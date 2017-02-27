using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountLines
{
    public partial class frmKindSetting : Form
    {
        private static frmKindSetting instance=null;

        private  string[] chooseKinds;
        public  string[] ChooseKinds
        {
            get { return chooseKinds; }
        }
        
        private frmKindSetting()
        {
            InitializeComponent();
            Init();
        }
        
        public static frmKindSetting GetInstance()
        {
            if(instance==null)
                instance=new frmKindSetting();
            return instance;
        }
        
        private void Init()
        {
            lstLeft.Items.AddRange(Utility.SplitKind(CountLines.Properties.Settings.Default.kinds));
        }
        
        private void ChooseItem(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            HandleButton(btn);
        }
        
        private void HandleButton(Button btn)
        {
            if (btn.Name == "btnToRight" )
            {
                 if(!lstRight.Items.Contains(lstLeft.SelectedItem))
                     lstRight.Items.Add(lstLeft.SelectedItem);
            }
            else if(btn.Name=="btnToLeft")
                lstRight.Items.Remove(lstRight.SelectedItem);
            else if(btn.Name=="btnAllToRight")
            {
                lstRight.Items.Clear();
                lstRight.Items.AddRange(lstLeft.Items);
            }
            else 
                lstRight.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleCustomKind();
        }
        
        private void HandleCustomKind()
        {
            if(txtKind.Text.Length!=0)
            {
                string kind = Utility.RightFileKindFormat(txtKind.Text);
                if(!lstLeft.Items.Contains(kind))
                {
                    CountLines.Properties.Settings.Default.kinds.Add(kind);
                    lstLeft.Items.Add(kind);
                }   
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CountLines.Properties.Settings.Default.Save();
            chooseKinds = null;
            chooseKinds=new string[lstRight.Items.Count];
            lstRight.Items.CopyTo(chooseKinds,0);
            this.Close();
        }
    }
}