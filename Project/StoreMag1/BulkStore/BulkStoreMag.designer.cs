namespace StoreMag.BulkStore
{
    partial class BulkStoreMag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkStoreMag));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsBOF = new System.Windows.Forms.BindingSource(this.components);
            this.dsStore = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTablePOSITION = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAMOUNT = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsStoreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsStoreL3DataTableMaterialType = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnBulkInput = new System.Windows.Forms.ToolStripButton();
            this.btnInStore = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsBOFBalanceOrChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbtnBOFBanlance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnBOFChange = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnBOFClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOFRollBack = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmsBOF4BalanceOrChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF4Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF4RollBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bs4BOF = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmsBOF3BalanceOrChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF3Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF3RollBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bs3BOF = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvGround = new System.Windows.Forms.DataGridView();
            this.cmsBOF2BalanceOrChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF2Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBOF2RollBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bs2BOF = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxBOF = new System.Windows.Forms.GroupBox();
            this.dvBOF = new System.Windows.Forms.DataGridView();
            this.l3dbxGetStore = new AppSvrHMI.L3DataBox();
            this.cmsGroundBalanceOrChange = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsbtnGroundBanlance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtnGroundChange = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGroundClear = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGroundRollBack = new System.Windows.Forms.ToolStripMenuItem();
            this.bsGround = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsStoreSend = new AppSvrHMI.L3DataSet();
            this.schemadsStoreSend = new System.Data.DataTable();
            this.coldsStoreSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_C = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_SI = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_MN = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_P = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_S = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsStoreSendL3DataTableMaterialType = new System.Data.DataColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSDIFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkSIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkMNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsClear = new AppSvrHMI.L3DataSet();
            this.schemadsClear = new System.Data.DataTable();
            this.coldsClearL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsClearL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsClearL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsClearL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsClearL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsClearL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsClearL3DataTableBULK_CODE = new System.Data.DataColumn();
            this.cmdClear = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BulkCODEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSDIFFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATCHIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.tSp1.SuspendLayout();
            this.cmsBOFBalanceOrChange.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            this.cmsBOF4BalanceOrChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs4BOF)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.cmsBOF3BalanceOrChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs3BOF)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGround)).BeginInit();
            this.cmsBOF2BalanceOrChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs2BOF)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxBOF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBOF)).BeginInit();
            this.cmsGroundBalanceOrChange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsClear)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBOF
            // 
            this.bsBOF.DataMember = "L3DataTable";
            this.bsBOF.DataSource = this.dsStore;
            this.bsBOF.Filter = "POSDIFF = \'A\'";
            // 
            // dsStore
            // 
            this.dsStore.AutoSubscribe = true;
            this.dsStore.DataSetName = "L3DataSet";
            this.dsStore.DeleteMethod = "";
            this.dsStore.InsertMethod = "";
            this.dsStore.L3DataAdapter = null;
            this.dsStore.LoadEvent = "Click";
            this.dsStore.LoadTrigger = null;
            this.dsStore.RefreshValve = 1000;
            this.dsStore.SourceCommand = null;
            this.dsStore.SourceCondition = null;
            this.dsStore.SourceMethod = "GetAllMaterialOnStore";
            this.dsStore.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsStore.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsStore.SubscribeTarget = null;
            this.dsStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsStore.UpdateEvent = "Click";
            this.dsStore.UpdateMethod = "";
            this.dsStore.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTablePOSITION,
            this.coll3DataSet1L3DataTableAMOUNT,
            this.coll3DataSet1L3DataTablePOSDIFF,
            this.coll3DataSet1L3DataTableBATCH_ID,
            this.coll3DataSet1L3DataTableBulk_CODE,
            this.coldsStoreL3DataTableMaterialID,
            this.coldsStoreL3DataTableMaterialType});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTablePOSITION
            // 
            this.coll3DataSet1L3DataTablePOSITION.Caption = "POSITION";
            this.coll3DataSet1L3DataTablePOSITION.ColumnName = "POSITION";
            this.coll3DataSet1L3DataTablePOSITION.DefaultValue = "";
            this.coll3DataSet1L3DataTablePOSITION.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAMOUNT
            // 
            this.coll3DataSet1L3DataTableAMOUNT.Caption = "AMOUNT";
            this.coll3DataSet1L3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coll3DataSet1L3DataTableAMOUNT.DataType = typeof(double);
            this.coll3DataSet1L3DataTableAMOUNT.DefaultValue = 0;
            this.coll3DataSet1L3DataTableAMOUNT.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePOSDIFF
            // 
            this.coll3DataSet1L3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coll3DataSet1L3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coll3DataSet1L3DataTablePOSDIFF.DefaultValue = "";
            this.coll3DataSet1L3DataTablePOSDIFF.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBATCH_ID
            // 
            this.coll3DataSet1L3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coll3DataSet1L3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coll3DataSet1L3DataTableBATCH_ID.DefaultValue = "";
            this.coll3DataSet1L3DataTableBATCH_ID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBulk_CODE
            // 
            this.coll3DataSet1L3DataTableBulk_CODE.Caption = "BULK_CODE";
            this.coll3DataSet1L3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coll3DataSet1L3DataTableBulk_CODE.DefaultValue = "";
            this.coll3DataSet1L3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsStoreL3DataTableMaterialID
            // 
            this.coldsStoreL3DataTableMaterialID.Caption = "MATERIALID";
            this.coldsStoreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsStoreL3DataTableMaterialID.DefaultValue = "";
            this.coldsStoreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsStoreL3DataTableMaterialType
            // 
            this.coldsStoreL3DataTableMaterialType.Caption = "MATERIALTYPE";
            this.coldsStoreL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsStoreL3DataTableMaterialType.DefaultValue = "";
            this.coldsStoreL3DataTableMaterialType.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnBulkInput
            // 
            this.Adapter.SetAccessRight(this.btnBulkInput, "BtnBulkExl");
            this.btnBulkInput.Image = ((System.Drawing.Image)(resources.GetObject("btnBulkInput.Image")));
            this.btnBulkInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBulkInput.Name = "btnBulkInput";
            this.btnBulkInput.Size = new System.Drawing.Size(137, 40);
            this.btnBulkInput.Text = "散状原料信息导入";
            this.btnBulkInput.Click += new System.EventHandler(this.btnBulkInput_Click);
            // 
            // btnInStore
            // 
            this.Adapter.SetAccessRight(this.btnInStore, "BtnBulkInstore");
            this.btnInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnInStore.Image")));
            this.btnInStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(113, 40);
            this.btnInStore.Text = "散状原料上料";
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnBulkInput,
            this.btnInStore});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1020, 43);
            this.tSp1.TabIndex = 27;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // cmsBOFBalanceOrChange
            // 
            this.cmsBOFBalanceOrChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBOFBanlance,
            this.tsbtnBOFChange,
            this.tsbtnBOFClear,
            this.btnBOFRollBack});
            this.cmsBOFBalanceOrChange.Name = "cmsBOFBalanceOrChange";
            this.cmsBOFBalanceOrChange.Size = new System.Drawing.Size(131, 92);
            // 
            // tsbtnBOFBanlance
            // 
            this.tsbtnBOFBanlance.Name = "tsbtnBOFBanlance";
            this.tsbtnBOFBanlance.Size = new System.Drawing.Size(130, 22);
            this.tsbtnBOFBanlance.Text = "盘库";
            this.tsbtnBOFBanlance.Click += new System.EventHandler(this.tsbtnBOFBanlance_Click);
            // 
            // tsbtnBOFChange
            // 
            this.tsbtnBOFChange.Name = "tsbtnBOFChange";
            this.tsbtnBOFChange.Size = new System.Drawing.Size(130, 22);
            this.tsbtnBOFChange.Text = "散状料转库";
            this.tsbtnBOFChange.Click += new System.EventHandler(this.tsbtnBOFChange_Click);
            // 
            // tsbtnBOFClear
            // 
            this.tsbtnBOFClear.Name = "tsbtnBOFClear";
            this.tsbtnBOFClear.Size = new System.Drawing.Size(130, 22);
            this.tsbtnBOFClear.Text = "料仓清零";
            this.tsbtnBOFClear.Click += new System.EventHandler(this.tsbtnBOFClear_Click);
            // 
            // btnBOFRollBack
            // 
            this.btnBOFRollBack.Name = "btnBOFRollBack";
            this.btnBOFRollBack.Size = new System.Drawing.Size(130, 22);
            this.btnBOFRollBack.Text = "取消上料";
            this.btnBOFRollBack.Click += new System.EventHandler(this.btnBOFRollBack_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BackColor = System.Drawing.Color.MintCream;
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel4);
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel3);
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel2);
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1020, 572);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(506, 280);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(511, 292);
            this.tableLayoutPanel4.TabIndex = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 286);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4#转炉散状料高仓";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn16});
            this.dataGridView2.ContextMenuStrip = this.cmsBOF4BalanceOrChange;
            this.dataGridView2.DataSource = this.bs4BOF;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(499, 266);
            this.dataGridView2.TabIndex = 0;
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoSubscribe = true;
            this.dsBulkCode.DataSetName = "L3DataSet";
            this.dsBulkCode.DeleteMethod = null;
            this.dsBulkCode.InsertMethod = null;
            this.dsBulkCode.L3DataAdapter = this.Adapter;
            this.dsBulkCode.LoadEvent = "Click";
            this.dsBulkCode.LoadTrigger = null;
            this.dsBulkCode.RefreshValve = 1000;
            this.dsBulkCode.SourceCommand = null;
            this.dsBulkCode.SourceCondition = "CODE_GROUP = \'BULK_CODE\'";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkCode});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
            // 
            // schemadsBulkCode
            // 
            this.schemadsBulkCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkCodeL3DataTableCode,
            this.coldsBulkCodeL3DataTableCode_Des});
            this.schemadsBulkCode.TableName = "L3DataTable";
            // 
            // coldsBulkCodeL3DataTableCode
            // 
            this.coldsBulkCodeL3DataTableCode.Caption = "Code";
            this.coldsBulkCodeL3DataTableCode.ColumnName = "Code";
            this.coldsBulkCodeL3DataTableCode.Namespace = "";
            // 
            // coldsBulkCodeL3DataTableCode_Des
            // 
            this.coldsBulkCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.Namespace = "";
            // 
            // cmsBOF4BalanceOrChange
            // 
            this.cmsBOF4BalanceOrChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.btnBOF4Clear,
            this.btnBOF4RollBack});
            this.cmsBOF4BalanceOrChange.Name = "cmsBOFBalanceOrChange";
            this.cmsBOF4BalanceOrChange.Size = new System.Drawing.Size(131, 92);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem5.Text = "盘库";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem6.Text = "散状料转库";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // btnBOF4Clear
            // 
            this.btnBOF4Clear.Name = "btnBOF4Clear";
            this.btnBOF4Clear.Size = new System.Drawing.Size(130, 22);
            this.btnBOF4Clear.Text = "料仓清零";
            this.btnBOF4Clear.Click += new System.EventHandler(this.btnBOF4Clear_Click);
            // 
            // btnBOF4RollBack
            // 
            this.btnBOF4RollBack.Name = "btnBOF4RollBack";
            this.btnBOF4RollBack.Size = new System.Drawing.Size(130, 22);
            this.btnBOF4RollBack.Text = "取消上料";
            this.btnBOF4RollBack.Click += new System.EventHandler(this.btnBOF4RollBack_Click);
            // 
            // bs4BOF
            // 
            this.bs4BOF.DataMember = "L3DataTable";
            this.bs4BOF.DataSource = this.dsStore;
            this.bs4BOF.Filter = "POSDIFF = \'D\'";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(506, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(511, 274);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 268);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3#转炉散状料高仓";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView1.ContextMenuStrip = this.cmsBOF3BalanceOrChange;
            this.dataGridView1.DataSource = this.bs3BOF;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(499, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmsBOF3BalanceOrChange
            // 
            this.cmsBOF3BalanceOrChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.btnBOF3Clear,
            this.btnBOF3RollBack});
            this.cmsBOF3BalanceOrChange.Name = "cmsBOFBalanceOrChange";
            this.cmsBOF3BalanceOrChange.Size = new System.Drawing.Size(131, 92);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem3.Text = "盘库";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem4.Text = "散状料转库";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // btnBOF3Clear
            // 
            this.btnBOF3Clear.Name = "btnBOF3Clear";
            this.btnBOF3Clear.Size = new System.Drawing.Size(130, 22);
            this.btnBOF3Clear.Text = "料仓清零";
            this.btnBOF3Clear.Click += new System.EventHandler(this.btnBOF3Clear_Click);
            // 
            // btnBOF3RollBack
            // 
            this.btnBOF3RollBack.Name = "btnBOF3RollBack";
            this.btnBOF3RollBack.Size = new System.Drawing.Size(130, 22);
            this.btnBOF3RollBack.Text = "取消上料";
            this.btnBOF3RollBack.Click += new System.EventHandler(this.btnBOF3RollBack_Click);
            // 
            // bs3BOF
            // 
            this.bs3BOF.DataMember = "L3DataTable";
            this.bs3BOF.DataSource = this.dsStore;
            this.bs3BOF.Filter = "POSDIFF = \'C\'";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(503, 289);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvGround);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 283);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2#转炉散状料高仓";
            // 
            // dvGround
            // 
            this.dvGround.AllowUserToAddRows = false;
            this.dvGround.AutoGenerateColumns = false;
            this.dvGround.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvGround.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvGround.BackgroundColor = System.Drawing.Color.MintCream;
            this.dvGround.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGround.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvGround.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn14});
            this.dvGround.ContextMenuStrip = this.cmsBOF2BalanceOrChange;
            this.dvGround.DataSource = this.bs2BOF;
            this.dvGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGround.Location = new System.Drawing.Point(3, 17);
            this.dvGround.Name = "dvGround";
            this.dvGround.ReadOnly = true;
            this.dvGround.RowHeadersVisible = false;
            this.dvGround.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvGround.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dvGround.RowTemplate.Height = 23;
            this.dvGround.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvGround.Size = new System.Drawing.Size(491, 263);
            this.dvGround.TabIndex = 0;
            // 
            // cmsBOF2BalanceOrChange
            // 
            this.cmsBOF2BalanceOrChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBalance,
            this.toolStripMenuItem2,
            this.btnBOF2Clear,
            this.btnBOF2RollBack});
            this.cmsBOF2BalanceOrChange.Name = "cmsBOFBalanceOrChange";
            this.cmsBOF2BalanceOrChange.Size = new System.Drawing.Size(131, 92);
            // 
            // btnBalance
            // 
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(130, 22);
            this.btnBalance.Text = "盘库";
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem2.Text = "散状料转库";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnBOF2Clear
            // 
            this.btnBOF2Clear.Name = "btnBOF2Clear";
            this.btnBOF2Clear.Size = new System.Drawing.Size(130, 22);
            this.btnBOF2Clear.Text = "料仓清零";
            this.btnBOF2Clear.Click += new System.EventHandler(this.btnBOF2Clear_Click);
            // 
            // btnBOF2RollBack
            // 
            this.btnBOF2RollBack.Name = "btnBOF2RollBack";
            this.btnBOF2RollBack.Size = new System.Drawing.Size(130, 22);
            this.btnBOF2RollBack.Text = "取消上料";
            this.btnBOF2RollBack.Click += new System.EventHandler(this.btnBOF2RollBack_Click);
            // 
            // bs2BOF
            // 
            this.bs2BOF.DataMember = "L3DataTable";
            this.bs2BOF.DataSource = this.dsStore;
            this.bs2BOF.Filter = "POSDIFF = \'B\'";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbxBOF, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 274);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // gbxBOF
            // 
            this.gbxBOF.Controls.Add(this.dvBOF);
            this.gbxBOF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxBOF.Location = new System.Drawing.Point(3, 3);
            this.gbxBOF.Name = "gbxBOF";
            this.gbxBOF.Size = new System.Drawing.Size(497, 268);
            this.gbxBOF.TabIndex = 29;
            this.gbxBOF.TabStop = false;
            this.gbxBOF.Text = "1#转炉散状料高仓";
            // 
            // dvBOF
            // 
            this.dvBOF.AllowUserToAddRows = false;
            this.dvBOF.AutoGenerateColumns = false;
            this.dvBOF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvBOF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvBOF.BackgroundColor = System.Drawing.Color.MintCream;
            this.dvBOF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvBOF.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvBOF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pOSITIONDataGridViewTextBoxColumn1,
            this.BulkCODEDataGridViewTextBoxColumn1,
            this.aMOUNTDataGridViewTextBoxColumn1,
            this.pOSDIFFDataGridViewTextBoxColumn1,
            this.bATCHIDDataGridViewTextBoxColumn1});
            this.dvBOF.ContextMenuStrip = this.cmsBOFBalanceOrChange;
            this.dvBOF.DataSource = this.bsBOF;
            this.dvBOF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBOF.Location = new System.Drawing.Point(3, 17);
            this.dvBOF.Name = "dvBOF";
            this.dvBOF.ReadOnly = true;
            this.dvBOF.RowHeadersVisible = false;
            this.dvBOF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvBOF.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dvBOF.RowTemplate.Height = 23;
            this.dvBOF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBOF.Size = new System.Drawing.Size(491, 248);
            this.dvBOF.TabIndex = 0;
            this.dvBOF.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.TipText_CellToolTipTextNeeded);
            // 
            // l3dbxGetStore
            // 
            this.l3dbxGetStore.DataFormat = null;
            this.l3dbxGetStore.DataObject = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.l3dbxGetStore.DataProperty = "MaterialInputted";
            this.l3dbxGetStore.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3dbxGetStore.L3DataAdapter = this.Adapter;
            this.l3dbxGetStore.Location = new System.Drawing.Point(288, 16);
            this.l3dbxGetStore.Name = "l3dbxGetStore";
            this.l3dbxGetStore.Size = new System.Drawing.Size(100, 21);
            this.l3dbxGetStore.TabIndex = 32;
            this.l3dbxGetStore.Value = null;
            this.l3dbxGetStore.Visible = false;
            this.l3dbxGetStore.TextChanged += new System.EventHandler(this.l3dbxGetStore_TextChanged);
            // 
            // cmsGroundBalanceOrChange
            // 
            this.cmsGroundBalanceOrChange.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGroundBanlance,
            this.tsbtnGroundChange,
            this.btnGroundClear,
            this.btnGroundRollBack});
            this.cmsGroundBalanceOrChange.Name = "cmsBOFBalanceOrChange";
            this.cmsGroundBalanceOrChange.Size = new System.Drawing.Size(131, 92);
            // 
            // tsbtnGroundBanlance
            // 
            this.tsbtnGroundBanlance.Name = "tsbtnGroundBanlance";
            this.tsbtnGroundBanlance.Size = new System.Drawing.Size(130, 22);
            this.tsbtnGroundBanlance.Text = "盘库";
            this.tsbtnGroundBanlance.Click += new System.EventHandler(this.tsbtnGroundBanlance_Click);
            // 
            // tsbtnGroundChange
            // 
            this.tsbtnGroundChange.Name = "tsbtnGroundChange";
            this.tsbtnGroundChange.Size = new System.Drawing.Size(130, 22);
            this.tsbtnGroundChange.Text = "散状料转库";
            this.tsbtnGroundChange.Click += new System.EventHandler(this.tsbtnGroundChange_Click);
            // 
            // btnGroundClear
            // 
            this.btnGroundClear.Name = "btnGroundClear";
            this.btnGroundClear.Size = new System.Drawing.Size(130, 22);
            this.btnGroundClear.Text = "料仓清零";
            this.btnGroundClear.Click += new System.EventHandler(this.btnGroundClear_Click);
            // 
            // btnGroundRollBack
            // 
            this.btnGroundRollBack.Name = "btnGroundRollBack";
            this.btnGroundRollBack.Size = new System.Drawing.Size(130, 22);
            this.btnGroundRollBack.Text = "取消上料";
            this.btnGroundRollBack.Click += new System.EventHandler(this.btnGroundRollBack_Click);
            // 
            // bsGround
            // 
            this.bsGround.DataMember = "L3DataTable";
            this.bsGround.DataSource = this.dsStore;
            this.bsGround.Filter = "POSDIFF = \'Z\'";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // dsStoreSend
            // 
            this.dsStoreSend.AutoSubscribe = true;
            this.dsStoreSend.DataSetName = "L3DataSet";
            this.dsStoreSend.DeleteMethod = "";
            this.dsStoreSend.InsertMethod = "";
            this.dsStoreSend.L3DataAdapter = this.Adapter;
            this.dsStoreSend.LoadEvent = "Click";
            this.dsStoreSend.LoadTrigger = null;
            this.dsStoreSend.RefreshValve = 1000;
            this.dsStoreSend.SourceCommand = null;
            this.dsStoreSend.SourceCondition = "";
            this.dsStoreSend.SourceMethod = "";
            this.dsStoreSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsStoreSend.SourceURI = "";
            this.dsStoreSend.SubscribeTarget = "Version";
            this.dsStoreSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreSend});
            this.dsStoreSend.UpdateEvent = "Click";
            this.dsStoreSend.UpdateMethod = "";
            this.dsStoreSend.UpdateTrigger = null;
            // 
            // schemadsStoreSend
            // 
            this.schemadsStoreSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreSendL3DataTablePOSITION,
            this.coldsStoreSendL3DataTablePOSDIFF,
            this.coldsStoreSendL3DataTableAMOUNT,
            this.coldsStoreSendL3DataTableBulk_C,
            this.coldsStoreSendL3DataTableBulk_SI,
            this.coldsStoreSendL3DataTableBulk_MN,
            this.coldsStoreSendL3DataTableBulk_P,
            this.coldsStoreSendL3DataTableBulk_S,
            this.coldsStoreSendL3DataTableBATCH_ID,
            this.coldsStoreSendL3DataTableBulk_CODE,
            this.coldsStoreSendL3DataTableMaterialID,
            this.coldsStoreSendL3DataTableMaterialType});
            this.schemadsStoreSend.TableName = "L3DataTable";
            // 
            // coldsStoreSendL3DataTablePOSITION
            // 
            this.coldsStoreSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsStoreSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsStoreSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsStoreSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsStoreSendL3DataTablePOSDIFF
            // 
            this.coldsStoreSendL3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coldsStoreSendL3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coldsStoreSendL3DataTablePOSDIFF.DefaultValue = "";
            this.coldsStoreSendL3DataTablePOSDIFF.Namespace = "";
            // 
            // coldsStoreSendL3DataTableAMOUNT
            // 
            this.coldsStoreSendL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsStoreSendL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsStoreSendL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsStoreSendL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsStoreSendL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_C
            // 
            this.coldsStoreSendL3DataTableBulk_C.Caption = "Bulk_C";
            this.coldsStoreSendL3DataTableBulk_C.ColumnName = "Bulk_C";
            this.coldsStoreSendL3DataTableBulk_C.DataType = typeof(double);
            this.coldsStoreSendL3DataTableBulk_C.DefaultValue = 0;
            this.coldsStoreSendL3DataTableBulk_C.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_SI
            // 
            this.coldsStoreSendL3DataTableBulk_SI.Caption = "Bulk_SI";
            this.coldsStoreSendL3DataTableBulk_SI.ColumnName = "Bulk_SI";
            this.coldsStoreSendL3DataTableBulk_SI.DataType = typeof(double);
            this.coldsStoreSendL3DataTableBulk_SI.DefaultValue = 0;
            this.coldsStoreSendL3DataTableBulk_SI.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_MN
            // 
            this.coldsStoreSendL3DataTableBulk_MN.Caption = "Bulk_MN";
            this.coldsStoreSendL3DataTableBulk_MN.ColumnName = "Bulk_MN";
            this.coldsStoreSendL3DataTableBulk_MN.DataType = typeof(double);
            this.coldsStoreSendL3DataTableBulk_MN.DefaultValue = 0;
            this.coldsStoreSendL3DataTableBulk_MN.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_P
            // 
            this.coldsStoreSendL3DataTableBulk_P.Caption = "Bulk_P";
            this.coldsStoreSendL3DataTableBulk_P.ColumnName = "Bulk_P";
            this.coldsStoreSendL3DataTableBulk_P.DataType = typeof(double);
            this.coldsStoreSendL3DataTableBulk_P.DefaultValue = 0;
            this.coldsStoreSendL3DataTableBulk_P.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_S
            // 
            this.coldsStoreSendL3DataTableBulk_S.Caption = "Bulk_S";
            this.coldsStoreSendL3DataTableBulk_S.ColumnName = "Bulk_S";
            this.coldsStoreSendL3DataTableBulk_S.DataType = typeof(double);
            this.coldsStoreSendL3DataTableBulk_S.DefaultValue = 0;
            this.coldsStoreSendL3DataTableBulk_S.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBATCH_ID
            // 
            this.coldsStoreSendL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsStoreSendL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsStoreSendL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsStoreSendL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsStoreSendL3DataTableBulk_CODE
            // 
            this.coldsStoreSendL3DataTableBulk_CODE.Caption = "Bulk_CODE";
            this.coldsStoreSendL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsStoreSendL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsStoreSendL3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsStoreSendL3DataTableMaterialID
            // 
            this.coldsStoreSendL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsStoreSendL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsStoreSendL3DataTableMaterialID.Namespace = "";
            // 
            // coldsStoreSendL3DataTableMaterialType
            // 
            this.coldsStoreSendL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsStoreSendL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsStoreSendL3DataTableMaterialType.Namespace = "";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.Width = 78;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Width = 66;
            // 
            // pOSDIFFDataGridViewTextBoxColumn
            // 
            this.pOSDIFFDataGridViewTextBoxColumn.DataPropertyName = "POSDIFF";
            this.pOSDIFFDataGridViewTextBoxColumn.HeaderText = "POSDIFF";
            this.pOSDIFFDataGridViewTextBoxColumn.Name = "pOSDIFFDataGridViewTextBoxColumn";
            this.pOSDIFFDataGridViewTextBoxColumn.Width = 72;
            // 
            // bulkCDataGridViewTextBoxColumn
            // 
            this.bulkCDataGridViewTextBoxColumn.DataPropertyName = "Bulk_C";
            this.bulkCDataGridViewTextBoxColumn.HeaderText = "Bulk_C";
            this.bulkCDataGridViewTextBoxColumn.Name = "bulkCDataGridViewTextBoxColumn";
            this.bulkCDataGridViewTextBoxColumn.Width = 66;
            // 
            // bulkSIDataGridViewTextBoxColumn
            // 
            this.bulkSIDataGridViewTextBoxColumn.DataPropertyName = "Bulk_SI";
            this.bulkSIDataGridViewTextBoxColumn.HeaderText = "Bulk_SI";
            this.bulkSIDataGridViewTextBoxColumn.Name = "bulkSIDataGridViewTextBoxColumn";
            this.bulkSIDataGridViewTextBoxColumn.Width = 72;
            // 
            // bulkMNDataGridViewTextBoxColumn
            // 
            this.bulkMNDataGridViewTextBoxColumn.DataPropertyName = "Bulk_MN";
            this.bulkMNDataGridViewTextBoxColumn.HeaderText = "Bulk_MN";
            this.bulkMNDataGridViewTextBoxColumn.Name = "bulkMNDataGridViewTextBoxColumn";
            this.bulkMNDataGridViewTextBoxColumn.Width = 72;
            // 
            // bulkPDataGridViewTextBoxColumn
            // 
            this.bulkPDataGridViewTextBoxColumn.DataPropertyName = "Bulk_P";
            this.bulkPDataGridViewTextBoxColumn.HeaderText = "Bulk_P";
            this.bulkPDataGridViewTextBoxColumn.Name = "bulkPDataGridViewTextBoxColumn";
            this.bulkPDataGridViewTextBoxColumn.Width = 66;
            // 
            // bulkSDataGridViewTextBoxColumn
            // 
            this.bulkSDataGridViewTextBoxColumn.DataPropertyName = "Bulk_S";
            this.bulkSDataGridViewTextBoxColumn.HeaderText = "Bulk_S";
            this.bulkSDataGridViewTextBoxColumn.Name = "bulkSDataGridViewTextBoxColumn";
            this.bulkSDataGridViewTextBoxColumn.Width = 66;
            // 
            // bATCHIDDataGridViewTextBoxColumn
            // 
            this.bATCHIDDataGridViewTextBoxColumn.DataPropertyName = "BATCH_ID";
            this.bATCHIDDataGridViewTextBoxColumn.HeaderText = "BATCH_ID";
            this.bATCHIDDataGridViewTextBoxColumn.Name = "bATCHIDDataGridViewTextBoxColumn";
            this.bATCHIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // bulkCODEDataGridViewTextBoxColumn
            // 
            this.bulkCODEDataGridViewTextBoxColumn.DataPropertyName = "Bulk_CODE";
            this.bulkCODEDataGridViewTextBoxColumn.HeaderText = "Bulk_CODE";
            this.bulkCODEDataGridViewTextBoxColumn.Name = "bulkCODEDataGridViewTextBoxColumn";
            this.bulkCODEDataGridViewTextBoxColumn.Width = 84;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.Width = 102;
            // 
            // dsBulkArea
            // 
            this.dsBulkArea.AutoSubscribe = true;
            this.dsBulkArea.DataSetName = "L3DataSet";
            this.dsBulkArea.DeleteMethod = null;
            this.dsBulkArea.InsertMethod = null;
            this.dsBulkArea.L3DataAdapter = this.Adapter;
            this.dsBulkArea.LoadEvent = "Click";
            this.dsBulkArea.LoadTrigger = null;
            this.dsBulkArea.RefreshValve = 1000;
            this.dsBulkArea.SourceCommand = null;
            this.dsBulkArea.SourceCondition = "CODE_GROUP = \'BulkArea\'";
            this.dsBulkArea.SourceMethod = "";
            this.dsBulkArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkArea.SubscribeTarget = null;
            this.dsBulkArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkArea});
            this.dsBulkArea.UpdateEvent = "Click";
            this.dsBulkArea.UpdateMethod = null;
            this.dsBulkArea.UpdateTrigger = null;
            // 
            // schemadsBulkArea
            // 
            this.schemadsBulkArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAreaL3DataTableCode,
            this.coldsBulkAreaL3DataTableCode_Des});
            this.schemadsBulkArea.TableName = "L3DataTable";
            // 
            // coldsBulkAreaL3DataTableCode
            // 
            this.coldsBulkAreaL3DataTableCode.Caption = "Code";
            this.coldsBulkAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBulkAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBulkAreaL3DataTableCode_Des
            // 
            this.coldsBulkAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.Namespace = "";
            // 
            // dsClear
            // 
            this.dsClear.AutoSubscribe = true;
            this.dsClear.DataSetName = "L3DataSet";
            this.dsClear.DeleteMethod = "";
            this.dsClear.InsertMethod = "";
            this.dsClear.L3DataAdapter = null;
            this.dsClear.LoadEvent = "";
            this.dsClear.LoadTrigger = null;
            this.dsClear.RefreshValve = 1000;
            this.dsClear.SourceCommand = null;
            this.dsClear.SourceCondition = "";
            this.dsClear.SourceMethod = "";
            this.dsClear.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsClear.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsClear.SubscribeTarget = "Version";
            this.dsClear.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsClear});
            this.dsClear.UpdateEvent = "";
            this.dsClear.UpdateMethod = "";
            this.dsClear.UpdateTrigger = null;
            // 
            // schemadsClear
            // 
            this.schemadsClear.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsClearL3DataTableMATERIALID,
            this.coldsClearL3DataTableMATERIALTYPE,
            this.coldsClearL3DataTablePOSITION,
            this.coldsClearL3DataTablePOSDIFF,
            this.coldsClearL3DataTableAMOUNT,
            this.coldsClearL3DataTableBATCH_ID,
            this.coldsClearL3DataTableBULK_CODE});
            this.schemadsClear.TableName = "L3DataTable";
            // 
            // coldsClearL3DataTableMATERIALID
            // 
            this.coldsClearL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsClearL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsClearL3DataTableMATERIALID.DefaultValue = "";
            this.coldsClearL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsClearL3DataTableMATERIALTYPE
            // 
            this.coldsClearL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsClearL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsClearL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsClearL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsClearL3DataTablePOSITION
            // 
            this.coldsClearL3DataTablePOSITION.Caption = "POSITION";
            this.coldsClearL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsClearL3DataTablePOSITION.DefaultValue = "";
            this.coldsClearL3DataTablePOSITION.Namespace = "";
            // 
            // coldsClearL3DataTablePOSDIFF
            // 
            this.coldsClearL3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coldsClearL3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coldsClearL3DataTablePOSDIFF.DefaultValue = "";
            this.coldsClearL3DataTablePOSDIFF.Namespace = "";
            // 
            // coldsClearL3DataTableAMOUNT
            // 
            this.coldsClearL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsClearL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsClearL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsClearL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsClearL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsClearL3DataTableBATCH_ID
            // 
            this.coldsClearL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsClearL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsClearL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsClearL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsClearL3DataTableBULK_CODE
            // 
            this.coldsClearL3DataTableBULK_CODE.Caption = "BULK_CODE";
            this.coldsClearL3DataTableBULK_CODE.ColumnName = "BULK_CODE";
            this.coldsClearL3DataTableBULK_CODE.DefaultValue = "";
            this.coldsClearL3DataTableBULK_CODE.Namespace = "";
            // 
            // cmdClear
            // 
            this.cmdClear.Adapter = this.Adapter;
            this.cmdClear.MergeReturnTarget = false;
            this.cmdClear.Method = "ResetWeight";
            this.cmdClear.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdClear.Parameters.Add(this.l3CommandParameter1);
            this.cmdClear.ReturnTarget = null;
            this.cmdClear.ReturnTargetProperty = null;
            this.cmdClear.Trigger = null;
            this.cmdClear.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsClear;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "POSITION";
            this.dataGridViewTextBoxColumn6.DataSource = this.dsBulkArea;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "料仓";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "L3DataTable.Code";
            this.dataGridViewTextBoxColumn6.Width = 54;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Bulk_CODE";
            this.dataGridViewComboBoxColumn1.DataSource = this.dsBulkCode;
            this.dataGridViewComboBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "散状料";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn8.HeaderText = "重量[Kg]";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "POSDIFF";
            this.dataGridViewTextBoxColumn9.HeaderText = "POSDIFF";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 72;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BATCH_ID";
            this.dataGridViewTextBoxColumn15.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "POSITION";
            this.dataGridViewTextBoxColumn1.DataSource = this.dsBulkArea;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn1.HeaderText = "料仓";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Bulk_CODE";
            this.dataGridViewTextBoxColumn2.DataSource = this.dsBulkCode;
            this.dataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "散状料";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code";
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "重量[Kg]";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "POSDIFF";
            this.dataGridViewTextBoxColumn5.HeaderText = "POSDIFF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "BATCH_ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "POSITION";
            this.dataGridViewTextBoxColumn10.DataSource = this.dsBulkArea;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn10.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn10.HeaderText = "料仓";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "L3DataTable.Code";
            this.dataGridViewTextBoxColumn10.Width = 54;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Bulk_CODE";
            this.dataGridViewComboBoxColumn2.DataSource = this.dsBulkCode;
            this.dataGridViewComboBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "散状料";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn12.HeaderText = "重量";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 54;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "POSDIFF";
            this.dataGridViewTextBoxColumn13.HeaderText = "POSDIFF";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 72;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "BATCH_ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 66;
            // 
            // pOSITIONDataGridViewTextBoxColumn1
            // 
            this.pOSITIONDataGridViewTextBoxColumn1.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn1.DataSource = this.dsBulkArea;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.pOSITIONDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.pOSITIONDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn1.HeaderText = "料仓";
            this.pOSITIONDataGridViewTextBoxColumn1.Name = "pOSITIONDataGridViewTextBoxColumn1";
            this.pOSITIONDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.pOSITIONDataGridViewTextBoxColumn1.Width = 35;
            // 
            // BulkCODEDataGridViewTextBoxColumn1
            // 
            this.BulkCODEDataGridViewTextBoxColumn1.DataPropertyName = "Bulk_CODE";
            this.BulkCODEDataGridViewTextBoxColumn1.DataSource = this.dsBulkCode;
            this.BulkCODEDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.BulkCODEDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BulkCODEDataGridViewTextBoxColumn1.HeaderText = "散状料";
            this.BulkCODEDataGridViewTextBoxColumn1.Name = "BulkCODEDataGridViewTextBoxColumn1";
            this.BulkCODEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.BulkCODEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BulkCODEDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.BulkCODEDataGridViewTextBoxColumn1.Width = 47;
            // 
            // aMOUNTDataGridViewTextBoxColumn1
            // 
            this.aMOUNTDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aMOUNTDataGridViewTextBoxColumn1.DataPropertyName = "AMOUNT";
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = null;
            this.aMOUNTDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.aMOUNTDataGridViewTextBoxColumn1.HeaderText = "重量[Kg]";
            this.aMOUNTDataGridViewTextBoxColumn1.Name = "aMOUNTDataGridViewTextBoxColumn1";
            this.aMOUNTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.aMOUNTDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aMOUNTDataGridViewTextBoxColumn1.Width = 59;
            // 
            // pOSDIFFDataGridViewTextBoxColumn1
            // 
            this.pOSDIFFDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pOSDIFFDataGridViewTextBoxColumn1.DataPropertyName = "POSDIFF";
            this.pOSDIFFDataGridViewTextBoxColumn1.HeaderText = "POSDIFF";
            this.pOSDIFFDataGridViewTextBoxColumn1.Name = "pOSDIFFDataGridViewTextBoxColumn1";
            this.pOSDIFFDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pOSDIFFDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pOSDIFFDataGridViewTextBoxColumn1.Visible = false;
            this.pOSDIFFDataGridViewTextBoxColumn1.Width = 53;
            // 
            // bATCHIDDataGridViewTextBoxColumn1
            // 
            this.bATCHIDDataGridViewTextBoxColumn1.DataPropertyName = "BATCH_ID";
            this.bATCHIDDataGridViewTextBoxColumn1.HeaderText = "批次号";
            this.bATCHIDDataGridViewTextBoxColumn1.Name = "bATCHIDDataGridViewTextBoxColumn1";
            this.bATCHIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bATCHIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bATCHIDDataGridViewTextBoxColumn1.Width = 47;
            // 
            // BulkStoreMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.l3dbxGetStore);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BulkStoreMag";
            this.TabText = "散状料管理";
            this.Text = "多记录显示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BulkStoreMag_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.BulkStoreMag_VisibleChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkStoreMag_FormClosing);
            this.Load += new System.EventHandler(this.BulkAadAreaMapFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.cmsBOFBalanceOrChange.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            this.cmsBOF4BalanceOrChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs4BOF)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.cmsBOF3BalanceOrChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs3BOF)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGround)).EndInit();
            this.cmsBOF2BalanceOrChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs2BOF)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbxBOF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBOF)).EndInit();
            this.cmsGroundBalanceOrChange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsStore;
        private System.Windows.Forms.BindingSource bsBOF;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnInStore;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTablePOSITION;
        private System.Data.DataColumn coll3DataSet1L3DataTableAMOUNT;
        private System.Data.DataColumn coll3DataSet1L3DataTablePOSDIFF;
        private System.Data.DataColumn coll3DataSet1L3DataTableBATCH_ID;
        private System.Data.DataColumn coll3DataSet1L3DataTableBulk_CODE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnBulkInput;
        private System.Data.DataColumn coldsStoreL3DataTableMaterialID;
        private System.Data.DataColumn coldsStoreL3DataTableMaterialType;
        private AppSvrHMI.L3DataSet dsStoreSend;
        private System.Data.DataTable schemadsStoreSend;
        private System.Data.DataColumn coldsStoreSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsStoreSendL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsStoreSendL3DataTableAMOUNT;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_C;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_SI;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_MN;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_P;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_S;
        private System.Data.DataColumn coldsStoreSendL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsStoreSendL3DataTableBulk_CODE;
        private System.Windows.Forms.ContextMenuStrip cmsBOFBalanceOrChange;
        private System.Data.DataColumn coldsStoreSendL3DataTableMaterialID;
        private System.Data.DataColumn coldsStoreSendL3DataTableMaterialType;
        private System.Windows.Forms.ToolStripMenuItem tsbtnBOFBanlance;
        private System.Windows.Forms.ToolStripMenuItem tsbtnBOFChange;
        private System.Windows.Forms.GroupBox gbxBOF;
        private System.Windows.Forms.DataGridView dvBOF;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSDIFFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkSIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkMNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvGround;
        private System.Windows.Forms.BindingSource bsGround;
        private System.Windows.Forms.ContextMenuStrip cmsGroundBalanceOrChange;
        private System.Windows.Forms.ToolStripMenuItem tsbtnGroundBanlance;
        private System.Windows.Forms.ToolStripMenuItem tsbtnGroundChange;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs4BOF;
        private System.Windows.Forms.BindingSource bs3BOF;
        private System.Windows.Forms.BindingSource bs2BOF;
        private System.Windows.Forms.ContextMenuStrip cmsBOF2BalanceOrChange;
        private System.Windows.Forms.ToolStripMenuItem btnBalance;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmsBOF3BalanceOrChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip cmsBOF4BalanceOrChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private AppSvrHMI.L3DataBox l3dbxGetStore;
        private System.Windows.Forms.ToolStripMenuItem tsbtnBOFClear;
        private System.Windows.Forms.ToolStripMenuItem btnBOF2Clear;
        private System.Windows.Forms.ToolStripMenuItem btnBOF4Clear;
        private System.Windows.Forms.ToolStripMenuItem btnBOF3Clear;
        private AppSvrHMI.L3DataSet dsClear;
        private System.Data.DataTable schemadsClear;
        private System.Data.DataColumn coldsClearL3DataTableMATERIALID;
        private System.Data.DataColumn coldsClearL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsClearL3DataTablePOSITION;
        private System.Data.DataColumn coldsClearL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsClearL3DataTableAMOUNT;
        private System.Data.DataColumn coldsClearL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsClearL3DataTableBULK_CODE;
        private AppSvrHMI.L3Command cmdClear;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripMenuItem btnGroundClear;
        private System.Windows.Forms.ToolStripMenuItem btnBOFRollBack;
        private System.Windows.Forms.ToolStripMenuItem btnBOF4RollBack;
        private System.Windows.Forms.ToolStripMenuItem btnBOF3RollBack;
        private System.Windows.Forms.ToolStripMenuItem btnBOF2RollBack;
        private System.Windows.Forms.ToolStripMenuItem btnGroundRollBack;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn BulkCODEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSDIFFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATCHIDDataGridViewTextBoxColumn1;

    }
}