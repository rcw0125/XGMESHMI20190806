namespace EquipMag.LadleMag
{
    partial class ComLadleTieQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComLadleTieQueryFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.l3CommandParameterMain = new AppSvrHMI.L3CommandParameter();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREPID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREP_DATE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBREATHE_BRI_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBREATHE_BRI_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCAST_FAC = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCAST_WAST = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsDetailL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableObject_ID = new System.Data.DataColumn();
            this.l3CommandParameterTetail = new AppSvrHMI.L3CommandParameter();
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLadleID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bREATHEBRIWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableConfirm_Flag = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "/ 0";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel4.Text = " ****信息 ";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到第一条记录";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到上一条记录";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Enabled = false;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到下一条记录";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Enabled = false;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到最后一条记录";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "  ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton1.Text = "退出";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(71, 40);
            this.toolStripButton3.Text = "功能1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton4.Text = "确认";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton5.Text = "取消";
            // 
            // l3CommandParameterMain
            // 
            this.l3CommandParameterMain.AcceptAfterExecuted = false;
            this.l3CommandParameterMain.ConstantValue = null;
            this.l3CommandParameterMain.MergeTarget = false;
            this.l3CommandParameterMain.SourceFilter = null;
            this.l3CommandParameterMain.SourceObject = null;
            this.l3CommandParameterMain.SourceProperty = null;
            this.l3CommandParameterMain.TargetObject = null;
            this.l3CommandParameterMain.TargetProperty = null;
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
            this.dsDetail.DeleteMethod = "";
            this.dsDetail.InsertMethod = "";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "Click";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 1000;
            this.dsDetail.SourceCommand = null;
            this.dsDetail.SourceCondition = "1=2";
            this.dsDetail.SourceMethod = "";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDetail.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Com_Lad_Rep";
            this.dsDetail.SubscribeTarget = null;
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "Click";
            this.dsDetail.UpdateMethod = "";
            this.dsDetail.UpdateTrigger = null;
            // 
            // schemadsDetail
            // 
            this.schemadsDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDetailL3DataTableGUID,
            this.coldsDetailL3DataTableNAME,
            this.coldsDetailL3DataTableINPUT_TIME,
            this.coldsDetailL3DataTableREPID,
            this.coldsDetailL3DataTableLADLEID,
            this.coldsDetailL3DataTableREP_DATE,
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC,
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST,
            this.coldsDetailL3DataTableBREATHE_BRI_FAC,
            this.coldsDetailL3DataTableBREATHE_BRI_WAST,
            this.coldsDetailL3DataTableCAST_FAC,
            this.coldsDetailL3DataTableCAST_WAST,
            this.coldsDetailL3DataTableFIRE_START_TIME,
            this.coldsDetailL3DataTableFIRE_END_TIME,
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR,
            this.coldsDetailL3DataTableTEAMID,
            this.coldsDetailL3DataTableSHIFTID,
            this.coldsDetailL3DataTableOPERATOR,
            this.coldsDetailL3DataTableNOTE,
            this.coldsDetailL3DataTableWorkID,
            this.coldsDetailL3DataTableObject_ID});
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
            // coldsDetailL3DataTableREPID
            // 
            this.coldsDetailL3DataTableREPID.Caption = "REPID";
            this.coldsDetailL3DataTableREPID.ColumnName = "REPID";
            this.coldsDetailL3DataTableREPID.DataType = typeof(int);
            this.coldsDetailL3DataTableREPID.DefaultValue = 0;
            this.coldsDetailL3DataTableREPID.Namespace = "";
            // 
            // coldsDetailL3DataTableLADLEID
            // 
            this.coldsDetailL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsDetailL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsDetailL3DataTableLADLEID.DefaultValue = "";
            this.coldsDetailL3DataTableLADLEID.Namespace = "";
            // 
            // coldsDetailL3DataTableREP_DATE
            // 
            this.coldsDetailL3DataTableREP_DATE.Caption = "REP_DATE";
            this.coldsDetailL3DataTableREP_DATE.ColumnName = "REP_DATE";
            this.coldsDetailL3DataTableREP_DATE.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableREP_DATE.Namespace = "";
            // 
            // coldsDetailL3DataTableWATER_GAP_BRI_FAC
            // 
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.Caption = "WATER_GAP_BRI_FAC";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.ColumnName = "WATER_GAP_BRI_FAC";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableWATER_GAP_BRI_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableWATER_GAP_BRI_WAST
            // 
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.Caption = "WATER_GAP_BRI_WAST";
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.ColumnName = "WATER_GAP_BRI_WAST";
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableWATER_GAP_BRI_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableBREATHE_BRI_FAC
            // 
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.Caption = "BREATHE_BRI_FAC";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.ColumnName = "BREATHE_BRI_FAC";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableBREATHE_BRI_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableBREATHE_BRI_WAST
            // 
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.Caption = "BREATHE_BRI_WAST";
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.ColumnName = "BREATHE_BRI_WAST";
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableBREATHE_BRI_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableCAST_FAC
            // 
            this.coldsDetailL3DataTableCAST_FAC.Caption = "CAST_FAC";
            this.coldsDetailL3DataTableCAST_FAC.ColumnName = "CAST_FAC";
            this.coldsDetailL3DataTableCAST_FAC.DefaultValue = "";
            this.coldsDetailL3DataTableCAST_FAC.Namespace = "";
            // 
            // coldsDetailL3DataTableCAST_WAST
            // 
            this.coldsDetailL3DataTableCAST_WAST.Caption = "CAST_WAST";
            this.coldsDetailL3DataTableCAST_WAST.ColumnName = "CAST_WAST";
            this.coldsDetailL3DataTableCAST_WAST.DataType = typeof(double);
            this.coldsDetailL3DataTableCAST_WAST.DefaultValue = 0;
            this.coldsDetailL3DataTableCAST_WAST.Namespace = "";
            // 
            // coldsDetailL3DataTableFIRE_START_TIME
            // 
            this.coldsDetailL3DataTableFIRE_START_TIME.Caption = "FIRE_START_TIME";
            this.coldsDetailL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsDetailL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableFIRE_END_TIME
            // 
            this.coldsDetailL3DataTableFIRE_END_TIME.Caption = "FIRE_END_TIME";
            this.coldsDetailL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsDetailL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsDetailL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsDetailL3DataTableREP_LADLE_OPERATOR
            // 
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR.Caption = "REP_LADLE_OPERATOR";
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR.ColumnName = "REP_LADLE_OPERATOR";
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR.DefaultValue = "";
            this.coldsDetailL3DataTableREP_LADLE_OPERATOR.Namespace = "";
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
            // coldsDetailL3DataTableOPERATOR
            // 
            this.coldsDetailL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsDetailL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsDetailL3DataTableOPERATOR.DefaultValue = "";
            this.coldsDetailL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsDetailL3DataTableNOTE
            // 
            this.coldsDetailL3DataTableNOTE.Caption = "NOTE";
            this.coldsDetailL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsDetailL3DataTableNOTE.DefaultValue = "";
            this.coldsDetailL3DataTableNOTE.Namespace = "";
            // 
            // coldsDetailL3DataTableWorkID
            // 
            this.coldsDetailL3DataTableWorkID.Caption = "WorkID";
            this.coldsDetailL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsDetailL3DataTableWorkID.Namespace = "";
            // 
            // coldsDetailL3DataTableObject_ID
            // 
            this.coldsDetailL3DataTableObject_ID.Caption = "Object_ID";
            this.coldsDetailL3DataTableObject_ID.ColumnName = "Object_ID";
            this.coldsDetailL3DataTableObject_ID.Namespace = "";
            // 
            // l3CommandParameterTetail
            // 
            this.l3CommandParameterTetail.AcceptAfterExecuted = false;
            this.l3CommandParameterTetail.ConstantValue = null;
            this.l3CommandParameterTetail.MergeTarget = false;
            this.l3CommandParameterTetail.SourceFilter = null;
            this.l3CommandParameterTetail.SourceObject = null;
            this.l3CommandParameterTetail.SourceProperty = null;
            this.l3CommandParameterTetail.TargetObject = null;
            this.l3CommandParameterTetail.TargetProperty = null;
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = null;
            this.bnMain.AutoSize = false;
            this.bnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnMain.BackgroundImage")));
            this.bnMain.BindingSource = this.bsDetail;
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = null;
            this.bnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel6,
            this.dtEnd,
            this.toolStripLabel8,
            this.dtStart,
            this.toolStripLabel9,
            this.cmbLadleID,
            this.toolStripLabel7,
            this.btnOutput});
            this.bnMain.Location = new System.Drawing.Point(0, 0);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(1000, 25);
            this.bnMain.TabIndex = 22;
            this.bnMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel3.Text = " ****信息 ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
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
            // toolStripLabel8
            // 
            this.toolStripLabel8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel8.Text = "-";
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
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel9.Text = "录入日期:";
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel7.Text = "钢包号:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bnMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 700);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvDetail);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(994, 669);
            this.hmiRootPanel1.TabIndex = 24;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.rEPIDDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.rEPDATEDataGridViewTextBoxColumn,
            this.wATERGAPBRIFACDataGridViewTextBoxColumn,
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn,
            this.bREATHEBRIFACDataGridViewTextBoxColumn,
            this.bREATHEBRIWASTDataGridViewTextBoxColumn,
            this.cASTFACDataGridViewTextBoxColumn,
            this.cASTWASTDataGridViewTextBoxColumn,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn,
            this.fIREENDTIMEDataGridViewTextBoxColumn,
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 0);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(994, 669);
            this.dvDetail.TabIndex = 25;
            this.dvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEPIDDataGridViewTextBoxColumn
            // 
            this.rEPIDDataGridViewTextBoxColumn.DataPropertyName = "REPID";
            this.rEPIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.rEPIDDataGridViewTextBoxColumn.Name = "rEPIDDataGridViewTextBoxColumn";
            this.rEPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // rEPDATEDataGridViewTextBoxColumn
            // 
            this.rEPDATEDataGridViewTextBoxColumn.DataPropertyName = "REP_DATE";
            this.rEPDATEDataGridViewTextBoxColumn.HeaderText = "修补日期";
            this.rEPDATEDataGridViewTextBoxColumn.Name = "rEPDATEDataGridViewTextBoxColumn";
            this.rEPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // wATERGAPBRIFACDataGridViewTextBoxColumn
            // 
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.DataPropertyName = "WATER_GAP_BRI_FAC";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.HeaderText = "水口座砖厂家";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.Name = "wATERGAPBRIFACDataGridViewTextBoxColumn";
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.wATERGAPBRIFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // wATERGAPBRIWASTDataGridViewTextBoxColumn
            // 
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.DataPropertyName = "WATER_GAP_BRI_WAST";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.HeaderText = "水口座砖消耗量";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.Name = "wATERGAPBRIWASTDataGridViewTextBoxColumn";
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.wATERGAPBRIWASTDataGridViewTextBoxColumn.Width = 114;
            // 
            // bREATHEBRIFACDataGridViewTextBoxColumn
            // 
            this.bREATHEBRIFACDataGridViewTextBoxColumn.DataPropertyName = "BREATHE_BRI_FAC";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.HeaderText = "透气座砖厂家";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.Name = "bREATHEBRIFACDataGridViewTextBoxColumn";
            this.bREATHEBRIFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.bREATHEBRIFACDataGridViewTextBoxColumn.Width = 102;
            // 
            // bREATHEBRIWASTDataGridViewTextBoxColumn
            // 
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.DataPropertyName = "BREATHE_BRI_WAST";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.HeaderText = "透气座砖消耗量";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.Name = "bREATHEBRIWASTDataGridViewTextBoxColumn";
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bREATHEBRIWASTDataGridViewTextBoxColumn.Width = 114;
            // 
            // cASTFACDataGridViewTextBoxColumn
            // 
            this.cASTFACDataGridViewTextBoxColumn.DataPropertyName = "CAST_FAC";
            this.cASTFACDataGridViewTextBoxColumn.HeaderText = "浇铸料厂家";
            this.cASTFACDataGridViewTextBoxColumn.Name = "cASTFACDataGridViewTextBoxColumn";
            this.cASTFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // cASTWASTDataGridViewTextBoxColumn
            // 
            this.cASTWASTDataGridViewTextBoxColumn.DataPropertyName = "CAST_WAST";
            this.cASTWASTDataGridViewTextBoxColumn.HeaderText = "浇注料消耗量";
            this.cASTWASTDataGridViewTextBoxColumn.Name = "cASTWASTDataGridViewTextBoxColumn";
            this.cASTWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTWASTDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤开始时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤结束时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn.Name = "fIREENDTIMEDataGridViewTextBoxColumn";
            this.fIREENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEPLADLEOPERATORDataGridViewTextBoxColumn
            // 
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn.DataPropertyName = "REP_LADLE_OPERATOR";
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn.HeaderText = "修包操作者";
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn.Name = "rEPLADLEOPERATORDataGridViewTextBoxColumn";
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEPLADLEOPERATORDataGridViewTextBoxColumn.Width = 90;
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
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
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
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
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
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "Object_ID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "主键";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn.Visible = false;
            this.objectIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "LadleType = \'1\' order by LadleID";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
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
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // coldsDetailL3DataTableConfirm_Flag
            // 
            this.coldsDetailL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsDetailL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsDetailL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsDetailL3DataTableConfirm_Flag.Namespace = "";
            // 
            // ComLadleTieQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ComLadleTieQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "普通钢包打结实绩管理";
            this.Text = "普通钢包修补实绩查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComLadleTieQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.ComLadleTieQueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AppSvrHMI.L3DataSet dsDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbLadleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private AppSvrHMI.L3CommandParameter l3CommandParameterTetail;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableNAME;
        private System.Data.DataColumn coldsDetailL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableREPID;
        private System.Data.DataColumn coldsDetailL3DataTableLADLEID;
        private System.Data.DataColumn coldsDetailL3DataTableREP_DATE;
        private System.Data.DataColumn coldsDetailL3DataTableWATER_GAP_BRI_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableWATER_GAP_BRI_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableBREATHE_BRI_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableBREATHE_BRI_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableCAST_FAC;
        private System.Data.DataColumn coldsDetailL3DataTableCAST_WAST;
        private System.Data.DataColumn coldsDetailL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsDetailL3DataTableREP_LADLE_OPERATOR;
        private System.Data.DataColumn coldsDetailL3DataTableTEAMID;
        private System.Data.DataColumn coldsDetailL3DataTableSHIFTID;
        private System.Data.DataColumn coldsDetailL3DataTableOPERATOR;
        private System.Data.DataColumn coldsDetailL3DataTableNOTE;
        private AppSvrHMI.L3CommandParameter l3CommandParameterMain;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private System.Data.DataColumn coldsDetailL3DataTableWorkID;
        private System.Data.DataColumn coldsDetailL3DataTableObject_ID;
        private System.Windows.Forms.DataGridView dvDetail;
        private System.Data.DataColumn coldsDetailL3DataTableConfirm_Flag;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATERGAPBRIWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bREATHEBRIWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEPLADLEOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
       
    }
}