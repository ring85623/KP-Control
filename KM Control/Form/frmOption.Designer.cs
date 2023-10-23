namespace WindowsFormsApplication1
{
    partial class frmOption
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblKeyDelay = new System.Windows.Forms.Label();
            this.lblMouseClkDelay = new System.Windows.Forms.Label();
            this.lblMouseMovDelay = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblRepeatDelay = new System.Windows.Forms.Label();
            this.txtKeyDelay = new System.Windows.Forms.TextBox();
            this.txtMouseClkDelay = new System.Windows.Forms.TextBox();
            this.txtMouseMovDelay = new System.Windows.Forms.TextBox();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.txtRepeatDelay = new System.Windows.Forms.TextBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblItemColorA = new System.Windows.Forms.Label();
            this.ItemColorB = new System.Windows.Forms.Label();
            this.btnItemColorA = new System.Windows.Forms.Button();
            this.btnItemColorB = new System.Windows.Forms.Button();
            this.tabSettingControl = new System.Windows.Forms.TabControl();
            this.tpgEnvirSetting = new System.Windows.Forms.TabPage();
            this.tpgColorSetting = new System.Windows.Forms.TabPage();
            this.btnRowSelectCol = new System.Windows.Forms.Button();
            this.lblRowSelectCol = new System.Windows.Forms.Label();
            this.tpgKeySetting = new System.Windows.Forms.TabPage();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.tabSettingControl.SuspendLayout();
            this.tpgEnvirSetting.SuspendLayout();
            this.tpgColorSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(12, 266);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 28);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "確定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(439, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblKeyDelay
            // 
            this.lblKeyDelay.AutoSize = true;
            this.lblKeyDelay.Location = new System.Drawing.Point(15, 17);
            this.lblKeyDelay.Name = "lblKeyDelay";
            this.lblKeyDelay.Size = new System.Drawing.Size(141, 20);
            this.lblKeyDelay.TabIndex = 2;
            this.lblKeyDelay.Text = "鍵盤按鍵延遲時間:";
            // 
            // lblMouseClkDelay
            // 
            this.lblMouseClkDelay.AutoSize = true;
            this.lblMouseClkDelay.Location = new System.Drawing.Point(15, 59);
            this.lblMouseClkDelay.Name = "lblMouseClkDelay";
            this.lblMouseClkDelay.Size = new System.Drawing.Size(141, 20);
            this.lblMouseClkDelay.TabIndex = 3;
            this.lblMouseClkDelay.Text = "滑鼠按鍵延遲時間:";
            // 
            // lblMouseMovDelay
            // 
            this.lblMouseMovDelay.AutoSize = true;
            this.lblMouseMovDelay.Location = new System.Drawing.Point(15, 101);
            this.lblMouseMovDelay.Name = "lblMouseMovDelay";
            this.lblMouseMovDelay.Size = new System.Drawing.Size(141, 20);
            this.lblMouseMovDelay.TabIndex = 4;
            this.lblMouseMovDelay.Text = "滑鼠移動延遲時間:";
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(79, 143);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(77, 20);
            this.lblRepeat.TabIndex = 5;
            this.lblRepeat.Text = "執行次數:";
            // 
            // lblRepeatDelay
            // 
            this.lblRepeatDelay.AutoSize = true;
            this.lblRepeatDelay.Location = new System.Drawing.Point(15, 185);
            this.lblRepeatDelay.Name = "lblRepeatDelay";
            this.lblRepeatDelay.Size = new System.Drawing.Size(141, 20);
            this.lblRepeatDelay.TabIndex = 6;
            this.lblRepeatDelay.Text = "執行次數延遲時間:";
            // 
            // txtKeyDelay
            // 
            this.txtKeyDelay.Location = new System.Drawing.Point(164, 14);
            this.txtKeyDelay.Name = "txtKeyDelay";
            this.txtKeyDelay.Size = new System.Drawing.Size(74, 29);
            this.txtKeyDelay.TabIndex = 7;
            this.txtKeyDelay.Tag = "KeyDelay";
            // 
            // txtMouseClkDelay
            // 
            this.txtMouseClkDelay.Location = new System.Drawing.Point(164, 56);
            this.txtMouseClkDelay.Name = "txtMouseClkDelay";
            this.txtMouseClkDelay.Size = new System.Drawing.Size(74, 29);
            this.txtMouseClkDelay.TabIndex = 8;
            this.txtMouseClkDelay.Tag = "MouseClkDelay";
            // 
            // txtMouseMovDelay
            // 
            this.txtMouseMovDelay.Location = new System.Drawing.Point(164, 98);
            this.txtMouseMovDelay.Name = "txtMouseMovDelay";
            this.txtMouseMovDelay.Size = new System.Drawing.Size(74, 29);
            this.txtMouseMovDelay.TabIndex = 9;
            this.txtMouseMovDelay.Tag = "MouseMovDelay";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(164, 140);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(74, 29);
            this.txtRepeat.TabIndex = 10;
            this.txtRepeat.Tag = "Repeat";
            // 
            // txtRepeatDelay
            // 
            this.txtRepeatDelay.Location = new System.Drawing.Point(164, 182);
            this.txtRepeatDelay.Name = "txtRepeatDelay";
            this.txtRepeatDelay.Size = new System.Drawing.Size(74, 29);
            this.txtRepeatDelay.TabIndex = 11;
            this.txtRepeatDelay.Tag = "RepeatDelay";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(244, 23);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(31, 20);
            this.lblUnit1.TabIndex = 12;
            this.lblUnit1.Text = "ms";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Location = new System.Drawing.Point(244, 190);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(31, 20);
            this.lblUnit5.TabIndex = 13;
            this.lblUnit5.Text = "ms";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(244, 148);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(25, 20);
            this.lblUnit4.TabIndex = 14;
            this.lblUnit4.Text = "次";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(244, 107);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(31, 20);
            this.lblUnit3.TabIndex = 15;
            this.lblUnit3.Text = "ms";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(244, 65);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(31, 20);
            this.lblUnit2.TabIndex = 16;
            this.lblUnit2.Text = "ms";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // lblItemColorA
            // 
            this.lblItemColorA.AutoSize = true;
            this.lblItemColorA.Location = new System.Drawing.Point(12, 20);
            this.lblItemColorA.Name = "lblItemColorA";
            this.lblItemColorA.Size = new System.Drawing.Size(88, 20);
            this.lblItemColorA.TabIndex = 17;
            this.lblItemColorA.Text = "列表A顏色:";
            // 
            // ItemColorB
            // 
            this.ItemColorB.AutoSize = true;
            this.ItemColorB.Location = new System.Drawing.Point(13, 55);
            this.ItemColorB.Name = "ItemColorB";
            this.ItemColorB.Size = new System.Drawing.Size(87, 20);
            this.ItemColorB.TabIndex = 18;
            this.ItemColorB.Text = "列表B顏色:";
            // 
            // btnItemColorA
            // 
            this.btnItemColorA.BackColor = System.Drawing.Color.LightYellow;
            this.btnItemColorA.Location = new System.Drawing.Point(113, 20);
            this.btnItemColorA.Name = "btnItemColorA";
            this.btnItemColorA.Size = new System.Drawing.Size(31, 23);
            this.btnItemColorA.TabIndex = 19;
            this.btnItemColorA.Tag = "ItemColorA";
            this.btnItemColorA.UseVisualStyleBackColor = false;
            this.btnItemColorA.Click += new System.EventHandler(this.btnBackColorChange);
            // 
            // btnItemColorB
            // 
            this.btnItemColorB.BackColor = System.Drawing.Color.LightGreen;
            this.btnItemColorB.Location = new System.Drawing.Point(113, 54);
            this.btnItemColorB.Name = "btnItemColorB";
            this.btnItemColorB.Size = new System.Drawing.Size(31, 23);
            this.btnItemColorB.TabIndex = 20;
            this.btnItemColorB.Tag = "ItemColorB";
            this.btnItemColorB.UseVisualStyleBackColor = false;
            this.btnItemColorB.Click += new System.EventHandler(this.btnBackColorChange);
            // 
            // tabSettingControl
            // 
            this.tabSettingControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettingControl.Controls.Add(this.tpgEnvirSetting);
            this.tabSettingControl.Controls.Add(this.tpgColorSetting);
            this.tabSettingControl.Controls.Add(this.tpgKeySetting);
            this.tabSettingControl.Location = new System.Drawing.Point(8, 8);
            this.tabSettingControl.Name = "tabSettingControl";
            this.tabSettingControl.SelectedIndex = 0;
            this.tabSettingControl.Size = new System.Drawing.Size(513, 252);
            this.tabSettingControl.TabIndex = 21;
            // 
            // tpgEnvirSetting
            // 
            this.tpgEnvirSetting.Controls.Add(this.lblKeyDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblMouseClkDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblMouseMovDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblRepeat);
            this.tpgEnvirSetting.Controls.Add(this.lblRepeatDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblUnit2);
            this.tpgEnvirSetting.Controls.Add(this.txtKeyDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblUnit3);
            this.tpgEnvirSetting.Controls.Add(this.txtMouseClkDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblUnit4);
            this.tpgEnvirSetting.Controls.Add(this.txtMouseMovDelay);
            this.tpgEnvirSetting.Controls.Add(this.lblUnit5);
            this.tpgEnvirSetting.Controls.Add(this.txtRepeat);
            this.tpgEnvirSetting.Controls.Add(this.lblUnit1);
            this.tpgEnvirSetting.Controls.Add(this.txtRepeatDelay);
            this.tpgEnvirSetting.Location = new System.Drawing.Point(4, 29);
            this.tpgEnvirSetting.Name = "tpgEnvirSetting";
            this.tpgEnvirSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEnvirSetting.Size = new System.Drawing.Size(505, 219);
            this.tpgEnvirSetting.TabIndex = 0;
            this.tpgEnvirSetting.Text = "環境設定";
            this.tpgEnvirSetting.UseVisualStyleBackColor = true;
            // 
            // tpgColorSetting
            // 
            this.tpgColorSetting.Controls.Add(this.btnBackColor);
            this.tpgColorSetting.Controls.Add(this.lblBackColor);
            this.tpgColorSetting.Controls.Add(this.btnRowSelectCol);
            this.tpgColorSetting.Controls.Add(this.lblRowSelectCol);
            this.tpgColorSetting.Controls.Add(this.lblItemColorA);
            this.tpgColorSetting.Controls.Add(this.btnItemColorB);
            this.tpgColorSetting.Controls.Add(this.ItemColorB);
            this.tpgColorSetting.Controls.Add(this.btnItemColorA);
            this.tpgColorSetting.Location = new System.Drawing.Point(4, 29);
            this.tpgColorSetting.Name = "tpgColorSetting";
            this.tpgColorSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgColorSetting.Size = new System.Drawing.Size(505, 219);
            this.tpgColorSetting.TabIndex = 1;
            this.tpgColorSetting.Text = "顏色設定";
            this.tpgColorSetting.UseVisualStyleBackColor = true;
            // 
            // btnRowSelectCol
            // 
            this.btnRowSelectCol.BackColor = System.Drawing.Color.LightGreen;
            this.btnRowSelectCol.Location = new System.Drawing.Point(113, 90);
            this.btnRowSelectCol.Name = "btnRowSelectCol";
            this.btnRowSelectCol.Size = new System.Drawing.Size(31, 23);
            this.btnRowSelectCol.TabIndex = 22;
            this.btnRowSelectCol.Tag = "RowSelectCol";
            this.btnRowSelectCol.UseVisualStyleBackColor = false;
            this.btnRowSelectCol.Click += new System.EventHandler(this.btnBackColorChange);
            // 
            // lblRowSelectCol
            // 
            this.lblRowSelectCol.AutoSize = true;
            this.lblRowSelectCol.Location = new System.Drawing.Point(23, 90);
            this.lblRowSelectCol.Name = "lblRowSelectCol";
            this.lblRowSelectCol.Size = new System.Drawing.Size(77, 20);
            this.lblRowSelectCol.TabIndex = 21;
            this.lblRowSelectCol.Text = "選擇顏色:";
            // 
            // tpgKeySetting
            // 
            this.tpgKeySetting.Location = new System.Drawing.Point(4, 29);
            this.tpgKeySetting.Name = "tpgKeySetting";
            this.tpgKeySetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpgKeySetting.Size = new System.Drawing.Size(505, 219);
            this.tpgKeySetting.TabIndex = 2;
            this.tpgKeySetting.Text = "按鍵設定";
            this.tpgKeySetting.UseVisualStyleBackColor = true;
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.LightGreen;
            this.btnBackColor.Location = new System.Drawing.Point(113, 127);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(31, 23);
            this.btnBackColor.TabIndex = 24;
            this.btnBackColor.Tag = "BackColor";
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColorChange);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(23, 127);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(77, 20);
            this.lblBackColor.TabIndex = 23;
            this.lblBackColor.Text = "背景顏色:";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.tabSettingControl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmOption";
            this.Text = "環境設置";
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.tabSettingControl.ResumeLayout(false);
            this.tpgEnvirSetting.ResumeLayout(false);
            this.tpgEnvirSetting.PerformLayout();
            this.tpgColorSetting.ResumeLayout(false);
            this.tpgColorSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblKeyDelay;
        private System.Windows.Forms.Label lblMouseClkDelay;
        private System.Windows.Forms.Label lblMouseMovDelay;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblRepeatDelay;
        private System.Windows.Forms.TextBox txtKeyDelay;
        private System.Windows.Forms.TextBox txtMouseClkDelay;
        private System.Windows.Forms.TextBox txtMouseMovDelay;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.TextBox txtRepeatDelay;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblItemColorA;
        private System.Windows.Forms.Label ItemColorB;
        private System.Windows.Forms.Button btnItemColorA;
        private System.Windows.Forms.Button btnItemColorB;
        private System.Windows.Forms.TabControl tabSettingControl;
        private System.Windows.Forms.TabPage tpgEnvirSetting;
        private System.Windows.Forms.TabPage tpgColorSetting;
        private System.Windows.Forms.TabPage tpgKeySetting;
        private System.Windows.Forms.Button btnRowSelectCol;
        private System.Windows.Forms.Label lblRowSelectCol;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lblBackColor;
    }
}

