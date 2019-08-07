using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnergyMag
{
    public partial class EnergyStatShowFrm : Form
    {
        public EnergyStatShowFrm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <param name="strSort"></param>
        /// <param name="iPosition"></param>
        /// <param name="bPreDtEnabled">已提交数据库数据再做修改，其主键ProductionDate不能修改</param>
        /// <param name="dsData"></param>
        /// <returns></returns>
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int iPosition, bool bPreDtEnabled, ref AppSvrHMI.L3DataSet dsData)
        {
            try
            {
                dtProductionDate.Enabled = bPreDtEnabled;

                bsStat.DataSource = null;
                bsStat.DataSource = dsData;
                bsStat.DataMember = dsData.Tables[0].TableName;

                ((System.Data.DataRowView)(bsStat.Current)).DataView.Sort = strSort;
                bsStat.Position = iPosition;

                Adapter.Session = session;
                Adapter.RefreshDataBindings();
                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void EnergyStatShowFrm_Load(object sender, EventArgs e)
        {

        }

        private void GetLastTotalData(string strProDate)
        {
            try
            {
                dsLastData.Tables[0].Clear();
                string strSQL = "";
                string strMonthFirstDate = strProDate.Substring(0, 8) + "01";
                strSQL += "SELECT *                                                      ";
                strSQL += " FROM (SELECT   *                                             ";
                strSQL += "           FROM cenergy_manual_data                           ";
                strSQL += "          WHERE productiondate < '" + strProDate + "'         ";
                strSQL += "            AND productiondate >= '" + strMonthFirstDate + "' ";
                strSQL += "       ORDER BY productiondate DESC)                          ";
                strSQL += "WHERE ROWNUM < 2                                              ";
                dsLastData.SourceMethod = strSQL;
            }
            catch { dsLastData.Tables[0].Clear(); }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsStat.EndEdit();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsStat.CancelEdit();
            Close();
        }

        //焦炉煤气累计消耗
        private double d_CFCO_M = 0;
        //转炉煤气累计消耗
        private double d_BOFCO_M = 0;
        //转炉煤气回收累计消耗
        private double d_BOFCO_CallBack_M = 0;
        //氮气累计消耗
        private double d_N2_M = 0;
        //精品钢氮气累计消耗
        private double d_N2_SpecialSteel_M = 0;
        //氧气累计消耗
        private double d_O2_M = 0;
        //累计产量
        private double d_Production_M = 0;
        //精品钢累计产量
        private double d_Production_Special_M = 0;

        //当前日产
        private double d_Cur_Pro = 0;
        //当前累计产量
        private double d_Cur_Pro_M = 0;
        //当前精品钢日产量
        private double d_Cur_Pro_F = 0;
        //当前精品钢累计产量
        private double d_Cur_Pro_F_M = 0;

        private void dsLastData_OnDataLoaded(object sender)
        {
            try
            {
                if (dsLastData.Tables[0].Rows.Count < 1)
                    return;
                d_CFCO_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["CFCO_M"].ToString());
                d_BOFCO_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["BOFCO_M"].ToString());
                d_BOFCO_CallBack_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["BOFCO_CallBack_M"].ToString());
                d_N2_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["N2_M"].ToString());
                d_N2_SpecialSteel_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["N2_SpecialSteel_M"].ToString());
                d_O2_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["O2_M"].ToString());
                d_Production_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["Production_M"].ToString());
                d_Production_Special_M = Convert.ToDouble(dsLastData.Tables[0].Rows[0]["Production_Special_M"].ToString());
            }
            catch { }
        }
       
        //日产量
        private void txtProduction_D_TextChanged(object sender, EventArgs e)
        {
            try
            {
                d_Cur_Pro = txtProduction_D.Text.Length < 1 ? 0 : Convert.ToDouble(txtProduction_D.Text);
                d_Cur_Pro_M = d_Production_M + d_Cur_Pro;
                txtProduction_M.Text = string.Format("{0:F}", d_Cur_Pro_M);

                txtFlow_CFCO_TextChanged(null, null);
                txtFlow_BOFCO_TextChanged(null, null);
                txtFlow_BOFCO_CallBack_TextChanged(null, null);
                txtFlow_N2_TextChanged(null, null);
                txtO2_TextChanged(null, null);
            }
            catch
            {
                d_Cur_Pro = 0;
                d_Cur_Pro_M = 0;
                txtProduction_M.Text = "0";
            }
        }

        //精品钢日产量
        private void txtProduction_Special_D_TextChanged(object sender, EventArgs e)
        {
            try
            {
                d_Cur_Pro_F = txtProduction_Special_D.Text.Length < 1 ? 0 : Convert.ToDouble(txtProduction_Special_D.Text);
                d_Cur_Pro_F_M = d_Production_Special_M + d_Cur_Pro_F;

                txtProduction_Special_M.Text = string.Format("{0:F}", d_Cur_Pro_F_M);

                txtFlow_N2_SpecialSteel_TextChanged(null, null);
            }
            catch
            {
                d_Cur_Pro_F = 0;
                d_Cur_Pro_F_M = 0;

                txtProduction_Special_M.Text = "0";
            }
        }

        //焦炉煤气
        private void txtFlow_CFCO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_CFCO.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_CFCO.Text.Trim());

                txtCFCO_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtCFCO_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtCFCO_D.Text.Trim());
                if (d_Cur_Pro > 0)
                    txtCFCO_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro);
                else
                    txtCFCO_D_Avg.Text = "0";

                double dCur_M = d_CFCO_M + dCur_D;
                txtCFCO_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_M > 0)
                    txtCFCO_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_M);
                else
                    txtCFCO_M_Avg.Text = "0";

            }
            catch
            {
            }
        }

        //转炉煤气
        private void txtFlow_BOFCO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_BOFCO.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_BOFCO.Text.Trim());

                txtBOFCO_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtBOFCO_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtBOFCO_D.Text.Trim());
                if (d_Cur_Pro > 0)
                    txtBOFCO_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro);
                else
                    txtBOFCO_D_Avg.Text = "0";

                double dCur_M = d_BOFCO_M + dCur_D;
                txtBOFCO_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_M > 0)
                    txtBOFCO_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_M);
                else
                    txtBOFCO_M_Avg.Text = "0";

            }
            catch { }
        }

        //转炉煤气回收
        private void txtFlow_BOFCO_CallBack_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_BOFCO_CallBack.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_BOFCO_CallBack.Text.Trim());

                txtBOFCO_CallBack_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtBOFCO_CallBack_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtBOFCO_CallBack_D.Text.Trim());
                if (d_Cur_Pro > 0)
                    txtBOFCO_CallBack_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro);
                else
                    txtBOFCO_CallBack_D_Avg.Text = "0";

                double dCur_M = d_BOFCO_CallBack_M + dCur_D;
                txtBOFCO_CallBack_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_M > 0)
                    txtBOFCO_CallBack_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_M);
                else
                    txtBOFCO_CallBack_M_Avg.Text = "0";

            }
            catch { }
        }

        //氮气
        private void txtFlow_N2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_N2.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_N2.Text.Trim());

                txtN2_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtN2_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtN2_D.Text.Trim());
                if (d_Cur_Pro > 0)
                    txtN2_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro);
                else
                    txtN2_D_Avg.Text = "0";

                double dCur_M = d_N2_M + dCur_D;
                txtN2_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_M > 0)
                    txtN2_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_M);
                else
                    txtN2_M_Avg.Text = "0";
            }
            catch { }
        }

        //精品钢氮气
        private void txtFlow_N2_SpecialSteel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_N2_SpecialSteel.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_N2_SpecialSteel.Text.Trim());

                txtN2_SpecialSteel_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtN2_SpecialSteel_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtN2_SpecialSteel_D.Text.Trim());
                if (d_Cur_Pro_F > 0)
                    txtN2_SpecialSteel_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro_F);
                else
                    txtN2_SpecialSteel_D_Avg.Text = "0";

                double dCur_M = d_N2_SpecialSteel_M + dCur_D;
                txtN2_SpecialSteel_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_F_M > 0)
                    txtN2_SpecialSteel_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_F_M);
                else
                    txtN2_SpecialSteel_M_Avg.Text = "0";

            }
            catch { }
        }

        //氧气
        private void txtO2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double dFlow = txtFlow_O2.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtFlow_O2.Text.Trim());

                txtO2_D.Text = string.Format("{0:F}", 24 * dFlow);

                double dCur_D = txtO2_D.Text.Trim().Length < 1 ? 0 : Convert.ToDouble(txtO2_D.Text.Trim());
                if (d_Cur_Pro > 0)
                    txtO2_D_Avg.Text = string.Format("{0:F}", dCur_D / d_Cur_Pro);
                else
                    txtO2_D_Avg.Text = "0";

                double dCur_M = d_O2_M + dCur_D;
                txtO2_M.Text = string.Format("{0:F}", dCur_M);

                if (d_Cur_Pro_M > 0)
                    txtO2_M_Avg.Text = string.Format("{0:F}", dCur_M / d_Cur_Pro_M);
                else
                    txtO2_M_Avg.Text = "0";
            }
            catch { }
        }

        private void dtProductionDate_ValueChanged(object sender, EventArgs e)
        {
            GetLastTotalData(dtProductionDate.Value.ToString("yyyy-MM-dd"));
        }

    }
}