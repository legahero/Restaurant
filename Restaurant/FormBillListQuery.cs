using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormBillListQuery : Form
    {
        BindingSource bsBillList;

        public FormBillListQuery()
        {
            InitializeComponent();

            bsBillList = new BindingSource();

            InitBillList();
        }
        void InitBillList()
        {
            dgvBillList.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnBillListID = new DataGridViewTextBoxColumn();
            ColumnBillListID.DataPropertyName = "BillListID";
            ColumnBillListID.Name = "ColumnBillListID";
            ColumnBillListID.HeaderText = "BillListID";
            ColumnBillListID.Visible = false;
            ColumnBillListID.Width = 30;
            ColumnBillListID.FillWeight = 40F;
            ColumnBillListID.ReadOnly = true;
            ColumnBillListID.DisplayIndex = 0;
            dgvBillList.Columns.Add(ColumnBillListID);

            DataGridViewTextBoxColumn ColumnGoodsID2 = new DataGridViewTextBoxColumn();
            ColumnGoodsID2.DataPropertyName = "GoodsID";
            ColumnGoodsID2.Name = "ColumnGoodsID2";
            ColumnGoodsID2.HeaderText = "GoodsID";
            ColumnGoodsID2.Visible = false;
            ColumnGoodsID2.Width = 30;
            ColumnGoodsID2.FillWeight = 40F;
            ColumnGoodsID2.ReadOnly = true;
            ColumnGoodsID2.DisplayIndex = 1;
            dgvBillList.Columns.Add(ColumnGoodsID2);


            DataGridViewTextBoxColumn ColumnBillID = new DataGridViewTextBoxColumn();
            ColumnBillID.DataPropertyName = "BillID";
            ColumnBillID.Name = "ColumnBillID";
            ColumnBillID.HeaderText = "BillID";
            ColumnBillID.Width = 70;
            ColumnBillID.DisplayIndex = 2;
            ColumnBillID.Visible = false;
            dgvBillList.Columns.Add(ColumnBillID);

            DataGridViewTextBoxColumn ColumnLongGoodsNO2 = new DataGridViewTextBoxColumn();
            ColumnLongGoodsNO2.DataPropertyName = "LongGoodsNO";
            ColumnLongGoodsNO2.Name = "ColumnLongGoodsNO2";
            ColumnLongGoodsNO2.HeaderText = "长编码";
            ColumnLongGoodsNO2.Width = 80;
            ColumnLongGoodsNO2.DisplayIndex = 4;
            dgvBillList.Columns.Add(ColumnLongGoodsNO2);

            DataGridViewTextBoxColumn ColumnGoodsName2 = new DataGridViewTextBoxColumn();
            ColumnGoodsName2.DataPropertyName = "GoodsName";
            ColumnGoodsName2.Name = "ColumnGoodsName2";
            ColumnGoodsName2.HeaderText = "消费项目";
            ColumnGoodsName2.Width = 120;
            ColumnGoodsName2.DisplayIndex = 3;
            dgvBillList.Columns.Add(ColumnGoodsName2);

            DataGridViewTextBoxColumn ColumnGoodsNumber = new DataGridViewTextBoxColumn();
            ColumnGoodsNumber.DataPropertyName = "GoodsNumber";
            ColumnGoodsNumber.Name = "ColumnGoodsNumber";
            ColumnGoodsNumber.HeaderText = "数量";
            ColumnGoodsNumber.Width = 50;
            ColumnGoodsNumber.DisplayIndex = 4;
            dgvBillList.Columns.Add(ColumnGoodsNumber);


            DataGridViewTextBoxColumn ColumnUnit2 = new DataGridViewTextBoxColumn();
            ColumnUnit2.DataPropertyName = "Unit";
            ColumnUnit2.Name = "ColumnUnit2";
            ColumnUnit2.HeaderText = "单位";
            ColumnUnit2.Width = 50;
            ColumnUnit2.DisplayIndex = 5;
            dgvBillList.Columns.Add(ColumnUnit2);

            DataGridViewTextBoxColumn ColumnUnitPrice2 = new DataGridViewTextBoxColumn();
            ColumnUnitPrice2.DataPropertyName = "UnitPrice";
            ColumnUnitPrice2.Name = "ColumnUnitPrice2";
            ColumnUnitPrice2.HeaderText = "单价";
            ColumnUnitPrice2.DefaultCellStyle.Format = "0.00";
            ColumnUnitPrice2.Width = 80;
            ColumnUnitPrice2.DisplayIndex = 6;
            dgvBillList.Columns.Add(ColumnUnitPrice2);

            DataGridViewTextBoxColumn ColumnWorthiness = new DataGridViewTextBoxColumn();
            ColumnWorthiness.DataPropertyName = "Worthiness";
            ColumnWorthiness.Name = "ColumnWorthiness";
            ColumnWorthiness.HeaderText = "小计";
            ColumnWorthiness.DefaultCellStyle.Format = "0.00";
            ColumnWorthiness.Width = 80;
            ColumnWorthiness.DisplayIndex = 7;
            dgvBillList.Columns.Add(ColumnWorthiness);


            DataGridViewCheckBoxColumn ColumnIsCurrentPrice2 = new DataGridViewCheckBoxColumn();
            ColumnIsCurrentPrice2.DataPropertyName = "IsCurrentPrice";
            ColumnIsCurrentPrice2.Name = "ColumnIsCurrentPrice2";
            ColumnIsCurrentPrice2.HeaderText = "时价";
            ColumnIsCurrentPrice2.TrueValue = "1";
            ColumnIsCurrentPrice2.FalseValue = "0";
            ColumnIsCurrentPrice2.Visible = true;
            ColumnIsCurrentPrice2.ReadOnly = true;
            ColumnIsCurrentPrice2.Width = 50;
            ColumnIsCurrentPrice2.DisplayIndex = 8;
            dgvBillList.Columns.Add(ColumnIsCurrentPrice2);

            DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "大类";
            ColumnGoodsClassifyName.Width = 70;
            ColumnGoodsClassifyName.DisplayIndex = 9;
            dgvBillList.Columns.Add(ColumnGoodsClassifyName);


            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 80;
            ColumnRemark.DisplayIndex = 10;
            dgvBillList.Columns.Add(ColumnRemark);

            DataGridViewTextBoxColumn ColumnDeductEmployeeNO = new DataGridViewTextBoxColumn();
            ColumnDeductEmployeeNO.DataPropertyName = "DeductEmployeeNO";
            ColumnDeductEmployeeNO.Name = "ColumnDeductEmployeeNO";
            ColumnDeductEmployeeNO.HeaderText = "提成员工";
            ColumnDeductEmployeeNO.Width = 80;
            ColumnDeductEmployeeNO.DisplayIndex = 11;
            dgvBillList.Columns.Add(ColumnDeductEmployeeNO);


            DataGridViewComboBoxColumn ColumnType = new DataGridViewComboBoxColumn();
            ColumnType.DataPropertyName = "Type";//
            ColumnType.DisplayMember = "Name";
            ColumnType.ValueMember = "Value";
            ColumnType.DataSource = CGlobalInstance.Instance.dtBillType;

            ColumnType.Name = "ColumnType";
            ColumnType.HeaderText = "类型";//点单，退单，赠单,退赠
            ColumnType.Width = 80;
            ColumnType.DisplayIndex = 12;
            dgvBillList.Columns.Add(ColumnType);


            DataGridViewTextBoxColumn ColumnDeptName = new DataGridViewTextBoxColumn();
            ColumnDeptName.DataPropertyName = "DeptName";
            ColumnDeptName.Name = "ColumnDeptName";
            ColumnDeptName.HeaderText = "部门";//0落单，1排队中，3已上菜
            ColumnDeptName.Width = 80;
            ColumnDeptName.DisplayIndex = 13;
            dgvBillList.Columns.Add(ColumnDeptName);

            DataGridViewTextBoxColumn ColumnBillTime = new DataGridViewTextBoxColumn();
            ColumnBillTime.DataPropertyName = "BillTime";
            ColumnBillTime.Name = "ColumnBillTime";
            ColumnBillTime.HeaderText = "开台时间";//0落单，1排队中，3已上菜
            ColumnBillTime.Width = 80;
            ColumnBillTime.DisplayIndex = 14;
            dgvBillList.Columns.Add(ColumnBillTime);
        }
        private void FormBillListQuery_Load(object sender, EventArgs e)
        {
            ShowBillList();
        }

        void ShowBillList()
        {
            DateTime dtFrom, dtTo;
            dtFrom = dateTimePicker1.Value.Date;
            dtTo = dateTimePicker2.Value.Date.AddDays(1);

            DataTable dtBillListSrc = CGlobalInstance.Instance.DbAdaHelper.GetBillList(dtFrom, dtTo);
                       

            DataTable dtBillList = dtBillListSrc.Copy();

            int ipos = 0, iType = 0;
            double SumWorthiness = 0;
            bool bRT = false;
            foreach (DataRow dr in dtBillListSrc.Rows)
            {
                iType = Convert.ToInt32(dr["Type"]);

                if (iType >= 2 && bRT == false)
                {
                    DataRow drSumH = dtBillList.NewRow();
                    drSumH["GoodsName"] = "    合计(消)";
                    drSumH["Worthiness"] = SumWorthiness;
                    dtBillList.Rows.InsertAt(drSumH, ipos);
                    SumWorthiness = 0;
                    bRT = true;
                }

                if (!Convert.IsDBNull(dr["Worthiness"]))
                    SumWorthiness += Convert.ToDouble(dr["Worthiness"]);
                ipos++;


            }

            DataRow drSum = dtBillList.NewRow();
            drSum["GoodsName"] = "    合计(赠)";
            drSum["Worthiness"] = SumWorthiness;
            dtBillList.Rows.Add(drSum);

            bsBillList.DataSource = dtBillList;
            dgvBillList.DataSource = bsBillList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowBillList();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.DefaultExt = "xls";
            fileDlg.Filter = "Excel7 files (*.xls)|*.xls|All files (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                MixFunc.CDataExport.ExportDataGridViewToExcel7(dgvBillList, fileDlg.FileName);
            }
        }

        private void btHtml_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDlg = new SaveFileDialog();
            fileDlg.DefaultExt = "htm";
            fileDlg.Filter = "html files (*.htm)|*.htm|All files (*.*)|*.*";
            if (fileDlg.ShowDialog() == DialogResult.OK)
            {
                MixFunc.CDataExport.ExportDataGridViewAsHtml(dgvBillList, fileDlg.FileName);
            }
        }

        private void dgvBillList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.IsDBNull(dgvBillList.Rows[e.RowIndex].Cells["ColumnBillListID"].Value))
                dgvBillList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
        }
    }
}