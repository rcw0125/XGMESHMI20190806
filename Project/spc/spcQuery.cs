using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using C1.Win.C1Chart;
using System.Configuration;
using AppSvrHMI;
namespace spc
{
    public partial class spcQuery : DockContent, IMESForm
    {
        public spcQuery()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion
        public string unit = "";
        public string unit_like = "";
        public string qcitemcode = "";
        public string qctypecode = "";
        public string qc_des = "";
        public string maintype = "";
        public string steelgradeindex = "";
        public string steelgrade = "";
        public string DataObject = "";
        public string heatid = "";
        public string beginTimeLog = "";
        public string endTimeLog = "";
        public string unitLog = "";
        private SpcChartData test = new SpcChartData();




        private void Form1_Load(object sender, EventArgs e)
        {

            //cbItem.Items.Add("");

            cbUnit.Items.Add("1#炉");
            cbUnit.Items.Add("2#炉");
            cbUnit.Items.Add("3#炉");
            cbUnit.Items.Add("4#炉");
            cbUnit.Items.Add("1#LF");
            cbUnit.Items.Add("2#LF");
            cbUnit.Items.Add("3#LF");
            cbUnit.Items.Add("4#LF");
            cbUnit.Items.Add("5#LF");
            cbUnit.Items.Add("3#铸机");
            cbUnit.Items.Add("4#铸机");
            cbUnit.Items.Add("5#铸机");
            cbUnit.Items.Add("6#铸机");
            cbUnit.Items.Add("7#铸机");
            cbUnit.Items.Add("RH");

            





          

           // TabText = qc_des;
          


            #region 直方图表设置
            this.chartZhifang.DataSource = test;
            this.chartZhifang.Margin = Padding.Empty;
            this.chartZhifang.Padding = Padding.Empty;
            this.chartZhifang.ChartArea.Inverted = true;
            this.chartZhifang.ChartArea.Margins.SetMargins(0, 0, 0, 0);
            this.chartZhifang.ChartArea.PlotArea.SizeDefault = new Size(203, -1);
            this.chartZhifang.ChartArea.AxisX.Text = "数值";
            this.chartZhifang.ChartArea.AxisX.Thickness = 1;
            this.chartZhifang.ChartArea.AxisY.Text = "样本";
            this.chartZhifang.ChartArea.AxisY.Thickness = 1;

            ChartGroup zhifangGroup = chartZhifang.ChartGroups[0];
            zhifangGroup.ChartType = Chart2DTypeEnum.Histogram;
            zhifangGroup.Histogram.NormalDisplay.FillStyle.Alpha = 64;
            zhifangGroup.Histogram.NormalDisplay.FillStyle.Color1 = Color.Yellow;
            zhifangGroup.Histogram.NormalDisplay.Visible = true;
            // cg.Histogram.Normalized = true;

            zhifangGroup.ChartData.SeriesList.Clear();
            ChartDataSeries zfSeries = zhifangGroup.ChartData.SeriesList.AddNewSeries();
            zfSeries.FitType = FitTypeEnum.Spline;
            zfSeries.FillStyle.Alpha = 64;
            zfSeries.FillStyle.Color1 = Color.Blue;
            zfSeries.Histogram.IntervalCreationMethod = IntervalMethodEnum.SemiAutomatic;
            zfSeries.Histogram.DisplayType = DisplayTypeEnum.Histogram;
            zfSeries.X.DataField = "Data.X";
            zfSeries.Y.DataField = "Data.X";

            #endregion

            #region 单值图表设置
            this.chartDanzhi.DataSource = test;
            this.chartDanzhi.Margin = Padding.Empty;
            this.chartDanzhi.Padding = Padding.Empty;

            //this.chartDanzhi.Style.Border.BorderStyle = BorderStyleEnum.None;
            this.chartDanzhi.ToolTip.Enabled = true;
            this.chartDanzhi.ChartArea.Margins.SetMargins(0, 0, 0, 0);
            this.chartDanzhi.ChartArea.LocationDefault = new Point(0, -1);
            this.chartDanzhi.ChartArea.PlotArea.LocationDefault = new Point(2, -1);
            this.chartDanzhi.ChartArea.AxisX.Thickness = 1;
            this.chartDanzhi.ChartArea.AxisX.Text = "样本";
            this.chartDanzhi.ChartArea.AxisX.Visible = true;
            this.chartDanzhi.ChartArea.AxisY.Text = "数值";
            this.chartDanzhi.ChartArea.AxisY.Compass = CompassEnum.East;
            this.chartDanzhi.ChartArea.AxisY.Thickness = 1;
            this.chartDanzhi.ChartArea.AxisY.AnnoMethod = AnnotationMethodEnum.Mixed;
            this.chartDanzhi.ChartArea.AxisY.GridMajor.Pattern = LinePatternEnum.Solid;
            this.chartDanzhi.ChartArea.AxisY.OnTop = true;
            ValueLabel maxVl = this.chartDanzhi.ChartArea.AxisY.ValueLabels.AddNewLabel();
            maxVl.Appearance = ValueLabelAppearanceEnum.Label;
            maxVl.GridLine = true;
            maxVl.Moveable = true;
            maxVl.MarkerSize = 10;
            maxVl.Color = Color.Red;
            maxVl.Text = "上限";
            maxVl.ValueChanged += MarkerMoved;
            test.PropertyChanged += test_PropertyChanged;
         
            ValueLabel minVl = this.chartDanzhi.ChartArea.AxisY.ValueLabels.AddNewLabel();
            minVl.Appearance = ValueLabelAppearanceEnum.Label;
            //minVl.GridLine = true;
            //minVl.Moveable = true;
            minVl.GridLine = true;
            minVl.Moveable = true;
            minVl.MarkerSize = 10;
            minVl.Color = Color.Red;
            minVl.Text = "下限";
            minVl.ValueChanged += MarkerMoved;
            
               
            this.chartDanzhi.ShowTooltip += c1Chart1_ShowTooltip;
           

            this.chartDanzhi.ChartGroups[0].ChartData.SeriesList.Clear();
            this.chartDanzhi.ChartGroups[0].ChartType = Chart2DTypeEnum.XYPlot;
            ChartDataSeries dzSeries = this.chartDanzhi.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
            dzSeries.LineStyle.Pattern = LinePatternEnum.Solid;
            dzSeries.LineStyle.Color = Color.Black;
            dzSeries.SymbolStyle.Shape = SymbolShapeEnum.Star;
            dzSeries.SymbolStyle.Color = Color.DarkBlue;

            C1.Win.C1Chart.PointStyle ps = new C1.Win.C1Chart.PointStyle();
            ps.Selection = C1.Win.C1Chart.PointStyleSelectionEnum.Custom;
            ps.Select += ps_Select;
            chartDanzhi.ChartGroups[0].ChartData.PointStylesList.Add(ps);
            this.chartDanzhi.SizeChanged += c1Chart1_SizeChanged;
            #endregion

            #region 极差图表设置
            this.chartJicha.DataSource = test;
            this.chartJicha.ChartArea.AxisX.Text = "样本";
            this.chartJicha.ChartArea.AxisY.Text = "数值";
            this.chartJicha.ChartArea.AxisX.Thickness = 1;
            this.chartJicha.ChartArea.AxisY.Thickness = 1;
            this.chartJicha.Header.Visible = true;
            this.chartJicha.Header.Text = "移动极差MR图";
            ChartGroup jichaGroup = this.chartJicha.ChartGroups[0];
            jichaGroup.ChartType = Chart2DTypeEnum.XYPlot;
            jichaGroup.ChartData.SeriesList.Clear();
            ChartDataSeries MRSeries = jichaGroup.ChartData.SeriesList.AddNewSeries();
            MRSeries.LineStyle.Pattern = LinePatternEnum.Solid;
            MRSeries.LineStyle.Color = Color.DarkBlue;
            MRSeries.SymbolStyle.Shape = SymbolShapeEnum.Star;
            MRSeries.SymbolStyle.Color = Color.DarkRed;
            MRSeries.X.DataField = "Data.Idx";
            MRSeries.Y.DataField = "Data.R";
            #endregion
            //dbxHeatID.DataProperty = "HeatID";
            //dbxHeatID.DataObject = DataObject;

            gvAlarm.ContextMenuStrip = menuMain;

           // LoadBofData(unit, qcitem, steelgradeindex);
           // LoadBofData();

           // init();
        }


