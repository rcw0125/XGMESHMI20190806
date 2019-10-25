namespace UnitMag.BOFMag
{
    partial class Bofwdjs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbtemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbheatid = new System.Windows.Forms.TextBox();
            this.lbtemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lbcurtemp = new System.Windows.Forms.Label();
            this.wdmodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lactemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scrapweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ykweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irontempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shihuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baiyunhuiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baiyunshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shihuishi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shaojiekuang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cgfrj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liuzha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.o2time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sxzweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlzweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qgzweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wdmodelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 476);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tbtemp);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(451, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "温度预测";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(24, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbtemp
            // 
            this.tbtemp.Location = new System.Drawing.Point(200, 42);
            this.tbtemp.Margin = new System.Windows.Forms.Padding(4);
            this.tbtemp.Name = "tbtemp";
            this.tbtemp.Size = new System.Drawing.Size(84, 26);
            this.tbtemp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "温度:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbheatid);
            this.groupBox1.Controls.Add(this.lbcurtemp);
            this.groupBox1.Controls.Add(this.lbtemp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(43, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(306, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "炉次信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbheatid
            // 
            this.tbheatid.Location = new System.Drawing.Point(74, 21);
            this.tbheatid.Margin = new System.Windows.Forms.Padding(4);
            this.tbheatid.Name = "tbheatid";
            this.tbheatid.Size = new System.Drawing.Size(115, 26);
            this.tbheatid.TabIndex = 1;
            // 
            // lbtemp
            // 
            this.lbtemp.AutoSize = true;
            this.lbtemp.Font = new System.Drawing.Font("宋体", 14F);
            this.lbtemp.ForeColor = System.Drawing.Color.Red;
            this.lbtemp.Location = new System.Drawing.Point(122, 80);
            this.lbtemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(19, 19);
            this.lbtemp.TabIndex = 0;
            this.lbtemp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "上一炉温度:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatidDataGridViewTextBoxColumn,
            this.lactemp,
            this.ironweightDataGridViewTextBoxColumn,
            this.scrapweightDataGridViewTextBoxColumn,
            this.ykweight,
            this.cDataGridViewTextBoxColumn,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.irontempDataGridViewTextBoxColumn,
            this.shihuiDataGridViewTextBoxColumn,
            this.baiyunhuiDataGridViewTextBoxColumn,
            this.baiyunshiDataGridViewTextBoxColumn,
            this.shihuishi,
            this.shaojiekuang,
            this.cgfrj,
            this.zdc,
            this.liuzha,
            this.o2time,
            this.sxzweight,
            this.tlzweight,
            this.qgzweight});
            this.dataGridView1.DataSource = this.wdmodelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "本炉温度:";
            // 
            // lbcurtemp
            // 
            this.lbcurtemp.AutoSize = true;
            this.lbcurtemp.Font = new System.Drawing.Font("宋体", 14F);
            this.lbcurtemp.ForeColor = System.Drawing.Color.Red;
            this.lbcurtemp.Location = new System.Drawing.Point(122, 119);
            this.lbcurtemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcurtemp.Name = "lbcurtemp";
            this.lbcurtemp.Size = new System.Drawing.Size(19, 19);
            this.lbcurtemp.TabIndex = 0;
            this.lbcurtemp.Text = "0";
            // 
            // wdmodelBindingSource
            // 
            this.wdmodelBindingSource.DataSource = typeof(UnitMag.BOFMag.wdmodel);
            // 
            // heatidDataGridViewTextBoxColumn
            // 
            this.heatidDataGridViewTextBoxColumn.DataPropertyName = "heatid";
            this.heatidDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatidDataGridViewTextBoxColumn.Name = "heatidDataGridViewTextBoxColumn";
            // 
            // lactemp
            // 
            this.lactemp.DataPropertyName = "lactemp";
            this.lactemp.HeaderText = "拉碳温度";
            this.lactemp.Name = "lactemp";
            this.lactemp.Visible = false;
            this.lactemp.Width = 70;
            // 
            // ironweightDataGridViewTextBoxColumn
            // 
            this.ironweightDataGridViewTextBoxColumn.DataPropertyName = "ironweight";
            this.ironweightDataGridViewTextBoxColumn.HeaderText = "铁水重量";
            this.ironweightDataGridViewTextBoxColumn.Name = "ironweightDataGridViewTextBoxColumn";
            this.ironweightDataGridViewTextBoxColumn.Width = 70;
            // 
            // scrapweightDataGridViewTextBoxColumn
            // 
            this.scrapweightDataGridViewTextBoxColumn.DataPropertyName = "scrapweight";
            this.scrapweightDataGridViewTextBoxColumn.HeaderText = "废钢重量";
            this.scrapweightDataGridViewTextBoxColumn.Name = "scrapweightDataGridViewTextBoxColumn";
            this.scrapweightDataGridViewTextBoxColumn.Width = 70;
            // 
            // ykweight
            // 
            this.ykweight.DataPropertyName = "ykweight";
            this.ykweight.HeaderText = "压块";
            this.ykweight.Name = "ykweight";
            this.ykweight.Width = 70;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "c";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.Width = 50;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 50;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 50;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "p";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 50;
            // 
            // irontempDataGridViewTextBoxColumn
            // 
            this.irontempDataGridViewTextBoxColumn.DataPropertyName = "irontemp";
            this.irontempDataGridViewTextBoxColumn.HeaderText = "铁水温度";
            this.irontempDataGridViewTextBoxColumn.Name = "irontempDataGridViewTextBoxColumn";
            this.irontempDataGridViewTextBoxColumn.Width = 70;
            // 
            // shihuiDataGridViewTextBoxColumn
            // 
            this.shihuiDataGridViewTextBoxColumn.DataPropertyName = "shihui";
            this.shihuiDataGridViewTextBoxColumn.HeaderText = "石灰";
            this.shihuiDataGridViewTextBoxColumn.Name = "shihuiDataGridViewTextBoxColumn";
            this.shihuiDataGridViewTextBoxColumn.Width = 60;
            // 
            // baiyunhuiDataGridViewTextBoxColumn
            // 
            this.baiyunhuiDataGridViewTextBoxColumn.DataPropertyName = "baiyunhui";
            this.baiyunhuiDataGridViewTextBoxColumn.HeaderText = "白云灰";
            this.baiyunhuiDataGridViewTextBoxColumn.Name = "baiyunhuiDataGridViewTextBoxColumn";
            this.baiyunhuiDataGridViewTextBoxColumn.Width = 70;
            // 
            // baiyunshiDataGridViewTextBoxColumn
            // 
            this.baiyunshiDataGridViewTextBoxColumn.DataPropertyName = "baiyunshi";
            this.baiyunshiDataGridViewTextBoxColumn.HeaderText = "白云石";
            this.baiyunshiDataGridViewTextBoxColumn.Name = "baiyunshiDataGridViewTextBoxColumn";
            this.baiyunshiDataGridViewTextBoxColumn.Width = 70;
            // 
            // shihuishi
            // 
            this.shihuishi.DataPropertyName = "shihuishi";
            this.shihuishi.HeaderText = "石灰石";
            this.shihuishi.Name = "shihuishi";
            this.shihuishi.Width = 70;
            // 
            // shaojiekuang
            // 
            this.shaojiekuang.DataPropertyName = "shaojiekuang";
            this.shaojiekuang.HeaderText = "烧结矿";
            this.shaojiekuang.Name = "shaojiekuang";
            this.shaojiekuang.Width = 70;
            // 
            // cgfrj
            // 
            this.cgfrj.DataPropertyName = "cgfrj";
            this.cgfrj.HeaderText = "碳硅发热剂";
            this.cgfrj.Name = "cgfrj";
            this.cgfrj.Width = 70;
            // 
            // zdc
            // 
            this.zdc.DataPropertyName = "zdc";
            this.zdc.HeaderText = "终点C";
            this.zdc.Name = "zdc";
            this.zdc.Width = 70;
            // 
            // liuzha
            // 
            this.liuzha.DataPropertyName = "liuzha";
            this.liuzha.HeaderText = "留渣";
            this.liuzha.Name = "liuzha";
            this.liuzha.Width = 55;
            // 
            // o2time
            // 
            this.o2time.DataPropertyName = "o2time";
            this.o2time.HeaderText = "供氧时间";
            this.o2time.Name = "o2time";
            this.o2time.Width = 70;
            // 
            // sxzweight
            // 
            this.sxzweight.DataPropertyName = "sxzweight";
            this.sxzweight.HeaderText = "三选钢渣";
            this.sxzweight.Name = "sxzweight";
            this.sxzweight.Width = 70;
            // 
            // tlzweight
            // 
            this.tlzweight.DataPropertyName = "tlzweight";
            this.tlzweight.HeaderText = "脱硫渣";
            this.tlzweight.Name = "tlzweight";
            this.tlzweight.Width = 70;
            // 
            // qgzweight
            // 
            this.qgzweight.DataPropertyName = "qgzweight";
            this.qgzweight.HeaderText = "切割渣";
            this.qgzweight.Name = "qgzweight";
            this.qgzweight.Width = 70;
            // 
            // Bofwdjs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 476);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bofwdjs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转炉温度计算";
            this.Load += new System.EventHandler(this.LFcfjs_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wdmodelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbheatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ztjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sivalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mncalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crcalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource wdmodelBindingSource;
        private System.Windows.Forms.TextBox tbtemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Label lbcurtemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lactemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scrapweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ykweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irontempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shihuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baiyunhuiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baiyunshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shihuishi;
        private System.Windows.Forms.DataGridViewTextBoxColumn shaojiekuang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cgfrj;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdc;
        private System.Windows.Forms.DataGridViewTextBoxColumn liuzha;
        private System.Windows.Forms.DataGridViewTextBoxColumn o2time;
        private System.Windows.Forms.DataGridViewTextBoxColumn sxzweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlzweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn qgzweight;
    }
}