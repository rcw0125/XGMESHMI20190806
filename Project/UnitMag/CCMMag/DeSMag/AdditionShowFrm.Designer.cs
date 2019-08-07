namespace UnitMag.DeSMag
{
    partial class AdditionShowFrm
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
            this.tpAdditon = new System.Windows.Forms.TabPage();
            this.cmbMatVendor = new System.Windows.Forms.ComboBox();
            this.bsAddition = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdditon = new AppSvrHMI.L3DataSet();
            this.schemadsAdditon = new System.Data.DataTable();
            this.coldsAdditonL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableWeight = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableName = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableMat_Code = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableMat_Vendor = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableTime_Discharge = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableShift = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableTeam = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableOperator = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableTime_Begin_Discharge = new System.Data.DataColumn();
            this.coldsAdditonL3DataTableTime_Stop_Discharge = new System.Data.DataColumn();
            this.dsMatVendor = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMatVendor = new System.Data.DataTable();
            this.coldsMatVendorL3DataTablecode = new System.Data.DataColumn();
            this.coldsMatVendorL3DataTablecode_des = new System.Data.DataColumn();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.txtWeight = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbMatCode = new System.Windows.Forms.ComboBox();
            this.dsMatCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTablecode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTablecode_des = new System.Data.DataColumn();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
            this.dsDeSUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsDeSUnitID = new System.Data.DataTable();
            this.coldsDeSUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsDeSUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.l3txtMatVendor1 = new AppSvrHMI.L3DataBox();
            this.l3txtMatCode1 = new AppSvrHMI.L3DataBox();
            this.cmdNewDeSAdditionData = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3txtMatCode2 = new AppSvrHMI.L3DataBox();
            this.l3txtMatVendor2 = new AppSvrHMI.L3DataBox();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.tcMain.SuspendLayout();
            this.tpAdditon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAdditon);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(566, 218);
            this.tcMain.TabIndex = 5;
            // 
            // tpAdditon
            // 
            this.tpAdditon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAdditon.Controls.Add(this.cmbMatVendor);
            this.tpAdditon.Controls.Add(this.dtpStop);
            this.tpAdditon.Controls.Add(this.dtpBegin);
            this.tpAdditon.Controls.Add(this.txtWeight);
            this.tpAdditon.Controls.Add(this.cmbMatCode);
            this.tpAdditon.Controls.Add(this.cmbUnitID);
            this.tpAdditon.Controls.Add(this.label3);
            this.tpAdditon.Controls.Add(this.label4);
            this.tpAdditon.Controls.Add(this.label6);
            this.tpAdditon.Controls.Add(this.label5);
            this.tpAdditon.Controls.Add(this.label2);
            this.tpAdditon.Controls.Add(this.label1);
            this.tpAdditon.Location = new System.Drawing.Point(4, 21);
            this.tpAdditon.Name = "tpAdditon";
            this.tpAdditon.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdditon.Size = new System.Drawing.Size(558, 193);
            this.tpAdditon.TabIndex = 0;
            this.tpAdditon.Text = "加料信息";
            this.tpAdditon.UseVisualStyleBackColor = true;
            // 
            // cmbMatVendor
            // 
            this.cmbMatVendor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAddition, "Mat_Vendor", true));
            this.cmbMatVendor.DataSource = this.dsMatVendor;
            this.cmbMatVendor.DisplayMember = "L3DataTable.code_des";
            this.cmbMatVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatVendor.FormattingEnabled = true;
            this.cmbMatVendor.Location = new System.Drawing.Point(129, 126);
            this.cmbMatVendor.Name = "cmbMatVendor";
            this.cmbMatVendor.Size = new System.Drawing.Size(121, 20);
            this.cmbMatVendor.TabIndex = 4;
            this.cmbMatVendor.ValueMember = "L3DataTable.code";
            // 
            // bsAddition
            // 
            this.bsAddition.DataMember = "L3DataTable";
            this.bsAddition.DataSource = this.dsAdditon;
            // 
            // dsAdditon
            // 
            this.dsAdditon.AutoLoad = false;
            this.dsAdditon.AutoSubscribe = false;
            this.dsAdditon.DataSetName = "L3DataSet";
            this.dsAdditon.DeleteMethod = "";
            this.dsAdditon.InsertMethod = "";
            this.dsAdditon.L3DataAdapter = null;
            this.dsAdditon.LoadEvent = "";
            this.dsAdditon.LoadTrigger = null;
            this.dsAdditon.RefreshValve = 1000;
            this.dsAdditon.SourceCommand = null;
            this.dsAdditon.SourceCondition = "";
            this.dsAdditon.SourceMethod = "";
            this.dsAdditon.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsAdditon.SourceURI = "";
            this.dsAdditon.SubscribeTarget = "";
            this.dsAdditon.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdditon});
            this.dsAdditon.UpdateEvent = "";
            this.dsAdditon.UpdateMethod = "";
            this.dsAdditon.UpdateTrigger = null;
            // 
            // schemadsAdditon
            // 
            this.schemadsAdditon.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdditonL3DataTableUnitID,
            this.coldsAdditonL3DataTableWeight,
            this.coldsAdditonL3DataTableGUID,
            this.coldsAdditonL3DataTableName,
            this.coldsAdditonL3DataTableMat_Code,
            this.coldsAdditonL3DataTableMat_Vendor,
            this.coldsAdditonL3DataTableTime_Discharge,
            this.coldsAdditonL3DataTableShift,
            this.coldsAdditonL3DataTableTeam,
            this.coldsAdditonL3DataTableOperator,
            this.coldsAdditonL3DataTableTime_Begin_Discharge,
            this.coldsAdditonL3DataTableTime_Stop_Discharge});
            this.schemadsAdditon.TableName = "L3DataTable";
            // 
            // coldsAdditonL3DataTableUnitID
            // 
            this.coldsAdditonL3DataTableUnitID.Caption = "UnitID";
            this.coldsAdditonL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsAdditonL3DataTableUnitID.Namespace = "";
            // 
            // coldsAdditonL3DataTableWeight
            // 
            this.coldsAdditonL3DataTableWeight.Caption = "Weight";
            this.coldsAdditonL3DataTableWeight.ColumnName = "Weight";
            this.coldsAdditonL3DataTableWeight.DataType = typeof(float);
            this.coldsAdditonL3DataTableWeight.Namespace = "";
            // 
            // coldsAdditonL3DataTableGUID
            // 
            this.coldsAdditonL3DataTableGUID.Caption = "GUID";
            this.coldsAdditonL3DataTableGUID.ColumnName = "GUID";
            this.coldsAdditonL3DataTableGUID.Namespace = "";
            // 
            // coldsAdditonL3DataTableName
            // 
            this.coldsAdditonL3DataTableName.Caption = "Name";
            this.coldsAdditonL3DataTableName.ColumnName = "Name";
            this.coldsAdditonL3DataTableName.Namespace = "";
            // 
            // coldsAdditonL3DataTableMat_Code
            // 
            this.coldsAdditonL3DataTableMat_Code.Caption = "Mat_Code";
            this.coldsAdditonL3DataTableMat_Code.ColumnName = "Mat_Code";
            this.coldsAdditonL3DataTableMat_Code.Namespace = "";
            // 
            // coldsAdditonL3DataTableMat_Vendor
            // 
            this.coldsAdditonL3DataTableMat_Vendor.Caption = "Mat_Vendor";
            this.coldsAdditonL3DataTableMat_Vendor.ColumnName = "Mat_Vendor";
            this.coldsAdditonL3DataTableMat_Vendor.Namespace = "";
            // 
            // coldsAdditonL3DataTableTime_Discharge
            // 
            this.coldsAdditonL3DataTableTime_Discharge.Caption = "Time_Discharge";
            this.coldsAdditonL3DataTableTime_Discharge.ColumnName = "Time_Discharge";
            this.coldsAdditonL3DataTableTime_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditonL3DataTableTime_Discharge.Namespace = "";
            // 
            // coldsAdditonL3DataTableShift
            // 
            this.coldsAdditonL3DataTableShift.Caption = "Shift";
            this.coldsAdditonL3DataTableShift.ColumnName = "Shift";
            this.coldsAdditonL3DataTableShift.Namespace = "";
            // 
            // coldsAdditonL3DataTableTeam
            // 
            this.coldsAdditonL3DataTableTeam.Caption = "Team";
            this.coldsAdditonL3DataTableTeam.ColumnName = "Team";
            this.coldsAdditonL3DataTableTeam.Namespace = "";
            // 
            // coldsAdditonL3DataTableOperator
            // 
            this.coldsAdditonL3DataTableOperator.Caption = "Operator";
            this.coldsAdditonL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdditonL3DataTableOperator.Namespace = "";
            // 
            // coldsAdditonL3DataTableTime_Begin_Discharge
            // 
            this.coldsAdditonL3DataTableTime_Begin_Discharge.Caption = "Time_Begin_Discharge";
            this.coldsAdditonL3DataTableTime_Begin_Discharge.ColumnName = "Time_Begin_Discharge";
            this.coldsAdditonL3DataTableTime_Begin_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditonL3DataTableTime_Begin_Discharge.Namespace = "";
            // 
            // coldsAdditonL3DataTableTime_Stop_Discharge
            // 
            this.coldsAdditonL3DataTableTime_Stop_Discharge.Caption = "Time_Stop_Discharge";
            this.coldsAdditonL3DataTableTime_Stop_Discharge.ColumnName = "Time_Stop_Discharge";
            this.coldsAdditonL3DataTableTime_Stop_Discharge.DataType = typeof(System.DateTime);
            this.coldsAdditonL3DataTableTime_Stop_Discharge.Namespace = "";
            // 
            // dsMatVendor
            // 
            this.dsMatVendor.AutoLoad = true;
            this.dsMatVendor.AutoSubscribe = false;
            this.dsMatVendor.DataSetName = "L3DataSet";
            this.dsMatVendor.DeleteMethod = "";
            this.dsMatVendor.InsertMethod = "";
            this.dsMatVendor.L3DataAdapter = this.Adapter;
            this.dsMatVendor.LoadEvent = "";
            this.dsMatVendor.LoadTrigger = null;
            this.dsMatVendor.RefreshValve = 1000;
            this.dsMatVendor.SourceCommand = null;
            this.dsMatVendor.SourceCondition = "code_group = \'DeS_Mat_Vendor\'";
            this.dsMatVendor.SourceMethod = "";
            this.dsMatVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatVendor.SubscribeTarget = "";
            this.dsMatVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatVendor});
            this.dsMatVendor.UpdateEvent = "";
            this.dsMatVendor.UpdateMethod = "";
            this.dsMatVendor.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMatVendor
            // 
            this.schemadsMatVendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatVendorL3DataTablecode,
            this.coldsMatVendorL3DataTablecode_des});
            this.schemadsMatVendor.TableName = "L3DataTable";
            // 
            // coldsMatVendorL3DataTablecode
            // 
            this.coldsMatVendorL3DataTablecode.Caption = "code";
            this.coldsMatVendorL3DataTablecode.ColumnName = "code";
            this.coldsMatVendorL3DataTablecode.Namespace = "";
            // 
            // coldsMatVendorL3DataTablecode_des
            // 
            this.coldsMatVendorL3DataTablecode_des.Caption = "code_des";
            this.coldsMatVendorL3DataTablecode_des.ColumnName = "code_des";
            this.coldsMatVendorL3DataTablecode_des.Namespace = "";
            // 
            // dtpStop
            // 
            this.dtpStop.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dtpStop.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsAddition, "Time_Stop_Discharge", true));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStop.Location = new System.Drawing.Point(383, 125);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(121, 21);
            this.dtpStop.TabIndex = 3;
            // 
            // dtpBegin
            // 
            this.dtpBegin.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dtpBegin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsAddition, "Time_Begin_Discharge", true));
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBegin.Location = new System.Drawing.Point(383, 84);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(121, 21);
            this.dtpBegin.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAddition, "Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"));
            this.txtWeight.EnableNull = false;
            this.txtWeight.ErropPr = this.errorProvider1;
            this.txtWeight.Length = 0;
            this.txtWeight.Location = new System.Drawing.Point(383, 43);
            this.txtWeight.Max = 9999;
            this.txtWeight.MaxStrLength = 0;
            this.txtWeight.Min = 0;
            this.txtWeight.MinStrLength = 0;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Precision = 0;
            this.txtWeight.Size = new System.Drawing.Size(121, 21);
            this.txtWeight.TabIndex = 2;
            this.txtWeight.ToolTipValid = this.toolTip1;
            this.txtWeight.ValidEable = true;
            this.txtWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbMatCode
            // 
            this.cmbMatCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAddition, "Mat_Code", true));
            this.cmbMatCode.DataSource = this.dsMatCode;
            this.cmbMatCode.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMatCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatCode.FormattingEnabled = true;
            this.cmbMatCode.Location = new System.Drawing.Point(129, 85);
            this.cmbMatCode.Name = "cmbMatCode";
            this.cmbMatCode.Size = new System.Drawing.Size(121, 20);
            this.cmbMatCode.TabIndex = 1;
            this.cmbMatCode.ValueMember = "L3DataTable.Code";
            // 
            // dsMatCode
            // 
            this.dsMatCode.AutoLoad = true;
            this.dsMatCode.AutoSubscribe = false;
            this.dsMatCode.DataSetName = "L3DataSet";
            this.dsMatCode.DeleteMethod = "";
            this.dsMatCode.InsertMethod = "";
            this.dsMatCode.L3DataAdapter = this.Adapter;
            this.dsMatCode.LoadEvent = "";
            this.dsMatCode.LoadTrigger = null;
            this.dsMatCode.RefreshValve = 1000;
            this.dsMatCode.SourceCommand = null;
            this.dsMatCode.SourceCondition = "code_group = \'DeS_Mat_Code\'";
            this.dsMatCode.SourceMethod = "";
            this.dsMatCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatCode.SubscribeTarget = "";
            this.dsMatCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsMatCode.UpdateEvent = "";
            this.dsMatCode.UpdateMethod = "";
            this.dsMatCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTablecode,
            this.coldsMatCodeL3DataTablecode_des});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTablecode
            // 
            this.coldsMatCodeL3DataTablecode.Caption = "code";
            this.coldsMatCodeL3DataTablecode.ColumnName = "code";
            this.coldsMatCodeL3DataTablecode.Namespace = "";
            // 
            // coldsMatCodeL3DataTablecode_des
            // 
            this.coldsMatCodeL3DataTablecode_des.Caption = "code_des";
            this.coldsMatCodeL3DataTablecode_des.ColumnName = "code_des";
            this.coldsMatCodeL3DataTablecode_des.Namespace = "";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAddition, "UnitID", true));
            this.cmbUnitID.DataSource = this.dsDeSUnitID;
            this.cmbUnitID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(129, 44);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(121, 20);
            this.cmbUnitID.TabIndex = 1;
            this.cmbUnitID.ValueMember = "L3DataTable.Code";
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // dsDeSUnitID
            // 
            this.dsDeSUnitID.AutoLoad = true;
            this.dsDeSUnitID.AutoSubscribe = false;
            this.dsDeSUnitID.DataSetName = "L3DataSet";
            this.dsDeSUnitID.DeleteMethod = "";
            this.dsDeSUnitID.InsertMethod = "";
            this.dsDeSUnitID.L3DataAdapter = this.Adapter;
            this.dsDeSUnitID.LoadEvent = "";
            this.dsDeSUnitID.LoadTrigger = null;
            this.dsDeSUnitID.RefreshValve = 1000;
            this.dsDeSUnitID.SourceCommand = null;
            this.dsDeSUnitID.SourceCondition = "code_group = \'DeS\' and (code = \'S02\' or code = \'S03\')";
            this.dsDeSUnitID.SourceMethod = "";
            this.dsDeSUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDeSUnitID.SubscribeTarget = "";
            this.dsDeSUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDeSUnitID});
            this.dsDeSUnitID.UpdateEvent = "";
            this.dsDeSUnitID.UpdateMethod = "";
            this.dsDeSUnitID.UpdateTrigger = null;
            // 
            // schemadsDeSUnitID
            // 
            this.schemadsDeSUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDeSUnitIDL3DataTableCode,
            this.coldsDeSUnitIDL3DataTableCode_Des});
            this.schemadsDeSUnitID.TableName = "L3DataTable";
            // 
            // coldsDeSUnitIDL3DataTableCode
            // 
            this.coldsDeSUnitIDL3DataTableCode.Caption = "Code";
            this.coldsDeSUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsDeSUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsDeSUnitIDL3DataTableCode_Des
            // 
            this.coldsDeSUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDeSUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDeSUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "脱硫剂代码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "脱硫剂厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "加料结束时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "加料开始时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "加料量[Kg]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "脱硫工位:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(470, 222);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(378, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // l3txtMatVendor1
            // 
            this.l3txtMatVendor1.DataFormat = null;
            this.l3txtMatVendor1.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.l3txtMatVendor1.DataProperty = "Mat_Vendor";
            this.l3txtMatVendor1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtMatVendor1.L3DataAdapter = this.Adapter;
            this.l3txtMatVendor1.Location = new System.Drawing.Point(46, 224);
            this.l3txtMatVendor1.Name = "l3txtMatVendor1";
            this.l3txtMatVendor1.Size = new System.Drawing.Size(21, 21);
            this.l3txtMatVendor1.TabIndex = 83;
            this.l3txtMatVendor1.Value = null;
            this.l3txtMatVendor1.Visible = false;
            // 
            // l3txtMatCode1
            // 
            this.l3txtMatCode1.DataFormat = null;
            this.l3txtMatCode1.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.l3txtMatCode1.DataProperty = "Mat_Code";
            this.l3txtMatCode1.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtMatCode1.L3DataAdapter = this.Adapter;
            this.l3txtMatCode1.Location = new System.Drawing.Point(19, 224);
            this.l3txtMatCode1.Name = "l3txtMatCode1";
            this.l3txtMatCode1.Size = new System.Drawing.Size(21, 21);
            this.l3txtMatCode1.TabIndex = 84;
            this.l3txtMatCode1.Value = null;
            this.l3txtMatCode1.Visible = false;
            // 
            // cmdNewDeSAdditionData
            // 
            this.cmdNewDeSAdditionData.Adapter = this.Adapter;
            this.cmdNewDeSAdditionData.MergeReturnTarget = false;
            this.cmdNewDeSAdditionData.Method = "NewDeSAdditionData";
            this.cmdNewDeSAdditionData.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\{name}";
            this.cmdNewDeSAdditionData.Parameters.Add(this.l3CommandParameter1);
            this.cmdNewDeSAdditionData.ReturnTarget = null;
            this.cmdNewDeSAdditionData.ReturnTargetProperty = null;
            this.cmdNewDeSAdditionData.Trigger = null;
            this.cmdNewDeSAdditionData.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsAdditon;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3txtMatCode2
            // 
            this.l3txtMatCode2.DataFormat = null;
            this.l3txtMatCode2.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.l3txtMatCode2.DataProperty = "Mat_Code";
            this.l3txtMatCode2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtMatCode2.L3DataAdapter = this.Adapter;
            this.l3txtMatCode2.Location = new System.Drawing.Point(77, 224);
            this.l3txtMatCode2.Name = "l3txtMatCode2";
            this.l3txtMatCode2.Size = new System.Drawing.Size(21, 21);
            this.l3txtMatCode2.TabIndex = 84;
            this.l3txtMatCode2.Value = null;
            this.l3txtMatCode2.Visible = false;
            // 
            // l3txtMatVendor2
            // 
            this.l3txtMatVendor2.DataFormat = null;
            this.l3txtMatVendor2.DataObject = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.l3txtMatVendor2.DataProperty = "Mat_Vendor";
            this.l3txtMatVendor2.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3txtMatVendor2.L3DataAdapter = this.Adapter;
            this.l3txtMatVendor2.Location = new System.Drawing.Point(104, 224);
            this.l3txtMatVendor2.Name = "l3txtMatVendor2";
            this.l3txtMatVendor2.Size = new System.Drawing.Size(21, 21);
            this.l3txtMatVendor2.TabIndex = 83;
            this.l3txtMatVendor2.Value = null;
            this.l3txtMatVendor2.Visible = false;
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
            this.dsError.SourceCondition = "OWNER = \'NewDeSAdditionData\'";
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
            // AdditionShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.l3txtMatVendor2);
            this.Controls.Add(this.l3txtMatVendor1);
            this.Controls.Add(this.l3txtMatCode2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.l3txtMatCode1);
            this.Controls.Add(this.tcMain);
            this.Name = "AdditionShowFrm";
            this.Text = "新增加料信息";
            this.Load += new System.EventHandler(this.AdditionShowFrm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpAdditon.ResumeLayout(false);
            this.tpAdditon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAdditon;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ComboBox cmbUnitID;
        private PxDataValid.PxTextBox txtWeight;
        private AppSvrHMI.L3DataSet dsDeSUnitID;
        private System.Data.DataTable schemadsDeSUnitID;
        private System.Data.DataColumn coldsDeSUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsDeSUnitIDL3DataTableCode_Des;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource bsAddition;
        private AppSvrHMI.L3DataSet dsAdditon;
        private System.Data.DataTable schemadsAdditon;
        private System.Data.DataColumn coldsAdditonL3DataTableUnitID;
        private System.Data.DataColumn coldsAdditonL3DataTableWeight;
        private AppSvrHMI.L3DataBox l3txtMatVendor1;
        private AppSvrHMI.L3DataBox l3txtMatCode1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMatCode;
        private AppSvrHMI.L3Command cmdNewDeSAdditionData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsMatCode;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTablecode;
        private System.Data.DataColumn coldsMatCodeL3DataTablecode_des;
        private System.Data.DataColumn coldsAdditonL3DataTableGUID;
        private System.Data.DataColumn coldsAdditonL3DataTableName;
        private System.Data.DataColumn coldsAdditonL3DataTableMat_Code;
        private System.Data.DataColumn coldsAdditonL3DataTableMat_Vendor;
        private System.Data.DataColumn coldsAdditonL3DataTableTime_Discharge;
        private System.Data.DataColumn coldsAdditonL3DataTableShift;
        private System.Data.DataColumn coldsAdditonL3DataTableTeam;
        private System.Data.DataColumn coldsAdditonL3DataTableOperator;
        private System.Data.DataColumn coldsAdditonL3DataTableTime_Begin_Discharge;
        private System.Data.DataColumn coldsAdditonL3DataTableTime_Stop_Discharge;
        private AppSvrHMI.L3DataBox l3txtMatVendor2;
        private AppSvrHMI.L3DataBox l3txtMatCode2;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox cmbMatVendor;
        private AppSvrHMI.L3DataSet dsMatVendor;
        private System.Data.DataTable schemadsMatVendor;
        private System.Data.DataColumn coldsMatVendorL3DataTablecode;
        private System.Data.DataColumn coldsMatVendorL3DataTablecode_des;
    }
}