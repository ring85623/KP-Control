namespace InputManager_Example
{
    partial class MainDisplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDisplay));
            this.btnRecord = new System.Windows.Forms.Button();
            this.lstEventLog = new System.Windows.Forms.ListBox();
            this.ctmusControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.TimeMouseMv = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMouseAutoPos = new System.Windows.Forms.Label();
            this.tabEventCtl = new System.Windows.Forms.TabControl();
            this.tpgMouseEvent = new System.Windows.Forms.TabPage();
            this.txtMPosY = new System.Windows.Forms.TextBox();
            this.txtMPosX = new System.Windows.Forms.TextBox();
            this.lblMPosY = new System.Windows.Forms.Label();
            this.lblMPosX = new System.Windows.Forms.Label();
            this.btnMouseClickIns = new System.Windows.Forms.Button();
            this.btnMousePosIns = new System.Windows.Forms.Button();
            this.lblClickMode = new System.Windows.Forms.Label();
            this.cobClickMode = new System.Windows.Forms.ComboBox();
            this.txtClickNumb = new System.Windows.Forms.TextBox();
            this.lblClickNumb = new System.Windows.Forms.Label();
            this.lblMouseClick = new System.Windows.Forms.Label();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.lblYPos = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.lblMouseMove = new System.Windows.Forms.Label();
            this.tpgKeyEvent = new System.Windows.Forms.TabPage();
            this.txtBkKeyNum = new System.Windows.Forms.TextBox();
            this.lblBkKeyNum = new System.Windows.Forms.Label();
            this.btnBkKeyIns = new System.Windows.Forms.Button();
            this.lblBkKey = new System.Windows.Forms.Label();
            this.cobBkKey = new System.Windows.Forms.ComboBox();
            this.lblBkKeyEvent = new System.Windows.Forms.Label();
            this.btnKeyIns = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.cobKey = new System.Windows.Forms.ComboBox();
            this.txtKeyNum = new System.Windows.Forms.TextBox();
            this.lblKeyNum = new System.Windows.Forms.Label();
            this.lblKeyEvent = new System.Windows.Forms.Label();
            this.tpgContrlEvent = new System.Windows.Forms.TabPage();
            this.btnWinCodeIns = new System.Windows.Forms.Button();
            this.btnSearchCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblWinCode = new System.Windows.Forms.Label();
            this.btnDelayIns = new System.Windows.Forms.Button();
            this.btnLoopIns = new System.Windows.Forms.Button();
            this.lblDelayUnit = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblDelayEvent = new System.Windows.Forms.Label();
            this.txtLoopNum = new System.Windows.Forms.TextBox();
            this.lblLoopNum = new System.Windows.Forms.Label();
            this.lblLoopEvent = new System.Windows.Forms.Label();
            this.menuControl = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSysOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDescription = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKeyDesc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpControlEvent = new System.Windows.Forms.GroupBox();
            this.btnlstDown = new System.Windows.Forms.Button();
            this.btnlstUp = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctmusNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNotEnSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRecord = new System.Windows.Forms.TabControl();
            this.tabItemSet = new System.Windows.Forms.TabPage();
            this.tabItemWrite = new System.Windows.Forms.TabPage();
            this.txtItemWrite = new System.Windows.Forms.TextBox();
            this.ctmusControl.SuspendLayout();
            this.tabEventCtl.SuspendLayout();
            this.tpgMouseEvent.SuspendLayout();
            this.tpgKeyEvent.SuspendLayout();
            this.tpgContrlEvent.SuspendLayout();
            this.menuControl.SuspendLayout();
            this.grpControlEvent.SuspendLayout();
            this.ctmusNotify.SuspendLayout();
            this.tabRecord.SuspendLayout();
            this.tabItemSet.SuspendLayout();
            this.tabItemWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(183, 37);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(100, 33);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "錄製";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lstEventLog
            // 
            this.lstEventLog.BackColor = System.Drawing.Color.PapayaWhip;
            this.lstEventLog.ContextMenuStrip = this.ctmusControl;
            this.lstEventLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEventLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstEventLog.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
            this.lstEventLog.FormattingEnabled = true;
            this.lstEventLog.ItemHeight = 24;
            this.lstEventLog.Location = new System.Drawing.Point(3, 3);
            this.lstEventLog.Margin = new System.Windows.Forms.Padding(4);
            this.lstEventLog.Name = "lstEventLog";
            this.lstEventLog.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstEventLog.Size = new System.Drawing.Size(606, 398);
            this.lstEventLog.TabIndex = 2;
            this.lstEventLog.Click += new System.EventHandler(this.lstEventLog_Click);
            this.lstEventLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstEventLog_DrawItem);
            //this.lstEventLog.SelectedIndexChanged += new System.EventHandler(this.lstEventLog_SelectedIndexChanged);
            this.lstEventLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstEventLog_DragDrop);
            this.lstEventLog.DragOver += new System.Windows.Forms.DragEventHandler(this.lstEventLog_DragOver);
            this.lstEventLog.DoubleClick += new System.EventHandler(this.lstEventLog_DoubleClick);
            this.lstEventLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstEventLog_MouseDown);
            // 
            // ctmusControl
            // 
            this.ctmusControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete});
            this.ctmusControl.Name = "ctmusControl";
            this.ctmusControl.Size = new System.Drawing.Size(99, 70);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCopy.Image")));
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(98, 22);
            this.tsmiCopy.Text = "複製";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPaste.Image")));
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(98, 22);
            this.tsmiPaste.Text = "貼上";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(98, 22);
            this.tsmiDelete.Text = "刪除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(291, 37);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 33);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "執行";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(187, 33);
            this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 17);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(187, 58);
            this.lblY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(19, 17);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // TimeMouseMv
            // 
            this.TimeMouseMv.Tick += new System.EventHandler(this.TimeMouseMv_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(399, 37);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "清除結果";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMouseAutoPos
            // 
            this.lblMouseAutoPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMouseAutoPos.AutoSize = true;
            this.lblMouseAutoPos.Location = new System.Drawing.Point(81, 46);
            this.lblMouseAutoPos.Name = "lblMouseAutoPos";
            this.lblMouseAutoPos.Size = new System.Drawing.Size(99, 17);
            this.lblMouseAutoPos.TabIndex = 7;
            this.lblMouseAutoPos.Text = "滑鼠座標位置：";
            // 
            // tabEventCtl
            // 
            this.tabEventCtl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabEventCtl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabEventCtl.Controls.Add(this.tpgMouseEvent);
            this.tabEventCtl.Controls.Add(this.tpgKeyEvent);
            this.tabEventCtl.Controls.Add(this.tpgContrlEvent);
            this.tabEventCtl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabEventCtl.Location = new System.Drawing.Point(1, 34);
            this.tabEventCtl.Multiline = true;
            this.tabEventCtl.Name = "tabEventCtl";
            this.tabEventCtl.SelectedIndex = 0;
            this.tabEventCtl.Size = new System.Drawing.Size(172, 477);
            this.tabEventCtl.TabIndex = 8;
            this.tabEventCtl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabEventCtl_DrawItem);
            // 
            // tpgMouseEvent
            // 
            this.tpgMouseEvent.Controls.Add(this.txtMPosY);
            this.tpgMouseEvent.Controls.Add(this.txtMPosX);
            this.tpgMouseEvent.Controls.Add(this.lblMPosY);
            this.tpgMouseEvent.Controls.Add(this.lblMPosX);
            this.tpgMouseEvent.Controls.Add(this.btnMouseClickIns);
            this.tpgMouseEvent.Controls.Add(this.btnMousePosIns);
            this.tpgMouseEvent.Controls.Add(this.lblClickMode);
            this.tpgMouseEvent.Controls.Add(this.cobClickMode);
            this.tpgMouseEvent.Controls.Add(this.txtClickNumb);
            this.tpgMouseEvent.Controls.Add(this.lblClickNumb);
            this.tpgMouseEvent.Controls.Add(this.lblMouseClick);
            this.tpgMouseEvent.Controls.Add(this.txtYPos);
            this.tpgMouseEvent.Controls.Add(this.txtXPos);
            this.tpgMouseEvent.Controls.Add(this.lblYPos);
            this.tpgMouseEvent.Controls.Add(this.lblXPos);
            this.tpgMouseEvent.Controls.Add(this.lblMouseMove);
            this.tpgMouseEvent.Location = new System.Drawing.Point(28, 4);
            this.tpgMouseEvent.Name = "tpgMouseEvent";
            this.tpgMouseEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgMouseEvent.Size = new System.Drawing.Size(140, 469);
            this.tpgMouseEvent.TabIndex = 0;
            this.tpgMouseEvent.Text = "滑鼠控制";
            this.tpgMouseEvent.UseVisualStyleBackColor = true;
            // 
            // txtMPosY
            // 
            this.txtMPosY.Location = new System.Drawing.Point(54, 206);
            this.txtMPosY.Name = "txtMPosY";
            this.txtMPosY.Size = new System.Drawing.Size(74, 25);
            this.txtMPosY.TabIndex = 15;
            // 
            // txtMPosX
            // 
            this.txtMPosX.Location = new System.Drawing.Point(54, 175);
            this.txtMPosX.Name = "txtMPosX";
            this.txtMPosX.Size = new System.Drawing.Size(74, 25);
            this.txtMPosX.TabIndex = 14;
            // 
            // lblMPosY
            // 
            this.lblMPosY.AutoSize = true;
            this.lblMPosY.Location = new System.Drawing.Point(22, 210);
            this.lblMPosY.Name = "lblMPosY";
            this.lblMPosY.Size = new System.Drawing.Size(22, 17);
            this.lblMPosY.TabIndex = 13;
            this.lblMPosY.Text = "Y :";
            // 
            // lblMPosX
            // 
            this.lblMPosX.AutoSize = true;
            this.lblMPosX.Location = new System.Drawing.Point(22, 178);
            this.lblMPosX.Name = "lblMPosX";
            this.lblMPosX.Size = new System.Drawing.Size(22, 17);
            this.lblMPosX.TabIndex = 12;
            this.lblMPosX.Text = "X :";
            // 
            // btnMouseClickIns
            // 
            this.btnMouseClickIns.Image = ((System.Drawing.Image)(resources.GetObject("btnMouseClickIns.Image")));
            this.btnMouseClickIns.Location = new System.Drawing.Point(94, 305);
            this.btnMouseClickIns.Name = "btnMouseClickIns";
            this.btnMouseClickIns.Size = new System.Drawing.Size(34, 23);
            this.btnMouseClickIns.TabIndex = 11;
            this.btnMouseClickIns.Tag = "MouseClick";
            this.btnMouseClickIns.UseVisualStyleBackColor = true;
            this.btnMouseClickIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // btnMousePosIns
            // 
            this.btnMousePosIns.Image = ((System.Drawing.Image)(resources.GetObject("btnMousePosIns.Image")));
            this.btnMousePosIns.Location = new System.Drawing.Point(94, 112);
            this.btnMousePosIns.Name = "btnMousePosIns";
            this.btnMousePosIns.Size = new System.Drawing.Size(34, 23);
            this.btnMousePosIns.TabIndex = 10;
            this.btnMousePosIns.Tag = "MouseMove";
            this.btnMousePosIns.UseVisualStyleBackColor = true;
            this.btnMousePosIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // lblClickMode
            // 
            this.lblClickMode.AutoSize = true;
            this.lblClickMode.Location = new System.Drawing.Point(4, 240);
            this.lblClickMode.Name = "lblClickMode";
            this.lblClickMode.Size = new System.Drawing.Size(40, 17);
            this.lblClickMode.TabIndex = 9;
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
            this.cobClickMode.Location = new System.Drawing.Point(54, 237);
            this.cobClickMode.Name = "cobClickMode";
            this.cobClickMode.Size = new System.Drawing.Size(74, 25);
            this.cobClickMode.TabIndex = 8;
            // 
            // txtClickNumb
            // 
            this.txtClickNumb.Location = new System.Drawing.Point(54, 270);
            this.txtClickNumb.Name = "txtClickNumb";
            this.txtClickNumb.Size = new System.Drawing.Size(74, 25);
            this.txtClickNumb.TabIndex = 7;
            this.txtClickNumb.Text = "1";
            // 
            // lblClickNumb
            // 
            this.lblClickNumb.AutoSize = true;
            this.lblClickNumb.Location = new System.Drawing.Point(4, 275);
            this.lblClickNumb.Name = "lblClickNumb";
            this.lblClickNumb.Size = new System.Drawing.Size(40, 17);
            this.lblClickNumb.TabIndex = 6;
            this.lblClickNumb.Text = "次數 :";
            // 
            // lblMouseClick
            // 
            this.lblMouseClick.AutoSize = true;
            this.lblMouseClick.Location = new System.Drawing.Point(8, 150);
            this.lblMouseClick.Name = "lblMouseClick";
            this.lblMouseClick.Size = new System.Drawing.Size(73, 17);
            this.lblMouseClick.TabIndex = 5;
            this.lblMouseClick.Text = "滑鼠控制：";
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(54, 74);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(74, 25);
            this.txtYPos.TabIndex = 4;
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(54, 43);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(74, 25);
            this.txtXPos.TabIndex = 3;
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(22, 77);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(22, 17);
            this.lblYPos.TabIndex = 2;
            this.lblYPos.Text = "Y :";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Location = new System.Drawing.Point(22, 46);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(22, 17);
            this.lblXPos.TabIndex = 1;
            this.lblXPos.Text = "X :";
            // 
            // lblMouseMove
            // 
            this.lblMouseMove.AutoSize = true;
            this.lblMouseMove.Location = new System.Drawing.Point(8, 13);
            this.lblMouseMove.Name = "lblMouseMove";
            this.lblMouseMove.Size = new System.Drawing.Size(99, 17);
            this.lblMouseMove.TabIndex = 0;
            this.lblMouseMove.Text = "滑鼠座標移動：";
            // 
            // tpgKeyEvent
            // 
            this.tpgKeyEvent.Controls.Add(this.txtBkKeyNum);
            this.tpgKeyEvent.Controls.Add(this.lblBkKeyNum);
            this.tpgKeyEvent.Controls.Add(this.btnBkKeyIns);
            this.tpgKeyEvent.Controls.Add(this.lblBkKey);
            this.tpgKeyEvent.Controls.Add(this.cobBkKey);
            this.tpgKeyEvent.Controls.Add(this.lblBkKeyEvent);
            this.tpgKeyEvent.Controls.Add(this.btnKeyIns);
            this.tpgKeyEvent.Controls.Add(this.lblKey);
            this.tpgKeyEvent.Controls.Add(this.cobKey);
            this.tpgKeyEvent.Controls.Add(this.txtKeyNum);
            this.tpgKeyEvent.Controls.Add(this.lblKeyNum);
            this.tpgKeyEvent.Controls.Add(this.lblKeyEvent);
            this.tpgKeyEvent.Location = new System.Drawing.Point(28, 4);
            this.tpgKeyEvent.Name = "tpgKeyEvent";
            this.tpgKeyEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgKeyEvent.Size = new System.Drawing.Size(140, 469);
            this.tpgKeyEvent.TabIndex = 1;
            this.tpgKeyEvent.Text = "鍵盤控制";
            this.tpgKeyEvent.UseVisualStyleBackColor = true;
            // 
            // txtBkKeyNum
            // 
            this.txtBkKeyNum.Location = new System.Drawing.Point(55, 201);
            this.txtBkKeyNum.Name = "txtBkKeyNum";
            this.txtBkKeyNum.Size = new System.Drawing.Size(74, 25);
            this.txtBkKeyNum.TabIndex = 29;
            this.txtBkKeyNum.Text = "1";
            // 
            // lblBkKeyNum
            // 
            this.lblBkKeyNum.AutoSize = true;
            this.lblBkKeyNum.Location = new System.Drawing.Point(9, 206);
            this.lblBkKeyNum.Name = "lblBkKeyNum";
            this.lblBkKeyNum.Size = new System.Drawing.Size(40, 17);
            this.lblBkKeyNum.TabIndex = 28;
            this.lblBkKeyNum.Text = "次數 :";
            // 
            // btnBkKeyIns
            // 
            this.btnBkKeyIns.Image = ((System.Drawing.Image)(resources.GetObject("btnBkKeyIns.Image")));
            this.btnBkKeyIns.Location = new System.Drawing.Point(95, 232);
            this.btnBkKeyIns.Name = "btnBkKeyIns";
            this.btnBkKeyIns.Size = new System.Drawing.Size(34, 23);
            this.btnBkKeyIns.TabIndex = 27;
            this.btnBkKeyIns.Tag = "KeyBkBoardDown";
            this.btnBkKeyIns.UseVisualStyleBackColor = true;
            this.btnBkKeyIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // lblBkKey
            // 
            this.lblBkKey.AutoSize = true;
            this.lblBkKey.Location = new System.Drawing.Point(9, 174);
            this.lblBkKey.Name = "lblBkKey";
            this.lblBkKey.Size = new System.Drawing.Size(40, 17);
            this.lblBkKey.TabIndex = 26;
            this.lblBkKey.Text = "按鍵 :";
            // 
            // cobBkKey
            // 
            this.cobBkKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobBkKey.FormattingEnabled = true;
            this.cobBkKey.Items.AddRange(new object[] {
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
            this.cobBkKey.Location = new System.Drawing.Point(55, 170);
            this.cobBkKey.Name = "cobBkKey";
            this.cobBkKey.Size = new System.Drawing.Size(74, 25);
            this.cobBkKey.TabIndex = 25;
            // 
            // lblBkKeyEvent
            // 
            this.lblBkKeyEvent.AutoSize = true;
            this.lblBkKeyEvent.Location = new System.Drawing.Point(9, 143);
            this.lblBkKeyEvent.Name = "lblBkKeyEvent";
            this.lblBkKeyEvent.Size = new System.Drawing.Size(99, 17);
            this.lblBkKeyEvent.TabIndex = 24;
            this.lblBkKeyEvent.Text = "背端鍵盤按鍵：";
            // 
            // btnKeyIns
            // 
            this.btnKeyIns.Image = ((System.Drawing.Image)(resources.GetObject("btnKeyIns.Image")));
            this.btnKeyIns.Location = new System.Drawing.Point(95, 112);
            this.btnKeyIns.Name = "btnKeyIns";
            this.btnKeyIns.Size = new System.Drawing.Size(34, 23);
            this.btnKeyIns.TabIndex = 15;
            this.btnKeyIns.Tag = "KeyBoardDown";
            this.btnKeyIns.UseVisualStyleBackColor = true;
            this.btnKeyIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(9, 46);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(40, 17);
            this.lblKey.TabIndex = 14;
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
            this.cobKey.Location = new System.Drawing.Point(55, 42);
            this.cobKey.Name = "cobKey";
            this.cobKey.Size = new System.Drawing.Size(74, 25);
            this.cobKey.TabIndex = 13;
            // 
            // txtKeyNum
            // 
            this.txtKeyNum.Location = new System.Drawing.Point(55, 76);
            this.txtKeyNum.Name = "txtKeyNum";
            this.txtKeyNum.Size = new System.Drawing.Size(74, 25);
            this.txtKeyNum.TabIndex = 12;
            this.txtKeyNum.Text = "1";
            // 
            // lblKeyNum
            // 
            this.lblKeyNum.AutoSize = true;
            this.lblKeyNum.Location = new System.Drawing.Point(9, 81);
            this.lblKeyNum.Name = "lblKeyNum";
            this.lblKeyNum.Size = new System.Drawing.Size(40, 17);
            this.lblKeyNum.TabIndex = 11;
            this.lblKeyNum.Text = "次數 :";
            // 
            // lblKeyEvent
            // 
            this.lblKeyEvent.AutoSize = true;
            this.lblKeyEvent.Location = new System.Drawing.Point(9, 15);
            this.lblKeyEvent.Name = "lblKeyEvent";
            this.lblKeyEvent.Size = new System.Drawing.Size(73, 17);
            this.lblKeyEvent.TabIndex = 10;
            this.lblKeyEvent.Text = "鍵盤按鍵：";
            // 
            // tpgContrlEvent
            // 
            this.tpgContrlEvent.Controls.Add(this.btnWinCodeIns);
            this.tpgContrlEvent.Controls.Add(this.btnSearchCode);
            this.tpgContrlEvent.Controls.Add(this.txtCode);
            this.tpgContrlEvent.Controls.Add(this.lblCode);
            this.tpgContrlEvent.Controls.Add(this.lblWinCode);
            this.tpgContrlEvent.Controls.Add(this.btnDelayIns);
            this.tpgContrlEvent.Controls.Add(this.btnLoopIns);
            this.tpgContrlEvent.Controls.Add(this.lblDelayUnit);
            this.tpgContrlEvent.Controls.Add(this.txtDelay);
            this.tpgContrlEvent.Controls.Add(this.lblDelay);
            this.tpgContrlEvent.Controls.Add(this.lblDelayEvent);
            this.tpgContrlEvent.Controls.Add(this.txtLoopNum);
            this.tpgContrlEvent.Controls.Add(this.lblLoopNum);
            this.tpgContrlEvent.Controls.Add(this.lblLoopEvent);
            this.tpgContrlEvent.Location = new System.Drawing.Point(28, 4);
            this.tpgContrlEvent.Name = "tpgContrlEvent";
            this.tpgContrlEvent.Padding = new System.Windows.Forms.Padding(3);
            this.tpgContrlEvent.Size = new System.Drawing.Size(140, 469);
            this.tpgContrlEvent.TabIndex = 2;
            this.tpgContrlEvent.Text = "其餘命令";
            this.tpgContrlEvent.UseVisualStyleBackColor = true;
            // 
            // btnWinCodeIns
            // 
            this.btnWinCodeIns.Image = ((System.Drawing.Image)(resources.GetObject("btnWinCodeIns.Image")));
            this.btnWinCodeIns.Location = new System.Drawing.Point(93, 281);
            this.btnWinCodeIns.Name = "btnWinCodeIns";
            this.btnWinCodeIns.Size = new System.Drawing.Size(34, 23);
            this.btnWinCodeIns.TabIndex = 20;
            this.btnWinCodeIns.Tag = "WinCodeControl";
            this.btnWinCodeIns.UseVisualStyleBackColor = true;
            this.btnWinCodeIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // btnSearchCode
            // 
            this.btnSearchCode.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCode.Image")));
            this.btnSearchCode.Location = new System.Drawing.Point(13, 281);
            this.btnSearchCode.Name = "btnSearchCode";
            this.btnSearchCode.Size = new System.Drawing.Size(34, 23);
            this.btnSearchCode.TabIndex = 19;
            this.btnSearchCode.Tag = "";
            this.btnSearchCode.UseVisualStyleBackColor = true;
            this.btnSearchCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSearchCode_MouseDown);
            this.btnSearchCode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSearchCode_MouseUp);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(53, 248);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(74, 25);
            this.txtCode.TabIndex = 17;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(7, 252);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 17);
            this.lblCode.TabIndex = 16;
            this.lblCode.Text = "代碼 :";
            // 
            // lblWinCode
            // 
            this.lblWinCode.AutoSize = true;
            this.lblWinCode.Location = new System.Drawing.Point(7, 218);
            this.lblWinCode.Name = "lblWinCode";
            this.lblWinCode.Size = new System.Drawing.Size(73, 17);
            this.lblWinCode.TabIndex = 15;
            this.lblWinCode.Text = "視窗代碼：";
            // 
            // btnDelayIns
            // 
            this.btnDelayIns.Image = ((System.Drawing.Image)(resources.GetObject("btnDelayIns.Image")));
            this.btnDelayIns.Location = new System.Drawing.Point(93, 182);
            this.btnDelayIns.Name = "btnDelayIns";
            this.btnDelayIns.Size = new System.Drawing.Size(34, 23);
            this.btnDelayIns.TabIndex = 14;
            this.btnDelayIns.Tag = "DelayControl";
            this.btnDelayIns.UseVisualStyleBackColor = true;
            this.btnDelayIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // btnLoopIns
            // 
            this.btnLoopIns.Image = ((System.Drawing.Image)(resources.GetObject("btnLoopIns.Image")));
            this.btnLoopIns.Location = new System.Drawing.Point(93, 85);
            this.btnLoopIns.Name = "btnLoopIns";
            this.btnLoopIns.Size = new System.Drawing.Size(34, 23);
            this.btnLoopIns.TabIndex = 13;
            this.btnLoopIns.Tag = "LoopControl";
            this.btnLoopIns.UseVisualStyleBackColor = true;
            this.btnLoopIns.Click += new System.EventHandler(this.btnInsertEvent);
            // 
            // lblDelayUnit
            // 
            this.lblDelayUnit.AutoSize = true;
            this.lblDelayUnit.Location = new System.Drawing.Point(112, 152);
            this.lblDelayUnit.Name = "lblDelayUnit";
            this.lblDelayUnit.Size = new System.Drawing.Size(26, 17);
            this.lblDelayUnit.TabIndex = 12;
            this.lblDelayUnit.Text = "ms";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(53, 146);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(56, 25);
            this.txtDelay.TabIndex = 11;
            this.txtDelay.Text = "1";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(7, 150);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(40, 17);
            this.lblDelay.TabIndex = 10;
            this.lblDelay.Text = "時間 :";
            // 
            // lblDelayEvent
            // 
            this.lblDelayEvent.AutoSize = true;
            this.lblDelayEvent.Location = new System.Drawing.Point(7, 121);
            this.lblDelayEvent.Name = "lblDelayEvent";
            this.lblDelayEvent.Size = new System.Drawing.Size(73, 17);
            this.lblDelayEvent.TabIndex = 9;
            this.lblDelayEvent.Text = "延遲控制：";
            // 
            // txtLoopNum
            // 
            this.txtLoopNum.Location = new System.Drawing.Point(53, 47);
            this.txtLoopNum.Name = "txtLoopNum";
            this.txtLoopNum.Size = new System.Drawing.Size(74, 25);
            this.txtLoopNum.TabIndex = 8;
            this.txtLoopNum.Text = "1";
            // 
            // lblLoopNum
            // 
            this.lblLoopNum.AutoSize = true;
            this.lblLoopNum.Location = new System.Drawing.Point(7, 51);
            this.lblLoopNum.Name = "lblLoopNum";
            this.lblLoopNum.Size = new System.Drawing.Size(40, 17);
            this.lblLoopNum.TabIndex = 6;
            this.lblLoopNum.Text = "次數 :";
            // 
            // lblLoopEvent
            // 
            this.lblLoopEvent.AutoSize = true;
            this.lblLoopEvent.Location = new System.Drawing.Point(7, 17);
            this.lblLoopEvent.Name = "lblLoopEvent";
            this.lblLoopEvent.Size = new System.Drawing.Size(73, 17);
            this.lblLoopEvent.TabIndex = 5;
            this.lblLoopEvent.Text = "迴圈控制：";
            // 
            // menuControl
            // 
            this.menuControl.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.tsmiOption,
            this.tsmiDescription,
            this.tsmiSystem});
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(806, 27);
            this.menuControl.TabIndex = 10;
            this.menuControl.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiSave,
            this.tsmiLoad});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNew.Image")));
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(138, 24);
            this.tsmiNew.Text = "開新檔案";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSave.Image")));
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(138, 24);
            this.tsmiSave.Text = "儲存";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLoad.Image")));
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.Size = new System.Drawing.Size(138, 24);
            this.tsmiLoad.Text = "載入";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tsmiOption
            // 
            this.tsmiOption.Checked = true;
            this.tsmiOption.CheckOnClick = true;
            this.tsmiOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoop,
            this.tsmiSysOption});
            this.tsmiOption.Name = "tsmiOption";
            this.tsmiOption.Size = new System.Drawing.Size(51, 23);
            this.tsmiOption.Text = "設定";
            // 
            // tsmiLoop
            // 
            this.tsmiLoop.Name = "tsmiLoop";
            this.tsmiLoop.Size = new System.Drawing.Size(138, 24);
            this.tsmiLoop.Text = "重複執行";
            this.tsmiLoop.Click += new System.EventHandler(this.tsmiLoop_Click);
            // 
            // tsmiSysOption
            // 
            this.tsmiSysOption.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSysOption.Image")));
            this.tsmiSysOption.Name = "tsmiSysOption";
            this.tsmiSysOption.Size = new System.Drawing.Size(138, 24);
            this.tsmiSysOption.Text = "環境設定";
            this.tsmiSysOption.Click += new System.EventHandler(this.tsmiSysOption_Click);
            // 
            // tsmiDescription
            // 
            this.tsmiDescription.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKeyDesc});
            this.tsmiDescription.Name = "tsmiDescription";
            this.tsmiDescription.Size = new System.Drawing.Size(51, 23);
            this.tsmiDescription.Text = "說明";
            // 
            // tsmiKeyDesc
            // 
            this.tsmiKeyDesc.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKeyDesc.Image")));
            this.tsmiKeyDesc.Name = "tsmiKeyDesc";
            this.tsmiKeyDesc.Size = new System.Drawing.Size(138, 24);
            this.tsmiKeyDesc.Text = "按鍵說明";
            this.tsmiKeyDesc.Click += new System.EventHandler(this.tsmiKeyDesc_Click);
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(51, 23);
            this.tsmiSystem.Text = "系統";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 24);
            this.tsmiExit.Text = "離開";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // grpControlEvent
            // 
            this.grpControlEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpControlEvent.BackColor = System.Drawing.SystemColors.Control;
            this.grpControlEvent.Controls.Add(this.btnlstDown);
            this.grpControlEvent.Controls.Add(this.btnlstUp);
            this.grpControlEvent.Controls.Add(this.lblMouseAutoPos);
            this.grpControlEvent.Controls.Add(this.lblX);
            this.grpControlEvent.Controls.Add(this.lblY);
            this.grpControlEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpControlEvent.Location = new System.Drawing.Point(537, 0);
            this.grpControlEvent.Name = "grpControlEvent";
            this.grpControlEvent.Size = new System.Drawing.Size(266, 82);
            this.grpControlEvent.TabIndex = 11;
            this.grpControlEvent.TabStop = false;
            this.grpControlEvent.Text = "groupBox1";
            // 
            // btnlstDown
            // 
            this.btnlstDown.Image = ((System.Drawing.Image)(resources.GetObject("btnlstDown.Image")));
            this.btnlstDown.Location = new System.Drawing.Point(48, 39);
            this.btnlstDown.Name = "btnlstDown";
            this.btnlstDown.Size = new System.Drawing.Size(29, 28);
            this.btnlstDown.TabIndex = 16;
            this.btnlstDown.Tag = "Down";
            this.btnlstDown.UseVisualStyleBackColor = true;
            this.btnlstDown.Click += new System.EventHandler(this.btnListMoveEvent);
            // 
            // btnlstUp
            // 
            this.btnlstUp.Image = ((System.Drawing.Image)(resources.GetObject("btnlstUp.Image")));
            this.btnlstUp.Location = new System.Drawing.Point(13, 39);
            this.btnlstUp.Name = "btnlstUp";
            this.btnlstUp.Size = new System.Drawing.Size(29, 28);
            this.btnlstUp.TabIndex = 15;
            this.btnlstUp.Tag = "Up";
            this.btnlstUp.UseVisualStyleBackColor = true;
            this.btnlstUp.Click += new System.EventHandler(this.btnListMoveEvent);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.ctmusNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // ctmusNotify
            // 
            this.ctmusNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNotEnSetting,
            this.tsmiEnd});
            this.ctmusNotify.Name = "ctmusNotify";
            this.ctmusNotify.Size = new System.Drawing.Size(123, 48);
            // 
            // tsmiNotEnSetting
            // 
            this.tsmiNotEnSetting.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNotEnSetting.Image")));
            this.tsmiNotEnSetting.Name = "tsmiNotEnSetting";
            this.tsmiNotEnSetting.Size = new System.Drawing.Size(122, 22);
            this.tsmiNotEnSetting.Text = "環境設置";
            this.tsmiNotEnSetting.Click += new System.EventHandler(this.tsmiSysOption_Click);
            // 
            // tsmiEnd
            // 
            this.tsmiEnd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEnd.Image")));
            this.tsmiEnd.Name = "tsmiEnd";
            this.tsmiEnd.Size = new System.Drawing.Size(122, 22);
            this.tsmiEnd.Text = "結束";
            this.tsmiEnd.Click += new System.EventHandler(this.tsmiEnd_Click);
            // 
            // tabRecord
            // 
            this.tabRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRecord.Controls.Add(this.tabItemSet);
            this.tabRecord.Controls.Add(this.tabItemWrite);
            this.tabRecord.Location = new System.Drawing.Point(183, 77);
            this.tabRecord.Name = "tabRecord";
            this.tabRecord.SelectedIndex = 0;
            this.tabRecord.Size = new System.Drawing.Size(620, 434);
            this.tabRecord.TabIndex = 12;
            // 
            // tabItemSet
            // 
            this.tabItemSet.Controls.Add(this.lstEventLog);
            this.tabItemSet.Location = new System.Drawing.Point(4, 26);
            this.tabItemSet.Name = "tabItemSet";
            this.tabItemSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemSet.Size = new System.Drawing.Size(612, 404);
            this.tabItemSet.TabIndex = 0;
            this.tabItemSet.Text = "執行項目";
            this.tabItemSet.UseVisualStyleBackColor = true;
            // 
            // tabItemWrite
            // 
            this.tabItemWrite.Controls.Add(this.txtItemWrite);
            this.tabItemWrite.Location = new System.Drawing.Point(4, 26);
            this.tabItemWrite.Name = "tabItemWrite";
            this.tabItemWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tabItemWrite.Size = new System.Drawing.Size(612, 404);
            this.tabItemWrite.TabIndex = 1;
            this.tabItemWrite.Text = "原始文字";
            this.tabItemWrite.UseVisualStyleBackColor = true;
            // 
            // txtItemWrite
            // 
            this.txtItemWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemWrite.Location = new System.Drawing.Point(3, 3);
            this.txtItemWrite.Multiline = true;
            this.txtItemWrite.Name = "txtItemWrite";
            this.txtItemWrite.Size = new System.Drawing.Size(606, 398);
            this.txtItemWrite.TabIndex = 0;
            this.txtItemWrite.TextChanged += new System.EventHandler(this.txtItemWrite_TextChanged);
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 515);
            this.Controls.Add(this.tabRecord);
            this.Controls.Add(this.menuControl);
            this.Controls.Add(this.tabEventCtl);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.grpControlEvent);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MainMenuStrip = this.menuControl;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "滑鼠鍵盤控制介面";
            this.MinimumSizeChanged += new System.EventHandler(this.MainDisplay_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDisplay_FormClosing);
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.ctmusControl.ResumeLayout(false);
            this.tabEventCtl.ResumeLayout(false);
            this.tpgMouseEvent.ResumeLayout(false);
            this.tpgMouseEvent.PerformLayout();
            this.tpgKeyEvent.ResumeLayout(false);
            this.tpgKeyEvent.PerformLayout();
            this.tpgContrlEvent.ResumeLayout(false);
            this.tpgContrlEvent.PerformLayout();
            this.menuControl.ResumeLayout(false);
            this.menuControl.PerformLayout();
            this.grpControlEvent.ResumeLayout(false);
            this.grpControlEvent.PerformLayout();
            this.ctmusNotify.ResumeLayout(false);
            this.tabRecord.ResumeLayout(false);
            this.tabItemSet.ResumeLayout(false);
            this.tabItemWrite.ResumeLayout(false);
            this.tabItemWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ListBox lstEventLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Timer TimeMouseMv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMouseAutoPos;
        private System.Windows.Forms.TabControl tabEventCtl;
        private System.Windows.Forms.TabPage tpgMouseEvent;
        private System.Windows.Forms.ComboBox cobClickMode;
        private System.Windows.Forms.TextBox txtClickNumb;
        private System.Windows.Forms.Label lblClickNumb;
        private System.Windows.Forms.Label lblMouseClick;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblMouseMove;
        private System.Windows.Forms.TabPage tpgKeyEvent;
        private System.Windows.Forms.Label lblClickMode;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cobKey;
        private System.Windows.Forms.TextBox txtKeyNum;
        private System.Windows.Forms.Label lblKeyNum;
        private System.Windows.Forms.Label lblKeyEvent;
        private System.Windows.Forms.TabPage tpgContrlEvent;
        private System.Windows.Forms.TextBox txtLoopNum;
        private System.Windows.Forms.Label lblLoopNum;
        private System.Windows.Forms.Label lblLoopEvent;
        private System.Windows.Forms.Label lblDelayUnit;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblDelayEvent;
        private System.Windows.Forms.Button btnMouseClickIns;
        private System.Windows.Forms.Button btnMousePosIns;
        private System.Windows.Forms.Button btnKeyIns;
        private System.Windows.Forms.Button btnDelayIns;
        private System.Windows.Forms.Button btnLoopIns;
        private System.Windows.Forms.TextBox txtMPosY;
        private System.Windows.Forms.TextBox txtMPosX;
        private System.Windows.Forms.Label lblMPosY;
        private System.Windows.Forms.Label lblMPosX;
        private System.Windows.Forms.ContextMenuStrip ctmusControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.MenuStrip menuControl;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOption;
        private System.Windows.Forms.ToolStripMenuItem tsmiDescription;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiKeyDesc;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiSysOption;
        private System.Windows.Forms.GroupBox grpControlEvent;
        private System.Windows.Forms.Button btnlstDown;
        private System.Windows.Forms.Button btnlstUp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip ctmusNotify;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnd;
        private System.Windows.Forms.ToolStripMenuItem tsmiNotEnSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.TabControl tabRecord;
        private System.Windows.Forms.TabPage tabItemSet;
        private System.Windows.Forms.TabPage tabItemWrite;
        private System.Windows.Forms.TextBox txtItemWrite;
        private System.Windows.Forms.TextBox txtBkKeyNum;
        private System.Windows.Forms.Label lblBkKeyNum;
        private System.Windows.Forms.Button btnBkKeyIns;
        private System.Windows.Forms.Label lblBkKey;
        private System.Windows.Forms.ComboBox cobBkKey;
        private System.Windows.Forms.Label lblBkKeyEvent;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblWinCode;
        private System.Windows.Forms.Button btnSearchCode;
        private System.Windows.Forms.Button btnWinCodeIns;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoop;

    }
}

