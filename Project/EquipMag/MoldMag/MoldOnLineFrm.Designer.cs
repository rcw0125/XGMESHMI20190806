namespace EquipMag.MoldMag
{
    partial class MoldOnLineFrm
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
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.bsMold = new System.Windows.Forms.BindingSource(this.components);
            this.dsMold = new AppSvrHMI.L3DataSet();
            this.schemadsMold = new System.Data.DataTable();
            this.coldsMoldL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsMoldL3DataTableFlowID = new System.Data.DataColumn();
            this.cmbCastID = new PxDataValid.PxComboBox();
            this.txtMoldID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdOn = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpON = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMold)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 64);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(197, 3);
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
            this.tabControl1.Size = new System.Drawing.Size(356, 168);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pxComboBox2);
            this.tabPage1.Controls.Add(this.cmbCastID);
            this.tabPage1.Controls.Add(this.txtMoldID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMold, "FlowID", true));
            this.pxComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.pxComboBox2.Location = new System.Drawing.Point(117, 89);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(171, 20);
            this.pxComboBox2.TabIndex = 2;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            // 
            // bsMold
            // 
            this.bsMold.DataMember = "L3DataTable";
            this.bsMold.DataSource = this.dsMold;
            // 
            // dsMold
            // 
            this.dsMold.DataSetName = "L3DataSet";
            this.dsMold.DeleteMethod = null;
            this.dsMold.InsertMethod = null;
            this.dsMold.L3DataAdapter = null;
            this.dsMold.LoadEvent = "Click";
            this.dsMold.LoadTrigger = null;
            this.dsMold.RefreshValve = 1000;
            this.dsMold.SourceCommand = null;
            this.dsMold.SourceCondition = "";
            this.dsMold.SourceMethod = "";
            this.dsMold.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMold.SourceURI = "";
            this.dsMold.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMold});
            this.dsMold.UpdateEvent = "Click";
            this.dsMold.UpdateMethod = null;
            this.dsMold.UpdateTrigger = null;
            // 
            // schemadsMold
            // 
            this.schemadsMold.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldL3DataTableMoldID,
            this.coldsMoldL3DataTableCast_ID,
            this.coldsMoldL3DataTableFlowID});
            this.schemadsMold.TableName = "L3DataTable";
            // 
            // coldsMoldL3DataTableMoldID
            // 
            this.coldsMoldL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldL3DataTableMoldID.Namespace = "";
            // 
            // coldsMoldL3DataTableCast_ID
            // 
            this.coldsMoldL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsMoldL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsMoldL3DataTableCast_ID.Namespace = "";
            // 
            // coldsMoldL3DataTableFlowID
            // 
            this.coldsMoldL3DataTableFlowID.Caption = "FlowID";
            this.coldsMoldL3DataTableFlowID.ColumnName = "FlowID";
            this.coldsMoldL3DataTableFlowID.Namespace = "";
            // 
            // cmbCastID
            // 
            this.cmbCastID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCastID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCastID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMold, "Cast_ID", true));
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
            // txtMoldID
            // 
            this.txtMoldID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMold, "MoldID", true));
            this.txtMoldID.Location = new System.Drawing.Point(117, 28);
            this.txtMoldID.Name = "txtMoldID";
            this.txtMoldID.ReadOnly = true;
            this.txtMoldID.Size = new System.Drawing.Size(171, 21);
            this.txtMoldID.TabIndex = 1;
            this.txtMoldID.TextChanged += new System.EventHandler(this.txtMoldID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "流号:";
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
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "结晶器号:";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdOn
            // 
            this.cmdOn.Adapter = this.Adapter;
            this.cmdOn.MergeReturnTarget = false;
            this.cmdOn.Method = "MoldOnLine";
            this.cmdOn.Object = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.cmdOn.Parameters.Add(this.l3cmdpON);
            this.cmdOn.ReturnTarget = null;
            this.cmdOn.ReturnTargetProperty = null;
            this.cmdOn.Trigger = null;
            this.cmdOn.TriggerEvent = "Click";
            // 
            // l3cmdpON
            // 
            this.l3cmdpON.AcceptAfterExecuted = false;
            this.l3cmdpON.ConstantValue = null;
            this.l3cmdpON.MergeTarget = false;
            this.l3cmdpON.SourceFilter = null;
            this.l3cmdpON.SourceObject = this.dsMold;
            this.l3cmdpON.SourceProperty = "L3DataTable";
            this.l3cmdpON.TargetObject = null;
            this.l3cmdpON.TargetProperty = null;
            // 
            // MoldOnLineFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 232);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MoldOnLineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "换上结晶器";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbCastID;
        private System.Windows.Forms.TextBox txtMoldID;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox pxComboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3Command cmdOn;
        private AppSvrHMI.L3DataSet dsMold;
        private System.Data.DataTable schemadsMold;
        private System.Data.DataColumn coldsMoldL3DataTableMoldID;
        private System.Data.DataColumn coldsMoldL3DataTableCast_ID;
        private System.Data.DataColumn coldsMoldL3DataTableFlowID;
        private AppSvrHMI.L3CommandParameter l3cmdpON;
        private System.Windows.Forms.BindingSource bsMold;
    }
}