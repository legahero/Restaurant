using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormDeptInfo : Form
    {
        public long GroupID = -1;
        public string GroupName = "";
        public string Address = "";
        public string Description = "";

        public UserDbAdaHelper m_DbAdaHelper = null;

        public FormDeptInfo()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            GroupName=editGroupName.Text ;
            Address=editAddress.Text ;
            Description=tbDescription.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void FormDeptInfo_Load(object sender, EventArgs e)
        {
            editGroupName.Text = GroupName;
            editAddress.Text = Address;
            tbDescription.Text=Description;

        }
    }
}