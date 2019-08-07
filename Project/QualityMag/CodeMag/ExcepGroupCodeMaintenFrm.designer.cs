namespace QualityMag.CodeMag
{
    partial class ExcepGroupCodeMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcepGroupCodeMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bsExcepGroupCodeMainten = new System.Windows.Forms.BindingSource(this.components);
            this.dsExcepGroupCodeMainten = new AppSvrHMI.L3DataSet();
            this.schemadsExcepGroupCodeMainten = new System.Data.DataTable();
            this.coldsExcepGroupCodeMaintenL3DataTableCode = new System.Data.DataColumn();
            this.coldsExcepGroupCodeMaintenL3DataTableDes = new System.Data.DataColumn();
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanelExcepGroupCodeMainten = new HMIBase.HMIRootPanel();
            this.dvExcepGroupCodeMainten = new System.Windows.Forms.DataGridView();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcepGroupCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcepGroupCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcepGroupCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelExcepGroupCodeMainten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcepGroupCodeMainten)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.btnOK,
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
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // bsExcepGroupCodeMainten
            // 
            this.bsExcepGroupCodeMainten.DataMember = "L3DataTable";
            this.bsExcepGroupCodeMainten.DataSource = this.dsExcepGroupCodeMainten;
            // 
            // dsExcepGroupCodeMainten
            // 
            this.dsExcepGroupCodeMainten.AutoSubscribe = true;
            this.dsExcepGroupCodeMainten.DataSetName = "L3DataSet";
            this.dsExcepGroupCodeMainten.DeleteMethod = null;
            this.dsExcepGroupCodeMainten.InsertMethod = null;
            this.dsExcepGroupCodeMainten.L3DataAdapter = this.Adapter;
            this.dsExcepGroupCodeMainten.LoadEvent = "Click";
            this.dsExcepGroupCodeMainten.LoadTrigger = null;
            this.dsExcepGroupCodeMainten.RefreshValve = 1000;
            this.dsExcepGroupCodeMainten.SourceCommand = null;
            this.dsExcepGroupCodeMainten.SourceCondition = null;
            this.dsExcepGroupCodeMainten.SourceMethod = "";
            this.dsExcepGroupCodeMainten.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExcepGroupCodeMainten.SourceURI = "XGMESLogic\\QualityMag\\CQA_Except_Group_Code";
            this.dsExcepGroupCodeMainten.SubscribeTarget = null;
            this.dsExcepGroupCodeMainten.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExcepGroupCodeMainten});
            this.dsExcepGroupCodeMainten.UpdateEvent = "Click";
            this.dsExcepGroupCodeMainten.UpdateMethod = null;
            this.dsExcepGroupCodeMainten.UpdateTrigger = null;
            // 
            // schemadsExcepGroupCodeMainten
            // 
            this.schemadsExcepGroupCodeMainten.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExcepGroupCodeMaintenL3DataTableCode,
            this.coldsExcepGroupCodeMaintenL3DataTableDes});
            this.schemadsExcepGroupCodeMainten.TableName = "L3DataTable";
            // 
            // coldsExcepGroupCodeMaintenL3DataTableCode
            // 
            this.coldsExcepGroupCodeMaintenL3DataTableCode.Caption = "Code";
            this.coldsExcepGroupCodeMaintenL3DataTableCode.ColumnName = "Code";
            this.coldsExcepGroupCodeMaintenL3DataTableCode.Namespace = "";
            // 
            // coldsExcepGroupCodeMaintenL3DataTableDes
            // 
            this.coldsExcepGroupCodeMaintenL3DataTableDes.Caption = "Des";
            this.coldsExcepGroupCodeMaintenL3DataTableDes.ColumnName = "Des";
            this.coldsExcepGroupCodeMaintenL3DataTableDes.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsExcepGroupCodeMainten;
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
            this.toolStripLabel3});
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel3.Text = " ";
            // 
            // hmiRootPanelExcepGroupCodeMainten
            // 
            this.hmiRootPanelExcepGroupCodeMainten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelExcepGroupCodeMainten.Controls.Add(this.dvExcepGroupCodeMainten);
            this.hmiRootPanelExcepGroupCodeMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelExcepGroupCodeMainten.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelExcepGroupCodeMainten.Name = "hmiRootPanelExcepGroupCodeMainten";
            this.hmiRootPanelExcepGroupCodeMainten.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelExcepGroupCodeMainten.TabIndex = 17;
            // 
            // dvExcepGroupCodeMainten
            // 
            this.dvExcepGroupCodeMainten.AllowUserToAddRows = false;
            this.dvExcepGroupCodeMainten.AutoGenerateColumns = false;
            this.dvExcepGroupCodeMainten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvExcepGroupCodeMainten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvExcepGroupCodeMainten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.desDataGridViewTextBoxColumn});
            this.dvExcepGroupCodeMainten.DataSource = this.bsExcepGroupCodeMainten;
            this.dvExcepGroupCodeMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExcepGroupCodeMainten.Location = new System.Drawing.Point(0, 0);
            this.dvExcepGroupCodeMainten.Name = "dvExcepGroupCodeMainten";
            this.dvExcepGroupCodeMainten.RowTemplate.Height = 23;
            this.dvExcepGroupCodeMainten.Size = new System.Drawing.Size(1016, 608);
            this.dvExcepGroupCodeMainten.TabIndex = 0;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "代码";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // desDataGridViewTextBoxColumn
            // 
            this.desDataGridViewTextBoxColumn.DataPropertyName = "Des";
            this.desDataGridViewTextBoxColumn.HeaderText = "内容";
            this.desDataGridViewTextBoxColumn.Name = "desDataGridViewTextBoxColumn";
            // 
            // ExcepGroupCodeMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelExcepGroupCodeMainten);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcepGroupCodeMaintenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "异常处理组号代码维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcepGroupCodeMaintenFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcepGroupCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcepGroupCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcepGroupCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelExcepGroupCodeMainten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvExcepGroupCodeMainten)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsExcepGroupCodeMainten;
        private AppSvrHMI.L3DataSet dsExcepGroupCodeMainten;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private HMIBase.HMIRootPanel hmiRootPanelExcepGroupCodeMainten;
        private System.Windows.Forms.DataGridView dvExcepGroupCodeMainten;
        private System.Data.DataTable schemadsExcepGroupCodeMainten;
        private System.Data.DataColumn coldsExcepGroupCodeMaintenL3DataTableCode;
        private System.Data.DataColumn coldsExcepGroupCodeMaintenL3DataTableDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desDataGridViewTextBoxColumn;
    }
}