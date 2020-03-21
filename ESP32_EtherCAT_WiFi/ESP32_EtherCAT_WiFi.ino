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
