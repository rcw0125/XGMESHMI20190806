namespace BaseDataMag
{
    partial class MaterialPriceMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialPriceMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.btnIncludeExcel = new System.Windows.Forms.ToolStripButton();
            this.bnMatPrice = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsMatPrice = new System.Windows.Forms.BindingSource(this.components);
            this.dsMatPrice = new AppSvrHMI.L3DataSet();
            this.cmdGetMatPrice = new AppSvrHMI.L3Command(this.components);
            this.cmdpMatPrice = new AppSvrHMI.L3CommandParameter();
            this.schemadsMatPrice = new System.Data.DataTable();
            this.coldsMatPriceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableMATERIAL_CODE = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableMATERIAL_NAME = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableSTANDARD_PRICE = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableWORK_YEAR = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableLATEST_PRICE = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableOBJECT_ID = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbMatCode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtYear = new System.Windows.Forms.ToolStripTextBox();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvMatPrice = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OBJECT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORK_YEAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATERIAL_NAME = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMatCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableNC_Code = new System.Data.DataColumn();
            this.STANDARD_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LATEST_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_JAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_FEB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_MAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_APR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_MAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_JUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_JUL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_AUG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_SEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_OCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_NOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUDGET_PRICE_DEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSelectAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMatPrice)).BeginInit();
            this.bnMatPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            this.cmsSelectAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut,
            this.btnIncludeExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // btnIncludeExcel
            // 
            this.btnIncludeExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnIncludeExcel.Image")));
            this.btnIncludeExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncludeExcel.Name = "btnIncludeExcel";
            this.btnIncludeExcel.Size = new System.Drawing.Size(95, 40);
            this.btnIncludeExcel.Text = "导入Excel";
            this.btnIncludeExcel.Click += new System.EventHandler(this.btnIncludeExcel_Click);
            // 
            // bnMatPrice
            // 
            this.bnMatPrice.AddNewItem = null;
            this.bnMatPrice.AutoSize = false;
            this.bnMatPrice.BindingSource = this.bsMatPrice;
            this.bnMatPrice.CountItem = this.bindingNavigatorCountItem;
            this.bnMatPrice.DeleteItem = null;
            this.bnMatPrice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel5,
            this.cmbMatCode,
            this.toolStripLabel2,
            this.txtYear,
            this.dtStart,
            this.toolStripLabel6});
            this.bnMatPrice.Location = new System.Drawing.Point(0, 43);
            this.bnMatPrice.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMatPrice.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMatPrice.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMatPrice.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMatPrice.Name = "bnMatPrice";
            this.bnMatPrice.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMatPrice.Size = new System.Drawing.Size(1000, 25);
            this.bnMatPrice.TabIndex = 25;
            this.bnMatPrice.Text = "bindingNavigator1";
            // 
            // bsMatPrice
            // 
            this.bsMatPrice.DataMember = "L3DataTable";
            this.bsMatPrice.DataSource = this.dsMatPrice;
            // 
            // dsMatPrice
            // 
            this.dsMatPrice.AutoLoad = true;
            this.dsMatPrice.AutoSubscribe = false;
            this.dsMatPrice.DataSetName = "L3DataSet";
            this.dsMatPrice.DeleteMethod = "Delete_Mat_Price";
            this.dsMatPrice.InsertMethod = "Add_Mat_Price";
            this.dsMatPrice.L3DataAdapter = this.Adapter;
            this.dsMatPrice.LoadEvent = "";
            this.dsMatPrice.LoadTrigger = null;
            this.dsMatPrice.RefreshValve = 1000;
            this.dsMatPrice.SourceCommand = this.cmdGetMatPrice;
            this.dsMatPrice.SourceCondition = "";
            this.dsMatPrice.SourceMethod = "Get_Materia_Price";
            this.dsMatPrice.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMatPrice.SourceURI = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.dsMatPrice.SubscribeTarget = "";
            this.dsMatPrice.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatPrice});
            this.dsMatPrice.UpdateEvent = "";
            this.dsMatPrice.UpdateMethod = "Modify_Mat_Price";
            this.dsMatPrice.UpdateTrigger = null;
            // 
            // cmdGetMatPrice
            // 
            this.cmdGetMatPrice.Adapter = null;
            this.cmdGetMatPrice.MergeReturnTarget = false;
            this.cmdGetMatPrice.Method = null;
            this.cmdGetMatPrice.Object = null;
            this.cmdGetMatPrice.Parameters.Add(this.cmdpMatPrice);
            this.cmdGetMatPrice.ReturnTarget = null;
            this.cmdGetMatPrice.ReturnTargetProperty = null;
            this.cmdGetMatPrice.Trigger = null;
            this.cmdGetMatPrice.TriggerEvent = "Click";
            // 
            // cmdpMatPrice
            // 
            this.cmdpMatPrice.AcceptAfterExecuted = false;
            this.cmdpMatPrice.ConstantValue = null;
            this.cmdpMatPrice.MergeTarget = false;
            this.cmdpMatPrice.SourceFilter = null;
            this.cmdpMatPrice.SourceObject = null;
            this.cmdpMatPrice.SourceProperty = null;
            this.cmdpMatPrice.TargetObject = null;
            this.cmdpMatPrice.TargetProperty = null;
            // 
            // schemadsMatPrice
            // 
            this.schemadsMatPrice.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatPriceL3DataTableGUID,
            this.coldsMatPriceL3DataTableNAME,
            this.coldsMatPriceL3DataTableMATERIAL_CODE,
            this.coldsMatPriceL3DataTableMATERIAL_NAME,
            this.coldsMatPriceL3DataTableSTANDARD_PRICE,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV,
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC,
            this.coldsMatPriceL3DataTableWORK_YEAR,
            this.coldsMatPriceL3DataTableLATEST_PRICE,
            this.coldsMatPriceL3DataTableOBJECT_ID,
            this.coldsMatPriceL3DataTableCheckFlag});
            this.schemadsMatPrice.TableName = "L3DataTable";
            // 
            // coldsMatPriceL3DataTableGUID
            // 
            this.coldsMatPriceL3DataTableGUID.Caption = "GUID";
            this.coldsMatPriceL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatPriceL3DataTableGUID.DefaultValue = "";
            this.coldsMatPriceL3DataTableGUID.Namespace = "";
            // 
            // coldsMatPriceL3DataTableNAME
            // 
            this.coldsMatPriceL3DataTableNAME.Caption = "NAME";
            this.coldsMatPriceL3DataTableNAME.ColumnName = "NAME";
            this.coldsMatPriceL3DataTableNAME.DefaultValue = "";
            this.coldsMatPriceL3DataTableNAME.Namespace = "";
            // 
            // coldsMatPriceL3DataTableMATERIAL_CODE
            // 
            this.coldsMatPriceL3DataTableMATERIAL_CODE.Caption = "MATERIAL_CODE";
            this.coldsMatPriceL3DataTableMATERIAL_CODE.ColumnName = "MATERIAL_CODE";
            this.coldsMatPriceL3DataTableMATERIAL_CODE.DefaultValue = "";
            this.coldsMatPriceL3DataTableMATERIAL_CODE.Namespace = "";
            // 
            // coldsMatPriceL3DataTableMATERIAL_NAME
            // 
            this.coldsMatPriceL3DataTableMATERIAL_NAME.Caption = "MATERIAL_NAME";
            this.coldsMatPriceL3DataTableMATERIAL_NAME.ColumnName = "MATERIAL_NAME";
            this.coldsMatPriceL3DataTableMATERIAL_NAME.DefaultValue = "";
            this.coldsMatPriceL3DataTableMATERIAL_NAME.Namespace = "";
            // 
            // coldsMatPriceL3DataTableSTANDARD_PRICE
            // 
            this.coldsMatPriceL3DataTableSTANDARD_PRICE.Caption = "STANDARD_PRICE";
            this.coldsMatPriceL3DataTableSTANDARD_PRICE.ColumnName = "STANDARD_PRICE";
            this.coldsMatPriceL3DataTableSTANDARD_PRICE.DataType = typeof(double);
            this.coldsMatPriceL3DataTableSTANDARD_PRICE.DefaultValue = 0;
            this.coldsMatPriceL3DataTableSTANDARD_PRICE.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_JAN
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN.Caption = "BUDGET_PRICE_JAN";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN.ColumnName = "BUDGET_PRICE_JAN";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JAN.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_FEB
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB.Caption = "BUDGET_PRICE_FEB";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB.ColumnName = "BUDGET_PRICE_FEB";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_FEB.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_MAR
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR.Caption = "BUDGET_PRICE_MAR";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR.ColumnName = "BUDGET_PRICE_MAR";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAR.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_APR
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR.Caption = "BUDGET_PRICE_APR";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR.ColumnName = "BUDGET_PRICE_APR";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_APR.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_MAY
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY.Caption = "BUDGET_PRICE_MAY";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY.ColumnName = "BUDGET_PRICE_MAY";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_MAY.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_JUN
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN.Caption = "BUDGET_PRICE_JUN";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN.ColumnName = "BUDGET_PRICE_JUN";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUN.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_JUL
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL.Caption = "BUDGET_PRICE_JUL";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL.ColumnName = "BUDGET_PRICE_JUL";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_JUL.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_AUG
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG.Caption = "BUDGET_PRICE_AUG";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG.ColumnName = "BUDGET_PRICE_AUG";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_AUG.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_SEP
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP.Caption = "BUDGET_PRICE_SEP";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP.ColumnName = "BUDGET_PRICE_SEP";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_SEP.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_OCT
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT.Caption = "BUDGET_PRICE_OCT";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT.ColumnName = "BUDGET_PRICE_OCT";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_OCT.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_NOV
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV.Caption = "BUDGET_PRICE_NOV";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV.ColumnName = "BUDGET_PRICE_NOV";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_NOV.Namespace = "";
            // 
            // coldsMatPriceL3DataTableBUDGET_PRICE_DEC
            // 
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC.Caption = "BUDGET_PRICE_DEC";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC.ColumnName = "BUDGET_PRICE_DEC";
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC.DataType = typeof(double);
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC.DefaultValue = 0;
            this.coldsMatPriceL3DataTableBUDGET_PRICE_DEC.Namespace = "";
            // 
            // coldsMatPriceL3DataTableWORK_YEAR
            // 
            this.coldsMatPriceL3DataTableWORK_YEAR.Caption = "WORK_YEAR";
            this.coldsMatPriceL3DataTableWORK_YEAR.ColumnName = "WORK_YEAR";
            this.coldsMatPriceL3DataTableWORK_YEAR.DefaultValue = "";
            this.coldsMatPriceL3DataTableWORK_YEAR.Namespace = "";
            // 
            // coldsMatPriceL3DataTableLATEST_PRICE
            // 
            this.coldsMatPriceL3DataTableLATEST_PRICE.Caption = "LATEST_PRICE";
            this.coldsMatPriceL3DataTableLATEST_PRICE.ColumnName = "LATEST_PRICE";
            this.coldsMatPriceL3DataTableLATEST_PRICE.DataType = typeof(double);
            this.coldsMatPriceL3DataTableLATEST_PRICE.DefaultValue = 0;
            this.coldsMatPriceL3DataTableLATEST_PRICE.Namespace = "";
            // 
            // coldsMatPriceL3DataTableOBJECT_ID
            // 
            this.coldsMatPriceL3DataTableOBJECT_ID.Caption = "OBJECT_ID";
            this.coldsMatPriceL3DataTableOBJECT_ID.ColumnName = "OBJECT_ID";
            this.coldsMatPriceL3DataTableOBJECT_ID.Namespace = "";
            // 
            // coldsMatPriceL3DataTableCheckFlag
            // 
            this.coldsMatPriceL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsMatPriceL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsMatPriceL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsMatPriceL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbMatCode
            // 
            this.cmbMatCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbMatCode.DropDownHeight = 200;
            this.cmbMatCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatCode.DropDownWidth = 150;
            this.cmbMatCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMatCode.IntegralHeight = false;
            this.cmbMatCode.Name = "cmbMatCode";
            this.cmbMatCode.Size = new System.Drawing.Size(121, 25);
            this.cmbMatCode.SelectedIndexChanged += new System.EventHandler(this.cmbMatCode_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "物料名称:";
            // 
            // txtYear
            // 
            this.txtYear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 25);
            this.txtYear.Visible = false;
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 0, 0);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "年份:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvMatPrice);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 26;
            // 
            // dvMatPrice
            // 
            this.dvMatPrice.AllowUserToAddRows = false;
            this.dvMatPrice.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvMatPrice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvMatPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMatPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.OBJECT_ID,
            this.WORK_YEAR,
            this.MATERIAL_CODE,
            this.MATERIAL_NAME,
            this.STANDARD_PRICE,
            this.LATEST_PRICE,
            this.BUDGET_PRICE_JAN,
            this.BUDGET_PRICE_FEB,
            this.BUDGET_PRICE_MAR,
            this.BUDGET_PRICE_APR,
            this.BUDGET_PRICE_MAY,
            this.BUDGET_PRICE_JUN,
            this.BUDGET_PRICE_JUL,
            this.BUDGET_PRICE_AUG,
            this.BUDGET_PRICE_SEP,
            this.BUDGET_PRICE_OCT,
            this.BUDGET_PRICE_NOV,
            this.BUDGET_PRICE_DEC});
            this.dvMatPrice.ContextMenuStrip = this.cmsSelectAll;
            this.dvMatPrice.DataSource = this.bsMatPrice;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvMatPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvMatPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMatPrice.Location = new System.Drawing.Point(0, 0);
            this.dvMatPrice.Name = "dvMatPrice";
            this.dvMatPrice.RowTemplate.Height = 23;
            this.dvMatPrice.Size = new System.Drawing.Size(1000, 632);
            this.dvMatPrice.TabIndex = 0;
            this.dvMatPrice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMatPrice_DataBindingComplete);
            this.dvMatPrice.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvMatPrice_CurrentCellDirtyStateChanged);
            this.dvMatPrice.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMatPrice_DataError);
            // 
            // CheckFlag
            // 
            this.CheckFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 51;
            // 
            // OBJECT_ID
            // 
            this.OBJECT_ID.DataPropertyName = "OBJECT_ID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OBJECT_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.OBJECT_ID.HeaderText = "关键字";
            this.OBJECT_ID.Name = "OBJECT_ID";
            this.OBJECT_ID.ReadOnly = true;
            this.OBJECT_ID.Width = 80;
            // 
            // WORK_YEAR
            // 
            this.WORK_YEAR.DataPropertyName = "WORK_YEAR";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WORK_YEAR.DefaultCellStyle = dataGridViewCellStyle3;
            this.WORK_YEAR.HeaderText = "年份";
            this.WORK_YEAR.Name = "WORK_YEAR";
            this.WORK_YEAR.Width = 60;
            // 
            // MATERIAL_CODE
            // 
            this.MATERIAL_CODE.DataPropertyName = "MATERIAL_CODE";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MATERIAL_CODE.DefaultCellStyle = dataGridViewCellStyle4;
            this.MATERIAL_CODE.HeaderText = "物料编码";
            this.MATERIAL_CODE.Name = "MATERIAL_CODE";
            this.MATERIAL_CODE.ReadOnly = true;
            this.MATERIAL_CODE.Width = 80;
            // 
            // MATERIAL_NAME
            // 
            this.MATERIAL_NAME.DataPropertyName = "MATERIAL_NAME";
            this.MATERIAL_NAME.DataSource = this.dsMatCode;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MATERIAL_NAME.DefaultCellStyle = dataGridViewCellStyle5;
            this.MATERIAL_NAME.DisplayMember = "L3DataTable.Code_Des";
            this.MATERIAL_NAME.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MATERIAL_NAME.DropDownWidth = 150;
            this.MATERIAL_NAME.HeaderText = "物料名称";
            this.MATERIAL_NAME.MaxDropDownItems = 20;
            this.MATERIAL_NAME.Name = "MATERIAL_NAME";
            this.MATERIAL_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MATERIAL_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MATERIAL_NAME.ValueMember = "L3DataTable.Code";
            // 
            // dsMatCode
            // 
            this.dsMatCode.AutoLoad = true;
            this.dsMatCode.AutoSubscribe = false;
            this.dsMatCode.DataSetName = "L3DataSet";
            this.dsMatCode.DeleteMethod = "";
            this.dsMatCode.InsertMethod = "";
            this.dsMatCode.L3DataAdapter = this.Adapter;
            this.dsMatCode.LoadEvent = "";
            this.dsMatCode.LoadTrigger = null;
            this.dsMatCode.RefreshValve = 1000;
            this.dsMatCode.SourceCommand = null;
            this.dsMatCode.SourceCondition = "";
            this.dsMatCode.SourceMethod = "";
            this.dsMatCode.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsMatCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatCode.SubscribeTarget = "";
            this.dsMatCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsMatCode.UpdateEvent = "";
            this.dsMatCode.UpdateMethod = "";
            this.dsMatCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTableGUID,
            this.coldsMatCodeL3DataTableName,
            this.coldsMatCodeL3DataTableCode,
            this.coldsMatCodeL3DataTableCode_Des,
            this.coldsMatCodeL3DataTableCode_Group,
            this.coldsMatCodeL3DataTableCode_Group_Des,
            this.coldsMatCodeL3DataTableCode_Val_Str,
            this.coldsMatCodeL3DataTableCode_Val_Long,
            this.coldsMatCodeL3DataTableCode_Val_Double,
            this.coldsMatCodeL3DataTableNC_Code});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTableGUID
            // 
            this.coldsMatCodeL3DataTableGUID.Caption = "GUID";
            this.coldsMatCodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatCodeL3DataTableGUID.Namespace = "";
            // 
            // coldsMatCodeL3DataTableName
            // 
            this.coldsMatCodeL3DataTableName.Caption = "Name";
            this.coldsMatCodeL3DataTableName.ColumnName = "Name";
            this.coldsMatCodeL3DataTableName.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode
            // 
            this.coldsMatCodeL3DataTableCode.Caption = "Code";
            this.coldsMatCodeL3DataTableCode.ColumnName = "Code";
            this.coldsMatCodeL3DataTableCode.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Des
            // 
            this.coldsMatCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group
            // 
            this.coldsMatCodeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group_Des
            // 
            this.coldsMatCodeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Str
            // 
            this.coldsMatCodeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Long
            // 
            this.coldsMatCodeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsMatCodeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Double
            // 
            this.coldsMatCodeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsMatCodeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsMatCodeL3DataTableNC_Code
            // 
            this.coldsMatCodeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.Namespace = "";
            // 
            // STANDARD_PRICE
            // 
            this.STANDARD_PRICE.DataPropertyName = "STANDARD_PRICE";
            this.STANDARD_PRICE.HeaderText = "标准价";
            this.STANDARD_PRICE.Name = "STANDARD_PRICE";
            this.STANDARD_PRICE.Width = 80;
            // 
            // LATEST_PRICE
            // 
            this.LATEST_PRICE.DataPropertyName = "LATEST_PRICE";
            this.LATEST_PRICE.HeaderText = "最新价格";
            this.LATEST_PRICE.Name = "LATEST_PRICE";
            this.LATEST_PRICE.Width = 80;
            // 
            // BUDGET_PRICE_JAN
            // 
            this.BUDGET_PRICE_JAN.DataPropertyName = "BUDGET_PRICE_JAN";
            this.BUDGET_PRICE_JAN.HeaderText = "一月预算价格";
            this.BUDGET_PRICE_JAN.Name = "BUDGET_PRICE_JAN";
            this.BUDGET_PRICE_JAN.Width = 80;
            // 
            // BUDGET_PRICE_FEB
            // 
            this.BUDGET_PRICE_FEB.DataPropertyName = "BUDGET_PRICE_FEB";
            this.BUDGET_PRICE_FEB.HeaderText = "二月预算价格";
            this.BUDGET_PRICE_FEB.Name = "BUDGET_PRICE_FEB";
            this.BUDGET_PRICE_FEB.Width = 80;
            // 
            // BUDGET_PRICE_MAR
            // 
            this.BUDGET_PRICE_MAR.DataPropertyName = "BUDGET_PRICE_MAR";
            this.BUDGET_PRICE_MAR.HeaderText = "三月预算价格";
            this.BUDGET_PRICE_MAR.Name = "BUDGET_PRICE_MAR";
            this.BUDGET_PRICE_MAR.Width = 80;
            // 
            // BUDGET_PRICE_APR
            // 
            this.BUDGET_PRICE_APR.DataPropertyName = "BUDGET_PRICE_APR";
            this.BUDGET_PRICE_APR.HeaderText = "四月预算价格";
            this.BUDGET_PRICE_APR.Name = "BUDGET_PRICE_APR";
            this.BUDGET_PRICE_APR.Width = 80;
            // 
            // BUDGET_PRICE_MAY
            // 
            this.BUDGET_PRICE_MAY.DataPropertyName = "BUDGET_PRICE_MAY";
            this.BUDGET_PRICE_MAY.HeaderText = "五月预算价格";
            this.BUDGET_PRICE_MAY.Name = "BUDGET_PRICE_MAY";
            this.BUDGET_PRICE_MAY.Width = 80;
            // 
            // BUDGET_PRICE_JUN
            // 
            this.BUDGET_PRICE_JUN.DataPropertyName = "BUDGET_PRICE_JUN";
            this.BUDGET_PRICE_JUN.HeaderText = "六月预算价格";
            this.BUDGET_PRICE_JUN.Name = "BUDGET_PRICE_JUN";
            this.BUDGET_PRICE_JUN.Width = 80;
            // 
            // BUDGET_PRICE_JUL
            // 
            this.BUDGET_PRICE_JUL.DataPropertyName = "BUDGET_PRICE_JUL";
            this.BUDGET_PRICE_JUL.HeaderText = "七月预算价格";
            this.BUDGET_PRICE_JUL.Name = "BUDGET_PRICE_JUL";
            this.BUDGET_PRICE_JUL.Width = 80;
            // 
            // BUDGET_PRICE_AUG
            // 
            this.BUDGET_PRICE_AUG.DataPropertyName = "BUDGET_PRICE_AUG";
            this.BUDGET_PRICE_AUG.HeaderText = "八月预算价格";
            this.BUDGET_PRICE_AUG.Name = "BUDGET_PRICE_AUG";
            this.BUDGET_PRICE_AUG.Width = 80;
            // 
            // BUDGET_PRICE_SEP
            // 
            this.BUDGET_PRICE_SEP.DataPropertyName = "BUDGET_PRICE_SEP";
            this.BUDGET_PRICE_SEP.HeaderText = "九月预算价格";
            this.BUDGET_PRICE_SEP.Name = "BUDGET_PRICE_SEP";
            this.BUDGET_PRICE_SEP.Width = 80;
            // 
            // BUDGET_PRICE_OCT
            // 
            this.BUDGET_PRICE_OCT.DataPropertyName = "BUDGET_PRICE_OCT";
            this.BUDGET_PRICE_OCT.HeaderText = "十月预算价格";
            this.BUDGET_PRICE_OCT.Name = "BUDGET_PRICE_OCT";
            this.BUDGET_PRICE_OCT.Width = 80;
            // 
            // BUDGET_PRICE_NOV
            // 
            this.BUDGET_PRICE_NOV.DataPropertyName = "BUDGET_PRICE_NOV";
            this.BUDGET_PRICE_NOV.HeaderText = "十一月预算价格";
            this.BUDGET_PRICE_NOV.Name = "BUDGET_PRICE_NOV";
            this.BUDGET_PRICE_NOV.Width = 80;
            // 
            // BUDGET_PRICE_DEC
            // 
            this.BUDGET_PRICE_DEC.DataPropertyName = "BUDGET_PRICE_DEC";
            this.BUDGET_PRICE_DEC.HeaderText = "十二月预算价格";
            this.BUDGET_PRICE_DEC.Name = "BUDGET_PRICE_DEC";
            this.BUDGET_PRICE_DEC.Width = 80;
            // 
            // cmsSelectAll
            // 
            this.cmsSelectAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全选ToolStripMenuItem});
            this.cmsSelectAll.Name = "cmsSelectAll";
            this.cmsSelectAll.Size = new System.Drawing.Size(95, 26);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // MaterialPriceMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnMatPrice);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialPriceMagFrm";
            this.TabText = "物料价格库管理";
            this.Text = "物料价格库管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaterialPriceMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.MaterialPriceMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMatPrice)).EndInit();
            this.bnMatPrice.ResumeLayout(false);
            this.bnMatPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMatPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            this.cmsSelectAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.BindingNavigator bnMatPrice;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbMatCode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvMatPrice;
        private AppSvrHMI.L3DataSet dsMatPrice;
        private AppSvrHMI.L3Command cmdGetMatPrice;
        private AppSvrHMI.L3CommandParameter cmdpMatPrice;
        private System.Data.DataTable schemadsMatPrice;
        private System.Data.DataColumn coldsMatPriceL3DataTableGUID;
        private System.Data.DataColumn coldsMatPriceL3DataTableNAME;
        private System.Data.DataColumn coldsMatPriceL3DataTableMATERIAL_CODE;
        private System.Data.DataColumn coldsMatPriceL3DataTableMATERIAL_NAME;
        private System.Data.DataColumn coldsMatPriceL3DataTableSTANDARD_PRICE;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_JAN;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_FEB;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_MAR;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_APR;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_MAY;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_JUN;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_JUL;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_AUG;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_SEP;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_OCT;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_NOV;
        private System.Data.DataColumn coldsMatPriceL3DataTableBUDGET_PRICE_DEC;
        private System.Data.DataColumn coldsMatPriceL3DataTableWORK_YEAR;
        private System.Data.DataColumn coldsMatPriceL3DataTableLATEST_PRICE;
        private System.Data.DataColumn coldsMatPriceL3DataTableOBJECT_ID;
        private System.Windows.Forms.BindingSource bsMatPrice;
        private AppSvrHMI.L3DataSet dsMatCode;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableGUID;
        private System.Data.DataColumn coldsMatCodeL3DataTableName;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsMatCodeL3DataTableNC_Code;
        private System.Windows.Forms.ToolStripTextBox txtYear;
        private System.Windows.Forms.ToolStripButton btnIncludeExcel;
        private System.Data.DataColumn coldsMatPriceL3DataTableCheckFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBJECT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORK_YEAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAL_CODE;
        private System.Windows.Forms.DataGridViewComboBoxColumn MATERIAL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn STANDARD_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LATEST_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_JAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_FEB;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_MAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_APR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_MAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_JUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_JUL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_AUG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_SEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_OCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_NOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUDGET_PRICE_DEC;
        private System.Windows.Forms.ContextMenuStrip cmsSelectAll;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
    }
}