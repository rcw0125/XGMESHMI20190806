namespace UnitMag.DeSMag
{
    partial class ChangeNoteMag
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
            this.lbMaterialID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dsNote = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStatus = new System.Data.DataTable();
            this.txtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbReason = new System.Windows.Forms.Label();
            this.cmdSetStatus1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.cmdSetStatus2 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.coldsStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableName = new System.Data.DataColumn();
            this.coldsStatusL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsStatusL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDeS_UnitID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableRemoveSlag_UnitID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDeS_Operator = new System.Data.DataColumn();
            this.coldsStatusL3DataTableRemoveSlag_Operator = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDeS_Flag = new System.Data.DataColumn();
            this.coldsStatusL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsStatusL3DataTablePreRemoveSlagTime = new System.Data.DataColumn();
            this.coldsStatusL3DataTableRemoveSlagTime = new System.Data.DataColumn();
            this.coldsStatusL3DataTableBlowTimeTotal = new System.Data.DataColumn();
            this.coldsStatusL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsStatusL3DataTableRemoveSlagCount = new System.Data.DataColumn();
            this.coldsStatusL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsStatusL3DataTableEstimate_Weight = new System.Data.DataColumn();
            this.coldsStatusL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDeSType = new System.Data.DataColumn();
            this.coldsStatusL3DataTableMat_Consume = new System.Data.DataColumn();
            this.coldsStatusL3DataTableWeight_MatTank = new System.Data.DataColumn();
            this.coldsStatusL3DataTableWeight_SprayTank = new System.Data.DataColumn();
            this.coldsStatusL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatusL3DataTableDestination = new System.Data.DataColumn();
            this.coldsStatusL3DataTableShift = new System.Data.DataColumn();
            this.coldsStatusL3DataTableTeam = new System.Data.DataColumn();
            this.coldsStatusL3DataTableNote = new System.Data.DataColumn();
            this.coldsStatusL3DataTableLocked = new System.Data.DataColumn();
            this.coldsStatusL3DataTableSampleApplyCount_B = new System.Data.DataColumn();
            this.coldsStatusL3DataTableSampleApplyCount_A = new System.Data.DataColumn();
            this.coldsStatusL3DataTableMediator = new System.Data.DataColumn();
            this.coldsStatusL3DataTableTotalTime = new System.Data.DataColumn();
            this.bsNote = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbMaterialID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 29);
            this.panel3.TabIndex = 77;
            // 
            // lbMaterialID
            // 
            this.lbMaterialID.AutoSize = true;
            this.lbMaterialID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMaterialID.ForeColor = System.Drawing.SystemColors.Window;
            this.lbMaterialID.Location = new System.Drawing.Point(85, 9);
            this.lbMaterialID.Name = "lbMaterialID";
            this.lbMaterialID.Size = new System.Drawing.Size(68, 12);
            this.lbMaterialID.TabIndex = 73;
            this.lbMaterialID.Text = "XXXXXXXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "物料编号:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 263);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(442, 37);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(364, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(283, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 78;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 234);
            this.tabControl1.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtNote);
            this.tabPage1.Controls.Add(this.lbReason);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "备注信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dsNote
            // 
            this.dsNote.AutoLoad = true;
            this.dsNote.AutoSubscribe = false;
            this.dsNote.DataSetName = "L3DataSet";
            this.dsNote.DeleteMethod = "";
            this.dsNote.InsertMethod = "";
            this.dsNote.L3DataAdapter = this.Adapter;
            this.dsNote.LoadEvent = "";
            this.dsNote.LoadTrigger = null;
            this.dsNote.RefreshValve = 1000;
            this.dsNote.SourceCommand = null;
            this.dsNote.SourceCondition = "code_group = \'DeSEquipmentStatus\'";
            this.dsNote.SourceMethod = "";
            this.dsNote.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNote.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Base_Data";
            this.dsNote.SubscribeTarget = "";
            this.dsNote.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsNote.UpdateEvent = "";
            this.dsNote.UpdateMethod = "";
            this.dsNote.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableGUID,
            this.coldsStatusL3DataTableName,
            this.coldsStatusL3DataTableMaterialID,
            this.coldsStatusL3DataTableTAP_No,
            this.coldsStatusL3DataTableTPC_No,
            this.coldsStatusL3DataTableDeS_UnitID,
            this.coldsStatusL3DataTableRemoveSlag_UnitID,
            this.coldsStatusL3DataTableDeS_Operator,
            this.coldsStatusL3DataTableRemoveSlag_Operator,
            this.coldsStatusL3DataTableDeS_Flag,
            this.coldsStatusL3DataTableProductionDate,
            this.coldsStatusL3DataTablePreRemoveSlagTime,
            this.coldsStatusL3DataTableRemoveSlagTime,
            this.coldsStatusL3DataTableBlowTimeTotal,
            this.coldsStatusL3DataTableProcessTime,
            this.coldsStatusL3DataTableRemoveSlagCount,
            this.coldsStatusL3DataTableGross_Weight,
            this.coldsStatusL3DataTableEstimate_Weight,
            this.coldsStatusL3DataTableNet_Weight,
            this.coldsStatusL3DataTableDeSType,
            this.coldsStatusL3DataTableMat_Consume,
            this.coldsStatusL3DataTableWeight_MatTank,
            this.coldsStatusL3DataTableWeight_SprayTank,
            this.coldsStatusL3DataTableStatus,
            this.coldsStatusL3DataTableDestination,
            this.coldsStatusL3DataTableShift,
            this.coldsStatusL3DataTableTeam,
            this.coldsStatusL3DataTableNote,
            this.coldsStatusL3DataTableLocked,
            this.coldsStatusL3DataTableSampleApplyCount_B,
            this.coldsStatusL3DataTableSampleApplyCount_A,
            this.coldsStatusL3DataTableMediator,
            this.coldsStatusL3DataTableTotalTime});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsNote, "Note", true));
            this.txtNote.EnableNull = false;
            this.txtNote.ErropPr = this.errorProvider1;
            this.txtNote.Location = new System.Drawing.Point(73, 34);
            this.txtNote.MaxStrLength = 500;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(323, 139);
            this.txtNote.TabIndex = 75;
            this.txtNote.Text = "";
            this.txtNote.ToolTipValid = this.toolTip1;
            this.txtNote.ValidEable = true;
            this.txtNote.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(37, 37);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(35, 12);
            this.lbReason.TabIndex = 74;
            this.lbReason.Text = "备注:";
            // 
            // cmdSetStatus1
            // 
            this.cmdSetStatus1.Adapter = this.Adapter;
            this.cmdSetStatus1.MergeReturnTarget = false;
            this.cmdSetStatus1.Method = "NewDeSEquipmentStatusData";
            this.cmdSetStatus1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdSetStatus1.Parameters.Add(this.l3CommandParameter3);
            this.cmdSetStatus1.Parameters.Add(this.l3CommandParameter4);
            this.cmdSetStatus1.ReturnTarget = null;
            this.cmdSetStatus1.ReturnTargetProperty = null;
            this.cmdSetStatus1.Trigger = null;
            this.cmdSetStatus1.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
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
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // cmdSetStatus2
            // 
            this.cmdSetStatus2.Adapter = this.Adapter;
            this.cmdSetStatus2.MergeReturnTarget = false;
            this.cmdSetStatus2.Method = "NewDeSEquipmentStatusData";
            this.cmdSetStatus2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdSetStatus2.Parameters.Add(this.l3CommandParameter5);
            this.cmdSetStatus2.Parameters.Add(this.l3CommandParameter6);
            this.cmdSetStatus2.ReturnTarget = null;
            this.cmdSetStatus2.ReturnTargetProperty = null;
            this.cmdSetStatus2.Trigger = null;
            this.cmdSetStatus2.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = null;
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
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
            this.dsError.SourceCondition = "OWNER = \'NewDeSEquipmentStatusData\'";
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
            // coldsStatusL3DataTableGUID
            // 
            this.coldsStatusL3DataTableGUID.Caption = "GUID";
            this.coldsStatusL3DataTableGUID.ColumnName = "GUID";
            this.coldsStatusL3DataTableGUID.Namespace = "";
            // 
            // coldsStatusL3DataTableName
            // 
            this.coldsStatusL3DataTableName.Caption = "Name";
            this.coldsStatusL3DataTableName.ColumnName = "Name";
            this.coldsStatusL3DataTableName.Namespace = "";
            // 
            // coldsStatusL3DataTableMaterialID
            // 
            this.coldsStatusL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsStatusL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsStatusL3DataTableMaterialID.Namespace = "";
            // 
            // coldsStatusL3DataTableTAP_No
            // 
            this.coldsStatusL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsStatusL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsStatusL3DataTableTAP_No.Namespace = "";
            // 
            // coldsStatusL3DataTableTPC_No
            // 
            this.coldsStatusL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsStatusL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsStatusL3DataTableTPC_No.Namespace = "";
            // 
            // coldsStatusL3DataTableDeS_UnitID
            // 
            this.coldsStatusL3DataTableDeS_UnitID.Caption = "DeS_UnitID";
            this.coldsStatusL3DataTableDeS_UnitID.ColumnName = "DeS_UnitID";
            this.coldsStatusL3DataTableDeS_UnitID.Namespace = "";
            // 
            // coldsStatusL3DataTableRemoveSlag_UnitID
            // 
            this.coldsStatusL3DataTableRemoveSlag_UnitID.Caption = "RemoveSlag_UnitID";
            this.coldsStatusL3DataTableRemoveSlag_UnitID.ColumnName = "RemoveSlag_UnitID";
            this.coldsStatusL3DataTableRemoveSlag_UnitID.Namespace = "";
            // 
            // coldsStatusL3DataTableDeS_Operator
            // 
            this.coldsStatusL3DataTableDeS_Operator.Caption = "DeS_Operator";
            this.coldsStatusL3DataTableDeS_Operator.ColumnName = "DeS_Operator";
            this.coldsStatusL3DataTableDeS_Operator.Namespace = "";
            // 
            // coldsStatusL3DataTableRemoveSlag_Operator
            // 
            this.coldsStatusL3DataTableRemoveSlag_Operator.Caption = "RemoveSlag_Operator";
            this.coldsStatusL3DataTableRemoveSlag_Operator.ColumnName = "RemoveSlag_Operator";
            this.coldsStatusL3DataTableRemoveSlag_Operator.Namespace = "";
            // 
            // coldsStatusL3DataTableDeS_Flag
            // 
            this.coldsStatusL3DataTableDeS_Flag.Caption = "DeS_Flag";
            this.coldsStatusL3DataTableDeS_Flag.ColumnName = "DeS_Flag";
            this.coldsStatusL3DataTableDeS_Flag.DataType = typeof(int);
            this.coldsStatusL3DataTableDeS_Flag.Namespace = "";
            // 
            // coldsStatusL3DataTableProductionDate
            // 
            this.coldsStatusL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsStatusL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsStatusL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsStatusL3DataTableProductionDate.Namespace = "";
            // 
            // coldsStatusL3DataTablePreRemoveSlagTime
            // 
            this.coldsStatusL3DataTablePreRemoveSlagTime.Caption = "PreRemoveSlagTime";
            this.coldsStatusL3DataTablePreRemoveSlagTime.ColumnName = "PreRemoveSlagTime";
            this.coldsStatusL3DataTablePreRemoveSlagTime.DataType = typeof(int);
            this.coldsStatusL3DataTablePreRemoveSlagTime.Namespace = "";
            // 
            // coldsStatusL3DataTableRemoveSlagTime
            // 
            this.coldsStatusL3DataTableRemoveSlagTime.Caption = "RemoveSlagTime";
            this.coldsStatusL3DataTableRemoveSlagTime.ColumnName = "RemoveSlagTime";
            this.coldsStatusL3DataTableRemoveSlagTime.DataType = typeof(int);
            this.coldsStatusL3DataTableRemoveSlagTime.Namespace = "";
            // 
            // coldsStatusL3DataTableBlowTimeTotal
            // 
            this.coldsStatusL3DataTableBlowTimeTotal.Caption = "BlowTimeTotal";
            this.coldsStatusL3DataTableBlowTimeTotal.ColumnName = "BlowTimeTotal";
            this.coldsStatusL3DataTableBlowTimeTotal.DataType = typeof(int);
            this.coldsStatusL3DataTableBlowTimeTotal.Namespace = "";
            // 
            // coldsStatusL3DataTableProcessTime
            // 
            this.coldsStatusL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsStatusL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsStatusL3DataTableProcessTime.DataType = typeof(int);
            this.coldsStatusL3DataTableProcessTime.Namespace = "";
            // 
            // coldsStatusL3DataTableRemoveSlagCount
            // 
            this.coldsStatusL3DataTableRemoveSlagCount.Caption = "RemoveSlagCount";
            this.coldsStatusL3DataTableRemoveSlagCount.ColumnName = "RemoveSlagCount";
            this.coldsStatusL3DataTableRemoveSlagCount.DataType = typeof(int);
            this.coldsStatusL3DataTableRemoveSlagCount.Namespace = "";
            // 
            // coldsStatusL3DataTableGross_Weight
            // 
            this.coldsStatusL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsStatusL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsStatusL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsStatusL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsStatusL3DataTableEstimate_Weight
            // 
            this.coldsStatusL3DataTableEstimate_Weight.Caption = "Estimate_Weight";
            this.coldsStatusL3DataTableEstimate_Weight.ColumnName = "Estimate_Weight";
            this.coldsStatusL3DataTableEstimate_Weight.DataType = typeof(double);
            this.coldsStatusL3DataTableEstimate_Weight.Namespace = "";
            // 
            // coldsStatusL3DataTableNet_Weight
            // 
            this.coldsStatusL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsStatusL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsStatusL3DataTableNet_Weight.DataType = typeof(double);
            this.coldsStatusL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsStatusL3DataTableDeSType
            // 
            this.coldsStatusL3DataTableDeSType.Caption = "DeSType";
            this.coldsStatusL3DataTableDeSType.ColumnName = "DeSType";
            this.coldsStatusL3DataTableDeSType.DataType = typeof(bool);
            this.coldsStatusL3DataTableDeSType.Namespace = "";
            // 
            // coldsStatusL3DataTableMat_Consume
            // 
            this.coldsStatusL3DataTableMat_Consume.Caption = "Mat_Consume";
            this.coldsStatusL3DataTableMat_Consume.ColumnName = "Mat_Consume";
            this.coldsStatusL3DataTableMat_Consume.DataType = typeof(double);
            this.coldsStatusL3DataTableMat_Consume.Namespace = "";
            // 
            // coldsStatusL3DataTableWeight_MatTank
            // 
            this.coldsStatusL3DataTableWeight_MatTank.Caption = "Weight_MatTank";
            this.coldsStatusL3DataTableWeight_MatTank.ColumnName = "Weight_MatTank";
            this.coldsStatusL3DataTableWeight_MatTank.DataType = typeof(double);
            this.coldsStatusL3DataTableWeight_MatTank.Namespace = "";
            // 
            // coldsStatusL3DataTableWeight_SprayTank
            // 
            this.coldsStatusL3DataTableWeight_SprayTank.Caption = "Weight_SprayTank";
            this.coldsStatusL3DataTableWeight_SprayTank.ColumnName = "Weight_SprayTank";
            this.coldsStatusL3DataTableWeight_SprayTank.DataType = typeof(double);
            this.coldsStatusL3DataTableWeight_SprayTank.Namespace = "";
            // 
            // coldsStatusL3DataTableStatus
            // 
            this.coldsStatusL3DataTableStatus.Caption = "Status";
            this.coldsStatusL3DataTableStatus.ColumnName = "Status";
            this.coldsStatusL3DataTableStatus.DataType = typeof(bool);
            this.coldsStatusL3DataTableStatus.Namespace = "";
            // 
            // coldsStatusL3DataTableDestination
            // 
            this.coldsStatusL3DataTableDestination.Caption = "Destination";
            this.coldsStatusL3DataTableDestination.ColumnName = "Destination";
            this.coldsStatusL3DataTableDestination.DataType = typeof(int);
            this.coldsStatusL3DataTableDestination.Namespace = "";
            // 
            // coldsStatusL3DataTableShift
            // 
            this.coldsStatusL3DataTableShift.Caption = "Shift";
            this.coldsStatusL3DataTableShift.ColumnName = "Shift";
            this.coldsStatusL3DataTableShift.Namespace = "";
            // 
            // coldsStatusL3DataTableTeam
            // 
            this.coldsStatusL3DataTableTeam.Caption = "Team";
            this.coldsStatusL3DataTableTeam.ColumnName = "Team";
            this.coldsStatusL3DataTableTeam.Namespace = "";
            // 
            // coldsStatusL3DataTableNote
            // 
            this.coldsStatusL3DataTableNote.Caption = "Note";
            this.coldsStatusL3DataTableNote.ColumnName = "Note";
            this.coldsStatusL3DataTableNote.Namespace = "";
            // 
            // coldsStatusL3DataTableLocked
            // 
            this.coldsStatusL3DataTableLocked.Caption = "Locked";
            this.coldsStatusL3DataTableLocked.ColumnName = "Locked";
            this.coldsStatusL3DataTableLocked.DataType = typeof(bool);
            this.coldsStatusL3DataTableLocked.Namespace = "";
            // 
            // coldsStatusL3DataTableSampleApplyCount_B
            // 
            this.coldsStatusL3DataTableSampleApplyCount_B.Caption = "SampleApplyCount_B";
            this.coldsStatusL3DataTableSampleApplyCount_B.ColumnName = "SampleApplyCount_B";
            this.coldsStatusL3DataTableSampleApplyCount_B.DataType = typeof(bool);
            this.coldsStatusL3DataTableSampleApplyCount_B.Namespace = "";
            // 
            // coldsStatusL3DataTableSampleApplyCount_A
            // 
            this.coldsStatusL3DataTableSampleApplyCount_A.Caption = "SampleApplyCount_A";
            this.coldsStatusL3DataTableSampleApplyCount_A.ColumnName = "SampleApplyCount_A";
            this.coldsStatusL3DataTableSampleApplyCount_A.DataType = typeof(bool);
            this.coldsStatusL3DataTableSampleApplyCount_A.Namespace = "";
            // 
            // coldsStatusL3DataTableMediator
            // 
            this.coldsStatusL3DataTableMediator.Caption = "Mediator";
            this.coldsStatusL3DataTableMediator.ColumnName = "Mediator";
            this.coldsStatusL3DataTableMediator.Namespace = "";
            // 
            // coldsStatusL3DataTableTotalTime
            // 
            this.coldsStatusL3DataTableTotalTime.Caption = "TotalTime";
            this.coldsStatusL3DataTableTotalTime.ColumnName = "TotalTime";
            this.coldsStatusL3DataTableTotalTime.DataType = typeof(int);
            this.coldsStatusL3DataTableTotalTime.Namespace = "";
            // 
            // bsNote
            // 
            this.bsNote.DataMember = "L3DataTable";
            this.bsNote.DataSource = this.dsNote;
            // 
            // ChangeNoteMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 300);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "ChangeNoteMag";
            this.Text = "备注维护";
            this.Load += new System.EventHandler(this.ChangeNoteMag_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMaterialID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox txtNote;
        private System.Windows.Forms.Label lbReason;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsNote;
        private System.Data.DataTable schemadsStatus;
        private AppSvrHMI.L3Command cmdSetStatus1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3Command cmdSetStatus2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsStatusL3DataTableMaterialID;
        private System.Data.DataColumn coldsStatusL3DataTableTAP_No;
        private System.Data.DataColumn coldsStatusL3DataTableTPC_No;
        private System.Data.DataColumn coldsStatusL3DataTableDeS_UnitID;
        private System.Data.DataColumn coldsStatusL3DataTableRemoveSlag_UnitID;
        private System.Data.DataColumn coldsStatusL3DataTableDeS_Operator;
        private System.Data.DataColumn coldsStatusL3DataTableRemoveSlag_Operator;
        private System.Data.DataColumn coldsStatusL3DataTableDeS_Flag;
        private System.Data.DataColumn coldsStatusL3DataTableProductionDate;
        private System.Data.DataColumn coldsStatusL3DataTablePreRemoveSlagTime;
        private System.Data.DataColumn coldsStatusL3DataTableRemoveSlagTime;
        private System.Data.DataColumn coldsStatusL3DataTableBlowTimeTotal;
        private System.Data.DataColumn coldsStatusL3DataTableProcessTime;
        private System.Data.DataColumn coldsStatusL3DataTableRemoveSlagCount;
        private System.Data.DataColumn coldsStatusL3DataTableGross_Weight;
        private System.Data.DataColumn coldsStatusL3DataTableEstimate_Weight;
        private System.Data.DataColumn coldsStatusL3DataTableNet_Weight;
        private System.Data.DataColumn coldsStatusL3DataTableDeSType;
        private System.Data.DataColumn coldsStatusL3DataTableMat_Consume;
        private System.Data.DataColumn coldsStatusL3DataTableWeight_MatTank;
        private System.Data.DataColumn coldsStatusL3DataTableWeight_SprayTank;
        private System.Data.DataColumn coldsStatusL3DataTableStatus;
        private System.Data.DataColumn coldsStatusL3DataTableDestination;
        private System.Data.DataColumn coldsStatusL3DataTableShift;
        private System.Data.DataColumn coldsStatusL3DataTableTeam;
        private System.Data.DataColumn coldsStatusL3DataTableNote;
        private System.Data.DataColumn coldsStatusL3DataTableLocked;
        private System.Data.DataColumn coldsStatusL3DataTableSampleApplyCount_B;
        private System.Data.DataColumn coldsStatusL3DataTableSampleApplyCount_A;
        private System.Data.DataColumn coldsStatusL3DataTableMediator;
        private System.Data.DataColumn coldsStatusL3DataTableTotalTime;
        private System.Windows.Forms.BindingSource bsNote;
    }
}