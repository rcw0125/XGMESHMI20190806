namespace UnitMag.BFMag
{
    partial class PathMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBFID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableSource = new System.Data.DataColumn();
            this.coldsMainL3DataTableDestination = new System.Data.DataColumn();
            this.coldsMainL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSendFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeam = new System.Data.DataColumn();
            this.coldsMainL3DataTableResult = new System.Data.DataColumn();
            this.coldsMainL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsMainL3DataTableC = new System.Data.DataColumn();
            this.coldsMainL3DataTableSi = new System.Data.DataColumn();
            this.coldsMainL3DataTableMn = new System.Data.DataColumn();
            this.coldsMainL3DataTableS = new System.Data.DataColumn();
            this.coldsMainL3DataTableP = new System.Data.DataColumn();
            this.coldsMainL3DataTableTi = new System.Data.DataColumn();
            this.coldsMainL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronStatus = new System.Data.DataColumn();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDegiate = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnReSendNC = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsState = new AppSvrHMI.L3DataSet();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronSource = new AppSvrHMI.L3DataSet();
            this.schemadsIronSource = new System.Data.DataTable();
            this.coldsIronSourceL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronSourceL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronDestination = new AppSvrHMI.L3DataSet();
            this.schemadsIronDestination = new System.Data.DataTable();
            this.coldsIronDestinationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronDestinationL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSendFlag = new AppSvrHMI.L3DataSet();
            this.schemadsSendFlag = new System.Data.DataTable();
            this.coldsSendFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsSendFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.resultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronResult = new AppSvrHMI.L3DataSet();
            this.schemadsIronResult = new System.Data.DataTable();
            this.coldsIronResultL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronResultL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.samplePlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currTareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spareWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronStatus = new AppSvrHMI.L3DataSet();
            this.schemadsIronStatus = new System.Data.DataTable();
            this.coldsIronStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.l3cmdReSendNC = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsState)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = true;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "GetIronsForDefineDest";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.dsMain.SubscribeTarget = "XGMESLogic\\BaseDataMag\\XGStoreArea\\S01.MaterialChanged";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = "DesignatePath";
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableMaterialID,
            this.coldsMainL3DataTableBFID,
            this.coldsMainL3DataTableTAP_No,
            this.coldsMainL3DataTableTPC_No,
            this.coldsMainL3DataTableSource,
            this.coldsMainL3DataTableDestination,
            this.coldsMainL3DataTableProduction_Date,
            this.coldsMainL3DataTableShift,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableSendFlag,
            this.coldsMainL3DataTableTeam,
            this.coldsMainL3DataTableResult,
            this.coldsMainL3DataTableSample_Place,
            this.coldsMainL3DataTableC,
            this.coldsMainL3DataTableSi,
            this.coldsMainL3DataTableMn,
            this.coldsMainL3DataTableS,
            this.coldsMainL3DataTableP,
            this.coldsMainL3DataTableTi,
            this.coldsMainL3DataTableGross_Weight,
            this.coldsMainL3DataTableLast_Tare,
            this.coldsMainL3DataTableCurr_Tare,
            this.coldsMainL3DataTableNet_Weight,
            this.coldsMainL3DataTableSpare_Weight,
            this.coldsMainL3DataTableIronStatus});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableMaterialID
            // 
            this.coldsMainL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsMainL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsMainL3DataTableMaterialID.Namespace = "";
            // 
            // coldsMainL3DataTableBFID
            // 
            this.coldsMainL3DataTableBFID.Caption = "BFID";
            this.coldsMainL3DataTableBFID.ColumnName = "BFID";
            this.coldsMainL3DataTableBFID.Namespace = "";
            // 
            // coldsMainL3DataTableTAP_No
            // 
            this.coldsMainL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsMainL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsMainL3DataTableTAP_No.Namespace = "";
            // 
            // coldsMainL3DataTableTPC_No
            // 
            this.coldsMainL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsMainL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsMainL3DataTableTPC_No.Namespace = "";
            // 
            // coldsMainL3DataTableSource
            // 
            this.coldsMainL3DataTableSource.Caption = "Source";
            this.coldsMainL3DataTableSource.ColumnName = "Source";
            this.coldsMainL3DataTableSource.DataType = typeof(int);
            this.coldsMainL3DataTableSource.Namespace = "";
            // 
            // coldsMainL3DataTableDestination
            // 
            this.coldsMainL3DataTableDestination.Caption = "Destination";
            this.coldsMainL3DataTableDestination.ColumnName = "Destination";
            this.coldsMainL3DataTableDestination.DataType = typeof(int);
            this.coldsMainL3DataTableDestination.Namespace = "";
            // 
            // coldsMainL3DataTableProduction_Date
            // 
            this.coldsMainL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsMainL3DataTableShift
            // 
            this.coldsMainL3DataTableShift.Caption = "Shift";
            this.coldsMainL3DataTableShift.ColumnName = "Shift";
            this.coldsMainL3DataTableShift.DataType = typeof(int);
            this.coldsMainL3DataTableShift.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableSendFlag
            // 
            this.coldsMainL3DataTableSendFlag.Caption = "SendFlag";
            this.coldsMainL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsMainL3DataTableSendFlag.DataType = typeof(int);
            this.coldsMainL3DataTableSendFlag.Namespace = "";
            // 
            // coldsMainL3DataTableTeam
            // 
            this.coldsMainL3DataTableTeam.Caption = "Team";
            this.coldsMainL3DataTableTeam.ColumnName = "Team";
            this.coldsMainL3DataTableTeam.DataType = typeof(int);
            this.coldsMainL3DataTableTeam.Namespace = "";
            // 
            // coldsMainL3DataTableResult
            // 
            this.coldsMainL3DataTableResult.Caption = "Result";
            this.coldsMainL3DataTableResult.ColumnName = "Result";
            this.coldsMainL3DataTableResult.DataType = typeof(int);
            this.coldsMainL3DataTableResult.Namespace = "";
            // 
            // coldsMainL3DataTableSample_Place
            // 
            this.coldsMainL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.Namespace = "";
            // 
            // coldsMainL3DataTableC
            // 
            this.coldsMainL3DataTableC.Caption = "C";
            this.coldsMainL3DataTableC.ColumnName = "C";
            this.coldsMainL3DataTableC.DataType = typeof(float);
            this.coldsMainL3DataTableC.Namespace = "";
            // 
            // coldsMainL3DataTableSi
            // 
            this.coldsMainL3DataTableSi.Caption = "Si";
            this.coldsMainL3DataTableSi.ColumnName = "Si";
            this.coldsMainL3DataTableSi.DataType = typeof(float);
            this.coldsMainL3DataTableSi.Namespace = "";
            // 
            // coldsMainL3DataTableMn
            // 
            this.coldsMainL3DataTableMn.Caption = "Mn";
            this.coldsMainL3DataTableMn.ColumnName = "Mn";
            this.coldsMainL3DataTableMn.DataType = typeof(float);
            this.coldsMainL3DataTableMn.Namespace = "";
            // 
            // coldsMainL3DataTableS
            // 
            this.coldsMainL3DataTableS.Caption = "S";
            this.coldsMainL3DataTableS.ColumnName = "S";
            this.coldsMainL3DataTableS.DataType = typeof(float);
            this.coldsMainL3DataTableS.Namespace = "";
            // 
            // coldsMainL3DataTableP
            // 
            this.coldsMainL3DataTableP.Caption = "P";
            this.coldsMainL3DataTableP.ColumnName = "P";
            this.coldsMainL3DataTableP.DataType = typeof(float);
            this.coldsMainL3DataTableP.Namespace = "";
            // 
            // coldsMainL3DataTableTi
            // 
            this.coldsMainL3DataTableTi.Caption = "Ti";
            this.coldsMainL3DataTableTi.ColumnName = "Ti";
            this.coldsMainL3DataTableTi.DataType = typeof(float);
            this.coldsMainL3DataTableTi.Namespace = "";
            // 
            // coldsMainL3DataTableGross_Weight
            // 
            this.coldsMainL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsMainL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableLast_Tare
            // 
            this.coldsMainL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableCurr_Tare
            // 
            this.coldsMainL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableNet_Weight
            // 
            this.coldsMainL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsMainL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsMainL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsMainL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableSpare_Weight
            // 
            this.coldsMainL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsMainL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableIronStatus
            // 
            this.coldsMainL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsMainL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsMainL3DataTableIronStatus.DataType = typeof(int);
            this.coldsMainL3DataTableIronStatus.Namespace = "";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnDegiate,
            this.btnCancel,
            this.btnOK,
            this.btnRefresh,
            this.btnReSendNC});
            this.tSp1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 13;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnDegiate
            // 
            this.btnDegiate.Image = ((System.Drawing.Image)(resources.GetObject("btnDegiate.Image")));
            this.btnDegiate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDegiate.Name = "btnDegiate";
            this.btnDegiate.Size = new System.Drawing.Size(92, 40);
            this.btnDegiate.Text = "指定去向";
            this.btnDegiate.Click += new System.EventHandler(this.btnDegiate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.Text = "撤销去向";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 40);
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(68, 40);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnReSendNC
            // 
            this.btnReSendNC.Image = ((System.Drawing.Image)(resources.GetObject("btnReSendNC.Image")));
            this.btnReSendNC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReSendNC.Name = "btnReSendNC";
            this.btnReSendNC.Size = new System.Drawing.Size(86, 40);
            this.btnReSendNC.Text = "重发NC";
            this.btnReSendNC.Click += new System.EventHandler(this.btnReSendNC_Click);
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
            this.toolStripLabel1});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 21;
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = true;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
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
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode_Val_Long});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Val_Long
            // 
            this.coldsShiftIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsShiftIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = true;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
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
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode_Val_Long});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Val_Long
            // 
            this.coldsTeamIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsTeamIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsState
            // 
            this.dsState.AutoLoad = true;
            this.dsState.AutoSubscribe = true;
            this.dsState.DataSetName = "L3DataSet";
            this.dsState.DeleteMethod = null;
            this.dsState.InsertMethod = null;
            this.dsState.L3DataAdapter = this.Adapter;
            this.dsState.LoadEvent = "Click";
            this.dsState.LoadTrigger = null;
            this.dsState.RefreshValve = 1000;
            this.dsState.SourceCommand = null;
            this.dsState.SourceCondition = null;
            this.dsState.SourceMethod = null;
            this.dsState.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsState.SourceURI = null;
            this.dsState.SubscribeTarget = null;
            this.dsState.UpdateEvent = "Click";
            this.dsState.UpdateMethod = null;
            this.dsState.UpdateTrigger = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 302);
            this.hmiRootPanel1.TabIndex = 22;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvM.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDDataGridViewTextBoxColumn,
            this.bFIDDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.sendFlagDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.resultDataGridViewTextBoxColumn,
            this.samplePlaceDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.lastTareDataGridViewTextBoxColumn,
            this.currTareDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.spareWeightDataGridViewTextBoxColumn,
            this.ironStatusDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsMain;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.MultiSelect = false;
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(996, 298);
            this.dvM.TabIndex = 25;
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
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
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.DataSource = this.dsIronSource;
            this.sourceDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sourceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceDataGridViewTextBoxColumn.HeaderText = "来源";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sourceDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sourceDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsIronSource
            // 
            this.dsIronSource.AutoLoad = true;
            this.dsIronSource.AutoSubscribe = true;
            this.dsIronSource.DataSetName = "L3DataSet";
            this.dsIronSource.DeleteMethod = null;
            this.dsIronSource.InsertMethod = null;
            this.dsIronSource.L3DataAdapter = this.Adapter;
            this.dsIronSource.LoadEvent = "Click";
            this.dsIronSource.LoadTrigger = null;
            this.dsIronSource.RefreshValve = 1000;
            this.dsIronSource.SourceCommand = null;
            this.dsIronSource.SourceCondition = "CODE_GROUP = \'Iron_Source\'";
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
            // schemadsIronSource
            // 
            this.schemadsIronSource.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronSourceL3DataTableCode_Des,
            this.coldsIronSourceL3DataTableCode_Val_Long});
            this.schemadsIronSource.TableName = "L3DataTable";
            // 
            // coldsIronSourceL3DataTableCode_Des
            // 
            this.coldsIronSourceL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronSourceL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronSourceL3DataTableCode_Des.Namespace = "";
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
            this.destinationDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsIronDestination
            // 
            this.dsIronDestination.AutoLoad = true;
            this.dsIronDestination.AutoSubscribe = true;
            this.dsIronDestination.DataSetName = "L3DataSet";
            this.dsIronDestination.DeleteMethod = null;
            this.dsIronDestination.InsertMethod = null;
            this.dsIronDestination.L3DataAdapter = this.Adapter;
            this.dsIronDestination.LoadEvent = "Click";
            this.dsIronDestination.LoadTrigger = null;
            this.dsIronDestination.RefreshValve = 1000;
            this.dsIronDestination.SourceCommand = null;
            this.dsIronDestination.SourceCondition = "CODE_GROUP = \'Iron_Destination\'";
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
            this.productionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "Production_Date";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作工";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // sendFlagDataGridViewTextBoxColumn
            // 
            this.sendFlagDataGridViewTextBoxColumn.DataPropertyName = "SendFlag";
            this.sendFlagDataGridViewTextBoxColumn.DataSource = this.dsSendFlag;
            this.sendFlagDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sendFlagDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sendFlagDataGridViewTextBoxColumn.HeaderText = "发送标志";
            this.sendFlagDataGridViewTextBoxColumn.Name = "sendFlagDataGridViewTextBoxColumn";
            this.sendFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.sendFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sendFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sendFlagDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sendFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSendFlag
            // 
            this.dsSendFlag.AutoLoad = true;
            this.dsSendFlag.AutoSubscribe = true;
            this.dsSendFlag.DataSetName = "L3DataSet";
            this.dsSendFlag.DeleteMethod = null;
            this.dsSendFlag.InsertMethod = null;
            this.dsSendFlag.L3DataAdapter = this.Adapter;
            this.dsSendFlag.LoadEvent = "Click";
            this.dsSendFlag.LoadTrigger = null;
            this.dsSendFlag.RefreshValve = 1000;
            this.dsSendFlag.SourceCommand = null;
            this.dsSendFlag.SourceCondition = "CODE_GROUP = \'SendFlag\'";
            this.dsSendFlag.SourceMethod = "";
            this.dsSendFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSendFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSendFlag.SubscribeTarget = null;
            this.dsSendFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSendFlag});
            this.dsSendFlag.UpdateEvent = "Click";
            this.dsSendFlag.UpdateMethod = null;
            this.dsSendFlag.UpdateTrigger = null;
            // 
            // schemadsSendFlag
            // 
            this.schemadsSendFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSendFlagL3DataTableCode_Des,
            this.coldsSendFlagL3DataTableCode_Val_Long});
            this.schemadsSendFlag.TableName = "L3DataTable";
            // 
            // coldsSendFlagL3DataTableCode_Des
            // 
            this.coldsSendFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSendFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSendFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsSendFlagL3DataTableCode_Val_Long
            // 
            this.coldsSendFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsSendFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsSendFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsSendFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // resultDataGridViewTextBoxColumn
            // 
            this.resultDataGridViewTextBoxColumn.DataPropertyName = "Result";
            this.resultDataGridViewTextBoxColumn.DataSource = this.dsIronResult;
            this.resultDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.resultDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.resultDataGridViewTextBoxColumn.HeaderText = "结果";
            this.resultDataGridViewTextBoxColumn.Name = "resultDataGridViewTextBoxColumn";
            this.resultDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.resultDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.resultDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsIronResult
            // 
            this.dsIronResult.AutoLoad = true;
            this.dsIronResult.AutoSubscribe = true;
            this.dsIronResult.DataSetName = "L3DataSet";
            this.dsIronResult.DeleteMethod = null;
            this.dsIronResult.InsertMethod = null;
            this.dsIronResult.L3DataAdapter = this.Adapter;
            this.dsIronResult.LoadEvent = "Click";
            this.dsIronResult.LoadTrigger = null;
            this.dsIronResult.RefreshValve = 1000;
            this.dsIronResult.SourceCommand = null;
            this.dsIronResult.SourceCondition = "CODE_GROUP = \'Iron_Result\'";
            this.dsIronResult.SourceMethod = "";
            this.dsIronResult.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronResult.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronResult.SubscribeTarget = null;
            this.dsIronResult.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronResult});
            this.dsIronResult.UpdateEvent = "Click";
            this.dsIronResult.UpdateMethod = null;
            this.dsIronResult.UpdateTrigger = null;
            // 
            // schemadsIronResult
            // 
            this.schemadsIronResult.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronResultL3DataTableCode_Des,
            this.coldsIronResultL3DataTableCode_Val_Long});
            this.schemadsIronResult.TableName = "L3DataTable";
            // 
            // coldsIronResultL3DataTableCode_Des
            // 
            this.coldsIronResultL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronResultL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronResultL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronResultL3DataTableCode_Val_Long
            // 
            this.coldsIronResultL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronResultL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronResultL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronResultL3DataTableCode_Val_Long.Namespace = "";
            // 
            // samplePlaceDataGridViewTextBoxColumn
            // 
            this.samplePlaceDataGridViewTextBoxColumn.DataPropertyName = "Sample_Place";
            this.samplePlaceDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.samplePlaceDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.samplePlaceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.samplePlaceDataGridViewTextBoxColumn.HeaderText = "采样地点";
            this.samplePlaceDataGridViewTextBoxColumn.Name = "samplePlaceDataGridViewTextBoxColumn";
            this.samplePlaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.samplePlaceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.samplePlaceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.samplePlaceDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.samplePlaceDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = true;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "Code_Group = \'QA_Sample_Addr\'";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // lastTareDataGridViewTextBoxColumn
            // 
            this.lastTareDataGridViewTextBoxColumn.DataPropertyName = "Last_Tare";
            this.lastTareDataGridViewTextBoxColumn.HeaderText = "上次皮重";
            this.lastTareDataGridViewTextBoxColumn.Name = "lastTareDataGridViewTextBoxColumn";
            this.lastTareDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastTareDataGridViewTextBoxColumn.Width = 78;
            // 
            // currTareDataGridViewTextBoxColumn
            // 
            this.currTareDataGridViewTextBoxColumn.DataPropertyName = "Curr_Tare";
            this.currTareDataGridViewTextBoxColumn.HeaderText = "当前皮重";
            this.currTareDataGridViewTextBoxColumn.Name = "currTareDataGridViewTextBoxColumn";
            this.currTareDataGridViewTextBoxColumn.ReadOnly = true;
            this.currTareDataGridViewTextBoxColumn.Width = 78;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "净重";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // spareWeightDataGridViewTextBoxColumn
            // 
            this.spareWeightDataGridViewTextBoxColumn.DataPropertyName = "Spare_Weight";
            this.spareWeightDataGridViewTextBoxColumn.HeaderText = "剩余重量";
            this.spareWeightDataGridViewTextBoxColumn.Name = "spareWeightDataGridViewTextBoxColumn";
            this.spareWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.spareWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // ironStatusDataGridViewTextBoxColumn
            // 
            this.ironStatusDataGridViewTextBoxColumn.DataPropertyName = "IronStatus";
            this.ironStatusDataGridViewTextBoxColumn.DataSource = this.dsIronStatus;
            this.ironStatusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.ironStatusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ironStatusDataGridViewTextBoxColumn.HeaderText = "铁水状态";
            this.ironStatusDataGridViewTextBoxColumn.Name = "ironStatusDataGridViewTextBoxColumn";
            this.ironStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.ironStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ironStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ironStatusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.ironStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsIronStatus
            // 
            this.dsIronStatus.AutoLoad = true;
            this.dsIronStatus.AutoSubscribe = true;
            this.dsIronStatus.DataSetName = "L3DataSet";
            this.dsIronStatus.DeleteMethod = null;
            this.dsIronStatus.InsertMethod = null;
            this.dsIronStatus.L3DataAdapter = this.Adapter;
            this.dsIronStatus.LoadEvent = "Click";
            this.dsIronStatus.LoadTrigger = null;
            this.dsIronStatus.RefreshValve = 1000;
            this.dsIronStatus.SourceCommand = null;
            this.dsIronStatus.SourceCondition = "CODE_GROUP = \'Iron_Status\'";
            this.dsIronStatus.SourceMethod = "";
            this.dsIronStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronStatus.SubscribeTarget = null;
            this.dsIronStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronStatus});
            this.dsIronStatus.UpdateEvent = "Click";
            this.dsIronStatus.UpdateMethod = null;
            this.dsIronStatus.UpdateTrigger = null;
            // 
            // schemadsIronStatus
            // 
            this.schemadsIronStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronStatusL3DataTableCode_Des,
            this.coldsIronStatusL3DataTableCode_Val_Long});
            this.schemadsIronStatus.TableName = "L3DataTable";
            // 
            // coldsIronStatusL3DataTableCode_Des
            // 
            this.coldsIronStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronStatusL3DataTableCode_Val_Long
            // 
            this.coldsIronStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // l3cmdReSendNC
            // 
            this.l3cmdReSendNC.Adapter = this.Adapter;
            this.l3cmdReSendNC.MergeReturnTarget = false;
            this.l3cmdReSendNC.Method = "SendCastIronToNC";
            this.l3cmdReSendNC.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.l3cmdReSendNC.Parameters.Add(this.l3CommandParameter1);
            this.l3cmdReSendNC.ReturnTarget = null;
            this.l3cmdReSendNC.ReturnTargetProperty = null;
            this.l3cmdReSendNC.Trigger = null;
            this.l3cmdReSendNC.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // PathMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 370);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathMagFrm";
            this.TabText = "铁水去向管理";
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsState)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSendFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSendFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDegiate;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsState;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Data.DataTable schemadsMain;
        private System.Windows.Forms.ToolStripButton btnReSendNC;
        private AppSvrHMI.L3Command l3cmdReSendNC;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsMainL3DataTableMaterialID;
        private System.Data.DataColumn coldsMainL3DataTableBFID;
        private System.Data.DataColumn coldsMainL3DataTableTAP_No;
        private System.Data.DataColumn coldsMainL3DataTableTPC_No;
        private System.Data.DataColumn coldsMainL3DataTableSource;
        private System.Data.DataColumn coldsMainL3DataTableDestination;
        private System.Data.DataColumn coldsMainL3DataTableProduction_Date;
        private System.Data.DataColumn coldsMainL3DataTableShift;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableSendFlag;
        private System.Data.DataColumn coldsMainL3DataTableTeam;
        private System.Data.DataColumn coldsMainL3DataTableResult;
        private System.Data.DataColumn coldsMainL3DataTableSample_Place;
        private System.Data.DataColumn coldsMainL3DataTableC;
        private System.Data.DataColumn coldsMainL3DataTableSi;
        private System.Data.DataColumn coldsMainL3DataTableMn;
        private System.Data.DataColumn coldsMainL3DataTableS;
        private System.Data.DataColumn coldsMainL3DataTableP;
        private System.Data.DataColumn coldsMainL3DataTableTi;
        private System.Data.DataColumn coldsMainL3DataTableGross_Weight;
        private System.Data.DataColumn coldsMainL3DataTableLast_Tare;
        private System.Data.DataColumn coldsMainL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsMainL3DataTableNet_Weight;
        private System.Data.DataColumn coldsMainL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsMainL3DataTableIronStatus;
        private AppSvrHMI.L3DataSet dsIronSource;
        private System.Data.DataTable schemadsIronSource;
        private System.Data.DataColumn coldsIronSourceL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronSourceL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIronDestination;
        private System.Data.DataTable schemadsIronDestination;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronDestinationL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSendFlag;
        private System.Data.DataTable schemadsSendFlag;
        private System.Data.DataColumn coldsSendFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsSendFlagL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsIronResult;
        private System.Data.DataTable schemadsIronResult;
        private System.Data.DataColumn coldsIronResultL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronResultL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsIronStatus;
        private System.Data.DataTable schemadsIronStatus;
        private System.Data.DataColumn coldsIronStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronStatusL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sendFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn resultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn samplePlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currTareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spareWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ironStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnOK;
    }
}