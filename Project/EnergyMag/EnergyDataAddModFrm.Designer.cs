namespace EnergyMag
{
    partial class EnergyDataAddModFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMainL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsMainL3DataTableTagName = new System.Data.DataColumn();
            this.coldsMainL3DataTableTagValue = new System.Data.DataColumn();
            this.coldsMainL3DataTableDayValue = new System.Data.DataColumn();
            this.coldsMainL3DataTableMonthValue = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableModifyTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTagName = new System.Windows.Forms.ComboBox();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableCode = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTime = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtTagValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbTagName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MonthValue", true));
            this.textBox3.Location = new System.Drawing.Point(126, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(140, 21);
            this.textBox3.TabIndex = 5;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = false;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\EnergyMag\\CEnergyConsumption";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableObjectID,
            this.coldsMainL3DataTableProductionDate,
            this.coldsMainL3DataTableTagName,
            this.coldsMainL3DataTableTagValue,
            this.coldsMainL3DataTableDayValue,
            this.coldsMainL3DataTableMonthValue,
            this.coldsMainL3DataTableCreateTime,
            this.coldsMainL3DataTableModifyTime,
            this.coldsMainL3DataTableOperator});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableObjectID
            // 
            this.coldsMainL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMainL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMainL3DataTableObjectID.Namespace = "";
            // 
            // coldsMainL3DataTableProductionDate
            // 
            this.coldsMainL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsMainL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsMainL3DataTableProductionDate.Namespace = "";
            // 
            // coldsMainL3DataTableTagName
            // 
            this.coldsMainL3DataTableTagName.Caption = "TagName";
            this.coldsMainL3DataTableTagName.ColumnName = "TagName";
            this.coldsMainL3DataTableTagName.Namespace = "";
            // 
            // coldsMainL3DataTableTagValue
            // 
            this.coldsMainL3DataTableTagValue.Caption = "TagValue";
            this.coldsMainL3DataTableTagValue.ColumnName = "TagValue";
            this.coldsMainL3DataTableTagValue.DataType = typeof(double);
            this.coldsMainL3DataTableTagValue.Namespace = "";
            // 
            // coldsMainL3DataTableDayValue
            // 
            this.coldsMainL3DataTableDayValue.Caption = "DayValue";
            this.coldsMainL3DataTableDayValue.ColumnName = "DayValue";
            this.coldsMainL3DataTableDayValue.DataType = typeof(double);
            this.coldsMainL3DataTableDayValue.Namespace = "";
            // 
            // coldsMainL3DataTableMonthValue
            // 
            this.coldsMainL3DataTableMonthValue.Caption = "MonthValue";
            this.coldsMainL3DataTableMonthValue.ColumnName = "MonthValue";
            this.coldsMainL3DataTableMonthValue.DataType = typeof(double);
            this.coldsMainL3DataTableMonthValue.Namespace = "";
            // 
            // coldsMainL3DataTableCreateTime
            // 
            this.coldsMainL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsMainL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsMainL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCreateTime.Namespace = "";
            // 
            // coldsMainL3DataTableModifyTime
            // 
            this.coldsMainL3DataTableModifyTime.Caption = "ModifyTime";
            this.coldsMainL3DataTableModifyTime.ColumnName = "ModifyTime";
            this.coldsMainL3DataTableModifyTime.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableModifyTime.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "DayValue", true));
            this.textBox2.Location = new System.Drawing.Point(126, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(140, 21);
            this.textBox2.TabIndex = 5;
            // 
            // txtTagValue
            // 
            this.txtTagValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TagValue", true));
            this.txtTagValue.Location = new System.Drawing.Point(126, 85);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.Size = new System.Drawing.Size(140, 21);
            this.txtTagValue.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "月累消耗:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "当日消耗:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "表 数 据:";
            // 
            // cmbTagName
            // 
            this.cmbTagName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TagName", true));
            this.cmbTagName.DataSource = this.dsCode;
            this.cmbTagName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTagName.DropDownHeight = 200;
            this.cmbTagName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTagName.DropDownWidth = 200;
            this.cmbTagName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTagName.FormattingEnabled = true;
            this.cmbTagName.IntegralHeight = false;
            this.cmbTagName.Location = new System.Drawing.Point(126, 59);
            this.cmbTagName.Name = "cmbTagName";
            this.cmbTagName.Size = new System.Drawing.Size(140, 20);
            this.cmbTagName.TabIndex = 1;
            this.cmbTagName.ValueMember = "L3DataTable.Code";
            // 
            // dsCode
            // 
            this.dsCode.AutoLoad = true;
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = "";
            this.dsCode.InsertMethod = "";
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "Code_Group = \'EnergyConsumption\' order by Code";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCode.SubscribeTarget = null;
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsCode.UpdateEvent = "";
            this.dsCode.UpdateMethod = "";
            this.dsCode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableCode,
            this.coldsEnergyDataL3DataTableCode_Des,
            this.coldsEnergyDataL3DataTableCode_Group_Des});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableCode
            // 
            this.coldsEnergyDataL3DataTableCode.Caption = "Code";
            this.coldsEnergyDataL3DataTableCode.ColumnName = "Code";
            this.coldsEnergyDataL3DataTableCode.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableCode_Des
            // 
            this.coldsEnergyDataL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsEnergyDataL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsEnergyDataL3DataTableCode_Des.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableCode_Group_Des
            // 
            this.coldsEnergyDataL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsEnergyDataL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsEnergyDataL3DataTableCode_Group_Des.Namespace = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "标 签 名:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日    期:";
            // 
            // dtTime
            // 
            this.dtTime.CustomFormat = "yyyyMMdd";
            this.dtTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "ProductionDate", true));
            this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTime.Location = new System.Drawing.Point(126, 32);
            this.dtTime.Name = "dtTime";
            this.dtTime.Size = new System.Drawing.Size(140, 21);
            this.dtTime.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(232, 181);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定(&O)";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // EnergyDataAddModFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 232);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EnergyDataAddModFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "能源数据操作";
            this.Load += new System.EventHandler(this.EnergyDataAddModFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTagName;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableCode;
        private System.Data.DataColumn coldsEnergyDataL3DataTableCode_Des;
        private System.Data.DataColumn coldsEnergyDataL3DataTableCode_Group_Des;
        private System.Windows.Forms.Label label4;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataColumn coldsMainL3DataTableProductionDate;
        private System.Data.DataColumn coldsMainL3DataTableTagName;
        private System.Data.DataColumn coldsMainL3DataTableTagValue;
        private System.Data.DataColumn coldsMainL3DataTableDayValue;
        private System.Data.DataColumn coldsMainL3DataTableMonthValue;
        private System.Data.DataColumn coldsMainL3DataTableCreateTime;
        private System.Data.DataColumn coldsMainL3DataTableModifyTime;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTagValue;
    }
}