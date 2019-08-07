namespace PlanMag
{
    partial class BOFStatusFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOFStatusFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBOFStatus = new System.Windows.Forms.DataGridView();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.newBOFFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsNewBOFFlag = new AppSvrHMI.L3DataSet();
            this.schemadsNewBOFFlag = new System.Data.DataTable();
            this.coldsNewBOFFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsNewBOFFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBOFStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOFStatus = new AppSvrHMI.L3DataSet();
            this.schemadsBOFStatus = new System.Data.DataTable();
            this.coldsBOFStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBOFStatusL3DataTableName = new System.Data.DataColumn();
            this.coldsBOFStatusL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsBOFStatusL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBOFStatusL3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBOFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(405, 43);
            this.tSp1.TabIndex = 28;
            this.tSp1.Text = "toolStrip1";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvBOFStatus);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(405, 200);
            this.hmiRootPanel1.TabIndex = 32;
            // 
            // dvBOFStatus
            // 
            this.dvBOFStatus.AllowUserToAddRows = false;
            this.dvBOFStatus.AutoGenerateColumns = false;
            this.dvBOFStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvBOFStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBOFStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOFIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.newBOFFlagDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvBOFStatus.DataSource = this.bsBOFStatus;
            this.dvBOFStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBOFStatus.Location = new System.Drawing.Point(0, 0);
            this.dvBOFStatus.Name = "dvBOFStatus";
            this.dvBOFStatus.RowHeadersVisible = false;
            this.dvBOFStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBOFStatus.RowTemplate.Height = 23;
            this.dvBOFStatus.Size = new System.Drawing.Size(401, 196);
            this.dvBOFStatus.TabIndex = 0;
            this.dvBOFStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBOFStatus_DataError);
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "转炉炉座";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsStatus
            // 
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = "";
            this.dsStatus.InsertMethod = "";
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "CODE_GROUP = \'BOFUseFlag\' and CODE is not null";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableCode,
            this.coldsStatusL3DataTableCode_Des});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableCode
            // 
            this.coldsStatusL3DataTableCode.Caption = "Code";
            this.coldsStatusL3DataTableCode.ColumnName = "Code";
            this.coldsStatusL3DataTableCode.Namespace = "";
            // 
            // coldsStatusL3DataTableCode_Des
            // 
            this.coldsStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.Namespace = "";
            // 
            // newBOFFlagDataGridViewTextBoxColumn
            // 
            this.newBOFFlagDataGridViewTextBoxColumn.DataPropertyName = "New_BOF_Flag";
            this.newBOFFlagDataGridViewTextBoxColumn.DataSource = this.dsNewBOFFlag;
            this.newBOFFlagDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.newBOFFlagDataGridViewTextBoxColumn.HeaderText = "新转炉标志";
            this.newBOFFlagDataGridViewTextBoxColumn.Name = "newBOFFlagDataGridViewTextBoxColumn";
            this.newBOFFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.newBOFFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.newBOFFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.newBOFFlagDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsNewBOFFlag
            // 
            this.dsNewBOFFlag.DataSetName = "L3DataSet";
            this.dsNewBOFFlag.DeleteMethod = "";
            this.dsNewBOFFlag.InsertMethod = "";
            this.dsNewBOFFlag.L3DataAdapter = this.Adapter;
            this.dsNewBOFFlag.LoadEvent = "Click";
            this.dsNewBOFFlag.LoadTrigger = null;
            this.dsNewBOFFlag.RefreshValve = 1000;
            this.dsNewBOFFlag.SourceCommand = null;
            this.dsNewBOFFlag.SourceCondition = "CODE_GROUP = \'BOF_TYPE\' and CODE is not null";
            this.dsNewBOFFlag.SourceMethod = "";
            this.dsNewBOFFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNewBOFFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsNewBOFFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNewBOFFlag});
            this.dsNewBOFFlag.UpdateEvent = "Click";
            this.dsNewBOFFlag.UpdateMethod = "";
            this.dsNewBOFFlag.UpdateTrigger = null;
            // 
            // schemadsNewBOFFlag
            // 
            this.schemadsNewBOFFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNewBOFFlagL3DataTableCode_Des,
            this.coldsNewBOFFlagL3DataTableCode_Val_Long});
            this.schemadsNewBOFFlag.TableName = "L3DataTable";
            // 
            // coldsNewBOFFlagL3DataTableCode_Des
            // 
            this.coldsNewBOFFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNewBOFFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNewBOFFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsNewBOFFlagL3DataTableCode_Val_Long
            // 
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsNewBOFFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsBOFStatus
            // 
            this.bsBOFStatus.DataMember = "L3DataTable";
            this.bsBOFStatus.DataSource = this.dsBOFStatus;
            // 
            // dsBOFStatus
            // 
            this.dsBOFStatus.DataSetName = "L3DataSet";
            this.dsBOFStatus.DeleteMethod = "";
            this.dsBOFStatus.InsertMethod = "";
            this.dsBOFStatus.L3DataAdapter = this.Adapter;
            this.dsBOFStatus.LoadEvent = "Click";
            this.dsBOFStatus.LoadTrigger = null;
            this.dsBOFStatus.RefreshValve = 1000;
            this.dsBOFStatus.SourceCommand = null;
            this.dsBOFStatus.SourceCondition = "";
            this.dsBOFStatus.SourceMethod = "";
            this.dsBOFStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFStatus.SourceURI = "XGMESLogic\\PlanMag\\CPlan_BOF_Status";
            this.dsBOFStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFStatus});
            this.dsBOFStatus.UpdateEvent = "Click";
            this.dsBOFStatus.UpdateMethod = "";
            this.dsBOFStatus.UpdateTrigger = null;
            // 
            // schemadsBOFStatus
            // 
            this.schemadsBOFStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFStatusL3DataTableGUID,
            this.coldsBOFStatusL3DataTableName,
            this.coldsBOFStatusL3DataTableBOFID,
            this.coldsBOFStatusL3DataTableStatus,
            this.coldsBOFStatusL3DataTableNew_BOF_Flag});
            this.schemadsBOFStatus.TableName = "L3DataTable";
            // 
            // coldsBOFStatusL3DataTableGUID
            // 
            this.coldsBOFStatusL3DataTableGUID.Caption = "GUID";
            this.coldsBOFStatusL3DataTableGUID.ColumnName = "GUID";
            this.coldsBOFStatusL3DataTableGUID.Namespace = "";
            // 
            // coldsBOFStatusL3DataTableName
            // 
            this.coldsBOFStatusL3DataTableName.Caption = "Name";
            this.coldsBOFStatusL3DataTableName.ColumnName = "Name";
            this.coldsBOFStatusL3DataTableName.Namespace = "";
            // 
            // coldsBOFStatusL3DataTableBOFID
            // 
            this.coldsBOFStatusL3DataTableBOFID.Caption = "BOFID";
            this.coldsBOFStatusL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsBOFStatusL3DataTableBOFID.Namespace = "";
            // 
            // coldsBOFStatusL3DataTableStatus
            // 
            this.coldsBOFStatusL3DataTableStatus.Caption = "Status";
            this.coldsBOFStatusL3DataTableStatus.ColumnName = "Status";
            this.coldsBOFStatusL3DataTableStatus.Namespace = "";
            // 
            // coldsBOFStatusL3DataTableNew_BOF_Flag
            // 
            this.coldsBOFStatusL3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsBOFStatusL3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsBOFStatusL3DataTableNew_BOF_Flag.DataType = typeof(int);
            this.coldsBOFStatusL3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // BOFStatusFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 243);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.Name = "BOFStatusFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转炉再用情况";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BOFStatusFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBOFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBOFStatus;
        private AppSvrHMI.L3DataSet dsBOFStatus;
        private System.Data.DataTable schemadsBOFStatus;
        private System.Data.DataColumn coldsBOFStatusL3DataTableGUID;
        private System.Data.DataColumn coldsBOFStatusL3DataTableName;
        private System.Data.DataColumn coldsBOFStatusL3DataTableBOFID;
        private System.Data.DataColumn coldsBOFStatusL3DataTableStatus;
        private System.Data.DataColumn coldsBOFStatusL3DataTableNew_BOF_Flag;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBOFStatus;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsNewBOFFlag;
        private System.Data.DataTable schemadsNewBOFFlag;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn newBOFFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
    }
}