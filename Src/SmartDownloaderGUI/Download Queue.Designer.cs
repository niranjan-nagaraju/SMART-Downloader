namespace SmartDownloader.GUI
{
    partial class DownloadQueueForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadQueueForm));
            this.DownloadQueueListBox = new System.Windows.Forms.ListBox();
            this.DQcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.Resumebtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.CleanUpButton = new System.Windows.Forms.Button();
            this.DQcontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadQueueListBox
            // 
            this.DownloadQueueListBox.AllowDrop = true;
            this.DownloadQueueListBox.BackColor = System.Drawing.Color.Azure;
            this.DownloadQueueListBox.ContextMenuStrip = this.DQcontextMenuStrip;
            this.DownloadQueueListBox.FormattingEnabled = true;
            this.DownloadQueueListBox.HorizontalScrollbar = true;
            this.DownloadQueueListBox.Location = new System.Drawing.Point(7, 12);
            this.DownloadQueueListBox.Name = "DownloadQueueListBox";
            this.DownloadQueueListBox.ScrollAlwaysVisible = true;
            this.DownloadQueueListBox.Size = new System.Drawing.Size(522, 277);
            this.DownloadQueueListBox.TabIndex = 0;
            // 
            // DQcontextMenuStrip
            // 
            this.DQcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.DQcontextMenuStrip.Name = "DQcontextMenuStrip";
            this.DQcontextMenuStrip.Size = new System.Drawing.Size(124, 70);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.refreshToolStripMenuItem.Text = "Re&fresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PauseBtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.PauseBtn.Location = new System.Drawing.Point(38, 295);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(107, 39);
            this.PauseBtn.TabIndex = 1;
            this.PauseBtn.Text = "&Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // Resumebtn
            // 
            this.Resumebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Resumebtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resumebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Resumebtn.Location = new System.Drawing.Point(151, 295);
            this.Resumebtn.Name = "Resumebtn";
            this.Resumebtn.Size = new System.Drawing.Size(107, 39);
            this.Resumebtn.TabIndex = 2;
            this.Resumebtn.Text = "&Resume";
            this.Resumebtn.UseVisualStyleBackColor = false;
            this.Resumebtn.Click += new System.EventHandler(this.Resumebtn_Click);
            // 
            // Stopbtn
            // 
            this.Stopbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Stopbtn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stopbtn.ForeColor = System.Drawing.SystemColors.Window;
            this.Stopbtn.Location = new System.Drawing.Point(264, 295);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(107, 39);
            this.Stopbtn.TabIndex = 3;
            this.Stopbtn.Text = "&Stop";
            this.Stopbtn.UseVisualStyleBackColor = false;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // CleanUpButton
            // 
            this.CleanUpButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CleanUpButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanUpButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CleanUpButton.Location = new System.Drawing.Point(377, 295);
            this.CleanUpButton.Name = "CleanUpButton";
            this.CleanUpButton.Size = new System.Drawing.Size(107, 39);
            this.CleanUpButton.TabIndex = 4;
            this.CleanUpButton.Text = "&Clean up";
            this.CleanUpButton.UseVisualStyleBackColor = false;
            this.CleanUpButton.Click += new System.EventHandler(this.CleanUpButton_Click);
            // 
            // DownloadQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(536, 349);
            this.Controls.Add(this.CleanUpButton);
            this.Controls.Add(this.Stopbtn);
            this.Controls.Add(this.Resumebtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.DownloadQueueListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadQueueForm";
            this.Text = "Download Queue";
            this.Load += new System.EventHandler(this.DownloadQueueForm_Load);
            this.DQcontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DownloadQueueListBox;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button Resumebtn;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Button CleanUpButton;
        private System.Windows.Forms.ContextMenuStrip DQcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}