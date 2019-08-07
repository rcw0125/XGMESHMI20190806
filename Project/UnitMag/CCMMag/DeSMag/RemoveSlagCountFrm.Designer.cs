namespace UnitMag.DeSMag
{
    partial class RemoveSlagCountFrm
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
            this.txtRemoveSlagCount = new PxDataValid.PxTextBox();
            this.bsIronsIfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronsInfo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsIronsInfo = new System.Data.DataTable();
            this.coldsIronsInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsIronsInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsIronsInfoL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsIronsInfoL3DataTableRemoveSlagCount = new System.Data.DataColumn();
            this.coldsIronsInfoL3DataTableDes_UnitID = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtTPCNo = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsIronsIfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronsInfo)).BeginInit();
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
            this.tabPage2.Controls.Add(this.txtRemoveSlagCount);
            this.tabPage2.Controls.Add(this.txtTPCNo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 115);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "铁水信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTAPNo
            // 
            //
            this.txtTAPNo.Enabled = false;
            this.txtTAPNo.EnableNull = false;
            this.txtTAPNo.ErropPr = null;
            //
            this.txtTAPNo.Length = 0;
            this.txtTAPNo.Location = new System.Drawing.Point(113, 22);
            this.txtTAPNo.Max = 0;
            //
            //
            this.txtTAPNo.MaxStrLength = 0;
            this.txtTAPNo.Min = -0.99;
            //
            //
            this.txtTAPNo.MinStrLength = 0;
            this.txtTAPNo.Name = "txtTAPNo";
            this.txtTAPNo.Precision = 0;
            //
            this.txtTAPNo.Size = new System.Drawing.Size(209, 21);
            this.txtTAPNo.TabIndex = 4;
            this.txtTAPNo.ToolTipValid = null;
          //
            this.txtTAPNo.ValidEable = true;
            this.txtTAPNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtRemoveSlagCount
            // 
            this.txtRemoveSlagCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsIronsIfo, "RemoveSlagCount", true));
            //
            this.txtRemoveSlagCount.EnableNull = false;
            this.txtRemoveSlagCount.ErropPr = this.errorProvider1;
            //
            this.txtRemoveSlagCount.Length = 0;
            this.txtRemoveSlagCount.Location = new System.Drawing.Point(113, 74);
            this.txtRemoveSlagCount.Max = 99;
            //
            //
            this.txtRemoveSlagCount.MaxStrLength = 0;
            this.txtRemoveSlagCount.Min = 0;
            //
            //
            this.txtRemoveSlagCount.MinStrLength = 0;
            this.txtRemoveSlagCount.Name = "txtRemoveSlagCount";
            this.txtRemoveSlagCount.Precision = 0;
            //
            this.txtRemoveSlagCount.Size = new System.Drawing.Size(209, 21);
            this.txtRemoveSlagCount.TabIndex = 1;
            this.txtRemoveSlagCount.ToolTipValid = this.toolTip1;
          //
            this.txtRemoveSlagCount.ValidEable = true;
            this.txtRemoveSlagCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtRemoveSlagCount.TextChanged += new System.EventHandler(this.txtRemoveSlagCount_TextChanged);
            // 
            // bsIronsIfo
            // 
            this.bsIronsIfo.DataMember = "L3DataTable";
            this.bsIronsIfo.DataSource = this.dsIronsInfo;
            // 
            // dsIronsInfo
            // 
            this.dsIronsInfo.AutoLoad = true;
            this.dsIronsInfo.AutoSubscribe = false;
            this.dsIronsInfo.DataSetName = "L3DataSet";
            this.dsIronsInfo.DeleteMethod = "";
            this.dsIronsInfo.InsertMethod = "";
            this.dsIronsInfo.L3DataAdapter = this.Adapter;
            this.dsIronsInfo.LoadEvent = "";
            this.dsIronsInfo.LoadTrigger = null;
            this.dsIronsInfo.RefreshValve = 1000;
            this.dsIronsInfo.SourceCommand = null;
            this.dsIronsInfo.SourceCondition = "1=2";
            this.dsIronsInfo.SourceMethod = "";
            this.dsIronsInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronsInfo.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Base_Data";
            this.dsIronsInfo.SubscribeTarget = "";
            this.dsIronsInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronsInfo});
            this.dsIronsInfo.UpdateEvent = "";
            this.dsIronsInfo.UpdateMethod = "";
            this.dsIronsInfo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsIronsInfo
            // 
            this.schemadsIronsInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronsInfoL3DataTableGUID,
            this.coldsIronsInfoL3DataTableName,
            this.coldsIronsInfoL3DataTableMaterialID,
            this.coldsIronsInfoL3DataTableRemoveSlagCount,
            this.coldsIronsInfoL3DataTableDes_UnitID});
            this.schemadsIronsInfo.TableName = "L3DataTable";
            // 
            // coldsIronsInfoL3DataTableGUID
            // 
            this.coldsIronsInfoL3DataTableGUID.Caption = "GUID";
            this.coldsIronsInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsIronsInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsIronsInfoL3DataTableName
            // 
            this.coldsIronsInfoL3DataTableName.Caption = "Name";
            this.coldsIronsInfoL3DataTableName.ColumnName = "Name";
            this.coldsIronsInfoL3DataTableName.Namespace = "";
            // 
            // coldsIronsInfoL3DataTableMaterialID
            // 
            this.coldsIronsInfoL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsIronsInfoL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsIronsInfoL3DataTableMaterialID.Namespace = "";
            // 
            // coldsIronsInfoL3DataTableRemoveSlagCount
            // 
            this.coldsIronsInfoL3DataTableRemoveSlagCount.Caption = "RemoveSlagCount";
            this.coldsIronsInfoL3DataTableRemoveSlagCount.ColumnName = "RemoveSlagCount";
            this.coldsIronsInfoL3DataTableRemoveSlagCount.DataType = typeof(int);
            this.coldsIronsInfoL3DataTableRemoveSlagCount.Namespace = "";
            // 
            // coldsIronsInfoL3DataTableDes_UnitID
            // 
            this.coldsIronsInfoL3DataTableDes_UnitID.Caption = "Des_UnitID";
            this.coldsIronsInfoL3DataTableDes_UnitID.ColumnName = "Des_UnitID";
            this.coldsIronsInfoL3DataTableDes_UnitID.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtTPCNo
            // 
            //
            this.txtTPCNo.Enabled = false;
            this.txtTPCNo.EnableNull = false;
            this.txtTPCNo.ErropPr = null;
            //
            this.txtTPCNo.Length = 0;
            this.txtTPCNo.Location = new System.Drawing.Point(113, 48);
            this.txtTPCNo.Max = 0;
            //
            //
            this.txtTPCNo.MaxStrLength = 0;
            this.txtTPCNo.Min = -0.99;
            //
            //
            this.txtTPCNo.MinStrLength = 0;
            this.txtTPCNo.Name = "txtTPCNo";
            this.txtTPCNo.Precision = 0;
            //
            this.txtTPCNo.Size = new System.Drawing.Size(209, 21);
            this.txtTPCNo.TabIndex = 1;
            this.txtTPCNo.ToolTipValid = null;
          //
            this.txtTPCNo.ValidEable = true;
            this.txtTPCNo.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "捞渣次数:";
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
            // RemoveSlagCountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 186);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RemoveSlagCountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "捞渣次数修改";
            this.Load += new System.EventHandler(this.RemoveSlagCountFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronsIfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private PxDataValid.PxTextBox txtTPCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxTextBox txtTAPNo;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
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
        private PxDataValid.PxTextBox txtRemoveSlagCount;
        private AppSvrHMI.L3DataSet dsIronsInfo;
        private System.Data.DataTable schemadsIronsInfo;
        private System.Data.DataColumn coldsIronsInfoL3DataTableGUID;
        private System.Data.DataColumn coldsIronsInfoL3DataTableName;
        private System.Data.DataColumn coldsIronsInfoL3DataTableMaterialID;
        private System.Data.DataColumn coldsIronsInfoL3DataTableRemoveSlagCount;
        private System.Windows.Forms.BindingSource bsIronsIfo;
        private System.Data.DataColumn coldsIronsInfoL3DataTableDes_UnitID;

    }
}