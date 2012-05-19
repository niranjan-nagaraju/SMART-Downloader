using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.IO;
using System.Globalization;


namespace SmartDownloader.FTPDownloader
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FTPClientUI : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPwd;
		private System.Windows.Forms.Label lblPort;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListView lstMessages;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Splitter splitter1;

		// into imagelist:
		//	at index 0 there's folder bmp
		//	at index 1 there's file bmp
		//	at index 2 there's link bmp
		private static int INDEX_TAG_DIR = 0;
		private static int INDEX_TAG_FILE = 1;
		private static int INDEX_TAG_LINK = 2;

		private connectionlist connectionlist = new connectionlist();
		private String binFname;
		
		private ListViewItem lvDragItem;
		private DragDropEffects CurrentEffect;
		private string startingFrom="";

		private System.Windows.Forms.ImageList imageList1;

		private ListViewColumnSorter lvwColumnSorter;
		private ListViewColumnSorter lvwLocalColumnSorter;


		private string sLocalPath = "";
		private string sRemotePath = "";
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.Panel localPanel;
		private System.Windows.Forms.ListView lvLocalFiles;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtLocalPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Panel remotePanel;
		private System.Windows.Forms.ListView lvFiles;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnPrevConnect;
		private System.Windows.Forms.ContextMenu contextMenuRemote;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ContextMenu contextMenuLocal;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		
		FtpClient ftpClient = null;
 
		public FTPClientUI()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			// load connections
			binFname = Application.ExecutablePath;
			binFname = binFname.Substring(0, binFname.LastIndexOf("\\")) + "\\lightftpclient.bin";

			ConnectionDeserialize();
			
			// assign imagelist to listview controls
			lvFiles.SmallImageList = imageList1;
			lvLocalFiles.SmallImageList = imageList1;

			// Create an instance of a ListView column sorter and assign it 
			// to ListView control.
			lvwColumnSorter = new ListViewColumnSorter();
			this.lvFiles.ListViewItemSorter = lvwColumnSorter;

			lvwLocalColumnSorter = new ListViewColumnSorter();
			this.lvLocalFiles.ListViewItemSorter = lvwLocalColumnSorter;					

			// initialize list which shows local directory
			this.lvLocalFiles.AllowDrop = true;
			InitLocalListView();

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTPClientUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevConnect = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstMessages = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.localPanel = new System.Windows.Forms.Panel();
            this.lvLocalFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuLocal = new System.Windows.Forms.ContextMenu();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.remotePanel = new System.Windows.Forms.Panel();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuRemote = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.localPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.remotePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnPrevConnect);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.lblPort);
            this.panel1.Controls.Add(this.lblPwd);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnPrevConnect
            // 
            this.btnPrevConnect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrevConnect.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnPrevConnect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrevConnect.Location = new System.Drawing.Point(400, 34);
            this.btnPrevConnect.Name = "btnPrevConnect";
            this.btnPrevConnect.Size = new System.Drawing.Size(144, 30);
            this.btnPrevConnect.TabIndex = 11;
            this.btnPrevConnect.Text = "&Previous Connections";
            this.btnPrevConnect.UseVisualStyleBackColor = false;
            this.btnPrevConnect.Click += new System.EventHandler(this.btnPrevConnect_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(256, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "anonymous";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDisconnect.Location = new System.Drawing.Point(16, 34);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(80, 29);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "&Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnConnect.Enabled = false;
            this.btnConnect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConnect.Location = new System.Drawing.Point(104, 34);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 29);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(584, 8);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 13);
            this.lblPort.TabIndex = 7;
            this.lblPort.Text = "Port:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(384, 8);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(73, 13);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(216, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(41, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "User:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 8);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(624, 8);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(32, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "21";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(456, 8);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(96, 20);
            this.txtPwd.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(256, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(104, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(120, 20);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            // 
            // lstMessages
            // 
            this.lstMessages.BackColor = System.Drawing.Color.Azure;
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lstMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstMessages.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMessages.ForeColor = System.Drawing.Color.Black;
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstMessages.Location = new System.Drawing.Point(0, 72);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(682, 127);
            this.lstMessages.TabIndex = 9;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Messages";
            this.columnHeader5.Width = 700;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 199);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(682, 5);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoving += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoving);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar1.Location = new System.Drawing.Point(0, 364);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(682, 22);
            this.statusBar1.TabIndex = 13;
            this.statusBar1.Text = "sdsdssssss";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 665;
            // 
            // localPanel
            // 
            this.localPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localPanel.Controls.Add(this.lvLocalFiles);
            this.localPanel.Controls.Add(this.panel4);
            this.localPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.localPanel.Location = new System.Drawing.Point(0, 204);
            this.localPanel.Name = "localPanel";
            this.localPanel.Size = new System.Drawing.Size(329, 160);
            this.localPanel.TabIndex = 19;
            // 
            // lvLocalFiles
            // 
            this.lvLocalFiles.AllowDrop = true;
            this.lvLocalFiles.BackColor = System.Drawing.Color.Azure;
            this.lvLocalFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvLocalFiles.ContextMenu = this.contextMenuLocal;
            this.lvLocalFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLocalFiles.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLocalFiles.FullRowSelect = true;
            this.lvLocalFiles.GridLines = true;
            this.lvLocalFiles.Location = new System.Drawing.Point(0, 32);
            this.lvLocalFiles.MultiSelect = false;
            this.lvLocalFiles.Name = "lvLocalFiles";
            this.lvLocalFiles.Size = new System.Drawing.Size(327, 126);
            this.lvLocalFiles.TabIndex = 22;
            this.lvLocalFiles.UseCompatibleStateImageBehavior = false;
            this.lvLocalFiles.View = System.Windows.Forms.View.Details;
            this.lvLocalFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvLocalFiles_DragEnter);
            this.lvLocalFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvLocalFiles_DragDrop);
            this.lvLocalFiles.DoubleClick += new System.EventHandler(this.lvLocalFiles_DoubleClick);
            this.lvLocalFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.lvLocalFiles_DragOver);
            this.lvLocalFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvLocalFiles_KeyDown);
            this.lvLocalFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLocalFiles_ColumnClick);
            this.lvLocalFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvLocalFiles_ItemDrag);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 22;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 90;
            // 
            // contextMenuLocal
            // 
            this.contextMenuLocal.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem6});
            this.contextMenuLocal.Popup += new System.EventHandler(this.contextMenuLocal_Popup);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Refresh (F5)";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Rename (F2)";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "Deleted (DEL)";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Tan;
            this.panel4.Controls.Add(this.txtLocalPath);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 32);
            this.panel4.TabIndex = 21;
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Location = new System.Drawing.Point(48, 5);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(264, 20);
            this.txtLocalPath.TabIndex = 1;
            this.txtLocalPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalPath_KeyPress);
            this.txtLocalPath.TextChanged += new System.EventHandler(this.txtLocalPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(329, 204);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 160);
            this.splitter2.TabIndex = 20;
            this.splitter2.TabStop = false;
            // 
            // remotePanel
            // 
            this.remotePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remotePanel.Controls.Add(this.lvFiles);
            this.remotePanel.Controls.Add(this.panel5);
            this.remotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remotePanel.Location = new System.Drawing.Point(339, 204);
            this.remotePanel.Name = "remotePanel";
            this.remotePanel.Size = new System.Drawing.Size(343, 160);
            this.remotePanel.TabIndex = 21;
            // 
            // lvFiles
            // 
            this.lvFiles.BackColor = System.Drawing.Color.Azure;
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvFiles.FullRowSelect = true;
            this.lvFiles.GridLines = true;
            this.lvFiles.Location = new System.Drawing.Point(0, 32);
            this.lvFiles.MultiSelect = false;
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(341, 126);
            this.lvFiles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvFiles.TabIndex = 24;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.View = System.Windows.Forms.View.Details;
            this.lvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragEnter);
            this.lvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragDrop);
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            this.lvFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.lvFiles_DragOver);
            this.lvFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFiles_KeyDown);
            this.lvFiles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvFiles_ColumnClick);
            this.lvFiles.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvFiles_ItemDrag);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 22;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Size";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Date";
            this.columnHeader9.Width = 90;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Tan;
            this.panel5.Controls.Add(this.txtPath);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(341, 32);
            this.panel5.TabIndex = 23;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(48, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(280, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPath_KeyPress);
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Path:";
            // 
            // contextMenuRemote
            // 
            this.contextMenuRemote.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            this.contextMenuRemote.Popup += new System.EventHandler(this.contextMenuRemote_Popup);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Refresh (F5)";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Rename (F2)";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Delete (DEL)";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // FTPClientUI
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.remotePanel);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.localPanel);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FTPClientUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTPClient >>";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.localPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.remotePanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		

		private void txtAddress_TextChanged(object sender, System.EventArgs e)
		{
			if (txtAddress.Text.Length > 0)
				btnConnect.Enabled = true;
			else
				btnConnect.Enabled = false;
		}

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			connectiondata conndata = new connectiondata();
			try
			{
				conndata.address = txtAddress.Text;
				conndata.username = txtUsername.Text;
				conndata.password = txtPwd.Text;
				conndata.port= txtPort.Text;
				conndata.anonymous = (checkBox1.Checked)?true:false;
				if ( !connectionlist.SearchItem(conndata) )
				{
					connectionlist.AddItem(conndata);
				}
				Login();

				btnConnect.Enabled = false;
				btnDisconnect.Enabled=true;

				lvwColumnSorter.Order = SortOrder.Ascending;
				ChangeDir("/");
				lvFiles.AllowDrop = true;

				// set context menu for the remote file list
				lvFiles.ContextMenu = contextMenuRemote;

				// reset address changement
				txtAddress.TextChanged -= new System.EventHandler(this.txtAddress_TextChanged);
			}
			catch 
			{
				ftpClient.Close();
				ftpClient=null;
				btnConnect.Enabled = true;
				btnDisconnect.Enabled = false;
				lvFiles.AllowDrop = false;
			}
				
		}

		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
			CloseConnection();
			btnConnect.Enabled = true;
			btnDisconnect.Enabled = false;
			// reset context menu for the remote file list
			lvFiles.ContextMenu = null;
			// set address changement
			txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
		}

		protected void InitLocalListView()
		{
			txtLocalPath.Text = Application.StartupPath;
			PopulateLocalFileList();
		}

		protected void ChangeLocalDir(string newdir)
		{
			if (newdir == "..")
			{
				int l = txtLocalPath.Text.LastIndexOf('\\');
				txtLocalPath.Text = txtLocalPath.Text.Substring(0, l);
			}
			else
			{
				if (newdir.Length > 0)
				{
					if (txtLocalPath.Text[txtLocalPath.Text.Length-1] != '\\')
						txtLocalPath.Text += "\\";
					txtLocalPath.Text += newdir;
				}
			}
			if (txtLocalPath.Text.Length < 3)
				txtLocalPath.Text += "\\";

			PopulateLocalFileList();
		}

		protected void PopulateLocalFileList()
		{
			//Populate listview with files
			string[] lvData =  new string[4];
			string sPath = txtLocalPath.Text;
			
			InitListView(lvLocalFiles);

	
			if (sPath.Length > 3)
				addParentDirectory(lvLocalFiles);
			else
			{
				
			}
			try
			{
				string[] stringDir = Directory.GetDirectories(sPath);
				string[] stringFiles = Directory.GetFiles(sPath);
				
				string stringFileName = "";
				DateTime dtCreateDate, dtModifyDate;
				Int64 lFileSize = 0;

				foreach (string stringFile in stringDir)
				{
					stringFileName = stringFile;
					FileInfo objFileSize = new FileInfo(stringFileName);
					lFileSize = 0;
					dtCreateDate = objFileSize.CreationTime; //GetCreationTime(stringFileName);
					dtModifyDate = objFileSize.LastWriteTime; //GetLastWriteTime(stringFileName);

					//create listview data
					lvData[0] = "";
					lvData[1] = GetPathName(stringFileName);
					lvData[2] = formatSize(lFileSize);
					lvData[3] = formatDate(dtModifyDate);

					//Create actual list item
					ListViewItem lvItem = new ListViewItem(lvData,0); // 0 = directory
					lvLocalFiles.Items.Add(lvItem);

				}

				foreach (string stringFile in stringFiles)
				{
					stringFileName = stringFile;
					FileInfo objFileSize = new FileInfo(stringFileName);
					lFileSize = objFileSize.Length;
					dtCreateDate = objFileSize.CreationTime; //GetCreationTime(stringFileName);
					dtModifyDate = objFileSize.LastWriteTime; //GetLastWriteTime(stringFileName);

					//create listview data
					lvData[0] = "";
					lvData[1] = GetPathName(stringFileName);
					lvData[2] = formatSize(lFileSize);
					lvData[3] = formatDate(dtModifyDate);

					//Create actual list item
					ListViewItem lvItem = new ListViewItem(lvData,1); // 1 = file
					lvLocalFiles.Items.Add(lvItem);


				}

				// Loop through and size each column header to fit the column header text.
				foreach (ColumnHeader ch in this.lvLocalFiles.Columns)
				{			
					ch.Width = -2;
				}

			}
			catch (IOException)
			{
				MessageBox.Show("Error: Drive not ready or directory does not exist.");
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("Error: Drive or directory access denided.");
			}
			catch (Exception ee)
			{
				MessageBox.Show("Error: " + ee);
			}
			lvLocalFiles.Invalidate();
			lvLocalFiles.Update();
		
		}


		protected void InitListView(ListView lvFiles)
		{
			//init ListView control
			lvFiles.Clear();		//clear control
			//create column header for ListView
			lvFiles.Columns.Add("",22,System.Windows.Forms.HorizontalAlignment.Center);
			lvFiles.Columns.Add("Name",140,System.Windows.Forms.HorizontalAlignment.Left);
			lvFiles.Columns.Add("Size",60, System.Windows.Forms.HorizontalAlignment.Right);
			lvFiles.Columns.Add("Date", 90, System.Windows.Forms.HorizontalAlignment.Left);


		}


		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ConnectionSerialize();
			CloseConnection();
			lvFiles.AllowDrop = false;
		}

