namespace CountLines
{
    partial class frmFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLineInclude = new System.Windows.Forms.TextBox();
            this.radLineAnd = new System.Windows.Forms.RadioButton();
            this.radLineOr = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLineExclude = new System.Windows.Forms.TextBox();
            this.txtFileExclude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radFileOr = new System.Windows.Forms.RadioButton();
            this.radFileAnd = new System.Windows.Forms.RadioButton();
            this.txtFileInclude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.toolTipFilter = new System.Windows.Forms.ToolTip(this.components);
            this.lnkLineClear = new System.Windows.Forms.LinkLabel();
            this.lnkFileClear = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLineExclude);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radLineOr);
            this.groupBox1.Controls.Add(this.radLineAnd);
            this.groupBox1.Controls.Add(this.txtLineInclude);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(50, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代码行过滤条件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFileExclude);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.radFileOr);
            this.groupBox2.Controls.Add(this.radFileAnd);
            this.groupBox2.Controls.Add(this.txtFileInclude);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(50, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件名过滤条件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "包含：";
            // 
            // txtLineInclude
            // 
            this.txtLineInclude.Location = new System.Drawing.Point(77, 28);
            this.txtLineInclude.Name = "txtLineInclude";
            this.txtLineInclude.Size = new System.Drawing.Size(249, 21);
            this.txtLineInclude.TabIndex = 1;
            this.toolTipFilter.SetToolTip(this.txtLineInclude, "请输入代码行中要包含的字符串");
            // 
            // radLineAnd
            // 
            this.radLineAnd.AutoSize = true;
            this.radLineAnd.Checked = true;
            this.radLineAnd.Location = new System.Drawing.Point(20, 77);
            this.radLineAnd.Name = "radLineAnd";
            this.radLineAnd.Size = new System.Drawing.Size(47, 16);
            this.radLineAnd.TabIndex = 2;
            this.radLineAnd.TabStop = true;
            this.radLineAnd.Text = "并且";
            this.toolTipFilter.SetToolTip(this.radLineAnd, "请选择包含与不包含的关系");
            this.radLineAnd.UseVisualStyleBackColor = true;
            // 
            // radLineOr
            // 
            this.radLineOr.AutoSize = true;
            this.radLineOr.Location = new System.Drawing.Point(77, 77);
            this.radLineOr.Name = "radLineOr";
            this.radLineOr.Size = new System.Drawing.Size(47, 16);
            this.radLineOr.TabIndex = 3;
            this.radLineOr.Text = "或者";
            this.toolTipFilter.SetToolTip(this.radLineOr, "请选择包含与不包含的关系");
            this.radLineOr.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(5, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "不包含：";
            // 
            // txtLineExclude
            // 
            this.txtLineExclude.Location = new System.Drawing.Point(77, 115);
            this.txtLineExclude.Name = "txtLineExclude";
            this.txtLineExclude.Size = new System.Drawing.Size(249, 21);
            this.txtLineExclude.TabIndex = 5;
            this.toolTipFilter.SetToolTip(this.txtLineExclude, "请输入代码行中不包含的字符串");
            // 
            // txtFileExclude
            // 
            this.txtFileExclude.Location = new System.Drawing.Point(77, 116);
            this.txtFileExclude.Name = "txtFileExclude";
            this.txtFileExclude.Size = new System.Drawing.Size(249, 21);
            this.txtFileExclude.TabIndex = 11;
            this.toolTipFilter.SetToolTip(this.txtFileExclude, "请输入文件名中不包含的字符串");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "不包含：";
            // 
            // radFileOr
            // 
            this.radFileOr.AutoSize = true;
            this.radFileOr.Location = new System.Drawing.Point(77, 78);
            this.radFileOr.Name = "radFileOr";
            this.radFileOr.Size = new System.Drawing.Size(47, 16);
            this.radFileOr.TabIndex = 9;
            this.radFileOr.Text = "或者";
            this.toolTipFilter.SetToolTip(this.radFileOr, "请选择包含与不包含的关系");
            this.radFileOr.UseVisualStyleBackColor = true;
            // 
            // radFileAnd
            // 
            this.radFileAnd.AutoSize = true;
            this.radFileAnd.Checked = true;
            this.radFileAnd.Location = new System.Drawing.Point(20, 78);
            this.radFileAnd.Name = "radFileAnd";
            this.radFileAnd.Size = new System.Drawing.Size(47, 16);
            this.radFileAnd.TabIndex = 8;
            this.radFileAnd.TabStop = true;
            this.radFileAnd.Text = "并且";
            this.toolTipFilter.SetToolTip(this.radFileAnd, "请选择包含与不包含的关系");
            this.radFileAnd.UseVisualStyleBackColor = true;
            // 
            // txtFileInclude
            // 
            this.txtFileInclude.Location = new System.Drawing.Point(77, 29);
            this.txtFileInclude.Name = "txtFileInclude";
            this.txtFileInclude.Size = new System.Drawing.Size(249, 21);
            this.txtFileInclude.TabIndex = 7;
            this.toolTipFilter.SetToolTip(this.txtFileInclude, "请输入文件名要包含的字符串");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "包含：";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(177, 375);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lnkLineClear
            // 
            this.lnkLineClear.AutoSize = true;
            this.lnkLineClear.Location = new System.Drawing.Point(327, 9);
            this.lnkLineClear.Name = "lnkLineClear";
            this.lnkLineClear.Size = new System.Drawing.Size(53, 12);
            this.lnkLineClear.TabIndex = 3;
            this.lnkLineClear.TabStop = true;
            this.lnkLineClear.Text = "重置条件";
            this.lnkLineClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLineClear_LinkClicked);
            // 
            // lnkFileClear
            // 
            this.lnkFileClear.AutoSize = true;
            this.lnkFileClear.Location = new System.Drawing.Point(327, 193);
            this.lnkFileClear.Name = "lnkFileClear";
            this.lnkFileClear.Size = new System.Drawing.Size(53, 12);
            this.lnkFileClear.TabIndex = 4;
            this.lnkFileClear.TabStop = true;
            this.lnkFileClear.Text = "重置条件";
            this.lnkFileClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFileClear_LinkClicked);
            // 
            // frmFilter
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 410);
            this.Controls.Add(this.lnkFileClear);
            this.Controls.Add(this.lnkLineClear);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置过滤选项";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLineExclude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radLineOr;
        private System.Windows.Forms.RadioButton radLineAnd;
        private System.Windows.Forms.TextBox txtLineInclude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFileExclude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radFileOr;
        private System.Windows.Forms.RadioButton radFileAnd;
        private System.Windows.Forms.TextBox txtFileInclude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.ToolTip toolTipFilter;
        private System.Windows.Forms.LinkLabel lnkLineClear;
        private System.Windows.Forms.LinkLabel lnkFileClear;
    }
}