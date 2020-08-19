namespace PlanMag
{
    partial class TappingPlanMainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TappingPlanMainFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTappingPlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsTappingPlan = new AppSvrHMI.L3DataSet();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnCancelTappingPlan = new System.Windows.Forms.ToolStripButton();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.btnSendCancel = new System.Windows.Forms.ToolStripButton();
            this.btnHeatExchange = new System.Windows.Forms.ToolStripButton();
            this.btnOnSeqExchange = new System.Windows.Forms.ToolStripButton();
            this.btnTappingModify = new System.Windows.Forms.ToolStripButton();
            this.btnShowChangeRoute = new System.Windows.Forms.ToolStripButton();
            this.btnDispAccount = new System.Windows.Forms.ToolStripButton();
            this.btnData = new System.Windows.Forms.ToolStripButton();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.tstxtBOFID = new System.Windows.Forms.ToolStripTextBox();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tstxtCasterID = new System.Windows.Forms.ToolStripTextBox();
            this.schemadsTappingPlan = new System.Data.DataTable();
            this.coldsTappingPlanL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableNAME = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePLANNER = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePRE_LOTNO = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableLFID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableRHID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableBOF_STATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableLF_STATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableRH_STATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCASTER_STATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSIDE_STATUS = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableDIV_HEATID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableTREAT_SEQ = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableDESTITATION = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableLF_TREATNO = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableRH_TREATNO = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableCASTER_TREATNO = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableRefine_Type = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableLength = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableThickness = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableWidth = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAct_Time_LFArrival = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAct_Time_LFLeave = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAct_Time_RHArrival = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTableAct_Time_RHLeave = new System.Data.DataColumn();
            this.l3Command1 = new AppSvrHMI.L3Command(this.components);
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbxPlanCount4 = new AppSvrHMI.L3DataBox();
            this.dbxPlanCount3 = new AppSvrHMI.L3DataBox();
            this.dbxPlanCount2 = new AppSvrHMI.L3DataBox();
            this.dbxPlanCount1 = new AppSvrHMI.L3DataBox();
            this.myLine1 = new buttonHide.MyLine();
            this.l3txtCaster5 = new AppSvrHMI.L3DataBox();
            this.l3txtCaster4 = new AppSvrHMI.L3DataBox();
            this.l3txtCaster3 = new AppSvrHMI.L3DataBox();
            this.l3txtCaster2 = new AppSvrHMI.L3DataBox();
            this.l3txtCaster1 = new AppSvrHMI.L3DataBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l3DataBox4 = new AppSvrHMI.L3DataBox();
            this.l3txtRH1 = new AppSvrHMI.L3DataBox();
            this.l3DataBox3 = new AppSvrHMI.L3DataBox();
            this.l3txtLF3 = new AppSvrHMI.L3DataBox();
            this.l3DataBox2 = new AppSvrHMI.L3DataBox();
            this.l3txtLF2 = new AppSvrHMI.L3DataBox();
            this.l3DataBox1 = new AppSvrHMI.L3DataBox();
            this.l3txtLF1 = new AppSvrHMI.L3DataBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l3txtBOF4 = new AppSvrHMI.L3DataBox();
            this.l3txtBOF3 = new AppSvrHMI.L3DataBox();
            this.l3txtBOF2 = new AppSvrHMI.L3DataBox();
            this.l3txtBOF1 = new AppSvrHMI.L3DataBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbxSteelExchangeAppEvent = new AppSvrHMI.L3DataBox();
            this.dbxSteelDivAppEvent = new AppSvrHMI.L3DataBox();
            this.dbxSteelReturnAppEvent = new AppSvrHMI.L3DataBox();
            this.dbxSteelBackAppEvent = new AppSvrHMI.L3DataBox();
            this.l3DataBoxTapEvent = new AppSvrHMI.L3DataBox();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTapPlan = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreSteelGradeIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActSteelGradeIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IronTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlowBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TappedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LFArrivle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LFStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LFLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RHArrivle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RHStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RHLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LadleArrilTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasterStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasterEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.tscmbBOFID = new System.Windows.Forms.ToolStripComboBox();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.tscmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.cmdTappingCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.cmdTappingSend = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter12 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.cmdTappingSendCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter11 = new AppSvrHMI.L3CommandParameter();
            this.cmdExchange = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter13 = new AppSvrHMI.L3CommandParameter();
            this.cmdExchangeTreatSeq = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter14 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeRoute = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter15 = new AppSvrHMI.L3CommandParameter();
            this.dsChangeRoute = new AppSvrHMI.L3DataSet();
            this.schemadsChangeRoute = new System.Data.DataTable();
            this.coldsChangeRouteL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableLFID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableRHID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsChangeRouteL3DataTableSteelGrade = new System.Data.DataColumn();
            this.dsCmd = new AppSvrHMI.L3DataSet();
            this.schemadsCmd = new System.Data.DataTable();
            this.coldsCmdL3DataTablePlanID = new System.Data.DataColumn();
            this.cmdStopPlan = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter16 = new AppSvrHMI.L3CommandParameter();
            this.dsCmdd = new AppSvrHMI.L3DataSet();
            this.schemadsCmdd = new System.Data.DataTable();
            this.coldsCmddL3DataTablePlanID = new System.Data.DataColumn();
            this.dsErrorHeatExchange = new AppSvrHMI.L3DataSet();
            this.dsErrorExchange = new AppSvrHMI.L3DataSet();
            this.schemadsErrorExchange = new System.Data.DataTable();
            this.coldsErrorExchangeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorExchangeL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTappingPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTappingPlan)).BeginInit();
            this.tSp1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTapPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCmd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCmdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCmdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsErrorHeatExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsErrorExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsErrorExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsTappingPlan
            // 
            this.bsTappingPlan.DataMember = "L3DataTable";
            this.bsTappingPlan.DataSource = this.dsTappingPlan;
            // 
            // dsTappingPlan
            // 
            this.dsTappingPlan.AutoLoad = true;
            this.dsTappingPlan.AutoSubscribe = true;
            this.dsTappingPlan.DataSetName = "L3DataSet";
            this.dsTappingPlan.DeleteMethod = "";
            this.dsTappingPlan.InsertMethod = "";
            this.dsTappingPlan.L3DataAdapter = null;
            this.dsTappingPlan.LoadEvent = "Click";
            this.dsTappingPlan.LoadTrigger = null;
            this.dsTappingPlan.RefreshValve = 1000;
            this.dsTappingPlan.SourceCommand = this.cmdQuery;
            this.dsTappingPlan.SourceCondition = "";
            this.dsTappingPlan.SourceMethod = "";
            this.dsTappingPlan.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTappingPlan.SourceURI = "";
            this.dsTappingPlan.SubscribeTarget = null;
            this.dsTappingPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTappingPlan});
            this.dsTappingPlan.UpdateEvent = "Click";
            this.dsTappingPlan.UpdateMethod = "";
            this.dsTappingPlan.UpdateTrigger = null;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = this.Adapter;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "GetCurDayTappingPlan";
            this.cmdQuery.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdQuery.Parameters.Add(this.l3CommandParameter3);
            this.cmdQuery.Parameters.Add(this.l3CommandParameter4);
            this.cmdQuery.ReturnTarget = this.dsTappingPlan;
            this.cmdQuery.ReturnTargetProperty = null;
            this.cmdQuery.Trigger = null;
            this.cmdQuery.TriggerEvent = "Click";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnCancelTappingPlan
            // 
            this.Adapter.SetAccessRight(this.btnCancelTappingPlan, "BtnCancelTappingPlan");
            this.btnCancelTappingPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelTappingPlan.Image")));
            this.btnCancelTappingPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelTappingPlan.Name = "btnCancelTappingPlan";
            this.btnCancelTappingPlan.Size = new System.Drawing.Size(116, 40);
            this.btnCancelTappingPlan.Text = "取消出钢计划";
            this.btnCancelTappingPlan.Click += new System.EventHandler(this.btnCancelTappingPlan_Click);
            // 
            // btnSend
            // 
            this.Adapter.SetAccessRight(this.btnSend, "BtnTappingPlanSend");
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 40);
            this.btnSend.Text = "计划下达";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSendCancel
            // 
            this.Adapter.SetAccessRight(this.btnSendCancel, "BtnTappingPlanSendCancel");
            this.btnSendCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnSendCancel.Image")));
            this.btnSendCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendCancel.Name = "btnSendCancel";
            this.btnSendCancel.Size = new System.Drawing.Size(116, 40);
            this.btnSendCancel.Text = "计划下达取消";
            this.btnSendCancel.Click += new System.EventHandler(this.btnSendCancel_Click);
            // 
            // btnHeatExchange
            // 
            this.Adapter.SetAccessRight(this.btnHeatExchange, "BtnTappingPlanExchange");
            this.btnHeatExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnHeatExchange.Image")));
            this.btnHeatExchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHeatExchange.Name = "btnHeatExchange";
            this.btnHeatExchange.Size = new System.Drawing.Size(92, 40);
            this.btnHeatExchange.Text = "炉座交换";
            this.btnHeatExchange.Click += new System.EventHandler(this.btnHeatExchange_Click);
            // 
            // btnOnSeqExchange
            // 
            this.Adapter.SetAccessRight(this.btnOnSeqExchange, "BtnExchangeProcessSeq");
            this.btnOnSeqExchange.Image = ((System.Drawing.Image)(resources.GetObject("btnOnSeqExchange.Image")));
            this.btnOnSeqExchange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnSeqExchange.Name = "btnOnSeqExchange";
            this.btnOnSeqExchange.Size = new System.Drawing.Size(140, 40);
            this.btnOnSeqExchange.Text = "调整铸机处理顺序";
            this.btnOnSeqExchange.Click += new System.EventHandler(this.btnOnSeqExchange_Click);
            // 
            // btnTappingModify
            // 
            this.Adapter.SetAccessRight(this.btnTappingModify, "BtnModTappingPlan");
            this.btnTappingModify.Image = ((System.Drawing.Image)(resources.GetObject("btnTappingModify.Image")));
            this.btnTappingModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTappingModify.Name = "btnTappingModify";
            this.btnTappingModify.Size = new System.Drawing.Size(116, 40);
            this.btnTappingModify.Text = "出钢计划修改";
            this.btnTappingModify.Click += new System.EventHandler(this.btnTappingModify_Click);
            // 
            // btnShowChangeRoute
            // 
            this.Adapter.SetAccessRight(this.btnShowChangeRoute, "BtnChengeRoute");
            this.btnShowChangeRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnShowChangeRoute.Image")));
            this.btnShowChangeRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowChangeRoute.Name = "btnShowChangeRoute";
            this.btnShowChangeRoute.Size = new System.Drawing.Size(116, 40);
            this.btnShowChangeRoute.Text = "更改工艺路径";
            this.btnShowChangeRoute.Click += new System.EventHandler(this.btnShowChangeRoute_Click);
            // 
            // btnDispAccount
            // 
            this.Adapter.SetAccessRight(this.btnDispAccount, "BtnChengeRoute");
            this.btnDispAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnDispAccount.Image")));
            this.btnDispAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDispAccount.Name = "btnDispAccount";
            this.btnDispAccount.Size = new System.Drawing.Size(116, 40);
            this.btnDispAccount.Text = "异常数据修改";
            this.btnDispAccount.Click += new System.EventHandler(this.btnDispAccount_Click_1);
            // 
            // btnData
            // 
            this.Adapter.SetAccessRight(this.btnData, "BtnTappingPlanSend");
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(92, 40);
            this.btnData.Text = "数据维护";
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.tstxtBOFID;
            this.l3CommandParameter3.SourceProperty = "Text";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // tstxtBOFID
            // 
            this.tstxtBOFID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtBOFID.Name = "tstxtBOFID";
            this.tstxtBOFID.Size = new System.Drawing.Size(100, 25);
            this.tstxtBOFID.Visible = false;
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
            this.tstxtCasterID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tstxtCasterID.Name = "tstxtCasterID";
            this.tstxtCasterID.Size = new System.Drawing.Size(100, 25);
            this.tstxtCasterID.Visible = false;
            // 
            // schemadsTappingPlan
            // 
            this.schemadsTappingPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTappingPlanL3DataTableGUID,
            this.coldsTappingPlanL3DataTableNAME,
            this.coldsTappingPlanL3DataTablePLANID,
            this.coldsTappingPlanL3DataTableCONTRACTID,
            this.coldsTappingPlanL3DataTableSTATUS,
            this.coldsTappingPlanL3DataTablePLANDEPT,
            this.coldsTappingPlanL3DataTableEXECUTEDEPT,
            this.coldsTappingPlanL3DataTableCREATEDATE,
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE,
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE,
            this.coldsTappingPlanL3DataTablePLANNER,
            this.coldsTappingPlanL3DataTablePRE_LOTNO,
            this.coldsTappingPlanL3DataTablePREHEATID,
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX,
            this.coldsTappingPlanL3DataTableSTEELGRADE,
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT,
            this.coldsTappingPlanL3DataTableCASTERID,
            this.coldsTappingPlanL3DataTableBOFID,
            this.coldsTappingPlanL3DataTableLFID,
            this.coldsTappingPlanL3DataTableRHID,
            this.coldsTappingPlanL3DataTableBOF_STATUS,
            this.coldsTappingPlanL3DataTableLF_STATUS,
            this.coldsTappingPlanL3DataTableRH_STATUS,
            this.coldsTappingPlanL3DataTableCASTER_STATUS,
            this.coldsTappingPlanL3DataTableSIDE_STATUS,
            this.coldsTappingPlanL3DataTableHEATID,
            this.coldsTappingPlanL3DataTableCASTING_NO,
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT,
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED,
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART,
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED,
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND,
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL,
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART,
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND,
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE,
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL,
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART,
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND,
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE,
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL,
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART,
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND,
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG,
            this.coldsTappingPlanL3DataTableDIV_HEATID,
            this.coldsTappingPlanL3DataTableTEAMID,
            this.coldsTappingPlanL3DataTableSHIFTID,
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID,
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG,
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG,
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG,
            this.coldsTappingPlanL3DataTableTREAT_SEQ,
            this.coldsTappingPlanL3DataTableDESTITATION,
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG,
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED,
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART,
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED,
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND,
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART,
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND,
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART,
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND,
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL,
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART,
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND,
            this.coldsTappingPlanL3DataTableLF_TREATNO,
            this.coldsTappingPlanL3DataTableRH_TREATNO,
            this.coldsTappingPlanL3DataTableCASTER_TREATNO,
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX,
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE,
            this.coldsTappingPlanL3DataTableRefine_Type,
            this.coldsTappingPlanL3DataTableLength,
            this.coldsTappingPlanL3DataTableThickness,
            this.coldsTappingPlanL3DataTableWidth,
            this.coldsTappingPlanL3DataTableAct_Time_LFArrival,
            this.coldsTappingPlanL3DataTableAct_Time_LFLeave,
            this.coldsTappingPlanL3DataTableAct_Time_RHArrival,
            this.coldsTappingPlanL3DataTableAct_Time_RHLeave});
            this.schemadsTappingPlan.TableName = "L3DataTable";
            // 
            // coldsTappingPlanL3DataTableGUID
            // 
            this.coldsTappingPlanL3DataTableGUID.Caption = "GUID";
            this.coldsTappingPlanL3DataTableGUID.ColumnName = "GUID";
            this.coldsTappingPlanL3DataTableGUID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableGUID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableNAME
            // 
            this.coldsTappingPlanL3DataTableNAME.Caption = "NAME";
            this.coldsTappingPlanL3DataTableNAME.ColumnName = "NAME";
            this.coldsTappingPlanL3DataTableNAME.DefaultValue = "";
            this.coldsTappingPlanL3DataTableNAME.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePLANID
            // 
            this.coldsTappingPlanL3DataTablePLANID.Caption = "PLANID";
            this.coldsTappingPlanL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsTappingPlanL3DataTablePLANID.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePLANID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCONTRACTID
            // 
            this.coldsTappingPlanL3DataTableCONTRACTID.Caption = "CONTRACTID";
            this.coldsTappingPlanL3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coldsTappingPlanL3DataTableCONTRACTID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableCONTRACTID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSTATUS
            // 
            this.coldsTappingPlanL3DataTableSTATUS.Caption = "STATUS";
            this.coldsTappingPlanL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsTappingPlanL3DataTableSTATUS.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableSTATUS.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableSTATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePLANDEPT
            // 
            this.coldsTappingPlanL3DataTablePLANDEPT.Caption = "PLANDEPT";
            this.coldsTappingPlanL3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coldsTappingPlanL3DataTablePLANDEPT.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePLANDEPT.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableEXECUTEDEPT
            // 
            this.coldsTappingPlanL3DataTableEXECUTEDEPT.Caption = "EXECUTEDEPT";
            this.coldsTappingPlanL3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coldsTappingPlanL3DataTableEXECUTEDEPT.DefaultValue = "";
            this.coldsTappingPlanL3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCREATEDATE
            // 
            this.coldsTappingPlanL3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coldsTappingPlanL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsTappingPlanL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePLANEXECUTEDATE
            // 
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE.Caption = "PLANEXECUTEDATE";
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACTUALEXECUTEDATE
            // 
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE.Caption = "ACTUALEXECUTEDATE";
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePLANNER
            // 
            this.coldsTappingPlanL3DataTablePLANNER.Caption = "PLANNER";
            this.coldsTappingPlanL3DataTablePLANNER.ColumnName = "PLANNER";
            this.coldsTappingPlanL3DataTablePLANNER.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePLANNER.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePRE_LOTNO
            // 
            this.coldsTappingPlanL3DataTablePRE_LOTNO.Caption = "PRE_LOTNO";
            this.coldsTappingPlanL3DataTablePRE_LOTNO.ColumnName = "PRE_LOTNO";
            this.coldsTappingPlanL3DataTablePRE_LOTNO.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePRE_LOTNO.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePREHEATID
            // 
            this.coldsTappingPlanL3DataTablePREHEATID.Caption = "PREHEATID";
            this.coldsTappingPlanL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsTappingPlanL3DataTablePREHEATID.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSTEELGRADEINDEX
            // 
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsTappingPlanL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSTEELGRADE
            // 
            this.coldsTappingPlanL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsTappingPlanL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsTappingPlanL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsTappingPlanL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT
            // 
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT.Caption = "AIM_TAPPED_WEIGHT";
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT.ColumnName = "AIM_TAPPED_WEIGHT";
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT.DataType = typeof(double);
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT.DefaultValue = 0D;
            this.coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCASTERID
            // 
            this.coldsTappingPlanL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsTappingPlanL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsTappingPlanL3DataTableCASTERID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableCASTERID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableBOFID
            // 
            this.coldsTappingPlanL3DataTableBOFID.Caption = "BOFID";
            this.coldsTappingPlanL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsTappingPlanL3DataTableBOFID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableBOFID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableLFID
            // 
            this.coldsTappingPlanL3DataTableLFID.Caption = "LFID";
            this.coldsTappingPlanL3DataTableLFID.ColumnName = "LFID";
            this.coldsTappingPlanL3DataTableLFID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableLFID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableRHID
            // 
            this.coldsTappingPlanL3DataTableRHID.Caption = "RHID";
            this.coldsTappingPlanL3DataTableRHID.ColumnName = "RHID";
            this.coldsTappingPlanL3DataTableRHID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableRHID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableBOF_STATUS
            // 
            this.coldsTappingPlanL3DataTableBOF_STATUS.Caption = "BOF_STATUS";
            this.coldsTappingPlanL3DataTableBOF_STATUS.ColumnName = "BOF_STATUS";
            this.coldsTappingPlanL3DataTableBOF_STATUS.DefaultValue = "";
            this.coldsTappingPlanL3DataTableBOF_STATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableLF_STATUS
            // 
            this.coldsTappingPlanL3DataTableLF_STATUS.Caption = "LF_STATUS";
            this.coldsTappingPlanL3DataTableLF_STATUS.ColumnName = "LF_STATUS";
            this.coldsTappingPlanL3DataTableLF_STATUS.DefaultValue = "";
            this.coldsTappingPlanL3DataTableLF_STATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableRH_STATUS
            // 
            this.coldsTappingPlanL3DataTableRH_STATUS.Caption = "RH_STATUS";
            this.coldsTappingPlanL3DataTableRH_STATUS.ColumnName = "RH_STATUS";
            this.coldsTappingPlanL3DataTableRH_STATUS.DefaultValue = "";
            this.coldsTappingPlanL3DataTableRH_STATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCASTER_STATUS
            // 
            this.coldsTappingPlanL3DataTableCASTER_STATUS.Caption = "CASTER_STATUS";
            this.coldsTappingPlanL3DataTableCASTER_STATUS.ColumnName = "CASTER_STATUS";
            this.coldsTappingPlanL3DataTableCASTER_STATUS.DefaultValue = "";
            this.coldsTappingPlanL3DataTableCASTER_STATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSIDE_STATUS
            // 
            this.coldsTappingPlanL3DataTableSIDE_STATUS.Caption = "SIDE_STATUS";
            this.coldsTappingPlanL3DataTableSIDE_STATUS.ColumnName = "SIDE_STATUS";
            this.coldsTappingPlanL3DataTableSIDE_STATUS.DefaultValue = "";
            this.coldsTappingPlanL3DataTableSIDE_STATUS.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableHEATID
            // 
            this.coldsTappingPlanL3DataTableHEATID.Caption = "HEATID";
            this.coldsTappingPlanL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsTappingPlanL3DataTableHEATID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableHEATID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCASTING_NO
            // 
            this.coldsTappingPlanL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsTappingPlanL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsTappingPlanL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsTappingPlanL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED.Caption = "AIM_TIME_IRONPREPARED";
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED.ColumnName = "AIM_TIME_IRONPREPARED";
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_BOFSTART
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART.Caption = "AIM_TIME_BOFSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART.ColumnName = "AIM_TIME_BOFSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED.Caption = "AIM_TIME_BOFTAPPED";
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED.ColumnName = "AIM_TIME_BOFTAPPED";
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.Caption = "AIM_TIME_TAPPEDSIDEEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.ColumnName = "AIM_TIME_TAPPEDSIDEEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL.Caption = "AIM_TIME_LFARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL.ColumnName = "AIM_TIME_LFARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_LFSTART
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART.Caption = "AIM_TIME_LFSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART.ColumnName = "AIM_TIME_LFSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_LFSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_LFEND
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND.Caption = "AIM_TIME_LFEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND.ColumnName = "AIM_TIME_LFEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_LFEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE.Caption = "AIM_TIME_LFLEAVE";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE.ColumnName = "AIM_TIME_LFLEAVE";
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL.Caption = "AIM_TIME_RHARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL.ColumnName = "AIM_TIME_RHARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_RHSTART
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART.Caption = "AIM_TIME_RHSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART.ColumnName = "AIM_TIME_RHSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_RHSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_RHEND
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND.Caption = "AIM_TIME_RHEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND.ColumnName = "AIM_TIME_RHEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_RHEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE.Caption = "AIM_TIME_RHLEAVE";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE.ColumnName = "AIM_TIME_RHLEAVE";
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL.Caption = "AIM_TIME_CASTERARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL.ColumnName = "AIM_TIME_CASTERARRIVAL";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART.Caption = "AIM_TIME_CASTINGSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART.ColumnName = "AIM_TIME_CASTINGSTART";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND
            // 
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND.Caption = "AIM_TIME_CASTINGEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND.ColumnName = "AIM_TIME_CASTINGEND";
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableFIR_HEAT_FLAG
            // 
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG.Caption = "FIR_HEAT_FLAG";
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG.ColumnName = "FIR_HEAT_FLAG";
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableFIR_HEAT_FLAG.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableDIV_HEATID
            // 
            this.coldsTappingPlanL3DataTableDIV_HEATID.Caption = "DIV_HEATID";
            this.coldsTappingPlanL3DataTableDIV_HEATID.ColumnName = "DIV_HEATID";
            this.coldsTappingPlanL3DataTableDIV_HEATID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableDIV_HEATID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableTEAMID
            // 
            this.coldsTappingPlanL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsTappingPlanL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsTappingPlanL3DataTableTEAMID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableTEAMID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSHIFTID
            // 
            this.coldsTappingPlanL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsTappingPlanL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsTappingPlanL3DataTableSHIFTID.DefaultValue = "";
            this.coldsTappingPlanL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePLAN_ORD_ID
            // 
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableHOT_SEND_FLAG
            // 
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG
            // 
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG.Caption = "STEEL_RETURN_FLAG";
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG.ColumnName = "STEEL_RETURN_FLAG";
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableSTEEL_BACK_FLAG
            // 
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG.Caption = "STEEL_BACK_FLAG";
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG.ColumnName = "STEEL_BACK_FLAG";
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableSTEEL_BACK_FLAG.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableTREAT_SEQ
            // 
            this.coldsTappingPlanL3DataTableTREAT_SEQ.Caption = "TREAT_SEQ";
            this.coldsTappingPlanL3DataTableTREAT_SEQ.ColumnName = "TREAT_SEQ";
            this.coldsTappingPlanL3DataTableTREAT_SEQ.DefaultValue = "";
            this.coldsTappingPlanL3DataTableTREAT_SEQ.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableDESTITATION
            // 
            this.coldsTappingPlanL3DataTableDESTITATION.Caption = "DESTITATION";
            this.coldsTappingPlanL3DataTableDESTITATION.ColumnName = "DESTITATION";
            this.coldsTappingPlanL3DataTableDESTITATION.DefaultValue = "";
            this.coldsTappingPlanL3DataTableDESTITATION.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableNEW_BOF_FLAG
            // 
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsTappingPlanL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED.Caption = "ACT_TIME_IRONPREPARED";
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED.ColumnName = "ACT_TIME_IRONPREPARED";
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_BOFSTART
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART.Caption = "ACT_TIME_BOFSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART.ColumnName = "ACT_TIME_BOFSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_BOFSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED.Caption = "ACT_TIME_BOFTAPPED";
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED.ColumnName = "ACT_TIME_BOFTAPPED";
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND.Caption = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND.ColumnName = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_LFSTART
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART.Caption = "ACT_TIME_LFSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART.ColumnName = "ACT_TIME_LFSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_LFSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_LFEND
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND.Caption = "ACT_TIME_LFEND";
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND.ColumnName = "ACT_TIME_LFEND";
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_LFEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_RHSTART
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART.Caption = "ACT_TIME_RHSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART.ColumnName = "ACT_TIME_RHSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_RHSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_RHEND
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND.Caption = "ACT_TIME_RHEND";
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND.ColumnName = "ACT_TIME_RHEND";
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_RHEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL.Caption = "ACT_TIME_CASTERARRIVAL";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL.ColumnName = "ACT_TIME_CASTERARRIVAL";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART.Caption = "ACT_TIME_CASTINGSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART.ColumnName = "ACT_TIME_CASTINGSTART";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableACT_TIME_CASTINGEND
            // 
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND.Caption = "ACT_TIME_CASTINGEND";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND.ColumnName = "ACT_TIME_CASTINGEND";
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTableACT_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableLF_TREATNO
            // 
            this.coldsTappingPlanL3DataTableLF_TREATNO.Caption = "LF_TREATNO";
            this.coldsTappingPlanL3DataTableLF_TREATNO.ColumnName = "LF_TREATNO";
            this.coldsTappingPlanL3DataTableLF_TREATNO.DefaultValue = "";
            this.coldsTappingPlanL3DataTableLF_TREATNO.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableRH_TREATNO
            // 
            this.coldsTappingPlanL3DataTableRH_TREATNO.Caption = "RH_TREATNO";
            this.coldsTappingPlanL3DataTableRH_TREATNO.ColumnName = "RH_TREATNO";
            this.coldsTappingPlanL3DataTableRH_TREATNO.DefaultValue = "";
            this.coldsTappingPlanL3DataTableRH_TREATNO.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableCASTER_TREATNO
            // 
            this.coldsTappingPlanL3DataTableCASTER_TREATNO.Caption = "CASTER_TREATNO";
            this.coldsTappingPlanL3DataTableCASTER_TREATNO.ColumnName = "CASTER_TREATNO";
            this.coldsTappingPlanL3DataTableCASTER_TREATNO.DefaultValue = "";
            this.coldsTappingPlanL3DataTableCASTER_TREATNO.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablePRE_STEELGRADE
            // 
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE.Caption = "PRE_STEELGRADE";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE.ColumnName = "PRE_STEELGRADE";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE.DefaultValue = "";
            this.coldsTappingPlanL3DataTablePRE_STEELGRADE.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableRefine_Type
            // 
            this.coldsTappingPlanL3DataTableRefine_Type.Caption = "Refine_Type";
            this.coldsTappingPlanL3DataTableRefine_Type.ColumnName = "Refine_Type";
            this.coldsTappingPlanL3DataTableRefine_Type.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableLength
            // 
            this.coldsTappingPlanL3DataTableLength.Caption = "Length";
            this.coldsTappingPlanL3DataTableLength.ColumnName = "Length";
            this.coldsTappingPlanL3DataTableLength.DataType = typeof(short);
            this.coldsTappingPlanL3DataTableLength.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableThickness
            // 
            this.coldsTappingPlanL3DataTableThickness.Caption = "Thickness";
            this.coldsTappingPlanL3DataTableThickness.ColumnName = "Thickness";
            this.coldsTappingPlanL3DataTableThickness.DataType = typeof(short);
            this.coldsTappingPlanL3DataTableThickness.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableWidth
            // 
            this.coldsTappingPlanL3DataTableWidth.Caption = "Width";
            this.coldsTappingPlanL3DataTableWidth.ColumnName = "Width";
            this.coldsTappingPlanL3DataTableWidth.DataType = typeof(short);
            this.coldsTappingPlanL3DataTableWidth.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAct_Time_LFArrival
            // 
            this.coldsTappingPlanL3DataTableAct_Time_LFArrival.Caption = "Act_Time_LFArrival";
            this.coldsTappingPlanL3DataTableAct_Time_LFArrival.ColumnName = "Act_Time_LFArrival";
            this.coldsTappingPlanL3DataTableAct_Time_LFArrival.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAct_Time_LFLeave
            // 
            this.coldsTappingPlanL3DataTableAct_Time_LFLeave.Caption = "Act_Time_LFLeave";
            this.coldsTappingPlanL3DataTableAct_Time_LFLeave.ColumnName = "Act_Time_LFLeave";
            this.coldsTappingPlanL3DataTableAct_Time_LFLeave.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAct_Time_RHArrival
            // 
            this.coldsTappingPlanL3DataTableAct_Time_RHArrival.Caption = "Act_Time_RHArrival";
            this.coldsTappingPlanL3DataTableAct_Time_RHArrival.ColumnName = "Act_Time_RHArrival";
            this.coldsTappingPlanL3DataTableAct_Time_RHArrival.Namespace = "";
            // 
            // coldsTappingPlanL3DataTableAct_Time_RHLeave
            // 
            this.coldsTappingPlanL3DataTableAct_Time_RHLeave.Caption = "Act_Time_RHLeave";
            this.coldsTappingPlanL3DataTableAct_Time_RHLeave.ColumnName = "Act_Time_RHLeave";
            this.coldsTappingPlanL3DataTableAct_Time_RHLeave.Namespace = "";
            // 
            // l3Command1
            // 
            this.l3Command1.Adapter = null;
            this.l3Command1.MergeReturnTarget = false;
            this.l3Command1.Method = null;
            this.l3Command1.Object = null;
            this.l3Command1.ReturnTarget = null;
            this.l3Command1.ReturnTargetProperty = null;
            this.l3Command1.Trigger = null;
            this.l3Command1.TriggerEvent = "Click";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelTappingPlan,
            this.btnSend,
            this.btnSendCancel,
            this.btnHeatExchange,
            this.btnOnSeqExchange,
            this.btnTappingModify,
            this.btnShowChangeRoute,
            this.btnDispAccount,
            this.btnData});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1050, 43);
            this.tSp1.TabIndex = 27;
            this.tSp1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbxPlanCount4);
            this.groupBox1.Controls.Add(this.dbxPlanCount3);
            this.groupBox1.Controls.Add(this.dbxPlanCount2);
            this.groupBox1.Controls.Add(this.dbxPlanCount1);
            this.groupBox1.Controls.Add(this.myLine1);
            this.groupBox1.Controls.Add(this.l3txtCaster5);
            this.groupBox1.Controls.Add(this.l3txtCaster4);
            this.groupBox1.Controls.Add(this.l3txtCaster3);
            this.groupBox1.Controls.Add(this.l3txtCaster2);
            this.groupBox1.Controls.Add(this.l3txtCaster1);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.l3DataBox4);
            this.groupBox1.Controls.Add(this.l3txtRH1);
            this.groupBox1.Controls.Add(this.l3DataBox3);
            this.groupBox1.Controls.Add(this.l3txtLF3);
            this.groupBox1.Controls.Add(this.l3DataBox2);
            this.groupBox1.Controls.Add(this.l3txtLF2);
            this.groupBox1.Controls.Add(this.l3DataBox1);
            this.groupBox1.Controls.Add(this.l3txtLF1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.l3txtBOF4);
            this.groupBox1.Controls.Add(this.l3txtBOF3);
            this.groupBox1.Controls.Add(this.l3txtBOF2);
            this.groupBox1.Controls.Add(this.l3txtBOF1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dbxSteelExchangeAppEvent);
            this.groupBox1.Controls.Add(this.dbxSteelDivAppEvent);
            this.groupBox1.Controls.Add(this.dbxSteelReturnAppEvent);
            this.groupBox1.Controls.Add(this.dbxSteelBackAppEvent);
            this.groupBox1.Controls.Add(this.l3DataBoxTapEvent);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 102);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实绩";
            // 
            // dbxPlanCount4
            // 
            this.dbxPlanCount4.DataFormat = null;
            this.dbxPlanCount4.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S24";
            this.dbxPlanCount4.DataProperty = "Plan_Count";
            this.dbxPlanCount4.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxPlanCount4.L3DataAdapter = this.Adapter;
            this.dbxPlanCount4.Location = new System.Drawing.Point(943, 75);
            this.dbxPlanCount4.Name = "dbxPlanCount4";
            this.dbxPlanCount4.Size = new System.Drawing.Size(10, 21);
            this.dbxPlanCount4.TabIndex = 40;
            this.dbxPlanCount4.Value = null;
            this.dbxPlanCount4.Visible = false;
            this.dbxPlanCount4.TextChanged += new System.EventHandler(this.dbxPlanCount4_TextChanged);
            // 
            // dbxPlanCount3
            // 
            this.dbxPlanCount3.DataFormat = null;
            this.dbxPlanCount3.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S23";
            this.dbxPlanCount3.DataProperty = "Plan_Count";
            this.dbxPlanCount3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxPlanCount3.L3DataAdapter = this.Adapter;
            this.dbxPlanCount3.Location = new System.Drawing.Point(927, 75);
            this.dbxPlanCount3.Name = "dbxPlanCount3";
            this.dbxPlanCount3.Size = new System.Drawing.Size(10, 21);
            this.dbxPlanCount3.TabIndex = 40;
            this.dbxPlanCount3.Value = null;
            this.dbxPlanCount3.Visible = false;
            this.dbxPlanCount3.TextChanged += new System.EventHandler(this.dbxPlanCount3_TextChanged);
            // 
            // dbxPlanCount2
            // 
            this.dbxPlanCount2.DataFormat = null;
            this.dbxPlanCount2.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S22";
            this.dbxPlanCount2.DataProperty = "Plan_Count";
            this.dbxPlanCount2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxPlanCount2.L3DataAdapter = this.Adapter;
            this.dbxPlanCount2.Location = new System.Drawing.Point(911, 75);
            this.dbxPlanCount2.Name = "dbxPlanCount2";
            this.dbxPlanCount2.Size = new System.Drawing.Size(10, 21);
            this.dbxPlanCount2.TabIndex = 40;
            this.dbxPlanCount2.Value = null;
            this.dbxPlanCount2.Visible = false;
            this.dbxPlanCount2.TextChanged += new System.EventHandler(this.dbxPlanCount2_TextChanged);
            // 
            // dbxPlanCount1
            // 
            this.dbxPlanCount1.DataFormat = null;
            this.dbxPlanCount1.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S21";
            this.dbxPlanCount1.DataProperty = "Plan_Count";
            this.dbxPlanCount1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxPlanCount1.L3DataAdapter = this.Adapter;
            this.dbxPlanCount1.Location = new System.Drawing.Point(895, 75);
            this.dbxPlanCount1.Name = "dbxPlanCount1";
            this.dbxPlanCount1.Size = new System.Drawing.Size(10, 21);
            this.dbxPlanCount1.TabIndex = 40;
            this.dbxPlanCount1.Value = null;
            this.dbxPlanCount1.Visible = false;
            this.dbxPlanCount1.TextChanged += new System.EventHandler(this.dbxPlanCount1_TextChanged);
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.myLine1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.myLine1.Location = new System.Drawing.Point(6, 69);
            this.myLine1.Margin = new System.Windows.Forms.Padding(0);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(979, 3);
            this.myLine1.TabIndex = 39;
            // 
            // l3txtCaster5
            // 
            this.l3txtCaster5.DataFormat = null;
            this.l3txtCaster5.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S65";
            this.l3txtCaster5.DataProperty = "HeatID";
            this.l3txtCaster5.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster5.L3DataAdapter = this.Adapter;
            this.l3txtCaster5.Location = new System.Drawing.Point(719, 75);
            this.l3txtCaster5.Name = "l3txtCaster5";
            this.l3txtCaster5.ReadOnly = true;
            this.l3txtCaster5.Size = new System.Drawing.Size(100, 21);
            this.l3txtCaster5.TabIndex = 38;
            this.l3txtCaster5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster5.Value = null;
            // 
            // l3txtCaster4
            // 
            this.l3txtCaster4.DataFormat = null;
            this.l3txtCaster4.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S64";
            this.l3txtCaster4.DataProperty = "HeatID";
            this.l3txtCaster4.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster4.L3DataAdapter = this.Adapter;
            this.l3txtCaster4.Location = new System.Drawing.Point(552, 75);
            this.l3txtCaster4.Name = "l3txtCaster4";
            this.l3txtCaster4.ReadOnly = true;
            this.l3txtCaster4.Size = new System.Drawing.Size(100, 21);
            this.l3txtCaster4.TabIndex = 37;
            this.l3txtCaster4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster4.Value = null;
            // 
            // l3txtCaster3
            // 
            this.l3txtCaster3.DataFormat = null;
            this.l3txtCaster3.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S63";
            this.l3txtCaster3.DataProperty = "HeatID";
            this.l3txtCaster3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster3.L3DataAdapter = this.Adapter;
            this.l3txtCaster3.Location = new System.Drawing.Point(385, 75);
            this.l3txtCaster3.Name = "l3txtCaster3";
            this.l3txtCaster3.ReadOnly = true;
            this.l3txtCaster3.Size = new System.Drawing.Size(100, 21);
            this.l3txtCaster3.TabIndex = 36;
            this.l3txtCaster3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster3.Value = null;
            // 
            // l3txtCaster2
            // 
            this.l3txtCaster2.DataFormat = null;
            this.l3txtCaster2.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S62";
            this.l3txtCaster2.DataProperty = "HeatID";
            this.l3txtCaster2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster2.L3DataAdapter = this.Adapter;
            this.l3txtCaster2.Location = new System.Drawing.Point(218, 75);
            this.l3txtCaster2.Name = "l3txtCaster2";
            this.l3txtCaster2.ReadOnly = true;
            this.l3txtCaster2.Size = new System.Drawing.Size(100, 21);
            this.l3txtCaster2.TabIndex = 35;
            this.l3txtCaster2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster2.Value = null;
            // 
            // l3txtCaster1
            // 
            this.l3txtCaster1.DataFormat = null;
            this.l3txtCaster1.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S61";
            this.l3txtCaster1.DataProperty = "HeatID";
            this.l3txtCaster1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster1.L3DataAdapter = this.Adapter;
            this.l3txtCaster1.Location = new System.Drawing.Point(51, 75);
            this.l3txtCaster1.Name = "l3txtCaster1";
            this.l3txtCaster1.ReadOnly = true;
            this.l3txtCaster1.Size = new System.Drawing.Size(100, 21);
            this.l3txtCaster1.TabIndex = 34;
            this.l3txtCaster1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster1.Value = null;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(666, 79);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 25;
            this.label25.Text = "5#铸机:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(499, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 24;
            this.label20.Text = "4#铸机:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(335, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 15;
            this.label19.Text = "3#铸机:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(165, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 14;
            this.label18.Text = "2#铸机:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 13;
            this.label17.Text = "1#铸机:";
            // 
            // l3DataBox4
            // 
            this.l3DataBox4.DataFormat = null;
            this.l3DataBox4.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\S51B";
            this.l3DataBox4.DataProperty = "HeatID";
            this.l3DataBox4.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox4.L3DataAdapter = this.Adapter;
            this.l3DataBox4.Location = new System.Drawing.Point(886, 42);
            this.l3DataBox4.Name = "l3DataBox4";
            this.l3DataBox4.ReadOnly = true;
            this.l3DataBox4.Size = new System.Drawing.Size(100, 21);
            this.l3DataBox4.TabIndex = 33;
            this.l3DataBox4.Tag = "";
            this.l3DataBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3DataBox4.Value = null;
            // 
            // l3txtRH1
            // 
            this.l3txtRH1.DataFormat = null;
            this.l3txtRH1.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\S51A";
            this.l3txtRH1.DataProperty = "HeatID";
            this.l3txtRH1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtRH1.L3DataAdapter = this.Adapter;
            this.l3txtRH1.Location = new System.Drawing.Point(886, 16);
            this.l3txtRH1.Name = "l3txtRH1";
            this.l3txtRH1.ReadOnly = true;
            this.l3txtRH1.Size = new System.Drawing.Size(100, 21);
            this.l3txtRH1.TabIndex = 33;
            this.l3txtRH1.Tag = "";
            this.l3txtRH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtRH1.Value = null;
            // 
            // l3DataBox3
            // 
            this.l3DataBox3.DataFormat = null;
            this.l3DataBox3.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S43A";
            this.l3DataBox3.DataProperty = "HeatID";
            this.l3DataBox3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox3.L3DataAdapter = this.Adapter;
            this.l3DataBox3.Location = new System.Drawing.Point(719, 16);
            this.l3DataBox3.Name = "l3DataBox3";
            this.l3DataBox3.ReadOnly = true;
            this.l3DataBox3.Size = new System.Drawing.Size(100, 21);
            this.l3DataBox3.TabIndex = 32;
            this.l3DataBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3DataBox3.Value = null;
            // 
            // l3txtLF3
            // 
            this.l3txtLF3.DataFormat = null;
            this.l3txtLF3.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S43B";
            this.l3txtLF3.DataProperty = "HeatID";
            this.l3txtLF3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF3.L3DataAdapter = this.Adapter;
            this.l3txtLF3.Location = new System.Drawing.Point(719, 42);
            this.l3txtLF3.Name = "l3txtLF3";
            this.l3txtLF3.ReadOnly = true;
            this.l3txtLF3.Size = new System.Drawing.Size(100, 21);
            this.l3txtLF3.TabIndex = 32;
            this.l3txtLF3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF3.Value = null;
            // 
            // l3DataBox2
            // 
            this.l3DataBox2.DataFormat = null;
            this.l3DataBox2.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S42B";
            this.l3DataBox2.DataProperty = "HeatID";
            this.l3DataBox2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox2.L3DataAdapter = this.Adapter;
            this.l3DataBox2.Location = new System.Drawing.Point(552, 42);
            this.l3DataBox2.Name = "l3DataBox2";
            this.l3DataBox2.ReadOnly = true;
            this.l3DataBox2.Size = new System.Drawing.Size(100, 21);
            this.l3DataBox2.TabIndex = 31;
            this.l3DataBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3DataBox2.Value = null;
            // 
            // l3txtLF2
            // 
            this.l3txtLF2.DataFormat = null;
            this.l3txtLF2.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S42A";
            this.l3txtLF2.DataProperty = "HeatID";
            this.l3txtLF2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF2.L3DataAdapter = this.Adapter;
            this.l3txtLF2.Location = new System.Drawing.Point(552, 16);
            this.l3txtLF2.Name = "l3txtLF2";
            this.l3txtLF2.ReadOnly = true;
            this.l3txtLF2.Size = new System.Drawing.Size(100, 21);
            this.l3txtLF2.TabIndex = 31;
            this.l3txtLF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF2.Value = null;
            // 
            // l3DataBox1
            // 
            this.l3DataBox1.DataFormat = null;
            this.l3DataBox1.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S41B";
            this.l3DataBox1.DataProperty = "HeatID";
            this.l3DataBox1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBox1.L3DataAdapter = this.Adapter;
            this.l3DataBox1.Location = new System.Drawing.Point(385, 42);
            this.l3DataBox1.Name = "l3DataBox1";
            this.l3DataBox1.ReadOnly = true;
            this.l3DataBox1.Size = new System.Drawing.Size(100, 21);
            this.l3DataBox1.TabIndex = 30;
            this.l3DataBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3DataBox1.Value = null;
            // 
            // l3txtLF1
            // 
            this.l3txtLF1.DataFormat = null;
            this.l3txtLF1.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\S41A";
            this.l3txtLF1.DataProperty = "HeatID";
            this.l3txtLF1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF1.L3DataAdapter = this.Adapter;
            this.l3txtLF1.Location = new System.Drawing.Point(385, 16);
            this.l3txtLF1.Name = "l3txtLF1";
            this.l3txtLF1.ReadOnly = true;
            this.l3txtLF1.Size = new System.Drawing.Size(100, 21);
            this.l3txtLF1.TabIndex = 30;
            this.l3txtLF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF1.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(827, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "1#RH[B]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "3#LF[A]:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(827, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "1#RH[A]:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(660, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "3#LF[B]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "2#LF[B]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "1#LF[B]:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "2#LF[A]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "1#LF[A]:";
            // 
            // l3txtBOF4
            // 
            this.l3txtBOF4.DataFormat = null;
            this.l3txtBOF4.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S24";
            this.l3txtBOF4.DataProperty = "HeatID";
            this.l3txtBOF4.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtBOF4.L3DataAdapter = this.Adapter;
            this.l3txtBOF4.Location = new System.Drawing.Point(218, 42);
            this.l3txtBOF4.Name = "l3txtBOF4";
            this.l3txtBOF4.ReadOnly = true;
            this.l3txtBOF4.Size = new System.Drawing.Size(100, 21);
            this.l3txtBOF4.TabIndex = 29;
            this.l3txtBOF4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtBOF4.Value = null;
            // 
            // l3txtBOF3
            // 
            this.l3txtBOF3.DataFormat = null;
            this.l3txtBOF3.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S23";
            this.l3txtBOF3.DataProperty = "HeatID";
            this.l3txtBOF3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtBOF3.L3DataAdapter = this.Adapter;
            this.l3txtBOF3.Location = new System.Drawing.Point(218, 16);
            this.l3txtBOF3.Name = "l3txtBOF3";
            this.l3txtBOF3.ReadOnly = true;
            this.l3txtBOF3.Size = new System.Drawing.Size(100, 21);
            this.l3txtBOF3.TabIndex = 28;
            this.l3txtBOF3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtBOF3.Value = null;
            // 
            // l3txtBOF2
            // 
            this.l3txtBOF2.DataFormat = null;
            this.l3txtBOF2.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S22";
            this.l3txtBOF2.DataProperty = "HeatID";
            this.l3txtBOF2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtBOF2.L3DataAdapter = this.Adapter;
            this.l3txtBOF2.Location = new System.Drawing.Point(51, 42);
            this.l3txtBOF2.Name = "l3txtBOF2";
            this.l3txtBOF2.ReadOnly = true;
            this.l3txtBOF2.Size = new System.Drawing.Size(100, 21);
            this.l3txtBOF2.TabIndex = 27;
            this.l3txtBOF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtBOF2.Value = null;
            // 
            // l3txtBOF1
            // 
            this.l3txtBOF1.BackColor = System.Drawing.SystemColors.Control;
            this.l3txtBOF1.DataFormat = null;
            this.l3txtBOF1.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S21";
            this.l3txtBOF1.DataProperty = "HeatID";
            this.l3txtBOF1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtBOF1.L3DataAdapter = this.Adapter;
            this.l3txtBOF1.Location = new System.Drawing.Point(51, 16);
            this.l3txtBOF1.Name = "l3txtBOF1";
            this.l3txtBOF1.ReadOnly = true;
            this.l3txtBOF1.Size = new System.Drawing.Size(100, 21);
            this.l3txtBOF1.TabIndex = 26;
            this.l3txtBOF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtBOF1.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "4#转炉:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "3#转炉:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "2#转炉:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "1#转炉:";
            // 
            // dbxSteelExchangeAppEvent
            // 
            this.dbxSteelExchangeAppEvent.DataFormat = null;
            this.dbxSteelExchangeAppEvent.DataObject = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dbxSteelExchangeAppEvent.DataProperty = "SteelExchangeAppEvent";
            this.dbxSteelExchangeAppEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxSteelExchangeAppEvent.L3DataAdapter = this.Adapter;
            this.dbxSteelExchangeAppEvent.Location = new System.Drawing.Point(866, 75);
            this.dbxSteelExchangeAppEvent.Name = "dbxSteelExchangeAppEvent";
            this.dbxSteelExchangeAppEvent.Size = new System.Drawing.Size(10, 21);
            this.dbxSteelExchangeAppEvent.TabIndex = 7;
            this.dbxSteelExchangeAppEvent.Value = null;
            this.dbxSteelExchangeAppEvent.Visible = false;
            this.dbxSteelExchangeAppEvent.TextChanged += new System.EventHandler(this.dbxSteelExchangeAppEvent_TextChanged);
            // 
            // dbxSteelDivAppEvent
            // 
            this.dbxSteelDivAppEvent.DataFormat = null;
            this.dbxSteelDivAppEvent.DataObject = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dbxSteelDivAppEvent.DataProperty = "SteelDivAppEvent";
            this.dbxSteelDivAppEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxSteelDivAppEvent.L3DataAdapter = this.Adapter;
            this.dbxSteelDivAppEvent.Location = new System.Drawing.Point(853, 75);
            this.dbxSteelDivAppEvent.Name = "dbxSteelDivAppEvent";
            this.dbxSteelDivAppEvent.Size = new System.Drawing.Size(10, 21);
            this.dbxSteelDivAppEvent.TabIndex = 6;
            this.dbxSteelDivAppEvent.Value = null;
            this.dbxSteelDivAppEvent.Visible = false;
            this.dbxSteelDivAppEvent.TextChanged += new System.EventHandler(this.dbxSteelDivAppEvent_TextChanged);
            // 
            // dbxSteelReturnAppEvent
            // 
            this.dbxSteelReturnAppEvent.DataFormat = null;
            this.dbxSteelReturnAppEvent.DataObject = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dbxSteelReturnAppEvent.DataProperty = "SteelReturnAppEvent";
            this.dbxSteelReturnAppEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxSteelReturnAppEvent.L3DataAdapter = this.Adapter;
            this.dbxSteelReturnAppEvent.Location = new System.Drawing.Point(840, 75);
            this.dbxSteelReturnAppEvent.Name = "dbxSteelReturnAppEvent";
            this.dbxSteelReturnAppEvent.Size = new System.Drawing.Size(10, 21);
            this.dbxSteelReturnAppEvent.TabIndex = 5;
            this.dbxSteelReturnAppEvent.Value = null;
            this.dbxSteelReturnAppEvent.Visible = false;
            this.dbxSteelReturnAppEvent.TextChanged += new System.EventHandler(this.dbxSteelReturnAppEvent_TextChanged);
            // 
            // dbxSteelBackAppEvent
            // 
            this.dbxSteelBackAppEvent.DataFormat = null;
            this.dbxSteelBackAppEvent.DataObject = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dbxSteelBackAppEvent.DataProperty = "SteelBackAppEvent";
            this.dbxSteelBackAppEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxSteelBackAppEvent.L3DataAdapter = this.Adapter;
            this.dbxSteelBackAppEvent.Location = new System.Drawing.Point(827, 75);
            this.dbxSteelBackAppEvent.Name = "dbxSteelBackAppEvent";
            this.dbxSteelBackAppEvent.Size = new System.Drawing.Size(10, 21);
            this.dbxSteelBackAppEvent.TabIndex = 4;
            this.dbxSteelBackAppEvent.Value = null;
            this.dbxSteelBackAppEvent.Visible = false;
            this.dbxSteelBackAppEvent.TextChanged += new System.EventHandler(this.dbxSteelBackAppEvent_TextChanged);
            // 
            // l3DataBoxTapEvent
            // 
            this.l3DataBoxTapEvent.DataFormat = null;
            this.l3DataBoxTapEvent.DataObject = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.l3DataBoxTapEvent.DataProperty = "TappingPlanEvent";
            this.l3DataBoxTapEvent.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3DataBoxTapEvent.L3DataAdapter = this.Adapter;
            this.l3DataBoxTapEvent.Location = new System.Drawing.Point(879, 75);
            this.l3DataBoxTapEvent.Name = "l3DataBoxTapEvent";
            this.l3DataBoxTapEvent.Size = new System.Drawing.Size(10, 21);
            this.l3DataBoxTapEvent.TabIndex = 3;
            this.l3DataBoxTapEvent.Value = null;
            this.l3DataBoxTapEvent.Visible = false;
            this.l3DataBoxTapEvent.TextChanged += new System.EventHandler(this.l3DataBoxTapEvent_TextChanged);
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
            this.dsStatus.SourceCondition = "Code_Group = \'TAPPING_PLAN_STATUS\'";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode_Des,
            this.coll3DataSet1L3DataTableCode_Val_Long});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Val_Long
            // 
            this.coll3DataSet1L3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coll3DataSet1L3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coll3DataSet1L3DataTableCode_Val_Long.DataType = typeof(int);
            this.coll3DataSet1L3DataTableCode_Val_Long.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvTapPlan);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 170);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1050, 230);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvTapPlan
            // 
            this.dvTapPlan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dvTapPlan.AllowUserToAddRows = false;
            this.dvTapPlan.AllowUserToResizeColumns = false;
            this.dvTapPlan.AllowUserToResizeRows = false;
            this.dvTapPlan.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dvTapPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvTapPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvTapPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvTapPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTapPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.PlanID,
            this.PreSteelGradeIndex,
            this.ActSteelGradeIndex,
            this.CasterID,
            this.CastingID,
            this.IronTime,
            this.BlowBegin,
            this.TappedTime,
            this.SideEndTime,
            this.LFArrivle,
            this.LFStartTime,
            this.LFLeave,
            this.RHArrivle,
            this.RHStartTime,
            this.RHLeave,
            this.LadleArrilTime,
            this.CasterStartTime,
            this.CasterEndTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvTapPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvTapPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTapPlan.Location = new System.Drawing.Point(0, 0);
            this.dvTapPlan.Name = "dvTapPlan";
            this.dvTapPlan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvTapPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvTapPlan.RowHeadersVisible = false;
            this.dvTapPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dvTapPlan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvTapPlan.RowTemplate.Height = 23;
            this.dvTapPlan.Size = new System.Drawing.Size(1046, 226);
            this.dvTapPlan.TabIndex = 2;
            this.dvTapPlan.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvTapPlan_CellMouseDown);
            // 
            // Selected
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Selected.DefaultCellStyle = dataGridViewCellStyle2;
            this.Selected.Frozen = true;
            this.Selected.HeaderText = "选择 ";
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Selected.Width = 37;
            // 
            // PlanID
            // 
            this.PlanID.Frozen = true;
            this.PlanID.HeaderText = "预定炉号";
            this.PlanID.Name = "PlanID";
            this.PlanID.ReadOnly = true;
            this.PlanID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PlanID.Width = 75;
            // 
            // PreSteelGradeIndex
            // 
            this.PreSteelGradeIndex.Frozen = true;
            this.PreSteelGradeIndex.HeaderText = "计划炼钢记号";
            this.PreSteelGradeIndex.Name = "PreSteelGradeIndex";
            this.PreSteelGradeIndex.ReadOnly = true;
            this.PreSteelGradeIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PreSteelGradeIndex.Width = 83;
            // 
            // ActSteelGradeIndex
            // 
            this.ActSteelGradeIndex.Frozen = true;
            this.ActSteelGradeIndex.HeaderText = "实际炼钢记号";
            this.ActSteelGradeIndex.Name = "ActSteelGradeIndex";
            this.ActSteelGradeIndex.ReadOnly = true;
            this.ActSteelGradeIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ActSteelGradeIndex.Width = 83;
            // 
            // CasterID
            // 
            this.CasterID.Frozen = true;
            this.CasterID.HeaderText = "铸机";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            this.CasterID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CasterID.Width = 70;
            // 
            // CastingID
            // 
            this.CastingID.Frozen = true;
            this.CastingID.HeaderText = "计划日期";
            this.CastingID.Name = "CastingID";
            this.CastingID.ReadOnly = true;
            this.CastingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CastingID.Width = 68;
            // 
            // IronTime
            // 
            this.IronTime.HeaderText = "兑铁时间";
            this.IronTime.Name = "IronTime";
            this.IronTime.ReadOnly = true;
            this.IronTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IronTime.Width = 95;
            // 
            // BlowBegin
            // 
            this.BlowBegin.HeaderText = "吹炼始";
            this.BlowBegin.Name = "BlowBegin";
            this.BlowBegin.ReadOnly = true;
            this.BlowBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BlowBegin.Width = 60;
            // 
            // TappedTime
            // 
            this.TappedTime.HeaderText = "出钢终";
            this.TappedTime.Name = "TappedTime";
            this.TappedTime.ReadOnly = true;
            this.TappedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TappedTime.Width = 55;
            // 
            // SideEndTime
            // 
            this.SideEndTime.HeaderText = "炉后终";
            this.SideEndTime.Name = "SideEndTime";
            this.SideEndTime.ReadOnly = true;
            this.SideEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SideEndTime.Width = 55;
            // 
            // LFArrivle
            // 
            this.LFArrivle.HeaderText = "LF进站";
            this.LFArrivle.Name = "LFArrivle";
            this.LFArrivle.ReadOnly = true;
            this.LFArrivle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LFArrivle.Width = 55;
            // 
            // LFStartTime
            // 
            this.LFStartTime.HeaderText = "LF始";
            this.LFStartTime.Name = "LFStartTime";
            this.LFStartTime.ReadOnly = true;
            this.LFStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LFStartTime.Width = 55;
            // 
            // LFLeave
            // 
            this.LFLeave.HeaderText = "LF出站";
            this.LFLeave.Name = "LFLeave";
            this.LFLeave.ReadOnly = true;
            this.LFLeave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LFLeave.Width = 55;
            // 
            // RHArrivle
            // 
            this.RHArrivle.HeaderText = "RH进站";
            this.RHArrivle.Name = "RHArrivle";
            this.RHArrivle.ReadOnly = true;
            this.RHArrivle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RHArrivle.Width = 55;
            // 
            // RHStartTime
            // 
            this.RHStartTime.HeaderText = "RH始";
            this.RHStartTime.Name = "RHStartTime";
            this.RHStartTime.ReadOnly = true;
            this.RHStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RHStartTime.Width = 55;
            // 
            // RHLeave
            // 
            this.RHLeave.HeaderText = "RH出站";
            this.RHLeave.Name = "RHLeave";
            this.RHLeave.ReadOnly = true;
            this.RHLeave.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RHLeave.Width = 55;
            // 
            // LadleArrilTime
            // 
            this.LadleArrilTime.HeaderText = "到达";
            this.LadleArrilTime.Name = "LadleArrilTime";
            this.LadleArrilTime.ReadOnly = true;
            this.LadleArrilTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LadleArrilTime.Width = 55;
            // 
            // CasterStartTime
            // 
            this.CasterStartTime.HeaderText = "浇注始";
            this.CasterStartTime.Name = "CasterStartTime";
            this.CasterStartTime.ReadOnly = true;
            this.CasterStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CasterStartTime.Width = 55;
            // 
            // CasterEndTime
            // 
            this.CasterEndTime.HeaderText = "浇注终";
            this.CasterEndTime.Name = "CasterEndTime";
            this.CasterEndTime.ReadOnly = true;
            this.CasterEndTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CasterEndTime.Width = 55;
            // 
            // dsBOFID
            // 
            this.dsBOFID.AutoLoad = true;
            this.dsBOFID.AutoSubscribe = false;
            this.dsBOFID.DataSetName = "L3DataSet";
            this.dsBOFID.DeleteMethod = null;
            this.dsBOFID.InsertMethod = null;
            this.dsBOFID.L3DataAdapter = this.Adapter;
            this.dsBOFID.LoadEvent = "Click";
            this.dsBOFID.LoadTrigger = null;
            this.dsBOFID.RefreshValve = 1000;
            this.dsBOFID.SourceCommand = null;
            this.dsBOFID.SourceCondition = "Code_Group = \'BOF\' order by Code";
            this.dsBOFID.SourceMethod = "";
            this.dsBOFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFID.SubscribeTarget = null;
            this.dsBOFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFID});
            this.dsBOFID.UpdateEvent = "Click";
            this.dsBOFID.UpdateMethod = null;
            this.dsBOFID.UpdateTrigger = null;
            // 
            // schemadsBOFID
            // 
            this.schemadsBOFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFIDL3DataTableCode,
            this.coldsBOFIDL3DataTableCode_Des});
            this.schemadsBOFID.TableName = "L3DataTable";
            // 
            // coldsBOFIDL3DataTableCode
            // 
            this.coldsBOFIDL3DataTableCode.Caption = "Code";
            this.coldsBOFIDL3DataTableCode.ColumnName = "Code";
            this.coldsBOFIDL3DataTableCode.Namespace = "";
            // 
            // coldsBOFIDL3DataTableCode_Des
            // 
            this.coldsBOFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.Namespace = "";
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
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' order by Code";
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
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.tscmbBOFID;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // tscmbBOFID
            // 
            this.tscmbBOFID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbBOFID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbBOFID.Name = "tscmbBOFID";
            this.tscmbBOFID.Size = new System.Drawing.Size(121, 25);
            this.tscmbBOFID.SelectedIndexChanged += new System.EventHandler(this.tscmbBOFID_SelectedIndexChanged);
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.tscmbCasterID;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // tscmbCasterID
            // 
            this.tscmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbCasterID.Name = "tscmbCasterID";
            this.tscmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.tscmbCasterID.SelectedIndexChanged += new System.EventHandler(this.tscmbCasterID_SelectedIndexChanged);
            // 
            // cmdTappingCancel
            // 
            this.cmdTappingCancel.Adapter = this.Adapter;
            this.cmdTappingCancel.MergeReturnTarget = false;
            this.cmdTappingCancel.Method = "TappingPlanCancel";
            this.cmdTappingCancel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdTappingCancel.Parameters.Add(this.l3CommandParameter5);
            this.cmdTappingCancel.ReturnTarget = null;
            this.cmdTappingCancel.ReturnTargetProperty = null;
            this.cmdTappingCancel.Trigger = null;
            this.cmdTappingCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = "";
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = "";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // cmdTappingSend
            // 
            this.cmdTappingSend.Adapter = this.Adapter;
            this.cmdTappingSend.MergeReturnTarget = false;
            this.cmdTappingSend.Method = "TappingPlanSend";
            this.cmdTappingSend.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdTappingSend.Parameters.Add(this.l3CommandParameter12);
            this.cmdTappingSend.ReturnTarget = null;
            this.cmdTappingSend.ReturnTargetProperty = null;
            this.cmdTappingSend.Trigger = null;
            this.cmdTappingSend.TriggerEvent = "Click";
            // 
            // l3CommandParameter12
            // 
            this.l3CommandParameter12.AcceptAfterExecuted = false;
            this.l3CommandParameter12.ConstantValue = null;
            this.l3CommandParameter12.MergeTarget = false;
            this.l3CommandParameter12.SourceFilter = "";
            this.l3CommandParameter12.SourceObject = null;
            this.l3CommandParameter12.SourceProperty = "";
            this.l3CommandParameter12.TargetObject = null;
            this.l3CommandParameter12.TargetProperty = null;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter6.SourceObject = this.dsTappingPlan;
            this.l3CommandParameter6.SourceProperty = "L3DataTable";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = null;
            this.l3CommandParameter7.SourceObject = null;
            this.l3CommandParameter7.SourceProperty = null;
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // cmdTappingSendCancel
            // 
            this.cmdTappingSendCancel.Adapter = this.Adapter;
            this.cmdTappingSendCancel.MergeReturnTarget = false;
            this.cmdTappingSendCancel.Method = "TappingPlanSndCancel";
            this.cmdTappingSendCancel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdTappingSendCancel.Parameters.Add(this.l3CommandParameter10);
            this.cmdTappingSendCancel.ReturnTarget = null;
            this.cmdTappingSendCancel.ReturnTargetProperty = null;
            this.cmdTappingSendCancel.Trigger = null;
            this.cmdTappingSendCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter10
            // 
            this.l3CommandParameter10.AcceptAfterExecuted = false;
            this.l3CommandParameter10.ConstantValue = null;
            this.l3CommandParameter10.MergeTarget = false;
            this.l3CommandParameter10.SourceFilter = "";
            this.l3CommandParameter10.SourceObject = null;
            this.l3CommandParameter10.SourceProperty = "";
            this.l3CommandParameter10.TargetObject = null;
            this.l3CommandParameter10.TargetProperty = null;
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter8.SourceObject = this.dsTappingPlan;
            this.l3CommandParameter8.SourceProperty = "L3DataTable";
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = null;
            this.l3CommandParameter9.SourceObject = null;
            this.l3CommandParameter9.SourceProperty = null;
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // l3CommandParameter11
            // 
            this.l3CommandParameter11.AcceptAfterExecuted = false;
            this.l3CommandParameter11.ConstantValue = null;
            this.l3CommandParameter11.MergeTarget = false;
            this.l3CommandParameter11.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter11.SourceObject = this.dsTappingPlan;
            this.l3CommandParameter11.SourceProperty = "L3DataTable";
            this.l3CommandParameter11.TargetObject = null;
            this.l3CommandParameter11.TargetProperty = null;
            // 
            // cmdExchange
            // 
            this.cmdExchange.Adapter = this.Adapter;
            this.cmdExchange.MergeReturnTarget = false;
            this.cmdExchange.Method = "TappingPlanExchange";
            this.cmdExchange.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdExchange.Parameters.Add(this.l3CommandParameter13);
            this.cmdExchange.ReturnTarget = null;
            this.cmdExchange.ReturnTargetProperty = null;
            this.cmdExchange.Trigger = null;
            this.cmdExchange.TriggerEvent = "Click";
            // 
            // l3CommandParameter13
            // 
            this.l3CommandParameter13.AcceptAfterExecuted = false;
            this.l3CommandParameter13.ConstantValue = null;
            this.l3CommandParameter13.MergeTarget = false;
            this.l3CommandParameter13.SourceFilter = "";
            this.l3CommandParameter13.SourceObject = null;
            this.l3CommandParameter13.SourceProperty = "";
            this.l3CommandParameter13.TargetObject = null;
            this.l3CommandParameter13.TargetProperty = null;
            // 
            // cmdExchangeTreatSeq
            // 
            this.cmdExchangeTreatSeq.Adapter = this.Adapter;
            this.cmdExchangeTreatSeq.MergeReturnTarget = false;
            this.cmdExchangeTreatSeq.Method = "TappingPlanExchangeTreatSeq";
            this.cmdExchangeTreatSeq.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdExchangeTreatSeq.Parameters.Add(this.l3CommandParameter14);
            this.cmdExchangeTreatSeq.ReturnTarget = null;
            this.cmdExchangeTreatSeq.ReturnTargetProperty = null;
            this.cmdExchangeTreatSeq.Trigger = null;
            this.cmdExchangeTreatSeq.TriggerEvent = "Click";
            // 
            // l3CommandParameter14
            // 
            this.l3CommandParameter14.AcceptAfterExecuted = false;
            this.l3CommandParameter14.ConstantValue = null;
            this.l3CommandParameter14.MergeTarget = false;
            this.l3CommandParameter14.SourceFilter = "";
            this.l3CommandParameter14.SourceObject = null;
            this.l3CommandParameter14.SourceProperty = "";
            this.l3CommandParameter14.TargetObject = null;
            this.l3CommandParameter14.TargetProperty = null;
            // 
            // cmdChangeRoute
            // 
            this.cmdChangeRoute.Adapter = this.Adapter;
            this.cmdChangeRoute.MergeReturnTarget = false;
            this.cmdChangeRoute.Method = "TappingPlanChangeRoute";
            this.cmdChangeRoute.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdChangeRoute.Parameters.Add(this.l3CommandParameter15);
            this.cmdChangeRoute.ReturnTarget = null;
            this.cmdChangeRoute.ReturnTargetProperty = null;
            this.cmdChangeRoute.Trigger = null;
            this.cmdChangeRoute.TriggerEvent = "Click";
            // 
            // l3CommandParameter15
            // 
            this.l3CommandParameter15.AcceptAfterExecuted = false;
            this.l3CommandParameter15.ConstantValue = null;
            this.l3CommandParameter15.MergeTarget = false;
            this.l3CommandParameter15.SourceFilter = null;
            this.l3CommandParameter15.SourceObject = this.dsTappingPlan;
            this.l3CommandParameter15.SourceProperty = null;
            this.l3CommandParameter15.TargetObject = null;
            this.l3CommandParameter15.TargetProperty = null;
            // 
            // dsChangeRoute
            // 
            this.dsChangeRoute.AutoLoad = true;
            this.dsChangeRoute.AutoSubscribe = true;
            this.dsChangeRoute.DataSetName = "L3DataSet";
            this.dsChangeRoute.DeleteMethod = null;
            this.dsChangeRoute.InsertMethod = null;
            this.dsChangeRoute.L3DataAdapter = null;
            this.dsChangeRoute.LoadEvent = "Click";
            this.dsChangeRoute.LoadTrigger = null;
            this.dsChangeRoute.RefreshValve = 1000;
            this.dsChangeRoute.SourceCommand = null;
            this.dsChangeRoute.SourceCondition = "";
            this.dsChangeRoute.SourceMethod = "";
            this.dsChangeRoute.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsChangeRoute.SourceURI = "";
            this.dsChangeRoute.SubscribeTarget = "";
            this.dsChangeRoute.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChangeRoute});
            this.dsChangeRoute.UpdateEvent = "Click";
            this.dsChangeRoute.UpdateMethod = null;
            this.dsChangeRoute.UpdateTrigger = null;
            // 
            // schemadsChangeRoute
            // 
            this.schemadsChangeRoute.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChangeRouteL3DataTablePreHeatID,
            this.coldsChangeRouteL3DataTableCasterID,
            this.coldsChangeRouteL3DataTableBOFID,
            this.coldsChangeRouteL3DataTableLFID,
            this.coldsChangeRouteL3DataTableRHID,
            this.coldsChangeRouteL3DataTableHeatID,
            this.coldsChangeRouteL3DataTableSteelGradeIndex,
            this.coldsChangeRouteL3DataTableSteelGrade});
            this.schemadsChangeRoute.TableName = "L3DataTable";
            // 
            // coldsChangeRouteL3DataTablePreHeatID
            // 
            this.coldsChangeRouteL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsChangeRouteL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsChangeRouteL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableCasterID
            // 
            this.coldsChangeRouteL3DataTableCasterID.Caption = "CasterID";
            this.coldsChangeRouteL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsChangeRouteL3DataTableCasterID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableBOFID
            // 
            this.coldsChangeRouteL3DataTableBOFID.Caption = "BOFID";
            this.coldsChangeRouteL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsChangeRouteL3DataTableBOFID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableLFID
            // 
            this.coldsChangeRouteL3DataTableLFID.Caption = "LFID";
            this.coldsChangeRouteL3DataTableLFID.ColumnName = "LFID";
            this.coldsChangeRouteL3DataTableLFID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableRHID
            // 
            this.coldsChangeRouteL3DataTableRHID.Caption = "RHID";
            this.coldsChangeRouteL3DataTableRHID.ColumnName = "RHID";
            this.coldsChangeRouteL3DataTableRHID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableHeatID
            // 
            this.coldsChangeRouteL3DataTableHeatID.Caption = "HeatID";
            this.coldsChangeRouteL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsChangeRouteL3DataTableHeatID.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableSteelGradeIndex
            // 
            this.coldsChangeRouteL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsChangeRouteL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsChangeRouteL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsChangeRouteL3DataTableSteelGrade
            // 
            this.coldsChangeRouteL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsChangeRouteL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsChangeRouteL3DataTableSteelGrade.Namespace = "";
            // 
            // dsCmd
            // 
            this.dsCmd.AutoLoad = true;
            this.dsCmd.AutoSubscribe = false;
            this.dsCmd.DataSetName = "L3DataSet";
            this.dsCmd.DeleteMethod = null;
            this.dsCmd.InsertMethod = null;
            this.dsCmd.L3DataAdapter = null;
            this.dsCmd.LoadEvent = "Click";
            this.dsCmd.LoadTrigger = null;
            this.dsCmd.RefreshValve = 1000;
            this.dsCmd.SourceCommand = null;
            this.dsCmd.SourceCondition = null;
            this.dsCmd.SourceMethod = null;
            this.dsCmd.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsCmd.SourceURI = null;
            this.dsCmd.SubscribeTarget = null;
            this.dsCmd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCmd});
            this.dsCmd.UpdateEvent = "Click";
            this.dsCmd.UpdateMethod = null;
            this.dsCmd.UpdateTrigger = null;
            // 
            // schemadsCmd
            // 
            this.schemadsCmd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCmdL3DataTablePlanID});
            this.schemadsCmd.TableName = "L3DataTable";
            // 
            // coldsCmdL3DataTablePlanID
            // 
            this.coldsCmdL3DataTablePlanID.Caption = "PlanID";
            this.coldsCmdL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsCmdL3DataTablePlanID.Namespace = "";
            // 
            // cmdStopPlan
            // 
            this.cmdStopPlan.Adapter = this.Adapter;
            this.cmdStopPlan.MergeReturnTarget = false;
            this.cmdStopPlan.Method = "TappingPlanEnd";
            this.cmdStopPlan.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdStopPlan.Parameters.Add(this.l3CommandParameter16);
            this.cmdStopPlan.ReturnTarget = null;
            this.cmdStopPlan.ReturnTargetProperty = null;
            this.cmdStopPlan.Trigger = null;
            this.cmdStopPlan.TriggerEvent = "Click";
            // 
            // l3CommandParameter16
            // 
            this.l3CommandParameter16.AcceptAfterExecuted = false;
            this.l3CommandParameter16.ConstantValue = null;
            this.l3CommandParameter16.MergeTarget = false;
            this.l3CommandParameter16.SourceFilter = null;
            this.l3CommandParameter16.SourceObject = null;
            this.l3CommandParameter16.SourceProperty = null;
            this.l3CommandParameter16.TargetObject = null;
            this.l3CommandParameter16.TargetProperty = null;
            // 
            // dsCmdd
            // 
            this.dsCmdd.AutoLoad = true;
            this.dsCmdd.AutoSubscribe = false;
            this.dsCmdd.DataSetName = "L3DataSet";
            this.dsCmdd.DeleteMethod = null;
            this.dsCmdd.InsertMethod = null;
            this.dsCmdd.L3DataAdapter = null;
            this.dsCmdd.LoadEvent = "Click";
            this.dsCmdd.LoadTrigger = null;
            this.dsCmdd.RefreshValve = 1000;
            this.dsCmdd.SourceCommand = null;
            this.dsCmdd.SourceCondition = null;
            this.dsCmdd.SourceMethod = null;
            this.dsCmdd.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsCmdd.SourceURI = null;
            this.dsCmdd.SubscribeTarget = null;
            this.dsCmdd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCmdd});
            this.dsCmdd.UpdateEvent = "Click";
            this.dsCmdd.UpdateMethod = null;
            this.dsCmdd.UpdateTrigger = null;
            // 
            // schemadsCmdd
            // 
            this.schemadsCmdd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCmddL3DataTablePlanID});
            this.schemadsCmdd.TableName = "L3DataTable";
            // 
            // coldsCmddL3DataTablePlanID
            // 
            this.coldsCmddL3DataTablePlanID.Caption = "PlanID";
            this.coldsCmddL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsCmddL3DataTablePlanID.Namespace = "";
            // 
            // dsErrorHeatExchange
            // 
            this.dsErrorHeatExchange.AutoLoad = true;
            this.dsErrorHeatExchange.AutoSubscribe = false;
            this.dsErrorHeatExchange.DataSetName = "L3DataSet";
            this.dsErrorHeatExchange.DeleteMethod = null;
            this.dsErrorHeatExchange.InsertMethod = null;
            this.dsErrorHeatExchange.L3DataAdapter = this.Adapter;
            this.dsErrorHeatExchange.LoadEvent = "Click";
            this.dsErrorHeatExchange.LoadTrigger = null;
            this.dsErrorHeatExchange.RefreshValve = 1000;
            this.dsErrorHeatExchange.SourceCommand = null;
            this.dsErrorHeatExchange.SourceCondition = "OWNER = \'TappingPlanExchange\'";
            this.dsErrorHeatExchange.SourceMethod = "";
            this.dsErrorHeatExchange.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsErrorHeatExchange.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsErrorHeatExchange.SubscribeTarget = null;
            this.dsErrorHeatExchange.UpdateEvent = "Click";
            this.dsErrorHeatExchange.UpdateMethod = null;
            this.dsErrorHeatExchange.UpdateTrigger = null;
            // 
            // dsErrorExchange
            // 
            this.dsErrorExchange.AutoLoad = true;
            this.dsErrorExchange.AutoSubscribe = false;
            this.dsErrorExchange.DataSetName = "L3DataSet";
            this.dsErrorExchange.DeleteMethod = null;
            this.dsErrorExchange.InsertMethod = null;
            this.dsErrorExchange.L3DataAdapter = this.Adapter;
            this.dsErrorExchange.LoadEvent = "Click";
            this.dsErrorExchange.LoadTrigger = null;
            this.dsErrorExchange.RefreshValve = 1000;
            this.dsErrorExchange.SourceCommand = null;
            this.dsErrorExchange.SourceCondition = "OWNER = \'TappingPlanExchangeTreatSeq\'";
            this.dsErrorExchange.SourceMethod = "";
            this.dsErrorExchange.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsErrorExchange.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsErrorExchange.SubscribeTarget = null;
            this.dsErrorExchange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsErrorExchange});
            this.dsErrorExchange.UpdateEvent = "Click";
            this.dsErrorExchange.UpdateMethod = null;
            this.dsErrorExchange.UpdateTrigger = null;
            // 
            // schemadsErrorExchange
            // 
            this.schemadsErrorExchange.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorExchangeL3DataTableGUID,
            this.coldsErrorExchangeL3DataTableName,
            this.coldsErrorExchangeL3DataTableError_Code,
            this.coldsErrorExchangeL3DataTableError_Des,
            this.coldsErrorExchangeL3DataTableOwner,
            this.coldsErrorExchangeL3DataTableOwner_Des,
            this.coldsErrorExchangeL3DataTableError_Val_Long});
            this.schemadsErrorExchange.TableName = "L3DataTable";
            // 
            // coldsErrorExchangeL3DataTableGUID
            // 
            this.coldsErrorExchangeL3DataTableGUID.Caption = "GUID";
            this.coldsErrorExchangeL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorExchangeL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableName
            // 
            this.coldsErrorExchangeL3DataTableName.Caption = "Name";
            this.coldsErrorExchangeL3DataTableName.ColumnName = "Name";
            this.coldsErrorExchangeL3DataTableName.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableError_Code
            // 
            this.coldsErrorExchangeL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorExchangeL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorExchangeL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableError_Des
            // 
            this.coldsErrorExchangeL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorExchangeL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorExchangeL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableOwner
            // 
            this.coldsErrorExchangeL3DataTableOwner.Caption = "Owner";
            this.coldsErrorExchangeL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorExchangeL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableOwner_Des
            // 
            this.coldsErrorExchangeL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorExchangeL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorExchangeL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorExchangeL3DataTableError_Val_Long
            // 
            this.coldsErrorExchangeL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorExchangeL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorExchangeL3DataTableError_Val_Long.Namespace = "";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel3.Text = "　　　　　";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "铸机:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "炉座:";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorCountItem.Text = "{0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsTappingPlan;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.CountItemFormat = "{0}";
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.tscmbCasterID,
            this.toolStripLabel4,
            this.tscmbBOFID,
            this.toolStripLabel2,
            this.tstxtBOFID,
            this.tstxtCasterID,
            this.toolStripSeparator1,
            this.bindingNavigatorCountItem});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = null;
            this.bdN1.MoveLastItem = null;
            this.bdN1.MoveNextItem = null;
            this.bdN1.MovePreviousItem = null;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = null;
            this.bdN1.Size = new System.Drawing.Size(1050, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.Color.Coral;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "查      询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "选择 ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "计划炼钢记号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "实际炼钢记号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 83;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "铸机";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "计划日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "兑铁时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 95;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "吹炼始";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "出钢终";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 55;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "炉后终";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 55;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "LF进站";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn11.Width = 55;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "LF始";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn12.Width = 55;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "LF出站";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn13.Width = 55;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "RH进站";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn14.Width = 55;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "RH始";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn15.Width = 55;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "RH出站";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn16.Width = 55;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "到达";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn17.Width = 55;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "浇注始";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn18.Width = 55;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "浇注终";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn19.Width = 55;
            // 
            // TappingPlanMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 400);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TappingPlanMainFrm";
            this.TabText = "出钢计划管理";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TappingPlanMainFrm_FormClosing);
            this.Load += new System.EventHandler(this.TappingPlanMainFrm_Load);
            this.VisibleChanged += new System.EventHandler(this.TappingPlanMainFrm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.bsTappingPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTappingPlan)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTapPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCmd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCmdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCmdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsErrorHeatExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsErrorExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsErrorExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsTappingPlan;
        private System.Windows.Forms.BindingSource bsTappingPlan;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnHeatExchange;
        private System.Windows.Forms.ToolStripButton btnSend;
        private System.Windows.Forms.ToolStripButton btnCancelTappingPlan;
        private System.Windows.Forms.ToolStripButton btnSendCancel;
        private System.Windows.Forms.ToolStripButton btnOnSeqExchange;
        private System.Windows.Forms.ToolStripButton btnTappingModify;
        private System.Windows.Forms.GroupBox groupBox1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3Command cmdQuery;
        private System.Data.DataTable schemadsTappingPlan;
        private System.Data.DataColumn coldsTappingPlanL3DataTableGUID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableNAME;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePLANID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCONTRACTID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSTATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePLANDEPT;
        private System.Data.DataColumn coldsTappingPlanL3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePLANNER;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePRE_LOTNO;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePREHEATID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TAPPED_WEIGHT;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCASTERID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableBOFID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableLFID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableRHID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableBOF_STATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTableLF_STATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTableRH_STATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCASTER_STATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSIDE_STATUS;
        private System.Data.DataColumn coldsTappingPlanL3DataTableHEATID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_BOFSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_LFARRIVAL;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_LFSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_LFEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_LFLEAVE;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_RHARRIVAL;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_RHSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_RHEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_RHLEAVE;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAIM_TIME_CASTINGEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableFIR_HEAT_FLAG;
        private System.Data.DataColumn coldsTappingPlanL3DataTableDIV_HEATID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableTEAMID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSHIFTID;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsTappingPlanL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSTEEL_RETURN_FLAG;
        private System.Data.DataColumn coldsTappingPlanL3DataTableSTEEL_BACK_FLAG;
        private System.Data.DataColumn coldsTappingPlanL3DataTableTREAT_SEQ;
        private System.Data.DataColumn coldsTappingPlanL3DataTableDESTITATION;
        private System.Data.DataColumn coldsTappingPlanL3DataTableNEW_BOF_FLAG;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_BOFSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_LFSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_LFEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_RHSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_RHEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsTappingPlanL3DataTableACT_TIME_CASTINGEND;
        private System.Data.DataColumn coldsTappingPlanL3DataTableLF_TREATNO;
        private System.Data.DataColumn coldsTappingPlanL3DataTableRH_TREATNO;
        private System.Data.DataColumn coldsTappingPlanL3DataTableCASTER_TREATNO;
        private AppSvrHMI.L3DataSet dsBOFID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3Command cmdTappingCancel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3Command cmdTappingSend;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3Command cmdTappingSendCancel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private AppSvrHMI.L3CommandParameter l3CommandParameter12;
        private AppSvrHMI.L3CommandParameter l3CommandParameter11;
        private AppSvrHMI.L3Command cmdExchange;
        private AppSvrHMI.L3Command cmdExchangeTreatSeq;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Val_Long;
        private AppSvrHMI.L3CommandParameter l3CommandParameter13;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsTappingPlanL3DataTablePRE_STEELGRADE;
        private AppSvrHMI.L3CommandParameter l3CommandParameter14;
        private System.Windows.Forms.ToolStripButton btnShowChangeRoute;
        private AppSvrHMI.L3Command cmdChangeRoute;
        private AppSvrHMI.L3CommandParameter l3CommandParameter15;
        private AppSvrHMI.L3DataSet dsChangeRoute;
        private System.Data.DataTable schemadsChangeRoute;
        private System.Data.DataColumn coldsChangeRouteL3DataTablePreHeatID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableCasterID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableBOFID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableLFID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableRHID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableHeatID;
        private System.Data.DataColumn coldsChangeRouteL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsChangeRouteL3DataTableSteelGrade;
        private System.Data.DataColumn coldsTappingPlanL3DataTableRefine_Type;
        private System.Windows.Forms.DataGridView dvTapPlan;
        private AppSvrHMI.L3DataSet dsCmd;
        private System.Data.DataTable schemadsCmd;
        private System.Data.DataColumn coldsCmdL3DataTablePlanID;
        private AppSvrHMI.L3DataBox l3DataBoxTapEvent;
        private System.Data.DataColumn coldsTappingPlanL3DataTableLength;
        private System.Data.DataColumn coldsTappingPlanL3DataTableThickness;
        private System.Data.DataColumn coldsTappingPlanL3DataTableWidth;
        private System.Windows.Forms.ToolStripButton btnDispAccount;
        private AppSvrHMI.L3Command cmdStopPlan;
        private AppSvrHMI.L3DataSet dsCmdd;
        private System.Data.DataTable schemadsCmdd;
        private System.Data.DataColumn coldsCmddL3DataTablePlanID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter16;
        private AppSvrHMI.L3DataBox dbxSteelBackAppEvent;
        private AppSvrHMI.L3DataBox dbxSteelExchangeAppEvent;
        private AppSvrHMI.L3DataBox dbxSteelDivAppEvent;
        private AppSvrHMI.L3DataBox dbxSteelReturnAppEvent;
        private AppSvrHMI.L3DataBox l3txtCaster5;
        private AppSvrHMI.L3DataBox l3txtCaster4;
        private AppSvrHMI.L3DataBox l3txtCaster3;
        private AppSvrHMI.L3DataBox l3txtCaster2;
        private AppSvrHMI.L3DataBox l3txtCaster1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private AppSvrHMI.L3DataBox l3txtRH1;
        private AppSvrHMI.L3DataBox l3txtLF3;
        private AppSvrHMI.L3DataBox l3txtLF2;
        private AppSvrHMI.L3DataBox l3txtLF1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private AppSvrHMI.L3DataBox l3txtBOF4;
        private AppSvrHMI.L3DataBox l3txtBOF3;
        private AppSvrHMI.L3DataBox l3txtBOF2;
        private AppSvrHMI.L3DataBox l3txtBOF1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAct_Time_LFArrival;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAct_Time_LFLeave;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAct_Time_RHArrival;
        private System.Data.DataColumn coldsTappingPlanL3DataTableAct_Time_RHLeave;
        private AppSvrHMI.L3Command l3Command1;
        private AppSvrHMI.L3DataSet dsErrorHeatExchange;
        private AppSvrHMI.L3DataSet dsErrorExchange;
        private System.Data.DataTable schemadsErrorExchange;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableGUID;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableName;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableOwner;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorExchangeL3DataTableError_Val_Long;
        private AppSvrHMI.L3DataBox l3DataBox2;
        private AppSvrHMI.L3DataBox l3DataBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataBox l3DataBox4;
        private AppSvrHMI.L3DataBox l3DataBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private buttonHide.MyLine myLine1;
        private System.Windows.Forms.ToolStripTextBox tstxtBOFID;
        private System.Windows.Forms.ToolStripTextBox tstxtCasterID;
        private System.Windows.Forms.ToolStripComboBox tscmbBOFID;
        private System.Windows.Forms.ToolStripComboBox tscmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private AppSvrHMI.L3DataBox dbxPlanCount1;
        private AppSvrHMI.L3DataBox dbxPlanCount4;
        private AppSvrHMI.L3DataBox dbxPlanCount3;
        private AppSvrHMI.L3DataBox dbxPlanCount2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreSteelGradeIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActSteelGradeIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IronTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlowBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TappedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LFArrivle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LFStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LFLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHArrivle;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RHLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn LadleArrilTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterEndTime;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnData;
    }
}