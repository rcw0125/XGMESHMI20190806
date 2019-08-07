namespace EquipMag.MoldMag
{
    partial class MoldBoardInstallMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoldBoardInstallMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsInstall = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.cmdInstall = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpInstall = new AppSvrHMI.L3CommandParameter();
            this.schemadsInstall = new System.Data.DataTable();
            this.coldsInstallL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINSTALL_DATE = new System.Data.DataColumn();
            this.coldsInstallL3DataTableREPAIR_START_TIME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableREPAIR_END_TIME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableMOLDID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableHIT_PRESS_FLAG = new System.Data.DataColumn();
            this.coldsInstallL3DataTableCOPPER_FAC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableREPAIR_FAC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableREP_COUNT = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINNERID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableOUTER_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableSOUTH_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNORTH_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableLUG_STEEL_MEA = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_TWO_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_UP_THREE_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINSTALL_PER = new System.Data.DataColumn();
            this.coldsInstallL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInStallID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableConfirmFlag = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
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
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbMoldID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbFac = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInstall = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALLDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOLDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hITPRESSFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStallID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOPPERFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPAIRFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oUTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOUTHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nORTHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUGSTEELMEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTWOSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTHREESECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTWOFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTWOSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTWOTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTHREEFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTHREESECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARUPTHREETHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALLPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMoldID = new AppSvrHMI.L3DataSet();
            this.schemadsMoldID = new System.Data.DataTable();
            this.coldsMoldIDL3DataTableMoldID = new System.Data.DataColumn();
            this.dsCopperFac = new AppSvrHMI.L3DataSet();
            this.schemadsCopperFac = new System.Data.DataTable();
            this.coldsCopperFacL3DataTableMatFactory = new System.Data.DataColumn();
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
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInstall
            // 
            this.bsInstall.DataMember = "L3DataTable";
            this.bsInstall.DataSource = this.dsInstall;
            // 
            // dsInstall
            // 
            this.dsInstall.AutoLoad = true;
            this.dsInstall.AutoSubscribe = true;
            this.dsInstall.DataSetName = "L3DataSet";
            this.dsInstall.DeleteMethod = "DeleteBoardInstallInfo";
            this.dsInstall.InsertMethod = "InsertBoardInstallInfo";
            this.dsInstall.L3DataAdapter = this.Adapter;
            this.dsInstall.LoadEvent = "Click";
            this.dsInstall.LoadTrigger = null;
            this.dsInstall.RefreshValve = 1000;
            this.dsInstall.SourceCommand = this.cmdInstall;
            this.dsInstall.SourceCondition = null;
            this.dsInstall.SourceMethod = "GetBoardInstallInfo";
            this.dsInstall.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsInstall.SourceURI = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.dsInstall.SubscribeTarget = null;
            this.dsInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInstall});
            this.dsInstall.UpdateEvent = "Click";
            this.dsInstall.UpdateMethod = "UpdateBoardInstallInfo";
            this.dsInstall.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "MoldBoardInstallbtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "MoldBoardInstallbtnDel");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "MoldBoardInstallbtnAdd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "MoldBoardInstallbtnConfirm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdInstall
            // 
            this.cmdInstall.Adapter = null;
            this.cmdInstall.MergeReturnTarget = false;
            this.cmdInstall.Method = null;
            this.cmdInstall.Object = null;
            this.cmdInstall.Parameters.Add(this.l3cmdpInstall);
            this.cmdInstall.ReturnTarget = null;
            this.cmdInstall.ReturnTargetProperty = null;
            this.cmdInstall.Trigger = null;
            this.cmdInstall.TriggerEvent = "Click";
            // 
            // l3cmdpInstall
            // 
            this.l3cmdpInstall.AcceptAfterExecuted = false;
            this.l3cmdpInstall.ConstantValue = "Input_Time = ";
            this.l3cmdpInstall.MergeTarget = false;
            this.l3cmdpInstall.SourceFilter = null;
            this.l3cmdpInstall.SourceObject = null;
            this.l3cmdpInstall.SourceProperty = null;
            this.l3cmdpInstall.TargetObject = null;
            this.l3cmdpInstall.TargetProperty = null;
            // 
            // schemadsInstall
            // 
            this.schemadsInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInstallL3DataTableGUID,
            this.coldsInstallL3DataTableNAME,
            this.coldsInstallL3DataTableINPUT_TIME,
            this.coldsInstallL3DataTableINSTALL_DATE,
            this.coldsInstallL3DataTableREPAIR_START_TIME,
            this.coldsInstallL3DataTableREPAIR_END_TIME,
            this.coldsInstallL3DataTableMOLDID,
            this.coldsInstallL3DataTableHIT_PRESS_FLAG,
            this.coldsInstallL3DataTableCOPPER_FAC,
            this.coldsInstallL3DataTableREPAIR_FAC,
            this.coldsInstallL3DataTableREP_COUNT,
            this.coldsInstallL3DataTableINNERID,
            this.coldsInstallL3DataTableOUTER_ID,
            this.coldsInstallL3DataTableSOUTH_ID,
            this.coldsInstallL3DataTableNORTH_ID,
            this.coldsInstallL3DataTableLUG_STEEL_MEA,
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR,
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC,
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI,
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR,
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC,
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI,
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR,
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC,
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI,
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR,
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC,
            this.coldsInstallL3DataTableNAR_UP_TWO_THI,
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR,
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC,
            this.coldsInstallL3DataTableNAR_UP_THREE_THI,
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR,
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC,
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI,
            this.coldsInstallL3DataTableINSTALL_PER,
            this.coldsInstallL3DataTableTEAMID,
            this.coldsInstallL3DataTableSHIFTID,
            this.coldsInstallL3DataTableOPERATOR,
            this.coldsInstallL3DataTableNOTE,
            this.coldsInstallL3DataTableInStallID,
            this.coldsInstallL3DataTableConfirmFlag});
            this.schemadsInstall.TableName = "L3DataTable";
            // 
            // coldsInstallL3DataTableGUID
            // 
            this.coldsInstallL3DataTableGUID.Caption = "GUID";
            this.coldsInstallL3DataTableGUID.ColumnName = "GUID";
            this.coldsInstallL3DataTableGUID.DefaultValue = "";
            this.coldsInstallL3DataTableGUID.Namespace = "";
            // 
            // coldsInstallL3DataTableNAME
            // 
            this.coldsInstallL3DataTableNAME.Caption = "NAME";
            this.coldsInstallL3DataTableNAME.ColumnName = "NAME";
            this.coldsInstallL3DataTableNAME.DefaultValue = "";
            this.coldsInstallL3DataTableNAME.Namespace = "";
            // 
            // coldsInstallL3DataTableINPUT_TIME
            // 
            this.coldsInstallL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsInstallL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsInstallL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsInstallL3DataTableINSTALL_DATE
            // 
            this.coldsInstallL3DataTableINSTALL_DATE.Caption = "INSTALL_DATE";
            this.coldsInstallL3DataTableINSTALL_DATE.ColumnName = "INSTALL_DATE";
            this.coldsInstallL3DataTableINSTALL_DATE.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableINSTALL_DATE.Namespace = "";
            // 
            // coldsInstallL3DataTableREPAIR_START_TIME
            // 
            this.coldsInstallL3DataTableREPAIR_START_TIME.Caption = "REPAIR_START_TIME";
            this.coldsInstallL3DataTableREPAIR_START_TIME.ColumnName = "REPAIR_START_TIME";
            this.coldsInstallL3DataTableREPAIR_START_TIME.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableREPAIR_START_TIME.Namespace = "";
            // 
            // coldsInstallL3DataTableREPAIR_END_TIME
            // 
            this.coldsInstallL3DataTableREPAIR_END_TIME.Caption = "REPAIR_END_TIME";
            this.coldsInstallL3DataTableREPAIR_END_TIME.ColumnName = "REPAIR_END_TIME";
            this.coldsInstallL3DataTableREPAIR_END_TIME.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableREPAIR_END_TIME.Namespace = "";
            // 
            // coldsInstallL3DataTableMOLDID
            // 
            this.coldsInstallL3DataTableMOLDID.Caption = "MOLDID";
            this.coldsInstallL3DataTableMOLDID.ColumnName = "MOLDID";
            this.coldsInstallL3DataTableMOLDID.DefaultValue = "";
            this.coldsInstallL3DataTableMOLDID.Namespace = "";
            // 
            // coldsInstallL3DataTableHIT_PRESS_FLAG
            // 
            this.coldsInstallL3DataTableHIT_PRESS_FLAG.Caption = "HIT_PRESS_FLAG";
            this.coldsInstallL3DataTableHIT_PRESS_FLAG.ColumnName = "HIT_PRESS_FLAG";
            this.coldsInstallL3DataTableHIT_PRESS_FLAG.DataType = typeof(int);
            this.coldsInstallL3DataTableHIT_PRESS_FLAG.DefaultValue = 0;
            this.coldsInstallL3DataTableHIT_PRESS_FLAG.Namespace = "";
            // 
            // coldsInstallL3DataTableCOPPER_FAC
            // 
            this.coldsInstallL3DataTableCOPPER_FAC.Caption = "COPPER_FAC";
            this.coldsInstallL3DataTableCOPPER_FAC.ColumnName = "COPPER_FAC";
            this.coldsInstallL3DataTableCOPPER_FAC.DefaultValue = "";
            this.coldsInstallL3DataTableCOPPER_FAC.Namespace = "";
            // 
            // coldsInstallL3DataTableREPAIR_FAC
            // 
            this.coldsInstallL3DataTableREPAIR_FAC.Caption = "REPAIR_FAC";
            this.coldsInstallL3DataTableREPAIR_FAC.ColumnName = "REPAIR_FAC";
            this.coldsInstallL3DataTableREPAIR_FAC.DefaultValue = "";
            this.coldsInstallL3DataTableREPAIR_FAC.Namespace = "";
            // 
            // coldsInstallL3DataTableREP_COUNT
            // 
            this.coldsInstallL3DataTableREP_COUNT.Caption = "REP_COUNT";
            this.coldsInstallL3DataTableREP_COUNT.ColumnName = "REP_COUNT";
            this.coldsInstallL3DataTableREP_COUNT.DataType = typeof(int);
            this.coldsInstallL3DataTableREP_COUNT.DefaultValue = 0;
            this.coldsInstallL3DataTableREP_COUNT.Namespace = "";
            // 
            // coldsInstallL3DataTableINNERID
            // 
            this.coldsInstallL3DataTableINNERID.Caption = "Inner_ID";
            this.coldsInstallL3DataTableINNERID.ColumnName = "Inner_ID";
            this.coldsInstallL3DataTableINNERID.DefaultValue = "";
            this.coldsInstallL3DataTableINNERID.Namespace = "";
            // 
            // coldsInstallL3DataTableOUTER_ID
            // 
            this.coldsInstallL3DataTableOUTER_ID.Caption = "OUTER_ID";
            this.coldsInstallL3DataTableOUTER_ID.ColumnName = "OUTER_ID";
            this.coldsInstallL3DataTableOUTER_ID.DefaultValue = "";
            this.coldsInstallL3DataTableOUTER_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableSOUTH_ID
            // 
            this.coldsInstallL3DataTableSOUTH_ID.Caption = "SOUTH_ID";
            this.coldsInstallL3DataTableSOUTH_ID.ColumnName = "SOUTH_ID";
            this.coldsInstallL3DataTableSOUTH_ID.DefaultValue = "";
            this.coldsInstallL3DataTableSOUTH_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableNORTH_ID
            // 
            this.coldsInstallL3DataTableNORTH_ID.Caption = "NORTH_ID";
            this.coldsInstallL3DataTableNORTH_ID.ColumnName = "NORTH_ID";
            this.coldsInstallL3DataTableNORTH_ID.DefaultValue = "";
            this.coldsInstallL3DataTableNORTH_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableLUG_STEEL_MEA
            // 
            this.coldsInstallL3DataTableLUG_STEEL_MEA.Caption = "LUG_STEEL_MEA";
            this.coldsInstallL3DataTableLUG_STEEL_MEA.ColumnName = "LUG_STEEL_MEA";
            this.coldsInstallL3DataTableLUG_STEEL_MEA.DataType = typeof(double);
            this.coldsInstallL3DataTableLUG_STEEL_MEA.DefaultValue = 0;
            this.coldsInstallL3DataTableLUG_STEEL_MEA.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_TWO_FIR
            // 
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR.Caption = "WIDE_UP_TWO_FIR";
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR.ColumnName = "WIDE_UP_TWO_FIR";
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_TWO_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_TWO_SEC
            // 
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC.Caption = "WIDE_UP_TWO_SEC";
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC.ColumnName = "WIDE_UP_TWO_SEC";
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_TWO_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_TWO_THI
            // 
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI.Caption = "WIDE_UP_TWO_THI";
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI.ColumnName = "WIDE_UP_TWO_THI";
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_TWO_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_THREE_FIR
            // 
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR.Caption = "WIDE_UP_THREE_FIR";
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR.ColumnName = "WIDE_UP_THREE_FIR";
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_THREE_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_THREE_SEC
            // 
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC.Caption = "WIDE_UP_THREE_SEC";
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC.ColumnName = "WIDE_UP_THREE_SEC";
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_THREE_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_UP_THREE_THI
            // 
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI.Caption = "WIDE_UP_THREE_THI";
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI.ColumnName = "WIDE_UP_THREE_THI";
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_UP_THREE_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR
            // 
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR.Caption = "WIDE_DOWN_EIGHT_FIR";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR.ColumnName = "WIDE_DOWN_EIGHT_FIR";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC
            // 
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC.Caption = "WIDE_DOWN_EIGHT_SEC";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC.ColumnName = "WIDE_DOWN_EIGHT_SEC";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI
            // 
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI.Caption = "WIDE_DOWN_EIGHT_THI";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI.ColumnName = "WIDE_DOWN_EIGHT_THI";
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_TWO_FIR
            // 
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR.Caption = "NAR_UP_TWO_FIR";
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR.ColumnName = "NAR_UP_TWO_FIR";
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_TWO_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_TWO_SEC
            // 
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC.Caption = "NAR_UP_TWO_SEC";
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC.ColumnName = "NAR_UP_TWO_SEC";
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_TWO_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_TWO_THI
            // 
            this.coldsInstallL3DataTableNAR_UP_TWO_THI.Caption = "NAR_UP_TWO_THI";
            this.coldsInstallL3DataTableNAR_UP_TWO_THI.ColumnName = "NAR_UP_TWO_THI";
            this.coldsInstallL3DataTableNAR_UP_TWO_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_TWO_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_TWO_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_THREE_FIR
            // 
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR.Caption = "NAR_UP_THREE_FIR";
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR.ColumnName = "NAR_UP_THREE_FIR";
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_THREE_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_THREE_SEC
            // 
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC.Caption = "NAR_UP_THREE_SEC";
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC.ColumnName = "NAR_UP_THREE_SEC";
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_THREE_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_UP_THREE_THI
            // 
            this.coldsInstallL3DataTableNAR_UP_THREE_THI.Caption = "NAR_UP_THREE_THI";
            this.coldsInstallL3DataTableNAR_UP_THREE_THI.ColumnName = "NAR_UP_THREE_THI";
            this.coldsInstallL3DataTableNAR_UP_THREE_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_UP_THREE_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_UP_THREE_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR
            // 
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR.Caption = "NAR_DOWN_EIGHT_FIR";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR.ColumnName = "NAR_DOWN_EIGHT_FIR";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC
            // 
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC.Caption = "NAR_DOWN_EIGHT_SEC";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC.ColumnName = "NAR_DOWN_EIGHT_SEC";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC.Namespace = "";
            // 
            // coldsInstallL3DataTableNAR_DOWN_EIGHT_THI
            // 
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI.Caption = "NAR_DOWN_EIGHT_THI";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI.ColumnName = "NAR_DOWN_EIGHT_THI";
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI.DataType = typeof(double);
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI.DefaultValue = 0;
            this.coldsInstallL3DataTableNAR_DOWN_EIGHT_THI.Namespace = "";
            // 
            // coldsInstallL3DataTableINSTALL_PER
            // 
            this.coldsInstallL3DataTableINSTALL_PER.Caption = "INSTALL_PER";
            this.coldsInstallL3DataTableINSTALL_PER.ColumnName = "INSTALL_PER";
            this.coldsInstallL3DataTableINSTALL_PER.DefaultValue = "";
            this.coldsInstallL3DataTableINSTALL_PER.Namespace = "";
            // 
            // coldsInstallL3DataTableTEAMID
            // 
            this.coldsInstallL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsInstallL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsInstallL3DataTableTEAMID.DefaultValue = "";
            this.coldsInstallL3DataTableTEAMID.Namespace = "";
            // 
            // coldsInstallL3DataTableSHIFTID
            // 
            this.coldsInstallL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsInstallL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsInstallL3DataTableSHIFTID.DefaultValue = "";
            this.coldsInstallL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsInstallL3DataTableOPERATOR
            // 
            this.coldsInstallL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsInstallL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsInstallL3DataTableOPERATOR.DefaultValue = "";
            this.coldsInstallL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsInstallL3DataTableNOTE
            // 
            this.coldsInstallL3DataTableNOTE.Caption = "NOTE";
            this.coldsInstallL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsInstallL3DataTableNOTE.DefaultValue = "";
            this.coldsInstallL3DataTableNOTE.Namespace = "";
            // 
            // coldsInstallL3DataTableInStallID
            // 
            this.coldsInstallL3DataTableInStallID.Caption = "InStallID";
            this.coldsInstallL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsInstallL3DataTableInStallID.Namespace = "";
            // 
            // coldsInstallL3DataTableConfirmFlag
            // 
            this.coldsInstallL3DataTableConfirmFlag.Caption = "ConfirmFlag";
            this.coldsInstallL3DataTableConfirmFlag.ColumnName = "ConfirmFlag";
            this.coldsInstallL3DataTableConfirmFlag.DataType = typeof(int);
            this.coldsInstallL3DataTableConfirmFlag.Namespace = "";
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsInstall;
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
            this.toolStripLabel5,
            this.cmbMoldID,
            this.toolStripLabel3,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6,
            this.cmbFac,
            this.toolStripLabel7});
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
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoldID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "结晶器号:";
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
            this.dtEnd.Size = new System.Drawing.Size(85, 22);
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
            this.dtStart.Size = new System.Drawing.Size(85, 22);
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
            // cmbFac
            // 
            this.cmbFac.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFac.DropDownWidth = 200;
            this.cmbFac.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "铜板厂家:";
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
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
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
            this.hmiRootPanel1.Controls.Add(this.dvInstall);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvInstall
            // 
            this.dvInstall.AllowUserToAddRows = false;
            this.dvInstall.AutoGenerateColumns = false;
            this.dvInstall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInstall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInstall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvInstall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.iNSTALLDATEDataGridViewTextBoxColumn,
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn,
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn,
            this.mOLDIDDataGridViewTextBoxColumn,
            this.hITPRESSFLAGDataGridViewTextBoxColumn,
            this.InStallID,
            this.cOPPERFACDataGridViewTextBoxColumn,
            this.rEPAIRFACDataGridViewTextBoxColumn,
            this.rEPCOUNTDataGridViewTextBoxColumn,
            this.iNNERIDDataGridViewTextBoxColumn,
            this.oUTERIDDataGridViewTextBoxColumn,
            this.sOUTHIDDataGridViewTextBoxColumn,
            this.nORTHIDDataGridViewTextBoxColumn,
            this.lUGSTEELMEADataGridViewTextBoxColumn,
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn,
            this.wIDEUPTWOSECDataGridViewTextBoxColumn,
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn,
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn,
            this.wIDEUPTHREESECDataGridViewTextBoxColumn,
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn,
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn,
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn,
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn,
            this.nARUPTWOFIRDataGridViewTextBoxColumn,
            this.nARUPTWOSECDataGridViewTextBoxColumn,
            this.nARUPTWOTHIDataGridViewTextBoxColumn,
            this.nARUPTHREEFIRDataGridViewTextBoxColumn,
            this.nARUPTHREESECDataGridViewTextBoxColumn,
            this.nARUPTHREETHIDataGridViewTextBoxColumn,
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn,
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn,
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn,
            this.iNSTALLPERDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.ConfirmFlag,
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvInstall.DataSource = this.bsInstall;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvInstall.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInstall.Location = new System.Drawing.Point(0, 0);
            this.dvInstall.Margin = new System.Windows.Forms.Padding(0);
            this.dvInstall.Name = "dvInstall";
            this.dvInstall.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvInstall.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dvInstall.RowTemplate.Height = 23;
            this.dvInstall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInstall.Size = new System.Drawing.Size(1000, 632);
            this.dvInstall.TabIndex = 31;
            this.dvInstall.Sorted += new System.EventHandler(this.dvInstall_Sorted);
            this.dvInstall.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvInstall_CellMouseDoubleClick);
            this.dvInstall.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInstall_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // iNSTALLDATEDataGridViewTextBoxColumn
            // 
            this.iNSTALLDATEDataGridViewTextBoxColumn.DataPropertyName = "INSTALL_DATE";
            this.iNSTALLDATEDataGridViewTextBoxColumn.HeaderText = "安装日期";
            this.iNSTALLDATEDataGridViewTextBoxColumn.Name = "iNSTALLDATEDataGridViewTextBoxColumn";
            this.iNSTALLDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSTALLDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEPAIRSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_START_TIME";
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "维修开始时间";
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn.Name = "rEPAIRSTARTTIMEDataGridViewTextBoxColumn";
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRSTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEPAIRENDTIMEDataGridViewTextBoxColumn
            // 
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_END_TIME";
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn.HeaderText = "维修结束时间";
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn.Name = "rEPAIRENDTIMEDataGridViewTextBoxColumn";
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // mOLDIDDataGridViewTextBoxColumn
            // 
            this.mOLDIDDataGridViewTextBoxColumn.DataPropertyName = "MOLDID";
            this.mOLDIDDataGridViewTextBoxColumn.HeaderText = "结晶器编号";
            this.mOLDIDDataGridViewTextBoxColumn.Name = "mOLDIDDataGridViewTextBoxColumn";
            this.mOLDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mOLDIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // hITPRESSFLAGDataGridViewTextBoxColumn
            // 
            this.hITPRESSFLAGDataGridViewTextBoxColumn.DataPropertyName = "HIT_PRESS_FLAG";
            this.hITPRESSFLAGDataGridViewTextBoxColumn.HeaderText = "打压是否合格";
            this.hITPRESSFLAGDataGridViewTextBoxColumn.Name = "hITPRESSFLAGDataGridViewTextBoxColumn";
            this.hITPRESSFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.hITPRESSFLAGDataGridViewTextBoxColumn.Width = 102;
            // 
            // InStallID
            // 
            this.InStallID.DataPropertyName = "InStallID";
            this.InStallID.HeaderText = "装配编号";
            this.InStallID.Name = "InStallID";
            this.InStallID.ReadOnly = true;
            this.InStallID.Width = 78;
            // 
            // cOPPERFACDataGridViewTextBoxColumn
            // 
            this.cOPPERFACDataGridViewTextBoxColumn.DataPropertyName = "COPPER_FAC";
            this.cOPPERFACDataGridViewTextBoxColumn.HeaderText = "铜管(板)厂家";
            this.cOPPERFACDataGridViewTextBoxColumn.Name = "cOPPERFACDataGridViewTextBoxColumn";
            this.cOPPERFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOPPERFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEPAIRFACDataGridViewTextBoxColumn
            // 
            this.rEPAIRFACDataGridViewTextBoxColumn.DataPropertyName = "REPAIR_FAC";
            this.rEPAIRFACDataGridViewTextBoxColumn.HeaderText = "铜板修复厂家";
            this.rEPAIRFACDataGridViewTextBoxColumn.Name = "rEPAIRFACDataGridViewTextBoxColumn";
            this.rEPAIRFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPAIRFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEPCOUNTDataGridViewTextBoxColumn
            // 
            this.rEPCOUNTDataGridViewTextBoxColumn.DataPropertyName = "REP_COUNT";
            this.rEPCOUNTDataGridViewTextBoxColumn.HeaderText = "铜板修复次数";
            this.rEPCOUNTDataGridViewTextBoxColumn.Name = "rEPCOUNTDataGridViewTextBoxColumn";
            this.rEPCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPCOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // iNNERIDDataGridViewTextBoxColumn
            // 
            this.iNNERIDDataGridViewTextBoxColumn.DataPropertyName = "Inner_ID";
            this.iNNERIDDataGridViewTextBoxColumn.HeaderText = "铜板内弧编号";
            this.iNNERIDDataGridViewTextBoxColumn.Name = "iNNERIDDataGridViewTextBoxColumn";
            this.iNNERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNERIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // oUTERIDDataGridViewTextBoxColumn
            // 
            this.oUTERIDDataGridViewTextBoxColumn.DataPropertyName = "OUTER_ID";
            this.oUTERIDDataGridViewTextBoxColumn.HeaderText = "铜板外弧编号";
            this.oUTERIDDataGridViewTextBoxColumn.Name = "oUTERIDDataGridViewTextBoxColumn";
            this.oUTERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oUTERIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // sOUTHIDDataGridViewTextBoxColumn
            // 
            this.sOUTHIDDataGridViewTextBoxColumn.DataPropertyName = "SOUTH_ID";
            this.sOUTHIDDataGridViewTextBoxColumn.HeaderText = "铜板南侧编号";
            this.sOUTHIDDataGridViewTextBoxColumn.Name = "sOUTHIDDataGridViewTextBoxColumn";
            this.sOUTHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sOUTHIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // nORTHIDDataGridViewTextBoxColumn
            // 
            this.nORTHIDDataGridViewTextBoxColumn.DataPropertyName = "NORTH_ID";
            this.nORTHIDDataGridViewTextBoxColumn.HeaderText = "铜板北侧编号";
            this.nORTHIDDataGridViewTextBoxColumn.Name = "nORTHIDDataGridViewTextBoxColumn";
            this.nORTHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.nORTHIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // lUGSTEELMEADataGridViewTextBoxColumn
            // 
            this.lUGSTEELMEADataGridViewTextBoxColumn.DataPropertyName = "LUG_STEEL_MEA";
            this.lUGSTEELMEADataGridViewTextBoxColumn.HeaderText = "铜板拉钢量";
            this.lUGSTEELMEADataGridViewTextBoxColumn.Name = "lUGSTEELMEADataGridViewTextBoxColumn";
            this.lUGSTEELMEADataGridViewTextBoxColumn.ReadOnly = true;
            this.lUGSTEELMEADataGridViewTextBoxColumn.Width = 90;
            // 
            // wIDEUPTWOFIRDataGridViewTextBoxColumn
            // 
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_TWO_FIR";
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn.HeaderText = "宽面距上口200mm点1[mm]";
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn.Name = "wIDEUPTWOFIRDataGridViewTextBoxColumn";
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTWOFIRDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEUPTWOSECDataGridViewTextBoxColumn
            // 
            this.wIDEUPTWOSECDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_TWO_SEC";
            this.wIDEUPTWOSECDataGridViewTextBoxColumn.HeaderText = "宽面距上口200mm点2[mm]";
            this.wIDEUPTWOSECDataGridViewTextBoxColumn.Name = "wIDEUPTWOSECDataGridViewTextBoxColumn";
            this.wIDEUPTWOSECDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTWOSECDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEUPTWOTHIDataGridViewTextBoxColumn
            // 
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_TWO_THI";
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn.HeaderText = "宽面距上口200mm点3[mm]";
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn.Name = "wIDEUPTWOTHIDataGridViewTextBoxColumn";
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTWOTHIDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEUPTHREEFIRDataGridViewTextBoxColumn
            // 
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_THREE_FIR";
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn.HeaderText = "宽面距上口300mm点1[mm]";
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn.Name = "wIDEUPTHREEFIRDataGridViewTextBoxColumn";
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTHREEFIRDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEUPTHREESECDataGridViewTextBoxColumn
            // 
            this.wIDEUPTHREESECDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_THREE_SEC";
            this.wIDEUPTHREESECDataGridViewTextBoxColumn.HeaderText = "宽面距上口300mm点2[mm]";
            this.wIDEUPTHREESECDataGridViewTextBoxColumn.Name = "wIDEUPTHREESECDataGridViewTextBoxColumn";
            this.wIDEUPTHREESECDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTHREESECDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEUPTHREETHIDataGridViewTextBoxColumn
            // 
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn.DataPropertyName = "WIDE_UP_THREE_THI";
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn.HeaderText = "宽面距上口300mm点3[mm]";
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn.Name = "wIDEUPTHREETHIDataGridViewTextBoxColumn";
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEUPTHREETHIDataGridViewTextBoxColumn.Width = 162;
            // 
            // wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn
            // 
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn.DataPropertyName = "WIDE_DOWN_EIGHT_FIR";
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn.HeaderText = "宽面距下口80mm点1[mm]";
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn.Name = "wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn";
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn.Width = 156;
            // 
            // wIDEDOWNEIGHTSECDataGridViewTextBoxColumn
            // 
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn.DataPropertyName = "WIDE_DOWN_EIGHT_SEC";
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn.HeaderText = "宽面距下口80mm点2[mm]";
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn.Name = "wIDEDOWNEIGHTSECDataGridViewTextBoxColumn";
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEDOWNEIGHTSECDataGridViewTextBoxColumn.Width = 156;
            // 
            // wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn
            // 
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn.DataPropertyName = "WIDE_DOWN_EIGHT_THI";
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn.HeaderText = "宽面距下口80mm点3[mm]";
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn.Name = "wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn";
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn.Width = 156;
            // 
            // nARUPTWOFIRDataGridViewTextBoxColumn
            // 
            this.nARUPTWOFIRDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_TWO_FIR";
            this.nARUPTWOFIRDataGridViewTextBoxColumn.HeaderText = "窄面距上口200mm点1[mm]";
            this.nARUPTWOFIRDataGridViewTextBoxColumn.Name = "nARUPTWOFIRDataGridViewTextBoxColumn";
            this.nARUPTWOFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTWOFIRDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARUPTWOSECDataGridViewTextBoxColumn
            // 
            this.nARUPTWOSECDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_TWO_SEC";
            this.nARUPTWOSECDataGridViewTextBoxColumn.HeaderText = "窄面距上口200mm点2[mm]";
            this.nARUPTWOSECDataGridViewTextBoxColumn.Name = "nARUPTWOSECDataGridViewTextBoxColumn";
            this.nARUPTWOSECDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTWOSECDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARUPTWOTHIDataGridViewTextBoxColumn
            // 
            this.nARUPTWOTHIDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_TWO_THI";
            this.nARUPTWOTHIDataGridViewTextBoxColumn.HeaderText = "窄面距上口200mm点3[mm]";
            this.nARUPTWOTHIDataGridViewTextBoxColumn.Name = "nARUPTWOTHIDataGridViewTextBoxColumn";
            this.nARUPTWOTHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTWOTHIDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARUPTHREEFIRDataGridViewTextBoxColumn
            // 
            this.nARUPTHREEFIRDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_THREE_FIR";
            this.nARUPTHREEFIRDataGridViewTextBoxColumn.HeaderText = "窄面距上口300mm点1[mm]";
            this.nARUPTHREEFIRDataGridViewTextBoxColumn.Name = "nARUPTHREEFIRDataGridViewTextBoxColumn";
            this.nARUPTHREEFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTHREEFIRDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARUPTHREESECDataGridViewTextBoxColumn
            // 
            this.nARUPTHREESECDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_THREE_SEC";
            this.nARUPTHREESECDataGridViewTextBoxColumn.HeaderText = "窄面距上口300mm点2[mm]";
            this.nARUPTHREESECDataGridViewTextBoxColumn.Name = "nARUPTHREESECDataGridViewTextBoxColumn";
            this.nARUPTHREESECDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTHREESECDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARUPTHREETHIDataGridViewTextBoxColumn
            // 
            this.nARUPTHREETHIDataGridViewTextBoxColumn.DataPropertyName = "NAR_UP_THREE_THI";
            this.nARUPTHREETHIDataGridViewTextBoxColumn.HeaderText = "窄面距上口300mm点3[mm]";
            this.nARUPTHREETHIDataGridViewTextBoxColumn.Name = "nARUPTHREETHIDataGridViewTextBoxColumn";
            this.nARUPTHREETHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARUPTHREETHIDataGridViewTextBoxColumn.Width = 162;
            // 
            // nARDOWNEIGHTFIRDataGridViewTextBoxColumn
            // 
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn.DataPropertyName = "NAR_DOWN_EIGHT_FIR";
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn.HeaderText = "窄面距下口80mm点1[mm]";
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn.Name = "nARDOWNEIGHTFIRDataGridViewTextBoxColumn";
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARDOWNEIGHTFIRDataGridViewTextBoxColumn.Width = 156;
            // 
            // nARDOWNEIGHTSECDataGridViewTextBoxColumn
            // 
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn.DataPropertyName = "NAR_DOWN_EIGHT_SEC";
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn.HeaderText = "窄面距下口80mm点2[mm]";
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn.Name = "nARDOWNEIGHTSECDataGridViewTextBoxColumn";
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARDOWNEIGHTSECDataGridViewTextBoxColumn.Width = 156;
            // 
            // nARDOWNEIGHTTHIDataGridViewTextBoxColumn
            // 
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn.DataPropertyName = "NAR_DOWN_EIGHT_THI";
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn.HeaderText = "窄面距下口80mm点3[mm]";
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn.Name = "nARDOWNEIGHTTHIDataGridViewTextBoxColumn";
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nARDOWNEIGHTTHIDataGridViewTextBoxColumn.Width = 156;
            // 
            // iNSTALLPERDataGridViewTextBoxColumn
            // 
            this.iNSTALLPERDataGridViewTextBoxColumn.DataPropertyName = "INSTALL_PER";
            this.iNSTALLPERDataGridViewTextBoxColumn.HeaderText = "装配人";
            this.iNSTALLPERDataGridViewTextBoxColumn.Name = "iNSTALLPERDataGridViewTextBoxColumn";
            this.iNSTALLPERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSTALLPERDataGridViewTextBoxColumn.Width = 66;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 66;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // ConfirmFlag
            // 
            this.ConfirmFlag.DataPropertyName = "ConfirmFlag";
            this.ConfirmFlag.HeaderText = "实绩确认标志";
            this.ConfirmFlag.Name = "ConfirmFlag";
            this.ConfirmFlag.ReadOnly = true;
            this.ConfirmFlag.Visible = false;
            this.ConfirmFlag.Width = 102;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsMoldID
            // 
            this.dsMoldID.AutoLoad = true;
            this.dsMoldID.AutoSubscribe = true;
            this.dsMoldID.DataSetName = "L3DataSet";
            this.dsMoldID.DeleteMethod = null;
            this.dsMoldID.InsertMethod = null;
            this.dsMoldID.L3DataAdapter = this.Adapter;
            this.dsMoldID.LoadEvent = "Click";
            this.dsMoldID.LoadTrigger = null;
            this.dsMoldID.RefreshValve = 1000;
            this.dsMoldID.SourceCommand = null;
            this.dsMoldID.SourceCondition = "MoldID Like \'J12%\'";
            this.dsMoldID.SourceMethod = "";
            this.dsMoldID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldID.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMoldID.SubscribeTarget = null;
            this.dsMoldID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldID});
            this.dsMoldID.UpdateEvent = "Click";
            this.dsMoldID.UpdateMethod = null;
            this.dsMoldID.UpdateTrigger = null;
            // 
            // schemadsMoldID
            // 
            this.schemadsMoldID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldIDL3DataTableMoldID});
            this.schemadsMoldID.TableName = "L3DataTable";
            // 
            // coldsMoldIDL3DataTableMoldID
            // 
            this.coldsMoldIDL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.Namespace = "";
            // 
            // dsCopperFac
            // 
            this.dsCopperFac.AutoLoad = true;
            this.dsCopperFac.AutoSubscribe = false;
            this.dsCopperFac.DataSetName = "L3DataSet";
            this.dsCopperFac.DeleteMethod = null;
            this.dsCopperFac.InsertMethod = null;
            this.dsCopperFac.L3DataAdapter = this.Adapter;
            this.dsCopperFac.LoadEvent = "Click";
            this.dsCopperFac.LoadTrigger = null;
            this.dsCopperFac.RefreshValve = 1000;
            this.dsCopperFac.SourceCommand = null;
            this.dsCopperFac.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜板\'";
            this.dsCopperFac.SourceMethod = "";
            this.dsCopperFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCopperFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCopperFac.SubscribeTarget = null;
            this.dsCopperFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCopperFac});
            this.dsCopperFac.UpdateEvent = "Click";
            this.dsCopperFac.UpdateMethod = null;
            this.dsCopperFac.UpdateTrigger = null;
            // 
            // schemadsCopperFac
            // 
            this.schemadsCopperFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCopperFacL3DataTableMatFactory});
            this.schemadsCopperFac.TableName = "L3DataTable";
            // 
            // coldsCopperFacL3DataTableMatFactory
            // 
            this.coldsCopperFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "INPUT_TIME";
            this.dataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "INSTALL_DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "安装日期";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "REPAIR_START_TIME";
            this.dataGridViewTextBoxColumn3.HeaderText = "维修开始时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "REPAIR_END_TIME";
            this.dataGridViewTextBoxColumn4.HeaderText = "维修结束时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MOLDID";
            this.dataGridViewTextBoxColumn5.HeaderText = "结晶器编号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HIT_PRESS_FLAG";
            this.dataGridViewTextBoxColumn6.HeaderText = "打压是否合格";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 102;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InStallID";
            this.dataGridViewTextBoxColumn7.HeaderText = "装配编号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "COPPER_FAC";
            this.dataGridViewTextBoxColumn8.HeaderText = "铜管(板)厂家";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 102;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "REPAIR_FAC";
            this.dataGridViewTextBoxColumn9.HeaderText = "铜板修复厂家";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 102;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "REP_COUNT";
            this.dataGridViewTextBoxColumn10.HeaderText = "铜板修复次数";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 102;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Inner_ID";
            this.dataGridViewTextBoxColumn11.HeaderText = "铜板内弧编号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 102;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OUTER_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "铜板外弧编号";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 102;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SOUTH_ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "铜板南侧编号";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 102;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "NORTH_ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "铜板北侧编号";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 102;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "LUG_STEEL_MEA";
            this.dataGridViewTextBoxColumn15.HeaderText = "铜板拉钢量";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 90;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "WIDE_UP_TWO_FIR";
            this.dataGridViewTextBoxColumn16.HeaderText = "宽面距上口200mm点1[mm]";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 162;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "WIDE_UP_TWO_SEC";
            this.dataGridViewTextBoxColumn17.HeaderText = "宽面距上口200mm点2[mm]";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 162;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "WIDE_UP_TWO_THI";
            this.dataGridViewTextBoxColumn18.HeaderText = "宽面距上口200mm点3[mm]";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 162;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "WIDE_UP_THREE_FIR";
            this.dataGridViewTextBoxColumn19.HeaderText = "宽面距上口300mm点1[mm]";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 162;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "WIDE_UP_THREE_SEC";
            this.dataGridViewTextBoxColumn20.HeaderText = "宽面距上口300mm点2[mm]";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 162;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "WIDE_UP_THREE_THI";
            this.dataGridViewTextBoxColumn21.HeaderText = "宽面距上口300mm点3[mm]";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 162;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "WIDE_DOWN_EIGHT_FIR";
            this.dataGridViewTextBoxColumn22.HeaderText = "宽面距下口80mm点1[mm]";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 156;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "WIDE_DOWN_EIGHT_SEC";
            this.dataGridViewTextBoxColumn23.HeaderText = "宽面距下口80mm点2[mm]";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 156;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "WIDE_DOWN_EIGHT_THI";
            this.dataGridViewTextBoxColumn24.HeaderText = "宽面距下口80mm点3[mm]";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 156;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "NAR_UP_TWO_FIR";
            this.dataGridViewTextBoxColumn25.HeaderText = "窄面距上口200mm点1[mm]";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 162;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "NAR_UP_TWO_SEC";
            this.dataGridViewTextBoxColumn26.HeaderText = "窄面距上口200mm点2[mm]";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 162;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "NAR_UP_TWO_THI";
            this.dataGridViewTextBoxColumn27.HeaderText = "窄面距上口200mm点3[mm]";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 162;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "NAR_UP_THREE_FIR";
            this.dataGridViewTextBoxColumn28.HeaderText = "窄面距上口300mm点1[mm]";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 162;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "NAR_UP_THREE_SEC";
            this.dataGridViewTextBoxColumn29.HeaderText = "窄面距上口300mm点2[mm]";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 162;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "NAR_UP_THREE_THI";
            this.dataGridViewTextBoxColumn30.HeaderText = "窄面距上口300mm点3[mm]";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 162;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "NAR_DOWN_EIGHT_FIR";
            this.dataGridViewTextBoxColumn31.HeaderText = "窄面距下口80mm点1[mm]";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 156;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "NAR_DOWN_EIGHT_SEC";
            this.dataGridViewTextBoxColumn32.HeaderText = "窄面距下口80mm点2[mm]";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 156;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "NAR_DOWN_EIGHT_THI";
            this.dataGridViewTextBoxColumn33.HeaderText = "窄面距下口80mm点3[mm]";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 156;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "INSTALL_PER";
            this.dataGridViewTextBoxColumn34.HeaderText = "装配人";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 66;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "TEAMID";
            this.dataGridViewTextBoxColumn35.HeaderText = "班别";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 54;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "SHIFTID";
            this.dataGridViewTextBoxColumn36.HeaderText = "班次";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 54;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "OPERATOR";
            this.dataGridViewTextBoxColumn37.HeaderText = "责任人";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 66;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "NOTE";
            this.dataGridViewTextBoxColumn38.HeaderText = "备注";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 54;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "ConfirmFlag";
            this.dataGridViewTextBoxColumn39.HeaderText = "实绩确认标志";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Visible = false;
            this.dataGridViewTextBoxColumn39.Width = 102;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn40.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Visible = false;
            this.dataGridViewTextBoxColumn40.Width = 54;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn41.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Visible = false;
            this.dataGridViewTextBoxColumn41.Width = 54;
            // 
            // MoldBoardInstallMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoldBoardInstallMagFrm";
            this.TabText = "结晶器铜板装配实绩管理";
            this.Text = "结晶器铜板装配实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoldBoardInstallMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.MoldBoardInstallMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInstall;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
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
        private System.Windows.Forms.DataGridView dvInstall;
        private AppSvrHMI.L3Command cmdInstall;
        private AppSvrHMI.L3CommandParameter l3cmdpInstall;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbMoldID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsMoldID;
        private System.Data.DataTable schemadsMoldID;
        private System.Data.DataColumn coldsMoldIDL3DataTableMoldID;
        private AppSvrHMI.L3DataSet dsInstall;
        private System.Data.DataTable schemadsInstall;
        private System.Data.DataColumn coldsInstallL3DataTableGUID;
        private System.Data.DataColumn coldsInstallL3DataTableNAME;
        private System.Data.DataColumn coldsInstallL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsInstallL3DataTableINSTALL_DATE;
        private System.Data.DataColumn coldsInstallL3DataTableREPAIR_START_TIME;
        private System.Data.DataColumn coldsInstallL3DataTableREPAIR_END_TIME;
        private System.Data.DataColumn coldsInstallL3DataTableMOLDID;
        private System.Data.DataColumn coldsInstallL3DataTableHIT_PRESS_FLAG;
        private System.Data.DataColumn coldsInstallL3DataTableCOPPER_FAC;
        private System.Data.DataColumn coldsInstallL3DataTableREPAIR_FAC;
        private System.Data.DataColumn coldsInstallL3DataTableREP_COUNT;
        private System.Data.DataColumn coldsInstallL3DataTableINNERID;
        private System.Data.DataColumn coldsInstallL3DataTableOUTER_ID;
        private System.Data.DataColumn coldsInstallL3DataTableSOUTH_ID;
        private System.Data.DataColumn coldsInstallL3DataTableNORTH_ID;
        private System.Data.DataColumn coldsInstallL3DataTableLUG_STEEL_MEA;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_TWO_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_TWO_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_TWO_THI;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_THREE_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_THREE_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_UP_THREE_THI;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_DOWN_EIGHT_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_DOWN_EIGHT_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableWIDE_DOWN_EIGHT_THI;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_TWO_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_TWO_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_TWO_THI;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_THREE_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_THREE_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_UP_THREE_THI;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_DOWN_EIGHT_FIR;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_DOWN_EIGHT_SEC;
        private System.Data.DataColumn coldsInstallL3DataTableNAR_DOWN_EIGHT_THI;
        private System.Data.DataColumn coldsInstallL3DataTableINSTALL_PER;
        private System.Data.DataColumn coldsInstallL3DataTableTEAMID;
        private System.Data.DataColumn coldsInstallL3DataTableSHIFTID;
        private System.Data.DataColumn coldsInstallL3DataTableOPERATOR;
        private System.Data.DataColumn coldsInstallL3DataTableNOTE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Data.DataColumn coldsInstallL3DataTableInStallID;
        private System.Data.DataColumn coldsInstallL3DataTableConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALLDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOLDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hITPRESSFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStallID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOPPERFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPAIRFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oUTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOUTHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nORTHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUGSTEELMEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTWOFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTWOSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTWOTHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTHREEFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTHREESECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEUPTHREETHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEDOWNEIGHTFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEDOWNEIGHTSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDEDOWNEIGHTTHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTWOFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTWOSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTWOTHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTHREEFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTHREESECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARUPTHREETHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARDOWNEIGHTFIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARDOWNEIGHTSECDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nARDOWNEIGHTTHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALLPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripComboBox cmbFac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private AppSvrHMI.L3DataSet dsCopperFac;
        private System.Data.DataTable schemadsCopperFac;
        private System.Data.DataColumn coldsCopperFacL3DataTableMatFactory;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
    }
}