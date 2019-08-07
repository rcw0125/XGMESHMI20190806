namespace UnitMag.DEPMag
{
    partial class DEPDesignateMaterialFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsIronMode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsIronMode = new System.Data.DataTable();
            this.coldsIronModeL3DataTableName = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsIronModeL3DataTableNC_Code = new System.Data.DataColumn();
            this.bsIronInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronInfo = new AppSvrHMI.L3DataSet();
            this.schemadsIronInfo = new System.Data.DataTable();
            this.coldsIronInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePosition = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableC = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableMn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableP = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableS = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTi = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronTemp = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSource = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableShift = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTeam = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTare = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableTap_Time = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIronLadleNo = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject1 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight1 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject2 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight2 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableObject3 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableWeight3 = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableIsDes = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSn = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableAs = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTablePb = new System.Data.DataColumn();
            this.coldsIronInfoL3DataTableSELECTID = new System.Data.DataColumn();
            this.bsScrapSteel = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapSteel = new AppSvrHMI.L3DataSet();
            this.schemadsScrapSteel = new System.Data.DataTable();
            this.coldsScrapSteelL3DataTableAmount = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableScrapWT = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTablePigIronWT = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableLOGDATE = new System.Data.DataColumn();
            this.coldsScrapSteelL3DataTableCheckFlag = new System.Data.DataColumn();
            this.dsReturnSteel = new AppSvrHMI.L3DataSet();
            this.schemadsReturnSteel = new System.Data.DataTable();
            this.coldsReturnSteelL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsReturnSteelL3DataTableReturn_SteelGrade = new System.Data.DataColumn();
            this.cmdDesignateMainMat = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.cmdPar1 = new AppSvrHMI.L3CommandParameter();
            this.cmdPar2 = new AppSvrHMI.L3CommandParameter();
            this.cmdPar3 = new AppSvrHMI.L3CommandParameter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHeatID = new AppSvrHMI.L3DataBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvIronInfo = new System.Windows.Forms.DataGridView();
            this.SELECTID = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shiftDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironLadleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qAStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produceContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesContractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapTimeDataGridViewTextBoxColumn = new DataGridValid.DataGridViewValidateCellColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnSteelWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturnSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsIronMode
            // 
            this.dsIronMode.AutoLoad = true;
            this.dsIronMode.AutoSubscribe = false;
            this.dsIronMode.DataSetName = "L3DataSet";
            this.dsIronMode.DeleteMethod = null;
            this.dsIronMode.InsertMethod = null;
            this.dsIronMode.L3DataAdapter = this.Adapter;
            this.dsIronMode.LoadEvent = "Click";
            this.dsIronMode.LoadTrigger = null;
            this.dsIronMode.RefreshValve = 1000;
            this.dsIronMode.SourceCommand = null;
            this.dsIronMode.SourceCondition = "CODE_GROUP = \'Iron_Mode\'";
            this.dsIronMode.SourceMethod = "";
            this.dsIronMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronMode.SubscribeTarget = null;
            this.dsIronMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronMode});
            this.dsIronMode.UpdateEvent = "Click";
            this.dsIronMode.UpdateMethod = null;
            this.dsIronMode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsIronMode
            // 
            this.schemadsIronMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronModeL3DataTableName,
            this.coldsIronModeL3DataTableCode,
            this.coldsIronModeL3DataTableCode_Des,
            this.coldsIronModeL3DataTableCode_Group,
            this.coldsIronModeL3DataTableCode_Group_Des,
            this.coldsIronModeL3DataTableCode_Val_Str,
            this.coldsIronModeL3DataTableCode_Val_Long,
            this.coldsIronModeL3DataTableCode_Val_Double,
            this.coldsIronModeL3DataTableCode_Function_Group,
            this.coldsIronModeL3DataTableNC_Code});
            this.schemadsIronMode.TableName = "L3DataTable";
            // 
            // coldsIronModeL3DataTableName
            // 
            this.coldsIronModeL3DataTableName.Caption = "Name";
            this.coldsIronModeL3DataTableName.ColumnName = "Name";
            this.coldsIronModeL3DataTableName.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode
            // 
            this.coldsIronModeL3DataTableCode.Caption = "Code";
            this.coldsIronModeL3DataTableCode.ColumnName = "Code";
            this.coldsIronModeL3DataTableCode.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Des
            // 
            this.coldsIronModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Group
            // 
            this.coldsIronModeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsIronModeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsIronModeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Group_Des
            // 
            this.coldsIronModeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsIronModeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsIronModeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Str
            // 
            this.coldsIronModeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsIronModeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsIronModeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Long
            // 
            this.coldsIronModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsIronModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsIronModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsIronModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Val_Double
            // 
            this.coldsIronModeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsIronModeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsIronModeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsIronModeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsIronModeL3DataTableCode_Function_Group
            // 
            this.coldsIronModeL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsIronModeL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsIronModeL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsIronModeL3DataTableNC_Code
            // 
            this.coldsIronModeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsIronModeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsIronModeL3DataTableNC_Code.Namespace = "";
            // 
            // bsIronInfo
            // 
            this.bsIronInfo.DataMember = "L3DataTable";
            this.bsIronInfo.DataSource = this.dsIronInfo;
            // 
            // dsIronInfo
            // 
            this.dsIronInfo.AutoLoad = true;
            this.dsIronInfo.AutoSubscribe = false;
            this.dsIronInfo.DataSetName = "L3DataSet";
            this.dsIronInfo.DeleteMethod = "";
            this.dsIronInfo.InsertMethod = "";
            this.dsIronInfo.L3DataAdapter = this.Adapter;
            this.dsIronInfo.LoadEvent = "";
            this.dsIronInfo.LoadTrigger = null;
            this.dsIronInfo.RefreshValve = 1000;
            this.dsIronInfo.SourceCommand = null;
            this.dsIronInfo.SourceCondition = "";
            this.dsIronInfo.SourceMethod = "GetIronsForDesignate";
            this.dsIronInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsIronInfo.SourceURI = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.dsIronInfo.SubscribeTarget = "";
            this.dsIronInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronInfo});
            this.dsIronInfo.UpdateEvent = "";
            this.dsIronInfo.UpdateMethod = "";
            this.dsIronInfo.UpdateTrigger = null;
            // 
            // schemadsIronInfo
            // 
            this.schemadsIronInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronInfoL3DataTableName,
            this.coldsIronInfoL3DataTableMaterialID,
            this.coldsIronInfoL3DataTableStatus,
            this.coldsIronInfoL3DataTablePosition,
            this.coldsIronInfoL3DataTableQAStatus,
            this.coldsIronInfoL3DataTableQALevel,
            this.coldsIronInfoL3DataTableOrderContractID,
            this.coldsIronInfoL3DataTableProduceContractID,
            this.coldsIronInfoL3DataTableSalesContractID,
            this.coldsIronInfoL3DataTableWeight,
            this.coldsIronInfoL3DataTableC,
            this.coldsIronInfoL3DataTableSi,
            this.coldsIronInfoL3DataTableMn,
            this.coldsIronInfoL3DataTableP,
            this.coldsIronInfoL3DataTableS,
            this.coldsIronInfoL3DataTableTi,
            this.coldsIronInfoL3DataTableIronTemp,
            this.coldsIronInfoL3DataTableHeatID,
            this.coldsIronInfoL3DataTableSource,
            this.coldsIronInfoL3DataTableShift,
            this.coldsIronInfoL3DataTableTeam,
            this.coldsIronInfoL3DataTableOperator,
            this.coldsIronInfoL3DataTableTare,
            this.coldsIronInfoL3DataTableGross_Weight,
            this.coldsIronInfoL3DataTableTap_Time,
            this.coldsIronInfoL3DataTableIronLadleNo,
            this.coldsIronInfoL3DataTableObject1,
            this.coldsIronInfoL3DataTableWeight1,
            this.coldsIronInfoL3DataTableObject2,
            this.coldsIronInfoL3DataTableWeight2,
            this.coldsIronInfoL3DataTableObject3,
            this.coldsIronInfoL3DataTableWeight3,
            this.coldsIronInfoL3DataTableReturn_Steel_Weight,
            this.coldsIronInfoL3DataTableIsDes,
            this.coldsIronInfoL3DataTableSn,
            this.coldsIronInfoL3DataTableSb,
            this.coldsIronInfoL3DataTableAs,
            this.coldsIronInfoL3DataTablePb,
            this.coldsIronInfoL3DataTableSELECTID});
            this.schemadsIronInfo.TableName = "L3DataTable";
            // 
            // coldsIronInfoL3DataTableName
            // 
            this.coldsIronInfoL3DataTableName.Caption = "Name";
            this.coldsIronInfoL3DataTableName.ColumnName = "Name";
            this.coldsIronInfoL3DataTableName.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMaterialID
            // 
            this.coldsIronInfoL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsIronInfoL3DataTableMaterialID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableStatus
            // 
            this.coldsIronInfoL3DataTableStatus.Caption = "Status";
            this.coldsIronInfoL3DataTableStatus.ColumnName = "Status";
            this.coldsIronInfoL3DataTableStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePosition
            // 
            this.coldsIronInfoL3DataTablePosition.Caption = "Position";
            this.coldsIronInfoL3DataTablePosition.ColumnName = "Position";
            this.coldsIronInfoL3DataTablePosition.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQAStatus
            // 
            this.coldsIronInfoL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsIronInfoL3DataTableQAStatus.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQAStatus.Namespace = "";
            // 
            // coldsIronInfoL3DataTableQALevel
            // 
            this.coldsIronInfoL3DataTableQALevel.Caption = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsIronInfoL3DataTableQALevel.DataType = typeof(int);
            this.coldsIronInfoL3DataTableQALevel.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOrderContractID
            // 
            this.coldsIronInfoL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsIronInfoL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableProduceContractID
            // 
            this.coldsIronInfoL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsIronInfoL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSalesContractID
            // 
            this.coldsIronInfoL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsIronInfoL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight
            // 
            this.coldsIronInfoL3DataTableWeight.Caption = "Weight";
            this.coldsIronInfoL3DataTableWeight.ColumnName = "Weight";
            this.coldsIronInfoL3DataTableWeight.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableC
            // 
            this.coldsIronInfoL3DataTableC.Caption = "C";
            this.coldsIronInfoL3DataTableC.ColumnName = "C";
            this.coldsIronInfoL3DataTableC.DataType = typeof(float);
            this.coldsIronInfoL3DataTableC.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSi
            // 
            this.coldsIronInfoL3DataTableSi.Caption = "Si";
            this.coldsIronInfoL3DataTableSi.ColumnName = "Si";
            this.coldsIronInfoL3DataTableSi.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableMn
            // 
            this.coldsIronInfoL3DataTableMn.Caption = "Mn";
            this.coldsIronInfoL3DataTableMn.ColumnName = "Mn";
            this.coldsIronInfoL3DataTableMn.DataType = typeof(float);
            this.coldsIronInfoL3DataTableMn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableP
            // 
            this.coldsIronInfoL3DataTableP.Caption = "P";
            this.coldsIronInfoL3DataTableP.ColumnName = "P";
            this.coldsIronInfoL3DataTableP.DataType = typeof(float);
            this.coldsIronInfoL3DataTableP.Namespace = "";
            // 
            // coldsIronInfoL3DataTableS
            // 
            this.coldsIronInfoL3DataTableS.Caption = "S";
            this.coldsIronInfoL3DataTableS.ColumnName = "S";
            this.coldsIronInfoL3DataTableS.DataType = typeof(float);
            this.coldsIronInfoL3DataTableS.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTi
            // 
            this.coldsIronInfoL3DataTableTi.Caption = "Ti";
            this.coldsIronInfoL3DataTableTi.ColumnName = "Ti";
            this.coldsIronInfoL3DataTableTi.DataType = typeof(float);
            this.coldsIronInfoL3DataTableTi.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronTemp
            // 
            this.coldsIronInfoL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsIronInfoL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsIronInfoL3DataTableIronTemp.DataType = typeof(int);
            this.coldsIronInfoL3DataTableIronTemp.Namespace = "";
            // 
            // coldsIronInfoL3DataTableHeatID
            // 
            this.coldsIronInfoL3DataTableHeatID.Caption = "HeatID";
            this.coldsIronInfoL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsIronInfoL3DataTableHeatID.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSource
            // 
            this.coldsIronInfoL3DataTableSource.Caption = "Source";
            this.coldsIronInfoL3DataTableSource.ColumnName = "Source";
            this.coldsIronInfoL3DataTableSource.DataType = typeof(int);
            this.coldsIronInfoL3DataTableSource.Namespace = "";
            // 
            // coldsIronInfoL3DataTableShift
            // 
            this.coldsIronInfoL3DataTableShift.Caption = "Shift";
            this.coldsIronInfoL3DataTableShift.ColumnName = "Shift";
            this.coldsIronInfoL3DataTableShift.DataType = typeof(bool);
            this.coldsIronInfoL3DataTableShift.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTeam
            // 
            this.coldsIronInfoL3DataTableTeam.Caption = "Team";
            this.coldsIronInfoL3DataTableTeam.ColumnName = "Team";
            this.coldsIronInfoL3DataTableTeam.DataType = typeof(bool);
            this.coldsIronInfoL3DataTableTeam.Namespace = "";
            // 
            // coldsIronInfoL3DataTableOperator
            // 
            this.coldsIronInfoL3DataTableOperator.Caption = "Operator";
            this.coldsIronInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsIronInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTare
            // 
            this.coldsIronInfoL3DataTableTare.Caption = "Tare";
            this.coldsIronInfoL3DataTableTare.ColumnName = "Tare";
            this.coldsIronInfoL3DataTableTare.DataType = typeof(double);
            this.coldsIronInfoL3DataTableTare.Namespace = "";
            // 
            // coldsIronInfoL3DataTableGross_Weight
            // 
            this.coldsIronInfoL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsIronInfoL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsIronInfoL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableTap_Time
            // 
            this.coldsIronInfoL3DataTableTap_Time.Caption = "Tap_Time";
            this.coldsIronInfoL3DataTableTap_Time.ColumnName = "Tap_Time";
            this.coldsIronInfoL3DataTableTap_Time.DataType = typeof(System.DateTime);
            this.coldsIronInfoL3DataTableTap_Time.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIronLadleNo
            // 
            this.coldsIronInfoL3DataTableIronLadleNo.Caption = "IronLadleNo";
            this.coldsIronInfoL3DataTableIronLadleNo.ColumnName = "IronLadleNo";
            this.coldsIronInfoL3DataTableIronLadleNo.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject1
            // 
            this.coldsIronInfoL3DataTableObject1.Caption = "Object1";
            this.coldsIronInfoL3DataTableObject1.ColumnName = "Object1";
            this.coldsIronInfoL3DataTableObject1.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight1
            // 
            this.coldsIronInfoL3DataTableWeight1.Caption = "Weight1";
            this.coldsIronInfoL3DataTableWeight1.ColumnName = "Weight1";
            this.coldsIronInfoL3DataTableWeight1.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight1.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject2
            // 
            this.coldsIronInfoL3DataTableObject2.Caption = "Object2";
            this.coldsIronInfoL3DataTableObject2.ColumnName = "Object2";
            this.coldsIronInfoL3DataTableObject2.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight2
            // 
            this.coldsIronInfoL3DataTableWeight2.Caption = "Weight2";
            this.coldsIronInfoL3DataTableWeight2.ColumnName = "Weight2";
            this.coldsIronInfoL3DataTableWeight2.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight2.Namespace = "";
            // 
            // coldsIronInfoL3DataTableObject3
            // 
            this.coldsIronInfoL3DataTableObject3.Caption = "Object3";
            this.coldsIronInfoL3DataTableObject3.ColumnName = "Object3";
            this.coldsIronInfoL3DataTableObject3.Namespace = "";
            // 
            // coldsIronInfoL3DataTableWeight3
            // 
            this.coldsIronInfoL3DataTableWeight3.Caption = "Weight3";
            this.coldsIronInfoL3DataTableWeight3.ColumnName = "Weight3";
            this.coldsIronInfoL3DataTableWeight3.DataType = typeof(double);
            this.coldsIronInfoL3DataTableWeight3.Namespace = "";
            // 
            // coldsIronInfoL3DataTableReturn_Steel_Weight
            // 
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.DataType = typeof(float);
            this.coldsIronInfoL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsIronInfoL3DataTableIsDes
            // 
            this.coldsIronInfoL3DataTableIsDes.Caption = "IsDes";
            this.coldsIronInfoL3DataTableIsDes.ColumnName = "IsDes";
            this.coldsIronInfoL3DataTableIsDes.DataType = typeof(float);
            this.coldsIronInfoL3DataTableIsDes.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSn
            // 
            this.coldsIronInfoL3DataTableSn.Caption = "Sn";
            this.coldsIronInfoL3DataTableSn.ColumnName = "Sn";
            this.coldsIronInfoL3DataTableSn.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSn.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSb
            // 
            this.coldsIronInfoL3DataTableSb.Caption = "Sb";
            this.coldsIronInfoL3DataTableSb.ColumnName = "Sb";
            this.coldsIronInfoL3DataTableSb.DataType = typeof(float);
            this.coldsIronInfoL3DataTableSb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableAs
            // 
            this.coldsIronInfoL3DataTableAs.Caption = "As";
            this.coldsIronInfoL3DataTableAs.ColumnName = "As";
            this.coldsIronInfoL3DataTableAs.DataType = typeof(float);
            this.coldsIronInfoL3DataTableAs.Namespace = "";
            // 
            // coldsIronInfoL3DataTablePb
            // 
            this.coldsIronInfoL3DataTablePb.Caption = "Pb";
            this.coldsIronInfoL3DataTablePb.ColumnName = "Pb";
            this.coldsIronInfoL3DataTablePb.DataType = typeof(float);
            this.coldsIronInfoL3DataTablePb.Namespace = "";
            // 
            // coldsIronInfoL3DataTableSELECTID
            // 
            this.coldsIronInfoL3DataTableSELECTID.Caption = "SELECTID";
            this.coldsIronInfoL3DataTableSELECTID.ColumnName = "SELECTID";
            this.coldsIronInfoL3DataTableSELECTID.DataType = typeof(short);
            this.coldsIronInfoL3DataTableSELECTID.Namespace = "";
            // 
            // bsScrapSteel
            // 
            this.bsScrapSteel.DataMember = "L3DataTable";
            this.bsScrapSteel.DataSource = this.dsScrapSteel;
            // 
            // dsScrapSteel
            // 
            this.dsScrapSteel.AutoLoad = true;
            this.dsScrapSteel.AutoSubscribe = false;
            this.dsScrapSteel.DataSetName = "L3DataSet";
            this.dsScrapSteel.DeleteMethod = "";
            this.dsScrapSteel.InsertMethod = "";
            this.dsScrapSteel.L3DataAdapter = this.Adapter;
            this.dsScrapSteel.LoadEvent = "";
            this.dsScrapSteel.LoadTrigger = null;
            this.dsScrapSteel.RefreshValve = 1000;
            this.dsScrapSteel.SourceCommand = null;
            this.dsScrapSteel.SourceCondition = "";
            this.dsScrapSteel.SourceMethod = "GetScrapesForDesignate";
            this.dsScrapSteel.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsScrapSteel.SourceURI = "XGMESLogic\\AODMag\\CAOD_Unit_Mag\\S25";
            this.dsScrapSteel.SubscribeTarget = "";
            this.dsScrapSteel.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapSteel});
            this.dsScrapSteel.UpdateEvent = "";
            this.dsScrapSteel.UpdateMethod = "";
            this.dsScrapSteel.UpdateTrigger = null;
            // 
            // schemadsScrapSteel
            // 
            this.schemadsScrapSteel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapSteelL3DataTableAmount,
            this.coldsScrapSteelL3DataTableScrap_Slot_ID,
            this.coldsScrapSteelL3DataTableScrapWT,
            this.coldsScrapSteelL3DataTablePigIronWT,
            this.coldsScrapSteelL3DataTableLOGDATE,
            this.coldsScrapSteelL3DataTableCheckFlag});
            this.schemadsScrapSteel.TableName = "L3DataTable";
            // 
            // coldsScrapSteelL3DataTableAmount
            // 
            this.coldsScrapSteelL3DataTableAmount.Caption = "AMOUNT";
            this.coldsScrapSteelL3DataTableAmount.ColumnName = "Amount";
            this.coldsScrapSteelL3DataTableAmount.DataType = typeof(double);
            this.coldsScrapSteelL3DataTableAmount.DefaultValue = 0;
            this.coldsScrapSteelL3DataTableAmount.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableScrap_Slot_ID
            // 
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.DefaultValue = "";
            this.coldsScrapSteelL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableScrapWT
            // 
            this.coldsScrapSteelL3DataTableScrapWT.Caption = "SCRAPWT";
            this.coldsScrapSteelL3DataTableScrapWT.ColumnName = "ScrapWT";
            this.coldsScrapSteelL3DataTableScrapWT.DataType = typeof(double);
            this.coldsScrapSteelL3DataTableScrapWT.DefaultValue = 0;
            this.coldsScrapSteelL3DataTableScrapWT.Namespace = "";
            // 
            // coldsScrapSteelL3DataTablePigIronWT
            // 
            this.coldsScrapSteelL3DataTablePigIronWT.Caption = "PIGIRONWT";
            this.coldsScrapSteelL3DataTablePigIronWT.ColumnName = "PigIronWT";
            this.coldsScrapSteelL3DataTablePigIronWT.DataType = typeof(double);
            this.coldsScrapSteelL3DataTablePigIronWT.DefaultValue = 0;
            this.coldsScrapSteelL3DataTablePigIronWT.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableLOGDATE
            // 
            this.coldsScrapSteelL3DataTableLOGDATE.Caption = "LOGDATE";
            this.coldsScrapSteelL3DataTableLOGDATE.ColumnName = "LOGDATE";
            this.coldsScrapSteelL3DataTableLOGDATE.DataType = typeof(System.DateTime);
            this.coldsScrapSteelL3DataTableLOGDATE.Namespace = "";
            // 
            // coldsScrapSteelL3DataTableCheckFlag
            // 
            this.coldsScrapSteelL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsScrapSteelL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsScrapSteelL3DataTableCheckFlag.DataType = typeof(bool);
            this.coldsScrapSteelL3DataTableCheckFlag.Namespace = "";
            // 
            // dsReturnSteel
            // 
            this.dsReturnSteel.AutoLoad = true;
            this.dsReturnSteel.AutoSubscribe = false;
            this.dsReturnSteel.DataSetName = "L3DataSet";
            this.dsReturnSteel.DeleteMethod = "";
            this.dsReturnSteel.InsertMethod = "";
            this.dsReturnSteel.L3DataAdapter = null;
            this.dsReturnSteel.LoadEvent = "";
            this.dsReturnSteel.LoadTrigger = null;
            this.dsReturnSteel.RefreshValve = 1000;
            this.dsReturnSteel.SourceCommand = null;
            this.dsReturnSteel.SourceCondition = "";
            this.dsReturnSteel.SourceMethod = "";
            this.dsReturnSteel.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsReturnSteel.SourceURI = "XGMESLogic\\\\AODMag\\\\CAOD_Unit_Mag\\\\S25";
            this.dsReturnSteel.SubscribeTarget = "";
            this.dsReturnSteel.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReturnSteel});
            this.dsReturnSteel.UpdateEvent = "";
            this.dsReturnSteel.UpdateMethod = "";
            this.dsReturnSteel.UpdateTrigger = null;
            // 
            // schemadsReturnSteel
            // 
            this.schemadsReturnSteel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReturnSteelL3DataTableHeatID,
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight,
            this.coldsReturnSteelL3DataTableReturn_SteelGrade});
            this.schemadsReturnSteel.TableName = "L3DataTable";
            // 
            // coldsReturnSteelL3DataTableHeatID
            // 
            this.coldsReturnSteelL3DataTableHeatID.Caption = "HeatID";
            this.coldsReturnSteelL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsReturnSteelL3DataTableHeatID.Namespace = "";
            // 
            // coldsReturnSteelL3DataTableReturn_Steel_Weight
            // 
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.DataType = typeof(double);
            this.coldsReturnSteelL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsReturnSteelL3DataTableReturn_SteelGrade
            // 
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.Caption = "Return_SteelGrade";
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.ColumnName = "Return_SteelGrade";
            this.coldsReturnSteelL3DataTableReturn_SteelGrade.Namespace = "";
            // 
            // cmdDesignateMainMat
            // 
            this.cmdDesignateMainMat.Adapter = this.Adapter;
            this.cmdDesignateMainMat.MergeReturnTarget = false;
            this.cmdDesignateMainMat.Method = "IronLadleToDEP";
            this.cmdDesignateMainMat.Object = "XGMESLogic\\DePMag\\CDEP_Unit_Mag\\S91";
            this.cmdDesignateMainMat.Parameters.Add(this.l3CommandParameter4);
            this.cmdDesignateMainMat.ReturnTarget = null;
            this.cmdDesignateMainMat.ReturnTargetProperty = null;
            this.cmdDesignateMainMat.Trigger = null;
            this.cmdDesignateMainMat.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = "SELECTID=true";
            this.l3CommandParameter4.SourceObject = this.dsIronInfo;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // cmdPar1
            // 
            this.cmdPar1.AcceptAfterExecuted = false;
            this.cmdPar1.ConstantValue = null;
            this.cmdPar1.MergeTarget = false;
            this.cmdPar1.SourceFilter = "SELECTID=true";
            this.cmdPar1.SourceObject = this.dsIronInfo;
            this.cmdPar1.SourceProperty = "L3DataTable";
            this.cmdPar1.TargetObject = null;
            this.cmdPar1.TargetProperty = null;
            // 
            // cmdPar2
            // 
            this.cmdPar2.AcceptAfterExecuted = false;
            this.cmdPar2.ConstantValue = null;
            this.cmdPar2.MergeTarget = false;
            this.cmdPar2.SourceFilter = null;
            this.cmdPar2.SourceObject = this.dsReturnSteel;
            this.cmdPar2.SourceProperty = "L3DataTable";
            this.cmdPar2.TargetObject = null;
            this.cmdPar2.TargetProperty = null;
            // 
            // cmdPar3
            // 
            this.cmdPar3.AcceptAfterExecuted = false;
            this.cmdPar3.ConstantValue = null;
            this.cmdPar3.MergeTarget = false;
            this.cmdPar3.SourceFilter = "CheckFlag=true";
            this.cmdPar3.SourceObject = this.dsScrapSteel;
            this.cmdPar3.SourceProperty = "L3DataTable";
            this.cmdPar3.TargetObject = null;
            this.cmdPar3.TargetProperty = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaterialID";
            this.dataGridViewTextBoxColumn2.HeaderText = "材料号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IronLadleNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "铁包号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Return_Steel_Weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "回炉钢水量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn5.HeaderText = "铁水重量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "QAStatus";
            this.dataGridViewTextBoxColumn8.HeaderText = "QAStatus";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "QALevel";
            this.dataGridViewTextBoxColumn9.HeaderText = "QALevel";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 72;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OrderContractID";
            this.dataGridViewTextBoxColumn10.HeaderText = "OrderContractID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProduceContractID";
            this.dataGridViewTextBoxColumn11.HeaderText = "ProduceContractID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 132;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SalesContractID";
            this.dataGridViewTextBoxColumn12.HeaderText = "SalesContractID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn13.HeaderText = "C";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 36;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn14.HeaderText = "Si";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 42;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn15.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 42;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn16.HeaderText = "P";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 36;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn17.HeaderText = "S";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 36;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn18.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 42;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn19.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 42;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn20.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 42;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn21.HeaderText = "As";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 42;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn22.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 42;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "IronTemp";
            this.dataGridViewTextBoxColumn23.HeaderText = "铁水温度";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 78;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn24.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 54;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn25.HeaderText = "Operator";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Visible = false;
            this.dataGridViewTextBoxColumn25.Width = 78;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Tare";
            this.dataGridViewTextBoxColumn26.HeaderText = "皮重";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 54;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Gross_Weight";
            this.dataGridViewTextBoxColumn27.HeaderText = "毛重";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 54;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Object1";
            this.dataGridViewTextBoxColumn28.HeaderText = "Object1";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Visible = false;
            this.dataGridViewTextBoxColumn28.Width = 72;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Weight1";
            this.dataGridViewTextBoxColumn29.HeaderText = "Weight1";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Visible = false;
            this.dataGridViewTextBoxColumn29.Width = 72;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Object2";
            this.dataGridViewTextBoxColumn30.HeaderText = "Object2";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Visible = false;
            this.dataGridViewTextBoxColumn30.Width = 72;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Weight2";
            this.dataGridViewTextBoxColumn31.HeaderText = "Weight2";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Visible = false;
            this.dataGridViewTextBoxColumn31.Width = 72;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Object3";
            this.dataGridViewTextBoxColumn32.HeaderText = "Object3";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Visible = false;
            this.dataGridViewTextBoxColumn32.Width = 72;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Weight3";
            this.dataGridViewTextBoxColumn33.HeaderText = "Weight3";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Visible = false;
            this.dataGridViewTextBoxColumn33.Width = 72;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "IsDes";
            this.dataGridViewTextBoxColumn34.HeaderText = "IsDes";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 60;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Scrap_Slot_ID";
            this.dataGridViewTextBoxColumn35.HeaderText = "废钢斗号";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn36.HeaderText = "重量[T]";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "ScrapWT";
            this.dataGridViewTextBoxColumn37.HeaderText = "废钢[T]";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "PigIronWT";
            this.dataGridViewTextBoxColumn38.HeaderText = "生铁[T]";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnAssign);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 268);
            this.panel2.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(427, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(297, 40);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "指定";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHeatID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 40);
            this.panel1.TabIndex = 2;
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataFormat = null;
            this.txtHeatID.DataObject = "XGMESLogic\\\\DePMag\\\\CDEP_Unit_Mag\\\\S91";
            this.txtHeatID.DataProperty = "NextHeatID";
            this.txtHeatID.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtHeatID.L3DataAdapter = this.Adapter;
            this.txtHeatID.Location = new System.Drawing.Point(61, 9);
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.ReadOnly = true;
            this.txtHeatID.Size = new System.Drawing.Size(136, 21);
            this.txtHeatID.TabIndex = 1;
            this.txtHeatID.Value = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvIronInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "铁水信息";
            // 
            // dvIronInfo
            // 
            this.dvIronInfo.AllowUserToAddRows = false;
            this.dvIronInfo.AutoGenerateColumns = false;
            this.dvIronInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvIronInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvIronInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvIronInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTID,
            this.shiftDataGridViewCheckBoxColumn,
            this.teamDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ironLadleNoDataGridViewTextBoxColumn,
            this.sourceDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.qAStatusDataGridViewTextBoxColumn,
            this.qALevelDataGridViewTextBoxColumn,
            this.orderContractIDDataGridViewTextBoxColumn,
            this.produceContractIDDataGridViewTextBoxColumn,
            this.salesContractIDDataGridViewTextBoxColumn,
            this.tapTimeDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.Sn,
            this.Sb,
            this.As,
            this.Pb,
            this.ironTempDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.tareDataGridViewTextBoxColumn,
            this.returnSteelWeightDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.object1DataGridViewTextBoxColumn,
            this.weight1DataGridViewTextBoxColumn,
            this.object2DataGridViewTextBoxColumn,
            this.weight2DataGridViewTextBoxColumn,
            this.object3DataGridViewTextBoxColumn,
            this.weight3DataGridViewTextBoxColumn,
            this.isDesDataGridViewTextBoxColumn});
            this.dvIronInfo.DataSource = this.bsIronInfo;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvIronInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvIronInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronInfo.Location = new System.Drawing.Point(3, 17);
            this.dvIronInfo.Name = "dvIronInfo";
            this.dvIronInfo.RowHeadersVisible = false;
            this.dvIronInfo.RowTemplate.Height = 23;
            this.dvIronInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvIronInfo.Size = new System.Drawing.Size(988, 113);
            this.dvIronInfo.TabIndex = 0;
            // 
            // SELECTID
            // 
            this.SELECTID.DataPropertyName = "SELECTID";
            this.SELECTID.FalseValue = "0";
            this.SELECTID.Frozen = true;
            this.SELECTID.HeaderText = "选择";
            this.SELECTID.IndeterminateValue = "0";
            this.SELECTID.Name = "SELECTID";
            this.SELECTID.TrueValue = "1";
            this.SELECTID.Width = 35;
            // 
            // shiftDataGridViewCheckBoxColumn
            // 
            this.shiftDataGridViewCheckBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewCheckBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewCheckBoxColumn.Name = "shiftDataGridViewCheckBoxColumn";
            this.shiftDataGridViewCheckBoxColumn.Visible = false;
            this.shiftDataGridViewCheckBoxColumn.Width = 41;
            // 
            // teamDataGridViewCheckBoxColumn
            // 
            this.teamDataGridViewCheckBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewCheckBoxColumn.HeaderText = "Team";
            this.teamDataGridViewCheckBoxColumn.Name = "teamDataGridViewCheckBoxColumn";
            this.teamDataGridViewCheckBoxColumn.Visible = false;
            this.teamDataGridViewCheckBoxColumn.Width = 35;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // ironLadleNoDataGridViewTextBoxColumn
            // 
            this.ironLadleNoDataGridViewTextBoxColumn.DataPropertyName = "IronLadleNo";
            this.ironLadleNoDataGridViewTextBoxColumn.Frozen = true;
            this.ironLadleNoDataGridViewTextBoxColumn.HeaderText = "铁包号";
            this.ironLadleNoDataGridViewTextBoxColumn.Name = "ironLadleNoDataGridViewTextBoxColumn";
            this.ironLadleNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // sourceDataGridViewCheckBoxColumn
            // 
            this.sourceDataGridViewCheckBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewCheckBoxColumn.DataSource = this.dsIronMode;
            this.sourceDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sourceDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceDataGridViewCheckBoxColumn.Frozen = true;
            this.sourceDataGridViewCheckBoxColumn.HeaderText = "出铁方式";
            this.sourceDataGridViewCheckBoxColumn.Name = "sourceDataGridViewCheckBoxColumn";
            this.sourceDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.sourceDataGridViewCheckBoxColumn.Width = 59;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.Frozen = true;
            this.weightDataGridViewTextBoxColumn.HeaderText = "铁水重量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Width = 78;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.Frozen = true;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 66;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.Frozen = true;
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Visible = false;
            this.positionDataGridViewTextBoxColumn.Width = 78;
            // 
            // qAStatusDataGridViewTextBoxColumn
            // 
            this.qAStatusDataGridViewTextBoxColumn.DataPropertyName = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.Frozen = true;
            this.qAStatusDataGridViewTextBoxColumn.HeaderText = "QAStatus";
            this.qAStatusDataGridViewTextBoxColumn.Name = "qAStatusDataGridViewTextBoxColumn";
            this.qAStatusDataGridViewTextBoxColumn.Visible = false;
            this.qAStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // qALevelDataGridViewTextBoxColumn
            // 
            this.qALevelDataGridViewTextBoxColumn.DataPropertyName = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.Frozen = true;
            this.qALevelDataGridViewTextBoxColumn.HeaderText = "QALevel";
            this.qALevelDataGridViewTextBoxColumn.Name = "qALevelDataGridViewTextBoxColumn";
            this.qALevelDataGridViewTextBoxColumn.Visible = false;
            this.qALevelDataGridViewTextBoxColumn.Width = 72;
            // 
            // orderContractIDDataGridViewTextBoxColumn
            // 
            this.orderContractIDDataGridViewTextBoxColumn.DataPropertyName = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.Frozen = true;
            this.orderContractIDDataGridViewTextBoxColumn.HeaderText = "OrderContractID";
            this.orderContractIDDataGridViewTextBoxColumn.Name = "orderContractIDDataGridViewTextBoxColumn";
            this.orderContractIDDataGridViewTextBoxColumn.Visible = false;
            this.orderContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // produceContractIDDataGridViewTextBoxColumn
            // 
            this.produceContractIDDataGridViewTextBoxColumn.DataPropertyName = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.Frozen = true;
            this.produceContractIDDataGridViewTextBoxColumn.HeaderText = "ProduceContractID";
            this.produceContractIDDataGridViewTextBoxColumn.Name = "produceContractIDDataGridViewTextBoxColumn";
            this.produceContractIDDataGridViewTextBoxColumn.Visible = false;
            this.produceContractIDDataGridViewTextBoxColumn.Width = 132;
            // 
            // salesContractIDDataGridViewTextBoxColumn
            // 
            this.salesContractIDDataGridViewTextBoxColumn.DataPropertyName = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.Frozen = true;
            this.salesContractIDDataGridViewTextBoxColumn.HeaderText = "SalesContractID";
            this.salesContractIDDataGridViewTextBoxColumn.Name = "salesContractIDDataGridViewTextBoxColumn";
            this.salesContractIDDataGridViewTextBoxColumn.Visible = false;
            this.salesContractIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // tapTimeDataGridViewTextBoxColumn
            // 
            this.tapTimeDataGridViewTextBoxColumn.DataPropertyName = "Tap_Time";
            this.tapTimeDataGridViewTextBoxColumn.DefaultHeaderCellType = typeof(System.Windows.Forms.DataGridViewColumnHeaderCell);
            this.tapTimeDataGridViewTextBoxColumn.EnableNull = true;
            this.tapTimeDataGridViewTextBoxColumn.Frozen = true;
            this.tapTimeDataGridViewTextBoxColumn.HeaderText = "出铁时间";
            this.tapTimeDataGridViewTextBoxColumn.Length = 0;
            this.tapTimeDataGridViewTextBoxColumn.Max = 0;
            this.tapTimeDataGridViewTextBoxColumn.MaxInputLength = 32767;
            this.tapTimeDataGridViewTextBoxColumn.MaxLength = 0;
            this.tapTimeDataGridViewTextBoxColumn.Min = 0;
            this.tapTimeDataGridViewTextBoxColumn.MinLength = 0;
            this.tapTimeDataGridViewTextBoxColumn.Name = "tapTimeDataGridViewTextBoxColumn";
            this.tapTimeDataGridViewTextBoxColumn.Precision = 0;
            this.tapTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tapTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tapTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tapTimeDataGridViewTextBoxColumn.ValidEable = true;
            this.tapTimeDataGridViewTextBoxColumn.ValidType = DataGridValid.DataGridViewValidateCellColumn.TypeEnum.Integer;
            this.tapTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.Frozen = true;
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.Frozen = true;
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.Frozen = true;
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.Frozen = true;
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.Frozen = true;
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.Frozen = true;
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            this.Sn.Frozen = true;
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.Width = 42;
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            this.Sb.Frozen = true;
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            this.Sb.Width = 42;
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            this.As.Frozen = true;
            this.As.HeaderText = "As";
            this.As.Name = "As";
            this.As.Width = 42;
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            this.Pb.Frozen = true;
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            this.Pb.Width = 42;
            // 
            // ironTempDataGridViewTextBoxColumn
            // 
            this.ironTempDataGridViewTextBoxColumn.DataPropertyName = "IronTemp";
            this.ironTempDataGridViewTextBoxColumn.Frozen = true;
            this.ironTempDataGridViewTextBoxColumn.HeaderText = "铁水温度";
            this.ironTempDataGridViewTextBoxColumn.Name = "ironTempDataGridViewTextBoxColumn";
            this.ironTempDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Frozen = true;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "Operator";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.Visible = false;
            this.operatorDataGridViewTextBoxColumn.Width = 78;
            // 
            // tareDataGridViewTextBoxColumn
            // 
            this.tareDataGridViewTextBoxColumn.DataPropertyName = "Tare";
            this.tareDataGridViewTextBoxColumn.HeaderText = "皮重";
            this.tareDataGridViewTextBoxColumn.Name = "tareDataGridViewTextBoxColumn";
            this.tareDataGridViewTextBoxColumn.Width = 54;
            // 
            // returnSteelWeightDataGridViewTextBoxColumn
            // 
            this.returnSteelWeightDataGridViewTextBoxColumn.DataPropertyName = "Return_Steel_Weight";
            this.returnSteelWeightDataGridViewTextBoxColumn.HeaderText = "回炉钢水量";
            this.returnSteelWeightDataGridViewTextBoxColumn.Name = "returnSteelWeightDataGridViewTextBoxColumn";
            this.returnSteelWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // object1DataGridViewTextBoxColumn
            // 
            this.object1DataGridViewTextBoxColumn.DataPropertyName = "Object1";
            this.object1DataGridViewTextBoxColumn.HeaderText = "Object1";
            this.object1DataGridViewTextBoxColumn.Name = "object1DataGridViewTextBoxColumn";
            this.object1DataGridViewTextBoxColumn.Visible = false;
            this.object1DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight1DataGridViewTextBoxColumn
            // 
            this.weight1DataGridViewTextBoxColumn.DataPropertyName = "Weight1";
            this.weight1DataGridViewTextBoxColumn.HeaderText = "Weight1";
            this.weight1DataGridViewTextBoxColumn.Name = "weight1DataGridViewTextBoxColumn";
            this.weight1DataGridViewTextBoxColumn.Visible = false;
            this.weight1DataGridViewTextBoxColumn.Width = 72;
            // 
            // object2DataGridViewTextBoxColumn
            // 
            this.object2DataGridViewTextBoxColumn.DataPropertyName = "Object2";
            this.object2DataGridViewTextBoxColumn.HeaderText = "Object2";
            this.object2DataGridViewTextBoxColumn.Name = "object2DataGridViewTextBoxColumn";
            this.object2DataGridViewTextBoxColumn.Visible = false;
            this.object2DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight2DataGridViewTextBoxColumn
            // 
            this.weight2DataGridViewTextBoxColumn.DataPropertyName = "Weight2";
            this.weight2DataGridViewTextBoxColumn.HeaderText = "Weight2";
            this.weight2DataGridViewTextBoxColumn.Name = "weight2DataGridViewTextBoxColumn";
            this.weight2DataGridViewTextBoxColumn.Visible = false;
            this.weight2DataGridViewTextBoxColumn.Width = 72;
            // 
            // object3DataGridViewTextBoxColumn
            // 
            this.object3DataGridViewTextBoxColumn.DataPropertyName = "Object3";
            this.object3DataGridViewTextBoxColumn.HeaderText = "Object3";
            this.object3DataGridViewTextBoxColumn.Name = "object3DataGridViewTextBoxColumn";
            this.object3DataGridViewTextBoxColumn.Visible = false;
            this.object3DataGridViewTextBoxColumn.Width = 72;
            // 
            // weight3DataGridViewTextBoxColumn
            // 
            this.weight3DataGridViewTextBoxColumn.DataPropertyName = "Weight3";
            this.weight3DataGridViewTextBoxColumn.HeaderText = "Weight3";
            this.weight3DataGridViewTextBoxColumn.Name = "weight3DataGridViewTextBoxColumn";
            this.weight3DataGridViewTextBoxColumn.Visible = false;
            this.weight3DataGridViewTextBoxColumn.Width = 72;
            // 
            // isDesDataGridViewTextBoxColumn
            // 
            this.isDesDataGridViewTextBoxColumn.DataPropertyName = "IsDes";
            this.isDesDataGridViewTextBoxColumn.HeaderText = "IsDes";
            this.isDesDataGridViewTextBoxColumn.Name = "isDesDataGridViewTextBoxColumn";
            this.isDesDataGridViewTextBoxColumn.Visible = false;
            this.isDesDataGridViewTextBoxColumn.Width = 60;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.904762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 466);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DEPDesignateMaterialFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "DEPDesignateMaterialFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "指定主原料";
            this.Load += new System.EventHandler(this.NewDesignateMaterialFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsIronMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturnSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturnSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIronInfo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3DataSet dsIronInfo;
        private AppSvrHMI.L3DataSet dsScrapSteel;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsReturnSteel;
        private System.Data.DataTable schemadsIronInfo;
        private System.Data.DataColumn coldsIronInfoL3DataTableName;
        private System.Data.DataColumn coldsIronInfoL3DataTableMaterialID;
        private System.Data.DataColumn coldsIronInfoL3DataTableStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTablePosition;
        private System.Data.DataColumn coldsIronInfoL3DataTableQAStatus;
        private System.Data.DataColumn coldsIronInfoL3DataTableQALevel;
        private System.Data.DataColumn coldsIronInfoL3DataTableOrderContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableProduceContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableSalesContractID;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight;
        private System.Data.DataColumn coldsIronInfoL3DataTableC;
        private System.Data.DataColumn coldsIronInfoL3DataTableSi;
        private System.Data.DataColumn coldsIronInfoL3DataTableMn;
        private System.Data.DataColumn coldsIronInfoL3DataTableP;
        private System.Data.DataColumn coldsIronInfoL3DataTableS;
        private System.Data.DataColumn coldsIronInfoL3DataTableTi;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronTemp;
        private System.Data.DataColumn coldsIronInfoL3DataTableHeatID;
        private System.Data.DataColumn coldsIronInfoL3DataTableSource;
        private System.Data.DataColumn coldsIronInfoL3DataTableShift;
        private System.Data.DataColumn coldsIronInfoL3DataTableTeam;
        private System.Data.DataColumn coldsIronInfoL3DataTableOperator;
        private System.Data.DataColumn coldsIronInfoL3DataTableTare;
        private System.Data.DataColumn coldsIronInfoL3DataTableGross_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableTap_Time;
        private System.Data.DataColumn coldsIronInfoL3DataTableIronLadleNo;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject1;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight1;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject2;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight2;
        private System.Data.DataColumn coldsIronInfoL3DataTableObject3;
        private System.Data.DataColumn coldsIronInfoL3DataTableWeight3;
        private System.Data.DataColumn coldsIronInfoL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsIronInfoL3DataTableIsDes;
        private System.Data.DataTable schemadsScrapSteel;
        private System.Data.DataColumn coldsScrapSteelL3DataTableAmount;
        private System.Data.DataColumn coldsScrapSteelL3DataTableScrap_Slot_ID;
        private System.Data.DataTable schemadsReturnSteel;
        private System.Data.DataColumn coldsReturnSteelL3DataTableHeatID;
        private System.Data.DataColumn coldsReturnSteelL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsReturnSteelL3DataTableReturn_SteelGrade;
        private System.Windows.Forms.BindingSource bsIronInfo;
        private System.Windows.Forms.BindingSource bsScrapSteel;
       // private PxDataValid.PxTextBox pxTextBox1;
        private System.Data.DataColumn coldsIronInfoL3DataTableSn;
        private System.Data.DataColumn coldsIronInfoL3DataTableSb;
        private System.Data.DataColumn coldsIronInfoL3DataTableAs;
        private System.Data.DataColumn coldsIronInfoL3DataTablePb;
        private AppSvrHMI.L3Command cmdDesignateMainMat;
        private AppSvrHMI.L3CommandParameter cmdPar1;
        private AppSvrHMI.L3CommandParameter cmdPar2;
        private AppSvrHMI.L3CommandParameter cmdPar3;
        private System.Data.DataColumn coldsScrapSteelL3DataTableScrapWT;
        private System.Data.DataColumn coldsScrapSteelL3DataTablePigIronWT;
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
        //private PxDataValid.PxTextBox txtRetAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsIronInfoL3DataTableSELECTID;
        private AppSvrHMI.L3DataSet dsIronMode;
        private System.Data.DataTable schemadsIronMode;
        private System.Data.DataColumn coldsIronModeL3DataTableName;
        private System.Data.DataColumn coldsIronModeL3DataTableCode;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Group;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsIronModeL3DataTableCode_Function_Group;
        private System.Data.DataColumn coldsIronModeL3DataTableNC_Code;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvIronInfo;
        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3DataBox txtHeatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAssign;
        private System.Data.DataColumn coldsScrapSteelL3DataTableLOGDATE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn shiftDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn teamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironLadleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qAStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produceContractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesContractIDDataGridViewTextBoxColumn;
        private DataGridValid.DataGridViewValidateCellColumn tapTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnSteelWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn object3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDesDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsScrapSteelL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
    }
}