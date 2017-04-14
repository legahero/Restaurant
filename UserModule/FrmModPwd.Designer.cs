namespace UserModule
{
    partial class FrmModPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModPwd));
            this.tb_Confirm = new System.Windows.Forms.TextBox();
            this.tb_NewPwd = new System.Windows.Forms.TextBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Confirm = new System.Windows.Forms.Button();
            this.tb_OldPwd = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.lbl_oldPWD = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Confirm
            // 
            this.tb_Confirm.Location = new System.Drawing.Point(139, 114);
            this.tb_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Confirm.Name = "tb_Confirm";
            this.tb_Confirm.PasswordChar = '*';
            this.tb_Confirm.Size = new System.Drawing.Size(127, 21);
            this.tb_Confirm.TabIndex = 19;
            // 
            // tb_NewPwd
            // 
            this.tb_NewPwd.Location = new System.Drawing.Point(139, 88);
            this.tb_NewPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_NewPwd.Name = "tb_NewPwd";
            this.tb_NewPwd.PasswordChar = '*';
            this.tb_NewPwd.Size = new System.Drawing.Size(127, 21);
            this.tb_NewPwd.TabIndex = 18;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.Location = new System.Drawing.Point(55, 118);
            this.lbl_Confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(75, 18);
            this.lbl_Confirm.TabIndex = 17;
            this.lbl_Confirm.Text = "确认新密码:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "新密码:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Location = new System.Drawing.Point(181, 152);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(56, 26);
            this.bt_Cancel.TabIndex = 15;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_Confirm
            // 
            this.bt_Confirm.Location = new System.Drawing.Point(85, 152);
            this.bt_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Confirm.Name = "bt_Confirm";
            this.bt_Confirm.Size = new System.Drawing.Size(56, 26);
            this.bt_Confirm.TabIndex = 14;
            this.bt_Confirm.Text = "确定";
            this.bt_Confirm.Click += new System.EventHandler(this.bt_Confirm_Click);
            // 
            // tb_OldPwd
            // 
            this.tb_OldPwd.Location = new System.Drawing.Point(139, 62);
            this.tb_OldPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_OldPwd.Name = "tb_OldPwd";
            this.tb_OldPwd.PasswordChar = '*';
            this.tb_OldPwd.Size = new System.Drawing.Size(127, 21);
            this.tb_OldPwd.TabIndex = 13;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(139, 30);
            this.tb_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(127, 21);
            this.tb_User.TabIndex = 12;
            // 
            // lbl_oldPWD
            // 
            this.lbl_oldPWD.Location = new System.Drawing.Point(55, 62);
            this.lbl_oldPWD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_oldPWD.Name = "lbl_oldPWD";
            this.lbl_oldPWD.Size = new System.Drawing.Size(75, 18);
            this.lbl_oldPWD.TabIndex = 11;
            this.lbl_oldPWD.Text = "旧密码:";
            // 
            // lbl_User
            // 
            this.lbl_User.Location = new System.Drawing.Point(55, 31);
            this.lbl_User.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(75, 18);
            this.lbl_User.TabIndex = 10;
            this.lbl_User.Text = "用户:";
            // 
            // FrmModPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 208);
            this.Controls.Add(this.tb_Confirm);
            this.Controls.Add(this.tb_NewPwd);
            this.Controls.Add(this.lbl_Confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Confirm);
            this.Controls.Add(this.tb_OldPwd);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.lbl_oldPWD);
            this.Controls.Add(this.lbl_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmModPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmModPwd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Confirm;
        private System.Windows.Forms.TextBox tb_NewPwd;
        private System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Confirm;
        private System.Windows.Forms.TextBox tb_OldPwd;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label lbl_oldPWD;
        private System.Windows.Forms.Label lbl_User;
    }
}