namespace PlanMag
{
    partial class Control
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.l3DataSet1 = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_BOFStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_LFArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_LFStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_LFEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_LFLeave = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_RHArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_RHStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_RHEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_RHLeave = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_CastingStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_BOFStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_LFArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_LFStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_LFEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_LFLeave = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_RHArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_RHStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_RHEnd = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_RHLeave = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_CastingStart = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd = new System.Data.DataColumn();
            this.queryBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l3dbxTappingStatus = new AppSvrHMI.L3DataBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmBof = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmCcm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmLf = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHeatid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coll3DataSet1L3DataTable新字段1 = new System.Data.DataColumn();
            this.dsTappingPlan = new AppSvrHMI.L3DataSet();
            this.schemadsTappingPlan = new System.Data.DataTable();
            this.coldsTappingPlanL3DataTableuserId = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablepassWord = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTablelastModTime = new System.Data.DataColumn();
            this.coldsTappingPlanL3DataTabletemp = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTappingPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnUpdate
            // 
            this.Adapter.SetAccessRight(this.btnUpdate, "BtnCastingPlanGen");
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 16F);
            this.btnUpdate.Location = new System.Drawing.Point(908, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 36);
            this.btnUpdate.TabIndex = 153;
            this.btnUpdate.Text = "修改开浇时间";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // l3DataSet1
            // 
            this.l3DataSet1.AutoLoad = true;
            this.l3DataSet1.AutoSubscribe = true;
            this.l3DataSet1.DataSetName = "L3DataSet";
            this.l3DataSet1.DeleteMethod = "";
            this.l3DataSet1.InsertMethod = "";
            this.l3DataSet1.L3DataAdapter = this.Adapter;
            this.l3DataSet1.LoadEvent = "";
            this.l3DataSet1.LoadTrigger = null;
            this.l3DataSet1.RefreshValve = 1000;
            this.l3DataSet1.SourceCommand = null;
            this.l3DataSet1.SourceCondition = "";
            this.l3DataSet1.SourceMethod = "";
            this.l3DataSet1.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.l3DataSet1.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Tapping";
            this.l3DataSet1.SubscribeTarget = "";
            this.l3DataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.l3DataSet1.UpdateEvent = "";
            this.l3DataSet1.UpdateMethod = "";
            this.l3DataSet1.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared,
            this.coll3DataSet1L3DataTableAim_Time_BOFStart,
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped,
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd,
            this.coll3DataSet1L3DataTableAim_Time_LFArrival,
            this.coll3DataSet1L3DataTableAim_Time_LFStart,
            this.coll3DataSet1L3DataTableAim_Time_LFEnd,
            this.coll3DataSet1L3DataTableAim_Time_LFLeave,
            this.coll3DataSet1L3DataTableAim_Time_RHArrival,
            this.coll3DataSet1L3DataTableAim_Time_RHStart,
            this.coll3DataSet1L3DataTableAim_Time_RHEnd,
            this.coll3DataSet1L3DataTableAim_Time_RHLeave,
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival,
            this.coll3DataSet1L3DataTableAim_Time_CastingStart,
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd,
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared,
            this.coll3DataSet1L3DataTableAct_Time_BOFStart,
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped,
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd,
            this.coll3DataSet1L3DataTableAct_Time_LFArrival,
            this.coll3DataSet1L3DataTableAct_Time_LFStart,
            this.coll3DataSet1L3DataTableAct_Time_LFEnd,
            this.coll3DataSet1L3DataTableAct_Time_LFLeave,
            this.coll3DataSet1L3DataTableAct_Time_RHArrival,
            this.coll3DataSet1L3DataTableAct_Time_RHStart,
            this.coll3DataSet1L3DataTableAct_Time_RHEnd,
            this.coll3DataSet1L3DataTableAct_Time_RHLeave,
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival,
            this.coll3DataSet1L3DataTableAct_Time_CastingStart,
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_IronPrepared
            // 
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared.Caption = "Aim_Time_IronPrepared";
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared.ColumnName = "Aim_Time_IronPrepared";
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_IronPrepared.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_BOFStart
            // 
            this.coll3DataSet1L3DataTableAim_Time_BOFStart.Caption = "Aim_Time_BOFStart";
            this.coll3DataSet1L3DataTableAim_Time_BOFStart.ColumnName = "Aim_Time_BOFStart";
            this.coll3DataSet1L3DataTableAim_Time_BOFStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_BOFStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_BOFTapped
            // 
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped.Caption = "Aim_Time_BOFTapped";
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped.ColumnName = "Aim_Time_BOFTapped";
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_BOFTapped.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_TappedSideEnd
            // 
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd.Caption = "Aim_Time_TappedSideEnd";
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd.ColumnName = "Aim_Time_TappedSideEnd";
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_TappedSideEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_LFArrival
            // 
            this.coll3DataSet1L3DataTableAim_Time_LFArrival.Caption = "Aim_Time_LFArrival";
            this.coll3DataSet1L3DataTableAim_Time_LFArrival.ColumnName = "Aim_Time_LFArrival";
            this.coll3DataSet1L3DataTableAim_Time_LFArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_LFArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_LFStart
            // 
            this.coll3DataSet1L3DataTableAim_Time_LFStart.Caption = "Aim_Time_LFStart";
            this.coll3DataSet1L3DataTableAim_Time_LFStart.ColumnName = "Aim_Time_LFStart";
            this.coll3DataSet1L3DataTableAim_Time_LFStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_LFStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_LFEnd
            // 
            this.coll3DataSet1L3DataTableAim_Time_LFEnd.Caption = "Aim_Time_LFEnd";
            this.coll3DataSet1L3DataTableAim_Time_LFEnd.ColumnName = "Aim_Time_LFEnd";
            this.coll3DataSet1L3DataTableAim_Time_LFEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_LFEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_LFLeave
            // 
            this.coll3DataSet1L3DataTableAim_Time_LFLeave.Caption = "Aim_Time_LFLeave";
            this.coll3DataSet1L3DataTableAim_Time_LFLeave.ColumnName = "Aim_Time_LFLeave";
            this.coll3DataSet1L3DataTableAim_Time_LFLeave.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_LFLeave.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_RHArrival
            // 
            this.coll3DataSet1L3DataTableAim_Time_RHArrival.Caption = "Aim_Time_RHArrival";
            this.coll3DataSet1L3DataTableAim_Time_RHArrival.ColumnName = "Aim_Time_RHArrival";
            this.coll3DataSet1L3DataTableAim_Time_RHArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_RHArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_RHStart
            // 
            this.coll3DataSet1L3DataTableAim_Time_RHStart.Caption = "Aim_Time_RHStart";
            this.coll3DataSet1L3DataTableAim_Time_RHStart.ColumnName = "Aim_Time_RHStart";
            this.coll3DataSet1L3DataTableAim_Time_RHStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_RHStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_RHEnd
            // 
            this.coll3DataSet1L3DataTableAim_Time_RHEnd.Caption = "Aim_Time_RHEnd";
            this.coll3DataSet1L3DataTableAim_Time_RHEnd.ColumnName = "Aim_Time_RHEnd";
            this.coll3DataSet1L3DataTableAim_Time_RHEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_RHEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_RHLeave
            // 
            this.coll3DataSet1L3DataTableAim_Time_RHLeave.Caption = "Aim_Time_RHLeave";
            this.coll3DataSet1L3DataTableAim_Time_RHLeave.ColumnName = "Aim_Time_RHLeave";
            this.coll3DataSet1L3DataTableAim_Time_RHLeave.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_RHLeave.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_CasterArrival
            // 
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival.Caption = "Aim_Time_CasterArrival";
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival.ColumnName = "Aim_Time_CasterArrival";
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_CasterArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_CastingStart
            // 
            this.coll3DataSet1L3DataTableAim_Time_CastingStart.Caption = "Aim_Time_CastingStart";
            this.coll3DataSet1L3DataTableAim_Time_CastingStart.ColumnName = "Aim_Time_CastingStart";
            this.coll3DataSet1L3DataTableAim_Time_CastingStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_CastingStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAim_Time_CastingEnd
            // 
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd.Caption = "Aim_Time_CastingEnd";
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd.ColumnName = "Aim_Time_CastingEnd";
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAim_Time_CastingEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_IronPrepared
            // 
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared.Caption = "Act_Time_IronPrepared";
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared.ColumnName = "Act_Time_IronPrepared";
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_IronPrepared.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_BOFStart
            // 
            this.coll3DataSet1L3DataTableAct_Time_BOFStart.Caption = "Act_Time_BOFStart";
            this.coll3DataSet1L3DataTableAct_Time_BOFStart.ColumnName = "Act_Time_BOFStart";
            this.coll3DataSet1L3DataTableAct_Time_BOFStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_BOFStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_BOFTapped
            // 
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped.Caption = "Act_Time_BOFTapped";
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped.ColumnName = "Act_Time_BOFTapped";
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_BOFTapped.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_TappedSideEnd
            // 
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd.Caption = "Act_Time_TappedSideEnd";
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd.ColumnName = "Act_Time_TappedSideEnd";
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_TappedSideEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_LFArrival
            // 
            this.coll3DataSet1L3DataTableAct_Time_LFArrival.Caption = "Act_Time_LFArrival";
            this.coll3DataSet1L3DataTableAct_Time_LFArrival.ColumnName = "Act_Time_LFArrival";
            this.coll3DataSet1L3DataTableAct_Time_LFArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_LFArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_LFStart
            // 
            this.coll3DataSet1L3DataTableAct_Time_LFStart.Caption = "Act_Time_LFStart";
            this.coll3DataSet1L3DataTableAct_Time_LFStart.ColumnName = "Act_Time_LFStart";
            this.coll3DataSet1L3DataTableAct_Time_LFStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_LFStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_LFEnd
            // 
            this.coll3DataSet1L3DataTableAct_Time_LFEnd.Caption = "Act_Time_LFEnd";
            this.coll3DataSet1L3DataTableAct_Time_LFEnd.ColumnName = "Act_Time_LFEnd";
            this.coll3DataSet1L3DataTableAct_Time_LFEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_LFEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_LFLeave
            // 
            this.coll3DataSet1L3DataTableAct_Time_LFLeave.Caption = "Act_Time_LFLeave";
            this.coll3DataSet1L3DataTableAct_Time_LFLeave.ColumnName = "Act_Time_LFLeave";
            this.coll3DataSet1L3DataTableAct_Time_LFLeave.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_LFLeave.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_RHArrival
            // 
            this.coll3DataSet1L3DataTableAct_Time_RHArrival.Caption = "Act_Time_RHArrival";
            this.coll3DataSet1L3DataTableAct_Time_RHArrival.ColumnName = "Act_Time_RHArrival";
            this.coll3DataSet1L3DataTableAct_Time_RHArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_RHArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_RHStart
            // 
            this.coll3DataSet1L3DataTableAct_Time_RHStart.Caption = "Act_Time_RHStart";
            this.coll3DataSet1L3DataTableAct_Time_RHStart.ColumnName = "Act_Time_RHStart";
            this.coll3DataSet1L3DataTableAct_Time_RHStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_RHStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_RHEnd
            // 
            this.coll3DataSet1L3DataTableAct_Time_RHEnd.Caption = "Act_Time_RHEnd";
            this.coll3DataSet1L3DataTableAct_Time_RHEnd.ColumnName = "Act_Time_RHEnd";
            this.coll3DataSet1L3DataTableAct_Time_RHEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_RHEnd.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_RHLeave
            // 
            this.coll3DataSet1L3DataTableAct_Time_RHLeave.Caption = "Act_Time_RHLeave";
            this.coll3DataSet1L3DataTableAct_Time_RHLeave.ColumnName = "Act_Time_RHLeave";
            this.coll3DataSet1L3DataTableAct_Time_RHLeave.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_RHLeave.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_CasterArrival
            // 
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival.Caption = "Act_Time_CasterArrival";
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival.ColumnName = "Act_Time_CasterArrival";
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_CasterArrival.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_CastingStart
            // 
            this.coll3DataSet1L3DataTableAct_Time_CastingStart.Caption = "Act_Time_CastingStart";
            this.coll3DataSet1L3DataTableAct_Time_CastingStart.ColumnName = "Act_Time_CastingStart";
            this.coll3DataSet1L3DataTableAct_Time_CastingStart.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_CastingStart.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAct_Time_CastingEnd
            // 
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd.Caption = "Act_Time_CastingEnd";
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd.ColumnName = "Act_Time_CastingEnd";
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableAct_Time_CastingEnd.Namespace = "";
            // 
            // queryBtn
            // 
            this.queryBtn.Font = new System.Drawing.Font("宋体", 16F);
            this.queryBtn.Location = new System.Drawing.Point(577, 153);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(117, 41);
            this.queryBtn.TabIndex = 0;
            this.queryBtn.Text = "查询";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.l3dbxTappingStatus);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.queryBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1387, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // l3dbxTappingStatus
            // 
            this.l3dbxTappingStatus.DataFormat = null;
            this.l3dbxTappingStatus.DataObject = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.l3dbxTappingStatus.DataProperty = "TappingPlanEvent";
            this.l3dbxTappingStatus.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3dbxTappingStatus.L3DataAdapter = this.Adapter;
            this.l3dbxTappingStatus.Location = new System.Drawing.Point(594, 31);
            this.l3dbxTappingStatus.Name = "l3dbxTappingStatus";
            this.l3dbxTappingStatus.Size = new System.Drawing.Size(100, 21);
            this.l3dbxTappingStatus.TabIndex = 152;
            this.l3dbxTappingStatus.Value = null;
            this.l3dbxTappingStatus.Visible = false;
            this.l3dbxTappingStatus.TextChanged += new System.EventHandler(this.l3dbxTappingStatus_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmBof);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmCcm);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmLf);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 174);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选择一个工位,查询";
            // 
            // cmBof
            // 
            this.cmBof.FormattingEnabled = true;
            this.cmBof.Items.AddRange(new object[] {
            "",
            "1#转炉",
            "2#转炉",
            "3#转炉",
            "4#转炉"});
            this.cmBof.Location = new System.Drawing.Point(88, 26);
            this.cmBof.Name = "cmBof";
            this.cmBof.Size = new System.Drawing.Size(121, 20);
            this.cmBof.TabIndex = 4;
            this.cmBof.SelectedIndexChanged += new System.EventHandler(this.cmBof_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "转炉";
            // 
            // cmCcm
            // 
            this.cmCcm.FormattingEnabled = true;
            this.cmCcm.Items.AddRange(new object[] {
            "",
            "3#机",
            "4#机",
            "5#机",
            "6#机",
            "7#机"});
            this.cmCcm.Location = new System.Drawing.Point(88, 133);
            this.cmCcm.Name = "cmCcm";
            this.cmCcm.Size = new System.Drawing.Size(121, 20);
            this.cmCcm.TabIndex = 6;
            this.cmCcm.SelectedIndexChanged += new System.EventHandler(this.cmCcm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "连铸机";
            // 
            // cmLf
            // 
            this.cmLf.FormattingEnabled = true;
            this.cmLf.Items.AddRange(new object[] {
            "",
            "1#LF",
            "2#LF",
            "3#LF",
            "4#LF",
            "5#LF"});
            this.cmLf.Location = new System.Drawing.Point(88, 76);
            this.cmLf.Name = "cmLf";
            this.cmLf.Size = new System.Drawing.Size(121, 20);
            this.cmLf.TabIndex = 5;
            this.cmLf.SelectedIndexChanged += new System.EventHandler(this.cmLf_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "精炼炉";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHeatid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(277, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 174);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入炉号,精确查询";
            // 
            // txtHeatid
            // 
            this.txtHeatid.Location = new System.Drawing.Point(75, 46);
            this.txtHeatid.Name = "txtHeatid";
            this.txtHeatid.Size = new System.Drawing.Size(110, 21);
            this.txtHeatid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "炉号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 405);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "炉号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "标识";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "转炉兑铁";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "转炉开吹";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "转炉结束";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "炉后结束";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "LF到达";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "LF处理开始";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "LF处理结束";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "LF离站";
            this.Column10.Name = "Column10";
            this.Column10.Width = 80;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "RH到达";
            this.Column11.Name = "Column11";
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "RH处理开始";
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "RH处理结束";
            this.Column13.Name = "Column13";
            this.Column13.Width = 80;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "RH离站";
            this.Column14.Name = "Column14";
            this.Column14.Width = 80;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "大包到达";
            this.Column15.Name = "Column15";
            this.Column15.Width = 80;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "大包开浇";
            this.Column16.Name = "Column16";
            this.Column16.Width = 80;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "大包离开";
            this.Column17.Name = "Column17";
            this.Column17.Width = 80;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "L3DataTable";
            this.bindingSource1.DataSource = this.l3DataSet1;
            // 
            // coll3DataSet1L3DataTable新字段1
            // 
            this.coll3DataSet1L3DataTable新字段1.Caption = "ACT_TIME_LFARRIVAL";
            this.coll3DataSet1L3DataTable新字段1.ColumnName = "新字段1";
            this.coll3DataSet1L3DataTable新字段1.Namespace = "";
            // 
            // dsTappingPlan
            // 
            this.dsTappingPlan.AutoLoad = true;
            this.dsTappingPlan.AutoSubscribe = true;
            this.dsTappingPlan.DataSetName = "L3DataSet";
            this.dsTappingPlan.DeleteMethod = "";
            this.dsTappingPlan.InsertMethod = "";
            this.dsTappingPlan.L3DataAdapter = null;
            this.dsTappingPlan.LoadEvent = "Click";
            this.dsTappingPlan.LoadTrigger = null;
            this.dsTappingPlan.RefreshValve = 1000;
            this.dsTappingPlan.SourceCommand = null;
            this.dsTappingPlan.SourceCondition = "";
            this.dsTappingPlan.SourceMethod = "";
            this.dsTappingPlan.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTappingPlan.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_UserPwd_Lock";
            this.dsTappingPlan.SubscribeTarget = null;
            this.dsTappingPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTappingPlan});
            this.dsTappingPlan.UpdateEvent = "Click";
            this.dsTappingPlan.UpdateMethod = "";
            this.dsTappingPlan.UpdateTrigger = null;
            // 
            // schemadsTappingPlan
            // 
            this.schemadsTappingPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTappingPlanL3DataTableuserId,
            this.coldsTappingPlanL3DataTablepassWord,
            this.coldsTappingPlanL3DataTablelastModTime,
            this.coldsTappingPlanL3DataTabletemp});
            this.schemadsTappingPlan.TableName = "L3DataTable";
            // 
            // coldsTappingPlanL3DataTableuserId
            // 
            this.coldsTappingPlanL3DataTableuserId.Caption = "userId";
            this.coldsTappingPlanL3DataTableuserId.ColumnName = "userId";
            this.coldsTappingPlanL3DataTableuserId.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablepassWord
            // 
            this.coldsTappingPlanL3DataTablepassWord.Caption = "passWord";
            this.coldsTappingPlanL3DataTablepassWord.ColumnName = "passWord";
            this.coldsTappingPlanL3DataTablepassWord.Namespace = "";
            // 
            // coldsTappingPlanL3DataTablelastModTime
            // 
            this.coldsTappingPlanL3DataTablelastModTime.Caption = "lastModTime";
            this.coldsTappingPlanL3DataTablelastModTime.ColumnName = "lastModTime";
            this.coldsTappingPlanL3DataTablelastModTime.DataType = typeof(System.DateTime);
            this.coldsTappingPlanL3DataTablelastModTime.Namespace = "";
            // 
            // coldsTappingPlanL3DataTabletemp
            // 
            this.coldsTappingPlanL3DataTabletemp.Caption = "temp";
            this.coldsTappingPlanL3DataTabletemp.ColumnName = "temp";
            this.coldsTappingPlanL3DataTabletemp.Namespace = "";
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
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // Control
            // 
            this.ClientSize = new System.Drawing.Size(1387, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Control";
            this.TabText = "节奏控制";
            this.Text = "节奏控制";
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTappingPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTappingPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet l3DataSet1;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_IronPrepared;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_BOFStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_BOFTapped;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_TappedSideEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_LFArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_LFStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_LFEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_LFLeave;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_RHArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_RHStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_RHEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_RHLeave;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_CasterArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_CastingStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAim_Time_CastingEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_IronPrepared;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_BOFStart;
        private System.Data.DataColumn coll3DataSet1L3DataTable新字段1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新字段1DataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsTappingPlan;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsTappingPlan;
        private System.Data.DataColumn coldsTappingPlanL3DataTableuserId;
        private System.Data.DataColumn coldsTappingPlanL3DataTablepassWord;
        private System.Data.DataColumn coldsTappingPlanL3DataTablelastModTime;
        private System.Data.DataColumn coldsTappingPlanL3DataTabletemp;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_BOFTapped;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_TappedSideEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_LFArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_LFStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_LFEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_LFLeave;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_RHArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_RHStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_RHEnd;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_RHLeave;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_CasterArrival;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_CastingStart;
        private System.Data.DataColumn coll3DataSet1L3DataTableAct_Time_CastingEnd;
        private System.Windows.Forms.TextBox txtHeatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmLf;
        private System.Windows.Forms.ComboBox cmBof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmCcm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private AppSvrHMI.L3DataBox l3dbxTappingStatus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}