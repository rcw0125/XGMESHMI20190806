using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.TundishMag
{
    public partial class TundishBaseMagFrm : DockContent, IMESForm
    {
        public TundishBaseMagFrm()
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

        AppSvrHMI.L3DataSet dsCold = new AppSvrHMI.L3DataSet();

        //控件加载
        private void TundishBaseMagFrm_Load(object sender, EventArgs e)
        {
            //锁定排序
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvTundish);
            dsCold = (AppSvrHMI.L3DataSet)dsTundish.Clone();

            //永久层打结开始
            cmdInnerTieStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_OFFLINE + "'";
            
            //永久层打结束
            cmdInnerTieEnd.Parameters[0].SourceFilter = "CheckFlag =1  and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_INNER_BUILD + "' and Flag = 0";
           
            //永久层烘烤开始
            cmdInnerFireStart.Parameters[0].SourceFilter = "CheckFlag = 1  and  Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_INNER_BUILD + "' and Flag = 1";
            
            //永久层烘烤结束
            cmdInnerFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_INNER_FIRE + "'  and Flag = 0";
            
            //工作层修砌开始
            cmdWorkBuildStart.Parameters[0].SourceFilter = "(CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_INNER_FIRE + "' and Flag = 1)  or  (CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_OFFLINE + "')";
           
            //工作层修砌结束
            cmdWorkBuildEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_WORK_DAUB + "' and Flag = 0";
          
            //工作层烘烤开始
            cmdWorkFireStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_WORK_DAUB + "'  and Flag = 1";
          
            //工作层烘烤结束
            cmdWorkFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_WORK_FIRE + "'  and Flag = 0";
          
            //工作层确认冷备
            cmdConfirmCold.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_WORK_FIRE + "'  and Flag = 1";
           
            //上件开始
            cmdInstallStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_COLD + "'  and Flag = 1";
          
            //上件结束
            cmdInstallEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_ISTALL+"'  and Flag = 0";
           
            //热备烘烤开始
            cmdOnFireStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_ISTALL + "'  and Flag = 1";
           
            //热备烘烤结束
            cmdOnFireEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_HOT_FIRE + "' and Flag = 0";

            //中包异常下线
            cmdOffLineException.Parameters[0].SourceFilter = "CheckFlag = 1 and Status < '" + CommDataMag.CommonData.CTUNDISH_STATUS_USE + "'";
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //永久层打结开始
        private void btnInnerTieStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInnerTieStart))
            { 
                cmdInnerTieStart.Execute();
            }
        }

        private void btnInnerTieEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInnerTieEnd))
            {
                cmdInnerTieEnd.Execute();
            }
        }

        private void btnInnerFireStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInnerFireStart))
            {
                cmdInnerFireStart.Execute();
            }
        }

        private void btnInnerFireEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInnerFireEnd))
            {
                cmdInnerFireEnd.Execute();
            }
        }

        private void btnWorkBuildStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdWorkBuildStart))
            {
                cmdWorkBuildStart.Execute();
            }
        }

        private void btnWorkBuildEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdWorkBuildEnd))
            {
                cmdWorkBuildEnd.Execute();
            }
        }

        private void btnWorkFireStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdWorkFireStart))
            { 
                cmdWorkFireStart.Execute();
            }
        }

        private void btnWorkFireEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdWorkFireEnd))
            {
                cmdWorkFireEnd.Execute();
            }
        }

        private void btnOnFireStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            DataSet dsJudge = (DataSet)(cmdOnFireStart.Parameters[0].Value);
            if (dsJudge.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("请选择一个状态为上件结束的中包！", "提示");
                return;
            }
            else if (dsJudge.Tables[0].Rows.Count > 1)
            {
                MessageBox.Show("请只选择一个状态为上件结束的中包！", "提示");
                return;
            }
            TundishOnLineFrm Frm = new TundishOnLineFrm();
            Frm.ShowDialogEx(Adapter.Session,dsJudge);
            GC.Collect();
        }

        private void btnOnFireEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdOnFireEnd))
            {
                cmdOnFireEnd.Execute();
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

        private void btnConfirmCold_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdConfirmCold))
            {
                cmdConfirmCold.Execute();
            }
        }

        private void btnInstallStart_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInstallStart))
            {
                cmdInstallStart.Execute();
            }
        }

        private void btnInstallEnd_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdInstallEnd))
            {
                cmdInstallEnd.Execute();
            }
        }

        private void menuDire_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem menu = (System.Windows.Forms.ToolStripMenuItem)sender;
            cmdTundishDireCCMID.Parameters[0].ConstantValue = dvTundish.Rows[bsTundish.Position].Cells["TundishID"].Value.ToString();
            switch (menu.Tag.ToString())
            {
                case "0":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = "0";
                    break;
                case "3":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = CommDataMag.CommonData.CCM_UNIT_03ID;
                    break;
                case "4":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = CommDataMag.CommonData.CCM_UNIT_04ID;
                    break;
                case "5":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = CommDataMag.CommonData.CCM_UNIT_05ID;
                    break;
                case "7":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = CommDataMag.CommonData.CCM_UNIT_07ID;
                    break;
                    //modify by hyh 2012-06-08
                case "6":
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = CommDataMag.CommonData.CCM_UNIT_06ID;
                    break;
                    //end
                default:
                    cmdTundishDireCCMID.Parameters[1].ConstantValue = null;
                    break;
            }
            if (cmdTundishDireCCMID.Parameters[1].ConstantValue != null)
            {
                cmdTundishDireCCMID.Execute();
                object ii = cmdTundishDireCCMID.Command.Return;
            }
        }

        //需要右键菜单时
        private void dvTundish_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            //TundishcmsTundishDire
            //int iRowIndex = e.RowIndex;
            //bsTundish.Position = iRowIndex;
            //string strTundishType = dvTundish.Rows[bsTundish.Position].Cells[TundishType.Index].Value.ToString();
            //string strStatus = dvTundish.Rows[bsTundish.Position].Cells["Status"].Value.ToString();
            //string strCCMID = dvTundish.Rows[bsTundish.Position].Cells[castIDDataGridViewTextBoxColumn.Index].Value.ToString();
            //switch (strTundishType)
            //{
            //    case "2":
            //        menuS63.Visible = true;
            //        menuS64.Visible = true;
            //        menuS65.Visible = false;
            //        if ((strStatus == CommDataMag.CommonData.CTUNDISH_STATUS_HOT_FIRE) || (strStatus == CommDataMag.CommonData.CTUNDISH_STATUS_HOT))
            //        {
            //            menuS63.Enabled = true;
            //            menuS64.Enabled = true;
            //            if (strCCMID != "")
            //            {
            //                menuS63.Enabled = false;
            //                menuS64.Enabled = false;
            //                menuCancelDire.Enabled = true;

            //            }
            //            else
            //            {
            //                menuCancelDire.Enabled = false;
            //                menuS63.Enabled = true;
            //                menuS64.Enabled = true;
            //            }
            //        }
            //        else
            //        {
            //            menuS63.Enabled = false;
            //            menuS64.Enabled = false;
            //            menuCancelDire.Enabled = false;
            //        }
            //        break;
            //    case "3":
            //        menuS63.Visible = false;
            //        menuS64.Visible = false;
            //        menuS65.Visible = true;
            //        if ((strStatus == CommDataMag.CommonData.CTUNDISH_STATUS_HOT_FIRE) || (strStatus == CommDataMag.CommonData.CTUNDISH_STATUS_HOT))
            //        {
            //            menuS65.Enabled = true;
            //            if (strCCMID != "")
            //            {
            //                menuCancelDire.Enabled = true;
            //                menuS65.Enabled = false;
            //            }
            //            else
            //            {
            //                menuCancelDire.Enabled = false;
            //                menuS65.Enabled = true;
            //            }
            //        }
            //        else
            //        {
            //            menuS65.Enabled = false;
            //            menuCancelDire.Enabled = false;
            //        }
            //        break;
            //}
        }

        //中包上线
        private void btnONLine_Click(object sender, EventArgs e)
        {
            //string strTundishID=
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            string strCondition = "CheckFlag = 1 and (STATUS = '" + CommDataMag.CommonData.CTUNDISH_STATUS_HOT + "' and Cast_ID is not null)";
            DataRow[] dr = dsTundish.Tables[0].Select(strCondition);
            
            if (dr.Length < 1)
            {
                MessageBox.Show("请选中已经\"指定去向\"并且状态为\"热备\"的中包！","提示");
                return;
            }
            if (dr.Length > 1)
            {
                MessageBox.Show("只能选择\"一个中包\"进行操作！", "提示");
                return;
            }
            string strCastID = dr[0]["Cast_ID"].ToString();
            strCondition = "STATUS = '" + CommDataMag.CommonData.CTUNDISH_STATUS_USE + "' and Cast_ID = '" + strCastID + "'";

            DataRow[] drUse = dsTundish.Tables[0].Select(strCondition);
            if (drUse.Length > 0)
            {
                MessageBox.Show("请先将\"" + drUse[0]["TundishID"].ToString() + "中包\"进行下线操作！", "提示");
                return;
            }

            TundishONorOFFLine onFrm = new TundishONorOFFLine();
            onFrm.ShowDialogEx(Adapter.Session, true, dr[0]["TundishID"].ToString(), dr[0]["TundishNO"].ToString(), dr[0]["Cast_ID"].ToString());
        }

        //中包下线
        private void btnOFFLine_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();

            DataRow[] dr = dsTundish.Tables[0].Select("CheckFlag = 1 and STATUS = '" + CommDataMag.CommonData.CTUNDISH_STATUS_USE + "' and Cast_ID is not null");
            if (dr.Length < 1)
            {
                MessageBox.Show("请选中状态为\"使用(周转)\"的中包！", "提示");
                return;
            }
            if (dr.Length > 1)
            {
                MessageBox.Show("只能选择\"一个中包\"进行操作！", "提示");
                return;
            }
            TundishONorOFFLine onFrm = new TundishONorOFFLine();

            onFrm.ShowDialogEx(Adapter.Session, false, dr[0]["TundishID"].ToString(), dr[0]["TundishNO"].ToString(), dr[0]["Cast_ID"].ToString());
        }

        private void dvTundish_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //永久层砌筑(打结)
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_INNER_BUILD, Color.DarkOrange, Color.Blue); 

            //永久层烘烤 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_INNER_FIRE, Color.Plum, Color.Blue);

            //工作层砌筑(打结) 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_WORK_DAUB, Color.Goldenrod, Color.Blue);

            //工作层烘烤
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
              "Status", CommDataMag.CommonData.CTUNDISH_STATUS_WORK_FIRE, Color.HotPink, Color.Blue);

            //冷备 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_COLD, Color.YellowGreen, Color.Blue);

            //中包上件 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_ISTALL, Color.GreenYellow, Color.Blue);

            //热备烘烤 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_HOT_FIRE, Color.OrangeRed, Color.Blue);

            //热备 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_HOT, Color.LightSeaGreen, Color.Blue);

            //使用(周转) 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_USE, Color.Red, Color.Blue);

            //离线待修 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvTundish, "TundishID",
                "Status", CommDataMag.CommonData.CTUNDISH_STATUS_OFFLINE, SystemColors.Control, Color.Blue);
        }

        private void TundishBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TundishAddShowFrm frm = new TundishAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            DataRow[] drArray = dsTundish.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CTUNDISH_STATUS_OFFLINE + "'");
            if (drArray.Length < 1)
            {
                MessageBox.Show("请选择状态为\"离线待修\"的中包", "提示", MessageBoxButtons.OK);
                return;
            }
            string strMessage = "";
            for (int i = dsTundish.Tables[0].Rows.Count - 1; i >= 0; i--)
            {
                if (dsTundish.Tables[0].Rows[i]["CheckFlag"].ToString() == "1" && dsTundish.Tables[0].Rows[i]["Status"].ToString() == "10")
                {
                    strMessage += dsTundish.Tables[0].Rows[i]["TundishID"].ToString() + ",";
                    //dsTundish.Tables[0].Rows.RemoveAt(i);
                }
            }
            strMessage = strMessage.Substring(0, strMessage.Length - 1);
            string deleteConfirm = MessageBox.Show("确认要删除" + strMessage + "号中包么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (deleteConfirm != "Yes")
                return;
            for (int i = dvTundish.RowCount - 1; i >= 0; i--)
            {
                if (dvTundish.Rows[i].Cells["CheckFlag"].Value.ToString() == "1" && dvTundish.Rows[i].Cells["Status"].Value.ToString() == "10")
                {
                    bsTundish.RemoveAt(i);
                }
            }
            object objDel = null;
            dsTundish.CommitDeleted(ref objDel);
            if (objDel == null)
                MessageBox.Show("删除失败！", "提示");
            else
                MessageBox.Show("成功删除" + objDel + "条记录！", "提示");
            dsTundish.LoadData();
        }

        //中包异常下线
        private void btnOffLineException_Click(object sender, EventArgs e)
        {
            dvTundish.EndEdit();
            bsTundish.EndEdit();
            if (JudgeValueRowCount(cmdOffLineException))
            {
                string strYesNo = MessageBox.Show("确认所选中包异常下线", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo != "Yes")
                    return;
                cmdOffLineException.Execute();
            }
        }
    }
}