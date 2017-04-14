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
    public partial class FormGoodsSet : Form
    {
        BindingSource bs;
        public FormGoodsSet()
        {
            InitializeComponent();
        }

        private void FormGoodsSet_Load(object sender, EventArgs e)
        {
            CAppOption.WindowStyleMan.SetStyle(this, CAppOption.iFormStyle);

            dgvMain.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn ColumnGoodsID = new DataGridViewTextBoxColumn();
            ColumnGoodsID.DataPropertyName = "GoodsID";
            ColumnGoodsID.Name = "ColumnGoodsID";
            ColumnGoodsID.HeaderText = "GoodsID";
            ColumnGoodsID.Visible = false;
            ColumnGoodsID.Width = 30;
            ColumnGoodsID.FillWeight = 40F;
            ColumnGoodsID.ReadOnly = true;
            ColumnGoodsID.DisplayIndex = 0;
            dgvMain.Columns.Add(ColumnGoodsID);

            DataGridViewTextBoxColumn ColumnGoodsClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsClassify.DataPropertyName = "GoodsClassify";
            ColumnGoodsClassify.Name = "ColumnGoodsClassify";
            ColumnGoodsClassify.HeaderText = "大类码";
            ColumnGoodsClassify.Width = 70;
            ColumnGoodsClassify.DisplayIndex = 1;
            ColumnGoodsClassify.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsClassify);

            DataGridViewTextBoxColumn ColumnGoodsSubClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassify.DataPropertyName = "GoodsSubClassify";
            ColumnGoodsSubClassify.Name = "ColumnGoodsSubClassify";
            ColumnGoodsSubClassify.HeaderText = "小类码";
            ColumnGoodsSubClassify.Width = 70;
            ColumnGoodsSubClassify.DisplayIndex = 2;
            ColumnGoodsSubClassify.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsSubClassify);

            DataGridViewTextBoxColumn ColumnGoodsNO = new DataGridViewTextBoxColumn();
            ColumnGoodsNO.DataPropertyName = "GoodsNO";
            ColumnGoodsNO.Name = "ColumnGoodsNO";
            ColumnGoodsNO.HeaderText = "短编码";
            ColumnGoodsNO.Width = 70;
            ColumnGoodsNO.DisplayIndex = 3;
            ColumnGoodsNO.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsNO);

            DataGridViewTextBoxColumn ColumnLongGoodsNO = new DataGridViewTextBoxColumn();
            ColumnLongGoodsNO.DataPropertyName = "LongGoodsNO";
            ColumnLongGoodsNO.Name = "ColumnLongGoodsNO";
            ColumnLongGoodsNO.HeaderText = "长编码";
            ColumnLongGoodsNO.Width = 80;
            ColumnLongGoodsNO.DisplayIndex = 4;
            dgvMain.Columns.Add(ColumnLongGoodsNO);

            DataGridViewTextBoxColumn ColumnGoodsName = new DataGridViewTextBoxColumn();
            ColumnGoodsName.DataPropertyName = "GoodsName";
            ColumnGoodsName.Name = "ColumnGoodsName";
            ColumnGoodsName.HeaderText = "名称";
            ColumnGoodsName.Width = 80;
            ColumnGoodsName.DisplayIndex = 5;
            dgvMain.Columns.Add(ColumnGoodsName);

            DataGridViewTextBoxColumn ColumnGoodsSubClassifyID = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyID.DataPropertyName = "GoodsSubClassifyID";
            ColumnGoodsSubClassifyID.Name = "ColumnGoodsSubClassifyID";
            ColumnGoodsSubClassifyID.HeaderText = "分类";
            ColumnGoodsSubClassifyID.Width = 70;
            ColumnGoodsSubClassifyID.DisplayIndex = 6;
            ColumnGoodsSubClassifyID.Visible = false;
            dgvMain.Columns.Add(ColumnGoodsSubClassifyID);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsSubClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyName.DataPropertyName = "GoodsSubClassifyName";
            ColumnGoodsSubClassifyName.Name = "ColumnGoodsSubClassifyName";
            ColumnGoodsSubClassifyName.HeaderText = "小类";
            ColumnGoodsSubClassifyName.Width = 70;
            ColumnGoodsSubClassifyName.DisplayIndex = 7;
            dgvMain.Columns.Add(ColumnGoodsSubClassifyName);

            DataGridViewAutoFilterTextBoxColumn ColumnGoodsClassifyName = new DataGridViewAutoFilterTextBoxColumn();
            //DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "大类";
            ColumnGoodsClassifyName.Width = 70;
            ColumnGoodsClassifyName.DisplayIndex = 8;
            dgvMain.Columns.Add(ColumnGoodsClassifyName);
            

            DataGridViewTextBoxColumn ColumnUnit = new DataGridViewTextBoxColumn();
            ColumnUnit.DataPropertyName = "Unit";
            ColumnUnit.Name = "ColumnUnit";
            ColumnUnit.HeaderText = "单位";
            ColumnUnit.Width = 50;
            ColumnUnit.DisplayIndex = 9;
            dgvMain.Columns.Add(ColumnUnit);

            DataGridViewTextBoxColumn ColumnUnitPrice = new DataGridViewTextBoxColumn();
            ColumnUnitPrice.DataPropertyName = "UnitPrice";
            ColumnUnitPrice.Name = "ColumnUnitPrice";
            ColumnUnitPrice.HeaderText = "单价";
            ColumnUnitPrice.Width = 80;
            ColumnUnitPrice.DisplayIndex = 10;
            dgvMain.Columns.Add(ColumnUnitPrice);

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
            dgvMain.Columns.Add(ColumnIsCurrentPrice);

            DataGridViewTextBoxColumn ColumnPinYin = new DataGridViewTextBoxColumn();
            ColumnPinYin.DataPropertyName = "PinYin";
            ColumnPinYin.Name = "ColumnPinYin";
            ColumnPinYin.HeaderText = "拼音简码";
            ColumnPinYin.Width = 90;
            ColumnPinYin.DisplayIndex = 12;
            dgvMain.Columns.Add(ColumnPinYin);

            DataGridViewTextBoxColumn ColumnGoodsCode = new DataGridViewTextBoxColumn();
            ColumnGoodsCode.DataPropertyName = "GoodsCode";
            ColumnGoodsCode.Name = "ColumnGoodsCode";
            ColumnGoodsCode.HeaderText = "商品条码";
            ColumnGoodsCode.Width = 90;
            ColumnGoodsCode.DisplayIndex = 13;
            dgvMain.Columns.Add(ColumnGoodsCode);

            DataGridViewTextBoxColumn ColumnCost = new DataGridViewTextBoxColumn();
            ColumnCost.DataPropertyName = "Cost";
            ColumnCost.Name = "ColumnCost";
            ColumnCost.HeaderText = "成本";
            ColumnCost.Width = 80;
            ColumnCost.DisplayIndex = 14;
            dgvMain.Columns.Add(ColumnCost);

            DataGridViewTextBoxColumn ColumnIntegral = new DataGridViewTextBoxColumn();
            ColumnIntegral.DataPropertyName = "Integral";
            ColumnIntegral.Name = "ColumnIntegral";
            ColumnIntegral.HeaderText = "积分";
            ColumnIntegral.Width = 50;
            ColumnIntegral.DisplayIndex = 15;
            dgvMain.Columns.Add(ColumnIntegral);

            DataGridViewTextBoxColumn ColumnDeduct = new DataGridViewTextBoxColumn();
            ColumnDeduct.DataPropertyName = "Deduct";
            ColumnDeduct.Name = "ColumnDeduct";
            ColumnDeduct.HeaderText = "提成";
            ColumnDeduct.Width = 70;
            ColumnDeduct.DisplayIndex = 16;
            dgvMain.Columns.Add(ColumnDeduct);

            MixFunc.DataGridViewHelper.LoadStyle(dgvMain, "酒菜设置");

            bs = new BindingSource();

            ShowGoods();
        }
        void ShowGoods()
        {
            bs.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoods();
            dgvMain.DataSource = bs;
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            FormGoodsItem dlg = new FormGoodsItem();
            dlg.ShowDialog();

            ShowGoods();
        }
        void ModData()
        {
            
            if (dgvMain.CurrentRow != null)
            {
                FormGoodsItem dlg = new FormGoodsItem();
                dlg.m_GoodsItem.GoodsID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsID"].Value);
                dlg.m_GoodsItem.GoodsSubClassifyID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsSubClassifyID"].Value);

                dlg.m_GoodsItem.Cost = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnCost"].Value);
                dlg.m_GoodsItem.Deduct = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnDeduct"].Value);
                dlg.m_GoodsItem.GoodsCode = dgvMain.CurrentRow.Cells["ColumnGoodsCode"].Value.ToString();
                dlg.m_GoodsItem.GoodsName = dgvMain.CurrentRow.Cells["ColumnGoodsName"].Value.ToString();
                dlg.m_GoodsItem.GoodsNO = dgvMain.CurrentRow.Cells["ColumnGoodsNO"].Value.ToString();
                dlg.m_GoodsItem.Integral = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnIntegral"].Value);
                dlg.m_GoodsItem.IsCurrentPrice = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnIsCurrentPrice"].Value);
                dlg.m_GoodsItem.PinYin = dgvMain.CurrentRow.Cells["ColumnPinYin"].Value.ToString();
                dlg.m_GoodsItem.Unit = dgvMain.CurrentRow.Cells["ColumnUnit"].Value.ToString();
                dlg.m_GoodsItem.UnitPrice = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnUnitPrice"].Value);
                dlg.m_GoodsItem.GoodsClassify = dgvMain.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString().Trim();
                dlg.m_GoodsItem.GoodsSubClassify = dgvMain.CurrentRow.Cells["ColumnGoodsSubClassify"].Value.ToString().Trim();

                dlg.ShowDialog();

                ShowGoods();
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
                int GoodsID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsID"].Value);

                CGlobalInstance.Instance.DbAdaHelper.DeleteGoods(GoodsID);
                ShowGoods();
            }
        }

        private void toolStripButtonStyle_Click(object sender, EventArgs e)
        {
            FormColumn dlg = new FormColumn();
            dlg.dgvMainSet = dgvMain;
            dlg.ShowDialog();

            MixFunc.DataGridViewHelper.SaveStyle(dgvMain, "酒菜设置");            
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModData();
        }

        private void toolStripButtonDetail_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow != null)
            {
                FormGoodsDetail dlg = new FormGoodsDetail();
                dlg.m_GoodsItem.GoodsID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsID"].Value);
                dlg.m_GoodsItem.GoodsSubClassifyID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnGoodsSubClassifyID"].Value);

                dlg.m_GoodsItem.Cost = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnCost"].Value);
                dlg.m_GoodsItem.Deduct = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnDeduct"].Value);
                dlg.m_GoodsItem.GoodsCode = dgvMain.CurrentRow.Cells["ColumnGoodsCode"].Value.ToString();
                dlg.m_GoodsItem.GoodsName = dgvMain.CurrentRow.Cells["ColumnGoodsName"].Value.ToString();
                dlg.m_GoodsItem.GoodsNO = dgvMain.CurrentRow.Cells["ColumnGoodsNO"].Value.ToString();
                dlg.m_GoodsItem.Integral = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnIntegral"].Value);
                dlg.m_GoodsItem.IsCurrentPrice = Convert.ToInt32(dgvMain.CurrentRow.Cells["ColumnIsCurrentPrice"].Value);
                dlg.m_GoodsItem.PinYin = dgvMain.CurrentRow.Cells["ColumnPinYin"].Value.ToString();
                dlg.m_GoodsItem.Unit = dgvMain.CurrentRow.Cells["ColumnUnit"].Value.ToString();
                dlg.m_GoodsItem.UnitPrice = Convert.ToDouble(dgvMain.CurrentRow.Cells["ColumnUnitPrice"].Value);
                dlg.m_GoodsItem.GoodsClassify = dgvMain.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString().Trim();
                dlg.m_GoodsItem.GoodsSubClassify = dgvMain.CurrentRow.Cells["ColumnGoodsSubClassify"].Value.ToString().Trim();

                dlg.ShowDialog();

                
            }
            
        }

        private void toolStripButtonClassify_Click(object sender, EventArgs e)
        {
            FormGoodsClassify dlg = new FormGoodsClassify();

            dlg.ShowDialog();
        }        
    }
}