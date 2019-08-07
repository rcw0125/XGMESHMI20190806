namespace EquipMag.LadleMag
{
    partial class BOFTapStartFrm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbBOFID = new PxDataValid.PxComboBox();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.dtTapTime = new System.Windows.Forms.DateTimePicker();
            this.txtLadleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBOFTapStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpUnitID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpTapTime = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 190);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(383, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(217, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
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
            this.tabControl1.Size = new System.Drawing.Size(383, 190);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbBOFID);
            this.tabPage1.Controls.Add(this.txtHeatID);
            this.tabPage1.Controls.Add(this.dtTapTime);
            this.tabPage1.Controls.Add(this.txtLadleID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 165);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出钢信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBOFID
            // 
            this.cmbBOFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBOFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBOFID.DataSource = this.dsBOFID;
            this.cmbBOFID.DisplayMember = "L3DataTable.Code";
            this.cmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOFID.EnableNull = false;
            this.cmbBOFID.ErropPr = this.errorProvider1;
            this.cmbBOFID.FormattingEnabled = true;
            this.cmbBOFID.Location = new System.Drawing.Point(131, 56);
            this.cmbBOFID.Name = "cmbBOFID";
            this.cmbBOFID.Size = new System.Drawing.Size(179, 20);
            this.cmbBOFID.TabIndex = 5;
            this.cmbBOFID.ToolTipValid = this.toolTip1;
            this.cmbBOFID.ValidEable = true;
            this.cmbBOFID.ValueMember = "L3DataTable.Code";
            // 
            // dsBOFID
            // 
            this.dsBOFID.AutoSubscribe = false;
            this.dsBOFID.DataSetName = "L3DataSet";
            this.dsBOFID.DeleteMethod = null;
            this.dsBOFID.InsertMethod = null;
            this.dsBOFID.L3DataAdapter = this.Adapter;
            this.dsBOFID.LoadEvent = "Click";
            this.dsBOFID.LoadTrigger = null;
            this.dsBOFID.RefreshValve = 1000;
            this.dsBOFID.SourceCommand = null;
            this.dsBOFID.SourceCondition = "Code_Group = \'BOF\' and Code is not null order by Code";
            this.dsBOFID.SourceMethod = "";
            this.dsBOFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFID.SubscribeTarget = null;
            this.dsBOFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFID});
            this.dsBOFID.UpdateEvent = "Click";
            this.dsBOFID.UpdateMethod = null;
            this.dsBOFID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBOFID
            // 
            this.schemadsBOFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFIDL3DataTableCode,
            this.coldsBOFIDL3DataTableCode_Des});
            this.schemadsBOFID.TableName = "L3DataTable";
            // 
            // coldsBOFIDL3DataTableCode
            // 
            this.coldsBOFIDL3DataTableCode.Caption = "Code";
            this.coldsBOFIDL3DataTableCode.ColumnName = "Code";
            this.coldsBOFIDL3DataTableCode.Namespace = "";
            // 
            // coldsBOFIDL3DataTableCode_Des
            // 
            this.coldsBOFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtHeatID
            // 
            this.txtHeatID.EnableNull = false;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 9;
            this.txtHeatID.Location = new System.Drawing.Point(131, 85);
            this.txtHeatID.Max = 0;
            this.txtHeatID.MaxStrLength = 0;
            this.txtHeatID.Min = 0;
            this.txtHeatID.MinStrLength = 0;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Precision = 0;
            this.txtHeatID.Size = new System.Drawing.Size(179, 21);
            this.txtHeatID.TabIndex = 4;
            this.txtHeatID.ToolTipValid = this.toolTip1;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // dtTapTime
            // 
            this.dtTapTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTapTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTapTime.Location = new System.Drawing.Point(131, 115);
            this.dtTapTime.Name = "dtTapTime";
            this.dtTapTime.Size = new System.Drawing.Size(179, 21);
            this.dtTapTime.TabIndex = 2;
            // 
            // txtLadleID
            // 
            this.txtLadleID.Location = new System.Drawing.Point(131, 26);
            this.txtLadleID.Name = "txtLadleID";
            this.txtLadleID.ReadOnly = true;
            this.txtLadleID.Size = new System.Drawing.Size(179, 21);
            this.txtLadleID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "出钢开始时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "炉号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "炉座号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "钢包号:";
            // 
            // cmdBOFTapStart
            // 
            this.cmdBOFTapStart.Adapter = this.Adapter;
            this.cmdBOFTapStart.MergeReturnTarget = false;
            this.cmdBOFTapStart.Method = "BOFTapingStart";
            this.cmdBOFTapStart.Object = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.cmdBOFTapStart.Parameters.Add(this.l3cmdpUnitID);
            this.cmdBOFTapStart.Parameters.Add(this.l3cmdpTapTime);
            this.cmdBOFTapStart.Parameters.Add(this.l3cmdpHeatID);
            this.cmdBOFTapStart.ReturnTarget = null;
            this.cmdBOFTapStart.ReturnTargetProperty = null;
            this.cmdBOFTapStart.Trigger = null;
            this.cmdBOFTapStart.TriggerEvent = "Click";
            // 
            // l3cmdpUnitID
            // 
            this.l3cmdpUnitID.AcceptAfterExecuted = false;
            this.l3cmdpUnitID.ConstantValue = null;
            this.l3cmdpUnitID.MergeTarget = false;
            this.l3cmdpUnitID.SourceFilter = null;
            this.l3cmdpUnitID.SourceObject = null;
            this.l3cmdpUnitID.SourceProperty = "Text";
            this.l3cmdpUnitID.TargetObject = null;
            this.l3cmdpUnitID.TargetProperty = null;
            // 
            // l3cmdpTapTime
            // 
            this.l3cmdpTapTime.AcceptAfterExecuted = false;
            this.l3cmdpTapTime.ConstantValue = null;
            this.l3cmdpTapTime.MergeTarget = false;
            this.l3cmdpTapTime.SourceFilter = null;
            this.l3cmdpTapTime.SourceObject = this.dtTapTime;
            this.l3cmdpTapTime.SourceProperty = "Value";
            this.l3cmdpTapTime.TargetObject = null;
            this.l3cmdpTapTime.TargetProperty = null;
            // 
            // l3cmdpHeatID
            // 
            this.l3cmdpHeatID.AcceptAfterExecuted = false;
            this.l3cmdpHeatID.ConstantValue = null;
            this.l3cmdpHeatID.MergeTarget = false;
            this.l3cmdpHeatID.SourceFilter = null;
            this.l3cmdpHeatID.SourceObject = null;
            this.l3cmdpHeatID.SourceProperty = "Text";
            this.l3cmdpHeatID.TargetObject = null;
            this.l3cmdpHeatID.TargetProperty = null;
            // 
            // BOFTapStartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 258);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BOFTapStartFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "补录转炉出钢";
            this.Load += new System.EventHandler(this.BOFTapStartFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLadleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTapTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsBOFID;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdBOFTapStart;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitID;
        private AppSvrHMI.L3CommandParameter l3cmdpTapTime;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private PxDataValid.PxComboBox cmbBOFID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxTextBox txtHeatID;
    }
}