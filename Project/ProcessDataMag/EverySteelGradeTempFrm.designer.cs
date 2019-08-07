namespace ProcessDataMag
{
    partial class EverySteelGradeTempFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EverySteelGradeTempFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bsEle_Act = new System.Windows.Forms.BindingSource(this.components);
            this.dsElement = new AppSvrHMI.L3DataSet();
            this.schemadsElement = new System.Data.DataTable();
            this.coldsElementL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsElementL3DataTableEleMent = new System.Data.DataColumn();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.bdn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.cmbElement = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGrade = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBOFID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.LineFirst = new Steema.TeeChart.Styles.Line();
            this.pageNumber1 = new Steema.TeeChart.Tools.PageNumber();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.dsArTemp = new AppSvrHMI.L3DataSet();
            this.schemadsArTemp = new System.Data.DataTable();
            this.coldsArTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsArTempL3DataTableTemp = new System.Data.DataColumn();
            this.coldsArTempL3DataTableblowar_time = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEle_Act)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).BeginInit();
            this.bdn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsArTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bsEle_Act
            // 
            this.bsEle_Act.DataMember = "L3DataTable";
            this.bsEle_Act.DataSource = this.dsElement;
            // 
            // dsElement
            // 
            this.dsElement.AutoSubscribe = false;
            this.dsElement.DataSetName = "L3DataSet";
            this.dsElement.DeleteMethod = "";
            this.dsElement.InsertMethod = "";
            this.dsElement.L3DataAdapter = this.Adapter;
            this.dsElement.LoadEvent = "";
            this.dsElement.LoadTrigger = null;
            this.dsElement.RefreshValve = 1000;
            this.dsElement.SourceCommand = null;
            this.dsElement.SourceCondition = "";
            this.dsElement.SourceMethod = "";
            this.dsElement.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsElement.SourceURI = "";
            this.dsElement.SubscribeTarget = null;
            this.dsElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsElement});
            this.dsElement.UpdateEvent = "";
            this.dsElement.UpdateMethod = "";
            this.dsElement.UpdateTrigger = null;
            // 
            // schemadsElement
            // 
            this.schemadsElement.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsElementL3DataTableHeatID,
            this.coldsElementL3DataTableEleMent});
            this.schemadsElement.TableName = "L3DataTable";
            // 
            // coldsElementL3DataTableHeatID
            // 
            this.coldsElementL3DataTableHeatID.Caption = "HeatID";
            this.coldsElementL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsElementL3DataTableHeatID.Namespace = "";
            // 
            // coldsElementL3DataTableEleMent
            // 
            this.coldsElementL3DataTableEleMent.Caption = "EleMent";
            this.coldsElementL3DataTableEleMent.ColumnName = "EleMent";
            this.coldsElementL3DataTableEleMent.DataType = typeof(double);
            this.coldsElementL3DataTableEleMent.Namespace = "";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel10.AutoSize = false;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(120, 22);
            this.toolStripLabel10.Text = "　";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel11.Text = "  ";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2009-03";
            this.dtStart.Value = new System.DateTime(2009, 3, 9, 15, 33, 49, 390);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel7.Text = "日期:";
            // 
            // bdn1
            // 
            this.bdn1.AddNewItem = null;
            this.bdn1.CountItem = null;
            this.bdn1.DeleteItem = null;
            this.bdn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel10,
            this.btnQuery,
            this.toolStripLabel11,
            this.dtStart,
            this.toolStripLabel7,
            this.cmbElement,
            this.toolStripLabel3,
            this.cmbSteelGrade,
            this.toolStripLabel2,
            this.cmbBOFID,
            this.toolStripLabel1});
            this.bdn1.Location = new System.Drawing.Point(0, 0);
            this.bdn1.MoveFirstItem = null;
            this.bdn1.MoveLastItem = null;
            this.bdn1.MoveNextItem = null;
            this.bdn1.MovePreviousItem = null;
            this.bdn1.Name = "bdn1";
            this.bdn1.PositionItem = null;
            this.bdn1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn1.Size = new System.Drawing.Size(992, 25);
            this.bdn1.TabIndex = 0;
            this.bdn1.Text = "bindingNavigator1";
            // 
            // cmbElement
            // 
            this.cmbElement.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbElement.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbElement.Items.AddRange(new object[] {
            "1:拉碳温度",
            "2:出钢温度",
            "3:出钢温降",
            "4:氩前温度",
            "5:氩后温度",
            "6:吹氩温降"});
            this.cmbElement.Name = "cmbElement";
            this.cmbElement.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "温度类型:";
            // 
            // cmbSteelGrade
            // 
            this.cmbSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSteelGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSteelGrade.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbSteelGrade.Name = "cmbSteelGrade";
            this.cmbSteelGrade.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "钢种:";
            // 
            // cmbBOFID
            // 
            this.cmbBOFID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOFID.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbBOFID.Items.AddRange(new object[] {
            "S21",
            "S22",
            "S23",
            "S24"});
            this.cmbBOFID.Name = "cmbBOFID";
            this.cmbBOFID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "转炉:";
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = "";
            this.dsSteelGrade.InsertMethod = "";
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSteelGrade.SourceURI = "";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "";
            this.dsSteelGrade.UpdateMethod = "";
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ColorPaletteIndex = 16;
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.tChart1.Axes.Bottom.Increment = 1;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Angle = 90;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            this.tChart1.Axes.Bottom.TickOnLabelsOnly = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Left.EndPosition = 98;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Angle = 90;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Axes.Left.Maximum = 0;
            this.tChart1.Axes.Left.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            this.tChart1.Axes.Left.StartPosition = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = false;
            this.tChart1.Axes.Top.AutomaticMaximum = false;
            this.tChart1.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.AxisPen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Axes.Top.Maximum = 0;
            this.tChart1.Axes.Top.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            this.tChart1.Axes.Top.PositionUnits = Steema.TeeChart.PositionUnits.Pixels;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tChart1.Axes.Top.Visible = false;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart1.Legend.Brush.Gradient.Visible = true;
            this.tChart1.Legend.CheckBoxes = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            this.tChart1.Legend.ResizeChart = false;
            this.tChart1.Location = new System.Drawing.Point(0, 25);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            this.tChart1.Page.MaxPointsPerPage = 30;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            this.tChart1.Series.Add(this.LineFirst);
            this.tChart1.Size = new System.Drawing.Size(992, 641);
            this.tChart1.TabIndex = 2;
            this.tChart1.Tools.Add(this.pageNumber1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            // 
            // 
            // 
            this.tChart1.Walls.Back.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Left.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Walls.Right.Pen.Visible = false;
            // 
            // LineFirst
            // 
            // 
            // 
            // 
            this.LineFirst.Brush.Color = System.Drawing.Color.Cyan;
            this.LineFirst.Color = System.Drawing.Color.Cyan;
            this.LineFirst.ColorEach = false;
            this.LineFirst.DataSource = this.bsEle_Act;
            // 
            // 
            // 
            this.LineFirst.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LineFirst.LinePen.Width = 2;
            // 
            // 
            // 
            this.LineFirst.Marks.Angle = 5;
            // 
            // 
            // 
            this.LineFirst.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LineFirst.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.LineFirst.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LineFirst.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.LineFirst.Marks.Brush.Gradient.SigmaScale = 0F;
            this.LineFirst.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.LineFirst.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.LineFirst.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.LineFirst.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.LineFirst.Marks.Callout.Distance = 0;
            this.LineFirst.Marks.Callout.Draw3D = false;
            this.LineFirst.Marks.Callout.Length = 10;
            this.LineFirst.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.LineFirst.Marks.Callout.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.LineFirst.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineFirst.Marks.Transparent = true;
            this.LineFirst.Marks.Visible = true;
            // 
            // 
            // 
            this.LineFirst.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.LineFirst.Title = "实际值";
            this.LineFirst.ValueFormat = "";
            // 
            // 
            // 
            this.LineFirst.XValues.DataMember = "HeatID";
            this.LineFirst.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.LineFirst.YValues.DataMember = "EleMent";
            // 
            // pageNumber1
            // 
            this.pageNumber1.AutoSize = true;
            this.pageNumber1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pageNumber1.Format = "Page {0} of {1}";
            // 
            // 
            // 
            this.pageNumber1.Shape.Lines = new string[] {
        "Page {0} of {1}"};
            // 
            // 
            // 
            this.pageNumber1.Shape.Shadow.Visible = true;
            this.pageNumber1.Text = "Page {0} of {1}";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(210, 51);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(34, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(250, 51);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(34, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(290, 51);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(34, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(330, 51);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(34, 23);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // dsArTemp
            // 
            this.dsArTemp.AutoSubscribe = false;
            this.dsArTemp.DataSetName = "L3DataSet";
            this.dsArTemp.DeleteMethod = "";
            this.dsArTemp.InsertMethod = "";
            this.dsArTemp.L3DataAdapter = this.Adapter;
            this.dsArTemp.LoadEvent = "";
            this.dsArTemp.LoadTrigger = null;
            this.dsArTemp.RefreshValve = 1000;
            this.dsArTemp.SourceCommand = null;
            this.dsArTemp.SourceCondition = "";
            this.dsArTemp.SourceMethod = "";
            this.dsArTemp.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsArTemp.SourceURI = "";
            this.dsArTemp.SubscribeTarget = null;
            this.dsArTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsArTemp});
            this.dsArTemp.UpdateEvent = "";
            this.dsArTemp.UpdateMethod = "";
            this.dsArTemp.UpdateTrigger = null;
            // 
            // schemadsArTemp
            // 
            this.schemadsArTemp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsArTempL3DataTableHeatID,
            this.coldsArTempL3DataTableTemp,
            this.coldsArTempL3DataTableblowar_time});
            this.schemadsArTemp.TableName = "L3DataTable";
            // 
            // coldsArTempL3DataTableHeatID
            // 
            this.coldsArTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsArTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsArTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsArTempL3DataTableTemp
            // 
            this.coldsArTempL3DataTableTemp.Caption = "Temp";
            this.coldsArTempL3DataTableTemp.ColumnName = "Temp";
            this.coldsArTempL3DataTableTemp.DefaultValue = "0";
            this.coldsArTempL3DataTableTemp.Namespace = "";
            // 
            // coldsArTempL3DataTableblowar_time
            // 
            this.coldsArTempL3DataTableblowar_time.Caption = "blowar_time";
            this.coldsArTempL3DataTableblowar_time.ColumnName = "blowar_time";
            this.coldsArTempL3DataTableblowar_time.DataType = typeof(double);
            this.coldsArTempL3DataTableblowar_time.DefaultValue = 0;
            this.coldsArTempL3DataTableblowar_time.Namespace = "";
            // 
            // EverySteelGradeTempFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.bdn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EverySteelGradeTempFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "各钢种温度监控";
            this.Text = "各钢种温度监控";
            this.Load += new System.EventHandler(this.EverySteelGradeTempFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEle_Act)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).EndInit();
            this.bdn1.ResumeLayout(false);
            this.bdn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsArTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.BindingNavigator bdn1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbBOFID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private AppSvrHMI.L3DataSet dsElement;
        private System.Data.DataTable schemadsElement;
        private System.Data.DataColumn coldsElementL3DataTableHeatID;
        private System.Windows.Forms.BindingSource bsEle_Act;
        private System.Windows.Forms.ToolStripComboBox cmbElement;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line LineFirst;
        private Steema.TeeChart.Tools.PageNumber pageNumber1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private System.Data.DataColumn coldsElementL3DataTableEleMent;
        private AppSvrHMI.L3DataSet dsArTemp;
        private System.Data.DataTable schemadsArTemp;
        private System.Data.DataColumn coldsArTempL3DataTableHeatID;
        private System.Data.DataColumn coldsArTempL3DataTableTemp;
        private System.Data.DataColumn coldsArTempL3DataTableblowar_time;
    }
}