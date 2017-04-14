namespace Restaurant
{
    partial class FormGoodsItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsItem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGoodsName = new System.Windows.Forms.TextBox();
            this.tbGoodsClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsSubClassify = new System.Windows.Forms.TextBox();
            this.tbGoodsNO = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.cbGoodsClassifyName = new System.Windows.Forms.ComboBox();
            this.cbGoodsSubClassifyName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.cbIsCurrentPrice = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPinYin = new System.Windows.Forms.TextBox();
            this.tbGoodsCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbIntegral = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbDeduct = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "编码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "小类:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "单位:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "单价:";
            // 
            // tbGoodsName
            // 
            this.tbGoodsName.Location = new System.Drawing.Point(130, 10);
            this.tbGoodsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsName.Name = "tbGoodsName";
            this.tbGoodsName.Size = new System.Drawing.Size(129, 21);
            this.tbGoodsName.TabIndex = 5;
            this.tbGoodsName.TextChanged += new System.EventHandler(this.tbGoodsName_TextChanged);
            // 
            // tbGoodsClassify
            // 
            this.tbGoodsClassify.Location = new System.Drawing.Point(130, 58);
            this.tbGoodsClassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsClassify.Name = "tbGoodsClassify";
            this.tbGoodsClassify.ReadOnly = true;
            this.tbGoodsClassify.Size = new System.Drawing.Size(26, 21);
            this.tbGoodsClassify.TabIndex = 6;
            // 
            // tbGoodsSubClassify
            // 
            this.tbGoodsSubClassify.Location = new System.Drawing.Point(160, 58);
            this.tbGoodsSubClassify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsSubClassify.Name = "tbGoodsSubClassify";
            this.tbGoodsSubClassify.ReadOnly = true;
            this.tbGoodsSubClassify.Size = new System.Drawing.Size(27, 21);
            this.tbGoodsSubClassify.TabIndex = 7;
            // 
            // tbGoodsNO
            // 
            this.tbGoodsNO.Location = new System.Drawing.Point(190, 58);
            this.tbGoodsNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsNO.Name = "tbGoodsNO";
            this.tbGoodsNO.Size = new System.Drawing.Size(205, 21);
            this.tbGoodsNO.TabIndex = 8;
            this.tbGoodsNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGoodsNO_KeyPress);
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(238, 82);
            this.tbUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(92, 21);
            this.tbUnitPrice.TabIndex = 9;
            this.tbUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUnitPrice_KeyPress);
            // 
            // cbGoodsClassifyName
            // 
            this.cbGoodsClassifyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGoodsClassifyName.FormattingEnabled = true;
            this.cbGoodsClassifyName.Location = new System.Drawing.Point(130, 35);
            this.cbGoodsClassifyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGoodsClassifyName.Name = "cbGoodsClassifyName";
            this.cbGoodsClassifyName.Size = new System.Drawing.Size(129, 20);
            this.cbGoodsClassifyName.TabIndex = 10;
            this.cbGoodsClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsClassifyName_SelectedIndexChanged);
            // 
            // cbGoodsSubClassifyName
            // 
            this.cbGoodsSubClassifyName.FormattingEnabled = true;
            this.cbGoodsSubClassifyName.Location = new System.Drawing.Point(323, 35);
            this.cbGoodsSubClassifyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGoodsSubClassifyName.Name = "cbGoodsSubClassifyName";
            this.cbGoodsSubClassifyName.Size = new System.Drawing.Size(72, 20);
            this.cbGoodsSubClassifyName.TabIndex = 11;
            this.cbGoodsSubClassifyName.SelectedIndexChanged += new System.EventHandler(this.cbGoodsSubClassifyName_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "大类:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "拼音简码:";
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
            "箱"});
            this.cbUnit.Location = new System.Drawing.Point(130, 83);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(66, 20);
            this.cbUnit.TabIndex = 14;
            // 
            // cbIsCurrentPrice
            // 
            this.cbIsCurrentPrice.AutoSize = true;
            this.cbIsCurrentPrice.Location = new System.Drawing.Point(350, 82);
            this.cbIsCurrentPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIsCurrentPrice.Name = "cbIsCurrentPrice";
            this.cbIsCurrentPrice.Size = new System.Drawing.Size(48, 16);
            this.cbIsCurrentPrice.TabIndex = 15;
            this.cbIsCurrentPrice.Text = "时价";
            this.cbIsCurrentPrice.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "商品条码:";
            // 
            // tbPinYin
            // 
            this.tbPinYin.Location = new System.Drawing.Point(323, 10);
            this.tbPinYin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPinYin.Name = "tbPinYin";
            this.tbPinYin.Size = new System.Drawing.Size(72, 21);
            this.tbPinYin.TabIndex = 17;
            // 
            // tbGoodsCode
            // 
            this.tbGoodsCode.Location = new System.Drawing.Point(130, 106);
            this.tbGoodsCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGoodsCode.Name = "tbGoodsCode";
            this.tbGoodsCode.Size = new System.Drawing.Size(266, 21);
            this.tbGoodsCode.TabIndex = 18;
            this.tbGoodsCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGoodsCode_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "成本:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "积分:";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(130, 134);
            this.tbCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(129, 21);
            this.tbCost.TabIndex = 21;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // tbIntegral
            // 
            this.tbIntegral.Location = new System.Drawing.Point(320, 137);
            this.tbIntegral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIntegral.Name = "tbIntegral";
            this.tbIntegral.Size = new System.Drawing.Size(76, 21);
            this.tbIntegral.TabIndex = 22;
            this.tbIntegral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntegral_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "提成:";
            // 
            // tbDeduct
            // 
            this.tbDeduct.Location = new System.Drawing.Point(130, 162);
            this.tbDeduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDeduct.Name = "tbDeduct";
            this.tbDeduct.Size = new System.Drawing.Size(129, 21);
            this.tbDeduct.TabIndex = 24;
            this.tbDeduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeduct_KeyPress);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cancel.Image")));
            this.bt_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Cancel.Location = new System.Drawing.Point(255, 205);
            this.bt_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(74, 26);
            this.bt_Cancel.TabIndex = 26;
            this.bt_Cancel.Text = "取消";
            // 
            // bt_OK
            // 
            this.bt_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OK.Image")));
            this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_OK.Location = new System.Drawing.Point(153, 205);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(74, 26);
            this.bt_OK.TabIndex = 25;
            this.bt_OK.Text = "确定";
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // FormGoodsItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 240);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tbDeduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbIntegral);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbGoodsCode);
            this.Controls.Add(this.tbPinYin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbIsCurrentPrice);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGoodsSubClassifyName);
            this.Controls.Add(this.cbGoodsClassifyName);
            this.Controls.Add(this.tbUnitPrice);
            this.Controls.Add(this.tbGoodsNO);
            this.Controls.Add(this.tbGoodsSubClassify);
            this.Controls.Add(this.tbGoodsClassify);
            this.Controls.Add(this.tbGoodsName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormGoodsItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒菜信息";
            this.Load += new System.EventHandler(this.FormGoodsItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGoodsName;
        private System.Windows.Forms.TextBox tbGoodsClassify;
        private System.Windows.Forms.TextBox tbGoodsSubClassify;
        private System.Windows.Forms.TextBox tbGoodsNO;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.ComboBox cbGoodsClassifyName;
        private System.Windows.Forms.ComboBox cbGoodsSubClassifyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.CheckBox cbIsCurrentPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPinYin;
        private System.Windows.Forms.TextBox tbGoodsCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbIntegral;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbDeduct;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_OK;
    }
}