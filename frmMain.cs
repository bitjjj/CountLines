using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CountLines
{
    public partial class frmMain : Form
    {

        private frmKindSetting kindStng = frmKindSetting.GetInstance();

        private frmOtherSetting otherStng = frmOtherSetting.GetInstace();

        private frmFilter filterCondition = frmFilter.GetInstace();

        private delegate void UpdateUI(string path, int lines);

        private delegate void UpdateButton();

        private string filters = null;
        
        private Thread thrd = null;

        private readonly ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();

        private Dictionary<string, int> sortInfo = new Dictionary<string, int>();

        private Dictionary<string, int> lineInfo = new Dictionary<string, int>();

        private FilterLineCons filterLineCondition;

        private FilterFileCons filterFileCondition;

        private bool isSpace = false;

        private bool isBrace = false;
   
        public frmMain()
        {
            InitializeComponent();
            initUIDate();
            //InitLineInfo();
        }

        private void initUIDate()
        {
            this.lstDetails.ListViewItemSorter = this.lvwColumnSorter;
        }


        #region 处理文件夹或者文件的路径，并显示出来
        private void OpenDlg(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            ShowPath(btn);
            if (cmbFilesAndFolders.Items.Count != 0)
            {
                cmbFilesAndFolders.SelectedIndex = 0;
            }
        }

        private void ShowPath(Button btn)
        {
            if (btn.Text == "打开文件")
            {
                DialogResult dlgRsl = openFileDlg.ShowDialog();
                if (dlgRsl == DialogResult.OK)
                {
                    foreach (string fileName in openFileDlg.FileNames)
                    {
                        cmbFilesAndFolders.Items.Add(fileName);
                    }
                }
            }
            else
            {
                DialogResult dlgRsl = folderBrowserDlg.ShowDialog();
                if (dlgRsl == DialogResult.OK)
                {
                    cmbFilesAndFolders.Items.Add(folderBrowserDlg.SelectedPath);
                }
            }
        }
        #endregion

        #region 设置操作 
        private void ToolStripMenuItemChooseFile_Click(object sender, EventArgs e)
        {          
            kindStng.ShowDialog();
        }

        private void ToolStripMenuItemother_Click(object sender, EventArgs e)
        {
           
            otherStng.ShowDialog();
        }

        private void ToolStripMenuItemKind_Click(object sender, EventArgs e)
        {
            HandleCommonNum();
            frmSortStat sortDlg = new frmSortStat(sortInfo,lineInfo);
            sortDlg.ShowDialog();
        }

        private void HandleCommonNum()
        {
            if (lineInfo.Count != 0)
            {
                if (this.isBrace)
                {
                    lineInfo[Constants.COMMONNUM] -= lineInfo[Constants.BRACENUM];
                    lineInfo[Constants.ISBRACE] = 1;
                }
                if (this.isSpace)
                {
                    lineInfo[Constants.COMMONNUM] -= lineInfo[Constants.SPACENUM];
                    lineInfo[Constants.ISSPACE] = 1;
                }
            }
        }

        private void ToolStripMenuItemFilter_Click(object sender, EventArgs e)
        {
            filterCondition.ShowDialog();
        }
        #endregion

        #region 统计的过程
        private void btnStart_Click(object sender, EventArgs e)
        {
            ClearThisInfo();
            BeginCount();        
        }

        private void ClearThisInfo()
        {
            this.lstDetails.Items.Clear();
            this.lblThisFiles.Text = "0";
            this.lblThisLines.Text = "0";
            this.isBrace = otherStng.IsBrace;
            this.isSpace = otherStng.IsSpace;
        }
        
        /// <summary>
        /// 设置要统计的文件类型，异步统计文件
        /// </summary>
        private void BeginCount()
        {
            if (cmbFilesAndFolders.Items.Count != 0)
            {
                UpdateBtnEnabled();
                List<string> items = new List<string>();
                foreach (string item in cmbFilesAndFolders.Items)
                {
                    items.Add(item);
                }
                HandleFilters();
                InitFilterCondition();
                InitLineInfo();
                thrd = new Thread(BeginCountFiles);
                thrd.Start(items);
            }
        }
        
        /// <summary>
        /// 设置要统计的文件类型
        /// </summary>
        private void HandleFilters()
        {
            StringBuilder sbFilters=new StringBuilder();
            if (kindStng.ChooseKinds!=null)
            {
                foreach (string filter in kindStng.ChooseKinds)
                {
                    sbFilters.Append('*');
                    sbFilters.Append(filter);
                    sbFilters.Append(';');
                }
                sbFilters.Remove(sbFilters.Length - 1, 1);
                filters = sbFilters.ToString();
            }
            else
                filters = "*.c;*.cpp;*.cs;*.java";
            sortInfo.Clear();
            foreach (string type in filters.Split(new char[] { ';' }))
            {
                sortInfo.Add(type, 0);
            }

        }
        
        /// <summary>
        /// 开始统计文件或者文件夹
        /// </summary>
        /// <param name="fileItems">要统计的文件和文件的集合</param>
        private void BeginCountFiles(object fileItems)
        {
            List<string> items = (List<string>)fileItems;
            foreach (string item in items)
            {
                RecurseCountFiles(item);
            }
            this.Invoke(new UpdateButton(UpdateBtnEnabled));
        }
        
        /// <summary>
        /// 递归统计文件夹内的文件，直接计算单个文件的行数
        /// </summary>
        /// <param name="path">文件或者文件夹路径</param>
        private void RecurseCountFiles(string path)
        {

            string ext = Path.GetExtension(path),ext2;

            if (File.Exists(path) && filters.Contains(ext) 
                && (Utility.FilterFile(new string[]{path},filterFileCondition )).Length!=0)
            {
                int lines = Utility.CountFileLines(path,filterLineCondition,lineInfo);
                ext2="*"+ext;
                sortInfo[ext2] += lines;
                this.Invoke(new UpdateUI(UpdatePathAndLine), path, lines);
                return;
            }
            if (Directory.Exists(path))
            {
                string[] files = Utility.GetFilterFiles(path, filterFileCondition);
                foreach (string file in files)
                {
                    ext = Path.GetExtension(file);
                    ext2 = "*" + ext;
                    int lines = Utility.CountFileLines(file, filterLineCondition, lineInfo);
                    sortInfo[ext2] += lines;
                    this.Invoke(new UpdateUI(UpdatePathAndLine), file, lines);
                }
                try
                {
                    string[] folders = Directory.GetDirectories(path);
                    foreach (string folder in folders)
                    {
                        RecurseCountFiles(folder);
                    }
                }
                catch (UnauthorizedAccessException e)
                {
                    return;
                }
                
            }

        }

        private void InitFilterCondition()
        {
            filterLineCondition=new FilterLineCons();
            filterLineCondition.IsBrace = otherStng.IsBrace;
            filterLineCondition.IsSpace = otherStng.IsSpace;
            filterLineCondition.RelationAnd = filterCondition.LineRelationAnd;
            filterLineCondition.IncludeStr = filterCondition.LineInclude;
            filterLineCondition.ExcludeStr = filterCondition.LineExclude;

            filterFileCondition=new FilterFileCons();
            filterFileCondition.Filters = filters;
            filterFileCondition.RelationAnd = filterCondition.FileRelationAnd;
            filterFileCondition.IncludeStr = filterCondition.FileInclude;
            filterFileCondition.ExcludeStr = filterCondition.FileExclude;

        }

        private void InitLineInfo()
        {
            lineInfo.Clear();
            lineInfo.Add(Constants.ALLNUM, 0);
            lineInfo.Add(Constants.BRACENUM, 0);
            lineInfo.Add(Constants.COMMONNUM, 0);
            lineInfo.Add(Constants.FILTERCONSNUM, 0);
            lineInfo.Add(Constants.ISBRACE, 0);
            lineInfo.Add(Constants.ISSPACE, 0);
            lineInfo.Add(Constants.SPACENUM, 0);
            lineInfo.Add(Constants.NAMESPACENUM, 0);
        }

        #endregion
        

        #region 更新用户界面
        /// <summary>
        /// 更新代码统计信息
        /// </summary>
        /// <param name="path">文件的路径信息</param>
        /// <param name="lines">文件的行数</param>
        private void UpdatePathAndLine(string path,int lines)
        {
            lblFile.Text = path;
            UpdateStatData(lines, 1);
            ListViewItem lvi=new ListViewItem(path);
            lvi.ToolTipText = path;
            lvi.SubItems.Add(lines.ToString());
            lvi.SubItems.Add(Path.GetExtension(path)+"文件");
            lstDetails.Items.Add(lvi);
        }

        /// <summary>
        /// 改变行数和文件数的值
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="files"></param>
        private void UpdateStatData(int lines, int files)
        {
            if (int.Parse(lblLines.Text) + lines >= 0)
            {
                lblLines.Text = (int.Parse(lblLines.Text) + lines).ToString();
            }
            else
            {
                lblLines.Text = "0";
            }
            if (int.Parse(lblFiles.Text) + files >= 0)
            {
                lblFiles.Text = (int.Parse(lblFiles.Text) + files).ToString();
            }
            else
            {
                lblFiles.Text = "0";
            }

            if (int.Parse(lblThisLines.Text) + lines >= 0)
            {
                lblThisLines.Text = (int.Parse(lblThisLines.Text) + lines).ToString();
            }
            else
            {
                lblThisLines.Text = "0";
            }
            if (int.Parse(lblThisFiles.Text) + files >= 0)
            {
                lblThisFiles.Text = (int.Parse(lblThisFiles.Text) + files).ToString();
            }
            else
            {
                lblThisFiles.Text = "0";
            } 
        }

        /// <summary>
        /// 设置界面按钮状态
        /// </summary>
        private void UpdateBtnEnabled()
        {
            btnLinesClear.Enabled = !btnLinesClear.Enabled;
            btnFilesClear.Enabled = !btnFilesClear.Enabled;
            btnThisLinesClear.Enabled = !btnThisLinesClear.Enabled;
            btnThisFilesClear.Enabled = !btnThisFilesClear.Enabled;
            btnStart.Enabled = !btnStart.Enabled;
        }
        #endregion

        #region 右键处理
        private void ToolStripMenuItemCOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(lstDetails.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
            }
            
        }

        private void ToolStripMenuItemCClear_Click(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        private void ToolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
        }

        /// <summary>
        /// 删除选中的文件，并且更新行数和文件数的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemCDelFile_Click(object sender, EventArgs e)
        {
            if (lstDetails.SelectedItems.Count != 0)
            {
                int selectCount = lstDetails.SelectedIndices.Count;
                ListView.SelectedIndexCollection indexCollection = lstDetails.SelectedIndices;
                ListView.SelectedListViewItemCollection itemCollection = lstDetails.SelectedItems;
                ListViewItem item = null;
                for (int i = 0; i < selectCount; i++)
                {
                    item = itemCollection[0];
                    UpdateStatData(-int.Parse(item.SubItems[1].Text), -1);
                    lstDetails.Items.RemoveAt(indexCollection[0]);
                }
            }
        }

        private void ToolStripMenuItemDel_Click(object sender, EventArgs e)
        {
            ToolStripMenuItemCDelFile.PerformClick();
        }
        #endregion

        #region 清零操作
        private void btnLinesClear_Click(object sender, EventArgs e)
        {
            lblLines.Text = "0";
                
        }

        private void btnFilesClear_Click(object sender, EventArgs e)
        {
            lblFiles.Text = "0";
        }

        private void btnThisLinesClear_Click(object sender, EventArgs e)
        {
            lblThisLines.Text = "0";
        }

        private void btnThisFilesClear_Click(object sender, EventArgs e)
        {
            lblThisFiles.Text = "0";
        }
        #endregion

        #region 终止线程
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                thrd.Abort();
            }
            catch{}  
            btnFilesClear.Enabled = true;
            btnLinesClear.Enabled = true;
            btnStart.Enabled = true;
        }
        #endregion

        #region 文件菜单处理
        private void ToolStripMenuItemToFile_Click(object sender, EventArgs e)
        {
            DialogResult saveInfo = saveFileDlg.ShowDialog();
            if (saveInfo == DialogResult.OK)
                SaveInfoToFile(saveFileDlg.FileName);
        }
        
        /// <summary>
        /// 保存统计的信息到文件
        /// </summary>
        /// <param name="filePath"></param>
        private void SaveInfoToFile(string filePath)
        {
            try
            {
                StreamWriter sw=new StreamWriter(filePath,true,Encoding.Default);
                for (int i = 0; i < lstDetails.Items.Count; ++i)
                {
                    sw.WriteLine(lstDetails.Items[i].SubItems[0].Text + "\t\t\t\t" + lstDetails.Items[i].SubItems[1].Text+"行");
                }
                sw.WriteLine();
                sw.WriteLine("总计行数:"+lblLines.Text+"行\t\t"+"总计文件数:"+lblLines.Text+"个");
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }                               
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void ToolStripMenuItemUse_Click(object sender, EventArgs e)
        {
           frmHelp frmHelp=new frmHelp();
           frmHelp.Show();
        }

        /// <summary>
        /// 自动调整文件和文件夹下拉框的宽度
        /// </summary>
        /// <param name="sender"></param>
        public void AutoSizeComboBoxItem(ComboBox sender)
        {
            if (sender is ComboBox)
            {

                Graphics grap = Graphics.FromHwnd(sender.Handle);
                StringFormat sf = new StringFormat(StringFormat.GenericTypographic);
                SizeF size;
                int i = 0;
                int extraWidth = 4;//额外宽度
                if (sender.MaxDropDownItems < sender.Items.Count)
                {
                    extraWidth += 18; //预留18px的滚动条条宽度。

                }
                while (i < sender.Items.Count)
                {

                    size = grap.MeasureString(sender.Items[i].ToString(), sender.Font, 500, sf);
                    if (size.Width > sender.DropDownWidth - extraWidth)
                    {
                        sender.DropDownWidth = System.Convert.ToInt32(size.Width) + extraWidth;

                    }
                    i++;

                }

                grap.Dispose();
                sf.Dispose();
            }
        }

        private void cmbFilesAndFolders_DropDown(object sender, EventArgs e)
        {
            AutoSizeComboBoxItem((ComboBox)sender);
        }

        /// <summary>
        /// 点击列表头部进行排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstDetails_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
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
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            this.lstDetails.Sort();

        }



        #region 删除下拉列表中的项目
        /// <summary>
        /// 删除下拉框内选中的项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (cmbFilesAndFolders.Items.Count != 0)
            {
                try
                {
                    cmbFilesAndFolders.Items.RemoveAt(cmbFilesAndFolders.SelectedIndex);
                    cmbFilesAndFolders.SelectedIndex = 0;
                }
                catch { }
            }
        }

        /// <summary>
        /// 清空下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbFilesAndFolders.Items.Count != 0)
            {
                cmbFilesAndFolders.Items.Clear();
            }
        }
        #endregion



        #region 支持拖拽功能
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] myFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in myFiles)
            {
                if (!this.cmbFilesAndFolders.Items.Contains(file))
                {
                    this.cmbFilesAndFolders.Items.Add(file);
                }
            }
            this.cmbFilesAndFolders.SelectedIndex = 0;
        }
        #endregion



    }

}