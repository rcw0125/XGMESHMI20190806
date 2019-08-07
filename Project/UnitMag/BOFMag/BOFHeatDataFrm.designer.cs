namespace UnitMag.BOFMag
{
    partial class BOFHeatDataFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbHeatID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdBOFBlowStart = new AppSvrHMI.L3Command(this.components);
            this.paramBlowStart1 = new AppSvrHMI.L3CommandParameter();
            this.rdBOFMainBlow = new System.Windows.Forms.RadioButton();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dtBOFBlowStart = new System.Windows.Forms.DateTimePicker();
            this.btnBOFBlowStart = new System.Windows.Forms.Button();
            this.paramSetOxygen = new AppSvrHMI.L3CommandParameter();
            this.paramSetTemp = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBOFBlowStart = new System.Windows.Forms.TabPage();
            this.btnBOFBlowStartCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBOFReBlow = new System.Windows.Forms.RadioButton();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBOFBlowStart.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
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
            this.panel3.Controls.Add(this.lbHeatID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(407, 29);
            this.panel3.TabIndex = 84;
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeatID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHeatID.Location = new System.Drawing.Point(55, 9);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(61, 12);
            this.lbHeatID.TabIndex = 73;
            this.lbHeatID.Text = "XXXXXXXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号：";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(98, 29);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(164, 21);
            this.textBox7.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 78;
            this.label7.Text = "温度:";
            // 
            // cmdBOFBlowStart
            // 
            this.cmdBOFBlowStart.Adapter = this.Adapter;
            this.cmdBOFBlowStart.MergeReturnTarget = false;
            this.cmdBOFBlowStart.Method = "StartBlowing";
            this.cmdBOFBlowStart.Object = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.cmdBOFBlowStart.Parameters.Add(this.paramBlowStart1);
            this.cmdBOFBlowStart.Parameters.Add(this.l3CommandParameter2);
            this.cmdBOFBlowStart.ReturnTarget = null;
            this.cmdBOFBlowStart.ReturnTargetProperty = null;
            this.cmdBOFBlowStart.Trigger = null;
            this.cmdBOFBlowStart.TriggerEvent = "Click";
            // 
            // paramBlowStart1
            // 
            this.paramBlowStart1.AcceptAfterExecuted = false;
            this.paramBlowStart1.ConstantValue = null;
            this.paramBlowStart1.MergeTarget = false;
            this.paramBlowStart1.SourceFilter = null;
            this.paramBlowStart1.SourceObject = this.rdBOFMainBlow;
            this.paramBlowStart1.SourceProperty = "Checked";
            this.paramBlowStart1.TargetObject = null;
            this.paramBlowStart1.TargetProperty = null;
            // 
            // rdBOFMainBlow
            // 
            this.rdBOFMainBlow.AutoSize = true;
            this.rdBOFMainBlow.Checked = true;
            this.rdBOFMainBlow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBOFMainBlow.Location = new System.Drawing.Point(75, 30);
            this.rdBOFMainBlow.Name = "rdBOFMainBlow";
            this.rdBOFMainBlow.Size = new System.Drawing.Size(70, 25);
            this.rdBOFMainBlow.TabIndex = 0;
            this.rdBOFMainBlow.TabStop = true;
            this.rdBOFMainBlow.Text = "主吹";
            this.rdBOFMainBlow.UseVisualStyleBackColor = true;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dtBOFBlowStart;
            this.l3CommandParameter2.SourceProperty = "Value";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dtBOFBlowStart
            // 
            this.dtBOFBlowStart.CalendarFont = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtBOFBlowStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBOFBlowStart.Location = new System.Drawing.Point(14, 22);
            this.dtBOFBlowStart.Name = "dtBOFBlowStart";
            this.dtBOFBlowStart.ShowUpDown = true;
            this.dtBOFBlowStart.Size = new System.Drawing.Size(132, 21);
            this.dtBOFBlowStart.TabIndex = 0;
            // 
            // btnBOFBlowStart
            // 
            this.btnBOFBlowStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBOFBlowStart.Location = new System.Drawing.Point(164, 138);
            this.btnBOFBlowStart.Name = "btnBOFBlowStart";
            this.btnBOFBlowStart.Size = new System.Drawing.Size(75, 23);
            this.btnBOFBlowStart.TabIndex = 88;
            this.btnBOFBlowStart.Text = "吹炼开始";
            this.btnBOFBlowStart.UseVisualStyleBackColor = true;
            this.btnBOFBlowStart.Click += new System.EventHandler(this.btnBOFBlowStart_Click);
            // 
            // paramSetOxygen
            // 
            this.paramSetOxygen.AcceptAfterExecuted = false;
            this.paramSetOxygen.ConstantValue = null;
            this.paramSetOxygen.MergeTarget = false;
            this.paramSetOxygen.SourceFilter = null;
            this.paramSetOxygen.SourceObject = null;
            this.paramSetOxygen.SourceProperty = null;
            this.paramSetOxygen.TargetObject = null;
            this.paramSetOxygen.TargetProperty = null;
            // 
            // paramSetTemp
            // 
            this.paramSetTemp.AcceptAfterExecuted = false;
            this.paramSetTemp.ConstantValue = null;
            this.paramSetTemp.MergeTarget = false;
            this.paramSetTemp.SourceFilter = null;
            this.paramSetTemp.SourceObject = null;
            this.paramSetTemp.SourceProperty = null;
            this.paramSetTemp.TargetObject = null;
            this.paramSetTemp.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 29);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(407, 232);
            this.hmiRootPanel1.TabIndex = 85;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBOFBlowStart);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(407, 232);
            this.tabCtrlMain.TabIndex = 90;
            // 
            // tabBOFBlowStart
            // 
            this.tabBOFBlowStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBOFBlowStart.Controls.Add(this.btnBOFBlowStartCancel);
            this.tabBOFBlowStart.Controls.Add(this.btnBOFBlowStart);
            this.tabBOFBlowStart.Controls.Add(this.groupBox2);
            this.tabBOFBlowStart.Controls.Add(this.rdBOFReBlow);
            this.tabBOFBlowStart.Controls.Add(this.rdBOFMainBlow);
            this.tabBOFBlowStart.Location = new System.Drawing.Point(4, 21);
            this.tabBOFBlowStart.Name = "tabBOFBlowStart";
            this.tabBOFBlowStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabBOFBlowStart.Size = new System.Drawing.Size(399, 207);
            this.tabBOFBlowStart.TabIndex = 5;
            this.tabBOFBlowStart.Text = "吹炼开始";
            this.tabBOFBlowStart.UseVisualStyleBackColor = true;
            // 
            // btnBOFBlowStartCancel
            // 
            this.btnBOFBlowStartCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBOFBlowStartCancel.Location = new System.Drawing.Point(245, 138);
            this.btnBOFBlowStartCancel.Name = "btnBOFBlowStartCancel";
            this.btnBOFBlowStartCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBOFBlowStartCancel.TabIndex = 89;
            this.btnBOFBlowStartCancel.Text = "取消";
            this.btnBOFBlowStartCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtBOFBlowStart);
            this.groupBox2.Location = new System.Drawing.Point(161, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "开吹时间";
            // 
            // rdBOFReBlow
            // 
            this.rdBOFReBlow.AutoSize = true;
            this.rdBOFReBlow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdBOFReBlow.Location = new System.Drawing.Point(75, 72);
            this.rdBOFReBlow.Name = "rdBOFReBlow";
            this.rdBOFReBlow.Size = new System.Drawing.Size(70, 25);
            this.rdBOFReBlow.TabIndex = 0;
            this.rdBOFReBlow.Text = "补吹";
            this.rdBOFReBlow.UseVisualStyleBackColor = true;
            // 
            // dsError
            // 
            this.dsError.AutoSubscribe = true;
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
            // BOFHeatDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 261);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BOFHeatDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉次数据收集";
            this.Load += new System.EventHandler(this.BOFHeatDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBOFBlowStart.ResumeLayout(false);
            this.tabBOFBlowStart.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbHeatID;
        private AppSvrHMI.L3Command cmdBOFBlowStart;
        private AppSvrHMI.L3CommandParameter paramBlowStart1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter paramSetOxygen;
        private AppSvrHMI.L3CommandParameter paramSetTemp;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBOFBlowStart;
        private System.Windows.Forms.Button btnBOFBlowStartCancel;
        private System.Windows.Forms.Button btnBOFBlowStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtBOFBlowStart;
        private System.Windows.Forms.RadioButton rdBOFReBlow;
        private System.Windows.Forms.RadioButton rdBOFMainBlow;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
    }
}