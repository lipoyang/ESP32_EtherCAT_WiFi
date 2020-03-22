using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.DirectInput;
using System.Windows.Forms; // MessageBox

namespace RobotArmMonitor
{
    // ゲームパッド入力値
    class GamepadInput
    {
        public int[] val = new int[4];
        public bool startButton = false;
    }

    // ゲームパッド入力
    class GamePad
    {
        // スタートボタンの番号 (ゲームパッド製品によって異なる)
        const int START_BUTTON = 12;

        // DirectInput
        DirectInput dinput = new DirectInput();
        // ゲームパッド
        Joystick joystick = null;
        // 使用するゲームパッドのID
        Guid joystickGuid = Guid.Empty;
        // ゲームパッドが利用可能か
        bool available = false;
        // スタートボタン前回値
        bool startButtonOld = false;

        // 初期化する
        public void Init()
        {
            // ゲームパッドからゲームパッドを取得する
            foreach (DeviceInstance device in dinput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                joystickGuid = device.InstanceGuid;
                break;
            }
            // ジョイスティックからゲームパッドを取得する
            if (joystickGuid == Guid.Empty)
            {
                foreach (DeviceInstance device in dinput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                {
                    joystickGuid = device.InstanceGuid;
                    break;
                }
            }
            // 見つかった場合
            if (joystickGuid != Guid.Empty)
            {
                // ゲームパッドの取得
                joystick?.Dispose();
                joystick = new Joystick(dinput, joystickGuid);
                if (joystick != null)
                {
                    // バッファサイズを指定
                    joystick.Properties.BufferSize = 128;

                    // ジョイスティックの軸の最小値と最大値を -1000～+1000に設定
                    foreach (DeviceObjectInstance deviceObject in joystick.GetObjects())
                    {
                        switch (deviceObject.ObjectId.Flags)
                        {
                            case DeviceObjectTypeFlags.Axis:
                            case DeviceObjectTypeFlags.AbsoluteAxis:
                            case DeviceObjectTypeFlags.RelativeAxis:
                                var ir = joystick.GetObjectPropertiesById(deviceObject.ObjectId);
                                if (ir != null)
                                {
                                    try
                                    {
                                        ir.Range = new InputRange(-1000, 1000);
                                        ir.Saturation = 10000;
                                        ir.DeadZone = 0;
                                    }
                                    catch (Exception) { }
                                }
                                break;
                        }
                    }
                    // ゲームパッド有効
                    available = true;
                }
                else
                {
                    MessageBox.Show("ゲームパッドが取得できません。");
                    available = false;
                }
            }
            else
            {
                MessageBox.Show("ゲームパッドがみつかりません。");
                available = false;
            }
        }

        // ゲームパッド入力処理
        // return: 押されたボタン
        public GamepadInput Get()
        {
            GamepadInput ret = new GamepadInput();

            if (!available) return ret;

            // キャプチャするデバイスを取得
            try
            {
                joystick.Acquire();
                joystick.Poll();
            }
            catch
            {
                joystick?.Dispose();
                joystick = null;
                MessageBox.Show("ゲームパッドが抜けました");
                available = false;
                return ret;
            }

            // ゲームパッドのデータ取得
            var jState = joystick.GetCurrentState();
            // 取得できない場合、処理終了
            if (jState == null) { return ret; }
            
            // アナログスティックの値
            ret.val[0] = jState.X;
            ret.val[1] = jState.Y;
            ret.val[2] = jState.Z;
            ret.val[3] = jState.RotationZ;
            
            // スタートボタンの立下り
            bool button = jState.Buttons[START_BUTTON - 1];
            ret.startButton = (!startButtonOld && button) ? true : false;
            startButtonOld = button;

            return ret;
        }
    }
}
