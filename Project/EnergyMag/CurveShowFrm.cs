using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EnergyMag
{
    public partial class CurveShowFrm : DockContent, IMESForm
    {
        public CurveShowFrm() 
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

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            Show();
        }

        public string strTagName = "";//查看目标名
        public string strFormText = "";//窗体名称
        public string strPressTitle = "空气流量";
        public string strFlowTitle = "煤气流量";

        private double xval = 0;
        //界面加载
        private void CurveShowFrm_Load(object sender, EventArgs e)
        {
            this.TabText += "--[" + strFormText + "]";
            this.Text += "--[" + strFormText + "]";
            dtStart.Value = DateTime.Now;
            linePress.Title = strPressTitle;
            lineFlow.Title = strFlowTitle;

            lbPress.Text = strPressTitle + ":";
            lbFlow.Text = strFlowTitle + ":";
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //标签类型:1-压力;2:流量;3:消耗
            linePress.DataSource = null;
            lineFlow.DataSource = null;

            dsPress.SourceCondition = "1=2";
            dsPress.SourceCondition = "TagName = '" + strTagName + "'and TagType = '1' and to_Char(Catch_Time,'yyyy-MM-dd') = '" + 
                dtStart.Text + "' order by Catch_Time";
           
            dsFlow.SourceCondition = "1=2";
            dsFlow.SourceCondition = " TagName = '" + strTagName + "'and TagType = '2' and to_Char(Catch_Time,'yyyy-MM-dd') = '" + 
                dtStart.Text + "' order by Catch_Time";
           
            linePress.DataSource = dsPress;
            lineFlow.DataSource = dsFlow;

            tChart1.Refresh();
        }

        //拖动
        private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            xval = e.XValue;
            txtFlow.Text = "";
            txtPress.Text = "";

            txtTime.Text = DateTime.FromOADate(xval).ToString("yyyy-MM-dd HH:mm:ss");
            for (int i = 0; i < tChart1.Series.Count; i++)
            {
                if (tChart1.Series[i] is Steema.TeeChart.Styles.Custom)
                {
                    if (tChart1.Series[i].Visible == true)
                    {
                        if (tChart1.Series[i].Title == strFlowTitle)
                        {
                            txtFlow.Text = InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom, e.XValue).ToString("0.00") + "";
                        }
                        else if (tChart1.Series[i].Title == strPressTitle)
                        {
                            txtPress.Text = InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom, e.XValue).ToString("0.00") + "";
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

        }

        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
            int xs = tChart1.Axes.Bottom.CalcXPosValue(xval);
            int ys;
            g.Brush.Visible = true;
            g.Brush.Solid = true;
            for (int i = 0; i < tChart1.Series.Count; i++)
                if (tChart1.Series[i] is Steema.TeeChart.Styles.Custom)
                {
                    if (tChart1.Series[i].Visible == true)
                    {
                        ys = tChart1.Series[i].GetVertAxis.CalcYPosValue(InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom, xval));
                        g.Brush.Color = tChart1.Series[i].Color;
                        g.Ellipse(new Rectangle(xs - 4, ys - 4, 8, 8));
                    }
                }
        }

        private double InterpolateLineSeries(Steema.TeeChart.Styles.Custom series, double xvalue)
        {
            return InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue);
        }

        private double InterpolateLineSeries(Steema.TeeChart.Styles.Custom series, int firstindex, int lastindex, double xvalue)
        {
            int index;
            for (index = firstindex; index <= lastindex; index++)
            {
                if (index == -1 || series.XValues.Value[index] > xvalue) break;
            }
            // safeguard
            if (index < 1)
            { index = 1; return 0; }
            else if (index >= series.Count)
                index = series.Count - 1;
            // y=(y2-y1)/(x2-x1)*(x-x1)+y1
            double dx = series.XValues[index] - series.XValues[index - 1];
            double dy = series.YValues[index] - series.YValues[index - 1];
            if (dx != 0.0) return dy * (xvalue - series.XValues[index - 1]) / dx + series.YValues[index - 1];
            else return 0.0;
        }

    }
}