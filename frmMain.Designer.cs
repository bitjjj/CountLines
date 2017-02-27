namespace CountLines
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemKind = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChooseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemother = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFile = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.folderBrowserDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemCOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemCClear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.btnLinesClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnFilesClear = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.cmbFilesAndFolders = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThisFilesClear = new System.Windows.Forms.Button();
            this.btnThisLinesClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThisFiles = new System.Windows.Forms.Label();
            this.lblThisLines = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemCount,
            this.ToolStripMenuItemSet,
            this.ToolStripMenuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(593, 24);
            this.menuStripMain.TabIndex = 0;
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemToFile,
            this.toolStripSeparator1,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(41, 20);
            this.ToolStripMenuItemFile.Text = "文件";
            // 
            // ToolStripMenuItemToFile
            // 
            this.ToolStripMenuItemToFile.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemToFile.Image")));
            this.ToolStripMenuItemToFile.Name = "ToolStripMenuItemToFile";
            this.ToolStripMenuItemToFile.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItemToFile.Text = "保存信息到文件";
            this.ToolStripMenuItemToFile.ToolTipText = "保存每个文件代码行数的列表到文件";
            this.ToolStripMenuItemToFile.Click += new System.EventHandler(this.ToolStripMenuItemToFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemExit.Image")));
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItemExit.Text = "退出";
            this.ToolStripMenuItemExit.ToolTipText = "退出程序";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // ToolStripMenuItemCount
            // 
            this.ToolStripMenuItemCount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDel,
            this.ToolStripMenuItemClear,
            this.toolStripSeparator4,
            this.ToolStripMenuItemKind});
            this.ToolStripMenuItemCount.Name = "ToolStripMenuItemCount";
            this.ToolStripMenuItemCount.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemCount.Text = "统计操作";
            // 
            // ToolStripMenuItemDel
            // 
            this.ToolStripMenuItemDel.Name = "ToolStripMenuItemDel";
            this.ToolStripMenuItemDel.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemDel.Text = "删除已选文件";
            this.ToolStripMenuItemDel.Click += new System.EventHandler(this.ToolStripMenuItemDel_Click);
            // 
            // ToolStripMenuItemClear
            // 
            this.ToolStripMenuItemClear.Name = "ToolStripMenuItemClear";
            this.ToolStripMenuItemClear.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemClear.Text = "清空信息列表";
            this.ToolStripMenuItemClear.ToolTipText = "清空详细信息列表";
            this.ToolStripMenuItemClear.Click += new System.EventHandler(this.ToolStripMenuItemClear_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(139, 6);
            // 
            // ToolStripMenuItemKind
            // 
            this.ToolStripMenuItemKind.Name = "ToolStripMenuItemKind";
            this.ToolStripMenuItemKind.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemKind.Text = "分类统计信息";
            this.ToolStripMenuItemKind.Click += new System.EventHandler(this.ToolStripMenuItemKind_Click);
            // 
            // ToolStripMenuItemSet
            // 
            this.ToolStripMenuItemSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemChooseFile,
            this.toolStripSeparator2,
            this.ToolStripMenuItemFilter,
            this.ToolStripMenuItemother});
            this.ToolStripMenuItemSet.Name = "ToolStripMenuItemSet";
            this.ToolStripMenuItemSet.Size = new System.Drawing.Size(41, 20);
            this.ToolStripMenuItemSet.Text = "设置";
            // 
            // ToolStripMenuItemChooseFile
            // 
            this.ToolStripMenuItemChooseFile.Name = "ToolStripMenuItemChooseFile";
            this.ToolStripMenuItemChooseFile.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemChooseFile.Text = "选择文件类型";
            this.ToolStripMenuItemChooseFile.ToolTipText = "设置需要统计的文件类型";
            this.ToolStripMenuItemChooseFile.Click += new System.EventHandler(this.ToolStripMenuItemChooseFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // ToolStripMenuItemFilter
            // 
            this.ToolStripMenuItemFilter.Name = "ToolStripMenuItemFilter";
            this.ToolStripMenuItemFilter.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemFilter.Text = "过滤设置";
            this.ToolStripMenuItemFilter.Click += new System.EventHandler(this.ToolStripMenuItemFilter_Click);
            // 
            // ToolStripMenuItemother
            // 
            this.ToolStripMenuItemother.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemother.Image")));
            this.ToolStripMenuItemother.Name = "ToolStripMenuItemother";
            this.ToolStripMenuItemother.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemother.Text = "其他设置";
            this.ToolStripMenuItemother.ToolTipText = "其它统计设置";
            this.ToolStripMenuItemother.Click += new System.EventHandler(this.ToolStripMenuItemother_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUse});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(41, 20);
            this.ToolStripMenuItemHelp.Text = "帮助";
            // 
            // ToolStripMenuItemUse
            // 
            this.ToolStripMenuItemUse.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemUse.Image")));
            this.ToolStripMenuItemUse.Name = "ToolStripMenuItemUse";
            this.ToolStripMenuItemUse.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemUse.Text = "使用说明";
            this.ToolStripMenuItemUse.ToolTipText = "使用说明";
            this.ToolStripMenuItemUse.Click += new System.EventHandler(this.ToolStripMenuItemUse_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(483, 31);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "打开文件";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.OpenDlg);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Multiselect = true;
            // 
            // btnFolder
            // 
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFolder.Location = new System.Drawing.Point(402, 31);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "打开文件夹";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.OpenDlg);
            // 
            // folderBrowserDlg
            // 
            this.folderBrowserDlg.Description = "选择您要打开的文件夹";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(257, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "详细信息";
            // 
            // lstDetails
            // 
            this.lstDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstDetails.ContextMenuStrip = this.contextMenuStrip;
            this.lstDetails.FullRowSelect = true;
            this.lstDetails.GridLines = true;
            this.lstDetails.Location = new System.Drawing.Point(11, 167);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.ShowItemToolTips = true;
            this.lstDetails.Size = new System.Drawing.Size(568, 264);
            this.lstDetails.TabIndex = 6;
            this.lstDetails.UseCompatibleStateImageBehavior = false;
            this.lstDetails.View = System.Windows.Forms.View.Details;
            this.lstDetails.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstDetails_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件路径";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "代码行数";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "文件类型";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCOpenFile,
            this.toolStripSeparator3,
            this.ToolStripMenuItemCClear,
            this.ToolStripMenuItemCDelFile});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(119, 76);
            // 
            // ToolStripMenuItemCOpenFile
            // 
            this.ToolStripMenuItemCOpenFile.Name = "ToolStripMenuItemCOpenFile";
            this.ToolStripMenuItemCOpenFile.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemCOpenFile.Text = "打开文件";
            this.ToolStripMenuItemCOpenFile.ToolTipText = "预览选中文件";
            this.ToolStripMenuItemCOpenFile.Click += new System.EventHandler(this.ToolStripMenuItemCOpenFile_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // ToolStripMenuItemCClear
            // 
            this.ToolStripMenuItemCClear.Name = "ToolStripMenuItemCClear";
            this.ToolStripMenuItemCClear.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemCClear.Text = "清空列表";
            this.ToolStripMenuItemCClear.ToolTipText = "清空详细信息列表";
            this.ToolStripMenuItemCClear.Click += new System.EventHandler(this.ToolStripMenuItemCClear_Click);
            // 
            // ToolStripMenuItemCDelFile
            // 
            this.ToolStripMenuItemCDelFile.Name = "ToolStripMenuItemCDelFile";
            this.ToolStripMenuItemCDelFile.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemCDelFile.Text = "删除文件";
            this.ToolStripMenuItemCDelFile.Click += new System.EventHandler(this.ToolStripMenuItemCDelFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(13, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "正在统计的文件:";
            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.BackColor = System.Drawing.Color.Transparent;
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFile.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFile.Location = new System.Drawing.Point(114, 24);
            this.lblFile.MaximumSize = new System.Drawing.Size(450, 20);
            this.lblFile.MinimumSize = new System.Drawing.Size(450, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(450, 20);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "正在统计的文件";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "总计代码行数:";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.BackColor = System.Drawing.Color.Transparent;
            this.lblLines.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLines.Location = new System.Drawing.Point(98, 87);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(17, 16);
            this.lblLines.TabIndex = 10;
            this.lblLines.Text = "0";
            // 
            // btnLinesClear
            // 
            this.btnLinesClear.Location = new System.Drawing.Point(172, 84);
            this.btnLinesClear.Name = "btnLinesClear";
            this.btnLinesClear.Size = new System.Drawing.Size(72, 23);
            this.btnLinesClear.TabIndex = 11;
            this.btnLinesClear.Text = "行数清零";
            this.btnLinesClear.UseVisualStyleBackColor = true;
            this.btnLinesClear.Click += new System.EventHandler(this.btnLinesClear_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(413, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "开始统计";
            this.toolTip.SetToolTip(this.btnStart, "默认情况下只统计文件\r\n夹和磁盘内的.c,.cpp,.\r\ncs,.java文件,您可以点\r\n击设置菜单设置要统计\r\n的文件类型");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "提示";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(262, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "总计文件数:";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblFiles.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFiles.Location = new System.Drawing.Point(331, 87);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(17, 16);
            this.lblFiles.TabIndex = 14;
            this.lblFiles.Text = "0";
            // 
            // btnFilesClear
            // 
            this.btnFilesClear.Location = new System.Drawing.Point(402, 85);
            this.btnFilesClear.Name = "btnFilesClear";
            this.btnFilesClear.Size = new System.Drawing.Size(72, 23);
            this.btnFilesClear.TabIndex = 15;
            this.btnFilesClear.Text = "文件数清零";
            this.btnFilesClear.UseVisualStyleBackColor = true;
            this.btnFilesClear.Click += new System.EventHandler(this.btnFilesClear_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(497, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "停止统计";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Title = "保存统计信息";
            // 
            // cmbFilesAndFolders
            // 
            this.cmbFilesAndFolders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilesAndFolders.FormattingEnabled = true;
            this.cmbFilesAndFolders.Location = new System.Drawing.Point(6, 34);
            this.cmbFilesAndFolders.MaxDropDownItems = 20;
            this.cmbFilesAndFolders.Name = "cmbFilesAndFolders";
            this.cmbFilesAndFolders.Size = new System.Drawing.Size(297, 20);
            this.cmbFilesAndFolders.TabIndex = 17;
            this.cmbFilesAndFolders.DropDown += new System.EventHandler(this.cmbFilesAndFolders_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelItem);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.cmbFilesAndFolders);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计的文件和文件夹";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(357, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(39, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(309, 31);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(39, 23);
            this.btnDelItem.TabIndex = 18;
            this.btnDelItem.Text = "删除";
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThisFilesClear);
            this.groupBox2.Controls.Add(this.btnThisLinesClear);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblThisFiles);
            this.groupBox2.Controls.Add(this.lblThisLines);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnFilesClear);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnLinesClear);
            this.groupBox2.Controls.Add(this.lblFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblFiles);
            this.groupBox2.Controls.Add(this.lblLines);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(11, 449);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 123);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "其它信息";
            // 
            // btnThisFilesClear
            // 
            this.btnThisFilesClear.Location = new System.Drawing.Point(403, 54);
            this.btnThisFilesClear.Name = "btnThisFilesClear";
            this.btnThisFilesClear.Size = new System.Drawing.Size(72, 23);
            this.btnThisFilesClear.TabIndex = 21;
            this.btnThisFilesClear.Text = "文件数清零";
            this.btnThisFilesClear.UseVisualStyleBackColor = true;
            this.btnThisFilesClear.Click += new System.EventHandler(this.btnThisFilesClear_Click);
            // 
            // btnThisLinesClear
            // 
            this.btnThisLinesClear.Location = new System.Drawing.Point(173, 53);
            this.btnThisLinesClear.Name = "btnThisLinesClear";
            this.btnThisLinesClear.Size = new System.Drawing.Size(72, 23);
            this.btnThisLinesClear.TabIndex = 18;
            this.btnThisLinesClear.Text = "行数清零";
            this.btnThisLinesClear.UseVisualStyleBackColor = true;
            this.btnThisLinesClear.Click += new System.EventHandler(this.btnThisLinesClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "本次代码行数:";
            // 
            // lblThisFiles
            // 
            this.lblThisFiles.AutoSize = true;
            this.lblThisFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblThisFiles.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThisFiles.Location = new System.Drawing.Point(332, 56);
            this.lblThisFiles.Name = "lblThisFiles";
            this.lblThisFiles.Size = new System.Drawing.Size(17, 16);
            this.lblThisFiles.TabIndex = 20;
            this.lblThisFiles.Text = "0";
            // 
            // lblThisLines
            // 
            this.lblThisLines.AutoSize = true;
            this.lblThisLines.BackColor = System.Drawing.Color.Transparent;
            this.lblThisLines.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblThisLines.Location = new System.Drawing.Point(99, 56);
            this.lblThisLines.Name = "lblThisLines";
            this.lblThisLines.Size = new System.Drawing.Size(17, 16);
            this.lblThisLines.TabIndex = 17;
            this.lblThisLines.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(263, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "本次文件数:";
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码行统计工具V2.5";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMain_DragEnter);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemToFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCount;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUse;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChooseFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Button btnLinesClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemother;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCClear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnFilesClear;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.ComboBox cmbFilesAndFolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCDelFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKind;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThisFilesClear;
        private System.Windows.Forms.Button btnThisLinesClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThisFiles;
        private System.Windows.Forms.Label lblThisLines;
        private System.Windows.Forms.Label label8;
    }
}