        //选择spc项目发生变化时，炉座发生变化
        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //炉座发生变化时，  
        private void cbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbUnit.SelectedIndex<4)
            {
                cbItem.Items.Clear();
                cbItem.Items.Add("终点C");
                cbItem.Items.Add("终点P");
                cbItem.Items.Add("进站C");
                cbItem.Items.Add("进站P");
                cbItem.Items.Add("成品P");
                cbItem.Items.Add("出钢量");
                cbItem.Items.Add("出钢氧含量");
            }
            else if (cbUnit.SelectedIndex < 9)
            {
                cbItem.Items.Clear();
                cbItem.Items.Add("离站C");
                cbItem.Items.Add("软吹开始温度");
                cbItem.Items.Add("软吹时间");
                cbItem.Items.Add("精炼渣碱度R");
                cbItem.Items.Add("精炼渣碱度Al2O3");
                cbItem.Items.Add("C增量");
                cbItem.Items.Add("大包温降");
                cbItem.Items.Add("钙线加入量");
            }
            else if (cbUnit.SelectedIndex < 14)
            {
                cbItem.Items.Clear();
                cbItem.Items.Add("中包温度");
                cbItem.Items.Add("转包时中包重量");
            }
            else if (cbUnit.SelectedIndex < 15)
            {
                cbItem.Items.Clear();
                cbItem.Items.Add("离站 C");
            }
        }
        //开始时间发生变化时，钢种选择发生变化
        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
           // loadSteelGrade();
        }
        //结束时间发生变化是，钢种选择发生变化
        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
           // loadSteelGrade();
        }
        //点击钢种选择时，加载钢种
        private void cbSteelGrade_MouseClick(object sender, MouseEventArgs e)
        {
            TimeSpan time = (DateTime)dtpEnd.Value - (DateTime)dtpBegin.Value;
            if (time.TotalDays > 190)
            {
                MessageBox.Show("查询日期期间过长，已超过半年");
                return;
            }
            loadSteelGrade();
        }

        public void loadSteelGrade()
        {
            if ((cbItem.Text == "") || (cbUnit.Text == ""))
            {
                return;
            }
            if ((dtpBegin.Text != beginTimeLog) || (dtpEnd.Text != endTimeLog)||(cbUnit.Text!=unitLog))
            {
                beginTimeLog = dtpBegin.Text;
                endTimeLog = dtpEnd.Text;
                unitLog = cbUnit.Text;
                cbSteelGrade.Items.Clear();
            }
            else
            {
                return;
            }
            string strSQL="";
          

            if (cbUnit.Text.Contains("炉"))
            {
                strSQL = "select distinct(steelgradeindex),PLAN_STEELGRADE from xgwebrpt.TS_ORIGINALDATA where logtime>='";
                strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                strSQL += " and bofid='" + cbUnit.Text.Substring(0, 1) + "' order by  PLAN_STEELGRADE";
            }
            else if (cbUnit.Text.Contains("LF"))
            {
                strSQL = "select distinct(steelgradeindex),STEELGRADE from xgwebrpt.TR_LF_ORIGINALDATA where logtime>='";
                strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                strSQL += " and lfid='" + cbUnit.Text.Substring(0, 1) + "' order by  STEELGRADE";
            }
            else if (cbUnit.Text.Contains("铸机"))
            {
                if (cbUnit.Text.Substring(0, 1) == "5")
                {

                    strSQL = "select distinct(steelgradeindex),STEEL_GRADE from xgwebrpt.TC_ORIGINALDATA_NO5 where logtime>='";
                    strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                    strSQL += " order by  STEEL_GRADE";
                }
                else if (cbUnit.Text.Substring(0, 1) == "7")
                {

                    strSQL = "select distinct(steelgradeindex),STEEL_GRADE from xgwebrpt.TC_ORIGINALDATA_NO7 where logtime>='";
                    strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                    strSQL +=  " order by  STEEL_GRADE";
                }
                else 
                {

                    strSQL = "select distinct(steelgradeindex),STEEL_GRADE from xgwebrpt.TC_ORIGINALDATA_NO3ANDNO4 where logtime>='";
                    strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                    strSQL += " and ccmid='" + "S6"+cbUnit.Text.Substring(0, 1) + "' order by  STEEL_GRADE";
                }
                
            }
            else if (cbUnit.Text.Contains("RH"))
            {
                strSQL = "select distinct(steelgradeindex),STEELGRADE from xgwebrpt.TR_RH_ORIGINALDATA where logtime>='";
                strSQL += dtpBegin.Text.Trim() + "' and  logtime<='" + dtpEnd.Text.Trim() + "'";
                strSQL +=  " order by  STEELGRADE";
            }

            try
            {
                AppSvrHMI.L3DataSet ds = new AppSvrHMI.L3DataSet();
                ds.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                ds.SourceMethod = strSQL;
                ds.L3DataAdapter = this.Adapter;
                ds.LoadData();


                if (ds.Tables[0].Rows.Count > 0)
                {

                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        cbSteelGrade.Items.Add(ds.Tables[0].Rows[i][1].ToString() + "---" + ds.Tables[0].Rows[i][0].ToString());
                    }
                }
            }
            catch
            { 
            
            }
         
            
            

        }

        //钢种发生变化时，
        private void cbSteelGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        void test_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "USL")
            {
                this.chartDanzhi.ChartArea.AxisY.ValueLabels[0].NumericValue = test.USL ?? 0;
            }
            else if (e.PropertyName == "LSL")
            {

                this.chartDanzhi.ChartArea.AxisY.ValueLabels[1].NumericValue = test.LSL ?? 0;
            }
        }
        
        void c1Chart1_ShowTooltip(object sender, ShowTooltipEventArgs e)
        {
            SpcDataItem item = test.Data[e.PointIndex];
            e.TooltipText = "炉次:" + item.HeatId + Environment.NewLine;
            e.TooltipText += "数值:" + item.X.ToString() + Environment.NewLine;
            string alarm = test.Data[e.PointIndex].AlarmType;

            if (!string.IsNullOrEmpty(alarm))
            {
                e.TooltipText += "报警类型:" + alarm;
            }
        }

        void c1Chart1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.chartZhifang.ChartArea.Location = new Point(this.chartZhifang.ChartArea.Location.X, this.chartDanzhi.ChartArea.Location.Y);
            this.chartZhifang.ChartArea.Size = new Size(this.chartZhifang.ChartArea.Size.Width, this.chartDanzhi.ChartArea.Size.Height);
        }

        void c1Chart1_SizeChanged(object sender, EventArgs e)
        {

            this.chartDanzhi.Refresh();
            this.chartZhifang.Header.Location = new Point(this.chartZhifang.Header.Location.X, this.chartDanzhi.Header.Location.Y);
            this.chartZhifang.ChartArea.Location = new Point(this.chartZhifang.ChartArea.Location.X, this.chartDanzhi.ChartArea.Location.Y);
            this.chartZhifang.ChartArea.Size = new Size(this.chartZhifang.Width - this.chartZhifang.ChartArea.Location.X, this.chartDanzhi.ChartArea.Size.Height);
        }

        void Form1_StyleChanged(object sender, EventArgs e)
        {
            this.chartZhifang.ChartArea.Location = new Point(this.chartZhifang.ChartArea.Location.X, this.chartDanzhi.ChartArea.Location.Y);
            this.chartZhifang.ChartArea.Size = new Size(this.chartZhifang.ChartArea.Size.Width, this.chartDanzhi.ChartArea.Size.Height);
        }

        void c1Chart1_Resize(object sender, EventArgs e)
        {
           
            this.chartZhifang.ChartArea.Location = new Point(this.chartZhifang.ChartArea.Location.X, this.chartDanzhi.ChartArea.Location.Y);
            this.chartZhifang.ChartArea.Size = new Size(this.chartZhifang.ChartArea.Size.Width, this.chartDanzhi.ChartArea.Size.Height);
        }
       //报警点颜色
        void ps_Select(object sender, PointStyleSelectEventArgs e)
        {
            if (e.SeriesIndex == 0)
            {
                C1.Win.C1Chart.PointStyle ps = sender as C1.Win.C1Chart.PointStyle;
                C1.Win.C1Chart.ChartDataSeries ds = chartDanzhi.ChartGroups[0].ChartData[e.SeriesIndex];
              //  test.Alarm(e.PointIndex);
               // double y = Convert.ToDouble(ds.X[e.PointIndex]);
                if (test.Data[e.PointIndex].AlarmType!="")
                {
                    //ps.LineStyle.Color = Color.Red;
                    ps.SymbolStyle.Shape = SymbolShapeEnum.Box;
                    ps.SymbolStyle.Color = Color.Red;
                    ps.LineStyle.Thickness =4;
                    e.Selected = true;
                }
         
            }
        }

  
 
       
        void MarkerMoved(object sender, EventArgs e)
        {
            ValueLabel vl = sender as ValueLabel;
            if (vl.Text == "上限")
            {
                test.USL = vl.NumericValue;
            }
            else if (vl.Text == "下限")
            {
                test.LSL = vl.NumericValue;
            }

        }
 
 
        /// <summary>
        /// 根据炼钢记号获取钢种
        /// </summary>
        /// <param name="strSteelGradeIndex">炼钢记号</param>
        /// <returns></returns>
        public  string GetSteelGradeBySteelGradeIndex(string strSteelGradeIndex)
        {
            try
            {
                if (strSteelGradeIndex == "")
                    return "";

                object Obj = new object();
                string strUri = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\";
                string strObjUri = strUri + strSteelGradeIndex;
                AppSvrIF.Session l3session = new AppSvrIF.Session();
                l3session.Get(strObjUri, "SteelGrade", ref Obj);
              
                return Obj.ToString();
            }
            catch
            {
                return "";
            }
        }
 

        /// <summary>
        /// 获取炼钢记号质检项的要求范围
        /// </summary>
        /// <param name="steelgradeindex"></param>
        /// <param name="qcitemname"></param>
        private void QcStd(string steelgradeindex, string qcitemname)
        {
            if (maintype=="tapping")
            {
                if (unit_like == "24%")
                {
                    test.USL = 80;
                    test.LSL = 76;
                }
                else
                {
                    test.USL = 50;
                    test.LSL = 46.5;
                }
                

            }

            else if (maintype == "tapping_o")

            {
                //帘线钢或轴承钢
                if (steelgrade.Contains("LX")||steelgrade.Contains("GCr")||(steelgrade=="CU1-LD"))
                {
                    test.USL = 450;
                    test.LSL = 0;
                }
                    //XGM6-H/XGM6/XGM6-1/JW-17/XGCT/XGDL/XGYT1/XGYT2
                else if ((steelgrade == "XGM6-H") || (steelgrade == "XGM6") || (steelgrade == "XGM6-1") || (steelgrade == "JW-17") || (steelgrade == "XGCT") || (steelgrade == "XGDL") || (steelgrade == "XGYT1") || (steelgrade == "XGYT2"))
                {
                    test.USL = 800;
                    test.LSL = 500;
                }
                    //XGYT0/XGL1/CH1A    CH1T/CH1T-1  DT4


                else if ((steelgrade == "XGYT0") || (steelgrade == "XGL1") || (steelgrade == "CH1A") || (steelgrade == "CH1T") || (steelgrade == "CH1T-1") || (steelgrade == "DT4"))
                {

                    //test.USL = 800;
                    test.LSL = 500;
                }
                //QSCM435-C(JSKZ-163-65)、GSCM435-CJY(JSKZ-163-50)  GSCM440-C
                else if ((steelgrade == "QSCM435-C") || (steelgrade == "GSCM435-CJY") || (steelgrade == "GSCM440-C"))
                {
                    test.USL = 400;
                    test.LSL = 0;
                }
                //GSCM435-A(JSKZ-163-10)、GSCM435-C(JSKZ-163-55、JSKZ-163-60、JSKZ-163-205)、GSCM435-CF(JSKZ-163-66)
                else if ((steelgrade == "GSCM435-A") || (steelgrade == "GSCM435-C") || (steelgrade == "GSCM435-CF"))
                {

                    test.USL = 500;
                    test.LSL = 0;
                }
                else
                { 
                
                }
                
            }
            else 
            {
                string qcitem_max = GetSteelGradeIndexQcStd(steelgradeindex, qcitemname + "_Max");
                string qcitem_min = GetSteelGradeIndexQcStd(steelgradeindex, qcitemname + "_Min");
                if (qcitem_max != "")
                {
                    test.USL = Convert.ToDouble(qcitem_max);
                }
                else
                {
                    test.USL = null;
                }


                if (qcitem_min != "")
                {
                    test.LSL = Convert.ToDouble(qcitem_min);
                }
                else
                {
                    test.LSL = null;
                }
                
            
            }

                

           
        }
      
        public  string GetSteelGradeIndexQcStd(string strSteelGradeIndex,string qcitem)
        {

            try
            {
                if (strSteelGradeIndex == "")
                    return "";

                object Obj = new object();
                string strUri = "";
                if (maintype=="jinzhan")
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_BOF_Std_InCtr_Ele\\";
                    if (qcitem == "P_Min")
                    {
                        return "0.0";
                    }
                }
                else if (maintype=="zhongdian")
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Tapping\\";
                    if (qcitem == "C_Max")
                    {
                        qcitem = "End_C_UpLimit";
                    }
                    else if (qcitem == "C_Min")
                    {
                        qcitem = "End_C_LowLimit";
                    }
                    else if (qcitem == "P_Max")
                    {
                        qcitem = "End_P_UpLimit";
                    }
                    else if (qcitem == "P_Min")
                    {
                        return "0.0";
                    }
                }

                else if((maintype=="chengpin")||(maintype=="lizhan"))
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_Product_Sheet\\";
                    if (qcitem == "P_Min")
                    {
                        return "0.0";
                    }
                }
               

                string strObjUri = strUri + strSteelGradeIndex;
                Adapter.Session.Get(strObjUri, qcitem, ref Obj);
                return Obj.ToString();
            }
            catch
            {
                return "";
            }
           // return "";
        }


        /// <summary>
        /// 更新图表数据
        /// </summary>
        public void RefreshChartData()

        {
            
            LoadBofData();

            init();
        }

        private void LoadBofData()
        {
            test.Clear();
            StringBuilder sqlSb = new StringBuilder();
            //to_Char(ProductionDate,'yyyy-MM-dd')>='";
            //    strSQL += dtpBegin.Text.Trim() + "' and  to_Char(ProductionDate,'yyyy-MM-dd')<='" + dtpEnd.Text.Trim() + "'";
            qc_des = cbUnit.Text + " " + cbItem.Text;
            int count = cbSteelGrade.Text.Length;
            if (count < 10)
            {
                return;
            }
           
            steelgrade = cbSteelGrade.Text.Substring(0, cbSteelGrade.Text.IndexOf("---"));
            steelgradeindex = cbSteelGrade.Text.Substring(cbSteelGrade.Text.IndexOf("---") + 3, count - 3 - cbSteelGrade.Text.IndexOf("---"));
            if (cbItem.Text == "终点C")
            {
                qcitemcode = "C";
                maintype = "zhongdian";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GT' as ANATYPE,'C' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.C_LUZ as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GT' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'",dtpBegin.Text,dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.C_LUZ >0");
                sqlSb.Append(" order by t1.heatid");

            }
            else if (cbItem.Text == "终点P")
            {
                qcitemcode = "P";
                maintype = "zhongdian";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GT' as ANATYPE,'P' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.P_LUZ as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from "); 
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GT' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.P_LUZ >0");
                sqlSb.Append(" order by t1.heatid");
            }
            else if (cbItem.Text == "出钢量")
            {
                qcitemcode = "CGL";
                maintype = "tapping";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'BOF' as ANATYPE,'CGL' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.tapping_weight as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.tapping_weight >0");
                sqlSb.Append(" order by t1.heatid");
            }
            else if (cbItem.Text == "出钢氧含量")
            {
                qcitemcode = "CGY";
                maintype = "tapping_o";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'BOF' as ANATYPE,'CGY' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.tapping_oxygen as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.tapping_oxygen >0");
                sqlSb.Append(" order by t1.heatid");
            }
            if (cbItem.Text == "进站C")
            {
                qcitemcode = "C";
                maintype = "jinzhan";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GG' as ANATYPE,'C' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.C_ARRIVAL_ELEMENT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GG' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.C_ARRIVAL_ELEMENT >0");
                sqlSb.Append(" order by t1.heatid");

            }
            else if (cbItem.Text == "进站P")
            {
                qcitemcode = "P";
                maintype = "jinzhan";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GT' as ANATYPE,'P' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.P_ARRIVAL_ELEMENT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GG' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.P_ARRIVAL_ELEMENT >0");
                sqlSb.Append(" order by t1.heatid");
            }
            else if (cbItem.Text == "成品P")
            {
                qcitemcode = "P";
                maintype = "chengpin";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GL' as ANATYPE,'P' as ANAITEM, ");
                sqlSb.Append("t1.CHARGING_START_TIME AS REPORT_DATE,t1.P_FIN as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TS_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GL' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.P_FIN >0");
                sqlSb.Append(" order by t1.heatid");
            }
            else  if (cbItem.Text == "离站C")
            {
                qcitemcode = "C";
                maintype = "lizhan";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.c_process as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GL' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.c_process >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "软吹时间")
            {
                qcitemcode = "SOFTBLOW_TIME";
                maintype = "L_P";
                if ((steelgrade.Contains("XGLX")))
                {

                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.softblow_time as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(" and t1.softblow_time >1800");
                    sqlSb.Append(" and t1.softblow_time <4200");
                    sqlSb.Append(" order by t1.HEAT_START_TIME ");
                }
                else
                {
                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.softblow_time as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(" and t1.softblow_time >480");
                    sqlSb.Append(" and t1.softblow_time <2400");
                    sqlSb.Append(" order by t1.HEAT_START_TIME ");
                }
               

            }
            else if (cbItem.Text == "软吹开始温度")
            {
                qcitemcode = "FEEDWIRE_TEMP";
                maintype = "L_P";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.FEEDWIRE_TEMP as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.FEEDWIRE_TEMP >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "精炼渣碱度R")
            {
                qcitemcode = "R";
                maintype = "zhayang";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.SLAGANALYSIS_R as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.SLAGANALYSIS_R >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME");

            }
            else if (cbItem.Text == "精炼渣碱度Al2O3")
            {
                qcitemcode = "Al2O3";
                maintype = "zhayang";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.SLAGANALYSIS_AL203 as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.SLAGANALYSIS_AL203 >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "C增量")
            {
                qcitemcode = "C";
                maintype = "c_add";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'C_ADD' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.C_FINISHED-t1.c_process as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='C_ADD' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.c_process >0");
                sqlSb.Append(" and t1.C_FINISHED >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "大包温降")
            {
                qcitemcode = "TEMP";
                maintype = "ladletemp_sub";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'LADLETEMP' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.casting_start_temp-casting_stop_temp as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='LADLETEMP' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.casting_start_temp >1450");
                sqlSb.Append(" and t1.casting_stop_temp >1450");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "钙线加入量")
            {
                qcitemcode = "Ga";
                maintype = "wire";
                sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'wire' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                sqlSb.Append("t1.HEAT_START_TIME AS REPORT_DATE,t1.SXCGBX_AMOUNT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.tr_lf_originaldata t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='wire' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                sqlSb.Append(string.Format(" and t1.lfid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.SXCGBX_AMOUNT >0");
                sqlSb.Append(" order by t1.HEAT_START_TIME ");

            }
            else if (cbItem.Text == "中包温度")
            {
                //包次第一炉不参与计算
                qcitemcode = "TEMP";
                maintype = "tundishtemp";
                if (cbUnit.Text.Substring(0, 1) == "5")
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.TUNDISHTEMP20 as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no5 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'", "5-1"));
                   // sqlSb.Append(string.Format(" and t1.ccmid='{0}'", cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(" and t1.TUNDISHTEMP20 >1450");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }
                else if (cbUnit.Text.Substring(0, 1) == "7")
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.TUNDISHTEMP15 as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no7 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                   // sqlSb.Append(string.Format(" and t1.ccmid='{0}'", cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'","7-1"));
                    sqlSb.Append(" and t1.TUNDISHTEMP15 >1450");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }
                else 
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.TUNDISHTEMP15 as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no3andno4 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    sqlSb.Append(string.Format(" and t1.ccmid='{0}'","S6"+ cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'", cbUnit.Text.Substring(0, 1)+"-1"));
                    sqlSb.Append(" and t1.TUNDISHTEMP15 >1450");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }
                

            }
            else if (cbItem.Text == "转包时中包重量")
            {
                //包次第一炉不参与计算
                qcitemcode = "CASTINGTUNDISHWEIGHT";
                maintype = "weight";
                if (cbUnit.Text.Substring(0, 1) == "5")
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.CASTINGTUNDISHWEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no5 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    //sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'", "5-1"));
                    // sqlSb.Append(string.Format(" and t1.ccmid='{0}'", cbUnit.Text.Substring(0, 1)));
                    sqlSb.Append(" and t1.CASTINGTUNDISHWEIGHT >5");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }
                else if (cbUnit.Text.Substring(0, 1) == "7")
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.CASTINGTUNDISHWEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no7 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    // sqlSb.Append(string.Format(" and t1.ccmid='{0}'", cbUnit.Text.Substring(0, 1)));
                   // sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'", "7-1"));
                    sqlSb.Append(" and t1.CASTINGTUNDISHWEIGHT >5");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }
                else
                {


                    sqlSb.Append("select distinct(t1.heatid) as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                    sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM, ");
                    sqlSb.Append("t1.CASTING_START_TIME AS REPORT_DATE,t1.CASTINGTUNDISHWEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                    sqlSb.Append("xgwebrpt.tc_originaldata_no3andno4 t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                    sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
                    sqlSb.Append(string.Format(" and t1.ccmid='{0}'", "S6" + cbUnit.Text.Substring(0, 1)));
                    //sqlSb.Append(string.Format(" and t1.TUNDISH_HEATCOUNT >'{0}'", cbUnit.Text.Substring(0, 1) + "-1"));
                    sqlSb.Append(" and t1.CASTINGTUNDISHWEIGHT >5");
                    sqlSb.Append(" order by t1.CASTING_START_TIME ");
                }


            }
            else if (cbItem.Text == "离站 C")
            {
                qcitemcode = "C";
                maintype = "lizhan";
                sqlSb.Append("select t1.heatid as HEATID,case when t1.team='1' then '甲班' when t1.team='2' then '乙班' when t1.team='3'  ");
                sqlSb.Append("then '丙班' when t1.team='4' then '丁班' end as team,t1.steelgradeindex,'RH' as ANATYPE,'C' as ANAITEM, ");
                sqlSb.Append("t1.START_TIME AS REPORT_DATE,t1.C_OUT_ANALYSIS as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from ");
                sqlSb.Append("xgwebrpt.TR_RH_ORIGINALDATA t1 left join xgwebrpt.SPC_Data t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='RH' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(string.Format(" where t1.logtime >='{0}' and t1.logtime <='{1}'", dtpBegin.Text, dtpEnd.Text));
                sqlSb.Append(string.Format(" and t1.steelgradeindex='{0}'", steelgradeindex));
               // sqlSb.Append(string.Format(" and t1.bofid='{0}'", cbUnit.Text.Substring(0, 1)));
                sqlSb.Append(" and t1.C_OUT_ANALYSIS >0");
                sqlSb.Append(" order by t1.heatid");

            }

        
           
            LoadData(sqlSb);
           // QcStd(steelgradeindex, qcitemcode);
            test.Refresh();
        
        }

 
        private void LoadData(StringBuilder sqlSb)
        {
            AppSvrHMI.L3DataSet dsLabElement = new AppSvrHMI.L3DataSet();
            dsLabElement.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            dsLabElement.SourceMethod = sqlSb.ToString();
            dsLabElement.L3DataAdapter = this.Adapter;
            dsLabElement.LoadData();
           
            if (dsLabElement.Tables.Count > 0)
            {
                if (dsLabElement.Tables[0].Rows.Count > 0)
                {
                    //表不为空时，计算标准
                   // steelgradeindex = dsLabElement.Tables[0].Rows[0]["steelgradeindex"].ToString();
                    QcStd(steelgradeindex, qcitemcode);

                    foreach (DataRow dr in dsLabElement.Tables[0].Rows)
                    {
                        SpcDataItem spc = new SpcDataItem(test.Data);

                        foreach (DataColumn col in dsLabElement.Tables[0].Columns)
                        {
                            if (col.ColumnName.ToUpper() == "HEATID")
                            {
                                spc.HeatId = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "VAL")
                            {
                                spc.X = dr.IsNull(col) ? 0 : Convert.ToDouble(dr[col]);
                            }
                            else if (col.ColumnName.ToUpper() == "REPORT_DATE")
                            {
                                spc.ShiJian = dr.IsNull(col) ? null : (DateTime?)Convert.ToDateTime(dr[col]);
                            }
                            else if (col.ColumnName.ToUpper() == "GUID")
                            {
                                spc.Guid = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "ANATYPE")
                            {
                                spc.AnaType = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "ANAITEM")
                            {
                                spc.AnaItem = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            //else if (col.ColumnName.ToUpper() == "ALARMTYPE")
                            //{
                            //    spc.AlarmType = dr.IsNull(col) ? "" : dr[col].ToString();
                            //}
                            else if (col.ColumnName.ToUpper() == "YUANYIN")
                            {
                                spc.YuanYin = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "TEAM")
                            {
                                spc.team = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "GAIJIN")
                            {
                                spc.GaiJin = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            //else if (col.ColumnName.ToUpper() == "AVGX")
                            //{
                            //   // spc.AvgX = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            //    if (dr.IsNull(col))
                            //    {
                            //        spc.AvgX = 0;
                            //    }
                            //    else
                            //    {
                            //        spc.AvgX = (double)Convert.ToDouble(dr[col]);
                            //    }
                               
                            //}
                            //else if (col.ColumnName.ToUpper() == "MR")
                            //{
                            //    //spc.MR = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            //    if (dr.IsNull(col))
                            //    {
                            //        spc.MR = 0;
                            //    }
                            //    else
                            //    {
                            //        spc.MR = (double)Convert.ToDouble(dr[col]);
                            //    }
                            //}
                            //else if (col.ColumnName.ToUpper() == "SD")
                            //{
                            //  //  spc.Sd = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            //}
                            //else if (col.ColumnName.ToUpper() == "MSE")
                            //{
                            //    if (dr.IsNull(col))
                            //    {
                            //        spc.Mse = 0;
                            //    }
                            //    else
                            //    {
                            //        spc.Mse = (double)Convert.ToDouble(dr[col]);
                            //    }
                            //  //  spc.Mse = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            //}
                           
                            spc.steelgradeindex = steelgrade;

                        }
                        //object obj_heatid = dr[0];
                        //if (obj_heatid != null && obj_heatid != DBNull.Value)
                        //{
                        //    string heatid = obj_heatid as string;
                           
                        //    object obj_val = dr[2];
                        //    if (obj_val != null && obj_val != DBNull.Value)
                        //    {
                        //        string val = obj_val as string;
                        //        SpcDataItem spc = test.Add(Convert.ToDouble(val));
                        //        spc.HeatId = heatid;
                        //        spc.ShiJian = Convert.ToDateTime(dr[1]); 
                        //    }
                        //}
                    }
                }
            }
            test.Refresh();
        }
        
        private void init()
        {

         //  test.USL = test.UCLx;
         //  test.LSL = test.LCLx;

            this.chartDanzhi.Header.Text =  qc_des +"单值X图";

            if (test.Sd > 0)
            {
                this.chartDanzhi.ChartArea.AxisY.Max = (test.AvgX + 5 * test.Sd)??1;
                this.chartDanzhi.ChartArea.AxisY.Min = (test.AvgX - 5 * test.Sd)??0;
                //if (this.chartDanzhi.ChartArea.AxisY.Min < 0)
                //    this.chartDanzhi.ChartArea.AxisY.Min = 0;
                if (test.Sd != null)
                    this.chartDanzhi.ChartArea.AxisY.UnitMajor = double.Parse(test.Sd.Value.ToString("#############0.0####"));
                this.chartDanzhi.ChartArea.AxisY.GridMinor.Visible=false; // = test.Sd / 2;

            }
           this.chartDanzhi.ChartArea.AxisX.Max = test.Data.Count+1;
           this.chartDanzhi.ChartArea.AxisX.Min = 0;
           this.chartDanzhi.ChartGroups[0].ChartData.SeriesList[0].X.DataField = "Data.Idx";
           this.chartDanzhi.ChartGroups[0].ChartData.SeriesList[0].Y.DataField = "Data.X";
           this.chartDanzhi.ChartArea.AxisY.ValueLabels[0].NumericValue = test.USL??0;
          // this.chartDanzhi.ChartArea.AxisY.ValueLabels[1].NumericValue = 0;
           //if (cmbQcItem.Text.Contains("P"))
           //{
           //    this.chartDanzhi.ChartArea.AxisY.ValueLabels[1].NumericValue = -100000;
           //    label12.Visible = false;
           //    txtLSL.Visible = false;
           //}
           //else 
           //{
               this.chartDanzhi.ChartArea.AxisY.ValueLabels[1].NumericValue = test.LSL ?? 0;
              // label12.Visible = true;
               //txtLSL.Visible = true;
           //}
           

           //this.chartZhifang.DataSource = test;
           this.chartZhifang.ChartGroups[0].ChartData.SeriesList[0].Histogram.IntervalStart = 0;
           this.chartZhifang.ChartGroups[0].ChartData.SeriesList[0].Histogram.IntervalWidth = test.ZFIntervalWidth??1;
           this.chartZhifang.ChartGroups[0].ChartData.SeriesList[0].Histogram.IntervalNumber = 48;
           this.chartZhifang.ChartGroups[0].ChartData.SeriesList[0].X.DataField = "Data.X";
           this.chartZhifang.ChartGroups[0].ChartData.SeriesList[0].Y.DataField = "Data.X";
           try
           {
               this.chartZhifang.ChartArea.AxisX.Max = this.chartDanzhi.ChartArea.AxisY.Max;
               this.chartZhifang.ChartArea.AxisX.Min = this.chartDanzhi.ChartArea.AxisY.Min;
           }catch
           {
           }
           this.chartZhifang.Refresh();

            Color[] colors = new Color[] { Color.FromArgb(255, 192, 192), Color.FromArgb(255, 255, 192), Color.FromArgb(192, 255, 192), Color.FromArgb(192, 255, 192), Color.FromArgb(255, 255, 192), Color.FromArgb(255, 192, 192) };
            double avg = test.AvgX??0;
            double c = test.Sd??0;
            this.chartDanzhi.ChartArea.PlotArea.AlarmZones.Clear();
            AlarmZone[] zones = new AlarmZone[6];
            for (int i = 0; i < 6; i++)
            {
                AlarmZone zone = this.chartDanzhi.ChartArea.PlotArea.AlarmZones.AddNewZone();
                zone.Name = "稍大" + i.ToString();
                zone.BackColor = colors[i];
               // zone.UpperExtent = this.c1Chart1.ChartArea.AxisY.Max;
               // zone.LowerExtent = this.c1Chart1.ChartArea.AxisY.Min;
                zone.UpperExtent = avg + (i - 2) * c;
                if (i > 0)
                    zone.LowerExtent = zones[i - 1].UpperExtent;
                else
                    zone.LowerExtent = avg + (i - 3) * c;
                zones[i] = zone;
                zone.Visible = true;
            }

            this.chartJicha.DataSource = test;
            this.chartJicha.ChartGroups[0].ChartData.SeriesList[0].X.DataField = "Data.Idx";
            this.chartJicha.ChartGroups[0].ChartData.SeriesList[0].Y.DataField = "Data.R";
            this.chartJicha.ChartArea.PlotArea.AlarmZones.Clear();
            AlarmZone z1 = this.chartJicha.ChartArea.PlotArea.AlarmZones.AddNewZone();
            z1.Name = "小";
            z1.BackColor = Color.FromArgb(192, 255, 192);

            z1.Visible = true;
            AlarmZone z2 = this.chartJicha.ChartArea.PlotArea.AlarmZones.AddNewZone();
            z2.Name = "大";
            z2.BackColor = Color.FromArgb(255, 255, 192);  
            z2.Visible = true;
       
            z1.UpperExtent = test.UCLr??0;
            z1.LowerExtent = test.LCLr??0;
            z2.UpperExtent = this.chartJicha.ChartArea.AxisY.Max;
            z2.LowerExtent = test.UCLr??0;

            //this.txtAvgX.Text = test.AvgX.ToString("######0.00##");
            //this.txtC.Text = test.C.ToString("######0.00##");
            //this.txtUCLx.Text = test.UCLx.ToString("######0.00##");
            //this.txtLCLx.Text = test.LCLx.ToString("######0.00##");
            //this.txtMR.Text = test.AvgMR.ToString("######0.00##");
            //this.txtUCLr.Text = test.UCLr.ToString("######0.00##");
            //this.txtLCLr.Text = test.LCLr.ToString("######0.00##");
            //this.txtCp.Text = test.Cp.ToString("######0.00##");
            //this.txtCpk.Text = test.Cpk.ToString("######0.00##");
            //this.txtPp.Text = test.Pp.ToString("######0.00##");
            //this.txtPpk.Text = test.Ppk.ToString("######0.00##");
            //this.txtUSL.Text = test.USL.ToString();
            //this.txtLSL.Text = test.LSL.ToString();
            this.chartDanzhi.Refresh();

            //this.gvAlarm.DataSource = test.orderItem();
            SpcData spcData = test.orderItem();
            if (spcData.Count > 0)
            {
                gvAlarm.Rows.Clear();
                gvAlarm.AllowUserToAddRows = true;
                for (int i = 0; i < spcData.Count; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    gvAlarm.Rows.Add(row);

                    gvAlarm.Rows[i].Cells["ClIdx"].Value = spcData[i].Idx;
                    gvAlarm.Rows[i].Cells["ClShiJian"].Value = spcData[i].ShiJian;
                    gvAlarm.Rows[i].Cells["Clteam"].Value = spcData[i].team;
                    gvAlarm.Rows[i].Cells["ClHeatId"].Value = spcData[i].HeatId;
                    gvAlarm.Rows[i].Cells["Clsteelgradeindex"].Value = spcData[i].steelgradeindex;
                    gvAlarm.Rows[i].Cells["Clalarmtype"].Value = spcData[i].AlarmType;
                    gvAlarm.Rows[i].Cells["ClYuanYin"].Value = spcData[i].YuanYin;
                    gvAlarm.Rows[i].Cells["ClGaiJin"].Value = spcData[i].GaiJin;
                    gvAlarm.Rows[i].Cells["ClGuid"].Value = spcData[i].Guid;
                    gvAlarm.Rows[i].Cells["Clx"].Value = spcData[i].X;
                    gvAlarm.Rows[i].Cells["Clr"].Value = spcData[i].R;
                    gvAlarm.Rows[i].Cells["ClUsl"].Value = spcData[i].USL;
                    gvAlarm.Rows[i].Cells["ClLsl"].Value = spcData[i].LSL;

                    gvAlarm.Rows[i].Cells["ClAvgX"].Value = spcData[i].AvgX;
                    gvAlarm.Rows[i].Cells["ClSd"].Value = spcData[i].Sd;
                    gvAlarm.Rows[i].Cells["ClUslx"].Value = spcData[i].USLX;
                    gvAlarm.Rows[i].Cells["ClLslx"].Value = spcData[i].LSLX;
                    gvAlarm.Rows[i].Cells["ClMR"].Value = spcData[i].MR;
                    gvAlarm.Rows[i].Cells["ClUslr"].Value = spcData[i].USLR;
                    gvAlarm.Rows[i].Cells["ClLslr"].Value = spcData[i].LSLR;
                    gvAlarm.Rows[i].Cells["ClCp"].Value = spcData[i].Cp;
                    gvAlarm.Rows[i].Cells["C1Cpk"].Value = spcData[i].Cpk;
                    gvAlarm.Rows[i].Cells["ClPp"].Value = spcData[i].Pp;
                    gvAlarm.Rows[i].Cells["C1Ppk"].Value = spcData[i].Ppk;

                    gvAlarm.Rows[i].Cells["ClMse"].Value = spcData[i].Mse;
                    gvAlarm.Rows[i].Cells["ClAnaItem"].Value = spcData[i].AnaItem;
                    gvAlarm.Rows[i].Cells["ClAnaType"].Value = spcData[i].AnaType;
                
                }
                gvAlarm.AllowUserToAddRows = false;
            
            }
           


        }

        private string Save(string sql)
        {




            if (!string.IsNullOrEmpty(sql))
            {
                AppSvrIF.Command cmd = null;

                int result = Adapter.Session.CreateCommand(14, sql, "", ref cmd);
                if (result == 0)
                {
                    int i = Adapter.Session.Execute(cmd);
                    if (i > 0)
                    {
                        return "0";
                    }

                }
                else
                {
                    return "0";
                }
                
            }
            return "1";
               // MessageBox.Show("保存成功");
               // btnSave.Enabled = true;

            
        
        }

     
  

        private void gvAlarm_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {

                if (gvAlarm.Rows[e.RowIndex].Cells["Clalarmtype"].Value.ToString() != "" && gvAlarm.Rows[e.RowIndex].Cells["ClYuanYin"].Value.ToString() == "" && gvAlarm.Rows[e.RowIndex].Cells["ClGaiJin"].Value.ToString() == "")
                {

                    //gvAlarm.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Red;

                    gvAlarm.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                }
                //else
                //{
                //    if (e.RowIndex > 0)
                //    {
                //        gvAlarm.Rows[e.RowIndex].Visible = false;
                //    }

                //}
            }
            catch
            {
                return;
            }
            
        }

        private void gvAlarm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string heatid = gvAlarm.Rows[e.RowIndex].Cells["ClHeatID"].Value.ToString();
            string alarmtype = gvAlarm.Rows[e.RowIndex].Cells["Clalarmtype"].Value.ToString();
            if (alarmtype == "")
            {
                MessageBox.Show("该炉次没有报警，请选择有报警类型的炉次");
                return;
            }
            string yuanyin = gvAlarm.Rows[e.RowIndex].Cells["ClYuanYin"].Value.ToString();
            string gaijin = gvAlarm.Rows[e.RowIndex].Cells["ClGaiJin"].Value.ToString();
            string _yuanyin = yuanyin, _gaijin = gaijin;
            String bofunit = qc_des.Substring(0, 3);
            Remark re = new Remark();
            re.remark(heatid, alarmtype, ref yuanyin,ref  gaijin,maintype+qcitemcode,this.Adapter.Session);
            if ((_yuanyin != yuanyin) || (_gaijin != gaijin))
            {
                gvAlarm.Rows[e.RowIndex].Cells["ClYuanYin"].Value = yuanyin;
                gvAlarm.Rows[e.RowIndex].Cells["ClGaiJin"].Value = gaijin;
          //      MessageBox.Show(heatid + "-" + alarmtype + "-" + yuanyin + "-" + gaijin);

                if ((string)gvAlarm.Rows[e.RowIndex].Cells["ClGuid"].Value == "")
                {

                    StringBuilder sb = new StringBuilder();
                    // Guid = System.Guid.NewGuid().ToString().Replace("-", "");
                    DateTime nowtime = DateTime.Now;
                    string AnaType = gvAlarm.Rows[e.RowIndex].Cells["ClAnaType"].Value.ToString();
                    string AnaItem = gvAlarm.Rows[e.RowIndex].Cells["ClAnaItem"].Value.ToString();
                    double AvgX = (double)gvAlarm.Rows[e.RowIndex].Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.Rows[e.RowIndex].Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMse"].Value;
                    string  Cpk = gvAlarm.Rows[e.RowIndex].Cells["C1Cpk"].Value.ToString();
                    string  Ppk = gvAlarm.Rows[e.RowIndex].Cells["C1Ppk"].Value.ToString();
                    string Guid = heatid + AnaType + AnaItem;

                    DateTime productTime = (DateTime)gvAlarm.Rows[e.RowIndex].Cells["ClShiJian"].Value;
                    string strTeam = gvAlarm.Rows[e.RowIndex].Cells["Clteam"].Value.ToString();
                    if (strTeam == "甲班")
                    {
                        strTeam = "1";
                    }
                    else if (strTeam == "乙班")
                    {
                        strTeam = "2";
                    }
                    else if (strTeam == "丙班")
                    {
                        strTeam = "3";
                    }
                    else if (strTeam == "丁班")
                    {
                        strTeam = "4";
                    }
                    
                  //  string insert_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string insert_operator = Adapter.Session.User;

                    
                    sb.Append("INSERT INTO SPC_AlarmData(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,");
                    sb.Append("AvgX,MR,Sd,Cpk,Ppk,unit,steelgradeindex,steelgrade,team,flag,PRODUCTIONDATE,MSE) Values(");
                    sb.Append("'" + Guid + "',");
                    sb.Append("'" + heatid + "',");
                    sb.Append("'" + AnaType + "',");
                    sb.Append("'" + AnaItem + "',");
                    sb.Append("'" + alarmtype + "',");
                    sb.Append("'" + yuanyin + "',");
                    sb.Append("'" + gaijin + "',");
                    sb.Append("'" + nowtime + "',");
                    sb.Append("'" + insert_operator + "',");
                    sb.Append(AvgX + ",");
                    sb.Append(MR + ",");
                    sb.Append(Sd + ",");
                    sb.Append("'" + Cpk + "',");

                    sb.Append("'" + Ppk + "',");
                    sb.Append("'" + cbUnit.Text + "',");
                    sb.Append("'" + steelgradeindex + "',");
                    sb.Append("'" + steelgrade + "',");
                    sb.Append("'" + strTeam + "',");
                    sb.Append("'1',");
                    sb.Append("'" + productTime + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    string sql = sb.ToString();
                    string result=Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                    //存入报表数据库
                    sb.Length = 0;
                    sb.Append("INSERT INTO xgwebrpt.SPC_Data(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,");
                    sb.Append("AvgX,MR,Sd,Cpk,Ppk,unit,steelgradeindex,steelgrade,team,flag,PRODUCTIONDATE,MSE) Values(");
                    sb.Append("'" + Guid + "',");
                    sb.Append("'" + heatid + "',");
                    sb.Append("'" + AnaType + "',");
                    sb.Append("'" + AnaItem + "',");
                    sb.Append("'" + alarmtype + "',");
                    sb.Append("'" + yuanyin + "',");
                    sb.Append("'" + gaijin + "',");
                    sb.Append("'" + nowtime + "',");
                    sb.Append("'" + insert_operator + "',");
                    sb.Append(AvgX + ",");
                    sb.Append(MR + ",");
                    sb.Append(Sd + ",");
                    sb.Append("'" + Cpk + "',");

                    sb.Append("'" + Ppk + "',");
                    sb.Append("'" + cbUnit.Text + "',");
                    sb.Append("'" + steelgradeindex + "',");
                    sb.Append("'" + steelgrade + "',");
                    sb.Append("'" + strTeam + "',");
                    sb.Append("'1',");
                    sb.Append("'" + productTime + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    sql = sb.ToString();
                    result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                    gvAlarm.CurrentRow.Cells["ClGuid"].Value = Guid;
                    MessageBox.Show("保存成功");


                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    DateTime nowtime = DateTime.Now;
                   
                    double AvgX = (double)gvAlarm.Rows[e.RowIndex].Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.Rows[e.RowIndex].Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMse"].Value;
                    string  Cpk = gvAlarm.Rows[e.RowIndex].Cells["C1Cpk"].Value.ToString();
                    //double Ppk = (double)gvAlarm.Rows[e.RowIndex].Cells["C1Ppk"].Value;
                    string  Ppk = gvAlarm.Rows[e.RowIndex].Cells["C1Ppk"].Value.ToString();
                    //string Guid = heatid + AnaType + AnaItem;

                    //string update_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string update_operator = Adapter.Session.User;
                    sb.Append("Update SPC_AlarmData Set ");
                    sb.Append(" AlarmType='" + alarmtype + "',");
                    sb.Append(" YuanYin='" + yuanyin + "',");
                    sb.Append(" GaiJin='" + gaijin + "',");
                    sb.Append(" AvgX=" + AvgX + ",");
                    sb.Append(" MR=" + MR + ",");
                    sb.Append(" Sd=" + Sd + ",");
                    sb.Append(" Cpk='" + Cpk + "',");
                    //sb.Append(" Ppk=" + Ppk + ",");
                    sb.Append(" Ppk='" + Ppk + "',");
                    sb.Append(" update_time='" + nowtime + "',");
                    sb.Append(" update_operator='" + update_operator + "',");
                    sb.Append(" Mse=" + Mse);
                    //  sb.Append(" operator=" + update_operator + ",");
                    // sb.Append(" update_time=" + nowtime);
                    sb.Append(" Where Guid='" + gvAlarm.Rows[e.RowIndex].Cells["ClGuid"].Value.ToString().Trim() + "'");
                    string  sql = sb.ToString();
                    string result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                   //存入报表数据库
                    sb.Length = 0;
                    sb.Append("Update xgwebrpt.SPC_Data Set ");
                    sb.Append(" AlarmType='" + alarmtype + "',");
                    sb.Append(" YuanYin='" + yuanyin + "',");
                    sb.Append(" GaiJin='" + gaijin + "',");
                    sb.Append(" AvgX=" + AvgX + ",");
                    sb.Append(" MR=" + MR + ",");
                    sb.Append(" Sd=" + Sd + ",");
                    sb.Append(" Cpk='" + Cpk + "',");
                    //sb.Append(" Ppk=" + Ppk + ",");
                    sb.Append(" Ppk='" + Ppk + "',");
                    sb.Append(" update_time='" + nowtime + "',");
                    sb.Append(" update_operator='" + update_operator + "',");
                    sb.Append(" Mse=" + Mse);
                    //  sb.Append(" operator=" + update_operator + ",");
                    // sb.Append(" update_time=" + nowtime);
                    sb.Append(" Where Guid='" + gvAlarm.Rows[e.RowIndex].Cells["ClGuid"].Value.ToString().Trim() + "'");
                    sql = sb.ToString();
                   result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }
                    MessageBox.Show("保存成功");
                
                }
                
                
               
                //    sql = sb.ToString();
            }
            
            
        }


        private void 记录原因ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            string heatid = gvAlarm.CurrentRow.Cells["ClHeatID"].Value.ToString();
            string alarmtype = gvAlarm.CurrentRow.Cells["Clalarmtype"].Value.ToString();
            if (alarmtype == "")
            {
                MessageBox.Show("该炉次没有报警，请选择有报警类型的炉次");
                return;
            }
            string yuanyin = gvAlarm.CurrentRow.Cells["ClYuanYin"].Value.ToString();
            string gaijin = gvAlarm.CurrentRow.Cells["ClGaiJin"].Value.ToString();
            string _yuanyin = yuanyin, _gaijin = gaijin;
            String bofunit = qc_des.Substring(0,3);
            Remark re = new Remark();
           // re.remark(heatid, alarmtype, ref yuanyin, ref  gaijin);
            re.remark(heatid, alarmtype, ref yuanyin, ref  gaijin, maintype + qcitemcode, this.Adapter.Session);
            
           
            if ((_yuanyin != yuanyin) || (_gaijin != gaijin))
            {
                gvAlarm.CurrentRow.Cells["ClYuanYin"].Value = yuanyin;
                gvAlarm.CurrentRow.Cells["ClGaiJin"].Value = gaijin;
                //      MessageBox.Show(heatid + "-" + alarmtype + "-" + yuanyin + "-" + gaijin);

                if ((string)gvAlarm.CurrentRow.Cells["ClGuid"].Value == "")
                {

                    StringBuilder sb = new StringBuilder();
                    // Guid = System.Guid.NewGuid().ToString().Replace("-", "");
                    DateTime nowtime = DateTime.Now;
                    string AnaType = gvAlarm.CurrentRow.Cells["ClAnaType"].Value.ToString();
                    string AnaItem = gvAlarm.CurrentRow.Cells["ClAnaItem"].Value.ToString();
                    double AvgX = (double)gvAlarm.CurrentRow.Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.CurrentRow.Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.CurrentRow.Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.CurrentRow.Cells["ClMse"].Value;
                    string  Cpk = gvAlarm.CurrentRow.Cells["C1Cpk"].Value.ToString();
                    string  Ppk = gvAlarm.CurrentRow.Cells["C1Ppk"].Value.ToString();
                    string Guid = heatid + AnaType + AnaItem;
                   // Column7
                    DateTime productTime = (DateTime)gvAlarm.CurrentRow.Cells["ClShiJian"].Value;
                    string strTeam = gvAlarm.CurrentRow.Cells["Clteam"].Value.ToString();
                    if (strTeam == "甲班")
                    {
                        strTeam = "1";
                    }
                     else if (strTeam == "乙班")
                    {
                        strTeam = "2";
                    }
                    else if (strTeam == "丙班")
                    {
                        strTeam = "3";
                    }
                    else if (strTeam == "丁班")
                    {
                        strTeam = "4";
                    }
                    //  string insert_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string insert_operator = Adapter.Session.User;

                    sb.Append("INSERT INTO SPC_AlarmData(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,");
                    sb.Append("AvgX,MR,Sd,Cpk,Ppk,unit,steelgradeindex,steelgrade,team,flag,PRODUCTIONDATE,MSE) Values(");
                    sb.Append("'" + Guid + "',");
                    sb.Append("'" + heatid + "',");
                    sb.Append("'" + AnaType + "',");
                    sb.Append("'" + AnaItem + "',");
                    sb.Append("'" + alarmtype + "',");
                    sb.Append("'" + yuanyin + "',");
                    sb.Append("'" + gaijin + "',");
                    sb.Append("'" + nowtime + "',");
                    sb.Append("'" + insert_operator + "',");
                    sb.Append(AvgX + ",");
                    sb.Append(MR + ",");
                    sb.Append(Sd + ",");
                    sb.Append("'" + Cpk + "',");

                    sb.Append("'" + Ppk + "',");
                    sb.Append("'" + cbUnit.Text + "',");
                    sb.Append("'" + steelgradeindex + "',");
                    sb.Append("'" + steelgrade + "',");
                    sb.Append("'" + strTeam + "',");
                    sb.Append("'1',");
                    sb.Append("'" + productTime + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    string sql = sb.ToString();
                    string result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }
                    //存入报表数据库
                    sb.Length = 0;
                    sb.Append("INSERT INTO xgwebrpt.SPC_Data(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,");
                    sb.Append("AvgX,MR,Sd,Cpk,Ppk,unit,steelgradeindex,steelgrade,team,flag,PRODUCTIONDATE,MSE) Values(");
                    sb.Append("'" + Guid + "',");
                    sb.Append("'" + heatid + "',");
                    sb.Append("'" + AnaType + "',");
                    sb.Append("'" + AnaItem + "',");
                    sb.Append("'" + alarmtype + "',");
                    sb.Append("'" + yuanyin + "',");
                    sb.Append("'" + gaijin + "',");
                    sb.Append("'" + nowtime + "',");
                    sb.Append("'" + insert_operator + "',");
                    sb.Append(AvgX + ",");
                    sb.Append(MR + ",");
                    sb.Append(Sd + ",");
                    sb.Append("'" + Cpk + "',");
                    sb.Append("'" + Ppk + "',");
                    sb.Append("'" + cbUnit.Text + "',");
                    sb.Append("'" + steelgradeindex + "',");
                    sb.Append("'" + steelgrade + "',");
                    sb.Append("'" + strTeam + "',");
                    sb.Append("'1',");
                    sb.Append("'" + productTime + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    sql = sb.ToString();
                    result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                    gvAlarm.CurrentRow.Cells["ClGuid"].Value = Guid;
                    MessageBox.Show("保存成功");


                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    DateTime nowtime = DateTime.Now;

                    double AvgX = (double)gvAlarm.CurrentRow.Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.CurrentRow.Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.CurrentRow.Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.CurrentRow.Cells["ClMse"].Value;
                    string Cpk = gvAlarm.CurrentRow.Cells["C1Cpk"].Value.ToString();
                    string Ppk = gvAlarm.CurrentRow.Cells["C1Ppk"].Value.ToString();
                    //string Guid = heatid + AnaType + AnaItem;

                    //string update_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string update_operator = Adapter.Session.User;
                    sb.Append("Update SPC_AlarmData Set ");
                    sb.Append(" AlarmType='" + alarmtype + "',");
                    sb.Append(" YuanYin='" + yuanyin + "',");
                    sb.Append(" GaiJin='" + gaijin + "',");
                    sb.Append(" AvgX=" + AvgX + ",");
                    sb.Append(" MR=" + MR + ",");
                    sb.Append(" Sd=" + Sd + ",");
                    sb.Append(" Cpk='" + Cpk + "',");
                    sb.Append(" Ppk='" + Ppk + "',");
                    sb.Append(" update_time='" + nowtime + "',");
                    sb.Append(" update_operator='" + update_operator + "',");
                    sb.Append(" Mse=" + Mse);
                    //  sb.Append(" operator=" + update_operator + ",");
                    // sb.Append(" update_time=" + nowtime);
                    sb.Append(" Where Guid='" + gvAlarm.CurrentRow.Cells["ClGuid"].Value.ToString().Trim() + "'");
                    string sql = sb.ToString();
                    string result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }

                    // 存入报表数据库
                    sb.Length = 0;
                    sb.Append("Update xgwebrpt.SPC_AlarmData Set ");
                    sb.Append(" AlarmType='" + alarmtype + "',");
                    sb.Append(" YuanYin='" + yuanyin + "',");
                    sb.Append(" GaiJin='" + gaijin + "',");
                    sb.Append(" AvgX=" + AvgX + ",");
                    sb.Append(" MR=" + MR + ",");
                    sb.Append(" Sd=" + Sd + ",");
                    sb.Append(" Cpk='" + Cpk + "',");
                    sb.Append(" Ppk='" + Ppk + "',");
                    sb.Append(" update_time='" + nowtime + "',");
                    sb.Append(" update_operator='" + update_operator + "',");
                    sb.Append(" Mse=" + Mse);
                    //  sb.Append(" operator=" + update_operator + ",");
                    // sb.Append(" update_time=" + nowtime);
                    sb.Append(" Where Guid='" + gvAlarm.CurrentRow.Cells["ClGuid"].Value.ToString().Trim() + "'");
                    sql = sb.ToString();
                    result = Save(sql);
                    if (result == "0")
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }
                    MessageBox.Show("保存成功");
                }



                //    sql = sb.ToString();
            }
           
        }



        private void 导出到EXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CommDataMag.CommonMethed.PutIntoExcel(qc_des, gvAlarm);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "错误"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan time = (DateTime)dtpEnd.Value -(DateTime)dtpBegin.Value;
            if (time.TotalDays > 190)
            {
                MessageBox.Show("查询日期期间过长，已超过半年");
                return;
            }
            RefreshChartData();
        }

      

   
 


        //private void dbTreatNo_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (dbTreatNo.Text == "")
        //            return;

        //        object Obj = new object();
        //        string strUri = "XGMESLogic\\LFMag\\CLF_Base_Data\\";
        //        string strObjUri = strUri + dbTreatNo.Text;
        //        L3Session.Get(strObjUri, "SteelGrade", ref Obj);
        //        txtSteelGrade.Text = Obj.ToString();
        //        L3Session.Get(strObjUri, "SteelGradeIndex", ref Obj);
        //        txtSteelGradeIndex.Text = Obj.ToString();
        //        L3Session.Get(strObjUri, "HeatID", ref Obj);
        //        txtHeatID.Text = Obj.ToString();
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}


    
     
      
        
   
    }

    
}