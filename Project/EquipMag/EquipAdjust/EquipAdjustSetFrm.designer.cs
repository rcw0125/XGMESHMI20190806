namespace EquipMag.EquipAdjust
{
    partial class EquipAdjustSetFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipAdjustSetFrm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsAdjustSet = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustSet = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLocation = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLocation_Des = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableMeter = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableMeter_Size = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableRange = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTablePrecision = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableFactory = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableMeasure_ID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableStandard_Equ = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableScale_Min = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvAdjustSet = new System.Windows.Forms.DataGridView();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.dsLocation = new AppSvrHMI.L3DataSet();
            this.dsLocation_Des = new AppSvrHMI.L3DataSet();
            this.schemadsLocation = new System.Data.DataTable();
            this.coldsLocationL3DataTableCode = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Group = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardEquDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scaleMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1000, 43);
            this.toolStripMain.TabIndex = 15;
            this.toolStripMain.Text = "toolStrip1";
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnEquipAdjustSet");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnEquipAdjustSet");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnEquipAdjustSet");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnEquipAdjustSet");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsAdjustSet;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsAdjustSet
            // 
            this.bsAdjustSet.DataMember = "L3DataTable";
            this.bsAdjustSet.DataSource = this.dsAdjustSet;
            // 
            // dsAdjustSet
            // 
            this.dsAdjustSet.AutoSubscribe = false;
            this.dsAdjustSet.DataSetName = "L3DataSet";
            this.dsAdjustSet.DeleteMethod = "";
            this.dsAdjustSet.InsertMethod = "";
            this.dsAdjustSet.L3DataAdapter = this.Adapter;
            this.dsAdjustSet.LoadEvent = "";
            this.dsAdjustSet.LoadTrigger = null;
            this.dsAdjustSet.RefreshValve = 1000;
            this.dsAdjustSet.SourceCommand = null;
            this.dsAdjustSet.SourceCondition = "Location is not null order by Location";
            this.dsAdjustSet.SourceMethod = "";
            this.dsAdjustSet.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustSet.SourceURI = "XGMESLogic\\EquipMag\\CCalibration_Set";
            this.dsAdjustSet.SubscribeTarget = null;
            this.dsAdjustSet.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsAdjustSet.UpdateEvent = "";
            this.dsAdjustSet.UpdateMethod = "";
            this.dsAdjustSet.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsIronLadleL3DataTableLocation,
            this.coldsIronLadleL3DataTableLocation_Des,
            this.coldsIronLadleL3DataTableMeter,
            this.coldsIronLadleL3DataTableMeter_Size,
            this.coldsIronLadleL3DataTableRange,
            this.coldsIronLadleL3DataTablePrecision,
            this.coldsIronLadleL3DataTableFactory,
            this.coldsIronLadleL3DataTableMeasure_ID,
            this.coldsIronLadleL3DataTableStandard_Equ,
            this.coldsIronLadleL3DataTableScale_Min});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableGUID
            // 
            this.coldsEnergyDataL3DataTableGUID.Caption = "GUID";
            this.coldsEnergyDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsEnergyDataL3DataTableGUID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableName
            // 
            this.coldsEnergyDataL3DataTableName.Caption = "Name";
            this.coldsEnergyDataL3DataTableName.ColumnName = "Name";
            this.coldsEnergyDataL3DataTableName.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLocation
            // 
            this.coldsIronLadleL3DataTableLocation.Caption = "Location";
            this.coldsIronLadleL3DataTableLocation.ColumnName = "Location";
            this.coldsIronLadleL3DataTableLocation.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLocation_Des
            // 
            this.coldsIronLadleL3DataTableLocation_Des.Caption = "Location_Des";
            this.coldsIronLadleL3DataTableLocation_Des.ColumnName = "Location_Des";
            this.coldsIronLadleL3DataTableLocation_Des.Namespace = "";
            // 
            // coldsIronLadleL3DataTableMeter
            // 
            this.coldsIronLadleL3DataTableMeter.Caption = "Meter";
            this.coldsIronLadleL3DataTableMeter.ColumnName = "Meter";
            this.coldsIronLadleL3DataTableMeter.Namespace = "";
            // 
            // coldsIronLadleL3DataTableMeter_Size
            // 
            this.coldsIronLadleL3DataTableMeter_Size.Caption = "Meter_Size";
            this.coldsIronLadleL3DataTableMeter_Size.ColumnName = "Meter_Size";
            this.coldsIronLadleL3DataTableMeter_Size.Namespace = "";
            // 
            // coldsIronLadleL3DataTableRange
            // 
            this.coldsIronLadleL3DataTableRange.Caption = "Range";
            this.coldsIronLadleL3DataTableRange.ColumnName = "Range";
            this.coldsIronLadleL3DataTableRange.Namespace = "";
            // 
            // coldsIronLadleL3DataTablePrecision
            // 
            this.coldsIronLadleL3DataTablePrecision.Caption = "Precision";
            this.coldsIronLadleL3DataTablePrecision.ColumnName = "Precision";
            this.coldsIronLadleL3DataTablePrecision.Namespace = "";
            // 
            // coldsIronLadleL3DataTableFactory
            // 
            this.coldsIronLadleL3DataTableFactory.Caption = "Factory";
            this.coldsIronLadleL3DataTableFactory.ColumnName = "Factory";
            this.coldsIronLadleL3DataTableFactory.Namespace = "";
            // 
            // coldsIronLadleL3DataTableMeasure_ID
            // 
            this.coldsIronLadleL3DataTableMeasure_ID.Caption = "Measure_ID";
            this.coldsIronLadleL3DataTableMeasure_ID.ColumnName = "Measure_ID";
            this.coldsIronLadleL3DataTableMeasure_ID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableStandard_Equ
            // 
            this.coldsIronLadleL3DataTableStandard_Equ.Caption = "Standard_Equ";
            this.coldsIronLadleL3DataTableStandard_Equ.ColumnName = "Standard_Equ";
            this.coldsIronLadleL3DataTableStandard_Equ.Namespace = "";
            // 
            // coldsIronLadleL3DataTableScale_Min
            // 
            this.coldsIronLadleL3DataTableScale_Min.Caption = "Scale_Min";
            this.coldsIronLadleL3DataTableScale_Min.ColumnName = "Scale_Min";
            this.coldsIronLadleL3DataTableScale_Min.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // dvAdjustSet
            // 
            this.dvAdjustSet.AllowUserToAddRows = false;
            this.dvAdjustSet.AllowUserToDeleteRows = false;
            this.dvAdjustSet.AllowUserToResizeRows = false;
            this.dvAdjustSet.AutoGenerateColumns = false;
            this.dvAdjustSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvAdjustSet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAdjustSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAdjustSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.locationDesDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.meterSizeDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn,
            this.precisionDataGridViewTextBoxColumn,
            this.factoryDataGridViewTextBoxColumn,
            this.measureIDDataGridViewTextBoxColumn,
            this.standardEquDataGridViewTextBoxColumn,
            this.scaleMinDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvAdjustSet.DataSource = this.bsAdjustSet;
            this.dvAdjustSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAdjustSet.Location = new System.Drawing.Point(0, 68);
            this.dvAdjustSet.MultiSelect = false;
            this.dvAdjustSet.Name = "dvAdjustSet";
            this.dvAdjustSet.RowTemplate.Height = 23;
            this.dvAdjustSet.Size = new System.Drawing.Size(1000, 532);
            this.dvAdjustSet.TabIndex = 20;
            this.dvAdjustSet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAdjustSet_DataError);
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
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // dsLocation
            // 
            this.dsLocation.AutoSubscribe = false;
            this.dsLocation.DataSetName = "L3DataSet";
            this.dsLocation.DeleteMethod = "";
            this.dsLocation.InsertMethod = "";
            this.dsLocation.L3DataAdapter = this.Adapter;
            this.dsLocation.LoadEvent = "Click";
            this.dsLocation.LoadTrigger = null;
            this.dsLocation.RefreshValve = 1000;
            this.dsLocation.SourceCommand = null;
            this.dsLocation.SourceCondition = "Code_Group = \'Location\' order by Code";
            this.dsLocation.SourceMethod = "";
            this.dsLocation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation.SubscribeTarget = "";
            this.dsLocation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLocation});
            this.dsLocation.UpdateEvent = "Click";
            this.dsLocation.UpdateMethod = "";
            this.dsLocation.UpdateTrigger = null;
            // 
            // dsLocation_Des
            // 
            this.dsLocation_Des.AutoSubscribe = false;
            this.dsLocation_Des.DataSetName = "L3DataSet";
            this.dsLocation_Des.DeleteMethod = "";
            this.dsLocation_Des.InsertMethod = "";
            this.dsLocation_Des.L3DataAdapter = this.Adapter;
            this.dsLocation_Des.LoadEvent = "Click";
            this.dsLocation_Des.LoadTrigger = null;
            this.dsLocation_Des.RefreshValve = 1000;
            this.dsLocation_Des.SourceCommand = null;
            this.dsLocation_Des.SourceCondition = "Code_Group = \'Location_Des\' order by Code";
            this.dsLocation_Des.SourceMethod = "";
            this.dsLocation_Des.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation_Des.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation_Des.SubscribeTarget = "";
            this.dsLocation_Des.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsLocation_Des.UpdateEvent = "Click";
            this.dsLocation_Des.UpdateMethod = "";
            this.dsLocation_Des.UpdateTrigger = null;
            // 
            // schemadsLocation
            // 
            this.schemadsLocation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLocationL3DataTableCode,
            this.coldsLocationL3DataTableCode_Des,
            this.coldsLocationL3DataTableCode_Group,
            this.coldsLocationL3DataTableCode_Group_Des});
            this.schemadsLocation.TableName = "L3DataTable";
            // 
            // coldsLocationL3DataTableCode
            // 
            this.coldsLocationL3DataTableCode.Caption = "Code";
            this.coldsLocationL3DataTableCode.ColumnName = "Code";
            this.coldsLocationL3DataTableCode.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Des
            // 
            this.coldsLocationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group
            // 
            this.coldsLocationL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group_Des
            // 
            this.coldsLocationL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.Namespace = "";
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode,
            this.coll3DataSet1L3DataTableCode_Des,
            this.coll3DataSet1L3DataTableCode_Group,
            this.coll3DataSet1L3DataTableCode_Group_Des});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode
            // 
            this.coll3DataSet1L3DataTableCode.Caption = "Code";
            this.coll3DataSet1L3DataTableCode.ColumnName = "Code";
            this.coll3DataSet1L3DataTableCode.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Group
            // 
            this.coll3DataSet1L3DataTableCode_Group.Caption = "Code_Group";
            this.coll3DataSet1L3DataTableCode_Group.ColumnName = "Code_Group";
            this.coll3DataSet1L3DataTableCode_Group.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Group_Des
            // 
            this.coll3DataSet1L3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coll3DataSet1L3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coll3DataSet1L3DataTableCode_Group_Des.Namespace = "";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.DataSource = this.dsLocation;
            this.locationDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.locationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.locationDataGridViewTextBoxColumn.HeaderText = "处所";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.locationDataGridViewTextBoxColumn.Width = 54;
            // 
            // locationDesDataGridViewTextBoxColumn
            // 
            this.locationDesDataGridViewTextBoxColumn.DataPropertyName = "Location_Des";
            this.locationDesDataGridViewTextBoxColumn.DataSource = this.dsLocation_Des;
            this.locationDesDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.locationDesDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.locationDesDataGridViewTextBoxColumn.HeaderText = "处所描述";
            this.locationDesDataGridViewTextBoxColumn.Name = "locationDesDataGridViewTextBoxColumn";
            this.locationDesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationDesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationDesDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.locationDesDataGridViewTextBoxColumn.Width = 78;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "仪表名称";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.Width = 78;
            // 
            // meterSizeDataGridViewTextBoxColumn
            // 
            this.meterSizeDataGridViewTextBoxColumn.DataPropertyName = "Meter_Size";
            this.meterSizeDataGridViewTextBoxColumn.HeaderText = "仪表型号";
            this.meterSizeDataGridViewTextBoxColumn.Name = "meterSizeDataGridViewTextBoxColumn";
            this.meterSizeDataGridViewTextBoxColumn.Width = 78;
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "测量范围";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.Width = 78;
            // 
            // precisionDataGridViewTextBoxColumn
            // 
            this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
            this.precisionDataGridViewTextBoxColumn.HeaderText = "准确度";
            this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
            this.precisionDataGridViewTextBoxColumn.Width = 66;
            // 
            // factoryDataGridViewTextBoxColumn
            // 
            this.factoryDataGridViewTextBoxColumn.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn.HeaderText = "厂家";
            this.factoryDataGridViewTextBoxColumn.Name = "factoryDataGridViewTextBoxColumn";
            this.factoryDataGridViewTextBoxColumn.Width = 54;
            // 
            // measureIDDataGridViewTextBoxColumn
            // 
            this.measureIDDataGridViewTextBoxColumn.DataPropertyName = "Measure_ID";
            this.measureIDDataGridViewTextBoxColumn.HeaderText = "计量编号";
            this.measureIDDataGridViewTextBoxColumn.Name = "measureIDDataGridViewTextBoxColumn";
            this.measureIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // standardEquDataGridViewTextBoxColumn
            // 
            this.standardEquDataGridViewTextBoxColumn.DataPropertyName = "Standard_Equ";
            this.standardEquDataGridViewTextBoxColumn.HeaderText = "标准器";
            this.standardEquDataGridViewTextBoxColumn.Name = "standardEquDataGridViewTextBoxColumn";
            this.standardEquDataGridViewTextBoxColumn.Width = 66;
            // 
            // scaleMinDataGridViewTextBoxColumn
            // 
            this.scaleMinDataGridViewTextBoxColumn.DataPropertyName = "Scale_Min";
            this.scaleMinDataGridViewTextBoxColumn.HeaderText = "最小分度值";
            this.scaleMinDataGridViewTextBoxColumn.Name = "scaleMinDataGridViewTextBoxColumn";
            this.scaleMinDataGridViewTextBoxColumn.Width = 90;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // EquipAdjustSetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvAdjustSet);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipAdjustSetFrm";
            this.TabText = "称重设备校准设置";
            this.Text = "称重设备校准设置";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvAdjustSet;
        private AppSvrHMI.L3DataSet dsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsIronLadleL3DataTableLocation;
        private System.Data.DataColumn coldsIronLadleL3DataTableLocation_Des;
        private System.Data.DataColumn coldsIronLadleL3DataTableMeter;
        private System.Data.DataColumn coldsIronLadleL3DataTableMeter_Size;
        private System.Data.DataColumn coldsIronLadleL3DataTableRange;
        private System.Data.DataColumn coldsIronLadleL3DataTablePrecision;
        private System.Data.DataColumn coldsIronLadleL3DataTableFactory;
        private System.Data.DataColumn coldsIronLadleL3DataTableMeasure_ID;
        private System.Data.DataColumn coldsIronLadleL3DataTableStandard_Equ;
        private System.Data.DataColumn coldsIronLadleL3DataTableScale_Min;
        private AppSvrHMI.L3DataSet dsLocation;
        private System.Data.DataTable schemadsLocation;
        private System.Data.DataColumn coldsLocationL3DataTableCode;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Des;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group_Des;
        private AppSvrHMI.L3DataSet dsLocation_Des;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Group;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardEquDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scaleMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}