using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormDiningTable2 : Form
    {
        public int m_DiningDeptID = -1;

        public FormDiningTable2()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            _tagDiningTable m_DiningTable=new _tagDiningTable();

            int TableNO = Convert.ToInt32(tbTableNO.Text);
            int Number=Convert.ToInt32(tbNumber.Text);

            m_DiningTable.TableClassifyID = (int)cbTableClassifyID.SelectedValue;
            m_DiningTable.DiningDeptID = (int)cbDiningDeptID.SelectedValue;

            for (int i = TableNO; i < TableNO + Number; i++)
            {
                m_DiningTable.TableNO = i;
                m_DiningTable.TableName = tbTableName.Text + i.ToString();
                
                CGlobalInstance.Instance.DbAdaHelper.AddDiningTable(m_DiningTable);                
            }

            this.DialogResult = DialogResult.OK;
        }

        private void FormDiningTable2_Load(object sender, EventArgs e)
        {
            cbTableClassifyID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetTableClassify();
            cbTableClassifyID.DisplayMember = "ClassifyName";
            cbTableClassifyID.ValueMember = "TableClassifyID";

            cbDiningDeptID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningDept();
            cbDiningDeptID.DisplayMember = "DeptName";
            cbDiningDeptID.ValueMember = "DiningDeptID";

            cbDiningDeptID.SelectedValue = m_DiningDeptID;
        }
    }
}