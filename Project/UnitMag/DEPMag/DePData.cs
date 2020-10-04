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
            //�������
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
         
            //����ɷ�
           // dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'  order by UnitTypeID ,SAMPLE_COUNT  ";

  
            //dsProStatus.SourceMethod = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc ";

            dsStatus.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc ";
            //dsProStatus.SourceCondition =  "HeatID = '" + dbxHeatID.Text + "' order by Change_Time desc";

            //������Ϣ
            dsLabElement.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by LogTime desc";


            //dsFeedPro.SourceCondition = "MaterialID = '" + dbxIronLadle.Text.Trim() + "'";

            //ұ����Ϣ
            //dsProData.SourceCondition = "HeatID = '" + dbxHeatID.Text + "'";

            //����
           // dsAddition.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by DISCHARGE_TIME desc";

            //�����ۼ�[1/11/2009]
            dsSumAddition.SourceCondition = "HEATID = '" + dbxHeatID.Text + "'";

            // ����[12/28/2008 sun]
            dsTemp.SourceCondition = "HeatID = '" + dbxHeatID.Text + "' order by Temp_Time desc";

            // select a.other1_max,a.other2_max from CQA_PRODUCT_SHEET a, cplan_tapping b where a.steelgradeindex = b.steelgradeindex and b.heatid = '612000552'
            string strSql = "select a.other1_max,a.other2_max from CQA_PRODUCT_SHEET a, cplan_tapping b where a.steelgradeindex = b.steelgradeindex and b.heatid='" + dbxHeatID.Text + "'";
            var dt = UnitMag.MESTool.GetData(Adapter, strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["other1_max"] != null && dt.Rows[0]["other1_max"].ToString() != "")
                {
                    std_p = Convert.ToDouble(dt.Rows[0]["other1_max"]);
                }
                else
                {
                    std_p = 0;
                }

                if (dt.Rows[0]["other2_max"] != null && dt.Rows[0]["other2_max"].ToString() != "")
                {
                    std_si = Convert.ToDouble(dt.Rows[0]["other2_max"]);
                }
                else
                {
                    std_si = 0;
                }
            }

        }
        double std_p = 0, std_si = 0;

        //��L3DataSet��L3DataAdapter��ȡ���ݸ�ֵ��dv�У�Ȼ��ȡ����
        private void dsSetL3DataAdapter()
        {
            ////����
            //dsSlagele.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////ת¯��Ʒ�ɷݱ�׼
            //dsElementStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////�ڿظֳɷ�
            //dsInCtrl.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////������׼
            //dsBase.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////ɢ״�ϻ�׼
            //dsStdBulk.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////���ֱ�׼
            //dsTapping.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////�ְ�����
            //dsLadleMat.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";

            ////��¯�ɷ�
            //dsInFurnaceStd.SourceCondition = "SteelGradeIndex = '" + dbxSteelGradeIndex.Text + "'";
            
            ////�ǰ벺��¶�
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

        //��ǰ�������غ�ر�����Dataset��ԤԼ
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

        //���üƻ�tabҳ���Զ�ԤԼ����
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
            //strSQL += "select case when status=0 then '�ȴ�' when status=1 then '����' when status=2 and step=0  then '��̼1'  ";
            //strSQL += "when status=2 and step=1  then '��̼1'   when status=2 and step=2  then '��̼2'  when status=2 and step=3  then '��̼3'   when status=2 and step=4  then '��̼4'  ";
            //strSQL += "when status=2 and step=5  then '��̼5'  when status=2 and step=6  then '��̼6' when status=2 and step=7  then '��̼7'   when status=2 and step=8  then '��̼8' ";
            //strSQL += "when status=3 then '������ʼ'  when status=4 then '��������' when status=5 then '��ԭ' ";
            //strSQL += " when status=6 then '���ֿ�ʼ' when status=7 then '���ֽ���' else '�ȴ�' end as Status,Change_Time from caod_process_Status  where  ";

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

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 11)
                {
                    if (e.Value != null && Convert.ToDouble(e.Value) > std_si)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }

               
            }
            catch
            {

            }

            try
            {
                if (e.ColumnIndex == 13)
                {
                    if (e.Value != null && Convert.ToDouble(e.Value) > std_p)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }


            }
            catch
            {

            }
        }
    }
}

