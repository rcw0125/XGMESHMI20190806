namespace PlanMag
{
    partial class TappingActFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TappingActFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTappingAct = new System.Windows.Forms.DataGridView();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.bsTappingAct = new System.Windows.Forms.BindingSource(this.components);
            this.dsTappingAct = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBOFStatus = new System.Data.DataTable();
            this.coldsBOFStatusL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsTappingActL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableLF_TreatNo = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableRH_TreatNo = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableCaster_TreatNo = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableLFID = new System.Data.DataColumn();
            this.coldsTappingActL3DataTableRHID = new System.Data.DataColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsNewBOFFlag = new AppSvrHMI.L3DataSet();
            this.schemadsNewBOFFlag = new System.Data.DataTable();
            this.coldsNewBOFFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsNewBOFFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTappingAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTappingAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.btnCancel,
            this.btnExit,
            this.toolStripSeparator1});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(377, 43);
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
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvTappingAct);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(377, 172);
            this.hmiRootPanel1.TabIndex = 32;
            // 
            // dvTappingAct
            // 
            this.dvTappingAct.AllowUserToAddRows = false;
            this.dvTappingAct.AutoGenerateColumns = false;
            this.dvTappingAct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvTappingAct.BackgroundColor = System.Drawing.Color.White;
            this.dvTappingAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preHeatIDDataGridViewTextBoxColumn,
            this.bOFIDDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn});
            this.dvTappingAct.DataSource = this.bsTappingAct;
            this.dvTappingAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTappingAct.Location = new System.Drawing.Point(0, 0);
            this.dvTappingAct.Name = "dvTappingAct";
            this.dvTappingAct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvTappingAct.RowTemplate.Height = 23;
            this.dvTappingAct.Size = new System.Drawing.Size(373, 168);
            this.dvTappingAct.TabIndex = 0;
            this.dvTappingAct.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvTappingAct_CellPainting);
            this.dvTappingAct.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBOFStatus_DataError);
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "转炉炉座号";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.createDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.createDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Width = 35;
            // 
            // bsTappingAct
            // 
            this.bsTappingAct.DataMember = "L3DataTable";
            this.bsTappingAct.DataSource = this.dsTappingAct;
            // 
            // dsTappingAct
            // 
            this.dsTappingAct.AutoLoad = true;
            this.dsTappingAct.AutoSubscribe = true;
            this.dsTappingAct.DataSetName = "L3DataSet";
            this.dsTappingAct.DeleteMethod = "";
            this.dsTappingAct.InsertMethod = "";
            this.dsTappingAct.L3DataAdapter = this.Adapter;
            this.dsTappingAct.LoadEvent = "Click";
            this.dsTappingAct.LoadTrigger = null;
            this.dsTappingAct.RefreshValve = 1000;
            this.dsTappingAct.SourceCommand = null;
            this.dsTappingAct.SourceCondition = "PreHeatID =\'1\' or PreHeatID =\'2\' or PreHeatID =\'3\' or PreHeatID =\'4\' or PreHeatID" +
                " =\'5\'or PreHeatID =\'6\'";
            this.dsTappingAct.SourceMethod = "";
            this.dsTappingAct.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTappingAct.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Tapping_Act";
            this.dsTappingAct.SubscribeTarget = "";
            this.dsTappingAct.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFStatus});
            this.dsTappingAct.UpdateEvent = "Click";
            this.dsTappingAct.UpdateMethod = "";
            this.dsTappingAct.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBOFStatus
            // 
            this.schemadsBOFStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFStatusL3DataTableBOFID,
            this.coldsTappingActL3DataTablePreHeatID,
            this.coldsTappingActL3DataTableCasterID,
            this.coldsTappingActL3DataTableHeatID,
            this.coldsTappingActL3DataTableLF_TreatNo,
            this.coldsTappingActL3DataTableRH_TreatNo,
            this.coldsTappingActL3DataTableCaster_TreatNo,
            this.coldsTappingActL3DataTableCreateDate,
            this.coldsTappingActL3DataTableLFID,
            this.coldsTappingActL3DataTableRHID});
            this.schemadsBOFStatus.TableName = "L3DataTable";
            // 
            // coldsBOFStatusL3DataTableBOFID
            // 
            this.coldsBOFStatusL3DataTableBOFID.Caption = "BOFID";
            this.coldsBOFStatusL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsBOFStatusL3DataTableBOFID.Namespace = "";
            // 
            // coldsTappingActL3DataTablePreHeatID
            // 
            this.coldsTappingActL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsTappingActL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsTappingActL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsTappingActL3DataTableCasterID
            // 
            this.coldsTappingActL3DataTableCasterID.Caption = "CasterID";
            this.coldsTappingActL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsTappingActL3DataTableCasterID.Namespace = "";
            // 
            // coldsTappingActL3DataTableHeatID
            // 
            this.coldsTappingActL3DataTableHeatID.Caption = "HeatID";
            this.coldsTappingActL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTappingActL3DataTableHeatID.Namespace = "";
            // 
            // coldsTappingActL3DataTableLF_TreatNo
            // 
            this.coldsTappingActL3DataTableLF_TreatNo.Caption = "LF_TreatNo";
            this.coldsTappingActL3DataTableLF_TreatNo.ColumnName = "LF_TreatNo";
            this.coldsTappingActL3DataTableLF_TreatNo.Namespace = "";
            // 
            // coldsTappingActL3DataTableRH_TreatNo
            // 
            this.coldsTappingActL3DataTableRH_TreatNo.Caption = "RH_TreatNo";
            this.coldsTappingActL3DataTableRH_TreatNo.ColumnName = "RH_TreatNo";
            this.coldsTappingActL3DataTableRH_TreatNo.Namespace = "";
            // 
            // coldsTappingActL3DataTableCaster_TreatNo
            // 
            this.coldsTappingActL3DataTableCaster_TreatNo.Caption = "Caster_TreatNo";
            this.coldsTappingActL3DataTableCaster_TreatNo.ColumnName = "Caster_TreatNo";
            this.coldsTappingActL3DataTableCaster_TreatNo.Namespace = "";
            // 
            // coldsTappingActL3DataTableCreateDate
            // 
            this.coldsTappingActL3DataTableCreateDate.Caption = "CreateDate";
            this.coldsTappingActL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsTappingActL3DataTableCreateDate.DataType = typeof(System.DateTime);
            this.coldsTappingActL3DataTableCreateDate.Namespace = "";
            // 
            // coldsTappingActL3DataTableLFID
            // 
            this.coldsTappingActL3DataTableLFID.Caption = "LFID";
            this.coldsTappingActL3DataTableLFID.ColumnName = "LFID";
            this.coldsTappingActL3DataTableLFID.Namespace = "";
            // 
            // coldsTappingActL3DataTableRHID
            // 
            this.coldsTappingActL3DataTableRHID.Caption = "RHID";
            this.coldsTappingActL3DataTableRHID.ColumnName = "RHID";
            this.coldsTappingActL3DataTableRHID.Namespace = "";
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = true;
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
            this.dsStatus.SubscribeTarget = "";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
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
            // dsNewBOFFlag
            // 
            this.dsNewBOFFlag.AutoLoad = true;
            this.dsNewBOFFlag.AutoSubscribe = true;
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
            this.dsNewBOFFlag.SubscribeTarget = "";
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
            // TappingActFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(377, 215);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TappingActFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉号处理号对齐";
            this.Load += new System.EventHandler(this.TappingActFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TappingActFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTappingAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTappingAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNewBOFFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNewBOFFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvTappingAct;
        private AppSvrHMI.L3DataSet dsTappingAct;
        private System.Data.DataTable schemadsBOFStatus;
        private System.Data.DataColumn coldsBOFStatusL3DataTableBOFID;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsTappingAct;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsNewBOFFlag;
        private System.Data.DataTable schemadsNewBOFFlag;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsNewBOFFlagL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsTappingActL3DataTablePreHeatID;
        private System.Data.DataColumn coldsTappingActL3DataTableCasterID;
        private System.Data.DataColumn coldsTappingActL3DataTableHeatID;
        private System.Data.DataColumn coldsTappingActL3DataTableLF_TreatNo;
        private System.Data.DataColumn coldsTappingActL3DataTableRH_TreatNo;
        private System.Data.DataColumn coldsTappingActL3DataTableCaster_TreatNo;
        private System.Data.DataColumn coldsTappingActL3DataTableCreateDate;
        private System.Data.DataColumn coldsTappingActL3DataTableLFID;
        private System.Data.DataColumn coldsTappingActL3DataTableRHID;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn createDateDataGridViewTextBoxColumn;
        
    }
}