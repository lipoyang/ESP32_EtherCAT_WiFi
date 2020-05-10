#if defined(ARDUINO_M5Stack_Core_ESP32)
#include <M5Stack.h>
#endif

// UDP通信用NIC初期化
void udpWiFiInit();
// UDP受信スレッド関数
void udpRecvFunc(void *arg);
// UDP送信スレッド関数
void udpSendFunc(void *arg);
// ロボットアーム制御
void robot_arm_ctrl();

// 初期化
void setup()
{
#if defined(ARDUINO_M5Stack_Core_ESP32)
    // M5Stack初期化
    M5.begin();
    // 適宜画面回転
    M5.Lcd.setRotation(3);
    // 画面描画
    M5.Lcd.setTextColor(GREEN);
    M5.Lcd.setTextSize(4);
    for(int i=0;i<4;i++){
      M5.Lcd.setCursor(30, 20+i*40);
      M5.Lcd.printf("Servo%d:", i+1);
    }
    M5.Lcd.setTextColor(YELLOW);
#endif
    
    Serial.begin(115200);
    Serial.println("EtherCAT-WiFi Gateway");
    
    // WiFi初期化
    udpWiFiInit();
    // 受信スレッド開始
    xTaskCreatePinnedToCore(udpRecvFunc, "udpRecv", 4096, NULL, 1, NULL, 1);
    // 送信スレッド開始
    xTaskCreatePinnedToCore(udpSendFunc, "udpSend", 4096, NULL, 1, NULL, 1);
}

// メインループ
void loop()
{
    // ロボットアーム制御
    robot_arm_ctrl();
}