#region FTP commands

		/// <summary>
		/// Create a new Instance of FtpClient
		/// Then Login to ftp server
		/// </summary>
		private void Login()
		{
			if (ftpClient == null)
			{
				ftpClient = new FtpClient(txtAddress.Text, txtUsername.Text, txtPwd.Text, 10, Convert.ToInt16(txtPort.Text));
				ftpClient.lstMessage = lstMessages;
			}
			try
			{
				ftpClient.Login();
			}
			catch (FtpClient.FtpException ex)
			{
				Warning("", ex.Message);
				throw new Exception(ex.Message);
			}

		}

		/// <summary>
		/// Close connection to ftp server
		/// </summary>
		private void CloseConnection()
		{
			if (ftpClient != null)
				ftpClient.Close();
			ftpClient = null;
			lvFiles.Items.Clear();
		}

		/// <summary>
		/// Create a new Instance of FtpClient
		/// Then Login to ftp server
		/// </summary>
		private void GetFileList(string path)
		{
			string[] filelist;
			ListViewItem litem;
			string item = "";
			try 
			{
				InitListView(lvFiles);

				if (txtPath.Text != "/")
					addParentDirectory(lvFiles);

				filelist = ftpClient.GetFileList(path);
				for (int ii=0; (ii < filelist.Length) && (filelist[ii] != ""); ii++)
				{
					item = filelist[ii];

					// fill listview according to format
					// and OS
					switch (ftpClient.ServerOS)
					{
						case 1:
							// Unix format
							litem = parseUnixData(filelist[ii]);									
							if (litem != null)					
								lvFiles.Items.Add(litem );
							break;
						case 2:
							// Windows OS
							switch (filelist[ii][0])
							{
								case '-':
								case 'd':
								case 'l':
									// Unix format
									litem = parseUnixData(filelist[ii]);
									if (litem != null)					
										lvFiles.Items.Add(litem );
									break;
								default:
									// DOS format
									litem = parseDosData(filelist[ii]);
									if (litem != null)					
										lvFiles.Items.Add(litem );
									break;
							}
							break;

						default:
							litem = null;
							break;
					}
					
							

				}

				// Loop through and size each column header 
				// to fit the column header text.
				foreach (ColumnHeader ch in this.lvFiles.Columns)
				{			
					ch.Width = -2;
				}

				this.lvFiles.Sort();
			}
			catch (FtpClient.FtpException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{	
				lstMessages.Items.Add( ex.Message);
			}

		}



		/// <summary>
		/// Change remote dir
		/// </summary>
		/// <param name="dirname"></param>
		private void ChangeDir(string dirname)
		{
			try
			{
				if (ftpClient != null)
				{
					txtPath.Text = ftpClient.ChangeDir(dirname);
					GetFileList("");
				}
			}
			catch (FtpClient.FtpException ex)
			{
				Warning("", ex.Message);
			}
			
		}

		/// <summary>
		/// Rename a file on the remote FTP server.
		/// </summary>
		/// <param name="oldFileName"></param>
		private void RenameFile(string oldFileName)
		{
			string newFileName; 
			bool overwrite = false;

			frmRenameFile frm = new frmRenameFile();
			if ((newFileName = frm.ShowModal(oldFileName)) != oldFileName)
			{
				try
				{
					if (ftpClient != null)
					{
						ftpClient.RenameFile(oldFileName, newFileName, overwrite);
					}
				}
				catch (FtpClient.FtpException ex)
				{
					Warning("", ex.Message);
				}
			
			}
		}

		/// <summary>
		/// Delete a file from the remote FTP server.
		/// </summary>
		/// <param name="fileName"></param>
		private void DeleteFile(string fileName)
		{
			DialogResult dlgr = MessageBox.Show("Are you sure to delete '" + fileName + "'?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
			if (dlgr == DialogResult.Yes)
			{
				try
				{
					if (ftpClient != null)
					{
						UpdateStatusBar("Deleting....");
						ftpClient.DeleteFile(fileName);

					}

				}
				catch (FtpClient.FtpException ex)
				{
					Warning("", ex.Message);
				}
				catch (Exception ex)
				{
					Warning("Warning", ex.Message);
				}
				finally
				{
					UpdateStatusBar("");
				}
			}
		}


		/// <summary>
		/// Upload a directory and its file contents
		/// </summary>
		/// <param name="path"></param>
		/// <param name="recurse">Whether to recurse sub directories</param>
		private void UploadDirectory(string path, bool recurse)
		{
			try
			{
				if (ftpClient != null)
				{
					UpdateStatusBar("Uploading....");
					this.Cursor = Cursors.WaitCursor;
					ftpClient.UploadDirectory(path, recurse);
				}
			}
			catch (FtpClient.FtpException ex)
			{
				Warning("", ex.Message);
			}
			catch (Exception ex)
			{
				Warning("Warning", ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				UpdateStatusBar("");
			}
		}

		/// <summary>
		/// Upload a file and set the resume flag.
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="resume"></param>
		private void UploadFile(string fileName, bool resume)
		{
			try
			{
				if (ftpClient != null)
				{
					resume = false;
					UpdateStatusBar("Uploading....");
					this.Cursor = Cursors.WaitCursor;
					ftpClient.Upload(fileName, resume);
				}
			}
			catch (FtpClient.FtpException ex)
			{
				Warning("", ex.Message);
			}
			catch (Exception ex)
			{
				Warning("Warning", ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				UpdateStatusBar("");
			}
		}

		/// <summary>
		/// Download a remote file to a local file name which can include
		/// a path, and set the resume flag. The local file name will be
		/// created or overwritten, but the path must exist.
		/// </summary>
		/// <param name="remFileName"></param>
		/// <param name="locFileName"></param>
		/// <param name="resume"></param>
		public void DownloadFile(string remFileName,string locFileName,Boolean resume)
		{
			try
			{
				if (ftpClient != null)
				{
					resume = false;
					UpdateStatusBar("Downloading....");
					this.Cursor = Cursors.WaitCursor;
					ftpClient.Download(remFileName, locFileName, resume);
				}
			}
			catch (FtpClient.FtpException ex)
			{
				Warning("", ex.Message);
			}
			catch (Exception ex)
			{
				Warning("Warning", ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				UpdateStatusBar("");
			}

		}

		/// <summary>
		/// Rename a local file.
		/// </summary>
		/// <param name="oldFileName"></param>
		private void RenameLocalFile(string oldFileName)
		{
			string newFileName; 

			frmRenameFile frm = new frmRenameFile();
			if ((newFileName = frm.ShowModal(oldFileName)) != oldFileName)
			{
				try
				{
					File.Move(sLocalPath + "\\" + oldFileName, sLocalPath + "\\" + newFileName);
				}
				catch (Exception ex)
				{
					Warning("", ex.Message);
				}
			
			}
		}

		/// <summary>
		/// Delete a local file.
		/// </summary>
		/// <param name="fileName"></param>
		private void DeleteLocalFile(string fileName)
		{
			DialogResult dlgr = MessageBox.Show("Are you sure to delete '" + fileName + "'?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ;
			if (dlgr == DialogResult.Yes)
			{
				try
				{
					this.Cursor = Cursors.WaitCursor;
					UpdateStatusBar("Deleting....");
					File.Delete(sLocalPath + "\\" + fileName);
					
				}
				catch (Exception ex)
				{
					Warning("Warning", ex.Message);
				}
				finally
				{
					this.Cursor = Cursors.Default;
					UpdateStatusBar("");
				}
			}
		}



#endregion


#region Utility

		/// <summary>
		/// write a message in the status bar
		/// </summary>
		/// <param name="message"></param>
		private void UpdateStatusBar(string message)
		{
			statusBar1.Panels[0].Text = message;
		}


		/// <summary>
		/// parse dos file data
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private ListViewItem parseDosData(string text)
		{
			int imageindex = INDEX_TAG_FILE; //default file (1)

			string[] lvData =  new string[4];

			try
			{
				//12-29-02  11:41PM <DIR> Apps
				//01-34-67--01-3456
				string month, day, year;
				string[] test = text.Split(Convert.ToChar(" "));
				if(test.Length < 6)
					throw new ApplicationException();
				string parse = text;
				month = parse.Substring(0, 2);
				day = parse.Substring(3, 2);
				year = parse.Substring(6, 2);
				string hour = parse.Substring(10, 2);
				string min = parse.Substring(13, 2);
				string tod = parse.Substring(15, 2);
				parse = parse.Substring(17);
				long size = 0;

				while(parse.StartsWith(" "))
					parse = parse.Substring(1);
				if(parse.StartsWith("<DIR>"))
				{
					imageindex = INDEX_TAG_DIR;
					size = 0;
					parse = parse.Substring(5);
					while(parse.StartsWith(" "))
						parse = parse.Substring(1);
				}
				else
				{
					size = long.Parse(parse.Split(char.Parse(" "))[0]);
					parse = parse.Substring(parse.Split(char.Parse(" "))[0].Length);
				}
				string filename = parse;
					
				// I use a treshold to set year
				if (Convert.ToInt16(year) < 70)
					year = "20" + year;
				else
					year = "19" + year;

				int hr = int.Parse(hour);
				if(tod.ToUpper()== "PM")
				{
					if(hr != 12) 
						hr+=12;
					else
						if(hr == 12)
						hr = 0;
				}
				DateTime dt = DateTime.Parse(month + " " + day + " " + year, new System.Globalization.CultureInfo("en-US"));
				dt = new DateTime(dt.Year, dt.Month, dt.Day, hr, int.Parse(min), 0);		

				lvData[0] = "";
				lvData[1] = filename.Trim();
				lvData[2] = formatSize( size );
				lvData[3] = Convert.ToString( dt );

			}
			catch
			{
				return null;
			}


			//Create actual list item
			ListViewItem lvItem = new ListViewItem(lvData,imageindex);
			return lvItem;

		}


		/// <summary>
		/// parse unix file data
		/// </summary>
		/// <param name="text"></param>
		/// <returns></returns>
		private ListViewItem parseUnixData(string text)
		{
			int imageindex = INDEX_TAG_FILE; //default file (1)

			string[] lvData =  new string[4];

			string originalText = text;

			if(text == null)
				throw new ArgumentNullException("text");

			try
			{
				bool ufnisDir = false;
				bool ufnisLink = false;
				int inode, year;
				string month, day;
				string ufnext = "";
				
				if((text.Split(char.Parse(" "))).Length < 9)
					throw new ApplicationException();

				// remove link reference
				if (text.IndexOf("->")>= 0) 				
					text = text.Remove(text.IndexOf("->"), text.Length - text.IndexOf("->"));
				
				text = text.Trim();

				// remove multiple space char
				{
					string strtemp = "";
					int kk;

					for (kk=0; kk< text.Length-1; kk++)
					{
						if ((text[kk] != text[kk+1]) || (text[kk] != ' '))
							strtemp += text[kk];
					}
					strtemp += text[kk];

					text = strtemp;
				}

				string[] test = text.Split(char.Parse(" "));
				string[] nfo = new string[9];

				if (test.Length < 9)
				{
					int kk;
					for(kk =0; kk<3; kk++)
						nfo[kk] = test[kk];
					nfo[kk] = "";
					for( ; kk< test.Length; kk++)
						nfo[kk+1] = test[kk];
				}
				else
				{
					int i;
					for (i=0; i < nfo.Length; i++)
						nfo[i] = test[i];

					if (test.Length > 9)
					{
						for (i=9; i<test.Length; i++)
							nfo[8] += ' ' + test[i];
					}
				}

				string ufnpermissions = nfo[0];
				if(ufnpermissions.Length != 10)
					throw new ApplicationException();				
				
				if(ufnpermissions.StartsWith("d")) 
					ufnisDir = true;
				else if(ufnpermissions.StartsWith("l"))
				{
					ufnisDir = true;
					ufnisLink = true;
				}
				else 
				{
					ufnisDir = false;
					ufnisLink = false;
					if(text.IndexOf(".") >= 0)
						ufnext = text.Substring(text.IndexOf("."));
				}

				inode = int.Parse(nfo[1]);
				string ufnowner = nfo[2];
				string ufngroup = nfo[3];
				long ufnsize;

				if (ufnisDir)
				{
					ufnsize = 0;
					if (ufnisLink)
						imageindex = INDEX_TAG_LINK;
					else
						imageindex = INDEX_TAG_DIR;
				}
				else 
					ufnsize = long.Parse(nfo[4]); 
				
				month = nfo[5];
				day = nfo[6];
				int hour = 0;
				int minute = 0;
				if(nfo[7].IndexOf(":") == -1) 
					year = int.Parse(nfo[7]);
				else //file made in last 6 months
				{
					year = DateTime.Now.Year;
					hour = int.Parse(nfo[7].Substring(0, nfo[7].IndexOf(":")));
					minute = int.Parse(nfo[7].Substring(nfo[7].IndexOf(":") + 1));
				}
				string ufnfilename = nfo[8]; 

				
				DateTime ufndt = DateTime.Parse(month + " " + day + " " + year, new System.Globalization.CultureInfo("en-US"));
				if(ufndt.Month > DateTime.Now.Month) --year;
				ufndt = new DateTime(year, ufndt.Month, ufndt.Day, hour, minute, 0);		

				
				lvData[0] = "";
				lvData[1] = ufnfilename.Trim();
				lvData[2] = formatSize( ufnsize );
				lvData[3] = Convert.ToString( ufndt );


			}
			catch
			{
				return null;
			}


			//Create actual list item
			ListViewItem lvItem = new ListViewItem(lvData,imageindex);

			return lvItem;

		}


		/// <summary>
		/// Add an item representing parent directory
		/// </summary>
		/// <param name="lvF"></param>
		private void addParentDirectory(ListView lvF)
		{
			string[] lvData =  new string[4];
			int imageindex = 0; //directory

			lvData[0] = "";
			lvData[1] = "..";
			lvData[2] = "";
			lvData[3] = "";
			//Create actual list item
			ListViewItem lvItem = new ListViewItem(lvData,imageindex);
			lvF.Items.Add(lvItem);
		}

		/// <summary>
		/// returning directory name
		/// </summary>
		/// <param name="stringPath"></param>
		protected string GetPathName(string stringPath)
		{
			//Get Name of folder
			string[] stringSplit = stringPath.Split('\\');
			int _maxIndex = stringSplit.Length;
			return stringSplit[_maxIndex-1];
		}


		/// <summary>
		/// formatting date
		/// </summary>
		/// <param name="dtDate"></param>
		protected string formatDate(DateTime dtDate)
		{
			//Get date and time in short format
			string stringDate = "";

			stringDate = dtDate.ToShortDateString().ToString() + " " + dtDate.ToShortTimeString().ToString();

			return stringDate;
		}

		/// <summary>
		/// formatting size
		/// </summary>
		/// <param name="lSize"></param>
		protected string formatSize(Int64 lSize)
		{
			//Format number to KB
			string stringSize = "";
			NumberFormatInfo myNfi = new NumberFormatInfo();

			Int64 lKBSize = 0;

			if (lSize < 1024 ) 
			{
				if (lSize == 0) 
				{
					//zero byte
					stringSize = "0";
				}
				else 
				{
					//less than 1K but not zero byte
					stringSize = "1";
				}
			}
			else 
			{
				//convert to KB
				lKBSize = lSize / 1024;
				//format number with default format
				stringSize = lKBSize.ToString("n",myNfi);
				//remove decimal
				stringSize = stringSize.Replace(".00", "");
			}

			return stringSize + " KB";
		}

		/// <summary>
		/// Show warning message box
		/// </summary>
		/// <param name="caption"></param>
		/// <param name="message"></param>
		private void Warning(string caption, string message)
		{
			if (caption == "")
				caption = "Warning";
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

#endregion

#region Control's events
		private void btnPrevConnect_Click(object sender, System.EventArgs e)
		{
			// show previous connections
			frmConnections fConnections = new frmConnections();
			
			if ((DialogResult)fConnections.ShowDialog(connectionlist) == DialogResult.OK)
			{
				connectiondata conndata;

				conndata = connectionlist.Item(fConnections.iitemSelected);
				txtAddress.Text = conndata.address;
				txtUsername.Text = conndata.username;
				txtPwd.Text = conndata.password;
				txtPort.Text = conndata.port;
				checkBox1.Checked = conndata.anonymous;

				conndata = null;
				
			}
			
			fConnections = null;

		}


		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
		
			if (((CheckBox)sender).Checked)
			{
				this.txtUsername.Text = "anonymous";
				this.txtPwd.Text = "anonymous@guest.com";
			}
			else
			{
				this.txtUsername.Text = "";
				this.txtPwd.Text = "";
			}
		}

		private void txtPath_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar == 0xd) && (ftpClient !=null))
			{
				ChangeDir(txtPath.Text);
			}
		}

		// set local path variable
		private void txtLocalPath_TextChanged(object sender, System.EventArgs e)
		{
			sLocalPath = ((TextBox)sender).Text.Trim();
		}

		// set remote path variable
		private void txtPath_TextChanged(object sender, System.EventArgs e)
		{
			sRemotePath = ((TextBox)sender).Text.Trim();
		}


		
		private void lvFiles_DoubleClick(object sender, System.EventArgs e)
		{
			ListView.SelectedIndexCollection selIndex = lvFiles.SelectedIndices;
			int i = selIndex[0];

			if ( (i >= 0) && ((lvFiles.Items[i].ImageIndex == INDEX_TAG_DIR) || (lvFiles.Items[i].ImageIndex == INDEX_TAG_LINK)))
			{
				ChangeDir(lvFiles.Items[i].SubItems[1].Text);
			}
		}

		private void lvLocalFiles_DoubleClick(object sender, System.EventArgs e)
		{
			ListView.SelectedIndexCollection selIndex = lvLocalFiles.SelectedIndices;
			int i = selIndex[0];

			if ( (i >= 0) && (lvLocalFiles.Items[i].ImageIndex == INDEX_TAG_DIR))
			{
				ChangeLocalDir(lvLocalFiles.Items[i].SubItems[1].Text);
			}
		}

		private void txtLocalPath_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 0xd)
			{
				ChangeLocalDir("");
			}
		}

		
		
		private void splitter1_SplitterMoving(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			lstMessages.Height = e.Y - lstMessages.Top;
			lstMessages.Invalidate();
			lstMessages.Update();
		}


		private void splitter2_SplitterMoving(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			localPanel.Width = e.X - localPanel.Left;
			splitter2.Invalidate();
			remotePanel.Invalidate(true);
			localPanel.Invalidate(true);
			splitter2.Update();
			localPanel.Update();
			remotePanel.Update();
		}


		private void lvFiles_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			// For the moment I use only column 1 (name) to sort list view
			if (e.Column != 1)
				return;

			// Determine if clicked column is already the column that is being sorted.
			if ( e.Column == lvwColumnSorter.SortColumn )
			{
				// Reverse the current sort direction for this column.
				if (lvwColumnSorter.Order == SortOrder.Ascending)
				{
					lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				// Set the column number that is to be sorted; default to ascending.
				lvwColumnSorter.SortColumn = e.Column;
				lvwColumnSorter.Order = SortOrder.Ascending;
			}

			// Perform the sort with these new sort options.
			this.lvFiles.Sort();
		
		}

		private void lvLocalFiles_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			// For the moment I use only column 1 (name) to sort list view
			if (e.Column != 1)
				return;

			// Determine if clicked column is already the column that is being sorted.
			if ( e.Column == lvwLocalColumnSorter.SortColumn )
			{
				// Reverse the current sort direction for this column.
				if (lvwLocalColumnSorter.Order == SortOrder.Ascending)
				{
					lvwLocalColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					lvwLocalColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				// Set the column number that is to be sorted; default to ascending.
				lvwLocalColumnSorter.SortColumn = e.Column;
				lvwLocalColumnSorter.Order = SortOrder.Ascending;
			}

			// Perform the sort with these new sort options.
			this.lvLocalFiles.Sort();
		
		}

		// remote filelist 
		private void lvFiles_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			ListViewItem lvItem;
			ListView lv = (ListView)sender;

			if (e.KeyCode == Keys.F5)
			{
				// refresh list
				GetFileList("");
			}
			else
			{
				// to rename or delete a file
				// at least one item must be select
				if (lv.SelectedIndices.Count > 0)
				{
					// listview is not multi select
					// then there is only 1 item selected.
					// This is the item selected
					lvItem = lv.SelectedItems[0];

					switch(e.KeyCode)
					{
						case Keys.Delete:
							// here the code to delete a file
							if (lvItem.ImageIndex == INDEX_TAG_FILE)
							{
								DeleteFile(lvItem.SubItems[1].Text);
								GetFileList("");
							}
							// here put code to delete directory
							break;

						case Keys.F2: 
							// rename file
							if (lvItem.ImageIndex == INDEX_TAG_FILE)
							{
								RenameFile(lvItem.SubItems[1].Text);
								GetFileList("");
							}
							// here put code to rename directory
							break;

					}
				
				}
			}
		}

		// local filelist
		private void lvLocalFiles_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			ListViewItem lvItem;
			ListView lv = (ListView)sender;

			if (e.KeyCode == Keys.F5)
			{
				// refresh list
				PopulateLocalFileList();
			}
			else
			{
				// to delete or rename a file
				// at least one item must be select
				if (lv.SelectedIndices.Count > 0)
				{
					// listview is not multi select
					// then there is only 1 item selected.
					// This is the item selected
					lvItem = lv.SelectedItems[0];

					switch(e.KeyCode)
					{
						case Keys.Delete:
							// here the code to delete a file
							if (lvItem.ImageIndex == INDEX_TAG_FILE)
							{
								DeleteLocalFile(lvItem.SubItems[1].Text);
								PopulateLocalFileList();
							}
							// here put code to delete directory
							break;

						case Keys.F2: 
							// rename file
							if (lvItem.ImageIndex == INDEX_TAG_FILE)
							{
								RenameLocalFile(lvItem.SubItems[1].Text);
								PopulateLocalFileList();
							}
							// here put code to rename directory
							break;

					}
				
				}
			}
		}


