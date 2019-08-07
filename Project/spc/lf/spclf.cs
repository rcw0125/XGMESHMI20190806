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

namespace spc
{
    public partial class spclf : DockContent, IMESForm
    {
        public spclf()
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
        public string treatno = "";

        private SpcChartData test = new SpcChartData();




        private void Form1_Load(object sender, EventArgs e)
        {

     

            TabText = qc_des;
          


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
            dbxHeatID.DataProperty = "TreatNo";
            dbxHeatID.DataObject = DataObject;

            gvAlarm.ContextMenuStrip = menuMain;

           // LoadBofData(unit, qcitem, steelgradeindex);
           // LoadBofData();

           // init();
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

                

            }
            else 
            {
                string qcitem_max = GetSteelGradeIndexQcStd(steelgradeindex, qcitemname + "_Max");
                string qcitem_min = GetSteelGradeIndexQcStd(steelgradeindex, qcitemname + "_Min");
                if (qcitem_max != "")
                    test.USL = Convert.ToDouble(qcitem_max);
                if (qcitem_min != "")
                    test.LSL = Convert.ToDouble(qcitem_min);
            
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
                if (maintype=="lizhan")
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_Product_Sheet\\";
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
            if (maintype == "lizhan")
            {
                sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,ap.team,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.logtime DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and ap.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
               // sqlSb.Append(" and (lb.sample_type='GG' or lb.sample_type='GP')");
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "GL", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by REPORT_DATE");
            }
            else if (maintype == "zhayang")
            {
                sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'ZF' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,ap.team,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.logtime DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_slagele lb ");
                sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and ap.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                sqlSb.Append(" and  lb.sample_type='ZF' ");
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "ZF", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by REPORT_DATE");
            }
            else if (maintype =="process")
            {
                if ((qcitemcode == "SOFTBLOW_TIME")&&(steelgrade.Contains("XGLX")))
                {
                    sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.ARRIVAL_TIME AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                    sqlSb.Append("select lb.heatid,ap.team,lb.ARRIVAL_TIME,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.treatno DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.treatno DESC) as ARN from clf_process_data lb ");
                    sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                    // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                    sqlSb.Append(string.Format("  where lb.{0} >1800 ", qcitemcode));
                    sqlSb.Append(string.Format("  and lb.{0} <4200 ", qcitemcode));
                    sqlSb.Append(string.Format(" and lb.treatno<='{0}' ", treatno));
                    sqlSb.Append(string.Format(" and lb.treatno like '{0}' ", unit_like));
                    sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                    sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(" where RN=1 and ARN<100");
                    sqlSb.Append(" order by REPORT_DATE");
                }
                else
                {

                    sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'L_P' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.ARRIVAL_TIME AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                    sqlSb.Append("select lb.heatid,ap.team,lb.ARRIVAL_TIME,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.treatno DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.treatno DESC) as ARN from clf_process_data lb ");
                    sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                    // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                    sqlSb.Append(string.Format("  where lb.{0} >480 ", qcitemcode));
                    sqlSb.Append(string.Format("  and lb.{0} <2400 ", qcitemcode));
                    sqlSb.Append(string.Format(" and lb.treatno<='{0}' ", treatno));
                    sqlSb.Append(string.Format(" and lb.treatno like '{0}' ", unit_like));
                    sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                    sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                    sqlSb.Append(string.Format(" and t2.AnaType='L_P' and t2.AnaItem='{0}'", qcitemcode));
                    sqlSb.Append(" where RN=1 and ARN<100");
                    sqlSb.Append(" order by REPORT_DATE");
                }
               

            } 
            else if (maintype == "rh")
            {
                sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'RH' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,ap.team,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join crh_base_data ap on ap.heatid=lb.heatid");
                sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and ap.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                //sqlSb.Append(" and lb.sample_type='GG'");
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "RH", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by REPORT_DATE");
            }
            else if (maintype == "weight")
            {
                sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.ARRIVAL_TIME AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,ap.team,lb.ARRIVAL_TIME,lb." + qcitemcode + ",ROW_NUMBER()OVER(ORDER BY lb.treatno DESC) as ARN from cccm_heat_ladle lb ");
                sqlSb.Append(" inner join cccm_base_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                sqlSb.Append(string.Format("  where lb.{0} >5 ", qcitemcode));
                sqlSb.Append(string.Format(" and lb.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and lb.treatno like '{0}' ", unit_like));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='CCM' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(" where  ARN<100");
                sqlSb.Append(" order by REPORT_DATE");

            }
            else if (maintype == "tundishtemp")
            {
                sqlSb.Append("select t1.heatid as HEATID,t1.team as TEAM,'CCM' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.MEASURE_TIME AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,ap.team,lb.MEASURE_TIME,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.MEASURE_TIME DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.MEASURE_TIME DESC) as ARN from cccm_heat_tundishtemp lb ");
                sqlSb.Append(" inner join (select a.treatno,a.team,a.heatid,a.steelgradeindex,a.productiondate,b.tundish_heatnum from cccm_base_data a,cccm_process_data b where a.heatid=b.heatid and b.tundish_heatnum <>1) ap on ap.heatid=lb.heatid");
               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                sqlSb.Append(string.Format(" where lb.{0}  >0 ", qcitemcode));
                sqlSb.Append(string.Format(" and ap.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and ap.treatno like '{0}' ", unit_like));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                if (unit_like == "51%")
                {

                    sqlSb.Append(string.Format(" and  lb.MEASURE_TIME >=ap.PRODUCTIONDATE+17/ 24 / 60 "));
                    sqlSb.Append(string.Format(" and  lb.MEASURE_TIME <=ap.PRODUCTIONDATE+23/ 24 / 60 "));
                }
                else
                {

                    sqlSb.Append(string.Format(" and  lb.MEASURE_TIME >=ap.PRODUCTIONDATE+12/ 24 / 60 "));
                    sqlSb.Append(string.Format(" and  lb.MEASURE_TIME <=ap.PRODUCTIONDATE+18/ 24 / 60 "));
                }
                sqlSb.Append(string.Format(" and lb.tempid=2  "));
               
                // sqlSb.Append(" and (lb.sample_type='GG' or lb.sample_type='GP')");
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "CCM", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<500");
                sqlSb.Append(" order by REPORT_DATE");

            }
                //C增量
            else if (maintype == "c_add")
            {
                sqlSb.Append("select a.heatid as HEATID,c.team as TEAM,'C_ADD' as ANATYPE,'" + qcitemcode + "' as ANAITEM,A.logtime as REPORT_DATE,a.c_chengpin-b.c_lizhan as VAL,");
                sqlSb.Append(" t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse  from");
                sqlSb.Append("(select c as c_chengpin,logtime,heatid,ROW_NUMBER()OVER(PARTITION BY heatid  ORDER BY SAMPLE_COUNT DESC) as RN from cqa_lab_element ");
                sqlSb.Append("where unittypeid=6) a,( select c as c_lizhan,heatid,ROW_NUMBER()OVER(PARTITION BY heatid ORDER BY SAMPLE_COUNT DESC) as RN2 from  ");
                sqlSb.Append("  cqa_lab_element where unittypeid=4) b ,( select treatno,heatid,team,steelgradeindex,ROW_NUMBER()OVER(PARTITION BY heatid ORDER BY treatno DESC)  ");
                sqlSb.Append("as RN3 from clf_base_data ) c,( select * from spc_alarmdata where AnaType='C_ADD' and AnaItem='C') t2  where a.heatid =b.heatid  and a.rn=1 and b.rn2=1 and a.heatid=c.heatid and a.heatid=t2.heatid(+)  ");
                //sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                //sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and c.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and c.treatno like '{0}' ", unit_like));
                sqlSb.Append(string.Format(" and  c.steelgradeindex='{0}' ", steelgradeindex));
                sqlSb.Append(" and  a.RN=1 and b.RN2=1 and c.RN3=1");
               // sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                //sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "C_ADD", qcitemcode));
                //sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by a.logtime  ");
            }
            else if (maintype == "ladletemp_sub")
            {
                sqlSb.Append("select a.heatid as HEATID,c.team as TEAM,'LADLETEMP' as ANATYPE,'" + qcitemcode + "' as ANAITEM,A.measure_time as REPORT_DATE,b.temp-a.temp as VAL,");
                sqlSb.Append(" t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse  from");
                sqlSb.Append("(select heatid,temp,row_number()over(partition by heatid order by measure_time desc ) as ar,measure_time from cccm_heat_tundishtemp ) a");
                sqlSb.Append("  inner join cccm_heat_ladle b  on a.heatid=b.heatid inner join (select treatno,heatid,team,steelgradeindex, ");
                sqlSb.Append("  row_number()over(partition by heatid order by treatno desc) as ar3 from clf_base_data )  c on a.heatid=c.heatid  ");
                sqlSb.Append("left join spc_alarmdata t2  on b.heatid=t2.heatid and AnaType='LADLETEMP' and AnaItem='TEMP' ");
                sqlSb.Append(" where a.ar=1 and a.temp>1000 and b.temp >1000 and c.ar3=1 ");
                //sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                //sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and c.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and c.treatno like '{0}' ", unit_like));
                sqlSb.Append(string.Format(" and  c.steelgradeindex='{0}' ", steelgradeindex));
               
                // sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                //sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "C_ADD", qcitemcode));
                //sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by a.measure_time  ");
            
            
            
            
            }
            else if (maintype == "wire")
            {
                sqlSb.Append("select a.heatid as HEATID,b.team as TEAM,'wire' as ANATYPE,'" + qcitemcode + "' as ANAITEM,b.productiondate as REPORT_DATE,a.weight as VAL,");
                sqlSb.Append(" t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse  from");
                sqlSb.Append(" (select heatid,sum(weight) as weight,treatno from clf_wire_data where wirecode='12138' group by heatid,treatno,weight) a ");
                sqlSb.Append("  inner join ( select treatno,heatid,team,steelgradeindex,productiondate,row_number()over(partition by heatid order by treatno desc) as ar2  ");
                sqlSb.Append("  from clf_base_data) b on a.treatno =b.treatno inner join cccm_process_data c on a.heatid=c.heatid and casting_heatnum >1   ");
                sqlSb.Append("left join spc_alarmdata t2 on a.heatid=t2.heatid and AnaType='wire' and AnaItem='Ca'");
                sqlSb.Append(" where b.ar2=1 ");
                //sqlSb.Append(" inner join clf_base_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                //sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and b.treatno<='{0}' ", treatno));
                sqlSb.Append(string.Format(" and b.treatno like '{0}' ", unit_like));
                sqlSb.Append(string.Format(" and  b.steelgradeindex='{0}' ", steelgradeindex));

                // sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                //sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "C_ADD", qcitemcode));
                //sqlSb.Append(" where RN=1 and ARN<400");
                sqlSb.Append(" order by b.productiondate  ");




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
            QcStd(steelgradeindex, qcitemcode);
            if (dsLabElement.Tables.Count > 0)
            {
                if (dsLabElement.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsLabElement.Tables[0].Rows)
                    {
                        SpcDataItem spc = new SpcDataItem(test.Data);

                        foreach (DataColumn col in dsLabElement.Tables[0].Columns)
                        {
                            if (col.ColumnName.ToUpper() == "HEATID")
                            {
                                spc.HeatId = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "TEAM")
                            {
                                spc.team = dr.IsNull(col) ? "" : dr[col].ToString();
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
                            else if (col.ColumnName.ToUpper() == "ALARMTYPE")
                            {
                                spc.AlarmType = dr.IsNull(col) ? "" : dr[col].ToString();
                            }
                            else if (col.ColumnName.ToUpper() == "YUANYIN")
                            {
                                spc.YuanYin = dr.IsNull(col) ? "" : dr[col].ToString();
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

                    string strTeam = spcData[i].team;
                    if (strTeam == "1")
                    {
                        strTeam = "甲班";
                    }
                    else if (strTeam == "2")
                    {
                        strTeam = "乙班";
                    }
                    else if (strTeam == "3")
                    {
                        strTeam = "丙班";
                    }
                    else if (strTeam == "4")
                    {
                        strTeam = "丁班";
                    }
                    else
                    {
                        strTeam = "";
                    }

                    gvAlarm.Rows[i].Cells["ClTeam"].Value = strTeam;
                    // gvAlarm.Rows[i].Cells["Clteam"].Value = spcData[i].team;
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
                    gvAlarm.Rows[i].Cells["ClCpk"].Value = spcData[i].Cpk;
                    gvAlarm.Rows[i].Cells["ClPp"].Value = spcData[i].Pp;
                    gvAlarm.Rows[i].Cells["ClPpk"].Value = spcData[i].Ppk;

                    gvAlarm.Rows[i].Cells["ClMse"].Value = spcData[i].Mse;
                    gvAlarm.Rows[i].Cells["ClAnaItem"].Value = spcData[i].AnaItem;
                    gvAlarm.Rows[i].Cells["ClAnaType"].Value = spcData[i].AnaType;

                }
                gvAlarm.AllowUserToAddRows = false;

            }
        }

        private void Save(string sql)
        {




            if (!string.IsNullOrEmpty(sql))
            {
                AppSvrIF.Command cmd = null;

                int result = Adapter.Session.CreateCommand(14, sql, "", ref cmd);
                if (result == 0)
                {
                    Adapter.Session.Execute(cmd);
                }
            }
                
                MessageBox.Show("保存成功");
               // btnSave.Enabled = true;

            
        
        }

        private void txtHeatID_TextChanged(object sender, EventArgs e)
        {

             try
             {
                 if (dbxHeatID.Text == "")
                     return;
                 gvAlarm.Rows.Clear();
                 test.Clear();
                
                 if ((maintype == "tundishtemp") ||(maintype == "weight"))
                 {

                     object Obj = new object();
                     string strUri = "XGMESLogic\\CCMMag\\CCCM_Base_Data\\";
                     string strObjUri = strUri + dbxHeatID.Text;
                     this.Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                     steelgrade = Obj.ToString();
                     this.Adapter.Session.Get(strObjUri, "SteelGradeIndex", ref Obj);
                     steelgradeindex = Obj.ToString();

                 }
                 else if(maintype == "rh")
                 {
                     object Obj = new object();
                     string strUri = "XGMESLogic\\RHMag\\CRH_Base_Data\\";
                     string strObjUri = strUri + dbxHeatID.Text;
                     this.Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                     steelgrade = Obj.ToString();
                     this.Adapter.Session.Get(strObjUri, "SteelGradeIndex", ref Obj);
                     steelgradeindex = Obj.ToString();
                 }
                 else
                 {
                     object Obj = new object();
                     string strUri = "XGMESLogic\\LFMag\\CLF_Base_Data\\";
                     string strObjUri = strUri + dbxHeatID.Text;
                     this.Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                     steelgrade = Obj.ToString();
                     this.Adapter.Session.Get(strObjUri, "SteelGradeIndex", ref Obj);
                     steelgradeindex = Obj.ToString();
                 }
                
                 //this.Adapter.Session.Get(strObjUri, "HeatID", ref Obj);
                 //heatid = Obj.ToString();
                 treatno = dbxHeatID.Text.Trim();
                 RefreshChartData();
             }
             catch
             {
                 return;
             }
           
        }

   
  

        private void gvAlarm_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                if (gvAlarm.Rows[e.RowIndex].Cells["Clalarmtype"].Value.ToString() != "")
                {

                    gvAlarm.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Red;

                }
                else
                {
                    if (e.RowIndex > 0)
                    {
                        gvAlarm.Rows[e.RowIndex].Visible = false;
                    }
                }
            }
            catch
            {
                return;
            }
            
        }

        private void gvAlarm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            string alarmtype = gvAlarm.Rows[e.RowIndex].Cells["Clalarmtype"].Value.ToString();
            if (alarmtype == "")
            {
                MessageBox.Show("该炉次没有报警，请选择有报警类型的炉次");
                return;
            }
            string heatid = gvAlarm.Rows[e.RowIndex].Cells["ClHeatID"].Value.ToString();
            string yuanyin = gvAlarm.Rows[e.RowIndex].Cells["ClYuanYin"].Value.ToString();
            string gaijin = gvAlarm.Rows[e.RowIndex].Cells["ClGaiJin"].Value.ToString();
            string _yuanyin = yuanyin, _gaijin = gaijin;
            Remark re = new Remark();
            //re.remark(heatid, alarmtype, ref yuanyin,ref  gaijin,maintype,this.Adapter.Session);
            re.remark(heatid, alarmtype, ref yuanyin, ref  gaijin, maintype + qcitemcode, this.Adapter.Session);
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

                    string Cpk = gvAlarm.Rows[e.RowIndex].Cells["ClCpk"].Value.ToString();
                    string Ppk = gvAlarm.Rows[e.RowIndex].Cells["ClPpk"].Value.ToString();
                    string Guid = heatid + AnaType + AnaItem;
                    string lfunit = qc_des.Substring(0, 4);
                    
                  //  string insert_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string insert_operator = Adapter.Session.User;

                    sb.Append("INSERT INTO SPC_AlarmData(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,AvgX,MR,Sd,Cpk,Ppk,unit,MSE) Values(");
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
                    sb.Append("'" + lfunit + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    string sql = sb.ToString();
                    Save(sql);
                    gvAlarm.Rows[e.RowIndex].Cells["ClGuid"].Value = Guid;


                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    DateTime nowtime = DateTime.Now;
                   
                    double AvgX = (double)gvAlarm.Rows[e.RowIndex].Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.Rows[e.RowIndex].Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.Rows[e.RowIndex].Cells["ClMse"].Value;
                    string Cpk = gvAlarm.Rows[e.RowIndex].Cells["ClCpk"].Value.ToString();
                    string Ppk = gvAlarm.Rows[e.RowIndex].Cells["ClPpk"].Value.ToString();
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
                    sb.Append(" Where Guid='" + gvAlarm.Rows[e.RowIndex].Cells["ClGuid"].Value.ToString().Trim() + "'");
                    string  sql = sb.ToString();
                    Save(sql);
                
                }
                
                
               
                //    sql = sb.ToString();
            }
            
        }



        //刷新按钮
        private void 记录报警ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///刷新
            ///
            dbxHeatID.Text = "";
            object Obj = new object();
            string strUri = DataObject;
            this.Adapter.Session.Get(strUri, "TreatNo", ref Obj);
            dbxHeatID.Text = Obj.ToString();
        }

