using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using QuartzTypeLib;

namespace SmartDownloader.MediaPreviewer
{
	
    public class MediaPreviewer : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private System.ComponentModel.IContainer components;

        private const int WM_APP = 0x8000;
        private const int WM_GRAPHNOTIFY = WM_APP + 1;
        private const int EC_COMPLETE = 0x01;
        private const int WS_CHILD = 0x40000000;
        private const int WS_CLIPCHILDREN = 0x2000000;

        private FilgraphManager m_objFilterGraph = null;
        private IBasicAudio m_objBasicAudio = null;
        private IVideoWindow m_objVideoWindow = null;
        private IMediaEvent m_objMediaEvent = null;
        private IMediaEventEx m_objMediaEventEx = null;
        private IMediaPosition m_objMediaPosition = null;
        private IMediaControl m_objMediaControl = null;
        private Panel panel1;
        private String fileName;

        enum MediaStatus { None, Stopped, Paused, Running };

        private MediaStatus m_CurrentStatus = MediaStatus.None;

        public MediaPreviewer(String tmpFileName)
        {
            InitializeComponent();
            fileName = tmpFileName;
            UpdateStatusBar();
            UpdateToolBar();
        }

        
        protected override void Dispose( bool disposing )
        {
            CleanUp();
            
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
       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPreviewer));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(442, 28);
            this.toolBar1.TabIndex = 0;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Enabled = false;
            this.toolBarButton1.ImageIndex = 0;
            this.toolBarButton1.Name = "toolBarButton1";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.Enabled = false;
            this.toolBarButton2.ImageIndex = 1;
            this.toolBarButton2.Name = "toolBarButton2";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Enabled = false;
            this.toolBarButton3.ImageIndex = 2;
            this.toolBarButton3.Name = "toolBarButton3";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 294);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(442, 25);
            this.statusBar1.TabIndex = 2;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Ready";
            this.statusBarPanel1.Width = 309;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "00:00:00";
            this.statusBarPanel2.Width = 58;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Text = "00:00:00";
            this.statusBarPanel3.Width = 58;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 266);
            this.panel1.TabIndex = 3;
            // 
            // MediaPreviewer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(442, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPreviewer";
            this.Text = "SMART MediaPreviewer";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Load += new System.EventHandler(this.MediaPreviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

       
        



        private void CleanUp()
        {
            if (m_objMediaControl != null)
                m_objMediaControl.Stop();

            m_CurrentStatus = MediaStatus.Stopped;

            if (m_objMediaEventEx != null)
                m_objMediaEventEx.SetNotifyWindow(0, 0, 0);

            if (m_objVideoWindow != null)
            {
                m_objVideoWindow.Visible = 0;
                m_objVideoWindow.Owner = 0;
            }

            if (m_objMediaControl != null) m_objMediaControl = null;
            if (m_objMediaPosition != null) m_objMediaPosition = null;
            if (m_objMediaEventEx != null) m_objMediaEventEx = null;
            if (m_objMediaEvent != null) m_objMediaEvent = null;
            if (m_objVideoWindow != null) m_objVideoWindow = null;
            if (m_objBasicAudio != null) m_objBasicAudio = null;
            if (m_objFilterGraph != null) m_objFilterGraph = null;
        }

        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            if (m_objVideoWindow != null)
            {
                m_objVideoWindow.SetWindowPosition(panel1.ClientRectangle.Left,
                    panel1.ClientRectangle.Top,
                    panel1.ClientRectangle.Width,
                    panel1.ClientRectangle.Height);
            }
        }

        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            switch(toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0: m_objMediaControl.Run();
                        m_CurrentStatus = MediaStatus.Running;
                        break; 

                case 1: m_objMediaControl.Pause();
                        m_CurrentStatus = MediaStatus.Paused;
                        break; 

                case 2: m_objMediaControl.Stop();
                        m_objMediaPosition.CurrentPosition = 0;
                        m_CurrentStatus = MediaStatus.Stopped;
                        break; 
            }
            
            UpdateStatusBar();
            UpdateToolBar();                        
        }

        protected override void WndProc( ref Message m)
        {
            if (m.Msg == WM_GRAPHNOTIFY)
            {
                int lEventCode;
                int lParam1, lParam2;

                while (true)
                {
                    try
                    {
                        m_objMediaEventEx.GetEvent(out lEventCode, 
                            out lParam1,
                            out lParam2,
                            0); 
 
                        m_objMediaEventEx.FreeEventParams(lEventCode, lParam1, lParam2);

                        if (lEventCode == EC_COMPLETE)
                        {
                            m_objMediaControl.Stop();
                            m_objMediaPosition.CurrentPosition = 0;
                            m_CurrentStatus = MediaStatus.Stopped;
                            UpdateStatusBar();
                            UpdateToolBar();
                        }
                    } 
                    catch (Exception)
                    {
                        break;
                    }
                }
            }

            base.WndProc(ref m);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (m_CurrentStatus == MediaStatus.Running)
            {
                UpdateStatusBar();
            }
        }

        private void UpdateStatusBar()
        {
            switch (m_CurrentStatus)
            {
                case MediaStatus.None   : statusBarPanel1.Text = "Stopped"; break;
                case MediaStatus.Paused : statusBarPanel1.Text = "Paused "; break;
                case MediaStatus.Running: statusBarPanel1.Text = "Running"; break;
                case MediaStatus.Stopped: statusBarPanel1.Text = "Stopped"; break;
            }

            if (m_objMediaPosition != null)
            {
                int s = (int) m_objMediaPosition.Duration;
                int h = s / 3600;
                int m = (s  - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                
                statusBarPanel2.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);

                s = (int) m_objMediaPosition.CurrentPosition;
                h = s / 3600;
                m = (s  - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                
                statusBarPanel3.Text = String.Format("{0:D2}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                statusBarPanel2.Text = "00:00:00";
                statusBarPanel3.Text = "00:00:00";
            }
        }

        private void UpdateToolBar()
        {
            switch (m_CurrentStatus)
            {
                case MediaStatus.None   : toolBarButton1.Enabled = false;
                                          toolBarButton2.Enabled = false;
                                          toolBarButton3.Enabled = false;
                                          break;
                                          
                case MediaStatus.Paused : toolBarButton1.Enabled = true;
                                          toolBarButton2.Enabled = false;
                                          toolBarButton3.Enabled = true;
                                          break;
                                          
                case MediaStatus.Running: toolBarButton1.Enabled = false;
                                          toolBarButton2.Enabled = true;
                                          toolBarButton3.Enabled = true;
                                          break;
                                          
                case MediaStatus.Stopped: toolBarButton1.Enabled = true;
                                          toolBarButton2.Enabled = false;
                                          toolBarButton3.Enabled = false;
                                          break;
            }
        }

        private void MediaPreviewer_Load(object sender, EventArgs e)
        {
                statusBarPanel1.Text = "Buffering !! Please  Wait";
                CleanUp();
                Console.WriteLine("download finished");
                m_objFilterGraph = new FilgraphManager();

                try
                {
                        m_objFilterGraph.RenderFile(fileName);
                }
                catch (Exception ex)
                {
                        return;
                }

                m_objBasicAudio = m_objFilterGraph as IBasicAudio;
                
                try
                {
                    m_objVideoWindow = m_objFilterGraph as IVideoWindow;
                    m_objVideoWindow.Owner = (int) panel1.Handle;
                    m_objVideoWindow.WindowStyle = WS_CHILD | WS_CLIPCHILDREN;
                    m_objVideoWindow.SetWindowPosition(panel1.ClientRectangle.Left,
                        panel1.ClientRectangle.Top,
                        panel1.ClientRectangle.Width,
                        panel1.ClientRectangle.Height);
                }
                catch (Exception)
                {
                    m_objVideoWindow = null;
                }

                m_objMediaEvent = m_objFilterGraph as IMediaEvent;

                m_objMediaEventEx = m_objFilterGraph as IMediaEventEx;
                m_objMediaEventEx.SetNotifyWindow((int) this.Handle,WM_GRAPHNOTIFY, 0);

                m_objMediaPosition = m_objFilterGraph as IMediaPosition;

                m_objMediaControl = m_objFilterGraph as IMediaControl;

                this.Text = "SMART MediaPreviewer";

                m_objMediaControl.Run();
                m_CurrentStatus = MediaStatus.Running;

                UpdateStatusBar();
                UpdateToolBar();
         }

        public static bool isMediaFile(string fileName)
        {
            string[] ext;
            ext = new string[13]{ ".dat" ,
                                 ".vob" ,
                                 ".mpg" ,
                                 ".avi" ,
                               ".mp3" ,
                               ".midi" ,
                               ".mp4" ,
                               ".avi",
                               ".asf",
                               ".wmv",
                               ".wma",
                               ".au",
                               ".mpeg"
                               };
            for(int i=0;i<13;i++)
                if(fileName.EndsWith(ext[i],StringComparison.OrdinalIgnoreCase))
                   return true;

            return false;
       }
    }
}
