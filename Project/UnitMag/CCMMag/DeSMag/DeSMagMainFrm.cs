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

        public string strMainUnit = "";
        private string sMaterialID = "";
        private void dvDestIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //����ȷ��
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
                        MessageBox.Show("ȷ�ϳɹ���", "��ʾ");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("ȷ��ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                    }
                }
                else
                    MessageBox.Show("ȷ��ʧ�ܣ�", "��ʾ");
            }
            catch { }
            dsDestIron.LoadData();
            dsIronsInfo.LoadData();
        }

        //����ȷ��
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
                }
                else
                {
                    cmdUndoDes.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdUndoDes.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdUndoDes.Command.Return);
                        if (sRet == "1")
                            MessageBox.Show("�����ɹ���", "��ʾ");
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("����ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                }
            }
            catch { }
            dsIronsInfo.LoadData();
            dsDestIron.LoadData();
        }

        //�ı�״̬
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
                if (checkCount != 1 && status != "���޽�վ")
                {
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdChangeStatus.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdChangeStatus.Parameters[2].ConstantValue = "C";
                    switch (status)
                    {
                        case "׼������":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "1";
                            }
                            break;

                        case "Ԥ��������":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "4";
                            }
                            break;

                        case "��������":
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
                            MessageBox.Show("�����ɹ���", "��ʾ");
                        else
                        {
                            dsError.SourceCondition = "OWNER = 'ChangeStatus'";
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("����ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                    dsIronsInfo.LoadData();
                    //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;

                }
            }
            catch { }
        }

        //ָ����λ
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
                }
                else
                {
                    sMaterialID = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    cmdDesignateDeSUnitID1.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdDesignateDeSUnitID1.Execute() >= 0)
                    {
                        sRet = Convert.ToString(cmdDesignateDeSUnitID1.Command.Return);
                        if (sRet == "1")
                            MessageBox.Show("ָ���ɹ���", "��ʾ");
                        else
                        {
                            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                            MessageBox.Show("ָ��ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                        }
                    }
                    else
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                }
            }
            catch { }

            dsIronsInfo.LoadData();
            //dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
        }

        //�紵��ʼ
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //������޸�
        private void btnChangeTreatNo_Click(object sender, EventArgs e)
        {
            ChangeTreatNoShowFrm frm = new ChangeTreatNoShowFrm();
            frm.ShowDialogEx(Adapter.Session, strMainUnit);
            dsIronsInfo.LoadData();
        }

        //�紵����
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
                        MessageBox.Show("�紵�����ɹ���", "��ʾ");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("�紵����ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                    }
                }
                else
                    MessageBox.Show("�紵����ʧ�ܣ�", "��ʾ");
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

        //ָ��ȥ��
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //��������
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //ί�е�����
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //�����豸״̬
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
        //��ȡ�����豸״̬����
        private string Set_DeS_EquipLableText(string strStatus)
        {
            string strReturnText = "";
            try
            {
                int iStatuse = Convert.ToInt32(strStatus);
                switch (iStatuse)
                {
                    case 1:
                        strReturnText = "����";
                        break;
                    case 2:
                        strReturnText = "����";
                        break;
                    case 3:
                        strReturnText = "�ȴ�";
                        break;
                    case 4:
                        strReturnText = "����";
                        break;
                    case 5:
                        strReturnText = "�罬";
                        break;
                    case 6:
                        strReturnText = "����������";
                        break;
                    case 7:
                        strReturnText = "����";
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //��ȡ��ҵ״̬����
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
                        strReturnText = "׼������";
                        break;
                    case "2":
                        strReturnText = "���޽�վ";
                        break;
                    case "3":
                        strReturnText = "Ԥ������ʼ";
                        break;
                    case "4":
                        strReturnText = "Ԥ��������";
                        break;
                    case "5":
                        strReturnText = "�紵��ʼ";
                        break;
                    case "6":
                        strReturnText = "�紵����";
                        break;
                    case "7":
                        strReturnText = "������ʼ";
                        break;
                    case "8":
                        strReturnText = "��������";
                        break;
                    case "9":
                        strReturnText = "���޳�վ";
                        break;
                    case "10":
                        strReturnText = "������ʹ��";
                        break;
                    default:
                        strReturnText = "";
                        break;

                }
                return strReturnText;
            }
            catch { return ""; }
        }

        //׼������
        private void btnPrepare_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "owner = 'PrepareIronLadle'";
            if (cmdPrepare.Execute() >= 0)
            {
                sRet = Convert.ToString(cmdPrepare.Command.Return);
                if (sRet == "1")
                    MessageBox.Show("׼������ɹ���", "��ʾ");
                else
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                    MessageBox.Show("׼������ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                }
            }
            else
                MessageBox.Show("׼������ʧ�ܣ�", "��ʾ");
        }

        //���޽�վ
        private void btnironArrived1_Click(object sender, EventArgs e)
        {
            string sRet = "";
            dsError.SourceCondition = "owner = 'AcceptDeSArrivalSignal'";
            if (cmdAcceptDeSArrival.Execute() >= 0)
            {
                sRet = Convert.ToString(cmdAcceptDeSArrival.Command.Return);
                if (sRet == "1")
                    MessageBox.Show("��վ�ɹ���", "��ʾ");
                else
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                    MessageBox.Show("��վʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                }
            }
            else
                MessageBox.Show("��վʧ�ܣ�", "��ʾ");
            dsIronsInfo.LoadData();
        }

        

        //Ԥ������ʼ
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //������ʼ
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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

        //ԤԼ����λ����״̬
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

        

        //�����紵״̬�޸�ͼƬ��ʾ
        private void dbxDeSStatusI_TextChanged(object sender, EventArgs e)
        {
            lbStatus1.Text = Set_DeS_LableText(dbxDeSStatusI.Text);
            if (lbStatus1.Text != "�紵��ʼ" && lbStatus1.Text != "�紵����")
                lbStatus1.Text = "";
            if (lbStatus1.Text == "�紵��ʼ")
                pbxDeS1.Image = global::UnitMag.Properties.Resources.DesBusy;
            else
                pbxDeS1.Image = global::UnitMag.Properties.Resources.DesFree;
        }

        private void dbxDeSStatusII_TextChanged(object sender, EventArgs e)
        {
            lbStatus2.Text = Set_DeS_LableText(dbxDeSStatusII.Text);
            if (lbStatus2.Text != "�紵��ʼ" && lbStatus2.Text != "�紵����")
                lbStatus2.Text = "";
            if (lbStatus2.Text == "�紵��ʼ")
                pbxDeS2.Image = global::UnitMag.Properties.Resources.DesBusy;
            else
                pbxDeS2.Image = global::UnitMag.Properties.Resources.DesFree;
        }

        //���ݵ�ǰ��λΪA��B��ͼƬ�µ���ҵ״̬��̬�󶨵���ͬ��λ
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

        //Ĭ�ϲ���ͬһ������
        private void dsIronsInfo_OnDataLoaded(object sender)
        {
            if (sMaterialID != "")
                try
                {
                    dsIronsInfo.Tables[0].Select("MaterialID = '" + sMaterialID + "'")[0]["CheckFlag"] = 1;
                }
                catch { }
        }

        //����������Ϣ
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

        //���޳�վ
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
                        MessageBox.Show("��վ�ɹ���", "��ʾ");
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("��վʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                    }
                }
                else
                    MessageBox.Show("��վʧ�ܣ�", "��ʾ");
            }
            catch { }

            dsIronsInfo.LoadData();
            dsOutInfo.LoadData();
        }

        //������Ϣÿ�����ˢ��һ��
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
        //��վ��Ϣÿ����ˢ��һ��
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
                    MessageBox.Show("ֻ��ѡһ������", "��ʾ");
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