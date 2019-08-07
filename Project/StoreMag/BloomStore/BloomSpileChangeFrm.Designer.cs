namespace StoreMag.BloomStore
{
    partial class BloomSpileChangeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomSpileChangeFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnSpileChange = new System.Windows.Forms.ToolStripButton();
            this.dsStoreID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStoreAreaID = new System.Data.DataTable();
            this.coldsStoreIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsSpileChange = new AppSvrHMI.L3DataSet();
            this.schemadsSpileChange = new System.Data.DataTable();
            this.coldsSpileChangeL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableREASON = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableTargetID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableTarget_Pile_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableTarget_Layer_ID = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableAmount = new System.Data.DataColumn();
            this.coldsSpileChangeL3DataTableMaterialType = new System.Data.DataColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSpileChange = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cURPILEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsPile = new AppSvrHMI.L3DataSet();
            this.schemadsPile = new System.Data.DataTable();
            this.coldsPileL3DataTableCode = new System.Data.DataColumn();
            this.coldsPileL3DataTableCode_Des = new System.Data.DataColumn();
            this.cURLAYERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetPileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetLayerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSpileChange = new System.Windows.Forms.BindingSource(this.components);
            this.cmdSpileChange = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpileChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpileChange)).BeginInit();
            this.panel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSpileChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpileChange)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnSpileChange});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(861, 43);
            this.tSp1.TabIndex = 34;
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
            // btnSpileChange
            // 
            this.btnSpileChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSpileChange.Image")));
            this.btnSpileChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSpileChange.Name = "btnSpileChange";
            this.btnSpileChange.Size = new System.Drawing.Size(89, 40);
            this.btnSpileChange.Text = "垛位变更";
            this.btnSpileChange.Click += new System.EventHandler(this.btnSpileChange_Click);
            // 
            // dsStoreID
            // 
            this.dsStoreID.AutoSubscribe = true;
            this.dsStoreID.DataSetName = "L3DataSet";
            this.dsStoreID.DeleteMethod = "";
            this.dsStoreID.InsertMethod = "";
            this.dsStoreID.L3DataAdapter = this.Adapter;
            this.dsStoreID.LoadEvent = "Click";
            this.dsStoreID.LoadTrigger = null;
            this.dsStoreID.RefreshValve = 1000;
            this.dsStoreID.SourceCommand = null;
            this.dsStoreID.SourceCondition = "CODE_GROUP = \'BloomArea\' order by code";
            this.dsStoreID.SourceMethod = "";
            this.dsStoreID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreID.SubscribeTarget = null;
            this.dsStoreID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreAreaID});
            this.dsStoreID.UpdateEvent = "Click";
            this.dsStoreID.UpdateMethod = "";
            this.dsStoreID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStoreAreaID
            // 
            this.schemadsStoreAreaID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreIDL3DataTableCode,
            this.coldsStoreIDL3DataTableCode_Des});
            this.schemadsStoreAreaID.TableName = "L3DataTable";
            // 
            // coldsStoreIDL3DataTableCode
            // 
            this.coldsStoreIDL3DataTableCode.Caption = "Code";
            this.coldsStoreIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreIDL3DataTableCode_Des
            // 
            this.coldsStoreIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsSpileChange
            // 
            this.dsSpileChange.AutoSubscribe = true;
            this.dsSpileChange.DataSetName = "L3DataSet";
            this.dsSpileChange.DeleteMethod = "";
            this.dsSpileChange.InsertMethod = "";
            this.dsSpileChange.L3DataAdapter = this.Adapter;
            this.dsSpileChange.LoadEvent = "Click";
            this.dsSpileChange.LoadTrigger = null;
            this.dsSpileChange.RefreshValve = 1000;
            this.dsSpileChange.SourceCommand = null;
            this.dsSpileChange.SourceCondition = "";
            this.dsSpileChange.SourceMethod = "";
            this.dsSpileChange.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsSpileChange.SourceURI = "";
            this.dsSpileChange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSpileChange});
            this.dsSpileChange.UpdateEvent = "Click";
            this.dsSpileChange.UpdateMethod = "";
            this.dsSpileChange.UpdateTrigger = null;
            // 
            // schemadsSpileChange
            // 
            this.schemadsSpileChange.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSpileChangeL3DataTableMATERIALID,
            this.coldsSpileChangeL3DataTableSTATUS,
            this.coldsSpileChangeL3DataTablePOSITION,
            this.coldsSpileChangeL3DataTableQASTATUS,
            this.coldsSpileChangeL3DataTableQALEVEL,
            this.coldsSpileChangeL3DataTableORDERCONTRACTID,
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID,
            this.coldsSpileChangeL3DataTableSALESCONTRACTID,
            this.coldsSpileChangeL3DataTableCASTERID,
            this.coldsSpileChangeL3DataTableCASTING_NO,
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT,
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX,
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX,
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX,
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsSpileChangeL3DataTableLENGTH,
            this.coldsSpileChangeL3DataTableWIDTH,
            this.coldsSpileChangeL3DataTableTHICKNESS,
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID,
            this.coldsSpileChangeL3DataTableCUR_PILE_ID,
            this.coldsSpileChangeL3DataTableCUR_LAYER_ID,
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID,
            this.coldsSpileChangeL3DataTableCUR_BAY_ID,
            this.coldsSpileChangeL3DataTableDESTINATION,
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG,
            this.coldsSpileChangeL3DataTablePROCESS_TYPE,
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID,
            this.coldsSpileChangeL3DataTablePRODUCE_DATE,
            this.coldsSpileChangeL3DataTableFINISH_FLAG,
            this.coldsSpileChangeL3DataTableFINISHEDTIME,
            this.coldsSpileChangeL3DataTableBLOOM_COUNT,
            this.coldsSpileChangeL3DataTableCAL_WEIGHT,
            this.coldsSpileChangeL3DataTableRIGHT_COUNT,
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT,
            this.coldsSpileChangeL3DataTableWASTER_COUNT,
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT,
            this.coldsSpileChangeL3DataTableWASTER_COUNT1,
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1,
            this.coldsSpileChangeL3DataTableWASTER_REASON1,
            this.coldsSpileChangeL3DataTableWASTER_COUNT2,
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2,
            this.coldsSpileChangeL3DataTableWASTER_REASON2,
            this.coldsSpileChangeL3DataTableWASTER_COUNT3,
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3,
            this.coldsSpileChangeL3DataTableWASTER_REASON3,
            this.coldsSpileChangeL3DataTableWRONG_COUNT,
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT,
            this.coldsSpileChangeL3DataTableWRONG_COUNT1,
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1,
            this.coldsSpileChangeL3DataTableWRONG_REASON1,
            this.coldsSpileChangeL3DataTableWRONG_COUNT2,
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2,
            this.coldsSpileChangeL3DataTableWRONG_REASON2,
            this.coldsSpileChangeL3DataTableWRONG_COUNT3,
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3,
            this.coldsSpileChangeL3DataTableWRONG_REASON3,
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES,
            this.coldsSpileChangeL3DataTableREASON,
            this.coldsSpileChangeL3DataTableTargetID,
            this.coldsSpileChangeL3DataTableTarget_Pile_ID,
            this.coldsSpileChangeL3DataTableTarget_Layer_ID,
            this.coldsSpileChangeL3DataTableCheckFlag,
            this.coldsSpileChangeL3DataTableAmount,
            this.coldsSpileChangeL3DataTableMaterialType});
            this.schemadsSpileChange.TableName = "L3DataTable";
            // 
            // coldsSpileChangeL3DataTableMATERIALID
            // 
            this.coldsSpileChangeL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsSpileChangeL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsSpileChangeL3DataTableMATERIALID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableSTATUS
            // 
            this.coldsSpileChangeL3DataTableSTATUS.Caption = "STATUS";
            this.coldsSpileChangeL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsSpileChangeL3DataTableSTATUS.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableSTATUS.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableSTATUS.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePOSITION
            // 
            this.coldsSpileChangeL3DataTablePOSITION.Caption = "POSITION";
            this.coldsSpileChangeL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsSpileChangeL3DataTablePOSITION.DefaultValue = "";
            this.coldsSpileChangeL3DataTablePOSITION.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableQASTATUS
            // 
            this.coldsSpileChangeL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsSpileChangeL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsSpileChangeL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableQALEVEL
            // 
            this.coldsSpileChangeL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsSpileChangeL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsSpileChangeL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableORDERCONTRACTID
            // 
            this.coldsSpileChangeL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsSpileChangeL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsSpileChangeL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePRODUCECONTRACTID
            // 
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsSpileChangeL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableSALESCONTRACTID
            // 
            this.coldsSpileChangeL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsSpileChangeL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsSpileChangeL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCASTERID
            // 
            this.coldsSpileChangeL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsSpileChangeL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsSpileChangeL3DataTableCASTERID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCASTERID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCASTING_NO
            // 
            this.coldsSpileChangeL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsSpileChangeL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsSpileChangeL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableLENGTH
            // 
            this.coldsSpileChangeL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsSpileChangeL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsSpileChangeL3DataTableLENGTH.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableLENGTH.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableLENGTH.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWIDTH
            // 
            this.coldsSpileChangeL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsSpileChangeL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsSpileChangeL3DataTableWIDTH.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableWIDTH.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWIDTH.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableTHICKNESS
            // 
            this.coldsSpileChangeL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsSpileChangeL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsSpileChangeL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUR_SECTION_ID
            // 
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUR_PILE_ID
            // 
            this.coldsSpileChangeL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsSpileChangeL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsSpileChangeL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUR_LAYER_ID
            // 
            this.coldsSpileChangeL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsSpileChangeL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsSpileChangeL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUR_SEQ_ID
            // 
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCUR_BAY_ID
            // 
            this.coldsSpileChangeL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsSpileChangeL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsSpileChangeL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsSpileChangeL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableDESTINATION
            // 
            this.coldsSpileChangeL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsSpileChangeL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsSpileChangeL3DataTableDESTINATION.DefaultValue = "";
            this.coldsSpileChangeL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableHOT_SEND_FLAG
            // 
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePROCESS_TYPE
            // 
            this.coldsSpileChangeL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsSpileChangeL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsSpileChangeL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsSpileChangeL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsSpileChangeL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePLAN_ORD_ID
            // 
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsSpileChangeL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTablePRODUCE_DATE
            // 
            this.coldsSpileChangeL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsSpileChangeL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsSpileChangeL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsSpileChangeL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableFINISH_FLAG
            // 
            this.coldsSpileChangeL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsSpileChangeL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsSpileChangeL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableFINISHEDTIME
            // 
            this.coldsSpileChangeL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsSpileChangeL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsSpileChangeL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsSpileChangeL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableBLOOM_COUNT
            // 
            this.coldsSpileChangeL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsSpileChangeL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsSpileChangeL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCAL_WEIGHT
            // 
            this.coldsSpileChangeL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsSpileChangeL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsSpileChangeL3DataTableCAL_WEIGHT.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableCAL_WEIGHT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableRIGHT_COUNT
            // 
            this.coldsSpileChangeL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsSpileChangeL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsSpileChangeL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableRIGHT_WEIGHT
            // 
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_COUNT
            // 
            this.coldsSpileChangeL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsSpileChangeL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsSpileChangeL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_WEIGHT
            // 
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_COUNT1
            // 
            this.coldsSpileChangeL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsSpileChangeL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsSpileChangeL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_WEIGHT1
            // 
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_REASON1
            // 
            this.coldsSpileChangeL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsSpileChangeL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsSpileChangeL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_COUNT2
            // 
            this.coldsSpileChangeL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsSpileChangeL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsSpileChangeL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_WEIGHT2
            // 
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_REASON2
            // 
            this.coldsSpileChangeL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsSpileChangeL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsSpileChangeL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_COUNT3
            // 
            this.coldsSpileChangeL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsSpileChangeL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsSpileChangeL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_WEIGHT3
            // 
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWASTER_REASON3
            // 
            this.coldsSpileChangeL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsSpileChangeL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsSpileChangeL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_COUNT
            // 
            this.coldsSpileChangeL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsSpileChangeL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsSpileChangeL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_WEIGHT
            // 
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_COUNT1
            // 
            this.coldsSpileChangeL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsSpileChangeL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsSpileChangeL3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_WEIGHT1
            // 
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_REASON1
            // 
            this.coldsSpileChangeL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsSpileChangeL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsSpileChangeL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_COUNT2
            // 
            this.coldsSpileChangeL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsSpileChangeL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsSpileChangeL3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_WEIGHT2
            // 
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_REASON2
            // 
            this.coldsSpileChangeL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsSpileChangeL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsSpileChangeL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_COUNT3
            // 
            this.coldsSpileChangeL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsSpileChangeL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsSpileChangeL3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coldsSpileChangeL3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_WEIGHT3
            // 
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3.DataType = typeof(double);
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3.DefaultValue = 0;
            this.coldsSpileChangeL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableWRONG_REASON3
            // 
            this.coldsSpileChangeL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsSpileChangeL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsSpileChangeL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsSpileChangeL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableSUFACEDEFACTDES
            // 
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsSpileChangeL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableREASON
            // 
            this.coldsSpileChangeL3DataTableREASON.Caption = "REASON";
            this.coldsSpileChangeL3DataTableREASON.ColumnName = "REASON";
            this.coldsSpileChangeL3DataTableREASON.DefaultValue = "";
            this.coldsSpileChangeL3DataTableREASON.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableTargetID
            // 
            this.coldsSpileChangeL3DataTableTargetID.Caption = "TargetID";
            this.coldsSpileChangeL3DataTableTargetID.ColumnName = "TargetID";
            this.coldsSpileChangeL3DataTableTargetID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableTarget_Pile_ID
            // 
            this.coldsSpileChangeL3DataTableTarget_Pile_ID.Caption = "Target_Pile_ID";
            this.coldsSpileChangeL3DataTableTarget_Pile_ID.ColumnName = "Target_Pile_ID";
            this.coldsSpileChangeL3DataTableTarget_Pile_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableTarget_Layer_ID
            // 
            this.coldsSpileChangeL3DataTableTarget_Layer_ID.Caption = "Target_Layer_ID";
            this.coldsSpileChangeL3DataTableTarget_Layer_ID.ColumnName = "Target_Layer_ID";
            this.coldsSpileChangeL3DataTableTarget_Layer_ID.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableCheckFlag
            // 
            this.coldsSpileChangeL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSpileChangeL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSpileChangeL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSpileChangeL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableAmount
            // 
            this.coldsSpileChangeL3DataTableAmount.Caption = "Amount";
            this.coldsSpileChangeL3DataTableAmount.ColumnName = "Amount";
            this.coldsSpileChangeL3DataTableAmount.Namespace = "";
            // 
            // coldsSpileChangeL3DataTableMaterialType
            // 
            this.coldsSpileChangeL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsSpileChangeL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsSpileChangeL3DataTableMaterialType.Namespace = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hmiRootPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 424);
            this.panel1.TabIndex = 36;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvSpileChange);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(861, 424);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvSpileChange
            // 
            this.dvSpileChange.AllowUserToAddRows = false;
            this.dvSpileChange.AutoGenerateColumns = false;
            this.dvSpileChange.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSpileChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSpileChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.cURPILEIDDataGridViewTextBoxColumn,
            this.cURLAYERIDDataGridViewTextBoxColumn,
            this.targetIDDataGridViewTextBoxColumn,
            this.targetPileIDDataGridViewTextBoxColumn,
            this.targetLayerIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dvSpileChange.DataSource = this.bsSpileChange;
            this.dvSpileChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSpileChange.Location = new System.Drawing.Point(0, 0);
            this.dvSpileChange.Name = "dvSpileChange";
            this.dvSpileChange.RowHeadersVisible = false;
            this.dvSpileChange.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSpileChange.RowTemplate.Height = 23;
            this.dvSpileChange.Size = new System.Drawing.Size(861, 424);
            this.dvSpileChange.TabIndex = 1;
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsStoreID;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "原库区";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURPILEIDDataGridViewTextBoxColumn
            // 
            this.cURPILEIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_PILE_ID";
            this.cURPILEIDDataGridViewTextBoxColumn.DataSource = this.dsPile;
            this.cURPILEIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cURPILEIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cURPILEIDDataGridViewTextBoxColumn.HeaderText = "原垛位";
            this.cURPILEIDDataGridViewTextBoxColumn.Name = "cURPILEIDDataGridViewTextBoxColumn";
            this.cURPILEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURPILEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cURPILEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cURPILEIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsPile
            // 
            this.dsPile.AutoSubscribe = true;
            this.dsPile.DataSetName = "L3DataSet";
            this.dsPile.DeleteMethod = null;
            this.dsPile.InsertMethod = null;
            this.dsPile.L3DataAdapter = this.Adapter;
            this.dsPile.LoadEvent = "Click";
            this.dsPile.LoadTrigger = null;
            this.dsPile.RefreshValve = 1000;
            this.dsPile.SourceCommand = null;
            this.dsPile.SourceCondition = "CODE_GROUP = \'BLOOM_SPILE\' or CODE_GROUP = \'KEEP_SPILE\' order by code";
            this.dsPile.SourceMethod = "";
            this.dsPile.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPile.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPile.SubscribeTarget = null;
            this.dsPile.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPile});
            this.dsPile.UpdateEvent = "Click";
            this.dsPile.UpdateMethod = null;
            this.dsPile.UpdateTrigger = null;
            // 
            // schemadsPile
            // 
            this.schemadsPile.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPileL3DataTableCode,
            this.coldsPileL3DataTableCode_Des});
            this.schemadsPile.TableName = "L3DataTable";
            // 
            // coldsPileL3DataTableCode
            // 
            this.coldsPileL3DataTableCode.Caption = "Code";
            this.coldsPileL3DataTableCode.ColumnName = "Code";
            this.coldsPileL3DataTableCode.Namespace = "";
            // 
            // coldsPileL3DataTableCode_Des
            // 
            this.coldsPileL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPileL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPileL3DataTableCode_Des.Namespace = "";
            // 
            // cURLAYERIDDataGridViewTextBoxColumn
            // 
            this.cURLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_LAYER_ID";
            this.cURLAYERIDDataGridViewTextBoxColumn.HeaderText = "原层";
            this.cURLAYERIDDataGridViewTextBoxColumn.Name = "cURLAYERIDDataGridViewTextBoxColumn";
            this.cURLAYERIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetIDDataGridViewTextBoxColumn
            // 
            this.targetIDDataGridViewTextBoxColumn.DataPropertyName = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.DataSource = this.dsStoreID;
            this.targetIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.targetIDDataGridViewTextBoxColumn.HeaderText = "目标库区";
            this.targetIDDataGridViewTextBoxColumn.Name = "targetIDDataGridViewTextBoxColumn";
            this.targetIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.targetIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.targetIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // targetPileIDDataGridViewTextBoxColumn
            // 
            this.targetPileIDDataGridViewTextBoxColumn.DataPropertyName = "Target_Pile_ID";
            this.targetPileIDDataGridViewTextBoxColumn.DataSource = this.dsPile;
            this.targetPileIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.targetPileIDDataGridViewTextBoxColumn.HeaderText = "目标垛位";
            this.targetPileIDDataGridViewTextBoxColumn.Name = "targetPileIDDataGridViewTextBoxColumn";
            this.targetPileIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.targetPileIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.targetPileIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // targetLayerIDDataGridViewTextBoxColumn
            // 
            this.targetLayerIDDataGridViewTextBoxColumn.DataPropertyName = "Target_Layer_ID";
            this.targetLayerIDDataGridViewTextBoxColumn.HeaderText = "目标层";
            this.targetLayerIDDataGridViewTextBoxColumn.Name = "targetLayerIDDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSpileChange
            // 
            this.bsSpileChange.DataMember = "L3DataTable";
            this.bsSpileChange.DataSource = this.dsSpileChange;
            // 
            // cmdSpileChange
            // 
            this.cmdSpileChange.Adapter = this.Adapter;
            this.cmdSpileChange.MergeReturnTarget = false;
            this.cmdSpileChange.Method = "ChangeBloomPosition";
            this.cmdSpileChange.Object = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.cmdSpileChange.Parameters.Add(this.l3CommandParameter3);
            this.cmdSpileChange.ReturnTarget = null;
            this.cmdSpileChange.ReturnTargetProperty = null;
            this.cmdSpileChange.Trigger = null;
            this.cmdSpileChange.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter3.SourceObject = this.dsSpileChange;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // BloomSpileChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSp1);
            this.Name = "BloomSpileChangeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "垛位变更";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomSpileChangeFrm_FormClosing);
            this.Load += new System.EventHandler(this.BloomSpileChangeFrm_Load);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpileChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpileChange)).EndInit();
            this.panel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSpileChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpileChange)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnSpileChange;
        private AppSvrHMI.L3DataSet dsStoreID;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsStoreAreaID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSpileChange;
        private System.Data.DataTable schemadsSpileChange;
        private System.Data.DataColumn coldsSpileChangeL3DataTableMATERIALID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableSTATUS;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePOSITION;
        private System.Data.DataColumn coldsSpileChangeL3DataTableQASTATUS;
        private System.Data.DataColumn coldsSpileChangeL3DataTableQALEVEL;
        private System.Data.DataColumn coldsSpileChangeL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCASTERID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeL3DataTableLENGTH;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWIDTH;
        private System.Data.DataColumn coldsSpileChangeL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableDESTINATION;
        private System.Data.DataColumn coldsSpileChangeL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsSpileChangeL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsSpileChangeL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsSpileChangeL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsSpileChangeL3DataTableREASON;
        private System.Data.DataColumn coldsSpileChangeL3DataTableTargetID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableTarget_Pile_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableTarget_Layer_ID;
        private System.Data.DataColumn coldsSpileChangeL3DataTableCheckFlag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bsSpileChange;
        private System.Data.DataColumn coldsSpileChangeL3DataTableAmount;
        private AppSvrHMI.L3DataSet dsPile;
        private System.Data.DataTable schemadsPile;
        private System.Data.DataColumn coldsPileL3DataTableCode;
        private System.Data.DataColumn coldsPileL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdSpileChange;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsSpileChangeL3DataTableMaterialType;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSpileChange;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cURPILEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURLAYERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn targetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn targetPileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLayerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}