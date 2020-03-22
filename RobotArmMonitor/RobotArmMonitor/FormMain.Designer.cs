namespace RobotArmMonitor
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textLocalAddress = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textAD0 = new System.Windows.Forms.TextBox();
            this.textAD1 = new System.Windows.Forms.TextBox();
            this.textAD2 = new System.Windows.Forms.TextBox();
            this.textAD3 = new System.Windows.Forms.TextBox();
            this.textServo3 = new System.Windows.Forms.TextBox();
            this.textServo2 = new System.Windows.Forms.TextBox();
            this.textServo1 = new System.Windows.Forms.TextBox();
            this.textServo0 = new System.Windows.Forms.TextBox();
            this.textPad3 = new System.Windows.Forms.TextBox();
            this.textPad2 = new System.Windows.Forms.TextBox();
            this.textPad1 = new System.Windows.Forms.TextBox();
            this.textPad0 = new System.Windows.Forms.TextBox();
            this.buttonControl = new System.Windows.Forms.Button();
            this.labelCtrlState = new System.Windows.Forms.Label();
            this.buttonGamepad = new System.Windows.Forms.Button();
            this.textRemoteAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelConnectState = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "送信元IPアドレス";
            // 
            // textLocalAddress
            // 
            this.textLocalAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel.SetColumnSpan(this.textLocalAddress, 2);
            this.textLocalAddress.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textLocalAddress.Location = new System.Drawing.Point(269, 14);
            this.textLocalAddress.Name = "textLocalAddress";
            this.textLocalAddress.Size = new System.Drawing.Size(226, 34);
            this.textLocalAddress.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonConnect.AutoSize = true;
            this.buttonConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConnect.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.Location = new System.Drawing.Point(537, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(76, 37);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "接続";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(269, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "肩ヨー";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(403, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "肘ピッチ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(537, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "手首ピッチ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(671, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "指開閉";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "コントローラA/D値";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(3, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "サーボ指令値[deg]";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(3, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 27);
            this.label8.TabIndex = 9;
            this.label8.Text = "ゲームパッド入力値";
            // 
            // textAD0
            // 
            this.textAD0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textAD0.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAD0.Location = new System.Drawing.Point(269, 201);
            this.textAD0.Name = "textAD0";
            this.textAD0.Size = new System.Drawing.Size(100, 34);
            this.textAD0.TabIndex = 10;
            // 
            // textAD1
            // 
            this.textAD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textAD1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAD1.Location = new System.Drawing.Point(403, 201);
            this.textAD1.Name = "textAD1";
            this.textAD1.Size = new System.Drawing.Size(100, 34);
            this.textAD1.TabIndex = 11;
            // 
            // textAD2
            // 
            this.textAD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textAD2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAD2.Location = new System.Drawing.Point(537, 201);
            this.textAD2.Name = "textAD2";
            this.textAD2.Size = new System.Drawing.Size(100, 34);
            this.textAD2.TabIndex = 12;
            // 
            // textAD3
            // 
            this.textAD3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textAD3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textAD3.Location = new System.Drawing.Point(671, 201);
            this.textAD3.Name = "textAD3";
            this.textAD3.Size = new System.Drawing.Size(100, 34);
            this.textAD3.TabIndex = 13;
            // 
            // textServo3
            // 
            this.textServo3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textServo3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textServo3.Location = new System.Drawing.Point(671, 263);
            this.textServo3.Name = "textServo3";
            this.textServo3.Size = new System.Drawing.Size(100, 34);
            this.textServo3.TabIndex = 17;
            // 
            // textServo2
            // 
            this.textServo2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textServo2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textServo2.Location = new System.Drawing.Point(537, 263);
            this.textServo2.Name = "textServo2";
            this.textServo2.Size = new System.Drawing.Size(100, 34);
            this.textServo2.TabIndex = 16;
            // 
            // textServo1
            // 
            this.textServo1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textServo1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textServo1.Location = new System.Drawing.Point(403, 263);
            this.textServo1.Name = "textServo1";
            this.textServo1.Size = new System.Drawing.Size(100, 34);
            this.textServo1.TabIndex = 15;
            // 
            // textServo0
            // 
            this.textServo0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textServo0.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textServo0.Location = new System.Drawing.Point(269, 263);
            this.textServo0.Name = "textServo0";
            this.textServo0.Size = new System.Drawing.Size(100, 34);
            this.textServo0.TabIndex = 14;
            // 
            // textPad3
            // 
            this.textPad3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPad3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textPad3.Location = new System.Drawing.Point(671, 325);
            this.textPad3.Name = "textPad3";
            this.textPad3.Size = new System.Drawing.Size(100, 34);
            this.textPad3.TabIndex = 21;
            // 
            // textPad2
            // 
            this.textPad2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPad2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textPad2.Location = new System.Drawing.Point(537, 325);
            this.textPad2.Name = "textPad2";
            this.textPad2.Size = new System.Drawing.Size(100, 34);
            this.textPad2.TabIndex = 20;
            // 
            // textPad1
            // 
            this.textPad1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPad1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textPad1.Location = new System.Drawing.Point(403, 325);
            this.textPad1.Name = "textPad1";
            this.textPad1.Size = new System.Drawing.Size(100, 34);
            this.textPad1.TabIndex = 19;
            // 
            // textPad0
            // 
            this.textPad0.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textPad0.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textPad0.Location = new System.Drawing.Point(269, 325);
            this.textPad0.Name = "textPad0";
            this.textPad0.Size = new System.Drawing.Size(100, 34);
            this.textPad0.TabIndex = 18;
            // 
            // buttonControl
            // 
            this.buttonControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonControl.AutoSize = true;
            this.buttonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonControl.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonControl.Location = new System.Drawing.Point(3, 388);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(198, 37);
            this.buttonControl.TabIndex = 22;
            this.buttonControl.Text = "コントロール切替";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // labelCtrlState
            // 
            this.labelCtrlState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCtrlState.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelCtrlState, 2);
            this.labelCtrlState.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCtrlState.Location = new System.Drawing.Point(269, 393);
            this.labelCtrlState.Name = "labelCtrlState";
            this.labelCtrlState.Size = new System.Drawing.Size(138, 27);
            this.labelCtrlState.TabIndex = 23;
            this.labelCtrlState.Text = "リモートOFF";
            // 
            // buttonGamepad
            // 
            this.buttonGamepad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonGamepad.AutoSize = true;
            this.buttonGamepad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.SetColumnSpan(this.buttonGamepad, 2);
            this.buttonGamepad.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGamepad.Location = new System.Drawing.Point(537, 388);
            this.buttonGamepad.Name = "buttonGamepad";
            this.buttonGamepad.Size = new System.Drawing.Size(227, 37);
            this.buttonGamepad.TabIndex = 24;
            this.buttonGamepad.Text = "ゲームパッド再接続";
            this.buttonGamepad.UseVisualStyleBackColor = true;
            this.buttonGamepad.Click += new System.EventHandler(this.buttonGamepad_Click);
            // 
            // textRemoteAddress
            // 
            this.textRemoteAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel.SetColumnSpan(this.textRemoteAddress, 2);
            this.textRemoteAddress.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textRemoteAddress.Location = new System.Drawing.Point(269, 77);
            this.textRemoteAddress.Name = "textRemoteAddress";
            this.textRemoteAddress.Size = new System.Drawing.Size(226, 34);
            this.textRemoteAddress.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 27);
            this.label9.TabIndex = 26;
            this.label9.Text = "送信先IPアドレス";
            // 
            // labelConnectState
            // 
            this.labelConnectState.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConnectState.AutoSize = true;
            this.labelConnectState.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelConnectState.Location = new System.Drawing.Point(671, 18);
            this.labelConnectState.Name = "labelConnectState";
            this.labelConnectState.Size = new System.Drawing.Size(93, 27);
            this.labelConnectState.TabIndex = 27;
            this.labelConnectState.Text = "未接続";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15508F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71123F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71123F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71123F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71123F));
            this.tableLayoutPanel.Controls.Add(this.buttonGamepad, 3, 6);
            this.tableLayoutPanel.Controls.Add(this.textPad3, 4, 5);
            this.tableLayoutPanel.Controls.Add(this.textRemoteAddress, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textPad2, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.labelCtrlState, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.labelConnectState, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.textPad0, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.textServo3, 4, 4);
            this.tableLayoutPanel.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textServo2, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textServo1, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textServo0, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.textAD3, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonControl, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.textAD2, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textAD1, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.textAD0, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label4, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonConnect, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.textLocalAddress, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textPad1, 2, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.45168F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25805F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(804, 441);
            this.tableLayoutPanel.TabIndex = 28;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Robot Arm Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLocalAddress;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textAD0;
        private System.Windows.Forms.TextBox textAD1;
        private System.Windows.Forms.TextBox textAD2;
        private System.Windows.Forms.TextBox textAD3;
        private System.Windows.Forms.TextBox textServo3;
        private System.Windows.Forms.TextBox textServo2;
        private System.Windows.Forms.TextBox textServo1;
        private System.Windows.Forms.TextBox textServo0;
        private System.Windows.Forms.TextBox textPad3;
        private System.Windows.Forms.TextBox textPad2;
        private System.Windows.Forms.TextBox textPad1;
        private System.Windows.Forms.TextBox textPad0;
        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.Label labelCtrlState;
        private System.Windows.Forms.Button buttonGamepad;
        private System.Windows.Forms.TextBox textRemoteAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelConnectState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}

