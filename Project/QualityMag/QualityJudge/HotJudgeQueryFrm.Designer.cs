namespace QualityMag.QualityJudge
{
    partial class HotJudgeQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotJudgeQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsCaster = new AppSvrHMI.L3DataSet();
            this.schemadsCaster = new System.Data.DataTable();
            this.coldsCasterL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsWasterReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsWasterReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWasterReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWrongReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWrongReason = new AppSvrHMI.L3DataSet();
            this.schemadsWrongReason = new System.Data.DataTable();
            this.coldsWrongReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWrongReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsWrongReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsWrongReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.bsHotJudge = new System.Windows.Forms.BindingSource(this.components);
            this.dsHotJudge = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet9 = new System.Data.DataTable();
            this.coll3DataSet9L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableOperator = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableShift = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableTeam = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableLength = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWidth = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableThickness = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableRight_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableSufaceDefactDes = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableHotJudge_Time = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaitCheckFlag = new System.Data.DataColumn();
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
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtHotJudgeEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtHotJudgeData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotJudgeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloomCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wrongCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sufaceDefactDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waitCheckFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1014, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.hotJudgeTimeDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.bloomCountDataGridViewTextBoxColumn,
            this.calWeightDataGridViewTextBoxColumn,
            this.rightCountDataGridViewTextBoxColumn,
            this.rightWeightDataGridViewTextBoxColumn,
            this.wasterCountDataGridViewTextBoxColumn,
            this.wasterWeightDataGridViewTextBoxColumn,
            this.wasterCount1DataGridViewTextBoxColumn,
            this.wasterWeight1DataGridViewTextBoxColumn,
            this.wasterReason1DataGridViewTextBoxColumn,
            this.wasterCount2DataGridViewTextBoxColumn,
            this.wasterWeight2DataGridViewTextBoxColumn,
            this.wasterReason2DataGridViewTextBoxColumn,
            this.wasterCount3DataGridViewTextBoxColumn,
            this.wasterWeight3DataGridViewTextBoxColumn,
            this.wasterReason3DataGridViewTextBoxColumn,
            this.wrongCountDataGridViewTextBoxColumn,
            this.wrongWeightDataGridViewTextBoxColumn,
            this.wrongCount1DataGridViewTextBoxColumn,
            this.wrongWeight1DataGridViewTextBoxColumn,
            this.wrongReason1DataGridViewTextBoxColumn,
            this.wrongCount2DataGridViewTextBoxColumn,
            this.wrongWeight2DataGridViewTextBoxColumn,
            this.wrongReason2DataGridViewTextBoxColumn,
            this.wrongCount3DataGridViewTextBoxColumn,
            this.wrongWeight3DataGridViewTextBoxColumn,
            this.wrongReason3DataGridViewTextBoxColumn,
            this.sufaceDefactDesDataGridViewTextBoxColumn,
            this.waitCheckFlagDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsHotJudge;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInStore.Size = new System.Drawing.Size(1014, 508);
            this.dvInStore.TabIndex = 29;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
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
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
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
            // dsCaster
            // 
            this.dsCaster.AutoLoad = true;
            this.dsCaster.AutoSubscribe = false;
            this.dsCaster.DataSetName = "L3DataSet";
            this.dsCaster.DeleteMethod = null;
            this.dsCaster.InsertMethod = null;
            this.dsCaster.L3DataAdapter = this.Adapter;
            this.dsCaster.LoadEvent = "Click";
            this.dsCaster.LoadTrigger = null;
            this.dsCaster.RefreshValve = 1000;
            this.dsCaster.SourceCommand = null;
            this.dsCaster.SourceCondition = "CODE_GROUP = \'Caster\'";
            this.dsCaster.SourceMethod = "";
            this.dsCaster.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCaster.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCaster.SubscribeTarget = null;
            this.dsCaster.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCaster});
            this.dsCaster.UpdateEvent = "Click";
            this.dsCaster.UpdateMethod = null;
            this.dsCaster.UpdateTrigger = null;
            // 
            // schemadsCaster
            // 
            this.schemadsCaster.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterL3DataTableCode,
            this.coldsCasterL3DataTableCode_Des});
            this.schemadsCaster.TableName = "L3DataTable";
            // 
            // coldsCasterL3DataTableCode
            // 
            this.coldsCasterL3DataTableCode.Caption = "Code";
            this.coldsCasterL3DataTableCode.ColumnName = "Code";
            this.coldsCasterL3DataTableCode.Namespace = "";
            // 
            // coldsCasterL3DataTableCode_Des
            // 
            this.coldsCasterL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterL3DataTableCode_Des.Namespace = "";
            // 
            // bsWasterReason1
            // 
            this.bsWasterReason1.DataMember = "L3DataTable";
            this.bsWasterReason1.DataSource = this.dsWasterReason;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsWasterReason2
            // 
            this.bsWasterReason2.DataMember = "L3DataTable";
            this.bsWasterReason2.DataSource = this.dsWasterReason;
            // 
            // bsWasterReason3
            // 
            this.bsWasterReason3.DataMember = "L3DataTable";
            this.bsWasterReason3.DataSource = this.dsWasterReason;
            // 
            // bsWrongReason1
            // 
            this.bsWrongReason1.DataMember = "L3DataTable";
            this.bsWrongReason1.DataSource = this.dsWrongReason;
            // 
            // dsWrongReason
            // 
            this.dsWrongReason.AutoLoad = true;
            this.dsWrongReason.AutoSubscribe = false;
            this.dsWrongReason.DataSetName = "L3DataSet";
            this.dsWrongReason.DeleteMethod = null;
            this.dsWrongReason.InsertMethod = null;
            this.dsWrongReason.L3DataAdapter = this.Adapter;
            this.dsWrongReason.LoadEvent = "Click";
            this.dsWrongReason.LoadTrigger = null;
            this.dsWrongReason.RefreshValve = 1000;
            this.dsWrongReason.SourceCommand = null;
            this.dsWrongReason.SourceCondition = "CODE_GROUP = \'WRONG_REASON_CODE\'";
            this.dsWrongReason.SourceMethod = "";
            this.dsWrongReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWrongReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWrongReason.SubscribeTarget = null;
            this.dsWrongReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWrongReason});
            this.dsWrongReason.UpdateEvent = "Click";
            this.dsWrongReason.UpdateMethod = null;
            this.dsWrongReason.UpdateTrigger = null;
            // 
            // schemadsWrongReason
            // 
            this.schemadsWrongReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWrongReasonL3DataTableCode,
            this.coldsWrongReasonL3DataTableCode_Des});
            this.schemadsWrongReason.TableName = "L3DataTable";
            // 
            // coldsWrongReasonL3DataTableCode
            // 
            this.coldsWrongReasonL3DataTableCode.Caption = "Code";
            this.coldsWrongReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWrongReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWrongReasonL3DataTableCode_Des
            // 
            this.coldsWrongReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsWrongReason2
            // 
            this.bsWrongReason2.DataMember = "L3DataTable";
            this.bsWrongReason2.DataSource = this.dsWrongReason;
            // 
            // bsWrongReason3
            // 
            this.bsWrongReason3.DataMember = "L3DataTable";
            this.bsWrongReason3.DataSource = this.dsWrongReason;
            // 
            // bsHotJudge
            // 
            this.bsHotJudge.DataMember = "L3DataTable";
            this.bsHotJudge.DataSource = this.dsHotJudge;
            // 
            // dsHotJudge
            // 
            this.dsHotJudge.AutoLoad = true;
            this.dsHotJudge.AutoSubscribe = false;
            this.dsHotJudge.DataSetName = "L3DataSet";
            this.dsHotJudge.DeleteMethod = null;
            this.dsHotJudge.InsertMethod = null;
            this.dsHotJudge.L3DataAdapter = this.Adapter;
            this.dsHotJudge.LoadEvent = "Click";
            this.dsHotJudge.LoadTrigger = null;
            this.dsHotJudge.RefreshValve = 1000;
            this.dsHotJudge.SourceCommand = null;
            this.dsHotJudge.SourceCondition = "1=2";
            this.dsHotJudge.SourceMethod = "";
            this.dsHotJudge.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHotJudge.SourceURI = "XGMESLogic\\QualityMag\\CQA_Bloom_HotJudge_Data";
            this.dsHotJudge.SubscribeTarget = null;
            this.dsHotJudge.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet9});
            this.dsHotJudge.UpdateEvent = "Click";
            this.dsHotJudge.UpdateMethod = null;
            this.dsHotJudge.UpdateTrigger = null;
            // 
            // schemal3DataSet9
            // 
            this.schemal3DataSet9.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet9L3DataTableGUID,
            this.coll3DataSet9L3DataTableName,
            this.coll3DataSet9L3DataTableOperator,
            this.coll3DataSet9L3DataTableShift,
            this.coll3DataSet9L3DataTableTeam,
            this.coldsHotJudgeL3DataTableHeatID,
            this.coldsHotJudgeL3DataTableCasterID,
            this.coldsHotJudgeL3DataTableSteelGradeIndex,
            this.coldsHotJudgeL3DataTableLength,
            this.coldsHotJudgeL3DataTableWidth,
            this.coldsHotJudgeL3DataTableThickness,
            this.coldsHotJudgeL3DataTableBloom_Count,
            this.coldsHotJudgeL3DataTableCal_Weight,
            this.coldsHotJudgeL3DataTableRight_Count,
            this.coldsHotJudgeL3DataTableRight_Weight,
            this.coldsHotJudgeL3DataTableWaster_Count,
            this.coldsHotJudgeL3DataTableWaster_Weight,
            this.coldsHotJudgeL3DataTableWaster_Count1,
            this.coldsHotJudgeL3DataTableWaster_Weight1,
            this.coldsHotJudgeL3DataTableWaster_Reason1,
            this.coldsHotJudgeL3DataTableWaster_Count2,
            this.coldsHotJudgeL3DataTableWaster_Weight2,
            this.coldsHotJudgeL3DataTableWaster_Reason2,
            this.coldsHotJudgeL3DataTableWaster_Count3,
            this.coldsHotJudgeL3DataTableWaster_Weight3,
            this.coldsHotJudgeL3DataTableWaster_Reason3,
            this.coldsHotJudgeL3DataTableWrong_Count,
            this.coldsHotJudgeL3DataTableWrong_Weight,
            this.coldsHotJudgeL3DataTableWrong_Count1,
            this.coldsHotJudgeL3DataTableWrong_Weight1,
            this.coldsHotJudgeL3DataTableWrong_Reason1,
            this.coldsHotJudgeL3DataTableWrong_Count2,
            this.coldsHotJudgeL3DataTableWrong_Weight2,
            this.coldsHotJudgeL3DataTableWrong_Reason2,
            this.coldsHotJudgeL3DataTableWrong_Count3,
            this.coldsHotJudgeL3DataTableWrong_Weight3,
            this.coldsHotJudgeL3DataTableWrong_Reason3,
            this.coldsHotJudgeL3DataTableSufaceDefactDes,
            this.coldsHotJudgeL3DataTableHotJudge_Time,
            this.coldsHotJudgeL3DataTableWaitCheckFlag});
            this.schemal3DataSet9.TableName = "L3DataTable";
            // 
            // coll3DataSet9L3DataTableGUID
            // 
            this.coll3DataSet9L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet9L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet9L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableName
            // 
            this.coll3DataSet9L3DataTableName.Caption = "Name";
            this.coll3DataSet9L3DataTableName.ColumnName = "Name";
            this.coll3DataSet9L3DataTableName.Namespace = "";
            // 
            // coll3DataSet9L3DataTableOperator
            // 
            this.coll3DataSet9L3DataTableOperator.Caption = "Operator";
            this.coll3DataSet9L3DataTableOperator.ColumnName = "Operator";
            this.coll3DataSet9L3DataTableOperator.Namespace = "";
            // 
            // coll3DataSet9L3DataTableShift
            // 
            this.coll3DataSet9L3DataTableShift.Caption = "Shift";
            this.coll3DataSet9L3DataTableShift.ColumnName = "Shift";
            this.coll3DataSet9L3DataTableShift.Namespace = "";
            // 
            // coll3DataSet9L3DataTableTeam
            // 
            this.coll3DataSet9L3DataTableTeam.Caption = "Team";
            this.coll3DataSet9L3DataTableTeam.ColumnName = "Team";
            this.coll3DataSet9L3DataTableTeam.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableHeatID
            // 
            this.coldsHotJudgeL3DataTableHeatID.Caption = "HeatID";
            this.coldsHotJudgeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHotJudgeL3DataTableHeatID.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableCasterID
            // 
            this.coldsHotJudgeL3DataTableCasterID.Caption = "CasterID";
            this.coldsHotJudgeL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsHotJudgeL3DataTableCasterID.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableSteelGradeIndex
            // 
            this.coldsHotJudgeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsHotJudgeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsHotJudgeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableLength
            // 
            this.coldsHotJudgeL3DataTableLength.Caption = "Length";
            this.coldsHotJudgeL3DataTableLength.ColumnName = "Length";
            this.coldsHotJudgeL3DataTableLength.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableLength.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWidth
            // 
            this.coldsHotJudgeL3DataTableWidth.Caption = "Width";
            this.coldsHotJudgeL3DataTableWidth.ColumnName = "Width";
            this.coldsHotJudgeL3DataTableWidth.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWidth.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableThickness
            // 
            this.coldsHotJudgeL3DataTableThickness.Caption = "Thickness";
            this.coldsHotJudgeL3DataTableThickness.ColumnName = "Thickness";
            this.coldsHotJudgeL3DataTableThickness.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableThickness.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableBloom_Count
            // 
            this.coldsHotJudgeL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsHotJudgeL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsHotJudgeL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableCal_Weight
            // 
            this.coldsHotJudgeL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsHotJudgeL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsHotJudgeL3DataTableCal_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableRight_Count
            // 
            this.coldsHotJudgeL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsHotJudgeL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsHotJudgeL3DataTableRight_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableRight_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableRight_Weight
            // 
            this.coldsHotJudgeL3DataTableRight_Weight.Caption = "Right_Weight";
            this.coldsHotJudgeL3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coldsHotJudgeL3DataTableRight_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableRight_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count
            // 
            this.coldsHotJudgeL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsHotJudgeL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsHotJudgeL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsHotJudgeL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsHotJudgeL3DataTableWaster_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count1
            // 
            this.coldsHotJudgeL3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coldsHotJudgeL3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coldsHotJudgeL3DataTableWaster_Count1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight1
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coldsHotJudgeL3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coldsHotJudgeL3DataTableWaster_Weight1.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason1
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coldsHotJudgeL3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coldsHotJudgeL3DataTableWaster_Reason1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count2
            // 
            this.coldsHotJudgeL3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coldsHotJudgeL3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coldsHotJudgeL3DataTableWaster_Count2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight2
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coldsHotJudgeL3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coldsHotJudgeL3DataTableWaster_Weight2.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason2
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coldsHotJudgeL3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coldsHotJudgeL3DataTableWaster_Reason2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count3
            // 
            this.coldsHotJudgeL3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coldsHotJudgeL3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coldsHotJudgeL3DataTableWaster_Count3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight3
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coldsHotJudgeL3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coldsHotJudgeL3DataTableWaster_Weight3.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason3
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coldsHotJudgeL3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coldsHotJudgeL3DataTableWaster_Reason3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count
            // 
            this.coldsHotJudgeL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsHotJudgeL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsHotJudgeL3DataTableWrong_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coldsHotJudgeL3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coldsHotJudgeL3DataTableWrong_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count1
            // 
            this.coldsHotJudgeL3DataTableWrong_Count1.Caption = "Wrong_Count1";
            this.coldsHotJudgeL3DataTableWrong_Count1.ColumnName = "Wrong_Count1";
            this.coldsHotJudgeL3DataTableWrong_Count1.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight1
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight1.Caption = "Wrong_Weight1";
            this.coldsHotJudgeL3DataTableWrong_Weight1.ColumnName = "Wrong_Weight1";
            this.coldsHotJudgeL3DataTableWrong_Weight1.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason1
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason1.Caption = "Wrong_Reason1";
            this.coldsHotJudgeL3DataTableWrong_Reason1.ColumnName = "Wrong_Reason1";
            this.coldsHotJudgeL3DataTableWrong_Reason1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count2
            // 
            this.coldsHotJudgeL3DataTableWrong_Count2.Caption = "Wrong_Count2";
            this.coldsHotJudgeL3DataTableWrong_Count2.ColumnName = "Wrong_Count2";
            this.coldsHotJudgeL3DataTableWrong_Count2.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight2
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight2.Caption = "Wrong_Weight2";
            this.coldsHotJudgeL3DataTableWrong_Weight2.ColumnName = "Wrong_Weight2";
            this.coldsHotJudgeL3DataTableWrong_Weight2.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason2
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason2.Caption = "Wrong_Reason2";
            this.coldsHotJudgeL3DataTableWrong_Reason2.ColumnName = "Wrong_Reason2";
            this.coldsHotJudgeL3DataTableWrong_Reason2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count3
            // 
            this.coldsHotJudgeL3DataTableWrong_Count3.Caption = "Wrong_Count3";
            this.coldsHotJudgeL3DataTableWrong_Count3.ColumnName = "Wrong_Count3";
            this.coldsHotJudgeL3DataTableWrong_Count3.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight3
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight3.Caption = "Wrong_Weight3";
            this.coldsHotJudgeL3DataTableWrong_Weight3.ColumnName = "Wrong_Weight3";
            this.coldsHotJudgeL3DataTableWrong_Weight3.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason3
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason3.Caption = "Wrong_Reason3";
            this.coldsHotJudgeL3DataTableWrong_Reason3.ColumnName = "Wrong_Reason3";
            this.coldsHotJudgeL3DataTableWrong_Reason3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableSufaceDefactDes
            // 
            this.coldsHotJudgeL3DataTableSufaceDefactDes.Caption = "SufaceDefactDes";
            this.coldsHotJudgeL3DataTableSufaceDefactDes.ColumnName = "SufaceDefactDes";
            this.coldsHotJudgeL3DataTableSufaceDefactDes.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableHotJudge_Time
            // 
            this.coldsHotJudgeL3DataTableHotJudge_Time.Caption = "HotJudge_Time";
            this.coldsHotJudgeL3DataTableHotJudge_Time.ColumnName = "HotJudge_Time";
            this.coldsHotJudgeL3DataTableHotJudge_Time.DataType = typeof(System.DateTime);
            this.coldsHotJudgeL3DataTableHotJudge_Time.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaitCheckFlag
            // 
            this.coldsHotJudgeL3DataTableWaitCheckFlag.Caption = "WaitCheckFlag";
            this.coldsHotJudgeL3DataTableWaitCheckFlag.ColumnName = "WaitCheckFlag";
            this.coldsHotJudgeL3DataTableWaitCheckFlag.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWaitCheckFlag.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsHotJudge;
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
            this.txtHeatID,
            this.toolStripLabel5,
            this.cmbSteelGradeIndex,
            this.toolStripLabel4,
            this.dtHotJudgeEndData,
            this.toolStripLabel2,
            this.dtHotJudgeData,
            this.toolStripLabel6,
            this.btnOutput});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1014, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
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
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "炉号:";
            // 
            // cmbSteelGradeIndex
            // 
            this.cmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSteelGradeIndex.Name = "cmbSteelGradeIndex";
            this.cmbSteelGradeIndex.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "炼钢记号";
            // 
            // dtHotJudgeEndData
            // 
            this.dtHotJudgeEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtHotJudgeEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtHotJudgeEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtHotJudgeEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtHotJudgeEndData.CustomFormat = "yyyy-MM-dd";
            this.dtHotJudgeEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHotJudgeEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtHotJudgeEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtHotJudgeEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtHotJudgeEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtHotJudgeEndData.Name = "dtHotJudgeEndData";
            this.dtHotJudgeEndData.Size = new System.Drawing.Size(85, 22);
            this.dtHotJudgeEndData.Text = "2009-01-04";
            this.dtHotJudgeEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtHotJudgeData
            // 
            this.dtHotJudgeData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtHotJudgeData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtHotJudgeData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtHotJudgeData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtHotJudgeData.CustomFormat = "yyyy-MM-dd";
            this.dtHotJudgeData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHotJudgeData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtHotJudgeData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtHotJudgeData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtHotJudgeData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtHotJudgeData.Name = "dtHotJudgeData";
            this.dtHotJudgeData.Size = new System.Drawing.Size(85, 22);
            this.dtHotJudgeData.Text = "2008-11-16";
            this.dtHotJudgeData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "热检日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoLoad = true;
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = null;
            this.dsSteelGradeIndex.SourceMethod = "";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = null;
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.Frozen = true;
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.Frozen = true;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.Frozen = true;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.DataSource = this.dsCaster;
            this.casterIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.casterIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.casterIDDataGridViewTextBoxColumn.Frozen = true;
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.casterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.casterIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.casterIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // hotJudgeTimeDataGridViewTextBoxColumn
            // 
            this.hotJudgeTimeDataGridViewTextBoxColumn.DataPropertyName = "HotJudge_Time";
            this.hotJudgeTimeDataGridViewTextBoxColumn.HeaderText = "热检时间";
            this.hotJudgeTimeDataGridViewTextBoxColumn.Name = "hotJudgeTimeDataGridViewTextBoxColumn";
            this.hotJudgeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotJudgeTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 80;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 80;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            this.thicknessDataGridViewTextBoxColumn.Width = 80;
            // 
            // bloomCountDataGridViewTextBoxColumn
            // 
            this.bloomCountDataGridViewTextBoxColumn.DataPropertyName = "Bloom_Count";
            this.bloomCountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bloomCountDataGridViewTextBoxColumn.Name = "bloomCountDataGridViewTextBoxColumn";
            this.bloomCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloomCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // calWeightDataGridViewTextBoxColumn
            // 
            this.calWeightDataGridViewTextBoxColumn.DataPropertyName = "Cal_Weight";
            this.calWeightDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.calWeightDataGridViewTextBoxColumn.Name = "calWeightDataGridViewTextBoxColumn";
            this.calWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.calWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // rightCountDataGridViewTextBoxColumn
            // 
            this.rightCountDataGridViewTextBoxColumn.DataPropertyName = "Right_Count";
            this.rightCountDataGridViewTextBoxColumn.HeaderText = "合格支数";
            this.rightCountDataGridViewTextBoxColumn.Name = "rightCountDataGridViewTextBoxColumn";
            this.rightCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.rightCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // rightWeightDataGridViewTextBoxColumn
            // 
            this.rightWeightDataGridViewTextBoxColumn.DataPropertyName = "Right_Weight";
            this.rightWeightDataGridViewTextBoxColumn.HeaderText = "合格重量";
            this.rightWeightDataGridViewTextBoxColumn.Name = "rightWeightDataGridViewTextBoxColumn";
            this.rightWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.rightWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // wasterCountDataGridViewTextBoxColumn
            // 
            this.wasterCountDataGridViewTextBoxColumn.DataPropertyName = "Waster_Count";
            this.wasterCountDataGridViewTextBoxColumn.HeaderText = "甩废总长度";
            this.wasterCountDataGridViewTextBoxColumn.Name = "wasterCountDataGridViewTextBoxColumn";
            this.wasterCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCountDataGridViewTextBoxColumn.Width = 90;
            // 
            // wasterWeightDataGridViewTextBoxColumn
            // 
            this.wasterWeightDataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight";
            this.wasterWeightDataGridViewTextBoxColumn.HeaderText = "甩废总重量";
            this.wasterWeightDataGridViewTextBoxColumn.Name = "wasterWeightDataGridViewTextBoxColumn";
            this.wasterWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // wasterCount1DataGridViewTextBoxColumn
            // 
            this.wasterCount1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count1";
            this.wasterCount1DataGridViewTextBoxColumn.HeaderText = "甩废长度1";
            this.wasterCount1DataGridViewTextBoxColumn.Name = "wasterCount1DataGridViewTextBoxColumn";
            this.wasterCount1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight1DataGridViewTextBoxColumn
            // 
            this.wasterWeight1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight1";
            this.wasterWeight1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wasterWeight1DataGridViewTextBoxColumn.Name = "wasterWeight1DataGridViewTextBoxColumn";
            this.wasterWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason1DataGridViewTextBoxColumn
            // 
            this.wasterReason1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason1";
            this.wasterReason1DataGridViewTextBoxColumn.DataSource = this.bsWasterReason1;
            this.wasterReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wasterReason1DataGridViewTextBoxColumn.Name = "wasterReason1DataGridViewTextBoxColumn";
            this.wasterReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterCount2DataGridViewTextBoxColumn
            // 
            this.wasterCount2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count2";
            this.wasterCount2DataGridViewTextBoxColumn.HeaderText = "甩废长度2";
            this.wasterCount2DataGridViewTextBoxColumn.Name = "wasterCount2DataGridViewTextBoxColumn";
            this.wasterCount2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight2DataGridViewTextBoxColumn
            // 
            this.wasterWeight2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight2";
            this.wasterWeight2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wasterWeight2DataGridViewTextBoxColumn.Name = "wasterWeight2DataGridViewTextBoxColumn";
            this.wasterWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason2DataGridViewTextBoxColumn
            // 
            this.wasterReason2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason2";
            this.wasterReason2DataGridViewTextBoxColumn.DataSource = this.bsWasterReason2;
            this.wasterReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wasterReason2DataGridViewTextBoxColumn.Name = "wasterReason2DataGridViewTextBoxColumn";
            this.wasterReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterCount3DataGridViewTextBoxColumn
            // 
            this.wasterCount3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count3";
            this.wasterCount3DataGridViewTextBoxColumn.HeaderText = "甩废长度3";
            this.wasterCount3DataGridViewTextBoxColumn.Name = "wasterCount3DataGridViewTextBoxColumn";
            this.wasterCount3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight3DataGridViewTextBoxColumn
            // 
            this.wasterWeight3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight3";
            this.wasterWeight3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wasterWeight3DataGridViewTextBoxColumn.Name = "wasterWeight3DataGridViewTextBoxColumn";
            this.wasterWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason3DataGridViewTextBoxColumn
            // 
            this.wasterReason3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason3";
            this.wasterReason3DataGridViewTextBoxColumn.DataSource = this.bsWasterReason3;
            this.wasterReason3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wasterReason3DataGridViewTextBoxColumn.Name = "wasterReason3DataGridViewTextBoxColumn";
            this.wasterReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason3DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wrongCountDataGridViewTextBoxColumn
            // 
            this.wrongCountDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count";
            this.wrongCountDataGridViewTextBoxColumn.HeaderText = "不合格总支数";
            this.wrongCountDataGridViewTextBoxColumn.Name = "wrongCountDataGridViewTextBoxColumn";
            this.wrongCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCountDataGridViewTextBoxColumn.Width = 102;
            // 
            // wrongWeightDataGridViewTextBoxColumn
            // 
            this.wrongWeightDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight";
            this.wrongWeightDataGridViewTextBoxColumn.HeaderText = "不合格总重量";
            this.wrongWeightDataGridViewTextBoxColumn.Name = "wrongWeightDataGridViewTextBoxColumn";
            this.wrongWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeightDataGridViewTextBoxColumn.Width = 102;
            // 
            // wrongCount1DataGridViewTextBoxColumn
            // 
            this.wrongCount1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count1";
            this.wrongCount1DataGridViewTextBoxColumn.HeaderText = "不合格支数1";
            this.wrongCount1DataGridViewTextBoxColumn.Name = "wrongCount1DataGridViewTextBoxColumn";
            this.wrongCount1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount1DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight1DataGridViewTextBoxColumn
            // 
            this.wrongWeight1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight1";
            this.wrongWeight1DataGridViewTextBoxColumn.HeaderText = "不合格重量1";
            this.wrongWeight1DataGridViewTextBoxColumn.Name = "wrongWeight1DataGridViewTextBoxColumn";
            this.wrongWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight1DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason1DataGridViewTextBoxColumn
            // 
            this.wrongReason1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason1";
            this.wrongReason1DataGridViewTextBoxColumn.DataSource = this.bsWrongReason1;
            this.wrongReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason1DataGridViewTextBoxColumn.HeaderText = "不合格原因1";
            this.wrongReason1DataGridViewTextBoxColumn.Name = "wrongReason1DataGridViewTextBoxColumn";
            this.wrongReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason1DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongCount2DataGridViewTextBoxColumn
            // 
            this.wrongCount2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count2";
            this.wrongCount2DataGridViewTextBoxColumn.HeaderText = "不合格支数2";
            this.wrongCount2DataGridViewTextBoxColumn.Name = "wrongCount2DataGridViewTextBoxColumn";
            this.wrongCount2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount2DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight2DataGridViewTextBoxColumn
            // 
            this.wrongWeight2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight2";
            this.wrongWeight2DataGridViewTextBoxColumn.HeaderText = "不合格重量2";
            this.wrongWeight2DataGridViewTextBoxColumn.Name = "wrongWeight2DataGridViewTextBoxColumn";
            this.wrongWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight2DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason2DataGridViewTextBoxColumn
            // 
            this.wrongReason2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason2";
            this.wrongReason2DataGridViewTextBoxColumn.DataSource = this.bsWrongReason2;
            this.wrongReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason2DataGridViewTextBoxColumn.HeaderText = "不合格原因2";
            this.wrongReason2DataGridViewTextBoxColumn.Name = "wrongReason2DataGridViewTextBoxColumn";
            this.wrongReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason2DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongCount3DataGridViewTextBoxColumn
            // 
            this.wrongCount3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count3";
            this.wrongCount3DataGridViewTextBoxColumn.HeaderText = "不合格支数3";
            this.wrongCount3DataGridViewTextBoxColumn.Name = "wrongCount3DataGridViewTextBoxColumn";
            this.wrongCount3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount3DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight3DataGridViewTextBoxColumn
            // 
            this.wrongWeight3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight3";
            this.wrongWeight3DataGridViewTextBoxColumn.HeaderText = "不合格重量3";
            this.wrongWeight3DataGridViewTextBoxColumn.Name = "wrongWeight3DataGridViewTextBoxColumn";
            this.wrongWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight3DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason3DataGridViewTextBoxColumn
            // 
            this.wrongReason3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason3";
            this.wrongReason3DataGridViewTextBoxColumn.DataSource = this.bsWrongReason3;
            this.wrongReason3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason3DataGridViewTextBoxColumn.HeaderText = "不合格原因3";
            this.wrongReason3DataGridViewTextBoxColumn.Name = "wrongReason3DataGridViewTextBoxColumn";
            this.wrongReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason3DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason3DataGridViewTextBoxColumn.Width = 96;
            // 
            // sufaceDefactDesDataGridViewTextBoxColumn
            // 
            this.sufaceDefactDesDataGridViewTextBoxColumn.DataPropertyName = "SufaceDefactDes";
            this.sufaceDefactDesDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sufaceDefactDesDataGridViewTextBoxColumn.Name = "sufaceDefactDesDataGridViewTextBoxColumn";
            this.sufaceDefactDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sufaceDefactDesDataGridViewTextBoxColumn.Width = 102;
            // 
            // waitCheckFlagDataGridViewTextBoxColumn
            // 
            this.waitCheckFlagDataGridViewTextBoxColumn.DataPropertyName = "WaitCheckFlag";
            this.waitCheckFlagDataGridViewTextBoxColumn.HeaderText = "等待判定标志";
            this.waitCheckFlagDataGridViewTextBoxColumn.Name = "waitCheckFlagDataGridViewTextBoxColumn";
            this.waitCheckFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.waitCheckFlagDataGridViewTextBoxColumn.Width = 102;
            // 
            // HotJudgeQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "HotJudgeQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "热检质量判定查询";
            this.Text = "热检质量判定查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotJudgeQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.InStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHotJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtHotJudgeData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsHotJudge;
        private AppSvrHMI.L3DataSet dsHotJudge;
        private System.Data.DataTable schemal3DataSet9;
        private System.Data.DataColumn coll3DataSet9L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet9L3DataTableName;
        private System.Data.DataColumn coll3DataSet9L3DataTableOperator;
        private System.Data.DataColumn coll3DataSet9L3DataTableShift;
        private System.Data.DataColumn coll3DataSet9L3DataTableTeam;
        private System.Data.DataColumn coldsHotJudgeL3DataTableHeatID;
        private System.Data.DataColumn coldsHotJudgeL3DataTableCasterID;
        private System.Data.DataColumn coldsHotJudgeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsHotJudgeL3DataTableLength;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWidth;
        private System.Data.DataColumn coldsHotJudgeL3DataTableThickness;
        private System.Data.DataColumn coldsHotJudgeL3DataTableBloom_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableCal_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableRight_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableRight_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableSufaceDefactDes;
        private System.Data.DataColumn coldsHotJudgeL3DataTableHotJudge_Time;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaitCheckFlag;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCaster;
        private System.Data.DataTable schemadsCaster;
        private System.Data.DataColumn coldsCasterL3DataTableCode;
        private System.Data.DataColumn coldsCasterL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWasterReason1;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Windows.Forms.BindingSource bsWasterReason2;
        private System.Windows.Forms.BindingSource bsWasterReason3;
        private System.Windows.Forms.BindingSource bsWrongReason1;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Windows.Forms.BindingSource bsWrongReason2;
        private System.Windows.Forms.BindingSource bsWrongReason3;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtHotJudgeEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotJudgeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloomCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sufaceDefactDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waitCheckFlagDataGridViewTextBoxColumn;
    }
}