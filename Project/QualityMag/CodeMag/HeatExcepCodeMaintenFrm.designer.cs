namespace QualityMag.CodeMag
{
    partial class HeatExcepCodeMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeatExcepCodeMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsHeatExcepCodeMainten = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatExcepCodeMainten = new AppSvrHMI.L3DataSet();
            this.schemadsHeatExcepCodeMainten = new System.Data.DataTable();
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsHeatExcepCodeMaintenL3DataTableUnit = new System.Data.DataColumn();
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag = new System.Data.DataColumn();
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
            this.hmiRootPanelHeatExcepCodeMainten = new HMIBase.HMIRootPanel();
            this.dvHeatExcepCodeMainten = new System.Windows.Forms.DataGridView();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoJudgeFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcepCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcepCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcepCodeMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelHeatExcepCodeMainten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcepCodeMainten)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnExceptionCode");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnExceptionCode");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnExceptionCode");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOK
            // 
            this.Adapter.SetAccessRight(this.btnOK, "btnExceptionCode");
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnExceptionCode");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // bsHeatExcepCodeMainten
            // 
            this.bsHeatExcepCodeMainten.DataMember = "L3DataTable";
            this.bsHeatExcepCodeMainten.DataSource = this.dsHeatExcepCodeMainten;
            // 
            // dsHeatExcepCodeMainten
            // 
            this.dsHeatExcepCodeMainten.AutoSubscribe = true;
            this.dsHeatExcepCodeMainten.DataSetName = "L3DataSet";
            this.dsHeatExcepCodeMainten.DeleteMethod = null;
            this.dsHeatExcepCodeMainten.InsertMethod = null;
            this.dsHeatExcepCodeMainten.L3DataAdapter = this.Adapter;
            this.dsHeatExcepCodeMainten.LoadEvent = "Click";
            this.dsHeatExcepCodeMainten.LoadTrigger = null;
            this.dsHeatExcepCodeMainten.RefreshValve = 1000;
            this.dsHeatExcepCodeMainten.SourceCommand = null;
            this.dsHeatExcepCodeMainten.SourceCondition = null;
            this.dsHeatExcepCodeMainten.SourceMethod = "";
            this.dsHeatExcepCodeMainten.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatExcepCodeMainten.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
            this.dsHeatExcepCodeMainten.SubscribeTarget = null;
            this.dsHeatExcepCodeMainten.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatExcepCodeMainten});
            this.dsHeatExcepCodeMainten.UpdateEvent = "Click";
            this.dsHeatExcepCodeMainten.UpdateMethod = null;
            this.dsHeatExcepCodeMainten.UpdateTrigger = null;
            // 
            // schemadsHeatExcepCodeMainten
            // 
            this.schemadsHeatExcepCodeMainten.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Code,
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Des,
            this.coldsHeatExcepCodeMaintenL3DataTableUnit,
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag});
            this.schemadsHeatExcepCodeMainten.TableName = "L3DataTable";
            // 
            // coldsHeatExcepCodeMaintenL3DataTableExceptional_Code
            // 
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsHeatExcepCodeMaintenL3DataTableExceptional_Des
            // 
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Des.Caption = "Exceptional_Des";
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Des.ColumnName = "Exceptional_Des";
            this.coldsHeatExcepCodeMaintenL3DataTableExceptional_Des.Namespace = "";
            // 
            // coldsHeatExcepCodeMaintenL3DataTableUnit
            // 
            this.coldsHeatExcepCodeMaintenL3DataTableUnit.Caption = "Unit";
            this.coldsHeatExcepCodeMaintenL3DataTableUnit.ColumnName = "Unit";
            this.coldsHeatExcepCodeMaintenL3DataTableUnit.Namespace = "";
            // 
            // coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag
            // 
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag.Caption = "Auto_Judge_Flag";
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag.ColumnName = "Auto_Judge_Flag";
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag.DataType = typeof(int);
            this.coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsHeatExcepCodeMainten;
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
            // hmiRootPanelHeatExcepCodeMainten
            // 
            this.hmiRootPanelHeatExcepCodeMainten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelHeatExcepCodeMainten.Controls.Add(this.dvHeatExcepCodeMainten);
            this.hmiRootPanelHeatExcepCodeMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelHeatExcepCodeMainten.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelHeatExcepCodeMainten.Name = "hmiRootPanelHeatExcepCodeMainten";
            this.hmiRootPanelHeatExcepCodeMainten.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelHeatExcepCodeMainten.TabIndex = 17;
            // 
            // dvHeatExcepCodeMainten
            // 
            this.dvHeatExcepCodeMainten.AllowUserToAddRows = false;
            this.dvHeatExcepCodeMainten.AutoGenerateColumns = false;
            this.dvHeatExcepCodeMainten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatExcepCodeMainten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvHeatExcepCodeMainten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.exceptionalDesDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.autoJudgeFlagDataGridViewTextBoxColumn});
            this.dvHeatExcepCodeMainten.DataSource = this.bsHeatExcepCodeMainten;
            this.dvHeatExcepCodeMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatExcepCodeMainten.Location = new System.Drawing.Point(0, 0);
            this.dvHeatExcepCodeMainten.Name = "dvHeatExcepCodeMainten";
            this.dvHeatExcepCodeMainten.RowTemplate.Height = 23;
            this.dvHeatExcepCodeMainten.Size = new System.Drawing.Size(1016, 608);
            this.dvHeatExcepCodeMainten.TabIndex = 0;
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            // 
            // exceptionalDesDataGridViewTextBoxColumn
            // 
            this.exceptionalDesDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Des";
            this.exceptionalDesDataGridViewTextBoxColumn.HeaderText = "内容";
            this.exceptionalDesDataGridViewTextBoxColumn.Name = "exceptionalDesDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "发生工序";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // autoJudgeFlagDataGridViewTextBoxColumn
            // 
            this.autoJudgeFlagDataGridViewTextBoxColumn.DataPropertyName = "Auto_Judge_Flag";
            this.autoJudgeFlagDataGridViewTextBoxColumn.HeaderText = "自动判定标志";
            this.autoJudgeFlagDataGridViewTextBoxColumn.Name = "autoJudgeFlagDataGridViewTextBoxColumn";
            // 
            // HeatExcepCodeMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelHeatExcepCodeMainten);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeatExcepCodeMaintenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "炉次品质异常代码维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeatExcepCodeMaintenFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatExcepCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcepCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcepCodeMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelHeatExcepCodeMainten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatExcepCodeMainten)).EndInit();
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
        private System.Windows.Forms.BindingSource bsHeatExcepCodeMainten;
        private AppSvrHMI.L3DataSet dsHeatExcepCodeMainten;
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
        private HMIBase.HMIRootPanel hmiRootPanelHeatExcepCodeMainten;
        private System.Windows.Forms.DataGridView dvHeatExcepCodeMainten;
        private System.Data.DataTable schemadsHeatExcepCodeMainten;
        private System.Data.DataColumn coldsHeatExcepCodeMaintenL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsHeatExcepCodeMaintenL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsHeatExcepCodeMaintenL3DataTableUnit;
        private System.Data.DataColumn coldsHeatExcepCodeMaintenL3DataTableAuto_Judge_Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoJudgeFlagDataGridViewTextBoxColumn;
    }
}