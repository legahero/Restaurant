using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MixLib;
using OleDbOperate;

namespace UserModule
{
    public partial class FrmModPwd : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        public FrmModPwd()
        {
            InitializeComponent();
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            if (tb_NewPwd.Text.Trim().Length < 6)
            {
                MessageBox.Show("新密码长度不足6位,请重新输入新密码！");
            }
            else if (tb_NewPwd.Text != tb_Confirm.Text)
            {
                MessageBox.Show("确认密码与新密码不相符!请重新输入。");
            }
            else
            {
                if (m_DbAdaHelper.GetUserInfo(tb_User.Text, tb_OldPwd.Text) == null)
                {
                    MessageBox.Show("输入用户或旧密码出错!请重新输入。");
                }
                else
                {
                    if (m_DbAdaHelper.ModifyPwd(tb_User.Text, tb_OldPwd.Text, tb_NewPwd.Text) != true)
                    {
                        MessageBox.Show("修改密码失败！");
                    }
                    else
                    {
                        CAppOption.m_sUser = tb_User.Text;
                        if (CAppOption.m_bSavePwd == true)
                        {
                            CAppOption.m_sPwd = tb_NewPwd.Text;
                        }
                        MessageBox.Show("修改密码成功！");

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;

                    }
                }
            }
        }        
    }
}