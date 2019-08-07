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

        private void dvDestIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //来料确认
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
                        MessageBox.Show("确认成功！", "提示");
                    else
                        MessageBox.Show("确认失败！" + iRet, "提示");
                }
                else
                    MessageBox.Show("确认失败！", "提示");
            }
            catch { }
            dsDestIron.LoadData();
        }

        //撤销确认
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
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    cmdUndoDes.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdUndoDes.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdUndoDes.Command.Return);
                        if (iRet > 0)
                            MessageBox.Show("撤销成功！", "提示");
                        else
                            MessageBox.Show("撤销失败！" + iRet, "提示");
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
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    cmdChangeStatus.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    switch(status)
                    {
                        case "准备脱硫":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "1";
                            }
                            break;
                        case "铁罐进站":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "2";
                            }
                            break;
                        case "预捞渣开始":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "3";
                            }
                            break;
                        case "预捞渣结束":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "4";
                            }
                            break;
                        case "捞渣开始":
                            {
                                cmdChangeStatus.Parameters[1].ConstantValue = "7";
                            }
                            break;
                        case "捞渣结束":
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
                            MessageBox.Show("操作成功！", "提示");
                        else
                            MessageBox.Show("操作失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("操作失败！", "提示");
                }
            }
            catch { }
            dsIronsInfo.LoadData();
        }

        //指定工位
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
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    cmdDesignateDeSUnitID1.Parameters[0].ConstantValue = dsIronsInfo.Tables[0].Select("CheckFlag = '1'")[0]["MaterialID"].ToString();
                    if (cmdDesignateDeSUnitID1.Execute() >= 0)
                    {
                        iRet = Convert.ToInt32(cmdDesignateDeSUnitID1.Command.Return);
                        if (iRet > 0)
                            MessageBox.Show("指定成功！", "提示");
                        else
                            MessageBox.Show("指定失败！" + iRet, "提示");
                    }
                    else
                        MessageBox.Show("指定失败！", "提示");
                }
            }
            catch { }
            
            dsIronsInfo.LoadData();
        }

        //喷吹开始
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
                    MessageBox.Show("只能选一条数据", "提示");
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

        //处理号修改
        private void btnChangeTreatNo_Click(object sender, EventArgs e)
        {
            ChangeTreatNoShowFrm frm = new ChangeTreatNoShowFrm();
            frm.ShowDialogEx(Adapter.Session, "II");
        }

        //喷吹结束
        private void btnStopBlowing_Click(object sender, EventArgs e)
        {
            int iRet = 0;
            try
            {
                if (cmdStopBlowing.Execute() >= 0)
                {
                    iRet = Convert.ToInt32(cmdStopBlowing.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("喷吹结束成功！", "提示");
                    else
                        MessageBox.Show("喷吹结束失败！" + iRet, "提示");
                }
                else
                    MessageBox.Show("喷吹结束失败！", "提示");
            }
            catch { }
        }

        private void btnChangeLance_Click(object sender, EventArgs e)
        {
            ChangeLanceShowFrm frm = new ChangeLanceShowFrm();
            frm.ShowDialogEx(Adapter.Session, "II");
        }

        //铁罐出站
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
                    MessageBox.Show("只能选一条数据", "提示");
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

        //脱硫类型
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
                    MessageBox.Show("只能选一条数据", "提示");
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

        //委托单管理
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
                    MessageBox.Show("只能选一条数据", "提示");
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