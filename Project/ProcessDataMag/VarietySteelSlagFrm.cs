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
    public partial class VarietySteelSlagFrm : DockContent, IMESForm
    {
        public VarietySteelSlagFrm()
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
        private void VarietySteelSlagFrm_Load(object sender, EventArgs e)
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
            #region 查询
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
                    MessageBox.Show("请选择LF炉座！", "提示");
                    return;
                }
                if (cmbElement.Text == "")
                {
                    MessageBox.Show("请选择组分！", "提示");
                    return;
                }
                string strSteelGradeCon = "";
                if (cmbSteelGrade.Text != "")
                {
                    strSteelGradeCon = " AND a.SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";
                }
                dsElement.SourceMethod = "";
                string strElement = cmbElement.Text;
                string strSQL = "";

                /* 品种钢精炼渣组分 */
                strSQL += "SELECT   a.heatid AS heatid, b." + strElement + " AS ELEMENT, c." + strElement + "_max AS ele_max, ";
                strSQL += "         c." + strElement + "_min AS ele_min                                                                      ";
                strSQL += "    FROM clf_base_data a, cqa_lab_slagele b, cqa_lf_std_slag_ele c                                                ";
                strSQL += "   WHERE a.heatid = b.heatid(+)                                                                                   ";
                strSQL += "     AND SUBSTR (a.treatno, 1, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'                                ";
                strSQL += "     AND TO_CHAR (a.productiondate, 'yyyy-mm') = '" + dtStart.Text.Trim() + "'                                    ";
                strSQL += "     AND b." + strElement + " IS NOT NULL                                                                         ";
                strSQL += "     AND a.steelgradeindex = c.steelgradeindex                                                                    ";
                strSQL += strSteelGradeCon;
                strSQL += "ORDER BY heatid                                                                                                   ";
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
                LineFirst.DataSource = dsElement;
                LineStdMax.DataSource = dsElement;
                LineStdMin.DataSource = dsElement;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
            #endregion
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

        private void txtMax_MouseLeave(object sender, EventArgs e)
        {
            if(txtMin.Text == "")
                return;
            //tChart1.Axes.Bottom = Convert.ToDouble(txtMin.Text);
            //tChart1.Axes.Top=Convert.ToDouble(txtMax.Text);

        }

        private void txtMin_MouseLeave(object sender, EventArgs e)
        {
            if (txtMax.Text == "")
                return;
            //tChart1.Axes.Bottom = Convert.ToDouble(txtMin.Text);
            //tChart1.Axes.Top = Convert.ToDouble(txtMax.Text);


        }
    }
}



