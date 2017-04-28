namespace ETS2_Local_Radio_server.UI
{
    partial class InfoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameInfo = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.comboIP = new System.Windows.Forms.ComboBox();
            this.URLInfo = new System.Windows.Forms.Label();
            this.coordinatesInfo = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.statusInfo = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.URLLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // gameInfo
            // 
            this.gameInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gameInfo.Location = new System.Drawing.Point(3, 0);
            this.gameInfo.Name = "gameInfo";
            this.gameInfo.Size = new System.Drawing.Size(82, 22);
            this.gameInfo.TabIndex = 22;
            this.gameInfo.Text = "Game:";
            this.gameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gameLabel.Location = new System.Drawing.Point(91, 0);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(310, 22);
            this.gameLabel.TabIndex = 21;
            this.gameLabel.Text = "Euro Truck Simulator 2";
            this.gameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboIP
            // 
            this.comboIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIP.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.comboIP.FormattingEnabled = true;
            this.comboIP.Location = new System.Drawing.Point(91, 68);
            this.comboIP.Name = "comboIP";
            this.comboIP.Size = new System.Drawing.Size(310, 21);
            this.comboIP.TabIndex = 20;
            // 
            // URLInfo
            // 
            this.URLInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.URLInfo.Location = new System.Drawing.Point(3, 66);
            this.URLInfo.Name = "URLInfo";
            this.URLInfo.Size = new System.Drawing.Size(82, 22);
            this.URLInfo.TabIndex = 19;
            this.URLInfo.Text = "URL:";
            this.URLInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coordinatesInfo
            // 
            this.coordinatesInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.coordinatesInfo.Location = new System.Drawing.Point(3, 44);
            this.coordinatesInfo.Name = "coordinatesInfo";
            this.coordinatesInfo.Size = new System.Drawing.Size(82, 22);
            this.coordinatesInfo.TabIndex = 18;
            this.coordinatesInfo.Text = "Coordinates:";
            this.coordinatesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // locationLabel
            // 
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.locationLabel.Location = new System.Drawing.Point(91, 44);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(312, 22);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "XYZ";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusInfo
            // 
            this.statusInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusInfo.Location = new System.Drawing.Point(3, 22);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(82, 22);
            this.statusInfo.TabIndex = 17;
            this.statusInfo.Text = "Status:";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusLabel.Location = new System.Drawing.Point(91, 22);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(310, 22);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // URLLabel
            // 
            this.URLLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.URLLabel.Location = new System.Drawing.Point(88, 92);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Size = new System.Drawing.Size(313, 21);
            this.URLLabel.TabIndex = 15;
            this.URLLabel.TabStop = true;
            this.URLLabel.Text = "Open ETS2 Local Radio";
            this.URLLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URLLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URLLabel_LinkClicked);
            // 
            // InfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gameInfo);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.comboIP);
            this.Controls.Add(this.URLInfo);
            this.Controls.Add(this.coordinatesInfo);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.URLLabel);
            this.Name = "InfoView";
            this.Size = new System.Drawing.Size(407, 118);
            this.Load += new System.EventHandler(this.InfoView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label gameInfo;
        public System.Windows.Forms.Label gameLabel;
        public System.Windows.Forms.ComboBox comboIP;
        public System.Windows.Forms.Label URLInfo;
        public System.Windows.Forms.Label coordinatesInfo;
        public System.Windows.Forms.Label locationLabel;
        public System.Windows.Forms.Label statusInfo;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.LinkLabel URLLabel;
    }
}
