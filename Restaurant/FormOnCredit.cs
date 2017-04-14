using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormOnCredit : Form
    {
        BindingSource bs;

        public FormOnCredit()
        {
            InitializeComponent();

            InitView();
        }

        private void InitView()
        {
            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnOnCreditID = new DataGridViewTextBoxColumn();
            ColumnOnCreditID.DataPropertyName = "OnCreditID";
            ColumnOnCreditID.Name = "ColumnOnCreditID";
            ColumnOnCreditID.HeaderText = "GoodsID";
            ColumnOnCreditID.Visible = false;
            ColumnOnCreditID.Width = 30;
            ColumnOnCreditID.FillWeight = 40F;
            ColumnOnCreditID.ReadOnly = true;
            ColumnOnCreditID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnOnCreditID);

            DataGridViewTextBoxColumn ColumnClientName = new DataGridViewTextBoxColumn();
            ColumnClientName.DataPropertyName = "ClientName";
            ColumnClientName.Name = "ColumnClientName";
            ColumnClientName.HeaderText = "客户";
            ColumnClientName.Width = 80;
            ColumnClientName.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnClientName);

            DataGridViewTextBoxColumn ColumnCompany = new DataGridViewTextBoxColumn();
            ColumnCompany.DataPropertyName = "Company";
            ColumnCompany.Name = "ColumnCompany";
            ColumnCompany.HeaderText = "公司";
            ColumnCompany.Width = 120;
            ColumnCompany.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnCompany);

            DataGridViewTextBoxColumn ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnAddress.DataPropertyName = "Address";
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.HeaderText = "地址";
            ColumnAddress.Width = 150;
            ColumnAddress.DisplayIndex = 3;
            dgvMain.Columns.Add(ColumnAddress);

            DataGridViewTextBoxColumn ColumnPostCode = new DataGridViewTextBoxColumn();
            ColumnPostCode.DataPropertyName = "PostCode";
            ColumnPostCode.Name = "ColumnPostCode";
            ColumnPostCode.HeaderText = "邮编";
            ColumnPostCode.Width = 70;
            ColumnPostCode.DisplayIndex = 4;
            ColumnPostCode.Visible = false;
            dgvMain.Columns.Add(ColumnPostCode);

            DataGridViewTextBoxColumn ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnPhone.DataPropertyName = "Phone";
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.HeaderText = "电话";
            ColumnPhone.Width = 120;
            ColumnPhone.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnPhone);

            DataGridViewTextBoxColumn ColumnMobilePhone = new DataGridViewTextBoxColumn();
            ColumnMobilePhone.DataPropertyName = "MobilePhone";
            ColumnMobilePhone.Name = "ColumnMobilePhone";
            ColumnMobilePhone.HeaderText = "手机";
            ColumnMobilePhone.Width = 120;
            ColumnMobilePhone.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnMobilePhone);

            DataGridViewTextBoxColumn ColumnOnCreditLimit = new DataGridViewTextBoxColumn();
            ColumnOnCreditLimit.DataPropertyName = "OnCreditLimit";
            ColumnOnCreditLimit.Name = "ColumnOnCreditLimit";
            ColumnOnCreditLimit.HeaderText = "上限金额";
            ColumnOnCreditLimit.Width = 120;
            ColumnOnCreditLimit.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnOnCreditLimit);

            DataGridViewTextBoxColumn ColumnOnCreditSum = new DataGridViewTextBoxColumn();
            ColumnOnCreditSum.DataPropertyName = "OnCreditSum";
            ColumnOnCreditSum.Name = "ColumnOnCreditSum";
            ColumnOnCreditSum.HeaderText = "已挂金额";
            ColumnOnCreditSum.Width = 120;
            ColumnOnCreditSum.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnOnCreditSum);

            DataGridViewTextBoxColumn ColumnSurplus = new DataGridViewTextBoxColumn();
            ColumnSurplus.DataPropertyName = "Surplus";
            ColumnSurplus.Name = "ColumnSurplus";
            ColumnSurplus.HeaderText = "可挂金额";
            ColumnSurplus.Width = 70;
            ColumnSurplus.DisplayIndex = 9;
            dgvMain.Columns.Add(ColumnSurplus);

            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 150;
            ColumnRemark.DisplayIndex = 10;
            dgvMain.Columns.Add(ColumnRemark);

        }
        private void FormOnCredit_Load(object sender, EventArgs e)
        {
            bs = new BindingSource();

            ShowOnCredit();
        }

        void ShowOnCredit()
        {

            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetOnCredit();
            
            dgvMain.DataSource = bs;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int OnCreditID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnOnCreditID"].Value);

                if (CGlobalInstance.Instance.DbAdaHelper.DeleteOnCredit(OnCreditID))
                {
                    ShowOnCredit();
                }
            }
        }

        private void toolStripButtonRecord_Click(object sender, EventArgs e)
        {
            FormOnCreditRecord dlg = new FormOnCreditRecord();

            dlg.ShowDialog();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormOnCreditItem dlg = new FormOnCreditItem();

            dlg.ShowDialog();
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int OnCreditID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnOnCreditID"].Value);

                FormOnCreditItem dlg = new FormOnCreditItem();

                dlg.m_OnCreditItem.OnCreditID = OnCreditID;

                dlg.m_OnCreditItem.ClientName = dgvMain.CurrentRow.Cells["ColumnClientName"].Value.ToString();
                dlg.m_OnCreditItem.Address = dgvMain.CurrentRow.Cells["ColumnAddress"].Value.ToString();
                dlg.m_OnCreditItem.Company = dgvMain.CurrentRow.Cells["ColumnCompany"].Value.ToString();
                dlg.m_OnCreditItem.PostCode = dgvMain.CurrentRow.Cells["ColumnPostCode"].Value.ToString();

                dlg.m_OnCreditItem.Phone = dgvMain.CurrentRow.Cells["ColumnPhone"].Value.ToString();
                dlg.m_OnCreditItem.MobilePhone = dgvMain.CurrentRow.Cells["ColumnMobilePhone"].Value.ToString();
                try
                {
                    dlg.m_OnCreditItem.OnCreditLimit = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnOnCreditLimit"].Value);
                    dlg.m_OnCreditItem.OnCreditSum = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnOnCreditSum"].Value);
                }
                catch
                {
                }
                dlg.m_OnCreditItem.Remark = dgvMain.CurrentRow.Cells["ColumnRemark"].Value.ToString();

                dlg.ShowDialog();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int OnCreditID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnOnCreditID"].Value);
                double OnCreditSum = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnOnCreditSum"].Value);


                FormRepayment dlg = new FormRepayment();

                dlg.ClientName = dgvMain.CurrentRow.Cells["ColumnClientName"].Value.ToString();
                dlg.Company = dgvMain.CurrentRow.Cells["ColumnCompany"].Value.ToString();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string Employee = "";//有待修改
                    string Remark = dlg.Remark;

                    if (CGlobalInstance.Instance.DbAdaHelper.OnCreditRepayment(OnCreditID, OnCreditSum, -dlg.Value, Employee, Remark))
                    {
                        MessageBox.Show("还款成功!");
                    }
                    else
                    {
                        MessageBox.Show("还款失败!");
                    }
                }
            }
        }
    }
}