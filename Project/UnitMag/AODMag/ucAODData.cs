using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;



namespace UnitMag.AODMag
{
    public partial class ucAODData : UserControl
    {
        public ucAODData()
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
        private AppSvrHMI.L3DataSet dsNewArrivleCCMSteel = new AppSvrHMI.L3DataSet();
        public void RefreshContent()
        {
           // AppSvrHMI.L3DataSet dsNewArrivleCCMSteel = new AppSvrHMI.L3DataSet();
            if (DesignMode || Adapter == null || Adapter.Session == null)
                return;

            if (m_UnitID.Length != 3)
                return;
            string strUnitType = m_UnitID.Substring(1, 1);
            string strID = "S2" + m_UnitID.Substring(2, 1);

            //dsArrivleCCMSteel.SourceCondition = "Position ='S25P01' order by Idx";


            Adapter.set_URIParameters("BTID", strID);
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid,a.aodid ,a.bof_status, a.lf_status,";
            strSQLPlan += "         a.caster_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,      ";
            strSQLPlan += "         b.steelgrade, b.protocol                                          ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b                          ";
            //清空数据
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND ( a.bofid = '" + strID + "' OR a.aodid  = '" + strID + "')                                      ";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND   a.status < 13                            ";
            strSQLPlan += "ORDER BY a.heatid                                                          ";
            
            dsPlan.SourceMethod = strSQLPlan;
            dsArrivleCCMSteel.SourceCondition = "Position ='S25P01' order by Idx";
            //string strAODID;
            //string strsqldep = "";
            //string strsqldep1 = "";
            
            //strsqldep += "select a.materialid,b.heatid,round(b.weight,2) as weight,b.depart_weight,b.irontemp,e.tapping_temp,c.c,c.si,c.mn,c.p,c.s,c.cr,c.ni from materialposition a ,";
            //strsqldep += "cdep_FEED_data b,cqa_lab_element c  ,";
            //strsqldep += "(SELECT   heatid, MAX (report_date) AS report_date FROM cqa_lab_element where SAMPLE_ADDRESS='T2' GROUP BY heatid) d,cdep_process_data e ";

            //dsArrivleCCMSteel.SourceMethod = strsqldep + " where 1 = 2";
            //strsqldep += "where  a.position='S25P01' and a.MATERIALID=b.MATERIALID(+) and b.HEATID=c.heatid(+) and b.HEATID=e.heatid(+) and c.REPORT_DATE=d.REPORT_DATE ";

            //dsArrivleCCMSteel.SourceMethod = strsqldep;
            //dsNewArrivleCCMSteel = (AppSvrHMI.L3DataSet)dsArrivleCCMSteel.Clone();

            //strsqldep1 += "select a.MATERIALID,a.heatid,a.weight from ciron_data a,materialposition b,cmelt_FEED_data c";
            //dsArrivleCCMSteel1.SourceMethod = strsqldep1 + " where 1 = 2";
            //strsqldep1 += " where a.heatid=b.MATERIALID(+) and a.heatid = c.heatid(+) and b.position='S25P01' ";
            //dsArrivleCCMSteel1.SourceMethod = strsqldep1;
            //foreach (DataRow dr in dsArrivleCCMSteel1.Tables[0].Rows)
            //{
            //    dsNewArrivleCCMSteel.Tables[0].ImportRow(dr);
            //}
            //dsNewArrivleCCMSteel.AcceptChanges();
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
            //if (!(sender is Control))
            //    return;
            //Control ctrl = sender as Control;
            //Adapter.DeleteURIParameter("HeatID");
            //Adapter.set_URIParameters("HeatID", ctrl.Text);

            //入炉成份
            //dsFeedDataStd.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //化验成份
            dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' and SAMPLE_ADDRESS='A1' order by UnitTypeID ,SAMPLE_COUNT  ";

            //作业状态
            string strSQL = "";
            strSQL += "select case when status=0 then '等待' when status=1 then '兑铁' when status=2 and step=0  then '脱碳1'  ";
            strSQL += "when status=2 and step=1  then '脱碳1'   when status=2 and step=2  then '脱碳2'  when status=2 and step=3  then '脱碳3'   when status=2 and step=4  then '脱碳4'  ";
            strSQL += "when status=2 and step=5  then '脱碳5'  when status=2 and step=6  then '脱碳6' when status=2 and step=7  then '脱碳7'   when status=2 and step=8  then '脱碳8' ";
            strSQL += "when status=3 then '吹炼开始'  when status=4 then '吹炼结束' when status=5 then '还原' ";
            strSQL += " when status=6 then '出钢开始' when status=7 then '出钢结束' else '等待' end as Status,Change_Time from caod_process_Status  where  ";

            dsProStatus.SourceMethod = strSQL + "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";
            //dsProStatus.SourceCondition =  "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";

            //来料信息
            dsFeedPro.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //冶炼信息
            dsProData.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //加料
            dsAddition.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by DISCHARGE_TIME desc";

            //加料累计[1/11/2009]
            dsSumAddition.SourceCondition = "HEATID = '" + dbxHeatID.Text + "' AND TYPE = 1 AND ELEMENT IS NOT NULL";

            // 测温[12/28/2008 sun]
            dsTemp.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Temp_Time desc";

            // 定氧 [12/28/2008 sun]
            dsTestOxy.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Measure_Time desc";

        }

