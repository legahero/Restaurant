namespace Restaurant
{
    partial class FormRepayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepayment));
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(165, 124);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(190, 25);
            this.tbRemark.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "备注:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(257, 171);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancel.TabIndex = 43;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(121, 171);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(98, 32);
            this.bt_OK.TabIndex = 42;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(165, 93);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(120, 25);
            this.tbValue.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "金额:";
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(165, 50);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.ReadOnly = true;
            this.tbClientName.Size = new System.Drawing.Size(190, 25);
            this.tbClientName.TabIndex = 39;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(165, 18);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.ReadOnly = true;
            this.tbCompany.Size = new System.Drawing.Size(190, 25);
            this.tbCompany.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "客户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "公司：";
            // 
            // FormRepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 227);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRepayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "挂账还款";
            this.Load += new System.EventHandler(this.FormRepayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}