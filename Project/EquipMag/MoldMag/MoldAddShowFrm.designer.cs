namespace EquipMag.MoldMag
{
    partial class MoldAddShowFrm 
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CmbUnitID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoldID = new System.Windows.Forms.MaskedTextBox();
            this.cmbBreakFaceMea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsMold = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadle = new System.Data.DataTable();
            this.coldsIronLadleL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableBreak_Face_Mea = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableFlowID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableCopper_ID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableInStallID = new System.Data.DataColumn();
            this.AcoldsMoldL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableUnitID = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).BeginInit();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(316, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(229, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(148, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.CmbUnitID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMoldID);
            this.tabPage1.Controls.Add(this.cmbBreakFaceMea);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(308, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结晶器信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CmbUnitID
            // 
            this.CmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbUnitID.FormattingEnabled = true;
            this.CmbUnitID.Items.AddRange(new object[] {
            "S63",
            "S64",
            "S65",
            "S67",
            "S66"});
            this.CmbUnitID.Location = new System.Drawing.Point(112, 22);
            this.CmbUnitID.Name = "CmbUnitID";
            this.CmbUnitID.Size = new System.Drawing.Size(121, 20);
            this.CmbUnitID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "铸机号:";
            // 
            // txtMoldID
            // 
            this.txtMoldID.Location = new System.Drawing.Point(112, 93);
            this.txtMoldID.Name = "txtMoldID";
            this.txtMoldID.Size = new System.Drawing.Size(121, 21);
            this.txtMoldID.TabIndex = 3;
            // 
            // cmbBreakFaceMea
            // 
            this.cmbBreakFaceMea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreakFaceMea.FormattingEnabled = true;
            this.cmbBreakFaceMea.Items.AddRange(new object[] {
            "8",
            "9",
            "09",
            "12",
            "16",
            "18"});
            this.cmbBreakFaceMea.Location = new System.Drawing.Point(112, 57);
            this.cmbBreakFaceMea.Name = "cmbBreakFaceMea";
            this.cmbBreakFaceMea.Size = new System.Drawing.Size(121, 20);
            this.cmbBreakFaceMea.TabIndex = 2;
            this.cmbBreakFaceMea.SelectedIndexChanged += new System.EventHandler(this.cmbBreakFaceMea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "断面尺寸[m]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结晶器号:";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dsMold
            // 
            this.dsMold.AutoLoad = true;
            this.dsMold.AutoSubscribe = false;
            this.dsMold.DataSetName = "L3DataSet";
            this.dsMold.DeleteMethod = "";
            this.dsMold.InsertMethod = "";
            this.dsMold.L3DataAdapter = this.Adapter;
            this.dsMold.LoadEvent = "";
            this.dsMold.LoadTrigger = null;
            this.dsMold.RefreshValve = 1000;
            this.dsMold.SourceCommand = null;
            this.dsMold.SourceCondition = "1=2";
            this.dsMold.SourceMethod = "";
            this.dsMold.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMold.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMold.SubscribeTarget = "";
            this.dsMold.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadle});
            this.dsMold.UpdateEvent = "";
            this.dsMold.UpdateMethod = "";
            this.dsMold.UpdateTrigger = null;
            // 
            // schemadsIronLadle
            // 
            this.schemadsIronLadle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleL3DataTableStatus,
            this.coldsIronLadleL3DataTableMoldID,
            this.coldsIronLadleL3DataTableBreak_Face_Mea,
            this.coldsIronLadleL3DataTableCast_ID,
            this.coldsIronLadleL3DataTableFlowID,
            this.coldsIronLadleL3DataTableCopper_Fac,
            this.coldsIronLadleL3DataTableCopper_ID,
            this.coldsIronLadleL3DataTableInStallID,
            this.AcoldsMoldL3DataTableUnitID});
            this.schemadsIronLadle.TableName = "L3DataTable";
            // 
            // coldsIronLadleL3DataTableStatus
            // 
            this.coldsIronLadleL3DataTableStatus.Caption = "Status";
            this.coldsIronLadleL3DataTableStatus.ColumnName = "Status";
            this.coldsIronLadleL3DataTableStatus.Namespace = "";
            // 
            // coldsIronLadleL3DataTableMoldID
            // 
            this.coldsIronLadleL3DataTableMoldID.Caption = "MoldID";
            this.coldsIronLadleL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsIronLadleL3DataTableMoldID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableBreak_Face_Mea
            // 
            this.coldsIronLadleL3DataTableBreak_Face_Mea.Caption = "Break_Face_Mea";
            this.coldsIronLadleL3DataTableBreak_Face_Mea.ColumnName = "Break_Face_Mea";
            this.coldsIronLadleL3DataTableBreak_Face_Mea.DataType = typeof(double);
            this.coldsIronLadleL3DataTableBreak_Face_Mea.Namespace = "";
            // 
            // coldsIronLadleL3DataTableCast_ID
            // 
            this.coldsIronLadleL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsIronLadleL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsIronLadleL3DataTableCast_ID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableFlowID
            // 
            this.coldsIronLadleL3DataTableFlowID.Caption = "FlowID";
            this.coldsIronLadleL3DataTableFlowID.ColumnName = "FlowID";
            this.coldsIronLadleL3DataTableFlowID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableCopper_Fac
            // 
            this.coldsIronLadleL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsIronLadleL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsIronLadleL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsIronLadleL3DataTableCopper_ID
            // 
            this.coldsIronLadleL3DataTableCopper_ID.Caption = "Copper_ID";
            this.coldsIronLadleL3DataTableCopper_ID.ColumnName = "Copper_ID";
            this.coldsIronLadleL3DataTableCopper_ID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableInStallID
            // 
            this.coldsIronLadleL3DataTableInStallID.Caption = "InStallID";
            this.coldsIronLadleL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsIronLadleL3DataTableInStallID.Namespace = "";
            // 
            // AcoldsMoldL3DataTableUnitID
            // 
            this.AcoldsMoldL3DataTableUnitID.Caption = "UnitID";
            this.AcoldsMoldL3DataTableUnitID.ColumnName = "UnitID";
            this.AcoldsMoldL3DataTableUnitID.Namespace = "";
            // 
            // coldsMoldL3DataTableUnitID
            // 
            this.coldsMoldL3DataTableUnitID.Caption = "UnitID";
            this.coldsMoldL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsMoldL3DataTableUnitID.Namespace = "";
            // 
            // MoldAddShowFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(316, 213);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MoldAddShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结晶器新增";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsMold;
        private System.Data.DataTable schemadsIronLadle;
        private System.Data.DataColumn coldsIronLadleL3DataTableStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBreakFaceMea;
        private System.Windows.Forms.MaskedTextBox txtMoldID;
        private System.Data.DataColumn coldsIronLadleL3DataTableMoldID;
        private System.Data.DataColumn coldsIronLadleL3DataTableBreak_Face_Mea;
        private System.Data.DataColumn coldsIronLadleL3DataTableCast_ID;
        private System.Data.DataColumn coldsIronLadleL3DataTableFlowID;
        private System.Data.DataColumn coldsIronLadleL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsIronLadleL3DataTableCopper_ID;
        private System.Data.DataColumn coldsIronLadleL3DataTableInStallID;
        private System.Windows.Forms.ComboBox CmbUnitID;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn coldsMoldL3DataTableUnitID;
        private System.Data.DataColumn AcoldsMoldL3DataTableUnitID;
    }
}