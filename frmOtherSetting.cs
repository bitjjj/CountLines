using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountLines
{
    public partial class frmOtherSetting : Form
    {
        private static frmOtherSetting instance = null;

        private  bool isBrace = false;

        public  bool IsBrace
        {
            get { return isBrace; }
        }

        private  bool isSpace = false;

        public  bool IsSpace
        {
            get { return isSpace; }
        }
        
        private frmOtherSetting()
        {
            InitializeComponent();
            Init();
        }
  
        private void Init()
        {
            chkBrace.Checked = isBrace;
            chkSpace.Checked = isSpace;
        }
        
        public static frmOtherSetting GetInstace()
        {
            if(instance==null)
                instance=new frmOtherSetting();
            return instance;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            isBrace = chkBrace.Checked;
            isSpace = chkSpace.Checked;
            this.Close();
        }
    }
}