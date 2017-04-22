namespace ETS2_Local_Radio_server
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.keyTimeout = new System.Windows.Forms.Timer(this.components);
            this.groupSettings = new System.Windows.Forms.GroupBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.infoView = new ETS2_Local_Radio_server.UI.InfoView();
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.currentGameTimer = new System.Windows.Forms.Timer(this.components);
            this.groupInstall = new System.Windows.Forms.GroupBox();
            this.removePluginButton = new System.Windows.Forms.LinkLabel();
            this.installEts2Button = new System.Windows.Forms.Button();
            this.installAtsButton = new System.Windows.Forms.Button();
            this.groupController = new System.Windows.Forms.GroupBox();
            this.comboController = new System.Windows.Forms.ComboBox();
            this.settingsView = new ETS2_Local_Radio_server.UI.SettingsView();
            this.Koenvh = new System.Windows.Forms.PictureBox();
            this.groupSettings.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.groupInstall.SuspendLayout();
            this.groupController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).BeginInit();
            this.SuspendLayout();
            // 
            // keyTimeout
            // 
            this.keyTimeout.Interval = 10;
            this.keyTimeout.Tick += new System.EventHandler(this.keyTimeout_Tick);
            // 
            // groupSettings
            // 
            this.groupSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSettings.Controls.Add(this.settingsView);
            this.groupSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupSettings.Location = new System.Drawing.Point(12, 157);
            this.groupSettings.Name = "groupSettings";
            this.groupSettings.Size = new System.Drawing.Size(413, 267);
            this.groupSettings.TabIndex = 4;
            this.groupSettings.TabStop = false;
            this.groupSettings.Text = "Settings";
            // 
            // groupInfo
            // 
            this.groupInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupInfo.Controls.Add(this.infoView);
            this.groupInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupInfo.Location = new System.Drawing.Point(12, 12);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(413, 139);
            this.groupInfo.TabIndex = 5;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Info";
            // 
            // infoView
            // 
            this.infoView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoView.Location = new System.Drawing.Point(3, 18);
            this.infoView.Name = "infoView";
            this.infoView.Size = new System.Drawing.Size(407, 118);
            this.infoView.TabIndex = 0;
            // 
            // comboLang
            // 
            this.comboLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(360, 618);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(65, 21);
            this.comboLang.TabIndex = 8;
            this.comboLang.SelectedIndexChanged += new System.EventHandler(this.comboLang_SelectedIndexChanged);
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "Please select the Euro Truck Simulator 2 installation folder, usually found in C:" +
    "\\Program Files (x86)\\Steam\\SteamApps\\common\\Euro Truck Simulator 2";
            this.folderDialog.ShowNewFolderButton = false;
            // 
            // joystickTimer
            // 
            this.joystickTimer.Interval = 10;
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // currentGameTimer
            // 
            this.currentGameTimer.Interval = 3000;
            this.currentGameTimer.Tick += new System.EventHandler(this.currentGameTimer_Tick);
            // 
            // groupInstall
            // 
            this.groupInstall.Controls.Add(this.removePluginButton);
            this.groupInstall.Controls.Add(this.installEts2Button);
            this.groupInstall.Controls.Add(this.installAtsButton);
            this.groupInstall.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupInstall.Location = new System.Drawing.Point(12, 492);
            this.groupInstall.Name = "groupInstall";
            this.groupInstall.Size = new System.Drawing.Size(413, 91);
            this.groupInstall.TabIndex = 9;
            this.groupInstall.TabStop = false;
            this.groupInstall.Text = "Install plugin";
            // 
            // removePluginButton
            // 
            this.removePluginButton.AutoSize = true;
            this.removePluginButton.Location = new System.Drawing.Point(10, 72);
            this.removePluginButton.Name = "removePluginButton";
            this.removePluginButton.Size = new System.Drawing.Size(84, 13);
            this.removePluginButton.TabIndex = 2;
            this.removePluginButton.TabStop = true;
            this.removePluginButton.Text = "Remove plugin";
            this.removePluginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removePluginButton_LinkClicked);
            // 
            // installEts2Button
            // 
            this.installEts2Button.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.installEts2Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installEts2Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installEts2Button.Location = new System.Drawing.Point(213, 23);
            this.installEts2Button.Name = "installEts2Button";
            this.installEts2Button.Size = new System.Drawing.Size(190, 44);
            this.installEts2Button.TabIndex = 1;
            this.installEts2Button.Text = "Install plugin for \r\nEuro Truck Simulator 2";
            this.installEts2Button.UseVisualStyleBackColor = true;
            this.installEts2Button.Click += new System.EventHandler(this.installEts2Button_Click);
            // 
            // installAtsButton
            // 
            this.installAtsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.installAtsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.installAtsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.installAtsButton.Location = new System.Drawing.Point(10, 23);
            this.installAtsButton.Name = "installAtsButton";
            this.installAtsButton.Size = new System.Drawing.Size(190, 44);
            this.installAtsButton.TabIndex = 0;
            this.installAtsButton.Text = "Install plugin for \r\nAmerican Truck Simulator";
            this.installAtsButton.UseVisualStyleBackColor = true;
            this.installAtsButton.Click += new System.EventHandler(this.installAtsButton_Click);
            // 
            // groupController
            // 
            this.groupController.Controls.Add(this.comboController);
            this.groupController.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupController.Location = new System.Drawing.Point(12, 430);
            this.groupController.Name = "groupController";
            this.groupController.Size = new System.Drawing.Size(413, 56);
            this.groupController.TabIndex = 10;
            this.groupController.TabStop = false;
            this.groupController.Text = "Controller";
            // 
            // comboController
            // 
            this.comboController.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboController.FormattingEnabled = true;
            this.comboController.Location = new System.Drawing.Point(10, 22);
            this.comboController.Name = "comboController";
            this.comboController.Size = new System.Drawing.Size(393, 21);
            this.comboController.TabIndex = 11;
            this.comboController.SelectedIndexChanged += new System.EventHandler(this.comboController_SelectedIndexChanged);
            // 
            // settingsView
            // 
            this.settingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsView.Location = new System.Drawing.Point(3, 18);
            this.settingsView.Name = "settingsView";
            this.settingsView.Size = new System.Drawing.Size(407, 246);
            this.settingsView.TabIndex = 0;
            // 
            // Koenvh
            // 
            this.Koenvh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Koenvh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Koenvh.Image = global::ETS2_Local_Radio_server.Properties.Resources.Koenvh_fat_text_smaller;
            this.Koenvh.Location = new System.Drawing.Point(140, 589);
            this.Koenvh.Name = "Koenvh";
            this.Koenvh.Size = new System.Drawing.Size(156, 50);
            this.Koenvh.TabIndex = 6;
            this.Koenvh.TabStop = false;
            this.Koenvh.Click += new System.EventHandler(this.Koenvh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 649);
            this.Controls.Add(this.groupController);
            this.Controls.Add(this.groupInstall);
            this.Controls.Add(this.comboLang);
            this.Controls.Add(this.Koenvh);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ETS2 Local Radio server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupSettings.ResumeLayout(false);
            this.groupInfo.ResumeLayout(false);
            this.groupInstall.ResumeLayout(false);
            this.groupInstall.PerformLayout();
            this.groupController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer keyTimeout;
        private System.Windows.Forms.GroupBox groupSettings;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.PictureBox Koenvh;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.Timer currentGameTimer;
        private System.Windows.Forms.GroupBox groupInstall;
        private System.Windows.Forms.Button installEts2Button;
        private System.Windows.Forms.Button installAtsButton;
        private System.Windows.Forms.GroupBox groupController;
        private System.Windows.Forms.ComboBox comboController;
        private System.Windows.Forms.LinkLabel removePluginButton;
        private UI.InfoView infoView;
        private UI.SettingsView settingsView;
    }
}