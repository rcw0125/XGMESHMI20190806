namespace EquipMag.LadleMag
{
    partial class LadlePlanMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadlePlanMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsLadlePlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadlePlan = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdLadlePlan = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.txtBOFID = new System.Windows.Forms.ToolStripTextBox();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.txtCastID = new System.Windows.Forms.ToolStripTextBox();
            this.schemadsLadlePlan = new System.Data.DataTable();
            this.coldsLadlePlanL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableNAME = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableUNITID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableLADLE_AGE = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsLadlePlanL3DataTableCheckFlag = new System.Data.DataColumn();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.l3txtRH1 = new AppSvrHMI.L3DataBox();
            this.l3txtLF3 = new AppSvrHMI.L3DataBox();
            this.l3txtLF2 = new AppSvrHMI.L3DataBox();
            this.l3txtLF1 = new AppSvrHMI.L3DataBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.bnLadlePlan = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbBOFID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnSpecify = new System.Windows.Forms.ToolStripButton();
            this.btnCancelSpecify = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvLadlePlan = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEWBOFFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnChooseLadle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFold = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPour = new System.Windows.Forms.ToolStripMenuItem();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdSpecify = new AppSvrHMI.L3Command(this.components);
            this.l3cpSpecify = new AppSvrHMI.L3CommandParameter();
            this.cmdCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadlePlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadlePlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadlePlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLadlePlan)).BeginInit();
            this.bnLadlePlan.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadlePlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsLadlePlan
            // 
            this.bsLadlePlan.DataMember = "L3DataTable";
            this.bsLadlePlan.DataSource = this.dsLadlePlan;
            // 
            // dsLadlePlan
            // 
            this.dsLadlePlan.AutoLoad = true;
            this.dsLadlePlan.AutoSubscribe = true;
            this.dsLadlePlan.DataSetName = "L3DataSet";
            this.dsLadlePlan.DeleteMethod = "";
            this.dsLadlePlan.InsertMethod = "";
            this.dsLadlePlan.L3DataAdapter = this.Adapter;
            this.dsLadlePlan.LoadEvent = "";
            this.dsLadlePlan.LoadTrigger = null;
            this.dsLadlePlan.RefreshValve = 1000;
            this.dsLadlePlan.SourceCommand = this.cmdLadlePlan;
            this.dsLadlePlan.SourceCondition = null;
            this.dsLadlePlan.SourceMethod = "";
            this.dsLadlePlan.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsLadlePlan.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsLadlePlan.SubscribeTarget = null;
            this.dsLadlePlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadlePlan});
            this.dsLadlePlan.UpdateEvent = "Click";
            this.dsLadlePlan.UpdateMethod = "";
            this.dsLadlePlan.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdLadlePlan
            // 
            this.cmdLadlePlan.Adapter = null;
            this.cmdLadlePlan.MergeReturnTarget = false;
            this.cmdLadlePlan.Method = null;
            this.cmdLadlePlan.Object = null;
            this.cmdLadlePlan.Parameters.Add(this.l3CommandParameter1);
            this.cmdLadlePlan.Parameters.Add(this.l3CommandParameter2);
            this.cmdLadlePlan.ReturnTarget = null;
            this.cmdLadlePlan.ReturnTargetProperty = null;
            this.cmdLadlePlan.Trigger = null;
            this.cmdLadlePlan.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.txtBOFID;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // txtBOFID
            // 
            this.txtBOFID.Name = "txtBOFID";
            this.txtBOFID.Size = new System.Drawing.Size(10, 25);
            this.txtBOFID.Visible = false;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.txtCastID;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // txtCastID
            // 
            this.txtCastID.Name = "txtCastID";
            this.txtCastID.Size = new System.Drawing.Size(10, 25);
            this.txtCastID.Visible = false;
            // 
            // schemadsLadlePlan
            // 
            this.schemadsLadlePlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadlePlanL3DataTableGUID,
            this.coldsLadlePlanL3DataTableNAME,
            this.coldsLadlePlanL3DataTablePLANID,
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX,
            this.coldsLadlePlanL3DataTableCREATEDATE,
            this.coldsLadlePlanL3DataTableHEATID,
            this.coldsLadlePlanL3DataTableCASTERID,
            this.coldsLadlePlanL3DataTableUNITID,
            this.coldsLadlePlanL3DataTableLADLEID,
            this.coldsLadlePlanL3DataTableLADLE_AGE,
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG,
            this.coldsLadlePlanL3DataTableSTATUS,
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED,
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART,
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED,
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND,
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL,
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART,
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND,
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE,
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL,
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART,
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND,
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE,
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL,
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART,
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND,
            this.coldsLadlePlanL3DataTableTEAMID,
            this.coldsLadlePlanL3DataTableSHIFTID,
            this.coldsLadlePlanL3DataTableOPERATOR,
            this.coldsLadlePlanL3DataTableNOTE,
            this.coldsLadlePlanL3DataTableCheckFlag});
            this.schemadsLadlePlan.TableName = "L3DataTable";
            // 
            // coldsLadlePlanL3DataTableGUID
            // 
            this.coldsLadlePlanL3DataTableGUID.Caption = "GUID";
            this.coldsLadlePlanL3DataTableGUID.ColumnName = "GUID";
            this.coldsLadlePlanL3DataTableGUID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableGUID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableNAME
            // 
            this.coldsLadlePlanL3DataTableNAME.Caption = "NAME";
            this.coldsLadlePlanL3DataTableNAME.ColumnName = "NAME";
            this.coldsLadlePlanL3DataTableNAME.DefaultValue = "";
            this.coldsLadlePlanL3DataTableNAME.Namespace = "";
            // 
            // coldsLadlePlanL3DataTablePLANID
            // 
            this.coldsLadlePlanL3DataTablePLANID.Caption = "PLANID";
            this.coldsLadlePlanL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsLadlePlanL3DataTablePLANID.DefaultValue = "";
            this.coldsLadlePlanL3DataTablePLANID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableSTEELGRADEINDEX
            // 
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsLadlePlanL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableCREATEDATE
            // 
            this.coldsLadlePlanL3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coldsLadlePlanL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsLadlePlanL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableHEATID
            // 
            this.coldsLadlePlanL3DataTableHEATID.Caption = "HEATID";
            this.coldsLadlePlanL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsLadlePlanL3DataTableHEATID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableHEATID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableCASTERID
            // 
            this.coldsLadlePlanL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsLadlePlanL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsLadlePlanL3DataTableCASTERID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableCASTERID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableUNITID
            // 
            this.coldsLadlePlanL3DataTableUNITID.Caption = "UNITID";
            this.coldsLadlePlanL3DataTableUNITID.ColumnName = "UNITID";
            this.coldsLadlePlanL3DataTableUNITID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableUNITID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableLADLEID
            // 
            this.coldsLadlePlanL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsLadlePlanL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsLadlePlanL3DataTableLADLEID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableLADLEID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableLADLE_AGE
            // 
            this.coldsLadlePlanL3DataTableLADLE_AGE.Caption = "LADLE_AGE";
            this.coldsLadlePlanL3DataTableLADLE_AGE.ColumnName = "LADLE_AGE";
            this.coldsLadlePlanL3DataTableLADLE_AGE.DataType = typeof(int);
            this.coldsLadlePlanL3DataTableLADLE_AGE.DefaultValue = 0;
            this.coldsLadlePlanL3DataTableLADLE_AGE.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableNEW_BOF_FLAG
            // 
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsLadlePlanL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableSTATUS
            // 
            this.coldsLadlePlanL3DataTableSTATUS.Caption = "STATUS";
            this.coldsLadlePlanL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsLadlePlanL3DataTableSTATUS.DefaultValue = "";
            this.coldsLadlePlanL3DataTableSTATUS.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED.Caption = "ACT_TIME_IRONPREPARED";
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED.ColumnName = "ACT_TIME_IRONPREPARED";
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_BOFSTART
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART.Caption = "ACT_TIME_BOFSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART.ColumnName = "ACT_TIME_BOFSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_BOFSTART.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED.Caption = "ACT_TIME_BOFTAPPED";
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED.ColumnName = "ACT_TIME_BOFTAPPED";
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND.Caption = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND.ColumnName = "ACT_TIME_TAPPEDSIDEEND";
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL.Caption = "ACT_TIME_LFARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL.ColumnName = "ACT_TIME_LFARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_LFSTART
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART.Caption = "ACT_TIME_LFSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART.ColumnName = "ACT_TIME_LFSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_LFSTART.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_LFEND
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND.Caption = "ACT_TIME_LFEND";
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND.ColumnName = "ACT_TIME_LFEND";
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_LFEND.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_LFLEAVE
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE.Caption = "ACT_TIME_LFLEAVE";
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE.ColumnName = "ACT_TIME_LFLEAVE";
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_LFLEAVE.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL.Caption = "ACT_TIME_RHARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL.ColumnName = "ACT_TIME_RHARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_RHSTART
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART.Caption = "ACT_TIME_RHSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART.ColumnName = "ACT_TIME_RHSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_RHSTART.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_RHEND
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND.Caption = "ACT_TIME_RHEND";
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND.ColumnName = "ACT_TIME_RHEND";
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_RHEND.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_RHLEAVE
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE.Caption = "ACT_TIME_RHLEAVE";
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE.ColumnName = "ACT_TIME_RHLEAVE";
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_RHLEAVE.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL.Caption = "ACT_TIME_CASTERARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL.ColumnName = "ACT_TIME_CASTERARRIVAL";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART.Caption = "ACT_TIME_CASTINGSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART.ColumnName = "ACT_TIME_CASTINGSTART";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableACT_TIME_CASTINGEND
            // 
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND.Caption = "ACT_TIME_CASTINGEND";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND.ColumnName = "ACT_TIME_CASTINGEND";
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND.DataType = typeof(System.DateTime);
            this.coldsLadlePlanL3DataTableACT_TIME_CASTINGEND.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableTEAMID
            // 
            this.coldsLadlePlanL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsLadlePlanL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsLadlePlanL3DataTableTEAMID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableTEAMID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableSHIFTID
            // 
            this.coldsLadlePlanL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsLadlePlanL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsLadlePlanL3DataTableSHIFTID.DefaultValue = "";
            this.coldsLadlePlanL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableOPERATOR
            // 
            this.coldsLadlePlanL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsLadlePlanL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsLadlePlanL3DataTableOPERATOR.DefaultValue = "";
            this.coldsLadlePlanL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableNOTE
            // 
            this.coldsLadlePlanL3DataTableNOTE.Caption = "NOTE";
            this.coldsLadlePlanL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsLadlePlanL3DataTableNOTE.DefaultValue = "";
            this.coldsLadlePlanL3DataTableNOTE.Namespace = "";
            // 
            // coldsLadlePlanL3DataTableCheckFlag
            // 
            this.coldsLadlePlanL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsLadlePlanL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsLadlePlanL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsLadlePlanL3DataTableCheckFlag.Namespace = "";
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
            this.dsShiftID.SourceCondition = null;
            this.dsShiftID.SourceMethod = null;
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsShiftID.SourceURI = null;
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
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
            this.dsTeamID.SourceCondition = null;
            this.dsTeamID.SourceMethod = null;
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTeamID.SourceURI = null;
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.groupBox1, 0, 2);
            this.tbLPM.Controls.Add(this.bnLadlePlan, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 3);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 4;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Controls.Add(this.l3txtRH1);
            this.groupBox1.Controls.Add(this.l3txtLF3);
            this.groupBox1.Controls.Add(this.l3txtLF2);
            this.groupBox1.Controls.Add(this.l3txtLF1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1000, 76);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "监控";
            // 
            // l3txtCaster5
            // 
            this.l3txtCaster5.DataFormat = null;
            this.l3txtCaster5.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\S65";
            this.l3txtCaster5.DataProperty = "HeatID";
            this.l3txtCaster5.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtCaster5.L3DataAdapter = this.Adapter;
            this.l3txtCaster5.Location = new System.Drawing.Point(868, 17);
            this.l3txtCaster5.Name = "l3txtCaster5";
            this.l3txtCaster5.ReadOnly = true;
            this.l3txtCaster5.Size = new System.Drawing.Size(72, 21);
            this.l3txtCaster5.TabIndex = 12;
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
            this.l3txtCaster4.Location = new System.Drawing.Point(743, 46);
            this.l3txtCaster4.Name = "l3txtCaster4";
            this.l3txtCaster4.ReadOnly = true;
            this.l3txtCaster4.Size = new System.Drawing.Size(72, 21);
            this.l3txtCaster4.TabIndex = 11;
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
            this.l3txtCaster3.Location = new System.Drawing.Point(743, 17);
            this.l3txtCaster3.Name = "l3txtCaster3";
            this.l3txtCaster3.ReadOnly = true;
            this.l3txtCaster3.Size = new System.Drawing.Size(72, 21);
            this.l3txtCaster3.TabIndex = 10;
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
            this.l3txtCaster2.Location = new System.Drawing.Point(615, 46);
            this.l3txtCaster2.Name = "l3txtCaster2";
            this.l3txtCaster2.ReadOnly = true;
            this.l3txtCaster2.Size = new System.Drawing.Size(72, 21);
            this.l3txtCaster2.TabIndex = 9;
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
            this.l3txtCaster1.Location = new System.Drawing.Point(615, 17);
            this.l3txtCaster1.Name = "l3txtCaster1";
            this.l3txtCaster1.ReadOnly = true;
            this.l3txtCaster1.Size = new System.Drawing.Size(72, 21);
            this.l3txtCaster1.TabIndex = 8;
            this.l3txtCaster1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtCaster1.Value = null;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(819, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "5#铸机:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(694, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 0;
            this.label20.Text = "4#铸机:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(694, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "3#铸机:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(560, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "2#铸机:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(560, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "1#铸机:";
            // 
            // l3txtRH1
            // 
            this.l3txtRH1.DataFormat = null;
            this.l3txtRH1.DataObject = "XGMESLogic\\RHMag\\CRH_Unit_Mag\\S51";
            this.l3txtRH1.DataProperty = "HeatID";
            this.l3txtRH1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtRH1.L3DataAdapter = this.Adapter;
            this.l3txtRH1.Location = new System.Drawing.Point(470, 46);
            this.l3txtRH1.Name = "l3txtRH1";
            this.l3txtRH1.ReadOnly = true;
            this.l3txtRH1.Size = new System.Drawing.Size(72, 21);
            this.l3txtRH1.TabIndex = 7;
            this.l3txtRH1.Tag = "";
            this.l3txtRH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtRH1.Value = null;
            // 
            // l3txtLF3
            // 
            this.l3txtLF3.DataFormat = null;
            this.l3txtLF3.DataObject = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S43";
            this.l3txtLF3.DataProperty = "HeatID";
            this.l3txtLF3.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF3.L3DataAdapter = this.Adapter;
            this.l3txtLF3.Location = new System.Drawing.Point(470, 17);
            this.l3txtLF3.Name = "l3txtLF3";
            this.l3txtLF3.ReadOnly = true;
            this.l3txtLF3.Size = new System.Drawing.Size(72, 21);
            this.l3txtLF3.TabIndex = 6;
            this.l3txtLF3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF3.Value = null;
            // 
            // l3txtLF2
            // 
            this.l3txtLF2.DataFormat = null;
            this.l3txtLF2.DataObject = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S42";
            this.l3txtLF2.DataProperty = "HeatID";
            this.l3txtLF2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF2.L3DataAdapter = this.Adapter;
            this.l3txtLF2.Location = new System.Drawing.Point(341, 46);
            this.l3txtLF2.Name = "l3txtLF2";
            this.l3txtLF2.ReadOnly = true;
            this.l3txtLF2.Size = new System.Drawing.Size(72, 21);
            this.l3txtLF2.TabIndex = 5;
            this.l3txtLF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF2.Value = null;
            // 
            // l3txtLF1
            // 
            this.l3txtLF1.DataFormat = null;
            this.l3txtLF1.DataObject = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\S41";
            this.l3txtLF1.DataProperty = "HeatID";
            this.l3txtLF1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtLF1.L3DataAdapter = this.Adapter;
            this.l3txtLF1.Location = new System.Drawing.Point(341, 17);
            this.l3txtLF1.Name = "l3txtLF1";
            this.l3txtLF1.ReadOnly = true;
            this.l3txtLF1.Size = new System.Drawing.Size(72, 21);
            this.l3txtLF1.TabIndex = 4;
            this.l3txtLF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtLF1.Value = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(421, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "1#RH:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "3#LF:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "2#LF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "1#LF:";
            // 
            // l3txtBOF4
            // 
            this.l3txtBOF4.DataFormat = null;
            this.l3txtBOF4.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S24";
            this.l3txtBOF4.DataProperty = "HeatID";
            this.l3txtBOF4.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtBOF4.L3DataAdapter = this.Adapter;
            this.l3txtBOF4.Location = new System.Drawing.Point(197, 46);
            this.l3txtBOF4.Name = "l3txtBOF4";
            this.l3txtBOF4.ReadOnly = true;
            this.l3txtBOF4.Size = new System.Drawing.Size(72, 21);
            this.l3txtBOF4.TabIndex = 3;
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
            this.l3txtBOF3.Location = new System.Drawing.Point(197, 17);
            this.l3txtBOF3.Name = "l3txtBOF3";
            this.l3txtBOF3.ReadOnly = true;
            this.l3txtBOF3.Size = new System.Drawing.Size(72, 21);
            this.l3txtBOF3.TabIndex = 2;
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
            this.l3txtBOF2.Location = new System.Drawing.Point(67, 46);
            this.l3txtBOF2.Name = "l3txtBOF2";
            this.l3txtBOF2.ReadOnly = true;
            this.l3txtBOF2.Size = new System.Drawing.Size(72, 21);
            this.l3txtBOF2.TabIndex = 1;
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
            this.l3txtBOF1.Location = new System.Drawing.Point(67, 17);
            this.l3txtBOF1.Name = "l3txtBOF1";
            this.l3txtBOF1.ReadOnly = true;
            this.l3txtBOF1.Size = new System.Drawing.Size(72, 21);
            this.l3txtBOF1.TabIndex = 0;
            this.l3txtBOF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l3txtBOF1.Value = null;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "4#转炉:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "3#转炉:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "2#转炉:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1#转炉:";
            // 
            // bnLadlePlan
            // 
            this.bnLadlePlan.AddNewItem = null;
            this.bnLadlePlan.AutoSize = false;
            this.bnLadlePlan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnLadlePlan.BackgroundImage")));
            this.bnLadlePlan.BindingSource = this.bsLadlePlan;
            this.bnLadlePlan.CountItem = this.bindingNavigatorCountItem;
            this.bnLadlePlan.DeleteItem = null;
            this.bnLadlePlan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.tscmbCasterID,
            this.toolStripLabel4,
            this.tscmbBOFID,
            this.toolStripLabel2,
            this.txtBOFID,
            this.txtCastID});
            this.bnLadlePlan.Location = new System.Drawing.Point(0, 43);
            this.bnLadlePlan.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnLadlePlan.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnLadlePlan.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnLadlePlan.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnLadlePlan.Name = "bnLadlePlan";
            this.bnLadlePlan.PositionItem = this.bindingNavigatorPositionItem;
            this.bnLadlePlan.Size = new System.Drawing.Size(1000, 25);
            this.bnLadlePlan.TabIndex = 1;
            this.bnLadlePlan.Text = "bindingNavigator1";
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
            // tscmbCasterID
            // 
            this.tscmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbCasterID.Name = "tscmbCasterID";
            this.tscmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.tscmbCasterID.DropDownClosed += new System.EventHandler(this.tscmbCasterID_DropDownClosed);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "铸机:";
            // 
            // tscmbBOFID
            // 
            this.tscmbBOFID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbBOFID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbBOFID.Name = "tscmbBOFID";
            this.tscmbBOFID.Size = new System.Drawing.Size(121, 25);
            this.tscmbBOFID.DropDownClosed += new System.EventHandler(this.tscmbBOFID_DropDownClosed);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "炉座:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnSpecify,
            this.btnCancelSpecify});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 0;
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
            // btnSpecify
            // 
            this.btnSpecify.Image = ((System.Drawing.Image)(resources.GetObject("btnSpecify.Image")));
            this.btnSpecify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSpecify.Name = "btnSpecify";
            this.btnSpecify.Size = new System.Drawing.Size(89, 40);
            this.btnSpecify.Text = "指定钢包";
            this.btnSpecify.Click += new System.EventHandler(this.btnSpecify_Click);
            // 
            // btnCancelSpecify
            // 
            this.btnCancelSpecify.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelSpecify.Image")));
            this.btnCancelSpecify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelSpecify.Name = "btnCancelSpecify";
            this.btnCancelSpecify.Size = new System.Drawing.Size(89, 40);
            this.btnCancelSpecify.Text = "取消指定";
            this.btnCancelSpecify.Click += new System.EventHandler(this.btnCancelSpecify_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvLadlePlan);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 147);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(994, 550);
            this.hmiRootPanel1.TabIndex = 32;
            // 
            // dvLadlePlan
            // 
            this.dvLadlePlan.AllowUserToAddRows = false;
            this.dvLadlePlan.AutoGenerateColumns = false;
            this.dvLadlePlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvLadlePlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvLadlePlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.pLANIDDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.uNITIDDataGridViewTextBoxColumn,
            this.lADLEAGEDataGridViewTextBoxColumn,
            this.nEWBOFFLAGDataGridViewTextBoxColumn,
            this.STATUS,
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn,
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn,
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn,
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn,
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn,
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn,
            this.aCTTIMELFENDDataGridViewTextBoxColumn,
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn,
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn,
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn,
            this.aCTTIMERHENDDataGridViewTextBoxColumn,
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn,
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn,
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn,
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvLadlePlan.ContextMenuStrip = this.contextMenuStrip1;
            this.dvLadlePlan.DataSource = this.bsLadlePlan;
            this.dvLadlePlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLadlePlan.Location = new System.Drawing.Point(0, 0);
            this.dvLadlePlan.Margin = new System.Windows.Forms.Padding(0);
            this.dvLadlePlan.MultiSelect = false;
            this.dvLadlePlan.Name = "dvLadlePlan";
            this.dvLadlePlan.RowTemplate.Height = 23;
            this.dvLadlePlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvLadlePlan.Size = new System.Drawing.Size(994, 550);
            this.dvLadlePlan.TabIndex = 31;
            this.dvLadlePlan.VirtualMode = true;
            this.dvLadlePlan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dvLadlePlan_RowPrePaint);
            this.dvLadlePlan.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dvLadlePlan_CellContextMenuStripNeeded);
            this.dvLadlePlan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvLadlePlan_DataError);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = false;
            this.checkFlagDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.Frozen = true;
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn.Width = 54;
            // 
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.pLANIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pLANIDDataGridViewTextBoxColumn.Frozen = true;
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "计划号";
            this.pLANIDDataGridViewTextBoxColumn.Name = "pLANIDDataGridViewTextBoxColumn";
            this.pLANIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pLANIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.DataSource = this.dsLadleID;
            this.lADLEIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.lADLEIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lADLEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lADLEIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.lADLEIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
            this.dsLadleID.AutoSubscribe = true;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "Code_Group = \'Ladle\' order by Code";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleID.SubscribeTarget = null;
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableCode,
            this.coldsLadleIDL3DataTableCode_Des});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableCode
            // 
            this.coldsLadleIDL3DataTableCode.Caption = "Code";
            this.coldsLadleIDL3DataTableCode.ColumnName = "Code";
            this.coldsLadleIDL3DataTableCode.Namespace = "";
            // 
            // coldsLadleIDL3DataTableCode_Des
            // 
            this.coldsLadleIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleIDL3DataTableCode_Des.Namespace = "";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Width = 120;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDATEDataGridViewTextBoxColumn.Width = 90;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTERIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // uNITIDDataGridViewTextBoxColumn
            // 
            this.uNITIDDataGridViewTextBoxColumn.DataPropertyName = "UNITID";
            this.uNITIDDataGridViewTextBoxColumn.HeaderText = "UNITID";
            this.uNITIDDataGridViewTextBoxColumn.Name = "uNITIDDataGridViewTextBoxColumn";
            this.uNITIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNITIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // lADLEAGEDataGridViewTextBoxColumn
            // 
            this.lADLEAGEDataGridViewTextBoxColumn.DataPropertyName = "LADLE_AGE";
            this.lADLEAGEDataGridViewTextBoxColumn.HeaderText = "LADLE_AGE";
            this.lADLEAGEDataGridViewTextBoxColumn.Name = "lADLEAGEDataGridViewTextBoxColumn";
            this.lADLEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEAGEDataGridViewTextBoxColumn.Width = 84;
            // 
            // nEWBOFFLAGDataGridViewTextBoxColumn
            // 
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataPropertyName = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.HeaderText = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Name = "nEWBOFFLAGDataGridViewTextBoxColumn";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Width = 102;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 66;
            // 
            // aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn
            // 
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_IRONPREPARED";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_IRONPREPARED";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.Name = "aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn";
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn.Width = 156;
            // 
            // aCTTIMEBOFSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_BOFSTART";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_BOFSTART";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.Name = "aCTTIMEBOFSTARTDataGridViewTextBoxColumn";
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMEBOFSTARTDataGridViewTextBoxColumn.Width = 132;
            // 
            // aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn
            // 
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_BOFTAPPED";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_BOFTAPPED";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.Name = "aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn";
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn.Width = 138;
            // 
            // aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_TAPPEDSIDEEND";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_TAPPEDSIDEEND";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.Name = "aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn";
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn.Width = 162;
            // 
            // aCTTIMELFARRIVALDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFARRIVAL";
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_LFARRIVAL";
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn.Name = "aCTTIMELFARRIVALDataGridViewTextBoxColumn";
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMELFARRIVALDataGridViewTextBoxColumn.Width = 138;
            // 
            // aCTTIMELFSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFSTART";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_LFSTART";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.Name = "aCTTIMELFSTARTDataGridViewTextBoxColumn";
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMELFSTARTDataGridViewTextBoxColumn.Width = 126;
            // 
            // aCTTIMELFENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFEND";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_LFEND";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.Name = "aCTTIMELFENDDataGridViewTextBoxColumn";
            this.aCTTIMELFENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMELFENDDataGridViewTextBoxColumn.Width = 114;
            // 
            // aCTTIMELFLEAVEDataGridViewTextBoxColumn
            // 
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_LFLEAVE";
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_LFLEAVE";
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn.Name = "aCTTIMELFLEAVEDataGridViewTextBoxColumn";
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMELFLEAVEDataGridViewTextBoxColumn.Width = 126;
            // 
            // aCTTIMERHARRIVALDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHARRIVAL";
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_RHARRIVAL";
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn.Name = "aCTTIMERHARRIVALDataGridViewTextBoxColumn";
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMERHARRIVALDataGridViewTextBoxColumn.Width = 138;
            // 
            // aCTTIMERHSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHSTART";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_RHSTART";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.Name = "aCTTIMERHSTARTDataGridViewTextBoxColumn";
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMERHSTARTDataGridViewTextBoxColumn.Width = 126;
            // 
            // aCTTIMERHENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHEND";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_RHEND";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.Name = "aCTTIMERHENDDataGridViewTextBoxColumn";
            this.aCTTIMERHENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMERHENDDataGridViewTextBoxColumn.Width = 114;
            // 
            // aCTTIMERHLEAVEDataGridViewTextBoxColumn
            // 
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_RHLEAVE";
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_RHLEAVE";
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn.Name = "aCTTIMERHLEAVEDataGridViewTextBoxColumn";
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMERHLEAVEDataGridViewTextBoxColumn.Width = 126;
            // 
            // aCTTIMECASTERARRIVALDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTERARRIVAL";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_CASTERARRIVAL";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.Name = "aCTTIMECASTERARRIVALDataGridViewTextBoxColumn";
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMECASTERARRIVALDataGridViewTextBoxColumn.Width = 162;
            // 
            // aCTTIMECASTINGSTARTDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTINGSTART";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_CASTINGSTART";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.Name = "aCTTIMECASTINGSTARTDataGridViewTextBoxColumn";
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMECASTINGSTARTDataGridViewTextBoxColumn.Width = 156;
            // 
            // aCTTIMECASTINGENDDataGridViewTextBoxColumn
            // 
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.DataPropertyName = "ACT_TIME_CASTINGEND";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.HeaderText = "ACT_TIME_CASTINGEND";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.Name = "aCTTIMECASTINGENDDataGridViewTextBoxColumn";
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTTIMECASTINGENDDataGridViewTextBoxColumn.Width = 144;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 72;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 78;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChooseLadle,
            this.btnFold,
            this.btnPour});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 70);
            // 
            // btnChooseLadle
            // 
            this.btnChooseLadle.Name = "btnChooseLadle";
            this.btnChooseLadle.Size = new System.Drawing.Size(142, 22);
            this.btnChooseLadle.Text = "选择指定钢包";
            this.btnChooseLadle.Click += new System.EventHandler(this.btnChooseLadle_Click);
            // 
            // btnFold
            // 
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(142, 22);
            this.btnFold.Text = "钢包折罐";
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // btnPour
            // 
            this.btnPour.Name = "btnPour";
            this.btnPour.Size = new System.Drawing.Size(142, 22);
            this.btnPour.Text = "钢包倒包";
            this.btnPour.Click += new System.EventHandler(this.btnPour_Click);
            // 
            // dsBOFID
            // 
            this.dsBOFID.AutoLoad = true;
            this.dsBOFID.AutoSubscribe = true;
            this.dsBOFID.DataSetName = "L3DataSet";
            this.dsBOFID.DeleteMethod = null;
            this.dsBOFID.InsertMethod = null;
            this.dsBOFID.L3DataAdapter = this.Adapter;
            this.dsBOFID.LoadEvent = "Click";
            this.dsBOFID.LoadTrigger = null;
            this.dsBOFID.RefreshValve = 1000;
            this.dsBOFID.SourceCommand = null;
            this.dsBOFID.SourceCondition = "Code_Group = \'BOF\'";
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
            this.dsCasterID.AutoSubscribe = true;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\'";
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
            // cmdSpecify
            // 
            this.cmdSpecify.Adapter = this.Adapter;
            this.cmdSpecify.MergeReturnTarget = false;
            this.cmdSpecify.Method = "SpecifyLadle";
            this.cmdSpecify.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdSpecify.Parameters.Add(this.l3cpSpecify);
            this.cmdSpecify.ReturnTarget = null;
            this.cmdSpecify.ReturnTargetProperty = null;
            this.cmdSpecify.Trigger = null;
            this.cmdSpecify.TriggerEvent = "Click";
            // 
            // l3cpSpecify
            // 
            this.l3cpSpecify.AcceptAfterExecuted = false;
            this.l3cpSpecify.ConstantValue = null;
            this.l3cpSpecify.MergeTarget = false;
            this.l3cpSpecify.SourceFilter = "CheckFlag = 1 and Status = \'01\' and LadleID is not null";
            this.l3cpSpecify.SourceObject = this.dsLadlePlan;
            this.l3cpSpecify.SourceProperty = "L3DataTable";
            this.l3cpSpecify.TargetObject = null;
            this.l3cpSpecify.TargetProperty = null;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Adapter = this.Adapter;
            this.cmdCancel.MergeReturnTarget = false;
            this.cmdCancel.Method = "CancelSpecifyLadle";
            this.cmdCancel.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdCancel.Parameters.Add(this.l3CommandParameter3);
            this.cmdCancel.ReturnTarget = null;
            this.cmdCancel.ReturnTargetProperty = null;
            this.cmdCancel.Trigger = null;
            this.cmdCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = "CheckFlag = 1 and Status = \'02\'";
            this.l3CommandParameter3.SourceObject = this.dsLadlePlan;
            this.l3CommandParameter3.SourceProperty = "L3DataTable";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // LadlePlanMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LadlePlanMagFrm";
            this.TabText = "钢包计划管理";
            this.Text = "钢包计划管理";
            this.Load += new System.EventHandler(this.LadlePlanMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLadlePlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadlePlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadlePlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLadlePlan)).EndInit();
            this.bnLadlePlan.ResumeLayout(false);
            this.bnLadlePlan.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvLadlePlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsLadlePlan;
        private System.Windows.Forms.BindingSource bsLadlePlan;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnLadlePlan;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnPour;
        private System.Windows.Forms.ToolStripMenuItem btnFold;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox tscmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox tscmbBOFID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsBOFID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataBox l3txtRH1;
        private AppSvrHMI.L3DataBox l3txtCaster5;
        private AppSvrHMI.L3DataBox l3txtCaster4;
        private AppSvrHMI.L3DataBox l3txtLF3;
        private AppSvrHMI.L3DataBox l3txtCaster3;
        private AppSvrHMI.L3DataBox l3txtLF2;
        private AppSvrHMI.L3DataBox l3txtCaster2;
        private AppSvrHMI.L3DataBox l3txtBOF4;
        private AppSvrHMI.L3DataBox l3txtCaster1;
        private AppSvrHMI.L3DataBox l3txtBOF3;
        private AppSvrHMI.L3DataBox l3txtLF1;
        private AppSvrHMI.L3DataBox l3txtBOF2;
        private AppSvrHMI.L3DataBox l3txtBOF1;
        private AppSvrHMI.L3Command cmdLadlePlan;
        private System.Data.DataTable schemadsLadlePlan;
        private System.Data.DataColumn coldsLadlePlanL3DataTableGUID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableNAME;
        private System.Data.DataColumn coldsLadlePlanL3DataTablePLANID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsLadlePlanL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsLadlePlanL3DataTableHEATID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableCASTERID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableUNITID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableLADLEID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableLADLE_AGE;
        private System.Data.DataColumn coldsLadlePlanL3DataTableNEW_BOF_FLAG;
        private System.Data.DataColumn coldsLadlePlanL3DataTableSTATUS;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_IRONPREPARED;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_BOFSTART;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_BOFTAPPED;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_TAPPEDSIDEEND;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_LFARRIVAL;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_LFSTART;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_LFEND;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_LFLEAVE;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_RHARRIVAL;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_RHSTART;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_RHEND;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_RHLEAVE;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_CASTERARRIVAL;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsLadlePlanL3DataTableACT_TIME_CASTINGEND;
        private System.Data.DataColumn coldsLadlePlanL3DataTableTEAMID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableSHIFTID;
        private System.Data.DataColumn coldsLadlePlanL3DataTableOPERATOR;
        private System.Data.DataColumn coldsLadlePlanL3DataTableNOTE;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ToolStripTextBox txtBOFID;
        private System.Windows.Forms.ToolStripTextBox txtCastID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvLadlePlan;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnSpecify;
        private System.Windows.Forms.ToolStripButton btnCancelSpecify;
        private System.Data.DataColumn coldsLadlePlanL3DataTableCheckFlag;
        private AppSvrHMI.L3Command cmdSpecify;
        private AppSvrHMI.L3CommandParameter l3cpSpecify;
        private AppSvrHMI.L3Command cmdCancel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableCode;
        private System.Data.DataColumn coldsLadleIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripMenuItem btnChooseLadle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEWBOFFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEIRONPREPAREDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEBOFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMEBOFTAPPEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMETAPPEDSIDEENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMELFLEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMERHLEAVEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTERARRIVALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTINGSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTTIMECASTINGENDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}