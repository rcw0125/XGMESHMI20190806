namespace PlanMag
{
    partial class GenCastingPlanFrm
    {/// <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenCastingPlanFrm));
            this.bsGenCasting = new System.Windows.Forms.BindingSource(this.components);
            this.dsGenCasting = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClosePlan = new System.Windows.Forms.ToolStripButton();
            this.btnSteelLess = new System.Windows.Forms.ToolStripButton();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.tstdtpBeginDate = new buttonHide.ToolStripToriDateTimePicker();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tstdtpEndDate = new buttonHide.ToolStripToriDateTimePicker();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.tscmbSteelGrade = new System.Windows.Forms.ToolStripComboBox();
            this.schemadsGenCasting = new System.Data.DataTable();
            this.coldsGenCastingL3DataTableGUID = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableNAME = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablePLANID = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCONTRACTID = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablePLANDEPT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableEXECUTEDEPT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCREATEDATE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablePLANNER = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableUNIT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableASSIST_UNIT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableWEIGHT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableASSISI_WEIGHT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablePLANREC_DATE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableREQUEST_DATE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCORP = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableFACTORY = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableWORK_CENTER = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCLIENT = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableTECH_REQUEST = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableINSIDE_NOTE = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableIMM_FLAG = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableSTD = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableProtocol = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableActWeight = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableSpareWeight = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableProduceStd = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableMaterialCode = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableProduct_Route = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableOther_Tech_Request = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTablepk_poid = new System.Data.DataColumn();
            this.coldsGenCastingL3DataTableMaterialCode_ID = new System.Data.DataColumn();
            this.tstxtGenCasting = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripLabel();
            this.cmdGenCasting = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter11 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter12 = new AppSvrHMI.L3CommandParameter();
            this.L3cmdpGenCasting = new AppSvrHMI.L3CommandParameter();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvGenCasting = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.pLANIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpareWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tECHREQUESTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Tech_Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pLANDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXECUTEDEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.iNSIDENOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMMFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nEWBOFFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFFlag = new AppSvrHMI.L3DataSet();
            this.schemadsBOFFlag = new System.Data.DataTable();
            this.coldsBOFFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pk_poid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.cmdIntegrateCancel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.cmdDel = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.cmdClose = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter10 = new AppSvrHMI.L3CommandParameter();
            this.cmdSteelLess = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter13 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter14 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGenCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGenCasting)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGenCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsGenCasting
            // 
            this.bsGenCasting.DataMember = "L3DataTable";
            this.bsGenCasting.DataSource = this.dsGenCasting;
            // 
            // dsGenCasting
            // 
            this.dsGenCasting.AutoLoad = true;
            this.dsGenCasting.AutoSubscribe = true;
            this.dsGenCasting.DataSetName = "dsGenCasting";
            this.dsGenCasting.DeleteMethod = "";
            this.dsGenCasting.InsertMethod = "";
            this.dsGenCasting.L3DataAdapter = this.Adapter;
            this.dsGenCasting.LoadEvent = "Click";
            this.dsGenCasting.LoadTrigger = null;
            this.dsGenCasting.RefreshValve = 1000;
            this.dsGenCasting.SourceCommand = this.cmdQuery;
            this.dsGenCasting.SourceCondition = null;
            this.dsGenCasting.SourceMethod = "GetIntegratedPlanOrd";
            this.dsGenCasting.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsGenCasting.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.dsGenCasting.SubscribeTarget = null;
            this.dsGenCasting.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGenCasting});
            this.dsGenCasting.UpdateEvent = "Click";
            this.dsGenCasting.UpdateMethod = "";
            this.dsGenCasting.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BtnCastingPlanGen");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 40);
            this.btnConfirm.Text = "浇钢计划排产";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "BtnCastingPlanGen");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(113, 40);
            this.btnDel.Text = "删除计划订单";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClosePlan
            // 
            this.Adapter.SetAccessRight(this.btnClosePlan, "BtnCastingPlanGen");
            this.btnClosePlan.Image = ((System.Drawing.Image)(resources.GetObject("btnClosePlan.Image")));
            this.btnClosePlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClosePlan.Name = "btnClosePlan";
            this.btnClosePlan.Size = new System.Drawing.Size(113, 40);
            this.btnClosePlan.Text = "关闭计划订单";
            this.btnClosePlan.Click += new System.EventHandler(this.btnClosePlan_Click);
            // 
            // btnSteelLess
            // 
            this.Adapter.SetAccessRight(this.btnSteelLess, "BtnCastingPlanGen");
            this.btnSteelLess.Image = ((System.Drawing.Image)(resources.GetObject("btnSteelLess.Image")));
            this.btnSteelLess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSteelLess.Name = "btnSteelLess";
            this.btnSteelLess.Size = new System.Drawing.Size(125, 40);
            this.btnSteelLess.Text = "不锈钢计划排产";
            this.btnSteelLess.Click += new System.EventHandler(this.btnSteelLess_Click);
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = this.Adapter;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "GetIntegratedPlanOrd";
            this.cmdQuery.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdQuery.Parameters.Add(this.l3CommandParameter3);
            this.cmdQuery.Parameters.Add(this.l3CommandParameter4);
            this.cmdQuery.Parameters.Add(this.l3CommandParameter8);
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
            this.l3CommandParameter3.SourceObject = this.tstdtpBeginDate;
            this.l3CommandParameter3.SourceProperty = "Text";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // tstdtpBeginDate
            // 
            this.tstdtpBeginDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstdtpBeginDate.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tstdtpBeginDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tstdtpBeginDate.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tstdtpBeginDate.CustomFormat = "yyyy-MM-dd";
            this.tstdtpBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tstdtpBeginDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tstdtpBeginDate.MaximumSize = new System.Drawing.Size(0, 0);
            this.tstdtpBeginDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tstdtpBeginDate.MinimumSize = new System.Drawing.Size(0, 0);
            this.tstdtpBeginDate.Name = "tstdtpBeginDate";
            this.tstdtpBeginDate.Size = new System.Drawing.Size(100, 22);
            this.tstdtpBeginDate.Text = "2008-10-28";
            this.tstdtpBeginDate.Value = new System.DateTime(2008, 10, 28, 11, 28, 28, 220);
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.tstdtpEndDate;
            this.l3CommandParameter4.SourceProperty = "Text";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // tstdtpEndDate
            // 
            this.tstdtpEndDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstdtpEndDate.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tstdtpEndDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tstdtpEndDate.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tstdtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.tstdtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tstdtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tstdtpEndDate.MaximumSize = new System.Drawing.Size(0, 0);
            this.tstdtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tstdtpEndDate.MinimumSize = new System.Drawing.Size(0, 0);
            this.tstdtpEndDate.Name = "tstdtpEndDate";
            this.tstdtpEndDate.Size = new System.Drawing.Size(100, 22);
            this.tstdtpEndDate.Text = "2008-10-28";
            this.tstdtpEndDate.Value = new System.DateTime(2008, 10, 28, 11, 28, 28, 220);
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = null;
            this.l3CommandParameter8.SourceObject = this.tscmbSteelGrade;
            this.l3CommandParameter8.SourceProperty = "Text";
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // tscmbSteelGrade
            // 
            this.tscmbSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbSteelGrade.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbSteelGrade.Name = "tscmbSteelGrade";
            this.tscmbSteelGrade.Size = new System.Drawing.Size(121, 25);
            // 
            // schemadsGenCasting
            // 
            this.schemadsGenCasting.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGenCastingL3DataTableGUID,
            this.coldsGenCastingL3DataTableNAME,
            this.coldsGenCastingL3DataTablePLANID,
            this.coldsGenCastingL3DataTableCONTRACTID,
            this.coldsGenCastingL3DataTableSTATUS,
            this.coldsGenCastingL3DataTablePLANDEPT,
            this.coldsGenCastingL3DataTableEXECUTEDEPT,
            this.coldsGenCastingL3DataTableCREATEDATE,
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE,
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE,
            this.coldsGenCastingL3DataTablePLANNER,
            this.coldsGenCastingL3DataTableLENGTH,
            this.coldsGenCastingL3DataTableWIDTH,
            this.coldsGenCastingL3DataTableTHICKNESS,
            this.coldsGenCastingL3DataTableSTEELGRADE,
            this.coldsGenCastingL3DataTableUNIT,
            this.coldsGenCastingL3DataTableASSIST_UNIT,
            this.coldsGenCastingL3DataTableWEIGHT,
            this.coldsGenCastingL3DataTableASSISI_WEIGHT,
            this.coldsGenCastingL3DataTablePLANREC_DATE,
            this.coldsGenCastingL3DataTableREQUEST_DATE,
            this.coldsGenCastingL3DataTableCORP,
            this.coldsGenCastingL3DataTableFACTORY,
            this.coldsGenCastingL3DataTableWORK_CENTER,
            this.coldsGenCastingL3DataTableCLIENT,
            this.coldsGenCastingL3DataTableTECH_REQUEST,
            this.coldsGenCastingL3DataTableINSIDE_NOTE,
            this.coldsGenCastingL3DataTableIMM_FLAG,
            this.coldsGenCastingL3DataTableCASTERID,
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG,
            this.coldsGenCastingL3DataTableSTD,
            this.coldsGenCastingL3DataTableCheckFlag,
            this.coldsGenCastingL3DataTableProtocol,
            this.coldsGenCastingL3DataTableActWeight,
            this.coldsGenCastingL3DataTableSpareWeight,
            this.coldsGenCastingL3DataTableProduceStd,
            this.coldsGenCastingL3DataTableMaterialCode,
            this.coldsGenCastingL3DataTableProduct_Route,
            this.coldsGenCastingL3DataTableOther_Tech_Request,
            this.coldsGenCastingL3DataTablepk_poid,
            this.coldsGenCastingL3DataTableMaterialCode_ID});
            this.schemadsGenCasting.TableName = "L3DataTable";
            // 
            // coldsGenCastingL3DataTableGUID
            // 
            this.coldsGenCastingL3DataTableGUID.Caption = "GUID";
            this.coldsGenCastingL3DataTableGUID.ColumnName = "GUID";
            this.coldsGenCastingL3DataTableGUID.DefaultValue = "";
            this.coldsGenCastingL3DataTableGUID.Namespace = "";
            // 
            // coldsGenCastingL3DataTableNAME
            // 
            this.coldsGenCastingL3DataTableNAME.Caption = "NAME";
            this.coldsGenCastingL3DataTableNAME.ColumnName = "NAME";
            this.coldsGenCastingL3DataTableNAME.DefaultValue = "";
            this.coldsGenCastingL3DataTableNAME.Namespace = "";
            // 
            // coldsGenCastingL3DataTablePLANID
            // 
            this.coldsGenCastingL3DataTablePLANID.Caption = "PLANID";
            this.coldsGenCastingL3DataTablePLANID.ColumnName = "PLANID";
            this.coldsGenCastingL3DataTablePLANID.DefaultValue = "";
            this.coldsGenCastingL3DataTablePLANID.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCONTRACTID
            // 
            this.coldsGenCastingL3DataTableCONTRACTID.Caption = "CONTRACTID";
            this.coldsGenCastingL3DataTableCONTRACTID.ColumnName = "CONTRACTID";
            this.coldsGenCastingL3DataTableCONTRACTID.DefaultValue = "";
            this.coldsGenCastingL3DataTableCONTRACTID.Namespace = "";
            // 
            // coldsGenCastingL3DataTableSTATUS
            // 
            this.coldsGenCastingL3DataTableSTATUS.Caption = "STATUS";
            this.coldsGenCastingL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsGenCastingL3DataTableSTATUS.DataType = typeof(int);
            this.coldsGenCastingL3DataTableSTATUS.DefaultValue = 0;
            this.coldsGenCastingL3DataTableSTATUS.Namespace = "";
            // 
            // coldsGenCastingL3DataTablePLANDEPT
            // 
            this.coldsGenCastingL3DataTablePLANDEPT.Caption = "PLANDEPT";
            this.coldsGenCastingL3DataTablePLANDEPT.ColumnName = "PLANDEPT";
            this.coldsGenCastingL3DataTablePLANDEPT.DefaultValue = "";
            this.coldsGenCastingL3DataTablePLANDEPT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableEXECUTEDEPT
            // 
            this.coldsGenCastingL3DataTableEXECUTEDEPT.Caption = "EXECUTEDEPT";
            this.coldsGenCastingL3DataTableEXECUTEDEPT.ColumnName = "EXECUTEDEPT";
            this.coldsGenCastingL3DataTableEXECUTEDEPT.DefaultValue = "";
            this.coldsGenCastingL3DataTableEXECUTEDEPT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCREATEDATE
            // 
            this.coldsGenCastingL3DataTableCREATEDATE.Caption = "CREATEDATE";
            this.coldsGenCastingL3DataTableCREATEDATE.ColumnName = "CREATEDATE";
            this.coldsGenCastingL3DataTableCREATEDATE.DataType = typeof(System.DateTime);
            this.coldsGenCastingL3DataTableCREATEDATE.Namespace = "";
            // 
            // coldsGenCastingL3DataTablePLANEXECUTEDATE
            // 
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE.Caption = "PLANEXECUTEDATE";
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE.ColumnName = "PLANEXECUTEDATE";
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsGenCastingL3DataTablePLANEXECUTEDATE.Namespace = "";
            // 
            // coldsGenCastingL3DataTableACTUALEXECUTEDATE
            // 
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE.Caption = "ACTUALEXECUTEDATE";
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE.ColumnName = "ACTUALEXECUTEDATE";
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE.DataType = typeof(System.DateTime);
            this.coldsGenCastingL3DataTableACTUALEXECUTEDATE.Namespace = "";
            // 
            // coldsGenCastingL3DataTablePLANNER
            // 
            this.coldsGenCastingL3DataTablePLANNER.Caption = "PLANNER";
            this.coldsGenCastingL3DataTablePLANNER.ColumnName = "PLANNER";
            this.coldsGenCastingL3DataTablePLANNER.DefaultValue = "";
            this.coldsGenCastingL3DataTablePLANNER.Namespace = "";
            // 
            // coldsGenCastingL3DataTableLENGTH
            // 
            this.coldsGenCastingL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsGenCastingL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsGenCastingL3DataTableLENGTH.DataType = typeof(int);
            this.coldsGenCastingL3DataTableLENGTH.DefaultValue = 0;
            this.coldsGenCastingL3DataTableLENGTH.Namespace = "";
            // 
            // coldsGenCastingL3DataTableWIDTH
            // 
            this.coldsGenCastingL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsGenCastingL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsGenCastingL3DataTableWIDTH.DataType = typeof(int);
            this.coldsGenCastingL3DataTableWIDTH.DefaultValue = 0;
            this.coldsGenCastingL3DataTableWIDTH.Namespace = "";
            // 
            // coldsGenCastingL3DataTableTHICKNESS
            // 
            this.coldsGenCastingL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsGenCastingL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsGenCastingL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsGenCastingL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsGenCastingL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsGenCastingL3DataTableSTEELGRADE
            // 
            this.coldsGenCastingL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsGenCastingL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsGenCastingL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsGenCastingL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsGenCastingL3DataTableUNIT
            // 
            this.coldsGenCastingL3DataTableUNIT.Caption = "UNIT";
            this.coldsGenCastingL3DataTableUNIT.ColumnName = "UNIT";
            this.coldsGenCastingL3DataTableUNIT.DefaultValue = "";
            this.coldsGenCastingL3DataTableUNIT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableASSIST_UNIT
            // 
            this.coldsGenCastingL3DataTableASSIST_UNIT.Caption = "ASSIST_UNIT";
            this.coldsGenCastingL3DataTableASSIST_UNIT.ColumnName = "ASSIST_UNIT";
            this.coldsGenCastingL3DataTableASSIST_UNIT.DefaultValue = "";
            this.coldsGenCastingL3DataTableASSIST_UNIT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableWEIGHT
            // 
            this.coldsGenCastingL3DataTableWEIGHT.Caption = "WEIGHT";
            this.coldsGenCastingL3DataTableWEIGHT.ColumnName = "WEIGHT";
            this.coldsGenCastingL3DataTableWEIGHT.DataType = typeof(double);
            this.coldsGenCastingL3DataTableWEIGHT.DefaultValue = 0;
            this.coldsGenCastingL3DataTableWEIGHT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableASSISI_WEIGHT
            // 
            this.coldsGenCastingL3DataTableASSISI_WEIGHT.Caption = "ASSISI_WEIGHT";
            this.coldsGenCastingL3DataTableASSISI_WEIGHT.ColumnName = "ASSISI_WEIGHT";
            this.coldsGenCastingL3DataTableASSISI_WEIGHT.DataType = typeof(double);
            this.coldsGenCastingL3DataTableASSISI_WEIGHT.DefaultValue = 0;
            this.coldsGenCastingL3DataTableASSISI_WEIGHT.Namespace = "";
            // 
            // coldsGenCastingL3DataTablePLANREC_DATE
            // 
            this.coldsGenCastingL3DataTablePLANREC_DATE.Caption = "PLANREC_DATE";
            this.coldsGenCastingL3DataTablePLANREC_DATE.ColumnName = "PLANREC_DATE";
            this.coldsGenCastingL3DataTablePLANREC_DATE.DataType = typeof(System.DateTime);
            this.coldsGenCastingL3DataTablePLANREC_DATE.Namespace = "";
            // 
            // coldsGenCastingL3DataTableREQUEST_DATE
            // 
            this.coldsGenCastingL3DataTableREQUEST_DATE.Caption = "REQUEST_DATE";
            this.coldsGenCastingL3DataTableREQUEST_DATE.ColumnName = "REQUEST_DATE";
            this.coldsGenCastingL3DataTableREQUEST_DATE.DataType = typeof(System.DateTime);
            this.coldsGenCastingL3DataTableREQUEST_DATE.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCORP
            // 
            this.coldsGenCastingL3DataTableCORP.Caption = "CORP";
            this.coldsGenCastingL3DataTableCORP.ColumnName = "CORP";
            this.coldsGenCastingL3DataTableCORP.DefaultValue = "";
            this.coldsGenCastingL3DataTableCORP.Namespace = "";
            // 
            // coldsGenCastingL3DataTableFACTORY
            // 
            this.coldsGenCastingL3DataTableFACTORY.Caption = "FACTORY";
            this.coldsGenCastingL3DataTableFACTORY.ColumnName = "FACTORY";
            this.coldsGenCastingL3DataTableFACTORY.DefaultValue = "";
            this.coldsGenCastingL3DataTableFACTORY.Namespace = "";
            // 
            // coldsGenCastingL3DataTableWORK_CENTER
            // 
            this.coldsGenCastingL3DataTableWORK_CENTER.Caption = "WORK_CENTER";
            this.coldsGenCastingL3DataTableWORK_CENTER.ColumnName = "WORK_CENTER";
            this.coldsGenCastingL3DataTableWORK_CENTER.DefaultValue = "";
            this.coldsGenCastingL3DataTableWORK_CENTER.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCLIENT
            // 
            this.coldsGenCastingL3DataTableCLIENT.Caption = "CLIENT";
            this.coldsGenCastingL3DataTableCLIENT.ColumnName = "CLIENT";
            this.coldsGenCastingL3DataTableCLIENT.DefaultValue = "";
            this.coldsGenCastingL3DataTableCLIENT.Namespace = "";
            // 
            // coldsGenCastingL3DataTableTECH_REQUEST
            // 
            this.coldsGenCastingL3DataTableTECH_REQUEST.Caption = "TECH_REQUEST";
            this.coldsGenCastingL3DataTableTECH_REQUEST.ColumnName = "TECH_REQUEST";
            this.coldsGenCastingL3DataTableTECH_REQUEST.DefaultValue = "";
            this.coldsGenCastingL3DataTableTECH_REQUEST.Namespace = "";
            // 
            // coldsGenCastingL3DataTableINSIDE_NOTE
            // 
            this.coldsGenCastingL3DataTableINSIDE_NOTE.Caption = "INSIDE_NOTE";
            this.coldsGenCastingL3DataTableINSIDE_NOTE.ColumnName = "INSIDE_NOTE";
            this.coldsGenCastingL3DataTableINSIDE_NOTE.DefaultValue = "";
            this.coldsGenCastingL3DataTableINSIDE_NOTE.Namespace = "";
            // 
            // coldsGenCastingL3DataTableIMM_FLAG
            // 
            this.coldsGenCastingL3DataTableIMM_FLAG.Caption = "IMM_FLAG";
            this.coldsGenCastingL3DataTableIMM_FLAG.ColumnName = "IMM_FLAG";
            this.coldsGenCastingL3DataTableIMM_FLAG.DefaultValue = "";
            this.coldsGenCastingL3DataTableIMM_FLAG.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCASTERID
            // 
            this.coldsGenCastingL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsGenCastingL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsGenCastingL3DataTableCASTERID.DefaultValue = "";
            this.coldsGenCastingL3DataTableCASTERID.Namespace = "";
            // 
            // coldsGenCastingL3DataTableNEW_BOF_FLAG
            // 
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG.Caption = "NEW_BOF_FLAG";
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG.ColumnName = "NEW_BOF_FLAG";
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG.DataType = typeof(int);
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG.DefaultValue = 0;
            this.coldsGenCastingL3DataTableNEW_BOF_FLAG.Namespace = "";
            // 
            // coldsGenCastingL3DataTableSTD
            // 
            this.coldsGenCastingL3DataTableSTD.Caption = "STD";
            this.coldsGenCastingL3DataTableSTD.ColumnName = "STD";
            this.coldsGenCastingL3DataTableSTD.DefaultValue = "";
            this.coldsGenCastingL3DataTableSTD.Namespace = "";
            // 
            // coldsGenCastingL3DataTableCheckFlag
            // 
            this.coldsGenCastingL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsGenCastingL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsGenCastingL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsGenCastingL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsGenCastingL3DataTableProtocol
            // 
            this.coldsGenCastingL3DataTableProtocol.Caption = "Protocol";
            this.coldsGenCastingL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsGenCastingL3DataTableProtocol.DefaultValue = "";
            this.coldsGenCastingL3DataTableProtocol.Namespace = "";
            // 
            // coldsGenCastingL3DataTableActWeight
            // 
            this.coldsGenCastingL3DataTableActWeight.Caption = "ActWeight";
            this.coldsGenCastingL3DataTableActWeight.ColumnName = "ActWeight";
            this.coldsGenCastingL3DataTableActWeight.DataType = typeof(double);
            this.coldsGenCastingL3DataTableActWeight.Namespace = "";
            // 
            // coldsGenCastingL3DataTableSpareWeight
            // 
            this.coldsGenCastingL3DataTableSpareWeight.Caption = "SpareWeight";
            this.coldsGenCastingL3DataTableSpareWeight.ColumnName = "SpareWeight";
            this.coldsGenCastingL3DataTableSpareWeight.DataType = typeof(double);
            this.coldsGenCastingL3DataTableSpareWeight.Namespace = "";
            // 
            // coldsGenCastingL3DataTableProduceStd
            // 
            this.coldsGenCastingL3DataTableProduceStd.Caption = "ProduceStd";
            this.coldsGenCastingL3DataTableProduceStd.ColumnName = "ProduceStd";
            this.coldsGenCastingL3DataTableProduceStd.Namespace = "";
            // 
            // coldsGenCastingL3DataTableMaterialCode
            // 
            this.coldsGenCastingL3DataTableMaterialCode.Caption = "MaterialCode";
            this.coldsGenCastingL3DataTableMaterialCode.ColumnName = "MaterialCode";
            this.coldsGenCastingL3DataTableMaterialCode.Namespace = "";
            // 
            // coldsGenCastingL3DataTableProduct_Route
            // 
            this.coldsGenCastingL3DataTableProduct_Route.Caption = "Product_Route";
            this.coldsGenCastingL3DataTableProduct_Route.ColumnName = "Product_Route";
            this.coldsGenCastingL3DataTableProduct_Route.Namespace = "";
            // 
            // coldsGenCastingL3DataTableOther_Tech_Request
            // 
            this.coldsGenCastingL3DataTableOther_Tech_Request.Caption = "Other_Tech_Request";
            this.coldsGenCastingL3DataTableOther_Tech_Request.ColumnName = "Other_Tech_Request";
            this.coldsGenCastingL3DataTableOther_Tech_Request.Namespace = "";
            // 
            // coldsGenCastingL3DataTablepk_poid
            // 
            this.coldsGenCastingL3DataTablepk_poid.Caption = "pk_poid";
            this.coldsGenCastingL3DataTablepk_poid.ColumnName = "pk_poid";
            this.coldsGenCastingL3DataTablepk_poid.Namespace = "";
            // 
            // coldsGenCastingL3DataTableMaterialCode_ID
            // 
            this.coldsGenCastingL3DataTableMaterialCode_ID.Caption = "MaterialCode_ID";
            this.coldsGenCastingL3DataTableMaterialCode_ID.ColumnName = "MaterialCode_ID";
            this.coldsGenCastingL3DataTableMaterialCode_ID.Namespace = "";
            // 
            // tstxtGenCasting
            // 
            this.tstxtGenCasting.Name = "tstxtGenCasting";
            this.tstxtGenCasting.Size = new System.Drawing.Size(100, 21);
            this.tstxtGenCasting.Visible = false;
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(45, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmdGenCasting
            // 
            this.cmdGenCasting.Adapter = this.Adapter;
            this.cmdGenCasting.MergeReturnTarget = false;
            this.cmdGenCasting.Method = "NewCastingPlanGen";
            this.cmdGenCasting.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdGenCasting.Parameters.Add(this.l3CommandParameter11);
            this.cmdGenCasting.Parameters.Add(this.l3CommandParameter12);
            this.cmdGenCasting.ReturnTarget = null;
            this.cmdGenCasting.ReturnTargetProperty = null;
            this.cmdGenCasting.Trigger = null;
            this.cmdGenCasting.TriggerEvent = "Click";
            // 
            // l3CommandParameter11
            // 
            this.l3CommandParameter11.AcceptAfterExecuted = false;
            this.l3CommandParameter11.ConstantValue = null;
            this.l3CommandParameter11.MergeTarget = false;
            this.l3CommandParameter11.SourceFilter = null;
            this.l3CommandParameter11.SourceObject = null;
            this.l3CommandParameter11.SourceProperty = null;
            this.l3CommandParameter11.TargetObject = null;
            this.l3CommandParameter11.TargetProperty = null;
            // 
            // l3CommandParameter12
            // 
            this.l3CommandParameter12.AcceptAfterExecuted = false;
            this.l3CommandParameter12.ConstantValue = null;
            this.l3CommandParameter12.MergeTarget = false;
            this.l3CommandParameter12.SourceFilter = null;
            this.l3CommandParameter12.SourceObject = null;
            this.l3CommandParameter12.SourceProperty = null;
            this.l3CommandParameter12.TargetObject = null;
            this.l3CommandParameter12.TargetProperty = null;
            // 
            // L3cmdpGenCasting
            // 
            this.L3cmdpGenCasting.AcceptAfterExecuted = false;
            this.L3cmdpGenCasting.ConstantValue = null;
            this.L3cmdpGenCasting.MergeTarget = false;
            this.L3cmdpGenCasting.SourceFilter = "";
            this.L3cmdpGenCasting.SourceObject = null;
            this.L3cmdpGenCasting.SourceProperty = "";
            this.L3cmdpGenCasting.TargetObject = null;
            this.L3cmdpGenCasting.TargetProperty = null;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.btnExit,
            this.btnClosePlan,
            this.btnDel,
            this.btnSteelLess});
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
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsGenCasting;
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
            this.tstdtpEndDate,
            this.toolStripLabel4,
            this.tstdtpBeginDate,
            this.toolStripLabel5,
            this.tscmbSteelGrade,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.tstxtGenCasting});
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
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel4.Text = "计划订单结束日期:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel5.Text = "计划订单开始日期:";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "钢种:";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvGenCasting);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 29;
            // 
            // dvGenCasting
            // 
            this.dvGenCasting.AllowUserToAddRows = false;
            this.dvGenCasting.AutoGenerateColumns = false;
            this.dvGenCasting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvGenCasting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvGenCasting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvGenCasting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.pLANIDDataGridViewTextBoxColumn,
            this.wEIGHTDataGridViewTextBoxColumn,
            this.ActWeight,
            this.SpareWeight,
            this.uNITDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.Protocol,
            this.ProduceStd,
            this.tECHREQUESTDataGridViewTextBoxColumn,
            this.Other_Tech_Request,
            this.Product_Route,
            this.sTDDataGridViewTextBoxColumn,
            this.MaterialCode,
            this.sTATUSDataGridViewTextBoxColumn,
            this.pLANDEPTDataGridViewTextBoxColumn,
            this.cONTRACTIDDataGridViewTextBoxColumn,
            this.eXECUTEDEPTDataGridViewTextBoxColumn,
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
            this.iNSIDENOTEDataGridViewTextBoxColumn,
            this.iMMFLAGDataGridViewTextBoxColumn,
            this.nEWBOFFLAGDataGridViewTextBoxColumn,
            this.pk_poid,
            this.MaterialCode_ID});
            this.dvGenCasting.DataSource = this.bsGenCasting;
            this.dvGenCasting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGenCasting.Location = new System.Drawing.Point(0, 0);
            this.dvGenCasting.Name = "dvGenCasting";
            this.dvGenCasting.RowTemplate.Height = 23;
            this.dvGenCasting.Size = new System.Drawing.Size(996, 628);
            this.dvGenCasting.TabIndex = 0;
            this.dvGenCasting.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dvGenCasting_RowPrePaint);
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
            this.dsCasterID.AutoSubscribe = true;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' order by code";
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
            // pLANIDDataGridViewTextBoxColumn
            // 
            this.pLANIDDataGridViewTextBoxColumn.DataPropertyName = "PLANID";
            this.pLANIDDataGridViewTextBoxColumn.Frozen = true;
            this.pLANIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANIDDataGridViewTextBoxColumn.Name = "pLANIDDataGridViewTextBoxColumn";
            this.pLANIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT";
            this.wEIGHTDataGridViewTextBoxColumn.Frozen = true;
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "计划数量";
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            this.wEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wEIGHTDataGridViewTextBoxColumn.Width = 78;
            // 
            // ActWeight
            // 
            this.ActWeight.DataPropertyName = "ActWeight";
            this.ActWeight.Frozen = true;
            this.ActWeight.HeaderText = "实际投用量";
            this.ActWeight.Name = "ActWeight";
            this.ActWeight.ReadOnly = true;
            this.ActWeight.Width = 90;
            // 
            // SpareWeight
            // 
            this.SpareWeight.DataPropertyName = "SpareWeight";
            this.SpareWeight.Frozen = true;
            this.SpareWeight.HeaderText = "余量";
            this.SpareWeight.Name = "SpareWeight";
            this.SpareWeight.Width = 54;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.Frozen = true;
            this.uNITDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            this.uNITDataGridViewTextBoxColumn.Width = 78;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.Frozen = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.Width = 54;
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
            // ProduceStd
            // 
            this.ProduceStd.DataPropertyName = "ProduceStd";
            this.ProduceStd.HeaderText = "制造标准";
            this.ProduceStd.Name = "ProduceStd";
            this.ProduceStd.ReadOnly = true;
            this.ProduceStd.Width = 78;
            // 
            // tECHREQUESTDataGridViewTextBoxColumn
            // 
            this.tECHREQUESTDataGridViewTextBoxColumn.DataPropertyName = "TECH_REQUEST";
            this.tECHREQUESTDataGridViewTextBoxColumn.HeaderText = "技术要求";
            this.tECHREQUESTDataGridViewTextBoxColumn.Name = "tECHREQUESTDataGridViewTextBoxColumn";
            this.tECHREQUESTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tECHREQUESTDataGridViewTextBoxColumn.Width = 78;
            // 
            // Other_Tech_Request
            // 
            this.Other_Tech_Request.DataPropertyName = "Other_Tech_Request";
            this.Other_Tech_Request.HeaderText = "其他要求";
            this.Other_Tech_Request.Name = "Other_Tech_Request";
            this.Other_Tech_Request.Width = 78;
            // 
            // Product_Route
            // 
            this.Product_Route.DataPropertyName = "Product_Route";
            this.Product_Route.HeaderText = "工艺路径";
            this.Product_Route.Name = "Product_Route";
            this.Product_Route.Width = 78;
            // 
            // sTDDataGridViewTextBoxColumn
            // 
            this.sTDDataGridViewTextBoxColumn.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn.Name = "sTDDataGridViewTextBoxColumn";
            this.sTDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTDDataGridViewTextBoxColumn.Width = 54;
            // 
            // MaterialCode
            // 
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "物料代码";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.Width = 78;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.sTATUSDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTATUSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTATUSDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "计划状态";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTATUSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTATUSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTATUSDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sTATUSDataGridViewTextBoxColumn.Width = 78;
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
            this.pLANDEPTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANDEPTDataGridViewTextBoxColumn.Visible = false;
            this.pLANDEPTDataGridViewTextBoxColumn.Width = 102;
            // 
            // cONTRACTIDDataGridViewTextBoxColumn
            // 
            this.cONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "CONTRACTID";
            this.cONTRACTIDDataGridViewTextBoxColumn.HeaderText = "状态";
            this.cONTRACTIDDataGridViewTextBoxColumn.Name = "cONTRACTIDDataGridViewTextBoxColumn";
            this.cONTRACTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            this.cONTRACTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // eXECUTEDEPTDataGridViewTextBoxColumn
            // 
            this.eXECUTEDEPTDataGridViewTextBoxColumn.DataPropertyName = "EXECUTEDEPT";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.HeaderText = "计划执行单位";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Name = "eXECUTEDEPTDataGridViewTextBoxColumn";
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Visible = false;
            this.eXECUTEDEPTDataGridViewTextBoxColumn.Width = 102;
            // 
            // cREATEDATEDataGridViewTextBoxColumn
            // 
            this.cREATEDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATEDATE";
            this.cREATEDATEDataGridViewTextBoxColumn.HeaderText = "计划日期";
            this.cREATEDATEDataGridViewTextBoxColumn.Name = "cREATEDATEDataGridViewTextBoxColumn";
            this.cREATEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cREATEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // pLANEXECUTEDATEDataGridViewTextBoxColumn
            // 
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANEXECUTEDATE";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.HeaderText = "计划执行日期";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.Name = "pLANEXECUTEDATEDataGridViewTextBoxColumn";
            this.pLANEXECUTEDATEDataGridViewTextBoxColumn.ReadOnly = true;
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
            // aSSISTUNITDataGridViewTextBoxColumn
            // 
            this.aSSISTUNITDataGridViewTextBoxColumn.DataPropertyName = "ASSIST_UNIT";
            this.aSSISTUNITDataGridViewTextBoxColumn.HeaderText = "辅计量单位";
            this.aSSISTUNITDataGridViewTextBoxColumn.Name = "aSSISTUNITDataGridViewTextBoxColumn";
            this.aSSISTUNITDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSSISTUNITDataGridViewTextBoxColumn.Width = 90;
            // 
            // aSSISIWEIGHTDataGridViewTextBoxColumn
            // 
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "ASSISI_WEIGHT";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.HeaderText = "计划辅数量";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.Name = "aSSISIWEIGHTDataGridViewTextBoxColumn";
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSSISIWEIGHTDataGridViewTextBoxColumn.Width = 90;
            // 
            // pLANRECDATEDataGridViewTextBoxColumn
            // 
            this.pLANRECDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANREC_DATE";
            this.pLANRECDATEDataGridViewTextBoxColumn.HeaderText = "计划下单日期";
            this.pLANRECDATEDataGridViewTextBoxColumn.Name = "pLANRECDATEDataGridViewTextBoxColumn";
            this.pLANRECDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLANRECDATEDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEQUESTDATEDataGridViewTextBoxColumn
            // 
            this.rEQUESTDATEDataGridViewTextBoxColumn.DataPropertyName = "REQUEST_DATE";
            this.rEQUESTDATEDataGridViewTextBoxColumn.HeaderText = "需求日期";
            this.rEQUESTDATEDataGridViewTextBoxColumn.Name = "rEQUESTDATEDataGridViewTextBoxColumn";
            this.rEQUESTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEQUESTDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // cORPDataGridViewTextBoxColumn
            // 
            this.cORPDataGridViewTextBoxColumn.DataPropertyName = "CORP";
            this.cORPDataGridViewTextBoxColumn.HeaderText = "公司";
            this.cORPDataGridViewTextBoxColumn.Name = "cORPDataGridViewTextBoxColumn";
            this.cORPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cORPDataGridViewTextBoxColumn.Width = 54;
            // 
            // fACTORYDataGridViewTextBoxColumn
            // 
            this.fACTORYDataGridViewTextBoxColumn.DataPropertyName = "FACTORY";
            this.fACTORYDataGridViewTextBoxColumn.HeaderText = "工厂";
            this.fACTORYDataGridViewTextBoxColumn.Name = "fACTORYDataGridViewTextBoxColumn";
            this.fACTORYDataGridViewTextBoxColumn.ReadOnly = true;
            this.fACTORYDataGridViewTextBoxColumn.Width = 54;
            // 
            // wORKCENTERDataGridViewTextBoxColumn
            // 
            this.wORKCENTERDataGridViewTextBoxColumn.DataPropertyName = "WORK_CENTER";
            this.wORKCENTERDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.wORKCENTERDataGridViewTextBoxColumn.Name = "wORKCENTERDataGridViewTextBoxColumn";
            this.wORKCENTERDataGridViewTextBoxColumn.ReadOnly = true;
            this.wORKCENTERDataGridViewTextBoxColumn.Width = 78;
            // 
            // cLIENTDataGridViewTextBoxColumn
            // 
            this.cLIENTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT";
            this.cLIENTDataGridViewTextBoxColumn.HeaderText = "客户";
            this.cLIENTDataGridViewTextBoxColumn.Name = "cLIENTDataGridViewTextBoxColumn";
            this.cLIENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cLIENTDataGridViewTextBoxColumn.Width = 54;
            // 
            // iNSIDENOTEDataGridViewTextBoxColumn
            // 
            this.iNSIDENOTEDataGridViewTextBoxColumn.DataPropertyName = "INSIDE_NOTE";
            this.iNSIDENOTEDataGridViewTextBoxColumn.HeaderText = "生产部说明";
            this.iNSIDENOTEDataGridViewTextBoxColumn.Name = "iNSIDENOTEDataGridViewTextBoxColumn";
            this.iNSIDENOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSIDENOTEDataGridViewTextBoxColumn.Width = 90;
            // 
            // iMMFLAGDataGridViewTextBoxColumn
            // 
            this.iMMFLAGDataGridViewTextBoxColumn.DataPropertyName = "IMM_FLAG";
            this.iMMFLAGDataGridViewTextBoxColumn.HeaderText = "是否加急";
            this.iMMFLAGDataGridViewTextBoxColumn.Name = "iMMFLAGDataGridViewTextBoxColumn";
            this.iMMFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMMFLAGDataGridViewTextBoxColumn.Width = 78;
            // 
            // nEWBOFFLAGDataGridViewTextBoxColumn
            // 
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataPropertyName = "NEW_BOF_FLAG";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DataSource = this.dsBOFFlag;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.HeaderText = "转炉标志";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Name = "nEWBOFFLAGDataGridViewTextBoxColumn";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nEWBOFFLAGDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.nEWBOFFLAGDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsBOFFlag
            // 
            this.dsBOFFlag.AutoLoad = true;
            this.dsBOFFlag.AutoSubscribe = true;
            this.dsBOFFlag.DataSetName = "L3DataSet";
            this.dsBOFFlag.DeleteMethod = null;
            this.dsBOFFlag.InsertMethod = null;
            this.dsBOFFlag.L3DataAdapter = this.Adapter;
            this.dsBOFFlag.LoadEvent = "Click";
            this.dsBOFFlag.LoadTrigger = null;
            this.dsBOFFlag.RefreshValve = 1000;
            this.dsBOFFlag.SourceCommand = null;
            this.dsBOFFlag.SourceCondition = "Code_Group = \'BOF_TYPE\'";
            this.dsBOFFlag.SourceMethod = "";
            this.dsBOFFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFFlag.SubscribeTarget = null;
            this.dsBOFFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFFlag});
            this.dsBOFFlag.UpdateEvent = "Click";
            this.dsBOFFlag.UpdateMethod = null;
            this.dsBOFFlag.UpdateTrigger = null;
            // 
            // schemadsBOFFlag
            // 
            this.schemadsBOFFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFFlagL3DataTableCode_Des,
            this.coldsBOFFlagL3DataTableCode_Val_Long});
            this.schemadsBOFFlag.TableName = "L3DataTable";
            // 
            // coldsBOFFlagL3DataTableCode_Des
            // 
            this.coldsBOFFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBOFFlagL3DataTableCode_Val_Long
            // 
            this.coldsBOFFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBOFFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBOFFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBOFFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // pk_poid
            // 
            this.pk_poid.DataPropertyName = "pk_poid";
            this.pk_poid.HeaderText = "计划订单主键";
            this.pk_poid.Name = "pk_poid";
            this.pk_poid.Width = 102;
            // 
            // MaterialCode_ID
            // 
            this.MaterialCode_ID.DataPropertyName = "MaterialCode_ID";
            this.MaterialCode_ID.HeaderText = "物料编码ID";
            this.MaterialCode_ID.Name = "MaterialCode_ID";
            this.MaterialCode_ID.Width = 90;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.tstdtpEndDate;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // cmdIntegrateCancel
            // 
            this.cmdIntegrateCancel.Adapter = this.Adapter;
            this.cmdIntegrateCancel.MergeReturnTarget = false;
            this.cmdIntegrateCancel.Method = "PlanOrdIntegrateCancel";
            this.cmdIntegrateCancel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdIntegrateCancel.Parameters.Add(this.l3CommandParameter7);
            this.cmdIntegrateCancel.ReturnTarget = null;
            this.cmdIntegrateCancel.ReturnTargetProperty = null;
            this.cmdIntegrateCancel.Trigger = null;
            this.cmdIntegrateCancel.TriggerEvent = "Click";
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter7.SourceObject = this.dsGenCasting;
            this.l3CommandParameter7.SourceProperty = "L3DataTable";
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter5.SourceObject = this.dsGenCasting;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
            this.dsSteelGrade.AutoSubscribe = true;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = null;
            this.dsSteelGrade.InsertMethod = null;
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "Click";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "";
            this.dsSteelGrade.SourceMethod = "select SteelGrade from CQA_SteelGradeIndex_R group by SteelGrade";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSteelGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "Click";
            this.dsSteelGrade.UpdateMethod = null;
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
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
            this.dsError.SourceCondition = "OWNER = \'CastingPlanGen\'";
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
            // cmdDel
            // 
            this.cmdDel.Adapter = this.Adapter;
            this.cmdDel.MergeReturnTarget = false;
            this.cmdDel.Method = "DelPlanOrder";
            this.cmdDel.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdDel.Parameters.Add(this.l3CommandParameter9);
            this.cmdDel.ReturnTarget = null;
            this.cmdDel.ReturnTargetProperty = null;
            this.cmdDel.Trigger = null;
            this.cmdDel.TriggerEvent = "Click";
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter9.SourceObject = this.dsGenCasting;
            this.l3CommandParameter9.SourceProperty = "L3DataTable";
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // cmdClose
            // 
            this.cmdClose.Adapter = this.Adapter;
            this.cmdClose.MergeReturnTarget = false;
            this.cmdClose.Method = "EndPlanOrder";
            this.cmdClose.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdClose.Parameters.Add(this.l3CommandParameter9);
            this.cmdClose.ReturnTarget = null;
            this.cmdClose.ReturnTargetProperty = null;
            this.cmdClose.Trigger = null;
            this.cmdClose.TriggerEvent = "Click";
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = "L3DataTable";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
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
            // cmdSteelLess
            // 
            this.cmdSteelLess.Adapter = this.Adapter;
            this.cmdSteelLess.MergeReturnTarget = false;
            this.cmdSteelLess.Method = "NewCastingPlanGen1";
            this.cmdSteelLess.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdSteelLess.Parameters.Add(this.l3CommandParameter13);
            this.cmdSteelLess.Parameters.Add(this.l3CommandParameter14);
            this.cmdSteelLess.ReturnTarget = null;
            this.cmdSteelLess.ReturnTargetProperty = null;
            this.cmdSteelLess.Trigger = null;
            this.cmdSteelLess.TriggerEvent = "Click";
            // 
            // l3CommandParameter13
            // 
            this.l3CommandParameter13.AcceptAfterExecuted = false;
            this.l3CommandParameter13.ConstantValue = null;
            this.l3CommandParameter13.MergeTarget = false;
            this.l3CommandParameter13.SourceFilter = null;
            this.l3CommandParameter13.SourceObject = null;
            this.l3CommandParameter13.SourceProperty = null;
            this.l3CommandParameter13.TargetObject = null;
            this.l3CommandParameter13.TargetProperty = null;
            // 
            // l3CommandParameter14
            // 
            this.l3CommandParameter14.AcceptAfterExecuted = false;
            this.l3CommandParameter14.ConstantValue = null;
            this.l3CommandParameter14.MergeTarget = false;
            this.l3CommandParameter14.SourceFilter = null;
            this.l3CommandParameter14.SourceObject = null;
            this.l3CommandParameter14.SourceProperty = null;
            this.l3CommandParameter14.TargetObject = null;
            this.l3CommandParameter14.TargetProperty = null;
            // 
            // GenCastingPlanFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenCastingPlanFrm";
            this.TabText = "铸机浇钢计划排产";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.GenCastingPlanFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenCastingPlanFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsGenCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGenCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGenCasting)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGenCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsGenCasting;
        private System.Windows.Forms.BindingSource bsGenCasting;
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
        private System.Windows.Forms.DataGridView dvGenCasting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel btnQuery;
        private buttonHide.ToolStripToriDateTimePicker tstdtpEndDate;
        private AppSvrHMI.L3Command cmdQuery;
        private AppSvrHMI.L3Command cmdGenCasting;
        private System.Data.DataTable schemadsGenCasting;
        private System.Data.DataColumn coldsGenCastingL3DataTableGUID;
        private System.Data.DataColumn coldsGenCastingL3DataTableNAME;
        private System.Data.DataColumn coldsGenCastingL3DataTablePLANID;
        private System.Data.DataColumn coldsGenCastingL3DataTableCONTRACTID;
        private System.Data.DataColumn coldsGenCastingL3DataTableSTATUS;
        private System.Data.DataColumn coldsGenCastingL3DataTablePLANDEPT;
        private System.Data.DataColumn coldsGenCastingL3DataTableEXECUTEDEPT;
        private System.Data.DataColumn coldsGenCastingL3DataTableCREATEDATE;
        private System.Data.DataColumn coldsGenCastingL3DataTablePLANEXECUTEDATE;
        private System.Data.DataColumn coldsGenCastingL3DataTableACTUALEXECUTEDATE;
        private System.Data.DataColumn coldsGenCastingL3DataTablePLANNER;
        private System.Data.DataColumn coldsGenCastingL3DataTableLENGTH;
        private System.Data.DataColumn coldsGenCastingL3DataTableWIDTH;
        private System.Data.DataColumn coldsGenCastingL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsGenCastingL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsGenCastingL3DataTableUNIT;
        private System.Data.DataColumn coldsGenCastingL3DataTableASSIST_UNIT;
        private System.Data.DataColumn coldsGenCastingL3DataTableWEIGHT;
        private System.Data.DataColumn coldsGenCastingL3DataTableASSISI_WEIGHT;
        private System.Data.DataColumn coldsGenCastingL3DataTablePLANREC_DATE;
        private System.Data.DataColumn coldsGenCastingL3DataTableREQUEST_DATE;
        private System.Data.DataColumn coldsGenCastingL3DataTableCORP;
        private System.Data.DataColumn coldsGenCastingL3DataTableFACTORY;
        private System.Data.DataColumn coldsGenCastingL3DataTableWORK_CENTER;
        private System.Data.DataColumn coldsGenCastingL3DataTableCLIENT;
        private System.Data.DataColumn coldsGenCastingL3DataTableTECH_REQUEST;
        private System.Data.DataColumn coldsGenCastingL3DataTableINSIDE_NOTE;
        private System.Data.DataColumn coldsGenCastingL3DataTableIMM_FLAG;
        private System.Data.DataColumn coldsGenCastingL3DataTableCASTERID;
        private System.Data.DataColumn coldsGenCastingL3DataTableNEW_BOF_FLAG;
        private System.Data.DataColumn coldsGenCastingL3DataTableSTD;
        private System.Data.DataColumn coldsGenCastingL3DataTableCheckFlag;
        private System.Data.DataColumn coldsGenCastingL3DataTableProtocol;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3Command cmdIntegrateCancel;
        private AppSvrHMI.L3CommandParameter L3cmdpGenCasting;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBOFFlag;
        private System.Data.DataTable schemadsBOFFlag;
        private System.Data.DataColumn coldsBOFFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFFlagL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsGenCastingL3DataTableActWeight;
        private System.Data.DataColumn coldsGenCastingL3DataTableSpareWeight;
        private buttonHide.ToolStripToriDateTimePicker tstdtpBeginDate;
        private System.Windows.Forms.ToolStripTextBox tstxtGenCasting;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox tscmbSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.ToolStripButton btnDel;
        private AppSvrHMI.L3Command cmdDel;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private System.Data.DataColumn coldsGenCastingL3DataTableProduceStd;
        private System.Data.DataColumn coldsGenCastingL3DataTableMaterialCode;
        private System.Data.DataColumn coldsGenCastingL3DataTableProduct_Route;
        private System.Data.DataColumn coldsGenCastingL3DataTableOther_Tech_Request;
        private System.Data.DataColumn coldsGenCastingL3DataTablepk_poid;
        private System.Data.DataColumn coldsGenCastingL3DataTableMaterialCode_ID;
        private System.Windows.Forms.ToolStripButton btnClosePlan;
        private AppSvrHMI.L3Command cmdClose;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter10;
        private AppSvrHMI.L3CommandParameter l3CommandParameter11;
        private AppSvrHMI.L3CommandParameter l3CommandParameter12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpareWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tECHREQUESTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Tech_Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANDEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXECUTEDEPTDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSIDENOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMMFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nEWBOFFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_poid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode_ID;
        private System.Windows.Forms.ToolStripButton btnSteelLess;
        private AppSvrHMI.L3Command cmdSteelLess;
        private AppSvrHMI.L3CommandParameter l3CommandParameter13;
        private AppSvrHMI.L3CommandParameter l3CommandParameter14;
    }
}