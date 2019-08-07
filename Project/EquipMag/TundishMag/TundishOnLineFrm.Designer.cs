namespace EquipMag.TundishMag
{
    partial class TundishOnLineFrm
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
            this.cmbVehicleID = new PxDataValid.PxComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableRefra_Pro = new System.Data.DataColumn();
            this.coldsBaseL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundish_Age = new System.Data.DataColumn();
            this.coldsBaseL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsBaseL3DataTableFlag = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundishType = new System.Data.DataColumn();
            this.coldsBaseL3DataTableVehicleID = new System.Data.DataColumn();
            this.cmbCastID = new PxDataValid.PxComboBox();
            this.txtTundishID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdOnFire = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 163);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(362, 64);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(284, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(203, 3);
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
            this.tabControl1.Size = new System.Drawing.Size(362, 163);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbVehicleID);
            this.tabPage1.Controls.Add(this.cmbCastID);
            this.tabPage1.Controls.Add(this.txtTundishID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbVehicleID
            // 
            this.cmbVehicleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVehicleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVehicleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "VehicleID", true));
            this.cmbVehicleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleID.EnableNull = true;
            this.cmbVehicleID.ErropPr = null;
            this.cmbVehicleID.FormattingEnabled = true;
            this.cmbVehicleID.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbVehicleID.Location = new System.Drawing.Point(117, 89);
            this.cmbVehicleID.Name = "cmbVehicleID";
            this.cmbVehicleID.Size = new System.Drawing.Size(171, 20);
            this.cmbVehicleID.TabIndex = 2;
            this.cmbVehicleID.ToolTipValid = null;
            this.cmbVehicleID.ValidEable = true;
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = "";
            this.dsBase.InsertMethod = "";
            this.dsBase.L3DataAdapter = null;
            this.dsBase.LoadEvent = "";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBase.SourceURI = "";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "";
            this.dsBase.UpdateMethod = "";
            this.dsBase.UpdateTrigger = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableTundishID,
            this.coldsBaseL3DataTableCast_ID,
            this.coldsBaseL3DataTableRefra_Pro,
            this.coldsBaseL3DataTableStatus,
            this.coldsBaseL3DataTableTundish_Age,
            this.coldsBaseL3DataTableInnerID,
            this.coldsBaseL3DataTableWorkID,
            this.coldsBaseL3DataTableTundishNO,
            this.coldsBaseL3DataTableFlag,
            this.coldsBaseL3DataTableTundishType,
            this.coldsBaseL3DataTableVehicleID});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableTundishID
            // 
            this.coldsBaseL3DataTableTundishID.Caption = "TundishID";
            this.coldsBaseL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsBaseL3DataTableTundishID.Namespace = "";
            // 
            // coldsBaseL3DataTableCast_ID
            // 
            this.coldsBaseL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsBaseL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsBaseL3DataTableCast_ID.Namespace = "";
            // 
            // coldsBaseL3DataTableRefra_Pro
            // 
            this.coldsBaseL3DataTableRefra_Pro.Caption = "Refra_Pro";
            this.coldsBaseL3DataTableRefra_Pro.ColumnName = "Refra_Pro";
            this.coldsBaseL3DataTableRefra_Pro.Namespace = "";
            // 
            // coldsBaseL3DataTableStatus
            // 
            this.coldsBaseL3DataTableStatus.Caption = "Status";
            this.coldsBaseL3DataTableStatus.ColumnName = "Status";
            this.coldsBaseL3DataTableStatus.Namespace = "";
            // 
            // coldsBaseL3DataTableTundish_Age
            // 
            this.coldsBaseL3DataTableTundish_Age.Caption = "Tundish_Age";
            this.coldsBaseL3DataTableTundish_Age.ColumnName = "Tundish_Age";
            this.coldsBaseL3DataTableTundish_Age.DataType = typeof(int);
            this.coldsBaseL3DataTableTundish_Age.Namespace = "";
            // 
            // coldsBaseL3DataTableInnerID
            // 
            this.coldsBaseL3DataTableInnerID.Caption = "InnerID";
            this.coldsBaseL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsBaseL3DataTableInnerID.Namespace = "";
            // 
            // coldsBaseL3DataTableWorkID
            // 
            this.coldsBaseL3DataTableWorkID.Caption = "WorkID";
            this.coldsBaseL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsBaseL3DataTableWorkID.Namespace = "";
            // 
            // coldsBaseL3DataTableTundishNO
            // 
            this.coldsBaseL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsBaseL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsBaseL3DataTableTundishNO.Namespace = "";
            // 
            // coldsBaseL3DataTableFlag
            // 
            this.coldsBaseL3DataTableFlag.Caption = "Flag";
            this.coldsBaseL3DataTableFlag.ColumnName = "Flag";
            this.coldsBaseL3DataTableFlag.DataType = typeof(int);
            this.coldsBaseL3DataTableFlag.Namespace = "";
            // 
            // coldsBaseL3DataTableTundishType
            // 
            this.coldsBaseL3DataTableTundishType.Caption = "TundishType";
            this.coldsBaseL3DataTableTundishType.ColumnName = "TundishType";
            this.coldsBaseL3DataTableTundishType.DataType = typeof(short);
            this.coldsBaseL3DataTableTundishType.Namespace = "";
            // 
            // coldsBaseL3DataTableVehicleID
            // 
            this.coldsBaseL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsBaseL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsBaseL3DataTableVehicleID.Namespace = "";
            // 
            // cmbCastID
            // 
            this.cmbCastID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCastID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCastID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Cast_ID", true));
            this.cmbCastID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastID.EnableNull = true;
            this.cmbCastID.ErropPr = null;
            this.cmbCastID.FormattingEnabled = true;
            this.cmbCastID.Location = new System.Drawing.Point(117, 59);
            this.cmbCastID.Name = "cmbCastID";
            this.cmbCastID.Size = new System.Drawing.Size(171, 20);
            this.cmbCastID.TabIndex = 2;
            this.cmbCastID.ToolTipValid = null;
            this.cmbCastID.ValidEable = true;
            // 
            // txtTundishID
            // 
            this.txtTundishID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "TundishID", true));
            this.txtTundishID.Location = new System.Drawing.Point(117, 28);
            this.txtTundishID.Name = "txtTundishID";
            this.txtTundishID.ReadOnly = true;
            this.txtTundishID.Size = new System.Drawing.Size(171, 21);
            this.txtTundishID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "车号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "铸机号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "中包号:";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdOnFire
            // 
            this.cmdOnFire.Adapter = this.Adapter;
            this.cmdOnFire.MergeReturnTarget = false;
            this.cmdOnFire.Method = "TundishOnFireStart";
            this.cmdOnFire.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdOnFire.Parameters.Add(this.l3CommandParameter1);
            this.cmdOnFire.ReturnTarget = null;
            this.cmdOnFire.ReturnTargetProperty = null;
            this.cmdOnFire.Trigger = null;
            this.cmdOnFire.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsBase;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // TundishOnLineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 227);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "TundishOnLineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "中包在线烘烤开始";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbVehicleID;
        private PxDataValid.PxComboBox cmbCastID;
        private System.Windows.Forms.TextBox txtTundishID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableTundishID;
        private System.Data.DataColumn coldsBaseL3DataTableCast_ID;
        private System.Data.DataColumn coldsBaseL3DataTableRefra_Pro;
        private System.Data.DataColumn coldsBaseL3DataTableStatus;
        private System.Data.DataColumn coldsBaseL3DataTableTundish_Age;
        private System.Data.DataColumn coldsBaseL3DataTableInnerID;
        private System.Data.DataColumn coldsBaseL3DataTableWorkID;
        private System.Data.DataColumn coldsBaseL3DataTableTundishNO;
        private System.Data.DataColumn coldsBaseL3DataTableFlag;
        private System.Data.DataColumn coldsBaseL3DataTableTundishType;
        private System.Data.DataColumn coldsBaseL3DataTableVehicleID;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBase;
        private AppSvrHMI.L3Command cmdOnFire;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
    }
}