using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class ucRHData : UserControl
    {
        public ucRHData()
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
            string strID = "S5" + m_UnitID.Substring(2, 1);
            Adapter.set_URIParameters("RHID", m_UnitID);
            Adapter.set_URIParameters("HeatID", m_CurHeatID);

            dbxCurArea.DataObject = "XGMESLogic\\RHMag\\CRH_Unit_Mag\\" + m_UnitID + "";

            dbxSoftTimeA.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "A";
            dbxSoftTimeB.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "B";

            dbxSteelGradeIndexA.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "A";
            dbxSteelGradeIndexB.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "B";

            dbxHeatIDA.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "A";
            dbxHeatIDB.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "B";

            dbxTreatNoA.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "A";
            dbxTreatNoB.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\" + m_UnitID + "B";
          
            dsPlan.SourceCondition = "RHID='" + m_UnitID + "' and Status > 10 and (CreateDate >=(select SYSDATE from dual) -0.1667 or( CreateDate  < (select SYSDATE from dual) -0.1667 and Status < 13)) order by RH_Status desc,LF_Status desc,Side_Status desc,BOF_Status desc";
            dsArrivleRHSteel.SourceCondition = "Position ='" + m_UnitID + "' || 'P01' order by Idx";

            //dsExcept.SourceCondition = " HeatID = '" + m_CurHeatID + "' order by UnitTypeID,UnitID asc";
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            strSQLPlan += "         a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,a.AIM_TAPPED_WEIGHT,a.REFINE_TYPE, a.HOT_SEND_FLAG,a.STEEL_RETURN_FLAG,a.STEEL_BACK_FLAG,     ";
            strSQLPlan += "         b.steelgrade, b.protocol,c.other_tech_request                                          ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b ,cplan_order c                         ";
            //清空数据
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.plan_ord_id = c.planid                                          ";
            strSQLPlan += "     AND a.rhid = '" + strID + "'                                       ";
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

        //给L3DataSet赋L3DataAdapter以取数据赋值到dv中，然后取消绑定
        private void dsSetL3DataAdapter()
        {
            dsProcess.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text.Trim() + "'";

            dsFeed.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text.Trim() + "'";

            dsBase.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text.Trim() + "'";

            dsAlloy.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text.Trim() + "'";
        }

        private void ucRHData_Load(object sender, EventArgs e)
        {
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleRHSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            Set_tabElementA_AutoSubscribe(false);
            Set_tabElementB_AutoSubscribe(false);
            Set_tabProStd_AutoSubscribe(false);
            Set_tabProcess_AutoSubscribe(false);
            //Set_tabProcessB_AutoSubscribe(false);
        }

        private void dbxSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            Adapter.DeleteURIParameter("SteelGradeIndex");
            Adapter.set_URIParameters("SteelGradeIndex", dbxSteelGradeIndex.Text);

            dsSetL3DataAdapter();
        }

        private void dbxTreatNo_TextChanged(object sender, EventArgs e)
        {
            //Adapter.DeleteURIParameter("TreatNo");
            //Adapter.set_URIParameters("TreatNo", dbxTreatNoA.Text);
            if (lbReBlowCountB.SelectedTab != tabProcess)
                return;

            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Change_Time desc";

            // begin [12/25/2008 sun]
           
            dsRHTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";
            dsRHOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";
            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by WireTime desc";
            dsProcessInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";
            // end [12/25/2008 sun]
            dsRHProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";
        }

        private void dbxTreatNoB_TextChanged(object sender, EventArgs e)
        {
            //Adapter.DeleteURIParameter("TreatNo");
            //Adapter.set_URIParameters("TreatNo", dbxTreatNoB.Text);
            if (lbReBlowCountB.SelectedTab != tabProcessB)
                return;
            //Adapter.RefreshDataBindings();
            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";

            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Change_Time desc";

            // begin [12/25/2008 sun]

            dsRHTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";
            dsRHOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";
            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by WireTime desc";
            dsProcessInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";
            // end [12/25/2008 sun]
            dsRHProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";
        }

        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
            //Adapter.DeleteURIParameter("HeatID");
            //Adapter.set_URIParameters("HeatID", dbxHeatID.Text);

            //dsExcept.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "' order by Exceptional_Time desc";

            // begin [12/25/2008 sun]
            //dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";
            //dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "'";

            //dsLFOxyData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "' order by Measure_Time desc";
            //dsLFProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text.Trim() + "' order by Start_Time desc";
            // end [12/25/2008 sun]
        }

        private void dbxCurArea_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea.Text != "A") && (dbxCurArea.Text != "B"))
            {
                dbxSteelGradeIndex.DataObject = "";
                dbxTreatNo.DataObject = "";
                dbxHeatID.DataObject = "";
                return;
            }

            Adapter.DeleteURIParameter("CurArea");
            Adapter.set_URIParameters("CurArea", dbxCurArea.Text);

            dbxSteelGradeIndex.DataObject = "XGMESLogic\\RHMag\\CRH_Prod_Area\\{RHID}{CurArea}";
            dbxTreatNo.DataObject = @"XGMESLogic\RHMag\CRH_Prod_Area\{RHID}{CurArea}";
            dbxHeatID.DataObject = @"XGMESLogic\RHMag\CRH_Prod_Area\{RHID}{CurArea}";

            dbxSteelGradeIndex.LoadData();
            dbxHeatID.LoadData();
            dbxTreatNo.LoadData();
        }

        private void ucRHData_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabElementA_AutoSubscribe(false);
                Set_tabElementB_AutoSubscribe(false);
                Set_tabProStd_AutoSubscribe(false);
                Set_tabProcess_AutoSubscribe(false);
                //Set_tabProcessB_AutoSubscribe(false);

                timerRefresh.Enabled = false;
            }
            else
            {
                timerRefresh.Enabled = true;

                TabPage tabpag = lbReBlowCountB.SelectedTab;
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
                    case "tabProcess":
                        Set_tabProcess_AutoSubscribe(true);
                        break;
                    case "tabProcessB":
                        //Set_tabProcessB_AutoSubscribe(true);
                        Set_tabProcess_AutoSubscribe(true);
                        break;
                    default:
                        break;
                }
            }
        }

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
                    Set_tabProcess_AutoSubscribe(false);
                    //Set_tabProcessB_AutoSubscribe(false);
                    switch (e.TabPage.Name)
                    {
                        case "tabPlan":
                            if (dsPlan.L3DataAdapter == null)
                                dsPlan.L3DataAdapter = Adapter;

                            if (dsArrivleRHSteel.L3DataAdapter == null)
                                dsArrivleRHSteel.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;
                        case "tabArearA":
                            if (dsElementA.L3DataAdapter == null)
                                dsElementA.L3DataAdapter = Adapter;

                            if (dsInCtrolEleA.L3DataAdapter == null)
                                dsInCtrolEleA.L3DataAdapter = Adapter;

                            if (dsElementInfoA.L3DataAdapter == null)
                                dsElementInfoA.L3DataAdapter = Adapter;

                            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
                            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
                            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text + "' and UnitTypeID = '"
                                + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementA_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  增加Ca/Al比值
                            String HeatID_A = dbxHeatIDA.Text.Trim();
                            AppSvrIF.Command command_A = null;
                            String strMethod_A = @"CalEleRateValue";
                            String strObjURI_A = @"XGMESLogic\RHMag\CRH_Unit_Mag\S51";
                            try
                            {
                                int iRet = this.Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, strObjURI_A, strMethod_A, ref command_A);
                                if (iRet == 0)
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

                            if (dsInCtrolEleB.L3DataAdapter == null)
                                dsInCtrolEleB.L3DataAdapter = Adapter;

                            if (dsElementInfoB.L3DataAdapter == null)
                                dsElementInfoB.L3DataAdapter = Adapter;

                            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
                            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
                            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text + "' and UnitTypeID = '"
                                + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";

                            Set_tabElementB_AutoSubscribe(true);

                            //Modify begin by llj 2011-04-13  增加Ca/Al比值
                            String HeatID_B = dbxHeatIDB.Text.Trim();
                            AppSvrIF.Command command_B = null;
                            String strMethod_B = @"CalEleRateValue";
                            String strObjURI_B = @"XGMESLogic\RHMag\CRH_Unit_Mag\S51";
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
                                        if(strB.Length>5)
                                            txtCaAl_B.Text = strB.Substring(0,5);
                                        
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
                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;

                            if (dsAlloy.L3DataAdapter == null)
                                dsAlloy.L3DataAdapter = Adapter;

                            if (dsBase.L3DataAdapter == null)
                                dsBase.L3DataAdapter = Adapter;

                            if (dsFeed.L3DataAdapter == null)
                                dsFeed.L3DataAdapter = Adapter;

                            Set_tabProStd_AutoSubscribe(true);
                            break;

                        case "tabProcess":
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;
                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";

                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";

                            if (dsLFProcessData.L3DataAdapter == null)
                                dsLFProcessData.L3DataAdapter = Adapter;
                            dsLFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Start_Time desc";

                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;
                            dsLFOxyData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Measure_Time desc";

                            if (dsRHTempData.L3DataAdapter == null)
                                dsRHTempData.L3DataAdapter = Adapter;
                            dsRHTempData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

                            if (dsRHOxyData.L3DataAdapter == null)
                                dsRHOxyData.L3DataAdapter = Adapter;
                            dsRHOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Exceptional_Time desc";


                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;
                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Change_Time desc";

                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;
                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by Discharge_Time desc";

                            if (dsProcessInfo.L3DataAdapter == null)
                                dsProcessInfo.L3DataAdapter = Adapter;
                            dsProcessInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;
                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "' order by WireTime desc";

                            if (dsRHProcess.L3DataAdapter == null)
                                dsRHProcess.L3DataAdapter = Adapter;
                            dsRHProcess.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;
                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoA.Text.Trim() + "'";

                            Set_tabProcess_AutoSubscribe(true);
                            break;

                        case "tabProcessB":
                            if (dsBOFProcessData.L3DataAdapter == null)
                                dsBOFProcessData.L3DataAdapter = Adapter;
                            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";

                            if (dsTapProcessData.L3DataAdapter == null)
                                dsTapProcessData.L3DataAdapter = Adapter;
                            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";

                            if (dsLFProcessData.L3DataAdapter == null)
                                dsLFProcessData.L3DataAdapter = Adapter;
                            dsLFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Start_Time desc";

                            if (dsLFOxyData.L3DataAdapter == null)
                                dsLFOxyData.L3DataAdapter = Adapter;
                            dsLFOxyData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Measure_Time desc";

                            if (dsRHTempData.L3DataAdapter == null)
                                dsRHTempData.L3DataAdapter = Adapter;
                            dsRHTempData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

                            if (dsRHOxyData.L3DataAdapter == null)
                                dsRHOxyData.L3DataAdapter = Adapter;
                            dsRHOxyData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
                            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Exceptional_Time desc";

                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;
                            dsProcessStatus.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Change_Time desc";

                            if (dsAddition.L3DataAdapter == null)
                                dsAddition.L3DataAdapter = Adapter;
                            dsAddition.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by Discharge_Time desc";

                            if (dsProcessInfo.L3DataAdapter == null)
                                dsProcessInfo.L3DataAdapter = Adapter;
                            dsProcessInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

                            if (dsWireData.L3DataAdapter == null)
                                dsWireData.L3DataAdapter = Adapter;
                            dsWireData.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "' order by WireTime desc";

                            if (dsRHProcess.L3DataAdapter == null)
                                dsRHProcess.L3DataAdapter = Adapter;
                            dsRHProcess.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

                            if (dsLadleInfo.L3DataAdapter == null)
                                dsLadleInfo.L3DataAdapter = Adapter;
                            dsLadleInfo.SourceCondition = "TreatNo = '" + dbxTreatNoB.Text.Trim() + "'";

                            Set_tabProcess_AutoSubscribe(true);
                            //Set_tabProcessB_AutoSubscribe(true);//2009-05-05
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
            dsArrivleRHSteel.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsPlan.LoadData();
                dsArrivleRHSteel.LoadData();
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

        //设置计划tabProStd页的自动预约属性
        private void Set_tabProStd_AutoSubscribe(bool bAutoSubscribe)
        {

            dsProcess.AutoSubscribe = bAutoSubscribe;
            dsAlloy.AutoSubscribe = bAutoSubscribe;
            dsBase.AutoSubscribe = bAutoSubscribe;
            dsFeed.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsProcess.LoadData();
                dsAlloy.LoadData();
                dsBase.LoadData();
                dsFeed.LoadData();
            }
        }

        //设置计划tabProcessA页的自动预约属性
        private void Set_tabProcess_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
            dsTapProcessData.AutoSubscribe = bAutoSubscribe;
            dsLFProcessData.AutoSubscribe = bAutoSubscribe;
            dsLFOxyData.AutoSubscribe = bAutoSubscribe;
            dsRHTempData.AutoSubscribe = bAutoSubscribe;
            dsRHOxyData.AutoSubscribe = bAutoSubscribe;
            dsExcept.AutoSubscribe = bAutoSubscribe;
            dsProcessStatus.AutoSubscribe = bAutoSubscribe;
            dsAddition.AutoSubscribe = bAutoSubscribe;
            dsProcessInfo.AutoSubscribe = bAutoSubscribe;
            dsWireData.AutoSubscribe = bAutoSubscribe;
            dsRHProcess.AutoSubscribe = bAutoSubscribe;
            dsLadleInfo.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBOFProcessData.LoadData();
                dsTapProcessData.LoadData();
                dsLFProcessData.LoadData();
                dsLFOxyData.LoadData();
                dsRHTempData.LoadData();
                dsRHOxyData.LoadData();
                dsExcept.LoadData();
                dsProcessStatus.LoadData();
                dsAddition.LoadData();
                dsProcessInfo.LoadData();
                dsWireData.LoadData();
                dsRHProcess.LoadData();
                dsLadleInfo.LoadData();
            }
        }

        ////设置计划tabProcessB页的自动预约属性
        //private void Set_tabProcessB_AutoSubscribe(bool bAutoSubscribe)
        //{
        //    dsBOFProcessData.AutoSubscribe = bAutoSubscribe;
        //    dsTapProcessData.AutoSubscribe = bAutoSubscribe;
        //    dsLFProcessData.AutoSubscribe = bAutoSubscribe;
        //    dsLFOxyData.AutoSubscribe = bAutoSubscribe;
        //    dsRHTempData.AutoSubscribe = bAutoSubscribe;
        //    dsRHOxyData.AutoSubscribe = bAutoSubscribe;
        //    dsExcept.AutoSubscribe = bAutoSubscribe;
        //    dsProcessStatus.AutoSubscribe = bAutoSubscribe;
        //    dsAddition.AutoSubscribe = bAutoSubscribe;
        //    dsProcessInfo.AutoSubscribe = bAutoSubscribe;
        //    dsWireData.AutoSubscribe = bAutoSubscribe;
        //    dsRHProcess.AutoSubscribe = bAutoSubscribe;

        //    dsLadleUse.AutoSubscribe = bAutoSubscribe;
        //    if (bAutoSubscribe)
        //    {
        //        dsBOFProcessData.LoadData();
        //        dsTapProcessData.LoadData();
        //        dsLFProcessData.LoadData();
        //        dsLFOxyData.LoadData();
        //        dsRHTempData.LoadData();
        //        dsRHOxyData.LoadData();
        //        dsExcept.LoadData();
        //        dsProcessStatus.LoadData();
        //        dsAddition.LoadData();
        //        dsProcessInfo.LoadData();
        //        dsWireData.LoadData();
        //        dsRHProcess.LoadData();
        //        dsLadleUse.LoadData();
        //    }
        //}
        //[2009-03-04 sun]
        private void lbB4_TextChanged(object sender, EventArgs e)
        {
            string str = lbB4.Text.Trim();
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB4Dis.Text = vsTime;
            }
        }

        private void lbB3_TextChanged(object sender, EventArgs e)
        {
            if (lbB3.Text != "")
            {
                int viTime = Convert.ToInt32(lbB3.Text.Trim());
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB3Dis.Text = vsTime;
            }
        }

        private void lbB2_TextChanged(object sender, EventArgs e)
        {
            if (lbB2.Text != "")
            {
                int viTime = Convert.ToInt32(lbB2.Text.Trim());
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB2Dis.Text = vsTime;
            }
        }

        private void lbB1_TextChanged(object sender, EventArgs e)
        {
            if (lbB1.Text != "")
            {
                int viTime = Convert.ToInt32(lbB1.Text.Trim());
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB1Dis.Text = vsTime;
            }
        }

        private void dbxSteelGradeIndexA_TextChanged(object sender, EventArgs e)
        {
            if (lbReBlowCountB.SelectedTab != tabArearA)
                return;
            //成品成份标准
            dsElementA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
            dsInCtrolEleA.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexA.Text + "'";
        }

        private void dbxHeatIDA_TextChanged(object sender, EventArgs e)
        {
            if (lbReBlowCountB.SelectedTab != tabProcess && lbReBlowCountB.SelectedTab != tabArearA)
                return;
            //2009-04-25
            //dbxTreatNoA.LoadData();

            dsElementInfoA.SourceCondition = "HeatID = '" + dbxHeatIDA.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "'";
            dsLFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Start_Time desc";
            dsLFOxyData.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Measure_Time desc";
            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDA.Text.Trim() + "' order by Exceptional_Time desc";
        }

        private void dbxSteelGradeIndexB_TextChanged(object sender, EventArgs e)
        {
            if (lbReBlowCountB.SelectedTab != tabArearB)
                return;
            //成品成份标准
            dsElementB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
            dsInCtrolEleB.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndexB.Text + "'";
        }

        private void dbxHeatIDB_TextChanged(object sender, EventArgs e)
        {
            if (lbReBlowCountB.SelectedTab != tabProcessB && lbReBlowCountB.SelectedTab != tabArearB)
                return;
            //2009-04-25
            //dbxTreatNoB.LoadData();
            
            dsElementInfoB.SourceCondition = "HeatID = '" + dbxHeatIDB.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by HeatID,AppID,Sample_Count";
            dsBOFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
            dsTapProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "'";
            dsLFProcessData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Start_Time desc";
            dsLFOxyData.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Measure_Time desc";
            dsExcept.SourceCondition = "HeatID = '" + dbxHeatIDB.Text.Trim() + "' order by Exceptional_Time desc";
        }

        private void lbB4B_TextChanged(object sender, EventArgs e)
        {
            string str = lbB4B.Text.Trim();
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB4DisB.Text = vsTime;
            }
        }

        private void lbB3B_TextChanged(object sender, EventArgs e)
        {
            string str = lbB3B.Text.Trim();
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB3DisB.Text = vsTime;
            }
        }

        private void lbB2B_TextChanged(object sender, EventArgs e)
        {
            string str = lbB2B.Text.Trim();
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB2DisB.Text = vsTime;
            }
        }

        private void lbB1B_TextChanged(object sender, EventArgs e)
        {
            string str = lbB1B.Text.Trim();
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                lbB1DisB.Text = vsTime;
            }
        }

        //2009-05-05
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            dbxCurArea.LoadData();
            dbxHeatID.LoadData();
            dbxHeatIDA.LoadData();
            dbxHeatIDB.LoadData();
            dbxSoftTimeA.LoadData();
            dbxSoftTimeB.LoadData();
            dbxSteelGradeIndex.LoadData();
            dbxSteelGradeIndexA.LoadData();
            dbxSteelGradeIndexB.LoadData();
            dbxTreatNo.LoadData();
            dbxTreatNoA.LoadData();
            dbxTreatNoB.LoadData();
        }
        

        private void dsElementA_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleA, dsElementA, dsInCtrolEleA);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleA, dsElementInfoA);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow1(dvProEleA, dsElementA, dsInCtrolEleA, 5);
        }

        private void dsElementB_OnDataLoaded(object sender)
        {
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEleB, dsElementB, dsInCtrolEleB);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEleB, dsElementInfoB);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow1(dvProEleB, dsElementB, dsInCtrolEleB, 5);
        }

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
        }

      
        
    }
}
