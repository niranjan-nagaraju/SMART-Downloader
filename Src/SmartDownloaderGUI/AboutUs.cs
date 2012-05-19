using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartDownloader.GUI
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class AboutUs : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label smartdownloaderlabel;
		private System.Windows.Forms.RichTextBox AuthorInfo;
        private Button closeButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutUs()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.smartdownloaderlabel = new System.Windows.Forms.Label();
            this.AuthorInfo = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smartdownloaderlabel
            // 
            this.smartdownloaderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartdownloaderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.smartdownloaderlabel.Location = new System.Drawing.Point(83, 20);
            this.smartdownloaderlabel.Name = "smartdownloaderlabel";
            this.smartdownloaderlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.smartdownloaderlabel.Size = new System.Drawing.Size(321, 32);
            this.smartdownloaderlabel.TabIndex = 0;
            this.smartdownloaderlabel.Text = "   S.M.A.R.T  Downloader";
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.BackColor = System.Drawing.Color.Moccasin;
            this.AuthorInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AuthorInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorInfo.ForeColor = System.Drawing.Color.Brown;
            this.AuthorInfo.Location = new System.Drawing.Point(28, 55);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.ReadOnly = true;
            this.AuthorInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorInfo.Size = new System.Drawing.Size(475, 215);
            this.AuthorInfo.TabIndex = 2;
            this.AuthorInfo.Text = resources.GetString("AuthorInfo.Text");
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.closeButton.Location = new System.Drawing.Point(183, 276);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 37);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(535, 325);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.AuthorInfo);
            this.Controls.Add(this.smartdownloaderlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "About Us";
            this.ResumeLayout(false);

		}
		#endregion

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		

		
	}
}
