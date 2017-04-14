using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormBillQuery : Form
    {
        BindingSource bs;

        public FormBillQuery()
        {
            InitializeComponent();
            InitView();

            bs = new BindingSource();
        }
        private void InitView()
        {
            dgvBill.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnBillID = new DataGridViewTextBoxColumn();
            ColumnBillID.DataPropertyName = "BillID";
            ColumnBillID.Name = "ColumnBillID";
            ColumnBillID.HeaderText = "BillID";
            ColumnBillID.Visible = false;
            ColumnBillID.Width = 30;
            ColumnBillID.FillWeight = 40F;
            ColumnBillID.ReadOnly = true;
            ColumnBillID.DisplayIndex = 0;
            dgvBill.Columns.Add(ColumnBillID);

            DataGridViewTextBoxColumn ColumnBillNO = new DataGridViewTextBoxColumn();
            ColumnBillNO.DataPropertyName = "BillNO";
            ColumnBillNO.Name = "ColumnBillNO";
            ColumnBillNO.HeaderText = "单据编号";
            ColumnBillNO.Visible = false;
            ColumnBillNO.Width = 30;
            ColumnBillNO.FillWeight = 40F;
            ColumnBillNO.ReadOnly = true;
            ColumnBillNO.DisplayIndex = 1;
            dgvBill.Columns.Add(ColumnBillNO);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnTableName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnTableName.DataPropertyName = "TableName";
            ColumnTableName.Name = "ColumnTableName";
            ColumnTableName.HeaderText = "台名";
            ColumnTableName.Width = 70;
            ColumnTableName.DisplayIndex = 2;
            dgvBill.Columns.Add(ColumnTableName);



            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnTableNO = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnTableNO.DataPropertyName = "TableNO";
            ColumnTableNO.Name = "ColumnTableNO";
            ColumnTableNO.HeaderText = "台号";
            ColumnTableNO.Width = 70;
            ColumnTableNO.DisplayIndex = 3;
            dgvBill.Columns.Add(ColumnTableNO);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnClientName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnClientName.DataPropertyName = "ClientName";
            ColumnClientName.Name = "ColumnClientName";
            ColumnClientName.HeaderText = "客户";
            ColumnClientName.Width = 70;
            ColumnClientName.DisplayIndex = 4;
            dgvBill.Columns.Add(ColumnClientName);

            DataGridViewTextBoxColumn ColumnClientNumber = new DataGridViewTextBoxColumn();
            ColumnClientNumber.DataPropertyName = "ClientNumber";
            ColumnClientNumber.Name = "ColumnClientNumber";
            ColumnClientNumber.HeaderText = "人数";
            ColumnClientNumber.Width = 70;
            ColumnClientNumber.DisplayIndex = 5;
            dgvBill.Columns.Add(ColumnClientNumber);

            DataGridViewTextBoxColumn ColumnBillTime = new DataGridViewTextBoxColumn();
            ColumnBillTime.DataPropertyName = "BillTime";
            ColumnBillTime.Name = "ColumnBillTime";
            ColumnBillTime.HeaderText = "开台时间";
            ColumnBillTime.Width = 70;
            ColumnBillTime.DisplayIndex = 6;
            dgvBill.Columns.Add(ColumnBillTime);

            DataGridViewTextBoxColumn ColumnAccount = new DataGridViewTextBoxColumn();
            ColumnAccount.DataPropertyName = "Account";
            ColumnAccount.Name = "ColumnAccount";
            ColumnAccount.HeaderText = "消费金额";
            ColumnAccount.DefaultCellStyle.Format = "0.00";
            ColumnAccount.Width = 70;
            ColumnAccount.DisplayIndex = 7;
            dgvBill.Columns.Add(ColumnAccount);

            DataGridViewTextBoxColumn ColumnDiscount = new DataGridViewTextBoxColumn();
            ColumnDiscount.DataPropertyName = "Discount";
            ColumnDiscount.Name = "ColumnDiscount";
            ColumnDiscount.HeaderText = "折扣金额";
            ColumnDiscount.DefaultCellStyle.Format = "0.00";
            ColumnDiscount.Width = 70;
            ColumnDiscount.DisplayIndex = 8;
            dgvBill.Columns.Add(ColumnDiscount);
            
            DataGridViewTextBoxColumn ColumnReceAccount = new DataGridViewTextBoxColumn();
            ColumnReceAccount.DataPropertyName = "ReceAccount";
            ColumnReceAccount.Name = "ColumnReceAccount";
            ColumnReceAccount.HeaderText = "应收金额";
            ColumnReceAccount.DefaultCellStyle.Format = "0.00";
            ColumnReceAccount.Width = 70;
            ColumnReceAccount.DisplayIndex = 9;
            dgvBill.Columns.Add(ColumnReceAccount);

            DataGridViewTextBoxColumn ColumnRealAccount = new DataGridViewTextBoxColumn();
            ColumnRealAccount.DataPropertyName = "RealAccount";
            ColumnRealAccount.Name = "ColumnRealAccount";
            ColumnRealAccount.HeaderText = "实收金额";
            ColumnRealAccount.DefaultCellStyle.Format = "0.00";
            ColumnRealAccount.Width = 70;
            ColumnRealAccount.DisplayIndex = 10;
            dgvBill.Columns.Add(ColumnRealAccount);

            DataGridViewTextBoxColumn ColumnDeduct = new DataGridViewTextBoxColumn();
            ColumnDeduct.DataPropertyName = "Deduct";
            ColumnDeduct.Name = "ColumnDeduct";
            ColumnDeduct.HeaderText = "提成金额";
            ColumnDeduct.DefaultCellStyle.Format = "0.00";
            ColumnDeduct.Width = 70;
            ColumnDeduct.DisplayIndex = 11;
            dgvBill.Columns.Add(ColumnDeduct);

            DataGridViewTextBoxColumn ColumnPrintTime = new DataGridViewTextBoxColumn();
            ColumnPrintTime.DataPropertyName = "PrintTime";
            ColumnPrintTime.Name = "ColumnPrintTime";
            ColumnPrintTime.HeaderText = "结帐时间";
            ColumnPrintTime.Width = 70;
            ColumnPrintTime.DisplayIndex = 12;
            dgvBill.Columns.Add(ColumnPrintTime);

            DataGridViewCheckBoxColumn ColumnCheckout = new DataGridViewCheckBoxColumn();
            ColumnCheckout.DataPropertyName = "Checkout";
            ColumnCheckout.Name = "ColumnCheckout";
            ColumnCheckout.HeaderText = "已结帐";
            ColumnCheckout.Width = 70;
            ColumnCheckout.FalseValue = 0;
            ColumnCheckout.TrueValue = 1;
            ColumnCheckout.DisplayIndex = 13;
            dgvBill.Columns.Add(ColumnCheckout);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnEmployee = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnEmployee.DataPropertyName = "Employee";
            ColumnEmployee.Name = "ColumnEmployee";
            ColumnEmployee.HeaderText = "员工";
            ColumnEmployee.Width = 70;
            ColumnEmployee.DisplayIndex = 14;
            dgvBill.Columns.Add(ColumnEmployee);

            DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ColumnDeptName = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            ColumnDeptName.DataPropertyName = "DeptName";
            ColumnDeptName.Name = "ColumnDeptName";
            ColumnDeptName.HeaderText = "部门";
            ColumnDeptName.Width = 70;
            ColumnDeptName.DisplayIndex = 15;
            dgvBill.Columns.Add(ColumnDeptName);

            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 70;
            ColumnRemark.DisplayIndex = 16;
            dgvBill.Columns.Add(ColumnRemark);
        }
        void ShowData()
        {
            DateTime dtFrom, dtTo;
            dtFrom = dateTimePicker1.Value.Date;
            dtTo = dateTimePicker2.Value.Date.AddDays(1);

            DataTable dtBill=CGlobalInstance.Instance.DbAdaHelper.GetBill(dtFrom, dtTo);
            double SumRealAccount=0;
            foreach (DataRow dr in dtBill.Rows)
            {
                if (!Convert.IsDBNull(dr["RealAccount"]))
                    SumRealAccount += Convert.ToDouble(dr["RealAccount"]);                
            }
            DataRow drSum = dtBill.NewRow();

            drSum["RealAccount"] = SumRealAccount;
  
            drSum["ClientName"] = "合计：";

            dtBill.Rows.Add(drSum);


            bs.DataSource = dtBill;
            dgvBill.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.DefaultExt = "xls";
            fileDlg.Filter = "Excel7 files (*.xls)|*.xls|All files (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                MixFunc.CDataExport.ExportDataGridViewToExcel7(dgvBill, fileDlg.FileName);
            }
        }

        private void btHtml_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.DefaultExt = "htm";
            fileDlg.Filter = "html files (*.htm)|*.htm|All files (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                MixFunc.CDataExport.ExportDataGridViewAsHtml(dgvBill, fileDlg.FileName);
            }
        }

        private void dgvBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBill.CurrentRow != null)
            {
                FormBillListQueryB dlg = new FormBillListQueryB();

                dlg.m_Bill.BillID = Convert.ToInt64(dgvBill.CurrentRow.Cells["ColumnBillID"].Value);
                dlg.m_Bill.BillTime = Convert.ToDateTime(dgvBill.CurrentRow.Cells["ColumnBillTime"].Value);
                dlg.m_Bill.ClientName = dgvBill.CurrentRow.Cells["ColumnClientName"].Value.ToString();
                dlg.m_Bill.ClientNumber = Convert.ToInt32(dgvBill.CurrentRow.Cells["ColumnClientNumber"].Value);
                dlg.m_Bill.Remark = dgvBill.CurrentRow.Cells["ColumnRemark"].Value.ToString();

                dlg.m_Bill.Account = Convert.ToDouble(dgvBill.CurrentRow.Cells["ColumnAccount"].Value);
                dlg.m_Bill.ReceAccount = Convert.ToDouble(dgvBill.CurrentRow.Cells["ColumnReceAccount"].Value);
                dlg.m_Bill.RealAccount = Convert.ToDouble(dgvBill.CurrentRow.Cells["ColumnRealAccount"].Value);
                dlg.m_Bill.Discount = Convert.ToDouble(dgvBill.CurrentRow.Cells["ColumnDiscount"].Value);

                dlg.ShowDialog();
            }
        }
    }
}