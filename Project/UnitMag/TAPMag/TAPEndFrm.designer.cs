namespace UnitMag.TAPMag
{
    partial class TAPEndFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsProcData = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcData = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsProcData = new System.Data.DataTable();
            this.coldsProcDataL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableTemp_Before_BlowAr = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableO2_Before_BlowAr = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableTemp_BlownAr = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableO2_BlownAr = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableBlow_Mode = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableTune_Flag = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableBlowAr_Time = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsProcDataL3DataTableEnd_Time = new System.Data.DataColumn();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHeatID = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelProc = new System.Windows.Forms.Panel();
            this.txtBlowTime = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtO2AfterBlow = new PxDataValid.PxTextBox();
            this.txtTempAfterBlow = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.rdAdjustTemp = new System.Windows.Forms.RadioButton();
            this.rdNotAdjustTemp = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdBottomBlow = new System.Windows.Forms.RadioButton();
            this.rdTopBlow = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvElements = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsElements = new AppSvrHMI.L3DataSet();
            this.schemadsElements = new System.Data.DataTable();
            this.coldsElementsL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsElementsL3DataTableElement = new System.Data.DataColumn();
            this.coldsElementsL3DataTableWeight = new System.Data.DataColumn();
            this.coldsElementsL3DataTableLength = new System.Data.DataColumn();
            this.coldsElementsL3DataTableType = new System.Data.DataColumn();
            this.cmdFeedElements = new AppSvrHMI.L3Command(this.components);
            this.paramElements = new AppSvrHMI.L3CommandParameter();
            this.cmdStopProc = new AppSvrHMI.L3Command(this.components);
            this.paramProcData = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElements)).BeginInit();
            this.SuspendLayout();
            // 
            // bsProcData
            // 
            this.bsProcData.DataMember = "L3DataTable";
            this.bsProcData.DataSource = this.dsProcData;
            // 
            // dsProcData
            // 
            this.dsProcData.DataSetName = "L3DataSet";
            this.dsProcData.DeleteMethod = null;
            this.dsProcData.InsertMethod = null;
            this.dsProcData.L3DataAdapter = this.Adapter;
            this.dsProcData.LoadEvent = "Click";
            this.dsProcData.LoadTrigger = null;
            this.dsProcData.RefreshValve = 1000;
            this.dsProcData.SourceCommand = null;
            this.dsProcData.SourceCondition = "HeatID = \'{HeatID}\'";
            this.dsProcData.SourceMethod = "";
            this.dsProcData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcData.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Process_Data";
            this.dsProcData.SubscribeTarget = null;
            this.dsProcData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcData});
            this.dsProcData.UpdateEvent = "Click";
            this.dsProcData.UpdateMethod = null;
            this.dsProcData.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsProcData
            // 
            this.schemadsProcData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcDataL3DataTableHeatID,
            this.coldsProcDataL3DataTableTemp_Before_BlowAr,
            this.coldsProcDataL3DataTableO2_Before_BlowAr,
            this.coldsProcDataL3DataTableTemp_BlownAr,
            this.coldsProcDataL3DataTableO2_BlownAr,
            this.coldsProcDataL3DataTableBlow_Mode,
            this.coldsProcDataL3DataTableTune_Flag,
            this.coldsProcDataL3DataTableBlowAr_Time,
            this.coldsProcDataL3DataTableStart_Time,
            this.coldsProcDataL3DataTableEnd_Time});
            this.schemadsProcData.TableName = "L3DataTable";
            // 
            // coldsProcDataL3DataTableHeatID
            // 
            this.coldsProcDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcDataL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcDataL3DataTableTemp_Before_BlowAr
            // 
            this.coldsProcDataL3DataTableTemp_Before_BlowAr.Caption = "Temp_Before_BlowAr";
            this.coldsProcDataL3DataTableTemp_Before_BlowAr.ColumnName = "Temp_Before_BlowAr";
            this.coldsProcDataL3DataTableTemp_Before_BlowAr.DataType = typeof(int);
            this.coldsProcDataL3DataTableTemp_Before_BlowAr.Namespace = "";
            // 
            // coldsProcDataL3DataTableO2_Before_BlowAr
            // 
            this.coldsProcDataL3DataTableO2_Before_BlowAr.Caption = "O2_Before_BlowAr";
            this.coldsProcDataL3DataTableO2_Before_BlowAr.ColumnName = "O2_Before_BlowAr";
            this.coldsProcDataL3DataTableO2_Before_BlowAr.DataType = typeof(float);
            this.coldsProcDataL3DataTableO2_Before_BlowAr.Namespace = "";
            // 
            // coldsProcDataL3DataTableTemp_BlownAr
            // 
            this.coldsProcDataL3DataTableTemp_BlownAr.Caption = "Temp_BlownAr";
            this.coldsProcDataL3DataTableTemp_BlownAr.ColumnName = "Temp_BlownAr";
            this.coldsProcDataL3DataTableTemp_BlownAr.DataType = typeof(int);
            this.coldsProcDataL3DataTableTemp_BlownAr.Namespace = "";
            // 
            // coldsProcDataL3DataTableO2_BlownAr
            // 
            this.coldsProcDataL3DataTableO2_BlownAr.Caption = "O2_BlownAr";
            this.coldsProcDataL3DataTableO2_BlownAr.ColumnName = "O2_BlownAr";
            this.coldsProcDataL3DataTableO2_BlownAr.DataType = typeof(float);
            this.coldsProcDataL3DataTableO2_BlownAr.Namespace = "";
            // 
            // coldsProcDataL3DataTableBlow_Mode
            // 
            this.coldsProcDataL3DataTableBlow_Mode.Caption = "Blow_Mode";
            this.coldsProcDataL3DataTableBlow_Mode.ColumnName = "Blow_Mode";
            this.coldsProcDataL3DataTableBlow_Mode.DataType = typeof(short);
            this.coldsProcDataL3DataTableBlow_Mode.Namespace = "";
            // 
            // coldsProcDataL3DataTableTune_Flag
            // 
            this.coldsProcDataL3DataTableTune_Flag.Caption = "Tune_Flag";
            this.coldsProcDataL3DataTableTune_Flag.ColumnName = "Tune_Flag";
            this.coldsProcDataL3DataTableTune_Flag.DataType = typeof(short);
            this.coldsProcDataL3DataTableTune_Flag.Namespace = "";
            // 
            // coldsProcDataL3DataTableBlowAr_Time
            // 
            this.coldsProcDataL3DataTableBlowAr_Time.Caption = "BlowAr_Time";
            this.coldsProcDataL3DataTableBlowAr_Time.ColumnName = "BlowAr_Time";
            this.coldsProcDataL3DataTableBlowAr_Time.DataType = typeof(int);
            this.coldsProcDataL3DataTableBlowAr_Time.Namespace = "";
            // 
            // coldsProcDataL3DataTableStart_Time
            // 
            this.coldsProcDataL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsProcDataL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsProcDataL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsProcDataL3DataTableStart_Time.Namespace = "";
            // 
            // coldsProcDataL3DataTableEnd_Time
            // 
            this.coldsProcDataL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsProcDataL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsProcDataL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsProcDataL3DataTableEnd_Time.Namespace = "";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.lbHeatID);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(598, 29);
            this.panel4.TabIndex = 144;
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeatID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHeatID.Location = new System.Drawing.Point(74, 9);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(61, 12);
            this.lbHeatID.TabIndex = 73;
            this.lbHeatID.Text = "XXXXXXXX";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(25, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 12);
            this.label21.TabIndex = 73;
            this.label21.Text = "炉号";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 247);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 39);
            this.flowLayoutPanel1.TabIndex = 146;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(520, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 150;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(439, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 149;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 218);
            this.tabControl1.TabIndex = 147;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelProc);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.hmiRootPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "作业数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelProc
            // 
            this.panelProc.Controls.Add(this.txtBlowTime);
            this.panelProc.Controls.Add(this.label4);
            this.panelProc.Controls.Add(this.txtO2AfterBlow);
            this.panelProc.Controls.Add(this.txtTempAfterBlow);
            this.panelProc.Controls.Add(this.label3);
            this.panelProc.Controls.Add(this.label2);
            this.panelProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProc.Location = new System.Drawing.Point(3, 3);
            this.panelProc.Name = "panelProc";
            this.panelProc.Size = new System.Drawing.Size(243, 117);
            this.panelProc.TabIndex = 203;
            // 
            // txtBlowTime
            // 
            this.txtBlowTime.EnableNull = false;
            this.txtBlowTime.ErropPr = this.errorProvider1;
            this.txtBlowTime.Length = 0;
            this.txtBlowTime.Location = new System.Drawing.Point(91, 83);
            this.txtBlowTime.Max = 0;
            this.txtBlowTime.MaxStrLength = 0;
            this.txtBlowTime.Min = -0.99;
            this.txtBlowTime.MinStrLength = 0;
            this.txtBlowTime.Name = "txtBlowTime";
            this.txtBlowTime.Precision = 0;
            this.txtBlowTime.Size = new System.Drawing.Size(126, 21);
            this.txtBlowTime.TabIndex = 2;
            this.txtBlowTime.ToolTipValid = this.toolTip1;
            this.txtBlowTime.ValidEable = true;
            this.txtBlowTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 206;
            this.label4.Text = "吹氩时间:";
            // 
            // txtO2AfterBlow
            // 
            this.txtO2AfterBlow.EnableNull = false;
            this.txtO2AfterBlow.ErropPr = this.errorProvider1;
            this.txtO2AfterBlow.Length = 0;
            this.txtO2AfterBlow.Location = new System.Drawing.Point(91, 54);
            this.txtO2AfterBlow.Max = 0;
            this.txtO2AfterBlow.MaxStrLength = 0;
            this.txtO2AfterBlow.Min = -0.99;
            this.txtO2AfterBlow.MinStrLength = 0;
            this.txtO2AfterBlow.Name = "txtO2AfterBlow";
            this.txtO2AfterBlow.Precision = 0;
            this.txtO2AfterBlow.Size = new System.Drawing.Size(126, 21);
            this.txtO2AfterBlow.TabIndex = 1;
            this.txtO2AfterBlow.ToolTipValid = this.toolTip1;
            this.txtO2AfterBlow.ValidEable = true;
            this.txtO2AfterBlow.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTempAfterBlow
            // 
            this.txtTempAfterBlow.EnableNull = false;
            this.txtTempAfterBlow.ErropPr = this.errorProvider1;
            this.txtTempAfterBlow.Length = 0;
            this.txtTempAfterBlow.Location = new System.Drawing.Point(91, 25);
            this.txtTempAfterBlow.Max = 0;
            this.txtTempAfterBlow.MaxStrLength = 0;
            this.txtTempAfterBlow.Min = -0.99;
            this.txtTempAfterBlow.MinStrLength = 0;
            this.txtTempAfterBlow.Name = "txtTempAfterBlow";
            this.txtTempAfterBlow.Precision = 0;
            this.txtTempAfterBlow.Size = new System.Drawing.Size(126, 21);
            this.txtTempAfterBlow.TabIndex = 0;
            this.txtTempAfterBlow.ToolTipValid = this.toolTip1;
            this.txtTempAfterBlow.ValidEable = true;
            this.txtTempAfterBlow.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 203;
            this.label3.Text = "氩后氧含量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 202;
            this.label2.Text = "氩后温度:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.rdAdjustTemp);
            this.panel5.Controls.Add(this.rdNotAdjustTemp);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 23);
            this.panel5.TabIndex = 202;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 196;
            this.label5.Text = "是否调温:";
            // 
            // rdAdjustTemp
            // 
            this.rdAdjustTemp.AutoSize = true;
            this.rdAdjustTemp.Location = new System.Drawing.Point(91, 0);
            this.rdAdjustTemp.Name = "rdAdjustTemp";
            this.rdAdjustTemp.Size = new System.Drawing.Size(35, 16);
            this.rdAdjustTemp.TabIndex = 0;
            this.rdAdjustTemp.TabStop = true;
            this.rdAdjustTemp.Text = "是";
            this.rdAdjustTemp.UseVisualStyleBackColor = true;
            // 
            // rdNotAdjustTemp
            // 
            this.rdNotAdjustTemp.AutoSize = true;
            this.rdNotAdjustTemp.Location = new System.Drawing.Point(155, 0);
            this.rdNotAdjustTemp.Name = "rdNotAdjustTemp";
            this.rdNotAdjustTemp.Size = new System.Drawing.Size(35, 16);
            this.rdNotAdjustTemp.TabIndex = 1;
            this.rdNotAdjustTemp.TabStop = true;
            this.rdNotAdjustTemp.Text = "否";
            this.rdNotAdjustTemp.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdBottomBlow);
            this.panel3.Controls.Add(this.rdTopBlow);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 47);
            this.panel3.TabIndex = 192;
            // 
            // rdBottomBlow
            // 
            this.rdBottomBlow.AutoSize = true;
            this.rdBottomBlow.Location = new System.Drawing.Point(155, 8);
            this.rdBottomBlow.Name = "rdBottomBlow";
            this.rdBottomBlow.Size = new System.Drawing.Size(47, 16);
            this.rdBottomBlow.TabIndex = 1;
            this.rdBottomBlow.TabStop = true;
            this.rdBottomBlow.Text = "底吹";
            this.rdBottomBlow.UseVisualStyleBackColor = true;
            // 
            // rdTopBlow
            // 
            this.rdTopBlow.AutoSize = true;
            this.rdTopBlow.Location = new System.Drawing.Point(91, 8);
            this.rdTopBlow.Name = "rdTopBlow";
            this.rdTopBlow.Size = new System.Drawing.Size(47, 16);
            this.rdTopBlow.TabIndex = 0;
            this.rdTopBlow.TabStop = true;
            this.rdTopBlow.Text = "顶吹";
            this.rdTopBlow.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 199;
            this.label19.Text = "吹炼方式:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvElements);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.hmiRootPanel1.Location = new System.Drawing.Point(246, 3);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(341, 187);
            this.hmiRootPanel1.TabIndex = 191;
            // 
            // dvElements
            // 
            this.dvElements.AllowUserToDeleteRows = false;
            this.dvElements.AutoGenerateColumns = false;
            this.dvElements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvElements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvElements.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvElements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.heatIDDataGridViewTextBoxColumn,
            this.elementDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn});
            this.dvElements.DataMember = "L3DataTable";
            this.dvElements.DataSource = this.dsElements;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvElements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvElements.Location = new System.Drawing.Point(0, 0);
            this.dvElements.Name = "dvElements";
            this.dvElements.ReadOnly = true;
            this.dvElements.RowTemplate.Height = 23;
            this.dvElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvElements.Size = new System.Drawing.Size(341, 187);
            this.dvElements.TabIndex = 190;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Type";
            this.Column3.HeaderText = "加料性质";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Element";
            this.Column1.HeaderText = "辅料代码";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Weight";
            this.Column2.HeaderText = "加料量";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 66;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Length";
            this.Column4.HeaderText = "长度";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 54;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // elementDataGridViewTextBoxColumn
            // 
            this.elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn.HeaderText = "辅料代码";
            this.elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            this.elementDataGridViewTextBoxColumn.ReadOnly = true;
            this.elementDataGridViewTextBoxColumn.Width = 78;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "加料量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 66;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 54;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.HeaderText = "加料性质";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.typeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.typeDataGridViewCheckBoxColumn.Width = 59;
            // 
            // dsElements
            // 
            this.dsElements.DataSetName = "L3DataSet";
            this.dsElements.DeleteMethod = null;
            this.dsElements.InsertMethod = "";
            this.dsElements.L3DataAdapter = this.Adapter;
            this.dsElements.LoadEvent = "Click";
            this.dsElements.LoadTrigger = null;
            this.dsElements.RefreshValve = 1000;
            this.dsElements.SourceCommand = null;
            this.dsElements.SourceCondition = "HeatID = \'{HeatID}\'";
            this.dsElements.SourceMethod = "";
            this.dsElements.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsElements.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Addition_Data";
            this.dsElements.SubscribeTarget = null;
            this.dsElements.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsElements});
            this.dsElements.UpdateEvent = "Click";
            this.dsElements.UpdateMethod = null;
            this.dsElements.UpdateTrigger = null;
            // 
            // schemadsElements
            // 
            this.schemadsElements.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsElementsL3DataTableHeatID,
            this.coldsElementsL3DataTableElement,
            this.coldsElementsL3DataTableWeight,
            this.coldsElementsL3DataTableLength,
            this.coldsElementsL3DataTableType});
            this.schemadsElements.TableName = "L3DataTable";
            // 
            // coldsElementsL3DataTableHeatID
            // 
            this.coldsElementsL3DataTableHeatID.Caption = "HeatID";
            this.coldsElementsL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsElementsL3DataTableHeatID.Namespace = "";
            // 
            // coldsElementsL3DataTableElement
            // 
            this.coldsElementsL3DataTableElement.Caption = "Element";
            this.coldsElementsL3DataTableElement.ColumnName = "Element";
            this.coldsElementsL3DataTableElement.Namespace = "";
            // 
            // coldsElementsL3DataTableWeight
            // 
            this.coldsElementsL3DataTableWeight.Caption = "Weight";
            this.coldsElementsL3DataTableWeight.ColumnName = "Weight";
            this.coldsElementsL3DataTableWeight.DataType = typeof(float);
            this.coldsElementsL3DataTableWeight.Namespace = "";
            // 
            // coldsElementsL3DataTableLength
            // 
            this.coldsElementsL3DataTableLength.Caption = "Length";
            this.coldsElementsL3DataTableLength.ColumnName = "Length";
            this.coldsElementsL3DataTableLength.DataType = typeof(float);
            this.coldsElementsL3DataTableLength.Namespace = "";
            // 
            // coldsElementsL3DataTableType
            // 
            this.coldsElementsL3DataTableType.Caption = "Type";
            this.coldsElementsL3DataTableType.ColumnName = "Type";
            this.coldsElementsL3DataTableType.DataType = typeof(bool);
            this.coldsElementsL3DataTableType.Namespace = "";
            // 
            // cmdFeedElements
            // 
            this.cmdFeedElements.Adapter = this.Adapter;
            this.cmdFeedElements.MergeReturnTarget = false;
            this.cmdFeedElements.Method = "FeedElements";
            this.cmdFeedElements.Object = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\{TAPID}";
            this.cmdFeedElements.Parameters.Add(this.paramElements);
            this.cmdFeedElements.ReturnTarget = null;
            this.cmdFeedElements.ReturnTargetProperty = null;
            this.cmdFeedElements.Trigger = null;
            this.cmdFeedElements.TriggerEvent = "Click";
            // 
            // paramElements
            // 
            this.paramElements.AcceptAfterExecuted = false;
            this.paramElements.ConstantValue = null;
            this.paramElements.MergeTarget = false;
            this.paramElements.SourceFilter = null;
            this.paramElements.SourceObject = this.dsElements;
            this.paramElements.SourceProperty = "Added";
            this.paramElements.TargetObject = null;
            this.paramElements.TargetProperty = null;
            // 
            // cmdStopProc
            // 
            this.cmdStopProc.Adapter = this.Adapter;
            this.cmdStopProc.MergeReturnTarget = false;
            this.cmdStopProc.Method = "StopProcess";
            this.cmdStopProc.Object = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\{TAPID}";
            this.cmdStopProc.Parameters.Add(this.paramProcData);
            this.cmdStopProc.ReturnTarget = null;
            this.cmdStopProc.ReturnTargetProperty = null;
            this.cmdStopProc.Trigger = null;
            this.cmdStopProc.TriggerEvent = "Click";
            // 
            // paramProcData
            // 
            this.paramProcData.AcceptAfterExecuted = false;
            this.paramProcData.ConstantValue = null;
            this.paramProcData.MergeTarget = false;
            this.paramProcData.SourceFilter = null;
            this.paramProcData.SourceObject = this.dsProcData;
            this.paramProcData.SourceProperty = "";
            this.paramProcData.TargetObject = null;
            this.paramProcData.TargetProperty = null;
            // 
            // TAPEndFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(598, 286);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TAPEndFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉后处理结束";
            this.Load += new System.EventHandler(this.TAPEndFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelProc.ResumeLayout(false);
            this.panelProc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProcData;
        private AppSvrHMI.L3DataSet dsProcData;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelProc;
        private PxDataValid.PxTextBox txtBlowTime;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxTextBox txtO2AfterBlow;
        private PxDataValid.PxTextBox txtTempAfterBlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdAdjustTemp;
        private System.Windows.Forms.RadioButton rdNotAdjustTemp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdBottomBlow;
        private System.Windows.Forms.RadioButton rdTopBlow;
        private System.Windows.Forms.Label label19;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvElements;
        private System.Data.DataTable schemadsProcData;
        private System.Data.DataColumn coldsProcDataL3DataTableHeatID;
        private System.Data.DataColumn coldsProcDataL3DataTableTemp_Before_BlowAr;
        private System.Data.DataColumn coldsProcDataL3DataTableO2_Before_BlowAr;
        private System.Data.DataColumn coldsProcDataL3DataTableTemp_BlownAr;
        private System.Data.DataColumn coldsProcDataL3DataTableO2_BlownAr;
        private System.Data.DataColumn coldsProcDataL3DataTableBlow_Mode;
        private System.Data.DataColumn coldsProcDataL3DataTableTune_Flag;
        private System.Data.DataColumn coldsProcDataL3DataTableBlowAr_Time;
        private System.Data.DataColumn coldsProcDataL3DataTableStart_Time;
        private System.Data.DataColumn coldsProcDataL3DataTableEnd_Time;
        private AppSvrHMI.L3DataSet dsElements;
        private System.Data.DataTable schemadsElements;
        private System.Data.DataColumn coldsElementsL3DataTableHeatID;
        private System.Data.DataColumn coldsElementsL3DataTableElement;
        private System.Data.DataColumn coldsElementsL3DataTableWeight;
        private System.Data.DataColumn coldsElementsL3DataTableLength;
        private System.Data.DataColumn coldsElementsL3DataTableType;
        private System.Windows.Forms.Label lbHeatID;
        private AppSvrHMI.L3Command cmdFeedElements;
        private AppSvrHMI.L3CommandParameter paramElements;
        private AppSvrHMI.L3Command cmdStopProc;
        private AppSvrHMI.L3CommandParameter paramProcData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}