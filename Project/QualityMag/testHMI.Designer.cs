namespace QualityMag
{
    partial class testHMI
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
            this.bsGrid = new System.Windows.Forms.BindingSource(this.components);
            this.dsGrid = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsGrid = new System.Data.DataTable();
            this.coldsGridL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsGridL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsGridL3DataTableProtocol = new System.Data.DataColumn();
            this.txtSteelGradeIndex = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bsGrid
            // 
            this.bsGrid.DataSource = this.dsGrid;
            this.bsGrid.Position = 0;
            // 
            // dsGrid
            // 
            this.dsGrid.AutoLoad = true;
            this.dsGrid.AutoSubscribe = true;
            this.dsGrid.DataSetName = "L3DataSet";
            this.dsGrid.DeleteMethod = null;
            this.dsGrid.InsertMethod = null;
            this.dsGrid.L3DataAdapter = this.Adapter;
            this.dsGrid.LoadEvent = "Click";
            this.dsGrid.LoadTrigger = null;
            this.dsGrid.RefreshValve = 1000;
            this.dsGrid.SourceCommand = null;
            this.dsGrid.SourceCondition = "";
            this.dsGrid.SourceMethod = null;
            this.dsGrid.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsGrid.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsGrid.SubscribeTarget = null;
            this.dsGrid.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGrid});
            this.dsGrid.UpdateEvent = "Click";
            this.dsGrid.UpdateMethod = null;
            this.dsGrid.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsGrid
            // 
            this.schemadsGrid.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGridL3DataTableSteelGradeIndex,
            this.coldsGridL3DataTableSteelGrade,
            this.coldsGridL3DataTableProtocol});
            this.schemadsGrid.TableName = "L3DataTable";
            // 
            // coldsGridL3DataTableSteelGradeIndex
            // 
            this.coldsGridL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsGridL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsGridL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsGridL3DataTableSteelGrade
            // 
            this.coldsGridL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsGridL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsGridL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsGridL3DataTableProtocol
            // 
            this.coldsGridL3DataTableProtocol.Caption = "Protocol";
            this.coldsGridL3DataTableProtocol.ColumnName = "Protocol";
            this.coldsGridL3DataTableProtocol.Namespace = "";
            // 
            // txtSteelGradeIndex
            // 
            this.txtSteelGradeIndex.Location = new System.Drawing.Point(89, 68);
            this.txtSteelGradeIndex.Name = "txtSteelGradeIndex";
            this.txtSteelGradeIndex.Size = new System.Drawing.Size(100, 21);
            this.txtSteelGradeIndex.TabIndex = 0;
            this.txtSteelGradeIndex.TextChanged += new System.EventHandler(this.txtSteelGradeIndex_TextChanged_1);
            // 
            // testHMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.txtSteelGradeIndex);
            this.Name = "testHMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "HMI画面模板";
            this.Text = "HMI画面模板";
            ((System.ComponentModel.ISupportInitialize)(this.bsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGrid;
        private AppSvrHMI.L3DataSet dsGrid;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsGrid;
        private System.Data.DataColumn coldsGridL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsGridL3DataTableSteelGrade;
        private System.Data.DataColumn coldsGridL3DataTableProtocol;
        private System.Windows.Forms.TextBox txtSteelGradeIndex;
    }
}