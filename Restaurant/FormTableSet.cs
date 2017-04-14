using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormTableSet : Form
    {
        public FormTableSet()
        {
            InitializeComponent();

            //房台类别
            dgvTableClassify.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnTableClassifyID = new DataGridViewTextBoxColumn();
            ColumnTableClassifyID.DataPropertyName = "TableClassifyID";
            ColumnTableClassifyID.Name = "ColumnTableClassifyID";
            ColumnTableClassifyID.HeaderText = "编号";
            ColumnTableClassifyID.Visible = false;
            ColumnTableClassifyID.Width = 30;
            ColumnTableClassifyID.FillWeight = 40F;
            ColumnTableClassifyID.ReadOnly = true;
            dgvTableClassify.Columns.Add(ColumnTableClassifyID);

            DataGridViewTextBoxColumn ColumnClassifyName = new DataGridViewTextBoxColumn();
            ColumnClassifyName.DataPropertyName = "ClassifyName";
            ColumnClassifyName.Name = "ColumnClassifyName";
            ColumnClassifyName.HeaderText = "分类名";
            ColumnClassifyName.Width = 120;
            ColumnClassifyName.ReadOnly = true;
            dgvTableClassify.Columns.Add(ColumnClassifyName);

            DataGridViewTextBoxColumn ColumnAdmitNumber = new DataGridViewTextBoxColumn();
            ColumnAdmitNumber.DataPropertyName = "AdmitNumber";
            ColumnAdmitNumber.Name = "ColumnAdmitNumber";
            ColumnAdmitNumber.HeaderText = "容纳人数";
            ColumnAdmitNumber.Width = 120;
            ColumnAdmitNumber.ReadOnly = true;
            dgvTableClassify.Columns.Add(ColumnAdmitNumber);

            DataGridViewTextBoxColumn ColumnSeatCost = new DataGridViewTextBoxColumn();
            ColumnSeatCost.DataPropertyName = "SeatCost";
            ColumnSeatCost.Name = "ColumnSeatCost";
            ColumnSeatCost.HeaderText = "茶位收费(每位）";
            ColumnSeatCost.Width = 200;
            ColumnSeatCost.ReadOnly = true;
            dgvTableClassify.Columns.Add(ColumnSeatCost);

            //餐厅
            dgvDiningDept.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnDiningDeptID = new DataGridViewTextBoxColumn();
            ColumnDiningDeptID.DataPropertyName = "DiningDeptID";
            ColumnDiningDeptID.Name = "ColumnDiningDeptID";
            ColumnDiningDeptID.HeaderText = "编号";
            ColumnDiningDeptID.Visible = false;
            ColumnDiningDeptID.Width = 30;
            ColumnDiningDeptID.FillWeight = 40F;
            ColumnDiningDeptID.ReadOnly = true;
            dgvDiningDept.Columns.Add(ColumnDiningDeptID);

            DataGridViewTextBoxColumn ColumnDeptName = new DataGridViewTextBoxColumn();
            ColumnDeptName.DataPropertyName = "DeptName";
            ColumnDeptName.Name = "ColumnDeptName";
            ColumnDeptName.HeaderText = "部门";
            ColumnDeptName.Width = 80;
            ColumnDeptName.ReadOnly = true;
            dgvDiningDept.Columns.Add(ColumnDeptName);

            //餐台
            dgvDiningTable.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnDiningTableID = new DataGridViewTextBoxColumn();
            ColumnDiningTableID.DataPropertyName = "DiningTableID";
            ColumnDiningTableID.Name = "ColumnDiningTableID";
            ColumnDiningTableID.HeaderText = "台ID";
            ColumnDiningTableID.Visible = false;
            ColumnDiningTableID.Width = 30;
            ColumnDiningTableID.FillWeight = 40F;
            ColumnDiningTableID.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnDiningTableID);

            DataGridViewTextBoxColumn ColumnTableNO = new DataGridViewTextBoxColumn();
            ColumnTableNO.DataPropertyName = "TableNO";
            ColumnTableNO.Name = "ColumnTableNO";
            ColumnTableNO.HeaderText = "台号";
            ColumnTableNO.Width = 80;
            ColumnTableNO.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnTableNO);

            DataGridViewTextBoxColumn ColumnTableName = new DataGridViewTextBoxColumn();
            ColumnTableName.DataPropertyName = "TableName";
            ColumnTableName.Name = "ColumnTableName";
            ColumnTableName.HeaderText = "台名";
            ColumnTableName.Width = 80;
            ColumnTableName.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnTableName);

            DataGridViewTextBoxColumn ColumnTableClassifyID2 = new DataGridViewTextBoxColumn();
            ColumnTableClassifyID2.DataPropertyName = "TableClassifyID";
            ColumnTableClassifyID2.Name = "ColumnTableClassifyID";
            ColumnTableClassifyID2.HeaderText = "类别";
            ColumnTableClassifyID2.Width = 80;
            ColumnTableClassifyID2.ReadOnly = true;
            ColumnTableClassifyID2.Visible = false;
            dgvDiningTable.Columns.Add(ColumnTableClassifyID2);

            DataGridViewTextBoxColumn ColumnClassifyName2 = new DataGridViewTextBoxColumn();
            ColumnClassifyName2.DataPropertyName = "ClassifyName";
            ColumnClassifyName2.Name = "ColumnClassifyName";
            ColumnClassifyName2.HeaderText = "类别";
            ColumnClassifyName2.Width = 80;
            ColumnClassifyName2.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnClassifyName2);

            DataGridViewTextBoxColumn ColumnDiningDeptID2 = new DataGridViewTextBoxColumn();
            ColumnDiningDeptID2.DataPropertyName = "DiningDeptID";
            ColumnDiningDeptID2.Name = "ColumnDiningDeptID";
            ColumnDiningDeptID2.HeaderText = "部门";
            ColumnDiningDeptID2.Width = 80;
            ColumnDiningDeptID2.ReadOnly = true;
            ColumnDiningDeptID2.Visible = false;
            dgvDiningTable.Columns.Add(ColumnDiningDeptID2);

            DataGridViewTextBoxColumn ColumnDeptName2 = new DataGridViewTextBoxColumn();
            ColumnDeptName2.DataPropertyName = "DeptName";
            ColumnDeptName2.Name = "ColumnDeptName";
            ColumnDeptName2.HeaderText = "部门";
            ColumnDeptName2.Width = 80;
            ColumnDeptName2.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnDeptName2);

            DataGridViewTextBoxColumn ColumnAdmitNumber2 = new DataGridViewTextBoxColumn();
            ColumnAdmitNumber2.DataPropertyName = "AdmitNumber";
            ColumnAdmitNumber2.Name = "ColumnAdmitNumber";
            ColumnAdmitNumber2.HeaderText = "可容纳人数";
            ColumnAdmitNumber2.Width = 150;
            ColumnAdmitNumber2.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnAdmitNumber2);

            DataGridViewTextBoxColumn ColumnSeatCost2 = new DataGridViewTextBoxColumn();
            ColumnSeatCost2.DataPropertyName = "SeatCost";
            ColumnSeatCost2.Name = "ColumnSeatCost";
            ColumnSeatCost2.HeaderText = "茶位(每位)";
            ColumnSeatCost2.Width = 150;
            ColumnSeatCost2.ReadOnly = true;
            dgvDiningTable.Columns.Add(ColumnSeatCost2);
        }

        private void FormTableSet_Load(object sender, EventArgs e)
        {
            dgvTableClassify.DataSource=CGlobalInstance.Instance.DbAdaHelper.GetTableClassify();
            dgvDiningDept.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningDept();
            
        }

        private void toolStripButtonClassifyAdd_Click(object sender, EventArgs e)
        {
            FormTableClassify dlg = new FormTableClassify();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dgvTableClassify.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetTableClassify();
            }
            dlg.Dispose();
        }

        private void toolStripButtonClassifyMod_Click(object sender, EventArgs e)
        {
            if (dgvTableClassify.CurrentRow != null)
            {
                int TableClassifyID = Convert.ToInt32(dgvTableClassify.CurrentRow.Cells["ColumnTableClassifyID"].Value);
                string ClassifyName = dgvTableClassify.CurrentRow.Cells["ColumnClassifyName"].Value.ToString();
                string AdmitNumber = dgvTableClassify.CurrentRow.Cells["ColumnAdmitNumber"].Value.ToString();
                double SeatCost = Convert.ToDouble(dgvTableClassify.CurrentRow.Cells["ColumnSeatCost"].Value);

                FormTableClassify dlg = new FormTableClassify();
                dlg.m_TableClassify.TableClassifyID = TableClassifyID;
                dlg.m_TableClassify.AdmitNumber = AdmitNumber;
                dlg.m_TableClassify.ClassifyName = ClassifyName;
                dlg.m_TableClassify.SeatCost = SeatCost;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dgvTableClassify.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetTableClassify();
                }                
            }
        }

        private void toolStripButtonClassifyDel_Click(object sender, EventArgs e)
        {            
            if (dgvTableClassify.CurrentRow!=null)
            {
                int TableClassifyID = Convert.ToInt32(dgvTableClassify.CurrentRow.Cells["ColumnTableClassifyID"].Value);
                CGlobalInstance.Instance.DbAdaHelper.DeleteTableClassify(TableClassifyID);
            }
             
        }

        private void toolStripButtonDiningDeptAdd_Click(object sender, EventArgs e)
        {
            FormDiningDept dlg = new FormDiningDept();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                dgvDiningDept.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningDept();
            }
        }

        private void DiningDeptMod_Click(object sender, EventArgs e)
        {
            if (dgvDiningDept.CurrentRow != null)
            {
                int DiningDeptID = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                string DeptName = dgvDiningDept.CurrentRow.Cells["ColumnDeptName"].Value.ToString();
                
                FormDiningDept dlg = new FormDiningDept();
                dlg.m_DiningDeptID = DiningDeptID;
                dlg.m_DeptName = DeptName;
                
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dgvDiningDept.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningDept();
                }
            }
        }

        private void toolStripButtonDiningDeptDel_Click(object sender, EventArgs e)
        {
            if (dgvDiningDept.CurrentRow != null && dgvDiningTable.RowCount < 1)
            {
                int DiningDeptID = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                CGlobalInstance.Instance.DbAdaHelper.DeleteDiningDept(DiningDeptID);
            }
            else
            {
                MessageBox.Show("请选择没有餐台的部门(先删除其下的餐台)!");
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            FormDiningTable dlg = new FormDiningTable();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dgvDiningDept.CurrentRow != null)
                {
                    int DiningDeptID = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                    dgvDiningTable.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningTable(DiningDeptID);
                }
            }
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            if (dgvDiningTable.CurrentRow != null)
            {
                int DiningTableID = Convert.ToInt32(dgvDiningTable.CurrentRow.Cells["ColumnDiningTableID"].Value);
                int TableNO = Convert.ToInt32(dgvDiningTable.CurrentRow.Cells["ColumnTableNO"].Value);
                string TableName = dgvDiningTable.CurrentRow.Cells["ColumnTableName"].Value.ToString();

                int DiningDeptID = Convert.ToInt32(dgvDiningTable.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                int TableClassifyID = Convert.ToInt32(dgvDiningTable.CurrentRow.Cells["ColumnTableClassifyID"].Value);

                FormDiningTable dlg = new FormDiningTable();
                dlg.m_DiningTable.DiningTableID = DiningTableID;
                dlg.m_DiningTable.TableNO = TableNO;
                dlg.m_DiningTable.TableName = TableName;
                dlg.m_DiningTable.TableClassifyID = TableClassifyID;
                dlg.m_DiningTable.DiningDeptID = DiningDeptID;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dgvDiningDept.CurrentRow != null)
                    {
                        int DiningDeptID2 = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                        dgvDiningTable.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningTable(DiningDeptID2);
                    }
                }
            }
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvDiningTable.CurrentRow != null)
            {
                int DiningTableID = Convert.ToInt32(dgvDiningTable.CurrentRow.Cells["ColumnDiningTableID"].Value);
                CGlobalInstance.Instance.DbAdaHelper.DeleteDiningTable(DiningTableID);
            }
        }

        private void toolStripButtonNew2_Click(object sender, EventArgs e)
        {
            FormDiningTable2 dlg = new FormDiningTable2();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dgvDiningDept.CurrentRow != null )
                {
                    int DiningDeptID = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                    dgvDiningTable.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningTable(DiningDeptID);
                }
            }
        }

        private void dgvDiningDept_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvDiningDept_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiningDept.CurrentRow != null)
            {
                int DiningDeptID = Convert.ToInt32(dgvDiningDept.CurrentRow.Cells["ColumnDiningDeptID"].Value);
                dgvDiningTable.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningTable(DiningDeptID);
            }
        }       

        
    }
}