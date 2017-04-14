using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MixFunc;
using YyPrint;
using System.Collections.Specialized;

namespace Restaurant
{
    public partial class FormSysSetting : Form
    {
        public FormSysSetting()
        {
            InitializeComponent();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (cbPrompt.Checked == true) CRunSetting.Prompt = 1;
            else CRunSetting.Prompt = 0;
            if (cbAutoClearTable.Checked == true) CRunSetting.AutoClearTable = 1;
            else CRunSetting.AutoClearTable = 0;
            if (cbAutoOpenCashbox.Checked == true) CRunSetting.AutoOpenCashbox = 1;
            else CRunSetting.AutoOpenCashbox = 0;
            CRunSetting.MoneyStype=cbMoneyStype.SelectedIndex ;

            CRunSetting.CashboxPort=cbCashboxPort.Text  ;
            CRunSetting.ClientPromptPort=cbClientPromptPort.Text  ;

            CRunSetting.BillPrinter=cbBillPrinter.Text  ;
            CRunSetting.BillMode=cbBillMode.Text  ;

            CRunSetting.OrderPrinter=cbOrderPrinter.Text  ;
            CRunSetting.OrderMode=cbOrderMode.Text  ;

            CRunSetting.ServingPrinter=cbServingPrinter.Text  ;
            CRunSetting.ServingMode=cbServingMode.Text  ;

            CRunSetting.ReportPrinter=cbReportPrinter.Text  ;
            CRunSetting.ReportMode=cbReportMode.Text  ;

            CRunSetting.SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void FormSysSetting_Load(object sender, EventArgs e)
        {
            cbBillPrinter.DataSource = CGenPrint.GetPrints();
            cbOrderPrinter.DataSource = CGenPrint.GetPrints();
            cbServingPrinter.DataSource = CGenPrint.GetPrints();
            cbReportPrinter.DataSource = CGenPrint.GetPrints();

            if (CRunSetting.Prompt == 1) cbPrompt.Checked = true;
            if (CRunSetting.AutoClearTable == 1) cbAutoClearTable.Checked = true;
            if (CRunSetting.AutoOpenCashbox == 1) cbAutoOpenCashbox.Checked = true;
            cbMoneyStype.SelectedIndex = CRunSetting.MoneyStype;

            cbCashboxPort.Text = CRunSetting.CashboxPort;
            cbClientPromptPort.Text = CRunSetting.ClientPromptPort;

            cbBillPrinter.Text = CRunSetting.BillPrinter;
            cbBillMode.Text = CRunSetting.BillMode;

            cbOrderPrinter.Text = CRunSetting.OrderPrinter;
            cbOrderMode.Text = CRunSetting.OrderMode;

            cbServingPrinter.Text = CRunSetting.ServingPrinter;
            cbServingMode.Text = CRunSetting.ServingMode;

            cbReportPrinter.Text = CRunSetting.ReportPrinter;
            cbReportMode.Text = CRunSetting.ReportMode;

            
        }

        private void cbBillPrinter_TextChanged(object sender, EventArgs e)
        {
            cbBillMode.DataSource = CGenPrint.GetPaperSizes(cbBillPrinter.Text);
        }

        private void cbOrderPrinter_TextChanged(object sender, EventArgs e)
        {
            cbOrderMode.DataSource = CGenPrint.GetPaperSizes(cbOrderPrinter.Text);
        }

        private void cbServingPrinter_TextChanged(object sender, EventArgs e)
        {
            cbServingMode.DataSource = CGenPrint.GetPaperSizes(cbServingPrinter.Text);
        }

        private void cbReportPrinter_TextChanged(object sender, EventArgs e)
        {
            cbReportMode.DataSource = CGenPrint.GetPaperSizes(cbReportPrinter.Text);
        }
    }
}