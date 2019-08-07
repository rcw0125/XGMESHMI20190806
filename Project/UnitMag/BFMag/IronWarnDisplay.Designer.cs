namespace UnitMag
{
    partial class IronWarnDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronWarnDisplay));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvSteelGrade = new System.Windows.Forms.DataGridView();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelGradeStd = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelGradeStd = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeStd = new System.Data.DataTable();
            this.coldsSteelGradeStdL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableC_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableC_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSi_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSi_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableMn_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableMn_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableTi_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableTi_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSn_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSn_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSb_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableSb_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableAs_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTableAs_Min = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTablePb_Max = new System.Data.DataColumn();
            this.coldsSteelGradeStdL3DataTablePb_Min = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsCmbSteelGrade = new System.Windows.Forms.ToolStripComboBox();
            this.tsLblSteelGrade = new System.Windows.Forms.ToolStripLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvIronInfo = new System.Windows.Forms.DataGridView();
            this.Production_Date = new DataGridValid.DataGridViewValidateCellColumn();
            this.Arrival_Time = new DataGridValid.DataGridViewValidateCellColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIronInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronInfo = new AppSvrHMI.L3DataSet();
            this.schemadsIronInfo = new System.Data.DataTable();
            this.coldsIronInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePosition = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableBFID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSource = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableDestination = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableShift = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTeam = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableResult = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableC = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableS = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableP = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableAs = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableFeed_Time = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSend_Time = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSampCode = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronConfirm = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableC_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSi_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMn_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableS_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableP_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTi_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSn_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSb_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableAs_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePb_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableGrossFlag = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTareFlag = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableAnalysisFlag = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOperator_B = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableDeSFlag = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableDeSType = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbPath = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSoure = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dsWeight = new AppSvrHMI.L3DataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeStd)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 438);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 438);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvSteelGrade);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 196);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "钢种标准";
            // 
            // dvSteelGrade
            // 
            this.dvSteelGrade.AllowUserToAddRows = false;
            this.dvSteelGrade.AutoGenerateColumns = false;
            this.dvSteelGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSteelGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSteelGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.cMaxDataGridViewTextBoxColumn,
            this.cMinDataGridViewTextBoxColumn,
            this.siMaxDataGridViewTextBoxColumn,
            this.siMinDataGridViewTextBoxColumn,
            this.mnMaxDataGridViewTextBoxColumn,
            this.mnMinDataGridViewTextBoxColumn,
            this.pMaxDataGridViewTextBoxColumn,
            this.pMinDataGridViewTextBoxColumn,
            this.sMaxDataGridViewTextBoxColumn,
            this.sMinDataGridViewTextBoxColumn,
            this.tiMaxDataGridViewTextBoxColumn,
            this.tiMinDataGridViewTextBoxColumn,
            this.snMaxDataGridViewTextBoxColumn,
            this.snMinDataGridViewTextBoxColumn,
            this.sbMaxDataGridViewTextBoxColumn,
            this.sbMinDataGridViewTextBoxColumn,
            this.asMaxDataGridViewTextBoxColumn,
            this.asMinDataGridViewTextBoxColumn,
            this.pbMaxDataGridViewTextBoxColumn,
            this.pbMinDataGridViewTextBoxColumn});
            this.dvSteelGrade.DataSource = this.bsSteelGradeStd;
            this.dvSteelGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteelGrade.Location = new System.Drawing.Point(3, 42);
            this.dvSteelGrade.MultiSelect = false;
            this.dvSteelGrade.Name = "dvSteelGrade";
            this.dvSteelGrade.ReadOnly = true;
            this.dvSteelGrade.RowTemplate.Height = 23;
            this.dvSteelGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSteelGrade.Size = new System.Drawing.Size(1177, 151);
            this.dvSteelGrade.TabIndex = 0;
            this.dvSteelGrade.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvSteelGrade_RowPostPaint);
            this.dvSteelGrade.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvSteelGrade_DataError);
            this.dvSteelGrade.SelectionChanged += new System.EventHandler(this.dvSteelGrade_SelectionChanged);
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.Frozen = true;
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeDataGridViewTextBoxColumn.Width = 54;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // cMaxDataGridViewTextBoxColumn
            // 
            this.cMaxDataGridViewTextBoxColumn.DataPropertyName = "C_Max";
            this.cMaxDataGridViewTextBoxColumn.HeaderText = "C最大";
            this.cMaxDataGridViewTextBoxColumn.Name = "cMaxDataGridViewTextBoxColumn";
            this.cMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // cMinDataGridViewTextBoxColumn
            // 
            this.cMinDataGridViewTextBoxColumn.DataPropertyName = "C_Min";
            this.cMinDataGridViewTextBoxColumn.HeaderText = "C最小";
            this.cMinDataGridViewTextBoxColumn.Name = "cMinDataGridViewTextBoxColumn";
            this.cMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // siMaxDataGridViewTextBoxColumn
            // 
            this.siMaxDataGridViewTextBoxColumn.DataPropertyName = "Si_Max";
            this.siMaxDataGridViewTextBoxColumn.HeaderText = "Si最大";
            this.siMaxDataGridViewTextBoxColumn.Name = "siMaxDataGridViewTextBoxColumn";
            this.siMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.siMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // siMinDataGridViewTextBoxColumn
            // 
            this.siMinDataGridViewTextBoxColumn.DataPropertyName = "Si_Min";
            this.siMinDataGridViewTextBoxColumn.HeaderText = "Si最小";
            this.siMinDataGridViewTextBoxColumn.Name = "siMinDataGridViewTextBoxColumn";
            this.siMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.siMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMaxDataGridViewTextBoxColumn
            // 
            this.mnMaxDataGridViewTextBoxColumn.DataPropertyName = "Mn_Max";
            this.mnMaxDataGridViewTextBoxColumn.HeaderText = "Mn最大";
            this.mnMaxDataGridViewTextBoxColumn.Name = "mnMaxDataGridViewTextBoxColumn";
            this.mnMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnMinDataGridViewTextBoxColumn
            // 
            this.mnMinDataGridViewTextBoxColumn.DataPropertyName = "Mn_Min";
            this.mnMinDataGridViewTextBoxColumn.HeaderText = "Mn最小";
            this.mnMinDataGridViewTextBoxColumn.Name = "mnMinDataGridViewTextBoxColumn";
            this.mnMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // pMaxDataGridViewTextBoxColumn
            // 
            this.pMaxDataGridViewTextBoxColumn.DataPropertyName = "P_Max";
            this.pMaxDataGridViewTextBoxColumn.HeaderText = "P最大";
            this.pMaxDataGridViewTextBoxColumn.Name = "pMaxDataGridViewTextBoxColumn";
            this.pMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // pMinDataGridViewTextBoxColumn
            // 
            this.pMinDataGridViewTextBoxColumn.DataPropertyName = "P_Min";
            this.pMinDataGridViewTextBoxColumn.HeaderText = "P最小";
            this.pMinDataGridViewTextBoxColumn.Name = "pMinDataGridViewTextBoxColumn";
            this.pMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMaxDataGridViewTextBoxColumn
            // 
            this.sMaxDataGridViewTextBoxColumn.DataPropertyName = "S_Max";
            this.sMaxDataGridViewTextBoxColumn.HeaderText = "S最大";
            this.sMaxDataGridViewTextBoxColumn.Name = "sMaxDataGridViewTextBoxColumn";
            this.sMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMaxDataGridViewTextBoxColumn.Width = 60;
            // 
            // sMinDataGridViewTextBoxColumn
            // 
            this.sMinDataGridViewTextBoxColumn.DataPropertyName = "S_Min";
            this.sMinDataGridViewTextBoxColumn.HeaderText = "S最小";
            this.sMinDataGridViewTextBoxColumn.Name = "sMinDataGridViewTextBoxColumn";
            this.sMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMinDataGridViewTextBoxColumn.Width = 60;
            // 
            // tiMaxDataGridViewTextBoxColumn
            // 
            this.tiMaxDataGridViewTextBoxColumn.DataPropertyName = "Ti_Max";
            this.tiMaxDataGridViewTextBoxColumn.HeaderText = "Ti最大";
            this.tiMaxDataGridViewTextBoxColumn.Name = "tiMaxDataGridViewTextBoxColumn";
            this.tiMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // tiMinDataGridViewTextBoxColumn
            // 
            this.tiMinDataGridViewTextBoxColumn.DataPropertyName = "Ti_Min";
            this.tiMinDataGridViewTextBoxColumn.HeaderText = "Ti最小";
            this.tiMinDataGridViewTextBoxColumn.Name = "tiMinDataGridViewTextBoxColumn";
            this.tiMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMaxDataGridViewTextBoxColumn
            // 
            this.snMaxDataGridViewTextBoxColumn.DataPropertyName = "Sn_Max";
            this.snMaxDataGridViewTextBoxColumn.HeaderText = "Sn最大";
            this.snMaxDataGridViewTextBoxColumn.Name = "snMaxDataGridViewTextBoxColumn";
            this.snMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.snMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // snMinDataGridViewTextBoxColumn
            // 
            this.snMinDataGridViewTextBoxColumn.DataPropertyName = "Sn_Min";
            this.snMinDataGridViewTextBoxColumn.HeaderText = "Sn最小";
            this.snMinDataGridViewTextBoxColumn.Name = "snMinDataGridViewTextBoxColumn";
            this.snMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.snMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbMaxDataGridViewTextBoxColumn
            // 
            this.sbMaxDataGridViewTextBoxColumn.DataPropertyName = "Sb_Max";
            this.sbMaxDataGridViewTextBoxColumn.HeaderText = "Sb最大";
            this.sbMaxDataGridViewTextBoxColumn.Name = "sbMaxDataGridViewTextBoxColumn";
            this.sbMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbMinDataGridViewTextBoxColumn
            // 
            this.sbMinDataGridViewTextBoxColumn.DataPropertyName = "Sb_Min";
            this.sbMinDataGridViewTextBoxColumn.HeaderText = "Sb最小";
            this.sbMinDataGridViewTextBoxColumn.Name = "sbMinDataGridViewTextBoxColumn";
            this.sbMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMaxDataGridViewTextBoxColumn
            // 
            this.asMaxDataGridViewTextBoxColumn.DataPropertyName = "As_Max";
            this.asMaxDataGridViewTextBoxColumn.HeaderText = "As最大";
            this.asMaxDataGridViewTextBoxColumn.Name = "asMaxDataGridViewTextBoxColumn";
            this.asMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.asMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // asMinDataGridViewTextBoxColumn
            // 
            this.asMinDataGridViewTextBoxColumn.DataPropertyName = "As_Min";
            this.asMinDataGridViewTextBoxColumn.HeaderText = "As最小";
            this.asMinDataGridViewTextBoxColumn.Name = "asMinDataGridViewTextBoxColumn";
            this.asMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.asMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbMaxDataGridViewTextBoxColumn
            // 
            this.pbMaxDataGridViewTextBoxColumn.DataPropertyName = "Pb_Max";
            this.pbMaxDataGridViewTextBoxColumn.HeaderText = "Pb最大";
            this.pbMaxDataGridViewTextBoxColumn.Name = "pbMaxDataGridViewTextBoxColumn";
            this.pbMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbMaxDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbMinDataGridViewTextBoxColumn
            // 
            this.pbMinDataGridViewTextBoxColumn.DataPropertyName = "Pb_Min";
            this.pbMinDataGridViewTextBoxColumn.HeaderText = "Pb最小";
            this.pbMinDataGridViewTextBoxColumn.Name = "pbMinDataGridViewTextBoxColumn";
            this.pbMinDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbMinDataGridViewTextBoxColumn.Width = 66;
            // 
            // bsSteelGradeStd
            // 
            this.bsSteelGradeStd.DataMember = "L3DataTable";
            this.bsSteelGradeStd.DataSource = this.dsSteelGradeStd;
            // 
            // dsSteelGradeStd
            // 
            this.dsSteelGradeStd.AutoLoad = true;
            this.dsSteelGradeStd.AutoSubscribe = true;
            this.dsSteelGradeStd.DataSetName = "L3DataSet";
            this.dsSteelGradeStd.DeleteMethod = null;
            this.dsSteelGradeStd.InsertMethod = null;
            this.dsSteelGradeStd.L3DataAdapter = this.Adapter;
            this.dsSteelGradeStd.LoadEvent = "Click";
            this.dsSteelGradeStd.LoadTrigger = null;
            this.dsSteelGradeStd.RefreshValve = 1000;
            this.dsSteelGradeStd.SourceCommand = null;
            this.dsSteelGradeStd.SourceCondition = "";
            this.dsSteelGradeStd.SourceMethod = "";
            this.dsSteelGradeStd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeStd.SourceURI = "XGMESLogic\\QualityMag\\CQA_Element_Std";
            this.dsSteelGradeStd.SubscribeTarget = null;
            this.dsSteelGradeStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeStd});
            this.dsSteelGradeStd.UpdateEvent = "Click";
            this.dsSteelGradeStd.UpdateMethod = null;
            this.dsSteelGradeStd.UpdateTrigger = null;
            // 
            // schemadsSteelGradeStd
            // 
            this.schemadsSteelGradeStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeStdL3DataTableSteelGrade,
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex,
            this.coldsSteelGradeStdL3DataTableC_Max,
            this.coldsSteelGradeStdL3DataTableC_Min,
            this.coldsSteelGradeStdL3DataTableSi_Max,
            this.coldsSteelGradeStdL3DataTableSi_Min,
            this.coldsSteelGradeStdL3DataTableMn_Max,
            this.coldsSteelGradeStdL3DataTableMn_Min,
            this.coldsSteelGradeStdL3DataTableP_Max,
            this.coldsSteelGradeStdL3DataTableP_Min,
            this.coldsSteelGradeStdL3DataTableS_Max,
            this.coldsSteelGradeStdL3DataTableS_Min,
            this.coldsSteelGradeStdL3DataTableTi_Max,
            this.coldsSteelGradeStdL3DataTableTi_Min,
            this.coldsSteelGradeStdL3DataTableSn_Max,
            this.coldsSteelGradeStdL3DataTableSn_Min,
            this.coldsSteelGradeStdL3DataTableSb_Max,
            this.coldsSteelGradeStdL3DataTableSb_Min,
            this.coldsSteelGradeStdL3DataTableAs_Max,
            this.coldsSteelGradeStdL3DataTableAs_Min,
            this.coldsSteelGradeStdL3DataTablePb_Max,
            this.coldsSteelGradeStdL3DataTablePb_Min});
            this.schemadsSteelGradeStd.TableName = "L3DataTable";
            // 
            // coldsSteelGradeStdL3DataTableSteelGrade
            // 
            this.coldsSteelGradeStdL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeStdL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeStdL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeStdL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableC_Max
            // 
            this.coldsSteelGradeStdL3DataTableC_Max.Caption = "C_Max";
            this.coldsSteelGradeStdL3DataTableC_Max.ColumnName = "C_Max";
            this.coldsSteelGradeStdL3DataTableC_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableC_Min
            // 
            this.coldsSteelGradeStdL3DataTableC_Min.Caption = "C_Min";
            this.coldsSteelGradeStdL3DataTableC_Min.ColumnName = "C_Min";
            this.coldsSteelGradeStdL3DataTableC_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSi_Max
            // 
            this.coldsSteelGradeStdL3DataTableSi_Max.Caption = "Si_Max";
            this.coldsSteelGradeStdL3DataTableSi_Max.ColumnName = "Si_Max";
            this.coldsSteelGradeStdL3DataTableSi_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSi_Min
            // 
            this.coldsSteelGradeStdL3DataTableSi_Min.Caption = "Si_Min";
            this.coldsSteelGradeStdL3DataTableSi_Min.ColumnName = "Si_Min";
            this.coldsSteelGradeStdL3DataTableSi_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableMn_Max
            // 
            this.coldsSteelGradeStdL3DataTableMn_Max.Caption = "Mn_Max";
            this.coldsSteelGradeStdL3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coldsSteelGradeStdL3DataTableMn_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableMn_Min
            // 
            this.coldsSteelGradeStdL3DataTableMn_Min.Caption = "Mn_Min";
            this.coldsSteelGradeStdL3DataTableMn_Min.ColumnName = "Mn_Min";
            this.coldsSteelGradeStdL3DataTableMn_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableP_Max
            // 
            this.coldsSteelGradeStdL3DataTableP_Max.Caption = "P_Max";
            this.coldsSteelGradeStdL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsSteelGradeStdL3DataTableP_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableP_Min
            // 
            this.coldsSteelGradeStdL3DataTableP_Min.Caption = "P_Min";
            this.coldsSteelGradeStdL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsSteelGradeStdL3DataTableP_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableS_Max
            // 
            this.coldsSteelGradeStdL3DataTableS_Max.Caption = "S_Max";
            this.coldsSteelGradeStdL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsSteelGradeStdL3DataTableS_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableS_Min
            // 
            this.coldsSteelGradeStdL3DataTableS_Min.Caption = "S_Min";
            this.coldsSteelGradeStdL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsSteelGradeStdL3DataTableS_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableTi_Max
            // 
            this.coldsSteelGradeStdL3DataTableTi_Max.Caption = "Ti_Max";
            this.coldsSteelGradeStdL3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coldsSteelGradeStdL3DataTableTi_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableTi_Min
            // 
            this.coldsSteelGradeStdL3DataTableTi_Min.Caption = "Ti_Min";
            this.coldsSteelGradeStdL3DataTableTi_Min.ColumnName = "Ti_Min";
            this.coldsSteelGradeStdL3DataTableTi_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSn_Max
            // 
            this.coldsSteelGradeStdL3DataTableSn_Max.Caption = "Sn_Max";
            this.coldsSteelGradeStdL3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coldsSteelGradeStdL3DataTableSn_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSn_Min
            // 
            this.coldsSteelGradeStdL3DataTableSn_Min.Caption = "Sn_Min";
            this.coldsSteelGradeStdL3DataTableSn_Min.ColumnName = "Sn_Min";
            this.coldsSteelGradeStdL3DataTableSn_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSb_Max
            // 
            this.coldsSteelGradeStdL3DataTableSb_Max.Caption = "Sb_Max";
            this.coldsSteelGradeStdL3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coldsSteelGradeStdL3DataTableSb_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableSb_Min
            // 
            this.coldsSteelGradeStdL3DataTableSb_Min.Caption = "Sb_Min";
            this.coldsSteelGradeStdL3DataTableSb_Min.ColumnName = "Sb_Min";
            this.coldsSteelGradeStdL3DataTableSb_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableAs_Max
            // 
            this.coldsSteelGradeStdL3DataTableAs_Max.Caption = "As_Max";
            this.coldsSteelGradeStdL3DataTableAs_Max.ColumnName = "As_Max";
            this.coldsSteelGradeStdL3DataTableAs_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTableAs_Min
            // 
            this.coldsSteelGradeStdL3DataTableAs_Min.Caption = "As_Min";
            this.coldsSteelGradeStdL3DataTableAs_Min.ColumnName = "As_Min";
            this.coldsSteelGradeStdL3DataTableAs_Min.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTablePb_Max
            // 
            this.coldsSteelGradeStdL3DataTablePb_Max.Caption = "Pb_Max";
            this.coldsSteelGradeStdL3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coldsSteelGradeStdL3DataTablePb_Max.Namespace = "";
            // 
            // coldsSteelGradeStdL3DataTablePb_Min
            // 
            this.coldsSteelGradeStdL3DataTablePb_Min.Caption = "Pb_Min";
            this.coldsSteelGradeStdL3DataTablePb_Min.ColumnName = "Pb_Min";
            this.coldsSteelGradeStdL3DataTablePb_Min.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCmbSteelGrade,
            this.tsLblSteelGrade});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1177, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsCmbSteelGrade
            // 
            this.tsCmbSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCmbSteelGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsCmbSteelGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tsCmbSteelGrade.Name = "tsCmbSteelGrade";
            this.tsCmbSteelGrade.Size = new System.Drawing.Size(166, 25);
            this.tsCmbSteelGrade.TextChanged += new System.EventHandler(this.tsCmbSteelGrade_TextChanged);
            // 
            // tsLblSteelGrade
            // 
            this.tsLblSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblSteelGrade.Name = "tsLblSteelGrade";
            this.tsLblSteelGrade.Size = new System.Drawing.Size(39, 22);
            this.tsLblSteelGrade.Text = "钢 种:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvIronInfo);
            this.groupBox2.Controls.Add(this.bdN1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1183, 238);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "铁水进站样报警显示";
            // 
            // dvIronInfo
            // 
            this.dvIronInfo.AllowUserToAddRows = false;
            this.dvIronInfo.AutoGenerateColumns = false;
            this.dvIronInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvIronInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvIronInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Production_Date,
            this.Arrival_Time,
            this.materialIDDataGridViewTextBoxColumn,
            this.bFIDDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.nameGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.sbDataGridViewTextBoxColumn,
            this.asDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn});
            this.dvIronInfo.DataSource = this.bsIronInfo;
            this.dvIronInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronInfo.Location = new System.Drawing.Point(3, 42);
            this.dvIronInfo.Name = "dvIronInfo";
            this.dvIronInfo.ReadOnly = true;
            this.dvIronInfo.RowTemplate.Height = 23;
            this.dvIronInfo.Size = new System.Drawing.Size(1177, 193);
            this.dvIronInfo.TabIndex = 0;
            this.dvIronInfo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvIronInfo_RowPostPaint);
            this.dvIronInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvIronInfo_DataError);
            // 
            // Production_Date
            // 
            this.Production_Date.DataPropertyName = "Production_Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Production_Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Production_Date.DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewColumnHeaderCell);
            this.Production_Date.EnableNull = true;
            this.Production_Date.HeaderText = "生产时间";
            this.Production_Date.Length = 0;
            this.Production_Date.Max = 0;
            this.Production_Date.MaxInputLength = 32767;
            this.Production_Date.MaxLength = 0;
            this.Production_Date.Min = 0;
            this.Production_Date.MinLength = 0;
            this.Production_Date.Name = "Production_Date";
            this.Production_Date.Precision = 0;
            this.Production_Date.ReadOnly = true;
            this.Production_Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Production_Date.ValidEable = true;
            this.Production_Date.ValidType = DataGridValid.DataGridViewValidateCellColumn.TypeEnum.Integer;
            this.Production_Date.Width = 59;
            // 
            // Arrival_Time
            // 
            this.Arrival_Time.DataPropertyName = "Arrival_Time";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Arrival_Time.DefaultCellStyle = dataGridViewCellStyle2;
            this.Arrival_Time.DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewColumnHeaderCell);
            this.Arrival_Time.EnableNull = true;
            this.Arrival_Time.HeaderText = "到达时间";
            this.Arrival_Time.Length = 0;
            this.Arrival_Time.Max = 0;
            this.Arrival_Time.MaxInputLength = 32767;
            this.Arrival_Time.MaxLength = 0;
            this.Arrival_Time.Min = 0;
            this.Arrival_Time.MinLength = 0;
            this.Arrival_Time.Name = "Arrival_Time";
            this.Arrival_Time.Precision = 0;
            this.Arrival_Time.ReadOnly = true;
            this.Arrival_Time.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Arrival_Time.ValidEable = true;
            this.Arrival_Time.ValidType = DataGridValid.DataGridViewValidateCellColumn.TypeEnum.Integer;
            this.Arrival_Time.Width = 59;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // bFIDDataGridViewTextBoxColumn
            // 
            this.bFIDDataGridViewTextBoxColumn.DataPropertyName = "BFID";
            this.bFIDDataGridViewTextBoxColumn.HeaderText = "高炉炉号";
            this.bFIDDataGridViewTextBoxColumn.Name = "bFIDDataGridViewTextBoxColumn";
            this.bFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bFIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // tAPNoDataGridViewTextBoxColumn
            // 
            this.tAPNoDataGridViewTextBoxColumn.DataPropertyName = "TAP_No";
            this.tAPNoDataGridViewTextBoxColumn.HeaderText = "铁次号";
            this.tAPNoDataGridViewTextBoxColumn.Name = "tAPNoDataGridViewTextBoxColumn";
            this.tAPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAPNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            this.tPCNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameGridViewTextBoxColumn
            // 
            this.nameGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameGridViewTextBoxColumn.HeaderText = "组号";
            this.nameGridViewTextBoxColumn.Name = "nameGridViewTextBoxColumn";
            this.nameGridViewTextBoxColumn.ReadOnly = true;
            this.nameGridViewTextBoxColumn.Width = 54;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C成份";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 60;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si成份";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 66;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn成份";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 66;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P成份";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 60;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S成份";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 60;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti成份";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 66;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn成份";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            this.snDataGridViewTextBoxColumn.Width = 66;
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb成份";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            this.sbDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbDataGridViewTextBoxColumn.Width = 66;
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As成份";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            this.asDataGridViewTextBoxColumn.ReadOnly = true;
            this.asDataGridViewTextBoxColumn.Width = 66;
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb成份";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            this.pbDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbDataGridViewTextBoxColumn.Width = 66;
            // 
            // bsIronInfo
            // 
            this.bsIronInfo.DataMember = "L3DataTable";
            this.bsIronInfo.DataSource = this.dsIronInfo;
            // 
            // dsIronInfo
            // 
            this.dsIronInfo.AutoLoad = true;
            this.dsIronInfo.AutoSubscribe = true;
            this.dsIronInfo.DataSetName = "L3DataSet";
            this.dsIronInfo.DeleteMethod = "DeleteIronData";
            this.dsIronInfo.InsertMethod = "NewIronData";
            this.dsIronInfo.L3DataAdapter = this.Adapter;
            this.dsIronInfo.LoadEvent = "Click";
            this.dsIronInfo.LoadTrigger = null;
            this.dsIronInfo.RefreshValve = 1000;
            this.dsIronInfo.SourceCommand = null;
            this.dsIronInfo.SourceCondition = "";
            this.dsIronInfo.SourceMethod = "GetUnprocessSampIrons";
            this.dsIronInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsIronInfo.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.dsIronInfo.SubscribeTarget = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag.EventIronChanged";
            this.dsIronInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronInfo});
            this.dsIronInfo.UpdateEvent = "Click";
            this.dsIronInfo.UpdateMethod = "ModifyIronData";
            this.dsIronInfo.UpdateTrigger = null;
            // 
            // schemadsIronInfo
            // 
            this.schemadsIronInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronInfoL3DataTableGUID,
            this.coldsIronInfoL3DataTableName,
            this.coldsIronInfoL3DataTableMaterialID,
            this.coldsIronInfoL3DataTableStatus,
            this.coldsIronInfoL3DataTablePosition,
            this.coldsIronInfoL3DataTableQAStatus,
            this.coldsIronInfoL3DataTableQALevel,
            this.coldsIronInfoL3DataTableOrderContractID,
            this.coldsIronInfoL3DataTableProduceContractID,
            this.coldsIronInfoL3DataTableSalesContractID,
            this.coldsIronInfoL3DataTableBFID,
            this.coldsIronInfoL3DataTableTAP_No,
            this.coldsIronInfoL3DataTableTPC_No,
            this.coldsIronInfoL3DataTableSource,
            this.coldsIronInfoL3DataTableDestination,
            this.coldsIronInfoL3DataTableProduction_Date,
            this.coldsIronInfoL3DataTableShift,
            this.coldsIronInfoL3DataTableOperator,
            this.coldsIronInfoL3DataTableNC_Confirm_Flag,
            this.coldsIronInfoL3DataTableTeam,
            this.coldsIronInfoL3DataTableResult,
            this.coldsIronInfoL3DataTableSample_Place,
            this.coldsIronInfoL3DataTableC,
            this.coldsIronInfoL3DataTableSi,
            this.coldsIronInfoL3DataTableMn,
            this.coldsIronInfoL3DataTableS,
            this.coldsIronInfoL3DataTableP,
            this.coldsIronInfoL3DataTableTi,
            this.coldsIronInfoL3DataTableSn,
            this.coldsIronInfoL3DataTableSb,
            this.coldsIronInfoL3DataTableAs,
            this.coldsIronInfoL3DataTablePb,
            this.coldsIronInfoL3DataTableGross_Weight,
            this.coldsIronInfoL3DataTableLast_Tare,
            this.coldsIronInfoL3DataTableCurr_Tare,
            this.coldsIronInfoL3DataTableNet_Weight,
            this.coldsIronInfoL3DataTableSpare_Weight,
            this.coldsIronInfoL3DataTableIronStatus,
            this.coldsIronInfoL3DataTableArrival_Time,
            this.coldsIronInfoL3DataTableFeed_Time,
            this.coldsIronInfoL3DataTableSend_Time,
            this.coldsIronInfoL3DataTableSampCode,
            this.coldsIronInfoL3DataTableIronConfirm,
            this.coldsIronInfoL3DataTableC_B,
            this.coldsIronInfoL3DataTableSi_B,
            this.coldsIronInfoL3DataTableMn_B,
            this.coldsIronInfoL3DataTableS_B,
            this.coldsIronInfoL3DataTableP_B,
            this.coldsIronInfoL3DataTableTi_B,
            this.coldsIronInfoL3DataTableSn_B,
            this.coldsIronInfoL3DataTableSb_B,
            this.coldsIronInfoL3DataTableAs_B,
            this.coldsIronInfoL3DataTablePb_B,
            this.coldsIronInfoL3DataTableGrossFlag,
            this.coldsIronInfoL3DataTableTareFlag,
            this.coldsIronInfoL3DataTableAnalysisFlag,
            this.coldsIronInfoL3DataTableOperator_B,
            this.coldsIronInfoL3DataTableDeSFlag,
            this.coldsIronInfoL3DataTableDeSType});
            this.schemadsIronInfo.TableName = "L3DataTable";
            // 
            // coldsIronInfoL3DataTableGUID
            // 
            this.coldsIronInfoL3DataTableGUID.Caption = "GUID";
            this.coldsIronInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsIronInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableName
            // 
            this.coldsIronInfoL3DataTableName.Caption = "Name";
            this.coldsIronInfoL3DataTableName.ColumnName = "Name";
            this.coldsIronInfoL3DataTableName.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMaterialID
            // 
            this.coldsIronInfoL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableStatus
            // 
            this.coldsIronInfoL3DataTableStatus.Caption = "Status";
            this.coldsIronInfoL3DataTableStatus.ColumnName = "Status";
            this.coldsIronInfoL3DataTableStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePosition
            // 
            this.coldsIronInfoL3DataTablePosition.Caption = "Position";
            this.coldsIronInfoL3DataTablePosition.ColumnName = "Position";
            this.coldsIronInfoL3DataTablePosition.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQAStatus
            // 
            this.coldsIronInfoL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQAStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQALevel
            // 
            this.coldsIronInfoL3DataTableQALevel.Caption = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQALevel.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOrderContractID
            // 
            this.coldsIronInfoL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableProduceContractID
            // 
            this.coldsIronInfoL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSalesContractID
            // 
            this.coldsIronInfoL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableBFID
            // 
            this.coldsIronInfoL3DataTableBFID.Caption = "BFID";
            this.coldsIronInfoL3DataTableBFID.ColumnName = "BFID";
            this.coldsIronInfoL3DataTableBFID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTAP_No
            // 
            this.coldsIronInfoL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsIronInfoL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsIronInfoL3DataTableTAP_No.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTPC_No
            // 
            this.coldsIronInfoL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsIronInfoL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsIronInfoL3DataTableTPC_No.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSource
            // 
            this.coldsIronInfoL3DataTableSource.Caption = "Source";
            this.coldsIronInfoL3DataTableSource.ColumnName = "Source";
            this.coldsIronInfoL3DataTableSource.DataType = typeof(int);
            this.coldsIronInfoL3DataTableSource.Namespace = "";
            // 
            // coldsIronInfoL3DataTableDestination
            // 
            this.coldsIronInfoL3DataTableDestination.Caption = "Destination";
            this.coldsIronInfoL3DataTableDestination.ColumnName = "Destination";
            this.coldsIronInfoL3DataTableDestination.DataType = typeof(int);
            this.coldsIronInfoL3DataTableDestination.Namespace = "";
            // 
            // coldsIronInfoL3DataTableProduction_Date
            // 
            this.coldsIronInfoL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsIronInfoL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsIronInfoL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsIronInfoL3DataTableShift
            // 
            this.coldsIronInfoL3DataTableShift.Caption = "Shift";
            this.coldsIronInfoL3DataTableShift.ColumnName = "Shift";
            this.coldsIronInfoL3DataTableShift.DataType = typeof(int);
            this.coldsIronInfoL3DataTableShift.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOperator
            // 
            this.coldsIronInfoL3DataTableOperator.Caption = "Operator";
            this.coldsIronInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsIronInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsIronInfoL3DataTableNC_Confirm_Flag
            // 
            this.coldsIronInfoL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsIronInfoL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsIronInfoL3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.coldsIronInfoL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTeam
            // 
            this.coldsIronInfoL3DataTableTeam.Caption = "Team";
            this.coldsIronInfoL3DataTableTeam.ColumnName = "Team";
            this.coldsIronInfoL3DataTableTeam.DataType = typeof(int);
            this.coldsIronInfoL3DataTableTeam.Namespace = "";
            // 
            // coldsIronInfoL3DataTableResult
            // 
            this.coldsIronInfoL3DataTableResult.Caption = "Result";
            this.coldsIronInfoL3DataTableResult.ColumnName = "Result";
            this.coldsIronInfoL3DataTableResult.DataType = typeof(int);
            this.coldsIronInfoL3DataTableResult.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSample_Place
            // 
            this.coldsIronInfoL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsIronInfoL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsIronInfoL3DataTableSample_Place.Namespace = "";
            // 
            // coldsIronInfoL3DataTableC
            // 
            this.coldsIronInfoL3DataTableC.Caption = "C";
            this.coldsIronInfoL3DataTableC.ColumnName = "C";
            this.coldsIronInfoL3DataTableC.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSi
            // 
            this.coldsIronInfoL3DataTableSi.Caption = "Si";
            this.coldsIronInfoL3DataTableSi.ColumnName = "Si";
            this.coldsIronInfoL3DataTableSi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMn
            // 
            this.coldsIronInfoL3DataTableMn.Caption = "Mn";
            this.coldsIronInfoL3DataTableMn.ColumnName = "Mn";
            this.coldsIronInfoL3DataTableMn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableS
            // 
            this.coldsIronInfoL3DataTableS.Caption = "S";
            this.coldsIronInfoL3DataTableS.ColumnName = "S";
            this.coldsIronInfoL3DataTableS.Namespace = "";
            // 
            // coldsIronInfoL3DataTableP
            // 
            this.coldsIronInfoL3DataTableP.Caption = "P";
            this.coldsIronInfoL3DataTableP.ColumnName = "P";
            this.coldsIronInfoL3DataTableP.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTi
            // 
            this.coldsIronInfoL3DataTableTi.Caption = "Ti";
            this.coldsIronInfoL3DataTableTi.ColumnName = "Ti";
            this.coldsIronInfoL3DataTableTi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSn
            // 
            this.coldsIronInfoL3DataTableSn.Caption = "Sn";
            this.coldsIronInfoL3DataTableSn.ColumnName = "Sn";
            this.coldsIronInfoL3DataTableSn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSb
            // 
            this.coldsIronInfoL3DataTableSb.Caption = "Sb";
            this.coldsIronInfoL3DataTableSb.ColumnName = "Sb";
            this.coldsIronInfoL3DataTableSb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableAs
            // 
            this.coldsIronInfoL3DataTableAs.Caption = "As";
            this.coldsIronInfoL3DataTableAs.ColumnName = "As";
            this.coldsIronInfoL3DataTableAs.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePb
            // 
            this.coldsIronInfoL3DataTablePb.Caption = "Pb";
            this.coldsIronInfoL3DataTablePb.ColumnName = "Pb";
            this.coldsIronInfoL3DataTablePb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableGross_Weight
            // 
            this.coldsIronInfoL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsIronInfoL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableLast_Tare
            // 
            this.coldsIronInfoL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsIronInfoL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsIronInfoL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsIronInfoL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsIronInfoL3DataTableCurr_Tare
            // 
            this.coldsIronInfoL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsIronInfoL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsIronInfoL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsIronInfoL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsIronInfoL3DataTableNet_Weight
            // 
            this.coldsIronInfoL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsIronInfoL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsIronInfoL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsIronInfoL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSpare_Weight
            // 
            this.coldsIronInfoL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsIronInfoL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsIronInfoL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsIronInfoL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronStatus
            // 
            this.coldsIronInfoL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsIronInfoL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsIronInfoL3DataTableIronStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableIronStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTableArrival_Time
            // 
            this.coldsIronInfoL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsIronInfoL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsIronInfoL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsIronInfoL3DataTableFeed_Time
            // 
            this.coldsIronInfoL3DataTableFeed_Time.Caption = "Feed_Time";
            this.coldsIronInfoL3DataTableFeed_Time.ColumnName = "Feed_Time";
            this.coldsIronInfoL3DataTableFeed_Time.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableFeed_Time.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSend_Time
            // 
            this.coldsIronInfoL3DataTableSend_Time.Caption = "Send_Time";
            this.coldsIronInfoL3DataTableSend_Time.ColumnName = "Send_Time";
            this.coldsIronInfoL3DataTableSend_Time.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableSend_Time.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSampCode
            // 
            this.coldsIronInfoL3DataTableSampCode.Caption = "SampCode";
            this.coldsIronInfoL3DataTableSampCode.ColumnName = "SampCode";
            this.coldsIronInfoL3DataTableSampCode.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronConfirm
            // 
            this.coldsIronInfoL3DataTableIronConfirm.Caption = "IronConfirm";
            this.coldsIronInfoL3DataTableIronConfirm.ColumnName = "IronConfirm";
            this.coldsIronInfoL3DataTableIronConfirm.DataType = typeof(int);
            this.coldsIronInfoL3DataTableIronConfirm.Namespace = "";
            // 
            // coldsIronInfoL3DataTableC_B
            // 
            this.coldsIronInfoL3DataTableC_B.Caption = "C_B";
            this.coldsIronInfoL3DataTableC_B.ColumnName = "C_B";
            this.coldsIronInfoL3DataTableC_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSi_B
            // 
            this.coldsIronInfoL3DataTableSi_B.Caption = "Si_B";
            this.coldsIronInfoL3DataTableSi_B.ColumnName = "Si_B";
            this.coldsIronInfoL3DataTableSi_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMn_B
            // 
            this.coldsIronInfoL3DataTableMn_B.Caption = "Mn_B";
            this.coldsIronInfoL3DataTableMn_B.ColumnName = "Mn_B";
            this.coldsIronInfoL3DataTableMn_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableS_B
            // 
            this.coldsIronInfoL3DataTableS_B.Caption = "S_B";
            this.coldsIronInfoL3DataTableS_B.ColumnName = "S_B";
            this.coldsIronInfoL3DataTableS_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableP_B
            // 
            this.coldsIronInfoL3DataTableP_B.Caption = "P_B";
            this.coldsIronInfoL3DataTableP_B.ColumnName = "P_B";
            this.coldsIronInfoL3DataTableP_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTi_B
            // 
            this.coldsIronInfoL3DataTableTi_B.Caption = "Ti_B";
            this.coldsIronInfoL3DataTableTi_B.ColumnName = "Ti_B";
            this.coldsIronInfoL3DataTableTi_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSn_B
            // 
            this.coldsIronInfoL3DataTableSn_B.Caption = "Sn_B";
            this.coldsIronInfoL3DataTableSn_B.ColumnName = "Sn_B";
            this.coldsIronInfoL3DataTableSn_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSb_B
            // 
            this.coldsIronInfoL3DataTableSb_B.Caption = "Sb_B";
            this.coldsIronInfoL3DataTableSb_B.ColumnName = "Sb_B";
            this.coldsIronInfoL3DataTableSb_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableAs_B
            // 
            this.coldsIronInfoL3DataTableAs_B.Caption = "As_B";
            this.coldsIronInfoL3DataTableAs_B.ColumnName = "As_B";
            this.coldsIronInfoL3DataTableAs_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePb_B
            // 
            this.coldsIronInfoL3DataTablePb_B.Caption = "Pb_B";
            this.coldsIronInfoL3DataTablePb_B.ColumnName = "Pb_B";
            this.coldsIronInfoL3DataTablePb_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableGrossFlag
            // 
            this.coldsIronInfoL3DataTableGrossFlag.Caption = "GrossFlag";
            this.coldsIronInfoL3DataTableGrossFlag.ColumnName = "GrossFlag";
            this.coldsIronInfoL3DataTableGrossFlag.DataType = typeof(int);
            this.coldsIronInfoL3DataTableGrossFlag.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTareFlag
            // 
            this.coldsIronInfoL3DataTableTareFlag.Caption = "TareFlag";
            this.coldsIronInfoL3DataTableTareFlag.ColumnName = "TareFlag";
            this.coldsIronInfoL3DataTableTareFlag.DataType = typeof(int);
            this.coldsIronInfoL3DataTableTareFlag.Namespace = "";
            // 
            // coldsIronInfoL3DataTableAnalysisFlag
            // 
            this.coldsIronInfoL3DataTableAnalysisFlag.Caption = "AnalysisFlag";
            this.coldsIronInfoL3DataTableAnalysisFlag.ColumnName = "AnalysisFlag";
            this.coldsIronInfoL3DataTableAnalysisFlag.DataType = typeof(int);
            this.coldsIronInfoL3DataTableAnalysisFlag.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOperator_B
            // 
            this.coldsIronInfoL3DataTableOperator_B.Caption = "Operator_B";
            this.coldsIronInfoL3DataTableOperator_B.ColumnName = "Operator_B";
            this.coldsIronInfoL3DataTableOperator_B.Namespace = "";
            // 
            // coldsIronInfoL3DataTableDeSFlag
            // 
            this.coldsIronInfoL3DataTableDeSFlag.Caption = "DeSFlag";
            this.coldsIronInfoL3DataTableDeSFlag.ColumnName = "DeSFlag";
            this.coldsIronInfoL3DataTableDeSFlag.DataType = typeof(int);
            this.coldsIronInfoL3DataTableDeSFlag.Namespace = "";
            // 
            // coldsIronInfoL3DataTableDeSType
            // 
            this.coldsIronInfoL3DataTableDeSType.Caption = "DeSType";
            this.coldsIronInfoL3DataTableDeSType.ColumnName = "DeSType";
            this.coldsIronInfoL3DataTableDeSType.DataType = typeof(int);
            this.coldsIronInfoL3DataTableDeSType.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.cmbPath,
            this.toolStripLabel3,
            this.cmbSoure,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel2,
            this.dtStart,
            this.toolStripLabel4,
            this.btnOutput,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(3, 17);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1177, 25);
            this.bdN1.TabIndex = 25;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbPath
            // 
            this.cmbPath.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPath.Items.AddRange(new object[] {
            "1-炼钢",
            "2-铸铁",
            "3-全部"});
            this.cmbPath.Name = "cmbPath";
            this.cmbPath.Size = new System.Drawing.Size(85, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "去向:";
            // 
            // cmbSoure
            // 
            this.cmbSoure.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSoure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoure.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSoure.Items.AddRange(new object[] {
            "0:高炉",
            "1:脱硫",
            "2:全部"});
            this.cmbSoure.Name = "cmbSoure";
            this.cmbSoure.Size = new System.Drawing.Size(85, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "来源:";
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(85, 22);
            this.dtEnd.Text = "2008-11-07";
            this.dtEnd.Value = new System.DateTime(2008, 11, 7, 16, 57, 32, 884);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "结束日期:";
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
            this.dtStart.Size = new System.Drawing.Size(85, 22);
            this.dtStart.Text = "2008-11-07";
            this.dtStart.Value = new System.DateTime(2008, 11, 7, 16, 57, 32, 884);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel4.Text = "开始日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(193, 22);
            this.toolStripLabel6.Text = "注: 蓝色代表超出下限，红色表示超出上限";
            // 
            // dsWeight
            // 
            this.dsWeight.AutoLoad = true;
            this.dsWeight.AutoSubscribe = false;
            this.dsWeight.DataSetName = "L3DataSet";
            this.dsWeight.DeleteMethod = "";
            this.dsWeight.InsertMethod = "";
            this.dsWeight.L3DataAdapter = this.Adapter;
            this.dsWeight.LoadEvent = "";
            this.dsWeight.LoadTrigger = null;
            this.dsWeight.RefreshValve = 1000;
            this.dsWeight.SourceCommand = null;
            this.dsWeight.SourceCondition = "";
            this.dsWeight.SourceMethod = "";
            this.dsWeight.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsWeight.SourceURI = "";
            this.dsWeight.SubscribeTarget = "";
            this.dsWeight.UpdateEvent = "";
            this.dsWeight.UpdateMethod = "";
            this.dsWeight.UpdateTrigger = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaterialID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "材料号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BFID";
            this.dataGridViewTextBoxColumn2.HeaderText = "高炉炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TAP_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "铁次号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TPC_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "罐号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "组号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn6.HeaderText = "C成份";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn7.HeaderText = "Si成份";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 66;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mn成份";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 66;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn9.HeaderText = "P成份";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn10.HeaderText = "S成份";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 60;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ti成份";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 66;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn12.HeaderText = "Sn成份";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 66;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn13.HeaderText = "Sb成份";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 66;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn14.HeaderText = "As成份";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 66;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn15.HeaderText = "Pb成份";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 66;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Sn_Min";
            this.dataGridViewTextBoxColumn16.HeaderText = "Sn最小";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 66;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Sb_Max";
            this.dataGridViewTextBoxColumn17.HeaderText = "Sb最大";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 66;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Sb_Min";
            this.dataGridViewTextBoxColumn18.HeaderText = "Sb最小";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 66;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "As_Max";
            this.dataGridViewTextBoxColumn19.HeaderText = "As最大";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 66;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "As_Min";
            this.dataGridViewTextBoxColumn20.HeaderText = "As最小";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 66;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Pb_Max";
            this.dataGridViewTextBoxColumn21.HeaderText = "Pb最大";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 66;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Pb_Min";
            this.dataGridViewTextBoxColumn22.HeaderText = "Pb最小";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 66;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "MaterialID";
            this.dataGridViewTextBoxColumn23.HeaderText = "材料号";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 66;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "BFID";
            this.dataGridViewTextBoxColumn24.HeaderText = "高炉炉号";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 78;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "TAP_No";
            this.dataGridViewTextBoxColumn25.HeaderText = "铁次号";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 66;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TPC_No";
            this.dataGridViewTextBoxColumn26.HeaderText = "罐号";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 54;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn27.HeaderText = "组号";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 54;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn28.HeaderText = "C成份";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 60;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn29.HeaderText = "Si成份";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 66;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn30.HeaderText = "Mn成份";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 66;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn31.HeaderText = "P成份";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 60;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn32.HeaderText = "S成份";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 60;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn33.HeaderText = "Ti成份";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 66;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn34.HeaderText = "Sn成份";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 66;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn35.HeaderText = "Sb成份";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 66;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn36.HeaderText = "As成份";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 66;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn37.HeaderText = "Pb成份";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 66;
            // 
            // IronWarnDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 438);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronWarnDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "铁水样成分报警显示";
            this.Text = "铁水样成分报警显示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IronWarnDisplay_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronWarnDisplay_FormClosing);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelGradeStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeStd)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsIronInfo;
        private System.Data.DataTable schemadsIronInfo;
        private System.Data.DataColumn coldsIronInfoL3DataTableGUID;
        private System.Data.DataColumn coldsIronInfoL3DataTableName;
        private System.Data.DataColumn coldsIronInfoL3DataTableMaterialID;
        private System.Data.DataColumn coldsIronInfoL3DataTableStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTablePosition;
        private System.Data.DataColumn coldsIronInfoL3DataTableQAStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTableQALevel;
        private System.Data.DataColumn coldsIronInfoL3DataTableOrderContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableProduceContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableSalesContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableBFID;
        private System.Data.DataColumn coldsIronInfoL3DataTableTAP_No;
        private System.Data.DataColumn coldsIronInfoL3DataTableTPC_No;
        private System.Data.DataColumn coldsIronInfoL3DataTableSource;
        private System.Data.DataColumn coldsIronInfoL3DataTableDestination;
        private System.Data.DataColumn coldsIronInfoL3DataTableProduction_Date;
        private System.Data.DataColumn coldsIronInfoL3DataTableShift;
        private System.Data.DataColumn coldsIronInfoL3DataTableOperator;
        private System.Data.DataColumn coldsIronInfoL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsIronInfoL3DataTableTeam;
        private System.Data.DataColumn coldsIronInfoL3DataTableResult;
        private System.Data.DataColumn coldsIronInfoL3DataTableSample_Place;
        private System.Data.DataColumn coldsIronInfoL3DataTableC;
        private System.Data.DataColumn coldsIronInfoL3DataTableSi;
        private System.Data.DataColumn coldsIronInfoL3DataTableMn;
        private System.Data.DataColumn coldsIronInfoL3DataTableS;
        private System.Data.DataColumn coldsIronInfoL3DataTableP;
        private System.Data.DataColumn coldsIronInfoL3DataTableTi;
        private System.Data.DataColumn coldsIronInfoL3DataTableSn;
        private System.Data.DataColumn coldsIronInfoL3DataTableSb;
        private System.Data.DataColumn coldsIronInfoL3DataTableAs;
        private System.Data.DataColumn coldsIronInfoL3DataTablePb;
        private System.Data.DataColumn coldsIronInfoL3DataTableGross_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableLast_Tare;
        private System.Data.DataColumn coldsIronInfoL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsIronInfoL3DataTableNet_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTableArrival_Time;
        private System.Data.DataColumn coldsIronInfoL3DataTableFeed_Time;
        private System.Data.DataColumn coldsIronInfoL3DataTableSend_Time;
        private System.Data.DataColumn coldsIronInfoL3DataTableSampCode;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronConfirm;
        private System.Data.DataColumn coldsIronInfoL3DataTableC_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableSi_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableMn_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableS_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableP_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableTi_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableSn_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableSb_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableAs_B;
        private System.Data.DataColumn coldsIronInfoL3DataTablePb_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableGrossFlag;
        private System.Data.DataColumn coldsIronInfoL3DataTableTareFlag;
        private System.Data.DataColumn coldsIronInfoL3DataTableAnalysisFlag;
        private System.Data.DataColumn coldsIronInfoL3DataTableOperator_B;
        private System.Data.DataColumn coldsIronInfoL3DataTableDeSFlag;
        private System.Data.DataColumn coldsIronInfoL3DataTableDeSType;
        private System.Windows.Forms.BindingSource bsIronInfo;
        private AppSvrHMI.L3DataSet dsWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bsSteelGradeStd;
        private AppSvrHMI.L3DataSet dsSteelGradeStd;
        private System.Data.DataTable schemadsSteelGradeStd;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableC_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableC_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSi_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSi_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableMn_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableMn_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableP_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableP_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableS_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableS_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableTi_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableTi_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSn_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSn_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSb_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableSb_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableAs_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTableAs_Min;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTablePb_Max;
        private System.Data.DataColumn coldsSteelGradeStdL3DataTablePb_Min;
        private System.Windows.Forms.DataGridView dvIronInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private DataGridValid.DataGridViewValidateCellColumn Production_Date;
        private DataGridValid.DataGridViewValidateCellColumn Arrival_Time;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbPath;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbSoure;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridView dvSteelGrade;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLblSteelGrade;
        private System.Windows.Forms.ToolStripComboBox tsCmbSteelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
    }
}