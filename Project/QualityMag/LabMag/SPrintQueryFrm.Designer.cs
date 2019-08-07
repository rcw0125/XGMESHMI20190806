namespace QualityMag.LabMag
{
    partial class SPrintQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPrintQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSPrint = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shrinkageHoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerLooseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commonLooseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerCrackLevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerCrackLenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypoBubbleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerCrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiaxedGrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypoCrackDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypoCrackLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypoCrackQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hypoCrackLevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceEyeletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceCrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceSlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonmetalSlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acidTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPrintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSPrint = new System.Windows.Forms.BindingSource(this.components);
            this.dsSPrint = new AppSvrHMI.L3DataSet();
            this.schemadsSPrint = new System.Data.DataTable();
            this.coldsSPrintL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableName = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableAppID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableShrinkage_Hole = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableCenter_Loose = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableCommon_Loose = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableCenter_Crack_Lev = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableCenter_Crack_Len = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHypo_Bubble = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableCenter_Crack = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableEquiaxed_Grain = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHypo_Crack_D = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHypo_Crack_L = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHypo_Crack_Q = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableHypo_Crack_Lev = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSurface_Eyelet = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSurface_Crack = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSurface_Slag = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableNonmetal_Slag = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSpot = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableAcidTime = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableS_Print = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableStrandID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSize = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableOPERATOR = new System.Data.DataColumn();
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
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.cmbPossition = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtSPrint = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvSPrint);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(935, 543);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvSPrint
            // 
            this.dvSPrint.AllowUserToAddRows = false;
            this.dvSPrint.AutoGenerateColumns = false;
            this.dvSPrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSPrint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvSPrint.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSPrint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.shrinkageHoleDataGridViewTextBoxColumn,
            this.centerLooseDataGridViewTextBoxColumn,
            this.commonLooseDataGridViewTextBoxColumn,
            this.centerCrackLevDataGridViewTextBoxColumn,
            this.centerCrackLenDataGridViewTextBoxColumn,
            this.hypoBubbleDataGridViewTextBoxColumn,
            this.centerCrackDataGridViewTextBoxColumn,
            this.equiaxedGrainDataGridViewTextBoxColumn,
            this.hypoCrackDDataGridViewTextBoxColumn,
            this.hypoCrackLDataGridViewTextBoxColumn,
            this.hypoCrackQDataGridViewTextBoxColumn,
            this.hypoCrackLevDataGridViewTextBoxColumn,
            this.surfaceEyeletDataGridViewTextBoxColumn,
            this.surfaceCrackDataGridViewTextBoxColumn,
            this.surfaceSlagDataGridViewTextBoxColumn,
            this.nonmetalSlagDataGridViewTextBoxColumn,
            this.spotDataGridViewTextBoxColumn,
            this.acidTimeDataGridViewTextBoxColumn,
            this.sPrintDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn,
            this.strandIDDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.OPERATOR});
            this.dvSPrint.DataSource = this.bsSPrint;
            this.dvSPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSPrint.Location = new System.Drawing.Point(0, 25);
            this.dvSPrint.Name = "dvSPrint";
            this.dvSPrint.ReadOnly = true;
            this.dvSPrint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSPrint.RowTemplate.Height = 23;
            this.dvSPrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSPrint.Size = new System.Drawing.Size(935, 518);
            this.dvSPrint.TabIndex = 29;
            this.dvSPrint.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvSPrint_DataError);
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.Frozen = true;
            this.appIDDataGridViewTextBoxColumn.HeaderText = "委托单编号";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            this.appIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.appIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // arriveDateDataGridViewTextBoxColumn
            // 
            this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "Arrive_Date";
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.arriveDateDataGridViewTextBoxColumn.Visible = false;
            this.arriveDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampleAddressDataGridViewTextBoxColumn
            // 
            this.sampleAddressDataGridViewTextBoxColumn.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.sampleAddressDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleAddressDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleAddressDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sampleAddressDataGridViewTextBoxColumn.Name = "sampleAddressDataGridViewTextBoxColumn";
            this.sampleAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleAddressDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sampleAddressDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoSubscribe = false;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\' and code_function_group = \'C\' order by code";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // sampleTypeDataGridViewTextBoxColumn
            // 
            this.sampleTypeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Type";
            this.sampleTypeDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sampleTypeDataGridViewTextBoxColumn.Name = "sampleTypeDataGridViewTextBoxColumn";
            this.sampleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            this.sampleCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampleCodeDataGridViewTextBoxColumn
            // 
            this.sampleCodeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn.Name = "sampleCodeDataGridViewTextBoxColumn";
            this.sampleCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // shrinkageHoleDataGridViewTextBoxColumn
            // 
            this.shrinkageHoleDataGridViewTextBoxColumn.DataPropertyName = "Shrinkage_Hole";
            this.shrinkageHoleDataGridViewTextBoxColumn.HeaderText = "缩孔";
            this.shrinkageHoleDataGridViewTextBoxColumn.Name = "shrinkageHoleDataGridViewTextBoxColumn";
            this.shrinkageHoleDataGridViewTextBoxColumn.ReadOnly = true;
            this.shrinkageHoleDataGridViewTextBoxColumn.Width = 54;
            // 
            // centerLooseDataGridViewTextBoxColumn
            // 
            this.centerLooseDataGridViewTextBoxColumn.DataPropertyName = "Center_Loose";
            this.centerLooseDataGridViewTextBoxColumn.HeaderText = "中心疏松";
            this.centerLooseDataGridViewTextBoxColumn.Name = "centerLooseDataGridViewTextBoxColumn";
            this.centerLooseDataGridViewTextBoxColumn.ReadOnly = true;
            this.centerLooseDataGridViewTextBoxColumn.Width = 78;
            // 
            // commonLooseDataGridViewTextBoxColumn
            // 
            this.commonLooseDataGridViewTextBoxColumn.DataPropertyName = "Common_Loose";
            this.commonLooseDataGridViewTextBoxColumn.HeaderText = "一般疏松";
            this.commonLooseDataGridViewTextBoxColumn.Name = "commonLooseDataGridViewTextBoxColumn";
            this.commonLooseDataGridViewTextBoxColumn.ReadOnly = true;
            this.commonLooseDataGridViewTextBoxColumn.Width = 78;
            // 
            // centerCrackLevDataGridViewTextBoxColumn
            // 
            this.centerCrackLevDataGridViewTextBoxColumn.DataPropertyName = "Center_Crack_Lev";
            this.centerCrackLevDataGridViewTextBoxColumn.HeaderText = "中心裂纹级别";
            this.centerCrackLevDataGridViewTextBoxColumn.Name = "centerCrackLevDataGridViewTextBoxColumn";
            this.centerCrackLevDataGridViewTextBoxColumn.ReadOnly = true;
            this.centerCrackLevDataGridViewTextBoxColumn.Width = 102;
            // 
            // centerCrackLenDataGridViewTextBoxColumn
            // 
            this.centerCrackLenDataGridViewTextBoxColumn.DataPropertyName = "Center_Crack_Len";
            this.centerCrackLenDataGridViewTextBoxColumn.HeaderText = "中心裂纹长度";
            this.centerCrackLenDataGridViewTextBoxColumn.Name = "centerCrackLenDataGridViewTextBoxColumn";
            this.centerCrackLenDataGridViewTextBoxColumn.ReadOnly = true;
            this.centerCrackLenDataGridViewTextBoxColumn.Width = 102;
            // 
            // hypoBubbleDataGridViewTextBoxColumn
            // 
            this.hypoBubbleDataGridViewTextBoxColumn.DataPropertyName = "Hypo_Bubble";
            this.hypoBubbleDataGridViewTextBoxColumn.HeaderText = "皮下气泡";
            this.hypoBubbleDataGridViewTextBoxColumn.Name = "hypoBubbleDataGridViewTextBoxColumn";
            this.hypoBubbleDataGridViewTextBoxColumn.ReadOnly = true;
            this.hypoBubbleDataGridViewTextBoxColumn.Width = 78;
            // 
            // centerCrackDataGridViewTextBoxColumn
            // 
            this.centerCrackDataGridViewTextBoxColumn.DataPropertyName = "Center_Crack";
            this.centerCrackDataGridViewTextBoxColumn.HeaderText = "中间裂纹";
            this.centerCrackDataGridViewTextBoxColumn.Name = "centerCrackDataGridViewTextBoxColumn";
            this.centerCrackDataGridViewTextBoxColumn.ReadOnly = true;
            this.centerCrackDataGridViewTextBoxColumn.Width = 78;
            // 
            // equiaxedGrainDataGridViewTextBoxColumn
            // 
            this.equiaxedGrainDataGridViewTextBoxColumn.DataPropertyName = "Equiaxed_Grain";
            this.equiaxedGrainDataGridViewTextBoxColumn.HeaderText = "等轴晶";
            this.equiaxedGrainDataGridViewTextBoxColumn.Name = "equiaxedGrainDataGridViewTextBoxColumn";
            this.equiaxedGrainDataGridViewTextBoxColumn.ReadOnly = true;
            this.equiaxedGrainDataGridViewTextBoxColumn.Width = 66;
            // 
            // hypoCrackDDataGridViewTextBoxColumn
            // 
            this.hypoCrackDDataGridViewTextBoxColumn.DataPropertyName = "Hypo_Crack_D";
            this.hypoCrackDDataGridViewTextBoxColumn.HeaderText = "皮下裂纹d";
            this.hypoCrackDDataGridViewTextBoxColumn.Name = "hypoCrackDDataGridViewTextBoxColumn";
            this.hypoCrackDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hypoCrackDDataGridViewTextBoxColumn.Width = 84;
            // 
            // hypoCrackLDataGridViewTextBoxColumn
            // 
            this.hypoCrackLDataGridViewTextBoxColumn.DataPropertyName = "Hypo_Crack_L";
            this.hypoCrackLDataGridViewTextBoxColumn.HeaderText = "皮下裂纹l";
            this.hypoCrackLDataGridViewTextBoxColumn.Name = "hypoCrackLDataGridViewTextBoxColumn";
            this.hypoCrackLDataGridViewTextBoxColumn.ReadOnly = true;
            this.hypoCrackLDataGridViewTextBoxColumn.Width = 84;
            // 
            // hypoCrackQDataGridViewTextBoxColumn
            // 
            this.hypoCrackQDataGridViewTextBoxColumn.DataPropertyName = "Hypo_Crack_Q";
            this.hypoCrackQDataGridViewTextBoxColumn.HeaderText = "皮下裂纹q";
            this.hypoCrackQDataGridViewTextBoxColumn.Name = "hypoCrackQDataGridViewTextBoxColumn";
            this.hypoCrackQDataGridViewTextBoxColumn.ReadOnly = true;
            this.hypoCrackQDataGridViewTextBoxColumn.Width = 84;
            // 
            // hypoCrackLevDataGridViewTextBoxColumn
            // 
            this.hypoCrackLevDataGridViewTextBoxColumn.DataPropertyName = "Hypo_Crack_Lev";
            this.hypoCrackLevDataGridViewTextBoxColumn.HeaderText = "皮下裂纹级别";
            this.hypoCrackLevDataGridViewTextBoxColumn.Name = "hypoCrackLevDataGridViewTextBoxColumn";
            this.hypoCrackLevDataGridViewTextBoxColumn.ReadOnly = true;
            this.hypoCrackLevDataGridViewTextBoxColumn.Width = 102;
            // 
            // surfaceEyeletDataGridViewTextBoxColumn
            // 
            this.surfaceEyeletDataGridViewTextBoxColumn.DataPropertyName = "Surface_Eyelet";
            this.surfaceEyeletDataGridViewTextBoxColumn.HeaderText = "纵表面针眼";
            this.surfaceEyeletDataGridViewTextBoxColumn.Name = "surfaceEyeletDataGridViewTextBoxColumn";
            this.surfaceEyeletDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceEyeletDataGridViewTextBoxColumn.Width = 90;
            // 
            // surfaceCrackDataGridViewTextBoxColumn
            // 
            this.surfaceCrackDataGridViewTextBoxColumn.DataPropertyName = "Surface_Crack";
            this.surfaceCrackDataGridViewTextBoxColumn.HeaderText = "纵表面裂纹";
            this.surfaceCrackDataGridViewTextBoxColumn.Name = "surfaceCrackDataGridViewTextBoxColumn";
            this.surfaceCrackDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceCrackDataGridViewTextBoxColumn.Width = 90;
            // 
            // surfaceSlagDataGridViewTextBoxColumn
            // 
            this.surfaceSlagDataGridViewTextBoxColumn.DataPropertyName = "Surface_Slag";
            this.surfaceSlagDataGridViewTextBoxColumn.HeaderText = "纵表面夹渣";
            this.surfaceSlagDataGridViewTextBoxColumn.Name = "surfaceSlagDataGridViewTextBoxColumn";
            this.surfaceSlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.surfaceSlagDataGridViewTextBoxColumn.Width = 90;
            // 
            // nonmetalSlagDataGridViewTextBoxColumn
            // 
            this.nonmetalSlagDataGridViewTextBoxColumn.DataPropertyName = "Nonmetal_Slag";
            this.nonmetalSlagDataGridViewTextBoxColumn.HeaderText = "非金属夹渣";
            this.nonmetalSlagDataGridViewTextBoxColumn.Name = "nonmetalSlagDataGridViewTextBoxColumn";
            this.nonmetalSlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.nonmetalSlagDataGridViewTextBoxColumn.Width = 90;
            // 
            // spotDataGridViewTextBoxColumn
            // 
            this.spotDataGridViewTextBoxColumn.DataPropertyName = "Spot";
            this.spotDataGridViewTextBoxColumn.HeaderText = "斑点";
            this.spotDataGridViewTextBoxColumn.Name = "spotDataGridViewTextBoxColumn";
            this.spotDataGridViewTextBoxColumn.ReadOnly = true;
            this.spotDataGridViewTextBoxColumn.Width = 54;
            // 
            // acidTimeDataGridViewTextBoxColumn
            // 
            this.acidTimeDataGridViewTextBoxColumn.DataPropertyName = "AcidTime";
            this.acidTimeDataGridViewTextBoxColumn.HeaderText = "酸蚀时间";
            this.acidTimeDataGridViewTextBoxColumn.Name = "acidTimeDataGridViewTextBoxColumn";
            this.acidTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.acidTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // sPrintDataGridViewTextBoxColumn
            // 
            this.sPrintDataGridViewTextBoxColumn.DataPropertyName = "S_Print";
            this.sPrintDataGridViewTextBoxColumn.HeaderText = "硫印结果";
            this.sPrintDataGridViewTextBoxColumn.Name = "sPrintDataGridViewTextBoxColumn";
            this.sPrintDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPrintDataGridViewTextBoxColumn.Width = 78;
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.logTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // dataLogModeDataGridViewTextBoxColumn
            // 
            this.dataLogModeDataGridViewTextBoxColumn.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn.HeaderText = "数据产生方式";
            this.dataLogModeDataGridViewTextBoxColumn.Name = "dataLogModeDataGridViewTextBoxColumn";
            this.dataLogModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLogModeDataGridViewTextBoxColumn.Width = 102;
            // 
            // strandIDDataGridViewTextBoxColumn
            // 
            this.strandIDDataGridViewTextBoxColumn.DataPropertyName = "StrandID";
            this.strandIDDataGridViewTextBoxColumn.HeaderText = "流号";
            this.strandIDDataGridViewTextBoxColumn.Name = "strandIDDataGridViewTextBoxColumn";
            this.strandIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.strandIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "尺寸";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 54;
            // 
            // OPERATOR
            // 
            this.OPERATOR.DataPropertyName = "OPERATOR";
            this.OPERATOR.HeaderText = "检验员";
            this.OPERATOR.Name = "OPERATOR";
            this.OPERATOR.ReadOnly = true;
            this.OPERATOR.Width = 66;
            // 
            // bsSPrint
            // 
            this.bsSPrint.DataMember = "L3DataTable";
            this.bsSPrint.DataSource = this.dsSPrint;
            // 
            // dsSPrint
            // 
            this.dsSPrint.AutoSubscribe = false;
            this.dsSPrint.DataSetName = "L3DataSet";
            this.dsSPrint.DeleteMethod = null;
            this.dsSPrint.InsertMethod = null;
            this.dsSPrint.L3DataAdapter = this.Adapter;
            this.dsSPrint.LoadEvent = "Click";
            this.dsSPrint.LoadTrigger = null;
            this.dsSPrint.RefreshValve = 1000;
            this.dsSPrint.SourceCommand = null;
            this.dsSPrint.SourceCondition = "1=2";
            this.dsSPrint.SourceMethod = "";
            this.dsSPrint.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSPrint.SourceURI = "XGMESLogic\\QualityMag\\CQA_Lab_S_Print";
            this.dsSPrint.SubscribeTarget = null;
            this.dsSPrint.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSPrint});
            this.dsSPrint.UpdateEvent = "Click";
            this.dsSPrint.UpdateMethod = null;
            this.dsSPrint.UpdateTrigger = null;
            // 
            // schemadsSPrint
            // 
            this.schemadsSPrint.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSPrintL3DataTableGUID,
            this.coldsSPrintL3DataTableName,
            this.coldsSPrintL3DataTableAppID,
            this.coldsSPrintL3DataTableArrive_Date,
            this.coldsSPrintL3DataTableReport_Date,
            this.coldsSPrintL3DataTableHeatID,
            this.coldsSPrintL3DataTableSample_Address,
            this.coldsSPrintL3DataTableSample_Type,
            this.coldsSPrintL3DataTableSample_Count,
            this.coldsSPrintL3DataTableSample_Code,
            this.coldsSPrintL3DataTableShrinkage_Hole,
            this.coldsSPrintL3DataTableCenter_Loose,
            this.coldsSPrintL3DataTableCommon_Loose,
            this.coldsSPrintL3DataTableCenter_Crack_Lev,
            this.coldsSPrintL3DataTableCenter_Crack_Len,
            this.coldsSPrintL3DataTableHypo_Bubble,
            this.coldsSPrintL3DataTableCenter_Crack,
            this.coldsSPrintL3DataTableEquiaxed_Grain,
            this.coldsSPrintL3DataTableHypo_Crack_D,
            this.coldsSPrintL3DataTableHypo_Crack_L,
            this.coldsSPrintL3DataTableHypo_Crack_Q,
            this.coldsSPrintL3DataTableHypo_Crack_Lev,
            this.coldsSPrintL3DataTableSurface_Eyelet,
            this.coldsSPrintL3DataTableSurface_Crack,
            this.coldsSPrintL3DataTableSurface_Slag,
            this.coldsSPrintL3DataTableNonmetal_Slag,
            this.coldsSPrintL3DataTableSpot,
            this.coldsSPrintL3DataTableAcidTime,
            this.coldsSPrintL3DataTableS_Print,
            this.coldsSPrintL3DataTableLogTime,
            this.coldsSPrintL3DataTableDataLogMode,
            this.coldsSPrintL3DataTableStrandID,
            this.coldsSPrintL3DataTableSize,
            this.coldsSPrintL3DataTableOPERATOR});
            this.schemadsSPrint.TableName = "L3DataTable";
            // 
            // coldsSPrintL3DataTableGUID
            // 
            this.coldsSPrintL3DataTableGUID.Caption = "GUID";
            this.coldsSPrintL3DataTableGUID.ColumnName = "GUID";
            this.coldsSPrintL3DataTableGUID.Namespace = "";
            // 
            // coldsSPrintL3DataTableName
            // 
            this.coldsSPrintL3DataTableName.Caption = "Name";
            this.coldsSPrintL3DataTableName.ColumnName = "Name";
            this.coldsSPrintL3DataTableName.Namespace = "";
            // 
            // coldsSPrintL3DataTableAppID
            // 
            this.coldsSPrintL3DataTableAppID.Caption = "AppID";
            this.coldsSPrintL3DataTableAppID.ColumnName = "AppID";
            this.coldsSPrintL3DataTableAppID.Namespace = "";
            // 
            // coldsSPrintL3DataTableArrive_Date
            // 
            this.coldsSPrintL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsSPrintL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsSPrintL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsSPrintL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsSPrintL3DataTableReport_Date
            // 
            this.coldsSPrintL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsSPrintL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsSPrintL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsSPrintL3DataTableReport_Date.Namespace = "";
            // 
            // coldsSPrintL3DataTableHeatID
            // 
            this.coldsSPrintL3DataTableHeatID.Caption = "HeatID";
            this.coldsSPrintL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSPrintL3DataTableHeatID.Namespace = "";
            // 
            // coldsSPrintL3DataTableSample_Address
            // 
            this.coldsSPrintL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsSPrintL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsSPrintL3DataTableSample_Address.Namespace = "";
            // 
            // coldsSPrintL3DataTableSample_Type
            // 
            this.coldsSPrintL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsSPrintL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsSPrintL3DataTableSample_Type.Namespace = "";
            // 
            // coldsSPrintL3DataTableSample_Count
            // 
            this.coldsSPrintL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsSPrintL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsSPrintL3DataTableSample_Count.Namespace = "";
            // 
            // coldsSPrintL3DataTableSample_Code
            // 
            this.coldsSPrintL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsSPrintL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsSPrintL3DataTableSample_Code.Namespace = "";
            // 
            // coldsSPrintL3DataTableShrinkage_Hole
            // 
            this.coldsSPrintL3DataTableShrinkage_Hole.Caption = "Shrinkage_Hole";
            this.coldsSPrintL3DataTableShrinkage_Hole.ColumnName = "Shrinkage_Hole";
            this.coldsSPrintL3DataTableShrinkage_Hole.Namespace = "";
            // 
            // coldsSPrintL3DataTableCenter_Loose
            // 
            this.coldsSPrintL3DataTableCenter_Loose.Caption = "Center_Loose";
            this.coldsSPrintL3DataTableCenter_Loose.ColumnName = "Center_Loose";
            this.coldsSPrintL3DataTableCenter_Loose.Namespace = "";
            // 
            // coldsSPrintL3DataTableCommon_Loose
            // 
            this.coldsSPrintL3DataTableCommon_Loose.Caption = "Common_Loose";
            this.coldsSPrintL3DataTableCommon_Loose.ColumnName = "Common_Loose";
            this.coldsSPrintL3DataTableCommon_Loose.Namespace = "";
            // 
            // coldsSPrintL3DataTableCenter_Crack_Lev
            // 
            this.coldsSPrintL3DataTableCenter_Crack_Lev.Caption = "Center_Crack_Lev";
            this.coldsSPrintL3DataTableCenter_Crack_Lev.ColumnName = "Center_Crack_Lev";
            this.coldsSPrintL3DataTableCenter_Crack_Lev.Namespace = "";
            // 
            // coldsSPrintL3DataTableCenter_Crack_Len
            // 
            this.coldsSPrintL3DataTableCenter_Crack_Len.Caption = "Center_Crack_Len";
            this.coldsSPrintL3DataTableCenter_Crack_Len.ColumnName = "Center_Crack_Len";
            this.coldsSPrintL3DataTableCenter_Crack_Len.Namespace = "";
            // 
            // coldsSPrintL3DataTableHypo_Bubble
            // 
            this.coldsSPrintL3DataTableHypo_Bubble.Caption = "Hypo_Bubble";
            this.coldsSPrintL3DataTableHypo_Bubble.ColumnName = "Hypo_Bubble";
            this.coldsSPrintL3DataTableHypo_Bubble.Namespace = "";
            // 
            // coldsSPrintL3DataTableCenter_Crack
            // 
            this.coldsSPrintL3DataTableCenter_Crack.Caption = "Center_Crack";
            this.coldsSPrintL3DataTableCenter_Crack.ColumnName = "Center_Crack";
            this.coldsSPrintL3DataTableCenter_Crack.Namespace = "";
            // 
            // coldsSPrintL3DataTableEquiaxed_Grain
            // 
            this.coldsSPrintL3DataTableEquiaxed_Grain.Caption = "Equiaxed_Grain";
            this.coldsSPrintL3DataTableEquiaxed_Grain.ColumnName = "Equiaxed_Grain";
            this.coldsSPrintL3DataTableEquiaxed_Grain.Namespace = "";
            // 
            // coldsSPrintL3DataTableHypo_Crack_D
            // 
            this.coldsSPrintL3DataTableHypo_Crack_D.Caption = "Hypo_Crack_D";
            this.coldsSPrintL3DataTableHypo_Crack_D.ColumnName = "Hypo_Crack_D";
            this.coldsSPrintL3DataTableHypo_Crack_D.Namespace = "";
            // 
            // coldsSPrintL3DataTableHypo_Crack_L
            // 
            this.coldsSPrintL3DataTableHypo_Crack_L.Caption = "Hypo_Crack_L";
            this.coldsSPrintL3DataTableHypo_Crack_L.ColumnName = "Hypo_Crack_L";
            this.coldsSPrintL3DataTableHypo_Crack_L.Namespace = "";
            // 
            // coldsSPrintL3DataTableHypo_Crack_Q
            // 
            this.coldsSPrintL3DataTableHypo_Crack_Q.Caption = "Hypo_Crack_Q";
            this.coldsSPrintL3DataTableHypo_Crack_Q.ColumnName = "Hypo_Crack_Q";
            this.coldsSPrintL3DataTableHypo_Crack_Q.Namespace = "";
            // 
            // coldsSPrintL3DataTableHypo_Crack_Lev
            // 
            this.coldsSPrintL3DataTableHypo_Crack_Lev.Caption = "Hypo_Crack_Lev";
            this.coldsSPrintL3DataTableHypo_Crack_Lev.ColumnName = "Hypo_Crack_Lev";
            this.coldsSPrintL3DataTableHypo_Crack_Lev.Namespace = "";
            // 
            // coldsSPrintL3DataTableSurface_Eyelet
            // 
            this.coldsSPrintL3DataTableSurface_Eyelet.Caption = "Surface_Eyelet";
            this.coldsSPrintL3DataTableSurface_Eyelet.ColumnName = "Surface_Eyelet";
            this.coldsSPrintL3DataTableSurface_Eyelet.Namespace = "";
            // 
            // coldsSPrintL3DataTableSurface_Crack
            // 
            this.coldsSPrintL3DataTableSurface_Crack.Caption = "Surface_Crack";
            this.coldsSPrintL3DataTableSurface_Crack.ColumnName = "Surface_Crack";
            this.coldsSPrintL3DataTableSurface_Crack.Namespace = "";
            // 
            // coldsSPrintL3DataTableSurface_Slag
            // 
            this.coldsSPrintL3DataTableSurface_Slag.Caption = "Surface_Slag";
            this.coldsSPrintL3DataTableSurface_Slag.ColumnName = "Surface_Slag";
            this.coldsSPrintL3DataTableSurface_Slag.Namespace = "";
            // 
            // coldsSPrintL3DataTableNonmetal_Slag
            // 
            this.coldsSPrintL3DataTableNonmetal_Slag.Caption = "Nonmetal_Slag";
            this.coldsSPrintL3DataTableNonmetal_Slag.ColumnName = "Nonmetal_Slag";
            this.coldsSPrintL3DataTableNonmetal_Slag.Namespace = "";
            // 
            // coldsSPrintL3DataTableSpot
            // 
            this.coldsSPrintL3DataTableSpot.Caption = "Spot";
            this.coldsSPrintL3DataTableSpot.ColumnName = "Spot";
            this.coldsSPrintL3DataTableSpot.Namespace = "";
            // 
            // coldsSPrintL3DataTableAcidTime
            // 
            this.coldsSPrintL3DataTableAcidTime.Caption = "AcidTime";
            this.coldsSPrintL3DataTableAcidTime.ColumnName = "AcidTime";
            this.coldsSPrintL3DataTableAcidTime.Namespace = "";
            // 
            // coldsSPrintL3DataTableS_Print
            // 
            this.coldsSPrintL3DataTableS_Print.Caption = "S_Print";
            this.coldsSPrintL3DataTableS_Print.ColumnName = "S_Print";
            this.coldsSPrintL3DataTableS_Print.Namespace = "";
            // 
            // coldsSPrintL3DataTableLogTime
            // 
            this.coldsSPrintL3DataTableLogTime.Caption = "LogTime";
            this.coldsSPrintL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsSPrintL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsSPrintL3DataTableLogTime.Namespace = "";
            // 
            // coldsSPrintL3DataTableDataLogMode
            // 
            this.coldsSPrintL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsSPrintL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsSPrintL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsSPrintL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsSPrintL3DataTableStrandID
            // 
            this.coldsSPrintL3DataTableStrandID.Caption = "StrandID";
            this.coldsSPrintL3DataTableStrandID.ColumnName = "StrandID";
            this.coldsSPrintL3DataTableStrandID.Namespace = "";
            // 
            // coldsSPrintL3DataTableSize
            // 
            this.coldsSPrintL3DataTableSize.Caption = "Size";
            this.coldsSPrintL3DataTableSize.ColumnName = "Size";
            this.coldsSPrintL3DataTableSize.Namespace = "";
            // 
            // coldsSPrintL3DataTableOPERATOR
            // 
            this.coldsSPrintL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsSPrintL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsSPrintL3DataTableOPERATOR.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsSPrint;
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
            this.dtEnd,
            this.toolStripLabel2,
            this.dtStart,
            this.toolStripLabel6,
            this.btnOutput,
            this.cmbPossition,
            this.toolStripLabel3,
            this.txtSPrint});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(935, 25);
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
            this.dtEnd.Text = "2009-01-04";
            this.dtEnd.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
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
            this.toolStripLabel6.Text = "接收时间:";
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
            // cmbPossition
            // 
            this.cmbPossition.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbPossition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPossition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPossition.Name = "cmbPossition";
            this.cmbPossition.Size = new System.Drawing.Size(85, 25);
            this.cmbPossition.SelectedIndexChanged += new System.EventHandler(this.cmbPossition_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "取样地点:";
            // 
            // txtSPrint
            // 
            this.txtSPrint.Name = "txtSPrint";
            this.txtSPrint.Size = new System.Drawing.Size(100, 25);
            this.txtSPrint.Visible = false;
            // 
            // SPrintQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 543);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "SPrintQueryFrm";
            this.TabText = "低倍硫样查询";
            this.Text = "低倍硫样查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SPrintQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.SPrintQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSPrint;
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
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private AppSvrHMI.L3DataSet dsSPrint;
        private System.Data.DataTable schemadsSPrint;
        private System.Data.DataColumn coldsSPrintL3DataTableGUID;
        private System.Data.DataColumn coldsSPrintL3DataTableName;
        private System.Data.DataColumn coldsSPrintL3DataTableAppID;
        private System.Data.DataColumn coldsSPrintL3DataTableArrive_Date;
        private System.Data.DataColumn coldsSPrintL3DataTableReport_Date;
        private System.Data.DataColumn coldsSPrintL3DataTableHeatID;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Address;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Type;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Count;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Code;
        private System.Data.DataColumn coldsSPrintL3DataTableShrinkage_Hole;
        private System.Data.DataColumn coldsSPrintL3DataTableCenter_Loose;
        private System.Data.DataColumn coldsSPrintL3DataTableCommon_Loose;
        private System.Data.DataColumn coldsSPrintL3DataTableCenter_Crack_Lev;
        private System.Data.DataColumn coldsSPrintL3DataTableCenter_Crack_Len;
        private System.Data.DataColumn coldsSPrintL3DataTableHypo_Bubble;
        private System.Data.DataColumn coldsSPrintL3DataTableCenter_Crack;
        private System.Data.DataColumn coldsSPrintL3DataTableEquiaxed_Grain;
        private System.Data.DataColumn coldsSPrintL3DataTableHypo_Crack_D;
        private System.Data.DataColumn coldsSPrintL3DataTableHypo_Crack_L;
        private System.Data.DataColumn coldsSPrintL3DataTableHypo_Crack_Q;
        private System.Data.DataColumn coldsSPrintL3DataTableHypo_Crack_Lev;
        private System.Data.DataColumn coldsSPrintL3DataTableSurface_Eyelet;
        private System.Data.DataColumn coldsSPrintL3DataTableSurface_Crack;
        private System.Data.DataColumn coldsSPrintL3DataTableSurface_Slag;
        private System.Data.DataColumn coldsSPrintL3DataTableNonmetal_Slag;
        private System.Data.DataColumn coldsSPrintL3DataTableSpot;
        private System.Data.DataColumn coldsSPrintL3DataTableAcidTime;
        private System.Data.DataColumn coldsSPrintL3DataTableS_Print;
        private System.Data.DataColumn coldsSPrintL3DataTableLogTime;
        private System.Data.DataColumn coldsSPrintL3DataTableDataLogMode;
        private System.Data.DataColumn coldsSPrintL3DataTableStrandID;
        private System.Data.DataColumn coldsSPrintL3DataTableSize;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbPossition;
        private System.Windows.Forms.BindingSource bsSPrint;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox txtSPrint;
        private System.Data.DataColumn coldsSPrintL3DataTableOPERATOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shrinkageHoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerLooseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commonLooseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerCrackLevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerCrackLenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypoBubbleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerCrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equiaxedGrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypoCrackDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypoCrackLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypoCrackQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hypoCrackLevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceEyeletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceCrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceSlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonmetalSlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acidTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPrintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATOR;
    }
}