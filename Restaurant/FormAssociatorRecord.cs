using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormAssociatorRecord : Form
    {
        BindingSource bs;
        public FormAssociatorRecord()
        {
            InitializeComponent();
            InitView();

            bs = new BindingSource();
        }

        private void InitView()
        {
            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnRecordID = new DataGridViewTextBoxColumn();
            ColumnRecordID.DataPropertyName = "RecordID";
            ColumnRecordID.Name = "ColumnRecordID";
            ColumnRecordID.HeaderText = "RecordID";
            ColumnRecordID.Visible = false;
            ColumnRecordID.Width = 30;
            ColumnRecordID.FillWeight = 40F;
            ColumnRecordID.ReadOnly = true;
            ColumnRecordID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnRecordID);

            DataGridViewTextBoxColumn ColumnCardID = new DataGridViewTextBoxColumn();
            ColumnCardID.DataPropertyName = "CardID";
            ColumnCardID.Name = "ColumnCardID";
            ColumnCardID.HeaderText = "卡号";
            ColumnCardID.Visible = false;
            ColumnCardID.Width = 30;
            ColumnCardID.FillWeight = 40F;
            ColumnCardID.ReadOnly = true;
            ColumnCardID.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnCardID);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnAssociator = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnAssociator.DataPropertyName = "Associator";
            ColumnAssociator.Name = "ColumnAssociator";
            ColumnAssociator.HeaderText = "客户";
            ColumnAssociator.Width = 70;
            ColumnAssociator.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnAssociator);

            DataGridViewTextBoxColumn ColumnRecordTime = new DataGridViewTextBoxColumn();
            ColumnRecordTime.DataPropertyName = "RecordTime";
            ColumnRecordTime.Name = "ColumnRecordTime";
            ColumnRecordTime.HeaderText = "时间";
            ColumnRecordTime.Width = 120;
            ColumnRecordTime.DisplayIndex = 3;
            dgvMain.Columns.Add(ColumnRecordTime);

            DataGridViewComboBoxColumn ColumnOpType = new DataGridViewComboBoxColumn();
            ColumnOpType.DataPropertyName = "OpType";
            ColumnOpType.DisplayMember = "Name";
            ColumnOpType.ValueMember = "Value";
            ColumnOpType.DataSource = CGlobalInstance.Instance.dtAssociator;
            ColumnOpType.Name = "ColumnOpType";
            ColumnOpType.HeaderText = "操作";
            ColumnOpType.Width = 70;
            ColumnOpType.DisplayIndex = 4;
            dgvMain.Columns.Add(ColumnOpType);

            DataGridViewTextBoxColumn ColumnSurplus = new DataGridViewTextBoxColumn();
            ColumnSurplus.DataPropertyName = "Surplus";
            ColumnSurplus.Name = "ColumnSurplus";
            ColumnSurplus.HeaderText = "上次余额";
            ColumnSurplus.Width = 120;
            ColumnSurplus.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnSurplus);

            DataGridViewTextBoxColumn ColumnMoneySum = new DataGridViewTextBoxColumn();
            ColumnMoneySum.DataPropertyName = "MoneySum";
            ColumnMoneySum.Name = "ColumnMoneySum";
            ColumnMoneySum.HeaderText = "发生金额";
            ColumnMoneySum.Width = 70;
            ColumnMoneySum.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnMoneySum);

            

            DataGridViewTextBoxColumn ColumnIntegralSum = new DataGridViewTextBoxColumn();
            ColumnIntegralSum.DataPropertyName = "IntegralSum";
            ColumnIntegralSum.Name = "ColumnIntegralSum";
            ColumnIntegralSum.HeaderText = "积分";
            ColumnIntegralSum.Width = 120;
            ColumnIntegralSum.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnIntegralSum);

            DataGridViewTextBoxColumn ColumnResidualIntegral = new DataGridViewTextBoxColumn();
            ColumnResidualIntegral.DataPropertyName = "ResidualIntegral";
            ColumnResidualIntegral.Name = "ColumnResidualIntegral";
            ColumnResidualIntegral.HeaderText = "剩余积分";
            ColumnResidualIntegral.Width = 120;
            ColumnResidualIntegral.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnResidualIntegral);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnEmployee = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnEmployee.DataPropertyName = "Employee";
            ColumnEmployee.Name = "ColumnEmployee";
            ColumnEmployee.HeaderText = "员工";
            ColumnEmployee.Width = 70;
            ColumnEmployee.DisplayIndex = 9;
            dgvMain.Columns.Add(ColumnEmployee);


            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 70;
            ColumnRemark.DisplayIndex = 10;
            dgvMain.Columns.Add(ColumnRemark);

        }

        private void FormAssociatorRecord_Load(object sender, EventArgs e)
        {
            cbClient.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociator();
            cbClient.DisplayMember = "Associator";
            cbClient.ValueMember = "AssociatorID";
        }

        void ShowData()
        {
            DateTime dtFrom, dtTo;
            dtFrom = dateTimePicker1.Value.Date;
            dtTo = dateTimePicker2.Value.Date.AddDays(1);

            int ClientID = Convert.ToInt32(cbClient.SelectedValue);
            if (ClientID > 0)
            {
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociatorRecord(dtFrom, dtTo, ClientID);
            }
            else
            {
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociatorRecord(dtFrom, dtTo);
            }
            dgvMain.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}