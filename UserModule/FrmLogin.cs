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
    public partial class FrmLogin : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;
        public _tagUserInfo m_UserInfo = null;

        public bool m_bSavePwd = false;
        public string m_sUser = "";
        public string m_sPwd = "";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            m_UserInfo = m_DbAdaHelper.GetUserInfo(tb_User.Text, tb_PWD.Text);
            if (m_UserInfo!=null)
            {
                if (m_bSavePwd == true)
                {

                    m_sPwd = tb_PWD.Text;
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("用户登录名或密码错误，请重新输入！");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //MixLib.FormOption.ApplyOption(this);

            tb_User.Text = m_sUser;
            if (m_bSavePwd == true)
            {
                cb_Save.Checked = true;
                tb_PWD.Text = m_sPwd;
            }
        }

        private void cb_Save_CheckedChanged(object sender, EventArgs e)
        {
            m_bSavePwd = cb_Save.Checked;			
        }

        private void btModPwd_Click(object sender, EventArgs e)
        {
            FrmModPwd dlg = new FrmModPwd();
            dlg.m_User = tb_User.Text;
            dlg.ShowDialog();
        }

    }
}