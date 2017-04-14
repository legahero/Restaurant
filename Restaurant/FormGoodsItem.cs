using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormGoodsItem : Form
    {
        public _tagGoods m_GoodsItem=new _tagGoods();

        public FormGoodsItem()
        {
            InitializeComponent();
        }

        private void FormGoodsItem_Load(object sender, EventArgs e)
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
            tbDeduct.Text = m_GoodsItem.Deduct.ToString();
            tbGoodsCode.Text = m_GoodsItem.GoodsCode;
            tbGoodsName.Text = m_GoodsItem.GoodsName;
            tbGoodsNO.Text = m_GoodsItem.GoodsNO;
            tbIntegral.Text = m_GoodsItem.Integral.ToString();
            if(m_GoodsItem.IsCurrentPrice==1)
                cbIsCurrentPrice.Checked=true;
            tbPinYin.Text = m_GoodsItem.PinYin;
            cbUnit.Text = m_GoodsItem.Unit;
            tbUnitPrice.Text = m_GoodsItem.UnitPrice.ToString();         

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
            if(cbGoodsSubClassifyName.SelectedValue!=null)
                m_GoodsItem.GoodsSubClassify = cbGoodsSubClassifyName.SelectedValue.ToString();

            if (cbGoodsClassifyName.SelectedValue != null)
                m_GoodsItem.GoodsClassify = cbGoodsClassifyName.SelectedValue.ToString();
            m_GoodsItem.GoodsSubClassifyID = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassifyID(m_GoodsItem.GoodsClassify, m_GoodsItem.GoodsSubClassify);

            m_GoodsItem.Cost=Convert.ToDouble(tbCost.Text);
            m_GoodsItem.Deduct=Convert.ToDouble(tbDeduct.Text);
            m_GoodsItem.GoodsCode=tbGoodsCode.Text;
            m_GoodsItem.GoodsName=tbGoodsName.Text;
            m_GoodsItem.GoodsNO=tbGoodsNO.Text;
            m_GoodsItem.Integral = Convert.ToDouble(tbIntegral.Text);
            if (cbIsCurrentPrice.Checked == true)
                m_GoodsItem.IsCurrentPrice = 1;
            else
                m_GoodsItem.IsCurrentPrice = 0;

            m_GoodsItem.PinYin=tbPinYin.Text ;
            m_GoodsItem.Unit=cbUnit.Text;
            m_GoodsItem.UnitPrice=Convert.ToDouble(tbUnitPrice.Text);

            bool bRet = false;
            if (m_GoodsItem.GoodsID == 0)
            {
                bRet=CGlobalInstance.Instance.DbAdaHelper.AddGoods(m_GoodsItem);
            }
            else
            {
                bRet=CGlobalInstance.Instance.DbAdaHelper.UpdateGoods(m_GoodsItem);
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

        private void tbUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbDeduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbIntegral_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbGoodsCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }

        private void tbGoodsName_TextChanged(object sender, EventArgs e)
        {
            tbPinYin.Text = MixFunc.ChinaSpell.GetChineseSpellA(tbGoodsName.Text);
        }
    }
}