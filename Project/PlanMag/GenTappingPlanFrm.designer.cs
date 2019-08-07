namespace PlanMag
{
    partial class GenTappingPlanFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenTappingPlanFrm));
            this.bsTapping = new System.Windows.Forms.BindingSource(this.components);
            this.dsTapping = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tsbtnQuery = new System.Windows.Forms.ToolStripLabel();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.tstdtpCreateDate = new buttonHide.ToolStripToriDateTimePicker();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
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
            this.coldsTappingL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsTappingL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsTappingL3DataTableREFINE_TYPE = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_LOTNO = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePREHEATID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePROC_SEQ = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART = new System.Data.DataColumn();
            this.coldsTappingL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSTD = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePRE_STEELGRADE = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRHID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableActWeight = new System.Data.DataColumn();
            this.coldsTappingL3DataTableProtocol = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTECH_REQUEST = new System.Data.DataColumn();
            this.coldsTappingL3DataTableProduceStd = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAODID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableMaterialCode = new System.Data.DataColumn();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnTappingAct = new System.Windows.Forms.ToolStripButton();
            this.BuSteelBtn = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTapping = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.NEW_BOF_FLAG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsNewBOFFlag = new AppSvrHMI.L3DataSet();
            this.schemadsNewBOFFlag = new System.Data.DataTable();
            this.coldsNewBOFFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsNewBOFFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.BOFID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.AODID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAODID = new AppSvrHMI.L3DataSet();
            this.schemadsAODID = new System.Data.DataTable();
            this.coldsAODIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsAODIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.LFID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLFID = new AppSvrHMI.L3DataSet();
            this.schemadsLFID = new System.Data.DataTable();
            this.coldsLFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsLFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.RHID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRHID = new AppSvrHMI.L3DataSet();
            this.schemadsRHID = new System.Data.DataTable();
            this.coldsRHIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsRHIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.REFINE_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECH_REQUEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOOMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pLANDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXECUTEDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRELOTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREHEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCSEQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextCasting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdTapping = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdCastingCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3Command1 = new AppSvrHMI.L3Command(this.components);
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.updateHeatid = new AppSvrHMI.L3Command(this.components);
            this.cmdTapping1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAODID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAODID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.contextCasting.SuspendLayout();
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
            this.dsTapping.LoadTrigger = this.tsbtnQuery;
            this.dsTapping.RefreshValve = 1000;
            this.dsTapping.SourceCommand = this.cmdQuery;
            this.dsTapping.SourceCondition = null;
            this.dsTapping.SourceMethod = "GetCastingPlan";
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
            // tsbtnQuery
            // 
            this.tsbtnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnQuery.Image")));
            this.tsbtnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnQuery.Name = "tsbtnQuery";
            this.tsbtnQuery.Size = new System.Drawing.Size(45, 22);
            this.tsbtnQuery.Text = "查询";
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = null;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "GetCastingPlan";
            this.cmdQuery.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
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
            this.l3CommandParameter1.SourceObject = this.tstdtpCreateDate;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // tstdtpCreateDate
            // 
            this.tstdtpCreateDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstdtpCreateDate.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tstdtpCreateDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tstdtpCreateDate.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tstdtpCreateDate.CustomFormat = "yyyy-MM-dd";
            this.tstdtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tstdtpCreateDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tstdtpCreateDate.MaximumSize = new System.Drawing.Size(0, 0);
            this.tstdtpCreateDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tstdtpCreateDate.MinimumSize = new System.Drawing.Size(0, 0);
            this.tstdtpCreateDate.Name = "tstdtpCreateDate";
            this.tstdtpCreateDate.Size = new System.Drawing.Size(100, 22);
            this.tstdtpCreateDate.Text = "2008-10-28";
            this.tstdtpCreateDate.Value = new System.DateTime(2008, 10, 28, 11, 28, 28, 220);
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
            this.coldsTappingL3DataTableCASTERID,
            this.coldsTappingL3DataTableLENGTH,
            this.coldsTappingL3DataTableWIDTH,
            this.coldsTappingL3DataTableTHICKNESS,
            this.coldsTappingL3DataTableREFINE_TYPE,
            this.coldsTappingL3DataTablePRE_LOTNO,
            this.coldsTappingL3DataTablePREHEATID,
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT,
            this.coldsTappingL3DataTablePROC_SEQ,
            this.coldsTappingL3DataTablePLAN_ORD_ID,
            this.coldsTappingL3DataTableBLOOM_COUNT,
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART,
            this.coldsTappingL3DataTableNEW_BOF_FLAG,
            this.coldsTappingL3DataTableSTD,
            this.coldsTappingL3DataTablePRE_STEELGRADEINDEX,
            this.coldsTappingL3DataTablePRE_STEELGRADE,
            this.coldsTappingL3DataTableCheckFlag,
            this.coldsTappingL3DataTableBOFID,
            this.coldsTappingL3DataTableLFID,
            this.coldsTappingL3DataTableRHID,
            this.coldsTappingL3DataTableActWeight,
            this.coldsTappingL3DataTableProtocol,
            this.coldsTappingL3DataTableTECH_REQUEST,
            this.coldsTappingL3DataTableProduceStd,
            this.coldsTappingL3DataTableAODID,
            this.coldsTappingL3DataTableMaterialCode});
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
            // coldsTappingL3DataTableCASTERID
            // 
            this.coldsTappingL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsTappingL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsTappingL3DataTableCASTERID.DefaultValue = "";
            this.coldsTappingL3DataTableCASTERID.Namespace = "";
            // 
            // coldsTappingL3DataTableLENGTH
            // 
            this.coldsTappingL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsTappingL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsTappingL3DataTableLENGTH.DataType = typeof(int);
            this.coldsTappingL3DataTableLENGTH.DefaultValue = 0;
            this.coldsTappingL3DataTableLENGTH.Namespace = "";
            // 
            // coldsTappingL3DataTableWIDTH
            // 
            this.coldsTappingL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsTappingL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsTappingL3DataTableWIDTH.DataType = typeof(int);
            this.coldsTappingL3DataTableWIDTH.DefaultValue = 0;
            this.coldsTappingL3DataTableWIDTH.Namespace = "";
            // 
            // coldsTappingL3DataTableTHICKNESS
            // 
            this.coldsTappingL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsTappingL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsTappingL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsTappingL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsTappingL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsTappingL3DataTableREFINE_TYPE
            // 
            this.coldsTappingL3DataTableREFINE_TYPE.Caption = "REFINE_TYPE";
            this.coldsTappingL3DataTableREFINE_TYPE.ColumnName = "REFINE_TYPE";
            this.coldsTappingL3DataTableREFINE_TYPE.DefaultValue = "";
            this.coldsTappingL3DataTableREFINE_TYPE.Namespace = "";
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
            // coldsTappingL3DataTableAIM_TAPPED_WEIGHT
            // 
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.Caption = "AIM_TAPPED_WEIGHT";
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.ColumnName = "AIM_TAPPED_WEIGHT";
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.DataType = typeof(double);
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.DefaultValue = 0;
            this.coldsTappingL3DataTableAIM_TAPPED_WEIGHT.Namespace = "";
            // 
            // coldsTappingL3DataTablePROC_SEQ
            // 
            this.coldsTappingL3DataTablePROC_SEQ.Caption = "PROC_SEQ";
            this.coldsTappingL3DataTablePROC_SEQ.ColumnName = "PROC_SEQ";
            this.coldsTappingL3DataTablePROC_SEQ.DataType = typeof(int);
            this.coldsTappingL3DataTablePROC_SEQ.DefaultValue = 0;
            this.coldsTappingL3DataTablePROC_SEQ.Namespace = "";
            // 
            // coldsTappingL3DataTablePLAN_ORD_ID
            // 
            this.coldsTappingL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsTappingL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsTappingL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsTappingL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsTappingL3DataTableBLOOM_COUNT
            // 
            this.coldsTappingL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsTappingL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsTappingL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsTappingL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsTappingL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsTappingL3DataTableAIM_TIME_CASTINGSTART
            // 
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.Caption = "AIM_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.ColumnName = "AIM_TIME_CASTINGSTART";
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAIM_TIME_CASTINGSTART.Namespace = "";
            // 
            // coldsTappingL3DataTableNEW_BOF_FLAG
            // 
            this.coldsTappingL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsTappingL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsTappingL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsTappingL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsTappingL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsTappingL3DataTableSTD
            // 
            this.coldsTappingL3DataTableSTD.Caption = "STD";
            this.coldsTappingL3DataTableSTD.ColumnName = "STD";
            this.coldsTappingL3DataTableSTD.DefaultValue = "";
            this.coldsTappingL3DataTableSTD.Namespace = "";
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
            // coldsTappingL3DataTableCheckFlag
            // 
            this.coldsTappingL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsTappingL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsTappingL3DataTableCheckFlag.DataType = typeof(int);
            this.coldsTappingL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsTappingL3DataTableBOFID
            // 
            this.coldsTappingL3DataTableBOFID.Caption = "BOFID";
            this.coldsTappingL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsTappingL3DataTableBOFID.Namespace = "";
            // 
            // coldsTappingL3DataTableLFID
            // 
            this.coldsTappingL3DataTableLFID.Caption = "LFID";
            this.coldsTappingL3DataTableLFID.ColumnName = "LFID";
            this.coldsTappingL3DataTableLFID.Namespace = "";
            // 
            // coldsTappingL3DataTableRHID
            // 
            this.coldsTappingL3DataTableRHID.Caption = "RHID";
            this.coldsTappingL3DataTableRHID.ColumnName = "RHID";
            this.coldsTappingL3DataTableRHID.Namespace = "";
            // 
            // coldsTappingL3DataTableActWeight
            // 
            this.coldsTappingL3DataTableActWeight.Caption = "ActWeight";
            this.coldsTappingL3DataTableActWeight.ColumnName = "ActWeight";
            this.coldsTappingL3DataTableActWeight.DataType = typeof(double);
            this.coldsTappingL3DataTableActWeight.Namespace = "";
            // 
            // coldsTappingL3DataTableProtocol
            // 
            this.coldsTappingL3DataTableProtocol.Caption = "Protocol";
            this.coldsTappingL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsTappingL3DataTableProtocol.Namespace = "";
            // 
            // coldsTappingL3DataTableTECH_REQUEST
            // 
            this.coldsTappingL3DataTableTECH_REQUEST.Caption = "TECH_REQUEST";
            this.coldsTappingL3DataTableTECH_REQUEST.ColumnName = "TECH_REQUEST";
            this.coldsTappingL3DataTableTECH_REQUEST.Namespace = "";
            // 
            // coldsTappingL3DataTableProduceStd
            // 
            this.coldsTappingL3DataTableProduceStd.Caption = "ProduceStd";
            this.coldsTappingL3DataTableProduceStd.ColumnName = "ProduceStd";
            this.coldsTappingL3DataTableProduceStd.Namespace = "";
            // 
            // coldsTappingL3DataTableAODID
            // 
            this.coldsTappingL3DataTableAODID.Caption = "AODID";
            this.coldsTappingL3DataTableAODID.ColumnName = "AODID";
            this.coldsTappingL3DataTableAODID.Namespace = "";
            // 
            // coldsTappingL3DataTableMaterialCode
            // 
            this.coldsTappingL3DataTableMaterialCode.Caption = "MaterialCode";
            this.coldsTappingL3DataTableMaterialCode.ColumnName = "MaterialCode";
            this.coldsTappingL3DataTableMaterialCode.Namespace = "";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.btnCancel,
            this.btnExit,
            this.btnTappingAct,
            this.BuSteelBtn});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 27;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BtnTappingPlanGen");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 40);
            this.btnConfirm.Text = "出钢计划排产";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "BtnTappingPlanGen");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.Text = "取消浇钢计划";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // btnTappingAct
            // 
            this.Adapter.SetAccessRight(this.btnTappingAct, "BtnTappingPlanGen");
            this.btnTappingAct.Image = ((System.Drawing.Image)(resources.GetObject("btnTappingAct.Image")));
            this.btnTappingAct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTappingAct.Name = "btnTappingAct";
            this.btnTappingAct.Size = new System.Drawing.Size(197, 40);
            this.btnTappingAct.Text = "炉号处理号对齐            ";
            this.btnTappingAct.Click += new System.EventHandler(this.btnTappingAct_Click);
            // 
            // BuSteelBtn
            // 
            this.Adapter.SetAccessRight(this.BuSteelBtn, "BtnTappingPlanGen");
            this.BuSteelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuSteelBtn.Name = "BuSteelBtn";
            this.BuSteelBtn.Size = new System.Drawing.Size(93, 40);
            this.BuSteelBtn.Text = "不锈钢计划排产";
            this.BuSteelBtn.Click += new System.EventHandler(this.BuSteelBtn_Click);
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsTapping;
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
            this.toolStripLabel3,
            this.tsbtnQuery,
            this.toolStripLabel2,
            this.tscmbCasterID,
            this.toolStripLabel5,
            this.tstdtpCreateDate,
            this.toolStripLabel4,
            this.tstxtCasterID});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 28;
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "　　　　　";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // tscmbCasterID
            // 
            this.tscmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbCasterID.Name = "tscmbCasterID";
            this.tscmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.tscmbCasterID.SelectedIndexChanged += new System.EventHandler(this.tscmbCasterID_SelectedIndexChanged);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel5.Text = "铸机号:";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel4.Text = "计划制定日期:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvTapping);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvTapping
            // 
            this.dvTapping.AllowUserToAddRows = false;
            this.dvTapping.AutoGenerateColumns = false;
            this.dvTapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvTapping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvTapping.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.NEW_BOF_FLAG,
            this.BOFID,
            this.AODID,
            this.LFID,
            this.RHID,
            this.REFINE_TYPE,
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.pRESTEELGRADEDataGridViewTextBoxColumn,
            this.sTDDataGridViewTextBoxColumn,
            this.Protocol,
            this.MaterialCode,
            this.ProduceStd,
            this.TECH_REQUEST,
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn,
            this.ActWeight,
            this.bLOOMCOUNTDataGridViewTextBoxColumn,
            this.pLANORDIDDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn,
            this.pLANIDDataGridViewTextBoxColumn,
            this.STATUS,
            this.pLANDEPTDataGridViewTextBoxColumn,
            this.eXECUTEDEPTDataGridViewTextBoxColumn,
            this.cONTRACTIDDataGridViewTextBoxColumn,
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn,
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn,
            this.pLANNERDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.pRELOTNODataGridViewTextBoxColumn,
            this.pREHEATIDDataGridViewTextBoxColumn,
            this.pROCSEQDataGridViewTextBoxColumn});
            this.dvTapping.ContextMenuStrip = this.contextCasting;
            this.dvTapping.DataSource = this.bsTapping;
            this.dvTapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTapping.Location = new System.Drawing.Point(0, 0);
            this.dvTapping.Name = "dvTapping";
            this.dvTapping.RowHeadersVisible = false;
            this.dvTapping.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvTapping.RowTemplate.Height = 23;
            this.dvTapping.Size = new System.Drawing.Size(996, 628);
            this.dvTapping.TabIndex = 0;
            this.dvTapping.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dvTapping_RowPrePaint);
            this.dvTapping.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvTapping_CurrentCellDirtyStateChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CheckFlag";
            this.dataGridViewTextBoxColumn1.FalseValue = "0";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "选择";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.TrueValue = "1";
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.DataSource = this.dsCasterID;
            this.cASTERIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cASTERIDDataGridViewTextBoxColumn.Frozen = true;
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cASTERIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cASTERIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.cASTERIDDataGridViewTextBoxColumn.Width = 66;
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
            // NEW_BOF_FLAG
            // 
            this.NEW_BOF_FLAG.DataPropertyName = "NEW_BOF_FLAG";
            this.NEW_BOF_FLAG.DataSource = this.dsNewBOFFlag;
            this.NEW_BOF_FLAG.DisplayMember = "L3DataTable.Code_Des";
            this.NEW_BOF_FLAG.Frozen = true;
            this.NEW_BOF_FLAG.HeaderText = "转炉标志";
            this.NEW_BOF_FLAG.Name = "NEW_BOF_FLAG";
            this.NEW_BOF_FLAG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NEW_BOF_FLAG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NEW_BOF_FLAG.ValueMember = "L3DataTable.Code_Val_Long";
            this.NEW_BOF_FLAG.Width = 78;
            // 
            // dsNewBOFFlag
            // 
            this.dsNewBOFFlag.AutoLoad = true;
            this.dsNewBOFFlag.AutoSubscribe = false;
            this.dsNewBOFFlag.DataSetName = "L3DataSet";
            this.dsNewBOFFlag.DeleteMethod = null;
            this.dsNewBOFFlag.InsertMethod = null;
            this.dsNewBOFFlag.L3DataAdapter = this.Adapter;
            this.dsNewBOFFlag.LoadEvent = "Click";
            this.dsNewBOFFlag.LoadTrigger = null;
            this.dsNewBOFFlag.RefreshValve = 1000;
            this.dsNewBOFFlag.SourceCommand = null;
            this.dsNewBOFFlag.SourceCondition = "Code_Group = \'BOF_TYPE\' and Code is not Null";
            this.dsNewBOFFlag.SourceMethod = "";
            this.dsNewBOFFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNewBOFFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsNewBOFFlag.SubscribeTarget = null;
            this.dsNewBOFFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNewBOFFlag});
            this.dsNewBOFFlag.UpdateEvent = "Click";
            this.dsNewBOFFlag.UpdateMethod = null;
            this.dsNewBOFFlag.UpdateTrigger = null;
            // 
            // schemadsNewBOFFlag
            // 
            this.schemadsNewBOFFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNewBOFFlagL3DataTableCode_Des,
            this.coldsNewBOFFlagL3DataTableCode_Val_Long});
            this.schemadsNewBOFFlag.TableName = "L3DataTable";
            // 
            // coldsNewBOFFlagL3DataTableCode_Des
            // 
            this.coldsNewBOFFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNewBOFFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNewBOFFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsNewBOFFlagL3DataTableCode_Val_Long
            // 
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // BOFID
            // 
            this.BOFID.DataPropertyName = "BOFID";
            this.BOFID.DataSource = this.dsBOFID;
            this.BOFID.DisplayMember = "L3DataTable.Code_Des";
            this.BOFID.Frozen = true;
            this.BOFID.HeaderText = "转炉炉座号";
            this.BOFID.Name = "BOFID";
            this.BOFID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BOFID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BOFID.ValueMember = "L3DataTable.Code";
            this.BOFID.Width = 90;
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
            this.dsBOFID.SourceCondition = "Code_Group = \'BOF\' and Code is not null";
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
            // AODID
            // 
            this.AODID.DataPropertyName = "AODID";
            this.AODID.DataSource = this.dsAODID;
            this.AODID.DisplayMember = "L3DataTable.Code_Des";
            this.AODID.Frozen = true;
            this.AODID.HeaderText = "AOD炉座号";
            this.AODID.Name = "AODID";
            this.AODID.ValueMember = "L3DataTable.Code";
            this.AODID.Width = 65;
            // 
            // dsAODID
            // 
            this.dsAODID.AutoLoad = true;
            this.dsAODID.AutoSubscribe = false;
            this.dsAODID.DataSetName = "L3DataSet";
            this.dsAODID.DeleteMethod = null;
            this.dsAODID.InsertMethod = null;
            this.dsAODID.L3DataAdapter = this.Adapter;
            this.dsAODID.LoadEvent = "Click";
            this.dsAODID.LoadTrigger = null;
            this.dsAODID.RefreshValve = 1000;
            this.dsAODID.SourceCommand = null;
            this.dsAODID.SourceCondition = "Code_Group = \'AOD\'";
            this.dsAODID.SourceMethod = "";
            this.dsAODID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAODID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAODID.SubscribeTarget = null;
            this.dsAODID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAODID});
            this.dsAODID.UpdateEvent = "Click";
            this.dsAODID.UpdateMethod = null;
            this.dsAODID.UpdateTrigger = null;
            // 
            // schemadsAODID
            // 
            this.schemadsAODID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAODIDL3DataTableCode,
            this.coldsAODIDL3DataTableCode_Des});
            this.schemadsAODID.TableName = "L3DataTable";
            // 
            // coldsAODIDL3DataTableCode
            // 
            this.coldsAODIDL3DataTableCode.Caption = "Code";
            this.coldsAODIDL3DataTableCode.ColumnName = "Code";
            this.coldsAODIDL3DataTableCode.Namespace = "";
            // 
            // coldsAODIDL3DataTableCode_Des
            // 
            this.coldsAODIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAODIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAODIDL3DataTableCode_Des.Namespace = "";
            // 
            // LFID
            // 
            this.LFID.DataPropertyName = "LFID";
            this.LFID.DataSource = this.dsLFID;
            this.LFID.DisplayMember = "L3DataTable.Code_Des";
            this.LFID.Frozen = true;
            this.LFID.HeaderText = "LF炉座号";
            this.LFID.Name = "LFID";
            this.LFID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LFID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LFID.ValueMember = "L3DataTable.Code";
            this.LFID.Width = 78;
            // 
            // dsLFID
            // 
            this.dsLFID.AutoLoad = true;
            this.dsLFID.AutoSubscribe = false;
            this.dsLFID.DataSetName = "L3DataSet";
            this.dsLFID.DeleteMethod = null;
            this.dsLFID.InsertMethod = null;
            this.dsLFID.L3DataAdapter = this.Adapter;
            this.dsLFID.LoadEvent = "Click";
            this.dsLFID.LoadTrigger = null;
            this.dsLFID.RefreshValve = 1000;
            this.dsLFID.SourceCommand = null;
            this.dsLFID.SourceCondition = "Code_Group = \'LF_CHANGE\'";
            this.dsLFID.SourceMethod = "";
            this.dsLFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLFID.SubscribeTarget = null;
            this.dsLFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLFID});
            this.dsLFID.UpdateEvent = "Click";
            this.dsLFID.UpdateMethod = null;
            this.dsLFID.UpdateTrigger = null;
            // 
            // schemadsLFID
            // 
            this.schemadsLFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLFIDL3DataTableCode,
            this.coldsLFIDL3DataTableCode_Des});
            this.schemadsLFID.TableName = "L3DataTable";
            // 
            // coldsLFIDL3DataTableCode
            // 
            this.coldsLFIDL3DataTableCode.Caption = "Code";
            this.coldsLFIDL3DataTableCode.ColumnName = "Code";
            this.coldsLFIDL3DataTableCode.Namespace = "";
            // 
            // coldsLFIDL3DataTableCode_Des
            // 
            this.coldsLFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLFIDL3DataTableCode_Des.Namespace = "";
            // 
            // RHID
            // 
            this.RHID.DataPropertyName = "RHID";
            this.RHID.DataSource = this.dsRHID;
            this.RHID.DisplayMember = "L3DataTable.Code_Des";
            this.RHID.Frozen = true;
            this.RHID.HeaderText = "RH炉座号";
            this.RHID.Name = "RHID";
            this.RHID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RHID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RHID.ValueMember = "L3DataTable.Code";
            this.RHID.Width = 78;
            // 
            // dsRHID
            // 
            this.dsRHID.AutoLoad = true;
            this.dsRHID.AutoSubscribe = false;
            this.dsRHID.DataSetName = "L3DataSet";
            this.dsRHID.DeleteMethod = null;
            this.dsRHID.InsertMethod = null;
            this.dsRHID.L3DataAdapter = this.Adapter;
            this.dsRHID.LoadEvent = "Click";
            this.dsRHID.LoadTrigger = null;
            this.dsRHID.RefreshValve = 1000;
            this.dsRHID.SourceCommand = null;
            this.dsRHID.SourceCondition = "Code_Group = \'RH_CHANGE\'";
            this.dsRHID.SourceMethod = "";
            this.dsRHID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRHID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRHID.SubscribeTarget = null;
            this.dsRHID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRHID});
            this.dsRHID.UpdateEvent = "Click";
            this.dsRHID.UpdateMethod = null;
            this.dsRHID.UpdateTrigger = null;
            // 
            // schemadsRHID
            // 
            this.schemadsRHID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRHIDL3DataTableCode,
            this.coldsRHIDL3DataTableCode_Des});
            this.schemadsRHID.TableName = "L3DataTable";
            // 
            // coldsRHIDL3DataTableCode
            // 
            this.coldsRHIDL3DataTableCode.Caption = "Code";
            this.coldsRHIDL3DataTableCode.ColumnName = "Code";
            this.coldsRHIDL3DataTableCode.Namespace = "";
            // 
            // coldsRHIDL3DataTableCode_Des
            // 
            this.coldsRHIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRHIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRHIDL3DataTableCode_Des.Namespace = "";
            // 
            // REFINE_TYPE
            // 
            this.REFINE_TYPE.DataPropertyName = "REFINE_TYPE";
            this.REFINE_TYPE.Frozen = true;
            this.REFINE_TYPE.HeaderText = "精炼区分";
            this.REFINE_TYPE.Name = "REFINE_TYPE";
            this.REFINE_TYPE.ReadOnly = true;
            this.REFINE_TYPE.Width = 78;
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Frozen = true;
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Width = 78;
            // 
            // pRESTEELGRADEDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADE";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.Frozen = true;
            this.pRESTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.Name = "pRESTEELGRADEDataGridViewTextBoxColumn";
            this.pRESTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRESTEELGRADEDataGridViewTextBoxColumn.Width = 54;
            // 
            // sTDDataGridViewTextBoxColumn
            // 
            this.sTDDataGridViewTextBoxColumn.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn.Frozen = true;
            this.sTDDataGridViewTextBoxColumn.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn.Name = "sTDDataGridViewTextBoxColumn";
            this.sTDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "Protocol";
            this.Protocol.Frozen = true;
            this.Protocol.HeaderText = "制造标准/协议";
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Width = 108;
            // 
            // MaterialCode
            // 
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "物料代码";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.Width = 78;
            // 
            // ProduceStd
            // 
            this.ProduceStd.DataPropertyName = "ProduceStd";
            this.ProduceStd.HeaderText = "制造标准";
            this.ProduceStd.Name = "ProduceStd";
            this.ProduceStd.ReadOnly = true;
            this.ProduceStd.Width = 78;
            // 
            // TECH_REQUEST
            // 
            this.TECH_REQUEST.DataPropertyName = "TECH_REQUEST";
            this.TECH_REQUEST.HeaderText = "技术要求";
            this.TECH_REQUEST.Name = "TECH_REQUEST";
            this.TECH_REQUEST.ReadOnly = true;
            this.TECH_REQUEST.Width = 78;
            // 
            // aIMTAPPEDWEIGHTDataGridViewTextBoxColumn
            // 
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TAPPED_WEIGHT";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.HeaderText = "目标出钢量";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.Name = "aIMTAPPEDWEIGHTDataGridViewTextBoxColumn";
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIMTAPPEDWEIGHTDataGridViewTextBoxColumn.Width = 90;
            // 
            // ActWeight
            // 
            this.ActWeight.DataPropertyName = "ActWeight";
            this.ActWeight.HeaderText = "实际投放量";
            this.ActWeight.Name = "ActWeight";
            this.ActWeight.ReadOnly = true;
            this.ActWeight.Width = 90;
            // 
            // bLOOMCOUNTDataGridViewTextBoxColumn
            // 
            this.bLOOMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "BLOOM_COUNT";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.HeaderText = "计划钢坯块数";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Name = "bLOOMCOUNTDataGridViewTextBoxColumn";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            this.pLANORDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANORDIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "计划日期";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // aIMTIMECASTINGSTARTDataGridViewTextBoxColumn
            // 
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.DataPropertyName = "AIM_TIME_CASTINGSTART";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.HeaderText = "计划开浇时间";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.Name = "aIMTIMECASTINGSTARTDataGridViewTextBoxColumn";
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aIMTIMECASTINGSTARTDataGridViewTextBoxColumn.Width = 102;
            // 
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.pLANIDDataGridViewTextBoxColumn.Name = "pLANIDDataGridViewTextBoxColumn";
            this.pLANIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.DataSource = this.dsStatus;
            this.STATUS.DisplayMember = "L3DataTable.Code_Des";
            this.STATUS.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.STATUS.HeaderText = "计划状态";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STATUS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.STATUS.ValueMember = "L3DataTable.Code_Val_Long";
            this.STATUS.Width = 78;
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
            this.dsStatus.SourceCondition = "Code_Group = \'CASTING_PLAN_STATUS\'";
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
            // pLANDEPTDataGridViewTextBoxColumn
            // 
            this.pLANDEPTDataGridViewTextBoxColumn.DataPropertyName = "PLANDEPT";
            this.pLANDEPTDataGridViewTextBoxColumn.HeaderText = "计划制订单位";
            this.pLANDEPTDataGridViewTextBoxColumn.Name = "pLANDEPTDataGridViewTextBoxColumn";
            this.pLANDEPTDataGridViewTextBoxColumn.Visible = false;
            this.pLANDEPTDataGridViewTextBoxColumn.Width = 102;
            // 
            // eXECUTEDEPTDataGridViewTextBoxColumn
            // 
            this.eXECUTEDEPTDataGridViewTextBoxColumn.DataPropertyName = "EXECUTEDEPT";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.HeaderText = "计划执行单位";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Name = "eXECUTEDEPTDataGridViewTextBoxColumn";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Visible = false;
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Width = 102;
            // 
            // cONTRACTIDDataGridViewTextBoxColumn
            // 
            this.cONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "CONTRACTID";
            this.cONTRACTIDDataGridViewTextBoxColumn.HeaderText = "合同号";
            this.cONTRACTIDDataGridViewTextBoxColumn.Name = "cONTRACTIDDataGridViewTextBoxColumn";
            this.cONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            this.cONTRACTIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // pLANEXECUTEDATEDataGridViewTextBoxColumn
            // 
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANEXECUTEDATE";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.HeaderText = "计划执行日期";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Name = "pLANEXECUTEDATEDataGridViewTextBoxColumn";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Visible = false;
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Width = 102;
            // 
            // aCTUALEXECUTEDATEDataGridViewTextBoxColumn
            // 
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.DataPropertyName = "ACTUALEXECUTEDATE";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.HeaderText = "实际执行日期";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.Name = "aCTUALEXECUTEDATEDataGridViewTextBoxColumn";
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.Visible = false;
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn.Width = 102;
            // 
            // pLANNERDataGridViewTextBoxColumn
            // 
            this.pLANNERDataGridViewTextBoxColumn.DataPropertyName = "PLANNER";
            this.pLANNERDataGridViewTextBoxColumn.HeaderText = "计划员";
            this.pLANNERDataGridViewTextBoxColumn.Name = "pLANNERDataGridViewTextBoxColumn";
            this.pLANNERDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANNERDataGridViewTextBoxColumn.Width = 66;
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            this.lENGTHDataGridViewTextBoxColumn.Visible = false;
            this.lENGTHDataGridViewTextBoxColumn.Width = 54;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.Visible = false;
            this.wIDTHDataGridViewTextBoxColumn.Width = 54;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.Visible = false;
            this.tHICKNESSDataGridViewTextBoxColumn.Width = 54;
            // 
            // pRELOTNODataGridViewTextBoxColumn
            // 
            this.pRELOTNODataGridViewTextBoxColumn.DataPropertyName = "PRE_LOTNO";
            this.pRELOTNODataGridViewTextBoxColumn.HeaderText = "预定包次号";
            this.pRELOTNODataGridViewTextBoxColumn.Name = "pRELOTNODataGridViewTextBoxColumn";
            this.pRELOTNODataGridViewTextBoxColumn.Visible = false;
            this.pRELOTNODataGridViewTextBoxColumn.Width = 90;
            // 
            // pREHEATIDDataGridViewTextBoxColumn
            // 
            this.pREHEATIDDataGridViewTextBoxColumn.DataPropertyName = "PREHEATID";
            this.pREHEATIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.pREHEATIDDataGridViewTextBoxColumn.Name = "pREHEATIDDataGridViewTextBoxColumn";
            this.pREHEATIDDataGridViewTextBoxColumn.Visible = false;
            this.pREHEATIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // pROCSEQDataGridViewTextBoxColumn
            // 
            this.pROCSEQDataGridViewTextBoxColumn.DataPropertyName = "PROC_SEQ";
            this.pROCSEQDataGridViewTextBoxColumn.HeaderText = "计划处理顺序";
            this.pROCSEQDataGridViewTextBoxColumn.Name = "pROCSEQDataGridViewTextBoxColumn";
            this.pROCSEQDataGridViewTextBoxColumn.Visible = false;
            this.pROCSEQDataGridViewTextBoxColumn.Width = 102;
            // 
            // contextCasting
            // 
            this.contextCasting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全选ToolStripMenuItem});
            this.contextCasting.Name = "contextCasting";
            this.contextCasting.Size = new System.Drawing.Size(95, 26);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.contextCasting_Click);
            // 
            // cmdTapping
            // 
            this.cmdTapping.Adapter = this.Adapter;
            this.cmdTapping.MergeReturnTarget = false;
            this.cmdTapping.Method = "TappingPlanGen1";
            this.cmdTapping.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdTapping.Parameters.Add(this.l3CommandParameter3);
            this.cmdTapping.ReturnTarget = null;
            this.cmdTapping.ReturnTargetProperty = null;
            this.cmdTapping.Trigger = null;
            this.cmdTapping.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter3.SourceObject = this.dsTapping;
            this.l3CommandParameter3.SourceProperty = "L3DataTable";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // cmdCastingCancel
            // 
            this.cmdCastingCancel.Adapter = this.Adapter;
            this.cmdCastingCancel.MergeReturnTarget = false;
            this.cmdCastingCancel.Method = "CastingPlanCancel";
            this.cmdCastingCancel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdCastingCancel.Parameters.Add(this.l3CommandParameter4);
            this.cmdCastingCancel.ReturnTarget = null;
            this.cmdCastingCancel.ReturnTargetProperty = null;
            this.cmdCastingCancel.Trigger = null;
            this.cmdCastingCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter4.SourceObject = this.dsTapping;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
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
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = false;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'TappingPlanGen\'";
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
            // updateHeatid
            // 
            this.updateHeatid.Adapter = this.Adapter;
            this.updateHeatid.MergeReturnTarget = false;
            this.updateHeatid.Method = "UpdateAODHeatid";
            this.updateHeatid.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.updateHeatid.ReturnTarget = null;
            this.updateHeatid.ReturnTargetProperty = null;
            this.updateHeatid.Trigger = null;
            this.updateHeatid.TriggerEvent = "Click";
            // 
            // cmdTapping1
            // 
            this.cmdTapping1.Adapter = this.Adapter;
            this.cmdTapping1.MergeReturnTarget = false;
            this.cmdTapping1.Method = "TappingPlanGen";
            this.cmdTapping1.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdTapping1.Parameters.Add(this.l3CommandParameter5);
            this.cmdTapping1.ReturnTarget = null;
            this.cmdTapping1.ReturnTargetProperty = null;
            this.cmdTapping1.Trigger = null;
            this.cmdTapping1.TriggerEvent = "Click";
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
            // GenTappingPlanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenTappingPlanFrm";
            this.TabText = "出钢计划排产";
            this.Load += new System.EventHandler(this.GenTappingPlanFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenTappingPlanFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAODID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAODID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.contextCasting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsTapping;
        private System.Windows.Forms.BindingSource bsTapping;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvTapping;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel tsbtnQuery;
        private System.Windows.Forms.ToolStripComboBox tscmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker tstdtpCreateDate;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Command cmdQuery;
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
        private System.Data.DataColumn coldsTappingL3DataTableCASTERID;
        private System.Data.DataColumn coldsTappingL3DataTableLENGTH;
        private System.Data.DataColumn coldsTappingL3DataTableWIDTH;
        private System.Data.DataColumn coldsTappingL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsTappingL3DataTableREFINE_TYPE;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_LOTNO;
        private System.Data.DataColumn coldsTappingL3DataTablePREHEATID;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TAPPED_WEIGHT;
        private System.Data.DataColumn coldsTappingL3DataTablePROC_SEQ;
        private System.Data.DataColumn coldsTappingL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsTappingL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsTappingL3DataTableAIM_TIME_CASTINGSTART;
        private System.Data.DataColumn coldsTappingL3DataTableNEW_BOF_FLAG;
        private System.Data.DataColumn coldsTappingL3DataTableSTD;
        private System.Windows.Forms.ToolStripTextBox tstxtCasterID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdTapping;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3Command cmdCastingCancel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.ContextMenuStrip contextCasting;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsNewBOFFlag;
        private System.Data.DataTable schemadsNewBOFFlag;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsTappingL3DataTablePRE_STEELGRADE;
        private AppSvrHMI.L3Command l3Command1;
        private System.Data.DataColumn coldsTappingL3DataTableCheckFlag;
        private System.Data.DataColumn coldsTappingL3DataTableBOFID;
        private System.Data.DataColumn coldsTappingL3DataTableLFID;
        private System.Data.DataColumn coldsTappingL3DataTableRHID;
        private AppSvrHMI.L3DataSet dsBOFID;
        private AppSvrHMI.L3DataSet dsLFID;
        private AppSvrHMI.L3DataSet dsRHID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsLFID;
        private System.Data.DataColumn coldsLFIDL3DataTableCode;
        private System.Data.DataColumn coldsLFIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsRHID;
        private System.Data.DataColumn coldsRHIDL3DataTableCode;
        private System.Data.DataColumn coldsRHIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTappingL3DataTableActWeight;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.ToolStripButton btnTappingAct;
        private AppSvrHMI.L3Command updateHeatid;
        private System.Windows.Forms.ToolStripButton BuSteelBtn;
        private AppSvrHMI.L3Command cmdTapping1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private System.Data.DataColumn coldsTappingL3DataTableProtocol;
        private System.Data.DataColumn coldsTappingL3DataTableTECH_REQUEST;
        private System.Data.DataColumn coldsTappingL3DataTableProduceStd;
        private System.Data.DataColumn coldsTappingL3DataTableAODID;
        private AppSvrHMI.L3DataSet dsAODID;
        private System.Data.DataTable schemadsAODID;
        private System.Data.DataColumn coldsAODIDL3DataTableCode;
        private System.Data.DataColumn coldsAODIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTappingL3DataTableMaterialCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn NEW_BOF_FLAG;
        private System.Windows.Forms.DataGridViewComboBoxColumn BOFID;
        private System.Windows.Forms.DataGridViewComboBoxColumn AODID;
        private System.Windows.Forms.DataGridViewComboBoxColumn LFID;
        private System.Windows.Forms.DataGridViewComboBoxColumn RHID;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFINE_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TECH_REQUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTAPPEDWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOOMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIMTIMECASTINGSTARTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXECUTEDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTUALEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRELOTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREHEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCSEQDataGridViewTextBoxColumn;
    }
}