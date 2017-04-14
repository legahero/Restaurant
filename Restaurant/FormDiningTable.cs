using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormDiningTable : Form
    {
        public _tagDiningTable m_DiningTable;

        public FormDiningTable()
        {
            m_DiningTable = new _tagDiningTable();
            InitializeComponent();
        }

        private void FormDiningTable_Load(object sender, EventArgs e)
        {
            cbTableClassifyID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetTableClassify();
            cbTableClassifyID.DisplayMember = "ClassifyName";
            cbTableClassifyID.ValueMember = "TableClassifyID";

            cbDiningDeptID.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetDiningDept();
            cbDiningDeptID.DisplayMember = "DeptName";
            cbDiningDeptID.ValueMember = "DiningDeptID";  

            tbTableNO.Text=m_DiningTable.TableNO.ToString();
            tbTableName.Text = m_DiningTable.TableName;
            cbTableClassifyID.SelectedValue = m_DiningTable.TableClassifyID;
            cbDiningDeptID.SelectedValue = m_DiningTable.DiningDeptID;
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            m_DiningTable.TableNO = Convert.ToInt32(tbTableNO.Text);
            m_DiningTable.TableName=tbTableName.Text;
            m_DiningTable.TableClassifyID=(int)cbTableClassifyID.SelectedValue;
            m_DiningTable.DiningDeptID = (int)cbDiningDeptID.SelectedValue;

            if (m_DiningTable.DiningTableID == 0)
            {
                if (CGlobalInstance.Instance.DbAdaHelper.AddDiningTable(m_DiningTable) != true)
                {
                    MessageBox.Show("保存失败，台号不能重复!");
                }
            }
            else
            {
                if (CGlobalInstance.Instance.DbAdaHelper.UpdateDiningTable(m_DiningTable) != true)
                {
                    MessageBox.Show("修改失败，请检查输入!");
                }
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}