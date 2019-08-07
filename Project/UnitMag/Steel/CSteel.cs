using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using UnitMag.MELTMag;


namespace UnitMag.Steel
{



    //public enum UnitType : int
    //{
    //    DEP = 10,
    //    BOF = 20,
    //    LF = 40,
    //    CCM = 60,
    //    MELT = 70,

    //}
    public partial class CSteel : DockContent, IMESForm
    {



        public CSteel()
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

        public int CurUnitID = 1;
        public UnitType MainUnitType = UnitType.BOF ;


        public string HeatID
        {
            get
            {
                string id = "";
                switch (MainUnitType)
                {
                    case UnitType.MELT: id = txtBOFHeatID.Text; break;
                    //case UnitType.TAP: id = txtTAPHeatID.Text; break;
                    case UnitType.LF: id = LFAreaInfo.HeatID; break;
                    //case UnitType.RH: id = RHAreaInfo.HeatID; break;
                    case UnitType.CCM: id = txtCCMHeatID.Text; break;
                }
                return id;
            }
        }

        protected UnitMag.MELTMag.ucMELTData MELTData = null;
        protected UnitMag.LFMag.ucLFData LFData = null;
        protected UnitMag.RHMag.ucRHData RHData = null;
        protected UnitMag.CCMMag.ucCCMData CCMData = null;
        protected UnitMag.CCMMag.ucCCMDataFor07 CCMDataFor07 = null;

        ///*******Modify Begin At2011-02-23 By Huyunhai *******/
        //int isCCM07 = 0;
        ///****Modify END ******/

        private string strBOFID = "S26";
        private string strLFID = "S44";
        private string strRHID = "";
        private string strCCMID = "S66";

        protected string GetUnitObjID(UnitType type, int id)
        {
            string strID = string.Format("S{0}", type + id);
            return strID;
        }

        protected int ParseUnitID(string UnitObjID)
        {
            return int.Parse(UnitObjID.Substring(UnitObjID.Length - 1, 1));
        }

        //2009-03-17 //转炉
        protected void SetBOFTapAdapter(bool bSet)
        {
            if (bSet)
            {
                BOFStatus.L3Adapter = Adapter;


                txtBOFHeatID.L3DataAdapter = Adapter;
                txtBOFSteelGradeIndex.L3DataAdapter = Adapter;
                txtBOFIronWeight.L3DataAdapter = Adapter;
                txtBOFBlowTime.L3DataAdapter = Adapter;
                txtBOFNextHeatID.L3DataAdapter = Adapter;
                //txtAODStep.L3DataAdapter = Adapter;


            }
            else
            {
                BOFStatus.L3Adapter = null;


                txtBOFHeatID.L3DataAdapter = null;
                txtBOFSteelGradeIndex.L3DataAdapter = null;
                txtBOFIronWeight.L3DataAdapter = null;
                txtBOFBlowTime.L3DataAdapter = null;
                txtBOFNextHeatID.L3DataAdapter = null;
                //txtAODStep.L3DataAdapter = null;


            }
        }

        //LF
        protected void SetLFAdapter(bool bSet)
        {
            if (bSet)
            {
                ucLFStatus.L3Adapter = Adapter;
                LFAreaInfo.Adapter = Adapter;
                dbxEquStaLF.L3DataAdapter = Adapter;

                txtLFTreatNo.L3DataAdapter = Adapter;
                txtLFProcessTime.L3DataAdapter = Adapter;
                txtLFTemp.L3DataAdapter = Adapter;
                txtWeightHeatID.L3DataAdapter = Adapter;//2009-05-21
            }
            else
            {
                ucLFStatus.L3Adapter = null;
                LFAreaInfo.Adapter = null;
                dbxEquStaLF.L3DataAdapter = null;

                txtLFTreatNo.L3DataAdapter = null;
                txtLFProcessTime.L3DataAdapter = null;
                txtLFTemp.L3DataAdapter = null;
                txtWeightHeatID.L3DataAdapter = null;//2009-05-21
            }
        }

        //RH
        protected void SetRHAdapter(bool bSet)
        {
            if (bSet)
            {
                //ucRHStatus.L3Adapter = Adapter;
                //RHAreaInfo.Adapter = Adapter;
                dbxEquStaRH.L3DataAdapter = Adapter;

                //txtRHTreatNo.L3DataAdapter = Adapter;
                //txtRHProcTime.L3DataAdapter = Adapter;
                //txtRHTemp.L3DataAdapter = Adapter;
            }
            else
            {
                //ucRHStatus.L3Adapter = null;
                //RHAreaInfo.Adapter = null;
                dbxEquStaRH.L3DataAdapter = null;

                //txtRHTreatNo.L3DataAdapter = null;
                //txtRHProcTime.L3DataAdapter = null;
                //txtRHTemp.L3DataAdapter = null;
            }
        }

