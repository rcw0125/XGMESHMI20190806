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
    public partial class GenCastingPlanFrm : DockContent, IMESForm
    {
        public GenCastingPlanFrm()
        {
            InitializeComponent();
        }

        private string[] strArrValue = new string[5];
        private Color[] ColorArr = new Color[5];
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

        //浇钢计划排产
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null");
            if (dr.Length < 1)
            {
                MessageBox.Show("没有选择计划或者没有选择铸机或者当前没有计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// MODIFY BY Huyunhai 2011-03-13
            else if (dr.Length > 1)
            {
                MessageBox.Show("只能一次性选择一条计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//MODIFY END

            //校验实际投用量
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
                {
                    if (MessageBox.Show("计划订单号为\"" + dr[iIndex]["PLANID"].ToString() + "\"的投用量超过1600吨，确认要编制此浇钢计划么？",
                        "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
                    {
                        dsCasting.Tables[0].ImportRow(dr[iIndex]);
                    }
                }
                else
                {
                    dsCasting.Tables[0].ImportRow(dr[iIndex]);
                }
            }
            if (dsCasting.Tables[0].Rows.Count < 1)
                return;
            //Modify Begin At 2011-03-13 By Huyunhai

            //if (MessageBox.Show("当前有\"" + dsCasting.Tables[0].Rows.Count + "\"条浇钢计划需要编制？",
            //    "提示", MessageBoxButtons.OKCancel).ToString() == "OK")

            if (MessageBox.Show("符合浇钢计划要求，确定编制吗？",
                "提示", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//订单号
                string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//钢种
                string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//协议
                string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//工艺路径
                string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//规格
                string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//物料代码
                string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//制造标准
                string Flag = "";

                SelProductPathFrm sppf = new SelProductPathFrm();
                sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
                //L3cmdpGenCasting.SourceProperty = "L3DataTable";
                //L3cmdpGenCasting.SourceObject = dsCasting;
                Flag = sppf.returnFlag;
                string tt = sppf.isExcute;
                int iRot = -1;
                if (tt.Substring(0, 2).Equals("确定"))
                {
                    cmdGenCasting.Parameters[0].SourceObject = dsCasting;
                    cmdGenCasting.Parameters[0].SourceProperty = "L3DataTable";
                    cmdGenCasting.Parameters[1].ConstantValue = Flag;
                    iRot = cmdGenCasting.Execute();
                    //dsGenCasting.LoadData();
                }
                else
                    return;

                if (iRot == 0)
                {

                    string returnFlag = cmdGenCasting.Command.Return.ToString();

                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        dsGenCasting.LoadData();
                        MessageBox.Show(strReasultShow + "！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("编制浇钢计划不成功！" + strReasultShow, "提示");
                    }
                }
                else
                {
                    MessageBox.Show("编制浇钢计划不成功！", "提示");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
            //Modify END
        }

        //取消收池
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();
            string check = MessageBox.Show("确认要取消收池么？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdIntegrateCancel.Execute();
                dsGenCasting.LoadData();
                String returnFlag = cmdIntegrateCancel.Command.Return.ToString();
                if (returnFlag == "1" && dsGenCasting.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("取消收池成功！", "提示");
                }
                else
                {
                    MessageBox.Show("取消收池不成功！", "提示");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
        }



        private void GenCastingPlanFrm_Load(object sender, EventArgs e)
        {
            strArrValue[0] = "11";//未排产
            strArrValue[1] = "13";//产生浇钢计划
            strArrValue[2] = "14";//产生出钢计划
            strArrValue[3] = "15";//执行
            strArrValue[4] = "16";//执行完成

            ColorArr[0] = System.Drawing.SystemColors.Control;//未排产
            ColorArr[1] = System.Drawing.Color.FromArgb(190, 190, 115);
            ColorArr[2] = System.Drawing.Color.FromArgb(210, 140, 170);
            ColorArr[3] = System.Drawing.Color.Red;
            ColorArr[4] = System.Drawing.Color.FromArgb(150, 220, 200);

            tstdtpEndDate.Value = DateTime.Now;
            tstdtpBeginDate.Value = DateTime.Now;
            for (int i = 0; i < dsSteelGrade.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGrade.Items.Add(dsSteelGrade.Tables[0].Rows[i]["SteelGrade"].ToString());
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvGenCasting_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvGenCasting, "sTATUSDataGridViewTextBoxColumn", strArrValue, ColorArr);//绘制颜色
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsGenCasting.LoadData();
        }

        //删除计划订单[20090110 Liao]
        private void btnDel_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            DataSet dsDel = (DataSet)(cmdDel.Parameters[0].Value);
            if (dsDel == null || dsDel.Tables[0].Rows.Count < 1)
                return;
            if (cmdDel.Execute() >= 0)
            {
                if (Convert.ToBoolean(cmdDel.Command.Return))
                {
                    MessageBox.Show("删除计划订单成功！", "提示", MessageBoxButtons.OK);
                    dsGenCasting.LoadData();
                }
                else
                {
                    MessageBox.Show("删除计划订单失败！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("删除计划订单失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void GenCastingPlanFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //关闭计划订单[2009-04-19 sun]
        private void btnClosePlan_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            DataSet dsClose = (DataSet)(cmdDel.Parameters[0].Value);
            if (dsClose == null || dsClose.Tables[0].Rows.Count < 1)
                return;
            string strFalg = MessageBox.Show("确认要关闭计划订单么？计划订单关闭后则不能再排产！", "提示", MessageBoxButtons.YesNo).ToString();
            if (strFalg == "No")
                return;
            if (cmdClose.Execute() >= 0)
            {
                if (Convert.ToBoolean(cmdClose.Command.Return))
                {
                    MessageBox.Show("关闭计划订单成功！", "提示", MessageBoxButtons.OK);
                    dsGenCasting.LoadData();
                }
                else
                {
                    MessageBox.Show("关闭计划订单失败！", "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("关闭计划订单失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnSteelLess_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
            if (dr.Length < 1)
            {
                MessageBox.Show("请选择不锈钢计划订单，或者没有选择计划或者没有选择铸机或者当前没有计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// MODIFY BY Huyunhai 2011-03-13
            else if (dr.Length > 1)
            {
                MessageBox.Show("只能一次性选择一条计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//MODIFY END



            //校验实际投用量
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
                {
                    if (MessageBox.Show("计划订单号为\"" + dr[iIndex]["PLANID"].ToString() + "\"的投用量超过1600吨，确认要编制此浇钢计划么？",
                        "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
                    {
                        dsCasting.Tables[0].ImportRow(dr[iIndex]);
                    }
                }
                else
                {
                    dsCasting.Tables[0].ImportRow(dr[iIndex]);
                }
            }
            if (dsCasting.Tables[0].Rows.Count < 1)
                return;
            //Modify Begin At 2011-03-13 By Huyunhai

            //if (MessageBox.Show("当前有\"" + dsCasting.Tables[0].Rows.Count + "\"条浇钢计划需要编制？",
            //    "提示", MessageBoxButtons.OKCancel).ToString() == "OK")

            if (MessageBox.Show("符合浇钢计划要求，确定编制吗？",
                "提示", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//订单号
                string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//钢种
                string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//协议

                string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//工艺路径
                if (Path != "AL")
                {
                    MessageBox.Show("请选择不锈钢订单");
                    return;
                }
                string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//规格
                string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//物料代码
                string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//制造标准
                string Flag = "";

                SelProductPathFrm sppf = new SelProductPathFrm();
                sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
                //L3cmdpGenCasting.SourceProperty = "L3DataTable";
                //L3cmdpGenCasting.SourceObject = dsCasting;
                Flag = sppf.returnFlag;
                string tt = sppf.isExcute;
                int iRot = -1;
                if (tt.Substring(0, 2).Equals("确定"))
                {
                    cmdSteelLess.Parameters[0].SourceObject = dsCasting;
                    cmdSteelLess.Parameters[0].SourceProperty = "L3DataTable";
                    cmdSteelLess.Parameters[1].ConstantValue = Flag;
                    iRot = cmdSteelLess.Execute();
                    //dsGenCasting.LoadData();
                }
                else
                    return;

                if (iRot == 0)
                {

                    string returnFlag = cmdSteelLess.Command.Return.ToString();

                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        dsGenCasting.LoadData();
                        MessageBox.Show(strReasultShow + "！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("编制浇钢计划不成功！" + strReasultShow, "提示");
                    }
                }
                else
                {
                    MessageBox.Show("编制浇钢计划不成功！", "提示");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
        }

        //private void btnMelt_Click(object sender, EventArgs e)
        //{
        //    dvGenCasting.EndEdit();
        //    bsGenCasting.EndEdit();

        //    AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
        //    DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
        //    if (dr.Length < 1)
        //    {
        //        MessageBox.Show("请选择不锈钢计划订单，或者没有选择计划或者没有选择铸机或者当前没有计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }// MODIFY BY Huyunhai 2011-03-13
        //    else if (dr.Length > 1)
        //    {
        //        MessageBox.Show("只能一次性选择一条计划！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }//MODIFY END



        //    //校验实际投用量
        //    for (int iIndex = 0; iIndex < dr.Length; iIndex++)
        //    {
        //        if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
        //        {
        //            if (MessageBox.Show("计划订单号为\"" + dr[iIndex]["PLANID"].ToString() + "\"的投用量超过1600吨，确认要编制此浇钢计划么？",
        //                "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
        //            {
        //                dsCasting.Tables[0].ImportRow(dr[iIndex]);
        //            }
        //        }
        //        else
        //        {
        //            dsCasting.Tables[0].ImportRow(dr[iIndex]);
        //        }
        //    }
        //    if (dsCasting.Tables[0].Rows.Count < 1)
        //        return;
        //    //Modify Begin At 2011-03-13 By Huyunhai

        //    //if (MessageBox.Show("当前有\"" + dsCasting.Tables[0].Rows.Count + "\"条浇钢计划需要编制？",
        //    //    "提示", MessageBoxButtons.OKCancel).ToString() == "OK")

        //    if (MessageBox.Show("符合浇钢计划要求，确定编制吗？",
        //        "提示", MessageBoxButtons.OKCancel).ToString() == "OK")
        //    {
        //        string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//订单号
        //        string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//钢种
        //        string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//协议

        //        string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//工艺路径
        //        //if (MaterialCode.Substring (0,3) != "617")
        //        //{
        //        //    MessageBox.Show("请选择熔化炉碳钢订单");
        //        //    return;
        //        //}
        //        string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//规格
        //        string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//物料代码
        //        string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//制造标准
        //        string Flag = "";

        //        SelProductPathFrm sppf = new SelProductPathFrm();
        //        sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
        //        //L3cmdpGenCasting.SourceProperty = "L3DataTable";
        //        //L3cmdpGenCasting.SourceObject = dsCasting;
        //        Flag = sppf.returnFlag;
        //        string tt = sppf.isExcute;
        //        int iRot = -1;
        //        if (tt.Substring(0, 2).Equals("确定"))
        //        {
        //            cmdSteelLess.Parameters[0].SourceObject = dsCasting;
        //            cmdSteelLess.Parameters[0].SourceProperty = "L3DataTable";
        //            cmdSteelLess.Parameters[1].ConstantValue = Flag;
        //            iRot = cmdSteelLess.Execute();
        //            //dsGenCasting.LoadData();
        //        }
        //        else
        //            return;

        //        if (iRot == 0)
        //        {

        //            string returnFlag = cmdSteelLess.Command.Return.ToString();

        //            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
        //            if (returnFlag == "0")
        //            {
        //                dsGenCasting.LoadData();
        //                MessageBox.Show(strReasultShow + "！", "提示");
        //            }
        //            else
        //            {
        //                MessageBox.Show("编制浇钢计划不成功！" + strReasultShow, "提示");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("编制浇钢计划不成功！", "提示");
        //        }
        //    }
        //    else
        //    {
        //        dsGenCasting.LoadData();
        //    }
        //}


    }
}