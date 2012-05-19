using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Security.Cryptography;

namespace SmartDownloader.Encryption
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmFileEncryptDecrypt : System.Windows.Forms.Form
	{	
		private System.Windows.Forms.TabPage tpEncrypt;
		private System.Windows.Forms.TabPage tpDecrypt;
		private System.Windows.Forms.TabControl tbcFileCryptor;
		private System.Windows.Forms.TextBox txtEncPass;
		private System.Windows.Forms.TextBox txtEncFile;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnEncBrowse;
		private System.Windows.Forms.TextBox txtDecFile;
		private System.Windows.Forms.TextBox txtDecPass;
		private System.Windows.Forms.Button btnDecBrowse;
		private System.Windows.Forms.ProgressBar pbEncrypt;
		private System.Windows.Forms.OpenFileDialog ofdEnc;
		private System.Windows.Forms.OpenFileDialog ofdDec;
        private System.Windows.Forms.ProgressBar pbDec;
        private Label Selectlabel;
        private Label Keylabel;
        private Label label1;
        private Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmFileEncryptDecrypt(int flag)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            if(flag==1)
              this.tbcFileCryptor.SelectedIndex = 1;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileEncryptDecrypt));
            this.tbcFileCryptor = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.Selectlabel = new System.Windows.Forms.Label();
            this.Keylabel = new System.Windows.Forms.Label();
            this.pbEncrypt = new System.Windows.Forms.ProgressBar();
            this.btnEncBrowse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncFile = new System.Windows.Forms.TextBox();
            this.txtEncPass = new System.Windows.Forms.TextBox();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbDec = new System.Windows.Forms.ProgressBar();
            this.btnDecBrowse = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecFile = new System.Windows.Forms.TextBox();
            this.txtDecPass = new System.Windows.Forms.TextBox();
            this.ofdEnc = new System.Windows.Forms.OpenFileDialog();
            this.ofdDec = new System.Windows.Forms.OpenFileDialog();
            this.tbcFileCryptor.SuspendLayout();
            this.tpEncrypt.SuspendLayout();
            this.tpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcFileCryptor
            // 
            this.tbcFileCryptor.Controls.Add(this.tpEncrypt);
            this.tbcFileCryptor.Controls.Add(this.tpDecrypt);
            this.tbcFileCryptor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcFileCryptor.Location = new System.Drawing.Point(0, 0);
            this.tbcFileCryptor.Name = "tbcFileCryptor";
            this.tbcFileCryptor.SelectedIndex = 0;
            this.tbcFileCryptor.Size = new System.Drawing.Size(434, 199);
            this.tbcFileCryptor.TabIndex = 0;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.BackColor = System.Drawing.Color.Tan;
            this.tpEncrypt.Controls.Add(this.Selectlabel);
            this.tpEncrypt.Controls.Add(this.Keylabel);
            this.tpEncrypt.Controls.Add(this.pbEncrypt);
            this.tpEncrypt.Controls.Add(this.btnEncBrowse);
            this.tpEncrypt.Controls.Add(this.btnEncrypt);
            this.tpEncrypt.Controls.Add(this.txtEncFile);
            this.tpEncrypt.Controls.Add(this.txtEncPass);
            this.tpEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Size = new System.Drawing.Size(426, 173);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Encrypt";
            // 
            // Selectlabel
            // 
            this.Selectlabel.AutoSize = true;
            this.Selectlabel.Location = new System.Drawing.Point(8, 65);
            this.Selectlabel.Name = "Selectlabel";
            this.Selectlabel.Size = new System.Drawing.Size(23, 13);
            this.Selectlabel.TabIndex = 6;
            this.Selectlabel.Text = "File";
            // 
            // Keylabel
            // 
            this.Keylabel.AutoSize = true;
            this.Keylabel.Location = new System.Drawing.Point(8, 17);
            this.Keylabel.Name = "Keylabel";
            this.Keylabel.Size = new System.Drawing.Size(25, 13);
            this.Keylabel.TabIndex = 5;
            this.Keylabel.Text = "Key";
            // 
            // pbEncrypt
            // 
            this.pbEncrypt.Location = new System.Drawing.Point(129, 142);
            this.pbEncrypt.Name = "pbEncrypt";
            this.pbEncrypt.Size = new System.Drawing.Size(235, 15);
            this.pbEncrypt.TabIndex = 4;
            // 
            // btnEncBrowse
            // 
            this.btnEncBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncBrowse.Location = new System.Drawing.Point(332, 78);
            this.btnEncBrowse.Name = "btnEncBrowse";
            this.btnEncBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnEncBrowse.TabIndex = 3;
            this.btnEncBrowse.Text = "&Browse";
            this.btnEncBrowse.Click += new System.EventHandler(this.btnEncBrowse_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEncrypt.Location = new System.Drawing.Point(8, 125);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(102, 32);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "&Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncFile
            // 
            this.txtEncFile.Location = new System.Drawing.Point(8, 81);
            this.txtEncFile.Name = "txtEncFile";
            this.txtEncFile.Size = new System.Drawing.Size(304, 20);
            this.txtEncFile.TabIndex = 1;
            // 
            // txtEncPass
            // 
            this.txtEncPass.Location = new System.Drawing.Point(8, 33);
            this.txtEncPass.Name = "txtEncPass";
            this.txtEncPass.PasswordChar = '*';
            this.txtEncPass.Size = new System.Drawing.Size(304, 20);
            this.txtEncPass.TabIndex = 0;
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.BackColor = System.Drawing.Color.Tan;
            this.tpDecrypt.Controls.Add(this.label2);
            this.tpDecrypt.Controls.Add(this.label1);
            this.tpDecrypt.Controls.Add(this.pbDec);
            this.tpDecrypt.Controls.Add(this.btnDecBrowse);
            this.tpDecrypt.Controls.Add(this.btnDecrypt);
            this.tpDecrypt.Controls.Add(this.txtDecFile);
            this.tpDecrypt.Controls.Add(this.txtDecPass);
            this.tpDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Size = new System.Drawing.Size(426, 173);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Decrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Key";
            // 
            // pbDec
            // 
            this.pbDec.Location = new System.Drawing.Point(123, 133);
            this.pbDec.Name = "pbDec";
            this.pbDec.Size = new System.Drawing.Size(234, 15);
            this.pbDec.TabIndex = 6;
            // 
            // btnDecBrowse
            // 
            this.btnDecBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecBrowse.Location = new System.Drawing.Point(332, 78);
            this.btnDecBrowse.Name = "btnDecBrowse";
            this.btnDecBrowse.Size = new System.Drawing.Size(76, 23);
            this.btnDecBrowse.TabIndex = 5;
            this.btnDecBrowse.Text = "&Browse";
            this.btnDecBrowse.Click += new System.EventHandler(this.btnDecBrowse_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDecrypt.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDecrypt.Location = new System.Drawing.Point(8, 120);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(109, 28);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "&Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecFile
            // 
            this.txtDecFile.Location = new System.Drawing.Point(8, 81);
            this.txtDecFile.Name = "txtDecFile";
            this.txtDecFile.Size = new System.Drawing.Size(304, 20);
            this.txtDecFile.TabIndex = 3;
            // 
            // txtDecPass
            // 
            this.txtDecPass.Location = new System.Drawing.Point(8, 33);
            this.txtDecPass.Name = "txtDecPass";
            this.txtDecPass.PasswordChar = '*';
            this.txtDecPass.Size = new System.Drawing.Size(304, 20);
            this.txtDecPass.TabIndex = 2;
            // 
            // ofdEnc
            // 
            this.ofdEnc.Filter = "All files (*.*)|*.*";
            // 
            // ofdDec
            // 
            this.ofdDec.Filter = "FileCryptor Files (*.fcfe)|*.fcfe";
            // 
            // frmFileEncryptDecrypt
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 199);
            this.Controls.Add(this.tbcFileCryptor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFileEncryptDecrypt";
            this.Text = "File Encrypt/Decrypt";
            this.tbcFileCryptor.ResumeLayout(false);
            this.tpEncrypt.ResumeLayout(false);
            this.tpEncrypt.PerformLayout();
            this.tpDecrypt.ResumeLayout(false);
            this.tpDecrypt.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		

		private void btnEncBrowse_Click(object sender, System.EventArgs e)
		{
			if(DialogResult.OK == ofdEnc.ShowDialog())
			{
				txtEncFile.Text = ofdEnc.FileName;
			}
		}

		private void btnDecBrowse_Click(object sender, System.EventArgs e)
		{
			if(DialogResult.OK == ofdDec.ShowDialog())
			{
				txtDecFile.Text = ofdDec.FileName;
			}
		}

		private void btnEncrypt_Click(object sender, System.EventArgs e)
		{
			if(txtEncFile.Text != String.Empty &&
				File.Exists(txtEncFile.Text))
			{
				string inFile = txtEncFile.Text;
				string outFile = txtEncFile.Text + ".fcfe";
				string password = txtEncPass.Text;
				CryptoProgressCallBack cb = new CryptoProgressCallBack(this.ProgressCallBackEncrypt);

				CryptoHelp.EncryptFile(inFile,outFile,password,cb);

				pbEncrypt.Value = 0;
			}
		}

		private void btnDecrypt_Click(object sender, System.EventArgs e)
		{
			if(txtDecFile.Text != String.Empty &&
				File.Exists(txtDecFile.Text))
			{
				string inFile = txtDecFile.Text;
				int index = inFile.LastIndexOf(".fcf");
				string outFile = inFile.Substring(0,index);
				string password = txtDecPass.Text;
				CryptoProgressCallBack cb = new CryptoProgressCallBack(this.ProgressCallBackDecrypt);
				
				CryptoHelp.DecryptFile(inFile,outFile+".fcfd",password,cb);

				pbDec.Value = 0;
			}
		}

		void ProgressCallBackEncrypt(int min, int max, int value)
		{
			pbEncrypt.Minimum = min;
			pbEncrypt.Maximum = max;
			pbEncrypt.Value = value;
			Application.DoEvents();
		}

		void ProgressCallBackDecrypt(int min, int max, int value)
		{
			pbDec.Maximum = max;
			pbDec.Minimum = min;
			pbDec.Value = value;
			Application.DoEvents();
		}
	}
}
