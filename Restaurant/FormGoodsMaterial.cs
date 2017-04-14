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
    public partial class FormGoodsMaterial : Form
    {
        BindingSource bs;

        public FormGoodsMaterial()
        {
            InitializeComponent();
            InitView();
        }
        void InitView()
        {
            dgvMain.AutoGenerateColumns = false;

            
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

            /*
            DataGridViewTextBoxColumn ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnNumber.DataPropertyName = "Number";
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.HeaderText = "数量";
            ColumnNumber.Width = 50;
            ColumnNumber.DisplayIndex = 11;
            dgvMain.Columns.Add(ColumnNumber);
             * */

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
        private void FormGoodsMaterial_Load(object sender, EventArgs e)
        {

            bs = new BindingSource();

            ShowGoodsMaterial();

        }
        void ShowGoodsMaterial()
        {
            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsMaterial();
            dgvMain.DataSource = bs;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormGoodsMaterialItem dlg = new FormGoodsMaterialItem();
            dlg.ShowDialog();

            ShowGoodsMaterial();
            
        }

        void ModData()
        {            
            if (dgvMain.CurrentRow != null)
            {
                FormGoodsMaterialItem dlg = new FormGoodsMaterialItem();

                dlg.m_GoodsMaterialItem.GoodsMaterialID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsMaterialID"].Value);
                dlg.m_GoodsMaterialItem.GoodsSubClassifyID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsSubClassifyID"].Value);

                dlg.m_GoodsMaterialItem.Cost = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnCost"].Value);

                dlg.m_GoodsMaterialItem.GoodsMaterialName = dgvMain.CurrentRow.Cells["ColumnMaterialName"].Value.ToString();
                dlg.m_GoodsMaterialItem.GoodsMaterialNO = dgvMain.CurrentRow.Cells["ColumnMaterialNO"].Value.ToString();
                
                dlg.m_GoodsMaterialItem.PinYin = dgvMain.CurrentRow.Cells["ColumnPinYin"].Value.ToString();
                dlg.m_GoodsMaterialItem.Unit = dgvMain.CurrentRow.Cells["ColumnUnit"].Value.ToString();
                
                dlg.m_GoodsMaterialItem.GoodsClassify = dgvMain.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString().Trim();
                dlg.m_GoodsMaterialItem.GoodsSubClassify = dgvMain.CurrentRow.Cells["ColumnGoodsSubClassify"].Value.ToString().Trim();

                dlg.ShowDialog();

                ShowGoodsMaterial();
            }
        }
        private void toolStripButtonMod_Click(object sender, EventArgs e)
        {
            ModData();
        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                int GoodsMaterialID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsMaterialID"].Value);

                CGlobalInstance.Instance.DbAdaHelper.DeleteGoodsMaterial(GoodsMaterialID);
                ShowGoodsMaterial();
            }
        }
    }
}