        //CCM
        protected void SetCCMAdapter(bool bSet)
        {
            if (bSet)
            {
                dbxEquStaCCM.L3DataAdapter = Adapter;
                ucCCMStatus.L3Adapter = Adapter;

                txtStartCastingTime.L3DataAdapter = Adapter;
                txtArriveTime.L3DataAdapter = Adapter;
                txtCCMTreatNo.L3DataAdapter = Adapter;
                txtCCMHeatID.L3DataAdapter = Adapter;
                txtCCMLadleNo.L3DataAdapter = Adapter;
                txtCCMSteelGradeIndex.L3DataAdapter = Adapter;
                txtCCMSteelWeight.L3DataAdapter = Adapter;
                txtCCMCastingID.L3DataAdapter = Adapter;
                txtCCMTundishNo.L3DataAdapter = Adapter;
                txtCCMNextHeatID.L3DataAdapter = Adapter;
                txtCCMNextLadleID.L3DataAdapter = Adapter;
                l3DataBox1.L3DataAdapter = Adapter;
            }
            else
            {
                dbxEquStaCCM.L3DataAdapter = null;
                ucCCMStatus.L3Adapter = null;

                txtStartCastingTime.L3DataAdapter = null;
                txtArriveTime.L3DataAdapter = null;
                txtCCMTreatNo.L3DataAdapter = null;
                txtCCMHeatID.L3DataAdapter = null;
                txtCCMLadleNo.L3DataAdapter = null;
                txtCCMSteelGradeIndex.L3DataAdapter = null;
                txtCCMSteelWeight.L3DataAdapter = null;
                txtCCMCastingID.L3DataAdapter = null;
                txtCCMTundishNo.L3DataAdapter = null;
                txtCCMNextHeatID.L3DataAdapter = null;
                txtCCMNextLadleID.L3DataAdapter = null;
                l3DataBox1.L3DataAdapter = null;
            }
        }

        protected UnitType ParseUnitType(string UnitObjID)
        {
            string strType = UnitObjID.Substring(UnitObjID.Length - 2, 1);
            int iType = int.Parse(strType);
            iType *= 10;
            return (UnitType)iType;
        }

        protected void SetUnitID(UnitType type, int id)
        {
            this.menuBOF.ResumeLayout(false);
            //Adapter.set_URIParameters("DEPID", "S91");

            Adapter.set_URIParameters("MELTID", "S26");
            SetBOFTapAdapter(true);
            Adapter.set_URIParameters("LFID", "S44");
            SetLFAdapter(true);
            Adapter.set_URIParameters("CCMID", "S66");
            SetCCMAdapter(true);
        }

