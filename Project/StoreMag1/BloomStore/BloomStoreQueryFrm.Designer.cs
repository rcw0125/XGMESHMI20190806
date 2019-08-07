namespace StoreMag.BloomStore
{
    partial class BloomStoreQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomStoreQueryFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnOutEXL = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsQuery = new System.Windows.Forms.BindingSource(this.components);
            this.dsQuery = new AppSvrHMI.L3DataSet();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.txtStoreAreaID = new System.Windows.Forms.ToolStripTextBox();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.txtMaterialID = new System.Windows.Forms.ToolStripTextBox();
            this.schemadsQuery = new System.Data.DataTable();
            this.coldsQueryL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsQueryL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsQueryL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsQueryL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQueryL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsQueryL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsQueryL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsQueryL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsQueryL3DataTableREASON = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTest_Roll_Count = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTest_Roll_Weight = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSpileFlagDes = new System.Data.DataColumn();
            this.coldsQueryL3DataTabletotalweight = new System.Data.DataColumn();
            this.coldsQueryL3DataTableback_date = new System.Data.DataColumn();
            this.coldsQueryL3DataTableback_flag = new System.Data.DataColumn();
            this.coldsQueryL3DataTableAdd_Bloom_Count = new System.Data.DataColumn();
            this.coldsQueryL3DataTableDiv_Bloom_Count = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePlan_Bloom_Count = new System.Data.DataColumn();
            this.coldsQueryL3DataTableAdd_Div_HeatID = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbStoreID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvQuery = new System.Windows.Forms.DataGridView();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsStoreAreaID = new AppSvrHMI.L3DataSet();
            this.schemadsStoreAreaID = new System.Data.DataTable();
            this.coldsStoreAreaIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsSpile = new AppSvrHMI.L3DataSet();
            this.schemadsSpile = new System.Data.DataTable();
            this.coldsSpileL3DataTableCode = new System.Data.DataColumn();
            this.coldsSpileL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsWrongReason = new AppSvrHMI.L3DataSet();
            this.schemadsWrongReason = new System.Data.DataTable();
            this.coldsWrongReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWrongReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.AcoldsQueryL3DataTableAdd_Bloom_Count = new System.Data.DataColumn();
            this.AcoldsQueryL3DataTableDiv_Bloom_Count = new System.Data.DataColumn();
            this.AcoldsQueryL3DataTablePlan_Bloom_Count = new System.Data.DataColumn();
            this.AcoldsQueryL3DataTableAdd_Div_HeatID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableADD_HEATID1 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableADD_HEATID2 = new System.Data.DataColumn();
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2 = new System.Data.DataColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qASTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpileFlagDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGHEATCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cURPILEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cURLAYERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURSEQIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURBAYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTSENDFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCESSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINISHFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINISHEDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOOMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wASTERCOUNT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wASTERCOUNT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wRONGCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wRONGCOUNT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wRONGCOUNT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Test_Roll_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Roll_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cURSECTIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_HEATID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_HEATID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_BLOOM_COUNT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Div_HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQuery)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnOutEXL});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(898, 43);
            this.tSp1.TabIndex = 30;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOutEXL
            // 
            this.btnOutEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnOutEXL.Image")));
            this.btnOutEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutEXL.Name = "btnOutEXL";
            this.btnOutEXL.Size = new System.Drawing.Size(107, 40);
            this.btnOutEXL.Text = "导出到EXCEL";
            this.btnOutEXL.Click += new System.EventHandler(this.btnOutEXL_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BindingSource = this.bsQuery;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnQuery,
            this.cmbStoreID,
            this.toolStripLabel1,
            this.txtMaterialID,
            this.toolStripLabel4,
            this.txtStoreAreaID,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(898, 25);
            this.bindingNavigator1.TabIndex = 34;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsQuery
            // 
            this.bsQuery.DataMember = "L3DataTable";
            this.bsQuery.DataSource = this.dsQuery;
            // 
            // dsQuery
            // 
            this.dsQuery.AutoLoad = true;
            this.dsQuery.AutoSubscribe = false;
            this.dsQuery.DataSetName = "L3DataSet";
            this.dsQuery.DeleteMethod = "";
            this.dsQuery.InsertMethod = "";
            this.dsQuery.L3DataAdapter = null;
            this.dsQuery.LoadEvent = "Click";
            this.dsQuery.LoadTrigger = null;
            this.dsQuery.RefreshValve = 1000;
            this.dsQuery.SourceCommand = this.cmdQuery;
            this.dsQuery.SourceCondition = null;
            this.dsQuery.SourceMethod = "GetBloomOnStoreArea";
            this.dsQuery.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsQuery.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.dsQuery.SubscribeTarget = null;
            this.dsQuery.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsQuery});
            this.dsQuery.UpdateEvent = "Click";
            this.dsQuery.UpdateMethod = "";
            this.dsQuery.UpdateTrigger = null;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = null;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "";
            this.cmdQuery.Object = "";
            this.cmdQuery.Parameters.Add(this.l3CommandParameter1);
            this.cmdQuery.Parameters.Add(this.l3CommandParameter2);
            this.cmdQuery.ReturnTarget = null;
            this.cmdQuery.ReturnTargetProperty = null;
            this.cmdQuery.Trigger = null;
            this.cmdQuery.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.txtStoreAreaID;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // txtStoreAreaID
            // 
            this.txtStoreAreaID.Name = "txtStoreAreaID";
            this.txtStoreAreaID.Size = new System.Drawing.Size(100, 25);
            this.txtStoreAreaID.Visible = false;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.txtMaterialID;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtMaterialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(100, 25);
            // 
            // schemadsQuery
            // 
            this.schemadsQuery.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsQueryL3DataTableMATERIALID,
            this.coldsQueryL3DataTableSTATUS,
            this.coldsQueryL3DataTablePOSITION,
            this.coldsQueryL3DataTableQASTATUS,
            this.coldsQueryL3DataTableQALEVEL,
            this.coldsQueryL3DataTableORDERCONTRACTID,
            this.coldsQueryL3DataTablePRODUCECONTRACTID,
            this.coldsQueryL3DataTableSALESCONTRACTID,
            this.coldsQueryL3DataTableCASTERID,
            this.coldsQueryL3DataTableCASTING_NO,
            this.coldsQueryL3DataTableCASTING_HEAT_CNT,
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX,
            this.coldsQueryL3DataTableSTEELGRADEINDEX,
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX,
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsQueryL3DataTableLENGTH,
            this.coldsQueryL3DataTableWIDTH,
            this.coldsQueryL3DataTableTHICKNESS,
            this.coldsQueryL3DataTableCUR_SECTION_ID,
            this.coldsQueryL3DataTableCUR_PILE_ID,
            this.coldsQueryL3DataTableCUR_LAYER_ID,
            this.coldsQueryL3DataTableCUR_SEQ_ID,
            this.coldsQueryL3DataTableCUR_BAY_ID,
            this.coldsQueryL3DataTableDESTINATION,
            this.coldsQueryL3DataTableHOT_SEND_FLAG,
            this.coldsQueryL3DataTablePROCESS_TYPE,
            this.coldsQueryL3DataTablePLAN_ORD_ID,
            this.coldsQueryL3DataTablePRODUCE_DATE,
            this.coldsQueryL3DataTableFINISH_FLAG,
            this.coldsQueryL3DataTableFINISHEDTIME,
            this.coldsQueryL3DataTableBLOOM_COUNT,
            this.coldsQueryL3DataTableCAL_WEIGHT,
            this.coldsQueryL3DataTableRIGHT_COUNT,
            this.coldsQueryL3DataTableRIGHT_WEIGHT,
            this.coldsQueryL3DataTableWASTER_COUNT,
            this.coldsQueryL3DataTableWASTER_WEIGHT,
            this.coldsQueryL3DataTableWASTER_COUNT1,
            this.coldsQueryL3DataTableWASTER_WEIGHT1,
            this.coldsQueryL3DataTableWASTER_REASON1,
            this.coldsQueryL3DataTableWASTER_COUNT2,
            this.coldsQueryL3DataTableWASTER_WEIGHT2,
            this.coldsQueryL3DataTableWASTER_REASON2,
            this.coldsQueryL3DataTableWASTER_COUNT3,
            this.coldsQueryL3DataTableWASTER_WEIGHT3,
            this.coldsQueryL3DataTableWASTER_REASON3,
            this.coldsQueryL3DataTableWRONG_COUNT,
            this.coldsQueryL3DataTableWRONG_WEIGHT,
            this.coldsQueryL3DataTableWRONG_COUNT1,
            this.coldsQueryL3DataTableWRONG_WEIGHT1,
            this.coldsQueryL3DataTableWRONG_REASON1,
            this.coldsQueryL3DataTableWRONG_COUNT2,
            this.coldsQueryL3DataTableWRONG_WEIGHT2,
            this.coldsQueryL3DataTableWRONG_REASON2,
            this.coldsQueryL3DataTableWRONG_COUNT3,
            this.coldsQueryL3DataTableWRONG_WEIGHT3,
            this.coldsQueryL3DataTableWRONG_REASON3,
            this.coldsQueryL3DataTableSUFACEDEFACTDES,
            this.coldsQueryL3DataTableREASON,
            this.coldsQueryL3DataTableTest_Roll_Count,
            this.coldsQueryL3DataTableTest_Roll_Weight,
            this.coldsQueryL3DataTableSpileFlagDes,
            this.coldsQueryL3DataTabletotalweight,
            this.coldsQueryL3DataTableback_date,
            this.coldsQueryL3DataTableback_flag,
            this.coldsQueryL3DataTableAdd_Bloom_Count,
            this.coldsQueryL3DataTableDiv_Bloom_Count,
            this.coldsQueryL3DataTablePlan_Bloom_Count,
            this.coldsQueryL3DataTableAdd_Div_HeatID});
            this.schemadsQuery.TableName = "L3DataTable";
            // 
            // coldsQueryL3DataTableMATERIALID
            // 
            this.coldsQueryL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsQueryL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsQueryL3DataTableMATERIALID.DefaultValue = "";
            this.coldsQueryL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsQueryL3DataTableSTATUS
            // 
            this.coldsQueryL3DataTableSTATUS.Caption = "STATUS";
            this.coldsQueryL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsQueryL3DataTableSTATUS.DataType = typeof(int);
            this.coldsQueryL3DataTableSTATUS.DefaultValue = 0;
            this.coldsQueryL3DataTableSTATUS.Namespace = "";
            // 
            // coldsQueryL3DataTablePOSITION
            // 
            this.coldsQueryL3DataTablePOSITION.Caption = "POSITION";
            this.coldsQueryL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsQueryL3DataTablePOSITION.DefaultValue = "";
            this.coldsQueryL3DataTablePOSITION.Namespace = "";
            // 
            // coldsQueryL3DataTableQASTATUS
            // 
            this.coldsQueryL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsQueryL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsQueryL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsQueryL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsQueryL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsQueryL3DataTableQALEVEL
            // 
            this.coldsQueryL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsQueryL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsQueryL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsQueryL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsQueryL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsQueryL3DataTableORDERCONTRACTID
            // 
            this.coldsQueryL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsQueryL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsQueryL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsQueryL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsQueryL3DataTablePRODUCECONTRACTID
            // 
            this.coldsQueryL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsQueryL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsQueryL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsQueryL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsQueryL3DataTableSALESCONTRACTID
            // 
            this.coldsQueryL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsQueryL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsQueryL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsQueryL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsQueryL3DataTableCASTERID
            // 
            this.coldsQueryL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsQueryL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsQueryL3DataTableCASTERID.DefaultValue = "";
            this.coldsQueryL3DataTableCASTERID.Namespace = "";
            // 
            // coldsQueryL3DataTableCASTING_NO
            // 
            this.coldsQueryL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsQueryL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsQueryL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsQueryL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsQueryL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsQueryL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsQueryL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsQueryL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsQueryL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsQueryL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsQueryL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQueryL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQueryL3DataTableSTEELGRADEINDEX
            // 
            this.coldsQueryL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsQueryL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsQueryL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsQueryL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsQueryL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQueryL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQueryL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQueryL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQueryL3DataTableLENGTH
            // 
            this.coldsQueryL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsQueryL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsQueryL3DataTableLENGTH.DataType = typeof(int);
            this.coldsQueryL3DataTableLENGTH.DefaultValue = 0;
            this.coldsQueryL3DataTableLENGTH.Namespace = "";
            // 
            // coldsQueryL3DataTableWIDTH
            // 
            this.coldsQueryL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsQueryL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsQueryL3DataTableWIDTH.DataType = typeof(int);
            this.coldsQueryL3DataTableWIDTH.DefaultValue = 0;
            this.coldsQueryL3DataTableWIDTH.Namespace = "";
            // 
            // coldsQueryL3DataTableTHICKNESS
            // 
            this.coldsQueryL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsQueryL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsQueryL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsQueryL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsQueryL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsQueryL3DataTableCUR_SECTION_ID
            // 
            this.coldsQueryL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsQueryL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsQueryL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsQueryL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsQueryL3DataTableCUR_PILE_ID
            // 
            this.coldsQueryL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsQueryL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsQueryL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsQueryL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsQueryL3DataTableCUR_LAYER_ID
            // 
            this.coldsQueryL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsQueryL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsQueryL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsQueryL3DataTableCUR_SEQ_ID
            // 
            this.coldsQueryL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsQueryL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsQueryL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsQueryL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsQueryL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsQueryL3DataTableCUR_BAY_ID
            // 
            this.coldsQueryL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsQueryL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsQueryL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsQueryL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsQueryL3DataTableDESTINATION
            // 
            this.coldsQueryL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsQueryL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsQueryL3DataTableDESTINATION.DefaultValue = "";
            this.coldsQueryL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsQueryL3DataTableHOT_SEND_FLAG
            // 
            this.coldsQueryL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsQueryL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsQueryL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsQueryL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsQueryL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsQueryL3DataTablePROCESS_TYPE
            // 
            this.coldsQueryL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsQueryL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsQueryL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsQueryL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsQueryL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsQueryL3DataTablePLAN_ORD_ID
            // 
            this.coldsQueryL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsQueryL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsQueryL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsQueryL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsQueryL3DataTablePRODUCE_DATE
            // 
            this.coldsQueryL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsQueryL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsQueryL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsQueryL3DataTableFINISH_FLAG
            // 
            this.coldsQueryL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsQueryL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsQueryL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsQueryL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsQueryL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsQueryL3DataTableFINISHEDTIME
            // 
            this.coldsQueryL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsQueryL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsQueryL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsQueryL3DataTableBLOOM_COUNT
            // 
            this.coldsQueryL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsQueryL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsQueryL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsQueryL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsQueryL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsQueryL3DataTableCAL_WEIGHT
            // 
            this.coldsQueryL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsQueryL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsQueryL3DataTableCAL_WEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableCAL_WEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTableRIGHT_COUNT
            // 
            this.coldsQueryL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsQueryL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsQueryL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsQueryL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsQueryL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsQueryL3DataTableRIGHT_WEIGHT
            // 
            this.coldsQueryL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsQueryL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsQueryL3DataTableRIGHT_WEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableRIGHT_WEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_COUNT
            // 
            this.coldsQueryL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsQueryL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsQueryL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_WEIGHT
            // 
            this.coldsQueryL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsQueryL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsQueryL3DataTableWASTER_WEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableWASTER_WEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_COUNT1
            // 
            this.coldsQueryL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsQueryL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsQueryL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_WEIGHT1
            // 
            this.coldsQueryL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsQueryL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsQueryL3DataTableWASTER_WEIGHT1.DataType = typeof(double);
            this.coldsQueryL3DataTableWASTER_WEIGHT1.DefaultValue = 0;
            this.coldsQueryL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_REASON1
            // 
            this.coldsQueryL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsQueryL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsQueryL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsQueryL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_COUNT2
            // 
            this.coldsQueryL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsQueryL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsQueryL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_WEIGHT2
            // 
            this.coldsQueryL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsQueryL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsQueryL3DataTableWASTER_WEIGHT2.DataType = typeof(double);
            this.coldsQueryL3DataTableWASTER_WEIGHT2.DefaultValue = 0;
            this.coldsQueryL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_REASON2
            // 
            this.coldsQueryL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsQueryL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsQueryL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsQueryL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_COUNT3
            // 
            this.coldsQueryL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsQueryL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsQueryL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_WEIGHT3
            // 
            this.coldsQueryL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsQueryL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsQueryL3DataTableWASTER_WEIGHT3.DataType = typeof(double);
            this.coldsQueryL3DataTableWASTER_WEIGHT3.DefaultValue = 0;
            this.coldsQueryL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsQueryL3DataTableWASTER_REASON3
            // 
            this.coldsQueryL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsQueryL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsQueryL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsQueryL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_COUNT
            // 
            this.coldsQueryL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsQueryL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsQueryL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsQueryL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_WEIGHT
            // 
            this.coldsQueryL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsQueryL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsQueryL3DataTableWRONG_WEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableWRONG_WEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_COUNT1
            // 
            this.coldsQueryL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsQueryL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsQueryL3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coldsQueryL3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_WEIGHT1
            // 
            this.coldsQueryL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsQueryL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsQueryL3DataTableWRONG_WEIGHT1.DataType = typeof(double);
            this.coldsQueryL3DataTableWRONG_WEIGHT1.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_REASON1
            // 
            this.coldsQueryL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsQueryL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsQueryL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsQueryL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_COUNT2
            // 
            this.coldsQueryL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsQueryL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsQueryL3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coldsQueryL3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_WEIGHT2
            // 
            this.coldsQueryL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsQueryL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsQueryL3DataTableWRONG_WEIGHT2.DataType = typeof(double);
            this.coldsQueryL3DataTableWRONG_WEIGHT2.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_REASON2
            // 
            this.coldsQueryL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsQueryL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsQueryL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsQueryL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_COUNT3
            // 
            this.coldsQueryL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsQueryL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsQueryL3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coldsQueryL3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_WEIGHT3
            // 
            this.coldsQueryL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsQueryL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsQueryL3DataTableWRONG_WEIGHT3.DataType = typeof(double);
            this.coldsQueryL3DataTableWRONG_WEIGHT3.DefaultValue = 0;
            this.coldsQueryL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsQueryL3DataTableWRONG_REASON3
            // 
            this.coldsQueryL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsQueryL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsQueryL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsQueryL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsQueryL3DataTableSUFACEDEFACTDES
            // 
            this.coldsQueryL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsQueryL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsQueryL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsQueryL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsQueryL3DataTableREASON
            // 
            this.coldsQueryL3DataTableREASON.Caption = "REASON";
            this.coldsQueryL3DataTableREASON.ColumnName = "REASON";
            this.coldsQueryL3DataTableREASON.DefaultValue = "";
            this.coldsQueryL3DataTableREASON.Namespace = "";
            // 
            // coldsQueryL3DataTableTest_Roll_Count
            // 
            this.coldsQueryL3DataTableTest_Roll_Count.Caption = "Test_Roll_Count";
            this.coldsQueryL3DataTableTest_Roll_Count.ColumnName = "Test_Roll_Count";
            this.coldsQueryL3DataTableTest_Roll_Count.Namespace = "";
            // 
            // coldsQueryL3DataTableTest_Roll_Weight
            // 
            this.coldsQueryL3DataTableTest_Roll_Weight.Caption = "Test_Roll_Weight";
            this.coldsQueryL3DataTableTest_Roll_Weight.ColumnName = "Test_Roll_Weight";
            this.coldsQueryL3DataTableTest_Roll_Weight.Namespace = "";
            // 
            // coldsQueryL3DataTableSpileFlagDes
            // 
            this.coldsQueryL3DataTableSpileFlagDes.Caption = "SpileFlagDes";
            this.coldsQueryL3DataTableSpileFlagDes.ColumnName = "SpileFlagDes";
            this.coldsQueryL3DataTableSpileFlagDes.Namespace = "";
            // 
            // coldsQueryL3DataTabletotalweight
            // 
            this.coldsQueryL3DataTabletotalweight.Caption = "totalweight";
            this.coldsQueryL3DataTabletotalweight.ColumnName = "totalweight";
            this.coldsQueryL3DataTabletotalweight.DataType = typeof(double);
            this.coldsQueryL3DataTabletotalweight.Namespace = "";
            // 
            // coldsQueryL3DataTableback_date
            // 
            this.coldsQueryL3DataTableback_date.Caption = "back_date";
            this.coldsQueryL3DataTableback_date.ColumnName = "back_date";
            this.coldsQueryL3DataTableback_date.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTableback_date.Namespace = "";
            // 
            // coldsQueryL3DataTableback_flag
            // 
            this.coldsQueryL3DataTableback_flag.Caption = "back_flag";
            this.coldsQueryL3DataTableback_flag.ColumnName = "back_flag";
            this.coldsQueryL3DataTableback_flag.Namespace = "";
            // 
            // coldsQueryL3DataTableAdd_Bloom_Count
            // 
            this.coldsQueryL3DataTableAdd_Bloom_Count.Caption = "Add_Bloom_Count";
            this.coldsQueryL3DataTableAdd_Bloom_Count.ColumnName = "Add_Bloom_Count";
            this.coldsQueryL3DataTableAdd_Bloom_Count.DataType = typeof(int);
            this.coldsQueryL3DataTableAdd_Bloom_Count.DefaultValue = 0;
            this.coldsQueryL3DataTableAdd_Bloom_Count.Namespace = "";
            // 
            // coldsQueryL3DataTableDiv_Bloom_Count
            // 
            this.coldsQueryL3DataTableDiv_Bloom_Count.Caption = "Div_Bloom_Count";
            this.coldsQueryL3DataTableDiv_Bloom_Count.ColumnName = "Div_Bloom_Count";
            this.coldsQueryL3DataTableDiv_Bloom_Count.DataType = typeof(int);
            this.coldsQueryL3DataTableDiv_Bloom_Count.DefaultValue = 0;
            this.coldsQueryL3DataTableDiv_Bloom_Count.Namespace = "";
            // 
            // coldsQueryL3DataTablePlan_Bloom_Count
            // 
            this.coldsQueryL3DataTablePlan_Bloom_Count.Caption = "Plan_Bloom_Count";
            this.coldsQueryL3DataTablePlan_Bloom_Count.ColumnName = "Plan_Bloom_Count";
            this.coldsQueryL3DataTablePlan_Bloom_Count.DataType = typeof(int);
            this.coldsQueryL3DataTablePlan_Bloom_Count.DefaultValue = 0;
            this.coldsQueryL3DataTablePlan_Bloom_Count.Namespace = "";
            // 
            // coldsQueryL3DataTableAdd_Div_HeatID
            // 
            this.coldsQueryL3DataTableAdd_Div_HeatID.Caption = "Add_Div_HeatID";
            this.coldsQueryL3DataTableAdd_Div_HeatID.ColumnName = "Add_Div_HeatID";
            this.coldsQueryL3DataTableAdd_Div_HeatID.Namespace = "";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel3.Text = "               ";
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
            // cmbStoreID
            // 
            this.cmbStoreID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbStoreID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStoreID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStoreID.Name = "cmbStoreID";
            this.cmbStoreID.Size = new System.Drawing.Size(121, 25);
            this.cmbStoreID.SelectedIndexChanged += new System.EventHandler(this.cmbStoreID_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "库区:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "炉号:";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "/ {0}";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvQuery);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(898, 438);
            this.hmiRootPanel1.TabIndex = 35;
            // 
            // dvQuery
            // 
            this.dvQuery.AllowUserToAddRows = false;
            this.dvQuery.AutoGenerateColumns = false;
            this.dvQuery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.qASTATUSDataGridViewTextBoxColumn,
            this.qALEVELDataGridViewTextBoxColumn,
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn,
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn,
            this.sALESCONTRACTIDDataGridViewTextBoxColumn,
            this.SpileFlagDes,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.cASTINGNODataGridViewTextBoxColumn,
            this.cASTINGHEATCNTDataGridViewTextBoxColumn,
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.cURPILEIDDataGridViewTextBoxColumn,
            this.cURLAYERIDDataGridViewTextBoxColumn,
            this.cURSEQIDDataGridViewTextBoxColumn,
            this.cURBAYIDDataGridViewTextBoxColumn,
            this.dESTINATIONDataGridViewTextBoxColumn,
            this.hOTSENDFLAGDataGridViewTextBoxColumn,
            this.pROCESSTYPEDataGridViewTextBoxColumn,
            this.pLANORDIDDataGridViewTextBoxColumn,
            this.pRODUCEDATEDataGridViewTextBoxColumn,
            this.fINISHFLAGDataGridViewTextBoxColumn,
            this.fINISHEDTIMEDataGridViewTextBoxColumn,
            this.bLOOMCOUNTDataGridViewTextBoxColumn,
            this.totalweight,
            this.cALWEIGHTDataGridViewTextBoxColumn,
            this.rIGHTCOUNTDataGridViewTextBoxColumn,
            this.rIGHTWEIGHTDataGridViewTextBoxColumn,
            this.wASTERCOUNTDataGridViewTextBoxColumn,
            this.wASTERWEIGHTDataGridViewTextBoxColumn,
            this.wASTERCOUNT1DataGridViewTextBoxColumn,
            this.wASTERWEIGHT1DataGridViewTextBoxColumn,
            this.wASTERREASON1DataGridViewTextBoxColumn,
            this.wASTERCOUNT2DataGridViewTextBoxColumn,
            this.wASTERWEIGHT2DataGridViewTextBoxColumn,
            this.wASTERREASON2DataGridViewTextBoxColumn,
            this.wASTERCOUNT3DataGridViewTextBoxColumn,
            this.wASTERWEIGHT3DataGridViewTextBoxColumn,
            this.wASTERREASON3DataGridViewTextBoxColumn,
            this.wRONGCOUNTDataGridViewTextBoxColumn,
            this.wRONGWEIGHTDataGridViewTextBoxColumn,
            this.wRONGCOUNT1DataGridViewTextBoxColumn,
            this.wRONGWEIGHT1DataGridViewTextBoxColumn,
            this.wRONGREASON1DataGridViewTextBoxColumn,
            this.wRONGCOUNT2DataGridViewTextBoxColumn,
            this.wRONGWEIGHT2DataGridViewTextBoxColumn,
            this.wRONGREASON2DataGridViewTextBoxColumn,
            this.wRONGCOUNT3DataGridViewTextBoxColumn,
            this.wRONGWEIGHT3DataGridViewTextBoxColumn,
            this.wRONGREASON3DataGridViewTextBoxColumn,
            this.Test_Roll_Count,
            this.Test_Roll_Weight,
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn,
            this.rEASONDataGridViewTextBoxColumn,
            this.cURSECTIONIDDataGridViewTextBoxColumn,
            this.back_date,
            this.back_flag,
            this.Plan_Bloom_Count,
            this.ADD_HEATID1,
            this.Add_Bloom_Count,
            this.ADD_HEATID2,
            this.ADD_BLOOM_COUNT2,
            this.Div_Bloom_Count,
            this.Add_Div_HeatID});
            this.dvQuery.DataSource = this.bsQuery;
            this.dvQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvQuery.Location = new System.Drawing.Point(0, 0);
            this.dvQuery.Name = "dvQuery";
            this.dvQuery.ReadOnly = true;
            this.dvQuery.RowHeadersVisible = false;
            this.dvQuery.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvQuery.RowTemplate.Height = 23;
            this.dvQuery.Size = new System.Drawing.Size(898, 438);
            this.dvQuery.TabIndex = 1;
            this.dvQuery.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvQuery_DataError);
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "CODE_GROUP = \'BLOOM_STATUS\'";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableCode_Des,
            this.coldsStatusL3DataTableCode_Val_Long});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableCode_Des
            // 
            this.coldsStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsStatusL3DataTableCode_Val_Long
            // 
            this.coldsStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsStoreAreaID
            // 
            this.dsStoreAreaID.AutoLoad = true;
            this.dsStoreAreaID.AutoSubscribe = false;
            this.dsStoreAreaID.DataSetName = "L3DataSet";
            this.dsStoreAreaID.DeleteMethod = null;
            this.dsStoreAreaID.InsertMethod = null;
            this.dsStoreAreaID.L3DataAdapter = this.Adapter;
            this.dsStoreAreaID.LoadEvent = "Click";
            this.dsStoreAreaID.LoadTrigger = null;
            this.dsStoreAreaID.RefreshValve = 1000;
            this.dsStoreAreaID.SourceCommand = null;
            this.dsStoreAreaID.SourceCondition = "CODE_GROUP = \'BloomArea\' order by code";
            this.dsStoreAreaID.SourceMethod = "";
            this.dsStoreAreaID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreAreaID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreAreaID.SubscribeTarget = null;
            this.dsStoreAreaID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreAreaID});
            this.dsStoreAreaID.UpdateEvent = "Click";
            this.dsStoreAreaID.UpdateMethod = null;
            this.dsStoreAreaID.UpdateTrigger = null;
            // 
            // schemadsStoreAreaID
            // 
            this.schemadsStoreAreaID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreAreaIDL3DataTableCode,
            this.coldsStoreAreaIDL3DataTableCode_Des});
            this.schemadsStoreAreaID.TableName = "L3DataTable";
            // 
            // coldsStoreAreaIDL3DataTableCode
            // 
            this.coldsStoreAreaIDL3DataTableCode.Caption = "Code";
            this.coldsStoreAreaIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreAreaIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreAreaIDL3DataTableCode_Des
            // 
            this.coldsStoreAreaIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsSpile
            // 
            this.dsSpile.AutoLoad = true;
            this.dsSpile.AutoSubscribe = false;
            this.dsSpile.DataSetName = "L3DataSet";
            this.dsSpile.DeleteMethod = null;
            this.dsSpile.InsertMethod = null;
            this.dsSpile.L3DataAdapter = this.Adapter;
            this.dsSpile.LoadEvent = "Click";
            this.dsSpile.LoadTrigger = null;
            this.dsSpile.RefreshValve = 1000;
            this.dsSpile.SourceCommand = null;
            this.dsSpile.SourceCondition = "CODE_GROUP = \'BLOOM_SPILE\'";
            this.dsSpile.SourceMethod = "";
            this.dsSpile.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSpile.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSpile.SubscribeTarget = null;
            this.dsSpile.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSpile});
            this.dsSpile.UpdateEvent = "Click";
            this.dsSpile.UpdateMethod = null;
            this.dsSpile.UpdateTrigger = null;
            // 
            // schemadsSpile
            // 
            this.schemadsSpile.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSpileL3DataTableCode,
            this.coldsSpileL3DataTableCode_Des});
            this.schemadsSpile.TableName = "L3DataTable";
            // 
            // coldsSpileL3DataTableCode
            // 
            this.coldsSpileL3DataTableCode.Caption = "Code";
            this.coldsSpileL3DataTableCode.ColumnName = "Code";
            this.coldsSpileL3DataTableCode.Namespace = "";
            // 
            // coldsSpileL3DataTableCode_Des
            // 
            this.coldsSpileL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSpileL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSpileL3DataTableCode_Des.Namespace = "";
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // dsWrongReason
            // 
            this.dsWrongReason.AutoLoad = true;
            this.dsWrongReason.AutoSubscribe = false;
            this.dsWrongReason.DataSetName = "L3DataSet";
            this.dsWrongReason.DeleteMethod = null;
            this.dsWrongReason.InsertMethod = null;
            this.dsWrongReason.L3DataAdapter = this.Adapter;
            this.dsWrongReason.LoadEvent = "Click";
            this.dsWrongReason.LoadTrigger = null;
            this.dsWrongReason.RefreshValve = 1000;
            this.dsWrongReason.SourceCommand = null;
            this.dsWrongReason.SourceCondition = "CODE_GROUP = \'WRONG_REASON_CODE\'";
            this.dsWrongReason.SourceMethod = "";
            this.dsWrongReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWrongReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWrongReason.SubscribeTarget = null;
            this.dsWrongReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWrongReason});
            this.dsWrongReason.UpdateEvent = "Click";
            this.dsWrongReason.UpdateMethod = null;
            this.dsWrongReason.UpdateTrigger = null;
            // 
            // schemadsWrongReason
            // 
            this.schemadsWrongReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWrongReasonL3DataTableCode,
            this.coldsWrongReasonL3DataTableCode_Des});
            this.schemadsWrongReason.TableName = "L3DataTable";
            // 
            // coldsWrongReasonL3DataTableCode
            // 
            this.coldsWrongReasonL3DataTableCode.Caption = "Code";
            this.coldsWrongReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWrongReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWrongReasonL3DataTableCode_Des
            // 
            this.coldsWrongReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.Namespace = "";
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoLoad = true;
            this.dsOffLineReason.AutoSubscribe = false;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = null;
            this.dsOffLineReason.InsertMethod = null;
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "Click";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "CODE_GROUP = \'OFFLINE_REASON_CODE\'";
            this.dsOffLineReason.SourceMethod = "";
            this.dsOffLineReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOffLineReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOffLineReason.SubscribeTarget = null;
            this.dsOffLineReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOffLineReason});
            this.dsOffLineReason.UpdateEvent = "Click";
            this.dsOffLineReason.UpdateMethod = null;
            this.dsOffLineReason.UpdateTrigger = null;
            // 
            // schemadsOffLineReason
            // 
            this.schemadsOffLineReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOffLineReasonL3DataTableCode,
            this.coldsOffLineReasonL3DataTableCode_Des});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTableCode
            // 
            this.coldsOffLineReasonL3DataTableCode.Caption = "Code";
            this.coldsOffLineReasonL3DataTableCode.ColumnName = "Code";
            this.coldsOffLineReasonL3DataTableCode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_Des
            // 
            this.coldsOffLineReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.Namespace = "";
            // 
            // AcoldsQueryL3DataTableAdd_Bloom_Count
            // 
            this.AcoldsQueryL3DataTableAdd_Bloom_Count.Caption = "Add_Bloom_Count";
            this.AcoldsQueryL3DataTableAdd_Bloom_Count.ColumnName = "Add_Bloom_Count";
            this.AcoldsQueryL3DataTableAdd_Bloom_Count.DataType = typeof(int);
            this.AcoldsQueryL3DataTableAdd_Bloom_Count.DefaultValue = 0;
            this.AcoldsQueryL3DataTableAdd_Bloom_Count.Namespace = "";
            // 
            // AcoldsQueryL3DataTableDiv_Bloom_Count
            // 
            this.AcoldsQueryL3DataTableDiv_Bloom_Count.Caption = "Div_Bloom_Count";
            this.AcoldsQueryL3DataTableDiv_Bloom_Count.ColumnName = "Div_Bloom_Count";
            this.AcoldsQueryL3DataTableDiv_Bloom_Count.DataType = typeof(int);
            this.AcoldsQueryL3DataTableDiv_Bloom_Count.DefaultValue = 0;
            this.AcoldsQueryL3DataTableDiv_Bloom_Count.Namespace = "";
            // 
            // AcoldsQueryL3DataTablePlan_Bloom_Count
            // 
            this.AcoldsQueryL3DataTablePlan_Bloom_Count.Caption = "Plan_Bloom_Count";
            this.AcoldsQueryL3DataTablePlan_Bloom_Count.ColumnName = "Plan_Bloom_Count";
            this.AcoldsQueryL3DataTablePlan_Bloom_Count.DataType = typeof(int);
            this.AcoldsQueryL3DataTablePlan_Bloom_Count.DefaultValue = 0;
            this.AcoldsQueryL3DataTablePlan_Bloom_Count.Namespace = "";
            // 
            // AcoldsQueryL3DataTableAdd_Div_HeatID
            // 
            this.AcoldsQueryL3DataTableAdd_Div_HeatID.Caption = "Add_Div_HeatID";
            this.AcoldsQueryL3DataTableAdd_Div_HeatID.ColumnName = "Add_Div_HeatID";
            this.AcoldsQueryL3DataTableAdd_Div_HeatID.Namespace = "";
            // 
            // coldsQueryL3DataTableADD_HEATID1
            // 
            this.coldsQueryL3DataTableADD_HEATID1.Caption = "ADD_HEATID1";
            this.coldsQueryL3DataTableADD_HEATID1.ColumnName = "ADD_HEATID1";
            this.coldsQueryL3DataTableADD_HEATID1.Namespace = "";
            // 
            // coldsQueryL3DataTableADD_HEATID2
            // 
            this.coldsQueryL3DataTableADD_HEATID2.Caption = "ADD_HEATID2";
            this.coldsQueryL3DataTableADD_HEATID2.ColumnName = "ADD_HEATID2";
            this.coldsQueryL3DataTableADD_HEATID2.Namespace = "";
            // 
            // coldsQueryL3DataTableADD_BLOOM_COUNT2
            // 
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2.Caption = "ADD_BLOOM_COUNT2";
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2.ColumnName = "ADD_BLOOM_COUNT2";
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2.DataType = typeof(int);
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2.DefaultValue = 0;
            this.coldsQueryL3DataTableADD_BLOOM_COUNT2.Namespace = "";
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.Frozen = true;
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.sTATUSDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTATUSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // qASTATUSDataGridViewTextBoxColumn
            // 
            this.qASTATUSDataGridViewTextBoxColumn.DataPropertyName = "QASTATUS";
            this.qASTATUSDataGridViewTextBoxColumn.HeaderText = "质量状态";
            this.qASTATUSDataGridViewTextBoxColumn.Name = "qASTATUSDataGridViewTextBoxColumn";
            this.qASTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.qASTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // qALEVELDataGridViewTextBoxColumn
            // 
            this.qALEVELDataGridViewTextBoxColumn.DataPropertyName = "QALEVEL";
            this.qALEVELDataGridViewTextBoxColumn.HeaderText = "质量级别";
            this.qALEVELDataGridViewTextBoxColumn.Name = "qALEVELDataGridViewTextBoxColumn";
            this.qALEVELDataGridViewTextBoxColumn.ReadOnly = true;
            this.qALEVELDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERCONTRACTID";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "采购合同号";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Name = "oRDERCONTRACTIDDataGridViewTextBoxColumn";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUCECONTRACTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCECONTRACTID";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.HeaderText = "生产合同号";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Name = "pRODUCECONTRACTIDDataGridViewTextBoxColumn";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sALESCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "SALESCONTRACTID";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "销售合同号";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Name = "sALESCONTRACTIDDataGridViewTextBoxColumn";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SpileFlagDes
            // 
            this.SpileFlagDes.DataPropertyName = "SpileFlagDes";
            this.SpileFlagDes.HeaderText = "上垛标志描述";
            this.SpileFlagDes.Name = "SpileFlagDes";
            this.SpileFlagDes.ReadOnly = true;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cASTINGNODataGridViewTextBoxColumn
            // 
            this.cASTINGNODataGridViewTextBoxColumn.DataPropertyName = "CASTING_NO";
            this.cASTINGNODataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.cASTINGNODataGridViewTextBoxColumn.Name = "cASTINGNODataGridViewTextBoxColumn";
            this.cASTINGNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cASTINGHEATCNTDataGridViewTextBoxColumn
            // 
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.DataPropertyName = "CASTING_HEAT_CNT";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Name = "cASTINGHEATCNTDataGridViewTextBoxColumn";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUTSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "CUT_STEELGRADEINDEX";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "cUTSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fINALSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "FINAL_STEELGRADEINDEX";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "fINALSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            this.lENGTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsStoreAreaID;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "库区";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURPILEIDDataGridViewTextBoxColumn
            // 
            this.cURPILEIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_PILE_ID";
            this.cURPILEIDDataGridViewTextBoxColumn.DataSource = this.dsSpile;
            this.cURPILEIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cURPILEIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cURPILEIDDataGridViewTextBoxColumn.HeaderText = "当前垛";
            this.cURPILEIDDataGridViewTextBoxColumn.Name = "cURPILEIDDataGridViewTextBoxColumn";
            this.cURPILEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURPILEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cURPILEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cURPILEIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURLAYERIDDataGridViewTextBoxColumn
            // 
            this.cURLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_LAYER_ID";
            this.cURLAYERIDDataGridViewTextBoxColumn.HeaderText = "当前层";
            this.cURLAYERIDDataGridViewTextBoxColumn.Name = "cURLAYERIDDataGridViewTextBoxColumn";
            this.cURLAYERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cURSEQIDDataGridViewTextBoxColumn
            // 
            this.cURSEQIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SEQ_ID";
            this.cURSEQIDDataGridViewTextBoxColumn.HeaderText = "当前顺序";
            this.cURSEQIDDataGridViewTextBoxColumn.Name = "cURSEQIDDataGridViewTextBoxColumn";
            this.cURSEQIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cURBAYIDDataGridViewTextBoxColumn
            // 
            this.cURBAYIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_BAY_ID";
            this.cURBAYIDDataGridViewTextBoxColumn.HeaderText = "当前跨";
            this.cURBAYIDDataGridViewTextBoxColumn.Name = "cURBAYIDDataGridViewTextBoxColumn";
            this.cURBAYIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESTINATIONDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.HeaderText = "去向";
            this.dESTINATIONDataGridViewTextBoxColumn.Name = "dESTINATIONDataGridViewTextBoxColumn";
            this.dESTINATIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTSENDFLAGDataGridViewTextBoxColumn
            // 
            this.hOTSENDFLAGDataGridViewTextBoxColumn.DataPropertyName = "HOT_SEND_FLAG";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Name = "hOTSENDFLAGDataGridViewTextBoxColumn";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROCESSTYPEDataGridViewTextBoxColumn
            // 
            this.pROCESSTYPEDataGridViewTextBoxColumn.DataPropertyName = "PROCESS_TYPE";
            this.pROCESSTYPEDataGridViewTextBoxColumn.HeaderText = "处置方式";
            this.pROCESSTYPEDataGridViewTextBoxColumn.Name = "pROCESSTYPEDataGridViewTextBoxColumn";
            this.pROCESSTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            this.pLANORDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCEDATEDataGridViewTextBoxColumn
            // 
            this.pRODUCEDATEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCE_DATE";
            this.pRODUCEDATEDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.pRODUCEDATEDataGridViewTextBoxColumn.Name = "pRODUCEDATEDataGridViewTextBoxColumn";
            this.pRODUCEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fINISHFLAGDataGridViewTextBoxColumn
            // 
            this.fINISHFLAGDataGridViewTextBoxColumn.DataPropertyName = "FINISH_FLAG";
            this.fINISHFLAGDataGridViewTextBoxColumn.HeaderText = "质量抽检标志";
            this.fINISHFLAGDataGridViewTextBoxColumn.Name = "fINISHFLAGDataGridViewTextBoxColumn";
            this.fINISHFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fINISHEDTIMEDataGridViewTextBoxColumn
            // 
            this.fINISHEDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FINISHEDTIME";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.HeaderText = "质量抽检时间";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.Name = "fINISHEDTIMEDataGridViewTextBoxColumn";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bLOOMCOUNTDataGridViewTextBoxColumn
            // 
            this.bLOOMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "BLOOM_COUNT";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Name = "bLOOMCOUNTDataGridViewTextBoxColumn";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalweight
            // 
            this.totalweight.DataPropertyName = "totalweight";
            this.totalweight.HeaderText = "出坯总重量[t]";
            this.totalweight.Name = "totalweight";
            this.totalweight.ReadOnly = true;
            // 
            // cALWEIGHTDataGridViewTextBoxColumn
            // 
            this.cALWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "CAL_WEIGHT";
            this.cALWEIGHTDataGridViewTextBoxColumn.HeaderText = "理论重量[t]";
            this.cALWEIGHTDataGridViewTextBoxColumn.Name = "cALWEIGHTDataGridViewTextBoxColumn";
            this.cALWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rIGHTCOUNTDataGridViewTextBoxColumn
            // 
            this.rIGHTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_COUNT";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Name = "rIGHTCOUNTDataGridViewTextBoxColumn";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rIGHTWEIGHTDataGridViewTextBoxColumn
            // 
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_WEIGHT";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.HeaderText = "合格钢坯重量[t]";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Name = "rIGHTWEIGHTDataGridViewTextBoxColumn";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERCOUNTDataGridViewTextBoxColumn
            // 
            this.wASTERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT";
            this.wASTERCOUNTDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总长度";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Name = "wASTERCOUNTDataGridViewTextBoxColumn";
            this.wASTERCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERWEIGHTDataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.HeaderText = "甩废重量[t]";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Name = "wASTERWEIGHTDataGridViewTextBoxColumn";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERCOUNT1DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Name = "wASTERCOUNT1DataGridViewTextBoxColumn";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.HeaderText = "甩废重量1[t]";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Name = "wASTERWEIGHT1DataGridViewTextBoxColumn";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERREASON1DataGridViewTextBoxColumn
            // 
            this.wASTERREASON1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON1";
            this.wASTERREASON1DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wASTERREASON1DataGridViewTextBoxColumn.Name = "wASTERREASON1DataGridViewTextBoxColumn";
            this.wASTERREASON1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERREASON1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wASTERCOUNT2DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Name = "wASTERCOUNT2DataGridViewTextBoxColumn";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.HeaderText = "甩废重量2[t]";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Name = "wASTERWEIGHT2DataGridViewTextBoxColumn";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERREASON2DataGridViewTextBoxColumn
            // 
            this.wASTERREASON2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON2";
            this.wASTERREASON2DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wASTERREASON2DataGridViewTextBoxColumn.Name = "wASTERREASON2DataGridViewTextBoxColumn";
            this.wASTERREASON2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERREASON2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wASTERCOUNT3DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Name = "wASTERCOUNT3DataGridViewTextBoxColumn";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.HeaderText = "甩废重量3[t]";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Name = "wASTERWEIGHT3DataGridViewTextBoxColumn";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wASTERREASON3DataGridViewTextBoxColumn
            // 
            this.wASTERREASON3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON3";
            this.wASTERREASON3DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wASTERREASON3DataGridViewTextBoxColumn.Name = "wASTERREASON3DataGridViewTextBoxColumn";
            this.wASTERREASON3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERREASON3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNTDataGridViewTextBoxColumn
            // 
            this.wRONGCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT";
            this.wRONGCOUNTDataGridViewTextBoxColumn.HeaderText = "不合格钢坯总支数";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Name = "wRONGCOUNTDataGridViewTextBoxColumn";
            this.wRONGCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGCOUNTDataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHTDataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.HeaderText = "不合格总重量[t]";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Name = "wRONGWEIGHTDataGridViewTextBoxColumn";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGCOUNT1DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Name = "wRONGCOUNT1DataGridViewTextBoxColumn";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT1";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.HeaderText = "不合格重量1[t]";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.Name = "wRONGWEIGHT1DataGridViewTextBoxColumn";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGREASON1DataGridViewTextBoxColumn
            // 
            this.wRONGREASON1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON1";
            this.wRONGREASON1DataGridViewTextBoxColumn.DataSource = this.dsWrongReason;
            this.wRONGREASON1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wRONGREASON1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wRONGREASON1DataGridViewTextBoxColumn.HeaderText = "不合格原因1";
            this.wRONGREASON1DataGridViewTextBoxColumn.Name = "wRONGREASON1DataGridViewTextBoxColumn";
            this.wRONGREASON1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGREASON1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNT2DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Name = "wRONGCOUNT2DataGridViewTextBoxColumn";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT2";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.HeaderText = "不合格重量2[t]";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.Name = "wRONGWEIGHT2DataGridViewTextBoxColumn";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGREASON2DataGridViewTextBoxColumn
            // 
            this.wRONGREASON2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON2";
            this.wRONGREASON2DataGridViewTextBoxColumn.DataSource = this.dsWrongReason;
            this.wRONGREASON2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wRONGREASON2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wRONGREASON2DataGridViewTextBoxColumn.HeaderText = "不合格原因2";
            this.wRONGREASON2DataGridViewTextBoxColumn.Name = "wRONGREASON2DataGridViewTextBoxColumn";
            this.wRONGREASON2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGREASON2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNT3DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Name = "wRONGCOUNT3DataGridViewTextBoxColumn";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT3";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.HeaderText = "不合格重量3[t]";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.Name = "wRONGWEIGHT3DataGridViewTextBoxColumn";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGREASON3DataGridViewTextBoxColumn
            // 
            this.wRONGREASON3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON3";
            this.wRONGREASON3DataGridViewTextBoxColumn.DataSource = this.dsWrongReason;
            this.wRONGREASON3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wRONGREASON3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wRONGREASON3DataGridViewTextBoxColumn.HeaderText = "不合格原因3";
            this.wRONGREASON3DataGridViewTextBoxColumn.Name = "wRONGREASON3DataGridViewTextBoxColumn";
            this.wRONGREASON3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wRONGREASON3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // Test_Roll_Count
            // 
            this.Test_Roll_Count.DataPropertyName = "Test_Roll_Count";
            this.Test_Roll_Count.HeaderText = "试轧钢坯支数";
            this.Test_Roll_Count.Name = "Test_Roll_Count";
            this.Test_Roll_Count.ReadOnly = true;
            // 
            // Test_Roll_Weight
            // 
            this.Test_Roll_Weight.DataPropertyName = "Test_Roll_Weight";
            this.Test_Roll_Weight.HeaderText = "试轧钢坯重量[t]";
            this.Test_Roll_Weight.Name = "Test_Roll_Weight";
            this.Test_Roll_Weight.ReadOnly = true;
            this.Test_Roll_Weight.Width = 110;
            // 
            // sUFACEDEFACTDESDataGridViewTextBoxColumn
            // 
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.DataPropertyName = "SUFACEDEFACTDES";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.Name = "sUFACEDEFACTDESDataGridViewTextBoxColumn";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.DataSource = this.dsOffLineReason;
            this.rEASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.rEASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            this.rEASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rEASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rEASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURSECTIONIDDataGridViewTextBoxColumn
            // 
            this.cURSECTIONIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SECTION_ID";
            this.cURSECTIONIDDataGridViewTextBoxColumn.HeaderText = "当前区";
            this.cURSECTIONIDDataGridViewTextBoxColumn.Name = "cURSECTIONIDDataGridViewTextBoxColumn";
            this.cURSECTIONIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURSECTIONIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // back_date
            // 
            this.back_date.DataPropertyName = "back_date";
            this.back_date.HeaderText = "线材回退日期";
            this.back_date.Name = "back_date";
            this.back_date.ReadOnly = true;
            // 
            // back_flag
            // 
            this.back_flag.DataPropertyName = "back_flag";
            this.back_flag.HeaderText = "线材回退标志";
            this.back_flag.Name = "back_flag";
            this.back_flag.ReadOnly = true;
            // 
            // Plan_Bloom_Count
            // 
            this.Plan_Bloom_Count.DataPropertyName = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.HeaderText = "计划钢坯支数";
            this.Plan_Bloom_Count.Name = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.ReadOnly = true;
            // 
            // ADD_HEATID1
            // 
            this.ADD_HEATID1.DataPropertyName = "ADD_HEATID1";
            this.ADD_HEATID1.HeaderText = "拨入炉号1";
            this.ADD_HEATID1.Name = "ADD_HEATID1";
            this.ADD_HEATID1.ReadOnly = true;
            // 
            // Add_Bloom_Count
            // 
            this.Add_Bloom_Count.DataPropertyName = "Add_Bloom_Count";
            this.Add_Bloom_Count.HeaderText = "拨入钢坯支数1";
            this.Add_Bloom_Count.Name = "Add_Bloom_Count";
            this.Add_Bloom_Count.ReadOnly = true;
            // 
            // ADD_HEATID2
            // 
            this.ADD_HEATID2.DataPropertyName = "ADD_HEATID2";
            this.ADD_HEATID2.HeaderText = "拨入炉号2";
            this.ADD_HEATID2.Name = "ADD_HEATID2";
            this.ADD_HEATID2.ReadOnly = true;
            // 
            // ADD_BLOOM_COUNT2
            // 
            this.ADD_BLOOM_COUNT2.DataPropertyName = "ADD_BLOOM_COUNT2";
            this.ADD_BLOOM_COUNT2.HeaderText = "拨入钢坯支数2";
            this.ADD_BLOOM_COUNT2.Name = "ADD_BLOOM_COUNT2";
            this.ADD_BLOOM_COUNT2.ReadOnly = true;
            // 
            // Div_Bloom_Count
            // 
            this.Div_Bloom_Count.DataPropertyName = "Div_Bloom_Count";
            this.Div_Bloom_Count.HeaderText = "拨出钢坯支数";
            this.Div_Bloom_Count.Name = "Div_Bloom_Count";
            this.Div_Bloom_Count.ReadOnly = true;
            // 
            // Add_Div_HeatID
            // 
            this.Add_Div_HeatID.DataPropertyName = "Add_Div_HeatID";
            this.Add_Div_HeatID.HeaderText = "拨出炉号";
            this.Add_Div_HeatID.Name = "Add_Div_HeatID";
            this.Add_Div_HeatID.ReadOnly = true;
            // 
            // BloomStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 506);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tSp1);
            this.Name = "BloomStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢坯库存查询";
            this.Text = "库存查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomStoreQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.BloomStoreQueryFrm_Load);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQuery)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnOutEXL;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbStoreID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtMaterialID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtStoreAreaID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvQuery;
        private AppSvrHMI.L3DataSet dsStoreAreaID;
        private System.Windows.Forms.BindingSource bsQuery;
        private AppSvrHMI.L3DataSet dsQuery;
        private AppSvrHMI.L3Command cmdQuery;
        private System.Data.DataTable schemadsQuery;
        private System.Data.DataColumn coldsQueryL3DataTableMATERIALID;
        private System.Data.DataColumn coldsQueryL3DataTableSTATUS;
        private System.Data.DataColumn coldsQueryL3DataTablePOSITION;
        private System.Data.DataColumn coldsQueryL3DataTableQASTATUS;
        private System.Data.DataColumn coldsQueryL3DataTableQALEVEL;
        private System.Data.DataColumn coldsQueryL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsQueryL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsQueryL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsQueryL3DataTableCASTERID;
        private System.Data.DataColumn coldsQueryL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsQueryL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsQueryL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQueryL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsQueryL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQueryL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQueryL3DataTableLENGTH;
        private System.Data.DataColumn coldsQueryL3DataTableWIDTH;
        private System.Data.DataColumn coldsQueryL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsQueryL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsQueryL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsQueryL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsQueryL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsQueryL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsQueryL3DataTableDESTINATION;
        private System.Data.DataColumn coldsQueryL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsQueryL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsQueryL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsQueryL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsQueryL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsQueryL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsQueryL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsQueryL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsQueryL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsQueryL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsQueryL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsQueryL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsQueryL3DataTableREASON;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsStoreAreaID;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataColumn coldsQueryL3DataTableTest_Roll_Count;
        private System.Data.DataColumn coldsQueryL3DataTableTest_Roll_Weight;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSpile;
        private System.Data.DataTable schemadsSpile;
        private System.Data.DataColumn coldsSpileL3DataTableCode;
        private System.Data.DataColumn coldsSpileL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsQueryL3DataTableSpileFlagDes;
        private System.Data.DataColumn coldsQueryL3DataTabletotalweight;
        private System.Data.DataColumn coldsQueryL3DataTableback_date;
        private System.Data.DataColumn coldsQueryL3DataTableback_flag;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Data.DataColumn coldsQueryL3DataTableAdd_Bloom_Count;
        private System.Data.DataColumn coldsQueryL3DataTableDiv_Bloom_Count;
        private System.Data.DataColumn coldsQueryL3DataTablePlan_Bloom_Count;
        private System.Data.DataColumn coldsQueryL3DataTableAdd_Div_HeatID;
        private System.Data.DataColumn AcoldsQueryL3DataTableAdd_Bloom_Count;
        private System.Data.DataColumn AcoldsQueryL3DataTableDiv_Bloom_Count;
        private System.Data.DataColumn AcoldsQueryL3DataTablePlan_Bloom_Count;
        private System.Data.DataColumn AcoldsQueryL3DataTableAdd_Div_HeatID;
        private System.Data.DataColumn coldsQueryL3DataTableADD_HEATID1;
        private System.Data.DataColumn coldsQueryL3DataTableADD_HEATID2;
        private System.Data.DataColumn coldsQueryL3DataTableADD_BLOOM_COUNT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qASTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCECONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALESCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpileFlagDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGHEATCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUTSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cURPILEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURLAYERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSEQIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURBAYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTSENDFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCESSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINISHFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINISHEDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOOMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGHTCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGHTWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wASTERREASON1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wASTERREASON2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wASTERREASON3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wRONGREASON1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wRONGREASON2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wRONGREASON3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Roll_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Roll_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUFACEDEFACTDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSECTIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn back_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn back_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_HEATID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_HEATID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_BLOOM_COUNT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Div_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Div_HeatID;
    }
}