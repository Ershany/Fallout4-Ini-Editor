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
            this.unlockFPSLabel = new System.Windows.Forms.Label();
            this.unlockFPSBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.settingLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.ComboBox();
            this.depthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.donationButton.Location = new System.Drawing.Point(710, 70);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Temp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(710, 100);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 7;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
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
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(343, 58);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(152, 13);
            this.depthLabel.TabIndex = 8;
            this.depthLabel.Text = "Enable or disable depth of field";
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 561);
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

    }
}

