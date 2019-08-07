using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QualityMag.QualityJudge
{
    public partial class HotJudgeDefendFrm : Form
    {
        public HotJudgeDefendFrm()
        {
            InitializeComponent(); 
        }

        private double fweight = 0;
        private double fBloomWeight = 0;//缓存出坯总重量【进入界面获取：此重量为连铸甩废后的理论重量 + 甩废重量】
      
        public DialogResult ShowDialogEx(AppSvrIF.Session session,AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsBloomData.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsBloomData.AcceptChanges();
            try
            {
                //获取出坯总重量
                string strBloomWeight = dsBloomData.Tables[0].Rows[0]["Right_Weight"].ToString();
                fBloomWeight = double.Parse(strBloomWeight); //Math.Round(Convert.ToDouble(strBloomWeight), 3);
                
                ////获取理论重量、钢坯支数计算单位重量 2009-06-01
                //string strCalWeight = dsBloomData.Tables[0].Rows[0]["Cal_Weight"].ToString();
                //double dCalWeight = double.Parse(strCalWeight);
                //string strBloomCount = dsBloomData.Tables[0].Rows[0]["Bloom_Count"].ToString();
                //double dBloomCount = double.Parse(strBloomCount);

                //if (dBloomCount > 0.0)
                //    fweight = dCalWeight / dBloomCount;

                fweight = 0;
                //获取理论重量、钢坯支数计算单位重量 2009-06-01
                string strHeatID = dsBloomData.Tables[0].Rows[0]["MaterialID"].ToString();
                if (strHeatID != "")
                {
                    try
                    {
                        object objCalWeight = null;
                        object objBloomCount = null;
                        string strBoolmDataUri = "MES\\MaterialData\\CBloom_Data\\" + strHeatID;

                        Adapter.Session.Get(strBoolmDataUri, "Cal_Weight", ref objCalWeight);
                        double dCalWeight = double.Parse(objCalWeight.ToString());

                        Adapter.Session.Get(strBoolmDataUri, "Bloom_Count", ref objBloomCount);
                        double dBloomCount = double.Parse(objBloomCount.ToString());

                        if (dBloomCount > 0.0)
                            fweight = dCalWeight / dBloomCount;
                    }
                    catch { fweight = 0; }
                }
                
            }
            catch { return DialogResult.None; }
            return ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsBloomData.EndEdit();
            if (Convert.ToInt32(dsBloomData.Tables[0].Rows[0]["Right_Count"].ToString()) < 0)
            {
                MessageBox.Show("合格支数不能小于0！", "提示！",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            int iRet = cmdBloomData.Execute();
            if (iRet >= 0)
            {
                if (Convert.ToInt16(cmdBloomData.Command.Return) > 0)
                {
                    MessageBox.Show("操作成功！","提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("操作失败！", "提示");
                }

            }
        }
        private void CalculateWeight(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is TextBox))
                    return;
                TextBox ctrl = sender as TextBox;

                if (ctrl.Text.Length < 1)
                    return;

                if (ctrl.Tag.ToString().Length < 1)
                    return;

                TextBox txtWeight = null;
                foreach (Control other in ctrl.Parent.Controls)
                {
                    if (!(other is TextBox)) continue;
                    TextBox otherTxt = other as TextBox;
                    if (otherTxt == ctrl) continue;
                    if (otherTxt.Tag != null && ctrl.Tag != null && otherTxt.Tag.ToString() == ctrl.Tag.ToString())
                    {
                        txtWeight = otherTxt;
                        break;
                    }
                }
                //不合格支数
                string strCnt1 = tbxWrongCount1.Text; strCnt1.Trim();
                string strCnt2 = tbxWrongCount2.Text; strCnt2.Trim();
                string strCnt3 = tbxWrongCount3.Text; strCnt3.Trim();
                int WrongCount = (strCnt1.Length < 1 ? 0 : Convert.ToInt32(strCnt1)) +
                    (strCnt2.Length < 1 ? 0 : Convert.ToInt32(strCnt2)) +
                    (strCnt3.Length < 1 ? 0 : Convert.ToInt32(strCnt3));
                //不合格重量
                double WrongWeight = WrongCount * fweight;
                //钢坯支数
                string strBloomCount = tbxBloomCount.Text; strBloomCount.Trim();
                //合格支数=钢坯支数-不合格支数//20081228Liao
                int RightCount = (strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount)) - WrongCount ;
                //合格重量 = 出坯重量 - 不合格重量
                double RightWeight = fBloomWeight - WrongWeight;//RightCount * fweight;
                //
                txtWeight.Text = Convert.ToString(Math.Round(fweight * (ctrl.Text.Length < 1 ? 0 : Convert.ToInt32(ctrl.Text)), 3)); //string.Format("{0:F}", fweight * (ctrl.Text.Length < 1 ? 0 : Convert.ToInt32(ctrl.Text)));
                //tbxBloomWeight.Text = string.Format("{0:F}", fweight * (strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount)));
                tbxRightCount.Text = string.Format("{0:D}", RightCount);
                tbxRightWeight.Text = Convert.ToString(Math.Round(RightWeight, 3)); //string.Format("{0:F}", RightWeight);
                tbxWrongCount.Text = string.Format("{0:D}", WrongCount);
                tbxWrongWeight.Text = Convert.ToString(Math.Round(WrongWeight, 3)); //string.Format("{0:F}", WrongWeight);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "提示！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HotJudgeDefendFrm_Load(object sender, EventArgs e)
        {
            string strObjID = "";
            string Length = "";
            object objTemp = null;
            object objSteelGrade = null;
            string strSteelGradeIndex = ""; 
            
            //2009-06-01屏蔽
            //if (dsBloomData.Tables[0].Rows.Count > 0)
            //{
            //    strSteelGradeIndex = dsBloomData.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            //    Length = dsBloomData.Tables[0].Rows[0]["Length"].ToString();
            //    if (strSteelGradeIndex == "")
            //    {
            //        MessageBox.Show("获取炼钢记号失败！", "提示");
            //        return;
            //    }
            //    if (strSteelGradeIndex.Substring(0, 1) == "J")
            //    {
            //        Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\" + strSteelGradeIndex, "SteelGrade", ref objSteelGrade);
            //        strObjID = Length + objSteelGrade.ToString();
            //        Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + strObjID.ToString(), "Weight", ref objTemp);
            //    }
            //    else
            //    {
            //        Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + Length, "Weight", ref objTemp);
            //    }
            //    string strWeight = objTemp != null ? objTemp.ToString() : "";
            //    if (strWeight.Length > 0)
            //        fweight = double.Parse(strWeight);
            //    else
            //    {
            //        fweight = 0;
            //        MessageBox.Show("获取定尺对应重量标准值失败！", "提示");
            //        this.Close();
            //    }
            //}

            tbxWrongCount1.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxWrongCount2.TextChanged += new EventHandler(pxControls_TextChanged);
            tbxWrongCount3.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void cbWaitCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWaitCheck.Checked)
            {
                tbxWrongCount1.Text = "0";
                tbxWrongCount2.Text = "0";
                tbxWrongCount3.Text = "0";
                tbxWrongCount1.Enabled = false;
                tbxWrongCount2.Enabled = false;
                tbxWrongCount3.Enabled = false;
            }
            else
            {
                tbxWrongCount1.Enabled = true;
                tbxWrongCount2.Enabled = true;
                tbxWrongCount3.Enabled = true;
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}