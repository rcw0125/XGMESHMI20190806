namespace UnitMag.DeSMag
{
    partial class ChoseDesShowFrm
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTAPNo = new PxDataValid.PxTextBox();
            this.cmbDes = new PxDataValid.PxComboBox();
            this.dsDesination = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsDesination = new System.Data.DataTable();
            this.coldsDesinationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDesinationL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTPCNo = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmdIronsDeparture1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.cmdIronsDeparture2 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableGUID = new System.Data.DataColumn();
            this.coldsErrorL3DataTableName = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner = new System.Data.DataColumn();
            this.coldsErrorL3DataTableOwner_Des = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Val_Long = new System.Data.DataColumn();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(383, 141);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.txtTAPNo);
            this.tabPage2.Controls.Add(this.cmbDes);
            this.tabPage2.Controls.Add(this.txtTPCNo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 116);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "铁水信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTAPNo
            // 
            this.txtTAPNo.Enabled = false;
            this.txtTAPNo.EnableNull = false;
            this.txtTAPNo.ErropPr = null;
            this.txtTAPNo.Length = 0;
            this.txtTAPNo.Location = new System.Drawing.Point(113, 22);
            this.txtTAPNo.Max = 0;
            this.txtTAPNo.MaxStrLength = 0;
            this.txtTAPNo.Min = -0.99;
            this.txtTAPNo.MinStrLength = 0;
            this.txtTAPNo.Name = "txtTAPNo";
            this.txtTAPNo.Precision = 0;
            this.txtTAPNo.Size = new System.Drawing.Size(209, 21);
            this.txtTAPNo.TabIndex = 4;
            this.txtTAPNo.ToolTipValid = null;
            this.txtTAPNo.ValidEable = true;
            this.txtTAPNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // cmbDes
            // 
            this.cmbDes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDes.DataSource = this.dsDesination;
            this.cmbDes.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDes.EnableNull = false;
            this.cmbDes.ErropPr = this.errorProvider1;
            this.cmbDes.FormattingEnabled = true;
            this.cmbDes.Location = new System.Drawing.Point(113, 74);
            this.cmbDes.Name = "cmbDes";
            this.cmbDes.Size = new System.Drawing.Size(209, 20);
            this.cmbDes.TabIndex = 3;
            this.cmbDes.ToolTipValid = this.toolTip1;
            this.cmbDes.ValidEable = true;
            this.cmbDes.ValueMember = "L3DataTable.Code_Val_Long";
            this.cmbDes.SelectedIndexChanged += new System.EventHandler(this.cmbDes_SelectedIndexChanged);
            // 
            // dsDesination
            // 
            this.dsDesination.AutoLoad = true;
            this.dsDesination.AutoSubscribe = false;
            this.dsDesination.DataSetName = "L3DataSet";
            this.dsDesination.DeleteMethod = "";
            this.dsDesination.InsertMethod = "";
            this.dsDesination.L3DataAdapter = this.Adapter;
            this.dsDesination.LoadEvent = "";
            this.dsDesination.LoadTrigger = null;
            this.dsDesination.RefreshValve = 1000;
            this.dsDesination.SourceCommand = null;
            this.dsDesination.SourceCondition = "code_group = \'Iron_Destination\' and code != \'0\' order by code_val_str";
            this.dsDesination.SourceMethod = "";
            this.dsDesination.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDesination.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDesination.SubscribeTarget = "";
            this.dsDesination.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDesination});
            this.dsDesination.UpdateEvent = "";
            this.dsDesination.UpdateMethod = "";
            this.dsDesination.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsDesination
            // 
            this.schemadsDesination.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDesinationL3DataTableCode_Des,
            this.coldsDesinationL3DataTableCode_Val_Long});
            this.schemadsDesination.TableName = "L3DataTable";
            // 
            // coldsDesinationL3DataTableCode_Des
            // 
            this.coldsDesinationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDesinationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDesinationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDesinationL3DataTableCode_Val_Long
            // 
            this.coldsDesinationL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDesinationL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDesinationL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsDesinationL3DataTableCode_Val_Long.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTPCNo
            // 
            this.txtTPCNo.Enabled = false;
            this.txtTPCNo.EnableNull = false;
            this.txtTPCNo.ErropPr = null;
            this.txtTPCNo.Length = 0;
            this.txtTPCNo.Location = new System.Drawing.Point(113, 48);
            this.txtTPCNo.Max = 0;
            this.txtTPCNo.MaxStrLength = 0;
            this.txtTPCNo.Min = -0.99;
            this.txtTPCNo.MinStrLength = 0;
            this.txtTPCNo.Name = "txtTPCNo";
            this.txtTPCNo.Precision = 0;
            this.txtTPCNo.Size = new System.Drawing.Size(209, 21);
            this.txtTPCNo.TabIndex = 1;
            this.txtTPCNo.ToolTipValid = null;
            this.txtTPCNo.ValidEable = true;
            this.txtTPCNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "去向:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "罐号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "铁次号:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(287, 147);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 5;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(195, 147);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdIronsDeparture1
            // 
            this.cmdIronsDeparture1.Adapter = this.Adapter;
            this.cmdIronsDeparture1.MergeReturnTarget = false;
            this.cmdIronsDeparture1.Method = "SetDeSIronPath";
            this.cmdIronsDeparture1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdIronsDeparture1.Parameters.Add(this.l3CommandParameter3);
            this.cmdIronsDeparture1.Parameters.Add(this.l3CommandParameter4);
            this.cmdIronsDeparture1.ReturnTarget = null;
            this.cmdIronsDeparture1.ReturnTargetProperty = null;
            this.cmdIronsDeparture1.Trigger = null;
            this.cmdIronsDeparture1.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // cmdIronsDeparture2
            // 
            this.cmdIronsDeparture2.Adapter = this.Adapter;
            this.cmdIronsDeparture2.MergeReturnTarget = false;
            this.cmdIronsDeparture2.Method = "SetDeSIronPath";
            this.cmdIronsDeparture2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdIronsDeparture2.Parameters.Add(this.l3CommandParameter5);
            this.cmdIronsDeparture2.Parameters.Add(this.l3CommandParameter6);
            this.cmdIronsDeparture2.ReturnTarget = null;
            this.cmdIronsDeparture2.ReturnTargetProperty = null;
            this.cmdIronsDeparture2.Trigger = null;
            this.cmdIronsDeparture2.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = null;
            this.l3CommandParameter5.SourceProperty = null;
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = null;
            this.l3CommandParameter6.SourceProperty = null;
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'IronsDeparture\'";
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
            this.coldsErrorL3DataTableGUID,
            this.coldsErrorL3DataTableName,
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des,
            this.coldsErrorL3DataTableOwner,
            this.coldsErrorL3DataTableOwner_Des,
            this.coldsErrorL3DataTableError_Val_Long});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableGUID
            // 
            this.coldsErrorL3DataTableGUID.Caption = "GUID";
            this.coldsErrorL3DataTableGUID.ColumnName = "GUID";
            this.coldsErrorL3DataTableGUID.Namespace = "";
            // 
            // coldsErrorL3DataTableName
            // 
            this.coldsErrorL3DataTableName.Caption = "Name";
            this.coldsErrorL3DataTableName.ColumnName = "Name";
            this.coldsErrorL3DataTableName.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner
            // 
            this.coldsErrorL3DataTableOwner.Caption = "Owner";
            this.coldsErrorL3DataTableOwner.ColumnName = "Owner";
            this.coldsErrorL3DataTableOwner.Namespace = "";
            // 
            // coldsErrorL3DataTableOwner_Des
            // 
            this.coldsErrorL3DataTableOwner_Des.Caption = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.ColumnName = "Owner_Des";
            this.coldsErrorL3DataTableOwner_Des.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Val_Long
            // 
            this.coldsErrorL3DataTableError_Val_Long.Caption = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.ColumnName = "Error_Val_Long";
            this.coldsErrorL3DataTableError_Val_Long.Namespace = "";
            // 
            // ChoseDesShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 186);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChoseDesShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁水去向选择";
            this.Load += new System.EventHandler(this.ChoseDesShowFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDesination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDesination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private PxDataValid.PxComboBox cmbDes;
        private PxDataValid.PxTextBox txtTPCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxTextBox txtTAPNo;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3Command cmdIronsDeparture1;
        private AppSvrHMI.L3Command cmdIronsDeparture2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsDesination;
        private System.Data.DataTable schemadsDesination;
        private System.Data.DataColumn coldsDesinationL3DataTableCode_Des;
        private System.Data.DataColumn coldsDesinationL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;

    }
}