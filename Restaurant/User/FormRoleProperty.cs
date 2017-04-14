using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserModule
{
    public partial class FormRoleProperty : Form
    {
        public UserDbAdaHelper m_DbAdaHelper = null;

        public long RoleID = -1;
        public string RoleName = "";
        public string Description = "";
        public FormRoleProperty()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            RoleName = tbRole.Text;
            Description = tbDesc.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void FormRoleProperty_Load(object sender, EventArgs e)
        {
            tbRole.Text = RoleName;
            tbDesc.Text = Description ;
        }
    }
}