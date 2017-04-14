using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MixLib;

namespace Restaurant
{
    public partial class FormStyle : Form
    {
        public FormStyle()
        {
            InitializeComponent();
        }

        private void btYes_Click(object sender, EventArgs e)
        {
            if (tbMainTitle.Text!="")
                CAppOption.WindowTitle=tbMainTitle.Text;
            CAppOption.iFormStyle = cbStyle.SelectedIndex;
            CAppOption.iSortStyle = cbSort.SelectedIndex;
            CAppOption.NumberFormat = cbNumberFormat.Text;
            CAppOption.MoneyFormat = cbMoneyFormat.Text;
            CAppOption.Idiograph = tbIdiograph.Text;
            try
            {
                CAppOption.PageRowCount = Convert.ToInt32(tbPageRowCount.Text);

                if (CAppOption.PageRowCount < 10)
                    CAppOption.PageRowCount = 10;

                if (CAppOption.PageRowCount > 40)
                    CAppOption.PageRowCount = 40;
            }
            catch
            {
            }

            this.DialogResult = DialogResult.Yes;
        }

        private void FormStyle_Load(object sender, EventArgs e)
        {
            tbMainTitle.Text = CAppOption.WindowTitle;
            cbStyle.SelectedIndex = CAppOption.iFormStyle;
            cbSort.SelectedIndex = CAppOption.iSortStyle;
            cbNumberFormat.Text=CAppOption.NumberFormat ;
            cbMoneyFormat.Text = CAppOption.MoneyFormat;
            tbPageRowCount.Text = CAppOption.PageRowCount.ToString();
            tbIdiograph.Text=CAppOption.Idiograph ;
            if (CAppOption.m_lUserID <0)
            {
                tbIdiograph.Enabled = false;
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (CAppOption.m_lUserID <= 0)
            {
                UserModule.FrmLogin mLogin = new UserModule.FrmLogin();
                if (mLogin.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("你没有权限!");
                    return;
                }
                else
                {
                    tbIdiograph.Enabled = true;
                }
            }
        }
    }
}