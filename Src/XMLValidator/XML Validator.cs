using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Forms;
using System.IO;

namespace SmartDownloader.Xml
{
    public partial class XMLValidatorForm : Form
    {
        private int validationErrors;
        private XmlTextReader xmlReader;
        private XmlTextReader schemaReader;

        public XMLValidatorForm()
        {
            InitializeComponent();
        }

        private void validate()
        {
            //clear Results

            resultsBox.Clear();
            validationErrors = 0;

            //set parsing context and configure readers

            XmlParserContext context = new XmlParserContext(null, new XmlNamespaceManager(new NameTable()), null, XmlSpace.None);

            //Initialize readers using the context

            xmlReader = new XmlTextReader(xmlSourceBox.Text, XmlNodeType.Element, context);
            schemaReader = new XmlTextReader(schemaSourceBox.Text, XmlNodeType.Element, context);

            XmlValidatingReader validator = new XmlValidatingReader(xmlReader);

            //set validation type to use an XSD schema
            validator.ValidationType = ValidationType.Schema;

            //load schema into xmlschemacollection using specified target namespace

            XmlSchemaCollection schemaCollection = new XmlSchemaCollection();

            try
            {
                schemaReader.Read();
                schemaCollection.Add(schemaReader.GetAttribute("targetNamespace"), schemaReader);
            }
            catch (Exception ex)
            {
                //error parsing schema, display error and quit validation

                appendResult("Read/Parser Error: " + ex.Message);
                return;

            }

            //load schema into the validator
            validator.Schemas.Add(schemaCollection);

            //configure validator event handler to handle errors
            validator.ValidationEventHandler += new ValidationEventHandler(validationError);

            try
            {
                while (validator.Read())
                {
                    // parse xml document, calling validationError as required
                }

                //display completion info

                appendResult("Validation Complete. " + validationErrors + "error(s) found.");
            }

            catch (Exception ex)
            {
                //xml document parsing error, display information

                appendResult("Read/Parse Error: " + ex.Message);
            }

            finally
            {
                //close readers
                xmlReader.Close();
                schemaReader.Close();
            }


        }

        private void validatebutton_Click(object sender, EventArgs e)
        {
            this.validate();
        }


        private void appendResult(string newResult)
        {
            //create new string array i line bigger than old one and use
            //new space to add result text

            string[] newLines = new string[resultsBox.Lines.Length + 1];
            resultsBox.Lines.CopyTo(newLines, 0);
            newLines[resultsBox.Lines.Length] = newResult;
            resultsBox.Lines = newLines;
        }


        private void validationError(object sender, ValidationEventArgs args)
        {
            //check error severity
            string severity = "";

            if (args.Severity == XmlSeverityType.Error)
            {
                severity = "Error";
            }

            if (args.Severity == XmlSeverityType.Warning)
            {
                severity = "Warning";
            }

            //display error Information

            appendResult("Validation Error: " + args.Message);
            appendResult("Severity Level: " + severity);

            if (xmlReader.LineNumber > 0)
            {
                appendResult("Line: " + xmlReader.LineNumber + ", Character: " + xmlReader.LinePosition);
            }

            appendResult("");
            validationErrors += 1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getFileContents(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("File Does not Exist", "Error");
            }


            StreamReader sr = File.OpenText(fileName);
            string buf = null;
            buf = sr.ReadToEnd();

            sr.Close();

            return buf;

        }

        private void loadXMLDocument()
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "XML Files(*.xml)|*.xml";
            openDlg.ShowDialog();

            string fileName = openDlg.FileName;

            
            xmlSourceBox.Text = "";
            xmlSourceBox.Text = this.getFileContents(fileName);
            xmlSourceBox.Invalidate();

        }

        private void loadXMLDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadXMLDocument();
        }

        private void loadDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadXMLDocument();
        }


        private void loadXMLSchema()
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "XML Schema(*.xsd)|*.xsd";
            openDlg.ShowDialog();

            string fileName = openDlg.FileName;


            schemaSourceBox.Text = "";
            schemaSourceBox.Text = this.getFileContents(fileName);
            schemaSourceBox.Invalidate();

        }


        private void loadXMLSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadXMLSchema();
        }

        private void loadSchemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadXMLSchema();
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.validate();
        }

    }
}