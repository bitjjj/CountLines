using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountLines
{
    public partial class frmFilter : Form
    {
        private static frmFilter instance = null;

        private string lineInclude = "";
        private bool lineRelationAnd = true;
        private string lineExclude = "";

        private string fileInclude = "";
        private bool fileRelationAnd = true;
        private string fileExclude = "";
        
        private frmFilter()
        {
            InitializeComponent();
            Init();
        }

        public string LineInclude
        {
            get { return lineInclude; }
        }

        public bool LineRelationAnd
        {
            get { return lineRelationAnd; }
        }

        public string LineExclude
        {
            get { return lineExclude; }
        }

        public string FileInclude
        {
            get { return fileInclude; }
        }

        public bool FileRelationAnd
        {
            get { return fileRelationAnd; }
        }

        public string FileExclude
        {
            get { return fileExclude; }
        }

        public static frmFilter GetInstace()
        {
            if (instance == null)
                instance = new frmFilter();
            return instance;
        }

        private void Init()
        {
            this.txtLineExclude.Text = lineExclude;
            this.txtLineInclude.Text = lineInclude;
            this.radLineAnd.Checked = lineRelationAnd;
            this.radLineOr.Checked = !lineRelationAnd;

            this.txtFileExclude.Text = fileExclude;
            this.txtFileInclude.Text = fileInclude;
            this.radFileAnd.Checked = fileRelationAnd;
            this.radFileOr.Checked = !fileRelationAnd;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            lineExclude = this.txtLineExclude.Text;
            lineInclude = this.txtLineInclude.Text;
            lineRelationAnd = this.radLineAnd.Checked;

            fileExclude = this.txtFileExclude.Text;
            fileInclude = this.txtFileInclude.Text;
            fileRelationAnd = this.radFileAnd.Checked;

            this.Close();
        }

        private void lnkLineClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtLineExclude.Text = "";
            this.txtLineInclude.Text = "";
            this.radLineAnd.Checked = true;
        }

        private void lnkFileClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtFileExclude.Text = "";
            this.txtFileInclude.Text = "";
            this.radFileAnd.Checked = true;
        }
    }
}
