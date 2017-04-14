namespace Restaurant
{
    partial class FormBill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbVip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.tbBillTime = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBillNO = new System.Windows.Forms.TextBox();
            this.tbTableNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrompt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbVip);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTableName);
            this.groupBox1.Controls.Add(this.tbBillTime);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btStart);
            this.groupBox1.Controls.Add(this.tbRemark);
            this.groupBox1.Controls.Add(this.tbClientNumber);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbBillNO);
            this.groupBox1.Controls.Add(this.tbTableNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开台信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(380, 142);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(52, 15);
            this.lblPrompt.TabIndex = 21;
            this.lblPrompt.Text = "你选择";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "双击选择下列预定信息开台";
            // 
            // tbVip
            // 
            this.tbVip.Location = new System.Drawing.Point(85, 94);
            this.tbVip.Name = "tbVip";
            this.tbVip.Size = new System.Drawing.Size(222, 25);
            this.tbVip.TabIndex = 19;
            this.tbVip.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "VIP:";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "台名:";
            // 
            // tbTableName
            // 
            this.tbTableName.Enabled = false;
            this.tbTableName.Location = new System.Drawing.Point(85, 57);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(122, 25);
            this.tbTableName.TabIndex = 16;
            // 
            // tbBillTime
            // 
            this.tbBillTime.Location = new System.Drawing.Point(303, 58);
            this.tbBillTime.Name = "tbBillTime";
            this.tbBillTime.ReadOnly = true;
            this.tbBillTime.Size = new System.Drawing.Size(125, 25);
            this.tbBillTime.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "打印开台单";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(645, 136);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(87, 23);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "开台";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(485, 58);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(247, 25);
            this.tbRemark.TabIndex = 11;
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.Location = new System.Drawing.Point(642, 24);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.Size = new System.Drawing.Size(90, 25);
            this.tbClientNumber.TabIndex = 9;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(485, 25);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 25);
            this.tbClientName.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "备注:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "开单时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "人数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "客人:";
            // 
            // tbBillNO
            // 
            this.tbBillNO.Location = new System.Drawing.Point(303, 25);
            this.tbBillNO.Name = "tbBillNO";
            this.tbBillNO.Size = new System.Drawing.Size(125, 25);
            this.tbBillNO.TabIndex = 3;
            // 
            // tbTableNO
            // 
            this.tbTableNO.Location = new System.Drawing.Point(85, 22);
            this.tbTableNO.Name = "tbTableNO";
            this.tbTableNO.Size = new System.Drawing.Size(122, 25);
            this.tbTableNO.TabIndex = 2;
            this.tbTableNO.Leave += new System.EventHandler(this.tbTableNO_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "手工单号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "台号:";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 165);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.Size = new System.Drawing.Size(787, 174);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 339);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开台";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbBillNO;
        private System.Windows.Forms.TextBox tbTableNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox tbBillTime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.TextBox tbVip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.Timer timer1;
    }
}