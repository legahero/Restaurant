using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormUser : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        public string User="";
        public string Pwd = "";
        public FormUser()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(editLoginName.Text))
            {
                MessageBox.Show("登录名不能为空!","提示");
                return;
            }
            if (editPwdInput.Text != editPwd.Text||string.IsNullOrEmpty(editPwdInput.Text))
            {
                MessageBox.Show("确认密码不相符(不能为空)!","提示");
                return;
            }
            Pwd = editPwdInput.Text;
            User = editLoginName.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}