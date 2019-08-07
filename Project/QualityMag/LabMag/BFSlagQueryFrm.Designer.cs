namespace QualityMag.LabMag
{
    partial class BFSlagQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BFSlagQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSlag = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteelGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SteelGradeIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.sampleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al2O3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p2O5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSlag = new System.Windows.Forms.BindingSource(this.components);
            this.dsSlag = new AppSvrHMI.L3DataSet();
            this.schemadsSPrint = new System.Data.DataTable();
            this.coldsSPrintL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableName = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableAppID = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsElementL3DataTableS = new System.Data.DataColumn();
            this.coldsSlagL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSlagL3DataTableTFe = new System.Data.DataColumn();
            this.coldsSlagL3DataTableFeO = new System.Data.DataColumn();
            this.coldsSlagL3DataTableSiO2 = new System.Data.DataColumn();
            this.coldsSlagL3DataTableTCa = new System.Data.DataColumn();
            this.coldsSlagL3DataTableCaO = new System.Data.DataColumn();
            this.coldsSlagL3DataTableMgO = new System.Data.DataColumn();
            this.coldsSlagL3DataTableMnO = new System.Data.DataColumn();
            this.coldsSlagL3DataTableTiO2 = new System.Data.DataColumn();
            this.coldsSlagL3DataTableP2O5 = new System.Data.DataColumn();
            this.coldsSlagL3DataTableR = new System.Data.DataColumn();
            this.coldsSlagL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSlagL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSlagL3DataTableAl2O3 = new System.Data.DataColumn();
            this.coldsSlagL3DataTableOPERATOR = new System.Data.DataColumn();
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
            this.dtInStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtInStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.cmbPossition = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtElement = new System.Windows.Forms.ToolStripTextBox();
            this.cmbSampleType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtSampleType = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvSlag);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(944, 543);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvSlag
            // 
            this.dvSlag.AllowUserToAddRows = false;
            this.dvSlag.AutoGenerateColumns = false;
            this.dvSlag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSlag.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvSlag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSlag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.SteelGrade,
            this.SteelGradeIndex,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tFeDataGridViewTextBoxColumn,
            this.feODataGridViewTextBoxColumn,
            this.siO2DataGridViewTextBoxColumn,
            this.tCaDataGridViewTextBoxColumn,
            this.caODataGridViewTextBoxColumn,
            this.mgODataGridViewTextBoxColumn,
            this.mnODataGridViewTextBoxColumn,
            this.tiO2DataGridViewTextBoxColumn,
            this.Al2O3,
            this.p2O5DataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn,
            this.OPERATOR});
            this.dvSlag.DataSource = this.bsSlag;
            this.dvSlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSlag.Location = new System.Drawing.Point(0, 25);
            this.dvSlag.Name = "dvSlag";
            this.dvSlag.ReadOnly = true;
            this.dvSlag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSlag.RowTemplate.Height = 23;
            this.dvSlag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSlag.Size = new System.Drawing.Size(944, 518);
            this.dvSlag.TabIndex = 29;
            this.dvSlag.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvElement_DataError);
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
            // SteelGrade
            // 
            this.SteelGrade.DataPropertyName = "SteelGrade";
            this.SteelGrade.HeaderText = "钢种";
            this.SteelGrade.Name = "SteelGrade";
            this.SteelGrade.ReadOnly = true;
            this.SteelGrade.Visible = false;
            this.SteelGrade.Width = 54;
            // 
            // SteelGradeIndex
            // 
            this.SteelGradeIndex.DataPropertyName = "SteelGradeIndex";
            this.SteelGradeIndex.HeaderText = "炼钢记号";
            this.SteelGradeIndex.Name = "SteelGradeIndex";
            this.SteelGradeIndex.ReadOnly = true;
            this.SteelGradeIndex.Visible = false;
            this.SteelGradeIndex.Width = 78;
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
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = false;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\' and CODE_FUNCTION_GROUP = \'G\' ORDER BY CODE_VAL_LON" +
                "G";
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
            this.sampleTypeDataGridViewTextBoxColumn.DataSource = this.dsSampleType;
            this.sampleTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleTypeDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sampleTypeDataGridViewTextBoxColumn.Name = "sampleTypeDataGridViewTextBoxColumn";
            this.sampleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sampleTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSampleType
            // 
            this.dsSampleType.AutoLoad = true;
            this.dsSampleType.AutoSubscribe = false;
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\' and CODE_FUNCTION_GROUP = \'G\' and code = \'ZG\'";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleType});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleType
            // 
            this.schemadsSampleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleTypeL3DataTableCode,
            this.coldsSampleTypeL3DataTableCode_Des});
            this.schemadsSampleType.TableName = "L3DataTable";
            // 
            // coldsSampleTypeL3DataTableCode
            // 
            this.coldsSampleTypeL3DataTableCode.Caption = "Code";
            this.coldsSampleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsSampleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsSampleTypeL3DataTableCode_Des
            // 
            this.coldsSampleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            this.sampleCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleCountDataGridViewTextBoxColumn.Visible = false;
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
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // tFeDataGridViewTextBoxColumn
            // 
            this.tFeDataGridViewTextBoxColumn.DataPropertyName = "TFe";
            this.tFeDataGridViewTextBoxColumn.HeaderText = "TFe";
            this.tFeDataGridViewTextBoxColumn.Name = "tFeDataGridViewTextBoxColumn";
            this.tFeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tFeDataGridViewTextBoxColumn.Width = 48;
            // 
            // feODataGridViewTextBoxColumn
            // 
            this.feODataGridViewTextBoxColumn.DataPropertyName = "FeO";
            this.feODataGridViewTextBoxColumn.HeaderText = "FeO";
            this.feODataGridViewTextBoxColumn.Name = "feODataGridViewTextBoxColumn";
            this.feODataGridViewTextBoxColumn.ReadOnly = true;
            this.feODataGridViewTextBoxColumn.Width = 48;
            // 
            // siO2DataGridViewTextBoxColumn
            // 
            this.siO2DataGridViewTextBoxColumn.DataPropertyName = "SiO2";
            this.siO2DataGridViewTextBoxColumn.HeaderText = "SiO2";
            this.siO2DataGridViewTextBoxColumn.Name = "siO2DataGridViewTextBoxColumn";
            this.siO2DataGridViewTextBoxColumn.ReadOnly = true;
            this.siO2DataGridViewTextBoxColumn.Width = 54;
            // 
            // tCaDataGridViewTextBoxColumn
            // 
            this.tCaDataGridViewTextBoxColumn.DataPropertyName = "TCa";
            this.tCaDataGridViewTextBoxColumn.HeaderText = "TCa";
            this.tCaDataGridViewTextBoxColumn.Name = "tCaDataGridViewTextBoxColumn";
            this.tCaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCaDataGridViewTextBoxColumn.Width = 48;
            // 
            // caODataGridViewTextBoxColumn
            // 
            this.caODataGridViewTextBoxColumn.DataPropertyName = "CaO";
            this.caODataGridViewTextBoxColumn.HeaderText = "CaO";
            this.caODataGridViewTextBoxColumn.Name = "caODataGridViewTextBoxColumn";
            this.caODataGridViewTextBoxColumn.ReadOnly = true;
            this.caODataGridViewTextBoxColumn.Width = 48;
            // 
            // mgODataGridViewTextBoxColumn
            // 
            this.mgODataGridViewTextBoxColumn.DataPropertyName = "MgO";
            this.mgODataGridViewTextBoxColumn.HeaderText = "MgO";
            this.mgODataGridViewTextBoxColumn.Name = "mgODataGridViewTextBoxColumn";
            this.mgODataGridViewTextBoxColumn.ReadOnly = true;
            this.mgODataGridViewTextBoxColumn.Width = 48;
            // 
            // mnODataGridViewTextBoxColumn
            // 
            this.mnODataGridViewTextBoxColumn.DataPropertyName = "MnO";
            this.mnODataGridViewTextBoxColumn.HeaderText = "MnO";
            this.mnODataGridViewTextBoxColumn.Name = "mnODataGridViewTextBoxColumn";
            this.mnODataGridViewTextBoxColumn.ReadOnly = true;
            this.mnODataGridViewTextBoxColumn.Width = 48;
            // 
            // tiO2DataGridViewTextBoxColumn
            // 
            this.tiO2DataGridViewTextBoxColumn.DataPropertyName = "TiO2";
            this.tiO2DataGridViewTextBoxColumn.HeaderText = "TiO2";
            this.tiO2DataGridViewTextBoxColumn.Name = "tiO2DataGridViewTextBoxColumn";
            this.tiO2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tiO2DataGridViewTextBoxColumn.Width = 54;
            // 
            // Al2O3
            // 
            this.Al2O3.DataPropertyName = "Al2O3";
            this.Al2O3.HeaderText = "Al2O3";
            this.Al2O3.Name = "Al2O3";
            this.Al2O3.ReadOnly = true;
            this.Al2O3.Width = 60;
            // 
            // p2O5DataGridViewTextBoxColumn
            // 
            this.p2O5DataGridViewTextBoxColumn.DataPropertyName = "P2O5";
            this.p2O5DataGridViewTextBoxColumn.HeaderText = "P2O5";
            this.p2O5DataGridViewTextBoxColumn.Name = "p2O5DataGridViewTextBoxColumn";
            this.p2O5DataGridViewTextBoxColumn.ReadOnly = true;
            this.p2O5DataGridViewTextBoxColumn.Width = 54;
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            this.rDataGridViewTextBoxColumn.ReadOnly = true;
            this.rDataGridViewTextBoxColumn.Width = 36;
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
            // OPERATOR
            // 
            this.OPERATOR.DataPropertyName = "OPERATOR_Lab";
            this.OPERATOR.HeaderText = "检验员";
            this.OPERATOR.Name = "OPERATOR";
            this.OPERATOR.ReadOnly = true;
            this.OPERATOR.Width = 66;
            // 
            // bsSlag
            // 
            this.bsSlag.DataMember = "L3DataTable";
            this.bsSlag.DataSource = this.dsSlag;
            // 
            // dsSlag
            // 
            this.dsSlag.AutoLoad = true;
            this.dsSlag.AutoSubscribe = false;
            this.dsSlag.DataSetName = "L3DataSet";
            this.dsSlag.DeleteMethod = null;
            this.dsSlag.InsertMethod = null;
            this.dsSlag.L3DataAdapter = this.Adapter;
            this.dsSlag.LoadEvent = "Click";
            this.dsSlag.LoadTrigger = null;
            this.dsSlag.RefreshValve = 1000;
            this.dsSlag.SourceCommand = null;
            this.dsSlag.SourceCondition = "";
            this.dsSlag.SourceMethod = "";
            this.dsSlag.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSlag.SourceURI = "";
            this.dsSlag.SubscribeTarget = null;
            this.dsSlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSPrint});
            this.dsSlag.UpdateEvent = "Click";
            this.dsSlag.UpdateMethod = null;
            this.dsSlag.UpdateTrigger = null;
            // 
            // schemadsSPrint
            // 
            this.schemadsSPrint.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSPrintL3DataTableGUID,
            this.coldsSPrintL3DataTableName,
            this.coldsSPrintL3DataTableAppID,
            this.coldsSPrintL3DataTableArrive_Date,
            this.coldsSPrintL3DataTableReport_Date,
            this.coldsSPrintL3DataTableSample_Address,
            this.coldsSPrintL3DataTableSample_Type,
            this.coldsSPrintL3DataTableSample_Count,
            this.coldsSPrintL3DataTableSample_Code,
            this.coldsSPrintL3DataTableLogTime,
            this.coldsSPrintL3DataTableDataLogMode,
            this.coldsElementL3DataTableS,
            this.coldsSlagL3DataTableHeatID,
            this.coldsSlagL3DataTableTFe,
            this.coldsSlagL3DataTableFeO,
            this.coldsSlagL3DataTableSiO2,
            this.coldsSlagL3DataTableTCa,
            this.coldsSlagL3DataTableCaO,
            this.coldsSlagL3DataTableMgO,
            this.coldsSlagL3DataTableMnO,
            this.coldsSlagL3DataTableTiO2,
            this.coldsSlagL3DataTableP2O5,
            this.coldsSlagL3DataTableR,
            this.coldsSlagL3DataTableSteelGrade,
            this.coldsSlagL3DataTableSteelGradeIndex,
            this.coldsSlagL3DataTableAl2O3,
            this.coldsSlagL3DataTableOPERATOR});
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
            // coldsElementL3DataTableS
            // 
            this.coldsElementL3DataTableS.Caption = "S";
            this.coldsElementL3DataTableS.ColumnName = "S";
            this.coldsElementL3DataTableS.Namespace = "";
            // 
            // coldsSlagL3DataTableHeatID
            // 
            this.coldsSlagL3DataTableHeatID.Caption = "HeatID";
            this.coldsSlagL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSlagL3DataTableHeatID.Namespace = "";
            // 
            // coldsSlagL3DataTableTFe
            // 
            this.coldsSlagL3DataTableTFe.Caption = "TFe";
            this.coldsSlagL3DataTableTFe.ColumnName = "TFe";
            this.coldsSlagL3DataTableTFe.Namespace = "";
            // 
            // coldsSlagL3DataTableFeO
            // 
            this.coldsSlagL3DataTableFeO.Caption = "FeO";
            this.coldsSlagL3DataTableFeO.ColumnName = "FeO";
            this.coldsSlagL3DataTableFeO.Namespace = "";
            // 
            // coldsSlagL3DataTableSiO2
            // 
            this.coldsSlagL3DataTableSiO2.Caption = "SiO2";
            this.coldsSlagL3DataTableSiO2.ColumnName = "SiO2";
            this.coldsSlagL3DataTableSiO2.Namespace = "";
            // 
            // coldsSlagL3DataTableTCa
            // 
            this.coldsSlagL3DataTableTCa.Caption = "TCa";
            this.coldsSlagL3DataTableTCa.ColumnName = "TCa";
            this.coldsSlagL3DataTableTCa.Namespace = "";
            // 
            // coldsSlagL3DataTableCaO
            // 
            this.coldsSlagL3DataTableCaO.Caption = "CaO";
            this.coldsSlagL3DataTableCaO.ColumnName = "CaO";
            this.coldsSlagL3DataTableCaO.Namespace = "";
            // 
            // coldsSlagL3DataTableMgO
            // 
            this.coldsSlagL3DataTableMgO.Caption = "MgO";
            this.coldsSlagL3DataTableMgO.ColumnName = "MgO";
            this.coldsSlagL3DataTableMgO.Namespace = "";
            // 
            // coldsSlagL3DataTableMnO
            // 
            this.coldsSlagL3DataTableMnO.Caption = "MnO";
            this.coldsSlagL3DataTableMnO.ColumnName = "MnO";
            this.coldsSlagL3DataTableMnO.Namespace = "";
            // 
            // coldsSlagL3DataTableTiO2
            // 
            this.coldsSlagL3DataTableTiO2.Caption = "TiO2";
            this.coldsSlagL3DataTableTiO2.ColumnName = "TiO2";
            this.coldsSlagL3DataTableTiO2.Namespace = "";
            // 
            // coldsSlagL3DataTableP2O5
            // 
            this.coldsSlagL3DataTableP2O5.Caption = "P2O5";
            this.coldsSlagL3DataTableP2O5.ColumnName = "P2O5";
            this.coldsSlagL3DataTableP2O5.Namespace = "";
            // 
            // coldsSlagL3DataTableR
            // 
            this.coldsSlagL3DataTableR.Caption = "R";
            this.coldsSlagL3DataTableR.ColumnName = "R";
            this.coldsSlagL3DataTableR.Namespace = "";
            // 
            // coldsSlagL3DataTableSteelGrade
            // 
            this.coldsSlagL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSlagL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSlagL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSlagL3DataTableSteelGradeIndex
            // 
            this.coldsSlagL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSlagL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSlagL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSlagL3DataTableAl2O3
            // 
            this.coldsSlagL3DataTableAl2O3.Caption = "Al2O3";
            this.coldsSlagL3DataTableAl2O3.ColumnName = "Al2O3";
            this.coldsSlagL3DataTableAl2O3.Namespace = "";
            // 
            // coldsSlagL3DataTableOPERATOR
            // 
            this.coldsSlagL3DataTableOPERATOR.Caption = "OPERATOR_Lab";
            this.coldsSlagL3DataTableOPERATOR.ColumnName = "OPERATOR_Lab";
            this.coldsSlagL3DataTableOPERATOR.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsSlag;
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
            this.dtInStoreEndData,
            this.toolStripLabel2,
            this.dtInStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.cmbPossition,
            this.toolStripLabel3,
            this.txtElement,
            this.cmbSampleType,
            this.toolStripLabel4,
            this.txtSampleType});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(944, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
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
            // dtInStoreEndData
            // 
            this.dtInStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.Name = "dtInStoreEndData";
            this.dtInStoreEndData.Size = new System.Drawing.Size(85, 22);
            this.dtInStoreEndData.Text = "2009-01-04";
            this.dtInStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtInStoreData
            // 
            this.dtInStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.Name = "dtInStoreData";
            this.dtInStoreData.Size = new System.Drawing.Size(85, 22);
            this.dtInStoreData.Text = "2008-11-16";
            this.dtInStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
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
            // txtElement
            // 
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(10, 25);
            this.txtElement.Visible = false;
            // 
            // cmbSampleType
            // 
            this.cmbSampleType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSampleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampleType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSampleType.Name = "cmbSampleType";
            this.cmbSampleType.Size = new System.Drawing.Size(100, 25);
            this.cmbSampleType.SelectedIndexChanged += new System.EventHandler(this.cmbSampleType_SelectedIndexChanged);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel4.Text = "试样类别:";
            // 
            // txtSampleType
            // 
            this.txtSampleType.Name = "txtSampleType";
            this.txtSampleType.Size = new System.Drawing.Size(10, 25);
            this.txtSampleType.Visible = false;
            // 
            // BFSlagQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 543);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "BFSlagQueryFrm";
            this.TabText = "高炉铁渣样查询";
            this.Text = "高炉铁渣样查询";
            this.Load += new System.EventHandler(this.BFSlagQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BFSlagQueryFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSlag;
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
        private buttonHide.ToolStripToriDateTimePicker dtInStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private AppSvrHMI.L3DataSet dsSlag;
        private System.Data.DataTable schemadsSPrint;
        private System.Data.DataColumn coldsSPrintL3DataTableGUID;
        private System.Data.DataColumn coldsSPrintL3DataTableName;
        private System.Data.DataColumn coldsSPrintL3DataTableAppID;
        private System.Data.DataColumn coldsSPrintL3DataTableArrive_Date;
        private System.Data.DataColumn coldsSPrintL3DataTableReport_Date;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Address;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Type;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Count;
        private System.Data.DataColumn coldsSPrintL3DataTableSample_Code;
        private System.Data.DataColumn coldsSPrintL3DataTableLogTime;
        private System.Data.DataColumn coldsSPrintL3DataTableDataLogMode;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbPossition;
        private System.Windows.Forms.BindingSource bsSlag;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox txtElement;
        private System.Data.DataColumn coldsElementL3DataTableS;
        private System.Windows.Forms.ToolStripComboBox cmbSampleType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSampleType;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsSlagL3DataTableHeatID;
        private System.Data.DataColumn coldsSlagL3DataTableTFe;
        private System.Data.DataColumn coldsSlagL3DataTableFeO;
        private System.Data.DataColumn coldsSlagL3DataTableSiO2;
        private System.Data.DataColumn coldsSlagL3DataTableTCa;
        private System.Data.DataColumn coldsSlagL3DataTableCaO;
        private System.Data.DataColumn coldsSlagL3DataTableMgO;
        private System.Data.DataColumn coldsSlagL3DataTableMnO;
        private System.Data.DataColumn coldsSlagL3DataTableTiO2;
        private System.Data.DataColumn coldsSlagL3DataTableP2O5;
        private System.Data.DataColumn coldsSlagL3DataTableR;
        private System.Data.DataColumn coldsSlagL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSlagL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSlagL3DataTableAl2O3;
        private System.Data.DataColumn coldsSlagL3DataTableOPERATOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelGradeIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al2O3;
        private System.Windows.Forms.DataGridViewTextBoxColumn p2O5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATOR;
    }
}