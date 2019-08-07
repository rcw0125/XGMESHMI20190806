namespace UnitMag.MIFMag
{
    partial class IronBackQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronBackQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBFIron = new System.Windows.Forms.DataGridView();
            this.bFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronSource = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsIronSource = new System.Data.DataTable();
            this.coldsIronSourceL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsIronSourceL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronDestination = new AppSvrHMI.L3DataSet();
            this.schemadsIronDestination = new System.Data.DataTable();
            this.coldsIronDestinationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronDestinationL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currTareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backTeamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.backShiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.backTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBFIron = new System.Windows.Forms.BindingSource(this.components);
            this.dsBFIron = new AppSvrHMI.L3DataSet();
            this.schemadsBFIron = new System.Data.DataTable();
            this.coldsBFIronL3DataTableBFID = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSource = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableDestination = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableC = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSi = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableMn = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableS = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableP = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableTi = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableIronStatus = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableFeed_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSend_Time = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableSampCode = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableBack_Operator = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableBack_Team = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableBack_Shift = new System.Data.DataColumn();
            this.coldsBFIronL3DataTableBack_Time = new System.Data.DataColumn();
            this.bndsInnerFire = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBFIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).BeginInit();
            this.bndsInnerFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBFIron);
            this.hmiRootPanel1.Controls.Add(this.bndsInnerFire);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1241, 523);
            this.hmiRootPanel1.TabIndex = 23;
            // 
            // dvBFIron
            // 
            this.dvBFIron.AllowUserToAddRows = false;
            this.dvBFIron.AutoGenerateColumns = false;
            this.dvBFIron.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBFIron.ColumnHeadersHeight = 20;
            this.dvBFIron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bFIDDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.currTareDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.spareWeightDataGridViewTextBoxColumn,
            this.backOperatorDataGridViewTextBoxColumn,
            this.backTeamDataGridViewTextBoxColumn,
            this.backShiftDataGridViewTextBoxColumn,
            this.backTimeDataGridViewTextBoxColumn});
            this.dvBFIron.DataSource = this.bsBFIron;
            this.dvBFIron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBFIron.Location = new System.Drawing.Point(0, 25);
            this.dvBFIron.Name = "dvBFIron";
            this.dvBFIron.ReadOnly = true;
            this.dvBFIron.RowTemplate.Height = 23;
            this.dvBFIron.Size = new System.Drawing.Size(1241, 498);
            this.dvBFIron.TabIndex = 2;
            this.dvBFIron.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBFIron_DataError);
            // 
            // bFIDDataGridViewTextBoxColumn
            // 
            this.bFIDDataGridViewTextBoxColumn.DataPropertyName = "BFID";
            this.bFIDDataGridViewTextBoxColumn.Frozen = true;
            this.bFIDDataGridViewTextBoxColumn.HeaderText = "高炉炉号";
            this.bFIDDataGridViewTextBoxColumn.Name = "bFIDDataGridViewTextBoxColumn";
            this.bFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bFIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // tAPNoDataGridViewTextBoxColumn
            // 
            this.tAPNoDataGridViewTextBoxColumn.DataPropertyName = "TAP_No";
            this.tAPNoDataGridViewTextBoxColumn.Frozen = true;
            this.tAPNoDataGridViewTextBoxColumn.HeaderText = "铁次号";
            this.tAPNoDataGridViewTextBoxColumn.Name = "tAPNoDataGridViewTextBoxColumn";
            this.tAPNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.Frozen = true;
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            this.tPCNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCNoDataGridViewTextBoxColumn.Width = 60;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.DataSource = this.dsIronSource;
            this.sourceDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.sourceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceDataGridViewTextBoxColumn.HeaderText = "铁水来源";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sourceDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsIronSource
            // 
            this.dsIronSource.AutoLoad = true;
            this.dsIronSource.AutoSubscribe = false;
            this.dsIronSource.DataSetName = "L3DataSet";
            this.dsIronSource.DeleteMethod = null;
            this.dsIronSource.InsertMethod = null;
            this.dsIronSource.L3DataAdapter = this.Adapter;
            this.dsIronSource.LoadEvent = "Click";
            this.dsIronSource.LoadTrigger = null;
            this.dsIronSource.RefreshValve = 1000;
            this.dsIronSource.SourceCommand = null;
            this.dsIronSource.SourceCondition = "CODE_GROUP = \'Iron_Source\' and Code_Des is not null";
            this.dsIronSource.SourceMethod = "";
            this.dsIronSource.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronSource.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronSource.SubscribeTarget = null;
            this.dsIronSource.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronSource});
            this.dsIronSource.UpdateEvent = "Click";
            this.dsIronSource.UpdateMethod = null;
            this.dsIronSource.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsIronSource
            // 
            this.schemadsIronSource.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronSourceL3DataTablecode_des,
            this.coldsIronSourceL3DataTableCode_Val_Long});
            this.schemadsIronSource.TableName = "L3DataTable";
            // 
            // coldsIronSourceL3DataTablecode_des
            // 
            this.coldsIronSourceL3DataTablecode_des.Caption = "code_des";
            this.coldsIronSourceL3DataTablecode_des.ColumnName = "code_des";
            this.coldsIronSourceL3DataTablecode_des.Namespace = "";
            // 
            // coldsIronSourceL3DataTableCode_Val_Long
            // 
            this.coldsIronSourceL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronSourceL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronSourceL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronSourceL3DataTableCode_Val_Long.Namespace = "";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.DataSource = this.dsIronDestination;
            this.destinationDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.destinationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.destinationDataGridViewTextBoxColumn.HeaderText = "去向";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destinationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.destinationDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsIronDestination
            // 
            this.dsIronDestination.AutoLoad = true;
            this.dsIronDestination.AutoSubscribe = false;
            this.dsIronDestination.DataSetName = "L3DataSet";
            this.dsIronDestination.DeleteMethod = null;
            this.dsIronDestination.InsertMethod = null;
            this.dsIronDestination.L3DataAdapter = this.Adapter;
            this.dsIronDestination.LoadEvent = "Click";
            this.dsIronDestination.LoadTrigger = null;
            this.dsIronDestination.RefreshValve = 1000;
            this.dsIronDestination.SourceCommand = null;
            this.dsIronDestination.SourceCondition = "CODE_GROUP = \'Iron_Destination\' and Code_Des is not null";
            this.dsIronDestination.SourceMethod = "";
            this.dsIronDestination.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronDestination.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronDestination.SubscribeTarget = null;
            this.dsIronDestination.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronDestination});
            this.dsIronDestination.UpdateEvent = "Click";
            this.dsIronDestination.UpdateMethod = null;
            this.dsIronDestination.UpdateTrigger = null;
            // 
            // schemadsIronDestination
            // 
            this.schemadsIronDestination.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronDestinationL3DataTableCode_Des,
            this.coldsIronDestinationL3DataTableCode_Val_Long});
            this.schemadsIronDestination.TableName = "L3DataTable";
            // 
            // coldsIronDestinationL3DataTableCode_Des
            // 
            this.coldsIronDestinationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronDestinationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronDestinationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronDestinationL3DataTableCode_Val_Long
            // 
            this.coldsIronDestinationL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronDestinationL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronDestinationL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronDestinationL3DataTableCode_Val_Long.Namespace = "";
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 60;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 60;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 60;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 60;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 60;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 60;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            dataGridViewCellStyle1.Format = "N2";
            this.grossWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重[t]";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossWeightDataGridViewTextBoxColumn.Width = 80;
            // 
            // currTareDataGridViewTextBoxColumn
            // 
            this.currTareDataGridViewTextBoxColumn.DataPropertyName = "Curr_Tare";
            dataGridViewCellStyle2.Format = "N2";
            this.currTareDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.currTareDataGridViewTextBoxColumn.HeaderText = "皮重[t]";
            this.currTareDataGridViewTextBoxColumn.Name = "currTareDataGridViewTextBoxColumn";
            this.currTareDataGridViewTextBoxColumn.ReadOnly = true;
            this.currTareDataGridViewTextBoxColumn.Width = 80;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            dataGridViewCellStyle3.Format = "N2";
            this.netWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "净重[t]";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWeightDataGridViewTextBoxColumn.Width = 80;
            // 
            // spareWeightDataGridViewTextBoxColumn
            // 
            this.spareWeightDataGridViewTextBoxColumn.DataPropertyName = "Spare_Weight";
            dataGridViewCellStyle4.Format = "N2";
            this.spareWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.spareWeightDataGridViewTextBoxColumn.HeaderText = "剩余重量[t]";
            this.spareWeightDataGridViewTextBoxColumn.Name = "spareWeightDataGridViewTextBoxColumn";
            this.spareWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.spareWeightDataGridViewTextBoxColumn.Width = 80;
            // 
            // backOperatorDataGridViewTextBoxColumn
            // 
            this.backOperatorDataGridViewTextBoxColumn.DataPropertyName = "Back_Operator";
            this.backOperatorDataGridViewTextBoxColumn.HeaderText = "回退操作员";
            this.backOperatorDataGridViewTextBoxColumn.Name = "backOperatorDataGridViewTextBoxColumn";
            this.backOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.backOperatorDataGridViewTextBoxColumn.Width = 120;
            // 
            // backTeamDataGridViewTextBoxColumn
            // 
            this.backTeamDataGridViewTextBoxColumn.DataPropertyName = "Back_Team";
            this.backTeamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.backTeamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.backTeamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.backTeamDataGridViewTextBoxColumn.HeaderText = "回退班别";
            this.backTeamDataGridViewTextBoxColumn.Name = "backTeamDataGridViewTextBoxColumn";
            this.backTeamDataGridViewTextBoxColumn.ReadOnly = true;
            this.backTeamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.backTeamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.backTeamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\' and Code_Des is not null";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // backShiftDataGridViewTextBoxColumn
            // 
            this.backShiftDataGridViewTextBoxColumn.DataPropertyName = "Back_Shift";
            this.backShiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.backShiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.backShiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.backShiftDataGridViewTextBoxColumn.HeaderText = "回退班次";
            this.backShiftDataGridViewTextBoxColumn.Name = "backShiftDataGridViewTextBoxColumn";
            this.backShiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.backShiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.backShiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.backShiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\' and Code_Des is not null";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // backTimeDataGridViewTextBoxColumn
            // 
            this.backTimeDataGridViewTextBoxColumn.DataPropertyName = "Back_Time";
            this.backTimeDataGridViewTextBoxColumn.HeaderText = "回退时间";
            this.backTimeDataGridViewTextBoxColumn.Name = "backTimeDataGridViewTextBoxColumn";
            this.backTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBFIron
            // 
            this.bsBFIron.DataMember = "L3DataTable";
            this.bsBFIron.DataSource = this.dsBFIron;
            // 
            // dsBFIron
            // 
            this.dsBFIron.AutoLoad = true;
            this.dsBFIron.AutoSubscribe = false;
            this.dsBFIron.DataSetName = "L3DataSet";
            this.dsBFIron.DeleteMethod = null;
            this.dsBFIron.InsertMethod = null;
            this.dsBFIron.L3DataAdapter = this.Adapter;
            this.dsBFIron.LoadEvent = "Click";
            this.dsBFIron.LoadTrigger = null;
            this.dsBFIron.RefreshValve = 1000;
            this.dsBFIron.SourceCommand = null;
            this.dsBFIron.SourceCondition = "1=2";
            this.dsBFIron.SourceMethod = "";
            this.dsBFIron.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBFIron.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Back_Log";
            this.dsBFIron.SubscribeTarget = null;
            this.dsBFIron.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBFIron});
            this.dsBFIron.UpdateEvent = "Click";
            this.dsBFIron.UpdateMethod = null;
            this.dsBFIron.UpdateTrigger = null;
            // 
            // schemadsBFIron
            // 
            this.schemadsBFIron.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBFIronL3DataTableBFID,
            this.coldsBFIronL3DataTableTAP_No,
            this.coldsBFIronL3DataTableTPC_No,
            this.coldsBFIronL3DataTableSource,
            this.coldsBFIronL3DataTableDestination,
            this.coldsBFIronL3DataTableProduction_Date,
            this.coldsBFIronL3DataTableC,
            this.coldsBFIronL3DataTableSi,
            this.coldsBFIronL3DataTableMn,
            this.coldsBFIronL3DataTableS,
            this.coldsBFIronL3DataTableP,
            this.coldsBFIronL3DataTableTi,
            this.coldsBFIronL3DataTableGross_Weight,
            this.coldsBFIronL3DataTableLast_Tare,
            this.coldsBFIronL3DataTableCurr_Tare,
            this.coldsBFIronL3DataTableNet_Weight,
            this.coldsBFIronL3DataTableSpare_Weight,
            this.coldsBFIronL3DataTableIronStatus,
            this.coldsBFIronL3DataTableArrival_Time,
            this.coldsBFIronL3DataTableFeed_Time,
            this.coldsBFIronL3DataTableSend_Time,
            this.coldsBFIronL3DataTableNC_Confirm_Flag,
            this.coldsBFIronL3DataTableSampCode,
            this.coldsBFIronL3DataTableBack_Operator,
            this.coldsBFIronL3DataTableBack_Team,
            this.coldsBFIronL3DataTableBack_Shift,
            this.coldsBFIronL3DataTableBack_Time});
            this.schemadsBFIron.TableName = "L3DataTable";
            // 
            // coldsBFIronL3DataTableBFID
            // 
            this.coldsBFIronL3DataTableBFID.Caption = "BFID";
            this.coldsBFIronL3DataTableBFID.ColumnName = "BFID";
            this.coldsBFIronL3DataTableBFID.Namespace = "";
            // 
            // coldsBFIronL3DataTableTAP_No
            // 
            this.coldsBFIronL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsBFIronL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsBFIronL3DataTableTAP_No.Namespace = "";
            // 
            // coldsBFIronL3DataTableTPC_No
            // 
            this.coldsBFIronL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsBFIronL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsBFIronL3DataTableTPC_No.Namespace = "";
            // 
            // coldsBFIronL3DataTableSource
            // 
            this.coldsBFIronL3DataTableSource.Caption = "Source";
            this.coldsBFIronL3DataTableSource.ColumnName = "Source";
            this.coldsBFIronL3DataTableSource.DataType = typeof(int);
            this.coldsBFIronL3DataTableSource.Namespace = "";
            // 
            // coldsBFIronL3DataTableDestination
            // 
            this.coldsBFIronL3DataTableDestination.Caption = "Destination";
            this.coldsBFIronL3DataTableDestination.ColumnName = "Destination";
            this.coldsBFIronL3DataTableDestination.DataType = typeof(int);
            this.coldsBFIronL3DataTableDestination.Namespace = "";
            // 
            // coldsBFIronL3DataTableProduction_Date
            // 
            this.coldsBFIronL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsBFIronL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsBFIronL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsBFIronL3DataTableC
            // 
            this.coldsBFIronL3DataTableC.Caption = "C";
            this.coldsBFIronL3DataTableC.ColumnName = "C";
            this.coldsBFIronL3DataTableC.Namespace = "";
            // 
            // coldsBFIronL3DataTableSi
            // 
            this.coldsBFIronL3DataTableSi.Caption = "Si";
            this.coldsBFIronL3DataTableSi.ColumnName = "Si";
            this.coldsBFIronL3DataTableSi.Namespace = "";
            // 
            // coldsBFIronL3DataTableMn
            // 
            this.coldsBFIronL3DataTableMn.Caption = "Mn";
            this.coldsBFIronL3DataTableMn.ColumnName = "Mn";
            this.coldsBFIronL3DataTableMn.Namespace = "";
            // 
            // coldsBFIronL3DataTableS
            // 
            this.coldsBFIronL3DataTableS.Caption = "S";
            this.coldsBFIronL3DataTableS.ColumnName = "S";
            this.coldsBFIronL3DataTableS.Namespace = "";
            // 
            // coldsBFIronL3DataTableP
            // 
            this.coldsBFIronL3DataTableP.Caption = "P";
            this.coldsBFIronL3DataTableP.ColumnName = "P";
            this.coldsBFIronL3DataTableP.Namespace = "";
            // 
            // coldsBFIronL3DataTableTi
            // 
            this.coldsBFIronL3DataTableTi.Caption = "Ti";
            this.coldsBFIronL3DataTableTi.ColumnName = "Ti";
            this.coldsBFIronL3DataTableTi.Namespace = "";
            // 
            // coldsBFIronL3DataTableGross_Weight
            // 
            this.coldsBFIronL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsBFIronL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsBFIronL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsBFIronL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableLast_Tare
            // 
            this.coldsBFIronL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsBFIronL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsBFIronL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsBFIronL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsBFIronL3DataTableCurr_Tare
            // 
            this.coldsBFIronL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsBFIronL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsBFIronL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsBFIronL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsBFIronL3DataTableNet_Weight
            // 
            this.coldsBFIronL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsBFIronL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsBFIronL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsBFIronL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableSpare_Weight
            // 
            this.coldsBFIronL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsBFIronL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsBFIronL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsBFIronL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsBFIronL3DataTableIronStatus
            // 
            this.coldsBFIronL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsBFIronL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsBFIronL3DataTableIronStatus.DataType = typeof(int);
            this.coldsBFIronL3DataTableIronStatus.Namespace = "";
            // 
            // coldsBFIronL3DataTableArrival_Time
            // 
            this.coldsBFIronL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsBFIronL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsBFIronL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableFeed_Time
            // 
            this.coldsBFIronL3DataTableFeed_Time.Caption = "Feed_Time";
            this.coldsBFIronL3DataTableFeed_Time.ColumnName = "Feed_Time";
            this.coldsBFIronL3DataTableFeed_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableFeed_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableSend_Time
            // 
            this.coldsBFIronL3DataTableSend_Time.Caption = "Send_Time";
            this.coldsBFIronL3DataTableSend_Time.ColumnName = "Send_Time";
            this.coldsBFIronL3DataTableSend_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableSend_Time.Namespace = "";
            // 
            // coldsBFIronL3DataTableNC_Confirm_Flag
            // 
            this.coldsBFIronL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsBFIronL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsBFIronL3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.coldsBFIronL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsBFIronL3DataTableSampCode
            // 
            this.coldsBFIronL3DataTableSampCode.Caption = "SampCode";
            this.coldsBFIronL3DataTableSampCode.ColumnName = "SampCode";
            this.coldsBFIronL3DataTableSampCode.Namespace = "";
            // 
            // coldsBFIronL3DataTableBack_Operator
            // 
            this.coldsBFIronL3DataTableBack_Operator.Caption = "Back_Operator";
            this.coldsBFIronL3DataTableBack_Operator.ColumnName = "Back_Operator";
            this.coldsBFIronL3DataTableBack_Operator.Namespace = "";
            // 
            // coldsBFIronL3DataTableBack_Team
            // 
            this.coldsBFIronL3DataTableBack_Team.Caption = "Back_Team";
            this.coldsBFIronL3DataTableBack_Team.ColumnName = "Back_Team";
            this.coldsBFIronL3DataTableBack_Team.Namespace = "";
            // 
            // coldsBFIronL3DataTableBack_Shift
            // 
            this.coldsBFIronL3DataTableBack_Shift.Caption = "Back_Shift";
            this.coldsBFIronL3DataTableBack_Shift.ColumnName = "Back_Shift";
            this.coldsBFIronL3DataTableBack_Shift.Namespace = "";
            // 
            // coldsBFIronL3DataTableBack_Time
            // 
            this.coldsBFIronL3DataTableBack_Time.Caption = "Back_Time";
            this.coldsBFIronL3DataTableBack_Time.ColumnName = "Back_Time";
            this.coldsBFIronL3DataTableBack_Time.DataType = typeof(System.DateTime);
            this.coldsBFIronL3DataTableBack_Time.Namespace = "";
            // 
            // bndsInnerFire
            // 
            this.bndsInnerFire.AddNewItem = null;
            this.bndsInnerFire.AutoSize = false;
            this.bndsInnerFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bndsInnerFire.BackgroundImage")));
            this.bndsInnerFire.BindingSource = this.bsBFIron;
            this.bndsInnerFire.CountItem = this.toolStripLabel1;
            this.bndsInnerFire.DeleteItem = null;
            this.bndsInnerFire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.btnQuery,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel5,
            this.dtStart,
            this.toolStripLabel6,
            this.btnOutput});
            this.bndsInnerFire.Location = new System.Drawing.Point(0, 0);
            this.bndsInnerFire.MoveFirstItem = this.toolStripButton1;
            this.bndsInnerFire.MoveLastItem = this.toolStripButton4;
            this.bndsInnerFire.MoveNextItem = this.toolStripButton3;
            this.bndsInnerFire.MovePreviousItem = this.toolStripButton2;
            this.bndsInnerFire.Name = "bndsInnerFire";
            this.bndsInnerFire.PositionItem = this.toolStripTextBox1;
            this.bndsInnerFire.Size = new System.Drawing.Size(1241, 25);
            this.bndsInnerFire.TabIndex = 29;
            this.bndsInnerFire.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel3.Text = "  ";
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = " ";
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
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
            this.dtEnd.Text = "2008-11-18";
            this.dtEnd.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 197);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel5.Text = "-";
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
            this.dtStart.Text = "2008-11-18";
            this.dtStart.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 147);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnBFIromOutput_Click);
            // 
            // IronBackQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 523);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "IronBackQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "铁水回退炼铁厂信息查询";
            this.Text = "铁水回退炼铁厂信息查询";
            this.Load += new System.EventHandler(this.IronBackQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBFIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).EndInit();
            this.bndsInnerFire.ResumeLayout(false);
            this.bndsInnerFire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsBFIron;
        private System.Windows.Forms.BindingSource bsBFIron;
        private System.Data.DataTable schemadsBFIron;
        private System.Data.DataColumn coldsBFIronL3DataTableBFID;
        private System.Data.DataColumn coldsBFIronL3DataTableTAP_No;
        private System.Data.DataColumn coldsBFIronL3DataTableTPC_No;
        private System.Data.DataColumn coldsBFIronL3DataTableSource;
        private System.Data.DataColumn coldsBFIronL3DataTableDestination;
        private System.Data.DataColumn coldsBFIronL3DataTableProduction_Date;
        private System.Data.DataColumn coldsBFIronL3DataTableC;
        private System.Data.DataColumn coldsBFIronL3DataTableSi;
        private System.Data.DataColumn coldsBFIronL3DataTableMn;
        private System.Data.DataColumn coldsBFIronL3DataTableS;
        private System.Data.DataColumn coldsBFIronL3DataTableP;
        private System.Data.DataColumn coldsBFIronL3DataTableTi;
        private System.Data.DataColumn coldsBFIronL3DataTableGross_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableLast_Tare;
        private System.Data.DataColumn coldsBFIronL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsBFIronL3DataTableNet_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsBFIronL3DataTableIronStatus;
        private System.Data.DataColumn coldsBFIronL3DataTableArrival_Time;
        private System.Data.DataColumn coldsBFIronL3DataTableFeed_Time;
        private System.Data.DataColumn coldsBFIronL3DataTableSend_Time;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsIronDestination;
        private System.Data.DataTable schemadsIronDestination;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIronSource;
        private System.Data.DataTable schemadsIronSource;
        private System.Data.DataColumn coldsIronSourceL3DataTablecode_des;
        private System.Data.DataColumn coldsIronSourceL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingNavigator bndsInnerFire;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Data.DataColumn coldsBFIronL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsBFIronL3DataTableSampCode;
        private System.Data.DataColumn coldsBFIronL3DataTableBack_Operator;
        private System.Data.DataColumn coldsBFIronL3DataTableBack_Team;
        private System.Data.DataColumn coldsBFIronL3DataTableBack_Shift;
        private System.Data.DataColumn coldsBFIronL3DataTableBack_Time;
        private System.Windows.Forms.DataGridView dvBFIron;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currTareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn backTeamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn backShiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backTimeDataGridViewTextBoxColumn;
    }
}