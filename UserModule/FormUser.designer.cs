namespace UserModule
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.editPwdInput = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.editLoginName = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.editPwd = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editPwdInput
            // 
            this.editPwdInput.Location = new System.Drawing.Point(147, 69);
            this.editPwdInput.Name = "editPwdInput";
            this.editPwdInput.PasswordChar = '*';
            this.editPwdInput.Size = new System.Drawing.Size(192, 25);
            this.editPwdInput.TabIndex = 29;
            // 
            // lblLoginName
            // 
            this.lblLoginName.Location = new System.Drawing.Point(43, 29);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(100, 23);
            this.lblLoginName.TabIndex = 25;
            this.lblLoginName.Text = "登录名:";
            // 
            // editLoginName
            // 
            this.editLoginName.Location = new System.Drawing.Point(147, 29);
            this.editLoginName.Name = "editLoginName";
            this.editLoginName.Size = new System.Drawing.Size(192, 25);
            this.editLoginName.TabIndex = 26;
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(43, 69);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(56, 23);
            this.lblPwd.TabIndex = 27;
            this.lblPwd.Text = "密码:";
            // 
            // editPwd
            // 
            this.editPwd.Location = new System.Drawing.Point(147, 101);
            this.editPwd.Name = "editPwd";
            this.editPwd.PasswordChar = '*';
            this.editPwd.Size = new System.Drawing.Size(192, 25);
            this.editPwd.TabIndex = 28;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(241, 161);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancel.TabIndex = 31;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(105, 161);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(98, 32);
            this.bt_OK.TabIndex = 30;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 209);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.editPwdInput);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.editLoginName);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.editPwd);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editPwdInput;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.TextBox editLoginName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox editPwd;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
    }
}