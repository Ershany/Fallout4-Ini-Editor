namespace Fallout4Ini
{
    partial class EditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.inibutton = new System.Windows.Forms.Button();
            this.prefsIniButton = new System.Windows.Forms.Button();
            this.iniDir = new System.Windows.Forms.TextBox();
            this.prefsIniDir = new System.Windows.Forms.TextBox();
            this.banner = new System.Windows.Forms.PictureBox();
            this.donationButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.thirdFOVNum = new System.Windows.Forms.NumericUpDown();
            this.firstFOVNum = new System.Windows.Forms.NumericUpDown();
            this.thirdFOVLabel = new System.Windows.Forms.Label();
            this.firstFOVLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unlockFPSLabel = new System.Windows.Forms.Label();
            this.unlockFPSBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.settingLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pauseAltTabLabel = new System.Windows.Forms.Label();
            this.pauseAltTabBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skipIntroLabel = new System.Windows.Forms.Label();
            this.skipIntroBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.valueLabel2 = new System.Windows.Forms.Label();
            this.settingLabel2 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.resetIniButton = new System.Windows.Forms.Button();
            this.resetPrefsIniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdFOVNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFOVNum)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // inibutton
            // 
            this.inibutton.Location = new System.Drawing.Point(13, 68);
            this.inibutton.Name = "inibutton";
            this.inibutton.Size = new System.Drawing.Size(146, 23);
            this.inibutton.TabIndex = 1;
            this.inibutton.Text = "Set Fallout4.ini";
            this.inibutton.UseVisualStyleBackColor = true;
            this.inibutton.Click += new System.EventHandler(this.defaultIniButton_Click);
            // 
            // prefsIniButton
            // 
            this.prefsIniButton.Location = new System.Drawing.Point(13, 98);
            this.prefsIniButton.Name = "prefsIniButton";
            this.prefsIniButton.Size = new System.Drawing.Size(146, 23);
            this.prefsIniButton.TabIndex = 2;
            this.prefsIniButton.Text = "Set Fallout4Prefs.ini";
            this.prefsIniButton.UseVisualStyleBackColor = true;
            this.prefsIniButton.Click += new System.EventHandler(this.prefsIniButton_Click);
            // 
            // iniDir
            // 
            this.iniDir.Location = new System.Drawing.Point(166, 70);
            this.iniDir.Name = "iniDir";
            this.iniDir.ReadOnly = true;
            this.iniDir.Size = new System.Drawing.Size(409, 20);
            this.iniDir.TabIndex = 3;
            // 
            // prefsIniDir
            // 
            this.prefsIniDir.Location = new System.Drawing.Point(166, 100);
            this.prefsIniDir.Name = "prefsIniDir";
            this.prefsIniDir.ReadOnly = true;
            this.prefsIniDir.Size = new System.Drawing.Size(409, 20);
            this.prefsIniDir.TabIndex = 4;
            // 
            // banner
            // 
            this.banner.BackgroundImage = global::Fallout4Ini.Properties.Resources.Banner;
            this.banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(797, 61);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // donationButton
            // 
            this.donationButton.Location = new System.Drawing.Point(710, 68);
            this.donationButton.Name = "donationButton";
            this.donationButton.Size = new System.Drawing.Size(75, 23);
            this.donationButton.TabIndex = 5;
            this.donationButton.Text = "Donate";
            this.donationButton.UseVisualStyleBackColor = true;
            this.donationButton.Click += new System.EventHandler(this.donationButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 126);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(772, 423);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.thirdFOVNum);
            this.tabPage1.Controls.Add(this.firstFOVNum);
            this.tabPage1.Controls.Add(this.thirdFOVLabel);
            this.tabPage1.Controls.Add(this.firstFOVLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.depthLabel);
            this.tabPage1.Controls.Add(this.depthBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.unlockFPSLabel);
            this.tabPage1.Controls.Add(this.unlockFPSBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.descriptionLabel);
            this.tabPage1.Controls.Add(this.valueLabel);
            this.tabPage1.Controls.Add(this.settingLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // thirdFOVNum
            // 
            this.thirdFOVNum.Location = new System.Drawing.Point(179, 106);
            this.thirdFOVNum.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.thirdFOVNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.thirdFOVNum.Name = "thirdFOVNum";
            this.thirdFOVNum.Size = new System.Drawing.Size(121, 20);
            this.thirdFOVNum.TabIndex = 14;
            this.thirdFOVNum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.thirdFOVNum.ValueChanged += new System.EventHandler(this.thirdFOVNum_ValueChanged);
            // 
            // firstFOVNum
            // 
            this.firstFOVNum.Location = new System.Drawing.Point(179, 80);
            this.firstFOVNum.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.firstFOVNum.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.firstFOVNum.Name = "firstFOVNum";
            this.firstFOVNum.Size = new System.Drawing.Size(121, 20);
            this.firstFOVNum.TabIndex = 13;
            this.firstFOVNum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.firstFOVNum.ValueChanged += new System.EventHandler(this.firstFOVNum_ValueChanged);
            // 
            // thirdFOVLabel
            // 
            this.thirdFOVLabel.AutoSize = true;
            this.thirdFOVLabel.Location = new System.Drawing.Point(340, 108);
            this.thirdFOVLabel.Name = "thirdFOVLabel";
            this.thirdFOVLabel.Size = new System.Drawing.Size(372, 13);
            this.thirdFOVLabel.TabIndex = 12;
            this.thirdFOVLabel.Text = "Set the field of view of the camera in third person mode (recommend 70 - 120)\r\n";
            // 
            // firstFOVLabel
            // 
            this.firstFOVLabel.AutoSize = true;
            this.firstFOVLabel.Location = new System.Drawing.Point(340, 83);
            this.firstFOVLabel.Name = "firstFOVLabel";
            this.firstFOVLabel.Size = new System.Drawing.Size(368, 13);
            this.firstFOVLabel.TabIndex = 11;
            this.firstFOVLabel.Text = "Set the field of view of the camera in first person mode (recommend 70 - 120)\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Third Person FOV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Person FOV";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(340, 58);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(152, 13);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Enable or disable depth of field";
            // 
            // depthBox
            // 
            this.depthBox.FormattingEnabled = true;
            this.depthBox.Items.AddRange(new object[] {
            "Disabled",
            "Enabled"});
            this.depthBox.Location = new System.Drawing.Point(179, 53);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(121, 21);
            this.depthBox.TabIndex = 7;
            this.depthBox.SelectedIndexChanged += new System.EventHandler(this.depthBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depth of Field";
            // 
            // unlockFPSLabel
            // 
            this.unlockFPSLabel.AutoSize = true;
            this.unlockFPSLabel.Location = new System.Drawing.Point(340, 33);
            this.unlockFPSLabel.Name = "unlockFPSLabel";
            this.unlockFPSLabel.Size = new System.Drawing.Size(225, 26);
            this.unlockFPSLabel.TabIndex = 5;
            this.unlockFPSLabel.Text = "Check this to unlock the framerate per second\r\n\r\n";
            // 
            // unlockFPSBox
            // 
            this.unlockFPSBox.AutoSize = true;
            this.unlockFPSBox.Location = new System.Drawing.Point(179, 33);
            this.unlockFPSBox.Name = "unlockFPSBox";
            this.unlockFPSBox.Size = new System.Drawing.Size(15, 14);
            this.unlockFPSBox.TabIndex = 4;
            this.unlockFPSBox.UseVisualStyleBackColor = true;
            this.unlockFPSBox.CheckedChanged += new System.EventHandler(this.unlockFPSBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unlock the FPS";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(337, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(80, 15);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Description";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(176, 3);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(43, 15);
            this.valueLabel.TabIndex = 1;
            this.valueLabel.Text = "Value";
            // 
            // settingLabel
            // 
            this.settingLabel.AutoSize = true;
            this.settingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel.Location = new System.Drawing.Point(15, 3);
            this.settingLabel.Name = "settingLabel";
            this.settingLabel.Size = new System.Drawing.Size(52, 15);
            this.settingLabel.TabIndex = 0;
            this.settingLabel.Text = "Setting";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pauseAltTabLabel);
            this.tabPage2.Controls.Add(this.pauseAltTabBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.skipIntroLabel);
            this.tabPage2.Controls.Add(this.skipIntroBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.descriptionLabel2);
            this.tabPage2.Controls.Add(this.valueLabel2);
            this.tabPage2.Controls.Add(this.settingLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pauseAltTabLabel
            // 
            this.pauseAltTabLabel.AutoSize = true;
            this.pauseAltTabLabel.Location = new System.Drawing.Point(340, 58);
            this.pauseAltTabLabel.Name = "pauseAltTabLabel";
            this.pauseAltTabLabel.Size = new System.Drawing.Size(182, 13);
            this.pauseAltTabLabel.TabIndex = 8;
            this.pauseAltTabLabel.Text = "Check this to pause when you alt tab";
            // 
            // pauseAltTabBox
            // 
            this.pauseAltTabBox.AutoSize = true;
            this.pauseAltTabBox.Location = new System.Drawing.Point(179, 58);
            this.pauseAltTabBox.Name = "pauseAltTabBox";
            this.pauseAltTabBox.Size = new System.Drawing.Size(15, 14);
            this.pauseAltTabBox.TabIndex = 7;
            this.pauseAltTabBox.UseVisualStyleBackColor = true;
            this.pauseAltTabBox.CheckedChanged += new System.EventHandler(this.pauseAltTabBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pause When Alt-Tabbed";
            // 
            // skipIntroLabel
            // 
            this.skipIntroLabel.AutoSize = true;
            this.skipIntroLabel.Location = new System.Drawing.Point(340, 32);
            this.skipIntroLabel.Name = "skipIntroLabel";
            this.skipIntroLabel.Size = new System.Drawing.Size(249, 13);
            this.skipIntroLabel.TabIndex = 5;
            this.skipIntroLabel.Text = "Check this to skip the introduction video on start-up";
            // 
            // skipIntroBox
            // 
            this.skipIntroBox.AutoSize = true;
            this.skipIntroBox.Location = new System.Drawing.Point(179, 33);
            this.skipIntroBox.Name = "skipIntroBox";
            this.skipIntroBox.Size = new System.Drawing.Size(15, 14);
            this.skipIntroBox.TabIndex = 4;
            this.skipIntroBox.UseVisualStyleBackColor = true;
            this.skipIntroBox.CheckedChanged += new System.EventHandler(this.skipIntroBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Skip Introduction Video";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel2.Location = new System.Drawing.Point(337, 3);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(80, 15);
            this.descriptionLabel2.TabIndex = 2;
            this.descriptionLabel2.Text = "Description";
            // 
            // valueLabel2
            // 
            this.valueLabel2.AutoSize = true;
            this.valueLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel2.Location = new System.Drawing.Point(176, 3);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(43, 15);
            this.valueLabel2.TabIndex = 1;
            this.valueLabel2.Text = "Value";
            // 
            // settingLabel2
            // 
            this.settingLabel2.AutoSize = true;
            this.settingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingLabel2.Location = new System.Drawing.Point(15, 3);
            this.settingLabel2.Name = "settingLabel2";
            this.settingLabel2.Size = new System.Drawing.Size(52, 15);
            this.settingLabel2.TabIndex = 0;
            this.settingLabel2.Text = "Setting";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(710, 98);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // resetIniButton
            // 
            this.resetIniButton.Location = new System.Drawing.Point(581, 68);
            this.resetIniButton.Name = "resetIniButton";
            this.resetIniButton.Size = new System.Drawing.Size(123, 23);
            this.resetIniButton.TabIndex = 8;
            this.resetIniButton.Text = "Reset Fallout4.ini";
            this.resetIniButton.UseVisualStyleBackColor = true;
            this.resetIniButton.Click += new System.EventHandler(this.resetIniButton_Click);
            // 
            // resetPrefsIniButton
            // 
            this.resetPrefsIniButton.Location = new System.Drawing.Point(581, 98);
            this.resetPrefsIniButton.Name = "resetPrefsIniButton";
            this.resetPrefsIniButton.Size = new System.Drawing.Size(123, 23);
            this.resetPrefsIniButton.TabIndex = 9;
            this.resetPrefsIniButton.Text = "Reset Fallout4Prefs.ini";
            this.resetPrefsIniButton.UseVisualStyleBackColor = true;
            this.resetPrefsIniButton.Click += new System.EventHandler(this.resetPrefsIniButton_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 561);
            this.Controls.Add(this.resetPrefsIniButton);
            this.Controls.Add(this.resetIniButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.donationButton);
            this.Controls.Add(this.prefsIniDir);
            this.Controls.Add(this.iniDir);
            this.Controls.Add(this.prefsIniButton);
            this.Controls.Add(this.inibutton);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fallout 4 Ini Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdFOVNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFOVNum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.Button inibutton;
        private System.Windows.Forms.Button prefsIniButton;
        private System.Windows.Forms.TextBox prefsIniDir;
        private System.Windows.Forms.TextBox iniDir;
        private System.Windows.Forms.Button donationButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label settingLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label unlockFPSLabel;
        private System.Windows.Forms.CheckBox unlockFPSBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ComboBox depthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label firstFOVLabel;
        private System.Windows.Forms.Label thirdFOVLabel;
        private System.Windows.Forms.NumericUpDown thirdFOVNum;
        private System.Windows.Forms.NumericUpDown firstFOVNum;
        private System.Windows.Forms.Label skipIntroLabel;
        private System.Windows.Forms.CheckBox skipIntroBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label valueLabel2;
        private System.Windows.Forms.Label settingLabel2;
        private System.Windows.Forms.CheckBox pauseAltTabBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pauseAltTabLabel;
        private System.Windows.Forms.Button resetPrefsIniButton;
        private System.Windows.Forms.Button resetIniButton;

        // Accessors
        public System.Windows.Forms.TextBox PrefsIniDir
        {
            get { return prefsIniDir; }
            private set { prefsIniDir = value; }
        }
        public System.Windows.Forms.TextBox IniDir
        {
            get { return iniDir; }
            private set { iniDir = value; }
        }
        public System.Windows.Forms.TabControl TabControl
        {
            get { return tabControl; }
            set { tabControl = value; }
        }
        public System.Windows.Forms.CheckBox UnlockFPSBox
        {
            get { return unlockFPSBox; }
            private set { unlockFPSBox = value; }
        }
        public System.Windows.Forms.ComboBox DepthBox
        {
            get { return depthBox; }
            set { depthBox = value; }
        }
        public System.Windows.Forms.NumericUpDown FirstFOVNum
        {
            get { return firstFOVNum; }
            set { firstFOVNum = value; }
        }
        public System.Windows.Forms.NumericUpDown ThirdFOVNum
        {
            get { return thirdFOVNum; }
            set { thirdFOVNum = value; }
        }
        public System.Windows.Forms.CheckBox SkipIntroBox
        {
            get { return skipIntroBox; }
            set { skipIntroBox = value; }
        }
        public System.Windows.Forms.CheckBox PauseAltTabBox
        {
            get { return pauseAltTabBox; }
            set { pauseAltTabBox = value; }
        }

    }
}

