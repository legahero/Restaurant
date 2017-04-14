namespace Restaurant
{
    partial class FormDiningTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiningTable));
            this.tbTableNO = new System.Windows.Forms.TextBox();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.cbTableClassifyID = new System.Windows.Forms.ComboBox();
            this.cbDiningDeptID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbTableNO
            // 
            this.tbTableNO.Location = new System.Drawing.Point(130, 28);
            this.tbTableNO.Name = "tbTableNO";
            this.tbTableNO.Size = new System.Drawing.Size(100, 25);
            this.tbTableNO.TabIndex = 0;
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(130, 60);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(166, 25);
            this.tbTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "台号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "台名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "类别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "餐饮部:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(216, 171);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(98, 32);
            this.bt_Cancel.TabIndex = 10;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(80, 171);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(98, 32);
            this.bt_OK.TabIndex = 9;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // cbTableClassifyID
            // 
            this.cbTableClassifyID.FormattingEnabled = true;
            this.cbTableClassifyID.Location = new System.Drawing.Point(130, 92);
            this.cbTableClassifyID.Name = "cbTableClassifyID";
            this.cbTableClassifyID.Size = new System.Drawing.Size(166, 23);
            this.cbTableClassifyID.TabIndex = 11;
            // 
            // cbDiningDeptID
            // 
            this.cbDiningDeptID.FormattingEnabled = true;
            this.cbDiningDeptID.Location = new System.Drawing.Point(130, 121);
            this.cbDiningDeptID.Name = "cbDiningDeptID";
            this.cbDiningDeptID.Size = new System.Drawing.Size(166, 23);
            this.cbDiningDeptID.TabIndex = 12;
            // 
            // FormDiningTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 215);
            this.Controls.Add(this.cbDiningDeptID);
            this.Controls.Add(this.cbTableClassifyID);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.tbTableNO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiningTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐台信息";
            this.Load += new System.EventHandler(this.FormDiningTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTableNO;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.ComboBox cbTableClassifyID;
        private System.Windows.Forms.ComboBox cbDiningDeptID;
    }
}