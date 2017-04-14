using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormGoodsMaterialItem : Form
    {
        public _tagGoodsMaterial m_GoodsMaterialItem = new _tagGoodsMaterial();
        public FormGoodsMaterialItem()
        {
            InitializeComponent();
        }

        private void FormGoodsMaterialItem_Load(object sender, EventArgs e)
        {
            cbGoodsClassifyName.DisplayMember = "GoodsClassifyName";
            cbGoodsClassifyName.ValueMember = "GoodsClassify";
            cbGoodsClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsClassify();

            cbGoodsClassifyName.SelectedValue = m_GoodsMaterialItem.GoodsClassify;

            cbGoodsSubClassifyName.DisplayMember = "GoodsSubClassifyName";
            cbGoodsSubClassifyName.ValueMember = "GoodsSubClassify";

            if (cbGoodsClassifyName.SelectedValue != null)
            {
                cbGoodsSubClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassify(cbGoodsClassifyName.SelectedValue.ToString());
            }


            cbGoodsSubClassifyName.SelectedValue = m_GoodsMaterialItem.GoodsSubClassify;

            tbCost.Text = m_GoodsMaterialItem.Cost.ToString();
            tbGoodsName.Text = m_GoodsMaterialItem.GoodsMaterialName;
            tbGoodsNO.Text = m_GoodsMaterialItem.GoodsMaterialNO;

            tbPinYin.Text = m_GoodsMaterialItem.PinYin;
            cbUnit.Text = m_GoodsMaterialItem.Unit;
            
        }
        private void cbGoodsSubClassifyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGoodsSubClassifyName.SelectedValue != null)
            {
                tbGoodsSubClassify.Text = cbGoodsSubClassifyName.SelectedValue.ToString();
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (cbGoodsSubClassifyName.SelectedValue != null)
                m_GoodsMaterialItem.GoodsSubClassify = cbGoodsSubClassifyName.SelectedValue.ToString();

            if (cbGoodsClassifyName.SelectedValue != null)
                m_GoodsMaterialItem.GoodsClassify = cbGoodsClassifyName.SelectedValue.ToString();
            m_GoodsMaterialItem.GoodsSubClassifyID = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassifyID(m_GoodsMaterialItem.GoodsClassify, m_GoodsMaterialItem.GoodsSubClassify);

            m_GoodsMaterialItem.Cost = Convert.ToDouble(tbCost.Text);
            m_GoodsMaterialItem.GoodsMaterialName = tbGoodsName.Text;
            m_GoodsMaterialItem.GoodsMaterialNO = tbGoodsNO.Text;

            m_GoodsMaterialItem.PinYin = tbPinYin.Text;
            m_GoodsMaterialItem.Unit = cbUnit.Text;
           

            bool bRet = false;
            if (m_GoodsMaterialItem.GoodsMaterialID == 0)
            {
                bRet = CGlobalInstance.Instance.DbAdaHelper.AddGoodsMaterial(m_GoodsMaterialItem);
            }
            else
            {
                bRet = CGlobalInstance.Instance.DbAdaHelper.UpdateGoodsMaterial(m_GoodsMaterialItem);
            }
            if (bRet == false)
            {
                MessageBox.Show("Êý¾Ý±£´æÊ§°Ü!");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cbGoodsClassifyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGoodsClassifyName.SelectedValue != null)
            {
                tbGoodsClassify.Text = cbGoodsClassifyName.SelectedValue.ToString();
                cbGoodsSubClassifyName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassify(tbGoodsClassify.Text);
            }
        }

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbGoodsNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbGoodsName_TextChanged(object sender, EventArgs e)
        {
            tbPinYin.Text = MixFunc.ChinaSpell.GetChineseSpellB(tbGoodsName.Text);
        }
 
    }
}