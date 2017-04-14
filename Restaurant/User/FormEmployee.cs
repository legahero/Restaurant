using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormEmployee : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn identityCardDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eduLevelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn holdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dimissionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qQDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mSNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addreesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn onjobDataGridViewCheckBoxColumn;

        public FormEmployee()
        {
            InitializeComponent();

            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn.Visible = false;
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identityCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eduLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dimissionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addreesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onjobDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();


            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.aliasDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthDataGridViewTextBoxColumn,
            this.identityCardDataGridViewTextBoxColumn,
            this.eduLevelDataGridViewTextBoxColumn,
            this.holdDateDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.dimissionDateDataGridViewTextBoxColumn,
            this.workAddressDataGridViewTextBoxColumn,
            this.workPhoneDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.qQDataGridViewTextBoxColumn,
            this.mSNDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.mobilePhoneDataGridViewTextBoxColumn,
            this.homePhoneDataGridViewTextBoxColumn,
            this.addreesDataGridViewTextBoxColumn,
            this.onjobDataGridViewCheckBoxColumn});

            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "PersonnelID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 60F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.FillWeight = 60F;
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            this.aliasDataGridViewTextBoxColumn.DataPropertyName = "Alias";
            this.aliasDataGridViewTextBoxColumn.HeaderText = "别名";
            this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            this.aliasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDataGridViewTextBoxColumn
            // 
            this.birthDataGridViewTextBoxColumn.DataPropertyName = "Birth";
            this.birthDataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.birthDataGridViewTextBoxColumn.Name = "birthDataGridViewTextBoxColumn";
            this.birthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identityCardDataGridViewTextBoxColumn
            // 
            this.identityCardDataGridViewTextBoxColumn.DataPropertyName = "IdentityCard";
            this.identityCardDataGridViewTextBoxColumn.HeaderText = "身份证";
            this.identityCardDataGridViewTextBoxColumn.Name = "identityCardDataGridViewTextBoxColumn";
            this.identityCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eduLevelDataGridViewTextBoxColumn
            // 
            this.eduLevelDataGridViewTextBoxColumn.DataPropertyName = "EduLevel";
            this.eduLevelDataGridViewTextBoxColumn.HeaderText = "学历";
            this.eduLevelDataGridViewTextBoxColumn.Name = "eduLevelDataGridViewTextBoxColumn";
            this.eduLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // holdDateDataGridViewTextBoxColumn
            // 
            this.holdDateDataGridViewTextBoxColumn.DataPropertyName = "HoldDate";
            this.holdDateDataGridViewTextBoxColumn.HeaderText = "入职日期";
            this.holdDateDataGridViewTextBoxColumn.Name = "holdDateDataGridViewTextBoxColumn";
            this.holdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "合同日期";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dimissionDateDataGridViewTextBoxColumn
            // 
            this.dimissionDateDataGridViewTextBoxColumn.DataPropertyName = "DimissionDate";
            this.dimissionDateDataGridViewTextBoxColumn.HeaderText = "离职日期";
            this.dimissionDateDataGridViewTextBoxColumn.Name = "dimissionDateDataGridViewTextBoxColumn";
            this.dimissionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workAddressDataGridViewTextBoxColumn
            // 
            this.workAddressDataGridViewTextBoxColumn.DataPropertyName = "WorkAddress";
            this.workAddressDataGridViewTextBoxColumn.HeaderText = "工作地点";
            this.workAddressDataGridViewTextBoxColumn.Name = "workAddressDataGridViewTextBoxColumn";
            this.workAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            this.workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            this.workPhoneDataGridViewTextBoxColumn.HeaderText = "工作电话";
            this.workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            this.workPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "传真";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qQDataGridViewTextBoxColumn
            // 
            this.qQDataGridViewTextBoxColumn.DataPropertyName = "QQ";
            this.qQDataGridViewTextBoxColumn.HeaderText = "QQ";
            this.qQDataGridViewTextBoxColumn.Name = "qQDataGridViewTextBoxColumn";
            this.qQDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSNDataGridViewTextBoxColumn
            // 
            this.mSNDataGridViewTextBoxColumn.DataPropertyName = "MSN";
            this.mSNDataGridViewTextBoxColumn.HeaderText = "MSN";
            this.mSNDataGridViewTextBoxColumn.Name = "mSNDataGridViewTextBoxColumn";
            this.mSNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            this.mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            this.mobilePhoneDataGridViewTextBoxColumn.HeaderText = "手机";
            this.mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            this.mobilePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            this.homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            this.homePhoneDataGridViewTextBoxColumn.HeaderText = "家庭电话";
            this.homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            this.homePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addreesDataGridViewTextBoxColumn
            // 
            this.addreesDataGridViewTextBoxColumn.DataPropertyName = "Addrees";
            this.addreesDataGridViewTextBoxColumn.HeaderText = "家庭地址";
            this.addreesDataGridViewTextBoxColumn.Name = "addreesDataGridViewTextBoxColumn";
            this.addreesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onjobDataGridViewCheckBoxColumn
            // 
            this.onjobDataGridViewCheckBoxColumn.DataPropertyName = "Outjob";
            this.onjobDataGridViewCheckBoxColumn.FalseValue = "０";
            this.onjobDataGridViewCheckBoxColumn.HeaderText = "离职";
            this.onjobDataGridViewCheckBoxColumn.Name = "onjobDataGridViewCheckBoxColumn";
            this.onjobDataGridViewCheckBoxColumn.ReadOnly = true;
            this.onjobDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.onjobDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.onjobDataGridViewCheckBoxColumn.TrueValue = "１";
 
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = m_DbAdaHelper.GetEmployee();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvEmployee.SelectedRows)
            {
                long EmployeeID = Convert.ToInt64(dgvr.Cells["iDDataGridViewTextBoxColumn"].Value);
                m_DbAdaHelper.DeleteEmployee(EmployeeID);

                dgvEmployee.DataSource = m_DbAdaHelper.GetEmployee();
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormEmployeeInfo dlg = new FormEmployeeInfo();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                m_DbAdaHelper.AddEmployee(dlg.m_Personnel);
                m_DbAdaHelper.AddEmployeeResume(dlg.m_PersonnelResume);

                dgvEmployee.DataSource = m_DbAdaHelper.GetEmployee();
            }
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            ModEmployeeInfo();
        }
        void ModEmployeeInfo()
        {
            if (dgvEmployee.CurrentRow != null)
            {
                FormEmployeeInfo dlg = new FormEmployeeInfo();

                DataRowView drv = (DataRowView)dgvEmployee.CurrentRow.DataBoundItem;

                dlg.m_Personnel.Name = drv["Name"].ToString();
                dlg.m_Personnel.Alias = drv["Alias"].ToString();
                dlg.m_Personnel.Addrees = drv["Addrees"].ToString();
                if (!Convert.IsDBNull(drv["Birth"]))
                {
                    dlg.m_Personnel.Birth = Convert.ToDateTime(drv["Birth"]);
                }
                dlg.m_Personnel.EduLevel = drv["EduLevel"].ToString();
                dlg.m_Personnel.EMail = drv["EMail"].ToString();
                dlg.m_Personnel.Fax = drv["Fax"].ToString();

                if (!Convert.IsDBNull(drv["HoldDate"]))
                {
                    dlg.m_Personnel.HoldDate = Convert.ToDateTime(drv["HoldDate"]);
                }
                dlg.m_Personnel.HomePhone = drv["HomePhone"].ToString();
                dlg.m_Personnel.IdentityCard = drv["IdentityCard"].ToString();
                dlg.m_Personnel.MobilePhone = drv["MobilePhone"].ToString();
                dlg.m_Personnel.MSN = drv["MSN"].ToString();

                if (!Convert.IsDBNull(drv["Outjob"]))
                {
                    dlg.m_Personnel.Outjob = Convert.ToInt32(drv["Outjob"]);
                }
                dlg.m_Personnel.PersonnelID = Convert.ToInt32(drv["PersonnelID"]);
                dlg.m_Personnel.QQ = drv["QQ"].ToString();
                dlg.m_Personnel.Sex = drv["Sex"].ToString();
                dlg.m_Personnel.WorkAddress = drv["WorkAddress"].ToString();
                dlg.m_Personnel.WorkID = drv["WorkID"].ToString();
                dlg.m_Personnel.WorkPhone = drv["WorkPhone"].ToString();

                if (!Convert.IsDBNull(drv["Contract"]))
                {
                    dlg.m_Personnel.ContractDate = Convert.ToDateTime(drv["Contract"]);
                }
                if (!Convert.IsDBNull(drv["DimissionDate"]))
                {
                    dlg.m_Personnel.DimissionDate = Convert.ToDateTime(drv["DimissionDate"]);
                }

                dlg.m_PersonnelResume.PersonnelID = dlg.m_Personnel.PersonnelID;

                CPersonnelResume PersonnelResume = m_DbAdaHelper.GetEmployeeResume(dlg.m_Personnel.PersonnelID);
                if (PersonnelResume!=null) 
                    dlg.m_PersonnelResume = PersonnelResume;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    m_DbAdaHelper.UpdateEmployee(dlg.m_Personnel);
                    m_DbAdaHelper.UpdateEmployeeResume(dlg.m_PersonnelResume);
                }
                dgvEmployee.DataSource = m_DbAdaHelper.GetEmployee();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbQName.Text))
            {
                foreach (DataGridViewRow dgrv in dgvEmployee.Rows)
                {
                    if (dgrv.Cells["nameDataGridViewTextBoxColumn"].Value.ToString().IndexOf(tbQName.Text) > 0)
                    {
                        dgvEmployee.CurrentCell = dgrv.Cells["nameDataGridViewTextBoxColumn"];
                        break;
                    }
                }
            }
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModEmployeeInfo();
        }
    }
}