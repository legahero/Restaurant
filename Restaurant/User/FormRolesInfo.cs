using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormRolesInfo : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        public FormRolesInfo()
        {
            InitializeComponent();
        }

        private void FormRolesInfo_Load(object sender, EventArgs e)
        {
            dgvRolesInfo.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnRoleID = new DataGridViewTextBoxColumn();
            ColumnRoleID.DataPropertyName = "RoleID";
            ColumnRoleID.Name = "ColumnRoleID";
            ColumnRoleID.HeaderText = "RoleID";
            ColumnRoleID.Visible = false;
            ColumnRoleID.Width = 30;
            ColumnRoleID.FillWeight = 40F;
            ColumnRoleID.ReadOnly = true;
            ColumnRoleID.Visible = false;
            dgvRolesInfo.Columns.Add(ColumnRoleID);

            DataGridViewTextBoxColumn ColumnRoleName = new DataGridViewTextBoxColumn();
            ColumnRoleName.DataPropertyName = "RoleName";
            ColumnRoleName.Name = "ColumnRoleName";
            ColumnRoleName.HeaderText = "职位";
            ColumnRoleName.Width = 150;
            ColumnRoleName.FillWeight = 40F;
            ColumnRoleName.ReadOnly = true;
            dgvRolesInfo.Columns.Add(ColumnRoleName);

            DataGridViewTextBoxColumn ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnDescription.DataPropertyName = "Description";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.HeaderText = "部门描述";
            ColumnDescription.Width = 200;
            ColumnDescription.FillWeight = 40F;
            ColumnDescription.ReadOnly = true;
            dgvRolesInfo.Columns.Add(ColumnDescription);


            dgvEmployee.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnPersonnelID = new DataGridViewTextBoxColumn();
            ColumnPersonnelID.DataPropertyName = "PersonnelID";
            ColumnPersonnelID.Name = "ColumnPersonnelID";
            ColumnPersonnelID.HeaderText = "PersonnelID";
            ColumnPersonnelID.Width = 20;
            ColumnPersonnelID.FillWeight = 40F;
            ColumnPersonnelID.Visible = false;
            ColumnPersonnelID.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnPersonnelID);

            DataGridViewTextBoxColumn ColumnName = new DataGridViewTextBoxColumn();
            ColumnName.DataPropertyName = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.HeaderText = "职员";
            ColumnName.Width = 80;
            ColumnName.FillWeight = 40F;
            ColumnName.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnName);

            DataGridViewTextBoxColumn ColumnWorkID = new DataGridViewTextBoxColumn();
            ColumnWorkID.DataPropertyName = "WorkID";
            ColumnWorkID.Name = "ColumnWorkID";
            ColumnWorkID.HeaderText = "工号";
            ColumnWorkID.Width = 80;
            ColumnWorkID.FillWeight = 40F;
            ColumnWorkID.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnWorkID);

            DataGridViewTextBoxColumn ColumnSex = new DataGridViewTextBoxColumn();
            ColumnSex.DataPropertyName = "Sex";
            ColumnSex.Name = "ColumnSex";
            ColumnSex.HeaderText = "性别";
            ColumnSex.Width = 80;
            ColumnSex.FillWeight = 40F;
            ColumnSex.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnSex);

            DataGridViewTextBoxColumn ColumnEduLevel = new DataGridViewTextBoxColumn();
            ColumnEduLevel.DataPropertyName = "EduLevel";
            ColumnEduLevel.Name = "ColumnEduLevel";
            ColumnEduLevel.HeaderText = "教育水平";
            ColumnEduLevel.Width = 100;
            ColumnEduLevel.FillWeight = 40F;
            ColumnEduLevel.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnEduLevel);

            DataGridViewTextBoxColumn ColumnHoldDate = new DataGridViewTextBoxColumn();
            ColumnHoldDate.DataPropertyName = "HoldDate";
            ColumnHoldDate.Name = "ColumnHoldDate";
            ColumnHoldDate.HeaderText = "任职日期";
            ColumnHoldDate.Width = 120;
            ColumnHoldDate.FillWeight = 40F;
            ColumnHoldDate.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnHoldDate);

            DataGridViewTextBoxColumn ColumnContract = new DataGridViewTextBoxColumn();
            ColumnContract.DataPropertyName = "Contract";
            ColumnContract.Name = "ColumnContract";
            ColumnContract.HeaderText = "合同到期";
            ColumnContract.Width = 120;
            ColumnContract.FillWeight = 40F;
            ColumnContract.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnContract);


            cbEmployee.DataSource = m_DbAdaHelper.GetEmployee();
            cbEmployee.DisplayMember = "Name";
            cbEmployee.ValueMember = "PersonnelID";

            DataRefresh();
        }
        void DataRefresh()
        {
            dgvRolesInfo.DataSource = m_DbAdaHelper.GetRolesInfo();
            ShowRolesMember();
        }

        void ShowRolesMember()
        {
            if (dgvRolesInfo.CurrentRow != null)
            {
                long RoleID = Convert.ToInt64(dgvRolesInfo.CurrentRow.Cells["ColumnRoleID"].Value);

                dgvEmployee.DataSource = m_DbAdaHelper.GetRolesMember(RoleID);
            }
        }

        private void toolStripButtonDelEm_Click(object sender, EventArgs e)
        {
            if (dgvRolesInfo.CurrentRow != null && dgvEmployee.CurrentRow != null)
            {
                long RoleID = Convert.ToInt64(dgvRolesInfo.CurrentRow.Cells["ColumnRoleID"].Value);
                long PersonnelID = Convert.ToInt64(dgvEmployee.CurrentRow.Cells["ColumnPersonnelID"].Value);

                if (m_DbAdaHelper.DelRoleMember(RoleID, PersonnelID))
                {
                    ShowRolesMember();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dgvRolesInfo.CurrentRow != null)
            {
                long RoleID = Convert.ToInt64(dgvRolesInfo.CurrentRow.Cells["ColumnRoleID"].Value);
                if (cbEmployee.SelectedValue != null)
                {
                    long EmployeeID = Convert.ToInt64(cbEmployee.SelectedValue);

                    if (m_DbAdaHelper.AddRoleMember(RoleID, EmployeeID))
                    {
                        ShowRolesMember();
                    }
                }
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormRoleProperty dlg = new FormRoleProperty();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dlg.RoleName))
                {
                    if (m_DbAdaHelper.AddRoleInfo(dlg.RoleName, dlg.Description))
                    {
                        DataRefresh();
                    }
                    else
                    {
                        MessageBox.Show("添加职位失败！");
                    }

                }
            }
        }
        void ModRoleInfo()
        {
            if (dgvRolesInfo.CurrentRow != null)
            {
                long RoleID = Convert.ToInt64(dgvRolesInfo.CurrentRow.Cells["ColumnRoleID"].Value);
                string RoleName = dgvRolesInfo.CurrentRow.Cells["ColumnRoleName"].Value.ToString();
                string Description = dgvRolesInfo.CurrentRow.Cells["ColumnDescription"].Value.ToString();

                FormRoleProperty dlg = new FormRoleProperty();
                dlg.RoleID = RoleID;
                dlg.RoleName = RoleName;
                dlg.Description = Description;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dlg.RoleName))
                    {
                        if (m_DbAdaHelper.UpdateRoleInfo(RoleID, dlg.RoleName, dlg.Description))
                        {
                            DataRefresh();
                        }
                        else
                        {
                            MessageBox.Show("修改职位失败！");
                        }

                    }
                }
            }
        }
        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            ModRoleInfo();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvRolesInfo.CurrentRow != null)
            {
                long RoleID = Convert.ToInt64(dgvRolesInfo.CurrentRow.Cells["ColumnRoleID"].Value);

                if (m_DbAdaHelper.DelRoleInfo(RoleID))
                {
                    DataRefresh();
                }
                else
                {
                    MessageBox.Show("删除职位失败！");
                }
            }
        }

        private void dgvRolesInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModRoleInfo();
        }

        private void dgvRolesInfo_SelectionChanged(object sender, EventArgs e)
        {
            ShowRolesMember();
        }

        
    }
}