namespace SmartDownloader.MediaPreviewer
{
    partial class EnterUrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterUrl));
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(18, 19);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(29, 13);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "URL";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(21, 35);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(229, 20);
            this.UrlTextBox.TabIndex = 1;
            this.UrlTextBox.Text = "http://";
            // 
            // PreviewButton
            // 
            this.PreviewButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PreviewButton.ForeColor = System.Drawing.SystemColors.Window;
            this.PreviewButton.Location = new System.Drawing.Point(67, 76);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(142, 29);
            this.PreviewButton.TabIndex = 2;
            this.PreviewButton.Text = "Show &Preview";
            this.PreviewButton.UseVisualStyleBackColor = false;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // EnterUrl
            // 
            this.AcceptButton = this.PreviewButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(263, 135);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.UrlLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterUrl";
            this.Text = "Enter Url";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button PreviewButton;
    }
}
