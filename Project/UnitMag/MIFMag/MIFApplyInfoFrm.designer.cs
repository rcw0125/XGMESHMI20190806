﻿namespace UnitMag.MIFMag
{
    partial class MIFApplyInfoFrm
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
            this.bsSampleApply = new System.Windows.Forms.BindingSource(this.components);
            this.dsSampleApply = new AppSvrHMI.L3DataSet();
            this.schemadsSampleApply = new System.Data.DataTable();
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbSampleAddr = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHeatName = new System.Windows.Forms.Label();
            this.cmbHeatID = new PxDataValid.PxComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSampleType = new PxDataValid.PxComboBox();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsIronLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleID = new System.Data.DataTable();
            this.coldsIronLadleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            this.dsAddress = new AppSvrHMI.L3DataSet();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.dsIronLadleIDPre = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleIDPre = new System.Data.DataTable();
            this.coldsIronLadleIDPreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableName = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTablePosition = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableWeight = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableC = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableSi = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableMn = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableP = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableS = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableTi = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableSn = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableSb = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableAs = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTablePb = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableNi = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableMo = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableCu = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableCr = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableB = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableV = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableAl = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableNb = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableZn = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableW = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableIronTemp = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableSource = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableShift = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableTeam = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableTare = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableTap_Time = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableIronLadleNo = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableObject1 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableWeight1 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableObject2 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableWeight2 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableObject3 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableWeight3 = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsIronLadleIDPreL3DataTableIsDes = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleIDPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleIDPre)).BeginInit();
            this.SuspendLayout();
            // 
            // bsSampleApply
            // 
            this.bsSampleApply.DataMember = "L3DataTable";
            this.bsSampleApply.DataSource = this.dsSampleApply;
            // 
            // dsSampleApply
            // 
            this.dsSampleApply.AutoLoad = true;
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
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(284, 10);
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
            this.btnOK.Location = new System.Drawing.Point(203, 10);
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
            this.tabControl1.Size = new System.Drawing.Size(371, 163);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbSampleAddr);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.cmbHeatID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbSampleType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "申请信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbSampleAddr
            // 
            this.cmbSampleAddr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSampleApply, "Sample_Address", true));
            this.cmbSampleAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbSampleAddr.Enabled = false;
            this.cmbSampleAddr.FormattingEnabled = true;
            this.cmbSampleAddr.Location = new System.Drawing.Point(152, 46);
            this.cmbSampleAddr.Name = "cmbSampleAddr";
            this.cmbSampleAddr.Size = new System.Drawing.Size(153, 20);
            this.cmbSampleAddr.TabIndex = 1;
            this.cmbSampleAddr.SelectedIndexChanged += new System.EventHandler(this.cmbSampleAddr_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbHeatName);
            this.panel4.Location = new System.Drawing.Point(56, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 18);
            this.panel4.TabIndex = 7;
            // 
            // lbHeatName
            // 
            this.lbHeatName.AutoSize = true;
            this.lbHeatName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbHeatName.Location = new System.Drawing.Point(43, 0);
            this.lbHeatName.Name = "lbHeatName";
            this.lbHeatName.Size = new System.Drawing.Size(47, 12);
            this.lbHeatName.TabIndex = 4;
            this.lbHeatName.Text = "铁次号:";
            this.lbHeatName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbHeatID
            // 
            this.cmbHeatID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHeatID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHeatID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSampleApply, "HeatID", true));
            this.cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbHeatID.EnableNull = true;
            this.cmbHeatID.ErropPr = null;
            this.cmbHeatID.FormattingEnabled = true;
            this.cmbHeatID.Location = new System.Drawing.Point(152, 15);
            this.cmbHeatID.Name = "cmbHeatID";
            this.cmbHeatID.ReadOnly = false;
            this.cmbHeatID.Size = new System.Drawing.Size(153, 20);
            this.cmbHeatID.TabIndex = 0;
            this.cmbHeatID.TMpEnabled = true;
            this.cmbHeatID.ToolTipValid = null;
            this.cmbHeatID.ValidEable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "取样地点:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cmbSampleType
            // 
            this.cmbSampleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSampleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSampleType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSampleType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSampleApply, "Sample_Type", true));
            this.cmbSampleType.DataSource = this.dsSampleType;
            this.cmbSampleType.DisplayMember = "L3DataTable.Code_Des";
            this.cmbSampleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSampleType.EnableNull = true;
            this.cmbSampleType.ErropPr = null;
            this.cmbSampleType.FormattingEnabled = true;
            this.cmbSampleType.Location = new System.Drawing.Point(152, 76);
            this.cmbSampleType.Name = "cmbSampleType";
            this.cmbSampleType.ReadOnly = false;
            this.cmbSampleType.Size = new System.Drawing.Size(153, 20);
            this.cmbSampleType.TabIndex = 2;
            this.cmbSampleType.TMpEnabled = true;
            this.cmbSampleType.ToolTipValid = null;
            this.cmbSampleType.ValidEable = true;
            this.cmbSampleType.ValueMember = "L3DataTable.Code";
            this.cmbSampleType.SelectedIndexChanged += new System.EventHandler(this.cmbSampleType_SelectedIndexChanged);
            // 
            // dsSampleType
            // 
            this.dsSampleType.AutoLoad = true;
            this.dsSampleType.AutoSubscribe = false;
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "Code_Group =  \'QA_Sample_Type\' and Code_Function_Group = \'H\' order by Code";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "试样类别:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
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
            // dsIronLadleID
            // 
            this.dsIronLadleID.AutoLoad = true;
            this.dsIronLadleID.AutoSubscribe = true;
            this.dsIronLadleID.DataSetName = "L3DataSet";
            this.dsIronLadleID.DeleteMethod = null;
            this.dsIronLadleID.InsertMethod = null;
            this.dsIronLadleID.L3DataAdapter = this.Adapter;
            this.dsIronLadleID.LoadEvent = "Click";
            this.dsIronLadleID.LoadTrigger = null;
            this.dsIronLadleID.RefreshValve = 1000;
            this.dsIronLadleID.SourceCommand = null;
            this.dsIronLadleID.SourceCondition = null;
            this.dsIronLadleID.SourceMethod = "";
            this.dsIronLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleID.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronLadleID.SubscribeTarget = null;
            this.dsIronLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadleID});
            this.dsIronLadleID.UpdateEvent = "Click";
            this.dsIronLadleID.UpdateMethod = null;
            this.dsIronLadleID.UpdateTrigger = null;
            // 
            // schemadsIronLadleID
            // 
            this.schemadsIronLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleIDL3DataTableIronLadleID});
            this.schemadsIronLadleID.TableName = "L3DataTable";
            // 
            // coldsIronLadleIDL3DataTableIronLadleID
            // 
            this.coldsIronLadleIDL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.Namespace = "";
            // 
            // dsAddress
            // 
            this.dsAddress.AutoLoad = true;
            this.dsAddress.AutoSubscribe = true;
            this.dsAddress.DataSetName = "L3DataSet";
            this.dsAddress.DeleteMethod = null;
            this.dsAddress.InsertMethod = null;
            this.dsAddress.L3DataAdapter = null;
            this.dsAddress.LoadEvent = "Click";
            this.dsAddress.LoadTrigger = null;
            this.dsAddress.RefreshValve = 1000;
            this.dsAddress.SourceCommand = null;
            this.dsAddress.SourceCondition = null;
            this.dsAddress.SourceMethod = null;
            this.dsAddress.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsAddress.SourceURI = null;
            this.dsAddress.SubscribeTarget = null;
            this.dsAddress.UpdateEvent = "Click";
            this.dsAddress.UpdateMethod = null;
            this.dsAddress.UpdateTrigger = null;
            // 
            // dsHeatID
            // 
            this.dsHeatID.AutoLoad = true;
            this.dsHeatID.AutoSubscribe = false;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = "";
            this.dsHeatID.InsertMethod = "";
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "Click";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = null;
            this.dsHeatID.SourceCondition = null;
            this.dsHeatID.SourceMethod = "GetHeatIDByAddr";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "XGMESLogic\\QualityMag\\CQuality_Mag\\Quality_Mag";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = "";
            this.dsHeatID.UpdateTrigger = null;
            // 
            // dsIronLadleIDPre
            // 
            this.dsIronLadleIDPre.AutoLoad = true;
            this.dsIronLadleIDPre.AutoSubscribe = true;
            this.dsIronLadleIDPre.DataSetName = "L3DataSet";
            this.dsIronLadleIDPre.DeleteMethod = null;
            this.dsIronLadleIDPre.InsertMethod = null;
            this.dsIronLadleIDPre.L3DataAdapter = this.Adapter;
            this.dsIronLadleIDPre.LoadEvent = "Click";
            this.dsIronLadleIDPre.LoadTrigger = null;
            this.dsIronLadleIDPre.RefreshValve = 1000;
            this.dsIronLadleIDPre.SourceCommand = null;
            this.dsIronLadleIDPre.SourceCondition = "tap_time > sysdate-0.007 order by tap_time desc";
            this.dsIronLadleIDPre.SourceMethod = "";
            this.dsIronLadleIDPre.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleIDPre.SourceURI = "MES\\MaterialData\\CIron_Data";
            this.dsIronLadleIDPre.SubscribeTarget = null;
            this.dsIronLadleIDPre.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadleIDPre});
            this.dsIronLadleIDPre.UpdateEvent = "Click";
            this.dsIronLadleIDPre.UpdateMethod = null;
            this.dsIronLadleIDPre.UpdateTrigger = null;
            // 
            // schemadsIronLadleIDPre
            // 
            this.schemadsIronLadleIDPre.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleIDPreL3DataTableGUID,
            this.coldsIronLadleIDPreL3DataTableName,
            this.coldsIronLadleIDPreL3DataTableMaterialID,
            this.coldsIronLadleIDPreL3DataTableStatus,
            this.coldsIronLadleIDPreL3DataTablePosition,
            this.coldsIronLadleIDPreL3DataTableQAStatus,
            this.coldsIronLadleIDPreL3DataTableQALevel,
            this.coldsIronLadleIDPreL3DataTableOrderContractID,
            this.coldsIronLadleIDPreL3DataTableProduceContractID,
            this.coldsIronLadleIDPreL3DataTableSalesContractID,
            this.coldsIronLadleIDPreL3DataTableWeight,
            this.coldsIronLadleIDPreL3DataTableC,
            this.coldsIronLadleIDPreL3DataTableSi,
            this.coldsIronLadleIDPreL3DataTableMn,
            this.coldsIronLadleIDPreL3DataTableP,
            this.coldsIronLadleIDPreL3DataTableS,
            this.coldsIronLadleIDPreL3DataTableTi,
            this.coldsIronLadleIDPreL3DataTableSn,
            this.coldsIronLadleIDPreL3DataTableSb,
            this.coldsIronLadleIDPreL3DataTableAs,
            this.coldsIronLadleIDPreL3DataTablePb,
            this.coldsIronLadleIDPreL3DataTableNi,
            this.coldsIronLadleIDPreL3DataTableMo,
            this.coldsIronLadleIDPreL3DataTableCu,
            this.coldsIronLadleIDPreL3DataTableCr,
            this.coldsIronLadleIDPreL3DataTableB,
            this.coldsIronLadleIDPreL3DataTableV,
            this.coldsIronLadleIDPreL3DataTableAl,
            this.coldsIronLadleIDPreL3DataTableNb,
            this.coldsIronLadleIDPreL3DataTableZn,
            this.coldsIronLadleIDPreL3DataTableW,
            this.coldsIronLadleIDPreL3DataTableIronTemp,
            this.coldsIronLadleIDPreL3DataTableHeatID,
            this.coldsIronLadleIDPreL3DataTableSource,
            this.coldsIronLadleIDPreL3DataTableShift,
            this.coldsIronLadleIDPreL3DataTableTeam,
            this.coldsIronLadleIDPreL3DataTableOperator,
            this.coldsIronLadleIDPreL3DataTableTare,
            this.coldsIronLadleIDPreL3DataTableGross_Weight,
            this.coldsIronLadleIDPreL3DataTableTap_Time,
            this.coldsIronLadleIDPreL3DataTableIronLadleNo,
            this.coldsIronLadleIDPreL3DataTableObject1,
            this.coldsIronLadleIDPreL3DataTableWeight1,
            this.coldsIronLadleIDPreL3DataTableObject2,
            this.coldsIronLadleIDPreL3DataTableWeight2,
            this.coldsIronLadleIDPreL3DataTableObject3,
            this.coldsIronLadleIDPreL3DataTableWeight3,
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight,
            this.coldsIronLadleIDPreL3DataTableIsDes});
            this.schemadsIronLadleIDPre.TableName = "L3DataTable";
            // 
            // coldsIronLadleIDPreL3DataTableGUID
            // 
            this.coldsIronLadleIDPreL3DataTableGUID.Caption = "GUID";
            this.coldsIronLadleIDPreL3DataTableGUID.ColumnName = "GUID";
            this.coldsIronLadleIDPreL3DataTableGUID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableName
            // 
            this.coldsIronLadleIDPreL3DataTableName.Caption = "Name";
            this.coldsIronLadleIDPreL3DataTableName.ColumnName = "Name";
            this.coldsIronLadleIDPreL3DataTableName.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableMaterialID
            // 
            this.coldsIronLadleIDPreL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsIronLadleIDPreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsIronLadleIDPreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableStatus
            // 
            this.coldsIronLadleIDPreL3DataTableStatus.Caption = "Status";
            this.coldsIronLadleIDPreL3DataTableStatus.ColumnName = "Status";
            this.coldsIronLadleIDPreL3DataTableStatus.DataType = typeof(int);
            this.coldsIronLadleIDPreL3DataTableStatus.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTablePosition
            // 
            this.coldsIronLadleIDPreL3DataTablePosition.Caption = "Position";
            this.coldsIronLadleIDPreL3DataTablePosition.ColumnName = "Position";
            this.coldsIronLadleIDPreL3DataTablePosition.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableQAStatus
            // 
            this.coldsIronLadleIDPreL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsIronLadleIDPreL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsIronLadleIDPreL3DataTableQAStatus.DataType = typeof(int);
            this.coldsIronLadleIDPreL3DataTableQAStatus.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableQALevel
            // 
            this.coldsIronLadleIDPreL3DataTableQALevel.Caption = "QALevel";
            this.coldsIronLadleIDPreL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsIronLadleIDPreL3DataTableQALevel.DataType = typeof(int);
            this.coldsIronLadleIDPreL3DataTableQALevel.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableOrderContractID
            // 
            this.coldsIronLadleIDPreL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsIronLadleIDPreL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsIronLadleIDPreL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableProduceContractID
            // 
            this.coldsIronLadleIDPreL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsIronLadleIDPreL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsIronLadleIDPreL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableSalesContractID
            // 
            this.coldsIronLadleIDPreL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsIronLadleIDPreL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsIronLadleIDPreL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableWeight
            // 
            this.coldsIronLadleIDPreL3DataTableWeight.Caption = "Weight";
            this.coldsIronLadleIDPreL3DataTableWeight.ColumnName = "Weight";
            this.coldsIronLadleIDPreL3DataTableWeight.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableWeight.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableC
            // 
            this.coldsIronLadleIDPreL3DataTableC.Caption = "C";
            this.coldsIronLadleIDPreL3DataTableC.ColumnName = "C";
            this.coldsIronLadleIDPreL3DataTableC.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableC.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableSi
            // 
            this.coldsIronLadleIDPreL3DataTableSi.Caption = "Si";
            this.coldsIronLadleIDPreL3DataTableSi.ColumnName = "Si";
            this.coldsIronLadleIDPreL3DataTableSi.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableSi.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableMn
            // 
            this.coldsIronLadleIDPreL3DataTableMn.Caption = "Mn";
            this.coldsIronLadleIDPreL3DataTableMn.ColumnName = "Mn";
            this.coldsIronLadleIDPreL3DataTableMn.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableMn.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableP
            // 
            this.coldsIronLadleIDPreL3DataTableP.Caption = "P";
            this.coldsIronLadleIDPreL3DataTableP.ColumnName = "P";
            this.coldsIronLadleIDPreL3DataTableP.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableP.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableS
            // 
            this.coldsIronLadleIDPreL3DataTableS.Caption = "S";
            this.coldsIronLadleIDPreL3DataTableS.ColumnName = "S";
            this.coldsIronLadleIDPreL3DataTableS.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableS.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableTi
            // 
            this.coldsIronLadleIDPreL3DataTableTi.Caption = "Ti";
            this.coldsIronLadleIDPreL3DataTableTi.ColumnName = "Ti";
            this.coldsIronLadleIDPreL3DataTableTi.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableTi.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableSn
            // 
            this.coldsIronLadleIDPreL3DataTableSn.Caption = "Sn";
            this.coldsIronLadleIDPreL3DataTableSn.ColumnName = "Sn";
            this.coldsIronLadleIDPreL3DataTableSn.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableSn.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableSb
            // 
            this.coldsIronLadleIDPreL3DataTableSb.Caption = "Sb";
            this.coldsIronLadleIDPreL3DataTableSb.ColumnName = "Sb";
            this.coldsIronLadleIDPreL3DataTableSb.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableSb.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableAs
            // 
            this.coldsIronLadleIDPreL3DataTableAs.Caption = "As";
            this.coldsIronLadleIDPreL3DataTableAs.ColumnName = "As";
            this.coldsIronLadleIDPreL3DataTableAs.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableAs.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTablePb
            // 
            this.coldsIronLadleIDPreL3DataTablePb.Caption = "Pb";
            this.coldsIronLadleIDPreL3DataTablePb.ColumnName = "Pb";
            this.coldsIronLadleIDPreL3DataTablePb.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTablePb.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableNi
            // 
            this.coldsIronLadleIDPreL3DataTableNi.Caption = "Ni";
            this.coldsIronLadleIDPreL3DataTableNi.ColumnName = "Ni";
            this.coldsIronLadleIDPreL3DataTableNi.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableNi.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableMo
            // 
            this.coldsIronLadleIDPreL3DataTableMo.Caption = "Mo";
            this.coldsIronLadleIDPreL3DataTableMo.ColumnName = "Mo";
            this.coldsIronLadleIDPreL3DataTableMo.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableMo.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableCu
            // 
            this.coldsIronLadleIDPreL3DataTableCu.Caption = "Cu";
            this.coldsIronLadleIDPreL3DataTableCu.ColumnName = "Cu";
            this.coldsIronLadleIDPreL3DataTableCu.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableCu.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableCr
            // 
            this.coldsIronLadleIDPreL3DataTableCr.Caption = "Cr";
            this.coldsIronLadleIDPreL3DataTableCr.ColumnName = "Cr";
            this.coldsIronLadleIDPreL3DataTableCr.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableCr.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableB
            // 
            this.coldsIronLadleIDPreL3DataTableB.Caption = "B";
            this.coldsIronLadleIDPreL3DataTableB.ColumnName = "B";
            this.coldsIronLadleIDPreL3DataTableB.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableB.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableV
            // 
            this.coldsIronLadleIDPreL3DataTableV.Caption = "V";
            this.coldsIronLadleIDPreL3DataTableV.ColumnName = "V";
            this.coldsIronLadleIDPreL3DataTableV.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableV.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableAl
            // 
            this.coldsIronLadleIDPreL3DataTableAl.Caption = "Al";
            this.coldsIronLadleIDPreL3DataTableAl.ColumnName = "Al";
            this.coldsIronLadleIDPreL3DataTableAl.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableAl.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableNb
            // 
            this.coldsIronLadleIDPreL3DataTableNb.Caption = "Nb";
            this.coldsIronLadleIDPreL3DataTableNb.ColumnName = "Nb";
            this.coldsIronLadleIDPreL3DataTableNb.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableNb.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableZn
            // 
            this.coldsIronLadleIDPreL3DataTableZn.Caption = "Zn";
            this.coldsIronLadleIDPreL3DataTableZn.ColumnName = "Zn";
            this.coldsIronLadleIDPreL3DataTableZn.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableZn.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableW
            // 
            this.coldsIronLadleIDPreL3DataTableW.Caption = "W";
            this.coldsIronLadleIDPreL3DataTableW.ColumnName = "W";
            this.coldsIronLadleIDPreL3DataTableW.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableW.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableIronTemp
            // 
            this.coldsIronLadleIDPreL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsIronLadleIDPreL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsIronLadleIDPreL3DataTableIronTemp.DataType = typeof(int);
            this.coldsIronLadleIDPreL3DataTableIronTemp.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableHeatID
            // 
            this.coldsIronLadleIDPreL3DataTableHeatID.Caption = "HeatID";
            this.coldsIronLadleIDPreL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsIronLadleIDPreL3DataTableHeatID.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableSource
            // 
            this.coldsIronLadleIDPreL3DataTableSource.Caption = "Source";
            this.coldsIronLadleIDPreL3DataTableSource.ColumnName = "Source";
            this.coldsIronLadleIDPreL3DataTableSource.DataType = typeof(bool);
            this.coldsIronLadleIDPreL3DataTableSource.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableShift
            // 
            this.coldsIronLadleIDPreL3DataTableShift.Caption = "Shift";
            this.coldsIronLadleIDPreL3DataTableShift.ColumnName = "Shift";
            this.coldsIronLadleIDPreL3DataTableShift.DataType = typeof(bool);
            this.coldsIronLadleIDPreL3DataTableShift.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableTeam
            // 
            this.coldsIronLadleIDPreL3DataTableTeam.Caption = "Team";
            this.coldsIronLadleIDPreL3DataTableTeam.ColumnName = "Team";
            this.coldsIronLadleIDPreL3DataTableTeam.DataType = typeof(bool);
            this.coldsIronLadleIDPreL3DataTableTeam.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableOperator
            // 
            this.coldsIronLadleIDPreL3DataTableOperator.Caption = "Operator";
            this.coldsIronLadleIDPreL3DataTableOperator.ColumnName = "Operator";
            this.coldsIronLadleIDPreL3DataTableOperator.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableTare
            // 
            this.coldsIronLadleIDPreL3DataTableTare.Caption = "Tare";
            this.coldsIronLadleIDPreL3DataTableTare.ColumnName = "Tare";
            this.coldsIronLadleIDPreL3DataTableTare.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableTare.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableGross_Weight
            // 
            this.coldsIronLadleIDPreL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsIronLadleIDPreL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsIronLadleIDPreL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableTap_Time
            // 
            this.coldsIronLadleIDPreL3DataTableTap_Time.Caption = "Tap_Time";
            this.coldsIronLadleIDPreL3DataTableTap_Time.ColumnName = "Tap_Time";
            this.coldsIronLadleIDPreL3DataTableTap_Time.DataType = typeof(System.DateTime);
            this.coldsIronLadleIDPreL3DataTableTap_Time.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableIronLadleNo
            // 
            this.coldsIronLadleIDPreL3DataTableIronLadleNo.Caption = "IronLadleNo";
            this.coldsIronLadleIDPreL3DataTableIronLadleNo.ColumnName = "IronLadleNo";
            this.coldsIronLadleIDPreL3DataTableIronLadleNo.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableObject1
            // 
            this.coldsIronLadleIDPreL3DataTableObject1.Caption = "Object1";
            this.coldsIronLadleIDPreL3DataTableObject1.ColumnName = "Object1";
            this.coldsIronLadleIDPreL3DataTableObject1.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableWeight1
            // 
            this.coldsIronLadleIDPreL3DataTableWeight1.Caption = "Weight1";
            this.coldsIronLadleIDPreL3DataTableWeight1.ColumnName = "Weight1";
            this.coldsIronLadleIDPreL3DataTableWeight1.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableWeight1.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableObject2
            // 
            this.coldsIronLadleIDPreL3DataTableObject2.Caption = "Object2";
            this.coldsIronLadleIDPreL3DataTableObject2.ColumnName = "Object2";
            this.coldsIronLadleIDPreL3DataTableObject2.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableWeight2
            // 
            this.coldsIronLadleIDPreL3DataTableWeight2.Caption = "Weight2";
            this.coldsIronLadleIDPreL3DataTableWeight2.ColumnName = "Weight2";
            this.coldsIronLadleIDPreL3DataTableWeight2.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableWeight2.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableObject3
            // 
            this.coldsIronLadleIDPreL3DataTableObject3.Caption = "Object3";
            this.coldsIronLadleIDPreL3DataTableObject3.ColumnName = "Object3";
            this.coldsIronLadleIDPreL3DataTableObject3.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableWeight3
            // 
            this.coldsIronLadleIDPreL3DataTableWeight3.Caption = "Weight3";
            this.coldsIronLadleIDPreL3DataTableWeight3.ColumnName = "Weight3";
            this.coldsIronLadleIDPreL3DataTableWeight3.DataType = typeof(double);
            this.coldsIronLadleIDPreL3DataTableWeight3.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableReturn_Steel_Weight
            // 
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsIronLadleIDPreL3DataTableIsDes
            // 
            this.coldsIronLadleIDPreL3DataTableIsDes.Caption = "IsDes";
            this.coldsIronLadleIDPreL3DataTableIsDes.ColumnName = "IsDes";
            this.coldsIronLadleIDPreL3DataTableIsDes.DataType = typeof(float);
            this.coldsIronLadleIDPreL3DataTableIsDes.Namespace = "";
            // 
            // MIFApplyInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 208);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MIFApplyInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "制定委托单";
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleIDPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleIDPre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsSampleApply;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHeatName;
        private PxDataValid.PxComboBox cmbHeatID;
        private PxDataValid.PxComboBox cmbSampleType;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsSampleApply;
        private System.Data.DataTable schemadsSampleApply;
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
        private System.Windows.Forms.Panel panel4;
        private AppSvrHMI.L3DataSet dsIronLadleID;
        private System.Data.DataTable schemadsIronLadleID;
        private System.Data.DataColumn coldsIronLadleIDL3DataTableIronLadleID;
        private System.Windows.Forms.ComboBox cmbSampleAddr;
        private AppSvrHMI.L3DataSet dsAddress;
        private AppSvrHMI.L3DataSet dsHeatID;
        private AppSvrHMI.L3DataSet dsIronLadleIDPre;
        private System.Data.DataTable schemadsIronLadleIDPre;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableGUID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableName;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableMaterialID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableStatus;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTablePosition;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableQAStatus;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableQALevel;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableOrderContractID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableProduceContractID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableSalesContractID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableWeight;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableC;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableSi;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableMn;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableP;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableS;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableTi;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableSn;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableSb;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableAs;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTablePb;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableNi;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableMo;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableCu;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableCr;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableB;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableV;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableAl;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableNb;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableZn;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableW;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableIronTemp;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableHeatID;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableSource;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableShift;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableTeam;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableOperator;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableTare;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableGross_Weight;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableTap_Time;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableIronLadleNo;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableObject1;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableWeight1;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableObject2;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableWeight2;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableObject3;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableWeight3;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsIronLadleIDPreL3DataTableIsDes;
    }
}