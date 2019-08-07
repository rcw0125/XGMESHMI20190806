using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class LadleBaseMagFrm : DockContent, IMESForm
    {
        public LadleBaseMagFrm()
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
        private void LadleBaseMagFrm_Load(object sender, EventArgs e)
        { 
            cmdInnerBuildStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_OFFLINE + "'";
            cmdInnerBuildEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_INNER_BUILD + "' and ComFlag = 0";
           
            /****Modify By huyunhai 2011-4-9****/
            cmdHKBegin.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_INNER_BUILD + "' and ComFlag = 1)";
            cmdHKEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_INNER_FIRE + "' and ComFlag = 0";
            /*****END****/

            //cmdWorkBuildStart.Parameters[0].SourceFilter = "CheckFlag = 1 and ((Status = '" + CommDataMag.CommonData.CLADLE_STATUS_WORK_DAUB + "' and ComFlag = 1)";
            cmdWorkBuildStart.Parameters[0].SourceFilter = "CheckFlag = 1 and ((Status = '" + CommDataMag.CommonData.CLADLE_STATUS_INNER_FIRE + "' and ComFlag = 1)";
            cmdWorkBuildStart.Parameters[0].SourceFilter += " or (Status = '" + CommDataMag.CommonData.CLADLE_STATUS_OFFLINE + "'))";
            
            cmdWorkBuildEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_WORK_DAUB + "' and ComFlag = 0";
           
            cmdWorkFireStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_WORK_DAUB + "' and ComFlag = 1";
            cmdWorkFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_WORK_FIRE + "' and ComFlag = 0";
      

            cmdHotFireStart.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_COLD + "' and ComFlag = 1)";
            cmdHotFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_HOT + "' and ComFlag = 1)";
            
            cmdHotFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_HOT_FIRE + "' and ComFlag = 0";

            cmdOffLineException.Parameters[0].SourceFilter = "CheckFlag = 1 and Status < '" + CommDataMag.CommonData.CLADLE_STATUS_USE + "'";
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //����״̬
        private void SetStatus(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            ToolStripButton btn = (ToolStripButton)sender;
            string strtsBtnName = btn.Name;
            AppSvrHMI.L3Command l3cmd = new AppSvrHMI.L3Command();
            switch (strtsBtnName)
            {
                case "btnInnerBuildStart":
                    l3cmd = cmdInnerBuildStart;
                    break;
                case "btnInnerBuildEnd": 
                    l3cmd = cmdInnerBuildEnd;
                    break;
                    /***Modify by huyunhai**/
                case "btnHKBegin":
                    l3cmd = cmdHKBegin;
                    break;
                case "btnHKEnd":
                    l3cmd = cmdHKEnd;
                    break;
                    /**Modify end***/

                case "btnWorkBuildStart":
                    l3cmd = cmdWorkBuildStart;
                    break;
                case "btnWorkBuildEnd":
                    l3cmd = cmdWorkBuildEnd;
                    break;
                case "btnWorkFireStart":
                    l3cmd = cmdWorkFireStart;
                    break;
                case "btnWorkFireEnd":
                    l3cmd = cmdWorkFireEnd;
                    break;
                case "btnOnFireStart":
                    l3cmd = cmdHotFireStart;
                    break;
                case "btnOnFireEnd":
                    l3cmd = cmdHotFireEnd;
                    break;
                default:
                    l3cmd = null;
                    break;
            }
            if (JudgeValueRowCount(l3cmd))
            {
                l3cmd.Execute();
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

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        /****************20081228Liao********************************/
        //ת¯���ֿ�ʼ
        private void btnBOFTaping_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            DataRow[] dr = dsMain.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_HOT + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("��ѡ��һ��\"״̬Ϊ�ȱ�\"�ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("��\"ֻѡ��һ��\"״̬Ϊ�ȱ��ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            string strLadleID = dr[0]["LadleID"].ToString();
            BOFTapStartFrm Frm = new BOFTapStartFrm();
            Frm.ShowDialogEx(Adapter.Session, strLadleID);
        }

        //������ע����
        private void btnCastingEnd_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            DataRow[] dr = dsMain.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_USE + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("��ѡ��һ��\"״̬Ϊʹ��\"�ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("��\"ֻѡ��һ��\"״̬Ϊʹ�õĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("ȷ�ϸְ�������ע������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                string strLadleID = dr[0]["LadleID"].ToString();
                string strURI = @"XGMESLogic\LadleMag\CLadle_Base\" + strLadleID;
                if (Adapter.Session.Set(strURI, "Status", CommDataMag.CommonData.CLADLE_STATUS_HOT) >= 0)
                {
                    MessageBox.Show("�����ɹ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
        }

        //����ά��
        private void btnOffLineToCold_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            DataRow[] dr = dsMain.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_HOT + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("��ѡ��һ��\"״̬Ϊ�ȱ�\"�ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("��\"ֻѡ��һ��\"״̬Ϊ�ȱ��ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("ȷ�ϸְ�����ά����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                string strLadleID = dr[0]["LadleID"].ToString();
                string strURI = @"XGMESLogic\LadleMag\CLadle_Base\" + strLadleID;
                if (Adapter.Session.Set(strURI, "Status", CommDataMag.CommonData.CLADLE_STATUS_WORK_DAUB) >= 0)
                {
                    MessageBox.Show("�����ɹ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
        }

        //˦��
        private void btnOffLineThrow_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            DataRow[] dr = dsMain.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_HOT + "'");
            if (dr.Length < 1)
            {
                MessageBox.Show("��ѡ��һ��\"״̬Ϊ�ȱ�\"�ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            else if (dr.Length > 1)
            {
                MessageBox.Show("��\"ֻѡ��һ��\"״̬Ϊ�ȱ��ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("ȷ��˦����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                string strLadleID = dr[0]["LadleID"].ToString();
                string strURI = @"XGMESLogic\LadleMag\CLadle_Base\" + strLadleID;
                if (Adapter.Session.Set(strURI, "Status", CommDataMag.CommonData.CTUNDISH_STATUS_OFFLINE) >= 0)
                {
                    MessageBox.Show("�����ɹ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
        }
        /*******************20081228Liao*******************************/

        /*******************20081230************************************/
        private void dvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //���ò�����(���)
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_INNER_BUILD, Color.DarkOrange, Color.Blue);

            //���ò�濾 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_INNER_FIRE, Color.Plum, Color.Blue);

            //����������(���) 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_WORK_DAUB, Color.Goldenrod, Color.Blue);

            //������濾
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
              "Status", CommDataMag.CommonData.CLADLE_STATUS_WORK_FIRE, Color.HotPink, Color.Blue);

            //�䱸 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_COLD, Color.YellowGreen, Color.Blue);

            //�ȱ��濾 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_HOT_FIRE, Color.OrangeRed, Color.Blue);

            //�ȱ� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_HOT, Color.LightSeaGreen, Color.Blue);

            //ʹ��(��ת) 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_USE, Color.Red, Color.Blue);

            //���ߴ��� 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvMain, "LadleID",
                "Status", CommDataMag.CommonData.CLADLE_STATUS_OFFLINE, SystemColors.Control, Color.Blue);
        }

        private void LadleBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
/*******************20081230************************************/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LadleAddShowFrm frm = new LadleAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            DataRow[] drArray = dsMain.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLADLE_STATUS_OFFLINE + "'");
            if (drArray.Length < 1)
            {
                MessageBox.Show("��ѡ��״̬Ϊ\"���ߴ���\"�ĸְ�", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            string strMessage = "";
            for (int i = dsMain.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                if (dsMain.Tables[0].Rows[i]["CheckFlag"].ToString() == "1" && dsMain.Tables[0].Rows[i]["Status"].ToString() == "10")
                {
                    strMessage += dsMain.Tables[0].Rows[i]["LadleID"].ToString()+",";
                    //dsMain.Tables[0].Rows.RemoveAt(i);
                }
            }
            strMessage = strMessage.Substring(0, strMessage.Length - 1);
            string deleteConfirm = MessageBox.Show("ȷ��Ҫɾ��" + strMessage + "������ô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            for (int i = dvMain.RowCount - 1; i >= 0; i--)
            {
                if (dvMain.Rows[i].Cells["checkFlagDataGridViewTextBoxColumn"].Value.ToString() == "1" && dvMain.Rows[i].Cells["Status"].Value.ToString() == "10")
                {
                    bsMain.RemoveAt(i);
                }
            }
            object objDel = null;
            dsMain.CommitDeleted(ref objDel);
            if (objDel == null)
                MessageBox.Show("ɾ��ʧ�ܣ�", "��ʾ");
            else
                MessageBox.Show("�ɹ�ɾ��" + objDel + "����¼��", "��ʾ");
            dsMain.LoadData();
        }


        private void dvMain_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            bsMain.Position = e.RowIndex;
            string strLadleType = dvMain.Rows[bsMain.Position].Cells[ladleTypeDataGridViewTextBoxColumn.Index].Value.ToString();
            if (strLadleType != "3")
            {
                menuMeasure.Enabled = false;
                btnCancel.Enabled = false;
                return;
            }
            menuMeasure.Enabled = true;
            btnCancel.Enabled = true;
        }

        //ָ������
        private void menuMeasure_Click(object sender, EventArgs e)
        {
            string strLadleID = dvMain.Rows[bsMain.Position].Cells[LadleID.Index].Value.ToString();
            cmdMeasureDesignate.Parameters[0].ConstantValue = strLadleID;
            if (cmdMeasureDesignate.Execute() >= 0)
            {
                if (Convert.ToInt32(cmdMeasureDesignate.Command.Return) > 0)
                    MessageBox.Show("ָ���ɹ���", "��ʾ");
                else
                    MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
            }
            else
                MessageBox.Show("ָ��ʧ�ܣ�", "��ʾ");
        }

        //ȡ��ָ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            string strLadleID = dvMain.Rows[bsMain.Position].Cells[LadleID.Index].Value.ToString();
            Adapter.Session.Set(@"XGMESLogic\LadleMag\CLadle_Base\" + strLadleID + "", "Measure_Flag", 0);
        }

        private void btnOffLineException_Click(object sender, EventArgs e)
        {
            dvMain.EndEdit();
            bsMain.EndEdit();
            if (JudgeValueRowCount(cmdOffLineException))
            {
                string strYesNo = MessageBox.Show("ȷ����ѡ�ְ��쳣����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo != "Yes")
                    return;
                cmdOffLineException.Execute();
            }
        }

        private void dvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }

    }
}