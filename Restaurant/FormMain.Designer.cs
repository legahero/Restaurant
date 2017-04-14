namespace Restaurant
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMemory = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemWinStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRunSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTableSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGoodsSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUnused = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrearrange = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartBill = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOrderdishes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnite = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTransfer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReckoning = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearTable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemBillQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBillListQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonClientMgr = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOnCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonInner = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemEmployeeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGroupInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRolesInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoginMgr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItemRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelPageInfo = new System.Windows.Forms.ToolStripLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btDown = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.yyDiningTableView1 = new YyTableCtrl.YyDiningTableView();
            this.tmDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControlList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelMemory});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(233, 17);
            this.toolStripStatusLabel1.Text = "勇影工作室（Legahero@hotmail.com）出品";
            // 
            // toolStripStatusLabelMemory
            // 
            this.toolStripStatusLabelMemory.Name = "toolStripStatusLabelMemory";
            this.toolStripStatusLabelMemory.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabelMemory.Text = "使用内存：";
            // 
            // tabControlList
            // 
            this.tabControlList.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlList.Controls.Add(this.tabPage1);
            this.tabControlList.Controls.Add(this.tabPage2);
            this.tabControlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlList.Location = new System.Drawing.Point(0, 337);
            this.tabControlList.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlList.Name = "tabControlList";
            this.tabControlList.SelectedIndex = 0;
            this.tabControlList.Size = new System.Drawing.Size(909, 22);
            this.tabControlList.TabIndex = 1;
            this.tabControlList.SelectedIndexChanged += new System.EventHandler(this.tabControlList_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(901, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(901, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator4,
            this.toolStripButtonTableSet,
            this.toolStripButtonGoodsSet,
            this.toolStripSeparator2,
            this.toolStripButtonUnused,
            this.toolStripButtonUse,
            this.toolStripButtonPrearrange,
            this.toolStripButtonStartBill,
            this.toolStripButtonOrderdishes,
            this.toolStripButtonUnite,
            this.toolStripButtonTransfer,
            this.toolStripButtonReckoning,
            this.toolStripButtonClearTable,
            this.toolStripSeparator3,
            this.toolStripDropDownButtonReport,
            this.toolStripDropDownButtonClientMgr,
            this.toolStripDropDownButtonInner,
            this.toolStripSeparator1,
            this.toolStripDropDownButtonHelp,
            this.toolStripButtonExit,
            this.toolStripSeparator5,
            this.toolStripLabelPageInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemWinStyle,
            this.ToolStripMenuItemRunSetting,
            this.ToolStripMenuItemConnect});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 32);
            this.toolStripDropDownButton1.Text = "系统设置";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemWinStyle
            // 
            this.ToolStripMenuItemWinStyle.Name = "ToolStripMenuItemWinStyle";
            this.ToolStripMenuItemWinStyle.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemWinStyle.Text = "界面风格";
            this.ToolStripMenuItemWinStyle.Click += new System.EventHandler(this.ToolStripMenuItemWinStyle_Click);
            // 
            // ToolStripMenuItemRunSetting
            // 
            this.ToolStripMenuItemRunSetting.Name = "ToolStripMenuItemRunSetting";
            this.ToolStripMenuItemRunSetting.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemRunSetting.Text = "运行设置";
            this.ToolStripMenuItemRunSetting.Click += new System.EventHandler(this.ToolStripMenuItemRunSetting_Click);
            // 
            // ToolStripMenuItemConnect
            // 
            this.ToolStripMenuItemConnect.Name = "ToolStripMenuItemConnect";
            this.ToolStripMenuItemConnect.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemConnect.Text = "连接设置";
            this.ToolStripMenuItemConnect.Click += new System.EventHandler(this.ToolStripMenuItemConnect_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButtonTableSet
            // 
            this.toolStripButtonTableSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTableSet.Image")));
            this.toolStripButtonTableSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTableSet.Name = "toolStripButtonTableSet";
            this.toolStripButtonTableSet.Size = new System.Drawing.Size(57, 32);
            this.toolStripButtonTableSet.Text = "房台设置";
            this.toolStripButtonTableSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTableSet.Click += new System.EventHandler(this.toolStripButtonTableSet_Click);
            // 
            // toolStripButtonGoodsSet
            // 
            this.toolStripButtonGoodsSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGoodsSet.Image")));
            this.toolStripButtonGoodsSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGoodsSet.Name = "toolStripButtonGoodsSet";
            this.toolStripButtonGoodsSet.Size = new System.Drawing.Size(57, 32);
            this.toolStripButtonGoodsSet.Text = "酒菜设置";
            this.toolStripButtonGoodsSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonGoodsSet.Click += new System.EventHandler(this.toolStripButtonGoodsSet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButtonUnused
            // 
            this.toolStripButtonUnused.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnused.Image")));
            this.toolStripButtonUnused.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnused.Name = "toolStripButtonUnused";
            this.toolStripButtonUnused.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonUnused.Text = "停用";
            this.toolStripButtonUnused.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUnused.Click += new System.EventHandler(this.toolStripButtonUnused_Click);
            // 
            // toolStripButtonUse
            // 
            this.toolStripButtonUse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUse.Image")));
            this.toolStripButtonUse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUse.Name = "toolStripButtonUse";
            this.toolStripButtonUse.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonUse.Text = "启用";
            this.toolStripButtonUse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUse.Click += new System.EventHandler(this.toolStripButtonUse_Click);
            // 
            // toolStripButtonPrearrange
            // 
            this.toolStripButtonPrearrange.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrearrange.Image")));
            this.toolStripButtonPrearrange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrearrange.Name = "toolStripButtonPrearrange";
            this.toolStripButtonPrearrange.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonPrearrange.Text = "预定";
            this.toolStripButtonPrearrange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonPrearrange.Click += new System.EventHandler(this.toolStripButtonPrearrange_Click);
            // 
            // toolStripButtonStartBill
            // 
            this.toolStripButtonStartBill.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartBill.Image")));
            this.toolStripButtonStartBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartBill.Name = "toolStripButtonStartBill";
            this.toolStripButtonStartBill.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonStartBill.Text = "开台";
            this.toolStripButtonStartBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonStartBill.Click += new System.EventHandler(this.toolStripButtonStartBill_Click);
            // 
            // toolStripButtonOrderdishes
            // 
            this.toolStripButtonOrderdishes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOrderdishes.Image")));
            this.toolStripButtonOrderdishes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOrderdishes.Name = "toolStripButtonOrderdishes";
            this.toolStripButtonOrderdishes.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonOrderdishes.Text = "点菜";
            this.toolStripButtonOrderdishes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonOrderdishes.Click += new System.EventHandler(this.toolStripButtonOrderdishes_Click);
            // 
            // toolStripButtonUnite
            // 
            this.toolStripButtonUnite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnite.Image")));
            this.toolStripButtonUnite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnite.Name = "toolStripButtonUnite";
            this.toolStripButtonUnite.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonUnite.Text = "并台";
            this.toolStripButtonUnite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonUnite.Click += new System.EventHandler(this.toolStripButtonUnite_Click);
            // 
            // toolStripButtonTransfer
            // 
            this.toolStripButtonTransfer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTransfer.Image")));
            this.toolStripButtonTransfer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTransfer.Name = "toolStripButtonTransfer";
            this.toolStripButtonTransfer.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonTransfer.Text = "换台";
            this.toolStripButtonTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonTransfer.Click += new System.EventHandler(this.toolStripButtonTransfer_Click);
            // 
            // toolStripButtonReckoning
            // 
            this.toolStripButtonReckoning.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReckoning.Image")));
            this.toolStripButtonReckoning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReckoning.Name = "toolStripButtonReckoning";
            this.toolStripButtonReckoning.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonReckoning.Text = "结帐";
            this.toolStripButtonReckoning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonReckoning.Click += new System.EventHandler(this.toolStripButtonReckoning_Click);
            // 
            // toolStripButtonClearTable
            // 
            this.toolStripButtonClearTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearTable.Image")));
            this.toolStripButtonClearTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearTable.Name = "toolStripButtonClearTable";
            this.toolStripButtonClearTable.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonClearTable.Text = "清台";
            this.toolStripButtonClearTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonClearTable.Click += new System.EventHandler(this.toolStripButtonClearTable_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripDropDownButtonReport
            // 
            this.toolStripDropDownButtonReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBillQuery,
            this.ToolStripMenuItemBillListQuery});
            this.toolStripDropDownButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonReport.Image")));
            this.toolStripDropDownButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonReport.Name = "toolStripDropDownButtonReport";
            this.toolStripDropDownButtonReport.Size = new System.Drawing.Size(42, 32);
            this.toolStripDropDownButtonReport.Text = "台帐";
            this.toolStripDropDownButtonReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemBillQuery
            // 
            this.ToolStripMenuItemBillQuery.Name = "ToolStripMenuItemBillQuery";
            this.ToolStripMenuItemBillQuery.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemBillQuery.Text = "帐单查询";
            this.ToolStripMenuItemBillQuery.Click += new System.EventHandler(this.ToolStripMenuItemBillQuery_Click);
            // 
            // ToolStripMenuItemBillListQuery
            // 
            this.ToolStripMenuItemBillListQuery.Name = "ToolStripMenuItemBillListQuery";
            this.ToolStripMenuItemBillListQuery.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemBillListQuery.Text = "明细查询";
            this.ToolStripMenuItemBillListQuery.Click += new System.EventHandler(this.ToolStripMenuItemBillListQuery_Click);
            // 
            // toolStripDropDownButtonClientMgr
            // 
            this.toolStripDropDownButtonClientMgr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.ToolStripMenuItemOnCredit});
            this.toolStripDropDownButtonClientMgr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonClientMgr.Image")));
            this.toolStripDropDownButtonClientMgr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonClientMgr.Name = "toolStripDropDownButtonClientMgr";
            this.toolStripDropDownButtonClientMgr.Size = new System.Drawing.Size(66, 32);
            this.toolStripDropDownButtonClientMgr.Text = "客户管理";
            this.toolStripDropDownButtonClientMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItem.Text = "会员管理";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemOnCredit
            // 
            this.ToolStripMenuItemOnCredit.Name = "ToolStripMenuItemOnCredit";
            this.ToolStripMenuItemOnCredit.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemOnCredit.Text = "挂帐管理";
            this.ToolStripMenuItemOnCredit.Click += new System.EventHandler(this.ToolStripMenuItemOnCredit_Click);
            // 
            // toolStripDropDownButtonInner
            // 
            this.toolStripDropDownButtonInner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemEmployeeInfo,
            this.ToolStripMenuItemGroupInfo,
            this.ToolStripMenuItemRolesInfo,
            this.ToolStripMenuItemLoginMgr});
            this.toolStripDropDownButtonInner.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInner.Image")));
            this.toolStripDropDownButtonInner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonInner.Name = "toolStripDropDownButtonInner";
            this.toolStripDropDownButtonInner.Size = new System.Drawing.Size(66, 32);
            this.toolStripDropDownButtonInner.Text = "内部管理";
            this.toolStripDropDownButtonInner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemEmployeeInfo
            // 
            this.ToolStripMenuItemEmployeeInfo.Name = "ToolStripMenuItemEmployeeInfo";
            this.ToolStripMenuItemEmployeeInfo.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemEmployeeInfo.Text = "职员资料";
            this.ToolStripMenuItemEmployeeInfo.Click += new System.EventHandler(this.ToolStripMenuItemEmployeeInfo_Click);
            // 
            // ToolStripMenuItemGroupInfo
            // 
            this.ToolStripMenuItemGroupInfo.Name = "ToolStripMenuItemGroupInfo";
            this.ToolStripMenuItemGroupInfo.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemGroupInfo.Text = "部门资料";
            this.ToolStripMenuItemGroupInfo.Click += new System.EventHandler(this.ToolStripMenuItemGroupInfo_Click);
            // 
            // ToolStripMenuItemRolesInfo
            // 
            this.ToolStripMenuItemRolesInfo.Name = "ToolStripMenuItemRolesInfo";
            this.ToolStripMenuItemRolesInfo.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemRolesInfo.Text = "职位资料";
            this.ToolStripMenuItemRolesInfo.Click += new System.EventHandler(this.ToolStripMenuItemRolesInfo_Click);
            // 
            // ToolStripMenuItemLoginMgr
            // 
            this.ToolStripMenuItemLoginMgr.Name = "ToolStripMenuItemLoginMgr";
            this.ToolStripMenuItemLoginMgr.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemLoginMgr.Text = "登录管理";
            this.ToolStripMenuItemLoginMgr.Click += new System.EventHandler(this.ToolStripMenuItemLoginMgr_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripDropDownButtonHelp
            // 
            this.toolStripDropDownButtonHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemRegister,
            this.ToolStripMenuItemAbout});
            this.toolStripDropDownButtonHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonHelp.Image")));
            this.toolStripDropDownButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonHelp.Name = "toolStripDropDownButtonHelp";
            this.toolStripDropDownButtonHelp.Size = new System.Drawing.Size(42, 32);
            this.toolStripDropDownButtonHelp.Text = "帮助";
            this.toolStripDropDownButtonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ToolStripMenuItemRegister
            // 
            this.ToolStripMenuItemRegister.Name = "ToolStripMenuItemRegister";
            this.ToolStripMenuItemRegister.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemRegister.Text = "注册信息";
            this.ToolStripMenuItemRegister.Click += new System.EventHandler(this.ToolStripMenuItemRegister_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbout.Image")));
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItemAbout.Text = "关于";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(33, 32);
            this.toolStripButtonExit.Text = "退出";
            this.toolStripButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabelPageInfo
            // 
            this.toolStripLabelPageInfo.Name = "toolStripLabelPageInfo";
            this.toolStripLabelPageInfo.Size = new System.Drawing.Size(59, 32);
            this.toolStripLabelPageInfo.Text = "共页 第页";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btDown);
            this.pnlMain.Controls.Add(this.btUp);
            this.pnlMain.Controls.Add(this.yyDiningTableView1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 35);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(909, 302);
            this.pnlMain.TabIndex = 3;
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(730, 275);
            this.btDown.Margin = new System.Windows.Forms.Padding(2);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(63, 18);
            this.btDown.TabIndex = 5;
            this.btDown.Text = "PageDown";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(730, 256);
            this.btUp.Margin = new System.Windows.Forms.Padding(2);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(63, 18);
            this.btUp.TabIndex = 4;
            this.btUp.Text = "PageUp";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // yyDiningTableView1
            // 
            this.yyDiningTableView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yyDiningTableView1.DataMember = null;
            this.yyDiningTableView1.DataSource = null;
            this.yyDiningTableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yyDiningTableView1.ItemHeight = 80;
            this.yyDiningTableView1.ItemSpacing = 4;
            this.yyDiningTableView1.ItemWidth = 80;
            this.yyDiningTableView1.Location = new System.Drawing.Point(0, 0);
            this.yyDiningTableView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yyDiningTableView1.MultiSelect = true;
            this.yyDiningTableView1.Name = "yyDiningTableView1";
            this.yyDiningTableView1.Size = new System.Drawing.Size(909, 302);
            this.yyDiningTableView1.TabIndex = 0;
            this.yyDiningTableView1.ItemDoubleClick += new System.EventHandler(this.yyDiningTableView1_ItemDoubleClick);
            // 
            // tmDataRefresh
            // 
            this.tmDataRefresh.Interval = 30000;
            this.tmDataRefresh.Tick += new System.EventHandler(this.tmDataRefresh_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 381);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControlList);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "勇影餐饮系统 V1.00";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControlList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTableSet;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnused;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWinStyle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMemory;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Timer tmDataRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPageInfo;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private YyTableCtrl.YyDiningTableView yyDiningTableView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrearrange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonGoodsSet;
        private System.Windows.Forms.ToolStripButton toolStripButtonOrderdishes;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartBill;
        private System.Windows.Forms.ToolStripButton toolStripButtonTransfer;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnite;
        private System.Windows.Forms.ToolStripButton toolStripButtonReckoning;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearTable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonClientMgr;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOnCredit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonUse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInner;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEmployeeInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGroupInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRolesInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoginMgr;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRunSetting;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonReport;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBillQuery;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBillListQuery;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRegister;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;

    }
}

