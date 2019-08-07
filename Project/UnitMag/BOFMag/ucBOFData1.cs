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
//    /// 项目
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
//    /// 试样类别
//    /// </summary>
//    public string strSampleType;
    
//}

namespace UnitMag.BOFMag
{
    public partial class ucBOFData1 : UserControl
    {
        public ucBOFData1()
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
                gbxBOFArr.Text = "等待处理的铁水";
                dvArrivleCCMSteel.Columns[0].HeaderText = "铁水";
                dvArrivleCCMSteel.Columns[2].HeaderText = "罐数";
               

            }
            else if (strUnitType == "3")
            {
               
            }

          
            LoadData();
            
        }

       
        private void ucBOFData_Load(object sender, EventArgs e)
        {
            SetDataGridViewCellStyle(dvSumAddition, 1, 1);
            SetDataGridViewCellStyle(dvAllay, 1, 1);            
            dsArrivleCCMSteel.L3DataAdapter = Adapter;

           
        }

        //当前界面隐藏后关闭所有Dataset的预约
        private void ucBOFData_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
              
                return;
            }
            else
            {
                PublicResource.pageUrl = UnitID + "BOF";
                if (m_UnitID.Substring(1, 1) == "2")
                {
                    timer1.Enabled = true;
                }                          
            }
        }

        public void LoadData()
        {
            TabPage tabpag = tabControl1.SelectedTab;
            switch (tabpag.Name)
            {
                case "tabPlan":
                    GetPlan();
                    break;
                case "tabStdElement":
                    GetElement();
                    break;
                case "tabProStd":
                    GetStd();
                    break;
                case "tabProcess":
                    GetProcess();
                    break;
                //case "tabBOFL2":
                //    Set_tabBOFL2_AutoSubscribe(true);
                //    break;
                default:
                    break;
            }
        }

        public void GetPlan()
        {

            MESService.WSMES mesService = new MESService.WSMES();
            var plan = mesService.GetPlan("BOF", UnitID);
            dvPlan.DataSource = plan.Tables["plan"];
            dvArrivleCCMSteel.DataSource = plan.Tables["iron"];

        }

        public void GetElement()
        {

            MESService.WSMES mesService = new MESService.WSMES();
            var dsElement = mesService.GetElement("BOF", UnitID);
            dvSlagele.DataSource = dsElement.Tables["slag"];

            dsElementStd.Tables.Clear();
            DataTable tbM = new DataTable();
            tbM = dsElement.Tables["product"].Clone();
            tbM = dsElement.Tables["product"].Copy();
            tbM.TableName = "product";
            dsElementStd.Tables.Add(tbM);

            dsInCtrl.Tables.Clear();
            DataTable tbM1 = new DataTable();
            tbM1 = dsElement.Tables["inctl"].Clone();
            tbM1 = dsElement.Tables["inctl"].Copy();
            tbM1.TableName = "inctl";
            dsInCtrl.Tables.Add(tbM1);

            dsLabElement.Tables.Clear();
            DataTable tbM2 = new DataTable();
            tbM2 = dsElement.Tables["element"].Clone();
            tbM2 = dsElement.Tables["element"].Copy();
            tbM2.TableName = "elment";
            dsLabElement.Tables.Add(tbM2);
            CommDataMag.CommonMethed.dv_ElementStd_Draw(dvProEle, dsElementStd, dsInCtrl);
            CommDataMag.CommonMethed.dv_Element_Draw(dvProEle, dsLabElement);
            CommDataMag.CommonMethed.SetDataGridViewCellBackColorByRow(dvProEle, dsElementStd, dsInCtrl, 7);

        }

        public void GetStd()
        {

            MESService.WSMES mesService = new MESService.WSMES();
            var dsElement = mesService.GetStd("BOF", UnitID);
            if (dsElement.Tables["base"].Rows.Count > 0)
            {
                dsBase.DataSource = dsElement.Tables["base"];
            }
            else
            {  //清空数据
                label240.Text = "";
                label235.Text = "";
                label222.Text = "";
                label249.Text = "";
            }
            if (dsElement.Tables["infurnace"].Rows.Count > 0)
            {
                dsInToConver.DataSource = dsElement.Tables["infurnace"];
            }
            else
            {
                lbIronSMax.Text = "";
                label10.Text = "";
                lbIronNiMax.Text = "";
                label9.Text = "";
                lbIronCrMax.Text = "";
                label8.Text = "";
                lbIronCuMax.Text = "";
                label7.Text = "";
                lbIronMnMax.Text = "";
                label6.Text = "";
                lbIronSbMax.Text = "";
                label5.Text = "";
                lbIronSnMax.Text = "";
                label4.Text = "";
                lbIronAsMax.Text = "";
                label3.Text = "";
                lbIronPbMax.Text = "";
                label1.Text = "";
                label11.Text = "";
            }
           
            dvTapping.DataSource = dsElement.Tables["tapping"];
            dvLadleMat.DataSource = dsElement.Tables["ladle"];
            if (dsElement.Tables["ar"].Rows.Count > 0)
            {
                dsAr.DataSource = dsElement.Tables["ar"];
            }
            else
            {
                label24.Text = "";
                label25.Text = "";
                label26.Text = "";
                label27.Text = "";

                label28.Text = "";
                label29.Text = "";
                label30.Text = "";
                label31.Text = "";
            }
           


        }

        public void GetProcess()
        {

            MESService.WSMES mesService = new MESService.WSMES();
            var dsElement = mesService.GetProcess("BOF", UnitID);
            if (dsElement.Tables["feed"].Rows.Count > 0)
            {
                dsFeed.DataSource = dsElement.Tables["feed"];
            }
            else
            {
                lbIronWeight.Text = "";
                lbScrapWeight.Text = "";
                lbPigIronWeight.Text = "";
                label14.Text = "";
                lbIronTemp.Text = "";
                lbFeedWT.Text = "";
                lbIronC.Text = "";
                lbIronSi.Text = "";
                lbIronMn.Text = "";

            }
            
            dsPro.DataSource= dsElement.Tables["process"];
            dvSumAddition.DataSource = dsElement.Tables["bulk"];
            dvAllay.DataSource = dsElement.Tables["alloy"];
            dvTemp.DataSource = dsElement.Tables["temp"];
            dvTestOxy.DataSource = dsElement.Tables["oxygen"];
            dataGridView8.DataSource = dsElement.Tables["status"];
           

            try
            {
                if (dsElement.Tables["process"].Rows.Count > 0)
                {
                    double iFeedS = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["S"].ToString());
                    double iFeedSi = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["Si"].ToString());
                    double iFeedP = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["P"].ToString());
                    double iInS = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["Iron_S_Max"].ToString());
                    double iInSi = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["Iron_Si_Max"].ToString());
                    double iInP = Convert.ToDouble(dsElement.Tables["feed"].Rows[0]["Iron_P_Max"].ToString());
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
            catch (Exception ex){ var a = ex.ToString(); }
        }

        private void dsLabElement_OnDataLoaded(object sender)
        {
           
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
                LoadData();
            }
            catch { }
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
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            string url = m_UnitID + "BOF";
            if (PublicResource.bofMenu && PublicResource.pageUrl == url)
            {
                LoadData();
            }
           
        }

    }
}

