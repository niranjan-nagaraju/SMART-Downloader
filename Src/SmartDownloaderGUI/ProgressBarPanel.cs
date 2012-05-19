using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using SmartDownloader.Downloader;
using SmartDownloader;

namespace SmartDownloader.GUI
{
    public class ProgressBarPanel
    {
        public Panel progressPanel = new Panel();
        public Label infoLabel = new Label();
        public ProgressBar progressBar = new ProgressBar();
        public CheckBox selectThreadChkBox = new CheckBox();
        public LinkLabel openLinkLbl = new LinkLabel();

        private void initialize()
        {
            progressPanel.SuspendLayout();

            //progressPanel
            progressPanel.Controls.Add(infoLabel);
            progressPanel.Controls.Add(progressBar);
            progressPanel.Controls.Add(selectThreadChkBox);
            progressPanel.Controls.Add(openLinkLbl);
            progressPanel.Location = new System.Drawing.Point(12, 30);
            progressPanel.Size = new System.Drawing.Size(650, 125);
            progressPanel.Name = "Progress Panel";
            progressPanel.TabIndex = 0;

            //openLinkLabel
            openLinkLbl.AutoSize = true;
            this.openLinkLbl.Location = new System.Drawing.Point(475, 60);
            this.openLinkLbl.Name = "openLinkLbl";
            this.openLinkLbl.Size = new System.Drawing.Size(35, 15);
            this.openLinkLbl.TabIndex = 6;
            this.openLinkLbl.TabStop = true;
            this.openLinkLbl.Text = "Open";
            this.openLinkLbl.Enabled = false;
            this.openLinkLbl.Click += new EventHandler(openLinkLbl_Click);

            //selectThreadChkBox
            this.selectThreadChkBox.AutoSize = true;
            this.selectThreadChkBox.Location = new System.Drawing.Point(20, 60);
            this.selectThreadChkBox.Name = "selectThreadChkBox";
            this.selectThreadChkBox.Size = new System.Drawing.Size(15, 15);
            this.selectThreadChkBox.TabIndex = 5;
            this.selectThreadChkBox.UseVisualStyleBackColor = true;

            //infoLabel
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(65, 35);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "File : ";

            //progressBar
            this.progressBar.Location = new System.Drawing.Point(65, 52);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 20);
            this.progressBar.TabIndex = 0;
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 100;
            this.progressBar.Step = 1;
            
        }

        void openLinkLbl_Click(object sender, EventArgs e)
        {
            ThreadsAndDownloader threadAndDownloader =
                DownloadersAndPanels.getDownloaderThread(this.progressPanel);

            if (threadAndDownloader.Downloader.downloadstate == DownloadStates.completed)
            {
                ThreadManager.open(threadAndDownloader);
            }

        }

        public ProgressBarPanel()
        {
            this.initialize();
        }

        public ProgressBarPanel(int displacement)
        {
            this.initialize();
            this.progressPanel.Location = new System.Drawing.Point(12, 125 * displacement + 10);
        }
    }
}
