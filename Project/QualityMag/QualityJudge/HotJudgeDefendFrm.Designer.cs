namespace QualityMag.QualityJudge
{
    partial class HotJudgeDefendFrm
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
            this.dsBloomData = new AppSvrHMI.L3DataSet();
            this.schemadsBloomData = new System.Data.DataTable();
            this.coldsBloomDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableName = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTablePosition = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCaster_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCasting_No = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCut_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableFinal_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableLength = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWidth = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableThickness = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Area = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Section_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Pile_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Layer_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Seq_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCur_Bay_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableDestination = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableProcess_Type = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTablePlan_Ord_ID = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableProduce_Date = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableFinish_Flag = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableFinishedTime = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableRight_Weight = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Weight = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Count1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Weight1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Reason1 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Count2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Weight2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Reason2 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Count3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Weight3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWrong_Reason3 = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableSufaceDefactDes = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableReason = new System.Data.DataColumn();
            this.coldsBloomDataL3DataTableWaitCheckFlag = new System.Data.DataColumn();
            this.bsBloomData = new System.Windows.Forms.BindingSource(this.components);
            this.dsReason = new AppSvrHMI.L3DataSet();
            this.schemadsReason = new System.Data.DataTable();
            this.coldsReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.label73 = new System.Windows.Forms.Label();
            this.tbxWasterCount = new System.Windows.Forms.Label();
            this.lblWaster_Weight3 = new System.Windows.Forms.Label();
            this.lblWaster_Count3 = new System.Windows.Forms.Label();
            this.lblWaster_Weight2 = new System.Windows.Forms.Label();
            this.lblWaster_Count2 = new System.Windows.Forms.Label();
            this.lblWaster_Weight1 = new System.Windows.Forms.Label();
            this.lblWaster_Count1 = new System.Windows.Forms.Label();
            this.lblWaster_Weight = new System.Windows.Forms.Label();
            this.lblCal_Weight = new System.Windows.Forms.Label();
            this.tbxBloomCount = new System.Windows.Forms.Label();
            this.lblSteelGradeIndex = new System.Windows.Forms.Label();
            this.lblHeatID = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmdBloomData = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.bsReasonS2 = new System.Windows.Forms.BindingSource(this.components);
            this.bsReasonS1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsReasonS3 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbWasterReason3 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbWasterReason2 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbWasterReason1 = new System.Windows.Forms.ComboBox();
            this.bsWasterReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxWrongWeight3 = new System.Windows.Forms.TextBox();
            this.tbxWrongWeight2 = new System.Windows.Forms.TextBox();
            this.tbxWrongWeight1 = new System.Windows.Forms.TextBox();
            this.cbWaitCheck = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.tbxWrongCount3 = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label66 = new System.Windows.Forms.Label();
            this.tbxWrongCount2 = new PxDataValid.PxTextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.tbxWrongCount1 = new PxDataValid.PxTextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label67 = new System.Windows.Forms.Label();
            this.tbxWrongCount = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.tbxWrongWeight = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tbxRightCount = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tbxRightWeight = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBloomData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // dsBloomData
            // 
            this.dsBloomData.AutoSubscribe = false;
            this.dsBloomData.DataSetName = "L3DataSet";
            this.dsBloomData.DeleteMethod = null;
            this.dsBloomData.InsertMethod = null;
            this.dsBloomData.L3DataAdapter = null;
            this.dsBloomData.LoadEvent = "Click";
            this.dsBloomData.LoadTrigger = null;
            this.dsBloomData.RefreshValve = 1000;
            this.dsBloomData.SourceCommand = null;
            this.dsBloomData.SourceCondition = "";
            this.dsBloomData.SourceMethod = "";
            this.dsBloomData.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBloomData.SourceURI = "";
            this.dsBloomData.SubscribeTarget = null;
            this.dsBloomData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBloomData});
            this.dsBloomData.UpdateEvent = "Click";
            this.dsBloomData.UpdateMethod = null;
            this.dsBloomData.UpdateTrigger = null;
            // 
            // schemadsBloomData
            // 
            this.schemadsBloomData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomDataL3DataTableGUID,
            this.coldsBloomDataL3DataTableName,
            this.coldsBloomDataL3DataTableMaterialID,
            this.coldsBloomDataL3DataTableStatus,
            this.coldsBloomDataL3DataTablePosition,
            this.coldsBloomDataL3DataTableQAStatus,
            this.coldsBloomDataL3DataTableQALevel,
            this.coldsBloomDataL3DataTableOrderContractID,
            this.coldsBloomDataL3DataTableProduceContractID,
            this.coldsBloomDataL3DataTableSalesContractID,
            this.coldsBloomDataL3DataTableCaster_ID,
            this.coldsBloomDataL3DataTableCasting_No,
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt,
            this.coldsBloomDataL3DataTablePre_SteelGradeIndex,
            this.coldsBloomDataL3DataTableSteelGradeIndex,
            this.coldsBloomDataL3DataTableCut_SteelGradeIndex,
            this.coldsBloomDataL3DataTableFinal_SteelGradeIndex,
            this.coldsBloomDataL3DataTableLength,
            this.coldsBloomDataL3DataTableWidth,
            this.coldsBloomDataL3DataTableThickness,
            this.coldsBloomDataL3DataTableCur_Area,
            this.coldsBloomDataL3DataTableCur_Section_ID,
            this.coldsBloomDataL3DataTableCur_Pile_ID,
            this.coldsBloomDataL3DataTableCur_Layer_ID,
            this.coldsBloomDataL3DataTableCur_Seq_ID,
            this.coldsBloomDataL3DataTableCur_Bay_ID,
            this.coldsBloomDataL3DataTableDestination,
            this.coldsBloomDataL3DataTableHot_Send_Flag,
            this.coldsBloomDataL3DataTableProcess_Type,
            this.coldsBloomDataL3DataTablePlan_Ord_ID,
            this.coldsBloomDataL3DataTableProduce_Date,
            this.coldsBloomDataL3DataTableFinish_Flag,
            this.coldsBloomDataL3DataTableFinishedTime,
            this.coldsBloomDataL3DataTableBloom_Count,
            this.coldsBloomDataL3DataTableCal_Weight,
            this.coldsBloomDataL3DataTableRight_Count,
            this.coldsBloomDataL3DataTableRight_Weight,
            this.coldsBloomDataL3DataTableWaster_Count,
            this.coldsBloomDataL3DataTableWaster_Weight,
            this.coldsBloomDataL3DataTableWaster_Count1,
            this.coldsBloomDataL3DataTableWaster_Weight1,
            this.coldsBloomDataL3DataTableWaster_Reason1,
            this.coldsBloomDataL3DataTableWaster_Count2,
            this.coldsBloomDataL3DataTableWaster_Weight2,
            this.coldsBloomDataL3DataTableWaster_Reason2,
            this.coldsBloomDataL3DataTableWaster_Count3,
            this.coldsBloomDataL3DataTableWaster_Weight3,
            this.coldsBloomDataL3DataTableWaster_Reason3,
            this.coldsBloomDataL3DataTableWrong_Count,
            this.coldsBloomDataL3DataTableWrong_Weight,
            this.coldsBloomDataL3DataTableWrong_Count1,
            this.coldsBloomDataL3DataTableWrong_Weight1,
            this.coldsBloomDataL3DataTableWrong_Reason1,
            this.coldsBloomDataL3DataTableWrong_Count2,
            this.coldsBloomDataL3DataTableWrong_Weight2,
            this.coldsBloomDataL3DataTableWrong_Reason2,
            this.coldsBloomDataL3DataTableWrong_Count3,
            this.coldsBloomDataL3DataTableWrong_Weight3,
            this.coldsBloomDataL3DataTableWrong_Reason3,
            this.coldsBloomDataL3DataTableSufaceDefactDes,
            this.coldsBloomDataL3DataTableReason,
            this.coldsBloomDataL3DataTableWaitCheckFlag});
            this.schemadsBloomData.TableName = "L3DataTable";
            // 
            // coldsBloomDataL3DataTableGUID
            // 
            this.coldsBloomDataL3DataTableGUID.Caption = "GUID";
            this.coldsBloomDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsBloomDataL3DataTableGUID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableName
            // 
            this.coldsBloomDataL3DataTableName.Caption = "Name";
            this.coldsBloomDataL3DataTableName.ColumnName = "Name";
            this.coldsBloomDataL3DataTableName.Namespace = "";
            // 
            // coldsBloomDataL3DataTableMaterialID
            // 
            this.coldsBloomDataL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsBloomDataL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsBloomDataL3DataTableMaterialID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableStatus
            // 
            this.coldsBloomDataL3DataTableStatus.Caption = "Status";
            this.coldsBloomDataL3DataTableStatus.ColumnName = "Status";
            this.coldsBloomDataL3DataTableStatus.DataType = typeof(int);
            this.coldsBloomDataL3DataTableStatus.Namespace = "";
            // 
            // coldsBloomDataL3DataTablePosition
            // 
            this.coldsBloomDataL3DataTablePosition.Caption = "Position";
            this.coldsBloomDataL3DataTablePosition.ColumnName = "Position";
            this.coldsBloomDataL3DataTablePosition.Namespace = "";
            // 
            // coldsBloomDataL3DataTableQAStatus
            // 
            this.coldsBloomDataL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsBloomDataL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsBloomDataL3DataTableQAStatus.DataType = typeof(int);
            this.coldsBloomDataL3DataTableQAStatus.Namespace = "";
            // 
            // coldsBloomDataL3DataTableQALevel
            // 
            this.coldsBloomDataL3DataTableQALevel.Caption = "QALevel";
            this.coldsBloomDataL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsBloomDataL3DataTableQALevel.DataType = typeof(int);
            this.coldsBloomDataL3DataTableQALevel.Namespace = "";
            // 
            // coldsBloomDataL3DataTableOrderContractID
            // 
            this.coldsBloomDataL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsBloomDataL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsBloomDataL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableProduceContractID
            // 
            this.coldsBloomDataL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsBloomDataL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsBloomDataL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableSalesContractID
            // 
            this.coldsBloomDataL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsBloomDataL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsBloomDataL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCaster_ID
            // 
            this.coldsBloomDataL3DataTableCaster_ID.Caption = "Caster_ID";
            this.coldsBloomDataL3DataTableCaster_ID.ColumnName = "Caster_ID";
            this.coldsBloomDataL3DataTableCaster_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCasting_No
            // 
            this.coldsBloomDataL3DataTableCasting_No.Caption = "Casting_No";
            this.coldsBloomDataL3DataTableCasting_No.ColumnName = "Casting_No";
            this.coldsBloomDataL3DataTableCasting_No.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCasting_Heat_Cnt
            // 
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt.Caption = "Casting_Heat_Cnt";
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt.ColumnName = "Casting_Heat_Cnt";
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt.DataType = typeof(int);
            this.coldsBloomDataL3DataTableCasting_Heat_Cnt.Namespace = "";
            // 
            // coldsBloomDataL3DataTablePre_SteelGradeIndex
            // 
            this.coldsBloomDataL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsBloomDataL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsBloomDataL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsBloomDataL3DataTableSteelGradeIndex
            // 
            this.coldsBloomDataL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBloomDataL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBloomDataL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCut_SteelGradeIndex
            // 
            this.coldsBloomDataL3DataTableCut_SteelGradeIndex.Caption = "Cut_SteelGradeIndex";
            this.coldsBloomDataL3DataTableCut_SteelGradeIndex.ColumnName = "Cut_SteelGradeIndex";
            this.coldsBloomDataL3DataTableCut_SteelGradeIndex.Namespace = "";
            // 
            // coldsBloomDataL3DataTableFinal_SteelGradeIndex
            // 
            this.coldsBloomDataL3DataTableFinal_SteelGradeIndex.Caption = "Final_SteelGradeIndex";
            this.coldsBloomDataL3DataTableFinal_SteelGradeIndex.ColumnName = "Final_SteelGradeIndex";
            this.coldsBloomDataL3DataTableFinal_SteelGradeIndex.Namespace = "";
            // 
            // coldsBloomDataL3DataTableLength
            // 
            this.coldsBloomDataL3DataTableLength.Caption = "Length";
            this.coldsBloomDataL3DataTableLength.ColumnName = "Length";
            this.coldsBloomDataL3DataTableLength.DataType = typeof(int);
            this.coldsBloomDataL3DataTableLength.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWidth
            // 
            this.coldsBloomDataL3DataTableWidth.Caption = "Width";
            this.coldsBloomDataL3DataTableWidth.ColumnName = "Width";
            this.coldsBloomDataL3DataTableWidth.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWidth.Namespace = "";
            // 
            // coldsBloomDataL3DataTableThickness
            // 
            this.coldsBloomDataL3DataTableThickness.Caption = "Thickness";
            this.coldsBloomDataL3DataTableThickness.ColumnName = "Thickness";
            this.coldsBloomDataL3DataTableThickness.DataType = typeof(int);
            this.coldsBloomDataL3DataTableThickness.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Area
            // 
            this.coldsBloomDataL3DataTableCur_Area.Caption = "Cur_Area";
            this.coldsBloomDataL3DataTableCur_Area.ColumnName = "Cur_Area";
            this.coldsBloomDataL3DataTableCur_Area.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Section_ID
            // 
            this.coldsBloomDataL3DataTableCur_Section_ID.Caption = "Cur_Section_ID";
            this.coldsBloomDataL3DataTableCur_Section_ID.ColumnName = "Cur_Section_ID";
            this.coldsBloomDataL3DataTableCur_Section_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Pile_ID
            // 
            this.coldsBloomDataL3DataTableCur_Pile_ID.Caption = "Cur_Pile_ID";
            this.coldsBloomDataL3DataTableCur_Pile_ID.ColumnName = "Cur_Pile_ID";
            this.coldsBloomDataL3DataTableCur_Pile_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Layer_ID
            // 
            this.coldsBloomDataL3DataTableCur_Layer_ID.Caption = "Cur_Layer_ID";
            this.coldsBloomDataL3DataTableCur_Layer_ID.ColumnName = "Cur_Layer_ID";
            this.coldsBloomDataL3DataTableCur_Layer_ID.DataType = typeof(int);
            this.coldsBloomDataL3DataTableCur_Layer_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Seq_ID
            // 
            this.coldsBloomDataL3DataTableCur_Seq_ID.Caption = "Cur_Seq_ID";
            this.coldsBloomDataL3DataTableCur_Seq_ID.ColumnName = "Cur_Seq_ID";
            this.coldsBloomDataL3DataTableCur_Seq_ID.DataType = typeof(int);
            this.coldsBloomDataL3DataTableCur_Seq_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCur_Bay_ID
            // 
            this.coldsBloomDataL3DataTableCur_Bay_ID.Caption = "Cur_Bay_ID";
            this.coldsBloomDataL3DataTableCur_Bay_ID.ColumnName = "Cur_Bay_ID";
            this.coldsBloomDataL3DataTableCur_Bay_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableDestination
            // 
            this.coldsBloomDataL3DataTableDestination.Caption = "Destination";
            this.coldsBloomDataL3DataTableDestination.ColumnName = "Destination";
            this.coldsBloomDataL3DataTableDestination.Namespace = "";
            // 
            // coldsBloomDataL3DataTableHot_Send_Flag
            // 
            this.coldsBloomDataL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsBloomDataL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsBloomDataL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsBloomDataL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsBloomDataL3DataTableProcess_Type
            // 
            this.coldsBloomDataL3DataTableProcess_Type.Caption = "Process_Type";
            this.coldsBloomDataL3DataTableProcess_Type.ColumnName = "Process_Type";
            this.coldsBloomDataL3DataTableProcess_Type.DataType = typeof(int);
            this.coldsBloomDataL3DataTableProcess_Type.Namespace = "";
            // 
            // coldsBloomDataL3DataTablePlan_Ord_ID
            // 
            this.coldsBloomDataL3DataTablePlan_Ord_ID.Caption = "Plan_Ord_ID";
            this.coldsBloomDataL3DataTablePlan_Ord_ID.ColumnName = "Plan_Ord_ID";
            this.coldsBloomDataL3DataTablePlan_Ord_ID.Namespace = "";
            // 
            // coldsBloomDataL3DataTableProduce_Date
            // 
            this.coldsBloomDataL3DataTableProduce_Date.Caption = "Produce_Date";
            this.coldsBloomDataL3DataTableProduce_Date.ColumnName = "Produce_Date";
            this.coldsBloomDataL3DataTableProduce_Date.DataType = typeof(System.DateTime);
            this.coldsBloomDataL3DataTableProduce_Date.Namespace = "";
            // 
            // coldsBloomDataL3DataTableFinish_Flag
            // 
            this.coldsBloomDataL3DataTableFinish_Flag.Caption = "Finish_Flag";
            this.coldsBloomDataL3DataTableFinish_Flag.ColumnName = "Finish_Flag";
            this.coldsBloomDataL3DataTableFinish_Flag.DataType = typeof(int);
            this.coldsBloomDataL3DataTableFinish_Flag.Namespace = "";
            // 
            // coldsBloomDataL3DataTableFinishedTime
            // 
            this.coldsBloomDataL3DataTableFinishedTime.Caption = "FinishedTime";
            this.coldsBloomDataL3DataTableFinishedTime.ColumnName = "FinishedTime";
            this.coldsBloomDataL3DataTableFinishedTime.DataType = typeof(System.DateTime);
            this.coldsBloomDataL3DataTableFinishedTime.Namespace = "";
            // 
            // coldsBloomDataL3DataTableBloom_Count
            // 
            this.coldsBloomDataL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsBloomDataL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsBloomDataL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsBloomDataL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsBloomDataL3DataTableCal_Weight
            // 
            this.coldsBloomDataL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsBloomDataL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsBloomDataL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsBloomDataL3DataTableRight_Count
            // 
            this.coldsBloomDataL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsBloomDataL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsBloomDataL3DataTableRight_Count.DataType = typeof(int);
            this.coldsBloomDataL3DataTableRight_Count.Namespace = "";
            // 
            // coldsBloomDataL3DataTableRight_Weight
            // 
            this.coldsBloomDataL3DataTableRight_Weight.Caption = "Right_Weight";
            this.coldsBloomDataL3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coldsBloomDataL3DataTableRight_Weight.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Count
            // 
            this.coldsBloomDataL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsBloomDataL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsBloomDataL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Weight
            // 
            this.coldsBloomDataL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsBloomDataL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsBloomDataL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Count1
            // 
            this.coldsBloomDataL3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coldsBloomDataL3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coldsBloomDataL3DataTableWaster_Count1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Weight1
            // 
            this.coldsBloomDataL3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coldsBloomDataL3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coldsBloomDataL3DataTableWaster_Weight1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Reason1
            // 
            this.coldsBloomDataL3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coldsBloomDataL3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coldsBloomDataL3DataTableWaster_Reason1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Count2
            // 
            this.coldsBloomDataL3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coldsBloomDataL3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coldsBloomDataL3DataTableWaster_Count2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Weight2
            // 
            this.coldsBloomDataL3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coldsBloomDataL3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coldsBloomDataL3DataTableWaster_Weight2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Reason2
            // 
            this.coldsBloomDataL3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coldsBloomDataL3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coldsBloomDataL3DataTableWaster_Reason2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Count3
            // 
            this.coldsBloomDataL3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coldsBloomDataL3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coldsBloomDataL3DataTableWaster_Count3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Weight3
            // 
            this.coldsBloomDataL3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coldsBloomDataL3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coldsBloomDataL3DataTableWaster_Weight3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaster_Reason3
            // 
            this.coldsBloomDataL3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coldsBloomDataL3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coldsBloomDataL3DataTableWaster_Reason3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Count
            // 
            this.coldsBloomDataL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsBloomDataL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsBloomDataL3DataTableWrong_Count.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Weight
            // 
            this.coldsBloomDataL3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coldsBloomDataL3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coldsBloomDataL3DataTableWrong_Weight.DataType = typeof(double);
            this.coldsBloomDataL3DataTableWrong_Weight.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Count1
            // 
            this.coldsBloomDataL3DataTableWrong_Count1.Caption = "Wrong_Count1";
            this.coldsBloomDataL3DataTableWrong_Count1.ColumnName = "Wrong_Count1";
            this.coldsBloomDataL3DataTableWrong_Count1.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWrong_Count1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Weight1
            // 
            this.coldsBloomDataL3DataTableWrong_Weight1.Caption = "Wrong_Weight1";
            this.coldsBloomDataL3DataTableWrong_Weight1.ColumnName = "Wrong_Weight1";
            this.coldsBloomDataL3DataTableWrong_Weight1.DataType = typeof(double);
            this.coldsBloomDataL3DataTableWrong_Weight1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Reason1
            // 
            this.coldsBloomDataL3DataTableWrong_Reason1.Caption = "Wrong_Reason1";
            this.coldsBloomDataL3DataTableWrong_Reason1.ColumnName = "Wrong_Reason1";
            this.coldsBloomDataL3DataTableWrong_Reason1.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Count2
            // 
            this.coldsBloomDataL3DataTableWrong_Count2.Caption = "Wrong_Count2";
            this.coldsBloomDataL3DataTableWrong_Count2.ColumnName = "Wrong_Count2";
            this.coldsBloomDataL3DataTableWrong_Count2.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWrong_Count2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Weight2
            // 
            this.coldsBloomDataL3DataTableWrong_Weight2.Caption = "Wrong_Weight2";
            this.coldsBloomDataL3DataTableWrong_Weight2.ColumnName = "Wrong_Weight2";
            this.coldsBloomDataL3DataTableWrong_Weight2.DataType = typeof(double);
            this.coldsBloomDataL3DataTableWrong_Weight2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Reason2
            // 
            this.coldsBloomDataL3DataTableWrong_Reason2.Caption = "Wrong_Reason2";
            this.coldsBloomDataL3DataTableWrong_Reason2.ColumnName = "Wrong_Reason2";
            this.coldsBloomDataL3DataTableWrong_Reason2.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Count3
            // 
            this.coldsBloomDataL3DataTableWrong_Count3.Caption = "Wrong_Count3";
            this.coldsBloomDataL3DataTableWrong_Count3.ColumnName = "Wrong_Count3";
            this.coldsBloomDataL3DataTableWrong_Count3.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWrong_Count3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Weight3
            // 
            this.coldsBloomDataL3DataTableWrong_Weight3.Caption = "Wrong_Weight3";
            this.coldsBloomDataL3DataTableWrong_Weight3.ColumnName = "Wrong_Weight3";
            this.coldsBloomDataL3DataTableWrong_Weight3.DataType = typeof(double);
            this.coldsBloomDataL3DataTableWrong_Weight3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWrong_Reason3
            // 
            this.coldsBloomDataL3DataTableWrong_Reason3.Caption = "Wrong_Reason3";
            this.coldsBloomDataL3DataTableWrong_Reason3.ColumnName = "Wrong_Reason3";
            this.coldsBloomDataL3DataTableWrong_Reason3.Namespace = "";
            // 
            // coldsBloomDataL3DataTableSufaceDefactDes
            // 
            this.coldsBloomDataL3DataTableSufaceDefactDes.Caption = "SufaceDefactDes";
            this.coldsBloomDataL3DataTableSufaceDefactDes.ColumnName = "SufaceDefactDes";
            this.coldsBloomDataL3DataTableSufaceDefactDes.Namespace = "";
            // 
            // coldsBloomDataL3DataTableReason
            // 
            this.coldsBloomDataL3DataTableReason.Caption = "Reason";
            this.coldsBloomDataL3DataTableReason.ColumnName = "Reason";
            this.coldsBloomDataL3DataTableReason.Namespace = "";
            // 
            // coldsBloomDataL3DataTableWaitCheckFlag
            // 
            this.coldsBloomDataL3DataTableWaitCheckFlag.Caption = "WaitCheckFlag";
            this.coldsBloomDataL3DataTableWaitCheckFlag.ColumnName = "WaitCheckFlag";
            this.coldsBloomDataL3DataTableWaitCheckFlag.DataType = typeof(int);
            this.coldsBloomDataL3DataTableWaitCheckFlag.Namespace = "";
            // 
            // bsBloomData
            // 
            this.bsBloomData.DataMember = "L3DataTable";
            this.bsBloomData.DataSource = this.dsBloomData;
            // 
            // dsReason
            // 
            this.dsReason.AutoSubscribe = true;
            this.dsReason.DataSetName = "L3DataSet";
            this.dsReason.DeleteMethod = null;
            this.dsReason.InsertMethod = null;
            this.dsReason.L3DataAdapter = this.Adapter;
            this.dsReason.LoadEvent = "Click";
            this.dsReason.LoadTrigger = null;
            this.dsReason.RefreshValve = 1000;
            this.dsReason.SourceCommand = null;
            this.dsReason.SourceCondition = "Code_Group = \'WRONG_REASON_CODE\' order by Code";
            this.dsReason.SourceMethod = "";
            this.dsReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsReason.SubscribeTarget = null;
            this.dsReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReason});
            this.dsReason.UpdateEvent = "Click";
            this.dsReason.UpdateMethod = null;
            this.dsReason.UpdateTrigger = null;
            // 
            // schemadsReason
            // 
            this.schemadsReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReasonL3DataTableCode,
            this.coldsReasonL3DataTableCode_Des});
            this.schemadsReason.TableName = "L3DataTable";
            // 
            // coldsReasonL3DataTableCode
            // 
            this.coldsReasonL3DataTableCode.Caption = "Code";
            this.coldsReasonL3DataTableCode.ColumnName = "Code";
            this.coldsReasonL3DataTableCode.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Des
            // 
            this.coldsReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.Namespace = "";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(192, 43);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(71, 12);
            this.label73.TabIndex = 34;
            this.label73.Text = "甩废总长度:";
            // 
            // tbxWasterCount
            // 
            this.tbxWasterCount.AutoSize = true;
            this.tbxWasterCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Count", true));
            this.tbxWasterCount.Location = new System.Drawing.Point(269, 43);
            this.tbxWasterCount.Name = "tbxWasterCount";
            this.tbxWasterCount.Size = new System.Drawing.Size(29, 12);
            this.tbxWasterCount.TabIndex = 70;
            this.tbxWasterCount.Text = "XXXX";
            // 
            // lblWaster_Weight3
            // 
            this.lblWaster_Weight3.AutoSize = true;
            this.lblWaster_Weight3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Weight3", true));
            this.lblWaster_Weight3.Location = new System.Drawing.Point(269, 121);
            this.lblWaster_Weight3.Name = "lblWaster_Weight3";
            this.lblWaster_Weight3.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Weight3.TabIndex = 52;
            this.lblWaster_Weight3.Text = "XXXX";
            // 
            // lblWaster_Count3
            // 
            this.lblWaster_Count3.AutoSize = true;
            this.lblWaster_Count3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Count3", true));
            this.lblWaster_Count3.Location = new System.Drawing.Point(105, 121);
            this.lblWaster_Count3.Name = "lblWaster_Count3";
            this.lblWaster_Count3.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Count3.TabIndex = 38;
            this.lblWaster_Count3.Text = "XXXX";
            // 
            // lblWaster_Weight2
            // 
            this.lblWaster_Weight2.AutoSize = true;
            this.lblWaster_Weight2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Weight2", true));
            this.lblWaster_Weight2.Location = new System.Drawing.Point(269, 95);
            this.lblWaster_Weight2.Name = "lblWaster_Weight2";
            this.lblWaster_Weight2.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Weight2.TabIndex = 64;
            this.lblWaster_Weight2.Text = "XXXX";
            // 
            // lblWaster_Count2
            // 
            this.lblWaster_Count2.AutoSize = true;
            this.lblWaster_Count2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Count2", true));
            this.lblWaster_Count2.Location = new System.Drawing.Point(105, 95);
            this.lblWaster_Count2.Name = "lblWaster_Count2";
            this.lblWaster_Count2.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Count2.TabIndex = 65;
            this.lblWaster_Count2.Text = "XXXX";
            // 
            // lblWaster_Weight1
            // 
            this.lblWaster_Weight1.AutoSize = true;
            this.lblWaster_Weight1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Weight1", true));
            this.lblWaster_Weight1.Location = new System.Drawing.Point(269, 69);
            this.lblWaster_Weight1.Name = "lblWaster_Weight1";
            this.lblWaster_Weight1.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Weight1.TabIndex = 71;
            this.lblWaster_Weight1.Text = "XXXX";
            // 
            // lblWaster_Count1
            // 
            this.lblWaster_Count1.AutoSize = true;
            this.lblWaster_Count1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Count1", true));
            this.lblWaster_Count1.Location = new System.Drawing.Point(105, 69);
            this.lblWaster_Count1.Name = "lblWaster_Count1";
            this.lblWaster_Count1.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Count1.TabIndex = 72;
            this.lblWaster_Count1.Text = "XXXX";
            // 
            // lblWaster_Weight
            // 
            this.lblWaster_Weight.AutoSize = true;
            this.lblWaster_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Waster_Weight", true));
            this.lblWaster_Weight.Location = new System.Drawing.Point(413, 43);
            this.lblWaster_Weight.Name = "lblWaster_Weight";
            this.lblWaster_Weight.Size = new System.Drawing.Size(29, 12);
            this.lblWaster_Weight.TabIndex = 69;
            this.lblWaster_Weight.Text = "XXXX";
            // 
            // lblCal_Weight
            // 
            this.lblCal_Weight.AutoSize = true;
            this.lblCal_Weight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Cal_Weight", true));
            this.lblCal_Weight.Location = new System.Drawing.Point(413, 17);
            this.lblCal_Weight.Name = "lblCal_Weight";
            this.lblCal_Weight.Size = new System.Drawing.Size(29, 12);
            this.lblCal_Weight.TabIndex = 55;
            this.lblCal_Weight.Text = "XXXX";
            // 
            // tbxBloomCount
            // 
            this.tbxBloomCount.AutoSize = true;
            this.tbxBloomCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Bloom_Count", true));
            this.tbxBloomCount.Location = new System.Drawing.Point(269, 17);
            this.tbxBloomCount.Name = "tbxBloomCount";
            this.tbxBloomCount.Size = new System.Drawing.Size(29, 12);
            this.tbxBloomCount.TabIndex = 56;
            this.tbxBloomCount.Text = "XXXX";
            // 
            // lblSteelGradeIndex
            // 
            this.lblSteelGradeIndex.AutoSize = true;
            this.lblSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "SteelGradeIndex", true));
            this.lblSteelGradeIndex.Location = new System.Drawing.Point(105, 43);
            this.lblSteelGradeIndex.Name = "lblSteelGradeIndex";
            this.lblSteelGradeIndex.Size = new System.Drawing.Size(29, 12);
            this.lblSteelGradeIndex.TabIndex = 60;
            this.lblSteelGradeIndex.Text = "XXXX";
            // 
            // lblHeatID
            // 
            this.lblHeatID.AutoSize = true;
            this.lblHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "MaterialID", true));
            this.lblHeatID.Location = new System.Drawing.Point(105, 17);
            this.lblHeatID.Name = "lblHeatID";
            this.lblHeatID.Size = new System.Drawing.Size(29, 12);
            this.lblHeatID.TabIndex = 61;
            this.lblHeatID.Text = "XXXX";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(344, 121);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(65, 12);
            this.label38.TabIndex = 14;
            this.label38.Text = "甩废原因3:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(198, 121);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 16;
            this.label30.Text = "甩废重量3:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(31, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "甩废长度3:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(344, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 6;
            this.label21.Text = "甩废原因2:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(198, 95);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 28;
            this.label27.Text = "甩废重量2:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(31, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 12);
            this.label37.TabIndex = 29;
            this.label37.Text = "甩废长度2:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(344, 69);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 32;
            this.label29.Text = "甩废原因1:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(198, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 35;
            this.label28.Text = "甩废重量1:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(31, 69);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(65, 12);
            this.label35.TabIndex = 36;
            this.label35.Text = "甩废长度1:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(338, 43);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(71, 12);
            this.label36.TabIndex = 33;
            this.label36.Text = "甩废总重量:";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(350, 17);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(59, 12);
            this.label76.TabIndex = 19;
            this.label76.Text = "理论重量:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(204, 17);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(59, 12);
            this.label77.TabIndex = 20;
            this.label77.Text = "钢坯支数:";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(35, 43);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(59, 12);
            this.label81.TabIndex = 24;
            this.label81.Text = "炼钢记号:";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(37, 17);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(47, 12);
            this.label82.TabIndex = 25;
            this.label82.Text = "熔炼号:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 345);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(553, 50);
            this.flowLayoutPanel1.TabIndex = 68;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(472, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(397, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 26);
            this.btnOK.TabIndex = 65;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmdBloomData
            // 
            this.cmdBloomData.Adapter = this.Adapter;
            this.cmdBloomData.MergeReturnTarget = false;
            this.cmdBloomData.Method = "BloomHotJudge";
            this.cmdBloomData.Object = "XGMESLogic\\QualityMag\\CQA_HeatSufaceAssume_Mag\\QA_HeatSufaceAssume_Mag";
            this.cmdBloomData.Parameters.Add(this.l3CommandParameter1);
            this.cmdBloomData.ReturnTarget = null;
            this.cmdBloomData.ReturnTargetProperty = null;
            this.cmdBloomData.Trigger = null;
            this.cmdBloomData.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsBloomData;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // bsReasonS2
            // 
            this.bsReasonS2.DataMember = "L3DataTable";
            this.bsReasonS2.DataSource = this.dsReason;
            // 
            // bsReasonS1
            // 
            this.bsReasonS1.DataMember = "L3DataTable";
            this.bsReasonS1.DataSource = this.dsReason;
            // 
            // bsReasonS3
            // 
            this.bsReasonS3.DataMember = "L3DataTable";
            this.bsReasonS3.DataSource = this.dsReason;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbWasterReason3);
            this.groupBox1.Controls.Add(this.cmbWasterReason2);
            this.groupBox1.Controls.Add(this.cmbWasterReason1);
            this.groupBox1.Controls.Add(this.label73);
            this.groupBox1.Controls.Add(this.lblHeatID);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.tbxWasterCount);
            this.groupBox1.Controls.Add(this.lblSteelGradeIndex);
            this.groupBox1.Controls.Add(this.label82);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.tbxBloomCount);
            this.groupBox1.Controls.Add(this.label81);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblWaster_Weight3);
            this.groupBox1.Controls.Add(this.lblCal_Weight);
            this.groupBox1.Controls.Add(this.label77);
            this.groupBox1.Controls.Add(this.lblWaster_Weight);
            this.groupBox1.Controls.Add(this.lblWaster_Count3);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label76);
            this.groupBox1.Controls.Add(this.lblWaster_Count1);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.lblWaster_Weight1);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.lblWaster_Weight2);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.lblWaster_Count2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 143);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // cmbWasterReason3
            // 
            this.cmbWasterReason3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Waster_Reason3", true));
            this.cmbWasterReason3.DataSource = this.bsWasterReason3;
            this.cmbWasterReason3.DisplayMember = "Code_Des";
            this.cmbWasterReason3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason3.Enabled = false;
            this.cmbWasterReason3.FormattingEnabled = true;
            this.cmbWasterReason3.Location = new System.Drawing.Point(415, 118);
            this.cmbWasterReason3.Name = "cmbWasterReason3";
            this.cmbWasterReason3.Size = new System.Drawing.Size(132, 20);
            this.cmbWasterReason3.TabIndex = 102;
            this.cmbWasterReason3.ValueMember = "Code";
            // 
            // bsWasterReason3
            // 
            this.bsWasterReason3.DataMember = "L3DataTable";
            this.bsWasterReason3.DataSource = this.dsWasterReason;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\'";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // cmbWasterReason2
            // 
            this.cmbWasterReason2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Waster_Reason2", true));
            this.cmbWasterReason2.DataSource = this.bsWasterReason2;
            this.cmbWasterReason2.DisplayMember = "Code_Des";
            this.cmbWasterReason2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason2.Enabled = false;
            this.cmbWasterReason2.FormattingEnabled = true;
            this.cmbWasterReason2.Location = new System.Drawing.Point(415, 92);
            this.cmbWasterReason2.Name = "cmbWasterReason2";
            this.cmbWasterReason2.Size = new System.Drawing.Size(132, 20);
            this.cmbWasterReason2.TabIndex = 101;
            this.cmbWasterReason2.ValueMember = "Code";
            // 
            // bsWasterReason2
            // 
            this.bsWasterReason2.DataMember = "L3DataTable";
            this.bsWasterReason2.DataSource = this.dsWasterReason;
            // 
            // cmbWasterReason1
            // 
            this.cmbWasterReason1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Waster_Reason1", true));
            this.cmbWasterReason1.DataSource = this.bsWasterReason1;
            this.cmbWasterReason1.DisplayMember = "Code_Des";
            this.cmbWasterReason1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWasterReason1.Enabled = false;
            this.cmbWasterReason1.FormattingEnabled = true;
            this.cmbWasterReason1.Location = new System.Drawing.Point(415, 66);
            this.cmbWasterReason1.Name = "cmbWasterReason1";
            this.cmbWasterReason1.Size = new System.Drawing.Size(132, 20);
            this.cmbWasterReason1.TabIndex = 100;
            this.cmbWasterReason1.ValueMember = "Code";
            // 
            // bsWasterReason1
            // 
            this.bsWasterReason1.DataMember = "L3DataTable";
            this.bsWasterReason1.DataSource = this.dsWasterReason;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 143);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(553, 202);
            this.tabControl2.TabIndex = 72;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.tbxWrongWeight3);
            this.tabPage2.Controls.Add(this.tbxWrongWeight2);
            this.tabPage2.Controls.Add(this.tbxWrongWeight1);
            this.tabPage2.Controls.Add(this.cbWaitCheck);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label75);
            this.tabPage2.Controls.Add(this.tbxWrongCount3);
            this.tabPage2.Controls.Add(this.label66);
            this.tabPage2.Controls.Add(this.tbxWrongCount2);
            this.tabPage2.Controls.Add(this.label57);
            this.tabPage2.Controls.Add(this.tbxWrongCount1);
            this.tabPage2.Controls.Add(this.label56);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label67);
            this.tabPage2.Controls.Add(this.tbxWrongCount);
            this.tabPage2.Controls.Add(this.label65);
            this.tabPage2.Controls.Add(this.label55);
            this.tabPage2.Controls.Add(this.label64);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.tbxWrongWeight);
            this.tabPage2.Controls.Add(this.label74);
            this.tabPage2.Controls.Add(this.label54);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.tbxRightCount);
            this.tabPage2.Controls.Add(this.label63);
            this.tabPage2.Controls.Add(this.tbxRightWeight);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 177);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "质量判定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxWrongWeight3
            // 
            this.tbxWrongWeight3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Weight3", true));
            this.tbxWrongWeight3.Location = new System.Drawing.Point(257, 111);
            this.tbxWrongWeight3.Name = "tbxWrongWeight3";
            this.tbxWrongWeight3.ReadOnly = true;
            this.tbxWrongWeight3.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongWeight3.TabIndex = 72;
            this.tbxWrongWeight3.Tag = "3";
            // 
            // tbxWrongWeight2
            // 
            this.tbxWrongWeight2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Weight2", true));
            this.tbxWrongWeight2.Location = new System.Drawing.Point(257, 84);
            this.tbxWrongWeight2.Name = "tbxWrongWeight2";
            this.tbxWrongWeight2.ReadOnly = true;
            this.tbxWrongWeight2.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongWeight2.TabIndex = 71;
            this.tbxWrongWeight2.Tag = "2";
            // 
            // tbxWrongWeight1
            // 
            this.tbxWrongWeight1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Weight1", true));
            this.tbxWrongWeight1.Location = new System.Drawing.Point(257, 58);
            this.tbxWrongWeight1.Name = "tbxWrongWeight1";
            this.tbxWrongWeight1.ReadOnly = true;
            this.tbxWrongWeight1.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongWeight1.TabIndex = 70;
            this.tbxWrongWeight1.Tag = "1";
            // 
            // cbWaitCheck
            // 
            this.cbWaitCheck.AutoSize = true;
            this.cbWaitCheck.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsBloomData, "WaitCheckFlag", true));
            this.cbWaitCheck.Location = new System.Drawing.Point(329, 32);
            this.cbWaitCheck.Name = "cbWaitCheck";
            this.cbWaitCheck.Size = new System.Drawing.Size(72, 16);
            this.cbWaitCheck.TabIndex = 69;
            this.cbWaitCheck.Text = "不良待判";
            this.cbWaitCheck.UseVisualStyleBackColor = true;
            this.cbWaitCheck.CheckedChanged += new System.EventHandler(this.cbWaitCheck_CheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "SufaceDefactDes", true));
            this.textBox6.Location = new System.Drawing.Point(102, 139);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(433, 21);
            this.textBox6.TabIndex = 68;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(32, 12);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(59, 12);
            this.label75.TabIndex = 22;
            this.label75.Text = "合格支数:";
            // 
            // tbxWrongCount3
            // 
            this.tbxWrongCount3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Count3", true));
            this.tbxWrongCount3.EnableNull = true;
            this.tbxWrongCount3.ErropPr = this.errorProvider1;
            this.tbxWrongCount3.Length = 0;
            this.tbxWrongCount3.Location = new System.Drawing.Point(102, 111);
            this.tbxWrongCount3.Max = 0;
            this.tbxWrongCount3.MaxStrLength = 0;
            this.tbxWrongCount3.Min = 0;
            this.tbxWrongCount3.MinStrLength = 0;
            this.tbxWrongCount3.Name = "tbxWrongCount3";
            this.tbxWrongCount3.Precision = 0;
            this.tbxWrongCount3.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongCount3.TabIndex = 68;
            this.tbxWrongCount3.Tag = "3";
            this.tbxWrongCount3.ToolTipValid = null;
            this.tbxWrongCount3.ValidEable = false;
            this.tbxWrongCount3.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.tbxWrongCount3.TextChanged += new System.EventHandler(this.CalculateWeight);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(14, 115);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(77, 12);
            this.label66.TabIndex = 17;
            this.label66.Text = "不合格支数3:";
            // 
            // tbxWrongCount2
            // 
            this.tbxWrongCount2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Count2", true));
            this.tbxWrongCount2.EnableNull = true;
            this.tbxWrongCount2.ErropPr = this.errorProvider1;
            this.tbxWrongCount2.Length = 0;
            this.tbxWrongCount2.Location = new System.Drawing.Point(102, 85);
            this.tbxWrongCount2.Max = 0;
            this.tbxWrongCount2.MaxStrLength = 0;
            this.tbxWrongCount2.Min = 0;
            this.tbxWrongCount2.MinStrLength = 0;
            this.tbxWrongCount2.Name = "tbxWrongCount2";
            this.tbxWrongCount2.Precision = 0;
            this.tbxWrongCount2.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongCount2.TabIndex = 68;
            this.tbxWrongCount2.Tag = "2";
            this.tbxWrongCount2.ToolTipValid = null;
            this.tbxWrongCount2.ValidEable = false;
            this.tbxWrongCount2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.tbxWrongCount2.TextChanged += new System.EventHandler(this.CalculateWeight);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(327, 63);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(77, 12);
            this.label57.TabIndex = 10;
            this.label57.Text = "不合格原因1:";
            // 
            // tbxWrongCount1
            // 
            this.tbxWrongCount1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Count1", true));
            this.tbxWrongCount1.EnableNull = true;
            this.tbxWrongCount1.ErropPr = this.errorProvider1;
            this.tbxWrongCount1.Length = 0;
            this.tbxWrongCount1.Location = new System.Drawing.Point(102, 59);
            this.tbxWrongCount1.Max = 0;
            this.tbxWrongCount1.MaxStrLength = 0;
            this.tbxWrongCount1.Min = 0;
            this.tbxWrongCount1.MinStrLength = 0;
            this.tbxWrongCount1.Name = "tbxWrongCount1";
            this.tbxWrongCount1.Precision = 0;
            this.tbxWrongCount1.Size = new System.Drawing.Size(64, 21);
            this.tbxWrongCount1.TabIndex = 68;
            this.tbxWrongCount1.Tag = "1";
            this.tbxWrongCount1.ToolTipValid = null;
            this.tbxWrongCount1.ValidEable = false;
            this.tbxWrongCount1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.tbxWrongCount1.TextChanged += new System.EventHandler(this.CalculateWeight);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(181, 63);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(77, 12);
            this.label56.TabIndex = 18;
            this.label56.Text = "不合格重量1:";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Wrong_Reason3", true));
            this.comboBox3.DataSource = this.bsReasonS3;
            this.comboBox3.DisplayMember = "Code_Des";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(410, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 67;
            this.comboBox3.ValueMember = "Code";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 142);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = "表面缺陷描述:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Wrong_Reason2", true));
            this.comboBox2.DataSource = this.bsReasonS2;
            this.comboBox2.DisplayMember = "Code_Des";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(410, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 67;
            this.comboBox2.ValueMember = "Code";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBloomData, "Wrong_Reason1", true));
            this.comboBox1.DataSource = this.bsReasonS1;
            this.comboBox1.DisplayMember = "Code_Des";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(410, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.ValueMember = "Code";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(181, 115);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(77, 12);
            this.label67.TabIndex = 13;
            this.label67.Text = "不合格重量3:";
            // 
            // tbxWrongCount
            // 
            this.tbxWrongCount.AutoSize = true;
            this.tbxWrongCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Count", true));
            this.tbxWrongCount.Location = new System.Drawing.Point(102, 36);
            this.tbxWrongCount.Name = "tbxWrongCount";
            this.tbxWrongCount.Size = new System.Drawing.Size(41, 12);
            this.tbxWrongCount.TabIndex = 66;
            this.tbxWrongCount.Text = "label1";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(327, 89);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(77, 12);
            this.label65.TabIndex = 3;
            this.label65.Text = "不合格原因2:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(14, 63);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(77, 12);
            this.label55.TabIndex = 4;
            this.label55.Text = "不合格支数1:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(181, 89);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(77, 12);
            this.label64.TabIndex = 5;
            this.label64.Text = "不合格重量2:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(327, 115);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 12);
            this.label43.TabIndex = 31;
            this.label43.Text = "不合格原因3:";
            // 
            // tbxWrongWeight
            // 
            this.tbxWrongWeight.AutoSize = true;
            this.tbxWrongWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Wrong_Weight", true));
            this.tbxWrongWeight.Location = new System.Drawing.Point(264, 36);
            this.tbxWrongWeight.Name = "tbxWrongWeight";
            this.tbxWrongWeight.Size = new System.Drawing.Size(41, 12);
            this.tbxWrongWeight.TabIndex = 44;
            this.tbxWrongWeight.Text = "label1";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(199, 12);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(59, 12);
            this.label74.TabIndex = 21;
            this.label74.Text = "合格重量:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(175, 36);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 12);
            this.label54.TabIndex = 8;
            this.label54.Text = "不合格总重量:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(8, 36);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(83, 12);
            this.label53.TabIndex = 30;
            this.label53.Text = "不合格总支数:";
            // 
            // tbxRightCount
            // 
            this.tbxRightCount.AutoSize = true;
            this.tbxRightCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Right_Count", true));
            this.tbxRightCount.Location = new System.Drawing.Point(102, 12);
            this.tbxRightCount.Name = "tbxRightCount";
            this.tbxRightCount.Size = new System.Drawing.Size(41, 12);
            this.tbxRightCount.TabIndex = 58;
            this.tbxRightCount.Text = "label1";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(14, 89);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(77, 12);
            this.label63.TabIndex = 7;
            this.label63.Text = "不合格支数2:";
            // 
            // tbxRightWeight
            // 
            this.tbxRightWeight.AutoSize = true;
            this.tbxRightWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBloomData, "Right_Weight", true));
            this.tbxRightWeight.Location = new System.Drawing.Point(264, 12);
            this.tbxRightWeight.Name = "tbxRightWeight";
            this.tbxRightWeight.Size = new System.Drawing.Size(41, 12);
            this.tbxRightWeight.TabIndex = 57;
            this.tbxRightWeight.Text = "label1";
            // 
            // HotJudgeDefendFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 395);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HotJudgeDefendFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "热检质量判定";
            this.Load += new System.EventHandler(this.HotJudgeDefendFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBloomData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReasonS3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private AppSvrHMI.L3DataSet dsBloomData;
        private System.Windows.Forms.BindingSource bsBloomData;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label tbxWasterCount;
        private System.Windows.Forms.Label lblWaster_Weight3;
        private System.Windows.Forms.Label lblWaster_Count3;
        private System.Windows.Forms.Label lblWaster_Weight2;
        private System.Windows.Forms.Label lblWaster_Count2;
        private System.Windows.Forms.Label lblWaster_Weight1;
        private System.Windows.Forms.Label lblWaster_Count1;
        private System.Windows.Forms.Label lblWaster_Weight;
        private System.Windows.Forms.Label lblCal_Weight;
        private System.Windows.Forms.Label tbxBloomCount;
        private System.Windows.Forms.Label lblSteelGradeIndex;
        private System.Windows.Forms.Label lblHeatID;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Data.DataTable schemadsBloomData;
        private System.Data.DataColumn coldsBloomDataL3DataTableGUID;
        private System.Data.DataColumn coldsBloomDataL3DataTableName;
        private System.Data.DataColumn coldsBloomDataL3DataTableMaterialID;
        private System.Data.DataColumn coldsBloomDataL3DataTableStatus;
        private System.Data.DataColumn coldsBloomDataL3DataTablePosition;
        private System.Data.DataColumn coldsBloomDataL3DataTableQAStatus;
        private System.Data.DataColumn coldsBloomDataL3DataTableQALevel;
        private System.Data.DataColumn coldsBloomDataL3DataTableOrderContractID;
        private System.Data.DataColumn coldsBloomDataL3DataTableProduceContractID;
        private System.Data.DataColumn coldsBloomDataL3DataTableSalesContractID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCaster_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCasting_No;
        private System.Data.DataColumn coldsBloomDataL3DataTableCasting_Heat_Cnt;
        private System.Data.DataColumn coldsBloomDataL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsBloomDataL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBloomDataL3DataTableCut_SteelGradeIndex;
        private System.Data.DataColumn coldsBloomDataL3DataTableFinal_SteelGradeIndex;
        private System.Data.DataColumn coldsBloomDataL3DataTableLength;
        private System.Data.DataColumn coldsBloomDataL3DataTableWidth;
        private System.Data.DataColumn coldsBloomDataL3DataTableThickness;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Area;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Section_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Pile_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Layer_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Seq_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableCur_Bay_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableDestination;
        private System.Data.DataColumn coldsBloomDataL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsBloomDataL3DataTableProcess_Type;
        private System.Data.DataColumn coldsBloomDataL3DataTablePlan_Ord_ID;
        private System.Data.DataColumn coldsBloomDataL3DataTableProduce_Date;
        private System.Data.DataColumn coldsBloomDataL3DataTableFinish_Flag;
        private System.Data.DataColumn coldsBloomDataL3DataTableFinishedTime;
        private System.Data.DataColumn coldsBloomDataL3DataTableBloom_Count;
        private System.Data.DataColumn coldsBloomDataL3DataTableCal_Weight;
        private System.Data.DataColumn coldsBloomDataL3DataTableRight_Count;
        private System.Data.DataColumn coldsBloomDataL3DataTableRight_Weight;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Count;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Count1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Weight1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Reason1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Count2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Weight2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Reason2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Count3;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Weight3;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaster_Reason3;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Count;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Weight;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Count1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Weight1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Reason1;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Count2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Weight2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Reason2;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Count3;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Weight3;
        private System.Data.DataColumn coldsBloomDataL3DataTableWrong_Reason3;
        private System.Data.DataColumn coldsBloomDataL3DataTableSufaceDefactDes;
        private System.Data.DataColumn coldsBloomDataL3DataTableReason;
        private AppSvrHMI.L3Command cmdBloomData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsReason;
        private System.Data.DataTable schemadsReason;
        private System.Data.DataColumn coldsReasonL3DataTableCode;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsBloomDataL3DataTableWaitCheckFlag;
        private System.Windows.Forms.BindingSource bsReasonS3;
        private System.Windows.Forms.BindingSource bsReasonS2;
        private System.Windows.Forms.BindingSource bsReasonS1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxWrongWeight3;
        private System.Windows.Forms.TextBox tbxWrongWeight2;
        private System.Windows.Forms.TextBox tbxWrongWeight1;
        private System.Windows.Forms.CheckBox cbWaitCheck;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label75;
        private PxDataValid.PxTextBox tbxWrongCount3;
        private System.Windows.Forms.Label label66;
        private PxDataValid.PxTextBox tbxWrongCount2;
        private System.Windows.Forms.Label label57;
        private PxDataValid.PxTextBox tbxWrongCount1;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label tbxWrongCount;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label tbxWrongWeight;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label tbxRightCount;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label tbxRightWeight;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWasterReason1;
        private System.Windows.Forms.BindingSource bsWasterReason2;
        private System.Windows.Forms.BindingSource bsWasterReason3;
        private System.Windows.Forms.ComboBox cmbWasterReason3;
        private System.Windows.Forms.ComboBox cmbWasterReason2;
        private System.Windows.Forms.ComboBox cmbWasterReason1;
    }
}