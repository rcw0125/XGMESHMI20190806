namespace QualityMag.LabMag
{
    partial class ElementQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvElement = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsElement = new System.Windows.Forms.BindingSource(this.components);
            this.dsElement = new AppSvrHMI.L3DataSet();
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
            this.coldsSPrintL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsSPrintL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsElementL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsElementL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsElementL3DataTableC = new System.Data.DataColumn();
            this.coldsElementL3DataTableSi = new System.Data.DataColumn();
            this.coldsElementL3DataTableMn = new System.Data.DataColumn();
            this.coldsElementL3DataTableP = new System.Data.DataColumn();
            this.coldsElementL3DataTableS = new System.Data.DataColumn();
            this.coldsElementL3DataTableCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableNi = new System.Data.DataColumn();
            this.coldsElementL3DataTableCr = new System.Data.DataColumn();
            this.coldsElementL3DataTableMo = new System.Data.DataColumn();
            this.coldsElementL3DataTableV = new System.Data.DataColumn();
            this.coldsElementL3DataTableNb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAl = new System.Data.DataColumn();
            this.coldsElementL3DataTableAlS = new System.Data.DataColumn();
            this.coldsElementL3DataTableTi = new System.Data.DataColumn();
            this.coldsElementL3DataTableB = new System.Data.DataColumn();
            this.coldsElementL3DataTableSb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAs = new System.Data.DataColumn();
            this.coldsElementL3DataTableSn = new System.Data.DataColumn();
            this.coldsElementL3DataTableZn = new System.Data.DataColumn();
            this.coldsElementL3DataTableCa = new System.Data.DataColumn();
            this.coldsElementL3DataTableW = new System.Data.DataColumn();
            this.coldsElementL3DataTablePb = new System.Data.DataColumn();
            this.coldsElementL3DataTableRe = new System.Data.DataColumn();
            this.coldsElementL3DataTableCeq = new System.Data.DataColumn();
            this.coldsElementL3DataTableN = new System.Data.DataColumn();
            this.coldsElementL3DataTableH = new System.Data.DataColumn();
            this.coldsElementL3DataTableO = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableOPERATOR = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvElement);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(986, 543);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvElement
            // 
            this.dvElement.AllowUserToAddRows = false;
            this.dvElement.AutoGenerateColumns = false;
            this.dvElement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.cuDataGridViewTextBoxColumn,
            this.niDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.nbDataGridViewTextBoxColumn,
            this.alDataGridViewTextBoxColumn,
            this.alSDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.sbDataGridViewTextBoxColumn,
            this.asDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.znDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.ceqDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.CrNi,
            this.CrCu,
            this.CrNiCu,
            this.other1DataGridViewTextBoxColumn,
            this.other2DataGridViewTextBoxColumn,
            this.other3DataGridViewTextBoxColumn,
            this.OPERATOR});
            this.dvElement.DataSource = this.bsElement;
            this.dvElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvElement.Location = new System.Drawing.Point(0, 25);
            this.dvElement.Name = "dvElement";
            this.dvElement.ReadOnly = true;
            this.dvElement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvElement.RowTemplate.Height = 23;
            this.dvElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvElement.Size = new System.Drawing.Size(986, 518);
            this.dvElement.TabIndex = 29;
            this.dvElement.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvElement_DataError);
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
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
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
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\' and code_function_group <> \'G\' and code_function_gr" +
                "oup <> \'H\' and code_function_group <> \'T\' order by code_val_long";
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
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\' AND SUBSTR(CODE,1,1) = \'G\' order by code_val_long";
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
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.logTimeDataGridViewTextBoxColumn.Width = 102;
            // 
            // dataLogModeDataGridViewTextBoxColumn
            // 
            this.dataLogModeDataGridViewTextBoxColumn.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn.HeaderText = "数据产生方式";
            this.dataLogModeDataGridViewTextBoxColumn.Name = "dataLogModeDataGridViewTextBoxColumn";
            this.dataLogModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLogModeDataGridViewTextBoxColumn.Width = 102;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            this.unitTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitTypeIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // cuDataGridViewTextBoxColumn
            // 
            this.cuDataGridViewTextBoxColumn.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn.Name = "cuDataGridViewTextBoxColumn";
            this.cuDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuDataGridViewTextBoxColumn.Width = 42;
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            this.niDataGridViewTextBoxColumn.ReadOnly = true;
            this.niDataGridViewTextBoxColumn.Width = 42;
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            this.crDataGridViewTextBoxColumn.ReadOnly = true;
            this.crDataGridViewTextBoxColumn.Width = 42;
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            this.moDataGridViewTextBoxColumn.ReadOnly = true;
            this.moDataGridViewTextBoxColumn.Width = 42;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.ReadOnly = true;
            this.vDataGridViewTextBoxColumn.Width = 36;
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            this.nbDataGridViewTextBoxColumn.ReadOnly = true;
            this.nbDataGridViewTextBoxColumn.Width = 42;
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            this.alDataGridViewTextBoxColumn.ReadOnly = true;
            this.alDataGridViewTextBoxColumn.Width = 42;
            // 
            // alSDataGridViewTextBoxColumn
            // 
            this.alSDataGridViewTextBoxColumn.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn.Name = "alSDataGridViewTextBoxColumn";
            this.alSDataGridViewTextBoxColumn.ReadOnly = true;
            this.alSDataGridViewTextBoxColumn.Width = 48;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            this.bDataGridViewTextBoxColumn.Width = 36;
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            this.sbDataGridViewTextBoxColumn.ReadOnly = true;
            this.sbDataGridViewTextBoxColumn.Width = 42;
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            this.asDataGridViewTextBoxColumn.ReadOnly = true;
            this.asDataGridViewTextBoxColumn.Width = 42;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.ReadOnly = true;
            this.snDataGridViewTextBoxColumn.Width = 42;
            // 
            // znDataGridViewTextBoxColumn
            // 
            this.znDataGridViewTextBoxColumn.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn.Name = "znDataGridViewTextBoxColumn";
            this.znDataGridViewTextBoxColumn.ReadOnly = true;
            this.znDataGridViewTextBoxColumn.Width = 42;
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            this.caDataGridViewTextBoxColumn.ReadOnly = true;
            this.caDataGridViewTextBoxColumn.Width = 42;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.ReadOnly = true;
            this.wDataGridViewTextBoxColumn.Width = 36;
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            this.pbDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbDataGridViewTextBoxColumn.Width = 42;
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            this.reDataGridViewTextBoxColumn.ReadOnly = true;
            this.reDataGridViewTextBoxColumn.Width = 42;
            // 
            // ceqDataGridViewTextBoxColumn
            // 
            this.ceqDataGridViewTextBoxColumn.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn.Name = "ceqDataGridViewTextBoxColumn";
            this.ceqDataGridViewTextBoxColumn.ReadOnly = true;
            this.ceqDataGridViewTextBoxColumn.Width = 48;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            this.nDataGridViewTextBoxColumn.Width = 36;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDataGridViewTextBoxColumn.Width = 36;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            this.oDataGridViewTextBoxColumn.Width = 36;
            // 
            // CrNi
            // 
            this.CrNi.DataPropertyName = "CrNi";
            this.CrNi.HeaderText = "CrNi";
            this.CrNi.Name = "CrNi";
            this.CrNi.ReadOnly = true;
            this.CrNi.Width = 54;
            // 
            // CrCu
            // 
            this.CrCu.DataPropertyName = "CrCu";
            this.CrCu.HeaderText = "CrCu";
            this.CrCu.Name = "CrCu";
            this.CrCu.ReadOnly = true;
            this.CrCu.Width = 54;
            // 
            // CrNiCu
            // 
            this.CrNiCu.DataPropertyName = "CrNiCu";
            this.CrNiCu.HeaderText = "CrNiCu";
            this.CrNiCu.Name = "CrNiCu";
            this.CrNiCu.ReadOnly = true;
            this.CrNiCu.Width = 66;
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            this.other1DataGridViewTextBoxColumn.ReadOnly = true;
            this.other1DataGridViewTextBoxColumn.Width = 60;
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "其他2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            this.other2DataGridViewTextBoxColumn.ReadOnly = true;
            this.other2DataGridViewTextBoxColumn.Width = 60;
            // 
            // other3DataGridViewTextBoxColumn
            // 
            this.other3DataGridViewTextBoxColumn.DataPropertyName = "Other3";
            this.other3DataGridViewTextBoxColumn.HeaderText = "其他3";
            this.other3DataGridViewTextBoxColumn.Name = "other3DataGridViewTextBoxColumn";
            this.other3DataGridViewTextBoxColumn.ReadOnly = true;
            this.other3DataGridViewTextBoxColumn.Width = 60;
            // 
            // OPERATOR
            // 
            this.OPERATOR.DataPropertyName = "OPERATOR";
            this.OPERATOR.HeaderText = "检验员";
            this.OPERATOR.Name = "OPERATOR";
            this.OPERATOR.ReadOnly = true;
            // 
            // bsElement
            // 
            this.bsElement.DataMember = "L3DataTable";
            this.bsElement.DataSource = this.dsElement;
            // 
            // dsElement
            // 
            this.dsElement.AutoLoad = true;
            this.dsElement.AutoSubscribe = false;
            this.dsElement.DataSetName = "L3DataSet";
            this.dsElement.DeleteMethod = null;
            this.dsElement.InsertMethod = null;
            this.dsElement.L3DataAdapter = this.Adapter;
            this.dsElement.LoadEvent = "Click";
            this.dsElement.LoadTrigger = null;
            this.dsElement.RefreshValve = 1000;
            this.dsElement.SourceCommand = null;
            this.dsElement.SourceCondition = "1=2";
            this.dsElement.SourceMethod = "";
            this.dsElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsElement.SourceURI = "XGMESLogic\\QualityMag\\CQA_Lab_Element";
            this.dsElement.SubscribeTarget = null;
            this.dsElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSPrint});
            this.dsElement.UpdateEvent = "Click";
            this.dsElement.UpdateMethod = null;
            this.dsElement.UpdateTrigger = null;
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
            this.coldsSPrintL3DataTableLogTime,
            this.coldsSPrintL3DataTableDataLogMode,
            this.coldsElementL3DataTableUnitTypeID,
            this.coldsElementL3DataTableUnitID,
            this.coldsElementL3DataTableC,
            this.coldsElementL3DataTableSi,
            this.coldsElementL3DataTableMn,
            this.coldsElementL3DataTableP,
            this.coldsElementL3DataTableS,
            this.coldsElementL3DataTableCu,
            this.coldsElementL3DataTableNi,
            this.coldsElementL3DataTableCr,
            this.coldsElementL3DataTableMo,
            this.coldsElementL3DataTableV,
            this.coldsElementL3DataTableNb,
            this.coldsElementL3DataTableAl,
            this.coldsElementL3DataTableAlS,
            this.coldsElementL3DataTableTi,
            this.coldsElementL3DataTableB,
            this.coldsElementL3DataTableSb,
            this.coldsElementL3DataTableAs,
            this.coldsElementL3DataTableSn,
            this.coldsElementL3DataTableZn,
            this.coldsElementL3DataTableCa,
            this.coldsElementL3DataTableW,
            this.coldsElementL3DataTablePb,
            this.coldsElementL3DataTableRe,
            this.coldsElementL3DataTableCeq,
            this.coldsElementL3DataTableN,
            this.coldsElementL3DataTableH,
            this.coldsElementL3DataTableO,
            this.coldsElementL3DataTableOther1,
            this.coldsElementL3DataTableOther2,
            this.coldsElementL3DataTableOther3,
            this.coldsElementL3DataTableCrNi,
            this.coldsElementL3DataTableCrCu,
            this.coldsElementL3DataTableCrNiCu,
            this.coldsElementL3DataTableOPERATOR});
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
            // coldsElementL3DataTableUnitTypeID
            // 
            this.coldsElementL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsElementL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsElementL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsElementL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsElementL3DataTableUnitID
            // 
            this.coldsElementL3DataTableUnitID.Caption = "UnitID";
            this.coldsElementL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsElementL3DataTableUnitID.DataType = typeof(int);
            this.coldsElementL3DataTableUnitID.Namespace = "";
            // 
            // coldsElementL3DataTableC
            // 
            this.coldsElementL3DataTableC.Caption = "C";
            this.coldsElementL3DataTableC.ColumnName = "C";
            this.coldsElementL3DataTableC.Namespace = "";
            // 
            // coldsElementL3DataTableSi
            // 
            this.coldsElementL3DataTableSi.Caption = "Si";
            this.coldsElementL3DataTableSi.ColumnName = "Si";
            this.coldsElementL3DataTableSi.Namespace = "";
            // 
            // coldsElementL3DataTableMn
            // 
            this.coldsElementL3DataTableMn.Caption = "Mn";
            this.coldsElementL3DataTableMn.ColumnName = "Mn";
            this.coldsElementL3DataTableMn.Namespace = "";
            // 
            // coldsElementL3DataTableP
            // 
            this.coldsElementL3DataTableP.Caption = "P";
            this.coldsElementL3DataTableP.ColumnName = "P";
            this.coldsElementL3DataTableP.Namespace = "";
            // 
            // coldsElementL3DataTableS
            // 
            this.coldsElementL3DataTableS.Caption = "S";
            this.coldsElementL3DataTableS.ColumnName = "S";
            this.coldsElementL3DataTableS.Namespace = "";
            // 
            // coldsElementL3DataTableCu
            // 
            this.coldsElementL3DataTableCu.Caption = "Cu";
            this.coldsElementL3DataTableCu.ColumnName = "Cu";
            this.coldsElementL3DataTableCu.Namespace = "";
            // 
            // coldsElementL3DataTableNi
            // 
            this.coldsElementL3DataTableNi.Caption = "Ni";
            this.coldsElementL3DataTableNi.ColumnName = "Ni";
            this.coldsElementL3DataTableNi.Namespace = "";
            // 
            // coldsElementL3DataTableCr
            // 
            this.coldsElementL3DataTableCr.Caption = "Cr";
            this.coldsElementL3DataTableCr.ColumnName = "Cr";
            this.coldsElementL3DataTableCr.Namespace = "";
            // 
            // coldsElementL3DataTableMo
            // 
            this.coldsElementL3DataTableMo.Caption = "Mo";
            this.coldsElementL3DataTableMo.ColumnName = "Mo";
            this.coldsElementL3DataTableMo.Namespace = "";
            // 
            // coldsElementL3DataTableV
            // 
            this.coldsElementL3DataTableV.Caption = "V";
            this.coldsElementL3DataTableV.ColumnName = "V";
            this.coldsElementL3DataTableV.Namespace = "";
            // 
            // coldsElementL3DataTableNb
            // 
            this.coldsElementL3DataTableNb.Caption = "Nb";
            this.coldsElementL3DataTableNb.ColumnName = "Nb";
            this.coldsElementL3DataTableNb.Namespace = "";
            // 
            // coldsElementL3DataTableAl
            // 
            this.coldsElementL3DataTableAl.Caption = "Al";
            this.coldsElementL3DataTableAl.ColumnName = "Al";
            this.coldsElementL3DataTableAl.Namespace = "";
            // 
            // coldsElementL3DataTableAlS
            // 
            this.coldsElementL3DataTableAlS.Caption = "AlS";
            this.coldsElementL3DataTableAlS.ColumnName = "AlS";
            this.coldsElementL3DataTableAlS.Namespace = "";
            // 
            // coldsElementL3DataTableTi
            // 
            this.coldsElementL3DataTableTi.Caption = "Ti";
            this.coldsElementL3DataTableTi.ColumnName = "Ti";
            this.coldsElementL3DataTableTi.Namespace = "";
            // 
            // coldsElementL3DataTableB
            // 
            this.coldsElementL3DataTableB.Caption = "B";
            this.coldsElementL3DataTableB.ColumnName = "B";
            this.coldsElementL3DataTableB.Namespace = "";
            // 
            // coldsElementL3DataTableSb
            // 
            this.coldsElementL3DataTableSb.Caption = "Sb";
            this.coldsElementL3DataTableSb.ColumnName = "Sb";
            this.coldsElementL3DataTableSb.Namespace = "";
            // 
            // coldsElementL3DataTableAs
            // 
            this.coldsElementL3DataTableAs.Caption = "As";
            this.coldsElementL3DataTableAs.ColumnName = "As";
            this.coldsElementL3DataTableAs.Namespace = "";
            // 
            // coldsElementL3DataTableSn
            // 
            this.coldsElementL3DataTableSn.Caption = "Sn";
            this.coldsElementL3DataTableSn.ColumnName = "Sn";
            this.coldsElementL3DataTableSn.Namespace = "";
            // 
            // coldsElementL3DataTableZn
            // 
            this.coldsElementL3DataTableZn.Caption = "Zn";
            this.coldsElementL3DataTableZn.ColumnName = "Zn";
            this.coldsElementL3DataTableZn.Namespace = "";
            // 
            // coldsElementL3DataTableCa
            // 
            this.coldsElementL3DataTableCa.Caption = "Ca";
            this.coldsElementL3DataTableCa.ColumnName = "Ca";
            this.coldsElementL3DataTableCa.Namespace = "";
            // 
            // coldsElementL3DataTableW
            // 
            this.coldsElementL3DataTableW.Caption = "W";
            this.coldsElementL3DataTableW.ColumnName = "W";
            this.coldsElementL3DataTableW.Namespace = "";
            // 
            // coldsElementL3DataTablePb
            // 
            this.coldsElementL3DataTablePb.Caption = "Pb";
            this.coldsElementL3DataTablePb.ColumnName = "Pb";
            this.coldsElementL3DataTablePb.Namespace = "";
            // 
            // coldsElementL3DataTableRe
            // 
            this.coldsElementL3DataTableRe.Caption = "Re";
            this.coldsElementL3DataTableRe.ColumnName = "Re";
            this.coldsElementL3DataTableRe.Namespace = "";
            // 
            // coldsElementL3DataTableCeq
            // 
            this.coldsElementL3DataTableCeq.Caption = "Ceq";
            this.coldsElementL3DataTableCeq.ColumnName = "Ceq";
            this.coldsElementL3DataTableCeq.Namespace = "";
            // 
            // coldsElementL3DataTableN
            // 
            this.coldsElementL3DataTableN.Caption = "N";
            this.coldsElementL3DataTableN.ColumnName = "N";
            this.coldsElementL3DataTableN.Namespace = "";
            // 
            // coldsElementL3DataTableH
            // 
            this.coldsElementL3DataTableH.Caption = "H";
            this.coldsElementL3DataTableH.ColumnName = "H";
            this.coldsElementL3DataTableH.Namespace = "";
            // 
            // coldsElementL3DataTableO
            // 
            this.coldsElementL3DataTableO.Caption = "O";
            this.coldsElementL3DataTableO.ColumnName = "O";
            this.coldsElementL3DataTableO.Namespace = "";
            // 
            // coldsElementL3DataTableOther1
            // 
            this.coldsElementL3DataTableOther1.Caption = "Other1";
            this.coldsElementL3DataTableOther1.ColumnName = "Other1";
            this.coldsElementL3DataTableOther1.Namespace = "";
            // 
            // coldsElementL3DataTableOther2
            // 
            this.coldsElementL3DataTableOther2.Caption = "Other2";
            this.coldsElementL3DataTableOther2.ColumnName = "Other2";
            this.coldsElementL3DataTableOther2.Namespace = "";
            // 
            // coldsElementL3DataTableOther3
            // 
            this.coldsElementL3DataTableOther3.Caption = "Other3";
            this.coldsElementL3DataTableOther3.ColumnName = "Other3";
            this.coldsElementL3DataTableOther3.Namespace = "";
            // 
            // coldsElementL3DataTableCrNi
            // 
            this.coldsElementL3DataTableCrNi.Caption = "CrNi";
            this.coldsElementL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsElementL3DataTableCrNi.Namespace = "";
            // 
            // coldsElementL3DataTableCrCu
            // 
            this.coldsElementL3DataTableCrCu.Caption = "CrCu";
            this.coldsElementL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsElementL3DataTableCrCu.Namespace = "";
            // 
            // coldsElementL3DataTableCrNiCu
            // 
            this.coldsElementL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsElementL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsElementL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsElementL3DataTableOPERATOR
            // 
            this.coldsElementL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsElementL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsElementL3DataTableOPERATOR.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsElement;
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
            this.bdN1.Size = new System.Drawing.Size(986, 25);
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
            // ElementQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 543);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "ElementQueryFrm";
            this.TabText = "过程样查询";
            this.Text = "过程样查询";
            this.Load += new System.EventHandler(this.ElementQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementQueryFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvElement;
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
        private AppSvrHMI.L3DataSet dsElement;
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
        private System.Data.DataColumn coldsSPrintL3DataTableLogTime;
        private System.Data.DataColumn coldsSPrintL3DataTableDataLogMode;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbPossition;
        private System.Windows.Forms.BindingSource bsElement;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox txtElement;
        private System.Data.DataColumn coldsElementL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsElementL3DataTableUnitID;
        private System.Data.DataColumn coldsElementL3DataTableC;
        private System.Data.DataColumn coldsElementL3DataTableSi;
        private System.Data.DataColumn coldsElementL3DataTableMn;
        private System.Data.DataColumn coldsElementL3DataTableP;
        private System.Data.DataColumn coldsElementL3DataTableS;
        private System.Data.DataColumn coldsElementL3DataTableCu;
        private System.Data.DataColumn coldsElementL3DataTableNi;
        private System.Data.DataColumn coldsElementL3DataTableCr;
        private System.Data.DataColumn coldsElementL3DataTableMo;
        private System.Data.DataColumn coldsElementL3DataTableV;
        private System.Data.DataColumn coldsElementL3DataTableNb;
        private System.Data.DataColumn coldsElementL3DataTableAl;
        private System.Data.DataColumn coldsElementL3DataTableAlS;
        private System.Data.DataColumn coldsElementL3DataTableTi;
        private System.Data.DataColumn coldsElementL3DataTableB;
        private System.Data.DataColumn coldsElementL3DataTableSb;
        private System.Data.DataColumn coldsElementL3DataTableAs;
        private System.Data.DataColumn coldsElementL3DataTableSn;
        private System.Data.DataColumn coldsElementL3DataTableZn;
        private System.Data.DataColumn coldsElementL3DataTableCa;
        private System.Data.DataColumn coldsElementL3DataTableW;
        private System.Data.DataColumn coldsElementL3DataTablePb;
        private System.Data.DataColumn coldsElementL3DataTableRe;
        private System.Data.DataColumn coldsElementL3DataTableCeq;
        private System.Data.DataColumn coldsElementL3DataTableN;
        private System.Data.DataColumn coldsElementL3DataTableH;
        private System.Data.DataColumn coldsElementL3DataTableO;
        private System.Data.DataColumn coldsElementL3DataTableOther1;
        private System.Data.DataColumn coldsElementL3DataTableOther2;
        private System.Data.DataColumn coldsElementL3DataTableOther3;
        private System.Windows.Forms.ToolStripComboBox cmbSampleType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSampleType;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsElementL3DataTableCrNi;
        private System.Data.DataColumn coldsElementL3DataTableCrCu;
        private System.Data.DataColumn coldsElementL3DataTableCrNiCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATOR;
        private System.Data.DataColumn coldsElementL3DataTableOPERATOR;
    }
}