        //给L3DataSet赋L3DataAdapter以取数据赋值到dv中，然后取消绑定
        private void dsSetL3DataAdapter()
        {
            //渣样
            dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //转炉成品成份标准
            dsElementStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //内控钢成分
            dsInCtrl.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //基本标准
            dsBase.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //散状料基准
            dsStdBulk.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //出钢标准
            dsTapping.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //钢包物料
            dsLadleMat.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //入炉成分
            dsInFurnaceStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            
            ////氩前氩后温度
            //dsCQA_BOF_Std_Ar.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
        }

        private void ucBOFData_Load(object sender, EventArgs e)
        {
            //SetDataGridViewCellStyle(dvSumAddition, 1, 1);
            SetDataGridViewCellStyle(dvAllay, 1, 1);
            
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleCCMSteel.L3DataAdapter = Adapter;
            dsArrivleCCMSteel1.L3DataAdapter = Adapter;
            Set_TabPlan_AutoSubscribe(false);
            Set_tabStdElement_AutoSubscribe(false);
            Set_tabProStd_AutoSubscribe(false);
            Set_tabProcess_AutoSubscribe(false);
        }

        //当前界面隐藏后关闭所有Dataset的预约
        private void ucBOFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabStdElement_AutoSubscribe(false);
                Set_tabProStd_AutoSubscribe(false);
                Set_tabProcess_AutoSubscribe(false);
                return;
            }
            else
            {
                TabPage tabpag = tabControl1.SelectedTab;
                switch (tabpag.Name)
                {
                    case "tabPlan":
                        if (dsArrivleCCMSteel.L3DataAdapter == null)
                            dsArrivleCCMSteel.L3DataAdapter = Adapter;
                            dsArrivleCCMSteel1.L3DataAdapter = Adapter;
                        Set_TabPlan_AutoSubscribe(true);
                        break;
                    case "tabStdElement":
                        Set_tabStdElement_AutoSubscribe(true);
                        break;
                    case "tabProStd":
                        Set_tabProStd_AutoSubscribe(true);
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
                    Set_tabStdElement_AutoSubscribe(false);
                    Set_tabProStd_AutoSubscribe(false);
                    Set_tabProcess_AutoSubscribe(false);
                    switch (e.TabPage.Name)
                    {

                        case "tabPlan":
                            if (l3dbxTappingStatus.L3DataAdapter == null)
                                l3dbxTappingStatus.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;

                        case "tabStdElement":
                            l3dbxTappingStatus.L3DataAdapter = null;

                            if (dsSlagele.L3DataAdapter == null)
                                dsSlagele.L3DataAdapter = Adapter;

                            if (dsElementStd.L3DataAdapter == null)
                                dsElementStd.L3DataAdapter = Adapter;

                            if (dsInCtrl.L3DataAdapter == null)
                                dsInCtrl.L3DataAdapter = Adapter;

                            if (dsLabElement.L3DataAdapter == null)
                                dsLabElement.L3DataAdapter = Adapter;

                            Set_tabStdElement_AutoSubscribe(true);
                            break;

                        case "tabProStd":
                            l3dbxTappingStatus.L3DataAdapter = null;

                            if (dsBase.L3DataAdapter == null)
                                dsBase.L3DataAdapter = Adapter;

                            if (dsInFurnaceStd.L3DataAdapter == null)
                                dsInFurnaceStd.L3DataAdapter = Adapter;

                            if (dsTapping.L3DataAdapter == null)
                                dsTapping.L3DataAdapter = Adapter;

                            if (dsLadleMat.L3DataAdapter == null)
                                dsLadleMat.L3DataAdapter = Adapter;

                            if (dsStdBulk.L3DataAdapter == null)
                                dsStdBulk.L3DataAdapter = Adapter;

                            if (dsCQA_BOF_Std_Ar.L3DataAdapter == null)
                                dsCQA_BOF_Std_Ar.L3DataAdapter = Adapter;

                            Set_tabProStd_AutoSubscribe(true);
                            break;

                        case "tabProcess":
                            l3dbxTappingStatus.L3DataAdapter = null;

                            if (dsFeedPro.L3DataAdapter == null)
                                dsFeedPro.L3DataAdapter = Adapter;

                            //if (dsFeedDataStd.L3DataAdapter == null)
                            //    dsFeedDataStd.L3DataAdapter = Adapter;

                            if (dsProStatus.L3DataAdapter == null)
                                dsProStatus.L3DataAdapter = Adapter;

                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;

                            if (dsProData.L3DataAdapter == null)
                                dsProData.L3DataAdapter = Adapter;

                            if (dsSumAddition.L3DataAdapter == null)
                                dsSumAddition.L3DataAdapter = Adapter;

                            if (dsTemp.L3DataAdapter == null)
                                dsTemp.L3DataAdapter = Adapter;

                            if (dsTestOxy.L3DataAdapter == null)
                                dsTestOxy.L3DataAdapter = Adapter;

                            Set_tabProcess_AutoSubscribe(true);
                            //2009-09-01 sun
                            SetTabProcessBackColor();
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
            dsArrivleCCMSteel.AutoSubscribe = bAutoSubscribe;
            dsArrivleCCMSteel1.AutoSubscribe = bAutoSubscribe;
            //dsNewArrivleCCMSteel.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                l3dbxTappingStatus.LoadData();
                dsPlan.LoadData();
                dsArrivleCCMSteel1.LoadData();
                dsArrivleCCMSteel.LoadData();
             //   dsNewArrivleCCMSteel.LoadData();
                 
            }
        }

        //tabStdElement
        private void Set_tabStdElement_AutoSubscribe(bool bAutoSubscribe)
        {
            dsSlagele.AutoSubscribe = bAutoSubscribe;
            dsInCtrl.AutoSubscribe = bAutoSubscribe;
            dsElementStd.AutoSubscribe = bAutoSubscribe;
            dsLabElement.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsSlagele.LoadData();
                dsElementStd.LoadData();
                dsInCtrl.LoadData();
                dsLabElement.LoadData();
            }
        }

