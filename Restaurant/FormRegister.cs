using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormRegister : Form
    {
        public string CodeNO="";
        public string KeyNO = "";

        public bool bRegister = false;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            tbCode.Text = CodeNO;
            tbKey.Text = KeyNO;
            if (bRegister == true)
            {
                tbKey.Enabled = false;
            }
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            KeyNO = tbKey.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}