using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartDownloader.Scheduler
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class SchedulerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.DateTimePicker datePicker;
		private System.Windows.Forms.Label dateLabel;
        private Label timeLabel;
        private Button okBtn;
		private System.ComponentModel.Container components=null;
        private string url;
        private TextBox urlTextBox;
        private Label urlLabel;
        private StatusStrip statusBar;
        private ToolStripStatusLabel statusMessageLabel;
        private string completeSaveFilename;
        private Button closeButton;
        private bool direct;
        
        public SchedulerForm(string url,string completeSaveFilename)
		{
			//
			// Required for Windows Form Designer support
			//
            this.url = url;
            this.completeSaveFilename = completeSaveFilename;
            InitializeComponent();
            this.Controls.Remove(urlLabel);
            this.Controls.Remove(urlTextBox);
            direct=false;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public SchedulerForm()
		{
			//
			// Required for Windows Form Designer support
			//
            this.url = "";
            this.completeSaveFilename = "";
            InitializeComponent();
            direct=true;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        public SchedulerForm(string url) : this(url,"") { }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerForm));
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusMessageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(61, 130);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(104, 20);
            this.timePicker.TabIndex = 0;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(61, 71);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Tan;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateLabel.Location = new System.Drawing.Point(5, 71);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 23);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date  ";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Tan;
            this.timeLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.timeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeLabel.Location = new System.Drawing.Point(5, 130);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(60, 20);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time  ";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.okBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.okBtn.Location = new System.Drawing.Point(63, 171);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(102, 30);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(61, 31);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(200, 20);
            this.urlTextBox.TabIndex = 6;
            this.urlTextBox.Text = "http://";
            // 
            // urlLabel
            // 
            this.urlLabel.BackColor = System.Drawing.Color.Tan;
            this.urlLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.urlLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urlLabel.Location = new System.Drawing.Point(5, 31);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(39, 23);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "Url ";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessageLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 214);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(355, 22);
            this.statusBar.TabIndex = 8;
            // 
            // statusMessageLabel
            // 
            this.statusMessageLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.statusMessageLabel.Name = "statusMessageLabel";
            this.statusMessageLabel.Size = new System.Drawing.Size(38, 17);
            this.statusMessageLabel.Text = "Ready";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.closeButton.Location = new System.Drawing.Point(193, 171);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(102, 30);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SchedulerForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Tan;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(355, 236);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.timePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchedulerForm";
            this.Text = "Scheduler >>";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		

		

		private void okBtn_Click(object sender, EventArgs e)
        {
            Scheduler sch=null;
            if(!direct)
            {
              if (completeSaveFilename == "")
                sch = new Scheduler(url);
              else
                sch = new Scheduler(url, completeSaveFilename);
            }
            else
            {
                if(urlTextBox.Text!="")
                  sch = new Scheduler(urlTextBox.Text);
            }
            bool success= sch.scheduleDownload(datePicker.Value, timePicker.Value,DateTime.Now);
            if (urlTextBox.Text == "http://")
            {
                if (success)
                    setStatusMessage(url + " download is scheduled");
                else
                    setStatusMessage(url + " download cannot be scheduled");
            }
            else
            {
                if (success)
                    setStatusMessage(urlTextBox.Text + " download is scheduled");
                else
                    setStatusMessage(urlTextBox.Text + " download cannot be scheduled");
            }
        }

        private void setStatusMessage(string p)
        {
            statusMessageLabel.Text=p;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

      



	}
}
