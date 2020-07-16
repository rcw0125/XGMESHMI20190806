using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class ProcessSchemaFrm : DockContent, IMESForm
    {
        public ProcessSchemaFrm()
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

        public bool autoFresh = false;
        int count = 1;
        private void ProcessSchemaFrm_Load(object sender, EventArgs e)
        {      
            if (Adapter.Session.User.Length == 5)
            {
                autoFresh = true;
            }
            if (autoFresh)
            {
                timer1.Enabled = true;
                button1.Visible = false;
            }
        }

        public DataSet processDs = new DataSet();
        public void GetData()
        {

            try
            {
                //var ds = GetAllProcess();
                var ds = processDs;
                if (ds.Tables["des"].Rows.Count == 2 && ds.Tables["des"] != null && ds != null)
                {
                    txtDeSITAP_No.Text = ds.Tables["des"].Rows[0]["tap_no"].ToString();
                    txtDeSITPC_No.Text = ds.Tables["des"].Rows[0]["tpc_no"].ToString();
                    txtDeSIS.Text = ds.Tables["des"].Rows[0]["s"].ToString();
                    txtDeSIBlowTime.Text = ds.Tables["des"].Rows[0]["blowtime"].ToString();
                    txtDeSIDeSType.Text = Set_DeS_DeSType(ds.Tables["des"].Rows[0]["destype"].ToString());
                    SetDesI_Status(ds.Tables["des"].Rows[0]["status"].ToString());
                    if (ds.Tables["des"].Rows[0]["curarea"].ToString() == "A")
                    {
                        lbDeSICurArea.Text = "1#";
                    }
                    else
                    {
                        lbDeSICurArea.Text = "2#";
                    }

                    txtDeSIIDeSType.Text = Set_DeS_DeSType(ds.Tables["des"].Rows[1]["destype"].ToString());
                    txtDeSIITAP_No.Text = ds.Tables["des"].Rows[1]["tap_no"].ToString();
                    txtDeSIITPC_No.Text = ds.Tables["des"].Rows[1]["tpc_no"].ToString();
                    txtDeSIIS.Text = ds.Tables["des"].Rows[1]["s"].ToString();
                    txtDeSIIBlowTime.Text = ds.Tables["des"].Rows[1]["blowtime"].ToString();
                    SetDesII_Status(ds.Tables["des"].Rows[1]["status"].ToString());
                    if (ds.Tables["des"].Rows[1]["curarea"].ToString() == "A")
                    {
                        lbDeSIICurArea.Text = "3#";
                    }
                    else
                    {
                        lbDeSIICurArea.Text = "4#";
                    }
                }

                if (ds.Tables["mif"].Rows.Count == 3 && ds.Tables["mif"] != null && ds != null)
                {
                    txtBF01Weight.Text = ds.Tables["mif"].Rows[0]["weight"].ToString();
                    txtBF01Temperature.Text = ds.Tables["mif"].Rows[0]["temp"].ToString();
                    txtBF01C.Text = ds.Tables["mif"].Rows[0]["c"].ToString();
                    txtBF01Ti.Text = ds.Tables["mif"].Rows[0]["ti"].ToString();
                    txtBF01Si.Text = ds.Tables["mif"].Rows[0]["si"].ToString();
                    txtBF01Sn.Text = ds.Tables["mif"].Rows[0]["sn"].ToString();
                    txtBF01Mn.Text = ds.Tables["mif"].Rows[0]["mn"].ToString();
                    txtBF01Sb.Text = ds.Tables["mif"].Rows[0]["sb"].ToString();
                    txtBF01Mn.Text = ds.Tables["mif"].Rows[0]["mn"].ToString();
                    txtBF01P.Text = ds.Tables["mif"].Rows[0]["p"].ToString();
                    txtBF01As.Text = ds.Tables["mif"].Rows[0]["as"].ToString();
                    txtBF01S.Text = ds.Tables["mif"].Rows[0]["s"].ToString();
                    txtBF01Pb.Text = ds.Tables["mif"].Rows[0]["pb"].ToString();
                    txtBF01LabTime.Text = ds.Tables["mif"].Rows[0]["temp_time"].ToString();

                    txtBF02Weight.Text = ds.Tables["mif"].Rows[1]["weight"].ToString();
                    txtBF02Temperature.Text = ds.Tables["mif"].Rows[1]["temp"].ToString();
                    txtBF02C.Text = ds.Tables["mif"].Rows[1]["c"].ToString();
                    txtBF02Ti.Text = ds.Tables["mif"].Rows[1]["ti"].ToString();
                    txtBF02Si.Text = ds.Tables["mif"].Rows[1]["si"].ToString();
                    txtBF02Sn.Text = ds.Tables["mif"].Rows[1]["sn"].ToString();
                    txtBF02Mn.Text = ds.Tables["mif"].Rows[1]["mn"].ToString();
                    txtBF02Sb.Text = ds.Tables["mif"].Rows[1]["sb"].ToString();
                    txtBF02Mn.Text = ds.Tables["mif"].Rows[1]["mn"].ToString();
                    txtBF02P.Text = ds.Tables["mif"].Rows[1]["p"].ToString();
                    txtBF02As.Text = ds.Tables["mif"].Rows[1]["as"].ToString();
                    txtBF02S.Text = ds.Tables["mif"].Rows[1]["s"].ToString();
                    txtBF02Pb.Text = ds.Tables["mif"].Rows[1]["pb"].ToString();
                    txtBF02LabTime.Text = ds.Tables["mif"].Rows[1]["temp_time"].ToString();

                    txtBF03Weight.Text = ds.Tables["mif"].Rows[2]["weight"].ToString();
                    txtBF03Temperature.Text = ds.Tables["mif"].Rows[2]["temp"].ToString();
                    txtBF03C.Text = ds.Tables["mif"].Rows[2]["c"].ToString();
                    txtBF03Ti.Text = ds.Tables["mif"].Rows[2]["ti"].ToString();
                    txtBF03Si.Text = ds.Tables["mif"].Rows[2]["si"].ToString();
                    txtBF03Sn.Text = ds.Tables["mif"].Rows[2]["sn"].ToString();
                    txtBF03Mn.Text = ds.Tables["mif"].Rows[2]["mn"].ToString();
                    txtBF03Sb.Text = ds.Tables["mif"].Rows[2]["sb"].ToString();
                    txtBF03Mn.Text = ds.Tables["mif"].Rows[2]["mn"].ToString();
                    txtBF03P.Text = ds.Tables["mif"].Rows[2]["p"].ToString();
                    txtBF03As.Text = ds.Tables["mif"].Rows[2]["as"].ToString();
                    txtBF03S.Text = ds.Tables["mif"].Rows[2]["s"].ToString();
                    txtBF03Pb.Text = ds.Tables["mif"].Rows[2]["pb"].ToString();
                    txtBF03LabTime.Text = ds.Tables["mif"].Rows[2]["temp_time"].ToString();

                }


                if (ds.Tables["bof"].Rows.Count == 3 && ds.Tables["bof"] != null && ds != null)
                {
                    ucBOFStatus2.Status = Convert.ToInt16(ds.Tables["bof"].Rows[0]["status"].ToString());
                    txtBOF02NowHeatID.Text = ds.Tables["bof"].Rows[0]["heatid"].ToString();
                    txtBOF02NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[0]["steelgradeindex"].ToString();
                    txtBOF02NowSteelGrade.Text = ds.Tables["bof"].Rows[0]["bofsteelgrade"].ToString();
                    txtBOF02NowInWeight.Text = ds.Tables["bof"].Rows[0]["load"].ToString();
                    txtBOF02NowBlowTime.Text = ds.Tables["bof"].Rows[0]["startprocesstime"].ToString();
                    txtBOF02AfterHeatID.Text = ds.Tables["bof"].Rows[0]["tapheatid"].ToString();
                    txtBOF02AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[0]["tapsteelgradeindex"].ToString();
                    txtBOF02AfterSteelGrade.Text = ds.Tables["bof"].Rows[0]["tapsteelgrade"].ToString();
                    txtBOF02AfterSteelID.Text = ds.Tables["bof"].Rows[0]["ladleid"].ToString();
                    if (ds.Tables["bof"].Rows[0]["lfid"].ToString() != "0")
                    {
                        txtBOF02AfterOut.Text = ds.Tables["bof"].Rows[0]["lfid"].ToString();
                    }
                    else
                    {
                        txtBOF02AfterOut.Text = ds.Tables["bof"].Rows[0]["casterid"].ToString();
                    }

                    ucBOFStatus3.Status = Convert.ToInt16(ds.Tables["bof"].Rows[1]["status"].ToString());
                    txtBOF03NowHeatID.Text = ds.Tables["bof"].Rows[1]["heatid"].ToString();
                    txtBOF03NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[1]["steelgradeindex"].ToString();
                    txtBOF03NowSteelGrade.Text = ds.Tables["bof"].Rows[1]["bofsteelgrade"].ToString();
                    txtBOF03NowInWeight.Text = ds.Tables["bof"].Rows[1]["load"].ToString();
                    txtBOF03NowBlowTime.Text = ds.Tables["bof"].Rows[1]["startprocesstime"].ToString();
                    txtBOF03AfterHeatID.Text = ds.Tables["bof"].Rows[1]["tapheatid"].ToString();
                    txtBOF03AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[1]["tapsteelgradeindex"].ToString();
                    txtBOF03AfterSteelGrade.Text = ds.Tables["bof"].Rows[1]["tapsteelgrade"].ToString();
                    txtBOF03AfterSteelID.Text = ds.Tables["bof"].Rows[1]["ladleid"].ToString();
                    if (ds.Tables["bof"].Rows[1]["lfid"].ToString() != "0")
                    {
                        txtBOF03AfterOut.Text = ds.Tables["bof"].Rows[1]["lfid"].ToString();
                    }
                    else
                    {
                        txtBOF03AfterOut.Text = ds.Tables["bof"].Rows[1]["casterid"].ToString();
                    }

                    ucBOFStatus4.Status = Convert.ToInt16(ds.Tables["bof"].Rows[2]["status"].ToString());
                    txtBOF04NowHeatID.Text = ds.Tables["bof"].Rows[2]["heatid"].ToString();
                    txtBOF04NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[2]["steelgradeindex"].ToString();
                    txtBOF04NowSteelGrade.Text = ds.Tables["bof"].Rows[2]["bofsteelgrade"].ToString();
                    txtBOF04NowInWeight.Text = ds.Tables["bof"].Rows[2]["load"].ToString();
                    txtBOF04NowBlowTime.Text = ds.Tables["bof"].Rows[2]["startprocesstime"].ToString();
                    txtBOF04AfterHeatID.Text = ds.Tables["bof"].Rows[2]["tapheatid"].ToString();
                    txtBOF04AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[2]["tapsteelgradeindex"].ToString();
                    txtBOF04AfterSteelGrade.Text = ds.Tables["bof"].Rows[2]["tapsteelgrade"].ToString();
                    txtBOF04AfterSteelID.Text = ds.Tables["bof"].Rows[2]["ladleid"].ToString();
                    if (ds.Tables["bof"].Rows[2]["lfid"].ToString() != "0")
                    {
                        txtBOF04AfterOut.Text = ds.Tables["bof"].Rows[2]["lfid"].ToString();
                    }
                    else
                    {
                        txtBOF04AfterOut.Text = ds.Tables["bof"].Rows[2]["casterid"].ToString();
                    }



                }

                if (ds.Tables["lf"].Rows.Count == 5 && ds.Tables["lf"] != null && ds != null)
                {
                    ucLFStatus1.Status = Convert.ToInt16(ds.Tables["lf"].Rows[0]["status"].ToString());
                    txtLF01HeatID.Text = ds.Tables["lf"].Rows[0]["heatid"].ToString();
                    txtLF01SteelGradeIndex.Text = ds.Tables["lf"].Rows[0]["steelgradeindex"].ToString();
                    txtLF01SteelGrade.Text = ds.Tables["lf"].Rows[0]["steelgrade"].ToString();
                    txtLF01SteelID.Text = ds.Tables["lf"].Rows[0]["ladleid"].ToString();
                    txtLF01Weight.Text = ds.Tables["lf"].Rows[0]["weight"].ToString();
                    txtLF01DealTime.Text = ds.Tables["lf"].Rows[0]["startprocesstime"].ToString();
                    txtLF01AfterOut.Text = ds.Tables["lf"].Rows[0]["casterid"].ToString();
                    dbxCurArea01.Text = ds.Tables["lf"].Rows[0]["curarea"].ToString();

                    ucLFStatus2.Status = Convert.ToInt16(ds.Tables["lf"].Rows[1]["status"].ToString());
                    txtLF02HeatID.Text = ds.Tables["lf"].Rows[1]["heatid"].ToString();
                    txtLF02SteelGradeIndex.Text = ds.Tables["lf"].Rows[1]["steelgradeindex"].ToString();
                    txtLF02SteelGrade.Text = ds.Tables["lf"].Rows[1]["steelgrade"].ToString();
                    txtLF02SteelID.Text = ds.Tables["lf"].Rows[1]["ladleid"].ToString();
                    txtLF02Weight.Text = ds.Tables["lf"].Rows[1]["weight"].ToString();
                    txtLF02DealTime.Text = ds.Tables["lf"].Rows[1]["startprocesstime"].ToString();
                    txtLF02AfterOut.Text = ds.Tables["lf"].Rows[1]["casterid"].ToString();
                    dbxCurArea02.Text = ds.Tables["lf"].Rows[1]["curarea"].ToString();

                    ucLFStatus8.Status = Convert.ToInt16(ds.Tables["lf"].Rows[2]["status"].ToString());
                    txtLF03HeatID.Text = ds.Tables["lf"].Rows[2]["heatid"].ToString();
                    txtLF03SteelGradeIndex.Text = ds.Tables["lf"].Rows[2]["steelgradeindex"].ToString();
                    txtLF03SteelGrade.Text = ds.Tables["lf"].Rows[2]["steelgrade"].ToString();
                    txtLF03SteelID.Text = ds.Tables["lf"].Rows[2]["ladleid"].ToString();
                    txtLF03Weight.Text = ds.Tables["lf"].Rows[2]["weight"].ToString();
                    txtLF03DealTime.Text = ds.Tables["lf"].Rows[2]["startprocesstime"].ToString();
                    txtLF03AfterOut.Text = ds.Tables["lf"].Rows[2]["casterid"].ToString();
                    dbxCurArea03.Text = ds.Tables["lf"].Rows[2]["curarea"].ToString();

                    ucLFStatus3.Status = Convert.ToInt16(ds.Tables["lf"].Rows[3]["status"].ToString());
                    txtLF04HeatID.Text = ds.Tables["lf"].Rows[3]["heatid"].ToString();
                    txtLF04SteelGradeIndex.Text = ds.Tables["lf"].Rows[3]["steelgradeindex"].ToString();
                    txtLF04SteelGrade.Text = ds.Tables["lf"].Rows[3]["steelgrade"].ToString();
                    txtLF04SteelID.Text = ds.Tables["lf"].Rows[3]["ladleid"].ToString();
                    txtLF04Weight.Text = ds.Tables["lf"].Rows[3]["weight"].ToString();
                    txtLF04DealTime.Text = ds.Tables["lf"].Rows[3]["startprocesstime"].ToString();
                    txtLF04AfterOut.Text = ds.Tables["lf"].Rows[3]["casterid"].ToString();
                    dbxCurArea06.Text = ds.Tables["lf"].Rows[3]["curarea"].ToString();

                    ucLFStatus7.Status = Convert.ToInt16(ds.Tables["lf"].Rows[4]["status"].ToString());
                    txtLF05HeatID.Text = ds.Tables["lf"].Rows[4]["heatid"].ToString();
                    txtLF05SteelGradeIndex.Text = ds.Tables["lf"].Rows[4]["steelgradeindex"].ToString();
                    txtLF05SteelGrade.Text = ds.Tables["lf"].Rows[4]["steelgrade"].ToString();
                    txtLF05SteelID.Text = ds.Tables["lf"].Rows[4]["ladleid"].ToString();
                    txtLF05Weight.Text = ds.Tables["lf"].Rows[4]["weight"].ToString();
                    txtLF05DealTime.Text = ds.Tables["lf"].Rows[4]["startprocesstime"].ToString();
                    txtLF05AfterOut.Text = ds.Tables["lf"].Rows[4]["casterid"].ToString();
                    dbxCurArea05.Text = ds.Tables["lf"].Rows[4]["curarea"].ToString();



                }

                if (ds.Tables["rh"].Rows.Count == 1 && ds.Tables["rh"] != null && ds != null)
                {
                    ucRHStatus2.Status = Convert.ToInt16(ds.Tables["rh"].Rows[0]["status"].ToString());
                    txtRH01HeatID.Text = ds.Tables["rh"].Rows[0]["heatid"].ToString();
                    l3DataBox182.Text = ds.Tables["rh"].Rows[0]["steelgradeindex"].ToString();
                    l3DataBox201.Text = ds.Tables["rh"].Rows[0]["steelgrade"].ToString();
                    l3DataBox198.Text = ds.Tables["rh"].Rows[0]["ladleid"].ToString();
                    l3DataBox190.Text = ds.Tables["rh"].Rows[0]["weight"].ToString();
                    l3DataBox193.Text = ds.Tables["rh"].Rows[0]["startprocesstime"].ToString();
                    txtRH01AfterOut.Text = "S65";
                    dbxCurArea04.Text = ds.Tables["rh"].Rows[0]["curarea"].ToString();
                }

                if (ds.Tables["ccm"].Rows.Count == 5 && ds.Tables["ccm"] != null && ds != null)
                {
                    ucCCMStatus3.Status = Convert.ToInt16(ds.Tables["ccm"].Rows[0]["status"].ToString());
                    txtArriveTime03.Text = ds.Tables["ccm"].Rows[0]["arrivetime"].ToString();
                    txtHeatID03.Text = ds.Tables["ccm"].Rows[0]["heatid"].ToString();
                    txtSteelGradeIndex03.Text = ds.Tables["ccm"].Rows[0]["steelgradeindex"].ToString();
                    dbxCasting3.Text = ds.Tables["ccm"].Rows[0]["casting_heatnum"].ToString();
                    dbxTundish4.Text = ds.Tables["ccm"].Rows[0]["tundish_heatnum"].ToString();
                    txtWeight03.Text = ds.Tables["ccm"].Rows[0]["remainedweight"].ToString();
                    txtTime03.Text = ds.Tables["ccm"].Rows[0]["startcastingtime"].ToString();
                    txtRemainTime03.Text = ds.Tables["ccm"].Rows[0]["remaincastingtime"].ToString();

                    ucCCMStatus4.Status = Convert.ToInt16(ds.Tables["ccm"].Rows[1]["status"].ToString());
                    txtArriveTime04.Text = ds.Tables["ccm"].Rows[1]["arrivetime"].ToString();
                    txtHeatID04.Text = ds.Tables["ccm"].Rows[1]["heatid"].ToString();
                    txtSteelGradeIndex04.Text = ds.Tables["ccm"].Rows[1]["steelgradeindex"].ToString();
                    dbxCasting4.Text = ds.Tables["ccm"].Rows[1]["casting_heatnum"].ToString();
                    dbxTundish4.Text = ds.Tables["ccm"].Rows[1]["tundish_heatnum"].ToString();
                    txtWeight04.Text = ds.Tables["ccm"].Rows[1]["remainedweight"].ToString();
                    txtTime04.Text = ds.Tables["ccm"].Rows[1]["startcastingtime"].ToString();
                    txtRemainTime04.Text = ds.Tables["ccm"].Rows[1]["remaincastingtime"].ToString();

                    ucCCMStatus5.Status = Convert.ToInt16(ds.Tables["ccm"].Rows[2]["status"].ToString());
                    txtArriveTime05.Text = ds.Tables["ccm"].Rows[2]["arrivetime"].ToString();
                    txtHeatID05.Text = ds.Tables["ccm"].Rows[2]["heatid"].ToString();
                    txtSteelGradeIndex05.Text = ds.Tables["ccm"].Rows[2]["steelgradeindex"].ToString();
                    dbxCasting5.Text = ds.Tables["ccm"].Rows[2]["casting_heatnum"].ToString();
                    dbxTundish5.Text = ds.Tables["ccm"].Rows[2]["tundish_heatnum"].ToString();
                    txtWeight05.Text = ds.Tables["ccm"].Rows[2]["remainedweight"].ToString();
                    txtTime05.Text = ds.Tables["ccm"].Rows[2]["startcastingtime"].ToString();
                    txtRemainTime05.Text = ds.Tables["ccm"].Rows[2]["remaincastingtime"].ToString();

                    ucCCMStatus6.Status = Convert.ToInt16(ds.Tables["ccm"].Rows[3]["status"].ToString());
                    txtArriveTime06.Text = ds.Tables["ccm"].Rows[3]["arrivetime"].ToString();
                    txtHeatID06.Text = ds.Tables["ccm"].Rows[3]["heatid"].ToString();
                    txtSteelGradeIndex06.Text = ds.Tables["ccm"].Rows[3]["steelgradeindex"].ToString();
                    dbxCasting6.Text = ds.Tables["ccm"].Rows[3]["casting_heatnum"].ToString();
                    dbxTundish6.Text = ds.Tables["ccm"].Rows[3]["tundish_heatnum"].ToString();
                    txtWeight06.Text = ds.Tables["ccm"].Rows[3]["remainedweight"].ToString();
                    txtTime06.Text = ds.Tables["ccm"].Rows[3]["startcastingtime"].ToString();
                    txtRemainTime06.Text = ds.Tables["ccm"].Rows[3]["remaincastingtime"].ToString();


                    ucCCMStatus7.Status = Convert.ToInt16(ds.Tables["ccm"].Rows[4]["status"].ToString());
                    txtArriveTime07.Text = ds.Tables["ccm"].Rows[4]["arrivetime"].ToString();
                    txtHeatID07.Text = ds.Tables["ccm"].Rows[4]["heatid"].ToString();
                    txtSteelGradeIndex07.Text = ds.Tables["ccm"].Rows[4]["steelgradeindex"].ToString();
                    dbxCasting7.Text = ds.Tables["ccm"].Rows[4]["casting_heatnum"].ToString();
                    dbxTundish7.Text = ds.Tables["ccm"].Rows[4]["tundish_heatnum"].ToString();
                    txtWeight07.Text = ds.Tables["ccm"].Rows[4]["remainedweight"].ToString();
                    txtTime07.Text = ds.Tables["ccm"].Rows[4]["startcastingtime"].ToString();
                    txtRemainTime07.Text = ds.Tables["ccm"].Rows[4]["remaincastingtime"].ToString();
                }
                label1.Text = count + "-数据更新时间："+DateTime.Now.ToString("HH:mm:ss");
                count++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现异常:" + ex.ToString());
            }

            
        }

        public void SetDesII_Status(string strStatus)
        {
            switch (strStatus)
            {
                case "":
                    lbStatus2.Text = "准备脱硫";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "1":
                    lbStatus2.Text = "准备脱硫";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "2":
                    lbStatus2.Text = "铁罐进站";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "3":
                    lbStatus2.Text = "预捞渣开始";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "4":
                    lbStatus2.Text = "预捞渣结束";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "5":
                    lbStatus2.Text = "喷吹开始";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesBusy;
                    break;
                case "6":
                    lbStatus2.Text = "喷吹结束";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "7":
                    lbStatus2.Text = "捞渣开始";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "8":
                    lbStatus2.Text = "捞渣结束";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "9":
                    lbStatus2.Text = "铁罐出站";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                default:
                    lbStatus2.Text = "准备脱硫";
                    pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
            }
        }
        public void SetDesI_Status(string strStatus)
        {

            switch (strStatus)
            {
                case "":
                    lbStatus1.Text = "准备脱硫";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "1":
                    lbStatus1.Text = "准备脱硫";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "2":
                    lbStatus1.Text = "铁罐进站";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "3":
                    lbStatus1.Text = "预捞渣开始";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "4":
                    lbStatus1.Text = "预捞渣结束";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "5":
                    lbStatus1.Text = "喷吹开始";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesBusy;
                    break;
                case "6":
                    lbStatus1.Text = "喷吹结束";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "7":
                    lbStatus1.Text = "捞渣开始";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "8":
                    lbStatus1.Text = "捞渣结束";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                case "9":
                    lbStatus1.Text = "铁罐出站";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
                default:
                    lbStatus1.Text = "准备脱硫";
                    pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
                    break;
            }
        }

      

        private void ProcessSchemaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

       
        //获取脱硫类型表述
        private string Set_DeS_DeSType(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case 1:
                        strReturnText = "浅脱硫";
                        break;
                    case 2:
                        strReturnText = "标准脱硫";
                        break;
                    case 3:
                        strReturnText = "深脱硫";
                        break;
                    case 4:
                        strReturnText = "超深脱硫";
                        break;
                    case 5:
                        strReturnText = "捞渣";
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            //MessageBox.Show("查询操作完成！");
        }

        public DataSet GetAllProcess()
        {
            StringBuilder sbu = new StringBuilder();
            DataSet ds = new DataSet();
            try
            {
                
                sbu.Length = 0 ;
                sbu.Append(" select a.name,b.curarea,a.tap_no,a.tpc_no,round(a.s,3) as s,a.status,a.blowtime,b.destype ");
                sbu.Append(" from CDeS_Prod_Area a inner join CDeS_Unit_Mag b on a.name=concat(b.name,b.curarea) order by b.name");
                var dsbase = GetData(Adapter, sbu.ToString());
                if (dsbase.Rows.Count > 0  && dsbase != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dsbase.Clone();
                    tbM = dsbase.Copy();
                    tbM.TableName = "des";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "des";
                    ds.Tables.Add(tbM);
                }

                sbu.Length = 0;
                sbu.Append(" select name,weight,temp,c,ti,si,sn,mn,sb,p,\"AS\",s,pb,temp_time from CMIF_Unit_Mag order by name ");
                var dsmif = GetData(Adapter, sbu.ToString());
                if (dsmif.Rows.Count > 0 && dsmif != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dsmif.Clone();
                    tbM = dsmif.Copy();
                    tbM.TableName = "mif";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "mif";
                    ds.Tables.Add(tbM);
                }

                sbu.Length = 0;
                sbu.Append(" select a.heatid,a.steelgradeindex,a.load,a.startprocesstime,a.status, ");
                sbu.Append(" (select b.steelgrade from CQA_STEELGRADEINDEX_R b where a.steelgradeindex=b.steelgradeindex) as bofsteelgrade ");
                sbu.Append(" ,c.steelgradeindex as tapsteelgradeindex,c.heatid as tapheatid,c.ladleid, ");
                sbu.Append(" (select d.steelgrade from CQA_STEELGRADEINDEX_R d where c.steelgradeindex=d.steelgradeindex) as tapsteelgrade,");
                sbu.Append(" e.lfid,e.casterid ");
                sbu.Append("  from cbof_unit_mag a inner join CTap_Unit_Mag c on c.name=concat('S3',a.sequenceno) ");
                sbu.Append("   left join cplan_tapping e on a.heatid=e.heatid ");
                sbu.Append("   where a.name='S22' or a.name='S23' or a.name='S24' order by a.name");
                var dsbof = GetData(Adapter, sbu.ToString());
                if (dsbof.Rows.Count > 0  && dsbof != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dsbof.Clone();
                    tbM = dsbof.Copy();
                    tbM.TableName = "bof";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "bof";
                    ds.Tables.Add(tbM);
                }

                sbu.Length = 0;
                sbu.Append(" select a.name,a.curarea,a.status,b.heatid,b.steelgradeindex,b.ladleid,round(b.weight,2) as weight,a.startprocesstime ,d.rhid,d.casterid, ");
                sbu.Append(" (select c.steelgrade from CQA_STEELGRADEINDEX_R c where c.steelgradeindex=b.steelgradeindex) as steelgrade ");
                sbu.Append(" from clf_unit_mag a left join CLF_Prod_Area b on b.name=concat(a.CODE,a.CURAREA)");
                sbu.Append(" left join cplan_tapping d on b.heatid=d.heatid order by a.name");
                var dslf = GetData(Adapter, sbu.ToString());
                if (dslf.Rows.Count > 0  && dslf != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dslf.Clone();
                    tbM = dslf.Copy();
                    tbM.TableName = "lf";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "lf";
                    ds.Tables.Add(tbM);
                }


                sbu.Length = 0;
                sbu.Append(" select a.name,a.curarea,a.status,b.heatid,b.steelgradeindex,b.ladleid,b.weight,a.startprocesstime , ");
                sbu.Append(" (select c.steelgrade from CQA_STEELGRADEINDEX_R c where c.steelgradeindex=b.steelgradeindex) as steelgrade ");
                sbu.Append(" from crh_unit_mag a left join Crh_Prod_Area b on b.name=concat(a.CODE,a.CURAREA) ");
                var dsrh = GetData(Adapter, sbu.ToString());
                if (dsrh.Rows.Count > 0  && dsrh != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dsrh.Clone();
                    tbM = dsrh.Copy();
                    tbM.TableName = "rh";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "rh";
                    ds.Tables.Add(tbM);
                }

                sbu.Length = 0;              
                sbu.Append(" select a.name,a.arrivetime,a.heatid,a.status,a.steelgradeindex,a.remainedweight,a.remaincastingtime, ");
                sbu.Append(" a.startcastingtime,b.casting_heatnum,b.tundish_heatnum ");
                sbu.Append(" from cccm_unit_mag a left join cccm_process_data b on a.heatid=b.heatid");
                sbu.Append(" where a.name<>'S61' and a.name<>'S62' order by a.name");
                var dsccm = GetData(Adapter,sbu.ToString());
                if (dsccm.Rows.Count > 0 && dsccm != null)
                {
                    DataTable tbM = new DataTable();
                    tbM = dsccm.Clone();
                    tbM = dsccm.Copy();
                    tbM.TableName = "ccm";
                    ds.Tables.Add(tbM);
                }
                else
                {
                    DataTable tbM = new DataTable();
                    tbM.TableName = "ccm";
                    ds.Tables.Add(tbM);
                }
            }
            catch
            {
                return ds;
            }
            return ds;

        }

        public static DataTable GetData(AppSvrHMI.L3Adapter adapter, string strSql)
        {
            if (adapter.Session == null || !adapter.Session.Opened)
            {
                MessageBox.Show("adapter连接没有打开，请重新登陆");
                return null;
            }

            adapter.RefreshDataBindings();
            AppSvrIF.Command cmdSQl = new AppSvrIF.Command();
            int iRet = adapter.Session.CreateCommand((int)AppSvrIF.CommandType.QueryBySQL, strSql, "", ref cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show("创建查询命令失败，请重新登陆");
                return null;
            }
            iRet = adapter.Session.Execute(cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show("服务执行出现错误，请重新登陆");
                return null;
            }
            if (!(cmdSQl.Return is AppSvrIF.Recordset))
            {
                MessageBox.Show("返回结果错误，请重新登陆");
                return null;
            }
            AppSvrIF.Recordset rs = cmdSQl.Return as AppSvrIF.Recordset;
            if (rs.Tables[0].Rows.Count < 1)
            {
                return null;
            }
            else
            {
                return rs.Tables[0];
            }

        }

        private void ProcessSchemaFrm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                timer1.Enabled = false;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                if (autoFresh)
                {
                    timer1.Enabled = true;               
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 600)
            {
                this.Close();
                return;
            }
            try
            {
                //后台工作开始进行
                backgroundWorker1.RunWorkerAsync();
            }
            catch
            {
               
            }
            
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            processDs.Tables.Clear();
            processDs = GetAllProcess();
           
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                GetData();
            }
            catch
            {
                this.Close();
                return;
            }
            
        }
    }
}