        //tabProStd
        private void Set_tabProStd_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBase.AutoSubscribe = bAutoSubscribe;
            dsInFurnaceStd.AutoSubscribe = bAutoSubscribe;
            dsTapping.AutoSubscribe = bAutoSubscribe;
            dsLadleMat.AutoSubscribe = bAutoSubscribe;
            dsStdBulk.AutoSubscribe = bAutoSubscribe;
            dsCQA_BOF_Std_Ar.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBase.LoadData();
                dsInFurnaceStd.LoadData();
                dsTapping.LoadData();
                dsLadleMat.LoadData();
                dsStdBulk.LoadData();
                dsCQA_BOF_Std_Ar.LoadData();
            }
        }

        //tabProcess
        private void Set_tabProcess_AutoSubscribe(bool bAutoSubscribe)
        {
            dsFeedPro.AutoSubscribe = bAutoSubscribe;
            //dsFeedDataStd.AutoSubscribe = bAutoSubscribe;
            dsProData.AutoSubscribe = bAutoSubscribe;
            dsProStatus.AutoSubscribe = bAutoSubscribe;
            dsAddition.AutoSubscribe = bAutoSubscribe;
            dsSumAddition.AutoSubscribe = bAutoSubscribe;
            dsTemp.AutoSubscribe = bAutoSubscribe;
            dsTestOxy.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsFeedPro.LoadData();
                //dsFeedDataStd.LoadData();
                dsProData.LoadData();
                dsProStatus.LoadData();
                dsAddition.LoadData();
                dsSumAddition.LoadData();
                dsTemp.LoadData();
                dsTestOxy.LoadData();
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



        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
           // dsArrivleCCMSteel.LoadData();
        }

        private void dsLabElement_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEle, dsElementStd, dsInCtrl);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEle, dsLabElement);

            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEle, dsElementStd, dsInCtrl, 7);
        }

        //2009-09-01 sun
        private void SetTabProcessBackColor()
        {
            if (dsInFurnaceStd.L3DataAdapter == null)
                dsInFurnaceStd.L3DataAdapter = Adapter;
            dsInFurnaceStd.AutoSubscribe = true;
            dsInFurnaceStd.LoadData();
            try
            {
                if (dsInFurnaceStd.Tables[0].Rows.Count > 0 && dsFeedPro.Tables[0].Rows.Count > 0)
                {
                    double iFeedS = Convert.ToDouble(dsFeedPro.Tables[0].Rows[0]["S"].ToString());
                    double iFeedSi = Convert.ToDouble(dsFeedPro.Tables[0].Rows[0]["Si"].ToString());
                    double iFeedP = Convert.ToDouble(dsFeedPro.Tables[0].Rows[0]["P"].ToString());
                    double iInS = Convert.ToDouble(dsInFurnaceStd.Tables[0].Rows[0]["Iron_S_Max"].ToString());
                    double iInSi = Convert.ToDouble(dsInFurnaceStd.Tables[0].Rows[0]["Iron_Si_Max"].ToString());
                    double iInP = Convert.ToDouble(dsInFurnaceStd.Tables[0].Rows[0]["Iron_P_Max"].ToString());
                    if (iFeedS > iInS)
                        lbIronS.BackColor = Color.Yellow;
                    else
                        lbIronS.BackColor = Color.Silver;
                    if (iFeedSi > iInSi)
                        lbIronSi.BackColor = Color.Yellow;
                    else
                        lbIronSi.BackColor = Color.Silver;
                    if (iFeedP > iInP)
                        lbIronP.BackColor = Color.Yellow;
                    else
                        lbIronP.BackColor = Color.Silver;
                }
                else
                {
                    lbIronS.BackColor = Color.Silver;
                    lbIronSi.BackColor = Color.Silver;
                    lbIronP.BackColor = Color.Silver;
                }
            }
            catch { }
        }

        private void dvTemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ldbStatus_TextChanged(object sender, EventArgs e)
        {
            string strSQL = "";
            strSQL += "select case when status=0 then '等待' when status=1 then '兑铁' when status=2 and step=0  then '脱碳1'  ";
            strSQL += "when status=2 and step=1  then '脱碳1'   when status=2 and step=2  then '脱碳2'  when status=2 and step=3  then '脱碳3'   when status=2 and step=4  then '脱碳4'  ";
            strSQL += "when status=2 and step=5  then '脱碳5'  when status=2 and step=6  then '脱碳6' when status=2 and step=7  then '脱碳7'   when status=2 and step=8  then '脱碳8' ";
            strSQL += "when status=3 then '吹炼开始'  when status=4 then '吹炼结束' when status=5 then '还原' ";
            strSQL += " when status=6 then '出钢开始' when status=7 then '出钢结束' else '等待' end as Status,Change_Time from caod_process_Status  where  ";

            dsProStatus.SourceMethod = strSQL + "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";
            dsProStatus.LoadData();
        }

        private void dvProEle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

