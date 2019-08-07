namespace BaseDataMag
{
    partial class IronLadleDataManageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleDataManageFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsIronLadle = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronLadle = new AppSvrHMI.L3DataSet();
            this.cmdIronLadle = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableModifyTime = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableOperator = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableGroupNo = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableOrder_No = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableIDObject = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dvIronLadle = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.统计罐龄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.groupNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPCNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronLadle)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.bindingNavigator1.BindingSource = this.bsIronLadle;
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
            // bsIronLadle
            // 
            this.bsIronLadle.DataMember = "L3DataTable";
            this.bsIronLadle.DataSource = this.dsIronLadle;
            // 
            // dsIronLadle
            // 
            this.dsIronLadle.AutoSubscribe = false;
            this.dsIronLadle.DataSetName = "L3DataSet";
            this.dsIronLadle.DeleteMethod = "";
            this.dsIronLadle.InsertMethod = "";
            this.dsIronLadle.L3DataAdapter = this.Adapter;
            this.dsIronLadle.LoadEvent = "";
            this.dsIronLadle.LoadTrigger = null;
            this.dsIronLadle.RefreshValve = 1000;
            this.dsIronLadle.SourceCommand = this.cmdIronLadle;
            this.dsIronLadle.SourceCondition = "IDObject is not null order by IDObject";
            this.dsIronLadle.SourceMethod = "";
            this.dsIronLadle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadle.SourceURI = "XGMESLogic\\BFMag\\CBF_IronLadle_Info";
            this.dsIronLadle.SubscribeTarget = null;
            this.dsIronLadle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsIronLadle.UpdateEvent = "";
            this.dsIronLadle.UpdateMethod = "";
            this.dsIronLadle.UpdateTrigger = null;
            // 
            // cmdIronLadle
            // 
            this.cmdIronLadle.Adapter = null;
            this.cmdIronLadle.MergeReturnTarget = false;
            this.cmdIronLadle.Method = null;
            this.cmdIronLadle.Object = null;
            this.cmdIronLadle.Parameters.Add(this.l3CommandParameter1);
            this.cmdIronLadle.Parameters.Add(this.l3CommandParameter2);
            this.cmdIronLadle.ReturnTarget = null;
            this.cmdIronLadle.ReturnTargetProperty = null;
            this.cmdIronLadle.Trigger = null;
            this.cmdIronLadle.TriggerEvent = "Click";
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
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsEnergyDataL3DataTableModifyTime,
            this.coldsEnergyDataL3DataTableOperator,
            this.coldsEnergyDataL3DataTableTPC_No,
            this.coldsEnergyDataL3DataTableGroupNo,
            this.coldsEnergyDataL3DataTableOrder_No,
            this.coldsIronLadleL3DataTableIDObject});
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
            // coldsEnergyDataL3DataTableTPC_No
            // 
            this.coldsEnergyDataL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsEnergyDataL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsEnergyDataL3DataTableTPC_No.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableGroupNo
            // 
            this.coldsEnergyDataL3DataTableGroupNo.Caption = "GroupNo";
            this.coldsEnergyDataL3DataTableGroupNo.ColumnName = "GroupNo";
            this.coldsEnergyDataL3DataTableGroupNo.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableOrder_No
            // 
            this.coldsEnergyDataL3DataTableOrder_No.Caption = "Order_No";
            this.coldsEnergyDataL3DataTableOrder_No.ColumnName = "Order_No";
            this.coldsEnergyDataL3DataTableOrder_No.DataType = typeof(int);
            this.coldsEnergyDataL3DataTableOrder_No.Namespace = "";
            // 
            // coldsIronLadleL3DataTableIDObject
            // 
            this.coldsIronLadleL3DataTableIDObject.Caption = "IDObject";
            this.coldsIronLadleL3DataTableIDObject.ColumnName = "IDObject";
            this.coldsIronLadleL3DataTableIDObject.Namespace = "";
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
            // dvIronLadle
            // 
            this.dvIronLadle.AllowUserToAddRows = false;
            this.dvIronLadle.AllowUserToDeleteRows = false;
            this.dvIronLadle.AllowUserToResizeRows = false;
            this.dvIronLadle.AutoGenerateColumns = false;
            this.dvIronLadle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvIronLadle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvIronLadle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNoDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.tPCNoDataGridViewTextBoxColumn,
            this.modifyTimeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.IDObject});
            this.dvIronLadle.ContextMenuStrip = this.contextMenuStrip1;
            this.dvIronLadle.DataSource = this.bsIronLadle;
            this.dvIronLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronLadle.Location = new System.Drawing.Point(0, 68);
            this.dvIronLadle.Name = "dvIronLadle";
            this.dvIronLadle.RowTemplate.Height = 23;
            this.dvIronLadle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvIronLadle.Size = new System.Drawing.Size(1000, 532);
            this.dvIronLadle.TabIndex = 20;
            this.dvIronLadle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvEnergyData_DataError);
            this.dvIronLadle.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvIronLadle_CellEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.统计罐龄ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // 统计罐龄ToolStripMenuItem
            // 
            this.统计罐龄ToolStripMenuItem.Name = "统计罐龄ToolStripMenuItem";
            this.统计罐龄ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.统计罐龄ToolStripMenuItem.Text = "统计罐龄";
            this.统计罐龄ToolStripMenuItem.Click += new System.EventHandler(this.统计罐龄ToolStripMenuItem_Click);
            // 
            // dsCode
            // 
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = "";
            this.dsCode.InsertMethod = "";
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "Code_Group_Des = \'能源消耗\'";
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
            // groupNoDataGridViewTextBoxColumn
            // 
            this.groupNoDataGridViewTextBoxColumn.DataPropertyName = "GroupNo";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupNoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.groupNoDataGridViewTextBoxColumn.HeaderText = "分组号";
            this.groupNoDataGridViewTextBoxColumn.Name = "groupNoDataGridViewTextBoxColumn";
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "Order_No";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.orderNoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "组内顺序号";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            // 
            // tPCNoDataGridViewTextBoxColumn
            // 
            this.tPCNoDataGridViewTextBoxColumn.DataPropertyName = "TPC_No";
            this.tPCNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tPCNoDataGridViewTextBoxColumn.Name = "tPCNoDataGridViewTextBoxColumn";
            // 
            // modifyTimeDataGridViewTextBoxColumn
            // 
            this.modifyTimeDataGridViewTextBoxColumn.DataPropertyName = "ModifyTime";
            this.modifyTimeDataGridViewTextBoxColumn.HeaderText = "变更时刻";
            this.modifyTimeDataGridViewTextBoxColumn.Name = "modifyTimeDataGridViewTextBoxColumn";
            this.modifyTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // IDObject
            // 
            this.IDObject.DataPropertyName = "IDObject";
            this.IDObject.HeaderText = "IDObject";
            this.IDObject.Name = "IDObject";
            this.IDObject.Visible = false;
            // 
            // IronLadleDataManageFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvIronLadle);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronLadleDataManageFrm";
            this.TabText = "铁罐档案管理";
            this.Text = "铁罐档案管理";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronLadle)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvIronLadle;
        private AppSvrHMI.L3DataSet dsIronLadle;
        private AppSvrHMI.L3Command cmdIronLadle;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Data.DataColumn coldsEnergyDataL3DataTableModifyTime;
        private System.Data.DataColumn coldsEnergyDataL3DataTableOperator;
        private System.Windows.Forms.BindingSource bsIronLadle;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Group_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsEnergyDataL3DataTableTPC_No;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGroupNo;
        private System.Data.DataColumn coldsEnergyDataL3DataTableOrder_No;
        private System.Data.DataColumn coldsIronLadleL3DataTableIDObject;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 统计罐龄ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPCNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDObject;
    }
}