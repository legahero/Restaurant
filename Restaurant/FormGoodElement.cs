using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormGoodElement : Form
    {
        public _tagGoods m_GoodsItem = null;

        public int GoodsMaterialID=-1;
        public double Number = 0;

        public FormGoodElement()
        {
            InitializeComponent();
        }

        private void FormGoodElement_Load(object sender, EventArgs e)
        {
            if (m_GoodsItem == null)
            {
                MessageBox.Show("酒菜信息为空，无法进行其成分增加！");
                bt_OK.Enabled = false;
                return;
            }

            tbGoodName.Text = m_GoodsItem.GoodsName;

            cbMaterialName.DisplayMember = "MaterialName";
            cbMaterialName.ValueMember = "LongMaterialNO";
            cbMaterialName.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsMaterial();
            
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumber.Text))
            {
                try
                {
                    Number = Convert.ToInt32(tbNumber.Text);
                }
                catch
                {
                    MessageBox.Show("数量不对!");
                    return;
                }
            }

            if (cbMaterialName.SelectedItem is DataRowView)
            {
                DataRowView dr = (DataRowView)cbMaterialName.SelectedItem;
                GoodsMaterialID = Convert.ToInt32(dr["GoodsMaterialID"]);
                Number = Convert.ToDouble(tbNumber.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("找不到指定项!");
                return;
            }
        }

        private void cbMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bSet == false)
            {
                if (cbMaterialName.SelectedValue!=null)
                {
                    tbMaterialNO.Text = cbMaterialName.SelectedValue.ToString();
                    if (cbMaterialName.SelectedItem is DataRowView)
                    {
                        DataRowView dr = (DataRowView)cbMaterialName.SelectedItem;
                        lblUnit.Text = dr["Unit"].ToString();
                    }
                }
            }
        }
        bool bSet = false;
        private void tbMaterialNO_Leave(object sender, EventArgs e)
        {

            DataTable dt=CGlobalInstance.Instance.DbAdaHelper.GetGoodsMaterial(tbMaterialNO.Text);
            if(dt!=null&&dt.Rows.Count>0)
            {
                bSet = true;
                cbMaterialName.SelectedValue = tbMaterialNO.Text;

                DataRow dr = (DataRow)dt.Rows[0];
                lblUnit.Text = dr["Unit"].ToString();

                bSet = false;
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = MixFunc.CommConvert.DBCcaseNumber(e.KeyChar);   
        }
    }
}