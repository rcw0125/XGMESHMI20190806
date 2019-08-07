namespace PlanMag
{
    partial class WriteInTimeFrm
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
            this.bsData = new System.Windows.Forms.BindingSource(this.components);
            this.dsWriteTime = new AppSvrHMI.L3DataSet();
            this.schemadsData = new System.Data.DataTable();
            this.coldsDataL3DataTableAim_Time_BOFRepared = new System.Data.DataColumn();
            this.coldsDataL3DataTableAim_Time_BlowN2 = new System.Data.DataColumn();
            this.coldsDataL3DataTableHeatID = new System.Data.DataColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTime = new System.Windows.Forms.TabPage();
            this.txtBlown2Time = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.txtBOFReparedTime = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdWriteTime = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWriteTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsData
            // 
            this.bsData.DataMember = "L3DataTable";
            this.bsData.DataSource = this.dsWriteTime;
            // 
            // dsWriteTime
            // 
            this.dsWriteTime.DataSetName = "L3DataSet";
            this.dsWriteTime.DeleteMethod = null;
            this.dsWriteTime.InsertMethod = null;
            this.dsWriteTime.L3DataAdapter = null;
            this.dsWriteTime.LoadEvent = "Click";
            this.dsWriteTime.LoadTrigger = null;
            this.dsWriteTime.RefreshValve = 1000;
            this.dsWriteTime.SourceCommand = null;
            this.dsWriteTime.SourceCondition = "";
            this.dsWriteTime.SourceMethod = "";
            this.dsWriteTime.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsWriteTime.SourceURI = "";
            this.dsWriteTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsData});
            this.dsWriteTime.UpdateEvent = "Click";
            this.dsWriteTime.UpdateMethod = null;
            this.dsWriteTime.UpdateTrigger = null;
            // 
            // schemadsData
            // 
            this.schemadsData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDataL3DataTableAim_Time_BOFRepared,
            this.coldsDataL3DataTableAim_Time_BlowN2,
            this.coldsDataL3DataTableHeatID});
            this.schemadsData.TableName = "L3DataTable";
            // 
            // coldsDataL3DataTableAim_Time_BOFRepared
            // 
            this.coldsDataL3DataTableAim_Time_BOFRepared.Caption = "Aim_Time_BOFRepared";
            this.coldsDataL3DataTableAim_Time_BOFRepared.ColumnName = "Aim_Time_BOFRepared";
            this.coldsDataL3DataTableAim_Time_BOFRepared.DataType = typeof(double);
            this.coldsDataL3DataTableAim_Time_BOFRepared.Namespace = "";
            // 
            // coldsDataL3DataTableAim_Time_BlowN2
            // 
            this.coldsDataL3DataTableAim_Time_BlowN2.Caption = "Aim_Time_BlowN2";
            this.coldsDataL3DataTableAim_Time_BlowN2.ColumnName = "Aim_Time_BlowN2";
            this.coldsDataL3DataTableAim_Time_BlowN2.DataType = typeof(double);
            this.coldsDataL3DataTableAim_Time_BlowN2.Namespace = "";
            // 
            // coldsDataL3DataTableHeatID
            // 
            this.coldsDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsDataL3DataTableHeatID.Namespace = "";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTime);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 142);
            this.tabControl1.TabIndex = 146;
            // 
            // tpTime
            // 
            this.tpTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTime.Controls.Add(this.txtBlown2Time);
            this.tpTime.Controls.Add(this.pxTextBox1);
            this.tpTime.Controls.Add(this.txtBOFReparedTime);
            this.tpTime.Controls.Add(this.label1);
            this.tpTime.Controls.Add(this.label3);
            this.tpTime.Controls.Add(this.label7);
            this.tpTime.Location = new System.Drawing.Point(4, 21);
            this.tpTime.Name = "tpTime";
            this.tpTime.Padding = new System.Windows.Forms.Padding(3);
            this.tpTime.Size = new System.Drawing.Size(348, 117);
            this.tpTime.TabIndex = 0;
            this.tpTime.Text = "作业完毕后要求时间";
            this.tpTime.UseVisualStyleBackColor = true;
            // 
            // txtBlown2Time
            // 
            this.txtBlown2Time.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Aim_Time_BlowN2", true));
            this.txtBlown2Time.EnableNull = false;
            this.txtBlown2Time.ErropPr = this.errorProvider1;
            this.txtBlown2Time.Length = 0;
            this.txtBlown2Time.Location = new System.Drawing.Point(144, 81);
            this.txtBlown2Time.Max = 0;
            this.txtBlown2Time.MaxStrLength = 0;
            this.txtBlown2Time.Min = -0.99;
            this.txtBlown2Time.MinStrLength = 0;
            this.txtBlown2Time.Name = "txtBlown2Time";
            this.txtBlown2Time.Precision = 0;
            this.txtBlown2Time.Size = new System.Drawing.Size(182, 21);
            this.txtBlown2Time.TabIndex = 5;
            this.txtBlown2Time.ToolTipValid = this.toolTip1;
            this.txtBlown2Time.ValidEable = true;
            this.txtBlown2Time.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "HeatID", true));
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(144, 15);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.ReadOnly = true;
            this.pxTextBox1.Size = new System.Drawing.Size(182, 21);
            this.pxTextBox1.TabIndex = 5;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtBOFReparedTime
            // 
            this.txtBOFReparedTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsData, "Aim_Time_BOFRepared", true));
            this.txtBOFReparedTime.EnableNull = false;
            this.txtBOFReparedTime.ErropPr = this.errorProvider1;
            this.txtBOFReparedTime.Length = 0;
            this.txtBOFReparedTime.Location = new System.Drawing.Point(144, 48);
            this.txtBOFReparedTime.Max = 0;
            this.txtBOFReparedTime.MaxStrLength = 0;
            this.txtBOFReparedTime.Min = -0.99;
            this.txtBOFReparedTime.MinStrLength = 0;
            this.txtBOFReparedTime.Name = "txtBOFReparedTime";
            this.txtBOFReparedTime.Precision = 0;
            this.txtBOFReparedTime.Size = new System.Drawing.Size(182, 21);
            this.txtBOFReparedTime.TabIndex = 5;
            this.txtBOFReparedTime.ToolTipValid = this.toolTip1;
            this.txtBOFReparedTime.ValidEable = true;
            this.txtBOFReparedTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "溅渣补炉时间[min]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "炉号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "补炉时间[min]:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(166, 159);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 148;
            this.btnChange.Text = "录入";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(247, 159);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 148;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdWriteTime
            // 
            this.cmdWriteTime.Adapter = this.Adapter;
            this.cmdWriteTime.MergeReturnTarget = false;
            this.cmdWriteTime.Method = "LogBOFNunProcessTime";
            this.cmdWriteTime.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdWriteTime.Parameters.Add(this.l3CommandParameter2);
            this.cmdWriteTime.ReturnTarget = null;
            this.cmdWriteTime.ReturnTargetProperty = null;
            this.cmdWriteTime.Trigger = null;
            this.cmdWriteTime.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsWriteTime;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsWriteTime;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // WriteInTimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 207);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "WriteInTimeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "转炉非作业时间人工录入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WriteInTimeFrm_FormClosing);
            this.Load += new System.EventHandler(this.WriteInTimeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWriteTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpTime.ResumeLayout(false);
            this.tpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsData;
        private AppSvrHMI.L3DataSet dsWriteTime;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpTime;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReturn;
        private PxDataValid.PxTextBox txtBlown2Time;
        private PxDataValid.PxTextBox txtBOFReparedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsData;
        private System.Data.DataColumn coldsDataL3DataTableAim_Time_BOFRepared;
        private System.Data.DataColumn coldsDataL3DataTableAim_Time_BlowN2;
        private System.Data.DataColumn coldsDataL3DataTableHeatID;
        private PxDataValid.PxTextBox pxTextBox1;
        private AppSvrHMI.L3Command cmdWriteTime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}