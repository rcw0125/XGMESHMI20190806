namespace UnitMag.BFMag
{
    partial class IronSlagApplyInfo
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtxtTapNo = new System.Windows.Forms.MaskedTextBox();
            this.bsSampleApply = new System.Windows.Forms.BindingSource(this.components);
            this.dsSampleApply = new AppSvrHMI.L3DataSet();
            this.schemadsSampleApply = new System.Data.DataTable();
            this.coldsSampleApplyL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableName = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableAppID = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSample_Date = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableFin_Prod_Flag = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableAsis_Flag = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableTreaty = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableBack_Flag = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableBack_Date = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableReSample_Flag = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableReSample_Reason = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableReSample_Date = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSendFlag = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableReSampled = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSamplyTaype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSamplyAddress = new System.Windows.Forms.ComboBox();
            this.dsSampleAddress = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddress = new System.Data.DataTable();
            this.coldsSampleAddressL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddressL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTapNo = new AppSvrHMI.L3DataSet();
            this.schemadsTapNo = new System.Data.DataTable();
            this.coldsTapNoL3DataTableBFID = new System.Data.DataColumn();
            this.coldsTapNoL3DataTableTapNo = new System.Data.DataColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapNo)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(371, 59);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(293, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConfirm.Location = new System.Drawing.Point(212, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 149);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.mtxtTapNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSamplyTaype);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbSamplyAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "申请信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mtxtTapNo
            // 
            this.mtxtTapNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSampleApply, "HeatID", true));
            this.mtxtTapNo.Location = new System.Drawing.Point(136, 45);
            this.mtxtTapNo.Name = "mtxtTapNo";
            this.mtxtTapNo.Size = new System.Drawing.Size(153, 21);
            this.mtxtTapNo.TabIndex = 4;
            // 
            // bsSampleApply
            // 
            this.bsSampleApply.DataMember = "L3DataTable";
            this.bsSampleApply.DataSource = this.dsSampleApply;
            // 
            // dsSampleApply
            // 
            this.dsSampleApply.AutoSubscribe = false;
            this.dsSampleApply.DataSetName = "L3DataSet";
            this.dsSampleApply.DeleteMethod = null;
            this.dsSampleApply.InsertMethod = null;
            this.dsSampleApply.L3DataAdapter = null;
            this.dsSampleApply.LoadEvent = "Click";
            this.dsSampleApply.LoadTrigger = null;
            this.dsSampleApply.RefreshValve = 1000;
            this.dsSampleApply.SourceCommand = null;
            this.dsSampleApply.SourceCondition = "";
            this.dsSampleApply.SourceMethod = "";
            this.dsSampleApply.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsSampleApply.SourceURI = "";
            this.dsSampleApply.SubscribeTarget = "";
            this.dsSampleApply.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleApply});
            this.dsSampleApply.UpdateEvent = "Click";
            this.dsSampleApply.UpdateMethod = null;
            this.dsSampleApply.UpdateTrigger = null;
            // 
            // schemadsSampleApply
            // 
            this.schemadsSampleApply.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleApplyL3DataTableGUID,
            this.coldsSampleApplyL3DataTableName,
            this.coldsSampleApplyL3DataTableAppID,
            this.coldsSampleApplyL3DataTableHeatID,
            this.coldsSampleApplyL3DataTableSample_Code,
            this.coldsSampleApplyL3DataTableSample_Address,
            this.coldsSampleApplyL3DataTableSample_Type,
            this.coldsSampleApplyL3DataTableSample_Count,
            this.coldsSampleApplyL3DataTableSample_Date,
            this.coldsSampleApplyL3DataTableFin_Prod_Flag,
            this.coldsSampleApplyL3DataTableAsis_Flag,
            this.coldsSampleApplyL3DataTableSteelGrade,
            this.coldsSampleApplyL3DataTableTreaty,
            this.coldsSampleApplyL3DataTableBack_Flag,
            this.coldsSampleApplyL3DataTableBack_Date,
            this.coldsSampleApplyL3DataTableReSample_Flag,
            this.coldsSampleApplyL3DataTableReSample_Reason,
            this.coldsSampleApplyL3DataTableReSample_Date,
            this.coldsSampleApplyL3DataTableSendFlag,
            this.coldsSampleApplyL3DataTableReSampled});
            this.schemadsSampleApply.TableName = "L3DataTable";
            // 
            // coldsSampleApplyL3DataTableGUID
            // 
            this.coldsSampleApplyL3DataTableGUID.Caption = "GUID";
            this.coldsSampleApplyL3DataTableGUID.ColumnName = "GUID";
            this.coldsSampleApplyL3DataTableGUID.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableName
            // 
            this.coldsSampleApplyL3DataTableName.Caption = "Name";
            this.coldsSampleApplyL3DataTableName.ColumnName = "Name";
            this.coldsSampleApplyL3DataTableName.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableAppID
            // 
            this.coldsSampleApplyL3DataTableAppID.Caption = "AppID";
            this.coldsSampleApplyL3DataTableAppID.ColumnName = "AppID";
            this.coldsSampleApplyL3DataTableAppID.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableHeatID
            // 
            this.coldsSampleApplyL3DataTableHeatID.Caption = "HeatID";
            this.coldsSampleApplyL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSampleApplyL3DataTableHeatID.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSample_Code
            // 
            this.coldsSampleApplyL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsSampleApplyL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsSampleApplyL3DataTableSample_Code.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSample_Address
            // 
            this.coldsSampleApplyL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsSampleApplyL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsSampleApplyL3DataTableSample_Address.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSample_Type
            // 
            this.coldsSampleApplyL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsSampleApplyL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsSampleApplyL3DataTableSample_Type.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSample_Count
            // 
            this.coldsSampleApplyL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsSampleApplyL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsSampleApplyL3DataTableSample_Count.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSample_Date
            // 
            this.coldsSampleApplyL3DataTableSample_Date.Caption = "Sample_Date";
            this.coldsSampleApplyL3DataTableSample_Date.ColumnName = "Sample_Date";
            this.coldsSampleApplyL3DataTableSample_Date.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableSample_Date.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableFin_Prod_Flag
            // 
            this.coldsSampleApplyL3DataTableFin_Prod_Flag.Caption = "Fin_Prod_Flag";
            this.coldsSampleApplyL3DataTableFin_Prod_Flag.ColumnName = "Fin_Prod_Flag";
            this.coldsSampleApplyL3DataTableFin_Prod_Flag.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableFin_Prod_Flag.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableAsis_Flag
            // 
            this.coldsSampleApplyL3DataTableAsis_Flag.Caption = "Asis_Flag";
            this.coldsSampleApplyL3DataTableAsis_Flag.ColumnName = "Asis_Flag";
            this.coldsSampleApplyL3DataTableAsis_Flag.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableAsis_Flag.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSteelGrade
            // 
            this.coldsSampleApplyL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSampleApplyL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSampleApplyL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableTreaty
            // 
            this.coldsSampleApplyL3DataTableTreaty.Caption = "Treaty";
            this.coldsSampleApplyL3DataTableTreaty.ColumnName = "Treaty";
            this.coldsSampleApplyL3DataTableTreaty.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableBack_Flag
            // 
            this.coldsSampleApplyL3DataTableBack_Flag.Caption = "Back_Flag";
            this.coldsSampleApplyL3DataTableBack_Flag.ColumnName = "Back_Flag";
            this.coldsSampleApplyL3DataTableBack_Flag.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableBack_Flag.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableBack_Date
            // 
            this.coldsSampleApplyL3DataTableBack_Date.Caption = "Back_Date";
            this.coldsSampleApplyL3DataTableBack_Date.ColumnName = "Back_Date";
            this.coldsSampleApplyL3DataTableBack_Date.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableBack_Date.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableReSample_Flag
            // 
            this.coldsSampleApplyL3DataTableReSample_Flag.Caption = "ReSample_Flag";
            this.coldsSampleApplyL3DataTableReSample_Flag.ColumnName = "ReSample_Flag";
            this.coldsSampleApplyL3DataTableReSample_Flag.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableReSample_Flag.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableReSample_Reason
            // 
            this.coldsSampleApplyL3DataTableReSample_Reason.Caption = "ReSample_Reason";
            this.coldsSampleApplyL3DataTableReSample_Reason.ColumnName = "ReSample_Reason";
            this.coldsSampleApplyL3DataTableReSample_Reason.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableReSample_Date
            // 
            this.coldsSampleApplyL3DataTableReSample_Date.Caption = "ReSample_Date";
            this.coldsSampleApplyL3DataTableReSample_Date.ColumnName = "ReSample_Date";
            this.coldsSampleApplyL3DataTableReSample_Date.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableReSample_Date.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSendFlag
            // 
            this.coldsSampleApplyL3DataTableSendFlag.Caption = "SendFlag";
            this.coldsSampleApplyL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsSampleApplyL3DataTableSendFlag.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableSendFlag.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableReSampled
            // 
            this.coldsSampleApplyL3DataTableReSampled.Caption = "ReSampled";
            this.coldsSampleApplyL3DataTableReSampled.ColumnName = "ReSampled";
            this.coldsSampleApplyL3DataTableReSampled.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableReSampled.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "铁次号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "试样类别:";
            // 
            // txtSamplyTaype
            // 
            this.txtSamplyTaype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSampleApply, "Sample_Type", true));
            this.txtSamplyTaype.Location = new System.Drawing.Point(136, 74);
            this.txtSamplyTaype.Name = "txtSamplyTaype";
            this.txtSamplyTaype.ReadOnly = true;
            this.txtSamplyTaype.Size = new System.Drawing.Size(153, 21);
            this.txtSamplyTaype.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "取样地点:";
            // 
            // cmbSamplyAddress
            // 
            this.cmbSamplyAddress.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSampleApply, "Sample_Address", true));
            this.cmbSamplyAddress.DataSource = this.dsSampleAddress;
            this.cmbSamplyAddress.DisplayMember = "L3DataTable.Code_Des";
            this.cmbSamplyAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSamplyAddress.FormattingEnabled = true;
            this.cmbSamplyAddress.Location = new System.Drawing.Point(136, 15);
            this.cmbSamplyAddress.Name = "cmbSamplyAddress";
            this.cmbSamplyAddress.Size = new System.Drawing.Size(153, 20);
            this.cmbSamplyAddress.TabIndex = 1;
            this.cmbSamplyAddress.ValueMember = "L3DataTable.Code";
            this.cmbSamplyAddress.SelectedIndexChanged += new System.EventHandler(this.cmbSamplyAddress_SelectedIndexChanged);
            // 
            // dsSampleAddress
            // 
            this.dsSampleAddress.AutoSubscribe = false;
            this.dsSampleAddress.DataSetName = "L3DataSet";
            this.dsSampleAddress.DeleteMethod = "";
            this.dsSampleAddress.InsertMethod = "";
            this.dsSampleAddress.L3DataAdapter = this.Adapter;
            this.dsSampleAddress.LoadEvent = "";
            this.dsSampleAddress.LoadTrigger = null;
            this.dsSampleAddress.RefreshValve = 1000;
            this.dsSampleAddress.SourceCommand = null;
            this.dsSampleAddress.SourceCondition = "Code_Group = \'QA_Sample_Addr\' and substr(Code,1,1) = \'G\' order by Code";
            this.dsSampleAddress.SourceMethod = "";
            this.dsSampleAddress.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddress.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddress.SubscribeTarget = "";
            this.dsSampleAddress.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddress});
            this.dsSampleAddress.UpdateEvent = "";
            this.dsSampleAddress.UpdateMethod = "";
            this.dsSampleAddress.UpdateTrigger = null;
            // 
            // schemadsSampleAddress
            // 
            this.schemadsSampleAddress.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddressL3DataTableCode,
            this.coldsSampleAddressL3DataTableCode_Des});
            this.schemadsSampleAddress.TableName = "L3DataTable";
            // 
            // coldsSampleAddressL3DataTableCode
            // 
            this.coldsSampleAddressL3DataTableCode.Caption = "Code";
            this.coldsSampleAddressL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddressL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddressL3DataTableCode_Des
            // 
            this.coldsSampleAddressL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddressL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddressL3DataTableCode_Des.Namespace = "";
            // 
            // dsTapNo
            // 
            this.dsTapNo.AutoSubscribe = false;
            this.dsTapNo.DataSetName = "L3DataSet";
            this.dsTapNo.DeleteMethod = "";
            this.dsTapNo.InsertMethod = "";
            this.dsTapNo.L3DataAdapter = this.Adapter;
            this.dsTapNo.LoadEvent = "";
            this.dsTapNo.LoadTrigger = null;
            this.dsTapNo.RefreshValve = 1000;
            this.dsTapNo.SourceCommand = null;
            this.dsTapNo.SourceCondition = "";
            this.dsTapNo.SourceMethod = "GetMaxTAPNoByBFID";
            this.dsTapNo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTapNo.SourceURI = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.dsTapNo.SubscribeTarget = null;
            this.dsTapNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapNo});
            this.dsTapNo.UpdateEvent = "";
            this.dsTapNo.UpdateMethod = "";
            this.dsTapNo.UpdateTrigger = null;
            // 
            // schemadsTapNo
            // 
            this.schemadsTapNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapNoL3DataTableBFID,
            this.coldsTapNoL3DataTableTapNo});
            this.schemadsTapNo.TableName = "L3DataTable";
            // 
            // coldsTapNoL3DataTableBFID
            // 
            this.coldsTapNoL3DataTableBFID.Caption = "BFID";
            this.coldsTapNoL3DataTableBFID.ColumnName = "BFID";
            this.coldsTapNoL3DataTableBFID.Namespace = "";
            // 
            // coldsTapNoL3DataTableTapNo
            // 
            this.coldsTapNoL3DataTableTapNo.Caption = "TapNo";
            this.coldsTapNoL3DataTableTapNo.ColumnName = "TapNo";
            this.coldsTapNoL3DataTableTapNo.Namespace = "";
            // 
            // IronSlagApplyInfo
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnConfirm;
            this.ClientSize = new System.Drawing.Size(371, 208);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IronSlagApplyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁渣样委托单";
            this.Load += new System.EventHandler(this.IronSlagApply_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbSamplyAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSamplyTaype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtTapNo;
        private AppSvrHMI.L3DataSet dsSampleAddress;
        private System.Data.DataTable schemadsSampleAddress;
        private System.Data.DataColumn coldsSampleAddressL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddressL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTapNo;
        private System.Data.DataTable schemadsTapNo;
        private System.Data.DataColumn coldsTapNoL3DataTableBFID;
        private System.Data.DataColumn coldsTapNoL3DataTableTapNo;
        private AppSvrHMI.L3DataSet dsSampleApply;
        private System.Data.DataTable schemadsSampleApply;
        private System.Data.DataColumn coldsSampleApplyL3DataTableGUID;
        private System.Data.DataColumn coldsSampleApplyL3DataTableName;
        private System.Data.DataColumn coldsSampleApplyL3DataTableAppID;
        private System.Data.DataColumn coldsSampleApplyL3DataTableHeatID;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSample_Code;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSample_Address;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSample_Type;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSample_Count;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSample_Date;
        private System.Data.DataColumn coldsSampleApplyL3DataTableFin_Prod_Flag;
        private System.Data.DataColumn coldsSampleApplyL3DataTableAsis_Flag;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSampleApplyL3DataTableTreaty;
        private System.Data.DataColumn coldsSampleApplyL3DataTableBack_Flag;
        private System.Data.DataColumn coldsSampleApplyL3DataTableBack_Date;
        private System.Data.DataColumn coldsSampleApplyL3DataTableReSample_Flag;
        private System.Data.DataColumn coldsSampleApplyL3DataTableReSample_Reason;
        private System.Data.DataColumn coldsSampleApplyL3DataTableReSample_Date;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSendFlag;
        private System.Data.DataColumn coldsSampleApplyL3DataTableReSampled;
        private System.Windows.Forms.BindingSource bsSampleApply;
    }
}