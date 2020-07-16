﻿namespace UnitMag.BOFMag
{
    partial class BOFHeatFinalDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOFHeatFinalDataFrm));
            this.bsBOFData = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOFData = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.cxCheckFlag = new System.Windows.Forms.CheckBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.schemadsBOFData = new System.Data.DataTable();
            this.coldsBOFDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableName = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableShift = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableHeadFurnace = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableAssistant = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableSecondHand = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableStatisticsDate = new System.Data.DataColumn();
            this.coldsBOFDataL3DataTableLocked = new System.Data.DataColumn();
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
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataModify = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbBOFID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBOFData = new System.Windows.Forms.DataGridView();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsHeatIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.dsTempt = new AppSvrHMI.L3DataSet();
            this.sendSheet = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.headFurnaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBOFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempt)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBOFData
            // 
            this.bsBOFData.DataMember = "L3DataTable";
            this.bsBOFData.DataSource = this.dsBOFData;
            // 
            // dsBOFData
            // 
            this.dsBOFData.AutoLoad = true;
            this.dsBOFData.AutoSubscribe = true;
            this.dsBOFData.DataSetName = "L3DataSet";
            this.dsBOFData.DeleteMethod = null;
            this.dsBOFData.InsertMethod = null;
            this.dsBOFData.L3DataAdapter = this.Adapter;
            this.dsBOFData.LoadEvent = "Click";
            this.dsBOFData.LoadTrigger = null;
            this.dsBOFData.RefreshValve = 1000;
            this.dsBOFData.SourceCommand = null;
            this.dsBOFData.SourceCondition = "1=2";
            this.dsBOFData.SourceMethod = "";
            this.dsBOFData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFData.SourceURI = "XGMESLogic\\BOFMag\\CBOF_Base_Data";
            this.dsBOFData.SubscribeTarget = null;
            this.dsBOFData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFData});
            this.dsBOFData.UpdateEvent = "Click";
            this.dsBOFData.UpdateMethod = null;
            this.dsBOFData.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BOFbtnConfirm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(76, 22);
            this.btnConfirm.Text = "实绩确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cxCheckFlag
            // 
            this.Adapter.SetAccessRight(this.cxCheckFlag, "CheckBoxBOFInfo");
            this.cxCheckFlag.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cxCheckFlag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cxCheckFlag.Location = new System.Drawing.Point(362, 0);
            this.cxCheckFlag.Name = "cxCheckFlag";
            this.cxCheckFlag.Size = new System.Drawing.Size(99, 21);
            this.cxCheckFlag.TabIndex = 24;
            this.cxCheckFlag.Text = "数据维护";
            this.cxCheckFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cxCheckFlag.UseVisualStyleBackColor = false;
            // 
            // toolStripButton1
            // 
            this.Adapter.SetAccessRight(this.toolStripButton1, "LFbtnConfirm");
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "解锁";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // schemadsBOFData
            // 
            this.schemadsBOFData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFDataL3DataTableGUID,
            this.coldsBOFDataL3DataTableName,
            this.coldsBOFDataL3DataTableHeatID,
            this.coldsBOFDataL3DataTablePreHeatID,
            this.coldsBOFDataL3DataTableSteelGradeIndex,
            this.coldsBOFDataL3DataTableSteelGrade,
            this.coldsBOFDataL3DataTableShift,
            this.coldsBOFDataL3DataTableTeam,
            this.coldsBOFDataL3DataTableHeadFurnace,
            this.coldsBOFDataL3DataTableAssistant,
            this.coldsBOFDataL3DataTableSecondHand,
            this.coldsBOFDataL3DataTableProductionDate,
            this.coldsBOFDataL3DataTableStatisticsDate,
            this.coldsBOFDataL3DataTableLocked});
            this.schemadsBOFData.TableName = "L3DataTable";
            // 
            // coldsBOFDataL3DataTableGUID
            // 
            this.coldsBOFDataL3DataTableGUID.Caption = "GUID";
            this.coldsBOFDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsBOFDataL3DataTableGUID.Namespace = "";
            // 
            // coldsBOFDataL3DataTableName
            // 
            this.coldsBOFDataL3DataTableName.Caption = "Name";
            this.coldsBOFDataL3DataTableName.ColumnName = "Name";
            this.coldsBOFDataL3DataTableName.Namespace = "";
            // 
            // coldsBOFDataL3DataTableHeatID
            // 
            this.coldsBOFDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsBOFDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBOFDataL3DataTableHeatID.Namespace = "";
            // 
            // coldsBOFDataL3DataTablePreHeatID
            // 
            this.coldsBOFDataL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsBOFDataL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsBOFDataL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsBOFDataL3DataTableSteelGradeIndex
            // 
            this.coldsBOFDataL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBOFDataL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBOFDataL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBOFDataL3DataTableSteelGrade
            // 
            this.coldsBOFDataL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsBOFDataL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsBOFDataL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsBOFDataL3DataTableShift
            // 
            this.coldsBOFDataL3DataTableShift.Caption = "Shift";
            this.coldsBOFDataL3DataTableShift.ColumnName = "Shift";
            this.coldsBOFDataL3DataTableShift.Namespace = "";
            // 
            // coldsBOFDataL3DataTableTeam
            // 
            this.coldsBOFDataL3DataTableTeam.Caption = "Team";
            this.coldsBOFDataL3DataTableTeam.ColumnName = "Team";
            this.coldsBOFDataL3DataTableTeam.Namespace = "";
            // 
            // coldsBOFDataL3DataTableHeadFurnace
            // 
            this.coldsBOFDataL3DataTableHeadFurnace.Caption = "HeadFurnace";
            this.coldsBOFDataL3DataTableHeadFurnace.ColumnName = "HeadFurnace";
            this.coldsBOFDataL3DataTableHeadFurnace.Namespace = "";
            // 
            // coldsBOFDataL3DataTableAssistant
            // 
            this.coldsBOFDataL3DataTableAssistant.Caption = "Assistant";
            this.coldsBOFDataL3DataTableAssistant.ColumnName = "Assistant";
            this.coldsBOFDataL3DataTableAssistant.Namespace = "";
            // 
            // coldsBOFDataL3DataTableSecondHand
            // 
            this.coldsBOFDataL3DataTableSecondHand.Caption = "SecondHand";
            this.coldsBOFDataL3DataTableSecondHand.ColumnName = "SecondHand";
            this.coldsBOFDataL3DataTableSecondHand.Namespace = "";
            // 
            // coldsBOFDataL3DataTableProductionDate
            // 
            this.coldsBOFDataL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsBOFDataL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsBOFDataL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsBOFDataL3DataTableProductionDate.Namespace = "";
            // 
            // coldsBOFDataL3DataTableStatisticsDate
            // 
            this.coldsBOFDataL3DataTableStatisticsDate.Caption = "StatisticsDate";
            this.coldsBOFDataL3DataTableStatisticsDate.ColumnName = "StatisticsDate";
            this.coldsBOFDataL3DataTableStatisticsDate.DataType = typeof(System.DateTime);
            this.coldsBOFDataL3DataTableStatisticsDate.Namespace = "";
            // 
            // coldsBOFDataL3DataTableLocked
            // 
            this.coldsBOFDataL3DataTableLocked.Caption = "Locked";
            this.coldsBOFDataL3DataTableLocked.ColumnName = "Locked";
            this.coldsBOFDataL3DataTableLocked.DataType = typeof(short);
            this.coldsBOFDataL3DataTableLocked.Namespace = "";
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
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBOFData;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnDataModify,
            this.btnQuery,
            this.dtData,
            this.toolStripLabel3,
            this.cmbBOFID,
            this.toolStripLabel2,
            this.btnConfirm,
            this.txtHeatID,
            this.toolStripLabel5,
            this.btnAdd,
            this.toolStripButton1});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1022, 25);
            this.bdN1.TabIndex = 22;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
            this.toolStripLabel1.Text = "       ";
            // 
            // btnDataModify
            // 
            this.btnDataModify.Name = "btnDataModify";
            this.btnDataModify.Size = new System.Drawing.Size(0, 22);
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtData
            // 
            this.dtData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtData.CustomFormat = "yyyy-MM-dd";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(100, 22);
            this.dtData.Text = "2008-11-10";
            this.dtData.Value = new System.DateTime(2008, 11, 10, 11, 16, 8, 907);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "日期:";
            // 
            // cmbBOFID
            // 
            this.cmbBOFID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOFID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBOFID.Name = "cmbBOFID";
            this.cmbBOFID.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "炉座号:";
            // 
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "炉号:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Visible = false;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBOFData);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1022, 431);
            this.hmiRootPanel1.TabIndex = 23;
            // 
            // dvBOFData
            // 
            this.dvBOFData.AllowUserToAddRows = false;
            this.dvBOFData.AutoGenerateColumns = false;
            this.dvBOFData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBOFData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeatID,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.shiftDataGridViewCheckBoxColumn,
            this.teamDataGridViewCheckBoxColumn,
            this.headFurnaceDataGridViewTextBoxColumn,
            this.assistantDataGridViewTextBoxColumn,
            this.secondHandDataGridViewTextBoxColumn,
            this.productionDateDataGridViewTextBoxColumn,
            this.statisticsDateDataGridViewTextBoxColumn,
            this.Locked});
            this.dvBOFData.DataSource = this.bsBOFData;
            this.dvBOFData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBOFData.Location = new System.Drawing.Point(0, 0);
            this.dvBOFData.MultiSelect = false;
            this.dvBOFData.Name = "dvBOFData";
            this.dvBOFData.ReadOnly = true;
            this.dvBOFData.RowHeadersVisible = false;
            this.dvBOFData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBOFData.RowTemplate.Height = 23;
            this.dvBOFData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBOFData.Size = new System.Drawing.Size(1022, 431);
            this.dvBOFData.TabIndex = 0;
            this.dvBOFData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvBOFData_CellDoubleClick_1);
            this.dvBOFData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBOFData_DataBindingComplete);
            this.dvBOFData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBOFData_DataError);
            // 
            // dsShift
            // 
            this.dsShift.AutoLoad = true;
            this.dsShift.AutoSubscribe = false;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = null;
            this.dsShift.InsertMethod = null;
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "Click";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = null;
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "Click";
            this.dsShift.UpdateMethod = null;
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTableCode,
            this.coldsShiftL3DataTableCode_Des});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTableCode
            // 
            this.coldsShiftL3DataTableCode.Caption = "Code";
            this.coldsShiftL3DataTableCode.ColumnName = "Code";
            this.coldsShiftL3DataTableCode.Namespace = "";
            // 
            // coldsShiftL3DataTableCode_Des
            // 
            this.coldsShiftL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.Namespace = "";
            // 
            // dsTeam
            // 
            this.dsTeam.AutoLoad = true;
            this.dsTeam.AutoSubscribe = false;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = null;
            this.dsTeam.InsertMethod = null;
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "Click";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "Click";
            this.dsTeam.UpdateMethod = null;
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTableCode
            // 
            this.coldsTeamL3DataTableCode.Caption = "Code";
            this.coldsTeamL3DataTableCode.ColumnName = "Code";
            this.coldsTeamL3DataTableCode.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Des
            // 
            this.coldsTeamL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.Namespace = "";
            // 
            // dsHeatID
            // 
            this.dsHeatID.AutoLoad = true;
            this.dsHeatID.AutoSubscribe = false;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = null;
            this.dsHeatID.InsertMethod = null;
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "Click";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = null;
            this.dsHeatID.SourceCondition = "CODE_GROUP = \'BOF\' order by code";
            this.dsHeatID.SourceMethod = "";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = null;
            this.dsHeatID.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatIDL3DataTableCode,
            this.coldsHeatIDL3DataTableCode_Des});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coldsHeatIDL3DataTableCode
            // 
            this.coldsHeatIDL3DataTableCode.Caption = "Code";
            this.coldsHeatIDL3DataTableCode.ColumnName = "Code";
            this.coldsHeatIDL3DataTableCode.Namespace = "";
            // 
            // coldsHeatIDL3DataTableCode_Des
            // 
            this.coldsHeatIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHeatIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHeatIDL3DataTableCode_Des.Namespace = "";
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Adapter = this.Adapter;
            this.cmdConfirm.MergeReturnTarget = false;
            this.cmdConfirm.Method = "LockData";
            this.cmdConfirm.Object = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S21";
            this.cmdConfirm.Parameters.Add(this.l3CommandParameter1);
            this.cmdConfirm.Parameters.Add(this.l3CommandParameter2);
            this.cmdConfirm.Parameters.Add(this.l3CommandParameter3);
            this.cmdConfirm.ReturnTarget = null;
            this.cmdConfirm.ReturnTargetProperty = null;
            this.cmdConfirm.Trigger = null;
            this.cmdConfirm.TriggerEvent = "Click";
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
            // dsTempt
            // 
            this.dsTempt.AutoLoad = true;
            this.dsTempt.AutoSubscribe = false;
            this.dsTempt.DataSetName = "L3DataSet";
            this.dsTempt.DeleteMethod = null;
            this.dsTempt.InsertMethod = null;
            this.dsTempt.L3DataAdapter = this.Adapter;
            this.dsTempt.LoadEvent = "Click";
            this.dsTempt.LoadTrigger = null;
            this.dsTempt.RefreshValve = 1000;
            this.dsTempt.SourceCommand = null;
            this.dsTempt.SourceCondition = "";
            this.dsTempt.SourceMethod = "";
            this.dsTempt.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsTempt.SourceURI = "";
            this.dsTempt.SubscribeTarget = null;
            this.dsTempt.UpdateEvent = "Click";
            this.dsTempt.UpdateMethod = null;
            this.dsTempt.UpdateTrigger = null;
            // 
            // sendSheet
            // 
            this.sendSheet.Adapter = this.Adapter;
            this.sendSheet.MergeReturnTarget = false;
            this.sendSheet.Method = "GenLabSheetNew";
            this.sendSheet.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.sendSheet.Parameters.Add(this.l3CommandParameter4);
            this.sendSheet.Parameters.Add(this.l3CommandParameter5);
            this.sendSheet.Parameters.Add(this.l3CommandParameter6);
            this.sendSheet.Parameters.Add(this.l3CommandParameter7);
            this.sendSheet.Parameters.Add(this.l3CommandParameter8);
            this.sendSheet.ReturnTarget = null;
            this.sendSheet.ReturnTargetProperty = null;
            this.sendSheet.Trigger = null;
            this.sendSheet.TriggerEvent = "Click";
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
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = null;
            this.l3CommandParameter7.SourceObject = null;
            this.l3CommandParameter7.SourceProperty = null;
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = null;
            this.l3CommandParameter8.SourceObject = null;
            this.l3CommandParameter8.SourceProperty = null;
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            this.HeatID.ReadOnly = true;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewCheckBoxColumn
            // 
            this.shiftDataGridViewCheckBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewCheckBoxColumn.DataSource = this.dsShift;
            this.shiftDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewCheckBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewCheckBoxColumn.Name = "shiftDataGridViewCheckBoxColumn";
            this.shiftDataGridViewCheckBoxColumn.ReadOnly = true;
            this.shiftDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // teamDataGridViewCheckBoxColumn
            // 
            this.teamDataGridViewCheckBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewCheckBoxColumn.DataSource = this.dsTeam;
            this.teamDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewCheckBoxColumn.HeaderText = "班别";
            this.teamDataGridViewCheckBoxColumn.Name = "teamDataGridViewCheckBoxColumn";
            this.teamDataGridViewCheckBoxColumn.ReadOnly = true;
            this.teamDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // headFurnaceDataGridViewTextBoxColumn
            // 
            this.headFurnaceDataGridViewTextBoxColumn.DataPropertyName = "HeadFurnace";
            this.headFurnaceDataGridViewTextBoxColumn.HeaderText = "炉长";
            this.headFurnaceDataGridViewTextBoxColumn.Name = "headFurnaceDataGridViewTextBoxColumn";
            this.headFurnaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assistantDataGridViewTextBoxColumn
            // 
            this.assistantDataGridViewTextBoxColumn.DataPropertyName = "Assistant";
            this.assistantDataGridViewTextBoxColumn.HeaderText = "一助手";
            this.assistantDataGridViewTextBoxColumn.Name = "assistantDataGridViewTextBoxColumn";
            this.assistantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondHandDataGridViewTextBoxColumn
            // 
            this.secondHandDataGridViewTextBoxColumn.DataPropertyName = "SecondHand";
            this.secondHandDataGridViewTextBoxColumn.HeaderText = "二助手";
            this.secondHandDataGridViewTextBoxColumn.Name = "secondHandDataGridViewTextBoxColumn";
            this.secondHandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionDateDataGridViewTextBoxColumn
            // 
            this.productionDateDataGridViewTextBoxColumn.DataPropertyName = "ProductionDate";
            this.productionDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productionDateDataGridViewTextBoxColumn.Name = "productionDateDataGridViewTextBoxColumn";
            this.productionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statisticsDateDataGridViewTextBoxColumn
            // 
            this.statisticsDateDataGridViewTextBoxColumn.DataPropertyName = "StatisticsDate";
            this.statisticsDateDataGridViewTextBoxColumn.HeaderText = "统计日期";
            this.statisticsDateDataGridViewTextBoxColumn.Name = "statisticsDateDataGridViewTextBoxColumn";
            this.statisticsDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.statisticsDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // Locked
            // 
            this.Locked.DataPropertyName = "Locked";
            this.Locked.HeaderText = "封存标志";
            this.Locked.Name = "Locked";
            this.Locked.ReadOnly = true;
            this.Locked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Locked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BOFHeatFinalDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 456);
            this.Controls.Add(this.cxCheckFlag);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "BOFHeatFinalDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "转炉实绩数据管理";
            this.Text = "转炉实绩数据管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BOFHeatFinalDataFrm_FormClosing);
            this.Load += new System.EventHandler(this.BOFHeatFinalDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBOFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBOFData;
        private AppSvrHMI.L3DataSet dsBOFData;
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
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbBOFID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBOFData;
        private System.Data.DataTable schemadsBOFData;
        private System.Data.DataColumn coldsBOFDataL3DataTableGUID;
        private System.Data.DataColumn coldsBOFDataL3DataTableName;
        private System.Data.DataColumn coldsBOFDataL3DataTableHeatID;
        private System.Data.DataColumn coldsBOFDataL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBOFDataL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBOFDataL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBOFDataL3DataTableShift;
        private System.Data.DataColumn coldsBOFDataL3DataTableTeam;
        private System.Data.DataColumn coldsBOFDataL3DataTableHeadFurnace;
        private System.Data.DataColumn coldsBOFDataL3DataTableAssistant;
        private System.Data.DataColumn coldsBOFDataL3DataTableSecondHand;
        private System.Data.DataColumn coldsBOFDataL3DataTableProductionDate;
        private System.Data.DataColumn coldsBOFDataL3DataTableStatisticsDate;
        private System.Data.DataColumn coldsBOFDataL3DataTableLocked;
        private System.Windows.Forms.CheckBox cxCheckFlag;
        private AppSvrHMI.L3DataSet dsHeatID;
        private System.Data.DataTable schemal3DataSet1;
        private System.Windows.Forms.ToolStripLabel btnDataModify;
        private System.Data.DataColumn coldsHeatIDL3DataTableCode;
        private System.Data.DataColumn coldsHeatIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private AppSvrHMI.L3Command cmdConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCode;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private AppSvrHMI.L3DataSet dsTempt;
        private AppSvrHMI.L3Command sendSheet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headFurnaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statisticsDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locked;
    }
}