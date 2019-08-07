using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class ucCCMDataFor07 : UserControl
    {
        public ucCCMDataFor07()
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
            string strID = "S6" + m_UnitID.Substring(2, 1);
            Adapter.set_URIParameters("CCMID", m_UnitID);
            Adapter.set_URIParameters("HeatID", m_CurHeatID);

            foreach (Control cSpeedTemp in gbxSpeedTemp.Controls)
            {
                if (cSpeedTemp is AppSvrHMI.L3DataBox)
                    ((AppSvrHMI.L3DataBox)cSpeedTemp).DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            }
            foreach (Control cCasting in gbxCasting.Controls)
            {
                if (cCasting is AppSvrHMI.L3DataBox)
                    ((AppSvrHMI.L3DataBox)cCasting).DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            }
            dbxCutInformation.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            dsCutInfo.SourceCondition = "CasterID = '" + m_UnitID + "' and CUT_MARK = '0' order by Log_Time desc";

            dsPlan.SourceCondition = "CasterID='" + m_UnitID + "' and Status > 10 and (CreateDate >=(select SYSDATE from dual) -0.16667 or ( CreateDate  < (select SYSDATE from dual) -0.16667 and Status < 13)) order by Caster_Status desc,RH_Status desc,LF_Status desc,Side_Status desc,BOF_Status desc";
            dsArrivleCCMSteel.SourceCondition = "Position ='" + m_UnitID + "' || 'P01' order by Idx";
            string strSQLPlan = "";

            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            strSQLPlan += "         a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,a.AIM_TAPPED_WEIGHT,a.REFINE_TYPE, a.HOT_SEND_FLAG,a.STEEL_RETURN_FLAG,a.STEEL_BACK_FLAG,a.LENGTH,a.WIDTH,a.THICKNESS ,  ";
            strSQLPlan += "         b.steelgrade, b.protocol ,c.other_tech_request                                         ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b  ,cplan_order c                         ";
            //清空数据
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.CASTERID = '" + strID + "'                                       ";
            strSQLPlan += "     AND a.plan_ord_id = c.planid                                       ";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND (   a.createdate >= (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667                         ";
            strSQLPlan += "          OR (a.createdate < (SELECT SYSDATE                               ";
            strSQLPlan += "                                FROM DUAL) - 0.1667 AND a.status < 13)      ";
            strSQLPlan += "         )                                                                 ";
            strSQLPlan += "ORDER BY LF_Status desc ,Side_Status desc ,BOF_Status desc         ";

            dsPlan.SourceMethod = strSQLPlan;
            Adapter.RefreshDataBindings();
        }

        private string[,] strArrColor = new string[4, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control },
                { "02", CommDataMag.CommonData.Color_Code_Pink },
                { "03", CommDataMag.CommonData.Color_Code_OrangeRed },
                { "04", CommDataMag.CommonData.Color_Code_SteelBlue}};

        //给铸机成品成份标准dvProductElement组织数据
        private void dvElementFormData()
        {
            try
            {
                dvProductElement.Rows.Clear();
                if (dsElementStd == null || dsElementStd.Tables[0].Rows.Count != 1)
                {
                    if (dvProductElement.Rows.Count > 0)
                        dvProductElement.Rows.Clear();
                    return;
                }
                string[] strArrayType = new string[6];
                strArrayType[0] = "下限:";
                strArrayType[1] = "_Min";
                strArrayType[2] = "目标:";
                strArrayType[3] = "_Aim";
                strArrayType[4] = "上限:";
                strArrayType[5] = "_Max";

                dvProductElement.Rows.Add(3);

                for (int i = 0; i < 3; i++)
                {
                    dvProductElement.Rows[i].Cells[0].Value = strArrayType[2 * i];
                    dvProductElement.Rows[i].Cells[1].Value = dsElementStd.Tables[0].Rows[0]["C" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[2].Value = dsElementStd.Tables[0].Rows[0]["Si" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[3].Value = dsElementStd.Tables[0].Rows[0]["Mn" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[4].Value = dsElementStd.Tables[0].Rows[0]["P" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[5].Value = dsElementStd.Tables[0].Rows[0]["S" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[6].Value = dsElementStd.Tables[0].Rows[0]["Cu" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[7].Value = dsElementStd.Tables[0].Rows[0]["Ni" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[8].Value = dsElementStd.Tables[0].Rows[0]["Cr" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[9].Value = dsElementStd.Tables[0].Rows[0]["Mo" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[10].Value = dsElementStd.Tables[0].Rows[0]["V" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[11].Value = dsElementStd.Tables[0].Rows[0]["Nb" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[12].Value = dsElementStd.Tables[0].Rows[0]["Al" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[13].Value = dsElementStd.Tables[0].Rows[0]["AlS" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[14].Value = dsElementStd.Tables[0].Rows[0]["Ti" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[15].Value = dsElementStd.Tables[0].Rows[0]["B" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[16].Value = dsElementStd.Tables[0].Rows[0]["Sb" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[17].Value = dsElementStd.Tables[0].Rows[0]["Sn" + strArrayType[2 * i + 1]].ToString();

                    dvProductElement.Rows[i].Cells[18].Value = dsElementStd.Tables[0].Rows[0]["As" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[19].Value = dsElementStd.Tables[0].Rows[0]["Zn" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[20].Value = dsElementStd.Tables[0].Rows[0]["Zr" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[21].Value = dsElementStd.Tables[0].Rows[0]["Ca" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[22].Value = dsElementStd.Tables[0].Rows[0]["W" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[23].Value = dsElementStd.Tables[0].Rows[0]["Pb" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[24].Value = dsElementStd.Tables[0].Rows[0]["Re" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[25].Value = dsElementStd.Tables[0].Rows[0]["Ceq" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[26].Value = dsElementStd.Tables[0].Rows[0]["N" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[27].Value = dsElementStd.Tables[0].Rows[0]["H" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[28].Value = dsElementStd.Tables[0].Rows[0]["O" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[29].Value = dsElementStd.Tables[0].Rows[0]["CrNi" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[30].Value = dsElementStd.Tables[0].Rows[0]["CrCu" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[31].Value = dsElementStd.Tables[0].Rows[0]["CrNiCu" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[32].Value = dsElementStd.Tables[0].Rows[0]["Other1" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[33].Value = dsElementStd.Tables[0].Rows[0]["Other2" + strArrayType[2 * i + 1]].ToString();
                    dvProductElement.Rows[i].Cells[34].Value = dsElementStd.Tables[0].Rows[0]["Other3" + strArrayType[2 * i + 1]].ToString();
                }
            }
            catch
            {
                //MessageBox.Show(ex.ToString(), "提示！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //窗体加载
        private void ucCCMData_Load(object sender, EventArgs e)
        {
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleCCMSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            Set_tabElement_AutoSubscribe(false);
            Set_tabMakeStd_AutoSubscribe(false);
            Set_tabProcess_AutoSubscribe(false);
            Set_tabExcept_AutoSubscribe(false);
        }

        //预约炼钢记号
        private void dbxSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            //成分标准
            dsElementStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //基本信息
            dsBaseStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //中包覆盖剂
            dsTundishFlux.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //中包温度
            dsTundishStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //拉速
            dsSpeedStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //制造标准
            dsProcStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
        }

        //预约熔炼号
        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
            //连铸基本信息
            dsBaseCCM.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //连铸炉次信息
            dsProcessData.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //保护浇铸
            dsProtectCasting.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //保护套管
            dsProtectMat.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //钢包
            dsLadle.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //作业状态
            dsProcessStatus.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time Desc";

            //中包温度
            dsHeatTundishTemp.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Measure_Time Desc";

            //曲线数据[2009-03-20 Liao]
            string strSQLCurve = "select * from (select Oscillate_MeterNo,Freq_Act_ElectMix_2ST,Current_Act_ElectMix_2ST from ";

            if (m_UnitID == CommDataMag.CommonData.CCM_UNIT_05ID)
                strSQLCurve += " CCCM5_Runtime1_Data";
            else
                strSQLCurve += " CCCM_Runtime_Data";
            strSQLCurve += " where HeatID = '" + dbxHeatID.Text + "' order by LogTime asc ) where rownum < 2";
            dsCurve.SourceMethod = strSQLCurve;

            /******************090210********************/
            try
            {
                //前工序异常
                dsProdExcept.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'  and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by Exceptional_Time";

                //化验成份
                dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' and UnitTypeID = '" + UnitID.Substring(1, 1).ToString() + "' order by AppID ";
            }
            catch
            {
            }
            /***********************090210***********************/
        }

        //预约包次号
        private void dbxTundishNo_TextChanged(object sender, EventArgs e)
        {
            //包次信息
            dsTundishData.SourceCondition = "TundishNo = '" + dbxTundishNo.Text + "'";
        }

        //预约浇次号
        private void dbxCastingNO_TextChanged(object sender, EventArgs e)
        {
            //浇次信息
            dsCastingData.SourceCondition = "CastingNo = '" + dbxCastingNO.Text + "'";
        }

        //ucCCMData不可见时取消
        private void ucCCMData_VisibleChanged(object sender, EventArgs e)
        {
            if (!(this.Visible))
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabElement_AutoSubscribe(false);
                Set_tabMakeStd_AutoSubscribe(false);
                Set_tabProcess_AutoSubscribe(false);
                Set_tabExcept_AutoSubscribe(false);
            }
            else
            {
                TabPage tabpag = tabControl1.SelectedTab;
                switch (tabpag.Name)
                {
                    case "tabPlan":
                        Set_TabPlan_AutoSubscribe(true);
                        break;
                    case "tabElement":
                        Set_tabElement_AutoSubscribe(true);
                        break;
                    case "tabMakeStd":
                        Set_tabMakeStd_AutoSubscribe(true);
                        break;
                    case "tabProcess":
                        Set_tabProcess_AutoSubscribe(true);
                        break;
                    case "tabExcept":
                        Set_tabExcept_AutoSubscribe(true);
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

        //private void dvLabElement_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    if (dvLabElement.Rows.Count < 1)
        //        return;
        //    for (int i = 0; i < dvLabElement.Rows.Count; i++)
        //    {
        //        for (int j = CLib.Index; j < Other3Lib.Index; j++)
        //        {
        //            DataGridViewCell cell = dvLabElement.Rows[i].Cells[j];
        //            try
        //            {
        //                //获取实绩成分列名
        //                string strColumnName = dvLabElement.Columns[cell.ColumnIndex].DataPropertyName;
        //                //取出数据
        //                double dRealValue = Convert.ToDouble(cell.Value.ToString());
        //                //判断是否校验
        //                if (dRealValue > 0)
        //                {
        //                    double dStdMax = Convert.ToDouble(dsElementStd.Tables[0].Rows[0][strColumnName + "_Max"].ToString());
        //                    double dStdMin = Convert.ToDouble(dsElementStd.Tables[0].Rows[0][strColumnName + "_Min"].ToString());
        //                    CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
        //                }
        //            }
        //            catch { }
        //        }
        //    }
        //}

        private void dvLabElement_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //确认取样
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            DataRow dr = ((System.Data.DataRowView)(bsCutInfo.Current)).Row;
            string strGuid = dsCutInfo.Tables[0].Rows[dsCutInfo.Tables[0].Rows.IndexOf(dr)]["GUID"].ToString();
            Adapter.Session.Set("XGMESLogic\\QualityMag\\CQA_Lab_Cut_Advice\\" + strGuid, "Cut_Mark", "1");
            //Adapter.RefreshDataBindings();
        }

        private void dvCutInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvCutInfo.Rows.Count < 1)
                btnComfirm.Enabled = false;
            else
                btnComfirm.Enabled = true;
        }

        private void dvCutInfo_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            bsCutInfo.Position = e.RowIndex;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                if (e.Action == TabControlAction.Selected)
                {
                    Set_TabPlan_AutoSubscribe(false);
                    Set_tabElement_AutoSubscribe(false);
                    Set_tabMakeStd_AutoSubscribe(false);
                    Set_tabProcess_AutoSubscribe(false);
                    Set_tabExcept_AutoSubscribe(false);
                    switch (e.TabPage.Name)
                    {
                        case "tabPlan":
                            if (dsPlan.L3DataAdapter == null)
                                dsPlan.L3DataAdapter = Adapter;

                            if (dsArrivleCCMSteel.L3DataAdapter == null)
                                dsArrivleCCMSteel.L3DataAdapter = Adapter;

                            Set_TabPlan_AutoSubscribe(true);
                            break;
                        case "tabElement":
                            if (dsElementStd.L3DataAdapter == null)
                                dsElementStd.L3DataAdapter = Adapter;

                            if (dsLabElement.L3DataAdapter == null)
                                dsLabElement.L3DataAdapter = Adapter;

                            Set_tabElement_AutoSubscribe(true);
                            break;
                        case "tabMakeStd":
                            if (dsBaseStd.L3DataAdapter == null)
                                dsBaseStd.L3DataAdapter = Adapter;

                            if (dsProcStd.L3DataAdapter == null)
                                dsProcStd.L3DataAdapter = Adapter;

                            if (dsSpeedStd.L3DataAdapter == null)
                                dsSpeedStd.L3DataAdapter = Adapter;

                            if (dsTundishStd.L3DataAdapter == null)
                                dsTundishStd.L3DataAdapter = Adapter;

                            if (dsTundishFlux.L3DataAdapter == null)
                                dsTundishFlux.L3DataAdapter = Adapter;

                            Set_tabMakeStd_AutoSubscribe(true);
                            break;
                        case "tabProcess":
                            if (dsProcessData.L3DataAdapter == null)
                                dsProcessData.L3DataAdapter = Adapter;

                            if (dsLadle.L3DataAdapter == null)
                                dsLadle.L3DataAdapter = Adapter;

                            if (dsBaseCCM.L3DataAdapter == null)
                                dsBaseCCM.L3DataAdapter = Adapter;

                            if (dsProtectCasting.L3DataAdapter == null)
                                dsProtectCasting.L3DataAdapter = Adapter;

                            if (dsCutInfo.L3DataAdapter == null)
                                dsCutInfo.L3DataAdapter = Adapter;

                            if (dsCurve.L3DataAdapter == null)
                                dsCurve.L3DataAdapter = Adapter;

                            Set_tabProcess_AutoSubscribe(true);
                            break;

                        case "tabExcept":
                            if (dsProcessStatus.L3DataAdapter == null)
                                dsProcessStatus.L3DataAdapter = Adapter;

                            if (dsProdExcept.L3DataAdapter == null)
                                dsProdExcept.L3DataAdapter = Adapter;

                            if (dsCastingData.L3DataAdapter == null)
                                dsCastingData.L3DataAdapter = Adapter;

                            if (dsTundishData.L3DataAdapter == null)
                                dsTundishData.L3DataAdapter = Adapter;

                            if (dsHeatTundishTemp.L3DataAdapter == null)
                                dsHeatTundishTemp.L3DataAdapter = Adapter;

                            Set_tabExcept_AutoSubscribe(true);

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
            dsArrivleCCMSteel.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsPlan.LoadData();
                dsArrivleCCMSteel.LoadData();
            }
        }

        //tabStdElement
        private void Set_tabElement_AutoSubscribe(bool bAutoSubscribe)
        {
            dsElementStd.AutoSubscribe = bAutoSubscribe;
            dsLabElement.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsElementStd.LoadData();
                dvElementFormData();

                dsLabElement.LoadData();
            }
        }

        //tabMakeStd
        private void Set_tabMakeStd_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBaseStd.AutoSubscribe = bAutoSubscribe;
            dsProcStd.AutoSubscribe = bAutoSubscribe;
            dsTundishStd.AutoSubscribe = bAutoSubscribe;
            dsSpeedStd.AutoSubscribe = bAutoSubscribe;
            dsTundishFlux.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBaseStd.LoadData();
                dsProcStd.LoadData();
                dsTundishStd.LoadData();
                dsSpeedStd.LoadData();
                dsTundishFlux.LoadData();
            }
        }

        //tabProcess
        private void Set_tabProcess_AutoSubscribe(bool bAutoSubscribe)
        {
            dsProcessData.AutoSubscribe = bAutoSubscribe;
            dsLadle.AutoSubscribe = bAutoSubscribe;
            dsBaseCCM.AutoSubscribe = bAutoSubscribe;
            dsProtectCasting.AutoSubscribe = bAutoSubscribe;
            dsCutInfo.AutoSubscribe = bAutoSubscribe;
            dsCurve.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsProcessData.LoadData();
                dsLadle.LoadData();
                dsBaseCCM.LoadData();
                dsProtectCasting.LoadData();
                dsCutInfo.LoadData();
                dsCurve.LoadData();
            }
        }

        //tabExcept
        private void Set_tabExcept_AutoSubscribe(bool bAutoSubscribe)
        {
            dsProcessStatus.AutoSubscribe = bAutoSubscribe;
            dsProdExcept.AutoSubscribe = bAutoSubscribe; dsCastingData.AutoSubscribe = bAutoSubscribe;
            dsTundishData.AutoSubscribe = bAutoSubscribe;
            dsHeatTundishTemp.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsProcessStatus.LoadData();
                dsProdExcept.LoadData();
                dsCastingData.LoadData();
                dsTundishData.LoadData();
                dsHeatTundishTemp.LoadData();
            }
        }

        //预约割样通知[2009-03-11 Liao]
        int iCut = 0;
        private void dbxCutInformation_TextChanged(object sender, EventArgs e)
        {
            iCut++;
            if (iCut == 1)
                return;

            MessageBox.Show("接收到检化验的割样通知，请在连铸实绩中确认！", "提示");
            iCut--;
        }

        //2009-05-18
        private void dsLabElement_OnDataLoaded(object sender)
        {
            dvElementFormData();
            CommDataMag.CommonMethed.dv_CCMElement_Draw(dvProductElement, dsLabElement);
            //CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProductElement, dsElementStd, dsInCtrl, 5);
            int CLib = 0, Other3Lib = 0;
            for (int i = 0; i < dvProductElement.Columns.Count; i++)
            {
                if (dvProductElement.Columns[i].HeaderText == "C")
                    CLib = i;
                if (dvProductElement.Columns[i].HeaderText == "Other3")
                    Other3Lib = i;
            }
            for (int i = 4; i < dvProductElement.Rows.Count; i++)
            {
                for (int j = CLib; j < Other3Lib; j++)
                {
                    DataGridViewCell cell = dvProductElement.Rows[i].Cells[j];
                    try
                    {
                        //获取实绩成分列名
                        string strColumnName = dvProductElement.Columns[cell.ColumnIndex].HeaderText;
                        //取出数据
                        double dRealValue = Convert.ToDouble(cell.Value.ToString());
                        //判断是否校验
                        if (dRealValue > 0)
                        {
                            double dStdMax = Convert.ToDouble(dsElementStd.Tables[0].Rows[0][strColumnName + "_Max"].ToString());
                            double dStdMin = Convert.ToDouble(dsElementStd.Tables[0].Rows[0][strColumnName + "_Min"].ToString());
                            CommDataMag.CommonMethed.SetDataGridViewCellBackColor(cell, dStdMax, dStdMin, dRealValue);
                        }
                    }
                    catch { }
                }
            }
        }

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
        }

     

     

     

       
       


    }
}
