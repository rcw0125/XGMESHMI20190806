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
namespace spc
{
    public partial class spcform : DockContent, IMESForm
    {
        public spcform()
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
        public string DataObject = "";

        private SpcChartData test = new SpcChartData();




        private void Form1_Load(object sender, EventArgs e)
        {

            
           
            this.flexShuju.DataSource = test.Data;

            TabText = qc_des;
           
            this.txtUSL.DataSource = test;
            this.txtUSL.DataField = "USL";
            this.txtLSL.DataSource = test;
            this.txtLSL.DataField = "LSL";
            this.txtAvgX.DataSource = test;
            this.txtAvgX.DataField = "AvgX";
            this.txtC.DataSource = test;
            this.txtC.DataField = "Sd";
            this.txtUCLx.DataSource = test;
            this.txtUCLx.DataField = "UCLx";
            this.txtLCLx.DataSource = test;
            this.txtLCLx.DataField = "LCLx";


            this.txtMR.DataSource = test;
            this.txtMR.DataField = "MR";
            this.txtUCLr.DataSource = test;
            this.txtUCLr.DataField = "UCLr";
            this.txtLCLr.DataSource = test;
            this.txtLCLr.DataField = "LCLr";
            this.txtCp.DataSource = test;
            this.txtCp.DataField = "Cp";
            this.txtCpk.DataSource = test;
            this.txtCpk.DataField = "Cpk";
            this.txtPp.DataSource = test;
            this.txtPp.DataField = "Pp";
            this.txtPpk.DataSource = test;
            this.txtPpk.DataField = "Ppk";


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
            dbxHeatID.DataProperty = "HeatID";
            dbxHeatID.DataObject = DataObject;

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
                    ps.SymbolStyle.Color = Color.Yellow;
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
                if (unit == "Z4")
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

                else if(maintype=="chengpin")
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_Product_Sheet\\";
                    if (qcitem == "P_Min")
                    {
                        return "0.0";
                    }
                }
                else if (maintype == "tapping_o")
                {
                    strUri = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Tapping\\";
                    if (qcitem == "Tapping_Oxygen_Min")
                    {
                        return "0.0";
                    }
                    if (qcitem == "Tapping_Oxygen_Max")
                    {
                        qcitem = "End_O2_UpLimit";
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
            return "";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RefreshChartData();
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
            if (maintype == "zhongdian")
            {
                sqlSb.Append("select t1.heatid as HEATID,'GT' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
                sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", unit));
                sqlSb.Append(string.Format("  and lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                // sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GT' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<50");
                sqlSb.Append(" order by REPORT_DATE");
            }
            else if (maintype == "jinzhan")
            {
                sqlSb.Append("select t1.heatid as HEATID,'GG' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT asc) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                sqlSb.Append(string.Format("  where lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
                sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT='01'"));
                sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", unit_like));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GG' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<50");
                sqlSb.Append(" order by REPORT_DATE");
            }
            else if (maintype =="chengpin")
            {
                sqlSb.Append("select t1.heatid as HEATID,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                sqlSb.Append(string.Format("  where lb.{0} is not null ", qcitemcode));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
                //从样3开始跟踪
                sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT >='03'"));
                sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", unit_like));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GL' and t2.AnaItem='{0}'", qcitemcode));
                sqlSb.Append(" where RN=1 and ARN<50");
                sqlSb.Append(" order by REPORT_DATE");
            
            }
            else if (maintype == "tapping")
            {

                sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGL' as ANAITEM,t1.WEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from  ");
                sqlSb.Append("( select heatid,weight,ROW_NUMBER()OVER(ORDER BY heatid DESC) as ARN  ");
                sqlSb.Append(string.Format("from csteel_data where heatid like '{0}'", unit_like));
                sqlSb.Append(string.Format(" and  steelgradeindex='{0}' and weight >0 ", steelgradeindex));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid  ");
                sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGL'"));
                sqlSb.Append(" where  ARN<50");
                sqlSb.Append(" order by heatid ");
            }
            else if (maintype == "tapping_o")
            {

                sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGY' as ANAITEM,t1.CHARGING_START_TIME AS REPORT_DATE,t1.TAPPING_OXYGEN as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,lb.CHARGING_START_TIME,lb.TAPPING_OXYGEN,ROW_NUMBER()OVER(ORDER BY lb.heatid DESC) as ARN from cbof_process_data lb ");
                sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
                // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
                sqlSb.Append(string.Format("  where lb.TAPPING_OXYGEN >0  "));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                // sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
                //从样3开始跟踪
                //sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT >='03'"));
                sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", unit_like));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGY'"));
                sqlSb.Append(" where  ARN<50");
                sqlSb.Append(" order by heatid ");
            }
           
            LoadData(sqlSb);
            QcStd(steelgradeindex, qcitemcode);
            test.Refresh();
        
        }

