using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Runtime.InteropServices;
using System.Net;

namespace XenosZ1
{
    public partial class MainForm : MetroForm
    {
        #region IMPORTS
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, uint dwExtraInfo);

        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;

        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        public static bool HotKey(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }
        #endregion

        private License license = new License();

        private IniFile Config;
        private Keys RCSHotKey = Keys.RButton;
        private Keys RFHotKey = Keys.MButton;

        private Keys AK47HotKey = Keys.F1;
        private int RCSDelayAK47 = 250;
        private int RFDelayAK47 = 30;

        private Keys AR15HotKey = Keys.F2;
        private int RCSDelayAR15 = 200;
        private int RFDelayAR15 = 30;

        private int Mode;
        private int RCSDelay;
        private int RFDelay;

        private void ConfigSave()
        {
            Config = new IniFile(Directory.GetCurrentDirectory() + "\\Config.ini");
            Config.Write("Global", "RCSHotKey", RCSHotKey.ToString());
            Config.Write("Global", "RFHotKey", RFHotKey.ToString());
            Config.Write("AK47", "HotKey", AK47HotKey.ToString());
            Config.Write("AK47", "RCSDelay", RCSDelayAK47.ToString());
            Config.Write("AK47", "RFDelay", RFDelayAK47.ToString());
            Config.Write("AR15", "HotKey", AR15HotKey.ToString());
            Config.Write("AR15", "RCSDelay", RCSDelayAR15.ToString());
            Config.Write("AR15", "RFDelay", RFDelayAR15.ToString());
        }

        private void ConfigLoad()
        {
            Config = new IniFile(Directory.GetCurrentDirectory() + "\\Config.ini");
            Enum.TryParse(Config.Read("Global", "RCSHotKey"), out RCSHotKey);
            Enum.TryParse(Config.Read("Global", "RFHotKey"), out RFHotKey);
            Enum.TryParse(Config.Read("AK47", "HotKey"), out AK47HotKey);
            RCSDelayAK47 = Convert.ToInt32(Config.Read("AK47", "RCSDelay"));
            RFDelayAK47 = Convert.ToInt32(Config.Read("AK47", "RFDelay"));
            Enum.TryParse(Config.Read("AR15", "HotKey"), out AR15HotKey);
            RCSDelayAR15 = Convert.ToInt32(Config.Read("AR15", "RCSDelay"));
            RFDelayAR15 = Convert.ToInt32(Config.Read("AR15", "RFDelay"));
        }

        private void RCSRF()
        {
            while (true)
            {
                if (license.GetVerified())
                {
                    if (HotKey(AK47HotKey))
                    {
                        Mode = 0;
                        RCSDelay = RCSDelayAK47;
                        RFDelay = RFDelayAK47;
                    }
                    else if (HotKey(AR15HotKey))
                    {
                        Mode = 1;
                        RCSDelay = RCSDelayAR15;
                        RFDelay = RFDelayAR15;
                    }
                    else if (HotKey(RCSHotKey))
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(10);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        Thread.Sleep(RCSDelay);
                    }
                    else if (HotKey(RFHotKey))
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        Thread.Sleep(10);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        Thread.Sleep(RFDelay);
                    }
                    else
                    {
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    Thread.Sleep(10);
                }  
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //TODO: MAKE HWID HASH FUNC and Verify Func
            HWIDText.Text = license.GetHWID();
            //Check config before comboboxes fuck the values up (next line adds data source but also executes selected index changed -.- )
            if (File.Exists("Config.ini") == false)
            {
                ConfigSave(); //Will write the default values if executed at start of program otherwise its useless.
            }
            //Load all they keys into ComboBoxes
            RCSHotKeyComb.DataSource = Enum.GetValues(typeof(Keys));
            RFHotKeyComb.DataSource = Enum.GetValues(typeof(Keys));
            AK47HotKeyComb.DataSource = Enum.GetValues(typeof(Keys));
            AR15HotKeyComb.DataSource = Enum.GetValues(typeof(Keys));
            //Load config values (all default values got fucked by previous datasoruce loading)
            ConfigLoad();
            //Change to loaded values in GUI
            RCSHotKeyComb.SelectedIndex = RCSHotKeyComb.FindStringExact(RCSHotKey.ToString());
            RFHotKeyComb.SelectedIndex = RFHotKeyComb.FindStringExact(RFHotKey.ToString());
            AK47HotKeyComb.SelectedIndex = AK47HotKeyComb.FindStringExact(AK47HotKey.ToString());
            RCSDelayAK47Label.Text = "No Recoil Delay: " + RCSDelayAK47.ToString();
            RCSDelayAK47Track.Value = RCSDelayAK47;
            RFDelayAK47Label.Text = "Rapid Fire Delay: " + RFDelayAK47.ToString();
            RFDelayAK47Track.Value = RFDelayAK47;
            AR15HotKeyComb.SelectedIndex = AR15HotKeyComb.FindStringExact(AR15HotKey.ToString());
            RCSDelayAR15Label.Text = "No Recoil Delay: " + RCSDelayAR15.ToString();
            RCSDelayAR15Track.Value = RCSDelayAR15;
            RFDelayAR15Label.Text = "Rapid Fire Delay: " + RFDelayAR15.ToString();
            RFDelayAR15Track.Value = RFDelayAR15;
            //Load the delay values for default weapon which is AK47
            Mode = 0;
            RCSDelay = RCSDelayAK47;
            RFDelay = RFDelayAK47;
            //Create and start the RCSRFThread
            Thread RCSRFThread = new Thread(new ThreadStart(RCSRF))
            {
                IsBackground = true
            };
            RCSRFThread.Start();
        }