#endregion

		#region Remote list view dragging events

		private void lvFiles_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			int i = ((ListView)sender).SelectedIndices[0];
			ListViewItem lvItem = ((ListView)sender).Items[i];
			int imgindex = lvItem.ImageIndex;

			// try to drag a file
			if (lvItem.ImageIndex != INDEX_TAG_DIR)
			{
				Bitmap bmp = (Bitmap)imageList1.Images[imgindex];

				lvDragItem = lvItem;
				CurrentEffect = DragDropEffects.Copy;
				startingFrom = ((ListView)sender).Name;

				this.DoDragDrop(bmp, CurrentEffect);
			}

		}

		private void lvFiles_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if ((CurrentEffect == DragDropEffects.Copy) && (((ListView)sender).Name != startingFrom))
			{
				if (lvDragItem.ImageIndex == INDEX_TAG_FILE)
					UploadFile(sLocalPath+ (sLocalPath.EndsWith("\\")?"":"\\")+lvDragItem.SubItems[1].Text, false);
				else if (lvDragItem.ImageIndex == INDEX_TAG_DIR)
					UploadDirectory(sLocalPath+ (sLocalPath.EndsWith("\\")?"":"\\")+lvDragItem.SubItems[1].Text, true);
				GetFileList("");
			}
		
		}

		private void lvFiles_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = CurrentEffect;

		}

		private void lvFiles_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = CurrentEffect;
		
		}
		#endregion

		#region Local listview dragging events

		private void lvLocalFiles_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if ((CurrentEffect == DragDropEffects.Copy) && (((ListView)sender).Name != startingFrom))
			{
				//MessageBox.Show("download: " + lvDragItem.SubItems[1].Text);
				DownloadFile( sRemotePath + (sRemotePath.EndsWith("/")?"":"/") + lvDragItem.SubItems[1].Text, sLocalPath+ (sLocalPath.EndsWith("\\")?"":"\\")+lvDragItem.SubItems[1].Text ,false);
				PopulateLocalFileList();
			}
		
		}

		private void lvLocalFiles_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = CurrentEffect;
		
		}

		private void lvLocalFiles_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			int i = ((ListView)sender).SelectedIndices[0];
			ListViewItem lvItem = ((ListView)sender).Items[i];
			int imgindex = lvItem.ImageIndex;

			// try to drag a file
