using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormAssociator : Form
    {
        BindingSource bs;

        public FormAssociator()
        {
            InitializeComponent();
            InitView();
        }
        private void InitView()
        {
            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnAssociatorID = new DataGridViewTextBoxColumn();
            ColumnAssociatorID.DataPropertyName = "AssociatorID";
            ColumnAssociatorID.Name = "ColumnAssociatorID";
            ColumnAssociatorID.HeaderText = "AssociatorID";
            ColumnAssociatorID.Visible = false;
            ColumnAssociatorID.Width = 30;
            ColumnAssociatorID.FillWeight = 40F;
            ColumnAssociatorID.ReadOnly = true;
            ColumnAssociatorID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnAssociatorID);

            DataGridViewTextBoxColumn ColumnCardID = new DataGridViewTextBoxColumn();
            ColumnCardID.DataPropertyName = "CardID";
            ColumnCardID.Name = "ColumnCardID";
            ColumnCardID.HeaderText = "卡号";
            ColumnCardID.Width = 70;
            ColumnCardID.ReadOnly = true;
            ColumnCardID.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnCardID);

            DataGridViewTextBoxColumn ColumnCardPwd = new DataGridViewTextBoxColumn();
            ColumnCardPwd.DataPropertyName = "CardPwd";
            ColumnCardPwd.Name = "ColumnCardPwd";
            ColumnCardPwd.HeaderText = "密码";
            ColumnCardPwd.Width = 70;
            ColumnCardPwd.ReadOnly = true;
            ColumnCardPwd.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnCardPwd);

            DataGridViewTextBoxColumn ColumnClassifyID = new DataGridViewTextBoxColumn();
            ColumnClassifyID.DataPropertyName = "ClassifyID";
            ColumnClassifyID.Name = "ColumnClassifyID";
            ColumnClassifyID.HeaderText = "卡类";
            ColumnClassifyID.Width = 70;
            ColumnClassifyID.DisplayIndex = 3;
            ColumnClassifyID.Visible = false;
            dgvMain.Columns.Add(ColumnClassifyID);

            DataGridViewTextBoxColumn ColumnClassifyName = new DataGridViewTextBoxColumn();
            ColumnClassifyName.DataPropertyName = "ClassifyName";
            ColumnClassifyName.Name = "ColumnClassifyName";
            ColumnClassifyName.HeaderText = "卡类";
            ColumnClassifyName.Width = 70;
            ColumnClassifyName.DisplayIndex = 4;
            dgvMain.Columns.Add(ColumnClassifyName);

            DataGridViewTextBoxColumn ColumnAssociator = new DataGridViewTextBoxColumn();
            ColumnAssociator.DataPropertyName = "Associator";
            ColumnAssociator.Name = "ColumnAssociator";
            ColumnAssociator.HeaderText = "会员名";
            ColumnAssociator.Width = 80;
            ColumnAssociator.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnAssociator);

            DataGridViewTextBoxColumn ColumnIdentityCard = new DataGridViewTextBoxColumn();
            ColumnIdentityCard.DataPropertyName = "IdentityCard";
            ColumnIdentityCard.Name = "ColumnIdentityCard";
            ColumnIdentityCard.HeaderText = "身份证";
            ColumnIdentityCard.Width = 120;
            ColumnIdentityCard.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnIdentityCard);

            DataGridViewTextBoxColumn ColumnCompany = new DataGridViewTextBoxColumn();
            ColumnCompany.DataPropertyName = "Company";
            ColumnCompany.Name = "ColumnCompany";
            ColumnCompany.HeaderText = "公司";
            ColumnCompany.Width = 120;
            ColumnCompany.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnCompany);


            DataGridViewTextBoxColumn ColumnAddress = new DataGridViewTextBoxColumn();
            ColumnAddress.DataPropertyName = "Address";
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.HeaderText = "地址";
            ColumnAddress.Width = 120;
            ColumnAddress.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnAddress);

            DataGridViewTextBoxColumn ColumnPostCode = new DataGridViewTextBoxColumn();
            ColumnPostCode.DataPropertyName = "PostCode";
            ColumnPostCode.Name = "ColumnPostCode";
            ColumnPostCode.HeaderText = "邮编";
            ColumnPostCode.Width = 70;
            ColumnPostCode.DisplayIndex = 9;
            ColumnPostCode.Visible = false;
            dgvMain.Columns.Add(ColumnPostCode);

            DataGridViewTextBoxColumn ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnPhone.DataPropertyName = "Phone";
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.HeaderText = "电话";
            ColumnPhone.Width = 120;
            ColumnPhone.DisplayIndex = 10;
            dgvMain.Columns.Add(ColumnPhone);

            DataGridViewTextBoxColumn ColumnMobilePhone = new DataGridViewTextBoxColumn();
            ColumnMobilePhone.DataPropertyName = "MobilePhone";
            ColumnMobilePhone.Name = "ColumnMobilePhone";
            ColumnMobilePhone.HeaderText = "手机";
            ColumnMobilePhone.Width = 120;
            ColumnMobilePhone.DisplayIndex = 11;
            dgvMain.Columns.Add(ColumnMobilePhone);

            DataGridViewCheckBoxColumn ColumnIsTimeLimit = new DataGridViewCheckBoxColumn();
            ColumnIsTimeLimit.DataPropertyName = "IsTimeLimit";
            ColumnIsTimeLimit.Name = "ColumnIsTimeLimit";
            ColumnIsTimeLimit.HeaderText = "是否限期";
            ColumnIsTimeLimit.Width = 80;
            ColumnIsTimeLimit.TrueValue = 1;
            ColumnIsTimeLimit.FalseValue = 0;

            ColumnIsTimeLimit.DisplayIndex = 12;
            dgvMain.Columns.Add(ColumnIsTimeLimit);

            DataGridViewTextBoxColumn ColumnEndDate = new DataGridViewTextBoxColumn();
            ColumnEndDate.DataPropertyName = "EndDate";
            ColumnEndDate.Name = "ColumnEndDate";
            ColumnEndDate.HeaderText = "到期时间";
            ColumnEndDate.Width = 120;
            ColumnEndDate.DisplayIndex = 13;
            dgvMain.Columns.Add(ColumnEndDate);

            DataGridViewTextBoxColumn ColumnSurplus = new DataGridViewTextBoxColumn();
            ColumnSurplus.DataPropertyName = "Surplus";
            ColumnSurplus.Name = "ColumnSurplus";
            ColumnSurplus.HeaderText = "余额";
            ColumnSurplus.Width = 70;
            ColumnSurplus.DisplayIndex = 14;
            dgvMain.Columns.Add(ColumnSurplus);

            DataGridViewTextBoxColumn ColumnIntegral = new DataGridViewTextBoxColumn();
            ColumnIntegral.DataPropertyName = "Integral";
            ColumnIntegral.Name = "ColumnIntegral";
            ColumnIntegral.HeaderText = "积分";
            ColumnIntegral.Width = 70;
            ColumnIntegral.DisplayIndex = 15;
            dgvMain.Columns.Add(ColumnIntegral);

            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 150;
            ColumnRemark.DisplayIndex = 16;
            dgvMain.Columns.Add(ColumnRemark);

            DataGridViewTextBoxColumn ColumnRecordTime = new DataGridViewTextBoxColumn();
            ColumnRecordTime.DataPropertyName = "RecordTime";
            ColumnRecordTime.Name = "ColumnRecordTime";
            ColumnRecordTime.HeaderText = "建立时间";
            ColumnRecordTime.Width = 120;
            ColumnRecordTime.DisplayIndex = 17;
            dgvMain.Columns.Add(ColumnRecordTime);

            DataGridViewTextBoxColumn ColumnAgioRate = new DataGridViewTextBoxColumn();
            ColumnAgioRate.DataPropertyName = "AgioRate";
            ColumnAgioRate.Name = "ColumnAgioRate";
            ColumnAgioRate.HeaderText = "折扣率";
            ColumnAgioRate.Width = 100;
            ColumnAgioRate.DisplayIndex = 18;
            dgvMain.Columns.Add(ColumnAgioRate);

            DataGridViewTextBoxColumn ColumnIntegralRadix = new DataGridViewTextBoxColumn();
            ColumnIntegralRadix.DataPropertyName = "IntegralRadix";
            ColumnIntegralRadix.Name = "ColumnIntegralRadix";
            ColumnIntegralRadix.HeaderText = "积分基数";
            ColumnIntegralRadix.Width = 120;
            ColumnIntegralRadix.DisplayIndex = 19;
            dgvMain.Columns.Add(ColumnIntegralRadix);

            DataGridViewTextBoxColumn ColumnTimeLimit = new DataGridViewTextBoxColumn();
            ColumnTimeLimit.DataPropertyName = "TimeLimit";
            ColumnTimeLimit.Name = "ColumnTimeLimit";
            ColumnTimeLimit.HeaderText = "限制天数";
            ColumnTimeLimit.Width = 120;
            ColumnTimeLimit.DisplayIndex = 20;
            ColumnTimeLimit.Visible = false;
            dgvMain.Columns.Add(ColumnTimeLimit);
        }
        private void FormAssociator_Load(object sender, EventArgs e)
        {
            bs = new BindingSource();

            ShowAssociator();
        }

        void ShowAssociator()
        {

            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociator();

            dgvMain.DataSource = bs;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int AssociatorID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnAssociatorID"].Value);

                if (CGlobalInstance.Instance.DbAdaHelper.DeleteAssociator(AssociatorID))
                {
                    ShowAssociator();
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormAssociatorItem dlg = new FormAssociatorItem();

            dlg.ShowDialog();
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int AssociatorID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnAssociatorID"].Value);

                FormAssociatorItem dlg = new FormAssociatorItem();

                dlg.m_AssociatorItem.AssociatorID = AssociatorID;
                dlg.m_AssociatorItem.CardID = dgvMain.CurrentRow.Cells["ColumnCardID"].Value.ToString();
                dlg.m_AssociatorItem.CardPwd = dgvMain.CurrentRow.Cells["ColumnCardPwd"].Value.ToString();
                dlg.m_AssociatorItem.ClassifyID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnClassifyID"].Value);

                dlg.m_AssociatorItem.Associator = dgvMain.CurrentRow.Cells["ColumnAssociator"].Value.ToString();
                dlg.m_AssociatorItem.IdentityCard = dgvMain.CurrentRow.Cells["ColumnIdentityCard"].Value.ToString();
                dlg.m_AssociatorItem.Address = dgvMain.CurrentRow.Cells["ColumnAddress"].Value.ToString();
                dlg.m_AssociatorItem.Company = dgvMain.CurrentRow.Cells["ColumnCompany"].Value.ToString();
                dlg.m_AssociatorItem.PostCode = dgvMain.CurrentRow.Cells["ColumnPostCode"].Value.ToString();

                dlg.m_AssociatorItem.Phone = dgvMain.CurrentRow.Cells["ColumnPhone"].Value.ToString();
                dlg.m_AssociatorItem.MobilePhone = dgvMain.CurrentRow.Cells["ColumnMobilePhone"].Value.ToString();
                try
                {
                    dlg.m_AssociatorItem.Surplus = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnSurplus"].Value);
                    dlg.m_AssociatorItem.Integral = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnIntegral"].Value);

                    dlg.m_AssociatorItem.EndDate = Convert.ToDateTime(dgvMain.CurrentRow.Cells["ColumnEndDate"].Value);
                }
                catch
                {
                }
                dlg.m_AssociatorItem.Remark = dgvMain.CurrentRow.Cells["ColumnRemark"].Value.ToString();

                dlg.ShowDialog();
            }
        }

        private void toolStripButtonRecord_Click(object sender, EventArgs e)
        {
            FormAssociatorRecord dlg = new FormAssociatorRecord();

            dlg.ShowDialog();
        }

        private void toolStripButtonClassfy_Click(object sender, EventArgs e)
        {
            FormAssociatorClassify dlg = new FormAssociatorClassify();

            dlg.ShowDialog();

            ShowAssociator();
        }

        private void toolStripButtonReserve_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int AssociatorID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnAssociatorID"].Value);
                double Surplus = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnSurplus"].Value);


                FormDeposit dlg = new FormDeposit();

                dlg.CardID = dgvMain.CurrentRow.Cells["ColumnCardID"].Value.ToString();
                dlg.Associator = dgvMain.CurrentRow.Cells["ColumnAssociator"].Value.ToString();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string Employee = "";//有待修改
                    string Remark = dlg.Remark;

                    if (CGlobalInstance.Instance.DbAdaHelper.AssociatorDeposit(dlg.CardID, Surplus, dlg.Value, Employee, Remark))
                    {
                        MessageBox.Show("充值成功!");
                    }
                    else
                    {
                        MessageBox.Show("充值失败!");
                    }
                }
            }
            
        }
    }
}