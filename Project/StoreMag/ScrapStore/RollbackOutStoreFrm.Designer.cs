namespace StoreMag.ScrapStore
{
    partial class RollbackOutStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RollbackOutStoreFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.checkflag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.scrapSlotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCRAPWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIGIRONWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStore = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSCRAPWT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePIGIRONWT = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableLOGTIME = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablecheckflag = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelOutStore = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.cmdCancelOutStore = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(395, 292);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkflag,
            this.scrapSlotIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.sCRAPWTDataGridViewTextBoxColumn,
            this.pIGIRONWTDataGridViewTextBoxColumn,
            this.lOGTIMEDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsOutStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(395, 267);
            this.dvInStore.TabIndex = 29;
            // 
            // checkflag
            // 
            this.checkflag.DataPropertyName = "checkflag";
            this.checkflag.FalseValue = "0";
            this.checkflag.HeaderText = "选择";
            this.checkflag.Name = "checkflag";
            this.checkflag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkflag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkflag.TrueValue = "1";
            this.checkflag.Width = 54;
            // 
            // scrapSlotIDDataGridViewTextBoxColumn
            // 
            this.scrapSlotIDDataGridViewTextBoxColumn.DataPropertyName = "Scrap_Slot_ID";
            this.scrapSlotIDDataGridViewTextBoxColumn.HeaderText = "废钢斗号";
            this.scrapSlotIDDataGridViewTextBoxColumn.Name = "scrapSlotIDDataGridViewTextBoxColumn";
            this.scrapSlotIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.scrapSlotIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "出库量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 66;
            // 
            // sCRAPWTDataGridViewTextBoxColumn
            // 
            this.sCRAPWTDataGridViewTextBoxColumn.DataPropertyName = "SCRAPWT";
            this.sCRAPWTDataGridViewTextBoxColumn.HeaderText = "废钢";
            this.sCRAPWTDataGridViewTextBoxColumn.Name = "sCRAPWTDataGridViewTextBoxColumn";
            this.sCRAPWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sCRAPWTDataGridViewTextBoxColumn.Width = 54;
            // 
            // pIGIRONWTDataGridViewTextBoxColumn
            // 
            this.pIGIRONWTDataGridViewTextBoxColumn.DataPropertyName = "PIGIRONWT";
            this.pIGIRONWTDataGridViewTextBoxColumn.HeaderText = "生铁";
            this.pIGIRONWTDataGridViewTextBoxColumn.Name = "pIGIRONWTDataGridViewTextBoxColumn";
            this.pIGIRONWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pIGIRONWTDataGridViewTextBoxColumn.Width = 54;
            // 
            // lOGTIMEDataGridViewTextBoxColumn
            // 
            this.lOGTIMEDataGridViewTextBoxColumn.DataPropertyName = "LOGTIME";
            this.lOGTIMEDataGridViewTextBoxColumn.HeaderText = "出库日期";
            this.lOGTIMEDataGridViewTextBoxColumn.Name = "lOGTIMEDataGridViewTextBoxColumn";
            this.lOGTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStore;
            // 
            // dsOutStore
            // 
            this.dsOutStore.AutoSubscribe = true;
            this.dsOutStore.DataSetName = "L3DataSet";
            this.dsOutStore.DeleteMethod = "";
            this.dsOutStore.InsertMethod = "";
            this.dsOutStore.L3DataAdapter = this.Adapter;
            this.dsOutStore.LoadEvent = "Click";
            this.dsOutStore.LoadTrigger = null;
            this.dsOutStore.RefreshValve = 1000;
            this.dsOutStore.SourceCommand = null;
            this.dsOutStore.SourceCondition = "";
            this.dsOutStore.SourceMethod = "GetScrapes";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsOutStore.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.dsOutStore.SubscribeTarget = null;
            this.dsOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsOutStore.UpdateEvent = "Click";
            this.dsOutStore.UpdateMethod = "";
            this.dsOutStore.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableAmount,
            this.coldsOutStoreL3DataTableScrap_Slot_ID,
            this.coldsOutStoreL3DataTableSCRAPWT,
            this.coldsOutStoreL3DataTablePIGIRONWT,
            this.coldsOutStoreL3DataTableLOGTIME,
            this.coldsOutStoreL3DataTablecheckflag});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "AMOUNT";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsInStoreL3DataTableAmount.DefaultValue = 0;
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsOutStoreL3DataTableScrap_Slot_ID
            // 
            this.coldsOutStoreL3DataTableScrap_Slot_ID.Caption = "SCRAP_SLOT_ID";
            this.coldsOutStoreL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsOutStoreL3DataTableScrap_Slot_ID.DefaultValue = "";
            this.coldsOutStoreL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableSCRAPWT
            // 
            this.coldsOutStoreL3DataTableSCRAPWT.Caption = "SCRAPWT";
            this.coldsOutStoreL3DataTableSCRAPWT.ColumnName = "SCRAPWT";
            this.coldsOutStoreL3DataTableSCRAPWT.DataType = typeof(double);
            this.coldsOutStoreL3DataTableSCRAPWT.DefaultValue = 0;
            this.coldsOutStoreL3DataTableSCRAPWT.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePIGIRONWT
            // 
            this.coldsOutStoreL3DataTablePIGIRONWT.Caption = "PIGIRONWT";
            this.coldsOutStoreL3DataTablePIGIRONWT.ColumnName = "PIGIRONWT";
            this.coldsOutStoreL3DataTablePIGIRONWT.DataType = typeof(double);
            this.coldsOutStoreL3DataTablePIGIRONWT.DefaultValue = 0;
            this.coldsOutStoreL3DataTablePIGIRONWT.Namespace = "";
            // 
            // coldsOutStoreL3DataTableLOGTIME
            // 
            this.coldsOutStoreL3DataTableLOGTIME.Caption = "LOGTIME";
            this.coldsOutStoreL3DataTableLOGTIME.ColumnName = "LOGTIME";
            this.coldsOutStoreL3DataTableLOGTIME.DefaultValue = "";
            this.coldsOutStoreL3DataTableLOGTIME.Namespace = "";
            // 
            // coldsOutStoreL3DataTablecheckflag
            // 
            this.coldsOutStoreL3DataTablecheckflag.Caption = "checkflag";
            this.coldsOutStoreL3DataTablecheckflag.ColumnName = "checkflag";
            this.coldsOutStoreL3DataTablecheckflag.DataType = typeof(short);
            this.coldsOutStoreL3DataTablecheckflag.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsOutStore;
            this.bdN1.CountItem = null;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnCancelOutStore,
            this.btnRefresh});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = null;
            this.bdN1.MoveLastItem = null;
            this.bdN1.MoveNextItem = null;
            this.bdN1.MovePreviousItem = null;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = null;
            this.bdN1.Size = new System.Drawing.Size(395, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnCancelOutStore
            // 
            this.btnCancelOutStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOutStore.Image")));
            this.btnCancelOutStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelOutStore.Name = "btnCancelOutStore";
            this.btnCancelOutStore.Size = new System.Drawing.Size(73, 22);
            this.btnCancelOutStore.Text = "取消出库";
            this.btnCancelOutStore.Click += new System.EventHandler(this.btnCancelOutStore_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmdCancelOutStore
            // 
            this.cmdCancelOutStore.Adapter = this.Adapter;
            this.cmdCancelOutStore.MergeReturnTarget = false;
            this.cmdCancelOutStore.Method = "ScrapCancelOutStore";
            this.cmdCancelOutStore.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdCancelOutStore.Parameters.Add(this.l3CommandParameter1);
            this.cmdCancelOutStore.ReturnTarget = null;
            this.cmdCancelOutStore.ReturnTargetProperty = null;
            this.cmdCancelOutStore.Trigger = null;
            this.cmdCancelOutStore.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "checkflag = 1";
            this.l3CommandParameter1.SourceObject = this.dsOutStore;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = "";
            // 
            // RollbackOutStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 292);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RollbackOutStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "废钢撤销出库操作";
            this.Text = "废钢撤销出库操作";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RollbackOutStoreFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private AppSvrHMI.L3DataSet dsOutStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableScrap_Slot_ID;
        private System.Data.DataColumn coldsOutStoreL3DataTableSCRAPWT;
        private System.Data.DataColumn coldsOutStoreL3DataTablePIGIRONWT;
        private System.Data.DataColumn coldsOutStoreL3DataTableLOGTIME;
        private AppSvrHMI.L3Command cmdCancelOutStore;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripButton btnCancelOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTablecheckflag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkflag;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapSlotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRAPWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIGIRONWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGTIMEDataGridViewTextBoxColumn;
    }
}