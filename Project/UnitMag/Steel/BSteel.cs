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
using UnitMag.BOFMag;
using UnitMag.LFMag;
using UnitMag.CCMMag;
using UnitMag.AODMag;

namespace UnitMag.Steel
{

    
    public enum UnitType : int
    {
        DEP = 10,
        BOF = 20,
        TAP = 30,
        LF = 40,
        RH = 50,
        CCM = 60,
        MELT = 70,
        
    }

    public partial class BSteel : DockContent, IMESForm
    {

       

        public BSteel()
        {
            InitializeComponent();
            
        }

        #region IMESForm ��Ա

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
        public UnitType MainUnitType = UnitType.BOF;
        //public UnitType MainUnitType ;


        public string HeatID
        {
            get
            {
                string id = "";
                switch (MainUnitType)
                {
                    case UnitType.BOF: id = txtBOFHeatID.Text; break;
               
                    case UnitType.LF: id = LFAreaInfo.HeatID; break;
       
                    case UnitType.CCM: id = txtCCMHeatID.Text; break;
                }
                return id;
            }
        }

        protected UnitMag.AODMag.ucAODData AODData = null;
        protected UnitMag.LFMag.ucLFData LFData = null;
        protected UnitMag.DEPMag.DePData DEPData = null;

        protected UnitMag.CCMMag.ucCCMData CCMData = null;
        ///*******Modify Begin At2011-02-23 By Huyunhai *******/
        //int isCCM07 = 0;
        ///****Modify END ******/
       
        private string strBOFID = "S25";
        private string strLFID = "S44";
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

