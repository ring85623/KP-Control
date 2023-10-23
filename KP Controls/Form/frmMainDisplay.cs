using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InputManager;
using System.Collections;
using System.Runtime.InteropServices;
using WindowsFormsApplication1;
using System.IO;
using System.Xml;
using System.Drawing.Imaging;
using System.Threading;

//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.Devices;
//using Microsoft.VisualBasic.ApplicationServices;

namespace InputManager_Example
{
    public partial class MainDisplay : Form
    {
        #region "     Enum     "



        #endregion

        #region "     全域變數     "
  
        public ArrayList LarrKeyList = new ArrayList() { "A", "B", "D", "E", "F", "G", "H", "I", "J", 
                                                         "K","L","M","N","O","P","Q","R","S","T","U","V","W", 
                                                         "Y","F1","F2","F3","F4","F5","F6","F7","F8","F9","F10", 
                                                         "F11","F12"};
        public ArrayList LarrRecord = new ArrayList();

        public int LintKeyDelay = 30,                    //每次執行鍵盤按鍵的延遲時間
                   LintMouseClkDelay = 100,              //每次執行滑鼠按鍵的延遲時間
                   LintMouseMovDelay = 10,               //每次執行滑鼠移動的延遲時間
                   LintRepeat = 1,                       //執行次數
                   LintRepeatDelay = 0,                  //下一次執行相同事件的延遲時間
                   Lindexofsource,                       //拖動的起始索引
                   Lindexoftarget,                       //拖動的結束索引 
                   LintLastPosX = 0,                     //X 座標
                   LintLastPosY = 0;                     //Y 座標
        public bool LblnStopEvent = false, LblnStopThread = false, LblnStopKeyEvent = false, LblnLoopState = false, LblnRunAndStop = false;
        public string LstrLastEventlog = "", LstrLastMouseDown = "";
        public ArrayList LarrCopyItems = new ArrayList();
        private string LstrXmlSettingPath = Application.StartupPath + "\\Setting.xml";
        private string LStrXmlEnvieonment = "EnvironmentOption";
        private Color RowBackColorAltA = Color.LightYellow;               //交替色[A]
        private Color RowBackColorAltB = Color.LightSeaGreen;             //交替色[B]
        private Color RowBackColor = System.Drawing.Color.PapayaWhip;     //背景顏色
        private Color RowSelectColor = Color.FromArgb(150, 200, 250);     //選擇項目的顏色
        

        #endregion

        #region "     Public struct      "

         [DllImport("user32")]
         private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
         [DllImport("user32.dll")]
         static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
         [DllImport("User32.dll")]
         public static extern void keybd_event(byte bVK, byte bScan, Int32 dwFlags, int dwExtraInfo);
         [DllImport("user32.dll")]
         public static extern IntPtr WindowFromPoint(Point Point);
         [DllImport("user32.dll")]
         static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        #endregion

        #region "     Public const      "

         #region "======================滑鼠按鍵======================"
         public const int MOUSEEVENTF_MOVE = 0x0001;           //移动鼠标
         //模拟鼠标左键按下 
         public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
         //模拟鼠标左键抬起 
         public const int MOUSEEVENTF_LEFTUP = 0x0004;
         //模拟鼠标右键按下 
         public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
         //模拟鼠标右键抬起 
         public const int MOUSEEVENTF_RIGHTUP = 0x0010;
         //模拟鼠标中键按下 
         public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
         //模拟鼠标中键抬起 
         public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
         //标示是否采用绝对坐标 
         public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
         #endregion
         #region "======================鍵盤按鍵1======================"
         public const int VK_LBUTTON = 0x1;  // Linker Mausbutton
         public const int VK_RBUTTON = 0x2;  // Rechter Mausbutton
         public const int VK_MBUTTON = 0x4;  // Mittlerer Mausbutton
         public const int VK_BACK = 0x8;  // Backspace Taste
         public const int VK_TAB = 0x9;  // Tab Taste
         public const int VK_RETURN = 0xD;  // Enter Taste
         public const int VK_SHIFT = 0x10;  // Shift Taste
         public const int VK_CONTROL = 0x11;  // STRG Taste
         public const int VK_MENU = 0x12;  // Alt Taste
         public const int VK_PAUSE = 0x13;  // Pause/Untbr
         public const int VK_CAPITAL = 0x14;  // Caps Lock/Feststelltaste
         public const int VK_ESCAPE = 0x1B;  // Escape
         public const int VK_SPACE = 0x20;  // Space/Leertaste
         public const int VK_PRIOR = 0x21;  // PageUp/Bild hoch
         public const int VK_NEXT = 0x22;  // PageDown/Bild runter
         public const int VK_END = 0x23;  // Ende
         public const int VK_HOME = 0x24;  // Home/Pos1
         public const int VK_LEFT = 0x25;  // Linke Pfeiltaste
         public const int VK_UP = 0x26;  // Obere Pfeiltaste
         public const int VK_RIGHT = 0x27;  // Rechte Pfeiltaste
         public const int VK_DOWN = 0x28; // Untere Pfeiltaste
         public const int VK_PRINT = 0x2A;  // Drucken (Nokia Tastaturen)
         public const int VK_SNAPSHOT = 0x2;  // Drucken/S-Abf
         public const int VK_INSERT = 0x2D;  // Einfügen
         public const int VK_DELETE = 0x2E;  // Entfernen
         public const int VK_HELP = 0x2F;  // Hilfe
         public const int VK_0 = 0x30;  // Taste 0
         public const int VK_1 = 0x31;  // Taste 1
         public const int VK_2 = 0x32;  // Taste 2
         public const int VK_3 = 0x33;   // Taste 3
         public const int VK_4 = 0x34;  // Taste 4
         public const int VK_5 = 0x35;  // Taste 5
         public const int VK_6 = 0x36;  // Taste 6
         public const int VK_7 = 0x37;  // Taste 7
         public const int VK_8 = 0x38;   // Taste 8
         public const int VK_9 = 0x39;   // Taste 9
         public const int VK_A = 0x41;   // Taste A
         public const int VK_B = 0x42;   // Taste B
         public const int VK_C = 0x43;   // Taste C
         public const int VK_D = 0x44;   // Taste D
         public const int VK_E = 0x45;   // Taste E
         public const int VK_F = 0x46;   // Taste F
         public const int VK_G = 0x47;   // Taste G
         public const int VK_H = 0x48;  // Taste H
         public const int VK_I = 0x49;  // Taste I
         public const int VK_J = 0x4A;  // Taste J
         public const int VK_K = 0x4B;  // Taste K
         public const int VK_L = 0x4;   // Taste L
         public const int VK_M = 0x4D;   // Taste M
         public const int VK_N = 0x4E;  // Taste N
         public const int VK_O = 0x4F;  // Taste O
         public const int VK_P = 0x50;   // Taste P
         public const int VK_Q = 0x51;   // Taste Q
         public const int VK_R = 0x52; // Taste R
         public const int VK_S = 0x53;  // Taste S
         public const int VK_T = 0x54;   // Taste T
         public const int VK_U = 0x55;  // Taste U
         public const int VK_V = 0x56;  // Taste V
         public const int VK_W = 0x57;   // Taste W
         public const int VK_X = 0x58;  // Taste X
         public const int VK_Y = 0x59;  // Taste Y
         public const int VK_Z = 0x5A;  // Taste Z
         public const int VK_STARTKEY = 0x5B;   // Startmenütaste
         public const int VK_CONTEXTKEY = 0x5D;  // Kentextmenü
         public const int VK_NUMPAD0 = 0x60;  // Numpad Taste 0
         public const int VK_NUMPAD1 = 0x61;  // Numpad Taste 1
         public const int VK_NUMPAD2 = 0x62;  // Numpad Taste 2
         public const int VK_NUMPAD3 = 0x63;  // Numpad Taste 3
         public const int VK_NUMPAD4 = 0x64;  // Numpad Taste 4
         public const int VK_NUMPAD5 = 0x65; // Numpad Taste 5
         public const int VK_NUMPAD6 = 0x66;  // Numpad Taste 6
         public const int VK_NUMPAD7 = 0x67;  // Numpad Taste 7
         public const int VK_NUMPAD8 = 0x68;   // Numpad Taste 8
         public const int VK_NUMPAD9 = 0x69;   // Numpad Taste 9
         public const int VK_MULTIPLY = 0x6A; // Numpad Multiplikations Taste (*)
         public const int VK_ADD = 0x6B;  // Numpad Additions Taste (+)
         public const int VK_SUBTRACT = 0x6D;   // Numpad Subtrations Taste (-)
         public const int VK_DECIMAL = 0x6E;   // Numpad Komma Taste (,)
         public const int VK_DIVIDE = 0x6F; // Numpad Devidierungs Taste (/)
         public const int VK_F1 = 0x70;  // F1 Taste
         public const int VK_F2 = 0x71;  // F2 Taste
         public const int VK_F3 = 0x72;   // F3 Taste
         public const int VK_F4 = 0x73;   // F4 Taste
         public const int VK_F5 = 0x74;   // F5 Taste
         public const int VK_F6 = 0x75;   // F6 Taste
         public const int VK_F7 = 0x76;  // F7 Taste
         public const int VK_F8 = 0x77;  // F8 Taste
         public const int VK_F9 = 0x78;   // F9 Taste
         public const int VK_F10 = 0x79;  // F10 Taste
         public const int VK_F11 = 0x7A;   // F11 Taste
         public const int VK_F12 = 0x7B;   // F12 Taste
         public const int VK_F13 = 0x7;  // F13 Taste
         public const int VK_F14 = 0x7D;  // F14 Taste
         public const int VK_F15 = 0x7E;   // F15 Taste
         public const int VK_F16 = 0x7F;   // F16 Taste
         public const int VK_F17 = 0x80;   // F17 Taste
         public const int VK_F18 = 0x81;   // F18 Taste
         public const int VK_F19 = 0x82;   // F19 Taste
         public const int VK_F20 = 0x83;   // F20 Taste
         public const int VK_F21 = 0x84;   // F21 Taste
         public const int VK_F22 = 0x85;   // F22 Taste
         public const int VK_F23 = 0x86;   // F23 Taste
         public const int VK_F24 = 0x87;   // F24 Taste
         public const int VK_NUMLOCK = 0x90;  // Numlock Taste
         public const int VK_OEM_SCROLL = 0x91;  // Scroll Lock
         public const int VK_LSHIFT = 0xA0; // Linke Shift-Taste
         public const int VK_RSHIFT = 0xA1;  // Rechte Shift-Taste
         public const int VK_LCONTROL = 0xA2;  // Linke STRG-Taste
         public const int VK_RCONTROL = 0xA3; // Rechte STRG-Taste
         public const int VK_LMENU = 0xA4;  // Linke ALT-Taste
         public const int VK_RMENU = 0xA5;  // Rechte ALT-Taste
         public const int VK_OEM_1 = 0xBA;  // ";"-Taste
         public const int VK_OEM_PLUS = 0xBB;   // "
         public const int VK_OEM_COMMA = 0xB;   // ","-Taste
         public const int VK_OEM_MINUS = 0xBD;   // "-"-Taste
         public const int VK_OEM_PERIOD = 0xBE;   // "."-taste
         public const int VK_OEM_2 = 0xBF;   // "/"-Taste
         public const int VK_OEM_3 = 0xC0;   // "`"-Taste
         public const int VK_OEM_4 = 0xDB;   // "["-Taste
         public const int VK_OEM_5 = 0xD;   // "\"-Taste
         public const int VK_OEM_6 = 0xDD;   // "]"-Taste
         public const int VK_OEM_7 = 0xDE;   // "
         public const int VK_ICO_F17 = 0xE0;   // F17 einer Olivette Tastatur (Intern)
         public const int VK_ICO_F18 = 0xE1;   // F18 einer Olivette Tastatur (Intern)
         public const int VK_OEM102 = 0xE2;   // "<"-Taste oder "|"-Taste einer  
         // IBM-Kompatiblen 102 Tastatur (Nicht US)
         public const int VK_ICO_HELP = 0xE3;   // Hilfetaste einer Olivetti Tastatur (Intern) 
         public const int VK_ICO_00 = 0xE4;  // 00-Taste einer Olivetti Tastatur (Intern)
         public const int VK_ICO_CLEAR = 0xE6;   // Löschen Taste einer Olivetti Tastatur (Intern) 
         public const int VK_OEM_RESET = 0xE9;  // Reset Taste (Nokia)
         public const int VK_OEM_JUMP = 0xEA;   // Springen Taste (Nokia)
         public const int VK_OEM_PA1 = 0xEB;   // PA1 Taste (Nokia)
         public const int VK_OEM_PA2 = 0xE;  // PA2 Taste (Nokia)
         public const int VK_OEM_PA3 = 0xED;  // PA3 Taste (Nokia)
         public const int VK_OEM_WSCTRL = 0xEE;   // WSCTRL Taste (Nokia)
         public const int VK_OEM_CUSEL = 0xEF;   // WSCTRL Taste (Nokia)
         public const int VK_OEM_ATTN = 0xF0;   // ATTN Taste (Nokia)
         public const int VK_OEM_FINNISH = 0xF1;  // Fertig Taste (Nokia)
         public const int VK_OEM_COPY = 0xF2;   // Kopieren Taste (Nokia)
         public const int VK_OEM_AUTO = 0xF3;   // Auto Taste (Nokia)
         public const int VK_OEM_ENLW = 0xF4;   // ENLW Taste (Nokia)
         public const int VK_OEM_BACKTAB = 0xF5;   // BackTab Taste (Nokia)
         public const int VK_ATTN = 0xF6;   // ATTN-Taste
         public const int VK_CRSEL = 0xF7;   // CRSEL-Taste
         public const int VK_EXSEL = 0xF8;   // EXSEL-Taste
         public const int VK_EREOF = 0xF9;   // EREOF-Taste
         public const int VK_PLAY = 0xFA;  // PLAY-Taste
         public const int VK_ZOOM = 0xFB;   // ZOOM-Taste
         public const int VK_NONAME = 0xF;   // NONAME-Taste
         public const int VK_PA1 = 0xFD;   // PA1-Taste
         public const int VK_OEM_CLEAR = 0xFE;  // OEM_CLEAR-Taste
         #endregion
         #region "======================鍵盤按鍵2======================"
            public const uint WM_KEYDOWN = 0x0100;
            public const uint WM_KEYUP = 0x0101;
            public const int KEYEVENTF_KEYUP = 0x0002;
         #endregion