        private void LoadBofData(string sample_addr, string qcitem, string steelgradeindex)
        {
            test.Clear();

           
        
            StringBuilder sqlSb = new StringBuilder();
       
            sqlSb.Append("select t1.heatid as HEATID,'GT' as ANATYPE,'" + qcitem + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitem + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
                sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitem + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_element lb ");
                sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
                sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", "Z1"));
                sqlSb.Append(string.Format("  and lb.{0} is not null ", "C"));
                sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
                // sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
                sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
                sqlSb.Append(string.Format(" and t2.AnaType='GT' and t2.AnaItem='{0}'", "C"));
                sqlSb.Append(" where RN=1 and ARN<50");
                sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text.Contains("进站"))
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'GG' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT asc) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format("  where lb.{0} is not null ", qcitemcode));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
 //               sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT='01'"));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='GG' and t2.AnaItem='{0}'", qcitemcode));
 //               sqlSb.Append(" where RN=1 and ARN<50");
 //               sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text.Contains("成品"))
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format("  where lb.{0} is not null ", qcitemcode));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
 //               //从样3开始跟踪
 //               sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT >='03'"));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='GL' and t2.AnaItem='{0}'", qcitemcode));
 //               sqlSb.Append(" where RN=1 and ARN<50");
 //               sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text == "出钢氧含量")
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGY' as ANAITEM,t1.CHARGING_START_TIME AS REPORT_DATE,t1.TAPPING_OXYGEN as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.CHARGING_START_TIME,lb.TAPPING_OXYGEN,ROW_NUMBER()OVER(ORDER BY lb.heatid DESC) as ARN from cbof_process_data lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format("  where lb.TAPPING_OXYGEN >0  "));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               // sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
 //               //从样3开始跟踪
 //               //sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT >='03'"));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGY'"));
 //               sqlSb.Append(" where  ARN<50");
 //               sqlSb.Append(" order by heatid ");
 //           }
 //           else if (this.cmbQcItem.Text == "出钢量")
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGL' as ANAITEM,t1.WEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from  ");
 //               sqlSb.Append("( select heatid,weight,ROW_NUMBER()OVER(ORDER BY heatid DESC) as ARN  ");
 //               sqlSb.Append(string.Format("from csteel_data where heatid like '{0}'",strheatid));
 //               sqlSb.Append(string.Format(" and  steelgradeindex='{0}' and weight >0 ", steelgradeindex));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid  ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGL'"));
 //               sqlSb.Append(" where  ARN<50");
 //               sqlSb.Append(" order by heatid ");

            
 ////                select * from  
 ////( select heatid,weight,ROW_NUMBER()OVER(ORDER BY heatid DESC) as ARN
 ////from csteel_data where heatid like '23%') a
 ////where arn<50  order by heatid
 //           }

            LoadData(sqlSb);


          //  QcStd(steelgradeindex, qcitemcode);
            test.Refresh();
            //}
            //this.L3Session.Close();
     }

 //       private void LoadBofData(string sample_addr, string qcitem, string steelgradeindex, DateTime begintime, DateTime endtime)
 //       {
 //           test.Clear();

 //           if (qcitem == "" || steelgradeindex == "") return;

 //           string qcaddresscode = GetGxCode();
 //           string qcitemcode = GetQcItemCode();
 //           string qctypecode = GetQcTypeCode();
 //           string strheatid = "2" + cmbGx.Text.Trim().Substring(0, 1) + "%";

 //           StringBuilder sqlSb = new StringBuilder();
 //           if (this.cmbQcItem.Text.Contains("终点"))
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'GT' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
 //               // sqlSb.Append(string.Format(" and lb.SAMPLE_TYPE ='{0}'", qctypecode));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='GT' and t2.AnaItem='{0}'", qcitemcode));
 //               sqlSb.Append(" where RN=1 ");
 //               // sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','YYYY-MM-DD HH24:MI:SS') and REPORT_DATE<=to_date('{1}','YYYY-MM-DD HH24:MI:SS')", begintime.ToString("yyyy-MM-dd HH:mm:ss"), endtime.ToString("yyyy-MM-dd HH:mm:ss")));

 //               sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

 //               sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text.Contains("进站"))
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'GG' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT asc) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format(" where lb.{0} is not null ", qcitemcode));
 //               sqlSb.Append(string.Format(" and lb.SAMPLE_TYPE ='{0}'", qctypecode));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='GG' and t2.AnaItem='{0}'", qcitemcode));
 //               sqlSb.Append(" where RN=1 ");
 //               // sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','YYYY-MM-DD HH24:MI:SS') and REPORT_DATE<=to_date('{1}','YYYY-MM-DD HH24:MI:SS')", begintime.ToString("yyyy-MM-dd HH:mm:ss"), endtime.ToString("yyyy-MM-dd HH:mm:ss")));

 //               sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

 //               sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text.Contains("成品"))
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT desc) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format(" where lb.{0} is not null ", qcitemcode));
 //               sqlSb.Append(string.Format(" and lb.SAMPLE_TYPE ='{0}'", qctypecode));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='GL' and t2.AnaItem='{0}'", qcitemcode));
 //               sqlSb.Append(" where RN=1 ");
 //               // sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','YYYY-MM-DD HH24:MI:SS') and REPORT_DATE<=to_date('{1}','YYYY-MM-DD HH24:MI:SS')", begintime.ToString("yyyy-MM-dd HH:mm:ss"), endtime.ToString("yyyy-MM-dd HH:mm:ss")));

 //               sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

 //               sqlSb.Append(" order by REPORT_DATE");
 //           }
 //           else if (this.cmbQcItem.Text == "出钢氧含量")
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGY' as ANAITEM,t1.CHARGING_START_TIME AS REPORT_DATE,t1.TAPPING_OXYGEN as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
 //               sqlSb.Append("select lb.heatid,lb.CHARGING_START_TIME,lb.TAPPING_OXYGEN,ROW_NUMBER()OVER(ORDER BY lb.heatid DESC) as ARN from cbof_process_data lb ");
 //               sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
 //               // sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
 //               sqlSb.Append(string.Format("  where lb.TAPPING_OXYGEN >0  "));
 //               sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
 //               // sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));
 //               //从样3开始跟踪
 //               //sqlSb.Append(string.Format(" and lb.SAMPLE_COUNT >='03'"));
 //               sqlSb.Append(string.Format(" and lb.heatid like  '{0}'", strheatid));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGY'"));
 //              // sqlSb.Append(" where  ARN<50");
 //               sqlSb.Append(string.Format(" where REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

 //               sqlSb.Append(" order by heatid ");
 //           }
 //           else if (this.cmbQcItem.Text == "出钢量")
 //           {
 //               sqlSb.Append("select t1.heatid as HEATID,'BOF' as ANATYPE,'CGL' as ANAITEM,t1.WEIGHT as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from  ");
 //               sqlSb.Append("( select heatid,weight,ROW_NUMBER()OVER(ORDER BY heatid DESC) as ARN  ");
 //               sqlSb.Append(string.Format("from csteel_data where heatid like '{0}'", strheatid));
 //               sqlSb.Append(string.Format(" and  steelgradeindex='{0}' and weight >0 ", steelgradeindex));
 //               sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid  ");
 //               sqlSb.Append(string.Format(" and t2.AnaType='BOF' and t2.AnaItem='CGL'"));
 //               sqlSb.Append(" where  ARN<200");
 //               sqlSb.Append(" order by heatid ");


 //               //                select * from  
 //               //( select heatid,weight,ROW_NUMBER()OVER(ORDER BY heatid DESC) as ARN
 //               //from csteel_data where heatid like '23%') a
 //               //where arn<50  order by heatid
 //           }

        //    LoadData(sqlSb);

        //    //  sqlSb.Append(string.Format(" and lb.sample_type='{0}'", qctypecode));

        //  //  QcStd(steelgradeindex, qcitemcode);
        //    test.Refresh();
        //    //}
        //    //this.L3Session.Close();
        //}

        //private void LoadLfData(string sample_addr, string qcitem, string steelgradeindex1)
        //{
        //    test.Clear();
        //    string qcaddresscode = GetGxCode();
        //    string steelgradeindex = steelgradeindex1;
        //    //if (steelgradeindex1 == "")
        //    //    steelgradeindex = lastSteelGradeIndex[qcaddresscode];

        //    if (qcitem == "" || steelgradeindex == "") return;


        //    string qcitemcode = GetQcItemCode();
        //    string qctypecode = GetQcTypeCode();

        //    StringBuilder sqlSb = new StringBuilder();
        //    if (cmbQcItem.Text == "离站C含量")
        //    {

        //        sqlSb.Append("select t1.heatid as HEATID,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
        //        sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
        //        sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
        //        sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
        //        sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
        //        sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
        //        sqlSb.Append(" and (lb.sample_type='GG' or lb.sample_type='GP')");
        //        sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
        //        sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "GL", qcitemcode));
        //        sqlSb.Append(" where RN=1 and ARN<50");
        //        sqlSb.Append(" order by REPORT_DATE");
        //    }
        //    else if (cmbQcItem.Text.Contains("精炼渣"))
        //    {

        //        sqlSb.Append("select t1.heatid as HEATID,'ZF' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
        //        sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.logtime DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
        //        sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
        //        sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
        //        sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
        //        sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
        //        sqlSb.Append(" and  lb.sample_type='ZF' ");
        //        sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
        //        sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "ZF", qcitemcode));
        //        sqlSb.Append(" where RN=1 and ARN<50");
        //        sqlSb.Append(" order by REPORT_DATE");
        //    }


        //    LoadData(sqlSb);


        //   // QcStd(steelgradeindex, qcitemcode);
        //    test.Refresh();
        //    //}
        //    //this.L3Session.Close();
        //}

        //private void LoadLfData(string sample_addr, string qcitem, string steelgradeindex, DateTime begintime, DateTime endtime)
        //{
        //    test.Clear();
        //    if (qcitem == "" || steelgradeindex == "") return;

        //    string qcaddresscode = GetGxCode();
        //    string qcitemcode = GetQcItemCode();
        //    string qctypecode = GetQcTypeCode();

        //    StringBuilder sqlSb = new StringBuilder();
        //    if (cmbQcItem.Text == "离站C含量")
        //    {
        //        sqlSb.Append("select t1.heatid as HEATID,'GL' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
        //        sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.SAMPLE_COUNT DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
        //        sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
        //        sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
        //        sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
        //        sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
        //        sqlSb.Append(" and (lb.sample_type='GG' or lb.sample_type='GP')");
        //        sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
        //        sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "GL", qcitemcode));
        //        sqlSb.Append(" where RN=1 ");
        //        // sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','YYYY-MM-DD HH24:MI:SS') and REPORT_DATE<=to_date('{1}','YYYY-MM-DD HH24:MI:SS')", begintime.ToString("yyyy-MM-dd HH:mm:ss"), endtime.ToString("yyyy-MM-dd HH:mm:ss")));
        //        sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

        //        sqlSb.Append(" order by REPORT_DATE");
        //    }
        //    else if (cmbQcItem.Text.Contains("精炼渣"))
        //    {
        //        sqlSb.Append("select t1.heatid as HEATID,'ZF' as ANATYPE,'" + qcitemcode + "' as ANAITEM,t1.report_date AS REPORT_DATE,t1." + qcitemcode + " as VAL,t2.Guid,t2.AlarmType,t2.YuanYin,t2.Gaijin,t2.AvgX,t2.MR,t2.Sd,t2.Mse from (");
        //        sqlSb.Append("select lb.heatid,lb.report_date,lb." + qcitemcode + ",ROW_NUMBER()OVER(PARTITION BY lb.heatid ORDER BY lb.logtime DESC) as RN,ROW_NUMBER()OVER(ORDER BY lb.logtime DESC) as ARN from cqa_lab_" + QcSample.QA_Class[qcitem] + " lb ");
        //        sqlSb.Append(" inner join csteel_data ap on ap.heatid=lb.heatid");
        //        sqlSb.Append(string.Format(" where  lb.sample_address='{0}' ", qcaddresscode));
        //        sqlSb.Append(string.Format(" and lb.{0} is not null ", qcitemcode));
        //        sqlSb.Append(string.Format(" and  ap.steelgradeindex='{0}' ", steelgradeindex));
        //        sqlSb.Append(" and  lb.sample_type='ZF'");
        //        sqlSb.Append(") t1 left join SPC_AlarmData t2 on t1.heatid=t2.heatid ");
        //        sqlSb.Append(string.Format(" and t2.AnaType='{0}' and t2.AnaItem='{1}'", "ZF", qcitemcode));
        //        sqlSb.Append(" where RN=1 ");
        //        // sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','YYYY-MM-DD HH24:MI:SS') and REPORT_DATE<=to_date('{1}','YYYY-MM-DD HH24:MI:SS')", begintime.ToString("yyyy-MM-dd HH:mm:ss"), endtime.ToString("yyyy-MM-dd HH:mm:ss")));
        //        sqlSb.Append(string.Format(" and REPORT_DATE>=to_date('{0}','yyyy-MM-dd HH24:MI:SS') and REPORT_DATE<=to_date('{1}','yyyy-MM-dd HH24:MI:SS')", dtpBeginTime.Value, dtpEndTime.Value));

        //        sqlSb.Append(" order by REPORT_DATE");
        //    }

        //    LoadData(sqlSb);

        //   // QcStd(steelgradeindex, qcitemcode);
        //    test.Refresh();
        //    //}
        //    //this.L3Session.Close();
        //}
          
        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="sqlSb"></param>
        private void LoadData(StringBuilder sqlSb)
        {
            AppSvrHMI.L3DataSet dsLabElement = new AppSvrHMI.L3DataSet();
            dsLabElement.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            dsLabElement.SourceMethod = sqlSb.ToString();
            dsLabElement.L3DataAdapter = this.Adapter;
            dsLabElement.LoadData();
           // QcStd(txtSteelGradeIndex.Text.Trim(), GetQcItemCode());
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
                            else if (col.ColumnName.ToUpper() == "AVGX")
                            {
                                spc.AvgX = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            }
                            else if (col.ColumnName.ToUpper() == "MR")
                            {
                                spc.MR = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            }
                            else if (col.ColumnName.ToUpper() == "SD")
                            {
                              //  spc.Sd = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            }
                            else if (col.ColumnName.ToUpper() == "MSE")
                            {
                                spc.Mse = dr.IsNull(col) ? null : (double?)Convert.ToDouble(dr[col]);
                            }
                            spc.USL = (double)test.USL;
                            spc.LSL = (double)test.LSL;

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
               label12.Visible = true;
               txtLSL.Visible = true;
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

            this.flexAlarm.DataSource=test.getAllAlarm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flexAlarm.Rows.Count <= 1)
            {
                MessageBox.Show("报警数据为空，不用保存");
            }
            else
            {

                btnSave.Enabled = false;
                foreach (SpcDataItem item in test.getAllAlarm())
                {
                    string sql = item.getSql();
                    if (!string.IsNullOrEmpty(sql))
                    {
                        AppSvrIF.Command cmd = null;

                        int result = Adapter.Session.CreateCommand(14, sql, "", ref cmd);
                        if (result == 0)
                        {
                            Adapter.Session.Execute(cmd);
                        }
                    }
                }
                MessageBox.Show("保存成功");
                btnSave.Enabled = true;

            }
        
        }

        private void txtHeatID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dbxHeatID.Text == "")
                    return;

              
                    object Obj = new object();
                    string strUri = "XGMESLogic\\BOFMag\\CBOF_Base_Data\\";
                    string strObjUri = strUri + dbxHeatID.Text;
               
                    //this.Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                    //txtSteelGrade.Text = Obj.ToString();
                    this.Adapter.Session.Get(strObjUri, "SteelGradeIndex", ref Obj);
                    steelgradeindex = Obj.ToString();
                    tbSteelGradeIndex.Text = steelgradeindex;
             

              

                    RefreshChartData();
               

            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                this.flexShuju.SaveExcel(this.saveFileDialog1.FileName+".xls", C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);
                MessageBox.Show("导出Excel成功");
            
            }
            
            
            //   if (test.Data.Count != 0)
          //  {
          //      this.flexShuju.SaveGrid(@"C:\Users\Administrator\Desktop\test.xls", C1.Win.C1FlexGrid.FileFormatEnum.Excel, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells, Encoding.Default);
          //      MessageBox.Show("保存完成");
          //  }
          //  else MessageBox.Show("表中没数据");
        }

        private void flexAlarm_Click(object sender, EventArgs e)
        {

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