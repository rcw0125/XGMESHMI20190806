namespace EquipMag.LadleMag
{
    partial class ChooseLadleShowFrm
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.bsPlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlan = new AppSvrHMI.L3DataSet();
            this.schemadsPlan = new System.Data.DataTable();
            this.coldsPlanL3DataTablePlanID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableLadleID = new System.Data.DataColumn();
            this.dsHotLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsHotLadleID = new System.Data.DataTable();
            this.coldsHotLadleIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsHotLadleIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtPlanID = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHotLadleID)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(277, 147);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbLadleID);
            this.tabPage1.Controls.Add(this.txtPlanID);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(269, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "选择信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPlan, "LadleID", true));
            this.cmbLadleID.DataSource = this.dsHotLadleID;
            this.cmbLadleID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.EnableNull = false;
            this.cmbLadleID.ErropPr = null;
            this.cmbLadleID.FormattingEnabled = true;
            this.cmbLadleID.Location = new System.Drawing.Point(89, 62);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleID.TabIndex = 1;
            this.cmbLadleID.ToolTipValid = null;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.Code";
            // 
            // bsPlan
            // 
            this.bsPlan.DataMember = "L3DataTable";
            this.bsPlan.DataSource = this.dsPlan;
            // 
            // dsPlan
            // 
            this.dsPlan.DataSetName = "L3DataSet";
            this.dsPlan.DeleteMethod = null;
            this.dsPlan.InsertMethod = null;
            this.dsPlan.L3DataAdapter = null;
            this.dsPlan.LoadEvent = "Click";
            this.dsPlan.LoadTrigger = null;
            this.dsPlan.RefreshValve = 1000;
            this.dsPlan.SourceCommand = null;
            this.dsPlan.SourceCondition = "";
            this.dsPlan.SourceMethod = null;
            this.dsPlan.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsPlan.SourceURI = null;
            this.dsPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPlan});
            this.dsPlan.UpdateEvent = "Click";
            this.dsPlan.UpdateMethod = null;
            this.dsPlan.UpdateTrigger = null;
            // 
            // schemadsPlan
            // 
            this.schemadsPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPlanL3DataTablePlanID,
            this.coldsPlanL3DataTableLadleID});
            this.schemadsPlan.TableName = "L3DataTable";
            // 
            // coldsPlanL3DataTablePlanID
            // 
            this.coldsPlanL3DataTablePlanID.Caption = "PlanID";
            this.coldsPlanL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsPlanL3DataTablePlanID.Namespace = "";
            // 
            // coldsPlanL3DataTableLadleID
            // 
            this.coldsPlanL3DataTableLadleID.Caption = "LadleID";
            this.coldsPlanL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsPlanL3DataTableLadleID.Namespace = "";
            // 
            // dsHotLadleID
            // 
            this.dsHotLadleID.DataSetName = "L3DataSet";
            this.dsHotLadleID.DeleteMethod = "";
            this.dsHotLadleID.InsertMethod = "";
            this.dsHotLadleID.L3DataAdapter = this.Adapter;
            this.dsHotLadleID.LoadEvent = "Click";
            this.dsHotLadleID.LoadTrigger = null;
            this.dsHotLadleID.RefreshValve = 1000;
            this.dsHotLadleID.SourceCommand = null;
            this.dsHotLadleID.SourceCondition = null;
            this.dsHotLadleID.SourceMethod = "GetAvailableLadle";
            this.dsHotLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHotLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsHotLadleID.SubscribeTarget = null;
            this.dsHotLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHotLadleID});
            this.dsHotLadleID.UpdateEvent = "Click";
            this.dsHotLadleID.UpdateMethod = "";
            this.dsHotLadleID.UpdateTrigger = null;
            // 
            // schemadsHotLadleID
            // 
            this.schemadsHotLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHotLadleIDL3DataTableCode,
            this.coldsHotLadleIDL3DataTableCode_Des});
            this.schemadsHotLadleID.TableName = "L3DataTable";
            // 
            // coldsHotLadleIDL3DataTableCode
            // 
            this.coldsHotLadleIDL3DataTableCode.Caption = "Code";
            this.coldsHotLadleIDL3DataTableCode.ColumnName = "Code";
            this.coldsHotLadleIDL3DataTableCode.Namespace = "";
            // 
            // coldsHotLadleIDL3DataTableCode_Des
            // 
            this.coldsHotLadleIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHotLadleIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHotLadleIDL3DataTableCode_Des.Namespace = "";
            // 
            // txtPlanID
            // 
            this.txtPlanID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPlan, "PlanID", true));
            this.txtPlanID.EnableNull = true;
            this.txtPlanID.ErropPr = null;
            this.txtPlanID.Length = 0;
            this.txtPlanID.Location = new System.Drawing.Point(90, 26);
            this.txtPlanID.Max = 0;
            this.txtPlanID.MaxStrLength = 0;
            this.txtPlanID.Min = 0;
            this.txtPlanID.MinStrLength = 0;
            this.txtPlanID.Name = "txtPlanID";
            this.txtPlanID.Precision = 0;
            this.txtPlanID.ReadOnly = true;
            this.txtPlanID.Size = new System.Drawing.Size(140, 21);
            this.txtPlanID.TabIndex = 32;
            this.txtPlanID.ToolTipValid = null;
            this.txtPlanID.ValidEable = true;
            this.txtPlanID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(37, 32);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 70;
            this.label47.Text = "计划号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(36, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "钢包号:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(180, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(99, 153);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ChooseLadleShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChooseLadleShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择指定钢包";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHotLadleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtPlanID;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxComboBox cmbLadleID;
        private AppSvrHMI.L3DataSet dsHotLadleID;
        private System.Data.DataTable schemadsHotLadleID;
        private System.Data.DataColumn coldsHotLadleIDL3DataTableCode;
        private System.Data.DataColumn coldsHotLadleIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsPlan;
        private System.Data.DataTable schemadsPlan;
        private System.Data.DataColumn coldsPlanL3DataTablePlanID;
        private System.Data.DataColumn coldsPlanL3DataTableLadleID;
        private System.Windows.Forms.BindingSource bsPlan;
    }
}