        protected void ShowUnitDetails(UnitType type,int ccmNum)
        {
            if (type == UnitType.BOF )
            {
                if (MELTData == null)
                {
                    MELTData = new ucMELTData();
                    panelUnit.Controls.Add(MELTData);
                    MELTData.Dock = DockStyle.Fill;
                    MELTData.Visible = false;
                    MELTData.Session = Adapter.Session;

                    /**********L***********/
                    if (strBOFID.Length == 3)
                    {
                        MELTData.UnitID = strBOFID;//L
                        int iBOFid = Convert.ToInt16(strBOFID.Substring(2, 1));//L
                        Adapter.set_URIParameters("MELTID", "S26");//L
                        //Adapter.set_URIParameters("TAPID", GetUnitObjID(UnitType.TAP, iBOFid));//L
                    }
                    else
                    {
                        MELTData.UnitID = "";
                        Adapter.DeleteURIParameter("MELTID");
                        //Adapter.DeleteURIParameter("TAPID");
                    }
                    /****************************/
                }
                MELTData.Visible = true;
            }
            else if (MELTData != null)
                MELTData.Visible = false;

            if (type == UnitType.LF)
            {
                if (LFData == null)
                {
                    LFData = new UnitMag.LFMag.ucLFData();
                    panelUnit.Controls.Add(LFData);
                    LFData.Dock = DockStyle.Fill;
                    LFData.Visible = false;
                    LFData.Session = Adapter.Session;
                    /*********************************/
                    if (strLFID.Length == 3)
                    {
                        LFData.UnitID = strLFID;//L
                        Adapter.set_URIParameters("LFID", strLFID);//L
                    }
                    else
                        Adapter.DeleteURIParameter("LFID");
                    /**********************************/
                }
                LFData.Visible = true;
            }
            else if (LFData != null)
                LFData.Visible = false;

            if (type == UnitType.RH)
            {
                if (RHData == null)
                {
                    RHData = new UnitMag.RHMag.ucRHData();
                    panelUnit.Controls.Add(RHData);
                    RHData.Dock = DockStyle.Fill;
                    RHData.Visible = false;
                    RHData.Session = Adapter.Session;

                    /*********************************/
                    if (strRHID.Length == 3)
                    {
                        RHData.UnitID = strRHID;//L
                        Adapter.set_URIParameters("RHID", strRHID);
                    }
                    else
                        Adapter.DeleteURIParameter("RHID");
                    /**********************************/
                }
                RHData.Visible = true;
            }
            else if (RHData != null)
                RHData.Visible = false;
           
 
            /**********Modify Begin At 2011-02-23 By Huyunhai***************/


          

          
           // isCCM07 
        


            //连铸机
            if ((type == UnitType.CCM)&&(ccmNum!=7))
            {
                
                if (CCMData == null)
                {
                  
                        CCMData = new UnitMag.CCMMag.ucCCMData();

                    panelUnit.Controls.Add(CCMData);
                    CCMData.Dock = DockStyle.Fill;
                    CCMData.Visible = false;
                    CCMData.Session = Adapter.Session;

                    /*********************************/
                    if (strCCMID.Length == 3)
                    {
                        CCMData.UnitID = strCCMID;//L
                        Adapter.set_URIParameters("CCMID", strCCMID);
                    }
                    else
                        Adapter.DeleteURIParameter("CCMID");
                    /**********************************/
                }
                CCMData.Visible = true;

            }
            else if (CCMData != null)
                CCMData.Visible = false;

            //专为7#铸机


            if ((type == UnitType.CCM) && (ccmNum == 7))
            {
                //tt = true;
                if (CCMDataFor07 == null)
                {

                    CCMDataFor07 = new UnitMag.CCMMag.ucCCMDataFor07();
                   
                    panelUnit.Controls.Add(CCMDataFor07);
                    CCMDataFor07.Dock = DockStyle.Fill;
                    CCMDataFor07.Visible = false;
                    CCMDataFor07.Session = Adapter.Session;

                    /*********************************/
                    if (strCCMID.Length == 3)
                    {
                        CCMDataFor07.UnitID = strCCMID;//L
                        Adapter.set_URIParameters("CCMID", strCCMID);
                    }
                    else
                        Adapter.DeleteURIParameter("CCMID");
                    /**********************************/
                }
                CCMDataFor07.Visible = true;

            }
            else if (CCMDataFor07 != null)
                CCMDataFor07.Visible = false;

            /*******Modify END**********/

            tabPageBOF.BackColor = type == UnitType.BOF ? SystemColors.GradientActiveCaption : Color.Transparent;
            tabPageLF.BackColor = type == UnitType.LF ? SystemColors.GradientActiveCaption : Color.Transparent;
            //tabPageRH.BackColor = type == UnitType.RH ? SystemColors.GradientActiveCaption : Color.Transparent;
            tabPageCCM.BackColor = type == UnitType.CCM ? SystemColors.GradientActiveCaption : Color.Transparent;
        }

        protected void SwitchHeatID()
        {
            // Query unit id for this heat id
            if (Adapter.Session == null || !Adapter.Session.Opened)
                return;

            Adapter.RefreshDataBindings();
            AppSvrIF.Command cmdSQl = new AppSvrIF.Command();
            string strSQL = string.Format("select BOFID,LFID,RHID,CasterID from XGMESLogic\\PlanMag\\CPlan_Tapping where HeatID = '{0}'", HeatID);
            int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.QueryBySQL, strSQL, "", ref cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show(string.Format("查询出钢计划失败! 无法得到炉号{0}对应的工位！\n错误代码：{1:X}", HeatID, iRet));
                return;
            }
            iRet = Adapter.Session.Execute(cmdSQl);
            if (iRet != 0)
            {
                MessageBox.Show(string.Format("查询出钢计划失败! 无法得到炉号{0}对应的工位！\n错误代码：{1:X}", HeatID, iRet));
                return;
            }
            if (!(cmdSQl.Return is AppSvrIF.Recordset))
            {
                MessageBox.Show(string.Format("查询出钢计划失败! 无法得到炉号{0}对应的工位！\n返回的不是记录集！", HeatID));
                return;
            }
            AppSvrIF.Recordset rs = cmdSQl.Return as AppSvrIF.Recordset;
            if (rs.Tables[0].Rows.Count < 1)
            {
                //MessageBox.Show(string.Format("查询出钢计划失败! 无法得到炉号{0}对应的工位！\n未找到炉号对应的计划！",HeatID));
                return;
            }
            DataRow row = rs.Tables[0].Rows[0];

            ///******Modify Begin At 2011-02-23 By Huyunhai*********/
            //isCCM07 = ParseUnitID(row["CasterID"].ToString());
            ///********Modify END********/

            if (MainUnitType != UnitType.BOF && MainUnitType != UnitType.TAP) SetUnitID(UnitType.BOF, ParseUnitID(row["BOFID"].ToString()));
            if (MainUnitType != UnitType.LF) SetUnitID(UnitType.LF, ParseUnitID(row["LFID"].ToString()));
            if (MainUnitType != UnitType.RH) SetUnitID(UnitType.RH, ParseUnitID(row["RHID"].ToString()));
            if (MainUnitType != UnitType.CCM) SetUnitID(UnitType.CCM, ParseUnitID(row["CasterID"].ToString()));

        }

