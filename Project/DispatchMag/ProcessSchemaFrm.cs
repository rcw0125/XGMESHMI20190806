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

        private void ProcessSchemaFrm_Load(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show("出现异常:" + ex.ToString());
            }
           
        }

        public void GetData()
        {
            MESWS.WSMES mes = new MESWS.WSMES();
            var ds = mes.GetAllProcess();
            if (ds.Tables["des"].Rows.Count == 2&&ds.Tables["des"]!=null&& ds != null)
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

            if (ds.Tables["mif"].Rows.Count == 3 && ds.Tables["mif"] != null&&ds!=null)
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


            if (ds.Tables["bof"].Rows.Count == 4 && ds.Tables["bof"] != null && ds != null)
            {
                ucBOFStatus1.Status = Convert.ToInt16(ds.Tables["bof"].Rows[0]["status"].ToString());
                txtBOF01NowHeatID.Text = ds.Tables["bof"].Rows[0]["heatid"].ToString();
                txtBOF01NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[0]["steelgradeindex"].ToString();
                txtBOF01NowSteelGrade.Text = ds.Tables["bof"].Rows[0]["bofsteelgrade"].ToString();
                txtBOF01NowInWeight.Text = ds.Tables["bof"].Rows[0]["load"].ToString();
                txtBOF01NowBlowTime.Text = ds.Tables["bof"].Rows[0]["startprocesstime"].ToString();
                txtBOF01AfterHeatID.Text = ds.Tables["bof"].Rows[0]["tapheatid"].ToString();
                txtBOF01AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[0]["tapsteelgradeindex"].ToString();
                txtBOF01AfterSteelGrade.Text = ds.Tables["bof"].Rows[0]["tapsteelgrade"].ToString();
                txtBOF01AfterSteelID.Text = ds.Tables["bof"].Rows[0]["ladleid"].ToString();
                if (ds.Tables["bof"].Rows[0]["lfid"].ToString() != "0")
                {
                    txtBOF01AfterOut.Text = ds.Tables["bof"].Rows[0]["lfid"].ToString();
                }
                else
                {
                    txtBOF01AfterOut.Text = ds.Tables["bof"].Rows[0]["casterid"].ToString();
                }

                ucBOFStatus2.Status = Convert.ToInt16(ds.Tables["bof"].Rows[1]["status"].ToString());
                txtBOF02NowHeatID.Text = ds.Tables["bof"].Rows[1]["heatid"].ToString();
                txtBOF02NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[1]["steelgradeindex"].ToString();
                txtBOF02NowSteelGrade.Text = ds.Tables["bof"].Rows[1]["bofsteelgrade"].ToString();
                txtBOF02NowInWeight.Text = ds.Tables["bof"].Rows[1]["load"].ToString();
                txtBOF02NowBlowTime.Text = ds.Tables["bof"].Rows[1]["startprocesstime"].ToString();
                txtBOF02AfterHeatID.Text = ds.Tables["bof"].Rows[1]["tapheatid"].ToString();
                txtBOF02AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[1]["tapsteelgradeindex"].ToString();
                txtBOF02AfterSteelGrade.Text = ds.Tables["bof"].Rows[1]["tapsteelgrade"].ToString();
                txtBOF02AfterSteelID.Text = ds.Tables["bof"].Rows[1]["ladleid"].ToString();
                if (ds.Tables["bof"].Rows[1]["lfid"].ToString() != "0")
                {
                    txtBOF02AfterOut.Text = ds.Tables["bof"].Rows[1]["lfid"].ToString();
                }
                else
                {
                    txtBOF02AfterOut.Text = ds.Tables["bof"].Rows[1]["casterid"].ToString();
                }

                ucBOFStatus3.Status = Convert.ToInt16(ds.Tables["bof"].Rows[2]["status"].ToString());
                txtBOF03NowHeatID.Text = ds.Tables["bof"].Rows[2]["heatid"].ToString();
                txtBOF03NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[2]["steelgradeindex"].ToString();
                txtBOF03NowSteelGrade.Text = ds.Tables["bof"].Rows[2]["bofsteelgrade"].ToString();
                txtBOF03NowInWeight.Text = ds.Tables["bof"].Rows[2]["load"].ToString();
                txtBOF03NowBlowTime.Text = ds.Tables["bof"].Rows[2]["startprocesstime"].ToString();
                txtBOF03AfterHeatID.Text = ds.Tables["bof"].Rows[2]["tapheatid"].ToString();
                txtBOF03AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[2]["tapsteelgradeindex"].ToString();
                txtBOF03AfterSteelGrade.Text = ds.Tables["bof"].Rows[2]["tapsteelgrade"].ToString();
                txtBOF03AfterSteelID.Text = ds.Tables["bof"].Rows[2]["ladleid"].ToString();
                if (ds.Tables["bof"].Rows[2]["lfid"].ToString() != "0")
                {
                    txtBOF03AfterOut.Text = ds.Tables["bof"].Rows[2]["lfid"].ToString();
                }
                else
                {
                    txtBOF03AfterOut.Text = ds.Tables["bof"].Rows[2]["casterid"].ToString();
                }

                ucBOFStatus4.Status = Convert.ToInt16(ds.Tables["bof"].Rows[3]["status"].ToString());
                txtBOF04NowHeatID.Text = ds.Tables["bof"].Rows[3]["heatid"].ToString();
                txtBOF04NowSteelGradeIndex.Text = ds.Tables["bof"].Rows[3]["steelgradeindex"].ToString();
                txtBOF04NowSteelGrade.Text = ds.Tables["bof"].Rows[3]["bofsteelgrade"].ToString();
                txtBOF04NowInWeight.Text = ds.Tables["bof"].Rows[3]["load"].ToString();
                txtBOF04NowBlowTime.Text = ds.Tables["bof"].Rows[3]["startprocesstime"].ToString();
                txtBOF04AfterHeatID.Text = ds.Tables["bof"].Rows[3]["tapheatid"].ToString();
                txtBOF04AfterSteelGradeIndex.Text = ds.Tables["bof"].Rows[3]["tapsteelgradeindex"].ToString();
                txtBOF04AfterSteelGrade.Text = ds.Tables["bof"].Rows[3]["tapsteelgrade"].ToString();
                txtBOF04AfterSteelID.Text = ds.Tables["bof"].Rows[3]["ladleid"].ToString();
                if (ds.Tables["bof"].Rows[3]["lfid"].ToString() != "0")
                {
                    txtBOF04AfterOut.Text = ds.Tables["bof"].Rows[3]["lfid"].ToString();
                }
                else
                {
                    txtBOF04AfterOut.Text = ds.Tables["bof"].Rows[3]["casterid"].ToString();
                }



            }

            if (ds.Tables["lf"].Rows.Count == 5 && ds.Tables["lf"] != null && ds != null)
            {
                ucLFStatus1.Status=Convert.ToInt16( ds.Tables["lf"].Rows[0]["status"].ToString());
                txtLF01HeatID.Text = ds.Tables["lf"].Rows[0]["heatid"].ToString();
                txtLF01SteelGradeIndex.Text = ds.Tables["lf"].Rows[0]["steelgradeindex"].ToString();
                txtLF01SteelGrade.Text = ds.Tables["lf"].Rows[0]["steelgrade"].ToString();
                txtLF01SteelID.Text = ds.Tables["lf"].Rows[0]["ladleid"].ToString();
                txtLF01Weight.Text = ds.Tables["lf"].Rows[0]["weight"].ToString();
                txtLF01DealTime.Text = ds.Tables["lf"].Rows[0]["startprocesstime"].ToString();
                txtLF01AfterOut.Text = ds.Tables["lf"].Rows[0]["casterid"].ToString();
                dbxCurArea01.Text= ds.Tables["lf"].Rows[0]["curarea"].ToString();

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

            if (ds.Tables["rh"].Rows.Count == 5 && ds.Tables["rh"] != null && ds != null)
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

        //1#LF工位预约
        private void dbxCurArea01_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea01.Text != "A") && (dbxCurArea01.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name01");
            //Adapter.set_URIParameters("Name01", "S41" + dbxCurArea01.Text);
            //Adapter.RefreshDataBindings();
        }

        //2#LF工位预约
        private void dbxCurArea02_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea02.Text != "A") && (dbxCurArea02.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name02");
            //Adapter.set_URIParameters("Name02", "S42" + dbxCurArea02.Text);
            //Adapter.RefreshDataBindings();
        }
        //3#LF工位预约
        private void dbxCurArea03_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea03.Text != "A") && (dbxCurArea03.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name03");
            //Adapter.set_URIParameters("Name03", "S43" + dbxCurArea03.Text);
            //Adapter.RefreshDataBindings();
        }
        //1#RH工位预约
        private void dbxCurArea04_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea04.Text != "A") && (dbxCurArea04.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name04");
            //Adapter.set_URIParameters("Name04", "S51" + dbxCurArea04.Text);
            //Adapter.RefreshDataBindings();
        }

        //Modify By HuYunHai    BEGIN 2011-02-15 (新建5#LF炉)
        //5#LF工位预约
        private void dbxCurArea05_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea05.Text != "A") && (dbxCurArea05.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name45");
            //Adapter.set_URIParameters("Name45", "S45" + dbxCurArea05.Text);
            //Adapter.RefreshDataBindings();

        }
        //Modify By HuYunHai END   2011-02-15

        //add by hyh 2012-05-10
        //4#LF
        private void dbxCurArea06_TextChanged(object sender, EventArgs e)
        {
            //if ((dbxCurArea06.Text != "A") && (dbxCurArea06.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name07");
            //Adapter.set_URIParameters("Name07", "S44" + dbxCurArea06.Text);
            //Adapter.RefreshDataBindings();
        }
        //end

        //I部脱硫A、B工位预约
        private void txtDeSICurArea_TextChanged(object sender, EventArgs e)
        {
            //if ((txtDeSICurArea.Text != "A") && (txtDeSICurArea.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name05");
            //Adapter.set_URIParameters("Name05", "S02" + txtDeSICurArea.Text);
            //Adapter.RefreshDataBindings();

            //if (txtDeSICurArea.Text == "A")
            //{
            //    lbDeSICurArea.Text = "1#";
            //    dbxDeSStatus1.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S02A";
            //    dbxDeSStatus1.DataProperty = "Status";
            //}
            //else if (txtDeSICurArea.Text == "B")
            //{
            //    lbDeSICurArea.Text = "2#";
            //    dbxDeSStatus1.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S02B";
            //    dbxDeSStatus1.DataProperty = "Status";
            //}
            //else
            //    return;
        }

        //II脱硫A、B工位预约
        private void txtDeSIICurArea_TextChanged(object sender, EventArgs e)
        {
            //if ((txtDeSIICurArea.Text != "A") && (txtDeSIICurArea.Text != "B"))
            //{
            //    return;
            //}
            //Adapter.DeleteURIParameter("Name06");
            //Adapter.set_URIParameters("Name06", "S03" + txtDeSIICurArea.Text);
            //Adapter.RefreshDataBindings();

            //if (txtDeSIICurArea.Text == "A")
            //{
            //    lbDeSIICurArea.Text = "3#";
            //    dbxDeSStatus2.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S03A";
            //    dbxDeSStatus2.DataProperty = "Status";
            //}
            //else if (txtDeSIICurArea.Text == "B")
            //{
            //    lbDeSIICurArea.Text = "4#";
            //    dbxDeSStatus2.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S03B";
            //    dbxDeSStatus2.DataProperty = "Status";
            //}
            //else
            //    return;
        }

        //获取工艺去向
        private void ucStatus_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus)
        {
            //string strS = "S";
            //char[] charS = strS.ToCharArray();
            //string strUnitID = UnitURI.Substring(UnitURI.LastIndexOfAny(charS), 3);
            //string strHeatID = "";
            //string strReturn = "";
            //switch (strUnitID)
            //{
            //    case "S21":
            //        strHeatID = txtBOF01AfterHeatID.Text;
            //        break;
            //    case "S22":
            //        strHeatID = txtBOF02AfterHeatID.Text;
            //        break;
            //    case "S23":
            //        strHeatID = txtBOF03AfterHeatID.Text;
            //        break;
            //    case "S24":
            //        strHeatID = txtBOF04AfterHeatID.Text;
            //        break;
            //    case "S41":
            //        strHeatID = txtLF01HeatID.Text;
            //        break;
            //    case "S42":
            //        strHeatID = txtLF02HeatID.Text;
            //        break;
            //    case "S43":
            //        strHeatID = txtLF03HeatID.Text;
            //        break;
            //    case "S51":
            //        strHeatID = txtRH01HeatID.Text;
            //        break;

            //    //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
            //    case "S45":
            //        strHeatID = txtLF05HeatID.Text;
            //        break;
            //    //Modify By HuYunHai END 2011-02-15 

            //        //add by hyh 2012-05-10
            //    case "S44":
            //        strHeatID = txtLF04HeatID.Text;
            //        break;
            //        //end
            //    default:
            //        break;
            //}
            //if (strHeatID == "")
            //{
            //    switch (strUnitID)
            //    {
            //        case "S21":
            //            txtBOF01AfterOut.Text = "";
            //            break;
            //        case "S22":
            //            txtBOF02AfterOut.Text = "";
            //            break;
            //        case "S23":
            //            txtBOF03AfterOut.Text = "";
            //            break;
            //        case "S24":
            //            txtBOF04AfterOut.Text = "";
            //            break;
            //        case "S41":
            //            txtLF01AfterOut.Text = "";
            //            break;
            //        case "S42":
            //            txtLF02AfterOut.Text = "";
            //            break;
            //        case "S43":
            //            txtLF03AfterOut.Text = "";
            //            break;
            //        case "S51":
            //            txtRH01AfterOut.Text = "";
            //            break;
            //        //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
            //        case "S45":
            //            txtLF05AfterOut.Text = "";
            //            break;
            //        //Modify By HuYunHai END 2011-02-15 

            //        //add by hyh 2012-05-10
            //        case "S44":
            //            txtLF04AfterOut.Text = "";
            //            break;
            //        //end
            //        default:
            //            break;
            //    }
            //    return;
            //}
            ////执行
            //cmdGetDirection.Parameters[0].ConstantValue = strUnitID;
            //cmdGetDirection.Parameters[1].ConstantValue = strHeatID;
            //cmdGetDirection.Execute();
            //strReturn = cmdGetDirection.Command.Return.ToString();

            //switch (strUnitID)
            //{
            //    case "S21":
            //        txtBOF01AfterOut.Text = strReturn;
            //        break;
            //    case "S22":
            //        txtBOF02AfterOut.Text = strReturn;
            //        break;
            //    case "S23":
            //        txtBOF03AfterOut.Text = strReturn;
            //        break;
            //    case "S24":
            //        txtBOF04AfterOut.Text = strReturn;
            //        break;
            //    case "S41":
            //        txtLF01AfterOut.Text = strReturn;
            //        break;
            //    case "S42":
            //        txtLF02AfterOut.Text = strReturn;
            //        break;
            //    case "S43":
            //        txtLF03AfterOut.Text = strReturn;
            //        break;
            //    case "S51":
            //        txtRH01AfterOut.Text = strReturn;
            //        break;

            //    //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
            //    case "S45":
            //        txtLF05AfterOut.Text = strReturn;
            //        break;
            //    //Modify By HuYunHai END   2011-02-15 

            //    //Modify By hyh BEGIN 2012-05-10 (新建4LF炉)
            //    case "S44":
            //        txtLF04AfterOut.Text = strReturn;
            //        break;
            //    //Modify By HuYunHai END   2011-02-15 

            //    default:
            //        break;
            //}
        }

        //根据炼钢记号获取对应钢种
        private void GetSteelGradeBySteelGradeIndex(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!(sender is AppSvrHMI.L3DataBox))
            //        return;
            //    AppSvrHMI.L3DataBox ctrl = sender as AppSvrHMI.L3DataBox;

            //    if (ctrl.Tag.ToString().Length < 1)
            //        return;

            //    foreach (Control other in ctrl.Parent.Controls)
            //    {
            //        if (!(other is AppSvrHMI.L3DataBox)) continue;
            //        AppSvrHMI.L3DataBox otherTxt = other as AppSvrHMI.L3DataBox;
            //        if (otherTxt == ctrl) continue;
            //        if (otherTxt.Tag != null && ctrl.Tag != null && otherTxt.Tag.ToString() == ctrl.Tag.ToString())
            //        {
            //            otherTxt.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
            //            return;
            //        }
            //    }
            //}
            //catch { }
        }

        private void ucBOFStatus2_Load(object sender, EventArgs e)
        {

        }

        private void ProcessSchemaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //设置设备状态
        private void dbxEquipStatus_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "L3DataBox")
                return;

            AppSvrHMI.L3DataBox c = (AppSvrHMI.L3DataBox)sender;
            switch (c.Tag.ToString())
            {
                case "B1":
                    lbEquStaB1.Text = Set_BOF_EquipLableText(dbxEquStaBOF1.Text);
                    break;
                case "B2":
                    lbEquStaB2.Text = Set_BOF_EquipLableText(dbxEquStaBOF2.Text);
                    break;
                case "B3":
                    lbEquStaB3.Text = Set_BOF_EquipLableText(dbxEquStaBOF3.Text);
                    break;
                case "B4":
                    lbEquStaB4.Text = Set_BOF_EquipLableText(dbxEquStaBOF4.Text);
                    break;

                case "L1":
                    lbEquStaL1.Text = Set_LF_EquipLableText(dbxEquStaLF1.Text);
                    break;
                case "L2":
                    lbEquStaL2.Text = Set_LF_EquipLableText(dbxEquStaLF2.Text);
                    break;
                case "L3":
                    lbEquStaL3.Text = Set_LF_EquipLableText(dbxEquStaLF3.Text);
                    break;

                 //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
                case "L5":
                    lbEquStaL5.Text=Set_LF_EquipLableText((dbxEquStaLF5.Text));
                    break;
                 //Modify By HuYunHai BEGIN 2011-02-15 
                //add by hyh 2012-05-10
                case "L4":
                    lbEquStaL4.Text = Set_LF_EquipLableText((dbxEquStaLF4.Text));
                    break;
                    //end

                case "R1":
                    lbEquStaR1.Text = Set_RH_EquipLableText(dbxEquStaRH1.Text);
                    break;

                // Modify By HuYunHai Begin  2011-02-14   (1#连铸机修改为7#连铸机，删除2#连铸机)
                case "C7":
                    lbEquStaC7.Text = Set_CCM_EquipLableText(dbxEquStaCCM7.Text);
                    break;
                //case "C2":
                //    lbEquStaC2.Text = Set_CCM_EquipLableText(dbxEquStaCCM2.Text);
                //    break;
                // Modify By HuYunHai End  2011-02-14  

                case "C3":
                    lbEquStaC3.Text = Set_CCM_EquipLableText(dbxEquStaCCM3.Text);
                    break;
                case "C4":
                    lbEquStaC4.Text = Set_CCM_EquipLableText(dbxEquStaCCM4.Text);
                    break;
                case "C5":
                    lbEquStaC5.Text = Set_CCM_EquipLableText(dbxEquStaCCM5.Text);
                    break;
                    //add by hyh 2012-05-10
                case "C6":
                    lbEquStaC6.Text = Set_CCM_EquipLableText(dbxEquStaCCM6.Text);
                    break;
                    //end


                //case "D1":
                //    lbEquStaD1.Text = Set_DeS_EquipLableText(dbxEquStaDeS1.Text);
                //    break;
                //case "D2":
                //    lbEquStaD2.Text = Set_DeS_EquipLableText(dbxEquStaDeS2.Text);
                //    break;
                //case "D1T":
                //    txtDeSIDeSType.Text = Set_DeS_DeSType(txtDeSType1.Text);
                //    break;
                //case "D2T":
                //    txtDeSIIDeSType.Text = Set_DeS_DeSType(txtDeSType2.Text);
                //    break;
                //default:
                //    break;
            }
        }
        //获取脱硫设备状态表述
        private string Set_DeS_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case 1:
                        strReturnText = "正常";
                        break;
                    case 2:
                        strReturnText = "检修";
                        break;
                    case 3:
                        strReturnText = "等待";
                        break;
                    case 4:
                        strReturnText = "清渣";
                        break;
                    case 5:
                        strReturnText = "喷浆";
                        break;
                    case 6:
                        strReturnText = "更换防溅罩";
                        break;
                    case 7:
                        strReturnText = "故障";
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
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
        //获取转炉设备状态表述
        private string Set_BOF_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case CommDataMag.CommonData.BOFNormal:
                        strReturnText = CommDataMag.CommonData.strBOFNormal;
                        break;
                    case CommDataMag.CommonData.BOFRepair:
                        strReturnText = CommDataMag.CommonData.strBOFRepair;
                        break;
                    case CommDataMag.CommonData.BOFBushing:
                        strReturnText = CommDataMag.CommonData.strBOFBushing;
                        break;
                    case CommDataMag.CommonData.BOFMaintain:
                        strReturnText = CommDataMag.CommonData.strBOFMaintain;
                        break;
                    case CommDataMag.CommonData.BOFFailure:
                        strReturnText = CommDataMag.CommonData.strBOFFailure;
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //获取LF炉设备状态表述
        private string Set_LF_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case CommDataMag.CommonData.LFNormal:
                        strReturnText = CommDataMag.CommonData.strLFNormal;
                        break;
                    case CommDataMag.CommonData.LFRepair:
                        strReturnText = CommDataMag.CommonData.strLFRepair;
                        break;
                    case CommDataMag.CommonData.LFBushing:
                        strReturnText = CommDataMag.CommonData.strLFBushing;
                        break;
                    case CommDataMag.CommonData.LFMaintain:
                        strReturnText = CommDataMag.CommonData.strLFMaintain;
                        break;
                    case CommDataMag.CommonData.LFFailure:
                        strReturnText = CommDataMag.CommonData.strLFFailure;
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //获取RH炉设备状态表述
        private string Set_RH_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case CommDataMag.CommonData.RHNormal:
                        strReturnText = CommDataMag.CommonData.strRHNormal;
                        break;
                    case CommDataMag.CommonData.RHRepair:
                        strReturnText = CommDataMag.CommonData.strRHRepair;
                        break;
                    case CommDataMag.CommonData.RHFailure:
                        strReturnText = CommDataMag.CommonData.strRHFailure;
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //获取RH炉设备状态表述
        private string Set_CCM_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case CommDataMag.CommonData.CCMNormal:
                        strReturnText = CommDataMag.CommonData.strCCMNormal;
                        break;
                    case CommDataMag.CommonData.CCMRepair:
                        strReturnText = CommDataMag.CommonData.strCCMRepair;
                        break;
                    case CommDataMag.CommonData.CCMFailure:
                        strReturnText = CommDataMag.CommonData.strCCMFailure;
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        private void ucCCMStatus_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus)
        {
            try
            {
                ////生产状态不为浇注中，不获取
                //if (NewStatus != CommDataMag.CommonData.CCMCasting)
                //    return;

                //if (UnitURI.ToString() == "")
                //    return;
                //if (this.Adapter == null || this.Adapter.Session == null)
                //    return;

                //object objTreatNo = null;
                //string strCCMID = UnitURI.Substring(UnitURI.Length - 3, 3);
                //Adapter.Session.Get(UnitURI, "TreatNo", ref objTreatNo);

                //object objCastingHeatNum = null;
                //object objTundishHeatNum = null;
                //string strCastingHeatNum = "";
                //string strTundishHeatNum = "";

                //if (objTreatNo != null)
                //{
                //    Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + objTreatNo.ToString(), "Casting_HeatNum", ref objCastingHeatNum);
                //    if (objCastingHeatNum != null)
                //        strCastingHeatNum = objCastingHeatNum.ToString();

                //    Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + objTreatNo.ToString(), "Tundish_HeatNum", ref objTundishHeatNum);
                //    if (objTundishHeatNum != null)
                //        strTundishHeatNum = objTundishHeatNum.ToString();

                //}
                //switch (strCCMID)
                //{
                //    // Modify By HuYunHai Begin  2011-02-14   (1#连铸机修改为7#连铸机，删除2#连铸机)
                //    case "S67":
                //        dbxCasting7.Text = strCastingHeatNum;
                //        dbxTundish7.Text = strTundishHeatNum;
                //        break;
                //    //case "S62":
                //    //    dbxCasting2.Text = strCastingHeatNum;
                //    //    dbxTundish2.Text = strTundishHeatNum;
                //    //    break;
                //    // Modify By HuYunHai End  2011-02-14   
                //    case "S63":
                //        dbxCasting3.Text = strCastingHeatNum;
                //        dbxTundish3.Text = strTundishHeatNum;
                //        break;
                //    case "S64":
                //        dbxCasting4.Text = strCastingHeatNum;
                //        dbxTundish4.Text = strTundishHeatNum;
                //        break;
                //    case "S65":
                //        dbxCasting5.Text = strCastingHeatNum;
                //        dbxTundish5.Text = strTundishHeatNum;
                //        break;
                //        //add by hyh 2012-05-10
                //    case "S66":
                //        dbxCasting6.Text = strCastingHeatNum;
                //        dbxTundish6.Text = strTundishHeatNum;
                //        break;
                //        //end
                //    default:
                //        break;
                //}
            }
            catch { }
        }

      
        //根据脱硫状态更改图片设置
        private void dbxDeSStatus1_TextChanged(object sender, EventArgs e)
        {
            //string strStatus = dbxDeSStatus1.Text;
            //switch (strStatus)
            //{
            //    case "":
            //        lbStatus1.Text = "准备脱硫";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "1":
            //        lbStatus1.Text = "准备脱硫";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "2":
            //        lbStatus1.Text = "铁罐进站";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "3":
            //        lbStatus1.Text = "预捞渣开始";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "4":
            //        lbStatus1.Text = "预捞渣结束";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "5":
            //        lbStatus1.Text = "喷吹开始";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesBusy;
            //        break;
            //    case "6":
            //        lbStatus1.Text = "喷吹结束";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "7":
            //        lbStatus1.Text = "捞渣开始";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "8":
            //        lbStatus1.Text = "捞渣结束";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "9":
            //        lbStatus1.Text = "铁罐出站";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    default:
            //        lbStatus1.Text = "准备脱硫";
            //        pbxDeS1.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //}
        }

        private void dbxDeSStatus2_TextChanged(object sender, EventArgs e)
        {
            //string strStatus = dbxDeSStatus2.Text;
            //switch (strStatus)
            //{
            //    case "":
            //        lbStatus2.Text = "准备脱硫";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "1":
            //        lbStatus2.Text = "准备脱硫";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "2":
            //        lbStatus2.Text = "铁罐进站";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "3":
            //        lbStatus2.Text = "预捞渣开始";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "4":
            //        lbStatus2.Text = "预捞渣结束";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "5":
            //        lbStatus2.Text = "喷吹开始";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesBusy;
            //        break;
            //    case "6":
            //        lbStatus2.Text = "喷吹结束";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "7":
            //        lbStatus2.Text = "捞渣开始";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "8":
            //        lbStatus2.Text = "捞渣结束";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    case "9":
            //        lbStatus2.Text = "铁罐出站";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //    default:
            //        lbStatus2.Text = "准备脱硫";
            //        pbxDeS2.Image = global::DispatchMag.Properties.Resources.DesFree;
            //        break;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现异常:" + ex.ToString());
            }
        }
    }
}