namespace UnitMag.CCMMag
{
    partial class CCMScrapDutyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCMScrapDutyFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnWasterData = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsWasterData = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterData = new AppSvrHMI.L3DataSet();
            this.schemadsWasterData = new System.Data.DataTable();
            this.coldsWasterDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableProduce_Date = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableCut_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableThickness = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWidth = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableLength = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Shop1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Shop2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Shop3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Unit1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Unit2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Unit3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableDuty_Per1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableDuty_Per2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableDuty_Per3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableTeamID1 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableTeamID2 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableTeamID3 = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableConfirm_Per = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Operator = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableWaster_Date = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableShitID = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableDuty_Flag = new System.Data.DataColumn();
            this.coldsWasterDataL3DataTableObject_ID = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvWasterData = new System.Windows.Forms.DataGridView();
            this.produceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloomCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.wasterShop1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterUnit1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyPer1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.wasterCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterShop2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterUnit2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyPer2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wasterShop3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterUnit3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dutyPer3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamID3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.confirmPerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTablecode = new System.Data.DataColumn();
            this.coldsShiftL3DataTablecode_des = new System.Data.DataColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Duty_Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnWasterData)).BeginInit();
            this.bnWasterData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterData)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWasterData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bnWasterData
            // 
            this.bnWasterData.AddNewItem = null;
            this.bnWasterData.BindingSource = this.bsWasterData;
            this.bnWasterData.CountItem = this.bindingNavigatorCountItem;
            this.bnWasterData.DeleteItem = null;
            this.bnWasterData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.txtHeatID,
            this.toolStripLabel2,
            this.dtTime,
            this.toolStripLabel3});
            this.bnWasterData.Location = new System.Drawing.Point(0, 0);
            this.bnWasterData.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnWasterData.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnWasterData.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnWasterData.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnWasterData.Name = "bnWasterData";
            this.bnWasterData.PositionItem = this.bindingNavigatorPositionItem;
            this.bnWasterData.Size = new System.Drawing.Size(986, 25);
            this.bnWasterData.TabIndex = 0;
            this.bnWasterData.Text = "bindingNavigator1";
            // 
            // bsWasterData
            // 
            this.bsWasterData.DataMember = "L3DataTable";
            this.bsWasterData.DataSource = this.dsWasterData;
            // 
            // dsWasterData
            // 
            this.dsWasterData.AutoSubscribe = false;
            this.dsWasterData.DataSetName = "L3DataSet";
            this.dsWasterData.DeleteMethod = "";
            this.dsWasterData.InsertMethod = "";
            this.dsWasterData.L3DataAdapter = null;
            this.dsWasterData.LoadEvent = "";
            this.dsWasterData.LoadTrigger = null;
            this.dsWasterData.RefreshValve = 1000;
            this.dsWasterData.SourceCommand = null;
            this.dsWasterData.SourceCondition = "1=2";
            this.dsWasterData.SourceMethod = "";
            this.dsWasterData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterData.SourceURI = "XGMESLogic\\QualityMag\\CQA_Bloom_Waster_Data";
            this.dsWasterData.SubscribeTarget = null;
            this.dsWasterData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterData});
            this.dsWasterData.UpdateEvent = "";
            this.dsWasterData.UpdateMethod = "";
            this.dsWasterData.UpdateTrigger = null;
            // 
            // schemadsWasterData
            // 
            this.schemadsWasterData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterDataL3DataTableGUID,
            this.coldsWasterDataL3DataTableProduce_Date,
            this.coldsWasterDataL3DataTableHeatID,
            this.coldsWasterDataL3DataTableSteelGradeIndex,
            this.coldsWasterDataL3DataTableCut_SteelGradeIndex,
            this.coldsWasterDataL3DataTableThickness,
            this.coldsWasterDataL3DataTableWidth,
            this.coldsWasterDataL3DataTableLength,
            this.coldsWasterDataL3DataTableBloom_Count,
            this.coldsWasterDataL3DataTableCal_Weight,
            this.coldsWasterDataL3DataTableWaster_Count,
            this.coldsWasterDataL3DataTableWaster_Weight,
            this.coldsWasterDataL3DataTableWaster_Count1,
            this.coldsWasterDataL3DataTableWaster_Weight1,
            this.coldsWasterDataL3DataTableWaster_Reason1,
            this.coldsWasterDataL3DataTableWaster_Count2,
            this.coldsWasterDataL3DataTableWaster_Weight2,
            this.coldsWasterDataL3DataTableWaster_Reason2,
            this.coldsWasterDataL3DataTableWaster_Count3,
            this.coldsWasterDataL3DataTableWaster_Weight3,
            this.coldsWasterDataL3DataTableWaster_Reason3,
            this.coldsWasterDataL3DataTableWaster_Shop1,
            this.coldsWasterDataL3DataTableWaster_Shop2,
            this.coldsWasterDataL3DataTableWaster_Shop3,
            this.coldsWasterDataL3DataTableWaster_Unit1,
            this.coldsWasterDataL3DataTableWaster_Unit2,
            this.coldsWasterDataL3DataTableWaster_Unit3,
            this.coldsWasterDataL3DataTableDuty_Per1,
            this.coldsWasterDataL3DataTableDuty_Per2,
            this.coldsWasterDataL3DataTableDuty_Per3,
            this.coldsWasterDataL3DataTableTeamID1,
            this.coldsWasterDataL3DataTableTeamID2,
            this.coldsWasterDataL3DataTableTeamID3,
            this.coldsWasterDataL3DataTableConfirm_Per,
            this.coldsWasterDataL3DataTableWaster_Operator,
            this.coldsWasterDataL3DataTableWaster_Date,
            this.coldsWasterDataL3DataTableShitID,
            this.coldsWasterDataL3DataTableTeamID,
            this.coldsWasterDataL3DataTableCasterID,
            this.coldsWasterDataL3DataTableDuty_Flag,
            this.coldsWasterDataL3DataTableObject_ID});
            this.schemadsWasterData.TableName = "L3DataTable";
            // 
            // coldsWasterDataL3DataTableGUID
            // 
            this.coldsWasterDataL3DataTableGUID.Caption = "GUID";
            this.coldsWasterDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsWasterDataL3DataTableGUID.Namespace = "";
            // 
            // coldsWasterDataL3DataTableProduce_Date
            // 
            this.coldsWasterDataL3DataTableProduce_Date.Caption = "Produce_Date";
            this.coldsWasterDataL3DataTableProduce_Date.ColumnName = "Produce_Date";
            this.coldsWasterDataL3DataTableProduce_Date.DataType = typeof(System.DateTime);
            this.coldsWasterDataL3DataTableProduce_Date.Namespace = "";
            // 
            // coldsWasterDataL3DataTableHeatID
            // 
            this.coldsWasterDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsWasterDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsWasterDataL3DataTableHeatID.Namespace = "";
            // 
            // coldsWasterDataL3DataTableSteelGradeIndex
            // 
            this.coldsWasterDataL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsWasterDataL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsWasterDataL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsWasterDataL3DataTableCut_SteelGradeIndex
            // 
            this.coldsWasterDataL3DataTableCut_SteelGradeIndex.Caption = "Cut_SteelGradeIndex";
            this.coldsWasterDataL3DataTableCut_SteelGradeIndex.ColumnName = "Cut_SteelGradeIndex";
            this.coldsWasterDataL3DataTableCut_SteelGradeIndex.Namespace = "";
            // 
            // coldsWasterDataL3DataTableThickness
            // 
            this.coldsWasterDataL3DataTableThickness.Caption = "Thickness";
            this.coldsWasterDataL3DataTableThickness.ColumnName = "Thickness";
            this.coldsWasterDataL3DataTableThickness.DataType = typeof(int);
            this.coldsWasterDataL3DataTableThickness.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWidth
            // 
            this.coldsWasterDataL3DataTableWidth.Caption = "Width";
            this.coldsWasterDataL3DataTableWidth.ColumnName = "Width";
            this.coldsWasterDataL3DataTableWidth.DataType = typeof(int);
            this.coldsWasterDataL3DataTableWidth.Namespace = "";
            // 
            // coldsWasterDataL3DataTableLength
            // 
            this.coldsWasterDataL3DataTableLength.Caption = "Length";
            this.coldsWasterDataL3DataTableLength.ColumnName = "Length";
            this.coldsWasterDataL3DataTableLength.DataType = typeof(int);
            this.coldsWasterDataL3DataTableLength.Namespace = "";
            // 
            // coldsWasterDataL3DataTableBloom_Count
            // 
            this.coldsWasterDataL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsWasterDataL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsWasterDataL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsWasterDataL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsWasterDataL3DataTableCal_Weight
            // 
            this.coldsWasterDataL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsWasterDataL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsWasterDataL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Count
            // 
            this.coldsWasterDataL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsWasterDataL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsWasterDataL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Weight
            // 
            this.coldsWasterDataL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsWasterDataL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsWasterDataL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Count1
            // 
            this.coldsWasterDataL3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coldsWasterDataL3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coldsWasterDataL3DataTableWaster_Count1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Weight1
            // 
            this.coldsWasterDataL3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coldsWasterDataL3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coldsWasterDataL3DataTableWaster_Weight1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Reason1
            // 
            this.coldsWasterDataL3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coldsWasterDataL3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coldsWasterDataL3DataTableWaster_Reason1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Count2
            // 
            this.coldsWasterDataL3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coldsWasterDataL3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coldsWasterDataL3DataTableWaster_Count2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Weight2
            // 
            this.coldsWasterDataL3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coldsWasterDataL3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coldsWasterDataL3DataTableWaster_Weight2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Reason2
            // 
            this.coldsWasterDataL3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coldsWasterDataL3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coldsWasterDataL3DataTableWaster_Reason2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Count3
            // 
            this.coldsWasterDataL3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coldsWasterDataL3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coldsWasterDataL3DataTableWaster_Count3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Weight3
            // 
            this.coldsWasterDataL3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coldsWasterDataL3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coldsWasterDataL3DataTableWaster_Weight3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Reason3
            // 
            this.coldsWasterDataL3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coldsWasterDataL3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coldsWasterDataL3DataTableWaster_Reason3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Shop1
            // 
            this.coldsWasterDataL3DataTableWaster_Shop1.Caption = "Waster_Shop1";
            this.coldsWasterDataL3DataTableWaster_Shop1.ColumnName = "Waster_Shop1";
            this.coldsWasterDataL3DataTableWaster_Shop1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Shop2
            // 
            this.coldsWasterDataL3DataTableWaster_Shop2.Caption = "Waster_Shop2";
            this.coldsWasterDataL3DataTableWaster_Shop2.ColumnName = "Waster_Shop2";
            this.coldsWasterDataL3DataTableWaster_Shop2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Shop3
            // 
            this.coldsWasterDataL3DataTableWaster_Shop3.Caption = "Waster_Shop3";
            this.coldsWasterDataL3DataTableWaster_Shop3.ColumnName = "Waster_Shop3";
            this.coldsWasterDataL3DataTableWaster_Shop3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Unit1
            // 
            this.coldsWasterDataL3DataTableWaster_Unit1.Caption = "Waster_Unit1";
            this.coldsWasterDataL3DataTableWaster_Unit1.ColumnName = "Waster_Unit1";
            this.coldsWasterDataL3DataTableWaster_Unit1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Unit2
            // 
            this.coldsWasterDataL3DataTableWaster_Unit2.Caption = "Waster_Unit2";
            this.coldsWasterDataL3DataTableWaster_Unit2.ColumnName = "Waster_Unit2";
            this.coldsWasterDataL3DataTableWaster_Unit2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Unit3
            // 
            this.coldsWasterDataL3DataTableWaster_Unit3.Caption = "Waster_Unit3";
            this.coldsWasterDataL3DataTableWaster_Unit3.ColumnName = "Waster_Unit3";
            this.coldsWasterDataL3DataTableWaster_Unit3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableDuty_Per1
            // 
            this.coldsWasterDataL3DataTableDuty_Per1.Caption = "Duty_Per1";
            this.coldsWasterDataL3DataTableDuty_Per1.ColumnName = "Duty_Per1";
            this.coldsWasterDataL3DataTableDuty_Per1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableDuty_Per2
            // 
            this.coldsWasterDataL3DataTableDuty_Per2.Caption = "Duty_Per2";
            this.coldsWasterDataL3DataTableDuty_Per2.ColumnName = "Duty_Per2";
            this.coldsWasterDataL3DataTableDuty_Per2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableDuty_Per3
            // 
            this.coldsWasterDataL3DataTableDuty_Per3.Caption = "Duty_Per3";
            this.coldsWasterDataL3DataTableDuty_Per3.ColumnName = "Duty_Per3";
            this.coldsWasterDataL3DataTableDuty_Per3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableTeamID1
            // 
            this.coldsWasterDataL3DataTableTeamID1.Caption = "TeamID1";
            this.coldsWasterDataL3DataTableTeamID1.ColumnName = "TeamID1";
            this.coldsWasterDataL3DataTableTeamID1.Namespace = "";
            // 
            // coldsWasterDataL3DataTableTeamID2
            // 
            this.coldsWasterDataL3DataTableTeamID2.Caption = "TeamID2";
            this.coldsWasterDataL3DataTableTeamID2.ColumnName = "TeamID2";
            this.coldsWasterDataL3DataTableTeamID2.Namespace = "";
            // 
            // coldsWasterDataL3DataTableTeamID3
            // 
            this.coldsWasterDataL3DataTableTeamID3.Caption = "TeamID3";
            this.coldsWasterDataL3DataTableTeamID3.ColumnName = "TeamID3";
            this.coldsWasterDataL3DataTableTeamID3.Namespace = "";
            // 
            // coldsWasterDataL3DataTableConfirm_Per
            // 
            this.coldsWasterDataL3DataTableConfirm_Per.Caption = "Confirm_Per";
            this.coldsWasterDataL3DataTableConfirm_Per.ColumnName = "Confirm_Per";
            this.coldsWasterDataL3DataTableConfirm_Per.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Operator
            // 
            this.coldsWasterDataL3DataTableWaster_Operator.Caption = "Waster_Operator";
            this.coldsWasterDataL3DataTableWaster_Operator.ColumnName = "Waster_Operator";
            this.coldsWasterDataL3DataTableWaster_Operator.Namespace = "";
            // 
            // coldsWasterDataL3DataTableWaster_Date
            // 
            this.coldsWasterDataL3DataTableWaster_Date.Caption = "Waster_Date";
            this.coldsWasterDataL3DataTableWaster_Date.ColumnName = "Waster_Date";
            this.coldsWasterDataL3DataTableWaster_Date.DataType = typeof(System.DateTime);
            this.coldsWasterDataL3DataTableWaster_Date.Namespace = "";
            // 
            // coldsWasterDataL3DataTableShitID
            // 
            this.coldsWasterDataL3DataTableShitID.Caption = "ShitID";
            this.coldsWasterDataL3DataTableShitID.ColumnName = "ShitID";
            this.coldsWasterDataL3DataTableShitID.Namespace = "";
            // 
            // coldsWasterDataL3DataTableTeamID
            // 
            this.coldsWasterDataL3DataTableTeamID.Caption = "TeamID";
            this.coldsWasterDataL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsWasterDataL3DataTableTeamID.Namespace = "";
            // 
            // coldsWasterDataL3DataTableCasterID
            // 
            this.coldsWasterDataL3DataTableCasterID.Caption = "CasterID";
            this.coldsWasterDataL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsWasterDataL3DataTableCasterID.Namespace = "";
            // 
            // coldsWasterDataL3DataTableDuty_Flag
            // 
            this.coldsWasterDataL3DataTableDuty_Flag.Caption = "Duty_Flag";
            this.coldsWasterDataL3DataTableDuty_Flag.ColumnName = "Duty_Flag";
            this.coldsWasterDataL3DataTableDuty_Flag.DataType = typeof(int);
            this.coldsWasterDataL3DataTableDuty_Flag.Namespace = "";
            // 
            // coldsWasterDataL3DataTableObject_ID
            // 
            this.coldsWasterDataL3DataTableObject_ID.Caption = "Object_ID";
            this.coldsWasterDataL3DataTableObject_ID.ColumnName = "Object_ID";
            this.coldsWasterDataL3DataTableObject_ID.Namespace = "";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "炉号:";
            // 
            // dtTime
            // 
            this.dtTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtTime.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtTime.CustomFormat = "yyyy-MM-dd";
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(100, 22);
            this.dtTime.Text = "2008-11-16";
            this.dtTime.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "甩废日期:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvWasterData);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(986, 474);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvWasterData
            // 
            this.dvWasterData.AllowUserToAddRows = false;
            this.dvWasterData.AutoGenerateColumns = false;
            this.dvWasterData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvWasterData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWasterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvWasterData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produceDateDataGridViewTextBoxColumn,
            this.HeatID,
            this.casterIDDataGridViewTextBoxColumn,
            this.wasterDateDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.cutSteelGradeIndexDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.bloomCountDataGridViewTextBoxColumn,
            this.calWeightDataGridViewTextBoxColumn,
            this.wasterCountDataGridViewTextBoxColumn,
            this.wasterWeightDataGridViewTextBoxColumn,
            this.wasterCount1DataGridViewTextBoxColumn,
            this.wasterWeight1DataGridViewTextBoxColumn,
            this.wasterReason1DataGridViewTextBoxColumn,
            this.wasterShop1DataGridViewTextBoxColumn,
            this.wasterUnit1DataGridViewTextBoxColumn,
            this.dutyPer1DataGridViewTextBoxColumn,
            this.teamID1DataGridViewTextBoxColumn,
            this.wasterCount2DataGridViewTextBoxColumn,
            this.wasterWeight2DataGridViewTextBoxColumn,
            this.wasterReason2DataGridViewTextBoxColumn,
            this.wasterShop2DataGridViewTextBoxColumn,
            this.wasterUnit2DataGridViewTextBoxColumn,
            this.dutyPer2DataGridViewTextBoxColumn,
            this.teamID2DataGridViewTextBoxColumn,
            this.wasterCount3DataGridViewTextBoxColumn,
            this.wasterWeight3DataGridViewTextBoxColumn,
            this.wasterReason3DataGridViewTextBoxColumn,
            this.wasterShop3DataGridViewTextBoxColumn,
            this.wasterUnit3DataGridViewTextBoxColumn,
            this.dutyPer3DataGridViewTextBoxColumn,
            this.teamID3DataGridViewTextBoxColumn,
            this.confirmPerDataGridViewTextBoxColumn,
            this.wasterOperatorDataGridViewTextBoxColumn,
            this.shitIDDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.Duty_Flag});
            this.dvWasterData.DataSource = this.bsWasterData;
            this.dvWasterData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWasterData.Location = new System.Drawing.Point(0, 0);
            this.dvWasterData.Name = "dvWasterData";
            this.dvWasterData.ReadOnly = true;
            this.dvWasterData.RowTemplate.Height = 23;
            this.dvWasterData.Size = new System.Drawing.Size(986, 474);
            this.dvWasterData.TabIndex = 0;
            this.dvWasterData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvWasterData_CellDoubleClick);
            this.dvWasterData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvWasterData_DataBindingComplete);
            this.dvWasterData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvWasterData_DataError);
            // 
            // produceDateDataGridViewTextBoxColumn
            // 
            this.produceDateDataGridViewTextBoxColumn.DataPropertyName = "Produce_Date";
            this.produceDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.produceDateDataGridViewTextBoxColumn.Name = "produceDateDataGridViewTextBoxColumn";
            this.produceDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.produceDateDataGridViewTextBoxColumn.Visible = false;
            this.produceDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            this.HeatID.ReadOnly = true;
            this.HeatID.Width = 54;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // wasterDateDataGridViewTextBoxColumn
            // 
            this.wasterDateDataGridViewTextBoxColumn.DataPropertyName = "Waster_Date";
            this.wasterDateDataGridViewTextBoxColumn.HeaderText = "甩废日期";
            this.wasterDateDataGridViewTextBoxColumn.Name = "wasterDateDataGridViewTextBoxColumn";
            this.wasterDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // cutSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Cut_SteelGradeIndex";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Name = "cutSteelGradeIndexDataGridViewTextBoxColumn";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            this.thicknessDataGridViewTextBoxColumn.Width = 54;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 54;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 54;
            // 
            // bloomCountDataGridViewTextBoxColumn
            // 
            this.bloomCountDataGridViewTextBoxColumn.DataPropertyName = "Bloom_Count";
            this.bloomCountDataGridViewTextBoxColumn.HeaderText = "钢坯枝数";
            this.bloomCountDataGridViewTextBoxColumn.Name = "bloomCountDataGridViewTextBoxColumn";
            this.bloomCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloomCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // calWeightDataGridViewTextBoxColumn
            // 
            this.calWeightDataGridViewTextBoxColumn.DataPropertyName = "Cal_Weight";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.calWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.calWeightDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.calWeightDataGridViewTextBoxColumn.Name = "calWeightDataGridViewTextBoxColumn";
            this.calWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.calWeightDataGridViewTextBoxColumn.Width = 78;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.wasterWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.wasterWeight1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.wasterWeight1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wasterWeight1DataGridViewTextBoxColumn.Name = "wasterWeight1DataGridViewTextBoxColumn";
            this.wasterWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason1DataGridViewTextBoxColumn
            // 
            this.wasterReason1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason1";
            this.wasterReason1DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wasterReason1DataGridViewTextBoxColumn.Name = "wasterReason1DataGridViewTextBoxColumn";
            this.wasterReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.wasterReason1DataGridViewTextBoxColumn.Width = 84;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoSubscribe = true;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = "";
            this.dsWasterReason.InsertMethod = "";
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\' ORDER BY CODE";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "";
            this.dsWasterReason.UpdateMethod = "";
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
            // wasterShop1DataGridViewTextBoxColumn
            // 
            this.wasterShop1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Shop1";
            this.wasterShop1DataGridViewTextBoxColumn.HeaderText = "责任车间1";
            this.wasterShop1DataGridViewTextBoxColumn.Name = "wasterShop1DataGridViewTextBoxColumn";
            this.wasterShop1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterShop1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterUnit1DataGridViewTextBoxColumn
            // 
            this.wasterUnit1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Unit1";
            this.wasterUnit1DataGridViewTextBoxColumn.HeaderText = "责任机组1";
            this.wasterUnit1DataGridViewTextBoxColumn.Name = "wasterUnit1DataGridViewTextBoxColumn";
            this.wasterUnit1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterUnit1DataGridViewTextBoxColumn.Width = 84;
            // 
            // dutyPer1DataGridViewTextBoxColumn
            // 
            this.dutyPer1DataGridViewTextBoxColumn.DataPropertyName = "Duty_Per1";
            this.dutyPer1DataGridViewTextBoxColumn.HeaderText = "责任人1";
            this.dutyPer1DataGridViewTextBoxColumn.Name = "dutyPer1DataGridViewTextBoxColumn";
            this.dutyPer1DataGridViewTextBoxColumn.ReadOnly = true;
            this.dutyPer1DataGridViewTextBoxColumn.Width = 72;
            // 
            // teamID1DataGridViewTextBoxColumn
            // 
            this.teamID1DataGridViewTextBoxColumn.DataPropertyName = "TeamID1";
            this.teamID1DataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamID1DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamID1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamID1DataGridViewTextBoxColumn.HeaderText = "班组1";
            this.teamID1DataGridViewTextBoxColumn.Name = "teamID1DataGridViewTextBoxColumn";
            this.teamID1DataGridViewTextBoxColumn.ReadOnly = true;
            this.teamID1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamID1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamID1DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamID1DataGridViewTextBoxColumn.Width = 60;
            // 
            // dsTeam
            // 
            this.dsTeam.AutoSubscribe = true;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = "";
            this.dsTeam.InsertMethod = "";
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "code_group = \'TeamID\' order by code";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "";
            this.dsTeam.UpdateMethod = "";
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTableCode
            // 
            this.coldsTeamL3DataTableCode.Caption = "Code";
            this.coldsTeamL3DataTableCode.ColumnName = "Code";
            this.coldsTeamL3DataTableCode.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Des
            // 
            this.coldsTeamL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.Namespace = "";
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
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.wasterWeight2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.wasterWeight2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wasterWeight2DataGridViewTextBoxColumn.Name = "wasterWeight2DataGridViewTextBoxColumn";
            this.wasterWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason2DataGridViewTextBoxColumn
            // 
            this.wasterReason2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason2";
            this.wasterReason2DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wasterReason2DataGridViewTextBoxColumn.Name = "wasterReason2DataGridViewTextBoxColumn";
            this.wasterReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.wasterReason2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterShop2DataGridViewTextBoxColumn
            // 
            this.wasterShop2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Shop2";
            this.wasterShop2DataGridViewTextBoxColumn.HeaderText = "责任车间2";
            this.wasterShop2DataGridViewTextBoxColumn.Name = "wasterShop2DataGridViewTextBoxColumn";
            this.wasterShop2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterShop2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterUnit2DataGridViewTextBoxColumn
            // 
            this.wasterUnit2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Unit2";
            this.wasterUnit2DataGridViewTextBoxColumn.HeaderText = "责任机组2";
            this.wasterUnit2DataGridViewTextBoxColumn.Name = "wasterUnit2DataGridViewTextBoxColumn";
            this.wasterUnit2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterUnit2DataGridViewTextBoxColumn.Width = 84;
            // 
            // dutyPer2DataGridViewTextBoxColumn
            // 
            this.dutyPer2DataGridViewTextBoxColumn.DataPropertyName = "Duty_Per2";
            this.dutyPer2DataGridViewTextBoxColumn.HeaderText = "责任人2";
            this.dutyPer2DataGridViewTextBoxColumn.Name = "dutyPer2DataGridViewTextBoxColumn";
            this.dutyPer2DataGridViewTextBoxColumn.ReadOnly = true;
            this.dutyPer2DataGridViewTextBoxColumn.Width = 72;
            // 
            // teamID2DataGridViewTextBoxColumn
            // 
            this.teamID2DataGridViewTextBoxColumn.DataPropertyName = "TeamID2";
            this.teamID2DataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamID2DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamID2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamID2DataGridViewTextBoxColumn.HeaderText = "班组2";
            this.teamID2DataGridViewTextBoxColumn.Name = "teamID2DataGridViewTextBoxColumn";
            this.teamID2DataGridViewTextBoxColumn.ReadOnly = true;
            this.teamID2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamID2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamID2DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamID2DataGridViewTextBoxColumn.Width = 60;
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
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.wasterWeight3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.wasterWeight3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wasterWeight3DataGridViewTextBoxColumn.Name = "wasterWeight3DataGridViewTextBoxColumn";
            this.wasterWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason3DataGridViewTextBoxColumn
            // 
            this.wasterReason3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason3";
            this.wasterReason3DataGridViewTextBoxColumn.DataSource = this.dsWasterReason;
            this.wasterReason3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wasterReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wasterReason3DataGridViewTextBoxColumn.Name = "wasterReason3DataGridViewTextBoxColumn";
            this.wasterReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.wasterReason3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterShop3DataGridViewTextBoxColumn
            // 
            this.wasterShop3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Shop3";
            this.wasterShop3DataGridViewTextBoxColumn.HeaderText = "责任车间3";
            this.wasterShop3DataGridViewTextBoxColumn.Name = "wasterShop3DataGridViewTextBoxColumn";
            this.wasterShop3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterShop3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterUnit3DataGridViewTextBoxColumn
            // 
            this.wasterUnit3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Unit3";
            this.wasterUnit3DataGridViewTextBoxColumn.HeaderText = "责任机组3";
            this.wasterUnit3DataGridViewTextBoxColumn.Name = "wasterUnit3DataGridViewTextBoxColumn";
            this.wasterUnit3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterUnit3DataGridViewTextBoxColumn.Width = 84;
            // 
            // dutyPer3DataGridViewTextBoxColumn
            // 
            this.dutyPer3DataGridViewTextBoxColumn.DataPropertyName = "Duty_Per3";
            this.dutyPer3DataGridViewTextBoxColumn.HeaderText = "责任人3";
            this.dutyPer3DataGridViewTextBoxColumn.Name = "dutyPer3DataGridViewTextBoxColumn";
            this.dutyPer3DataGridViewTextBoxColumn.ReadOnly = true;
            this.dutyPer3DataGridViewTextBoxColumn.Width = 72;
            // 
            // teamID3DataGridViewTextBoxColumn
            // 
            this.teamID3DataGridViewTextBoxColumn.DataPropertyName = "TeamID3";
            this.teamID3DataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamID3DataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamID3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamID3DataGridViewTextBoxColumn.HeaderText = "班组3";
            this.teamID3DataGridViewTextBoxColumn.Name = "teamID3DataGridViewTextBoxColumn";
            this.teamID3DataGridViewTextBoxColumn.ReadOnly = true;
            this.teamID3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamID3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamID3DataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamID3DataGridViewTextBoxColumn.Width = 60;
            // 
            // confirmPerDataGridViewTextBoxColumn
            // 
            this.confirmPerDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Per";
            this.confirmPerDataGridViewTextBoxColumn.HeaderText = "备注";
            this.confirmPerDataGridViewTextBoxColumn.Name = "confirmPerDataGridViewTextBoxColumn";
            this.confirmPerDataGridViewTextBoxColumn.ReadOnly = true;
            this.confirmPerDataGridViewTextBoxColumn.Width = 54;
            // 
            // wasterOperatorDataGridViewTextBoxColumn
            // 
            this.wasterOperatorDataGridViewTextBoxColumn.DataPropertyName = "Waster_Operator";
            this.wasterOperatorDataGridViewTextBoxColumn.HeaderText = "甩废人";
            this.wasterOperatorDataGridViewTextBoxColumn.Name = "wasterOperatorDataGridViewTextBoxColumn";
            this.wasterOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterOperatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // shitIDDataGridViewTextBoxColumn
            // 
            this.shitIDDataGridViewTextBoxColumn.DataPropertyName = "ShitID";
            this.shitIDDataGridViewTextBoxColumn.DataSource = this.dsShift;
            this.shitIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.shitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shitIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shitIDDataGridViewTextBoxColumn.Name = "shitIDDataGridViewTextBoxColumn";
            this.shitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shitIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code";
            this.shitIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShift
            // 
            this.dsShift.AutoSubscribe = true;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = "";
            this.dsShift.InsertMethod = "";
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "code_group = \'ShiftID\' order by code";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = null;
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "";
            this.dsShift.UpdateMethod = "";
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTablecode,
            this.coldsShiftL3DataTablecode_des});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTablecode
            // 
            this.coldsShiftL3DataTablecode.Caption = "code";
            this.coldsShiftL3DataTablecode.ColumnName = "code";
            this.coldsShiftL3DataTablecode.Namespace = "";
            // 
            // coldsShiftL3DataTablecode_des
            // 
            this.coldsShiftL3DataTablecode_des.Caption = "code_des";
            this.coldsShiftL3DataTablecode_des.ColumnName = "code_des";
            this.coldsShiftL3DataTablecode_des.Namespace = "";
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Duty_Flag
            // 
            this.Duty_Flag.DataPropertyName = "Duty_Flag";
            this.Duty_Flag.HeaderText = "指定责任标志";
            this.Duty_Flag.Name = "Duty_Flag";
            this.Duty_Flag.ReadOnly = true;
            this.Duty_Flag.Width = 102;
            // 
            // CCMScrapDutyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 499);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnWasterData);
            this.Name = "CCMScrapDutyFrm";
            this.TabText = "甩废责任确认";
            this.Text = "甩废责任确认";
            this.Load += new System.EventHandler(this.CCMScrapDutyFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnWasterData)).EndInit();
            this.bnWasterData.ResumeLayout(false);
            this.bnWasterData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterData)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvWasterData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnWasterData;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvWasterData;
        private AppSvrHMI.L3DataSet dsWasterData;
        private System.Windows.Forms.BindingSource bsWasterData;
        private System.Data.DataTable schemadsWasterData;
        private System.Data.DataColumn coldsWasterDataL3DataTableGUID;
        private System.Data.DataColumn coldsWasterDataL3DataTableProduce_Date;
        private System.Data.DataColumn coldsWasterDataL3DataTableHeatID;
        private System.Data.DataColumn coldsWasterDataL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsWasterDataL3DataTableCut_SteelGradeIndex;
        private System.Data.DataColumn coldsWasterDataL3DataTableThickness;
        private System.Data.DataColumn coldsWasterDataL3DataTableWidth;
        private System.Data.DataColumn coldsWasterDataL3DataTableLength;
        private System.Data.DataColumn coldsWasterDataL3DataTableBloom_Count;
        private System.Data.DataColumn coldsWasterDataL3DataTableCal_Weight;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Count;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Count1;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Weight1;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Reason1;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Count2;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Weight2;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Reason2;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Count3;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Weight3;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Reason3;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Shop1;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Shop2;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Shop3;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Unit1;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Unit2;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Unit3;
        private System.Data.DataColumn coldsWasterDataL3DataTableDuty_Per1;
        private System.Data.DataColumn coldsWasterDataL3DataTableDuty_Per2;
        private System.Data.DataColumn coldsWasterDataL3DataTableDuty_Per3;
        private System.Data.DataColumn coldsWasterDataL3DataTableTeamID1;
        private System.Data.DataColumn coldsWasterDataL3DataTableTeamID2;
        private System.Data.DataColumn coldsWasterDataL3DataTableTeamID3;
        private System.Data.DataColumn coldsWasterDataL3DataTableConfirm_Per;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Operator;
        private System.Data.DataColumn coldsWasterDataL3DataTableWaster_Date;
        private System.Data.DataColumn coldsWasterDataL3DataTableShitID;
        private System.Data.DataColumn coldsWasterDataL3DataTableTeamID;
        private System.Data.DataColumn coldsWasterDataL3DataTableCasterID;
        private System.Data.DataColumn coldsWasterDataL3DataTableDuty_Flag;
        private System.Data.DataColumn coldsWasterDataL3DataTableObject_ID;
        private buttonHide.ToolStripToriDateTimePicker dtTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTablecode;
        private System.Data.DataColumn coldsShiftL3DataTablecode_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloomCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterShop1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterUnit1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyPer1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterShop2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterUnit2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyPer2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterShop3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterUnit3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dutyPer3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamID3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmPerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty_Flag;
    }
}