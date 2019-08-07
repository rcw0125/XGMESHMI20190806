namespace PlanMag
{
    partial class ChangeRouteFrm
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
            this.bsPlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlan = new AppSvrHMI.L3DataSet();
            this.schemadsPlan = new System.Data.DataTable();
            this.coldsPlanL3DataTableGUID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableNAME = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coldsPlanL3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coldsPlanL3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePLANNER = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePRE_LOTNO = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePRE_STEELGRADE = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableLFID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableRHID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableBOF_STATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTableLF_STATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTableRH_STATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCASTER_STATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSIDE_STATUS = new System.Data.DataColumn();
            this.coldsPlanL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsPlanL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_LFEND = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_RHEND = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsPlanL3DataTableFIR_HEAT_FLAG = new System.Data.DataColumn();
            this.coldsPlanL3DataTableDIV_HEATID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsPlanL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG = new System.Data.DataColumn();
            this.coldsPlanL3DataTableTREAT_SEQ = new System.Data.DataColumn();
            this.coldsPlanL3DataTableDESTITATION = new System.Data.DataColumn();
            this.coldsPlanL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpRoute = new System.Windows.Forms.TabPage();
            this.cmbCaster = new PxDataValid.PxComboBox();
            this.dsCaster = new AppSvrHMI.L3DataSet();
            this.schemabsCaster = new System.Data.DataTable();
            this.colbsCasterL3DataTableCode = new System.Data.DataColumn();
            this.colbsCasterL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBOF = new PxDataValid.PxComboBox();
            this.dsBOF = new AppSvrHMI.L3DataSet();
            this.schemadsBOF = new System.Data.DataTable();
            this.coldsBOFL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbRHID = new PxDataValid.PxComboBox();
            this.dsRH = new AppSvrHMI.L3DataSet();
            this.schemadsRH = new System.Data.DataTable();
            this.coldsRHL3DataTableCode = new System.Data.DataColumn();
            this.coldsRHL3DataTableCode_Des = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLFID = new PxDataValid.PxComboBox();
            this.dsLF = new AppSvrHMI.L3DataSet();
            this.schemadsLF = new System.Data.DataTable();
            this.coldsLFL3DataTableCode = new System.Data.DataColumn();
            this.coldsLFL3DataTableCode_Des = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbSteelGradeIndex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeRoute = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemabsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLF)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsPlan
            // 
            this.bsPlan.DataMember = "L3DataTable";
            this.bsPlan.DataSource = this.dsPlan;
            // 
            // dsPlan
            // 
            this.dsPlan.DataSetName = "L3DataSet";
            this.dsPlan.DeleteMethod = "";
            this.dsPlan.InsertMethod = "";
            this.dsPlan.L3DataAdapter = null;
            this.dsPlan.LoadEvent = "Click";
            this.dsPlan.LoadTrigger = null;
            this.dsPlan.RefreshValve = 1000;
            this.dsPlan.SourceCommand = null;
            this.dsPlan.SourceCondition = "";
            this.dsPlan.SourceMethod = "";
            this.dsPlan.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsPlan.SourceURI = "";
            this.dsPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPlan});
            this.dsPlan.UpdateEvent = "Click";
            this.dsPlan.UpdateMethod = "";
            this.dsPlan.UpdateTrigger = null;
            // 
            // schemadsPlan
            // 
            this.schemadsPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPlanL3DataTableGUID,
            this.coldsPlanL3DataTableNAME,
            this.coldsPlanL3DataTablePLANID,
            this.coldsPlanL3DataTableCONTRACTID,
            this.coldsPlanL3DataTableSTATUS,
            this.coldsPlanL3DataTablePLANDEPT,
            this.coldsPlanL3DataTableEXECUTEDEPT,
            this.coldsPlanL3DataTableCREATEDATE,
            this.coldsPlanL3DataTablePLANEXECUTEDATE,
            this.coldsPlanL3DataTableACTUALEXECUTEDATE,
            this.coldsPlanL3DataTablePLANNER,
            this.coldsPlanL3DataTablePRE_LOTNO,
            this.coldsPlanL3DataTablePREHEATID,
            this.coldsPlanL3DataTablePRE_STEELGRADEINDEX,
            this.coldsPlanL3DataTablePRE_STEELGRADE,
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT,
            this.coldsPlanL3DataTableCASTERID,
            this.coldsPlanL3DataTableBOFID,
            this.coldsPlanL3DataTableLFID,
            this.coldsPlanL3DataTableRHID,
            this.coldsPlanL3DataTableBOF_STATUS,
            this.coldsPlanL3DataTableLF_STATUS,
            this.coldsPlanL3DataTableRH_STATUS,
            this.coldsPlanL3DataTableCASTER_STATUS,
            this.coldsPlanL3DataTableSIDE_STATUS,
            this.coldsPlanL3DataTableHEATID,
            this.coldsPlanL3DataTableCASTING_NO,
            this.coldsPlanL3DataTableCASTING_HEAT_CNT,
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED,
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART,
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED,
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND,
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL,
            this.coldsPlanL3DataTableAIM_TIME_LFSTART,
            this.coldsPlanL3DataTableAIM_TIME_LFEND,
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE,
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL,
            this.coldsPlanL3DataTableAIM_TIME_RHSTART,
            this.coldsPlanL3DataTableAIM_TIME_RHEND,
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE,
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL,
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART,
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND,
            this.coldsPlanL3DataTableFIR_HEAT_FLAG,
            this.coldsPlanL3DataTableDIV_HEATID,
            this.coldsPlanL3DataTableTEAMID,
            this.coldsPlanL3DataTableSHIFTID,
            this.coldsPlanL3DataTableSTEELGRADEINDEX,
            this.coldsPlanL3DataTableSTEELGRADE,
            this.coldsPlanL3DataTablePLAN_ORD_ID,
            this.coldsPlanL3DataTableHOT_SEND_FLAG,
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG,
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG,
            this.coldsPlanL3DataTableTREAT_SEQ,
            this.coldsPlanL3DataTableDESTITATION,
            this.coldsPlanL3DataTableNEW_BOF_FLAG});
            this.schemadsPlan.TableName = "L3DataTable";
            // 
            // coldsPlanL3DataTableGUID
            // 
            this.coldsPlanL3DataTableGUID.Caption = "GUID";
            this.coldsPlanL3DataTableGUID.ColumnName = "GUID";
            this.coldsPlanL3DataTableGUID.Namespace = "";
            // 
            // coldsPlanL3DataTableNAME
            // 
            this.coldsPlanL3DataTableNAME.Caption = "Name";
            this.coldsPlanL3DataTableNAME.ColumnName = "NAME";
            this.coldsPlanL3DataTableNAME.Namespace = "";
            // 
            // coldsPlanL3DataTablePLANID
            // 
            this.coldsPlanL3DataTablePLANID.Caption = "PlanID";
            this.coldsPlanL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsPlanL3DataTablePLANID.Namespace = "";
            // 
            // coldsPlanL3DataTableCONTRACTID
            // 
            this.coldsPlanL3DataTableCONTRACTID.Caption = "ContractID";
            this.coldsPlanL3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coldsPlanL3DataTableCONTRACTID.Namespace = "";
            // 
            // coldsPlanL3DataTableSTATUS
            // 
            this.coldsPlanL3DataTableSTATUS.Caption = "Status";
            this.coldsPlanL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsPlanL3DataTableSTATUS.DataType = typeof(int);
            this.coldsPlanL3DataTableSTATUS.Namespace = "";
            // 
            // coldsPlanL3DataTablePLANDEPT
            // 
            this.coldsPlanL3DataTablePLANDEPT.Caption = "PlanDept";
            this.coldsPlanL3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coldsPlanL3DataTablePLANDEPT.Namespace = "";
            // 
            // coldsPlanL3DataTableEXECUTEDEPT
            // 
            this.coldsPlanL3DataTableEXECUTEDEPT.Caption = "ExecuteDept";
            this.coldsPlanL3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coldsPlanL3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coldsPlanL3DataTableCREATEDATE
            // 
            this.coldsPlanL3DataTableCREATEDATE.Caption = "CreateDate";
            this.coldsPlanL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsPlanL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsPlanL3DataTablePLANEXECUTEDATE
            // 
            this.coldsPlanL3DataTablePLANEXECUTEDATE.Caption = "PlanExecuteDate";
            this.coldsPlanL3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coldsPlanL3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coldsPlanL3DataTableACTUALEXECUTEDATE
            // 
            this.coldsPlanL3DataTableACTUALEXECUTEDATE.Caption = "ActualExecuteDate";
            this.coldsPlanL3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coldsPlanL3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coldsPlanL3DataTablePLANNER
            // 
            this.coldsPlanL3DataTablePLANNER.Caption = "Planner";
            this.coldsPlanL3DataTablePLANNER.ColumnName = "PLANNER";
            this.coldsPlanL3DataTablePLANNER.Namespace = "";
            // 
            // coldsPlanL3DataTablePRE_LOTNO
            // 
            this.coldsPlanL3DataTablePRE_LOTNO.Caption = "Pre_LotNo";
            this.coldsPlanL3DataTablePRE_LOTNO.ColumnName = "PRE_LOTNO";
            this.coldsPlanL3DataTablePRE_LOTNO.Namespace = "";
            // 
            // coldsPlanL3DataTablePREHEATID
            // 
            this.coldsPlanL3DataTablePREHEATID.Caption = "PreHeatID";
            this.coldsPlanL3DataTablePREHEATID.ColumnName = "PREHEATID";
            this.coldsPlanL3DataTablePREHEATID.Namespace = "";
            // 
            // coldsPlanL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsPlanL3DataTablePRE_STEELGRADEINDEX.Caption = "Pre_SteelGradeIndex";
            this.coldsPlanL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsPlanL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsPlanL3DataTablePRE_STEELGRADE
            // 
            this.coldsPlanL3DataTablePRE_STEELGRADE.Caption = "Pre_SteelGrade";
            this.coldsPlanL3DataTablePRE_STEELGRADE.ColumnName = "PRE_STEELGRADE";
            this.coldsPlanL3DataTablePRE_STEELGRADE.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TAPPED_WEIGHT
            // 
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT.Caption = "Aim_Tapped_Weight";
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT.ColumnName = "AIM_TAPPED_WEIGHT";
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT.DataType = typeof(double);
            this.coldsPlanL3DataTableAIM_TAPPED_WEIGHT.Namespace = "";
            // 
            // coldsPlanL3DataTableCASTERID
            // 
            this.coldsPlanL3DataTableCASTERID.Caption = "CasterID";
            this.coldsPlanL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsPlanL3DataTableCASTERID.Namespace = "";
            // 
            // coldsPlanL3DataTableBOFID
            // 
            this.coldsPlanL3DataTableBOFID.Caption = "BOFID";
            this.coldsPlanL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsPlanL3DataTableBOFID.Namespace = "";
            // 
            // coldsPlanL3DataTableLFID
            // 
            this.coldsPlanL3DataTableLFID.Caption = "LFID";
            this.coldsPlanL3DataTableLFID.ColumnName = "LFID";
            this.coldsPlanL3DataTableLFID.Namespace = "";
            // 
            // coldsPlanL3DataTableRHID
            // 
            this.coldsPlanL3DataTableRHID.Caption = "RHID";
            this.coldsPlanL3DataTableRHID.ColumnName = "RHID";
            this.coldsPlanL3DataTableRHID.Namespace = "";
            // 
            // coldsPlanL3DataTableBOF_STATUS
            // 
            this.coldsPlanL3DataTableBOF_STATUS.Caption = "BOF_Status";
            this.coldsPlanL3DataTableBOF_STATUS.ColumnName = "BOF_STATUS";
            this.coldsPlanL3DataTableBOF_STATUS.Namespace = "";
            // 
            // coldsPlanL3DataTableLF_STATUS
            // 
            this.coldsPlanL3DataTableLF_STATUS.Caption = "LF_Status";
            this.coldsPlanL3DataTableLF_STATUS.ColumnName = "LF_STATUS";
            this.coldsPlanL3DataTableLF_STATUS.Namespace = "";
            // 
            // coldsPlanL3DataTableRH_STATUS
            // 
            this.coldsPlanL3DataTableRH_STATUS.Caption = "RH_Status";
            this.coldsPlanL3DataTableRH_STATUS.ColumnName = "RH_STATUS";
            this.coldsPlanL3DataTableRH_STATUS.Namespace = "";
            // 
            // coldsPlanL3DataTableCASTER_STATUS
            // 
            this.coldsPlanL3DataTableCASTER_STATUS.Caption = "Caster_Status";
            this.coldsPlanL3DataTableCASTER_STATUS.ColumnName = "CASTER_STATUS";
            this.coldsPlanL3DataTableCASTER_STATUS.Namespace = "";
            // 
            // coldsPlanL3DataTableSIDE_STATUS
            // 
            this.coldsPlanL3DataTableSIDE_STATUS.Caption = "Side_Status";
            this.coldsPlanL3DataTableSIDE_STATUS.ColumnName = "SIDE_STATUS";
            this.coldsPlanL3DataTableSIDE_STATUS.Namespace = "";
            // 
            // coldsPlanL3DataTableHEATID
            // 
            this.coldsPlanL3DataTableHEATID.Caption = "HeatID";
            this.coldsPlanL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsPlanL3DataTableHEATID.Namespace = "";
            // 
            // coldsPlanL3DataTableCASTING_NO
            // 
            this.coldsPlanL3DataTableCASTING_NO.Caption = "Casting_No";
            this.coldsPlanL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsPlanL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsPlanL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsPlanL3DataTableCASTING_HEAT_CNT.Caption = "Casting_Heat_Cnt";
            this.coldsPlanL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsPlanL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsPlanL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_IRONPREPARED
            // 
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED.Caption = "Aim_Time_IronPrepared";
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED.ColumnName = "AIM_TIME_IRONPREPARED";
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_BOFSTART
            // 
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART.Caption = "Aim_Time_BOFStart";
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART.ColumnName = "AIM_TIME_BOFSTART";
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_BOFSTART.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_BOFTAPPED
            // 
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED.Caption = "Aim_Time_BOFTapped";
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED.ColumnName = "AIM_TIME_BOFTAPPED";
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND
            // 
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.Caption = "Aim_Time_TappedSideEnd";
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.ColumnName = "AIM_TIME_TAPPEDSIDEEND";
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_LFARRIVAL
            // 
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL.Caption = "Aim_Time_LFArrival";
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL.ColumnName = "AIM_TIME_LFARRIVAL";
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_LFARRIVAL.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_LFSTART
            // 
            this.coldsPlanL3DataTableAIM_TIME_LFSTART.Caption = "Aim_Time_LFStart";
            this.coldsPlanL3DataTableAIM_TIME_LFSTART.ColumnName = "AIM_TIME_LFSTART";
            this.coldsPlanL3DataTableAIM_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_LFSTART.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_LFEND
            // 
            this.coldsPlanL3DataTableAIM_TIME_LFEND.Caption = "Aim_Time_LFEnd";
            this.coldsPlanL3DataTableAIM_TIME_LFEND.ColumnName = "AIM_TIME_LFEND";
            this.coldsPlanL3DataTableAIM_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_LFEND.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_LFLEAVE
            // 
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE.Caption = "Aim_Time_LFLeave";
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE.ColumnName = "AIM_TIME_LFLEAVE";
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_LFLEAVE.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_RHARRIVAL
            // 
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL.Caption = "Aim_Time_RHArrival";
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL.ColumnName = "AIM_TIME_RHARRIVAL";
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_RHARRIVAL.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_RHSTART
            // 
            this.coldsPlanL3DataTableAIM_TIME_RHSTART.Caption = "Aim_Time_RHStart";
            this.coldsPlanL3DataTableAIM_TIME_RHSTART.ColumnName = "AIM_TIME_RHSTART";
            this.coldsPlanL3DataTableAIM_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_RHSTART.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_RHEND
            // 
            this.coldsPlanL3DataTableAIM_TIME_RHEND.Caption = "Aim_Time_RHEnd";
            this.coldsPlanL3DataTableAIM_TIME_RHEND.ColumnName = "AIM_TIME_RHEND";
            this.coldsPlanL3DataTableAIM_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_RHEND.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_RHLEAVE
            // 
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE.Caption = "Aim_Time_RHLeave";
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE.ColumnName = "AIM_TIME_RHLEAVE";
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_RHLEAVE.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL
            // 
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL.Caption = "Aim_Time_CasterArrival";
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL.ColumnName = "AIM_TIME_CASTERARRIVAL";
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_CASTINGSTART
            // 
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART.Caption = "Aim_Time_CastingStart";
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART.ColumnName = "AIM_TIME_CASTINGSTART";
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsPlanL3DataTableAIM_TIME_CASTINGEND
            // 
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND.Caption = "Aim_Time_CastingEnd";
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND.ColumnName = "AIM_TIME_CASTINGEND";
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableAIM_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsPlanL3DataTableFIR_HEAT_FLAG
            // 
            this.coldsPlanL3DataTableFIR_HEAT_FLAG.Caption = "Fir_Heat_Flag";
            this.coldsPlanL3DataTableFIR_HEAT_FLAG.ColumnName = "FIR_HEAT_FLAG";
            this.coldsPlanL3DataTableFIR_HEAT_FLAG.DataType = typeof(int);
            this.coldsPlanL3DataTableFIR_HEAT_FLAG.Namespace = "";
            // 
            // coldsPlanL3DataTableDIV_HEATID
            // 
            this.coldsPlanL3DataTableDIV_HEATID.Caption = "Div_HeatID";
            this.coldsPlanL3DataTableDIV_HEATID.ColumnName = "DIV_HEATID";
            this.coldsPlanL3DataTableDIV_HEATID.Namespace = "";
            // 
            // coldsPlanL3DataTableTEAMID
            // 
            this.coldsPlanL3DataTableTEAMID.Caption = "TeamID";
            this.coldsPlanL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsPlanL3DataTableTEAMID.Namespace = "";
            // 
            // coldsPlanL3DataTableSHIFTID
            // 
            this.coldsPlanL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsPlanL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsPlanL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsPlanL3DataTableSTEELGRADEINDEX
            // 
            this.coldsPlanL3DataTableSTEELGRADEINDEX.Caption = "SteelGradeIndex";
            this.coldsPlanL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsPlanL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsPlanL3DataTableSTEELGRADE
            // 
            this.coldsPlanL3DataTableSTEELGRADE.Caption = "SteelGrade";
            this.coldsPlanL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsPlanL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsPlanL3DataTablePLAN_ORD_ID
            // 
            this.coldsPlanL3DataTablePLAN_ORD_ID.Caption = "Plan_Ord_ID";
            this.coldsPlanL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsPlanL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsPlanL3DataTableHOT_SEND_FLAG
            // 
            this.coldsPlanL3DataTableHOT_SEND_FLAG.Caption = "Hot_Send_Flag";
            this.coldsPlanL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsPlanL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsPlanL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsPlanL3DataTableSTEEL_RETURN_FLAG
            // 
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG.Caption = "Steel_Return_Flag";
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG.ColumnName = "STEEL_RETURN_FLAG";
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG.DataType = typeof(int);
            this.coldsPlanL3DataTableSTEEL_RETURN_FLAG.Namespace = "";
            // 
            // coldsPlanL3DataTableSTEEL_BACK_FLAG
            // 
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG.Caption = "Steel_Back_Flag";
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG.ColumnName = "STEEL_BACK_FLAG";
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG.DataType = typeof(int);
            this.coldsPlanL3DataTableSTEEL_BACK_FLAG.Namespace = "";
            // 
            // coldsPlanL3DataTableTREAT_SEQ
            // 
            this.coldsPlanL3DataTableTREAT_SEQ.Caption = "Treat_Seq";
            this.coldsPlanL3DataTableTREAT_SEQ.ColumnName = "TREAT_SEQ";
            this.coldsPlanL3DataTableTREAT_SEQ.Namespace = "";
            // 
            // coldsPlanL3DataTableDESTITATION
            // 
            this.coldsPlanL3DataTableDESTITATION.Caption = "Destitation";
            this.coldsPlanL3DataTableDESTITATION.ColumnName = "DESTITATION";
            this.coldsPlanL3DataTableDESTITATION.Namespace = "";
            // 
            // coldsPlanL3DataTableNEW_BOF_FLAG
            // 
            this.coldsPlanL3DataTableNEW_BOF_FLAG.Caption = "New_BOF_Flag";
            this.coldsPlanL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsPlanL3DataTableNEW_BOF_FLAG.DataType = typeof(bool);
            this.coldsPlanL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpRoute);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 107);
            this.tabControl1.TabIndex = 146;
            // 
            // tpRoute
            // 
            this.tpRoute.Controls.Add(this.cmbCaster);
            this.tpRoute.Controls.Add(this.cmbBOF);
            this.tpRoute.Controls.Add(this.cmbRHID);
            this.tpRoute.Controls.Add(this.label4);
            this.tpRoute.Controls.Add(this.label3);
            this.tpRoute.Controls.Add(this.cmbLFID);
            this.tpRoute.Controls.Add(this.label2);
            this.tpRoute.Controls.Add(this.label1);
            this.tpRoute.Location = new System.Drawing.Point(4, 21);
            this.tpRoute.Name = "tpRoute";
            this.tpRoute.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoute.Size = new System.Drawing.Size(371, 82);
            this.tpRoute.TabIndex = 0;
            this.tpRoute.Text = "指定工艺路径";
            this.tpRoute.UseVisualStyleBackColor = true;
            // 
            // cmbCaster
            // 
            this.cmbCaster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCaster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCaster.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPlan, "CASTERID", true));
            this.cmbCaster.DataSource = this.dsCaster;
            this.cmbCaster.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCaster.Enabled = false;
            this.cmbCaster.EnableNull = false;
            this.cmbCaster.ErropPr = this.errorProvider1;
            this.cmbCaster.FormattingEnabled = true;
            this.cmbCaster.Location = new System.Drawing.Point(255, 47);
            this.cmbCaster.Name = "cmbCaster";
            this.cmbCaster.Size = new System.Drawing.Size(93, 20);
            this.cmbCaster.TabIndex = 4;
            this.cmbCaster.ToolTipValid = this.toolTip1;
            this.cmbCaster.ValidEable = true;
            this.cmbCaster.ValueMember = "L3DataTable.Code";
            // 
            // dsCaster
            // 
            this.dsCaster.DataSetName = "L3DataSet";
            this.dsCaster.DeleteMethod = null;
            this.dsCaster.InsertMethod = null;
            this.dsCaster.L3DataAdapter = this.Adapter;
            this.dsCaster.LoadEvent = "Click";
            this.dsCaster.LoadTrigger = null;
            this.dsCaster.RefreshValve = 1000;
            this.dsCaster.SourceCommand = null;
            this.dsCaster.SourceCondition = "Code_Group = \'Caster\'";
            this.dsCaster.SourceMethod = "";
            this.dsCaster.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCaster.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCaster.SubscribeTarget = null;
            this.dsCaster.Tables.AddRange(new System.Data.DataTable[] {
            this.schemabsCaster});
            this.dsCaster.UpdateEvent = "Click";
            this.dsCaster.UpdateMethod = null;
            this.dsCaster.UpdateTrigger = null;
            // 
            // schemabsCaster
            // 
            this.schemabsCaster.Columns.AddRange(new System.Data.DataColumn[] {
            this.colbsCasterL3DataTableCode,
            this.colbsCasterL3DataTableCode_Des});
            this.schemabsCaster.TableName = "L3DataTable";
            // 
            // colbsCasterL3DataTableCode
            // 
            this.colbsCasterL3DataTableCode.Caption = "Code";
            this.colbsCasterL3DataTableCode.ColumnName = "Code";
            this.colbsCasterL3DataTableCode.Namespace = "";
            // 
            // colbsCasterL3DataTableCode_Des
            // 
            this.colbsCasterL3DataTableCode_Des.Caption = "Code_Des";
            this.colbsCasterL3DataTableCode_Des.ColumnName = "Code_Des";
            this.colbsCasterL3DataTableCode_Des.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbBOF
            // 
            this.cmbBOF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBOF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBOF.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPlan, "BOFID", true));
            this.cmbBOF.DataSource = this.dsBOF;
            this.cmbBOF.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBOF.Enabled = false;
            this.cmbBOF.EnableNull = false;
            this.cmbBOF.ErropPr = this.errorProvider1;
            this.cmbBOF.FormattingEnabled = true;
            this.cmbBOF.Location = new System.Drawing.Point(83, 21);
            this.cmbBOF.Name = "cmbBOF";
            this.cmbBOF.Size = new System.Drawing.Size(93, 20);
            this.cmbBOF.TabIndex = 3;
            this.cmbBOF.ToolTipValid = this.toolTip1;
            this.cmbBOF.ValidEable = true;
            this.cmbBOF.ValueMember = "L3DataTable.Code";
            // 
            // dsBOF
            // 
            this.dsBOF.DataSetName = "L3DataSet";
            this.dsBOF.DeleteMethod = null;
            this.dsBOF.InsertMethod = null;
            this.dsBOF.L3DataAdapter = this.Adapter;
            this.dsBOF.LoadEvent = "Click";
            this.dsBOF.LoadTrigger = null;
            this.dsBOF.RefreshValve = 1000;
            this.dsBOF.SourceCommand = null;
            this.dsBOF.SourceCondition = "Code_Group = \'BOF\'";
            this.dsBOF.SourceMethod = "";
            this.dsBOF.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOF.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOF.SubscribeTarget = null;
            this.dsBOF.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOF});
            this.dsBOF.UpdateEvent = "Click";
            this.dsBOF.UpdateMethod = null;
            this.dsBOF.UpdateTrigger = null;
            // 
            // schemadsBOF
            // 
            this.schemadsBOF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFL3DataTableCode,
            this.coldsBOFL3DataTableCode_Des});
            this.schemadsBOF.TableName = "L3DataTable";
            // 
            // coldsBOFL3DataTableCode
            // 
            this.coldsBOFL3DataTableCode.Caption = "Code";
            this.coldsBOFL3DataTableCode.ColumnName = "Code";
            this.coldsBOFL3DataTableCode.Namespace = "";
            // 
            // coldsBOFL3DataTableCode_Des
            // 
            this.coldsBOFL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFL3DataTableCode_Des.Namespace = "";
            // 
            // cmbRHID
            // 
            this.cmbRHID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRHID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRHID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPlan, "RHID", true));
            this.cmbRHID.DataSource = this.dsRH;
            this.cmbRHID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbRHID.EnableNull = false;
            this.cmbRHID.ErropPr = this.errorProvider1;
            this.cmbRHID.FormattingEnabled = true;
            this.cmbRHID.Location = new System.Drawing.Point(83, 47);
            this.cmbRHID.Name = "cmbRHID";
            this.cmbRHID.Size = new System.Drawing.Size(93, 20);
            this.cmbRHID.TabIndex = 1;
            this.cmbRHID.ToolTipValid = this.toolTip1;
            this.cmbRHID.ValidEable = true;
            this.cmbRHID.ValueMember = "L3DataTable.Code";
            // 
            // dsRH
            // 
            this.dsRH.DataSetName = "L3DataSet";
            this.dsRH.DeleteMethod = null;
            this.dsRH.InsertMethod = null;
            this.dsRH.L3DataAdapter = this.Adapter;
            this.dsRH.LoadEvent = "Click";
            this.dsRH.LoadTrigger = null;
            this.dsRH.RefreshValve = 1000;
            this.dsRH.SourceCommand = null;
            this.dsRH.SourceCondition = "Code_Group = \'RH_CHANGE\'";
            this.dsRH.SourceMethod = "";
            this.dsRH.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRH.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRH.SubscribeTarget = null;
            this.dsRH.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRH});
            this.dsRH.UpdateEvent = "Click";
            this.dsRH.UpdateMethod = null;
            this.dsRH.UpdateTrigger = null;
            // 
            // schemadsRH
            // 
            this.schemadsRH.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRHL3DataTableCode,
            this.coldsRHL3DataTableCode_Des});
            this.schemadsRH.TableName = "L3DataTable";
            // 
            // coldsRHL3DataTableCode
            // 
            this.coldsRHL3DataTableCode.Caption = "Code";
            this.coldsRHL3DataTableCode.ColumnName = "Code";
            this.coldsRHL3DataTableCode.Namespace = "";
            // 
            // coldsRHL3DataTableCode_Des
            // 
            this.coldsRHL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRHL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRHL3DataTableCode_Des.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "RH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "铸机:";
            // 
            // cmbLFID
            // 
            this.cmbLFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLFID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPlan, "LFID", true));
            this.cmbLFID.DataSource = this.dsLF;
            this.cmbLFID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbLFID.EnableNull = false;
            this.cmbLFID.ErropPr = this.errorProvider1;
            this.cmbLFID.FormattingEnabled = true;
            this.cmbLFID.Location = new System.Drawing.Point(255, 21);
            this.cmbLFID.Name = "cmbLFID";
            this.cmbLFID.Size = new System.Drawing.Size(93, 20);
            this.cmbLFID.TabIndex = 1;
            this.cmbLFID.ToolTipValid = this.toolTip1;
            this.cmbLFID.ValidEable = true;
            this.cmbLFID.ValueMember = "L3DataTable.Code";
            // 
            // dsLF
            // 
            this.dsLF.DataSetName = "L3DataSet";
            this.dsLF.DeleteMethod = null;
            this.dsLF.InsertMethod = null;
            this.dsLF.L3DataAdapter = this.Adapter;
            this.dsLF.LoadEvent = "Click";
            this.dsLF.LoadTrigger = null;
            this.dsLF.RefreshValve = 1000;
            this.dsLF.SourceCommand = null;
            this.dsLF.SourceCondition = "Code_Group = \'LF_CHANGE\'";
            this.dsLF.SourceMethod = "";
            this.dsLF.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLF.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLF.SubscribeTarget = null;
            this.dsLF.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLF});
            this.dsLF.UpdateEvent = "Click";
            this.dsLF.UpdateMethod = null;
            this.dsLF.UpdateTrigger = null;
            // 
            // schemadsLF
            // 
            this.schemadsLF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLFL3DataTableCode,
            this.coldsLFL3DataTableCode_Des});
            this.schemadsLF.TableName = "L3DataTable";
            // 
            // coldsLFL3DataTableCode
            // 
            this.coldsLFL3DataTableCode.Caption = "Code";
            this.coldsLFL3DataTableCode.ColumnName = "Code";
            this.coldsLFL3DataTableCode.Namespace = "";
            // 
            // coldsLFL3DataTableCode_Des
            // 
            this.coldsLFL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLFL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLFL3DataTableCode_Des.Namespace = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "LF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "转炉:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 107);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(379, 108);
            this.tabControl2.TabIndex = 147;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.lbSteelGradeIndex);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 83);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "炉次计划基本信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlan, "HEATID", true));
            this.label21.Location = new System.Drawing.Point(83, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "xxxxxx";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlan, "PREHEATID", true));
            this.label19.Location = new System.Drawing.Point(83, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "xxxxxx";
            // 
            // lbSteelGradeIndex
            // 
            this.lbSteelGradeIndex.AutoSize = true;
            this.lbSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlan, "STEELGRADEINDEX", true));
            this.lbSteelGradeIndex.Location = new System.Drawing.Point(255, 23);
            this.lbSteelGradeIndex.Name = "lbSteelGradeIndex";
            this.lbSteelGradeIndex.Size = new System.Drawing.Size(41, 12);
            this.lbSteelGradeIndex.TabIndex = 0;
            this.lbSteelGradeIndex.Text = "xxxxxx";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "炼钢记号:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "炉号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "预定炉号:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(196, 221);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 148;
            this.btnChange.Text = "更改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(277, 221);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 148;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsPlan;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // cmdChangeRoute
            // 
            this.cmdChangeRoute.Adapter = this.Adapter;
            this.cmdChangeRoute.MergeReturnTarget = false;
            this.cmdChangeRoute.Method = "TappingPlanChangeRoute";
            this.cmdChangeRoute.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdChangeRoute.Parameters.Add(this.l3CommandParameter2);
            this.cmdChangeRoute.ReturnTarget = null;
            this.cmdChangeRoute.ReturnTargetProperty = null;
            this.cmdChangeRoute.Trigger = null;
            this.cmdChangeRoute.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsPlan;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'TappingPlanChangeRoute\'";
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
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
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
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // ChangeRouteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeRouteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更改工艺路径";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeRouteFrm_FormClosing);
            this.Load += new System.EventHandler(this.ChangeRouteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpRoute.ResumeLayout(false);
            this.tpRoute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemabsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLF)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPlan;
        private AppSvrHMI.L3DataSet dsPlan;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpRoute;
        private PxDataValid.PxComboBox cmbRHID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbLFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbSteelGradeIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private AppSvrHMI.L3DataSet dsLF;
        private System.Data.DataTable schemadsLF;
        private System.Data.DataColumn coldsLFL3DataTableCode;
        private System.Data.DataColumn coldsLFL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsRH;
        private System.Data.DataTable schemadsRH;
        private System.Data.DataColumn coldsRHL3DataTableCode;
        private System.Data.DataColumn coldsRHL3DataTableCode_Des;
        private System.Data.DataTable schemadsPlan;
        private System.Data.DataColumn coldsPlanL3DataTableGUID;
        private System.Data.DataColumn coldsPlanL3DataTableNAME;
        private System.Data.DataColumn coldsPlanL3DataTablePLANID;
        private System.Data.DataColumn coldsPlanL3DataTableCONTRACTID;
        private System.Data.DataColumn coldsPlanL3DataTableSTATUS;
        private System.Data.DataColumn coldsPlanL3DataTablePLANDEPT;
        private System.Data.DataColumn coldsPlanL3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coldsPlanL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsPlanL3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coldsPlanL3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coldsPlanL3DataTablePLANNER;
        private System.Data.DataColumn coldsPlanL3DataTablePRE_LOTNO;
        private System.Data.DataColumn coldsPlanL3DataTablePREHEATID;
        private System.Data.DataColumn coldsPlanL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsPlanL3DataTablePRE_STEELGRADE;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TAPPED_WEIGHT;
        private System.Data.DataColumn coldsPlanL3DataTableCASTERID;
        private System.Data.DataColumn coldsPlanL3DataTableBOFID;
        private System.Data.DataColumn coldsPlanL3DataTableLFID;
        private System.Data.DataColumn coldsPlanL3DataTableRHID;
        private System.Data.DataColumn coldsPlanL3DataTableBOF_STATUS;
        private System.Data.DataColumn coldsPlanL3DataTableLF_STATUS;
        private System.Data.DataColumn coldsPlanL3DataTableRH_STATUS;
        private System.Data.DataColumn coldsPlanL3DataTableCASTER_STATUS;
        private System.Data.DataColumn coldsPlanL3DataTableSIDE_STATUS;
        private System.Data.DataColumn coldsPlanL3DataTableHEATID;
        private System.Data.DataColumn coldsPlanL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsPlanL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_BOFSTART;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_LFARRIVAL;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_LFSTART;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_LFEND;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_LFLEAVE;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_RHARRIVAL;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_RHSTART;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_RHEND;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_RHLEAVE;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsPlanL3DataTableAIM_TIME_CASTINGEND;
        private System.Data.DataColumn coldsPlanL3DataTableFIR_HEAT_FLAG;
        private System.Data.DataColumn coldsPlanL3DataTableDIV_HEATID;
        private System.Data.DataColumn coldsPlanL3DataTableTEAMID;
        private System.Data.DataColumn coldsPlanL3DataTableSHIFTID;
        private System.Data.DataColumn coldsPlanL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsPlanL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsPlanL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsPlanL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsPlanL3DataTableSTEEL_RETURN_FLAG;
        private System.Data.DataColumn coldsPlanL3DataTableSTEEL_BACK_FLAG;
        private System.Data.DataColumn coldsPlanL3DataTableTREAT_SEQ;
        private System.Data.DataColumn coldsPlanL3DataTableDESTITATION;
        private System.Data.DataColumn coldsPlanL3DataTableNEW_BOF_FLAG;
        private AppSvrHMI.L3DataSet dsBOF;
        private AppSvrHMI.L3DataSet dsCaster;
        private PxDataValid.PxComboBox cmbCaster;
        private PxDataValid.PxComboBox cmbBOF;
        private System.Data.DataTable schemadsBOF;
        private System.Data.DataColumn coldsBOFL3DataTableCode;
        private System.Data.DataColumn coldsBOFL3DataTableCode_Des;
        private System.Data.DataTable schemabsCaster;
        private System.Data.DataColumn colbsCasterL3DataTableCode;
        private System.Data.DataColumn colbsCasterL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3Command cmdChangeRoute;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
    }
}