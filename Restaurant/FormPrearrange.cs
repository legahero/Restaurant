using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MixLib;
using DataGridViewAutoFilter;

namespace Restaurant
{
    public partial class FormPrearrange : Form
    {
        BindingSource bs;
        public FormPrearrange()
        {
            InitializeComponent();
        }

        private void FormPrearrange_Load(object sender, EventArgs e)
        {
            //CAppOption.WindowStyleMan.SetStyle(this, CAppOption.iFormStyle);

            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnPrearrangeID = new DataGridViewTextBoxColumn();
            ColumnPrearrangeID.DataPropertyName = "PrearrangeID";
            ColumnPrearrangeID.Name = "ColumnPrearrangeID";
            ColumnPrearrangeID.HeaderText = "GoodsID";
            ColumnPrearrangeID.Visible = false;
            ColumnPrearrangeID.Width = 30;
            ColumnPrearrangeID.FillWeight = 40F;
            ColumnPrearrangeID.ReadOnly = true;
            ColumnPrearrangeID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnPrearrangeID);

            DataGridViewTextBoxColumn ColumnClientName = new DataGridViewTextBoxColumn();
            ColumnClientName.DataPropertyName = "ClientName";
            ColumnClientName.Name = "ColumnClientName";
            ColumnClientName.HeaderText = "客户";
            ColumnClientName.Width = 70;
            ColumnClientName.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnClientName);

