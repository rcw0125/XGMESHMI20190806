namespace NCTelDataMag
{
    partial class HuiTui
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dsCBloom_Input = new AppSvrHMI.L3DataSet();
            this.schemadsModel = new System.Data.DataTable();
            this.coldsModelL3DataTableGUID = new System.Data.DataColumn();
            this.coldsModelL3DataTableName = new System.Data.DataColumn();
            this.coldsModelL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsModelL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsModelL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsModelL3DataTableAmount = new System.Data.DataColumn();
            this.coldsModelL3DataTableType = new System.Data.DataColumn();
            this.coldsModelL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsModelL3DataTableReason = new System.Data.DataColumn();
            this.coldsModelL3DataTableSource = new System.Data.DataColumn();
            this.coldsModelL3DataTableOperator = new System.Data.DataColumn();
            this.coldsModelL3DataTableShift = new System.Data.DataColumn();
            this.coldsModelL3DataTableTeam = new System.Data.DataColumn();
            this.coldsModelL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsModelL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsModelL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsModelL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsModelL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsModelL3DataTableCur_Section_ID = new System.Data.DataColumn();
            this.coldsModelL3DataTableCur_Bay_ID = new System.Data.DataColumn();
            this.coldsModelL3DataTableCur_Pile_ID = new System.Data.DataColumn();
            this.coldsModelL3DataTableCur_Layer_ID = new System.Data.DataColumn();
            this.coldsModelL3DataTableCur_Seq_ID = new System.Data.DataColumn();
            this.coldsModelL3DataTableLength = new System.Data.DataColumn();
            this.coldsModelL3DataTableWidth = new System.Data.DataColumn();
            this.coldsModelL3DataTableThickness = new System.Data.DataColumn();
            this.coldsModelL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsModelL3DataTableRight_Weight = new System.Data.DataColumn();
            this.coldsModelL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsModelL3DataTableWrong_Weight = new System.Data.DataColumn();
            this.panel1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCBloom_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModel)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hmiRootPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 573);
            this.panel1.TabIndex = 1;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.textBox3);
            this.hmiRootPanel1.Controls.Add(this.button3);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(792, 573);
            this.hmiRootPanel1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 21);
            this.textBox3.TabIndex = 70;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 69;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dsCBloom_Input
            // 
            this.dsCBloom_Input.AutoLoad = true;
            this.dsCBloom_Input.AutoSubscribe = true;
            this.dsCBloom_Input.DataSetName = "L3DataSet";
            this.dsCBloom_Input.DeleteMethod = null;
            this.dsCBloom_Input.InsertMethod = null;
            this.dsCBloom_Input.L3DataAdapter = this.Adapter;
            this.dsCBloom_Input.LoadEvent = "";
            this.dsCBloom_Input.LoadTrigger = this.Adapter;
            this.dsCBloom_Input.RefreshValve = 1000;
            this.dsCBloom_Input.SourceCommand = null;
            this.dsCBloom_Input.SourceCondition = "";
            this.dsCBloom_Input.SourceMethod = "";
            this.dsCBloom_Input.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCBloom_Input.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Input_Log";
            this.dsCBloom_Input.SubscribeTarget = null;
            this.dsCBloom_Input.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsModel});
            this.dsCBloom_Input.UpdateEvent = "";
            this.dsCBloom_Input.UpdateMethod = null;
            this.dsCBloom_Input.UpdateTrigger = null;
            // 
            // schemadsModel
            // 
            this.schemadsModel.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsModelL3DataTableGUID,
            this.coldsModelL3DataTableName,
            this.coldsModelL3DataTableMaterialType,
            this.coldsModelL3DataTableMaterialID,
            this.coldsModelL3DataTableLogDate,
            this.coldsModelL3DataTableAmount,
            this.coldsModelL3DataTableType,
            this.coldsModelL3DataTableStoreAreaID,
            this.coldsModelL3DataTableReason,
            this.coldsModelL3DataTableSource,
            this.coldsModelL3DataTableOperator,
            this.coldsModelL3DataTableShift,
            this.coldsModelL3DataTableTeam,
            this.coldsModelL3DataTableBloom_Count,
            this.coldsModelL3DataTableWaster_Count,
            this.coldsModelL3DataTableWrong_Count,
            this.coldsModelL3DataTableRight_Count,
            this.coldsModelL3DataTableSteelGradeIndex,
            this.coldsModelL3DataTableCur_Section_ID,
            this.coldsModelL3DataTableCur_Bay_ID,
            this.coldsModelL3DataTableCur_Pile_ID,
            this.coldsModelL3DataTableCur_Layer_ID,
            this.coldsModelL3DataTableCur_Seq_ID,
            this.coldsModelL3DataTableLength,
            this.coldsModelL3DataTableWidth,
            this.coldsModelL3DataTableThickness,
            this.coldsModelL3DataTableCal_Weight,
            this.coldsModelL3DataTableRight_Weight,
            this.coldsModelL3DataTableWaster_Weight,
            this.coldsModelL3DataTableWrong_Weight});
            this.schemadsModel.TableName = "L3DataTable";
            // 
            // coldsModelL3DataTableGUID
            // 
            this.coldsModelL3DataTableGUID.Caption = "GUID";
            this.coldsModelL3DataTableGUID.ColumnName = "GUID";
            this.coldsModelL3DataTableGUID.Namespace = "";
            // 
            // coldsModelL3DataTableName
            // 
            this.coldsModelL3DataTableName.Caption = "Name";
            this.coldsModelL3DataTableName.ColumnName = "Name";
            this.coldsModelL3DataTableName.Namespace = "";
            // 
            // coldsModelL3DataTableMaterialType
            // 
            this.coldsModelL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsModelL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsModelL3DataTableMaterialType.Namespace = "";
            // 
            // coldsModelL3DataTableMaterialID
            // 
            this.coldsModelL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsModelL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsModelL3DataTableMaterialID.Namespace = "";
            // 
            // coldsModelL3DataTableLogDate
            // 
            this.coldsModelL3DataTableLogDate.Caption = "LogDate";
            this.coldsModelL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsModelL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsModelL3DataTableLogDate.Namespace = "";
            // 
            // coldsModelL3DataTableAmount
            // 
            this.coldsModelL3DataTableAmount.Caption = "Amount";
            this.coldsModelL3DataTableAmount.ColumnName = "Amount";
            this.coldsModelL3DataTableAmount.DataType = typeof(double);
            this.coldsModelL3DataTableAmount.Namespace = "";
            // 
            // coldsModelL3DataTableType
            // 
            this.coldsModelL3DataTableType.Caption = "Type";
            this.coldsModelL3DataTableType.ColumnName = "Type";
            this.coldsModelL3DataTableType.DataType = typeof(int);
            this.coldsModelL3DataTableType.Namespace = "";
            // 
            // coldsModelL3DataTableStoreAreaID
            // 
            this.coldsModelL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsModelL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsModelL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsModelL3DataTableReason
            // 
            this.coldsModelL3DataTableReason.Caption = "Reason";
            this.coldsModelL3DataTableReason.ColumnName = "Reason";
            this.coldsModelL3DataTableReason.Namespace = "";
            // 
            // coldsModelL3DataTableSource
            // 
            this.coldsModelL3DataTableSource.Caption = "Source";
            this.coldsModelL3DataTableSource.ColumnName = "Source";
            this.coldsModelL3DataTableSource.Namespace = "";
            // 
            // coldsModelL3DataTableOperator
            // 
            this.coldsModelL3DataTableOperator.Caption = "Operator";
            this.coldsModelL3DataTableOperator.ColumnName = "Operator";
            this.coldsModelL3DataTableOperator.Namespace = "";
            // 
            // coldsModelL3DataTableShift
            // 
            this.coldsModelL3DataTableShift.Caption = "Shift";
            this.coldsModelL3DataTableShift.ColumnName = "Shift";
            this.coldsModelL3DataTableShift.Namespace = "";
            // 
            // coldsModelL3DataTableTeam
            // 
            this.coldsModelL3DataTableTeam.Caption = "Team";
            this.coldsModelL3DataTableTeam.ColumnName = "Team";
            this.coldsModelL3DataTableTeam.Namespace = "";
            // 
            // coldsModelL3DataTableBloom_Count
            // 
            this.coldsModelL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsModelL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsModelL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsModelL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsModelL3DataTableWaster_Count
            // 
            this.coldsModelL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsModelL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsModelL3DataTableWaster_Count.DataType = typeof(double);
            this.coldsModelL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsModelL3DataTableWrong_Count
            // 
            this.coldsModelL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsModelL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsModelL3DataTableWrong_Count.DataType = typeof(int);
            this.coldsModelL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsModelL3DataTableRight_Count
            // 
            this.coldsModelL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsModelL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsModelL3DataTableRight_Count.DataType = typeof(int);
            this.coldsModelL3DataTableRight_Count.Namespace = "";
            // 
            // coldsModelL3DataTableSteelGradeIndex
            // 
            this.coldsModelL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsModelL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsModelL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsModelL3DataTableCur_Section_ID
            // 
            this.coldsModelL3DataTableCur_Section_ID.Caption = "Cur_Section_ID";
            this.coldsModelL3DataTableCur_Section_ID.ColumnName = "Cur_Section_ID";
            this.coldsModelL3DataTableCur_Section_ID.Namespace = "";
            // 
            // coldsModelL3DataTableCur_Bay_ID
            // 
            this.coldsModelL3DataTableCur_Bay_ID.Caption = "Cur_Bay_ID";
            this.coldsModelL3DataTableCur_Bay_ID.ColumnName = "Cur_Bay_ID";
            this.coldsModelL3DataTableCur_Bay_ID.Namespace = "";
            // 
            // coldsModelL3DataTableCur_Pile_ID
            // 
            this.coldsModelL3DataTableCur_Pile_ID.Caption = "Cur_Pile_ID";
            this.coldsModelL3DataTableCur_Pile_ID.ColumnName = "Cur_Pile_ID";
            this.coldsModelL3DataTableCur_Pile_ID.Namespace = "";
            // 
            // coldsModelL3DataTableCur_Layer_ID
            // 
            this.coldsModelL3DataTableCur_Layer_ID.Caption = "Cur_Layer_ID";
            this.coldsModelL3DataTableCur_Layer_ID.ColumnName = "Cur_Layer_ID";
            this.coldsModelL3DataTableCur_Layer_ID.Namespace = "";
            // 
            // coldsModelL3DataTableCur_Seq_ID
            // 
            this.coldsModelL3DataTableCur_Seq_ID.Caption = "Cur_Seq_ID";
            this.coldsModelL3DataTableCur_Seq_ID.ColumnName = "Cur_Seq_ID";
            this.coldsModelL3DataTableCur_Seq_ID.DataType = typeof(int);
            this.coldsModelL3DataTableCur_Seq_ID.Namespace = "";
            // 
            // coldsModelL3DataTableLength
            // 
            this.coldsModelL3DataTableLength.Caption = "Length";
            this.coldsModelL3DataTableLength.ColumnName = "Length";
            this.coldsModelL3DataTableLength.DataType = typeof(int);
            this.coldsModelL3DataTableLength.Namespace = "";
            // 
            // coldsModelL3DataTableWidth
            // 
            this.coldsModelL3DataTableWidth.Caption = "Width";
            this.coldsModelL3DataTableWidth.ColumnName = "Width";
            this.coldsModelL3DataTableWidth.DataType = typeof(int);
            this.coldsModelL3DataTableWidth.Namespace = "";
            // 
            // coldsModelL3DataTableThickness
            // 
            this.coldsModelL3DataTableThickness.Caption = "Thickness";
            this.coldsModelL3DataTableThickness.ColumnName = "Thickness";
            this.coldsModelL3DataTableThickness.DataType = typeof(int);
            this.coldsModelL3DataTableThickness.Namespace = "";
            // 
            // coldsModelL3DataTableCal_Weight
            // 
            this.coldsModelL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsModelL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsModelL3DataTableCal_Weight.DataType = typeof(double);
            this.coldsModelL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsModelL3DataTableRight_Weight
            // 
            this.coldsModelL3DataTableRight_Weight.Caption = "Right_Weight";
            this.coldsModelL3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coldsModelL3DataTableRight_Weight.DataType = typeof(double);
            this.coldsModelL3DataTableRight_Weight.Namespace = "";
            // 
            // coldsModelL3DataTableWaster_Weight
            // 
            this.coldsModelL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsModelL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsModelL3DataTableWaster_Weight.DataType = typeof(double);
            this.coldsModelL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsModelL3DataTableWrong_Weight
            // 
            this.coldsModelL3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coldsModelL3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coldsModelL3DataTableWrong_Weight.DataType = typeof(double);
            this.coldsModelL3DataTableWrong_Weight.Namespace = "";
            // 
            // HuiTui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.panel1);
            this.Name = "HuiTui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "HMI画面模板";
            this.Text = "HMI画面模板";
            this.panel1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCBloom_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AppSvrHMI.L3Adapter Adapter;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private AppSvrHMI.L3DataSet dsCBloom_Input;
        private System.Data.DataTable schemadsModel;
        private System.Data.DataColumn coldsModelL3DataTableGUID;
        private System.Data.DataColumn coldsModelL3DataTableName;
        private System.Data.DataColumn coldsModelL3DataTableMaterialType;
        private System.Data.DataColumn coldsModelL3DataTableMaterialID;
        private System.Data.DataColumn coldsModelL3DataTableLogDate;
        private System.Data.DataColumn coldsModelL3DataTableAmount;
        private System.Data.DataColumn coldsModelL3DataTableType;
        private System.Data.DataColumn coldsModelL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsModelL3DataTableReason;
        private System.Data.DataColumn coldsModelL3DataTableSource;
        private System.Data.DataColumn coldsModelL3DataTableOperator;
        private System.Data.DataColumn coldsModelL3DataTableShift;
        private System.Data.DataColumn coldsModelL3DataTableTeam;
        private System.Data.DataColumn coldsModelL3DataTableBloom_Count;
        private System.Data.DataColumn coldsModelL3DataTableWaster_Count;
        private System.Data.DataColumn coldsModelL3DataTableWrong_Count;
        private System.Data.DataColumn coldsModelL3DataTableRight_Count;
        private System.Data.DataColumn coldsModelL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsModelL3DataTableCur_Section_ID;
        private System.Data.DataColumn coldsModelL3DataTableCur_Bay_ID;
        private System.Data.DataColumn coldsModelL3DataTableCur_Pile_ID;
        private System.Data.DataColumn coldsModelL3DataTableCur_Layer_ID;
        private System.Data.DataColumn coldsModelL3DataTableCur_Seq_ID;
        private System.Data.DataColumn coldsModelL3DataTableLength;
        private System.Data.DataColumn coldsModelL3DataTableWidth;
        private System.Data.DataColumn coldsModelL3DataTableThickness;
        private System.Data.DataColumn coldsModelL3DataTableCal_Weight;
        private System.Data.DataColumn coldsModelL3DataTableRight_Weight;
        private System.Data.DataColumn coldsModelL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsModelL3DataTableWrong_Weight;
    }
}