        private void 记录原因ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string alarmtype = gvAlarm.CurrentRow.Cells["Clalarmtype"].Value.ToString();
            if (alarmtype == "")
            {
                MessageBox.Show("该炉次没有报警，请选择有报警类型的炉次");
                return;
            }
            string heatid = gvAlarm.CurrentRow.Cells["ClHeatID"].Value.ToString();
            string yuanyin = gvAlarm.CurrentRow.Cells["ClYuanYin"].Value.ToString();
            string gaijin = gvAlarm.CurrentRow.Cells["ClGaiJin"].Value.ToString();
            string _yuanyin = yuanyin, _gaijin = gaijin;
            Remark re = new Remark();
            //re.remark(heatid, alarmtype, ref yuanyin, ref  gaijin);
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
                    string Cpk = gvAlarm.CurrentRow.Cells["ClCpk"].Value.ToString();
                    string Ppk = gvAlarm.CurrentRow.Cells["ClPpk"].Value.ToString();
                    string Guid = heatid + AnaType + AnaItem;
                    string lfunit = qc_des.Substring(0, 4);

                    //  string insert_operator = Adapter.GetUserDescription(Adapter.Session.User);
                    string insert_operator = Adapter.Session.User;

                    sb.Append("INSERT INTO SPC_AlarmData(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,AvgX,MR,Sd,Cpk,Ppk,unit,MSE) Values(");
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
                    sb.Append("'"+Cpk + "',");
                    sb.Append("'"+Ppk + "',");
                    sb.Append("'" + lfunit + "',");
                    sb.Append(Mse);
                    sb.Append(")");
                    string sql = sb.ToString();
                    Save(sql);
                    gvAlarm.CurrentRow.Cells["ClGuid"].Value = Guid;


                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    DateTime nowtime = DateTime.Now;

