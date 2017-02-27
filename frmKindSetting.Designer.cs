namespace CountLines
{
    partial class frmKindSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKindSetting));
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnToRight = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.btnAllToRight = new System.Windows.Forms.Button();
            this.btnAllToLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKind = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 12;
            this.lstLeft.Location = new System.Drawing.Point(12, 18);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(143, 220);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 12;
            this.lstRight.Location = new System.Drawing.Point(261, 18);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(143, 220);
            this.lstRight.TabIndex = 1;
            // 
            // btnToRight
            // 
            this.btnToRight.Location = new System.Drawing.Point(170, 33);
            this.btnToRight.Name = "btnToRight";
            this.btnToRight.Size = new System.Drawing.Size(75, 23);
            this.btnToRight.TabIndex = 2;
            this.btnToRight.Text = "-->";
            this.btnToRight.UseVisualStyleBackColor = true;
            this.btnToRight.Click += new System.EventHandler(this.ChooseItem);
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(170, 86);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnToLeft.TabIndex = 3;
            this.btnToLeft.Text = "<--";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.ChooseItem);
            // 
            // btnAllToRight
            // 
            this.btnAllToRight.Location = new System.Drawing.Point(170, 139);
            this.btnAllToRight.Name = "btnAllToRight";
            this.btnAllToRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllToRight.TabIndex = 4;
            this.btnAllToRight.Text = ">>";
            this.btnAllToRight.UseVisualStyleBackColor = true;
            this.btnAllToRight.Click += new System.EventHandler(this.ChooseItem);
            // 
            // btnAllToLeft
            // 
            this.btnAllToLeft.Location = new System.Drawing.Point(170, 192);
            this.btnAllToLeft.Name = "btnAllToLeft";
            this.btnAllToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAllToLeft.TabIndex = 5;
            this.btnAllToLeft.Text = "<<";
            this.btnAllToLeft.UseVisualStyleBackColor = true;
            this.btnAllToLeft.Click += new System.EventHandler(this.ChooseItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllToLeft);
            this.groupBox1.Controls.Add(this.btnAllToRight);
            this.groupBox1.Controls.Add(this.btnToLeft);
            this.groupBox1.Controls.Add(this.btnToRight);
            this.groupBox1.Controls.Add(this.lstRight);
            this.groupBox1.Controls.Add(this.lstLeft);
            this.groupBox1.Location = new System.Drawing.Point(9, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 256);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "从左边选择文件类型添加到右边";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "自定义文件类型:";
            // 
            // txtKind
            // 
            this.txtKind.Location = new System.Drawing.Point(113, 27);
            this.txtKind.MaxLength = 20;
            this.txtKind.Name = "txtKind";
            this.txtKind.Size = new System.Drawing.Size(100, 21);
            this.txtKind.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtKind);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 65);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "自定义";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(355, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "提示：点确定后自定义类型将保存，否则下一次运行将丢失";
            // 
            // frmKindSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 440);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKindSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置要统计的文件类型";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnToRight;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.Button btnAllToRight;
        private System.Windows.Forms.Button btnAllToLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKind;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
    }
}