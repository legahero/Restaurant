namespace Restaurant
{
    partial class FormOnCreditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOnCreditItem));
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.tbOnCreditLimit = new System.Windows.Forms.TextBox();
            this.tbOnCreditSum = new System.Windows.Forms.TextBox();
            this.tbMobilePhone = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(287, 198);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancel.TabIndex = 64;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(151, 198);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(98, 32);
            this.bt_OK.TabIndex = 63;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(93, 145);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(440, 25);
            this.tbRemark.TabIndex = 60;
            // 
            // tbOnCreditLimit
            // 
            this.tbOnCreditLimit.Location = new System.Drawing.Point(375, 109);
            this.tbOnCreditLimit.Name = "tbOnCreditLimit";
            this.tbOnCreditLimit.Size = new System.Drawing.Size(158, 25);
            this.tbOnCreditLimit.TabIndex = 59;
            // 
            // tbOnCreditSum
            // 
            this.tbOnCreditSum.Location = new System.Drawing.Point(93, 112);
            this.tbOnCreditSum.Name = "tbOnCreditSum";
            this.tbOnCreditSum.ReadOnly = true;
            this.tbOnCreditSum.Size = new System.Drawing.Size(174, 25);
            this.tbOnCreditSum.TabIndex = 58;
            this.tbOnCreditSum.TextChanged += new System.EventHandler(this.tbOnCreditLimit_TextChanged);
            // 
            // tbMobilePhone
            // 
            this.tbMobilePhone.Location = new System.Drawing.Point(375, 80);
            this.tbMobilePhone.Name = "tbMobilePhone";
            this.tbMobilePhone.Size = new System.Drawing.Size(158, 25);
            this.tbMobilePhone.TabIndex = 57;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(93, 81);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(174, 25);
            this.tbPhone.TabIndex = 56;
            // 
            // tbPostCode
            // 
            this.tbPostCode.Location = new System.Drawing.Point(468, 49);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(65, 25);
            this.tbPostCode.TabIndex = 55;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(93, 49);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(322, 25);
            this.tbAddress.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 52;
            this.label14.Text = "备注：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "挂帐上限：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "已挂金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "手机：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "电话：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "邮编：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "地址：";
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(265, 18);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(268, 25);
            this.tbCompany.TabIndex = 44;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(93, 17);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(123, 25);
            this.tbClientName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "公司：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "客户：";
            // 
            // FormOnCreditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 252);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.tbOnCreditLimit);
            this.Controls.Add(this.tbOnCreditSum);
            this.Controls.Add(this.tbMobilePhone);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOnCreditItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "挂帐客户信息";
            this.Load += new System.EventHandler(this.FormOnCreditItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbOnCreditLimit;
        private System.Windows.Forms.TextBox tbOnCreditSum;
        private System.Windows.Forms.TextBox tbMobilePhone;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}