        #endregion

        #region "     Form Event     "
            
        public MainDisplay()
        {
            InitializeComponent();
            lstEventLog.ItemHeight = 40;
            btnRecord.Image =  Properties.Resources.RecGen.ToBitmap();
            btnStart.Image =  Properties.Resources.running.ToBitmap();
            btnClear.Image = Properties.Resources.cleaning.ToBitmap();
        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {
            try
            {

                this.Text = "滑鼠鍵盤控制介面 [" + Application.ProductVersion + "]";
                //開啟計時器紀錄滑鼠動作
                TimeMouseMv.Enabled = true;
                TimeMouseMv.Interval = 100;
                //下拉式選單預設
                cobClickMode.SelectedIndex = 0;
                lstEventLog.Items.Add("");
                //環境參數讀取
                EnvironmentOption(true);
                lstEventLog.AllowDrop = true;
                notifyIcon.Text = "巨集程式";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void MainDisplay_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.Hide(); this.notifyIcon.Visible = true;
        }

        private void MainDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您確定是否要關閉程式?", "請小心確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true; 
        }

        #endregion

        #region "     Private Void     "

        //環境參數讀取
        private void EnvironmentOption(bool blnRead)
        {
            XmlDocument objXMLDoc = new XmlDocument();
            XmlNode objRoot, objTopNode;
            XmlNodeList objNodeList;
            XmlElement objElement;
            string strValue,strName,strhtmlColor = "Blue";
            try
            {
                objXMLDoc.Load(LstrXmlSettingPath);
                objRoot = (XmlNode)objXMLDoc.DocumentElement;
                if (objRoot.SelectSingleNode(LStrXmlEnvieonment) != null)
                {
                    objTopNode = objRoot.SelectSingleNode(LStrXmlEnvieonment);
                    objNodeList = objTopNode.SelectNodes("item");
                    foreach (XmlNode objNode in objNodeList)
                    {
                        objElement = (XmlElement)objNode;
                        strName = objElement.GetAttribute("name"); strValue = objElement.GetAttribute("value");
                        switch (strName)
                        {
                            case "KeyDelay":
                                if (blnRead == true)
                                {
                                    LintKeyDelay = Int32.Parse(strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", LintKeyDelay.ToString());
                                }
                                break;
                            case "MouseClkDelay":
                                if (blnRead == true)
                                {
                                    LintMouseClkDelay = Int32.Parse(strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", LintMouseClkDelay.ToString());
                                }
                                break;
                            case "MouseMovDelay":
                                if (blnRead == true)
                                {
                                    LintMouseClkDelay = Int32.Parse(strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", LintMouseClkDelay.ToString());
                                }
                                break;
                            case "Repeat":
                                if (blnRead == true)
                                {
                                    LintRepeat = Int32.Parse(strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", LintRepeat.ToString());
                                }
                                break;
                            case "RepeatDelay":
                                if (blnRead == true)
                                {
                                    LintRepeatDelay = Int32.Parse(strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", LintRepeatDelay.ToString());
                                }
                                break;
                            case "RowColorA":
                                if (blnRead == true)
                                {
                                    RowBackColorAltA = System.Drawing.ColorTranslator.FromHtml("#" + strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", RowBackColorAltA.Name);
                                }
                                break;
                            case "RowColorB":
                                if (blnRead == true)
                                {
                                    RowBackColorAltB = System.Drawing.ColorTranslator.FromHtml("#" + strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", RowBackColorAltB.Name);
                                }
                                break;
                            case "RowSelectColor":
                                if (blnRead == true)
                                {
                                    RowSelectColor = System.Drawing.ColorTranslator.FromHtml("#" + strValue);
                                }
                                else
                                {
                                    objElement.SetAttribute("value", RowSelectColor.Name);
                                }
                                break;
                            case "RowBackColor" :
                                if (blnRead == true)
                                {
                                    RowBackColor = System.Drawing.ColorTranslator.FromHtml("#" + strValue);
                                    lstEventLog.BackColor = RowBackColor;
                                }
                                else
                                {
                                    objElement.SetAttribute("value", RowBackColor.Name);
                                    lstEventLog.BackColor = RowBackColor;
                                }
                                break;
                        }
                    }
                    if (blnRead == false) { objXMLDoc.Save(LstrXmlSettingPath); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //紀錄滑鼠位置
        private void MouseHook_MouseMove(MouseHook.POINT ptLocat)
        {
            if (LstrLastEventlog != "滑鼠移動:" + ptLocat.x + "@" + ptLocat.y)
            {
                LarrRecord.Add("滑鼠移動:" + ptLocat.x + "@" + ptLocat.y);
                LstrLastEventlog = "滑鼠移動:" + ptLocat.x + "@" + ptLocat.y;
                LintLastPosX = ptLocat.x; LintLastPosY = ptLocat.y;
            }
        }
        //紀錄滑鼠事件(左鍵/右鍵)
        private void MouseHook_MouseEvent(MouseHook.MouseEvents mEvent)
        {
            string strKeyName = "";
            if (LstrLastEventlog != "滑鼠事件:" + mEvent.ToString() + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY)
            {
                switch (mEvent.ToString())
                {
                    case "LeftUp" :
                    case "RightUp" :
                    case "MiddleUp" :
                        LstrLastMouseDown = "";
                        break;
                    case "LeftDown":
                        strKeyName = "左鍵";
                        LstrLastMouseDown = mEvent.ToString();
                        LarrRecord.Add("滑鼠事件:" + strKeyName + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY);
                        LstrLastEventlog = "滑鼠事件:" + mEvent.ToString() + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY;
                        break;
                    case "RightDown":
                        strKeyName = "右鍵";
                        LstrLastMouseDown = mEvent.ToString();
                        LarrRecord.Add("滑鼠事件:" + strKeyName + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY);
                        LstrLastEventlog = "滑鼠事件:" + mEvent.ToString() + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY;
                        break;
                    case "MiddleDown":
                        strKeyName = "中鍵";
                        LstrLastMouseDown = mEvent.ToString();
                        LarrRecord.Add("滑鼠事件:" + strKeyName + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY);
                        LstrLastEventlog = "滑鼠事件:" + mEvent.ToString() + "@次數:1@X:" + LintLastPosX + "@Y:" + LintLastPosY;
                        break;
               }
            }      
        }
        //紀錄鍵盤事件
        private void KeyboardHook_KeyDown(int vkCode)
        {
            string keyString = ((Keys)vkCode).ToString(); //Convert the numeric value to a user easy to recognize string
            if (LstrLastEventlog != "鍵盤事件:" + keyString + "@次數:1")
            {
                if (LarrKeyList.Contains(keyString) == true)
                {
                    LarrRecord.Add("鍵盤事件:" + keyString + "@次數:1");
                }
                LstrLastEventlog = "鍵盤事件:" + keyString + "@次數:1";
            }        
        }
        //按下按鍵設定
        private void keyboardPressEvent(string strKey,int intTimes)
        {
            SendKeys.SendWait("{" + strKey + " " + intTimes.ToString() + "}");
        }
        //按下背端按鍵設定
        private void keyboardBkPressEvent(int inthwnd,string strKey, int intTimes)
        {
            PostMessage((IntPtr)inthwnd, WM_KEYDOWN, ExtractKeyCode(strKey), 0);
        }
        //多執行續-關閉執行動作
        private void StopEvent()
        {
            for (; ; )
            {
                if (GetAsyncKeyState(Keys.F8) != 0)
                {
                    LblnStopEvent = true; break;
                }
                else if (LblnStopThread == true)
                {
                    LblnStopThread = false; break;
                }
            }    
        }
        //多執行續-滑鼠連點
        private void MouseClickLoop()
        {
            for (; ; )
            {
                if (GetAsyncKeyState(Keys.F8) != 0)     //中斷操作
                {
                    break;
                }

                if (LblnRunAndStop == true)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
                    Thread.Sleep(LintMouseClkDelay);
                }
                else
                {
                    break;
                } 
            }   
        }
        //迴圈事件插入
        private void LoopControlInsAndUpdate(bool blnInsMode)
        {
            int intResult, intStartIndex, intEndIndex;
            try
            {
                if (Int32.TryParse(txtLoopNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[X]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (lstEventLog.SelectedItem != null)
                {
                    if (lstEventLog.SelectedItems.Count == 1)
                    {
                        if (lstEventLog.SelectedItem.ToString() == "") { return; }      //選擇是空白字串的情況下
                        lstEventLog.Items.Insert(lstEventLog.SelectedIndex + 1, "迴圈開始:次數:" + txtLoopNum.Text.Trim());
                        //lstEventLog.Items.Insert(lstEventLog.SelectedIndex + 2, "");
                        lstEventLog.Items.Insert(lstEventLog.SelectedIndex + 2, "迴圈結束");
                    }
                    else
                    {
                        //檢查所選擇的項目是否有迴圈
                        for (int I = 0; I < lstEventLog.SelectedItems.Count - 1; I++)
                        {
                            if (lstEventLog.SelectedItems[I].ToString().IndexOf("迴圈") > -1) { MessageBox.Show("插入點不可在迴圈中間", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        }
                        intStartIndex = (lstEventLog.SelectedIndices[0] == 0) ? 0 : lstEventLog.SelectedIndices[0];
                        intEndIndex = (lstEventLog.SelectedItems[lstEventLog.SelectedItems.Count - 1].ToString() == "") ? lstEventLog.SelectedIndices[lstEventLog.SelectedIndices.Count - 1] - 1
                                                                                                                        : lstEventLog.SelectedIndices[lstEventLog.SelectedIndices.Count - 1] + 2;
                        lstEventLog.Items.Insert(intStartIndex, "迴圈開始:次數:" + txtLoopNum.Text.Trim());
                        lstEventLog.Items.Insert(intEndIndex, "迴圈結束");
                    }
                }
                else
                {
                    lstEventLog.Items.Insert(lstEventLog.Items.Count - 1, "迴圈開始:次數:" + txtLoopNum.Text.Trim());
                    //lstEventLog.Items.Insert(lstEventLog.Items.Count - 1 , "");
                    lstEventLog.Items.Insert(lstEventLog.Items.Count - 1, "迴圈結束");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //移動LiseBox Index
        private void MoveListBoxSelectedItem(ListBox listBox, int direction, int intindex, ref bool blnTopOrDown)
        {
            try
            {
                // Checking selected item
                if (listBox.Items[intindex] == null || intindex < 0 || listBox.Items[intindex].ToString() == "")
                {
                    blnTopOrDown = true; return; // No selected item - nothing to do
                }    

                // Calculate new index using move direction
                int newIndex = intindex + direction;

                // Checking bounds of the range
                if (newIndex < 0 || newIndex >= listBox.Items.Count)
                {
                    blnTopOrDown = true; return; // Index out of range - nothing to do
                }

                if (listBox.Items[newIndex].ToString() == "")
                {
                    blnTopOrDown = true; return; // null str nothing to do
                }

                object selected = listBox.Items[intindex];
                // Save checked state if it is applicable
                var checkedListBox = listBox as CheckedListBox;
                var checkState = CheckState.Unchecked;
                if (checkedListBox != null)
                    checkState = checkedListBox.GetItemCheckState(intindex);

                // Removing removable element
                listBox.Items.Remove(selected);
                // Insert it in new position
                listBox.Items.Insert(newIndex, selected);
                // Restore selection
                listBox.SetSelected(newIndex, true);

                // Restore checked state if it is applicable
                if (checkedListBox != null)
                    checkedListBox.SetItemCheckState(newIndex, checkState);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //更新整體ListBox顯示狀態
        private void RefreshListBoxView()
        {
            string strLstLog = "",strTempStr = "",strBlank = "";
            string[] strEventMat;
            try
            {
                for (int i = 0; i <= lstEventLog.Items.Count - 1; i++)
                {
                    if (i == lstEventLog.Items.Count - 1)
                        return;
                    strLstLog = lstEventLog.Items[i].ToString();
                    strEventMat = strLstLog.Split(':');
                    switch (strEventMat[0].ToString().Trim())
                    {
                        case "迴圈開始":
                            if (strBlank == "")
                            {
                                strBlank += "   ";
                            }
                            else
                            {
                                strTempStr = strLstLog.Trim();
                                lstEventLog.Items[i] = strBlank + strTempStr;
                                strBlank += "   ";
                            }
                            break;
                        case "迴圈結束":
                            if (strBlank.Length > 2)
                            {
                                strBlank = strBlank.Remove(0, 3);
                                strTempStr = strLstLog.Trim();
                                lstEventLog.Items[i] = strBlank + strTempStr;
                            }
                            break;
                        default:
                            strTempStr = strLstLog.Trim();
                            lstEventLog.Items[i] = strBlank + strTempStr;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //讀取所有List事件，並將資料寫入到xml清單中
        private void SettingListEventToXml(XmlDocument objXMLDoc, XmlNode objTopNode,ref int intStep)
        {
            XmlNode objNode = null;
            string[] strEventMat,strMousePosMat,strKeyEventMat,strMouseEventMat;
            string strLstLog = "",strEvent = "", strMouseDown = "", strKeyDown = "", strPosX = "", strPosY = "", strNum = "";

            try
            {
                for (intStep += 0; intStep <= lstEventLog.Items.Count - 1; intStep++)
                {
                    strLstLog = lstEventLog.Items[intStep].ToString();
                    strEventMat = strLstLog.Trim().Split(':'); strEvent = strEventMat[0].ToString().Trim();
                    switch (strEvent)
                    {
                        case "滑鼠移動":    //滑鼠移動事件
                            strMousePosMat = strEventMat[1].ToString().Split('@');
                            strPosX = strMousePosMat[0]; strPosY = strMousePosMat[1];
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, "", "", strPosX, strPosY, "");
                            break;
                        case "鍵盤事件":    //鍵盤事件
                            strKeyEventMat = strEventMat[1].ToString().Split('@');
                            strKeyDown = strKeyEventMat[0].ToString();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, strKeyDown,"" , "", "", strNum);
                            break;
                        case "背端鍵盤事件":    //背端鍵盤事件
                            strKeyEventMat = strEventMat[1].ToString().Split('@');
                            strKeyDown = strKeyEventMat[0].ToString();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, strKeyDown, "", "", "", strNum);
                            break;
                        case "滑鼠事件":    //滑鼠點擊事件
                            strMouseEventMat = strLstLog.Trim().Split('@');
                            strMouseDown = strEventMat[1].ToString();
                            strPosX = strMouseEventMat[2].ToString().Split(':')[1].ToString(); strPosY = strMouseEventMat[3].ToString().Split(':')[1].ToString();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, "", strMouseDown, strPosX, strPosY, strNum);
                            break;
                        case "延遲時間":
                            strNum = strEventMat[1].ToString().Replace("ms", "");
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, "", "", "", "", strNum);
                            break;
                        case "視窗代碼":
                            strNum = strEventMat[1].ToString();
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, "", "", "", "", strNum);
                            break;
                        case "迴圈開始":
                            strNum = strEventMat[2].ToString();
                            objNode = AddNewMotionNode(objXMLDoc, objTopNode, strEvent, "", "", "", "", strNum);
                            intStep += 1;
                            SettingListEventToXml(objXMLDoc, objNode, ref intStep);
                            break;
                        case "迴圈結束":
                            return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //讀取xml資料並執行巨集事件
        private void RunningMarcoEvent(XmlNode objTopNode,int intTimes)
        {
            string strEvent = "", strMouseDown = "", strKeyDown = "", strPosX = "", strPosY = "", strNum = "";
            int inthwnd = 0,i = 0;
            try
            {
                do
                {
                    if (LblnStopEvent == true) { LblnRunAndStop = false; return; }
                    foreach (XmlNode objNode in objTopNode.SelectNodes("item"))
                    {
                        if (LblnStopEvent == true) { return; }
                        strEvent = GetXMLAttribute(objNode, "name", "");
                        strMouseDown = GetXMLAttribute(objNode, "MouseClick", "");
                        strKeyDown = GetXMLAttribute(objNode, "KeyClick", "");
                        strPosX = GetXMLAttribute(objNode, "PosX", "");
                        strPosY = GetXMLAttribute(objNode, "PosY", "");
                        strNum = GetXMLAttribute(objNode, "Number", "");
                        switch (strEvent)
                        {
                            case "滑鼠移動":    //滑鼠移動事件
                                Cursor.Position = new Point(Int32.Parse(strPosX), Int32.Parse(strPosY));
                                System.Threading.Thread.Sleep(10);
                                break;
                            case "鍵盤事件":    //鍵盤事件
                                for (int J = 0; J < Int32.Parse(strNum); J++)
                                {
                                    keyboardPressEvent(strKeyDown, 1);
                                    System.Threading.Thread.Sleep(LintKeyDelay);
                                }
                                break;
                            case "背端鍵盤事件":    //背端鍵盤事件
                                for (int J = 0; J < Int32.Parse(strNum); J++)
                                {
                                    keyboardBkPressEvent(inthwnd, strKeyDown, 1);
                                    System.Threading.Thread.Sleep(LintKeyDelay);
                                }
                                break;
                            case "滑鼠事件":    //滑鼠點擊事件
                                for (int J = 0; J < Int32.Parse(strNum); J++)
                                {
                                    Cursor.Position = new Point(Int32.Parse(strPosX), Int32.Parse(strPosY));
                                    switch (strMouseDown.Substring(0, 1).ToUpper())
                                    {
                                        case "左":       //左鍵
                                            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
                                            System.Threading.Thread.Sleep(LintMouseClkDelay);
                                            break;
                                        case "右":       //右鍵
                                            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
                                            System.Threading.Thread.Sleep(LintMouseClkDelay);
                                            break;
                                        case "中":
                                            mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
                                            System.Threading.Thread.Sleep(LintMouseClkDelay);
                                            break;
                                    }
                                }
                                break;
                            case "延遲時間":
                                System.Threading.Thread.Sleep(Int32.Parse(strNum));
                                break;
                            case "視窗代碼":
                                inthwnd = Int32.Parse(strNum);
                                break;
                            case "迴圈開始":
                                RunningMarcoEvent(objNode, Int32.Parse(strNum));
                                if (LblnStopEvent == true) { return; }
                                break;
                        }
                    }
                    if (LblnLoopState == false) {  i = i + 1; }
                } while (i < intTimes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //處理If的事件
        private void WriteIfCodeEvent()
        {

        }
        //處理For的事件
        private void WriteForCodeEvent()
        {

        }

        #endregion

        #region "     Private Function     "

        //新增節點資料
        private XmlNode AddNewMotionNode(XmlDocument objXMLDoc,string strEveName,string strKeyEve,string strMouseEve,
                                         string strPosX,string strPosY,string strNum)
        {
            XmlNode objNode = null;
            XmlElement objElement = null;
            try
            {
                objElement = objXMLDoc.CreateElement("item");
                objElement.SetAttribute("name", strEveName);
                objElement.SetAttribute("KeyClick", strKeyEve);
                objElement.SetAttribute("MouseClick", strMouseEve);
                objElement.SetAttribute("PosX", strPosX);
                objElement.SetAttribute("PosY", strPosY);
                objElement.SetAttribute("Number", strNum);
                objNode = objXMLDoc.AppendChild(objElement);
                return objNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return null;
            }
        }
        //新增節點資料 By Child
        private XmlNode AddNewMotionNode(XmlDocument objXMLDoc,XmlNode objTopNode, string strEveName, string strKeyEve, string strMouseEve,
                                         string strPosX, string strPosY, string strNum)
        {
            XmlNode objNode = null;
            XmlElement objElement = null;
            try
            {
                objElement = objXMLDoc.CreateElement("item");
                objElement.SetAttribute("name", strEveName);
                objElement.SetAttribute("KeyClick", strKeyEve);
                objElement.SetAttribute("MouseClick", strMouseEve);
                objElement.SetAttribute("PosX", strPosX);
                objElement.SetAttribute("PosY", strPosY);
                objElement.SetAttribute("Number", strNum);
                objNode = objTopNode.AppendChild(objElement);
                return objNode;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
                return null;
            }
        }
        //回傳指定節點資料
        private string GetXMLAttribute(XmlNode oNode, string strAttribute, string strDefault)
        {
            string LstrRetValue = "";
            XmlElement oElement;

            try
            {
                if (strDefault == null)
                    strDefault = "";
                oElement = (XmlElement)oNode;
                LstrRetValue = oElement.GetAttribute(strAttribute);
                return LstrRetValue;
            }
            catch (Exception ex)
            {
                return strDefault;
            }
        }
        //回傳按鍵代碼
        private int ExtractKeyCode(string strKey)
        {
            int intKey = 1;
            switch (strKey)
            {
                case "A":
                    intKey = VK_A;
                    break ;
                case "B":
                    intKey = VK_B;
                    break;
                case "C":
                    intKey = VK_C;
                    break;
                case "D":
                    intKey = VK_D;
                    break;
                case "E":
                    intKey = VK_E;
                    break;
                case "F":
                    intKey = VK_F;
                    break;
                case "G":
                    intKey = VK_G;
                    break;
                case "H":
                    intKey = VK_H;
                    break;
                case "I":
                    intKey = VK_I;
                    break;
                case "J":
                    intKey = VK_J;
                    break;
                case "K":
                    intKey = VK_K;
                    break;
                case "L":
                    intKey = VK_L;
                    break;
                case "M":
                    intKey = VK_M;
                    break;
                case "N":
                    intKey = VK_N;
                    break;
                case "O":
                    intKey = VK_O;
                    break;
                case "P":
                    intKey = VK_P;
                    break;
                case "Q":
                    intKey = VK_Q;
                    break;
                case "R":
                    intKey = VK_R;
                    break;
                case "S":
                    intKey = VK_S;
                    break;
                case "T":
                    intKey = VK_T;
                    break;
                case "U":
                    intKey = VK_U;
                    break;
                case "V":
                    intKey = VK_V;
                    break;
                case "W":
                    intKey = VK_W;
                    break;
                case "X":
                    intKey = VK_X;
                    break;
                case "Y":
                    intKey = VK_Y;
                    break;
                case "Z":
                    intKey = VK_Z;
                    break;
                case "F1":
                    intKey = VK_F1;
                    break;
                case "F2":
                    intKey = VK_F2;
                    break;
                case "F3":
                    intKey = VK_F3;
                    break;
                case "F4":
                    intKey = VK_F4;
                    break;
                case "F5":
                    intKey = VK_F5;
                    break;
                case "F6":
                    intKey = VK_F6;
                    break;
                case "F7":
                    intKey = VK_F7;
                    break;
                case "F8":
                    intKey = VK_F8;
                    break;
                case "F9":
                    intKey = VK_F9;
                    break;
                case "F10":
                    intKey = VK_F10;
                    break;
                case "F11":
                    intKey = VK_F11;
                    break;
                case "F12":
                    intKey = VK_F12;
                    break;
            }
            return intKey;
        }
        #endregion

        #region "     Button Event     "

        //錄製,結束錄製
        private void btnRecord_Click(object sender, EventArgs e)
        {
            int I = 0;

            try
            {
                switch (btnRecord.Text)
                {
                    case "錄製":
                        LarrRecord.Clear(); btnStart.Enabled = false; btnClear.Enabled = false; lstEventLog.Enabled = true;
                        //Adding keyboard event handlers and installing the hook
                        KeyboardHook.KeyDown += new KeyboardHook.KeyDownEventHandler(KeyboardHook_KeyDown);
                        //KeyboardHook.KeyUp += new KeyboardHook.KeyUpEventHandler(KeyboardHook_KeyUp);
                        KeyboardHook.InstallHook();

                        //Adding mouse event handlers and installing the hook
                        MouseHook.MouseEvent += new MouseHook.MouseEventEventHandler(MouseHook_MouseEvent);
                        MouseHook.MouseMove += new MouseHook.MouseMoveEventHandler(MouseHook_MouseMove);
                        //MouseHook.WheelEvent += new MouseHook.WheelEventEventHandler(MouseHook_WheelEvent);
                        MouseHook.InstallHook();

                        btnRecord.Text = "結束錄製";
                        btnRecord.Image = Properties.Resources.RecRed.ToBitmap();
                        break;
                    case "結束錄製":
                        MouseHook.UninstallHook(); KeyboardHook.UninstallHook();
                        //刪除最後點擊的結束錄製的紀錄        
                        if (LarrRecord.Count > 0)
                        {
                            if (LarrRecord.Count > 1)
                            {
                                if (LarrRecord[LarrRecord.Count - 2].ToString().IndexOf("左鍵") > 0) { LarrRecord.RemoveAt(LarrRecord.Count - 2); }
                            }
                            lstEventLog.Items.Clear();
                            for (I = 0; I < LarrRecord.Count - 1; I++)
                            {
                                lstEventLog.Items.Add(LarrRecord[I].ToString());
                            }
                        }
                        else 
                        {
                            lstEventLog.Items.Clear();
                        }
                        btnRecord.Text = "錄製"; lstEventLog.Items.Add(""); 
                        btnStart.Enabled = true;  btnClear.Enabled = true;  lstEventLog.Enabled = true;
                        btnRecord.Image = Properties.Resources.RecGen.ToBitmap();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //執行
        private void btnStart_Click(object sender, EventArgs e)
        {
            XmlDocument objXMLDoc = new XmlDocument();
            XmlNode objTopNode;
            XmlElement objElement;
            int intI = 0;
            System.Threading.Thread PrvStopEvent = new System.Threading.Thread(StopEvent);
            try
            {
                if (lstEventLog.Items.Count == 1) { MessageBox.Show("請先執行錄製", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                btnRecord.Enabled = false; btnClear.Enabled = false; lstEventLog.Enabled = false;
                PrvStopEvent.Name = "StopEvent"; PrvStopEvent.Start();
                this.Cursor = new Cursor(Cursor.Current.Handle);
                LblnStopKeyEvent = true; LblnStopThread = false;
                this.Hide(); this.notifyIcon.Visible = true;
                //新增XML檔案暫存紀錄
                objXMLDoc.AppendChild(objXMLDoc.CreateXmlDeclaration("1.0", "UTF-8", "yes"));
                objElement = objXMLDoc.CreateElement("sections");
                objTopNode = objXMLDoc.AppendChild(objElement);
                //讀取所有List事件，並將資料寫入到xml清單中
                SettingListEventToXml(objXMLDoc, objTopNode, ref intI);
                //讀取xml資料並執行巨集事件
                RunningMarcoEvent(objTopNode, LintRepeat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                Application.DoEvents();
                btnRecord.Enabled = true; btnClear.Enabled = true; lstEventLog.Enabled = true;
                LblnStopEvent = false;  LblnStopThread = true;
                LblnStopKeyEvent = false;
                this.Show(); this.WindowState = FormWindowState.Normal;
            }
        }
        //清除結果
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstEventLog.Items.Clear();
            LarrRecord.Clear();
            lstEventLog.Items.Add("");
        }
        //事件新增
        private void btnInsertEvent(object sender, EventArgs e)
        {
            string strTag,strMouseKey;
            int intResult;
            Button btnSelect = (Button)sender;

            try
            {
                if (btnSelect.Tag != null)
                {
                    strTag = btnSelect.Tag.ToString();
                    switch (strTag)
                    {
                        case "MouseMove":
                            if (Int32.TryParse(txtXPos.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[X]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (Int32.TryParse(txtYPos.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[Y]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, "滑鼠移動:" + txtXPos.Text.Trim() + "@" + txtYPos.Text.Trim());
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, "滑鼠移動:" + txtXPos.Text.Trim() + "@" + txtYPos.Text.Trim());
                            }
                            break;
                        case "MouseClick":
                            string strOutPutEvent;
                            if (Int32.TryParse(txtMPosX.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[X]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (Int32.TryParse(txtMPosY.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的滑鼠座標欄位[Y]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (Int32.TryParse(txtClickNumb.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (cobClickMode.Text.Trim() == "左鍵") { strMouseKey = "左鍵"; }
                            else if (cobClickMode.Text.Trim() == "右鍵") { strMouseKey = "右鍵"; }
                            else { strMouseKey = "中鍵"; }
                            strOutPutEvent = "滑鼠事件:" + strMouseKey + "@次數:" + txtClickNumb.Text.Trim() + "@X:" + txtMPosX.Text.Trim() + "@Y:" + txtMPosY.Text.Trim();
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, strOutPutEvent);
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, strOutPutEvent);
                            }
                            break;
                        case "KeyBoardDown":
                            if (Int32.TryParse(txtKeyNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (cobKey.Text.Trim() == "") { MessageBox.Show("請選擇鍵盤按鍵", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, "鍵盤事件:" + cobKey.Text.Trim() + "@次數:" + txtKeyNum.Text.Trim());
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, "鍵盤事件:" + cobKey.Text.Trim() + "@次數:" + txtKeyNum.Text.Trim());
                            }
                            break;
                        case "DelayControl":
                            if (Int32.TryParse(txtDelay.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[延遲]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, "延遲時間:" + txtDelay.Text.Trim() + "ms");
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, "延遲時間:" + txtDelay.Text.Trim() + "ms");
                            }
                            break;
                        case "LoopControl":
                            LoopControlInsAndUpdate(true);
                            break;
                        case "KeyBkBoardDown":
                            if (Int32.TryParse(txtBkKeyNum.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[次數]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (cobBkKey.Text.Trim() == "") { MessageBox.Show("請選擇鍵盤按鍵", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, "背端鍵盤事件:" + cobBkKey.Text.Trim() + "@次數:" + txtBkKeyNum.Text.Trim());
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, "背端鍵盤事件:" + cobBkKey.Text.Trim() + "@次數:" + txtBkKeyNum.Text.Trim());
                            }
                            break;
                        case "WinCodeControl":
                            if (Int32.TryParse(txtCode.Text.Trim(), out intResult) == false) { MessageBox.Show("輸入的欄位[視窗代碼]不為數字", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            if (lstEventLog.SelectedItem != null)
                            {
                                lstEventLog.Items.Insert(lstEventLog.SelectedIndex, "視窗代碼:" + txtCode.Text.Trim());
                            }
                            else
                            {
                                lstEventLog.Items.Insert(0, "視窗代碼:" + txtCode.Text.Trim());
                            }
                            break;
                        default:
                            MessageBox.Show("無法找到按鈕相關的新增事件，請管理人員處理(Tag Text)", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
                else
                {
                    MessageBox.Show("無法找到按鈕相關的新增事件，請管理人員處理(Tag Object)", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
                RefreshListBoxView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //ListBox上下移動
        private void btnListMoveEvent(object sender, EventArgs e)
        {
            string strTag;
            Button btnSelect = (Button)sender;
            bool blnTopOrDown = false;

            try
            {
                if (btnSelect.Tag != null)
                {
                    strTag = btnSelect.Tag.ToString();
                    switch (strTag)
                    {
                        case "Up":
                            for (int i = 0; i <= lstEventLog.SelectedIndices.Count - 1; i++)
                            {
                                MoveListBoxSelectedItem(lstEventLog, -1, lstEventLog.SelectedIndices[i],ref blnTopOrDown);
                                if (blnTopOrDown == true)
                                    break;
                            }            
                            break;
                        case "Down":
                            for (int i = lstEventLog.SelectedIndices.Count - 1; i >= 0; i--)
                            {
                                MoveListBoxSelectedItem(lstEventLog, 1, lstEventLog.SelectedIndices[i], ref blnTopOrDown);
                                if (blnTopOrDown == true)
                                    break;
                            }    
                            break;
                        default:
                            MessageBox.Show("無法找到移動事件，請管理人員處理(Tag Text)", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                }
                else
                {
                    MessageBox.Show("無法找到移動事件事件，請管理人員處理(Tag Object)", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
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

        #region "     Timer Event     "

        private void TimeMouseMv_Tick(object sender, EventArgs e)
        {   
           lblX.Text = "X:" + Cursor.Position.X.ToString();
           lblY.Text = "Y:" + Cursor.Position.Y.ToString();
      
           //按鍵的控制
           if (LblnStopKeyEvent == true) { return; }

           if (GetAsyncKeyState(Keys.F6) != 0)      //錄製、結束錄製
           {
               btnRecord_Click(btnRecord, new EventArgs());
           }
           else if (GetAsyncKeyState(Keys.F7) != 0) //執行
           {
               btnStart_Click(btnStart, new EventArgs());
           }
           else if (GetAsyncKeyState(Keys.Delete) != 0) //刪除
           {
               tsmiDelete_Click(tsmiDelete, new EventArgs());
           }
           else if (GetAsyncKeyState(Keys.F9) != 0) //滑鼠連點
           {
                if (LblnRunAndStop == false)
                {
                    LblnRunAndStop = true;
                    //多執行序
                    System.Threading.Thread MouseClick = new System.Threading.Thread(MouseClickLoop);
                    MouseClick.Name = "MouseClick"; MouseClick.Start();
                }
                else
                {
                    LblnRunAndStop = false;
                }
            }
        }

        #endregion

        #region "     ListBox Event     "

        private void lstEventLog_DoubleClick(object sender, EventArgs e)
        {
            string strSelectItem, strKeySelect, strNum, strMouseClick, strPosX, strPosY, strEvent, strOutPutStr;
            string[] strEventMat, strKeyEventMat, strMousePosMat, strMouseEventMat;
            try
            {
                if (lstEventLog.SelectedItem != null)
                {
                    strSelectItem = lstEventLog.SelectedItem.ToString();
                    if (strSelectItem == "") { return; }
                    strEventMat = strSelectItem.Split(':');                    //事件(滑鼠移動,滑鼠按鍵,鍵盤按鍵)
                    strEvent = strEventMat[0].ToString().Trim();
                    frmUpdateEvent frmUpdateEvent = new frmUpdateEvent();
                    switch (strEvent)
                    {
                        case "滑鼠移動":    //滑鼠移動事件
                            strMousePosMat = strEventMat[1].ToString().Split('@');
                            LintLastPosX = Int32.Parse(strMousePosMat[0]); LintLastPosY = Int32.Parse(strMousePosMat[1]);
                            //設定參數
                            frmUpdateEvent.strEvent = strEvent;                     //事件類別
                            frmUpdateEvent.intLastPosX = LintLastPosX;              //滑鼠X座標
                            frmUpdateEvent.intLastPosY = LintLastPosY;              //滑鼠Y座標
                            break;
                        case "鍵盤事件":    //鍵盤事件         
                            strKeyEventMat = strEventMat[1].ToString().Split('@');
                            strKeySelect = strKeyEventMat[0].ToString();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            //設定參數
                            frmUpdateEvent.strEvent = strEvent;                    //事件類別
                            frmUpdateEvent.strKeySelect = strKeySelect;            //鍵盤點擊項目
                            frmUpdateEvent.strUseNum = strNum;                     //按鍵次數
                            break;
                        case "背端鍵盤事件":  //背端鍵盤事件
                            strKeyEventMat = strEventMat[1].ToString().Split('@');
                            strKeySelect = strKeyEventMat[0].ToString();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            //設定參數
                            frmUpdateEvent.strEvent = strEvent;                    //事件類別
                            frmUpdateEvent.strKeySelect = strKeySelect;            //鍵盤點擊項目
                            frmUpdateEvent.strUseNum = strNum;                     //按鍵次數
                            break;
                        case "滑鼠事件":    //滑鼠點擊事件
                            strMouseEventMat = strSelectItem.Split('@');
                            strPosX = strMouseEventMat[2].ToString().Split(':')[1].ToString(); strPosY = strMouseEventMat[3].ToString().Split(':')[1].ToString();
                            strMouseClick = strEventMat[1].ToString().Substring(0, 1).ToUpper();
                            strNum = strEventMat[2].ToString().Split('@')[0];
                            //設定參數
                            frmUpdateEvent.strEvent = strEvent;                    //事件類別
                            frmUpdateEvent.strMouseClick = strMouseClick;          //滑鼠點擊項目
                            frmUpdateEvent.strUseNum = strNum;                     //按鍵次數
                            frmUpdateEvent.intLastPosX = Int32.Parse(strPosX);     //滑鼠X座標
                            frmUpdateEvent.intLastPosY = Int32.Parse(strPosY);     //滑鼠Y座標
                            break;
                        case "延遲時間":
                            frmUpdateEvent.strEvent = strEvent;                                              //事件類別
                            frmUpdateEvent.strDelayTime = strEventMat[1].ToString().Replace("ms", "");       //延遲時間
                            break;
                        case "視窗代碼":
                            frmUpdateEvent.strEvent = strEvent;                                              //事件類別
                            frmUpdateEvent.strWinCode = strEventMat[1].ToString();                           //視窗代碼
                            break;
                        case "迴圈開始":
                            frmUpdateEvent.strEvent = strEvent;                                              //事件類別
                            frmUpdateEvent.strUseNum =  strEventMat[strEventMat.Length - 1].ToString();      //次數
                            break;
                        default:
                            MessageBox.Show("未搜尋到任何指定事件，請重新點選！", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                    frmUpdateEvent.ShowDialog();
                    strOutPutStr = frmUpdateEvent.strOutPutEvent;
                    if (strOutPutStr != null) { lstEventLog.Items[lstEventLog.SelectedIndex] = strOutPutStr; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void lstEventLog_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left && e.Clicks != 2)
                {
                    Lindexofsource = ((ListBox)sender).IndexFromPoint(e.X, e.Y);
                    if (Lindexofsource != ListBox.NoMatches)
                    {
                        ((ListBox)sender).DoDragDrop(((ListBox)sender).Items[Lindexofsource].ToString(), DragDropEffects.All);

                        if (lstEventLog.SelectedItem != null)
                        {
                            if (lstEventLog.SelectedItem.ToString().IndexOf("迴圈開始") > -1)           //多選
                            { 
                                for (int i = lstEventLog.SelectedIndex + 1; ; i++)
                                {
                                    lstEventLog.SelectedIndices.Add(i);
                                    if (lstEventLog.Items[i].ToString().IndexOf("迴圈結束") > -1)
                                        break;
                                }
                            }                                                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void lstEventLog_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(typeof(System.String)) && ((ListBox)sender).Equals(lstEventLog))
                {
                    e.Effect = DragDropEffects.Move;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }     
        }

        private void lstEventLog_DragDrop(object sender, DragEventArgs e)
        {
            ListBox lstTemp = (ListBox)sender;
            string strLstItemsT;
            try
            {
                if (lstTemp.Items[Lindexofsource].ToString() == "" || lstTemp.Items[Lindexofsource].ToString().IndexOf("迴圈") > -1) { return; }
                Lindexoftarget = lstTemp.IndexFromPoint(lstTemp.PointToClient(new Point(e.X, e.Y)));
                if (Lindexoftarget != ListBox.NoMatches)
                {
                    strLstItemsT = lstTemp.Items[Lindexoftarget].ToString();
                    if (strLstItemsT.Trim() == "" && Lindexoftarget + 1 != lstEventLog.Items.Count)
                    { lstTemp.Items[Lindexoftarget] = lstTemp.Items[Lindexofsource]; lstTemp.Items.RemoveAt(Lindexofsource); }
                    else
                    {
                        if (Lindexofsource < Lindexoftarget)            //來源的Index小於目標的Index情況
                        {
                            lstTemp.Items.Insert(Lindexoftarget + 1, lstTemp.Items[Lindexofsource]);
                            lstTemp.Items.RemoveAt(Lindexofsource);
                            lstTemp.SelectedIndex = Lindexoftarget;
                        }
                        else                                            //來的Index大於目標的Index情況
                        {
                            lstTemp.Items.Insert(Lindexoftarget + 1, lstTemp.Items[Lindexofsource]);
                            lstTemp.Items.RemoveAt(Lindexofsource + 1);
                            lstTemp.SelectedIndex = Lindexoftarget;
                        }
                    }
                }
                RefreshListBoxView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void lstEventLog_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Black;
            StringFormat strFormat = new StringFormat();

            try
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    myBrush = new SolidBrush(RowSelectColor);
                }
                else if (e.Index % 2 == 0)
                {
                    myBrush = new SolidBrush(RowBackColorAltA);
                }
                else
                {
                    myBrush = new SolidBrush(RowBackColorAltB);
                }
                e.Graphics.FillRectangle(myBrush, e.Bounds);
                e.DrawFocusRectangle();//焦点框 

                //文本 
                //strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                if (e.Index != -1)
                {
                    e.Graphics.DrawString(lstEventLog.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, strFormat);
                }          
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void lstEventLog_Click(object sender, EventArgs e)
        {
            if (lstEventLog.SelectedItem != null)
            {
                if (lstEventLog.SelectedItem.ToString().IndexOf("迴圈開始") > -1)
                {
                    for (int i = lstEventLog.SelectedIndex + 1; ; i++)
                    {
                        lstEventLog.SelectedIndices.Add(i);
                        if (lstEventLog.Items[i].ToString().IndexOf("迴圈結束") > -1)
                            break;
                    }
                }
            }
        }

        #endregion

        #region "     TabControl Pretty     "

        private void tabEventCtl_DrawItem(object sender, DrawItemEventArgs e)
        {
            StringFormat sfForamt = new StringFormat();
            sfForamt.LineAlignment = StringAlignment.Center;
            sfForamt.Alignment = StringAlignment.Center;
            TabControl tcTab = (TabControl)sender;
            e.Graphics.DrawString(tcTab.TabPages[e.Index].Text, SystemInformation.MenuFont, new SolidBrush(Color.Black), e.Bounds, sfForamt);
        }

        #endregion

        #region "     ContextMenuStrip Event     "

        #region "     ctmusControl Event     "

        //複製
        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEventLog.SelectedItems.Count != 0)
                {
                    LarrCopyItems.Clear();
                    for (int I = lstEventLog.SelectedIndices.Count - 1; I >= 0; I--)
                    {
                        if (lstEventLog.Items[lstEventLog.SelectedIndices[I]].ToString() == "") { continue; }
                        LarrCopyItems.Add(lstEventLog.Items[lstEventLog.SelectedIndices[I]].ToString());
                    }
                    tsmiPaste.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //貼上
        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            int intIndex;
            if (LarrCopyItems.Count != 0)
            {
                if (lstEventLog.SelectedItem != null)
                {
                    for (int I = 0; I <= LarrCopyItems.Count - 1; I++)
                    {
                        intIndex = lstEventLog.SelectedIndex;
                        lstEventLog.Items.Insert(intIndex, LarrCopyItems[I].ToString());
                        intIndex -= 1;
                    }
                }
            }
        }
        //刪除
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstEventLog.SelectedItems.Count != 0)
                {
                    for (int I = lstEventLog.SelectedIndices.Count - 1; I >= 0; I--)
                    {
                        if (lstEventLog.Items[lstEventLog.SelectedIndices[I]].ToString() == "") { continue; }
                        lstEventLog.Items.RemoveAt(lstEventLog.SelectedIndices[I]);
                    }
                }
                RefreshListBoxView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        #endregion

        #region "     ctmusNotify Event     "

        //結束
        private void tsmiEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion     

        #endregion

        #region "     MenuStrip Event     "

        //離開
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //按鍵說明
        private void tsmiKeyDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("可紀錄的按鍵如下:" + Environment.NewLine + "A-Z" + Environment.NewLine + "F1~F12" +
                            Environment.NewLine + Environment.NewLine + "不可紀錄按鍵:" + Environment.NewLine + "暫無" +
                            Environment.NewLine + Environment.NewLine + "功能按鍵說明:" + Environment.NewLine + "F6:錄製" +
                            Environment.NewLine + "F7:執行" + Environment.NewLine + "F8:中斷執行" + Environment.NewLine + "F9:滑鼠連點(吃滑鼠按鍵延遲)", "系統訊息", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //開新檔案
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if (lstEventLog.Items.Count != 1)
                if (MessageBox.Show("尚有資料，請問是否開新檔案？", "詢問視窗", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    lstEventLog.Items.Clear(); lstEventLog.Items.Add("");
        }
        //儲存
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            string strDirectory;
            try
            {
                if (lstEventLog.Items.Count == 1) { return; }
                FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
                if (FolderBrowser.ShowDialog() == DialogResult.OK)
                {
                    strDirectory = FolderBrowser.SelectedPath;
                    StreamWriter sw = new StreamWriter(strDirectory + "\\Record.txt", false, Encoding.Unicode);
                    foreach (string strLstLog in lstEventLog.Items)
                    {
                        sw.WriteLine(strLstLog);
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //載入
        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            string strFullPath,  strLine;
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Title = "請選擇檔案";
                OpenFile.Filter = "Text|*.txt|All|*.*";
                OpenFile.FilterIndex = 1;
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    lstEventLog.Items.Clear();
                    strFullPath = OpenFile.FileName;
                    StreamReader sr = new StreamReader(strFullPath);
                    lstEventLog.Items.Clear();
                    strLine = sr.ReadLine();
                    while (strLine != null)
                    {
                        lstEventLog.Items.Add(strLine);
                        strLine = sr.ReadLine();
                    }
                    sr.Close();
                    if (lstEventLog.Items[lstEventLog.Items.Count - 1].ToString().Trim() != "") { lstEventLog.Items.Add(""); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //環境設定
        private void tsmiSysOption_Click(object sender, EventArgs e)
        {
            try
            {
                frmOption frmOption = new frmOption();
                frmOption.intKeyDelay = LintKeyDelay;
                frmOption.intMouseClkDelay = LintMouseClkDelay;
                frmOption.intMouseMovDelay = LintMouseMovDelay;
                frmOption.intRepeat = LintRepeat;
                frmOption.intRepeatDelay = LintRepeatDelay;
                frmOption.RowBackColorAltA = RowBackColorAltA;
                frmOption.RowBackColorAltB = RowBackColorAltB;
                frmOption.RowSelectColor = RowSelectColor;
                frmOption.RowBackColor = RowBackColor;
                frmOption.ShowDialog();
                LintKeyDelay = frmOption.intKeyDelay;
                LintMouseClkDelay = frmOption.intMouseClkDelay;
                LintMouseMovDelay = frmOption.intMouseMovDelay;
                LintRepeat = frmOption.intRepeat;
                LintRepeatDelay = frmOption.intRepeatDelay;
                RowBackColorAltA = frmOption.RowBackColorAltA;
                RowBackColorAltB = frmOption.RowBackColorAltB;
                RowSelectColor = frmOption.RowSelectColor;
                RowBackColor = frmOption.RowBackColor;
                //環境參數修改
                EnvironmentOption(false);
                lstEventLog.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        //無限迴圈
        private void tsmiLoop_Click(object sender, EventArgs e)
        {
            try
            {
                if (tsmiLoop.Checked == false)
                {
                    tsmiLoop.Checked = true;
                    LblnLoopState = true;
                }
                else 
                {
                    tsmiLoop.Checked = false;
                    LblnLoopState = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        #endregion

        #region "     notifyIcon Event     "

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //如果目前是縮小狀態，才要回覆成一般大小的視窗
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        #endregion

        #region "     TextBox Event     "

        private void txtItemWrite_TextChanged(object sender, EventArgs e)
        {
            //處理特殊事件
            WriteIfCodeEvent();
            WriteForCodeEvent();

        }

        #endregion
    }
}

#region "     Temp Code     "

//模擬按下"ABCDEFG"
//SendKeys.SendWait("(ABCDEFG)");
//SendKeys.SendWait("{left 5}");
//SendKeys.SendWait("{h 10}");
/*
更多舉例:
SendKeys.SendWait("^C");  //Ctrl+C 組合鍵
SendKeys.SendWait("+C");  //Shift+C 組合鍵
SendKeys.SendWait("%C");  //Alt+C 組合鍵
SendKeys.SendWait("+(AX)");  //Shift+A+X 組合鍵
SendKeys.SendWait("+AX");  //Shift+A 組合鍵,之後按X鍵
SendKeys.SendWait("{left 5}");  //按←鍵 5次
SendKeys.SendWait("{h 10}");   //按h鍵 10次
SendKeys.Send("漢字");  //模擬輸入"漢字"2個字
*/

//紀錄滑鼠滾輪的運動
//private void MouseHook_WheelEvent(MouseHook.MouseWheelEvents wEvent)
//{
//    //Event time the wheel was scrolled the application will go to this line
//    //Using the wEvent argument we can detect if the mouse was scrolled forward or backward

//    string scrollDirection;
//    if (wEvent == MouseHook.MouseWheelEvents.ScrollDown) scrollDirection = "scrolled down";
//    else scrollDirection = "scrolled up";

//    Log.Items.Add("The user mouse wheel was " + scrollDirection);
//}

//private void KeyboardHook_KeyUp(int vkCode)
//{
//    //Everytime the users releases a certain key up, your application will go to this line
//    //Use the vKCode argument to determine which key has been released

//    string keyString = ((Keys)vkCode).ToString(); //Convert the numeric value to a user easy to recognize string

//    //Log.Items.Add("User holds " + keyString); //Add the message to the Log listbox.
//}

////執行
//private void btnStart_Click(object sender, EventArgs e)
//{
//    string[] strEventMat, strKeyEventMat, strMouseEventMat, strMousePosMat;
//    string strPosX, strPosY, strNum,strDelay;
//    bool blnLoopStart = false; 
//    Hashtable hashLoopStart = new Hashtable();
//    ArrayList arrLoopRecord = new ArrayList();
//    System.Threading.Thread PrvStopEvent = new System.Threading.Thread(StopEvent);
//    try
//    {
//        if (lstEventLog.Items.Count == 1) { MessageBox.Show("請先執行錄製", "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);  return; }
//        btnRecord.Enabled = false; btnClear.Enabled = false; lstEventLog.Enabled = false;
//        PrvStopEvent.Name = "StopEvent";  PrvStopEvent.Start();
//        this.Cursor = new Cursor(Cursor.Current.Handle);
//        LblnStopKeyEvent = true; LblnStopThread = false;
//        this.Hide(); this.notifyIcon.Visible = true;
//        for (int I = 0; I < LintRepeat; I++)            //執行次數
//        {
//            foreach (string strLstLog in lstEventLog.Items)
//            {

//                if (LblnStopEvent == true) { LblnStopEvent = false;  return; } 
//                strEventMat = strLstLog.Trim().Split(':');
//                switch (strEventMat[0].ToString().Trim())
//                {
//                    case "滑鼠移動":    //滑鼠移動事件
//                        strMousePosMat = strEventMat[1].ToString().Split('@');
//                        LintLastPosX = Int32.Parse(strMousePosMat[0]); LintLastPosY = Int32.Parse(strMousePosMat[1]);
//                        Cursor.Position = new Point(LintLastPosX, LintLastPosY);
//                        System.Threading.Thread.Sleep(10);
//                        break;
//                    case "鍵盤事件":    //鍵盤事件
//                        strKeyEventMat = strEventMat[1].ToString().Split('@');
//                        strNum = strEventMat[2].ToString().Split('@')[0];
//                        for (int J = 0; J < Int32.Parse(strNum); J++)
//                        {
//                            keyboardPressEvent(strKeyEventMat[0].ToString(), 1);
//                            System.Threading.Thread.Sleep(LintKeyDelay);
//                        }
//                        break;
//                    case "滑鼠事件":    //滑鼠點擊事件
//                        strMouseEventMat = strLstLog.Trim().Split('@');
//                        strPosX = strMouseEventMat[2].ToString().Split(':')[1].ToString(); strPosY = strMouseEventMat[3].ToString().Split(':')[1].ToString();
//                        strNum = strEventMat[2].ToString().Split('@')[0];
//                        for (int J = 0; J < Int32.Parse(strNum); J++)
//                        {
//                            Cursor.Position = new Point(Int32.Parse(strPosX), Int32.Parse(strPosY));
//                            switch (strEventMat[1].ToString().Substring(0, 1).ToUpper())
//                            {
//                                case "左":       //左鍵
//                                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
//                                    System.Threading.Thread.Sleep(LintMouseClkDelay);
//                                    break;
//                                case "右":       //右鍵
//                                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
//                                    System.Threading.Thread.Sleep(LintMouseClkDelay);
//                                    break;
//                                case "中":
//                                    mouse_event(MOUSEEVENTF_MIDDLEDOWN | MOUSEEVENTF_MIDDLEUP, Int32.Parse(strPosX), Int32.Parse(strPosY), 0, 0);
//                                    System.Threading.Thread.Sleep(LintMouseClkDelay);
//                                    break;
//                            }
//                        }
//                        break;
//                    case "延遲時間":
//                        strDelay = strEventMat[1].ToString().Replace("ms", "");
//                        System.Threading.Thread.Sleep(Int32.Parse(strDelay));
//                        break;
//                    case "迴圈開始" :
//                        blnLoopStart = true;
//                        strNum = strEventMat[2].ToString();

//                        break;
//                    case "迴圈結束" :
//                        break;
//                }
//            }
//            System.Threading.Thread.Sleep(LintRepeatDelay);
//        }                
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
//    }
//    finally
//    {
//        Application.DoEvents();
//        btnRecord.Enabled = true; btnClear.Enabled = true; lstEventLog.Enabled = true;
//        LblnStopThread = true;
//        LblnStopKeyEvent = false;
//        this.Show(); this.WindowState = FormWindowState.Normal;
//    }
//}

//#region "     ListBox Pretty     "

////public class WenListBox : ListBox
////{
////    #region ======私有属性======
////    //选中项改变之前的选中项索引
////    private int selectBefore = -1;
////    private int MouseItemIndex;
////    private bool line = true;
////    private bool radioBox = true;
////    private Color oneRowColor = Color.DeepSkyBlue;
////    private Color towRowColor = Color.Aquamarine;
////    private Color selectedRowColor = Color.DarkCyan;
////    private Color mouseMoveRowColor = Color.Cyan;
////    private int itemHeight = 20;
////    #endregion
////    #region ======公有属性======
////    [Category("Wen"), Description("是否增加序号"), DefaultValue(true)]
////    public bool Line { get {return line;} set { line = value; this.Invalidate(); } } 
////    [Category("Wen"), Description("是否增加选框"), DefaultValue(true)] 
////    public bool RadioBox { get {return radioBox;} set { radioBox = value; this.Invalidate(); } }   
////    [Category("Wen"), Description("奇数行颜色"), DefaultValue(typeof(Color), "DeepSkyBlue")]  
////    public Color OneRowColor { get { return oneRowColor;} set { oneRowColor = value; this.Invalidate(); } } 
////    [Category("Wen"), Description("偶数行颜色"), DefaultValue(typeof(Color), "Aquamarine")]  
////    public Color TowRowColor { get { return towRowColor;} set { towRowColor = value; this.Invalidate(); } }
////    [Category("Wen"), Description("选中颜色"), DefaultValue(typeof(Color), "DarkCyan")]
////    public Color SelectedRowColor {get { return selectedRowColor;} set { selectedRowColor = value; this.Invalidate(); } }   
////    [Category("Wen"), Description("鼠标移动行颜色"), DefaultValue(typeof(Color), "Cyan")]
////    public Color MouseMoveRowColor { get { return mouseMoveRowColor; } set { mouseMoveRowColor = value; this.Invalidate(); } }
////    [Category("Wen"), Description("设置单项高度"), DefaultValue(20)]
////    public new int ItemHeight { get { return itemHeight; } set { base.ItemHeight = value; itemHeight = value; } }     
////    #endregion

////    public WenListBox()
////    {
////        base.SetStyle(
////            //ControlStyles.UserPaint |
////            ControlStyles.DoubleBuffer |
////            ControlStyles.OptimizedDoubleBuffer |
////            ControlStyles.AllPaintingInWmPaint |
////            ControlStyles.ResizeRedraw |
////            ControlStyles.SupportsTransparentBackColor, true);
////        base.UpdateStyles();
////        this.DrawMode = DrawMode.OwnerDrawFixed;
////        this.IntegralHeight = false;
////    }

////    private Brush GetBrush(string b)
////    {
////        return new SolidBrush(ColorTranslator.FromHtml(b));
////    }
////    private Brush GetBrush(Color c)
////    {
////        return new SolidBrush(c);
////    }

////    //重绘指定项 
////    protected override void OnDrawItem(DrawItemEventArgs e)
////    {
////        //base.OnDrawItem(e);  
////        if (Items.Count == 0 || e.Index < 0)
////            return;
////        Graphics g = e.Graphics;
////        Rectangle rec = GetItemRectangle(e.Index);
////        if (GetSelected(e.Index))
////        {
////            rec.Inflate(0, -2);
////            ItemDraw(e.Index, g, rec, SelectedRowColor, e);
////        }
////        else if (e.Index == MouseItemIndex)
////        {
////            ItemDraw(e.Index, g, rec, MouseMoveRowColor, e);
////        }
////        else if (e.Index % 2 != 1)
////        {
////            ItemDraw(e.Index, g, rec, OneRowColor, e);
////        }
////        else
////        {
////            ItemDraw(e.Index, g, rec, TowRowColor, e);
////        }
////    }
////    //刷新指定项目  
////    private void ItemDraw(int index, Graphics g, Rectangle rec, Color c, DrawItemEventArgs e)   
////    {
////    ControlHelper.SetGDIHigh(g);
////    g.FillRectangle(GetBrush(c), rec);
////    Brush brush = GetBrush(e.ForeColor); 
////    int radioWidth = 0;  
////    if (RadioBox)
////    {
////        radioWidth = 20;
////        Pen pen = new Pen(Color.Gray, 3);
////        g.DrawEllipse(new Pen(brush) { Width=2}, new Rectangle(rec.X, (ItemHeight - 15) / 2 + rec.Y, 15, 15));    
////        if (GetSelected(index))            
////            g.FillEllipse(brush, new Rectangle(rec.X + 5, (ItemHeight - 5) / 2 + rec.Y, 5, 5));   
////    }       
////    //绘制文字    
////    if (Line)        
////    {             
////        Rectangle recLine = new Rectangle(rec.X + radioWidth, rec.Y, 50 - radioWidth, this.ItemHeight);       
////        Rectangle recText = new Rectangle(rec.X + 50, rec.Y, rec.Width - 50, this.ItemHeight);         
////        g.DrawString((index + 1).ToString(), Font, brush, recLine, ControlHelper.StringConters);      
////        g.DrawString(Items[index]?.ToString(), Font, brush, recText, ControlHelper.StringConters);   
////    }       
////    else   
////    {          
////        Rectangle recText = new Rectangle(rec.X + radioWidth, rec.Y, rec.Width - radioWidth, this.ItemHeight);  
////        g.DrawString(Items[index]?.ToString(), Font, brush, recText, ControlHelper.StringConters);   
////    }    
////}
////    //鼠标移动 
////    protected override void OnMouseMove(MouseEventArgs e)
////    {
////        base.OnMouseMove(e);
////        int index = IndexFromPoint(e.Location);
////        if (index < 0) return;
////        if (MouseItemIndex != index)
////        {
////            int indexBefore = MouseItemIndex;
////            MouseItemIndex = index;
////            this.RefreshItem(index);
////            this.RefreshItem(indexBefore);
////        }
////    }
////}

//#endregion

#endregion
