namespace SmartDownloader.Uploader
{
    partial class UploadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadForm));
            this.UploadButton = new System.Windows.Forms.Button();
            this.FiletextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectFileLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.closeButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.ForeColor = System.Drawing.SystemColors.Window;
            this.UploadButton.Location = new System.Drawing.Point(36, 170);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(98, 30);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "&Upload";
            this.UploadButton.UseVisualStyleBackColor = false;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // FiletextBox
            // 
            this.FiletextBox.Location = new System.Drawing.Point(36, 107);
            this.FiletextBox.Name = "FiletextBox";
            this.FiletextBox.Size = new System.Drawing.Size(261, 20);
            this.FiletextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BrowseButton.Location = new System.Drawing.Point(338, 99);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(99, 35);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "&Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SelectFileLabel
            // 
            this.SelectFileLabel.AutoSize = true;
            this.SelectFileLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectFileLabel.Location = new System.Drawing.Point(33, 91);
            this.SelectFileLabel.Name = "SelectFileLabel";
            this.SelectFileLabel.Size = new System.Drawing.Size(56, 13);
            this.SelectFileLabel.TabIndex = 3;
            this.SelectFileLabel.Text = "Select File";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(36, 57);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(264, 20);
            this.UrlTextBox.TabIndex = 4;
            this.UrlTextBox.Text = "http://";
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.ForeColor = System.Drawing.Color.Black;
            this.UrlLabel.Location = new System.Drawing.Point(42, 41);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(29, 13);
            this.UrlLabel.TabIndex = 5;
            this.UrlLabel.Text = "URL";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessageLabel,
            this.progressBar});
            this.statusBar.Location = new System.Drawing.Point(0, 242);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(458, 24);
            this.statusBar.TabIndex = 6;
            // 
            // statusMessageLabel
            // 
            this.statusMessageLabel.AutoSize = false;
            this.statusMessageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusMessageLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(290, 19);
            this.statusMessageLabel.Text = "Ready";
            this.statusMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(150, 18);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.closeButton.Location = new System.Drawing.Point(202, 170);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(98, 30);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // UploadForm
            // 
            this.AcceptButton = this.UploadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.SelectFileLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FiletextBox);
            this.Controls.Add(this.UploadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UploadForm";
            this.Text = "UploadForm";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox FiletextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label SelectFileLabel;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusMessageLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button closeButton;
    }
}