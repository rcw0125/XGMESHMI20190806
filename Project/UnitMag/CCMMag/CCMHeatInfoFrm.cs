using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMHeatInfoFrm : Form
    {
        public CCMHeatInfoFrm()
        {
            InitializeComponent();
        }

        private bool UnLock = false;
        private bool check = false;

        private string strHeatID = "";
        private string strTreatNO = "";
        private string strTundishNo = "";
        private string strTundishID = "";

        private string strSteelGradeIndex = "";//当前炉号对应当前炼钢记号

        private bool bOperation = false;
        private DataSet dsAccept = new DataSet();

        public void ShowDialogEx(AppSvrIF.Session session, bool bLock, bool bCheckFlag, DataSet dsSend, string HeatID, string TreatNo)
        {
            /****Modify By Huyunahi 2011-3-15***/
            string flag = TreatNo.Substring(0, 1);
            if (flag.Equals("7"))
            {
                label57.Visible = false;
                cmbFourth.Visible = false;
                label21.Visible = false;
                cmbSoftPressFlag4.Visible = false;
                cmbSoftPressFlag4.Enabled = false;
                //label23.Location = new System.Drawing.Point(624, 199);
                //cmbPlugBarControl.Location = new System.Drawing.Point(743, 199);

            }
            /*********Modify END**********/

            /********20090218****************/
            tabProtectMat.Dispose();
            tabProtectCasting.Dispose();
            /***************************/

            UnLock = !bLock;
            check = bCheckFlag;

            dsAccept = dsSend.Copy();
            strHeatID = HeatID;
            strTreatNO = TreatNo;


            tbxHeatID.Text = HeatID;
            tbxTreatNo.Text = TreatNo;


            dsBase.SourceCondition = "HeatID = '" + HeatID + "'";

            dsChemical.SourceCondition = "HeatID = '" + HeatID + "' order by Report_Date desc";// and UNITTYPEID = '6'

            dsHeatCover.SourceCondition = "HeatID = '" + HeatID + "'";

            dsHeatTundishTemp.SourceCondition = "HeatID = '" + HeatID + "' order by Measure_Time desc";

            dsLadle.SourceCondition = "HeatID = '" + HeatID + "'";

            dsLadleUse.SourceCondition = "HeatID = '" + HeatID + "'";

            dsProcess.SourceCondition = "HeatID = '" + HeatID + "'";

            dsProtectCasting.SourceCondition = "HeatID = '" + HeatID + "'";

            dsProtectMat.SourceCondition = "HeatID = '" + HeatID + "'";

            dsProtectSlag.SourceCondition = "HeatID = '" + HeatID + "'";

            dsHoldTempMat.SourceCondition = "HeatID = '" + HeatID + "'";

            dsRemark.SourceCondition = "HeatID = '" + HeatID + "' order by Log_Time desc";

            dsSpeed.SourceCondition = "HeatID = '" + HeatID + "' order by Change_Time desc,StrandID";

            dsStatus.SourceCondition = "HeatID = '" + HeatID + "' order by Change_Time desc";

            dsStrandInfo.SourceCondition = "HeatID = '" + HeatID + "' order by StrandID";

            dsSmoothBlock.SourceCondition = "HeatID = '" + HeatID + "'";

            dsHurryGrap.SourceCondition = "HeatID = '" + HeatID + "'";

            dsBigGap.SourceCondition = "HeatID = '" + HeatID + "'";

            //炉次异常
            dsExcept.SourceCondition = "HeatID = '" + HeatID + "' and UnitTypeID = '6' and UnitID = '" + TreatNo.Substring(0, 1) + "'";
            //dsExcept.SourceCondition = "HeatID = '" + HeatID + "' and UnitTypeID = '6' and UnitID = '" + TreatNo.Substring(0, 1) + "'";
            //dsExcept.SourceCondition = "HeatID = '211101524'  and UnitTypeID = '6' and UnitID = '4'";
            //设置查询炉次异常条件
            // Adapter.set_URIParameters("UnitID", strHeatID.Substring(0, 1));
            try
            {
                this.Adapter.Session = session;
                dsDuty.L3DataAdapter = Adapter;
                dsBase.L3DataAdapter = Adapter;

                //[20081230]
                object objTundishNO = null;
                try
                {
                    if (strTreatNO != "")
                    {
                        Adapter.Session.Get("XGMESLogic\\CCMMag\\CCCM_Process_Data\\" + strTreatNO, "TundishNo", ref objTundishNO);
                        if (objTundishNO != null && objTundishNO.ToString() != "")
                        {
                            strTundishNo = objTundishNO.ToString();

                            object objTundishID = null;
                            Adapter.Session.Get("XGMESLogic\\CCMMag\\CCCM_Tundish_Data\\" + strTundishNo, "TundishID", ref objTundishID);
                            if (objTundishID != null && objTundishID.ToString() != "")
                                strTundishID = objTundishID.ToString();
                        }
                    }
                }
                catch { }
            }
            catch { }

            this.ShowDialog();
        }

        private void CCMHeatInfoFrm_Load(object sender, EventArgs e)
        {
            /*****Modify By Huyunhai 2011-03-24***如果炉次为1，重新计算等压钢时间*/
            dsProcess.L3DataAdapter = Adapter;
            dsLadle.L3DataAdapter = Adapter;
            if ((dsProcess.Tables[0].Rows.Count>0)&&(Convert.ToInt32(dsProcess.Tables[0].Rows[0]["Tundish_HeatNum"]) == 1))
            {              
                DateTime Casting_Start_Time = Convert.ToDateTime(dsLadle.Tables[0].Rows[0]["Casting_Start_Time"]);
                DateTime ArriveTime = Convert.ToDateTime(dsLadle.Tables[0].Rows[0]["Arrival_Time"]);
                int second1 = 0;
                int second2 =0;
                if (Casting_Start_Time.Month==ArriveTime.Month)
                {
                    second1 = Casting_Start_Time.Day * 24 * 60 * 60 + Casting_Start_Time.Hour * 60 * 60 + Casting_Start_Time.Minute * 60 + Casting_Start_Time.Second;
                    second2 = ArriveTime.Day * 24 * 60 * 60 + ArriveTime.Hour * 60 * 60 + ArriveTime.Minute * 60 + ArriveTime.Second;
                    dsLadle.Tables[0].Rows[0]["HoldTime"] = second1 - second2;
                }
                           
            }
            /********Modify END*******/

            btnSmoothBlockAdd.Visible = false;//   UnLock;
            btnSmoothBlockDel.Visible = false;//  UnLock;

            btnHurryGapAdd.Visible = false;//   UnLock;
            btnHurryGapDel.Visible = false;//  UnLock;

            btnBigGapAdd.Visible = false;//  UnLock;
            btnBigGapDel.Visible = false;//  UnLock;



            btnDelExcept.Visible = false;

            //如果实际尚未锁定并且可以维护实绩
            if (UnLock && check)
            {
                //基本数据
                pnlBase.Visible = true;
                btnBaseOK.Visible = true;
                foreach (Control cBase in this.tabBase.Controls)
                {
                    if (cBase.GetType().Name == "TextBox")
                        ((TextBox)cBase).ReadOnly = false;

                    else if (cBase.GetType().Name == "ComboBox")
                        ((ComboBox)cBase).Enabled = true;

                    else if (cBase.GetType().Name == "PxTextBox")
                        ((PxDataValid.PxTextBox)cBase).ReadOnly = false;

                    else if (cBase.GetType().Name == "PxComboBox")
                        ((PxDataValid.PxComboBox)cBase).Enabled = true;


                    else if (cBase.GetType().Name == "DateTimePicker")
                        ((DateTimePicker)cBase).Enabled = true;
                }

                //连铸数据
                pnlProcess.Visible = true;
                btnPaocessOK.Visible = true;
                foreach (Control cProcesse in this.tabProcess.Controls)
                {
                    if (cProcesse.GetType().Name == "TextBox")
                        ((TextBox)cProcesse).ReadOnly = false;

                    else if (cProcesse.GetType().Name == "ComboBox")
                        ((ComboBox)cProcesse).Enabled = true;

                    else if (cProcesse.GetType().Name == "PxTextBox")
                        ((PxDataValid.PxTextBox)cProcesse).ReadOnly = false;

                    else if (cProcesse.GetType().Name == "PxComboBox")
                        ((PxDataValid.PxComboBox)cProcesse).Enabled = true;

                    else if (cProcesse.GetType().Name == "DateTimePicker")
                        ((DateTimePicker)cProcesse).Enabled = true;
                }

                //炉次异常
                fLPExcept.Visible = true;
                btnAddExcept.Visible = true;
                btnConfirmExcept.Visible = true;

                //成份数据
                btnAddChemical.Visible = true;
                pnlChemical.Visible = true;
                btnChemicalOK.Visible = true;

                //状态数据
                btnAddStatus.Visible = true;
                pnlStatus.Visible = true;
                btnStatusOK.Visible = true;

                //中包测温
                btnAddHeatTundishTemp.Visible = true;
                //pnlTemp.Visible = true;
                //btnTempOK.Visible = true;

                //覆盖剂 
                btnAddHeatCover.Visible = true;
                btnDelHeatCover.Visible = false;
                pnlHeatCover.Visible = true;
                btnCoverOK.Visible = true;

                //大包数据
                btnAddLadle.Visible = true;
                pnlLadle.Visible = true;
                btnLadleOK.Visible = true;

                //保护浇注
                btnAddProtectCasting.Visible = false;// UnLock;
                pnlProtectCasting.Visible = false;// UnLock;
                btnProtectCastingOK.Visible = true;

                //保护材质
                btnAddProtectMat.Visible = true;
                btnDelProtectMat.Visible = true;
                pnlProtectMat.Visible = true;
                btnProtectMatOK.Visible = true;

                //保护渣
                btnAddProtectSlag.Visible = true;
                btnDelProtectSlag.Visible = true;
                pnlProtectSlag.Visible = true;
                btnProtectSlagOK.Visible = true;

                //保温剂信息
                btnAddHoldTempMat.Visible = true;
                btnDelHoldTempMat.Visible = true;
                pnlHoldTempMat.Visible = true;
                btnHoldTempMatConfirm.Visible = true;

                //拉速
                btnAddSpeed.Visible = true;// UnLock;
                pnlSpeed.Visible = true;//  UnLock;
                btnSpeedOk.Visible = true;

                //流数据
                btnAddStrandInfo.Visible = true;
                btnDelStrandInfo.Visible = true;
                pnlStrandInfo.Visible = true;
                btnStrandInfoOK.Visible = true;

                //记事数据
                btnAddRemark.Visible = true;
                pnlRemark.Visible = true;
                btnRemarkOK.Visible = true;

                fLPSmoothBlock.Visible = true;//  UnLock;
                pnlHurryGap.Visible = true;//  UnLock;
                pnlBigGap.Visible = true;//  UnLock;
            }
            else
            {
                btnAddChemical.Visible = false;// UnLock;
                pnlChemical.Visible = false;// UnLock;

                btnAddStatus.Visible = false;// UnLock;
                pnlStatus.Visible = false;// UnLock;

                btnAddHeatTundishTemp.Visible = false;//  UnLock;
                //pnlTemp.Visible = false;// UnLock;

                btnAddProtectCasting.Visible = false;// UnLock;
                pnlProtectCasting.Visible = false;// UnLock;

                btnAddSpeed.Visible = false;// UnLock;
                pnlSpeed.Visible = false;//  UnLock;

                if (!UnLock)
                {
                    pnlBase.Visible = UnLock;

                    pnlProcess.Visible = UnLock;

                    btnAddHeatCover.Visible = UnLock;
                    btnDelHeatCover.Visible = UnLock;
                    pnlHeatCover.Visible = UnLock;

                    btnAddLadle.Visible = UnLock;
                    pnlLadle.Visible = UnLock;

                    btnAddProtectMat.Visible = UnLock;
                    btnDelProtectMat.Visible = UnLock;
                    pnlProtectMat.Visible = UnLock;

                    btnAddProtectSlag.Visible = UnLock;
                    btnDelProtectSlag.Visible = UnLock;
                    pnlProtectSlag.Visible = UnLock;

                    btnAddRemark.Visible = UnLock;
                    pnlRemark.Visible = UnLock;

                    btnAddHoldTempMat.Visible = UnLock;
                    btnDelHoldTempMat.Visible = UnLock;
                    pnlHoldTempMat.Visible = UnLock;

                    btnAddStrandInfo.Visible = UnLock;
                    btnDelStrandInfo.Visible = UnLock;
                    pnlStrandInfo.Visible = UnLock;

                    fLPExcept.Visible = UnLock;
                    btnAddExcept.Visible = UnLock;

                    fLPSmoothBlock.Visible = UnLock;
                    pnlHurryGap.Visible = UnLock;
                    pnlBigGap.Visible = UnLock;
                }
            }

            //if (txtInjectionBar_BlowAr.Text == "")
            //    cmbInjectionBar_BlowAr.SelectedValue = 1;
            //if (txtSecondCoolingMode.Text == "")
            //    cmbSecondCoolingMode.SelectedValue = 1;
            if (cmbTeam.SelectedValue != null)
                dsDuty.SourceCondition = "CCMID ='" + tbxCCMID.Text.Trim() + "' and TeamID = '" + cmbTeam.SelectedValue.ToString() + "'";
            int i = cmbAssistant.Items.Count;
            dsBase.LoadData();
            if (cmbHeadFurnace.Text == "")
                if (cmbHeadFurnace.Items.Count > 0)
                    cmbHeadFurnace.SelectedIndex = 0;
            if (cmbControlOperator.Text == "")
                if (cmbControlOperator.Items.Count > 0)
                    cmbControlOperator.SelectedIndex = 0;
            if (cmbAssistant.Text == "")
                if (cmbAssistant.Items.Count > 0)
                    cmbAssistant.SelectedIndex = 0;

          

           
        }

        //基本数据
        private void btnBaseOK_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            bOperation = dsBase.UpdateData();
            MessageShowOperation();
            dsBase.LoadData();
        }

        private void btnBaseCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }

        //冶炼数据
        private void btnPaocessOK_Click(object sender, EventArgs e)
        {
            bsProcess.EndEdit();
            bOperation = dsProcess.UpdateData();
            MessageShowOperation();
            dsProcess.LoadData();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
        }

        //成份数据
        private void btnAddChemical_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsChemical.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["LogTime"] = System.DateTime.Now;
            newrow["Arrive_Date"] = System.DateTime.Now;
            newrow["Report_Date"] = System.DateTime.Now;
            dsChemical.Tables[0].Rows.Add(newrow);
        }

        private void btnChemicalOK_Click(object sender, EventArgs e)
        {
            dvChemical.EndEdit();
            bsChemical.EndEdit();
            bOperation = dsChemical.UpdateData();
            MessageShowOperation();
            dsChemical.LoadData();
        }

        private void btnChemicalCancel_Click(object sender, EventArgs e)
        {
            dsChemical.LoadData();
        }

        //状态数据
        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsStatus.Tables[0].NewRow();//
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["TreatNo"] = strTreatNO;
            newrow["Change_Time"] = System.DateTime.Now;
            dsStatus.Tables[0].Rows.Add(newrow);
        }

        private void btnStatusOK_Click(object sender, EventArgs e)
        {
            dvStatus.EndEdit();
            bsStatus.EndEdit();
            bOperation = dsStatus.UpdateData();
            MessageShowOperation();
            dsStatus.LoadData();
        }

        private void btnStatusCancel_Click(object sender, EventArgs e)
        {
            dsStatus.LoadData();
        }

        //中包测温
        private void btnAddHeatTundishTemp_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsHeatTundishTemp.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["Measure_Time"] = System.DateTime.Now;
            dsHeatTundishTemp.Tables[0].Rows.Add(newrow);
        }

        private void btnTempOK_Click(object sender, EventArgs e)
        {
            dvHeatTundishTemp.EndEdit();
            bsHeatTundishTemp.EndEdit();
            bOperation = dsHeatTundishTemp.UpdateData();
            MessageShowOperation();
            dsHeatTundishTemp.LoadData();
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsHeatTundishTemp.LoadData();
        }

        //覆盖剂
        private void btnAddHeatCover_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsHeatCover.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["UseInformation"] = 0;
            newrow["Batch_ID"] = 0;
            dsHeatCover.Tables[0].Rows.Add(newrow);
        }

        private void btnDelHeatCover_Click(object sender, EventArgs e)
        {
            if (bsHeatCover.Current != null)
                bsHeatCover.RemoveCurrent();
        }

        private void btnCoverK_Click(object sender, EventArgs e)
        {
            dvHeatCover.EndEdit();
            bsHeatCover.EndEdit();
            bOperation = dsHeatCover.UpdateData();
            MessageShowOperation();
            dsHeatCover.LoadData();
        }

        private void btnCoverCancel_Click(object sender, EventArgs e)
        {
            dsHeatCover.LoadData();
        }

        //大包数据
        private void btnAddLadle_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsLadle.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["LadleID"] = dsAccept.Tables[0].Rows[0]["LadleNO"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["TreatNO"] = strTreatNO;
            newrow["Arrival_Time"] = System.DateTime.Now;
            newrow["Departure_Time"] = System.DateTime.Now;
            newrow["Casting_Start_Time"] = System.DateTime.Now;
            newrow["Casting_Stop_Time"] = System.DateTime.Now;
            newrow["TempUpTo"] = 1;
            newrow["Protection"] = 1;
            newrow["AutoFlow"] = 0;
            newrow["UnAutoFlow_Reason"] = 0;
            newrow["UnProtection_Reason"] = 0;

            dsLadle.Tables[0].Rows.Add(newrow);
        }

        //private void btnLadle_Click(object sender, EventArgs e)
        //{
        //    //DataRow ladlerow = dsLadle.Tables[0].Rows[0]["AutoFlow"].ToString();
        //    //dsLadleUse .Tables [0].Rows .Add (ladlerow);
        //    /*****Modify Begin At 2011-02-23 By Huyunhai(手动输入等压钢超时原因)CCMCheck******/
        //    if (bsLadle.Count > 0 && bsLadle.Current != null && txtReason.Text != "")
        //    {
        //        ((DataRowView)bsLadle.Current)["HOLDTIME"] = txtReason.Text;
        //    }

        //    lblReason.Visible = false;
        //    txtReason.Visible = false;
        //    txtReason.Text = "";
        //    /*****Modify END*****/

        //    bsLadle.EndEdit();
        //    dsLadleUse.Clear();
        //    DataRow ladlerow = dsLadleUse.Tables[0].NewRow();
        //    ladlerow["Auto_Flow"] = dsLadle.Tables[0].Rows[0]["AutoFlow"].ToString();
        //    ladlerow["HeatID"] = strHeatID;
        //    dsLadleUse.Tables[0].Rows.Add(ladlerow);
        //    bOperation = dsLadle.UpdateData();
        //    bOperation = dsLadleUse.UpdateData();
        //    MessageShowOperation();
        //    dsLadle.LoadData();

        //}

        private void btnLadle_Click(object sender, EventArgs e)
        {
            //DataRow ladlerow = dsLadle.Tables[0].Rows[0]["AutoFlow"].ToString();
            //dsLadleUse .Tables [0].Rows .Add (ladlerow);
            /*****Modify Begin At 2011-02-23 By Huyunhai(手动输入等压钢超时原因)CCMCheck******/
            if (bsLadle.Count > 0 && bsLadle.Current != null && txtReason.Text != "")
            {
                ((DataRowView)bsLadle.Current)["HOLDTIME"] = txtReason.Text;
            }

            lblReason.Visible = false;
            txtReason.Visible = false;
            txtReason.Text = "";
            /*****Modify END*****/

            bsLadle.EndEdit();
            //dsLadleUse.Clear();
            //DataRow ladlerow = dsLadleUse.Tables[0].NewRow();
            string strautoflow = dsLadle.Tables[0].Rows[0]["AutoFlow"].ToString();
            //ladlerow["HeatID"] = strHeatID;
            string sql = "Update Cladle_use set auto_flow ='" + strautoflow + "' where HeatID='" + strHeatID + "'";
            dsLadleUse.SourceMethod = sql;
            bOperation = dsLadle.UpdateData();
            Adapter.RefreshDataBindings();
            MessageShowOperation();
            dsLadle.LoadData();

        }

        private void btnLadleCancel_Click(object sender, EventArgs e)
        {
            dsLadle.LoadData();
        }

        //保护浇注
        private void btnAddProtectCasting_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsProtectCasting.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["Start_Time"] = System.DateTime.Now;
            newrow["Stop_Time"] = System.DateTime.Now;
            dsProtectCasting.Tables[0].Rows.Add(newrow);
        }

        private void btnProtectCastingOK_Click(object sender, EventArgs e)
        {
            bsProtectCasting.EndEdit();
            bOperation = dsProtectCasting.UpdateData();
            MessageShowOperation();
            dsProtectCasting.LoadData();
        }

        private void btnProtectCastingCancel_Click(object sender, EventArgs e)
        {
            dsProtectCasting.LoadData();
        }

        //保护材质
        private void btnAddProtectMat_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsProtectMat.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            dsProtectMat.Tables[0].Rows.Add(newrow);
        }

        private void btnDelProtectMat_Click(object sender, EventArgs e)
        {
            if (bsProtectMat.Current != null)
                bsProtectMat.RemoveCurrent();
        }

        private void btnProtectMatOK_Click(object sender, EventArgs e)
        {
            dvProtectMat.EndEdit();
            bsProtectMat.EndEdit();
            bOperation = dsProtectMat.UpdateData();
            MessageShowOperation();
            dsProtectMat.LoadData();
        }

        private void btnProtectMatCancel_Click(object sender, EventArgs e)
        {
            dsProtectMat.LoadData();
        }

        //保护渣
        private void btnAddProtectSlag_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsProtectSlag.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["UseInformation"] = 0;
            dsProtectSlag.Tables[0].Rows.Add(newrow);
        }

        private void btnDelProtectSlag_Click(object sender, EventArgs e)
        {
            if (bsProtectSlag.Current != null)
                bsProtectSlag.RemoveCurrent();
        }

        private void btnProtectSlagOK_Click(object sender, EventArgs e)
        {
            dvProtectSlag.EndEdit();
            bsProtectSlag.EndEdit();
            bOperation = dsProtectSlag.UpdateData();
            MessageShowOperation();
            dsProtectSlag.LoadData();
        }

        private void btnProtectSlagCancel_Click(object sender, EventArgs e)
        {
            dsProtectSlag.LoadData();
        }

        //拉速 
        private void btnAddSpeed_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsSpeed.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["Change_Time"] = System.DateTime.Now;
            dsSpeed.Tables[0].Rows.Add(newrow);
        }

        private void btnSpeedOk_Click(object sender, EventArgs e)
        {
            dvSpeed.EndEdit();
            bsSpeed.EndEdit();
            bOperation = dsSpeed.UpdateData();
            MessageShowOperation();
            dsSpeed.LoadData();
        }

        private void btnSpeedCancel_Click(object sender, EventArgs e)
        {
            dsSpeed.LoadData();
        }

        //流数据
        private void btnAddStrandInfo_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsStrandInfo.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["Start_Time"] = System.DateTime.Now;
            newrow["Stop_Time"] = System.DateTime.Now;/////
            newrow["WaterGap_Center"] = 0;
            newrow["liquid_level"] = 0;
            newrow["Block_Up"] = 0;
            newrow["Block_Up_Reason"] = 0;
            newrow["Auto_Control"] = 1;
            newrow["liquid_level"] = "正常";
            newrow["Cast_Num"] = 1;
            dsStrandInfo.Tables[0].Rows.Add(newrow);
        }

        private void btnDelStrandInfo_Click(object sender, EventArgs e)
        {
            if (bsStrandInfo.Current != null)
                bsStrandInfo.RemoveCurrent();
        }

        private void btnStrandInfoOK_Click(object sender, EventArgs e)
        {
            dvStrandInfo.EndEdit();
            bsStrandInfo.EndEdit();
            bOperation = dsStrandInfo.UpdateData();
            MessageShowOperation();
            dsStrandInfo.LoadData();
        }

        private void btnStrandInfoCancel_Click(object sender, EventArgs e)
        {
            dsStrandInfo.LoadData();
        }

        //记事数据
        private void btnAddRemark_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsRemark.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["TreatNo"] = strTreatNO;
            newrow["Log_Time"] = System.DateTime.Now;
            dsRemark.Tables[0].Rows.Add(newrow);
        }

        private void btnRemarkOK_Click(object sender, EventArgs e)
        {
            dvRemark.EndEdit();
            bsRemark.EndEdit();
            bOperation = dsRemark.UpdateData();
            MessageShowOperation();
            dsRemark.LoadData();
        }

        private void btnRemarkCancel_Click(object sender, EventArgs e)
        {
            dsRemark.LoadData();
        }

        private void MessageShowOperation()
        {
            if (bOperation)
            {
                MessageBox.Show("保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("保存失败！", "警告");
            }
        }

        //保温剂信息
        private void btnAddCasting_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsHoldTempMat.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["UseInformation"] = 0;
            dsHoldTempMat.Tables[0].Rows.Add(newrow);
        }

        private void btnDelHoldTempMat_Click(object sender, EventArgs e)
        {
            if (bsHoldTempMat.Current != null)
                bsHoldTempMat.RemoveCurrent();
        }

        private void btnCastingConfirm_Click(object sender, EventArgs e)
        {
            dvHoldTempMat.EndEdit();
            bsHoldTempMat.EndEdit();
            bOperation = dsHoldTempMat.UpdateData();
            MessageShowOperation();
            dsHoldTempMat.LoadData();
        }

        private void btnCastingCancel_Click(object sender, EventArgs e)
        {
            dsHoldTempMat.LoadData();
        }

        private void dvChemical_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //快换滑块
        private void btnSmoothBlockAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsSmoothBlock.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["Start_Time"] = System.DateTime.Now;
            newrow["End_Time"] = System.DateTime.Now;
            newrow["Reason"] = "0";
            dsSmoothBlock.Tables[0].Rows.Add(newrow);
        }

        private void btnSmoothBlockDel_Click(object sender, EventArgs e)
        {
            if (bsSmoothBlock.Current != null)
                bsSmoothBlock.RemoveCurrent();
        }

        private void btnSmoothBlockConfirm_Click(object sender, EventArgs e)
        {
            dvHurryS.EndEdit();
            bsSmoothBlock.EndEdit();
            bOperation = dsSmoothBlock.UpdateData();
            MessageShowOperation();
            dsSmoothBlock.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsSmoothBlock.LoadData();
        }

        //快换水口
        private void btnHurryGapAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsHurryGrap.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["Start_Time"] = System.DateTime.Now;
            newrow["End_Time"] = System.DateTime.Now;
            newrow["Reason"] = "0";
            dsHurryGrap.Tables[0].Rows.Add(newrow);
        }

        private void btnHurryGapDel_Click(object sender, EventArgs e)
        {
            if (bsHurryGap.Current != null)
                bsHurryGap.RemoveCurrent();
        }

        private void btnHurryGapConfirm_Click(object sender, EventArgs e)
        {
            dvHurryGap.EndEdit();
            bsHurryGap.EndEdit();
            bOperation = dsHurryGrap.UpdateData();
            MessageShowOperation();
            dsHurryGrap.LoadData();
        }

        private void btnHurryGapCancel_Click(object sender, EventArgs e)
        {
            dsHurryGrap.LoadData();
        }

        //大包水口
        private void btnBigGapAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBigGap.Tables[0].NewRow();
            newrow["CCMID"] = dsAccept.Tables[0].Rows[0]["CCMID"].ToString();
            newrow["HeatID"] = strHeatID;
            newrow["ChangeTime"] = System.DateTime.Now;
            newrow["Reason"] = "0";
            dsBigGap.Tables[0].Rows.Add(newrow);
        }

        private void btnBigGapDel_Click(object sender, EventArgs e)
        {
            if (bsBigGap.Current != null)
                bsBigGap.RemoveCurrent();
        }

        private void btnBigGapConfirm_Click(object sender, EventArgs e)
        {
            dvBigGap.EndEdit();
            bsBigGap.EndEdit();
            bOperation = dsBigGap.UpdateData();
            MessageShowOperation();
            dsBigGap.LoadData();
        }

        private void btnBigGapCancel_Click(object sender, EventArgs e)
        {
            dsBigGap.LoadData();
        }

        private void tabCtrlMain_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                /******Modify Begin At 2011-03-09 By Huyunhai*****/
                lblReason.Visible = false;
                txtReason.Visible = false;
                /*******Modify END******/

                if (e.Action == TabControlAction.Selected)
                {
                    switch (e.TabPage.Name)
                    {
                        case "tabProcess":
                            if (dsProcess.L3DataAdapter == null)
                                dsProcess.L3DataAdapter = Adapter;
                            //AppSvrHMI.L3DataSet dsFlag = new AppSvrHMI.L3DataSet();
                            //DataTable dt = new DataTable();
                            //dsFlag.Tables.Add(dt);
                            //dsFlag.Tables[0].Columns.Add("USEFLAG");
                            //dsFlag.Tables[0].Columns.Add("USEFLAG_DES");
                            //dsFlag.Tables[0].Rows.Add(new string[] { "0", "是" });
                            //dsFlag.Tables[0].Rows.Add(new string[] { "-1", "否" });
                            //dsFlag.Tables[0].Rows.Add(new string[] { "", "" });

                            //cmbSpeedChange.DataSource = dsFlag;
                            //cmbSpeedChange.DisplayMember = "Table1.USEFLAG_DES";
                            //cmbSpeedChange.ValueMember = "Table1.USEFLAG";

                            break;

                        case "tabChemical":
                            if (dsChemical.L3DataAdapter == null)
                                dsChemical.L3DataAdapter = Adapter;
                            break;

                        case "tabStatus":
                            if (dsStatus.L3DataAdapter == null)
                                dsStatus.L3DataAdapter = Adapter;
                            break;

                        case "tabHeatTundishTemp":
                            if (dsHeatTundishTemp.L3DataAdapter == null)
                                dsHeatTundishTemp.L3DataAdapter = Adapter;
                            break;

                        case "tabHeatCover":
                            if (dsHeatCover.L3DataAdapter == null)
                                dsHeatCover.L3DataAdapter = Adapter;
                            break;
                        /***Modify Begin At 2011-02-23 By Huyunhai***/
                        case "tabLadle":
                            lblReason.Visible = true;
                            txtReason.Visible = true;
                            if (dsLadle.L3DataAdapter == null)
                                dsLadle.L3DataAdapter = Adapter;
                            break;
                        /******Modify END******/
                        case "tabProtectCasting":
                            if (dsProtectCasting.L3DataAdapter == null)
                                dsProtectCasting.L3DataAdapter = Adapter;
                            break;

                        case "tabProtectMat":
                            if (dsProtectMat.L3DataAdapter == null)
                                dsProtectMat.L3DataAdapter = Adapter;
                            break;

                        case "tabProtectSlag":
                            if (dsProtectSlag.L3DataAdapter == null)
                                dsProtectSlag.L3DataAdapter = Adapter;
                            break;

                        case "tabHoldTempMat":
                            if (dsHoldTempMat.L3DataAdapter == null)
                                dsHoldTempMat.L3DataAdapter = Adapter;
                            break;

                        case "tabSpeed":
                            if (dsSpeed.L3DataAdapter == null)
                                dsSpeed.L3DataAdapter = Adapter;
                            break;

                        case "tabStrandInfo":
                            if (dsStrandInfo.L3DataAdapter == null)
                                dsStrandInfo.L3DataAdapter = Adapter;
                            break;

                        case "tabRemark":
                            if (dsRemark.L3DataAdapter == null)
                                dsRemark.L3DataAdapter = Adapter;
                            break;

                        case "tabRef":
                            if (dsSmoothBlock.L3DataAdapter == null)
                                dsSmoothBlock.L3DataAdapter = Adapter;
                            break;

                        case "tabSmoothBlock":
                            if (dsSmoothBlock.L3DataAdapter == null)
                                dsSmoothBlock.L3DataAdapter = Adapter;
                            break;

                        case "tabHurryGap":
                            if (dsHurryGrap.L3DataAdapter == null)
                                dsHurryGrap.L3DataAdapter = Adapter;
                            break;

                        case "tabBigGap":
                            if (dsBigGap.L3DataAdapter == null)
                                dsBigGap.L3DataAdapter = Adapter;
                            break;
                        case "tabExcept":
                            if (dsExcept.L3DataAdapter == null)
                                dsExcept.L3DataAdapter = Adapter;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        private void btnConfirmExcept_Click(object sender, EventArgs e)
        {
            dvExcept.EndEdit();
            bsExcept.EndEdit();

            if (dsExcept.GetChanges(DataRowState.Added) != null && dsExcept.GetChanges(DataRowState.Added).Tables[0].Rows.Count > 0)
            {
                cmdHeatExcept.Parameters[0].ConstantValue = strHeatID;
                cmdHeatExcept.Parameters[1].ConstantValue = "6";
                cmdHeatExcept.Parameters[2].ConstantValue = strTreatNO.Substring(0, 1).ToString();
                cmdHeatExcept.Parameters[3].SourceObject = dsExcept.GetChanges(DataRowState.Added);

                int iRet = cmdHeatExcept.Execute();
                if (iRet != 0 || (Convert.ToInt16(cmdHeatExcept.Command.Return)) != 0)
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdHeatExcept.Command.ErrorCode));
                    MessageBox.Show("失败！" + strReasultShow);
                }
                else
                {
                    MessageBox.Show("记录工艺异常成功！");
                }
            }
            if (dsExcept.GetChanges(DataRowState.Modified) != null && dsExcept.GetChanges(DataRowState.Modified).Tables[0].Rows.Count > 0)
            {
                object objMod = null;
                if (dsExcept.CommitModified(ref objMod))
                {
                    if (Convert.ToBoolean(objMod))
                    {
                        MessageBox.Show("修改成功！", "提示");
                    }
                }
            }
            dsExcept.LoadData();
        }

        private void btnCancelExcept_Click(object sender, EventArgs e)
        {
            dsExcept.LoadData();
        }
        //炉次异常[2009-03-12 Sun]
        private void btnAddExcept_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsExcept.Tables[0].NewRow();
            newrow["HeatID"] = strHeatID;
            newrow["UnitTypeID"] = "6";
            newrow["UnitID"] = strTreatNO.Substring(0, 1).ToString();
            newrow["Exceptional_Time"] = DateTime.Now;
            dsExcept.Tables[0].Rows.Add(newrow);
        }

        private void btnDelExcept_Click(object sender, EventArgs e)
        {
            if (bsExcept.Current != null)
                bsExcept.RemoveCurrent();
        }

        //获取炼钢记号
        private void dsBase_OnDataLoaded(object sender)
        {
            try
            {
                strSteelGradeIndex = dsBase.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            }
            catch { strSteelGradeIndex = ""; }
        }

        //成分报警
        private void dvChemical_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (strSteelGradeIndex != "")
            //    CommDataMag.CommonMethed.dv_Info_Element_Cell_BaceColor(Adapter, dvChemical, strSteelGradeIndex,6);
        }





        /*****Modify By Huyunhai 2011-3-22*****/

        //当焦点改变后 发生
        private void txtReason_Leave(object sender, EventArgs e)
        {
            // dsHoldTimeReason
            if (txtReason.Text.Trim() == "")
                return;
            int tempt = -1;
            foreach (DataRow dr in dsHoldTimeReason.Tables[0].Rows)
            {
                if (dr["Code"].ToString().Equals(""))
                    continue;
                if (Convert.ToInt32(dr["CODE"]) > tempt)
                {
                    tempt = Convert.ToInt32(dr["CODE"]);
                }

            }

            AppSvrHMI.L3DataSet ds = new AppSvrHMI.L3DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].Columns.Add("CODE");
            ds.Tables[0].Columns.Add("CODE_DES");
            ds.Tables[0].Columns.Add("CODE_GROUP");
            ds.Tables[0].Columns.Add("CODE_GROUP_DES");
            ds.Tables[0].Columns.Add("CODE_VAL_LONG");
            ds.Tables[0].Columns.Add("CODE_VAL_DOUBLE");

            string tt = Convert.ToString(tempt + 1);
            string cc = txtReason.Text.Trim();

            ds.Tables[0].Rows.Add(new string[] { tt, cc, "HoldTime_Reason", "等压钢超时原因","0","0"});

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmdExcept.Parameters[0].ConstantValue = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
                cmdExcept.Parameters[1].SourceObject = ds;
                //cmdExcept.Parameters[1].SourceProperty = "L3DataTable";
                int iRot = cmdExcept.Execute();
                if (iRot == 0)
                {
                    if (Convert.ToInt32(cmdExcept.Command.Return) == 0)
                    {
                        dsHoldTimeReason.LoadData();
                        MessageBox.Show("异常代码保存成功!");

                        // ds.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("异常代码保存失败!", "提示");
                        txtExcept.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("异常代码保存失败!", "提示");
                    txtExcept.Text = "";
                    return;
                }
            }

        }

        private void txtExcept_Leave(object sender, EventArgs e)
        {
            if (txtExcept.Text.Trim() == "")
                return;
            int tempt = -1;
            foreach (DataRow dr in dsExceptCode.Tables[0].Rows)
            {
                string dd = dr["Exceptional_Code"].ToString();
                if (dd.Equals(""))
                    continue;
                if (Convert.ToInt32(dd) > tempt)
                {
                    tempt = Convert.ToInt32(dr["EXCEPTIONAL_CODE"]);
                }

            }

            AppSvrHMI.L3DataSet ds = new AppSvrHMI.L3DataSet();
            DataTable dt = new DataTable();
            ds.Tables.Add(dt);
            ds.Tables[0].Columns.Add("EXCEPTIONAL_CODE");
            ds.Tables[0].Columns.Add("EXCEPTIONAL_DES");
            ds.Tables[0].Columns.Add("UNIT");
            ds.Tables[0].Columns.Add("AUTO_JUDGE_FLAG");

            string tt = Convert.ToString(tempt + 1);
            string cc = txtExcept.Text.Trim();

            ds.Tables[0].Rows.Add(new string[] { tt, cc, "6", "0" });

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmdExcept.Parameters[0].ConstantValue = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
                cmdExcept.Parameters[1].SourceObject = ds;
                //cmdExcept.Parameters[1].SourceProperty = "L3DataTable";
                int iRot = cmdExcept.Execute();
                if (iRot == 0)
                {
                    if (Convert.ToInt32(cmdExcept.Command.Return) == 0)
                    {
                        dsExceptCode.LoadData();
                        MessageBox.Show("异常代码保存成功!");

                        // ds.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("异常代码保存失败!", "提示");
                        txtExcept.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("异常代码保存失败!", "提示");
                    txtExcept.Text = "";
                    return;
                }
            }


        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void pxTextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void pxTextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void pxTextBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTundishNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTundishNo.Text.Trim() != "")
            {
                AppSvrIF.Command cmdSQl = new AppSvrIF.Command();
                string strSQL = string.Format("select TUNDISHID from XGMESLogic\\CCMMag\\CCCM_Tundish_Data where TUNDISHNO = '{0}'", txtTundishNo.Text);
                int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.QueryBySQL, strSQL, "", ref cmdSQl);
                if (iRet != 0)
                {
                    MessageBox.Show(string.Format("查询中包号失败：{1:X}", iRet));
                    return;
                }
                iRet = Adapter.Session.Execute(cmdSQl);
                if (iRet != 0)
                {
                    MessageBox.Show(string.Format("查询中包号失败：{1:X}", iRet));
                    return;
                }
                if (!(cmdSQl.Return is AppSvrIF.Recordset))
                {

                    return;
                }
                AppSvrIF.Recordset rs = cmdSQl.Return as AppSvrIF.Recordset;
                if (rs.Tables[0].Rows.Count < 1)
                {
                    //MessageBox.Show(string.Format("查询出钢计划失败! 无法得到炉号{0}对应的工位！\n未找到炉号对应的计划！",HeatID));
                    return;
                }
                textBox1.Text = rs.Tables[0].Rows[0]["TUNDISHID"].ToString();
                //DataRow row = rs.Tables[0].Rows[0];
            }
        }
        /// <summary>
        /// 查询跟踪值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            string strSql = "select heatid,l1,l2,l3,l4,c_ts from CCCM_ZPGZ_DATA  where heatid='" + tbxHeatID.Text.Trim() + "' order by c_ts desc";
            var dt = UnitMag.MESTool.GetData(Adapter, strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            //MessageBox.Show("操作完成");
        }
        /// <summary>
        /// 从历史库中调取拉速数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            //"HeatID = '" + HeatID + "' order by Change_Time desc,StrandID";
            string strSql = "select * from XGMESHIS.CCCM_HEAT_SPEED_HIS_bak  where heatid='" + tbxHeatID.Text.Trim() + "' order by Change_Time desc,StrandID";
            var dt = UnitMag.MESTool.GetData(Adapter, strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dvSpeed.DataSource = dt;
            }

        }


        /********MODIFY END********/



    }
}