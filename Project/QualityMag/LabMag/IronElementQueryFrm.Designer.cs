namespace QualityMag.LabMag
{
    partial class IronElementQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronElementQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvIronElement = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIronElement = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronElement = new AppSvrHMI.L3DataSet();
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
            this.coldsElementL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsElementL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsElementL3DataTableC = new System.Data.DataColumn();
            this.coldsElementL3DataTableSi = new System.Data.DataColumn();
            this.coldsElementL3DataTableMn = new System.Data.DataColumn();
            this.coldsElementL3DataTableP = new System.Data.DataColumn();
            this.coldsElementL3DataTableS = new System.Data.DataColumn();
            this.coldsElementL3DataTableTi = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableS_Before = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableS_After = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableOPERATOR = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableSN = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableSB = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableAS = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTablePB = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableNI = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableMO = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableCU = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableCR = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableB = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableV = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableAL = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableNB = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableZN = new System.Data.DataColumn();
            this.AcoldsIronElementL3DataTableW = new System.Data.DataColumn();
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
            this.coldsIronElementL3DataTableSN = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableSB = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableAS = new System.Data.DataColumn();
            this.coldsIronElementL3DataTablePB = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableNI = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableMO = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableCU = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableCR = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableB = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableV = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableAL = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableNB = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableZN = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableW = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvIronElement);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1226, 543);
            this.hmiRootPanel1.TabIndex = 1;
            // 
            // dvIronElement
            // 
            this.dvIronElement.AllowUserToAddRows = false;
            this.dvIronElement.AutoGenerateColumns = false;
            this.dvIronElement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvIronElement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvIronElement.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvIronElement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appIDDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.SN,
            this.SB,
            this.AS,
            this.PB,
            this.NI,
            this.MO,
            this.CU,
            this.CR,
            this.B,
            this.V,
            this.AL,
            this.NB,
            this.ZN,
            this.W,
            this.sBeforeDataGridViewTextBoxColumn,
            this.sAfterDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn,
            this.OPERATOR});
            this.dvIronElement.DataSource = this.bsIronElement;
            this.dvIronElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronElement.Location = new System.Drawing.Point(0, 25);
            this.dvIronElement.Name = "dvIronElement";
            this.dvIronElement.ReadOnly = true;
            this.dvIronElement.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvIronElement.RowTemplate.Height = 23;
            this.dvIronElement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvIronElement.Size = new System.Drawing.Size(1226, 518);
            this.dvIronElement.TabIndex = 29;
            this.dvIronElement.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvElement_DataError);
            this.dvIronElement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvIronElement_CellContentClick);
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
            // tAPNoDataGridViewTextBoxColumn
            // 
            this.tAPNoDataGridViewTextBoxColumn.DataPropertyName = "TAP_No";
            this.tAPNoDataGridViewTextBoxColumn.Frozen = true;
            this.tAPNoDataGridViewTextBoxColumn.HeaderText = "铁次号";
            this.tAPNoDataGridViewTextBoxColumn.Name = "tAPNoDataGridViewTextBoxColumn";
            this.tAPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAPNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.Frozen = true;
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            this.tPCNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // sampleAddressDataGridViewTextBoxColumn
            // 
            this.sampleAddressDataGridViewTextBoxColumn.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.sampleAddressDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleAddressDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleAddressDataGridViewTextBoxColumn.Frozen = true;
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
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\' and (code_function_group = \'G\' OR code_function_gro" +
                "up = \'H\' OR code_function_group = \'T\') order by code_val_long";
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
            this.sampleTypeDataGridViewTextBoxColumn.Frozen = true;
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
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\' AND SUBSTR(CODE,1,1) <> \'Z\' AND (code_function_grou" +
                "p = \'G\' OR code_function_group = \'H\' OR code_function_group = \'T\') order by code" +
                "_val_long";
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
            // arriveDateDataGridViewTextBoxColumn
            // 
            this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "Arrive_Date";
            this.arriveDateDataGridViewTextBoxColumn.Frozen = true;
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.arriveDateDataGridViewTextBoxColumn.Visible = false;
            this.arriveDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.Frozen = true;
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampleCodeDataGridViewTextBoxColumn
            // 
            this.sampleCodeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn.Frozen = true;
            this.sampleCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn.Name = "sampleCodeDataGridViewTextBoxColumn";
            this.sampleCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.Frozen = true;
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            this.sampleCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sampleCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.Frozen = true;
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            this.unitTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitTypeIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.Frozen = true;
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.Frozen = true;
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.Frozen = true;
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.Frozen = true;
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.Frozen = true;
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.Frozen = true;
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.Frozen = true;
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // SN
            // 
            this.SN.DataPropertyName = "SN";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 42;
            // 
            // SB
            // 
            this.SB.DataPropertyName = "SB";
            this.SB.HeaderText = "SB";
            this.SB.Name = "SB";
            this.SB.ReadOnly = true;
            this.SB.Width = 42;
            // 
            // AS
            // 
            this.AS.DataPropertyName = "AS";
            this.AS.HeaderText = "AS";
            this.AS.Name = "AS";
            this.AS.ReadOnly = true;
            this.AS.Width = 42;
            // 
            // PB
            // 
            this.PB.DataPropertyName = "PB";
            this.PB.HeaderText = "PB";
            this.PB.Name = "PB";
            this.PB.ReadOnly = true;
            this.PB.Width = 42;
            // 
            // NI
            // 
            this.NI.DataPropertyName = "NI";
            this.NI.HeaderText = "NI";
            this.NI.Name = "NI";
            this.NI.ReadOnly = true;
            this.NI.Width = 42;
            // 
            // MO
            // 
            this.MO.DataPropertyName = "MO";
            this.MO.HeaderText = "MO";
            this.MO.Name = "MO";
            this.MO.ReadOnly = true;
            this.MO.Width = 42;
            // 
            // CU
            // 
            this.CU.DataPropertyName = "CU";
            this.CU.HeaderText = "CU";
            this.CU.Name = "CU";
            this.CU.ReadOnly = true;
            this.CU.Width = 42;
            // 
            // CR
            // 
            this.CR.DataPropertyName = "CR";
            this.CR.HeaderText = "CR";
            this.CR.Name = "CR";
            this.CR.ReadOnly = true;
            this.CR.Width = 42;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 36;
            // 
            // V
            // 
            this.V.DataPropertyName = "V";
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 36;
            // 
            // AL
            // 
            this.AL.DataPropertyName = "AL";
            this.AL.HeaderText = "AL";
            this.AL.Name = "AL";
            this.AL.ReadOnly = true;
            this.AL.Width = 42;
            // 
            // NB
            // 
            this.NB.DataPropertyName = "NB";
            this.NB.HeaderText = "NB";
            this.NB.Name = "NB";
            this.NB.ReadOnly = true;
            this.NB.Width = 42;
            // 
            // ZN
            // 
            this.ZN.DataPropertyName = "ZN";
            this.ZN.HeaderText = "ZN";
            this.ZN.Name = "ZN";
            this.ZN.ReadOnly = true;
            this.ZN.Width = 42;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 36;
            // 
            // sBeforeDataGridViewTextBoxColumn
            // 
            this.sBeforeDataGridViewTextBoxColumn.DataPropertyName = "S_Before";
            this.sBeforeDataGridViewTextBoxColumn.HeaderText = "前硫";
            this.sBeforeDataGridViewTextBoxColumn.Name = "sBeforeDataGridViewTextBoxColumn";
            this.sBeforeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sBeforeDataGridViewTextBoxColumn.Visible = false;
            this.sBeforeDataGridViewTextBoxColumn.Width = 54;
            // 
            // sAfterDataGridViewTextBoxColumn
            // 
            this.sAfterDataGridViewTextBoxColumn.DataPropertyName = "S_After";
            this.sAfterDataGridViewTextBoxColumn.HeaderText = "后硫";
            this.sAfterDataGridViewTextBoxColumn.Name = "sAfterDataGridViewTextBoxColumn";
            this.sAfterDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAfterDataGridViewTextBoxColumn.Visible = false;
            this.sAfterDataGridViewTextBoxColumn.Width = 54;
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
            // OPERATOR
            // 
            this.OPERATOR.DataPropertyName = "OPERATOR";
            this.OPERATOR.HeaderText = "检验员";
            this.OPERATOR.Name = "OPERATOR";
            this.OPERATOR.ReadOnly = true;
            this.OPERATOR.Width = 66;
            // 
            // bsIronElement
            // 
            this.bsIronElement.DataMember = "L3DataTable";
            this.bsIronElement.DataSource = this.dsIronElement;
            // 
            // dsIronElement
            // 
            this.dsIronElement.AutoLoad = true;
            this.dsIronElement.AutoSubscribe = false;
            this.dsIronElement.DataSetName = "L3DataSet";
            this.dsIronElement.DeleteMethod = null;
            this.dsIronElement.InsertMethod = null;
            this.dsIronElement.L3DataAdapter = this.Adapter;
            this.dsIronElement.LoadEvent = "Click";
            this.dsIronElement.LoadTrigger = null;
            this.dsIronElement.RefreshValve = 1000;
            this.dsIronElement.SourceCommand = null;
            this.dsIronElement.SourceCondition = "1=2";
            this.dsIronElement.SourceMethod = "";
            this.dsIronElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronElement.SourceURI = "XGMESLogic\\QualityMag\\CQA_Iron_Element";
            this.dsIronElement.SubscribeTarget = null;
            this.dsIronElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSPrint});
            this.dsIronElement.UpdateEvent = "Click";
            this.dsIronElement.UpdateMethod = null;
            this.dsIronElement.UpdateTrigger = null;
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
            this.coldsElementL3DataTableUnitTypeID,
            this.coldsElementL3DataTableUnitID,
            this.coldsElementL3DataTableC,
            this.coldsElementL3DataTableSi,
            this.coldsElementL3DataTableMn,
            this.coldsElementL3DataTableP,
            this.coldsElementL3DataTableS,
            this.coldsElementL3DataTableTi,
            this.coldsIronElementL3DataTableTAP_No,
            this.coldsIronElementL3DataTableTPC_No,
            this.coldsIronElementL3DataTableS_Before,
            this.coldsIronElementL3DataTableS_After,
            this.coldsIronElementL3DataTableOPERATOR,
            this.AcoldsIronElementL3DataTableSN,
            this.AcoldsIronElementL3DataTableSB,
            this.AcoldsIronElementL3DataTableAS,
            this.AcoldsIronElementL3DataTablePB,
            this.AcoldsIronElementL3DataTableNI,
            this.AcoldsIronElementL3DataTableMO,
            this.AcoldsIronElementL3DataTableCU,
            this.AcoldsIronElementL3DataTableCR,
            this.AcoldsIronElementL3DataTableB,
            this.AcoldsIronElementL3DataTableV,
            this.AcoldsIronElementL3DataTableAL,
            this.AcoldsIronElementL3DataTableNB,
            this.AcoldsIronElementL3DataTableZN,
            this.AcoldsIronElementL3DataTableW});
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
            // coldsElementL3DataTableTi
            // 
            this.coldsElementL3DataTableTi.Caption = "Ti";
            this.coldsElementL3DataTableTi.ColumnName = "Ti";
            this.coldsElementL3DataTableTi.Namespace = "";
            // 
            // coldsIronElementL3DataTableTAP_No
            // 
            this.coldsIronElementL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsIronElementL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsIronElementL3DataTableTAP_No.Namespace = "";
            // 
            // coldsIronElementL3DataTableTPC_No
            // 
            this.coldsIronElementL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsIronElementL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsIronElementL3DataTableTPC_No.Namespace = "";
            // 
            // coldsIronElementL3DataTableS_Before
            // 
            this.coldsIronElementL3DataTableS_Before.Caption = "S_Before";
            this.coldsIronElementL3DataTableS_Before.ColumnName = "S_Before";
            this.coldsIronElementL3DataTableS_Before.Namespace = "";
            // 
            // coldsIronElementL3DataTableS_After
            // 
            this.coldsIronElementL3DataTableS_After.Caption = "S_After";
            this.coldsIronElementL3DataTableS_After.ColumnName = "S_After";
            this.coldsIronElementL3DataTableS_After.Namespace = "";
            // 
            // coldsIronElementL3DataTableOPERATOR
            // 
            this.coldsIronElementL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsIronElementL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsIronElementL3DataTableOPERATOR.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableSN
            // 
            this.AcoldsIronElementL3DataTableSN.Caption = "SN";
            this.AcoldsIronElementL3DataTableSN.ColumnName = "SN";
            this.AcoldsIronElementL3DataTableSN.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableSB
            // 
            this.AcoldsIronElementL3DataTableSB.Caption = "SB";
            this.AcoldsIronElementL3DataTableSB.ColumnName = "SB";
            this.AcoldsIronElementL3DataTableSB.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableAS
            // 
            this.AcoldsIronElementL3DataTableAS.Caption = "AS";
            this.AcoldsIronElementL3DataTableAS.ColumnName = "AS";
            this.AcoldsIronElementL3DataTableAS.Namespace = "";
            // 
            // AcoldsIronElementL3DataTablePB
            // 
            this.AcoldsIronElementL3DataTablePB.Caption = "PB";
            this.AcoldsIronElementL3DataTablePB.ColumnName = "PB";
            this.AcoldsIronElementL3DataTablePB.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableNI
            // 
            this.AcoldsIronElementL3DataTableNI.Caption = "NI";
            this.AcoldsIronElementL3DataTableNI.ColumnName = "NI";
            this.AcoldsIronElementL3DataTableNI.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableMO
            // 
            this.AcoldsIronElementL3DataTableMO.Caption = "MO";
            this.AcoldsIronElementL3DataTableMO.ColumnName = "MO";
            this.AcoldsIronElementL3DataTableMO.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableCU
            // 
            this.AcoldsIronElementL3DataTableCU.Caption = "CU";
            this.AcoldsIronElementL3DataTableCU.ColumnName = "CU";
            this.AcoldsIronElementL3DataTableCU.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableCR
            // 
            this.AcoldsIronElementL3DataTableCR.Caption = "CR";
            this.AcoldsIronElementL3DataTableCR.ColumnName = "CR";
            this.AcoldsIronElementL3DataTableCR.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableB
            // 
            this.AcoldsIronElementL3DataTableB.Caption = "B";
            this.AcoldsIronElementL3DataTableB.ColumnName = "B";
            this.AcoldsIronElementL3DataTableB.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableV
            // 
            this.AcoldsIronElementL3DataTableV.Caption = "V";
            this.AcoldsIronElementL3DataTableV.ColumnName = "V";
            this.AcoldsIronElementL3DataTableV.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableAL
            // 
            this.AcoldsIronElementL3DataTableAL.Caption = "AL";
            this.AcoldsIronElementL3DataTableAL.ColumnName = "AL";
            this.AcoldsIronElementL3DataTableAL.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableNB
            // 
            this.AcoldsIronElementL3DataTableNB.Caption = "NB";
            this.AcoldsIronElementL3DataTableNB.ColumnName = "NB";
            this.AcoldsIronElementL3DataTableNB.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableZN
            // 
            this.AcoldsIronElementL3DataTableZN.Caption = "ZN";
            this.AcoldsIronElementL3DataTableZN.ColumnName = "ZN";
            this.AcoldsIronElementL3DataTableZN.Namespace = "";
            // 
            // AcoldsIronElementL3DataTableW
            // 
            this.AcoldsIronElementL3DataTableW.Caption = "W";
            this.AcoldsIronElementL3DataTableW.ColumnName = "W";
            this.AcoldsIronElementL3DataTableW.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsIronElement;
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
            this.bdN1.Size = new System.Drawing.Size(1226, 25);
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
            this.dtInStoreEndData.Size = new System.Drawing.Size(100, 22);
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
            this.dtInStoreData.Size = new System.Drawing.Size(100, 22);
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
            this.cmbPossition.Size = new System.Drawing.Size(100, 25);
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
            // coldsIronElementL3DataTableSN
            // 
            this.coldsIronElementL3DataTableSN.Caption = "SN";
            this.coldsIronElementL3DataTableSN.ColumnName = "SN";
            this.coldsIronElementL3DataTableSN.Namespace = "";
            // 
            // coldsIronElementL3DataTableSB
            // 
            this.coldsIronElementL3DataTableSB.Caption = "SB";
            this.coldsIronElementL3DataTableSB.ColumnName = "SB";
            this.coldsIronElementL3DataTableSB.Namespace = "";
            // 
            // coldsIronElementL3DataTableAS
            // 
            this.coldsIronElementL3DataTableAS.Caption = "AS";
            this.coldsIronElementL3DataTableAS.ColumnName = "AS";
            this.coldsIronElementL3DataTableAS.Namespace = "";
            // 
            // coldsIronElementL3DataTablePB
            // 
            this.coldsIronElementL3DataTablePB.Caption = "PB";
            this.coldsIronElementL3DataTablePB.ColumnName = "PB";
            this.coldsIronElementL3DataTablePB.Namespace = "";
            // 
            // coldsIronElementL3DataTableNI
            // 
            this.coldsIronElementL3DataTableNI.Caption = "NI";
            this.coldsIronElementL3DataTableNI.ColumnName = "NI";
            this.coldsIronElementL3DataTableNI.Namespace = "";
            // 
            // coldsIronElementL3DataTableMO
            // 
            this.coldsIronElementL3DataTableMO.Caption = "MO";
            this.coldsIronElementL3DataTableMO.ColumnName = "MO";
            this.coldsIronElementL3DataTableMO.Namespace = "";
            // 
            // coldsIronElementL3DataTableCU
            // 
            this.coldsIronElementL3DataTableCU.Caption = "CU";
            this.coldsIronElementL3DataTableCU.ColumnName = "CU";
            this.coldsIronElementL3DataTableCU.Namespace = "";
            // 
            // coldsIronElementL3DataTableCR
            // 
            this.coldsIronElementL3DataTableCR.Caption = "CR";
            this.coldsIronElementL3DataTableCR.ColumnName = "CR";
            this.coldsIronElementL3DataTableCR.Namespace = "";
            // 
            // coldsIronElementL3DataTableB
            // 
            this.coldsIronElementL3DataTableB.Caption = "B";
            this.coldsIronElementL3DataTableB.ColumnName = "B";
            this.coldsIronElementL3DataTableB.Namespace = "";
            // 
            // coldsIronElementL3DataTableV
            // 
            this.coldsIronElementL3DataTableV.Caption = "V";
            this.coldsIronElementL3DataTableV.ColumnName = "V";
            this.coldsIronElementL3DataTableV.Namespace = "";
            // 
            // coldsIronElementL3DataTableAL
            // 
            this.coldsIronElementL3DataTableAL.Caption = "AL";
            this.coldsIronElementL3DataTableAL.ColumnName = "AL";
            this.coldsIronElementL3DataTableAL.Namespace = "";
            // 
            // coldsIronElementL3DataTableNB
            // 
            this.coldsIronElementL3DataTableNB.Caption = "NB";
            this.coldsIronElementL3DataTableNB.ColumnName = "NB";
            this.coldsIronElementL3DataTableNB.Namespace = "";
            // 
            // coldsIronElementL3DataTableZN
            // 
            this.coldsIronElementL3DataTableZN.Caption = "ZN";
            this.coldsIronElementL3DataTableZN.ColumnName = "ZN";
            this.coldsIronElementL3DataTableZN.Namespace = "";
            // 
            // coldsIronElementL3DataTableW
            // 
            this.coldsIronElementL3DataTableW.Caption = "W";
            this.coldsIronElementL3DataTableW.ColumnName = "W";
            this.coldsIronElementL3DataTableW.Namespace = "";
            // 
            // IronElementQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 543);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "IronElementQueryFrm";
            this.TabText = "铁水样查询";
            this.Text = "铁水样查询";
            this.Load += new System.EventHandler(this.IronElementQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronElementQueryFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIronElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvIronElement;
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
        private AppSvrHMI.L3DataSet dsIronElement;
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
        private System.Windows.Forms.BindingSource bsIronElement;
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
        private System.Data.DataColumn coldsElementL3DataTableTi;
        private System.Windows.Forms.ToolStripComboBox cmbSampleType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSampleType;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsIronElementL3DataTableTAP_No;
        private System.Data.DataColumn coldsIronElementL3DataTableTPC_No;
        private System.Data.DataColumn coldsIronElementL3DataTableS_Before;
        private System.Data.DataColumn coldsIronElementL3DataTableS_After;
        private System.Data.DataColumn coldsIronElementL3DataTableOPERATOR;
        private System.Data.DataColumn coldsIronElementL3DataTableSN;
        private System.Data.DataColumn coldsIronElementL3DataTableSB;
        private System.Data.DataColumn coldsIronElementL3DataTableAS;
        private System.Data.DataColumn coldsIronElementL3DataTablePB;
        private System.Data.DataColumn coldsIronElementL3DataTableNI;
        private System.Data.DataColumn coldsIronElementL3DataTableMO;
        private System.Data.DataColumn coldsIronElementL3DataTableCU;
        private System.Data.DataColumn coldsIronElementL3DataTableCR;
        private System.Data.DataColumn coldsIronElementL3DataTableB;
        private System.Data.DataColumn coldsIronElementL3DataTableV;
        private System.Data.DataColumn coldsIronElementL3DataTableAL;
        private System.Data.DataColumn coldsIronElementL3DataTableNB;
        private System.Data.DataColumn coldsIronElementL3DataTableZN;
        private System.Data.DataColumn coldsIronElementL3DataTableW;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SB;
        private System.Windows.Forms.DataGridViewTextBoxColumn AS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn AL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZN;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATOR;
        private System.Data.DataColumn AcoldsIronElementL3DataTableSN;
        private System.Data.DataColumn AcoldsIronElementL3DataTableSB;
        private System.Data.DataColumn AcoldsIronElementL3DataTableAS;
        private System.Data.DataColumn AcoldsIronElementL3DataTablePB;
        private System.Data.DataColumn AcoldsIronElementL3DataTableNI;
        private System.Data.DataColumn AcoldsIronElementL3DataTableMO;
        private System.Data.DataColumn AcoldsIronElementL3DataTableCU;
        private System.Data.DataColumn AcoldsIronElementL3DataTableCR;
        private System.Data.DataColumn AcoldsIronElementL3DataTableB;
        private System.Data.DataColumn AcoldsIronElementL3DataTableV;
        private System.Data.DataColumn AcoldsIronElementL3DataTableAL;
        private System.Data.DataColumn AcoldsIronElementL3DataTableNB;
        private System.Data.DataColumn AcoldsIronElementL3DataTableZN;
        private System.Data.DataColumn AcoldsIronElementL3DataTableW;
    }
}