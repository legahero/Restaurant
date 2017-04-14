using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormRepayment : Form
    {
        public string ClientName = "";
        public string Company = "";
        public double Value = 0;
        public string Remark = "";

        public FormRepayment()
        {
            InitializeComponent();
        }

        private void FormRepayment_Load(object sender, EventArgs e)
        {
            tbCompany.Text = Company;
            tbClientName.Text = ClientName;
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            try
            {
                Value = Convert.ToDouble(tbValue.Text);
                Remark = tbRemark.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("«Î ‰»Î ˝◊÷!");
            }
        }
    }
}