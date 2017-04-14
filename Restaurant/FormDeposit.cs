using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormDeposit : Form
    {
        public string CardID = "";
        public string Associator = "";
        public double Value = 0;
        public string Remark = "";
        public FormDeposit()
        {
            InitializeComponent();
        }

        private void FormDeposit_Load(object sender, EventArgs e)
        {
            tbCardID.Text = CardID;
            tbAssociator.Text = Associator;
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