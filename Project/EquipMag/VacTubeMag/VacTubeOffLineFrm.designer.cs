namespace EquipMag.VacTubeMag
{
    partial class VacTubeOffLineFrm
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
            this.btnConfrim = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbVacTubeCode = new System.Windows.Forms.ComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableVacTube_Code = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdVacTubeCheckOver = new AppSvrHMI.L3Command(this.components);
            this.cmdpCode = new AppSvrHMI.L3CommandParameter();
            this.cmdpCheckType = new AppSvrHMI.L3CommandParameter();
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
            this.flowLayoutPanel1.Controls.Add(this.btnConfrim);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(318, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfrim
            // 
            this.btnConfrim.Location = new System.Drawing.Point(237, 3);
            this.btnConfrim.Name = "btnConfrim";
            this.btnConfrim.Size = new System.Drawing.Size(75, 23);
            this.btnConfrim.TabIndex = 0;
            this.btnConfrim.Tag = "";
            this.btnConfrim.Text = "操作";
            this.btnConfrim.UseVisualStyleBackColor = true;
            this.btnConfrim.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 203);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbVacTubeCode);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "真空槽信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbVacTubeCode
            // 
            this.cmbVacTubeCode.DataSource = this.bsBase;
            this.cmbVacTubeCode.DisplayMember = "VacTube_Code";
            this.cmbVacTubeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeCode.FormattingEnabled = true;
            this.cmbVacTubeCode.Location = new System.Drawing.Point(116, 67);
            this.cmbVacTubeCode.Name = "cmbVacTubeCode";
            this.cmbVacTubeCode.Size = new System.Drawing.Size(219, 20);
            this.cmbVacTubeCode.TabIndex = 5;
            this.cmbVacTubeCode.ValueMember = "VacTube_Code";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = false;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = "";
            this.dsBase.InsertMethod = "";
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBase.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsBase.SubscribeTarget = "";
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "";
            this.dsBase.UpdateMethod = "";
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableVacTube_Code});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableVacTube_Code
            // 
            this.coldsBaseL3DataTableVacTube_Code.Caption = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.ColumnName = "VacTube_Code";
            this.coldsBaseL3DataTableVacTube_Code.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "槽管编号:";
            // 
            // cmdVacTubeCheckOver
            // 
            this.cmdVacTubeCheckOver.Adapter = this.Adapter;
            this.cmdVacTubeCheckOver.MergeReturnTarget = false;
            this.cmdVacTubeCheckOver.Method = "VacTubeCheckOver";
            this.cmdVacTubeCheckOver.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.cmdVacTubeCheckOver.Parameters.Add(this.cmdpCode);
            this.cmdVacTubeCheckOver.Parameters.Add(this.cmdpCheckType);
            this.cmdVacTubeCheckOver.ReturnTarget = null;
            this.cmdVacTubeCheckOver.ReturnTargetProperty = null;
            this.cmdVacTubeCheckOver.Trigger = null;
            this.cmdVacTubeCheckOver.TriggerEvent = "Click";
            // 
            // cmdpCode
            // 
            this.cmdpCode.AcceptAfterExecuted = false;
            this.cmdpCode.ConstantValue = null;
            this.cmdpCode.MergeTarget = false;
            this.cmdpCode.SourceFilter = null;
            this.cmdpCode.SourceObject = null;
            this.cmdpCode.SourceProperty = null;
            this.cmdpCode.TargetObject = null;
            this.cmdpCode.TargetProperty = null;
            // 
            // cmdpCheckType
            // 
            this.cmdpCheckType.AcceptAfterExecuted = false;
            this.cmdpCheckType.ConstantValue = null;
            this.cmdpCheckType.MergeTarget = false;
            this.cmdpCheckType.SourceFilter = null;
            this.cmdpCheckType.SourceObject = null;
            this.cmdpCheckType.SourceProperty = null;
            this.cmdpCheckType.TargetObject = null;
            this.cmdpCheckType.TargetProperty = null;
            // 
            // VacTubeOffLineFrm
            // 
            this.AcceptButton = this.btnConfrim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 253);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeOffLineFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "真空槽处理";
            this.Load += new System.EventHandler(this.VacTubeOffLineFrm_Load);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Code;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.Button btnConfrim;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbVacTubeCode;
        private AppSvrHMI.L3Command cmdVacTubeCheckOver;
        private AppSvrHMI.L3CommandParameter cmdpCode;
        private AppSvrHMI.L3CommandParameter cmdpCheckType;
    }
}