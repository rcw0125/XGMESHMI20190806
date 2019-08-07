using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;



namespace UnitMag.DEPMag
{
    public partial class DePData : UserControl
    {
        public DePData()
        {
            InitializeComponent();
        }

        public AppSvrIF.Session Session
        {
            get { return Adapter.Session; }
            set { Adapter.Session = value; }
        }

        private string[,] strArrColor = new string[5, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control },
                { "02", CommDataMag.CommonData.Color_Code_OrangeRed },
                { "03", CommDataMag.CommonData.Color_Code_OrangeRed },
                { "04", CommDataMag.CommonData.Color_Code_OrangeRed},
                { "05", CommDataMag.CommonData.Color_Code_SteelBlue}};

        private string m_UnitID = "";
        private string m_CurHeatID = "";
        public string HeatID
        {
            get { return m_CurHeatID; }
            set
            {
                m_CurHeatID = value;
                SwitchToHeatID(m_CurHeatID);
            }
        }
        protected void SwitchToHeatID(string HeatID)
        {
            m_CurHeatID = HeatID;
            RefreshContent();
        }

        public string UnitID
        {
            get { return m_UnitID; }
            set
            {
                m_UnitID = value;
                RefreshContent();
            }
        }

        public void RefreshContent()
        {
            if (DesignMode || Adapter == null || Adapter.Session == null)
                return;

            if (m_UnitID.Length != 3)
                return;
            string strUnitType = m_UnitID.Substring(1, 1);
            string strID = "S91";

            //dsArrivleCCMSteel.SourceCondition = "Position ='S25P01' order by Idx";


            Adapter.set_URIParameters("BTID", strID);
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status,";
            strSQLPlan += "         a.caster_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,      ";
            strSQLPlan += "         b.steelgrade, b.protocol                                          ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b                          ";
            //清空数据
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.bofid = 'S25'";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND (   a.createdate >= (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667                         ";
            strSQLPlan += "          OR (a.createdate < (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667 AND a.status < 13)      ";
            strSQLPlan += "         )                                                                 ";
            strSQLPlan += "ORDER BY a.heatid                                                          ";
            
            dsPlan.SourceMethod = strSQLPlan;

            Adapter.RefreshDataBindings();
        }

        //炼钢记号预约
        private void dbxSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;
            Adapter.DeleteURIParameter("SteelGradeIndex");
            Adapter.set_URIParameters("SteelGradeIndex", ctrl.Text);
            //Adapter.RefreshDataBindings();

