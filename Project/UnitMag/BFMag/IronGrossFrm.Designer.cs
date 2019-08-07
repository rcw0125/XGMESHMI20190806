namespace UnitMag.BFMag
{
    partial class IronGrossFrm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBFID = new System.Windows.Forms.TextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableBFID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsMainL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMainL3DataTableWeightMode = new System.Data.DataColumn();
            this.txtTapNo = new System.Windows.Forms.TextBox();
            this.txtTpcNo = new System.Windows.Forms.TextBox();
            this.txtbTare = new System.Windows.Forms.TextBox();
            this.lbHeatName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.cmdAcceptWeightData = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3Command1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(298, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(217, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 196);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtBFID);
            this.tabPage1.Controls.Add(this.txtTapNo);
            this.tabPage1.Controls.Add(this.txtTpcNo);
            this.tabPage1.Controls.Add(this.txtbTare);
            this.tabPage1.Controls.Add(this.lbHeatName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铁水信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBFID
            // 
            this.txtBFID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BFID", true));
            this.txtBFID.Location = new System.Drawing.Point(136, 30);
            this.txtBFID.Name = "txtBFID";
            this.txtBFID.ReadOnly = true;
            this.txtBFID.Size = new System.Drawing.Size(151, 21);
            this.txtBFID.TabIndex = 0;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
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
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableBFID,
            this.coldsMainL3DataTableTAP_No,
            this.coldsMainL3DataTableTPC_No,
            this.coldsMainL3DataTableMaterialID,
            this.coldsMainL3DataTableWeight,
            this.coldsMainL3DataTableWeightMode});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableBFID
            // 
            this.coldsMainL3DataTableBFID.Caption = "BFID";
            this.coldsMainL3DataTableBFID.ColumnName = "BFID";
            this.coldsMainL3DataTableBFID.Namespace = "";
            // 
            // coldsMainL3DataTableTAP_No
            // 
            this.coldsMainL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsMainL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsMainL3DataTableTAP_No.Namespace = "";
            // 
            // coldsMainL3DataTableTPC_No
            // 
            this.coldsMainL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsMainL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsMainL3DataTableTPC_No.Namespace = "";
            // 
            // coldsMainL3DataTableMaterialID
            // 
            this.coldsMainL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsMainL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsMainL3DataTableMaterialID.Namespace = "";
            // 
            // coldsMainL3DataTableWeight
            // 
            this.coldsMainL3DataTableWeight.Caption = "Weight";
            this.coldsMainL3DataTableWeight.ColumnName = "Weight";
            this.coldsMainL3DataTableWeight.DataType = typeof(double);
            this.coldsMainL3DataTableWeight.DefaultValue = 0;
            this.coldsMainL3DataTableWeight.Namespace = "";
            // 
            // coldsMainL3DataTableWeightMode
            // 
            this.coldsMainL3DataTableWeightMode.Caption = "WeightMode";
            this.coldsMainL3DataTableWeightMode.ColumnName = "WeightMode";
            this.coldsMainL3DataTableWeightMode.DataType = typeof(int);
            this.coldsMainL3DataTableWeightMode.DefaultValue = 0;
            this.coldsMainL3DataTableWeightMode.Namespace = "";
            // 
            // txtTapNo
            // 
            this.txtTapNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TAP_No", true));
            this.txtTapNo.Location = new System.Drawing.Point(136, 56);
            this.txtTapNo.Name = "txtTapNo";
            this.txtTapNo.ReadOnly = true;
            this.txtTapNo.Size = new System.Drawing.Size(151, 21);
            this.txtTapNo.TabIndex = 1;
            // 
            // txtTpcNo
            // 
            this.txtTpcNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TPC_No", true));
            this.txtTpcNo.Location = new System.Drawing.Point(136, 82);
            this.txtTpcNo.Name = "txtTpcNo";
            this.txtTpcNo.ReadOnly = true;
            this.txtTpcNo.Size = new System.Drawing.Size(151, 21);
            this.txtTpcNo.TabIndex = 2;
            // 
            // txtbTare
            // 
            this.txtbTare.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.txtbTare.Location = new System.Drawing.Point(136, 108);
            this.txtbTare.Name = "txtbTare";
            this.txtbTare.Size = new System.Drawing.Size(151, 21);
            this.txtbTare.TabIndex = 3;
            // 
            // lbHeatName
            // 
            this.lbHeatName.AutoSize = true;
            this.lbHeatName.Location = new System.Drawing.Point(71, 34);
            this.lbHeatName.Name = "lbHeatName";
            this.lbHeatName.Size = new System.Drawing.Size(59, 12);
            this.lbHeatName.TabIndex = 17;
            this.lbHeatName.Text = "高炉炉号:";
            this.lbHeatName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "罐号:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 15;
            this.label19.Text = "毛重[t]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "铁次:";
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
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
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
            // cmdAcceptWeightData
            // 
            this.cmdAcceptWeightData.Adapter = this.Adapter;
            this.cmdAcceptWeightData.MergeReturnTarget = false;
            this.cmdAcceptWeightData.Method = "AcceptWeightData";
            this.cmdAcceptWeightData.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.cmdAcceptWeightData.Parameters.Add(this.l3CommandParameter4);
            this.cmdAcceptWeightData.ReturnTarget = null;
            this.cmdAcceptWeightData.ReturnTargetProperty = null;
            this.cmdAcceptWeightData.Trigger = null;
            this.cmdAcceptWeightData.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.dsMain;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // l3Command1
            // 
            this.l3Command1.Adapter = this.Adapter;
            this.l3Command1.MergeReturnTarget = false;
            this.l3Command1.Method = "AcceptWeightData";
            this.l3Command1.Object = "XGMESLogic\\BFMag\\CBF_Iron_Mag\\BFIronMag";
            this.l3Command1.Parameters.Add(this.l3CommandParameter5);
            this.l3Command1.ReturnTarget = null;
            this.l3Command1.ReturnTargetProperty = null;
            this.l3Command1.Trigger = null;
            this.l3Command1.TriggerEvent = "Click";
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
            // IronGrossFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(385, 241);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Name = "IronGrossFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁水毛重收集";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableBFID;
        private System.Data.DataColumn coldsMainL3DataTableTAP_No;
        private System.Data.DataColumn coldsMainL3DataTableTPC_No;
        private System.Windows.Forms.Label lbHeatName;
        private System.Windows.Forms.TextBox txtBFID;
        private System.Windows.Forms.TextBox txtTapNo;
        private System.Windows.Forms.TextBox txtTpcNo;
        private System.Windows.Forms.TextBox txtbTare;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Data.DataColumn coldsMainL3DataTableMaterialID;
        private AppSvrHMI.L3Command cmdAcceptWeightData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsMainL3DataTableWeight;
        private System.Data.DataColumn coldsMainL3DataTableWeightMode;
        private AppSvrHMI.L3Command l3Command1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
    }
}