namespace BaseDataMag
{
    partial class ShiftTeamMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftTeamMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bn = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsShiftTeamOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dsShiftTeamOrder = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsShiftTeamOrder = new System.Data.DataTable();
            this.coldsShiftTeamOrderL3DataTableL3Index = new System.Data.DataColumn();
            this.coldsShiftTeamOrderL3DataTableShiftType = new System.Data.DataColumn();
            this.coldsShiftTeamOrderL3DataTableOrderIndex = new System.Data.DataColumn();
            this.coldsShiftTeamOrderL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsShiftTeamOrderL3DataTableTeamID = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSet = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvShiftTeamOrder = new System.Windows.Forms.DataGridView();
            this.shiftTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.l3IndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bn)).BeginInit();
            this.bn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftTeamOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftTeamOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftTeamOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvShiftTeamOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // bn
            // 
            this.bn.AddNewItem = null;
            this.bn.AutoSize = false;
            this.bn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bn.BackgroundImage")));
            this.bn.BindingSource = this.bsShiftTeamOrder;
            this.bn.CountItem = this.bindingNavigatorCountItem;
            this.bn.DeleteItem = null;
            this.bn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bn.Location = new System.Drawing.Point(0, 0);
            this.bn.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn.Name = "bn";
            this.bn.PositionItem = this.bindingNavigatorPositionItem;
            this.bn.Size = new System.Drawing.Size(1020, 25);
            this.bn.TabIndex = 31;
            this.bn.Text = "bindingNavigator1";
            // 
            // bsShiftTeamOrder
            // 
            this.bsShiftTeamOrder.DataMember = "L3DataTable";
            this.bsShiftTeamOrder.DataSource = this.dsShiftTeamOrder;
            this.bsShiftTeamOrder.Sort = "L3Index";
            // 
            // dsShiftTeamOrder
            // 
            this.dsShiftTeamOrder.DataSetName = "L3DataSet";
            this.dsShiftTeamOrder.DeleteMethod = null;
            this.dsShiftTeamOrder.InsertMethod = null;
            this.dsShiftTeamOrder.L3DataAdapter = this.Adapter;
            this.dsShiftTeamOrder.LoadEvent = "Click";
            this.dsShiftTeamOrder.LoadTrigger = null;
            this.dsShiftTeamOrder.RefreshValve = 1000;
            this.dsShiftTeamOrder.SourceCommand = null;
            this.dsShiftTeamOrder.SourceCondition = null;
            this.dsShiftTeamOrder.SourceMethod = "";
            this.dsShiftTeamOrder.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftTeamOrder.SourceURI = "XGMESLogic\\ShiftTeamMag\\CShiftTeamOrder";
            this.dsShiftTeamOrder.SubscribeTarget = null;
            this.dsShiftTeamOrder.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftTeamOrder});
            this.dsShiftTeamOrder.UpdateEvent = "Click";
            this.dsShiftTeamOrder.UpdateMethod = null;
            this.dsShiftTeamOrder.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsShiftTeamOrder
            // 
            this.schemadsShiftTeamOrder.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftTeamOrderL3DataTableL3Index,
            this.coldsShiftTeamOrderL3DataTableShiftType,
            this.coldsShiftTeamOrderL3DataTableOrderIndex,
            this.coldsShiftTeamOrderL3DataTableShiftID,
            this.coldsShiftTeamOrderL3DataTableTeamID});
            this.schemadsShiftTeamOrder.TableName = "L3DataTable";
            // 
            // coldsShiftTeamOrderL3DataTableL3Index
            // 
            this.coldsShiftTeamOrderL3DataTableL3Index.Caption = "L3Index";
            this.coldsShiftTeamOrderL3DataTableL3Index.ColumnName = "L3Index";
            this.coldsShiftTeamOrderL3DataTableL3Index.DataType = typeof(short);
            this.coldsShiftTeamOrderL3DataTableL3Index.Namespace = "";
            // 
            // coldsShiftTeamOrderL3DataTableShiftType
            // 
            this.coldsShiftTeamOrderL3DataTableShiftType.Caption = "ShiftType";
            this.coldsShiftTeamOrderL3DataTableShiftType.ColumnName = "ShiftType";
            this.coldsShiftTeamOrderL3DataTableShiftType.Namespace = "";
            // 
            // coldsShiftTeamOrderL3DataTableOrderIndex
            // 
            this.coldsShiftTeamOrderL3DataTableOrderIndex.Caption = "OrderIndex";
            this.coldsShiftTeamOrderL3DataTableOrderIndex.ColumnName = "OrderIndex";
            this.coldsShiftTeamOrderL3DataTableOrderIndex.DataType = typeof(short);
            this.coldsShiftTeamOrderL3DataTableOrderIndex.Namespace = "";
            // 
            // coldsShiftTeamOrderL3DataTableShiftID
            // 
            this.coldsShiftTeamOrderL3DataTableShiftID.Caption = "ShiftID";
            this.coldsShiftTeamOrderL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsShiftTeamOrderL3DataTableShiftID.DataType = typeof(short);
            this.coldsShiftTeamOrderL3DataTableShiftID.Namespace = "";
            // 
            // coldsShiftTeamOrderL3DataTableTeamID
            // 
            this.coldsShiftTeamOrderL3DataTableTeamID.Caption = "TeamID";
            this.coldsShiftTeamOrderL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsShiftTeamOrderL3DataTableTeamID.DataType = typeof(short);
            this.coldsShiftTeamOrderL3DataTableTeamID.Namespace = "";
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
            // dsShiftID
            // 
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
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
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode_Val_Long});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Val_Long
            // 
            this.coldsShiftIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsShiftIDL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsShiftIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsTeamID
            // 
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
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
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode_Val_Long});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Val_Long
            // 
            this.coldsTeamIDL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTeamIDL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsTeamIDL3DataTableCode_Val_Long.Namespace = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 26);
            // 
            // btnSet
            // 
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(166, 22);
            this.btnSet.Text = "设为当前班别班次";
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvShiftTeamOrder);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1020, 625);
            this.hmiRootPanel1.TabIndex = 32;
            // 
            // dvShiftTeamOrder
            // 
            this.dvShiftTeamOrder.AllowUserToAddRows = false;
            this.dvShiftTeamOrder.AutoGenerateColumns = false;
            this.dvShiftTeamOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvShiftTeamOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shiftTypeDataGridViewTextBoxColumn,
            this.orderIndexDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.l3IndexDataGridViewTextBoxColumn});
            this.dvShiftTeamOrder.ContextMenuStrip = this.contextMenuStrip1;
            this.dvShiftTeamOrder.DataSource = this.bsShiftTeamOrder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvShiftTeamOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvShiftTeamOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvShiftTeamOrder.Location = new System.Drawing.Point(0, 0);
            this.dvShiftTeamOrder.MultiSelect = false;
            this.dvShiftTeamOrder.Name = "dvShiftTeamOrder";
            this.dvShiftTeamOrder.RowTemplate.Height = 23;
            this.dvShiftTeamOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvShiftTeamOrder.Size = new System.Drawing.Size(1020, 625);
            this.dvShiftTeamOrder.TabIndex = 33;
            // 
            // shiftTypeDataGridViewTextBoxColumn
            // 
            this.shiftTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shiftTypeDataGridViewTextBoxColumn.DataPropertyName = "ShiftType";
            this.shiftTypeDataGridViewTextBoxColumn.HeaderText = "换班类型";
            this.shiftTypeDataGridViewTextBoxColumn.Name = "shiftTypeDataGridViewTextBoxColumn";
            this.shiftTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIndexDataGridViewTextBoxColumn
            // 
            this.orderIndexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderIndexDataGridViewTextBoxColumn.DataPropertyName = "OrderIndex";
            this.orderIndexDataGridViewTextBoxColumn.HeaderText = "索引";
            this.orderIndexDataGridViewTextBoxColumn.Name = "orderIndexDataGridViewTextBoxColumn";
            this.orderIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // l3IndexDataGridViewTextBoxColumn
            // 
            this.l3IndexDataGridViewTextBoxColumn.DataPropertyName = "L3Index";
            this.l3IndexDataGridViewTextBoxColumn.HeaderText = "主键";
            this.l3IndexDataGridViewTextBoxColumn.Name = "l3IndexDataGridViewTextBoxColumn";
            this.l3IndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.l3IndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShiftTeamMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShiftTeamMagFrm";
            this.TabText = "班别班次管理";
            this.Text = "ShiftTeamMagFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftTeamMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bn)).EndInit();
            this.bn.ResumeLayout(false);
            this.bn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftTeamOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftTeamOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftTeamOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvShiftTeamOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bn;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsShiftTeamOrder;
        private System.Data.DataTable schemadsShiftTeamOrder;
        private System.Data.DataColumn coldsShiftTeamOrderL3DataTableL3Index;
        private System.Data.DataColumn coldsShiftTeamOrderL3DataTableShiftType;
        private System.Data.DataColumn coldsShiftTeamOrderL3DataTableOrderIndex;
        private System.Data.DataColumn coldsShiftTeamOrderL3DataTableShiftID;
        private System.Data.DataColumn coldsShiftTeamOrderL3DataTableTeamID;
        private System.Windows.Forms.BindingSource bsShiftTeamOrder;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Val_Long;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSet;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvShiftTeamOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l3IndexDataGridViewTextBoxColumn;
    }
}