            dsSetL3DataAdapter();
        }

        //熔炼号预约
        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
         
            //化验成份
           // dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'  order by UnitTypeID ,SAMPLE_COUNT  ";

  
            //dsProStatus.SourceMethod = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc ";

            dsStatus.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc ";
            //dsProStatus.SourceCondition =  "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";

            //来料信息
            dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by LogTime desc";


            //dsFeedPro.SourceCondition = "MaterialID = '" + dbxIronLadle.Text.Trim() + "'";

            //冶炼信息
            //dsProData.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //加料
           // dsAddition.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by DISCHARGE_TIME desc";

            //加料累计[1/11/2009]
            dsSumAddition.SourceCondition = "HEATID = '" + dbxHeatID.Text + "'";

            // 测温[12/28/2008 sun]
            dsTemp.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Temp_Time desc";



        }

        //给L3DataSet赋L3DataAdapter以取数据赋值到dv中，然后取消绑定
        private void dsSetL3DataAdapter()
        {
            ////渣样
            //dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////转炉成品成份标准
            //dsElementStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////内控钢成分
            //dsInCtrl.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////基本标准
            //dsBase.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////散状料基准
            //dsStdBulk.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////出钢标准
            //dsTapping.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////钢包物料
            //dsLadleMat.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////入炉成分
            //dsInFurnaceStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            
            ////氩前氩后温度
            //dsCQA_BOF_Std_Ar.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
        }

        private void ucBOFData_Load(object sender, EventArgs e)
        {
          
            SetDataGridViewCellStyle(dvAllay, 1, 1);
            
            dsPlan.L3DataAdapter = Adapter;
            //dsArrivleCCMSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            //Set_tabStdElement_AutoSubscribe(false);
            //Set_tabProStd_AutoSubscribe(false);
            Set_tabProcess_AutoSubscribe(false);
        }

        //当前界面隐藏后关闭所有Dataset的预约
        private void ucBOFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Set_TabPlan_AutoSubscribe(false);
                //Set_tabStdElement_AutoSubscribe(false);
                //Set_tabProStd_AutoSubscribe(false);
                Set_tabProcess_AutoSubscribe(false);
                return;
            }
            else
            {
                TabPage tabpag = tabControl1.SelectedTab;
                switch (tabpag.Name)
                {
                    case "tabPlan":
                        //if (dsArrivleCCMSteel.L3DataAdapter == null)
                        //    dsArrivleCCMSteel.L3DataAdapter = Adapter;

                        Set_TabPlan_AutoSubscribe(true);
                        break;
                     
                    case "tabProcess":
                        Set_tabProcess_AutoSubscribe(true);
                        break;
                    default:
                        break;
                }
            }
        }

        //根据转炉绘制计划颜色
        private void dvPlan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvPlan, "STATUS", strArrColor);
        }
    
        private void dvLabElement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvPlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    Set_TabPlan_AutoSubscribe(false);
                    Set_tabProcess_AutoSubscribe(false);
                    switch (e.TabPage.Name)
                    {

                        case "tabPlan":
                            if (l3dbxTappingStatus.L3DataAdapter == null)
                                l3dbxTappingStatus.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;

         
                        case "tabProcess":
                            l3dbxTappingStatus.L3DataAdapter = null;

                            if (dsFeedPro.L3DataAdapter == null)
                                dsFeedPro.L3DataAdapter = Adapter;

                            //if (dsFeedDataStd.L3DataAdapter == null)
                            //    dsFeedDataStd.L3DataAdapter = Adapter;

                            //if (dsProStatus.L3DataAdapter == null)
                            //    dsProStatus.L3DataAdapter = Adapter;

                            //if (dsAddition.L3DataAdapter == null)
                            //    dsAddition.L3DataAdapter = Adapter;

                            //if (dsProData.L3DataAdapter == null)
                            //    dsProData.L3DataAdapter = Adapter;
                            if (dsLabElement.L3DataAdapter == null)
                                dsLabElement.L3DataAdapter = Adapter;

                            if (dsSumAddition.L3DataAdapter == null)
                                dsSumAddition.L3DataAdapter = Adapter;

                            if (dsTemp.L3DataAdapter == null)
                                dsTemp.L3DataAdapter = Adapter;
                            if (dsStatus.L3DataAdapter == null)
                                dsStatus.L3DataAdapter = Adapter;


                            Set_tabProcess_AutoSubscribe(true);
                            //2009-09-01 sun
                            //SetTabProcessBackColor();
                            break;

                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        //设置计划tab页的自动预约属性
        private void Set_TabPlan_AutoSubscribe(bool bAutoSubscribe)
        {
           // dsPlan.AutoSubscribe = bAutoSubscribe;
            //dsArrivleCCMSteel.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                l3dbxTappingStatus.LoadData();
                dsPlan.LoadData();
                //dsArrivleCCMSteel.LoadData();
            }
        }

        //tabStdElement


        //tabProStd


        //tabProcess
        private void Set_tabProcess_AutoSubscribe(bool bAutoSubscribe)
        {
            dsFeedPro.AutoSubscribe = bAutoSubscribe;
            //dsFeedDataStd.AutoSubscribe = bAutoSubscribe;
            //dsProData.AutoSubscribe = bAutoSubscribe;
            dsProStatus.AutoSubscribe = bAutoSubscribe;
            //dsAddition.AutoSubscribe = bAutoSubscribe;
            dsSumAddition.AutoSubscribe = bAutoSubscribe;
            dsLabElement.AutoSubscribe = bAutoSubscribe;
            dsTemp.AutoSubscribe = bAutoSubscribe;
          
            if (bAutoSubscribe)
            {
                dsFeedPro.LoadData();
                //dsFeedDataStd.LoadData();
                //dsProData.LoadData();
                dsProStatus.LoadData();
                dsLabElement.LoadData();
                //dsAddition.LoadData();
                dsSumAddition.LoadData();
                dsTemp.LoadData();
   
            }
        }

        //手动设置dv列数据属性
        private void SetDataGridViewCellStyle(DataGridView dv, int iCloStartIndex, int iCloEndIndex)
        {
            int idvCol = dv.Columns.Count;
            if (iCloStartIndex < 0 || iCloEndIndex > idvCol - 1)
                return;
            DataGridViewCellStyle dvCellStyle = new DataGridViewCellStyle();
            dvCellStyle.Format = "N0";
            dvCellStyle.NullValue = "0";
            for (int i = iCloStartIndex; i < iCloEndIndex; i++)
            {
                dv.Columns[i].DefaultCellStyle = dvCellStyle;
            }
        }

        //计算来料总量
     

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
        }

        //2009-09-01 sun
       

        private void dvTemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ldbStatus_TextChanged(object sender, EventArgs e)
        {
            //string strSQL = "";
            //strSQL += "select case when status=0 then '等待' when status=1 then '兑铁' when status=2 and step=0  then '脱碳1'  ";
            //strSQL += "when status=2 and step=1  then '脱碳1'   when status=2 and step=2  then '脱碳2'  when status=2 and step=3  then '脱碳3'   when status=2 and step=4  then '脱碳4'  ";
            //strSQL += "when status=2 and step=5  then '脱碳5'  when status=2 and step=6  then '脱碳6' when status=2 and step=7  then '脱碳7'   when status=2 and step=8  then '脱碳8' ";
            //strSQL += "when status=3 then '吹炼开始'  when status=4 then '吹炼结束' when status=5 then '还原' ";
            //strSQL += " when status=6 then '出钢开始' when status=7 then '出钢结束' else '等待' end as Status,Change_Time from caod_process_Status  where  ";

            dsProStatus.SourceMethod = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";
            dsProStatus.LoadData();
        }

        private void dvProEle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dbxIronLadle_TextChanged(object sender, EventArgs e)
        {
            dsFeedPro.SourceCondition = "MaterialID = '" + dbxIronLadle.Text.Trim() + "'";
        }


    }
}

