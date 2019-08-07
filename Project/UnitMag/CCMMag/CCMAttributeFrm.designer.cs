namespace UnitMag.CCMMag
{
    partial class CCMAttributeFrm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.off4 = new System.Windows.Forms.RadioButton();
            this.on4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.off3 = new System.Windows.Forms.RadioButton();
            this.on3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.off2 = new System.Windows.Forms.RadioButton();
            this.on2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.off1 = new System.Windows.Forms.RadioButton();
            this.on1 = new System.Windows.Forms.RadioButton();
            this.dsCCMProp = new AppSvrHMI.L3DataSet();
            this.schemadsCCMProp = new System.Data.DataTable();
            this.coldsCCMPropL3DataTableGUID = new System.Data.DataColumn();
            this.coldsCCMPropL3DataTableName = new System.Data.DataColumn();
            this.coldsCCMPropL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsCCMPropL3DataTableOnOff = new System.Data.DataColumn();
            this.cmdCCMProp = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsCCMPropTruth = new AppSvrHMI.L3DataSet();
            this.schemadsCCMPropTruth = new System.Data.DataTable();
            this.coldsCCMPropTruthL3DataTableGUID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableName = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableOwner = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCode = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableDescription = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableWorkShop = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSequenceNo = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableMaterialProcessed = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableMaterialFeeded = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTablePlanChanged = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableDeviceChanged = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableStatus = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCastingNo = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableNextHeatID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableRemainedWeight = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCastingEndEvent = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCutSampleHeatID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableReSampleHeatID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableArriveTime = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableStartCastingTime = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableNextLadleID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableTundishWeight = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableEastTundishID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableWestTundishID = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSteelWeight = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableTundishTemp = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSpeed1st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSpeed2st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSpeed3st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSpeed4st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCastTo15Minute = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableOnOff1st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableOnOff2st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableOnOff3st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableOnOff4st = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableEquip_Status = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableCut_Information = new System.Data.DataColumn();
            this.coldsCCMPropTruthL3DataTableRemainCastingTime = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMPropTruth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMPropTruth)).BeginInit();
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
            this.panel3.Location = new System.Drawing.Point(0, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 41);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(380, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(302, 6);
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
            this.tabControl1.Size = new System.Drawing.Size(471, 242);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铸机信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.off4);
            this.groupBox4.Controls.Add(this.on4);
            this.groupBox4.Location = new System.Drawing.Point(264, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 73);
            this.groupBox4.TabIndex = 87;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "      ";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox4.Location = new System.Drawing.Point(6, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 16);
            this.checkBox4.TabIndex = 88;
            this.checkBox4.Text = "四流";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // off4
            // 
            this.off4.AutoSize = true;
            this.off4.Location = new System.Drawing.Point(105, 36);
            this.off4.Name = "off4";
            this.off4.Size = new System.Drawing.Size(47, 16);
            this.off4.TabIndex = 0;
            this.off4.TabStop = true;
            this.off4.Text = "停浇";
            this.off4.UseVisualStyleBackColor = true;
            // 
            // on4
            // 
            this.on4.AutoSize = true;
            this.on4.Location = new System.Drawing.Point(31, 36);
            this.on4.Name = "on4";
            this.on4.Size = new System.Drawing.Size(47, 16);
            this.on4.TabIndex = 0;
            this.on4.TabStop = true;
            this.on4.Text = "开浇";
            this.on4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.off3);
            this.groupBox3.Controls.Add(this.on3);
            this.groupBox3.Location = new System.Drawing.Point(30, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 73);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "       ";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox3.Location = new System.Drawing.Point(6, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 88;
            this.checkBox3.Text = "三流";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // off3
            // 
            this.off3.AutoSize = true;
            this.off3.Location = new System.Drawing.Point(105, 36);
            this.off3.Name = "off3";
            this.off3.Size = new System.Drawing.Size(47, 16);
            this.off3.TabIndex = 0;
            this.off3.TabStop = true;
            this.off3.Text = "停浇";
            this.off3.UseVisualStyleBackColor = true;
            // 
            // on3
            // 
            this.on3.AutoSize = true;
            this.on3.Location = new System.Drawing.Point(31, 36);
            this.on3.Name = "on3";
            this.on3.Size = new System.Drawing.Size(47, 16);
            this.on3.TabIndex = 0;
            this.on3.TabStop = true;
            this.on3.Text = "开浇";
            this.on3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.off2);
            this.groupBox2.Controls.Add(this.on2);
            this.groupBox2.Location = new System.Drawing.Point(264, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 73);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "       ";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox2.Location = new System.Drawing.Point(6, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 16);
            this.checkBox2.TabIndex = 88;
            this.checkBox2.Text = "二流";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // off2
            // 
            this.off2.AutoSize = true;
            this.off2.Location = new System.Drawing.Point(105, 36);
            this.off2.Name = "off2";
            this.off2.Size = new System.Drawing.Size(47, 16);
            this.off2.TabIndex = 0;
            this.off2.TabStop = true;
            this.off2.Text = "停浇";
            this.off2.UseVisualStyleBackColor = true;
            // 
            // on2
            // 
            this.on2.AutoSize = true;
            this.on2.Location = new System.Drawing.Point(31, 36);
            this.on2.Name = "on2";
            this.on2.Size = new System.Drawing.Size(47, 16);
            this.on2.TabIndex = 0;
            this.on2.TabStop = true;
            this.on2.Text = "开浇";
            this.on2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.off1);
            this.groupBox1.Controls.Add(this.on1);
            this.groupBox1.Location = new System.Drawing.Point(30, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 73);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "       ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox1.Location = new System.Drawing.Point(6, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 88;
            this.checkBox1.Text = "一流";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // off1
            // 
            this.off1.AutoSize = true;
            this.off1.Location = new System.Drawing.Point(105, 36);
            this.off1.Name = "off1";
            this.off1.Size = new System.Drawing.Size(47, 16);
            this.off1.TabIndex = 0;
            this.off1.TabStop = true;
            this.off1.Text = "停浇";
            this.off1.UseVisualStyleBackColor = true;
            // 
            // on1
            // 
            this.on1.AutoSize = true;
            this.on1.Location = new System.Drawing.Point(31, 36);
            this.on1.Name = "on1";
            this.on1.Size = new System.Drawing.Size(47, 16);
            this.on1.TabIndex = 0;
            this.on1.Text = "开浇";
            this.on1.UseVisualStyleBackColor = true;
            // 
            // dsCCMProp
            // 
            this.dsCCMProp.AutoLoad = true;
            this.dsCCMProp.AutoSubscribe = false;
            this.dsCCMProp.DataSetName = "L3DataSet";
            this.dsCCMProp.DeleteMethod = "";
            this.dsCCMProp.InsertMethod = "";
            this.dsCCMProp.L3DataAdapter = null;
            this.dsCCMProp.LoadEvent = "";
            this.dsCCMProp.LoadTrigger = null;
            this.dsCCMProp.RefreshValve = 1000;
            this.dsCCMProp.SourceCommand = null;
            this.dsCCMProp.SourceCondition = "";
            this.dsCCMProp.SourceMethod = "";
            this.dsCCMProp.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsCCMProp.SourceURI = "";
            this.dsCCMProp.SubscribeTarget = "";
            this.dsCCMProp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMProp});
            this.dsCCMProp.UpdateEvent = "";
            this.dsCCMProp.UpdateMethod = "";
            this.dsCCMProp.UpdateTrigger = null;
            // 
            // schemadsCCMProp
            // 
            this.schemadsCCMProp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMPropL3DataTableGUID,
            this.coldsCCMPropL3DataTableName,
            this.coldsCCMPropL3DataTableStrandNo,
            this.coldsCCMPropL3DataTableOnOff});
            this.schemadsCCMProp.TableName = "L3DataTable";
            // 
            // coldsCCMPropL3DataTableGUID
            // 
            this.coldsCCMPropL3DataTableGUID.Caption = "GUID";
            this.coldsCCMPropL3DataTableGUID.ColumnName = "GUID";
            this.coldsCCMPropL3DataTableGUID.Namespace = "";
            // 
            // coldsCCMPropL3DataTableName
            // 
            this.coldsCCMPropL3DataTableName.Caption = "Name";
            this.coldsCCMPropL3DataTableName.ColumnName = "Name";
            this.coldsCCMPropL3DataTableName.Namespace = "";
            // 
            // coldsCCMPropL3DataTableStrandNo
            // 
            this.coldsCCMPropL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsCCMPropL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsCCMPropL3DataTableStrandNo.DataType = typeof(int);
            this.coldsCCMPropL3DataTableStrandNo.Namespace = "";
            // 
            // coldsCCMPropL3DataTableOnOff
            // 
            this.coldsCCMPropL3DataTableOnOff.Caption = "OnOff";
            this.coldsCCMPropL3DataTableOnOff.ColumnName = "OnOff";
            this.coldsCCMPropL3DataTableOnOff.DataType = typeof(int);
            this.coldsCCMPropL3DataTableOnOff.Namespace = "";
            // 
            // cmdCCMProp
            // 
            this.cmdCCMProp.Adapter = this.Adapter;
            this.cmdCCMProp.MergeReturnTarget = false;
            this.cmdCCMProp.Method = "";
            this.cmdCCMProp.Object = "";
            this.cmdCCMProp.Parameters.Add(this.l3CommandParameter1);
            this.cmdCCMProp.ReturnTarget = null;
            this.cmdCCMProp.ReturnTargetProperty = null;
            this.cmdCCMProp.Trigger = null;
            this.cmdCCMProp.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsCCMProp;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsCCMPropTruth
            // 
            this.dsCCMPropTruth.AutoLoad = true;
            this.dsCCMPropTruth.AutoSubscribe = false;
            this.dsCCMPropTruth.DataSetName = "L3DataSet";
            this.dsCCMPropTruth.DeleteMethod = "";
            this.dsCCMPropTruth.InsertMethod = "";
            this.dsCCMPropTruth.L3DataAdapter = this.Adapter;
            this.dsCCMPropTruth.LoadEvent = "";
            this.dsCCMPropTruth.LoadTrigger = null;
            this.dsCCMPropTruth.RefreshValve = 1000;
            this.dsCCMPropTruth.SourceCommand = null;
            this.dsCCMPropTruth.SourceCondition = "";
            this.dsCCMPropTruth.SourceMethod = "";
            this.dsCCMPropTruth.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCMPropTruth.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag";
            this.dsCCMPropTruth.SubscribeTarget = null;
            this.dsCCMPropTruth.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMPropTruth});
            this.dsCCMPropTruth.UpdateEvent = "";
            this.dsCCMPropTruth.UpdateMethod = "";
            this.dsCCMPropTruth.UpdateTrigger = null;
            // 
            // schemadsCCMPropTruth
            // 
            this.schemadsCCMPropTruth.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMPropTruthL3DataTableGUID,
            this.coldsCCMPropTruthL3DataTableName,
            this.coldsCCMPropTruthL3DataTableOwner,
            this.coldsCCMPropTruthL3DataTableCode,
            this.coldsCCMPropTruthL3DataTableDescription,
            this.coldsCCMPropTruthL3DataTableWorkShop,
            this.coldsCCMPropTruthL3DataTableSequenceNo,
            this.coldsCCMPropTruthL3DataTableMaterialProcessed,
            this.coldsCCMPropTruthL3DataTableMaterialFeeded,
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried,
            this.coldsCCMPropTruthL3DataTablePlanChanged,
            this.coldsCCMPropTruthL3DataTableDeviceChanged,
            this.coldsCCMPropTruthL3DataTableStatus,
            this.coldsCCMPropTruthL3DataTableTreatNo,
            this.coldsCCMPropTruthL3DataTableCastingNo,
            this.coldsCCMPropTruthL3DataTableTundishNo,
            this.coldsCCMPropTruthL3DataTableHeatID,
            this.coldsCCMPropTruthL3DataTableNextHeatID,
            this.coldsCCMPropTruthL3DataTableSteelGradeIndex,
            this.coldsCCMPropTruthL3DataTableSteelGrade,
            this.coldsCCMPropTruthL3DataTableRemainedWeight,
            this.coldsCCMPropTruthL3DataTableCastingEndEvent,
            this.coldsCCMPropTruthL3DataTableCutSampleHeatID,
            this.coldsCCMPropTruthL3DataTableReSampleHeatID,
            this.coldsCCMPropTruthL3DataTableArriveTime,
            this.coldsCCMPropTruthL3DataTableStartCastingTime,
            this.coldsCCMPropTruthL3DataTableLadleID,
            this.coldsCCMPropTruthL3DataTableNextLadleID,
            this.coldsCCMPropTruthL3DataTableTundishWeight,
            this.coldsCCMPropTruthL3DataTableEastTundishID,
            this.coldsCCMPropTruthL3DataTableWestTundishID,
            this.coldsCCMPropTruthL3DataTableSteelWeight,
            this.coldsCCMPropTruthL3DataTableTundishTemp,
            this.coldsCCMPropTruthL3DataTableSpeed1st,
            this.coldsCCMPropTruthL3DataTableSpeed2st,
            this.coldsCCMPropTruthL3DataTableSpeed3st,
            this.coldsCCMPropTruthL3DataTableSpeed4st,
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st,
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st,
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st,
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st,
            this.coldsCCMPropTruthL3DataTableCastTo15Minute,
            this.coldsCCMPropTruthL3DataTableOnOff1st,
            this.coldsCCMPropTruthL3DataTableOnOff2st,
            this.coldsCCMPropTruthL3DataTableOnOff3st,
            this.coldsCCMPropTruthL3DataTableOnOff4st,
            this.coldsCCMPropTruthL3DataTableEquip_Status,
            this.coldsCCMPropTruthL3DataTableCut_Information,
            this.coldsCCMPropTruthL3DataTableRemainCastingTime});
            this.schemadsCCMPropTruth.TableName = "L3DataTable";
            // 
            // coldsCCMPropTruthL3DataTableGUID
            // 
            this.coldsCCMPropTruthL3DataTableGUID.Caption = "GUID";
            this.coldsCCMPropTruthL3DataTableGUID.ColumnName = "GUID";
            this.coldsCCMPropTruthL3DataTableGUID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableName
            // 
            this.coldsCCMPropTruthL3DataTableName.Caption = "Name";
            this.coldsCCMPropTruthL3DataTableName.ColumnName = "Name";
            this.coldsCCMPropTruthL3DataTableName.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableOwner
            // 
            this.coldsCCMPropTruthL3DataTableOwner.Caption = "Owner";
            this.coldsCCMPropTruthL3DataTableOwner.ColumnName = "Owner";
            this.coldsCCMPropTruthL3DataTableOwner.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCode
            // 
            this.coldsCCMPropTruthL3DataTableCode.Caption = "Code";
            this.coldsCCMPropTruthL3DataTableCode.ColumnName = "Code";
            this.coldsCCMPropTruthL3DataTableCode.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableDescription
            // 
            this.coldsCCMPropTruthL3DataTableDescription.Caption = "Description";
            this.coldsCCMPropTruthL3DataTableDescription.ColumnName = "Description";
            this.coldsCCMPropTruthL3DataTableDescription.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableWorkShop
            // 
            this.coldsCCMPropTruthL3DataTableWorkShop.Caption = "WorkShop";
            this.coldsCCMPropTruthL3DataTableWorkShop.ColumnName = "WorkShop";
            this.coldsCCMPropTruthL3DataTableWorkShop.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSequenceNo
            // 
            this.coldsCCMPropTruthL3DataTableSequenceNo.Caption = "SequenceNo";
            this.coldsCCMPropTruthL3DataTableSequenceNo.ColumnName = "SequenceNo";
            this.coldsCCMPropTruthL3DataTableSequenceNo.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableSequenceNo.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableMaterialProcessed
            // 
            this.coldsCCMPropTruthL3DataTableMaterialProcessed.Caption = "MaterialProcessed";
            this.coldsCCMPropTruthL3DataTableMaterialProcessed.ColumnName = "MaterialProcessed";
            this.coldsCCMPropTruthL3DataTableMaterialProcessed.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableMaterialProcessed.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableMaterialFeeded
            // 
            this.coldsCCMPropTruthL3DataTableMaterialFeeded.Caption = "MaterialFeeded";
            this.coldsCCMPropTruthL3DataTableMaterialFeeded.ColumnName = "MaterialFeeded";
            this.coldsCCMPropTruthL3DataTableMaterialFeeded.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableMaterialFeeded.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableMaterialDeliveried
            // 
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried.Caption = "MaterialDeliveried";
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried.ColumnName = "MaterialDeliveried";
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableMaterialDeliveried.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTablePlanChanged
            // 
            this.coldsCCMPropTruthL3DataTablePlanChanged.Caption = "PlanChanged";
            this.coldsCCMPropTruthL3DataTablePlanChanged.ColumnName = "PlanChanged";
            this.coldsCCMPropTruthL3DataTablePlanChanged.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTablePlanChanged.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableDeviceChanged
            // 
            this.coldsCCMPropTruthL3DataTableDeviceChanged.Caption = "DeviceChanged";
            this.coldsCCMPropTruthL3DataTableDeviceChanged.ColumnName = "DeviceChanged";
            this.coldsCCMPropTruthL3DataTableDeviceChanged.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableDeviceChanged.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableStatus
            // 
            this.coldsCCMPropTruthL3DataTableStatus.Caption = "Status";
            this.coldsCCMPropTruthL3DataTableStatus.ColumnName = "Status";
            this.coldsCCMPropTruthL3DataTableStatus.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableStatus.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableTreatNo
            // 
            this.coldsCCMPropTruthL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsCCMPropTruthL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsCCMPropTruthL3DataTableTreatNo.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCastingNo
            // 
            this.coldsCCMPropTruthL3DataTableCastingNo.Caption = "CastingNo";
            this.coldsCCMPropTruthL3DataTableCastingNo.ColumnName = "CastingNo";
            this.coldsCCMPropTruthL3DataTableCastingNo.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableTundishNo
            // 
            this.coldsCCMPropTruthL3DataTableTundishNo.Caption = "TundishNo";
            this.coldsCCMPropTruthL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsCCMPropTruthL3DataTableTundishNo.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableHeatID
            // 
            this.coldsCCMPropTruthL3DataTableHeatID.Caption = "HeatID";
            this.coldsCCMPropTruthL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsCCMPropTruthL3DataTableHeatID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableNextHeatID
            // 
            this.coldsCCMPropTruthL3DataTableNextHeatID.Caption = "NextHeatID";
            this.coldsCCMPropTruthL3DataTableNextHeatID.ColumnName = "NextHeatID";
            this.coldsCCMPropTruthL3DataTableNextHeatID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSteelGradeIndex
            // 
            this.coldsCCMPropTruthL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsCCMPropTruthL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsCCMPropTruthL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSteelGrade
            // 
            this.coldsCCMPropTruthL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsCCMPropTruthL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsCCMPropTruthL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableRemainedWeight
            // 
            this.coldsCCMPropTruthL3DataTableRemainedWeight.Caption = "RemainedWeight";
            this.coldsCCMPropTruthL3DataTableRemainedWeight.ColumnName = "RemainedWeight";
            this.coldsCCMPropTruthL3DataTableRemainedWeight.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableRemainedWeight.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCastingEndEvent
            // 
            this.coldsCCMPropTruthL3DataTableCastingEndEvent.Caption = "CastingEndEvent";
            this.coldsCCMPropTruthL3DataTableCastingEndEvent.ColumnName = "CastingEndEvent";
            this.coldsCCMPropTruthL3DataTableCastingEndEvent.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableCastingEndEvent.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCutSampleHeatID
            // 
            this.coldsCCMPropTruthL3DataTableCutSampleHeatID.Caption = "CutSampleHeatID";
            this.coldsCCMPropTruthL3DataTableCutSampleHeatID.ColumnName = "CutSampleHeatID";
            this.coldsCCMPropTruthL3DataTableCutSampleHeatID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableReSampleHeatID
            // 
            this.coldsCCMPropTruthL3DataTableReSampleHeatID.Caption = "ReSampleHeatID";
            this.coldsCCMPropTruthL3DataTableReSampleHeatID.ColumnName = "ReSampleHeatID";
            this.coldsCCMPropTruthL3DataTableReSampleHeatID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableArriveTime
            // 
            this.coldsCCMPropTruthL3DataTableArriveTime.Caption = "ArriveTime";
            this.coldsCCMPropTruthL3DataTableArriveTime.ColumnName = "ArriveTime";
            this.coldsCCMPropTruthL3DataTableArriveTime.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableStartCastingTime
            // 
            this.coldsCCMPropTruthL3DataTableStartCastingTime.Caption = "StartCastingTime";
            this.coldsCCMPropTruthL3DataTableStartCastingTime.ColumnName = "StartCastingTime";
            this.coldsCCMPropTruthL3DataTableStartCastingTime.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableLadleID
            // 
            this.coldsCCMPropTruthL3DataTableLadleID.Caption = "LadleID";
            this.coldsCCMPropTruthL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsCCMPropTruthL3DataTableLadleID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableNextLadleID
            // 
            this.coldsCCMPropTruthL3DataTableNextLadleID.Caption = "NextLadleID";
            this.coldsCCMPropTruthL3DataTableNextLadleID.ColumnName = "NextLadleID";
            this.coldsCCMPropTruthL3DataTableNextLadleID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableTundishWeight
            // 
            this.coldsCCMPropTruthL3DataTableTundishWeight.Caption = "TundishWeight";
            this.coldsCCMPropTruthL3DataTableTundishWeight.ColumnName = "TundishWeight";
            this.coldsCCMPropTruthL3DataTableTundishWeight.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableTundishWeight.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableEastTundishID
            // 
            this.coldsCCMPropTruthL3DataTableEastTundishID.Caption = "EastTundishID";
            this.coldsCCMPropTruthL3DataTableEastTundishID.ColumnName = "EastTundishID";
            this.coldsCCMPropTruthL3DataTableEastTundishID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableWestTundishID
            // 
            this.coldsCCMPropTruthL3DataTableWestTundishID.Caption = "WestTundishID";
            this.coldsCCMPropTruthL3DataTableWestTundishID.ColumnName = "WestTundishID";
            this.coldsCCMPropTruthL3DataTableWestTundishID.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSteelWeight
            // 
            this.coldsCCMPropTruthL3DataTableSteelWeight.Caption = "SteelWeight";
            this.coldsCCMPropTruthL3DataTableSteelWeight.ColumnName = "SteelWeight";
            this.coldsCCMPropTruthL3DataTableSteelWeight.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSteelWeight.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableTundishTemp
            // 
            this.coldsCCMPropTruthL3DataTableTundishTemp.Caption = "TundishTemp";
            this.coldsCCMPropTruthL3DataTableTundishTemp.ColumnName = "TundishTemp";
            this.coldsCCMPropTruthL3DataTableTundishTemp.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableTundishTemp.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSpeed1st
            // 
            this.coldsCCMPropTruthL3DataTableSpeed1st.Caption = "Speed1st";
            this.coldsCCMPropTruthL3DataTableSpeed1st.ColumnName = "Speed1st";
            this.coldsCCMPropTruthL3DataTableSpeed1st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSpeed1st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSpeed2st
            // 
            this.coldsCCMPropTruthL3DataTableSpeed2st.Caption = "Speed2st";
            this.coldsCCMPropTruthL3DataTableSpeed2st.ColumnName = "Speed2st";
            this.coldsCCMPropTruthL3DataTableSpeed2st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSpeed2st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSpeed3st
            // 
            this.coldsCCMPropTruthL3DataTableSpeed3st.Caption = "Speed3st";
            this.coldsCCMPropTruthL3DataTableSpeed3st.ColumnName = "Speed3st";
            this.coldsCCMPropTruthL3DataTableSpeed3st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSpeed3st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSpeed4st
            // 
            this.coldsCCMPropTruthL3DataTableSpeed4st.Caption = "Speed4st";
            this.coldsCCMPropTruthL3DataTableSpeed4st.ColumnName = "Speed4st";
            this.coldsCCMPropTruthL3DataTableSpeed4st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSpeed4st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSumCastWeight1st
            // 
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st.Caption = "SumCastWeight1st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st.ColumnName = "SumCastWeight1st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSumCastWeight1st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSumCastWeight2st
            // 
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st.Caption = "SumCastWeight2st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st.ColumnName = "SumCastWeight2st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSumCastWeight2st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSumCastWeight3st
            // 
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st.Caption = "SumCastWeight3st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st.ColumnName = "SumCastWeight3st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSumCastWeight3st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableSumCastWeight4st
            // 
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st.Caption = "SumCastWeight4st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st.ColumnName = "SumCastWeight4st";
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st.DataType = typeof(double);
            this.coldsCCMPropTruthL3DataTableSumCastWeight4st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCastTo15Minute
            // 
            this.coldsCCMPropTruthL3DataTableCastTo15Minute.Caption = "CastTo15Minute";
            this.coldsCCMPropTruthL3DataTableCastTo15Minute.ColumnName = "CastTo15Minute";
            this.coldsCCMPropTruthL3DataTableCastTo15Minute.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableCastTo15Minute.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableOnOff1st
            // 
            this.coldsCCMPropTruthL3DataTableOnOff1st.Caption = "OnOff1st";
            this.coldsCCMPropTruthL3DataTableOnOff1st.ColumnName = "OnOff1st";
            this.coldsCCMPropTruthL3DataTableOnOff1st.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableOnOff1st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableOnOff2st
            // 
            this.coldsCCMPropTruthL3DataTableOnOff2st.Caption = "OnOff2st";
            this.coldsCCMPropTruthL3DataTableOnOff2st.ColumnName = "OnOff2st";
            this.coldsCCMPropTruthL3DataTableOnOff2st.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableOnOff2st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableOnOff3st
            // 
            this.coldsCCMPropTruthL3DataTableOnOff3st.Caption = "OnOff3st";
            this.coldsCCMPropTruthL3DataTableOnOff3st.ColumnName = "OnOff3st";
            this.coldsCCMPropTruthL3DataTableOnOff3st.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableOnOff3st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableOnOff4st
            // 
            this.coldsCCMPropTruthL3DataTableOnOff4st.Caption = "OnOff4st";
            this.coldsCCMPropTruthL3DataTableOnOff4st.ColumnName = "OnOff4st";
            this.coldsCCMPropTruthL3DataTableOnOff4st.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableOnOff4st.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableEquip_Status
            // 
            this.coldsCCMPropTruthL3DataTableEquip_Status.Caption = "Equip_Status";
            this.coldsCCMPropTruthL3DataTableEquip_Status.ColumnName = "Equip_Status";
            this.coldsCCMPropTruthL3DataTableEquip_Status.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableEquip_Status.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableCut_Information
            // 
            this.coldsCCMPropTruthL3DataTableCut_Information.Caption = "Cut_Information";
            this.coldsCCMPropTruthL3DataTableCut_Information.ColumnName = "Cut_Information";
            this.coldsCCMPropTruthL3DataTableCut_Information.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableCut_Information.Namespace = "";
            // 
            // coldsCCMPropTruthL3DataTableRemainCastingTime
            // 
            this.coldsCCMPropTruthL3DataTableRemainCastingTime.Caption = "RemainCastingTime";
            this.coldsCCMPropTruthL3DataTableRemainCastingTime.ColumnName = "RemainCastingTime";
            this.coldsCCMPropTruthL3DataTableRemainCastingTime.DataType = typeof(int);
            this.coldsCCMPropTruthL3DataTableRemainCastingTime.Namespace = "";
            // 
            // CCMAttributeFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CCMAttributeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铸机属性维护";
            this.Load += new System.EventHandler(this.CCMAttributeFrm_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMPropTruth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMPropTruth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AppSvrHMI.L3DataSet dsCCMProp;
        private System.Data.DataTable schemadsCCMProp;
        private System.Data.DataColumn coldsCCMPropL3DataTableGUID;
        private System.Data.DataColumn coldsCCMPropL3DataTableName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton off4;
        private System.Windows.Forms.RadioButton on4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton off3;
        private System.Windows.Forms.RadioButton on3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton off2;
        private System.Windows.Forms.RadioButton on2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton off1;
        private System.Windows.Forms.RadioButton on1;
        private System.Data.DataColumn coldsCCMPropL3DataTableStrandNo;
        private System.Data.DataColumn coldsCCMPropL3DataTableOnOff;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private AppSvrHMI.L3Command cmdCCMProp;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsCCMPropTruth;
        private System.Data.DataTable schemadsCCMPropTruth;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableGUID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableName;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableOwner;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCode;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableDescription;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableWorkShop;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSequenceNo;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableMaterialProcessed;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableMaterialFeeded;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableMaterialDeliveried;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTablePlanChanged;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableDeviceChanged;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableStatus;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableTreatNo;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCastingNo;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableTundishNo;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableHeatID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableNextHeatID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSteelGrade;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableRemainedWeight;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCastingEndEvent;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCutSampleHeatID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableReSampleHeatID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableArriveTime;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableStartCastingTime;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableLadleID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableNextLadleID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableTundishWeight;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableEastTundishID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableWestTundishID;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSteelWeight;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableTundishTemp;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSpeed1st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSpeed2st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSpeed3st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSpeed4st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSumCastWeight1st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSumCastWeight2st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSumCastWeight3st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableSumCastWeight4st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCastTo15Minute;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableOnOff1st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableOnOff2st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableOnOff3st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableOnOff4st;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableEquip_Status;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableCut_Information;
        private System.Data.DataColumn coldsCCMPropTruthL3DataTableRemainCastingTime;
    }
}