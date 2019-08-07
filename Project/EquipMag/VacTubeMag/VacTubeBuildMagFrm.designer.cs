namespace EquipMag.VacTubeMag
{
    partial class VacTubeBuildMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacTubeBuildMagFrm));
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.cmdpMain = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableVACTUBE_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableVACTUBE_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_START_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_END_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableREFRA_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableWALL_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOT_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableRH_AGE = new System.Data.DataColumn();
            this.coldsMainL3DataTableINWALL_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableINBOT_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableMG_CR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableBEAR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableSI_CA_BOA_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableCAST_WAST = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.cmdpM = new AppSvrHMI.L3CommandParameter();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
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
            this.cmbSlotID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUILD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VACTUBE_NAME = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsName = new AppSvrHMI.L3DataSet();
            this.schemadsName = new System.Data.DataTable();
            this.coldsNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.VACTUBE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wALLBRITHICKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTBRITHICKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNWALLBRITHICKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNBOTBRITHICKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRFIRWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEARFIRWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sICABOAWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUGHITMATWASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vACTUBENAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vACTUBEIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAFACDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHAGEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIRAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uPAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOWNAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEARFIRWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sICABOAWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTWASTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRCASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nOTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.cmdDetail = new AppSvrHMI.L3Command(this.components);
            this.cmdpDetail = new AppSvrHMI.L3CommandParameter();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBUILD_ID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableVACTUBE_NAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableVACTUBE_ID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREFRA_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableRH_AGE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCIR_AGE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableUP_AGE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableDOWN_AGE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINWALL_BRI_THICK = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINBOT_BRI_THICK = new System.Data.DataColumn();
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBEAR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCAST_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREPAIR_POSITION = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREPAIR_CASE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREPAIR_PER = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNOTE = new System.Data.DataColumn();
            this.bdNP = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmDetail = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQueryDetail = new System.Windows.Forms.ToolStripButton();
            this.btnOutPutDetial = new System.Windows.Forms.ToolStripButton();
            this.dsSlotID = new AppSvrHMI.L3DataSet();
            this.schemadsBelSlotID = new System.Data.DataTable();
            this.coldsBelSlotIDL3DataTableVacTube_Id = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).BeginInit();
            this.bdNP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlotID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBelSlotID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            this.bsMain.CurrentChanged += new System.EventHandler(this.bsMain_CurrentChanged);
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteVacTubeBuild";
            this.dsMain.InsertMethod = "InsertVacTubeBuild";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "GetVacTubeBuild";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "UpdateVacTubeBuild";
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.cmdpMain);
            this.cmdMain.ReturnTarget = null;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
            // 
            // cmdpMain
            // 
            this.cmdpMain.AcceptAfterExecuted = false;
            this.cmdpMain.ConstantValue = null;
            this.cmdpMain.MergeTarget = false;
            this.cmdpMain.SourceFilter = null;
            this.cmdpMain.SourceObject = null;
            this.cmdpMain.SourceProperty = null;
            this.cmdpMain.TargetObject = null;
            this.cmdpMain.TargetProperty = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableBUILD_ID,
            this.coldsMainL3DataTableVACTUBE_NAME,
            this.coldsMainL3DataTableVACTUBE_ID,
            this.coldsMainL3DataTableBUILD_START_TIME,
            this.coldsMainL3DataTableBUILD_END_TIME,
            this.coldsMainL3DataTableREFRA_FAC,
            this.coldsMainL3DataTableWALL_BRI_THICK,
            this.coldsMainL3DataTableBOT_BRI_THICK,
            this.coldsMainL3DataTableRH_AGE,
            this.coldsMainL3DataTableINWALL_BRI_THICK,
            this.coldsMainL3DataTableINBOT_BRI_THICK,
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE,
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE,
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE,
            this.coldsMainL3DataTableMG_CR_FIR_WASTE,
            this.coldsMainL3DataTableBEAR_FIR_WASTE,
            this.coldsMainL3DataTableSI_CA_BOA_WASTE,
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE,
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE,
            this.coldsMainL3DataTableCAST_WAST,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableNOTE});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "NAME";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_ID
            // 
            this.coldsMainL3DataTableBUILD_ID.Caption = "BUILD_ID";
            this.coldsMainL3DataTableBUILD_ID.ColumnName = "BUILD_ID";
            this.coldsMainL3DataTableBUILD_ID.DefaultValue = "";
            this.coldsMainL3DataTableBUILD_ID.Namespace = "";
            // 
            // coldsMainL3DataTableVACTUBE_NAME
            // 
            this.coldsMainL3DataTableVACTUBE_NAME.Caption = "VACTUBE_NAME";
            this.coldsMainL3DataTableVACTUBE_NAME.ColumnName = "VACTUBE_NAME";
            this.coldsMainL3DataTableVACTUBE_NAME.DefaultValue = "";
            this.coldsMainL3DataTableVACTUBE_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableVACTUBE_ID
            // 
            this.coldsMainL3DataTableVACTUBE_ID.Caption = "VACTUBE_ID";
            this.coldsMainL3DataTableVACTUBE_ID.ColumnName = "VACTUBE_ID";
            this.coldsMainL3DataTableVACTUBE_ID.DefaultValue = "";
            this.coldsMainL3DataTableVACTUBE_ID.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_START_TIME
            // 
            this.coldsMainL3DataTableBUILD_START_TIME.Caption = "BUILD_START_TIME";
            this.coldsMainL3DataTableBUILD_START_TIME.ColumnName = "BUILD_START_TIME";
            this.coldsMainL3DataTableBUILD_START_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBUILD_START_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_END_TIME
            // 
            this.coldsMainL3DataTableBUILD_END_TIME.Caption = "BUILD_END_TIME";
            this.coldsMainL3DataTableBUILD_END_TIME.ColumnName = "BUILD_END_TIME";
            this.coldsMainL3DataTableBUILD_END_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBUILD_END_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableREFRA_FAC
            // 
            this.coldsMainL3DataTableREFRA_FAC.Caption = "REFRA_FAC";
            this.coldsMainL3DataTableREFRA_FAC.ColumnName = "REFRA_FAC";
            this.coldsMainL3DataTableREFRA_FAC.DefaultValue = "";
            this.coldsMainL3DataTableREFRA_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableWALL_BRI_THICK
            // 
            this.coldsMainL3DataTableWALL_BRI_THICK.Caption = "WALL_BRI_THICK";
            this.coldsMainL3DataTableWALL_BRI_THICK.ColumnName = "WALL_BRI_THICK";
            this.coldsMainL3DataTableWALL_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableWALL_BRI_THICK.DefaultValue = 0;
            this.coldsMainL3DataTableWALL_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableBOT_BRI_THICK
            // 
            this.coldsMainL3DataTableBOT_BRI_THICK.Caption = "BOT_BRI_THICK";
            this.coldsMainL3DataTableBOT_BRI_THICK.ColumnName = "BOT_BRI_THICK";
            this.coldsMainL3DataTableBOT_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableBOT_BRI_THICK.DefaultValue = 0;
            this.coldsMainL3DataTableBOT_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableRH_AGE
            // 
            this.coldsMainL3DataTableRH_AGE.Caption = "RH_AGE";
            this.coldsMainL3DataTableRH_AGE.ColumnName = "RH_AGE";
            this.coldsMainL3DataTableRH_AGE.DataType = typeof(int);
            this.coldsMainL3DataTableRH_AGE.DefaultValue = 0;
            this.coldsMainL3DataTableRH_AGE.Namespace = "";
            // 
            // coldsMainL3DataTableINWALL_BRI_THICK
            // 
            this.coldsMainL3DataTableINWALL_BRI_THICK.Caption = "INWALL_BRI_THICK";
            this.coldsMainL3DataTableINWALL_BRI_THICK.ColumnName = "INWALL_BRI_THICK";
            this.coldsMainL3DataTableINWALL_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableINWALL_BRI_THICK.DefaultValue = 0;
            this.coldsMainL3DataTableINWALL_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableINBOT_BRI_THICK
            // 
            this.coldsMainL3DataTableINBOT_BRI_THICK.Caption = "INBOT_BRI_THICK";
            this.coldsMainL3DataTableINBOT_BRI_THICK.ColumnName = "INBOT_BRI_THICK";
            this.coldsMainL3DataTableINBOT_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableINBOT_BRI_THICK.DefaultValue = 0;
            this.coldsMainL3DataTableINBOT_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableMG_CR_BRI_ELE_WASTE
            // 
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE.Caption = "MG_CR_BRI_ELE_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE.ColumnName = "MG_CR_BRI_ELE_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableMG_CR_BRI_ELE_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableMG_CR_BRI_DIR_WASTE
            // 
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE.Caption = "MG_CR_BRI_DIR_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE.ColumnName = "MG_CR_BRI_DIR_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableMG_CR_BRI_DIR_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableMG_CR_BRI_HALF_WASTE
            // 
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE.Caption = "MG_CR_BRI_HALF_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE.ColumnName = "MG_CR_BRI_HALF_WASTE";
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableMG_CR_BRI_HALF_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableMG_CR_FIR_WASTE
            // 
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.Caption = "MG_CR_FIR_WASTE";
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.ColumnName = "MG_CR_FIR_WASTE";
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableBEAR_FIR_WASTE
            // 
            this.coldsMainL3DataTableBEAR_FIR_WASTE.Caption = "BEAR_FIR_WASTE";
            this.coldsMainL3DataTableBEAR_FIR_WASTE.ColumnName = "BEAR_FIR_WASTE";
            this.coldsMainL3DataTableBEAR_FIR_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableBEAR_FIR_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableBEAR_FIR_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableSI_CA_BOA_WASTE
            // 
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.Caption = "SI_CA_BOA_WASTE";
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.ColumnName = "SI_CA_BOA_WASTE";
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableLIGHT_MAT_BRI_WASTE
            // 
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.Caption = "LIGHT_MAT_BRI_WASTE";
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.ColumnName = "LIGHT_MAT_BRI_WASTE";
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTablePUG_HIT_MAT_WASTE
            // 
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.Caption = "PUG_HIT_MAT_WASTE";
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.ColumnName = "PUG_HIT_MAT_WASTE";
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.DefaultValue = 0;
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableCAST_WAST
            // 
            this.coldsMainL3DataTableCAST_WAST.Caption = "CAST_WAST";
            this.coldsMainL3DataTableCAST_WAST.ColumnName = "CAST_WAST";
            this.coldsMainL3DataTableCAST_WAST.DataType = typeof(double);
            this.coldsMainL3DataTableCAST_WAST.DefaultValue = 0;
            this.coldsMainL3DataTableCAST_WAST.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.DefaultValue = "";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // cmdpM
            // 
            this.cmdpM.AcceptAfterExecuted = false;
            this.cmdpM.ConstantValue = null;
            this.cmdpM.MergeTarget = false;
            this.cmdpM.SourceFilter = null;
            this.cmdpM.SourceObject = null;
            this.cmdpM.SourceProperty = null;
            this.cmdpM.TargetObject = null;
            this.cmdpM.TargetProperty = null;
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsMain;
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
            this.cmbSlotID,
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 27;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
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
            // cmbSlotID
            // 
            this.cmbSlotID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSlotID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSlotID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSlotID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlotID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSlotID.Name = "cmbSlotID";
            this.cmbSlotID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "槽号:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
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
            this.dtEnd.Text = "2008-11-16";
            this.dtEnd.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 884);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel4.Text = "-";
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
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "录入日期:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 26;
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "VacTubeBuildbtn");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "VacTubeBuildbtn");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "VacTubeBuildbtn");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "VacTubeBuildbtn");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "VacTubeBuildbtn");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator3, "VacTubeBuildbtn");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.splitContainer1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 632);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 34;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.BUILD_ID,
            this.VACTUBE_NAME,
            this.VACTUBE_ID,
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn,
            this.bUILDENDTIMEDataGridViewTextBoxColumn,
            this.rEFRAFACDataGridViewTextBoxColumn,
            this.wALLBRITHICKDataGridViewTextBoxColumn,
            this.bOTBRITHICKDataGridViewTextBoxColumn,
            this.rHAGEDataGridViewTextBoxColumn,
            this.iNWALLBRITHICKDataGridViewTextBoxColumn,
            this.iNBOTBRITHICKDataGridViewTextBoxColumn,
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn,
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn,
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn,
            this.mGCRFIRWASTEDataGridViewTextBoxColumn,
            this.bEARFIRWASTEDataGridViewTextBoxColumn,
            this.sICABOAWASTEDataGridViewTextBoxColumn,
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn,
            this.pUGHITMATWASTEDataGridViewTextBoxColumn,
            this.cASTWASTDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(0, 0);
            this.dvMain.Margin = new System.Windows.Forms.Padding(0);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMain.Size = new System.Drawing.Size(996, 351);
            this.dvMain.TabIndex = 33;
            this.dvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvMain_CellDoubleClick);
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            this.dvMain.Sorted += new System.EventHandler(this.dvMain_Sorted);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BUILD_ID
            // 
            this.BUILD_ID.DataPropertyName = "BUILD_ID";
            this.BUILD_ID.Frozen = true;
            this.BUILD_ID.HeaderText = "砌筑编号";
            this.BUILD_ID.Name = "BUILD_ID";
            this.BUILD_ID.ReadOnly = true;
            this.BUILD_ID.Width = 80;
            // 
            // VACTUBE_NAME
            // 
            this.VACTUBE_NAME.DataPropertyName = "VACTUBE_NAME";
            this.VACTUBE_NAME.DataSource = this.dsName;
            this.VACTUBE_NAME.DisplayMember = "L3DataTable.Code_Des";
            this.VACTUBE_NAME.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.VACTUBE_NAME.Frozen = true;
            this.VACTUBE_NAME.HeaderText = "槽管名称";
            this.VACTUBE_NAME.Name = "VACTUBE_NAME";
            this.VACTUBE_NAME.ReadOnly = true;
            this.VACTUBE_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VACTUBE_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VACTUBE_NAME.ValueMember = "L3DataTable.Code";
            this.VACTUBE_NAME.Width = 80;
            // 
            // dsName
            // 
            this.dsName.AutoSubscribe = false;
            this.dsName.DataSetName = "L3DataSet";
            this.dsName.DeleteMethod = null;
            this.dsName.InsertMethod = null;
            this.dsName.L3DataAdapter = this.Adapter;
            this.dsName.LoadEvent = "Click";
            this.dsName.LoadTrigger = null;
            this.dsName.RefreshValve = 1000;
            this.dsName.SourceCommand = null;
            this.dsName.SourceCondition = "CODE_GROUP = \'VacTubeName\'  AND CODE < \'3\'";
            this.dsName.SourceMethod = "";
            this.dsName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsName.SubscribeTarget = null;
            this.dsName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsName});
            this.dsName.UpdateEvent = "Click";
            this.dsName.UpdateMethod = null;
            this.dsName.UpdateTrigger = null;
            // 
            // schemadsName
            // 
            this.schemadsName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNameL3DataTableCode,
            this.coldsNameL3DataTableCode_Des});
            this.schemadsName.TableName = "L3DataTable";
            // 
            // coldsNameL3DataTableCode
            // 
            this.coldsNameL3DataTableCode.Caption = "Code";
            this.coldsNameL3DataTableCode.ColumnName = "Code";
            this.coldsNameL3DataTableCode.Namespace = "";
            // 
            // coldsNameL3DataTableCode_Des
            // 
            this.coldsNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNameL3DataTableCode_Des.Namespace = "";
            // 
            // VACTUBE_ID
            // 
            this.VACTUBE_ID.DataPropertyName = "VACTUBE_ID";
            this.VACTUBE_ID.Frozen = true;
            this.VACTUBE_ID.HeaderText = "槽管编号";
            this.VACTUBE_ID.Name = "VACTUBE_ID";
            this.VACTUBE_ID.ReadOnly = true;
            this.VACTUBE_ID.Width = 80;
            // 
            // bUILDSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_START_TIME";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "砌筑开始时间";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Name = "bUILDSTARTTIMEDataGridViewTextBoxColumn";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Width = 115;
            // 
            // bUILDENDTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_END_TIME";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.HeaderText = "砌筑结束时间";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Name = "bUILDENDTIMEDataGridViewTextBoxColumn";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Width = 115;
            // 
            // rEFRAFACDataGridViewTextBoxColumn
            // 
            this.rEFRAFACDataGridViewTextBoxColumn.DataPropertyName = "REFRA_FAC";
            this.rEFRAFACDataGridViewTextBoxColumn.HeaderText = "耐材厂家";
            this.rEFRAFACDataGridViewTextBoxColumn.Name = "rEFRAFACDataGridViewTextBoxColumn";
            this.rEFRAFACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wALLBRITHICKDataGridViewTextBoxColumn
            // 
            this.wALLBRITHICKDataGridViewTextBoxColumn.DataPropertyName = "WALL_BRI_THICK";
            this.wALLBRITHICKDataGridViewTextBoxColumn.HeaderText = "槽壁砖厚度";
            this.wALLBRITHICKDataGridViewTextBoxColumn.Name = "wALLBRITHICKDataGridViewTextBoxColumn";
            this.wALLBRITHICKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOTBRITHICKDataGridViewTextBoxColumn
            // 
            this.bOTBRITHICKDataGridViewTextBoxColumn.DataPropertyName = "BOT_BRI_THICK";
            this.bOTBRITHICKDataGridViewTextBoxColumn.HeaderText = "槽底砖厚度";
            this.bOTBRITHICKDataGridViewTextBoxColumn.Name = "bOTBRITHICKDataGridViewTextBoxColumn";
            this.bOTBRITHICKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rHAGEDataGridViewTextBoxColumn
            // 
            this.rHAGEDataGridViewTextBoxColumn.DataPropertyName = "RH_AGE";
            this.rHAGEDataGridViewTextBoxColumn.HeaderText = "槽寿命";
            this.rHAGEDataGridViewTextBoxColumn.Name = "rHAGEDataGridViewTextBoxColumn";
            this.rHAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rHAGEDataGridViewTextBoxColumn.Width = 80;
            // 
            // iNWALLBRITHICKDataGridViewTextBoxColumn
            // 
            this.iNWALLBRITHICKDataGridViewTextBoxColumn.DataPropertyName = "INWALL_BRI_THICK";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn.HeaderText = "槽壁残砖厚度";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn.Name = "iNWALLBRITHICKDataGridViewTextBoxColumn";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNBOTBRITHICKDataGridViewTextBoxColumn
            // 
            this.iNBOTBRITHICKDataGridViewTextBoxColumn.DataPropertyName = "INBOT_BRI_THICK";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn.HeaderText = "槽底残砖厚度";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn.Name = "iNBOTBRITHICKDataGridViewTextBoxColumn";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mGCRBRIELEWASTEDataGridViewTextBoxColumn
            // 
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn.DataPropertyName = "MG_CR_BRI_ELE_WASTE";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn.HeaderText = "电熔再结合Mg-Cr砖[t]";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn.Name = "mGCRBRIELEWASTEDataGridViewTextBoxColumn";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mGCRBRIDIRWASTEDataGridViewTextBoxColumn
            // 
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn.DataPropertyName = "MG_CR_BRI_DIR_WASTE";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn.HeaderText = "直接结合Mg-Cr砖[t]";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn.Name = "mGCRBRIDIRWASTEDataGridViewTextBoxColumn";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mGCRBRIHALFWASTEDataGridViewTextBoxColumn
            // 
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn.DataPropertyName = "MG_CR_BRI_HALF_WASTE";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn.HeaderText = "半再结合Mg-Cr砖[t]";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn.Name = "mGCRBRIHALFWASTEDataGridViewTextBoxColumn";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mGCRFIRWASTEDataGridViewTextBoxColumn
            // 
            this.mGCRFIRWASTEDataGridViewTextBoxColumn.DataPropertyName = "MG_CR_FIR_WASTE";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn.HeaderText = "Mg-Cr火泥[t]";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn.Name = "mGCRFIRWASTEDataGridViewTextBoxColumn";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bEARFIRWASTEDataGridViewTextBoxColumn
            // 
            this.bEARFIRWASTEDataGridViewTextBoxColumn.DataPropertyName = "BEAR_FIR_WASTE";
            this.bEARFIRWASTEDataGridViewTextBoxColumn.HeaderText = "耐火泥[t]";
            this.bEARFIRWASTEDataGridViewTextBoxColumn.Name = "bEARFIRWASTEDataGridViewTextBoxColumn";
            this.bEARFIRWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sICABOAWASTEDataGridViewTextBoxColumn
            // 
            this.sICABOAWASTEDataGridViewTextBoxColumn.DataPropertyName = "SI_CA_BOA_WASTE";
            this.sICABOAWASTEDataGridViewTextBoxColumn.HeaderText = "硅钙板[t]";
            this.sICABOAWASTEDataGridViewTextBoxColumn.Name = "sICABOAWASTEDataGridViewTextBoxColumn";
            this.sICABOAWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lIGHTMATBRIWASTEDataGridViewTextBoxColumn
            // 
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn.DataPropertyName = "LIGHT_MAT_BRI_WASTE";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn.HeaderText = "轻质砖[t]";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn.Name = "lIGHTMATBRIWASTEDataGridViewTextBoxColumn";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pUGHITMATWASTEDataGridViewTextBoxColumn
            // 
            this.pUGHITMATWASTEDataGridViewTextBoxColumn.DataPropertyName = "PUG_HIT_MAT_WASTE";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn.HeaderText = "捣打料[t]";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn.Name = "pUGHITMATWASTEDataGridViewTextBoxColumn";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cASTWASTDataGridViewTextBoxColumn
            // 
            this.cASTWASTDataGridViewTextBoxColumn.DataPropertyName = "CAST_WAST";
            this.cASTWASTDataGridViewTextBoxColumn.HeaderText = "浇注料[t]";
            this.cASTWASTDataGridViewTextBoxColumn.Name = "cASTWASTDataGridViewTextBoxColumn";
            this.cASTWASTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
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
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
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
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 200;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 269);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvDetail);
            this.tabPage1.Controls.Add(this.bdNP);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(988, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "修补实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn1,
            this.bUILDIDDataGridViewTextBoxColumn1,
            this.vACTUBENAMEDataGridViewTextBoxColumn1,
            this.vACTUBEIDDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1,
            this.rEFRAFACDataGridViewTextBoxColumn1,
            this.rHAGEDataGridViewTextBoxColumn1,
            this.cIRAGEDataGridViewTextBoxColumn,
            this.uPAGEDataGridViewTextBoxColumn,
            this.dOWNAGEDataGridViewTextBoxColumn,
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1,
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1,
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1,
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1,
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1,
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1,
            this.bEARFIRWASTEDataGridViewTextBoxColumn1,
            this.sICABOAWASTEDataGridViewTextBoxColumn1,
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1,
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1,
            this.cASTWASTDataGridViewTextBoxColumn1,
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn,
            this.rEPAIRCASEDataGridViewTextBoxColumn,
            this.rEPAIRPERDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn1,
            this.sHIFTIDDataGridViewTextBoxColumn1,
            this.nOTEDataGridViewTextBoxColumn1});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 25);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(988, 219);
            this.dvDetail.TabIndex = 24;
            this.dvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDetail_CellDoubleClick);
            this.dvDetail.Sorted += new System.EventHandler(this.dvDetail_Sorted);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn1
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Name = "iNPUTTIMEDataGridViewTextBoxColumn1";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bUILDIDDataGridViewTextBoxColumn1
            // 
            this.bUILDIDDataGridViewTextBoxColumn1.DataPropertyName = "BUILD_ID";
            this.bUILDIDDataGridViewTextBoxColumn1.Frozen = true;
            this.bUILDIDDataGridViewTextBoxColumn1.HeaderText = "砌筑编号";
            this.bUILDIDDataGridViewTextBoxColumn1.Name = "bUILDIDDataGridViewTextBoxColumn1";
            this.bUILDIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bUILDIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // vACTUBENAMEDataGridViewTextBoxColumn1
            // 
            this.vACTUBENAMEDataGridViewTextBoxColumn1.DataPropertyName = "VACTUBE_NAME";
            this.vACTUBENAMEDataGridViewTextBoxColumn1.DataSource = this.dsName;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.vACTUBENAMEDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.Frozen = true;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.HeaderText = "槽管名称";
            this.vACTUBENAMEDataGridViewTextBoxColumn1.Name = "vACTUBENAMEDataGridViewTextBoxColumn1";
            this.vACTUBENAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.vACTUBENAMEDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.vACTUBENAMEDataGridViewTextBoxColumn1.Width = 78;
            // 
            // vACTUBEIDDataGridViewTextBoxColumn1
            // 
            this.vACTUBEIDDataGridViewTextBoxColumn1.DataPropertyName = "VACTUBE_ID";
            this.vACTUBEIDDataGridViewTextBoxColumn1.Frozen = true;
            this.vACTUBEIDDataGridViewTextBoxColumn1.HeaderText = "槽管编号";
            this.vACTUBEIDDataGridViewTextBoxColumn1.Name = "vACTUBEIDDataGridViewTextBoxColumn1";
            this.vACTUBEIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vACTUBEIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn1.Visible = false;
            this.nAMEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // rEFRAFACDataGridViewTextBoxColumn1
            // 
            this.rEFRAFACDataGridViewTextBoxColumn1.DataPropertyName = "REFRA_FAC";
            this.rEFRAFACDataGridViewTextBoxColumn1.HeaderText = "耐材厂家";
            this.rEFRAFACDataGridViewTextBoxColumn1.Name = "rEFRAFACDataGridViewTextBoxColumn1";
            this.rEFRAFACDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rEFRAFACDataGridViewTextBoxColumn1.Width = 78;
            // 
            // rHAGEDataGridViewTextBoxColumn1
            // 
            this.rHAGEDataGridViewTextBoxColumn1.DataPropertyName = "RH_AGE";
            this.rHAGEDataGridViewTextBoxColumn1.HeaderText = "槽寿命";
            this.rHAGEDataGridViewTextBoxColumn1.Name = "rHAGEDataGridViewTextBoxColumn1";
            this.rHAGEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rHAGEDataGridViewTextBoxColumn1.Width = 66;
            // 
            // cIRAGEDataGridViewTextBoxColumn
            // 
            this.cIRAGEDataGridViewTextBoxColumn.DataPropertyName = "CIR_AGE";
            this.cIRAGEDataGridViewTextBoxColumn.HeaderText = "环流管寿命(炉)";
            this.cIRAGEDataGridViewTextBoxColumn.Name = "cIRAGEDataGridViewTextBoxColumn";
            this.cIRAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIRAGEDataGridViewTextBoxColumn.Width = 114;
            // 
            // uPAGEDataGridViewTextBoxColumn
            // 
            this.uPAGEDataGridViewTextBoxColumn.DataPropertyName = "UP_AGE";
            this.uPAGEDataGridViewTextBoxColumn.HeaderText = "上升管寿命(min)";
            this.uPAGEDataGridViewTextBoxColumn.Name = "uPAGEDataGridViewTextBoxColumn";
            this.uPAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uPAGEDataGridViewTextBoxColumn.Width = 120;
            // 
            // dOWNAGEDataGridViewTextBoxColumn
            // 
            this.dOWNAGEDataGridViewTextBoxColumn.DataPropertyName = "DOWN_AGE";
            this.dOWNAGEDataGridViewTextBoxColumn.HeaderText = "下降管寿命(min)";
            this.dOWNAGEDataGridViewTextBoxColumn.Name = "dOWNAGEDataGridViewTextBoxColumn";
            this.dOWNAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOWNAGEDataGridViewTextBoxColumn.Width = 120;
            // 
            // iNWALLBRITHICKDataGridViewTextBoxColumn1
            // 
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1.DataPropertyName = "INWALL_BRI_THICK";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1.HeaderText = "槽壁残砖厚度";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1.Name = "iNWALLBRITHICKDataGridViewTextBoxColumn1";
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNWALLBRITHICKDataGridViewTextBoxColumn1.Width = 102;
            // 
            // iNBOTBRITHICKDataGridViewTextBoxColumn1
            // 
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1.DataPropertyName = "INBOT_BRI_THICK";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1.HeaderText = "槽底残砖厚度";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1.Name = "iNBOTBRITHICKDataGridViewTextBoxColumn1";
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNBOTBRITHICKDataGridViewTextBoxColumn1.Width = 102;
            // 
            // mGCRBRIELEWASTEDataGridViewTextBoxColumn1
            // 
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1.DataPropertyName = "MG_CR_BRI_ELE_WASTE";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1.HeaderText = "电熔再结合Mg-Cr砖[t]";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1.Name = "mGCRBRIELEWASTEDataGridViewTextBoxColumn1";
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mGCRBRIELEWASTEDataGridViewTextBoxColumn1.Width = 150;
            // 
            // mGCRBRIDIRWASTEDataGridViewTextBoxColumn1
            // 
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1.DataPropertyName = "MG_CR_BRI_DIR_WASTE";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1.HeaderText = "直接结合Mg-Cr砖[t]";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1.Name = "mGCRBRIDIRWASTEDataGridViewTextBoxColumn1";
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mGCRBRIDIRWASTEDataGridViewTextBoxColumn1.Width = 138;
            // 
            // mGCRBRIHALFWASTEDataGridViewTextBoxColumn1
            // 
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1.DataPropertyName = "MG_CR_BRI_HALF_WASTE";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1.HeaderText = "半再结合Mg-Cr砖[t]";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1.Name = "mGCRBRIHALFWASTEDataGridViewTextBoxColumn1";
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mGCRBRIHALFWASTEDataGridViewTextBoxColumn1.Width = 138;
            // 
            // mGCRFIRWASTEDataGridViewTextBoxColumn1
            // 
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1.DataPropertyName = "MG_CR_FIR_WASTE";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1.HeaderText = "Mg-Cr火泥[t]";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1.Name = "mGCRFIRWASTEDataGridViewTextBoxColumn1";
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mGCRFIRWASTEDataGridViewTextBoxColumn1.Width = 102;
            // 
            // bEARFIRWASTEDataGridViewTextBoxColumn1
            // 
            this.bEARFIRWASTEDataGridViewTextBoxColumn1.DataPropertyName = "BEAR_FIR_WASTE";
            this.bEARFIRWASTEDataGridViewTextBoxColumn1.HeaderText = "耐火泥[t]";
            this.bEARFIRWASTEDataGridViewTextBoxColumn1.Name = "bEARFIRWASTEDataGridViewTextBoxColumn1";
            this.bEARFIRWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bEARFIRWASTEDataGridViewTextBoxColumn1.Width = 84;
            // 
            // sICABOAWASTEDataGridViewTextBoxColumn1
            // 
            this.sICABOAWASTEDataGridViewTextBoxColumn1.DataPropertyName = "SI_CA_BOA_WASTE";
            this.sICABOAWASTEDataGridViewTextBoxColumn1.HeaderText = "硅钙板[t]";
            this.sICABOAWASTEDataGridViewTextBoxColumn1.Name = "sICABOAWASTEDataGridViewTextBoxColumn1";
            this.sICABOAWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sICABOAWASTEDataGridViewTextBoxColumn1.Width = 84;
            // 
            // lIGHTMATBRIWASTEDataGridViewTextBoxColumn1
            // 
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1.DataPropertyName = "LIGHT_MAT_BRI_WASTE";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1.HeaderText = "轻质砖[t]";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1.Name = "lIGHTMATBRIWASTEDataGridViewTextBoxColumn1";
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lIGHTMATBRIWASTEDataGridViewTextBoxColumn1.Width = 84;
            // 
            // pUGHITMATWASTEDataGridViewTextBoxColumn1
            // 
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1.DataPropertyName = "PUG_HIT_MAT_WASTE";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1.HeaderText = "捣打料[t]";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1.Name = "pUGHITMATWASTEDataGridViewTextBoxColumn1";
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pUGHITMATWASTEDataGridViewTextBoxColumn1.Width = 84;
            // 
            // cASTWASTDataGridViewTextBoxColumn1
            // 
            this.cASTWASTDataGridViewTextBoxColumn1.DataPropertyName = "CAST_WAST";
            this.cASTWASTDataGridViewTextBoxColumn1.HeaderText = "浇注料[t]";
            this.cASTWASTDataGridViewTextBoxColumn1.Name = "cASTWASTDataGridViewTextBoxColumn1";
            this.cASTWASTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cASTWASTDataGridViewTextBoxColumn1.Width = 84;
            // 
            // rEPAIRPOSITIONDataGridViewTextBoxColumn
            // 
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_POSITION";
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn.HeaderText = "修补部位";
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn.Name = "rEPAIRPOSITIONDataGridViewTextBoxColumn";
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRPOSITIONDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEPAIRCASEDataGridViewTextBoxColumn
            // 
            this.rEPAIRCASEDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_CASE";
            this.rEPAIRCASEDataGridViewTextBoxColumn.HeaderText = "修补情况";
            this.rEPAIRCASEDataGridViewTextBoxColumn.Name = "rEPAIRCASEDataGridViewTextBoxColumn";
            this.rEPAIRCASEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRCASEDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEPAIRPERDataGridViewTextBoxColumn
            // 
            this.rEPAIRPERDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_PER";
            this.rEPAIRPERDataGridViewTextBoxColumn.HeaderText = "修补人";
            this.rEPAIRPERDataGridViewTextBoxColumn.Name = "rEPAIRPERDataGridViewTextBoxColumn";
            this.rEPAIRPERDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRPERDataGridViewTextBoxColumn.Width = 66;
            // 
            // tEAMIDDataGridViewTextBoxColumn1
            // 
            this.tEAMIDDataGridViewTextBoxColumn1.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn1.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn1.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn1.Name = "tEAMIDDataGridViewTextBoxColumn1";
            this.tEAMIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn1
            // 
            this.sHIFTIDDataGridViewTextBoxColumn1.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn1.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn1.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn1.Name = "sHIFTIDDataGridViewTextBoxColumn1";
            this.sHIFTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // nOTEDataGridViewTextBoxColumn1
            // 
            this.nOTEDataGridViewTextBoxColumn1.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn1.Name = "nOTEDataGridViewTextBoxColumn1";
            this.nOTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "L3DataTable";
            this.bsDetail.DataSource = this.dsDetail;
            // 
            // dsDetail
            // 
            this.dsDetail.AutoSubscribe = false;
            this.dsDetail.DataSetName = "L3DataSet";
            this.dsDetail.DeleteMethod = "DeleteVacTubeRepair";
            this.dsDetail.InsertMethod = "InsertVacTubeRepair";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 1000;
            this.dsDetail.SourceCommand = this.cmdDetail;
            this.dsDetail.SourceCondition = "";
            this.dsDetail.SourceMethod = "GetVacTubeRepair";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDetail.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.dsDetail.SubscribeTarget = "";
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "";
            this.dsDetail.UpdateMethod = "UpdateVacTubeRepair";
            this.dsDetail.UpdateTrigger = null;
            // 
            // cmdDetail
            // 
            this.cmdDetail.Adapter = null;
            this.cmdDetail.MergeReturnTarget = false;
            this.cmdDetail.Method = null;
            this.cmdDetail.Object = null;
            this.cmdDetail.Parameters.Add(this.cmdpDetail);
            this.cmdDetail.ReturnTarget = null;
            this.cmdDetail.ReturnTargetProperty = null;
            this.cmdDetail.Trigger = null;
            this.cmdDetail.TriggerEvent = "Click";
            // 
            // cmdpDetail
            // 
            this.cmdpDetail.AcceptAfterExecuted = false;
            this.cmdpDetail.ConstantValue = null;
            this.cmdpDetail.MergeTarget = false;
            this.cmdpDetail.SourceFilter = null;
            this.cmdpDetail.SourceObject = null;
            this.cmdpDetail.SourceProperty = null;
            this.cmdpDetail.TargetObject = null;
            this.cmdpDetail.TargetProperty = null;
            // 
            // schemadsDetail
            // 
            this.schemadsDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDetailL3DataTableGUID,
            this.coldsDetailL3DataTableNAME,
            this.coldsDetailL3DataTableINPUT_TIME,
            this.coldsDetailL3DataTableBUILD_ID,
            this.coldsDetailL3DataTableVACTUBE_NAME,
            this.coldsDetailL3DataTableVACTUBE_ID,
            this.coldsDetailL3DataTableREFRA_FAC,
            this.coldsDetailL3DataTableRH_AGE,
            this.coldsDetailL3DataTableCIR_AGE,
            this.coldsDetailL3DataTableUP_AGE,
            this.coldsDetailL3DataTableDOWN_AGE,
            this.coldsDetailL3DataTableINWALL_BRI_THICK,
            this.coldsDetailL3DataTableINBOT_BRI_THICK,
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE,
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE,
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE,
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE,
            this.coldsDetailL3DataTableBEAR_FIR_WASTE,
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE,
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE,
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE,
            this.coldsDetailL3DataTableCAST_WAST,
            this.coldsDetailL3DataTableREPAIR_POSITION,
            this.coldsDetailL3DataTableREPAIR_CASE,
            this.coldsDetailL3DataTableREPAIR_PER,
            this.coldsDetailL3DataTableTEAMID,
            this.coldsDetailL3DataTableSHIFTID,
            this.coldsDetailL3DataTableNOTE});
            this.schemadsDetail.TableName = "L3DataTable";
            // 
            // coldsDetailL3DataTableGUID
            // 
            this.coldsDetailL3DataTableGUID.Caption = "GUID";
            this.coldsDetailL3DataTableGUID.ColumnName = "GUID";
            this.coldsDetailL3DataTableGUID.DefaultValue = "";
            this.coldsDetailL3DataTableGUID.Namespace = "";
            // 
            // coldsDetailL3DataTableNAME
            // 
            this.coldsDetailL3DataTableNAME.Caption = "NAME";
            this.coldsDetailL3DataTableNAME.ColumnName = "NAME";
            this.coldsDetailL3DataTableNAME.DefaultValue = "";
            this.coldsDetailL3DataTableNAME.Namespace = "";
            // 
            // coldsDetailL3DataTableINPUT_TIME
            // 
            this.coldsDetailL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsDetailL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableBUILD_ID
            // 
            this.coldsDetailL3DataTableBUILD_ID.Caption = "BUILD_ID";
            this.coldsDetailL3DataTableBUILD_ID.ColumnName = "BUILD_ID";
            this.coldsDetailL3DataTableBUILD_ID.DefaultValue = "";
            this.coldsDetailL3DataTableBUILD_ID.Namespace = "";
            // 
            // coldsDetailL3DataTableVACTUBE_NAME
            // 
            this.coldsDetailL3DataTableVACTUBE_NAME.Caption = "VACTUBE_NAME";
            this.coldsDetailL3DataTableVACTUBE_NAME.ColumnName = "VACTUBE_NAME";
            this.coldsDetailL3DataTableVACTUBE_NAME.DefaultValue = "";
            this.coldsDetailL3DataTableVACTUBE_NAME.Namespace = "";
            // 
            // coldsDetailL3DataTableVACTUBE_ID
            // 
            this.coldsDetailL3DataTableVACTUBE_ID.Caption = "VACTUBE_ID";
            this.coldsDetailL3DataTableVACTUBE_ID.ColumnName = "VACTUBE_ID";
            this.coldsDetailL3DataTableVACTUBE_ID.DefaultValue = "";
            this.coldsDetailL3DataTableVACTUBE_ID.Namespace = "";
            // 
            // coldsDetailL3DataTableREFRA_FAC
            // 
            this.coldsDetailL3DataTableREFRA_FAC.Caption = "REFRA_FAC";
            this.coldsDetailL3DataTableREFRA_FAC.ColumnName = "REFRA_FAC";
            this.coldsDetailL3DataTableREFRA_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableREFRA_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableRH_AGE
            // 
            this.coldsDetailL3DataTableRH_AGE.Caption = "RH_AGE";
            this.coldsDetailL3DataTableRH_AGE.ColumnName = "RH_AGE";
            this.coldsDetailL3DataTableRH_AGE.DataType = typeof(int);
            this.coldsDetailL3DataTableRH_AGE.DefaultValue = 0;
            this.coldsDetailL3DataTableRH_AGE.Namespace = "";
            // 
            // coldsDetailL3DataTableCIR_AGE
            // 
            this.coldsDetailL3DataTableCIR_AGE.Caption = "CIR_AGE";
            this.coldsDetailL3DataTableCIR_AGE.ColumnName = "CIR_AGE";
            this.coldsDetailL3DataTableCIR_AGE.DataType = typeof(int);
            this.coldsDetailL3DataTableCIR_AGE.DefaultValue = 0;
            this.coldsDetailL3DataTableCIR_AGE.Namespace = "";
            // 
            // coldsDetailL3DataTableUP_AGE
            // 
            this.coldsDetailL3DataTableUP_AGE.Caption = "UP_AGE";
            this.coldsDetailL3DataTableUP_AGE.ColumnName = "UP_AGE";
            this.coldsDetailL3DataTableUP_AGE.DataType = typeof(int);
            this.coldsDetailL3DataTableUP_AGE.DefaultValue = 0;
            this.coldsDetailL3DataTableUP_AGE.Namespace = "";
            // 
            // coldsDetailL3DataTableDOWN_AGE
            // 
            this.coldsDetailL3DataTableDOWN_AGE.Caption = "DOWN_AGE";
            this.coldsDetailL3DataTableDOWN_AGE.ColumnName = "DOWN_AGE";
            this.coldsDetailL3DataTableDOWN_AGE.DataType = typeof(int);
            this.coldsDetailL3DataTableDOWN_AGE.DefaultValue = 0;
            this.coldsDetailL3DataTableDOWN_AGE.Namespace = "";
            // 
            // coldsDetailL3DataTableINWALL_BRI_THICK
            // 
            this.coldsDetailL3DataTableINWALL_BRI_THICK.Caption = "INWALL_BRI_THICK";
            this.coldsDetailL3DataTableINWALL_BRI_THICK.ColumnName = "INWALL_BRI_THICK";
            this.coldsDetailL3DataTableINWALL_BRI_THICK.DataType = typeof(double);
            this.coldsDetailL3DataTableINWALL_BRI_THICK.DefaultValue = 0;
            this.coldsDetailL3DataTableINWALL_BRI_THICK.Namespace = "";
            // 
            // coldsDetailL3DataTableINBOT_BRI_THICK
            // 
            this.coldsDetailL3DataTableINBOT_BRI_THICK.Caption = "INBOT_BRI_THICK";
            this.coldsDetailL3DataTableINBOT_BRI_THICK.ColumnName = "INBOT_BRI_THICK";
            this.coldsDetailL3DataTableINBOT_BRI_THICK.DataType = typeof(double);
            this.coldsDetailL3DataTableINBOT_BRI_THICK.DefaultValue = 0;
            this.coldsDetailL3DataTableINBOT_BRI_THICK.Namespace = "";
            // 
            // coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE
            // 
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE.Caption = "MG_CR_BRI_ELE_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE.ColumnName = "MG_CR_BRI_ELE_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE
            // 
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE.Caption = "MG_CR_BRI_DIR_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE.ColumnName = "MG_CR_BRI_DIR_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE
            // 
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE.Caption = "MG_CR_BRI_HALF_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE.ColumnName = "MG_CR_BRI_HALF_WASTE";
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableMG_CR_FIR_WASTE
            // 
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE.Caption = "MG_CR_FIR_WASTE";
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE.ColumnName = "MG_CR_FIR_WASTE";
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableMG_CR_FIR_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableBEAR_FIR_WASTE
            // 
            this.coldsDetailL3DataTableBEAR_FIR_WASTE.Caption = "BEAR_FIR_WASTE";
            this.coldsDetailL3DataTableBEAR_FIR_WASTE.ColumnName = "BEAR_FIR_WASTE";
            this.coldsDetailL3DataTableBEAR_FIR_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableBEAR_FIR_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableBEAR_FIR_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableSI_CA_BOA_WASTE
            // 
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE.Caption = "SI_CA_BOA_WASTE";
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE.ColumnName = "SI_CA_BOA_WASTE";
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableSI_CA_BOA_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE
            // 
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE.Caption = "LIGHT_MAT_BRI_WASTE";
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE.ColumnName = "LIGHT_MAT_BRI_WASTE";
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTablePUG_HIT_MAT_WASTE
            // 
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE.Caption = "PUG_HIT_MAT_WASTE";
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE.ColumnName = "PUG_HIT_MAT_WASTE";
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE.DataType = typeof(double);
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE.DefaultValue = 0;
            this.coldsDetailL3DataTablePUG_HIT_MAT_WASTE.Namespace = "";
            // 
            // coldsDetailL3DataTableCAST_WAST
            // 
            this.coldsDetailL3DataTableCAST_WAST.Caption = "CAST_WAST";
            this.coldsDetailL3DataTableCAST_WAST.ColumnName = "CAST_WAST";
            this.coldsDetailL3DataTableCAST_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableCAST_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableCAST_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableREPAIR_POSITION
            // 
            this.coldsDetailL3DataTableREPAIR_POSITION.Caption = "REPAIR_POSITION";
            this.coldsDetailL3DataTableREPAIR_POSITION.ColumnName = "REPAIR_POSITION";
            this.coldsDetailL3DataTableREPAIR_POSITION.DefaultValue = "";
            this.coldsDetailL3DataTableREPAIR_POSITION.Namespace = "";
            // 
            // coldsDetailL3DataTableREPAIR_CASE
            // 
            this.coldsDetailL3DataTableREPAIR_CASE.Caption = "REPAIR_CASE";
            this.coldsDetailL3DataTableREPAIR_CASE.ColumnName = "REPAIR_CASE";
            this.coldsDetailL3DataTableREPAIR_CASE.DefaultValue = "";
            this.coldsDetailL3DataTableREPAIR_CASE.Namespace = "";
            // 
            // coldsDetailL3DataTableREPAIR_PER
            // 
            this.coldsDetailL3DataTableREPAIR_PER.Caption = "REPAIR_PER";
            this.coldsDetailL3DataTableREPAIR_PER.ColumnName = "REPAIR_PER";
            this.coldsDetailL3DataTableREPAIR_PER.DefaultValue = "";
            this.coldsDetailL3DataTableREPAIR_PER.Namespace = "";
            // 
            // coldsDetailL3DataTableTEAMID
            // 
            this.coldsDetailL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsDetailL3DataTableTEAMID.DefaultValue = "";
            this.coldsDetailL3DataTableTEAMID.Namespace = "";
            // 
            // coldsDetailL3DataTableSHIFTID
            // 
            this.coldsDetailL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsDetailL3DataTableSHIFTID.DefaultValue = "";
            this.coldsDetailL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsDetailL3DataTableNOTE
            // 
            this.coldsDetailL3DataTableNOTE.Caption = "NOTE";
            this.coldsDetailL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsDetailL3DataTableNOTE.DefaultValue = "";
            this.coldsDetailL3DataTableNOTE.Namespace = "";
            // 
            // bdNP
            // 
            this.bdNP.AddNewItem = null;
            this.bdNP.AutoSize = false;
            this.bdNP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdNP.BackgroundImage")));
            this.bdNP.CountItem = null;
            this.bdNP.DeleteItem = null;
            this.bdNP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDetail,
            this.btnDelDetail,
            this.toolStripSeparator5,
            this.btnConfirmDetail,
            this.btnCancelDetail,
            this.toolStripSeparator4,
            this.btnQueryDetail,
            this.btnOutPutDetial});
            this.bdNP.Location = new System.Drawing.Point(0, 0);
            this.bdNP.MoveFirstItem = null;
            this.bdNP.MoveLastItem = null;
            this.bdNP.MoveNextItem = null;
            this.bdNP.MovePreviousItem = null;
            this.bdNP.Name = "bdNP";
            this.bdNP.Padding = new System.Windows.Forms.Padding(0);
            this.bdNP.PositionItem = null;
            this.bdNP.Size = new System.Drawing.Size(988, 25);
            this.bdNP.TabIndex = 22;
            this.bdNP.Text = "bindingNavigator2";
            // 
            // btnAddDetail
            // 
            this.Adapter.SetAccessRight(this.btnAddDetail, "VacTubeBuildbtn");
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(49, 22);
            this.btnAddDetail.Text = "新增";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.Adapter.SetAccessRight(this.btnDelDetail, "VacTubeBuildbtn");
            this.btnDelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDelDetail.Image")));
            this.btnDelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnDelDetail.Text = "删除";
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "VacTubeBuildbtn");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmDetail
            // 
            this.Adapter.SetAccessRight(this.btnConfirmDetail, "VacTubeBuildbtn");
            this.btnConfirmDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmDetail.Image")));
            this.btnConfirmDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmDetail.Name = "btnConfirmDetail";
            this.btnConfirmDetail.Size = new System.Drawing.Size(55, 22);
            this.btnConfirmDetail.Text = "确定 ";
            this.btnConfirmDetail.Click += new System.EventHandler(this.btnConfirmDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.Adapter.SetAccessRight(this.btnCancelDetail, "VacTubeBuildbtn");
            this.btnCancelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDetail.Image")));
            this.btnCancelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(49, 22);
            this.btnCancelDetail.Text = "取消";
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // toolStripSeparator4
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator4, "VacTubeBuildbtn");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnQueryDetail
            // 
            this.btnQueryDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryDetail.Image")));
            this.btnQueryDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryDetail.Name = "btnQueryDetail";
            this.btnQueryDetail.Size = new System.Drawing.Size(73, 22);
            this.btnQueryDetail.Text = "实绩查询";
            this.btnQueryDetail.Visible = false;
            // 
            // btnOutPutDetial
            // 
            this.btnOutPutDetial.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPutDetial.Image")));
            this.btnOutPutDetial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPutDetial.Name = "btnOutPutDetial";
            this.btnOutPutDetial.Size = new System.Drawing.Size(91, 22);
            this.btnOutPutDetial.Text = "导出到Excel";
            this.btnOutPutDetial.Click += new System.EventHandler(this.btnOutPutDetial_Click);
            // 
            // dsSlotID
            // 
            this.dsSlotID.AutoSubscribe = false;
            this.dsSlotID.DataSetName = "L3DataSet";
            this.dsSlotID.DeleteMethod = null;
            this.dsSlotID.InsertMethod = null;
            this.dsSlotID.L3DataAdapter = this.Adapter;
            this.dsSlotID.LoadEvent = "Click";
            this.dsSlotID.LoadTrigger = null;
            this.dsSlotID.RefreshValve = 1000;
            this.dsSlotID.SourceCommand = null;
            this.dsSlotID.SourceCondition = "VACTUBE_NAME <> \'3\'";
            this.dsSlotID.SourceMethod = "";
            this.dsSlotID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSlotID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsSlotID.SubscribeTarget = null;
            this.dsSlotID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBelSlotID});
            this.dsSlotID.UpdateEvent = "Click";
            this.dsSlotID.UpdateMethod = null;
            this.dsSlotID.UpdateTrigger = null;
            // 
            // schemadsBelSlotID
            // 
            this.schemadsBelSlotID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBelSlotIDL3DataTableVacTube_Id});
            this.schemadsBelSlotID.TableName = "L3DataTable";
            // 
            // coldsBelSlotIDL3DataTableVacTube_Id
            // 
            this.coldsBelSlotIDL3DataTableVacTube_Id.Caption = "VacTube_Id";
            this.coldsBelSlotIDL3DataTableVacTube_Id.ColumnName = "VacTube_Id";
            this.coldsBelSlotIDL3DataTableVacTube_Id.Namespace = "";
            // 
            // VacTubeBuildMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VacTubeBuildMagFrm";
            this.TabText = "真空槽砌筑信息管理";
            this.Text = "真空槽砌筑信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VacTubeBuildMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.VacTubeBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).EndInit();
            this.bdNP.ResumeLayout(false);
            this.bdNP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlotID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBelSlotID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3DataSet dsSlotID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbSlotID;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Data.DataTable schemadsBelSlotID;
        private System.Data.DataColumn coldsBelSlotIDL3DataTableVacTube_Id;
        private AppSvrHMI.L3CommandParameter cmdpM;
        private AppSvrHMI.L3DataSet dsName;
        private System.Data.DataTable schemadsName;
        private System.Data.DataColumn coldsNameL3DataTableCode;
        private System.Data.DataColumn coldsNameL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvDetail;
        private System.Windows.Forms.BindingNavigator bdNP;
        private System.Windows.Forms.ToolStripButton btnAddDetail;
        private System.Windows.Forms.ToolStripButton btnDelDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirmDetail;
        private System.Windows.Forms.ToolStripButton btnCancelDetail;
        private System.Windows.Forms.ToolStripButton btnQueryDetail;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.ToolStripButton btnOutPutDetial;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private AppSvrHMI.L3DataSet dsDetail;
        private System.Windows.Forms.BindingSource bsDetail;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_ID;
        private System.Data.DataColumn coldsMainL3DataTableVACTUBE_NAME;
        private System.Data.DataColumn coldsMainL3DataTableVACTUBE_ID;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_START_TIME;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_END_TIME;
        private System.Data.DataColumn coldsMainL3DataTableREFRA_FAC;
        private System.Data.DataColumn coldsMainL3DataTableWALL_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableBOT_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableRH_AGE;
        private System.Data.DataColumn coldsMainL3DataTableINWALL_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableINBOT_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableMG_CR_BRI_ELE_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableMG_CR_BRI_DIR_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableMG_CR_BRI_HALF_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableMG_CR_FIR_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableBEAR_FIR_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableSI_CA_BOA_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableLIGHT_MAT_BRI_WASTE;
        private System.Data.DataColumn coldsMainL3DataTablePUG_HIT_MAT_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableCAST_WAST;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private AppSvrHMI.L3CommandParameter cmdpMain;
        private AppSvrHMI.L3Command cmdDetail;
        private AppSvrHMI.L3CommandParameter cmdpDetail;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableNAME;
        private System.Data.DataColumn coldsDetailL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableBUILD_ID;
        private System.Data.DataColumn coldsDetailL3DataTableVACTUBE_NAME;
        private System.Data.DataColumn coldsDetailL3DataTableVACTUBE_ID;
        private System.Data.DataColumn coldsDetailL3DataTableREFRA_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableRH_AGE;
        private System.Data.DataColumn coldsDetailL3DataTableCIR_AGE;
        private System.Data.DataColumn coldsDetailL3DataTableUP_AGE;
        private System.Data.DataColumn coldsDetailL3DataTableDOWN_AGE;
        private System.Data.DataColumn coldsDetailL3DataTableINWALL_BRI_THICK;
        private System.Data.DataColumn coldsDetailL3DataTableINBOT_BRI_THICK;
        private System.Data.DataColumn coldsDetailL3DataTableMG_CR_BRI_ELE_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableMG_CR_BRI_DIR_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableMG_CR_BRI_HALF_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableMG_CR_FIR_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableBEAR_FIR_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableSI_CA_BOA_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableLIGHT_MAT_BRI_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTablePUG_HIT_MAT_WASTE;
        private System.Data.DataColumn coldsDetailL3DataTableCAST_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableREPAIR_POSITION;
        private System.Data.DataColumn coldsDetailL3DataTableREPAIR_CASE;
        private System.Data.DataColumn coldsDetailL3DataTableREPAIR_PER;
        private System.Data.DataColumn coldsDetailL3DataTableTEAMID;
        private System.Data.DataColumn coldsDetailL3DataTableSHIFTID;
        private System.Data.DataColumn coldsDetailL3DataTableNOTE;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUILD_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn VACTUBE_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn VACTUBE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wALLBRITHICKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTBRITHICKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNWALLBRITHICKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNBOTBRITHICKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIELEWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIDIRWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIHALFWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRFIRWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEARFIRWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sICABOAWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIGHTMATBRIWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUGHITMATWASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn vACTUBENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vACTUBEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAFACDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHAGEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIRAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uPAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOWNAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNWALLBRITHICKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNBOTBRITHICKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIELEWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIDIRWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRBRIHALFWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGCRFIRWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bEARFIRWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sICABOAWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIGHTMATBRIWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUGHITMATWASTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTWASTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRCASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn1;
    }
}