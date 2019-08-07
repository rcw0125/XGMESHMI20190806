namespace PlanMag
{
    partial class PlanOrdRecFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanOrdRecFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsQuery = new AppSvrHMI.L3DataSet();
            this.schemadsQuery = new System.Data.DataTable();
            this.coldsQueryL3DataTableGUID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableNAME = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLANNER = new System.Data.DataColumn();
            this.coldsQueryL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsQueryL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableUNIT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableASSIST_UNIT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableASSISI_WEIGHT = new System.Data.DataColumn();
            this.coldsQueryL3DataTablePLANREC_DATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableREQUEST_DATE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCORP = new System.Data.DataColumn();
            this.coldsQueryL3DataTableFACTORY = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWORK_CENTER = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCLIENT = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTECH_REQUEST = new System.Data.DataColumn();
            this.coldsQueryL3DataTableINSIDE_NOTE = new System.Data.DataColumn();
            this.coldsQueryL3DataTableIMM_FLAG = new System.Data.DataColumn();
            this.coldsQueryL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsQueryL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.bdPlanOrdRec = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsPlanOrdRec = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanOrdRec = new AppSvrHMI.L3DataSet();
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
            this.coll3DataSet1L3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsPlanOrdRecL3DataTableProtocol = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvPlanOrdRec = new System.Windows.Forms.DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pLANDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXECUTEDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSISTUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEWBOFFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter12 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter11 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter13 = new AppSvrHMI.L3CommandParameter();
            this.cmdPlanOrdRec = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter16 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter15 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter14 = new AppSvrHMI.L3CommandParameter();
            this.coldsPlanOrdRecL3DataTableCheckFlag = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQuery)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdPlanOrdRec)).BeginInit();
            this.bdPlanOrdRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanOrdRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanOrdRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanOrdRec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsQuery
            // 
            this.dsQuery.AutoLoad = true;
            this.dsQuery.AutoSubscribe = true;
            this.dsQuery.DataSetName = "L3DataSet";
            this.dsQuery.DeleteMethod = "";
            this.dsQuery.InsertMethod = "";
            this.dsQuery.L3DataAdapter = this.Adapter;
            this.dsQuery.LoadEvent = "Click";
            this.dsQuery.LoadTrigger = null;
            this.dsQuery.RefreshValve = 1000;
            this.dsQuery.SourceCommand = null;
            this.dsQuery.SourceCondition = "";
            this.dsQuery.SourceMethod = "PlanOrdIntegrate";
            this.dsQuery.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsQuery.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.dsQuery.SubscribeTarget = null;
            this.dsQuery.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsQuery});
            this.dsQuery.UpdateEvent = "Click";
            this.dsQuery.UpdateMethod = "";
            this.dsQuery.UpdateTrigger = null;
            // 
            // schemadsQuery
            // 
            this.schemadsQuery.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsQueryL3DataTableGUID,
            this.coldsQueryL3DataTableNAME,
            this.coldsQueryL3DataTablePLANID,
            this.coldsQueryL3DataTableCONTRACTID,
            this.coldsQueryL3DataTableSTATUS,
            this.coldsQueryL3DataTablePLANDEPT,
            this.coldsQueryL3DataTableEXECUTEDEPT,
            this.coldsQueryL3DataTableCREATEDATE,
            this.coldsQueryL3DataTablePLANEXECUTEDATE,
            this.coldsQueryL3DataTableACTUALEXECUTEDATE,
            this.coldsQueryL3DataTablePLANNER,
            this.coldsQueryL3DataTableLENGTH,
            this.coldsQueryL3DataTableWIDTH,
            this.coldsQueryL3DataTableTHICKNESS,
            this.coldsQueryL3DataTableSTEELGRADE,
            this.coldsQueryL3DataTableUNIT,
            this.coldsQueryL3DataTableASSIST_UNIT,
            this.coldsQueryL3DataTableWEIGHT,
            this.coldsQueryL3DataTableASSISI_WEIGHT,
            this.coldsQueryL3DataTablePLANREC_DATE,
            this.coldsQueryL3DataTableREQUEST_DATE,
            this.coldsQueryL3DataTableCORP,
            this.coldsQueryL3DataTableFACTORY,
            this.coldsQueryL3DataTableWORK_CENTER,
            this.coldsQueryL3DataTableCLIENT,
            this.coldsQueryL3DataTableTECH_REQUEST,
            this.coldsQueryL3DataTableINSIDE_NOTE,
            this.coldsQueryL3DataTableIMM_FLAG,
            this.coldsQueryL3DataTableCASTERID,
            this.coldsQueryL3DataTableNEW_BOF_FLAG});
            this.schemadsQuery.TableName = "L3DataTable";
            // 
            // coldsQueryL3DataTableGUID
            // 
            this.coldsQueryL3DataTableGUID.Caption = "GUID";
            this.coldsQueryL3DataTableGUID.ColumnName = "GUID";
            this.coldsQueryL3DataTableGUID.DefaultValue = "";
            this.coldsQueryL3DataTableGUID.Namespace = "";
            // 
            // coldsQueryL3DataTableNAME
            // 
            this.coldsQueryL3DataTableNAME.Caption = "NAME";
            this.coldsQueryL3DataTableNAME.ColumnName = "NAME";
            this.coldsQueryL3DataTableNAME.DefaultValue = "";
            this.coldsQueryL3DataTableNAME.Namespace = "";
            // 
            // coldsQueryL3DataTablePLANID
            // 
            this.coldsQueryL3DataTablePLANID.Caption = "PLANID";
            this.coldsQueryL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsQueryL3DataTablePLANID.DefaultValue = "";
            this.coldsQueryL3DataTablePLANID.Namespace = "";
            // 
            // coldsQueryL3DataTableCONTRACTID
            // 
            this.coldsQueryL3DataTableCONTRACTID.Caption = "CONTRACTID";
            this.coldsQueryL3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coldsQueryL3DataTableCONTRACTID.DefaultValue = "";
            this.coldsQueryL3DataTableCONTRACTID.Namespace = "";
            // 
            // coldsQueryL3DataTableSTATUS
            // 
            this.coldsQueryL3DataTableSTATUS.Caption = "STATUS";
            this.coldsQueryL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsQueryL3DataTableSTATUS.DataType = typeof(int);
            this.coldsQueryL3DataTableSTATUS.DefaultValue = 0;
            this.coldsQueryL3DataTableSTATUS.Namespace = "";
            // 
            // coldsQueryL3DataTablePLANDEPT
            // 
            this.coldsQueryL3DataTablePLANDEPT.Caption = "PLANDEPT";
            this.coldsQueryL3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coldsQueryL3DataTablePLANDEPT.DefaultValue = "";
            this.coldsQueryL3DataTablePLANDEPT.Namespace = "";
            // 
            // coldsQueryL3DataTableEXECUTEDEPT
            // 
            this.coldsQueryL3DataTableEXECUTEDEPT.Caption = "EXECUTEDEPT";
            this.coldsQueryL3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coldsQueryL3DataTableEXECUTEDEPT.DefaultValue = "";
            this.coldsQueryL3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coldsQueryL3DataTableCREATEDATE
            // 
            this.coldsQueryL3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coldsQueryL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsQueryL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsQueryL3DataTablePLANEXECUTEDATE
            // 
            this.coldsQueryL3DataTablePLANEXECUTEDATE.Caption = "PLANEXECUTEDATE";
            this.coldsQueryL3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coldsQueryL3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coldsQueryL3DataTableACTUALEXECUTEDATE
            // 
            this.coldsQueryL3DataTableACTUALEXECUTEDATE.Caption = "ACTUALEXECUTEDATE";
            this.coldsQueryL3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coldsQueryL3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coldsQueryL3DataTablePLANNER
            // 
            this.coldsQueryL3DataTablePLANNER.Caption = "PLANNER";
            this.coldsQueryL3DataTablePLANNER.ColumnName = "PLANNER";
            this.coldsQueryL3DataTablePLANNER.DefaultValue = "";
            this.coldsQueryL3DataTablePLANNER.Namespace = "";
            // 
            // coldsQueryL3DataTableLENGTH
            // 
            this.coldsQueryL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsQueryL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsQueryL3DataTableLENGTH.DataType = typeof(int);
            this.coldsQueryL3DataTableLENGTH.DefaultValue = 0;
            this.coldsQueryL3DataTableLENGTH.Namespace = "";
            // 
            // coldsQueryL3DataTableWIDTH
            // 
            this.coldsQueryL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsQueryL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsQueryL3DataTableWIDTH.DataType = typeof(int);
            this.coldsQueryL3DataTableWIDTH.DefaultValue = 0;
            this.coldsQueryL3DataTableWIDTH.Namespace = "";
            // 
            // coldsQueryL3DataTableTHICKNESS
            // 
            this.coldsQueryL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsQueryL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsQueryL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsQueryL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsQueryL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsQueryL3DataTableSTEELGRADE
            // 
            this.coldsQueryL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsQueryL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsQueryL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsQueryL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsQueryL3DataTableUNIT
            // 
            this.coldsQueryL3DataTableUNIT.Caption = "UNIT";
            this.coldsQueryL3DataTableUNIT.ColumnName = "UNIT";
            this.coldsQueryL3DataTableUNIT.DefaultValue = "";
            this.coldsQueryL3DataTableUNIT.Namespace = "";
            // 
            // coldsQueryL3DataTableASSIST_UNIT
            // 
            this.coldsQueryL3DataTableASSIST_UNIT.Caption = "ASSIST_UNIT";
            this.coldsQueryL3DataTableASSIST_UNIT.ColumnName = "ASSIST_UNIT";
            this.coldsQueryL3DataTableASSIST_UNIT.DefaultValue = "";
            this.coldsQueryL3DataTableASSIST_UNIT.Namespace = "";
            // 
            // coldsQueryL3DataTableWEIGHT
            // 
            this.coldsQueryL3DataTableWEIGHT.Caption = "WEIGHT";
            this.coldsQueryL3DataTableWEIGHT.ColumnName = "WEIGHT";
            this.coldsQueryL3DataTableWEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableWEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableWEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTableASSISI_WEIGHT
            // 
            this.coldsQueryL3DataTableASSISI_WEIGHT.Caption = "ASSISI_WEIGHT";
            this.coldsQueryL3DataTableASSISI_WEIGHT.ColumnName = "ASSISI_WEIGHT";
            this.coldsQueryL3DataTableASSISI_WEIGHT.DataType = typeof(double);
            this.coldsQueryL3DataTableASSISI_WEIGHT.DefaultValue = 0;
            this.coldsQueryL3DataTableASSISI_WEIGHT.Namespace = "";
            // 
            // coldsQueryL3DataTablePLANREC_DATE
            // 
            this.coldsQueryL3DataTablePLANREC_DATE.Caption = "PLANREC_DATE";
            this.coldsQueryL3DataTablePLANREC_DATE.ColumnName = "PLANREC_DATE";
            this.coldsQueryL3DataTablePLANREC_DATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTablePLANREC_DATE.Namespace = "";
            // 
            // coldsQueryL3DataTableREQUEST_DATE
            // 
            this.coldsQueryL3DataTableREQUEST_DATE.Caption = "REQUEST_DATE";
            this.coldsQueryL3DataTableREQUEST_DATE.ColumnName = "REQUEST_DATE";
            this.coldsQueryL3DataTableREQUEST_DATE.DataType = typeof(System.DateTime);
            this.coldsQueryL3DataTableREQUEST_DATE.Namespace = "";
            // 
            // coldsQueryL3DataTableCORP
            // 
            this.coldsQueryL3DataTableCORP.Caption = "CORP";
            this.coldsQueryL3DataTableCORP.ColumnName = "CORP";
            this.coldsQueryL3DataTableCORP.DefaultValue = "";
            this.coldsQueryL3DataTableCORP.Namespace = "";
            // 
            // coldsQueryL3DataTableFACTORY
            // 
            this.coldsQueryL3DataTableFACTORY.Caption = "FACTORY";
            this.coldsQueryL3DataTableFACTORY.ColumnName = "FACTORY";
            this.coldsQueryL3DataTableFACTORY.DefaultValue = "";
            this.coldsQueryL3DataTableFACTORY.Namespace = "";
            // 
            // coldsQueryL3DataTableWORK_CENTER
            // 
            this.coldsQueryL3DataTableWORK_CENTER.Caption = "WORK_CENTER";
            this.coldsQueryL3DataTableWORK_CENTER.ColumnName = "WORK_CENTER";
            this.coldsQueryL3DataTableWORK_CENTER.DefaultValue = "";
            this.coldsQueryL3DataTableWORK_CENTER.Namespace = "";
            // 
            // coldsQueryL3DataTableCLIENT
            // 
            this.coldsQueryL3DataTableCLIENT.Caption = "CLIENT";
            this.coldsQueryL3DataTableCLIENT.ColumnName = "CLIENT";
            this.coldsQueryL3DataTableCLIENT.DefaultValue = "";
            this.coldsQueryL3DataTableCLIENT.Namespace = "";
            // 
            // coldsQueryL3DataTableTECH_REQUEST
            // 
            this.coldsQueryL3DataTableTECH_REQUEST.Caption = "TECH_REQUEST";
            this.coldsQueryL3DataTableTECH_REQUEST.ColumnName = "TECH_REQUEST";
            this.coldsQueryL3DataTableTECH_REQUEST.DefaultValue = "";
            this.coldsQueryL3DataTableTECH_REQUEST.Namespace = "";
            // 
            // coldsQueryL3DataTableINSIDE_NOTE
            // 
            this.coldsQueryL3DataTableINSIDE_NOTE.Caption = "INSIDE_NOTE";
            this.coldsQueryL3DataTableINSIDE_NOTE.ColumnName = "INSIDE_NOTE";
            this.coldsQueryL3DataTableINSIDE_NOTE.DefaultValue = "";
            this.coldsQueryL3DataTableINSIDE_NOTE.Namespace = "";
            // 
            // coldsQueryL3DataTableIMM_FLAG
            // 
            this.coldsQueryL3DataTableIMM_FLAG.Caption = "IMM_FLAG";
            this.coldsQueryL3DataTableIMM_FLAG.ColumnName = "IMM_FLAG";
            this.coldsQueryL3DataTableIMM_FLAG.DefaultValue = "";
            this.coldsQueryL3DataTableIMM_FLAG.Namespace = "";
            // 
            // coldsQueryL3DataTableCASTERID
            // 
            this.coldsQueryL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsQueryL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsQueryL3DataTableCASTERID.DefaultValue = "";
            this.coldsQueryL3DataTableCASTERID.Namespace = "";
            // 
            // coldsQueryL3DataTableNEW_BOF_FLAG
            // 
            this.coldsQueryL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsQueryL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsQueryL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsQueryL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsQueryL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnConfirm});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 27;
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
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // bdPlanOrdRec
            // 
            this.bdPlanOrdRec.AddNewItem = null;
            this.bdPlanOrdRec.AutoSize = false;
            this.bdPlanOrdRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdPlanOrdRec.BackgroundImage")));
            this.bdPlanOrdRec.BindingSource = this.bsPlanOrdRec;
            this.bdPlanOrdRec.CountItem = this.bindingNavigatorCountItem;
            this.bdPlanOrdRec.DeleteItem = null;
            this.bdPlanOrdRec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bdPlanOrdRec.Location = new System.Drawing.Point(0, 43);
            this.bdPlanOrdRec.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdPlanOrdRec.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdPlanOrdRec.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdPlanOrdRec.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdPlanOrdRec.Name = "bdPlanOrdRec";
            this.bdPlanOrdRec.PositionItem = this.bindingNavigatorPositionItem;
            this.bdPlanOrdRec.Size = new System.Drawing.Size(1000, 25);
            this.bdPlanOrdRec.TabIndex = 28;
            this.bdPlanOrdRec.Text = "bindingNavigator1";
            // 
            // bsPlanOrdRec
            // 
            this.bsPlanOrdRec.DataMember = "L3DataTable";
            this.bsPlanOrdRec.DataSource = this.dsPlanOrdRec;
            // 
            // dsPlanOrdRec
            // 
            this.dsPlanOrdRec.AutoLoad = true;
            this.dsPlanOrdRec.AutoSubscribe = true;
            this.dsPlanOrdRec.DataSetName = "L3DataSet";
            this.dsPlanOrdRec.DeleteMethod = "";
            this.dsPlanOrdRec.InsertMethod = "";
            this.dsPlanOrdRec.L3DataAdapter = this.Adapter;
            this.dsPlanOrdRec.LoadEvent = "Click";
            this.dsPlanOrdRec.LoadTrigger = null;
            this.dsPlanOrdRec.RefreshValve = 1000;
            this.dsPlanOrdRec.SourceCommand = null;
            this.dsPlanOrdRec.SourceCondition = null;
            this.dsPlanOrdRec.SourceMethod = "GetUnConfirmPlanOrder";
            this.dsPlanOrdRec.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsPlanOrdRec.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.dsPlanOrdRec.SubscribeTarget = null;
            this.dsPlanOrdRec.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsPlanOrdRec.UpdateEvent = "Click";
            this.dsPlanOrdRec.UpdateMethod = "";
            this.dsPlanOrdRec.UpdateTrigger = null;
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
            this.coll3DataSet1L3DataTableCheckFlag,
            this.coldsPlanOrdRecL3DataTableProtocol});
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
            // coll3DataSet1L3DataTableCheckFlag
            // 
            this.coll3DataSet1L3DataTableCheckFlag.Caption = "CheckFlag";
            this.coll3DataSet1L3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coll3DataSet1L3DataTableCheckFlag.DataType = typeof(short);
            this.coll3DataSet1L3DataTableCheckFlag.Namespace = "";
            // 
            // coldsPlanOrdRecL3DataTableProtocol
            // 
            this.coldsPlanOrdRecL3DataTableProtocol.Caption = "Protocol";
            this.coldsPlanOrdRecL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsPlanOrdRecL3DataTableProtocol.Namespace = "";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvPlanOrdRec);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvPlanOrdRec
            // 
            this.dvPlanOrdRec.AllowUserToAddRows = false;
            this.dvPlanOrdRec.AutoGenerateColumns = false;
            this.dvPlanOrdRec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvPlanOrdRec.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvPlanOrdRec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.pLANIDDataGridViewTextBoxColumn,
            this.cONTRACTIDDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.pLANDEPTDataGridViewTextBoxColumn,
            this.eXECUTEDEPTDataGridViewTextBoxColumn,
            this.cREATEDATEDataGridViewTextBoxColumn,
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn,
            this.aCTUALEXECUTEDATEDataGridViewTextBoxColumn,
            this.pLANNERDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.Protocol,
            this.uNITDataGridViewTextBoxColumn,
            this.aSSISTUNITDataGridViewTextBoxColumn,
            this.wEIGHTDataGridViewTextBoxColumn,
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
            this.cASTERIDDataGridViewTextBoxColumn,
            this.nEWBOFFLAGDataGridViewTextBoxColumn});
            this.dvPlanOrdRec.DataSource = this.bsPlanOrdRec;
            this.dvPlanOrdRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvPlanOrdRec.Location = new System.Drawing.Point(0, 0);
            this.dvPlanOrdRec.Name = "dvPlanOrdRec";
            this.dvPlanOrdRec.RowHeadersVisible = false;
            this.dvPlanOrdRec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvPlanOrdRec.RowTemplate.Height = 23;
            this.dvPlanOrdRec.Size = new System.Drawing.Size(996, 628);
            this.dvPlanOrdRec.TabIndex = 0;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CheckFlag";
            this.dataGridViewTextBoxColumn1.FalseValue = "0";
            this.dataGridViewTextBoxColumn1.HeaderText = "选择";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.TrueValue = "1";
            // 
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "计划号";
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
            this.lENGTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Protocol
            // 
            this.Protocol.DataPropertyName = "Protocol";
            this.Protocol.HeaderText = "协议";
            this.Protocol.Name = "Protocol";
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aSSISTUNITDataGridViewTextBoxColumn
            // 
            this.aSSISTUNITDataGridViewTextBoxColumn.DataPropertyName = "ASSIST_UNIT";
            this.aSSISTUNITDataGridViewTextBoxColumn.HeaderText = "辅计量单位";
            this.aSSISTUNITDataGridViewTextBoxColumn.Name = "aSSISTUNITDataGridViewTextBoxColumn";
            this.aSSISTUNITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT";
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "计划数量";
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            this.wEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nEWBOFFLAGDataGridViewTextBoxColumn
            // 
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataPropertyName = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.HeaderText = "转炉标志";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Name = "nEWBOFFLAGDataGridViewTextBoxColumn";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = null;
            this.l3CommandParameter8.SourceObject = this.dsQuery;
            this.l3CommandParameter8.SourceProperty = null;
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
            // l3CommandParameter10
            // 
            this.l3CommandParameter10.AcceptAfterExecuted = false;
            this.l3CommandParameter10.ConstantValue = null;
            this.l3CommandParameter10.MergeTarget = false;
            this.l3CommandParameter10.SourceFilter = null;
            this.l3CommandParameter10.SourceObject = null;
            this.l3CommandParameter10.SourceProperty = null;
            this.l3CommandParameter10.TargetObject = null;
            this.l3CommandParameter10.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "CheckFlag=1";
            this.l3CommandParameter1.SourceObject = this.bdPlanOrdRec;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter12
            // 
            this.l3CommandParameter12.AcceptAfterExecuted = false;
            this.l3CommandParameter12.ConstantValue = null;
            this.l3CommandParameter12.MergeTarget = false;
            this.l3CommandParameter12.SourceFilter = null;
            this.l3CommandParameter12.SourceObject = this.dsQuery;
            this.l3CommandParameter12.SourceProperty = null;
            this.l3CommandParameter12.TargetObject = null;
            this.l3CommandParameter12.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.bdPlanOrdRec;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
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
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = null;
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
            // l3CommandParameter11
            // 
            this.l3CommandParameter11.AcceptAfterExecuted = false;
            this.l3CommandParameter11.ConstantValue = null;
            this.l3CommandParameter11.MergeTarget = false;
            this.l3CommandParameter11.SourceFilter = null;
            this.l3CommandParameter11.SourceObject = this.dsQuery;
            this.l3CommandParameter11.SourceProperty = "L3Data";
            this.l3CommandParameter11.TargetObject = null;
            this.l3CommandParameter11.TargetProperty = null;
            // 
            // l3CommandParameter13
            // 
            this.l3CommandParameter13.AcceptAfterExecuted = false;
            this.l3CommandParameter13.ConstantValue = null;
            this.l3CommandParameter13.MergeTarget = false;
            this.l3CommandParameter13.SourceFilter = null;
            this.l3CommandParameter13.SourceObject = null;
            this.l3CommandParameter13.SourceProperty = "PlanID=\'\'";
            this.l3CommandParameter13.TargetObject = null;
            this.l3CommandParameter13.TargetProperty = null;
            // 
            // cmdPlanOrdRec
            // 
            this.cmdPlanOrdRec.Adapter = this.Adapter;
            this.cmdPlanOrdRec.MergeReturnTarget = false;
            this.cmdPlanOrdRec.Method = "PlanOrdCfm";
            this.cmdPlanOrdRec.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdPlanOrdRec.Parameters.Add(this.l3CommandParameter16);
            this.cmdPlanOrdRec.ReturnTarget = null;
            this.cmdPlanOrdRec.ReturnTargetProperty = null;
            this.cmdPlanOrdRec.Trigger = null;
            this.cmdPlanOrdRec.TriggerEvent = "Click";
            // 
            // l3CommandParameter16
            // 
            this.l3CommandParameter16.AcceptAfterExecuted = false;
            this.l3CommandParameter16.ConstantValue = null;
            this.l3CommandParameter16.MergeTarget = false;
            this.l3CommandParameter16.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter16.SourceObject = this.dsPlanOrdRec;
            this.l3CommandParameter16.SourceProperty = "L3DataTable";
            this.l3CommandParameter16.TargetObject = null;
            this.l3CommandParameter16.TargetProperty = null;
            // 
            // l3CommandParameter15
            // 
            this.l3CommandParameter15.AcceptAfterExecuted = false;
            this.l3CommandParameter15.ConstantValue = null;
            this.l3CommandParameter15.MergeTarget = false;
            this.l3CommandParameter15.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter15.SourceObject = null;
            this.l3CommandParameter15.SourceProperty = "L3DataTable";
            this.l3CommandParameter15.TargetObject = null;
            this.l3CommandParameter15.TargetProperty = null;
            // 
            // l3CommandParameter14
            // 
            this.l3CommandParameter14.AcceptAfterExecuted = false;
            this.l3CommandParameter14.ConstantValue = null;
            this.l3CommandParameter14.MergeTarget = false;
            this.l3CommandParameter14.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter14.SourceObject = null;
            this.l3CommandParameter14.SourceProperty = "L3DataTable";
            this.l3CommandParameter14.TargetObject = null;
            this.l3CommandParameter14.TargetProperty = null;
            // 
            // coldsPlanOrdRecL3DataTableCheckFlag
            // 
            this.coldsPlanOrdRecL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsPlanOrdRecL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsPlanOrdRecL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsPlanOrdRecL3DataTableCheckFlag.Namespace = "";
            // 
            // PlanOrdRecFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdPlanOrdRec);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanOrdRecFrm";
            this.TabText = "计划订单确认";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanOrdRecFrm_FormClosing);
            this.Load += new System.EventHandler(this.PlanOrdRecFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsQuery)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdPlanOrdRec)).EndInit();
            this.bdPlanOrdRec.ResumeLayout(false);
            this.bdPlanOrdRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanOrdRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanOrdRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanOrdRec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.BindingNavigator bdPlanOrdRec;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvPlanOrdRec;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsQuery;
        private System.Data.DataTable schemadsQuery;
        private System.Data.DataColumn coldsQueryL3DataTableGUID;
        private System.Data.DataColumn coldsQueryL3DataTableNAME;
        private System.Data.DataColumn coldsQueryL3DataTablePLANID;
        private System.Data.DataColumn coldsQueryL3DataTableCONTRACTID;
        private System.Data.DataColumn coldsQueryL3DataTableSTATUS;
        private System.Data.DataColumn coldsQueryL3DataTablePLANDEPT;
        private System.Data.DataColumn coldsQueryL3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coldsQueryL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsQueryL3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coldsQueryL3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coldsQueryL3DataTablePLANNER;
        private System.Data.DataColumn coldsQueryL3DataTableLENGTH;
        private System.Data.DataColumn coldsQueryL3DataTableWIDTH;
        private System.Data.DataColumn coldsQueryL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsQueryL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsQueryL3DataTableUNIT;
        private System.Data.DataColumn coldsQueryL3DataTableASSIST_UNIT;
        private System.Data.DataColumn coldsQueryL3DataTableWEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTableASSISI_WEIGHT;
        private System.Data.DataColumn coldsQueryL3DataTablePLANREC_DATE;
        private System.Data.DataColumn coldsQueryL3DataTableREQUEST_DATE;
        private System.Data.DataColumn coldsQueryL3DataTableCORP;
        private System.Data.DataColumn coldsQueryL3DataTableFACTORY;
        private System.Data.DataColumn coldsQueryL3DataTableWORK_CENTER;
        private System.Data.DataColumn coldsQueryL3DataTableCLIENT;
        private System.Data.DataColumn coldsQueryL3DataTableTECH_REQUEST;
        private System.Data.DataColumn coldsQueryL3DataTableINSIDE_NOTE;
        private System.Data.DataColumn coldsQueryL3DataTableIMM_FLAG;
        private System.Data.DataColumn coldsQueryL3DataTableCASTERID;
        private System.Data.DataColumn coldsQueryL3DataTableNEW_BOF_FLAG;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
        private AppSvrHMI.L3CommandParameter l3CommandParameter11;
        private AppSvrHMI.L3CommandParameter l3CommandParameter12;
        private AppSvrHMI.L3CommandParameter l3CommandParameter13;
        private System.Windows.Forms.BindingSource bsPlanOrdRec;
        private AppSvrHMI.L3Command cmdPlanOrdRec;
        private AppSvrHMI.L3CommandParameter l3CommandParameter14;
        private System.Data.DataColumn coldsPlanOrdRecL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter15;
        private AppSvrHMI.L3DataSet dsPlanOrdRec;
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
        private System.Data.DataColumn coll3DataSet1L3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter16;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsPlanOrdRecL3DataTableProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXECUTEDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTUALEXECUTEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSISTUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nEWBOFFLAGDataGridViewTextBoxColumn;
    }
}