using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMScrapInfoFrm : Form
    {
        public CCMScrapInfoFrm()
        {
            InitializeComponent();
        }
        private double fweight = 0;//定尺重量
        private double fWTPerMM = 0;//每米重量 20081228Liao
        //private double dMax = 100;//设置理论重量
        private int iDivCount = 0;//拨出钢坯支数
        private int iAddCount1 = 0;//拨入钢坯支数1
        private int iAddCount2 = 0;//拨入钢坯支数2

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData, string UnitID)
        {
            //if (UnitID == CommDataMag.CommonData.CCM_UNIT_05ID)
            //{
            //    dMax = 100;
            //}
            Adapter.Session = session;
            Adapter.set_URIParameters("CCMID", UnitID);
            Adapter.RefreshDataBindings();
            dsHeatData.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);

            return ShowDialog();
        }

        //数据加载
        private void CCMScrapInfoFrm_Load(object sender, EventArgs e)
        {
            try
            {
                tbxBloomWeight.FloatDataValid(errorProvider1, toolTip1, 0, 0, -0.9999, false);

                tbxWasterCount1.TextChanged += pxControls_TextChanged;
                tbxWasterCount2.TextChanged += pxControls_TextChanged;
                tbxWasterCount3.TextChanged += pxControls_TextChanged;

                string strObjID = "";
                object objTemp = null;
                object objSteelGrade = null;
                string strSteelGradeIndex = dsHeatData.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
                int iLength = 0;
                iLength = Convert.ToInt32(dsHeatData.Tables[0].Rows[0]["Length"].ToString());
                if (strSteelGradeIndex == "")
                {
                    MessageBox.Show("获取炼钢记号失败！", "提示");
                    return;
                }
                if ((strSteelGradeIndex.Substring(0, 1) == "J") || (strSteelGradeIndex.Substring(0, 1) == "B"))
                {
                    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\" + strSteelGradeIndex, "SteelGrade", ref objSteelGrade);
                    strObjID = iLength.ToString() + objSteelGrade.ToString();
                    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + strObjID.ToString(), "Weight", ref objTemp);
                }
                else
                    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + iLength.ToString(), "Weight", ref objTemp);

                string strWeight = objTemp != null ? objTemp.ToString() : "";
                if (strWeight.Length > 0)
                {
                    fweight = double.Parse(strWeight);
                    fWTPerMM = (fweight / iLength) * 1000;//20081228Liao
                }
                else
                {
                    fWTPerMM = 0;
                    MessageBox.Show("获取定尺对应重量标准值失败！", "提示");
                    this.Close();
                }
                pxControls_TextChanged(tbxBloomWeight, e);
            }
            catch
            { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //2009-08-26Liao
            if (iDivCount > 0)
            {
                dsHeatData.Tables[0].Rows[0]["ADD_BLOOM_COUNT"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_HEATID1"] = "";
                dsHeatData.Tables[0].Rows[0]["ADD_BLOOM_COUNT2"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_HEATID2"] = "";

                if (tbxAddDivHeatID.Text.Trim() == "")
                {
                    MessageBox.Show("\"拨出炉号\"为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (tbxAddDivHeatID.Text.Trim() == tbxHeatid.Text.Trim())
                {

                    MessageBox.Show("\"拨出炉号\"不能与\"当前炉号\"相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (iDivCount < 0)
            {
                dsHeatData.Tables[0].Rows[0]["DIV_BLOOM_COUNT"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_DIV_HEATID"] = "";

                if (iAddCount1 < 0 || iAddCount2 < 0)
                {
                    MessageBox.Show("\"拨入钢坯支数\"不能小于零！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (iAddCount1 > 0)
                {
                    if (tbxAddHeatID1.Text.Trim() == "")
                    {
                        MessageBox.Show("\"拨入炉号1\"为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (tbxAddHeatID1.Text.Trim() == tbxHeatid.Text.Trim())
                    {

                        MessageBox.Show("\"拨入炉号1\"不能与\"当前炉号\"相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (tbxAddHeatID1.Text.Trim().Length != 9)
                    {

                        MessageBox.Show("\"拨入炉号1\"输入可能错误，只能输入一个炉号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (iAddCount2 > 0)
                {
                    if (tbxAddHeatID2.Text.Trim() == "")
                    {
                        MessageBox.Show("\"拨入炉号2\"为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (tbxAddHeatID2.Text.Trim() == tbxHeatid.Text.Trim())
                    {

                        MessageBox.Show("\"拨入炉号2\"不能与\"当前炉号\"相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (tbxAddHeatID2.Text.Trim().Length != 9)
                    {

                        MessageBox.Show("\"拨入炉号2\"输入可能错误，只能输入一个炉号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else if (iDivCount == 0)
            {
                dsHeatData.Tables[0].Rows[0]["ADD_BLOOM_COUNT"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_HEATID1"] = "";
                dsHeatData.Tables[0].Rows[0]["ADD_BLOOM_COUNT2"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_HEATID2"] = "";

                dsHeatData.Tables[0].Rows[0]["DIV_BLOOM_COUNT"] = 0;
                dsHeatData.Tables[0].Rows[0]["ADD_DIV_HEATID"] = "";
            }
            if (MessageBox.Show("确认炉次甩废？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() != "Yes")
                return;

            bsHeatData.EndEdit();
            dsHeatData.Tables[0].Rows[0]["Produce_Date"] = DateTime.Now;
            cmdMakeWaster.Parameters[0].SourceObject = dsHeatData;
            //cmdMakeWaster.Parameters[1].ConstantValue = strHeatID;
            int iRet = cmdMakeWaster.Execute();
            if (iRet != 0 || !Convert.ToBoolean(cmdMakeWaster.Command.Return))
            {
                MessageBox.Show(string.Format("操作失败！错误:{0:X},{1:X}", cmdMakeWaster.Command.ErrorCode, iRet));
            }
            else
            {
                MessageBox.Show("操作成功！", "提示");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        //出坯支数20081227Liao
        private void tbxBloomCount_TextChanged(object sender, EventArgs e)
        {
            //钢坯支数
            string strBloomCount = tbxBloomCount.Text;
            strBloomCount.Trim();
            int iBloomCount = strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount);

            //2009-08-06
            tbxPlanCount.Text = iBloomCount.ToString();
            CalculateBloomCount();
            //甩废总重量
            string strWasterWeight = tbxWasterWeight.Text; strWasterWeight.Trim();
            double dWasterWeight = strWasterWeight.Length < 1 ? 0 : Convert.ToDouble(strWasterWeight);

            //理论重量
            double dBloomWeight = fweight * iBloomCount;
            tbxBloomWeight.Text = Convert.ToString(Math.Round(dBloomWeight, 3));
            //合格钢坯支数
            tbxRightCount.Text = iBloomCount.ToString();
            //合格重量 = 理论重量 + 甩废总重量
            tbxRightWeight.Text = Convert.ToString(Math.Round(dBloomWeight + dWasterWeight, 3));
        }

        //计算重量20081227Liao
        private void CalculateWegint(object sender, EventArgs e)
        {
            try
            {
                PxDataValid.PxTextBox ctrl = (PxDataValid.PxTextBox)sender;
                string strctrlText = ctrl.Text;
                switch (ctrl.Name)
                {
                    case "tbxWasterCount1":
                        //tbxWasterWeight1.Text =( string.Format("{0:F}", fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        tbxWasterWeight1.Text = Convert.ToString(Math.Round(fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToDouble(strctrlText)), 3));
                        break;

                    case "tbxWasterCount2":
                        //tbxWasterWeight2.Text = string.Format("{0:F}", fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        tbxWasterWeight2.Text = Convert.ToString(Math.Round(fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToDouble(strctrlText)), 3));
                        break;

                    case "tbxWasterCount3":
                        //tbxWasterWeight3.Text = string.Format("{0:F}", fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToInt32(strctrlText)));
                        tbxWasterWeight3.Text = Convert.ToString(Math.Round(fWTPerMM * (strctrlText.Length < 1 ? 0 : Convert.ToDouble(strctrlText)), 3));
                        break;
                    default:
                        break;
                }

                string strCnt1 = tbxWasterCount1.Text; strCnt1.Trim();
                string strCnt2 = tbxWasterCount2.Text; strCnt2.Trim();
                string strCnt3 = tbxWasterCount3.Text; strCnt3.Trim();
                //总甩废长度
                double WasterCount = (strCnt1.Length < 1 ? 0 : Convert.ToDouble(strCnt1)) +
                    (strCnt2.Length < 1 ? 0 : Convert.ToDouble(strCnt2)) +
                    (strCnt3.Length < 1 ? 0 : Convert.ToDouble(strCnt3));
                tbxWasterCount.Text = WasterCount.ToString();

                //总甩废重量
                string strWWT1 = tbxWasterWeight1.Text; strWWT1.Trim();
                string strWWT2 = tbxWasterWeight2.Text; strWWT2.Trim();
                string strWWT3 = tbxWasterWeight3.Text; strWWT3.Trim();

                double dWasterWT = (strWWT1.Length < 1 ? 0 : Convert.ToDouble(strWWT1)) +
                    (strWWT2.Length < 1 ? 0 : Convert.ToDouble(strWWT2)) +
                    (strWWT3.Length < 1 ? 0 : Convert.ToDouble(strWWT3));
                tbxWasterWeight.Text = dWasterWT.ToString();

                ////总甩废重量 = 总甩废长度 * 单位重量
                //double dWasterWeight = WasterCount * fWTPerMM;
                //tbxWasterWeight.Text = string.Format("{0:F}", dWasterWeight);

                //理论重量
                double dBloomWeight = (tbxBloomWeight.Text.Length < 1 ? 0 : Convert.ToDouble(tbxBloomWeight.Text.Trim()));

                //合格重量 = 理论重量 + 甩废总重量
                //tbxRightWeight.Text = string.Format("{0:F}", dBloomWeight + dWasterWeight);
                tbxRightWeight.Text = Convert.ToString(Math.Round((dBloomWeight + dWasterWT), 3));

            }
            catch { }
        }

        private void cmbWasteReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cmbWasteReason1))
            {
                if (cmbWasteReason1.Text.Trim() == "")
                {
                    tbxWasterCount1.Text = "0";
                    tbxWasterCount1.ReadOnly = true;
                }
                else
                    tbxWasterCount1.ReadOnly = false;
            }
            if (sender.Equals(cmbWasteReason2))
            {
                if (cmbWasteReason2.Text.Trim() == "")
                {
                    tbxWasterCount2.Text = "0";
                    tbxWasterCount2.ReadOnly = true;
                }
                else
                    tbxWasterCount2.ReadOnly = false;
            }
            if (sender.Equals(cmbWasteReason3))
            {
                if (cmbWasteReason3.Text.Trim() == "")
                {
                    tbxWasterCount3.Text = "0";
                    tbxWasterCount3.ReadOnly = true;
                }
                else
                    tbxWasterCount3.ReadOnly = false;
            }
        }

        //计划钢坯支数2009-08-06Liao
        private void tbxPlanCount_TextChanged(object sender, EventArgs e)
        {
            CalculateBloomCount();
        }

        //拨入拨出钢坯支数2009-08-06Liao 2009-08-21 //2009-08-26Liao
        private void CalculateBloomCount()
        {
            string strBloomCount = tbxBloomCount.Text; strBloomCount.Trim();
            int iBloomCount = strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount);

            string strPlanCount = tbxPlanCount.Text; strPlanCount.Trim();
            int iPlanCount = strPlanCount.Length < 1 ? 0 : Convert.ToInt32(strPlanCount);

            iDivCount = iPlanCount - iBloomCount;
            if (iDivCount > 0)//拨出
            {
                tbxAddCount1.Text = "0";
                tbxAddHeatID1.Text = "";
                tbxAddCount2.Text = "0";
                tbxAddHeatID2.Text = "";
                panelIn.Visible = false;

                panelOut.Visible = true;
                tbxAddDivHeatID.Text = "";
                tbxDivCount.Text = iDivCount.ToString();
            }
            else if (iDivCount < 0)//拨入
            {
                tbxAddDivHeatID.Text = "";
                tbxDivCount.Text = "0";
                panelOut.Visible = false;

                panelIn.Visible = true;
                int iAddCount = -iDivCount;
                tbxAddCount1.Text = iAddCount.ToString();
                tbxAddHeatID1.Text = "";
                tbxAddCount2.Text = "0";
                tbxAddHeatID2.Text = "";
            }
            else
            {
                tbxAddCount1.Text = "0";
                tbxAddHeatID1.Text = "";
                tbxAddCount2.Text = "0";
                tbxAddHeatID2.Text = "";
                panelIn.Visible = false;

                tbxAddDivHeatID.Text = "";
                tbxDivCount.Text = "0";
                panelOut.Visible = false;
            }
        }

        private void tbxAddCount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string strPlanCount = tbxPlanCount.Text; strPlanCount.Trim();
                int iPlanCount = strPlanCount.Length < 1 ? 0 : Convert.ToInt32(strPlanCount);

                string strBloomCount = tbxBloomCount.Text; strBloomCount.Trim();
                int iBloomCount = strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount);

                string strAddCount1 = tbxAddCount1.Text; strAddCount1.Trim();
                iAddCount1 = strAddCount1.Length < 1 ? 0 : Convert.ToInt32(strAddCount1);

                if (iAddCount1 > 0)
                    tbxAddHeatID1.ReadOnly = false;
                else
                {
                    tbxAddHeatID1.ReadOnly = true;
                    tbxAddHeatID1.Text = "";
                }

                iAddCount2 = iBloomCount - iPlanCount - iAddCount1;
                tbxAddCount2.Text = iAddCount2.ToString();
            }
            catch { }
        }

        private void tbxAddCount2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (iAddCount2 > 0)
                {
                    //if()
                    tbxAddHeatID2.ReadOnly = false;
                }
                else
                {
                    tbxAddHeatID2.ReadOnly = true;
                    tbxAddHeatID2.Text = "";
                }
            }
            catch { }
        }
    }
}