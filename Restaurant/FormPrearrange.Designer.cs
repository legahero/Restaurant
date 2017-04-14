namespace Restaurant
{
    partial class FormPrearrange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrearrange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbTableNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEmployeeNO = new System.Windows.Forms.ComboBox();
            this.dtpOrderTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMod = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonlankout = new System.Windows.Forms.ToolStripButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "客人:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "台号:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "预定时间:";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(163, 14);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(120, 25);
            this.tbClientName.TabIndex = 6;
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.Location = new System.Drawing.Point(392, 11);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.Size = new System.Drawing.Size(100, 25);
            this.tbClientNumber.TabIndex = 7;
            this.tbClientNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbClientNumber_KeyPress);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(163, 57);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(120, 25);
            this.tbPhone.TabIndex = 8;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(392, 48);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(210, 25);
            this.tbRemark.TabIndex = 9;
            // 
            // tbTableNO
            // 
            this.tbTableNO.Location = new System.Drawing.Point(163, 92);
            this.tbTableNO.Name = "tbTableNO";
            this.tbTableNO.Size = new System.Drawing.Size(120, 25);
            this.tbTableNO.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "责任员工:";
            // 
            // cbEmployeeNO
            // 
            this.cbEmployeeNO.FormattingEnabled = true;
            this.cbEmployeeNO.Location = new System.Drawing.Point(163, 129);
            this.cbEmployeeNO.Name = "cbEmployeeNO";
            this.cbEmployeeNO.Size = new System.Drawing.Size(121, 23);
            this.cbEmployeeNO.TabIndex = 12;
            // 
            // dtpOrderTime
            // 
            this.dtpOrderTime.Location = new System.Drawing.Point(392, 92);
            this.dtpOrderTime.Name = "dtpOrderTime";
            this.dtpOrderTime.Size = new System.Drawing.Size(210, 25);
            this.dtpOrderTime.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.dtpOrderTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbEmployeeNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTableNO);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRemark);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbClientNumber);
            this.groupBox1.Controls.Add(this.tbClientName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 159);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预定信息:";
            // 
            // btMod
            // 
            this.btMod.Location = new System.Drawing.Point(341, 6);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(75, 23);
            this.btMod.TabIndex = 15;
            this.btMod.Text = "修改(&M)";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(233, 6);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "增加(&A)";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDel,
            this.toolStripButtonlankout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "作废";
            // 
            // toolStripButtonDel
            // 
            this.toolStripButtonDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDel.Image")));
            this.toolStripButtonDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDel.Name = "toolStripButtonDel";
            this.toolStripButtonDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDel.Text = "删除";
            this.toolStripButtonDel.Click += new System.EventHandler(this.toolStripButtonDel_Click);
            // 
            // toolStripButtonlankout
            // 
            this.toolStripButtonlankout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonlankout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonlankout.Image")));
            this.toolStripButtonlankout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonlankout.Name = "toolStripButtonlankout";
            this.toolStripButtonlankout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonlankout.Text = "作废";
            this.toolStripButtonlankout.Click += new System.EventHandler(this.toolStripButtonlankout_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 25);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.Size = new System.Drawing.Size(759, 206);
            this.dgvMain.TabIndex = 16;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btMod);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 33);
            this.panel1.TabIndex = 17;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(449, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 16;
            this.btSave.Text = "保存(&S)";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(181, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "显示所有";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormPrearrange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 423);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrearrange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预定管理";
            this.Load += new System.EventHandler(this.FormPrearrange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbTableNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEmployeeNO;
        private System.Windows.Forms.DateTimePicker dtpOrderTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMod;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonlankout;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}