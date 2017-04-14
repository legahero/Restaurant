using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormGoodsClassify : Form
    {
        public FormGoodsClassify()
        {
            InitializeComponent();

            InitView();
        }
        void InitView()
        {
            dgvGoodsClassify.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnGoodsClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsClassify.DataPropertyName = "GoodsClassify";
            ColumnGoodsClassify.Name = "ColumnGoodsClassify";
            ColumnGoodsClassify.HeaderText = "大类码";
            ColumnGoodsClassify.Width = 80;
            ColumnGoodsClassify.FillWeight = 40F;
            ColumnGoodsClassify.ReadOnly = true;
            dgvGoodsClassify.Columns.Add(ColumnGoodsClassify);

            DataGridViewTextBoxColumn ColumnGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnGoodsClassifyName.DataPropertyName = "GoodsClassifyName";
            ColumnGoodsClassifyName.Name = "ColumnGoodsClassifyName";
            ColumnGoodsClassifyName.HeaderText = "分类名称";
            ColumnGoodsClassifyName.Width = 250;
            ColumnGoodsClassifyName.FillWeight = 40F;
            ColumnGoodsClassifyName.ReadOnly = true;
            dgvGoodsClassify.Columns.Add(ColumnGoodsClassifyName);

            dgvGoodsSubClassify.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn ColumnGoodsSubClassifyID = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassifyID.DataPropertyName = "GoodsSubClassifyID";
            ColumnGoodsSubClassifyID.Name = "ColumnGoodsSubClassifyID";
            ColumnGoodsSubClassifyID.HeaderText = "ID";
            ColumnGoodsSubClassifyID.Visible = false;
            ColumnGoodsSubClassifyID.Width = 30;
            ColumnGoodsSubClassifyID.FillWeight = 40F;
            ColumnGoodsSubClassifyID.ReadOnly = true;
            ColumnGoodsSubClassifyID.Visible = false;
            dgvGoodsSubClassify.Columns.Add(ColumnGoodsSubClassifyID);

            DataGridViewTextBoxColumn ColumnGoodsClassify2 = new DataGridViewTextBoxColumn();
            ColumnGoodsClassify2.DataPropertyName = "GoodsClassify";
            ColumnGoodsClassify2.Name = "ColumnGoodsClassify2";
            ColumnGoodsClassify2.HeaderText = "大类码";
            ColumnGoodsClassify2.Width = 80;
            ColumnGoodsClassify2.FillWeight = 40F;
            ColumnGoodsClassify2.ReadOnly = true;
            ColumnGoodsClassify2.Visible = false;
            dgvGoodsSubClassify.Columns.Add(ColumnGoodsClassify2);

            DataGridViewTextBoxColumn ColumnGoodsSubClassify = new DataGridViewTextBoxColumn();
            ColumnGoodsSubClassify.DataPropertyName = "GoodsSubClassify";
            ColumnGoodsSubClassify.Name = "ColumnGoodsSubClassify";
            ColumnGoodsSubClassify.HeaderText = "小类码";
            ColumnGoodsSubClassify.Width = 80;
            ColumnGoodsSubClassify.FillWeight = 40F;
            ColumnGoodsSubClassify.ReadOnly = true;
            dgvGoodsSubClassify.Columns.Add(ColumnGoodsSubClassify);

            DataGridViewTextBoxColumn ColumnSubGoodsClassifyName = new DataGridViewTextBoxColumn();
            ColumnSubGoodsClassifyName.DataPropertyName = "GoodsSubClassifyName";
            ColumnSubGoodsClassifyName.Name = "ColumnSubGoodsClassifyName";
            ColumnSubGoodsClassifyName.HeaderText = "分类名称";
            ColumnSubGoodsClassifyName.Width = 250;
            ColumnSubGoodsClassifyName.FillWeight = 40F;
            ColumnSubGoodsClassifyName.ReadOnly = true;
            dgvGoodsSubClassify.Columns.Add(ColumnSubGoodsClassifyName);
        }
        private void FormGoodsClassify_Load(object sender, EventArgs e)
        {
            DataRefresh();
        }
        void DataRefresh()
        {
            dgvGoodsClassify.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsClassify();
            DataRefreshB();
        }
        void DataRefreshB()
        {
            if (dgvGoodsClassify.CurrentRow != null)
            {
                string GoodsClassify = dgvGoodsClassify.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString();
                dgvGoodsSubClassify.DataSource = CGlobalInstance.Instance.DbAdaHelper.GetGoodsSubClassify(GoodsClassify);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbGoodsClassify.Text) && !string.IsNullOrEmpty(tbGoodsClassifyName.Text))
            {
                if (CGlobalInstance.Instance.DbAdaHelper.AddGoodsClassify(tbGoodsClassify.Text, tbGoodsClassifyName.Text) != true)
                {
                    MessageBox.Show("增加失败,注意编码不能有相同!");
                }
                else
                {
                    DataRefresh();
                    tbGoodsClassify.Text = "";
                    tbGoodsClassifyName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("编码和名称不能为空!");
            }
        }

        private void btSubAdd_Click(object sender, EventArgs e)
        {
            if (dgvGoodsClassify.CurrentRow != null)
            {
                string GoodsClassify = dgvGoodsClassify.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString();
                if (!string.IsNullOrEmpty(tbGoodsSubClassify.Text) && !string.IsNullOrEmpty(tbGoodsSubClassifyName.Text))
                {
                    string GoodsSubClassifyB="";
                    foreach (DataGridViewRow dr in dgvGoodsSubClassify.Rows)
                    {
                        GoodsSubClassifyB = dr.Cells["ColumnGoodsSubClassify"].Value.ToString();
                        if (GoodsSubClassifyB == tbGoodsSubClassify.Text)
                        {
                            MessageBox.Show("增加失败,注意编码不能有相同!");
                            return;
                        }
                    }
                    //有待增加代码
                    if (CGlobalInstance.Instance.DbAdaHelper.AddGoodsSubClassify(GoodsClassify, tbGoodsSubClassify.Text, tbGoodsSubClassifyName.Text) != true)
                    {
                        MessageBox.Show("增加失败,注意编码不能有相同!");
                    }
                    else
                    {
                        tbGoodsSubClassify.Text = "";
                        tbGoodsSubClassifyName.Text = "";
                        DataRefreshB();
                    }
                }
                else
                {
                    MessageBox.Show("编码和名称不能为空!");
                }
            }
        }
        
        private void toolStripButtonDelClassify_Click(object sender, EventArgs e)
        {
            if (dgvGoodsClassify.CurrentRow != null)
            {
                string GoodsClassify = dgvGoodsClassify.CurrentRow.Cells["ColumnGoodsClassify"].Value.ToString();

                
                if (CGlobalInstance.Instance.DbAdaHelper.DeleteGoodsClassify(GoodsClassify))
                {
                    DataRefresh();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void toolStripButtonDelSubClassify_Click(object sender, EventArgs e)
        {
            if (dgvGoodsSubClassify.CurrentRow != null)
            {
                int GoodsSubClassifyID = Convert.ToInt32(dgvGoodsSubClassify.CurrentRow.Cells["GoodsSubClassifyID"].Value);

                
                if (CGlobalInstance.Instance.DbAdaHelper.DeleteGoodsSubClassify(GoodsSubClassifyID))
                {
                    DataRefreshB();
                    
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void dgvGoodsClassify_SelectionChanged(object sender, EventArgs e)
        {
            DataRefreshB();
        }
    }
}