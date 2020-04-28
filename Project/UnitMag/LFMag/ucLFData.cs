using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class ucLFData : UserControl
    {
        public ucLFData()
        {
            InitializeComponent();
        }

        public AppSvrIF.Session Session
        {
            get { return Adapter.Session; }
            set { Adapter.Session = value; }
        }

        private string m_UnitID = "";
        private string m_CurHeatID = "";
        private string[,] strArrColor = new string[5, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control},
                { "02", CommDataMag.CommonData.Color_Code_Pink },
                { "03", CommDataMag.CommonData.Color_Code_OrangeRed},
                { "04", CommDataMag.CommonData.Color_Code_SteelBlue},
                { "05", CommDataMag.CommonData.Color_Code_SteelBlue}};
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
            /*2009-02-28Liao*/
            if (m_UnitID.Length != 3)
                return;
            string strID = "S4" + m_UnitID.Substring(2, 1);
            Adapter.set_URIParameters("LFID", m_UnitID);
            Adapter.set_URIParameters("HeatID", m_CurHeatID);

            dbxCurArea.DataObject = "XGMESLogic\\LFMag\\CLF_Unit_Mag\\{LFID}";
            dbxHeatID.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";
            dbxTreatNo.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";
            dbxSteelGradeIndex.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}{CurArea}";

            dbxSoftTimeA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxSoftTimeB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxSteelGradeIndexA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxSteelGradeIndexB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxHeatIDA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxHeatIDB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dbxTreatNoA.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}A";
            dbxTreatNoB.DataObject = "XGMESLogic\\LFMag\\CLF_Prod_Area\\{LFID}B";

            dsPlan.SourceCondition = "LFID='" + m_UnitID + "' and Status > 10 and (CreateDate >=(select SYSDATE from dual) -0.1667  or( CreateDate  < (select SYSDATE from dual) -0.1667 and Status < 13)) order by LF_Status desc ,Side_Status desc ,BOF_Status desc";
            dsArrivleLFSteel.SourceCondition = "Position ='" + m_UnitID + "' || 'P01' order by Idx";
            dsExcept.SourceCondition = "HeatID = '" + m_CurHeatID + "'  order by UnitTypeID,UnitID asc";
            Adapter.set_URIParameters("BTID", strID);
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            strSQLPlan += "         a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,a.AIM_TAPPED_WEIGHT,a.REFINE_TYPE, a.HOT_SEND_FLAG,a.STEEL_RETURN_FLAG,a.STEEL_BACK_FLAG,     ";
            strSQLPlan += "         b.steelgrade, b.protocol ,c.other_tech_request                                         ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b ,cplan_order c                         ";
            //清空数据
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.lfid = '" + strID + "'                                       ";
            strSQLPlan += "     AND a.plan_ord_id = c.planid                                       ";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND a.status <13                                                     ";
            //strSQLPlan += "     AND (   a.createdate >= (SELECT SYSDATE                               ";
            //strSQLPlan += "                                FROM DUAL) - 0.1667                         ";
            //strSQLPlan += "          OR (a.createdate < (SELECT SYSDATE                               ";
            //strSQLPlan += "                                FROM DUAL) - 0.1667 AND a.status < 13)      ";
            //strSQLPlan += "         )                                                                 ";
            strSQLPlan += "ORDER BY LF_Status desc ,Side_Status desc ,BOF_Status desc         ";

            dsPlan.SourceMethod = strSQLPlan;
            //dsArrivleLFSteel.L3DataAdapter = Adapter;
            Adapter.RefreshDataBindings();
        }


        private void dbxSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            Adapter.DeleteURIParameter("SteelGradeIndex");
            Adapter.set_URIParameters("SteelGradeIndex", dbxSteelGradeIndex.Text);
            //Adapter.RefreshDataBindings();

            dsSetL3DataAdapter();
        }
        //给L3DataSet赋L3DataAdapter以取数据赋值到dv中，然后取消绑定
        private void dsSetL3DataAdapter()
        {
            //渣样
            dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //基本标准
            dsBaseData.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //合金加料标准
            dsAlloy.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //处理基准
            dsProcess.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //渣料加料
            dsAddSlag.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            //喂丝
            dsFeed.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

        }

        private void dbxCurArea_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea.Text != "A") && (dbxCurArea.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("CurArea");
            Adapter.set_URIParameters("CurArea", dbxCurArea.Text);
            dbxSteelGradeIndex.LoadData();
            dbxHeatID.LoadData();
            dbxTreatNo.LoadData();
        }

        //数据加载
        private void ucLFData_Load(object sender, EventArgs e)
        {
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleLFSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            Set_tabElementA_AutoSubscribe(false);
            Set_tabElementB_AutoSubscribe(false);
            Set_tabProStd_AutoSubscribe(false);
            Set_tabProcessA_AutoSubscribe(false);
            Set_tabBofAnalysis_AutoSubscribe(false );
            Set_tabBofAnalysisB_AutoSubscribe(false );
            //Set_tabProcessB_AutoSubscribe(false);

        }

        private void dbxTreatNo_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabProcessA)
                return;
            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";

            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by WireTime desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Change_Time desc";
            // begin [12/24/2008 sun]
            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";

            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Measure_Time desc";
            // end [12/24/2008 sun]
            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
        }

        private void dbxTreatNoB_TextChanged(object sender, EventArgs e)
        {
            if (lbTappingOxygenB.SelectedTab != tabProcessB)
                return;

            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";

            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by WireTime desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Change_Time desc";
            // begin [12/24/2008 sun]
            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";

            //dsOxyTemp.SourceCondition = "TreatNo = '" + dbxTreatNo.Text.Trim().ToString() + "' and \"MODE\" = 4 order by MeasureTime desc";

            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Measure_Time desc";
            // end [12/24/2008 sun]
            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
        }

        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
            //Adapter.DeleteURIParameter("HeatID");
            //Adapter.set_URIParameters("HeatID", dbxHeatID.Text);

            //dsExcept.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            //dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";
            //dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";
            // end [12/24/2008 sun]
        }

        private void ucLFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!(this.Visible))
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabElementA_AutoSubscribe(false);
                Set_tabElementB_AutoSubscribe(false);
                Set_tabProStd_AutoSubscribe(false);
                Set_tabProcessA_AutoSubscribe(false);
                Set_tabBofAnalysis_AutoSubscribe(false );
                Set_tabBofAnalysisB_AutoSubscribe(false );
                //dsArrivleLFSteel.AutoSubscribe = false;
            }
            else
            {
                TabPage tabpag = lbTappingOxygenB.SelectedTab;
                //dsArrivleLFSteel.AutoSubscribe = true;
                switch (tabpag.Name)
                {
                    case "tabPlan":
                        Set_TabPlan_AutoSubscribe(true);
                        break;
                    case "tabElementA":
                        Set_tabElementA_AutoSubscribe(true);
                        break;
                    case "tabElementB":
                        Set_tabElementB_AutoSubscribe(true);
                        break;
                    case "tabProStd":
                        Set_tabProStd_AutoSubscribe(true);
                        break;
                    case "tabProcessA":
                        Set_tabProcessA_AutoSubscribe(true);
                        break;
                    case "tabProcessB":
                        Set_tabProcessA_AutoSubscribe(true);
                        break;
                    case "tabBofAnalysis":
                        Set_tabBofAnalysis_AutoSubscribe(true);
                        break;
                    case "tabBofAnalysisB":
                        Set_tabBofAnalysisB_AutoSubscribe(true);
                        break;
                    default:
                        break;
                }
            }
        }

        //根据计划当前工序状态绘制计划行数据颜色
        private void dvPlan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvPlan, "STATUS", strArrColor);
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
                    Set_tabElementA_AutoSubscribe(false);
                    Set_tabElementB_AutoSubscribe(false);
                    Set_tabProStd_AutoSubscribe(false);
                    Set_tabProcessA_AutoSubscribe(false);
                    //Set_tabProcessB_AutoSubscribe(false);
                    Set_tabBofAnalysis_AutoSubscribe(false );
                    switch (e.TabPage.Name)
                    {
                        case "tabPlan":
                            if (dsPlan.L3DataAdapter == null)
                                dsPlan.L3DataAdapter = Adapter;

                            if (dsArrivleLFSteel.L3DataAdapter == null)
                                dsArrivleLFSteel.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;
                        case "tabArearA":
                            if (dsElementA.L3DataAdapter == null)
                                dsElementA.L3DataAdapter = Adapter;
                            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsInCtrolEleA.L3DataAdapter == null)
                                dsInCtrolEleA.L3DataAdapter = Adapter;
                            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsElementInfoA.L3DataAdapter == null)
                                dsElementInfoA.L3DataAdapter = Adapter;
                            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text
                                + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementA_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  增加Ca/Al比值
                            String HeatID_A = dbxHeatIDA.Text.Trim();
                            AppSvrIF.Command command_A= null;
                            String strMethod_A = @"CalEleRateValue";
                            String strObjURI_A = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
                            try
                            {
                               int iRet=this.Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, strObjURI_A, strMethod_A, ref command_A);
                                if(iRet==0)
                                {
                                    command_A.set_Parameters(0, HeatID_A);
                                    command_A.set_Parameters(1, "Ca");
                                    command_A.set_Parameters(2, "Al");
                                    this.Adapter.Session.Execute(command_A);
                                    object retValue = command_A.Return;
                                    if (retValue != null)
                                    {
                                        string strA = retValue.ToString();
                                        txtCaAl_A.Text = strA;
                                        if (strA.Length > 7)
                                            txtCaAl_A.Text = strA.Substring(0, 7);
                                    }
                                }
                            }
                            catch
                            {
                                txtCaAl_A.Text = "";
                            }
                            finally
                            {
                                
                                command_A.Dispose();
                            }
                            //Modify end
                            break;

                        case "tabArearB":
                            if (dsElementB.L3DataAdapter == null)
                                dsElementB.L3DataAdapter = Adapter;
                            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsInCtrolEleB.L3DataAdapter == null)
                                dsInCtrolEleB.L3DataAdapter = Adapter;
                            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsElementInfoB.L3DataAdapter == null)
                                dsElementInfoB.L3DataAdapter = Adapter;
                            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text
                                + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementB_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  增加Ca/Al比值
                            String HeatID_B = dbxHeatIDB.Text.Trim();
                            AppSvrIF.Command command_B = null;
                            String strMethod_B = @"CalEleRateValue";
                            String strObjURI_B = @"XGMESLogic\LFMag\CLF_Unit_Mag\S41";
                            try
                            {
                                int iRet = this.Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, strObjURI_B, strMethod_B, ref command_B);
                                if (iRet == 0)
                                {
                                    command_B.set_Parameters(0, HeatID_B);
                                    command_B.set_Parameters(1, "Ca");
                                    command_B.set_Parameters(2, "Al");
                                    this.Adapter.Session.Execute(command_B);
                                    object retValue = command_B.Return;
                                    if (retValue != null)
                                    {
                                        string strB = retValue.ToString();
                                        txtCaAl_B.Text = strB;
                                        if (strB.Length > 5)
                                            txtCaAl_B.Text = strB.Substring(0, 5);
                                    }
                                }
                            }
                            catch
                            {
                                txtCaAl_B.Text = "";
                            }
                            finally
                            {

                                command_B.Dispose();
                            }
                            //Modify end
                            break;

                        case "tabProStd":
                            if (dsSlagele.L3DataAdapter == null)
                                dsSlagele.L3DataAdapter = Adapter;

                            if (dsBaseData.L3DataAdapter == null)
                                dsBaseData.L3DataAdapter = Adapter;

                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;

                            if (dsAlloy.L3DataAdapter == null)
                                dsAlloy.L3DataAdapter = Adapter;

                            if (dsAddSlag.L3DataAdapter == null)
                                dsAddSlag.L3DataAdapter = Adapter;

                            if (dsFeed.L3DataAdapter == null)
                                dsFeed.L3DataAdapter = Adapter;

                            Set_tabProStd_AutoSubscribe(true);
                            break;

                        case "tabProcessA":
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;

                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;

                            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";
                            if (dsLFTempData.L3DataAdapter == null)
                                dsLFTempData.L3DataAdapter = Adapter;

                            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Measure_Time desc";
                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;

                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;

                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by Change_Time desc";
                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;

                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";
                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;

                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "' order by WireTime desc";
                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;

                            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
                            if (dsLFProcess.L3DataAdapter == null)
                                dsLFProcess.L3DataAdapter = Adapter;

                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim().ToString() + "'";
                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;
                            dsCasterStdTundish.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
                            if (dsCasterStdTundish.L3DataAdapter == null)
                                dsCasterStdTundish.L3DataAdapter = Adapter;

                            Set_tabProcessA_AutoSubscribe(true);
                            break;

                        case "tabProcessB":
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;

                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;

                            dsLFTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' and \"MODE\" <> 4 order by MeasureTime desc";
                            if (dsLFTempData.L3DataAdapter == null)
                                dsLFTempData.L3DataAdapter = Adapter;

                            dsLFOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Measure_Time desc";
                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;

                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;

                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by Change_Time desc";
                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;

                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";
                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;

                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "' order by WireTime desc";
                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;

                            dsLFProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
                            if (dsLFProcess.L3DataAdapter == null)
                                dsLFProcess.L3DataAdapter = Adapter;

                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim().ToString() + "'";
                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;

                            dsCasterStdTundish.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
                            if (dsCasterStdTundish.L3DataAdapter == null)
                                dsCasterStdTundish.L3DataAdapter = Adapter;

                            Set_tabProcessA_AutoSubscribe(true);
                            break;

                        case "tabBofAnalysis":
                            //if (dsElementA.L3DataAdapter == null)
                            //    dsElementA.L3DataAdapter = Adapter;
                            //dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            //if (dsInCtrolEleA.L3DataAdapter == null)
                            //    dsInCtrolEleA.L3DataAdapter = Adapter;
                            //dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            //if (dsElementInfoA.L3DataAdapter == null)
                            //    dsElementInfoA.L3DataAdapter = Adapter;
                            //dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text
                            //    + "' and UnitTypeID = '2' order by HeatID,AppID,Sample_Count";
                            if (dsBofElementA.L3DataAdapter == null)
                                dsBofElementA.L3DataAdapter = Adapter;
                            dsBofElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsBofInCtrolEleA.L3DataAdapter == null)
                                dsBofInCtrolEleA.L3DataAdapter = Adapter;
                            dsBofInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            if (dsBofElementInfoA.L3DataAdapter == null)
                                dsBofElementInfoA.L3DataAdapter = Adapter;
                            dsBofElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text
                                + "' and UnitTypeID = '2' order by HeatID,AppID,Sample_Count";

                            Set_tabBofAnalysis_AutoSubscribe(true);

                       
                            break;

                        case "tabBofAnalysisB":
                            //if (dsElementA.L3DataAdapter == null)
                            //    dsElementA.L3DataAdapter = Adapter;
                            //dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            //if (dsInCtrolEleA.L3DataAdapter == null)
                            //    dsInCtrolEleA.L3DataAdapter = Adapter;
                            //dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";

                            //if (dsElementInfoA.L3DataAdapter == null)
                            //    dsElementInfoA.L3DataAdapter = Adapter;
                            //dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text
                            //    + "' and UnitTypeID = '2' order by HeatID,AppID,Sample_Count";
                            if (dsBofElementB.L3DataAdapter == null)
                                dsBofElementB.L3DataAdapter = Adapter;
                            dsBofElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsBofInCtrolEleB.L3DataAdapter == null)
                                dsBofInCtrolEleB.L3DataAdapter = Adapter;
                            dsBofInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";

                            if (dsBofElementInfoB.L3DataAdapter == null)
                                dsBofElementInfoB.L3DataAdapter = Adapter;
                            dsBofElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text
                                + "' and UnitTypeID = '2' order by HeatID,AppID,Sample_Count";

                            Set_tabBofAnalysisB_AutoSubscribe(true);


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
            dsPlan.AutoSubscribe = bAutoSubscribe;
            dsArrivleLFSteel.AutoSubscribe = true;
            if (bAutoSubscribe)
            {
                dsPlan.LoadData();
                dsArrivleLFSteel.LoadData();
            }
        }

        //设置计划tabElement页的自动预约属性
        private void Set_tabElementA_AutoSubscribe(bool bAutoSubscribe)
        {
            dsElementA.AutoSubscribe = bAutoSubscribe;
            dsInCtrolEleA.AutoSubscribe = bAutoSubscribe;
            dsElementInfoA.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsElementA.LoadData();
                dsInCtrolEleA.LoadData();
                //CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleA, dsElementA, dsInCtrolEleA);
                dsElementInfoA.LoadData();
            }
        }

        //设置计划tabElement页的自动预约属性
        private void Set_tabElementB_AutoSubscribe(bool bAutoSubscribe)
        {
            dsElementB.AutoSubscribe = bAutoSubscribe;
            dsInCtrolEleB.AutoSubscribe = bAutoSubscribe;
            dsElementInfoB.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsElementB.LoadData();
                dsInCtrolEleB.LoadData();
                dsElementInfoB.LoadData();
            }
        }

        //设置计划tabBofAnalysis页的自动预约属性
        private void Set_tabBofAnalysis_AutoSubscribe(bool bAutoSubscribe)
        {
            //dsElementA.AutoSubscribe = bAutoSubscribe;
            //dsInCtrolEleA.AutoSubscribe = bAutoSubscribe;
            //dsElementInfoA.AutoSubscribe = bAutoSubscribe;
            dsBofElementA . AutoSubscribe = bAutoSubscribe;
           dsBofInCtrolEleA . AutoSubscribe = bAutoSubscribe;
           dsBofElementInfoA. AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBofElementA.LoadData();
                dsBofInCtrolEleA.LoadData();
                dsBofElementInfoA.LoadData();
            }
        }
        //设置计划tabBofAnalysisB页的自动预约属性
        private void Set_tabBofAnalysisB_AutoSubscribe(bool bAutoSubscribe)
        {
            //dsElementA.AutoSubscribe = bAutoSubscribe;
            //dsInCtrolEleA.AutoSubscribe = bAutoSubscribe;
            //dsElementInfoA.AutoSubscribe = bAutoSubscribe;
            dsBofElementB.AutoSubscribe = bAutoSubscribe;
            dsBofInCtrolEleB.AutoSubscribe = bAutoSubscribe;
            dsBofElementInfoB.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBofElementB.LoadData();
                dsBofInCtrolEleB.LoadData();
                dsBofElementInfoB.LoadData();
            }
        }

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
        }
        //设置计划tabProStd页的自动预约属性
        private void Set_tabProStd_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBaseData.AutoSubscribe = bAutoSubscribe;
            dsProcess.AutoSubscribe = bAutoSubscribe;
            dsSlagele.AutoSubscribe = bAutoSubscribe;
            dsAlloy.AutoSubscribe = bAutoSubscribe;
            dsAddSlag.AutoSubscribe = bAutoSubscribe;
            dsFeed.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsSlagele.LoadData();
                dsBaseData.LoadData();
                dsProcess.LoadData();
                dsAlloy.LoadData();
                dsAddSlag.LoadData();
                dsFeed.LoadData();
            }
        }

        //设置计划tabProcessA页的自动预约属性
        private void Set_tabProcessA_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
            dsLFTempData.AutoSubscribe = bAutoSubscribe;
            dsLFOxyData.AutoSubscribe = bAutoSubscribe;
            dsExcept.AutoSubscribe = bAutoSubscribe;
            dsProcessStatus.AutoSubscribe = bAutoSubscribe;
            dsWireData.AutoSubscribe = bAutoSubscribe;
            dsLFProcess.AutoSubscribe = bAutoSubscribe;
            dsLadleInfo.AutoSubscribe = bAutoSubscribe;
            dsCasterStdTundish.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBOFProcessData.LoadData();
                dsLFTempData.LoadData();
                dsLFOxyData.LoadData();
                dsExcept.LoadData();
                dsProcessStatus.LoadData();
                dsWireData.LoadData();
                dsLFProcess.LoadData();
                dsLadleInfo.LoadData();
                dsCasterStdTundish.LoadData();
            }
        }

        ////设置计划tabProcessB页的自动预约属性
        //private void Set_tabProcessB_AutoSubscribe(bool bAutoSubscribe)
        //{
        //    dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
        //    dsLFTempData.AutoSubscribe = bAutoSubscribe;
        //    dsLFOxyData.AutoSubscribe = bAutoSubscribe;
        //    dsExcept.AutoSubscribe = bAutoSubscribe;
        //    dsProcessStatus.AutoSubscribe = bAutoSubscribe;
        //    dsWireData.AutoSubscribe = bAutoSubscribe;
        //    dsLFProcess.AutoSubscribe = bAutoSubscribe;
        //    dsLadleUse.AutoSubscribe = bAutoSubscribe;
        //    if (bAutoSubscribe)
        //    {
        //        dsBOFProcessData.LoadData();
        //        dsLFTempData.LoadData();
        //        dsLFOxyData.LoadData();
        //        dsExcept.LoadData();
        //        dsProcessStatus.LoadData();
        //        dsWireData.LoadData();
        //        dsLFProcess.LoadData();
        //        dsLadleUse.LoadData();
        //    }
        //}

        private void dbxSoftTimeB_TextChanged(object sender, EventArgs e)
        {
            string str = dbxSoftTimeB.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                dbxSoftTimeBDis.Text = vsTime;
            }
        }

        private void dbxSoftTimeA_TextChanged(object sender, EventArgs e)
        {
            string str = dbxSoftTimeA.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                dbxSoftTimeADis.Text = vsTime;
            }
        }

        private void dbxSteelGradeIndexA_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearA)
                return;
            //成品成份标准
            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
        }

        private void dbxHeatIDA_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearA && lbTappingOxygenB.SelectedTab != tabProcessA)
                return;

            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
        }

        private void dbxSteelGradeIndexB_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearB)
                return;
            //成品成份标准
            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
        }

        private void dbxHeatIDB_TextChanged(object sender, EventArgs e)
        {
            //2009-04-25 Liao
            if (lbTappingOxygenB.SelectedTab != tabArearB && lbTappingOxygenB.SelectedTab != tabProcessB)
                return;

            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by UnitTypeID,UnitID,Exceptional_Time asc ";

            // begin [12/24/2008 sun]
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
        }

        private void dsElementInfoB_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleB, dsElementB, dsInCtrolEleB);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleB, dsElementInfoB);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEleB, dsElementB, dsInCtrolEleB, 7);
        }

        private void dsElementInfoA_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleA, dsElementA, dsInCtrolEleA);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleA, dsElementInfoA);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEleA, dsElementA, dsInCtrolEleA, 7);
        }

        private void dvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void dsBofInCtrolEleA_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dataGridView28, dsBofElementA, dsBofInCtrolEleA);
            CommDataMag.CommonMethed.dv_Element_Draw(dataGridView28, dsBofElementInfoA);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dataGridView28, dsBofElementA, dsBofInCtrolEleA, 7);
            dsMatA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' and (type=5 or Type = 3)";
        }

        private void dsBofInCtrolEleB_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dataGridView29, dsBofElementB, dsBofInCtrolEleB);
            CommDataMag.CommonMethed.dv_Element_Draw(dataGridView29, dsBofElementInfoB);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dataGridView29, dsBofElementB, dsBofInCtrolEleB, 7);
            dsMat.SourceCondition = "HeatID = '"+dbxHeatIDB.Text .Trim () + "' and (type=5 or Type = 3)";



        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == "连铸第一炉")
        //    {
        //        if (dsCasterStdTundish.Tables[0].Rows.Count > 0)
        //        {
        //            temp1  = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Fir_Min"]);
        //            temp2 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Max"]);
        //            //Label turnLadleTemp_Drop;//上次转包温降
        //            //Label twentyMinLadleTemp_Drop;//上次20'温降
        //            //Label lastLadleState;//上次包况
        //            //Label curLadleState;//这次包况
        //            //Label upLimitTemp;//上限温度
        //            //Label lowerLimitTemp;//下限温度
        //            label62.text;
        //        }
        //    }
        //    mothedCac();

        //} 
        {
            int temp1;
            int temp2;

            //上次包况
            string lastBaokuang = label50.Text;
            //当前包况
            string curBaokuang = lbCurLadleGradeA.Text;

            if (comboBox1.Text == "连铸第一炉")
            {
                if (dsCasterStdTundish.Tables[0].Rows.Count > 0)
                {
                    temp1 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Fir_Min"]);

                    if (label62.Text != "")
                    {
                        label150.Text = Convert.ToString(temp1 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label62.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次转包温降没有数据！");
                    }

                    temp2 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Fir_Max"]);
                    if (label52.Text != "")
                    {
                        label148.Text = Convert.ToString(temp2 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label52.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次20'温降没有数据！");
                    }

                }
                else
                {
                    MessageBox.Show("该工位未有炉号！");
                }
                    
            }
            else if (comboBox1.Text == "连浇炉")
            {
                if (dsCasterStdTundish.Tables[0].Rows.Count > 0)
                {
                    temp1 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Min"]);

                    if (label62.Text != "")
                    {
                        label150.Text = Convert.ToString(temp1 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label62.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次转包温降没有数据！");
                    }
                    temp2 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Max"]);
                    if (label52.Text != "")
                    {
                        label148.Text = Convert.ToString(temp2 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label52.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次20'温降没有数据！");
                    }

                }
                else
                {
                    MessageBox.Show("该工位未有炉号！");
                }
                   
            }
        }

        public int calTempCha(string ladleGrade1, string ladleGrade2)
        {
            int a = calGrade(ladleGrade1);
            int b = calGrade(ladleGrade2);
            return (b-a)*2;
        }
        public int calGrade(string ladleGrade)
        {
            if (ladleGrade == "A")
            {
                return 1;
            }
            else if (ladleGrade == "A1")
            {
                return 1;
            }
            else if (ladleGrade == "A2")
            {
                return 2;
            }
            else if (ladleGrade == "B")
            {
                return 3;
            }
            else if (ladleGrade == "B1")
            {
                return 3;
            }
            else if (ladleGrade == "B2")
            {
                return 4;
            }
            else if (ladleGrade == "C")
            {
                return 5;
            }
            else if (ladleGrade == "C1")
            {
                return 5;
            }
            else if (ladleGrade == "C2")
            {
                return 6;
            }
            else if (ladleGrade == "D")
            {
                return 7;
            }
            else if (ladleGrade == "D1")
            {
                return 7;
            }
            else if (ladleGrade == "D2")
            {
                return 8;
            }
            return 1;
        }

        /// <summary>
        /// B工位离站温度指导
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            int temp1;
            int temp2;
            //上次包况
            string lastBaokuang = label34.Text;
            //当前包况
            string curBaokuang = label58.Text;

            if (comboBox3.Text == "连铸第一炉")
            {
                if (dsCasterStdTundish.Tables[0].Rows.Count > 0)
                {
                    temp1 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Fir_Min"]);

                    // label15 上次转包温降
                    if (label15.Text != "")
                    {
                        label157.Text = Convert.ToString(temp1 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label15.Text));  
                    }
                    else
                    {
                        MessageBox.Show("上次转包温降没有数据！");
                    }
                       
                    temp2 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Fir_Max"]);
                    if (label22.Text != "")
                    {
                        label158.Text = Convert.ToString(temp2 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label22.Text));                       
                    }
                    else
                        MessageBox.Show("上次20'温降没有数据！");
                }
                else
                    MessageBox.Show("该工位未有炉号！");
            }
            else if (comboBox3.Text == "连浇炉")
            {
                if (dsCasterStdTundish.Tables[0].Rows.Count > 0)
                {
                    temp1 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Min"]);

                    if (label15.Text != "")
                    {
                        label157.Text = Convert.ToString(temp1 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label15.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次转包温降没有数据！");
                    }

                    temp2 = Convert.ToInt16(dsCasterStdTundish.Tables[0].Rows[0]["Tundish_Temp_Max"]);
                    if (label22.Text != "")
                    {
                        label158.Text = Convert.ToString(temp2 + calTempCha(lastBaokuang, curBaokuang) + Convert.ToInt16(label22.Text));
                    }
                    else
                    {
                        MessageBox.Show("上次20'温降没有数据！");
                    }

                }
                else
                {
                    MessageBox.Show("该工位未有炉号！");
                }
                   
            }
        }
        private void dvAddition_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dvAdditionB_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        /// <summary>
        /// 计算A工位的进站成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_A_JSCF_Click(object sender, EventArgs e)
        {       
            LFcfjs lfcfjs = new LFcfjs();
            lfcfjs.Adapter = Adapter;
            lfcfjs.strHeatid = dbxHeatIDA.Text.Trim();
            lfcfjs.strSteelgradeindex = dbxSteelGradeIndexA.Text.Trim();
            if (lfcfjs.ShowDialog() == DialogResult.OK)
            {
                double c = lfcfjs.C;
                double si = lfcfjs.Si;
                double mn = lfcfjs.Mn;
                double cr = lfcfjs.Cr;
                int rowcount = dvProEleA.RowCount;
                dvProEleA.Rows.Add(1);
                dvProEleA.Rows[rowcount].Cells[0].Value = "计算成分";
                dvProEleA.Rows[rowcount].Cells[1].Value = c.ToString();
                dvProEleA.Rows[rowcount].Cells[2].Value = si.ToString();
                dvProEleA.Rows[rowcount].Cells[3].Value = mn.ToString();
                dvProEleA.Rows[rowcount].Cells[7].Value = cr.ToString();
                try
                {
                    if (rowcount > 6)
                    {
                        if ((dvProEleA.Rows[1].Cells[1].Value.ToString() != "" && c > Convert.ToDouble(dvProEleA.Rows[1].Cells[1].Value) || (dvProEleA.Rows[4].Cells[1].Value.ToString() != "" && c < Convert.ToDouble(dvProEleA.Rows[4].Cells[1].Value))))
                        {
                            dvProEleA.Rows[rowcount].Cells[1].Style.BackColor = Color.Yellow;
                        }
                        if (((dvProEleA.Rows[1].Cells[2].Value.ToString() != "") && (si > Convert.ToDouble(dvProEleA.Rows[1].Cells[2].Value)) || (dvProEleA.Rows[4].Cells[2].Value.ToString() != "" && si < Convert.ToDouble(dvProEleA.Rows[4].Cells[2].Value))))
                        {
                            dvProEleA.Rows[rowcount].Cells[2].Style.BackColor = Color.Yellow;
                        }
                        if ((dvProEleA.Rows[1].Cells[3].Value.ToString() != "" && mn > Convert.ToDouble(dvProEleA.Rows[1].Cells[3].Value) || (dvProEleA.Rows[4].Cells[3].Value.ToString() != null && mn < Convert.ToDouble(dvProEleA.Rows[4].Cells[3].Value))))
                        {
                            dvProEleA.Rows[rowcount].Cells[3].Style.BackColor = Color.Yellow;
                        }
                        if ((dvProEleA.Rows[4].Cells[7].Value != null && dvProEleA.Rows[4].Cells[7].Value.ToString() != "" && cr > Convert.ToDouble(dvProEleA.Rows[1].Cells[7].Value) || (dvProEleA.Rows[4].Cells[7].Value.ToString() != "" && cr < Convert.ToDouble(dvProEleA.Rows[4].Cells[7].Value))))
                        {
                            dvProEleA.Rows[rowcount].Cells[7].Style.BackColor = Color.Yellow;
                        }
                    }
                }
                catch
                {

                }
               
            }
        }

        private void btn_B_JSCF_Click(object sender, EventArgs e)
        {
            LFcfjs lfcfjs = new LFcfjs();
            lfcfjs.Adapter = Adapter;
            lfcfjs.strHeatid = dbxHeatIDB.Text.Trim();
            lfcfjs.strSteelgradeindex = dbxSteelGradeIndexB.Text.Trim();
            if(lfcfjs.ShowDialog()==DialogResult.OK)
            {
                double c = lfcfjs.C;
                double si = lfcfjs.Si;
                double mn = lfcfjs.Mn;
                double cr = lfcfjs.Cr;
                int rowcount = dvProEleB.RowCount;
                dvProEleB.Rows.Add(1);
                dvProEleB.Rows[rowcount].Cells[0].Value = "计算成分";
                dvProEleB.Rows[rowcount].Cells[1].Value = c.ToString();
                dvProEleB.Rows[rowcount].Cells[2].Value =si.ToString();
                dvProEleB.Rows[rowcount].Cells[3].Value = mn.ToString();
                dvProEleB.Rows[rowcount].Cells[7].Value = cr.ToString();

                try
                {
                    if (rowcount > 6)
                    {
                        if ((dvProEleB.Rows[1].Cells[1].Value.ToString() != "" && c > Convert.ToDouble(dvProEleB.Rows[1].Cells[1].Value) || (dvProEleB.Rows[4].Cells[1].Value.ToString() != "" && c < Convert.ToDouble(dvProEleB.Rows[4].Cells[1].Value))))
                        {
                            dvProEleB.Rows[rowcount].Cells[1].Style.BackColor = Color.Yellow;
                        }
                        if (((dvProEleB.Rows[1].Cells[2].Value.ToString() != "") && (si > Convert.ToDouble(dvProEleB.Rows[1].Cells[2].Value)) || (dvProEleB.Rows[4].Cells[2].Value.ToString() != "" && si < Convert.ToDouble(dvProEleB.Rows[4].Cells[2].Value))))
                        {
                            dvProEleB.Rows[rowcount].Cells[2].Style.BackColor = Color.Yellow;
                        }
                        if ((dvProEleB.Rows[1].Cells[3].Value.ToString() != "" && mn > Convert.ToDouble(dvProEleB.Rows[1].Cells[3].Value) || (dvProEleB.Rows[4].Cells[3].Value.ToString() != null && mn < Convert.ToDouble(dvProEleB.Rows[4].Cells[3].Value))))
                        {
                            dvProEleB.Rows[rowcount].Cells[3].Style.BackColor = Color.Yellow;
                        }
                        if ((dvProEleB.Rows[4].Cells[7].Value != null && dvProEleB.Rows[4].Cells[7].Value.ToString() != "" && cr > Convert.ToDouble(dvProEleB.Rows[1].Cells[7].Value) || (dvProEleB.Rows[4].Cells[7].Value.ToString() != "" && cr < Convert.ToDouble(dvProEleB.Rows[4].Cells[7].Value))))
                        {
                            dvProEleB.Rows[rowcount].Cells[7].Style.BackColor = Color.Yellow;
                        }
                    }
                }
                catch
                {

                }
              
            }

            //CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleB, dsElementB, dsInCtrolEleB);
            //CommDataMag.CommonMethed.dv_Element_Draw(dvProEleB, dsElementInfoB);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEleB, dsElementB, dsInCtrolEleB, 7);

           
        }

        /// <summary>
        /// 钢包信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (label46.Text.Trim() == "")
            {
                MessageBox.Show("当前工位没有钢包！");
                return;
            }
            LFLadleInfo ladleInfo = new LFLadleInfo();
            ladleInfo.ladleid = label46.Text.Trim();
            ladleInfo.Adapter= Adapter;
            ladleInfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label38.Text.Trim() == "")
            {
                MessageBox.Show("当前工位没有钢包！");
                return;
            }
            LFLadleInfo ladleInfo = new LFLadleInfo();
            ladleInfo.ladleid = label38.Text.Trim();
            ladleInfo.Adapter = Adapter;
            ladleInfo.ShowDialog();
        }
        //private int iCount = 0;
        //private int iFlag = 0;
        //private void dsArrivleLFSteel_OnDataLoaded(object sender)
        //{
        //    int i = dsArrivleLFSteel.Tables[0].Rows.Count;

        //    if (i > iCount && iFlag == 1)
        //        MessageBox.Show(m_UnitID + "有钢水到达！", "提示");

        //    iCount = i;

        //    if (iFlag == 0)
        //        iFlag += 1;
        //}

    }
}







 