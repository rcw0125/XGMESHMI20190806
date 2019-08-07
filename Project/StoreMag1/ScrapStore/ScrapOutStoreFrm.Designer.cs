namespace StoreMag.ScrapStore
{
    partial class ScrapOutStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapOutStoreFrm));
            this.bsScrapOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapOutStore = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsPlan = new System.Data.DataTable();
            this.coldsScrapOutStoreL3DataTableNo = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableType = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableReason = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableTarget = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableShift = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableTeam = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableCar_ID = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableCar_Type = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableTare_Weight = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableIron_Flag = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsScrapOutStoreL3DataTableCheckFlag = new System.Data.DataColumn();
            this.cmdScrapOutStore = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvScrapOutStore = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapSlotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapOutStore)).BeginInit();
            this.SuspendLayout();
            // 
            // bsScrapOutStore
            // 
            this.bsScrapOutStore.DataMember = "L3DataTable";
            this.bsScrapOutStore.DataSource = this.dsScrapOutStore;
            // 
            // dsScrapOutStore
            // 
            this.dsScrapOutStore.AutoLoad = true;
            this.dsScrapOutStore.AutoSubscribe = true;
            this.dsScrapOutStore.DataSetName = "L3DataSet1";
            this.dsScrapOutStore.DeleteMethod = "";
            this.dsScrapOutStore.InsertMethod = "";
            this.dsScrapOutStore.L3DataAdapter = this.Adapter;
            this.dsScrapOutStore.LoadEvent = "Click";
            this.dsScrapOutStore.LoadTrigger = null;
            this.dsScrapOutStore.RefreshValve = 1000;
            this.dsScrapOutStore.SourceCommand = null;
            this.dsScrapOutStore.SourceCondition = "";
            this.dsScrapOutStore.SourceMethod = "";
            this.dsScrapOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapOutStore.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Output_Log";
            this.dsScrapOutStore.SubscribeTarget = "";
            this.dsScrapOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPlan});
            this.dsScrapOutStore.UpdateEvent = "Click";
            this.dsScrapOutStore.UpdateMethod = "";
            this.dsScrapOutStore.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsPlan
            // 
            this.schemadsPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapOutStoreL3DataTableNo,
            this.coldsScrapOutStoreL3DataTableMaterialType,
            this.coldsScrapOutStoreL3DataTableMaterialID,
            this.coldsScrapOutStoreL3DataTableLogDate,
            this.coldsScrapOutStoreL3DataTableAmount,
            this.coldsScrapOutStoreL3DataTableType,
            this.coldsScrapOutStoreL3DataTableReason,
            this.coldsScrapOutStoreL3DataTableTarget,
            this.coldsScrapOutStoreL3DataTableStoreAreaID,
            this.coldsScrapOutStoreL3DataTableOperator,
            this.coldsScrapOutStoreL3DataTableShift,
            this.coldsScrapOutStoreL3DataTableTeam,
            this.coldsScrapOutStoreL3DataTableScrap_Slot_ID,
            this.coldsScrapOutStoreL3DataTableCar_ID,
            this.coldsScrapOutStoreL3DataTableCar_Type,
            this.coldsScrapOutStoreL3DataTableNet_Weight,
            this.coldsScrapOutStoreL3DataTableGross_Weight,
            this.coldsScrapOutStoreL3DataTableTare_Weight,
            this.coldsScrapOutStoreL3DataTableIron_Flag,
            this.coldsScrapOutStoreL3DataTableHeatID,
            this.coldsScrapOutStoreL3DataTableCheckFlag});
            this.schemadsPlan.TableName = "L3DataTable";
            // 
            // coldsScrapOutStoreL3DataTableNo
            // 
            this.coldsScrapOutStoreL3DataTableNo.Caption = "No";
            this.coldsScrapOutStoreL3DataTableNo.ColumnName = "No";
            this.coldsScrapOutStoreL3DataTableNo.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableMaterialType
            // 
            this.coldsScrapOutStoreL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsScrapOutStoreL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsScrapOutStoreL3DataTableMaterialType.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableMaterialID
            // 
            this.coldsScrapOutStoreL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsScrapOutStoreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsScrapOutStoreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableLogDate
            // 
            this.coldsScrapOutStoreL3DataTableLogDate.Caption = "LogDate";
            this.coldsScrapOutStoreL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsScrapOutStoreL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsScrapOutStoreL3DataTableLogDate.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableAmount
            // 
            this.coldsScrapOutStoreL3DataTableAmount.Caption = "Amount";
            this.coldsScrapOutStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsScrapOutStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsScrapOutStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableType
            // 
            this.coldsScrapOutStoreL3DataTableType.Caption = "Type";
            this.coldsScrapOutStoreL3DataTableType.ColumnName = "Type";
            this.coldsScrapOutStoreL3DataTableType.DataType = typeof(int);
            this.coldsScrapOutStoreL3DataTableType.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableReason
            // 
            this.coldsScrapOutStoreL3DataTableReason.Caption = "Reason";
            this.coldsScrapOutStoreL3DataTableReason.ColumnName = "Reason";
            this.coldsScrapOutStoreL3DataTableReason.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableTarget
            // 
            this.coldsScrapOutStoreL3DataTableTarget.Caption = "Target";
            this.coldsScrapOutStoreL3DataTableTarget.ColumnName = "Target";
            this.coldsScrapOutStoreL3DataTableTarget.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableStoreAreaID
            // 
            this.coldsScrapOutStoreL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsScrapOutStoreL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsScrapOutStoreL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableOperator
            // 
            this.coldsScrapOutStoreL3DataTableOperator.Caption = "Operator";
            this.coldsScrapOutStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsScrapOutStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableShift
            // 
            this.coldsScrapOutStoreL3DataTableShift.Caption = "Shift";
            this.coldsScrapOutStoreL3DataTableShift.ColumnName = "Shift";
            this.coldsScrapOutStoreL3DataTableShift.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableTeam
            // 
            this.coldsScrapOutStoreL3DataTableTeam.Caption = "Team";
            this.coldsScrapOutStoreL3DataTableTeam.ColumnName = "Team";
            this.coldsScrapOutStoreL3DataTableTeam.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableScrap_Slot_ID
            // 
            this.coldsScrapOutStoreL3DataTableScrap_Slot_ID.Caption = "Scrap_Slot_ID";
            this.coldsScrapOutStoreL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsScrapOutStoreL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableCar_ID
            // 
            this.coldsScrapOutStoreL3DataTableCar_ID.Caption = "Car_ID";
            this.coldsScrapOutStoreL3DataTableCar_ID.ColumnName = "Car_ID";
            this.coldsScrapOutStoreL3DataTableCar_ID.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableCar_Type
            // 
            this.coldsScrapOutStoreL3DataTableCar_Type.Caption = "Car_Type";
            this.coldsScrapOutStoreL3DataTableCar_Type.ColumnName = "Car_Type";
            this.coldsScrapOutStoreL3DataTableCar_Type.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableNet_Weight
            // 
            this.coldsScrapOutStoreL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsScrapOutStoreL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsScrapOutStoreL3DataTableNet_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableGross_Weight
            // 
            this.coldsScrapOutStoreL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsScrapOutStoreL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsScrapOutStoreL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableTare_Weight
            // 
            this.coldsScrapOutStoreL3DataTableTare_Weight.Caption = "Tare_Weight";
            this.coldsScrapOutStoreL3DataTableTare_Weight.ColumnName = "Tare_Weight";
            this.coldsScrapOutStoreL3DataTableTare_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreL3DataTableTare_Weight.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableIron_Flag
            // 
            this.coldsScrapOutStoreL3DataTableIron_Flag.Caption = "Iron_Flag";
            this.coldsScrapOutStoreL3DataTableIron_Flag.ColumnName = "Iron_Flag";
            this.coldsScrapOutStoreL3DataTableIron_Flag.DataType = typeof(int);
            this.coldsScrapOutStoreL3DataTableIron_Flag.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableHeatID
            // 
            this.coldsScrapOutStoreL3DataTableHeatID.Caption = "HeatID";
            this.coldsScrapOutStoreL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsScrapOutStoreL3DataTableHeatID.Namespace = "";
            // 
            // coldsScrapOutStoreL3DataTableCheckFlag
            // 
            this.coldsScrapOutStoreL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsScrapOutStoreL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsScrapOutStoreL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsScrapOutStoreL3DataTableCheckFlag.Namespace = "";
            // 
            // cmdScrapOutStore
            // 
            this.cmdScrapOutStore.Adapter = this.Adapter;
            this.cmdScrapOutStore.MergeReturnTarget = false;
            this.cmdScrapOutStore.Method = "ScrapOutStore";
            this.cmdScrapOutStore.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdScrapOutStore.Parameters.Add(this.l3CommandParameter2);
            this.cmdScrapOutStore.ReturnTarget = null;
            this.cmdScrapOutStore.ReturnTargetProperty = null;
            this.cmdScrapOutStore.Trigger = null;
            this.cmdScrapOutStore.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsScrapOutStore;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsScrapOutStore;
            this.l3CommandParameter1.SourceProperty = "Added";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
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
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsScrapOutStore;
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
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "　　　　　";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvScrapOutStore);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 31;
            // 
            // dvScrapOutStore
            // 
            this.dvScrapOutStore.AllowUserToAddRows = false;
            this.dvScrapOutStore.AutoGenerateColumns = false;
            this.dvScrapOutStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvScrapOutStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvScrapOutStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.scrapSlotIDDataGridViewTextBoxColumn,
            this.carIDDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.tareWeightDataGridViewTextBoxColumn});
            this.dvScrapOutStore.DataSource = this.bsScrapOutStore;
            this.dvScrapOutStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvScrapOutStore.Location = new System.Drawing.Point(0, 0);
            this.dvScrapOutStore.Name = "dvScrapOutStore";
            this.dvScrapOutStore.RowHeadersVisible = false;
            this.dvScrapOutStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvScrapOutStore.RowTemplate.Height = 23;
            this.dvScrapOutStore.Size = new System.Drawing.Size(1000, 632);
            this.dvScrapOutStore.TabIndex = 0;
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
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "出库的材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "出库的材料编码";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "出库量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "出库地";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scrapSlotIDDataGridViewTextBoxColumn
            // 
            this.scrapSlotIDDataGridViewTextBoxColumn.DataPropertyName = "Scrap_Slot_ID";
            this.scrapSlotIDDataGridViewTextBoxColumn.HeaderText = "废钢斗号";
            this.scrapSlotIDDataGridViewTextBoxColumn.Name = "scrapSlotIDDataGridViewTextBoxColumn";
            this.scrapSlotIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "Car_ID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "车号";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            this.carIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "Car_Type";
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "拖车类型";
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            this.carTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "净重";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tareWeightDataGridViewTextBoxColumn
            // 
            this.tareWeightDataGridViewTextBoxColumn.DataPropertyName = "Tare_Weight";
            this.tareWeightDataGridViewTextBoxColumn.HeaderText = "皮重";
            this.tareWeightDataGridViewTextBoxColumn.Name = "tareWeightDataGridViewTextBoxColumn";
            this.tareWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ScrapOutStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.Name = "ScrapOutStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "出库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapOutStoreFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvScrapOutStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsScrapOutStore;
        private System.Windows.Forms.BindingSource bsScrapOutStore;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvScrapOutStore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private AppSvrHMI.L3Command cmdScrapOutStore;
        private System.Data.DataTable schemadsPlan;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableNo;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableMaterialType;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableMaterialID;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableLogDate;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableAmount;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableType;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableReason;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableTarget;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableOperator;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableShift;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableTeam;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableScrap_Slot_ID;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableCar_ID;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableCar_Type;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableNet_Weight;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableGross_Weight;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableTare_Weight;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableIron_Flag;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableHeatID;
        private System.Data.DataColumn coldsScrapOutStoreL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapSlotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareWeightDataGridViewTextBoxColumn;
    }
}