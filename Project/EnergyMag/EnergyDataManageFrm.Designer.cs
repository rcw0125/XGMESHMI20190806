namespace EnergyMag
{
    partial class EnergyDataManageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnergyDataManageFrm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsEnergyData = new System.Windows.Forms.BindingSource(this.components);
            this.dsEnergyData = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableTagName = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableTagValue = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableDayValue = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableMonthValue = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableModifyTime = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableOperator = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmdEnergyData = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvEnergyData = new System.Windows.Forms.DataGridView();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.tagValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAdd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdMod = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsEnergyData;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.btnQuery,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2,
            this.dtEnd,
            this.toolStripLabel2,
            this.dtStart,
            this.toolStripLabel1});
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
            // bsEnergyData
            // 
            this.bsEnergyData.DataMember = "L3DataTable";
            this.bsEnergyData.DataSource = this.dsEnergyData;
            // 
            // dsEnergyData
            // 
            this.dsEnergyData.AutoLoad = true;
            this.dsEnergyData.AutoSubscribe = false;
            this.dsEnergyData.DataSetName = "L3DataSet";
            this.dsEnergyData.DeleteMethod = "";
            this.dsEnergyData.InsertMethod = "";
            this.dsEnergyData.L3DataAdapter = this.Adapter;
            this.dsEnergyData.LoadEvent = "";
            this.dsEnergyData.LoadTrigger = null;
            this.dsEnergyData.RefreshValve = 1000;
            this.dsEnergyData.SourceCommand = null;
            this.dsEnergyData.SourceCondition = "1=2";
            this.dsEnergyData.SourceMethod = "";
            this.dsEnergyData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsEnergyData.SourceURI = "XGMESLogic\\EnergyMag\\CEnergyConsumption";
            this.dsEnergyData.SubscribeTarget = null;
            this.dsEnergyData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsEnergyData.UpdateEvent = "";
            this.dsEnergyData.UpdateMethod = "";
            this.dsEnergyData.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsEnergyDataL3DataTableObjectID,
            this.coldsEnergyDataL3DataTableProductionDate,
            this.coldsEnergyDataL3DataTableTagName,
            this.coldsEnergyDataL3DataTableTagValue,
            this.coldsEnergyDataL3DataTableDayValue,
            this.coldsEnergyDataL3DataTableMonthValue,
            this.coldsEnergyDataL3DataTableCreateTime,
            this.coldsEnergyDataL3DataTableModifyTime,
            this.coldsEnergyDataL3DataTableOperator});
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
            // coldsEnergyDataL3DataTableObjectID
            // 
            this.coldsEnergyDataL3DataTableObjectID.Caption = "ObjectID";
            this.coldsEnergyDataL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsEnergyDataL3DataTableObjectID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableProductionDate
            // 
            this.coldsEnergyDataL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsEnergyDataL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsEnergyDataL3DataTableProductionDate.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableTagName
            // 
            this.coldsEnergyDataL3DataTableTagName.Caption = "TagName";
            this.coldsEnergyDataL3DataTableTagName.ColumnName = "TagName";
            this.coldsEnergyDataL3DataTableTagName.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableTagValue
            // 
            this.coldsEnergyDataL3DataTableTagValue.Caption = "TagValue";
            this.coldsEnergyDataL3DataTableTagValue.ColumnName = "TagValue";
            this.coldsEnergyDataL3DataTableTagValue.DataType = typeof(double);
            this.coldsEnergyDataL3DataTableTagValue.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableDayValue
            // 
            this.coldsEnergyDataL3DataTableDayValue.Caption = "DayValue";
            this.coldsEnergyDataL3DataTableDayValue.ColumnName = "DayValue";
            this.coldsEnergyDataL3DataTableDayValue.DataType = typeof(double);
            this.coldsEnergyDataL3DataTableDayValue.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableMonthValue
            // 
            this.coldsEnergyDataL3DataTableMonthValue.Caption = "MonthValue";
            this.coldsEnergyDataL3DataTableMonthValue.ColumnName = "MonthValue";
            this.coldsEnergyDataL3DataTableMonthValue.DataType = typeof(double);
            this.coldsEnergyDataL3DataTableMonthValue.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableCreateTime
            // 
            this.coldsEnergyDataL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsEnergyDataL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsEnergyDataL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsEnergyDataL3DataTableCreateTime.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableModifyTime
            // 
            this.coldsEnergyDataL3DataTableModifyTime.Caption = "ModifyTime";
            this.coldsEnergyDataL3DataTableModifyTime.ColumnName = "ModifyTime";
            this.coldsEnergyDataL3DataTableModifyTime.DataType = typeof(System.DateTime);
            this.coldsEnergyDataL3DataTableModifyTime.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableOperator
            // 
            this.coldsEnergyDataL3DataTableOperator.Caption = "Operator";
            this.coldsEnergyDataL3DataTableOperator.ColumnName = "Operator";
            this.coldsEnergyDataL3DataTableOperator.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel5.Text = "　";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
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
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(120, 22);
            this.dtEnd.Text = "2009-03-28";
            this.dtEnd.Value = new System.DateTime(2009, 3, 28, 18, 37, 23, 903);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "--";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(120, 22);
            this.dtStart.Text = "2009-03-28";
            this.dtStart.Value = new System.DateTime(2009, 3, 28, 18, 38, 0, 355);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "生产日期:";
            // 
            // cmdEnergyData
            // 
            this.cmdEnergyData.Adapter = null;
            this.cmdEnergyData.MergeReturnTarget = false;
            this.cmdEnergyData.Method = null;
            this.cmdEnergyData.Object = null;
            this.cmdEnergyData.Parameters.Add(this.l3CommandParameter1);
            this.cmdEnergyData.Parameters.Add(this.l3CommandParameter2);
            this.cmdEnergyData.ReturnTarget = null;
            this.cmdEnergyData.ReturnTargetProperty = null;
            this.cmdEnergyData.Trigger = null;
            this.cmdEnergyData.TriggerEvent = "Click";
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
            // dvEnergyData
            // 
            this.dvEnergyData.AllowUserToAddRows = false;
            this.dvEnergyData.AllowUserToDeleteRows = false;
            this.dvEnergyData.AllowUserToResizeRows = false;
            this.dvEnergyData.AutoGenerateColumns = false;
            this.dvEnergyData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvEnergyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvEnergyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectIDDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.tagNameDataGridViewTextBoxColumn,
            this.tagValueDataGridViewTextBoxColumn,
            this.dayValueDataGridViewTextBoxColumn,
            this.monthValueDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.modifyTimeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvEnergyData.DataSource = this.bsEnergyData;
            this.dvEnergyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvEnergyData.Location = new System.Drawing.Point(0, 68);
            this.dvEnergyData.MultiSelect = false;
            this.dvEnergyData.Name = "dvEnergyData";
            this.dvEnergyData.ReadOnly = true;
            this.dvEnergyData.RowTemplate.Height = 23;
            this.dvEnergyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvEnergyData.Size = new System.Drawing.Size(1000, 532);
            this.dvEnergyData.TabIndex = 20;
            this.dvEnergyData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvEnergyData_CellDoubleClick);
            this.dvEnergyData.Sorted += new System.EventHandler(this.dvEnergyData_Sorted);
            this.dvEnergyData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvEnergyData_DataError);
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.Frozen = true;
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "对象标识";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.Frozen = true;
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.productionDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.DataSource = this.dsCode;
            this.tagNameDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tagNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tagNameDataGridViewTextBoxColumn.Frozen = true;
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "标签名";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tagNameDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tagNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dsCode
            // 
            this.dsCode.AutoLoad = true;
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = "";
            this.dsCode.InsertMethod = "";
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "Code_Group = \'EnergyConsumption\' order by Code";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCode.SubscribeTarget = null;
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCode});
            this.dsCode.UpdateEvent = "";
            this.dsCode.UpdateMethod = "";
            this.dsCode.UpdateTrigger = null;
            // 
            // schemadsCode
            // 
            this.schemadsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeL3DataTableCode,
            this.coldsCodeL3DataTableCode_Des,
            this.coldsCodeL3DataTableCode_Group_Des});
            this.schemadsCode.TableName = "L3DataTable";
            // 
            // coldsCodeL3DataTableCode
            // 
            this.coldsCodeL3DataTableCode.Caption = "Code";
            this.coldsCodeL3DataTableCode.ColumnName = "Code";
            this.coldsCodeL3DataTableCode.Namespace = "";
            // 
            // coldsCodeL3DataTableCode_Des
            // 
            this.coldsCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCodeL3DataTableCode_Group_Des
            // 
            this.coldsCodeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsCodeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsCodeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // tagValueDataGridViewTextBoxColumn
            // 
            this.tagValueDataGridViewTextBoxColumn.DataPropertyName = "TagValue";
            this.tagValueDataGridViewTextBoxColumn.HeaderText = "仪表数据";
            this.tagValueDataGridViewTextBoxColumn.Name = "tagValueDataGridViewTextBoxColumn";
            this.tagValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayValueDataGridViewTextBoxColumn
            // 
            this.dayValueDataGridViewTextBoxColumn.DataPropertyName = "DayValue";
            this.dayValueDataGridViewTextBoxColumn.HeaderText = "当日消耗";
            this.dayValueDataGridViewTextBoxColumn.Name = "dayValueDataGridViewTextBoxColumn";
            this.dayValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthValueDataGridViewTextBoxColumn
            // 
            this.monthValueDataGridViewTextBoxColumn.DataPropertyName = "MonthValue";
            this.monthValueDataGridViewTextBoxColumn.HeaderText = "月累消耗";
            this.monthValueDataGridViewTextBoxColumn.Name = "monthValueDataGridViewTextBoxColumn";
            this.monthValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // modifyTimeDataGridViewTextBoxColumn
            // 
            this.modifyTimeDataGridViewTextBoxColumn.DataPropertyName = "ModifyTime";
            this.modifyTimeDataGridViewTextBoxColumn.HeaderText = "变更时刻";
            this.modifyTimeDataGridViewTextBoxColumn.Name = "modifyTimeDataGridViewTextBoxColumn";
            this.modifyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifyTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 80;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Adapter = this.Adapter;
            this.cmdAdd.MergeReturnTarget = false;
            this.cmdAdd.Method = "NewConsumption";
            this.cmdAdd.Object = "XGMESLogic\\EnergyMag\\CEnergy_Unit_Mag\\EnergyMag";
            this.cmdAdd.Parameters.Add(this.l3CommandParameter3);
            this.cmdAdd.ReturnTarget = null;
            this.cmdAdd.ReturnTargetProperty = null;
            this.cmdAdd.Trigger = null;
            this.cmdAdd.TriggerEvent = "Click";
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
            // cmdMod
            // 
            this.cmdMod.Adapter = this.Adapter;
            this.cmdMod.MergeReturnTarget = false;
            this.cmdMod.Method = "UpdateConsumption";
            this.cmdMod.Object = "XGMESLogic\\EnergyMag\\CEnergy_Unit_Mag\\EnergyMag";
            this.cmdMod.Parameters.Add(this.l3CommandParameter4);
            this.cmdMod.ReturnTarget = null;
            this.cmdMod.ReturnTargetProperty = null;
            this.cmdMod.Trigger = null;
            this.cmdMod.TriggerEvent = "Click";
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
            // EnergyDataManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvEnergyData);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnergyDataManageFrm";
            this.TabText = "能源消耗管理";
            this.Text = "能源消耗管理";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dvEnergyData;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private AppSvrHMI.L3DataSet dsEnergyData;
        private AppSvrHMI.L3Command cmdEnergyData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Data.DataColumn coldsEnergyDataL3DataTableObjectID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableProductionDate;
        private System.Data.DataColumn coldsEnergyDataL3DataTableTagName;
        private System.Data.DataColumn coldsEnergyDataL3DataTableTagValue;
        private System.Data.DataColumn coldsEnergyDataL3DataTableDayValue;
        private System.Data.DataColumn coldsEnergyDataL3DataTableMonthValue;
        private System.Data.DataColumn coldsEnergyDataL3DataTableCreateTime;
        private System.Data.DataColumn coldsEnergyDataL3DataTableModifyTime;
        private System.Data.DataColumn coldsEnergyDataL3DataTableOperator;
        private System.Windows.Forms.BindingSource bsEnergyData;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Group_Des;
        private AppSvrHMI.L3Command cmdAdd;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3Command cmdMod;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}