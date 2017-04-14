using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataGridViewAutoFilter;

namespace Restaurant
{
    public partial class FormOrderdishes : Form
    {
        public _tagBill m_Bill = new _tagBill();

        BindingSource bs;
        BindingSource bsBillList;
        public FormOrderdishes()
        {
            InitializeComponent();
        }
        void InitGoods()
        {
            dgvGoods.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnGoodsID = new DataGridViewTextBoxColumn();
            ColumnGoodsID.DataPropertyName = "GoodsID";
            ColumnGoodsID.Name = "ColumnGoodsID";
            ColumnGoodsID.HeaderText = "GoodsID";
            ColumnGoodsID.Visible = false;
            ColumnGoodsID.Width = 30;
            ColumnGoodsID.FillWeight = 40F;
            ColumnGoodsID.ReadOnly = true;
            ColumnGoodsID.DisplayIndex = 0;
            dgvGoods.Columns.Add(ColumnGoodsID);

            DataGridViewTextBoxColumn ColumnGoodsClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsClassify.DataPropertyName = "GoodsClassify";
            ColumnGoodsClassify.Name = "ColumnGoodsClassify";
            ColumnGoodsClassify.HeaderText = "大类码";
            ColumnGoodsClassify.Width = 70;
            ColumnGoodsClassify.DisplayIndex = 1;
            ColumnGoodsClassify.Visible = false;
            dgvGoods.Columns.Add(ColumnGoodsClassify);

            DataGridViewTextBoxColumn ColumnGoodsSubClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassify.DataPropertyName = "GoodsSubClassify";
            ColumnGoodsSubClassify.Name = "ColumnGoodsSubClassify";
            ColumnGoodsSubClassify.HeaderText = "小类码";
            ColumnGoodsSubClassify.Width = 70;
            ColumnGoodsSubClassify.DisplayIndex = 2;
            ColumnGoodsSubClassify.Visible = false;
            dgvGoods.Columns.Add(ColumnGoodsSubClassify);

            DataGridViewTextBoxColumn ColumnGoodsNO = new DataGridViewTextBoxColumn();
            ColumnGoodsNO.DataPropertyName = "GoodsNO";
            ColumnGoodsNO.Name = "ColumnGoodsNO";
            ColumnGoodsNO.HeaderText = "短编码";
            ColumnGoodsNO.Width = 70;
            ColumnGoodsNO.DisplayIndex = 3;
            ColumnGoodsNO.Visible = false;
            dgvGoods.Columns.Add(ColumnGoodsNO);

            DataGridViewTextBoxColumn ColumnLongGoodsNO = new DataGridViewTextBoxColumn();
            ColumnLongGoodsNO.DataPropertyName = "LongGoodsNO";
            ColumnLongGoodsNO.Name = "ColumnLongGoodsNO";
            ColumnLongGoodsNO.HeaderText = "长编码";
            ColumnLongGoodsNO.Width = 80;
            ColumnLongGoodsNO.DisplayIndex = 4;
            dgvGoods.Columns.Add(ColumnLongGoodsNO);

            DataGridViewTextBoxColumn ColumnGoodsName = new DataGridViewTextBoxColumn();
            ColumnGoodsName.DataPropertyName = "GoodsName";
            ColumnGoodsName.Name = "ColumnGoodsName";
            ColumnGoodsName.HeaderText = "名称";
            ColumnGoodsName.Width = 80;
            ColumnGoodsName.DisplayIndex = 5;
            dgvGoods.Columns.Add(ColumnGoodsName);

            DataGridViewTextBoxColumn ColumnGoodsSubClassifyID = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyID.DataPropertyName = "GoodsSubClassifyID";
            ColumnGoodsSubClassifyID.Name = "ColumnGoodsSubClassifyID";
            ColumnGoodsSubClassifyID.HeaderText = "分类";
            ColumnGoodsSubClassifyID.Width = 70;
            ColumnGoodsSubClassifyID.DisplayIndex = 6;
            ColumnGoodsSubClassifyID.Visible = false;
            dgvGoods.Columns.Add(ColumnGoodsSubClassifyID);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyName.DataPropertyName = "GoodsSubClassifyName";
            ColumnGoodsSubClassifyName.Name = "ColumnGoodsSubClassifyName";
            ColumnGoodsSubClassifyName.HeaderText = "小类";
            ColumnGoodsSubClassifyName.Width = 70;
            ColumnGoodsSubClassifyName.DisplayIndex = 7;
            dgvGoods.Columns.Add(ColumnGoodsSubClassifyName);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "大类";
            ColumnGoodsClassifyName.Width = 70;
            ColumnGoodsClassifyName.DisplayIndex = 8;
            dgvGoods.Columns.Add(ColumnGoodsClassifyName);


            DataGridViewTextBoxColumn ColumnUnit = new DataGridViewTextBoxColumn();
            ColumnUnit.DataPropertyName = "Unit";
            ColumnUnit.Name = "ColumnUnit";
            ColumnUnit.HeaderText = "单位";
            ColumnUnit.Width = 50;
            ColumnUnit.DisplayIndex = 9;
            dgvGoods.Columns.Add(ColumnUnit);

            DataGridViewTextBoxColumn ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnUnitPrice.DataPropertyName = "UnitPrice";
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.HeaderText = "单价";
            ColumnUnitPrice.Width = 80;
            ColumnUnitPrice.DisplayIndex = 10;
            dgvGoods.Columns.Add(ColumnUnitPrice);

            DataGridViewCheckBoxColumn ColumnIsCurrentPrice = new DataGridViewCheckBoxColumn();
            ColumnIsCurrentPrice.DataPropertyName = "IsCurrentPrice";
            ColumnIsCurrentPrice.Name = "ColumnIsCurrentPrice";
            ColumnIsCurrentPrice.HeaderText = "时价";
            ColumnIsCurrentPrice.TrueValue = "1";
            ColumnIsCurrentPrice.FalseValue = "0";
            ColumnIsCurrentPrice.Visible = true;
            ColumnIsCurrentPrice.ReadOnly = true;
            ColumnIsCurrentPrice.Width = 50;
            ColumnIsCurrentPrice.DisplayIndex = 11;
            dgvGoods.Columns.Add(ColumnIsCurrentPrice);

            DataGridViewTextBoxColumn ColumnPinYin = new DataGridViewTextBoxColumn();
            ColumnPinYin.DataPropertyName = "PinYin";
            ColumnPinYin.Name = "ColumnPinYin";
            ColumnPinYin.HeaderText = "拼音简码";
            ColumnPinYin.Width = 90;
            ColumnPinYin.DisplayIndex = 12;
            dgvGoods.Columns.Add(ColumnPinYin);

            DataGridViewTextBoxColumn ColumnGoodsCode = new DataGridViewTextBoxColumn();
            ColumnGoodsCode.DataPropertyName = "GoodsCode";
            ColumnGoodsCode.Name = "ColumnGoodsCode";
            ColumnGoodsCode.HeaderText = "商品条码";
            ColumnGoodsCode.Width = 90;
            ColumnGoodsCode.DisplayIndex = 13;
            dgvGoods.Columns.Add(ColumnGoodsCode);

            DataGridViewTextBoxColumn ColumnCost = new DataGridViewTextBoxColumn();
            ColumnCost.DataPropertyName = "Cost";
            ColumnCost.Name = "ColumnCost";
            ColumnCost.HeaderText = "成本";
            ColumnCost.Width = 80;
            ColumnCost.DisplayIndex = 14;
            ColumnCost.Visible = false;
            dgvGoods.Columns.Add(ColumnCost);

            DataGridViewTextBoxColumn ColumnIntegral = new DataGridViewTextBoxColumn();
            ColumnIntegral.DataPropertyName = "Integral";
            ColumnIntegral.Name = "ColumnIntegral";
            ColumnIntegral.HeaderText = "积分";
            ColumnIntegral.Width = 50;
            ColumnIntegral.DisplayIndex = 15;
            ColumnIntegral.Visible = false;
            dgvGoods.Columns.Add(ColumnIntegral);

            DataGridViewTextBoxColumn ColumnDeduct = new DataGridViewTextBoxColumn();
            ColumnDeduct.DataPropertyName = "Deduct";
            ColumnDeduct.Name = "ColumnDeduct";
            ColumnDeduct.HeaderText = "提成";
            ColumnDeduct.Width = 70;
            ColumnDeduct.DisplayIndex = 16;
            ColumnDeduct.Visible = false;
            dgvGoods.Columns.Add(ColumnDeduct);

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
            ColumnGoodsNumber.Width = 30;
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
            ColumnUnitPrice2.Width = 80;
            ColumnUnitPrice2.DefaultCellStyle.Format = "0.00";
            ColumnUnitPrice2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ColumnUnitPrice2.DisplayIndex = 6;
            dgvBillList.Columns.Add(ColumnUnitPrice2);

            DataGridViewCheckBoxColumn ColumnIsCurrentPrice2 = new DataGridViewCheckBoxColumn();
            ColumnIsCurrentPrice2.DataPropertyName = "IsCurrentPrice";
            ColumnIsCurrentPrice2.Name = "ColumnIsCurrentPrice2";
            ColumnIsCurrentPrice2.HeaderText = "时价";
            ColumnIsCurrentPrice2.TrueValue = "1";
            ColumnIsCurrentPrice2.FalseValue = "0";
            ColumnIsCurrentPrice2.Visible = true;
            ColumnIsCurrentPrice2.ReadOnly = true;
            ColumnIsCurrentPrice2.Width = 50;
            ColumnIsCurrentPrice2.DisplayIndex = 7;
            dgvBillList.Columns.Add(ColumnIsCurrentPrice2);

            DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "大类";
            ColumnGoodsClassifyName.Width = 70;
            ColumnGoodsClassifyName.DisplayIndex = 8;
            dgvBillList.Columns.Add(ColumnGoodsClassifyName);


            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 80;
            ColumnRemark.DisplayIndex = 9;
            dgvBillList.Columns.Add(ColumnRemark);             

            DataGridViewComboBoxColumn ColumnType = new DataGridViewComboBoxColumn();
            ColumnType.DataPropertyName = "Type";//
            ColumnType.DataSource = CGlobalInstance.Instance.dtBillType;
            ColumnType.DisplayMember = "Name";
            ColumnType.ValueMember = "Value";
            ColumnType.Name = "ColumnType";
            ColumnType.HeaderText = "类型";//点单，退单，赠单,退赠
            ColumnType.Width = 80;
            ColumnType.DisplayIndex = 10;
            dgvBillList.Columns.Add(ColumnType);

            
            DataGridViewComboBoxColumn ColumnState = new DataGridViewComboBoxColumn();
            ColumnState.DataPropertyName = "State";
            ColumnState.Name = "ColumnState";
            ColumnState.DisplayMember = "Name";
            ColumnState.ValueMember = "Value";
            ColumnState.DataSource = CGlobalInstance.Instance.dtBillState;
            ColumnState.HeaderText = "状态";//0落单，1排队中，3已上菜
            ColumnState.Width = 80;
            ColumnState.DisplayIndex = 11;
            dgvBillList.Columns.Add(ColumnState);

            DataGridViewTextBoxColumn ColumnDeductEmployeeNO = new DataGridViewTextBoxColumn();
            ColumnDeductEmployeeNO.DataPropertyName = "DeductEmployeeNO";
            ColumnDeductEmployeeNO.Name = "ColumnDeductEmployeeNO";
            ColumnDeductEmployeeNO.HeaderText = "提成员工";
            ColumnDeductEmployeeNO.Width = 80;
            ColumnDeductEmployeeNO.DisplayIndex = 12;
            dgvBillList.Columns.Add(ColumnDeductEmployeeNO);


            cbType.DataSource = CGlobalInstance.Instance.dtBillType;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Value";

            
            
        }
        private void FormOrderdishes_Load(object sender, EventArgs e)
        {
            InitGoods();
            InitBillList();

            tbBillNO.Text = m_Bill.BillNO;
            tbTableNO.Text = m_Bill.TableNO.ToString();
            tbTableName.Text = m_Bill.TableName;
            tbClientName.Text = m_Bill.ClientName;
            tbClientNumber.Text = m_Bill.ClientNumber.ToString();
            tbBillTime.Text = m_Bill.BillTime.ToString("yyyy-MM-dd hh:mm");
            tbRemark.Text = m_Bill.Remark;

            bs = new BindingSource();
            bsBillList = new BindingSource();

            ShowGoods();
            ShowBillList();
        }

