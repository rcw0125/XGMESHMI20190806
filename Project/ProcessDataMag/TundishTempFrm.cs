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
    public partial class TundishTempFrm : DockContent, IMESForm
    {
        public TundishTempFrm()
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
        private void TundishTempFrm_Load(object sender, EventArgs e)
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
                dsElement.Tables[0].Rows.Clear();
                dsElementStd.Tables[0].Clear();

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
                string strSteelGradeCondition = "";//钢种查询条件
                string strSQL = "";
                if (cmbCCMID.Text.Trim() == "S61" || cmbCCMID.Text.Trim() == "S62")
                {
                    if (cmbSteelGrade.Text.Trim() != "")
                    {
                        strSteelGradeCondition = " and CHANGE_STEELGRADE = '" + cmbSteelGrade.Text.Trim() + "'";
                    }
                    strSQL += "  SELECT   heatid, tundishtemp15 AS temp                         ";
                    strSQL += "    FROM xgwebrpt.tc_originaldata_no1andno2                      ";
                    strSQL += "   WHERE SUBSTR (logtime, 1, 7) = '" + dtStart.Text.Trim() + "'  ";
                    strSQL += " and CCMID = '" + cmbCCMID.Text.Trim() + "'                      ";
                    strSQL += strSteelGradeCondition;
                    strSQL += " and tundishtemp15 <> 0                                          ";
                    strSQL += "ORDER BY heatid                                                  ";
                }
                else if (cmbCCMID.Text.Trim() == "S63" || cmbCCMID.Text.Trim() == "S64")
                {
                    if (cmbSteelGrade.Text.Trim() != "")
                    {
                        strSteelGradeCondition = "and STEEL_GRADE = '" + cmbSteelGrade.Text.Trim() + "'";
                    }
                    strSQL += "  SELECT   heatid, tundishtemp15 AS temp                         ";
                    strSQL += "    FROM xgwebrpt.tc_originaldata_no3andno4                      ";
                    strSQL += "   WHERE SUBSTR (logtime, 1, 7) = '" + dtStart.Text.Trim() + "'  ";
                    strSQL += " and CCMID = '" + cmbCCMID.Text.Trim() + "'                      ";
                    strSQL += strSteelGradeCondition;
                    strSQL += " and tundishtemp15 <> 0                                          ";
                    strSQL += "ORDER BY heatid                                                  ";

                }
                    /******Modify Begin At 2011-03-10 By Huyunhai*****/
                else if (cmbCCMID.Text.Trim() == "S65"||cmbCCMID.Text.Trim()=="S67")
                    /****Modify END***/
                {
                    if (cmbSteelGrade.Text.Trim() != "")
                    {
                        strSteelGradeCondition = "and STEEL_GRADE = '" + cmbSteelGrade.Text.Trim() + "'";
                    }
                    strSQL += "  SELECT   heatid, TUNDISHTEMP20 AS temp                             ";
                    strSQL += "    FROM xgwebrpt.TC_ORIGINALDATA_NO5                                ";
                    strSQL += "   WHERE SUBSTR (logtime, 1, 7) = '" + dtStart.Text.Trim() + "'      ";
                    strSQL += strSteelGradeCondition;
                    strSQL += " and TUNDISHTEMP20 <> 0                                              ";
                    strSQL += "ORDER BY heatid                                                      ";
                }
                else
                {
                    MessageBox.Show("所选铸机好无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }
                dsElement.SourceMethod = strSQL;

                strSQL = "";
                dsElementStd.SourceMethod = "";
                strSQL += "SELECT   a.heatid, b.tundish_temp_min AS ele_min,                                ";
                strSQL += "         b.tundish_temp_max AS ele_max                                           ";
                strSQL += "    FROM cccm_base_data a, cqa_caster_std_tundish b                              ";
                strSQL += "   WHERE a.steelgradeindex = b.steelgradeindex                                   ";
                strSQL += "     AND ccmid = '" + cmbCCMID.Text + "'                                         ";
                strSQL += "     AND TO_CHAR (a.productiondate, 'yyyy-mm') = '" + dtStart.Text.Trim() + "'   ";
                strSQL += "ORDER BY heatid                                                                  ";
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
                LineStdMax.DataSource = dsElementStd;
                LineStdMin.DataSource = dsElementStd;

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

 //dsTemp.SourceMethod = "";
                //strSQL += "SELECT   a.heatid, b.temp, b.measure_time                                        ";
                //strSQL += "    FROM cccm_base_data a, cccm_heat_tundishtemp b                               ";
                //strSQL += "   WHERE a.heatid IS NOT NULL                                                    ";
                //strSQL += "     AND a.heatid = b.heatid(+)                                                  ";
                //strSQL += "     AND b.invalidflag <> 1                                                      ";
                //strSQL += "     AND TO_CHAR (a.productiondate, 'yyyy-mm') = '" + dtStart.Text.Trim() + "'   ";
                //strSQL += "     AND a.ccmid = '" + cmbBOFID.Text + "'                                       ";
                //strSQL += "ORDER BY a.heatid, b.measure_time                                                ";
                //dsTemp.SourceMethod = strSQL;

//if (cmbBOFID.Text != "S65")
//{
//    foreach (DataRow dr in dsElementStd.Tables[0].Rows)
//    {
//        DataRow[] drArray = dsTemp.Tables[0].Select("HeatID = '" + dr["HeatID"].ToString() + "'", "measure_time");

//        if (drArray.Length >= 3)
//        {
//            dsElement.Tables[0].ImportRow(drArray[2]);
//            continue;
//        }
//        if (drArray.Length == 2)
//        {
//            dsElement.Tables[0].ImportRow(drArray[1]);
//            continue;
//        }
//        if (drArray.Length == 1)
//        {
//            dsElement.Tables[0].ImportRow(drArray[0]);
//            continue;
//        }
//    }
//}
//else
//{
//    foreach (DataRow dr in dsElementStd.Tables[0].Rows)
//    {
//        DataRow[] drArray = dsTemp.Tables[0].Select("HeatID = '" + dr["HeatID"].ToString() + "'", "measure_time");

//        if (drArray.Length >= 4)
//        {
//            dsElement.Tables[0].ImportRow(drArray[3]);
//            continue;
//        }
//        if (drArray.Length == 3)
//        {
//            dsElement.Tables[0].ImportRow(drArray[2]);
//            continue;
//        }
//        if (drArray.Length == 2)
//        {
//            dsElement.Tables[0].ImportRow(drArray[1]);
//            continue;
//        }
//        if (drArray.Length == 1)
//        {
//            dsElement.Tables[0].ImportRow(drArray[0]);
//            continue;
//        }
//    }
//}