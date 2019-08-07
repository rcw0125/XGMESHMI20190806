namespace BaseDataMag
{
    partial class EQMaterialMagShowFrm
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
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsMainL3DataTableMatName = new System.Data.DataColumn();
            this.coldsMainL3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.coldsMainL3DataTableMatGroup_Des = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtGroupCode = new System.Windows.Forms.TextBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMatName = new System.Windows.Forms.ComboBox();
            this.bsGroup = new System.Windows.Forms.BindingSource(this.components);
            this.dsGroup = new AppSvrHMI.L3DataSet();
            this.schemadsGroup = new System.Data.DataTable();
            this.coldsGroupL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsGroupL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.cmbGroupDes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmatFac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsMatName = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Group = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.bsLadleFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsTundishFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsMoldFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsVacTubeFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsLanceFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsIronLadeFac = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoldFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVacTubeFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLanceFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadeFac)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = true;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableMatFactory,
            this.coldsMainL3DataTableMatName,
            this.coldsMainL3DataTableMatGroup_Code,
            this.coldsMainL3DataTableMatGroup_Des});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableMatFactory
            // 
            this.coldsMainL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsMainL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsMainL3DataTableMatFactory.Namespace = "";
            // 
            // coldsMainL3DataTableMatName
            // 
            this.coldsMainL3DataTableMatName.Caption = "MatName";
            this.coldsMainL3DataTableMatName.ColumnName = "MatName";
            this.coldsMainL3DataTableMatName.Namespace = "";
            // 
            // coldsMainL3DataTableMatGroup_Code
            // 
            this.coldsMainL3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsMainL3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsMainL3DataTableMatGroup_Code.Namespace = "";
            // 
            // coldsMainL3DataTableMatGroup_Des
            // 
            this.coldsMainL3DataTableMatGroup_Des.Caption = "MatGroup_Des";
            this.coldsMainL3DataTableMatGroup_Des.ColumnName = "MatGroup_Des";
            this.coldsMainL3DataTableMatGroup_Des.Namespace = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 199);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(441, 75);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(316, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(235, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
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
            this.tabControl1.Size = new System.Drawing.Size(441, 199);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtGroupCode);
            this.tabPage1.Controls.Add(this.cmbMatName);
            this.tabPage1.Controls.Add(this.cmbGroupDes);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtmatFac);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(433, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "维护信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtGroupCode
            // 
            this.txtGroupCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MatGroup_Code", true));
            this.txtGroupCode.Location = new System.Drawing.Point(146, 51);
            this.txtGroupCode.Name = "txtGroupCode";
            this.txtGroupCode.ReadOnly = true;
            this.txtGroupCode.Size = new System.Drawing.Size(216, 21);
            this.txtGroupCode.TabIndex = 3;
            this.txtGroupCode.TextChanged += new System.EventHandler(this.txtGroupCode_TextChanged);
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // cmbMatName
            // 
            this.cmbMatName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MatName", true));
            this.cmbMatName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatName.FormattingEnabled = true;
            this.cmbMatName.Location = new System.Drawing.Point(146, 79);
            this.cmbMatName.Name = "cmbMatName";
            this.cmbMatName.Size = new System.Drawing.Size(216, 20);
            this.cmbMatName.TabIndex = 2;
            // 
            // bsGroup
            // 
            this.bsGroup.DataMember = "L3DataTable";
            this.bsGroup.DataSource = this.dsGroup;
            // 
            // dsGroup
            // 
            this.dsGroup.AutoSubscribe = true;
            this.dsGroup.DataSetName = "L3DataSet";
            this.dsGroup.DeleteMethod = null;
            this.dsGroup.InsertMethod = null;
            this.dsGroup.L3DataAdapter = this.Adapter;
            this.dsGroup.LoadEvent = "Click";
            this.dsGroup.LoadTrigger = null;
            this.dsGroup.RefreshValve = 1000;
            this.dsGroup.SourceCommand = null;
            this.dsGroup.SourceCondition = "";
            this.dsGroup.SourceMethod = "select Code_Group,Code_Group_Des from CBase_All_Code  where Code_function_group =" +
                "\'EquipGroup\' and Code_Group is not null group by Code_Group ,Code_Group_Des";
            this.dsGroup.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsGroup.SourceURI = "";
            this.dsGroup.SubscribeTarget = null;
            this.dsGroup.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGroup});
            this.dsGroup.UpdateEvent = "Click";
            this.dsGroup.UpdateMethod = null;
            this.dsGroup.UpdateTrigger = null;
            // 
            // schemadsGroup
            // 
            this.schemadsGroup.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGroupL3DataTableCode_Group,
            this.coldsGroupL3DataTableCode_Group_Des});
            this.schemadsGroup.TableName = "L3DataTable";
            // 
            // coldsGroupL3DataTableCode_Group
            // 
            this.coldsGroupL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsGroupL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsGroupL3DataTableCode_Group.Namespace = "";
            // 
            // coldsGroupL3DataTableCode_Group_Des
            // 
            this.coldsGroupL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsGroupL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsGroupL3DataTableCode_Group_Des.Namespace = "";
            // 
            // cmbGroupDes
            // 
            this.cmbGroupDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MatGroup_Des", true));
            this.cmbGroupDes.DataSource = this.bsGroup;
            this.cmbGroupDes.DisplayMember = "Code_Group_Des";
            this.cmbGroupDes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupDes.FormattingEnabled = true;
            this.cmbGroupDes.Location = new System.Drawing.Point(146, 22);
            this.cmbGroupDes.Name = "cmbGroupDes";
            this.cmbGroupDes.Size = new System.Drawing.Size(216, 20);
            this.cmbGroupDes.TabIndex = 2;
            this.cmbGroupDes.ValueMember = "Code_Group_Des";
            this.cmbGroupDes.SelectedIndexChanged += new System.EventHandler(this.cmbGroupDes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "材料名称:";
            // 
            // txtmatFac
            // 
            this.txtmatFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MatFactory", true));
            this.txtmatFac.Location = new System.Drawing.Point(146, 107);
            this.txtmatFac.Name = "txtmatFac";
            this.txtmatFac.Size = new System.Drawing.Size(216, 21);
            this.txtmatFac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "工器具代码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "工器具名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "材料厂家:";
            // 
            // dsMatName
            // 
            this.dsMatName.AutoSubscribe = true;
            this.dsMatName.DataSetName = "L3DataSet";
            this.dsMatName.DeleteMethod = null;
            this.dsMatName.InsertMethod = null;
            this.dsMatName.L3DataAdapter = this.Adapter;
            this.dsMatName.LoadEvent = "Click";
            this.dsMatName.LoadTrigger = null;
            this.dsMatName.RefreshValve = 1000;
            this.dsMatName.SourceCommand = null;
            this.dsMatName.SourceCondition = "";
            this.dsMatName.SourceMethod = "select * from CBase_All_Code  where Code_function_group =\'EquipGroup\'";
            this.dsMatName.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsMatName.SourceURI = "";
            this.dsMatName.SubscribeTarget = null;
            this.dsMatName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsMatName.UpdateEvent = "Click";
            this.dsMatName.UpdateMethod = null;
            this.dsMatName.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode,
            this.coll3DataSet1L3DataTableCode_Des,
            this.coll3DataSet1L3DataTableCode_Group,
            this.coll3DataSet1L3DataTableCode_Group_Des,
            this.coll3DataSet1L3DataTableCode_Function_Group});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode
            // 
            this.coll3DataSet1L3DataTableCode.Caption = "Code";
            this.coll3DataSet1L3DataTableCode.ColumnName = "Code";
            this.coll3DataSet1L3DataTableCode.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Group
            // 
            this.coll3DataSet1L3DataTableCode_Group.Caption = "Code_Group";
            this.coll3DataSet1L3DataTableCode_Group.ColumnName = "Code_Group";
            this.coll3DataSet1L3DataTableCode_Group.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Group_Des
            // 
            this.coll3DataSet1L3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coll3DataSet1L3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coll3DataSet1L3DataTableCode_Group_Des.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Function_Group
            // 
            this.coll3DataSet1L3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coll3DataSet1L3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coll3DataSet1L3DataTableCode_Function_Group.Namespace = "";
            // 
            // bsLadleFac
            // 
            this.bsLadleFac.DataMember = "L3DataTable";
            this.bsLadleFac.DataSource = this.dsMatName;
            this.bsLadleFac.Filter = "Code_Group = \'LadleFac\'";
            // 
            // bsTundishFac
            // 
            this.bsTundishFac.DataMember = "L3DataTable";
            this.bsTundishFac.DataSource = this.dsMatName;
            this.bsTundishFac.Filter = "Code_Group = \'TundishFac\'";
            // 
            // bsMoldFac
            // 
            this.bsMoldFac.DataMember = "L3DataTable";
            this.bsMoldFac.DataSource = this.dsMatName;
            this.bsMoldFac.Filter = "Code_Group = \'MoldFac\'";
            // 
            // bsVacTubeFac
            // 
            this.bsVacTubeFac.DataMember = "L3DataTable";
            this.bsVacTubeFac.DataSource = this.dsMatName;
            this.bsVacTubeFac.Filter = "Code_Group = \'VacTubeFac\'";
            // 
            // bsLanceFac
            // 
            this.bsLanceFac.DataMember = "L3DataTable";
            this.bsLanceFac.DataSource = this.dsMatName;
            this.bsLanceFac.Filter = "Code_Group = \'LanceFac\'";
            // 
            // bsIronLadeFac
            // 
            this.bsIronLadeFac.DataMember = "L3DataTable";
            this.bsIronLadeFac.DataSource = this.dsMatName;
            this.bsIronLadeFac.Filter = "Code_Group = \'IronLadleFac\'";
            // 
            // EQMaterialMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 274);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EQMaterialMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "工器具材料厂家及材料名称维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EQMaterialMagShowFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoldFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVacTubeFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLanceFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadeFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbGroupDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatFac;
        private System.Windows.Forms.ComboBox cmbMatName;
        private System.Windows.Forms.Label label3;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableMatFactory;
        private System.Data.DataColumn coldsMainL3DataTableMatName;
        private System.Data.DataColumn coldsMainL3DataTableMatGroup_Code;
        private System.Data.DataColumn coldsMainL3DataTableMatGroup_Des;
        private AppSvrHMI.L3DataSet dsGroup;
        private System.Data.DataTable schemadsGroup;
        private System.Data.DataColumn coldsGroupL3DataTableCode_Group;
        private System.Data.DataColumn coldsGroupL3DataTableCode_Group_Des;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsGroup;
        private AppSvrHMI.L3DataSet dsMatName;
        private System.Windows.Forms.BindingSource bsLadleFac;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Group;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Group_Des;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Function_Group;
        private System.Windows.Forms.BindingSource bsTundishFac;
        private System.Windows.Forms.BindingSource bsMoldFac;
        private System.Windows.Forms.BindingSource bsVacTubeFac;
        private System.Windows.Forms.BindingSource bsLanceFac;
        private System.Windows.Forms.BindingSource bsIronLadeFac;
        private System.Windows.Forms.TextBox txtGroupCode;
    }
}