namespace spc
{
    partial class spclf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spclf));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dbxHeatID = new AppSvrHMI.L3DataBox();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.gvAlarm = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDanzhi = new C1.Win.C1Chart.C1Chart();
            this.chartZhifang = new C1.Win.C1Chart.C1Chart();
            this.chartJicha = new C1.Win.C1Chart.C1Chart();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dsLabElement = new AppSvrHMI.L3DataSet();
            this.gobalPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reflashMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录原因ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上一炉次ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一炉次ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳转到指定炉次ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出到EXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClShiJian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClHeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clsteelgradeindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clalarmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClYuanYin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClGaiJin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClLsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAvgX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClSd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClCpk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPpk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUslx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClLslx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClUslr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClLslr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAnaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClAnaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlarm)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDanzhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZhifang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJicha)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLabElement)).BeginInit();
            this.gobalPanel.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dbxHeatID);
            this.splitContainer2.Panel1.Controls.Add(this.gvAlarm);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1176, 547);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 3;
            // 
            // dbxHeatID
            // 
            this.dbxHeatID.DataFormat = null;
            this.dbxHeatID.DataObject = "";
            this.dbxHeatID.DataProperty = "";
            this.dbxHeatID.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxHeatID.L3DataAdapter = this.Adapter;
            this.dbxHeatID.Location = new System.Drawing.Point(534, 62);
            this.dbxHeatID.Name = "dbxHeatID";
            this.dbxHeatID.Size = new System.Drawing.Size(108, 21);
            this.dbxHeatID.TabIndex = 33;
            this.dbxHeatID.Value = null;
            this.dbxHeatID.Visible = false;
            this.dbxHeatID.TextChanged += new System.EventHandler(this.txtHeatID_TextChanged);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // gvAlarm
            // 
            this.gvAlarm.AllowUserToAddRows = false;
            this.gvAlarm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlarm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClIdx,
            this.ClShiJian,
            this.Clteam,
            this.ClHeatID,
            this.Clsteelgradeindex,
            this.Clalarmtype,
            this.ClYuanYin,
            this.ClGaiJin,
            this.ClGuid,
            this.Clx,
            this.Clr,
            this.ClUsl,
            this.ClLsl,
            this.ClAvgX,
            this.ClSd,
            this.ClCp,
            this.ClCpk,
            this.ClPp,
            this.ClPpk,
            this.ClUslx,
            this.ClLslx,
            this.ClMR,
            this.ClUslr,
            this.ClLslr,
            this.ClMse,
            this.ClAnaItem,
            this.ClAnaType});
            this.gvAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAlarm.Location = new System.Drawing.Point(0, 0);
            this.gvAlarm.MultiSelect = false;
            this.gvAlarm.Name = "gvAlarm";
            this.gvAlarm.ReadOnly = true;
            this.gvAlarm.RowTemplate.Height = 23;
            this.gvAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAlarm.Size = new System.Drawing.Size(1176, 201);
            this.gvAlarm.TabIndex = 1;
            this.gvAlarm.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gvAlarm_RowPostPaint);
            this.gvAlarm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlarm_CellContentDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 342);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "控制图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chartJicha);
            this.splitContainer1.Size = new System.Drawing.Size(1162, 311);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartDanzhi);
            this.panel1.Controls.Add(this.chartZhifang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 185);
            this.panel1.TabIndex = 0;
            // 
            // chartDanzhi
            // 
            this.chartDanzhi.BackColor = System.Drawing.Color.Transparent;
            this.chartDanzhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDanzhi.Location = new System.Drawing.Point(270, 0);
            this.chartDanzhi.Margin = new System.Windows.Forms.Padding(0);
            this.chartDanzhi.Name = "chartDanzhi";
            this.chartDanzhi.PropBag = resources.GetString("chartDanzhi.PropBag");
            this.chartDanzhi.Size = new System.Drawing.Size(892, 185);
            this.chartDanzhi.TabIndex = 1;
            // 
            // chartZhifang
            // 
            this.chartZhifang.BackColor = System.Drawing.Color.Transparent;
            this.chartZhifang.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartZhifang.Location = new System.Drawing.Point(0, 0);
            this.chartZhifang.Margin = new System.Windows.Forms.Padding(0);
            this.chartZhifang.Name = "chartZhifang";
            this.chartZhifang.PropBag = resources.GetString("chartZhifang.PropBag");
            this.chartZhifang.Size = new System.Drawing.Size(270, 185);
            this.chartZhifang.TabIndex = 2;
            // 
            // chartJicha
            // 
            this.chartJicha.BackColor = System.Drawing.Color.Transparent;
            this.chartJicha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartJicha.Location = new System.Drawing.Point(0, 0);
            this.chartJicha.Name = "chartJicha";
            this.chartJicha.PropBag = resources.GetString("chartJicha.PropBag");
            this.chartJicha.Size = new System.Drawing.Size(1162, 122);
            this.chartJicha.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2Collapsed = true;
            this.splitContainer3.Size = new System.Drawing.Size(1176, 547);
            this.splitContainer3.SplitterDistance = 949;
            this.splitContainer3.TabIndex = 5;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer4.Size = new System.Drawing.Size(96, 100);
            this.splitContainer4.SplitterDistance = 46;
            this.splitContainer4.TabIndex = 0;
            // 
            // dsLabElement
            // 
            this.dsLabElement.AutoLoad = true;
            this.dsLabElement.AutoSubscribe = true;
            this.dsLabElement.DataSetName = "L3DataSet";
            this.dsLabElement.DeleteMethod = "";
            this.dsLabElement.InsertMethod = "";
            this.dsLabElement.L3DataAdapter = null;
            this.dsLabElement.LoadEvent = "";
            this.dsLabElement.LoadTrigger = null;
            this.dsLabElement.RefreshValve = 1000;
            this.dsLabElement.SourceCommand = null;
            this.dsLabElement.SourceCondition = "1=2";
            this.dsLabElement.SourceMethod = "";
            this.dsLabElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLabElement.SourceURI = "GMESLogic\\QualityMag\\CQA_Lab_Element";
            this.dsLabElement.SubscribeTarget = "";
            this.dsLabElement.UpdateEvent = "";
            this.dsLabElement.UpdateMethod = "";
            this.dsLabElement.UpdateTrigger = null;
            // 
            // gobalPanel
            // 
            this.gobalPanel.Controls.Add(this.splitContainer3);
            this.gobalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gobalPanel.Location = new System.Drawing.Point(0, 0);
            this.gobalPanel.Name = "gobalPanel";
            this.gobalPanel.Size = new System.Drawing.Size(1176, 547);
            this.gobalPanel.TabIndex = 12;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reflashMenuItem,
            this.记录原因ToolStripMenuItem,
            this.上一炉次ToolStripMenuItem,
            this.下一炉次ToolStripMenuItem,
            this.跳转到指定炉次ToolStripMenuItem,
            this.导出到EXCELToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(155, 136);
            // 
            // reflashMenuItem
            // 
            this.reflashMenuItem.Name = "reflashMenuItem";
            this.reflashMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reflashMenuItem.Text = "刷新";
            this.reflashMenuItem.Click += new System.EventHandler(this.记录报警ToolStripMenuItem_Click);
            // 
            // 记录原因ToolStripMenuItem
            // 
            this.记录原因ToolStripMenuItem.Name = "记录原因ToolStripMenuItem";
            this.记录原因ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.记录原因ToolStripMenuItem.Text = "记录原因";
            this.记录原因ToolStripMenuItem.Click += new System.EventHandler(this.记录原因ToolStripMenuItem_Click);
            // 
            // 上一炉次ToolStripMenuItem
            // 
            this.上一炉次ToolStripMenuItem.Name = "上一炉次ToolStripMenuItem";
            this.上一炉次ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.上一炉次ToolStripMenuItem.Text = "上一炉次";
            this.上一炉次ToolStripMenuItem.Click += new System.EventHandler(this.上一炉次ToolStripMenuItem_Click);
            // 
            // 下一炉次ToolStripMenuItem
            // 
            this.下一炉次ToolStripMenuItem.Name = "下一炉次ToolStripMenuItem";
            this.下一炉次ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.下一炉次ToolStripMenuItem.Text = "下一炉次";
            this.下一炉次ToolStripMenuItem.Click += new System.EventHandler(this.下一炉次ToolStripMenuItem_Click);
            // 
            // 跳转到指定炉次ToolStripMenuItem
            // 
            this.跳转到指定炉次ToolStripMenuItem.Name = "跳转到指定炉次ToolStripMenuItem";
            this.跳转到指定炉次ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.跳转到指定炉次ToolStripMenuItem.Text = "跳转到指定炉次";
            this.跳转到指定炉次ToolStripMenuItem.Click += new System.EventHandler(this.跳转到指定炉次ToolStripMenuItem_Click);
            // 
            // 导出到EXCELToolStripMenuItem
            // 
            this.导出到EXCELToolStripMenuItem.Name = "导出到EXCELToolStripMenuItem";
            this.导出到EXCELToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.导出到EXCELToolStripMenuItem.Text = "导出到EXCEL";
            this.导出到EXCELToolStripMenuItem.Click += new System.EventHandler(this.导出到EXCELToolStripMenuItem_Click);
            // 
            // ClIdx
            // 
            this.ClIdx.DataPropertyName = "Idx";
            this.ClIdx.HeaderText = "序号";
            this.ClIdx.Name = "ClIdx";
            this.ClIdx.ReadOnly = true;
            this.ClIdx.Width = 40;
            // 
            // ClShiJian
            // 
            this.ClShiJian.DataPropertyName = "ShiJian";
            this.ClShiJian.HeaderText = "时间";
            this.ClShiJian.Name = "ClShiJian";
            this.ClShiJian.ReadOnly = true;
            // 
            // Clteam
            // 
            this.Clteam.HeaderText = "班次";
            this.Clteam.Name = "Clteam";
            this.Clteam.ReadOnly = true;
            this.Clteam.Width = 40;
            // 
            // ClHeatID
            // 
            this.ClHeatID.DataPropertyName = "HeatID";
            this.ClHeatID.HeaderText = "炉号";
            this.ClHeatID.Name = "ClHeatID";
            this.ClHeatID.ReadOnly = true;
            this.ClHeatID.Width = 60;
            // 
            // Clsteelgradeindex
            // 
            this.Clsteelgradeindex.DataPropertyName = "steelgradeindex";
            this.Clsteelgradeindex.HeaderText = "钢种";
            this.Clsteelgradeindex.Name = "Clsteelgradeindex";
            this.Clsteelgradeindex.ReadOnly = true;
            // 
            // Clalarmtype
            // 
            this.Clalarmtype.DataPropertyName = "AlarmType";
            this.Clalarmtype.HeaderText = "报警类型";
            this.Clalarmtype.Name = "Clalarmtype";
            this.Clalarmtype.ReadOnly = true;
            // 
            // ClYuanYin
            // 
            this.ClYuanYin.DataPropertyName = "YuanYin";
            this.ClYuanYin.HeaderText = "原因分析";
            this.ClYuanYin.Name = "ClYuanYin";
            this.ClYuanYin.ReadOnly = true;
            // 
            // ClGaiJin
            // 
            this.ClGaiJin.DataPropertyName = "GaiJin";
            this.ClGaiJin.HeaderText = "改进措施";
            this.ClGaiJin.Name = "ClGaiJin";
            this.ClGaiJin.ReadOnly = true;
            // 
            // ClGuid
            // 
            this.ClGuid.DataPropertyName = "Guid";
            this.ClGuid.HeaderText = "guid";
            this.ClGuid.Name = "ClGuid";
            this.ClGuid.ReadOnly = true;
            this.ClGuid.Visible = false;
            // 
            // Clx
            // 
            this.Clx.DataPropertyName = "X";
            this.Clx.HeaderText = "数值";
            this.Clx.Name = "Clx";
            this.Clx.ReadOnly = true;
            this.Clx.Width = 60;
            // 
            // Clr
            // 
            this.Clr.DataPropertyName = "R";
            this.Clr.HeaderText = "极差";
            this.Clr.Name = "Clr";
            this.Clr.ReadOnly = true;
            this.Clr.Width = 60;
            // 
            // ClUsl
            // 
            this.ClUsl.DataPropertyName = "USL";
            this.ClUsl.HeaderText = "要求上限";
            this.ClUsl.Name = "ClUsl";
            this.ClUsl.ReadOnly = true;
            this.ClUsl.Width = 50;
            // 
            // ClLsl
            // 
            this.ClLsl.DataPropertyName = "LSL";
            this.ClLsl.HeaderText = "要求下限";
            this.ClLsl.Name = "ClLsl";
            this.ClLsl.ReadOnly = true;
            this.ClLsl.Width = 50;
            // 
            // ClAvgX
            // 
            this.ClAvgX.DataPropertyName = "AvgX";
            this.ClAvgX.HeaderText = "平均值";
            this.ClAvgX.Name = "ClAvgX";
            this.ClAvgX.ReadOnly = true;
            this.ClAvgX.Width = 50;
            // 
            // ClSd
            // 
            this.ClSd.DataPropertyName = "Sd";
            this.ClSd.HeaderText = "标准差";
            this.ClSd.Name = "ClSd";
            this.ClSd.ReadOnly = true;
            this.ClSd.Width = 50;
            // 
            // ClCp
            // 
            this.ClCp.DataPropertyName = "Cp";
            this.ClCp.HeaderText = "Cp";
            this.ClCp.Name = "ClCp";
            this.ClCp.ReadOnly = true;
            this.ClCp.Width = 50;
            // 
            // ClCpk
            // 
            this.ClCpk.DataPropertyName = "Cpk";
            this.ClCpk.HeaderText = "Cpk";
            this.ClCpk.Name = "ClCpk";
            this.ClCpk.ReadOnly = true;
            this.ClCpk.Width = 50;
            // 
            // ClPp
            // 
            this.ClPp.DataPropertyName = "Pp";
            this.ClPp.HeaderText = "Pp";
            this.ClPp.Name = "ClPp";
            this.ClPp.ReadOnly = true;
            this.ClPp.Width = 50;
            // 
            // ClPpk
            // 
            this.ClPpk.DataPropertyName = "Ppk";
            this.ClPpk.HeaderText = "Ppk";
            this.ClPpk.Name = "ClPpk";
            this.ClPpk.ReadOnly = true;
            this.ClPpk.Width = 50;
            // 
            // ClUslx
            // 
            this.ClUslx.DataPropertyName = "USLX";
            this.ClUslx.HeaderText = "上限";
            this.ClUslx.Name = "ClUslx";
            this.ClUslx.ReadOnly = true;
            this.ClUslx.Width = 50;
            // 
            // ClLslx
            // 
            this.ClLslx.DataPropertyName = "LSLX";
            this.ClLslx.HeaderText = "下限";
            this.ClLslx.Name = "ClLslx";
            this.ClLslx.ReadOnly = true;
            this.ClLslx.Width = 50;
            // 
            // ClMR
            // 
            this.ClMR.DataPropertyName = "MR";
            this.ClMR.HeaderText = "均极差";
            this.ClMR.Name = "ClMR";
            this.ClMR.ReadOnly = true;
            this.ClMR.Width = 50;
            // 
            // ClUslr
            // 
            this.ClUslr.DataPropertyName = "USLR";
            this.ClUslr.HeaderText = "极差上限";
            this.ClUslr.Name = "ClUslr";
            this.ClUslr.ReadOnly = true;
            this.ClUslr.Width = 50;
            // 
            // ClLslr
            // 
            this.ClLslr.DataPropertyName = "LSLR";
            this.ClLslr.HeaderText = "极差下限";
            this.ClLslr.Name = "ClLslr";
            this.ClLslr.ReadOnly = true;
            this.ClLslr.Width = 50;
            // 
            // ClMse
            // 
            this.ClMse.DataPropertyName = "Mse";
            this.ClMse.HeaderText = "移动极差";
            this.ClMse.Name = "ClMse";
            this.ClMse.ReadOnly = true;
            this.ClMse.Width = 50;
            // 
            // ClAnaItem
            // 
            this.ClAnaItem.DataPropertyName = "AnaItem";
            this.ClAnaItem.HeaderText = "检验项";
            this.ClAnaItem.Name = "ClAnaItem";
            this.ClAnaItem.ReadOnly = true;
            this.ClAnaItem.Visible = false;
            // 
            // ClAnaType
            // 
            this.ClAnaType.DataPropertyName = "AnaType";
            this.ClAnaType.HeaderText = "检验类型";
            this.ClAnaType.Name = "ClAnaType";
            this.ClAnaType.ReadOnly = true;
            this.ClAnaType.Visible = false;
            // 
            // spclf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 547);
            this.Controls.Add(this.gobalPanel);
            this.Name = "spclf";
            this.TabText = "控制图";
            this.Text = "控制图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAlarm)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDanzhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZhifang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJicha)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLabElement)).EndInit();
            this.gobalPanel.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private AppSvrHMI.L3DataSet dsLabElement;
        private System.Windows.Forms.Panel gobalPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private AppSvrHMI.L3Adapter Adapter;
        //private System.Windows.Forms.DataGridView flexAlarm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Chart.C1Chart chartDanzhi;
        private C1.Win.C1Chart.C1Chart chartZhifang;
        private C1.Win.C1Chart.C1Chart chartJicha;
        private AppSvrHMI.L3DataBox dbxHeatID;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem reflashMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录原因ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上一炉次ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一炉次ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳转到指定炉次ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出到EXCELToolStripMenuItem;
        private System.Windows.Forms.DataGridView gvAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClShiJian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClHeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clsteelgradeindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clalarmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClYuanYin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClGaiJin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClLsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAvgX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClSd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClCpk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPpk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUslx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClLslx;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClUslr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClLslr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAnaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClAnaType;

    }
}