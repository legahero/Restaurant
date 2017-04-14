namespace UserModule
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbQName = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew,
            this.toolStripButtonMod,
            this.toolStripButtonDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 57);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(689, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Controls.Add(this.btSearch);
            this.gbSearch.Controls.Add(this.tbQName);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(689, 57);
            this.gbSearch.TabIndex = 24;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "快速搜索";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(27, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名：";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(281, 24);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(40, 24);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "->";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbQName
            // 
            this.tbQName.Location = new System.Drawing.Point(113, 24);
            this.tbQName.Name = "tbQName";
            this.tbQName.Size = new System.Drawing.Size(160, 25);
            this.tbQName.TabIndex = 0;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 82);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 27;
            this.dgvEmployee.Size = new System.Drawing.Size(689, 228);
            this.dgvEmployee.TabIndex = 25;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 310);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "职员资料";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.ToolStripButton toolStripButtonMod;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbQName;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}