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
    public partial class DeSMagMain02Frm : DockContent, IMESForm
    {
        public DeSMagMain02Frm()
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

        private void dvDestIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //����ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                dvDestIrons.EndEdit();
                bsDestIrons.EndEdit();
                int iRet = 0;
                if (dsDestIron == null || dsDestIron.Tables[0].Rows.Count < 1)
                    return;

                if (cmdConfirm.Execute() >= 0)
                {
                    iRet = Convert.ToInt32(cmdConfirm.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("ȷ�ϳɹ���", "��ʾ");
                    else
                        MessageBox.Show("ȷ��ʧ�ܣ�" + iRet, "��ʾ");
                }
                else
                    MessageBox.Show("ȷ��ʧ�ܣ�", "��ʾ");
            }
            catch { }
            dsDestIron.LoadData();
        }

        //����ȷ��
        private void btnUndoDes_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int iRet = 0;
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
                        iRet = Convert.ToInt32(cmdUndoDes.Command.Return);
                        if (iRet > 0)
                            MessageBox.Show("�����ɹ���", "��ʾ");
                        else
                            MessageBox.Show("����ʧ�ܣ�" + iRet, "��ʾ");
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
                int iRet = 0;
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
                    cmdChangeStatus.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    switch(status)
                    {
                        case "׼������":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "1";
                            }
                            break;
                        case "���޽�վ":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "2";
                            }
                            break;
                        case "Ԥ������ʼ":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "3";
                            }
                            break;
                        case "Ԥ��������":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "4";
                            }
                            break;
                        case "������ʼ":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "7";
                            }
                            break;
                        case "��������":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "8";
                            }
                            break;
                        default:
                            break;
                    }
                    if (cmdChangeStatus.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdChangeStatus.Command.Return);
                        if (iRet > 0)
                            MessageBox.Show("�����ɹ���", "��ʾ");
                        else
                            MessageBox.Show("����ʧ�ܣ�" + iRet, "��ʾ");
                    }
                    else
                        MessageBox.Show("����ʧ�ܣ�", "��ʾ");
                }
            }
            catch { }
            dsIronsInfo.LoadData();
        }

        //ָ����λ
        private void btnDesignateDeSUnitID_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int iRet = 0;
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
                    cmdDesignateDeSUnitID1.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdDesignateDeSUnitID1.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdDesignateDeSUnitID1.Command.Return);
                        if (iRet > 0)
                            MessageBox.Show("ָ���ɹ���", "��ʾ");
                        else
                            MessageBox.Show("ָ��ʧ�ܣ�" + iRet, "��ʾ");
                    }
                    else
                        MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
                }
            }
            catch { }
            
            dsIronsInfo.LoadData();
        }

        //�紵��ʼ
        private void btnStartBlowing_Click(object sender, EventArgs e)
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
                    DesignateDeSUnitIDFrm frm = new DesignateDeSUnitIDFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, "II");
                }
            }
            catch { }

            dsIronsInfo.LoadData();
        }

        //������޸�
        private void btnChangeTreatNo_Click(object sender, EventArgs e)
        {
            ChangeTreatNoShowFrm frm = new ChangeTreatNoShowFrm();
            frm.ShowDialogEx(Adapter.Session, "II");
        }

        //�紵����
        private void btnStopBlowing_Click(object sender, EventArgs e)
        {
            int iRet = 0;
            try
            {
                if (cmdStopBlowing.Execute() >= 0)
                {
                    iRet = Convert.ToInt32(cmdStopBlowing.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("�紵�����ɹ���", "��ʾ");
                    else
                        MessageBox.Show("�紵����ʧ�ܣ�" + iRet, "��ʾ");
                }
                else
                    MessageBox.Show("�紵����ʧ�ܣ�", "��ʾ");
            }
            catch { }
        }

        private void btnChangeLance_Click(object sender, EventArgs e)
        {
            ChangeLanceShowFrm frm = new ChangeLanceShowFrm();
            frm.ShowDialogEx(Adapter.Session, "II");
        }

        //���޳�վ
        private void btnIronsDeparture_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int iRet = 0;
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
                    dsOutInfoSend.Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    ChoseDesShowFrm frm = new ChoseDesShowFrm();
                    frm.ShowDialogEx(Adapter.Session,dsOutInfoSend,"II");
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
            }
            catch { }
        }

        private void DeSMagMain02Frm_Load(object sender, EventArgs e)
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
                int iRet = 0;
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
                    dsOutInfoSend.Clear();
                    dsOutInfoSend.Tables[0].ImportRow(dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]);
                    ChoseDesTypeShowFrm frm = new ChoseDesTypeShowFrm();
                    frm.ShowDialogEx(Adapter.Session, dsOutInfoSend, "II");
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
            }
            catch { }
        }

        private void btnEquipmentStatus_Click(object sender, EventArgs e)
        {
            DeSEquipmentStatusMag frm = new DeSEquipmentStatusMag();
            frm.ShowDialogEx(Adapter.Session, "II");
        }

        //ί�е�����
        private void btnDeSIronSheet_Click(object sender, EventArgs e)
        {
            try
            {

                dvIronInfo.EndEdit();
                bsIronInfo.EndEdit();
                int iRet = 0;
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
                    DeSIronSheetFrm frm = new DeSIronSheetFrm();
                    frm.ShowDialogEx(Adapter.Session,dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["TAP_No"].ToString(),dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["TPC_No"].ToString());
                }
                dsIronsInfo.LoadData();
                dsOutInfo.LoadData();
            }
            catch { }
        }

        private void btnMatSet_Click(object sender, EventArgs e)
        {
            DeSMatSetShow frm = new DeSMatSetShow();
            frm.ShowDialogEx(Adapter.Session, "II");
        }
    }
}