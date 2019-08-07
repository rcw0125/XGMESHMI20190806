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

        }

        //1#LF工位预约
        private void dbxCurArea01_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea01.Text != "A") && (dbxCurArea01.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name01");
            Adapter.set_URIParameters("Name01", "S41" + dbxCurArea01.Text);
            Adapter.RefreshDataBindings();
        }

        //2#LF工位预约
        private void dbxCurArea02_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea02.Text != "A") && (dbxCurArea02.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name02");
            Adapter.set_URIParameters("Name02", "S42" + dbxCurArea02.Text);
            Adapter.RefreshDataBindings();
        }
        //3#LF工位预约
        private void dbxCurArea03_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea03.Text != "A") && (dbxCurArea03.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name03");
            Adapter.set_URIParameters("Name03", "S43" + dbxCurArea03.Text);
            Adapter.RefreshDataBindings();
        }
        //1#RH工位预约
        private void dbxCurArea04_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea04.Text != "A") && (dbxCurArea04.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name04");
            Adapter.set_URIParameters("Name04", "S51" + dbxCurArea04.Text);
            Adapter.RefreshDataBindings();
        }

        //Modify By HuYunHai    BEGIN 2011-02-15 (新建5#LF炉)
        //5#LF工位预约
        private void dbxCurArea05_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea05.Text != "A") && (dbxCurArea05.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name45");
            Adapter.set_URIParameters("Name45", "S45" + dbxCurArea05.Text);
            Adapter.RefreshDataBindings();

        }
        //Modify By HuYunHai END   2011-02-15

        //add by hyh 2012-05-10
        //4#LF
        private void dbxCurArea06_TextChanged(object sender, EventArgs e)
        {
            if ((dbxCurArea06.Text != "A") && (dbxCurArea06.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name07");
            Adapter.set_URIParameters("Name07", "S44" + dbxCurArea06.Text);
            Adapter.RefreshDataBindings();
        }
        //end

        //I部脱硫A、B工位预约
        private void txtDeSICurArea_TextChanged(object sender, EventArgs e)
        {
            if ((txtDeSICurArea.Text != "A") && (txtDeSICurArea.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name05");
            Adapter.set_URIParameters("Name05", "S02" + txtDeSICurArea.Text);
            Adapter.RefreshDataBindings();

            if (txtDeSICurArea.Text == "A")
            {
                lbDeSICurArea.Text = "1#";
                dbxDeSStatus1.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S02A";
                dbxDeSStatus1.DataProperty = "Status";
            }
            else if (txtDeSICurArea.Text == "B")
            {
                lbDeSICurArea.Text = "2#";
                dbxDeSStatus1.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S02B";
                dbxDeSStatus1.DataProperty = "Status";
            }
            else
                return;
        }

        //II脱硫A、B工位预约
        private void txtDeSIICurArea_TextChanged(object sender, EventArgs e)
        {
            if ((txtDeSIICurArea.Text != "A") && (txtDeSIICurArea.Text != "B"))
            {
                return;
            }
            Adapter.DeleteURIParameter("Name06");
            Adapter.set_URIParameters("Name06", "S03" + txtDeSIICurArea.Text);
            Adapter.RefreshDataBindings();

            if (txtDeSIICurArea.Text == "A")
            {
                lbDeSIICurArea.Text = "3#";
                dbxDeSStatus2.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S03A";
                dbxDeSStatus2.DataProperty = "Status";
            }
            else if (txtDeSIICurArea.Text == "B")
            {
                lbDeSIICurArea.Text = "4#";
                dbxDeSStatus2.DataObject = @"XGMESLogic\DeSMag\CDeS_Prod_Area\S03B";
                dbxDeSStatus2.DataProperty = "Status";
            }
            else
                return;
        }

        //获取工艺去向
        private void ucStatus_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus)
        {
            string strS = "S";
            char[] charS = strS.ToCharArray();
            string strUnitID = UnitURI.Substring(UnitURI.LastIndexOfAny(charS), 3);
            string strHeatID = "";
            string strReturn = "";
            switch (strUnitID)
            {
                case "S21":
                    strHeatID = txtBOF01AfterHeatID.Text;
                    break;
                case "S22":
                    strHeatID = txtBOF02AfterHeatID.Text;
                    break;
                case "S23":
                    strHeatID = txtBOF03AfterHeatID.Text;
                    break;
                case "S24":
                    strHeatID = txtBOF04AfterHeatID.Text;
                    break;
                case "S41":
                    strHeatID = txtLF01HeatID.Text;
                    break;
                case "S42":
                    strHeatID = txtLF02HeatID.Text;
                    break;
                case "S43":
                    strHeatID = txtLF03HeatID.Text;
                    break;
                case "S51":
                    strHeatID = txtRH01HeatID.Text;
                    break;

                //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
                case "S45":
                    strHeatID = txtLF05HeatID.Text;
                    break;
                //Modify By HuYunHai END 2011-02-15 

                    //add by hyh 2012-05-10
                case "S44":
                    strHeatID = txtLF04HeatID.Text;
                    break;
                    //end
                default:
                    break;
            }
            if (strHeatID == "")
            {
                switch (strUnitID)
                {
                    case "S21":
                        txtBOF01AfterOut.Text = "";
                        break;
                    case "S22":
                        txtBOF02AfterOut.Text = "";
                        break;
                    case "S23":
                        txtBOF03AfterOut.Text = "";
                        break;
                    case "S24":
                        txtBOF04AfterOut.Text = "";
                        break;
                    case "S41":
                        txtLF01AfterOut.Text = "";
                        break;
                    case "S42":
                        txtLF02AfterOut.Text = "";
                        break;
                    case "S43":
                        txtLF03AfterOut.Text = "";
                        break;
                    case "S51":
                        txtRH01AfterOut.Text = "";
                        break;
                    //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
                    case "S45":
                        txtLF05AfterOut.Text = "";
                        break;
                    //Modify By HuYunHai END 2011-02-15 

                    //add by hyh 2012-05-10
                    case "S44":
                        txtLF04AfterOut.Text = "";
                        break;
                    //end
                    default:
                        break;
                }
                return;
            }
            //执行
            cmdGetDirection.Parameters[0].ConstantValue = strUnitID;
            cmdGetDirection.Parameters[1].ConstantValue = strHeatID;
            cmdGetDirection.Execute();
            strReturn = cmdGetDirection.Command.Return.ToString();

            switch (strUnitID)
            {
                case "S21":
                    txtBOF01AfterOut.Text = strReturn;
                    break;
                case "S22":
                    txtBOF02AfterOut.Text = strReturn;
                    break;
                case "S23":
                    txtBOF03AfterOut.Text = strReturn;
                    break;
                case "S24":
                    txtBOF04AfterOut.Text = strReturn;
                    break;
                case "S41":
                    txtLF01AfterOut.Text = strReturn;
                    break;
                case "S42":
                    txtLF02AfterOut.Text = strReturn;
                    break;
                case "S43":
                    txtLF03AfterOut.Text = strReturn;
                    break;
                case "S51":
                    txtRH01AfterOut.Text = strReturn;
                    break;

                //Modify By HuYunHai BEGIN 2011-02-15 (新建5#LF炉)
                case "S45":
                    txtLF05AfterOut.Text = strReturn;
                    break;
                //Modify By HuYunHai END   2011-02-15 

                //Modify By hyh BEGIN 2012-05-10 (新建4LF炉)
                case "S44":
                    txtLF04AfterOut.Text = strReturn;
                    break;
                //Modify By HuYunHai END   2011-02-15 

                default:
                    break;
            }
        }

        //根据炼钢记号获取对应钢种
        private void GetSteelGradeBySteelGradeIndex(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is AppSvrHMI.L3DataBox))
                    return;
                AppSvrHMI.L3DataBox ctrl = sender as AppSvrHMI.L3DataBox;

                if (ctrl.Tag.ToString().Length < 1)
                    return;

                foreach (Control other in ctrl.Parent.Controls)
                {
                    if (!(other is AppSvrHMI.L3DataBox)) continue;
                    AppSvrHMI.L3DataBox otherTxt = other as AppSvrHMI.L3DataBox;
                    if (otherTxt == ctrl) continue;
                    if (otherTxt.Tag != null && ctrl.Tag != null && otherTxt.Tag.ToString() == ctrl.Tag.ToString())
                    {
                        otherTxt.Text = CommDataMag.CommonMethed.GetSteelGradeBySteelGradeIndex(Adapter, ctrl.Text.Trim());
                        return;
                    }
                }
            }
            catch { }
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


                case "D1":
                    lbEquStaD1.Text = Set_DeS_EquipLableText(dbxEquStaDeS1.Text);
                    break;
                case "D2":
                    lbEquStaD2.Text = Set_DeS_EquipLableText(dbxEquStaDeS2.Text);
                    break;
                case "D1T":
                    txtDeSIDeSType.Text = Set_DeS_DeSType(txtDeSType1.Text);
                    break;
                case "D2T":
                    txtDeSIIDeSType.Text = Set_DeS_DeSType(txtDeSType2.Text);
                    break;
                default:
                    break;
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
                //生产状态不为浇注中，不获取
                if (NewStatus != CommDataMag.CommonData.CCMCasting)
                    return;

                if (UnitURI.ToString() == "")
                    return;
                if (this.Adapter == null || this.Adapter.Session == null)
                    return;

                object objTreatNo = null;
                string strCCMID = UnitURI.Substring(UnitURI.Length - 3, 3);
                Adapter.Session.Get(UnitURI, "TreatNo", ref objTreatNo);

                object objCastingHeatNum = null;
                object objTundishHeatNum = null;
                string strCastingHeatNum = "";
                string strTundishHeatNum = "";

                if (objTreatNo != null)
                {
                    Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + objTreatNo.ToString(), "Casting_HeatNum", ref objCastingHeatNum);
                    if (objCastingHeatNum != null)
                        strCastingHeatNum = objCastingHeatNum.ToString();

                    Adapter.Session.Get(CommDataMag.CommonData.CCM_PROCESS_DATA_URI + objTreatNo.ToString(), "Tundish_HeatNum", ref objTundishHeatNum);
                    if (objTundishHeatNum != null)
                        strTundishHeatNum = objTundishHeatNum.ToString();

                }
                switch (strCCMID)
                {
                    // Modify By HuYunHai Begin  2011-02-14   (1#连铸机修改为7#连铸机，删除2#连铸机)
                    case "S67":
                        dbxCasting7.Text = strCastingHeatNum;
                        dbxTundish7.Text = strTundishHeatNum;
                        break;
                    //case "S62":
                    //    dbxCasting2.Text = strCastingHeatNum;
                    //    dbxTundish2.Text = strTundishHeatNum;
                    //    break;
                    // Modify By HuYunHai End  2011-02-14   
                    case "S63":
                        dbxCasting3.Text = strCastingHeatNum;
                        dbxTundish3.Text = strTundishHeatNum;
                        break;
                    case "S64":
                        dbxCasting4.Text = strCastingHeatNum;
                        dbxTundish4.Text = strTundishHeatNum;
                        break;
                    case "S65":
                        dbxCasting5.Text = strCastingHeatNum;
                        dbxTundish5.Text = strTundishHeatNum;
                        break;
                        //add by hyh 2012-05-10
                    case "S66":
                        dbxCasting6.Text = strCastingHeatNum;
                        dbxTundish6.Text = strTundishHeatNum;
                        break;
                        //end
                    default:
                        break;
                }
            }
            catch { }
        }

      
        //根据脱硫状态更改图片设置
        private void dbxDeSStatus1_TextChanged(object sender, EventArgs e)
        {
            string strStatus = dbxDeSStatus1.Text;
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

        private void dbxDeSStatus2_TextChanged(object sender, EventArgs e)
        {
            string strStatus = dbxDeSStatus2.Text;
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


     




    }
}