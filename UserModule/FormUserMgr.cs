using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MixFunc;

namespace UserModule
{
    public partial class FormUserMgr : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        public FormUserMgr()
        {
            InitializeComponent();
        }

        private void FormUserMgr_Load(object sender, EventArgs e)
        {
            dgvUserLogin.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnPersonnelID = new DataGridViewTextBoxColumn();
            ColumnPersonnelID.DataPropertyName = "PersonnelID";
            ColumnPersonnelID.Name = "ColumnPersonnelID";
            ColumnPersonnelID.HeaderText = "PersonnelID";
            ColumnPersonnelID.Visible = false;
            ColumnPersonnelID.Width = 30;
            ColumnPersonnelID.FillWeight = 40F;
            ColumnPersonnelID.ReadOnly = true;
            ColumnPersonnelID.Visible = false;
            dgvUserLogin.Columns.Add(ColumnPersonnelID);

            DataGridViewTextBoxColumn ColumnWorkID = new DataGridViewTextBoxColumn();
            ColumnWorkID.DataPropertyName = "WorkID";
            ColumnWorkID.Name = "ColumnWorkID";
            ColumnWorkID.HeaderText = "工号";
            ColumnWorkID.Width = 150;
            ColumnWorkID.FillWeight = 40F;
            ColumnWorkID.ReadOnly = true;
            dgvUserLogin.Columns.Add(ColumnWorkID);

            DataGridViewTextBoxColumn ColumnName = new DataGridViewTextBoxColumn();
            ColumnName.DataPropertyName = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.HeaderText = "姓名";
            ColumnName.Width = 150;
            ColumnName.FillWeight = 40F;
            ColumnName.ReadOnly = true;
            dgvUserLogin.Columns.Add(ColumnName);

            DataGridViewTextBoxColumn ColumnLoginName = new DataGridViewTextBoxColumn();
            ColumnLoginName.DataPropertyName = "LoginName";
            ColumnLoginName.Name = "ColumnLoginName";
            ColumnLoginName.HeaderText = "登录名";
            ColumnLoginName.Width = 150;
            ColumnLoginName.FillWeight = 40F;
            ColumnLoginName.ReadOnly = true;
            dgvUserLogin.Columns.Add(ColumnLoginName);

            DataGridViewCheckBoxColumn ColumnIsLogin = new DataGridViewCheckBoxColumn();
            ColumnIsLogin.DataPropertyName = "IsLogin";
            ColumnIsLogin.Name = "ColumnIsLogin";
            ColumnIsLogin.HeaderText = "是否可登录";
            ColumnIsLogin.Width = 150;
            ColumnIsLogin.FillWeight = 40F;
            ColumnIsLogin.ReadOnly = true;
            ColumnIsLogin.FalseValue = 0;
            ColumnIsLogin.TrueValue = 1;
            dgvUserLogin.Columns.Add(ColumnIsLogin);


            dgvUserLogin.DataSource = m_DbAdaHelper.GetUserLogin();
        }

        private void toolStripButtonPWDInit_Click(object sender, EventArgs e)
        {
            if (dgvUserLogin.CurrentRow != null)
            {
                int IsLogin = Convert.ToInt32(dgvUserLogin.CurrentRow.Cells["ColumnIsLogin"].Value);
                if (IsLogin == 0)
                {
                    MessageBox.Show("该职员没有有登录权限!");
                    return;
                }

                long PersonnelID = Convert.ToInt64(dgvUserLogin.CurrentRow.Cells["ColumnPersonnelID"].Value);

                m_DbAdaHelper.LoginPwdInit(PersonnelID);
            }
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvUserLogin.CurrentRow != null)
            {
                long PersonnelID = Convert.ToInt64(dgvUserLogin.CurrentRow.Cells["ColumnPersonnelID"].Value);

                m_DbAdaHelper.DelLogin(PersonnelID);

                dgvUserLogin.DataSource = m_DbAdaHelper.GetUserLogin();
            }
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            if (dgvUserLogin.CurrentRow != null)
            {
                int IsLogin=Convert.ToInt32(dgvUserLogin.CurrentRow.Cells["ColumnIsLogin"].Value);
                if (IsLogin == 1)
                {
                    MessageBox.Show("该职员已经有登录权限!");
                    return;
                }
                long PersonnelID = Convert.ToInt64(dgvUserLogin.CurrentRow.Cells["ColumnPersonnelID"].Value);

                FormUser dlg = new FormUser();

                if(dlg.ShowDialog()==DialogResult.OK)
                {
                    m_DbAdaHelper.AddLogin(PersonnelID, dlg.User,CYyScrypt.Encrypt(dlg.Pwd));

                    dgvUserLogin.DataSource = m_DbAdaHelper.GetUserLogin();
                }
            }
        }
    }
}