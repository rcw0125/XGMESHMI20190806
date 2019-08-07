namespace QualityMag.LabMag
{
    partial class AdviceInfoFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbCasterID = new PxDataValid.PxComboBox();
            this.bsAdvice = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdvice = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsAdvice = new System.Data.DataTable();
            this.coldsAdviceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableName = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableCut_Count = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableCut_Position = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableCut_Dimen = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableCut_Mark = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableLog_Time = new System.Data.DataColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbCutSize = new PxDataValid.PxComboBox();
            this.dsCutSize = new AppSvrHMI.L3DataSet();
            this.schemadsCutSize = new System.Data.DataTable();
            this.coldsCutSizeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCutSizeL3DataTableCode_Des = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCutPosition = new PxDataValid.PxComboBox();
            this.dsCutPosition = new AppSvrHMI.L3DataSet();
            this.schemadsCutPosition = new System.Data.DataTable();
            this.coldsCutPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsCutPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCutCount = new PxDataValid.PxTextBox();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dsGrade = new AppSvrHMI.L3DataSet();
            this.cmdGrade = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsGrade = new System.Data.DataTable();
            this.coldsGradeL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsAdviceL3DataTableCasterID = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 45);
            this.panel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(335, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(254, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 201);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbCasterID);
            this.tabPage1.Controls.Add(this.cmbCutSize);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbCutPosition);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCutCount);
            this.tabPage1.Controls.Add(this.txtHeatID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "通知信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCasterID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCasterID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdvice, "CasterID", true));
            this.cmbCasterID.DataSource = this.dsCasterID;
            this.cmbCasterID.DisplayMember = "L3DataTable.Code";
            this.cmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterID.EnableNull = false;
            this.cmbCasterID.ErropPr = this.errorProvider1;
            this.cmbCasterID.FormattingEnabled = true;
            this.cmbCasterID.Location = new System.Drawing.Point(139, 51);
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(195, 20);
            this.cmbCasterID.TabIndex = 10;
            this.cmbCasterID.ToolTipValid = this.toolTip1;
            this.cmbCasterID.ValidEable = true;
            this.cmbCasterID.ValueMember = "L3DataTable.Code";
            // 
            // bsAdvice
            // 
            this.bsAdvice.DataMember = "L3DataTable";
            this.bsAdvice.DataSource = this.dsAdvice;
            // 
            // dsAdvice
            // 
            this.dsAdvice.DataSetName = "L3DataSet";
            this.dsAdvice.DeleteMethod = null;
            this.dsAdvice.InsertMethod = null;
            this.dsAdvice.L3DataAdapter = this.Adapter;
            this.dsAdvice.LoadEvent = "Click";
            this.dsAdvice.LoadTrigger = null;
            this.dsAdvice.RefreshValve = 1000;
            this.dsAdvice.SourceCommand = null;
            this.dsAdvice.SourceCondition = "";
            this.dsAdvice.SourceMethod = "";
            this.dsAdvice.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsAdvice.SourceURI = "";
            this.dsAdvice.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdvice});
            this.dsAdvice.UpdateEvent = "Click";
            this.dsAdvice.UpdateMethod = null;
            this.dsAdvice.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsAdvice
            // 
            this.schemadsAdvice.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdviceL3DataTableGUID,
            this.coldsAdviceL3DataTableName,
            this.coldsAdviceL3DataTableHeatID,
            this.coldsAdviceL3DataTableSteelGrade,
            this.coldsAdviceL3DataTableCut_Count,
            this.coldsAdviceL3DataTableCut_Position,
            this.coldsAdviceL3DataTableCut_Dimen,
            this.coldsAdviceL3DataTableCut_Mark,
            this.coldsAdviceL3DataTableLog_Time});
            this.schemadsAdvice.TableName = "L3DataTable";
            // 
            // coldsAdviceL3DataTableGUID
            // 
            this.coldsAdviceL3DataTableGUID.Caption = "GUID";
            this.coldsAdviceL3DataTableGUID.ColumnName = "GUID";
            this.coldsAdviceL3DataTableGUID.Namespace = "";
            // 
            // coldsAdviceL3DataTableName
            // 
            this.coldsAdviceL3DataTableName.Caption = "Name";
            this.coldsAdviceL3DataTableName.ColumnName = "Name";
            this.coldsAdviceL3DataTableName.Namespace = "";
            // 
            // coldsAdviceL3DataTableHeatID
            // 
            this.coldsAdviceL3DataTableHeatID.Caption = "HeatID";
            this.coldsAdviceL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsAdviceL3DataTableHeatID.Namespace = "";
            // 
            // coldsAdviceL3DataTableSteelGrade
            // 
            this.coldsAdviceL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsAdviceL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsAdviceL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsAdviceL3DataTableCut_Count
            // 
            this.coldsAdviceL3DataTableCut_Count.Caption = "Cut_Count";
            this.coldsAdviceL3DataTableCut_Count.ColumnName = "Cut_Count";
            this.coldsAdviceL3DataTableCut_Count.DataType = typeof(int);
            this.coldsAdviceL3DataTableCut_Count.Namespace = "";
            // 
            // coldsAdviceL3DataTableCut_Position
            // 
            this.coldsAdviceL3DataTableCut_Position.Caption = "Cut_Position";
            this.coldsAdviceL3DataTableCut_Position.ColumnName = "Cut_Position";
            this.coldsAdviceL3DataTableCut_Position.Namespace = "";
            // 
            // coldsAdviceL3DataTableCut_Dimen
            // 
            this.coldsAdviceL3DataTableCut_Dimen.Caption = "Cut_Dimen";
            this.coldsAdviceL3DataTableCut_Dimen.ColumnName = "Cut_Dimen";
            this.coldsAdviceL3DataTableCut_Dimen.Namespace = "";
            // 
            // coldsAdviceL3DataTableCut_Mark
            // 
            this.coldsAdviceL3DataTableCut_Mark.Caption = "Cut_Mark";
            this.coldsAdviceL3DataTableCut_Mark.ColumnName = "Cut_Mark";
            this.coldsAdviceL3DataTableCut_Mark.Namespace = "";
            // 
            // coldsAdviceL3DataTableLog_Time
            // 
            this.coldsAdviceL3DataTableLog_Time.Caption = "Log_Time";
            this.coldsAdviceL3DataTableLog_Time.ColumnName = "Log_Time";
            this.coldsAdviceL3DataTableLog_Time.DataType = typeof(System.DateTime);
            this.coldsAdviceL3DataTableLog_Time.Namespace = "";
            // 
            // dsCasterID
            // 
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\'";
            this.dsCasterID.SourceMethod = "";
            this.dsCasterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterID.SubscribeTarget = null;
            this.dsCasterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterID});
            this.dsCasterID.UpdateEvent = "Click";
            this.dsCasterID.UpdateMethod = null;
            this.dsCasterID.UpdateTrigger = null;
            // 
            // schemadsCasterID
            // 
            this.schemadsCasterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterIDL3DataTableCode,
            this.coldsCasterIDL3DataTableCode_Des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_Des
            // 
            this.coldsCasterIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCutSize
            // 
            this.cmbCutSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCutSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCutSize.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdvice, "Cut_Dimen", true));
            this.cmbCutSize.DataSource = this.dsCutSize;
            this.cmbCutSize.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCutSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCutSize.EnableNull = false;
            this.cmbCutSize.ErropPr = this.errorProvider1;
            this.cmbCutSize.FormattingEnabled = true;
            this.cmbCutSize.Location = new System.Drawing.Point(139, 130);
            this.cmbCutSize.Name = "cmbCutSize";
            this.cmbCutSize.Size = new System.Drawing.Size(195, 20);
            this.cmbCutSize.TabIndex = 10;
            this.cmbCutSize.ToolTipValid = this.toolTip1;
            this.cmbCutSize.ValidEable = true;
            this.cmbCutSize.ValueMember = "L3DataTable.Code";
            // 
            // dsCutSize
            // 
            this.dsCutSize.DataSetName = "L3DataSet";
            this.dsCutSize.DeleteMethod = null;
            this.dsCutSize.InsertMethod = null;
            this.dsCutSize.L3DataAdapter = this.Adapter;
            this.dsCutSize.LoadEvent = "Click";
            this.dsCutSize.LoadTrigger = null;
            this.dsCutSize.RefreshValve = 1000;
            this.dsCutSize.SourceCommand = null;
            this.dsCutSize.SourceCondition = "Code_Group = \'CutAdvice_Size\'";
            this.dsCutSize.SourceMethod = "";
            this.dsCutSize.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCutSize.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCutSize.SubscribeTarget = null;
            this.dsCutSize.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCutSize});
            this.dsCutSize.UpdateEvent = "Click";
            this.dsCutSize.UpdateMethod = null;
            this.dsCutSize.UpdateTrigger = null;
            // 
            // schemadsCutSize
            // 
            this.schemadsCutSize.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCutSizeL3DataTableCode,
            this.coldsCutSizeL3DataTableCode_Des});
            this.schemadsCutSize.TableName = "L3DataTable";
            // 
            // coldsCutSizeL3DataTableCode
            // 
            this.coldsCutSizeL3DataTableCode.Caption = "Code";
            this.coldsCutSizeL3DataTableCode.ColumnName = "Code";
            this.coldsCutSizeL3DataTableCode.Namespace = "";
            // 
            // coldsCutSizeL3DataTableCode_Des
            // 
            this.coldsCutSizeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCutSizeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCutSizeL3DataTableCode_Des.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "铸机:";
            // 
            // cmbCutPosition
            // 
            this.cmbCutPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCutPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCutPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdvice, "Cut_Position", true));
            this.cmbCutPosition.DataSource = this.dsCutPosition;
            this.cmbCutPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCutPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCutPosition.EnableNull = false;
            this.cmbCutPosition.ErropPr = this.errorProvider1;
            this.cmbCutPosition.FormattingEnabled = true;
            this.cmbCutPosition.Location = new System.Drawing.Point(139, 104);
            this.cmbCutPosition.Name = "cmbCutPosition";
            this.cmbCutPosition.Size = new System.Drawing.Size(195, 20);
            this.cmbCutPosition.TabIndex = 10;
            this.cmbCutPosition.ToolTipValid = this.toolTip1;
            this.cmbCutPosition.ValidEable = true;
            this.cmbCutPosition.ValueMember = "L3DataTable.Code";
            // 
            // dsCutPosition
            // 
            this.dsCutPosition.DataSetName = "L3DataSet";
            this.dsCutPosition.DeleteMethod = null;
            this.dsCutPosition.InsertMethod = null;
            this.dsCutPosition.L3DataAdapter = this.Adapter;
            this.dsCutPosition.LoadEvent = "Click";
            this.dsCutPosition.LoadTrigger = null;
            this.dsCutPosition.RefreshValve = 1000;
            this.dsCutPosition.SourceCommand = null;
            this.dsCutPosition.SourceCondition = "Code_Group = \'CutAdvice_Position\'";
            this.dsCutPosition.SourceMethod = "";
            this.dsCutPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCutPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCutPosition.SubscribeTarget = null;
            this.dsCutPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCutPosition});
            this.dsCutPosition.UpdateEvent = "Click";
            this.dsCutPosition.UpdateMethod = null;
            this.dsCutPosition.UpdateTrigger = null;
            // 
            // schemadsCutPosition
            // 
            this.schemadsCutPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCutPositionL3DataTableCode,
            this.coldsCutPositionL3DataTableCode_Des});
            this.schemadsCutPosition.TableName = "L3DataTable";
            // 
            // coldsCutPositionL3DataTableCode
            // 
            this.coldsCutPositionL3DataTableCode.Caption = "Code";
            this.coldsCutPositionL3DataTableCode.ColumnName = "Code";
            this.coldsCutPositionL3DataTableCode.Namespace = "";
            // 
            // coldsCutPositionL3DataTableCode_Des
            // 
            this.coldsCutPositionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCutPositionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCutPositionL3DataTableCode_Des.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "取样尺寸:";
            // 
            // txtCutCount
            // 
            this.txtCutCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdvice, "Cut_Count", true));
            this.txtCutCount.EnableNull = true;
            this.txtCutCount.ErropPr = this.errorProvider1;
            this.txtCutCount.Length = 0;
            this.txtCutCount.Location = new System.Drawing.Point(139, 77);
            this.txtCutCount.Max = 0;
            this.txtCutCount.MaxStrLength = 0;
            this.txtCutCount.Min = 0;
            this.txtCutCount.MinStrLength = 0;
            this.txtCutCount.Name = "txtCutCount";
            this.txtCutCount.Precision = 0;
            this.txtCutCount.Size = new System.Drawing.Size(195, 21);
            this.txtCutCount.TabIndex = 2;
            this.txtCutCount.ToolTipValid = this.toolTip1;
            this.txtCutCount.ValidEable = true;
            this.txtCutCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdvice, "HeatID", true));
            this.txtHeatID.EnableNull = true;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 9;
            this.txtHeatID.Location = new System.Drawing.Point(139, 24);
            this.txtHeatID.Max = 0;
            this.txtHeatID.MaxStrLength = 0;
            this.txtHeatID.Min = 0;
            this.txtHeatID.MinStrLength = 0;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Precision = 0;
            this.txtHeatID.Size = new System.Drawing.Size(195, 21);
            this.txtHeatID.TabIndex = 0;
            this.txtHeatID.ToolTipValid = this.toolTip1;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "炉号:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(74, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 8;
            this.label22.Text = "取样位置:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(74, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "取样数量:";
            // 
            // dsGrade
            // 
            this.dsGrade.DataSetName = "L3DataSet";
            this.dsGrade.DeleteMethod = "";
            this.dsGrade.InsertMethod = "";
            this.dsGrade.L3DataAdapter = this.Adapter;
            this.dsGrade.LoadEvent = "Click";
            this.dsGrade.LoadTrigger = null;
            this.dsGrade.RefreshValve = 1000;
            this.dsGrade.SourceCommand = this.cmdGrade;
            this.dsGrade.SourceCondition = null;
            this.dsGrade.SourceMethod = "GetGradeByHeatID";
            this.dsGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.dsGrade.SubscribeTarget = null;
            this.dsGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGrade});
            this.dsGrade.UpdateEvent = "Click";
            this.dsGrade.UpdateMethod = "";
            this.dsGrade.UpdateTrigger = null;
            // 
            // cmdGrade
            // 
            this.cmdGrade.Adapter = null;
            this.cmdGrade.MergeReturnTarget = false;
            this.cmdGrade.Method = null;
            this.cmdGrade.Object = null;
            this.cmdGrade.Parameters.Add(this.l3CommandParameter1);
            this.cmdGrade.ReturnTarget = null;
            this.cmdGrade.ReturnTargetProperty = null;
            this.cmdGrade.Trigger = null;
            this.cmdGrade.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // schemadsGrade
            // 
            this.schemadsGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGradeL3DataTableSTEELGRADE});
            this.schemadsGrade.TableName = "L3DataTable";
            // 
            // coldsGradeL3DataTableSTEELGRADE
            // 
            this.coldsGradeL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsGradeL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsGradeL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsGradeL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsAdviceL3DataTableCasterID
            // 
            this.coldsAdviceL3DataTableCasterID.Caption = "CasterID";
            this.coldsAdviceL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsAdviceL3DataTableCasterID.Namespace = "";
            // 
            // AdviceInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 246);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdviceInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "制定割样通知";
            this.Load += new System.EventHandler(this.AdviceInfoFrm_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtCutCount;
        private PxDataValid.PxTextBox txtHeatID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsGrade;
        private AppSvrHMI.L3Command cmdGrade;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsGrade;
        private System.Data.DataColumn coldsGradeL3DataTableSTEELGRADE;
        private AppSvrHMI.L3DataSet dsAdvice;
        private System.Windows.Forms.BindingSource bsAdvice;
        private System.Data.DataTable schemadsAdvice;
        private System.Data.DataColumn coldsAdviceL3DataTableGUID;
        private System.Data.DataColumn coldsAdviceL3DataTableName;
        private System.Data.DataColumn coldsAdviceL3DataTableHeatID;
        private System.Data.DataColumn coldsAdviceL3DataTableSteelGrade;
        private System.Data.DataColumn coldsAdviceL3DataTableCut_Count;
        private System.Data.DataColumn coldsAdviceL3DataTableCut_Position;
        private System.Data.DataColumn coldsAdviceL3DataTableCut_Dimen;
        private System.Data.DataColumn coldsAdviceL3DataTableCut_Mark;
        private System.Data.DataColumn coldsAdviceL3DataTableLog_Time;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private AppSvrHMI.L3DataSet dsCutSize;
        private AppSvrHMI.L3DataSet dsCutPosition;
        private System.Data.DataTable schemadsCutPosition;
        private System.Data.DataColumn coldsCutPositionL3DataTableCode;
        private System.Data.DataColumn coldsCutPositionL3DataTableCode_Des;
        private System.Data.DataTable schemadsCutSize;
        private System.Data.DataColumn coldsCutSizeL3DataTableCode;
        private System.Data.DataColumn coldsCutSizeL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbCutPosition;
        private PxDataValid.PxComboBox cmbCutSize;
        private PxDataValid.PxComboBox cmbCasterID;
        private System.Windows.Forms.Label label4;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdviceL3DataTableCasterID;
    }
}