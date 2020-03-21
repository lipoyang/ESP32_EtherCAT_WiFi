#include <stdio.h>
#include <string.h>

#include <Arduino.h>
#include <freertos/FreeRTOS.h>
#include <WiFi.h>
#include <ESPmDNS.h>
#include <WiFiUDP.h>

// APのSSIDとパスワード
static const char *SSID = "hogehoge";
static const char *PASS = "piyopiyo";

// グローバル変数
WiFiUDP udp; // UDP通信用
SemaphoreHandle_t g_mutex; // ミューテックス
uint8_t  g_servo[4];    // サーボ目標角度     (MANGO→PC)
uint16_t g_volume[4];   // ボリューム入力値   (MANGO→PC)
int16_t  g_gamepad[4];  // ゲームパッド入力値 (MANGO←PC)
bool g_remoteOn = false; // 遠隔操作ONフラグ
int g_init_cnt = 0;      // 初期動作カウンタ
bool g_init_flag = true; // 初期動作フラグ

// 自ホスト(マイコン)のIPアドレスとポート番号
static IPAddress localAddress;
static const uint16_t LocalPort = 4002;

// 相手ホスト(PC)のIPアドレスとポート番号
static IPAddress remoteAddress;
static const uint16_t RemotePort = 4001;

// 無効なIPアドレス
static const IPAddress NULL_ADDR(0,0,0,0);

// 生存応答コマンド送信リクエストフラグ
static bool reqAliveCommand = false;

// UDP通信用NIC初期化
void udpWiFiInit()
{
    g_mutex = xSemaphoreCreateMutex();
    
    WiFi.mode(WIFI_STA);
    WiFi.begin(SSID, PASS);
    printf("WiFi started!\n");
    
    // wait for connecting to AP
    while (WiFi.status() != WL_CONNECTED) {
      vTaskDelay(500 / portTICK_PERIOD_MS);
      Serial.print(".");
    }
    // get my own IP address
    localAddress = WiFi.localIP();
    Serial.println("Connected to AP!");
    Serial.print("STA IP address: "); Serial.println(localAddress);
    remoteAddress = NULL_ADDR;
  
    // begin UDP
    udp.begin(LocalPort);
}

// UDP送信スレッド関数
void udpSendFunc(void *arg)
{
    printf("udpSendFunc start!\n");
    
    // メインループ
    while(true){
    	xSemaphoreTake(g_mutex, portMAX_DELAY);
    	IPAddress addr = remoteAddress;
    	xSemaphoreGive(g_mutex);
    	if(addr == NULL_ADDR) continue;
        // 送信
        static int cnt = 0;
        cnt++;
        if(cnt>=10){
            cnt = 0;
            // Dコマンド送信
            uint8_t send_buf[15];
            send_buf[0] = '#';
            send_buf[1] = 'D';
            xSemaphoreTake(g_mutex, portMAX_DELAY);
            for(int i=0;i<4;i++){
                send_buf[2 + i*2] = (uint8_t)(g_volume[i] >> 8);
                send_buf[3 + i*2] = (uint8_t)(g_volume[i] & 0xFF);
                send_buf[10 + i] = g_servo[i];
            }
            xSemaphoreGive(g_mutex);
            send_buf[14] = '$';
            //printf("send D\n");
            // 送信
            udp.beginPacket(remoteAddress, RemotePort);
            udp.write(send_buf, strlen((const char*)send_buf));
            udp.endPacket();
        }
        if(reqAliveCommand){
            reqAliveCommand = false;
            // Aコマンド送信
            uint8_t send_buf[3];
            send_buf[0] = '#';
            send_buf[1] = 'A';
            send_buf[2] = '$';
            printf("send A\n");
            // 送信
            udp.beginPacket(remoteAddress, RemotePort);
            udp.write(send_buf, strlen((const char*)send_buf));
            udp.endPacket();
        }
        vTaskDelay(10 / portTICK_PERIOD_MS);
    }
}

// UDP受信スレッド関数
void udpRecvFunc(void *arg)
{
    static uint8_t recv_buf[256];
    printf("udpRecvFunc start\n");
    
    while(true)
    {
        // 受信があったら
        int n = udp.parsePacket();
        if (n) {
            if(n > sizeof(recv_buf)){
                n = sizeof(recv_buf);
            }
            udp.read(recv_buf, n);
            udp.flush();
            xSemaphoreTake(g_mutex, portMAX_DELAY);
            remoteAddress = udp.remoteIP();
            xSemaphoreGive(g_mutex);
            //printf("received %d byte\n", n);
            if(recv_buf[0] == '#')
            {
                switch(recv_buf[1]){
                    case 'A':
                        if(n < 3){
                            printf("A: Bad Size %d\n", n);
                            break;
                        }
                        if(recv_buf[2] == '$'){
                            reqAliveCommand = true;
                            printf("A: Received!\n");
                        }else{
                            printf("A: Bad Tail Code %02X\n", recv_buf[2]);
                        }
                        break;
                    case 'R':
                        if(n < 4){
                            printf("R: Bad Size %d\n", n);
                            break;
                        }
                        if(recv_buf[3] == '$'){
                            uint8_t remoteOn = recv_buf[2];
                            xSemaphoreTake(g_mutex, portMAX_DELAY);
                            if(remoteOn == 0){
                                g_remoteOn = false;
                                g_init_cnt = 0;
                                g_init_flag = true;
                                //printf("R: OFF!\n");
                            }else if(remoteOn == 1)
                            {
                                g_remoteOn = true;
                                //g_init_cnt = 0;
                                //g_init_flag = true;
                                //printf("R: ON!\n");
                            }else{
                                printf("R: Bad Parameter %02X\n", remoteOn);
                            }
                            xSemaphoreGive(g_mutex);
                        }else{
                            printf("R: Bad Tail Code %02X\n", recv_buf[3]);
                        }
                        break;
                    case 'C':
                        if(n < 11){
                            printf("C: Bad Size %d\n", n);
                            break;
                        }
                        if(recv_buf[10] == '$'){
                            xSemaphoreTake(g_mutex, portMAX_DELAY);
                            for(int i=0;i<4;i++){
                                g_gamepad[i] = (int16_t)(
                                    ((uint16_t)recv_buf[2 + 2*i] << 8) | (uint16_t)recv_buf[3 + 2*i]
                                );
                            }
                            xSemaphoreGive(g_mutex);
                            printf("C: %4d, %4d, %4d, %4d\n", g_gamepad[0], g_gamepad[1], g_gamepad[2], g_gamepad[3]);
                        }else{
                            printf("C: Bad Tail Code %02X\n", recv_buf[10]);
                        }
                        break;
                    default:
                        printf("Unknown Command %02X\n", recv_buf[1]);
                        break;
                }
            }else{
                printf("Bad Head Code %02X", recv_buf[0]);
            }
        }
    }
}