        protected void Start()
        {
            SetUnitID(MainUnitType, CurUnitID);
            ShowUnitDetails(MainUnitType,8);
            SwitchHeatID();
            Adapter.RefreshDataBindings();
        }

        private void UnitMagMainFrm_Load(object sender, EventArgs e)
        {
            Start();
            string strFmt = "";
            switch (MainUnitType)
            {
                case UnitType.MELT:
                    {

                        tabCtrlBOF.ContextMenuStrip = menuBOF;
                        tabCtrlBOF_Click(sender, e);
                        //if (CurUnitID == 5)
                        //{ }
                       TabText = "熔化炉工序管理";

                    }
                    break;
                case UnitType.RH:
                    {

                        //tabCtrlRH.ContextMenuStrip = menuRH;
                        tabCtrlRH_Click(sender, e);
                        TabText = "RH炉工序管理";
                    }
                    break;
                case UnitType.LF:
                    {
                        tabCtrlLF.ContextMenuStrip = menuLF;
                        tabCtrlLF_Click(sender, e);
                        TabText = "4#LF工序管理";
                    }
                    break;

                case UnitType.CCM:
                    {

                        tabCtrlCCM.ContextMenuStrip = menuCCM;
                        tabCtrlCCM_Click(sender, e);
                        TabText = "6#连铸机工序管理";
                    }
                    break;
            }
            //TabText = string.Format(strFmt, CurUnitID);
           
            //tabCtrlCCM_Click(sender, e);
        }

        private void tabCtrlBOF_Click(object sender, EventArgs e)
        {
            ShowUnitDetails(UnitType.BOF,8);
        }

        private void tabCtrlLF_Click(object sender, EventArgs e)
        {
            ShowUnitDetails(UnitType.LF,8);
        }

        private void tabCtrlRH_Click(object sender, EventArgs e)
        {
            ShowUnitDetails(UnitType.RH,8);
        }

        private void tabCtrlCCM_Click(object sender, EventArgs e)
        {
            /***********Modify Begin At 2011-02-23 By Huyunhai*************/
            string d = sender.ToString();
            int flag = 0;
            //for (int i = 0; i < d.Length; i++)
            //{
            //   //if (d[i]=='号')
            //   //{
            //   //    flag = i;
            //   //    break;
            //   //}             
            //}
            //if ((flag!=0)&&(flag!=d.Length))
            //{
            //    //string t = d[flag - 1].ToString();
            //    //int ccmNum = Convert.ToInt32(t);  
            //    //ShowUnitDetails(UnitType.CCM, ccmNum);
            //}

            if (d.Contains("CCMMain07") || d.Contains("7号铸机"))
            {
                ShowUnitDetails(UnitType.CCM, 7);
            }
            else
                ShowUnitDetails(UnitType.CCM, 8);                            
          
            /*********Modify END***********/
           
          
        }

