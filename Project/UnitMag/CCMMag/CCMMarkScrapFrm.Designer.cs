namespace UnitMag.CCMMag
{
    partial class CCMMarkScrapFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCMMarkScrapFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsHeatData = new AppSvrHMI.L3DataSet();
            this.schemadsHeatData = new System.Data.DataTable();
            this.coldsHeatDataL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAdd_Bloom_Count = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableDiv_Bloom_Count = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTablePlan_Bloom_Count = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAdd_Div_HeatID = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAdd_HeatID1 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAdd_HeatID2 = new System.Data.DataColumn();
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2 = new System.Data.DataColumn();
            this.bsHeatData = new System.Windows.Forms.BindingSource(this.components);
            this.l3dbxCastingEndEvent = new AppSvrHMI.L3DataBox();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvHeatData = new System.Windows.Forms.DataGridView();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGHEATCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTSENDFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOOMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.wASTERCOUNT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wASTERCOUNT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Div_HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_HeatID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_HeatID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Bloom_Count2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnThrow = new System.Windows.Forms.ToolStripButton();
            this.btnScrapQuery = new System.Windows.Forms.ToolStripButton();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatData)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsHeatData
            // 
            this.dsHeatData.AutoLoad = true;
            this.dsHeatData.AutoSubscribe = false;
            this.dsHeatData.DataSetName = "L3DataSet";
            this.dsHeatData.DeleteMethod = "";
            this.dsHeatData.InsertMethod = "";
            this.dsHeatData.L3DataAdapter = this.Adapter;
            this.dsHeatData.LoadEvent = "Click";
            this.dsHeatData.LoadTrigger = null;
            this.dsHeatData.RefreshValve = 1000;
            this.dsHeatData.SourceCommand = null;
            this.dsHeatData.SourceCondition = null;
            this.dsHeatData.SourceMethod = "GetHeatAllInformation";
            this.dsHeatData.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatData.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.dsHeatData.SubscribeTarget = null;
            this.dsHeatData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatData});
            this.dsHeatData.UpdateEvent = "Click";
            this.dsHeatData.UpdateMethod = "";
            this.dsHeatData.UpdateTrigger = null;
            // 
            // schemadsHeatData
            // 
            this.schemadsHeatData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatDataL3DataTableMATERIALTYPE,
            this.coldsHeatDataL3DataTableAMOUNT,
            this.coldsHeatDataL3DataTableMATERIALID,
            this.coldsHeatDataL3DataTableCASTERID,
            this.coldsHeatDataL3DataTableCASTING_NO,
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT,
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX,
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX,
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX,
            this.coldsHeatDataL3DataTableLENGTH,
            this.coldsHeatDataL3DataTableWIDTH,
            this.coldsHeatDataL3DataTableTHICKNESS,
            this.coldsHeatDataL3DataTableDESTINATION,
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG,
            this.coldsHeatDataL3DataTablePLAN_ORD_ID,
            this.coldsHeatDataL3DataTablePRODUCE_DATE,
            this.coldsHeatDataL3DataTableBLOOM_COUNT,
            this.coldsHeatDataL3DataTableCAL_WEIGHT,
            this.coldsHeatDataL3DataTableRIGHT_COUNT,
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT,
            this.coldsHeatDataL3DataTableWASTER_COUNT,
            this.coldsHeatDataL3DataTableWASTER_WEIGHT,
            this.coldsHeatDataL3DataTableWASTER_COUNT1,
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1,
            this.coldsHeatDataL3DataTableWASTER_REASON1,
            this.coldsHeatDataL3DataTableWASTER_COUNT2,
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2,
            this.coldsHeatDataL3DataTableWASTER_REASON2,
            this.coldsHeatDataL3DataTableWASTER_COUNT3,
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3,
            this.coldsHeatDataL3DataTableWASTER_REASON3,
            this.coldsHeatDataL3DataTableHEATID,
            this.coldsHeatDataL3DataTableAdd_Bloom_Count,
            this.coldsHeatDataL3DataTableDiv_Bloom_Count,
            this.coldsHeatDataL3DataTablePlan_Bloom_Count,
            this.coldsHeatDataL3DataTableAdd_Div_HeatID,
            this.coldsHeatDataL3DataTableAdd_HeatID1,
            this.coldsHeatDataL3DataTableAdd_HeatID2,
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2});
            this.schemadsHeatData.TableName = "L3DataTable";
            // 
            // coldsHeatDataL3DataTableMATERIALTYPE
            // 
            this.coldsHeatDataL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsHeatDataL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsHeatDataL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsHeatDataL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAMOUNT
            // 
            this.coldsHeatDataL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsHeatDataL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsHeatDataL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsHeatDataL3DataTableAMOUNT.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableMATERIALID
            // 
            this.coldsHeatDataL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsHeatDataL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsHeatDataL3DataTableMATERIALID.DefaultValue = "";
            this.coldsHeatDataL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableCASTERID
            // 
            this.coldsHeatDataL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsHeatDataL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsHeatDataL3DataTableCASTERID.DefaultValue = "";
            this.coldsHeatDataL3DataTableCASTERID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableCASTING_NO
            // 
            this.coldsHeatDataL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsHeatDataL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsHeatDataL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsHeatDataL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsHeatDataL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsHeatDataL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsHeatDataL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsHeatDataL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsHeatDataL3DataTableSTEELGRADEINDEX
            // 
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsHeatDataL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsHeatDataL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsHeatDataL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsHeatDataL3DataTableLENGTH
            // 
            this.coldsHeatDataL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsHeatDataL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsHeatDataL3DataTableLENGTH.DataType = typeof(int);
            this.coldsHeatDataL3DataTableLENGTH.DefaultValue = 0;
            this.coldsHeatDataL3DataTableLENGTH.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWIDTH
            // 
            this.coldsHeatDataL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsHeatDataL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsHeatDataL3DataTableWIDTH.DataType = typeof(int);
            this.coldsHeatDataL3DataTableWIDTH.DefaultValue = 0;
            this.coldsHeatDataL3DataTableWIDTH.Namespace = "";
            // 
            // coldsHeatDataL3DataTableTHICKNESS
            // 
            this.coldsHeatDataL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsHeatDataL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsHeatDataL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsHeatDataL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsHeatDataL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsHeatDataL3DataTableDESTINATION
            // 
            this.coldsHeatDataL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsHeatDataL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsHeatDataL3DataTableDESTINATION.DefaultValue = "";
            this.coldsHeatDataL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsHeatDataL3DataTableHOT_SEND_FLAG
            // 
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsHeatDataL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsHeatDataL3DataTablePLAN_ORD_ID
            // 
            this.coldsHeatDataL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsHeatDataL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsHeatDataL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsHeatDataL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsHeatDataL3DataTablePRODUCE_DATE
            // 
            this.coldsHeatDataL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsHeatDataL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsHeatDataL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsHeatDataL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsHeatDataL3DataTableBLOOM_COUNT
            // 
            this.coldsHeatDataL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsHeatDataL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsHeatDataL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsHeatDataL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsHeatDataL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableCAL_WEIGHT
            // 
            this.coldsHeatDataL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsHeatDataL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsHeatDataL3DataTableCAL_WEIGHT.DataType = typeof(double);
            this.coldsHeatDataL3DataTableCAL_WEIGHT.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableRIGHT_COUNT
            // 
            this.coldsHeatDataL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsHeatDataL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsHeatDataL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsHeatDataL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsHeatDataL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableRIGHT_WEIGHT
            // 
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT.DataType = typeof(double);
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_COUNT
            // 
            this.coldsHeatDataL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsHeatDataL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsHeatDataL3DataTableWASTER_COUNT.DataType = typeof(int);
            this.coldsHeatDataL3DataTableWASTER_COUNT.DefaultValue = 0;
            this.coldsHeatDataL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_WEIGHT
            // 
            this.coldsHeatDataL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT.DataType = typeof(double);
            this.coldsHeatDataL3DataTableWASTER_WEIGHT.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_COUNT1
            // 
            this.coldsHeatDataL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsHeatDataL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsHeatDataL3DataTableWASTER_COUNT1.DataType = typeof(int);
            this.coldsHeatDataL3DataTableWASTER_COUNT1.DefaultValue = 0;
            this.coldsHeatDataL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_WEIGHT1
            // 
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1.DataType = typeof(double);
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_REASON1
            // 
            this.coldsHeatDataL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsHeatDataL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsHeatDataL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsHeatDataL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_COUNT2
            // 
            this.coldsHeatDataL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsHeatDataL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsHeatDataL3DataTableWASTER_COUNT2.DataType = typeof(int);
            this.coldsHeatDataL3DataTableWASTER_COUNT2.DefaultValue = 0;
            this.coldsHeatDataL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_WEIGHT2
            // 
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2.DataType = typeof(double);
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_REASON2
            // 
            this.coldsHeatDataL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsHeatDataL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsHeatDataL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsHeatDataL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_COUNT3
            // 
            this.coldsHeatDataL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsHeatDataL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsHeatDataL3DataTableWASTER_COUNT3.DataType = typeof(int);
            this.coldsHeatDataL3DataTableWASTER_COUNT3.DefaultValue = 0;
            this.coldsHeatDataL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_WEIGHT3
            // 
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3.DataType = typeof(double);
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3.DefaultValue = 0D;
            this.coldsHeatDataL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsHeatDataL3DataTableWASTER_REASON3
            // 
            this.coldsHeatDataL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsHeatDataL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsHeatDataL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsHeatDataL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsHeatDataL3DataTableHEATID
            // 
            this.coldsHeatDataL3DataTableHEATID.Caption = "HEATID";
            this.coldsHeatDataL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsHeatDataL3DataTableHEATID.DefaultValue = "";
            this.coldsHeatDataL3DataTableHEATID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAdd_Bloom_Count
            // 
            this.coldsHeatDataL3DataTableAdd_Bloom_Count.Caption = "Add_Bloom_Count";
            this.coldsHeatDataL3DataTableAdd_Bloom_Count.ColumnName = "Add_Bloom_Count";
            this.coldsHeatDataL3DataTableAdd_Bloom_Count.DataType = typeof(int);
            this.coldsHeatDataL3DataTableAdd_Bloom_Count.DefaultValue = 0;
            this.coldsHeatDataL3DataTableAdd_Bloom_Count.Namespace = "";
            // 
            // coldsHeatDataL3DataTableDiv_Bloom_Count
            // 
            this.coldsHeatDataL3DataTableDiv_Bloom_Count.Caption = "Div_Bloom_Count";
            this.coldsHeatDataL3DataTableDiv_Bloom_Count.ColumnName = "Div_Bloom_Count";
            this.coldsHeatDataL3DataTableDiv_Bloom_Count.DataType = typeof(int);
            this.coldsHeatDataL3DataTableDiv_Bloom_Count.DefaultValue = 0;
            this.coldsHeatDataL3DataTableDiv_Bloom_Count.Namespace = "";
            // 
            // coldsHeatDataL3DataTablePlan_Bloom_Count
            // 
            this.coldsHeatDataL3DataTablePlan_Bloom_Count.Caption = "Plan_Bloom_Count";
            this.coldsHeatDataL3DataTablePlan_Bloom_Count.ColumnName = "Plan_Bloom_Count";
            this.coldsHeatDataL3DataTablePlan_Bloom_Count.DataType = typeof(int);
            this.coldsHeatDataL3DataTablePlan_Bloom_Count.DefaultValue = 0;
            this.coldsHeatDataL3DataTablePlan_Bloom_Count.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAdd_Div_HeatID
            // 
            this.coldsHeatDataL3DataTableAdd_Div_HeatID.Caption = "Add_Div_HeatID";
            this.coldsHeatDataL3DataTableAdd_Div_HeatID.ColumnName = "Add_Div_HeatID";
            this.coldsHeatDataL3DataTableAdd_Div_HeatID.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAdd_HeatID1
            // 
            this.coldsHeatDataL3DataTableAdd_HeatID1.Caption = "Add_HeatID1";
            this.coldsHeatDataL3DataTableAdd_HeatID1.ColumnName = "Add_HeatID1";
            this.coldsHeatDataL3DataTableAdd_HeatID1.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAdd_HeatID2
            // 
            this.coldsHeatDataL3DataTableAdd_HeatID2.Caption = "Add_HeatID2";
            this.coldsHeatDataL3DataTableAdd_HeatID2.ColumnName = "Add_HeatID2";
            this.coldsHeatDataL3DataTableAdd_HeatID2.Namespace = "";
            // 
            // coldsHeatDataL3DataTableAdd_Bloom_Count2
            // 
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2.Caption = "Add_Bloom_Count2";
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2.ColumnName = "Add_Bloom_Count2";
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2.DataType = typeof(int);
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2.DefaultValue = 0;
            this.coldsHeatDataL3DataTableAdd_Bloom_Count2.Namespace = "";
            // 
            // bsHeatData
            // 
            this.bsHeatData.DataMember = "L3DataTable";
            this.bsHeatData.DataSource = this.dsHeatData;
            // 
            // l3dbxCastingEndEvent
            // 
            this.l3dbxCastingEndEvent.DataFormat = null;
            this.l3dbxCastingEndEvent.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.l3dbxCastingEndEvent.DataProperty = "CastingEndEvent";
            this.l3dbxCastingEndEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3dbxCastingEndEvent.L3DataAdapter = this.Adapter;
            this.l3dbxCastingEndEvent.Location = new System.Drawing.Point(274, 12);
            this.l3dbxCastingEndEvent.Name = "l3dbxCastingEndEvent";
            this.l3dbxCastingEndEvent.Size = new System.Drawing.Size(100, 21);
            this.l3dbxCastingEndEvent.TabIndex = 82;
            this.l3dbxCastingEndEvent.Value = null;
            this.l3dbxCastingEndEvent.Visible = false;
            this.l3dbxCastingEndEvent.TextChanged += new System.EventHandler(this.l3dbxCastingEndEvent_TextChanged);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.hmiRootPanel2);
            this.hmiRootPanel1.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel1.Controls.Add(this.l3dbxCastingEndEvent);
            this.hmiRootPanel1.Controls.Add(this.tSp1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(880, 521);
            this.hmiRootPanel1.TabIndex = 89;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.Controls.Add(this.dvHeatData);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(880, 453);
            this.hmiRootPanel2.TabIndex = 95;
            // 
            // dvHeatData
            // 
            this.dvHeatData.AllowUserToAddRows = false;
            this.dvHeatData.AutoGenerateColumns = false;
            this.dvHeatData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvHeatData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvHeatData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.cASTINGNODataGridViewTextBoxColumn,
            this.cASTINGHEATCNTDataGridViewTextBoxColumn,
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.mATERIALTYPEDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.dESTINATIONDataGridViewTextBoxColumn,
            this.hOTSENDFLAGDataGridViewTextBoxColumn,
            this.pLANORDIDDataGridViewTextBoxColumn,
            this.pRODUCEDATEDataGridViewTextBoxColumn,
            this.bLOOMCOUNTDataGridViewTextBoxColumn,
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
            this.hEATIDDataGridViewTextBoxColumn,
            this.Add_Bloom_Count,
            this.Div_Bloom_Count,
            this.Plan_Bloom_Count,
            this.Add_Div_HeatID,
            this.Add_HeatID1,
            this.Add_HeatID2,
            this.Add_Bloom_Count2});
            this.dvHeatData.DataSource = this.bsHeatData;
            this.dvHeatData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatData.Location = new System.Drawing.Point(0, 0);
            this.dvHeatData.MultiSelect = false;
            this.dvHeatData.Name = "dvHeatData";
            this.dvHeatData.ReadOnly = true;
            this.dvHeatData.RowTemplate.Height = 23;
            this.dvHeatData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvHeatData.Size = new System.Drawing.Size(880, 453);
            this.dvHeatData.TabIndex = 0;
            this.dvHeatData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvHeatData_CellDoubleClick);
            this.dvHeatData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvHeatData_DataBindingComplete);
            this.dvHeatData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvHeatData_DataError);
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.Frozen = true;
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.Frozen = true;
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTERIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // cASTINGNODataGridViewTextBoxColumn
            // 
            this.cASTINGNODataGridViewTextBoxColumn.DataPropertyName = "CASTING_NO";
            this.cASTINGNODataGridViewTextBoxColumn.Frozen = true;
            this.cASTINGNODataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.cASTINGNODataGridViewTextBoxColumn.Name = "cASTINGNODataGridViewTextBoxColumn";
            this.cASTINGNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTINGNODataGridViewTextBoxColumn.Width = 66;
            // 
            // cASTINGHEATCNTDataGridViewTextBoxColumn
            // 
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.DataPropertyName = "CASTING_HEAT_CNT";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Name = "cASTINGHEATCNTDataGridViewTextBoxColumn";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Width = 102;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Width = 78;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aMOUNTDataGridViewTextBoxColumn.Visible = false;
            this.aMOUNTDataGridViewTextBoxColumn.Width = 66;
            // 
            // cUTSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "CUT_STEELGRADEINDEX";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "cUTSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Width = 102;
            // 
            // mATERIALTYPEDataGridViewTextBoxColumn
            // 
            this.mATERIALTYPEDataGridViewTextBoxColumn.DataPropertyName = "MATERIALTYPE";
            this.mATERIALTYPEDataGridViewTextBoxColumn.HeaderText = "MATERIALTYPE";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Name = "mATERIALTYPEDataGridViewTextBoxColumn";
            this.mATERIALTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALTYPEDataGridViewTextBoxColumn.Visible = false;
            this.mATERIALTYPEDataGridViewTextBoxColumn.Width = 102;
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            this.lENGTHDataGridViewTextBoxColumn.ReadOnly = true;
            this.lENGTHDataGridViewTextBoxColumn.Width = 54;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDTHDataGridViewTextBoxColumn.Width = 54;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHICKNESSDataGridViewTextBoxColumn.Width = 54;
            // 
            // dESTINATIONDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.HeaderText = "去向";
            this.dESTINATIONDataGridViewTextBoxColumn.Name = "dESTINATIONDataGridViewTextBoxColumn";
            this.dESTINATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESTINATIONDataGridViewTextBoxColumn.Width = 54;
            // 
            // hOTSENDFLAGDataGridViewTextBoxColumn
            // 
            this.hOTSENDFLAGDataGridViewTextBoxColumn.DataPropertyName = "HOT_SEND_FLAG";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Name = "hOTSENDFLAGDataGridViewTextBoxColumn";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Width = 78;
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            this.pLANORDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANORDIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // pRODUCEDATEDataGridViewTextBoxColumn
            // 
            this.pRODUCEDATEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCE_DATE";
            this.pRODUCEDATEDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.pRODUCEDATEDataGridViewTextBoxColumn.Name = "pRODUCEDATEDataGridViewTextBoxColumn";
            this.pRODUCEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRODUCEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // bLOOMCOUNTDataGridViewTextBoxColumn
            // 
            this.bLOOMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "BLOOM_COUNT";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Name = "bLOOMCOUNTDataGridViewTextBoxColumn";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Width = 78;
            // 
            // cALWEIGHTDataGridViewTextBoxColumn
            // 
            this.cALWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "CAL_WEIGHT";
            this.cALWEIGHTDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.cALWEIGHTDataGridViewTextBoxColumn.Name = "cALWEIGHTDataGridViewTextBoxColumn";
            this.cALWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cALWEIGHTDataGridViewTextBoxColumn.Width = 78;
            // 
            // rIGHTCOUNTDataGridViewTextBoxColumn
            // 
            this.rIGHTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_COUNT";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Name = "rIGHTCOUNTDataGridViewTextBoxColumn";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // rIGHTWEIGHTDataGridViewTextBoxColumn
            // 
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_WEIGHT";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.HeaderText = "合格重量";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Name = "rIGHTWEIGHTDataGridViewTextBoxColumn";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Width = 78;
            // 
            // wASTERCOUNTDataGridViewTextBoxColumn
            // 
            this.wASTERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT";
            this.wASTERCOUNTDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总长度";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Name = "wASTERCOUNTDataGridViewTextBoxColumn";
            this.wASTERCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERCOUNTDataGridViewTextBoxColumn.Width = 114;
            // 
            // wASTERWEIGHTDataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.HeaderText = "甩废重量";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Name = "wASTERWEIGHTDataGridViewTextBoxColumn";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Width = 78;
            // 
            // wASTERCOUNT1DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Name = "wASTERCOUNT1DataGridViewTextBoxColumn";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Width = 108;
            // 
            // wASTERWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Name = "wASTERWEIGHT1DataGridViewTextBoxColumn";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Width = 84;
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
            this.wASTERREASON1DataGridViewTextBoxColumn.Width = 84;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = null;
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
            // wASTERCOUNT2DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Name = "wASTERCOUNT2DataGridViewTextBoxColumn";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Width = 108;
            // 
            // wASTERWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Name = "wASTERWEIGHT2DataGridViewTextBoxColumn";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Width = 84;
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
            this.wASTERREASON2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wASTERCOUNT3DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Name = "wASTERCOUNT3DataGridViewTextBoxColumn";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Width = 108;
            // 
            // wASTERWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Name = "wASTERWEIGHT3DataGridViewTextBoxColumn";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Width = 84;
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
            this.wASTERREASON3DataGridViewTextBoxColumn.Width = 84;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Add_Bloom_Count
            // 
            this.Add_Bloom_Count.DataPropertyName = "Add_Bloom_Count";
            this.Add_Bloom_Count.HeaderText = "拨入钢坯支数1";
            this.Add_Bloom_Count.Name = "Add_Bloom_Count";
            this.Add_Bloom_Count.ReadOnly = true;
            this.Add_Bloom_Count.Width = 108;
            // 
            // Div_Bloom_Count
            // 
            this.Div_Bloom_Count.DataPropertyName = "Div_Bloom_Count";
            this.Div_Bloom_Count.HeaderText = "拨出钢坯支数";
            this.Div_Bloom_Count.Name = "Div_Bloom_Count";
            this.Div_Bloom_Count.ReadOnly = true;
            this.Div_Bloom_Count.Width = 102;
            // 
            // Plan_Bloom_Count
            // 
            this.Plan_Bloom_Count.DataPropertyName = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.HeaderText = "计划钢坯支数";
            this.Plan_Bloom_Count.Name = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.ReadOnly = true;
            this.Plan_Bloom_Count.Width = 102;
            // 
            // Add_Div_HeatID
            // 
            this.Add_Div_HeatID.DataPropertyName = "Add_Div_HeatID";
            this.Add_Div_HeatID.HeaderText = "拨出炉号";
            this.Add_Div_HeatID.Name = "Add_Div_HeatID";
            this.Add_Div_HeatID.ReadOnly = true;
            this.Add_Div_HeatID.Width = 78;
            // 
            // Add_HeatID1
            // 
            this.Add_HeatID1.DataPropertyName = "Add_HeatID1";
            this.Add_HeatID1.HeaderText = "拨入炉号1";
            this.Add_HeatID1.Name = "Add_HeatID1";
            this.Add_HeatID1.ReadOnly = true;
            this.Add_HeatID1.Width = 84;
            // 
            // Add_HeatID2
            // 
            this.Add_HeatID2.DataPropertyName = "Add_HeatID2";
            this.Add_HeatID2.HeaderText = "拨入炉号1";
            this.Add_HeatID2.Name = "Add_HeatID2";
            this.Add_HeatID2.ReadOnly = true;
            this.Add_HeatID2.Width = 84;
            // 
            // Add_Bloom_Count2
            // 
            this.Add_Bloom_Count2.DataPropertyName = "Add_Bloom_Count2";
            this.Add_Bloom_Count2.HeaderText = "拨入钢坯支数2";
            this.Add_Bloom_Count2.Name = "Add_Bloom_Count2";
            this.Add_Bloom_Count2.ReadOnly = true;
            this.Add_Bloom_Count2.Width = 108;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsHeatData;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.cmbCasterID,
            this.toolStripLabel3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(880, 25);
            this.bindingNavigator1.TabIndex = 94;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.cmbCasterID.SelectedIndexChanged += new System.EventHandler(this.cmbCasterID_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "铸机:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnThrow,
            this.btnScrapQuery,
            this.btnConfirm});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(880, 43);
            this.tSp1.TabIndex = 91;
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
            // btnThrow
            // 
            this.btnThrow.Image = ((System.Drawing.Image)(resources.GetObject("btnThrow.Image")));
            this.btnThrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(68, 40);
            this.btnThrow.Text = "甩废";
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // btnScrapQuery
            // 
            this.btnScrapQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnScrapQuery.Image")));
            this.btnScrapQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScrapQuery.Name = "btnScrapQuery";
            this.btnScrapQuery.Size = new System.Drawing.Size(116, 40);
            this.btnScrapQuery.Text = "出坯实绩查询";
            this.btnScrapQuery.Click += new System.EventHandler(this.btnScrapQuery_Click);
            // 
            // dsCasterID
            // 
            this.dsCasterID.AutoLoad = true;
            this.dsCasterID.AutoSubscribe = false;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' and CODE is not null order by CODE ";
            this.dsCasterID.SourceMethod = "";
            this.dsCasterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterID.SubscribeTarget = null;
            this.dsCasterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterID});
            this.dsCasterID.UpdateEvent = "Click";
            this.dsCasterID.UpdateMethod = null;
            this.dsCasterID.UpdateTrigger = null;
            // 
            // schemadsCasterID
            // 
            this.schemadsCasterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterIDL3DataTableCode,
            this.coldsCasterIDL3DataTableCode_Des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_Des
            // 
            this.coldsCasterIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.Namespace = "";
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "CCMbtnConfirm");
            this.btnConfirm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(104, 40);
            this.btnConfirm.Text = "重新做甩废";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // CCMMarkScrapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 521);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "CCMMarkScrapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "炉次甩废";
            this.Text = "炉次甩废";
            this.Load += new System.EventHandler(this.CCMMarkScrapFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatData)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel1.PerformLayout();
            this.hmiRootPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsHeatData;
        private System.Windows.Forms.BindingSource bsHeatData;
        private System.Data.DataTable schemadsHeatData;
        private System.Data.DataColumn coldsHeatDataL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsHeatDataL3DataTableAMOUNT;
        private System.Data.DataColumn coldsHeatDataL3DataTableMATERIALID;
        private System.Data.DataColumn coldsHeatDataL3DataTableCASTERID;
        private System.Data.DataColumn coldsHeatDataL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsHeatDataL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsHeatDataL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsHeatDataL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsHeatDataL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsHeatDataL3DataTableLENGTH;
        private System.Data.DataColumn coldsHeatDataL3DataTableWIDTH;
        private System.Data.DataColumn coldsHeatDataL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsHeatDataL3DataTableDESTINATION;
        private System.Data.DataColumn coldsHeatDataL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsHeatDataL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsHeatDataL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsHeatDataL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsHeatDataL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsHeatDataL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsHeatDataL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsHeatDataL3DataTableWASTER_REASON3;
        private AppSvrHMI.L3DataBox l3dbxCastingEndEvent;
        private System.Data.DataColumn coldsHeatDataL3DataTableHEATID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.DataGridView dvHeatData;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnThrow;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnScrapQuery;
        private System.Data.DataColumn coldsHeatDataL3DataTableAdd_Bloom_Count;
        private System.Data.DataColumn coldsHeatDataL3DataTableDiv_Bloom_Count;
        private System.Data.DataColumn coldsHeatDataL3DataTablePlan_Bloom_Count;
        private System.Data.DataColumn coldsHeatDataL3DataTableAdd_Div_HeatID;
        private System.Data.DataColumn coldsHeatDataL3DataTableAdd_HeatID1;
        private System.Data.DataColumn coldsHeatDataL3DataTableAdd_HeatID2;
        private System.Data.DataColumn coldsHeatDataL3DataTableAdd_Bloom_Count2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGHEATCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUTSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTSENDFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOOMCOUNTDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Div_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Div_HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_HeatID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_HeatID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Bloom_Count2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
    }
}