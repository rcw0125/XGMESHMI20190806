using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace NCTelDataMag
{
    public partial class ChangeSteel : DockContent, IMESForm
    {
        public ChangeSteel()
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


        double fweight = 0;//定尺重量
        double fWTPerMM = 0;//每米重量

        

        private void button1_Click(object sender, EventArgs e)
        {
             //double fweight = 0;//定尺重量
             //double fWTPerMM = 0;//每米重量

            string preHeatId = textBox1.Text.Trim();
            string sql = "select PreHeatID,Plan_Ord_ID,Pre_SteelGradeIndex,Pre_SteelGrade,LENGTH,WIDTH,THICKNESS from cplan_casting where preheatid = '" + preHeatId + "'";//在这儿写sql语句 
            string sql1 = "select PREHEATID,HEATID,PRE_STEELGRADEINDEX,PRE_STEELGRADE,STEELGRADEINDEX,PLAN_ORD_ID,LENGTH,WIDTH,THICKNESS from cplan_tapping where preheatid = '" + preHeatId + "'";
            string sql2 = "select HEATID,PREHEATID,STEELGRADE,STEELGRADEINDEX,PRE_STEELGRADEINDEX,PLAN_STEELGRADE,LENGTH,WIDTH,THICKNESS from cccm_base_data where preheatid = '" + preHeatId + "'";
            dsCasting.SourceMethod = sql;
            dsTapping.SourceMethod = sql1;
            if (textBox1.Text != "")
            {
                heatIdtextBox.Text = dsTapping.Tables[0].Rows[0]["HeatID"].ToString();
            }
            else
            {
                MessageBox.Show("预定炉号不能为空！");
            }

////
              //string strObjID = "";
              //object objTemp = null;
              //object objSteelGrade = null;
              //string strSteelGradeIndex = dsTapping.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
              //int iLength = 0;
              //iLength = Convert.ToInt32(dsTapping.Tables[0].Rows[0]["Length"].ToString());
              ////if (strSteelGradeIndex == "")
              ////{
              ////    MessageBox.Show("获取炼钢记号失败！", "提示");
              ////    return;
              ////}
              //if ((strSteelGradeIndex.Substring(0, 1) == "J") || (strSteelGradeIndex.Substring(0, 1) == "B"))
              //{
              //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\" + strSteelGradeIndex, "SteelGrade", ref objSteelGrade);
              //    strObjID = iLength.ToString() + objSteelGrade.ToString();
              //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + strObjID.ToString(), "Weight", ref objTemp);
              //}
              //else
              //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + iLength.ToString(), "Weight", ref objTemp);

              //string strWeight = objTemp != null ? objTemp.ToString() : "";
              //if (strWeight.Length > 0)
              //{
              //    fweight = double.Parse(strWeight);
              //    fWTPerMM = (fweight / iLength) * 1000;//20081228Liao
              //}
              //else
              //{
              //    fWTPerMM = 0;
              //    MessageBox.Show("获取定尺对应重量标准值失败！", "提示");
              //    this.Close();
              //}

              //WeightChanged();
              //pxControls_TextChanged(calWeighttextBox, e);
           
////
            dsCcm.SourceMethod = sql2;
            string sql3 = "select PRE_STEELGRADEINDEX,STEELGRADEINDEX,CUT_STEELGRADEINDEX,FINAL_STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,PLAN_ORD_ID,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT,PLAN_BLOOM_COUNT from cbloom_data where heatid = '" + heatIdtextBox.Text + "'";
            string sql4 = "select HEATID,STEELGRADEINDEX,CUT_STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,BLOOM_COUNT,to_number(CAL_WEIGHT) as CAL_WEIGHT from CQA_Bloom_Waster_Data where heatid = '" + heatIdtextBox.Text + "'";
            string sql5 = "select STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT from CQA_Bloom_HotJudge_Data where heatid = '" + heatIdtextBox.Text + "'";
            string sql6 = "select Pre_SteelGradeIndex,SteelGradeIndex,Cut_SteelGradeIndex,Final_SteelGradeIndex,LENGTH,WIDTH,THICKNESS,BLOOM_COUNT,CAL_WEIGHT,RIGHT_COUNT,RIGHT_WEIGHT from CQA_Bloom_FinJudge_Data where heatid = '" + heatIdtextBox.Text + "'";
            string sql7 = "select BLOOM_COUNT,to_number(CAL_WEIGHT) as CAL_WEIGHT,RIGHT_COUNT,to_number(RIGHT_WEIGHT) as RIGHT_WEIGHT ,STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS from cbloom_input_log where materialid = '" + heatIdtextBox.Text + "'";
            string sql8 = "select BLOOM_COUNT,to_number(CAL_WEIGHT) as CAL_WEIGHT,RIGHT_COUNT,to_number(RIGHT_WEIGHT) as RIGHT_WEIGHT,STEELGRADEINDEX,LENGTH,WIDTH,THICKNESS from cbloom_output_log where materialid = '" + heatIdtextBox.Text + "'";
            dsBloomData.SourceMethod = sql3;
            dsWasterData.SourceMethod = sql4;
            dsHotjudge.SourceMethod = sql5;
            dsFinjudge.SourceMethod = sql6;
            dsBloomInput.SourceMethod = sql7;
            dsBloomOutput.SourceMethod = sql8;
            Adapter.RefreshDataBindings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "Update CPlan_Casting set Plan_Ord_ID ='" + planOrdIDtextBox.Text + "', Pre_SteelGradeIndex='" + steelGradeIndextextBox.Text + "', Pre_SteelGrade='" + steelGradetextBox.Text + "', Length='" + lengthBox.Text + "'  where PreHeatID='" + textBox1.Text + "'";
            string sql1 = "Update CPlan_Tapping set Plan_Ord_ID ='" + planOrdIDtextBox.Text + "', Pre_SteelGradeIndex='" + steelGradeIndextextBox.Text + "', Pre_SteelGrade='" + steelGradetextBox.Text + "' , SteelGradeIndex ='" + steelGradeIndextextBox.Text + "' , Length='" + lengthBox.Text + "' where PreHeatID='" + textBox1.Text + "'";
            string sql2 = "Update CCCM_Base_Data set SteelGrade ='" + steelGradetextBox.Text + "', Pre_SteelGradeIndex='" + steelGradeIndextextBox.Text + "',SteelGradeIndex ='" + steelGradeIndextextBox.Text + "',plan_SteelGrade ='" + steelGradetextBox.Text + "' , Length='" + lengthBox.Text + "' where HeatID='" + heatIdtextBox.Text + "'";
            string sql3 = "Update CBloom_Data set Plan_Ord_ID ='" + planOrdIDtextBox.Text + "', Pre_SteelGradeIndex='" + steelGradeIndextextBox.Text + "',SteelGradeIndex ='" + steelGradeIndextextBox.Text + "' ,Cut_SteelGradeIndex ='" + steelGradeIndextextBox.Text + "',final_steelgradeindex='" + steelGradeIndextextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "',RIGHT_COUNT='" + bloomCounttextBox.Text + "',RIGHT_WEIGHT='" + calWeighttextBox.Text + "',PLAN_BLOOM_COUNT='" + bloomCounttextBox.Text + "' , Length='" + lengthBox.Text + "'  where HeatID='" + heatIdtextBox.Text + "'";
            string sql4 = "Update CQA_Bloom_Waster_Data set SteelGradeIndex ='" + steelGradeIndextextBox.Text + "',Cut_SteelGradeIndex ='" + steelGradeIndextextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "' , Length='" + lengthBox.Text + "'  where HeatID='" + heatIdtextBox.Text + "'";
            string sql5 = "Update CQA_Bloom_HotJudge_Data set SteelGradeIndex='" + steelGradeIndextextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "',RIGHT_COUNT='" + bloomCounttextBox.Text + "',RIGHT_WEIGHT='" + calWeighttextBox.Text + "' , Length='" + lengthBox.Text + "'  where HeatID='" + heatIdtextBox.Text + "'";
            string sql6 = "Update CQA_BLOOM_FINJUDGE_DATA  set Pre_SteelGradeIndex='" + steelGradeIndextextBox.Text + "',SteelGradeIndex='" + steelGradeIndextextBox.Text + "', Cut_SteelGradeIndex ='" + steelGradeIndextextBox.Text + "',Final_SteelGradeIndex='" + steelGradeIndextextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "',RIGHT_COUNT='" + bloomCounttextBox.Text + "' ,RIGHT_WEIGHT='" + calWeighttextBox.Text + "'  , Length='" + lengthBox.Text + "' where HeatID='" + heatIdtextBox.Text + "'";
            string sql7 = "Update CBLOOM_INPUT_LOG set SteelGradeIndex='" + steelGradeIndextextBox.Text + "',RIGHT_COUNT='" + bloomCounttextBox.Text + "',RIGHT_WEIGHT='" + calWeighttextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "'  , Length='" + lengthBox.Text + "' where materialID='" + heatIdtextBox.Text + "'";
            string sql8 = "Update CBLOOM_OUTPUT_LOG set SteelGradeIndex='" + steelGradeIndextextBox.Text + "',RIGHT_COUNT='" + bloomCounttextBox.Text + "',RIGHT_WEIGHT='" + calWeighttextBox.Text + "',BLOOM_COUNT='" + bloomCounttextBox.Text + "',CAL_WEIGHT='" + calWeighttextBox.Text + "' , Length='" + lengthBox.Text + "'  where materialID='" + heatIdtextBox.Text + "'";
            string sql9 = "Update CBOF_BASE_DATA set SteelGradeIndex ='" + steelGradeIndextextBox.Text + "' ,SteelGrade ='" + steelGradetextBox.Text + "' where HeatID='" + heatIdtextBox.Text + "'";
            string sql10 = "Update CLF_BASE_DATA set SteelGradeIndex ='" + steelGradeIndextextBox.Text + "' ,SteelGrade ='" + steelGradetextBox.Text + "' where HeatID='" + heatIdtextBox.Text + "'";
            string sql11 = "Update CRH_BASE_DATA set SteelGradeIndex ='" + steelGradeIndextextBox.Text + "' ,SteelGrade ='" + steelGradetextBox.Text + "' where HeatID='" + heatIdtextBox.Text + "'";
            dsCasting.SourceMethod = sql;
            dsTapping.SourceMethod = sql1;
            dsCcm.SourceMethod = sql2;
            dsBloomData.SourceMethod = sql3;
            dsWasterData.SourceMethod = sql4;
            dsHotjudge.SourceMethod = sql5;
            dsFinjudge.SourceMethod = sql6;
            dsBloomInput.SourceMethod = sql7;
            dsBloomOutput.SourceMethod = sql8;
            Adapter.RefreshDataBindings();
            button1_Click(null,null);

        }
        //出坯支数20081227Liao
        private void bloomCounttextBox_TextChanged(object sender, EventArgs e)
        {
            //钢坯支数
            string strBloomCount = bloomCounttextBox.Text;
            strBloomCount.Trim();
            int iBloomCount = strBloomCount.Length < 1 ? 0 : Convert.ToInt32(strBloomCount);

            //2009-08-06
            //tbxPlanCount.Text = iBloomCount.ToString();
            //CalculateBloomCount();
            ////甩废总重量
            //string strWasterWeight = tbxWasterWeight.Text; strWasterWeight.Trim();
            //double dWasterWeight = strWasterWeight.Length < 1 ? 0 : Convert.ToDouble(strWasterWeight);

            //理论重量
            double dBloomWeight = fweight * iBloomCount;
            calWeighttextBox.Text = Convert.ToString(Math.Round(dBloomWeight, 3));
            
        }

        private void steelGradetextBox_TextChanged(object sender, EventArgs e)
        {
            //WeightChanged();
        }

        private void ChangeSteel_Load()
        {
            //string strObjID = "";
            //object objTemp = null;
            //object objSteelGrade = null;
            ////string strSteelGradeIndex = dsTapping.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            //int iLength = 0;
            ////iLength = Convert.ToInt32(dsTapping.Tables[0].Rows[0]["Length"].ToString());
            ////if (strSteelGradeIndex == "")
            ////{
            ////    MessageBox.Show("获取炼钢记号失败！", "提示");
            ////    return;
            ////}
            //if ((strSteelGradeIndex.Substring(0, 1) == "J") || (strSteelGradeIndex.Substring(0, 1) == "B"))
            //{
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\" + strSteelGradeIndex, "SteelGrade", ref objSteelGrade);
            //    strObjID = iLength.ToString() + objSteelGrade.ToString();
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + strObjID.ToString(), "Weight", ref objTemp);
            //}
            //else
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + iLength.ToString(), "Weight", ref objTemp);

            //string strWeight = objTemp != null ? objTemp.ToString() : "";
            //if (strWeight.Length > 0)
            //{
            //    fweight = double.Parse(strWeight);
            //    fWTPerMM = (fweight / iLength) * 1000;//20081228Liao
            //}
            //else
            //{
            //    fWTPerMM = 0;
            //    MessageBox.Show("获取定尺对应重量标准值失败！", "提示");
            //    this.Close();
            //}
        }
        private void WeightChanged()
        {
            string steelIndex = steelGradeIndextextBox.Text.Trim();

            string sql = "select STEELGRADE,LENGTH from CPLAN_ORDER where steelgrade=(SELECT steelgrade FROM CQA_SteelGradeIndex_R where STEELGRADEINDEX='" + steelIndex + "')";//在这儿写sql语句 
            //string sql1 = "select PREHEATID,HEATID,PRE_STEELGRADEINDEX,PRE_STEELGRADE,STEELGRADEINDEX,PLAN_ORD_ID,LENGTH,WIDTH,THICKNESS from cplan_tapping where preheatid = '" + preHeatId + "'";
            //string sql2 = "select HEATID,PREHEATID,STEELGRADE,STEELGRADEINDEX,PRE_STEELGRADEINDEX,PLAN_STEELGRADE,LENGTH,WIDTH,THICKNESS from cccm_base_data where preheatid = '" + preHeatId + "'";
            dsCalWeight.SourceMethod = sql;
            //if (textBox1.Text != "")
            //{
            //    heatIdtextBox.Text = dsTapping.Tables[0].Rows[0]["HeatID"].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("预定炉号不能为空！");
            //}
            string strObjID = "";
            object objTemp = null;
            object objSteelGrade = null;
            string strSteelGradeIndex = steelIndex ;
            int iLength = 0;
            if (dsCalWeight.Tables[0].Rows.Count != 0 && Convert.ToInt32(dsCalWeight.Tables[0].Rows[0]["Length"].ToString()) !=0)
            {
                iLength = Convert.ToInt32(dsCalWeight.Tables[0].Rows[0]["Length"].ToString());
            }
            else {MessageBox.Show("计划订单中无该炼钢记号，获取炼钢记号失败！", "提示");
               return; }
            //if (strSteelGradeIndex == "")
            //{
            //    MessageBox.Show("获取炼钢记号失败！", "提示");
            //    return;
            //}
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
                MessageBox.Show("铸坯重量长度关系维护表中，没有"+strObjID+"主键，获取定尺对应重量标准值失败，请与生产科联系！, 提示");
                
            }
         }

        private void steelGradeIndextextBox_TextChanged(object sender, EventArgs e)
        {
            WeightChanged();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string sql = "Update BOFL2_Model_Data set Heatid ='" + textBox3.Text + "'  where Name='" + textBox3.Text + "'";
            string sql = "delete BOFL2_Model_Data  where Name='" + textBox3.Text + "'";
           
            dsModel.SourceMethod = sql;
            Adapter.RefreshDataBindings();
       
        }

    }
}