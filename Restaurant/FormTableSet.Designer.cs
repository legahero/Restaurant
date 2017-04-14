namespace Restaurant
{
    partial class FormTableSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTableSet));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDiningTable = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNew2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDiningDept = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDiningDeptAdd = new System.Windows.Forms.ToolStripButton();
            this.DiningDeptMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDiningDeptDel = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTableClassify = new System.Windows.Forms.DataGridView();
            this.toolStripClassify = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClassifyAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClassifyMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClassifyDel = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiningTable)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiningDept)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableClassify)).BeginInit();
            this.toolStripClassify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 289);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDiningTable);
            this.tabPage2.Controls.Add(this.toolStrip4);
            this.tabPage2.Controls.Add(this.splitter1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "房台设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDiningTable
            // 
            this.dgvDiningTable.AllowUserToAddRows = false;
            this.dgvDiningTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiningTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiningTable.Location = new System.Drawing.Point(302, 28);
            this.dgvDiningTable.Name = "dgvDiningTable";
            this.dgvDiningTable.RowTemplate.Height = 27;
            this.dgvDiningTable.Size = new System.Drawing.Size(322, 230);
            this.dgvDiningTable.TabIndex = 4;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonNew2,
            this.toolStripButtonMod,
            this.toolStripButtonDel});
            this.toolStrip4.Location = new System.Drawing.Point(302, 3);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(322, 25);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "增加";
            this.toolStripButtonNew.ToolTipText = "增加";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // toolStripButtonNew2
            // 
            this.toolStripButtonNew2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew2.Image")));
            this.toolStripButtonNew2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew2.Name = "toolStripButtonNew2";
            this.toolStripButtonNew2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew2.Text = "批量加";
            this.toolStripButtonNew2.Click += new System.EventHandler(this.toolStripButtonNew2_Click);
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
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(292, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 255);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDiningDept);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 255);
            this.panel1.TabIndex = 1;
            // 
            // dgvDiningDept
            // 
            this.dgvDiningDept.AllowUserToAddRows = false;
            this.dgvDiningDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiningDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiningDept.Location = new System.Drawing.Point(0, 25);
            this.dgvDiningDept.Name = "dgvDiningDept";
            this.dgvDiningDept.RowTemplate.Height = 27;
            this.dgvDiningDept.Size = new System.Drawing.Size(289, 230);
            this.dgvDiningDept.TabIndex = 0;
            this.dgvDiningDept.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiningDept_RowEnter);
            this.dgvDiningDept.SelectionChanged += new System.EventHandler(this.dgvDiningDept_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDiningDeptAdd,
            this.DiningDeptMod,
            this.toolStripButtonDiningDeptDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(289, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonDiningDeptAdd
            // 
            this.toolStripButtonDiningDeptAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDiningDeptAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDiningDeptAdd.Image")));
            this.toolStripButtonDiningDeptAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiningDeptAdd.Name = "toolStripButtonDiningDeptAdd";
            this.toolStripButtonDiningDeptAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDiningDeptAdd.Text = "增加";
            this.toolStripButtonDiningDeptAdd.ToolTipText = "增加";
            this.toolStripButtonDiningDeptAdd.Click += new System.EventHandler(this.toolStripButtonDiningDeptAdd_Click);
            // 
            // DiningDeptMod
            // 
            this.DiningDeptMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DiningDeptMod.Image = ((System.Drawing.Image)(resources.GetObject("DiningDeptMod.Image")));
            this.DiningDeptMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DiningDeptMod.Name = "DiningDeptMod";
            this.DiningDeptMod.Size = new System.Drawing.Size(23, 22);
            this.DiningDeptMod.Text = "修改";
            this.DiningDeptMod.Click += new System.EventHandler(this.DiningDeptMod_Click);
            // 
            // toolStripButtonDiningDeptDel
            // 
            this.toolStripButtonDiningDeptDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDiningDeptDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDiningDeptDel.Image")));
            this.toolStripButtonDiningDeptDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiningDeptDel.Name = "toolStripButtonDiningDeptDel";
            this.toolStripButtonDiningDeptDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDiningDeptDel.Text = "删除";
            this.toolStripButtonDiningDeptDel.Click += new System.EventHandler(this.toolStripButtonDiningDeptDel_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTableClassify);
            this.tabPage1.Controls.Add(this.toolStripClassify);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "房台类别";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTableClassify
            // 
            this.dgvTableClassify.AllowUserToAddRows = false;
            this.dgvTableClassify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableClassify.Location = new System.Drawing.Point(3, 28);
            this.dgvTableClassify.Name = "dgvTableClassify";
            this.dgvTableClassify.RowTemplate.Height = 27;
            this.dgvTableClassify.Size = new System.Drawing.Size(621, 230);
            this.dgvTableClassify.TabIndex = 7;
            // 
            // toolStripClassify
            // 
            this.toolStripClassify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClassifyAdd,
            this.toolStripButtonClassifyMod,
            this.toolStripButtonClassifyDel});
            this.toolStripClassify.Location = new System.Drawing.Point(3, 3);
            this.toolStripClassify.Name = "toolStripClassify";
            this.toolStripClassify.Size = new System.Drawing.Size(621, 25);
            this.toolStripClassify.TabIndex = 6;
            this.toolStripClassify.Text = "toolStrip2";
            // 
            // toolStripButtonClassifyAdd
            // 
            this.toolStripButtonClassifyAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClassifyAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassifyAdd.Image")));
            this.toolStripButtonClassifyAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassifyAdd.Name = "toolStripButtonClassifyAdd";
            this.toolStripButtonClassifyAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClassifyAdd.Text = "增加";
            this.toolStripButtonClassifyAdd.ToolTipText = "增加";
            this.toolStripButtonClassifyAdd.Click += new System.EventHandler(this.toolStripButtonClassifyAdd_Click);
            // 
            // toolStripButtonClassifyMod
            // 
            this.toolStripButtonClassifyMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClassifyMod.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassifyMod.Image")));
            this.toolStripButtonClassifyMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassifyMod.Name = "toolStripButtonClassifyMod";
            this.toolStripButtonClassifyMod.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClassifyMod.Text = "修改";
            this.toolStripButtonClassifyMod.Click += new System.EventHandler(this.toolStripButtonClassifyMod_Click);
            // 
            // toolStripButtonClassifyDel
            // 
            this.toolStripButtonClassifyDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClassifyDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClassifyDel.Image")));
            this.toolStripButtonClassifyDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClassifyDel.Name = "toolStripButtonClassifyDel";
            this.toolStripButtonClassifyDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClassifyDel.Text = "删除";
            this.toolStripButtonClassifyDel.Click += new System.EventHandler(this.toolStripButtonClassifyDel_Click);
            // 
            // FormTableSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 289);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTableSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐台设置";
            this.Load += new System.EventHandler(this.FormTableSet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiningTable)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiningDept)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableClassify)).EndInit();
            this.toolStripClassify.ResumeLayout(false);
            this.toolStripClassify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDiningDept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvDiningTable;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiningDeptAdd;
        private System.Windows.Forms.ToolStripButton DiningDeptMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiningDeptDel;
        private System.Windows.Forms.ToolStrip toolStripClassify;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassifyAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassifyMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonClassifyDel;
        private System.Windows.Forms.DataGridView dgvTableClassify;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew2;
    }
}