using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;


public struct stctPlanData2
{
    public string PlanID;
    public string SteelGradeIndex;
    public string Pre_SteelGradeIndex;
    public string strBOFID;
    public string strLFID;
    public string strRHID;
    public string strCasterID;
    public string strCCMNo;
    public string dtIronPrepaired;
    public string dtBOFStart;
    public string dtBOFEnd;
    public string dtTappedSideEnd;
    public string dtLFArrivle;
    public string dtLFStart;
    public string dtLFEnd;
    public string dtLFLeave;
    public string dtRHArrivle;
    public string dtRHStart;
    public string dtRHEnd;
    public string dtRHLeave;
    public string dtCasterArrial;
    public string dtCasterStart;
    public string dtCasterEnd;
    public int    nExcuteStatus;
    public int    nBOFStatus;
    public int    nLFStatus;
    public int nRHStatus;
    public int nCasterStatus;
    public int nSideStatus;
    public string nFirHeat;
    public string strHeatID;
    public string strLFTreatNo;
    public string strRHTreatNo;
    public string strCasterTreatNo;
    public int  nGridCols;
    public string strDivHeatID;
    public string strHeatReturnDes;
    public string strRefineType;
    public string strPlanOrderID;
    public string strLength;
    public string strWidth;
    public string strThickness;
    public string strCreateDate;
}


namespace PlanMag
{
    public partial class TappingPlanMainFrm2 : DockContent, IMESForm
    {
        #region MyRegion
        //stctPlanData[] ArrayPlanData;
        // List<stctPlanData> ArrayPlanData = new List<stctPlanData>();
        //出钢计划状态
        const int TAPPING_PLAN_STATUS_UNSEND = 10;//01:未下达
        const int TAPPING_PLAN_STATUS_SEND = 11;//02:已下达
        const int TAPPING_PLAN_STATUS_EXCUTING = 12;//03:执行
        const int TAPPING_PLAN_STATUS_EXCUTED = 13;//04:执行完成


        //出钢计划转炉状态
        const int TAPPING_PLAN_BOF_STATUS_UNEXCUTING = 01;//01:未执行
        const int TAPPING_PLAN_BOF_STATUS_IRON = 02;//02:兑铁
        const int TAPPING_PLAN_BOF_STATUS_BLOW = 03;//03:吹炼开始
        const int TAPPING_PLAN_BOF_STATUS_TAPPING = 04;//03:出钢开始
        const int TAPPING_PLAN_BOF_STATUS_TAPPED = 05;//04:出钢结束


        //出钢计划炉后状态
        const int TAPPING_PLAN_SIDE_STATUS_UNEXCUTING = 01;//01:未执行
        const int TAPPING_PLAN_SIDE_STATUS_BEGIN = 02;//02:处理开始
        const int TAPPING_PLAN_SIDE_STATUS_END = 03;//03:处理结束


        //出钢计划LF炉状态
        const int TAPPING_PLAN_LF_STATUS_UNEXCUTING = 01;//01:未执行
        const int TAPPING_PLAN_LF_STATUS_ARR = 02;//02:进站
        const int TAPPING_PLAN_LF_STATUS_BEGIN = 03;//03:处理开始
        const int TAPPING_PLAN_LF_STATUS_END = 04;//04:处理结束
        const int TAPPING_PLAN_LF_STATUS_LEAVE = 05;//05:出站


        //出钢计划RH炉状态
        const int TAPPING_PLAN_RH_STATUS_UNEXCUTING = 01;//01:未执行
        const int TAPPING_PLAN_RH_STATUS_ARR = 02;//02:进站
        const int TAPPING_PLAN_RH_STATUS_BEGIN = 03;//03:处理开始
        const int TAPPING_PLAN_RH_STATUS_END = 04;//04:处理结束
        const int TAPPING_PLAN_RH_STATUS_LEAVE = 05;//05:出站


        //出钢计划铸机状态
        const int TAPPING_PLAN_CCM_STATUS_UNEXCUTING = 01;//01:未执行
        const int TAPPING_PLAN_CCM_STATUS_ARR = 02;//02:大包到达
        const int TAPPING_PLAN_CCM_STATUS_BEGIN = 03;//03:大包开浇
        const int TAPPING_PLAN_CCM_STATUS_END = 04;//03:浇注结束

        List<stctPlanData2> ArrayPlanData = new List<stctPlanData2>(); //值类型

        private int iSteelBackAppEvent = 0;
        private int iSteelReturnAppEvent = 0;
        private int iSteelDivAppEvent = 0;
        private int iSteelExchangeAppEvent = 0;
        private int iPlanCount1 = 0;
        private int iPlanCount2 = 0;
        private int iPlanCount3 = 0;
        private int iPlanCount4 = 0; 
        #endregion
        

        public TappingPlanMainFrm2()
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

