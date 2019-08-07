using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace ProcessDataMag
{
    public partial class CoolWaterFlowFrm : DockContent, IMESForm
    {
        public CoolWaterFlowFrm() 
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

        private double xval = 0;
        //界面加载
        private void CoolWaterFlowFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                //标签类型:1-压力;2:流量;3:消耗
                lineFlow.DataSource = null;

                if (cmbCCMID.Text == "")
                {
                    MessageBox.Show("请选择铸机！", "提示");
                    return;
                }
                string strCCMTableName = "";
                string strCCMID = cmbCCMID.Text.Trim().Substring(2, 1);
                if (strCCMID == "5")
                    strCCMTableName = "CCCM5_Runtime1_Data";
                else
                    strCCMTableName = "CCCM_Runtime_Data";

                string strSQL = "";
                /**********************************************************************************/
                strSQL += "  SELECT   a.heatid, b.ELEMENT, b.logtime,                                              ";
                strSQL += "         TO_NUMBER (c.sec_cold_base) AS ele_aim                                         ";
                strSQL += "    FROM (SELECT heatid, steelgradeindex                                                ";
                strSQL += "            FROM cccm_base_data                                                         ";
                strSQL += "           WHERE TO_CHAR (productiondate, 'yyyy-MM-dd') = '" + dtStart.Text.Trim() + "' ";
                strSQL += "             AND SUBSTR (treatno, 1, 1) = '" + strCCMID + "') a,                        ";
                strSQL += "         (SELECT   heatid, ROUND (flow_cooling, 2) AS ELEMENT, logtime                  ";
                strSQL += "              FROM " + strCCMTableName + "                                              ";
                strSQL += "             WHERE TO_CHAR (logtime, 'yyyy-MM-dd') = '" + dtStart.Text.Trim() + "'      ";
                strSQL += "               AND SUBSTR (treatno, 1, 1) = '" + strCCMID + "'                          ";
                strSQL += "               AND heatid IS NOT NULL                                                   ";
                strSQL += "          ORDER BY logtime) b,                                                          ";
                strSQL += "         cqa_caster_std_proc c                                                          ";

                dsFlow.SourceMethod = strSQL + "WHERE 1 = 2 ";

                strSQL += "   WHERE a.heatid = b.heatid AND a.steelgradeindex = c.steelgradeindex                  ";
                strSQL += "ORDER BY b.logtime                                                                      ";

                dsFlow.SourceMethod = strSQL;
                lineFlow.DataSource = dsFlow;

                tChart1.Refresh();
            }
            catch { }
        }

        //拖动
        private void cursorTool1_Change(object sender, Steema.TeeChart.Tools.CursorChangeEventArgs e)
        {
            xval = e.XValue;
            txtFlow.Text = "";

            txtTime.Text = DateTime.FromOADate(xval).ToString("yyyy-MM-dd HH:mm:ss");
            for (int i = 0; i < tChart1.Series.Count; i++)
            {
                if (tChart1.Series[i] is Steema.TeeChart.Styles.Custom)
                {
                    if (tChart1.Series[i].Visible == true)
                    {
                        if (tChart1.Series[i].Title == "二冷水流量")
                        {
                            txtFlow.Text = InterpolateLineSeries(tChart1.Series[i] as Steema.TeeChart.Styles.Custom, e.XValue).ToString("0.00") + "";
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