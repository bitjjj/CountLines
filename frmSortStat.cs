using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CountLines
{
    public partial class frmSortStat : Form
    {
        //private static frmSortStat instance = null;

        public frmSortStat(IDictionary<string, int> sortInfo, IDictionary<string, int> lineInfo)
        {
            InitializeComponent();
            AddFileInfo(sortInfo);
            AddLineInfo(lineInfo);
        }

        private void AddLineInfo(IDictionary<string, int> lineInfo)
        {
            if (lineInfo.Count != 0)
            {
                AddFilterInfo(lineInfo);
                AddCommonLineInfo(lineInfo);
            }
        }

        private void AddFilterInfo(IDictionary<string, int> lineInfo)
        {
            this.lstFilterInfo.Items.Clear();
            long sum = 0;
            sum += lineInfo[Constants.FILTERCONSNUM];
            sum += lineInfo[Constants.NAMESPACENUM];
            if (lineInfo[Constants.ISBRACE] == 0)
                sum += lineInfo[Constants.BRACENUM];
            if (lineInfo[Constants.ISSPACE] == 0)
                sum += lineInfo[Constants.SPACENUM];
            ListViewItem lviFilter = new ListViewItem("过滤条件");
            if(sum <= 0)
            {
                lviFilter.SubItems.Add("0");
                lviFilter.SubItems.Add("0");
            }
            else
            {
                lviFilter.SubItems.Add(lineInfo[Constants.FILTERCONSNUM].ToString());
                lviFilter.SubItems.Add(string.Format("{0:P}",(double)lineInfo[Constants.FILTERCONSNUM]/sum));               
            }
            this.lstFilterInfo.Items.Add(lviFilter);
            ListViewItem lviNamespace = new ListViewItem("命名空间");
            if (sum <= 0)
            {
                lviNamespace.SubItems.Add("0");
                lviNamespace.SubItems.Add("0");
            }
            else
            {
                lviNamespace.SubItems.Add(lineInfo[Constants.NAMESPACENUM].ToString());
                lviNamespace.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.NAMESPACENUM] / sum));
            }
            this.lstFilterInfo.Items.Add(lviNamespace);
            if(lineInfo[Constants.ISBRACE] == 0)
            {
                ListViewItem lviBrace = new ListViewItem("大括号{,}");
                if (sum <= 0)
                {
                    lviBrace.SubItems.Add("0");
                    lviBrace.SubItems.Add("0");
                }
                else
                {
                    lviBrace.SubItems.Add(lineInfo[Constants.BRACENUM].ToString());
                    lviBrace.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.BRACENUM] / sum));
                }
                this.lstFilterInfo.Items.Add(lviBrace);                
            }
            if (lineInfo[Constants.ISSPACE] == 0)
            {
                ListViewItem lviSpace = new ListViewItem("空行");
                if (sum <= 0)
                {
                    lviSpace.SubItems.Add("0");
                    lviSpace.SubItems.Add("0");
                }
                else
                {
                    lviSpace.SubItems.Add(lineInfo[Constants.SPACENUM].ToString());
                    lviSpace.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.SPACENUM] / sum));
                }
                this.lstFilterInfo.Items.Add(lviSpace);
            }

        }

        private void AddCommonLineInfo(IDictionary<string, int> lineInfo)
        {
            this.lstLineInfo.Items.Clear();
            long sum = 0;
            sum += lineInfo[Constants.COMMONNUM];
            if (lineInfo[Constants.ISBRACE] == 1)
                sum += lineInfo[Constants.BRACENUM];
            if (lineInfo[Constants.ISSPACE] == 1)
                sum += lineInfo[Constants.SPACENUM];
            ListViewItem lviCommon = new ListViewItem("正常代码行数");
            if (sum <= 0)
            {
                lviCommon.SubItems.Add("0");
                lviCommon.SubItems.Add("0");
            }
            else
            {
                lviCommon.SubItems.Add(lineInfo[Constants.COMMONNUM].ToString());
                lviCommon.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.COMMONNUM] / sum));
            }
            this.lstLineInfo.Items.Add(lviCommon);
            if (lineInfo[Constants.ISBRACE] == 1)
            {
                ListViewItem lviBrace = new ListViewItem("大括号{,}");
                if (sum <= 0)
                {
                    lviBrace.SubItems.Add("0");
                    lviBrace.SubItems.Add("0");
                }
                else
                {
                    lviBrace.SubItems.Add(lineInfo[Constants.BRACENUM].ToString());
                    lviBrace.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.BRACENUM] / sum));
                }
                this.lstLineInfo.Items.Add(lviBrace);
            }
            if (lineInfo[Constants.ISSPACE] == 1)
            {
                ListViewItem lviSpace = new ListViewItem("空行");
                if (sum <= 0)
                {
                    lviSpace.SubItems.Add("0");
                    lviSpace.SubItems.Add("0");
                }
                else
                {
                    lviSpace.SubItems.Add(lineInfo[Constants.SPACENUM].ToString());
                    lviSpace.SubItems.Add(string.Format("{0:P}", (double)lineInfo[Constants.SPACENUM] / sum));
                }
                this.lstLineInfo.Items.Add(lviSpace);
            }
        }

        private void AddFileInfo(IDictionary<string, int> sortInfo)
        {
            this.lstSortInfo.Items.Clear();
            long sum = 0;
            foreach (int value in sortInfo.Values)
            {
                sum += value;
            }
            foreach (string key in sortInfo.Keys)
            {
                ListViewItem lvi = new ListViewItem(key);
                lvi.SubItems.Add(sortInfo[key].ToString());
                if (sum == 0)
                {
                    lvi.SubItems.Add("0");
                }
                else
                {
                    lvi.SubItems.Add(string.Format("{0:P}",(double)sortInfo[key]/sum));
                }
                this.lstSortInfo.Items.Add(lvi);
            }    
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        //public static frmSortStat GetInstance()
        //{
        //    if (instance == null)
        //        instance = new frmSortStat();
        //    return instance;
        //}
    }
}
