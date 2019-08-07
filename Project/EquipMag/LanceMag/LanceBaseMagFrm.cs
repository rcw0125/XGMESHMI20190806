using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LanceMag
{
    public partial class LanceBaseMagFrm : DockContent, IMESForm
    {
        public LanceBaseMagFrm()
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


        //�ؼ�����
        private void LanceBaseMagFrm_Load(object sender, EventArgs e)
        {
            //������ʼ
            cmdDefendStrat.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_OFFLINE + "'";
            //��������
            cmdDefendEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_REPAIR + "'";
            //����
            cmdChangeOn.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_FREE + "'";
            //���߼��
            cmdOffCheck.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_USE + "'";
            //��Ϊ���ٴ�ʹ��
            cmdFree.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_CHECK + "'";
            //���ߴ���
            cmdOffLine.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_CHECK + "'";
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��ǹά�޿�ʼ
        private void btnDefendStrat_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdDefendStrat))
            {
                cmdDefendStrat.Execute();
            }
        }

        //��ǹά�޽���
        private void btnDefendEnd_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdDefendEnd))
            {
                cmdDefendEnd.Execute();
            }
        }

        //�˹�������ǹ
        private void btnOn_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdChangeOn))
            {
                cmdChangeOn.Execute();
            }
        }

        //�˹�������ǹ
        private void btnOff_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdOffCheck))
            {
                cmdOffCheck.Execute();
            }
        }

        //׼���ٴ�����
        private void btnUseAgain_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdFree))
            {
                cmdFree.Execute();
            }
        }

        //���ߴ���
        private void btnWaitRepair_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdOffLine))
            {
                cmdOffLine.Execute();
            }
        }

        //�ж�ִ��Cmdʱ�Ƿ��м�¼
        private bool JudgeValueRowCount(AppSvrHMI.L3Command cmd)
        {
            DataSet dsJudge = (DataSet)(cmd.Parameters[0].Value);
            if (dsJudge == null || dsJudge.Tables[0].Rows.Count < 1)
            {
                return false;
            }
            return true;
        }

        //[20081230]
        private void dvBase_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        { 
            //���� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_REPAIR, Color.DarkOrange, Color.Blue);

            //����
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_FREE, Color.LightSeaGreen, Color.Blue);

            //ʹ��
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_USE, Color.Red, Color.Yellow);

            //���
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_CHECK, Color.Yellow, Color.Blue);

            //���ߴ���
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_OFFLINE, SystemColors.Control, Color.Blue);
        }

        private void LanceBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LanceAddShowFrm frm = new LanceAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            DataRow[] drArray = dsBase.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_OFFLINE + "'");
            if (drArray.Length < 1)
            {
                MessageBox.Show("��ѡ��״̬Ϊ\"���ߴ���\"����ǹ", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            string strMessage = "";
            for (int i = dsBase.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                if (dsBase.Tables[0].Rows[i]["CheckFlag"].ToString() == "1" && dsBase.Tables[0].Rows[i]["Status"].ToString() == "05")
                {
                    strMessage += dsBase.Tables[0].Rows[i]["LanceID"].ToString() + ",";
                    //dsMain.Tables[0].Rows.RemoveAt(i);
                }
            }
            strMessage = strMessage.Substring(0, strMessage.Length - 1);
            string deleteConfirm = MessageBox.Show("ȷ��Ҫɾ��" + strMessage + "����ǹô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            for (int i = dvBase.RowCount - 1; i >= 0; i--)
            {
                if (dvBase.Rows[i].Cells["checkFlagDataGridViewTextBoxColumn"].Value.ToString() == "1" && dvBase.Rows[i].Cells["Status"].Value.ToString() == "05")
                {
                    bsBase.RemoveAt(i);
                }
            }
            object objDel = null;
            dsBase.CommitDeleted(ref objDel);
            if (objDel == null)
                MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
            else
                MessageBox.Show("�ɹ�ɾ��" + objDel + "����¼��", "��ʾ");
            dsBase.LoadData();
        }

    }
}