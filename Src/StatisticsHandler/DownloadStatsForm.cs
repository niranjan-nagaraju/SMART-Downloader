using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

using SmartDownloader.StatisticsHandler;

namespace SmartDownloader.StatisticsHandler
{
    public partial class DownloadStatsForm : Form
    {
        public ArrayList savedStatistics;
        public int SelectedIndex = -1;

        public DownloadStatsForm()
        {
            InitializeComponent();
        }

        private void updateDownloadStatsListBox()
        {
            savedStatistics = StatisticsHandler.retrieveStatistics();
            DwnldStatsListBox.Items.Clear();

            if (savedStatistics.Count > 0)
            {
                foreach (DownloadStatistics dwnldStats in savedStatistics)
                {
                    DwnldStatsListBox.Items.Add(dwnldStats);
                }
            }
        }

       
        private void DownloadStatsForm_Load(object sender, EventArgs e)
        {
            this.updateDownloadStatsListBox();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            savedStatistics.Clear();

            StatisticsHandler.writeStatsToFile(savedStatistics);

            this.updateDownloadStatsListBox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectedIndex = DwnldStatsListBox.SelectedIndex;

            if (SelectedIndex >= 0)
            {
                DownloadStatistics dwnldStat = (DownloadStatistics)DwnldStatsListBox.Items[SelectedIndex];

                savedStatistics.Remove(dwnldStat);

                StatisticsHandler.writeStatsToFile(savedStatistics);

                this.updateDownloadStatsListBox();
            }

            else
            {
                MessageBox.Show("Please Select an Item to delete");
            }
        }


    }
}