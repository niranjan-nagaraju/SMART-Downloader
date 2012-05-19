namespace SmartDownloader.GUI
{
    partial class SmartDownloaderGUI
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
                timer.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartDownloaderGUI));
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.URLlbl = new System.Windows.Forms.Label();
            this.StartDwnldBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.lblSaveFile = new System.Windows.Forms.Label();
            this.SavetxtBox = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SmartMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.Schedulebutton = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.priv_btn = new System.Windows.Forms.Button();
            this.DwnldQLbl = new System.Windows.Forms.Label();
            this.DownloadQueuePanel = new System.Windows.Forms.Panel();
            this.NoneLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UnDockbutton = new System.Windows.Forms.Button();
            this.SmartMainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.DownloadQueuePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(124, 79);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(414, 20);
            this.URLTextBox.TabIndex = 0;
            this.URLTextBox.Text = "http://";
            this.URLTextBox.TextChanged += new System.EventHandler(this.URLTextBox_TextChanged);
            // 
            // URLlbl
            // 
            this.URLlbl.AutoSize = true;
            this.URLlbl.Location = new System.Drawing.Point(89, 82);
            this.URLlbl.Name = "URLlbl";
            this.URLlbl.Size = new System.Drawing.Size(29, 13);
            this.URLlbl.TabIndex = 1;
            this.URLlbl.Text = "URL";
            // 
            // StartDwnldBtn
            // 
            this.StartDwnldBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartDwnldBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.StartDwnldBtn.Location = new System.Drawing.Point(164, 163);
            this.StartDwnldBtn.Name = "StartDwnldBtn";
            this.StartDwnldBtn.Size = new System.Drawing.Size(112, 37);
            this.StartDwnldBtn.TabIndex = 2;
            this.StartDwnldBtn.Text = "Start &Download";
            this.StartDwnldBtn.UseVisualStyleBackColor = false;
            this.StartDwnldBtn.Click += new System.EventHandler(this.StartDwnldBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PauseBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PauseBtn.Location = new System.Drawing.Point(164, 452);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(112, 38);
            this.PauseBtn.TabIndex = 3;
            this.PauseBtn.Text = "|| &Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ResumeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResumeBtn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ResumeBtn.Location = new System.Drawing.Point(282, 452);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(121, 38);
            this.ResumeBtn.TabIndex = 4;
            this.ResumeBtn.Text = "> &Resume";
            this.ResumeBtn.UseVisualStyleBackColor = false;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // lblSaveFile
            // 
            this.lblSaveFile.AutoSize = true;
            this.lblSaveFile.Location = new System.Drawing.Point(65, 118);
            this.lblSaveFile.Name = "lblSaveFile";
            this.lblSaveFile.Size = new System.Drawing.Size(53, 13);
            this.lblSaveFile.TabIndex = 7;
            this.lblSaveFile.Text = "Save In : ";
            // 
            // SavetxtBox
            // 
            this.SavetxtBox.Location = new System.Drawing.Point(124, 118);
            this.SavetxtBox.Name = "SavetxtBox";
            this.SavetxtBox.Size = new System.Drawing.Size(414, 20);
            this.SavetxtBox.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBrowse.Location = new System.Drawing.Point(568, 114);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 33);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // SmartMainMenu
            // 
            this.SmartMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.SmartMainMenu.Location = new System.Drawing.Point(0, 0);
            this.SmartMainMenu.Name = "SmartMainMenu";
            this.SmartMainMenu.Size = new System.Drawing.Size(847, 24);
            this.SmartMainMenu.TabIndex = 10;
            this.SmartMainMenu.Text = "SmatMainmenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.downloadQueueToolStripMenuItem,
            this.zipPreviewToolStripMenuItem,
            this.mediaPreviewToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.statisticsToolStripMenuItem.Text = "&Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // downloadQueueToolStripMenuItem
            // 
            this.downloadQueueToolStripMenuItem.Name = "downloadQueueToolStripMenuItem";
            this.downloadQueueToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.downloadQueueToolStripMenuItem.Text = "Download &Queue";
            this.downloadQueueToolStripMenuItem.Click += new System.EventHandler(this.downloadQueueToolStripMenuItem_Click);
            // 
            // zipPreviewToolStripMenuItem
            // 
            this.zipPreviewToolStripMenuItem.Name = "zipPreviewToolStripMenuItem";
            this.zipPreviewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.zipPreviewToolStripMenuItem.Text = "&Zip Preview";
            this.zipPreviewToolStripMenuItem.Click += new System.EventHandler(this.zipPreviewToolStripMenuItem_Click);
            // 
            // mediaPreviewToolStripMenuItem
            // 
            this.mediaPreviewToolStripMenuItem.Name = "mediaPreviewToolStripMenuItem";
            this.mediaPreviewToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mediaPreviewToolStripMenuItem.Text = "&Media Preview";
            this.mediaPreviewToolStripMenuItem.Click += new System.EventHandler(this.mediaPreviewToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.decryptToolStripMenuItem,
            this.fTPToolStripMenuItem,
            this.validateXMLToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.uploadToolStripMenuItem.Text = "&Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.encryptToolStripMenuItem.Text = "&Encrypt";
            this.encryptToolStripMenuItem.Click += new System.EventHandler(this.encryptToolStripMenuItem_Click);
            // 
            // decryptToolStripMenuItem
            // 
            this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
            this.decryptToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.decryptToolStripMenuItem.Text = "&Decrypt";
            this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
            // 
            // fTPToolStripMenuItem
            // 
            this.fTPToolStripMenuItem.Name = "fTPToolStripMenuItem";
            this.fTPToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fTPToolStripMenuItem.Text = "FTP";
            this.fTPToolStripMenuItem.Click += new System.EventHandler(this.fTPToolStripMenuItem_Click);
            // 
            // validateXMLToolStripMenuItem
            // 
            this.validateXMLToolStripMenuItem.Name = "validateXMLToolStripMenuItem";
            this.validateXMLToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.validateXMLToolStripMenuItem.Text = "&Validate XML";
            this.validateXMLToolStripMenuItem.Click += new System.EventHandler(this.validateXMLToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.schedulerToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "&Tasks";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pauseToolStripMenuItem.Text = "&Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.resumeToolStripMenuItem.Text = "&Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stopToolStripMenuItem.Text = "&Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // schedulerToolStripMenuItem
            // 
            this.schedulerToolStripMenuItem.Name = "schedulerToolStripMenuItem";
            this.schedulerToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.schedulerToolStripMenuItem.Text = "S&cheduler";
            this.schedulerToolStripMenuItem.Click += new System.EventHandler(this.schedulerToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.userManualToolStripMenuItem.Text = "User &Manual";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.aboutUsToolStripMenuItem.Text = "About &Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Stopbutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Stopbutton.Location = new System.Drawing.Point(409, 452);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(121, 37);
            this.Stopbutton.TabIndex = 11;
            this.Stopbutton.Text = "S&top Download";
            this.Stopbutton.UseVisualStyleBackColor = false;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // Schedulebutton
            // 
            this.Schedulebutton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Schedulebutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Schedulebutton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Schedulebutton.Location = new System.Drawing.Point(409, 163);
            this.Schedulebutton.Name = "Schedulebutton";
            this.Schedulebutton.Size = new System.Drawing.Size(121, 37);
            this.Schedulebutton.TabIndex = 12;
            this.Schedulebutton.Text = "&Schedule Download";
            this.Schedulebutton.UseVisualStyleBackColor = false;
            this.Schedulebutton.Click += new System.EventHandler(this.Schedulebutton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 509);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(847, 22);
            this.statusBar.TabIndex = 13;
            this.statusBar.Text = "statusBar";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(810, 17);
            this.StatusLabel.Text = "Ready";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priv_btn
            // 
            this.priv_btn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.priv_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.priv_btn.ForeColor = System.Drawing.SystemColors.InfoText;
            this.priv_btn.Location = new System.Drawing.Point(282, 163);
            this.priv_btn.Name = "priv_btn";
            this.priv_btn.Size = new System.Drawing.Size(121, 37);
            this.priv_btn.TabIndex = 14;
            this.priv_btn.Text = "Show &Preview";
            this.priv_btn.UseVisualStyleBackColor = false;
            this.priv_btn.Click += new System.EventHandler(this.priv_btn_Click);
            // 
            // DwnldQLbl
            // 
            this.DwnldQLbl.AutoSize = true;
            this.DwnldQLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DwnldQLbl.Location = new System.Drawing.Point(65, 226);
            this.DwnldQLbl.Name = "DwnldQLbl";
            this.DwnldQLbl.Size = new System.Drawing.Size(117, 15);
            this.DwnldQLbl.TabIndex = 15;
            this.DwnldQLbl.Text = "Download Queue";
            // 
            // DownloadQueuePanel
            // 
            this.DownloadQueuePanel.AutoScroll = true;
            this.DownloadQueuePanel.BackColor = System.Drawing.Color.Azure;
            this.DownloadQueuePanel.Controls.Add(this.NoneLinkLabel);
            this.DownloadQueuePanel.Controls.Add(this.AllLinkLabel);
            this.DownloadQueuePanel.Location = new System.Drawing.Point(68, 242);
            this.DownloadQueuePanel.Name = "DownloadQueuePanel";
            this.DownloadQueuePanel.Size = new System.Drawing.Size(668, 204);
            this.DownloadQueuePanel.TabIndex = 16;
            // 
            // NoneLinkLabel
            // 
            this.NoneLinkLabel.AutoSize = true;
            this.NoneLinkLabel.Location = new System.Drawing.Point(32, 16);
            this.NoneLinkLabel.Name = "NoneLinkLabel";
            this.NoneLinkLabel.Size = new System.Drawing.Size(33, 13);
            this.NoneLinkLabel.TabIndex = 1;
            this.NoneLinkLabel.TabStop = true;
            this.NoneLinkLabel.Text = "None";
            this.NoneLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoneLinkLabel_LinkClicked);
            // 
            // AllLinkLabel
            // 
            this.AllLinkLabel.AutoSize = true;
            this.AllLinkLabel.Location = new System.Drawing.Point(12, 16);
            this.AllLinkLabel.Name = "AllLinkLabel";
            this.AllLinkLabel.Size = new System.Drawing.Size(18, 13);
            this.AllLinkLabel.TabIndex = 0;
            this.AllLinkLabel.TabStop = true;
            this.AllLinkLabel.Text = "All";
            this.AllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AllLinkLabel_LinkClicked);
            // 
            // UnDockbutton
            // 
            this.UnDockbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnDockbutton.Location = new System.Drawing.Point(569, 218);
            this.UnDockbutton.Name = "UnDockbutton";
            this.UnDockbutton.Size = new System.Drawing.Size(167, 23);
            this.UnDockbutton.TabIndex = 17;
            this.UnDockbutton.Text = "<< Undock from Main window";
            this.UnDockbutton.UseVisualStyleBackColor = true;
            this.UnDockbutton.Click += new System.EventHandler(this.UnDockbutton_Click);
            // 
            // SmartDownloaderGUI
            // 
            this.AcceptButton = this.StartDwnldBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(847, 531);
            this.Controls.Add(this.UnDockbutton);
            this.Controls.Add(this.DownloadQueuePanel);
            this.Controls.Add(this.DwnldQLbl);
            this.Controls.Add(this.priv_btn);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.Schedulebutton);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.SavetxtBox);
            this.Controls.Add(this.lblSaveFile);
            this.Controls.Add(this.ResumeBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.StartDwnldBtn);
            this.Controls.Add(this.URLlbl);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.SmartMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SmartMainMenu;
            this.Name = "SmartDownloaderGUI";
            this.Text = "Smart Downloader >>";
            this.Load += new System.EventHandler(this.SmartDownloaderGUI_Load);
            this.SmartMainMenu.ResumeLayout(false);
            this.SmartMainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.DownloadQueuePanel.ResumeLayout(false);
            this.DownloadQueuePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Label URLlbl;
        private System.Windows.Forms.Button StartDwnldBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.Label lblSaveFile;
        private System.Windows.Forms.TextBox SavetxtBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.MenuStrip SmartMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadQueueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Button Schedulebutton;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button priv_btn;
        private System.Windows.Forms.Label DwnldQLbl;
        private System.Windows.Forms.Panel DownloadQueuePanel;
        private System.Windows.Forms.Button UnDockbutton;
        private System.Windows.Forms.LinkLabel NoneLinkLabel;
        private System.Windows.Forms.LinkLabel AllLinkLabel;
    }
}