                    double AvgX = (double)gvAlarm.CurrentRow.Cells["ClAvgX"].Value;
                    double MR = (double)gvAlarm.CurrentRow.Cells["ClMR"].Value;
                    double Sd = (double)gvAlarm.CurrentRow.Cells["ClSd"].Value;
                    double Mse = (double)gvAlarm.CurrentRow.Cells["ClMse"].Value;
                    string Cpk = gvAlarm.CurrentRow.Cells["ClCpk"].Value.ToString();
                    string Ppk = gvAlarm.CurrentRow.Cells["ClPpk"].Value.ToString();
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
                    Save(sql);

                }



                //    sql = sb.ToString();
            }
        }

        private void 上一炉次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           

            try
            {
                long heatid = Convert.ToInt64(dbxHeatID.Text.ToString());

                heatid--;
                dbxHeatID.Text = heatid.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "错误"); }
            //MessageBox.Show(heatid.ToString());

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

        private void 下一炉次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gvAlarm.Rows.Clear();
           
            try
            {
                long heatid = Convert.ToInt64(dbxHeatID.Text.ToString());
                heatid++;
                dbxHeatID.Text = heatid.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "错误"); }
            //MessageBox.Show(heatid.ToString());
        }

        private void 跳转到指定炉次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // gvAlarm.Rows.Clear();
            addHeatid ah = new addHeatid();
            string _heatid = treatno;
            ah.add(ref _heatid);
            dbxHeatID.Text = _heatid;
        }

        //private void dbTreatNo_TextChanged(object sender, EventArgs e)
        //{
        //   
        //}


    
     
      
        
   
    }

    
}