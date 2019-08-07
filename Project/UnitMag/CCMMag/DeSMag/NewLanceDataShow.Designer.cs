namespace UnitMag.DeSMag
{
    partial class NewLanceDataShow
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpNewLance = new System.Windows.Forms.TabPage();
            this.cbLanceNo = new System.Windows.Forms.ComboBox();
            this.dsLanceNo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsLanceNo = new System.Data.DataTable();
            this.coldsLanceNoL3DataTableLanceNo = new System.Data.DataColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dsLanceVendor = new AppSvrHMI.L3DataSet();
            this.schemadsLanceVendor = new System.Data.DataTable();
            this.coldsLanceVendorL3DataTableCode = new System.Data.DataColumn();
            this.coldsLanceVendorL3DataTableCode_Des = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsLance = new AppSvrHMI.L3DataSet();
            this.schemadsLance = new System.Data.DataTable();
            this.coldsLanceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLanceL3DataTableName = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceNo = new System.Data.DataColumn();
            this.coldsLanceL3DataTableStatus = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceAge = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceVendor = new System.Data.DataColumn();
            this.coldsLanceL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsLanceL3DataTableProcessAmount = new System.Data.DataColumn();
            this.coldsLanceL3DataTableNote = new System.Data.DataColumn();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmdNewLance = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.cmdGetLanceNo = new AppSvrHMI.L3Command(this.components);
            this.tcMain.SuspendLayout();
            this.tpNewLance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpNewLance);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(405, 218);
            this.tcMain.TabIndex = 6;
            // 
            // tpNewLance
            // 
            this.tpNewLance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNewLance.Controls.Add(this.cbLanceNo);
            this.tpNewLance.Controls.Add(this.richTextBox1);
            this.tpNewLance.Controls.Add(this.cmbStatus);
            this.tpNewLance.Controls.Add(this.label3);
            this.tpNewLance.Controls.Add(this.label2);
            this.tpNewLance.Controls.Add(this.label1);
            this.tpNewLance.Location = new System.Drawing.Point(4, 21);
            this.tpNewLance.Name = "tpNewLance";
            this.tpNewLance.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewLance.Size = new System.Drawing.Size(397, 193);
            this.tpNewLance.TabIndex = 0;
            this.tpNewLance.Text = "喷枪实绩信息";
            this.tpNewLance.UseVisualStyleBackColor = true;
            // 
            // cbLanceNo
            // 
            this.cbLanceNo.DataSource = this.dsLanceNo;
            this.cbLanceNo.DisplayMember = "L3DataTable.LanceNo";
            this.cbLanceNo.FormattingEnabled = true;
            this.cbLanceNo.Location = new System.Drawing.Point(66, 24);
            this.cbLanceNo.Name = "cbLanceNo";
            this.cbLanceNo.Size = new System.Drawing.Size(121, 20);
            this.cbLanceNo.TabIndex = 16;
            this.cbLanceNo.ValueMember = "L3DataTable.LanceNo";
            // 
            // dsLanceNo
            // 
            this.dsLanceNo.AutoLoad = true;
            this.dsLanceNo.AutoSubscribe = false;
            this.dsLanceNo.DataSetName = "L3DataSet";
            this.dsLanceNo.DeleteMethod = "";
            this.dsLanceNo.InsertMethod = "";
            this.dsLanceNo.L3DataAdapter = this.Adapter;
            this.dsLanceNo.LoadEvent = "";
            this.dsLanceNo.LoadTrigger = null;
            this.dsLanceNo.RefreshValve = 1000;
            this.dsLanceNo.SourceCommand = null;
            this.dsLanceNo.SourceCondition = "";
            this.dsLanceNo.SourceMethod = "";
            this.dsLanceNo.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsLanceNo.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Lance_Data";
            this.dsLanceNo.SubscribeTarget = "";
            this.dsLanceNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceNo});
            this.dsLanceNo.UpdateEvent = "";
            this.dsLanceNo.UpdateMethod = "";
            this.dsLanceNo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsLanceNo
            // 
            this.schemadsLanceNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceNoL3DataTableLanceNo});
            this.schemadsLanceNo.TableName = "L3DataTable";
            // 
            // coldsLanceNoL3DataTableLanceNo
            // 
            this.coldsLanceNoL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsLanceNoL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsLanceNoL3DataTableLanceNo.Namespace = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 73);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(66, 59);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 20);
            this.cmbStatus.TabIndex = 14;
            // 
            // dsLanceVendor
            // 
            this.dsLanceVendor.AutoLoad = true;
            this.dsLanceVendor.AutoSubscribe = false;
            this.dsLanceVendor.DataSetName = "L3DataSet";
            this.dsLanceVendor.DeleteMethod = "";
            this.dsLanceVendor.InsertMethod = "";
            this.dsLanceVendor.L3DataAdapter = this.Adapter;
            this.dsLanceVendor.LoadEvent = "";
            this.dsLanceVendor.LoadTrigger = null;
            this.dsLanceVendor.RefreshValve = 1000;
            this.dsLanceVendor.SourceCommand = null;
            this.dsLanceVendor.SourceCondition = "code_group = \'DeS_Lance_Vendor\' and code is not null order by code";
            this.dsLanceVendor.SourceMethod = "";
            this.dsLanceVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLanceVendor.SubscribeTarget = "";
            this.dsLanceVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceVendor});
            this.dsLanceVendor.UpdateEvent = "";
            this.dsLanceVendor.UpdateMethod = "";
            this.dsLanceVendor.UpdateTrigger = null;
            // 
            // schemadsLanceVendor
            // 
            this.schemadsLanceVendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceVendorL3DataTableCode,
            this.coldsLanceVendorL3DataTableCode_Des});
            this.schemadsLanceVendor.TableName = "L3DataTable";
            // 
            // coldsLanceVendorL3DataTableCode
            // 
            this.coldsLanceVendorL3DataTableCode.Caption = "Code";
            this.coldsLanceVendorL3DataTableCode.ColumnName = "Code";
            this.coldsLanceVendorL3DataTableCode.Namespace = "";
            // 
            // coldsLanceVendorL3DataTableCode_Des
            // 
            this.coldsLanceVendorL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLanceVendorL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLanceVendorL3DataTableCode_Des.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "备注:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "状态:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "枪号:";
            // 
            // dsLance
            // 
            this.dsLance.AutoLoad = false;
            this.dsLance.AutoSubscribe = false;
            this.dsLance.DataSetName = "L3DataSet";
            this.dsLance.DeleteMethod = "";
            this.dsLance.InsertMethod = "";
            this.dsLance.L3DataAdapter = this.Adapter;
            this.dsLance.LoadEvent = "";
            this.dsLance.LoadTrigger = null;
            this.dsLance.RefreshValve = 1000;
            this.dsLance.SourceCommand = null;
            this.dsLance.SourceCondition = "";
            this.dsLance.SourceMethod = "";
            this.dsLance.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsLance.SourceURI = "";
            this.dsLance.SubscribeTarget = "";
            this.dsLance.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLance});
            this.dsLance.UpdateEvent = "";
            this.dsLance.UpdateMethod = "";
            this.dsLance.UpdateTrigger = null;
            // 
            // schemadsLance
            // 
            this.schemadsLance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceL3DataTableGUID,
            this.coldsLanceL3DataTableName,
            this.coldsLanceL3DataTableLanceNo,
            this.coldsLanceL3DataTableStatus,
            this.coldsLanceL3DataTableLanceAge,
            this.coldsLanceL3DataTableLanceVendor,
            this.coldsLanceL3DataTableProcessTime,
            this.coldsLanceL3DataTableProcessAmount,
            this.coldsLanceL3DataTableNote});
            this.schemadsLance.TableName = "L3DataTable";
            // 
            // coldsLanceL3DataTableGUID
            // 
            this.coldsLanceL3DataTableGUID.Caption = "GUID";
            this.coldsLanceL3DataTableGUID.ColumnName = "GUID";
            this.coldsLanceL3DataTableGUID.Namespace = "";
            // 
            // coldsLanceL3DataTableName
            // 
            this.coldsLanceL3DataTableName.Caption = "Name";
            this.coldsLanceL3DataTableName.ColumnName = "Name";
            this.coldsLanceL3DataTableName.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceNo
            // 
            this.coldsLanceL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.Namespace = "";
            // 
            // coldsLanceL3DataTableStatus
            // 
            this.coldsLanceL3DataTableStatus.Caption = "Status";
            this.coldsLanceL3DataTableStatus.ColumnName = "Status";
            this.coldsLanceL3DataTableStatus.DataType = typeof(int);
            this.coldsLanceL3DataTableStatus.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceAge
            // 
            this.coldsLanceL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.DataType = typeof(int);
            this.coldsLanceL3DataTableLanceAge.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceVendor
            // 
            this.coldsLanceL3DataTableLanceVendor.Caption = "LanceVendor";
            this.coldsLanceL3DataTableLanceVendor.ColumnName = "LanceVendor";
            this.coldsLanceL3DataTableLanceVendor.Namespace = "";
            // 
            // coldsLanceL3DataTableProcessTime
            // 
            this.coldsLanceL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsLanceL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsLanceL3DataTableProcessTime.DataType = typeof(int);
            this.coldsLanceL3DataTableProcessTime.Namespace = "";
            // 
            // coldsLanceL3DataTableProcessAmount
            // 
            this.coldsLanceL3DataTableProcessAmount.Caption = "ProcessAmount";
            this.coldsLanceL3DataTableProcessAmount.ColumnName = "ProcessAmount";
            this.coldsLanceL3DataTableProcessAmount.DataType = typeof(double);
            this.coldsLanceL3DataTableProcessAmount.Namespace = "";
            // 
            // coldsLanceL3DataTableNote
            // 
            this.coldsLanceL3DataTableNote.Caption = "Note";
            this.coldsLanceL3DataTableNote.ColumnName = "Note";
            this.coldsLanceL3DataTableNote.Namespace = "";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(299, 224);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(207, 224);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdNewLance
            // 
            this.cmdNewLance.Adapter = this.Adapter;
            this.cmdNewLance.MergeReturnTarget = false;
            this.cmdNewLance.Method = "AddNewLanceData";
            this.cmdNewLance.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdNewLance.Parameters.Add(this.l3CommandParameter1);
            this.cmdNewLance.ReturnTarget = null;
            this.cmdNewLance.ReturnTargetProperty = null;
            this.cmdNewLance.Trigger = null;
            this.cmdNewLance.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsLance;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'AddNewLanceData\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // cmdGetLanceNo
            // 
            this.cmdGetLanceNo.Adapter = this.Adapter;
            this.cmdGetLanceNo.MergeReturnTarget = false;
            this.cmdGetLanceNo.Method = "GenerateLanceNo";
            this.cmdGetLanceNo.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdGetLanceNo.ReturnTarget = null;
            this.cmdGetLanceNo.ReturnTargetProperty = null;
            this.cmdGetLanceNo.Trigger = null;
            this.cmdGetLanceNo.TriggerEvent = "Click";
            // 
            // NewLanceDataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 259);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tcMain);
            this.Name = "NewLanceDataShow";
            this.Text = "新增喷枪实绩";
            this.Load += new System.EventHandler(this.NewLanceDataShow_Load);
            this.tcMain.ResumeLayout(false);
            this.tpNewLance.ResumeLayout(false);
            this.tpNewLance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpNewLance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private AppSvrHMI.L3DataSet dsLance;
        private System.Data.DataTable schemadsLance;
        private System.Data.DataColumn coldsLanceL3DataTableGUID;
        private System.Data.DataColumn coldsLanceL3DataTableName;
        private System.Data.DataColumn coldsLanceL3DataTableLanceNo;
        private System.Data.DataColumn coldsLanceL3DataTableStatus;
        private System.Data.DataColumn coldsLanceL3DataTableLanceAge;
        private System.Data.DataColumn coldsLanceL3DataTableLanceVendor;
        private System.Data.DataColumn coldsLanceL3DataTableProcessTime;
        private System.Data.DataColumn coldsLanceL3DataTableProcessAmount;
        private System.Data.DataColumn coldsLanceL3DataTableNote;
        private AppSvrHMI.L3DataSet dsLanceVendor;
        private System.Data.DataTable schemadsLanceVendor;
        private System.Data.DataColumn coldsLanceVendorL3DataTableCode;
        private System.Data.DataColumn coldsLanceVendorL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdNewLance;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private AppSvrHMI.L3Command cmdGetLanceNo;
        private System.Windows.Forms.ComboBox cbLanceNo;
        private AppSvrHMI.L3DataSet dsLanceNo;
        private System.Data.DataTable schemadsLanceNo;
        private System.Data.DataColumn coldsLanceNoL3DataTableLanceNo;
    }
}