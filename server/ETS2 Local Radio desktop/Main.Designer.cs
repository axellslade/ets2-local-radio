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
            this.comboLang = new System.Windows.Forms.ComboBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.currentGameTimer = new System.Windows.Forms.Timer(this.components);
            this.Koenvh = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPlugin = new System.Windows.Forms.TabPage();
            this.tabControls = new System.Windows.Forms.TabPage();
            this.controlSettings = new ETS2_Local_Radio_server.UIComponents.ControlSettings();
            this.tabMaps = new System.Windows.Forms.TabPage();
            this.tabStations = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.plugin1 = new ETS2_Local_Radio_server.UIComponents.Plugin();
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPlugin.SuspendLayout();
            this.tabControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboLang
            // 
            this.comboLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLang.FormattingEnabled = true;
            this.comboLang.Location = new System.Drawing.Point(356, 501);
            this.comboLang.Name = "comboLang";
            this.comboLang.Size = new System.Drawing.Size(65, 21);
            this.comboLang.TabIndex = 8;
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "Please select the Euro Truck Simulator 2 installation folder, usually found in C:" +
    "\\Program Files (x86)\\Steam\\SteamApps\\common\\Euro Truck Simulator 2";
            this.folderDialog.ShowNewFolderButton = false;
            // 
            // Koenvh
            // 
            this.Koenvh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Koenvh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Koenvh.Image = global::ETS2_Local_Radio_server.Properties.Resources.Koenvh_fat_text_smaller;
            this.Koenvh.Location = new System.Drawing.Point(138, 472);
            this.Koenvh.Name = "Koenvh";
            this.Koenvh.Size = new System.Drawing.Size(160, 50);
            this.Koenvh.TabIndex = 6;
            this.Koenvh.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::ETS2_Local_Radio_server.Properties.Resources.Local_Radio_Logo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(413, 127);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPlugin);
            this.tabControl.Controls.Add(this.tabControls);
            this.tabControl.Controls.Add(this.tabMaps);
            this.tabControl.Controls.Add(this.tabStations);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabControl.Location = new System.Drawing.Point(12, 146);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(413, 320);
            this.tabControl.TabIndex = 12;
            // 
            // tabPlugin
            // 
            this.tabPlugin.Controls.Add(this.plugin1);
            this.tabPlugin.Location = new System.Drawing.Point(4, 22);
            this.tabPlugin.Name = "tabPlugin";
            this.tabPlugin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlugin.Size = new System.Drawing.Size(405, 294);
            this.tabPlugin.TabIndex = 0;
            this.tabPlugin.Text = "Plugin";
            this.tabPlugin.UseVisualStyleBackColor = true;
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.controlSettings);
            this.tabControls.Location = new System.Drawing.Point(4, 22);
            this.tabControls.Name = "tabControls";
            this.tabControls.Padding = new System.Windows.Forms.Padding(3);
            this.tabControls.Size = new System.Drawing.Size(405, 294);
            this.tabControls.TabIndex = 1;
            this.tabControls.Text = "Controls";
            this.tabControls.UseVisualStyleBackColor = true;
            // 
            // controlSettings
            // 
            this.controlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSettings.Location = new System.Drawing.Point(3, 3);
            this.controlSettings.Name = "controlSettings";
            this.controlSettings.Size = new System.Drawing.Size(399, 288);
            this.controlSettings.TabIndex = 0;
            // 
            // tabMaps
            // 
            this.tabMaps.Location = new System.Drawing.Point(4, 22);
            this.tabMaps.Name = "tabMaps";
            this.tabMaps.Size = new System.Drawing.Size(405, 294);
            this.tabMaps.TabIndex = 2;
            this.tabMaps.Text = "Maps";
            this.tabMaps.UseVisualStyleBackColor = true;
            // 
            // tabStations
            // 
            this.tabStations.Location = new System.Drawing.Point(4, 22);
            this.tabStations.Name = "tabStations";
            this.tabStations.Size = new System.Drawing.Size(405, 294);
            this.tabStations.TabIndex = 4;
            this.tabStations.Text = "Stations";
            this.tabStations.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(405, 294);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // plugin1
            // 
            this.plugin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plugin1.Location = new System.Drawing.Point(3, 3);
            this.plugin1.Name = "plugin1";
            this.plugin1.Size = new System.Drawing.Size(399, 288);
            this.plugin1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 532);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.comboLang);
            this.Controls.Add(this.Koenvh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Local Radio server";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Koenvh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPlugin.ResumeLayout(false);
            this.tabControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer keyTimeout;
        private System.Windows.Forms.PictureBox Koenvh;
        private System.Windows.Forms.ComboBox comboLang;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.Timer currentGameTimer;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPlugin;
        private System.Windows.Forms.TabPage tabControls;
        private System.Windows.Forms.TabPage tabMaps;
        private System.Windows.Forms.TabPage tabSettings;
        private UIComponents.Plugin info;
        private UIComponents.ControlSettings controlSettings;
        private System.Windows.Forms.TabPage tabStations;
        private UIComponents.Plugin plugin1;
    }
}