namespace Restaurant
{
    partial class FormDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeposit));
            this.tbAssociator = new System.Windows.Forms.TextBox();
            this.tbCardID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAssociator
            // 
            this.tbAssociator.Location = new System.Drawing.Point(123, 45);
            this.tbAssociator.Name = "tbAssociator";
            this.tbAssociator.ReadOnly = true;
            this.tbAssociator.Size = new System.Drawing.Size(190, 25);
            this.tbAssociator.TabIndex = 13;
            // 
            // tbCardID
            // 
            this.tbCardID.Location = new System.Drawing.Point(123, 13);
            this.tbCardID.Name = "tbCardID";
            this.tbCardID.ReadOnly = true;
            this.tbCardID.Size = new System.Drawing.Size(190, 25);
            this.tbCardID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "会员名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "卡号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "金额:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(123, 88);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(120, 25);
            this.tbValue.TabIndex = 15;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(215, 166);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancel.TabIndex = 33;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(79, 166);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(98, 32);
            this.bt_OK.TabIndex = 32;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 34;
            this.label3.Text = "备注:";
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(123, 119);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(190, 25);
            this.tbRemark.TabIndex = 35;
            // 
            // FormDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 210);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAssociator);
            this.Controls.Add(this.tbCardID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充值";
            this.Load += new System.EventHandler(this.FormDeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAssociator;
        private System.Windows.Forms.TextBox tbCardID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRemark;
    }
}