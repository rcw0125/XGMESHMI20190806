using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

//public struct stctElementDataCommon
//{
//    /// <summary>
//    /// ��Ŀ
//    /// </summary>
//    public string strProject;

//    public string strC;
//    public string strSi;
//    public string strMn;
//    public string strP;
//    public string strS;

//    public string strAl;
//    public string strCr;
//    public string strTi;
//    public string strV;
//    public string strB;

//    public string strMo;
//    public string strNi;
//    public string strCa;
//    public string strCu;
//    public string strNb;

//    public string strSn;
//    public string strW;
//    public string strPb;
//    public string strZn;
//    public string strN;

//    public string strH;
//    public string strO;
//    public string strAs;
//    public string strAlS;
//    public string strSb;

//    public string strRe;
//    public string strCeq;
//    public string strCrNi;
//    public string strCrCu;
//    public string strCrNiCu;

//    public string strOther1;
//    public string strOther2;
//    public string strOther3;

//    /// <summary>
//    /// �������
//    /// </summary>
//    public string strSampleType;
    
//}

namespace UnitMag.BOFMag
{
    public partial class ucBOFData : UserControl
    {
        public ucBOFData()
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
            string strID = "S2" + m_UnitID.Substring(2, 1);

            if (strUnitType == "2")
            {
                //S10N01
                gbxBOFArr.Text = "�ȴ��������ˮ";
                dvArrivleCCMSteel.Columns[0].HeaderText = "��ˮ";
                dvArrivleCCMSteel.Columns[2].HeaderText = "����";
                dsArrivleCCMSteel.SourceCondition = "Position ='S10N01' order by Idx";

                dbxSteelGradeIndex.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
                dbxSteelGradeIndex.DataProperty = "SteelGradeIndex";

                dbxHeatID.DataObject = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
                dbxHeatID.DataProperty = "HeatID";

                Adapter.set_URIParameters("BOFID", m_UnitID);
                object objTemp = null;
                Adapter.Session.Get("XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\" + m_UnitID, "HeatID", ref objTemp);
                string HeatID = objTemp != null ? objTemp.ToString() : "";
                Adapter.set_URIParameters("HeatID", HeatID);
                objTemp = null;
                Adapter.Session.Get("XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\" + m_UnitID, "SteelGradeIndex", ref objTemp);
                string SteelGradeIndex = objTemp != null ? objTemp.ToString() : "";
                Adapter.set_URIParameters("SteelGradeIndex", SteelGradeIndex);

                dbxSteelGradeIndex.L3DataAdapter = Adapter;
                dbxHeatID.L3DataAdapter = Adapter;

            }
            else if (strUnitType == "3")
            {
                dsArrivleCCMSteel.SourceCondition = "Position = '" + m_UnitID + "P01' order by Idx";

                dbxSteelGradeIndex.DataObject = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\{BOFID}";
                dbxSteelGradeIndex.DataProperty = "SteelGradeIndex";

                dbxHeatID.DataObject = "XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\{BOFID}";
                dbxHeatID.DataProperty = "HeatID";

                Adapter.set_URIParameters("BOFID", m_UnitID);
                object objTemp = null;
                Adapter.Session.Get("XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\" + m_UnitID, "HeatID", ref objTemp);
                string HeatID = objTemp != null ? objTemp.ToString() : "";
                Adapter.set_URIParameters("HeatID", HeatID);
                objTemp = null;
                Adapter.Session.Get("XGMESLogic\\TapSideMag\\CTap_Unit_Mag\\" + m_UnitID, "SteelGradeIndex", ref objTemp);
                string SteelGradeIndex = objTemp != null ? objTemp.ToString() : "";
                Adapter.set_URIParameters("SteelGradeIndex", SteelGradeIndex);

                dbxSteelGradeIndex.L3DataAdapter = Adapter;
                dbxHeatID.L3DataAdapter = Adapter;
            }

            Adapter.set_URIParameters("BTID", strID);
            string strSQLPlan = "";

            //strSQLPlan += "select  e.heatid, e.planid, e.steelgradeindex, e.lfid, e.rhid, e.casterid,            ";
            //strSQLPlan += "                    e.status, e.createdate, e.preheatid, e.pre_steelgradeindex,       ";
            //strSQLPlan += "                    e.pre_steelgrade, e.bofid, e.bof_status, e.lf_status, e.rh_status,";
            //strSQLPlan += "                     e.caster_status, e.side_status, e.casting_no, e.casting_heat_cnt, ";
            //strSQLPlan += "                     e.fir_heat_flag, e.div_heatid, e.plan_ord_id, e.destitation,      ";
            //strSQLPlan += "                     e.steelgrade, e.protocol,e.other_tech_request,f.arrival_time,f.start_time,f.heatid           ";
            //strSQLPlan += "from (SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            //strSQLPlan += "                     a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            //strSQLPlan += "                     a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            //strSQLPlan += "                     a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            //strSQLPlan += "                     a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,      ";
            //strSQLPlan += "                     b.steelgrade, b.protocol,c.other_tech_request                   ";
            //strSQLPlan += "                FROM cplan_tapping a, cqa_steelgradeindex_r b,cplan_order c ";
            //strSQLPlan += "               WHERE a.steelgradeindex = b.steelgradeindex                    ";
            //strSQLPlan += "                 AND a.plan_ord_id = c.planid                                          ";
            //strSQLPlan += "                 AND a.bofid =  '" + strID + "'                                         ";
            //strSQLPlan += "                 AND a.status > 10                                                     ";
            //strSQLPlan += "                 AND (   a.createdate >= (SELECT SYSDATE                               ";
            //strSQLPlan += "                                            FROM DUAL) - 0.1667                         ";
            //strSQLPlan += "                      OR (a.createdate < (SELECT SYSDATE                               ";
            //strSQLPlan += "                                            FROM DUAL) - 0.1667 AND a.status < 13)      ";
            //strSQLPlan += "                     )                                                                 ";
            //strSQLPlan += "            ORDER BY a.heatid) e left  join clf_process_data f on e.heatid = f.heatid";


            strSQLPlan += "SELECT   a.heatid, a.planid, a.steelgradeindex, a.lfid, a.rhid, a.casterid,";
            strSQLPlan += "         a.status, a.createdate, a.preheatid, a.pre_steelgradeindex,       ";
            strSQLPlan += "         a.pre_steelgrade, a.bofid, a.bof_status, a.lf_status, a.rh_status,";
            strSQLPlan += "         a.caster_status, a.side_status, a.casting_no, a.casting_heat_cnt, ";
            strSQLPlan += "         a.fir_heat_flag, a.div_heatid, a.plan_ord_id, a.destitation,      ";
            strSQLPlan += "         b.steelgrade, b.protocol,c.other_tech_request                     ";
            strSQLPlan += "    FROM cplan_tapping a, cqa_steelgradeindex_r b,cplan_order c                          ";
            //�������
            dsPlan.SourceMethod = strSQLPlan + " where 1 = 2";

            strSQLPlan += "   WHERE a.steelgradeindex = b.steelgradeindex                             ";
            strSQLPlan += "     AND a.bofid = '" + strID + "'                                       ";
            strSQLPlan += "     AND a.plan_ord_id = c.planid                                       ";
            strSQLPlan += "     AND a.status > 10                                                     ";
            strSQLPlan += "     AND a.status <13                                                     ";
            //strSQLPlan += "     AND (   a.createdate >= (SELECT SYSDATE                               ";
            //strSQLPlan += "                                FROM DUAL) - 0.1667                         ";
            //strSQLPlan += "          OR (a.createdate < (SELECT SYSDATE                               ";
            //strSQLPlan += "                                FROM DUAL) - 0.1667 AND a.status < 13)      ";
            //strSQLPlan += "         )                                                                 ";
            strSQLPlan += "ORDER BY a.heatid                                                          ";

            dsPlan.SourceMethod = strSQLPlan;

            Adapter.RefreshDataBindings();
        }

        //���ּǺ�ԤԼ
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

        //������ԤԼ
        private void dbxHeatID_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;
            Adapter.DeleteURIParameter("HeatID");
            Adapter.set_URIParameters("HeatID", ctrl.Text);

            //��¯�ɷ�
            dsFeedDataStd.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //����ɷ�
            dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'  order by UnitTypeID ,SAMPLE_COUNT  ";

            //��ҵ״̬
            dsProStatus.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";

            //������Ϣ
            dsFeedPro.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //ұ����Ϣ
            dsProData.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //����
            dsAddition.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by DISCHARGE_TIME desc";

            //�����ۼ�[1/11/2009]
            dsSumAddition.SourceCondition = "HEATID = '" + dbxHeatID.Text + "' AND TYPE = 9 AND ELEMENT IS NOT NULL";

            // ����[12/28/2008 sun]
            dsTemp.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Temp_Time desc";

            // ���� [12/28/2008 sun]
            dsTestOxy.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Measure_Time desc";

            //ת¯����
            //dsBOFL2ModelData.SourceCondition = "Name = '{BOFID}'";

        }

        //��L3DataSet��L3DataAdapter��ȡ���ݸ�ֵ��dv�У�Ȼ��ȡ����
        private void dsSetL3DataAdapter()
        {
            //����
            dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //ת¯��Ʒ�ɷݱ�׼
            dsElementStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //�ڿظֳɷ�
            dsInCtrl.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //������׼
            dsBase.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //ɢ״�ϻ�׼
            dsStdBulk.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //���ֱ�׼
            dsTapping.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //�ְ�����
            dsLadleMat.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            //��¯�ɷ�
            dsInFurnaceStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            
            //�ǰ벺��¶�
            dsCQA_BOF_Std_Ar.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
        }

        private void ucBOFData_Load(object sender, EventArgs e)
        {
            SetDataGridViewCellStyle(dvSumAddition, 1, 1);
            SetDataGridViewCellStyle(dvAllay, 1, 1);
            
            dsPlan.L3DataAdapter = Adapter;
            dsArrivleCCMSteel.L3DataAdapter = Adapter;

            Set_TabPlan_AutoSubscribe(false);
            Set_tabStdElement_AutoSubscribe(false);
            Set_tabProStd_AutoSubscribe(false);
            Set_tabProcess_AutoSubscribe(false);
            //Set_tabBOFL2_AutoSubscribe(false);
        }

        //��ǰ�������غ�ر�����Dataset��ԤԼ
        private void ucBOFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                Set_TabPlan_AutoSubscribe(false);
                Set_tabStdElement_AutoSubscribe(false);
                Set_tabProStd_AutoSubscribe(false);
                Set_tabProcess_AutoSubscribe(false);
                //Set_tabBOFL2_AutoSubscribe(false);
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
                    //case "tabBOFL2":
                    //    Set_tabBOFL2_AutoSubscribe(true);
                    //    break;
                    default:
                        break;
                }
            }
        }

        //����ת¯���Ƽƻ���ɫ
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
                    Set_tabBOFL2_AutoSubscribe(false);
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

                            if (dsFeedDataStd.L3DataAdapter == null)
                                dsFeedDataStd.L3DataAdapter = Adapter;

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

                        //case "tabBOFL2":
                        //    l3dbxTappingStatus.L3DataAdapter = null;

                        //    if (dsBOFL2ModelData.L3DataAdapter == null)
                        //        dsBOFL2ModelData.L3DataAdapter = Adapter;
                           
                        //    Set_tabBOFL2_AutoSubscribe(true);
                        //    break;

                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        //���üƻ�tabҳ���Զ�ԤԼ����
        private void Set_TabPlan_AutoSubscribe(bool bAutoSubscribe)
        {
           // dsPlan.AutoSubscribe = bAutoSubscribe;
            dsArrivleCCMSteel.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                l3dbxTappingStatus.LoadData();
                dsPlan.LoadData();
                dsArrivleCCMSteel.LoadData();
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
            dsFeedDataStd.AutoSubscribe = bAutoSubscribe;
            dsProData.AutoSubscribe = bAutoSubscribe;
            dsProStatus.AutoSubscribe = bAutoSubscribe;
            dsAddition.AutoSubscribe = bAutoSubscribe;
            dsSumAddition.AutoSubscribe = bAutoSubscribe;
            dsTemp.AutoSubscribe = bAutoSubscribe;
            dsTestOxy.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsFeedPro.LoadData();
                dsFeedDataStd.LoadData();
                dsProData.LoadData();
                dsProStatus.LoadData();
                dsAddition.LoadData();
                dsSumAddition.LoadData();
                dsTemp.LoadData();
                dsTestOxy.LoadData();
            }
        }

        //tabBOFL2
        private void Set_tabBOFL2_AutoSubscribe(bool bAutoSubscribe)
        {
            dsBOFL2ModelData.AutoSubscribe = bAutoSubscribe;
            if (bAutoSubscribe)
            {
                dsBOFL2ModelData.LoadData();
            }
        }

        //�ֶ�����dv����������
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

        //������������
        private void dsFeedPro_OnDataLoaded(object sender)
        {
            try
            {
                string strWT = "";
                double dWt = 0;
                if (dsFeedPro.Tables[0].Rows.Count == 1)
                {
                    strWT = dsFeedPro.Tables[0].Rows[0]["IronWeight"].ToString();
                    dWt = dWt + double.Parse(strWT);

                    strWT = dsFeedPro.Tables[0].Rows[0]["ScrapWeight"].ToString();
                    dWt = dWt + double.Parse(strWT);

                    strWT = dsFeedPro.Tables[0].Rows[0]["PigIronWeight"].ToString();
                    dWt = dWt + double.Parse(strWT);

                    strWT = dsFeedPro.Tables[0].Rows[0]["Return_Steel_Weight"].ToString();
                    dWt = dWt + double.Parse(strWT);

                    lbFeedWT.Text = dWt.ToString();
                }
                else
                    lbFeedWT.Text = "";
            }
            catch { lbFeedWT.Text = ""; }
        }

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            dsPlan.LoadData();
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
                if (dsInFurnaceStd.Tables[0].Rows.Count > 0 && dsFeedDataStd.Tables[0].Rows.Count > 0)
                {
                    double iFeedS = Convert.ToDouble(dsFeedDataStd.Tables[0].Rows[0]["S"].ToString());
                    double iFeedSi = Convert.ToDouble(dsFeedDataStd.Tables[0].Rows[0]["Si"].ToString());
                    double iFeedP = Convert.ToDouble(dsFeedDataStd.Tables[0].Rows[0]["P"].ToString());
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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int iRet = cmdStaticCalculateBOFL2Model.Execute();
        //    if (iRet != 0 || (short)cmdStaticCalculateBOFL2Model.Command.Return != 666)
        //    {
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -1)
        //        {
        //            MessageBox.Show("��ȡת¯��������ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -2)
        //        {
        //            MessageBox.Show("��ȡ���ϻ������ݣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -3)
        //        {
        //            MessageBox.Show("��ȡ�յ�Ŀ������ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -4)
        //        {
        //            MessageBox.Show("��ȡ��ǰģ��ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -5)
        //        {
        //            MessageBox.Show("��ȡ�ϸֶ���ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -6)
        //        {
        //            MessageBox.Show("����ϸֳɷ�ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -7)
        //        {
        //            MessageBox.Show("���������ɷ�ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -8)
        //        {
        //            MessageBox.Show("����ͣ¯ʱ��ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -9)
        //        {
        //            MessageBox.Show("����ȴ�ʱ��ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -10)
        //        {
        //            MessageBox.Show("����ʯ�Ҽ�����ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -11)
        //        {
        //            MessageBox.Show("��������������ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -12)
        //        {
        //            MessageBox.Show("�����¶�ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -13)
        //        {
        //            MessageBox.Show("�¶��ж�ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -14)
        //        {
        //            MessageBox.Show("ɾ���ϸּ�¼ʧ�ܣ�", "��ʾ");
        //        }
        //        if ((short)cmdStaticCalculateBOFL2Model.Command.Return == -15)
        //        {
        //            MessageBox.Show("����ϸ��½�ʧ�ܣ�", "��ʾ");
        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show("����ɹ���", "��ʾ");
        //    }
        //}

    }
}