        private void DiscordLink_Click(object sender, EventArgs e)
        {

        }

        private void SkypeLink_Click(object sender, EventArgs e)
        {

        }

        private void LoginVerify_Click(object sender, EventArgs e)
        {  
            HWIDLabel.Style = MetroFramework.MetroColorStyle.Red;
            HWIDText.Style = MetroFramework.MetroColorStyle.Red;
            Refresh();
            license.Verify();
            if (license.GetVerified())
            {
                HWIDLabel.Style = MetroFramework.MetroColorStyle.Lime;
                HWIDText.Style = MetroFramework.MetroColorStyle.Lime;
                Refresh();
            }
        }

        private void RCSHotKeyComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(RCSHotKeyComb.GetItemText(RCSHotKeyComb.SelectedItem), out RCSHotKey);
        }

        private void RFHotKeyComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(RFHotKeyComb.GetItemText(RFHotKeyComb.SelectedItem), out RFHotKey);
        }

        private void AK47HotKeyComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(AK47HotKeyComb.GetItemText(AK47HotKeyComb.SelectedItem), out AK47HotKey);
        }

        private void AR15HotKeyComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse(AR15HotKeyComb.GetItemText(AR15HotKeyComb.SelectedItem), out AR15HotKey);
        }

        private void RCSDelayAK47Track_Scroll(object sender, ScrollEventArgs e)
        {
            RCSDelayAK47Track.Value = (RCSDelayAK47Track.Value / 10) * 10; //SO ITS ONLY ADJUSTABLE BY +-10
            RCSDelayAK47 = RCSDelayAK47Track.Value;
            RCSDelayAK47Label.Text = "No Recoil Delay: " + RCSDelayAK47.ToString();
        }

        private void RFDelayAK47Track_Scroll(object sender, ScrollEventArgs e)
        {
            RFDelayAK47Track.Value = (RFDelayAK47Track.Value / 10) * 10;
            RFDelayAK47 = RFDelayAK47Track.Value;
            RFDelayAK47Label.Text = "Rapid Fire Delay: " + RFDelayAK47.ToString();
        }

        private void RCSDelayAR15Track_Scroll(object sender, ScrollEventArgs e)
        {
            RCSDelayAR15Track.Value = (RCSDelayAR15Track.Value / 10) * 10;
            RCSDelayAR15 = RCSDelayAR15Track.Value;
            RCSDelayAR15Label.Text = "No Recoil Delay: " + RCSDelayAR15.ToString();
        }

        private void RFDelayAR15Track_Scroll(object sender, ScrollEventArgs e)
        {
            RFDelayAR15Track.Value = (RFDelayAR15Track.Value / 10) * 10;
            RFDelayAR15 = RFDelayAR15Track.Value;
            RFDelayAR15Label.Text = "Rapid Fire Delay: " + RFDelayAR15.ToString();
        }

        private void RCSRFSave_Click(object sender, EventArgs e)
        {
            ConfigSave();
        }
    }
}