            DataGridViewTextBoxColumn ColumnClientNumber = new DataGridViewTextBoxColumn();
            ColumnClientNumber.DataPropertyName = "ClientNumber";
            ColumnClientNumber.Name = "ColumnClientNumber";
            ColumnClientNumber.HeaderText = "人数";
            ColumnClientNumber.Width = 70;
            ColumnClientNumber.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnClientNumber);

            DataGridViewAutoFilterTextBoxColumn ColumnPhone = new DataGridViewAutoFilterTextBoxColumn();
            ColumnPhone.DataPropertyName = "Phone";
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.HeaderText = "电话";
            ColumnPhone.Width = 70;
            ColumnPhone.DisplayIndex = 3;
            dgvMain.Columns.Add(ColumnPhone);

            DataGridViewTextBoxColumn ColumnRemark = new DataGridViewTextBoxColumn();
            ColumnRemark.DataPropertyName = "Remark";
            ColumnRemark.Name = "ColumnRemark";
            ColumnRemark.HeaderText = "备注";
            ColumnRemark.Width = 70;
            ColumnRemark.DisplayIndex = 4;
            dgvMain.Columns.Add(ColumnRemark);

            DataGridViewTextBoxColumn ColumnOrderTime = new DataGridViewTextBoxColumn();
            ColumnOrderTime.DataPropertyName = "OrderTime";
            ColumnOrderTime.Name = "ColumnOrderTime";
            ColumnOrderTime.HeaderText = "预定时间";
            ColumnOrderTime.Width = 120;
            ColumnOrderTime.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnOrderTime);

            DataGridViewAutoFilterTextBoxColumn ColumnTableNO = new DataGridViewAutoFilterTextBoxColumn();
            ColumnTableNO.DataPropertyName = "TableNO";
            ColumnTableNO.Name = "ColumnTableNO";
            ColumnTableNO.HeaderText = "台号";
            ColumnTableNO.Width = 120;
            ColumnTableNO.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnTableNO);

            DataGridViewAutoFilterTextBoxColumn ColumnTableName = new DataGridViewAutoFilterTextBoxColumn();
            ColumnTableName.DataPropertyName = "TableName";
            ColumnTableName.Name = "ColumnTableName";
            ColumnTableName.HeaderText = "台名";
            ColumnTableName.Width = 120;
            ColumnTableName.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnTableName);

            DataGridViewAutoFilterTextBoxColumn ColumnEmployeeNO = new DataGridViewAutoFilterTextBoxColumn();
            ColumnEmployeeNO.DataPropertyName = "EmployeeNO";
            ColumnEmployeeNO.Name = "ColumnEmployeeNO";
            ColumnEmployeeNO.HeaderText = "责任员工";
            ColumnEmployeeNO.Width = 120;
            ColumnEmployeeNO.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnEmployeeNO);

            DataGridViewComboBoxColumn ColumnState = new DataGridViewComboBoxColumn();
            ColumnState.DataPropertyName = "State";
            ColumnState.Name = "ColumnState";
            ColumnState.HeaderText = "状态";
            ColumnState.Width = 60;
            ColumnState.DisplayIndex = 9;
            ColumnState.Visible = false;            
            dgvMain.Columns.Add(ColumnState);

            DataGridViewTextBoxColumn ColumnRecordTime = new DataGridViewTextBoxColumn();
            ColumnRecordTime.DataPropertyName = "RecordTime";
            ColumnRecordTime.Name = "ColumnRecordTime";
            ColumnRecordTime.HeaderText = "记录时间";
            ColumnRecordTime.Width = 120;
            ColumnRecordTime.DisplayIndex = 10;
            ColumnRecordTime.Visible = false;
            dgvMain.Columns.Add(ColumnRecordTime);

            ColumnState.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetPrearrangeState();
            ColumnState.DisplayMember = "ItemName";
            ColumnState.ValueMember = "ItemValue";

            bs = new BindingSource();

            ShowPrearrange();

            groupBox1.Enabled = false;
        }

        void ShowPrearrange()
        {
            if (checkBox1.Checked == false)
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetPrearrange(0);
            else
            {
                bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetPrearrange();
            }
            dgvMain.DataSource = bs;
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int PrearrangeID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnPrearrangeID"].Value);

                if (CGlobalInstance.Instance.DbAdaHelper.DeletePrearrange(PrearrangeID))
                {
                    ShowPrearrange();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrearrange();
        }
        long m_CurrentID = 0;
        public int m_TableNO=0;
        public int m_iOperate = -1;
        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if (m_iOperate == 1 || m_iOperate==-1) return;

            ShowCurrentData();
        }

        void ShowCurrentData()
        {
            if (dgvMain.CurrentRow!=null)
            {
                long CurrentID = Convert.ToInt64(dgvMain.CurrentRow.Cells["ColumnPrearrangeID"].Value);

                if (CurrentID != m_CurrentID)
                {
                    tbClientName.Text = dgvMain.CurrentRow.Cells["ColumnClientName"].Value.ToString();
                    tbClientNumber.Text = dgvMain.CurrentRow.Cells["ColumnClientNumber"].Value.ToString();
                    tbPhone.Text = dgvMain.CurrentRow.Cells["ColumnPhone"].Value.ToString();
                    tbRemark.Text = dgvMain.CurrentRow.Cells["ColumnRemark"].Value.ToString();
                    cbEmployeeNO.Text = dgvMain.CurrentRow.Cells["ColumnEmployeeNO"].Value.ToString();

                    dtpOrderTime.Value = Convert.ToDateTime(dgvMain.CurrentRow.Cells["ColumnOrderTime"].Value);
                    tbTableNO.Text = dgvMain.CurrentRow.Cells["ColumnTableNO"].Value.ToString();

                    if (m_iOperate<1)
                        groupBox1.Enabled = false;
                    m_CurrentID = CurrentID;
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

            _tagPrearrange data = new _tagPrearrange();

            data.TableNO=Convert.ToInt32(tbTableNO.Text);

            data.ClientName=tbClientName.Text ;
            data.ClientNumber=Convert.ToInt32(tbClientNumber.Text) ;
            data.Phone=tbPhone.Text ;
            data.Remark=tbRemark.Text ;
            data.EmployeeNO=cbEmployeeNO.Text ;

            data.OrderTime=dtpOrderTime.Value;
            bool bRet = false;
            if (m_iOperate == 1)
            {
                bRet=CGlobalInstance.Instance.DbAdaHelper.AddPrearrange(data);

                int State = (int)YyTableCtrl.YyDiningTable.YyTableState.Prearrange;
                if (CGlobalInstance.Instance.DbAdaHelper.UpdateDiningTableState(data.TableNO, State))
                {
                    //yyDiningTableView1.CurrentItem.State = YyTableCtrl.YyDiningTable.YyTableState.Prearrange;
                }
            }
            else
            {
                data.OrderTime = dtpOrderTime.Value;
                data.PrearrangeID = m_CurrentID;
                bRet=CGlobalInstance.Instance.DbAdaHelper.UpdatePrearrange(data);
            }
            if (bRet == true)
            {
                ShowPrearrange();
                m_iOperate = 0;
            }
            else
            {
                MessageBox.Show("数据可能有误，保存失败!");
            }

            btAdd.Enabled = true;
            btMod.Enabled = true;
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            m_iOperate = 2;//修改

            ShowCurrentData();

            btAdd.Enabled = false;
            btMod.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            m_CurrentID = 0;
            tbTableNO.Text= m_TableNO.ToString();

            tbClientName.Text = "";
            tbClientNumber.Text = "4";
            tbPhone.Text = "";
            tbRemark.Text = "";
            cbEmployeeNO.Text = "";

            dtpOrderTime.Value = DateTime.Now;
            m_iOperate = 1;
            groupBox1.Enabled = true;
            btAdd.Enabled = false;
            btMod.Enabled = false;
        }

        private void toolStripButtonlankout_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int PrearrangeID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnPrearrangeID"].Value);

                if (CGlobalInstance.Instance.DbAdaHelper.UpdatePrearrangeState(PrearrangeID,2))
                {
                    ShowPrearrange();
                }
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbClientNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }


    }
}