namespace StoreMag.BloomStore
{
    partial class BloomOutStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomOutStoreFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.btnOutStore = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvOutStore = new System.Windows.Forms.DataGridView();
            this.dsStoreID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStoreID = new System.Data.DataTable();
            this.coldsStoreIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsDESTINATION = new AppSvrHMI.L3DataSet();
            this.schemadsDESTINATION = new System.Data.DataTable();
            this.coldsDESTINATIONL3DataTableCode = new System.Data.DataColumn();
            this.coldsDESTINATIONL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStore = new AppSvrHMI.L3DataSet();
            this.schemadsOutStore = new System.Data.DataTable();
            this.coldsOutStoreL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSTATUS = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableQASTATUS = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableQALEVEL = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableORDERCONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSALESCONTRACTID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCASTING_NO = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableLENGTH = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWIDTH = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableTHICKNESS = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUR_SECTION_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUR_SEQ_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCUR_BAY_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableDESTINATION = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePROCESS_TYPE = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePLAN_ORD_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePRODUCE_DATE = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableFINISH_FLAG = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableFINISHEDTIME = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableBLOOM_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCAL_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_COUNT1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_REASON1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_COUNT2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_REASON2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_COUNT3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWASTER_REASON3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_WEIGHT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_COUNT1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_REASON1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_COUNT2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_REASON2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_COUNT3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWRONG_REASON3 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableREASON = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableTarget = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.cmdOutStore = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTINGHEATCNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIDTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHICKNESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURSECTIONIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPILEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURLAYERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURSEQIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURBAYIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTSENDFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCESSTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINISHFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINISHEDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLOOMCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERWEIGHT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERREASON3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGWEIGHT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGREASON3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qALEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qASTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDESTINATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDESTINATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOutStore)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.btnOutStore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 43);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton9.Text = "退出";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // btnOutStore
            // 
            this.btnOutStore.Image = ((System.Drawing.Image)(resources.GetObject("btnOutStore.Image")));
            this.btnOutStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutStore.Name = "btnOutStore";
            this.btnOutStore.Size = new System.Drawing.Size(65, 40);
            this.btnOutStore.Text = "出库";
            this.btnOutStore.Click += new System.EventHandler(this.btnOutStore_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvOutStore);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(410, 213);
            this.hmiRootPanel1.TabIndex = 66;
            // 
            // dvOutStore
            // 
            this.dvOutStore.AllowUserToAddRows = false;
            this.dvOutStore.AutoGenerateColumns = false;
            this.dvOutStore.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvOutStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvOutStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.cASTINGNODataGridViewTextBoxColumn,
            this.cASTINGHEATCNTDataGridViewTextBoxColumn,
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.lENGTHDataGridViewTextBoxColumn,
            this.wIDTHDataGridViewTextBoxColumn,
            this.tHICKNESSDataGridViewTextBoxColumn,
            this.cURSECTIONIDDataGridViewTextBoxColumn,
            this.cURPILEIDDataGridViewTextBoxColumn,
            this.cURLAYERIDDataGridViewTextBoxColumn,
            this.cURSEQIDDataGridViewTextBoxColumn,
            this.cURBAYIDDataGridViewTextBoxColumn,
            this.dESTINATIONDataGridViewTextBoxColumn,
            this.hOTSENDFLAGDataGridViewTextBoxColumn,
            this.pROCESSTYPEDataGridViewTextBoxColumn,
            this.pLANORDIDDataGridViewTextBoxColumn,
            this.pRODUCEDATEDataGridViewTextBoxColumn,
            this.fINISHFLAGDataGridViewTextBoxColumn,
            this.fINISHEDTIMEDataGridViewTextBoxColumn,
            this.bLOOMCOUNTDataGridViewTextBoxColumn,
            this.cALWEIGHTDataGridViewTextBoxColumn,
            this.rIGHTCOUNTDataGridViewTextBoxColumn,
            this.rIGHTWEIGHTDataGridViewTextBoxColumn,
            this.wASTERCOUNTDataGridViewTextBoxColumn,
            this.wASTERWEIGHTDataGridViewTextBoxColumn,
            this.wASTERCOUNT1DataGridViewTextBoxColumn,
            this.wASTERWEIGHT1DataGridViewTextBoxColumn,
            this.wASTERREASON1DataGridViewTextBoxColumn,
            this.wASTERCOUNT2DataGridViewTextBoxColumn,
            this.wASTERWEIGHT2DataGridViewTextBoxColumn,
            this.wASTERREASON2DataGridViewTextBoxColumn,
            this.wASTERCOUNT3DataGridViewTextBoxColumn,
            this.wASTERWEIGHT3DataGridViewTextBoxColumn,
            this.wASTERREASON3DataGridViewTextBoxColumn,
            this.wRONGCOUNTDataGridViewTextBoxColumn,
            this.wRONGWEIGHTDataGridViewTextBoxColumn,
            this.wRONGCOUNT1DataGridViewTextBoxColumn,
            this.wRONGWEIGHT1DataGridViewTextBoxColumn,
            this.wRONGREASON1DataGridViewTextBoxColumn,
            this.wRONGCOUNT2DataGridViewTextBoxColumn,
            this.wRONGWEIGHT2DataGridViewTextBoxColumn,
            this.wRONGREASON2DataGridViewTextBoxColumn,
            this.wRONGCOUNT3DataGridViewTextBoxColumn,
            this.wRONGWEIGHT3DataGridViewTextBoxColumn,
            this.wRONGREASON3DataGridViewTextBoxColumn,
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn,
            this.rEASONDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.qALEVELDataGridViewTextBoxColumn,
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn,
            this.sALESCONTRACTIDDataGridViewTextBoxColumn,
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn,
            this.qASTATUSDataGridViewTextBoxColumn});
            this.dvOutStore.DataSource = this.bsOutStore;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvOutStore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvOutStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvOutStore.Location = new System.Drawing.Point(0, 0);
            this.dvOutStore.Margin = new System.Windows.Forms.Padding(0);
            this.dvOutStore.Name = "dvOutStore";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvOutStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvOutStore.RowHeadersVisible = false;
            this.dvOutStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvOutStore.RowTemplate.Height = 23;
            this.dvOutStore.Size = new System.Drawing.Size(410, 213);
            this.dvOutStore.TabIndex = 18;
            this.dvOutStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvOutStore_DataError);
            this.dvOutStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvOutStore_CellContentClick);
            // 
            // dsStoreID
            // 
            this.dsStoreID.AutoSubscribe = false;
            this.dsStoreID.DataSetName = "L3DataSet";
            this.dsStoreID.DeleteMethod = "";
            this.dsStoreID.InsertMethod = "";
            this.dsStoreID.L3DataAdapter = this.Adapter;
            this.dsStoreID.LoadEvent = "Click";
            this.dsStoreID.LoadTrigger = null;
            this.dsStoreID.RefreshValve = 1000;
            this.dsStoreID.SourceCommand = null;
            this.dsStoreID.SourceCondition = "CODE_GROUP = \'BloomArea\'";
            this.dsStoreID.SourceMethod = "";
            this.dsStoreID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreID.SubscribeTarget = null;
            this.dsStoreID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreID});
            this.dsStoreID.UpdateEvent = "Click";
            this.dsStoreID.UpdateMethod = "";
            this.dsStoreID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStoreID
            // 
            this.schemadsStoreID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreIDL3DataTableCode,
            this.coldsStoreIDL3DataTableCode_Des});
            this.schemadsStoreID.TableName = "L3DataTable";
            // 
            // coldsStoreIDL3DataTableCode
            // 
            this.coldsStoreIDL3DataTableCode.Caption = "Code";
            this.coldsStoreIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreIDL3DataTableCode_Des
            // 
            this.coldsStoreIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsDESTINATION
            // 
            this.dsDESTINATION.AutoSubscribe = false;
            this.dsDESTINATION.DataSetName = "L3DataSet";
            this.dsDESTINATION.DeleteMethod = null;
            this.dsDESTINATION.InsertMethod = null;
            this.dsDESTINATION.L3DataAdapter = this.Adapter;
            this.dsDESTINATION.LoadEvent = "Click";
            this.dsDESTINATION.LoadTrigger = null;
            this.dsDESTINATION.RefreshValve = 1000;
            this.dsDESTINATION.SourceCommand = null;
            this.dsDESTINATION.SourceCondition = "CODE_GROUP = \'DESTINATION\' order by Code";
            this.dsDESTINATION.SourceMethod = "";
            this.dsDESTINATION.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDESTINATION.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDESTINATION.SubscribeTarget = null;
            this.dsDESTINATION.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDESTINATION});
            this.dsDESTINATION.UpdateEvent = "Click";
            this.dsDESTINATION.UpdateMethod = null;
            this.dsDESTINATION.UpdateTrigger = null;
            // 
            // schemadsDESTINATION
            // 
            this.schemadsDESTINATION.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDESTINATIONL3DataTableCode,
            this.coldsDESTINATIONL3DataTableCode_Des});
            this.schemadsDESTINATION.TableName = "L3DataTable";
            // 
            // coldsDESTINATIONL3DataTableCode
            // 
            this.coldsDESTINATIONL3DataTableCode.Caption = "Code";
            this.coldsDESTINATIONL3DataTableCode.ColumnName = "Code";
            this.coldsDESTINATIONL3DataTableCode.Namespace = "";
            // 
            // coldsDESTINATIONL3DataTableCode_Des
            // 
            this.coldsDESTINATIONL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDESTINATIONL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDESTINATIONL3DataTableCode_Des.Namespace = "";
            // 
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStore;
            // 
            // dsOutStore
            // 
            this.dsOutStore.AutoSubscribe = false;
            this.dsOutStore.DataSetName = "L3DataSet";
            this.dsOutStore.DeleteMethod = "";
            this.dsOutStore.InsertMethod = "";
            this.dsOutStore.L3DataAdapter = this.Adapter;
            this.dsOutStore.LoadEvent = "Click";
            this.dsOutStore.LoadTrigger = null;
            this.dsOutStore.RefreshValve = 1000;
            this.dsOutStore.SourceCommand = null;
            this.dsOutStore.SourceCondition = "";
            this.dsOutStore.SourceMethod = "";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsOutStore.SourceURI = "";
            this.dsOutStore.SubscribeTarget = null;
            this.dsOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOutStore});
            this.dsOutStore.UpdateEvent = "Click";
            this.dsOutStore.UpdateMethod = "";
            this.dsOutStore.UpdateTrigger = null;
            // 
            // schemadsOutStore
            // 
            this.schemadsOutStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOutStoreL3DataTableMATERIALID,
            this.coldsOutStoreL3DataTableSTATUS,
            this.coldsOutStoreL3DataTablePOSITION,
            this.coldsOutStoreL3DataTableQASTATUS,
            this.coldsOutStoreL3DataTableQALEVEL,
            this.coldsOutStoreL3DataTableORDERCONTRACTID,
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID,
            this.coldsOutStoreL3DataTableSALESCONTRACTID,
            this.coldsOutStoreL3DataTableCASTERID,
            this.coldsOutStoreL3DataTableCASTING_NO,
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT,
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX,
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX,
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX,
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX,
            this.coldsOutStoreL3DataTableLENGTH,
            this.coldsOutStoreL3DataTableWIDTH,
            this.coldsOutStoreL3DataTableTHICKNESS,
            this.coldsOutStoreL3DataTableCUR_SECTION_ID,
            this.coldsOutStoreL3DataTableCUR_PILE_ID,
            this.coldsOutStoreL3DataTableCUR_LAYER_ID,
            this.coldsOutStoreL3DataTableCUR_SEQ_ID,
            this.coldsOutStoreL3DataTableCUR_BAY_ID,
            this.coldsOutStoreL3DataTableDESTINATION,
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG,
            this.coldsOutStoreL3DataTablePROCESS_TYPE,
            this.coldsOutStoreL3DataTablePLAN_ORD_ID,
            this.coldsOutStoreL3DataTablePRODUCE_DATE,
            this.coldsOutStoreL3DataTableFINISH_FLAG,
            this.coldsOutStoreL3DataTableFINISHEDTIME,
            this.coldsOutStoreL3DataTableBLOOM_COUNT,
            this.coldsOutStoreL3DataTableCAL_WEIGHT,
            this.coldsOutStoreL3DataTableRIGHT_COUNT,
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT,
            this.coldsOutStoreL3DataTableWASTER_COUNT,
            this.coldsOutStoreL3DataTableWASTER_WEIGHT,
            this.coldsOutStoreL3DataTableWASTER_COUNT1,
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1,
            this.coldsOutStoreL3DataTableWASTER_REASON1,
            this.coldsOutStoreL3DataTableWASTER_COUNT2,
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2,
            this.coldsOutStoreL3DataTableWASTER_REASON2,
            this.coldsOutStoreL3DataTableWASTER_COUNT3,
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3,
            this.coldsOutStoreL3DataTableWASTER_REASON3,
            this.coldsOutStoreL3DataTableWRONG_COUNT,
            this.coldsOutStoreL3DataTableWRONG_WEIGHT,
            this.coldsOutStoreL3DataTableWRONG_COUNT1,
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1,
            this.coldsOutStoreL3DataTableWRONG_REASON1,
            this.coldsOutStoreL3DataTableWRONG_COUNT2,
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2,
            this.coldsOutStoreL3DataTableWRONG_REASON2,
            this.coldsOutStoreL3DataTableWRONG_COUNT3,
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3,
            this.coldsOutStoreL3DataTableWRONG_REASON3,
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES,
            this.coldsOutStoreL3DataTableREASON,
            this.coldsOutStoreL3DataTableTarget,
            this.coldsOutStoreL3DataTableStoreAreaID});
            this.schemadsOutStore.TableName = "L3DataTable";
            // 
            // coldsOutStoreL3DataTableMATERIALID
            // 
            this.coldsOutStoreL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsOutStoreL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsOutStoreL3DataTableMATERIALID.DefaultValue = "";
            this.coldsOutStoreL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableSTATUS
            // 
            this.coldsOutStoreL3DataTableSTATUS.Caption = "STATUS";
            this.coldsOutStoreL3DataTableSTATUS.ColumnName = "STATUS";
            this.coldsOutStoreL3DataTableSTATUS.DataType = typeof(int);
            this.coldsOutStoreL3DataTableSTATUS.DefaultValue = 0;
            this.coldsOutStoreL3DataTableSTATUS.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePOSITION
            // 
            this.coldsOutStoreL3DataTablePOSITION.Caption = "POSITION";
            this.coldsOutStoreL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsOutStoreL3DataTablePOSITION.DefaultValue = "";
            this.coldsOutStoreL3DataTablePOSITION.Namespace = "";
            // 
            // coldsOutStoreL3DataTableQASTATUS
            // 
            this.coldsOutStoreL3DataTableQASTATUS.Caption = "QASTATUS";
            this.coldsOutStoreL3DataTableQASTATUS.ColumnName = "QASTATUS";
            this.coldsOutStoreL3DataTableQASTATUS.DataType = typeof(int);
            this.coldsOutStoreL3DataTableQASTATUS.DefaultValue = 0;
            this.coldsOutStoreL3DataTableQASTATUS.Namespace = "";
            // 
            // coldsOutStoreL3DataTableQALEVEL
            // 
            this.coldsOutStoreL3DataTableQALEVEL.Caption = "QALEVEL";
            this.coldsOutStoreL3DataTableQALEVEL.ColumnName = "QALEVEL";
            this.coldsOutStoreL3DataTableQALEVEL.DataType = typeof(int);
            this.coldsOutStoreL3DataTableQALEVEL.DefaultValue = 0;
            this.coldsOutStoreL3DataTableQALEVEL.Namespace = "";
            // 
            // coldsOutStoreL3DataTableORDERCONTRACTID
            // 
            this.coldsOutStoreL3DataTableORDERCONTRACTID.Caption = "ORDERCONTRACTID";
            this.coldsOutStoreL3DataTableORDERCONTRACTID.ColumnName = "ORDERCONTRACTID";
            this.coldsOutStoreL3DataTableORDERCONTRACTID.DefaultValue = "";
            this.coldsOutStoreL3DataTableORDERCONTRACTID.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePRODUCECONTRACTID
            // 
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID.Caption = "PRODUCECONTRACTID";
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID.ColumnName = "PRODUCECONTRACTID";
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID.DefaultValue = "";
            this.coldsOutStoreL3DataTablePRODUCECONTRACTID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableSALESCONTRACTID
            // 
            this.coldsOutStoreL3DataTableSALESCONTRACTID.Caption = "SALESCONTRACTID";
            this.coldsOutStoreL3DataTableSALESCONTRACTID.ColumnName = "SALESCONTRACTID";
            this.coldsOutStoreL3DataTableSALESCONTRACTID.DefaultValue = "";
            this.coldsOutStoreL3DataTableSALESCONTRACTID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCASTERID
            // 
            this.coldsOutStoreL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsOutStoreL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsOutStoreL3DataTableCASTERID.DefaultValue = "";
            this.coldsOutStoreL3DataTableCASTERID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCASTING_NO
            // 
            this.coldsOutStoreL3DataTableCASTING_NO.Caption = "CASTING_NO";
            this.coldsOutStoreL3DataTableCASTING_NO.ColumnName = "CASTING_NO";
            this.coldsOutStoreL3DataTableCASTING_NO.DefaultValue = "";
            this.coldsOutStoreL3DataTableCASTING_NO.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCASTING_HEAT_CNT
            // 
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT.Caption = "CASTING_HEAT_CNT";
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT.ColumnName = "CASTING_HEAT_CNT";
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT.DataType = typeof(int);
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableCASTING_HEAT_CNT.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePRE_STEELGRADEINDEX
            // 
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX.Caption = "PRE_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX.ColumnName = "PRE_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreL3DataTablePRE_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreL3DataTableSTEELGRADEINDEX
            // 
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUT_STEELGRADEINDEX
            // 
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX.Caption = "CUT_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX.ColumnName = "CUT_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreL3DataTableCUT_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX
            // 
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX.Caption = "FINAL_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX.ColumnName = "FINAL_STEELGRADEINDEX";
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX.DefaultValue = "";
            this.coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX.Namespace = "";
            // 
            // coldsOutStoreL3DataTableLENGTH
            // 
            this.coldsOutStoreL3DataTableLENGTH.Caption = "LENGTH";
            this.coldsOutStoreL3DataTableLENGTH.ColumnName = "LENGTH";
            this.coldsOutStoreL3DataTableLENGTH.DataType = typeof(int);
            this.coldsOutStoreL3DataTableLENGTH.DefaultValue = 0;
            this.coldsOutStoreL3DataTableLENGTH.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWIDTH
            // 
            this.coldsOutStoreL3DataTableWIDTH.Caption = "WIDTH";
            this.coldsOutStoreL3DataTableWIDTH.ColumnName = "WIDTH";
            this.coldsOutStoreL3DataTableWIDTH.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWIDTH.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWIDTH.Namespace = "";
            // 
            // coldsOutStoreL3DataTableTHICKNESS
            // 
            this.coldsOutStoreL3DataTableTHICKNESS.Caption = "THICKNESS";
            this.coldsOutStoreL3DataTableTHICKNESS.ColumnName = "THICKNESS";
            this.coldsOutStoreL3DataTableTHICKNESS.DataType = typeof(int);
            this.coldsOutStoreL3DataTableTHICKNESS.DefaultValue = 0;
            this.coldsOutStoreL3DataTableTHICKNESS.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUR_SECTION_ID
            // 
            this.coldsOutStoreL3DataTableCUR_SECTION_ID.Caption = "CUR_SECTION_ID";
            this.coldsOutStoreL3DataTableCUR_SECTION_ID.ColumnName = "CUR_SECTION_ID";
            this.coldsOutStoreL3DataTableCUR_SECTION_ID.DefaultValue = "";
            this.coldsOutStoreL3DataTableCUR_SECTION_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUR_PILE_ID
            // 
            this.coldsOutStoreL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsOutStoreL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsOutStoreL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsOutStoreL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUR_LAYER_ID
            // 
            this.coldsOutStoreL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsOutStoreL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsOutStoreL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUR_SEQ_ID
            // 
            this.coldsOutStoreL3DataTableCUR_SEQ_ID.Caption = "CUR_SEQ_ID";
            this.coldsOutStoreL3DataTableCUR_SEQ_ID.ColumnName = "CUR_SEQ_ID";
            this.coldsOutStoreL3DataTableCUR_SEQ_ID.DataType = typeof(int);
            this.coldsOutStoreL3DataTableCUR_SEQ_ID.DefaultValue = 0;
            this.coldsOutStoreL3DataTableCUR_SEQ_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCUR_BAY_ID
            // 
            this.coldsOutStoreL3DataTableCUR_BAY_ID.Caption = "CUR_BAY_ID";
            this.coldsOutStoreL3DataTableCUR_BAY_ID.ColumnName = "CUR_BAY_ID";
            this.coldsOutStoreL3DataTableCUR_BAY_ID.DefaultValue = "";
            this.coldsOutStoreL3DataTableCUR_BAY_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableDESTINATION
            // 
            this.coldsOutStoreL3DataTableDESTINATION.Caption = "DESTINATION";
            this.coldsOutStoreL3DataTableDESTINATION.ColumnName = "DESTINATION";
            this.coldsOutStoreL3DataTableDESTINATION.DefaultValue = "";
            this.coldsOutStoreL3DataTableDESTINATION.Namespace = "";
            // 
            // coldsOutStoreL3DataTableHOT_SEND_FLAG
            // 
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG.Caption = "HOT_SEND_FLAG";
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG.ColumnName = "HOT_SEND_FLAG";
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG.DataType = typeof(int);
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG.DefaultValue = 0;
            this.coldsOutStoreL3DataTableHOT_SEND_FLAG.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePROCESS_TYPE
            // 
            this.coldsOutStoreL3DataTablePROCESS_TYPE.Caption = "PROCESS_TYPE";
            this.coldsOutStoreL3DataTablePROCESS_TYPE.ColumnName = "PROCESS_TYPE";
            this.coldsOutStoreL3DataTablePROCESS_TYPE.DataType = typeof(int);
            this.coldsOutStoreL3DataTablePROCESS_TYPE.DefaultValue = 0;
            this.coldsOutStoreL3DataTablePROCESS_TYPE.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePLAN_ORD_ID
            // 
            this.coldsOutStoreL3DataTablePLAN_ORD_ID.Caption = "PLAN_ORD_ID";
            this.coldsOutStoreL3DataTablePLAN_ORD_ID.ColumnName = "PLAN_ORD_ID";
            this.coldsOutStoreL3DataTablePLAN_ORD_ID.DefaultValue = "";
            this.coldsOutStoreL3DataTablePLAN_ORD_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePRODUCE_DATE
            // 
            this.coldsOutStoreL3DataTablePRODUCE_DATE.Caption = "PRODUCE_DATE";
            this.coldsOutStoreL3DataTablePRODUCE_DATE.ColumnName = "PRODUCE_DATE";
            this.coldsOutStoreL3DataTablePRODUCE_DATE.DataType = typeof(System.DateTime);
            this.coldsOutStoreL3DataTablePRODUCE_DATE.Namespace = "";
            // 
            // coldsOutStoreL3DataTableFINISH_FLAG
            // 
            this.coldsOutStoreL3DataTableFINISH_FLAG.Caption = "FINISH_FLAG";
            this.coldsOutStoreL3DataTableFINISH_FLAG.ColumnName = "FINISH_FLAG";
            this.coldsOutStoreL3DataTableFINISH_FLAG.DataType = typeof(int);
            this.coldsOutStoreL3DataTableFINISH_FLAG.DefaultValue = 0;
            this.coldsOutStoreL3DataTableFINISH_FLAG.Namespace = "";
            // 
            // coldsOutStoreL3DataTableFINISHEDTIME
            // 
            this.coldsOutStoreL3DataTableFINISHEDTIME.Caption = "FINISHEDTIME";
            this.coldsOutStoreL3DataTableFINISHEDTIME.ColumnName = "FINISHEDTIME";
            this.coldsOutStoreL3DataTableFINISHEDTIME.DataType = typeof(System.DateTime);
            this.coldsOutStoreL3DataTableFINISHEDTIME.Namespace = "";
            // 
            // coldsOutStoreL3DataTableBLOOM_COUNT
            // 
            this.coldsOutStoreL3DataTableBLOOM_COUNT.Caption = "BLOOM_COUNT";
            this.coldsOutStoreL3DataTableBLOOM_COUNT.ColumnName = "BLOOM_COUNT";
            this.coldsOutStoreL3DataTableBLOOM_COUNT.DataType = typeof(int);
            this.coldsOutStoreL3DataTableBLOOM_COUNT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableBLOOM_COUNT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCAL_WEIGHT
            // 
            this.coldsOutStoreL3DataTableCAL_WEIGHT.Caption = "CAL_WEIGHT";
            this.coldsOutStoreL3DataTableCAL_WEIGHT.ColumnName = "CAL_WEIGHT";
            this.coldsOutStoreL3DataTableCAL_WEIGHT.DataType = typeof(double);
            this.coldsOutStoreL3DataTableCAL_WEIGHT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableCAL_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableRIGHT_COUNT
            // 
            this.coldsOutStoreL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsOutStoreL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsOutStoreL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsOutStoreL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableRIGHT_WEIGHT
            // 
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT.Caption = "RIGHT_WEIGHT";
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT.ColumnName = "RIGHT_WEIGHT";
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT.DataType = typeof(double);
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableRIGHT_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_COUNT
            // 
            this.coldsOutStoreL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsOutStoreL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsOutStoreL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_WEIGHT
            // 
            this.coldsOutStoreL3DataTableWASTER_WEIGHT.Caption = "WASTER_WEIGHT";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT.ColumnName = "WASTER_WEIGHT";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWASTER_WEIGHT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWASTER_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_COUNT1
            // 
            this.coldsOutStoreL3DataTableWASTER_COUNT1.Caption = "WASTER_COUNT1";
            this.coldsOutStoreL3DataTableWASTER_COUNT1.ColumnName = "WASTER_COUNT1";
            this.coldsOutStoreL3DataTableWASTER_COUNT1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_WEIGHT1
            // 
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1.Caption = "WASTER_WEIGHT1";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1.ColumnName = "WASTER_WEIGHT1";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWASTER_WEIGHT1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_REASON1
            // 
            this.coldsOutStoreL3DataTableWASTER_REASON1.Caption = "WASTER_REASON1";
            this.coldsOutStoreL3DataTableWASTER_REASON1.ColumnName = "WASTER_REASON1";
            this.coldsOutStoreL3DataTableWASTER_REASON1.DefaultValue = "";
            this.coldsOutStoreL3DataTableWASTER_REASON1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_COUNT2
            // 
            this.coldsOutStoreL3DataTableWASTER_COUNT2.Caption = "WASTER_COUNT2";
            this.coldsOutStoreL3DataTableWASTER_COUNT2.ColumnName = "WASTER_COUNT2";
            this.coldsOutStoreL3DataTableWASTER_COUNT2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_WEIGHT2
            // 
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2.Caption = "WASTER_WEIGHT2";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2.ColumnName = "WASTER_WEIGHT2";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWASTER_WEIGHT2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_REASON2
            // 
            this.coldsOutStoreL3DataTableWASTER_REASON2.Caption = "WASTER_REASON2";
            this.coldsOutStoreL3DataTableWASTER_REASON2.ColumnName = "WASTER_REASON2";
            this.coldsOutStoreL3DataTableWASTER_REASON2.DefaultValue = "";
            this.coldsOutStoreL3DataTableWASTER_REASON2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_COUNT3
            // 
            this.coldsOutStoreL3DataTableWASTER_COUNT3.Caption = "WASTER_COUNT3";
            this.coldsOutStoreL3DataTableWASTER_COUNT3.ColumnName = "WASTER_COUNT3";
            this.coldsOutStoreL3DataTableWASTER_COUNT3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_WEIGHT3
            // 
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3.Caption = "WASTER_WEIGHT3";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3.ColumnName = "WASTER_WEIGHT3";
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWASTER_WEIGHT3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWASTER_REASON3
            // 
            this.coldsOutStoreL3DataTableWASTER_REASON3.Caption = "WASTER_REASON3";
            this.coldsOutStoreL3DataTableWASTER_REASON3.ColumnName = "WASTER_REASON3";
            this.coldsOutStoreL3DataTableWASTER_REASON3.DefaultValue = "";
            this.coldsOutStoreL3DataTableWASTER_REASON3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_COUNT
            // 
            this.coldsOutStoreL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsOutStoreL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsOutStoreL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_WEIGHT
            // 
            this.coldsOutStoreL3DataTableWRONG_WEIGHT.Caption = "WRONG_WEIGHT";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT.ColumnName = "WRONG_WEIGHT";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWRONG_WEIGHT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_WEIGHT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_COUNT1
            // 
            this.coldsOutStoreL3DataTableWRONG_COUNT1.Caption = "WRONG_COUNT1";
            this.coldsOutStoreL3DataTableWRONG_COUNT1.ColumnName = "WRONG_COUNT1";
            this.coldsOutStoreL3DataTableWRONG_COUNT1.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWRONG_COUNT1.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_COUNT1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_WEIGHT1
            // 
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1.Caption = "WRONG_WEIGHT1";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1.ColumnName = "WRONG_WEIGHT1";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_WEIGHT1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_REASON1
            // 
            this.coldsOutStoreL3DataTableWRONG_REASON1.Caption = "WRONG_REASON1";
            this.coldsOutStoreL3DataTableWRONG_REASON1.ColumnName = "WRONG_REASON1";
            this.coldsOutStoreL3DataTableWRONG_REASON1.DefaultValue = "";
            this.coldsOutStoreL3DataTableWRONG_REASON1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_COUNT2
            // 
            this.coldsOutStoreL3DataTableWRONG_COUNT2.Caption = "WRONG_COUNT2";
            this.coldsOutStoreL3DataTableWRONG_COUNT2.ColumnName = "WRONG_COUNT2";
            this.coldsOutStoreL3DataTableWRONG_COUNT2.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWRONG_COUNT2.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_COUNT2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_WEIGHT2
            // 
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2.Caption = "WRONG_WEIGHT2";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2.ColumnName = "WRONG_WEIGHT2";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_WEIGHT2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_REASON2
            // 
            this.coldsOutStoreL3DataTableWRONG_REASON2.Caption = "WRONG_REASON2";
            this.coldsOutStoreL3DataTableWRONG_REASON2.ColumnName = "WRONG_REASON2";
            this.coldsOutStoreL3DataTableWRONG_REASON2.DefaultValue = "";
            this.coldsOutStoreL3DataTableWRONG_REASON2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_COUNT3
            // 
            this.coldsOutStoreL3DataTableWRONG_COUNT3.Caption = "WRONG_COUNT3";
            this.coldsOutStoreL3DataTableWRONG_COUNT3.ColumnName = "WRONG_COUNT3";
            this.coldsOutStoreL3DataTableWRONG_COUNT3.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWRONG_COUNT3.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_COUNT3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_WEIGHT3
            // 
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3.Caption = "WRONG_WEIGHT3";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3.ColumnName = "WRONG_WEIGHT3";
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3.DefaultValue = 0;
            this.coldsOutStoreL3DataTableWRONG_WEIGHT3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWRONG_REASON3
            // 
            this.coldsOutStoreL3DataTableWRONG_REASON3.Caption = "WRONG_REASON3";
            this.coldsOutStoreL3DataTableWRONG_REASON3.ColumnName = "WRONG_REASON3";
            this.coldsOutStoreL3DataTableWRONG_REASON3.DefaultValue = "";
            this.coldsOutStoreL3DataTableWRONG_REASON3.Namespace = "";
            // 
            // coldsOutStoreL3DataTableSUFACEDEFACTDES
            // 
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES.Caption = "SUFACEDEFACTDES";
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES.ColumnName = "SUFACEDEFACTDES";
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES.DefaultValue = "";
            this.coldsOutStoreL3DataTableSUFACEDEFACTDES.Namespace = "";
            // 
            // coldsOutStoreL3DataTableREASON
            // 
            this.coldsOutStoreL3DataTableREASON.Caption = "REASON";
            this.coldsOutStoreL3DataTableREASON.ColumnName = "REASON";
            this.coldsOutStoreL3DataTableREASON.DefaultValue = "";
            this.coldsOutStoreL3DataTableREASON.Namespace = "";
            // 
            // coldsOutStoreL3DataTableTarget
            // 
            this.coldsOutStoreL3DataTableTarget.Caption = "Target";
            this.coldsOutStoreL3DataTableTarget.ColumnName = "Target";
            this.coldsOutStoreL3DataTableTarget.Namespace = "";
            // 
            // coldsOutStoreL3DataTableStoreAreaID
            // 
            this.coldsOutStoreL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsOutStoreL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsOutStoreL3DataTableStoreAreaID.Namespace = "";
            // 
            // cmdOutStore
            // 
            this.cmdOutStore.Adapter = this.Adapter;
            this.cmdOutStore.MergeReturnTarget = false;
            this.cmdOutStore.Method = "AcceptBloomOutStoreInfor";
            this.cmdOutStore.Object = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.cmdOutStore.Parameters.Add(this.l3CommandParameter1);
            this.cmdOutStore.ReturnTarget = null;
            this.cmdOutStore.ReturnTargetProperty = null;
            this.cmdOutStore.Trigger = null;
            this.cmdOutStore.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsOutStore;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = " 炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsStoreID;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "位置";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.DataSource = this.dsDESTINATION;
            this.targetDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.targetDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.targetDataGridViewTextBoxColumn.HeaderText = "出库去向";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.targetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.targetDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            this.cASTERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTINGNODataGridViewTextBoxColumn
            // 
            this.cASTINGNODataGridViewTextBoxColumn.DataPropertyName = "CASTING_NO";
            this.cASTINGNODataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.cASTINGNODataGridViewTextBoxColumn.Name = "cASTINGNODataGridViewTextBoxColumn";
            this.cASTINGNODataGridViewTextBoxColumn.Visible = false;
            // 
            // cASTINGHEATCNTDataGridViewTextBoxColumn
            // 
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.DataPropertyName = "CASTING_HEAT_CNT";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Name = "cASTINGHEATCNTDataGridViewTextBoxColumn";
            this.cASTINGHEATCNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRESTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "PRE_STEELGRADEINDEX";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "pRESTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.pRESTEELGRADEINDEXDataGridViewTextBoxColumn.Visible = false;
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // cUTSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "CUT_STEELGRADEINDEX";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "cUTSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.cUTSTEELGRADEINDEXDataGridViewTextBoxColumn.Visible = false;
            // 
            // fINALSTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "FINAL_STEELGRADEINDEX";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "fINALSTEELGRADEINDEXDataGridViewTextBoxColumn";
            this.fINALSTEELGRADEINDEXDataGridViewTextBoxColumn.Visible = false;
            // 
            // lENGTHDataGridViewTextBoxColumn
            // 
            this.lENGTHDataGridViewTextBoxColumn.DataPropertyName = "LENGTH";
            this.lENGTHDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lENGTHDataGridViewTextBoxColumn.Name = "lENGTHDataGridViewTextBoxColumn";
            this.lENGTHDataGridViewTextBoxColumn.Visible = false;
            // 
            // wIDTHDataGridViewTextBoxColumn
            // 
            this.wIDTHDataGridViewTextBoxColumn.DataPropertyName = "WIDTH";
            this.wIDTHDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.wIDTHDataGridViewTextBoxColumn.Name = "wIDTHDataGridViewTextBoxColumn";
            this.wIDTHDataGridViewTextBoxColumn.Visible = false;
            // 
            // tHICKNESSDataGridViewTextBoxColumn
            // 
            this.tHICKNESSDataGridViewTextBoxColumn.DataPropertyName = "THICKNESS";
            this.tHICKNESSDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.tHICKNESSDataGridViewTextBoxColumn.Name = "tHICKNESSDataGridViewTextBoxColumn";
            this.tHICKNESSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURSECTIONIDDataGridViewTextBoxColumn
            // 
            this.cURSECTIONIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SECTION_ID";
            this.cURSECTIONIDDataGridViewTextBoxColumn.HeaderText = "当前区";
            this.cURSECTIONIDDataGridViewTextBoxColumn.Name = "cURSECTIONIDDataGridViewTextBoxColumn";
            this.cURSECTIONIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURPILEIDDataGridViewTextBoxColumn
            // 
            this.cURPILEIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_PILE_ID";
            this.cURPILEIDDataGridViewTextBoxColumn.HeaderText = "当前垛";
            this.cURPILEIDDataGridViewTextBoxColumn.Name = "cURPILEIDDataGridViewTextBoxColumn";
            this.cURPILEIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURLAYERIDDataGridViewTextBoxColumn
            // 
            this.cURLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_LAYER_ID";
            this.cURLAYERIDDataGridViewTextBoxColumn.HeaderText = "当前层";
            this.cURLAYERIDDataGridViewTextBoxColumn.Name = "cURLAYERIDDataGridViewTextBoxColumn";
            this.cURLAYERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURSEQIDDataGridViewTextBoxColumn
            // 
            this.cURSEQIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_SEQ_ID";
            this.cURSEQIDDataGridViewTextBoxColumn.HeaderText = "当前顺序";
            this.cURSEQIDDataGridViewTextBoxColumn.Name = "cURSEQIDDataGridViewTextBoxColumn";
            this.cURSEQIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cURBAYIDDataGridViewTextBoxColumn
            // 
            this.cURBAYIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_BAY_ID";
            this.cURBAYIDDataGridViewTextBoxColumn.HeaderText = "当前跨";
            this.cURBAYIDDataGridViewTextBoxColumn.Name = "cURBAYIDDataGridViewTextBoxColumn";
            this.cURBAYIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESTINATIONDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.HeaderText = "去向";
            this.dESTINATIONDataGridViewTextBoxColumn.Name = "dESTINATIONDataGridViewTextBoxColumn";
            this.dESTINATIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // hOTSENDFLAGDataGridViewTextBoxColumn
            // 
            this.hOTSENDFLAGDataGridViewTextBoxColumn.DataPropertyName = "HOT_SEND_FLAG";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Name = "hOTSENDFLAGDataGridViewTextBoxColumn";
            this.hOTSENDFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROCESSTYPEDataGridViewTextBoxColumn
            // 
            this.pROCESSTYPEDataGridViewTextBoxColumn.DataPropertyName = "PROCESS_TYPE";
            this.pROCESSTYPEDataGridViewTextBoxColumn.HeaderText = "处置方式";
            this.pROCESSTYPEDataGridViewTextBoxColumn.Name = "pROCESSTYPEDataGridViewTextBoxColumn";
            this.pROCESSTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pLANORDIDDataGridViewTextBoxColumn
            // 
            this.pLANORDIDDataGridViewTextBoxColumn.DataPropertyName = "PLAN_ORD_ID";
            this.pLANORDIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.pLANORDIDDataGridViewTextBoxColumn.Name = "pLANORDIDDataGridViewTextBoxColumn";
            this.pLANORDIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUCEDATEDataGridViewTextBoxColumn
            // 
            this.pRODUCEDATEDataGridViewTextBoxColumn.DataPropertyName = "PRODUCE_DATE";
            this.pRODUCEDATEDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.pRODUCEDATEDataGridViewTextBoxColumn.Name = "pRODUCEDATEDataGridViewTextBoxColumn";
            this.pRODUCEDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // fINISHFLAGDataGridViewTextBoxColumn
            // 
            this.fINISHFLAGDataGridViewTextBoxColumn.DataPropertyName = "FINISH_FLAG";
            this.fINISHFLAGDataGridViewTextBoxColumn.HeaderText = "质量抽检标志";
            this.fINISHFLAGDataGridViewTextBoxColumn.Name = "fINISHFLAGDataGridViewTextBoxColumn";
            this.fINISHFLAGDataGridViewTextBoxColumn.Visible = false;
            // 
            // fINISHEDTIMEDataGridViewTextBoxColumn
            // 
            this.fINISHEDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FINISHEDTIME";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.HeaderText = "质量抽检时间";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.Name = "fINISHEDTIMEDataGridViewTextBoxColumn";
            this.fINISHEDTIMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bLOOMCOUNTDataGridViewTextBoxColumn
            // 
            this.bLOOMCOUNTDataGridViewTextBoxColumn.DataPropertyName = "BLOOM_COUNT";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Name = "bLOOMCOUNTDataGridViewTextBoxColumn";
            this.bLOOMCOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cALWEIGHTDataGridViewTextBoxColumn
            // 
            this.cALWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "CAL_WEIGHT";
            this.cALWEIGHTDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.cALWEIGHTDataGridViewTextBoxColumn.Name = "cALWEIGHTDataGridViewTextBoxColumn";
            this.cALWEIGHTDataGridViewTextBoxColumn.Visible = false;
            // 
            // rIGHTCOUNTDataGridViewTextBoxColumn
            // 
            this.rIGHTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_COUNT";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Name = "rIGHTCOUNTDataGridViewTextBoxColumn";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // rIGHTWEIGHTDataGridViewTextBoxColumn
            // 
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_WEIGHT";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.HeaderText = "合格重量";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Name = "rIGHTWEIGHTDataGridViewTextBoxColumn";
            this.rIGHTWEIGHTDataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERCOUNTDataGridViewTextBoxColumn
            // 
            this.wASTERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT";
            this.wASTERCOUNTDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总支数";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Name = "wASTERCOUNTDataGridViewTextBoxColumn";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERWEIGHTDataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.HeaderText = "甩废重量";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Name = "wASTERWEIGHTDataGridViewTextBoxColumn";
            this.wASTERWEIGHTDataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERCOUNT1DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.HeaderText = "甩废钢坯支数1";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Name = "wASTERCOUNT1DataGridViewTextBoxColumn";
            this.wASTERCOUNT1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Name = "wASTERWEIGHT1DataGridViewTextBoxColumn";
            this.wASTERWEIGHT1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERREASON1DataGridViewTextBoxColumn
            // 
            this.wASTERREASON1DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON1";
            this.wASTERREASON1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wASTERREASON1DataGridViewTextBoxColumn.Name = "wASTERREASON1DataGridViewTextBoxColumn";
            this.wASTERREASON1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERCOUNT2DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.HeaderText = "甩废钢坯支数2";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Name = "wASTERCOUNT2DataGridViewTextBoxColumn";
            this.wASTERCOUNT2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Name = "wASTERWEIGHT2DataGridViewTextBoxColumn";
            this.wASTERWEIGHT2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERREASON2DataGridViewTextBoxColumn
            // 
            this.wASTERREASON2DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON2";
            this.wASTERREASON2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wASTERREASON2DataGridViewTextBoxColumn.Name = "wASTERREASON2DataGridViewTextBoxColumn";
            this.wASTERREASON2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERCOUNT3DataGridViewTextBoxColumn
            // 
            this.wASTERCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.HeaderText = "甩废钢坯支数3";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Name = "wASTERCOUNT3DataGridViewTextBoxColumn";
            this.wASTERCOUNT3DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_WEIGHT3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Name = "wASTERWEIGHT3DataGridViewTextBoxColumn";
            this.wASTERWEIGHT3DataGridViewTextBoxColumn.Visible = false;
            // 
            // wASTERREASON3DataGridViewTextBoxColumn
            // 
            this.wASTERREASON3DataGridViewTextBoxColumn.DataPropertyName = "WASTER_REASON3";
            this.wASTERREASON3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wASTERREASON3DataGridViewTextBoxColumn.Name = "wASTERREASON3DataGridViewTextBoxColumn";
            this.wASTERREASON3DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGCOUNTDataGridViewTextBoxColumn
            // 
            this.wRONGCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT";
            this.wRONGCOUNTDataGridViewTextBoxColumn.HeaderText = "不合格钢坯总支数";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Name = "wRONGCOUNTDataGridViewTextBoxColumn";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGWEIGHTDataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.HeaderText = "不合格总重量";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Name = "wRONGWEIGHTDataGridViewTextBoxColumn";
            this.wRONGWEIGHTDataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGCOUNT1DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数1";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Name = "wRONGCOUNT1DataGridViewTextBoxColumn";
            this.wRONGCOUNT1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGWEIGHT1DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT1";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.HeaderText = "不合格重量1";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.Name = "wRONGWEIGHT1DataGridViewTextBoxColumn";
            this.wRONGWEIGHT1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGREASON1DataGridViewTextBoxColumn
            // 
            this.wRONGREASON1DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON1";
            this.wRONGREASON1DataGridViewTextBoxColumn.HeaderText = "不合格原因1";
            this.wRONGREASON1DataGridViewTextBoxColumn.Name = "wRONGREASON1DataGridViewTextBoxColumn";
            this.wRONGREASON1DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGCOUNT2DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数2";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Name = "wRONGCOUNT2DataGridViewTextBoxColumn";
            this.wRONGCOUNT2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGWEIGHT2DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT2";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.HeaderText = "不合格重量2";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.Name = "wRONGWEIGHT2DataGridViewTextBoxColumn";
            this.wRONGWEIGHT2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGREASON2DataGridViewTextBoxColumn
            // 
            this.wRONGREASON2DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON2";
            this.wRONGREASON2DataGridViewTextBoxColumn.HeaderText = "不合格原因2";
            this.wRONGREASON2DataGridViewTextBoxColumn.Name = "wRONGREASON2DataGridViewTextBoxColumn";
            this.wRONGREASON2DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGCOUNT3DataGridViewTextBoxColumn
            // 
            this.wRONGCOUNT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数3";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Name = "wRONGCOUNT3DataGridViewTextBoxColumn";
            this.wRONGCOUNT3DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGWEIGHT3DataGridViewTextBoxColumn
            // 
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_WEIGHT3";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.HeaderText = "不合格重量3";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.Name = "wRONGWEIGHT3DataGridViewTextBoxColumn";
            this.wRONGWEIGHT3DataGridViewTextBoxColumn.Visible = false;
            // 
            // wRONGREASON3DataGridViewTextBoxColumn
            // 
            this.wRONGREASON3DataGridViewTextBoxColumn.DataPropertyName = "WRONG_REASON3";
            this.wRONGREASON3DataGridViewTextBoxColumn.HeaderText = "不合格原因3";
            this.wRONGREASON3DataGridViewTextBoxColumn.Name = "wRONGREASON3DataGridViewTextBoxColumn";
            this.wRONGREASON3DataGridViewTextBoxColumn.Visible = false;
            // 
            // sUFACEDEFACTDESDataGridViewTextBoxColumn
            // 
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.DataPropertyName = "SUFACEDEFACTDES";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.Name = "sUFACEDEFACTDESDataGridViewTextBoxColumn";
            this.sUFACEDEFACTDESDataGridViewTextBoxColumn.Visible = false;
            // 
            // rEASONDataGridViewTextBoxColumn
            // 
            this.rEASONDataGridViewTextBoxColumn.DataPropertyName = "REASON";
            this.rEASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.rEASONDataGridViewTextBoxColumn.Name = "rEASONDataGridViewTextBoxColumn";
            this.rEASONDataGridViewTextBoxColumn.Visible = false;
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qALEVELDataGridViewTextBoxColumn
            // 
            this.qALEVELDataGridViewTextBoxColumn.DataPropertyName = "QALEVEL";
            this.qALEVELDataGridViewTextBoxColumn.HeaderText = "QALEVEL";
            this.qALEVELDataGridViewTextBoxColumn.Name = "qALEVELDataGridViewTextBoxColumn";
            this.qALEVELDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRODUCECONTRACTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCECONTRACTID";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCECONTRACTID";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Name = "pRODUCECONTRACTIDDataGridViewTextBoxColumn";
            this.pRODUCECONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sALESCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "SALESCONTRACTID";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "SALESCONTRACTID";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Name = "sALESCONTRACTIDDataGridViewTextBoxColumn";
            this.sALESCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // oRDERCONTRACTIDDataGridViewTextBoxColumn
            // 
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERCONTRACTID";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.HeaderText = "ORDERCONTRACTID";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Name = "oRDERCONTRACTIDDataGridViewTextBoxColumn";
            this.oRDERCONTRACTIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // qASTATUSDataGridViewTextBoxColumn
            // 
            this.qASTATUSDataGridViewTextBoxColumn.DataPropertyName = "QASTATUS";
            this.qASTATUSDataGridViewTextBoxColumn.HeaderText = "QASTATUS";
            this.qASTATUSDataGridViewTextBoxColumn.Name = "qASTATUSDataGridViewTextBoxColumn";
            this.qASTATUSDataGridViewTextBoxColumn.Visible = false;
            // 
            // BloomOutStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 256);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BloomOutStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "出库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomOutStoreFrm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDESTINATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDESTINATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOutStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton btnOutStore;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvOutStore;
        private AppSvrHMI.L3DataSet dsStoreID;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsOutStore;
        private System.Data.DataTable schemadsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableMATERIALID;
        private System.Data.DataColumn coldsOutStoreL3DataTableSTATUS;
        private System.Data.DataColumn coldsOutStoreL3DataTablePOSITION;
        private System.Data.DataColumn coldsOutStoreL3DataTableQASTATUS;
        private System.Data.DataColumn coldsOutStoreL3DataTableQALEVEL;
        private System.Data.DataColumn coldsOutStoreL3DataTableORDERCONTRACTID;
        private System.Data.DataColumn coldsOutStoreL3DataTablePRODUCECONTRACTID;
        private System.Data.DataColumn coldsOutStoreL3DataTableSALESCONTRACTID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCASTERID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCASTING_NO;
        private System.Data.DataColumn coldsOutStoreL3DataTableCASTING_HEAT_CNT;
        private System.Data.DataColumn coldsOutStoreL3DataTablePRE_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUT_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreL3DataTableFINAL_STEELGRADEINDEX;
        private System.Data.DataColumn coldsOutStoreL3DataTableLENGTH;
        private System.Data.DataColumn coldsOutStoreL3DataTableWIDTH;
        private System.Data.DataColumn coldsOutStoreL3DataTableTHICKNESS;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUR_SECTION_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUR_SEQ_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableCUR_BAY_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableDESTINATION;
        private System.Data.DataColumn coldsOutStoreL3DataTableHOT_SEND_FLAG;
        private System.Data.DataColumn coldsOutStoreL3DataTablePROCESS_TYPE;
        private System.Data.DataColumn coldsOutStoreL3DataTablePLAN_ORD_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTablePRODUCE_DATE;
        private System.Data.DataColumn coldsOutStoreL3DataTableFINISH_FLAG;
        private System.Data.DataColumn coldsOutStoreL3DataTableFINISHEDTIME;
        private System.Data.DataColumn coldsOutStoreL3DataTableBLOOM_COUNT;
        private System.Data.DataColumn coldsOutStoreL3DataTableCAL_WEIGHT;
        private System.Data.DataColumn coldsOutStoreL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsOutStoreL3DataTableRIGHT_WEIGHT;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_WEIGHT;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_COUNT1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_WEIGHT1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_REASON1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_COUNT2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_WEIGHT2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_REASON2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_COUNT3;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_WEIGHT3;
        private System.Data.DataColumn coldsOutStoreL3DataTableWASTER_REASON3;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_WEIGHT;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_COUNT1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_WEIGHT1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_REASON1;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_COUNT2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_WEIGHT2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_REASON2;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_COUNT3;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_WEIGHT3;
        private System.Data.DataColumn coldsOutStoreL3DataTableWRONG_REASON3;
        private System.Data.DataColumn coldsOutStoreL3DataTableSUFACEDEFACTDES;
        private System.Data.DataColumn coldsOutStoreL3DataTableREASON;
        private System.Data.DataColumn coldsOutStoreL3DataTableTarget;
        private AppSvrHMI.L3Command cmdOutStore;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableStoreAreaID;
        private System.Data.DataTable schemadsStoreID;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsDESTINATION;
        private System.Data.DataTable schemadsDESTINATION;
        private System.Data.DataColumn coldsDESTINATIONL3DataTableCode;
        private System.Data.DataColumn coldsDESTINATIONL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTINGHEATCNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRESTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUTSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALSTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIDTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHICKNESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSECTIONIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPILEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURLAYERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURSEQIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURBAYIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTSENDFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCESSTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINISHFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINISHEDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bLOOMCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGHTCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGHTWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERREASON1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERREASON2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERWEIGHT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERREASON3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGREASON1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGREASON2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGWEIGHT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGREASON3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUFACEDEFACTDESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qALEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCECONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALESCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERCONTRACTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qASTATUSDataGridViewTextBoxColumn;
    }
}