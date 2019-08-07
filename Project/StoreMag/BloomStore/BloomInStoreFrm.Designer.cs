namespace StoreMag.BloomStore
{
    partial class BloomInStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloomInStoreFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsInStore = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCUR_PILE_ID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCUR_LAYER_ID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSTOREAREAID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSTD = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableWASTER_COUNT = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableWRONG_COUNT = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableRIGHT_COUNT = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableBloom_Count = new System.Data.DataColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOREAREAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStoreAreaID = new AppSvrHMI.L3DataSet();
            this.schemadsStoreAreaID = new System.Data.DataTable();
            this.coldsStoreAreaIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cURPILEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCurPileID = new AppSvrHMI.L3DataSet();
            this.schemadsCurPileID = new System.Data.DataTable();
            this.coldsCurPileIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCurPileIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cURLAYERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTERCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRONGCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rIGHTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdInStore = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsCurLayerID = new AppSvrHMI.L3DataSet();
            this.schemadsCurLayerID = new System.Data.DataTable();
            this.coldsCurLayerIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCurLayerIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurPileID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurPileID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurLayerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurLayerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bindingNavigator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator2.BackgroundImage")));
            this.bindingNavigator2.BindingSource = this.bsInStore;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1121, 25);
            this.bindingNavigator2.TabIndex = 62;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bsInStore
            // 
            this.bsInStore.DataMember = "L3DataTable";
            this.bsInStore.DataSource = this.dsInStore;
            // 
            // dsInStore
            // 
            this.dsInStore.AutoSubscribe = true;
            this.dsInStore.DataSetName = "L3DataSet";
            this.dsInStore.DeleteMethod = "";
            this.dsInStore.InsertMethod = "";
            this.dsInStore.L3DataAdapter = this.Adapter;
            this.dsInStore.LoadEvent = "Click";
            this.dsInStore.LoadTrigger = null;
            this.dsInStore.RefreshValve = 1000;
            this.dsInStore.SourceCommand = null;
            this.dsInStore.SourceCondition = "";
            this.dsInStore.SourceMethod = "";
            this.dsInStore.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsInStore.SourceURI = "";
            this.dsInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsInStore.UpdateEvent = "Click";
            this.dsInStore.UpdateMethod = "";
            this.dsInStore.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableMATERIALTYPE,
            this.coldsInStoreL3DataTableAMOUNT,
            this.coldsInStoreL3DataTableMATERIALID,
            this.coldsInStoreL3DataTableCUR_PILE_ID,
            this.coldsInStoreL3DataTableCUR_LAYER_ID,
            this.coldsInStoreL3DataTableCASTERID,
            this.coldsInStoreL3DataTableSTOREAREAID,
            this.coldsInStoreL3DataTableSTD,
            this.coldsInStoreL3DataTableSTEELGRADEINDEX,
            this.coldsInStoreL3DataTableWASTER_COUNT,
            this.coldsInStoreL3DataTableWRONG_COUNT,
            this.coldsInStoreL3DataTableRIGHT_COUNT,
            this.coldsInStoreL3DataTableCheckFlag,
            this.coldsInStoreL3DataTableBloom_Count});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableMATERIALTYPE
            // 
            this.coldsInStoreL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsInStoreL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsInStoreL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsInStoreL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsInStoreL3DataTableAMOUNT
            // 
            this.coldsInStoreL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsInStoreL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsInStoreL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsInStoreL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsInStoreL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsInStoreL3DataTableMATERIALID
            // 
            this.coldsInStoreL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsInStoreL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsInStoreL3DataTableMATERIALID.DefaultValue = "";
            this.coldsInStoreL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsInStoreL3DataTableCUR_PILE_ID
            // 
            this.coldsInStoreL3DataTableCUR_PILE_ID.Caption = "CUR_PILE_ID";
            this.coldsInStoreL3DataTableCUR_PILE_ID.ColumnName = "CUR_PILE_ID";
            this.coldsInStoreL3DataTableCUR_PILE_ID.DefaultValue = "";
            this.coldsInStoreL3DataTableCUR_PILE_ID.Namespace = "";
            // 
            // coldsInStoreL3DataTableCUR_LAYER_ID
            // 
            this.coldsInStoreL3DataTableCUR_LAYER_ID.Caption = "CUR_LAYER_ID";
            this.coldsInStoreL3DataTableCUR_LAYER_ID.ColumnName = "CUR_LAYER_ID";
            this.coldsInStoreL3DataTableCUR_LAYER_ID.Namespace = "";
            // 
            // coldsInStoreL3DataTableCASTERID
            // 
            this.coldsInStoreL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsInStoreL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsInStoreL3DataTableCASTERID.DefaultValue = "";
            this.coldsInStoreL3DataTableCASTERID.Namespace = "";
            // 
            // coldsInStoreL3DataTableSTOREAREAID
            // 
            this.coldsInStoreL3DataTableSTOREAREAID.Caption = "STOREAREAID";
            this.coldsInStoreL3DataTableSTOREAREAID.ColumnName = "STOREAREAID";
            this.coldsInStoreL3DataTableSTOREAREAID.DefaultValue = "";
            this.coldsInStoreL3DataTableSTOREAREAID.Namespace = "";
            // 
            // coldsInStoreL3DataTableSTD
            // 
            this.coldsInStoreL3DataTableSTD.Caption = "STD";
            this.coldsInStoreL3DataTableSTD.ColumnName = "STD";
            this.coldsInStoreL3DataTableSTD.DefaultValue = "";
            this.coldsInStoreL3DataTableSTD.Namespace = "";
            // 
            // coldsInStoreL3DataTableSTEELGRADEINDEX
            // 
            this.coldsInStoreL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsInStoreL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsInStoreL3DataTableSTEELGRADEINDEX.DefaultValue = "";
            this.coldsInStoreL3DataTableSTEELGRADEINDEX.Namespace = "";
            // 
            // coldsInStoreL3DataTableWASTER_COUNT
            // 
            this.coldsInStoreL3DataTableWASTER_COUNT.Caption = "WASTER_COUNT";
            this.coldsInStoreL3DataTableWASTER_COUNT.ColumnName = "WASTER_COUNT";
            this.coldsInStoreL3DataTableWASTER_COUNT.Namespace = "";
            // 
            // coldsInStoreL3DataTableWRONG_COUNT
            // 
            this.coldsInStoreL3DataTableWRONG_COUNT.Caption = "WRONG_COUNT";
            this.coldsInStoreL3DataTableWRONG_COUNT.ColumnName = "WRONG_COUNT";
            this.coldsInStoreL3DataTableWRONG_COUNT.DataType = typeof(int);
            this.coldsInStoreL3DataTableWRONG_COUNT.DefaultValue = 0;
            this.coldsInStoreL3DataTableWRONG_COUNT.Namespace = "";
            // 
            // coldsInStoreL3DataTableRIGHT_COUNT
            // 
            this.coldsInStoreL3DataTableRIGHT_COUNT.Caption = "RIGHT_COUNT";
            this.coldsInStoreL3DataTableRIGHT_COUNT.ColumnName = "RIGHT_COUNT";
            this.coldsInStoreL3DataTableRIGHT_COUNT.DataType = typeof(int);
            this.coldsInStoreL3DataTableRIGHT_COUNT.DefaultValue = 0;
            this.coldsInStoreL3DataTableRIGHT_COUNT.Namespace = "";
            // 
            // coldsInStoreL3DataTableCheckFlag
            // 
            this.coldsInStoreL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsInStoreL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsInStoreL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsInStoreL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsInStoreL3DataTableBloom_Count
            // 
            this.coldsInStoreL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsInStoreL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsInStoreL3DataTableBloom_Count.Namespace = "";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到第一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripSeparator5,
            this.toolStripButton11});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1121, 43);
            this.toolStrip1.TabIndex = 63;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton11.Text = "入库";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1121, 333);
            this.hmiRootPanel1.TabIndex = 64;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn,
            this.sTOREAREAIDDataGridViewTextBoxColumn,
            this.cURPILEIDDataGridViewTextBoxColumn,
            this.cURLAYERIDDataGridViewTextBoxColumn,
            this.cASTERIDDataGridViewTextBoxColumn,
            this.sTDDataGridViewTextBoxColumn,
            this.Bloom_Count,
            this.wASTERCOUNTDataGridViewTextBoxColumn,
            this.wRONGCOUNTDataGridViewTextBoxColumn,
            this.rIGHTCOUNTDataGridViewTextBoxColumn,
            this.mATERIALTYPEDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsInStore;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvInStore.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 0);
            this.dvInStore.Margin = new System.Windows.Forms.Padding(0);
            this.dvInStore.Name = "dvInStore";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(1121, 333);
            this.dvInStore.TabIndex = 18;
            this.dvInStore.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvInStore_CellValueChanged);
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            // 
            // sTEELGRADEINDEXDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADEINDEX";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.sTEELGRADEINDEXDataGridViewTextBoxColumn.Name = "sTEELGRADEINDEXDataGridViewTextBoxColumn";
            // 
            // sTOREAREAIDDataGridViewTextBoxColumn
            // 
            this.sTOREAREAIDDataGridViewTextBoxColumn.DataPropertyName = "STOREAREAID";
            this.sTOREAREAIDDataGridViewTextBoxColumn.DataSource = this.dsStoreAreaID;
            this.sTOREAREAIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTOREAREAIDDataGridViewTextBoxColumn.HeaderText = "库位";
            this.sTOREAREAIDDataGridViewTextBoxColumn.Name = "sTOREAREAIDDataGridViewTextBoxColumn";
            this.sTOREAREAIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTOREAREAIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTOREAREAIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsStoreAreaID
            // 
            this.dsStoreAreaID.AutoSubscribe = true;
            this.dsStoreAreaID.DataSetName = "L3DataSet";
            this.dsStoreAreaID.DeleteMethod = null;
            this.dsStoreAreaID.InsertMethod = null;
            this.dsStoreAreaID.L3DataAdapter = this.Adapter;
            this.dsStoreAreaID.LoadEvent = "Click";
            this.dsStoreAreaID.LoadTrigger = null;
            this.dsStoreAreaID.RefreshValve = 1000;
            this.dsStoreAreaID.SourceCommand = null;
            this.dsStoreAreaID.SourceCondition = "CODE_GROUP = \'BloomArea\'";
            this.dsStoreAreaID.SourceMethod = "";
            this.dsStoreAreaID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreAreaID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreAreaID.SubscribeTarget = null;
            this.dsStoreAreaID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreAreaID});
            this.dsStoreAreaID.UpdateEvent = "Click";
            this.dsStoreAreaID.UpdateMethod = null;
            this.dsStoreAreaID.UpdateTrigger = null;
            // 
            // schemadsStoreAreaID
            // 
            this.schemadsStoreAreaID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreAreaIDL3DataTableCode,
            this.coldsStoreAreaIDL3DataTableCode_Des});
            this.schemadsStoreAreaID.TableName = "L3DataTable";
            // 
            // coldsStoreAreaIDL3DataTableCode
            // 
            this.coldsStoreAreaIDL3DataTableCode.Caption = "Code";
            this.coldsStoreAreaIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreAreaIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreAreaIDL3DataTableCode_Des
            // 
            this.coldsStoreAreaIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.Namespace = "";
            // 
            // cURPILEIDDataGridViewTextBoxColumn
            // 
            this.cURPILEIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_PILE_ID";
            this.cURPILEIDDataGridViewTextBoxColumn.DataSource = this.dsCurPileID;
            this.cURPILEIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cURPILEIDDataGridViewTextBoxColumn.HeaderText = "当前垛";
            this.cURPILEIDDataGridViewTextBoxColumn.Name = "cURPILEIDDataGridViewTextBoxColumn";
            this.cURPILEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cURPILEIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cURPILEIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCurPileID
            // 
            this.dsCurPileID.AutoSubscribe = true;
            this.dsCurPileID.DataSetName = "L3DataSet";
            this.dsCurPileID.DeleteMethod = null;
            this.dsCurPileID.InsertMethod = null;
            this.dsCurPileID.L3DataAdapter = this.Adapter;
            this.dsCurPileID.LoadEvent = "Click";
            this.dsCurPileID.LoadTrigger = null;
            this.dsCurPileID.RefreshValve = 1000;
            this.dsCurPileID.SourceCommand = null;
            this.dsCurPileID.SourceCondition = "CODE_GROUP = \'BLOOM_SPILE\' or CODE_GROUP = \'KEEP_SPILE\' ";
            this.dsCurPileID.SourceMethod = "";
            this.dsCurPileID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCurPileID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCurPileID.SubscribeTarget = null;
            this.dsCurPileID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCurPileID});
            this.dsCurPileID.UpdateEvent = "Click";
            this.dsCurPileID.UpdateMethod = null;
            this.dsCurPileID.UpdateTrigger = null;
            // 
            // schemadsCurPileID
            // 
            this.schemadsCurPileID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCurPileIDL3DataTableCode,
            this.coldsCurPileIDL3DataTableCode_Des});
            this.schemadsCurPileID.TableName = "L3DataTable";
            // 
            // coldsCurPileIDL3DataTableCode
            // 
            this.coldsCurPileIDL3DataTableCode.Caption = "Code";
            this.coldsCurPileIDL3DataTableCode.ColumnName = "Code";
            this.coldsCurPileIDL3DataTableCode.Namespace = "";
            // 
            // coldsCurPileIDL3DataTableCode_Des
            // 
            this.coldsCurPileIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCurPileIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCurPileIDL3DataTableCode_Des.Namespace = "";
            // 
            // cURLAYERIDDataGridViewTextBoxColumn
            // 
            this.cURLAYERIDDataGridViewTextBoxColumn.DataPropertyName = "CUR_LAYER_ID";
            this.cURLAYERIDDataGridViewTextBoxColumn.HeaderText = "当前层";
            this.cURLAYERIDDataGridViewTextBoxColumn.Name = "cURLAYERIDDataGridViewTextBoxColumn";
            // 
            // cASTERIDDataGridViewTextBoxColumn
            // 
            this.cASTERIDDataGridViewTextBoxColumn.DataPropertyName = "CASTERID";
            this.cASTERIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTERIDDataGridViewTextBoxColumn.Name = "cASTERIDDataGridViewTextBoxColumn";
            // 
            // sTDDataGridViewTextBoxColumn
            // 
            this.sTDDataGridViewTextBoxColumn.DataPropertyName = "STD";
            this.sTDDataGridViewTextBoxColumn.HeaderText = "规格";
            this.sTDDataGridViewTextBoxColumn.Name = "sTDDataGridViewTextBoxColumn";
            // 
            // Bloom_Count
            // 
            this.Bloom_Count.DataPropertyName = "Bloom_Count";
            this.Bloom_Count.HeaderText = "钢坯支数";
            this.Bloom_Count.Name = "Bloom_Count";
            // 
            // wASTERCOUNTDataGridViewTextBoxColumn
            // 
            this.wASTERCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WASTER_COUNT";
            this.wASTERCOUNTDataGridViewTextBoxColumn.HeaderText = "甩废钢坯总长度";
            this.wASTERCOUNTDataGridViewTextBoxColumn.Name = "wASTERCOUNTDataGridViewTextBoxColumn";
            // 
            // wRONGCOUNTDataGridViewTextBoxColumn
            // 
            this.wRONGCOUNTDataGridViewTextBoxColumn.DataPropertyName = "WRONG_COUNT";
            this.wRONGCOUNTDataGridViewTextBoxColumn.HeaderText = "不合格钢坯支数";
            this.wRONGCOUNTDataGridViewTextBoxColumn.Name = "wRONGCOUNTDataGridViewTextBoxColumn";
            // 
            // rIGHTCOUNTDataGridViewTextBoxColumn
            // 
            this.rIGHTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "RIGHT_COUNT";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.HeaderText = "合格钢坯支数";
            this.rIGHTCOUNTDataGridViewTextBoxColumn.Name = "rIGHTCOUNTDataGridViewTextBoxColumn";
            // 
            // mATERIALTYPEDataGridViewTextBoxColumn
            // 
            this.mATERIALTYPEDataGridViewTextBoxColumn.DataPropertyName = "MATERIALTYPE";
            this.mATERIALTYPEDataGridViewTextBoxColumn.HeaderText = "入库的材料类型";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Name = "mATERIALTYPEDataGridViewTextBoxColumn";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmdInStore
            // 
            this.cmdInStore.Adapter = this.Adapter;
            this.cmdInStore.MergeReturnTarget = false;
            this.cmdInStore.Method = "BloomColdSendInStore";
            this.cmdInStore.Object = "XGMESLogic\\BloomStoreMag\\CBloom_Store_Mag\\S71";
            this.cmdInStore.Parameters.Add(this.l3CommandParameter2);
            this.cmdInStore.ReturnTarget = null;
            this.cmdInStore.ReturnTargetProperty = null;
            this.cmdInStore.Trigger = null;
            this.cmdInStore.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsInStore;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter1.SourceObject = this.dsInStore;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsCurLayerID
            // 
            this.dsCurLayerID.AutoSubscribe = true;
            this.dsCurLayerID.DataSetName = "L3DataSet";
            this.dsCurLayerID.DeleteMethod = null;
            this.dsCurLayerID.InsertMethod = null;
            this.dsCurLayerID.L3DataAdapter = this.Adapter;
            this.dsCurLayerID.LoadEvent = "Click";
            this.dsCurLayerID.LoadTrigger = null;
            this.dsCurLayerID.RefreshValve = 1000;
            this.dsCurLayerID.SourceCommand = null;
            this.dsCurLayerID.SourceCondition = "CODE_GROUP = \'\'";
            this.dsCurLayerID.SourceMethod = "";
            this.dsCurLayerID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCurLayerID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCurLayerID.SubscribeTarget = null;
            this.dsCurLayerID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCurLayerID});
            this.dsCurLayerID.UpdateEvent = "Click";
            this.dsCurLayerID.UpdateMethod = null;
            this.dsCurLayerID.UpdateTrigger = null;
            // 
            // schemadsCurLayerID
            // 
            this.schemadsCurLayerID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCurLayerIDL3DataTableCode,
            this.coldsCurLayerIDL3DataTableCode_Des});
            this.schemadsCurLayerID.TableName = "L3DataTable";
            // 
            // coldsCurLayerIDL3DataTableCode
            // 
            this.coldsCurLayerIDL3DataTableCode.Caption = "Code";
            this.coldsCurLayerIDL3DataTableCode.ColumnName = "Code";
            this.coldsCurLayerIDL3DataTableCode.Namespace = "";
            // 
            // coldsCurLayerIDL3DataTableCode_Des
            // 
            this.coldsCurLayerIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCurLayerIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCurLayerIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsError
            // 
            this.dsError.AutoSubscribe = false;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = "";
            this.dsError.InsertMethod = "";
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "owner = \'BloomColdSendInStore\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "";
            this.dsError.UpdateMethod = "";
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // BloomInStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 401);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BloomInStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BloomInStoreFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurPileID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurPileID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurLayerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurLayerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsInStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsInStoreL3DataTableAMOUNT;
        private System.Data.DataColumn coldsInStoreL3DataTableMATERIALID;
        private System.Data.DataColumn coldsInStoreL3DataTableCUR_PILE_ID;
        private System.Data.DataColumn coldsInStoreL3DataTableCUR_LAYER_ID;
        private System.Data.DataColumn coldsInStoreL3DataTableCASTERID;
        private System.Data.DataColumn coldsInStoreL3DataTableSTOREAREAID;
        private System.Data.DataColumn coldsInStoreL3DataTableSTD;
        private System.Data.DataColumn coldsInStoreL3DataTableSTEELGRADEINDEX;
        private System.Windows.Forms.BindingSource bsInStore;
        private AppSvrHMI.L3Command cmdInStore;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsCurPileID;
        private AppSvrHMI.L3DataSet dsCurLayerID;
        private AppSvrHMI.L3DataSet dsStoreAreaID;
        private System.Data.DataTable schemadsCurPileID;
        private System.Data.DataColumn coldsCurPileIDL3DataTableCode;
        private System.Data.DataColumn coldsCurPileIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsCurLayerID;
        private System.Data.DataColumn coldsCurLayerIDL3DataTableCode;
        private System.Data.DataColumn coldsCurLayerIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsStoreAreaID;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsInStoreL3DataTableWASTER_COUNT;
        private System.Data.DataColumn coldsInStoreL3DataTableWRONG_COUNT;
        private System.Data.DataColumn coldsInStoreL3DataTableRIGHT_COUNT;
        private System.Data.DataColumn coldsInStoreL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataColumn coldsInStoreL3DataTableBloom_Count;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEINDEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTOREAREAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cURPILEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURLAYERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTERCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRONGCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rIGHTCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;

    }
}