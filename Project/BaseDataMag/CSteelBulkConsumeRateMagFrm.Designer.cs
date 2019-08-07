namespace BaseDataMag
{
    partial class CSteelBulkConsumeRateMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSteelBulkConsumeRateMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.bsUnitConsume = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitConsume = new AppSvrHMI.L3DataSet();
            this.schemadsMatPrice = new System.Data.DataTable();
            this.coldsMatPriceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableNAME = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableUnit_Consume = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableMatCode = new System.Data.DataColumn();
            this.cmdpMatPrice = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvUnitConsume = new System.Windows.Forms.DataGridView();
            this.dsUnitCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableNC_Code = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitConsumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
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
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 24;
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
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // bsUnitConsume
            // 
            this.bsUnitConsume.DataMember = "L3DataTable";
            this.bsUnitConsume.DataSource = this.dsUnitConsume;
            // 
            // dsUnitConsume
            // 
            this.dsUnitConsume.AutoLoad = true;
            this.dsUnitConsume.AutoSubscribe = false;
            this.dsUnitConsume.DataSetName = "L3DataSet";
            this.dsUnitConsume.DeleteMethod = "";
            this.dsUnitConsume.InsertMethod = "";
            this.dsUnitConsume.L3DataAdapter = this.Adapter;
            this.dsUnitConsume.LoadEvent = "";
            this.dsUnitConsume.LoadTrigger = null;
            this.dsUnitConsume.RefreshValve = 1000;
            this.dsUnitConsume.SourceCommand = null;
            this.dsUnitConsume.SourceCondition = "";
            this.dsUnitConsume.SourceMethod = "";
            this.dsUnitConsume.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitConsume.SourceURI = "XGMESLogic\\BaseDataMag\\CSteelBulk_Consume_Rate";
            this.dsUnitConsume.SubscribeTarget = "";
            this.dsUnitConsume.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatPrice});
            this.dsUnitConsume.UpdateEvent = "";
            this.dsUnitConsume.UpdateMethod = "";
            this.dsUnitConsume.UpdateTrigger = null;
            // 
            // schemadsMatPrice
            // 
            this.schemadsMatPrice.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatPriceL3DataTableGUID,
            this.coldsMatPriceL3DataTableNAME,
            this.coldsUnitConsumeL3DataTableUnit_Consume,
            this.coldsUnitConsumeL3DataTableMatCode});
            this.schemadsMatPrice.TableName = "L3DataTable";
            // 
            // coldsMatPriceL3DataTableGUID
            // 
            this.coldsMatPriceL3DataTableGUID.Caption = "GUID";
            this.coldsMatPriceL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatPriceL3DataTableGUID.Namespace = "";
            // 
            // coldsMatPriceL3DataTableNAME
            // 
            this.coldsMatPriceL3DataTableNAME.Caption = "Name";
            this.coldsMatPriceL3DataTableNAME.ColumnName = "NAME";
            this.coldsMatPriceL3DataTableNAME.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableUnit_Consume
            // 
            this.coldsUnitConsumeL3DataTableUnit_Consume.Caption = "Unit_Consume";
            this.coldsUnitConsumeL3DataTableUnit_Consume.ColumnName = "Unit_Consume";
            this.coldsUnitConsumeL3DataTableUnit_Consume.DataType = typeof(double);
            this.coldsUnitConsumeL3DataTableUnit_Consume.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableMatCode
            // 
            this.coldsUnitConsumeL3DataTableMatCode.Caption = "MatCode";
            this.coldsUnitConsumeL3DataTableMatCode.ColumnName = "MatCode";
            this.coldsUnitConsumeL3DataTableMatCode.Namespace = "";
            // 
            // cmdpMatPrice
            // 
            this.cmdpMatPrice.AcceptAfterExecuted = false;
            this.cmdpMatPrice.ConstantValue = null;
            this.cmdpMatPrice.MergeTarget = false;
            this.cmdpMatPrice.SourceFilter = null;
            this.cmdpMatPrice.SourceObject = null;
            this.cmdpMatPrice.SourceProperty = null;
            this.cmdpMatPrice.TargetObject = null;
            this.cmdpMatPrice.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvUnitConsume);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 657);
            this.hmiRootPanel1.TabIndex = 26;
            // 
            // dvUnitConsume
            // 
            this.dvUnitConsume.AllowUserToAddRows = false;
            this.dvUnitConsume.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvUnitConsume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvUnitConsume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvUnitConsume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matCodeDataGridViewTextBoxColumn,
            this.unitConsumeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvUnitConsume.DataSource = this.bsUnitConsume;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvUnitConsume.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvUnitConsume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUnitConsume.Location = new System.Drawing.Point(0, 0);
            this.dvUnitConsume.Name = "dvUnitConsume";
            this.dvUnitConsume.RowTemplate.Height = 23;
            this.dvUnitConsume.Size = new System.Drawing.Size(1000, 657);
            this.dvUnitConsume.TabIndex = 0;
            this.dvUnitConsume.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMatPrice_DataError);
            // 
            // dsUnitCode
            // 
            this.dsUnitCode.AutoLoad = true;
            this.dsUnitCode.AutoSubscribe = false;
            this.dsUnitCode.DataSetName = "L3DataSet";
            this.dsUnitCode.DeleteMethod = "";
            this.dsUnitCode.InsertMethod = "";
            this.dsUnitCode.L3DataAdapter = this.Adapter;
            this.dsUnitCode.LoadEvent = "";
            this.dsUnitCode.LoadTrigger = null;
            this.dsUnitCode.RefreshValve = 1000;
            this.dsUnitCode.SourceCommand = null;
            this.dsUnitCode.SourceCondition = "";
            this.dsUnitCode.SourceMethod = "";
            this.dsUnitCode.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsUnitCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitCode.SubscribeTarget = "";
            this.dsUnitCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsUnitCode.UpdateEvent = "";
            this.dsUnitCode.UpdateMethod = "";
            this.dsUnitCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTableGUID,
            this.coldsMatCodeL3DataTableName,
            this.coldsMatCodeL3DataTableCode,
            this.coldsMatCodeL3DataTableCode_Des,
            this.coldsMatCodeL3DataTableCode_Group,
            this.coldsMatCodeL3DataTableCode_Group_Des,
            this.coldsMatCodeL3DataTableCode_Val_Str,
            this.coldsMatCodeL3DataTableCode_Val_Long,
            this.coldsMatCodeL3DataTableCode_Val_Double,
            this.coldsMatCodeL3DataTableNC_Code});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTableGUID
            // 
            this.coldsMatCodeL3DataTableGUID.Caption = "GUID";
            this.coldsMatCodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatCodeL3DataTableGUID.Namespace = "";
            // 
            // coldsMatCodeL3DataTableName
            // 
            this.coldsMatCodeL3DataTableName.Caption = "Name";
            this.coldsMatCodeL3DataTableName.ColumnName = "Name";
            this.coldsMatCodeL3DataTableName.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode
            // 
            this.coldsMatCodeL3DataTableCode.Caption = "Code";
            this.coldsMatCodeL3DataTableCode.ColumnName = "Code";
            this.coldsMatCodeL3DataTableCode.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Des
            // 
            this.coldsMatCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group
            // 
            this.coldsMatCodeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group_Des
            // 
            this.coldsMatCodeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Str
            // 
            this.coldsMatCodeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Long
            // 
            this.coldsMatCodeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsMatCodeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Double
            // 
            this.coldsMatCodeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsMatCodeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsMatCodeL3DataTableNC_Code
            // 
            this.coldsMatCodeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ele_Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "合金编码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ele_Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "合金单价";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn3.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // matCodeDataGridViewTextBoxColumn
            // 
            this.matCodeDataGridViewTextBoxColumn.DataPropertyName = "MatCode";
            this.matCodeDataGridViewTextBoxColumn.DataSource = this.dsUnitCode;
            this.matCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.matCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.matCodeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matCodeDataGridViewTextBoxColumn.HeaderText = "物料代码";
            this.matCodeDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.matCodeDataGridViewTextBoxColumn.Name = "matCodeDataGridViewTextBoxColumn";
            this.matCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.matCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.matCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.matCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // unitConsumeDataGridViewTextBoxColumn
            // 
            this.unitConsumeDataGridViewTextBoxColumn.DataPropertyName = "Unit_Consume";
            this.unitConsumeDataGridViewTextBoxColumn.HeaderText = "单耗指标";
            this.unitConsumeDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.unitConsumeDataGridViewTextBoxColumn.Name = "unitConsumeDataGridViewTextBoxColumn";
            this.unitConsumeDataGridViewTextBoxColumn.Width = 150;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // CSteelBulkConsumeRateMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CSteelBulkConsumeRateMagFrm";
            this.TabText = "钢铁料散装料指标单耗管理";
            this.Text = "钢铁料散装料指标单耗管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CSteelBulkConsumeRateMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.CSteelBulkConsumeRateMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvUnitConsume;
        private AppSvrHMI.L3DataSet dsUnitConsume;
        private AppSvrHMI.L3CommandParameter cmdpMatPrice;
        private System.Data.DataTable schemadsMatPrice;
        private System.Data.DataColumn coldsMatPriceL3DataTableGUID;
        private System.Data.DataColumn coldsMatPriceL3DataTableNAME;
        private System.Windows.Forms.BindingSource bsUnitConsume;
        private AppSvrHMI.L3DataSet dsUnitCode;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableGUID;
        private System.Data.DataColumn coldsMatCodeL3DataTableName;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsMatCodeL3DataTableNC_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableUnit_Consume;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableMatCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn matCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitConsumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}