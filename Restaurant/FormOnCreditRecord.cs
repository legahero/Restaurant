using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormOnCreditRecord : Form
    {
        BindingSource bs;
        public FormOnCreditRecord()
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

            DataGridViewTextBoxColumn ColumnOnCreditID = new DataGridViewTextBoxColumn();
            ColumnOnCreditID.DataPropertyName = "OnCreditID";
            ColumnOnCreditID.Name = "ColumnOnCreditID";
            ColumnOnCreditID.HeaderText = "GoodsID";
            ColumnOnCreditID.Visible = false;
            ColumnOnCreditID.Width = 30;
            ColumnOnCreditID.FillWeight = 40F;
            ColumnOnCreditID.ReadOnly = true;
            ColumnOnCreditID.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnOnCreditID);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnClientName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnClientName.DataPropertyName = "ClientName";
            ColumnClientName.Name = "ColumnClientName";
            ColumnClientName.HeaderText = "客户";
            ColumnClientName.Width = 70;
            ColumnClientName.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnClientName);

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
            ColumnOpType.DataSource = CGlobalInstance.Instance.dtOnCreditType;

            ColumnOpType.Name = "ColumnOpType";
            ColumnOpType.HeaderText = "操作";
            ColumnOpType.Width = 70;
            ColumnOpType.DisplayIndex = 4;
            
            dgvMain.Columns.Add(ColumnOpType);

            DataGridViewTextBoxColumn ColumnLastNumber = new DataGridViewTextBoxColumn();
            ColumnLastNumber.DataPropertyName = "LastNumber";
            ColumnLastNumber.Name = "ColumnLastNumber";
            ColumnLastNumber.HeaderText = "上次余额";
            ColumnLastNumber.Width = 120;
            ColumnLastNumber.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnLastNumber);

            DataGridViewTextBoxColumn ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnNumber.DataPropertyName = "Number";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.HeaderText = "发生金额";
            ColumnNumber.Width = 70;
            ColumnNumber.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnNumber);

            

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnEmployee = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnEmployee.DataPropertyName = "Employee";
            ColumnEmployee.Name = "ColumnEmployee";
            ColumnEmployee.HeaderText = "员工";
            ColumnEmployee.Width = 70;
            ColumnEmployee.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnEmployee);

            
            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 70;
            ColumnRemark.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnRemark);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            DateTime dtFrom, dtTo;
            dtFrom = dateTimePicker1.Value.Date;
            dtTo = dateTimePicker2.Value.Date.AddDays(1);

            int ClientID = Convert.ToInt32(cbClient.SelectedValue);
            if (ClientID > 0)
            {
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetOnCreditRecord(dtFrom, dtTo, Convert.ToInt32(cbClient.SelectedValue));


            }
            else
            {
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetOnCreditRecord(dtFrom, dtTo);
            }
            dgvMain.DataSource = bs;
        }

        private void FormOnCreditRecord_Load(object sender, EventArgs e)
        {
            cbClient.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetOnCredit();
            cbClient.DisplayMember = "ClientName";
            cbClient.ValueMember = "OnCreditID";
        }
    }
}