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

        //加载
        private void IronLadleBaseMagFrm_Load(object sender, EventArgs e)
        {
            cmdTieStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_OFFLINE + "'";
            cmdTieEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_TIE + "' and ComFlag = 0";

            //小火开始:打结结束、小火结束、中火结束、大火结束（热备）
            cmdSmallFireStart.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_COLD + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 1)";
            cmdSmallFireStart.Parameters[0].SourceFilter += " or (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "')";

            cmdSmallFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 0";
            
            //中火开始:小火结束、中火结束、大火结束（热备）
            cmdMiddleFireStart.Parameters[0].SourceFilter = "(CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE + "' and ComFlag = 1)";
            cmdMiddleFireStart.Parameters[0].SourceFilter += " or (CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 1)";
            cmdMiddleFireStart.Parameters[0].SourceFilter += " or (CheckFlag =1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_HOT + "')";

            cmdMiddleFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE + "' and ComFlag = 0";

            //大火开始:小火结束、中火结束、大火结束（热备）
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

      
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //打结开始
        private void btnTieStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdTieStart))
            {
                cmdTieStart.Execute();
            }
        }

        //打结结束
        private void btnTieEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdTieEnd))
            {
                cmdTieEnd.Execute();
            }
        }

        //小火开始
        private void btnSmallFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdSmallFireStart))
            {
                cmdSmallFireStart.Execute();
            }
        }

        //小火结束
        private void btnSmallFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdSmallFireEnd))
            {
                cmdSmallFireEnd.Execute();
            }
        }

        //中火开始
        private void btnMidFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdMiddleFireStart))
            {
                cmdMiddleFireStart.Execute();
            }
        }

        //中火结束
        private void btnMidFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdMiddleFireEnd))
            {
                cmdMiddleFireEnd.Execute();
            }
        }

        //大火开始
        private void btnBigFireStart_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdBigFireStart))
            {
                cmdBigFireStart.Execute();
            }
        }

        //大火结束
        private void btnBigFireEnd_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdBigFireEnd))
            {
                cmdBigFireEnd.Execute();
            }
        }


        //转炉兑铁
        private void btnHot_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdHot))
            {
                cmdHot.Execute();
            }
        }

        //混铁炉出铁
        private void btnUse_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdUse))
            {
                cmdUse.Execute();
            }
        }

        //下线维护
        private void btnStopUse_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdStopUse))
            {
                cmdStopUse.Execute();
            }
        }

        //离线待修
        private void btnWaitRepair_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdWaitRepair)) 
            {
                cmdWaitRepair.Execute();
            }
        }

        //判断执行Cmd时是否有记录
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
            //打结 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_TIE, Color.DarkOrange, Color.Blue);

            //冷备 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_COLD, Color.YellowGreen, Color.Blue);

            //小火 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_SMALL_FIRE, Color.OrangeRed, Color.Blue);

            //中火
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
              "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_MIDDLE_FIRE, Color.OrangeRed, Color.Blue);

            //大火 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_BIG_FIRE, Color.OrangeRed, Color.Blue);


            //热备 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_HOT, Color.LightSeaGreen, Color.Blue);


            //使用 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_USE, Color.Red, Color.Blue);


            //停用 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvIronLadle, "IronLadleID",
                "Status", CommDataMag.CommonData.CIRONLADLE_STATUS_SUSPEND, Color.DarkOrange, Color.Blue);

            //离线待修 
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

        //新增铁包
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
                MessageBox.Show("请选择状态为\"离线待修\"的铁包", "提示", MessageBoxButtons.OK);
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

            string deleteConfirm = MessageBox.Show("确认要删除" + strMessage + "号铁包么？", "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            object objDel=null;
            dsIronLadle.CommitDeleted(ref objDel);
            if (objDel==null)
                MessageBox.Show("删除失败！", "提示");
            else
                MessageBox.Show("成功删除" + objDel + "条记录！", "提示");
            dsIronLadle.LoadData();
        }

        private void btnOffLineException_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            if (JudgeValueRowCount(cmdOffLineException))
            {
                string strYesNo = MessageBox.Show("确认所选铁包异常下线", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo != "Yes")
                    return;
                cmdOffLineException.Execute();
            }
        }
    }
}
