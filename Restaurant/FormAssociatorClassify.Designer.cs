namespace Restaurant
{
    partial class FormAssociatorClassify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAssociatorClassify));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsTimeLimit = new System.Windows.Forms.CheckBox();
            this.tbAgioRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntegralRadix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeLimit = new System.Windows.Forms.TextBox();
            this.tbClassifyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btMod = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 25);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.Size = new System.Drawing.Size(676, 116);
            this.dgvMain.TabIndex = 18;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIsTimeLimit);
            this.groupBox1.Controls.Add(this.tbAgioRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbIntegralRadix);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRemark);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTimeLimit);
            this.groupBox1.Controls.Add(this.tbClassifyName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 116);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预定信息:";
            // 
            // cbIsTimeLimit
            // 
            this.cbIsTimeLimit.AutoSize = true;
            this.cbIsTimeLimit.Location = new System.Drawing.Point(301, 13);
            this.cbIsTimeLimit.Name = "cbIsTimeLimit";
            this.cbIsTimeLimit.Size = new System.Drawing.Size(59, 19);
            this.cbIsTimeLimit.TabIndex = 14;
            this.cbIsTimeLimit.Text = "时限";
            this.cbIsTimeLimit.UseVisualStyleBackColor = true;
            // 
            // tbAgioRate
            // 
            this.tbAgioRate.Location = new System.Drawing.Point(163, 44);
            this.tbAgioRate.Name = "tbAgioRate";
            this.tbAgioRate.Size = new System.Drawing.Size(120, 25);
            this.tbAgioRate.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员卡:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "天";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "折扣:";
            // 
            // tbIntegralRadix
            // 
            this.tbIntegralRadix.Location = new System.Drawing.Point(379, 44);
            this.tbIntegralRadix.Name = "tbIntegralRadix";
            this.tbIntegralRadix.Size = new System.Drawing.Size(120, 25);
            this.tbIntegralRadix.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注:";
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(163, 80);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(210, 25);
            this.tbRemark.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "积分基数:";
            // 
            // tbTimeLimit
            // 
            this.tbTimeLimit.Location = new System.Drawing.Point(379, 10);
            this.tbTimeLimit.Name = "tbTimeLimit";
            this.tbTimeLimit.Size = new System.Drawing.Size(83, 25);
            this.tbTimeLimit.TabIndex = 7;
            // 
            // tbClassifyName
            // 
            this.tbClassifyName.Location = new System.Drawing.Point(163, 10);
            this.tbClassifyName.Name = "tbClassifyName";
            this.tbClassifyName.Size = new System.Drawing.Size(120, 25);
            this.tbClassifyName.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btMod);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 40);
            this.panel1.TabIndex = 19;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(379, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 16;
            this.btSave.Text = "保存(&S)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(271, 6);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(75, 23);
            this.btMod.TabIndex = 15;
            this.btMod.Text = "修改(&M)";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(163, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "增加(&A)";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FormAssociatorClassify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 297);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAssociatorClassify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员类别";
            this.Load += new System.EventHandler(this.FormAssociatorClassify_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAgioRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntegralRadix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeLimit;
        private System.Windows.Forms.TextBox tbClassifyName;
        private System.Windows.Forms.CheckBox cbIsTimeLimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btAdd;
    }
}