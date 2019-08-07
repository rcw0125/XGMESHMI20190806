namespace EquipMag.LadleMag
{
    partial class LadleInnerBuildMagShowFrm
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bsBuildInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsBuildInfo = new AppSvrHMI.L3DataSet();
            this.schemadsBuildInfo = new System.Data.DataTable();
            this.coldsBuildInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableINNERID = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableBuild_Start_Time = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableBuild_End_Time = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Fac = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableSpinel_Cast_Fac = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Fac = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableMg_Firecaly_Fact = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableOperator = new System.Data.DataColumn();
            this.coldsBuildInfoL3DataTableNote = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMgFirecalyWast = new PxDataValid.PxTextBox();
            this.txtAlMgBrickWast = new PxDataValid.PxTextBox();
            this.txtSpinelCastWast = new PxDataValid.PxTextBox();
            this.txtHardFiAdiBoaWast = new PxDataValid.PxTextBox();
            this.txtAtoLigCastWast = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbMgFirecalyFact = new PxDataValid.PxComboBox();
            this.dsMgFirecalyFact = new AppSvrHMI.L3DataSet();
            this.schemadsMgFirecalyFact = new System.Data.DataTable();
            this.coldsMgFirecalyFactL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbAlMgBrickFac = new PxDataValid.PxComboBox();
            this.dsAlMgBrickFac = new AppSvrHMI.L3DataSet();
            this.schemadsAlMgBrickFac = new System.Data.DataTable();
            this.coldsAlMgBrickFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbSpinelCastFac = new PxDataValid.PxComboBox();
            this.dsCastMat = new AppSvrHMI.L3DataSet();
            this.schemadsCastMat = new System.Data.DataTable();
            this.coldsCastMatL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbHardFiAdiBoaFac = new PxDataValid.PxComboBox();
            this.dsHardFiAdiBoaFac = new AppSvrHMI.L3DataSet();
            this.schemadsHardFiAdiBoaFac = new System.Data.DataTable();
            this.coldsHardFiAdiBoaFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.cmbAtoLigCastFac = new PxDataValid.PxComboBox();
            this.dsAtoLigCastFac = new AppSvrHMI.L3DataSet();
            this.schemadsAtoLigCastFac = new System.Data.DataTable();
            this.coldsAtoLigCastFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLadleInnerUseCount = new PxDataValid.PxTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.dtBuildEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtBuildStartTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuildInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuildInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBuildInfo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMgFirecalyFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMgFirecalyFact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlMgBrickFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlMgBrickFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHardFiAdiBoaFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHardFiAdiBoaFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtoLigCastFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAtoLigCastFac)).BeginInit();
            this.SuspendLayout();
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bsBuildInfo
            // 
            this.bsBuildInfo.DataMember = "L3DataTable";
            this.bsBuildInfo.DataSource = this.dsBuildInfo;
            // 
            // dsBuildInfo
            // 
            this.dsBuildInfo.AutoLoad = true;
            this.dsBuildInfo.AutoSubscribe = false;
            this.dsBuildInfo.DataSetName = "L3DataSet";
            this.dsBuildInfo.DeleteMethod = null;
            this.dsBuildInfo.InsertMethod = null;
            this.dsBuildInfo.L3DataAdapter = null;
            this.dsBuildInfo.LoadEvent = "Click";
            this.dsBuildInfo.LoadTrigger = null;
            this.dsBuildInfo.RefreshValve = 1000;
            this.dsBuildInfo.SourceCommand = null;
            this.dsBuildInfo.SourceCondition = "";
            this.dsBuildInfo.SourceMethod = "";
            this.dsBuildInfo.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBuildInfo.SourceURI = "";
            this.dsBuildInfo.SubscribeTarget = "";
            this.dsBuildInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBuildInfo});
            this.dsBuildInfo.UpdateEvent = "Click";
            this.dsBuildInfo.UpdateMethod = null;
            this.dsBuildInfo.UpdateTrigger = null;
            // 
            // schemadsBuildInfo
            // 
            this.schemadsBuildInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBuildInfoL3DataTableGUID,
            this.coldsBuildInfoL3DataTableName,
            this.coldsBuildInfoL3DataTableInput_Time,
            this.coldsBuildInfoL3DataTableINNERID,
            this.coldsBuildInfoL3DataTableLadleID,
            this.coldsBuildInfoL3DataTableBuild_Start_Time,
            this.coldsBuildInfoL3DataTableBuild_End_Time,
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Fac,
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast,
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac,
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast,
            this.coldsBuildInfoL3DataTableSpinel_Cast_Fac,
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast,
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Fac,
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast,
            this.coldsBuildInfoL3DataTableMg_Firecaly_Fact,
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast,
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count,
            this.coldsBuildInfoL3DataTableTeamID,
            this.coldsBuildInfoL3DataTableShiftID,
            this.coldsBuildInfoL3DataTableOperator,
            this.coldsBuildInfoL3DataTableNote});
            this.schemadsBuildInfo.TableName = "L3DataTable";
            // 
            // coldsBuildInfoL3DataTableGUID
            // 
            this.coldsBuildInfoL3DataTableGUID.Caption = "GUID";
            this.coldsBuildInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsBuildInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableName
            // 
            this.coldsBuildInfoL3DataTableName.Caption = "Name";
            this.coldsBuildInfoL3DataTableName.ColumnName = "Name";
            this.coldsBuildInfoL3DataTableName.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableInput_Time
            // 
            this.coldsBuildInfoL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsBuildInfoL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsBuildInfoL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsBuildInfoL3DataTableInput_Time.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableINNERID
            // 
            this.coldsBuildInfoL3DataTableINNERID.Caption = "INNERID";
            this.coldsBuildInfoL3DataTableINNERID.ColumnName = "INNERID";
            this.coldsBuildInfoL3DataTableINNERID.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableLadleID
            // 
            this.coldsBuildInfoL3DataTableLadleID.Caption = "LadleID";
            this.coldsBuildInfoL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsBuildInfoL3DataTableLadleID.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableBuild_Start_Time
            // 
            this.coldsBuildInfoL3DataTableBuild_Start_Time.Caption = "Build_Start_Time";
            this.coldsBuildInfoL3DataTableBuild_Start_Time.ColumnName = "Build_Start_Time";
            this.coldsBuildInfoL3DataTableBuild_Start_Time.DataType = typeof(System.DateTime);
            this.coldsBuildInfoL3DataTableBuild_Start_Time.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableBuild_End_Time
            // 
            this.coldsBuildInfoL3DataTableBuild_End_Time.Caption = "Build_End_Time";
            this.coldsBuildInfoL3DataTableBuild_End_Time.ColumnName = "Build_End_Time";
            this.coldsBuildInfoL3DataTableBuild_End_Time.DataType = typeof(System.DateTime);
            this.coldsBuildInfoL3DataTableBuild_End_Time.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableAto_Lig_Cast_Fac
            // 
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Fac.Caption = "Ato_Lig_Cast_Fac";
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Fac.ColumnName = "Ato_Lig_Cast_Fac";
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Fac.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableAto_Lig_Cast_Wast
            // 
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast.Caption = "Ato_Lig_Cast_Wast";
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast.ColumnName = "Ato_Lig_Cast_Wast";
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast.DataType = typeof(double);
            this.coldsBuildInfoL3DataTableAto_Lig_Cast_Wast.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac
            // 
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac.Caption = "Hard_Fi_Adi_Boa_Fac";
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac.ColumnName = "Hard_Fi_Adi_Boa_Fac";
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast
            // 
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast.Caption = "Hard_Fi_Adi_Boa_Wast";
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast.ColumnName = "Hard_Fi_Adi_Boa_Wast";
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast.DataType = typeof(double);
            this.coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableSpinel_Cast_Fac
            // 
            this.coldsBuildInfoL3DataTableSpinel_Cast_Fac.Caption = "Spinel_Cast_Fac";
            this.coldsBuildInfoL3DataTableSpinel_Cast_Fac.ColumnName = "Spinel_Cast_Fac";
            this.coldsBuildInfoL3DataTableSpinel_Cast_Fac.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableSpinel_Cast_Wast
            // 
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast.Caption = "Spinel_Cast_Wast";
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast.ColumnName = "Spinel_Cast_Wast";
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast.DataType = typeof(double);
            this.coldsBuildInfoL3DataTableSpinel_Cast_Wast.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableAl_Mg_Brick_Fac
            // 
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Fac.Caption = "Al_Mg_Brick_Fac";
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Fac.ColumnName = "Al_Mg_Brick_Fac";
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Fac.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableAl_Mg_Brick_Wast
            // 
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast.Caption = "Al_Mg_Brick_Wast";
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast.ColumnName = "Al_Mg_Brick_Wast";
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast.DataType = typeof(double);
            this.coldsBuildInfoL3DataTableAl_Mg_Brick_Wast.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableMg_Firecaly_Fact
            // 
            this.coldsBuildInfoL3DataTableMg_Firecaly_Fact.Caption = "Mg_Firecaly_Fact";
            this.coldsBuildInfoL3DataTableMg_Firecaly_Fact.ColumnName = "Mg_Firecaly_Fact";
            this.coldsBuildInfoL3DataTableMg_Firecaly_Fact.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableMg_Firecaly_Wast
            // 
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast.Caption = "Mg_Firecaly_Wast";
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast.ColumnName = "Mg_Firecaly_Wast";
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast.DataType = typeof(double);
            this.coldsBuildInfoL3DataTableMg_Firecaly_Wast.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableLadle_Inner_Use_Count
            // 
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count.Caption = "Ladle_Inner_Use_Count";
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count.ColumnName = "Ladle_Inner_Use_Count";
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count.DataType = typeof(int);
            this.coldsBuildInfoL3DataTableLadle_Inner_Use_Count.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableTeamID
            // 
            this.coldsBuildInfoL3DataTableTeamID.Caption = "TeamID";
            this.coldsBuildInfoL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsBuildInfoL3DataTableTeamID.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableShiftID
            // 
            this.coldsBuildInfoL3DataTableShiftID.Caption = "ShiftID";
            this.coldsBuildInfoL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsBuildInfoL3DataTableShiftID.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableOperator
            // 
            this.coldsBuildInfoL3DataTableOperator.Caption = "Operator";
            this.coldsBuildInfoL3DataTableOperator.ColumnName = "Operator";
            this.coldsBuildInfoL3DataTableOperator.Namespace = "";
            // 
            // coldsBuildInfoL3DataTableNote
            // 
            this.coldsBuildInfoL3DataTableNote.Caption = "Note";
            this.coldsBuildInfoL3DataTableNote.ColumnName = "Note";
            this.coldsBuildInfoL3DataTableNote.Namespace = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.txtMgFirecalyWast);
            this.tabPage1.Controls.Add(this.txtAlMgBrickWast);
            this.tabPage1.Controls.Add(this.txtSpinelCastWast);
            this.tabPage1.Controls.Add(this.txtHardFiAdiBoaWast);
            this.tabPage1.Controls.Add(this.txtAtoLigCastWast);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.cmbMgFirecalyFact);
            this.tabPage1.Controls.Add(this.cmbAlMgBrickFac);
            this.tabPage1.Controls.Add(this.cmbSpinelCastFac);
            this.tabPage1.Controls.Add(this.cmbHardFiAdiBoaFac);
            this.tabPage1.Controls.Add(this.cmbLadleID);
            this.tabPage1.Controls.Add(this.cmbAtoLigCastFac);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txtLadleInnerUseCount);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.dtBuildEndTime);
            this.tabPage1.Controls.Add(this.dtBuildStartTime);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "砌筑实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(451, 206);
            this.rtxtNote.MaxStrLength = 0;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(141, 42);
            this.rtxtNote.TabIndex = 18;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuildInfo, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(451, 182);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 17;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuildInfo, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(451, 158);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 16;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(451, 134);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 15;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(410, 186);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 63;
            this.label24.Text = "班次:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(410, 162);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 64;
            this.label25.Text = "班别:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(410, 210);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 61;
            this.label26.Text = "备注:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(398, 138);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 12);
            this.label27.TabIndex = 62;
            this.label27.Text = "责任人:";
            // 
            // txtMgFirecalyWast
            // 
            this.txtMgFirecalyWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Mg_Firecaly_Wast", true));
            this.txtMgFirecalyWast.EnableNull = false;
            this.txtMgFirecalyWast.ErropPr = this.errorProvider1;
            this.txtMgFirecalyWast.Length = 0;
            this.txtMgFirecalyWast.Location = new System.Drawing.Point(451, 109);
            this.txtMgFirecalyWast.Max = 0;
            this.txtMgFirecalyWast.MaxStrLength = 0;
            this.txtMgFirecalyWast.Min = -0.99;
            this.txtMgFirecalyWast.MinStrLength = 0;
            this.txtMgFirecalyWast.Name = "txtMgFirecalyWast";
            this.txtMgFirecalyWast.Precision = 2;
            this.txtMgFirecalyWast.Size = new System.Drawing.Size(141, 21);
            this.txtMgFirecalyWast.TabIndex = 14;
            this.txtMgFirecalyWast.ToolTipValid = this.toolTip1;
            this.txtMgFirecalyWast.ValidEable = true;
            this.txtMgFirecalyWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtMgFirecalyWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtAlMgBrickWast
            // 
            this.txtAlMgBrickWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Al_Mg_Brick_Wast", true));
            this.txtAlMgBrickWast.EnableNull = false;
            this.txtAlMgBrickWast.ErropPr = this.errorProvider1;
            this.txtAlMgBrickWast.Length = 0;
            this.txtAlMgBrickWast.Location = new System.Drawing.Point(451, 84);
            this.txtAlMgBrickWast.Max = 0;
            this.txtAlMgBrickWast.MaxStrLength = 0;
            this.txtAlMgBrickWast.Min = -0.99;
            this.txtAlMgBrickWast.MinStrLength = 0;
            this.txtAlMgBrickWast.Name = "txtAlMgBrickWast";
            this.txtAlMgBrickWast.Precision = 2;
            this.txtAlMgBrickWast.Size = new System.Drawing.Size(141, 21);
            this.txtAlMgBrickWast.TabIndex = 13;
            this.txtAlMgBrickWast.ToolTipValid = this.toolTip1;
            this.txtAlMgBrickWast.ValidEable = true;
            this.txtAlMgBrickWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtAlMgBrickWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtSpinelCastWast
            // 
            this.txtSpinelCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Spinel_Cast_Wast", true));
            this.txtSpinelCastWast.EnableNull = false;
            this.txtSpinelCastWast.ErropPr = this.errorProvider1;
            this.txtSpinelCastWast.Length = 0;
            this.txtSpinelCastWast.Location = new System.Drawing.Point(451, 59);
            this.txtSpinelCastWast.Max = 0;
            this.txtSpinelCastWast.MaxStrLength = 0;
            this.txtSpinelCastWast.Min = -0.99;
            this.txtSpinelCastWast.MinStrLength = 0;
            this.txtSpinelCastWast.Name = "txtSpinelCastWast";
            this.txtSpinelCastWast.Precision = 2;
            this.txtSpinelCastWast.Size = new System.Drawing.Size(141, 21);
            this.txtSpinelCastWast.TabIndex = 12;
            this.txtSpinelCastWast.ToolTipValid = this.toolTip1;
            this.txtSpinelCastWast.ValidEable = true;
            this.txtSpinelCastWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtSpinelCastWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtHardFiAdiBoaWast
            // 
            this.txtHardFiAdiBoaWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Hard_Fi_Adi_Boa_Wast", true));
            this.txtHardFiAdiBoaWast.EnableNull = false;
            this.txtHardFiAdiBoaWast.ErropPr = this.errorProvider1;
            this.txtHardFiAdiBoaWast.Length = 0;
            this.txtHardFiAdiBoaWast.Location = new System.Drawing.Point(451, 34);
            this.txtHardFiAdiBoaWast.Max = 0;
            this.txtHardFiAdiBoaWast.MaxStrLength = 0;
            this.txtHardFiAdiBoaWast.Min = -0.99;
            this.txtHardFiAdiBoaWast.MinStrLength = 0;
            this.txtHardFiAdiBoaWast.Name = "txtHardFiAdiBoaWast";
            this.txtHardFiAdiBoaWast.Precision = 2;
            this.txtHardFiAdiBoaWast.Size = new System.Drawing.Size(141, 21);
            this.txtHardFiAdiBoaWast.TabIndex = 11;
            this.txtHardFiAdiBoaWast.ToolTipValid = this.toolTip1;
            this.txtHardFiAdiBoaWast.ValidEable = true;
            this.txtHardFiAdiBoaWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtHardFiAdiBoaWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtAtoLigCastWast
            // 
            this.txtAtoLigCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Ato_Lig_Cast_Wast", true));
            this.txtAtoLigCastWast.EnableNull = false;
            this.txtAtoLigCastWast.ErropPr = this.errorProvider1;
            this.txtAtoLigCastWast.Length = 0;
            this.txtAtoLigCastWast.Location = new System.Drawing.Point(451, 9);
            this.txtAtoLigCastWast.Max = 0;
            this.txtAtoLigCastWast.MaxStrLength = 0;
            this.txtAtoLigCastWast.Min = -0.99;
            this.txtAtoLigCastWast.MinStrLength = 0;
            this.txtAtoLigCastWast.Name = "txtAtoLigCastWast";
            this.txtAtoLigCastWast.Precision = 2;
            this.txtAtoLigCastWast.Size = new System.Drawing.Size(141, 21);
            this.txtAtoLigCastWast.TabIndex = 10;
            this.txtAtoLigCastWast.ToolTipValid = this.toolTip1;
            this.txtAtoLigCastWast.ValidEable = true;
            this.txtAtoLigCastWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtAtoLigCastWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(344, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "镁火泥消耗量[t]:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(344, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 51;
            this.label19.Text = "铝镁砖消耗量[t]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(308, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(137, 12);
            this.label22.TabIndex = 53;
            this.label22.Text = "尖晶石浇铸料消耗量[t]:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(290, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 12);
            this.label23.TabIndex = 55;
            this.label23.Text = "硬质纤维隔热板消耗量[m2]:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(296, 13);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(149, 12);
            this.label33.TabIndex = 54;
            this.label33.Text = "微孔轻质浇铸料消耗量[t]:";
            // 
            // cmbMgFirecalyFact
            // 
            this.cmbMgFirecalyFact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMgFirecalyFact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMgFirecalyFact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Mg_Firecaly_Fact", true));
            this.cmbMgFirecalyFact.DataSource = this.dsMgFirecalyFact;
            this.cmbMgFirecalyFact.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbMgFirecalyFact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMgFirecalyFact.EnableNull = true;
            this.cmbMgFirecalyFact.ErropPr = null;
            this.cmbMgFirecalyFact.FormattingEnabled = true;
            this.cmbMgFirecalyFact.Location = new System.Drawing.Point(133, 230);
            this.cmbMgFirecalyFact.Name = "cmbMgFirecalyFact";
            this.cmbMgFirecalyFact.Size = new System.Drawing.Size(141, 20);
            this.cmbMgFirecalyFact.TabIndex = 9;
            this.cmbMgFirecalyFact.ToolTipValid = null;
            this.cmbMgFirecalyFact.ValidEable = true;
            this.cmbMgFirecalyFact.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsMgFirecalyFact
            // 
            this.dsMgFirecalyFact.AutoLoad = true;
            this.dsMgFirecalyFact.AutoSubscribe = false;
            this.dsMgFirecalyFact.DataSetName = "L3DataSet";
            this.dsMgFirecalyFact.DeleteMethod = null;
            this.dsMgFirecalyFact.InsertMethod = null;
            this.dsMgFirecalyFact.L3DataAdapter = this.Adapter;
            this.dsMgFirecalyFact.LoadEvent = "Click";
            this.dsMgFirecalyFact.LoadTrigger = null;
            this.dsMgFirecalyFact.RefreshValve = 1000;
            this.dsMgFirecalyFact.SourceCommand = null;
            this.dsMgFirecalyFact.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'镁火泥\'";
            this.dsMgFirecalyFact.SourceMethod = "";
            this.dsMgFirecalyFact.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMgFirecalyFact.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsMgFirecalyFact.SubscribeTarget = null;
            this.dsMgFirecalyFact.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMgFirecalyFact});
            this.dsMgFirecalyFact.UpdateEvent = "Click";
            this.dsMgFirecalyFact.UpdateMethod = null;
            this.dsMgFirecalyFact.UpdateTrigger = null;
            // 
            // schemadsMgFirecalyFact
            // 
            this.schemadsMgFirecalyFact.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMgFirecalyFactL3DataTableMATFACTORY});
            this.schemadsMgFirecalyFact.TableName = "L3DataTable";
            // 
            // coldsMgFirecalyFactL3DataTableMATFACTORY
            // 
            this.coldsMgFirecalyFactL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsMgFirecalyFactL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsMgFirecalyFactL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbAlMgBrickFac
            // 
            this.cmbAlMgBrickFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlMgBrickFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlMgBrickFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Al_Mg_Brick_Fac", true));
            this.cmbAlMgBrickFac.DataSource = this.dsAlMgBrickFac;
            this.cmbAlMgBrickFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbAlMgBrickFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlMgBrickFac.EnableNull = true;
            this.cmbAlMgBrickFac.ErropPr = null;
            this.cmbAlMgBrickFac.FormattingEnabled = true;
            this.cmbAlMgBrickFac.Location = new System.Drawing.Point(133, 206);
            this.cmbAlMgBrickFac.Name = "cmbAlMgBrickFac";
            this.cmbAlMgBrickFac.Size = new System.Drawing.Size(141, 20);
            this.cmbAlMgBrickFac.TabIndex = 8;
            this.cmbAlMgBrickFac.ToolTipValid = null;
            this.cmbAlMgBrickFac.ValidEable = true;
            this.cmbAlMgBrickFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsAlMgBrickFac
            // 
            this.dsAlMgBrickFac.AutoLoad = true;
            this.dsAlMgBrickFac.AutoSubscribe = false;
            this.dsAlMgBrickFac.DataSetName = "L3DataSet";
            this.dsAlMgBrickFac.DeleteMethod = null;
            this.dsAlMgBrickFac.InsertMethod = null;
            this.dsAlMgBrickFac.L3DataAdapter = this.Adapter;
            this.dsAlMgBrickFac.LoadEvent = "Click";
            this.dsAlMgBrickFac.LoadTrigger = null;
            this.dsAlMgBrickFac.RefreshValve = 1000;
            this.dsAlMgBrickFac.SourceCommand = null;
            this.dsAlMgBrickFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'铝镁砖\'";
            this.dsAlMgBrickFac.SourceMethod = "";
            this.dsAlMgBrickFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlMgBrickFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsAlMgBrickFac.SubscribeTarget = null;
            this.dsAlMgBrickFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlMgBrickFac});
            this.dsAlMgBrickFac.UpdateEvent = "Click";
            this.dsAlMgBrickFac.UpdateMethod = null;
            this.dsAlMgBrickFac.UpdateTrigger = null;
            // 
            // schemadsAlMgBrickFac
            // 
            this.schemadsAlMgBrickFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlMgBrickFacL3DataTableMATFACTORY});
            this.schemadsAlMgBrickFac.TableName = "L3DataTable";
            // 
            // coldsAlMgBrickFacL3DataTableMATFACTORY
            // 
            this.coldsAlMgBrickFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsAlMgBrickFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsAlMgBrickFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbSpinelCastFac
            // 
            this.cmbSpinelCastFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSpinelCastFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSpinelCastFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Spinel_Cast_Fac", true));
            this.cmbSpinelCastFac.DataSource = this.dsCastMat;
            this.cmbSpinelCastFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbSpinelCastFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpinelCastFac.EnableNull = true;
            this.cmbSpinelCastFac.ErropPr = null;
            this.cmbSpinelCastFac.FormattingEnabled = true;
            this.cmbSpinelCastFac.Location = new System.Drawing.Point(133, 182);
            this.cmbSpinelCastFac.Name = "cmbSpinelCastFac";
            this.cmbSpinelCastFac.Size = new System.Drawing.Size(141, 20);
            this.cmbSpinelCastFac.TabIndex = 7;
            this.cmbSpinelCastFac.ToolTipValid = null;
            this.cmbSpinelCastFac.ValidEable = true;
            this.cmbSpinelCastFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsCastMat
            // 
            this.dsCastMat.AutoLoad = true;
            this.dsCastMat.AutoSubscribe = false;
            this.dsCastMat.DataSetName = "L3DataSet";
            this.dsCastMat.DeleteMethod = null;
            this.dsCastMat.InsertMethod = null;
            this.dsCastMat.L3DataAdapter = this.Adapter;
            this.dsCastMat.LoadEvent = "Click";
            this.dsCastMat.LoadTrigger = null;
            this.dsCastMat.RefreshValve = 1000;
            this.dsCastMat.SourceCommand = null;
            this.dsCastMat.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'尖晶石浇铸料\'";
            this.dsCastMat.SourceMethod = "";
            this.dsCastMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCastMat.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCastMat.SubscribeTarget = null;
            this.dsCastMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCastMat});
            this.dsCastMat.UpdateEvent = "Click";
            this.dsCastMat.UpdateMethod = null;
            this.dsCastMat.UpdateTrigger = null;
            // 
            // schemadsCastMat
            // 
            this.schemadsCastMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCastMatL3DataTableMATFACTORY});
            this.schemadsCastMat.TableName = "L3DataTable";
            // 
            // coldsCastMatL3DataTableMATFACTORY
            // 
            this.coldsCastMatL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbHardFiAdiBoaFac
            // 
            this.cmbHardFiAdiBoaFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHardFiAdiBoaFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHardFiAdiBoaFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Hard_Fi_Adi_Boa_Fac", true));
            this.cmbHardFiAdiBoaFac.DataSource = this.dsHardFiAdiBoaFac;
            this.cmbHardFiAdiBoaFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbHardFiAdiBoaFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHardFiAdiBoaFac.EnableNull = true;
            this.cmbHardFiAdiBoaFac.ErropPr = null;
            this.cmbHardFiAdiBoaFac.FormattingEnabled = true;
            this.cmbHardFiAdiBoaFac.Location = new System.Drawing.Point(133, 158);
            this.cmbHardFiAdiBoaFac.Name = "cmbHardFiAdiBoaFac";
            this.cmbHardFiAdiBoaFac.Size = new System.Drawing.Size(141, 20);
            this.cmbHardFiAdiBoaFac.TabIndex = 6;
            this.cmbHardFiAdiBoaFac.ToolTipValid = null;
            this.cmbHardFiAdiBoaFac.ValidEable = true;
            this.cmbHardFiAdiBoaFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsHardFiAdiBoaFac
            // 
            this.dsHardFiAdiBoaFac.AutoLoad = true;
            this.dsHardFiAdiBoaFac.AutoSubscribe = false;
            this.dsHardFiAdiBoaFac.DataSetName = "L3DataSet";
            this.dsHardFiAdiBoaFac.DeleteMethod = null;
            this.dsHardFiAdiBoaFac.InsertMethod = null;
            this.dsHardFiAdiBoaFac.L3DataAdapter = this.Adapter;
            this.dsHardFiAdiBoaFac.LoadEvent = "Click";
            this.dsHardFiAdiBoaFac.LoadTrigger = null;
            this.dsHardFiAdiBoaFac.RefreshValve = 1000;
            this.dsHardFiAdiBoaFac.SourceCommand = null;
            this.dsHardFiAdiBoaFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'硬质纤维隔热板\'";
            this.dsHardFiAdiBoaFac.SourceMethod = "";
            this.dsHardFiAdiBoaFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHardFiAdiBoaFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsHardFiAdiBoaFac.SubscribeTarget = null;
            this.dsHardFiAdiBoaFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHardFiAdiBoaFac});
            this.dsHardFiAdiBoaFac.UpdateEvent = "Click";
            this.dsHardFiAdiBoaFac.UpdateMethod = null;
            this.dsHardFiAdiBoaFac.UpdateTrigger = null;
            // 
            // schemadsHardFiAdiBoaFac
            // 
            this.schemadsHardFiAdiBoaFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHardFiAdiBoaFacL3DataTableMATFACTORY});
            this.schemadsHardFiAdiBoaFac.TableName = "L3DataTable";
            // 
            // coldsHardFiAdiBoaFacL3DataTableMATFACTORY
            // 
            this.coldsHardFiAdiBoaFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsHardFiAdiBoaFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsHardFiAdiBoaFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuildInfo, "LadleID", true));
            this.cmbLadleID.DataSource = this.dsLadleID;
            this.cmbLadleID.DisplayMember = "L3DataTable.LadleID";
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.EnableNull = false;
            this.cmbLadleID.ErropPr = this.errorProvider1;
            this.cmbLadleID.FormattingEnabled = true;
            this.cmbLadleID.Location = new System.Drawing.Point(133, 35);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleID.TabIndex = 5;
            this.cmbLadleID.ToolTipValid = this.toolTip1;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.LadleID";
            this.cmbLadleID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadleID.SubscribeTarget = "";
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // cmbAtoLigCastFac
            // 
            this.cmbAtoLigCastFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAtoLigCastFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAtoLigCastFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Ato_Lig_Cast_Fac", true));
            this.cmbAtoLigCastFac.DataSource = this.dsAtoLigCastFac;
            this.cmbAtoLigCastFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbAtoLigCastFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtoLigCastFac.EnableNull = true;
            this.cmbAtoLigCastFac.ErropPr = null;
            this.cmbAtoLigCastFac.FormattingEnabled = true;
            this.cmbAtoLigCastFac.Location = new System.Drawing.Point(133, 134);
            this.cmbAtoLigCastFac.Name = "cmbAtoLigCastFac";
            this.cmbAtoLigCastFac.Size = new System.Drawing.Size(141, 20);
            this.cmbAtoLigCastFac.TabIndex = 5;
            this.cmbAtoLigCastFac.ToolTipValid = null;
            this.cmbAtoLigCastFac.ValidEable = true;
            this.cmbAtoLigCastFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsAtoLigCastFac
            // 
            this.dsAtoLigCastFac.AutoLoad = true;
            this.dsAtoLigCastFac.AutoSubscribe = false;
            this.dsAtoLigCastFac.DataSetName = "L3DataSet";
            this.dsAtoLigCastFac.DeleteMethod = null;
            this.dsAtoLigCastFac.InsertMethod = null;
            this.dsAtoLigCastFac.L3DataAdapter = this.Adapter;
            this.dsAtoLigCastFac.LoadEvent = "Click";
            this.dsAtoLigCastFac.LoadTrigger = null;
            this.dsAtoLigCastFac.RefreshValve = 1000;
            this.dsAtoLigCastFac.SourceCommand = null;
            this.dsAtoLigCastFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'微孔轻质浇铸料\'";
            this.dsAtoLigCastFac.SourceMethod = "";
            this.dsAtoLigCastFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAtoLigCastFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsAtoLigCastFac.SubscribeTarget = null;
            this.dsAtoLigCastFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAtoLigCastFac});
            this.dsAtoLigCastFac.UpdateEvent = "Click";
            this.dsAtoLigCastFac.UpdateMethod = null;
            this.dsAtoLigCastFac.UpdateTrigger = null;
            // 
            // schemadsAtoLigCastFac
            // 
            this.schemadsAtoLigCastFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAtoLigCastFacL3DataTableMATFACTORY});
            this.schemadsAtoLigCastFac.TableName = "L3DataTable";
            // 
            // coldsAtoLigCastFacL3DataTableMATFACTORY
            // 
            this.coldsAtoLigCastFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsAtoLigCastFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsAtoLigCastFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "镁火泥厂家:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(56, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "铝镁砖厂家:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(20, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "尖晶石浇铸料厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "硬质纤维隔热板厂家:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(8, 138);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 12);
            this.label21.TabIndex = 44;
            this.label21.Text = "微孔轻质浇铸料厂家:";
            // 
            // txtLadleInnerUseCount
            // 
            this.txtLadleInnerUseCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuildInfo, "Ladle_Inner_Use_Count", true));
            this.txtLadleInnerUseCount.EnableNull = false;
            this.txtLadleInnerUseCount.ErropPr = this.errorProvider1;
            this.txtLadleInnerUseCount.Length = 0;
            this.txtLadleInnerUseCount.Location = new System.Drawing.Point(133, 109);
            this.txtLadleInnerUseCount.Max = 0;
            this.txtLadleInnerUseCount.MaxStrLength = 0;
            this.txtLadleInnerUseCount.Min = -0.99;
            this.txtLadleInnerUseCount.MinStrLength = 0;
            this.txtLadleInnerUseCount.Name = "txtLadleInnerUseCount";
            this.txtLadleInnerUseCount.Precision = 0;
            this.txtLadleInnerUseCount.Size = new System.Drawing.Size(141, 21);
            this.txtLadleInnerUseCount.TabIndex = 4;
            this.txtLadleInnerUseCount.ToolTipValid = this.toolTip1;
            this.txtLadleInnerUseCount.ValidEable = true;
            this.txtLadleInnerUseCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtLadleInnerUseCount.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(32, 113);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 12);
            this.label34.TabIndex = 39;
            this.label34.Text = "永久层使用次数:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBuildInfo, "Input_Time", true));
            this.dtInputTime.Enabled = false;
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(133, 9);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // dtBuildEndTime
            // 
            this.dtBuildEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBuildInfo, "Build_End_Time", true));
            this.dtBuildEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildEndTime.Location = new System.Drawing.Point(133, 84);
            this.dtBuildEndTime.Name = "dtBuildEndTime";
            this.dtBuildEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildEndTime.TabIndex = 3;
            // 
            // dtBuildStartTime
            // 
            this.dtBuildStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBuildInfo, "Build_Start_Time", true));
            this.dtBuildStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildStartTime.Location = new System.Drawing.Point(133, 59);
            this.dtBuildStartTime.Name = "dtBuildStartTime";
            this.dtBuildStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildStartTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "砌筑结束时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "砌筑开始时间:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(68, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "录入时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(80, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "钢包号:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(492, 299);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(417, 299);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 26);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // LadleInnerBuildMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 358);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LadleInnerBuildMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢包永久层砌筑实绩维护界面";
            this.Load += new System.EventHandler(this.LadleInnerBuildMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuildInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBuildInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBuildInfo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMgFirecalyFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMgFirecalyFact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlMgBrickFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlMgBrickFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHardFiAdiBoaFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHardFiAdiBoaFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAtoLigCastFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAtoLigCastFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBuildInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxTextBox txtLadleInnerUseCount;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.DateTimePicker dtBuildEndTime;
        private System.Windows.Forms.DateTimePicker dtBuildStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxComboBox cmbMgFirecalyFact;
        private PxDataValid.PxComboBox cmbAlMgBrickFac;
        private PxDataValid.PxComboBox cmbSpinelCastFac;
        private PxDataValid.PxComboBox cmbHardFiAdiBoaFac;
        private PxDataValid.PxComboBox cmbAtoLigCastFac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private PxDataValid.PxTextBox txtMgFirecalyWast;
        private PxDataValid.PxTextBox txtAlMgBrickWast;
        private PxDataValid.PxTextBox txtSpinelCastWast;
        private PxDataValid.PxTextBox txtHardFiAdiBoaWast;
        private PxDataValid.PxTextBox txtAtoLigCastWast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label33;
        private PxDataValid.PxRichTextBox rtxtNote;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxComboBox cmbLadleID;
        private AppSvrHMI.L3DataSet dsBuildInfo;
        private System.Data.DataTable schemadsBuildInfo;
        private System.Data.DataColumn coldsBuildInfoL3DataTableGUID;
        private System.Data.DataColumn coldsBuildInfoL3DataTableName;
        private System.Data.DataColumn coldsBuildInfoL3DataTableInput_Time;
        private System.Data.DataColumn coldsBuildInfoL3DataTableINNERID;
        private System.Data.DataColumn coldsBuildInfoL3DataTableLadleID;
        private System.Data.DataColumn coldsBuildInfoL3DataTableBuild_Start_Time;
        private System.Data.DataColumn coldsBuildInfoL3DataTableBuild_End_Time;
        private System.Data.DataColumn coldsBuildInfoL3DataTableAto_Lig_Cast_Fac;
        private System.Data.DataColumn coldsBuildInfoL3DataTableAto_Lig_Cast_Wast;
        private System.Data.DataColumn coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Fac;
        private System.Data.DataColumn coldsBuildInfoL3DataTableHard_Fi_Adi_Boa_Wast;
        private System.Data.DataColumn coldsBuildInfoL3DataTableSpinel_Cast_Fac;
        private System.Data.DataColumn coldsBuildInfoL3DataTableSpinel_Cast_Wast;
        private System.Data.DataColumn coldsBuildInfoL3DataTableAl_Mg_Brick_Fac;
        private System.Data.DataColumn coldsBuildInfoL3DataTableAl_Mg_Brick_Wast;
        private System.Data.DataColumn coldsBuildInfoL3DataTableMg_Firecaly_Fact;
        private System.Data.DataColumn coldsBuildInfoL3DataTableMg_Firecaly_Wast;
        private System.Data.DataColumn coldsBuildInfoL3DataTableLadle_Inner_Use_Count;
        private System.Data.DataColumn coldsBuildInfoL3DataTableTeamID;
        private System.Data.DataColumn coldsBuildInfoL3DataTableShiftID;
        private System.Data.DataColumn coldsBuildInfoL3DataTableOperator;
        private System.Data.DataColumn coldsBuildInfoL3DataTableNote;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsCastMat;
        private System.Data.DataTable schemadsCastMat;
        private System.Data.DataColumn coldsCastMatL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsAtoLigCastFac;
        private AppSvrHMI.L3DataSet dsHardFiAdiBoaFac;
        private AppSvrHMI.L3DataSet dsAlMgBrickFac;
        private AppSvrHMI.L3DataSet dsMgFirecalyFact;
        private System.Data.DataTable schemadsAtoLigCastFac;
        private System.Data.DataColumn coldsAtoLigCastFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsHardFiAdiBoaFac;
        private System.Data.DataColumn coldsHardFiAdiBoaFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsAlMgBrickFac;
        private System.Data.DataColumn coldsAlMgBrickFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsMgFirecalyFact;
        private System.Data.DataColumn coldsMgFirecalyFactL3DataTableMATFACTORY;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}