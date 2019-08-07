namespace UnitMag.BOFMag
{
    partial class SteelReturnAppFrm
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
            this.cbxHeatID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxReason = new System.Windows.Forms.ComboBox();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdApply = new AppSvrHMI.L3Command(this.components);
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.schemadsHeatID = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableHEATID = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 51);
            this.panel3.TabIndex = 84;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(307, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 81;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(229, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 80;
            this.btnOK.Text = "回炉申请";
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
            this.tabControl1.Size = new System.Drawing.Size(394, 132);
            this.tabControl1.TabIndex = 85;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cbxHeatID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbxReason);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "回炉信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxHeatID
            // 
            this.cbxHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHeatID.FormattingEnabled = true;
            this.cbxHeatID.Location = new System.Drawing.Point(109, 25);
            this.cbxHeatID.Name = "cbxHeatID";
            this.cbxHeatID.Size = new System.Drawing.Size(203, 20);
            this.cbxHeatID.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 79;
            this.label1.Text = "炉号:";
            // 
            // cbxReason
            // 
            this.cbxReason.DataSource = this.dsCode;
            this.cbxReason.DisplayMember = "L3DataTable.Code_Des";
            this.cbxReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReason.FormattingEnabled = true;
            this.cbxReason.Location = new System.Drawing.Point(109, 60);
            this.cbxReason.Name = "cbxReason";
            this.cbxReason.Size = new System.Drawing.Size(203, 20);
            this.cbxReason.TabIndex = 77;
            this.cbxReason.ValueMember = "L3DataTable.Code";
            // 
            // dsCode
            // 
            this.dsCode.AutoSubscribe = true;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = null;
            this.dsCode.InsertMethod = null;
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "Click";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = this.cmdApply;
            this.dsCode.SourceCondition = "Code_Group = \'SteelTrunReason\' and Code is not null";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCode.SubscribeTarget = null;
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCode});
            this.dsCode.UpdateEvent = "Click";
            this.dsCode.UpdateMethod = null;
            this.dsCode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdApply
            // 
            this.cmdApply.Adapter = this.Adapter;
            this.cmdApply.MergeReturnTarget = false;
            this.cmdApply.Method = null;
            this.cmdApply.Object = null;
            this.cmdApply.ReturnTarget = null;
            this.cmdApply.ReturnTargetProperty = null;
            this.cmdApply.Trigger = null;
            this.cmdApply.TriggerEvent = "Click";
            // 
            // schemadsCode
            // 
            this.schemadsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeL3DataTableCode,
            this.coldsCodeL3DataTableCode_Des});
            this.schemadsCode.TableName = "L3DataTable";
            // 
            // coldsCodeL3DataTableCode
            // 
            this.coldsCodeL3DataTableCode.Caption = "Code";
            this.coldsCodeL3DataTableCode.ColumnName = "Code";
            this.coldsCodeL3DataTableCode.Namespace = "";
            // 
            // coldsCodeL3DataTableCode_Des
            // 
            this.coldsCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.Namespace = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "申请理由:";
            // 
            // dsError
            // 
            this.dsError.AutoSubscribe = true;
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
            // dsHeatID
            // 
            this.dsHeatID.AutoSubscribe = true;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = "";
            this.dsHeatID.InsertMethod = "";
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = null;
            this.dsHeatID.SourceCondition = "";
            this.dsHeatID.SourceMethod = "GetPreThreeHeatID";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatID});
            this.dsHeatID.UpdateEvent = "";
            this.dsHeatID.UpdateMethod = "";
            this.dsHeatID.UpdateTrigger = null;
            // 
            // schemadsHeatID
            // 
            this.schemadsHeatID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatIDL3DataTableHEATID});
            this.schemadsHeatID.TableName = "L3DataTable";
            // 
            // coldsHeatIDL3DataTableHEATID
            // 
            this.coldsHeatIDL3DataTableHEATID.Caption = "HEATID";
            this.coldsHeatIDL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsHeatIDL3DataTableHEATID.DefaultValue = "";
            this.coldsHeatIDL3DataTableHEATID.Namespace = "";
            // 
            // SteelReturnAppFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 183);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SteelReturnAppFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回炉申请";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbxReason;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataSet dsCode;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3Command cmdApply;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsHeatID;
        private System.Data.DataTable schemadsHeatID;
        private System.Data.DataColumn coldsHeatIDL3DataTableHEATID;
        private System.Windows.Forms.ComboBox cbxHeatID;
    }
}