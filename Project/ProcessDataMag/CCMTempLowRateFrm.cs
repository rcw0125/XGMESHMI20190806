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
    public partial class CCMTempLowRateFrm : DockContent, IMESForm
    {
        public CCMTempLowRateFrm()
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

        //界面加载
        private void CCMTempLowRateFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsElement.Tables[0].Clear();
                LineFirst.DataSource = null;
               
                tChart1.Refresh();
                if (cmbCCMID.Text == "")
                {
                    MessageBox.Show("请选择铸机！", "提示");
                    return;
                }
                dsElement.SourceMethod = " SELECT 0 heatid, 0 ELEMENT from clf_base_data where 1=2";
                string strID = cmbCCMID.Text.Trim().Substring(2, 1);
                string strSQL = "";

                /********************************* 浇注过程中温降  *************************************************/
                strSQL += "        SELECT   a.heatid,                                                                               ";
                strSQL += "         ROUND (  (c.temp - b.temp)                                                                      ";
                strSQL += "                / ((b.measure_time - c.measuretime) * 24 * 60),                                          ";
                strSQL += "                2                                                                                        ";
                strSQL += "               ) AS ELEMENT                                                                              ";
                strSQL += "    FROM (SELECT   heatid                                                                                ";
                strSQL += "              FROM (SELECT heatid                                                                        ";
                strSQL += "                      FROM cccm_base_data                                                                ";
                strSQL += "                     WHERE TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'           ";
                strSQL += "                       AND SUBSTR (treatno, 1, 1) = '" + strID + "')                                     ";
                strSQL += "          GROUP BY heatid) a,                                                                            ";
                strSQL += "         (SELECT a.heatid, a.temp, a.measure_time                                                        ";
                strSQL += "            FROM cccm_heat_tundishtemp a,                                                                ";
                strSQL += "                 (SELECT   heatid, MAX (measure_time) AS measure_time                                    ";
                strSQL += "                      FROM cccm_heat_tundishtemp                                                         ";
                strSQL += "                     WHERE SUBSTR (ccmid, 3, 1) = '" + strID + "'                                        ";
                strSQL += "                       AND invalidflag <> '1'                                                            ";
                strSQL += "                       AND TO_CHAR (measure_time, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'             ";
                strSQL += "                  GROUP BY heatid) b                                                                     ";
                strSQL += "           WHERE a.heatid = b.heatid AND a.measure_time = b.measure_time) b,                             ";
                strSQL += "         (SELECT a.heatid, a.measuretime, b.temp                                                         ";
                strSQL += "            FROM (SELECT   heatid, MAX (measuretime) AS measuretime                                      ";
                strSQL += "                      FROM (SELECT a.heatid, temperature AS temp,                                        ";
                strSQL += "                                   a.measuretime                                                         ";
                strSQL += "                              FROM clf_temp_data a,                                                      ";
                strSQL += "                                   (SELECT   heatid,                                                     ";
                strSQL += "                                             MAX (measuretime) AS measuretime                            ";
                strSQL += "                                        FROM clf_temp_data                                               ";
                strSQL += "                                       WHERE heatid IS NOT NULL                                          ";
                strSQL += "                                    GROUP BY heatid) b                                                   ";
                strSQL += "                             WHERE a.heatid = b.heatid                                                   ";
                strSQL += "                               AND a.measuretime = b.measuretime                                         ";
                strSQL += "                            UNION ALL                                                                    ";
                strSQL += "                            SELECT a.heatid, temp, a.measuretime                                         ";
                strSQL += "                              FROM crh_temp_data a,                                                      ";
                strSQL += "                                   (SELECT   heatid,                                                     ";
                strSQL += "                                             MAX (measuretime) AS measuretime                            ";
                strSQL += "                                        FROM crh_temp_data                                               ";
                strSQL += "                                       WHERE heatid IS NOT NULL                                          ";
                strSQL += "                                    GROUP BY heatid) b                                                   ";
                strSQL += "                             WHERE a.heatid = b.heatid                                                   ";
                strSQL += "                               AND a.measuretime = b.measuretime)                                        ";
                strSQL += "                  GROUP BY heatid) a,                                                                    ";
                strSQL += "                 (SELECT a.heatid, temperature AS temp, a.measuretime                                    ";
                strSQL += "                    FROM clf_temp_data a,                                                                ";
                strSQL += "                         (SELECT   heatid, MAX (measuretime) AS measuretime                              ";
                strSQL += "                              FROM clf_temp_data                                                         ";
                strSQL += "                             WHERE heatid IS NOT NULL                                                    ";
                strSQL += "                          GROUP BY heatid) b                                                             ";
                strSQL += "                   WHERE a.heatid = b.heatid AND a.measuretime = b.measuretime                           ";
                strSQL += "                  UNION ALL                                                                              ";
                strSQL += "                  SELECT a.heatid, temp, a.measuretime                                                   ";
                strSQL += "                    FROM crh_temp_data a,                                                                ";
                strSQL += "                         (SELECT   heatid, MAX (measuretime) AS measuretime                              ";
                strSQL += "                              FROM crh_temp_data                                                         ";
                strSQL += "                             WHERE heatid IS NOT NULL                                                    ";
                strSQL += "                          GROUP BY heatid) b                                                             ";
                strSQL += "                   WHERE a.heatid = b.heatid AND a.measuretime = b.measuretime) b                        ";
                strSQL += "           WHERE a.heatid = b.heatid AND a.measuretime = b.measuretime) c                                ";
                strSQL += "   WHERE a.heatid = b.heatid AND a.heatid = c.heatid                                                     ";
                strSQL += "ORDER BY a.heatid                                                                                        ";

                dsElement.SourceMethod = strSQL;

                if (dsElement.Tables[0].Rows.Count > 0)
                {
                    tChart1.Axes.Top.Minimum = Convert.ToDouble(dsElement.Tables[0].Rows[0]["heatid"].ToString());
                    tChart1.Axes.Top.Maximum = Convert.ToDouble(dsElement.Tables[0].Rows[dsElement.Tables[0].Rows.Count - 1]["heatid"].ToString());
                    tChart1.Axes.Top.EndPosition = Convert.ToDouble(dsElement.Tables[0].Rows[dsElement.Tables[0].Rows.Count - 1]["heatid"].ToString());
                }
                else
                {
                    tChart1.Axes.Top.Minimum = 0;
                    tChart1.Axes.Top.Maximum = 0;
                    tChart1.Axes.Top.EndPosition = 0;
                }
                LineFirst.DataSource = dsElement;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
            catch
            {
                tChart1.Axes.Top.Minimum = 0;
                tChart1.Axes.Top.Maximum = 0;
                tChart1.Axes.Top.EndPosition = 0;
                LineFirst.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current >= 1)
                {
                    this.tChart1.Page.Current = 1;
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current > 1)
                {
                    this.tChart1.Page.Previous();
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tChart1.Page.Current < this.tChart1.Page.MaxPointsPerPage)
                {
                    this.tChart1.Page.Next();
                    tChart1.Refresh();
                }
            }
            catch { }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                this.tChart1.Page.Current = this.tChart1.Page.Count;
                tChart1.Refresh();
            }
            catch { }
        }
    }
}



 