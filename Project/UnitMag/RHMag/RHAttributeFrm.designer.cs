namespace UnitMag.RHMag
{
    partial class RHAttributeFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dsProbeVendor = new AppSvrHMI.L3DataSet();
            this.schemadsPoleVendor = new System.Data.DataTable();
            this.coldsPoleVendorL3DataTablecode = new System.Data.DataColumn();
            this.coldsPoleVendorL3DataTablecode_des = new System.Data.DataColumn();
            this.dsRHUnit = new AppSvrHMI.L3DataSet();
            this.schemadsRHUnit = new System.Data.DataTable();
            this.coldsRHUnitL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableName = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableOwner = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableCode = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableDescription = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableWorkShop = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableSequenceNo = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableMaterialProcessed = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableMaterialFeeded = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableMaterialDeliveried = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTablePlanChanged = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableDeviceChanged = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableNextTreatNo = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableStatus = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableSlot_No = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableNextSteel = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableCurArea = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableProcStartTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableProcStopTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableOBStartTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableAlloyStartTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableProcTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableCurTemp = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableReSampleHeatID = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableStartProcessTime = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableEquip_Status = new System.Data.DataColumn();
            this.coldsRHUnitL3DataTableProbe_Vendor = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPoleVendor = new System.Windows.Forms.ComboBox();
            this.bsRHUnit = new System.Windows.Forms.BindingSource(this.components);
            this.txtSlotNo = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProbeVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPoleVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRHUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 41);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(211, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(133, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
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
            this.tabControl1.Size = new System.Drawing.Size(302, 146);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtSlotNo);
            this.tabPage1.Controls.Add(this.cmbPoleVendor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 121);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RH炉信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 83;
            this.label7.Text = "槽号:";
            // 
            // dsProbeVendor
            // 
            this.dsProbeVendor.AutoSubscribe = false;
            this.dsProbeVendor.DataSetName = "L3DataSet";
            this.dsProbeVendor.DeleteMethod = null;
            this.dsProbeVendor.InsertMethod = null;
            this.dsProbeVendor.L3DataAdapter = this.Adapter;
            this.dsProbeVendor.LoadEvent = "Click";
            this.dsProbeVendor.LoadTrigger = null;
            this.dsProbeVendor.RefreshValve = 1000;
            this.dsProbeVendor.SourceCommand = null;
            this.dsProbeVendor.SourceCondition = "code_group = \'Probe_Vonder\' order by code";
            this.dsProbeVendor.SourceMethod = "";
            this.dsProbeVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProbeVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProbeVendor.SubscribeTarget = null;
            this.dsProbeVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPoleVendor});
            this.dsProbeVendor.UpdateEvent = "Click";
            this.dsProbeVendor.UpdateMethod = null;
            this.dsProbeVendor.UpdateTrigger = null;
            // 
            // schemadsPoleVendor
            // 
            this.schemadsPoleVendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPoleVendorL3DataTablecode,
            this.coldsPoleVendorL3DataTablecode_des});
            this.schemadsPoleVendor.TableName = "L3DataTable";
            // 
            // coldsPoleVendorL3DataTablecode
            // 
            this.coldsPoleVendorL3DataTablecode.Caption = "code";
            this.coldsPoleVendorL3DataTablecode.ColumnName = "code";
            this.coldsPoleVendorL3DataTablecode.Namespace = "";
            // 
            // coldsPoleVendorL3DataTablecode_des
            // 
            this.coldsPoleVendorL3DataTablecode_des.Caption = "code_des";
            this.coldsPoleVendorL3DataTablecode_des.ColumnName = "code_des";
            this.coldsPoleVendorL3DataTablecode_des.Namespace = "";
            // 
            // dsRHUnit
            // 
            this.dsRHUnit.AutoSubscribe = false;
            this.dsRHUnit.DataSetName = "L3DataSet";
            this.dsRHUnit.DeleteMethod = "";
            this.dsRHUnit.InsertMethod = "";
            this.dsRHUnit.L3DataAdapter = this.Adapter;
            this.dsRHUnit.LoadEvent = "";
            this.dsRHUnit.LoadTrigger = null;
            this.dsRHUnit.RefreshValve = 1000;
            this.dsRHUnit.SourceCommand = null;
            this.dsRHUnit.SourceCondition = "";
            this.dsRHUnit.SourceMethod = "";
            this.dsRHUnit.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRHUnit.SourceURI = "XGMESLogic\\RHMag\\CRH_Unit_Mag";
            this.dsRHUnit.SubscribeTarget = null;
            this.dsRHUnit.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRHUnit});
            this.dsRHUnit.UpdateEvent = "";
            this.dsRHUnit.UpdateMethod = "";
            this.dsRHUnit.UpdateTrigger = null;
            // 
            // schemadsRHUnit
            // 
            this.schemadsRHUnit.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRHUnitL3DataTableGUID,
            this.coldsRHUnitL3DataTableName,
            this.coldsRHUnitL3DataTableOwner,
            this.coldsRHUnitL3DataTableCode,
            this.coldsRHUnitL3DataTableDescription,
            this.coldsRHUnitL3DataTableWorkShop,
            this.coldsRHUnitL3DataTableSequenceNo,
            this.coldsRHUnitL3DataTableMaterialProcessed,
            this.coldsRHUnitL3DataTableMaterialFeeded,
            this.coldsRHUnitL3DataTableMaterialDeliveried,
            this.coldsRHUnitL3DataTablePlanChanged,
            this.coldsRHUnitL3DataTableDeviceChanged,
            this.coldsRHUnitL3DataTableTreatNo,
            this.coldsRHUnitL3DataTableNextTreatNo,
            this.coldsRHUnitL3DataTableStatus,
            this.coldsRHUnitL3DataTableSlot_No,
            this.coldsRHUnitL3DataTableNextSteel,
            this.coldsRHUnitL3DataTableCurArea,
            this.coldsRHUnitL3DataTableProcStartTime,
            this.coldsRHUnitL3DataTableProcStopTime,
            this.coldsRHUnitL3DataTableOBStartTime,
            this.coldsRHUnitL3DataTableAlloyStartTime,
            this.coldsRHUnitL3DataTableProcTime,
            this.coldsRHUnitL3DataTableCurTemp,
            this.coldsRHUnitL3DataTableReSampleHeatID,
            this.coldsRHUnitL3DataTableStartProcessTime,
            this.coldsRHUnitL3DataTableEquip_Status,
            this.coldsRHUnitL3DataTableProbe_Vendor});
            this.schemadsRHUnit.TableName = "L3DataTable";
            // 
            // coldsRHUnitL3DataTableGUID
            // 
            this.coldsRHUnitL3DataTableGUID.Caption = "GUID";
            this.coldsRHUnitL3DataTableGUID.ColumnName = "GUID";
            this.coldsRHUnitL3DataTableGUID.Namespace = "";
            // 
            // coldsRHUnitL3DataTableName
            // 
            this.coldsRHUnitL3DataTableName.Caption = "Name";
            this.coldsRHUnitL3DataTableName.ColumnName = "Name";
            this.coldsRHUnitL3DataTableName.Namespace = "";
            // 
            // coldsRHUnitL3DataTableOwner
            // 
            this.coldsRHUnitL3DataTableOwner.Caption = "Owner";
            this.coldsRHUnitL3DataTableOwner.ColumnName = "Owner";
            this.coldsRHUnitL3DataTableOwner.Namespace = "";
            // 
            // coldsRHUnitL3DataTableCode
            // 
            this.coldsRHUnitL3DataTableCode.Caption = "Code";
            this.coldsRHUnitL3DataTableCode.ColumnName = "Code";
            this.coldsRHUnitL3DataTableCode.Namespace = "";
            // 
            // coldsRHUnitL3DataTableDescription
            // 
            this.coldsRHUnitL3DataTableDescription.Caption = "Description";
            this.coldsRHUnitL3DataTableDescription.ColumnName = "Description";
            this.coldsRHUnitL3DataTableDescription.Namespace = "";
            // 
            // coldsRHUnitL3DataTableWorkShop
            // 
            this.coldsRHUnitL3DataTableWorkShop.Caption = "WorkShop";
            this.coldsRHUnitL3DataTableWorkShop.ColumnName = "WorkShop";
            this.coldsRHUnitL3DataTableWorkShop.Namespace = "";
            // 
            // coldsRHUnitL3DataTableSequenceNo
            // 
            this.coldsRHUnitL3DataTableSequenceNo.Caption = "SequenceNo";
            this.coldsRHUnitL3DataTableSequenceNo.ColumnName = "SequenceNo";
            this.coldsRHUnitL3DataTableSequenceNo.DataType = typeof(int);
            this.coldsRHUnitL3DataTableSequenceNo.Namespace = "";
            // 
            // coldsRHUnitL3DataTableMaterialProcessed
            // 
            this.coldsRHUnitL3DataTableMaterialProcessed.Caption = "MaterialProcessed";
            this.coldsRHUnitL3DataTableMaterialProcessed.ColumnName = "MaterialProcessed";
            this.coldsRHUnitL3DataTableMaterialProcessed.DataType = typeof(int);
            this.coldsRHUnitL3DataTableMaterialProcessed.Namespace = "";
            // 
            // coldsRHUnitL3DataTableMaterialFeeded
            // 
            this.coldsRHUnitL3DataTableMaterialFeeded.Caption = "MaterialFeeded";
            this.coldsRHUnitL3DataTableMaterialFeeded.ColumnName = "MaterialFeeded";
            this.coldsRHUnitL3DataTableMaterialFeeded.DataType = typeof(int);
            this.coldsRHUnitL3DataTableMaterialFeeded.Namespace = "";
            // 
            // coldsRHUnitL3DataTableMaterialDeliveried
            // 
            this.coldsRHUnitL3DataTableMaterialDeliveried.Caption = "MaterialDeliveried";
            this.coldsRHUnitL3DataTableMaterialDeliveried.ColumnName = "MaterialDeliveried";
            this.coldsRHUnitL3DataTableMaterialDeliveried.DataType = typeof(int);
            this.coldsRHUnitL3DataTableMaterialDeliveried.Namespace = "";
            // 
            // coldsRHUnitL3DataTablePlanChanged
            // 
            this.coldsRHUnitL3DataTablePlanChanged.Caption = "PlanChanged";
            this.coldsRHUnitL3DataTablePlanChanged.ColumnName = "PlanChanged";
            this.coldsRHUnitL3DataTablePlanChanged.DataType = typeof(int);
            this.coldsRHUnitL3DataTablePlanChanged.Namespace = "";
            // 
            // coldsRHUnitL3DataTableDeviceChanged
            // 
            this.coldsRHUnitL3DataTableDeviceChanged.Caption = "DeviceChanged";
            this.coldsRHUnitL3DataTableDeviceChanged.ColumnName = "DeviceChanged";
            this.coldsRHUnitL3DataTableDeviceChanged.DataType = typeof(int);
            this.coldsRHUnitL3DataTableDeviceChanged.Namespace = "";
            // 
            // coldsRHUnitL3DataTableTreatNo
            // 
            this.coldsRHUnitL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsRHUnitL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsRHUnitL3DataTableTreatNo.Namespace = "";
            // 
            // coldsRHUnitL3DataTableNextTreatNo
            // 
            this.coldsRHUnitL3DataTableNextTreatNo.Caption = "NextTreatNo";
            this.coldsRHUnitL3DataTableNextTreatNo.ColumnName = "NextTreatNo";
            this.coldsRHUnitL3DataTableNextTreatNo.Namespace = "";
            // 
            // coldsRHUnitL3DataTableStatus
            // 
            this.coldsRHUnitL3DataTableStatus.Caption = "Status";
            this.coldsRHUnitL3DataTableStatus.ColumnName = "Status";
            this.coldsRHUnitL3DataTableStatus.DataType = typeof(int);
            this.coldsRHUnitL3DataTableStatus.Namespace = "";
            // 
            // coldsRHUnitL3DataTableSlot_No
            // 
            this.coldsRHUnitL3DataTableSlot_No.Caption = "Slot_No";
            this.coldsRHUnitL3DataTableSlot_No.ColumnName = "Slot_No";
            this.coldsRHUnitL3DataTableSlot_No.Namespace = "";
            // 
            // coldsRHUnitL3DataTableNextSteel
            // 
            this.coldsRHUnitL3DataTableNextSteel.Caption = "NextSteel";
            this.coldsRHUnitL3DataTableNextSteel.ColumnName = "NextSteel";
            this.coldsRHUnitL3DataTableNextSteel.Namespace = "";
            // 
            // coldsRHUnitL3DataTableCurArea
            // 
            this.coldsRHUnitL3DataTableCurArea.Caption = "CurArea";
            this.coldsRHUnitL3DataTableCurArea.ColumnName = "CurArea";
            this.coldsRHUnitL3DataTableCurArea.Namespace = "";
            // 
            // coldsRHUnitL3DataTableProcStartTime
            // 
            this.coldsRHUnitL3DataTableProcStartTime.Caption = "ProcStartTime";
            this.coldsRHUnitL3DataTableProcStartTime.ColumnName = "ProcStartTime";
            this.coldsRHUnitL3DataTableProcStartTime.DataType = typeof(System.DateTime);
            this.coldsRHUnitL3DataTableProcStartTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableProcStopTime
            // 
            this.coldsRHUnitL3DataTableProcStopTime.Caption = "ProcStopTime";
            this.coldsRHUnitL3DataTableProcStopTime.ColumnName = "ProcStopTime";
            this.coldsRHUnitL3DataTableProcStopTime.DataType = typeof(System.DateTime);
            this.coldsRHUnitL3DataTableProcStopTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableOBStartTime
            // 
            this.coldsRHUnitL3DataTableOBStartTime.Caption = "OBStartTime";
            this.coldsRHUnitL3DataTableOBStartTime.ColumnName = "OBStartTime";
            this.coldsRHUnitL3DataTableOBStartTime.DataType = typeof(System.DateTime);
            this.coldsRHUnitL3DataTableOBStartTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableAlloyStartTime
            // 
            this.coldsRHUnitL3DataTableAlloyStartTime.Caption = "AlloyStartTime";
            this.coldsRHUnitL3DataTableAlloyStartTime.ColumnName = "AlloyStartTime";
            this.coldsRHUnitL3DataTableAlloyStartTime.DataType = typeof(System.DateTime);
            this.coldsRHUnitL3DataTableAlloyStartTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableProcTime
            // 
            this.coldsRHUnitL3DataTableProcTime.Caption = "ProcTime";
            this.coldsRHUnitL3DataTableProcTime.ColumnName = "ProcTime";
            this.coldsRHUnitL3DataTableProcTime.DataType = typeof(int);
            this.coldsRHUnitL3DataTableProcTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableCurTemp
            // 
            this.coldsRHUnitL3DataTableCurTemp.Caption = "CurTemp";
            this.coldsRHUnitL3DataTableCurTemp.ColumnName = "CurTemp";
            this.coldsRHUnitL3DataTableCurTemp.DataType = typeof(double);
            this.coldsRHUnitL3DataTableCurTemp.Namespace = "";
            // 
            // coldsRHUnitL3DataTableReSampleHeatID
            // 
            this.coldsRHUnitL3DataTableReSampleHeatID.Caption = "ReSampleHeatID";
            this.coldsRHUnitL3DataTableReSampleHeatID.ColumnName = "ReSampleHeatID";
            this.coldsRHUnitL3DataTableReSampleHeatID.Namespace = "";
            // 
            // coldsRHUnitL3DataTableStartProcessTime
            // 
            this.coldsRHUnitL3DataTableStartProcessTime.Caption = "StartProcessTime";
            this.coldsRHUnitL3DataTableStartProcessTime.ColumnName = "StartProcessTime";
            this.coldsRHUnitL3DataTableStartProcessTime.Namespace = "";
            // 
            // coldsRHUnitL3DataTableEquip_Status
            // 
            this.coldsRHUnitL3DataTableEquip_Status.Caption = "Equip_Status";
            this.coldsRHUnitL3DataTableEquip_Status.ColumnName = "Equip_Status";
            this.coldsRHUnitL3DataTableEquip_Status.DataType = typeof(int);
            this.coldsRHUnitL3DataTableEquip_Status.Namespace = "";
            // 
            // coldsRHUnitL3DataTableProbe_Vendor
            // 
            this.coldsRHUnitL3DataTableProbe_Vendor.Caption = "Probe_Vendor";
            this.coldsRHUnitL3DataTableProbe_Vendor.ColumnName = "Probe_Vendor";
            this.coldsRHUnitL3DataTableProbe_Vendor.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 83;
            this.label1.Text = "定氧探头厂家:";
            // 
            // cmbPoleVendor
            // 
            this.cmbPoleVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsRHUnit, "Probe_Vendor", true));
            this.cmbPoleVendor.DataSource = this.dsProbeVendor;
            this.cmbPoleVendor.DisplayMember = "L3DataTable.code_des";
            this.cmbPoleVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoleVendor.FormattingEnabled = true;
            this.cmbPoleVendor.Location = new System.Drawing.Point(99, 62);
            this.cmbPoleVendor.Name = "cmbPoleVendor";
            this.cmbPoleVendor.Size = new System.Drawing.Size(171, 20);
            this.cmbPoleVendor.TabIndex = 84;
            this.cmbPoleVendor.ValueMember = "L3DataTable.code";
            // 
            // bsRHUnit
            // 
            this.bsRHUnit.DataMember = "L3DataTable";
            this.bsRHUnit.DataSource = this.dsRHUnit;
            // 
            // txtSlotNo
            // 
            this.txtSlotNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRHUnit, "Slot_No", true));
            this.txtSlotNo.Location = new System.Drawing.Point(99, 21);
            this.txtSlotNo.Name = "txtSlotNo";
            this.txtSlotNo.Size = new System.Drawing.Size(171, 21);
            this.txtSlotNo.TabIndex = 85;
            // 
            // RHAttributeFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(302, 187);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RHAttributeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH炉属性维护";
            this.Load += new System.EventHandler(this.RHAttributeFrm_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProbeVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPoleVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRHUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private AppSvrHMI.L3DataSet dsProbeVendor;
        private System.Data.DataTable schemadsPoleVendor;
        private System.Data.DataColumn coldsPoleVendorL3DataTablecode;
        private System.Data.DataColumn coldsPoleVendorL3DataTablecode_des;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsRHUnit;
        private System.Data.DataTable schemadsRHUnit;
        private System.Data.DataColumn coldsRHUnitL3DataTableGUID;
        private System.Data.DataColumn coldsRHUnitL3DataTableName;
        private System.Data.DataColumn coldsRHUnitL3DataTableOwner;
        private System.Data.DataColumn coldsRHUnitL3DataTableCode;
        private System.Data.DataColumn coldsRHUnitL3DataTableDescription;
        private System.Data.DataColumn coldsRHUnitL3DataTableWorkShop;
        private System.Data.DataColumn coldsRHUnitL3DataTableSequenceNo;
        private System.Data.DataColumn coldsRHUnitL3DataTableMaterialProcessed;
        private System.Data.DataColumn coldsRHUnitL3DataTableMaterialFeeded;
        private System.Data.DataColumn coldsRHUnitL3DataTableMaterialDeliveried;
        private System.Data.DataColumn coldsRHUnitL3DataTablePlanChanged;
        private System.Data.DataColumn coldsRHUnitL3DataTableDeviceChanged;
        private System.Data.DataColumn coldsRHUnitL3DataTableTreatNo;
        private System.Data.DataColumn coldsRHUnitL3DataTableNextTreatNo;
        private System.Data.DataColumn coldsRHUnitL3DataTableStatus;
        private System.Data.DataColumn coldsRHUnitL3DataTableSlot_No;
        private System.Data.DataColumn coldsRHUnitL3DataTableNextSteel;
        private System.Data.DataColumn coldsRHUnitL3DataTableCurArea;
        private System.Data.DataColumn coldsRHUnitL3DataTableProcStartTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableProcStopTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableOBStartTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableAlloyStartTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableProcTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableCurTemp;
        private System.Data.DataColumn coldsRHUnitL3DataTableReSampleHeatID;
        private System.Data.DataColumn coldsRHUnitL3DataTableStartProcessTime;
        private System.Data.DataColumn coldsRHUnitL3DataTableEquip_Status;
        private System.Data.DataColumn coldsRHUnitL3DataTableProbe_Vendor;
        private System.Windows.Forms.ComboBox cmbPoleVendor;
        private System.Windows.Forms.BindingSource bsRHUnit;
        private System.Windows.Forms.TextBox txtSlotNo;
    }
}