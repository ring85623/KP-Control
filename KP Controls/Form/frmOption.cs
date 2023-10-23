using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmOption : Form
    {
        #region "     全域變數     "

        public int LintKeyDelay = 30,                                   //每次執行鍵盤按鍵的延遲時間
                   LintMouseClkDelay = 100,                             //每次執行滑鼠按鍵的延遲時間
                   LintMouseMovDelay = 10,                              //每次執行滑鼠移動的延遲時間
                   LintRepeat = 1,                                      //執行次數
                   LintRepeatDelay = 0;                                 //下一次執行相同事件的延遲時間
        public Color LRowBackColorAltA = Color.LightYellow,             //表格A欄位顏色
                     LRowBackColorAltB = Color.LightSeaGreen,           //表格B欄位顏色
                     LRowSelectColor = Color.FromArgb(150, 200, 250),   //表格選擇顏色
                     LRowBackColor = System.Drawing.Color.PapayaWhip;   //背景顏色

        #endregion

        #region "     Property     "

        public int intKeyDelay
        {
            // -----------------------------------------------------------
            // 屬性：每次執行鍵盤按鍵的延遲時間
            // -----------------------------------------------------------
            get
            {
                return LintKeyDelay;
            }
            set
            {
                LintKeyDelay = value;
            }
        }

        public int intMouseClkDelay
        {
            // -----------------------------------------------------------
            // 屬性：每次執行滑鼠按鍵的延遲時間
            // -----------------------------------------------------------
            get
            {
                return LintMouseClkDelay;
            }
            set
            {
                LintMouseClkDelay = value;
            }
        }

        public int intMouseMovDelay
        {
            // -----------------------------------------------------------
            // 屬性：每次執行滑鼠移動的延遲時間
            // -----------------------------------------------------------
            get
            {
                return LintMouseMovDelay;
            }
            set
            {
                LintMouseMovDelay = value;
            }
        }

        public int intRepeat
        {
            // -----------------------------------------------------------
            // 屬性：執行次數
            // -----------------------------------------------------------
            get
            {
                return LintRepeat;
            }
            set
            {
                LintRepeat = value;
            }
        }

        public int intRepeatDelay
        {
            // -----------------------------------------------------------
            // 屬性：下一次執行相同事件的延遲時間X座標
            // -----------------------------------------------------------
            get
            {
                return LintRepeatDelay;
            }
            set
            {
                LintRepeatDelay = value;
            }
        }

        public Color RowBackColorAltA
        {
            // -----------------------------------------------------------
            // 屬性：表格A欄位顏色
            // -----------------------------------------------------------
            get
            {
                return LRowBackColorAltA;
            }
            set
            {
                LRowBackColorAltA = value;
            }
        }

        public Color RowBackColorAltB
        {
            // -----------------------------------------------------------
            // 屬性：表格A欄位顏色
            // -----------------------------------------------------------
            get
            {
                return LRowBackColorAltB;
            }
            set
            {
                LRowBackColorAltB = value;
            }
        }

        public Color RowSelectColor
        {
            // -----------------------------------------------------------
            // 屬性：表格選擇顏色
            // -----------------------------------------------------------
            get
            {
                return LRowSelectColor;
            }
            set
            {
                LRowSelectColor = value;
            }
        }

        public Color RowBackColor
        {
            // -----------------------------------------------------------
            // 屬性：背景顏色
            // -----------------------------------------------------------
            get
            {
                return LRowBackColor;
            }
            set
            {
                LRowBackColor = value;
            }
        }

        #endregion

        #region "     Private Function     "

        //設置介面屬性寫入及讀取
        private bool GetAndSetAttrubute(Control.ControlCollection MeControls,bool blnIsRead,ref string strErrMsg)
        {
            Button BtnControl;
            TextBox TextControl;
            ComboBox ComBoControl;        
            TabControl TabControl;
            TabPage TabPageControl;
            GroupBox GroupBoxControl;
            TableLayoutPanel TableLayoutPanelControl;
            try
            {
                foreach (Control MeControl in MeControls)
                {
                    if (MeControl is TextBox)
                    {
                        TextControl = (TextBox)MeControl;
                        if (TextboxAttribute(TextControl,blnIsRead,ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is ComboBox)
                    {
                        ComBoControl = (ComboBox)MeControl;
                        if (ComboBoxAttribute(ComBoControl, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is Button)
                    {
                        BtnControl = (Button)MeControl;
                        if (ButtonAttribute(BtnControl, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is TableLayoutPanel)
                    {
                        TableLayoutPanelControl = (TableLayoutPanel)MeControl;
                        if (GetAndSetAttrubute(TableLayoutPanelControl.Controls, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is GroupBox)
                    {
                        GroupBoxControl = (GroupBox)MeControl;
                        if (GetAndSetAttrubute(GroupBoxControl.Controls, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is TabControl)
                    {
                        TabControl = (TabControl)MeControl;
                        if (GetAndSetAttrubute(TabControl.Controls, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                    else if (MeControl is TabPage)
                    {
                        TabPageControl = (TabPage)MeControl;
                        if (GetAndSetAttrubute(TabPageControl.Controls, blnIsRead, ref strErrMsg) == false)
                            return false;
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }
        }
        //TextBox屬性寫入及讀取
        private bool TextboxAttribute(TextBox TextControl, bool blnIsRead, ref string strErrMsg)
        {
            int intResult;
            try
            {
                if (TextControl.Tag != null)
                {
                    if (TextControl.Tag.ToString().Trim() != "")
                    {
                        switch(TextControl.Tag.ToString().Trim())
                        {
                            case "KeyDelay":                    //鍵盤延遲時間
                                if (blnIsRead == true)
                                {
                                    txtKeyDelay.Text = LintKeyDelay.ToString();
                                }
                                else
                                {
                                    if (Int32.TryParse(TextControl.Text.Trim(), out intResult) == false) { strErrMsg = "輸入的鍵盤點擊延遲時間不為數字"; return false; }
                                    LintKeyDelay = Int32.Parse(txtKeyDelay.Text.Trim());
                                }
                                break;
                            case "MouseClkDelay":              //滑鼠點擊延遲時間
                                if (blnIsRead == true)
                                {
                                    txtMouseClkDelay.Text = LintMouseClkDelay.ToString();
                                }
                                else
                                {
                                    if (Int32.TryParse(TextControl.Text.Trim(), out intResult) == false) { strErrMsg = "輸入的滑鼠點擊延遲時間不為數字"; return false; }
                                    LintMouseClkDelay = Int32.Parse(txtMouseClkDelay.Text.Trim());
                                }
                                break;
                            case "MouseMovDelay":              //滑鼠移動延遲時間
                                if (blnIsRead == true)
                                {
                                    txtMouseMovDelay.Text = LintMouseMovDelay.ToString();
                                }
                                else
                                {
                                    if (Int32.TryParse(TextControl.Text.Trim(), out intResult) == false) { strErrMsg = "輸入的滑鼠移動延遲時間不為數字"; return false; }
                                    LintMouseMovDelay = Int32.Parse(txtMouseMovDelay.Text.Trim());
                                }
                                break;
                            case "Repeat":                    //執行次數
                                if (blnIsRead == true)
                                {
                                    txtRepeat.Text = LintRepeat.ToString();
                                }
                                else
                                {
                                    if (Int32.TryParse(TextControl.Text.Trim(), out intResult) == false) { strErrMsg = "輸入的執行次數不為數字"; return false; }
                                    LintRepeat = Int32.Parse(txtRepeat.Text.Trim());
                                }
                                break;
                            case "RepeatDelay":              //每次執行的延遲時間
                                if (blnIsRead == true)
                                {
                                    txtRepeatDelay.Text = LintRepeatDelay.ToString();
                                }
                                else
                                {
                                    if (Int32.TryParse(TextControl.Text.Trim(), out intResult) == false) { strErrMsg = "輸入的執行次數延遲時間不為數字"; return false; }
                                    LintRepeatDelay = Int32.Parse(txtRepeatDelay.Text.Trim());
                                }
                                break;
                        }
                    }
                }            
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }            
        }
        //Combo屬性寫入及讀取
        private bool ComboBoxAttribute(ComboBox cobControl, bool blnIsRead, ref string strErrMsg)
        {
            try
            {
                if (cobControl.Tag != null)
                {
                    if (cobControl.Tag.ToString().Trim() != "")
                    {
                        switch (cobControl.Tag.ToString().Trim())
                        {
                            default :             

                                break;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }
        }
        //Button屬性寫入及讀取(color)
        private bool ButtonAttribute(Button btnControl, bool blnIsRead, ref string strErrMsg)
        {
            try
            {
                if (btnControl.Tag != null)
                {
                    if (btnControl.Tag.ToString().Trim() != "")
                    {
                        switch (btnControl.Tag.ToString().Trim())
                        {
                            case "ItemColorA":                  //奇數欄位顏色
                                if (blnIsRead == true) { btnItemColorA.BackColor = LRowBackColorAltA; }
                                else { LRowBackColorAltA = btnItemColorA.BackColor; }
                                break;
                            case "ItemColorB":                  //偶數欄位顏色
                                if (blnIsRead == true) { btnItemColorB.BackColor = LRowBackColorAltB; }
                                else { LRowBackColorAltB = btnItemColorB.BackColor; }
                                break;
                            case "RowSelectCol":
                                if (blnIsRead == true) { btnRowSelectCol.BackColor = LRowSelectColor; }
                                else { LRowSelectColor = btnRowSelectCol.BackColor; }
                                break;
                            case "BackColor":
                                if (blnIsRead == true) { btnBackColor.BackColor = LRowBackColor; }
                                else { LRowBackColor = btnBackColor.BackColor; }
                                break;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }
        }

        #endregion

        #region "     Form Event     "

        public frmOption()
        {
            InitializeComponent();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            string strErrMsg = "";
            if (GetAndSetAttrubute(tabSettingControl.Controls, true, ref strErrMsg) == false)
            {
                MessageBox.Show("環境設定更新錯誤，原因：" + Environment.NewLine + strErrMsg, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "     Button Event     "

        //確定
        private void btnOk_Click(object sender, EventArgs e)
        {
            string strErrMsg = "";
            if (GetAndSetAttrubute(tabSettingControl.Controls, false, ref strErrMsg) == false)
            {
                MessageBox.Show("環境設定更新錯誤，原因：" + Environment.NewLine + strErrMsg, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
        //離開
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //更換按鈕顏色
        private void btnBackColorChange(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ((Button)sender).BackColor = colorDialog.Color;
            }
        }

        #endregion



    }
}
