namespace PlanMag
{
    partial class PlanOrdIntegerateFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanOrdIntegerateFrm));
            this.bsIntegernate = new System.Windows.Forms.BindingSource(this.components);
            this.dsIntegernate = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmdIntegernate = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tstdtpCreateDate = new buttonHide.ToolStripToriDateTimePicker();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableNAME = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePLANID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSTATUS = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePLANNER = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLENGTH = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWIDTH = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableUNIT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableASSIST_UNIT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWEIGHT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableASSISI_WEIGHT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePLANREC_DATE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableREQUEST_DATE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCORP = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFACTORY = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWORK_CENTER = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCLIENT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTECH_REQUEST = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableINSIDE_NOTE = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableIMM_FLAG = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCASTERID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsIntegernateL3DataTableSTD = new System.Data.DataColumn();
            this.coldsIntegernateL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsIntegernateL3DataTableProtocol = new System.Data.DataColumn();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.tsbtIntegerate = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvIntegernate = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.nEWBOFFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsNewBOFFlag = new AppSvrHMI.L3DataSet();
            this.schemadsNewBOFFlag = new System.Data.DataTable();
            this.coldsNewBOFFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsNewBOFFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSISTUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSISIWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANRECDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQUESTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACTORYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKCENTERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tECHREQUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSIDENOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMMFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXECUTEDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdIntegernateCfm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsIntegernate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntegernate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIntegernate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bsIntegernate
            // 
            this.bsIntegernate.DataMember = "L3DataTable";
            this.bsIntegernate.DataSource = this.dsIntegernate;
            // 
            // dsIntegernate
            // 
            this.dsIntegernate.AutoLoad = true;
            this.dsIntegernate.AutoSubscribe = true;
            this.dsIntegernate.DataSetName = "dsIntegernate";
            this.dsIntegernate.DeleteMethod = "";
            this.dsIntegernate.InsertMethod = "";
            this.dsIntegernate.L3DataAdapter = this.Adapter;
            this.dsIntegernate.LoadEvent = "Click";
            this.dsIntegernate.LoadTrigger = this.btnQuery;
            this.dsIntegernate.RefreshValve = 1000;
            this.dsIntegernate.SourceCommand = this.cmdIntegernate;
            this.dsIntegernate.SourceCondition = null;
            this.dsIntegernate.SourceMethod = "GetUnIntegratePlanOrd";
            this.dsIntegernate.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsIntegernate.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.dsIntegernate.SubscribeTarget = null;
            this.dsIntegernate.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsIntegernate.UpdateEvent = "Click";
            this.dsIntegernate.UpdateMethod = "";
            this.dsIntegernate.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            // 
            // cmdIntegernate
            // 
            this.cmdIntegernate.Adapter = null;
            this.cmdIntegernate.MergeReturnTarget = false;
            this.cmdIntegernate.Method = null;
            this.cmdIntegernate.Object = null;
            this.cmdIntegernate.Parameters.Add(this.l3CommandParameter4);
            this.cmdIntegernate.ReturnTarget = null;
            this.cmdIntegernate.ReturnTargetProperty = null;
            this.cmdIntegernate.Trigger = null;
            this.cmdIntegernate.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.tstdtpCreateDate;
            this.l3CommandParameter4.SourceProperty = "Text";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
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
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableNAME,
            this.coll3DataSet1L3DataTablePLANID,
            this.coll3DataSet1L3DataTableCONTRACTID,
            this.coll3DataSet1L3DataTableSTATUS,
            this.coll3DataSet1L3DataTablePLANDEPT,
            this.coll3DataSet1L3DataTableEXECUTEDEPT,
            this.coll3DataSet1L3DataTableCREATEDATE,
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE,
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE,
            this.coll3DataSet1L3DataTablePLANNER,
            this.coll3DataSet1L3DataTableLENGTH,
            this.coll3DataSet1L3DataTableWIDTH,
            this.coll3DataSet1L3DataTableTHICKNESS,
            this.coll3DataSet1L3DataTableSTEELGRADE,
            this.coll3DataSet1L3DataTableUNIT,
            this.coll3DataSet1L3DataTableASSIST_UNIT,
            this.coll3DataSet1L3DataTableWEIGHT,
            this.coll3DataSet1L3DataTableASSISI_WEIGHT,
            this.coll3DataSet1L3DataTablePLANREC_DATE,
            this.coll3DataSet1L3DataTableREQUEST_DATE,
            this.coll3DataSet1L3DataTableCORP,
            this.coll3DataSet1L3DataTableFACTORY,
            this.coll3DataSet1L3DataTableWORK_CENTER,
            this.coll3DataSet1L3DataTableCLIENT,
            this.coll3DataSet1L3DataTableTECH_REQUEST,
            this.coll3DataSet1L3DataTableINSIDE_NOTE,
            this.coll3DataSet1L3DataTableIMM_FLAG,
            this.coll3DataSet1L3DataTableCASTERID,
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG,
            this.coldsIntegernateL3DataTableSTD,
            this.coldsIntegernateL3DataTableCheckFlag,
            this.coldsIntegernateL3DataTableProtocol});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.DefaultValue = "";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableNAME
            // 
            this.coll3DataSet1L3DataTableNAME.Caption = "NAME";
            this.coll3DataSet1L3DataTableNAME.ColumnName = "NAME";
            this.coll3DataSet1L3DataTableNAME.DefaultValue = "";
            this.coll3DataSet1L3DataTableNAME.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePLANID
            // 
            this.coll3DataSet1L3DataTablePLANID.Caption = "PLANID";
            this.coll3DataSet1L3DataTablePLANID.ColumnName = "PLANID";
            this.coll3DataSet1L3DataTablePLANID.DefaultValue = "";
            this.coll3DataSet1L3DataTablePLANID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCONTRACTID
            // 
            this.coll3DataSet1L3DataTableCONTRACTID.Caption = "CONTRACTID";
            this.coll3DataSet1L3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coll3DataSet1L3DataTableCONTRACTID.DefaultValue = "";
            this.coll3DataSet1L3DataTableCONTRACTID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSTATUS
            // 
            this.coll3DataSet1L3DataTableSTATUS.Caption = "STATUS";
            this.coll3DataSet1L3DataTableSTATUS.ColumnName = "STATUS";
            this.coll3DataSet1L3DataTableSTATUS.DataType = typeof(int);
            this.coll3DataSet1L3DataTableSTATUS.DefaultValue = 0;
            this.coll3DataSet1L3DataTableSTATUS.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePLANDEPT
            // 
            this.coll3DataSet1L3DataTablePLANDEPT.Caption = "PLANDEPT";
            this.coll3DataSet1L3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coll3DataSet1L3DataTablePLANDEPT.DefaultValue = "";
            this.coll3DataSet1L3DataTablePLANDEPT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableEXECUTEDEPT
            // 
            this.coll3DataSet1L3DataTableEXECUTEDEPT.Caption = "EXECUTEDEPT";
            this.coll3DataSet1L3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coll3DataSet1L3DataTableEXECUTEDEPT.DefaultValue = "";
            this.coll3DataSet1L3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCREATEDATE
            // 
            this.coll3DataSet1L3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coll3DataSet1L3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coll3DataSet1L3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableCREATEDATE.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePLANEXECUTEDATE
            // 
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE.Caption = "PLANEXECUTEDATE";
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coll3DataSet1L3DataTableACTUALEXECUTEDATE
            // 
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE.Caption = "ACTUALEXECUTEDATE";
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePLANNER
            // 
            this.coll3DataSet1L3DataTablePLANNER.Caption = "PLANNER";
            this.coll3DataSet1L3DataTablePLANNER.ColumnName = "PLANNER";
            this.coll3DataSet1L3DataTablePLANNER.DefaultValue = "";
            this.coll3DataSet1L3DataTablePLANNER.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLENGTH
            // 
            this.coll3DataSet1L3DataTableLENGTH.Caption = "LENGTH";
            this.coll3DataSet1L3DataTableLENGTH.ColumnName = "LENGTH";
            this.coll3DataSet1L3DataTableLENGTH.DataType = typeof(int);
            this.coll3DataSet1L3DataTableLENGTH.DefaultValue = 0;
            this.coll3DataSet1L3DataTableLENGTH.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWIDTH
            // 
            this.coll3DataSet1L3DataTableWIDTH.Caption = "WIDTH";
            this.coll3DataSet1L3DataTableWIDTH.ColumnName = "WIDTH";
            this.coll3DataSet1L3DataTableWIDTH.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWIDTH.DefaultValue = 0;
            this.coll3DataSet1L3DataTableWIDTH.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTHICKNESS
            // 
            this.coll3DataSet1L3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coll3DataSet1L3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coll3DataSet1L3DataTableTHICKNESS.DataType = typeof(int);
            this.coll3DataSet1L3DataTableTHICKNESS.DefaultValue = 0;
            this.coll3DataSet1L3DataTableTHICKNESS.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSTEELGRADE
            // 
            this.coll3DataSet1L3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coll3DataSet1L3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coll3DataSet1L3DataTableSTEELGRADE.DefaultValue = "";
            this.coll3DataSet1L3DataTableSTEELGRADE.Namespace = "";
            // 
            // coll3DataSet1L3DataTableUNIT
            // 
            this.coll3DataSet1L3DataTableUNIT.Caption = "UNIT";
            this.coll3DataSet1L3DataTableUNIT.ColumnName = "UNIT";
            this.coll3DataSet1L3DataTableUNIT.DefaultValue = "";
            this.coll3DataSet1L3DataTableUNIT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableASSIST_UNIT
            // 
            this.coll3DataSet1L3DataTableASSIST_UNIT.Caption = "ASSIST_UNIT";
            this.coll3DataSet1L3DataTableASSIST_UNIT.ColumnName = "ASSIST_UNIT";
            this.coll3DataSet1L3DataTableASSIST_UNIT.DefaultValue = "";
            this.coll3DataSet1L3DataTableASSIST_UNIT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWEIGHT
            // 
            this.coll3DataSet1L3DataTableWEIGHT.Caption = "WEIGHT";
            this.coll3DataSet1L3DataTableWEIGHT.ColumnName = "WEIGHT";
            this.coll3DataSet1L3DataTableWEIGHT.DataType = typeof(double);
            this.coll3DataSet1L3DataTableWEIGHT.DefaultValue = 0;
            this.coll3DataSet1L3DataTableWEIGHT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableASSISI_WEIGHT
            // 
            this.coll3DataSet1L3DataTableASSISI_WEIGHT.Caption = "ASSISI_WEIGHT";
            this.coll3DataSet1L3DataTableASSISI_WEIGHT.ColumnName = "ASSISI_WEIGHT";
            this.coll3DataSet1L3DataTableASSISI_WEIGHT.DataType = typeof(double);
            this.coll3DataSet1L3DataTableASSISI_WEIGHT.DefaultValue = 0;
            this.coll3DataSet1L3DataTableASSISI_WEIGHT.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePLANREC_DATE
            // 
            this.coll3DataSet1L3DataTablePLANREC_DATE.Caption = "PLANREC_DATE";
            this.coll3DataSet1L3DataTablePLANREC_DATE.ColumnName = "PLANREC_DATE";
            this.coll3DataSet1L3DataTablePLANREC_DATE.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTablePLANREC_DATE.Namespace = "";
            // 
            // coll3DataSet1L3DataTableREQUEST_DATE
            // 
            this.coll3DataSet1L3DataTableREQUEST_DATE.Caption = "REQUEST_DATE";
            this.coll3DataSet1L3DataTableREQUEST_DATE.ColumnName = "REQUEST_DATE";
            this.coll3DataSet1L3DataTableREQUEST_DATE.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableREQUEST_DATE.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCORP
            // 
            this.coll3DataSet1L3DataTableCORP.Caption = "CORP";
            this.coll3DataSet1L3DataTableCORP.ColumnName = "CORP";
            this.coll3DataSet1L3DataTableCORP.DefaultValue = "";
            this.coll3DataSet1L3DataTableCORP.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFACTORY
            // 
            this.coll3DataSet1L3DataTableFACTORY.Caption = "FACTORY";
            this.coll3DataSet1L3DataTableFACTORY.ColumnName = "FACTORY";
            this.coll3DataSet1L3DataTableFACTORY.DefaultValue = "";
            this.coll3DataSet1L3DataTableFACTORY.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWORK_CENTER
            // 
            this.coll3DataSet1L3DataTableWORK_CENTER.Caption = "WORK_CENTER";
            this.coll3DataSet1L3DataTableWORK_CENTER.ColumnName = "WORK_CENTER";
            this.coll3DataSet1L3DataTableWORK_CENTER.DefaultValue = "";
            this.coll3DataSet1L3DataTableWORK_CENTER.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCLIENT
            // 
            this.coll3DataSet1L3DataTableCLIENT.Caption = "CLIENT";
            this.coll3DataSet1L3DataTableCLIENT.ColumnName = "CLIENT";
            this.coll3DataSet1L3DataTableCLIENT.DefaultValue = "";
            this.coll3DataSet1L3DataTableCLIENT.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTECH_REQUEST
            // 
            this.coll3DataSet1L3DataTableTECH_REQUEST.Caption = "TECH_REQUEST";
            this.coll3DataSet1L3DataTableTECH_REQUEST.ColumnName = "TECH_REQUEST";
            this.coll3DataSet1L3DataTableTECH_REQUEST.DefaultValue = "";
            this.coll3DataSet1L3DataTableTECH_REQUEST.Namespace = "";
            // 
            // coll3DataSet1L3DataTableINSIDE_NOTE
            // 
            this.coll3DataSet1L3DataTableINSIDE_NOTE.Caption = "INSIDE_NOTE";
            this.coll3DataSet1L3DataTableINSIDE_NOTE.ColumnName = "INSIDE_NOTE";
            this.coll3DataSet1L3DataTableINSIDE_NOTE.DefaultValue = "";
            this.coll3DataSet1L3DataTableINSIDE_NOTE.Namespace = "";
            // 
            // coll3DataSet1L3DataTableIMM_FLAG
            // 
            this.coll3DataSet1L3DataTableIMM_FLAG.Caption = "IMM_FLAG";
            this.coll3DataSet1L3DataTableIMM_FLAG.ColumnName = "IMM_FLAG";
            this.coll3DataSet1L3DataTableIMM_FLAG.DefaultValue = "";
            this.coll3DataSet1L3DataTableIMM_FLAG.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCASTERID
            // 
            this.coll3DataSet1L3DataTableCASTERID.Caption = "CASTERID";
            this.coll3DataSet1L3DataTableCASTERID.ColumnName = "CASTERID";
            this.coll3DataSet1L3DataTableCASTERID.DefaultValue = "";
            this.coll3DataSet1L3DataTableCASTERID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableNEW_BOF_FLAG
            // 
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coll3DataSet1L3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsIntegernateL3DataTableSTD
            // 
            this.coldsIntegernateL3DataTableSTD.Caption = "STD";
            this.coldsIntegernateL3DataTableSTD.ColumnName = "STD";
            this.coldsIntegernateL3DataTableSTD.DefaultValue = "";
            this.coldsIntegernateL3DataTableSTD.Namespace = "";
            // 
            // coldsIntegernateL3DataTableCheckFlag
            // 
            this.coldsIntegernateL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsIntegernateL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsIntegernateL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsIntegernateL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsIntegernateL3DataTableProtocol
            // 
            this.coldsIntegernateL3DataTableProtocol.Caption = "Protocol";
            this.coldsIntegernateL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsIntegernateL3DataTableProtocol.Namespace = "";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtIntegerate,
            this.btnExit});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 27;
            this.tSp1.Text = "toolStrip1";
            // 
            // tsbtIntegerate
            // 
            this.tsbtIntegerate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtIntegerate.Image")));
            this.tsbtIntegerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtIntegerate.Name = "tsbtIntegerate";
            this.tsbtIntegerate.Size = new System.Drawing.Size(65, 40);
            this.tsbtIntegerate.Text = "收池";
            this.tsbtIntegerate.Click += new System.EventHandler(this.tsbtIntegerate_Click);
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
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsIntegernate;
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
            this.tstdtpCreateDate,
            this.toolStripLabel2});
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "计划制订日期:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvIntegernate);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvIntegernate
            // 
            this.dvIntegernate.AllowUserToAddRows = false;
            this.dvIntegernate.AutoGenerateColumns = false;
            this.dvIntegernate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvIntegernate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvIntegernate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.nEWBOFFLAGDataGridViewTextBoxColumn,
            this.pLANIDDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.Protocol,
            this.sTDDataGridViewTextBoxColumn,
            this.wEIGHTDataGridViewTextBoxColumn,
            this.uNITDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn,
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn,
            this.pLANNERDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.aSSISTUNITDataGridViewTextBoxColumn,
            this.aSSISIWEIGHTDataGridViewTextBoxColumn,
            this.pLANRECDATEDataGridViewTextBoxColumn,
            this.rEQUESTDATEDataGridViewTextBoxColumn,
            this.cORPDataGridViewTextBoxColumn,
            this.fACTORYDataGridViewTextBoxColumn,
            this.wORKCENTERDataGridViewTextBoxColumn,
            this.cLIENTDataGridViewTextBoxColumn,
            this.tECHREQUESTDataGridViewTextBoxColumn,
            this.iNSIDENOTEDataGridViewTextBoxColumn,
            this.iMMFLAGDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.pLANDEPTDataGridViewTextBoxColumn,
            this.eXECUTEDEPTDataGridViewTextBoxColumn,
            this.cONTRACTIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvIntegernate.DataSource = this.bsIntegernate;
            this.dvIntegernate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIntegernate.Location = new System.Drawing.Point(0, 0);
            this.dvIntegernate.Name = "dvIntegernate";
            this.dvIntegernate.RowHeadersVisible = false;
            this.dvIntegernate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvIntegernate.RowTemplate.Height = 23;
            this.dvIntegernate.Size = new System.Drawing.Size(996, 628);
            this.dvIntegernate.TabIndex = 0;
            this.dvIntegernate.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
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
            // nEWBOFFLAGDataGridViewTextBoxColumn
            // 
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataPropertyName = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataSource = this.dsNewBOFFlag;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Frozen = true;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.HeaderText = "转炉标志";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Name = "nEWBOFFLAGDataGridViewTextBoxColumn";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsNewBOFFlag
            // 
            this.dsNewBOFFlag.AutoLoad = true;
            this.dsNewBOFFlag.AutoSubscribe = true;
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
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            this.pLANIDDataGridViewTextBoxColumn.Frozen = true;
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "计划号";
            this.pLANIDDataGridViewTextBoxColumn.Name = "pLANIDDataGridViewTextBoxColumn";
            this.pLANIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.Frozen = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "Protocol";
            this.Protocol.Frozen = true;
            this.Protocol.HeaderText = "协议";
            this.Protocol.Name = "Protocol";
            // 
            // sTDDataGridViewTextBoxColumn
            // 
            this.sTDDataGridViewTextBoxColumn.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn.Frozen = true;
            this.sTDDataGridViewTextBoxColumn.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn.Name = "sTDDataGridViewTextBoxColumn";
            this.sTDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT";
            this.wEIGHTDataGridViewTextBoxColumn.Frozen = true;
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "计划数量";
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            this.wEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.Frozen = true;
            this.uNITDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.sTATUSDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTATUSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "计划状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = true;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "Code_Group = \'PLAN_ORDER_STATUS\'";
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
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "计划日期";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.pLANNERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            this.lENGTHDataGridViewTextBoxColumn.Visible = false;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.Visible = false;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.Visible = false;
            // 
            // aSSISTUNITDataGridViewTextBoxColumn
            // 
            this.aSSISTUNITDataGridViewTextBoxColumn.DataPropertyName = "ASSIST_UNIT";
            this.aSSISTUNITDataGridViewTextBoxColumn.HeaderText = "辅计量单位";
            this.aSSISTUNITDataGridViewTextBoxColumn.Name = "aSSISTUNITDataGridViewTextBoxColumn";
            this.aSSISTUNITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aSSISIWEIGHTDataGridViewTextBoxColumn
            // 
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "ASSISI_WEIGHT";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.HeaderText = "计划辅数量";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.Name = "aSSISIWEIGHTDataGridViewTextBoxColumn";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pLANRECDATEDataGridViewTextBoxColumn
            // 
            this.pLANRECDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANREC_DATE";
            this.pLANRECDATEDataGridViewTextBoxColumn.HeaderText = "计划下单日期";
            this.pLANRECDATEDataGridViewTextBoxColumn.Name = "pLANRECDATEDataGridViewTextBoxColumn";
            this.pLANRECDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rEQUESTDATEDataGridViewTextBoxColumn
            // 
            this.rEQUESTDATEDataGridViewTextBoxColumn.DataPropertyName = "REQUEST_DATE";
            this.rEQUESTDATEDataGridViewTextBoxColumn.HeaderText = "需求日期";
            this.rEQUESTDATEDataGridViewTextBoxColumn.Name = "rEQUESTDATEDataGridViewTextBoxColumn";
            this.rEQUESTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cORPDataGridViewTextBoxColumn
            // 
            this.cORPDataGridViewTextBoxColumn.DataPropertyName = "CORP";
            this.cORPDataGridViewTextBoxColumn.HeaderText = "公司";
            this.cORPDataGridViewTextBoxColumn.Name = "cORPDataGridViewTextBoxColumn";
            this.cORPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fACTORYDataGridViewTextBoxColumn
            // 
            this.fACTORYDataGridViewTextBoxColumn.DataPropertyName = "FACTORY";
            this.fACTORYDataGridViewTextBoxColumn.HeaderText = "工厂";
            this.fACTORYDataGridViewTextBoxColumn.Name = "fACTORYDataGridViewTextBoxColumn";
            this.fACTORYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wORKCENTERDataGridViewTextBoxColumn
            // 
            this.wORKCENTERDataGridViewTextBoxColumn.DataPropertyName = "WORK_CENTER";
            this.wORKCENTERDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.wORKCENTERDataGridViewTextBoxColumn.Name = "wORKCENTERDataGridViewTextBoxColumn";
            this.wORKCENTERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTDataGridViewTextBoxColumn
            // 
            this.cLIENTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT";
            this.cLIENTDataGridViewTextBoxColumn.HeaderText = "客户";
            this.cLIENTDataGridViewTextBoxColumn.Name = "cLIENTDataGridViewTextBoxColumn";
            this.cLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tECHREQUESTDataGridViewTextBoxColumn
            // 
            this.tECHREQUESTDataGridViewTextBoxColumn.DataPropertyName = "TECH_REQUEST";
            this.tECHREQUESTDataGridViewTextBoxColumn.HeaderText = "技术要求";
            this.tECHREQUESTDataGridViewTextBoxColumn.Name = "tECHREQUESTDataGridViewTextBoxColumn";
            this.tECHREQUESTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNSIDENOTEDataGridViewTextBoxColumn
            // 
            this.iNSIDENOTEDataGridViewTextBoxColumn.DataPropertyName = "INSIDE_NOTE";
            this.iNSIDENOTEDataGridViewTextBoxColumn.HeaderText = "生产部说明";
            this.iNSIDENOTEDataGridViewTextBoxColumn.Name = "iNSIDENOTEDataGridViewTextBoxColumn";
            this.iNSIDENOTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iMMFLAGDataGridViewTextBoxColumn
            // 
            this.iMMFLAGDataGridViewTextBoxColumn.DataPropertyName = "IMM_FLAG";
            this.iMMFLAGDataGridViewTextBoxColumn.HeaderText = "是否加急";
            this.iMMFLAGDataGridViewTextBoxColumn.Name = "iMMFLAGDataGridViewTextBoxColumn";
            this.iMMFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
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
            // cONTRACTIDDataGridViewTextBoxColumn
            // 
            this.cONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "CONTRACTID";
            this.cONTRACTIDDataGridViewTextBoxColumn.HeaderText = "状态";
            this.cONTRACTIDDataGridViewTextBoxColumn.Name = "cONTRACTIDDataGridViewTextBoxColumn";
            this.cONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsIntegernate;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // cmdIntegernateCfm
            // 
            this.cmdIntegernateCfm.Adapter = this.Adapter;
            this.cmdIntegernateCfm.MergeReturnTarget = false;
            this.cmdIntegernateCfm.Method = "PlanOrdIntegrateCfm";
            this.cmdIntegernateCfm.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdIntegernateCfm.Parameters.Add(this.l3CommandParameter6);
            this.cmdIntegernateCfm.ReturnTarget = null;
            this.cmdIntegernateCfm.ReturnTargetProperty = null;
            this.cmdIntegernateCfm.Trigger = null;
            this.cmdIntegernateCfm.TriggerEvent = "Click";
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter6.SourceObject = this.dsIntegernate;
            this.l3CommandParameter6.SourceProperty = "L3DataTable";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter5.SourceObject = this.dsIntegernate;
            this.l3CommandParameter5.SourceProperty = "L3DataLable";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // PlanOrdIntegerateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanOrdIntegerateFrm";
            this.TabText = "计划订单收池窗口";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanOrdIntegerateFrm_FormClosing);
            this.Load += new System.EventHandler(this.PlanOrdIntegerateFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsIntegernate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIntegernate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIntegernate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsIntegernate;
        private System.Windows.Forms.BindingSource bsIntegernate;
        private System.Windows.Forms.ToolStrip tSp1;
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
        private System.Windows.Forms.DataGridView dvIntegernate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker tstdtpCreateDate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton tsbtIntegerate;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableNAME;
        private System.Data.DataColumn coll3DataSet1L3DataTablePLANID;
        private System.Data.DataColumn coll3DataSet1L3DataTableCONTRACTID;
        private System.Data.DataColumn coll3DataSet1L3DataTableSTATUS;
        private System.Data.DataColumn coll3DataSet1L3DataTablePLANDEPT;
        private System.Data.DataColumn coll3DataSet1L3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coll3DataSet1L3DataTableCREATEDATE;
        private System.Data.DataColumn coll3DataSet1L3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coll3DataSet1L3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coll3DataSet1L3DataTablePLANNER;
        private System.Data.DataColumn coll3DataSet1L3DataTableLENGTH;
        private System.Data.DataColumn coll3DataSet1L3DataTableWIDTH;
        private System.Data.DataColumn coll3DataSet1L3DataTableTHICKNESS;
        private System.Data.DataColumn coll3DataSet1L3DataTableSTEELGRADE;
        private System.Data.DataColumn coll3DataSet1L3DataTableUNIT;
        private System.Data.DataColumn coll3DataSet1L3DataTableASSIST_UNIT;
        private System.Data.DataColumn coll3DataSet1L3DataTableWEIGHT;
        private System.Data.DataColumn coll3DataSet1L3DataTableASSISI_WEIGHT;
        private System.Data.DataColumn coll3DataSet1L3DataTablePLANREC_DATE;
        private System.Data.DataColumn coll3DataSet1L3DataTableREQUEST_DATE;
        private System.Data.DataColumn coll3DataSet1L3DataTableCORP;
        private System.Data.DataColumn coll3DataSet1L3DataTableFACTORY;
        private System.Data.DataColumn coll3DataSet1L3DataTableWORK_CENTER;
        private System.Data.DataColumn coll3DataSet1L3DataTableCLIENT;
        private System.Data.DataColumn coll3DataSet1L3DataTableTECH_REQUEST;
        private System.Data.DataColumn coll3DataSet1L3DataTableINSIDE_NOTE;
        private System.Data.DataColumn coll3DataSet1L3DataTableIMM_FLAG;
        private System.Data.DataColumn coll3DataSet1L3DataTableCASTERID;
        private System.Data.DataColumn coll3DataSet1L3DataTableNEW_BOF_FLAG;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3Command cmdIntegernate;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsIntegernateL3DataTableSTD;
        private System.Data.DataColumn coldsIntegernateL3DataTableCheckFlag;
        private AppSvrHMI.L3Command cmdIntegernateCfm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsNewBOFFlag;
        private System.Data.DataTable schemadsNewBOFFlag;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Val_Long;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Data.DataColumn coldsIntegernateL3DataTableProtocol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nEWBOFFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTUALEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSISTUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSISIWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANRECDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQUESTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fACTORYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKCENTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tECHREQUESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSIDENOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMMFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXECUTEDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}