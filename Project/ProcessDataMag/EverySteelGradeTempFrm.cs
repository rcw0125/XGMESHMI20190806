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
    public partial class EverySteelGradeTempFrm : DockContent, IMESForm
    {
        public EverySteelGradeTempFrm()
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
        private void EverySteelGradeTempFrm_Load(object sender, EventArgs e)
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

                tChart1.Refresh();
                tChart1.Page.Current = 1;

                if (cmbBOFID.Text == "")
                {
                    MessageBox.Show("请选择炉座！", "提示");
                    return;
                }
                if (cmbElement.Text == "")
                {
                    MessageBox.Show("请选择查看温度类型！", "提示");
                    return;
                }
                string strSteelGradeCon = "";
                if (cmbSteelGrade.Text != "")
                {
                    strSteelGradeCon = " AND SteelGrade = '" + cmbSteelGrade.Text.Trim() + "'";
                }
                dsElement.SourceMethod = "SELECT heatid, 0 AS ELEMENT,  0 AS ele_max ,0 AS ele_min from cbof_base_data where 1=2";
                //确定查看温度类型
                LineFirst.Title = cmbElement.Text.Trim();
                string strTempType = cmbElement.Text.Trim().Substring (0,1);
                string strSQL = "";
                switch (strTempType)
                {
                    case "1":
                        /* 1:拉碳温度*/
                        strSQL += "   SELECT   a.heatid AS heatid, lac_temp AS ELEMENT                                        ";
                        strSQL += "     FROM (SELECT   heatid                                                                 ";
                        strSQL += "               FROM cbof_base_data                                                         ";
                        strSQL += "              WHERE SUBSTR (heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "' ";
                        strSQL += "                AND TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'    ";
                        strSQL += strSteelGradeCon;
                        strSQL += "           ORDER BY heatid) a,                                                             ";
                        strSQL += "          cbof_process_data b                                                              ";
                        strSQL += "    WHERE a.heatid = b.heatid(+)                                                           ";
                        strSQL += " ORDER BY heatid                                                                           ";
                        dsElement.SourceMethod = strSQL;

                        tChart1.Axes.Left.Minimum = 1550;
                        tChart1.Axes.Left.Maximum = 1800;
                        break;
                    case "2":
                        /* 出钢温度*/
                        strSQL += " SELECT   a.heatid AS heatid, b.tapping_temp AS ELEMENT　                                   ";
                        strSQL += "   FROM (SELECT   heatid                                                                   ";
                        strSQL += "             FROM cbof_base_data                                                           ";
                        strSQL += "            WHERE SUBSTR (heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'   ";
                        strSQL += "              AND TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'      ";
                        strSQL += strSteelGradeCon;
                        strSQL += "         ORDER BY heatid) a,                                                               ";
                        strSQL += "        cbof_process_data b                                                                ";
                        strSQL += "  WHERE a.heatid = b.heatid(+)                                                             ";
                        strSQL += "ORDER BY heatid                                                                            ";
                        dsElement.SourceMethod = strSQL;

                        tChart1.Axes.Left.Minimum = 1550;
                        tChart1.Axes.Left.Maximum = 1800;
                        break;
                    case "3":
                        /*出钢温降*/
                        strSQL += "  SELECT   a.heatid AS heatid,                                                             ";
                        strSQL += "         (b.tapping_temp - c.temp_before_blowar) AS ELEMENT                                ";
                        strSQL += "    FROM (SELECT   heatid                                                                  ";
                        strSQL += "              FROM cbof_base_data                                                          ";
                        strSQL += "             WHERE SUBSTR (heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'  ";
                        strSQL += "               AND TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'     ";
                        strSQL += strSteelGradeCon;
                        strSQL += "          ORDER BY heatid) a,                                                              ";
                        strSQL += "         cbof_process_data b,                                                              ";
                        strSQL += "         ctap_process_data c                                                               ";
                        strSQL += "   WHERE a.heatid = b.heatid(+) AND a.heatid = c.heatid(+)                                 ";
                        strSQL += "ORDER BY a.heatid                                                                          ";
                        dsElement.SourceMethod = strSQL;

                        tChart1.Axes.Left.Minimum = 0;
                        tChart1.Axes.Left.Maximum = 200;
                        break;
                    case "4":
                        /* 氩前温度*/
                        strSQL += "  SELECT   a.heatid AS heatid, temp_before_blowar AS ELEMENT　                              ";
                        strSQL += "    FROM (SELECT   heatid                  ";
                        strSQL += "              FROM cbof_base_data                                      ";
                        strSQL += "             WHERE SUBSTR (heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'  ";
                        strSQL += "               AND TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'     ";
                        strSQL += strSteelGradeCon;
                        strSQL += "          ORDER BY heatid) a,                                                              ";
                        strSQL += "         ctap_process_data b                                                               ";
                        strSQL += "   WHERE a.heatid = b.heatid(+)                                                            ";
                        strSQL += "ORDER BY heatid                                                                            ";
                        dsElement.SourceMethod = strSQL;

                        tChart1.Axes.Left.Minimum = 1500;
                        tChart1.Axes.Left.Maximum = 1750;
                        break;
                    case "5":
                        /* 氩后温度*/
                        strSQL += "  SELECT   a.heatid AS heatid, temp_blownar AS ELEMENT　                                   ";
                        strSQL += "    FROM (SELECT   heatid                      ";
                        strSQL += "              FROM cbof_base_data                                        ";
                        strSQL += "             WHERE SUBSTR (heatid, 2, 1) = '" + cmbBOFID.Text.Trim().Substring(2, 1) + "'  ";
                        strSQL += "               AND TO_CHAR (productiondate, 'yyyy-MM') = '" + dtStart.Text.Trim() + "'     ";
                        strSQL += strSteelGradeCon;
                        strSQL += "          ORDER BY heatid) a,                                                              ";
                        strSQL += "         ctap_process_data b                                                               ";
                        strSQL += "   WHERE a.heatid = b.heatid(+)                                                            ";
                        strSQL += "ORDER BY heatid                                                                            ";
                        dsElement.SourceMethod = strSQL;

                        tChart1.Axes.Left.Minimum = 1500;
                        tChart1.Axes.Left.Maximum = 1750;
                        break;
                    case "6":
                        /*吹氩温降*/
                        GetdsArTemp(cmbBOFID.Text.Trim().Substring(2, 1), strSteelGradeCon, dtStart.Text.Trim());

                        tChart1.Axes.Left.Minimum = 0;
                        tChart1.Axes.Left.Maximum = 20;
                        break;
                }
              
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

                LineFirst.Title = "";
                LineFirst.DataSource = null;

                tChart1.Refresh();
                tChart1.Page.Current = 1;
            }
        }

        //获取钢种类型，吹氩温差，时间
        private void GetdsArTemp(string strBOFIDCondition, string strGradeCondition, string strdtCondition)
        {
            dsArTemp.Tables[0].Rows.Clear();
            dsArTemp.SourceMethod = "select heatid ,0 as temp,0 as blowar_time from cbof_base_data where 1=2";
            string strSQL = "";
            strSQL += "SELECT   heatid, temp, blowar_time                                                       ";
            strSQL += "    FROM (SELECT a.heatid AS heatid,                                                     ";
            strSQL += "                 (temp_before_blowar - temp_blownar) AS temp, blowar_time                ";
            strSQL += "            FROM (SELECT heatid                                                          ";
            strSQL += "                    FROM cbof_base_data                                                  ";
            strSQL += "                   WHERE SUBSTR (heatid, 2, 1) = '" + strBOFIDCondition + "'             ";
            strSQL += "                     AND TO_CHAR (productiondate, 'yyyy-MM') = '" + strdtCondition + "'  ";
            strSQL += "                     AND SUBSTR (steelgradeindex, 1, 1) = 'F'                            ";
            strSQL += strGradeCondition;
            strSQL += "   ) a,                                                                                  ";
            strSQL += "                 ctap_process_data b                                                     ";
            strSQL += "           WHERE a.heatid = b.heatid(+)                                                  ";
            strSQL += "          UNION ALL                                                                      ";
            strSQL += "          SELECT a.heatid,                                                               ";
            strSQL += "                 (b.feedwire_temp - b.departure_temp) AS temp,                           ";
            strSQL += "                 ROUND (process_time / 60, 0) AS blowar_time                             ";
            strSQL += "            FROM (SELECT heatid                                                          ";
            strSQL += "                    FROM cbof_base_data                                                  ";
            strSQL += "                   WHERE SUBSTR (heatid, 2, 1) = '" + strBOFIDCondition + "'             ";
            strSQL += "                     AND TO_CHAR (productiondate, 'yyyy-MM') = '" + strdtCondition + "'  ";
            strSQL += "                     AND SUBSTR (steelgradeindex, 1, 1) <> 'F'                           ";
            strSQL += strGradeCondition;
            strSQL += "  ) a,                                                                                   ";
            strSQL += "                 clf_process_data b                                                      ";
            strSQL += "           WHERE a.heatid = b.heatid(+))                                                 ";
            strSQL += "ORDER BY heatid                                                                          ";
            dsArTemp.SourceMethod = strSQL;

            SetdsEement();
        }

           //组织吹氩温降数据集
        private void SetdsEement()
        {
            try
            {
                if (dsArTemp == null)
                    return;
                if (dsArTemp.Tables[0].Rows.Count < 1)
                    return;

                for (int i = 0; i < dsArTemp.Tables[0].Rows.Count; i++)
                {
                    if (dsArTemp.Tables[0].Rows[i]["blowar_time"].ToString() == "0"
                        || dsArTemp.Tables[0].Rows[i]["blowar_time"].ToString() == "")
                        break;

                    double ddt = Convert.ToDouble(dsArTemp.Tables[0].Rows[i]["blowar_time"].ToString());
                    double dtemp = Convert.ToDouble(dsArTemp.Tables[0].Rows[i]["temp"].ToString());
                    double delement = Math.Round(dtemp / ddt,2);

                    DataRow newrow = dsElement.Tables[0].NewRow();
                    newrow["Heatid"] = dsArTemp.Tables[0].Rows[i]["Heatid"];
                    newrow["Element"] = delement;
                    dsElement.Tables[0].Rows.Add(newrow);
                }
                dsElement.AcceptChanges();
            }
            catch { }
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
