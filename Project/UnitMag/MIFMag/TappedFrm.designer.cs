namespace UnitMag.MIFMag
{
    partial class TappedFrm
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
            this.cmbLadle = new PxDataValid.PxComboBox();
            this.dsIronLadles = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsIronLadles = new System.Data.DataTable();
            this.coldsIronLadlesL3DataTableIRONLADLEID = new System.Data.DataColumn();
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbWeight = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReturnSteelWeight = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.tbYk = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLadle
            // 
            this.cmbLadle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadle.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLadle.DataSource = this.dsIronLadles;
            this.cmbLadle.DisplayMember = "L3DataTable.IRONLADLEID";
            this.cmbLadle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadle.EnableNull = false;
            this.cmbLadle.ErropPr = this.errorProvider1;
            this.cmbLadle.FormattingEnabled = true;
            this.cmbLadle.Location = new System.Drawing.Point(120, 22);
            this.cmbLadle.Name = "cmbLadle";
            this.cmbLadle.ReadOnly = false;
            this.cmbLadle.Size = new System.Drawing.Size(150, 20);
            this.cmbLadle.TabIndex = 10;
            this.cmbLadle.TMpEnabled = true;
            this.cmbLadle.ToolTipValid = this.toolTip1;
            this.cmbLadle.ValidEable = true;
            this.cmbLadle.ValueMember = "L3DataTable.IRONLADLEID";
            // 
            // dsIronLadles
            // 
            this.dsIronLadles.AutoLoad = true;
            this.dsIronLadles.AutoSubscribe = true;
            this.dsIronLadles.DataSetName = "L3DataSet";
            this.dsIronLadles.DeleteMethod = "";
            this.dsIronLadles.InsertMethod = "";
            this.dsIronLadles.L3DataAdapter = this.Adapter;
            this.dsIronLadles.LoadEvent = "Click";
            this.dsIronLadles.LoadTrigger = null;
            this.dsIronLadles.RefreshValve = 1000;
            this.dsIronLadles.SourceCommand = null;
            this.dsIronLadles.SourceCondition = null;
            this.dsIronLadles.SourceMethod = "GetHotIronLadles";
            this.dsIronLadles.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsIronLadles.SourceURI = "XGMESLogic\\MIXFMag\\CMIF_Mag\\MIFMag";
            this.dsIronLadles.SubscribeTarget = null;
            this.dsIronLadles.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadles});
            this.dsIronLadles.UpdateEvent = "Click";
            this.dsIronLadles.UpdateMethod = "";
            this.dsIronLadles.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsIronLadles
            // 
            this.schemadsIronLadles.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadlesL3DataTableIRONLADLEID,
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight});
            this.schemadsIronLadles.TableName = "L3DataTable";
            // 
            // coldsIronLadlesL3DataTableIRONLADLEID
            // 
            this.coldsIronLadlesL3DataTableIRONLADLEID.Caption = "IRONLADLEID";
            this.coldsIronLadlesL3DataTableIRONLADLEID.ColumnName = "IRONLADLEID";
            this.coldsIronLadlesL3DataTableIRONLADLEID.DefaultValue = "";
            this.coldsIronLadlesL3DataTableIRONLADLEID.Namespace = "";
            // 
            // coldsIronLadlesL3DataTableReturn_Steel_Weight
            // 
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight.DataType = typeof(double);
            this.coldsIronLadlesL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbWeight
            // 
            this.tbWeight.BackColor = System.Drawing.SystemColors.Window;
            this.tbWeight.DisplayPrecision = 0;
            this.tbWeight.EnableNull = false;
            this.tbWeight.ErropPr = this.errorProvider1;
            this.tbWeight.FixedLength = 0;
            this.tbWeight.Length = 0;
            this.tbWeight.Location = new System.Drawing.Point(120, 50);
            this.tbWeight.Max = 99D;
            this.tbWeight.MaxNull = 99D;
            this.tbWeight.MaxStringLength = 0;
            this.tbWeight.MaxStrLength = 0;
            this.tbWeight.Min = 0D;
            this.tbWeight.MinNull = 0D;
            this.tbWeight.MinStringLength = 0;
            this.tbWeight.MinStrLength = 0;
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Precision = 0;
            this.tbWeight.Regex = "";
            this.tbWeight.Size = new System.Drawing.Size(150, 21);
            this.tbWeight.TabIndex = 8;
            this.tbWeight.ToolTipValid = this.toolTip1;
            this.tbWeight.VaildWarning = "";
            this.tbWeight.ValidEable = true;
            this.tbWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "铁包号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "出铁量[t]:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(191, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(272, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 46);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "回炉钢水量[t]:";
            // 
            // txtReturnSteelWeight
            // 
            this.txtReturnSteelWeight.DisplayPrecision = 0;
            this.txtReturnSteelWeight.EnableNull = false;
            this.txtReturnSteelWeight.ErropPr = this.errorProvider1;
            this.txtReturnSteelWeight.FixedLength = 0;
            this.txtReturnSteelWeight.Length = 0;
            this.txtReturnSteelWeight.Location = new System.Drawing.Point(120, 104);
            this.txtReturnSteelWeight.Max = 99D;
            this.txtReturnSteelWeight.MaxNull = 99D;
            this.txtReturnSteelWeight.MaxStringLength = 0;
            this.txtReturnSteelWeight.MaxStrLength = 0;
            this.txtReturnSteelWeight.Min = 0D;
            this.txtReturnSteelWeight.MinNull = 0D;
            this.txtReturnSteelWeight.MinStringLength = 0;
            this.txtReturnSteelWeight.MinStrLength = 0;
            this.txtReturnSteelWeight.Name = "txtReturnSteelWeight";
            this.txtReturnSteelWeight.Precision = 0;
            this.txtReturnSteelWeight.Regex = "";
            this.txtReturnSteelWeight.Size = new System.Drawing.Size(150, 21);
            this.txtReturnSteelWeight.TabIndex = 8;
            this.txtReturnSteelWeight.ToolTipValid = this.toolTip1;
            this.txtReturnSteelWeight.VaildWarning = "";
            this.txtReturnSteelWeight.ValidEable = true;
            this.txtReturnSteelWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "指定去向:";
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "转炉(碳钢)",
            "脱磷(不锈钢)"});
            this.cmbDestination.Location = new System.Drawing.Point(120, 132);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(150, 20);
            this.cmbDestination.TabIndex = 14;
            // 
            // tbYk
            // 
            this.tbYk.BackColor = System.Drawing.SystemColors.Window;
            this.tbYk.DisplayPrecision = 0;
            this.tbYk.EnableNull = false;
            this.tbYk.ErropPr = this.errorProvider1;
            this.tbYk.FixedLength = 0;
            this.tbYk.Length = 0;
            this.tbYk.Location = new System.Drawing.Point(120, 77);
            this.tbYk.Max = 99D;
            this.tbYk.MaxNull = 99D;
            this.tbYk.MaxStringLength = 0;
            this.tbYk.MaxStrLength = 0;
            this.tbYk.Min = 0D;
            this.tbYk.MinNull = 0D;
            this.tbYk.MinStringLength = 0;
            this.tbYk.MinStrLength = 0;
            this.tbYk.Name = "tbYk";
            this.tbYk.Precision = 0;
            this.tbYk.Regex = "";
            this.tbYk.Size = new System.Drawing.Size(150, 21);
            this.tbYk.TabIndex = 16;
            this.tbYk.ToolTipValid = this.toolTip1;
            this.tbYk.VaildWarning = "";
            this.tbYk.ValidEable = true;
            this.tbYk.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "压块[t]:";
            // 
            // TappedFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 220);
            this.Controls.Add(this.tbYk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbLadle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturnSteelWeight);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TappedFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "输入出铁信息";
            this.Load += new System.EventHandler(this.TappedFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PxDataValid.PxComboBox cmbLadle;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox tbWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsIronLadles;
        private System.Data.DataTable schemadsIronLadles;
        private System.Data.DataColumn coldsIronLadlesL3DataTableIRONLADLEID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PxDataValid.PxTextBox txtReturnSteelWeight;
        private System.Windows.Forms.Label label1;
        private System.Data.DataColumn coldsIronLadlesL3DataTableReturn_Steel_Weight;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxTextBox tbYk;
        private System.Windows.Forms.Label label5;
    }
}