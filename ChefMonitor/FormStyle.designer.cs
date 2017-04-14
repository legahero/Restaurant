namespace ChefMonitor
{
    partial class FormStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStyle));
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btYes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNumberFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPageRowCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbMoneyFormat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdiograph = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbMainTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "股票行情",
            "白水蓝天",
            "雨后彩虹",
            "山水国画"});
            this.cbStyle.Location = new System.Drawing.Point(106, 37);
            this.cbStyle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(200, 20);
            this.cbStyle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "风格：";
            // 
            // btYes
            // 
            this.btYes.Location = new System.Drawing.Point(151, 206);
            this.btYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(56, 18);
            this.btYes.TabIndex = 2;
            this.btYes.Text = "确认";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "数字格式:";
            // 
            // cbNumberFormat
            // 
            this.cbNumberFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumberFormat.FormattingEnabled = true;
            this.cbNumberFormat.Items.AddRange(new object[] {
            "0",
            "0.00",
            "0.000",
            "0.0000"});
            this.cbNumberFormat.Location = new System.Drawing.Point(106, 65);
            this.cbNumberFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNumberFormat.Name = "cbNumberFormat";
            this.cbNumberFormat.Size = new System.Drawing.Size(102, 20);
            this.cbNumberFormat.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "分页行数:";
            // 
            // tbPageRowCount
            // 
            this.tbPageRowCount.Location = new System.Drawing.Point(106, 120);
            this.tbPageRowCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPageRowCount.Name = "tbPageRowCount";
            this.tbPageRowCount.Size = new System.Drawing.Size(102, 21);
            this.tbPageRowCount.TabIndex = 6;
            this.tbPageRowCount.Text = "22";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "(10-40)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "排序风格:";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "送厨时间",
            "菜名",
            "类型",
            "下单时间",
            "部门,送厨时间",
            "部门,下单时间",
            "台名,送厨时间",
            "台名,下单时间",
            "部门,台名,送厨时间",
            "部门,台名,下单时间",
            "部门,台名,出厨时间"});
            this.cbSort.Location = new System.Drawing.Point(106, 150);
            this.cbSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(200, 20);
            this.cbSort.TabIndex = 9;
            // 
            // cbMoneyFormat
            // 
            this.cbMoneyFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoneyFormat.FormattingEnabled = true;
            this.cbMoneyFormat.Items.AddRange(new object[] {
            "0.0",
            "0.00",
            "0.000"});
            this.cbMoneyFormat.Location = new System.Drawing.Point(106, 93);
            this.cbMoneyFormat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMoneyFormat.Name = "cbMoneyFormat";
            this.cbMoneyFormat.Size = new System.Drawing.Size(102, 20);
            this.cbMoneyFormat.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "金额格式:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "签名:";
            // 
            // tbIdiograph
            // 
            this.tbIdiograph.Location = new System.Drawing.Point(106, 177);
            this.tbIdiograph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIdiograph.Name = "tbIdiograph";
            this.tbIdiograph.Size = new System.Drawing.Size(102, 21);
            this.tbIdiograph.TabIndex = 13;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(229, 180);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(56, 18);
            this.btLogin.TabIndex = 19;
            this.btLogin.Text = "鉴权";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // tbMainTitle
            // 
            this.tbMainTitle.Location = new System.Drawing.Point(106, 11);
            this.tbMainTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbMainTitle.Name = "tbMainTitle";
            this.tbMainTitle.Size = new System.Drawing.Size(200, 21);
            this.tbMainTitle.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "主界面标题:";
            // 
            // FormStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 230);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbMainTitle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbIdiograph);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMoneyFormat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPageRowCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNumberFormat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStyle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStyle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "界面风格";
            this.Load += new System.EventHandler(this.FormStyle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNumberFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPageRowCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.ComboBox cbMoneyFormat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdiograph;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbMainTitle;
        private System.Windows.Forms.Label label8;
    }
}