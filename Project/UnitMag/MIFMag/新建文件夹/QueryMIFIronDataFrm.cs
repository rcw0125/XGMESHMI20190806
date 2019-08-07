using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.MIFMag
{
    public partial class QueryMIFIronDataFrm : DockContent, IMESForm
    {
        public QueryMIFIronDataFrm()
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
       
        private void QueryMIFIronDataFrm_Load(object sender, EventArgs e)
        {
            cbxMode.SelectedIndex = 0;
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void cbxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            while(tabCtrlMain.TabPages.Count > 0)
                tabCtrlMain.TabPages.RemoveAt(0);
            if (cbxMode.Text.Substring(0, 1) == "2")
                tabCtrlMain.TabPages.Add(tabPageMIFIron);
            else
                tabCtrlMain.TabPages.Add(tabPageBFIron);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            double dDateLength = 0;
            if (cbxMode.Text.Substring(0, 1) == "2")
            {
                if (txtHeatID.Text.Length != 9)
                {
                    dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
                    if (dDateLength > 7)
                    {
                        MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                        return;
                    }
                    dsMIFIron.SourceCondition = "1=2";
                    if (txtHeatID.Text.Trim() == "")
                        dsMIFIron.SourceCondition = "to_Char(Tap_Time,'yyyy-MM-dd') >= '"
                            + dtStart.Text.Trim() + "' and " + "to_Char(Tap_Time,'yyyy-MM-dd') <= '" + dtEnd.Text.Trim() + "'   order by Tap_Time asc";
                    else
                        dsMIFIron.SourceCondition = "to_Char(Tap_Time,'yyyy-MM-dd') >= '"
                            + dtStart.Text.Trim() + "' and " + "to_Char(Tap_Time,'yyyy-MM-dd') <= '"
                            + dtEnd.Text.Trim() + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%'  order by Tap_Time asc";
                }
                else
                    dsMIFIron.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";

                //if (dsMIFIron.Tables[0].Rows.Count > 0)
                //{
                //    //dsMIFIron.Tables[0].Columns.Add("DesFlag", System.Type.GetType("System.String"));
                //    for (int i = 0; i < dsMIFIron.Tables[0].Rows.Count; i++)
                //    {
                //        //String sMaterialid = dsMIFIron.Tables[0].Rows[i]["MaterialID"].ToString();
                //        //dsDesFlag.SourceCondition = " MaterialID='" + sMaterialid + "'";
                //        //dsDesFlag.LoadData();
                //        //if (dsDesFlag.Tables[0].Rows.Count > 0)
                //        //{
                //        //    dsMIFIron.Tables[0].Rows[i]["DesFlag"] = "脱硫铁水";
                //        //}
                //        //else
                //        //{
                //        //    dsMIFIron.Tables[0].Rows[i]["DesFlag"] = "非脱硫铁水";
                //        //}
                //        string strIsDes = dsMIFIron.Tables[0].Rows[i]["IsDes"].ToString();
                //        if(strIsDes=="0")
                //            dsMIFIron.Tables[0].Rows[i]["DesFlag"] = "脱硫铁水";
                //        else if(strIsDes=="-1")
                //            dsMIFIron.Tables[0].Rows[i]["DesFlag"] = "非脱硫铁水";
                //        else
                //            dsMIFIron.Tables[0].Rows[i]["DesFlag"] = "";

                //    }
                //}
                return;
            }

            string strBFIronSQL = "";
            dsBFIron.SourceMethod = strBFIronSQL;
            dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            /* 高炉进场铁水 */
            strBFIronSQL += "SELECT   a.materialid, a.bfid, a.tap_no, a.tpc_no, a.SOURCE,                                        ";
            strBFIronSQL += "         a.production_date, a.shift, a.OPERATOR, a.nc_confirm_flag, a.team,                         ";
            strBFIronSQL += "         a.RESULT, a.sample_place, a.c, a.si, a.mn, a.s, a.p, a.ti,                                 ";
            strBFIronSQL += "         a.sn, a.sb, a.\"AS\", a.pb, a.ni, a.mo,a.cu, a.cr, a.b, a.v,a.al, a.nb, a.zn, a.w,             ";//add by hyh 2012-08-13
            strBFIronSQL += "         ROUND (a.gross_weight, 3) as gross_weight, ROUND (a.last_tare, 3) as last_tare,            ";
            strBFIronSQL += "         ROUND (a.curr_tare, 3) as curr_tare, ROUND (a.net_weight, 3) as net_weight,                ";
            strBFIronSQL += "         ROUND (a.spare_weight, 3) as spare_weight, a.ironstatus, a.arrival_time, a.feed_time,      ";
            strBFIronSQL += "         a.send_time, ROUND (b.weight, 3) as weight, b.destination                                  ";
            strBFIronSQL += "    FROM cbfiron a,                                                                                 ";
            strBFIronSQL += "         (SELECT materialid, weight, destination                                                    ";
            strBFIronSQL += "            FROM (SELECT object1 AS materialid, weight1 AS weight,                                  ";
            strBFIronSQL += "                         0 AS destination                                                           ";
            strBFIronSQL += "                    FROM ciron_data                                                                 ";
            strBFIronSQL += "                   WHERE object1 IS NOT NULL                                                        ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "'          ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-MM-dd') <= '" + dtEnd.Text.Trim() + "'            ";
            strBFIronSQL += "                  UNION ALL                                                                         ";
            strBFIronSQL += "                  SELECT object2 AS materialid, weight2 AS weight,                                  ";
            strBFIronSQL += "                          0 AS destination                                                          ";
            strBFIronSQL += "                    FROM ciron_data                                                                 ";
            strBFIronSQL += "                   WHERE object2 IS NOT NULL                                                        ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "'          ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-MM-dd') <= '" + dtEnd.Text.Trim() + "'            ";
            strBFIronSQL += "                  UNION ALL                                                                         ";
            strBFIronSQL += "                  SELECT object3 AS materialid, weight3 AS weight,                                  ";
            strBFIronSQL += "                           0 AS destination                                                         ";
            strBFIronSQL += "                    FROM ciron_data                                                                 ";
            strBFIronSQL += "                   WHERE object3 IS NOT NULL                                                        ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "'          ";
            strBFIronSQL += "                     AND TO_CHAR (tap_time, 'yyyy-MM-dd') <= '" + dtEnd.Text.Trim() + "'            ";
            strBFIronSQL += "                  UNION ALL                                                                         ";
            strBFIronSQL += "                  SELECT  materialid, sum(Amount) AS weight,                                        ";
            strBFIronSQL += "                         TO_NUMBER (SUBSTR (mifid, 3, 1)) AS destination                            ";
            strBFIronSQL += "                    FROM cmif_feed_log                                                              ";
            strBFIronSQL += "                   WHERE materialtype = 'CBFIron'                                                   ";
            strBFIronSQL += "                      AND TO_CHAR (logdate, 'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "'          ";
            strBFIronSQL += "                      AND TO_CHAR (logdate, 'yyyy-MM-dd') <= '" + dtEnd.Text.Trim() + "'            ";
            strBFIronSQL += "                      group by materialid,TO_NUMBER (SUBSTR (mifid, 3, 1)))) b                      ";
            strBFIronSQL += "    WHERE a.materialid(+) = b.materialid                                                            ";
            strBFIronSQL += " ORDER BY a.arrival_time                                                                            ";
            //strBFIronSQL = "select a.*,c.Code_Des from (" + strBFIronSQL + ") a,CDeS_Base_Data b,CBase_All_Code c                ";
           // strBFIronSQL += " where a.materialid=b.materialid and b.DesType=c.CODE_VAL_LONG and c.code_group = 'DeSType'                  ";
            dsBFIron.SourceMethod = strBFIronSQL;
        }                                                                                          

        private void dvBFIron_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvMIFIron_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnBFIromOutput_Click(object sender, EventArgs e)
        {
            try
            {
                CommDataMag.CommonMethed.PutIntoExcel("高炉铁水信息", dvBFIron);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "错误"); }
        }

        private void btnMIFOutput_Click(object sender, EventArgs e)
        {
            try
            {
                CommDataMag.CommonMethed.PutIntoExcel("出铁铁水信息", dvMIFIron);
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message, "错误"); }
        }

    }
}
