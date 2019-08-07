namespace QualityMag.QualityStandard
{
    partial class ExchangeSteelGradeMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeSteelGradeMagFrm));
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judgedSteelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsMainL3DataTableJudged_SteelGrade = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = null;
            this.bnMain.AutoSize = false;
            this.bnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnMain.BackgroundImage")));
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = null;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel5,
            this.txtSteelGrade,
            this.toolStripLabel2});
            this.bnMain.Location = new System.Drawing.Point(0, 43);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(838, 25);
            this.bnMain.TabIndex = 29;
            this.bnMain.Text = "bindingNavigator1";
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
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "钢种:";
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
            this.btnCancel,
            this.toolStripSeparator1,
            this.btnOutput});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(838, 43);
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
            this.Adapter.SetAccessRight(this.btnAdd, "btnSteeGradeChangeMap");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnSteeGradeChangeMap");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnSteeGradeChangeMap");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnSteeGradeChangeMap");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnSteeGradeChangeMap");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator1, "btnSteeGradeChangeMap");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutput
            // 
            this.Adapter.SetAccessRight(this.btnOutput, "btnSteeGradeChangeMap");
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(107, 40);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(838, 462);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.judgedSteelGradeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(0, 0);
            this.dvMain.Name = "dvMain";
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.Size = new System.Drawing.Size(838, 462);
            this.dvMain.TabIndex = 0;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.Width = 398;
            // 
            // judgedSteelGradeDataGridViewTextBoxColumn
            // 
            this.judgedSteelGradeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.judgedSteelGradeDataGridViewTextBoxColumn.DataPropertyName = "Judged_SteelGrade";
            this.judgedSteelGradeDataGridViewTextBoxColumn.HeaderText = "可改判钢种";
            this.judgedSteelGradeDataGridViewTextBoxColumn.Name = "judgedSteelGradeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "1=2";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\QualityMag\\CQA_ChangeSteel_Std";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableSteelGrade,
            this.coldsMainL3DataTableJudged_SteelGrade});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableSteelGrade
            // 
            this.coldsMainL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsMainL3DataTableJudged_SteelGrade
            // 
            this.coldsMainL3DataTableJudged_SteelGrade.Caption = "Judged_SteelGrade";
            this.coldsMainL3DataTableJudged_SteelGrade.ColumnName = "Judged_SteelGrade";
            this.coldsMainL3DataTableJudged_SteelGrade.Namespace = "";
            // 
            // ExchangeSteelGradeMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 530);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnMain);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExchangeSteelGradeMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢种改钢对照关系维护";
            this.Text = "钢种改钢对照关系维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExchangeSteelGradeMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.ExchangeSteelGradeMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvMain;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableSteelGrade;
        private System.Data.DataColumn coldsMainL3DataTableJudged_SteelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judgedSteelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOutput;
    }
}