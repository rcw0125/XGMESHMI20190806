namespace QualityMag.LabMag
{
    partial class BFIronElementQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BFIronElementQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvIronElement = new System.Windows.Forms.DataGridView();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tAPNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsIronElement = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronElement = new AppSvrHMI.L3DataSet();
            this.schemadsSPrint = new System.Data.DataTable();
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
            this.coldsIronElementL3DataTableSn = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableSb = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableAs = new System.Data.DataColumn();
            this.coldsIronElementL3DataTablePb = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableNi = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableMo = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableCu = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableCr = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableB = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableV = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableAl = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableNb = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableZn = new System.Data.DataColumn();
            this.coldsIronElementL3DataTableW = new System.Data.DataColumn();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(1192, 543);
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
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.tAPNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
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
            this.Ni,
            this.Mo,
            this.Cu,
            this.Cr,
            this.B,
            this.V,
            this.Al,
            this.Nb,
            this.Zn,
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
            this.dvIronElement.Size = new System.Drawing.Size(1192, 518);
            this.dvIronElement.TabIndex = 29;
            this.dvIronElement.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvElement_DataError);
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
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\' and code <> \'ZG\'  and  CODE_FUNCTION_GROUP = \'G\' OR" +
                "DER BY CODE_VAL_LONG";
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
            // tAPNoDataGridViewTextBoxColumn
            // 
            this.tAPNoDataGridViewTextBoxColumn.DataPropertyName = "TAP_No";
            this.tAPNoDataGridViewTextBoxColumn.HeaderText = "铁次号";
            this.tAPNoDataGridViewTextBoxColumn.Name = "tAPNoDataGridViewTextBoxColumn";
            this.tAPNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tAPNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            this.tPCNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPCNoDataGridViewTextBoxColumn.Width = 54;
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.cDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDataGridViewTextBoxColumn.Width = 36;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.siDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.ReadOnly = true;
            this.siDataGridViewTextBoxColumn.Width = 42;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "0";
            this.mnDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.ReadOnly = true;
            this.mnDataGridViewTextBoxColumn.Width = 42;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.pDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDataGridViewTextBoxColumn.Width = 36;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            this.sDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = "0";
            this.tiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiDataGridViewTextBoxColumn.Width = 42;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = "0";
            this.Sn.DefaultCellStyle = dataGridViewCellStyle7;
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.ReadOnly = true;
            this.Sn.Width = 42;
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = "0";
            this.Sb.DefaultCellStyle = dataGridViewCellStyle8;
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            this.Sb.ReadOnly = true;
            this.Sb.Width = 42;
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = "0";
            this.As.DefaultCellStyle = dataGridViewCellStyle9;
            this.As.HeaderText = "As";
            this.As.Name = "As";
            this.As.ReadOnly = true;
            this.As.Width = 42;
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = "0";
            this.Pb.DefaultCellStyle = dataGridViewCellStyle10;
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            this.Pb.ReadOnly = true;
            this.Pb.Width = 42;
            // 
            // Ni
            // 
            this.Ni.DataPropertyName = "Ni";
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = "0";
            this.Ni.DefaultCellStyle = dataGridViewCellStyle11;
            this.Ni.HeaderText = "Ni";
            this.Ni.Name = "Ni";
            this.Ni.ReadOnly = true;
            this.Ni.Width = 42;
            // 
            // Mo
            // 
            this.Mo.DataPropertyName = "Mo";
            dataGridViewCellStyle12.Format = "N3";
            dataGridViewCellStyle12.NullValue = "0";
            this.Mo.DefaultCellStyle = dataGridViewCellStyle12;
            this.Mo.HeaderText = "Mo";
            this.Mo.Name = "Mo";
            this.Mo.ReadOnly = true;
            this.Mo.Width = 42;
            // 
            // Cu
            // 
            this.Cu.DataPropertyName = "Cu";
            dataGridViewCellStyle13.Format = "N3";
            dataGridViewCellStyle13.NullValue = "0";
            this.Cu.DefaultCellStyle = dataGridViewCellStyle13;
            this.Cu.HeaderText = "Cu";
            this.Cu.Name = "Cu";
            this.Cu.ReadOnly = true;
            this.Cu.Width = 42;
            // 
            // Cr
            // 
            this.Cr.DataPropertyName = "Cr";
            dataGridViewCellStyle14.Format = "N3";
            dataGridViewCellStyle14.NullValue = "0";
            this.Cr.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            this.Cr.ReadOnly = true;
            this.Cr.Width = 42;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            dataGridViewCellStyle15.Format = "N3";
            dataGridViewCellStyle15.NullValue = "0";
            this.B.DefaultCellStyle = dataGridViewCellStyle15;
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 36;
            // 
            // V
            // 
            this.V.DataPropertyName = "V";
            dataGridViewCellStyle16.Format = "N3";
            dataGridViewCellStyle16.NullValue = "0";
            this.V.DefaultCellStyle = dataGridViewCellStyle16;
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 36;
            // 
            // Al
            // 
            this.Al.DataPropertyName = "Al";
            dataGridViewCellStyle17.Format = "N3";
            dataGridViewCellStyle17.NullValue = "0";
            this.Al.DefaultCellStyle = dataGridViewCellStyle17;
            this.Al.HeaderText = "Al";
            this.Al.Name = "Al";
            this.Al.ReadOnly = true;
            this.Al.Width = 42;
            // 
            // Nb
            // 
            this.Nb.DataPropertyName = "Nb";
            dataGridViewCellStyle18.Format = "N3";
            dataGridViewCellStyle18.NullValue = "0";
            this.Nb.DefaultCellStyle = dataGridViewCellStyle18;
            this.Nb.HeaderText = "Nb";
            this.Nb.Name = "Nb";
            this.Nb.ReadOnly = true;
            this.Nb.Width = 42;
            // 
            // Zn
            // 
            this.Zn.DataPropertyName = "Zn";
            dataGridViewCellStyle19.Format = "N3";
            dataGridViewCellStyle19.NullValue = "0";
            this.Zn.DefaultCellStyle = dataGridViewCellStyle19;
            this.Zn.HeaderText = "Zn";
            this.Zn.Name = "Zn";
            this.Zn.ReadOnly = true;
            this.Zn.Width = 42;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            dataGridViewCellStyle20.Format = "N3";
            dataGridViewCellStyle20.NullValue = "0";
            this.W.DefaultCellStyle = dataGridViewCellStyle20;
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
            this.coldsIronElementL3DataTableSn,
            this.coldsIronElementL3DataTableSb,
            this.coldsIronElementL3DataTableAs,
            this.coldsIronElementL3DataTablePb,
            this.coldsIronElementL3DataTableNi,
            this.coldsIronElementL3DataTableMo,
            this.coldsIronElementL3DataTableCu,
            this.coldsIronElementL3DataTableCr,
            this.coldsIronElementL3DataTableB,
            this.coldsIronElementL3DataTableV,
            this.coldsIronElementL3DataTableAl,
            this.coldsIronElementL3DataTableNb,
            this.coldsIronElementL3DataTableZn,
            this.coldsIronElementL3DataTableW});
            this.schemadsSPrint.TableName = "L3DataTable";
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
            this.coldsIronElementL3DataTableOPERATOR.Caption = "Operator";
            this.coldsIronElementL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsIronElementL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsIronElementL3DataTableSn
            // 
            this.coldsIronElementL3DataTableSn.Caption = "Sn";
            this.coldsIronElementL3DataTableSn.ColumnName = "Sn";
            this.coldsIronElementL3DataTableSn.Namespace = "";
            // 
            // coldsIronElementL3DataTableSb
            // 
            this.coldsIronElementL3DataTableSb.Caption = "Sb";
            this.coldsIronElementL3DataTableSb.ColumnName = "Sb";
            this.coldsIronElementL3DataTableSb.Namespace = "";
            // 
            // coldsIronElementL3DataTableAs
            // 
            this.coldsIronElementL3DataTableAs.Caption = "As";
            this.coldsIronElementL3DataTableAs.ColumnName = "As";
            this.coldsIronElementL3DataTableAs.Namespace = "";
            // 
            // coldsIronElementL3DataTablePb
            // 
            this.coldsIronElementL3DataTablePb.Caption = "Pb";
            this.coldsIronElementL3DataTablePb.ColumnName = "Pb";
            this.coldsIronElementL3DataTablePb.Namespace = "";
            // 
            // coldsIronElementL3DataTableNi
            // 
            this.coldsIronElementL3DataTableNi.Caption = "Ni";
            this.coldsIronElementL3DataTableNi.ColumnName = "Ni";
            this.coldsIronElementL3DataTableNi.Namespace = "";
            // 
            // coldsIronElementL3DataTableMo
            // 
            this.coldsIronElementL3DataTableMo.Caption = "Mo";
            this.coldsIronElementL3DataTableMo.ColumnName = "Mo";
            this.coldsIronElementL3DataTableMo.Namespace = "";
            // 
            // coldsIronElementL3DataTableCu
            // 
            this.coldsIronElementL3DataTableCu.Caption = "Cu";
            this.coldsIronElementL3DataTableCu.ColumnName = "Cu";
            this.coldsIronElementL3DataTableCu.Namespace = "";
            // 
            // coldsIronElementL3DataTableCr
            // 
            this.coldsIronElementL3DataTableCr.Caption = "Cr";
            this.coldsIronElementL3DataTableCr.ColumnName = "Cr";
            this.coldsIronElementL3DataTableCr.Namespace = "";
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
            // coldsIronElementL3DataTableAl
            // 
            this.coldsIronElementL3DataTableAl.Caption = "Al";
            this.coldsIronElementL3DataTableAl.ColumnName = "Al";
            this.coldsIronElementL3DataTableAl.Namespace = "";
            // 
            // coldsIronElementL3DataTableNb
            // 
            this.coldsIronElementL3DataTableNb.Caption = "Nb";
            this.coldsIronElementL3DataTableNb.ColumnName = "Nb";
            this.coldsIronElementL3DataTableNb.Namespace = "";
            // 
            // coldsIronElementL3DataTableZn
            // 
            this.coldsIronElementL3DataTableZn.Caption = "Zn";
            this.coldsIronElementL3DataTableZn.ColumnName = "Zn";
            this.coldsIronElementL3DataTableZn.Namespace = "";
            // 
            // coldsIronElementL3DataTableW
            // 
            this.coldsIronElementL3DataTableW.Caption = "W";
            this.coldsIronElementL3DataTableW.ColumnName = "W";
            this.coldsIronElementL3DataTableW.Namespace = "";
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
            this.bdN1.Size = new System.Drawing.Size(1192, 25);
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
            // BFIronElementQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 543);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "BFIronElementQueryFrm";
            this.TabText = "高炉样查询";
            this.Text = "高炉样查询";
            this.Load += new System.EventHandler(this.BFIronElementQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BFIronElementQueryFrm_FormClosing);
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
        private System.Data.DataColumn coldsIronElementL3DataTableSn;
        private System.Data.DataColumn coldsIronElementL3DataTableSb;
        private System.Data.DataColumn coldsIronElementL3DataTableAs;
        private System.Data.DataColumn coldsIronElementL3DataTablePb;
        private System.Data.DataColumn coldsIronElementL3DataTableNi;
        private System.Data.DataColumn coldsIronElementL3DataTableMo;
        private System.Data.DataColumn coldsIronElementL3DataTableCu;
        private System.Data.DataColumn coldsIronElementL3DataTableCr;
        private System.Data.DataColumn coldsIronElementL3DataTableB;
        private System.Data.DataColumn coldsIronElementL3DataTableV;
        private System.Data.DataColumn coldsIronElementL3DataTableAl;
        private System.Data.DataColumn coldsIronElementL3DataTableNb;
        private System.Data.DataColumn coldsIronElementL3DataTableZn;
        private System.Data.DataColumn coldsIronElementL3DataTableW;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zn;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATOR;
    }
}