        private void menuBOFProp_Click(object sender, EventArgs e)
        {
            MELTAttributeFrm dlg = new MELTAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        //指定主原料
        private void menuBOFDesignateMat_Click(object sender, EventArgs e)
        {
            //modify by hyh 2012-04-24
            //BOFDesignateMatFrm dlg = new BOFDesignateMatFrm();
            MELTDesignateMaterialFrm dlg = new MELTDesignateMaterialFrm();
            //end

            dlg.ShowDialogEx(Adapter.Session, "S51");
        }

        private void menuBOFDevStatus_Click(object sender, EventArgs e)
        {
            //MELTEquStatusFrm dlg = new MELTEquStatusFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFFixData_Click(object sender, EventArgs e)
        {
            //BOFHeatFinalDataFrm dlg = new BOFHeatFinalDataFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFEvents_Click(object sender, EventArgs e)
        {
            //BOFHeatRemarkFrm dlg = new BOFHeatRemarkFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFStackMaintain_Click(object sender, EventArgs e)
        {
            //MELTStackMagFrm dlg = new MELTStackMagFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        //private void menuBOFFailure_Click(object sender, EventArgs e)
        //{
        //    BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
        //    dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        //}

        private void menuBOFChangeGrade_Click(object sender, EventArgs e)
        {
            MELTChangeGradeFrm dlg = new MELTChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFDutyMag_Click(object sender, EventArgs e)
        {
            //DutyMagFrm dlg = new DutyMagFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFAnalysRequest_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuTAPStartProc_Click(object sender, EventArgs e)
        {
            TAPMag.TAPStartFrm dlg = new UnitMag.TAPMag.TAPStartFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        private void menuTAPStopProc_Click(object sender, EventArgs e)
        {
            int iRet = cmdTappingSideEnd.Execute();
            if (iRet != 0 || (short)cmdTappingSideEnd.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdTappingSideEnd.Command.ErrorCode));
                MessageBox.Show("处理结束失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("处理结束成功！", "提示");
            }
        }

        private void menuTAPSetWightHeatID_Click(object sender, EventArgs e)
        {
            TAPMag.TAPWeightFrm dlg = new UnitMag.TAPMag.TAPWeightFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        private void menuTAPFixData_Click(object sender, EventArgs e)
        {
            TAPMag.TAPHeatFinalDataFrm dlg = new UnitMag.TAPMag.TAPHeatFinalDataFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        private void menuLFProp_Click(object sender, EventArgs e)
        {
            LFMag.LFAttributeFrm dlg = new UnitMag.LFMag.LFAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFDesignateLadle_Click(object sender, EventArgs e)
        {
            LFMag.LFDesignateLadleFrm dlg = new UnitMag.LFMag.LFDesignateLadleFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFCollectData_Click(object sender, EventArgs e)
        {
            LFMag.LFHeatDataFrm dlg = new UnitMag.LFMag.LFHeatDataFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFFixData_Click(object sender, EventArgs e)
        {
            //LFMag.LFHeatFinalDataFrm dlg = new UnitMag.LFMag.LFHeatFinalDataFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFEvents_Click(object sender, EventArgs e)
        {
            LFMag.LFHeatRemarkFrm dlg = new UnitMag.LFMag.LFHeatRemarkFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFFailure_Click(object sender, EventArgs e)
        {
            //BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFChangeGrade_Click(object sender, EventArgs e)
        {
            MELTChangeGradeFrm dlg = new MELTChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFSetWeightLadle_Click(object sender, EventArgs e)
        {       //Modify Begin  At 2011-02-15  By HuYunHai
            if ((CurUnitID != 3) && (CurUnitID != 5))
            {
                MessageBox.Show("只有3号和5号LF炉可称重！");
                return;
            }
            //Modify End  At 2011-02-15  By HuYunHai

            LFMag.LFWeightFrm dlg = new UnitMag.LFMag.LFWeightFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuRHFixData_Click(object sender, EventArgs e)
        {
            RHMag.RHHeatFinalDataFrm dlg = new UnitMag.RHMag.RHHeatFinalDataFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuRHFailure_Click(object sender, EventArgs e)
        {
            //BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuRHChangeGrade_Click(object sender, EventArgs e)
        {
            MELTChangeGradeFrm dlg = new MELTChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuRHEvents_Click(object sender, EventArgs e)
        {
            RHMag.RHHeatRemarkFrm dlg = new UnitMag.RHMag.RHHeatRemarkFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuCCMFixData_Click(object sender, EventArgs e)
        {
            CCMMag.CCMHeatFinalDataFrmNew dlg = new UnitMag.CCMMag.CCMHeatFinalDataFrmNew();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void menuCCMFailure_Click(object sender, EventArgs e)
        {
            //BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            SwitchHeatID();
            Adapter.RefreshDataBindings();
        }

        private void menuBOFFeed_Click(object sender, EventArgs e)
        {
            
            int iRet = cmdFeedIrons.Execute();
            if (iRet != 0 || (short)cmdFeedIrons.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdFeedIrons.Command.ErrorCode));
                MessageBox.Show("兑铁失败！" + strReasultShow);
                //btnFeedIron.DialogResult = DialogResult.None;
                return;
            }
            //  [12/27/2008 sun]
            MessageBox.Show("兑铁成功！", "提示");

            //btnFeedIron.DialogResult = DialogResult.OK;
            //BOFHeatDataFrm dlg = new BOFHeatDataFrm();
            //dlg.FeedIrons(Adapter.Session, Adapter.get_URIParameters("BOFID"), txtBOFNextHeatID.Text);
        }

        //吹练开始
        private void menuBOFBlowStart_Click(object sender, EventArgs e)
        {
           
            //MELTHeatDataFrm dlg = new MELTHeatDataFrm();
            //dlg.BlowStart(Adapter.Session, Adapter.get_URIParameters("BOFID"), txtBOFHeatID.Text);

        }

        private void menuBOFBlowStop_Click(object sender, EventArgs e)
        {
            paramStopBlow.ConstantValue = DateTime.Now.ToString();
            cmdBOFStopBlowing.Execute();
            String returnFlag = cmdBOFStopBlowing.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("吹炼结束成功！", "提示");
            }
            else
            {
                MessageBox.Show("吹炼结束不成功！", "提示");
            }
        }

        private string OnUpdateProcTimeText(object value)
        {
            try
            {
                Int32 iTime = Convert.ToInt32(value);
                iTime /= 1000; // to Second
                Int32 iMin = iTime / 60;
                Int32 iSec = iTime - iMin * 60;
                return string.Format("{0:D2}:{1:D2}", iMin, iSec);
            }
            catch
            {
                return "";
            }
        }

        //出钢开始
        private void menuBOFTappingStart_Click(object sender, EventArgs e)
        {
           

            int iRet = cmdBOFStartTapping.Execute();
            if (iRet != 0 || (short)cmdBOFStartTapping.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdBOFStartTapping.Command.ErrorCode));
                MessageBox.Show("出钢开始失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("出钢开始成功！", "提示");

            }
        }

        private void menuBOFTappingStop_Click(object sender, EventArgs e)
        {
            int iRet = cmdBOFStopTapping.Execute();
            if (iRet != 0 || (short)cmdBOFStopTapping.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdBOFStopTapping.Command.ErrorCode));
                MessageBox.Show("出钢结束失败,是否没有指定主原料！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("出钢结束成功！", "提示");
            }
        }

        private void menuTAPComplete_Click(object sender, EventArgs e)
        {
            int iRet = cmdTAPComplete.Execute();
            if (iRet != 0 || (short)cmdTAPComplete.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdTAPComplete.Command.ErrorCode));
                MessageBox.Show("钢水下线失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("钢水下线成功！", "提示");
            }
        }

        private void menuLFProcStart_Click(object sender, EventArgs e)
        {
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.StartProcess(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        private void menuLFProcStop_Click(object sender, EventArgs e)
        {
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.StopProcess(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        //钢包离站
        private void menuLFLeave_Click(object sender, EventArgs e)
        {
       
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.SteelLeave(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        //钢水全回炉申请--转炉
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MELTSteelReturnAppFrm dlg = new MELTSteelReturnAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        //全回炉申请--炉后
        private void menuTapSideReturnApply_Click(object sender, EventArgs e)
        {
            //SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        //钢水全回炉申请--LF炉
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        //全回炉申请--RH炉
        private void menuRHReturnApply_Click(object sender, EventArgs e)
        {
            //SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        //全回炉申请--CCM
        private void menuCCMReturnApply_Click(object sender, EventArgs e)
        {
            //SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        //返送申请--炉后
        private void menuTapBackApp_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        //饭送申请--LF炉
        private void menuLFBackApply_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        //饭送申请--RH炉
        private void menuRHBackApply_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        //饭送申请--CCM
        private void menuCCMBackApply_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void menuTapChangeGrade_Click(object sender, EventArgs e)
        {
            MELTChangeGradeFrm dlg = new MELTChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.TAP, CurUnitID));
        }

        private void menuCCMChangeGrade_Click(object sender, EventArgs e)
        {
            MELTChangeGradeFrm dlg = new MELTChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }


        private void menuRHArrive_Click(object sender, EventArgs e)
        {
            RHMag.RHDesignateLadleFrm dlg = new UnitMag.RHMag.RHDesignateLadleFrm();
            dlg.ShowDialogEx(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }

        private void menuRHProcStart_Click(object sender, EventArgs e)
        {
            RHMag.RHAreaOperation dlg = new UnitMag.RHMag.RHAreaOperation();
            dlg.StartProcess(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }

        private void menuRHProcStop_Click(object sender, EventArgs e)
        {
            RHMag.RHAreaOperation dlg = new UnitMag.RHMag.RHAreaOperation();
            dlg.StopProcess(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }

        /*****************20090218***************************/
        private void menuRHBlowStart_Click(object sender, EventArgs e)
        {
            RHMag.RHAreaOperation dlg = new UnitMag.RHMag.RHAreaOperation();
            dlg.StartBlow(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }

        private void menuRHBlowEnd_Click(object sender, EventArgs e)
        {
            RHMag.RHAreaOperation dlg = new UnitMag.RHMag.RHAreaOperation();
            dlg.StopBlow(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }
        /*****************20090218***************************/
        private void menuRHLeave_Click(object sender, EventArgs e)
        {
            RHMag.RHAreaOperation dlg = new UnitMag.RHMag.RHAreaOperation();
            dlg.SteelLeave(Adapter.Session, Adapter.get_URIParameters("RHID"));
        }

        private void menuCCMArrive_Click(object sender, EventArgs e)
        {
            CCMMag.CCMDesignateLadleFrm dlg = new UnitMag.CCMMag.CCMDesignateLadleFrm();
            dlg.ShowDialogEx(Adapter.Session, Adapter.get_URIParameters("CCMID"));
        }

        private void menuCCMChangeCastingNo_Click(object sender, EventArgs e)
        {
            string strYesNo = MessageBox.Show("确认换\"浇次\"？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (strYesNo != "Yes")
                return;

            int iRet = cmdCCMChangeCastingNo.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMChangeCastingNo.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMChangeCastingNo.Command.ErrorCode));
                MessageBox.Show("操作失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("操作成功！", "提示");
            }
        }

        private void menuCCMChangeTundishNo_Click(object sender, EventArgs e)
        {
            string strYesNo = MessageBox.Show("确认换\"包次\"？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (strYesNo != "Yes")
                return;

            int iRet = cmdCCMChangeTundishNo.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMChangeTundishNo.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMChangeTundishNo.Command.ErrorCode));
                MessageBox.Show("操作失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("操作成功！", "提示");
            }
        }

        private void menuCCMCastingStart_Click(object sender, EventArgs e)
        {
            int iRet = cmdCCMCastingStart.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMCastingStart.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMCastingStart.Command.ErrorCode));
                MessageBox.Show("操作失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("操作成功！", "提示");
            }
        }

        private void menuCCMCastingStop_Click(object sender, EventArgs e)
        {
            int iRet = cmdCCMCastingStop.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMCastingStop.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMCastingStop.Command.ErrorCode));
                MessageBox.Show("操作失败！" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("操作成功！", "提示");
            }
        }

        private void menuCCMComplet_Click(object sender, EventArgs e)
        {

        }

        private void menuMakeScrap_Click(object sender, EventArgs e)
        {
            CCMMag.CCMMarkScrapFrm dlg = new UnitMag.CCMMag.CCMMarkScrapFrm();
            dlg.ShowDialogEx(Adapter.Session, Adapter.get_URIParameters("CCMID"));
        }

        private void menuAnalysisApply_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuRHAnalysisApply_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuCCMAnalysisApply_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void menuLFBlowStart_Click(object sender, EventArgs e)
        {
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.SoftStart(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        //软吹结束
        private void menuLFBlowStop_Click(object sender, EventArgs e)
        {
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.SoftEnd(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        private void menuLFDevStatus_Click(object sender, EventArgs e)
        {
            LFMag.LFEquStatusFrm dlg = new LFMag.LFEquStatusFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuRHDevStatus_Click(object sender, EventArgs e)
        {
            LFMag.LFEquStatusFrm dlg = new LFMag.LFEquStatusFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
        }

        private void menuCCMDevStatus_Click(object sender, EventArgs e)
        {
            LFMag.LFEquStatusFrm dlg = new LFMag.LFEquStatusFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void txtSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            AppSvrHMI.L3DataBox ctrl = (AppSvrHMI.L3DataBox)sender;
            switch (ctrl.Name)
            {
                case "txtBOFSteelGradeIndex":
                    txtBOFSteelGrade.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                    break;
                case "txtTAPSteelGradeIndex":
                    txtTAPSteelGrade.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                    break;
                case "txtCCMSteelGradeIndex":
                    txtCCMSteelGrade.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                    break;
                default:
                    break;
            }
        }

        //窗体关闭，释放内存
        private void UnitMagMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //准备兑铁[2009-02-28 sun]
        private void MenuPreFeed_Click(object sender, EventArgs e)
        {
            int iRet = cmdPreFeed.Execute();
            int iReturn = Convert.ToInt16(cmdPreFeed.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdPreFeed.Command.ErrorCode));
                MessageBox.Show(string.Format("准备兑铁失败！" + strReasultShow));
                return;

            }
            else
            {
                MessageBox.Show("准备兑铁成功！", "提示");
            }
        }

        /*2009-03-04Liao*/
        private void dbxEquipStatus_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "L3DataBox")
                return;
            AppSvrHMI.L3DataBox c = (AppSvrHMI.L3DataBox)sender;
            switch (c.Tag.ToString())
            {
                case "B":
                    lbEquStaB.Text = Set_BOF_EquipLableText(dbxEquStaBOF.Text);
                    break;
                case "L":
                    lbEquStaL.Text = Set_LF_EquipLableText(dbxEquStaLF.Text);
                    break;
                case "R":
                    //lbEquStaR.Text = Set_RH_EquipLableText(dbxEquStaRH.Text);
                    break;
                case "C":
                    lbEquStaC.Text = Set_CCM_EquipLableText(dbxEquStaCCM.Text);
                    break;
                default:
                    break;
            }
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

        //获取铸机设备状态表述
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

        private void txtBOFIronTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBOFIronTempGet_TextChanged(object sender, EventArgs e)
        {
            string str = txtBOFIronTempGet.Text;
            if (str != "")
            {
                int viTime = Convert.ToInt32(str);
                int viMin = Convert.ToInt32(viTime / 60);
                int viSec = viTime % 60;
                string vsTime = viMin.ToString() + "'" + viSec.ToString() + "''";
                txtBOFIronTemp.Text = vsTime;
            }
        }
        /****************************2009-03-08:Liao**********************************/
        //换滑块
        private void MenuSmoothBlock_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.SmoothBlock; //加载界面（换滑块、中包水口、大包水口）

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

        //中包水口
        private void MenuWaterGrap_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.HurryWaterGap;

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

        //大包水口
        private void MenuBigWaterGrap_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.BigWaterGap;

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }
        /****************************2009-03-08:Liao**********************************/

        //根据处理号获取包次内炉数、浇次内炉数
        private void ucCCMStatus_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus)
        {
            try
            {
                //生产状态不为浇注中，不获取
                if (NewStatus != CommDataMag.CommonData.CCMCasting)
                    return;

                if (Adapter == null || Adapter.Session == null || txtCCMTreatNo.Text.Trim() == "")
                {
                    txtCCMCastingID.Text = "";
                    txtCCMTundishNo.Text = "";
                    return;
                }
                object objCastingHeatNum = null;
                object objTundishHeatNum = null;
                Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + txtCCMTreatNo.Text.Trim(), "Casting_HeatNum", ref  objCastingHeatNum);
                Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + txtCCMTreatNo.Text.Trim(), "Tundish_HeatNum", ref objTundishHeatNum);

                if (objCastingHeatNum != null)
                    txtCCMCastingID.Text = objCastingHeatNum.ToString();
                else
                    txtCCMCastingID.Text = "";

                if (objTundishHeatNum != null)
                    txtCCMTundishNo.Text = objTundishHeatNum.ToString();
                else
                    txtCCMTundishNo.Text = "";
            }
            catch
            {
                txtCCMCastingID.Text = "";
                txtCCMTundishNo.Text = "";
            }
        }

        private void menuModifyLadleGrade_Click(object sender, EventArgs e)
        {
            ModifyLadleGradeFrm Frm = new ModifyLadleGradeFrm();

            if (sender.Equals(menuLFModifyLadleGrade))
                Frm.ShowDialogEx(Adapter.Session, strLFID);
            else if (sender.Equals(menuRHModifyLadleGrade))
                Frm.ShowDialogEx(Adapter.Session, strRHID);

            GC.Collect();
        }

        //RH属性调整
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RHMag.RHAttributeFrm dlg = new UnitMag.RHMag.RHAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
            GC.Collect();
        }

        //CCM属性调整
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CCMMag.CCMAttributeFrm dlg = new UnitMag.CCMMag.CCMAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

        //RH称重2009-04-09
        private void menuRHSetWeightLadle_Click(object sender, EventArgs e)
        {
            RHMag.RHWeightFrm dlg = new UnitMag.RHMag.RHWeightFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.RH, CurUnitID));
            GC.Collect();
        }

        //RH刷新
        private void timerRHRefresh_Tick(object sender, EventArgs e)
        {
            //RHAreaInfo.RefreshData();
        }

        private void UnitMagMainFrm_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                timerRHRefresh.Enabled = false;
            else
                timerRHRefresh.Enabled = true;
        }

        //连铸实绩包次浇次内炉数修正
        private void menuCCMTCData_Click(object sender, EventArgs e)
        {
            CCMMag.CCMTCDataFrm frm = new UnitMag.CCMMag.CCMTCDataFrm();
            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();

            ucCCMStatus_OnUnitStatusChanged("XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\" + GetUnitObjID(UnitType.CCM, CurUnitID), 0, CommDataMag.CommonData.CCMCasting);
        }


        //bool bCCMLoad = false;
        private void tabCtrlCCM_VisibleChanged(object sender, EventArgs e)
        {

            //if (!bCCMLoad)
            //{
            //    tabCtrlCCM_Click(sender, e);
            //    bCCMLoad = true;
            //}
           
        }

        private void tabCtrlRH_VisibleChanged(object sender, EventArgs e)
        {
            //tabCtrlRH_Click(sender, e);
        }

        private void tabCtrlLF_VisibleChanged(object sender, EventArgs e)
        {
            //tabCtrlLF_Click(sender, e);
        }

        private void tabCtrlBOF_VisibleChanged(object sender, EventArgs e)
        {
            //tabCtrlBOF_Click(sender, e);
        }

        private void menuMELTStart_Click(object sender, EventArgs e)
        {
            cmdStart.Execute();
            String returnFlag = cmdStart.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("处理开始成功！", "提示");
            }
            else
            {
                MessageBox.Show("处理开始不成功！", "提示");
            }
        }

        
        private void menuMELTEnd_Click_1(object sender, EventArgs e)
        {
            cmdEnd.Execute();
            String returnFlag = cmdEnd.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("处理结束成功！", "提示");
            }
            else
            {
                MessageBox.Show("处理结束不成功！", "提示");
            }
        }


        //private void menuBOFBlowStop_Click(object sender, EventArgs e)
        //{

        //    cmdStopBlowing.Execute();
        //    String returnFlag = cmdStopBlowing.Command.Return.ToString();
        //    if (returnFlag == "1")
        //    {
        //        MessageBox.Show("吹炼结束成功！", "提示");
        //    }
        //    else
        //    {
        //        MessageBox.Show("吹炼结束不成功！", "提示");
        //    }
        //}

     



    }
}