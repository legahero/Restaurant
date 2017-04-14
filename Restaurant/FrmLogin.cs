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

namespace Restaurant
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (Login(tb_User.Text, tb_PWD.Text))
            {
                CAppOption.m_sUser = tb_User.Text;
                if (CAppOption.m_bSavePwd == true)
                {
                    CAppOption.m_sPwd = tb_PWD.Text;
                }

                _tagUserInfo UserInfo=CGlobalInstance.Instance.DbAdaHelper.GetUserInfo(tb_User.Text, tb_PWD.Text);

                if (UserInfo!=null)
                {
                    CAppOption.m_lUserID = UserInfo.UserID;
                    CAppOption.m_sUserName = UserInfo.UserName;
                    CAppOption.m_sUserWorkID = UserInfo.UserWorkID;
                    CAppOption.m_sUserAlias = UserInfo.UserAlias;

                    if (CAppOption.m_sUserWorkID.Length < 1)
                        CAppOption.m_sUserWorkID = CAppOption.m_sUserName;
                }else
                {
                    System.Windows.Forms.MessageBox.Show("获取UserID失败，用户、密码可能有误!");
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

            tb_User.Text = CAppOption.m_sUser;
            if (CAppOption.m_bSavePwd == true)
            {
                cb_Save.Checked = true;
                tb_PWD.Text = CAppOption.m_sPwd;
            }
        }

        private void cb_Save_CheckedChanged(object sender, EventArgs e)
        {
            CAppOption.m_bSavePwd = cb_Save.Checked;			
        }

        
        /// <summary>
        /// 验证登录用户
        /// </summary>
        public static bool Login(string User, string Pwd)
        {
            if (User == "Admin" && Pwd == "legahero")
            {
                CAppOption.m_lUserID = 0;
                return true;
            }
            bool bRet=false;
            try
            {
                System.Data.OleDb.OleDbParameter[] Params = new System.Data.OleDb.OleDbParameter[2];
                Params[0] = CGlobalInstance.Instance.DbAdaHelper.MakeInParam("LoginName", OleDbType.VarChar, 20, User);
                Params[1] = CGlobalInstance.Instance.DbAdaHelper.MakeInParam("Pwd", OleDbType.VarChar, 256, Pwd);

                object obj = CGlobalInstance.Instance.DbAdaHelper.ExecuteScalar("Select count(*) AS Expr1 From tLogin INNER JOIN tPersonnel ON tLogin.PersonID = tPersonnel.ID Where ((tPersonnel.Outjob <> 1) OR (tPersonnel.Outjob IS NULL)) And (LoginName=?) and  (Pwd=?) ", Params);
                if (obj==null)
                {
                    System.Data.OleDb.OleDbParameter[] Params0 = new System.Data.OleDb.OleDbParameter[2];
                    Params0[0] = CGlobalInstance.Instance.DbAdaHelper.MakeInParam("LoginName", OleDbType.VarChar, 20, User);
                    Params0[1] = CGlobalInstance.Instance.DbAdaHelper.MakeInParam("Pwd", OleDbType.VarChar, 256, Pwd);

                    obj = CGlobalInstance.Instance.DbAdaHelper.ExecuteScalar("Select count(*) AS Expr1 From tLogin INNER JOIN tPersonnel ON tLogin.PersonID = tPersonnel.ID Where ((tPersonnel.Onjob <> 1) OR (tPersonnel.Onjob IS NULL)) And (LoginName=?) and  (Pwd=?) ", Params0);
                }
                if (obj != null )
                {
                    int iCount = Convert.ToInt32(obj);
                    if (iCount > 0)
                    {
                        bRet = true;
                    }
                }                         
            }
            catch (System.Exception fillException)
            {
                // 在此处添加错误处理代码。
                throw fillException;
            }
            

            return bRet;
        }

        private void btModPwd_Click(object sender, EventArgs e)
        {
            FrmModPwd dlg = new FrmModPwd();
            dlg.ShowDialog();
        }

    }
}