namespace QualityMag.QualityStandard
{
    partial class CasterStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasterStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelFlux = new System.Windows.Forms.ToolStripButton();
            this.btnAddFlux = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tscmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.bsSpeed = new System.Windows.Forms.BindingSource(this.components);
            this.dsSpeed = new AppSvrHMI.L3DataSet();
            this.schemadsSpeed = new System.Data.DataTable();
            this.coldsSpeedL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableName = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSpeed_Fir_Min = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSpeed_Fir_Max = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSpeed_Min = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSpeed_Max = new System.Data.DataColumn();
            this.bsTundish = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundish = new AppSvrHMI.L3DataSet();
            this.schemadsTundish = new System.Data.DataTable();
            this.coldsTundishL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableName = new System.Data.DataColumn();
            this.coldsTundishL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundish_Temp_Min = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundish_Temp_Max = new System.Data.DataColumn();
            this.bsFlux = new System.Windows.Forms.BindingSource(this.components);
            this.dsFlux = new AppSvrHMI.L3DataSet();
            this.schemadsFlux = new System.Data.DataTable();
            this.coldsFluxL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsFluxL3DataTableTundish_Flux_Name = new System.Data.DataColumn();
            this.coldsFluxL3DataTableTundish_Flux_Weight = new System.Data.DataColumn();
            this.coldsFluxL3DataTableGUID = new System.Data.DataColumn();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableValid_Date = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNew_Code = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNote = new System.Data.DataColumn();
            this.dsProc = new AppSvrHMI.L3DataSet();
            this.schemadsProc = new System.Data.DataTable();
            this.coldsProcL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcL3DataTableName = new System.Data.DataColumn();
            this.coldsProcL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsProcL3DataTableMold_Cold_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableMold_Shake_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableSec_Cold_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableElec_Mix_Current = new System.Data.DataColumn();
            this.coldsProcL3DataTableElec_Mix_Freq = new System.Data.DataColumn();
            this.coldsProcL3DataTableASTC_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableCut_Coefficient = new System.Data.DataColumn();
            this.coldsProcL3DataTableCut_Head_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableCut_Head_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableCut_Trail_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableCut_Trail_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableMark_Cut_Length_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableMark_Cut_Length_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableBloom_Finish_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableTundish_Water_Type = new System.Data.DataColumn();
            this.coldsProcL3DataTableTundish_Weight_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableProtect_Slag_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableBlow_Ar_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableBlow_Ar_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableLadle_Blow_Ar_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableLadle_Blow_Ar_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableChange_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableHold_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableStay_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableLiquid_Temp = new System.Data.DataColumn();
            this.coldsProcL3DataTableSlow_Cold_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableTundish_Speed_Base = new System.Data.DataColumn();
            this.coldsProcL3DataTableBloom_Low_Base = new System.Data.DataColumn();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.bsProc = new System.Windows.Forms.BindingSource(this.components);
            this.tabFlux = new System.Windows.Forms.TabPage();
            this.hmiRootPanelLadle = new HMIBase.HMIRootPanel();
            this.dvFlux = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishFluxNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishFluxWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNavigatorFlux = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tabTundish = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.pxTextBox7 = new PxDataValid.PxTextBox();
            this.pxTextBox8 = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSteelGradeIndexTundish = new PxDataValid.PxTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tabSpeed = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSteelGradeIndexSpeed = new PxDataValid.PxTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabProc = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTundishWaterType = new PxDataValid.PxComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChangeTimeMin = new PxDataValid.PxTextBox();
            this.txtMarkCutLengthMax = new PxDataValid.PxTextBox();
            this.txtElecMixCurrent = new PxDataValid.PxTextBox();
            this.txtLadleBlowArMax = new PxDataValid.PxTextBox();
            this.txtDifSteelCutLengthMax = new PxDataValid.PxTextBox();
            this.txtMoldShakeBase = new PxDataValid.PxTextBox();
            this.txtBloomLowBase = new PxDataValid.PxTextBox();
            this.txtBlowArMax = new PxDataValid.PxTextBox();
            this.txtCutTrailMax = new PxDataValid.PxTextBox();
            this.txtStaySteelTimeMax = new PxDataValid.PxTextBox();
            this.txtBloomFinishBase = new PxDataValid.PxTextBox();
            this.txtASTCFlag = new PxDataValid.PxTextBox();
            this.txtTundishSpeedBase = new PxDataValid.PxTextBox();
            this.txtProtectSlagBase = new PxDataValid.PxTextBox();
            this.txtCutHeadMin = new PxDataValid.PxTextBox();
            this.txtSlowColdBase = new PxDataValid.PxTextBox();
            this.txtTundishWeightMin = new PxDataValid.PxTextBox();
            this.txtCutHeadMax = new PxDataValid.PxTextBox();
            this.txtLiquidTemp = new PxDataValid.PxTextBox();
            this.txtCutCoefficient = new PxDataValid.PxTextBox();
            this.txtBlowArMin = new PxDataValid.PxTextBox();
            this.txtHoldSteelTimeMax = new PxDataValid.PxTextBox();
            this.txtCutTrailMin = new PxDataValid.PxTextBox();
            this.txtMarkCutLengthMin = new PxDataValid.PxTextBox();
            this.txtLadleBlowArMin = new PxDataValid.PxTextBox();
            this.txtMoldColdBase = new PxDataValid.PxTextBox();
            this.txtDifSteelCutLengthMin = new PxDataValid.PxTextBox();
            this.txtElecMixFreq = new PxDataValid.PxTextBox();
            this.txtSecColdBase = new PxDataValid.PxTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSteelGradeIndexProc = new PxDataValid.PxTextBox();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.txtNewCode = new PxDataValid.PxTextBox();
            this.txtSteelGradeIndexBase = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).BeginInit();
            this.tabFlux.SuspendLayout();
            this.hmiRootPanelLadle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFlux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFlux)).BeginInit();
            this.bNavigatorFlux.SuspendLayout();
            this.tabTundish.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabSpeed.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabProc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnCCMStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnCCMStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOK
            // 
            this.Adapter.SetAccessRight(this.btnOK, "btnCCMStd");
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnCCMStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelFlux
            // 
            this.Adapter.SetAccessRight(this.btnDelFlux, "btnCCMStd");
            this.btnDelFlux.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFlux.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFlux.Image")));
            this.btnDelFlux.Name = "btnDelFlux";
            this.btnDelFlux.RightToLeftAutoMirrorImage = true;
            this.btnDelFlux.Size = new System.Drawing.Size(23, 22);
            this.btnDelFlux.Text = "删除";
            this.btnDelFlux.Click += new System.EventHandler(this.btnDelFlux_Click);
            // 
            // btnAddFlux
            // 
            this.Adapter.SetAccessRight(this.btnAddFlux, "btnCCMStd");
            this.btnAddFlux.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFlux.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFlux.Image")));
            this.btnAddFlux.Name = "btnAddFlux";
            this.btnAddFlux.RightToLeftAutoMirrorImage = true;
            this.btnAddFlux.Size = new System.Drawing.Size(23, 22);
            this.btnAddFlux.Text = "新添";
            this.btnAddFlux.Click += new System.EventHandler(this.btnAddFlux_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnOK,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnQuery,
            this.tscmbSteelGradeIndex,
            this.toolStripLabel1,
            this.toolStripLabel5,
            this.toolStripLabel4,
            this.txtSteelGrade});
            this.toolStrip2.Location = new System.Drawing.Point(0, 43);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "　";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tscmbSteelGradeIndex
            // 
            this.tscmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbSteelGradeIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tscmbSteelGradeIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tscmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmbSteelGradeIndex.Name = "tscmbSteelGradeIndex";
            this.tscmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "炼钢记号:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel5.Text = "        ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "钢种";
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.ReadOnly = true;
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // bsSpeed
            // 
            this.bsSpeed.DataMember = "L3DataTable";
            this.bsSpeed.DataSource = this.dsSpeed;
            // 
            // dsSpeed
            // 
            this.dsSpeed.AutoLoad = true;
            this.dsSpeed.AutoSubscribe = false;
            this.dsSpeed.DataSetName = "L3DataSet";
            this.dsSpeed.DeleteMethod = null;
            this.dsSpeed.InsertMethod = null;
            this.dsSpeed.L3DataAdapter = this.Adapter;
            this.dsSpeed.LoadEvent = "Click";
            this.dsSpeed.LoadTrigger = null;
            this.dsSpeed.RefreshValve = 1000;
            this.dsSpeed.SourceCommand = null;
            this.dsSpeed.SourceCondition = "1=2";
            this.dsSpeed.SourceMethod = "";
            this.dsSpeed.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSpeed.SourceURI = "XGMESLogic\\QualityMag\\CQA_Caster_Std_Speed";
            this.dsSpeed.SubscribeTarget = null;
            this.dsSpeed.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSpeed});
            this.dsSpeed.UpdateEvent = "Click";
            this.dsSpeed.UpdateMethod = null;
            this.dsSpeed.UpdateTrigger = null;
            // 
            // schemadsSpeed
            // 
            this.schemadsSpeed.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSpeedL3DataTableGUID,
            this.coldsSpeedL3DataTableName,
            this.coldsSpeedL3DataTableSteelGradeIndex,
            this.coldsSpeedL3DataTableSpeed_Fir_Min,
            this.coldsSpeedL3DataTableSpeed_Fir_Max,
            this.coldsSpeedL3DataTableSpeed_Min,
            this.coldsSpeedL3DataTableSpeed_Max});
            this.schemadsSpeed.TableName = "L3DataTable";
            // 
            // coldsSpeedL3DataTableGUID
            // 
            this.coldsSpeedL3DataTableGUID.Caption = "GUID";
            this.coldsSpeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsSpeedL3DataTableGUID.Namespace = "";
            // 
            // coldsSpeedL3DataTableName
            // 
            this.coldsSpeedL3DataTableName.Caption = "Name";
            this.coldsSpeedL3DataTableName.ColumnName = "Name";
            this.coldsSpeedL3DataTableName.Namespace = "";
            // 
            // coldsSpeedL3DataTableSteelGradeIndex
            // 
            this.coldsSpeedL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSpeedL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSpeedL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSpeedL3DataTableSpeed_Fir_Min
            // 
            this.coldsSpeedL3DataTableSpeed_Fir_Min.Caption = "Speed_Fir_Min";
            this.coldsSpeedL3DataTableSpeed_Fir_Min.ColumnName = "Speed_Fir_Min";
            this.coldsSpeedL3DataTableSpeed_Fir_Min.DataType = typeof(double);
            this.coldsSpeedL3DataTableSpeed_Fir_Min.Namespace = "";
            // 
            // coldsSpeedL3DataTableSpeed_Fir_Max
            // 
            this.coldsSpeedL3DataTableSpeed_Fir_Max.Caption = "Speed_Fir_Max";
            this.coldsSpeedL3DataTableSpeed_Fir_Max.ColumnName = "Speed_Fir_Max";
            this.coldsSpeedL3DataTableSpeed_Fir_Max.DataType = typeof(double);
            this.coldsSpeedL3DataTableSpeed_Fir_Max.Namespace = "";
            // 
            // coldsSpeedL3DataTableSpeed_Min
            // 
            this.coldsSpeedL3DataTableSpeed_Min.Caption = "Speed_Min";
            this.coldsSpeedL3DataTableSpeed_Min.ColumnName = "Speed_Min";
            this.coldsSpeedL3DataTableSpeed_Min.DataType = typeof(double);
            this.coldsSpeedL3DataTableSpeed_Min.Namespace = "";
            // 
            // coldsSpeedL3DataTableSpeed_Max
            // 
            this.coldsSpeedL3DataTableSpeed_Max.Caption = "Speed_Max";
            this.coldsSpeedL3DataTableSpeed_Max.ColumnName = "Speed_Max";
            this.coldsSpeedL3DataTableSpeed_Max.DataType = typeof(double);
            this.coldsSpeedL3DataTableSpeed_Max.Namespace = "";
            // 
            // bsTundish
            // 
            this.bsTundish.DataMember = "L3DataTable";
            this.bsTundish.DataSource = this.dsTundish;
            // 
            // dsTundish
            // 
            this.dsTundish.AutoLoad = true;
            this.dsTundish.AutoSubscribe = false;
            this.dsTundish.DataSetName = "L3DataSet";
            this.dsTundish.DeleteMethod = null;
            this.dsTundish.InsertMethod = null;
            this.dsTundish.L3DataAdapter = this.Adapter;
            this.dsTundish.LoadEvent = "Click";
            this.dsTundish.LoadTrigger = null;
            this.dsTundish.RefreshValve = 1000;
            this.dsTundish.SourceCommand = null;
            this.dsTundish.SourceCondition = "1=2";
            this.dsTundish.SourceMethod = "";
            this.dsTundish.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundish.SourceURI = "XGMESLogic\\QualityMag\\CQA_Caster_Std_Tundish";
            this.dsTundish.SubscribeTarget = null;
            this.dsTundish.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundish});
            this.dsTundish.UpdateEvent = "Click";
            this.dsTundish.UpdateMethod = null;
            this.dsTundish.UpdateTrigger = null;
            // 
            // schemadsTundish
            // 
            this.schemadsTundish.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishL3DataTableGUID,
            this.coldsTundishL3DataTableName,
            this.coldsTundishL3DataTableSteelGradeIndex,
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min,
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max,
            this.coldsTundishL3DataTableTundish_Temp_Min,
            this.coldsTundishL3DataTableTundish_Temp_Max});
            this.schemadsTundish.TableName = "L3DataTable";
            // 
            // coldsTundishL3DataTableGUID
            // 
            this.coldsTundishL3DataTableGUID.Caption = "GUID";
            this.coldsTundishL3DataTableGUID.ColumnName = "GUID";
            this.coldsTundishL3DataTableGUID.Namespace = "";
            // 
            // coldsTundishL3DataTableName
            // 
            this.coldsTundishL3DataTableName.Caption = "Name";
            this.coldsTundishL3DataTableName.ColumnName = "Name";
            this.coldsTundishL3DataTableName.Namespace = "";
            // 
            // coldsTundishL3DataTableSteelGradeIndex
            // 
            this.coldsTundishL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsTundishL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsTundishL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsTundishL3DataTableTundish_Temp_Fir_Min
            // 
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min.Caption = "Tundish_Temp_Fir_Min";
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min.ColumnName = "Tundish_Temp_Fir_Min";
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min.DataType = typeof(int);
            this.coldsTundishL3DataTableTundish_Temp_Fir_Min.Namespace = "";
            // 
            // coldsTundishL3DataTableTundish_Temp_Fir_Max
            // 
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max.Caption = "Tundish_Temp_Fir_Max";
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max.ColumnName = "Tundish_Temp_Fir_Max";
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max.DataType = typeof(int);
            this.coldsTundishL3DataTableTundish_Temp_Fir_Max.Namespace = "";
            // 
            // coldsTundishL3DataTableTundish_Temp_Min
            // 
            this.coldsTundishL3DataTableTundish_Temp_Min.Caption = "Tundish_Temp_Min";
            this.coldsTundishL3DataTableTundish_Temp_Min.ColumnName = "Tundish_Temp_Min";
            this.coldsTundishL3DataTableTundish_Temp_Min.DataType = typeof(int);
            this.coldsTundishL3DataTableTundish_Temp_Min.Namespace = "";
            // 
            // coldsTundishL3DataTableTundish_Temp_Max
            // 
            this.coldsTundishL3DataTableTundish_Temp_Max.Caption = "Tundish_Temp_Max";
            this.coldsTundishL3DataTableTundish_Temp_Max.ColumnName = "Tundish_Temp_Max";
            this.coldsTundishL3DataTableTundish_Temp_Max.DataType = typeof(int);
            this.coldsTundishL3DataTableTundish_Temp_Max.Namespace = "";
            // 
            // bsFlux
            // 
            this.bsFlux.DataMember = "L3DataTable";
            this.bsFlux.DataSource = this.dsFlux;
            // 
            // dsFlux
            // 
            this.dsFlux.AutoLoad = true;
            this.dsFlux.AutoSubscribe = false;
            this.dsFlux.DataSetName = "L3DataSet";
            this.dsFlux.DeleteMethod = null;
            this.dsFlux.InsertMethod = null;
            this.dsFlux.L3DataAdapter = this.Adapter;
            this.dsFlux.LoadEvent = "Click";
            this.dsFlux.LoadTrigger = null;
            this.dsFlux.RefreshValve = 1000;
            this.dsFlux.SourceCommand = null;
            this.dsFlux.SourceCondition = "1=2";
            this.dsFlux.SourceMethod = "";
            this.dsFlux.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFlux.SourceURI = "XGMESLogic\\QualityMag\\CQA_Caster_Std_Flux";
            this.dsFlux.SubscribeTarget = null;
            this.dsFlux.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFlux});
            this.dsFlux.UpdateEvent = "Click";
            this.dsFlux.UpdateMethod = null;
            this.dsFlux.UpdateTrigger = null;
            // 
            // schemadsFlux
            // 
            this.schemadsFlux.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFluxL3DataTableSteelGradeIndex,
            this.coldsFluxL3DataTableTundish_Flux_Name,
            this.coldsFluxL3DataTableTundish_Flux_Weight,
            this.coldsFluxL3DataTableGUID});
            this.schemadsFlux.TableName = "L3DataTable";
            // 
            // coldsFluxL3DataTableSteelGradeIndex
            // 
            this.coldsFluxL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsFluxL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsFluxL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsFluxL3DataTableTundish_Flux_Name
            // 
            this.coldsFluxL3DataTableTundish_Flux_Name.Caption = "Tundish_Flux_Name";
            this.coldsFluxL3DataTableTundish_Flux_Name.ColumnName = "Tundish_Flux_Name";
            this.coldsFluxL3DataTableTundish_Flux_Name.Namespace = "";
            // 
            // coldsFluxL3DataTableTundish_Flux_Weight
            // 
            this.coldsFluxL3DataTableTundish_Flux_Weight.Caption = "Tundish_Flux_Weight";
            this.coldsFluxL3DataTableTundish_Flux_Weight.ColumnName = "Tundish_Flux_Weight";
            this.coldsFluxL3DataTableTundish_Flux_Weight.Namespace = "";
            // 
            // coldsFluxL3DataTableGUID
            // 
            this.coldsFluxL3DataTableGUID.Caption = "GUID";
            this.coldsFluxL3DataTableGUID.ColumnName = "GUID";
            this.coldsFluxL3DataTableGUID.Namespace = "";
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoLoad = true;
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = "SteelGradeIndex is not null order by SteelGradeIndex";
            this.dsSteelGradeIndex.SourceMethod = "";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = null;
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "1=2";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\QualityMag\\CQA_Cater_Std_Base";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableValid_Date,
            this.coldsBaseL3DataTableNew_Code,
            this.coldsBaseL3DataTableNote});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableGUID
            // 
            this.coldsBaseL3DataTableGUID.Caption = "GUID";
            this.coldsBaseL3DataTableGUID.ColumnName = "GUID";
            this.coldsBaseL3DataTableGUID.Namespace = "";
            // 
            // coldsBaseL3DataTableName
            // 
            this.coldsBaseL3DataTableName.Caption = "Name";
            this.coldsBaseL3DataTableName.ColumnName = "Name";
            this.coldsBaseL3DataTableName.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGradeIndex
            // 
            this.coldsBaseL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTableValid_Date
            // 
            this.coldsBaseL3DataTableValid_Date.Caption = "Valid_Date";
            this.coldsBaseL3DataTableValid_Date.ColumnName = "Valid_Date";
            this.coldsBaseL3DataTableValid_Date.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableValid_Date.Namespace = "";
            // 
            // coldsBaseL3DataTableNew_Code
            // 
            this.coldsBaseL3DataTableNew_Code.Caption = "New_Code";
            this.coldsBaseL3DataTableNew_Code.ColumnName = "New_Code";
            this.coldsBaseL3DataTableNew_Code.Namespace = "";
            // 
            // coldsBaseL3DataTableNote
            // 
            this.coldsBaseL3DataTableNote.Caption = "Note";
            this.coldsBaseL3DataTableNote.ColumnName = "Note";
            this.coldsBaseL3DataTableNote.Namespace = "";
            // 
            // dsProc
            // 
            this.dsProc.AutoLoad = true;
            this.dsProc.AutoSubscribe = false;
            this.dsProc.DataSetName = "L3DataSet";
            this.dsProc.DeleteMethod = null;
            this.dsProc.InsertMethod = null;
            this.dsProc.L3DataAdapter = this.Adapter;
            this.dsProc.LoadEvent = "Click";
            this.dsProc.LoadTrigger = null;
            this.dsProc.RefreshValve = 1000;
            this.dsProc.SourceCommand = null;
            this.dsProc.SourceCondition = "1=2";
            this.dsProc.SourceMethod = "";
            this.dsProc.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProc.SourceURI = "XGMESLogic\\QualityMag\\CQA_Caster_Std_Proc";
            this.dsProc.SubscribeTarget = null;
            this.dsProc.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProc});
            this.dsProc.UpdateEvent = "Click";
            this.dsProc.UpdateMethod = null;
            this.dsProc.UpdateTrigger = null;
            // 
            // schemadsProc
            // 
            this.schemadsProc.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcL3DataTableGUID,
            this.coldsProcL3DataTableName,
            this.coldsProcL3DataTableSteelGradeIndex,
            this.coldsProcL3DataTableMold_Cold_Base,
            this.coldsProcL3DataTableMold_Shake_Base,
            this.coldsProcL3DataTableSec_Cold_Base,
            this.coldsProcL3DataTableElec_Mix_Current,
            this.coldsProcL3DataTableElec_Mix_Freq,
            this.coldsProcL3DataTableASTC_Flag,
            this.coldsProcL3DataTableCut_Coefficient,
            this.coldsProcL3DataTableCut_Head_Max,
            this.coldsProcL3DataTableCut_Head_Min,
            this.coldsProcL3DataTableCut_Trail_Max,
            this.coldsProcL3DataTableCut_Trail_Min,
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max,
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min,
            this.coldsProcL3DataTableMark_Cut_Length_Max,
            this.coldsProcL3DataTableMark_Cut_Length_Min,
            this.coldsProcL3DataTableBloom_Finish_Base,
            this.coldsProcL3DataTableTundish_Water_Type,
            this.coldsProcL3DataTableTundish_Weight_Min,
            this.coldsProcL3DataTableProtect_Slag_Base,
            this.coldsProcL3DataTableBlow_Ar_Max,
            this.coldsProcL3DataTableBlow_Ar_Min,
            this.coldsProcL3DataTableLadle_Blow_Ar_Max,
            this.coldsProcL3DataTableLadle_Blow_Ar_Min,
            this.coldsProcL3DataTableChange_Time_Min,
            this.coldsProcL3DataTableHold_Steel_Time_Max,
            this.coldsProcL3DataTableStay_Steel_Time_Max,
            this.coldsProcL3DataTableLiquid_Temp,
            this.coldsProcL3DataTableSlow_Cold_Base,
            this.coldsProcL3DataTableTundish_Speed_Base,
            this.coldsProcL3DataTableBloom_Low_Base});
            this.schemadsProc.TableName = "L3DataTable";
            // 
            // coldsProcL3DataTableGUID
            // 
            this.coldsProcL3DataTableGUID.Caption = "GUID";
            this.coldsProcL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcL3DataTableGUID.Namespace = "";
            // 
            // coldsProcL3DataTableName
            // 
            this.coldsProcL3DataTableName.Caption = "Name";
            this.coldsProcL3DataTableName.ColumnName = "Name";
            this.coldsProcL3DataTableName.Namespace = "";
            // 
            // coldsProcL3DataTableSteelGradeIndex
            // 
            this.coldsProcL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsProcL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsProcL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsProcL3DataTableMold_Cold_Base
            // 
            this.coldsProcL3DataTableMold_Cold_Base.Caption = "Mold_Cold_Base";
            this.coldsProcL3DataTableMold_Cold_Base.ColumnName = "Mold_Cold_Base";
            this.coldsProcL3DataTableMold_Cold_Base.Namespace = "";
            // 
            // coldsProcL3DataTableMold_Shake_Base
            // 
            this.coldsProcL3DataTableMold_Shake_Base.Caption = "Mold_Shake_Base";
            this.coldsProcL3DataTableMold_Shake_Base.ColumnName = "Mold_Shake_Base";
            this.coldsProcL3DataTableMold_Shake_Base.Namespace = "";
            // 
            // coldsProcL3DataTableSec_Cold_Base
            // 
            this.coldsProcL3DataTableSec_Cold_Base.Caption = "Sec_Cold_Base";
            this.coldsProcL3DataTableSec_Cold_Base.ColumnName = "Sec_Cold_Base";
            this.coldsProcL3DataTableSec_Cold_Base.Namespace = "";
            // 
            // coldsProcL3DataTableElec_Mix_Current
            // 
            this.coldsProcL3DataTableElec_Mix_Current.Caption = "Elec_Mix_Current";
            this.coldsProcL3DataTableElec_Mix_Current.ColumnName = "Elec_Mix_Current";
            this.coldsProcL3DataTableElec_Mix_Current.Namespace = "";
            // 
            // coldsProcL3DataTableElec_Mix_Freq
            // 
            this.coldsProcL3DataTableElec_Mix_Freq.Caption = "Elec_Mix_Freq";
            this.coldsProcL3DataTableElec_Mix_Freq.ColumnName = "Elec_Mix_Freq";
            this.coldsProcL3DataTableElec_Mix_Freq.Namespace = "";
            // 
            // coldsProcL3DataTableASTC_Flag
            // 
            this.coldsProcL3DataTableASTC_Flag.Caption = "ASTC_Flag";
            this.coldsProcL3DataTableASTC_Flag.ColumnName = "ASTC_Flag";
            this.coldsProcL3DataTableASTC_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableCut_Coefficient
            // 
            this.coldsProcL3DataTableCut_Coefficient.Caption = "Cut_Coefficient";
            this.coldsProcL3DataTableCut_Coefficient.ColumnName = "Cut_Coefficient";
            this.coldsProcL3DataTableCut_Coefficient.Namespace = "";
            // 
            // coldsProcL3DataTableCut_Head_Max
            // 
            this.coldsProcL3DataTableCut_Head_Max.Caption = "Cut_Head_Max";
            this.coldsProcL3DataTableCut_Head_Max.ColumnName = "Cut_Head_Max";
            this.coldsProcL3DataTableCut_Head_Max.DataType = typeof(int);
            this.coldsProcL3DataTableCut_Head_Max.Namespace = "";
            // 
            // coldsProcL3DataTableCut_Head_Min
            // 
            this.coldsProcL3DataTableCut_Head_Min.Caption = "Cut_Head_Min";
            this.coldsProcL3DataTableCut_Head_Min.ColumnName = "Cut_Head_Min";
            this.coldsProcL3DataTableCut_Head_Min.DataType = typeof(int);
            this.coldsProcL3DataTableCut_Head_Min.Namespace = "";
            // 
            // coldsProcL3DataTableCut_Trail_Max
            // 
            this.coldsProcL3DataTableCut_Trail_Max.Caption = "Cut_Trail_Max";
            this.coldsProcL3DataTableCut_Trail_Max.ColumnName = "Cut_Trail_Max";
            this.coldsProcL3DataTableCut_Trail_Max.DataType = typeof(int);
            this.coldsProcL3DataTableCut_Trail_Max.Namespace = "";
            // 
            // coldsProcL3DataTableCut_Trail_Min
            // 
            this.coldsProcL3DataTableCut_Trail_Min.Caption = "Cut_Trail_Min";
            this.coldsProcL3DataTableCut_Trail_Min.ColumnName = "Cut_Trail_Min";
            this.coldsProcL3DataTableCut_Trail_Min.DataType = typeof(int);
            this.coldsProcL3DataTableCut_Trail_Min.Namespace = "";
            // 
            // coldsProcL3DataTableDifSteel_Cut_Length_Max
            // 
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max.Caption = "DifSteel_Cut_Length_Max";
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max.ColumnName = "DifSteel_Cut_Length_Max";
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max.DataType = typeof(int);
            this.coldsProcL3DataTableDifSteel_Cut_Length_Max.Namespace = "";
            // 
            // coldsProcL3DataTableDifSteel_Cut_Length_Min
            // 
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min.Caption = "DifSteel_Cut_Length_Min";
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min.ColumnName = "DifSteel_Cut_Length_Min";
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min.DataType = typeof(int);
            this.coldsProcL3DataTableDifSteel_Cut_Length_Min.Namespace = "";
            // 
            // coldsProcL3DataTableMark_Cut_Length_Max
            // 
            this.coldsProcL3DataTableMark_Cut_Length_Max.Caption = "Mark_Cut_Length_Max";
            this.coldsProcL3DataTableMark_Cut_Length_Max.ColumnName = "Mark_Cut_Length_Max";
            this.coldsProcL3DataTableMark_Cut_Length_Max.DataType = typeof(int);
            this.coldsProcL3DataTableMark_Cut_Length_Max.Namespace = "";
            // 
            // coldsProcL3DataTableMark_Cut_Length_Min
            // 
            this.coldsProcL3DataTableMark_Cut_Length_Min.Caption = "Mark_Cut_Length_Min";
            this.coldsProcL3DataTableMark_Cut_Length_Min.ColumnName = "Mark_Cut_Length_Min";
            this.coldsProcL3DataTableMark_Cut_Length_Min.DataType = typeof(int);
            this.coldsProcL3DataTableMark_Cut_Length_Min.Namespace = "";
            // 
            // coldsProcL3DataTableBloom_Finish_Base
            // 
            this.coldsProcL3DataTableBloom_Finish_Base.Caption = "Bloom_Finish_Base";
            this.coldsProcL3DataTableBloom_Finish_Base.ColumnName = "Bloom_Finish_Base";
            this.coldsProcL3DataTableBloom_Finish_Base.Namespace = "";
            // 
            // coldsProcL3DataTableTundish_Water_Type
            // 
            this.coldsProcL3DataTableTundish_Water_Type.Caption = "Tundish_Water_Type";
            this.coldsProcL3DataTableTundish_Water_Type.ColumnName = "Tundish_Water_Type";
            this.coldsProcL3DataTableTundish_Water_Type.Namespace = "";
            // 
            // coldsProcL3DataTableTundish_Weight_Min
            // 
            this.coldsProcL3DataTableTundish_Weight_Min.Caption = "Tundish_Weight_Min";
            this.coldsProcL3DataTableTundish_Weight_Min.ColumnName = "Tundish_Weight_Min";
            this.coldsProcL3DataTableTundish_Weight_Min.Namespace = "";
            // 
            // coldsProcL3DataTableProtect_Slag_Base
            // 
            this.coldsProcL3DataTableProtect_Slag_Base.Caption = "Protect_Slag_Base";
            this.coldsProcL3DataTableProtect_Slag_Base.ColumnName = "Protect_Slag_Base";
            this.coldsProcL3DataTableProtect_Slag_Base.Namespace = "";
            // 
            // coldsProcL3DataTableBlow_Ar_Max
            // 
            this.coldsProcL3DataTableBlow_Ar_Max.Caption = "Blow_Ar_Max";
            this.coldsProcL3DataTableBlow_Ar_Max.ColumnName = "Blow_Ar_Max";
            this.coldsProcL3DataTableBlow_Ar_Max.Namespace = "";
            // 
            // coldsProcL3DataTableBlow_Ar_Min
            // 
            this.coldsProcL3DataTableBlow_Ar_Min.Caption = "Blow_Ar_Min";
            this.coldsProcL3DataTableBlow_Ar_Min.ColumnName = "Blow_Ar_Min";
            this.coldsProcL3DataTableBlow_Ar_Min.Namespace = "";
            // 
            // coldsProcL3DataTableLadle_Blow_Ar_Max
            // 
            this.coldsProcL3DataTableLadle_Blow_Ar_Max.Caption = "Ladle_Blow_Ar_Max";
            this.coldsProcL3DataTableLadle_Blow_Ar_Max.ColumnName = "Ladle_Blow_Ar_Max";
            this.coldsProcL3DataTableLadle_Blow_Ar_Max.Namespace = "";
            // 
            // coldsProcL3DataTableLadle_Blow_Ar_Min
            // 
            this.coldsProcL3DataTableLadle_Blow_Ar_Min.Caption = "Ladle_Blow_Ar_Min";
            this.coldsProcL3DataTableLadle_Blow_Ar_Min.ColumnName = "Ladle_Blow_Ar_Min";
            this.coldsProcL3DataTableLadle_Blow_Ar_Min.Namespace = "";
            // 
            // coldsProcL3DataTableChange_Time_Min
            // 
            this.coldsProcL3DataTableChange_Time_Min.Caption = "Change_Time_Min";
            this.coldsProcL3DataTableChange_Time_Min.ColumnName = "Change_Time_Min";
            this.coldsProcL3DataTableChange_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableHold_Steel_Time_Max
            // 
            this.coldsProcL3DataTableHold_Steel_Time_Max.Caption = "Hold_Steel_Time_Max";
            this.coldsProcL3DataTableHold_Steel_Time_Max.ColumnName = "Hold_Steel_Time_Max";
            this.coldsProcL3DataTableHold_Steel_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableStay_Steel_Time_Max
            // 
            this.coldsProcL3DataTableStay_Steel_Time_Max.Caption = "Stay_Steel_Time_Max";
            this.coldsProcL3DataTableStay_Steel_Time_Max.ColumnName = "Stay_Steel_Time_Max";
            this.coldsProcL3DataTableStay_Steel_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableLiquid_Temp
            // 
            this.coldsProcL3DataTableLiquid_Temp.Caption = "Liquid_Temp";
            this.coldsProcL3DataTableLiquid_Temp.ColumnName = "Liquid_Temp";
            this.coldsProcL3DataTableLiquid_Temp.Namespace = "";
            // 
            // coldsProcL3DataTableSlow_Cold_Base
            // 
            this.coldsProcL3DataTableSlow_Cold_Base.Caption = "Slow_Cold_Base";
            this.coldsProcL3DataTableSlow_Cold_Base.ColumnName = "Slow_Cold_Base";
            this.coldsProcL3DataTableSlow_Cold_Base.Namespace = "";
            // 
            // coldsProcL3DataTableTundish_Speed_Base
            // 
            this.coldsProcL3DataTableTundish_Speed_Base.Caption = "Tundish_Speed_Base";
            this.coldsProcL3DataTableTundish_Speed_Base.ColumnName = "Tundish_Speed_Base";
            this.coldsProcL3DataTableTundish_Speed_Base.Namespace = "";
            // 
            // coldsProcL3DataTableBloom_Low_Base
            // 
            this.coldsProcL3DataTableBloom_Low_Base.Caption = "Bloom_Low_Base";
            this.coldsProcL3DataTableBloom_Low_Base.ColumnName = "Bloom_Low_Base";
            this.coldsProcL3DataTableBloom_Low_Base.Namespace = "";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // bsProc
            // 
            this.bsProc.DataMember = "L3DataTable";
            this.bsProc.DataSource = this.dsProc;
            // 
            // tabFlux
            // 
            this.tabFlux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFlux.Controls.Add(this.hmiRootPanelLadle);
            this.tabFlux.Location = new System.Drawing.Point(4, 21);
            this.tabFlux.Name = "tabFlux";
            this.tabFlux.Size = new System.Drawing.Size(1012, 587);
            this.tabFlux.TabIndex = 7;
            this.tabFlux.Text = "中包覆盖剂信息";
            this.tabFlux.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelLadle
            // 
            this.hmiRootPanelLadle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelLadle.Controls.Add(this.dvFlux);
            this.hmiRootPanelLadle.Controls.Add(this.bNavigatorFlux);
            this.hmiRootPanelLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelLadle.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelLadle.Name = "hmiRootPanelLadle";
            this.hmiRootPanelLadle.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelLadle.TabIndex = 29;
            // 
            // dvFlux
            // 
            this.dvFlux.AllowUserToAddRows = false;
            this.dvFlux.AutoGenerateColumns = false;
            this.dvFlux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFlux.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFlux.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvFlux.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.tundishFluxNameDataGridViewTextBoxColumn,
            this.tundishFluxWeightDataGridViewTextBoxColumn});
            this.dvFlux.DataSource = this.bsFlux;
            this.dvFlux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFlux.Location = new System.Drawing.Point(0, 25);
            this.dvFlux.Name = "dvFlux";
            this.dvFlux.RowTemplate.Height = 23;
            this.dvFlux.Size = new System.Drawing.Size(1006, 556);
            this.dvFlux.TabIndex = 1;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // tundishFluxNameDataGridViewTextBoxColumn
            // 
            this.tundishFluxNameDataGridViewTextBoxColumn.DataPropertyName = "Tundish_Flux_Name";
            this.tundishFluxNameDataGridViewTextBoxColumn.HeaderText = "中包覆盖剂名称";
            this.tundishFluxNameDataGridViewTextBoxColumn.Name = "tundishFluxNameDataGridViewTextBoxColumn";
            this.tundishFluxNameDataGridViewTextBoxColumn.Width = 114;
            // 
            // tundishFluxWeightDataGridViewTextBoxColumn
            // 
            this.tundishFluxWeightDataGridViewTextBoxColumn.DataPropertyName = "Tundish_Flux_Weight";
            this.tundishFluxWeightDataGridViewTextBoxColumn.HeaderText = "中包覆盖剂加入量";
            this.tundishFluxWeightDataGridViewTextBoxColumn.Name = "tundishFluxWeightDataGridViewTextBoxColumn";
            this.tundishFluxWeightDataGridViewTextBoxColumn.Width = 126;
            // 
            // bNavigatorFlux
            // 
            this.bNavigatorFlux.AddNewItem = null;
            this.bNavigatorFlux.BindingSource = this.bsFlux;
            this.bNavigatorFlux.CountItem = this.bindingNavigatorCountItem2;
            this.bNavigatorFlux.DeleteItem = null;
            this.bNavigatorFlux.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.btnAddFlux,
            this.btnDelFlux});
            this.bNavigatorFlux.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorFlux.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bNavigatorFlux.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bNavigatorFlux.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bNavigatorFlux.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bNavigatorFlux.Name = "bNavigatorFlux";
            this.bNavigatorFlux.PositionItem = this.bindingNavigatorPositionItem2;
            this.bNavigatorFlux.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorFlux.TabIndex = 0;
            this.bNavigatorFlux.Text = "bindingNavigator3";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "/ {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "位置";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tabTundish
            // 
            this.tabTundish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTundish.Controls.Add(this.groupBox5);
            this.tabTundish.Controls.Add(this.groupBox8);
            this.tabTundish.Location = new System.Drawing.Point(4, 21);
            this.tabTundish.Name = "tabTundish";
            this.tabTundish.Size = new System.Drawing.Size(1012, 587);
            this.tabTundish.TabIndex = 4;
            this.tabTundish.Text = "中包信息";
            this.tabTundish.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pxTextBox5);
            this.groupBox5.Controls.Add(this.pxTextBox6);
            this.groupBox5.Controls.Add(this.pxTextBox7);
            this.groupBox5.Controls.Add(this.pxTextBox8);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 54);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1010, 76);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTundish, "Tundish_Temp_Max", true));
            //
            this.pxTextBox5.EnableNull = false;
            this.pxTextBox5.ErropPr = this.errorProvider1;
            //
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(447, 41);
            this.pxTextBox5.Max = 2000;
            ////
            //
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            ////
            //
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            //
            this.pxTextBox5.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox5.TabIndex = 3;
            this.pxTextBox5.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeed, "Speed_Fir_Min", true));
            //
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = this.errorProvider1;
            //
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(170, 14);
            this.pxTextBox1.Max = 99;
            ////
            //
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            ////
            //
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            //
            this.pxTextBox1.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.pxTextBox1, "必输项,不小于-0.99的数字!");
            this.pxTextBox1.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTundish, "Tundish_Temp_Fir_Max", true));
            //
            this.pxTextBox6.EnableNull = false;
            this.pxTextBox6.ErropPr = this.errorProvider1;
            //
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(186, 41);
            this.pxTextBox6.Max = 2000;
            ////
            //
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0;
            ////
            //
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            //
            this.pxTextBox6.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox6.TabIndex = 1;
            this.pxTextBox6.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox7
            // 
            this.pxTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTundish, "Tundish_Temp_Min", true));
            //
            this.pxTextBox7.EnableNull = false;
            this.pxTextBox7.ErropPr = this.errorProvider1;
            //
            this.pxTextBox7.Length = 0;
            this.pxTextBox7.Location = new System.Drawing.Point(447, 14);
            this.pxTextBox7.Max = 2000;
            ////
            //
            this.pxTextBox7.MaxStrLength = 0;
            this.pxTextBox7.Min = 0;
            ////
            //
            this.pxTextBox7.MinStrLength = 0;
            this.pxTextBox7.Name = "pxTextBox7";
            this.pxTextBox7.Precision = 0;
            //
            this.pxTextBox7.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox7.TabIndex = 2;
            this.pxTextBox7.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox7.ValidEable = true;
            this.pxTextBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox8
            // 
            this.pxTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTundish, "Tundish_Temp_Fir_Min", true));
            //
            this.pxTextBox8.EnableNull = false;
            this.pxTextBox8.ErropPr = this.errorProvider1;
            //
            this.pxTextBox8.Length = 0;
            this.pxTextBox8.Location = new System.Drawing.Point(186, 14);
            this.pxTextBox8.Max = 2000;
            ////
            //
            this.pxTextBox8.MaxStrLength = 0;
            this.pxTextBox8.Min = 0;
            ////
            //
            this.pxTextBox8.MinStrLength = 0;
            this.pxTextBox8.Name = "pxTextBox8";
            this.pxTextBox8.Precision = 0;
            //
            this.pxTextBox8.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox8.TabIndex = 0;
            this.pxTextBox8.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox8.ValidEable = true;
            this.pxTextBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 12);
            this.label16.TabIndex = 20;
            this.label16.Text = "中包温度最大(连铸炉):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 12);
            this.label17.TabIndex = 19;
            this.label17.Text = "中包温度最大(连铸第一炉):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(310, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 12);
            this.label18.TabIndex = 22;
            this.label18.Text = "中包温度最小(连铸炉):";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "中包温度最小(连铸第一炉):";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSteelGradeIndexTundish);
            this.groupBox8.Controls.Add(this.label53);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1010, 54);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // txtSteelGradeIndexTundish
            // 
            this.txtSteelGradeIndexTundish.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTundish, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexTundish.EnableNull = false;
            this.txtSteelGradeIndexTundish.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexTundish.Length = 8;
            this.txtSteelGradeIndexTundish.Location = new System.Drawing.Point(105, 17);
            this.txtSteelGradeIndexTundish.Max = 0;
            this.txtSteelGradeIndexTundish.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexTundish.MaxStrLength = 0;
            this.txtSteelGradeIndexTundish.Min = 0;
            ////
            //
            this.txtSteelGradeIndexTundish.MinStrLength = 0;
            this.txtSteelGradeIndexTundish.Name = "txtSteelGradeIndexTundish";
            this.txtSteelGradeIndexTundish.Precision = 0;
            this.txtSteelGradeIndexTundish.ReadOnly = true;
            //
            this.txtSteelGradeIndexTundish.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexTundish.TabIndex = 0;
            this.txtSteelGradeIndexTundish.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexTundish.ValidEable = true;
            this.txtSteelGradeIndexTundish.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(33, 20);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 12);
            this.label53.TabIndex = 14;
            this.label53.Text = "炼钢记号:";
            // 
            // tabSpeed
            // 
            this.tabSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSpeed.Controls.Add(this.groupBox1);
            this.tabSpeed.Controls.Add(this.groupBox4);
            this.tabSpeed.Location = new System.Drawing.Point(4, 21);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.Size = new System.Drawing.Size(1012, 587);
            this.tabSpeed.TabIndex = 3;
            this.tabSpeed.Text = "拉速信息";
            this.tabSpeed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pxTextBox4);
            this.groupBox1.Controls.Add(this.pxTextBox2);
            this.groupBox1.Controls.Add(this.pxTextBox3);
            this.groupBox1.Controls.Add(this.pxTextBox1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeed, "Speed_Max", true));
            //
            this.pxTextBox4.EnableNull = false;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            //
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(397, 41);
            this.pxTextBox4.Max = 99;
            ////
            //
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            ////
            //
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            //
            this.pxTextBox4.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox4.TabIndex = 3;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeed, "Speed_Fir_Max", true));
            //
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            //
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(170, 41);
            this.pxTextBox2.Max = 99;
            ////
            //
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            ////
            //
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            //
            this.pxTextBox2.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox2.TabIndex = 1;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeed, "Speed_Min", true));
            //
            this.pxTextBox3.EnableNull = false;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            //
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(397, 14);
            this.pxTextBox3.Max = 99;
            ////
            //
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            ////
            //
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            //
            this.pxTextBox3.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox3.TabIndex = 2;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
          //
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(286, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 12);
            this.label15.TabIndex = 14;
            this.label15.Text = "拉速最大(连铸炉):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "拉速最大(连铸第一炉):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(286, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "拉速最小(连铸炉):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "拉速最小(连铸第一炉):";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSteelGradeIndexSpeed);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1010, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // txtSteelGradeIndexSpeed
            // 
            this.txtSteelGradeIndexSpeed.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSpeed, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexSpeed.EnableNull = false;
            this.txtSteelGradeIndexSpeed.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexSpeed.Length = 8;
            this.txtSteelGradeIndexSpeed.Location = new System.Drawing.Point(105, 17);
            this.txtSteelGradeIndexSpeed.Max = 0;
            this.txtSteelGradeIndexSpeed.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexSpeed.MaxStrLength = 0;
            this.txtSteelGradeIndexSpeed.Min = 0;
            ////
            //
            this.txtSteelGradeIndexSpeed.MinStrLength = 0;
            this.txtSteelGradeIndexSpeed.Name = "txtSteelGradeIndexSpeed";
            this.txtSteelGradeIndexSpeed.Precision = 0;
            this.txtSteelGradeIndexSpeed.ReadOnly = true;
            //
            this.txtSteelGradeIndexSpeed.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexSpeed.TabIndex = 0;
            this.txtSteelGradeIndexSpeed.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexSpeed.ValidEable = true;
            this.txtSteelGradeIndexSpeed.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(33, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 14;
            this.label34.Text = "炼钢记号:";
            // 
            // tabProc
            // 
            this.tabProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProc.Controls.Add(this.groupBox3);
            this.tabProc.Controls.Add(this.groupBox2);
            this.tabProc.Location = new System.Drawing.Point(4, 21);
            this.tabProc.Name = "tabProc";
            this.tabProc.Size = new System.Drawing.Size(1012, 587);
            this.tabProc.TabIndex = 10;
            this.tabProc.Text = "处理信息";
            this.tabProc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTundishWaterType);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.label43);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label50);
            this.groupBox3.Controls.Add(this.label42);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label58);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label41);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label57);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label56);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.label45);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label52);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtChangeTimeMin);
            this.groupBox3.Controls.Add(this.txtMarkCutLengthMax);
            this.groupBox3.Controls.Add(this.txtElecMixCurrent);
            this.groupBox3.Controls.Add(this.txtLadleBlowArMax);
            this.groupBox3.Controls.Add(this.txtDifSteelCutLengthMax);
            this.groupBox3.Controls.Add(this.txtMoldShakeBase);
            this.groupBox3.Controls.Add(this.txtBloomLowBase);
            this.groupBox3.Controls.Add(this.txtBlowArMax);
            this.groupBox3.Controls.Add(this.txtCutTrailMax);
            this.groupBox3.Controls.Add(this.txtStaySteelTimeMax);
            this.groupBox3.Controls.Add(this.txtBloomFinishBase);
            this.groupBox3.Controls.Add(this.txtASTCFlag);
            this.groupBox3.Controls.Add(this.txtTundishSpeedBase);
            this.groupBox3.Controls.Add(this.txtProtectSlagBase);
            this.groupBox3.Controls.Add(this.txtCutHeadMin);
            this.groupBox3.Controls.Add(this.txtSlowColdBase);
            this.groupBox3.Controls.Add(this.txtTundishWeightMin);
            this.groupBox3.Controls.Add(this.txtCutHeadMax);
            this.groupBox3.Controls.Add(this.txtLiquidTemp);
            this.groupBox3.Controls.Add(this.txtCutCoefficient);
            this.groupBox3.Controls.Add(this.txtBlowArMin);
            this.groupBox3.Controls.Add(this.txtHoldSteelTimeMax);
            this.groupBox3.Controls.Add(this.txtCutTrailMin);
            this.groupBox3.Controls.Add(this.txtMarkCutLengthMin);
            this.groupBox3.Controls.Add(this.txtLadleBlowArMin);
            this.groupBox3.Controls.Add(this.txtMoldColdBase);
            this.groupBox3.Controls.Add(this.txtDifSteelCutLengthMin);
            this.groupBox3.Controls.Add(this.txtElecMixFreq);
            this.groupBox3.Controls.Add(this.txtSecColdBase);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 289);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cmbTundishWaterType
            // 
            this.cmbTundishWaterType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTundishWaterType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTundishWaterType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTundishWaterType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Tundish_Water_Type", true));
            this.cmbTundishWaterType.EnableNull = true;
            this.cmbTundishWaterType.ErropPr = null;
            this.cmbTundishWaterType.FormattingEnabled = true;
            this.cmbTundishWaterType.Location = new System.Drawing.Point(450, 177);
            this.cmbTundishWaterType.Name = "cmbTundishWaterType";
            //
            this.cmbTundishWaterType.Size = new System.Drawing.Size(100, 20);
            this.cmbTundishWaterType.TabIndex = 16;
            //
            this.cmbTundishWaterType.ToolTipValid = null;
            this.cmbTundishWaterType.ValidEable = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(650, 101);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(107, 12);
            this.label51.TabIndex = 2;
            this.label51.Text = "气氛置换时间最小:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(361, 154);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 12);
            this.label43.TabIndex = 2;
            this.label43.Text = "铸坯精理基准:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 206);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "铸坯切头长度最大:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(650, 76);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(107, 12);
            this.label50.TabIndex = 2;
            this.label50.Text = "大包吹氩流量最小:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(325, 128);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(119, 12);
            this.label42.TabIndex = 2;
            this.label42.Text = "接痕后切割长度最小:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(45, 180);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "切割补正系数:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(674, 257);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(83, 12);
            this.label58.TabIndex = 2;
            this.label58.Text = "铸坯低倍基准:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(650, 49);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(107, 12);
            this.label49.TabIndex = 2;
            this.label49.Text = "大包吹氩流量最大:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(325, 102);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(119, 12);
            this.label41.TabIndex = 2;
            this.label41.Text = "接痕后切割长度最大:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(81, 154);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "轻压下:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(590, 231);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(167, 12);
            this.label57.TabIndex = 2;
            this.label57.Text = "中包目标温度时铸机拉速基准:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(650, 23);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(107, 12);
            this.label48.TabIndex = 2;
            this.label48.Text = "塞棒吹氩流量最小:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(277, 76);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(167, 12);
            this.label33.TabIndex = 2;
            this.label33.Text = "异钢连浇接痕前切割长度最小:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "电磁搅拌频率:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(698, 205);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(59, 12);
            this.label56.TabIndex = 2;
            this.label56.Text = "缓冷基准:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(337, 258);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(107, 12);
            this.label47.TabIndex = 2;
            this.label47.Text = "塞棒吹氩流量最大:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(277, 50);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(167, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "异钢连浇接痕前切割长度最大:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "电磁搅拌电流:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(686, 179);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(71, 12);
            this.label55.TabIndex = 2;
            this.label55.Text = "液相线温度:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(373, 232);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(71, 12);
            this.label46.TabIndex = 2;
            this.label46.Text = "保护渣基准:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(337, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(107, 12);
            this.label31.TabIndex = 2;
            this.label31.Text = "铸坯切尾长度最小:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "二次冷却基准:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(674, 153);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 12);
            this.label54.TabIndex = 2;
            this.label54.Text = "等钢时间最大:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(349, 206);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(95, 12);
            this.label45.TabIndex = 2;
            this.label45.Text = "中包最小钢水量:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(21, 258);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "铸坯切尾长度最大:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "结晶器振动基准:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(674, 128);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 12);
            this.label52.TabIndex = 2;
            this.label52.Text = "压钢时间最大:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(361, 180);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(83, 12);
            this.label44.TabIndex = 2;
            this.label44.Text = "中包水口类型:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 232);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "铸坯切头长度最小:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "结晶器冷却基准:";
            // 
            // txtChangeTimeMin
            // 
            this.txtChangeTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Change_Time_Min", true));
            //
            this.txtChangeTimeMin.EnableNull = false;
            this.txtChangeTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtChangeTimeMin.Length = 0;
            this.txtChangeTimeMin.Location = new System.Drawing.Point(763, 98);
            this.txtChangeTimeMin.Max = 99999;
            ////
            //
            this.txtChangeTimeMin.MaxStrLength = 0;
            this.txtChangeTimeMin.Min = 0;
            ////
            //
            this.txtChangeTimeMin.MinStrLength = 0;
            this.txtChangeTimeMin.Name = "txtChangeTimeMin";
            this.txtChangeTimeMin.Precision = 0;
            //
            this.txtChangeTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtChangeTimeMin.TabIndex = 23;
            this.txtChangeTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtChangeTimeMin.ValidEable = true;
            this.txtChangeTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMarkCutLengthMax
            // 
            this.txtMarkCutLengthMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Mark_Cut_Length_Max", true));
            //
            this.txtMarkCutLengthMax.EnableNull = false;
            this.txtMarkCutLengthMax.ErropPr = this.errorProvider1;
            //
            this.txtMarkCutLengthMax.Length = 0;
            this.txtMarkCutLengthMax.Location = new System.Drawing.Point(450, 98);
            this.txtMarkCutLengthMax.Max = 9999;
            ////
            //
            this.txtMarkCutLengthMax.MaxStrLength = 0;
            this.txtMarkCutLengthMax.Min = 0;
            ////
            //
            this.txtMarkCutLengthMax.MinStrLength = 0;
            this.txtMarkCutLengthMax.Name = "txtMarkCutLengthMax";
            this.txtMarkCutLengthMax.Precision = 0;
            //
            this.txtMarkCutLengthMax.Size = new System.Drawing.Size(100, 21);
            this.txtMarkCutLengthMax.TabIndex = 13;
            this.txtMarkCutLengthMax.ToolTipValid = this.toolTip1;
          //
            this.txtMarkCutLengthMax.ValidEable = true;
            this.txtMarkCutLengthMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtElecMixCurrent
            // 
            this.txtElecMixCurrent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Elec_Mix_Current", true));
            //
            this.txtElecMixCurrent.EnableNull = false;
            this.txtElecMixCurrent.ErropPr = this.errorProvider1;
            //
            this.txtElecMixCurrent.Length = 0;
            this.txtElecMixCurrent.Location = new System.Drawing.Point(134, 98);
            this.txtElecMixCurrent.Max = 9999;
            ////
            //
            this.txtElecMixCurrent.MaxStrLength = 0;
            this.txtElecMixCurrent.Min = 0;
            ////
            //
            this.txtElecMixCurrent.MinStrLength = 0;
            this.txtElecMixCurrent.Name = "txtElecMixCurrent";
            this.txtElecMixCurrent.Precision = 0;
            //
            this.txtElecMixCurrent.Size = new System.Drawing.Size(100, 21);
            this.txtElecMixCurrent.TabIndex = 3;
            this.txtElecMixCurrent.ToolTipValid = this.toolTip1;
          //
            this.txtElecMixCurrent.ValidEable = true;
            this.txtElecMixCurrent.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtLadleBlowArMax
            // 
            this.txtLadleBlowArMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Ladle_Blow_Ar_Max", true));
            //
            this.txtLadleBlowArMax.EnableNull = false;
            this.txtLadleBlowArMax.ErropPr = this.errorProvider1;
            //
            this.txtLadleBlowArMax.Length = 0;
            this.txtLadleBlowArMax.Location = new System.Drawing.Point(763, 46);
            this.txtLadleBlowArMax.Max = 99999;
            ////
            //
            this.txtLadleBlowArMax.MaxStrLength = 0;
            this.txtLadleBlowArMax.Min = 0;
            ////
            //
            this.txtLadleBlowArMax.MinStrLength = 0;
            this.txtLadleBlowArMax.Name = "txtLadleBlowArMax";
            this.txtLadleBlowArMax.Precision = 0;
            //
            this.txtLadleBlowArMax.Size = new System.Drawing.Size(100, 21);
            this.txtLadleBlowArMax.TabIndex = 21;
            this.txtLadleBlowArMax.ToolTipValid = this.toolTip1;
          //
            this.txtLadleBlowArMax.ValidEable = true;
            this.txtLadleBlowArMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtDifSteelCutLengthMax
            // 
            this.txtDifSteelCutLengthMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "DifSteel_Cut_Length_Max", true));
            //
            this.txtDifSteelCutLengthMax.EnableNull = false;
            this.txtDifSteelCutLengthMax.ErropPr = this.errorProvider1;
            //
            this.txtDifSteelCutLengthMax.Length = 0;
            this.txtDifSteelCutLengthMax.Location = new System.Drawing.Point(450, 46);
            this.txtDifSteelCutLengthMax.Max = 9999;
            ////
            //
            this.txtDifSteelCutLengthMax.MaxStrLength = 0;
            this.txtDifSteelCutLengthMax.Min = 0;
            ////
            //
            this.txtDifSteelCutLengthMax.MinStrLength = 0;
            this.txtDifSteelCutLengthMax.Name = "txtDifSteelCutLengthMax";
            this.txtDifSteelCutLengthMax.Precision = 0;
            //
            this.txtDifSteelCutLengthMax.Size = new System.Drawing.Size(100, 21);
            this.txtDifSteelCutLengthMax.TabIndex = 11;
            this.txtDifSteelCutLengthMax.ToolTipValid = this.toolTip1;
          //
            this.txtDifSteelCutLengthMax.ValidEable = true;
            this.txtDifSteelCutLengthMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMoldShakeBase
            // 
            this.txtMoldShakeBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Mold_Shake_Base", true));
            //
            this.txtMoldShakeBase.EnableNull = false;
            this.txtMoldShakeBase.ErropPr = this.errorProvider1;
            //
            this.txtMoldShakeBase.Length = 0;
            this.txtMoldShakeBase.Location = new System.Drawing.Point(134, 46);
            this.txtMoldShakeBase.Max = 9999;
            ////
            //
            this.txtMoldShakeBase.MaxStrLength = 0;
            this.txtMoldShakeBase.Min = 0;
            ////
            //
            this.txtMoldShakeBase.MinStrLength = 0;
            this.txtMoldShakeBase.Name = "txtMoldShakeBase";
            this.txtMoldShakeBase.Precision = 0;
            //
            this.txtMoldShakeBase.Size = new System.Drawing.Size(100, 21);
            this.txtMoldShakeBase.TabIndex = 1;
            this.txtMoldShakeBase.ToolTipValid = this.toolTip1;
          //
            this.txtMoldShakeBase.ValidEable = true;
            this.txtMoldShakeBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtBloomLowBase
            // 
            this.txtBloomLowBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Bloom_Low_Base", true));
            //
            this.txtBloomLowBase.EnableNull = false;
            this.txtBloomLowBase.ErropPr = this.errorProvider1;
            //
            this.txtBloomLowBase.Length = 0;
            this.txtBloomLowBase.Location = new System.Drawing.Point(763, 254);
            this.txtBloomLowBase.Max = 9999;
            ////
            //
            this.txtBloomLowBase.MaxStrLength = 0;
            this.txtBloomLowBase.Min = 0;
            ////
            //
            this.txtBloomLowBase.MinStrLength = 0;
            this.txtBloomLowBase.Name = "txtBloomLowBase";
            this.txtBloomLowBase.Precision = 0;
            //
            this.txtBloomLowBase.Size = new System.Drawing.Size(100, 21);
            this.txtBloomLowBase.TabIndex = 29;
            this.txtBloomLowBase.ToolTipValid = this.toolTip1;
          //
            this.txtBloomLowBase.ValidEable = true;
            this.txtBloomLowBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtBlowArMax
            // 
            this.txtBlowArMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Blow_Ar_Max", true));
            //
            this.txtBlowArMax.EnableNull = false;
            this.txtBlowArMax.ErropPr = this.errorProvider1;
            //
            this.txtBlowArMax.Length = 0;
            this.txtBlowArMax.Location = new System.Drawing.Point(450, 254);
            this.txtBlowArMax.Max = 9999;
            ////
            //
            this.txtBlowArMax.MaxStrLength = 0;
            this.txtBlowArMax.Min = 0;
            ////
            //
            this.txtBlowArMax.MinStrLength = 0;
            this.txtBlowArMax.Name = "txtBlowArMax";
            this.txtBlowArMax.Precision = 0;
            //
            this.txtBlowArMax.Size = new System.Drawing.Size(100, 21);
            this.txtBlowArMax.TabIndex = 19;
            this.txtBlowArMax.ToolTipValid = this.toolTip1;
          //
            this.txtBlowArMax.ValidEable = true;
            this.txtBlowArMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCutTrailMax
            // 
            this.txtCutTrailMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cut_Trail_Max", true));
            //
            this.txtCutTrailMax.EnableNull = false;
            this.txtCutTrailMax.ErropPr = this.errorProvider1;
            //
            this.txtCutTrailMax.Length = 0;
            this.txtCutTrailMax.Location = new System.Drawing.Point(134, 254);
            this.txtCutTrailMax.Max = 9999;
            ////
            //
            this.txtCutTrailMax.MaxStrLength = 0;
            this.txtCutTrailMax.Min = 0;
            ////
            //
            this.txtCutTrailMax.MinStrLength = 0;
            this.txtCutTrailMax.Name = "txtCutTrailMax";
            this.txtCutTrailMax.Precision = 0;
            //
            this.txtCutTrailMax.Size = new System.Drawing.Size(100, 21);
            this.txtCutTrailMax.TabIndex = 9;
            this.txtCutTrailMax.ToolTipValid = this.toolTip1;
          //
            this.txtCutTrailMax.ValidEable = true;
            this.txtCutTrailMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtStaySteelTimeMax
            // 
            this.txtStaySteelTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Stay_Steel_Time_Max", true));
            //
            this.txtStaySteelTimeMax.EnableNull = false;
            this.txtStaySteelTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtStaySteelTimeMax.Length = 0;
            this.txtStaySteelTimeMax.Location = new System.Drawing.Point(763, 150);
            this.txtStaySteelTimeMax.Max = 99999;
            ////
            //
            this.txtStaySteelTimeMax.MaxStrLength = 0;
            this.txtStaySteelTimeMax.Min = 0;
            ////
            //
            this.txtStaySteelTimeMax.MinStrLength = 0;
            this.txtStaySteelTimeMax.Name = "txtStaySteelTimeMax";
            this.txtStaySteelTimeMax.Precision = 0;
            //
            this.txtStaySteelTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtStaySteelTimeMax.TabIndex = 25;
            this.txtStaySteelTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtStaySteelTimeMax.ValidEable = true;
            this.txtStaySteelTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtBloomFinishBase
            // 
            this.txtBloomFinishBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Bloom_Finish_Base", true));
            //
            this.txtBloomFinishBase.EnableNull = false;
            this.txtBloomFinishBase.ErropPr = this.errorProvider1;
            //
            this.txtBloomFinishBase.Length = 0;
            this.txtBloomFinishBase.Location = new System.Drawing.Point(450, 150);
            this.txtBloomFinishBase.Max = 9999;
            ////
            //
            this.txtBloomFinishBase.MaxStrLength = 0;
            this.txtBloomFinishBase.Min = 0;
            ////
            //
            this.txtBloomFinishBase.MinStrLength = 0;
            this.txtBloomFinishBase.Name = "txtBloomFinishBase";
            this.txtBloomFinishBase.Precision = 0;
            //
            this.txtBloomFinishBase.Size = new System.Drawing.Size(100, 21);
            this.txtBloomFinishBase.TabIndex = 15;
            this.txtBloomFinishBase.ToolTipValid = this.toolTip1;
          //
            this.txtBloomFinishBase.ValidEable = true;
            this.txtBloomFinishBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtASTCFlag
            // 
            this.txtASTCFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "ASTC_Flag", true));
            //
            this.txtASTCFlag.EnableNull = false;
            this.txtASTCFlag.ErropPr = this.errorProvider1;
            //
            this.txtASTCFlag.Length = 0;
            this.txtASTCFlag.Location = new System.Drawing.Point(134, 150);
            this.txtASTCFlag.Max = 9999;
            ////
            //
            this.txtASTCFlag.MaxStrLength = 0;
            this.txtASTCFlag.Min = 0;
            ////
            //
            this.txtASTCFlag.MinStrLength = 0;
            this.txtASTCFlag.Name = "txtASTCFlag";
            this.txtASTCFlag.Precision = 0;
            //
            this.txtASTCFlag.Size = new System.Drawing.Size(100, 21);
            this.txtASTCFlag.TabIndex = 5;
            this.txtASTCFlag.ToolTipValid = this.toolTip1;
          //
            this.txtASTCFlag.ValidEable = true;
            this.txtASTCFlag.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtTundishSpeedBase
            // 
            this.txtTundishSpeedBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Tundish_Speed_Base", true));
            //
            this.txtTundishSpeedBase.EnableNull = false;
            this.txtTundishSpeedBase.ErropPr = this.errorProvider1;
            //
            this.txtTundishSpeedBase.Length = 0;
            this.txtTundishSpeedBase.Location = new System.Drawing.Point(763, 228);
            this.txtTundishSpeedBase.Max = 9999;
            ////
            //
            this.txtTundishSpeedBase.MaxStrLength = 0;
            this.txtTundishSpeedBase.Min = 0;
            ////
            //
            this.txtTundishSpeedBase.MinStrLength = 0;
            this.txtTundishSpeedBase.Name = "txtTundishSpeedBase";
            this.txtTundishSpeedBase.Precision = 0;
            //
            this.txtTundishSpeedBase.Size = new System.Drawing.Size(100, 21);
            this.txtTundishSpeedBase.TabIndex = 28;
            this.txtTundishSpeedBase.ToolTipValid = this.toolTip1;
          //
            this.txtTundishSpeedBase.ValidEable = true;
            this.txtTundishSpeedBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtProtectSlagBase
            // 
            this.txtProtectSlagBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Protect_Slag_Base", true));
            //
            this.txtProtectSlagBase.EnableNull = false;
            this.txtProtectSlagBase.ErropPr = this.errorProvider1;
            //
            this.txtProtectSlagBase.Length = 0;
            this.txtProtectSlagBase.Location = new System.Drawing.Point(450, 228);
            this.txtProtectSlagBase.Max = 9999;
            ////
            //
            this.txtProtectSlagBase.MaxStrLength = 0;
            this.txtProtectSlagBase.Min = 0;
            ////
            //
            this.txtProtectSlagBase.MinStrLength = 0;
            this.txtProtectSlagBase.Name = "txtProtectSlagBase";
            this.txtProtectSlagBase.Precision = 0;
            //
            this.txtProtectSlagBase.Size = new System.Drawing.Size(100, 21);
            this.txtProtectSlagBase.TabIndex = 18;
            this.txtProtectSlagBase.ToolTipValid = this.toolTip1;
          //
            this.txtProtectSlagBase.ValidEable = true;
            this.txtProtectSlagBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtCutHeadMin
            // 
            this.txtCutHeadMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cut_Head_Min", true));
            //
            this.txtCutHeadMin.EnableNull = false;
            this.txtCutHeadMin.ErropPr = this.errorProvider1;
            //
            this.txtCutHeadMin.Length = 0;
            this.txtCutHeadMin.Location = new System.Drawing.Point(134, 228);
            this.txtCutHeadMin.Max = 9999;
            ////
            //
            this.txtCutHeadMin.MaxStrLength = 0;
            this.txtCutHeadMin.Min = 0;
            ////
            //
            this.txtCutHeadMin.MinStrLength = 0;
            this.txtCutHeadMin.Name = "txtCutHeadMin";
            this.txtCutHeadMin.Precision = 0;
            //
            this.txtCutHeadMin.Size = new System.Drawing.Size(100, 21);
            this.txtCutHeadMin.TabIndex = 8;
            this.txtCutHeadMin.ToolTipValid = this.toolTip1;
          //
            this.txtCutHeadMin.ValidEable = true;
            this.txtCutHeadMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtSlowColdBase
            // 
            this.txtSlowColdBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Slow_Cold_Base", true));
            //
            this.txtSlowColdBase.EnableNull = false;
            this.txtSlowColdBase.ErropPr = this.errorProvider1;
            //
            this.txtSlowColdBase.Length = 0;
            this.txtSlowColdBase.Location = new System.Drawing.Point(763, 202);
            this.txtSlowColdBase.Max = 9999;
            ////
            //
            this.txtSlowColdBase.MaxStrLength = 0;
            this.txtSlowColdBase.Min = 0;
            ////
            //
            this.txtSlowColdBase.MinStrLength = 0;
            this.txtSlowColdBase.Name = "txtSlowColdBase";
            this.txtSlowColdBase.Precision = 0;
            //
            this.txtSlowColdBase.Size = new System.Drawing.Size(100, 21);
            this.txtSlowColdBase.TabIndex = 27;
            this.txtSlowColdBase.ToolTipValid = this.toolTip1;
          //
            this.txtSlowColdBase.ValidEable = true;
            this.txtSlowColdBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTundishWeightMin
            // 
            this.txtTundishWeightMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Tundish_Weight_Min", true));
            //
            this.txtTundishWeightMin.EnableNull = false;
            this.txtTundishWeightMin.ErropPr = this.errorProvider1;
            //
            this.txtTundishWeightMin.Length = 0;
            this.txtTundishWeightMin.Location = new System.Drawing.Point(450, 202);
            this.txtTundishWeightMin.Max = 9999;
            ////
            //
            this.txtTundishWeightMin.MaxStrLength = 0;
            this.txtTundishWeightMin.Min = 0;
           // //
            //
            this.txtTundishWeightMin.MinStrLength = 0;
            this.txtTundishWeightMin.Name = "txtTundishWeightMin";
            this.txtTundishWeightMin.Precision = 0;
            //
            this.txtTundishWeightMin.Size = new System.Drawing.Size(100, 21);
            this.txtTundishWeightMin.TabIndex = 17;
            this.txtTundishWeightMin.ToolTipValid = this.toolTip1;
          //
            this.txtTundishWeightMin.ValidEable = true;
            this.txtTundishWeightMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCutHeadMax
            // 
            this.txtCutHeadMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cut_Head_Max", true));
            //
            this.txtCutHeadMax.EnableNull = false;
            this.txtCutHeadMax.ErropPr = this.errorProvider1;
            //
            this.txtCutHeadMax.Length = 0;
            this.txtCutHeadMax.Location = new System.Drawing.Point(134, 202);
            this.txtCutHeadMax.Max = 9999;
            ////
            //
            this.txtCutHeadMax.MaxStrLength = 0;
            this.txtCutHeadMax.Min = 0;
            ////
            //
            this.txtCutHeadMax.MinStrLength = 0;
            this.txtCutHeadMax.Name = "txtCutHeadMax";
            this.txtCutHeadMax.Precision = 0;
            //
            this.txtCutHeadMax.Size = new System.Drawing.Size(100, 21);
            this.txtCutHeadMax.TabIndex = 7;
            this.txtCutHeadMax.ToolTipValid = this.toolTip1;
          //
            this.txtCutHeadMax.ValidEable = true;
            this.txtCutHeadMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLiquidTemp
            // 
            this.txtLiquidTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Liquid_Temp", true));
            //
            this.txtLiquidTemp.EnableNull = false;
            this.txtLiquidTemp.ErropPr = this.errorProvider1;
            //
            this.txtLiquidTemp.Length = 0;
            this.txtLiquidTemp.Location = new System.Drawing.Point(763, 176);
            this.txtLiquidTemp.Max = 9999;
            ////
            //
            this.txtLiquidTemp.MaxStrLength = 0;
            this.txtLiquidTemp.Min = 0;
            ////
            //
            this.txtLiquidTemp.MinStrLength = 0;
            this.txtLiquidTemp.Name = "txtLiquidTemp";
            this.txtLiquidTemp.Precision = 0;
            //
            this.txtLiquidTemp.Size = new System.Drawing.Size(100, 21);
            this.txtLiquidTemp.TabIndex = 26;
            this.txtLiquidTemp.ToolTipValid = this.toolTip1;
          //
            this.txtLiquidTemp.ValidEable = true;
            this.txtLiquidTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCutCoefficient
            // 
            this.txtCutCoefficient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cut_Coefficient", true));
            //
            this.txtCutCoefficient.EnableNull = false;
            this.txtCutCoefficient.ErropPr = this.errorProvider1;
            //
            this.txtCutCoefficient.Length = 0;
            this.txtCutCoefficient.Location = new System.Drawing.Point(134, 176);
            this.txtCutCoefficient.Max = 9999;
            ////
            //
            this.txtCutCoefficient.MaxStrLength = 0;
            this.txtCutCoefficient.Min = 0;
            ////
            //
            this.txtCutCoefficient.MinStrLength = 0;
            this.txtCutCoefficient.Name = "txtCutCoefficient";
            this.txtCutCoefficient.Precision = 0;
            //
            this.txtCutCoefficient.Size = new System.Drawing.Size(100, 21);
            this.txtCutCoefficient.TabIndex = 6;
            this.txtCutCoefficient.ToolTipValid = this.toolTip1;
          //
            this.txtCutCoefficient.ValidEable = true;
            this.txtCutCoefficient.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtBlowArMin
            // 
            this.txtBlowArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Blow_Ar_Min", true));
            //
            this.txtBlowArMin.EnableNull = false;
            this.txtBlowArMin.ErropPr = this.errorProvider1;
            //
            this.txtBlowArMin.Length = 0;
            this.txtBlowArMin.Location = new System.Drawing.Point(763, 20);
            this.txtBlowArMin.Max = 99999;
            ////
            //
            this.txtBlowArMin.MaxStrLength = 0;
            this.txtBlowArMin.Min = 0;
            ////
            //
            this.txtBlowArMin.MinStrLength = 0;
            this.txtBlowArMin.Name = "txtBlowArMin";
            this.txtBlowArMin.Precision = 0;
            //
            this.txtBlowArMin.Size = new System.Drawing.Size(100, 21);
            this.txtBlowArMin.TabIndex = 20;
            this.txtBlowArMin.ToolTipValid = this.toolTip1;
          //
            this.txtBlowArMin.ValidEable = true;
            this.txtBlowArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHoldSteelTimeMax
            // 
            this.txtHoldSteelTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hold_Steel_Time_Max", true));
            //
            this.txtHoldSteelTimeMax.EnableNull = false;
            this.txtHoldSteelTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtHoldSteelTimeMax.Length = 0;
            this.txtHoldSteelTimeMax.Location = new System.Drawing.Point(763, 124);
            this.txtHoldSteelTimeMax.Max = 99999;
            ////
            //
            this.txtHoldSteelTimeMax.MaxStrLength = 0;
            this.txtHoldSteelTimeMax.Min = 0;
            ////
            //
            this.txtHoldSteelTimeMax.MinStrLength = 0;
            this.txtHoldSteelTimeMax.Name = "txtHoldSteelTimeMax";
            this.txtHoldSteelTimeMax.Precision = 0;
            //
            this.txtHoldSteelTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtHoldSteelTimeMax.TabIndex = 24;
            this.txtHoldSteelTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtHoldSteelTimeMax.ValidEable = true;
            this.txtHoldSteelTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCutTrailMin
            // 
            this.txtCutTrailMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cut_Trail_Min", true));
            //
            this.txtCutTrailMin.EnableNull = false;
            this.txtCutTrailMin.ErropPr = this.errorProvider1;
            //
            this.txtCutTrailMin.Length = 0;
            this.txtCutTrailMin.Location = new System.Drawing.Point(450, 20);
            this.txtCutTrailMin.Max = 9999;
            ////
            //
            this.txtCutTrailMin.MaxStrLength = 0;
            this.txtCutTrailMin.Min = 0;
            ////
            //
            this.txtCutTrailMin.MinStrLength = 0;
            this.txtCutTrailMin.Name = "txtCutTrailMin";
            this.txtCutTrailMin.Precision = 0;
            //
            this.txtCutTrailMin.Size = new System.Drawing.Size(100, 21);
            this.txtCutTrailMin.TabIndex = 10;
            this.txtCutTrailMin.ToolTipValid = this.toolTip1;
          //
            this.txtCutTrailMin.ValidEable = true;
            this.txtCutTrailMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtMarkCutLengthMin
            // 
            this.txtMarkCutLengthMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Mark_Cut_Length_Min", true));
            //
            this.txtMarkCutLengthMin.EnableNull = false;
            this.txtMarkCutLengthMin.ErropPr = this.errorProvider1;
            //
            this.txtMarkCutLengthMin.Length = 0;
            this.txtMarkCutLengthMin.Location = new System.Drawing.Point(450, 124);
            this.txtMarkCutLengthMin.Max = 9999;
            ////
            //
            this.txtMarkCutLengthMin.MaxStrLength = 0;
            this.txtMarkCutLengthMin.Min = 0;
            ////
            //
            this.txtMarkCutLengthMin.MinStrLength = 0;
            this.txtMarkCutLengthMin.Name = "txtMarkCutLengthMin";
            this.txtMarkCutLengthMin.Precision = 0;
            //
            this.txtMarkCutLengthMin.Size = new System.Drawing.Size(100, 21);
            this.txtMarkCutLengthMin.TabIndex = 14;
            this.txtMarkCutLengthMin.ToolTipValid = this.toolTip1;
          //
            this.txtMarkCutLengthMin.ValidEable = true;
            this.txtMarkCutLengthMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtLadleBlowArMin
            // 
            this.txtLadleBlowArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Ladle_Blow_Ar_Min", true));
            //
            this.txtLadleBlowArMin.EnableNull = false;
            this.txtLadleBlowArMin.ErropPr = this.errorProvider1;
            //
            this.txtLadleBlowArMin.Length = 0;
            this.txtLadleBlowArMin.Location = new System.Drawing.Point(763, 72);
            this.txtLadleBlowArMin.Max = 99999;
            ////
            //
            this.txtLadleBlowArMin.MaxStrLength = 0;
            this.txtLadleBlowArMin.Min = 0;
            ////
            //
            this.txtLadleBlowArMin.MinStrLength = 0;
            this.txtLadleBlowArMin.Name = "txtLadleBlowArMin";
            this.txtLadleBlowArMin.Precision = 0;
            //
            this.txtLadleBlowArMin.Size = new System.Drawing.Size(100, 21);
            this.txtLadleBlowArMin.TabIndex = 22;
            this.txtLadleBlowArMin.ToolTipValid = this.toolTip1;
          //
            this.txtLadleBlowArMin.ValidEable = true;
            this.txtLadleBlowArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMoldColdBase
            // 
            this.txtMoldColdBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Mold_Cold_Base", true));
            //
            this.txtMoldColdBase.EnableNull = false;
            this.txtMoldColdBase.ErropPr = this.errorProvider1;
            //
            this.txtMoldColdBase.Length = 0;
            this.txtMoldColdBase.Location = new System.Drawing.Point(134, 20);
            this.txtMoldColdBase.Max = 9999;
            ////
            //
            this.txtMoldColdBase.MaxStrLength = 0;
            this.txtMoldColdBase.Min = 0;
            ////
            //
            this.txtMoldColdBase.MinStrLength = 0;
            this.txtMoldColdBase.Name = "txtMoldColdBase";
            this.txtMoldColdBase.Precision = 0;
            //
            this.txtMoldColdBase.Size = new System.Drawing.Size(100, 21);
            this.txtMoldColdBase.TabIndex = 0;
            this.txtMoldColdBase.ToolTipValid = this.toolTip1;
          //
            this.txtMoldColdBase.ValidEable = true;
            this.txtMoldColdBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtDifSteelCutLengthMin
            // 
            this.txtDifSteelCutLengthMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "DifSteel_Cut_Length_Min", true));
            //
            this.txtDifSteelCutLengthMin.EnableNull = false;
            this.txtDifSteelCutLengthMin.ErropPr = this.errorProvider1;
            //
            this.txtDifSteelCutLengthMin.Length = 0;
            this.txtDifSteelCutLengthMin.Location = new System.Drawing.Point(450, 72);
            this.txtDifSteelCutLengthMin.Max = 9999;
            ////
            //
            this.txtDifSteelCutLengthMin.MaxStrLength = 0;
            this.txtDifSteelCutLengthMin.Min = 0;
            ////
            //
            this.txtDifSteelCutLengthMin.MinStrLength = 0;
            this.txtDifSteelCutLengthMin.Name = "txtDifSteelCutLengthMin";
            this.txtDifSteelCutLengthMin.Precision = 0;
            //
            this.txtDifSteelCutLengthMin.Size = new System.Drawing.Size(100, 21);
            this.txtDifSteelCutLengthMin.TabIndex = 12;
            this.txtDifSteelCutLengthMin.ToolTipValid = this.toolTip1;
          //
            this.txtDifSteelCutLengthMin.ValidEable = true;
            this.txtDifSteelCutLengthMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtElecMixFreq
            // 
            this.txtElecMixFreq.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Elec_Mix_Freq", true));
            //
            this.txtElecMixFreq.EnableNull = false;
            this.txtElecMixFreq.ErropPr = this.errorProvider1;
            //
            this.txtElecMixFreq.Length = 0;
            this.txtElecMixFreq.Location = new System.Drawing.Point(134, 124);
            this.txtElecMixFreq.Max = 9999;
            ////
            //
            this.txtElecMixFreq.MaxStrLength = 0;
            this.txtElecMixFreq.Min = 0;
            ////
            //
            this.txtElecMixFreq.MinStrLength = 0;
            this.txtElecMixFreq.Name = "txtElecMixFreq";
            this.txtElecMixFreq.Precision = 0;
            //
            this.txtElecMixFreq.Size = new System.Drawing.Size(100, 21);
            this.txtElecMixFreq.TabIndex = 4;
            this.txtElecMixFreq.ToolTipValid = this.toolTip1;
          //
            this.txtElecMixFreq.ValidEable = true;
            this.txtElecMixFreq.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtSecColdBase
            // 
            this.txtSecColdBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Sec_Cold_Base", true));
            //
            this.txtSecColdBase.EnableNull = false;
            this.txtSecColdBase.ErropPr = this.errorProvider1;
            //
            this.txtSecColdBase.Length = 0;
            this.txtSecColdBase.Location = new System.Drawing.Point(134, 72);
            this.txtSecColdBase.Max = 9999;
            ////
            //
            this.txtSecColdBase.MaxStrLength = 0;
            this.txtSecColdBase.Min = 0;
            ////
            //
            this.txtSecColdBase.MinStrLength = 0;
            this.txtSecColdBase.Name = "txtSecColdBase";
            this.txtSecColdBase.Precision = 0;
            //
            this.txtSecColdBase.Size = new System.Drawing.Size(100, 21);
            this.txtSecColdBase.TabIndex = 2;
            this.txtSecColdBase.ToolTipValid = this.toolTip1;
          //
            this.txtSecColdBase.ValidEable = true;
            this.txtSecColdBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSteelGradeIndexProc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "炼钢记号:";
            // 
            // txtSteelGradeIndexProc
            // 
            this.txtSteelGradeIndexProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexProc.EnableNull = false;
            this.txtSteelGradeIndexProc.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexProc.Length = 8;
            this.txtSteelGradeIndexProc.Location = new System.Drawing.Point(86, 23);
            this.txtSteelGradeIndexProc.Max = 0;
            this.txtSteelGradeIndexProc.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexProc.MaxStrLength = 0;
            this.txtSteelGradeIndexProc.Min = 0;
            ////
            //
            this.txtSteelGradeIndexProc.MinStrLength = 0;
            this.txtSteelGradeIndexProc.Name = "txtSteelGradeIndexProc";
            this.txtSteelGradeIndexProc.Precision = 0;
            this.txtSteelGradeIndexProc.ReadOnly = true;
            //
            this.txtSteelGradeIndexProc.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexProc.TabIndex = 0;
            this.txtSteelGradeIndexProc.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexProc.ValidEable = true;
            this.txtSteelGradeIndexProc.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.rtxtNote);
            this.tabBase.Controls.Add(this.dtValidDate);
            this.tabBase.Controls.Add(this.txtNewCode);
            this.tabBase.Controls.Add(this.txtSteelGradeIndexBase);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(1012, 587);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本信息";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(116, 100);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(866, 449);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // dtValidDate
            // 
            this.dtValidDate.CustomFormat = "yyyy-MM-dd";
            this.dtValidDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBase, "Valid_Date", true));
            this.dtValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidDate.Location = new System.Drawing.Point(116, 45);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(181, 21);
            this.dtValidDate.TabIndex = 1;
            // 
            // txtNewCode
            // 
            this.txtNewCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "New_Code", true));
            //
            this.txtNewCode.EnableNull = true;
            this.txtNewCode.ErropPr = null;
            //
            this.txtNewCode.Length = 0;
            this.txtNewCode.Location = new System.Drawing.Point(116, 72);
            this.txtNewCode.Max = 0;
            ////
            //
            this.txtNewCode.MaxStrLength = 0;
            this.txtNewCode.Min = 0;
            ////
            //
            this.txtNewCode.MinStrLength = 0;
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Precision = 0;
            //
            this.txtNewCode.Size = new System.Drawing.Size(181, 21);
            this.txtNewCode.TabIndex = 2;
            this.txtNewCode.ToolTipValid = null;
          //
            this.txtNewCode.ValidEable = true;
            this.txtNewCode.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSteelGradeIndexBase
            // 
            this.txtSteelGradeIndexBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexBase.EnableNull = false;
            this.txtSteelGradeIndexBase.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexBase.Length = 8;
            this.txtSteelGradeIndexBase.Location = new System.Drawing.Point(116, 17);
            this.txtSteelGradeIndexBase.Max = 0;
            this.txtSteelGradeIndexBase.MaxLength = 8;
           // //
            //
            this.txtSteelGradeIndexBase.MaxStrLength = 0;
            this.txtSteelGradeIndexBase.Min = 0;
            ////
            //
            this.txtSteelGradeIndexBase.MinStrLength = 0;
            this.txtSteelGradeIndexBase.Name = "txtSteelGradeIndexBase";
            this.txtSteelGradeIndexBase.Precision = 0;
            this.txtSteelGradeIndexBase.ReadOnly = true;
            //
            this.txtSteelGradeIndexBase.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexBase.TabIndex = 0;
            this.txtSteelGradeIndexBase.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexBase.ValidEable = true;
            this.txtSteelGradeIndexBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生效日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "新试号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炼钢记号:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBase);
            this.tabControlMain.Controls.Add(this.tabProc);
            this.tabControlMain.Controls.Add(this.tabSpeed);
            this.tabControlMain.Controls.Add(this.tabTundish);
            this.tabControlMain.Controls.Add(this.tabFlux);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 68);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 612);
            this.tabControlMain.TabIndex = 2;
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = "";
            this.dsSteelGrade.InsertMethod = "";
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "1=2";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "";
            this.dsSteelGrade.UpdateMethod = "";
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGradeIndex,
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
            // 
            // CasterStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CasterStdMaintenFrm";
            this.TabText = "铸机制造标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CasterStdMaintenFrm_FormClosing_1);
            this.Load += new System.EventHandler(this.CasterStdMaintenFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFlux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).EndInit();
            this.tabFlux.ResumeLayout(false);
            this.hmiRootPanelLadle.ResumeLayout(false);
            this.hmiRootPanelLadle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFlux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFlux)).EndInit();
            this.bNavigatorFlux.ResumeLayout(false);
            this.bNavigatorFlux.PerformLayout();
            this.tabTundish.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabSpeed.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabProc.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsBase;
        private AppSvrHMI.L3DataSet dsProc;
        private AppSvrHMI.L3DataSet dsSpeed;
        private AppSvrHMI.L3DataSet dsTundish;
        private AppSvrHMI.L3DataSet dsFlux;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsProc;
        private System.Windows.Forms.BindingSource bsSpeed;
        private System.Windows.Forms.BindingSource bsTundish;
        private System.Windows.Forms.BindingSource bsFlux;
        private System.Windows.Forms.TabPage tabFlux;
        private HMIBase.HMIRootPanel hmiRootPanelLadle;
        private System.Windows.Forms.DataGridView dvFlux;
        private System.Windows.Forms.BindingNavigator bNavigatorFlux;
        private System.Windows.Forms.ToolStripButton btnAddFlux;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton btnDelFlux;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.TabPage tabTundish;
        private System.Windows.Forms.GroupBox groupBox8;
        private PxDataValid.PxTextBox txtSteelGradeIndexTundish;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TabPage tabSpeed;
        private System.Windows.Forms.GroupBox groupBox4;
        private PxDataValid.PxTextBox txtSteelGradeIndexSpeed;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TabPage tabProc;
        private System.Windows.Forms.GroupBox groupBox3;
        private PxDataValid.PxTextBox txtElecMixCurrent;
        private PxDataValid.PxTextBox txtMoldShakeBase;
        private PxDataValid.PxTextBox txtCutTrailMax;
        private PxDataValid.PxTextBox txtASTCFlag;
        private PxDataValid.PxTextBox txtCutHeadMin;
        private PxDataValid.PxTextBox txtCutHeadMax;
        private PxDataValid.PxTextBox txtCutCoefficient;
        private PxDataValid.PxTextBox txtMoldColdBase;
        private PxDataValid.PxTextBox txtElecMixFreq;
        private PxDataValid.PxTextBox txtSecColdBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox txtSteelGradeIndexProc;
        private System.Windows.Forms.TabPage tabBase;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.DateTimePicker dtValidDate;
        private PxDataValid.PxTextBox txtNewCode;
        private PxDataValid.PxTextBox txtSteelGradeIndexBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label52;
        private PxDataValid.PxTextBox txtChangeTimeMin;
        private PxDataValid.PxTextBox txtMarkCutLengthMax;
        private PxDataValid.PxTextBox txtLadleBlowArMax;
        private PxDataValid.PxTextBox txtDifSteelCutLengthMax;
        private PxDataValid.PxTextBox txtBloomLowBase;
        private PxDataValid.PxTextBox txtBlowArMax;
        private PxDataValid.PxTextBox txtStaySteelTimeMax;
        private PxDataValid.PxTextBox txtBloomFinishBase;
        private PxDataValid.PxTextBox txtTundishSpeedBase;
        private PxDataValid.PxTextBox txtProtectSlagBase;
        private PxDataValid.PxTextBox txtSlowColdBase;
        private PxDataValid.PxTextBox txtTundishWeightMin;
        private PxDataValid.PxTextBox txtLiquidTemp;
        private PxDataValid.PxTextBox txtBlowArMin;
        private PxDataValid.PxTextBox txtHoldSteelTimeMax;
        private PxDataValid.PxTextBox txtCutTrailMin;
        private PxDataValid.PxTextBox txtMarkCutLengthMin;
        private PxDataValid.PxTextBox txtLadleBlowArMin;
        private PxDataValid.PxTextBox txtDifSteelCutLengthMin;
        private PxDataValid.PxComboBox cmbTundishWaterType;
        private System.Windows.Forms.GroupBox groupBox1;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox2;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private PxDataValid.PxTextBox pxTextBox5;
        private PxDataValid.PxTextBox pxTextBox6;
        private PxDataValid.PxTextBox pxTextBox7;
        private PxDataValid.PxTextBox pxTextBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableValid_Date;
        private System.Data.DataColumn coldsBaseL3DataTableNew_Code;
        private System.Data.DataColumn coldsBaseL3DataTableNote;
        private System.Data.DataTable schemadsProc;
        private System.Data.DataColumn coldsProcL3DataTableGUID;
        private System.Data.DataColumn coldsProcL3DataTableName;
        private System.Data.DataColumn coldsProcL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsProcL3DataTableMold_Cold_Base;
        private System.Data.DataColumn coldsProcL3DataTableMold_Shake_Base;
        private System.Data.DataColumn coldsProcL3DataTableSec_Cold_Base;
        private System.Data.DataColumn coldsProcL3DataTableElec_Mix_Current;
        private System.Data.DataColumn coldsProcL3DataTableElec_Mix_Freq;
        private System.Data.DataColumn coldsProcL3DataTableASTC_Flag;
        private System.Data.DataColumn coldsProcL3DataTableCut_Coefficient;
        private System.Data.DataColumn coldsProcL3DataTableCut_Head_Max;
        private System.Data.DataColumn coldsProcL3DataTableCut_Head_Min;
        private System.Data.DataColumn coldsProcL3DataTableCut_Trail_Max;
        private System.Data.DataColumn coldsProcL3DataTableCut_Trail_Min;
        private System.Data.DataColumn coldsProcL3DataTableDifSteel_Cut_Length_Max;
        private System.Data.DataColumn coldsProcL3DataTableDifSteel_Cut_Length_Min;
        private System.Data.DataColumn coldsProcL3DataTableMark_Cut_Length_Max;
        private System.Data.DataColumn coldsProcL3DataTableMark_Cut_Length_Min;
        private System.Data.DataColumn coldsProcL3DataTableBloom_Finish_Base;
        private System.Data.DataColumn coldsProcL3DataTableTundish_Water_Type;
        private System.Data.DataColumn coldsProcL3DataTableTundish_Weight_Min;
        private System.Data.DataColumn coldsProcL3DataTableProtect_Slag_Base;
        private System.Data.DataColumn coldsProcL3DataTableBlow_Ar_Max;
        private System.Data.DataColumn coldsProcL3DataTableBlow_Ar_Min;
        private System.Data.DataColumn coldsProcL3DataTableLadle_Blow_Ar_Max;
        private System.Data.DataColumn coldsProcL3DataTableLadle_Blow_Ar_Min;
        private System.Data.DataColumn coldsProcL3DataTableChange_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableHold_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableStay_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableLiquid_Temp;
        private System.Data.DataColumn coldsProcL3DataTableSlow_Cold_Base;
        private System.Data.DataColumn coldsProcL3DataTableTundish_Speed_Base;
        private System.Data.DataColumn coldsProcL3DataTableBloom_Low_Base;
        private System.Data.DataTable schemadsSpeed;
        private System.Data.DataColumn coldsSpeedL3DataTableGUID;
        private System.Data.DataColumn coldsSpeedL3DataTableName;
        private System.Data.DataColumn coldsSpeedL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSpeedL3DataTableSpeed_Fir_Min;
        private System.Data.DataColumn coldsSpeedL3DataTableSpeed_Fir_Max;
        private System.Data.DataColumn coldsSpeedL3DataTableSpeed_Min;
        private System.Data.DataColumn coldsSpeedL3DataTableSpeed_Max;
        private System.Data.DataTable schemadsTundish;
        private System.Data.DataColumn coldsTundishL3DataTableGUID;
        private System.Data.DataColumn coldsTundishL3DataTableName;
        private System.Data.DataColumn coldsTundishL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsTundishL3DataTableTundish_Temp_Fir_Min;
        private System.Data.DataColumn coldsTundishL3DataTableTundish_Temp_Fir_Max;
        private System.Data.DataColumn coldsTundishL3DataTableTundish_Temp_Min;
        private System.Data.DataColumn coldsTundishL3DataTableTundish_Temp_Max;
        private System.Data.DataTable schemadsFlux;
        private System.Data.DataColumn coldsFluxL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsFluxL3DataTableTundish_Flux_Name;
        private System.Data.DataColumn coldsFluxL3DataTableTundish_Flux_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishFluxNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishFluxWeightDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsFluxL3DataTableGUID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
    }
}