        void ShowGoods()
        {
            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoods();
            dgvGoods.DataSource = bs;
        }

        void ShowBillList()
        {            
            bsBillList.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetBillList(this.m_Bill.BillID);
            dgvBillList.DataSource = bsBillList;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddCurrent();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddCurrent();
            }
        }

        private void dgvGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddCurrent();
        }
        void AddCurrent()
        {
            if (dgvGoods.CurrentRow != null)
            {
                _tagBillList data = new _tagBillList();
                data.BillID = m_Bill.BillID;
                data.GoodsID = Convert.ToInt32(dgvGoods.CurrentRow.Cells["ColumnGoodsID"].Value);
                data.GoodsName = dgvGoods.CurrentRow.Cells["ColumnGoodsName"].Value.ToString();
                data.GoodsNumber = 1;
                data.Unit = dgvGoods.CurrentRow.Cells["ColumnUnit"].Value.ToString();
                data.UnitPrice = Convert.ToDouble(dgvGoods.CurrentRow.Cells["ColumnUnitPrice"].Value);

                if (CGlobalInstance.Instance.DbAdaHelper.AddBillList(data) == true)
                {
                    ShowBillList();
                    dgvBillList.Rows[dgvBillList.RowCount - 1].Selected = true;
                    dgvBillList.CurrentCell = dgvBillList.Rows[dgvBillList.RowCount - 1].Cells["ColumnGoodsName2"];
                }
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = " LongGoodsNO like '" + tbInput.Text + "%' or PinYin like '" + tbInput.Text + "%'";
            
        }

        private void dgvBillList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBillList.SelectedRows.Count > 0)
            {
                RemoveEditedEvent();

                tbLongGoodsNO.Text = dgvBillList.SelectedRows[0].Cells["ColumnLongGoodsNO2"].Value.ToString();
                tbUnitPrice.Text = dgvBillList.SelectedRows[0].Cells["ColumnUnitPrice2"].Value.ToString();
                tbGoodsName.Text = dgvBillList.SelectedRows[0].Cells["ColumnGoodsName2"].Value.ToString();

                nudGoodsNumber.Text = dgvBillList.SelectedRows[0].Cells["ColumnGoodsNumber"].Value.ToString();
                int State = Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnState"].Value);
                if (State != 0)
                {
                    //送厨房后数量不可修改
                    nudGoodsNumber.Enabled = false;
                }
                else
                {
                    nudGoodsNumber.Enabled = true;
                }

                int Type = Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnType"].Value);
                cbType.SelectedValue = Type;
                if (Type == 1 || Type == 3)
                {
                    //退单不可改
                    cbType.Enabled = false;
                }
                else
                {
                    cbType.Enabled = true;
                }
                int IsCurrentPrice=0;
                IsCurrentPrice=Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnIsCurrentPrice2"].Value);
                if (IsCurrentPrice == 1)
                {
                    tbUnitPrice.ReadOnly = false;
                }
                else
                {
                    tbUnitPrice.ReadOnly = true;
                }

                cbRemark.Text = dgvBillList.SelectedRows[0].Cells["ColumnRemark"].Value.ToString();
                cbDeductEmployeeNO.Text = dgvBillList.SelectedRows[0].Cells["ColumnDeductEmployeeNO"].Value.ToString();

                AddEditedEvent();
            }
        }
        void AddEditedEvent()
        {
            nudGoodsNumber.ValueChanged += new EventHandler(OnEdited);
            cbRemark.TextChanged += new EventHandler(OnEdited);
            cbDeductEmployeeNO.TextChanged += new EventHandler(OnEdited);
            cbType.SelectedValueChanged += new EventHandler(OnEdited);
            tbUnitPrice.TextChanged += new EventHandler(OnEdited);
        }
        void RemoveEditedEvent()
        {
            nudGoodsNumber.ValueChanged -= new EventHandler(OnEdited);
            cbRemark.TextChanged -= new EventHandler(OnEdited);
            cbDeductEmployeeNO.TextChanged -= new EventHandler(OnEdited);
            cbType.SelectedValueChanged -= new EventHandler(OnEdited);
            tbUnitPrice.TextChanged -= new EventHandler(OnEdited);
        }
        void OnEdited(object sender, EventArgs e)
        {
            long BillListID = Convert.ToInt64(dgvBillList.SelectedRows[0].Cells["ColumnBillListID"].Value);
            double GoodsNumber = Convert.ToDouble(nudGoodsNumber.Value);
            double UnitPrice = Convert.ToDouble(tbUnitPrice.Text);

            int OldType = Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnType"].Value);
            int Type = Convert.ToInt32(cbType.SelectedValue);
            if ((OldType == 0 || OldType==2) && (Type == OldType+1))
            {
                toolStripButtonCancel.PerformClick();
                return;
            }
            string DeductEmployeeNO = cbDeductEmployeeNO.Text;
            string Remark = cbRemark.Text;

            int ScrollingRowIndex = dgvBillList.FirstDisplayedScrollingRowIndex;

            if (CGlobalInstance.Instance.DbAdaHelper.UpdateBillList(BillListID,GoodsNumber, UnitPrice, Type, Remark, DeductEmployeeNO) == true)
            {
                ShowBillList();
                if (ScrollingRowIndex >= 0 && ScrollingRowIndex < dgvBillList.RowCount)
                    dgvBillList.FirstDisplayedScrollingRowIndex = ScrollingRowIndex;

            }
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
        {
            if (dgvBillList.SelectedRows.Count > 0)
            {
                _tagBillList data = new _tagBillList();

                data.BillID = m_Bill.BillID;
                data.GoodsID = Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnGoodsID2"].Value);
                data.GoodsName = dgvBillList.SelectedRows[0].Cells["ColumnGoodsName2"].Value.ToString();
                data.GoodsNumber = -Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnGoodsNumber"].Value);
                data.Unit = dgvBillList.SelectedRows[0].Cells["ColumnUnit2"].Value.ToString();
                data.UnitPrice = Convert.ToDouble(dgvBillList.SelectedRows[0].Cells["ColumnUnitPrice2"].Value);
                int Type = Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnType"].Value);
                if (Type==1||Type==3)
                {
                    //已经是退，不能再退
                    return;
                }
                data.Type = Type + 1;
                if (CGlobalInstance.Instance.DbAdaHelper.AddBillList(data) == true)
                {
                    ShowBillList();
                    dgvBillList.Rows[dgvBillList.RowCount - 1].Selected = true;
                    dgvBillList.CurrentCell = dgvBillList.Rows[dgvBillList.RowCount - 1].Cells["ColumnGoodsName2"];
                }               
                
            }            
        }

        private void toolStripButtonDeliver_Click(object sender, EventArgs e)
        {
            long BillListID = Convert.ToInt64(dgvBillList.SelectedRows[0].Cells["ColumnBillListID"].Value);
            CGlobalInstance.Instance.DbAdaHelper.UpdateBillListState(BillListID,1);
            int Index=dgvBillList.CurrentRow.Index;
            ShowBillList();
            dgvBillList.CurrentCell = dgvBillList.Rows[Index].Cells["ColumnGoodsName2"];
        }

        private void toolStripButtonAlldeliver_Click(object sender, EventArgs e)
        {
            CGlobalInstance.Instance.DbAdaHelper.UpdateBillListAllState(m_Bill.BillID, 1);
            int Index = dgvBillList.CurrentRow.Index;
            ShowBillList();
            dgvBillList.CurrentCell = dgvBillList.Rows[Index].Cells["ColumnGoodsName2"];
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            long BillListID = Convert.ToInt64(dgvBillList.SelectedRows[0].Cells["ColumnBillListID"].Value);
            int State= Convert.ToInt32(dgvBillList.SelectedRows[0].Cells["ColumnState"].Value);
            if(State>0)
            {
                MessageBox.Show("只有未送厨才能直接删除!");
                return ;
            }
            CGlobalInstance.Instance.DbAdaHelper.DeleteBillList(BillListID);
            ShowBillList();
        }

        private void tbClientNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void dgvBillList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}