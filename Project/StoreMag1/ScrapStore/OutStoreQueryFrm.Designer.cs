namespace StoreMag.ScrapStore
{
    partial class OutStoreQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsFGST = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsFGST = new System.Data.DataTable();
            this.coldsFGSTL3DataTableCode = new System.Data.DataColumn();
            this.coldsFGSTL3DataTableCode_Des = new System.Data.DataColumn();
            this.aMOUNTDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsST = new System.Windows.Forms.BindingSource(this.components);
            this.dsST = new AppSvrHMI.L3DataSet();
            this.schemadsST = new System.Data.DataTable();
            this.coldsSTL3DataTableSCRAP_SLOT_ID = new System.Data.DataColumn();
            this.coldsSTL3DataTableMATERIAL = new System.Data.DataColumn();
            this.coldsSTL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.coldsSTL3DataTableAMOUNT = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFG = new System.Windows.Forms.BindingSource(this.components);
            this.dsFG = new AppSvrHMI.L3DataSet();
            this.schemadsFG = new System.Data.DataTable();
            this.coldsFGL3DataTableSCRAP_SLOT_ID = new System.Data.DataColumn();
            this.coldsFGL3DataTableMATERIAL = new System.Data.DataColumn();
            this.coldsFGL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.coldsFGL3DataTableAMOUNT = new System.Data.DataColumn();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapSlotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapwtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pigironwtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStore = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableShift = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTeam = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablescrapwt = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablepigironwt = new System.Data.DataColumn();
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
            this.dtOutStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtOutStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dsScrapCode = new AppSvrHMI.L3DataSet();
            this.schemadsScrapCode = new System.Data.DataTable();
            this.coldsScrapCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsScrapArea = new AppSvrHMI.L3DataSet();
            this.schemadsScrapArea = new System.Data.DataTable();
            this.coldsScrapAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsFG1 = new AppSvrHMI.L3DataSet();
            this.dsST1 = new AppSvrHMI.L3DataSet();
            this.hmiRootPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFGST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsST)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST1)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.groupBox2);
            this.hmiRootPanel1.Controls.Add(this.groupBox1);
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(953, 532);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(668, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 134);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生铁";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2,
            this.mATERIALDataGridViewTextBoxColumn1,
            this.mATERIALCODEDataGridViewTextBoxColumn1,
            this.aMOUNTDataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.bsST;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(279, 114);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint);
            // 
            // sCRAPSLOTIDDataGridViewTextBoxColumn2
            // 
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2.DataPropertyName = "SCRAP_SLOT_ID";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2.HeaderText = "废钢斗号";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2.Name = "sCRAPSLOTIDDataGridViewTextBoxColumn2";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.sCRAPSLOTIDDataGridViewTextBoxColumn2.Width = 150;
            // 
            // mATERIALDataGridViewTextBoxColumn1
            // 
            this.mATERIALDataGridViewTextBoxColumn1.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn1.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn1.Name = "mATERIALDataGridViewTextBoxColumn1";
            this.mATERIALDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mATERIALDataGridViewTextBoxColumn1.Visible = false;
            // 
            // mATERIALCODEDataGridViewTextBoxColumn1
            // 
            this.mATERIALCODEDataGridViewTextBoxColumn1.DataPropertyName = "MATERIAL_CODE";
            this.mATERIALCODEDataGridViewTextBoxColumn1.DataSource = this.dsFGST;
            this.mATERIALCODEDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.mATERIALCODEDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mATERIALCODEDataGridViewTextBoxColumn1.HeaderText = "生铁名称";
            this.mATERIALCODEDataGridViewTextBoxColumn1.Name = "mATERIALCODEDataGridViewTextBoxColumn1";
            this.mATERIALCODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mATERIALCODEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALCODEDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATERIALCODEDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.mATERIALCODEDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dsFGST
            // 
            this.dsFGST.AutoLoad = true;
            this.dsFGST.AutoSubscribe = false;
            this.dsFGST.DataSetName = "L3DataSet";
            this.dsFGST.DeleteMethod = null;
            this.dsFGST.InsertMethod = null;
            this.dsFGST.L3DataAdapter = this.Adapter;
            this.dsFGST.LoadEvent = "Click";
            this.dsFGST.LoadTrigger = null;
            this.dsFGST.RefreshValve = 1000;
            this.dsFGST.SourceCommand = null;
            this.dsFGST.SourceCondition = "CODE_GROUP = \'PigIronGroupName\' or CODE_GROUP = \'ScrapGroupName\'";
            this.dsFGST.SourceMethod = "";
            this.dsFGST.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFGST.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFGST.SubscribeTarget = null;
            this.dsFGST.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFGST});
            this.dsFGST.UpdateEvent = "Click";
            this.dsFGST.UpdateMethod = null;
            this.dsFGST.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsFGST
            // 
            this.schemadsFGST.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFGSTL3DataTableCode,
            this.coldsFGSTL3DataTableCode_Des});
            this.schemadsFGST.TableName = "L3DataTable";
            // 
            // coldsFGSTL3DataTableCode
            // 
            this.coldsFGSTL3DataTableCode.Caption = "Code";
            this.coldsFGSTL3DataTableCode.ColumnName = "Code";
            this.coldsFGSTL3DataTableCode.Namespace = "";
            // 
            // coldsFGSTL3DataTableCode_Des
            // 
            this.coldsFGSTL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFGSTL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFGSTL3DataTableCode_Des.Namespace = "";
            // 
            // aMOUNTDataGridViewTextBoxColumn2
            // 
            this.aMOUNTDataGridViewTextBoxColumn2.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn2.HeaderText = "生铁重量";
            this.aMOUNTDataGridViewTextBoxColumn2.Name = "aMOUNTDataGridViewTextBoxColumn2";
            this.aMOUNTDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bsST
            // 
            this.bsST.DataMember = "L3DataTable";
            this.bsST.DataSource = this.dsST;
            // 
            // dsST
            // 
            this.dsST.AutoLoad = true;
            this.dsST.AutoSubscribe = true;
            this.dsST.DataSetName = "L3DataSet";
            this.dsST.DeleteMethod = null;
            this.dsST.InsertMethod = null;
            this.dsST.L3DataAdapter = this.Adapter;
            this.dsST.LoadEvent = "Click";
            this.dsST.LoadTrigger = null;
            this.dsST.RefreshValve = 1000;
            this.dsST.SourceCommand = null;
            this.dsST.SourceCondition = "";
            this.dsST.SourceMethod = "";
            this.dsST.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsST.SourceURI = "";
            this.dsST.SubscribeTarget = null;
            this.dsST.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsST});
            this.dsST.UpdateEvent = "Click";
            this.dsST.UpdateMethod = null;
            this.dsST.UpdateTrigger = null;
            // 
            // schemadsST
            // 
            this.schemadsST.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSTL3DataTableSCRAP_SLOT_ID,
            this.coldsSTL3DataTableMATERIAL,
            this.coldsSTL3DataTableMATERIAL_CODE,
            this.coldsSTL3DataTableAMOUNT});
            this.schemadsST.TableName = "L3DataTable";
            // 
            // coldsSTL3DataTableSCRAP_SLOT_ID
            // 
            this.coldsSTL3DataTableSCRAP_SLOT_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsSTL3DataTableSCRAP_SLOT_ID.ColumnName = "SCRAP_SLOT_ID";
            this.coldsSTL3DataTableSCRAP_SLOT_ID.Namespace = "";
            // 
            // coldsSTL3DataTableMATERIAL
            // 
            this.coldsSTL3DataTableMATERIAL.Caption = "MATERIAL";
            this.coldsSTL3DataTableMATERIAL.ColumnName = "MATERIAL";
            this.coldsSTL3DataTableMATERIAL.Namespace = "";
            // 
            // coldsSTL3DataTableMATERIAL_CODE
            // 
            this.coldsSTL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.coldsSTL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.coldsSTL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // coldsSTL3DataTableAMOUNT
            // 
            this.coldsSTL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsSTL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsSTL3DataTableAMOUNT.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 134);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "废钢";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1,
            this.mATERIALDataGridViewTextBoxColumn,
            this.mATERIALCODEDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bsFG;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(662, 114);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // sCRAPSLOTIDDataGridViewTextBoxColumn1
            // 
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.DataPropertyName = "SCRAP_SLOT_ID";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.HeaderText = "废钢斗号";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.Name = "sCRAPSLOTIDDataGridViewTextBoxColumn1";
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sCRAPSLOTIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // mATERIALDataGridViewTextBoxColumn
            // 
            this.mATERIALDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.HeaderText = "MATERIAL";
            this.mATERIALDataGridViewTextBoxColumn.Name = "mATERIALDataGridViewTextBoxColumn";
            this.mATERIALDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALCODEDataGridViewTextBoxColumn
            // 
            this.mATERIALCODEDataGridViewTextBoxColumn.DataPropertyName = "MATERIAL_CODE";
            this.mATERIALCODEDataGridViewTextBoxColumn.DataSource = this.dsFGST;
            this.mATERIALCODEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.mATERIALCODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mATERIALCODEDataGridViewTextBoxColumn.HeaderText = "废钢名称";
            this.mATERIALCODEDataGridViewTextBoxColumn.Name = "mATERIALCODEDataGridViewTextBoxColumn";
            this.mATERIALCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATERIALCODEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.mATERIALCODEDataGridViewTextBoxColumn.Width = 120;
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn1.HeaderText = "废钢重量";
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            this.aMOUNTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bsFG
            // 
            this.bsFG.DataMember = "L3DataTable";
            this.bsFG.DataSource = this.dsFG;
            // 
            // dsFG
            // 
            this.dsFG.AutoLoad = true;
            this.dsFG.AutoSubscribe = true;
            this.dsFG.DataSetName = "L3DataSet";
            this.dsFG.DeleteMethod = null;
            this.dsFG.InsertMethod = null;
            this.dsFG.L3DataAdapter = this.Adapter;
            this.dsFG.LoadEvent = "Click";
            this.dsFG.LoadTrigger = null;
            this.dsFG.RefreshValve = 1000;
            this.dsFG.SourceCommand = null;
            this.dsFG.SourceCondition = "";
            this.dsFG.SourceMethod = "";
            this.dsFG.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFG.SourceURI = "";
            this.dsFG.SubscribeTarget = null;
            this.dsFG.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFG});
            this.dsFG.UpdateEvent = "Click";
            this.dsFG.UpdateMethod = null;
            this.dsFG.UpdateTrigger = null;
            // 
            // schemadsFG
            // 
            this.schemadsFG.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFGL3DataTableSCRAP_SLOT_ID,
            this.coldsFGL3DataTableMATERIAL,
            this.coldsFGL3DataTableMATERIAL_CODE,
            this.coldsFGL3DataTableAMOUNT});
            this.schemadsFG.TableName = "L3DataTable";
            // 
            // coldsFGL3DataTableSCRAP_SLOT_ID
            // 
            this.coldsFGL3DataTableSCRAP_SLOT_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsFGL3DataTableSCRAP_SLOT_ID.ColumnName = "SCRAP_SLOT_ID";
            this.coldsFGL3DataTableSCRAP_SLOT_ID.Namespace = "";
            // 
            // coldsFGL3DataTableMATERIAL
            // 
            this.coldsFGL3DataTableMATERIAL.Caption = "MATERIAL";
            this.coldsFGL3DataTableMATERIAL.ColumnName = "MATERIAL";
            this.coldsFGL3DataTableMATERIAL.Namespace = "";
            // 
            // coldsFGL3DataTableMATERIAL_CODE
            // 
            this.coldsFGL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.coldsFGL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.coldsFGL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // coldsFGL3DataTableAMOUNT
            // 
            this.coldsFGL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsFGL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsFGL3DataTableAMOUNT.Namespace = "";
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDateDataGridViewTextBoxColumn,
            this.scrapSlotIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.scrapwtDataGridViewTextBoxColumn,
            this.pigironwtDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsOutStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInStore.Size = new System.Drawing.Size(953, 373);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvInStore_ColumnHeaderMouseClick);
            this.dvInStore.CurrentCellChanged += new System.EventHandler(this.dvInStore_CurrentCellChanged);
            this.dvInStore.Click += new System.EventHandler(this.dvInStore_Click);
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "出库时间";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scrapSlotIDDataGridViewTextBoxColumn
            // 
            this.scrapSlotIDDataGridViewTextBoxColumn.DataPropertyName = "Scrap_Slot_ID";
            this.scrapSlotIDDataGridViewTextBoxColumn.HeaderText = "废钢斗号";
            this.scrapSlotIDDataGridViewTextBoxColumn.Name = "scrapSlotIDDataGridViewTextBoxColumn";
            this.scrapSlotIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = "0";
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "出库量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scrapwtDataGridViewTextBoxColumn
            // 
            this.scrapwtDataGridViewTextBoxColumn.DataPropertyName = "scrapwt";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.scrapwtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.scrapwtDataGridViewTextBoxColumn.HeaderText = "废钢";
            this.scrapwtDataGridViewTextBoxColumn.Name = "scrapwtDataGridViewTextBoxColumn";
            this.scrapwtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pigironwtDataGridViewTextBoxColumn
            // 
            this.pigironwtDataGridViewTextBoxColumn.DataPropertyName = "pigironwt";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "0";
            this.pigironwtDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.pigironwtDataGridViewTextBoxColumn.HeaderText = "生铁";
            this.pigironwtDataGridViewTextBoxColumn.Name = "pigironwtDataGridViewTextBoxColumn";
            this.pigironwtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftDataGridViewTextBoxColumn.Width = 50;
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
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStore;
            // 
            // dsOutStore
            // 
            this.dsOutStore.AutoLoad = true;
            this.dsOutStore.AutoSubscribe = false;
            this.dsOutStore.DataSetName = "L3DataSet";
            this.dsOutStore.DeleteMethod = null;
            this.dsOutStore.InsertMethod = null;
            this.dsOutStore.L3DataAdapter = this.Adapter;
            this.dsOutStore.LoadEvent = "Click";
            this.dsOutStore.LoadTrigger = null;
            this.dsOutStore.RefreshValve = 1000;
            this.dsOutStore.SourceCommand = null;
            this.dsOutStore.SourceCondition = "";
            this.dsOutStore.SourceMethod = " ";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsOutStore.SourceURI = "";
            this.dsOutStore.SubscribeTarget = null;
            this.dsOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsOutStore.UpdateEvent = "Click";
            this.dsOutStore.UpdateMethod = null;
            this.dsOutStore.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableLogDate,
            this.coldsInStoreL3DataTableAmount,
            this.coldsInStoreL3DataTableOperator,
            this.coldsInStoreL3DataTableShift,
            this.coldsInStoreL3DataTableTeam,
            this.coldsOutStoreL3DataTableScrap_Slot_ID,
            this.coldsOutStoreL3DataTableHeatID,
            this.coldsOutStoreL3DataTablescrapwt,
            this.coldsOutStoreL3DataTablepigironwt});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableLogDate
            // 
            this.coldsInStoreL3DataTableLogDate.Caption = "LogDate";
            this.coldsInStoreL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsInStoreL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableLogDate.Namespace = "";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "Amount";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsInStoreL3DataTableOperator
            // 
            this.coldsInStoreL3DataTableOperator.Caption = "Operator";
            this.coldsInStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsInStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsInStoreL3DataTableShift
            // 
            this.coldsInStoreL3DataTableShift.Caption = "Shift";
            this.coldsInStoreL3DataTableShift.ColumnName = "Shift";
            this.coldsInStoreL3DataTableShift.Namespace = "";
            // 
            // coldsInStoreL3DataTableTeam
            // 
            this.coldsInStoreL3DataTableTeam.Caption = "Team";
            this.coldsInStoreL3DataTableTeam.ColumnName = "Team";
            this.coldsInStoreL3DataTableTeam.Namespace = "";
            // 
            // coldsOutStoreL3DataTableScrap_Slot_ID
            // 
            this.coldsOutStoreL3DataTableScrap_Slot_ID.Caption = "Scrap_Slot_ID";
            this.coldsOutStoreL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsOutStoreL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableHeatID
            // 
            this.coldsOutStoreL3DataTableHeatID.Caption = "HeatID";
            this.coldsOutStoreL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsOutStoreL3DataTableHeatID.Namespace = "";
            // 
            // coldsOutStoreL3DataTablescrapwt
            // 
            this.coldsOutStoreL3DataTablescrapwt.Caption = "scrapwt";
            this.coldsOutStoreL3DataTablescrapwt.ColumnName = "scrapwt";
            this.coldsOutStoreL3DataTablescrapwt.DataType = typeof(double);
            this.coldsOutStoreL3DataTablescrapwt.Namespace = "";
            // 
            // coldsOutStoreL3DataTablepigironwt
            // 
            this.coldsOutStoreL3DataTablepigironwt.Caption = "pigironwt";
            this.coldsOutStoreL3DataTablepigironwt.ColumnName = "pigironwt";
            this.coldsOutStoreL3DataTablepigironwt.DataType = typeof(double);
            this.coldsOutStoreL3DataTablepigironwt.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsOutStore;
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
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.txtHeatID,
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(953, 25);
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
            // dtOutStoreEndData
            // 
            this.dtOutStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.Name = "dtOutStoreEndData";
            this.dtOutStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreEndData.Text = "2009-01-04";
            this.dtOutStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            this.dtOutStoreEndData.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            this.toolStripLabel2.Visible = false;
            // 
            // dtOutStoreData
            // 
            this.dtOutStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.Name = "dtOutStoreData";
            this.dtOutStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreData.Text = "2008-11-16";
            this.dtOutStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "出库日期:";
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
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "炉号:";
            // 
            // dsScrapCode
            // 
            this.dsScrapCode.AutoLoad = true;
            this.dsScrapCode.AutoSubscribe = false;
            this.dsScrapCode.DataSetName = "L3DataSet";
            this.dsScrapCode.DeleteMethod = null;
            this.dsScrapCode.InsertMethod = null;
            this.dsScrapCode.L3DataAdapter = this.Adapter;
            this.dsScrapCode.LoadEvent = "Click";
            this.dsScrapCode.LoadTrigger = null;
            this.dsScrapCode.RefreshValve = 1000;
            this.dsScrapCode.SourceCommand = null;
            this.dsScrapCode.SourceCondition = "CODE_GROUP = \'SCRAP_CODE\'";
            this.dsScrapCode.SourceMethod = "";
            this.dsScrapCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapCode.SubscribeTarget = null;
            this.dsScrapCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapCode});
            this.dsScrapCode.UpdateEvent = "Click";
            this.dsScrapCode.UpdateMethod = null;
            this.dsScrapCode.UpdateTrigger = null;
            // 
            // schemadsScrapCode
            // 
            this.schemadsScrapCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapCodeL3DataTableCode,
            this.coldsScrapCodeL3DataTableCode_Des});
            this.schemadsScrapCode.TableName = "L3DataTable";
            // 
            // coldsScrapCodeL3DataTableCode
            // 
            this.coldsScrapCodeL3DataTableCode.Caption = "Code";
            this.coldsScrapCodeL3DataTableCode.ColumnName = "Code";
            this.coldsScrapCodeL3DataTableCode.Namespace = "";
            // 
            // coldsScrapCodeL3DataTableCode_Des
            // 
            this.coldsScrapCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.Namespace = "";
            // 
            // dsScrapArea
            // 
            this.dsScrapArea.AutoLoad = true;
            this.dsScrapArea.AutoSubscribe = false;
            this.dsScrapArea.DataSetName = "L3DataSet";
            this.dsScrapArea.DeleteMethod = null;
            this.dsScrapArea.InsertMethod = null;
            this.dsScrapArea.L3DataAdapter = this.Adapter;
            this.dsScrapArea.LoadEvent = "Click";
            this.dsScrapArea.LoadTrigger = null;
            this.dsScrapArea.RefreshValve = 1000;
            this.dsScrapArea.SourceCommand = null;
            this.dsScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\'";
            this.dsScrapArea.SourceMethod = "";
            this.dsScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapArea.SubscribeTarget = null;
            this.dsScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapArea});
            this.dsScrapArea.UpdateEvent = "Click";
            this.dsScrapArea.UpdateMethod = null;
            this.dsScrapArea.UpdateTrigger = null;
            // 
            // schemadsScrapArea
            // 
            this.schemadsScrapArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapAreaL3DataTableCode,
            this.coldsScrapAreaL3DataTableCode_Des});
            this.schemadsScrapArea.TableName = "L3DataTable";
            // 
            // coldsScrapAreaL3DataTableCode
            // 
            this.coldsScrapAreaL3DataTableCode.Caption = "Code";
            this.coldsScrapAreaL3DataTableCode.ColumnName = "Code";
            this.coldsScrapAreaL3DataTableCode.Namespace = "";
            // 
            // coldsScrapAreaL3DataTableCode_Des
            // 
            this.coldsScrapAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.Namespace = "";
            // 
            // dsFG1
            // 
            this.dsFG1.AutoLoad = true;
            this.dsFG1.AutoSubscribe = true;
            this.dsFG1.DataSetName = "L3DataSet";
            this.dsFG1.DeleteMethod = null;
            this.dsFG1.InsertMethod = null;
            this.dsFG1.L3DataAdapter = this.Adapter;
            this.dsFG1.LoadEvent = "Click";
            this.dsFG1.LoadTrigger = null;
            this.dsFG1.RefreshValve = 1000;
            this.dsFG1.SourceCommand = null;
            this.dsFG1.SourceCondition = "";
            this.dsFG1.SourceMethod = "";
            this.dsFG1.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFG1.SourceURI = "";
            this.dsFG1.SubscribeTarget = null;
            this.dsFG1.UpdateEvent = "Click";
            this.dsFG1.UpdateMethod = null;
            this.dsFG1.UpdateTrigger = null;
            // 
            // dsST1
            // 
            this.dsST1.AutoLoad = true;
            this.dsST1.AutoSubscribe = true;
            this.dsST1.DataSetName = "L3DataSet";
            this.dsST1.DeleteMethod = null;
            this.dsST1.InsertMethod = null;
            this.dsST1.L3DataAdapter = this.Adapter;
            this.dsST1.LoadEvent = "Click";
            this.dsST1.LoadTrigger = null;
            this.dsST1.RefreshValve = 1000;
            this.dsST1.SourceCommand = null;
            this.dsST1.SourceCondition = "";
            this.dsST1.SourceMethod = "";
            this.dsST1.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsST1.SourceURI = "";
            this.dsST1.SubscribeTarget = null;
            this.dsST1.UpdateEvent = "Click";
            this.dsST1.UpdateMethod = null;
            this.dsST1.UpdateTrigger = null;
            // 
            // OutStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 532);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "OutStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "废钢出库查询";
            this.Text = "出库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutStoreQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.OutStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFGST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsST)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsST1)).EndInit();
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
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsOutStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableLogDate;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Data.DataColumn coldsInStoreL3DataTableShift;
        private System.Data.DataColumn coldsInStoreL3DataTableTeam;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableScrap_Slot_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableHeatID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsScrapArea;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsScrapArea;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private AppSvrHMI.L3DataSet dsScrapCode;
        private System.Data.DataTable schemadsScrapCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataColumn coldsOutStoreL3DataTablescrapwt;
        private System.Data.DataColumn coldsOutStoreL3DataTablepigironwt;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AppSvrHMI.L3DataSet dsFG;
        private System.Data.DataTable schemadsFG;
        private System.Data.DataColumn coldsFGL3DataTableSCRAP_SLOT_ID;
        private System.Data.DataColumn coldsFGL3DataTableMATERIAL;
        private System.Data.DataColumn coldsFGL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn coldsFGL3DataTableAMOUNT;
        private AppSvrHMI.L3DataSet dsST;
        private System.Data.DataTable schemadsST;
        private System.Data.DataColumn coldsSTL3DataTableSCRAP_SLOT_ID;
        private System.Data.DataColumn coldsSTL3DataTableMATERIAL;
        private System.Data.DataColumn coldsSTL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn coldsSTL3DataTableAMOUNT;
        private System.Windows.Forms.BindingSource bsST;
        private System.Windows.Forms.BindingSource bsFG;
        private AppSvrHMI.L3DataSet dsFGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRAPSLOTIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn mATERIALCODEDataGridViewTextBoxColumn1;
        private System.Data.DataTable schemadsFGST;
        private System.Data.DataColumn coldsFGSTL3DataTableCode;
        private System.Data.DataColumn coldsFGSTL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRAPSLOTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn mATERIALCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn1;
        private AppSvrHMI.L3DataSet dsFG1;
        private AppSvrHMI.L3DataSet dsST1;
        private System.Windows.Forms.DataGridView dvInStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapSlotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapwtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pigironwtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
    }
}