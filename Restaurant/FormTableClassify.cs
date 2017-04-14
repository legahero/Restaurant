using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class FormTableClassify : Form
    {
        public _tagTableClassify m_TableClassify;
        public FormTableClassify()
        {
            m_TableClassify = new _tagTableClassify();
            InitializeComponent();            
        }

        private void FormTableClassify_Load(object sender, EventArgs e)
        {
            tbClassifyName.Text = m_TableClassify.ClassifyName;
            tbAdmitNumber.Text = m_TableClassify.AdmitNumber;
            tbSeatCost.Text = m_TableClassify.SeatCost.ToString();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tbClassifyName.Text == "" || tbAdmitNumber.Text == "")
            {
                MessageBox.Show("分类、容纳人数不能空!");
                return;
            }

            m_TableClassify.ClassifyName = tbClassifyName.Text;
            m_TableClassify.AdmitNumber = tbAdmitNumber.Text;
            if (tbSeatCost.Text != "")
                m_TableClassify.SeatCost = Convert.ToDouble(tbSeatCost.Text);
            else
                m_TableClassify.SeatCost = 0;

            if (m_TableClassify.TableClassifyID==0)
            {
                CGlobalInstance.Instance.DbAdaHelper.AddTableClassify(m_TableClassify.ClassifyName, m_TableClassify.AdmitNumber, m_TableClassify.SeatCost);
            }else{
                CGlobalInstance.Instance.DbAdaHelper.UpdateTableClassify(m_TableClassify.TableClassifyID, m_TableClassify.ClassifyName, m_TableClassify.AdmitNumber, m_TableClassify.SeatCost);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}