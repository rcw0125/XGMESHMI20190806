namespace PlanMag
{
    partial class TappingPlanModifyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TappingPlanModifyFrm));
            this.bsTapping = new System.Windows.Forms.BindingSource(this.components);
            this.dsTapping = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdTapping = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tstxtCasterID = new System.Windows.Forms.ToolStripTextBox();
            this.schemadsTapping = new System.Data.DataTable();
            this.coldsTappingL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableNAME = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coldsTappingL3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLANNER = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_LOTNO = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_STEELGRADE = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRHID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBOF_STATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLF_STATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRH_STATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCASTER_STATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSIDE_STATUS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_LFEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_RHEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableFIR_HEAT_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableDIV_HEATID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTREAT_SEQ = new System.Data.DataColumn();
            this.coldsTappingL3DataTableDESTITATION = new System.Data.DataColumn();
            this.coldsTappingL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_LFEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_RHEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLF_TREATNO = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRH_TREATNO = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCASTER_TREATNO = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCheckFlag = new System.Data.DataColumn();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnCastingFirHeat = new System.Windows.Forms.ToolStripButton();
            this.btnAddNewHeatToCasting = new System.Windows.Forms.ToolStripButton();
            this.btnDestination = new System.Windows.Forms.ToolStripButton();
            this.btnChangeTimeTable = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancelCastinFirHeat = new System.Windows.Forms.ToolStripButton();
            this.btnShowChangePlanTime = new System.Windows.Forms.ToolStripButton();
            this.btnShowWriteInTime = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTapping = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dESTITATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDest = new AppSvrHMI.L3DataSet();
            this.schemadsDest = new System.Data.DataTable();
            this.coldsDestL3DataTableCode = new System.Data.DataColumn();
            this.coldsDestL3DataTableCode_Des = new System.Data.DataColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXECUTEDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRELOTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERSTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDESTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGHEATCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMELFENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMERHENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIVHEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTSENDFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELBACKFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tREATSEQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEWBOFFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFTREATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHTREATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERTREATNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRHEATFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdFirst = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.cmdAddHeats = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.cmdDestCfm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeTime = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.cmdFirstCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.dsDES = new AppSvrHMI.L3DataSet();
            this.cmdChangPlanTime = new AppSvrHMI.L3Command(this.components);
            this.dsWriteTime = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_BlowN2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.dsChangePlanTime = new AppSvrHMI.L3DataSet();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWriteTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangePlanTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTapping
            // 
            this.bsTapping.DataMember = "L3DataTable";
            this.bsTapping.DataSource = this.dsTapping;
            // 
            // dsTapping
            // 
            this.dsTapping.AutoLoad = true;
            this.dsTapping.AutoSubscribe = true;
            this.dsTapping.DataSetName = "L3DataSet";
            this.dsTapping.DeleteMethod = "";
            this.dsTapping.InsertMethod = "";
            this.dsTapping.L3DataAdapter = this.Adapter;
            this.dsTapping.LoadEvent = "Click";
            this.dsTapping.LoadTrigger = null;
            this.dsTapping.RefreshValve = 1000;
            this.dsTapping.SourceCommand = this.cmdTapping;
            this.dsTapping.SourceCondition = null;
            this.dsTapping.SourceMethod = "GetCurDayTappingPlan";
            this.dsTapping.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTapping.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.dsTapping.SubscribeTarget = null;
            this.dsTapping.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapping});
            this.dsTapping.UpdateEvent = "Click";
            this.dsTapping.UpdateMethod = "";
            this.dsTapping.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdTapping
            // 
            this.cmdTapping.Adapter = null;
            this.cmdTapping.MergeReturnTarget = false;
            this.cmdTapping.Method = "";
            this.cmdTapping.Object = "";
            this.cmdTapping.Parameters.Add(this.l3CommandParameter3);
            this.cmdTapping.Parameters.Add(this.l3CommandParameter4);
            this.cmdTapping.ReturnTarget = null;
            this.cmdTapping.ReturnTargetProperty = null;
            this.cmdTapping.Trigger = null;
            this.cmdTapping.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = "";
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.tstxtCasterID;
            this.l3CommandParameter4.SourceProperty = "Text";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // tstxtCasterID
            // 
            this.tstxtCasterID.Name = "tstxtCasterID";
            this.tstxtCasterID.Size = new System.Drawing.Size(100, 25);
            this.tstxtCasterID.Visible = false;
            // 
            // schemadsTapping
            // 
            this.schemadsTapping.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTappingL3DataTableGUID,
            this.coldsTappingL3DataTableNAME,
            this.coldsTappingL3DataTablePLANID,
            this.coldsTappingL3DataTableCONTRACTID,
            this.coldsTappingL3DataTableSTATUS,
            this.coldsTappingL3DataTablePLANDEPT,
            this.coldsTappingL3DataTableEXECUTEDEPT,
            this.coldsTappingL3DataTableCREATEDATE,
            this.coldsTappingL3DataTablePLANEXECUTEDATE,
            this.coldsTappingL3DataTableACTUALEXECUTEDATE,
            this.coldsTappingL3DataTablePLANNER,
            this.coldsTappingL3DataTablePRE_LOTNO,
            this.coldsTappingL3DataTablePREHEATID,
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX,
            this.coldsTappingL3DataTablePRE_STEELGRADE,
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT,
            this.coldsTappingL3DataTableCASTERID,
            this.coldsTappingL3DataTableBOFID,
            this.coldsTappingL3DataTableLFID,
            this.coldsTappingL3DataTableRHID,
            this.coldsTappingL3DataTableBOF_STATUS,
            this.coldsTappingL3DataTableLF_STATUS,
            this.coldsTappingL3DataTableRH_STATUS,
            this.coldsTappingL3DataTableCASTER_STATUS,
            this.coldsTappingL3DataTableSIDE_STATUS,
            this.coldsTappingL3DataTableHEATID,
            this.coldsTappingL3DataTableCASTING_NO,
            this.coldsTappingL3DataTableCASTING_HEAT_CNT,
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED,
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART,
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED,
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND,
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL,
            this.coldsTappingL3DataTableAIM_TIME_LFSTART,
            this.coldsTappingL3DataTableAIM_TIME_LFEND,
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE,
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL,
            this.coldsTappingL3DataTableAIM_TIME_RHSTART,
            this.coldsTappingL3DataTableAIM_TIME_RHEND,
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE,
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL,
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART,
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND,
            this.coldsTappingL3DataTableFIR_HEAT_FLAG,
            this.coldsTappingL3DataTableDIV_HEATID,
            this.coldsTappingL3DataTableTEAMID,
            this.coldsTappingL3DataTableSHIFTID,
            this.coldsTappingL3DataTableSTEELGRADEINDEX,
            this.coldsTappingL3DataTableSTEELGRADE,
            this.coldsTappingL3DataTablePLAN_ORD_ID,
            this.coldsTappingL3DataTableHOT_SEND_FLAG,
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG,
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG,
            this.coldsTappingL3DataTableTREAT_SEQ,
            this.coldsTappingL3DataTableDESTITATION,
            this.coldsTappingL3DataTableNEW_BOF_FLAG,
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED,
            this.coldsTappingL3DataTableACT_TIME_BOFSTART,
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED,
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND,
            this.coldsTappingL3DataTableACT_TIME_LFSTART,
            this.coldsTappingL3DataTableACT_TIME_LFEND,
            this.coldsTappingL3DataTableACT_TIME_RHSTART,
            this.coldsTappingL3DataTableACT_TIME_RHEND,
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL,
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART,
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND,
            this.coldsTappingL3DataTableLF_TREATNO,
            this.coldsTappingL3DataTableRH_TREATNO,
            this.coldsTappingL3DataTableCASTER_TREATNO,
            this.coldsTappingL3DataTableCheckFlag});
            this.schemadsTapping.TableName = "L3DataTable";
            // 
            // coldsTappingL3DataTableGUID
            // 
            this.coldsTappingL3DataTableGUID.Caption = "GUID";
            this.coldsTappingL3DataTableGUID.ColumnName = "GUID";
            this.coldsTappingL3DataTableGUID.DefaultValue = "";
            this.coldsTappingL3DataTableGUID.Namespace = "";
            // 
            // coldsTappingL3DataTableNAME
            // 
            this.coldsTappingL3DataTableNAME.Caption = "NAME";
            this.coldsTappingL3DataTableNAME.ColumnName = "NAME";
            this.coldsTappingL3DataTableNAME.DefaultValue = "";
            this.coldsTappingL3DataTableNAME.Namespace = "";
            // 
            // coldsTappingL3DataTablePLANID
            // 
            this.coldsTappingL3DataTablePLANID.Caption = "PLANID";
            this.coldsTappingL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsTappingL3DataTablePLANID.DefaultValue = "";
            this.coldsTappingL3DataTablePLANID.Namespace = "";
            // 
            // coldsTappingL3DataTableCONTRACTID
            // 
            this.coldsTappingL3DataTableCONTRACTID.Caption = "CONTRACTID";
            this.coldsTappingL3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coldsTappingL3DataTableCONTRACTID.DefaultValue = "";
            this.coldsTappingL3DataTableCONTRACTID.Namespace = "";
            // 
            // coldsTappingL3DataTableSTATUS
            // 
            this.coldsTappingL3DataTableSTATUS.Caption = "STATUS";
            this.coldsTappingL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsTappingL3DataTableSTATUS.DataType = typeof(int);
            this.coldsTappingL3DataTableSTATUS.DefaultValue = 0;
            this.coldsTappingL3DataTableSTATUS.Namespace = "";
            // 
            // coldsTappingL3DataTablePLANDEPT
            // 
            this.coldsTappingL3DataTablePLANDEPT.Caption = "PLANDEPT";
            this.coldsTappingL3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coldsTappingL3DataTablePLANDEPT.DefaultValue = "";
            this.coldsTappingL3DataTablePLANDEPT.Namespace = "";
            // 
            // coldsTappingL3DataTableEXECUTEDEPT
            // 
            this.coldsTappingL3DataTableEXECUTEDEPT.Caption = "EXECUTEDEPT";
            this.coldsTappingL3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coldsTappingL3DataTableEXECUTEDEPT.DefaultValue = "";
            this.coldsTappingL3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coldsTappingL3DataTableCREATEDATE
            // 
            this.coldsTappingL3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coldsTappingL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsTappingL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsTappingL3DataTablePLANEXECUTEDATE
            // 
            this.coldsTappingL3DataTablePLANEXECUTEDATE.Caption = "PLANEXECUTEDATE";
            this.coldsTappingL3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coldsTappingL3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coldsTappingL3DataTableACTUALEXECUTEDATE
            // 
            this.coldsTappingL3DataTableACTUALEXECUTEDATE.Caption = "ACTUALEXECUTEDATE";
            this.coldsTappingL3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coldsTappingL3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coldsTappingL3DataTablePLANNER
            // 
            this.coldsTappingL3DataTablePLANNER.Caption = "PLANNER";
            this.coldsTappingL3DataTablePLANNER.ColumnName = "PLANNER";
            this.coldsTappingL3DataTablePLANNER.DefaultValue = "";
            this.coldsTappingL3DataTablePLANNER.Namespace = "";
            // 
            // coldsTappingL3DataTablePRE_LOTNO
            // 
            this.coldsTappingL3DataTablePRE_LOTNO.Caption = "PRE_LOTNO";
            this.coldsTappingL3DataTablePRE_LOTNO.ColumnName = "PRE_LOTNO";
            this.coldsTappingL3DataTablePRE_LOTNO.DefaultValue = "";
            this.coldsTappingL3DataTablePRE_LOTNO.Namespace = "";
            // 
            // coldsTappingL3DataTablePREHEATID
            // 
            this.coldsTappingL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsTappingL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsTappingL3DataTablePREHEATID.DefaultValue = "";
            this.coldsTappingL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsTappingL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsTappingL3DataTablePRE_STEELGRADE
            // 
            this.coldsTappingL3DataTablePRE_STEELGRADE.Caption = "PRE_STEELGRADE";
            this.coldsTappingL3DataTablePRE_STEELGRADE.ColumnName = "PRE_STEELGRADE";
            this.coldsTappingL3DataTablePRE_STEELGRADE.DefaultValue = "";
            this.coldsTappingL3DataTablePRE_STEELGRADE.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TAPPED_WEIGHT
            // 
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.Caption = "AIM_TAPPED_WEIGHT";
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.ColumnName = "AIM_TAPPED_WEIGHT";
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.DataType = typeof(double);
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.DefaultValue = 0;
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.Namespace = "";
            // 
            // coldsTappingL3DataTableCASTERID
            // 
            this.coldsTappingL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsTappingL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsTappingL3DataTableCASTERID.DefaultValue = "";
            this.coldsTappingL3DataTableCASTERID.Namespace = "";
            // 
            // coldsTappingL3DataTableBOFID
            // 
            this.coldsTappingL3DataTableBOFID.Caption = "BOFID";
            this.coldsTappingL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsTappingL3DataTableBOFID.DefaultValue = "";
            this.coldsTappingL3DataTableBOFID.Namespace = "";
            // 
            // coldsTappingL3DataTableLFID
            // 
            this.coldsTappingL3DataTableLFID.Caption = "LFID";
            this.coldsTappingL3DataTableLFID.ColumnName = "LFID";
            this.coldsTappingL3DataTableLFID.DefaultValue = "";
            this.coldsTappingL3DataTableLFID.Namespace = "";
            // 
            // coldsTappingL3DataTableRHID
            // 
            this.coldsTappingL3DataTableRHID.Caption = "RHID";
            this.coldsTappingL3DataTableRHID.ColumnName = "RHID";
            this.coldsTappingL3DataTableRHID.DefaultValue = "";
            this.coldsTappingL3DataTableRHID.Namespace = "";
            // 
            // coldsTappingL3DataTableBOF_STATUS
            // 
            this.coldsTappingL3DataTableBOF_STATUS.Caption = "BOF_STATUS";
            this.coldsTappingL3DataTableBOF_STATUS.ColumnName = "BOF_STATUS";
            this.coldsTappingL3DataTableBOF_STATUS.DefaultValue = "";
            this.coldsTappingL3DataTableBOF_STATUS.Namespace = "";
            // 
            // coldsTappingL3DataTableLF_STATUS
            // 
            this.coldsTappingL3DataTableLF_STATUS.Caption = "LF_STATUS";
            this.coldsTappingL3DataTableLF_STATUS.ColumnName = "LF_STATUS";
            this.coldsTappingL3DataTableLF_STATUS.DefaultValue = "";
            this.coldsTappingL3DataTableLF_STATUS.Namespace = "";
            // 
            // coldsTappingL3DataTableRH_STATUS
            // 
            this.coldsTappingL3DataTableRH_STATUS.Caption = "RH_STATUS";
            this.coldsTappingL3DataTableRH_STATUS.ColumnName = "RH_STATUS";
            this.coldsTappingL3DataTableRH_STATUS.DefaultValue = "";
            this.coldsTappingL3DataTableRH_STATUS.Namespace = "";
            // 
            // coldsTappingL3DataTableCASTER_STATUS
            // 
            this.coldsTappingL3DataTableCASTER_STATUS.Caption = "CASTER_STATUS";
            this.coldsTappingL3DataTableCASTER_STATUS.ColumnName = "CASTER_STATUS";
            this.coldsTappingL3DataTableCASTER_STATUS.DefaultValue = "";
            this.coldsTappingL3DataTableCASTER_STATUS.Namespace = "";
            // 
            // coldsTappingL3DataTableSIDE_STATUS
            // 
            this.coldsTappingL3DataTableSIDE_STATUS.Caption = "SIDE_STATUS";
            this.coldsTappingL3DataTableSIDE_STATUS.ColumnName = "SIDE_STATUS";
            this.coldsTappingL3DataTableSIDE_STATUS.DefaultValue = "";
            this.coldsTappingL3DataTableSIDE_STATUS.Namespace = "";
            // 
            // coldsTappingL3DataTableHEATID
            // 
            this.coldsTappingL3DataTableHEATID.Caption = "HEATID";
            this.coldsTappingL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsTappingL3DataTableHEATID.DefaultValue = "";
            this.coldsTappingL3DataTableHEATID.Namespace = "";
            // 
            // coldsTappingL3DataTableCASTING_NO
            // 
            this.coldsTappingL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsTappingL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsTappingL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsTappingL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsTappingL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsTappingL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsTappingL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsTappingL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsTappingL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsTappingL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_IRONPREPARED
            // 
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED.Caption = "AIM_TIME_IRONPREPARED";
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED.ColumnName = "AIM_TIME_IRONPREPARED";
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_BOFSTART
            // 
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART.Caption = "AIM_TIME_BOFSTART";
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART.ColumnName = "AIM_TIME_BOFSTART";
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_BOFSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_BOFTAPPED
            // 
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED.Caption = "AIM_TIME_BOFTAPPED";
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED.ColumnName = "AIM_TIME_BOFTAPPED";
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND
            // 
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND.Caption = "AIM_TIME_TAPPEDSIDEEND";
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND.ColumnName = "AIM_TIME_TAPPEDSIDEEND";
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_LFARRIVAL
            // 
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL.Caption = "AIM_TIME_LFARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL.ColumnName = "AIM_TIME_LFARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_LFARRIVAL.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_LFSTART
            // 
            this.coldsTappingL3DataTableAIM_TIME_LFSTART.Caption = "AIM_TIME_LFSTART";
            this.coldsTappingL3DataTableAIM_TIME_LFSTART.ColumnName = "AIM_TIME_LFSTART";
            this.coldsTappingL3DataTableAIM_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_LFSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_LFEND
            // 
            this.coldsTappingL3DataTableAIM_TIME_LFEND.Caption = "AIM_TIME_LFEND";
            this.coldsTappingL3DataTableAIM_TIME_LFEND.ColumnName = "AIM_TIME_LFEND";
            this.coldsTappingL3DataTableAIM_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_LFEND.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_LFLEAVE
            // 
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE.Caption = "AIM_TIME_LFLEAVE";
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE.ColumnName = "AIM_TIME_LFLEAVE";
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_LFLEAVE.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_RHARRIVAL
            // 
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL.Caption = "AIM_TIME_RHARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL.ColumnName = "AIM_TIME_RHARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_RHARRIVAL.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_RHSTART
            // 
            this.coldsTappingL3DataTableAIM_TIME_RHSTART.Caption = "AIM_TIME_RHSTART";
            this.coldsTappingL3DataTableAIM_TIME_RHSTART.ColumnName = "AIM_TIME_RHSTART";
            this.coldsTappingL3DataTableAIM_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_RHSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_RHEND
            // 
            this.coldsTappingL3DataTableAIM_TIME_RHEND.Caption = "AIM_TIME_RHEND";
            this.coldsTappingL3DataTableAIM_TIME_RHEND.ColumnName = "AIM_TIME_RHEND";
            this.coldsTappingL3DataTableAIM_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_RHEND.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_RHLEAVE
            // 
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE.Caption = "AIM_TIME_RHLEAVE";
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE.ColumnName = "AIM_TIME_RHLEAVE";
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_RHLEAVE.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL
            // 
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL.Caption = "AIM_TIME_CASTERARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL.ColumnName = "AIM_TIME_CASTERARRIVAL";
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_CASTINGSTART
            // 
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.Caption = "AIM_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.ColumnName = "AIM_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_CASTINGEND
            // 
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND.Caption = "AIM_TIME_CASTINGEND";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND.ColumnName = "AIM_TIME_CASTINGEND";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsTappingL3DataTableFIR_HEAT_FLAG
            // 
            this.coldsTappingL3DataTableFIR_HEAT_FLAG.Caption = "FIR_HEAT_FLAG";
            this.coldsTappingL3DataTableFIR_HEAT_FLAG.ColumnName = "FIR_HEAT_FLAG";
            this.coldsTappingL3DataTableFIR_HEAT_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableFIR_HEAT_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableFIR_HEAT_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableDIV_HEATID
            // 
            this.coldsTappingL3DataTableDIV_HEATID.Caption = "DIV_HEATID";
            this.coldsTappingL3DataTableDIV_HEATID.ColumnName = "DIV_HEATID";
            this.coldsTappingL3DataTableDIV_HEATID.DefaultValue = "";
            this.coldsTappingL3DataTableDIV_HEATID.Namespace = "";
            // 
            // coldsTappingL3DataTableTEAMID
            // 
            this.coldsTappingL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsTappingL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsTappingL3DataTableTEAMID.DefaultValue = "";
            this.coldsTappingL3DataTableTEAMID.Namespace = "";
            // 
            // coldsTappingL3DataTableSHIFTID
            // 
            this.coldsTappingL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsTappingL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsTappingL3DataTableSHIFTID.DefaultValue = "";
            this.coldsTappingL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsTappingL3DataTableSTEELGRADEINDEX
            // 
            this.coldsTappingL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsTappingL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsTappingL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsTappingL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsTappingL3DataTableSTEELGRADE
            // 
            this.coldsTappingL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsTappingL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsTappingL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsTappingL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsTappingL3DataTablePLAN_ORD_ID
            // 
            this.coldsTappingL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsTappingL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsTappingL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsTappingL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsTappingL3DataTableHOT_SEND_FLAG
            // 
            this.coldsTappingL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsTappingL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsTappingL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableSTEEL_RETURN_FLAG
            // 
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG.Caption = "STEEL_RETURN_FLAG";
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG.ColumnName = "STEEL_RETURN_FLAG";
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableSTEEL_RETURN_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableSTEEL_BACK_FLAG
            // 
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG.Caption = "STEEL_BACK_FLAG";
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG.ColumnName = "STEEL_BACK_FLAG";
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableSTEEL_BACK_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableTREAT_SEQ
            // 
            this.coldsTappingL3DataTableTREAT_SEQ.Caption = "TREAT_SEQ";
            this.coldsTappingL3DataTableTREAT_SEQ.ColumnName = "TREAT_SEQ";
            this.coldsTappingL3DataTableTREAT_SEQ.DefaultValue = "";
            this.coldsTappingL3DataTableTREAT_SEQ.Namespace = "";
            // 
            // coldsTappingL3DataTableDESTITATION
            // 
            this.coldsTappingL3DataTableDESTITATION.Caption = "DESTITATION";
            this.coldsTappingL3DataTableDESTITATION.ColumnName = "DESTITATION";
            this.coldsTappingL3DataTableDESTITATION.DefaultValue = "";
            this.coldsTappingL3DataTableDESTITATION.Namespace = "";
            // 
            // coldsTappingL3DataTableNEW_BOF_FLAG
            // 
            this.coldsTappingL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsTappingL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsTappingL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_IRONPREPARED
            // 
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED.Caption = "ACT_TIME_IRONPREPARED";
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED.ColumnName = "ACT_TIME_IRONPREPARED";
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_BOFSTART
            // 
            this.coldsTappingL3DataTableACT_TIME_BOFSTART.Caption = "ACT_TIME_BOFSTART";
            this.coldsTappingL3DataTableACT_TIME_BOFSTART.ColumnName = "ACT_TIME_BOFSTART";
            this.coldsTappingL3DataTableACT_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_BOFSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_BOFTAPPED
            // 
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED.Caption = "ACT_TIME_BOFTAPPED";
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED.ColumnName = "ACT_TIME_BOFTAPPED";
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND
            // 
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND.Caption = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND.ColumnName = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_LFSTART
            // 
            this.coldsTappingL3DataTableACT_TIME_LFSTART.Caption = "ACT_TIME_LFSTART";
            this.coldsTappingL3DataTableACT_TIME_LFSTART.ColumnName = "ACT_TIME_LFSTART";
            this.coldsTappingL3DataTableACT_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_LFSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_LFEND
            // 
            this.coldsTappingL3DataTableACT_TIME_LFEND.Caption = "ACT_TIME_LFEND";
            this.coldsTappingL3DataTableACT_TIME_LFEND.ColumnName = "ACT_TIME_LFEND";
            this.coldsTappingL3DataTableACT_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_LFEND.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_RHSTART
            // 
            this.coldsTappingL3DataTableACT_TIME_RHSTART.Caption = "ACT_TIME_RHSTART";
            this.coldsTappingL3DataTableACT_TIME_RHSTART.ColumnName = "ACT_TIME_RHSTART";
            this.coldsTappingL3DataTableACT_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_RHSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_RHEND
            // 
            this.coldsTappingL3DataTableACT_TIME_RHEND.Caption = "ACT_TIME_RHEND";
            this.coldsTappingL3DataTableACT_TIME_RHEND.ColumnName = "ACT_TIME_RHEND";
            this.coldsTappingL3DataTableACT_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_RHEND.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_CASTERARRIVAL
            // 
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL.Caption = "ACT_TIME_CASTERARRIVAL";
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL.ColumnName = "ACT_TIME_CASTERARRIVAL";
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_CASTINGSTART
            // 
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART.Caption = "ACT_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART.ColumnName = "ACT_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableACT_TIME_CASTINGEND
            // 
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND.Caption = "ACT_TIME_CASTINGEND";
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND.ColumnName = "ACT_TIME_CASTINGEND";
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableACT_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsTappingL3DataTableLF_TREATNO
            // 
            this.coldsTappingL3DataTableLF_TREATNO.Caption = "LF_TREATNO";
            this.coldsTappingL3DataTableLF_TREATNO.ColumnName = "LF_TREATNO";
            this.coldsTappingL3DataTableLF_TREATNO.DefaultValue = "";
            this.coldsTappingL3DataTableLF_TREATNO.Namespace = "";
            // 
            // coldsTappingL3DataTableRH_TREATNO
            // 
            this.coldsTappingL3DataTableRH_TREATNO.Caption = "RH_TREATNO";
            this.coldsTappingL3DataTableRH_TREATNO.ColumnName = "RH_TREATNO";
            this.coldsTappingL3DataTableRH_TREATNO.DefaultValue = "";
            this.coldsTappingL3DataTableRH_TREATNO.Namespace = "";
            // 
            // coldsTappingL3DataTableCASTER_TREATNO
            // 
            this.coldsTappingL3DataTableCASTER_TREATNO.Caption = "CASTER_TREATNO";
            this.coldsTappingL3DataTableCASTER_TREATNO.ColumnName = "CASTER_TREATNO";
            this.coldsTappingL3DataTableCASTER_TREATNO.DefaultValue = "";
            this.coldsTappingL3DataTableCASTER_TREATNO.Namespace = "";
            // 
            // coldsTappingL3DataTableCheckFlag
            // 
            this.coldsTappingL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsTappingL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsTappingL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsTappingL3DataTableCheckFlag.Namespace = "";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Visible = false;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = "-1";
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "";
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.tstxtCasterID;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCastingFirHeat,
            this.btnAddNewHeatToCasting,
            this.btnDestination,
            this.btnChangeTimeTable,
            this.btnExit,
            this.btnCancelCastinFirHeat,
            this.btnShowChangePlanTime,
            this.btnShowWriteInTime});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(953, 43);
            this.tSp1.TabIndex = 147;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnCastingFirHeat
            // 
            this.btnCastingFirHeat.Image = ((System.Drawing.Image)(resources.GetObject("btnCastingFirHeat.Image")));
            this.btnCastingFirHeat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCastingFirHeat.Name = "btnCastingFirHeat";
            this.btnCastingFirHeat.Size = new System.Drawing.Size(125, 40);
            this.btnCastingFirHeat.Text = "指定浇次第一炉";
            this.btnCastingFirHeat.Visible = false;
            this.btnCastingFirHeat.Click += new System.EventHandler(this.btnCastingFirHeat_Click);
            // 
            // btnAddNewHeatToCasting
            // 
            this.btnAddNewHeatToCasting.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewHeatToCasting.Image")));
            this.btnAddNewHeatToCasting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewHeatToCasting.Name = "btnAddNewHeatToCasting";
            this.btnAddNewHeatToCasting.Size = new System.Drawing.Size(149, 40);
            this.btnAddNewHeatToCasting.Text = "添加炉数到最近浇次";
            this.btnAddNewHeatToCasting.Visible = false;
            this.btnAddNewHeatToCasting.Click += new System.EventHandler(this.btnAddNewHeatToCasting_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Image = ((System.Drawing.Image)(resources.GetObject("btnDestination.Image")));
            this.btnDestination.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(89, 40);
            this.btnDestination.Text = "指定去向";
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnChangeTimeTable
            // 
            this.btnChangeTimeTable.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeTimeTable.Image")));
            this.btnChangeTimeTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeTimeTable.Name = "btnChangeTimeTable";
            this.btnChangeTimeTable.Size = new System.Drawing.Size(125, 40);
            this.btnChangeTimeTable.Text = "修正火车时刻表";
            this.btnChangeTimeTable.Click += new System.EventHandler(this.btnChangeTimeTable_Click);
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
            // btnCancelCastinFirHeat
            // 
            this.btnCancelCastinFirHeat.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelCastinFirHeat.Image")));
            this.btnCancelCastinFirHeat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelCastinFirHeat.Name = "btnCancelCastinFirHeat";
            this.btnCancelCastinFirHeat.Size = new System.Drawing.Size(125, 40);
            this.btnCancelCastinFirHeat.Text = "取消浇次第一炉";
            this.btnCancelCastinFirHeat.Visible = false;
            this.btnCancelCastinFirHeat.Click += new System.EventHandler(this.btnCancelCastinFirHeat_Click);
            // 
            // btnShowChangePlanTime
            // 
            this.btnShowChangePlanTime.Image = ((System.Drawing.Image)(resources.GetObject("btnShowChangePlanTime.Image")));
            this.btnShowChangePlanTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowChangePlanTime.Name = "btnShowChangePlanTime";
            this.btnShowChangePlanTime.Size = new System.Drawing.Size(113, 40);
            this.btnShowChangePlanTime.Text = "修改计划时间";
            this.btnShowChangePlanTime.Click += new System.EventHandler(this.btnShowChangePlanTime_Click);
            // 
            // btnShowWriteInTime
            // 
            this.btnShowWriteInTime.Image = ((System.Drawing.Image)(resources.GetObject("btnShowWriteInTime.Image")));
            this.btnShowWriteInTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowWriteInTime.Name = "btnShowWriteInTime";
            this.btnShowWriteInTime.Size = new System.Drawing.Size(125, 40);
            this.btnShowWriteInTime.Text = "转炉非作业时间";
            this.btnShowWriteInTime.Visible = false;
            this.btnShowWriteInTime.Click += new System.EventHandler(this.btnShowWriteInTime_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvTapping);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(953, 485);
            this.hmiRootPanel1.TabIndex = 149;
            // 
            // dvTapping
            // 
            this.dvTapping.AllowUserToAddRows = false;
            this.dvTapping.AutoGenerateColumns = false;
            this.dvTapping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvTapping.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.dESTITATIONDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.pLANIDDataGridViewTextBoxColumn,
            this.cONTRACTIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.pLANDEPTDataGridViewTextBoxColumn,
            this.eXECUTEDEPTDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn,
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn,
            this.pLANNERDataGridViewTextBoxColumn,
            this.pRELOTNODataGridViewTextBoxColumn,
            this.pREHEATIDDataGridViewTextBoxColumn,
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.pRESTEELGRADEDataGridViewTextBoxColumn,
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.bOFIDDataGridViewTextBoxColumn,
            this.lFIDDataGridViewTextBoxColumn,
            this.rHIDDataGridViewTextBoxColumn,
            this.bOFSTATUSDataGridViewTextBoxColumn,
            this.lFSTATUSDataGridViewTextBoxColumn,
            this.rHSTATUSDataGridViewTextBoxColumn,
            this.cASTERSTATUSDataGridViewTextBoxColumn,
            this.sIDESTATUSDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn,
            this.cASTINGNODataGridViewTextBoxColumn,
            this.cASTINGHEATCNTDataGridViewTextBoxColumn,
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn,
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn,
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn,
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn,
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn,
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn,
            this.aIMTIMELFENDDataGridViewTextBoxColumn,
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn,
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn,
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn,
            this.aIMTIMERHENDDataGridViewTextBoxColumn,
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn,
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn,
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn,
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn,
            this.dIVHEATIDDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.pLANORDIDDataGridViewTextBoxColumn,
            this.hOTSENDFLAGDataGridViewTextBoxColumn,
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn,
            this.sTEELBACKFLAGDataGridViewTextBoxColumn,
            this.tREATSEQDataGridViewTextBoxColumn,
            this.nEWBOFFLAGDataGridViewTextBoxColumn,
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn,
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn,
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn,
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn,
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn,
            this.aCTTIMELFENDDataGridViewTextBoxColumn,
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn,
            this.aCTTIMERHENDDataGridViewTextBoxColumn,
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn,
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn,
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn,
            this.lFTREATNODataGridViewTextBoxColumn,
            this.rHTREATNODataGridViewTextBoxColumn,
            this.cASTERTREATNODataGridViewTextBoxColumn,
            this.fIRHEATFLAGDataGridViewTextBoxColumn});
            this.dvTapping.DataSource = this.bsTapping;
            this.dvTapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTapping.Location = new System.Drawing.Point(0, 0);
            this.dvTapping.Name = "dvTapping";
            this.dvTapping.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvTapping.RowTemplate.Height = 23;
            this.dvTapping.Size = new System.Drawing.Size(949, 481);
            this.dvTapping.TabIndex = 2;
            this.dvTapping.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvTapping_CellPainting);
            this.dvTapping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvTapping_CellContentClick);
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
            // dESTITATIONDataGridViewTextBoxColumn
            // 
            this.dESTITATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTITATION";
            this.dESTITATIONDataGridViewTextBoxColumn.DataSource = this.dsDest;
            this.dESTITATIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.dESTITATIONDataGridViewTextBoxColumn.HeaderText = "去向";
            this.dESTITATIONDataGridViewTextBoxColumn.Name = "dESTITATIONDataGridViewTextBoxColumn";
            this.dESTITATIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dESTITATIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dESTITATIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsDest
            // 
            this.dsDest.AutoLoad = true;
            this.dsDest.AutoSubscribe = true;
            this.dsDest.DataSetName = "L3DataSet";
            this.dsDest.DeleteMethod = null;
            this.dsDest.InsertMethod = null;
            this.dsDest.L3DataAdapter = this.Adapter;
            this.dsDest.LoadEvent = "Click";
            this.dsDest.LoadTrigger = null;
            this.dsDest.RefreshValve = 1000;
            this.dsDest.SourceCommand = null;
            this.dsDest.SourceCondition = "CODE_GROUP = \'DESTINATION\'";
            this.dsDest.SourceMethod = "";
            this.dsDest.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDest.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDest.SubscribeTarget = null;
            this.dsDest.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDest});
            this.dsDest.UpdateEvent = "Click";
            this.dsDest.UpdateMethod = null;
            this.dsDest.UpdateTrigger = null;
            // 
            // schemadsDest
            // 
            this.schemadsDest.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDestL3DataTableCode,
            this.coldsDestL3DataTableCode_Des});
            this.schemadsDest.TableName = "L3DataTable";
            // 
            // coldsDestL3DataTableCode
            // 
            this.coldsDestL3DataTableCode.Caption = "Code";
            this.coldsDestL3DataTableCode.ColumnName = "Code";
            this.coldsDestL3DataTableCode.Namespace = "";
            // 
            // coldsDestL3DataTableCode_Des
            // 
            this.coldsDestL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDestL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDestL3DataTableCode_Des.Namespace = "";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.pLANIDDataGridViewTextBoxColumn.Name = "pLANIDDataGridViewTextBoxColumn";
            this.pLANIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONTRACTIDDataGridViewTextBoxColumn
            // 
            this.cONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "CONTRACTID";
            this.cONTRACTIDDataGridViewTextBoxColumn.HeaderText = "状态";
            this.cONTRACTIDDataGridViewTextBoxColumn.Name = "cONTRACTIDDataGridViewTextBoxColumn";
            this.cONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "计划状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANDEPTDataGridViewTextBoxColumn
            // 
            this.pLANDEPTDataGridViewTextBoxColumn.DataPropertyName = "PLANDEPT";
            this.pLANDEPTDataGridViewTextBoxColumn.HeaderText = "计划制订单位";
            this.pLANDEPTDataGridViewTextBoxColumn.Name = "pLANDEPTDataGridViewTextBoxColumn";
            this.pLANDEPTDataGridViewTextBoxColumn.Visible = false;
            // 
            // eXECUTEDEPTDataGridViewTextBoxColumn
            // 
            this.eXECUTEDEPTDataGridViewTextBoxColumn.DataPropertyName = "EXECUTEDEPT";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.HeaderText = "计划执行单位";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Name = "eXECUTEDEPTDataGridViewTextBoxColumn";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANEXECUTEDATEDataGridViewTextBoxColumn
            // 
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANEXECUTEDATE";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.HeaderText = "计划执行日期";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Name = "pLANEXECUTEDATEDataGridViewTextBoxColumn";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTUALEXECUTEDATEDataGridViewTextBoxColumn
            // 
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.DataPropertyName = "ACTUALEXECUTEDATE";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.HeaderText = "实际执行日期";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.Name = "aCTUALEXECUTEDATEDataGridViewTextBoxColumn";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANNERDataGridViewTextBoxColumn
            // 
            this.pLANNERDataGridViewTextBoxColumn.DataPropertyName = "PLANNER";
            this.pLANNERDataGridViewTextBoxColumn.HeaderText = "计划员";
            this.pLANNERDataGridViewTextBoxColumn.Name = "pLANNERDataGridViewTextBoxColumn";
            this.pLANNERDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRELOTNODataGridViewTextBoxColumn
            // 
            this.pRELOTNODataGridViewTextBoxColumn.DataPropertyName = "PRE_LOTNO";
            this.pRELOTNODataGridViewTextBoxColumn.HeaderText = "预定包次号";
            this.pRELOTNODataGridViewTextBoxColumn.Name = "pRELOTNODataGridViewTextBoxColumn";
            this.pRELOTNODataGridViewTextBoxColumn.Visible = false;
            // 
            // pREHEATIDDataGridViewTextBoxColumn
            // 
            this.pREHEATIDDataGridViewTextBoxColumn.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn.Name = "pREHEATIDDataGridViewTextBoxColumn";
            this.pREHEATIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRESTEELGRADEDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADE";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.HeaderText = "预定钢种";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.Name = "pRESTEELGRADEDataGridViewTextBoxColumn";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aIMTAPPEDWEIGHTDataGridViewTextBoxColumn
            // 
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TAPPED_WEIGHT";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.HeaderText = "目标出钢量";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.Name = "aIMTAPPEDWEIGHTDataGridViewTextBoxColumn";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "转炉炉座号";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lFIDDataGridViewTextBoxColumn
            // 
            this.lFIDDataGridViewTextBoxColumn.DataPropertyName = "LFID";
            this.lFIDDataGridViewTextBoxColumn.HeaderText = "LF炉座号";
            this.lFIDDataGridViewTextBoxColumn.Name = "lFIDDataGridViewTextBoxColumn";
            this.lFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rHIDDataGridViewTextBoxColumn
            // 
            this.rHIDDataGridViewTextBoxColumn.DataPropertyName = "RHID";
            this.rHIDDataGridViewTextBoxColumn.HeaderText = "RH炉座号";
            this.rHIDDataGridViewTextBoxColumn.Name = "rHIDDataGridViewTextBoxColumn";
            this.rHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOFSTATUSDataGridViewTextBoxColumn
            // 
            this.bOFSTATUSDataGridViewTextBoxColumn.DataPropertyName = "BOF_STATUS";
            this.bOFSTATUSDataGridViewTextBoxColumn.HeaderText = "转炉状态";
            this.bOFSTATUSDataGridViewTextBoxColumn.Name = "bOFSTATUSDataGridViewTextBoxColumn";
            this.bOFSTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // lFSTATUSDataGridViewTextBoxColumn
            // 
            this.lFSTATUSDataGridViewTextBoxColumn.DataPropertyName = "LF_STATUS";
            this.lFSTATUSDataGridViewTextBoxColumn.HeaderText = "LF炉状态";
            this.lFSTATUSDataGridViewTextBoxColumn.Name = "lFSTATUSDataGridViewTextBoxColumn";
            this.lFSTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // rHSTATUSDataGridViewTextBoxColumn
            // 
            this.rHSTATUSDataGridViewTextBoxColumn.DataPropertyName = "RH_STATUS";
            this.rHSTATUSDataGridViewTextBoxColumn.HeaderText = "RH炉状态";
            this.rHSTATUSDataGridViewTextBoxColumn.Name = "rHSTATUSDataGridViewTextBoxColumn";
            this.rHSTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTERSTATUSDataGridViewTextBoxColumn
            // 
            this.cASTERSTATUSDataGridViewTextBoxColumn.DataPropertyName = "CASTER_STATUS";
            this.cASTERSTATUSDataGridViewTextBoxColumn.HeaderText = "铸机状态";
            this.cASTERSTATUSDataGridViewTextBoxColumn.Name = "cASTERSTATUSDataGridViewTextBoxColumn";
            this.cASTERSTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // sIDESTATUSDataGridViewTextBoxColumn
            // 
            this.sIDESTATUSDataGridViewTextBoxColumn.DataPropertyName = "SIDE_STATUS";
            this.sIDESTATUSDataGridViewTextBoxColumn.HeaderText = "炉后状态";
            this.sIDESTATUSDataGridViewTextBoxColumn.Name = "sIDESTATUSDataGridViewTextBoxColumn";
            this.sIDESTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cASTINGNODataGridViewTextBoxColumn
            // 
            this.cASTINGNODataGridViewTextBoxColumn.DataPropertyName = "CASTING_NO";
            this.cASTINGNODataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.cASTINGNODataGridViewTextBoxColumn.Name = "cASTINGNODataGridViewTextBoxColumn";
            this.cASTINGNODataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTINGNODataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTINGHEATCNTDataGridViewTextBoxColumn
            // 
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.DataPropertyName = "CASTING_HEAT_CNT";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Name = "cASTINGHEATCNTDataGridViewTextBoxColumn";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn
            // 
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_IRONPREPARED";
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn.HeaderText = "主原料装入时刻";
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn.Name = "aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn";
            this.aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMEBOFSTARTDataGridViewTextBoxColumn
            // 
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_BOFSTART";
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn.HeaderText = "吹炼始";
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn.Name = "aIMTIMEBOFSTARTDataGridViewTextBoxColumn";
            this.aIMTIMEBOFSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn
            // 
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_BOFTAPPED";
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn.HeaderText = "出钢终";
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn.Name = "aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn";
            this.aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn
            // 
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_TAPPEDSIDEEND";
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.HeaderText = "炉后处理结束";
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.Name = "aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn";
            this.aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMELFARRIVALDataGridViewTextBoxColumn
            // 
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_LFARRIVAL";
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn.HeaderText = "LF进站时刻";
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn.Name = "aIMTIMELFARRIVALDataGridViewTextBoxColumn";
            this.aIMTIMELFARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMELFSTARTDataGridViewTextBoxColumn
            // 
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_LFSTART";
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn.HeaderText = "LF始";
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn.Name = "aIMTIMELFSTARTDataGridViewTextBoxColumn";
            this.aIMTIMELFSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMELFENDDataGridViewTextBoxColumn
            // 
            this.aIMTIMELFENDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_LFEND";
            this.aIMTIMELFENDDataGridViewTextBoxColumn.HeaderText = "LF终";
            this.aIMTIMELFENDDataGridViewTextBoxColumn.Name = "aIMTIMELFENDDataGridViewTextBoxColumn";
            this.aIMTIMELFENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMELFLEAVEDataGridViewTextBoxColumn
            // 
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_LFLEAVE";
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn.HeaderText = "LF出站时刻";
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn.Name = "aIMTIMELFLEAVEDataGridViewTextBoxColumn";
            this.aIMTIMELFLEAVEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMERHARRIVALDataGridViewTextBoxColumn
            // 
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_RHARRIVAL";
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn.HeaderText = "RH进站时刻";
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn.Name = "aIMTIMERHARRIVALDataGridViewTextBoxColumn";
            this.aIMTIMERHARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMERHSTARTDataGridViewTextBoxColumn
            // 
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_RHSTART";
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn.HeaderText = "RH始";
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn.Name = "aIMTIMERHSTARTDataGridViewTextBoxColumn";
            this.aIMTIMERHSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMERHENDDataGridViewTextBoxColumn
            // 
            this.aIMTIMERHENDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_RHEND";
            this.aIMTIMERHENDDataGridViewTextBoxColumn.HeaderText = "RH终";
            this.aIMTIMERHENDDataGridViewTextBoxColumn.Name = "aIMTIMERHENDDataGridViewTextBoxColumn";
            this.aIMTIMERHENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMERHLEAVEDataGridViewTextBoxColumn
            // 
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_RHLEAVE";
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn.HeaderText = "RH出站时刻";
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn.Name = "aIMTIMERHLEAVEDataGridViewTextBoxColumn";
            this.aIMTIMERHLEAVEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMECASTERARRIVALDataGridViewTextBoxColumn
            // 
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_CASTERARRIVAL";
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn.HeaderText = "铸机到达时刻";
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn.Name = "aIMTIMECASTERARRIVALDataGridViewTextBoxColumn";
            this.aIMTIMECASTERARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMECASTINGSTARTDataGridViewTextBoxColumn
            // 
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_CASTINGSTART";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.HeaderText = "注入始";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.Name = "aIMTIMECASTINGSTARTDataGridViewTextBoxColumn";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aIMTIMECASTINGENDDataGridViewTextBoxColumn
            // 
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_CASTINGEND";
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn.HeaderText = "注入终";
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn.Name = "aIMTIMECASTINGENDDataGridViewTextBoxColumn";
            this.aIMTIMECASTINGENDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIVHEATIDDataGridViewTextBoxColumn
            // 
            this.dIVHEATIDDataGridViewTextBoxColumn.DataPropertyName = "DIV_HEATID";
            this.dIVHEATIDDataGridViewTextBoxColumn.HeaderText = "虚拟熔炼号";
            this.dIVHEATIDDataGridViewTextBoxColumn.Name = "dIVHEATIDDataGridViewTextBoxColumn";
            this.dIVHEATIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "实际炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "实际钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            this.pLANORDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hOTSENDFLAGDataGridViewTextBoxColumn
            // 
            this.hOTSENDFLAGDataGridViewTextBoxColumn.DataPropertyName = "HOT_SEND_FLAG";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Name = "hOTSENDFLAGDataGridViewTextBoxColumn";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTEELRETURNFLAGDataGridViewTextBoxColumn
            // 
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn.DataPropertyName = "STEEL_RETURN_FLAG";
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn.HeaderText = "回炉标志";
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn.Name = "sTEELRETURNFLAGDataGridViewTextBoxColumn";
            this.sTEELRETURNFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTEELBACKFLAGDataGridViewTextBoxColumn
            // 
            this.sTEELBACKFLAGDataGridViewTextBoxColumn.DataPropertyName = "STEEL_BACK_FLAG";
            this.sTEELBACKFLAGDataGridViewTextBoxColumn.HeaderText = "返送标志";
            this.sTEELBACKFLAGDataGridViewTextBoxColumn.Name = "sTEELBACKFLAGDataGridViewTextBoxColumn";
            this.sTEELBACKFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // tREATSEQDataGridViewTextBoxColumn
            // 
            this.tREATSEQDataGridViewTextBoxColumn.DataPropertyName = "TREAT_SEQ";
            this.tREATSEQDataGridViewTextBoxColumn.HeaderText = "铸机处理顺序号：08000001";
            this.tREATSEQDataGridViewTextBoxColumn.Name = "tREATSEQDataGridViewTextBoxColumn";
            this.tREATSEQDataGridViewTextBoxColumn.Visible = false;
            // 
            // nEWBOFFLAGDataGridViewTextBoxColumn
            // 
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataPropertyName = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.HeaderText = "转炉标志";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Name = "nEWBOFFLAGDataGridViewTextBoxColumn";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn
            // 
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_IRONPREPARED";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.HeaderText = "主原料装入时刻（铁水准备终）";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.Name = "aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMEBOFSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_BOFSTART";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.HeaderText = "吹炼始";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.Name = "aCTTIMEBOFSTARTDataGridViewTextBoxColumn";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn
            // 
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_BOFTAPPED";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.HeaderText = "出钢终";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.Name = "aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_TAPPEDSIDEEND";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.HeaderText = "炉后处理结束";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.Name = "aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMELFSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFSTART";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.HeaderText = "LF始";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.Name = "aCTTIMELFSTARTDataGridViewTextBoxColumn";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMELFENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFEND";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.HeaderText = "LF终";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.Name = "aCTTIMELFENDDataGridViewTextBoxColumn";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMERHSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHSTART";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.HeaderText = "RH始";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.Name = "aCTTIMERHSTARTDataGridViewTextBoxColumn";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMERHENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHEND";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.HeaderText = "RH终";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.Name = "aCTTIMERHENDDataGridViewTextBoxColumn";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMECASTERARRIVALDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTERARRIVAL";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.HeaderText = "铸机到达时刻";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.Name = "aCTTIMECASTERARRIVALDataGridViewTextBoxColumn";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMECASTINGSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTINGSTART";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.HeaderText = "注入始";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.Name = "aCTTIMECASTINGSTARTDataGridViewTextBoxColumn";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTTIMECASTINGENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTINGEND";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.HeaderText = "注入终";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.Name = "aCTTIMECASTINGENDDataGridViewTextBoxColumn";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.Visible = false;
            // 
            // lFTREATNODataGridViewTextBoxColumn
            // 
            this.lFTREATNODataGridViewTextBoxColumn.DataPropertyName = "LF_TREATNO";
            this.lFTREATNODataGridViewTextBoxColumn.HeaderText = "LF处理号";
            this.lFTREATNODataGridViewTextBoxColumn.Name = "lFTREATNODataGridViewTextBoxColumn";
            this.lFTREATNODataGridViewTextBoxColumn.Visible = false;
            // 
            // rHTREATNODataGridViewTextBoxColumn
            // 
            this.rHTREATNODataGridViewTextBoxColumn.DataPropertyName = "RH_TREATNO";
            this.rHTREATNODataGridViewTextBoxColumn.HeaderText = "RH处理号";
            this.rHTREATNODataGridViewTextBoxColumn.Name = "rHTREATNODataGridViewTextBoxColumn";
            this.rHTREATNODataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTERTREATNODataGridViewTextBoxColumn
            // 
            this.cASTERTREATNODataGridViewTextBoxColumn.DataPropertyName = "CASTER_TREATNO";
            this.cASTERTREATNODataGridViewTextBoxColumn.HeaderText = "铸机处理号";
            this.cASTERTREATNODataGridViewTextBoxColumn.Name = "cASTERTREATNODataGridViewTextBoxColumn";
            this.cASTERTREATNODataGridViewTextBoxColumn.Visible = false;
            // 
            // fIRHEATFLAGDataGridViewTextBoxColumn
            // 
            this.fIRHEATFLAGDataGridViewTextBoxColumn.DataPropertyName = "FIR_HEAT_FLAG";
            this.fIRHEATFLAGDataGridViewTextBoxColumn.HeaderText = "浇次第一炉标志";
            this.fIRHEATFLAGDataGridViewTextBoxColumn.Name = "fIRHEATFLAGDataGridViewTextBoxColumn";
            this.fIRHEATFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRHEATFLAGDataGridViewTextBoxColumn.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "　　　　　";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // tscmbCasterID
            // 
            this.tscmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbCasterID.Name = "tscmbCasterID";
            this.tscmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.tscmbCasterID.SelectedIndexChanged += new System.EventHandler(this.tscmbCasterID_SelectedIndexChanged);
            this.tscmbCasterID.DropDownClosed += new System.EventHandler(this.tscmbCasterID_DropDownClosed);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "铸机:";
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
            this.toolStripLabel3,
            this.toolStripLabel1,
            this.btnQuery,
            this.tscmbCasterID,
            this.toolStripLabel4,
            this.tstxtCasterID});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(953, 25);
            this.bdN1.TabIndex = 148;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // dsCasterID
            // 
            this.dsCasterID.AutoLoad = true;
            this.dsCasterID.AutoSubscribe = true;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' and code is not null";
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
            // cmdFirst
            // 
            this.cmdFirst.Adapter = this.Adapter;
            this.cmdFirst.MergeReturnTarget = false;
            this.cmdFirst.Method = "TappingPlanFirHeatDesign";
            this.cmdFirst.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdFirst.Parameters.Add(this.l3CommandParameter5);
            this.cmdFirst.ReturnTarget = null;
            this.cmdFirst.ReturnTargetProperty = null;
            this.cmdFirst.Trigger = null;
            this.cmdFirst.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter5.SourceObject = this.dsTapping;
            this.l3CommandParameter5.SourceProperty = "L3DataTable";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // cmdAddHeats
            // 
            this.cmdAddHeats.Adapter = this.Adapter;
            this.cmdAddHeats.MergeReturnTarget = false;
            this.cmdAddHeats.Method = "AddHeatsToCasting";
            this.cmdAddHeats.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdAddHeats.Parameters.Add(this.l3CommandParameter6);
            this.cmdAddHeats.ReturnTarget = null;
            this.cmdAddHeats.ReturnTargetProperty = null;
            this.cmdAddHeats.Trigger = null;
            this.cmdAddHeats.TriggerEvent = "Click";
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = "";
            this.l3CommandParameter6.SourceObject = this.tstxtCasterID;
            this.l3CommandParameter6.SourceProperty = "Text";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // cmdDestCfm
            // 
            this.cmdDestCfm.Adapter = this.Adapter;
            this.cmdDestCfm.MergeReturnTarget = false;
            this.cmdDestCfm.Method = "TappingPlanDestCfm";
            this.cmdDestCfm.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdDestCfm.Parameters.Add(this.l3CommandParameter10);
            this.cmdDestCfm.ReturnTarget = null;
            this.cmdDestCfm.ReturnTargetProperty = null;
            this.cmdDestCfm.Trigger = null;
            this.cmdDestCfm.TriggerEvent = "Click";
            // 
            // l3CommandParameter10
            // 
            this.l3CommandParameter10.AcceptAfterExecuted = false;
            this.l3CommandParameter10.ConstantValue = null;
            this.l3CommandParameter10.MergeTarget = false;
            this.l3CommandParameter10.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter10.SourceObject = this.dsTapping;
            this.l3CommandParameter10.SourceProperty = "L3DataTable";
            this.l3CommandParameter10.TargetObject = null;
            this.l3CommandParameter10.TargetProperty = null;
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter7.SourceObject = this.dsTapping;
            this.l3CommandParameter7.SourceProperty = "L3DataTable";
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // cmdChangeTime
            // 
            this.cmdChangeTime.Adapter = this.Adapter;
            this.cmdChangeTime.MergeReturnTarget = false;
            this.cmdChangeTime.Method = "TappingPlanChangeTimeTable";
            this.cmdChangeTime.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdChangeTime.Parameters.Add(this.l3CommandParameter8);
            this.cmdChangeTime.ReturnTarget = null;
            this.cmdChangeTime.ReturnTargetProperty = null;
            this.cmdChangeTime.Trigger = null;
            this.cmdChangeTime.TriggerEvent = "Click";
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter8.SourceObject = this.dsTapping;
            this.l3CommandParameter8.SourceProperty = "L3DataTable";
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // cmdFirstCancel
            // 
            this.cmdFirstCancel.Adapter = this.Adapter;
            this.cmdFirstCancel.MergeReturnTarget = false;
            this.cmdFirstCancel.Method = "TappingPlanFirHeatCancel";
            this.cmdFirstCancel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdFirstCancel.Parameters.Add(this.l3CommandParameter9);
            this.cmdFirstCancel.ReturnTarget = null;
            this.cmdFirstCancel.ReturnTargetProperty = null;
            this.cmdFirstCancel.Trigger = null;
            this.cmdFirstCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = null;
            this.l3CommandParameter9.SourceObject = this.tstxtCasterID;
            this.l3CommandParameter9.SourceProperty = "Text";
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // dsDES
            // 
            this.dsDES.AutoLoad = true;
            this.dsDES.AutoSubscribe = true;
            this.dsDES.DataSetName = "L3DataSet";
            this.dsDES.DeleteMethod = null;
            this.dsDES.InsertMethod = null;
            this.dsDES.L3DataAdapter = null;
            this.dsDES.LoadEvent = "Click";
            this.dsDES.LoadTrigger = null;
            this.dsDES.RefreshValve = 1000;
            this.dsDES.SourceCommand = null;
            this.dsDES.SourceCondition = null;
            this.dsDES.SourceMethod = null;
            this.dsDES.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDES.SourceURI = null;
            this.dsDES.SubscribeTarget = null;
            this.dsDES.UpdateEvent = "Click";
            this.dsDES.UpdateMethod = null;
            this.dsDES.UpdateTrigger = null;
            // 
            // cmdChangPlanTime
            // 
            this.cmdChangPlanTime.Adapter = this.Adapter;
            this.cmdChangPlanTime.MergeReturnTarget = false;
            this.cmdChangPlanTime.Method = null;
            this.cmdChangPlanTime.Object = null;
            this.cmdChangPlanTime.ReturnTarget = null;
            this.cmdChangPlanTime.ReturnTargetProperty = null;
            this.cmdChangPlanTime.Trigger = null;
            this.cmdChangPlanTime.TriggerEvent = "Click";
            // 
            // dsWriteTime
            // 
            this.dsWriteTime.AutoLoad = true;
            this.dsWriteTime.AutoSubscribe = true;
            this.dsWriteTime.DataSetName = "L3DataSet";
            this.dsWriteTime.DeleteMethod = null;
            this.dsWriteTime.InsertMethod = null;
            this.dsWriteTime.L3DataAdapter = null;
            this.dsWriteTime.LoadEvent = "Click";
            this.dsWriteTime.LoadTrigger = null;
            this.dsWriteTime.RefreshValve = 1000;
            this.dsWriteTime.SourceCommand = null;
            this.dsWriteTime.SourceCondition = "";
            this.dsWriteTime.SourceMethod = "";
            this.dsWriteTime.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsWriteTime.SourceURI = "";
            this.dsWriteTime.SubscribeTarget = "";
            this.dsWriteTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsWriteTime.UpdateEvent = "Click";
            this.dsWriteTime.UpdateMethod = null;
            this.dsWriteTime.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared,
            this.coll3DataSet1L3DataTableAim_Time_BlowN2,
            this.coll3DataSet1L3DataTableHeatID});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableAim_Time_BOFRepared
            // 
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared.Caption = "Aim_Time_BOFRepared";
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared.ColumnName = "Aim_Time_BOFRepared";
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared.DataType = typeof(double);
            this.coll3DataSet1L3DataTableAim_Time_BOFRepared.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_BlowN2
            // 
            this.coll3DataSet1L3DataTableAim_Time_BlowN2.Caption = "Aim_Time_BlowN2";
            this.coll3DataSet1L3DataTableAim_Time_BlowN2.ColumnName = "Aim_Time_BlowN2";
            this.coll3DataSet1L3DataTableAim_Time_BlowN2.DataType = typeof(double);
            this.coll3DataSet1L3DataTableAim_Time_BlowN2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // dsChangePlanTime
            // 
            this.dsChangePlanTime.AutoLoad = true;
            this.dsChangePlanTime.AutoSubscribe = true;
            this.dsChangePlanTime.DataSetName = "L3DataSet";
            this.dsChangePlanTime.DeleteMethod = null;
            this.dsChangePlanTime.InsertMethod = null;
            this.dsChangePlanTime.L3DataAdapter = null;
            this.dsChangePlanTime.LoadEvent = "Click";
            this.dsChangePlanTime.LoadTrigger = null;
            this.dsChangePlanTime.RefreshValve = 1000;
            this.dsChangePlanTime.SourceCommand = null;
            this.dsChangePlanTime.SourceCondition = null;
            this.dsChangePlanTime.SourceMethod = null;
            this.dsChangePlanTime.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsChangePlanTime.SourceURI = null;
            this.dsChangePlanTime.SubscribeTarget = null;
            this.dsChangePlanTime.UpdateEvent = "Click";
            this.dsChangePlanTime.UpdateMethod = null;
            this.dsChangePlanTime.UpdateTrigger = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'TappingPlanChangeTimeTable\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // TappingPlanModifyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 553);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TappingPlanModifyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出钢计划编制";
            this.Load += new System.EventHandler(this.TappingPlanModifyFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TappingPlanModifyFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWriteTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangePlanTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTapping;
        private AppSvrHMI.L3DataSet dsTapping;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnCastingFirHeat;
        private System.Windows.Forms.ToolStripButton btnAddNewHeatToCasting;
        private System.Windows.Forms.ToolStripButton btnDestination;
        private System.Windows.Forms.ToolStripButton btnChangeTimeTable;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripButton btnCancelCastinFirHeat;
        private System.Windows.Forms.DataGridView dvTapping;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox tscmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.BindingNavigator bdN1;
        private AppSvrHMI.L3Command cmdTapping;
        private System.Data.DataTable schemadsTapping;
        private System.Data.DataColumn coldsTappingL3DataTableGUID;
        private System.Data.DataColumn coldsTappingL3DataTableNAME;
        private System.Data.DataColumn coldsTappingL3DataTablePLANID;
        private System.Data.DataColumn coldsTappingL3DataTableCONTRACTID;
        private System.Data.DataColumn coldsTappingL3DataTableSTATUS;
        private System.Data.DataColumn coldsTappingL3DataTablePLANDEPT;
        private System.Data.DataColumn coldsTappingL3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coldsTappingL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsTappingL3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coldsTappingL3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coldsTappingL3DataTablePLANNER;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_LOTNO;
        private System.Data.DataColumn coldsTappingL3DataTablePREHEATID;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_STEELGRADE;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TAPPED_WEIGHT;
        private System.Data.DataColumn coldsTappingL3DataTableCASTERID;
        private System.Data.DataColumn coldsTappingL3DataTableBOFID;
        private System.Data.DataColumn coldsTappingL3DataTableLFID;
        private System.Data.DataColumn coldsTappingL3DataTableRHID;
        private System.Data.DataColumn coldsTappingL3DataTableBOF_STATUS;
        private System.Data.DataColumn coldsTappingL3DataTableLF_STATUS;
        private System.Data.DataColumn coldsTappingL3DataTableRH_STATUS;
        private System.Data.DataColumn coldsTappingL3DataTableCASTER_STATUS;
        private System.Data.DataColumn coldsTappingL3DataTableSIDE_STATUS;
        private System.Data.DataColumn coldsTappingL3DataTableHEATID;
        private System.Data.DataColumn coldsTappingL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsTappingL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_BOFSTART;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_LFARRIVAL;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_LFSTART;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_LFEND;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_LFLEAVE;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_RHARRIVAL;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_RHSTART;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_RHEND;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_RHLEAVE;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_CASTINGEND;
        private System.Data.DataColumn coldsTappingL3DataTableFIR_HEAT_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableDIV_HEATID;
        private System.Data.DataColumn coldsTappingL3DataTableTEAMID;
        private System.Data.DataColumn coldsTappingL3DataTableSHIFTID;
        private System.Data.DataColumn coldsTappingL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsTappingL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsTappingL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsTappingL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableSTEEL_RETURN_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableSTEEL_BACK_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableTREAT_SEQ;
        private System.Data.DataColumn coldsTappingL3DataTableDESTITATION;
        private System.Data.DataColumn coldsTappingL3DataTableNEW_BOF_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_BOFSTART;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_LFSTART;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_LFEND;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_RHSTART;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_RHEND;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsTappingL3DataTableACT_TIME_CASTINGEND;
        private System.Data.DataColumn coldsTappingL3DataTableLF_TREATNO;
        private System.Data.DataColumn coldsTappingL3DataTableRH_TREATNO;
        private System.Data.DataColumn coldsTappingL3DataTableCASTER_TREATNO;
        private System.Data.DataColumn coldsTappingL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox tstxtCasterID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3Command cmdFirst;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3Command cmdAddHeats;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3Command cmdDestCfm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3Command cmdChangeTime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3Command cmdFirstCancel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private AppSvrHMI.L3DataSet dsDES;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
        private System.Windows.Forms.ToolStripButton btnShowChangePlanTime;
        private System.Windows.Forms.ToolStripButton btnShowWriteInTime;
        private AppSvrHMI.L3Command cmdChangPlanTime;
        private AppSvrHMI.L3DataSet dsWriteTime;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_BOFRepared;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_BlowN2;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private AppSvrHMI.L3DataSet dsChangePlanTime;
        private AppSvrHMI.L3DataSet dsDest;
        private System.Data.DataTable schemadsDest;
        private System.Data.DataColumn coldsDestL3DataTableCode;
        private System.Data.DataColumn coldsDestL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dESTITATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXECUTEDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTUALEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRELOTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTAPPEDWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERSTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDESTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGHEATCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMEIRONPREPAREDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMEBOFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMEBOFTAPPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMETAPPEDSIDEENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMELFARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMELFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMELFENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMELFLEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMERHARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMERHSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMERHENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMERHLEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMECASTERARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMECASTINGSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMECASTINGENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIVHEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTSENDFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELRETURNFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELBACKFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tREATSEQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEWBOFFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEBOFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTERARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTINGSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTINGENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFTREATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHTREATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERTREATNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRHEATFLAGDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
    }
}