using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormUnite : Form
    {
        public int OldTableNO;
        public int NewTableNO;

        public FormUnite()
        {
            InitializeComponent();
        }

        private void FormUnite_Load(object sender, EventArgs e)
        {
            lblPrompt.Text = string.Format("确实需要把[{0}]并入新的台吗？", OldTableNO);
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            NewTableNO = Convert.ToInt32(tbNewTableNo.Text);

            if (CGlobalInstance.Instance.DbAdaHelper.IsUsingDiningTable(NewTableNO) > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("要并入的台不存在或未处于使用中！");
            }
        }
    }
}