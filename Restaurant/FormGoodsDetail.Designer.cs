namespace Restaurant
{
    partial class FormGoodsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGoodsSubClassifyName = new System.Windows.Forms.ComboBox();
            this.cbGoodsClassifyName = new System.Windows.Forms.ComboBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbGoodsCode = new System.Windows.Forms.TextBox();
            this.tbPinYin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGoodsNO = new System.Windows.Forms.TextBox();
            this.tbGoodsSubClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMaterial = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGoodsSubClassifyName);
            this.groupBox1.Controls.Add(this.cbGoodsClassifyName);
            this.groupBox1.Controls.Add(this.tbCost);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbGoodsCode);
            this.groupBox1.Controls.Add(this.tbPinYin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbGoodsNO);
            this.groupBox1.Controls.Add(this.tbGoodsSubClassify);
            this.groupBox1.Controls.Add(this.tbGoodsClassify);
            this.groupBox1.Controls.Add(this.tbGoodsName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "酒菜信息：";
            // 
            // cbGoodsSubClassifyName
            // 
            this.cbGoodsSubClassifyName.FormattingEnabled = true;
            this.cbGoodsSubClassifyName.Location = new System.Drawing.Point(682, 24);
            this.cbGoodsSubClassifyName.Name = "cbGoodsSubClassifyName";
            this.cbGoodsSubClassifyName.Size = new System.Drawing.Size(95, 23);
            this.cbGoodsSubClassifyName.TabIndex = 35;
            this.cbGoodsSubClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsSubClassifyName_SelectedIndexChanged);
            // 
            // cbGoodsClassifyName
            // 
            this.cbGoodsClassifyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodsClassifyName.FormattingEnabled = true;
            this.cbGoodsClassifyName.Location = new System.Drawing.Point(682, 55);
            this.cbGoodsClassifyName.Name = "cbGoodsClassifyName";
            this.cbGoodsClassifyName.Size = new System.Drawing.Size(95, 23);
            this.cbGoodsClassifyName.TabIndex = 34;
            this.cbGoodsClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsClassifyName_SelectedIndexChanged);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(65, 55);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(171, 25);
            this.tbCost.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "成本:";
            // 
            // tbGoodsCode
            // 
            this.tbGoodsCode.Location = new System.Drawing.Point(323, 55);
            this.tbGoodsCode.Name = "tbGoodsCode";
            this.tbGoodsCode.Size = new System.Drawing.Size(353, 25);
            this.tbGoodsCode.TabIndex = 31;
            // 
            // tbPinYin
            // 
            this.tbPinYin.Location = new System.Drawing.Point(323, 24);
            this.tbPinYin.Name = "tbPinYin";
            this.tbPinYin.Size = new System.Drawing.Size(95, 25);
            this.tbPinYin.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "商品条码:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "拼音简码:";
            // 
            // tbGoodsNO
            // 
            this.tbGoodsNO.Location = new System.Drawing.Point(552, 24);
            this.tbGoodsNO.Name = "tbGoodsNO";
            this.tbGoodsNO.Size = new System.Drawing.Size(124, 25);
            this.tbGoodsNO.TabIndex = 27;
            this.tbGoodsNO.TextChanged += new System.EventHandler(this.tbGoodsNO_TextChanged);
            // 
            // tbGoodsSubClassify
            // 
            this.tbGoodsSubClassify.Location = new System.Drawing.Point(511, 24);
            this.tbGoodsSubClassify.Name = "tbGoodsSubClassify";
            this.tbGoodsSubClassify.ReadOnly = true;
            this.tbGoodsSubClassify.Size = new System.Drawing.Size(35, 25);
            this.tbGoodsSubClassify.TabIndex = 26;
            // 
            // tbGoodsClassify
            // 
            this.tbGoodsClassify.Location = new System.Drawing.Point(471, 24);
            this.tbGoodsClassify.Name = "tbGoodsClassify";
            this.tbGoodsClassify.ReadOnly = true;
            this.tbGoodsClassify.Size = new System.Drawing.Size(34, 25);
            this.tbGoodsClassify.TabIndex = 25;
            // 
            // tbGoodsName
            // 
            this.tbGoodsName.Location = new System.Drawing.Point(65, 24);
            this.tbGoodsName.Name = "tbGoodsName";
            this.tbGoodsName.Size = new System.Drawing.Size(171, 25);
            this.tbGoodsName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "编码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "名称:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMain);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "成分:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 46);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.Size = new System.Drawing.Size(827, 143);
            this.dgvMain.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonMod,
            this.toolStripButtonDel,
            this.toolStripSeparator1,
            this.toolStripButtonMaterial});
            this.toolStrip1.Location = new System.Drawing.Point(3, 21);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(827, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "增加";
            this.toolStripButtonAdd.ToolTipText = "增加";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonMod
            // 
            this.toolStripButtonMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMod.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMod.Image")));
            this.toolStripButtonMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMod.Name = "toolStripButtonMod";
            this.toolStripButtonMod.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMod.Text = "修改";
            this.toolStripButtonMod.Click += new System.EventHandler(this.toolStripButtonMod_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMaterial
            // 
            this.toolStripButtonMaterial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMaterial.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMaterial.Image")));
            this.toolStripButtonMaterial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMaterial.Name = "toolStripButtonMaterial";
            this.toolStripButtonMaterial.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMaterial.Text = "材料设置";
            this.toolStripButtonMaterial.Click += new System.EventHandler(this.toolStripButtonMaterial_Click);
            // 
            // FormGoodsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGoodsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒菜组成";
            this.Load += new System.EventHandler(this.FormGoodsDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbGoodsCode;
        private System.Windows.Forms.TextBox tbPinYin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGoodsNO;
        private System.Windows.Forms.TextBox tbGoodsSubClassify;
        private System.Windows.Forms.TextBox tbGoodsClassify;
        private System.Windows.Forms.TextBox tbGoodsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGoodsSubClassifyName;
        private System.Windows.Forms.ComboBox cbGoodsClassifyName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMaterial;
    }
}