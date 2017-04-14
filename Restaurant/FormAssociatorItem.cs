using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormAssociatorItem : Form
    {
        public _tagAssociator m_AssociatorItem;
        public FormAssociatorItem()
        {
            m_AssociatorItem = new _tagAssociator();

            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tbCardID.Text == "" || tbAssociator.Text == "")
            {
                MessageBox.Show("卡号和客户不能为空!");
                return;
            }

            m_AssociatorItem.CardID = tbCardID.Text;
            m_AssociatorItem.CardPwd = tbCardPwd.Text;
            if(cbClassifyID.SelectedValue!=null)
                m_AssociatorItem.ClassifyID = Convert.ToInt32(cbClassifyID.SelectedValue);

            m_AssociatorItem.Associator = tbAssociator.Text;
            m_AssociatorItem.IdentityCard = tbIdentityCard.Text;

            m_AssociatorItem.Address = tbAddress.Text;
            m_AssociatorItem.Company = tbCompany.Text;
            m_AssociatorItem.PostCode = tbPostCode.Text;

            m_AssociatorItem.Phone = tbPhone.Text;
            m_AssociatorItem.MobilePhone = tbMobilePhone.Text;
            m_AssociatorItem.Surplus = Convert.ToDouble(tbSurplus.Text);
            m_AssociatorItem.Integral = Convert.ToInt32(tbIntegral.Text);

            m_AssociatorItem.Remark = tbRemark.Text;

            m_AssociatorItem.EndDate = dateTimePicker1.Value;
            m_AssociatorItem.RecordTime = dateTimePicker2.Value;

            bool bRet = false;
            if (m_AssociatorItem.AssociatorID <= 0)
            {
                bRet = CGlobalInstance.Instance.DbAdaHelper.AddAssociator(m_AssociatorItem);
            }
            else
            {
                bRet = CGlobalInstance.Instance.DbAdaHelper.UpdateAssociator(m_AssociatorItem);
            }
            if (bRet == true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormAssociatorItem_Load(object sender, EventArgs e)
        { 
            tbCardID.Text=m_AssociatorItem.CardID;
            tbCardPwd.Text=m_AssociatorItem.CardPwd;
            

            tbIdentityCard.Text = m_AssociatorItem.IdentityCard;
            tbAssociator.Text = m_AssociatorItem.Associator;
            tbAddress.Text = m_AssociatorItem.Address;
            tbCompany.Text = m_AssociatorItem.Company;
            tbPostCode.Text = m_AssociatorItem.PostCode;

            tbPhone.Text = m_AssociatorItem.Phone;
            tbMobilePhone.Text = m_AssociatorItem.MobilePhone;
            tbSurplus.Text = m_AssociatorItem.Surplus.ToString();
            tbIntegral.Text = m_AssociatorItem.Integral.ToString();

            dateTimePicker1.Value=m_AssociatorItem.EndDate;
            dateTimePicker2.Value=m_AssociatorItem.RecordTime;

            cbClassifyID.DisplayMember = "ClassifyName";
            cbClassifyID.ValueMember = "ClassifyID";
            cbClassifyID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociatorClassify();

            cbClassifyID.SelectedValue = m_AssociatorItem.ClassifyID;

            tbRemark.Text = m_AssociatorItem.Remark;
        }

        private void cbClassifyID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_AssociatorItem.AssociatorID <= 0)
            {
                int TimeLimit=365;
                if (cbClassifyID.SelectedValue != null && !(cbClassifyID.SelectedValue is System.Data.DataRowView))
                {
                    int ClassifyID=Convert.ToInt32(cbClassifyID.SelectedValue);
                    TimeLimit=CGlobalInstance.Instance.DbAdaHelper.GetAssociatorClassifyTimeLimit(ClassifyID);
                }
                DateTime dt = DateTime.Now.AddDays(TimeLimit);
                dateTimePicker1.Value = dt;
            }
        }

        private void btClassify_Click(object sender, EventArgs e)
        {
            FormAssociatorClassify dlg = new FormAssociatorClassify();

            dlg.ShowDialog();

            cbClassifyID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetAssociatorClassify();
            cbClassifyID.DisplayMember = "ClassifyName";
            cbClassifyID.ValueMember = "ClassifyID";
        }
    }
}