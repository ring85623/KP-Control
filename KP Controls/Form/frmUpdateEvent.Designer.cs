namespace WindowsFormsApplication1
{
    partial class frmUpdateEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEvent));
            this.tabUpdateEvent = new System.Windows.Forms.TabControl();
            this.tpgMouseMoveSetting = new System.Windows.Forms.TabPage();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.tpgMouseClickSetting = new System.Windows.Forms.TabPage();
            this.txtMPosY = new System.Windows.Forms.TextBox();
            this.txtMPosX = new System.Windows.Forms.TextBox();
            this.lblMPosY = new System.Windows.Forms.Label();
            this.lblMPosX = new System.Windows.Forms.Label();
            this.lblClickMode = new System.Windows.Forms.Label();
            this.cobClickMode = new System.Windows.Forms.ComboBox();
            this.txtClickNumb = new System.Windows.Forms.TextBox();
            this.lblClickNumb = new System.Windows.Forms.Label();
            this.tpgKeyBoardSetting = new System.Windows.Forms.TabPage();
            this.lblKey = new System.Windows.Forms.Label();
            this.cobKey = new System.Windows.Forms.ComboBox();
            this.txtKeyNum = new System.Windows.Forms.TextBox();
            this.lblKeyNum = new System.Windows.Forms.Label();
            this.tpgDelayControl = new System.Windows.Forms.TabPage();
            this.lblDelayUnit = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.tpgLoopControl = new System.Windows.Forms.TabPage();
            this.txtLoopNum = new System.Windows.Forms.TextBox();
            this.lblLoopNum = new System.Windows.Forms.Label();
            this.tpgWinCode = new System.Windows.Forms.TabPage();
            this.btnSearchCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabUpdateEvent.SuspendLayout();
            this.tpgMouseMoveSetting.SuspendLayout();
            this.tpgMouseClickSetting.SuspendLayout();
            this.tpgKeyBoardSetting.SuspendLayout();
            this.tpgDelayControl.SuspendLayout();
            this.tpgLoopControl.SuspendLayout();
            this.tpgWinCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUpdateEvent
            // 
            this.tabUpdateEvent.Controls.Add(this.tpgMouseMoveSetting);
            this.tabUpdateEvent.Controls.Add(this.tpgMouseClickSetting);
            this.tabUpdateEvent.Controls.Add(this.tpgKeyBoardSetting);
            this.tabUpdateEvent.Controls.Add(this.tpgDelayControl);
            this.tabUpdateEvent.Controls.Add(this.tpgLoopControl);
            this.tabUpdateEvent.Controls.Add(this.tpgWinCode);
            this.tabUpdateEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUpdateEvent.Location = new System.Drawing.Point(0, 0);
            this.tabUpdateEvent.Name = "tabUpdateEvent";
            this.tabUpdateEvent.SelectedIndex = 0;
            this.tabUpdateEvent.Size = new System.Drawing.Size(284, 171);
            this.tabUpdateEvent.TabIndex = 0;
            // 
            // tpgMouseMoveSetting
            // 
            this.tpgMouseMoveSetting.Controls.Add(this.txtPosY);
            this.tpgMouseMoveSetting.Controls.Add(this.txtPosX);
            this.tpgMouseMoveSetting.Controls.Add(this.lblPosY);
            this.tpgMouseMoveSetting.Controls.Add(this.lblPosX);
            this.tpgMouseMoveSetting.Location = new System.Drawing.Point(4, 26);
            this.tpgMouseMoveSetting.Name = "tpgMouseMoveSetting";
            this.tpgMouseMoveSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMouseMoveSetting.Size = new System.Drawing.Size(276, 141);
            this.tpgMouseMoveSetting.TabIndex = 0;
            this.tpgMouseMoveSetting.Text = "tabPage1";
            this.tpgMouseMoveSetting.UseVisualStyleBackColor = true;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(105, 59);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(97, 25);
            this.txtPosY.TabIndex = 9;
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(105, 18);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(97, 25);
            this.txtPosX.TabIndex = 8;
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(70, 63);
            this.lblPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(19, 17);
            this.lblPosY.TabIndex = 7;
            this.lblPosY.Text = "Y:";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(70, 21);
            this.lblPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(19, 17);
            this.lblPosX.TabIndex = 6;
            this.lblPosX.Text = "X:";
            // 
            // tpgMouseClickSetting
            // 
            this.tpgMouseClickSetting.Controls.Add(this.txtMPosY);
            this.tpgMouseClickSetting.Controls.Add(this.txtMPosX);
            this.tpgMouseClickSetting.Controls.Add(this.lblMPosY);
            this.tpgMouseClickSetting.Controls.Add(this.lblMPosX);
            this.tpgMouseClickSetting.Controls.Add(this.lblClickMode);
            this.tpgMouseClickSetting.Controls.Add(this.cobClickMode);
            this.tpgMouseClickSetting.Controls.Add(this.txtClickNumb);
            this.tpgMouseClickSetting.Controls.Add(this.lblClickNumb);
            this.tpgMouseClickSetting.Location = new System.Drawing.Point(4, 26);
            this.tpgMouseClickSetting.Name = "tpgMouseClickSetting";
            this.tpgMouseClickSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMouseClickSetting.Size = new System.Drawing.Size(276, 141);
            this.tpgMouseClickSetting.TabIndex = 1;
            this.tpgMouseClickSetting.Text = "tabPage2";
            this.tpgMouseClickSetting.UseVisualStyleBackColor = true;
            // 
            // txtMPosY
            // 
            this.txtMPosY.Location = new System.Drawing.Point(179, 57);
            this.txtMPosY.Name = "txtMPosY";
            this.txtMPosY.Size = new System.Drawing.Size(89, 25);
            this.txtMPosY.TabIndex = 17;
            // 
            // txtMPosX
            // 
            this.txtMPosX.Location = new System.Drawing.Point(179, 24);
            this.txtMPosX.Name = "txtMPosX";
            this.txtMPosX.Size = new System.Drawing.Size(89, 25);
            this.txtMPosX.TabIndex = 16;
            // 
            // lblMPosY
            // 
            this.lblMPosY.AutoSize = true;
            this.lblMPosY.Location = new System.Drawing.Point(151, 62);
            this.lblMPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPosY.Name = "lblMPosY";
            this.lblMPosY.Size = new System.Drawing.Size(19, 17);
            this.lblMPosY.TabIndex = 15;
            this.lblMPosY.Text = "Y:";
            // 
            // lblMPosX
            // 
            this.lblMPosX.AutoSize = true;
            this.lblMPosX.Location = new System.Drawing.Point(151, 27);
            this.lblMPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMPosX.Name = "lblMPosX";
            this.lblMPosX.Size = new System.Drawing.Size(19, 17);
            this.lblMPosX.TabIndex = 14;
            this.lblMPosX.Text = "X:";
            // 
            // lblClickMode
            // 
            this.lblClickMode.AutoSize = true;
            this.lblClickMode.Location = new System.Drawing.Point(15, 27);
            this.lblClickMode.Name = "lblClickMode";
            this.lblClickMode.Size = new System.Drawing.Size(40, 17);
            this.lblClickMode.TabIndex = 13;
            this.lblClickMode.Text = "模式 :";
            // 
            // cobClickMode
            // 
            this.cobClickMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobClickMode.FormattingEnabled = true;
            this.cobClickMode.Items.AddRange(new object[] {
            "左鍵",
            "右鍵",
            "中鍵"});
            this.cobClickMode.Location = new System.Drawing.Point(61, 24);
            this.cobClickMode.Name = "cobClickMode";
            this.cobClickMode.Size = new System.Drawing.Size(74, 25);
            this.cobClickMode.TabIndex = 12;
            // 
            // txtClickNumb
            // 
            this.txtClickNumb.Location = new System.Drawing.Point(61, 57);
            this.txtClickNumb.Name = "txtClickNumb";
            this.txtClickNumb.Size = new System.Drawing.Size(74, 25);
            this.txtClickNumb.TabIndex = 11;
            this.txtClickNumb.Text = "1";
            // 
            // lblClickNumb
            // 
            this.lblClickNumb.AutoSize = true;
            this.lblClickNumb.Location = new System.Drawing.Point(15, 62);
            this.lblClickNumb.Name = "lblClickNumb";
            this.lblClickNumb.Size = new System.Drawing.Size(40, 17);
            this.lblClickNumb.TabIndex = 10;
            this.lblClickNumb.Text = "次數 :";
            // 
            // tpgKeyBoardSetting
            // 
            this.tpgKeyBoardSetting.Controls.Add(this.lblKey);
            this.tpgKeyBoardSetting.Controls.Add(this.cobKey);
            this.tpgKeyBoardSetting.Controls.Add(this.txtKeyNum);
            this.tpgKeyBoardSetting.Controls.Add(this.lblKeyNum);
            this.tpgKeyBoardSetting.Location = new System.Drawing.Point(4, 26);
            this.tpgKeyBoardSetting.Name = "tpgKeyBoardSetting";
            this.tpgKeyBoardSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgKeyBoardSetting.Size = new System.Drawing.Size(276, 141);
            this.tpgKeyBoardSetting.TabIndex = 2;
            this.tpgKeyBoardSetting.Text = "tabPage1";
            this.tpgKeyBoardSetting.UseVisualStyleBackColor = true;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(71, 25);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(40, 17);
            this.lblKey.TabIndex = 19;
            this.lblKey.Text = "按鍵 :";
            // 
            // cobKey
            // 
            this.cobKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobKey.FormattingEnabled = true;
            this.cobKey.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F10",
            "F11",
            "F12"});
            this.cobKey.Location = new System.Drawing.Point(117, 21);
            this.cobKey.Name = "cobKey";
            this.cobKey.Size = new System.Drawing.Size(74, 25);
            this.cobKey.TabIndex = 18;
            // 
            // txtKeyNum
            // 
            this.txtKeyNum.Location = new System.Drawing.Point(117, 55);
            this.txtKeyNum.Name = "txtKeyNum";
            this.txtKeyNum.Size = new System.Drawing.Size(74, 25);
            this.txtKeyNum.TabIndex = 17;
            this.txtKeyNum.Text = "1";
            // 
            // lblKeyNum
            // 
            this.lblKeyNum.AutoSize = true;
            this.lblKeyNum.Location = new System.Drawing.Point(71, 60);
            this.lblKeyNum.Name = "lblKeyNum";
            this.lblKeyNum.Size = new System.Drawing.Size(40, 17);
            this.lblKeyNum.TabIndex = 16;
            this.lblKeyNum.Text = "次數 :";
            // 
            // tpgDelayControl
            // 
            this.tpgDelayControl.Controls.Add(this.lblDelayUnit);
            this.tpgDelayControl.Controls.Add(this.txtDelay);
            this.tpgDelayControl.Controls.Add(this.lblDelay);
            this.tpgDelayControl.Location = new System.Drawing.Point(4, 26);
            this.tpgDelayControl.Name = "tpgDelayControl";
            this.tpgDelayControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDelayControl.Size = new System.Drawing.Size(276, 141);
            this.tpgDelayControl.TabIndex = 3;
            this.tpgDelayControl.Text = "tabPage1";
            this.tpgDelayControl.UseVisualStyleBackColor = true;
            // 
            // lblDelayUnit
            // 
            this.lblDelayUnit.AutoSize = true;
            this.lblDelayUnit.Location = new System.Drawing.Point(173, 46);
            this.lblDelayUnit.Name = "lblDelayUnit";
            this.lblDelayUnit.Size = new System.Drawing.Size(26, 17);
            this.lblDelayUnit.TabIndex = 15;
            this.lblDelayUnit.Text = "ms";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(114, 40);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(56, 25);
            this.txtDelay.TabIndex = 14;
            this.txtDelay.Text = "1";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(68, 44);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(40, 17);
            this.lblDelay.TabIndex = 13;
            this.lblDelay.Text = "時間 :";
            // 
            // tpgLoopControl
            // 
            this.tpgLoopControl.Controls.Add(this.txtLoopNum);
            this.tpgLoopControl.Controls.Add(this.lblLoopNum);
            this.tpgLoopControl.Location = new System.Drawing.Point(4, 26);
            this.tpgLoopControl.Name = "tpgLoopControl";
            this.tpgLoopControl.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLoopControl.Size = new System.Drawing.Size(276, 141);
            this.tpgLoopControl.TabIndex = 4;
            this.tpgLoopControl.Text = "tabPage1";
            this.tpgLoopControl.UseVisualStyleBackColor = true;
            // 
            // txtLoopNum
            // 
            this.txtLoopNum.Location = new System.Drawing.Point(120, 42);
            this.txtLoopNum.Name = "txtLoopNum";
            this.txtLoopNum.Size = new System.Drawing.Size(74, 25);
            this.txtLoopNum.TabIndex = 10;
            this.txtLoopNum.Text = "1";
            // 
            // lblLoopNum
            // 
            this.lblLoopNum.AutoSize = true;
            this.lblLoopNum.Location = new System.Drawing.Point(74, 46);
            this.lblLoopNum.Name = "lblLoopNum";
            this.lblLoopNum.Size = new System.Drawing.Size(40, 17);
            this.lblLoopNum.TabIndex = 9;
            this.lblLoopNum.Text = "次數 :";
            // 
            // tpgWinCode
            // 
            this.tpgWinCode.Controls.Add(this.btnSearchCode);
            this.tpgWinCode.Controls.Add(this.txtCode);
            this.tpgWinCode.Controls.Add(this.lblCode);
            this.tpgWinCode.Location = new System.Drawing.Point(4, 26);
            this.tpgWinCode.Name = "tpgWinCode";
            this.tpgWinCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpgWinCode.Size = new System.Drawing.Size(276, 141);
            this.tpgWinCode.TabIndex = 5;
            this.tpgWinCode.Text = "tabPage1";
            this.tpgWinCode.UseVisualStyleBackColor = true;
            // 
            // btnSearchCode
            // 
            this.btnSearchCode.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCode.Image")));
            this.btnSearchCode.Location = new System.Drawing.Point(199, 43);
            this.btnSearchCode.Name = "btnSearchCode";
            this.btnSearchCode.Size = new System.Drawing.Size(34, 23);
            this.btnSearchCode.TabIndex = 24;
            this.btnSearchCode.Tag = "";
            this.btnSearchCode.UseVisualStyleBackColor = true;
            this.btnSearchCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSearchCode_MouseDown);
            this.btnSearchCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSearchCode_MouseUp);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(89, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(104, 25);
            this.txtCode.TabIndex = 23;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(43, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 17);
            this.lblCode.TabIndex = 22;
            this.lblCode.Text = "代碼 :";
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(284, 25);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "調整設定：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(8, 139);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(203, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.tabUpdateEvent);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "項目更新介面";
            this.Load += new System.EventHandler(this.frmUpdateEvent_Load);
            this.tabUpdateEvent.ResumeLayout(false);
            this.tpgMouseMoveSetting.ResumeLayout(false);
            this.tpgMouseMoveSetting.PerformLayout();
            this.tpgMouseClickSetting.ResumeLayout(false);
            this.tpgMouseClickSetting.PerformLayout();
            this.tpgKeyBoardSetting.ResumeLayout(false);
            this.tpgKeyBoardSetting.PerformLayout();
            this.tpgDelayControl.ResumeLayout(false);
            this.tpgDelayControl.PerformLayout();
            this.tpgLoopControl.ResumeLayout(false);
            this.tpgLoopControl.PerformLayout();
            this.tpgWinCode.ResumeLayout(false);
            this.tpgWinCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabUpdateEvent;
        private System.Windows.Forms.TabPage tpgMouseMoveSetting;
        private System.Windows.Forms.TabPage tpgMouseClickSetting;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tpgKeyBoardSetting;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Label lblClickMode;
        private System.Windows.Forms.ComboBox cobClickMode;
        private System.Windows.Forms.TextBox txtClickNumb;
        private System.Windows.Forms.Label lblClickNumb;
        private System.Windows.Forms.TextBox txtMPosY;
        private System.Windows.Forms.TextBox txtMPosX;
        private System.Windows.Forms.Label lblMPosY;
        private System.Windows.Forms.Label lblMPosX;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cobKey;
        private System.Windows.Forms.TextBox txtKeyNum;
        private System.Windows.Forms.Label lblKeyNum;
        private System.Windows.Forms.TabPage tpgDelayControl;
        private System.Windows.Forms.Label lblDelayUnit;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.TabPage tpgLoopControl;
        private System.Windows.Forms.TextBox txtLoopNum;
        private System.Windows.Forms.Label lblLoopNum;
        private System.Windows.Forms.TabPage tpgWinCode;
        private System.Windows.Forms.Button btnSearchCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
    }
}