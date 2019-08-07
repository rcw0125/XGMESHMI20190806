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
    public partial class CommonFrm : DockContent, IMESForm
    {
        public CommonFrm()
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
        private void CommonFrm_Load(object sender, EventArgs e)
        {
            string strSql = "";
            strSql = "    SELECT   steelgrade                   ";
            strSql += "     FROM cqa_steelgradeindex_r          ";
            strSql += "    WHERE steelgradeindex IS NOT NULL and  steelgradeindex <> 'YY000000'  ";
            strSql += " GROUP BY steelgrade                     ";
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
                    strSteelGradeCon = " and a.SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";

                string strElement = cmbElement.Text;
                string strSQL = "";

                /********************************* 炉终样  *************************************************/
                strSQL += "  SELECT   a.heatid AS heatid, b." + strElement + " AS ELEMENT, c." + strElement + "_min AS ele_min,";
                strSQL += "         c." + strElement + "_max AS ele_max                                       ";
                strSQL += "    FROM cbof_base_data a, cqa_lab_element b, cqa_product_sheet c ";

                dsElement.SourceMethod = strSQL + " where 1=2";

                strSQL += "   WHERE SUBSTR (a.heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'";
                strSQL += "     AND TO_CHAR (a.productiondate, 'yyyy-MM') = '"+ dtStart.Text.Trim() +"'        ";
                strSQL += "     AND a.heatid = b.heatid(+)                                   ";
                strSQL += "     AND b.unittypeid = '2'";
                strSQL += "     AND b.unitid = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'";
                strSQL += "     AND b.sample_type = 'GZ'                                     ";
                strSQL += "     AND b.sample_count = '01'                                    ";
                strSQL += "     AND a.steelgradeindex = c.steelgradeindex                    ";
                strSQL += strSteelGradeCon;
                strSQL += "ORDER BY a.heatid                                                 ";

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
            catch(Exception ee)
            {
                tChart1.Axes.Top.Minimum = 0;
                tChart1.Axes.Top.Maximum = 0;
                tChart1.Axes.Top.EndPosition = 0;
                LineFirst.DataSource = null;
                LineStdMax.DataSource = null;
                LineStdMin.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
                MessageBox.Show(ee.ToString(), "异常");
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



 