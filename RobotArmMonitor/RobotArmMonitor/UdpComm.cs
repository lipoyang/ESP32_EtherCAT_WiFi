using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // IPAddress, IPEndPoint
using System.Net.Sockets; // UdpClient
using System.Threading; // Thread
using System.Windows.Forms; // MessageBox

namespace RobotArmMonitor
{
    // UDP受信イベントハンドラ
    class UdpEventArgs : EventArgs
    {
        public byte[] data;
    }
    delegate void UdpEventHandler(object sender, UdpEventArgs e);

    // UDP通信
    class UdpComm
    {
        // ポート
        const int LOCAL_PORT  = 4001;
        const int REMOTE_PORT = 4002;
        // 受信スレッド
        Thread threadReceive;
        // フラグ
        bool isClosing = false;
        bool isOpen = false;

        // UDPクライアント
        UdpClient receiver;
        UdpClient sender;

        // UDP受信イベント
        public event UdpEventHandler onReceive;

        // 開く
        public bool Open(string localAddrStr, string remoteAddrStr)
        {
            if (isOpen) return false;

            try
            {
                // 受信用UDPクライアント
                IPAddress localAddress = IPAddress.Parse(localAddrStr);
                IPEndPoint localEP = new IPEndPoint(localAddress, LOCAL_PORT);
                receiver = new UdpClient(localEP);
                receiver.Client.ReceiveTimeout = 3000;
                // 受信スレッドの起動
                isClosing = false;
                threadReceive = new Thread(new ThreadStart(funcReceive));
                threadReceive.Start();

                // 送信用UDPクライアント
                sender = new UdpClient(remoteAddrStr, REMOTE_PORT);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "エラー");
                return false;
            }

            isOpen = true;
            return true;
        }

        // 閉じる
        public void Close()
        {
            if (!isOpen) return;
            isOpen = false;

            // 受信スレッドの終了待ち合わせ
            isClosing = true;
            threadReceive.Join();
            // 受信用UDPクライアントを閉じる
            receiver.Close();
            // 送信用UDPクライアントを閉じる
            sender.Close();
        }

        // 受信スレッドの関数
        private void funcReceive()
        {
            while (!isClosing)
            {
                try
                {
                    //データを受信する
                    IPEndPoint remoteEP = null;
                    byte[] rcvBytes = receiver.Receive(ref remoteEP);
                    //イベント発行
                    UdpEventArgs args = new UdpEventArgs();
                    args.data = rcvBytes;
                    onReceive(this, args);

                }
                catch
                {
                    //Console.WriteLine("receiving timeout");
                    ; // タイムアウト 特に何もしない
                }
            }
        }

        // 送信する
        public void Send(byte[] data)
        {
            if (!isOpen) return;

            //データを送信する
            sender.Send(data, data.Length);
        }
    }
}
