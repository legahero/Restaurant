using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormTransfer : Form
    {
        public int OldTableNO;
        public int NewTableNO;


        public FormTransfer()
        {
            InitializeComponent();
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            lblPrompt.Text = string.Format("确实需要把[{0}]换入新的台吗？",OldTableNO);
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            NewTableNO = Convert.ToInt32(tbNewTableNo.Text);

            if (CGlobalInstance.Instance.DbAdaHelper.IsIdleDiningTable(NewTableNO)>0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("要换入的台不存在或未处于空闲！");
            }
        }
    }
}