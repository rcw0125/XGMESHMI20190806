namespace QualityMag.QualityStandard
{
    partial class DesStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesStdMaintenFrm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsDesStdMainten = new System.Windows.Forms.BindingSource(this.components);
            this.dsDesStdMainten = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsDesStdMainten = new System.Data.DataTable();
            this.coldsDesStdMaintenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDesStdMaintenL3DataTableName = new System.Data.DataColumn();
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod = new System.Data.DataColumn();
            this.coldsDesStdMaintenL3DataTableValid_Date = new System.Data.DataColumn();
            this.coldsDesStdMaintenL3DataTableS = new System.Data.DataColumn();
            this.coldsDesStdMaintenL3DataTableWeight = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtDesProcMod = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanelDesStdMainten = new HMIBase.HMIRootPanel();
            this.dvDesStdMainten = new System.Windows.Forms.DataGridView();
            this.desProcModDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesStdMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesStdMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesStdMainten)).BeginInit();
            this.hmiRootPanelDesStdMainten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDesStdMainten)).BeginInit();
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
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 14;
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
            this.Adapter.SetAccessRight(this.btnAdd, "btnDesStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnDesStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnDesStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnDesStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnDesStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsDesStdMainten;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel3,
            this.txtDesProcMod,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsDesStdMainten
            // 
            this.bsDesStdMainten.DataMember = "L3DataTable";
            this.bsDesStdMainten.DataSource = this.dsDesStdMainten;
            // 
            // dsDesStdMainten
            // 
            this.dsDesStdMainten.AutoSubscribe = false;
            this.dsDesStdMainten.DataSetName = "L3DataSet";
            this.dsDesStdMainten.DeleteMethod = null;
            this.dsDesStdMainten.InsertMethod = null;
            this.dsDesStdMainten.L3DataAdapter = this.Adapter;
            this.dsDesStdMainten.LoadEvent = "Click";
            this.dsDesStdMainten.LoadTrigger = null;
            this.dsDesStdMainten.RefreshValve = 1000;
            this.dsDesStdMainten.SourceCommand = null;
            this.dsDesStdMainten.SourceCondition = "1=2";
            this.dsDesStdMainten.SourceMethod = "";
            this.dsDesStdMainten.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDesStdMainten.SourceURI = "XGMESLogic\\QualityMag\\CQA_Des_Std";
            this.dsDesStdMainten.SubscribeTarget = null;
            this.dsDesStdMainten.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDesStdMainten});
            this.dsDesStdMainten.UpdateEvent = "Click";
            this.dsDesStdMainten.UpdateMethod = null;
            this.dsDesStdMainten.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsDesStdMainten
            // 
            this.schemadsDesStdMainten.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDesStdMaintenL3DataTableGUID,
            this.coldsDesStdMaintenL3DataTableName,
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod,
            this.coldsDesStdMaintenL3DataTableValid_Date,
            this.coldsDesStdMaintenL3DataTableS,
            this.coldsDesStdMaintenL3DataTableWeight});
            this.schemadsDesStdMainten.TableName = "L3DataTable";
            // 
            // coldsDesStdMaintenL3DataTableGUID
            // 
            this.coldsDesStdMaintenL3DataTableGUID.Caption = "GUID";
            this.coldsDesStdMaintenL3DataTableGUID.ColumnName = "GUID";
            this.coldsDesStdMaintenL3DataTableGUID.Namespace = "";
            // 
            // coldsDesStdMaintenL3DataTableName
            // 
            this.coldsDesStdMaintenL3DataTableName.Caption = "Name";
            this.coldsDesStdMaintenL3DataTableName.ColumnName = "Name";
            this.coldsDesStdMaintenL3DataTableName.Namespace = "";
            // 
            // coldsDesStdMaintenL3DataTableDes_Proc_Mod
            // 
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod.Caption = "Des_Proc_Mod";
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod.ColumnName = "Des_Proc_Mod";
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod.DataType = typeof(int);
            this.coldsDesStdMaintenL3DataTableDes_Proc_Mod.Namespace = "";
            // 
            // coldsDesStdMaintenL3DataTableValid_Date
            // 
            this.coldsDesStdMaintenL3DataTableValid_Date.Caption = "Valid_Date";
            this.coldsDesStdMaintenL3DataTableValid_Date.ColumnName = "Valid_Date";
            this.coldsDesStdMaintenL3DataTableValid_Date.DataType = typeof(System.DateTime);
            this.coldsDesStdMaintenL3DataTableValid_Date.Namespace = "";
            // 
            // coldsDesStdMaintenL3DataTableS
            // 
            this.coldsDesStdMaintenL3DataTableS.Caption = "S";
            this.coldsDesStdMaintenL3DataTableS.ColumnName = "S";
            this.coldsDesStdMaintenL3DataTableS.Namespace = "";
            // 
            // coldsDesStdMaintenL3DataTableWeight
            // 
            this.coldsDesStdMaintenL3DataTableWeight.Caption = "Weight";
            this.coldsDesStdMaintenL3DataTableWeight.ColumnName = "Weight";
            this.coldsDesStdMaintenL3DataTableWeight.Namespace = "";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "　";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel3.Text = " ";
            // 
            // txtDesProcMod
            // 
            this.txtDesProcMod.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtDesProcMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesProcMod.Name = "txtDesProcMod";
            this.txtDesProcMod.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel1.Text = "脱硫处理模式号:";
            // 
            // hmiRootPanelDesStdMainten
            // 
            this.hmiRootPanelDesStdMainten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelDesStdMainten.Controls.Add(this.dvDesStdMainten);
            this.hmiRootPanelDesStdMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelDesStdMainten.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelDesStdMainten.Name = "hmiRootPanelDesStdMainten";
            this.hmiRootPanelDesStdMainten.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelDesStdMainten.TabIndex = 17;
            // 
            // dvDesStdMainten
            // 
            this.dvDesStdMainten.AllowUserToAddRows = false;
            this.dvDesStdMainten.AutoGenerateColumns = false;
            this.dvDesStdMainten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvDesStdMainten.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDesStdMainten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvDesStdMainten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desProcModDataGridViewTextBoxColumn,
            this.validDateDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvDesStdMainten.DataSource = this.bsDesStdMainten;
            this.dvDesStdMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDesStdMainten.Location = new System.Drawing.Point(0, 0);
            this.dvDesStdMainten.Name = "dvDesStdMainten";
            this.dvDesStdMainten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvDesStdMainten.RowTemplate.Height = 23;
            this.dvDesStdMainten.Size = new System.Drawing.Size(1016, 608);
            this.dvDesStdMainten.TabIndex = 0;
            this.dvDesStdMainten.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDesStdMainten_DataError);
            // 
            // desProcModDataGridViewTextBoxColumn
            // 
            this.desProcModDataGridViewTextBoxColumn.DataPropertyName = "Des_Proc_Mod";
            this.desProcModDataGridViewTextBoxColumn.HeaderText = "脱硫处理模式号";
            this.desProcModDataGridViewTextBoxColumn.Name = "desProcModDataGridViewTextBoxColumn";
            // 
            // validDateDataGridViewTextBoxColumn
            // 
            this.validDateDataGridViewTextBoxColumn.DataPropertyName = "Valid_Date";
            this.validDateDataGridViewTextBoxColumn.HeaderText = "生效日期";
            this.validDateDataGridViewTextBoxColumn.Name = "validDateDataGridViewTextBoxColumn";
            this.validDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "铁水硫含量";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "铁水重量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // DesStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelDesStdMainten);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DesStdMaintenFrm";
            this.TabText = "脱硫制造标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesStdMaintenFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesStdMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesStdMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesStdMainten)).EndInit();
            this.hmiRootPanelDesStdMainten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDesStdMainten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsDesStdMainten;
        private AppSvrHMI.L3DataSet dsDesStdMainten;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanelDesStdMainten;
        private System.Windows.Forms.DataGridView dvDesStdMainten;
        private System.Windows.Forms.ToolStripTextBox txtDesProcMod;
        private System.Data.DataTable schemadsDesStdMainten;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableGUID;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableName;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableDes_Proc_Mod;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableValid_Date;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableS;
        private System.Data.DataColumn coldsDesStdMaintenL3DataTableWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn desProcModDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn validDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
    }
}