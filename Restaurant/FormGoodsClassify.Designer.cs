namespace Restaurant
{
    partial class FormGoodsClassify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsClassify));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGoodsClassify = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbGoodsClassifyName = new System.Windows.Forms.TextBox();
            this.tbGoodsClassify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.toolStripClassify = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelClassify = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGoodsSubClassify = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbGoodsSubClassifyName = new System.Windows.Forms.TextBox();
            this.tbGoodsSubClassify = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSubAdd = new System.Windows.Forms.Button();
            this.toolStripSubClassify = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelSubClassify = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsClassify)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStripClassify.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSubClassify)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStripSubClassify.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGoodsClassify);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.toolStripClassify);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大类：";
            // 
            // dgvGoodsClassify
            // 
            this.dgvGoodsClassify.AllowUserToAddRows = false;
            this.dgvGoodsClassify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoodsClassify.Location = new System.Drawing.Point(3, 46);
            this.dgvGoodsClassify.Name = "dgvGoodsClassify";
            this.dgvGoodsClassify.RowTemplate.Height = 27;
            this.dgvGoodsClassify.Size = new System.Drawing.Size(331, 231);
            this.dgvGoodsClassify.TabIndex = 0;
            this.dgvGoodsClassify.SelectionChanged += new System.EventHandler(this.dgvGoodsClassify_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbGoodsClassifyName);
            this.groupBox3.Controls.Add(this.tbGoodsClassify);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加大类:";
            // 
            // tbGoodsClassifyName
            // 
            this.tbGoodsClassifyName.Location = new System.Drawing.Point(87, 49);
            this.tbGoodsClassifyName.Name = "tbGoodsClassifyName";
            this.tbGoodsClassifyName.Size = new System.Drawing.Size(163, 25);
            this.tbGoodsClassifyName.TabIndex = 5;
            // 
            // tbGoodsClassify
            // 
            this.tbGoodsClassify.Location = new System.Drawing.Point(87, 18);
            this.tbGoodsClassify.Name = "tbGoodsClassify";
            this.tbGoodsClassify.Size = new System.Drawing.Size(100, 25);
            this.tbGoodsClassify.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "大类名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "大类码:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(256, 52);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // toolStripClassify
            // 
            this.toolStripClassify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDelClassify});
            this.toolStripClassify.Location = new System.Drawing.Point(3, 21);
            this.toolStripClassify.Name = "toolStripClassify";
            this.toolStripClassify.Size = new System.Drawing.Size(331, 25);
            this.toolStripClassify.TabIndex = 5;
            this.toolStripClassify.Text = "toolStrip2";
            // 
            // toolStripButtonDelClassify
            // 
            this.toolStripButtonDelClassify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelClassify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelClassify.Image")));
            this.toolStripButtonDelClassify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelClassify.Name = "toolStripButtonDelClassify";
            this.toolStripButtonDelClassify.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelClassify.Text = "删除";
            this.toolStripButtonDelClassify.Click += new System.EventHandler(this.toolStripButtonDelClassify_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGoodsSubClassify);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.toolStripSubClassify);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(347, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "小类:";
            // 
            // dgvGoodsSubClassify
            // 
            this.dgvGoodsSubClassify.AllowUserToAddRows = false;
            this.dgvGoodsSubClassify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoodsSubClassify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoodsSubClassify.Location = new System.Drawing.Point(3, 46);
            this.dgvGoodsSubClassify.Name = "dgvGoodsSubClassify";
            this.dgvGoodsSubClassify.RowTemplate.Height = 27;
            this.dgvGoodsSubClassify.Size = new System.Drawing.Size(520, 231);
            this.dgvGoodsSubClassify.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbGoodsSubClassifyName);
            this.groupBox4.Controls.Add(this.tbGoodsSubClassify);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btSubAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(520, 89);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加小类:";
            // 
            // tbGoodsSubClassifyName
            // 
            this.tbGoodsSubClassifyName.Location = new System.Drawing.Point(77, 52);
            this.tbGoodsSubClassifyName.Name = "tbGoodsSubClassifyName";
            this.tbGoodsSubClassifyName.Size = new System.Drawing.Size(163, 25);
            this.tbGoodsSubClassifyName.TabIndex = 9;
            // 
            // tbGoodsSubClassify
            // 
            this.tbGoodsSubClassify.Location = new System.Drawing.Point(77, 22);
            this.tbGoodsSubClassify.Name = "tbGoodsSubClassify";
            this.tbGoodsSubClassify.Size = new System.Drawing.Size(100, 25);
            this.tbGoodsSubClassify.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "小类名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "小类码:";
            // 
            // btSubAdd
            // 
            this.btSubAdd.Location = new System.Drawing.Point(246, 51);
            this.btSubAdd.Name = "btSubAdd";
            this.btSubAdd.Size = new System.Drawing.Size(75, 23);
            this.btSubAdd.TabIndex = 1;
            this.btSubAdd.Text = "添加";
            this.btSubAdd.UseVisualStyleBackColor = true;
            this.btSubAdd.Click += new System.EventHandler(this.btSubAdd_Click);
            // 
            // toolStripSubClassify
            // 
            this.toolStripSubClassify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDelSubClassify});
            this.toolStripSubClassify.Location = new System.Drawing.Point(3, 21);
            this.toolStripSubClassify.Name = "toolStripSubClassify";
            this.toolStripSubClassify.Size = new System.Drawing.Size(520, 25);
            this.toolStripSubClassify.TabIndex = 5;
            this.toolStripSubClassify.Text = "toolStrip1";
            // 
            // toolStripButtonDelSubClassify
            // 
            this.toolStripButtonDelSubClassify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelSubClassify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelSubClassify.Image")));
            this.toolStripButtonDelSubClassify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelSubClassify.Name = "toolStripButtonDelSubClassify";
            this.toolStripButtonDelSubClassify.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelSubClassify.Text = "删除";
            this.toolStripButtonDelSubClassify.Click += new System.EventHandler(this.toolStripButtonDelSubClassify_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(337, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 369);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // FormGoodsClassify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 369);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGoodsClassify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒菜分类";
            this.Load += new System.EventHandler(this.FormGoodsClassify_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsClassify)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStripClassify.ResumeLayout(false);
            this.toolStripClassify.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSubClassify)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStripSubClassify.ResumeLayout(false);
            this.toolStripSubClassify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGoodsClassify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStrip toolStripClassify;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelClassify;
        private System.Windows.Forms.ToolStrip toolStripSubClassify;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelSubClassify;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dgvGoodsSubClassify;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btSubAdd;
        private System.Windows.Forms.TextBox tbGoodsClassifyName;
        private System.Windows.Forms.TextBox tbGoodsClassify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGoodsSubClassifyName;
        private System.Windows.Forms.TextBox tbGoodsSubClassify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

    }
}