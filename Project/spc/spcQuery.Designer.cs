namespace spc
{
    partial class spcQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spcQuery));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gvAlarm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSteelGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDanzhi = new C1.Win.C1Chart.C1Chart();
            this.chartZhifang = new C1.Win.C1Chart.C1Chart();
            this.chartJicha = new C1.Win.C1Chart.C1Chart();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dsLabElement = new AppSvrHMI.L3DataSet();
            this.gobalPanel = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.记录原因ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.C1Cpk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1Ppk = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.gvAlarm);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.cbSteelGrade);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.dtpEnd);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.dtpBegin);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.cbUnit);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.cbItem);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1176, 547);
            this.splitContainer2.SplitterDistance = 257;
            this.splitContainer2.TabIndex = 3;
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
            this.C1Cpk,
            this.ClPp,
            this.C1Ppk,
            this.ClUslx,
            this.ClLslx,
            this.ClMR,
            this.ClUslr,
            this.ClLslr,
            this.ClMse,
            this.ClAnaItem,
            this.ClAnaType});
            this.gvAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvAlarm.Location = new System.Drawing.Point(0, 25);
            this.gvAlarm.MultiSelect = false;
            this.gvAlarm.Name = "gvAlarm";
            this.gvAlarm.ReadOnly = true;
            this.gvAlarm.RowTemplate.Height = 23;
            this.gvAlarm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAlarm.Size = new System.Drawing.Size(1176, 232);
            this.gvAlarm.TabIndex = 1;
            this.gvAlarm.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gvAlarm_RowPostPaint);
            this.gvAlarm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAlarm_CellContentDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(928, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 45;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSteelGrade
            // 
            this.cbSteelGrade.FormattingEnabled = true;
            this.cbSteelGrade.Location = new System.Drawing.Point(741, 3);
            this.cbSteelGrade.Name = "cbSteelGrade";
            this.cbSteelGrade.Size = new System.Drawing.Size(172, 20);
            this.cbSteelGrade.TabIndex = 44;
            this.cbSteelGrade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSteelGrade_MouseClick);
            this.cbSteelGrade.SelectedIndexChanged += new System.EventHandler(this.cbSteelGrade_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "钢种：";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(585, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(97, 21);
            this.dtpEnd.TabIndex = 42;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "结束日期：";
            // 
            // dtpBegin
            // 
            this.dtpBegin.CustomFormat = "yyyy-MM-dd";
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(406, 2);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(94, 21);
            this.dtpBegin.TabIndex = 40;
            this.dtpBegin.ValueChanged += new System.EventHandler(this.dtpBegin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "开始日期：";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(78, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(74, 20);
            this.cbUnit.TabIndex = 38;
            this.cbUnit.SelectedIndexChanged += new System.EventHandler(this.cbUnit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "炉座：";
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(203, 2);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(113, 20);
            this.cbItem.TabIndex = 36;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "项目：";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1176, 25);
            this.bindingNavigator1.TabIndex = 34;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 286);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1168, 261);
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
            this.splitContainer1.Size = new System.Drawing.Size(1162, 255);
            this.splitContainer1.SplitterDistance = 160;
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
            this.panel1.Size = new System.Drawing.Size(1162, 160);
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
            this.chartDanzhi.Size = new System.Drawing.Size(892, 160);
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
            this.chartZhifang.Size = new System.Drawing.Size(270, 160);
            this.chartZhifang.TabIndex = 2;
            // 
            // chartJicha
            // 
            this.chartJicha.BackColor = System.Drawing.Color.Transparent;
            this.chartJicha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartJicha.Location = new System.Drawing.Point(0, 0);
            this.chartJicha.Name = "chartJicha";
            this.chartJicha.PropBag = resources.GetString("chartJicha.PropBag");
            this.chartJicha.Size = new System.Drawing.Size(1162, 91);
            this.chartJicha.TabIndex = 2;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.记录原因ToolStripMenuItem,
            this.导出到EXCELToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(137, 48);
            // 
            // 记录原因ToolStripMenuItem
            // 
            this.记录原因ToolStripMenuItem.Name = "记录原因ToolStripMenuItem";
            this.记录原因ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.记录原因ToolStripMenuItem.Text = "记录原因";
            this.记录原因ToolStripMenuItem.Click += new System.EventHandler(this.记录原因ToolStripMenuItem_Click);
            // 
            // 导出到EXCELToolStripMenuItem
            // 
            this.导出到EXCELToolStripMenuItem.Name = "导出到EXCELToolStripMenuItem";
            this.导出到EXCELToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导出到EXCELToolStripMenuItem.Text = "导出到EXCEL";
            this.导出到EXCELToolStripMenuItem.Click += new System.EventHandler(this.导出到EXCELToolStripMenuItem_Click);
            // 
            // ClIdx
            // 
            this.ClIdx.DataPropertyName = "Idx";
            this.ClIdx.Frozen = true;
            this.ClIdx.HeaderText = "序号";
            this.ClIdx.Name = "ClIdx";
            this.ClIdx.ReadOnly = true;
            this.ClIdx.Width = 40;
            // 
            // ClShiJian
            // 
            this.ClShiJian.DataPropertyName = "ShiJian";
            this.ClShiJian.Frozen = true;
            this.ClShiJian.HeaderText = "时间";
            this.ClShiJian.Name = "ClShiJian";
            this.ClShiJian.ReadOnly = true;
            // 
            // Clteam
            // 
            this.Clteam.DataPropertyName = "team";
            this.Clteam.Frozen = true;
            this.Clteam.HeaderText = "班次";
            this.Clteam.Name = "Clteam";
            this.Clteam.ReadOnly = true;
            this.Clteam.Width = 55;
            // 
            // ClHeatID
            // 
            this.ClHeatID.DataPropertyName = "HeatID";
            this.ClHeatID.Frozen = true;
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
            this.Clsteelgradeindex.Visible = false;
            // 
            // Clalarmtype
            // 
            this.Clalarmtype.DataPropertyName = "AlarmType";
            this.Clalarmtype.Frozen = true;
            this.Clalarmtype.HeaderText = "报警类型";
            this.Clalarmtype.Name = "Clalarmtype";
            this.Clalarmtype.ReadOnly = true;
            // 
            // ClYuanYin
            // 
            this.ClYuanYin.DataPropertyName = "YuanYin";
            this.ClYuanYin.Frozen = true;
            this.ClYuanYin.HeaderText = "原因分析";
            this.ClYuanYin.Name = "ClYuanYin";
            this.ClYuanYin.ReadOnly = true;
            // 
            // ClGaiJin
            // 
            this.ClGaiJin.DataPropertyName = "GaiJin";
            this.ClGaiJin.Frozen = true;
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
            this.Clx.Width = 55;
            // 
            // Clr
            // 
            this.Clr.DataPropertyName = "R";
            this.Clr.HeaderText = "极差";
            this.Clr.Name = "Clr";
            this.Clr.ReadOnly = true;
            this.Clr.Width = 55;
            // 
            // ClUsl
            // 
            this.ClUsl.DataPropertyName = "USL";
            this.ClUsl.HeaderText = "要求上限";
            this.ClUsl.Name = "ClUsl";
            this.ClUsl.ReadOnly = true;
            this.ClUsl.Width = 80;
            // 
            // ClLsl
            // 
            this.ClLsl.DataPropertyName = "LSL";
            this.ClLsl.HeaderText = "要求下限";
            this.ClLsl.Name = "ClLsl";
            this.ClLsl.ReadOnly = true;
            this.ClLsl.Width = 80;
            // 
            // ClAvgX
            // 
            this.ClAvgX.DataPropertyName = "AvgX";
            this.ClAvgX.HeaderText = "平均值";
            this.ClAvgX.Name = "ClAvgX";
            this.ClAvgX.ReadOnly = true;
            this.ClAvgX.Width = 70;
            // 
            // ClSd
            // 
            this.ClSd.DataPropertyName = "Sd";
            this.ClSd.HeaderText = "标准差";
            this.ClSd.Name = "ClSd";
            this.ClSd.ReadOnly = true;
            this.ClSd.Width = 70;
            // 
            // ClCp
            // 
            this.ClCp.DataPropertyName = "Cp";
            this.ClCp.HeaderText = "Cp";
            this.ClCp.Name = "ClCp";
            this.ClCp.ReadOnly = true;
            this.ClCp.Width = 50;
            // 
            // C1Cpk
            // 
            this.C1Cpk.DataPropertyName = "Cpk";
            this.C1Cpk.HeaderText = "Cpk";
            this.C1Cpk.Name = "C1Cpk";
            this.C1Cpk.ReadOnly = true;
            this.C1Cpk.Width = 50;
            // 
            // ClPp
            // 
            this.ClPp.DataPropertyName = "Pp";
            this.ClPp.HeaderText = "Pp";
            this.ClPp.Name = "ClPp";
            this.ClPp.ReadOnly = true;
            this.ClPp.Width = 50;
            // 
            // C1Ppk
            // 
            this.C1Ppk.DataPropertyName = "Ppk";
            this.C1Ppk.HeaderText = "Ppk";
            this.C1Ppk.Name = "C1Ppk";
            this.C1Ppk.ReadOnly = true;
            this.C1Ppk.Width = 50;
            // 
            // ClUslx
            // 
            this.ClUslx.DataPropertyName = "USLX";
            this.ClUslx.HeaderText = "上限";
            this.ClUslx.Name = "ClUslx";
            this.ClUslx.ReadOnly = true;
            this.ClUslx.Width = 60;
            // 
            // ClLslx
            // 
            this.ClLslx.DataPropertyName = "LSLX";
            this.ClLslx.HeaderText = "下限";
            this.ClLslx.Name = "ClLslx";
            this.ClLslx.ReadOnly = true;
            this.ClLslx.Width = 60;
            // 
            // ClMR
            // 
            this.ClMR.DataPropertyName = "MR";
            this.ClMR.HeaderText = "均极差";
            this.ClMR.Name = "ClMR";
            this.ClMR.ReadOnly = true;
            this.ClMR.Width = 70;
            // 
            // ClUslr
            // 
            this.ClUslr.DataPropertyName = "USLR";
            this.ClUslr.HeaderText = "极差上限";
            this.ClUslr.Name = "ClUslr";
            this.ClUslr.ReadOnly = true;
            this.ClUslr.Width = 80;
            // 
            // ClLslr
            // 
            this.ClLslr.DataPropertyName = "LSLR";
            this.ClLslr.HeaderText = "极差下限";
            this.ClLslr.Name = "ClLslr";
            this.ClLslr.ReadOnly = true;
            this.ClLslr.Width = 80;
            // 
            // ClMse
            // 
            this.ClMse.DataPropertyName = "Mse";
            this.ClMse.HeaderText = "移动极差";
            this.ClMse.Name = "ClMse";
            this.ClMse.ReadOnly = true;
            this.ClMse.Width = 80;
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
            // spcQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 547);
            this.Controls.Add(this.gobalPanel);
            this.Name = "spcQuery";
            this.TabText = "SPC数据查询";
            this.Text = "SPC数据查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 记录原因ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出到EXCELToolStripMenuItem;
        private System.Windows.Forms.DataGridView gvAlarm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSteelGrade;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn C1Cpk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPp;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1Ppk;
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