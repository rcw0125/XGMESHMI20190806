namespace ProcessDataMag
{
    partial class CoolWaterFlowFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolWaterFlowFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bdn2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.txtTime = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lbFlow = new System.Windows.Forms.ToolStripLabel();
            this.txtFlow = new System.Windows.Forms.ToolStripTextBox();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.lineFlow = new Steema.TeeChart.Styles.Line();
            this.bsFlow = new System.Windows.Forms.BindingSource(this.components);
            this.dsFlow = new AppSvrHMI.L3DataSet();
            this.schemadsFlow = new System.Data.DataTable();
            this.coldsFlowL3DataTableTagValue = new System.Data.DataColumn();
            this.coldsFlowL3DataTableCatch_Time = new System.Data.DataColumn();
            this.coldsFlowL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsFlowL3DataTableElement = new System.Data.DataColumn();
            this.coldsFlowL3DataTableEle_Aim = new System.Data.DataColumn();
            this.coldsFlowL3DataTableLogTime = new System.Data.DataColumn();
            this.cursorTool1 = new Steema.TeeChart.Tools.CursorTool();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.bdn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.cmbCCMID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bdn2)).BeginInit();
            this.bdn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).BeginInit();
            this.bdn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bdn2
            // 
            this.bdn2.AddNewItem = null;
            this.bdn2.CountItem = null;
            this.bdn2.DeleteItem = null;
            this.bdn2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel8,
            this.txtTime,
            this.toolStripSeparator1,
            this.lbFlow,
            this.txtFlow});
            this.bdn2.Location = new System.Drawing.Point(0, 25);
            this.bdn2.MoveFirstItem = null;
            this.bdn2.MoveLastItem = null;
            this.bdn2.MoveNextItem = null;
            this.bdn2.MovePreviousItem = null;
            this.bdn2.Name = "bdn2";
            this.bdn2.PositionItem = null;
            this.bdn2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bdn2.Size = new System.Drawing.Size(992, 25);
            this.bdn2.TabIndex = 1;
            this.bdn2.Text = "bindingNavigator2";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel8.Text = "时间:";
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(120, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lbFlow
            // 
            this.lbFlow.Name = "lbFlow";
            this.lbFlow.Size = new System.Drawing.Size(35, 22);
            this.lbFlow.Text = "流量:";
            // 
            // txtFlow
            // 
            this.txtFlow.Name = "txtFlow";
            this.txtFlow.ReadOnly = true;
            this.txtFlow.Size = new System.Drawing.Size(100, 25);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ColorPaletteIndex = 11;
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
            // 
            // 
            // 
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
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
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
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
            this.tChart1.Location = new System.Drawing.Point(0, 50);
            this.tChart1.Margin = new System.Windows.Forms.Padding(0);
            this.tChart1.Name = "tChart1";
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
            this.tChart1.Series.Add(this.lineFlow);
            this.tChart1.Size = new System.Drawing.Size(992, 616);
            this.tChart1.TabIndex = 2;
            this.tChart1.Tools.Add(this.cursorTool1);
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
            this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
            // 
            // lineFlow
            // 
            // 
            // 
            // 
            this.lineFlow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(210)))));
            this.lineFlow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(210)))));
            this.lineFlow.ColorEach = false;
            this.lineFlow.DataSource = this.bsFlow;
            // 
            // 
            // 
            this.lineFlow.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFlow.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lineFlow.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lineFlow.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.lineFlow.Marks.Brush.Gradient.SigmaScale = 0F;
            this.lineFlow.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lineFlow.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.lineFlow.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.lineFlow.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.lineFlow.Marks.Callout.Distance = 0;
            this.lineFlow.Marks.Callout.Draw3D = false;
            this.lineFlow.Marks.Callout.Length = 10;
            this.lineFlow.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineFlow.Marks.Callout.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.lineFlow.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lineFlow.Marks.Transparent = true;
            // 
            // 
            // 
            this.lineFlow.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.lineFlow.Title = "二冷水流量";
            // 
            // 
            // 
            this.lineFlow.XValues.DataMember = "LogTime";
            this.lineFlow.XValues.DateTime = true;
            this.lineFlow.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.lineFlow.YValues.DataMember = "Element";
            // 
            // bsFlow
            // 
            this.bsFlow.DataMember = "L3DataTable";
            this.bsFlow.DataSource = this.dsFlow;
            // 
            // dsFlow
            // 
            this.dsFlow.AutoLoad = true;
            this.dsFlow.AutoSubscribe = false;
            this.dsFlow.DataSetName = "L3DataSet";
            this.dsFlow.DeleteMethod = "";
            this.dsFlow.InsertMethod = "";
            this.dsFlow.L3DataAdapter = this.Adapter;
            this.dsFlow.LoadEvent = "";
            this.dsFlow.LoadTrigger = null;
            this.dsFlow.RefreshValve = 1000;
            this.dsFlow.SourceCommand = null;
            this.dsFlow.SourceCondition = "";
            this.dsFlow.SourceMethod = "";
            this.dsFlow.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFlow.SourceURI = "";
            this.dsFlow.SubscribeTarget = null;
            this.dsFlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFlow});
            this.dsFlow.UpdateEvent = "";
            this.dsFlow.UpdateMethod = "";
            this.dsFlow.UpdateTrigger = null;
            // 
            // schemadsFlow
            // 
            this.schemadsFlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFlowL3DataTableTagValue,
            this.coldsFlowL3DataTableCatch_Time,
            this.coldsFlowL3DataTableHeatID,
            this.coldsFlowL3DataTableElement,
            this.coldsFlowL3DataTableEle_Aim,
            this.coldsFlowL3DataTableLogTime});
            this.schemadsFlow.TableName = "L3DataTable";
            // 
            // coldsFlowL3DataTableTagValue
            // 
            this.coldsFlowL3DataTableTagValue.Caption = "TagValue";
            this.coldsFlowL3DataTableTagValue.ColumnName = "TagValue";
            this.coldsFlowL3DataTableTagValue.DataType = typeof(double);
            this.coldsFlowL3DataTableTagValue.Namespace = "";
            // 
            // coldsFlowL3DataTableCatch_Time
            // 
            this.coldsFlowL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsFlowL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsFlowL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsFlowL3DataTableCatch_Time.Namespace = "";
            // 
            // coldsFlowL3DataTableHeatID
            // 
            this.coldsFlowL3DataTableHeatID.Caption = "HeatID";
            this.coldsFlowL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsFlowL3DataTableHeatID.Namespace = "";
            // 
            // coldsFlowL3DataTableElement
            // 
            this.coldsFlowL3DataTableElement.Caption = "Element";
            this.coldsFlowL3DataTableElement.ColumnName = "Element";
            this.coldsFlowL3DataTableElement.DataType = typeof(double);
            this.coldsFlowL3DataTableElement.Namespace = "";
            // 
            // coldsFlowL3DataTableEle_Aim
            // 
            this.coldsFlowL3DataTableEle_Aim.Caption = "Ele_Aim";
            this.coldsFlowL3DataTableEle_Aim.ColumnName = "Ele_Aim";
            this.coldsFlowL3DataTableEle_Aim.DataType = typeof(double);
            this.coldsFlowL3DataTableEle_Aim.Namespace = "";
            // 
            // coldsFlowL3DataTableLogTime
            // 
            this.coldsFlowL3DataTableLogTime.Caption = "LogTime";
            this.coldsFlowL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsFlowL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsFlowL3DataTableLogTime.Namespace = "";
            // 
            // cursorTool1
            // 
            this.cursorTool1.FollowMouse = true;
            // 
            // 
            // 
            this.cursorTool1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cursorTool1.Style = Steema.TeeChart.Tools.CursorToolStyles.Vertical;
            this.cursorTool1.Change += new Steema.TeeChart.Tools.CursorChangeEventHandler(this.cursorTool1_Change);
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
            this.btnQuery.Size = new System.Drawing.Size(51, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel11.Text = "  ";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2009-03-09";
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
            this.cmbCCMID,
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
            // cmbCCMID
            // 
            this.cmbCCMID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCCMID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCMID.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbCCMID.Items.AddRange(new object[] {
            "S61",
            "S62",
            "S63",
            "S64",
            "S65",
            "S67"});
            this.cmbCCMID.Name = "cmbCCMID";
            this.cmbCCMID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "铸机:";
            // 
            // CoolWaterFlowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 666);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.bdn2);
            this.Controls.Add(this.bdn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoolWaterFlowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "趋势";
            this.Text = "趋势";
            this.Load += new System.EventHandler(this.CoolWaterFlowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdn2)).EndInit();
            this.bdn2.ResumeLayout(false);
            this.bdn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdn1)).EndInit();
            this.bdn1.ResumeLayout(false);
            this.bdn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bdn2;
        private System.Windows.Forms.ToolStripLabel lbFlow;
        private System.Windows.Forms.ToolStripTextBox txtFlow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox txtTime;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Line lineFlow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.BindingNavigator bdn1;
        private AppSvrHMI.L3DataSet dsFlow;
        private System.Data.DataTable schemadsFlow;
        private System.Data.DataColumn coldsFlowL3DataTableTagValue;
        private System.Data.DataColumn coldsFlowL3DataTableCatch_Time;
        private System.Windows.Forms.BindingSource bsFlow;
        private Steema.TeeChart.Tools.CursorTool cursorTool1;
        private System.Windows.Forms.ToolStripComboBox cmbCCMID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Data.DataColumn coldsFlowL3DataTableHeatID;
        private System.Data.DataColumn coldsFlowL3DataTableElement;
        private System.Data.DataColumn coldsFlowL3DataTableEle_Aim;
        private System.Data.DataColumn coldsFlowL3DataTableLogTime;
    }
}