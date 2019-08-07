namespace BaseDataMag
{
    partial class WireCoefficientFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WireCoefficientFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsWireData = new AppSvrHMI.L3DataSet();
            this.schemadsWireData = new System.Data.DataTable();
            this.coldsWireDataL3DataTableWireCode = new System.Data.DataColumn();
            this.coldsWireDataL3DataTableCoefficient = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.bsWireData = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dvWireData = new System.Windows.Forms.DataGridView();
            this.wireCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWireCode = new AppSvrHMI.L3DataSet();
            this.schemadsWireCode = new System.Data.DataTable();
            this.coldsWireCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsWireCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coefficientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWireData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsWireData
            // 
            this.dsWireData.AutoSubscribe = true;
            this.dsWireData.DataSetName = "L3DataSet";
            this.dsWireData.DeleteMethod = "";
            this.dsWireData.InsertMethod = "";
            this.dsWireData.L3DataAdapter = this.Adapter;
            this.dsWireData.LoadEvent = "";
            this.dsWireData.LoadTrigger = null;
            this.dsWireData.RefreshValve = 1000;
            this.dsWireData.SourceCommand = null;
            this.dsWireData.SourceCondition = "";
            this.dsWireData.SourceMethod = "";
            this.dsWireData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireData.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Wire_Coefficient";
            this.dsWireData.SubscribeTarget = "";
            this.dsWireData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireData});
            this.dsWireData.UpdateEvent = "";
            this.dsWireData.UpdateMethod = "";
            this.dsWireData.UpdateTrigger = null;
            // 
            // schemadsWireData
            // 
            this.schemadsWireData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireDataL3DataTableWireCode,
            this.coldsWireDataL3DataTableCoefficient});
            this.schemadsWireData.TableName = "L3DataTable";
            // 
            // coldsWireDataL3DataTableWireCode
            // 
            this.coldsWireDataL3DataTableWireCode.Caption = "WireCode";
            this.coldsWireDataL3DataTableWireCode.ColumnName = "WireCode";
            this.coldsWireDataL3DataTableWireCode.Namespace = "";
            // 
            // coldsWireDataL3DataTableCoefficient
            // 
            this.coldsWireDataL3DataTableCoefficient.Caption = "Coefficient";
            this.coldsWireDataL3DataTableCoefficient.ColumnName = "Coefficient";
            this.coldsWireDataL3DataTableCoefficient.DataType = typeof(double);
            this.coldsWireDataL3DataTableCoefficient.DefaultValue = 0;
            this.coldsWireDataL3DataTableCoefficient.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(777, 43);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
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
            this.Adapter.SetAccessRight(this.btnAdd, "btnWireCoefficient");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnWireCoefficient");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "btnWireCoefficient");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnWireCoefficient");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnWireCoefficient");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator3, "btnWireCoefficient");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.Adapter.SetAccessRight(this.btnOutPut, "btnWireCoefficient");
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // bsWireData
            // 
            this.bsWireData.DataMember = "L3DataTable";
            this.bsWireData.DataSource = this.dsWireData;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsWireData;
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
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(777, 25);
            this.bindingNavigator1.TabIndex = 27;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // dvWireData
            // 
            this.dvWireData.AllowUserToAddRows = false;
            this.dvWireData.AutoGenerateColumns = false;
            this.dvWireData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvWireData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvWireData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wireCodeDataGridViewTextBoxColumn,
            this.coefficientDataGridViewTextBoxColumn});
            this.dvWireData.DataSource = this.bsWireData;
            this.dvWireData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWireData.Location = new System.Drawing.Point(0, 68);
            this.dvWireData.Name = "dvWireData";
            this.dvWireData.RowTemplate.Height = 23;
            this.dvWireData.Size = new System.Drawing.Size(777, 254);
            this.dvWireData.TabIndex = 28;
            this.dvWireData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvWireData_DataError);
            // 
            // wireCodeDataGridViewTextBoxColumn
            // 
            this.wireCodeDataGridViewTextBoxColumn.DataPropertyName = "WireCode";
            this.wireCodeDataGridViewTextBoxColumn.DataSource = this.dsWireCode;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wireCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.wireCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wireCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wireCodeDataGridViewTextBoxColumn.HeaderText = "喂线代码";
            this.wireCodeDataGridViewTextBoxColumn.Name = "wireCodeDataGridViewTextBoxColumn";
            this.wireCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wireCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wireCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsWireCode
            // 
            this.dsWireCode.AutoSubscribe = false;
            this.dsWireCode.DataSetName = "L3DataSet";
            this.dsWireCode.DeleteMethod = "";
            this.dsWireCode.InsertMethod = "";
            this.dsWireCode.L3DataAdapter = this.Adapter;
            this.dsWireCode.LoadEvent = "";
            this.dsWireCode.LoadTrigger = null;
            this.dsWireCode.RefreshValve = 1000;
            this.dsWireCode.SourceCommand = null;
            this.dsWireCode.SourceCondition = "code_group = \'ALLOY_CODE\' and CODE_FUNCTION_GROUP = \'FeedWire\' ORDER BY code";
            this.dsWireCode.SourceMethod = "";
            this.dsWireCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWireCode.SubscribeTarget = "";
            this.dsWireCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireCode});
            this.dsWireCode.UpdateEvent = "";
            this.dsWireCode.UpdateMethod = "";
            this.dsWireCode.UpdateTrigger = null;
            // 
            // schemadsWireCode
            // 
            this.schemadsWireCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireCodeL3DataTableCode,
            this.coldsWireCodeL3DataTableCode_Des});
            this.schemadsWireCode.TableName = "L3DataTable";
            // 
            // coldsWireCodeL3DataTableCode
            // 
            this.coldsWireCodeL3DataTableCode.Caption = "Code";
            this.coldsWireCodeL3DataTableCode.ColumnName = "Code";
            this.coldsWireCodeL3DataTableCode.Namespace = "";
            // 
            // coldsWireCodeL3DataTableCode_Des
            // 
            this.coldsWireCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coefficientDataGridViewTextBoxColumn
            // 
            this.coefficientDataGridViewTextBoxColumn.DataPropertyName = "Coefficient";
            this.coefficientDataGridViewTextBoxColumn.HeaderText = "喂线系数";
            this.coefficientDataGridViewTextBoxColumn.Name = "coefficientDataGridViewTextBoxColumn";
            // 
            // WireCoefficientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 322);
            this.Controls.Add(this.dvWireData);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WireCoefficientFrm";
            this.TabText = "喂线米重维护";
            this.Text = "喂线米重维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WireCoefficientFrm_FormClosing);
            this.Load += new System.EventHandler(this.WireCoefficientFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsWireData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWireData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsWireData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.BindingSource bsWireData;
        private System.Data.DataTable schemadsWireData;
        private System.Data.DataColumn coldsWireDataL3DataTableWireCode;
        private System.Data.DataColumn coldsWireDataL3DataTableCoefficient;
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
        private System.Windows.Forms.DataGridView dvWireData;
        private AppSvrHMI.L3DataSet dsWireCode;
        private System.Data.DataTable schemadsWireCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn wireCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coefficientDataGridViewTextBoxColumn;
    }
}