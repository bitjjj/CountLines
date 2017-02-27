namespace CountLines
{
    partial class frmSortStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSortStat));
            this.lstSortInfo = new System.Windows.Forms.ListView();
            this.fileType = new System.Windows.Forms.ColumnHeader();
            this.codeLines = new System.Windows.Forms.ColumnHeader();
            this.percent = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstFilterInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLineInfo = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSortInfo
            // 
            this.lstSortInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileType,
            this.codeLines,
            this.percent});
            this.lstSortInfo.FullRowSelect = true;
            this.lstSortInfo.GridLines = true;
            this.lstSortInfo.Location = new System.Drawing.Point(19, 20);
            this.lstSortInfo.Name = "lstSortInfo";
            this.lstSortInfo.Size = new System.Drawing.Size(408, 124);
            this.lstSortInfo.TabIndex = 0;
            this.lstSortInfo.UseCompatibleStateImageBehavior = false;
            this.lstSortInfo.View = System.Windows.Forms.View.Details;
            // 
            // fileType
            // 
            this.fileType.Text = "文件类型";
            this.fileType.Width = 102;
            // 
            // codeLines
            // 
            this.codeLines.Text = "代码行数";
            this.codeLines.Width = 108;
            // 
            // percent
            // 
            this.percent.Text = "百分比";
            this.percent.Width = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSortInfo);
            this.groupBox1.Location = new System.Drawing.Point(26, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件分类统计信息";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(196, 534);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstFilterInfo);
            this.groupBox2.Location = new System.Drawing.Point(26, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "过滤行统计信息";
            // 
            // lstFilterInfo
            // 
            this.lstFilterInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstFilterInfo.FullRowSelect = true;
            this.lstFilterInfo.GridLines = true;
            this.lstFilterInfo.Location = new System.Drawing.Point(19, 20);
            this.lstFilterInfo.Name = "lstFilterInfo";
            this.lstFilterInfo.Size = new System.Drawing.Size(408, 124);
            this.lstFilterInfo.TabIndex = 1;
            this.lstFilterInfo.UseCompatibleStateImageBehavior = false;
            this.lstFilterInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "过滤类型";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "代码行数";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "百分比";
            this.columnHeader3.Width = 76;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLineInfo);
            this.groupBox3.Location = new System.Drawing.Point(26, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 157);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "代码行统计信息";
            // 
            // lstLineInfo
            // 
            this.lstLineInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstLineInfo.FullRowSelect = true;
            this.lstLineInfo.GridLines = true;
            this.lstLineInfo.Location = new System.Drawing.Point(19, 20);
            this.lstLineInfo.Name = "lstLineInfo";
            this.lstLineInfo.Size = new System.Drawing.Size(408, 124);
            this.lstLineInfo.TabIndex = 1;
            this.lstLineInfo.UseCompatibleStateImageBehavior = false;
            this.lstLineInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "代码行类型";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "代码行数";
            this.columnHeader5.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "百分比";
            this.columnHeader6.Width = 76;
            // 
            // frmSortStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 568);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSortStat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "分类统计信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSortInfo;
        private System.Windows.Forms.ColumnHeader fileType;
        private System.Windows.Forms.ColumnHeader codeLines;
        private System.Windows.Forms.ColumnHeader percent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstFilterInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstLineInfo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}