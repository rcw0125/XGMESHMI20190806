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
    public partial class DepartureTempFrm : DockContent, IMESForm
    {
        public DepartureTempFrm()
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
        private void DepartureTempFrm_Load(object sender, EventArgs e)
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
                LineStdMax.DataSource = null;
                LineStdMin.DataSource = null;
                tChart1.Refresh();
                if (cmbUnitID.Text == "")
                {
                    MessageBox.Show("请选择工位！", "提示");
                    return;
                }
                dsElement.SourceMethod = " SELECT 0 heatid, 0 ELEMENT,0 ele_min,0 ele_max from clf_base_data where 1=2";
                string strSQL = "";
                string strUnitType = cmbUnitID.Text.Trim().Substring(1, 1);
                string strUnitID = cmbUnitID.Text.Trim().Substring(2, 1);
                if (strUnitType == "4")
                {
                    /********************************* LF离站温度  *************************************************/
                    strSQL += "  SELECT   a.heatid, departure_temp AS ELEMENT, a.ele_min, a.ele_max                             ";
                    strSQL += "    FROM (SELECT   a.heatid, a.treatno, lea_temp_min AS ele_min,                                 ";
                    strSQL += "                   lea_temp_max AS ele_max                                                       ";
                    strSQL += "              FROM clf_base_data a,                                                              ";
                    strSQL += "                   (SELECT   heatid, MAX (productiondate) AS productiondate                      ";
                    strSQL += "                        FROM clf_base_data                                                       ";
                    strSQL += "                       WHERE TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "' ";
                    strSQL += "                    GROUP BY heatid) b,                                                          ";
                    strSQL += "                   cqa_lf_std_proc c                                                             ";
                    strSQL += "             WHERE a.heatid = b.heatid                                                           ";
                    strSQL += "               AND a.productiondate = b.productiondate                                           ";
                    strSQL += "               AND a.steelgradeindex = c.steelgradeindex                                         ";
                    strSQL += "          ORDER BY a.heatid) a,                                                                  ";
                    strSQL += "         clf_process_data b                                                                      ";
                    strSQL += "   WHERE a.treatno = b.treatno AND SUBSTR (b.treatno, 1, 1) = '" + strUnitID + "'                ";
                    strSQL += "ORDER BY a.heatid                                                                                ";
                }
                /********************************* RH离站温度  *************************************************/
                else if (strUnitType == "5")
                {
                    strSQL += "  SELECT   a.heatid, departure_temp AS ELEMENT, a.ele_min, a.ele_max                             ";
                    strSQL += "    FROM (SELECT   a.heatid, a.treatno, lea_temp_min AS ele_min,                                 ";
                    strSQL += "                   lea_temp_max AS ele_max                                                       ";
                    strSQL += "              FROM crh_base_data a,                                                              ";
                    strSQL += "                   (SELECT   heatid, MAX (productiondate) AS productiondate                      ";
                    strSQL += "                        FROM crh_base_data                                                       ";
                    strSQL += "                       WHERE TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "' ";
                    strSQL += "                    GROUP BY heatid) b,                                                          ";
                    strSQL += "                   cqa_rh_std_proc c                                                             ";
                    strSQL += "             WHERE a.heatid = b.heatid                                                           ";
                    strSQL += "               AND a.productiondate = b.productiondate                                           ";
                    strSQL += "               AND a.steelgradeindex = c.steelgradeindex                                         ";
                    strSQL += "          ORDER BY a.heatid) a,                                                                  ";
                    strSQL += "         crh_process_data b                                                                      ";
                    strSQL += "   WHERE a.treatno = b.treatno AND SUBSTR (b.treatno, 1, 1) = '" + strUnitID + "'                ";
                    strSQL += "ORDER BY a.heatid                                                                                ";
                }

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



 