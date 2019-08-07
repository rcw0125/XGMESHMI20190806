namespace UnitMag.DeSMag
{
    partial class LanceChangeAgeShow
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
            this.dsLance = new AppSvrHMI.L3DataSet();
            this.schemadsLance = new System.Data.DataTable();
            this.coldsLanceL3DataTableLanceNo = new System.Data.DataColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.txtLanceNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpNewLance = new System.Windows.Forms.TabPage();
            this.lbLanceNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmdChangeLanceAge = new AppSvrHMI.L3Command(this.components);
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
            this.txtLanceAge = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.coldsLanceL3DataTableLanceAge = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpNewLance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsLance
            // 
            this.dsLance.AutoLoad = false;
            this.dsLance.AutoSubscribe = false;
            this.dsLance.DataSetName = "L3DataSet";
            this.dsLance.DeleteMethod = "";
            this.dsLance.InsertMethod = "";
            this.dsLance.L3DataAdapter = this.Adapter;
            this.dsLance.LoadEvent = "";
            this.dsLance.LoadTrigger = null;
            this.dsLance.RefreshValve = 1000;
            this.dsLance.SourceCommand = null;
            this.dsLance.SourceCondition = "";
            this.dsLance.SourceMethod = "";
            this.dsLance.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsLance.SourceURI = "";
            this.dsLance.SubscribeTarget = "";
            this.dsLance.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLance});
            this.dsLance.UpdateEvent = "";
            this.dsLance.UpdateMethod = "";
            this.dsLance.UpdateTrigger = null;
            // 
            // schemadsLance
            // 
            this.schemadsLance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceL3DataTableLanceNo,
            this.coldsLanceL3DataTableLanceAge});
            this.schemadsLance.TableName = "L3DataTable";
            // 
            // coldsLanceL3DataTableLanceNo
            // 
            this.coldsLanceL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.Namespace = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 97);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(303, 73);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // cmbVendor
            // 
            this.cmbVendor.DisplayMember = "L3DataTable.Code_Des";
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(66, 59);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(121, 20);
            this.cmbVendor.TabIndex = 14;
            this.cmbVendor.ValueMember = "L3DataTable.Code";
            // 
            // txtLanceNo
            // 
            this.txtLanceNo.Location = new System.Drawing.Point(66, 21);
            this.txtLanceNo.Mask = "0000-00";
            this.txtLanceNo.Name = "txtLanceNo";
            this.txtLanceNo.Size = new System.Drawing.Size(121, 21);
            this.txtLanceNo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "备注:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "厂家:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "枪号:";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpNewLance);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(347, 157);
            this.tcMain.TabIndex = 7;
            // 
            // tpNewLance
            // 
            this.tpNewLance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNewLance.Controls.Add(this.txtLanceAge);
            this.tpNewLance.Controls.Add(this.lbLanceNo);
            this.tpNewLance.Controls.Add(this.label4);
            this.tpNewLance.Controls.Add(this.label6);
            this.tpNewLance.Location = new System.Drawing.Point(4, 21);
            this.tpNewLance.Name = "tpNewLance";
            this.tpNewLance.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewLance.Size = new System.Drawing.Size(339, 132);
            this.tpNewLance.TabIndex = 0;
            this.tpNewLance.Text = "喷枪信息";
            this.tpNewLance.UseVisualStyleBackColor = true;
            // 
            // lbLanceNo
            // 
            this.lbLanceNo.AutoSize = true;
            this.lbLanceNo.Location = new System.Drawing.Point(66, 33);
            this.lbLanceNo.Name = "lbLanceNo";
            this.lbLanceNo.Size = new System.Drawing.Size(41, 12);
            this.lbLanceNo.TabIndex = 13;
            this.lbLanceNo.Text = "xxxxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "枪龄:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "枪号:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(242, 163);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(150, 163);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdChangeLanceAge
            // 
            this.cmdChangeLanceAge.Adapter = this.Adapter;
            this.cmdChangeLanceAge.MergeReturnTarget = false;
            this.cmdChangeLanceAge.Method = "ChangeLanceAge";
            this.cmdChangeLanceAge.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdChangeLanceAge.Parameters.Add(this.l3CommandParameter1);
            this.cmdChangeLanceAge.ReturnTarget = null;
            this.cmdChangeLanceAge.ReturnTargetProperty = null;
            this.cmdChangeLanceAge.Trigger = null;
            this.cmdChangeLanceAge.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsLance;
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
            this.dsError.SourceCondition = "1=2";
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
            // txtLanceAge
            // 
            this.txtLanceAge.EnableNull = false;
            this.txtLanceAge.ErropPr = this.errorProvider1;
            this.txtLanceAge.Length = 0;
            this.txtLanceAge.Location = new System.Drawing.Point(68, 77);
            this.txtLanceAge.Max = 0;
            this.txtLanceAge.MaxStrLength = 0;
            this.txtLanceAge.Min = 0;
            this.txtLanceAge.MinStrLength = 0;
            this.txtLanceAge.Name = "txtLanceAge";
            this.txtLanceAge.Precision = 0;
            this.txtLanceAge.Size = new System.Drawing.Size(100, 21);
            this.txtLanceAge.TabIndex = 14;
            this.txtLanceAge.ToolTipValid = this.toolTip1;
            this.txtLanceAge.ValidEable = true;
            this.txtLanceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtLanceAge.TextChanged += new System.EventHandler(this.txtLanceAge_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // coldsLanceL3DataTableLanceAge
            // 
            this.coldsLanceL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.DataType = typeof(int);
            this.coldsLanceL3DataTableLanceAge.Namespace = "";
            // 
            // LanceChangeAgeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 196);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tcMain);
            this.Name = "LanceChangeAgeShow";
            this.Text = "喷枪状态修改";
            this.Load += new System.EventHandler(this.LanceChangeAgeShow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpNewLance.ResumeLayout(false);
            this.tpNewLance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsLance;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cmbVendor;
        private System.Windows.Forms.MaskedTextBox txtLanceNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpNewLance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLanceNo;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Data.DataTable schemadsLance;
        private System.Data.DataColumn coldsLanceL3DataTableLanceNo;
        private AppSvrHMI.L3Command cmdChangeLanceAge;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableGUID;
        private System.Data.DataColumn coldsErrorL3DataTableName;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn coldsErrorL3DataTableOwner;
        private System.Data.DataColumn coldsErrorL3DataTableOwner_Des;
        private System.Data.DataColumn coldsErrorL3DataTableError_Val_Long;
        private PxDataValid.PxTextBox txtLanceAge;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsLanceL3DataTableLanceAge;
    }
}