//			if (lvItem.ImageIndex != INDEX_TAG_DIR)
			{
				Bitmap bmp = (Bitmap)imageList1.Images[imgindex];

				lvDragItem = lvItem;
				CurrentEffect = DragDropEffects.Copy;

				startingFrom = ((ListView)sender).Name;
				this.DoDragDrop(bmp, CurrentEffect);
			}
		
		}

		private void lvLocalFiles_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = CurrentEffect;
		}
		#endregion


		// save connection to file
		public void ConnectionSerialize()
		{
			System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			System.IO.Stream stream = new System.IO.FileStream(binFname, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None);

			connectiondata conndata;
			int i;

			for (i = 0; i< connectionlist.ItemCount(); i++)
			{
				conndata = connectionlist.Item(i);
				formatter.Serialize(stream, conndata);
				conndata = null;
			}
			stream.Close();

		}

		// load connection from file
		public void ConnectionDeserialize()
		{
			System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			System.IO.Stream fromstream = new System.IO.FileStream(binFname, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read, System.IO.FileShare.Read);
			connectiondata obj;
			Boolean endofstream = false;

			while (! endofstream)
			{
				try
				{
					obj = (connectiondata) formatter.Deserialize(fromstream);
					connectionlist.AddItem(obj);

				}
				catch
				{
					endofstream = true;
				}
			}


			fromstream.Close();

		}

		#region Context Menu Remote
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			// refresh
			GetFileList("");
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			// rename
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuRemote.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];
				RenameFile(lvItem.SubItems[1].Text);
				GetFileList("");
				
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			// delete
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuRemote.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];
				if (lvItem.ImageIndex == INDEX_TAG_FILE)
				{
					DeleteFile(lvItem.SubItems[1].Text);
					GetFileList("");
				}
				
			}
		}


		private void contextMenuRemote_Popup(object sender, System.EventArgs e)
		{
			//
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuRemote.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];

				menuItem2.Enabled = true;
				if (lvItem.ImageIndex != INDEX_TAG_FILE)
				{
					menuItem3.Enabled = false;
					if (lvItem.SubItems[1].Text == "..")
						menuItem2.Enabled = false;
				}
				else
					menuItem3.Enabled = true;
			}
			else
			{
				menuItem3.Enabled = false;
				menuItem2.Enabled = false;
			}
		}


		#endregion

		#region Context Menu Local

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			// refresh
			PopulateLocalFileList();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			// rename
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuLocal.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];

				RenameLocalFile(lvItem.SubItems[1].Text);
				PopulateLocalFileList();
			}
		
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			// delete
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuLocal.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];
		
				if (lvItem.ImageIndex == INDEX_TAG_FILE)
				{
					DeleteLocalFile(lvItem.SubItems[1].Text);
					PopulateLocalFileList();
				}
			}

		}


		private void contextMenuLocal_Popup(object sender, System.EventArgs e)
		{
			// we can delete only files
			ListViewItem lvItem;
			ListView lv = (ListView)(contextMenuLocal.SourceControl);

			if (lv.SelectedIndices.Count > 0)
			{
				lvItem = lv.SelectedItems[0];
		
				menuItem5.Enabled = true;
				if (lvItem.ImageIndex != INDEX_TAG_FILE)
				{
					menuItem6.Enabled = false;
					if (lvItem.SubItems[1].Text == "..")
						menuItem5.Enabled = false;
				}
				else
					menuItem6.Enabled = true;
			}
			else
			{
				menuItem6.Enabled = false;
				menuItem5.Enabled = false;
			}
		
		}


		#endregion


	}
}
