using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.DeSMag
{
    public partial class DeSMagMainFrm : DockContent, IMESForm
    {
        public DeSMagMainFrm()
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

        public string strMainUnit = "";
        private string sMaterialID = "";
        private void dvDestIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //来料确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsError.SourceCondition = "OWNER = 'DesignateIronLadle'";
            dsError.LoadData();
            try
            {

                dvDestIrons.EndEdit();
                bsDestIrons.EndEdit();
                string sRet = "";
                if (dsDestIron == null || dsDestIron.Tables[0].Rows.Count < 1)
                    return;

                if (cmdConfirm.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdConfirm.Command.Return);
                    if (sRet == "1")
                        MessageBox.Show("确认成功！", "提示");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("确认失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("确认失败！", "提示");
            }
            catch { }
            dsDestIron.LoadData();
            dsIronsInfo.LoadData();
        }

        //撤销确认
        private void btnUndoDes_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                dsError.SourceCondition = "OWNER = 'UndoDesignateIronLadle'";
                dsError.LoadData();
                string sRet = "";
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    cmdUndoDes.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdUndoDes.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdUndoDes.Command.Return);
                        if (sRet == "1")
                            MessageBox.Show("撤销成功！", "提示");
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("撤销失败！" + sRet + strReasultShow, "提示");
                        }
                    }
                    else
                        MessageBox.Show("撤销失败！", "提示");
                }
            }
            catch { }
            dsIronsInfo.LoadData();
            dsDestIron.LoadData();
        }

        //改变状态
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            string status = sender.ToString();
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                string sRet = "";
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1 && status != "铁罐进站")
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdChangeStatus.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdChangeStatus.Parameters[2].ConstantValue = "C";
                    switch (status)
                    {
                        case "准备脱硫":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "1";
                            }
                            break;

                        case "预捞渣结束":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "4";
                            }
                            break;

                        case "捞渣结束":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "8";
                                try
                                {

                                    dvIronInfo.EndEdit();
                                    bsIronInfo.EndEdit();

                                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                                    dsOutInfoSend.Clear();
                                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                                    RemoveSlagCountFrm frm = new RemoveSlagCountFrm();
                                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                                }
                                catch { }
                            }
                            break;
                        default:
                            break;
                    }
                    if (cmdChangeStatus.Execute() >= 0)
                    {
                        sRet = cmdChangeStatus.Command.Return.ToString();
                        if (sRet == "1")
                            MessageBox.Show("操作成功！", "提示");
                        else
                        {
                            dsError.SourceCondition = "OWNER = 'ChangeStatus'";
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("操作失败！" + sRet + strReasultShow, "提示");
                        }
                    }
                    else
                        MessageBox.Show("操作失败！", "提示");
                    dsIronsInfo.LoadData();
                    //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;

                }
            }
            catch { }
        }

        //指定工位
        private void btnDesignateDeSUnitID_Click(object sender, EventArgs e)
        {
            dsError.SourceCondition = "owner = 'DesignateDeSUnitID'";
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                string sRet = "";
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdDesignateDeSUnitID1.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdDesignateDeSUnitID1.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdDesignateDeSUnitID1.Command.Return);
                        if (sRet == "1")
                            MessageBox.Show("指定成功！", "提示");
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("指定失败！" + sRet + strReasultShow, "提示");
                        }
                    }
                    else
                        MessageBox.Show("指定失败！", "提示");
                }
            }
            catch { }

            dsIronsInfo.LoadData();
            //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
        }

        //喷吹开始
        private void btnStartBlowing_Click(object sender, EventArgs e)
        {
            //string sMaterialID = "";
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    dsOutInfoSend.Tables[0].Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    DesignateDeSUnitIDFrm frm = new DesignateDeSUnitIDFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                }
            }
            catch { }

            dsIronsInfo.LoadData();
            //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
        }

        //处理号修改
        private void btnChangeTreatNo_Click(object sender, EventArgs e)
        {
            ChangeTreatNoShowFrm frm = new ChangeTreatNoShowFrm();
            frm.ShowDialogEx(Adapter.Session, strMainUnit);
            dsIronsInfo.LoadData();
        }

        //喷吹结束
        private void btnStopBlowing_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "owner = 'StopBlowing'";
            try
            {
                if (cmdStopBlowing.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdStopBlowing.Command.Return);
                    if (sRet == "1")
                        MessageBox.Show("喷吹结束成功！", "提示");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("喷吹结束失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("喷吹结束失败！", "提示");
            }
            catch { }
            dsIronsInfo.LoadData();
        }

        private void btnChangeLance_Click(object sender, EventArgs e)
        {
            ChangeLanceShowFrm frm = new ChangeLanceShowFrm();
            frm.ShowDialogEx(Adapter.Session, strMainUnit);
            dsIronsInfo.LoadData();
        }

        //指定去向
        private void btnIronsDeparture_Click(object sender, EventArgs e)
        {
            //string sMaterialID = "";
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    dsOutInfoSend.Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    ChoseDesShowFrm frm = new ChoseDesShowFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
                //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
            }
            catch { }
        }

        private void DeSMagMainFrm_Load(object sender, EventArgs e)
        {
            txtTAPNo1.LoadData();
        }

        //脱硫类型
        private void btnDeSType_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    dsOutInfoSend.Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    ChoseDesTypeShowFrm frm = new ChoseDesTypeShowFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
                //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
            }
            catch { }
        }

        private void btnEquipmentStatus_Click(object sender, EventArgs e)
        {
            DeSEquipmentStatusMag frm = new DeSEquipmentStatusMag();
            frm.ShowDialogEx(Adapter.Session, strMainUnit);
            dsIronsInfo.LoadData();
        }

        //委托单管理
        private void btnDeSIronSheet_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    DeSIronSheetFrm frm = new DeSIronSheetFrm();
                    frm.ShowDialogEx(Adapter.Session,dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["TAP_No"].ToString(),dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["TPC_No"].ToString());
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
                //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
            }
            catch { }
        }

        private void btnMatSet_Click(object sender, EventArgs e)
        {
            DeSMatSetShow frm = new DeSMatSetShow();
            frm.ShowDialogEx(Adapter.Session, strMainUnit);
            dsIronsInfo.LoadData();
        }

        private void DeSMagMainFrm_Load_2(object sender, EventArgs e)
        {
            Adapter.DeleteURIParameter("DeSUnit");
            Adapter.set_URIParameters("DeSUnit", strMainUnit);
            Adapter.RefreshDataBindings();
            //dsIronsInfo.SourceCondition = "(Status<9 and Des_UnitID = '" + strMainUnit + "') or Des_UnitID is null";
            if (strMainUnit == "S02")
            {
                panel1.ContextMenuStrip = contextMenuStrip1;
            }
            else
            {
                panel2.ContextMenuStrip = contextMenuStrip1;
            }
            dsIronsInfo.SourceMethod = "SELECT a.*, b.c, b.si, b.mn, b.s, b.p, b.ti                      "+
                                        "FROM cdes_base_data a, cbfiron b                                "+
                                        "WHERE a.materialid = b.materialid AND a.status < 9";
            dsIronsInfo.LoadData();

            //dsOutInfo.SourceMethod = " SELECT c.*, d.s_b, d.s_a                                          "+
            //                          "FROM cdes_base_data c,                                           "+
            //                          "     (SELECT a.*                                                 "+
            //                          "        FROM cdes_process_data a,                                "+
            //                          "             (SELECT   materialid, MAX (treatno) AS treatno      "+
            //                          "                  FROM cdes_process_data                         "+
            //                          "              GROUP BY materialid) b                             "+
            //                          "       WHERE a.treatno = b.treatno) d                            "+
            //                          " WHERE c.materialid = d.materialid and c.Status = 9 order by     "+ 
            //                          "c.PRODUCTIONDATE desc                                            ";
            dsOutInfo.SourceMethod ="SELECT *                                                                           " +
                                    "FROM (SELECT   c.*, d.s_b, d.s_a                                                   " +
                                    "         FROM cdes_base_data c,                                                    " +
                                    "               (SELECT a.*                                                         " +
                                    "                  FROM cdes_process_data a,                                        " +
                                    "                       (SELECT   materialid, MAX (treatno) AS treatno              " +
                                    "                            FROM cdes_process_data                                 " +
                                    "                        GROUP BY materialid) b                                     " +
                                    "                 WHERE a.treatno = b.treatno) d                                    " +
                                    "         WHERE c.materialid = d.materialid(+) AND (c.status = 9 or c.status = 10)  " +
                                    "      ORDER BY c.productiondate DESC)                                              " +
                                    "WHERE ROWNUM < 11                                                                  ";
            dsOutInfo.LoadData();
            timerRefInfo.Enabled = true;
            timerRefOut.Enabled = true;
        }

        //设置设备状态
        private void dbxEquipStatus_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "L3DataBox")
                return;

            AppSvrHMI.L3DataBox c = (AppSvrHMI.L3DataBox)sender;
            switch (c.Tag.ToString())
            {
                case "D1":
                    lbEquStaD1.Text = Set_DeS_EquipLableText(dbxEquStaDeS1.Text);
                    break;
                case "D2":
                    lbEquStaD2.Text = Set_DeS_EquipLableText(dbxEquStaDeS2.Text);
                    break;
                default:
                    break;
            }
            dsIronsInfo.LoadData();
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

        //获取作业状态表述
        private string Set_DeS_LableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                //string sStatus = CommDataMag.CommonMethed.GetStatusByMaterialID(Adapter, strStatus);
                switch (strStatus)
                {
                    case "":
                        strReturnText = "";
                        break;
                    case "1":
                        strReturnText = "准备脱硫";
                        break;
                    case "2":
                        strReturnText = "铁罐进站";
                        break;
                    case "3":
                        strReturnText = "预捞渣开始";
                        break;
                    case "4":
                        strReturnText = "预捞渣结束";
                        break;
                    case "5":
                        strReturnText = "喷吹开始";
                        break;
                    case "6":
                        strReturnText = "喷吹结束";
                        break;
                    case "7":
                        strReturnText = "捞渣开始";
                        break;
                    case "8":
                        strReturnText = "捞渣结束";
                        break;
                    case "9":
                        strReturnText = "铁罐出站";
                        break;
                    case "10":
                        strReturnText = "铁罐已使用";
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //准备脱硫
        private void btnPrepare_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "owner = 'PrepareIronLadle'";
            if (cmdPrepare.Execute() >= 0)
            {
                sRet = Convert.ToString(cmdPrepare.Command.Return);
                if (sRet == "1")
                    MessageBox.Show("准备脱硫成功！", "提示");
                else
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                    MessageBox.Show("准备脱硫失败！" + sRet + strReasultShow, "提示");
                }
            }
            else
                MessageBox.Show("准备脱硫失败！", "提示");
        }

        //铁罐进站
        private void btnironArrived1_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "owner = 'AcceptDeSArrivalSignal'";
            if (cmdAcceptDeSArrival.Execute() >= 0)
            {
                sRet = Convert.ToString(cmdAcceptDeSArrival.Command.Return);
                if (sRet == "1")
                    MessageBox.Show("进站成功！", "提示");
                else
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                    MessageBox.Show("进站失败！" + sRet + strReasultShow, "提示");
                }
            }
            else
                MessageBox.Show("进站失败！", "提示");
            dsIronsInfo.LoadData();
        }

        

        //预捞渣开始
        private void btnBeginPreRemoveSlag1_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    dsOutInfoSend.Tables[0].Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    PreRemoveSlagUnitIDFrm frm = new PreRemoveSlagUnitIDFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                }
            }
            catch { }
            dsIronsInfo.LoadData();

        }

        //捞渣开始
        private void btnBeginRemoveSlag1_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    dsOutInfoSend.Tables[0].Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    RemoveSlagUnitIDFrm frm = new RemoveSlagUnitIDFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, strMainUnit);
                }
            }
            catch { }
            dsIronsInfo.LoadData();
        }

        //预约各工位工作状态
        private void dbxDeSStatus1_TextChanged(object sender, EventArgs e)
        {
                    lbStatus1A.Text = Set_DeS_LableText(dbxDeSStatus1.Text);
                    
        }
        private void dbxDeSStatus2_TextChanged(object sender, EventArgs e)
        {
            lbStatus1B.Text = Set_DeS_LableText(dbxDeSStatus2.Text);
            
        }

        private void dbxDeSStatus3_TextChanged(object sender, EventArgs e)
        {
            lbStatus2A.Text = Set_DeS_LableText(dbxDeSStatus3.Text);
            
        }

        private void dbxDeSStatus4_TextChanged(object sender, EventArgs e)
        {
            lbStatus2B.Text = Set_DeS_LableText(dbxDeSStatus4.Text);
        }

        

        //根据喷吹状态修改图片显示
        private void dbxDeSStatusI_TextChanged(object sender, EventArgs e)
        {
            lbStatus1.Text = Set_DeS_LableText(dbxDeSStatusI.Text);
            if (lbStatus1.Text != "喷吹开始" && lbStatus1.Text != "喷吹结束")
                lbStatus1.Text = "";
            if (lbStatus1.Text == "喷吹开始")
                pbxDeS1.Image = global::UnitMag.Properties.Resources.DesBusy;
            else
                pbxDeS1.Image = global::UnitMag.Properties.Resources.DesFree;
        }

        private void dbxDeSStatusII_TextChanged(object sender, EventArgs e)
        {
            lbStatus2.Text = Set_DeS_LableText(dbxDeSStatusII.Text);
            if (lbStatus2.Text != "喷吹开始" && lbStatus2.Text != "喷吹结束")
                lbStatus2.Text = "";
            if (lbStatus2.Text == "喷吹开始")
                pbxDeS2.Image = global::UnitMag.Properties.Resources.DesBusy;
            else
                pbxDeS2.Image = global::UnitMag.Properties.Resources.DesFree;
        }

        //根据当前工位为A或B将图片下的作业状态动态绑定到不同工位
        private void txtDeSICurArea_TextChanged(object sender, EventArgs e)
        {
            if (txtDeSICurArea.Text == "A")
            {
                lbDeSICurArea.Text = "1#";
                dbxDeSStatusI.DataObject = dbxDeSStatus1.DataObject;
                dbxDeSStatusI.DataProperty = dbxDeSStatus1.DataProperty;
            }
            else if (txtDeSICurArea.Text == "B")
            {
                lbDeSICurArea.Text = "2#";
                dbxDeSStatusI.DataObject = dbxDeSStatus2.DataObject;
                dbxDeSStatusI.DataProperty = dbxDeSStatus2.DataProperty;
            }
            else
                return;

        }
        private void txtDeSIICurArea_TextChanged(object sender, EventArgs e)
        {
            if (txtDeSIICurArea.Text == "A")
            {
                lbDeSIICurArea.Text = "3#";
                dbxDeSStatusII.DataObject = dbxDeSStatus3.DataObject;
                dbxDeSStatusII.DataProperty = dbxDeSStatus3.DataProperty;
            }
            else if (txtDeSIICurArea.Text == "B")
            {
                lbDeSIICurArea.Text = "4#";
                dbxDeSStatusII.DataObject = dbxDeSStatus4.DataObject;
                dbxDeSStatusII.DataProperty = dbxDeSStatus4.DataProperty;
            }
            else
                return;
        }

        //默认操作同一条数据
        private void dsIronsInfo_OnDataLoaded(object sender)
        {
            if (sMaterialID != "")
                try
                {
                    dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
                }
                catch { }
        }

        //新增加料信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdditionShowFrm frm = new AdditionShowFrm();
            frm.ShowDialogEx(Adapter.Session);
            dsIronsInfo.LoadData();
        }

        private void dvDestIrons_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dvDestIrons.RowCount; i++)
            {
                if (dvDestIrons.Rows[i].Cells["SIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["SIn"].Value.ToString()) >= 0.04)
                    dvDestIrons.Rows[i].Cells["SIn"].Style.BackColor = Color.Yellow;
                if (dvDestIrons.Rows[i].Cells["TiIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["TiIn"].Value.ToString()) >= 0.065)
                    dvDestIrons.Rows[i].Cells["TiIn"].Style.BackColor = Color.Yellow;
                if (dvDestIrons.Rows[i].Cells["SiIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["SiIn"].Value.ToString()) >= 0.58)
                    dvDestIrons.Rows[i].Cells["SiIn"].Style.BackColor = Color.Yellow;
            }
        }

        //铁罐出站
        private void btnOut_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "OWNER = 'IronsDeparture'";
            try
            {
                if (cmdOut.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdOut.Command.Return);
                    if (sRet == "1")
                        MessageBox.Show("离站成功！", "提示");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("离站失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("离站失败！", "提示");
            }
            catch { }

            dsIronsInfo.LoadData();
            dsOutInfo.LoadData();
        }

        //脱硫信息每半分钟刷新一次
        private void timerRef_Tick(object sender, EventArgs e)
        {
            dsIronsInfo.LoadData();
            if (sMaterialID != "")
                try
                {
                    dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
                }
                catch { }
        }
        //离站信息每分钟刷新一次
        private void timerRefOut_Tick(object sender, EventArgs e)
        {
            dsOutInfo.LoadData();
        }
        private void btnChangeNote_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsIronsInfo.Tables[0].Rows.Count; i++)
                {
                    if (dvIronInfo.Rows[i].Cells[0].Value != null && dvIronInfo.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    ChangeNoteMag frm = new ChangeNoteMag();
                    frm.ShowDialogEx(Adapter.Session, dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString());
                }
            }
            catch{}
        }

        private void dvIronInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        
    }
}