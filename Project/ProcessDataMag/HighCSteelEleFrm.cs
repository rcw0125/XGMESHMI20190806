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
    public partial class HighCSteelEleFrm : DockContent, IMESForm
    {
        public HighCSteelEleFrm()
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
        private void HighCSteelEleFrm_Load(object sender, EventArgs e)
        {
            string strSql = "";

            strSql += "SELECT b.steelgrade                                                          ";
            strSql += "  FROM cqa_product_sheet a, cqa_steelgradeindex_r b                          ";
            strSql += " WHERE a.steelgradeindex = b.steelgradeindex AND TO_NUMBER (a.c_min) > 0.6   ";
            strSql += " group by b.steelgrade                                                       ";
           
            dsSteelGrade.SourceMethod = strSql;

            cmbSteelGrade.Items.Clear();
            for (int i = 0; i < dsSteelGrade.Tables[0].Rows.Count; i++)
                cmbSteelGrade.Items.Add(dsSteelGrade.Tables[0].Rows[i][0].ToString());
            dtStart.Value = DateTime.Now;
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsElement.Tables[0].Clear();

                LineFirst.DataSource = null;
                LineStdMax.DataSource = null;
                LineStdMin.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;

                if (cmbBOFID.Text == "")
                {
                    MessageBox.Show("请选择炉座！", "提示");
                    return;
                }
                string strSteelGradeCon = "";
                if (cmbSteelGrade.Text != "")
                {
                    strSteelGradeCon = " AND a.SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";
                }
                dsElement.SourceMethod = "SELECT Heatid,0 AS ELEMENT,8 AS ele_Max,0 as ele_Min from cbof_base_data where 1 = 2";
                string strSQL = "";
                /**********************************************************************************/
                strSQL += "  SELECT   a.heatid, (c.c - b.c) * 100 AS ELEMENT, 8 AS ele_Max,0 as ele_Min               ";
                strSQL += "    FROM (SELECT   a.heatid, a.steelgrade                                                  ";
                strSQL += "              FROM cbof_base_data a,                                                       ";
                strSQL += "                   (SELECT   d.steelgrade                                                  ";
                strSQL += "                        FROM cqa_product_sheet c, cqa_steelgradeindex_r d                  ";
                strSQL += "                       WHERE c.steelgradeindex = d.steelgradeindex                         ";
                strSQL += "                         AND TO_NUMBER (c.c_min) > 0.6                                     ";
                strSQL += "                    GROUP BY d.steelgrade) b                                               ";
                strSQL += "             WHERE TO_CHAR (a.productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'   ";
                strSQL += "               AND a.steelgrade = b.steelgrade                                             ";
                strSQL += "               AND substr(a.Heatid,2,1)  = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'  ";

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

                dsElement.SourceMethod = strSQL;

                if (dsElement.Tables[0].Rows.Count > 0)
                {
                    tChart1.Axes.Top.Minimum = Convert.ToDouble(dsElement.Tables[0].Rows[0]["heatid"].ToString());//第一炉 号
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
                LineStdMax.DataSource = dsElement;
                LineStdMin.DataSource = dsElement;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
            catch
            {
                tChart1.Axes.Top.Minimum = 0;
                tChart1.Axes.Top.Maximum = 0;
                tChart1.Axes.Top.EndPosition = 0;
                LineFirst.DataSource = null;
                LineStdMax.DataSource = null;
                LineStdMin.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
        }

        private void SetMaxMin(string max,string min)
        {
            //try
            //{
            //    if (dsElement.Tables[0].Rows.Count > 0)
            //    {
            //        tChart1.Axes.Top.Minimum =Convert.ToDouble(min);
            //        tChart1.Axes.Top.Maximum =Convert.ToDouble(max);
            //        tChart1.Axes.Top.EndPosition =Convert.ToDouble(max);
            //    }
            //    else
            //    {
            //        tChart1.Axes.Top.Minimum = 0;
            //        tChart1.Axes.Top.Maximum = 0;
            //        tChart1.Axes.Top.EndPosition = 0;
            //    }
            //    LineFirst.DataSource = dsElement;
            //    LineStdMax.DataSource = dsElement;
            //    LineStdMin.DataSource = dsElement;

            //    tChart1.Refresh();
            //    tChart1.Page.Current = 1;
            //}
            //catch 
            //{
            //    tChart1.Axes.Top.Minimum = 0;
            //    tChart1.Axes.Top.Maximum = 0;
            //    tChart1.Axes.Top.EndPosition = 0;
            //    LineFirst.DataSource = null;
            //    LineStdMax.DataSource = null;
            //    LineStdMin.DataSource = null;

            //    tChart1.Refresh();
            //    tChart1.Page.Current = 1;
            //}
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

        /********Modify By Huyunhai 20110411*******/
        private void txtMin_Leave(object sender, EventArgs e)
        {
            if(txtMin.Text.Trim()=="")
            {
                MessageBox.Show("没设置下限!");
                return;
            }
            if (txtMax.Text.Trim()=="")
            {
                MessageBox.Show("没设置上限");
                return;
            }
           // SetMaxMin(txtMax.Text, txtMin.Text);Ele_Max
            for (int i=0;i<dsElement.Tables[0].Rows.Count;i++)
            {
                dsElement.Tables[0].Rows[i]["Ele_Max"]=Convert.ToDouble(txtMax.Text.Trim());
                dsElement.Tables[0].Rows[i]["Ele_Min"]=Convert.ToDouble(txtMin.Text.Trim());
            }
            dsElement.AcceptChanges();

            //tChart1.Axes.Top.Minimum = Convert.ToDouble(txtMin.Text.Trim());
            //tChart1.Axes.Top.Maximum = Convert.ToDouble(txtMax.Text.Trim());
            //tChart1.Axes.Top.EndPosition = Convert.ToDouble(txtMax.Text.Trim());
               
            LineFirst.DataSource = dsElement;
            LineStdMax.DataSource = dsElement;
            LineStdMin.DataSource = dsElement;
            tChart1.Refresh();
            tChart1.Page.Current = 1;

        }
        /********Modify End**********/

       
    }
}



 