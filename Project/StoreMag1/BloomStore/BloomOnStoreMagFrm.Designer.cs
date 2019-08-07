namespace StoreMag.BloomStore
{
    partial class BloomOnStoreMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomOnStoreMagFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnQualityCheck = new System.Windows.Forms.ToolStripButton();
            this.btnSpileChange = new System.Windows.Forms.ToolStripButton();
            this.btnOutStore = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsQualityCheck = new System.Windows.Forms.BindingSource(this.components);
            this.dsQualityCheck = new AppSvrHMI.L3DataSet();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.txtStoreAreaID = new System.Windows.Forms.ToolStripTextBox();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.txtMaterialID = new System.Windows.Forms.ToolStripTextBox();
            this.schemadsQualityCheck = new System.Data.DataTable();
            this.coldsQualityCheckL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableREASON = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableTest_Roll_Count = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableTest_Roll_Weight = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableSpileFlagDes = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTabletotalweight = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableback_flag = new System.Data.DataColumn();
            this.coldsQualityCheckL3DataTableback_date = new System.Data.DataColumn();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbStoreID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvQualityCheck = new System.Windows.Forms.DataGridView();
            this.dsStatus = new AppSvrHMI.L3DataSet();
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
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.cmdBloomFinish = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsSpileChangeSend = new AppSvrHMI.L3DataSet();
            this.schemadsSpileChangeSend = new System.Data.DataTable();
            this.coldsSpileChangeSendL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsSpileChangeSendL3DataTableREASON = new System.Data.DataColumn();
            this.dsOutStoreSend = new AppSvrHMI.L3DataSet();
            this.schemadsOutStoreSend = new System.Data.DataTable();
            this.coldsOutStoreSendL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableREASON = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableTarget = new System.Data.DataColumn();
            this.coldsOutStoreSendL3DataTableStroeAreaID = new System.Data.DataColumn();
            this.l3dbxGetStore = new AppSvrHMI.L3DataBox();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.qALEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpileFlagDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Roll_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test_Roll_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cURSECTIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qASTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualityCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQualityCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQualityCheck)).BeginInit();
            this.panel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvQualityCheck)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsSpileChangeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpileChangeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStoreSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOutStoreSend)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnQualityCheck,
            this.btnSpileChange,
            this.btnOutStore});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(940, 43);
            this.tSp1.TabIndex = 29;
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
            // btnQualityCheck
            // 
            this.Adapter.SetAccessRight(this.btnQualityCheck, "BloomStorebtnQualityCheck");
            this.btnQualityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnQualityCheck.Image")));
            this.btnQualityCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQualityCheck.Name = "btnQualityCheck";
            this.btnQualityCheck.Size = new System.Drawing.Size(65, 40);
            this.btnQualityCheck.Text = "抽检";
            this.btnQualityCheck.Click += new System.EventHandler(this.btnQualityCheck_Click);
            // 
            // btnSpileChange
            // 
            this.Adapter.SetAccessRight(this.btnSpileChange, "BloomStorebtnSpileChange");
            this.btnSpileChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSpileChange.Image")));
            this.btnSpileChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSpileChange.Name = "btnSpileChange";
            this.btnSpileChange.Size = new System.Drawing.Size(89, 40);
            this.btnSpileChange.Text = "垛位变更";
            this.btnSpileChange.Click += new System.EventHandler(this.btnSpileChange_Click);
            // 
            // btnOutStore
            // 
            this.Adapter.SetAccessRight(this.btnOutStore, "BloomStorebtnOutStore");
            this.btnOutStore.Image = ((System.Drawing.Image)(resources.GetObject("btnOutStore.Image")));
            this.btnOutStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutStore.Name = "btnOutStore";
            this.btnOutStore.Size = new System.Drawing.Size(65, 40);
            this.btnOutStore.Text = "出库";
            this.btnOutStore.Click += new System.EventHandler(this.btnOutStore_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BindingSource = this.bsQualityCheck;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnQuery,
            this.cmbStoreID,
            this.toolStripLabel1,
            this.txtMaterialID,
            this.toolStripLabel4,
            this.txtStoreAreaID});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(940, 25);
            this.bindingNavigator1.TabIndex = 33;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsQualityCheck
            // 
            this.bsQualityCheck.DataMember = "L3DataTable";
            this.bsQualityCheck.DataSource = this.dsQualityCheck;
            // 
            // dsQualityCheck
            // 
            this.dsQualityCheck.AutoSubscribe = true;
            this.dsQualityCheck.DataSetName = "L3DataSet";
            this.dsQualityCheck.DeleteMethod = "";
            this.dsQualityCheck.InsertMethod = "";
            this.dsQualityCheck.L3DataAdapter = null;
            this.dsQualityCheck.LoadEvent = "Click";
            this.dsQualityCheck.LoadTrigger = null;
            this.dsQualityCheck.RefreshValve = 1000;
            this.dsQualityCheck.SourceCommand = this.cmdQuery;
            this.dsQualityCheck.SourceCondition = null;
            this.dsQualityCheck.SourceMethod = "GetWillFinishBloom";
            this.dsQualityCheck.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsQualityCheck.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.dsQualityCheck.SubscribeTarget = null;
            this.dsQualityCheck.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsQualityCheck});
            this.dsQualityCheck.UpdateEvent = "Click";
            this.dsQualityCheck.UpdateMethod = "";
            this.dsQualityCheck.UpdateTrigger = null;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = null;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "GetWillFinishBloom";
            this.cmdQuery.Object = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.cmdQuery.Parameters.Add(this.l3CommandParameter3);
            this.cmdQuery.Parameters.Add(this.l3CommandParameter4);
            this.cmdQuery.ReturnTarget = null;
            this.cmdQuery.ReturnTargetProperty = null;
            this.cmdQuery.Trigger = null;
            this.cmdQuery.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.txtStoreAreaID;
            this.l3CommandParameter3.SourceProperty = "Text";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // txtStoreAreaID
            // 
            this.txtStoreAreaID.Name = "txtStoreAreaID";
            this.txtStoreAreaID.Size = new System.Drawing.Size(100, 25);
            this.txtStoreAreaID.Visible = false;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.txtMaterialID;
            this.l3CommandParameter4.SourceProperty = "Text";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtMaterialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(100, 25);
            // 
            // schemadsQualityCheck
            // 
            this.schemadsQualityCheck.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsQualityCheckL3DataTableMATERIALID,
            this.coldsQualityCheckL3DataTableSTATUS,
            this.coldsQualityCheckL3DataTablePOSITION,
            this.coldsQualityCheckL3DataTableQASTATUS,
            this.coldsQualityCheckL3DataTableQALEVEL,
            this.coldsQualityCheckL3DataTableORDERCONTRACTID,
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID,
            this.coldsQualityCheckL3DataTableSALESCONTRACTID,
            this.coldsQualityCheckL3DataTableCASTERID,
            this.coldsQualityCheckL3DataTableCASTING_NO,
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT,
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX,
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX,
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX,
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsQualityCheckL3DataTableLENGTH,
            this.coldsQualityCheckL3DataTableWIDTH,
            this.coldsQualityCheckL3DataTableTHICKNESS,
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID,
            this.coldsQualityCheckL3DataTableCUR_PILE_ID,
            this.coldsQualityCheckL3DataTableCUR_LAYER_ID,
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID,
            this.coldsQualityCheckL3DataTableCUR_BAY_ID,
            this.coldsQualityCheckL3DataTableDESTINATION,
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG,
            this.coldsQualityCheckL3DataTablePROCESS_TYPE,
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID,
            this.coldsQualityCheckL3DataTablePRODUCE_DATE,
            this.coldsQualityCheckL3DataTableFINISH_FLAG,
            this.coldsQualityCheckL3DataTableFINISHEDTIME,
            this.coldsQualityCheckL3DataTableBLOOM_COUNT,
            this.coldsQualityCheckL3DataTableCAL_WEIGHT,
            this.coldsQualityCheckL3DataTableRIGHT_COUNT,
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT,
            this.coldsQualityCheckL3DataTableWASTER_COUNT,
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT,
            this.coldsQualityCheckL3DataTableWASTER_COUNT1,
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1,
            this.coldsQualityCheckL3DataTableWASTER_REASON1,
            this.coldsQualityCheckL3DataTableWASTER_COUNT2,
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2,
            this.coldsQualityCheckL3DataTableWASTER_REASON2,
            this.coldsQualityCheckL3DataTableWASTER_COUNT3,
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3,
            this.coldsQualityCheckL3DataTableWASTER_REASON3,
            this.coldsQualityCheckL3DataTableWRONG_COUNT,
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT,
            this.coldsQualityCheckL3DataTableWRONG_COUNT1,
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1,
            this.coldsQualityCheckL3DataTableWRONG_REASON1,
            this.coldsQualityCheckL3DataTableWRONG_COUNT2,
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2,
            this.coldsQualityCheckL3DataTableWRONG_REASON2,
            this.coldsQualityCheckL3DataTableWRONG_COUNT3,
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3,
            this.coldsQualityCheckL3DataTableWRONG_REASON3,
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES,
            this.coldsQualityCheckL3DataTableREASON,
            this.coldsQualityCheckL3DataTableCheckFlag,
            this.coldsQualityCheckL3DataTableTest_Roll_Count,
            this.coldsQualityCheckL3DataTableTest_Roll_Weight,
            this.coldsQualityCheckL3DataTableSpileFlagDes,
            this.coldsQualityCheckL3DataTabletotalweight,
            this.coldsQualityCheckL3DataTableback_flag,
            this.coldsQualityCheckL3DataTableback_date});
            this.schemadsQualityCheck.TableName = "L3DataTable";
            // 
            // coldsQualityCheckL3DataTableMATERIALID
            // 
            this.coldsQualityCheckL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsQualityCheckL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsQualityCheckL3DataTableMATERIALID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableSTATUS
            // 
            this.coldsQualityCheckL3DataTableSTATUS.Caption = "STATUS";
            this.coldsQualityCheckL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsQualityCheckL3DataTableSTATUS.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableSTATUS.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableSTATUS.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePOSITION
            // 
            this.coldsQualityCheckL3DataTablePOSITION.Caption = "POSITION";
            this.coldsQualityCheckL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsQualityCheckL3DataTablePOSITION.DefaultValue = "";
            this.coldsQualityCheckL3DataTablePOSITION.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableQASTATUS
            // 
            this.coldsQualityCheckL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsQualityCheckL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsQualityCheckL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableQALEVEL
            // 
            this.coldsQualityCheckL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsQualityCheckL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsQualityCheckL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableORDERCONTRACTID
            // 
            this.coldsQualityCheckL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsQualityCheckL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsQualityCheckL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePRODUCECONTRACTID
            // 
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsQualityCheckL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableSALESCONTRACTID
            // 
            this.coldsQualityCheckL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsQualityCheckL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsQualityCheckL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCASTERID
            // 
            this.coldsQualityCheckL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsQualityCheckL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsQualityCheckL3DataTableCASTERID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCASTERID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCASTING_NO
            // 
            this.coldsQualityCheckL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsQualityCheckL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsQualityCheckL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableSTEELGRADEINDEX
            // 
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsQualityCheckL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableLENGTH
            // 
            this.coldsQualityCheckL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsQualityCheckL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsQualityCheckL3DataTableLENGTH.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableLENGTH.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableLENGTH.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWIDTH
            // 
            this.coldsQualityCheckL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsQualityCheckL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsQualityCheckL3DataTableWIDTH.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableWIDTH.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableWIDTH.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableTHICKNESS
            // 
            this.coldsQualityCheckL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsQualityCheckL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsQualityCheckL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUR_SECTION_ID
            // 
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUR_PILE_ID
            // 
            this.coldsQualityCheckL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsQualityCheckL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsQualityCheckL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUR_LAYER_ID
            // 
            this.coldsQualityCheckL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsQualityCheckL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsQualityCheckL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUR_SEQ_ID
            // 
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCUR_BAY_ID
            // 
            this.coldsQualityCheckL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsQualityCheckL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsQualityCheckL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsQualityCheckL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableDESTINATION
            // 
            this.coldsQualityCheckL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsQualityCheckL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsQualityCheckL3DataTableDESTINATION.DefaultValue = "";
            this.coldsQualityCheckL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableHOT_SEND_FLAG
            // 
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePROCESS_TYPE
            // 
            this.coldsQualityCheckL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsQualityCheckL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsQualityCheckL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsQualityCheckL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsQualityCheckL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePLAN_ORD_ID
            // 
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsQualityCheckL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsQualityCheckL3DataTablePRODUCE_DATE
            // 
            this.coldsQualityCheckL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsQualityCheckL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsQualityCheckL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsQualityCheckL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableFINISH_FLAG
            // 
            this.coldsQualityCheckL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsQualityCheckL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsQualityCheckL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableFINISHEDTIME
            // 
            this.coldsQualityCheckL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsQualityCheckL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsQualityCheckL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsQualityCheckL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableBLOOM_COUNT
            // 
            this.coldsQualityCheckL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsQualityCheckL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsQualityCheckL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCAL_WEIGHT
            // 
            this.coldsQualityCheckL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsQualityCheckL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsQualityCheckL3DataTableCAL_WEIGHT.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableRIGHT_COUNT
            // 
            this.coldsQualityCheckL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsQualityCheckL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsQualityCheckL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsQualityCheckL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsQualityCheckL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableRIGHT_WEIGHT
            // 
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_COUNT
            // 
            this.coldsQualityCheckL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsQualityCheckL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsQualityCheckL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_WEIGHT
            // 
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_COUNT1
            // 
            this.coldsQualityCheckL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsQualityCheckL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsQualityCheckL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_WEIGHT1
            // 
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_REASON1
            // 
            this.coldsQualityCheckL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsQualityCheckL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsQualityCheckL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_COUNT2
            // 
            this.coldsQualityCheckL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsQualityCheckL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsQualityCheckL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_WEIGHT2
            // 
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_REASON2
            // 
            this.coldsQualityCheckL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsQualityCheckL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsQualityCheckL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_COUNT3
            // 
            this.coldsQualityCheckL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsQualityCheckL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsQualityCheckL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_WEIGHT3
            // 
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWASTER_REASON3
            // 
            this.coldsQualityCheckL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsQualityCheckL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsQualityCheckL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_COUNT
            // 
            this.coldsQualityCheckL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsQualityCheckL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsQualityCheckL3DataTableWRONG_COUNT.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_WEIGHT
            // 
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_COUNT1
            // 
            this.coldsQualityCheckL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsQualityCheckL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsQualityCheckL3DataTableWRONG_COUNT1.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_WEIGHT1
            // 
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_REASON1
            // 
            this.coldsQualityCheckL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsQualityCheckL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsQualityCheckL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_COUNT2
            // 
            this.coldsQualityCheckL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsQualityCheckL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsQualityCheckL3DataTableWRONG_COUNT2.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_WEIGHT2
            // 
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_REASON2
            // 
            this.coldsQualityCheckL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsQualityCheckL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsQualityCheckL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_COUNT3
            // 
            this.coldsQualityCheckL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsQualityCheckL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsQualityCheckL3DataTableWRONG_COUNT3.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_WEIGHT3
            // 
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3.DefaultValue = "0";
            this.coldsQualityCheckL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableWRONG_REASON3
            // 
            this.coldsQualityCheckL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsQualityCheckL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsQualityCheckL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsQualityCheckL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableSUFACEDEFACTDES
            // 
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsQualityCheckL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableREASON
            // 
            this.coldsQualityCheckL3DataTableREASON.Caption = "REASON";
            this.coldsQualityCheckL3DataTableREASON.ColumnName = "REASON";
            this.coldsQualityCheckL3DataTableREASON.DefaultValue = "";
            this.coldsQualityCheckL3DataTableREASON.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableCheckFlag
            // 
            this.coldsQualityCheckL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsQualityCheckL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsQualityCheckL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsQualityCheckL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableTest_Roll_Count
            // 
            this.coldsQualityCheckL3DataTableTest_Roll_Count.Caption = "Test_Roll_Count";
            this.coldsQualityCheckL3DataTableTest_Roll_Count.ColumnName = "Test_Roll_Count";
            this.coldsQualityCheckL3DataTableTest_Roll_Count.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableTest_Roll_Weight
            // 
            this.coldsQualityCheckL3DataTableTest_Roll_Weight.Caption = "Test_Roll_Weight";
            this.coldsQualityCheckL3DataTableTest_Roll_Weight.ColumnName = "Test_Roll_Weight";
            this.coldsQualityCheckL3DataTableTest_Roll_Weight.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableSpileFlagDes
            // 
            this.coldsQualityCheckL3DataTableSpileFlagDes.Caption = "SpileFlagDes";
            this.coldsQualityCheckL3DataTableSpileFlagDes.ColumnName = "SpileFlagDes";
            this.coldsQualityCheckL3DataTableSpileFlagDes.Namespace = "";
            // 
            // coldsQualityCheckL3DataTabletotalweight
            // 
            this.coldsQualityCheckL3DataTabletotalweight.Caption = "totalweight";
            this.coldsQualityCheckL3DataTabletotalweight.ColumnName = "totalweight";
            this.coldsQualityCheckL3DataTabletotalweight.DataType = typeof(double);
            this.coldsQualityCheckL3DataTabletotalweight.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableback_flag
            // 
            this.coldsQualityCheckL3DataTableback_flag.Caption = "back_flag";
            this.coldsQualityCheckL3DataTableback_flag.ColumnName = "back_flag";
            this.coldsQualityCheckL3DataTableback_flag.Namespace = "";
            // 
            // coldsQualityCheckL3DataTableback_date
            // 
            this.coldsQualityCheckL3DataTableback_date.Caption = "back_date";
            this.coldsQualityCheckL3DataTableback_date.ColumnName = "back_date";
            this.coldsQualityCheckL3DataTableback_date.DataType = typeof(System.DateTime);
            this.coldsQualityCheckL3DataTableback_date.Namespace = "";
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hmiRootPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 393);
            this.panel1.TabIndex = 34;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvQualityCheck);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(940, 393);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvQualityCheck
            // 
            this.dvQualityCheck.AllowUserToAddRows = false;
            this.dvQualityCheck.AutoGenerateColumns = false;
            this.dvQualityCheck.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvQualityCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.qALEVELDataGridViewTextBoxColumn,
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn,
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn,
            this.sALESCONTRACTIDDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.SpileFlagDes,
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
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn,
            this.Test_Roll_Count,
            this.Test_Roll_Weight,
            this.rEASONDataGridViewTextBoxColumn,
            this.cURSECTIONIDDataGridViewTextBoxColumn,
            this.qASTATUSDataGridViewTextBoxColumn,
            this.back_flag,
            this.back_date});
            this.dvQualityCheck.DataSource = this.bsQualityCheck;
            this.dvQualityCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvQualityCheck.Location = new System.Drawing.Point(0, 0);
            this.dvQualityCheck.Name = "dvQualityCheck";
            this.dvQualityCheck.RowHeadersVisible = false;
            this.dvQualityCheck.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvQualityCheck.RowTemplate.Height = 23;
            this.dvQualityCheck.Size = new System.Drawing.Size(940, 393);
            this.dvQualityCheck.TabIndex = 1;
            this.dvQualityCheck.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvQualityCheck_DataError);
            // 
            // dsStatus
            // 
            this.dsStatus.AutoSubscribe = true;
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
            this.dsStoreAreaID.AutoSubscribe = true;
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
            this.dsSpile.AutoSubscribe = true;
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
            this.dsWasterReason.AutoSubscribe = true;
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
            this.dsWrongReason.AutoSubscribe = true;
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
            this.dsOffLineReason.AutoSubscribe = true;
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
            // cmdBloomFinish
            // 
            this.cmdBloomFinish.Adapter = this.Adapter;
            this.cmdBloomFinish.MergeReturnTarget = false;
            this.cmdBloomFinish.Method = "BloomFinish";
            this.cmdBloomFinish.Object = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.cmdBloomFinish.Parameters.Add(this.l3CommandParameter2);
            this.cmdBloomFinish.ReturnTarget = null;
            this.cmdBloomFinish.ReturnTargetProperty = null;
            this.cmdBloomFinish.Trigger = null;
            this.cmdBloomFinish.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsQualityCheck;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsSpileChangeSend
            // 
            this.dsSpileChangeSend.AutoSubscribe = true;
            this.dsSpileChangeSend.DataSetName = "L3DataSet";
            this.dsSpileChangeSend.DeleteMethod = "";
            this.dsSpileChangeSend.InsertMethod = "";
            this.dsSpileChangeSend.L3DataAdapter = this.Adapter;
            this.dsSpileChangeSend.LoadEvent = "Click";
            this.dsSpileChangeSend.LoadTrigger = null;
            this.dsSpileChangeSend.RefreshValve = 1000;
            this.dsSpileChangeSend.SourceCommand = null;
            this.dsSpileChangeSend.SourceCondition = "";
            this.dsSpileChangeSend.SourceMethod = "";
            this.dsSpileChangeSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsSpileChangeSend.SourceURI = "";
            this.dsSpileChangeSend.SubscribeTarget = "Version";
            this.dsSpileChangeSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSpileChangeSend});
            this.dsSpileChangeSend.UpdateEvent = "Click";
            this.dsSpileChangeSend.UpdateMethod = "";
            this.dsSpileChangeSend.UpdateTrigger = null;
            // 
            // schemadsSpileChangeSend
            // 
            this.schemadsSpileChangeSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSpileChangeSendL3DataTableMATERIALID,
            this.coldsSpileChangeSendL3DataTableSTATUS,
            this.coldsSpileChangeSendL3DataTablePOSITION,
            this.coldsSpileChangeSendL3DataTableQASTATUS,
            this.coldsSpileChangeSendL3DataTableQALEVEL,
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID,
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID,
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID,
            this.coldsSpileChangeSendL3DataTableCASTERID,
            this.coldsSpileChangeSendL3DataTableCASTING_NO,
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT,
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX,
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX,
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX,
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsSpileChangeSendL3DataTableLENGTH,
            this.coldsSpileChangeSendL3DataTableWIDTH,
            this.coldsSpileChangeSendL3DataTableTHICKNESS,
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID,
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID,
            this.coldsSpileChangeSendL3DataTableCUR_LAYER_ID,
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID,
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID,
            this.coldsSpileChangeSendL3DataTableDESTINATION,
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG,
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE,
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID,
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE,
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG,
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME,
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT,
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT,
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT,
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT,
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT,
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT,
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT1,
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1,
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1,
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT2,
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2,
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2,
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT3,
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3,
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3,
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT,
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT,
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1,
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1,
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1,
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2,
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2,
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2,
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3,
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3,
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3,
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES,
            this.coldsSpileChangeSendL3DataTableREASON});
            this.schemadsSpileChangeSend.TableName = "L3DataTable";
            // 
            // coldsSpileChangeSendL3DataTableMATERIALID
            // 
            this.coldsSpileChangeSendL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsSpileChangeSendL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsSpileChangeSendL3DataTableMATERIALID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableSTATUS
            // 
            this.coldsSpileChangeSendL3DataTableSTATUS.Caption = "STATUS";
            this.coldsSpileChangeSendL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsSpileChangeSendL3DataTableSTATUS.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableSTATUS.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableSTATUS.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePOSITION
            // 
            this.coldsSpileChangeSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsSpileChangeSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsSpileChangeSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableQASTATUS
            // 
            this.coldsSpileChangeSendL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsSpileChangeSendL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsSpileChangeSendL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableQALEVEL
            // 
            this.coldsSpileChangeSendL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsSpileChangeSendL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsSpileChangeSendL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableORDERCONTRACTID
            // 
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePRODUCECONTRACTID
            // 
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableSALESCONTRACTID
            // 
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCASTERID
            // 
            this.coldsSpileChangeSendL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsSpileChangeSendL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsSpileChangeSendL3DataTableCASTERID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCASTERID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCASTING_NO
            // 
            this.coldsSpileChangeSendL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsSpileChangeSendL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsSpileChangeSendL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableSTEELGRADEINDEX
            // 
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableLENGTH
            // 
            this.coldsSpileChangeSendL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsSpileChangeSendL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsSpileChangeSendL3DataTableLENGTH.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableLENGTH.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableLENGTH.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWIDTH
            // 
            this.coldsSpileChangeSendL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsSpileChangeSendL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsSpileChangeSendL3DataTableWIDTH.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableWIDTH.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableWIDTH.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableTHICKNESS
            // 
            this.coldsSpileChangeSendL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsSpileChangeSendL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsSpileChangeSendL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUR_SECTION_ID
            // 
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUR_PILE_ID
            // 
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUR_LAYER_ID
            // 
            this.coldsSpileChangeSendL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsSpileChangeSendL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsSpileChangeSendL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUR_SEQ_ID
            // 
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCUR_BAY_ID
            // 
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableDESTINATION
            // 
            this.coldsSpileChangeSendL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsSpileChangeSendL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsSpileChangeSendL3DataTableDESTINATION.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableHOT_SEND_FLAG
            // 
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePROCESS_TYPE
            // 
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePLAN_ORD_ID
            // 
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTablePRODUCE_DATE
            // 
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsSpileChangeSendL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableFINISH_FLAG
            // 
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableFINISHEDTIME
            // 
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsSpileChangeSendL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableBLOOM_COUNT
            // 
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableCAL_WEIGHT
            // 
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableRIGHT_COUNT
            // 
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableRIGHT_WEIGHT
            // 
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_COUNT
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_WEIGHT
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_COUNT1
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_WEIGHT1
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_REASON1
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_COUNT2
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_WEIGHT2
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_REASON2
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_COUNT3
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsSpileChangeSendL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_WEIGHT3
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWASTER_REASON3
            // 
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_COUNT
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_WEIGHT
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_COUNT1
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_WEIGHT1
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_REASON1
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_COUNT2
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_WEIGHT2
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_REASON2
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_COUNT3
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coldsSpileChangeSendL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_WEIGHT3
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3.DefaultValue = "0";
            this.coldsSpileChangeSendL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableWRONG_REASON3
            // 
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableSUFACEDEFACTDES
            // 
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsSpileChangeSendL3DataTableREASON
            // 
            this.coldsSpileChangeSendL3DataTableREASON.Caption = "REASON";
            this.coldsSpileChangeSendL3DataTableREASON.ColumnName = "REASON";
            this.coldsSpileChangeSendL3DataTableREASON.DefaultValue = "";
            this.coldsSpileChangeSendL3DataTableREASON.Namespace = "";
            // 
            // dsOutStoreSend
            // 
            this.dsOutStoreSend.AutoSubscribe = true;
            this.dsOutStoreSend.DataSetName = "L3DataSet";
            this.dsOutStoreSend.DeleteMethod = "";
            this.dsOutStoreSend.InsertMethod = "";
            this.dsOutStoreSend.L3DataAdapter = null;
            this.dsOutStoreSend.LoadEvent = "Click";
            this.dsOutStoreSend.LoadTrigger = null;
            this.dsOutStoreSend.RefreshValve = 1000;
            this.dsOutStoreSend.SourceCommand = null;
            this.dsOutStoreSend.SourceCondition = null;
            this.dsOutStoreSend.SourceMethod = "GetWillFinishBloom";
            this.dsOutStoreSend.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsOutStoreSend.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.dsOutStoreSend.SubscribeTarget = null;
            this.dsOutStoreSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOutStoreSend});
            this.dsOutStoreSend.UpdateEvent = "Click";
            this.dsOutStoreSend.UpdateMethod = "";
            this.dsOutStoreSend.UpdateTrigger = null;
            // 
            // schemadsOutStoreSend
            // 
            this.schemadsOutStoreSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOutStoreSendL3DataTableMATERIALID,
            this.coldsOutStoreSendL3DataTableSTATUS,
            this.coldsOutStoreSendL3DataTablePOSITION,
            this.coldsOutStoreSendL3DataTableQASTATUS,
            this.coldsOutStoreSendL3DataTableQALEVEL,
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID,
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID,
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID,
            this.coldsOutStoreSendL3DataTableCASTERID,
            this.coldsOutStoreSendL3DataTableCASTING_NO,
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT,
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX,
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX,
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX,
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsOutStoreSendL3DataTableLENGTH,
            this.coldsOutStoreSendL3DataTableWIDTH,
            this.coldsOutStoreSendL3DataTableTHICKNESS,
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID,
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID,
            this.coldsOutStoreSendL3DataTableCUR_LAYER_ID,
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID,
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID,
            this.coldsOutStoreSendL3DataTableDESTINATION,
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG,
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE,
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID,
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE,
            this.coldsOutStoreSendL3DataTableFINISH_FLAG,
            this.coldsOutStoreSendL3DataTableFINISHEDTIME,
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT,
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT,
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT,
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT,
            this.coldsOutStoreSendL3DataTableWASTER_COUNT,
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT,
            this.coldsOutStoreSendL3DataTableWASTER_COUNT1,
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1,
            this.coldsOutStoreSendL3DataTableWASTER_REASON1,
            this.coldsOutStoreSendL3DataTableWASTER_COUNT2,
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2,
            this.coldsOutStoreSendL3DataTableWASTER_REASON2,
            this.coldsOutStoreSendL3DataTableWASTER_COUNT3,
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3,
            this.coldsOutStoreSendL3DataTableWASTER_REASON3,
            this.coldsOutStoreSendL3DataTableWRONG_COUNT,
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT,
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1,
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1,
            this.coldsOutStoreSendL3DataTableWRONG_REASON1,
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2,
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2,
            this.coldsOutStoreSendL3DataTableWRONG_REASON2,
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3,
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3,
            this.coldsOutStoreSendL3DataTableWRONG_REASON3,
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES,
            this.coldsOutStoreSendL3DataTableREASON,
            this.coldsOutStoreSendL3DataTableTarget,
            this.coldsOutStoreSendL3DataTableStroeAreaID});
            this.schemadsOutStoreSend.TableName = "L3DataTable";
            // 
            // coldsOutStoreSendL3DataTableMATERIALID
            // 
            this.coldsOutStoreSendL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsOutStoreSendL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsOutStoreSendL3DataTableMATERIALID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableSTATUS
            // 
            this.coldsOutStoreSendL3DataTableSTATUS.Caption = "STATUS";
            this.coldsOutStoreSendL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsOutStoreSendL3DataTableSTATUS.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableSTATUS.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableSTATUS.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePOSITION
            // 
            this.coldsOutStoreSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsOutStoreSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsOutStoreSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsOutStoreSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableQASTATUS
            // 
            this.coldsOutStoreSendL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsOutStoreSendL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsOutStoreSendL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableQALEVEL
            // 
            this.coldsOutStoreSendL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsOutStoreSendL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsOutStoreSendL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableORDERCONTRACTID
            // 
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePRODUCECONTRACTID
            // 
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableSALESCONTRACTID
            // 
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCASTERID
            // 
            this.coldsOutStoreSendL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsOutStoreSendL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsOutStoreSendL3DataTableCASTERID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCASTERID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCASTING_NO
            // 
            this.coldsOutStoreSendL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsOutStoreSendL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsOutStoreSendL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableSTEELGRADEINDEX
            // 
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableLENGTH
            // 
            this.coldsOutStoreSendL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsOutStoreSendL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsOutStoreSendL3DataTableLENGTH.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableLENGTH.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableLENGTH.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWIDTH
            // 
            this.coldsOutStoreSendL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsOutStoreSendL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsOutStoreSendL3DataTableWIDTH.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableWIDTH.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableWIDTH.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableTHICKNESS
            // 
            this.coldsOutStoreSendL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsOutStoreSendL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsOutStoreSendL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUR_SECTION_ID
            // 
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUR_PILE_ID
            // 
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUR_LAYER_ID
            // 
            this.coldsOutStoreSendL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsOutStoreSendL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsOutStoreSendL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUR_SEQ_ID
            // 
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCUR_BAY_ID
            // 
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableDESTINATION
            // 
            this.coldsOutStoreSendL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsOutStoreSendL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsOutStoreSendL3DataTableDESTINATION.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableHOT_SEND_FLAG
            // 
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePROCESS_TYPE
            // 
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePLAN_ORD_ID
            // 
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsOutStoreSendL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTablePRODUCE_DATE
            // 
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsOutStoreSendL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableFINISH_FLAG
            // 
            this.coldsOutStoreSendL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsOutStoreSendL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsOutStoreSendL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableFINISHEDTIME
            // 
            this.coldsOutStoreSendL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsOutStoreSendL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsOutStoreSendL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsOutStoreSendL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableBLOOM_COUNT
            // 
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableCAL_WEIGHT
            // 
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableRIGHT_COUNT
            // 
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableRIGHT_WEIGHT
            // 
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_COUNT
            // 
            this.coldsOutStoreSendL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_WEIGHT
            // 
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_COUNT1
            // 
            this.coldsOutStoreSendL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_WEIGHT1
            // 
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_REASON1
            // 
            this.coldsOutStoreSendL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsOutStoreSendL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsOutStoreSendL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_COUNT2
            // 
            this.coldsOutStoreSendL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_WEIGHT2
            // 
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_REASON2
            // 
            this.coldsOutStoreSendL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsOutStoreSendL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsOutStoreSendL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_COUNT3
            // 
            this.coldsOutStoreSendL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsOutStoreSendL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_WEIGHT3
            // 
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWASTER_REASON3
            // 
            this.coldsOutStoreSendL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsOutStoreSendL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsOutStoreSendL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_COUNT
            // 
            this.coldsOutStoreSendL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_WEIGHT
            // 
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_COUNT1
            // 
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_WEIGHT1
            // 
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_REASON1
            // 
            this.coldsOutStoreSendL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsOutStoreSendL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsOutStoreSendL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_COUNT2
            // 
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_WEIGHT2
            // 
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_REASON2
            // 
            this.coldsOutStoreSendL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsOutStoreSendL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsOutStoreSendL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_COUNT3
            // 
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coldsOutStoreSendL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_WEIGHT3
            // 
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3.DefaultValue = "0";
            this.coldsOutStoreSendL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableWRONG_REASON3
            // 
            this.coldsOutStoreSendL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsOutStoreSendL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsOutStoreSendL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableSUFACEDEFACTDES
            // 
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableREASON
            // 
            this.coldsOutStoreSendL3DataTableREASON.Caption = "REASON";
            this.coldsOutStoreSendL3DataTableREASON.ColumnName = "REASON";
            this.coldsOutStoreSendL3DataTableREASON.DefaultValue = "";
            this.coldsOutStoreSendL3DataTableREASON.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableTarget
            // 
            this.coldsOutStoreSendL3DataTableTarget.Caption = "Target";
            this.coldsOutStoreSendL3DataTableTarget.ColumnName = "Target";
            this.coldsOutStoreSendL3DataTableTarget.Namespace = "";
            // 
            // coldsOutStoreSendL3DataTableStroeAreaID
            // 
            this.coldsOutStoreSendL3DataTableStroeAreaID.Caption = "StroeAreaID";
            this.coldsOutStoreSendL3DataTableStroeAreaID.ColumnName = "StroeAreaID";
            this.coldsOutStoreSendL3DataTableStroeAreaID.Namespace = "";
            // 
            // l3dbxGetStore
            // 
            this.l3dbxGetStore.DataFormat = null;
            this.l3dbxGetStore.DataObject = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.l3dbxGetStore.DataProperty = "MaterialInputted";
            this.l3dbxGetStore.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3dbxGetStore.L3DataAdapter = this.Adapter;
            this.l3dbxGetStore.Location = new System.Drawing.Point(268, 12);
            this.l3dbxGetStore.Name = "l3dbxGetStore";
            this.l3dbxGetStore.Size = new System.Drawing.Size(100, 21);
            this.l3dbxGetStore.TabIndex = 34;
            this.l3dbxGetStore.Value = null;
            this.l3dbxGetStore.Visible = false;
            this.l3dbxGetStore.TextChanged += new System.EventHandler(this.l3dbxGetStore_TextChanged);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn.Width = 54;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.Frozen = true;
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.sTATUSDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTATUSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // qALEVELDataGridViewTextBoxColumn
            // 
            this.qALEVELDataGridViewTextBoxColumn.DataPropertyName = "QALEVEL";
            this.qALEVELDataGridViewTextBoxColumn.HeaderText = "质量级别";
            this.qALEVELDataGridViewTextBoxColumn.Name = "qALEVELDataGridViewTextBoxColumn";
            this.qALEVELDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERCONTRACTID";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "采购合同号";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Name = "oRDERCONTRACTIDDataGridViewTextBoxColumn";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUCECONTRACTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCECONTRACTID";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.HeaderText = "生产合同号";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Name = "pRODUCECONTRACTIDDataGridViewTextBoxColumn";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sALESCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "SALESCONTRACTID";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "销售合同号";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Name = "sALESCONTRACTIDDataGridViewTextBoxColumn";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            // 
            // SpileFlagDes
            // 
            this.SpileFlagDes.DataPropertyName = "SpileFlagDes";
            this.SpileFlagDes.HeaderText = "上垛标志描述";
            this.SpileFlagDes.Name = "SpileFlagDes";
            // 
            // cASTINGNODataGridViewTextBoxColumn
            // 
            this.cASTINGNODataGridViewTextBoxColumn.DataPropertyName = "CASTING_NO";
            this.cASTINGNODataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.cASTINGNODataGridViewTextBoxColumn.Name = "cASTINGNODataGridViewTextBoxColumn";
            // 
            // cASTINGHEATCNTDataGridViewTextBoxColumn
            // 
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.DataPropertyName = "CASTING_HEAT_CNT";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Name = "cASTINGHEATCNTDataGridViewTextBoxColumn";
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // cUTSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "CUT_STEELGRADEINDEX";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "cUTSTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // fINALSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "FINAL_STEELGRADEINDEX";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "fINALSTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsStoreAreaID;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "库区";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
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
            this.cURPILEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cURPILEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cURPILEIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURLAYERIDDataGridViewTextBoxColumn
            // 
            this.cURLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_LAYER_ID";
            this.cURLAYERIDDataGridViewTextBoxColumn.HeaderText = "当前层";
            this.cURLAYERIDDataGridViewTextBoxColumn.Name = "cURLAYERIDDataGridViewTextBoxColumn";
            // 
            // cURSEQIDDataGridViewTextBoxColumn
            // 
            this.cURSEQIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SEQ_ID";
            this.cURSEQIDDataGridViewTextBoxColumn.HeaderText = "当前顺序";
            this.cURSEQIDDataGridViewTextBoxColumn.Name = "cURSEQIDDataGridViewTextBoxColumn";
            // 
            // cURBAYIDDataGridViewTextBoxColumn
            // 
            this.cURBAYIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_BAY_ID";
            this.cURBAYIDDataGridViewTextBoxColumn.HeaderText = "当前跨";
            this.cURBAYIDDataGridViewTextBoxColumn.Name = "cURBAYIDDataGridViewTextBoxColumn";
            // 
            // dESTINATIONDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.HeaderText = "去向";
            this.dESTINATIONDataGridViewTextBoxColumn.Name = "dESTINATIONDataGridViewTextBoxColumn";
            // 
            // hOTSENDFLAGDataGridViewTextBoxColumn
            // 
            this.hOTSENDFLAGDataGridViewTextBoxColumn.DataPropertyName = "HOT_SEND_FLAG";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Name = "hOTSENDFLAGDataGridViewTextBoxColumn";
            // 
            // pROCESSTYPEDataGridViewTextBoxColumn
            // 
            this.pROCESSTYPEDataGridViewTextBoxColumn.DataPropertyName = "PROCESS_TYPE";
            this.pROCESSTYPEDataGridViewTextBoxColumn.HeaderText = "处置方式";
            this.pROCESSTYPEDataGridViewTextBoxColumn.Name = "pROCESSTYPEDataGridViewTextBoxColumn";
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            // 
            // pRODUCEDATEDataGridViewTextBoxColumn
            // 
            this.pRODUCEDATEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCE_DATE";
            this.pRODUCEDATEDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.pRODUCEDATEDataGridViewTextBoxColumn.Name = "pRODUCEDATEDataGridViewTextBoxColumn";
            // 
            // fINISHFLAGDataGridViewTextBoxColumn
            // 
            this.fINISHFLAGDataGridViewTextBoxColumn.DataPropertyName = "FINISH_FLAG";
            this.fINISHFLAGDataGridViewTextBoxColumn.HeaderText = "质量抽检标志";
            this.fINISHFLAGDataGridViewTextBoxColumn.Name = "fINISHFLAGDataGridViewTextBoxColumn";
            // 
            // fINISHEDTIMEDataGridViewTextBoxColumn
            // 
            this.fINISHEDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FINISHEDTIME";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.HeaderText = "质量抽检时间";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.Name = "fINISHEDTIMEDataGridViewTextBoxColumn";
            // 
            // bLOOMCOUNTDataGridViewTextBoxColumn
            // 
            this.bLOOMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "BLOOM_COUNT";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Name = "bLOOMCOUNTDataGridViewTextBoxColumn";
            // 
            // totalweight
            // 
            this.totalweight.DataPropertyName = "totalweight";
            this.totalweight.HeaderText = "出坯总重量[t]";
            this.totalweight.Name = "totalweight";
            // 
            // cALWEIGHTDataGridViewTextBoxColumn
            // 
            this.cALWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "CAL_WEIGHT";
            this.cALWEIGHTDataGridViewTextBoxColumn.HeaderText = "理论重量[t]";
            this.cALWEIGHTDataGridViewTextBoxColumn.Name = "cALWEIGHTDataGridViewTextBoxColumn";
            // 
            // rIGHTCOUNTDataGridViewTextBoxColumn
            // 
            this.rIGHTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_COUNT";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Name = "rIGHTCOUNTDataGridViewTextBoxColumn";
            // 
            // rIGHTWEIGHTDataGridViewTextBoxColumn
            // 
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_WEIGHT";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.HeaderText = "合格钢坯重量[t]";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Name = "rIGHTWEIGHTDataGridViewTextBoxColumn";
            // 
            // wASTERCOUNTDataGridViewTextBoxColumn
            // 
            this.wASTERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT";
            this.wASTERCOUNTDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总长度";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Name = "wASTERCOUNTDataGridViewTextBoxColumn";
            // 
            // wASTERWEIGHTDataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.HeaderText = "甩废重量[t]";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Name = "wASTERWEIGHTDataGridViewTextBoxColumn";
            // 
            // wASTERCOUNT1DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Name = "wASTERCOUNT1DataGridViewTextBoxColumn";
            // 
            // wASTERWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.HeaderText = "甩废重量1[t]";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Name = "wASTERWEIGHT1DataGridViewTextBoxColumn";
            // 
            // wASTERREASON1DataGridViewTextBoxColumn
            // 
            this.wASTERREASON1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON1";
            this.wASTERREASON1DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wASTERREASON1DataGridViewTextBoxColumn.Name = "wASTERREASON1DataGridViewTextBoxColumn";
            this.wASTERREASON1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wASTERCOUNT2DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Name = "wASTERCOUNT2DataGridViewTextBoxColumn";
            // 
            // wASTERWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.HeaderText = "甩废重量2[t]";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Name = "wASTERWEIGHT2DataGridViewTextBoxColumn";
            // 
            // wASTERREASON2DataGridViewTextBoxColumn
            // 
            this.wASTERREASON2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON2";
            this.wASTERREASON2DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wASTERREASON2DataGridViewTextBoxColumn.Name = "wASTERREASON2DataGridViewTextBoxColumn";
            this.wASTERREASON2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wASTERCOUNT3DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.HeaderText = "甩废钢坯长度3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Name = "wASTERCOUNT3DataGridViewTextBoxColumn";
            // 
            // wASTERWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.HeaderText = "甩废重量3[t]";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Name = "wASTERWEIGHT3DataGridViewTextBoxColumn";
            // 
            // wASTERREASON3DataGridViewTextBoxColumn
            // 
            this.wASTERREASON3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON3";
            this.wASTERREASON3DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wASTERREASON3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wASTERREASON3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wASTERREASON3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wASTERREASON3DataGridViewTextBoxColumn.Name = "wASTERREASON3DataGridViewTextBoxColumn";
            this.wASTERREASON3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wASTERREASON3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wASTERREASON3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNTDataGridViewTextBoxColumn
            // 
            this.wRONGCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT";
            this.wRONGCOUNTDataGridViewTextBoxColumn.HeaderText = "不合格钢坯总支数";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Name = "wRONGCOUNTDataGridViewTextBoxColumn";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHTDataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.HeaderText = "不合格总重量[t]";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Name = "wRONGWEIGHTDataGridViewTextBoxColumn";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGCOUNT1DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Name = "wRONGCOUNT1DataGridViewTextBoxColumn";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT1";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.HeaderText = "不合格重量1[t]";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.Name = "wRONGWEIGHT1DataGridViewTextBoxColumn";
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
            this.wRONGREASON1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNT2DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Name = "wRONGCOUNT2DataGridViewTextBoxColumn";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT2";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.HeaderText = "不合格重量2[t]";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.Name = "wRONGWEIGHT2DataGridViewTextBoxColumn";
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
            this.wRONGREASON2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wRONGCOUNT3DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Name = "wRONGCOUNT3DataGridViewTextBoxColumn";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Width = 110;
            // 
            // wRONGWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT3";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.HeaderText = "不合格重量3[t]";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.Name = "wRONGWEIGHT3DataGridViewTextBoxColumn";
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
            this.wRONGREASON3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wRONGREASON3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wRONGREASON3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // sUFACEDEFACTDESDataGridViewTextBoxColumn
            // 
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.DataPropertyName = "SUFACEDEFACTDES";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.Name = "sUFACEDEFACTDESDataGridViewTextBoxColumn";
            // 
            // Test_Roll_Count
            // 
            this.Test_Roll_Count.DataPropertyName = "Test_Roll_Count";
            this.Test_Roll_Count.HeaderText = "试轧钢坯支数";
            this.Test_Roll_Count.Name = "Test_Roll_Count";
            // 
            // Test_Roll_Weight
            // 
            this.Test_Roll_Weight.DataPropertyName = "Test_Roll_Weight";
            this.Test_Roll_Weight.HeaderText = "试轧钢坯重量[t]";
            this.Test_Roll_Weight.Name = "Test_Roll_Weight";
            this.Test_Roll_Weight.Width = 110;
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.DataSource = this.dsOffLineReason;
            this.rEASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.rEASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            this.rEASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rEASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rEASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cURSECTIONIDDataGridViewTextBoxColumn
            // 
            this.cURSECTIONIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SECTION_ID";
            this.cURSECTIONIDDataGridViewTextBoxColumn.HeaderText = "当前区";
            this.cURSECTIONIDDataGridViewTextBoxColumn.Name = "cURSECTIONIDDataGridViewTextBoxColumn";
            this.cURSECTIONIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qASTATUSDataGridViewTextBoxColumn
            // 
            this.qASTATUSDataGridViewTextBoxColumn.DataPropertyName = "QASTATUS";
            this.qASTATUSDataGridViewTextBoxColumn.HeaderText = "质量状态";
            this.qASTATUSDataGridViewTextBoxColumn.Name = "qASTATUSDataGridViewTextBoxColumn";
            this.qASTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // back_flag
            // 
            this.back_flag.DataPropertyName = "back_flag";
            this.back_flag.HeaderText = "线材回退标志";
            this.back_flag.Name = "back_flag";
            // 
            // back_date
            // 
            this.back_date.DataPropertyName = "back_date";
            this.back_date.HeaderText = "线材回退日期";
            this.back_date.Name = "back_date";
            // 
            // BloomOnStoreMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 461);
            this.Controls.Add(this.l3dbxGetStore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tSp1);
            this.Name = "BloomOnStoreMagFrm";
            this.Text = "在库钢坯管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomOnStoreMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.BloomOnStoreMagFrm_Load);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsQualityCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQualityCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQualityCheck)).EndInit();
            this.panel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvQualityCheck)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsSpileChangeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpileChangeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStoreSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOutStoreSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnQualityCheck;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbStoreID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsQualityCheck;
        private AppSvrHMI.L3Command cmdQuery;
        private System.Data.DataTable schemadsQualityCheck;
        private System.Data.DataColumn coldsQualityCheckL3DataTableMATERIALID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableSTATUS;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePOSITION;
        private System.Data.DataColumn coldsQualityCheckL3DataTableQASTATUS;
        private System.Data.DataColumn coldsQualityCheckL3DataTableQALEVEL;
        private System.Data.DataColumn coldsQualityCheckL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCASTERID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQualityCheckL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQualityCheckL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsQualityCheckL3DataTableLENGTH;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWIDTH;
        private System.Data.DataColumn coldsQualityCheckL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTableDESTINATION;
        private System.Data.DataColumn coldsQualityCheckL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsQualityCheckL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsQualityCheckL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsQualityCheckL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsQualityCheckL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsQualityCheckL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsQualityCheckL3DataTableREASON;
        private System.Data.DataColumn coldsQualityCheckL3DataTableCheckFlag;
        private System.Windows.Forms.BindingSource bsQualityCheck;
        private System.Windows.Forms.ToolStripTextBox txtStoreAreaID;
        private AppSvrHMI.L3DataSet dsStoreAreaID;
        private System.Data.DataTable schemadsStoreAreaID;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtMaterialID;
        private AppSvrHMI.L3Command cmdBloomFinish;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.ToolStripButton btnSpileChange;
        private AppSvrHMI.L3DataSet dsSpileChangeSend;
        private System.Data.DataTable schemadsSpileChangeSend;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableMATERIALID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableSTATUS;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableQASTATUS;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableQALEVEL;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCASTERID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableLENGTH;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWIDTH;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableDESTINATION;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsSpileChangeSendL3DataTableREASON;
        private AppSvrHMI.L3DataSet dsOutStoreSend;
        private System.Data.DataTable schemadsOutStoreSend;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableMATERIALID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableSTATUS;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableQASTATUS;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableQALEVEL;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCASTERID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableLENGTH;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWIDTH;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableDESTINATION;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsOutStoreSendL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableREASON;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableTarget;
        private System.Windows.Forms.ToolStripButton btnOutStore;
        private System.Data.DataColumn coldsOutStoreSendL3DataTableStroeAreaID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvQualityCheck;
        private System.Data.DataColumn coldsQualityCheckL3DataTableTest_Roll_Count;
        private System.Data.DataColumn coldsQualityCheckL3DataTableTest_Roll_Weight;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSpile;
        private System.Data.DataTable schemadsSpile;
        private System.Data.DataColumn coldsSpileL3DataTableCode;
        private System.Data.DataColumn coldsSpileL3DataTableCode_Des;
        private AppSvrHMI.L3DataBox l3dbxGetStore;
        private System.Data.DataColumn coldsQualityCheckL3DataTableSpileFlagDes;
        private System.Data.DataColumn coldsQualityCheckL3DataTabletotalweight;
        private System.Data.DataColumn coldsQualityCheckL3DataTableback_flag;
        private System.Data.DataColumn coldsQualityCheckL3DataTableback_date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCECONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALESCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpileFlagDes;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn sUFACEDEFACTDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Roll_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test_Roll_Weight;
        private System.Windows.Forms.DataGridViewComboBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSECTIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qASTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn back_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn back_date;
    }
}