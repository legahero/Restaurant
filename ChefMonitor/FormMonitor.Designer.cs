namespace ChefMonitor
{
    partial class FormMonitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonitor));
            this.tabControlList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemWinStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDeliver = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtoncooked = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonServing = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPageInfo = new System.Windows.Forms.ToolStripLabel();
            this.btDown = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tmDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.btShowAll = new System.Windows.Forms.Button();
            this.toolStripButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStyle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlList.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlList
            // 
            this.tabControlList.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlList.Controls.Add(this.tabPage1);
            this.tabControlList.Controls.Add(this.tabPage2);
            this.tabControlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlList.Location = new System.Drawing.Point(0, 288);
            this.tabControlList.Name = "tabControlList";
            this.tabControlList.SelectedIndex = 0;
            this.tabControlList.Size = new System.Drawing.Size(796, 28);
            this.tabControlList.TabIndex = 2;
            this.tabControlList.SelectedIndexChanged += new System.EventHandler(this.tabControlList_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripButtonDeliver,
            this.toolStripButtoncooked,
            this.toolStripButtonServing,
            this.toolStripButtonReturn,
            this.toolStripSeparator3,
            this.toolStripButtonStyle,
            this.toolStripSeparator4,
            this.toolStripButtonAbout,
            this.toolStripButtonExit,
            this.toolStripSeparator1,
            this.toolStripLabelPageInfo});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(796, 38);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemWinStyle,
            this.ToolStripMenuItemConnect});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(80, 35);
            this.toolStripDropDownButton1.Text = "系统设置";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemWinStyle
            // 
            this.ToolStripMenuItemWinStyle.Name = "ToolStripMenuItemWinStyle";
            this.ToolStripMenuItemWinStyle.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemWinStyle.Text = "界面风格";
            this.ToolStripMenuItemWinStyle.Click += new System.EventHandler(this.ToolStripMenuItemWinStyle_Click);
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(134, 22);
            this.ToolStripMenuItemConnect.Text = "连接设置";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonDeliver
            // 
            this.toolStripButtonDeliver.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDeliver.Image")));
            this.toolStripButtonDeliver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDeliver.Name = "toolStripButtonDeliver";
            this.toolStripButtonDeliver.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtonDeliver.Text = "送厨";
            this.toolStripButtonDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonDeliver.Click += new System.EventHandler(this.toolStripButtonDeliver_Click);
            // 
            // toolStripButtoncooked
            // 
            this.toolStripButtoncooked.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtoncooked.Image")));
            this.toolStripButtoncooked.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoncooked.Name = "toolStripButtoncooked";
            this.toolStripButtoncooked.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtoncooked.Text = "出厨";
            this.toolStripButtoncooked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtoncooked.Click += new System.EventHandler(this.toolStripButtoncooked_Click);
            // 
            // toolStripButtonServing
            // 
            this.toolStripButtonServing.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonServing.Image")));
            this.toolStripButtonServing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonServing.Name = "toolStripButtonServing";
            this.toolStripButtonServing.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtonServing.Text = "上菜";
            this.toolStripButtonServing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonServing.Click += new System.EventHandler(this.toolStripButtonServing_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtonAbout.Text = "关于";
            this.toolStripButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtonExit.Text = "退出";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripLabelPageInfo
            // 
            this.toolStripLabelPageInfo.Name = "toolStripLabelPageInfo";
            this.toolStripLabelPageInfo.Size = new System.Drawing.Size(75, 35);
            this.toolStripLabelPageInfo.Text = "共页 第页";
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(555, 316);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(84, 23);
            this.btDown.TabIndex = 7;
            this.btDown.Text = "PageDown";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(555, 293);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(84, 23);
            this.btUp.TabIndex = 6;
            this.btUp.Text = "PageUp";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 38);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 27;
            this.dgvMain.Size = new System.Drawing.Size(796, 250);
            this.dgvMain.TabIndex = 8;
            // 
            // tmDataRefresh
            // 
            this.tmDataRefresh.Interval = 30000;
            this.tmDataRefresh.Tick += new System.EventHandler(this.tmDataRefresh_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelMemory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(796, 24);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "勇影软件工作室（Legahero@hotmail.com）";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(302, 19);
            this.toolStripStatusLabel1.Text = "勇影工作室（Legahero@hotmail.com）出品";
            // 
            // toolStripStatusLabelMemory
            // 
            this.toolStripStatusLabelMemory.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelMemory.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.toolStripStatusLabelMemory.Name = "toolStripStatusLabelMemory";
            this.toolStripStatusLabelMemory.Size = new System.Drawing.Size(86, 19);
            this.toolStripStatusLabelMemory.Text = "使用内存：";
            // 
            // btShowAll
            // 
            this.btShowAll.Location = new System.Drawing.Point(477, 292);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(75, 23);
            this.btShowAll.TabIndex = 10;
            this.btShowAll.Text = "显示所有";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // toolStripButtonReturn
            // 
            this.toolStripButtonReturn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReturn.Image")));
            this.toolStripButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReturn.Name = "toolStripButtonReturn";
            this.toolStripButtonReturn.Size = new System.Drawing.Size(41, 35);
            this.toolStripButtonReturn.Text = "回退";
            this.toolStripButtonReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonReturn.Click += new System.EventHandler(this.toolStripButtonReturn_Click);
            // 
            // toolStripButtonStyle
            // 
            this.toolStripButtonStyle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStyle.Image")));
            this.toolStripButtonStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStyle.Name = "toolStripButtonStyle";
            this.toolStripButtonStyle.Size = new System.Drawing.Size(56, 35);
            this.toolStripButtonStyle.Text = "列设置";
            this.toolStripButtonStyle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonStyle.Click += new System.EventHandler(this.toolStripButtonStyle_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 340);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.tabControlList);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "厨房监控";
            this.Load += new System.EventHandler(this.FormMonitor_Load);
            this.SizeChanged += new System.EventHandler(this.FormMonitor_SizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMonitor_FormClosed);
            this.tabControlList.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Timer tmDataRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMemory;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWinStyle;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPageInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtoncooked;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonServing;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeliver;
        private System.Windows.Forms.ToolStripButton toolStripButtonReturn;
        private System.Windows.Forms.ToolStripButton toolStripButtonStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

