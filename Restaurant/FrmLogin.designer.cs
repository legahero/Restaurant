namespace Restaurant
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.cb_Save = new System.Windows.Forms.CheckBox();
            this.tb_PWD = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.lbl_PWD = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.btModPwd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(242, 198);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(72, 32);
            this.bt_Cancel.TabIndex = 13;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(89, 198);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 32);
            this.bt_OK.TabIndex = 12;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // cb_Save
            // 
            this.cb_Save.Location = new System.Drawing.Point(141, 139);
            this.cb_Save.Name = "cb_Save";
            this.cb_Save.Size = new System.Drawing.Size(104, 24);
            this.cb_Save.TabIndex = 11;
            this.cb_Save.Text = "保存密码";
            this.cb_Save.CheckedChanged += new System.EventHandler(this.cb_Save_CheckedChanged);
            // 
            // tb_PWD
            // 
            this.tb_PWD.Location = new System.Drawing.Point(141, 91);
            this.tb_PWD.Name = "tb_PWD";
            this.tb_PWD.PasswordChar = '*';
            this.tb_PWD.Size = new System.Drawing.Size(184, 25);
            this.tb_PWD.TabIndex = 10;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(141, 35);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(184, 25);
            this.tb_User.TabIndex = 9;
            // 
            // lbl_PWD
            // 
            this.lbl_PWD.Location = new System.Drawing.Point(77, 91);
            this.lbl_PWD.Name = "lbl_PWD";
            this.lbl_PWD.Size = new System.Drawing.Size(56, 23);
            this.lbl_PWD.TabIndex = 8;
            this.lbl_PWD.Text = "密码:";
            // 
            // lbl_User
            // 
            this.lbl_User.Location = new System.Drawing.Point(77, 35);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(56, 23);
            this.lbl_User.TabIndex = 7;
            this.lbl_User.Text = "用户:";
            // 
            // btModPwd
            // 
            this.btModPwd.Location = new System.Drawing.Point(239, 134);
            this.btModPwd.Name = "btModPwd";
            this.btModPwd.Size = new System.Drawing.Size(86, 32);
            this.btModPwd.TabIndex = 14;
            this.btModPwd.Text = "修改密码";
            this.btModPwd.UseVisualStyleBackColor = true;
            this.btModPwd.Click += new System.EventHandler(this.btModPwd_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 242);
            this.Controls.Add(this.btModPwd);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.cb_Save);
            this.Controls.Add(this.tb_PWD);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lbl_PWD);
            this.Controls.Add(this.lbl_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.CheckBox cb_Save;
        private System.Windows.Forms.TextBox tb_PWD;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label lbl_PWD;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Button btModPwd;
    }
}