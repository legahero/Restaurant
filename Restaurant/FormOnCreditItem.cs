using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormOnCreditItem : Form
    {
        public _tagOnCredit m_OnCreditItem;

        public FormOnCreditItem()
        {
            m_OnCreditItem = new _tagOnCredit();

            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            m_OnCreditItem.ClientName=tbClientName.Text;
            m_OnCreditItem.Address=tbAddress.Text;
            m_OnCreditItem.Company=tbCompany.Text  ;
            m_OnCreditItem.PostCode=tbPostCode.Text ;

            m_OnCreditItem.Phone=tbPhone.Text  ;
            m_OnCreditItem.MobilePhone=tbMobilePhone.Text  ;
            m_OnCreditItem.OnCreditLimit = Convert.ToDouble(tbOnCreditLimit.Text);
            m_OnCreditItem.OnCreditSum = Convert.ToDouble(tbOnCreditSum.Text); 

            m_OnCreditItem.Remark=tbRemark.Text ;

            bool bRet = false;
            if (m_OnCreditItem.OnCreditID <= 0)
            {
                bRet=CGlobalInstance.Instance.DbAdaHelper.AddOnCredit(m_OnCreditItem);
            }
            else
            {
                bRet = CGlobalInstance.Instance.DbAdaHelper.UpdateOnCredit(m_OnCreditItem);
            }
            if (bRet==true)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormOnCreditItem_Load(object sender, EventArgs e)
        {
            tbClientName.Text=m_OnCreditItem.ClientName;
            tbAddress.Text = m_OnCreditItem.Address;
            tbCompany.Text = m_OnCreditItem.Company;
            tbPostCode.Text = m_OnCreditItem.PostCode;

            tbPhone.Text = m_OnCreditItem.Phone;
            tbMobilePhone.Text = m_OnCreditItem.MobilePhone;
            tbOnCreditSum.Text = m_OnCreditItem.OnCreditSum.ToString();
            tbOnCreditLimit.Text = m_OnCreditItem.OnCreditLimit.ToString();

            tbRemark.Text = m_OnCreditItem.Remark;
        }

        private void tbOnCreditLimit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}