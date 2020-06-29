namespace UnitMag.BFMag
{
    partial class ModifyIronWeight
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Coltap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collogtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgrossweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltareweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnetweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtgrossWeight = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttareWeight = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnetWeight = new PxDataValid.PxTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coltap,
            this.collogtime,
            this.colgrossweight,
            this.Coltareweight,
            this.Colnetweight});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(220, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Coltap
            // 
            this.Coltap.DataPropertyName = "materialid";
            this.Coltap.HeaderText = "铁罐号";
            this.Coltap.Name = "Coltap";
            this.Coltap.ReadOnly = true;
            // 
            // collogtime
            // 
            this.collogtime.DataPropertyName = "logtime";
            this.collogtime.HeaderText = "生产时间";
            this.collogtime.Name = "collogtime";
            this.collogtime.ReadOnly = true;
            this.collogtime.Visible = false;
            // 
            // colgrossweight
            // 
            this.colgrossweight.DataPropertyName = "gross_weight";
            this.colgrossweight.HeaderText = "毛重";
            this.colgrossweight.Name = "colgrossweight";
            this.colgrossweight.ReadOnly = true;
            this.colgrossweight.Visible = false;
            // 
            // Coltareweight
            // 
            this.Coltareweight.DataPropertyName = "curr_tare";
            this.Coltareweight.HeaderText = "皮重";
            this.Coltareweight.Name = "Coltareweight";
            this.Coltareweight.ReadOnly = true;
            this.Coltareweight.Visible = false;
            // 
            // Colnetweight
            // 
            this.Colnetweight.DataPropertyName = "net_weight";
            this.Colnetweight.HeaderText = "净重";
            this.Colnetweight.Name = "Colnetweight";
            this.Colnetweight.ReadOnly = true;
            this.Colnetweight.Visible = false;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(371, 75);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 26);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(274, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "出铁时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(290, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "铁次号:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(371, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 26);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(380, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "确认修正";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtgrossWeight
            // 
            this.txtgrossWeight.DisplayPrecision = 0;
            this.txtgrossWeight.EnableNull = false;
            this.txtgrossWeight.ErropPr = null;
            this.txtgrossWeight.FixedLength = 0;
            this.txtgrossWeight.Font = new System.Drawing.Font("宋体", 12F);
            this.txtgrossWeight.Length = 0;
            this.txtgrossWeight.Location = new System.Drawing.Point(371, 121);
            this.txtgrossWeight.Max = 999D;
            this.txtgrossWeight.MaxNull = 999D;
            this.txtgrossWeight.MaxStringLength = 0;
            this.txtgrossWeight.MaxStrLength = 0;
            this.txtgrossWeight.Min = 0D;
            this.txtgrossWeight.MinNull = 0D;
            this.txtgrossWeight.MinStringLength = 0;
            this.txtgrossWeight.MinStrLength = 0;
            this.txtgrossWeight.Name = "txtgrossWeight";
            this.txtgrossWeight.Precision = 0;
            this.txtgrossWeight.Regex = "";
            this.txtgrossWeight.Size = new System.Drawing.Size(188, 26);
            this.txtgrossWeight.TabIndex = 16;
            this.txtgrossWeight.ToolTipValid = null;
            this.txtgrossWeight.VaildWarning = "";
            this.txtgrossWeight.ValidEable = true;
            this.txtgrossWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(306, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "毛重:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(306, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "皮重:";
            // 
            // txttareWeight
            // 
            this.txttareWeight.DisplayPrecision = 0;
            this.txttareWeight.EnableNull = false;
            this.txttareWeight.ErropPr = null;
            this.txttareWeight.FixedLength = 0;
            this.txttareWeight.Font = new System.Drawing.Font("宋体", 12F);
            this.txttareWeight.Length = 0;
            this.txttareWeight.Location = new System.Drawing.Point(371, 163);
            this.txttareWeight.Max = 999D;
            this.txttareWeight.MaxNull = 999D;
            this.txttareWeight.MaxStringLength = 0;
            this.txttareWeight.MaxStrLength = 0;
            this.txttareWeight.Min = 0D;
            this.txttareWeight.MinNull = 0D;
            this.txttareWeight.MinStringLength = 0;
            this.txttareWeight.MinStrLength = 0;
            this.txttareWeight.Name = "txttareWeight";
            this.txttareWeight.Precision = 0;
            this.txttareWeight.Regex = "";
            this.txttareWeight.Size = new System.Drawing.Size(188, 26);
            this.txttareWeight.TabIndex = 16;
            this.txttareWeight.ToolTipValid = null;
            this.txttareWeight.VaildWarning = "";
            this.txttareWeight.ValidEable = true;
            this.txttareWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(306, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "净重:";
            // 
            // txtnetWeight
            // 
            this.txtnetWeight.DisplayPrecision = 0;
            this.txtnetWeight.EnableNull = false;
            this.txtnetWeight.ErropPr = null;
            this.txtnetWeight.FixedLength = 0;
            this.txtnetWeight.Font = new System.Drawing.Font("宋体", 12F);
            this.txtnetWeight.Length = 0;
            this.txtnetWeight.Location = new System.Drawing.Point(371, 206);
            this.txtnetWeight.Max = 999D;
            this.txtnetWeight.MaxNull = 999D;
            this.txtnetWeight.MaxStringLength = 0;
            this.txtnetWeight.MaxStrLength = 0;
            this.txtnetWeight.Min = 0D;
            this.txtnetWeight.MinNull = 0D;
            this.txtnetWeight.MinStringLength = 0;
            this.txtnetWeight.MinStrLength = 0;
            this.txtnetWeight.Name = "txtnetWeight";
            this.txtnetWeight.Precision = 0;
            this.txtnetWeight.Regex = "";
            this.txtnetWeight.Size = new System.Drawing.Size(188, 26);
            this.txtnetWeight.TabIndex = 16;
            this.txtnetWeight.ToolTipValid = null;
            this.txtnetWeight.VaildWarning = "";
            this.txtnetWeight.ValidEable = true;
            this.txtnetWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // ModifyIronWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 431);
            this.Controls.Add(this.txtnetWeight);
            this.Controls.Add(this.txttareWeight);
            this.Controls.Add(this.txtgrossWeight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModifyIronWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "出铁时间修正";
            this.Text = "铁次重量修正";
            this.Load += new System.EventHandler(this.ModifyIronTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltap;
        private System.Windows.Forms.DataGridViewTextBoxColumn collogtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgrossweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltareweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnetweight;
        private PxDataValid.PxTextBox txtgrossWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxTextBox txttareWeight;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxTextBox txtnetWeight;
    }
}