namespace BaseDataMag
{
    partial class IronLadleAgeQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleAgeQueryFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsQuery = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsQueryL3DataTableAge = new System.Data.DataColumn();
            this.coldsQueryL3DataTableTpc_No = new System.Data.DataColumn();
            this.coldsQueryL3DataTableWeight = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStartTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtEndTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dvQuery = new System.Windows.Forms.DataGridView();
            this.bsQuery = new System.Windows.Forms.BindingSource(this.components);
            this.tpcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // dsQuery
            // 
            this.dsQuery.AutoSubscribe = false;
            this.dsQuery.DataSetName = "L3DataSet";
            this.dsQuery.DeleteMethod = "";
            this.dsQuery.InsertMethod = "";
            this.dsQuery.L3DataAdapter = this.Adapter;
            this.dsQuery.LoadEvent = "";
            this.dsQuery.LoadTrigger = null;
            this.dsQuery.RefreshValve = 1000;
            this.dsQuery.SourceCommand = null;
            this.dsQuery.SourceCondition = "";
            this.dsQuery.SourceMethod = "";
            this.dsQuery.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsQuery.SourceURI = "";
            this.dsQuery.SubscribeTarget = null;
            this.dsQuery.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsQuery.UpdateEvent = "";
            this.dsQuery.UpdateMethod = "";
            this.dsQuery.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsQueryL3DataTableAge,
            this.coldsQueryL3DataTableTpc_No,
            this.coldsQueryL3DataTableWeight});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsQueryL3DataTableAge
            // 
            this.coldsQueryL3DataTableAge.Caption = "Age";
            this.coldsQueryL3DataTableAge.ColumnName = "Age";
            this.coldsQueryL3DataTableAge.DataType = typeof(int);
            this.coldsQueryL3DataTableAge.Namespace = "";
            // 
            // coldsQueryL3DataTableTpc_No
            // 
            this.coldsQueryL3DataTableTpc_No.Caption = "Tpc_No";
            this.coldsQueryL3DataTableTpc_No.ColumnName = "Tpc_No";
            this.coldsQueryL3DataTableTpc_No.Namespace = "";
            // 
            // coldsQueryL3DataTableWeight
            // 
            this.coldsQueryL3DataTableWeight.Caption = "Weight";
            this.coldsQueryL3DataTableWeight.ColumnName = "Weight";
            this.coldsQueryL3DataTableWeight.DataType = typeof(double);
            this.coldsQueryL3DataTableWeight.DefaultValue = 0;
            this.coldsQueryL3DataTableWeight.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.dtStartTime,
            this.toolStripLabel1,
            this.dtEndTime,
            this.toolStripLabel3,
            this.btnQuery});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(420, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "日期:";
            // 
            // dtStartTime
            // 
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtStartTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStartTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStartTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStartTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(120, 22);
            this.dtStartTime.Text = "2009-04-09 11:48";
            this.dtStartTime.Value = new System.DateTime(2009, 4, 9, 11, 48, 0, 727);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel1.Text = "-";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtEndTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEndTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEndTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEndTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(120, 22);
            this.dtEndTime.Text = "2009-04-09 11:48";
            this.dtEndTime.Value = new System.DateTime(2009, 4, 9, 11, 48, 46, 643);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(19, 22);
            this.toolStripLabel3.Text = "    ";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(51, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dvQuery
            // 
            this.dvQuery.AllowUserToAddRows = false;
            this.dvQuery.AllowUserToDeleteRows = false;
            this.dvQuery.AutoGenerateColumns = false;
            this.dvQuery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tpcNoDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.Weight});
            this.dvQuery.DataSource = this.bsQuery;
            this.dvQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvQuery.Location = new System.Drawing.Point(0, 25);
            this.dvQuery.Name = "dvQuery";
            this.dvQuery.ReadOnly = true;
            this.dvQuery.RowTemplate.Height = 23;
            this.dvQuery.Size = new System.Drawing.Size(420, 240);
            this.dvQuery.TabIndex = 6;
            // 
            // bsQuery
            // 
            this.bsQuery.DataMember = "L3DataTable";
            this.bsQuery.DataSource = this.dsQuery;
            // 
            // tpcNoDataGridViewTextBoxColumn
            // 
            this.tpcNoDataGridViewTextBoxColumn.DataPropertyName = "Tpc_No";
            this.tpcNoDataGridViewTextBoxColumn.HeaderText = "罐号";
            this.tpcNoDataGridViewTextBoxColumn.Name = "tpcNoDataGridViewTextBoxColumn";
            this.tpcNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.ageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ageDataGridViewTextBoxColumn.HeaderText = "罐龄";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.Weight.DefaultCellStyle = dataGridViewCellStyle2;
            this.Weight.HeaderText = "净重";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // IronLadleAgeQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 265);
            this.Controls.Add(this.dvQuery);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "IronLadleAgeQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "罐龄查询";
            this.Load += new System.EventHandler(this.EnergyDataAddModFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsQuery;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsQueryL3DataTableAge;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private buttonHide.ToolStripToriDateTimePicker dtStartTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEndTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Data.DataColumn coldsQueryL3DataTableTpc_No;
        private System.Windows.Forms.DataGridView dvQuery;
        private System.Windows.Forms.BindingSource bsQuery;
        private System.Data.DataColumn coldsQueryL3DataTableWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
    }
}