using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleBaseMagFrm : DockContent, IMESForm
    {
        public IronLadleBaseMagFrm()
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

        //����
        private void IronLadleBaseMagFrm_Load(object sender, EventArgs e)
        {
            cmdTieStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_OFFLINE + "'";
            cmdTieEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_TIE + "' and ComFlag = 0";

            //С��ʼ:��������С��������л���������������ȱ���
            cmdSmallFireStart.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_COLD + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "')";

            cmdSmallFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 0";
            
            //�л�ʼ:С��������л���������������ȱ���
            cmdMiddleFireStart.Parameters[0].SourceFilter = "(CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 1)";
            cmdMiddleFireStart.Parameters[0].SourceFilter += " or (CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 1)";
            cmdMiddleFireStart.Parameters[0].SourceFilter += " or (CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "')";

            cmdMiddleFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 0";

            //���ʼ:С��������л���������������ȱ���
            cmdBigFireStart.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 1)";
            cmdBigFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 1)";
            cmdBigFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "')";

            cmdBigFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_BIG_FIRE + "' and ComFlag = 0";

            cmdUse.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "'";
            cmdHot.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_USE + "'";

            cmdStopUse.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "'";
            cmdWaitRepair.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "'";

            cmdOffLineException.Parameters[0].SourceFilter = "CheckFlag = 1 and Status < '" + CommDataMag.CommonData.CIRONLADLE_STATUS_USE + "'";
        }

      
        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��Ὺʼ
        private void btnTieStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdTieStart))
            {
                cmdTieStart.Execute();
            }
        }

        //������
        private void btnTieEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdTieEnd))
            {
                cmdTieEnd.Execute();
            }
        }

        //С��ʼ
        private void btnSmallFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdSmallFireStart))
            {
                cmdSmallFireStart.Execute();
            }
        }

        //С�����
        private void btnSmallFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdSmallFireEnd))
            {
                cmdSmallFireEnd.Execute();
            }
        }

        //�л�ʼ
        private void btnMidFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdMiddleFireStart))
            {
                cmdMiddleFireStart.Execute();
            }
        }

        //�л����
        private void btnMidFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdMiddleFireEnd))
            {
                cmdMiddleFireEnd.Execute();
            }
        }

        //���ʼ
        private void btnBigFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdBigFireStart))
            {
                cmdBigFireStart.Execute();
            }
        }

        //������
        private void btnBigFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdBigFireEnd))
            {
                cmdBigFireEnd.Execute();
            }
        }


        //ת¯����
        private void btnHot_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdHot))
            {
                cmdHot.Execute();
            }
        }

        //����¯����
        private void btnUse_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdUse))
            {
                cmdUse.Execute();
            }
        }

        //����ά��
        private void btnStopUse_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdStopUse))
            {
                cmdStopUse.Execute();
            }
        }

        //���ߴ���
        private void btnWaitRepair_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdWaitRepair)) 
            {
                cmdWaitRepair.Execute();
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

        //[20081231Liao]
        private void dvIronLadle_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //��� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_TIE, Color.DarkOrange, Color.Blue);

            //�䱸 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_COLD, Color.YellowGreen, Color.Blue);

            //С�� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE, Color.OrangeRed, Color.Blue);

            //�л�
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
              "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE, Color.OrangeRed, Color.Blue);

            //��� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_BIG_FIRE, Color.OrangeRed, Color.Blue);


            //�ȱ� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_HOT, Color.LightSeaGreen, Color.Blue);


            //ʹ�� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_USE, Color.Red, Color.Blue);


            //ͣ�� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_SUSPEND, Color.DarkOrange, Color.Blue);

            //���ߴ��� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_OFFLINE,SystemColors.Control, Color.Blue);

        }

        private void dvIronLadle_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void IronLadleBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //��������
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IronLadleAddShowFrm frm = new IronLadleAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            DataRow[] drArray = dsIronLadle.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_OFFLINE + "'");
            if (drArray.Length < 1)
            {
                MessageBox.Show("��ѡ��״̬Ϊ\"���ߴ���\"������", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            
            string strMessage = "";
            foreach (DataRow dr in drArray)
            {
                string strIronLadleID = dr["IronLadleID"].ToString();
                strMessage += strIronLadleID + ",";
                for (int i = 0; i < dvIronLadle.Rows.Count;)
                {
                    if (dvIronLadle.Rows[i].Cells[IronLadleID.Index].Value.ToString() == strIronLadleID)
                    {
                        bsIronLadle.RemoveAt(i);
                        break;
                    }
                    i++;
                }
            }
            strMessage = strMessage.Substring(0, strMessage.Length - 1);

            string deleteConfirm = MessageBox.Show("ȷ��Ҫɾ��" + strMessage + "������ô��", "��ʾ", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            object objDel=null;
            dsIronLadle.CommitDeleted(ref objDel);
            if (objDel==null)
                MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
            else
                MessageBox.Show("�ɹ�ɾ��" + objDel + "����¼��", "��ʾ");
            dsIronLadle.LoadData();
        }

        private void btnOffLineException_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdOffLineException))
            {
                string strYesNo = MessageBox.Show("ȷ����ѡ�����쳣����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo != "Yes")
                    return;
                cmdOffLineException.Execute();
            }
        }
    }
}
