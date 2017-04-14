namespace Restaurant
{
    partial class FormSysSetting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSysSetting));
            this.cbPrompt = new System.Windows.Forms.CheckBox();
            this.cbAutoClearTable = new System.Windows.Forms.CheckBox();
            this.cbCashboxPort = new System.Windows.Forms.ComboBox();
            this.cbClientPromptPort = new System.Windows.Forms.ComboBox();
            this.cbAutoOpenCashbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRunSet = new System.Windows.Forms.TabPage();
            this.cbMoneyStype = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpPrintSet = new System.Windows.Forms.TabPage();
            this.cbReportMode = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbReportPrinter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbServingMode = new System.Windows.Forms.ComboBox();
            this.cbOrderMode = new System.Windows.Forms.ComboBox();
            this.cbBillMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbServingPrinter = new System.Windows.Forms.ComboBox();
            this.cbOrderPrinter = new System.Windows.Forms.ComboBox();
            this.cbBillPrinter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpRunSet.SuspendLayout();
            this.tpPrintSet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPrompt
            // 
            this.cbPrompt.AutoSize = true;
            this.cbPrompt.Location = new System.Drawing.Point(18, 9);
            this.cbPrompt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPrompt.Name = "cbPrompt";
            this.cbPrompt.Size = new System.Drawing.Size(84, 16);
            this.cbPrompt.TabIndex = 0;
            this.cbPrompt.Text = "结帐时提示";
            this.cbPrompt.UseVisualStyleBackColor = true;
            // 
            // cbAutoClearTable
            // 
            this.cbAutoClearTable.AutoSize = true;
            this.cbAutoClearTable.Location = new System.Drawing.Point(18, 37);
            this.cbAutoClearTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoClearTable.Name = "cbAutoClearTable";
            this.cbAutoClearTable.Size = new System.Drawing.Size(108, 16);
            this.cbAutoClearTable.TabIndex = 1;
            this.cbAutoClearTable.Text = "结帐时自动清台";
            this.cbAutoClearTable.UseVisualStyleBackColor = true;
            // 
            // cbCashboxPort
            // 
            this.cbCashboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCashboxPort.FormattingEnabled = true;
            this.cbCashboxPort.Items.AddRange(new object[] {
            "LPT1",
            "LPT2",
            "COM1"});
            this.cbCashboxPort.Location = new System.Drawing.Point(85, 95);
            this.cbCashboxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCashboxPort.Name = "cbCashboxPort";
            this.cbCashboxPort.Size = new System.Drawing.Size(92, 20);
            this.cbCashboxPort.TabIndex = 2;
            // 
            // cbClientPromptPort
            // 
            this.cbClientPromptPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientPromptPort.FormattingEnabled = true;
            this.cbClientPromptPort.Items.AddRange(new object[] {
            "无",
            "COM1",
            "COM2"});
            this.cbClientPromptPort.Location = new System.Drawing.Point(85, 128);
            this.cbClientPromptPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbClientPromptPort.Name = "cbClientPromptPort";
            this.cbClientPromptPort.Size = new System.Drawing.Size(92, 20);
            this.cbClientPromptPort.TabIndex = 3;
            // 
            // cbAutoOpenCashbox
            // 
            this.cbAutoOpenCashbox.AutoSize = true;
            this.cbAutoOpenCashbox.Location = new System.Drawing.Point(18, 65);
            this.cbAutoOpenCashbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoOpenCashbox.Name = "cbAutoOpenCashbox";
            this.cbAutoOpenCashbox.Size = new System.Drawing.Size(120, 16);
            this.cbAutoOpenCashbox.TabIndex = 4;
            this.cbAutoOpenCashbox.Text = "结帐时自动开钱箱";
            this.cbAutoOpenCashbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "钱箱端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "客显端口:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRunSet);
            this.tabControl1.Controls.Add(this.tpPrintSet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 180);
            this.tabControl1.TabIndex = 7;
            // 
            // tpRunSet
            // 
            this.tpRunSet.Controls.Add(this.cbMoneyStype);
            this.tpRunSet.Controls.Add(this.label11);
            this.tpRunSet.Controls.Add(this.cbAutoOpenCashbox);
            this.tpRunSet.Controls.Add(this.label2);
            this.tpRunSet.Controls.Add(this.cbPrompt);
            this.tpRunSet.Controls.Add(this.label1);
            this.tpRunSet.Controls.Add(this.cbAutoClearTable);
            this.tpRunSet.Controls.Add(this.cbCashboxPort);
            this.tpRunSet.Controls.Add(this.cbClientPromptPort);
            this.tpRunSet.Location = new System.Drawing.Point(4, 22);
            this.tpRunSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRunSet.Name = "tpRunSet";
            this.tpRunSet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpRunSet.Size = new System.Drawing.Size(450, 154);
            this.tpRunSet.TabIndex = 0;
            this.tpRunSet.Text = "运行设置";
            this.tpRunSet.UseVisualStyleBackColor = true;
            // 
            // cbMoneyStype
            // 
            this.cbMoneyStype.FormattingEnabled = true;
            this.cbMoneyStype.Items.AddRange(new object[] {
            "舍去小数",
            "一位小数",
            "二位小数"});
            this.cbMoneyStype.Location = new System.Drawing.Point(323, 7);
            this.cbMoneyStype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMoneyStype.Name = "cbMoneyStype";
            this.cbMoneyStype.Size = new System.Drawing.Size(92, 20);
            this.cbMoneyStype.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "结帐金额取整:";
            // 
            // tpPrintSet
            // 
            this.tpPrintSet.Controls.Add(this.cbReportMode);
            this.tpPrintSet.Controls.Add(this.label10);
            this.tpPrintSet.Controls.Add(this.cbReportPrinter);
            this.tpPrintSet.Controls.Add(this.label9);
            this.tpPrintSet.Controls.Add(this.cbServingMode);
            this.tpPrintSet.Controls.Add(this.cbOrderMode);
            this.tpPrintSet.Controls.Add(this.cbBillMode);
            this.tpPrintSet.Controls.Add(this.label8);
            this.tpPrintSet.Controls.Add(this.label7);
            this.tpPrintSet.Controls.Add(this.label6);
            this.tpPrintSet.Controls.Add(this.cbServingPrinter);
            this.tpPrintSet.Controls.Add(this.cbOrderPrinter);
            this.tpPrintSet.Controls.Add(this.cbBillPrinter);
            this.tpPrintSet.Controls.Add(this.label5);
            this.tpPrintSet.Controls.Add(this.label4);
            this.tpPrintSet.Controls.Add(this.label3);
            this.tpPrintSet.Location = new System.Drawing.Point(4, 22);
            this.tpPrintSet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPrintSet.Name = "tpPrintSet";
            this.tpPrintSet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpPrintSet.Size = new System.Drawing.Size(450, 155);
            this.tpPrintSet.TabIndex = 1;
            this.tpPrintSet.Text = "打印设置";
            this.tpPrintSet.UseVisualStyleBackColor = true;
            // 
            // cbReportMode
            // 
            this.cbReportMode.FormattingEnabled = true;
            this.cbReportMode.Items.AddRange(new object[] {
            "A4",
            "B4"});
            this.cbReportMode.Location = new System.Drawing.Point(321, 86);
            this.cbReportMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbReportMode.Name = "cbReportMode";
            this.cbReportMode.Size = new System.Drawing.Size(92, 20);
            this.cbReportMode.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "样式:";
            // 
            // cbReportPrinter
            // 
            this.cbReportPrinter.FormattingEnabled = true;
            this.cbReportPrinter.Location = new System.Drawing.Point(100, 86);
            this.cbReportPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbReportPrinter.Name = "cbReportPrinter";
            this.cbReportPrinter.Size = new System.Drawing.Size(170, 20);
            this.cbReportPrinter.TabIndex = 13;
            this.cbReportPrinter.TextChanged += new System.EventHandler(this.cbReportPrinter_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "报表打印机:";
            // 
            // cbServingMode
            // 
            this.cbServingMode.FormattingEnabled = true;
            this.cbServingMode.Location = new System.Drawing.Point(321, 63);
            this.cbServingMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbServingMode.Name = "cbServingMode";
            this.cbServingMode.Size = new System.Drawing.Size(92, 20);
            this.cbServingMode.TabIndex = 11;
            // 
            // cbOrderMode
            // 
            this.cbOrderMode.FormattingEnabled = true;
            this.cbOrderMode.Location = new System.Drawing.Point(321, 39);
            this.cbOrderMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOrderMode.Name = "cbOrderMode";
            this.cbOrderMode.Size = new System.Drawing.Size(92, 20);
            this.cbOrderMode.TabIndex = 10;
            // 
            // cbBillMode
            // 
            this.cbBillMode.FormattingEnabled = true;
            this.cbBillMode.Location = new System.Drawing.Point(321, 17);
            this.cbBillMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBillMode.Name = "cbBillMode";
            this.cbBillMode.Size = new System.Drawing.Size(92, 20);
            this.cbBillMode.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "样式:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "样式:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "样式:";
            // 
            // cbServingPrinter
            // 
            this.cbServingPrinter.FormattingEnabled = true;
            this.cbServingPrinter.Location = new System.Drawing.Point(100, 63);
            this.cbServingPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbServingPrinter.Name = "cbServingPrinter";
            this.cbServingPrinter.Size = new System.Drawing.Size(170, 20);
            this.cbServingPrinter.TabIndex = 5;
            this.cbServingPrinter.TextChanged += new System.EventHandler(this.cbServingPrinter_TextChanged);
            // 
            // cbOrderPrinter
            // 
            this.cbOrderPrinter.FormattingEnabled = true;
            this.cbOrderPrinter.Location = new System.Drawing.Point(100, 40);
            this.cbOrderPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOrderPrinter.Name = "cbOrderPrinter";
            this.cbOrderPrinter.Size = new System.Drawing.Size(170, 20);
            this.cbOrderPrinter.TabIndex = 4;
            this.cbOrderPrinter.TextChanged += new System.EventHandler(this.cbOrderPrinter_TextChanged);
            // 
            // cbBillPrinter
            // 
            this.cbBillPrinter.FormattingEnabled = true;
            this.cbBillPrinter.Location = new System.Drawing.Point(100, 17);
            this.cbBillPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBillPrinter.Name = "cbBillPrinter";
            this.cbBillPrinter.Size = new System.Drawing.Size(170, 20);
            this.cbBillPrinter.TabIndex = 3;
            this.cbBillPrinter.TextChanged += new System.EventHandler(this.cbBillPrinter_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "传菜打印机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "落单打印机:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "帐单打印机:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Cancel);
            this.panel1.Controls.Add(this.bt_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 38);
            this.panel1.TabIndex = 8;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(243, 6);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(74, 26);
            this.bt_Cancel.TabIndex = 35;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(141, 6);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(74, 26);
            this.bt_OK.TabIndex = 34;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // FormSysSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 218);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSysSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.FormSysSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpRunSet.ResumeLayout(false);
            this.tpRunSet.PerformLayout();
            this.tpPrintSet.ResumeLayout(false);
            this.tpPrintSet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPrompt;
        private System.Windows.Forms.CheckBox cbAutoClearTable;
        private System.Windows.Forms.ComboBox cbCashboxPort;
        private System.Windows.Forms.ComboBox cbClientPromptPort;
        private System.Windows.Forms.CheckBox cbAutoOpenCashbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRunSet;
        private System.Windows.Forms.TabPage tpPrintSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.ComboBox cbOrderPrinter;
        private System.Windows.Forms.ComboBox cbBillPrinter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbServingMode;
        private System.Windows.Forms.ComboBox cbOrderMode;
        private System.Windows.Forms.ComboBox cbBillMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbServingPrinter;
        private System.Windows.Forms.ComboBox cbReportMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbReportPrinter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMoneyStype;
        private System.Windows.Forms.Label label11;
    }
}