using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class frmUpdateEvent : Form
    {
        #region "     全域變數     "

        string LstrEvent, LstrKeySelect, LstrMouseClick, LstrUseNum, LstrOutPutEvent, LstrDelayTime, LstrWinCode;
        int LintLastPosX, LintLastPosY;

        #endregion

        #region "     Public struct      "

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(Point Point);

        #endregion

        #region "     Property Event     "

        public string strOutPutEvent
        {
            // -----------------------------------------------------------
            // 屬性：修改後的事件內容
            // -----------------------------------------------------------
            get
            {
                return LstrOutPutEvent;
            }
            set
            {
                LstrOutPutEvent = value;
            }
        }

        public string strEvent
        {
            // -----------------------------------------------------------
            // 屬性：鍵盤事件
            // -----------------------------------------------------------
            get
            {
                return LstrEvent;
            }
            set
            {
                LstrEvent = value;
            }
        }

        public string strKeySelect
        {
            // -----------------------------------------------------------
            // 屬性：使用按鍵
            // -----------------------------------------------------------
            get
            {
                return LstrKeySelect;
            }
            set
            {
                LstrKeySelect = value;
            }
        }

        public string strMouseClick
        {
            // -----------------------------------------------------------
            // 屬性：滑鼠按鍵
            // -----------------------------------------------------------
            get
            {
                return LstrMouseClick;
            }
            set
            {
                LstrMouseClick = value;
            }
        }

        public string strUseNum
        {
            // -----------------------------------------------------------
            // 屬性：按鍵次數
            // -----------------------------------------------------------
            get
            {
                return LstrUseNum;
            }
            set
            {
                LstrUseNum = value;
            }
        }

        public string strDelayTime
        {
            // -----------------------------------------------------------
            // 屬性：延遲時間
            // -----------------------------------------------------------
            get
            {
                return LstrDelayTime;
            }
            set
            {
                LstrDelayTime = value;
            }
        }

        public string strWinCode
        {
            // -----------------------------------------------------------
            // 屬性：視窗代碼
            // -----------------------------------------------------------
            get
            {
                return LstrWinCode;
            }
            set
            {
                LstrWinCode = value;
            }
        }

        public int intLastPosX
        {
            // -----------------------------------------------------------
            // 屬性：滑鼠X座標
            // -----------------------------------------------------------
            get
            {
                return LintLastPosX;
            }
            set
            {
                LintLastPosX = value;
            }
        }

        public int intLastPosY
        {
            // -----------------------------------------------------------
            // 屬性：滑鼠Y座標
            // -----------------------------------------------------------
            get
            {
                return LintLastPosY;
            }
            set
            {
                LintLastPosY = value;
            }
        }

        #endregion

        #region "     From     "

        public frmUpdateEvent()
        {
            InitializeComponent();
        }

        private void frmUpdateEvent_Load(object sender, EventArgs e)
        {
            try
            {
                switch (LstrEvent)
                {
                    case "滑鼠移動":    //滑鼠移動事件
                        txtTitle.Text = "調整設定：滑鼠移動事件";
                        tabUpdateEvent.SelectedTab = tpgMouseMoveSetting;
                        txtPosX.Text = LintLastPosX.ToString();
                        txtPosY.Text = LintLastPosY.ToString();
                        break;
                    case "鍵盤事件":    //鍵盤事件
                        txtTitle.Text = "調整設定：鍵盤點擊事件";
                        tabUpdateEvent.SelectedTab = tpgKeyBoardSetting;
                        txtKeyNum.Text = LstrUseNum;
                        for (int I = 0; I < cobKey.Items.Count; I++)
                        {
                            if (cobKey.Items[I].ToString() == LstrKeySelect) { cobKey.SelectedIndex = I; break; } else { cobKey.SelectedIndex = 0; }
                        }
                        break;
                    case "背端鍵盤事件":    //背端鍵盤事件
                        txtTitle.Text = "調整設定：背端鍵盤點擊事件";
                        tabUpdateEvent.SelectedTab = tpgKeyBoardSetting;
                        txtKeyNum.Text = LstrUseNum;
                        for (int I = 0; I < cobKey.Items.Count; I++)
                        {
                            if (cobKey.Items[I].ToString() == LstrKeySelect) { cobKey.SelectedIndex = I; break; } else { cobKey.SelectedIndex = 0; }
                        }
                        break;
                    case "滑鼠事件":    //滑鼠點擊事件
                        txtTitle.Text = "調整設定：滑鼠點擊事件";
                        tabUpdateEvent.SelectedTab = tpgMouseClickSetting;
                        txtMPosX.Text = LintLastPosX.ToString();
                        txtMPosY.Text = LintLastPosY.ToString();
                        txtClickNumb.Text = LstrUseNum;
                        if (LstrMouseClick == "左") { cobClickMode.SelectedIndex = 0; } else if (LstrMouseClick == "右") { cobClickMode.SelectedIndex = 1; } else { cobClickMode.SelectedIndex = 2; }
                        break;
                    case "延遲時間":
                        txtTitle.Text = "調整設定：延遲時間設定";
                        tabUpdateEvent.SelectedTab = tpgDelayControl;
                        txtDelay.Text = LstrDelayTime;
                        break;
                    case "視窗代碼":
                        txtTitle.Text = "調整設定：視窗代碼設定";
                        tabUpdateEvent.SelectedTab = tpgWinCode;
                        txtCode.Text = LstrWinCode;
                        break;
                    case "迴圈開始":
                        txtTitle.Text = "調整設定：迴圈次數設定";
                        tabUpdateEvent.SelectedTab = tpgLoopControl;
                        txtLoopNum.Text = LstrUseNum;
                        break;
                    default:
                        MessageBox.Show("出現未知錯誤，無法進行修改", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                this.Close();
            }
        }

        #endregion

        #region "     Button     "

        //離開
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //確定
        private void btnOk_Click(object sender, EventArgs e)
        {
            int intResult;
            string strMouseKey;
            try
            {
                switch (LstrEvent)
                {
                    case "滑鼠移動":    //滑鼠移動事件
                        if (Int32.TryParse(txtPosX.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[X]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        if (Int32.TryParse(txtPosY.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[Y]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "滑鼠移動:" + txtPosX.Text.Trim() + "@" + txtPosY.Text.Trim();
                        break;
                    case "鍵盤事件":    //鍵盤事件
                        if (Int32.TryParse(txtKeyNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "鍵盤事件:" + cobKey.Text.Trim() + "@次數:" + txtKeyNum.Text.Trim();
                        break;
                    case "背端鍵盤事件":
                        if (Int32.TryParse(txtKeyNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "背端鍵盤事件:" + cobKey.Text.Trim() + "@次數:" + txtKeyNum.Text.Trim();
                        break;
                    case "滑鼠事件":    //滑鼠點擊事件
                        if (Int32.TryParse(txtMPosX.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[X]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        if (Int32.TryParse(txtMPosY.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[Y]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        if (Int32.TryParse(txtClickNumb.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        if (cobClickMode.Text.Trim() == "左鍵") { strMouseKey = "左鍵"; }
                        else if (cobClickMode.Text.Trim() == "右鍵") { strMouseKey = "右鍵"; }
                        else { strMouseKey = "中鍵"; }
                        LstrOutPutEvent = "滑鼠事件:" + strMouseKey + "@次數:" + txtClickNumb.Text.Trim() + "@X:" + txtMPosX.Text.Trim() + "@Y:" + txtMPosY.Text.Trim();
                        break;
                    case "延遲時間":
                        if (Int32.TryParse(txtDelay.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的時間不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "延遲時間:" + txtDelay.Text.Trim() + "ms";
                        break;
                    case "視窗代碼":
                        if (Int32.TryParse(txtCode.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的代碼不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "視窗代碼:" + txtCode.Text.Trim();
                        break;
                    case "迴圈開始":
                        if (Int32.TryParse(txtLoopNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的次數不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        LstrOutPutEvent = "迴圈開始:次數:" + txtLoopNum.Text.Trim();
                        break;
                    default:
                        MessageBox.Show("出現未知錯誤，無法進行修改", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //模擬spy++方法讀取位置-設定按鈕被按下
        private void btnSearchCode_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Help;
        }
        //模擬spy++方法讀取位置-設定按鈕回復並記錄hwnd
        private void btnSearchCode_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            Point ptCursor = new Point(Cursor.Position.X, Cursor.Position.Y);
            IntPtr hWnd = WindowFromPoint(ptCursor);
            txtCode.Text = hWnd.ToString();
        }

        #endregion 

    }
}
