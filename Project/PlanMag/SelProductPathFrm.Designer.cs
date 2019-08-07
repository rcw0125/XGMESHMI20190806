namespace PlanMag
{
    partial class SelProductPathFrm
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
            this.dsProductPath = new AppSvrHMI.L3DataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnCancel = new System.Windows.Forms.ToolStripButton();
            this.tsBtnOK = new System.Windows.Forms.ToolStripButton();
            this.tsLblPath = new System.Windows.Forms.ToolStripLabel();
            this.tsLblPLANID = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsLBLProductPath = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsLblStandard = new System.Windows.Forms.ToolStripLabel();
            this.cmdSteelPlanPath = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblGZ = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.lblWLDM = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.lblXY = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.lblZZBZ = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductPath)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsProductPath
            // 
            this.dsProductPath.AutoLoad = true;
            this.dsProductPath.AutoSubscribe = false;
            this.dsProductPath.DataSetName = "dsProductPath";
            this.dsProductPath.DeleteMethod = "";
            this.dsProductPath.InsertMethod = "";
            this.dsProductPath.L3DataAdapter = this.Adapter;
            this.dsProductPath.LoadEvent = "Click";
            this.dsProductPath.LoadTrigger = null;
            this.dsProductPath.RefreshValve = 1000;
            this.dsProductPath.SourceCommand = null;
            this.dsProductPath.SourceCondition = "";
            this.dsProductPath.SourceMethod = "";
            this.dsProductPath.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsProductPath.SourceURI = "";
            this.dsProductPath.SubscribeTarget = null;
            this.dsProductPath.UpdateEvent = "Click";
            this.dsProductPath.UpdateMethod = "";
            this.dsProductPath.UpdateTrigger = null;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCancel,
            this.tsBtnOK,
            this.tsLblPath,
            this.tsLblPLANID,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsLBLProductPath,
            this.toolStripSeparator2,
            this.toolStripLabel7,
            this.lblXY,
            this.toolStripSeparator5,
            this.toolStripLabel2,
            this.tsLblStandard,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.lblGZ,
            this.toolStripSeparator4,
            this.toolStripLabel5,
            this.lblWLDM,
            this.toolStripSeparator6,
            this.toolStripLabel4,
            this.lblZZBZ});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1031, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnCancel
            // 
            this.tsBtnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnCancel.Font = new System.Drawing.Font("宋体", 10F);
            this.tsBtnCancel.Image = global::PlanMag.Properties.Resources.取消1;
            this.tsBtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCancel.Name = "tsBtnCancel";
            this.tsBtnCancel.Size = new System.Drawing.Size(92, 33);
            this.tsBtnCancel.Text = "取消(&C)";
            this.tsBtnCancel.Click += new System.EventHandler(this.tsBtnCancel_Click);
            // 
            // tsBtnOK
            // 
            this.tsBtnOK.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnOK.Font = new System.Drawing.Font("宋体", 10F);
            this.tsBtnOK.Image = global::PlanMag.Properties.Resources.确认1;
            this.tsBtnOK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOK.Name = "tsBtnOK";
            this.tsBtnOK.Size = new System.Drawing.Size(92, 33);
            this.tsBtnOK.Text = "确定(&O)";
            this.tsBtnOK.Click += new System.EventHandler(this.tsBtnOK_Click);
            // 
            // tsLblPath
            // 
            this.tsLblPath.Font = new System.Drawing.Font("宋体", 10F);
            this.tsLblPath.Name = "tsLblPath";
            this.tsLblPath.Size = new System.Drawing.Size(63, 33);
            this.tsLblPath.Text = "订单号：";
            // 
            // tsLblPLANID
            // 
            this.tsLblPLANID.Font = new System.Drawing.Font("宋体", 10F);
            this.tsLblPLANID.Name = "tsLblPLANID";
            this.tsLblPLANID.Size = new System.Drawing.Size(21, 33);
            this.tsLblPLANID.Text = "**";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("宋体", 10F);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 33);
            this.toolStripLabel1.Text = "工艺路径：";
            // 
            // tsLBLProductPath
            // 
            this.tsLBLProductPath.Font = new System.Drawing.Font("宋体", 10F);
            this.tsLBLProductPath.Name = "tsLBLProductPath";
            this.tsLBLProductPath.Size = new System.Drawing.Size(21, 33);
            this.tsLBLProductPath.Text = "**";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("宋体", 10F);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(42, 33);
            this.toolStripLabel2.Text = "规格:";
            // 
            // tsLblStandard
            // 
            this.tsLblStandard.Font = new System.Drawing.Font("宋体", 10F);
            this.tsLblStandard.Name = "tsLblStandard";
            this.tsLblStandard.Size = new System.Drawing.Size(21, 33);
            this.tsLblStandard.Text = "**";
            // 
            // cmdSteelPlanPath
            // 
            this.cmdSteelPlanPath.Adapter = this.Adapter;
            this.cmdSteelPlanPath.MergeReturnTarget = false;
            this.cmdSteelPlanPath.Method = "NewCastingPlanGen";
            this.cmdSteelPlanPath.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdSteelPlanPath.Parameters.Add(this.l3CommandParameter5);
            this.cmdSteelPlanPath.Parameters.Add(this.l3CommandParameter6);
            this.cmdSteelPlanPath.ReturnTarget = null;
            this.cmdSteelPlanPath.ReturnTargetProperty = null;
            this.cmdSteelPlanPath.Trigger = null;
            this.cmdSteelPlanPath.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = null;
            this.l3CommandParameter5.SourceObject = this.textBox2;
            this.l3CommandParameter5.SourceProperty = "text";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 21);
            this.textBox2.TabIndex = 7;
            this.textBox2.Visible = false;
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = null;
            this.l3CommandParameter6.SourceObject = this.textBox3;
            this.l3CommandParameter6.SourceProperty = "text";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(177, 280);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 21);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.textBox2;
            this.l3CommandParameter1.SourceProperty = "text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.textBox3;
            this.l3CommandParameter2.SourceProperty = "text";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.textBox2;
            this.l3CommandParameter3.SourceProperty = "text";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 33);
            this.toolStripLabel3.Text = "钢种:";
            // 
            // lblGZ
            // 
            this.lblGZ.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblGZ.Name = "lblGZ";
            this.lblGZ.Size = new System.Drawing.Size(37, 33);
            this.lblGZ.Text = "lblGZ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(69, 33);
            this.toolStripLabel5.Text = "物料代码:";
            // 
            // lblWLDM
            // 
            this.lblWLDM.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblWLDM.Name = "lblWLDM";
            this.lblWLDM.Size = new System.Drawing.Size(62, 33);
            this.lblWLDM.Text = "lblMCode";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(41, 33);
            this.toolStripLabel7.Text = "协议:";
            // 
            // lblXY
            // 
            this.lblXY.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(36, 33);
            this.lblXY.Text = "lblXY";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 33);
            this.toolStripLabel4.Text = "标准:";
            // 
            // lblZZBZ
            // 
            this.lblZZBZ.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblZZBZ.Name = "lblZZBZ";
            this.lblZZBZ.Size = new System.Drawing.Size(52, 33);
            this.lblZZBZ.Text = "lblZZBZ";
            // 
            // SelProductPathFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1031, 344);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SelProductPathFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择浇钢计划工艺路径";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelProductPathFrm_FormClosed);
            this.Load += new System.EventHandler(this.SelProductPathFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsProductPath)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsProductPath;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnOK;
        private System.Windows.Forms.ToolStripButton tsBtnCancel;
        private AppSvrHMI.L3Command cmdSteelPlanPath;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.ToolStripLabel tsLblPath;
        private System.Windows.Forms.ToolStripLabel tsLblPLANID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tsLBLProductPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel tsLblStandard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblGZ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel lblWLDM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel lblXY;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel lblZZBZ;
        // private System.Data.DataColumn coldsProductPathL3DataTable新字段1;
    }
}