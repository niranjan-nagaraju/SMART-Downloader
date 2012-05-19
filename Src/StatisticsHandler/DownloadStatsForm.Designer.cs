namespace SmartDownloader.StatisticsHandler
{
    partial class DownloadStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadStatsForm));
            this.DwnldStatsListBox = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DwnldStatsListBox
            // 
            this.DwnldStatsListBox.BackColor = System.Drawing.Color.Azure;
            this.DwnldStatsListBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DwnldStatsListBox.FormattingEnabled = true;
            this.DwnldStatsListBox.HorizontalScrollbar = true;
            this.DwnldStatsListBox.ItemHeight = 16;
            this.DwnldStatsListBox.Location = new System.Drawing.Point(12, 12);
            this.DwnldStatsListBox.MinimumSize = new System.Drawing.Size(644, 244);
            this.DwnldStatsListBox.Name = "DwnldStatsListBox";
            this.DwnldStatsListBox.ScrollAlwaysVisible = true;
            this.DwnldStatsListBox.Size = new System.Drawing.Size(644, 244);
            this.DwnldStatsListBox.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(127, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(178, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear &All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(326, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DownloadStatsForm
            // 
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(668, 350);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.DwnldStatsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(648, 384);
            this.Name = "DownloadStatsForm";
            this.Text = "Download Statistics";
            this.Load += new System.EventHandler(this.DownloadStatsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DwnldStatsListBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}