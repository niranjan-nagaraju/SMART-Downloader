using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartDownloader.FTPDownloader
{
	/// <summary>
	/// Summary description for frmConnections.
	/// </summary>
	public class frmConnections : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.Button btnCancel;
		internal System.Windows.Forms.Button btnApply;
		private Boolean blnApply = false;
		private System.Windows.Forms.TreeView treeView1;
		public int iitemSelected;

		public frmConnections()
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo6");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo7");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnections));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(91, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnApply.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnApply.ForeColor = System.Drawing.SystemColors.Window;
            this.btnApply.Location = new System.Drawing.Point(187, 146);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(85, 33);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "&Ok";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Azure;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Nodo3";
            treeNode2.Name = "";
            treeNode2.Text = "Nodo4";
            treeNode3.Name = "";
            treeNode3.Text = "Nodo5";
            treeNode4.Name = "";
            treeNode4.Text = "Nodo6";
            treeNode5.Name = "";
            treeNode5.Text = "Nodo7";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(368, 128);
            this.treeView1.TabIndex = 8;
            // 
            // frmConnections
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(368, 191);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Previous Connections";
            this.ResumeLayout(false);

		}
		#endregion

		public object ShowDialog(connectionlist connlist)
		{
			TreeNode node;
			string sPwd;

			this.TopMost = true;
			

			treeView1.Nodes.Clear();

			for (int i = 0; i< connlist.ItemCount(); i++)
			{
				sPwd = "";
				for (int j =0 ; j < connlist.Item(i).password.Length; j++)
					sPwd += "*"; 
				node = treeView1.Nodes.Add(connlist.Item(i).address);
				
				node.Nodes.Add("Username: " + connlist.Item(i).username);
				node.Nodes.Add("Password: " + sPwd);
				node.Nodes.Add("Port: " + connlist.Item(i).port);
			}

			base.ShowDialog();

			if (blnApply) 
			{
				return DialogResult.OK;
			}
			return DialogResult.Cancel;
		}
	

		#region Button's events

		private void btnApply_Click(object sender, System.EventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;

			if ( node != null)
			{
				if (node.Parent != null)
					node = node.Parent;
				iitemSelected = node.Index;
				blnApply = true;
				this.Close();
			}
			else
				blnApply = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}
		
		#endregion



	}
}
