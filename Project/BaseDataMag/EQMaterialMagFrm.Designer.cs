namespace BaseDataMag
{
    partial class EQMaterialMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQMaterialMagFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvEQM = new System.Windows.Forms.DataGridView();
            this.matFactoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matGroupCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matGroupDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEQM = new System.Windows.Forms.BindingSource(this.components);
            this.dsEQM = new AppSvrHMI.L3DataSet();
            this.schemadsEQM = new System.Data.DataTable();
            this.coldsEQML3DataTableGUID = new System.Data.DataColumn();
            this.coldsEQML3DataTableName = new System.Data.DataColumn();
            this.coldsEQML3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsEQML3DataTableMatName = new System.Data.DataColumn();
            this.coldsEQML3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.coldsEQML3DataTableMatGroup_Des = new System.Data.DataColumn();
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvEQM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEQM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEQM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEQM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvEQM);
            this.hmiRootPanel1.Controls.Add(this.bnM);
            this.hmiRootPanel1.Controls.Add(this.tSp1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 650);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvEQM
            // 
            this.dvEQM.AllowUserToAddRows = false;
            this.dvEQM.AutoGenerateColumns = false;
            this.dvEQM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvEQM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvEQM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvEQM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvEQM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matFactoryDataGridViewTextBoxColumn,
            this.matNameDataGridViewTextBoxColumn,
            this.matGroupCodeDataGridViewTextBoxColumn,
            this.matGroupDesDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvEQM.DataSource = this.bsEQM;
            this.dvEQM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvEQM.Location = new System.Drawing.Point(0, 68);
            this.dvEQM.MultiSelect = false;
            this.dvEQM.Name = "dvEQM";
            this.dvEQM.ReadOnly = true;
            this.dvEQM.RowTemplate.Height = 23;
            this.dvEQM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvEQM.Size = new System.Drawing.Size(1000, 582);
            this.dvEQM.TabIndex = 30;
            this.dvEQM.Sorted += new System.EventHandler(this.dvEQM_Sorted);
            this.dvEQM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvEQM_CellMouseDoubleClick);
            // 
            // matFactoryDataGridViewTextBoxColumn
            // 
            this.matFactoryDataGridViewTextBoxColumn.DataPropertyName = "MatFactory";
            this.matFactoryDataGridViewTextBoxColumn.HeaderText = "材料厂家";
            this.matFactoryDataGridViewTextBoxColumn.Name = "matFactoryDataGridViewTextBoxColumn";
            this.matFactoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matNameDataGridViewTextBoxColumn
            // 
            this.matNameDataGridViewTextBoxColumn.DataPropertyName = "MatName";
            this.matNameDataGridViewTextBoxColumn.HeaderText = "材料名称";
            this.matNameDataGridViewTextBoxColumn.Name = "matNameDataGridViewTextBoxColumn";
            this.matNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matGroupCodeDataGridViewTextBoxColumn
            // 
            this.matGroupCodeDataGridViewTextBoxColumn.DataPropertyName = "MatGroup_Code";
            this.matGroupCodeDataGridViewTextBoxColumn.HeaderText = "材料组";
            this.matGroupCodeDataGridViewTextBoxColumn.Name = "matGroupCodeDataGridViewTextBoxColumn";
            this.matGroupCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // matGroupDesDataGridViewTextBoxColumn
            // 
            this.matGroupDesDataGridViewTextBoxColumn.DataPropertyName = "MatGroup_Des";
            this.matGroupDesDataGridViewTextBoxColumn.HeaderText = "材料组描述";
            this.matGroupDesDataGridViewTextBoxColumn.Name = "matGroupDesDataGridViewTextBoxColumn";
            this.matGroupDesDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bsEQM
            // 
            this.bsEQM.DataMember = "L3DataTable";
            this.bsEQM.DataSource = this.dsEQM;
            // 
            // dsEQM
            // 
            this.dsEQM.AutoSubscribe = true;
            this.dsEQM.DataSetName = "L3DataSet";
            this.dsEQM.DeleteMethod = null;
            this.dsEQM.InsertMethod = null;
            this.dsEQM.L3DataAdapter = this.Adapter;
            this.dsEQM.LoadEvent = "Click";
            this.dsEQM.LoadTrigger = null;
            this.dsEQM.RefreshValve = 1000;
            this.dsEQM.SourceCommand = null;
            this.dsEQM.SourceCondition = "";
            this.dsEQM.SourceMethod = "";
            this.dsEQM.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsEQM.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsEQM.SubscribeTarget = null;
            this.dsEQM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEQM});
            this.dsEQM.UpdateEvent = "Click";
            this.dsEQM.UpdateMethod = null;
            this.dsEQM.UpdateTrigger = null;
            // 
            // schemadsEQM
            // 
            this.schemadsEQM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEQML3DataTableGUID,
            this.coldsEQML3DataTableName,
            this.coldsEQML3DataTableMatFactory,
            this.coldsEQML3DataTableMatName,
            this.coldsEQML3DataTableMatGroup_Code,
            this.coldsEQML3DataTableMatGroup_Des});
            this.schemadsEQM.TableName = "L3DataTable";
            // 
            // coldsEQML3DataTableGUID
            // 
            this.coldsEQML3DataTableGUID.Caption = "GUID";
            this.coldsEQML3DataTableGUID.ColumnName = "GUID";
            this.coldsEQML3DataTableGUID.Namespace = "";
            // 
            // coldsEQML3DataTableName
            // 
            this.coldsEQML3DataTableName.Caption = "Name";
            this.coldsEQML3DataTableName.ColumnName = "Name";
            this.coldsEQML3DataTableName.Namespace = "";
            // 
            // coldsEQML3DataTableMatFactory
            // 
            this.coldsEQML3DataTableMatFactory.Caption = "MatFactory";
            this.coldsEQML3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsEQML3DataTableMatFactory.Namespace = "";
            // 
            // coldsEQML3DataTableMatName
            // 
            this.coldsEQML3DataTableMatName.Caption = "MatName";
            this.coldsEQML3DataTableMatName.ColumnName = "MatName";
            this.coldsEQML3DataTableMatName.Namespace = "";
            // 
            // coldsEQML3DataTableMatGroup_Code
            // 
            this.coldsEQML3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsEQML3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsEQML3DataTableMatGroup_Code.Namespace = "";
            // 
            // coldsEQML3DataTableMatGroup_Des
            // 
            this.coldsEQML3DataTableMatGroup_Des.Caption = "MatGroup_Des";
            this.coldsEQML3DataTableMatGroup_Des.ColumnName = "MatGroup_Des";
            this.coldsEQML3DataTableMatGroup_Des.Namespace = "";
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsEQM;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnM.Location = new System.Drawing.Point(0, 43);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(1000, 25);
            this.bnM.TabIndex = 29;
            this.bnM.Text = "bindingNavigator1";
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
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 28;
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "BtnMaterialFacMaint");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "BtnMaterialFacMaint");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "BtnMaterialFacMaint");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BtnMaterialFacMaint");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "BtnMaterialFacMaint");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EQMaterialMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EQMaterialMagFrm";
            this.TabText = "工器具材料厂家及材料维护";
            this.Text = "EQMaterialMagFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EQMaterialMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.EQMaterialMagFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvEQM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEQM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEQM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEQM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridView dvEQM;
        private System.Windows.Forms.BindingSource bsEQM;
        private AppSvrHMI.L3DataSet dsEQM;
        private System.Data.DataTable schemadsEQM;
        private System.Data.DataColumn coldsEQML3DataTableGUID;
        private System.Data.DataColumn coldsEQML3DataTableName;
        private System.Data.DataColumn coldsEQML3DataTableMatFactory;
        private System.Data.DataColumn coldsEQML3DataTableMatName;
        private System.Data.DataColumn coldsEQML3DataTableMatGroup_Code;
        private System.Data.DataColumn coldsEQML3DataTableMatGroup_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn matFactoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matGroupCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matGroupDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}