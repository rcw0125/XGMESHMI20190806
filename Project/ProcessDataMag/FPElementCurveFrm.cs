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
    public partial class FPElementCurveFrm : DockContent, IMESForm
    {
        public FPElementCurveFrm()
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
        private void FPElementCurveFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;

            string strSql = "";
            strSql = "    SELECT   steelgrade                   ";
            strSql += "     FROM cqa_steelgradeindex_r          ";
            strSql += "    WHERE steelgradeindex IS NOT NULL and  steelgradeindex <> 'YY000000'  ";
            strSql += " GROUP BY steelgrade                     ";
            dsSteelGrade.SourceMethod = strSql;

            cmbSteelGrade.Items.Clear();
            for (int i = 0; i < dsSteelGrade.Tables[0].Rows.Count; i++)
                cmbSteelGrade.Items.Add(dsSteelGrade.Tables[0].Rows[i][0].ToString());
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsElement.Tables[0].Clear();

                LineFirst.DataSource = null;
                LineProc.DataSource = null;
                LineStdMax.DataSource = null;
                LineStdMin.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;

                if (cmbBOFID.Text == "")
                {
                    MessageBox.Show("请选择炉座！", "提示");
                    return;
                }
                if (cmbElement.Text == "")
                {
                    MessageBox.Show("请选择成分！", "提示");
                    return;
                }
                string strSteelGradeCon = "";
                if (cmbSteelGrade.Text != "")
                {
                    strSteelGradeCon = " AND a.SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";
                }
                dsElement.SourceMethod = "SELECT * from cbof_base_data where 1=2";
                string strElement = cmbElement.Text;
                string strSQL = "";
                /********************************* 进 站、成 品 成 分  *************************************************/
                strSQL += " SELECT   a.heatid AS heatid, a.steelgradeindex AS steelgradeindex,           ";
                strSQL += "                a.steelgrade AS steelgrade, b." + strElement + " AS element_in,     ";
                strSQL += "                c." + strElement + " AS element_pro                                 ";
                strSQL += "           FROM cbof_base_data a,                                                   ";
                strSQL += "                (SELECT d.heatid, d." + strElement + "                              ";
                strSQL += "                   FROM cqa_lab_element d,                                          ";
                strSQL += "                        (SELECT   heatid, MIN (report_date) AS report_date          ";
                strSQL += "                             FROM cqa_lab_element                                   ";
                strSQL += "                            WHERE unittypeid = '4'                                  ";
                strSQL += "                         GROUP BY heatid) e                                         ";
                strSQL += "                  WHERE d.heatid = e.heatid AND d.report_date = e.report_date) b,   ";
                strSQL += "                (SELECT f.heatid, f." + strElement + "                              ";
                strSQL += "                   FROM cqa_lab_element f,                                          ";
                strSQL += "                        (SELECT   heatid, MAX (report_date) AS report_date          ";
                strSQL += "                             FROM cqa_lab_element                                   ";
                strSQL += "                            WHERE finaljudgeflag = '1'                              ";
                strSQL += "                         GROUP BY heatid) g                                         ";
                strSQL += "                  WHERE f.heatid = g.heatid AND f.report_date = g.report_date) c    ";
                strSQL += "          WHERE SUBSTR (a.heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'                                       ";
                strSQL += "            AND TO_CHAR (a.productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'                   ";
                strSQL += "            AND SUBSTR (a.steelgradeindex, 1, 1) <> 'F'                             ";
                strSQL += "            AND a.heatid = b.heatid (+)                                                ";
                strSQL += "            AND a.heatid = c.heatid (+)                                                ";
                strSQL += strSteelGradeCon;
                strSQL += "       ORDER BY a.heatid                                                          ";
                /********************************* 进 站、成 品 成 分   *************************************************/
                dsElement.SourceMethod = strSQL;

                strSQL += "  SELECT   a.heatid, (c.c - b.c) * 100 AS ELEMENT, 8 AS ele_std                            ";
                strSQL += "    FROM (SELECT   a.heatid, a.steelgrade                                                  ";
                strSQL += "              FROM cbof_base_data a,                                                       ";
                strSQL += "                   (SELECT   d.steelgrade                                                  ";
                strSQL += "                        FROM cqa_product_sheet c, cqa_steelgradeindex_r d                  ";
                strSQL += "                       WHERE c.steelgradeindex = d.steelgradeindex                         ";
                strSQL += "                         AND TO_NUMBER (c.c_min) > 0.6                                     ";
                strSQL += "                    GROUP BY d.steelgrade) b                                               ";
                strSQL += "             WHERE TO_CHAR (a.productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'   ";
                strSQL += "               AND a.steelgrade = b.steelgrade                                             ";

                strSQL += strSteelGradeCon;   

                strSQL += "          ORDER BY a.heatid) a,                                                            ";
                strSQL += "         (SELECT d.heatid, d.c                                                             ";
                strSQL += "            FROM cqa_lab_element d,                                                        ";
                strSQL += "                 (SELECT   heatid, MIN (report_date) AS report_date                        ";
                strSQL += "                      FROM cqa_lab_element                                                 ";
                strSQL += "                     WHERE unittypeid = '4' AND sample_count = '01'                        ";
                strSQL += "                  GROUP BY heatid) e                                                       ";
                strSQL += "           WHERE d.heatid = e.heatid AND d.report_date = e.report_date) b,                 ";
                strSQL += "         (SELECT f.heatid, f.c                                                             ";
                strSQL += "            FROM cqa_lab_element f,                                                        ";
                strSQL += "                 (SELECT   heatid, MAX (report_date) AS report_date                        ";
                strSQL += "                      FROM cqa_lab_element                                                 ";
                strSQL += "                     WHERE finaljudgeflag = '1'                                            ";
                strSQL += "                  GROUP BY heatid) g                                                       ";
                strSQL += "           WHERE f.heatid = g.heatid AND f.report_date = g.report_date) c                  ";
                strSQL += "   WHERE a.heatid = b.heatid AND a.heatid = c.heatid                                       ";
                strSQL += "ORDER BY heatid                                                                            ";
                //                                                       

                ///********************************* 国 标 成 分 标 准  *************************************************/
                //dsElementStd.SourceMethod = "SELECT * from cbof_base_data where 1=2";
                //strSQL = "";
                //strSQL += "   SELECT   a.heatid AS heatid, b." + strElement + "_max as Ele_Max, b." + strElement + "_min   as Ele_Min          ";
                //strSQL += "     FROM cbof_base_data a, cqa_product_sheet b              ";
                //strSQL += "    WHERE SUBSTR (a.heatid, 2, 1) =  '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'                      ";
                //strSQL += "      AND TO_CHAR (a.productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'  ";
                //strSQL += "      AND SUBSTR (a.steelgradeindex, 1, 1) <> 'F'            ";
                //strSQL += "      AND a.steelgradeindex = b.steelgradeindex              ";
                //strSQL += strSteelGradeCon;
                //strSQL += " ORDER BY heatid                                             ";
                ///********************************* 国 标 成 分 标 准  *************************************************/
                /********************************* 内 控 标 成 分 标 准  *************************************************/
                dsElementStd.SourceMethod = "SELECT * from cbof_base_data where 1=2";
                strSQL = "";
                strSQL += "   SELECT   a.heatid AS heatid, b." + strElement + "_max as Ele_Max, b." + strElement + "_min   as Ele_Min          ";
                strSQL += "     FROM cbof_base_data a, CQA_BOF_Std_InCtr_Ele b              ";
                strSQL += "    WHERE SUBSTR (a.heatid, 2, 1) =  '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'                      ";
                strSQL += "      AND TO_CHAR (a.productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'  ";
                strSQL += "      AND SUBSTR (a.steelgradeindex, 1, 1) <> 'F'            ";
                strSQL += "      AND a.steelgradeindex = b.steelgradeindex              ";
                strSQL += strSteelGradeCon;
                strSQL += " ORDER BY heatid                                             ";
                /********************************* 内 控 成 分 标 准  *************************************************/
                dsElementStd.SourceMethod = strSQL;
                if (dsElementStd.Tables[0].Rows.Count > 0)
                {
                    tChart1.Axes.Top.Minimum = Convert.ToDouble(dsElementStd.Tables[0].Rows[0]["heatid"].ToString());
                    tChart1.Axes.Top.Maximum = Convert.ToDouble(dsElementStd.Tables[0].Rows[dsElementStd.Tables[0].Rows.Count - 1]["heatid"].ToString());
                    tChart1.Axes.Top.EndPosition = Convert.ToDouble(dsElementStd.Tables[0].Rows[dsElementStd.Tables[0].Rows.Count - 1]["heatid"].ToString());
                }
                else
                {
                    tChart1.Axes.Top.Minimum = 0;
                    tChart1.Axes.Top.Maximum = 0;
                    tChart1.Axes.Top.EndPosition = 0;
                }
                LineFirst.DataSource = dsElement;
                LineProc.DataSource = dsElement;
                LineStdMax.DataSource = dsElementStd;
                LineStdMin.DataSource = dsElementStd;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
            catch
            {
                tChart1.Axes.Top.Minimum = 0;
                tChart1.Axes.Top.Maximum = 0;
                tChart1.Axes.Top.EndPosition = 0;
                LineFirst.DataSource = dsElement;
                LineProc.DataSource = dsElement;
                LineStdMax.DataSource = dsElement;
                LineStdMin.DataSource = dsElement;

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
                if (this.tChart1.Page.Current < this.tChart1.Page.Count)
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



 