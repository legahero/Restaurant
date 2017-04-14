namespace UserModule
{
    partial class FormUserMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserMgr));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPWDInit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.dgvUserLogin = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPWDInit,
            this.toolStripButtonMod,
            this.toolStripButtonDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonPWDInit
            // 
            this.toolStripButtonPWDInit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPWDInit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPWDInit.Image")));
            this.toolStripButtonPWDInit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPWDInit.Name = "toolStripButtonPWDInit";
            this.toolStripButtonPWDInit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPWDInit.Text = "密码复位";
            this.toolStripButtonPWDInit.Click += new System.EventHandler(this.toolStripButtonPWDInit_Click);
            // 
            // toolStripButtonMod
            // 
            this.toolStripButtonMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMod.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMod.Image")));
            this.toolStripButtonMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMod.Name = "toolStripButtonMod";
            this.toolStripButtonMod.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMod.Text = "登录设置";
            this.toolStripButtonMod.Click += new System.EventHandler(this.toolStripButtonMod_Click);
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel.Text = "清除登录权限";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // dgvUserLogin
            // 
            this.dgvUserLogin.AllowUserToAddRows = false;
            this.dgvUserLogin.AllowUserToDeleteRows = false;
            this.dgvUserLogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserLogin.Location = new System.Drawing.Point(0, 25);
            this.dgvUserLogin.Name = "dgvUserLogin";
            this.dgvUserLogin.RowTemplate.Height = 27;
            this.dgvUserLogin.Size = new System.Drawing.Size(740, 265);
            this.dgvUserLogin.TabIndex = 1;
            // 
            // FormUserMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 290);
            this.Controls.Add(this.dgvUserLogin);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUserMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录管理";
            this.Load += new System.EventHandler(this.FormUserMgr_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPWDInit;
        private System.Windows.Forms.DataGridView dgvUserLogin;
        private System.Windows.Forms.ToolStripButton toolStripButtonMod;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
    }
}