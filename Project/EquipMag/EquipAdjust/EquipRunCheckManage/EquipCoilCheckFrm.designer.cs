namespace EquipMag.EquipAdjust.EquipRunCheckManage
{
    partial class EquipCoilCheckFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipCoilCheckFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.coldsAdjustSetL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCoilNo = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableInsulating = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableElec_Intensity_Std = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableElec_Intensity_Act = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCheck_Date = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCreate_Time = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableOperator = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableStatus = new System.Data.DataColumn();
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
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.dsAdjustStd = new AppSvrHMI.L3DataSet();
            this.schemadsAdjustStd = new System.Data.DataTable();
            this.coldsAdjustStdL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableAdjustType = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableAdjustObject = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableItems = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableStandard = new System.Data.DataColumn();
            this.coldsAdjustStdL3DataTableValidFlag = new System.Data.DataColumn();
            this.dvAdjustSet = new System.Windows.Forms.DataGridView();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.dsAdjustObject = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.schemadsAdjustObject = new System.Data.DataTable();
            this.coldsAdjustObjectL3DataTableCode = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDesc = new System.Data.DataColumn();
            this.cCMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.strandNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.coilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insulatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elecIntensityStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elecIntensityActDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
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
            this.Adapter.SetAccessRight(this.btnAdd, "btnEquipCoilCheck");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnEquipCoilCheck");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnEquipCoilCheck");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnEquipCoilCheck");
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
            this.dsAdjustSet.SourceCondition = "CCMID is not null order by CCMID,StrandNo";
            this.dsAdjustSet.SourceMethod = "";
            this.dsAdjustSet.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustSet.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Coil_Log";
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
            this.coldsAdjustSetL3DataTableCCMID,
            this.coldsAdjustSetL3DataTableStrandNo,
            this.coldsAdjustSetL3DataTableCoilNo,
            this.coldsAdjustSetL3DataTableInsulating,
            this.coldsAdjustSetL3DataTableElec_Intensity_Std,
            this.coldsAdjustSetL3DataTableElec_Intensity_Act,
            this.coldsAdjustSetL3DataTableCheck_Date,
            this.coldsAdjustSetL3DataTableCreate_Time,
            this.coldsAdjustSetL3DataTableOperator,
            this.coldsAdjustSetL3DataTableStatus});
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
            // coldsAdjustSetL3DataTableCCMID
            // 
            this.coldsAdjustSetL3DataTableCCMID.Caption = "CCMID";
            this.coldsAdjustSetL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsAdjustSetL3DataTableCCMID.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableStrandNo
            // 
            this.coldsAdjustSetL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsAdjustSetL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsAdjustSetL3DataTableStrandNo.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCoilNo
            // 
            this.coldsAdjustSetL3DataTableCoilNo.Caption = "CoilNo";
            this.coldsAdjustSetL3DataTableCoilNo.ColumnName = "CoilNo";
            this.coldsAdjustSetL3DataTableCoilNo.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableInsulating
            // 
            this.coldsAdjustSetL3DataTableInsulating.Caption = "Insulating";
            this.coldsAdjustSetL3DataTableInsulating.ColumnName = "Insulating";
            this.coldsAdjustSetL3DataTableInsulating.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableElec_Intensity_Std
            // 
            this.coldsAdjustSetL3DataTableElec_Intensity_Std.Caption = "Elec_Intensity_Std";
            this.coldsAdjustSetL3DataTableElec_Intensity_Std.ColumnName = "Elec_Intensity_Std";
            this.coldsAdjustSetL3DataTableElec_Intensity_Std.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableElec_Intensity_Act
            // 
            this.coldsAdjustSetL3DataTableElec_Intensity_Act.Caption = "Elec_Intensity_Act";
            this.coldsAdjustSetL3DataTableElec_Intensity_Act.ColumnName = "Elec_Intensity_Act";
            this.coldsAdjustSetL3DataTableElec_Intensity_Act.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCheck_Date
            // 
            this.coldsAdjustSetL3DataTableCheck_Date.Caption = "Check_Date";
            this.coldsAdjustSetL3DataTableCheck_Date.ColumnName = "Check_Date";
            this.coldsAdjustSetL3DataTableCheck_Date.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableCheck_Date.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCreate_Time
            // 
            this.coldsAdjustSetL3DataTableCreate_Time.Caption = "Create_Time";
            this.coldsAdjustSetL3DataTableCreate_Time.ColumnName = "Create_Time";
            this.coldsAdjustSetL3DataTableCreate_Time.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableCreate_Time.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableOperator
            // 
            this.coldsAdjustSetL3DataTableOperator.Caption = "Operator";
            this.coldsAdjustSetL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdjustSetL3DataTableOperator.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableStatus
            // 
            this.coldsAdjustSetL3DataTableStatus.Caption = "Status";
            this.coldsAdjustSetL3DataTableStatus.ColumnName = "Status";
            this.coldsAdjustSetL3DataTableStatus.DataType = typeof(int);
            this.coldsAdjustSetL3DataTableStatus.Namespace = "";
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
            // dsAdjustStd
            // 
            this.dsAdjustStd.AutoSubscribe = false;
            this.dsAdjustStd.DataSetName = "L3DataSet";
            this.dsAdjustStd.DeleteMethod = "";
            this.dsAdjustStd.InsertMethod = "";
            this.dsAdjustStd.L3DataAdapter = this.Adapter;
            this.dsAdjustStd.LoadEvent = "Click";
            this.dsAdjustStd.LoadTrigger = null;
            this.dsAdjustStd.RefreshValve = 1000;
            this.dsAdjustStd.SourceCommand = null;
            this.dsAdjustStd.SourceCondition = "";
            this.dsAdjustStd.SourceMethod = "";
            this.dsAdjustStd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustStd.SourceURI = "XGMESLogic\\EquipMag\\CEupip_Adjust_Std";
            this.dsAdjustStd.SubscribeTarget = "";
            this.dsAdjustStd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdjustStd});
            this.dsAdjustStd.UpdateEvent = "Click";
            this.dsAdjustStd.UpdateMethod = "";
            this.dsAdjustStd.UpdateTrigger = null;
            // 
            // schemadsAdjustStd
            // 
            this.schemadsAdjustStd.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustStdL3DataTableGUID,
            this.coldsAdjustStdL3DataTableName,
            this.coldsAdjustStdL3DataTableAdjustType,
            this.coldsAdjustStdL3DataTableUnitID,
            this.coldsAdjustStdL3DataTableAdjustObject,
            this.coldsAdjustStdL3DataTableItems,
            this.coldsAdjustStdL3DataTableStandard,
            this.coldsAdjustStdL3DataTableValidFlag});
            this.schemadsAdjustStd.TableName = "L3DataTable";
            // 
            // coldsAdjustStdL3DataTableGUID
            // 
            this.coldsAdjustStdL3DataTableGUID.Caption = "GUID";
            this.coldsAdjustStdL3DataTableGUID.ColumnName = "GUID";
            this.coldsAdjustStdL3DataTableGUID.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableName
            // 
            this.coldsAdjustStdL3DataTableName.Caption = "Name";
            this.coldsAdjustStdL3DataTableName.ColumnName = "Name";
            this.coldsAdjustStdL3DataTableName.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableAdjustType
            // 
            this.coldsAdjustStdL3DataTableAdjustType.Caption = "AdjustType";
            this.coldsAdjustStdL3DataTableAdjustType.ColumnName = "AdjustType";
            this.coldsAdjustStdL3DataTableAdjustType.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableUnitID
            // 
            this.coldsAdjustStdL3DataTableUnitID.Caption = "UnitID";
            this.coldsAdjustStdL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsAdjustStdL3DataTableUnitID.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableAdjustObject
            // 
            this.coldsAdjustStdL3DataTableAdjustObject.Caption = "AdjustObject";
            this.coldsAdjustStdL3DataTableAdjustObject.ColumnName = "AdjustObject";
            this.coldsAdjustStdL3DataTableAdjustObject.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableItems
            // 
            this.coldsAdjustStdL3DataTableItems.Caption = "Items";
            this.coldsAdjustStdL3DataTableItems.ColumnName = "Items";
            this.coldsAdjustStdL3DataTableItems.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableStandard
            // 
            this.coldsAdjustStdL3DataTableStandard.Caption = "Standard";
            this.coldsAdjustStdL3DataTableStandard.ColumnName = "Standard";
            this.coldsAdjustStdL3DataTableStandard.Namespace = "";
            // 
            // coldsAdjustStdL3DataTableValidFlag
            // 
            this.coldsAdjustStdL3DataTableValidFlag.Caption = "ValidFlag";
            this.coldsAdjustStdL3DataTableValidFlag.ColumnName = "ValidFlag";
            this.coldsAdjustStdL3DataTableValidFlag.DataType = typeof(int);
            this.coldsAdjustStdL3DataTableValidFlag.Namespace = "";
            // 
            // dvAdjustSet
            // 
            this.dvAdjustSet.AllowUserToAddRows = false;
            this.dvAdjustSet.AllowUserToDeleteRows = false;
            this.dvAdjustSet.AllowUserToResizeRows = false;
            this.dvAdjustSet.AutoGenerateColumns = false;
            this.dvAdjustSet.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvAdjustSet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvAdjustSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAdjustSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCMIDDataGridViewTextBoxColumn,
            this.strandNoDataGridViewTextBoxColumn,
            this.coilNoDataGridViewTextBoxColumn,
            this.insulatingDataGridViewTextBoxColumn,
            this.elecIntensityStdDataGridViewTextBoxColumn,
            this.elecIntensityActDataGridViewTextBoxColumn,
            this.checkDateDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
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
            this.dvAdjustSet.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvAdjustSet_CurrentCellDirtyStateChanged);
            this.dvAdjustSet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAdjustSet_DataError);
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "Click";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "Code_Group = \'UnitID\' order by Code";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "Click";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // dsAdjustObject
            // 
            this.dsAdjustObject.AutoSubscribe = false;
            this.dsAdjustObject.DataSetName = "L3DataSet";
            this.dsAdjustObject.DeleteMethod = "";
            this.dsAdjustObject.InsertMethod = "";
            this.dsAdjustObject.L3DataAdapter = this.Adapter;
            this.dsAdjustObject.LoadEvent = "Click";
            this.dsAdjustObject.LoadTrigger = null;
            this.dsAdjustObject.RefreshValve = 1000;
            this.dsAdjustObject.SourceCommand = null;
            this.dsAdjustObject.SourceCondition = "Code_Group = \'AdjustObject\' order by Code";
            this.dsAdjustObject.SourceMethod = "";
            this.dsAdjustObject.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustObject.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdjustObject.SubscribeTarget = "";
            this.dsAdjustObject.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdjustObject});
            this.dsAdjustObject.UpdateEvent = "Click";
            this.dsAdjustObject.UpdateMethod = "";
            this.dsAdjustObject.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des,
            this.coldsUnitIDL3DataTableCode_Group,
            this.coldsUnitIDL3DataTableCode_Group_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Group
            // 
            this.coldsUnitIDL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Group_Des
            // 
            this.coldsUnitIDL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.Namespace = "";
            // 
            // schemadsAdjustObject
            // 
            this.schemadsAdjustObject.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustObjectL3DataTableCode,
            this.coldsAdjustObjectL3DataTableCode_Des,
            this.coldsAdjustObjectL3DataTableCode_Group,
            this.coldsAdjustObjectL3DataTableCode_Group_Des});
            this.schemadsAdjustObject.TableName = "L3DataTable";
            // 
            // coldsAdjustObjectL3DataTableCode
            // 
            this.coldsAdjustObjectL3DataTableCode.Caption = "Code";
            this.coldsAdjustObjectL3DataTableCode.ColumnName = "Code";
            this.coldsAdjustObjectL3DataTableCode.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group
            // 
            this.coldsAdjustObjectL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Namespace = "";
            // 
            // dsStatus
            // 
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = "";
            this.dsStatus.InsertMethod = "";
            this.dsStatus.L3DataAdapter = null;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsStatus.SourceURI = "";
            this.dsStatus.SubscribeTarget = "";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableID,
            this.coldsStatusL3DataTableDesc});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableID
            // 
            this.coldsStatusL3DataTableID.Caption = "ID";
            this.coldsStatusL3DataTableID.ColumnName = "ID";
            this.coldsStatusL3DataTableID.DataType = typeof(int);
            this.coldsStatusL3DataTableID.Namespace = "";
            // 
            // coldsStatusL3DataTableDesc
            // 
            this.coldsStatusL3DataTableDesc.Caption = "Desc";
            this.coldsStatusL3DataTableDesc.ColumnName = "Desc";
            this.coldsStatusL3DataTableDesc.Namespace = "";
            // 
            // cCMIDDataGridViewTextBoxColumn
            // 
            this.cCMIDDataGridViewTextBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn.DataSource = this.dsUnitID;
            this.cCMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cCMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cCMIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.cCMIDDataGridViewTextBoxColumn.Name = "cCMIDDataGridViewTextBoxColumn";
            this.cCMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cCMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cCMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // strandNoDataGridViewTextBoxColumn
            // 
            this.strandNoDataGridViewTextBoxColumn.DataPropertyName = "StrandNo";
            this.strandNoDataGridViewTextBoxColumn.DataSource = this.dsAdjustObject;
            this.strandNoDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.strandNoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.strandNoDataGridViewTextBoxColumn.HeaderText = "流号";
            this.strandNoDataGridViewTextBoxColumn.Name = "strandNoDataGridViewTextBoxColumn";
            this.strandNoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strandNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.strandNoDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // coilNoDataGridViewTextBoxColumn
            // 
            this.coilNoDataGridViewTextBoxColumn.DataPropertyName = "CoilNo";
            this.coilNoDataGridViewTextBoxColumn.HeaderText = "线圈编号";
            this.coilNoDataGridViewTextBoxColumn.Name = "coilNoDataGridViewTextBoxColumn";
            // 
            // insulatingDataGridViewTextBoxColumn
            // 
            this.insulatingDataGridViewTextBoxColumn.DataPropertyName = "Insulating";
            this.insulatingDataGridViewTextBoxColumn.HeaderText = "绝缘强度";
            this.insulatingDataGridViewTextBoxColumn.Name = "insulatingDataGridViewTextBoxColumn";
            // 
            // elecIntensityStdDataGridViewTextBoxColumn
            // 
            this.elecIntensityStdDataGridViewTextBoxColumn.DataPropertyName = "Elec_Intensity_Std";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.elecIntensityStdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.elecIntensityStdDataGridViewTextBoxColumn.HeaderText = "电磁场强度标准值";
            this.elecIntensityStdDataGridViewTextBoxColumn.Name = "elecIntensityStdDataGridViewTextBoxColumn";
            this.elecIntensityStdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elecIntensityActDataGridViewTextBoxColumn
            // 
            this.elecIntensityActDataGridViewTextBoxColumn.DataPropertyName = "Elec_Intensity_Act";
            this.elecIntensityActDataGridViewTextBoxColumn.HeaderText = "电磁场强度值";
            this.elecIntensityActDataGridViewTextBoxColumn.Name = "elecIntensityActDataGridViewTextBoxColumn";
            // 
            // checkDateDataGridViewTextBoxColumn
            // 
            this.checkDateDataGridViewTextBoxColumn.DataPropertyName = "Check_Date";
            this.checkDateDataGridViewTextBoxColumn.HeaderText = "校准日期";
            this.checkDateDataGridViewTextBoxColumn.Name = "checkDateDataGridViewTextBoxColumn";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Desc";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.ID";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "Create_Time";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.createTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // EquipCoilCheckFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvAdjustSet);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipCoilCheckFrm";
            this.TabText = "电磁搅拌线圈检查";
            this.Text = "电磁搅拌线圈检查";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdjustObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
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
        private AppSvrHMI.L3DataSet dsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCCMID;
        private System.Data.DataColumn coldsAdjustSetL3DataTableStrandNo;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCoilNo;
        private System.Data.DataColumn coldsAdjustSetL3DataTableInsulating;
        private System.Data.DataColumn coldsAdjustSetL3DataTableElec_Intensity_Std;
        private System.Data.DataColumn coldsAdjustSetL3DataTableElec_Intensity_Act;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCheck_Date;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCreate_Time;
        private System.Data.DataColumn coldsAdjustSetL3DataTableOperator;
        private System.Data.DataColumn coldsAdjustSetL3DataTableStatus;
        private AppSvrHMI.L3DataSet dsAdjustStd;
        private System.Data.DataTable schemadsAdjustStd;
        private System.Data.DataColumn coldsAdjustStdL3DataTableGUID;
        private System.Data.DataColumn coldsAdjustStdL3DataTableName;
        private System.Data.DataColumn coldsAdjustStdL3DataTableAdjustType;
        private System.Data.DataColumn coldsAdjustStdL3DataTableUnitID;
        private System.Data.DataColumn coldsAdjustStdL3DataTableAdjustObject;
        private System.Data.DataColumn coldsAdjustStdL3DataTableItems;
        private System.Data.DataColumn coldsAdjustStdL3DataTableStandard;
        private System.Data.DataColumn coldsAdjustStdL3DataTableValidFlag;
        private System.Windows.Forms.DataGridView dvAdjustSet;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group_Des;
        private AppSvrHMI.L3DataSet dsAdjustObject;
        private System.Data.DataTable schemadsAdjustObject;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group_Des;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableID;
        private System.Data.DataColumn coldsStatusL3DataTableDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn cCMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn strandNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insulatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elecIntensityStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elecIntensityActDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}