using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace PlanMag
{
    public partial class GenTappingPlanFrm : DockContent, IMESForm
    {
        public GenTappingPlanFrm()
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

        private string[] strArrValue = new string[4];
        private Color[] ColorArr = new Color[4];

        private int iFlag = 1;
        private string strOldValue = "";
        private string strNewValue = "";
        private string strRefineType = "";
        private string strNewBofFlag = "";
        private string strBOFID = "";
        private string strSteelGradeIndex = "";
        private string strMaterialCode = "";
        private void GenTappingPlanFrm_Load(object sender, EventArgs e)
        {
            strArrValue[0] = "10";//未排产
            strArrValue[1] = "11";//已排产
            strArrValue[2] = "12";//执行
            strArrValue[3] = "13";//执行完成

            ColorArr[0] = System.Drawing.SystemColors.Control;//未排产
            ColorArr[1] = System.Drawing.Color.FromArgb(210, 140, 170);
            ColorArr[2] = System.Drawing.Color.Red;
            ColorArr[3] = System.Drawing.Color.FromArgb(150, 220, 200);

            tstdtpCreateDate.Value = DateTime.Now;
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
            {
                tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void tscmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tstxtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.SelectedItem.ToString());
        }

        private void contextCasting_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dvTapping.Rows.Count; i++)
            {
                dvTapping.Rows[i].Cells[0].Value = 1;
            }
        }

        //编制出钢计划
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvTapping.EndEdit();
            bsTapping.EndEdit();

            //AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            //DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
            //if (dr.Length < 1)
            //{
            //    MessageBox.Show("请选择不锈钢计划订单，或者没有选择计划或则没有选择铸机或则当前没有计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}// MODIFY BY Huyunhai 2011-03-13
            //else if (dr.Length > 1)
            //{
            //    MessageBox.Show("对不起，只能一次性选择一条计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}//MODIFY END



            ////校验实际投用量
            //for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            //{
            //    if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
            //    {
            //        if (MessageBox.Show("计划订单号为\"" + dr[iIndex]["PLANID"].ToString() + "\"的投用量超过1600吨，确认要编制此浇钢计划么？",
            //            "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            //        {
            //            dsCasting.Tables[0].ImportRow(dr[iIndex]);
            //        }
            //    }
            //    else
            //    {
            //        dsCasting.Tables[0].ImportRow(dr[iIndex]);
            //    }
            //}

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsTapping.Clone();
            DataRow[] dr = dsTapping.Tables[0].Select("CheckFlag = 1");
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                //if (dr[iIndex]["BOFID"].ToString() == "S25")
                if (dr[iIndex]["Pre_SteelGradeIndex"].ToString().Substring(0, 1) == "B")
                {
                    MessageBox.Show("请选择不锈钢计划排产！");
                    return;
                }
                if (dr[iIndex]["BOFID"].ToString() != "S51" && dr[iIndex]["MaterialCode"].ToString().Substring(0, 3) == "617")
                {
                    MessageBox.Show("请选择熔化炉！");
                    return;
                }

            }



            string check = MessageBox.Show("确认要编制出钢计划么？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTapping1.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdTapping1.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "！", "提示");
                }
                else
                {
                    MessageBox.Show("编制出钢计划不成功！" + returnFlag, "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //取消浇钢计划
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            string check = MessageBox.Show("确认要取消浇钢计划么？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdCastingCancel.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdCastingCancel.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("取消浇钢计划成功！", "提示");
                }
                else
                {
                    MessageBox.Show("取消浇钢计划不成功！", "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvTapping_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvTapping, "STATUS", strArrValue, ColorArr);//绘制颜色
        }

        //判断选择工艺路径是否正确
        private void dvTapping_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if ((bsTapping.Position < 0) || (dvTapping.CurrentCell.ColumnIndex == 0))
                return;

            iFlag += 1;
            if (iFlag == 1)
            {
                strOldValue = dvTapping.CurrentCell.Value.ToString();
                strRefineType = dvTapping.Rows[bsTapping.Position].Cells["REFINE_TYPE"].Value.ToString();
                strNewBofFlag = dvTapping.Rows[bsTapping.Position].Cells["NEW_BOF_FLAG"].Value.ToString();
                strSteelGradeIndex = dvTapping.Rows[bsTapping.Position].Cells["pRESTEELGRADEINDEXDataGridViewTextBoxColumn"].Value.ToString();
                strMaterialCode = dvTapping.Rows[bsTapping.Position].Cells["MaterialCode"].Value.ToString();
                strBOFID = dvTapping.Rows[bsTapping.Position].Cells["BOFID"].Value.ToString();
            }
            dvTapping.EndEdit();

            strNewValue = dvTapping.CurrentCell.Value.ToString();
            //if (strNewBofFlag == "1" && iFlag == 2)              //取消了4#转炉不允许上3、4#铸机的限制。2017-11-07
            //{
            //    MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dvTapping.CurrentCell.Value = strOldValue;
            //}
            //else if (strNewBofFlag == "0" && iFlag == 2)
             if (strNewBofFlag == "0" && iFlag == 2)
            {
                //选择RH炉
                if (dvTapping.CurrentCell.ColumnIndex == 6 && strNewValue=="S51")//注意RH也为S51
                {
                    MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dvTapping.CurrentCell.Value = strOldValue;
                }
                //选择转炉
                else if (dvTapping.CurrentCell.ColumnIndex == 3)
                {
                    if (strNewValue == "S24")
                    {
                        MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dvTapping.CurrentCell.Value = strOldValue;
                    }
                    else if (strRefineType == "A" && dvTapping.CurrentCell.ColumnIndex == 3)
                    {
                        if (strNewValue != "S51")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "0" && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    {
                        if (strNewValue == "S51" && strMaterialCode.Substring (0,3) != "617")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                        else if (strNewValue == "S25")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L" && dvTapping.CurrentCell.ColumnIndex == 3 &&  strSteelGradeIndex.Substring (0,1)=="B")
                    {
                        if (strNewValue != "S25")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L" && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    {
                        if (strNewValue == "S51" || strNewValue == "S25")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    //else if ((strRefineType == "L" || strRefineType == "0" ) && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    //{
                    //    if (strNewValue == "S25")
                    //    {
                    //        MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        dvTapping.CurrentCell.Value = strOldValue;
                    //    }
                    //}

                }

                //选择LF炉
                else if (dvTapping.CurrentCell.ColumnIndex == 5)
                {
                    if (strRefineType == "0" && strBOFID == "S51")//此处S51为熔化炉
                    {
                        if (strOldValue != strNewValue)
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L")
                    {
                        if (strNewValue == "S43" || strNewValue == "0")
                        {
                            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                }
            }
            iFlag = 0;
        }

        //判断选择工艺路径是否正确
        //private void routeJudge()
        //{
        //    //if ((bsTapping.Position < 0) || (dvTapping.CurrentCell.ColumnIndex == 0))
        //    //    return;

        //    iFlag += 1;
        //    if (iFlag == 1)
        //    {
        //        strOldValue = dvTapping.CurrentCell.Value.ToString();
        //        strRefineType = dvTapping.Rows[bsTapping.Position].Cells["REFINE_TYPE"].Value.ToString();
        //        strNewBofFlag = dvTapping.Rows[bsTapping.Position].Cells["NEW_BOF_FLAG"].Value.ToString();
        //    }
        //    dvTapping.EndEdit();

        //    strNewValue = dvTapping.CurrentCell.Value.ToString();
        //    if (strNewBofFlag == "1" && iFlag == 2)
        //    {
        //        MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dvTapping.CurrentCell.Value = strOldValue;
        //    }
        //    else if (strNewBofFlag == "0" && iFlag == 1)
        //    {
        //        //选择RH炉
        //        if (dvTapping.CurrentCell.ColumnIndex == 5)
        //        {
        //            MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            dvTapping.CurrentCell.Value = strOldValue;
        //        }
        //        //选择转炉
        //        else if (dvTapping.CurrentCell.ColumnIndex == 3)
        //        {
        //            if (strNewValue == "S24")
        //            {
        //                MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                dvTapping.CurrentCell.Value = strOldValue;
        //            }
        //            else if (strRefineType == "A" && dvTapping.CurrentCell.ColumnIndex == 3)
        //            {
        //                if (strNewValue != "S51")
        //                {
        //                    MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //        }

        //        //选择LF炉
        //        else if (dvTapping.CurrentCell.ColumnIndex == 4)
        //        {
        //            if (strRefineType == "0")
        //            {
        //                if (strOldValue != strNewValue)
        //                {
        //                    MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //            else if (strRefineType == "L")
        //            {
        //                if (strNewValue == "S43" || strNewValue == "0")
        //                {
        //                    MessageBox.Show("工艺路径不允许修改！", "注意！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //        }
        //    }
        //    iFlag = 0;
        //}

        private void btnTappingAct_Click(object sender, EventArgs e)
        {
            TappingActFrm frm = new TappingActFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void GenTappingPlanFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void BuSteelBtn_Click(object sender, EventArgs e)
        {
            //routeJudge();
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsTapping.Clone();
            DataRow[] dr = dsTapping.Tables[0].Select("CheckFlag = 1");
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                //if (dr[iIndex]["BOFID"].ToString() == "S25")
                if (dr[iIndex]["Pre_SteelGradeIndex"].ToString().Substring(0, 1) != "B")
                {
                    MessageBox.Show("所选计划非不锈钢，请选择出钢计划排产！");
                    return;
                }

            }

            string check = MessageBox.Show("确认要编制出钢计划么？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTapping.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdTapping.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                   // updateHeatid.Execute();
                    MessageBox.Show(strReasultShow + "！", "提示");
                }
                else
                {
                    MessageBox.Show("编制出钢计划不成功！" + returnFlag, "提示");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }
    }
}