        //出钢计划编制
        private void btnTappingModify_Click(object sender, EventArgs e)
        {
            try
            {
                TappingPlanModifyFrm frm = new TappingPlanModifyFrm();
                frm.ShowDialogEx(Adapter.Session);
            }
            catch { }
        }


        //选择炉座
        private void tscmbBOFID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tscmbCasterID.Text = "-1";
                tstxtBOFID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsBOFID, tscmbBOFID.SelectedItem.ToString());

                cmdQuery.Execute();
                AnalysisPlandata(dsTappingPlan);
            }
            catch { }
        }


        //选择铸机
        private void tscmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tscmbBOFID.Text = "-1";
                tstxtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.SelectedItem.ToString());

                cmdQuery.Execute();
                AnalysisPlandata(dsTappingPlan);
            }
            catch { }
        }

        //加载
        private void TappingPlanMainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
                {
                    tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code_Des"].ToString());
                }
                for (int i = 0; i < dsBOFID.Tables[0].Rows.Count; i++)
                {
                    tscmbBOFID.Items.Add(dsBOFID.Tables[0].Rows[i]["Code_Des"].ToString());
                }

                tscmbBOFID.SelectedIndex = 0;
            }
            catch { }
        }

        //取消出钢计划
        private void btnCancelTappingPlan_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                string check = MessageBox.Show("确认要取消出钢计划么？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                if (check != "OK") return;
                int nRow = dvTapPlan.RowCount;
                dsCmd.Tables[0].Clear();
                for (int i = 0; i < nRow; i += 3)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    dsCmd.Tables[0].Rows.Add(dvTapPlan.Rows[i].Cells[1].Value.ToString());

                }

                cmdTappingCancel.Parameters[0].SourceObject = dsCmd;
                cmdTappingCancel.Execute();
                String returnFlag = cmdTappingCancel.Command.Return.ToString();
                if (returnFlag == "1")
                    MessageBox.Show("取消出钢计划成功！", "提示");
                else
                    MessageBox.Show("取消出钢计划不成功！", "提示");
            }
            catch { }

        }

        //计划下达
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                string check = MessageBox.Show("确认要下达计划么？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                if (check != "OK") return;
                int nRow = dvTapPlan.RowCount;
                dsCmd.Tables[0].Clear();
                for (int i = 0; i < nRow; i += 3)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    dsCmd.Tables[0].Rows.Add(dvTapPlan.Rows[i].Cells[1].Value.ToString());

                }

                cmdTappingSend.Parameters[0].SourceObject = dsCmd;
                cmdTappingSend.Execute();
                String returnFlag = cmdTappingSend.Command.Return.ToString();
                if (returnFlag == "1")
                    MessageBox.Show("计划下达成功！", "提示");
                else
                    MessageBox.Show("计划下达不成功！", "提示");
            }
            catch { }
        }

        //计划下达取消
        private void btnSendCancel_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                string check = MessageBox.Show("确认要取消计划下达么？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                if (check != "OK") return;
                int nRow = dvTapPlan.RowCount;
                dsCmd.Tables[0].Clear();
                for (int i = 0; i < nRow; i += 2)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    dsCmd.Tables[0].Rows.Add(dvTapPlan.Rows[i].Cells[1].Value.ToString());

                }

                cmdTappingSendCancel.Parameters[0].SourceObject = dsCmd;
                cmdTappingSendCancel.Execute();
                String returnFlag = cmdTappingSendCancel.Command.Return.ToString();
                if (returnFlag == "1")
                    MessageBox.Show("取消计划成功！", "提示");
                else
                    MessageBox.Show("取消计划不成功！", "提示");
            }
            catch { }
        }

        //炉座交换
        private void btnHeatExchange_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                string check = MessageBox.Show("确认要交换炉座么？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                if (check != "OK") return;
                int nRow = dvTapPlan.RowCount;
                dsCmd.Tables[0].Clear();
                int nRecordCount = 0;
                for (int i = 0; i < nRow; i += 2)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    dsCmd.Tables[0].Rows.Add(dvTapPlan.Rows[i].Cells[1].Value.ToString());
                    nRecordCount++;
                }
                if (nRecordCount != 2) { MessageBox.Show("只能选两条数据", "提示"); return; }
                cmdExchange.Parameters[0].SourceObject = dsCmd;
                cmdExchange.Execute();
                String returnFlag = cmdExchange.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsErrorHeatExchange, returnFlag);
                if (returnFlag == "0")
                    MessageBox.Show(strReasultShow + "！", "提示");
                else
                    MessageBox.Show("交换炉座不成功！" + strReasultShow, "提示");
            }
            catch { }
        }

        //交换处理顺序
        private void btnOnSeqExchange_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                string check = MessageBox.Show("确认要交换处理顺序么？", "提示",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                if (check != "OK") return;
                int nRow = dvTapPlan.RowCount;
                dsCmd.Tables[0].Clear();
                int nRecordCount = 0;
                for (int i = 0; i < nRow; i += 2)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    dsCmd.Tables[0].Rows.Add(dvTapPlan.Rows[i].Cells[1].Value.ToString());
                    nRecordCount++;
                }
                if (nRecordCount != 2) { MessageBox.Show("只能选两条数据", "提示"); return; }
                cmdExchangeTreatSeq.Parameters[0].SourceObject = dsCmd;
                cmdExchangeTreatSeq.Execute();
                String returnFlag = cmdExchangeTreatSeq.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsErrorExchange, returnFlag);
                if (returnFlag == "0")
                    MessageBox.Show(strReasultShow + "！", "提示");
                else
                    MessageBox.Show("交换处理顺序不成功！" + strReasultShow, "提示");
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //更改工艺路径
        private void btnShowChangeRoute_Click(object sender, EventArgs e)
        {
            try
            {
                dvTapPlan.EndEdit();
                int nRow = dvTapPlan.RowCount;
                int nRecordCount = 0;
                int nCurRow = 0;
                for (int i = 0; i < nRow; i += 2)
                {
                    string strIsSelected = dvTapPlan.Rows[i].Cells[0].Value.ToString();
                    if (strIsSelected == "□") continue;
                    nCurRow = i;
                    nRecordCount++;
                }
                if (nRecordCount != 1) { MessageBox.Show("只能选一条数据", "提示"); return; }
                int nPlanRow = nCurRow / 2;
                dsChangeRoute.Tables[0].Clear();
                DataRow NewRow = dsChangeRoute.Tables[0].NewRow();
                dsChangeRoute.Tables[0].Rows.Add(NewRow);
                dsChangeRoute.Tables[0].Rows[0]["PreHeatID"] = ArrayPlanData[nPlanRow].PlanID;
                dsChangeRoute.Tables[0].Rows[0]["CasterID"] = ArrayPlanData[nPlanRow].strCasterID;
                dsChangeRoute.Tables[0].Rows[0]["BOFID"] = ArrayPlanData[nPlanRow].strBOFID;
                dsChangeRoute.Tables[0].Rows[0]["LFID"] = ArrayPlanData[nPlanRow].strLFID;
                dsChangeRoute.Tables[0].Rows[0]["RHID"] = ArrayPlanData[nPlanRow].strRHID;
                dsChangeRoute.Tables[0].Rows[0]["HeatID"] = ArrayPlanData[nPlanRow].strHeatID;
                dsChangeRoute.Tables[0].Rows[0]["SteelGradeIndex"] = ArrayPlanData[nPlanRow].SteelGradeIndex;

                ChangeRouteFrm frm = new ChangeRouteFrm();
                frm.ShowDialogEx(Adapter.Session, dsChangeRoute);
            }
            catch { }
        }

        //初始化数据
        private void AnalysisPlandata(AppSvrHMI.L3DataSet dsPlanData)
        {
            try
            {
                int nRow = dsPlanData.Tables[0].Rows.Count;
                ArrayPlanData = new List<stctPlanData2>(nRow);
                ArrayPlanData.Clear();
                try
                {
                    for (int i = 0; i < nRow; i++)
                    {
                        stctPlanData2 PlanData = new stctPlanData2();
                        //获取计划基本信息
                        PlanData.PlanID = dsPlanData.Tables[0].Rows[i]["PlanID"].ToString();
                        PlanData.SteelGradeIndex = dsPlanData.Tables[0].Rows[i]["SteelGradeIndex"].ToString();
                        PlanData.Pre_SteelGradeIndex = dsPlanData.Tables[0].Rows[i]["Pre_SteelGradeIndex"].ToString();
                        PlanData.strBOFID = dsPlanData.Tables[0].Rows[i]["BOFID"].ToString();
                        PlanData.strLFID = dsPlanData.Tables[0].Rows[i]["LFID"].ToString();
                        PlanData.strRHID = dsPlanData.Tables[0].Rows[i]["RHID"].ToString();
                        PlanData.strCasterID = dsPlanData.Tables[0].Rows[i]["CasterID"].ToString();
                        PlanData.strCCMNo = dsPlanData.Tables[0].Rows[i]["Casting_No"].ToString() + "-" + dsPlanData.Tables[0].Rows[i]["Casting_Heat_Cnt"].ToString();
                        PlanData.strRefineType = dsPlanData.Tables[0].Rows[i]["Refine_Type"].ToString();
                        PlanData.strDivHeatID = dsPlanData.Tables[0].Rows[i]["Div_HeatID"].ToString();
                        PlanData.strHeatID = dsPlanData.Tables[0].Rows[i]["HeatID"].ToString();
                        PlanData.strRHTreatNo = dsPlanData.Tables[0].Rows[i]["RH_TreatNo"].ToString();
                        PlanData.strLFTreatNo = dsPlanData.Tables[0].Rows[i]["LF_TreatNo"].ToString();
                        PlanData.strCasterTreatNo = dsPlanData.Tables[0].Rows[i]["Caster_TreatNo"].ToString();
                        PlanData.nFirHeat = dsPlanData.Tables[0].Rows[i]["Fir_Heat_Flag"].ToString();
                        PlanData.strHeatReturnDes = dsPlanData.Tables[0].Rows[i]["Steel_Back_Flag"].ToString();
                        PlanData.strPlanOrderID = dsPlanData.Tables[0].Rows[i]["Plan_Ord_ID"].ToString();
                        PlanData.strLength = dsPlanData.Tables[0].Rows[i]["Length"].ToString();
                        PlanData.strWidth = dsPlanData.Tables[0].Rows[i]["Width"].ToString();
                        PlanData.strThickness = dsPlanData.Tables[0].Rows[i]["Thickness"].ToString();
                        PlanData.strCreateDate = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["CreateDate"]).ToString("yyyy-MM-dd");

                        //获取计划时间
                        //if ((dsPlanData.Tables[0].Rows[i]["Aim_Time_IronPrepared"].ToString() != null)&&(dsPlanData.Tables[0].Rows[i]["Aim_Time_IronPrepared"].ToString()!=""))
                        //{
                        //    PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                        //}
                        
                        //PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_BOFStart"]).ToString("HH:mm:ss");
                        //PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_BOFTapped"]).ToString("HH:mm:ss");
                        //PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                        //PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
                        //PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFStart"]).ToString("HH:mm:ss");
                        //PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFLeave"]).ToString("HH:mm:ss");
                        //PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_RHArrival"]).ToString("HH:mm:ss");
                        //PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_RHStart"]).ToString("HH:mm:ss");
                        //PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_RHLeave"]).ToString("HH:mm:ss");
                        //PlanData.dtCasterArrial = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_CasterArrival"]).ToString("HH:mm:ss");
                        //PlanData.dtCasterStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_CastingStart"]).ToString("HH:mm:ss");
                        //PlanData.dtCasterEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_CastingEnd"]).ToString("HH:mm:ss");
                        //获取计划及各工序状态
                        PlanData.nCasterStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["Caster_Status"]);
                        PlanData.nBOFStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["BOF_Status"]);
                        PlanData.nLFStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["LF_Status"]);
                        PlanData.nRHStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["RH_Status"]);
                        PlanData.nExcuteStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["Status"]);
                        PlanData.nSideStatus = Convert.ToInt16(dsPlanData.Tables[0].Rows[i]["Side_Status"]);
                        //根据工序状态将作业时间转换为实际作业时间
                        if (PlanData.nExcuteStatus == TAPPING_PLAN_STATUS_UNSEND || PlanData.nExcuteStatus == TAPPING_PLAN_STATUS_SEND)
                            PlanData.nGridCols = 0;
                        else
                        {
                            if (PlanData.nCasterStatus > TAPPING_PLAN_CCM_STATUS_UNEXCUTING)
                            {
                                switch (PlanData.nCasterStatus)
                                {
                                    case TAPPING_PLAN_CCM_STATUS_ARR:
                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterArrial = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CasterArrival"]).ToString("HH:mm:ss");
                                        PlanData.nGridCols = 16;
                                        break;
                                    case TAPPING_PLAN_CCM_STATUS_BEGIN:
                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterArrial = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CasterArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CastingStart"]).ToString("HH:mm:ss");
                                        PlanData.nGridCols = 17;
                                        break;
                                    case TAPPING_PLAN_CCM_STATUS_END:
                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                        PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterArrial = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CasterArrival"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CastingStart"]).ToString("HH:mm:ss");
                                        PlanData.dtCasterEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_CastingEnd"]).ToString("HH:mm:ss");
                                        PlanData.nGridCols = 18;
                                        break;
                                    default:
                                        break;
                                }

                            }
                            else
                            {
                                if ((PlanData.nRHStatus > TAPPING_PLAN_RH_STATUS_UNEXCUTING) && (PlanData.strRefineType == "LR"))
                                {
                                    switch (PlanData.nRHStatus)
                                    {
                                        case TAPPING_PLAN_RH_STATUS_ARR:
                                            PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                            PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                            PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                            PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                            PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                            PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                            PlanData.nGridCols = 13;
                                            break;
                                        case TAPPING_PLAN_RH_STATUS_BEGIN:
                                        case TAPPING_PLAN_RH_STATUS_END:
                                            PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                            PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                            PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                            PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
                                            PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                            PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                            PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                            PlanData.nGridCols = 14;
                                            break;
                                        case TAPPING_PLAN_RH_STATUS_LEAVE:
                                            PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                            PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                            PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                            PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
                                            PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                            PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                            PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                            PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                            PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                            PlanData.nGridCols = 15;
                                            break;
                                        default:
                                            break;
                                    }


                                    // PlanData.nGridCols = 11;

                                }
                                else
                                {
                                    if ((PlanData.nRHStatus > TAPPING_PLAN_RH_STATUS_UNEXCUTING) && (PlanData.strRefineType == "RL" || PlanData.strRefineType == "R"))
                                    {
                                        switch (PlanData.nRHStatus)
                                        {
                                            case TAPPING_PLAN_RH_STATUS_ARR:
                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                PlanData.nGridCols = 13;
                                                break;
                                            case TAPPING_PLAN_RH_STATUS_BEGIN:
                                            case TAPPING_PLAN_RH_STATUS_END:
                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                                PlanData.nGridCols = 14;
                                                break;
                                            case TAPPING_PLAN_RH_STATUS_LEAVE:
                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                                PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                                PlanData.nGridCols = 15;
                                                break;
                                            default:
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        if ((PlanData.nLFStatus > TAPPING_PLAN_LF_STATUS_UNEXCUTING) && (PlanData.strRefineType == "L" || PlanData.strRefineType == "LR"))
                                        {
                                            switch (PlanData.nLFStatus)
                                            {
                                                case TAPPING_PLAN_LF_STATUS_ARR:
                                                    PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                    PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                    PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                    PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                                    PlanData.nGridCols = 10;
                                                    break;
                                                case TAPPING_PLAN_LF_STATUS_BEGIN:
                                                case TAPPING_PLAN_LF_STATUS_END:
                                                    PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                    PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                    PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                    PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                                    PlanData.nGridCols = 11;
                                                    break;
                                                case TAPPING_PLAN_LF_STATUS_LEAVE:
                                                    PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                    PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                    PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                    PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                                    PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                                    PlanData.nGridCols = 12;
                                                    break;
                                                default:
                                                    break;
                                            }

                                        }
                                        else
                                        {
                                            if ((PlanData.nLFStatus > TAPPING_PLAN_LF_STATUS_UNEXCUTING) && (PlanData.strRefineType == "RL"))
                                            {
                                                switch (PlanData.nLFStatus)
                                                {
                                                    case TAPPING_PLAN_LF_STATUS_ARR:
                                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                                        PlanData.nGridCols = 10;
                                                        break;
                                                    case TAPPING_PLAN_LF_STATUS_BEGIN:
                                                    case TAPPING_PLAN_LF_STATUS_END:
                                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                                        PlanData.nGridCols = 11;
                                                        break;
                                                    case TAPPING_PLAN_LF_STATUS_LEAVE:
                                                        PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                        PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                        PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtRHLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFArrivle = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
                                                        PlanData.dtLFLeave = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
                                                        PlanData.nGridCols = 12;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                if (PlanData.nSideStatus > TAPPING_PLAN_SIDE_STATUS_UNEXCUTING)
                                                {
                                                    switch (PlanData.nSideStatus)
                                                    {
                                                        case TAPPING_PLAN_SIDE_STATUS_BEGIN:
                                                            PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                            PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                            PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                            PlanData.nGridCols = 8;
                                                            break;
                                                        case TAPPING_PLAN_SIDE_STATUS_END:
                                                            PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                            PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                            PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                            PlanData.dtTappedSideEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                                                            PlanData.nGridCols = 9;
                                                            break;
                                                        default:
                                                            break;

                                                    }

                                                }
                                                else
                                                {
                                                    if (PlanData.nBOFStatus > TAPPING_PLAN_BOF_STATUS_UNEXCUTING)
                                                    {
                                                        switch (PlanData.nBOFStatus)
                                                        {
                                                            case TAPPING_PLAN_BOF_STATUS_IRON:
                                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                                PlanData.nGridCols = 6;
                                                                break;
                                                            case TAPPING_PLAN_BOF_STATUS_BLOW:
                                                            case TAPPING_PLAN_BOF_STATUS_TAPPING:
                                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                                PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                                PlanData.nGridCols = 7;
                                                                break;
                                                            case TAPPING_PLAN_BOF_STATUS_TAPPED:
                                                                PlanData.dtIronPrepaired = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                                                                PlanData.dtBOFStart = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
                                                                PlanData.dtBOFEnd = Convert.ToDateTime(dsPlanData.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
                                                                PlanData.nGridCols = 8;
                                                                break;
                                                            default:
                                                                break;
                                                        }
                                                    }

                                                }

                                            }

                                        }
                                    }

                                }

                            }
                        }

                        ArrayPlanData.Add(PlanData);
                    }//for
                }
                catch { }

                //清空GRID数据
                dvTapPlan.Rows.Clear();
                //将结构数组的值赋予GRID
                dvTapPlan.RowCount = nRow * 2;

                for (int j = 0; j < nRow; j++)
                {
                    //1行赋值
                    dvTapPlan.Rows[j * 2].Cells[0].Value = "□";
                    dvTapPlan.Rows[j * 2].Cells[1].Value = ArrayPlanData[j].PlanID;
                    dvTapPlan.Rows[j * 2].Cells[2].Value = ArrayPlanData[j].Pre_SteelGradeIndex;
                    dvTapPlan.Rows[j * 2].Cells[3].Value = ArrayPlanData[j].SteelGradeIndex;
                    dvTapPlan.Rows[j * 2].Cells[4].Value = ArrayPlanData[j].strCasterID;
                    dvTapPlan.Rows[j * 2].Cells[5].Value = ArrayPlanData[j].strCreateDate;
                    dvTapPlan.Rows[j * 2].Cells[6].Value = ArrayPlanData[j].dtIronPrepaired;
                    dvTapPlan.Rows[j * 2].Cells[7].Value = ArrayPlanData[j].dtBOFStart;
                    dvTapPlan.Rows[j * 2].Cells[8].Value = ArrayPlanData[j].dtBOFEnd;
                    dvTapPlan.Rows[j * 2].Cells[9].Value = ArrayPlanData[j].dtTappedSideEnd;
                    dvTapPlan.Rows[j * 2].Cells[10].Value = ArrayPlanData[j].dtLFArrivle;
                    dvTapPlan.Rows[j * 2].Cells[11].Value = ArrayPlanData[j].dtLFStart;
                    dvTapPlan.Rows[j * 2].Cells[12].Value = ArrayPlanData[j].dtLFLeave;
                    dvTapPlan.Rows[j * 2].Cells[13].Value = ArrayPlanData[j].dtRHArrivle;
                    dvTapPlan.Rows[j * 2].Cells[14].Value = ArrayPlanData[j].dtRHStart;
                    dvTapPlan.Rows[j * 2].Cells[15].Value = ArrayPlanData[j].dtRHLeave;
                    dvTapPlan.Rows[j * 2].Cells[16].Value = ArrayPlanData[j].dtCasterArrial;
                    dvTapPlan.Rows[j * 2].Cells[17].Value = ArrayPlanData[j].dtCasterStart;
                    dvTapPlan.Rows[j * 2].Cells[18].Value = ArrayPlanData[j].dtCasterEnd;
                    //2行赋值
                    object Obj = new object();
                    //获取钢种20081222
                    string strUri = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\";
                    string strSteelGradeIndex = ArrayPlanData[j].Pre_SteelGradeIndex;
                    string strObjUri = strUri + strSteelGradeIndex;
                    Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                    dvTapPlan.Rows[j * 2 + 1].Cells[2].Value = Obj.ToString();

                    strSteelGradeIndex = ArrayPlanData[j].SteelGradeIndex;
                    strObjUri = strUri + strSteelGradeIndex;
                    Adapter.Session.Get(strObjUri, "SteelGrade", ref Obj);
                    dvTapPlan.Rows[j * 2 + 1].Cells[3].Value = Obj.ToString();
                    dvTapPlan.Rows[j * 2 + 1].Cells[4].Value = "定尺" + ArrayPlanData[j].strLength;
                    dvTapPlan.Rows[j * 2 + 1].Cells[6].Value = ArrayPlanData[j].strBOFID;
                    dvTapPlan.Rows[j * 2 + 1].Cells[7].Value = ArrayPlanData[j].strHeatID;
                    dvTapPlan.Rows[j * 2 + 1].Cells[8].Value = ArrayPlanData[j].strDivHeatID;
                    dvTapPlan.Rows[j * 2 + 1].Cells[9].Value = ArrayPlanData[j].strRefineType;
                    if (ArrayPlanData[j].strLFID != "0")
                        dvTapPlan.Rows[j * 2 + 1].Cells[10].Value = ArrayPlanData[j].strLFID;
                    dvTapPlan.Rows[j * 2 + 1].Cells[11].Value = ArrayPlanData[j].strLFTreatNo;
                    if (ArrayPlanData[j].strRHID != "0")
                        dvTapPlan.Rows[j * 2 + 1].Cells[13].Value = ArrayPlanData[j].strRHID;
                    dvTapPlan.Rows[j * 2 + 1].Cells[14].Value = ArrayPlanData[j].strRHTreatNo;
                    dvTapPlan.Rows[j * 2 + 1].Cells[16].Value = ArrayPlanData[j].strCasterTreatNo;
                    //dvTapPlan.Rows[j*3 + 1].Cells[18].Value = ArrayPlanData[j].strThickness + "*" + ArrayPlanData[j].strWidth + "*" + ArrayPlanData[j].strLength;

                    /******Modify by hyh 2011-5-16******/
                    //3行赋值
                    //dvTapPlan.Rows[j * 2+2].Cells[0].Value = "□";
                    //dvTapPlan.Rows[j * 3 + 2].Cells[1].Value = "计划时间：";
                    ////dvTapPlan.Rows[j * 3 + 2].Cells[2].Value = ArrayPlanData[j].Pre_SteelGradeIndex;
                    ////dvTapPlan.Rows[j * 3 + 2].Cells[3].Value = ArrayPlanData[j].SteelGradeIndex;
                    ////dvTapPlan.Rows[j * 3 + 2].Cells[4].Value = "计划时间";
                    //dvTapPlan.Rows[j * 3 + 2].Cells[5].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["CreateDate"]).ToString("yyyy-MM-dd");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[6].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[7].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_BOFStart"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[8].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_BOFTapped"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[9].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_TappedSideEnd"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[10].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[11].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_LFStart"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[12].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_LFLeave"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[13].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_RHArrival"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[14].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_RHStart"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[15].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_RHLeave"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[16].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_CasterArrival"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[17].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_CastingStart"]).ToString("HH:mm:ss");
                    //dvTapPlan.Rows[j * 3 + 2].Cells[18].Value = Convert.ToDateTime(dsPlanData.Tables[0].Rows[j]["Aim_Time_CastingEnd"]).ToString("HH:mm:ss");

                    /*******END******/
                }

                /***************************************************/
                try
                {
                    for (int iRowIndex = 0; iRowIndex < dvTapPlan.Rows.Count; iRowIndex++)
                    {
                        for (int iColIndex = 0; iColIndex < dvTapPlan.Columns.Count; iColIndex++)
                        {
                            //改变单元格的颜色，当数据为空时退出
                            if (ArrayPlanData.Count < 1 || iRowIndex < 0)
                                return;

                            //根据计划的状态修改偶数行单元格的颜色
                            switch (ArrayPlanData[iRowIndex / 2].nExcuteStatus)
                            {
                                case TAPPING_PLAN_STATUS_UNSEND://01:未下达
                                    if (iColIndex > 0 && iRowIndex % 2 == 0)
                                        dvTapPlan.Rows[iRowIndex].DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case TAPPING_PLAN_STATUS_SEND://02:已下达
                                    if (iColIndex > 0 && iRowIndex % 2 == 0)
                                        dvTapPlan.Rows[iRowIndex].DefaultCellStyle.ForeColor = Color.Yellow;
                                    break;
                                case TAPPING_PLAN_STATUS_EXCUTING://03:执行
                                    if (iColIndex > 0 && iColIndex < ArrayPlanData[iRowIndex / 2].nGridCols && iRowIndex % 2 == 0)
                                        dvTapPlan.Rows[iRowIndex].Cells[iColIndex].Style.BackColor = Color.Red;
                                    else
                                        if (iColIndex > 0 && iColIndex == ArrayPlanData[iRowIndex / 2].nGridCols && iRowIndex % 2 == 0)
                                            dvTapPlan.Rows[iRowIndex].Cells[ArrayPlanData[iRowIndex / 2].nGridCols].Style.ForeColor = Color.Red;
                                    break;
                                case TAPPING_PLAN_STATUS_EXCUTED://04:执行完成
                                    if (iColIndex > 0 && iRowIndex % 2 == 0)
                                        dvTapPlan.Rows[iRowIndex].DefaultCellStyle.BackColor = Color.Red;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                catch { }
                /***************************************************/
            }
            catch { }
        }

        private void dvTapPlan_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                //修改第一列的值
                if (e.ColumnIndex == 0)
                {
                    if (e.RowIndex % 2 == 0)
                    {
                        string strValur = dvTapPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        if (strValur == "√")
                            dvTapPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "□";
                        else
                            dvTapPlan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "√";
                    }
                }
            }
            catch { }
        }

        //private void dvTapPlan_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    //改变单元格的颜色，当数据为空时退出
        //    if (ArrayPlanData.Count < 1 || e.RowIndex < 0)
        //        return;
        //    int nRow = e.RowIndex;
        //    //根据计划的状态修改偶数行单元格的颜色
        //    switch (ArrayPlanData[nRow / 2].nExcuteStatus)
        //    {
        //        case TAPPING_PLAN_STATUS_UNSEND://01:未下达
        //            if (e.ColumnIndex > 0 && nRow % 2 == 0)
        //                dvTapPlan.Rows[nRow].DefaultCellStyle.ForeColor = Color.White;
        //            break;
        //        case TAPPING_PLAN_STATUS_SEND://02:已下达
        //            if (e.ColumnIndex > 0 && nRow % 2 == 0)
        //                dvTapPlan.Rows[nRow].DefaultCellStyle.ForeColor = Color.Yellow;
        //            break;
        //        case TAPPING_PLAN_STATUS_EXCUTING://03:执行
        //            if (e.ColumnIndex > 0 && e.ColumnIndex < ArrayPlanData[nRow / 2].nGridCols && nRow % 2 == 0)
        //                dvTapPlan.Rows[nRow].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
        //            else
        //                if (e.ColumnIndex > 0 && e.ColumnIndex == ArrayPlanData[nRow / 2].nGridCols && nRow % 2 == 0)
        //                    dvTapPlan.Rows[nRow].Cells[ArrayPlanData[nRow / 2].nGridCols].Style.ForeColor = Color.Red;
        //            break;
        //        case TAPPING_PLAN_STATUS_EXCUTED://04:执行完成
        //            if (e.ColumnIndex > 0 && nRow % 2 == 0)
        //                dvTapPlan.Rows[nRow].DefaultCellStyle.BackColor = Color.Red;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void l3DataBoxTapEvent_TextChanged ( object sender , EventArgs e )
        {
            try
            {
                cmdQuery.Execute();
                AnalysisPlandata(dsTappingPlan);
            }
            catch { }
        }
       
        ////计划强制结束
        //private void btnDispAccount_Click(object sender, EventArgs e)
        //{
        //dvTapPlan.EndEdit();
        //string check = MessageBox.Show( "确认要强制结束该计划么？" , "提示" , MessageBoxButtons.OKCancel ).ToString();
        //if ( check == "Cancel" ) return;
        //int nRow = dvTapPlan.RowCount;
        //dsCmd.Tables [0].Clear();
        //for ( int i = 0 ; i < nRow ; i += 2 )
        //{
        //    string strIsSelected = dvTapPlan.Rows [i].Cells [0].Value.ToString();
        //    if ( strIsSelected == "□" ) continue;
        //    dsCmd.Tables [0].Rows.Add( dvTapPlan.Rows [i].Cells [1].Value.ToString() );

        //}

        //cmdStopPlan.Parameters [0].SourceObject = dsCmd;
        //cmdStopPlan.Execute();
        //String returnFlag = cmdStopPlan.Command.Return.ToString();
        //if ( returnFlag == "1" )
        //    MessageBox.Show( "强制结束计划成功！" , "提示" );
        //else
        //    MessageBox.Show( "强制结束计划不成功！" , "提示" );


        //}

        TappingActFrm BOFStatus = new TappingActFrm();
        private void btnBOFStatus_Click ( object sender , EventArgs e )
        {
            BOFStatus.ShowDialogEx( Adapter.Session );
        }

        private void dbxSteelReturnAppEvent_TextChanged ( object sender , EventArgs e )
        {
            try
            {
                if (iSteelReturnAppEvent == 0)
                {
                    iSteelReturnAppEvent += 1;
                    return;
                }
                MessageBox.Show("工序有新的钢水回炉申请！\n请到调度管理模块下进行相应处理", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxSteelBackAppEvent_TextChanged ( object sender , EventArgs e )
        {
            try
            {
                if (iSteelBackAppEvent == 0)
                {
                    iSteelBackAppEvent += 1;
                    return;
                }
                MessageBox.Show("工序有新的钢水返送申请！\n请到调度管理模块下进行相应处理", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxSteelDivAppEvent_TextChanged ( object sender , EventArgs e )
        {
            try
            {
                if (iSteelDivAppEvent == 0)
                {
                    iSteelDivAppEvent += 1;
                    return;
                }
                MessageBox.Show("工序有新的钢水炉次分割申请！\n请到调度管理模块下进行相应处理", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxSteelExchangeAppEvent_TextChanged ( object sender , EventArgs e )
        {
            if (iSteelExchangeAppEvent == 0)
            {
                iSteelExchangeAppEvent += 1;
                return;
            }
            MessageBox.Show( "工序有新的钢水改钢申请！\n请到调度管理模块下进行相应处理" , "提示" , MessageBoxButtons.OK );
        }

        private void TappingPlanMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CommDataMag.CommonMethed.FlushMemory();
            }
            catch { }
        }

        //调度台账管理
        private void btnDispAccount_Click_1(object sender, EventArgs e)
        {
            try
            {
                DispAccountFrm frm = new DispAccountFrm();
                frm.ShowDialogEx(Adapter.Session);
            }
            catch { }
        }

        //界面可见性变化时
        private void TappingPlanMainFrm_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                if (!this.Visible)
                {
                    l3DataBoxTapEvent.L3DataAdapter = null;
                }
                else
                {
                    l3DataBoxTapEvent.L3DataAdapter = Adapter;
                    cmdQuery.Execute();
                    AnalysisPlandata(dsTappingPlan);
                }
            }
            catch { }
        }

        private void dbxPlanCount1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (iPlanCount1 == 0)
                {
                    iPlanCount1 += 1;
                    return;
                }
                MessageBox.Show("1#转炉生产订单不足三炉，请下达生产计划！", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxPlanCount2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (iPlanCount2 == 0)
                {
                    iPlanCount2 += 1;
                    return;
                }
                MessageBox.Show("2#转炉生产订单不足三炉，请下达生产计划！", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxPlanCount3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (iPlanCount3 == 0)
                {
                    iPlanCount3 += 1;
                    return;
                }
                MessageBox.Show("3#转炉生产订单不足三炉，请下达生产计划！", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }

        private void dbxPlanCount4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (iPlanCount4 == 0)
                {
                    iPlanCount4 += 1;
                    return;
                }
                MessageBox.Show("4#转炉生产订单不足三炉，请下达生产计划！", "提示", MessageBoxButtons.OK);
            }
            catch { }
        }
    }
}