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
    public partial class FormGoodsDetail : Form
    {
        public _tagGoods m_GoodsItem = new _tagGoods();

        BindingSource bs;
        public FormGoodsDetail()
        {
            InitializeComponent();
            InitView();
        }
        void InitView()
        {
            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnGoodsDetailID = new DataGridViewTextBoxColumn();
            ColumnGoodsDetailID.DataPropertyName = "GoodsDetailID";
            ColumnGoodsDetailID.Name = "ColumnGoodsDetailID";
            ColumnGoodsDetailID.HeaderText = "GoodsDetailID";
            ColumnGoodsDetailID.Visible = false;
            ColumnGoodsDetailID.Width = 30;
            ColumnGoodsDetailID.FillWeight = 40F;
            ColumnGoodsDetailID.ReadOnly = true;
            ColumnGoodsDetailID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnGoodsDetailID);

            DataGridViewTextBoxColumn ColumnGoodsID = new DataGridViewTextBoxColumn();
            ColumnGoodsID.DataPropertyName = "GoodsID";
            ColumnGoodsID.Name = "ColumnGoodsID";
            ColumnGoodsID.HeaderText = "GoodsID";
            ColumnGoodsID.Visible = false;
            ColumnGoodsID.Width = 30;
            ColumnGoodsID.FillWeight = 40F;
            ColumnGoodsID.ReadOnly = true;
            ColumnGoodsID.DisplayIndex = 1;
            dgvMain.Columns.Add(ColumnGoodsID);

            DataGridViewTextBoxColumn ColumnGoodsMaterialID = new DataGridViewTextBoxColumn();
            ColumnGoodsMaterialID.DataPropertyName = "GoodsMaterialID";
            ColumnGoodsMaterialID.Name = "ColumnGoodsMaterialID";
            ColumnGoodsMaterialID.HeaderText = "GoodsMaterialID";
            ColumnGoodsMaterialID.Visible = false;
            ColumnGoodsMaterialID.Width = 30;
            ColumnGoodsMaterialID.FillWeight = 40F;
            ColumnGoodsMaterialID.ReadOnly = true;
            ColumnGoodsMaterialID.DisplayIndex = 2;
            dgvMain.Columns.Add(ColumnGoodsMaterialID);

            DataGridViewTextBoxColumn ColumnGoodsClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsClassify.DataPropertyName = "GoodsClassify";
            ColumnGoodsClassify.Name = "ColumnGoodsClassify";
            ColumnGoodsClassify.HeaderText = "大类码";
            ColumnGoodsClassify.Width = 70;
            ColumnGoodsClassify.DisplayIndex = 3;
            ColumnGoodsClassify.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsClassify);

            DataGridViewTextBoxColumn ColumnGoodsSubClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassify.DataPropertyName = "GoodsSubClassify";
            ColumnGoodsSubClassify.Name = "ColumnGoodsSubClassify";
            ColumnGoodsSubClassify.HeaderText = "小类码";
            ColumnGoodsSubClassify.Width = 70;
            ColumnGoodsSubClassify.DisplayIndex = 4;
            ColumnGoodsSubClassify.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsSubClassify);

            DataGridViewTextBoxColumn ColumnMaterialNO = new DataGridViewTextBoxColumn();
            ColumnMaterialNO.DataPropertyName = "MaterialNO";
            ColumnMaterialNO.Name = "ColumnMaterialNO";
            ColumnMaterialNO.HeaderText = "短编码";
            ColumnMaterialNO.Width = 70;
            ColumnMaterialNO.DisplayIndex = 5;
            ColumnMaterialNO.Visible = false;
            dgvMain.Columns.Add(ColumnMaterialNO);

            DataGridViewTextBoxColumn ColumnLongMaterialNO = new DataGridViewTextBoxColumn();
            ColumnLongMaterialNO.DataPropertyName = "LongMaterialNO";
            ColumnLongMaterialNO.Name = "ColumnLongMaterialNO";
            ColumnLongMaterialNO.HeaderText = "长编码";
            ColumnLongMaterialNO.Width = 80;
            ColumnLongMaterialNO.DisplayIndex = 6;
            dgvMain.Columns.Add(ColumnLongMaterialNO);

            DataGridViewTextBoxColumn ColumnMaterialName = new DataGridViewTextBoxColumn();
            ColumnMaterialName.DataPropertyName = "MaterialName";
            ColumnMaterialName.Name = "ColumnMaterialName";
            ColumnMaterialName.HeaderText = "名称";
            ColumnMaterialName.Width = 80;
            ColumnMaterialName.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnMaterialName);

            DataGridViewTextBoxColumn ColumnGoodsSubClassifyID = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyID.DataPropertyName = "GoodsSubClassifyID";
            ColumnGoodsSubClassifyID.Name = "ColumnGoodsSubClassifyID";
            ColumnGoodsSubClassifyID.HeaderText = "分类";
            ColumnGoodsSubClassifyID.Width = 70;
            ColumnGoodsSubClassifyID.DisplayIndex = 8;
            ColumnGoodsSubClassifyID.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsSubClassifyID);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyName.DataPropertyName = "GoodsSubClassifyName";
            ColumnGoodsSubClassifyName.Name = "ColumnGoodsSubClassifyName";
            ColumnGoodsSubClassifyName.HeaderText = "小类";
            ColumnGoodsSubClassifyName.Width = 70;
            ColumnGoodsSubClassifyName.DisplayIndex = 9;
            dgvMain.Columns.Add(ColumnGoodsSubClassifyName);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "大类";
            ColumnGoodsClassifyName.Width = 70;
            ColumnGoodsClassifyName.DisplayIndex = 10;
            dgvMain.Columns.Add(ColumnGoodsClassifyName);

            DataGridViewTextBoxColumn ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnNumber.DataPropertyName = "Number";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.HeaderText = "数量";
            ColumnNumber.Width = 50;
            ColumnNumber.DisplayIndex = 11;
            dgvMain.Columns.Add(ColumnNumber);

            DataGridViewTextBoxColumn ColumnUnit = new DataGridViewTextBoxColumn();
            ColumnUnit.DataPropertyName = "Unit";
            ColumnUnit.Name = "ColumnUnit";
            ColumnUnit.HeaderText = "单位";
            ColumnUnit.Width = 50;
            ColumnUnit.DisplayIndex = 12;
            dgvMain.Columns.Add(ColumnUnit);

            DataGridViewTextBoxColumn ColumnCost = new DataGridViewTextBoxColumn();
            ColumnCost.DataPropertyName = "Cost";
            ColumnCost.Name = "ColumnCost";
            ColumnCost.HeaderText = "单位成本";
            ColumnCost.Width = 80;
            ColumnCost.DisplayIndex = 13;
            dgvMain.Columns.Add(ColumnCost); 

            DataGridViewTextBoxColumn ColumnPinYin = new DataGridViewTextBoxColumn();
            ColumnPinYin.DataPropertyName = "PinYin";
            ColumnPinYin.Name = "ColumnPinYin";
            ColumnPinYin.HeaderText = "拼音简码";
            ColumnPinYin.Width = 90;
            ColumnPinYin.DisplayIndex = 14;
            dgvMain.Columns.Add(ColumnPinYin);             
        }
        private void FormGoodsDetail_Load(object sender, EventArgs e)
        {
            cbGoodsClassifyName.DisplayMember = "GoodsClassifyName";
            cbGoodsClassifyName.ValueMember = "GoodsClassify";
            cbGoodsClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsClassify();

            cbGoodsClassifyName.SelectedValue = m_GoodsItem.GoodsClassify;

            cbGoodsSubClassifyName.DisplayMember = "GoodsSubClassifyName";
            cbGoodsSubClassifyName.ValueMember = "GoodsSubClassify";

            if (cbGoodsClassifyName.SelectedValue != null)
            {
                cbGoodsSubClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassify(cbGoodsClassifyName.SelectedValue.ToString());
            }


            cbGoodsSubClassifyName.SelectedValue = m_GoodsItem.GoodsSubClassify;

            tbCost.Text = m_GoodsItem.Cost.ToString();
            tbGoodsCode.Text = m_GoodsItem.GoodsCode;
            tbGoodsName.Text = m_GoodsItem.GoodsName;
            tbGoodsNO.Text = m_GoodsItem.GoodsNO;
            tbPinYin.Text = m_GoodsItem.PinYin;

            bs = new BindingSource();

            ShowGoodsDetail();
 
        }
        void ShowGoodsDetail()
        {
            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsDetail(m_GoodsItem.GoodsID);
            dgvMain.DataSource = bs;
        }
        private void tbGoodsNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbGoodsSubClassifyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGoodsSubClassifyName.SelectedValue != null)
            {
                tbGoodsSubClassify.Text = cbGoodsSubClassifyName.SelectedValue.ToString();
            }
        }

        private void cbGoodsClassifyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGoodsClassifyName.SelectedValue != null)
            {
                tbGoodsClassify.Text = cbGoodsClassifyName.SelectedValue.ToString();
                cbGoodsSubClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassify(tbGoodsClassify.Text);
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormGoodElement dlg=new FormGoodElement();
            dlg.m_GoodsItem = m_GoodsItem;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (CGlobalInstance.Instance.DbAdaHelper.AddGoodsDetail(m_GoodsItem.GoodsID, dlg.GoodsMaterialID, dlg.Number))
                {
                    ShowGoodsDetail();
                }
                else
                {
                    MessageBox.Show("添加失败!");
                }
            }

            dlg.Dispose();
        }

        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int GoodsDetailID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsDetailID"].Value);

                FormGoodElement dlg = new FormGoodElement();
                dlg.m_GoodsItem = m_GoodsItem;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (CGlobalInstance.Instance.DbAdaHelper.UpdateGoodsDetail(GoodsDetailID, dlg.GoodsMaterialID, dlg.Number))
                    {
                        ShowGoodsDetail();
                    }
                    else
                    {
                        MessageBox.Show("修改失败!");
                    }
                }

                dlg.Dispose();
            }
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int GoodsDetailID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsDetailID"].Value);

                CGlobalInstance.Instance.DbAdaHelper.DeleteGoodsDetail(GoodsDetailID);
                ShowGoodsDetail();
            }
            
        }

        private void toolStripButtonMaterial_Click(object sender, EventArgs e)
        {
            FormGoodsMaterial dlg = new FormGoodsMaterial();

            dlg.ShowDialog();
        }
    }
}