        //2009-03-17 //ת¯
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
                txtAODStep.L3DataAdapter = Adapter;
               

            }
            else
            {
                BOFStatus.L3Adapter = null;
      

                txtBOFHeatID.L3DataAdapter = null;
                txtBOFSteelGradeIndex.L3DataAdapter = null;
                txtBOFIronWeight.L3DataAdapter = null;
                txtBOFBlowTime.L3DataAdapter = null;
                txtBOFNextHeatID.L3DataAdapter = null;
                txtAODStep.L3DataAdapter = null;

            
            }
        }

        //LF
        protected void SetLFAdapter(bool bSet)
        {
            if (bSet)
            {
                ucLFStatus.L3Adapter = Adapter;
                LFAreaInfo.Adapter = Adapter;
          

                txtLFTreatNo.L3DataAdapter = Adapter;
                txtLFProcessTime.L3DataAdapter = Adapter;
                txtLFTemp.L3DataAdapter = Adapter;
                txtWeightHeatID.L3DataAdapter = Adapter;//2009-05-21
            }
            else
            {
                ucLFStatus.L3Adapter = null;
                LFAreaInfo.Adapter = null;
          

                txtLFTreatNo.L3DataAdapter = null;
                txtLFProcessTime.L3DataAdapter = null;
                txtLFTemp.L3DataAdapter = null;
                txtWeightHeatID.L3DataAdapter = null;//2009-05-21
            }
        }



        //CCM
        protected void SetCCMAdapter(bool bSet)
        {
            if (bSet)
            {
     
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

        protected void SetUnitID()
        {
            this.menuBOF.ResumeLayout(false);
                    Adapter.set_URIParameters("DEPID", "S91");
                   
                    Adapter.set_URIParameters("BOFID","S25");
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
                if (AODData == null)
                {
                    AODData = new ucAODData();
                    panelUnit.Controls.Add(AODData);
                    AODData.Dock = DockStyle.Fill;
                    AODData.Visible = false;
                    AODData.Session = Adapter.Session;

                    /**********L***********/
                    if (strBOFID.Length == 3)
                    {
                        AODData.UnitID = strBOFID;//L
                        int iBOFid = Convert.ToInt16(strBOFID.Substring(2, 1));//L
                        Adapter.set_URIParameters("AODID", "S25");//L
                    
                    }
                    else
                    {
                        AODData.UnitID = "";
                        Adapter.DeleteURIParameter("AODID");
             
                    }
                    /****************************/
                }
                AODData.Visible = true;
            }
            else if (AODData != null)
                AODData.Visible = false;



            if (type == UnitType.DEP)
            {
                if (DEPData == null)
                {
                    DEPData = new UnitMag.DEPMag.DePData();
                    panelUnit.Controls.Add(DEPData);
                    DEPData.Dock = DockStyle.Fill;
                    DEPData.Visible = false;
                    DEPData.Session = Adapter.Session;

                    /**********L***********/
                    if (strBOFID.Length == 3)
                    {
                        DEPData.UnitID = strBOFID;//L
                        int iBOFid = Convert.ToInt16(strBOFID.Substring(2, 1));//L
                        Adapter.set_URIParameters("AODID", "S25");//L

                    }
                    else
                    {
                        DEPData.UnitID = "";
                        Adapter.DeleteURIParameter("DEPID");

                    }
                    /****************************/
                }
                DEPData.Visible = true;
            }
            else if (DEPData != null)
                DEPData.Visible = false;




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
                        Adapter.set_URIParameters("LFID", "S44");//L
                    }
                    else
                        Adapter.DeleteURIParameter("LFID");
                    /**********************************/
                }
                LFData.Visible = true;
            }
            else if (LFData != null)
                LFData.Visible = false;

           
 
            /**********Modify Begin At 2011-02-23 By Huyunhai***************/


          

          
           // isCCM07 
        


            //������
            if (type == UnitType.CCM)
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

            //רΪ7#����



            /*******Modify END**********/

            tabPageBOF.BackColor = type == UnitType.BOF ? SystemColors.GradientActiveCaption : Color.Transparent;
            tabPageLF.BackColor = type == UnitType.LF ? SystemColors.GradientActiveCaption : Color.Transparent;
            tabPageRH.BackColor = type == UnitType.DEP ? SystemColors.GradientActiveCaption : Color.Transparent;
            tabPageCCM.BackColor = type == UnitType.CCM ? SystemColors.GradientActiveCaption : Color.Transparent;
        }

     

        protected void Start()
        {
            SetUnitID();
            //SetUnitID(MainUnitType, CurUnitID);
            ShowUnitDetails(MainUnitType,8);
         
            Adapter.RefreshDataBindings();
        }

        private void UnitMagMainFrm_Load(object sender, EventArgs e)
         {
             Start();

             switch (MainUnitType)
             {
                 case UnitType.BOF:
                     {

                         tabCtrlBOF.ContextMenuStrip = menuBOF;
                         tabCtrlBOF_Click(sender, e);
                         //if (CurUnitID == 5)
                         //{ }
                         TabText = "AOD�������";

                     }
                     break;
                 case UnitType.DEP:
                     {

                         tabCtrlRH.ContextMenuStrip = menuDEP;
                         tabCtrlRH_Click(sender, e);
                         TabText = "���׹������";
                     }
                     break;
                 case UnitType.LF:
                     {
                         tabCtrlLF.ContextMenuStrip = menuLF;
                         tabCtrlLF_Click(sender, e);
                         TabText = "4#LF�������";
                     }
                     break;
          
                 case UnitType.CCM:
                     {

                         tabCtrlCCM.ContextMenuStrip = menuCCM;
                         tabCtrlCCM_Click(sender, e);
                         TabText = "6#�������������";
                     }
                     break;
             }
     
         
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
            ShowUnitDetails(UnitType.DEP,8);
        }

        private void tabCtrlCCM_Click(object sender, EventArgs e)
        {
                ShowUnitDetails(UnitType.CCM, 8);                            
          

           
          
        }

        private void menuBOFProp_Click(object sender, EventArgs e)
        {
            UnitMag.AODMag.AODAttributeFrm dlg = new AODAttributeFrm();
        
            dlg.ShowDialogEx(Adapter.Session,"S25");
        }

        //ָ����ԭ��
        private void menuBOFDesignateMat_Click(object sender, EventArgs e)
        {
            //modify by hyh 2012-04-24
            //BOFDesignateMatFrm dlg = new BOFDesignateMatFrm();
            AODDesignateMaterialFrm dlg = new AODDesignateMaterialFrm();
            //end

            dlg.ShowDialogEx(Adapter.Session, "S25");
        }

        private void menuBOFDevStatus_Click(object sender, EventArgs e)
        {
            BOFEquStatusFrm dlg = new BOFEquStatusFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFFixData_Click(object sender, EventArgs e)
        {
            //BOFHeatFinalDataFrm dlg = new BOFHeatFinalDataFrm();
            //dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFEvents_Click(object sender, EventArgs e)
        {
            BOFHeatRemarkFrm dlg = new BOFHeatRemarkFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFStackMaintain_Click(object sender, EventArgs e)
        {
            BOFStackMagFrm dlg = new BOFStackMagFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        //private void menuBOFFailure_Click(object sender, EventArgs e)
        //{
        //    BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
        //    dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        //}

        private void menuBOFChangeGrade_Click(object sender, EventArgs e)
        {
            ChangeGradeFrm dlg = new ChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFDutyMag_Click(object sender, EventArgs e)
        {
            UnitMag.BOFMag.DutyMagFrm dlg = new UnitMag.BOFMag.DutyMagFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

        private void menuBOFAnalysRequest_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, "S25");
        }



        private void menuTAPStopProc_Click(object sender, EventArgs e)
        {
            int iRet = cmdTappingSideEnd.Execute();
            if (iRet != 0 || (short)cmdTappingSideEnd.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdTappingSideEnd.Command.ErrorCode));
                MessageBox.Show("�������ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("��������ɹ���", "��ʾ");
            }
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
            BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFChangeGrade_Click(object sender, EventArgs e)
        {
            ChangeGradeFrm dlg = new ChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }

        private void menuLFSetWeightLadle_Click(object sender, EventArgs e)
        {       //Modify Begin  At 2011-02-15  By HuYunHai
            if ((CurUnitID != 3) && (CurUnitID != 5))
            {
                MessageBox.Show("ֻ��3�ź�5��LF¯�ɳ��أ�");
                return;
            }
            //Modify End  At 2011-02-15  By HuYunHai

            LFMag.LFWeightFrm dlg = new UnitMag.LFMag.LFWeightFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }




        private void menuCCMFixData_Click(object sender, EventArgs e)
        {
            CCMMag.CCMHeatFinalDataFrmNew dlg = new UnitMag.CCMMag.CCMHeatFinalDataFrmNew();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void menuCCMFailure_Click(object sender, EventArgs e)
        {
            BOFTechicsExceptionFrm dlg = new BOFTechicsExceptionFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            //SwitchHeatID();
            Adapter.RefreshDataBindings();
        }

        private void menuBOFFeed_Click(object sender, EventArgs e)
        {
            
            int iRet = cmdFeedIrons.Execute();
            if (iRet != 0 || (short)cmdFeedIrons.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdFeedIrons.Command.ErrorCode));
                MessageBox.Show("����ʧ�ܣ�" + strReasultShow);
                //btnFeedIron.DialogResult = DialogResult.None;
                return;
            }
            //  [12/27/2008 sun]
            MessageBox.Show("�����ɹ���", "��ʾ");

            //btnFeedIron.DialogResult = DialogResult.OK;
            //BOFHeatDataFrm dlg = new BOFHeatDataFrm();
            //dlg.FeedIrons(Adapter.Session, Adapter.get_URIParameters("BOFID"), txtBOFNextHeatID.Text);
        }

        //������ʼ
        private void menuBOFBlowStart_Click(object sender, EventArgs e)
        {
           
            ////BOFHeatDataFrm dlg = new BOFHeatDataFrm();
            ////dlg.BlowStart(Adapter.Session, Adapter.get_URIParameters("BOFID"), txtBOFHeatID.Text);d
            cmdStartBlowing.Execute();
            String returnFlag = cmdStartBlowing.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("������ʼ�ɹ���", "��ʾ");
            }
            else
            {
                MessageBox.Show("������ʼ���ɹ���", "��ʾ");
            }

        }

        private void menuBOFBlowStop_Click(object sender, EventArgs e)
        {
          
            cmdStopBlowing.Execute();
            String returnFlag = cmdStopBlowing.Command.Return.ToString();
            if (returnFlag == "1")
            {
                MessageBox.Show("���������ɹ���", "��ʾ");
            }
            else
            {
                MessageBox.Show("�����������ɹ���", "��ʾ");
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

        //���ֿ�ʼ
        private void menuBOFTappingStart_Click(object sender, EventArgs e)
        {
           

            int iRet = cmdBOFStartTapping.Execute();
            if (iRet != 0 || (short)cmdBOFStartTapping.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdBOFStartTapping.Command.ErrorCode));
                MessageBox.Show("���ֿ�ʼʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("���ֿ�ʼ�ɹ���", "��ʾ");

            }
        }

        private void menuBOFTappingStop_Click(object sender, EventArgs e)
        {
            int iRet = cmdBOFStopTapping.Execute();
            if (iRet != 0 || (short)cmdBOFStopTapping.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdBOFStopTapping.Command.ErrorCode));
                MessageBox.Show("���ֽ���ʧ��,�Ƿ�û��ָ����ԭ�ϣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("���ֽ����ɹ���", "��ʾ");
            }
        }

        private void menuTAPComplete_Click(object sender, EventArgs e)
        {
            int iRet = cmdTAPComplete.Execute();
            if (iRet != 0 || (short)cmdTAPComplete.Command.Return == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdTAPComplete.Command.ErrorCode));
                MessageBox.Show("��ˮ����ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("��ˮ���߳ɹ���", "��ʾ");
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

        //�ְ���վ
        private void menuLFLeave_Click(object sender, EventArgs e)
        {
       
            LFMag.LFAreaOperation dlg = new UnitMag.LFMag.LFAreaOperation();
            dlg.SteelLeave(Adapter.Session, Adapter.get_URIParameters("LFID"));
        }

        //��ˮȫ��¯����--ת¯
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.BOF, CurUnitID));
        }

 

        //��ˮȫ��¯����--LF¯
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }


  

        //ȫ��¯����--CCM
        private void menuCCMReturnApply_Click(object sender, EventArgs e)
        {
            SteelReturnAppFrm dlg = new SteelReturnAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }


        //��������--LF¯
        private void menuLFBackApply_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }


        //��������--CCM
        private void menuCCMBackApply_Click(object sender, EventArgs e)
        {
            SteelBackAppFrm dlg = new SteelBackAppFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }



        private void menuCCMChangeGrade_Click(object sender, EventArgs e)
        {
            ChangeGradeFrm dlg = new ChangeGradeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
        }



        private void menuCCMArrive_Click(object sender, EventArgs e)
        {
            CCMMag.CCMDesignateLadleFrm dlg = new UnitMag.CCMMag.CCMDesignateLadleFrm();
            dlg.ShowDialogEx(Adapter.Session, Adapter.get_URIParameters("CCMID"));
        }

        private void menuCCMChangeCastingNo_Click(object sender, EventArgs e)
        {
            string strYesNo = MessageBox.Show("ȷ�ϻ�\"����\"��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (strYesNo != "Yes")
                return;

            int iRet = cmdCCMChangeCastingNo.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMChangeCastingNo.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMChangeCastingNo.Command.ErrorCode));
                MessageBox.Show("����ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
            }
        }

        private void menuCCMChangeTundishNo_Click(object sender, EventArgs e)
        {
            string strYesNo = MessageBox.Show("ȷ�ϻ�\"����\"��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (strYesNo != "Yes")
                return;

            int iRet = cmdCCMChangeTundishNo.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMChangeTundishNo.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMChangeTundishNo.Command.ErrorCode));
                MessageBox.Show("����ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
            }
        }

        private void menuCCMCastingStart_Click(object sender, EventArgs e)
        {
            int iRet = cmdCCMCastingStart.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMCastingStart.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMCastingStart.Command.ErrorCode));
                MessageBox.Show("����ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
            }
        }

        private void menuCCMCastingStop_Click(object sender, EventArgs e)
        {
            int iRet = cmdCCMCastingStop.Execute();
            if (iRet != 0 || Convert.ToBoolean(cmdCCMCastingStop.Command.Return) == false)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdCCMCastingStop.Command.ErrorCode));
                MessageBox.Show("����ʧ�ܣ�" + strReasultShow);
            }
            //  [12/27/2008 sun]
            else
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
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

        //������
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
          
                case "txtCCMSteelGradeIndex":
                    txtCCMSteelGrade.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                    break;
                case "txtDEPSteelGradeIndex":
                    txtDEPSteelGrade.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                    break;
                default:
                    break;
            }
        }

        //����رգ��ͷ��ڴ�
        private void UnitMagMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //׼������[2009-02-28 sun]
        //private void MenuPreFeed_Click(object sender, EventArgs e)
        //{
        //    int iRet = cmdPreFeed.Execute();
        //    int iReturn = Convert.ToInt16(cmdPreFeed.Command.Return.ToString());
        //    if (iRet != 0 || iReturn == 0)
        //    {
        //        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdPreFeed.Command.ErrorCode));
        //        MessageBox.Show(string.Format("׼������ʧ�ܣ�" + strReasultShow));
        //        return;

        //    }
        //    else
        //    {
        //        MessageBox.Show("׼�������ɹ���", "��ʾ");
        //    }
        //}
        private void MenuPreFeed_Click(object sender, EventArgs e)
        {
            AODMag.AODDesignateLadleFrm dlg = new UnitMag.AODMag.AODDesignateLadleFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.LF, CurUnitID));
        }
       

   
     

        private void txtBOFIronTemp_TextChanged(object sender, EventArgs e)
        {

        }

        /****************************2009-03-08:Liao**********************************/
        //������
        private void MenuSmoothBlock_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.SmoothBlock; //���ؽ��棨�����顢�а�ˮ�ڡ����ˮ�ڣ�

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

        //�а�ˮ��
        private void MenuWaterGrap_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.HurryWaterGap;

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

        //���ˮ��
        private void MenuBigWaterGrap_Click(object sender, EventArgs e)
        {
            CCMMag.CCMRefraFrm frm = new UnitMag.CCMMag.CCMRefraFrm();
            frm.MainEquipType = UnitMag.CCMMag.EquipType.BigWaterGap;

            frm.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }
        /****************************2009-03-08:Liao**********************************/

        //���ݴ���Ż�ȡ������¯����������¯��
        private void ucCCMStatus_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus)
        {
            try
            {
                //����״̬��Ϊ��ע�У�����ȡ
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
          

            GC.Collect();
        }



        //CCM���Ե���
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CCMMag.CCMAttributeFrm dlg = new UnitMag.CCMMag.CCMAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, GetUnitObjID(UnitType.CCM, CurUnitID));
            GC.Collect();
        }

 


     


        //����ʵ�����ν�����¯������
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
        //�紵��ʼ
        private void ��ʼToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRet = cmdBeginSpray.Execute();
            int iReturn = Convert.ToInt16(cmdBeginSpray.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ʼ�ɹ���");
            }
        }
        //�紵����
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRet = cmdEndSpray.Execute();
            int iReturn = Convert.ToInt16(cmdEndSpray.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����ɹ���");
            }
        }
        //  ������ʼ
        private void ��ʼToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int iRet = cmdbeginSlag.Execute();
            int iReturn = Convert.ToInt16(cmdbeginSlag.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ʼ�ɹ���");
            }
        }
        //��������
        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int iRet = cmdEndSlag.Execute();
            int iReturn = Convert.ToInt16(cmdEndSlag.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����ɹ���");
            }

        }

        private void ��ʼToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //���׿�ʼ
            int iRet = cmdBeginP.Execute();
            int iReturn = Convert.ToInt16(cmdBeginP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ʼ�ɹ���");
            }
        }

        private void ����ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //���׽���
            int iRet = cmdEndP.Execute();
            int iReturn = Convert.ToInt16(cmdEndP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����ɹ���");
                
            }
        }

        private void ��վToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //������վ
            int iRet = cmdDepWait.Execute();
            int iReturn = Convert.ToInt16(cmdDepWait.Command.Return.ToString());
            if (iRet != 0 || (int)cmdDepWait.Command.Return < 0)
            {

                MessageBox.Show("��վʧ�ܣ�" + iReturn);
                return;

            }
            else
            {
                MessageBox.Show("��վ�ɹ���");
            }


        }

        private void ί�е�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QualityMag.LabMag.SampleApplyFrm dlg = new QualityMag.LabMag.SampleApplyFrm();
            dlg.ShowDialogEx(Adapter.Session, "S91");
        }

        private void txtBOFHeatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ��̼��ʼToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRet = cmdDec.Execute();
            int iReturn = Convert.ToInt16(cmdDec.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��̼��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��̼��ʼ�ɹ���");
            }
        }

        private void ��ԭ��ʼToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRet = cmdReturn.Execute();
            int iReturn = Convert.ToInt16(cmdReturn.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ԭ��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ԭ��ʼ�ɹ���");
            }

        }

        private void ������վToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //����������վ

            UnitMag.DEPMag.DEPDesignateMaterialFrm dlg = new UnitMag.DEPMag.DEPDesignateMaterialFrm();

            dlg.ShowDialogEx(Adapter.Session, "S91");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //�ѹ迪ʼ
            int iRet = cmdBeginSi.Execute();
            int iReturn = Convert.ToInt16(cmdBeginSi.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ԭ��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ԭ��ʼ�ɹ���");
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //�ѹ����
            int iRet = cmdEndSi.Execute();
            int iReturn = Convert.ToInt16(cmdEndSi.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ԭ��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ԭ��ʼ�ɹ���");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DEPMag.DEPAttributeFrm dlg = new UnitMag.DEPMag.DEPAttributeFrm();
            dlg.ShowDialogEx(Adapter.Session, "S91");

        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�����紵��ʼ
            int iRet = cmdBeginP.Execute();
            int iReturn = Convert.ToInt16(cmdBeginP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����紵��ʼ�ɹ���");
            }
        }

        private void ����ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            //�����紵����
            int iRet = cmdEndP.Execute();
            int iReturn = Convert.ToInt16(cmdEndP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("���׽����ɹ���");
            }
        }

        private void ��ʼToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int iRet = cmdbeginSlagP.Execute();
            int iReturn = Convert.ToInt16(cmdbeginSlagP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ʼ�ɹ���");
            }
        }

        private void ����ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int iRet = cmdEndSlagP.Execute();
            int iReturn = Convert.ToInt16(cmdEndSlagP.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����ɹ���");
            }
        }

        private void ��ʼToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int iRet = cmdbeginReblow.Execute();
            int iReturn = Convert.ToInt16(cmdbeginReblow.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("��ʼʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("��ʼ�ɹ���");
            }
        }

        private void ����ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int iRet = cmdEndReblow.Execute();
            int iReturn = Convert.ToInt16(cmdEndReblow.Command.Return.ToString());
            if (iRet != 0 || iReturn == 0)
            {

                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                return;

            }
            else
            {
                MessageBox.Show("�����ɹ���");
            }
        }

      


     



    }
}