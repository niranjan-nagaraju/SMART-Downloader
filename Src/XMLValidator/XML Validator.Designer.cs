namespace SmartDownloader.Xml
{
    partial class XMLValidatorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XMLValidatorForm));
            this.xmlSourceBox = new System.Windows.Forms.TextBox();
            this.DocContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaSourceBox = new System.Windows.Forms.TextBox();
            this.SchemaContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.validatebutton = new System.Windows.Forms.Button();
            this.xmlDocLabel = new System.Windows.Forms.Label();
            this.schemaLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.XMLValidatorMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocContextMenu.SuspendLayout();
            this.SchemaContextMenu.SuspendLayout();
            this.XMLValidatorMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // xmlSourceBox
            // 
            this.xmlSourceBox.BackColor = System.Drawing.Color.Azure;
            this.xmlSourceBox.ContextMenuStrip = this.DocContextMenu;
            this.xmlSourceBox.Location = new System.Drawing.Point(12, 65);
            this.xmlSourceBox.Multiline = true;
            this.xmlSourceBox.Name = "xmlSourceBox";
            this.xmlSourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.xmlSourceBox.Size = new System.Drawing.Size(372, 330);
            this.xmlSourceBox.TabIndex = 0;
            // 
            // DocContextMenu
            // 
            this.DocContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDocumentToolStripMenuItem});
            this.DocContextMenu.Name = "DocContextMenu";
            this.DocContextMenu.Size = new System.Drawing.Size(160, 26);
            // 
            // loadDocumentToolStripMenuItem
            // 
            this.loadDocumentToolStripMenuItem.Name = "loadDocumentToolStripMenuItem";
            this.loadDocumentToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.loadDocumentToolStripMenuItem.Text = "&Load Document";
            this.loadDocumentToolStripMenuItem.Click += new System.EventHandler(this.loadDocumentToolStripMenuItem_Click);
            // 
            // schemaSourceBox
            // 
            this.schemaSourceBox.BackColor = System.Drawing.Color.Azure;
            this.schemaSourceBox.ContextMenuStrip = this.SchemaContextMenu;
            this.schemaSourceBox.Location = new System.Drawing.Point(403, 65);
            this.schemaSourceBox.Multiline = true;
            this.schemaSourceBox.Name = "schemaSourceBox";
            this.schemaSourceBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.schemaSourceBox.Size = new System.Drawing.Size(379, 330);
            this.schemaSourceBox.TabIndex = 1;
            // 
            // SchemaContextMenu
            // 
            this.SchemaContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSchemaToolStripMenuItem});
            this.SchemaContextMenu.Name = "SchemaContextMenu";
            this.SchemaContextMenu.Size = new System.Drawing.Size(149, 26);
            // 
            // loadSchemaToolStripMenuItem
            // 
            this.loadSchemaToolStripMenuItem.Name = "loadSchemaToolStripMenuItem";
            this.loadSchemaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadSchemaToolStripMenuItem.Text = "&Load Schema";
            this.loadSchemaToolStripMenuItem.Click += new System.EventHandler(this.loadSchemaToolStripMenuItem_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.Color.Azure;
            this.resultsBox.Location = new System.Drawing.Point(12, 497);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultsBox.Size = new System.Drawing.Size(770, 154);
            this.resultsBox.TabIndex = 2;
            // 
            // validatebutton
            // 
            this.validatebutton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.validatebutton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validatebutton.ForeColor = System.Drawing.SystemColors.Window;
            this.validatebutton.Location = new System.Drawing.Point(12, 401);
            this.validatebutton.Name = "validatebutton";
            this.validatebutton.Size = new System.Drawing.Size(770, 54);
            this.validatebutton.TabIndex = 3;
            this.validatebutton.Text = "&Validate";
            this.validatebutton.UseVisualStyleBackColor = false;
            this.validatebutton.Click += new System.EventHandler(this.validatebutton_Click);
            // 
            // xmlDocLabel
            // 
            this.xmlDocLabel.AutoSize = true;
            this.xmlDocLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlDocLabel.Location = new System.Drawing.Point(92, 35);
            this.xmlDocLabel.Name = "xmlDocLabel";
            this.xmlDocLabel.Size = new System.Drawing.Size(131, 18);
            this.xmlDocLabel.TabIndex = 4;
            this.xmlDocLabel.Text = "XML Document";
            // 
            // schemaLabel
            // 
            this.schemaLabel.AutoSize = true;
            this.schemaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schemaLabel.Location = new System.Drawing.Point(534, 35);
            this.schemaLabel.Name = "schemaLabel";
            this.schemaLabel.Size = new System.Drawing.Size(112, 18);
            this.schemaLabel.TabIndex = 5;
            this.schemaLabel.Text = "XSD Schema";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(340, 476);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(69, 18);
            this.resultsLabel.TabIndex = 6;
            this.resultsLabel.Text = "Results";
            // 
            // XMLValidatorMenu
            // 
            this.XMLValidatorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.XMLValidatorMenu.Location = new System.Drawing.Point(0, 0);
            this.XMLValidatorMenu.Name = "XMLValidatorMenu";
            this.XMLValidatorMenu.Size = new System.Drawing.Size(801, 24);
            this.XMLValidatorMenu.TabIndex = 7;
            this.XMLValidatorMenu.Text = "XMLValidatorMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLDocumentToolStripMenuItem,
            this.loadXMLSchemaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadXMLDocumentToolStripMenuItem
            // 
            this.loadXMLDocumentToolStripMenuItem.Name = "loadXMLDocumentToolStripMenuItem";
            this.loadXMLDocumentToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadXMLDocumentToolStripMenuItem.Text = "Load XML &Document";
            this.loadXMLDocumentToolStripMenuItem.Click += new System.EventHandler(this.loadXMLDocumentToolStripMenuItem_Click);
            // 
            // loadXMLSchemaToolStripMenuItem
            // 
            this.loadXMLSchemaToolStripMenuItem.Name = "loadXMLSchemaToolStripMenuItem";
            this.loadXMLSchemaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.loadXMLSchemaToolStripMenuItem.Text = "Load XML &Schema";
            this.loadXMLSchemaToolStripMenuItem.Click += new System.EventHandler(this.loadXMLSchemaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validateToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.actionToolStripMenuItem.Text = "&Action";
            // 
            // validateToolStripMenuItem
            // 
            this.validateToolStripMenuItem.Name = "validateToolStripMenuItem";
            this.validateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.validateToolStripMenuItem.Text = "&Validate";
            this.validateToolStripMenuItem.Click += new System.EventHandler(this.validateToolStripMenuItem_Click);
            // 
            // XMLValidatorForm
            // 
            this.AcceptButton = this.validatebutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(801, 663);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.validatebutton);
            this.Controls.Add(this.schemaSourceBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.schemaLabel);
            this.Controls.Add(this.XMLValidatorMenu);
            this.Controls.Add(this.xmlSourceBox);
            this.Controls.Add(this.xmlDocLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.XMLValidatorMenu;
            this.Name = "XMLValidatorForm";
            this.Text = "XML Validator";
            this.DocContextMenu.ResumeLayout(false);
            this.SchemaContextMenu.ResumeLayout(false);
            this.XMLValidatorMenu.ResumeLayout(false);
            this.XMLValidatorMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlSourceBox;
        private System.Windows.Forms.TextBox schemaSourceBox;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Button validatebutton;
        private System.Windows.Forms.Label xmlDocLabel;
        private System.Windows.Forms.Label schemaLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.MenuStrip XMLValidatorMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadXMLSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip DocContextMenu;
        private System.Windows.Forms.ToolStripMenuItem loadDocumentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SchemaContextMenu;
        private System.Windows.Forms.ToolStripMenuItem loadSchemaToolStripMenuItem;
    }
}