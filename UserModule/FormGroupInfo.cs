using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormGroupInfo : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;
        public FormGroupInfo()
        {
            InitializeComponent();
        }

        private void FormGroupInfo_Load(object sender, EventArgs e)
        {
            dgvGroupInfo.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnGroupID = new DataGridViewTextBoxColumn();
            ColumnGroupID.DataPropertyName = "GroupID";
            ColumnGroupID.Name = "ColumnGroupID";
            ColumnGroupID.HeaderText = "GroupID";
            ColumnGroupID.Visible = false;
            ColumnGroupID.Width = 30;
            ColumnGroupID.FillWeight = 40F;
            ColumnGroupID.ReadOnly = true;
            ColumnGroupID.Visible = false;
            dgvGroupInfo.Columns.Add(ColumnGroupID);

            DataGridViewTextBoxColumn ColumnGroupName = new DataGridViewTextBoxColumn();
            ColumnGroupName.DataPropertyName = "GroupName";
            ColumnGroupName.Name = "ColumnGroupName";
            ColumnGroupName.HeaderText = "部门";
            ColumnGroupName.Width = 150;
            ColumnGroupName.FillWeight = 40F;
            ColumnGroupName.ReadOnly = true;
            dgvGroupInfo.Columns.Add(ColumnGroupName);

            DataGridViewTextBoxColumn ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnAddress.DataPropertyName = "Address";
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.HeaderText = "部门地址";
            ColumnAddress.Visible = false;
            ColumnAddress.Width = 300;
            ColumnAddress.FillWeight = 40F;
            ColumnAddress.ReadOnly = true;
            dgvGroupInfo.Columns.Add(ColumnAddress);

            
            DataGridViewTextBoxColumn ColumnDescription = new DataGridViewTextBoxColumn();
            ColumnDescription.DataPropertyName = "Description";
            ColumnDescription.Name = "ColumnDescription";
            ColumnDescription.HeaderText = "部门描述";
            ColumnDescription.Width = 200;
            ColumnDescription.FillWeight = 40F;
            ColumnDescription.ReadOnly = true;
            dgvGroupInfo.Columns.Add(ColumnDescription);

            //
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

            DataGridViewTextBoxColumn ColumnQQ = new DataGridViewTextBoxColumn();
            ColumnQQ.DataPropertyName = "QQ";
            ColumnQQ.Name = "ColumnQQ";
            ColumnQQ.HeaderText = "QQ";
            ColumnQQ.Width = 80;
            ColumnQQ.FillWeight = 40F;
            ColumnQQ.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnQQ);

            DataGridViewTextBoxColumn ColumnEMail = new DataGridViewTextBoxColumn();
            ColumnEMail.DataPropertyName = "EMail";
            ColumnEMail.Name = "ColumnEMail";
            ColumnEMail.HeaderText = "EMail";
            ColumnEMail.Width = 120;
            ColumnEMail.FillWeight = 40F;
            ColumnEMail.ReadOnly = true;
            dgvEmployee.Columns.Add(ColumnEMail);

            DataGridViewTextBoxColumn MobilePhone = new DataGridViewTextBoxColumn();
            MobilePhone.DataPropertyName = "MobilePhone";
            MobilePhone.Name = "ColumnMobilePhone";
            MobilePhone.HeaderText = "手机";
            MobilePhone.Width = 150;
            MobilePhone.FillWeight = 40F;
            MobilePhone.ReadOnly = true;
            dgvEmployee.Columns.Add(MobilePhone);

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

            cbEmployee.DataSource=m_DbAdaHelper.GetEmployee();
            cbEmployee.DisplayMember = "Name";
            cbEmployee.ValueMember = "PersonnelID";

            DataRefresh();
            
        }
        void DataRefresh()
        {
            dgvGroupInfo.DataSource = m_DbAdaHelper.GetGroupInfo();
            ShowGroupMember();
        }

        void ShowGroupMember()
        {
            if (dgvGroupInfo.CurrentRow != null)
            {
                long GroupID = Convert.ToInt64(dgvGroupInfo.CurrentRow.Cells["ColumnGroupID"].Value);

                dgvEmployee.DataSource=m_DbAdaHelper.GetGroupMember(GroupID);
            }
        }

        private void dgvGroupInfo_SelectionChanged(object sender, EventArgs e)
        {
            ShowGroupMember();
        }

        private void toolStripButtonDelEm_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.CurrentRow != null && dgvEmployee.CurrentRow != null)
            {
                long GroupID = Convert.ToInt64(dgvGroupInfo.CurrentRow.Cells["ColumnGroupID"].Value);
                long PersonnelID = Convert.ToInt64(dgvEmployee.CurrentRow.Cells["ColumnPersonnelID"].Value);

                if (m_DbAdaHelper.DelGroupMember(GroupID, PersonnelID))
                {
                    ShowGroupMember();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.CurrentRow != null )
            {
                long GroupID = Convert.ToInt64(dgvGroupInfo.CurrentRow.Cells["ColumnGroupID"].Value);
                if (cbEmployee.SelectedValue!=null)
                {
                    long EmployeeID = Convert.ToInt64(cbEmployee.SelectedValue);

                    if (m_DbAdaHelper.AddGroupMember(GroupID, EmployeeID))
                    {
                        ShowGroupMember();
                    }
                }
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormDeptInfo dlg = new FormDeptInfo();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dlg.GroupName))
                {
                    if (m_DbAdaHelper.AddGroupInfo(dlg.GroupName, dlg.Address, dlg.Description))
                    {
                        DataRefresh();
                    }
                    else
                    {
                        MessageBox.Show("添加部门失败！");
                    }

                }
            }

        }
        void ModGroupInfo()
        {
            if (dgvGroupInfo.CurrentRow != null)
            {
                long GroupID = Convert.ToInt64(dgvGroupInfo.CurrentRow.Cells["ColumnGroupID"].Value);
                string GroupName = dgvGroupInfo.CurrentRow.Cells["ColumnGroupName"].Value.ToString();
                string Address = dgvGroupInfo.CurrentRow.Cells["ColumnAddress"].Value.ToString();
                string Description = dgvGroupInfo.CurrentRow.Cells["ColumnDescription"].Value.ToString();

                FormDeptInfo dlg = new FormDeptInfo();
                dlg.GroupID = GroupID;
                dlg.GroupName = GroupName;
                dlg.Address = Address;
                dlg.Description = Description;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(dlg.GroupName))
                    {
                        if (m_DbAdaHelper.UpdateGroupInfo(GroupID, dlg.GroupName, dlg.Address, dlg.Description))
                        {
                            DataRefresh();
                        }
                        else
                        {
                            MessageBox.Show("修改部门失败！");
                        }

                    }
                }
            }
        }
        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            ModGroupInfo();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvGroupInfo.CurrentRow != null)
            {
                long GroupID = Convert.ToInt64(dgvGroupInfo.CurrentRow.Cells["ColumnGroupID"].Value);

                if (m_DbAdaHelper.DelGroupInfo(GroupID))
                {
                    DataRefresh();
                }
                else
                {
                    MessageBox.Show("删除部门失败！");
                }
            }
        }

        private void dgvGroupInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModGroupInfo();
        }

    }
}