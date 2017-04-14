namespace Restaurant
{
    partial class FormGoodsMaterialItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsMaterialItem));
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPinYin = new System.Windows.Forms.TextBox();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGoodsSubClassifyName = new System.Windows.Forms.ComboBox();
            this.cbGoodsClassifyName = new System.Windows.Forms.ComboBox();
            this.tbGoodsNO = new System.Windows.Forms.TextBox();
            this.tbGoodsSubClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(242, 177);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(74, 26);
            this.bt_Cancel.TabIndex = 53;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(140, 177);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(74, 26);
            this.bt_OK.TabIndex = 52;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(117, 128);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(129, 21);
            this.tbCost.TabIndex = 48;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "成本:";
            // 
            // tbPinYin
            // 
            this.tbPinYin.Location = new System.Drawing.Point(310, 31);
            this.tbPinYin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPinYin.Name = "tbPinYin";
            this.tbPinYin.Size = new System.Drawing.Size(72, 21);
            this.tbPinYin.TabIndex = 44;
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Items.AddRange(new object[] {
            "份",
            "碗",
            "个",
            "瓶",
            "打",
            "杯",
            "个",
            "箱",
            "升",
            "斤",
            "两",
            "克",
            "毫升"});
            this.cbUnit.Location = new System.Drawing.Point(117, 105);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(66, 20);
            this.cbUnit.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "拼音简码:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "大类:";
            // 
            // cbGoodsSubClassifyName
            // 
            this.cbGoodsSubClassifyName.FormattingEnabled = true;
            this.cbGoodsSubClassifyName.Location = new System.Drawing.Point(310, 57);
            this.cbGoodsSubClassifyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGoodsSubClassifyName.Name = "cbGoodsSubClassifyName";
            this.cbGoodsSubClassifyName.Size = new System.Drawing.Size(72, 20);
            this.cbGoodsSubClassifyName.TabIndex = 38;
            this.cbGoodsSubClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsSubClassifyName_SelectedIndexChanged);
            // 
            // cbGoodsClassifyName
            // 
            this.cbGoodsClassifyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodsClassifyName.FormattingEnabled = true;
            this.cbGoodsClassifyName.Location = new System.Drawing.Point(117, 57);
            this.cbGoodsClassifyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGoodsClassifyName.Name = "cbGoodsClassifyName";
            this.cbGoodsClassifyName.Size = new System.Drawing.Size(129, 20);
            this.cbGoodsClassifyName.TabIndex = 37;
            this.cbGoodsClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsClassifyName_SelectedIndexChanged);
            // 
            // tbGoodsNO
            // 
            this.tbGoodsNO.Location = new System.Drawing.Point(178, 80);
            this.tbGoodsNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsNO.Name = "tbGoodsNO";
            this.tbGoodsNO.Size = new System.Drawing.Size(205, 21);
            this.tbGoodsNO.TabIndex = 35;
            this.tbGoodsNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGoodsNO_KeyPress);
            // 
            // tbGoodsSubClassify
            // 
            this.tbGoodsSubClassify.Location = new System.Drawing.Point(147, 80);
            this.tbGoodsSubClassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsSubClassify.Name = "tbGoodsSubClassify";
            this.tbGoodsSubClassify.ReadOnly = true;
            this.tbGoodsSubClassify.Size = new System.Drawing.Size(27, 21);
            this.tbGoodsSubClassify.TabIndex = 34;
            // 
            // tbGoodsClassify
            // 
            this.tbGoodsClassify.Location = new System.Drawing.Point(117, 80);
            this.tbGoodsClassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsClassify.Name = "tbGoodsClassify";
            this.tbGoodsClassify.ReadOnly = true;
            this.tbGoodsClassify.Size = new System.Drawing.Size(26, 21);
            this.tbGoodsClassify.TabIndex = 33;
            // 
            // tbGoodsName
            // 
            this.tbGoodsName.Location = new System.Drawing.Point(117, 32);
            this.tbGoodsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsName.Name = "tbGoodsName";
            this.tbGoodsName.Size = new System.Drawing.Size(129, 21);
            this.tbGoodsName.TabIndex = 32;
            this.tbGoodsName.TextChanged += new System.EventHandler(this.tbGoodsName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "单位:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "小类:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "编码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "名称:";
            // 
            // FormGoodsMaterialItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 215);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPinYin);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGoodsSubClassifyName);
            this.Controls.Add(this.cbGoodsClassifyName);
            this.Controls.Add(this.tbGoodsNO);
            this.Controls.Add(this.tbGoodsSubClassify);
            this.Controls.Add(this.tbGoodsClassify);
            this.Controls.Add(this.tbGoodsName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGoodsMaterialItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原料";
            this.Load += new System.EventHandler(this.FormGoodsMaterialItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPinYin;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGoodsSubClassifyName;
        private System.Windows.Forms.ComboBox cbGoodsClassifyName;
        private System.Windows.Forms.TextBox tbGoodsNO;
        private System.Windows.Forms.TextBox tbGoodsSubClassify;
        private System.Windows.Forms.TextBox tbGoodsClassify;
        private System.Windows.Forms.TextBox tbGoodsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}