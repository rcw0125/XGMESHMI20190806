namespace UnitMag.LFMag
{
    partial class LFAreaOperation
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
            this.rbAreaA = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLFID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbAreaB = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdStartProc = new AppSvrHMI.L3Command(this.components);
            this.paramStartArea = new AppSvrHMI.L3CommandParameter();
            this.cmdStopProc = new AppSvrHMI.L3Command(this.components);
            this.cmdSteelLeave = new AppSvrHMI.L3Command(this.components);
            this.paramLeaveArea = new AppSvrHMI.L3CommandParameter();
            this.cmdStartBlow = new AppSvrHMI.L3Command(this.components);
            this.paramStartBlow = new AppSvrHMI.L3CommandParameter();
            this.cmdStopBlow = new AppSvrHMI.L3Command(this.components);
            this.paramStopBlow = new AppSvrHMI.L3CommandParameter();
            this.ucLFAreaBrief1 = new UnitMag.LFMag.ucLFAreaBrief();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // rbAreaA
            // 
            this.rbAreaA.AutoSize = true;
            this.rbAreaA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbAreaA.Location = new System.Drawing.Point(149, 54);
            this.rbAreaA.Name = "rbAreaA";
            this.rbAreaA.Size = new System.Drawing.Size(53, 16);
            this.rbAreaA.TabIndex = 76;
            this.rbAreaA.TabStop = true;
            this.rbAreaA.Text = "　A　";
            this.rbAreaA.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 209);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 54);
            this.flowLayoutPanel1.TabIndex = 91;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(290, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(209, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 72;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 75;
            this.label1.Text = "工位:";
            // 
            // lbLFID
            // 
            this.lbLFID.AutoSize = true;
            this.lbLFID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLFID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLFID.Location = new System.Drawing.Point(63, 9);
            this.lbLFID.Name = "lbLFID";
            this.lbLFID.Size = new System.Drawing.Size(38, 12);
            this.lbLFID.TabIndex = 73;
            this.lbLFID.Text = "炉座:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 73;
            this.label2.Text = "炉座:";
            // 
            // rbAreaB
            // 
            this.rbAreaB.AutoSize = true;
            this.rbAreaB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbAreaB.Location = new System.Drawing.Point(235, 54);
            this.rbAreaB.Name = "rbAreaB";
            this.rbAreaB.Size = new System.Drawing.Size(53, 16);
            this.rbAreaB.TabIndex = 77;
            this.rbAreaB.TabStop = true;
            this.rbAreaB.Text = "　B　";
            this.rbAreaB.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbLFID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 29);
            this.panel3.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 83;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 84;
            this.label10.Text = "XXXXXXX:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 86;
            this.label18.Text = "重量[kg]:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 87;
            this.label16.Text = "计划号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(95, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 75;
            // 
            // cmdStartProc
            // 
            this.cmdStartProc.Adapter = this.Adapter;
            this.cmdStartProc.MergeReturnTarget = false;
            this.cmdStartProc.Method = "StartProcess";
            this.cmdStartProc.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdStartProc.Parameters.Add(this.paramStartArea);
            this.cmdStartProc.ReturnTarget = null;
            this.cmdStartProc.ReturnTargetProperty = null;
            this.cmdStartProc.Trigger = null;
            this.cmdStartProc.TriggerEvent = "Click";
            // 
            // paramStartArea
            // 
            this.paramStartArea.AcceptAfterExecuted = false;
            this.paramStartArea.ConstantValue = null;
            this.paramStartArea.MergeTarget = false;
            this.paramStartArea.SourceFilter = null;
            this.paramStartArea.SourceObject = null;
            this.paramStartArea.SourceProperty = null;
            this.paramStartArea.TargetObject = null;
            this.paramStartArea.TargetProperty = null;
            // 
            // cmdStopProc
            // 
            this.cmdStopProc.Adapter = this.Adapter;
            this.cmdStopProc.MergeReturnTarget = false;
            this.cmdStopProc.Method = "StopProcess";
            this.cmdStopProc.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdStopProc.ReturnTarget = null;
            this.cmdStopProc.ReturnTargetProperty = null;
            this.cmdStopProc.Trigger = null;
            this.cmdStopProc.TriggerEvent = "Click";
            // 
            // cmdSteelLeave
            // 
            this.cmdSteelLeave.Adapter = this.Adapter;
            this.cmdSteelLeave.MergeReturnTarget = false;
            this.cmdSteelLeave.Method = "SteelLeave";
            this.cmdSteelLeave.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdSteelLeave.Parameters.Add(this.paramLeaveArea);
            this.cmdSteelLeave.ReturnTarget = null;
            this.cmdSteelLeave.ReturnTargetProperty = null;
            this.cmdSteelLeave.Trigger = null;
            this.cmdSteelLeave.TriggerEvent = "Click";
            // 
            // paramLeaveArea
            // 
            this.paramLeaveArea.AcceptAfterExecuted = false;
            this.paramLeaveArea.ConstantValue = null;
            this.paramLeaveArea.MergeTarget = false;
            this.paramLeaveArea.SourceFilter = null;
            this.paramLeaveArea.SourceObject = null;
            this.paramLeaveArea.SourceProperty = null;
            this.paramLeaveArea.TargetObject = null;
            this.paramLeaveArea.TargetProperty = null;
            // 
            // cmdStartBlow
            // 
            this.cmdStartBlow.Adapter = this.Adapter;
            this.cmdStartBlow.MergeReturnTarget = false;
            this.cmdStartBlow.Method = "StartBlowing";
            this.cmdStartBlow.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdStartBlow.Parameters.Add(this.paramStartBlow);
            this.cmdStartBlow.ReturnTarget = null;
            this.cmdStartBlow.ReturnTargetProperty = null;
            this.cmdStartBlow.Trigger = null;
            this.cmdStartBlow.TriggerEvent = "Click";
            // 
            // paramStartBlow
            // 
            this.paramStartBlow.AcceptAfterExecuted = false;
            this.paramStartBlow.ConstantValue = null;
            this.paramStartBlow.MergeTarget = false;
            this.paramStartBlow.SourceFilter = null;
            this.paramStartBlow.SourceObject = null;
            this.paramStartBlow.SourceProperty = null;
            this.paramStartBlow.TargetObject = null;
            this.paramStartBlow.TargetProperty = null;
            // 
            // cmdStopBlow
            // 
            this.cmdStopBlow.Adapter = this.Adapter;
            this.cmdStopBlow.MergeReturnTarget = false;
            this.cmdStopBlow.Method = "StopBlowing";
            this.cmdStopBlow.Object = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            this.cmdStopBlow.Parameters.Add(this.paramStopBlow);
            this.cmdStopBlow.ReturnTarget = null;
            this.cmdStopBlow.ReturnTargetProperty = null;
            this.cmdStopBlow.Trigger = null;
            this.cmdStopBlow.TriggerEvent = "Click";
            // 
            // paramStopBlow
            // 
            this.paramStopBlow.AcceptAfterExecuted = false;
            this.paramStopBlow.ConstantValue = null;
            this.paramStopBlow.MergeTarget = false;
            this.paramStopBlow.SourceFilter = null;
            this.paramStopBlow.SourceObject = null;
            this.paramStopBlow.SourceProperty = null;
            this.paramStopBlow.TargetObject = null;
            this.paramStopBlow.TargetProperty = null;
            // 
            // ucLFAreaBrief1
            // 
            this.ucLFAreaBrief1.Adapter = this.Adapter;
            this.ucLFAreaBrief1.Location = new System.Drawing.Point(47, 76);
            this.ucLFAreaBrief1.Margin = new System.Windows.Forms.Padding(0);
            this.ucLFAreaBrief1.Name = "ucLFAreaBrief1";
            this.ucLFAreaBrief1.Size = new System.Drawing.Size(275, 123);
            this.ucLFAreaBrief1.TabIndex = 92;
            // 
            // dsError
            // 
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
            // LFAreaOperation
            // 
            this.AcceptButton = this.btnOK;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 263);
            this.Controls.Add(this.ucLFAreaBrief1);
            this.Controls.Add(this.rbAreaB);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rbAreaA);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Name = "LFAreaOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LF炉操作";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.RadioButton rbAreaA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLFID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAreaB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private ucLFAreaBrief ucLFAreaBrief1;
        private AppSvrHMI.L3Command cmdStartProc;
        private AppSvrHMI.L3CommandParameter paramStartArea;
        private AppSvrHMI.L3Command cmdStopProc;
        private AppSvrHMI.L3Command cmdSteelLeave;
        private AppSvrHMI.L3CommandParameter paramLeaveArea;
        private AppSvrHMI.L3Command cmdStartBlow;
        private AppSvrHMI.L3CommandParameter paramStartBlow;
        private AppSvrHMI.L3Command cmdStopBlow;
        private AppSvrHMI.L3CommandParameter paramStopBlow;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
    }
}