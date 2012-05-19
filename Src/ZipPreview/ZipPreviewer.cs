
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.IO;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;

namespace SmartDownloader.ZipPreviewer
{

   
    public class ZipPreviewer : System.Windows.Forms.Form
    {
        MyRemoteZip zip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox FileListBox;
        private System.Windows.Forms.PropertyGrid FilePropertyGrid;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton TextRadioButton;
        private System.Windows.Forms.RadioButton ImageRadioButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private IContainer components;

        public ZipPreviewer()
        {
            InitializeComponent();
            zip = new MyRemoteZip(progressBar);
        }
        public ZipPreviewer(string url)
        {
            InitializeComponent();
            zip = new MyRemoteZip(progressBar);
            this.Controls.Remove(progressBar);
            this.Controls.Remove(urlLabel);
            this.Controls.Remove(urlTextBox);
            this.Controls.Remove(LoadButton);
            ZipLoad(url);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZipPreviewer));
            this.textBox = new System.Windows.Forms.TextBox();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.FilePropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.TextRadioButton = new System.Windows.Forms.RadioButton();
            this.ImageRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.Location = new System.Drawing.Point(7, 76);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(246, 238);
            this.textBox.TabIndex = 0;
            // 
            // FileListBox
            // 
            this.FileListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.FileListBox.BackColor = System.Drawing.Color.Azure;
            this.FileListBox.ContextMenu = this.contextMenu1;
            this.FileListBox.ForeColor = System.Drawing.Color.Black;
            this.FileListBox.Location = new System.Drawing.Point(267, 76);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.Size = new System.Drawing.Size(340, 238);
            this.FileListBox.TabIndex = 1;
            this.FileListBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            this.FileListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Preview";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Save As...";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // FilePropertyGrid
            // 
            this.FilePropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePropertyGrid.CommandsActiveLinkColor = System.Drawing.Color.White;
            this.FilePropertyGrid.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FilePropertyGrid.CommandsDisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FilePropertyGrid.HelpBackColor = System.Drawing.Color.Azure;
            this.FilePropertyGrid.LineColor = System.Drawing.SystemColors.MenuBar;
            this.FilePropertyGrid.Location = new System.Drawing.Point(620, 76);
            this.FilePropertyGrid.Name = "FilePropertyGrid";
            this.FilePropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.FilePropertyGrid.Size = new System.Drawing.Size(197, 236);
            this.FilePropertyGrid.TabIndex = 0;
            this.FilePropertyGrid.ViewBackColor = System.Drawing.Color.Azure;
            this.FilePropertyGrid.ViewForeColor = System.Drawing.Color.Black;
            this.FilePropertyGrid.Click += new System.EventHandler(this.propertyGrid1_Click);
            this.FilePropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(40, 14);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 20);
            this.urlTextBox.TabIndex = 4;
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // urlLabel
            // 
            this.urlLabel.Location = new System.Drawing.Point(7, 14);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(20, 20);
            this.urlLabel.TabIndex = 5;
            this.urlLabel.Text = "Url";
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LoadButton.ForeColor = System.Drawing.SystemColors.Window;
            this.LoadButton.Location = new System.Drawing.Point(561, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(80, 30);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "&Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLabel.Location = new System.Drawing.Point(7, 54);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(66, 19);
            this.FileLabel.TabIndex = 7;
            this.FileLabel.Text = "File Preview";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Files";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Properties";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "doc1";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.MistyRose;
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(659, 14);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(158, 21);
            this.progressBar.TabIndex = 10;
            // 
            // TextRadioButton
            // 
            this.TextRadioButton.Checked = true;
            this.TextRadioButton.Location = new System.Drawing.Point(153, 54);
            this.TextRadioButton.Name = "TextRadioButton";
            this.TextRadioButton.Size = new System.Drawing.Size(54, 20);
            this.TextRadioButton.TabIndex = 11;
            this.TextRadioButton.TabStop = true;
            this.TextRadioButton.Text = "Text";
            this.TextRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ImageRadioButton
            // 
            this.ImageRadioButton.Location = new System.Drawing.Point(93, 53);
            this.ImageRadioButton.Name = "ImageRadioButton";
            this.ImageRadioButton.Size = new System.Drawing.Size(54, 20);
            this.ImageRadioButton.TabIndex = 12;
            this.ImageRadioButton.Text = "Image";
            this.ImageRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Azure;
            this.pictureBox.Location = new System.Drawing.Point(7, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(246, 238);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // ZipPreviewer
            // 
            this.AcceptButton = this.LoadButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(831, 326);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ImageRadioButton);
            this.Controls.Add(this.TextRadioButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.FilePropertyGrid);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZipPreviewer";
            this.Text = "SMART ZipPreviewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

       
        


       
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (FileListBox.SelectedIndex != -1)
                FilePropertyGrid.SelectedObject = zip[FileListBox.SelectedIndex];
            else
                FilePropertyGrid.SelectedObject = null;
        }

        private void listBox1_DoubleClick(object sender, System.EventArgs e)
        {
            if (FileListBox.SelectedIndex != -1)
            {
                textBox.Text = "";
                ZipEntry zipe = zip[FileListBox.SelectedIndex];

                Stream s = zip.GetInputStream(zipe);
                if (s != null)
                {
                    if (pictureBox.Visible)
                    {
                        try
                        {
                            pictureBox.Image = new Bitmap(s);
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show("Not an Image File");
                            
                            pictureBox.Image = null;
                        }
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(s);
                        string t = "";
                        try
                        {
                            for (int i = 0; i < 2048; i++)
                            {
                                string tx = sr.ReadLine();
                                if (tx == null)
                                {
                                    t = t + "<Preview truncated here>" + "\r\n";
                                    break;
                                }
                                else
                                    t = t + tx + "\r\n";
                            }
                        }
                        catch (Exception ee)
                        { }
                        textBox.Text = t;
                    }
                    s.Close();
                }
                else
                    textBox.Text = "<Empty File or Directory>";
            }
        }

        public void ZipLoad(string url)
        {
            bool b = false;
            textBox.Text = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Text = "Loading ... " + url;
                b = zip.Load(url);
            }
            catch (Exception ee)
            {

            }
            Cursor.Current = Cursors.Arrow;

            FileListBox.Items.Clear();
            if (b)
            {
                foreach (ZipEntry zipe in zip)
                {
                    FileListBox.Items.Add(zipe.ToString());
                }
                urlTextBox.Text = url;
            }
            Text = "SMART ZipPreviewer " + url;

        }

        private void contextMenu1_Popup(object sender, System.EventArgs e)
        {
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            ZipLoad(urlTextBox.Text);
        }

        private void menuItem4_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            listBox1_DoubleClick(null, null);
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            if (FileListBox.SelectedIndex == -1)
                return;

            ZipEntry zipe = zip[FileListBox.SelectedIndex];

            saveFileDialog1.FileName = zipe.Name.Substring(zipe.Name.LastIndexOf('/') + 1);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Stream os = saveFileDialog1.OpenFile();
                Stream s = zip.GetInputStream(zipe);

                progressBar.Value = 0;
                byte[] bb = new byte[65536];
                int total = 0;

                try
                {
                    while (true)
                    {
                        int r = s.Read(bb, 0, bb.Length);
                        if (r <= 0)
                            break;
                        os.Write(bb, 0, r);
                        total += r;
                        progressBar.Value = (int)((total * 100) / zipe.Size);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Exception during transfer " + ee);
                }
                os.Close();
                s.Close();

            }
        }



        private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                button1_Click(null, null);
        }

        private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox.Visible = true;
            pictureBox.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {
            textBox.Visible = false;
            pictureBox.Visible = true;

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

       
    }
    public class MyRemoteZip : ZipPreview
    {
        public MyRemoteZip(ProgressBar p)
        {
            pb = p;
        }

        public override void OnProgress(int pct)
        {
            pb.Value = pct;
            Application.DoEvents();
        }

        ProgressBar pb;
    }
}
