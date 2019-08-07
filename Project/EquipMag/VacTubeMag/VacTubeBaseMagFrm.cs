using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.VacTubeMag
{
    public partial class VacTubeBaseMagFrm : DockContent, IMESForm
    {
        public VacTubeBaseMagFrm()
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

     
        //控件加载
        private void VacTubeBaseMagFrm_Load(object sender, EventArgs e)
        {
            cmdBuildStart.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE + "'";
            cmdBuildEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_REPAIR + "' and Flag = '0'";

            cmdHotOn.Parameters[0].SourceFilter = "CheckFlag = 1 and VacTube_Name = '3' and  Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_COLD + "'";
            cmdHotOff.Parameters[0].SourceFilter = "CheckFlag = 1 and VacTube_Name = '3' and  Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_USE + "'";

          }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //真空槽槽管砌筑开始
        private void btnBuildStart_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdBuildStart))
            {
                cmdBuildStart.Execute();
            }
        }

        //真空槽槽管砌筑结束
        private void btnBuildEnd_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdBuildEnd))
            {
                cmdBuildEnd.Execute();
            }
        }


        //热弯管砌筑开始
        private void btnHotBuildStart_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdBuildStart))
            {
                cmdBuildStart.Execute();
            }
        }

        //热弯管砌筑结束
        private void btnHotBuildEnd_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdBuildEnd))
            {
                cmdBuildEnd.Execute();
            }
        }

        //换上热弯管
        private void btnHotOn_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdHotOn))
            {
                cmdHotOn.Execute();
            }
        }

        //换下热弯管
        private void btnHotOff_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdHotOff))
            {
                cmdHotOff.Execute();
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

        //上位
        private void btnOnPosition_Click(object sender, EventArgs e)
        {
            string strbtnName = ((ToolStripMenuItem)sender).Name;
            AppSvrHMI.L3DataSet dsSend = SetDSOnPositon(strbtnName);
            if (dsSend != null)
            {
                cmdOnPosition.Parameters[0].SourceObject = dsSend;
                cmdOnPosition.Parameters[0].SourceProperty = "L3DataTable";
                cmdOnPosition.Execute();
            }
        }

        private AppSvrHMI.L3DataSet SetDSOnPositon(string strbtnName)
        {
            AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();
            dsSend = (AppSvrHMI.L3DataSet)dsBase.Clone();
            dvBase.EndEdit();
            bsBase.EndEdit();

            int iPosition1 = 0;//上部槽
            int iPosition2 = 0;//下部槽
            int iPosition3 = 0;//热弯管

            DataRow[] drTemp = dsBase.Tables[0].Select("CheckFlag = 1");
            foreach (DataRow dr in drTemp)
            {
                dsSend.Tables[0].ImportRow(dr);
            }
            
            switch (strbtnName)
            {
                case "btnOnBuildPosition":
                    foreach (DataRow dr in dsSend.Tables[0].Rows)
                        dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_BUILD;
                    break;
                case "btnOnFirePositionA"://A烘烤位    
                    iPosition1 = dsBase.Tables[0].Select("VacTube_Name = '1' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_A + "'").Length;
                    iPosition2 = dsBase.Tables[0].Select("VacTube_Name = '2' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_A + "'").Length;
                    iPosition3 = dsBase.Tables[0].Select("VacTube_Name = '3' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_A + "'").Length;
                    foreach (DataRow dr in dsSend.Tables[0].Rows)
                    {
                        string strType = dr["VacTube_Name"].ToString();

                        if (strType == "1")
                        {
                            if (iPosition1 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前烘烤位上不能有多个上部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] =  CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_A;
                            iPosition1 += 1;
                        }
                        else if (strType == "2")
                        {
                            if (iPosition2 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前烘烤位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_A;
                            iPosition2 += 1;
                        }
                        else if (strType == "3")
                        {
                            return null;
                        }
                    }
                    break;
                case "btnOnFirePositionB"://B烘烤位  
                    iPosition1 = dsBase.Tables[0].Select("VacTube_Name = '1' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_B + "'").Length;
                    iPosition2 = dsBase.Tables[0].Select("VacTube_Name = '2' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_B + "'").Length;
                    iPosition3 = dsBase.Tables[0].Select("VacTube_Name = '3' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_B + "'").Length;

                    foreach (DataRow dr in dsSend.Tables[0].Rows)
                    {
                        string strType = dr["VacTube_Name"].ToString();

                        if (strType == "1")
                        {
                            if (iPosition1 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前烘烤位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_B;
                            iPosition1 += 1;
                        }
                        else if (strType == "2")
                        {
                            if (iPosition2 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前烘烤位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_FIRE_B;
                            iPosition2 += 1;
                        }
                        else if (strType == "3")
                        {
                            return null;
                        }
                    }
                    break;
                case "btnOnWorkPositionA"://A工位  
                    iPosition1 = dsBase.Tables[0].Select("VacTube_Name = '1' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "'").Length;
                    iPosition2 = dsBase.Tables[0].Select("VacTube_Name = '2' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "'").Length;
                    iPosition3 = dsBase.Tables[0].Select("VacTube_Name = '3' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "'").Length;

                    foreach (DataRow dr in dsSend.Tables[0].Rows)
                    {
                        string strType = dr["VacTube_Name"].ToString();

                        if (strType == "1")
                        {
                            if (iPosition1 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A;
                            iPosition1 += 1;
                        }
                        else if (strType == "2")
                        {
                            if (iPosition2 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A;
                            iPosition2 += 1;
                        }
                        else if (strType == "3")
                        {
                            if (iPosition3 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个热弯管！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A;
                            iPosition3 += 1;
                        }
                    }
                    break;
                case "btnOnWorkPositionB"://B工位  
                    iPosition1 = dsBase.Tables[0].Select("VacTube_Name = '1' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "'").Length;
                    iPosition2 = dsBase.Tables[0].Select("VacTube_Name = '2' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "'").Length;
                    iPosition3 = dsBase.Tables[0].Select("VacTube_Name = '3' and Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "'").Length;

                    foreach (DataRow dr in dsSend.Tables[0].Rows)
                    {
                        string strType = dr["VacTube_Name"].ToString();

                        if (strType == "1")
                        {
                            if (iPosition1 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B;
                            iPosition1 += 1;
                        }
                        else if (strType == "2")
                        {
                            if (iPosition2 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个下部槽！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B;
                            iPosition2 += 1;
                        }
                        else if (strType == "3")
                        {
                            if (iPosition3 > 0)
                            {
                                MessageBox.Show("上位操作不允许,当前工位上不能有多个热弯管！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                            dr["Position"] = CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B;
                            iPosition3 += 1;
                        }
                    }
                    break;
                default:
                    break;
            }
            dsSend.AcceptChanges();
            return dsSend;
        }

        //处理开始
        private void btnProcessStart_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string strConditon = "VacTube_Name <> '3' and Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_HOT + "'";
            //    strConditon += " and (Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "'";
            //    strConditon += "  or Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "')";
            //    DataRow[] dr = dsBase.Tables[0].Select(strConditon);
            //    if (dr.Length == 0 || dr.Length == 1)
            //    {
            //        MessageBox.Show("没有满足RH处理开始的真空槽！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //    {
            //        DataSet ds = dsBase.Clone();
            //        foreach (DataRow r in dr)
            //        {
            //            ds.Tables[0].ImportRow(r);
            //        }
            //        RHAreaOperation Frm = new RHAreaOperation();
            //        Frm.ShowDialogEx(Adapter.Session, ds,0);
            //    }
            //}
            //catch { }
            VacTubeOnLineFrm frm = new VacTubeOnLineFrm();
            frm.operatetype = OperateType.OperateStart;
            frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
        }

        //处理结束
        private void btnProcessEnd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string strConditon = "VacTube_Name <> '3' and Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_USE + "'";
            //    strConditon += " and (Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_A + "'";
            //    strConditon += "  or Position = '" + CommDataMag.CommonData.CVACTUBE_POSITION_WORK_B + "')";
            //    DataRow[] dr = dsBase.Tables[0].Select(strConditon);
            //    if (dr.Length == 0 || dr.Length == 1)
            //    {
            //        MessageBox.Show("没有满足RH处理结束的真空槽！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //    {
            //        DataSet ds = dsBase.Clone();
            //        foreach (DataRow r in dr)
            //        {
            //            ds.Tables[0].ImportRow(r);
            //        }

            //        RHAreaOperation Frm = new RHAreaOperation();
            //        Frm.ShowDialogEx(Adapter.Session, ds,1);
            //    }
            //}
            //catch { }
            VacTubeOnLineFrm frm = new VacTubeOnLineFrm();
            frm.operatetype = OperateType.OperateEnd;
            frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    
        private void VacTubeBaseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //添加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            VacTubeAddShowFrm frm = new VacTubeAddShowFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //删除
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dvBase.EndEdit();
                bsBase.EndEdit();
                DataRow[] drArray = dsBase.Tables[0].Select("CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE + "'");
                if (drArray.Length < 1)
                {
                    MessageBox.Show("请选择状态为\"下线\"的真空槽或热弯管", "提示", MessageBoxButtons.OK);
                    return;
                }
                string strMessage = "";
                for (int i = dsBase.Tables[0].Rows.Count - 1; i >= 0; i--)
                {
                    if (dsBase.Tables[0].Rows[i]["CheckFlag"].ToString() == "1" && dsBase.Tables[0].Rows[i]["Status"].ToString() == CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE)
                    {
                        strMessage += dsBase.Tables[0].Rows[i]["VacTube_ID"].ToString() + ",";
                        //dsBase.Tables[0].Rows.RemoveAt(i);
                    }
                }
                strMessage = strMessage.Substring(0, strMessage.Length - 1);
                string deleteConfirm = MessageBox.Show("确认要删除" + strMessage + "号么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (deleteConfirm != "Yes")
                    return;
                for (int i = dvBase.RowCount - 1; i >= 0; i--)
                {
                    if (dvBase.Rows[i].Cells["checkFlagDataGridViewTextBoxColumn"].Value.ToString() == "1" && dvBase.Rows[i].Cells["Status"].Value.ToString() == CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE)
                    {
                        bsBase.RemoveAt(i);
                    }
                }
                object objDel = null;
                dsBase.CommitDeleted(ref objDel);
                if (objDel == null)
                    MessageBox.Show("删除失败！", "提示");
                else
                    MessageBox.Show("成功删除" + objDel + "条记录！", "提示");
                dsBase.LoadData();
            }
            catch { }
        }

        //组装
        private void btnInstall_Click(object sender, EventArgs e)
        {
            VacTubeInstallFrm frm = new VacTubeInstallFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //烘烤
        private void btnFire_Click(object sender, EventArgs e)
        {
            VacTubeOnFireFrm frm = new VacTubeOnFireFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //检查
        private void btnCheck_Click(object sender, EventArgs e)
        {
            VacTubeOnLineFrm frm = new VacTubeOnLineFrm();
            frm.operatetype = OperateType.OperateCheck;
            frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
        }

        //检查完毕
        private void btnCheckOver_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem btncheck = (ToolStripDropDownItem)sender;
            if (btncheck.Tag == null)
                return;

            VacTubeOffLineFrm frm = new VacTubeOffLineFrm();
            if (btncheck.Tag.ToString() == "1")
                frm.checkovertype = CheckOverType.ToCold;
            else if (btncheck.Tag.ToString() == "2")
                frm.checkovertype = CheckOverType.ToRepair;
            else if (btncheck.Tag.ToString() == "3")
                frm.checkovertype = CheckOverType.ToBuild;
            else
                return;
            frm.ShowDialogEx(Adapter.Session);
            GC.Collect(); 
        }

        private void dvBase_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //离线待修
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_OFFLINE, SystemColors.Control, Color.Blue);

            //维修
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_REPAIR, Color.DarkOrange, Color.Blue);

            //冷备
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_COLD, Color.LightSeaGreen, Color.Yellow);

            //小火
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_PRE_FIRE, Color.HotPink, Color.Blue);

            //大火
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_BIG_FIRE, Color.OrangeRed, Color.Blue);

            //热备
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_HOT, Color.LightSeaGreen, Color.Blue);

            //在线使用
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_USE, Color.Red, Color.Blue);

            //下线检测
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "VacTube_ID",
                "Status", CommDataMag.CommonData.CVACTUBE_STATUS_CHECK, Color.Yellow, Color.Blue);
        }
    }
}