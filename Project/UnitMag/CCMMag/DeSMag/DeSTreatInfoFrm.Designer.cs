namespace UnitMag.DeSMag
{
    partial class DeSTreatInfoFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeSTreatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMaterialID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbRemoveSlag_UnitID = new System.Windows.Forms.ComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsbase = new System.Data.DataTable();
            this.coldsbaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsbaseL3DataTableName = new System.Data.DataColumn();
            this.coldsbaseL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsbaseL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsbaseL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsbaseL3DataTableDeS_UnitID = new System.Data.DataColumn();
            this.coldsbaseL3DataTableRemoveSlag_UnitID = new System.Data.DataColumn();
            this.coldsbaseL3DataTableDeS_Operator = new System.Data.DataColumn();
            this.coldsbaseL3DataTableRemoveSlag_Operator = new System.Data.DataColumn();
            this.coldsbaseL3DataTableDeS_Flag = new System.Data.DataColumn();
            this.coldsbaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsbaseL3DataTablePreRemoveSlagTime = new System.Data.DataColumn();
            this.coldsbaseL3DataTableRemoveSlagTime = new System.Data.DataColumn();
            this.coldsbaseL3DataTableBlowTimeTotal = new System.Data.DataColumn();
            this.coldsbaseL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsbaseL3DataTableRemoveSlagCount = new System.Data.DataColumn();
            this.coldsbaseL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsbaseL3DataTableEstimate_Weight = new System.Data.DataColumn();
            this.coldsbaseL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsbaseL3DataTableDeSType = new System.Data.DataColumn();
            this.coldsbaseL3DataTableMat_Consume = new System.Data.DataColumn();
            this.coldsbaseL3DataTableWeight_MatTank = new System.Data.DataColumn();
            this.coldsbaseL3DataTableWeight_SprayTank = new System.Data.DataColumn();
            this.coldsbaseL3DataTableStatus = new System.Data.DataColumn();
            this.coldsbaseL3DataTableDestination = new System.Data.DataColumn();
            this.coldsbaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsbaseL3DataTableTeam = new System.Data.DataColumn();
            this.coldsbaseL3DataTableNote = new System.Data.DataColumn();
            this.coldsbaseL3DataTableLocked = new System.Data.DataColumn();
            this.coldsBaseL3DataTableMediator = new System.Data.DataColumn();
            this.AcoldsBaseL3DataTableTotalTime = new System.Data.DataColumn();
            this.dsUnitID2 = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID2 = new System.Data.DataTable();
            this.coldsUnitID2L3DataTablecode = new System.Data.DataColumn();
            this.coldsUnitID2L3DataTablecode_des = new System.Data.DataColumn();
            this.cmbDeS_UnitID = new System.Windows.Forms.ComboBox();
            this.dsUintID = new AppSvrHMI.L3DataSet();
            this.schemadsUintID = new System.Data.DataTable();
            this.coldsUintIDL3DataTablecode = new System.Data.DataColumn();
            this.coldsUintIDL3DataTablecode_des = new System.Data.DataColumn();
            this.txtTPC_No = new PxDataValid.PxTextBox();
            this.txtTAP_No = new PxDataValid.PxTextBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.cmbDestination = new PxDataValid.PxComboBox();
            this.dsDesination = new AppSvrHMI.L3DataSet();
            this.schemadsDesination = new System.Data.DataTable();
            this.coldsDesinationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDesinationL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cmbStatus = new PxDataValid.PxComboBox();
            this.dsDeSStatus = new AppSvrHMI.L3DataSet();
            this.schemadsDeSStatus = new System.Data.DataTable();
            this.coldsDeSStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDeSStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cmbDeSType = new PxDataValid.PxComboBox();
            this.dsDeSType = new AppSvrHMI.L3DataSet();
            this.schemadsDeSType = new System.Data.DataTable();
            this.coldsDeSTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDeSTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cmbDeS_Flag = new PxDataValid.PxComboBox();
            this.dsYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsYesNo = new System.Data.DataTable();
            this.coldsYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.dsShift2 = new AppSvrHMI.L3DataSet();
            this.schemadsShift2 = new System.Data.DataTable();
            this.coldsShift2L3DataTableCode = new System.Data.DataColumn();
            this.coldsShift2L3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeam = new PxDataValid.PxComboBox();
            this.dsTeam2 = new AppSvrHMI.L3DataSet();
            this.schemadsTeam2 = new System.Data.DataTable();
            this.coldsTeam2L3DataTableCode = new System.Data.DataColumn();
            this.coldsTeam2L3DataTableCode_Des = new System.Data.DataColumn();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMediator = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemoveSlag_Operator = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.txtNet_Weight = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEstimate_Weight = new PxDataValid.PxTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtGross_Weight = new PxDataValid.PxTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRemoveSlagCount = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTotalTime = new PxDataValid.PxTextBox();
            this.txtProcessTime = new PxDataValid.PxTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWeight_SprayTank = new PxDataValid.PxTextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtWeight_MatTank = new PxDataValid.PxTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.txtMat_Consume = new PxDataValid.PxTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBlowTimeTotal = new PxDataValid.PxTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsddd = new AppSvrHMI.L3DataSet();
            this.schemads = new System.Data.DataTable();
            this.coldsL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsL3DataTableBlowTime = new System.Data.DataColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemoveSlagTime = new PxDataValid.PxTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPreRemoveSlagTime = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.txtDeS_Operator = new PxDataValid.PxTextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fLPBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.btnBaseConfirm = new System.Windows.Forms.Button();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.hmiRootPanel7 = new HMIBase.HMIRootPanel();
            this.dvProcess = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matConsumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blowTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blowBeginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blowEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableS_B = new System.Data.DataColumn();
            this.coldsProcessL3DataTableS_A = new System.Data.DataColumn();
            this.coldsProcessL3DataTableP_B = new System.Data.DataColumn();
            this.coldsProcessL3DataTableP_A = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMat_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLanceNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLanceAge = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlowTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlowBeginTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlowEndTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableAreaID = new System.Data.DataColumn();
            this.FLPProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.btnProcessConfirm = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.dvStatus = new System.Windows.Forms.DataGridView();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.changeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableName = new System.Data.DataColumn();
            this.coldsStatusL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsStatusL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatusL3DataTableChange_Time = new System.Data.DataColumn();
            this.coldsStatusL3DataTableAreaID = new System.Data.DataColumn();
            this.bnStatus = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.btnDelStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.fLPStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.btnStatusConfirm = new System.Windows.Forms.Button();
            this.tabRunTime = new System.Windows.Forms.TabPage();
            this.hmiRootPanel3 = new HMIBase.HMIRootPanel();
            this.dvRunTime = new System.Windows.Forms.DataGridView();
            this.iDObjectDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRunTime = new System.Windows.Forms.BindingSource(this.components);
            this.dsRunTime = new AppSvrHMI.L3DataSet();
            this.schemadsRunTime = new System.Data.DataTable();
            this.coldsRunTimeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableName = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTablePressure = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableFlow = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableRate = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableCatch_Count = new System.Data.DataColumn();
            this.coldsRunTimeL3DataTableCatch_Time = new System.Data.DataColumn();
            this.bnRemark = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemarkAdd = new System.Windows.Forms.ToolStripButton();
            this.btnRemarkDel = new System.Windows.Forms.ToolStripButton();
            this.fLPRunTime = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRunTimeCancel = new System.Windows.Forms.Button();
            this.btnRunTimeConfirm = new System.Windows.Forms.Button();
            this.coldsBaseL3DataTableTotalTime = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUintID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUintID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsddd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemads)).BeginInit();
            this.fLPBase.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.hmiRootPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            this.FLPProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).BeginInit();
            this.bnStatus.SuspendLayout();
            this.fLPStatus.SuspendLayout();
            this.tabRunTime.SuspendLayout();
            this.hmiRootPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRunTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).BeginInit();
            this.bnRemark.SuspendLayout();
            this.fLPRunTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.txtMaterialID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 29);
            this.panel3.TabIndex = 86;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Enabled = false;
            this.txtMaterialID.EnableNull = false;
            this.txtMaterialID.ErropPr = null;
            this.txtMaterialID.Length = 0;
            this.txtMaterialID.Location = new System.Drawing.Point(84, 5);
            this.txtMaterialID.Max = 0;
            this.txtMaterialID.MaxStrLength = 0;
            this.txtMaterialID.Min = 0;
            this.txtMaterialID.MinStrLength = 0;
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Precision = 0;
            this.txtMaterialID.ReadOnly = true;
            this.txtMaterialID.Size = new System.Drawing.Size(106, 21);
            this.txtMaterialID.TabIndex = 74;
            this.txtMaterialID.ToolTipValid = null;
            this.txtMaterialID.ValidEable = true;
            this.txtMaterialID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtMaterialID.TextChanged += new System.EventHandler(this.txtMaterialID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "物料标识：";
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabRunTime);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 29);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(973, 411);
            this.tabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrlMain.TabIndex = 87;
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbRemoveSlag_UnitID);
            this.tabBase.Controls.Add(this.cmbDeS_UnitID);
            this.tabBase.Controls.Add(this.txtTPC_No);
            this.tabBase.Controls.Add(this.txtTAP_No);
            this.tabBase.Controls.Add(this.txtNote);
            this.tabBase.Controls.Add(this.cmbDestination);
            this.tabBase.Controls.Add(this.cmbStatus);
            this.tabBase.Controls.Add(this.cmbDeSType);
            this.tabBase.Controls.Add(this.cmbDeS_Flag);
            this.tabBase.Controls.Add(this.cmbShift);
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.dtpProductionDate);
            this.tabBase.Controls.Add(this.label10);
            this.tabBase.Controls.Add(this.txtMediator);
            this.tabBase.Controls.Add(this.label8);
            this.tabBase.Controls.Add(this.txtRemoveSlag_Operator);
            this.tabBase.Controls.Add(this.label7);
            this.tabBase.Controls.Add(this.label59);
            this.tabBase.Controls.Add(this.txtNet_Weight);
            this.tabBase.Controls.Add(this.label19);
            this.tabBase.Controls.Add(this.txtEstimate_Weight);
            this.tabBase.Controls.Add(this.label18);
            this.tabBase.Controls.Add(this.txtGross_Weight);
            this.tabBase.Controls.Add(this.label17);
            this.tabBase.Controls.Add(this.txtRemoveSlagCount);
            this.tabBase.Controls.Add(this.label16);
            this.tabBase.Controls.Add(this.txtTotalTime);
            this.tabBase.Controls.Add(this.txtProcessTime);
            this.tabBase.Controls.Add(this.label20);
            this.tabBase.Controls.Add(this.label15);
            this.tabBase.Controls.Add(this.txtWeight_SprayTank);
            this.tabBase.Controls.Add(this.label55);
            this.tabBase.Controls.Add(this.txtWeight_MatTank);
            this.tabBase.Controls.Add(this.label54);
            this.tabBase.Controls.Add(this.txtMat_Consume);
            this.tabBase.Controls.Add(this.label22);
            this.tabBase.Controls.Add(this.txtBlowTimeTotal);
            this.tabBase.Controls.Add(this.label14);
            this.tabBase.Controls.Add(this.txtRemoveSlagTime);
            this.tabBase.Controls.Add(this.label13);
            this.tabBase.Controls.Add(this.txtPreRemoveSlagTime);
            this.tabBase.Controls.Add(this.label9);
            this.tabBase.Controls.Add(this.label57);
            this.tabBase.Controls.Add(this.txtDeS_Operator);
            this.tabBase.Controls.Add(this.label56);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label58);
            this.tabBase.Controls.Add(this.label21);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label3);
            this.tabBase.Controls.Add(this.label12);
            this.tabBase.Controls.Add(this.label11);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Controls.Add(this.fLPBase);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(965, 386);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本数据";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cmbRemoveSlag_UnitID
            // 
            this.cmbRemoveSlag_UnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "RemoveSlag_UnitID", true));
            this.cmbRemoveSlag_UnitID.DataSource = this.dsUnitID2;
            this.cmbRemoveSlag_UnitID.DisplayMember = "L3DataTable.code_des";
            this.cmbRemoveSlag_UnitID.Enabled = false;
            this.cmbRemoveSlag_UnitID.FormattingEnabled = true;
            this.cmbRemoveSlag_UnitID.Location = new System.Drawing.Point(114, 136);
            this.cmbRemoveSlag_UnitID.Name = "cmbRemoveSlag_UnitID";
            this.cmbRemoveSlag_UnitID.Size = new System.Drawing.Size(104, 20);
            this.cmbRemoveSlag_UnitID.TabIndex = 110;
            this.cmbRemoveSlag_UnitID.ValueMember = "L3DataTable.code";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = "";
            this.dsBase.InsertMethod = "";
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "1=2";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Base_Data";
            this.dsBase.SubscribeTarget = "";
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsbase});
            this.dsBase.UpdateEvent = "";
            this.dsBase.UpdateMethod = "";
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsbase
            // 
            this.schemadsbase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsbaseL3DataTableGUID,
            this.coldsbaseL3DataTableName,
            this.coldsbaseL3DataTableMaterialID,
            this.coldsbaseL3DataTableTAP_No,
            this.coldsbaseL3DataTableTPC_No,
            this.coldsbaseL3DataTableDeS_UnitID,
            this.coldsbaseL3DataTableRemoveSlag_UnitID,
            this.coldsbaseL3DataTableDeS_Operator,
            this.coldsbaseL3DataTableRemoveSlag_Operator,
            this.coldsbaseL3DataTableDeS_Flag,
            this.coldsbaseL3DataTableProductionDate,
            this.coldsbaseL3DataTablePreRemoveSlagTime,
            this.coldsbaseL3DataTableRemoveSlagTime,
            this.coldsbaseL3DataTableBlowTimeTotal,
            this.coldsbaseL3DataTableProcessTime,
            this.coldsbaseL3DataTableRemoveSlagCount,
            this.coldsbaseL3DataTableGross_Weight,
            this.coldsbaseL3DataTableEstimate_Weight,
            this.coldsbaseL3DataTableNet_Weight,
            this.coldsbaseL3DataTableDeSType,
            this.coldsbaseL3DataTableMat_Consume,
            this.coldsbaseL3DataTableWeight_MatTank,
            this.coldsbaseL3DataTableWeight_SprayTank,
            this.coldsbaseL3DataTableStatus,
            this.coldsbaseL3DataTableDestination,
            this.coldsbaseL3DataTableShift,
            this.coldsbaseL3DataTableTeam,
            this.coldsbaseL3DataTableNote,
            this.coldsbaseL3DataTableLocked,
            this.coldsBaseL3DataTableMediator,
            this.AcoldsBaseL3DataTableTotalTime});
            this.schemadsbase.TableName = "L3DataTable";
            // 
            // coldsbaseL3DataTableGUID
            // 
            this.coldsbaseL3DataTableGUID.Caption = "GUID";
            this.coldsbaseL3DataTableGUID.ColumnName = "GUID";
            this.coldsbaseL3DataTableGUID.Namespace = "";
            // 
            // coldsbaseL3DataTableName
            // 
            this.coldsbaseL3DataTableName.Caption = "Name";
            this.coldsbaseL3DataTableName.ColumnName = "Name";
            this.coldsbaseL3DataTableName.Namespace = "";
            // 
            // coldsbaseL3DataTableMaterialID
            // 
            this.coldsbaseL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsbaseL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsbaseL3DataTableMaterialID.Namespace = "";
            // 
            // coldsbaseL3DataTableTAP_No
            // 
            this.coldsbaseL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsbaseL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsbaseL3DataTableTAP_No.Namespace = "";
            // 
            // coldsbaseL3DataTableTPC_No
            // 
            this.coldsbaseL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsbaseL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsbaseL3DataTableTPC_No.Namespace = "";
            // 
            // coldsbaseL3DataTableDeS_UnitID
            // 
            this.coldsbaseL3DataTableDeS_UnitID.Caption = "DeS_UnitID";
            this.coldsbaseL3DataTableDeS_UnitID.ColumnName = "DeS_UnitID";
            this.coldsbaseL3DataTableDeS_UnitID.Namespace = "";
            // 
            // coldsbaseL3DataTableRemoveSlag_UnitID
            // 
            this.coldsbaseL3DataTableRemoveSlag_UnitID.Caption = "RemoveSlag_UnitID";
            this.coldsbaseL3DataTableRemoveSlag_UnitID.ColumnName = "RemoveSlag_UnitID";
            this.coldsbaseL3DataTableRemoveSlag_UnitID.Namespace = "";
            // 
            // coldsbaseL3DataTableDeS_Operator
            // 
            this.coldsbaseL3DataTableDeS_Operator.Caption = "DeS_Operator";
            this.coldsbaseL3DataTableDeS_Operator.ColumnName = "DeS_Operator";
            this.coldsbaseL3DataTableDeS_Operator.Namespace = "";
            // 
            // coldsbaseL3DataTableRemoveSlag_Operator
            // 
            this.coldsbaseL3DataTableRemoveSlag_Operator.Caption = "RemoveSlag_Operator";
            this.coldsbaseL3DataTableRemoveSlag_Operator.ColumnName = "RemoveSlag_Operator";
            this.coldsbaseL3DataTableRemoveSlag_Operator.Namespace = "";
            // 
            // coldsbaseL3DataTableDeS_Flag
            // 
            this.coldsbaseL3DataTableDeS_Flag.Caption = "DeS_Flag";
            this.coldsbaseL3DataTableDeS_Flag.ColumnName = "DeS_Flag";
            this.coldsbaseL3DataTableDeS_Flag.DataType = typeof(int);
            this.coldsbaseL3DataTableDeS_Flag.Namespace = "";
            // 
            // coldsbaseL3DataTableProductionDate
            // 
            this.coldsbaseL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsbaseL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsbaseL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsbaseL3DataTableProductionDate.Namespace = "";
            // 
            // coldsbaseL3DataTablePreRemoveSlagTime
            // 
            this.coldsbaseL3DataTablePreRemoveSlagTime.Caption = "PreRemoveSlagTime";
            this.coldsbaseL3DataTablePreRemoveSlagTime.ColumnName = "PreRemoveSlagTime";
            this.coldsbaseL3DataTablePreRemoveSlagTime.DataType = typeof(int);
            this.coldsbaseL3DataTablePreRemoveSlagTime.Namespace = "";
            // 
            // coldsbaseL3DataTableRemoveSlagTime
            // 
            this.coldsbaseL3DataTableRemoveSlagTime.Caption = "RemoveSlagTime";
            this.coldsbaseL3DataTableRemoveSlagTime.ColumnName = "RemoveSlagTime";
            this.coldsbaseL3DataTableRemoveSlagTime.DataType = typeof(int);
            this.coldsbaseL3DataTableRemoveSlagTime.Namespace = "";
            // 
            // coldsbaseL3DataTableBlowTimeTotal
            // 
            this.coldsbaseL3DataTableBlowTimeTotal.Caption = "BlowTimeTotal";
            this.coldsbaseL3DataTableBlowTimeTotal.ColumnName = "BlowTimeTotal";
            this.coldsbaseL3DataTableBlowTimeTotal.DataType = typeof(int);
            this.coldsbaseL3DataTableBlowTimeTotal.Namespace = "";
            // 
            // coldsbaseL3DataTableProcessTime
            // 
            this.coldsbaseL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsbaseL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsbaseL3DataTableProcessTime.DataType = typeof(int);
            this.coldsbaseL3DataTableProcessTime.Namespace = "";
            // 
            // coldsbaseL3DataTableRemoveSlagCount
            // 
            this.coldsbaseL3DataTableRemoveSlagCount.Caption = "RemoveSlagCount";
            this.coldsbaseL3DataTableRemoveSlagCount.ColumnName = "RemoveSlagCount";
            this.coldsbaseL3DataTableRemoveSlagCount.DataType = typeof(int);
            this.coldsbaseL3DataTableRemoveSlagCount.Namespace = "";
            // 
            // coldsbaseL3DataTableGross_Weight
            // 
            this.coldsbaseL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsbaseL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsbaseL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsbaseL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsbaseL3DataTableEstimate_Weight
            // 
            this.coldsbaseL3DataTableEstimate_Weight.Caption = "Estimate_Weight";
            this.coldsbaseL3DataTableEstimate_Weight.ColumnName = "Estimate_Weight";
            this.coldsbaseL3DataTableEstimate_Weight.DataType = typeof(double);
            this.coldsbaseL3DataTableEstimate_Weight.Namespace = "";
            // 
            // coldsbaseL3DataTableNet_Weight
            // 
            this.coldsbaseL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsbaseL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsbaseL3DataTableNet_Weight.DataType = typeof(double);
            this.coldsbaseL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsbaseL3DataTableDeSType
            // 
            this.coldsbaseL3DataTableDeSType.Caption = "DeSType";
            this.coldsbaseL3DataTableDeSType.ColumnName = "DeSType";
            this.coldsbaseL3DataTableDeSType.DataType = typeof(short);
            this.coldsbaseL3DataTableDeSType.Namespace = "";
            // 
            // coldsbaseL3DataTableMat_Consume
            // 
            this.coldsbaseL3DataTableMat_Consume.Caption = "Mat_Consume";
            this.coldsbaseL3DataTableMat_Consume.ColumnName = "Mat_Consume";
            this.coldsbaseL3DataTableMat_Consume.DataType = typeof(double);
            this.coldsbaseL3DataTableMat_Consume.Namespace = "";
            // 
            // coldsbaseL3DataTableWeight_MatTank
            // 
            this.coldsbaseL3DataTableWeight_MatTank.Caption = "Weight_MatTank";
            this.coldsbaseL3DataTableWeight_MatTank.ColumnName = "Weight_MatTank";
            this.coldsbaseL3DataTableWeight_MatTank.DataType = typeof(double);
            this.coldsbaseL3DataTableWeight_MatTank.Namespace = "";
            // 
            // coldsbaseL3DataTableWeight_SprayTank
            // 
            this.coldsbaseL3DataTableWeight_SprayTank.Caption = "Weight_SprayTank";
            this.coldsbaseL3DataTableWeight_SprayTank.ColumnName = "Weight_SprayTank";
            this.coldsbaseL3DataTableWeight_SprayTank.DataType = typeof(double);
            this.coldsbaseL3DataTableWeight_SprayTank.Namespace = "";
            // 
            // coldsbaseL3DataTableStatus
            // 
            this.coldsbaseL3DataTableStatus.Caption = "Status";
            this.coldsbaseL3DataTableStatus.ColumnName = "Status";
            this.coldsbaseL3DataTableStatus.DataType = typeof(short);
            this.coldsbaseL3DataTableStatus.Namespace = "";
            // 
            // coldsbaseL3DataTableDestination
            // 
            this.coldsbaseL3DataTableDestination.Caption = "Destination";
            this.coldsbaseL3DataTableDestination.ColumnName = "Destination";
            this.coldsbaseL3DataTableDestination.DataType = typeof(short);
            this.coldsbaseL3DataTableDestination.Namespace = "";
            // 
            // coldsbaseL3DataTableShift
            // 
            this.coldsbaseL3DataTableShift.Caption = "Shift";
            this.coldsbaseL3DataTableShift.ColumnName = "Shift";
            this.coldsbaseL3DataTableShift.Namespace = "";
            // 
            // coldsbaseL3DataTableTeam
            // 
            this.coldsbaseL3DataTableTeam.Caption = "Team";
            this.coldsbaseL3DataTableTeam.ColumnName = "Team";
            this.coldsbaseL3DataTableTeam.Namespace = "";
            // 
            // coldsbaseL3DataTableNote
            // 
            this.coldsbaseL3DataTableNote.Caption = "Note";
            this.coldsbaseL3DataTableNote.ColumnName = "Note";
            this.coldsbaseL3DataTableNote.Namespace = "";
            // 
            // coldsbaseL3DataTableLocked
            // 
            this.coldsbaseL3DataTableLocked.Caption = "Locked";
            this.coldsbaseL3DataTableLocked.ColumnName = "Locked";
            this.coldsbaseL3DataTableLocked.DataType = typeof(short);
            this.coldsbaseL3DataTableLocked.Namespace = "";
            // 
            // coldsBaseL3DataTableMediator
            // 
            this.coldsBaseL3DataTableMediator.Caption = "Mediator";
            this.coldsBaseL3DataTableMediator.ColumnName = "Mediator";
            this.coldsBaseL3DataTableMediator.Namespace = "";
            // 
            // AcoldsBaseL3DataTableTotalTime
            // 
            this.AcoldsBaseL3DataTableTotalTime.Caption = "TotalTime";
            this.AcoldsBaseL3DataTableTotalTime.ColumnName = "TotalTime";
            this.AcoldsBaseL3DataTableTotalTime.DataType = typeof(int);
            this.AcoldsBaseL3DataTableTotalTime.Namespace = "";
            // 
            // dsUnitID2
            // 
            this.dsUnitID2.AutoLoad = true;
            this.dsUnitID2.AutoSubscribe = false;
            this.dsUnitID2.DataSetName = "L3DataSet";
            this.dsUnitID2.DeleteMethod = "";
            this.dsUnitID2.InsertMethod = "";
            this.dsUnitID2.L3DataAdapter = this.Adapter;
            this.dsUnitID2.LoadEvent = "";
            this.dsUnitID2.LoadTrigger = null;
            this.dsUnitID2.RefreshValve = 1000;
            this.dsUnitID2.SourceCommand = null;
            this.dsUnitID2.SourceCondition = "code_group = \'DeS\'";
            this.dsUnitID2.SourceMethod = "";
            this.dsUnitID2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID2.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID2.SubscribeTarget = "";
            this.dsUnitID2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID2});
            this.dsUnitID2.UpdateEvent = "";
            this.dsUnitID2.UpdateMethod = "";
            this.dsUnitID2.UpdateTrigger = null;
            // 
            // schemadsUnitID2
            // 
            this.schemadsUnitID2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitID2L3DataTablecode,
            this.coldsUnitID2L3DataTablecode_des});
            this.schemadsUnitID2.TableName = "L3DataTable";
            // 
            // coldsUnitID2L3DataTablecode
            // 
            this.coldsUnitID2L3DataTablecode.Caption = "code";
            this.coldsUnitID2L3DataTablecode.ColumnName = "code";
            this.coldsUnitID2L3DataTablecode.Namespace = "";
            // 
            // coldsUnitID2L3DataTablecode_des
            // 
            this.coldsUnitID2L3DataTablecode_des.Caption = "code_des";
            this.coldsUnitID2L3DataTablecode_des.ColumnName = "code_des";
            this.coldsUnitID2L3DataTablecode_des.Namespace = "";
            // 
            // cmbDeS_UnitID
            // 
            this.cmbDeS_UnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "DeS_UnitID", true));
            this.cmbDeS_UnitID.DataSource = this.dsUintID;
            this.cmbDeS_UnitID.DisplayMember = "L3DataTable.code_des";
            this.cmbDeS_UnitID.Enabled = false;
            this.cmbDeS_UnitID.FormattingEnabled = true;
            this.cmbDeS_UnitID.Location = new System.Drawing.Point(116, 99);
            this.cmbDeS_UnitID.Name = "cmbDeS_UnitID";
            this.cmbDeS_UnitID.Size = new System.Drawing.Size(104, 20);
            this.cmbDeS_UnitID.TabIndex = 110;
            this.cmbDeS_UnitID.ValueMember = "L3DataTable.code";
            // 
            // dsUintID
            // 
            this.dsUintID.AutoLoad = true;
            this.dsUintID.AutoSubscribe = false;
            this.dsUintID.DataSetName = "L3DataSet";
            this.dsUintID.DeleteMethod = "";
            this.dsUintID.InsertMethod = "";
            this.dsUintID.L3DataAdapter = this.Adapter;
            this.dsUintID.LoadEvent = "";
            this.dsUintID.LoadTrigger = null;
            this.dsUintID.RefreshValve = 1000;
            this.dsUintID.SourceCommand = null;
            this.dsUintID.SourceCondition = "code_group = \'DeS\'";
            this.dsUintID.SourceMethod = "";
            this.dsUintID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUintID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUintID.SubscribeTarget = "";
            this.dsUintID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUintID});
            this.dsUintID.UpdateEvent = "";
            this.dsUintID.UpdateMethod = "";
            this.dsUintID.UpdateTrigger = null;
            // 
            // schemadsUintID
            // 
            this.schemadsUintID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUintIDL3DataTablecode,
            this.coldsUintIDL3DataTablecode_des});
            this.schemadsUintID.TableName = "L3DataTable";
            // 
            // coldsUintIDL3DataTablecode
            // 
            this.coldsUintIDL3DataTablecode.Caption = "code";
            this.coldsUintIDL3DataTablecode.ColumnName = "code";
            this.coldsUintIDL3DataTablecode.Namespace = "";
            // 
            // coldsUintIDL3DataTablecode_des
            // 
            this.coldsUintIDL3DataTablecode_des.Caption = "code_des";
            this.coldsUintIDL3DataTablecode_des.ColumnName = "code_des";
            this.coldsUintIDL3DataTablecode_des.Namespace = "";
            // 
            // txtTPC_No
            // 
            this.txtTPC_No.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "TPC_No", true));
            this.txtTPC_No.Enabled = false;
            this.txtTPC_No.EnableNull = false;
            this.txtTPC_No.ErropPr = null;
            this.txtTPC_No.Length = 0;
            this.txtTPC_No.Location = new System.Drawing.Point(118, 61);
            this.txtTPC_No.Max = 0;
            this.txtTPC_No.MaxStrLength = 0;
            this.txtTPC_No.Min = -0.99;
            this.txtTPC_No.MinStrLength = 0;
            this.txtTPC_No.Name = "txtTPC_No";
            this.txtTPC_No.Precision = 0;
            this.txtTPC_No.Size = new System.Drawing.Size(100, 21);
            this.txtTPC_No.TabIndex = 109;
            this.txtTPC_No.ToolTipValid = null;
            this.txtTPC_No.ValidEable = true;
            this.txtTPC_No.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTAP_No
            // 
            this.txtTAP_No.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "TAP_No", true));
            this.txtTAP_No.Enabled = false;
            this.txtTAP_No.EnableNull = false;
            this.txtTAP_No.ErropPr = null;
            this.txtTAP_No.Length = 0;
            this.txtTAP_No.Location = new System.Drawing.Point(118, 25);
            this.txtTAP_No.Max = 0;
            this.txtTAP_No.MaxStrLength = 0;
            this.txtTAP_No.Min = -0.99;
            this.txtTAP_No.MinStrLength = 0;
            this.txtTAP_No.Name = "txtTAP_No";
            this.txtTAP_No.Precision = 0;
            this.txtTAP_No.Size = new System.Drawing.Size(100, 21);
            this.txtTAP_No.TabIndex = 109;
            this.txtTAP_No.ToolTipValid = null;
            this.txtTAP_No.ValidEable = true;
            this.txtTAP_No.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtNote
            // 
            this.txtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Note", true));
            this.txtNote.Location = new System.Drawing.Point(743, 25);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(192, 281);
            this.txtNote.TabIndex = 108;
            this.txtNote.Text = "";
            // 
            // cmbDestination
            // 
            this.cmbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDestination.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDestination.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Destination", true));
            this.cmbDestination.DataSource = this.dsDesination;
            this.cmbDestination.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.EnableNull = true;
            this.cmbDestination.ErropPr = null;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(562, 210);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(100, 20);
            this.cmbDestination.TabIndex = 107;
            this.cmbDestination.ToolTipValid = null;
            this.cmbDestination.ValidEable = true;
            this.cmbDestination.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsDesination
            // 
            this.dsDesination.AutoLoad = true;
            this.dsDesination.AutoSubscribe = false;
            this.dsDesination.DataSetName = "L3DataSet";
            this.dsDesination.DeleteMethod = "";
            this.dsDesination.InsertMethod = "";
            this.dsDesination.L3DataAdapter = this.Adapter;
            this.dsDesination.LoadEvent = "";
            this.dsDesination.LoadTrigger = null;
            this.dsDesination.RefreshValve = 1000;
            this.dsDesination.SourceCommand = null;
            this.dsDesination.SourceCondition = "code_group = \'Iron_Destination\' order by code";
            this.dsDesination.SourceMethod = "";
            this.dsDesination.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDesination.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDesination.SubscribeTarget = "";
            this.dsDesination.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDesination});
            this.dsDesination.UpdateEvent = "";
            this.dsDesination.UpdateMethod = "";
            this.dsDesination.UpdateTrigger = null;
            // 
            // schemadsDesination
            // 
            this.schemadsDesination.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDesinationL3DataTableCode_Des,
            this.coldsDesinationL3DataTableCode_Val_Long});
            this.schemadsDesination.TableName = "L3DataTable";
            // 
            // coldsDesinationL3DataTableCode_Des
            // 
            this.coldsDesinationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDesinationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDesinationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDesinationL3DataTableCode_Val_Long
            // 
            this.coldsDesinationL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDesinationL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDesinationL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsDesinationL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Status", true));
            this.cmbStatus.DataSource = this.dsDeSStatus;
            this.cmbStatus.DisplayMember = "L3DataTable.Code_Des";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.EnableNull = true;
            this.cmbStatus.ErropPr = null;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(562, 173);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 20);
            this.cmbStatus.TabIndex = 107;
            this.cmbStatus.ToolTipValid = null;
            this.cmbStatus.ValidEable = true;
            this.cmbStatus.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsDeSStatus
            // 
            this.dsDeSStatus.AutoLoad = true;
            this.dsDeSStatus.AutoSubscribe = false;
            this.dsDeSStatus.DataSetName = "L3DataSet";
            this.dsDeSStatus.DeleteMethod = "";
            this.dsDeSStatus.InsertMethod = "";
            this.dsDeSStatus.L3DataAdapter = this.Adapter;
            this.dsDeSStatus.LoadEvent = "";
            this.dsDeSStatus.LoadTrigger = null;
            this.dsDeSStatus.RefreshValve = 1000;
            this.dsDeSStatus.SourceCommand = null;
            this.dsDeSStatus.SourceCondition = "CODE_GROUP = \'DeSIronStatus\' order by Code_Val_Long";
            this.dsDeSStatus.SourceMethod = "";
            this.dsDeSStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDeSStatus.SubscribeTarget = "";
            this.dsDeSStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDeSStatus});
            this.dsDeSStatus.UpdateEvent = "";
            this.dsDeSStatus.UpdateMethod = "";
            this.dsDeSStatus.UpdateTrigger = null;
            // 
            // schemadsDeSStatus
            // 
            this.schemadsDeSStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDeSStatusL3DataTableCode_Des,
            this.coldsDeSStatusL3DataTableCode_Val_Long});
            this.schemadsDeSStatus.TableName = "L3DataTable";
            // 
            // coldsDeSStatusL3DataTableCode_Des
            // 
            this.coldsDeSStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDeSStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDeSStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDeSStatusL3DataTableCode_Val_Long
            // 
            this.coldsDeSStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDeSStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDeSStatusL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsDeSStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cmbDeSType
            // 
            this.cmbDeSType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDeSType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDeSType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDeSType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "DeSType", true));
            this.cmbDeSType.DataSource = this.dsDeSType;
            this.cmbDeSType.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDeSType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbDeSType.Enabled = false;
            this.cmbDeSType.EnableNull = true;
            this.cmbDeSType.ErropPr = null;
            this.cmbDeSType.FormattingEnabled = true;
            this.cmbDeSType.Location = new System.Drawing.Point(562, 25);
            this.cmbDeSType.Name = "cmbDeSType";
            this.cmbDeSType.Size = new System.Drawing.Size(100, 20);
            this.cmbDeSType.TabIndex = 107;
            this.cmbDeSType.ToolTipValid = null;
            this.cmbDeSType.ValidEable = true;
            this.cmbDeSType.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsDeSType
            // 
            this.dsDeSType.AutoLoad = true;
            this.dsDeSType.AutoSubscribe = false;
            this.dsDeSType.DataSetName = "L3DataSet";
            this.dsDeSType.DeleteMethod = "";
            this.dsDeSType.InsertMethod = "";
            this.dsDeSType.L3DataAdapter = this.Adapter;
            this.dsDeSType.LoadEvent = "";
            this.dsDeSType.LoadTrigger = null;
            this.dsDeSType.RefreshValve = 1000;
            this.dsDeSType.SourceCommand = null;
            this.dsDeSType.SourceCondition = "CODE_GROUP = \'DeSType\' order by Code_Val_Long";
            this.dsDeSType.SourceMethod = "";
            this.dsDeSType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDeSType.SubscribeTarget = "";
            this.dsDeSType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDeSType});
            this.dsDeSType.UpdateEvent = "";
            this.dsDeSType.UpdateMethod = "";
            this.dsDeSType.UpdateTrigger = null;
            // 
            // schemadsDeSType
            // 
            this.schemadsDeSType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDeSTypeL3DataTableCode_Des,
            this.coldsDeSTypeL3DataTableCode_Val_Long});
            this.schemadsDeSType.TableName = "L3DataTable";
            // 
            // coldsDeSTypeL3DataTableCode_Des
            // 
            this.coldsDeSTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDeSTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDeSTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDeSTypeL3DataTableCode_Val_Long
            // 
            this.coldsDeSTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDeSTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDeSTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsDeSTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cmbDeS_Flag
            // 
            this.cmbDeS_Flag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDeS_Flag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDeS_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDeS_Flag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "DeS_Flag", true));
            this.cmbDeS_Flag.DataSource = this.dsYesNo;
            this.cmbDeS_Flag.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDeS_Flag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbDeS_Flag.Enabled = false;
            this.cmbDeS_Flag.EnableNull = true;
            this.cmbDeS_Flag.ErropPr = null;
            this.cmbDeS_Flag.FormattingEnabled = true;
            this.cmbDeS_Flag.Location = new System.Drawing.Point(118, 285);
            this.cmbDeS_Flag.Name = "cmbDeS_Flag";
            this.cmbDeS_Flag.Size = new System.Drawing.Size(102, 20);
            this.cmbDeS_Flag.TabIndex = 107;
            this.cmbDeS_Flag.ToolTipValid = null;
            this.cmbDeS_Flag.ValidEable = true;
            this.cmbDeS_Flag.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsYesNo
            // 
            this.dsYesNo.AutoLoad = true;
            this.dsYesNo.AutoSubscribe = false;
            this.dsYesNo.DataSetName = "L3DataSet";
            this.dsYesNo.DeleteMethod = "";
            this.dsYesNo.InsertMethod = "";
            this.dsYesNo.L3DataAdapter = this.Adapter;
            this.dsYesNo.LoadEvent = "";
            this.dsYesNo.LoadTrigger = null;
            this.dsYesNo.RefreshValve = 1000;
            this.dsYesNo.SourceCommand = null;
            this.dsYesNo.SourceCondition = "CODE_GROUP = \'COMMON_YESNO\'  order by Code_Des";
            this.dsYesNo.SourceMethod = "";
            this.dsYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsYesNo.SubscribeTarget = "";
            this.dsYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsYesNo});
            this.dsYesNo.UpdateEvent = "";
            this.dsYesNo.UpdateMethod = "";
            this.dsYesNo.UpdateTrigger = null;
            // 
            // schemadsYesNo
            // 
            this.schemadsYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsYesNoL3DataTableCode_Des,
            this.coldsYesNoL3DataTableCode_Val_Long});
            this.schemadsYesNo.TableName = "L3DataTable";
            // 
            // coldsYesNoL3DataTableCode_Des
            // 
            this.coldsYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // coldsYesNoL3DataTableCode_Val_Long
            // 
            this.coldsYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cmbShift
            // 
            this.cmbShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShift.BackColor = System.Drawing.SystemColors.Window;
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Shift", true));
            this.cmbShift.DataSource = this.dsShift2;
            this.cmbShift.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.EnableNull = true;
            this.cmbShift.ErropPr = null;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(562, 245);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(100, 20);
            this.cmbShift.TabIndex = 107;
            this.cmbShift.ToolTipValid = null;
            this.cmbShift.ValidEable = true;
            this.cmbShift.ValueMember = "L3DataTable.Code";
            // 
            // dsShift2
            // 
            this.dsShift2.AutoLoad = true;
            this.dsShift2.AutoSubscribe = false;
            this.dsShift2.DataSetName = "L3DataSet";
            this.dsShift2.DeleteMethod = "";
            this.dsShift2.InsertMethod = "";
            this.dsShift2.L3DataAdapter = this.Adapter;
            this.dsShift2.LoadEvent = "";
            this.dsShift2.LoadTrigger = null;
            this.dsShift2.RefreshValve = 1000;
            this.dsShift2.SourceCommand = null;
            this.dsShift2.SourceCondition = "CODE_GROUP = \'ShiftID\' order by code";
            this.dsShift2.SourceMethod = "";
            this.dsShift2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift2.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift2.SubscribeTarget = "";
            this.dsShift2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift2});
            this.dsShift2.UpdateEvent = "";
            this.dsShift2.UpdateMethod = "";
            this.dsShift2.UpdateTrigger = null;
            // 
            // schemadsShift2
            // 
            this.schemadsShift2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShift2L3DataTableCode,
            this.coldsShift2L3DataTableCode_Des});
            this.schemadsShift2.TableName = "L3DataTable";
            // 
            // coldsShift2L3DataTableCode
            // 
            this.coldsShift2L3DataTableCode.Caption = "Code";
            this.coldsShift2L3DataTableCode.ColumnName = "Code";
            this.coldsShift2L3DataTableCode.Namespace = "";
            // 
            // coldsShift2L3DataTableCode_Des
            // 
            this.coldsShift2L3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShift2L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShift2L3DataTableCode_Des.Namespace = "";
            // 
            // cmbTeam
            // 
            this.cmbTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeam.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Team", true));
            this.cmbTeam.DataSource = this.dsTeam2;
            this.cmbTeam.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.EnableNull = true;
            this.cmbTeam.ErropPr = null;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(562, 285);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(100, 20);
            this.cmbTeam.TabIndex = 107;
            this.cmbTeam.ToolTipValid = null;
            this.cmbTeam.ValidEable = true;
            this.cmbTeam.ValueMember = "L3DataTable.Code";
            // 
            // dsTeam2
            // 
            this.dsTeam2.AutoLoad = true;
            this.dsTeam2.AutoSubscribe = false;
            this.dsTeam2.DataSetName = "L3DataSet";
            this.dsTeam2.DeleteMethod = "";
            this.dsTeam2.InsertMethod = "";
            this.dsTeam2.L3DataAdapter = this.Adapter;
            this.dsTeam2.LoadEvent = "";
            this.dsTeam2.LoadTrigger = null;
            this.dsTeam2.RefreshValve = 1000;
            this.dsTeam2.SourceCommand = null;
            this.dsTeam2.SourceCondition = "CODE_GROUP = \'TeamID\' order by code";
            this.dsTeam2.SourceMethod = "";
            this.dsTeam2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam2.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam2.SubscribeTarget = "";
            this.dsTeam2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam2});
            this.dsTeam2.UpdateEvent = "";
            this.dsTeam2.UpdateMethod = "";
            this.dsTeam2.UpdateTrigger = null;
            // 
            // schemadsTeam2
            // 
            this.schemadsTeam2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeam2L3DataTableCode,
            this.coldsTeam2L3DataTableCode_Des});
            this.schemadsTeam2.TableName = "L3DataTable";
            // 
            // coldsTeam2L3DataTableCode
            // 
            this.coldsTeam2L3DataTableCode.Caption = "Code";
            this.coldsTeam2L3DataTableCode.ColumnName = "Code";
            this.coldsTeam2L3DataTableCode.Namespace = "";
            // 
            // coldsTeam2L3DataTableCode_Des
            // 
            this.coldsTeam2L3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeam2L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeam2L3DataTableCode_Des.Namespace = "";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.CustomFormat = "yyyy-MM-dd";
            this.dtpProductionDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBase, "ProductionDate", true));
            this.dtpProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProductionDate.Location = new System.Drawing.Point(116, 321);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(102, 21);
            this.dtpProductionDate.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // txtMediator
            // 
            this.txtMediator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Mediator", true));
            this.txtMediator.Enabled = false;
            this.txtMediator.EnableNull = true;
            this.txtMediator.ErropPr = null;
            this.txtMediator.Length = 0;
            this.txtMediator.Location = new System.Drawing.Point(116, 246);
            this.txtMediator.Max = 0;
            this.txtMediator.MaxStrLength = 0;
            this.txtMediator.Min = 0;
            this.txtMediator.MinStrLength = 0;
            this.txtMediator.Name = "txtMediator";
            this.txtMediator.Precision = 0;
            this.txtMediator.Size = new System.Drawing.Size(102, 21);
            this.txtMediator.TabIndex = 101;
            this.txtMediator.ToolTipValid = null;
            this.txtMediator.ValidEable = true;
            this.txtMediator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 100;
            this.label8.Text = "协调人:";
            // 
            // txtRemoveSlag_Operator
            // 
            this.txtRemoveSlag_Operator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "RemoveSlag_Operator", true));
            this.txtRemoveSlag_Operator.Enabled = false;
            this.txtRemoveSlag_Operator.EnableNull = true;
            this.txtRemoveSlag_Operator.ErropPr = null;
            this.txtRemoveSlag_Operator.Length = 0;
            this.txtRemoveSlag_Operator.Location = new System.Drawing.Point(116, 210);
            this.txtRemoveSlag_Operator.Max = 0;
            this.txtRemoveSlag_Operator.MaxStrLength = 0;
            this.txtRemoveSlag_Operator.Min = 0;
            this.txtRemoveSlag_Operator.MinStrLength = 0;
            this.txtRemoveSlag_Operator.Name = "txtRemoveSlag_Operator";
            this.txtRemoveSlag_Operator.Precision = 0;
            this.txtRemoveSlag_Operator.Size = new System.Drawing.Size(102, 21);
            this.txtRemoveSlag_Operator.TabIndex = 101;
            this.txtRemoveSlag_Operator.ToolTipValid = null;
            this.txtRemoveSlag_Operator.ValidEable = true;
            this.txtRemoveSlag_Operator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "捞渣工:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(702, 29);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 12);
            this.label59.TabIndex = 98;
            this.label59.Text = "备注:";
            // 
            // txtNet_Weight
            // 
            this.txtNet_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Net_Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtNet_Weight.Enabled = false;
            this.txtNet_Weight.EnableNull = true;
            this.txtNet_Weight.ErropPr = null;
            this.txtNet_Weight.Length = 0;
            this.txtNet_Weight.Location = new System.Drawing.Point(344, 321);
            this.txtNet_Weight.Max = 0;
            this.txtNet_Weight.MaxStrLength = 0;
            this.txtNet_Weight.Min = 0;
            this.txtNet_Weight.MinStrLength = 0;
            this.txtNet_Weight.Name = "txtNet_Weight";
            this.txtNet_Weight.Precision = 0;
            this.txtNet_Weight.Size = new System.Drawing.Size(100, 21);
            this.txtNet_Weight.TabIndex = 99;
            this.txtNet_Weight.ToolTipValid = null;
            this.txtNet_Weight.ValidEable = true;
            this.txtNet_Weight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(285, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 98;
            this.label19.Text = "净重[T]:";
            // 
            // txtEstimate_Weight
            // 
            this.txtEstimate_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Estimate_Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtEstimate_Weight.Enabled = false;
            this.txtEstimate_Weight.EnableNull = true;
            this.txtEstimate_Weight.ErropPr = null;
            this.txtEstimate_Weight.Length = 0;
            this.txtEstimate_Weight.Location = new System.Drawing.Point(344, 246);
            this.txtEstimate_Weight.Max = 0;
            this.txtEstimate_Weight.MaxStrLength = 0;
            this.txtEstimate_Weight.Min = 0;
            this.txtEstimate_Weight.MinStrLength = 0;
            this.txtEstimate_Weight.Name = "txtEstimate_Weight";
            this.txtEstimate_Weight.Precision = 0;
            this.txtEstimate_Weight.Size = new System.Drawing.Size(100, 21);
            this.txtEstimate_Weight.TabIndex = 99;
            this.txtEstimate_Weight.ToolTipValid = null;
            this.txtEstimate_Weight.ValidEable = true;
            this.txtEstimate_Weight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(237, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 12);
            this.label18.TabIndex = 98;
            this.label18.Text = "铁水预测重量[T]:";
            // 
            // txtGross_Weight
            // 
            this.txtGross_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Gross_Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtGross_Weight.Enabled = false;
            this.txtGross_Weight.EnableNull = true;
            this.txtGross_Weight.ErropPr = null;
            this.txtGross_Weight.Length = 0;
            this.txtGross_Weight.Location = new System.Drawing.Point(344, 285);
            this.txtGross_Weight.Max = 0;
            this.txtGross_Weight.MaxStrLength = 0;
            this.txtGross_Weight.Min = 0;
            this.txtGross_Weight.MinStrLength = 0;
            this.txtGross_Weight.Name = "txtGross_Weight";
            this.txtGross_Weight.Precision = 0;
            this.txtGross_Weight.Size = new System.Drawing.Size(100, 21);
            this.txtGross_Weight.TabIndex = 99;
            this.txtGross_Weight.ToolTipValid = null;
            this.txtGross_Weight.ValidEable = true;
            this.txtGross_Weight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 98;
            this.label17.Text = "毛重[T]:";
            // 
            // txtRemoveSlagCount
            // 
            this.txtRemoveSlagCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "RemoveSlagCount", true));
            this.txtRemoveSlagCount.EnableNull = true;
            this.txtRemoveSlagCount.ErropPr = null;
            this.txtRemoveSlagCount.Length = 0;
            this.txtRemoveSlagCount.Location = new System.Drawing.Point(344, 210);
            this.txtRemoveSlagCount.Max = 0;
            this.txtRemoveSlagCount.MaxStrLength = 0;
            this.txtRemoveSlagCount.Min = 0;
            this.txtRemoveSlagCount.MinStrLength = 0;
            this.txtRemoveSlagCount.Name = "txtRemoveSlagCount";
            this.txtRemoveSlagCount.Precision = 0;
            this.txtRemoveSlagCount.Size = new System.Drawing.Size(100, 21);
            this.txtRemoveSlagCount.TabIndex = 99;
            this.txtRemoveSlagCount.ToolTipValid = null;
            this.txtRemoveSlagCount.ValidEable = true;
            this.txtRemoveSlagCount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 98;
            this.label16.Text = "捞渣次数:";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "TotalTime", true));
            this.txtTotalTime.Enabled = false;
            this.txtTotalTime.EnableNull = true;
            this.txtTotalTime.ErropPr = null;
            this.txtTotalTime.Length = 0;
            this.txtTotalTime.Location = new System.Drawing.Point(344, 173);
            this.txtTotalTime.Max = 0;
            this.txtTotalTime.MaxStrLength = 0;
            this.txtTotalTime.Min = 0;
            this.txtTotalTime.MinStrLength = 0;
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.Precision = 0;
            this.txtTotalTime.Size = new System.Drawing.Size(100, 21);
            this.txtTotalTime.TabIndex = 99;
            this.txtTotalTime.ToolTipValid = null;
            this.txtTotalTime.ValidEable = true;
            this.txtTotalTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtProcessTime
            // 
            this.txtProcessTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "ProcessTime", true));
            this.txtProcessTime.Enabled = false;
            this.txtProcessTime.EnableNull = true;
            this.txtProcessTime.ErropPr = null;
            this.txtProcessTime.Length = 0;
            this.txtProcessTime.Location = new System.Drawing.Point(344, 137);
            this.txtProcessTime.Max = 0;
            this.txtProcessTime.MaxStrLength = 0;
            this.txtProcessTime.Min = 0;
            this.txtProcessTime.MinStrLength = 0;
            this.txtProcessTime.Name = "txtProcessTime";
            this.txtProcessTime.Precision = 0;
            this.txtProcessTime.Size = new System.Drawing.Size(100, 21);
            this.txtProcessTime.TabIndex = 99;
            this.txtProcessTime.ToolTipValid = null;
            this.txtProcessTime.ValidEable = true;
            this.txtProcessTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(261, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 98;
            this.label20.Text = "全程用时[M]:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(261, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 98;
            this.label15.Text = "作业用时[M]:";
            // 
            // txtWeight_SprayTank
            // 
            this.txtWeight_SprayTank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Weight_SprayTank", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtWeight_SprayTank.Enabled = false;
            this.txtWeight_SprayTank.EnableNull = true;
            this.txtWeight_SprayTank.ErropPr = null;
            this.txtWeight_SprayTank.Length = 0;
            this.txtWeight_SprayTank.Location = new System.Drawing.Point(562, 136);
            this.txtWeight_SprayTank.Max = 0;
            this.txtWeight_SprayTank.MaxStrLength = 0;
            this.txtWeight_SprayTank.Min = 0;
            this.txtWeight_SprayTank.MinStrLength = 0;
            this.txtWeight_SprayTank.Name = "txtWeight_SprayTank";
            this.txtWeight_SprayTank.Precision = 0;
            this.txtWeight_SprayTank.Size = new System.Drawing.Size(100, 21);
            this.txtWeight_SprayTank.TabIndex = 99;
            this.txtWeight_SprayTank.ToolTipValid = null;
            this.txtWeight_SprayTank.ValidEable = true;
            this.txtWeight_SprayTank.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(467, 139);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(89, 12);
            this.label55.TabIndex = 98;
            this.label55.Text = "喷吹罐重量[T]:";
            // 
            // txtWeight_MatTank
            // 
            this.txtWeight_MatTank.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Weight_MatTank", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtWeight_MatTank.Enabled = false;
            this.txtWeight_MatTank.EnableNull = true;
            this.txtWeight_MatTank.ErropPr = null;
            this.txtWeight_MatTank.Length = 0;
            this.txtWeight_MatTank.Location = new System.Drawing.Point(562, 99);
            this.txtWeight_MatTank.Max = 0;
            this.txtWeight_MatTank.MaxStrLength = 0;
            this.txtWeight_MatTank.Min = 0;
            this.txtWeight_MatTank.MinStrLength = 0;
            this.txtWeight_MatTank.Name = "txtWeight_MatTank";
            this.txtWeight_MatTank.Precision = 0;
            this.txtWeight_MatTank.Size = new System.Drawing.Size(100, 21);
            this.txtWeight_MatTank.TabIndex = 99;
            this.txtWeight_MatTank.ToolTipValid = null;
            this.txtWeight_MatTank.ValidEable = true;
            this.txtWeight_MatTank.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(467, 102);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(89, 12);
            this.label54.TabIndex = 98;
            this.label54.Text = "储料罐重量[T]:";
            // 
            // txtMat_Consume
            // 
            this.txtMat_Consume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Mat_Consume", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "N2"));
            this.txtMat_Consume.Enabled = false;
            this.txtMat_Consume.EnableNull = true;
            this.txtMat_Consume.ErropPr = null;
            this.txtMat_Consume.Length = 0;
            this.txtMat_Consume.Location = new System.Drawing.Point(562, 61);
            this.txtMat_Consume.Max = 0;
            this.txtMat_Consume.MaxStrLength = 0;
            this.txtMat_Consume.Min = 0;
            this.txtMat_Consume.MinStrLength = 0;
            this.txtMat_Consume.Name = "txtMat_Consume";
            this.txtMat_Consume.Precision = 0;
            this.txtMat_Consume.Size = new System.Drawing.Size(100, 21);
            this.txtMat_Consume.TabIndex = 99;
            this.txtMat_Consume.ToolTipValid = null;
            this.txtMat_Consume.ValidEable = true;
            this.txtMat_Consume.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 12);
            this.label22.TabIndex = 98;
            this.label22.Text = "颗粒镁消耗[Kg]:";
            // 
            // txtBlowTimeTotal
            // 
            this.txtBlowTimeTotal.Enabled = false;
            this.txtBlowTimeTotal.EnableNull = true;
            this.txtBlowTimeTotal.ErropPr = null;
            this.txtBlowTimeTotal.Length = 0;
            this.txtBlowTimeTotal.Location = new System.Drawing.Point(344, 100);
            this.txtBlowTimeTotal.Max = 0;
            this.txtBlowTimeTotal.MaxStrLength = 0;
            this.txtBlowTimeTotal.Min = 0;
            this.txtBlowTimeTotal.MinStrLength = 0;
            this.txtBlowTimeTotal.Name = "txtBlowTimeTotal";
            this.txtBlowTimeTotal.Precision = 0;
            this.txtBlowTimeTotal.Size = new System.Drawing.Size(100, 21);
            this.txtBlowTimeTotal.TabIndex = 99;
            this.txtBlowTimeTotal.ToolTipValid = null;
            this.txtBlowTimeTotal.ValidEable = true;
            this.txtBlowTimeTotal.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "L3DataTable";
            this.bindingSource1.DataSource = this.dsddd;
            // 
            // dsddd
            // 
            this.dsddd.AutoLoad = true;
            this.dsddd.AutoSubscribe = false;
            this.dsddd.DataSetName = "L3DataSet";
            this.dsddd.DeleteMethod = "";
            this.dsddd.InsertMethod = "";
            this.dsddd.L3DataAdapter = this.Adapter;
            this.dsddd.LoadEvent = "";
            this.dsddd.LoadTrigger = null;
            this.dsddd.RefreshValve = 1000;
            this.dsddd.SourceCommand = null;
            this.dsddd.SourceCondition = "";
            this.dsddd.SourceMethod = "";
            this.dsddd.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsddd.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Process_Data";
            this.dsddd.SubscribeTarget = "";
            this.dsddd.Tables.AddRange(new System.Data.DataTable[] {
            this.schemads});
            this.dsddd.UpdateEvent = "";
            this.dsddd.UpdateMethod = "";
            this.dsddd.UpdateTrigger = null;
            // 
            // schemads
            // 
            this.schemads.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsL3DataTableMaterialID,
            this.coldsL3DataTableBlowTime});
            this.schemads.TableName = "L3DataTable";
            // 
            // coldsL3DataTableMaterialID
            // 
            this.coldsL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsL3DataTableMaterialID.Namespace = "";
            // 
            // coldsL3DataTableBlowTime
            // 
            this.coldsL3DataTableBlowTime.Caption = "BlowTime";
            this.coldsL3DataTableBlowTime.ColumnName = "BlowTime";
            this.coldsL3DataTableBlowTime.DataType = typeof(int);
            this.coldsL3DataTableBlowTime.Namespace = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 98;
            this.label14.Text = "喷吹用时[S]:";
            // 
            // txtRemoveSlagTime
            // 
            this.txtRemoveSlagTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "RemoveSlagTime", true));
            this.txtRemoveSlagTime.Enabled = false;
            this.txtRemoveSlagTime.EnableNull = true;
            this.txtRemoveSlagTime.ErropPr = null;
            this.txtRemoveSlagTime.Length = 0;
            this.txtRemoveSlagTime.Location = new System.Drawing.Point(344, 61);
            this.txtRemoveSlagTime.Max = 0;
            this.txtRemoveSlagTime.MaxStrLength = 0;
            this.txtRemoveSlagTime.Min = 0;
            this.txtRemoveSlagTime.MinStrLength = 0;
            this.txtRemoveSlagTime.Name = "txtRemoveSlagTime";
            this.txtRemoveSlagTime.Precision = 0;
            this.txtRemoveSlagTime.Size = new System.Drawing.Size(100, 21);
            this.txtRemoveSlagTime.TabIndex = 99;
            this.txtRemoveSlagTime.ToolTipValid = null;
            this.txtRemoveSlagTime.ValidEable = true;
            this.txtRemoveSlagTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 98;
            this.label13.Text = "捞渣用时[M]:";
            // 
            // txtPreRemoveSlagTime
            // 
            this.txtPreRemoveSlagTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "PreRemoveSlagTime", true));
            this.txtPreRemoveSlagTime.Enabled = false;
            this.txtPreRemoveSlagTime.EnableNull = true;
            this.txtPreRemoveSlagTime.ErropPr = null;
            this.txtPreRemoveSlagTime.Length = 0;
            this.txtPreRemoveSlagTime.Location = new System.Drawing.Point(344, 26);
            this.txtPreRemoveSlagTime.Max = 0;
            this.txtPreRemoveSlagTime.MaxStrLength = 0;
            this.txtPreRemoveSlagTime.Min = 0;
            this.txtPreRemoveSlagTime.MinStrLength = 0;
            this.txtPreRemoveSlagTime.Name = "txtPreRemoveSlagTime";
            this.txtPreRemoveSlagTime.Precision = 0;
            this.txtPreRemoveSlagTime.Size = new System.Drawing.Size(100, 21);
            this.txtPreRemoveSlagTime.TabIndex = 99;
            this.txtPreRemoveSlagTime.ToolTipValid = null;
            this.txtPreRemoveSlagTime.ValidEable = true;
            this.txtPreRemoveSlagTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 98;
            this.label9.Text = "预捞渣用时[M]:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(521, 214);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 12);
            this.label57.TabIndex = 94;
            this.label57.Text = "去向:";
            // 
            // txtDeS_Operator
            // 
            this.txtDeS_Operator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "DeS_Operator", true));
            this.txtDeS_Operator.Enabled = false;
            this.txtDeS_Operator.EnableNull = true;
            this.txtDeS_Operator.ErropPr = null;
            this.txtDeS_Operator.Length = 0;
            this.txtDeS_Operator.Location = new System.Drawing.Point(116, 173);
            this.txtDeS_Operator.Max = 0;
            this.txtDeS_Operator.MaxStrLength = 0;
            this.txtDeS_Operator.Min = 0;
            this.txtDeS_Operator.MinStrLength = 0;
            this.txtDeS_Operator.Name = "txtDeS_Operator";
            this.txtDeS_Operator.Precision = 0;
            this.txtDeS_Operator.Size = new System.Drawing.Size(102, 21);
            this.txtDeS_Operator.TabIndex = 99;
            this.txtDeS_Operator.ToolTipValid = null;
            this.txtDeS_Operator.ValidEable = true;
            this.txtDeS_Operator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(521, 177);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 12);
            this.label56.TabIndex = 94;
            this.label56.Text = "状态:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 98;
            this.label5.Text = "脱硫工:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(521, 249);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 12);
            this.label58.TabIndex = 96;
            this.label58.Text = "班次:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(497, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 94;
            this.label21.Text = "脱硫类型:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 94;
            this.label3.Text = "是否脱硫:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 92;
            this.label12.Text = "捞渣工位:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 92;
            this.label11.Text = "脱硫工位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "罐号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "铁次号:";
            // 
            // fLPBase
            // 
            this.fLPBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPBase.Controls.Add(this.btnBaseCancel);
            this.fLPBase.Controls.Add(this.btnBaseConfirm);
            this.fLPBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPBase.Location = new System.Drawing.Point(3, 348);
            this.fLPBase.Name = "fLPBase";
            this.fLPBase.Size = new System.Drawing.Size(957, 33);
            this.fLPBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(875, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // btnBaseConfirm
            // 
            this.btnBaseConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnBaseConfirm.Name = "btnBaseConfirm";
            this.btnBaseConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBaseConfirm.TabIndex = 86;
            this.btnBaseConfirm.Text = "确认";
            this.btnBaseConfirm.UseVisualStyleBackColor = true;
            this.btnBaseConfirm.Click += new System.EventHandler(this.btnBaseConfirm_Click);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.hmiRootPanel7);
            this.tabProcess.Location = new System.Drawing.Point(4, 21);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(965, 386);
            this.tabProcess.TabIndex = 14;
            this.tabProcess.Text = "脱硫数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel7
            // 
            this.hmiRootPanel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel7.Controls.Add(this.dvProcess);
            this.hmiRootPanel7.Controls.Add(this.FLPProcess);
            this.hmiRootPanel7.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel7.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel7.Name = "hmiRootPanel7";
            this.hmiRootPanel7.Size = new System.Drawing.Size(957, 378);
            this.hmiRootPanel7.TabIndex = 90;
            // 
            // dvProcess
            // 
            this.dvProcess.AllowUserToAddRows = false;
            this.dvProcess.AllowUserToDeleteRows = false;
            this.dvProcess.AutoGenerateColumns = false;
            this.dvProcess.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.AreaID,
            this.sBDataGridViewTextBoxColumn,
            this.sADataGridViewTextBoxColumn,
            this.pBDataGridViewTextBoxColumn,
            this.pADataGridViewTextBoxColumn,
            this.matConsumeDataGridViewTextBoxColumn,
            this.lanceNoDataGridViewTextBoxColumn,
            this.lanceAgeDataGridViewTextBoxColumn,
            this.blowTimeDataGridViewTextBoxColumn,
            this.blowBeginTimeDataGridViewTextBoxColumn,
            this.blowEndTimeDataGridViewTextBoxColumn});
            this.dvProcess.DataSource = this.bsProcess;
            this.dvProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProcess.Location = new System.Drawing.Point(0, 25);
            this.dvProcess.Name = "dvProcess";
            this.dvProcess.RowTemplate.Height = 23;
            this.dvProcess.Size = new System.Drawing.Size(953, 316);
            this.dvProcess.TabIndex = 97;
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "喷吹号";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "铁水ID";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            // 
            // AreaID
            // 
            this.AreaID.DataPropertyName = "AreaID";
            this.AreaID.DataSource = this.dsUintID;
            this.AreaID.DisplayMember = "L3DataTable.code_des";
            this.AreaID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.AreaID.HeaderText = "工位";
            this.AreaID.Name = "AreaID";
            this.AreaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AreaID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AreaID.ValueMember = "L3DataTable.code";
            // 
            // sBDataGridViewTextBoxColumn
            // 
            this.sBDataGridViewTextBoxColumn.DataPropertyName = "S_B";
            dataGridViewCellStyle9.Format = "N3";
            dataGridViewCellStyle9.NullValue = "0";
            this.sBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.sBDataGridViewTextBoxColumn.HeaderText = "脱前硫(%)";
            this.sBDataGridViewTextBoxColumn.Name = "sBDataGridViewTextBoxColumn";
            // 
            // sADataGridViewTextBoxColumn
            // 
            this.sADataGridViewTextBoxColumn.DataPropertyName = "S_A";
            dataGridViewCellStyle10.Format = "N3";
            dataGridViewCellStyle10.NullValue = "0";
            this.sADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.sADataGridViewTextBoxColumn.HeaderText = "脱后硫(%)";
            this.sADataGridViewTextBoxColumn.Name = "sADataGridViewTextBoxColumn";
            // 
            // pBDataGridViewTextBoxColumn
            // 
            this.pBDataGridViewTextBoxColumn.DataPropertyName = "P_B";
            dataGridViewCellStyle11.Format = "N3";
            dataGridViewCellStyle11.NullValue = "0";
            this.pBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.pBDataGridViewTextBoxColumn.HeaderText = "脱前磷(%)";
            this.pBDataGridViewTextBoxColumn.Name = "pBDataGridViewTextBoxColumn";
            // 
            // pADataGridViewTextBoxColumn
            // 
            this.pADataGridViewTextBoxColumn.DataPropertyName = "P_A";
            dataGridViewCellStyle12.Format = "N3";
            dataGridViewCellStyle12.NullValue = "0";
            this.pADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.pADataGridViewTextBoxColumn.HeaderText = "脱后磷(%)";
            this.pADataGridViewTextBoxColumn.Name = "pADataGridViewTextBoxColumn";
            // 
            // matConsumeDataGridViewTextBoxColumn
            // 
            this.matConsumeDataGridViewTextBoxColumn.DataPropertyName = "Mat_Consume";
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0";
            this.matConsumeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.matConsumeDataGridViewTextBoxColumn.HeaderText = "颗粒镁消耗[Kg]";
            this.matConsumeDataGridViewTextBoxColumn.Name = "matConsumeDataGridViewTextBoxColumn";
            // 
            // lanceNoDataGridViewTextBoxColumn
            // 
            this.lanceNoDataGridViewTextBoxColumn.DataPropertyName = "LanceNo";
            this.lanceNoDataGridViewTextBoxColumn.HeaderText = "喷枪号";
            this.lanceNoDataGridViewTextBoxColumn.Name = "lanceNoDataGridViewTextBoxColumn";
            // 
            // lanceAgeDataGridViewTextBoxColumn
            // 
            this.lanceAgeDataGridViewTextBoxColumn.DataPropertyName = "LanceAge";
            this.lanceAgeDataGridViewTextBoxColumn.HeaderText = "枪龄";
            this.lanceAgeDataGridViewTextBoxColumn.Name = "lanceAgeDataGridViewTextBoxColumn";
            // 
            // blowTimeDataGridViewTextBoxColumn
            // 
            this.blowTimeDataGridViewTextBoxColumn.DataPropertyName = "BlowTime";
            this.blowTimeDataGridViewTextBoxColumn.HeaderText = "喷吹用时[S]";
            this.blowTimeDataGridViewTextBoxColumn.Name = "blowTimeDataGridViewTextBoxColumn";
            // 
            // blowBeginTimeDataGridViewTextBoxColumn
            // 
            this.blowBeginTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.blowBeginTimeDataGridViewTextBoxColumn.DataPropertyName = "BlowBeginTime";
            this.blowBeginTimeDataGridViewTextBoxColumn.HeaderText = "喷吹开始时刻";
            this.blowBeginTimeDataGridViewTextBoxColumn.Name = "blowBeginTimeDataGridViewTextBoxColumn";
            this.blowBeginTimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // blowEndTimeDataGridViewTextBoxColumn
            // 
            this.blowEndTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.blowEndTimeDataGridViewTextBoxColumn.DataPropertyName = "BlowEndTime";
            this.blowEndTimeDataGridViewTextBoxColumn.HeaderText = "喷吹结束时刻";
            this.blowEndTimeDataGridViewTextBoxColumn.Name = "blowEndTimeDataGridViewTextBoxColumn";
            this.blowEndTimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // bsProcess
            // 
            this.bsProcess.DataMember = "L3DataTable";
            this.bsProcess.DataSource = this.dsProcess;
            // 
            // dsProcess
            // 
            this.dsProcess.AutoLoad = true;
            this.dsProcess.AutoSubscribe = false;
            this.dsProcess.DataSetName = "L3DataSet";
            this.dsProcess.DeleteMethod = "";
            this.dsProcess.InsertMethod = "";
            this.dsProcess.L3DataAdapter = this.Adapter;
            this.dsProcess.LoadEvent = "Click";
            this.dsProcess.LoadTrigger = null;
            this.dsProcess.RefreshValve = 1000;
            this.dsProcess.SourceCommand = null;
            this.dsProcess.SourceCondition = "1=2";
            this.dsProcess.SourceMethod = "";
            this.dsProcess.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcess.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Process_Data";
            this.dsProcess.SubscribeTarget = "";
            this.dsProcess.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcess});
            this.dsProcess.UpdateEvent = "";
            this.dsProcess.UpdateMethod = "";
            this.dsProcess.UpdateTrigger = null;
            // 
            // schemadsProcess
            // 
            this.schemadsProcess.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessL3DataTableGUID,
            this.coldsProcessL3DataTableName,
            this.coldsProcessL3DataTableTreatNo,
            this.coldsProcessL3DataTableMaterialID,
            this.coldsProcessL3DataTableS_B,
            this.coldsProcessL3DataTableS_A,
            this.coldsProcessL3DataTableP_B,
            this.coldsProcessL3DataTableP_A,
            this.coldsProcessL3DataTableMat_Consume,
            this.coldsProcessL3DataTableLanceNo,
            this.coldsProcessL3DataTableLanceAge,
            this.coldsProcessL3DataTableBlowTime,
            this.coldsProcessL3DataTableBlowBeginTime,
            this.coldsProcessL3DataTableBlowEndTime,
            this.coldsProcessL3DataTableAreaID});
            this.schemadsProcess.TableName = "L3DataTable";
            // 
            // coldsProcessL3DataTableGUID
            // 
            this.coldsProcessL3DataTableGUID.Caption = "GUID";
            this.coldsProcessL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcessL3DataTableGUID.Namespace = "";
            // 
            // coldsProcessL3DataTableName
            // 
            this.coldsProcessL3DataTableName.Caption = "Name";
            this.coldsProcessL3DataTableName.ColumnName = "Name";
            this.coldsProcessL3DataTableName.Namespace = "";
            // 
            // coldsProcessL3DataTableTreatNo
            // 
            this.coldsProcessL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.Namespace = "";
            // 
            // coldsProcessL3DataTableMaterialID
            // 
            this.coldsProcessL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.Namespace = "";
            // 
            // coldsProcessL3DataTableS_B
            // 
            this.coldsProcessL3DataTableS_B.Caption = "S_B";
            this.coldsProcessL3DataTableS_B.ColumnName = "S_B";
            this.coldsProcessL3DataTableS_B.DataType = typeof(double);
            this.coldsProcessL3DataTableS_B.Namespace = "";
            // 
            // coldsProcessL3DataTableS_A
            // 
            this.coldsProcessL3DataTableS_A.Caption = "S_A";
            this.coldsProcessL3DataTableS_A.ColumnName = "S_A";
            this.coldsProcessL3DataTableS_A.DataType = typeof(double);
            this.coldsProcessL3DataTableS_A.Namespace = "";
            // 
            // coldsProcessL3DataTableP_B
            // 
            this.coldsProcessL3DataTableP_B.Caption = "P_B";
            this.coldsProcessL3DataTableP_B.ColumnName = "P_B";
            this.coldsProcessL3DataTableP_B.DataType = typeof(double);
            this.coldsProcessL3DataTableP_B.Namespace = "";
            // 
            // coldsProcessL3DataTableP_A
            // 
            this.coldsProcessL3DataTableP_A.Caption = "P_A";
            this.coldsProcessL3DataTableP_A.ColumnName = "P_A";
            this.coldsProcessL3DataTableP_A.DataType = typeof(double);
            this.coldsProcessL3DataTableP_A.Namespace = "";
            // 
            // coldsProcessL3DataTableMat_Consume
            // 
            this.coldsProcessL3DataTableMat_Consume.Caption = "Mat_Consume";
            this.coldsProcessL3DataTableMat_Consume.ColumnName = "Mat_Consume";
            this.coldsProcessL3DataTableMat_Consume.DataType = typeof(double);
            this.coldsProcessL3DataTableMat_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableLanceNo
            // 
            this.coldsProcessL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsProcessL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsProcessL3DataTableLanceNo.Namespace = "";
            // 
            // coldsProcessL3DataTableLanceAge
            // 
            this.coldsProcessL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsProcessL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsProcessL3DataTableLanceAge.DataType = typeof(int);
            this.coldsProcessL3DataTableLanceAge.Namespace = "";
            // 
            // coldsProcessL3DataTableBlowTime
            // 
            this.coldsProcessL3DataTableBlowTime.Caption = "BlowTime";
            this.coldsProcessL3DataTableBlowTime.ColumnName = "BlowTime";
            this.coldsProcessL3DataTableBlowTime.DataType = typeof(int);
            this.coldsProcessL3DataTableBlowTime.Namespace = "";
            // 
            // coldsProcessL3DataTableBlowBeginTime
            // 
            this.coldsProcessL3DataTableBlowBeginTime.Caption = "BlowBeginTime";
            this.coldsProcessL3DataTableBlowBeginTime.ColumnName = "BlowBeginTime";
            this.coldsProcessL3DataTableBlowBeginTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableBlowBeginTime.Namespace = "";
            // 
            // coldsProcessL3DataTableBlowEndTime
            // 
            this.coldsProcessL3DataTableBlowEndTime.Caption = "BlowEndTime";
            this.coldsProcessL3DataTableBlowEndTime.ColumnName = "BlowEndTime";
            this.coldsProcessL3DataTableBlowEndTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableBlowEndTime.Namespace = "";
            // 
            // coldsProcessL3DataTableAreaID
            // 
            this.coldsProcessL3DataTableAreaID.Caption = "AreaID";
            this.coldsProcessL3DataTableAreaID.ColumnName = "AreaID";
            this.coldsProcessL3DataTableAreaID.Namespace = "";
            // 
            // FLPProcess
            // 
            this.FLPProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FLPProcess.Controls.Add(this.btnProcessCancel);
            this.FLPProcess.Controls.Add(this.btnProcessConfirm);
            this.FLPProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FLPProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FLPProcess.Location = new System.Drawing.Point(0, 341);
            this.FLPProcess.Name = "FLPProcess";
            this.FLPProcess.Size = new System.Drawing.Size(953, 33);
            this.FLPProcess.TabIndex = 96;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(871, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // btnProcessConfirm
            // 
            this.btnProcessConfirm.Location = new System.Drawing.Point(790, 3);
            this.btnProcessConfirm.Name = "btnProcessConfirm";
            this.btnProcessConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnProcessConfirm.TabIndex = 86;
            this.btnProcessConfirm.Text = "确认";
            this.btnProcessConfirm.UseVisualStyleBackColor = true;
            this.btnProcessConfirm.Visible = false;
            this.btnProcessConfirm.Click += new System.EventHandler(this.btnProcessConfirm_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsProcess;
            this.bindingNavigator1.CountItem = this.toolStripLabel10;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton21,
            this.toolStripButton22,
            this.toolStripSeparator16,
            this.toolStripTextBox6,
            this.toolStripLabel10,
            this.toolStripSeparator17,
            this.toolStripButton23,
            this.toolStripButton24,
            this.toolStripSeparator18});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton21;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton24;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton23;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton22;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox6;
            this.bindingNavigator1.Size = new System.Drawing.Size(953, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel10.Text = "/ {0}";
            this.toolStripLabel10.ToolTipText = "总项数";
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.RightToLeftAutoMirrorImage = true;
            this.toolStripButton21.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton21.Text = "移到第一条记录";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "移到上一条记录";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.AccessibleName = "位置";
            this.toolStripTextBox6.AutoSize = false;
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox6.Text = "0";
            this.toolStripTextBox6.ToolTipText = "当前位置";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "移到下一条记录";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "移到最后一条记录";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // tabStatus
            // 
            this.tabStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatus.Controls.Add(this.dvStatus);
            this.tabStatus.Controls.Add(this.bnStatus);
            this.tabStatus.Controls.Add(this.fLPStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 21);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(965, 386);
            this.tabStatus.TabIndex = 6;
            this.tabStatus.Text = "状态数据";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // dvStatus
            // 
            this.dvStatus.AllowUserToAddRows = false;
            this.dvStatus.AllowUserToDeleteRows = false;
            this.dvStatus.AutoGenerateColumns = false;
            this.dvStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObjectDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn});
            this.dvStatus.DataSource = this.bsStatus;
            this.dvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStatus.Location = new System.Drawing.Point(3, 28);
            this.dvStatus.Name = "dvStatus";
            this.dvStatus.RowTemplate.Height = 23;
            this.dvStatus.Size = new System.Drawing.Size(957, 320);
            this.dvStatus.TabIndex = 93;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "对象标识";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AreaID";
            this.dataGridViewTextBoxColumn1.DataSource = this.dsUintID;
            this.dataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.code_des";
            this.dataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn1.HeaderText = "工位";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "L3DataTable.code";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsDeSStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "作业状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            this.changeTimeDataGridViewTextBoxColumn.HeaderText = "作业状态变化时刻";
            this.changeTimeDataGridViewTextBoxColumn.Name = "changeTimeDataGridViewTextBoxColumn";
            this.changeTimeDataGridViewTextBoxColumn.Width = 126;
            // 
            // bsStatus
            // 
            this.bsStatus.DataMember = "L3DataTable";
            this.bsStatus.DataSource = this.dsStatus;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = "";
            this.dsStatus.InsertMethod = "";
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "1=2";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Process_Status";
            this.dsStatus.SubscribeTarget = "";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableGUID,
            this.coldsStatusL3DataTableName,
            this.coldsStatusL3DataTableID_Object,
            this.coldsStatusL3DataTableStatus,
            this.coldsStatusL3DataTableChange_Time,
            this.coldsStatusL3DataTableAreaID});
            this.schemadsStatus.TableName = "L3DataTable";
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
            // coldsStatusL3DataTableID_Object
            // 
            this.coldsStatusL3DataTableID_Object.Caption = "ID_Object";
            this.coldsStatusL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsStatusL3DataTableID_Object.Namespace = "";
            // 
            // coldsStatusL3DataTableStatus
            // 
            this.coldsStatusL3DataTableStatus.Caption = "Status";
            this.coldsStatusL3DataTableStatus.ColumnName = "Status";
            this.coldsStatusL3DataTableStatus.DataType = typeof(short);
            this.coldsStatusL3DataTableStatus.Namespace = "";
            // 
            // coldsStatusL3DataTableChange_Time
            // 
            this.coldsStatusL3DataTableChange_Time.Caption = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.ColumnName = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coldsStatusL3DataTableChange_Time.Namespace = "";
            // 
            // coldsStatusL3DataTableAreaID
            // 
            this.coldsStatusL3DataTableAreaID.Caption = "AreaID";
            this.coldsStatusL3DataTableAreaID.ColumnName = "AreaID";
            this.coldsStatusL3DataTableAreaID.Namespace = "";
            // 
            // bnStatus
            // 
            this.bnStatus.AddNewItem = null;
            this.bnStatus.BindingSource = this.bsStatus;
            this.bnStatus.CountItem = this.bindingNavigatorCountItem4;
            this.bnStatus.DeleteItem = null;
            this.bnStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.btnAddStatus,
            this.btnDelStatus,
            this.toolStripButton28});
            this.bnStatus.Location = new System.Drawing.Point(3, 3);
            this.bnStatus.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bnStatus.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bnStatus.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bnStatus.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bnStatus.Name = "bnStatus";
            this.bnStatus.PositionItem = this.bindingNavigatorPositionItem4;
            this.bnStatus.Size = new System.Drawing.Size(957, 25);
            this.bnStatus.TabIndex = 92;
            this.bnStatus.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem4.Text = "/ {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "位置";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStatus.Image")));
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.RightToLeftAutoMirrorImage = true;
            this.btnAddStatus.Size = new System.Drawing.Size(23, 22);
            this.btnAddStatus.Text = "新添";
            this.btnAddStatus.Visible = false;
            // 
            // btnDelStatus
            // 
            this.btnDelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnDelStatus.Image")));
            this.btnDelStatus.Name = "btnDelStatus";
            this.btnDelStatus.RightToLeftAutoMirrorImage = true;
            this.btnDelStatus.Size = new System.Drawing.Size(23, 22);
            this.btnDelStatus.Text = "删除";
            this.btnDelStatus.Visible = false;
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton28.Text = "toolStripButton25";
            this.toolStripButton28.ToolTipText = "刷新";
            this.toolStripButton28.Visible = false;
            // 
            // fLPStatus
            // 
            this.fLPStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPStatus.Controls.Add(this.btnStatusCancel);
            this.fLPStatus.Controls.Add(this.btnStatusConfirm);
            this.fLPStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPStatus.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPStatus.Location = new System.Drawing.Point(3, 348);
            this.fLPStatus.Name = "fLPStatus";
            this.fLPStatus.Size = new System.Drawing.Size(957, 33);
            this.fLPStatus.TabIndex = 91;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.Location = new System.Drawing.Point(875, 3);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStatusCancel.TabIndex = 87;
            this.btnStatusCancel.Text = "取消";
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // btnStatusConfirm
            // 
            this.btnStatusConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnStatusConfirm.Name = "btnStatusConfirm";
            this.btnStatusConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnStatusConfirm.TabIndex = 86;
            this.btnStatusConfirm.Text = "确认";
            this.btnStatusConfirm.UseVisualStyleBackColor = true;
            this.btnStatusConfirm.Visible = false;
            this.btnStatusConfirm.Click += new System.EventHandler(this.btnStatusConfirm_Click);
            // 
            // tabRunTime
            // 
            this.tabRunTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRunTime.Controls.Add(this.hmiRootPanel3);
            this.tabRunTime.Location = new System.Drawing.Point(4, 21);
            this.tabRunTime.Name = "tabRunTime";
            this.tabRunTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabRunTime.Size = new System.Drawing.Size(965, 386);
            this.tabRunTime.TabIndex = 11;
            this.tabRunTime.Text = "实时数据";
            this.tabRunTime.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel3
            // 
            this.hmiRootPanel3.Controls.Add(this.dvRunTime);
            this.hmiRootPanel3.Controls.Add(this.bnRemark);
            this.hmiRootPanel3.Controls.Add(this.fLPRunTime);
            this.hmiRootPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel3.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel3.Name = "hmiRootPanel3";
            this.hmiRootPanel3.Size = new System.Drawing.Size(957, 378);
            this.hmiRootPanel3.TabIndex = 91;
            // 
            // dvRunTime
            // 
            this.dvRunTime.AllowUserToAddRows = false;
            this.dvRunTime.AllowUserToDeleteRows = false;
            this.dvRunTime.AutoGenerateColumns = false;
            this.dvRunTime.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRunTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRunTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObjectDataGridViewTextBoxColumn1,
            this.treatNoDataGridViewTextBoxColumn1,
            this.pressureDataGridViewTextBoxColumn,
            this.flowDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.catchCountDataGridViewTextBoxColumn,
            this.catchTimeDataGridViewTextBoxColumn});
            this.dvRunTime.DataSource = this.bsRunTime;
            this.dvRunTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRunTime.Location = new System.Drawing.Point(0, 25);
            this.dvRunTime.Name = "dvRunTime";
            this.dvRunTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvRunTime.RowTemplate.Height = 23;
            this.dvRunTime.Size = new System.Drawing.Size(957, 320);
            this.dvRunTime.TabIndex = 94;
            // 
            // iDObjectDataGridViewTextBoxColumn1
            // 
            this.iDObjectDataGridViewTextBoxColumn1.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn1.HeaderText = "对象标识";
            this.iDObjectDataGridViewTextBoxColumn1.Name = "iDObjectDataGridViewTextBoxColumn1";
            // 
            // treatNoDataGridViewTextBoxColumn1
            // 
            this.treatNoDataGridViewTextBoxColumn1.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn1.HeaderText = "喷吹号";
            this.treatNoDataGridViewTextBoxColumn1.Name = "treatNoDataGridViewTextBoxColumn1";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            dataGridViewCellStyle14.Format = "N3";
            dataGridViewCellStyle14.NullValue = "0";
            this.pressureDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.pressureDataGridViewTextBoxColumn.HeaderText = "主吹压力(MPa)";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            this.pressureDataGridViewTextBoxColumn.Width = 72;
            // 
            // flowDataGridViewTextBoxColumn
            // 
            this.flowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.flowDataGridViewTextBoxColumn.DataPropertyName = "Flow";
            dataGridViewCellStyle15.Format = "N3";
            dataGridViewCellStyle15.NullValue = "0";
            this.flowDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.flowDataGridViewTextBoxColumn.HeaderText = "主吹流量(Nm3/h)";
            this.flowDataGridViewTextBoxColumn.Name = "flowDataGridViewTextBoxColumn";
            this.flowDataGridViewTextBoxColumn.Width = 110;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            dataGridViewCellStyle16.Format = "N3";
            dataGridViewCellStyle16.NullValue = "0";
            this.rateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.rateDataGridViewTextBoxColumn.HeaderText = "速率(kg/min)";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 94;
            // 
            // catchCountDataGridViewTextBoxColumn
            // 
            this.catchCountDataGridViewTextBoxColumn.DataPropertyName = "Catch_Count";
            this.catchCountDataGridViewTextBoxColumn.HeaderText = "采集次数";
            this.catchCountDataGridViewTextBoxColumn.Name = "catchCountDataGridViewTextBoxColumn";
            // 
            // catchTimeDataGridViewTextBoxColumn
            // 
            this.catchTimeDataGridViewTextBoxColumn.DataPropertyName = "Catch_Time";
            this.catchTimeDataGridViewTextBoxColumn.HeaderText = "采集时刻";
            this.catchTimeDataGridViewTextBoxColumn.Name = "catchTimeDataGridViewTextBoxColumn";
            // 
            // bsRunTime
            // 
            this.bsRunTime.DataMember = "L3DataTable";
            this.bsRunTime.DataSource = this.dsRunTime;
            // 
            // dsRunTime
            // 
            this.dsRunTime.AutoLoad = true;
            this.dsRunTime.AutoSubscribe = false;
            this.dsRunTime.DataSetName = "L3DataSet";
            this.dsRunTime.DeleteMethod = "";
            this.dsRunTime.InsertMethod = "";
            this.dsRunTime.L3DataAdapter = this.Adapter;
            this.dsRunTime.LoadEvent = "Click";
            this.dsRunTime.LoadTrigger = null;
            this.dsRunTime.RefreshValve = 1000;
            this.dsRunTime.SourceCommand = null;
            this.dsRunTime.SourceCondition = "1=2";
            this.dsRunTime.SourceMethod = "";
            this.dsRunTime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRunTime.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Runtime_Data";
            this.dsRunTime.SubscribeTarget = "";
            this.dsRunTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRunTime});
            this.dsRunTime.UpdateEvent = "";
            this.dsRunTime.UpdateMethod = "";
            this.dsRunTime.UpdateTrigger = null;
            // 
            // schemadsRunTime
            // 
            this.schemadsRunTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRunTimeL3DataTableGUID,
            this.coldsRunTimeL3DataTableName,
            this.coldsRunTimeL3DataTableID_Object,
            this.coldsRunTimeL3DataTableTreatNo,
            this.coldsRunTimeL3DataTablePressure,
            this.coldsRunTimeL3DataTableFlow,
            this.coldsRunTimeL3DataTableRate,
            this.coldsRunTimeL3DataTableCatch_Count,
            this.coldsRunTimeL3DataTableCatch_Time});
            this.schemadsRunTime.TableName = "L3DataTable";
            // 
            // coldsRunTimeL3DataTableGUID
            // 
            this.coldsRunTimeL3DataTableGUID.Caption = "GUID";
            this.coldsRunTimeL3DataTableGUID.ColumnName = "GUID";
            this.coldsRunTimeL3DataTableGUID.Namespace = "";
            // 
            // coldsRunTimeL3DataTableName
            // 
            this.coldsRunTimeL3DataTableName.Caption = "Name";
            this.coldsRunTimeL3DataTableName.ColumnName = "Name";
            this.coldsRunTimeL3DataTableName.Namespace = "";
            // 
            // coldsRunTimeL3DataTableID_Object
            // 
            this.coldsRunTimeL3DataTableID_Object.Caption = "ID_Object";
            this.coldsRunTimeL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsRunTimeL3DataTableID_Object.Namespace = "";
            // 
            // coldsRunTimeL3DataTableTreatNo
            // 
            this.coldsRunTimeL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsRunTimeL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsRunTimeL3DataTableTreatNo.Namespace = "";
            // 
            // coldsRunTimeL3DataTablePressure
            // 
            this.coldsRunTimeL3DataTablePressure.Caption = "Pressure";
            this.coldsRunTimeL3DataTablePressure.ColumnName = "Pressure";
            this.coldsRunTimeL3DataTablePressure.DataType = typeof(double);
            this.coldsRunTimeL3DataTablePressure.Namespace = "";
            // 
            // coldsRunTimeL3DataTableFlow
            // 
            this.coldsRunTimeL3DataTableFlow.Caption = "Flow";
            this.coldsRunTimeL3DataTableFlow.ColumnName = "Flow";
            this.coldsRunTimeL3DataTableFlow.DataType = typeof(double);
            this.coldsRunTimeL3DataTableFlow.Namespace = "";
            // 
            // coldsRunTimeL3DataTableRate
            // 
            this.coldsRunTimeL3DataTableRate.Caption = "Rate";
            this.coldsRunTimeL3DataTableRate.ColumnName = "Rate";
            this.coldsRunTimeL3DataTableRate.DataType = typeof(double);
            this.coldsRunTimeL3DataTableRate.Namespace = "";
            // 
            // coldsRunTimeL3DataTableCatch_Count
            // 
            this.coldsRunTimeL3DataTableCatch_Count.Caption = "Catch_Count";
            this.coldsRunTimeL3DataTableCatch_Count.ColumnName = "Catch_Count";
            this.coldsRunTimeL3DataTableCatch_Count.DataType = typeof(int);
            this.coldsRunTimeL3DataTableCatch_Count.Namespace = "";
            // 
            // coldsRunTimeL3DataTableCatch_Time
            // 
            this.coldsRunTimeL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsRunTimeL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsRunTimeL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsRunTimeL3DataTableCatch_Time.Namespace = "";
            // 
            // bnRemark
            // 
            this.bnRemark.AddNewItem = null;
            this.bnRemark.BindingSource = this.bsRunTime;
            this.bnRemark.CountItem = this.toolStripLabel1;
            this.bnRemark.DeleteItem = null;
            this.bnRemark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.btnRemarkAdd,
            this.btnRemarkDel});
            this.bnRemark.Location = new System.Drawing.Point(0, 0);
            this.bnRemark.MoveFirstItem = this.toolStripButton1;
            this.bnRemark.MoveLastItem = this.toolStripButton4;
            this.bnRemark.MoveNextItem = this.toolStripButton3;
            this.bnRemark.MovePreviousItem = this.toolStripButton2;
            this.bnRemark.Name = "bnRemark";
            this.bnRemark.PositionItem = this.toolStripTextBox1;
            this.bnRemark.Size = new System.Drawing.Size(957, 25);
            this.bnRemark.TabIndex = 93;
            this.bnRemark.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRemarkAdd
            // 
            this.btnRemarkAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemarkAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRemarkAdd.Image")));
            this.btnRemarkAdd.Name = "btnRemarkAdd";
            this.btnRemarkAdd.RightToLeftAutoMirrorImage = true;
            this.btnRemarkAdd.Size = new System.Drawing.Size(23, 22);
            this.btnRemarkAdd.Text = "新添";
            this.btnRemarkAdd.Visible = false;
            // 
            // btnRemarkDel
            // 
            this.btnRemarkDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemarkDel.Image = ((System.Drawing.Image)(resources.GetObject("btnRemarkDel.Image")));
            this.btnRemarkDel.Name = "btnRemarkDel";
            this.btnRemarkDel.RightToLeftAutoMirrorImage = true;
            this.btnRemarkDel.Size = new System.Drawing.Size(23, 22);
            this.btnRemarkDel.Text = "删除";
            this.btnRemarkDel.Visible = false;
            // 
            // fLPRunTime
            // 
            this.fLPRunTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPRunTime.Controls.Add(this.btnRunTimeCancel);
            this.fLPRunTime.Controls.Add(this.btnRunTimeConfirm);
            this.fLPRunTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPRunTime.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPRunTime.Location = new System.Drawing.Point(0, 345);
            this.fLPRunTime.Name = "fLPRunTime";
            this.fLPRunTime.Size = new System.Drawing.Size(957, 33);
            this.fLPRunTime.TabIndex = 92;
            // 
            // btnRunTimeCancel
            // 
            this.btnRunTimeCancel.Location = new System.Drawing.Point(875, 3);
            this.btnRunTimeCancel.Name = "btnRunTimeCancel";
            this.btnRunTimeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRunTimeCancel.TabIndex = 87;
            this.btnRunTimeCancel.Text = "取消";
            this.btnRunTimeCancel.UseVisualStyleBackColor = true;
            this.btnRunTimeCancel.Click += new System.EventHandler(this.btnRunTimeCancel_Click);
            // 
            // btnRunTimeConfirm
            // 
            this.btnRunTimeConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnRunTimeConfirm.Name = "btnRunTimeConfirm";
            this.btnRunTimeConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRunTimeConfirm.TabIndex = 86;
            this.btnRunTimeConfirm.Text = "确认";
            this.btnRunTimeConfirm.UseVisualStyleBackColor = true;
            this.btnRunTimeConfirm.Visible = false;
            this.btnRunTimeConfirm.Click += new System.EventHandler(this.btnRunTimeConfirm_Click);
            // 
            // coldsBaseL3DataTableTotalTime
            // 
            this.coldsBaseL3DataTableTotalTime.Caption = "TotalTime";
            this.coldsBaseL3DataTableTotalTime.ColumnName = "TotalTime";
            this.coldsBaseL3DataTableTotalTime.DataType = typeof(int);
            this.coldsBaseL3DataTableTotalTime.Namespace = "";
            // 
            // DeSTreatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 440);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.panel3);
            this.Name = "DeSTreatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "脱硫喷吹数据";
            this.Load += new System.EventHandler(this.DeSTreatInfoFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUintID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUintID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsddd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemads)).EndInit();
            this.fLPBase.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.hmiRootPanel7.ResumeLayout(false);
            this.hmiRootPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            this.FLPProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).EndInit();
            this.bnStatus.ResumeLayout(false);
            this.bnStatus.PerformLayout();
            this.fLPStatus.ResumeLayout(false);
            this.tabRunTime.ResumeLayout(false);
            this.hmiRootPanel3.ResumeLayout(false);
            this.hmiRootPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRunTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).EndInit();
            this.bnRemark.ResumeLayout(false);
            this.bnRemark.PerformLayout();
            this.fLPRunTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private PxDataValid.PxComboBox cmbDeS_Flag;
        private PxDataValid.PxComboBox cmbTeam;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fLPBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseConfirm;
        private System.Windows.Forms.TabPage tabProcess;
        private HMIBase.HMIRootPanel hmiRootPanel7;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.DataGridView dvStatus;
        private System.Windows.Forms.BindingNavigator bnStatus;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.ToolStripButton btnDelStatus;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.FlowLayoutPanel fLPStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusConfirm;
        private System.Windows.Forms.TabPage tabRunTime;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.DataGridView dvRunTime;
        private System.Windows.Forms.BindingNavigator bnRemark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRemarkAdd;
        private System.Windows.Forms.ToolStripButton btnRemarkDel;
        private System.Windows.Forms.FlowLayoutPanel fLPRunTime;
        private System.Windows.Forms.Button btnRunTimeCancel;
        private System.Windows.Forms.Button btnRunTimeConfirm;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsbase;
        private System.Data.DataColumn coldsbaseL3DataTableGUID;
        private System.Data.DataColumn coldsbaseL3DataTableName;
        private System.Data.DataColumn coldsbaseL3DataTableMaterialID;
        private System.Data.DataColumn coldsbaseL3DataTableTAP_No;
        private System.Data.DataColumn coldsbaseL3DataTableTPC_No;
        private System.Data.DataColumn coldsbaseL3DataTableDeS_UnitID;
        private System.Data.DataColumn coldsbaseL3DataTableRemoveSlag_UnitID;
        private System.Data.DataColumn coldsbaseL3DataTableDeS_Operator;
        private System.Data.DataColumn coldsbaseL3DataTableRemoveSlag_Operator;
        private System.Data.DataColumn coldsbaseL3DataTableDeS_Flag;
        private System.Data.DataColumn coldsbaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsbaseL3DataTablePreRemoveSlagTime;
        private System.Data.DataColumn coldsbaseL3DataTableRemoveSlagTime;
        private System.Data.DataColumn coldsbaseL3DataTableBlowTimeTotal;
        private System.Data.DataColumn coldsbaseL3DataTableProcessTime;
        private System.Data.DataColumn coldsbaseL3DataTableRemoveSlagCount;
        private System.Data.DataColumn coldsbaseL3DataTableGross_Weight;
        private System.Data.DataColumn coldsbaseL3DataTableEstimate_Weight;
        private System.Data.DataColumn coldsbaseL3DataTableNet_Weight;
        private System.Data.DataColumn coldsbaseL3DataTableDeSType;
        private System.Data.DataColumn coldsbaseL3DataTableMat_Consume;
        private System.Data.DataColumn coldsbaseL3DataTableWeight_MatTank;
        private System.Data.DataColumn coldsbaseL3DataTableWeight_SprayTank;
        private System.Data.DataColumn coldsbaseL3DataTableStatus;
        private System.Data.DataColumn coldsbaseL3DataTableDestination;
        private System.Data.DataColumn coldsbaseL3DataTableShift;
        private System.Data.DataColumn coldsbaseL3DataTableTeam;
        private System.Data.DataColumn coldsbaseL3DataTableNote;
        private System.Data.DataColumn coldsbaseL3DataTableLocked;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxComboBox cmbDeSType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private PxDataValid.PxComboBox cmbDestination;
        private PxDataValid.PxComboBox cmbStatus;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private PxDataValid.PxComboBox cmbShift;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.BindingSource bsBase;
        private PxDataValid.PxTextBox txtTAP_No;
        private PxDataValid.PxTextBox txtTPC_No;
        private PxDataValid.PxTextBox txtRemoveSlag_Operator;
        private PxDataValid.PxTextBox txtDeS_Operator;
        private PxDataValid.PxTextBox txtPreRemoveSlagTime;
        private PxDataValid.PxTextBox txtNet_Weight;
        private PxDataValid.PxTextBox txtEstimate_Weight;
        private PxDataValid.PxTextBox txtGross_Weight;
        private PxDataValid.PxTextBox txtRemoveSlagCount;
        private PxDataValid.PxTextBox txtProcessTime;
        private PxDataValid.PxTextBox txtWeight_SprayTank;
        private PxDataValid.PxTextBox txtWeight_MatTank;
        private PxDataValid.PxTextBox txtMat_Consume;
        private PxDataValid.PxTextBox txtBlowTimeTotal;
        private PxDataValid.PxTextBox txtRemoveSlagTime;
        private PxDataValid.PxTextBox txtMaterialID;
        private AppSvrHMI.L3DataSet dsProcess;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableTreatNo;
        private System.Data.DataColumn coldsProcessL3DataTableMaterialID;
        private System.Data.DataColumn coldsProcessL3DataTableS_B;
        private System.Data.DataColumn coldsProcessL3DataTableS_A;
        private System.Data.DataColumn coldsProcessL3DataTableP_B;
        private System.Data.DataColumn coldsProcessL3DataTableP_A;
        private System.Data.DataColumn coldsProcessL3DataTableMat_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableLanceNo;
        private System.Data.DataColumn coldsProcessL3DataTableLanceAge;
        private System.Data.DataColumn coldsProcessL3DataTableBlowTime;
        private System.Data.DataColumn coldsProcessL3DataTableBlowBeginTime;
        private System.Data.DataColumn coldsProcessL3DataTableBlowEndTime;
        private System.Windows.Forms.BindingSource bsProcess;
        private System.Windows.Forms.FlowLayoutPanel FLPProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnProcessConfirm;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsStatusL3DataTableID_Object;
        private System.Data.DataColumn coldsStatusL3DataTableStatus;
        private System.Data.DataColumn coldsStatusL3DataTableChange_Time;
        private System.Windows.Forms.BindingSource bsStatus;
        private AppSvrHMI.L3DataSet dsRunTime;
        private System.Data.DataTable schemadsRunTime;
        private System.Data.DataColumn coldsRunTimeL3DataTableGUID;
        private System.Data.DataColumn coldsRunTimeL3DataTableName;
        private System.Data.DataColumn coldsRunTimeL3DataTableID_Object;
        private System.Data.DataColumn coldsRunTimeL3DataTableTreatNo;
        private System.Data.DataColumn coldsRunTimeL3DataTablePressure;
        private System.Data.DataColumn coldsRunTimeL3DataTableFlow;
        private System.Data.DataColumn coldsRunTimeL3DataTableRate;
        private System.Data.DataColumn coldsRunTimeL3DataTableCatch_Count;
        private System.Data.DataColumn coldsRunTimeL3DataTableCatch_Time;
        private System.Windows.Forms.BindingSource bsRunTime;
        private System.Windows.Forms.DataGridView dvProcess;
        private AppSvrHMI.L3DataSet dsDeSStatus;
        private System.Data.DataTable schemadsDeSStatus;
        private System.Data.DataColumn coldsDeSStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsDeSStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsDeSType;
        private System.Data.DataTable schemadsDeSType;
        private System.Data.DataColumn coldsDeSTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDeSTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsDesination;
        private System.Data.DataTable schemadsDesination;
        private System.Data.DataColumn coldsDesinationL3DataTableCode_Des;
        private System.Data.DataColumn coldsDesinationL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsTeam2;
        private AppSvrHMI.L3DataSet dsShift2;
        private System.Data.DataTable schemadsTeam2;
        private System.Data.DataColumn coldsTeam2L3DataTableCode;
        private System.Data.DataColumn coldsTeam2L3DataTableCode_Des;
        private System.Data.DataTable schemadsShift2;
        private System.Data.DataColumn coldsShift2L3DataTableCode;
        private System.Data.DataColumn coldsShift2L3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsYesNo;
        private System.Data.DataTable schemadsYesNo;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Des;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchTimeDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsBaseL3DataTableMediator;
        private PxDataValid.PxTextBox txtMediator;
        private System.Windows.Forms.Label label8;
        private AppSvrHMI.L3DataSet dsUintID;
        private System.Data.DataTable schemadsUintID;
        private System.Data.DataColumn coldsUintIDL3DataTablecode;
        private System.Data.DataColumn coldsUintIDL3DataTablecode_des;
        private System.Windows.Forms.ComboBox cmbDeS_UnitID;
        private System.Windows.Forms.ComboBox cmbRemoveSlag_UnitID;
        private System.Data.DataColumn coldsProcessL3DataTableAreaID;
        private System.Data.DataColumn coldsStatusL3DataTableAreaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AreaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matConsumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blowTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blowBeginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blowEndTimeDataGridViewTextBoxColumn;
        private PxDataValid.PxTextBox txtTotalTime;
        private System.Windows.Forms.Label label20;
        private System.Data.DataColumn coldsBaseL3DataTableTotalTime;
        private System.Data.DataColumn AcoldsBaseL3DataTableTotalTime;
        private AppSvrHMI.L3DataSet dsUnitID2;
        private System.Data.DataTable schemadsUnitID2;
        private System.Data.DataColumn coldsUnitID2L3DataTablecode;
        private System.Data.DataColumn coldsUnitID2L3DataTablecode_des;
        private AppSvrHMI.L3DataSet dsddd;
        private System.Data.DataTable schemads;
        private System.Data.DataColumn coldsL3DataTableMaterialID;
        private System.Data.DataColumn coldsL3DataTableBlowTime;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}