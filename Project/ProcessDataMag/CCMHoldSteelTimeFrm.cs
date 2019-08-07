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
    public partial class CCMHoldSteelTimeFrm : DockContent, IMESForm
    {
        public CCMHoldSteelTimeFrm()
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
        private void CCMHoldSteelTimeFrm_Load(object sender, EventArgs e)
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
                tChart1.Page.Current = 1;

                if (cmbCCMID.Text == "")
                {
                    MessageBox.Show("请选择铸机！", "提示");
                    return;
                }
                string strSQL = "";
                /**********************************************************************************/
                strSQL += "  SELECT   heatid, ELEMENT, ele_max, ele_min                                                         ";
                strSQL += "    FROM (SELECT a.heatid, b.holdtime AS ELEMENT,                                                    ";
                strSQL += "                 -c.stay_steel_time_max AS ele_max,                                                  ";
                strSQL += "                 c.hold_steel_time_max AS ele_min                                                    ";
                strSQL += "            FROM (SELECT   heatid, steelgradeindex                                                   ";
                strSQL += "                      FROM cccm_base_data                                                            ";
                strSQL += "                     WHERE TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'       ";
                strSQL += "                       AND SUBSTR (treatno, 1, 1) = '" + cmbCCMID.Text.Trim().Substring(2, 1) + "'   ";
                strSQL += "                  ORDER BY heatid) a,                                                                ";
                strSQL += "                 (SELECT   heatid, ROUND (holdtime / 60, 1) AS holdtime                              ";
                strSQL += "                      FROM cccm_heat_ladle                                                           ";
                strSQL += "                     WHERE TO_CHAR (casting_start_time, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'   ";
                strSQL += "                       AND SUBSTR (treatno, 1, 1) = '" + cmbCCMID.Text.Trim().Substring(2, 1) + "'   ";
                strSQL += "                  ORDER BY heatid) b,                                                                ";
                strSQL += "                 cqa_caster_std_proc c                                                               ";

                dsElement.SourceMethod = strSQL + "WHERE 1 = 2 )";
                
                strSQL += "           WHERE a.heatid = b.heatid AND a.steelgradeindex = c.steelgradeindex)                      ";
                strSQL += "ORDER BY heatid                                                                                      ";
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



 