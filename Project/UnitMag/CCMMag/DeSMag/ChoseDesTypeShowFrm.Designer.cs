namespace UnitMag.DeSMag
{
    partial class ChoseDesTypeShowFrm
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
            this.cmbDesType = new PxDataValid.PxComboBox();
            this.dsDeSType = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsDeSType = new System.Data.DataTable();
            this.coldsDeSTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDeSTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.txtTPCNo = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.cmdDesType1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.cmdDesType2 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabPage2.Controls.Add(this.cmbDesType);
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
            // cmbDesType
            // 
            this.cmbDesType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDesType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDesType.DataSource = this.dsDeSType;
            this.cmbDesType.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesType.EnableNull = false;
            this.cmbDesType.ErropPr = this.errorProvider1;
            this.cmbDesType.FormattingEnabled = true;
            this.cmbDesType.Location = new System.Drawing.Point(113, 74);
            this.cmbDesType.Name = "cmbDesType";
            this.cmbDesType.Size = new System.Drawing.Size(209, 20);
            this.cmbDesType.TabIndex = 3;
            this.cmbDesType.ToolTipValid = this.toolTip1;
            this.cmbDesType.ValidEable = true;
            this.cmbDesType.ValueMember = "L3DataTable.Code_Val_Long";
            this.cmbDesType.SelectedIndexChanged += new System.EventHandler(this.cmbDesType_SelectedIndexChanged);
            // 
            // dsDeSType
            // 
            this.dsDeSType.AutoLoad = true;
            this.dsDeSType.AutoSubscribe = false;
            this.dsDeSType.DataSetName = "L3DataSet";
            this.dsDeSType.DeleteMethod = "";
            this.dsDeSType.InsertMethod = "";
            this.dsDeSType.L3DataAdapter = this.Adapter;
            this.dsDeSType.LoadEvent = "";
            this.dsDeSType.LoadTrigger = null;
            this.dsDeSType.RefreshValve = 1000;
            this.dsDeSType.SourceCommand = null;
            this.dsDeSType.SourceCondition = "CODE_GROUP = \'DeSType\'";
            this.dsDeSType.SourceMethod = "";
            this.dsDeSType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDeSType.SubscribeTarget = "";
            this.dsDeSType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDeSType});
            this.dsDeSType.UpdateEvent = "";
            this.dsDeSType.UpdateMethod = "";
            this.dsDeSType.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsDeSType
            // 
            this.schemadsDeSType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDeSTypeL3DataTableCode_Des,
            this.coldsDeSTypeL3DataTableCode_Val_Long});
            this.schemadsDeSType.TableName = "L3DataTable";
            // 
            // coldsDeSTypeL3DataTableCode_Des
            // 
            this.coldsDeSTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDeSTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDeSTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDeSTypeL3DataTableCode_Val_Long
            // 
            this.coldsDeSTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDeSTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDeSTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsDeSTypeL3DataTableCode_Val_Long.Namespace = "";
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
            this.label5.Location = new System.Drawing.Point(48, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "脱硫类型:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 51);
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
            // cmdDesType1
            // 
            this.cmdDesType1.Adapter = this.Adapter;
            this.cmdDesType1.MergeReturnTarget = false;
            this.cmdDesType1.Method = "SetDeSMode";
            this.cmdDesType1.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S02";
            this.cmdDesType1.Parameters.Add(this.l3CommandParameter3);
            this.cmdDesType1.Parameters.Add(this.l3CommandParameter4);
            this.cmdDesType1.ReturnTarget = null;
            this.cmdDesType1.ReturnTargetProperty = null;
            this.cmdDesType1.Trigger = null;
            this.cmdDesType1.TriggerEvent = "Click";
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
            // cmdDesType2
            // 
            this.cmdDesType2.Adapter = this.Adapter;
            this.cmdDesType2.MergeReturnTarget = false;
            this.cmdDesType2.Method = "SetDeSMode";
            this.cmdDesType2.Object = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag\\S03";
            this.cmdDesType2.Parameters.Add(this.l3CommandParameter5);
            this.cmdDesType2.Parameters.Add(this.l3CommandParameter6);
            this.cmdDesType2.ReturnTarget = null;
            this.cmdDesType2.ReturnTargetProperty = null;
            this.cmdDesType2.Trigger = null;
            this.cmdDesType2.TriggerEvent = "Click";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChoseDesTypeShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 186);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChoseDesTypeShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "脱硫类型选择";
            this.Load += new System.EventHandler(this.ChoseDesTypeShowFrm_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private PxDataValid.PxComboBox cmbDesType;
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
        private AppSvrHMI.L3Command cmdDesType1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3Command cmdDesType2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3DataSet dsDeSType;
        private System.Data.DataTable schemadsDeSType;
        private System.Data.DataColumn coldsDeSTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDeSTypeL3DataTableCode_Val_Long;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}