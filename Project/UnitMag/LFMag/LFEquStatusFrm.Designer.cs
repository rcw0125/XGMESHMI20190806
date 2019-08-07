namespace UnitMag.LFMag
{
    partial class LFEquStatusFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbUnitID = new System.Windows.Forms.Label();
            this.lbUnitName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtReason = new PxDataValid.PxRichTextBox();
            this.rdFailure = new System.Windows.Forms.RadioButton();
            this.rdRepaire = new System.Windows.Forms.RadioButton();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.lbReason = new System.Windows.Forms.Label();
            this.cmdChangeStatus = new AppSvrHMI.L3Command(this.components);
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.paramStatus = new AppSvrHMI.L3CommandParameter();
            this.paramReason = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbUnitID);
            this.panel3.Controls.Add(this.lbUnitName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 29);
            this.panel3.TabIndex = 77;
            // 
            // lbUnitID
            // 
            this.lbUnitID.AutoSize = true;
            this.lbUnitID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUnitID.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUnitID.Location = new System.Drawing.Point(67, 9);
            this.lbUnitID.Name = "lbUnitID";
            this.lbUnitID.Size = new System.Drawing.Size(68, 12);
            this.lbUnitID.TabIndex = 73;
            this.lbUnitID.Text = "XXXXXXXXX";
            // 
            // lbUnitName
            // 
            this.lbUnitName.AutoSize = true;
            this.lbUnitName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUnitName.ForeColor = System.Drawing.SystemColors.Window;
            this.lbUnitName.Location = new System.Drawing.Point(19, 9);
            this.lbUnitName.Name = "lbUnitName";
            this.lbUnitName.Size = new System.Drawing.Size(38, 12);
            this.lbUnitName.TabIndex = 73;
            this.lbUnitName.Text = "炉座:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 255);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 37);
            this.flowLayoutPanel1.TabIndex = 81;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(367, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(286, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 78;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 226);
            this.tabControl1.TabIndex = 82;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtReason);
            this.tabPage1.Controls.Add(this.rdFailure);
            this.tabPage1.Controls.Add(this.rdRepaire);
            this.tabPage1.Controls.Add(this.rdNormal);
            this.tabPage1.Controls.Add(this.lbReason);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 201);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "状态信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.EnableNull = true;
            this.txtReason.ErropPr = null;
            this.txtReason.Location = new System.Drawing.Point(64, 50);
            this.txtReason.MaxStrLength = 125;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(323, 139);
            this.txtReason.TabIndex = 75;
            this.txtReason.Text = "";
            this.txtReason.ToolTipValid = null;
            this.txtReason.ValidEable = true;
            // 
            // rdFailure
            // 
            this.rdFailure.AutoSize = true;
            this.rdFailure.Location = new System.Drawing.Point(340, 17);
            this.rdFailure.Name = "rdFailure";
            this.rdFailure.Size = new System.Drawing.Size(47, 16);
            this.rdFailure.TabIndex = 4;
            this.rdFailure.TabStop = true;
            this.rdFailure.Tag = "-2";
            this.rdFailure.Text = "故障";
            this.rdFailure.UseVisualStyleBackColor = true;
            this.rdFailure.CheckedChanged += new System.EventHandler(this.OnStatusChanged);
            // 
            // rdRepaire
            // 
            this.rdRepaire.AutoSize = true;
            this.rdRepaire.Location = new System.Drawing.Point(199, 17);
            this.rdRepaire.Name = "rdRepaire";
            this.rdRepaire.Size = new System.Drawing.Size(47, 16);
            this.rdRepaire.TabIndex = 1;
            this.rdRepaire.TabStop = true;
            this.rdRepaire.Tag = "-1";
            this.rdRepaire.Text = "检修";
            this.rdRepaire.UseVisualStyleBackColor = true;
            this.rdRepaire.CheckedChanged += new System.EventHandler(this.OnStatusChanged);
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Location = new System.Drawing.Point(64, 17);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(47, 16);
            this.rdNormal.TabIndex = 0;
            this.rdNormal.TabStop = true;
            this.rdNormal.Tag = "0";
            this.rdNormal.Text = "正常";
            this.rdNormal.UseVisualStyleBackColor = true;
            this.rdNormal.CheckedChanged += new System.EventHandler(this.OnStatusChanged);
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(28, 53);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(35, 12);
            this.lbReason.TabIndex = 74;
            this.lbReason.Text = "原因:";
            // 
            // cmdChangeStatus
            // 
            this.cmdChangeStatus.Adapter = this.Adapter;
            this.cmdChangeStatus.MergeReturnTarget = false;
            this.cmdChangeStatus.Method = "ChangeDeviceStatus";
            this.cmdChangeStatus.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdChangeStatus.Parameters.Add(this.l3CommandParameter1);
            this.cmdChangeStatus.Parameters.Add(this.l3CommandParameter2);
            this.cmdChangeStatus.ReturnTarget = null;
            this.cmdChangeStatus.ReturnTargetProperty = null;
            this.cmdChangeStatus.Trigger = null;
            this.cmdChangeStatus.TriggerEvent = "Click";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.txtReason;
            this.l3CommandParameter2.SourceProperty = "Text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // paramStatus
            // 
            this.paramStatus.AcceptAfterExecuted = false;
            this.paramStatus.ConstantValue = null;
            this.paramStatus.MergeTarget = false;
            this.paramStatus.SourceFilter = null;
            this.paramStatus.SourceObject = null;
            this.paramStatus.SourceProperty = null;
            this.paramStatus.TargetObject = null;
            this.paramStatus.TargetProperty = null;
            // 
            // paramReason
            // 
            this.paramReason.AcceptAfterExecuted = false;
            this.paramReason.ConstantValue = null;
            this.paramReason.MergeTarget = false;
            this.paramReason.SourceFilter = null;
            this.paramReason.SourceObject = this.txtReason;
            this.paramReason.SourceProperty = "Text";
            this.paramReason.TargetObject = null;
            this.paramReason.TargetProperty = null;
            // 
            // dsError
            // 
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
            // LFEquStatusFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 292);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LFEquStatusFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LF炉设备状态";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbUnitID;
        private System.Windows.Forms.Label lbUnitName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox txtReason;
        private System.Windows.Forms.RadioButton rdFailure;
        private System.Windows.Forms.RadioButton rdRepaire;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.Label lbReason;
        private AppSvrHMI.L3Command cmdChangeStatus;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter paramStatus;
        private AppSvrHMI.L3CommandParameter paramReason;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
    }
}