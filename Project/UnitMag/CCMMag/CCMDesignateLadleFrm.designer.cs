namespace UnitMag.CCMMag
{
    partial class CCMDesignateLadleFrm
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
            this.dsSteels = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteels = new System.Data.DataTable();
            this.coldsSteelsL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsSteelsL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelsL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableWeight = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableHeatGrade = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableClassify = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableDecideFinalFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableBOFFinishedFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableLFFinishedFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableRHFinishedFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableCCMFinishedFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableFinalChemiclaFlag = new System.Data.DataColumn();
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag = new System.Data.DataColumn();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCCMID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnArrive = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirmHeat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSteels = new System.Windows.Forms.DataGridView();
            this.cmdArrive = new AppSvrHMI.L3Command(this.components);
            this.cmdDesignate = new AppSvrHMI.L3Command(this.components);
            this.paramSteel = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSteels
            // 
            this.dsSteels.DataSetName = "L3DataSet";
            this.dsSteels.DeleteMethod = "";
            this.dsSteels.InsertMethod = "";
            this.dsSteels.L3DataAdapter = this.Adapter;
            this.dsSteels.LoadEvent = "Click";
            this.dsSteels.LoadTrigger = null;
            this.dsSteels.RefreshValve = 1000;
            this.dsSteels.SourceCommand = null;
            this.dsSteels.SourceCondition = null;
            this.dsSteels.SourceMethod = "GetInputSteels";
            this.dsSteels.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSteels.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.dsSteels.SubscribeTarget = null;
            this.dsSteels.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteels});
            this.dsSteels.UpdateEvent = "Click";
            this.dsSteels.UpdateMethod = "";
            this.dsSteels.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteels
            // 
            this.schemadsSteels.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelsL3DataTableMaterialID,
            this.coldsSteelsL3DataTablePreHeatID,
            this.coldsSteelsL3DataTableSteelGradeIndex,
            this.coldsSteelsL3DataTablePre_SteelGradeIndex,
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex,
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex,
            this.coldsSteelsL3DataTableHeatID,
            this.coldsSteelsL3DataTableLadleID,
            this.coldsSteelsL3DataTableWeight,
            this.coldsSteelsL3DataTableDecide_Code,
            this.coldsSteelsL3DataTableHeatGrade,
            this.coldsSteelsL3DataTableClassify,
            this.coldsSteelsL3DataTableExceptional_Code,
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag,
            this.coldsSteelsL3DataTableDecideFinalFlag,
            this.coldsSteelsL3DataTableBOFFinishedFlag,
            this.coldsSteelsL3DataTableLFFinishedFlag,
            this.coldsSteelsL3DataTableRHFinishedFlag,
            this.coldsSteelsL3DataTableCCMFinishedFlag,
            this.coldsSteelsL3DataTableFinalChemiclaFlag,
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag});
            this.schemadsSteels.TableName = "L3DataTable";
            // 
            // coldsSteelsL3DataTableMaterialID
            // 
            this.coldsSteelsL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsSteelsL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsSteelsL3DataTableMaterialID.DefaultValue = "";
            this.coldsSteelsL3DataTableMaterialID.Namespace = "";
            // 
            // coldsSteelsL3DataTablePreHeatID
            // 
            this.coldsSteelsL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsSteelsL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsSteelsL3DataTablePreHeatID.DefaultValue = "";
            this.coldsSteelsL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsSteelsL3DataTableSteelGradeIndex
            // 
            this.coldsSteelsL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelsL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelsL3DataTableSteelGradeIndex.DefaultValue = "";
            this.coldsSteelsL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelsL3DataTablePre_SteelGradeIndex
            // 
            this.coldsSteelsL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsSteelsL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsSteelsL3DataTablePre_SteelGradeIndex.DefaultValue = "";
            this.coldsSteelsL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsSteelsL3DataTableFinal_SteelGradeIndex
            // 
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex.Caption = "Final_SteelGradeIndex";
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex.ColumnName = "Final_SteelGradeIndex";
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex.DefaultValue = "";
            this.coldsSteelsL3DataTableFinal_SteelGradeIndex.Namespace = "";
            // 
            // coldsSteelsL3DataTableDecide_SteelGradeIndex
            // 
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex.Caption = "Decide_SteelGradeIndex";
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex.ColumnName = "Decide_SteelGradeIndex";
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex.DefaultValue = "";
            this.coldsSteelsL3DataTableDecide_SteelGradeIndex.Namespace = "";
            // 
            // coldsSteelsL3DataTableHeatID
            // 
            this.coldsSteelsL3DataTableHeatID.Caption = "HeatID";
            this.coldsSteelsL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSteelsL3DataTableHeatID.DefaultValue = "";
            this.coldsSteelsL3DataTableHeatID.Namespace = "";
            // 
            // coldsSteelsL3DataTableLadleID
            // 
            this.coldsSteelsL3DataTableLadleID.Caption = "LadleID";
            this.coldsSteelsL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsSteelsL3DataTableLadleID.DefaultValue = "";
            this.coldsSteelsL3DataTableLadleID.Namespace = "";
            // 
            // coldsSteelsL3DataTableWeight
            // 
            this.coldsSteelsL3DataTableWeight.Caption = "Weight";
            this.coldsSteelsL3DataTableWeight.ColumnName = "Weight";
            this.coldsSteelsL3DataTableWeight.DataType = typeof(float);
            this.coldsSteelsL3DataTableWeight.DefaultValue = 0F;
            this.coldsSteelsL3DataTableWeight.Namespace = "";
            // 
            // coldsSteelsL3DataTableDecide_Code
            // 
            this.coldsSteelsL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsSteelsL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsSteelsL3DataTableDecide_Code.DefaultValue = "";
            this.coldsSteelsL3DataTableDecide_Code.Namespace = "";
            // 
            // coldsSteelsL3DataTableHeatGrade
            // 
            this.coldsSteelsL3DataTableHeatGrade.Caption = "HeatGrade";
            this.coldsSteelsL3DataTableHeatGrade.ColumnName = "HeatGrade";
            this.coldsSteelsL3DataTableHeatGrade.DefaultValue = "";
            this.coldsSteelsL3DataTableHeatGrade.Namespace = "";
            // 
            // coldsSteelsL3DataTableClassify
            // 
            this.coldsSteelsL3DataTableClassify.Caption = "Classify";
            this.coldsSteelsL3DataTableClassify.ColumnName = "Classify";
            this.coldsSteelsL3DataTableClassify.DefaultValue = "";
            this.coldsSteelsL3DataTableClassify.Namespace = "";
            // 
            // coldsSteelsL3DataTableExceptional_Code
            // 
            this.coldsSteelsL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsSteelsL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsSteelsL3DataTableExceptional_Code.DefaultValue = "";
            this.coldsSteelsL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsSteelsL3DataTableDecideSteelGradeIndexFlag
            // 
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag.Caption = "DecideSteelGradeIndexFlag";
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag.ColumnName = "DecideSteelGradeIndexFlag";
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableDecideSteelGradeIndexFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableDecideFinalFlag
            // 
            this.coldsSteelsL3DataTableDecideFinalFlag.Caption = "DecideFinalFlag";
            this.coldsSteelsL3DataTableDecideFinalFlag.ColumnName = "DecideFinalFlag";
            this.coldsSteelsL3DataTableDecideFinalFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableDecideFinalFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableBOFFinishedFlag
            // 
            this.coldsSteelsL3DataTableBOFFinishedFlag.Caption = "BOFFinishedFlag";
            this.coldsSteelsL3DataTableBOFFinishedFlag.ColumnName = "BOFFinishedFlag";
            this.coldsSteelsL3DataTableBOFFinishedFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableBOFFinishedFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableLFFinishedFlag
            // 
            this.coldsSteelsL3DataTableLFFinishedFlag.Caption = "LFFinishedFlag";
            this.coldsSteelsL3DataTableLFFinishedFlag.ColumnName = "LFFinishedFlag";
            this.coldsSteelsL3DataTableLFFinishedFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableLFFinishedFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableRHFinishedFlag
            // 
            this.coldsSteelsL3DataTableRHFinishedFlag.Caption = "RHFinishedFlag";
            this.coldsSteelsL3DataTableRHFinishedFlag.ColumnName = "RHFinishedFlag";
            this.coldsSteelsL3DataTableRHFinishedFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableRHFinishedFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableCCMFinishedFlag
            // 
            this.coldsSteelsL3DataTableCCMFinishedFlag.Caption = "CCMFinishedFlag";
            this.coldsSteelsL3DataTableCCMFinishedFlag.ColumnName = "CCMFinishedFlag";
            this.coldsSteelsL3DataTableCCMFinishedFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableCCMFinishedFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableFinalChemiclaFlag
            // 
            this.coldsSteelsL3DataTableFinalChemiclaFlag.Caption = "FinalChemiclaFlag";
            this.coldsSteelsL3DataTableFinalChemiclaFlag.ColumnName = "FinalChemiclaFlag";
            this.coldsSteelsL3DataTableFinalChemiclaFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableFinalChemiclaFlag.Namespace = "";
            // 
            // coldsSteelsL3DataTableDivFinalChemiclaFlag
            // 
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag.Caption = "DivFinalChemiclaFlag";
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag.ColumnName = "DivFinalChemiclaFlag";
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag.DefaultValue = "";
            this.coldsSteelsL3DataTableDivFinalChemiclaFlag.Namespace = "";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbCCMID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 29);
            this.panel3.TabIndex = 70;
            // 
            // lbCCMID
            // 
            this.lbCCMID.AutoSize = true;
            this.lbCCMID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCCMID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCCMID.Location = new System.Drawing.Point(63, 9);
            this.lbCCMID.Name = "lbCCMID";
            this.lbCCMID.Size = new System.Drawing.Size(38, 12);
            this.lbCCMID.TabIndex = 73;
            this.lbCCMID.Text = "铸机:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 73;
            this.label2.Text = "铸机:";
            // 
            // btnArrive
            // 
            this.btnArrive.Location = new System.Drawing.Point(581, 3);
            this.btnArrive.Name = "btnArrive";
            this.btnArrive.Size = new System.Drawing.Size(75, 23);
            this.btnArrive.TabIndex = 71;
            this.btnArrive.Text = "钢包到达";
            this.btnArrive.UseVisualStyleBackColor = true;
            this.btnArrive.Click += new System.EventHandler(this.btnArrive_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.Location = new System.Drawing.Point(743, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "返回";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirmHeat
            // 
            this.btnConfirmHeat.Location = new System.Drawing.Point(662, 3);
            this.btnConfirmHeat.Name = "btnConfirmHeat";
            this.btnConfirmHeat.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmHeat.TabIndex = 71;
            this.btnConfirmHeat.Text = "指定炉号";
            this.btnConfirmHeat.UseVisualStyleBackColor = true;
            this.btnConfirmHeat.Click += new System.EventHandler(this.btnConfirmHeat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmHeat);
            this.flowLayoutPanel1.Controls.Add(this.btnArrive);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 329);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 54);
            this.flowLayoutPanel1.TabIndex = 73;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 300);
            this.tabControl1.TabIndex = 74;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hmiRootPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "钢包(炉次)信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvSteels);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(807, 269);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvSteels
            // 
            this.dvSteels.AllowUserToAddRows = false;
            this.dvSteels.AutoGenerateColumns = false;
            this.dvSteels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvSteels.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvSteels.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSteels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSteels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialIDDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.finalSteelGradeIndexDataGridViewTextBoxColumn,
            this.decideSteelGradeIndexDataGridViewTextBoxColumn,
            this.HeatID,
            this.ladleIDDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dvSteels.DataMember = "L3DataTable";
            this.dvSteels.DataSource = this.dsSteels;
            this.dvSteels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSteels.Location = new System.Drawing.Point(0, 0);
            this.dvSteels.MultiSelect = false;
            this.dvSteels.Name = "dvSteels";
            this.dvSteels.RowTemplate.Height = 23;
            this.dvSteels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSteels.Size = new System.Drawing.Size(803, 265);
            this.dvSteels.TabIndex = 0;
            // 
            // cmdArrive
            // 
            this.cmdArrive.Adapter = this.Adapter;
            this.cmdArrive.MergeReturnTarget = false;
            this.cmdArrive.Method = "SteelArrived";
            this.cmdArrive.Object = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.cmdArrive.ReturnTarget = null;
            this.cmdArrive.ReturnTargetProperty = null;
            this.cmdArrive.Trigger = null;
            this.cmdArrive.TriggerEvent = "Click";
            // 
            // cmdDesignate
            // 
            this.cmdDesignate.Adapter = this.Adapter;
            this.cmdDesignate.MergeReturnTarget = false;
            this.cmdDesignate.Method = "DesignateSteel";
            this.cmdDesignate.Object = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.cmdDesignate.Parameters.Add(this.paramSteel);
            this.cmdDesignate.ReturnTarget = null;
            this.cmdDesignate.ReturnTargetProperty = null;
            this.cmdDesignate.Trigger = null;
            this.cmdDesignate.TriggerEvent = "Click";
            // 
            // paramSteel
            // 
            this.paramSteel.AcceptAfterExecuted = false;
            this.paramSteel.ConstantValue = null;
            this.paramSteel.MergeTarget = false;
            this.paramSteel.SourceFilter = null;
            this.paramSteel.SourceObject = null;
            this.paramSteel.SourceProperty = null;
            this.paramSteel.TargetObject = null;
            this.paramSteel.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'UnitMag\'";
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
            this.coldsErrorL3DataTableERROR_CODE,
            this.coldsErrorL3DataTableERROR_DES});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableERROR_CODE
            // 
            this.coldsErrorL3DataTableERROR_CODE.Caption = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.ColumnName = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.Namespace = "";
            // 
            // coldsErrorL3DataTableERROR_DES
            // 
            this.coldsErrorL3DataTableERROR_DES.Caption = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.ColumnName = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.Namespace = "";
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            // 
            // finalSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Final_SteelGradeIndex";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.Name = "finalSteelGradeIndexDataGridViewTextBoxColumn";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // decideSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.decideSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Decide_SteelGradeIndex";
            this.decideSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "决定炼钢记号";
            this.decideSteelGradeIndexDataGridViewTextBoxColumn.Name = "decideSteelGradeIndexDataGridViewTextBoxColumn";
            this.decideSteelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            // 
            // ladleIDDataGridViewTextBoxColumn
            // 
            this.ladleIDDataGridViewTextBoxColumn.DataPropertyName = "LadleID";
            this.ladleIDDataGridViewTextBoxColumn.HeaderText = "钢包号";
            this.ladleIDDataGridViewTextBoxColumn.Name = "ladleIDDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "钢水重量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // CCMDesignateLadleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(821, 383);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "CCMDesignateLadleFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "指定到达钢水炉号";
            ((System.ComponentModel.ISupportInitialize)(this.dsSteels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSteels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3DataSet dsSteels;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmHeat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSteels;
        private System.Windows.Forms.Label lbCCMID;
        private System.Windows.Forms.Button btnArrive;
        private System.Data.DataTable schemadsSteels;
        private System.Data.DataColumn coldsSteelsL3DataTableMaterialID;
        private System.Data.DataColumn coldsSteelsL3DataTablePreHeatID;
        private System.Data.DataColumn coldsSteelsL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelsL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsSteelsL3DataTableFinal_SteelGradeIndex;
        private System.Data.DataColumn coldsSteelsL3DataTableDecide_SteelGradeIndex;
        private System.Data.DataColumn coldsSteelsL3DataTableHeatID;
        private System.Data.DataColumn coldsSteelsL3DataTableLadleID;
        private System.Data.DataColumn coldsSteelsL3DataTableWeight;
        private System.Data.DataColumn coldsSteelsL3DataTableDecide_Code;
        private System.Data.DataColumn coldsSteelsL3DataTableHeatGrade;
        private System.Data.DataColumn coldsSteelsL3DataTableClassify;
        private System.Data.DataColumn coldsSteelsL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsSteelsL3DataTableDecideSteelGradeIndexFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableDecideFinalFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableBOFFinishedFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableLFFinishedFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableRHFinishedFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableCCMFinishedFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableFinalChemiclaFlag;
        private System.Data.DataColumn coldsSteelsL3DataTableDivFinalChemiclaFlag;
        private AppSvrHMI.L3Command cmdArrive;
        private AppSvrHMI.L3Command cmdDesignate;
        private AppSvrHMI.L3CommandParameter paramSteel;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
    }
}