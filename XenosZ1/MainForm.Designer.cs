namespace XenosZ1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabs = new MetroFramework.Controls.MetroTabControl();
            this.LoginTab = new MetroFramework.Controls.MetroTabPage();
            this.HWIDLabel = new MetroFramework.Controls.MetroLabel();
            this.SkypeLink = new MetroFramework.Controls.MetroLink();
            this.DiscordLink = new MetroFramework.Controls.MetroLink();
            this.LoginHelpLabel2 = new MetroFramework.Controls.MetroLabel();
            this.LoginVerify = new MetroFramework.Controls.MetroButton();
            this.HWIDText = new MetroFramework.Controls.MetroTextBox();
            this.LoginHelpLabel = new MetroFramework.Controls.MetroLabel();
            this.RCSRFTab = new MetroFramework.Controls.MetroTabPage();
            this.RCSRFSave = new MetroFramework.Controls.MetroButton();
            this.RFHotKeyComb = new MetroFramework.Controls.MetroComboBox();
            this.RCSHotKeyComb = new MetroFramework.Controls.MetroComboBox();
            this.RFHotKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.RCSHotKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.RCSRFWeaponTab = new MetroFramework.Controls.MetroTabControl();
            this.AK47Tab = new MetroFramework.Controls.MetroTabPage();
            this.AK47HotKeyComb = new MetroFramework.Controls.MetroComboBox();
            this.AK47HotKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.RCSDelayAK47Label = new MetroFramework.Controls.MetroLabel();
            this.RCSDelayAK47Track = new MetroFramework.Controls.MetroTrackBar();
            this.RFDelayAK47Label = new MetroFramework.Controls.MetroLabel();
            this.RFDelayAK47Track = new MetroFramework.Controls.MetroTrackBar();
            this.AR15Tab = new MetroFramework.Controls.MetroTabPage();
            this.AR15HotKeyComb = new MetroFramework.Controls.MetroComboBox();
            this.AR15HotKeyLabel = new MetroFramework.Controls.MetroLabel();
            this.RCSDelayAR15Label = new MetroFramework.Controls.MetroLabel();
            this.RCSDelayAR15Track = new MetroFramework.Controls.MetroTrackBar();
            this.RFDelayAR15Label = new MetroFramework.Controls.MetroLabel();
            this.RFDelayAR15Track = new MetroFramework.Controls.MetroTrackBar();
            this.MainTabs.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.RCSRFTab.SuspendLayout();
            this.RCSRFWeaponTab.SuspendLayout();
            this.AK47Tab.SuspendLayout();
            this.AR15Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.LoginTab);
            this.MainTabs.Controls.Add(this.RCSRFTab);
            this.MainTabs.Location = new System.Drawing.Point(23, 63);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(254, 312);
            this.MainTabs.Style = MetroFramework.MetroColorStyle.Blue;
            this.MainTabs.TabIndex = 0;
            this.MainTabs.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTabs.UseSelectable = true;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.HWIDLabel);
            this.LoginTab.Controls.Add(this.SkypeLink);
            this.LoginTab.Controls.Add(this.DiscordLink);
            this.LoginTab.Controls.Add(this.LoginHelpLabel2);
            this.LoginTab.Controls.Add(this.LoginVerify);
            this.LoginTab.Controls.Add(this.HWIDText);
            this.LoginTab.Controls.Add(this.LoginHelpLabel);
            this.LoginTab.HorizontalScrollbarBarColor = true;
            this.LoginTab.HorizontalScrollbarHighlightOnWheel = false;
            this.LoginTab.HorizontalScrollbarSize = 10;
            this.LoginTab.Location = new System.Drawing.Point(4, 38);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(246, 270);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            this.LoginTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginTab.VerticalScrollbarBarColor = true;
            this.LoginTab.VerticalScrollbarHighlightOnWheel = false;
            this.LoginTab.VerticalScrollbarSize = 10;
            // 
            // HWIDLabel
            // 
            this.HWIDLabel.Location = new System.Drawing.Point(3, 47);
            this.HWIDLabel.Name = "HWIDLabel";
            this.HWIDLabel.Size = new System.Drawing.Size(240, 20);
            this.HWIDLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.HWIDLabel.TabIndex = 9;
            this.HWIDLabel.Text = "HWID";
            this.HWIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HWIDLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HWIDLabel.UseStyleColors = true;
            // 
            // SkypeLink
            // 
            this.SkypeLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SkypeLink.Location = new System.Drawing.Point(3, 151);
            this.SkypeLink.Name = "SkypeLink";
            this.SkypeLink.Size = new System.Drawing.Size(117, 20);
            this.SkypeLink.TabIndex = 7;
            this.SkypeLink.Text = "Skype";
            this.SkypeLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SkypeLink.UseSelectable = true;
            this.SkypeLink.UseStyleColors = true;
            this.SkypeLink.Click += new System.EventHandler(this.SkypeLink_Click);
            // 
            // DiscordLink
            // 
            this.DiscordLink.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DiscordLink.Location = new System.Drawing.Point(126, 151);
            this.DiscordLink.Name = "DiscordLink";
            this.DiscordLink.Size = new System.Drawing.Size(117, 20);
            this.DiscordLink.Style = MetroFramework.MetroColorStyle.Purple;
            this.DiscordLink.TabIndex = 6;
            this.DiscordLink.Text = "Discord";
            this.DiscordLink.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DiscordLink.UseSelectable = true;
            this.DiscordLink.UseStyleColors = true;
            this.DiscordLink.Click += new System.EventHandler(this.DiscordLink_Click);
            // 
            // LoginHelpLabel2
            // 
            this.LoginHelpLabel2.Location = new System.Drawing.Point(3, 119);
            this.LoginHelpLabel2.Name = "LoginHelpLabel2";
            this.LoginHelpLabel2.Size = new System.Drawing.Size(240, 20);
            this.LoginHelpLabel2.TabIndex = 5;
            this.LoginHelpLabel2.Text = "Support - Contact links";
            this.LoginHelpLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginHelpLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LoginVerify
            // 
            this.LoginVerify.Location = new System.Drawing.Point(3, 244);
            this.LoginVerify.Name = "LoginVerify";
            this.LoginVerify.Size = new System.Drawing.Size(240, 23);
            this.LoginVerify.TabIndex = 4;
            this.LoginVerify.Text = "Verify";
            this.LoginVerify.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginVerify.UseSelectable = true;
            this.LoginVerify.Click += new System.EventHandler(this.LoginVerify_Click);
            // 
            // HWIDText
            // 
            // 
            // 
            // 
            this.HWIDText.CustomButton.Image = null;
            this.HWIDText.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.HWIDText.CustomButton.Name = "";
            this.HWIDText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.HWIDText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.HWIDText.CustomButton.TabIndex = 1;
            this.HWIDText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.HWIDText.CustomButton.UseSelectable = true;
            this.HWIDText.CustomButton.Visible = false;
            this.HWIDText.Lines = new string[] {
        "SHA3HashIFPossibleWillShowUpHere"};
            this.HWIDText.Location = new System.Drawing.Point(3, 70);
            this.HWIDText.MaxLength = 32767;
            this.HWIDText.Name = "HWIDText";
            this.HWIDText.PasswordChar = '\0';
            this.HWIDText.ReadOnly = true;
            this.HWIDText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HWIDText.SelectedText = "";
            this.HWIDText.SelectionLength = 0;
            this.HWIDText.SelectionStart = 0;
            this.HWIDText.ShortcutsEnabled = true;
            this.HWIDText.Size = new System.Drawing.Size(240, 23);
            this.HWIDText.Style = MetroFramework.MetroColorStyle.Red;
            this.HWIDText.TabIndex = 3;
            this.HWIDText.Text = "SHA3HashIFPossibleWillShowUpHere";
            this.HWIDText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HWIDText.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HWIDText.UseSelectable = true;
            this.HWIDText.UseStyleColors = true;
            this.HWIDText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.HWIDText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LoginHelpLabel
            // 
            this.LoginHelpLabel.Location = new System.Drawing.Point(3, 9);
            this.LoginHelpLabel.Name = "LoginHelpLabel";
            this.LoginHelpLabel.Size = new System.Drawing.Size(240, 20);
            this.LoginHelpLabel.TabIndex = 2;
            this.LoginHelpLabel.Text = "You have to verify your PC first!\r\n";
            this.LoginHelpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginHelpLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSRFTab
            // 
            this.RCSRFTab.Controls.Add(this.RCSRFSave);
            this.RCSRFTab.Controls.Add(this.RFHotKeyComb);
            this.RCSRFTab.Controls.Add(this.RCSHotKeyComb);
            this.RCSRFTab.Controls.Add(this.RFHotKeyLabel);
            this.RCSRFTab.Controls.Add(this.RCSHotKeyLabel);
            this.RCSRFTab.Controls.Add(this.RCSRFWeaponTab);
            this.RCSRFTab.HorizontalScrollbarBarColor = true;
            this.RCSRFTab.HorizontalScrollbarHighlightOnWheel = false;
            this.RCSRFTab.HorizontalScrollbarSize = 10;
            this.RCSRFTab.Location = new System.Drawing.Point(4, 38);
            this.RCSRFTab.Name = "RCSRFTab";
            this.RCSRFTab.Size = new System.Drawing.Size(246, 270);
            this.RCSRFTab.Style = MetroFramework.MetroColorStyle.Yellow;
            this.RCSRFTab.TabIndex = 1;
            this.RCSRFTab.Text = "RCS \\ RF";
            this.RCSRFTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSRFTab.VerticalScrollbarBarColor = true;
            this.RCSRFTab.VerticalScrollbarHighlightOnWheel = false;
            this.RCSRFTab.VerticalScrollbarSize = 10;
            // 
            // RCSRFSave
            // 
            this.RCSRFSave.Location = new System.Drawing.Point(-4, 241);
            this.RCSRFSave.Name = "RCSRFSave";
            this.RCSRFSave.Size = new System.Drawing.Size(254, 18);
            this.RCSRFSave.Style = MetroFramework.MetroColorStyle.Blue;
            this.RCSRFSave.TabIndex = 1;
            this.RCSRFSave.Text = "Save";
            this.RCSRFSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSRFSave.UseSelectable = true;
            this.RCSRFSave.Click += new System.EventHandler(this.RCSRFSave_Click);
            // 
            // RFHotKeyComb
            // 
            this.RFHotKeyComb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.RFHotKeyComb.FormattingEnabled = true;
            this.RFHotKeyComb.ItemHeight = 19;
            this.RFHotKeyComb.Location = new System.Drawing.Point(91, 36);
            this.RFHotKeyComb.Name = "RFHotKeyComb";
            this.RFHotKeyComb.Size = new System.Drawing.Size(152, 25);
            this.RFHotKeyComb.Style = MetroFramework.MetroColorStyle.White;
            this.RFHotKeyComb.TabIndex = 13;
            this.RFHotKeyComb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RFHotKeyComb.UseSelectable = true;
            this.RFHotKeyComb.SelectedIndexChanged += new System.EventHandler(this.RFHotKeyComb_SelectedIndexChanged);
            // 
            // RCSHotKeyComb
            // 
            this.RCSHotKeyComb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.RCSHotKeyComb.FormattingEnabled = true;
            this.RCSHotKeyComb.ItemHeight = 19;
            this.RCSHotKeyComb.Location = new System.Drawing.Point(91, 9);
            this.RCSHotKeyComb.Name = "RCSHotKeyComb";
            this.RCSHotKeyComb.Size = new System.Drawing.Size(152, 25);
            this.RCSHotKeyComb.Style = MetroFramework.MetroColorStyle.White;
            this.RCSHotKeyComb.TabIndex = 12;
            this.RCSHotKeyComb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSHotKeyComb.UseSelectable = true;
            this.RCSHotKeyComb.SelectedIndexChanged += new System.EventHandler(this.RCSHotKeyComb_SelectedIndexChanged);
            // 
            // RFHotKeyLabel
            // 
            this.RFHotKeyLabel.Location = new System.Drawing.Point(3, 38);
            this.RFHotKeyLabel.Name = "RFHotKeyLabel";
            this.RFHotKeyLabel.Size = new System.Drawing.Size(78, 23);
            this.RFHotKeyLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.RFHotKeyLabel.TabIndex = 10;
            this.RFHotKeyLabel.Text = "RF HotKey";
            this.RFHotKeyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSHotKeyLabel
            // 
            this.RCSHotKeyLabel.Location = new System.Drawing.Point(3, 9);
            this.RCSHotKeyLabel.Name = "RCSHotKeyLabel";
            this.RCSHotKeyLabel.Size = new System.Drawing.Size(78, 23);
            this.RCSHotKeyLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.RCSHotKeyLabel.TabIndex = 9;
            this.RCSHotKeyLabel.Text = "RCS HotKey";
            this.RCSHotKeyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSRFWeaponTab
            // 
            this.RCSRFWeaponTab.Controls.Add(this.AK47Tab);
            this.RCSRFWeaponTab.Controls.Add(this.AR15Tab);
            this.RCSRFWeaponTab.Location = new System.Drawing.Point(3, 67);
            this.RCSRFWeaponTab.Name = "RCSRFWeaponTab";
            this.RCSRFWeaponTab.SelectedIndex = 0;
            this.RCSRFWeaponTab.Size = new System.Drawing.Size(240, 175);
            this.RCSRFWeaponTab.Style = MetroFramework.MetroColorStyle.Blue;
            this.RCSRFWeaponTab.TabIndex = 7;
            this.RCSRFWeaponTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSRFWeaponTab.UseSelectable = true;
            // 
            // AK47Tab
            // 
            this.AK47Tab.Controls.Add(this.AK47HotKeyComb);
            this.AK47Tab.Controls.Add(this.AK47HotKeyLabel);
            this.AK47Tab.Controls.Add(this.RCSDelayAK47Label);
            this.AK47Tab.Controls.Add(this.RCSDelayAK47Track);
            this.AK47Tab.Controls.Add(this.RFDelayAK47Label);
            this.AK47Tab.Controls.Add(this.RFDelayAK47Track);
            this.AK47Tab.HorizontalScrollbarBarColor = true;
            this.AK47Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.AK47Tab.HorizontalScrollbarSize = 10;
            this.AK47Tab.Location = new System.Drawing.Point(4, 38);
            this.AK47Tab.Name = "AK47Tab";
            this.AK47Tab.Size = new System.Drawing.Size(232, 133);
            this.AK47Tab.Style = MetroFramework.MetroColorStyle.Blue;
            this.AK47Tab.TabIndex = 0;
            this.AK47Tab.Text = "AK47";
            this.AK47Tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AK47Tab.VerticalScrollbarBarColor = true;
            this.AK47Tab.VerticalScrollbarHighlightOnWheel = false;
            this.AK47Tab.VerticalScrollbarSize = 10;
            // 
            // AK47HotKeyComb
            // 
            this.AK47HotKeyComb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.AK47HotKeyComb.FormattingEnabled = true;
            this.AK47HotKeyComb.ItemHeight = 19;
            this.AK47HotKeyComb.Location = new System.Drawing.Point(77, 7);
            this.AK47HotKeyComb.Name = "AK47HotKeyComb";
            this.AK47HotKeyComb.Size = new System.Drawing.Size(152, 25);
            this.AK47HotKeyComb.Style = MetroFramework.MetroColorStyle.White;
            this.AK47HotKeyComb.TabIndex = 13;
            this.AK47HotKeyComb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AK47HotKeyComb.UseSelectable = true;
            this.AK47HotKeyComb.SelectedIndexChanged += new System.EventHandler(this.AK47HotKeyComb_SelectedIndexChanged);
            // 
            // AK47HotKeyLabel
            // 
            this.AK47HotKeyLabel.Location = new System.Drawing.Point(3, 9);
            this.AK47HotKeyLabel.Name = "AK47HotKeyLabel";
            this.AK47HotKeyLabel.Size = new System.Drawing.Size(68, 23);
            this.AK47HotKeyLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.AK47HotKeyLabel.TabIndex = 12;
            this.AK47HotKeyLabel.Text = "HotKey";
            this.AK47HotKeyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSDelayAK47Label
            // 
            this.RCSDelayAK47Label.Location = new System.Drawing.Point(3, 35);
            this.RCSDelayAK47Label.Name = "RCSDelayAK47Label";
            this.RCSDelayAK47Label.Size = new System.Drawing.Size(226, 20);
            this.RCSDelayAK47Label.TabIndex = 10;
            this.RCSDelayAK47Label.Text = "No Recoil Delay: 250";
            this.RCSDelayAK47Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RCSDelayAK47Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSDelayAK47Track
            // 
            this.RCSDelayAK47Track.BackColor = System.Drawing.Color.Transparent;
            this.RCSDelayAK47Track.LargeChange = 10;
            this.RCSDelayAK47Track.Location = new System.Drawing.Point(3, 58);
            this.RCSDelayAK47Track.Maximum = 1000;
            this.RCSDelayAK47Track.Minimum = 100;
            this.RCSDelayAK47Track.Name = "RCSDelayAK47Track";
            this.RCSDelayAK47Track.Size = new System.Drawing.Size(226, 23);
            this.RCSDelayAK47Track.SmallChange = 10;
            this.RCSDelayAK47Track.Style = MetroFramework.MetroColorStyle.Blue;
            this.RCSDelayAK47Track.TabIndex = 9;
            this.RCSDelayAK47Track.Text = "RFDelay";
            this.RCSDelayAK47Track.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSDelayAK47Track.Value = 250;
            this.RCSDelayAK47Track.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RCSDelayAK47Track_Scroll);
            // 
            // RFDelayAK47Label
            // 
            this.RFDelayAK47Label.Location = new System.Drawing.Point(3, 84);
            this.RFDelayAK47Label.Name = "RFDelayAK47Label";
            this.RFDelayAK47Label.Size = new System.Drawing.Size(226, 20);
            this.RFDelayAK47Label.TabIndex = 8;
            this.RFDelayAK47Label.Text = "Rapid Fire Delay: 30";
            this.RFDelayAK47Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RFDelayAK47Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RFDelayAK47Track
            // 
            this.RFDelayAK47Track.BackColor = System.Drawing.Color.Transparent;
            this.RFDelayAK47Track.LargeChange = 1;
            this.RFDelayAK47Track.Location = new System.Drawing.Point(3, 107);
            this.RFDelayAK47Track.Minimum = 10;
            this.RFDelayAK47Track.Name = "RFDelayAK47Track";
            this.RFDelayAK47Track.Size = new System.Drawing.Size(226, 23);
            this.RFDelayAK47Track.Style = MetroFramework.MetroColorStyle.Blue;
            this.RFDelayAK47Track.TabIndex = 7;
            this.RFDelayAK47Track.Text = "RFDelay";
            this.RFDelayAK47Track.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RFDelayAK47Track.Value = 30;
            this.RFDelayAK47Track.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RFDelayAK47Track_Scroll);
            // 
            // AR15Tab
            // 
            this.AR15Tab.Controls.Add(this.AR15HotKeyComb);
            this.AR15Tab.Controls.Add(this.AR15HotKeyLabel);
            this.AR15Tab.Controls.Add(this.RCSDelayAR15Label);
            this.AR15Tab.Controls.Add(this.RCSDelayAR15Track);
            this.AR15Tab.Controls.Add(this.RFDelayAR15Label);
            this.AR15Tab.Controls.Add(this.RFDelayAR15Track);
            this.AR15Tab.HorizontalScrollbarBarColor = true;
            this.AR15Tab.HorizontalScrollbarHighlightOnWheel = false;
            this.AR15Tab.HorizontalScrollbarSize = 10;
            this.AR15Tab.Location = new System.Drawing.Point(4, 38);
            this.AR15Tab.Name = "AR15Tab";
            this.AR15Tab.Size = new System.Drawing.Size(232, 133);
            this.AR15Tab.Style = MetroFramework.MetroColorStyle.Blue;
            this.AR15Tab.TabIndex = 1;
            this.AR15Tab.Text = "AR15";
            this.AR15Tab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AR15Tab.VerticalScrollbarBarColor = true;
            this.AR15Tab.VerticalScrollbarHighlightOnWheel = false;
            this.AR15Tab.VerticalScrollbarSize = 10;
            // 
            // AR15HotKeyComb
            // 
            this.AR15HotKeyComb.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.AR15HotKeyComb.FormattingEnabled = true;
            this.AR15HotKeyComb.ItemHeight = 19;
            this.AR15HotKeyComb.Location = new System.Drawing.Point(77, 7);
            this.AR15HotKeyComb.Name = "AR15HotKeyComb";
            this.AR15HotKeyComb.Size = new System.Drawing.Size(152, 25);
            this.AR15HotKeyComb.Style = MetroFramework.MetroColorStyle.White;
            this.AR15HotKeyComb.TabIndex = 19;
            this.AR15HotKeyComb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AR15HotKeyComb.UseSelectable = true;
            this.AR15HotKeyComb.SelectedIndexChanged += new System.EventHandler(this.AR15HotKeyComb_SelectedIndexChanged);
            // 
            // AR15HotKeyLabel
            // 
            this.AR15HotKeyLabel.Location = new System.Drawing.Point(3, 9);
            this.AR15HotKeyLabel.Name = "AR15HotKeyLabel";
            this.AR15HotKeyLabel.Size = new System.Drawing.Size(68, 23);
            this.AR15HotKeyLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.AR15HotKeyLabel.TabIndex = 18;
            this.AR15HotKeyLabel.Text = "HotKey";
            this.AR15HotKeyLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSDelayAR15Label
            // 
            this.RCSDelayAR15Label.Location = new System.Drawing.Point(3, 35);
            this.RCSDelayAR15Label.Name = "RCSDelayAR15Label";
            this.RCSDelayAR15Label.Size = new System.Drawing.Size(226, 20);
            this.RCSDelayAR15Label.TabIndex = 16;
            this.RCSDelayAR15Label.Text = "No Recoil Delay: 150";
            this.RCSDelayAR15Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RCSDelayAR15Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RCSDelayAR15Track
            // 
            this.RCSDelayAR15Track.BackColor = System.Drawing.Color.Transparent;
            this.RCSDelayAR15Track.Location = new System.Drawing.Point(3, 58);
            this.RCSDelayAR15Track.Maximum = 1000;
            this.RCSDelayAR15Track.Minimum = 100;
            this.RCSDelayAR15Track.Name = "RCSDelayAR15Track";
            this.RCSDelayAR15Track.Size = new System.Drawing.Size(226, 23);
            this.RCSDelayAR15Track.Style = MetroFramework.MetroColorStyle.Blue;
            this.RCSDelayAR15Track.TabIndex = 15;
            this.RCSDelayAR15Track.Text = "RFDelay";
            this.RCSDelayAR15Track.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RCSDelayAR15Track.Value = 150;
            this.RCSDelayAR15Track.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RCSDelayAR15Track_Scroll);
            // 
            // RFDelayAR15Label
            // 
            this.RFDelayAR15Label.Location = new System.Drawing.Point(3, 84);
            this.RFDelayAR15Label.Name = "RFDelayAR15Label";
            this.RFDelayAR15Label.Size = new System.Drawing.Size(226, 20);
            this.RFDelayAR15Label.TabIndex = 14;
            this.RFDelayAR15Label.Text = "Rapid Fire Delay: 30";
            this.RFDelayAR15Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RFDelayAR15Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // RFDelayAR15Track
            // 
            this.RFDelayAR15Track.BackColor = System.Drawing.Color.Transparent;
            this.RFDelayAR15Track.Location = new System.Drawing.Point(3, 107);
            this.RFDelayAR15Track.Minimum = 10;
            this.RFDelayAR15Track.Name = "RFDelayAR15Track";
            this.RFDelayAR15Track.Size = new System.Drawing.Size(226, 23);
            this.RFDelayAR15Track.Style = MetroFramework.MetroColorStyle.Blue;
            this.RFDelayAR15Track.TabIndex = 13;
            this.RFDelayAR15Track.Text = "RFDelay";
            this.RFDelayAR15Track.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RFDelayAR15Track.Value = 30;
            this.RFDelayAR15Track.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RFDelayAR15Track_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 398);
            this.Controls.Add(this.MainTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "XenosZ1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabs.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.RCSRFTab.ResumeLayout(false);
            this.RCSRFWeaponTab.ResumeLayout(false);
            this.AK47Tab.ResumeLayout(false);
            this.AR15Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTabs;
        private MetroFramework.Controls.MetroTabPage LoginTab;
        private MetroFramework.Controls.MetroTabPage RCSRFTab;
        private MetroFramework.Controls.MetroLabel LoginHelpLabel;
        private MetroFramework.Controls.MetroTextBox HWIDText;
        private MetroFramework.Controls.MetroButton LoginVerify;
        private MetroFramework.Controls.MetroLabel LoginHelpLabel2;
        private MetroFramework.Controls.MetroLink DiscordLink;
        private MetroFramework.Controls.MetroLink SkypeLink;
        private MetroFramework.Controls.MetroTabControl RCSRFWeaponTab;
        private MetroFramework.Controls.MetroTabPage AK47Tab;
        private MetroFramework.Controls.MetroLabel RFDelayAK47Label;
        private MetroFramework.Controls.MetroTrackBar RFDelayAK47Track;
        private MetroFramework.Controls.MetroTabPage AR15Tab;
        private MetroFramework.Controls.MetroLabel RCSHotKeyLabel;
        private MetroFramework.Controls.MetroLabel RFHotKeyLabel;
        private MetroFramework.Controls.MetroLabel RCSDelayAK47Label;
        private MetroFramework.Controls.MetroTrackBar RCSDelayAK47Track;
        private MetroFramework.Controls.MetroLabel AK47HotKeyLabel;
        private MetroFramework.Controls.MetroLabel AR15HotKeyLabel;
        private MetroFramework.Controls.MetroLabel RCSDelayAR15Label;
        private MetroFramework.Controls.MetroTrackBar RCSDelayAR15Track;
        private MetroFramework.Controls.MetroLabel RFDelayAR15Label;
        private MetroFramework.Controls.MetroTrackBar RFDelayAR15Track;
        private MetroFramework.Controls.MetroComboBox RCSHotKeyComb;
        private MetroFramework.Controls.MetroComboBox RFHotKeyComb;
        private MetroFramework.Controls.MetroComboBox AK47HotKeyComb;
        private MetroFramework.Controls.MetroComboBox AR15HotKeyComb;
        private MetroFramework.Controls.MetroButton RCSRFSave;
        private MetroFramework.Controls.MetroLabel HWIDLabel;
    }
}

