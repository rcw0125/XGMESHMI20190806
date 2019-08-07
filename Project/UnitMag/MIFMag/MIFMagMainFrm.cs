//Modify by hyh 2012-03-29 
//界面新增3#混铁炉
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.MIFMag
{
    public partial class MIFMagMainFrm : DockContent, IMESForm
    {
        public MIFMagMainFrm()
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

        //铁水到达确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //ConfirmIronFrm frm = new ConfirmIronFrm();
            //frm.ShowDialogEx(Adapter.Session, "");
            //dsInIrons.LoadData();
            try
            {

                dvDestIrons.EndEdit();
                bsDestIrons.EndEdit();

                DataSet dsSend = (DataSet)(l3cmdConfirm.Parameters[0].Value);
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                if (l3cmdConfirm.Execute() >= 0)
                {
                    int iRet = Convert.ToInt32(l3cmdConfirm.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("确认成功！", "提示");
                    else
                        MessageBox.Show("确认失败！", "提示");
                }
                else
                    MessageBox.Show("确认失败！", "提示");
            }
            catch { }
            dsDestIron.LoadData();
            dsInIron.LoadData();
        }

        //直兑
        private void btnDirect_Click(object sender, EventArgs e)
        {
            DirectFeedIronFrm frm = new DirectFeedIronFrm();
            frm.ShowDialogEx(Adapter.Session, "");
        }

        //3#混铁炉组罐同样调用此方法  hyh 2012-03-29
        //组罐
        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;
            FeedIronFrm frm = new FeedIronFrm();
            frm.ShowDialogEx(Adapter.Session, ctrl.Tag.ToString());
        }

        //3#混铁炉出铁同样调用此方法  hyh 2012-03-29
        //出铁
        private void btnTap_Click(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;//强制转换成Control
            //TextBox ctrl = sender as TextBox;

            double fWeight = 0;
            double fReturnSteelWeight = 0;
            //Modify by hyh 2012-03-29
            if (ctrl.Tag.ToString() == "S11")
            {
                fWeight = double.Parse(this.txS11GrossWeight.Text);
            }
            else if (ctrl.Tag.ToString() == "S12")
            {
                fWeight = double.Parse(this.txS12GrossWeight.Text);
            }
            else if (ctrl.Tag.ToString() == "S13")
            {
                fWeight = double.Parse(this.txS13GrossWeight.Text);
            }
            //end

            TappedFrm frm = new TappedFrm();
            frm.Weight = fWeight;
            frm.ReturnSteelWeight = fReturnSteelWeight;
            if (frm.ShowDialogEx(Adapter.Session) == DialogResult.Cancel)
                return;
            if (frm.LadleID == "")
            {
                MessageBox.Show("没有选择可用的铁包,不能出铁！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (frm.Destination == "")
            {
                MessageBox.Show("没有选择去向,不能出铁！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (frm.Weight < 0)
            {
                MessageBox.Show("铁水重量小于零,不能出铁！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (frm.ReturnSteelWeight < 0)
            {
                MessageBox.Show("回炉钢水量小于零,不能出铁！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string MIFID = ctrl.Tag.ToString();
            AppSvrIF.Command cmd = new AppSvrIF.Command();
            string MIFUri = "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\" + MIFID;
            int iRet = Adapter.Session.CreateCommand((int)AppSvrIF.CommandType.Call, MIFUri, "OutputIron", ref cmd);
            if (iRet != 0)
            {
                //  [12/28/2008 sun]
                // string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", l3cmdIron.Command.ErrorCode));
                MessageBox.Show(string.Format("出铁失败！错误代码：{0:X}", iRet));
                return;
            }

            cmd.set_Parameters(0, frm.LadleID);
            cmd.set_Parameters(1, frm.Weight);
            cmd.set_Parameters(2, frm.ReturnSteelWeight);
            if (frm.Destination == "转炉(碳钢)")
            {
                cmd.set_Parameters(3, "1");
            }
            else 
            {
                cmd.set_Parameters(3, "2");
            }
            iRet = Adapter.Session.Execute(cmd);
            if (iRet != 0 || 0 == (short)cmd.Return)
            {
                if (cmd.ErrorCode == 0xB1001003)
                {
                    MessageBox.Show(string.Format("混铁炉中铁量不足！"));
                }
                else
                {
                    //  [12/28/2008 sun]
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmd.ErrorCode));
                    //MessageBox.Show(string.Format("出铁失败！错误代码：{0:X},{1:X}",cmd.ErrorCode,iRet));
                    MessageBox.Show("出铁失败！" + strReasultShow);
                }
            }
            else
            {
                MessageBox.Show("出铁成功！");
            }
        }

        //存铁量调整
        private void btnTuneWeight_Click(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;
            string MIFID = ctrl.Tag.ToString();
            if (MIFID == "S11")
            {   // 1号混铁炉
                txS11Weight.UpdateData();
                txS11Temp.UpdateData();
                txS11Temp_Time.Text = DateTime.Now.ToString();
                txS11Temp_Time.UpdateData();
                txS11C.UpdateData();
                txS11Mn.UpdateData();
                txS11P.UpdateData();
                txS11S.UpdateData();
                txS11Ti.UpdateData();
                txS11Si.UpdateData();
                txS11Sn.UpdateData();
                txS11Sb.UpdateData();
                txS11As.UpdateData();
                txS11Pb.UpdateData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS11Ni.UpdateData();
                txS11Mo.UpdateData();
                txS11Cu.UpdateData();
                txS11Cr.UpdateData();
                txS11B.UpdateData();
                txS11V.UpdateData();
                txS11Al.UpdateData();
                txS11Nb.UpdateData();
                txS11Zn.UpdateData();
                txS11W.UpdateData();
                //END
                txS11TareWeight.UpdateData();
                txS11Tare_Weight_Time.Text = DateTime.Now.ToString();
                txS11Tare_Weight_Time.UpdateData();
                txS11GrossWeight.UpdateData();
                txS11Gross_Weight_Time.Text = DateTime.Now.ToString();
                txS11Gross_Weight_Time.UpdateData();
            }
            else if (MIFID == "S12")
            {   // 2号混铁炉
                txS12Weight.UpdateData();
                txS12Temp.UpdateData();
                txS12Temp_Time.Text = DateTime.Now.ToString();
                txS12Temp_Time.UpdateData();
                txS12C.UpdateData();
                txS12Mn.UpdateData();
                txS12P.UpdateData();
                txS12S.UpdateData();
                txS12Ti.UpdateData();
                txS12Si.UpdateData();
                txS12Sn.UpdateData();
                txS12Sb.UpdateData();
                txS12As.UpdateData();
                txS12Pb.UpdateData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS12Ni.UpdateData();
                txS12Mo.UpdateData();
                txS12Cu.UpdateData();
                txS12Cr.UpdateData();
                txS12B.UpdateData();
                txS12V.UpdateData();
                txS12Al.UpdateData();
                txS12Nb.UpdateData();
                txS12Zn.UpdateData();
                txS12W.UpdateData();
                //END
                txS12GrossWeight.UpdateData();
                txS12Gross_Weight_Time.Text = DateTime.Now.ToString();
                txS12Gross_Weight_Time.UpdateData();
            }
             //Modify by hyh 2012-03-29
            else if (MIFID == "S13")
            {   // 3号混铁炉
                txS13Weight.UpdateData();
                txS13Temp.UpdateData();
                txS13Temp_Time.Text = DateTime.Now.ToString();
                txS13Temp_Time.UpdateData();
                txS13C.UpdateData();
                txS13Mn.UpdateData();
                txS13P.UpdateData();
                txS13S.UpdateData();
                txS13Ti.UpdateData();
                txS13Si.UpdateData();
                txS13Sn.UpdateData();
                txS13Sb.UpdateData();
                txS13As.UpdateData();
                txS13Pb.UpdateData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS13Ni.UpdateData();
                txS13Mo.UpdateData();
                txS13Cu.UpdateData();
                txS13Cr.UpdateData();
                txS13B.UpdateData();
                txS13V.UpdateData();
                txS13Al.UpdateData();
                txS13Nb.UpdateData();
                txS13Zn.UpdateData();
                txS13W.UpdateData();
                //end
                txS13GrossWeight.UpdateData();
                txS13Gross_Weight_Time.Text = DateTime.Now.ToString();
                txS13Gross_Weight_Time.UpdateData();
            }
            //end
        }

        //存铁信息刷新
        private void btnRefreshWeight_Click(object sender, EventArgs e)
        {
            if (!(sender is Control))
                return;
            Control ctrl = sender as Control;
            string MIFID = ctrl.Tag.ToString();
            if (MIFID == "S11")
            {   // 1号混铁炉
                txS11Weight.LoadData();
                txS11Temp.LoadData();
                txS11Temp_Time.LoadData();
                txS11C.LoadData();
                txS11Mn.LoadData();
                txS11P.LoadData();
                txS11S.LoadData();
                txS11Ti.LoadData();
                txS11Si.LoadData();
                txS11Sn.LoadData();
                txS11Sb.LoadData();
                txS11As.LoadData();
                txS11Pb.LoadData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS11Ni.LoadData();
                txS11Mo.LoadData();
                txS11Cu.LoadData();
                txS11Cr.LoadData();
                txS11B.LoadData();
                txS11V.LoadData();
                txS11Al.LoadData();
                txS11Nb.LoadData();
                txS11Zn.LoadData();
                txS11W.LoadData();
                //END
                txS11TareWeight.LoadData();
                txS11Tare_Weight_Time.LoadData();
                txS11GrossWeight.LoadData();
                txS11Gross_Weight_Time.LoadData();
            }
            else if (MIFID == "S12")
            {   // 2号混铁炉
                txS12Weight.LoadData();
                txS12Temp.LoadData();
                txS12Temp_Time.LoadData();
                txS12C.LoadData();
                txS12Mn.LoadData();
                txS12P.LoadData();
                txS12S.LoadData();
                txS12Ti.LoadData();
                txS12Si.LoadData();
                txS12Sn.LoadData();
                txS12Sb.LoadData();
                txS12As.LoadData();
                txS12Pb.LoadData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS12Ni.LoadData();
                txS12Mo.LoadData();
                txS12Cu.LoadData();
                txS12Cr.LoadData();
                txS12B.LoadData();
                txS12V.LoadData();
                txS12Al.LoadData();
                txS12Nb.LoadData();
                txS12Zn.LoadData();
                txS12W.LoadData();
                //END
                txS12GrossWeight.LoadData();
                txS12Gross_Weight_Time.LoadData();
            }
            //Modify by hyh 2012-03-29
            else if (MIFID == "S13")
            {   // 3号混铁炉
                txS13Weight.LoadData();
                txS13Temp.LoadData();
                txS13Temp_Time.LoadData();
                txS13C.LoadData();
                txS13Mn.LoadData();
                txS13P.LoadData();
                txS13S.LoadData();
                txS13Ti.LoadData();
                txS13Si.LoadData();
                txS13Sn.LoadData();
                txS13Sb.LoadData();
                txS13As.LoadData();
                txS13Pb.LoadData();
                //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                txS13Ni.LoadData();
                txS13Mo.LoadData();
                txS13Cu.LoadData();
                txS13Cr.LoadData();
                txS13B.LoadData();
                txS13V.LoadData();
                txS13Al.LoadData();
                txS13Nb.LoadData();
                txS13Zn.LoadData();
                txS13W.LoadData();
                //end
                txS13GrossWeight.LoadData();
                txS13Gross_Weight_Time.LoadData();
            }
            //end
        }

        private void dgvTapData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        //委托单管理1
        private void btnSampleApp1_Click(object sender, EventArgs e)
        {
            MIFSampleApplyFrm sapleApplyFrm = new MIFSampleApplyFrm();
            sapleApplyFrm.ShowDialogEx(Adapter.Session, CommDataMag.CommonData.MIF_UNIT_01ID);
        }

        //委托单管理2
        private void btnSampleApp2_Click(object sender, EventArgs e)
        {
            MIFSampleApplyFrm sapleApplyFrm = new MIFSampleApplyFrm();
            sapleApplyFrm.ShowDialogEx(Adapter.Session, CommDataMag.CommonData.MIF_UNIT_02ID);
        }
        //Add by hyh 2012-03-29
        private void btnSampleApp3_Click(object sender, EventArgs e)
        {
            MIFSampleApplyFrm sapleApplyFrm = new MIFSampleApplyFrm();
            sapleApplyFrm.ShowDialogEx(Adapter.Session, CommDataMag.CommonData.MIF_UNIT_03ID);
        }
        //end

        private void dgvTapData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }

        private void dvDestIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvInIrons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void MIFMagMainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //
        private void dgvTapData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.SetDVSingleColEnable(dgvTapData, "CheckFlag", "2");
        }

        //取消出铁
        private void btnCancelIron_Click(object sender, EventArgs e)
        {
            dgvTapData.EndEdit();
            bsOut.EndEdit();
            //if(cmdCancelIron.Parameters.Count>0)
            DataSet dsSend = (DataSet)(cmdCancelIron.Parameters[0].Value);
            if (dsSend == null)
            {
                MessageBox.Show("请先选择需取消的铁水！", "提示");
                return;
            }
            if (dsSend.Tables[0].Rows.Count != 1)
            {
                MessageBox.Show("请只选择一条记录！", "提示");
                return;
            }

            string strMIFID = dsSend.Tables[0].Rows[0]["Source"].ToString();
            if (strMIFID == "0")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Mag\MIFMag";
            else if (strMIFID == "1")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S11";
            else if (strMIFID == "2")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S12";
            //Add by hyh 2012-03-29
            else if (strMIFID == "3")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S13";
            //end
            else
                return;
            if (cmdCancelIron.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdCancelIron.Command.Return);
                if (iRet < 0)
                {
                    string strShow = "";
                    switch (iRet)
                    {
                        case -3:
                            strShow = "已经指定主原料不允许取消！";
                            break;
                        case -4:
                            strShow = "直兑铁水不允许取消！";
                            break;
                        case -5:
                            strShow = "删除铁水对象不成功！";
                            break;
                        case -6:
                            strShow = "将新铁水移出出口区域不成功！";
                            break;
                        case -7:
                            strShow = "更改铁包的状态为热备不成功！";
                            break;
                        case -8:
                            strShow = "设置铁水属性对象不成功！";
                            break;
                    }
                    MessageBox.Show(strShow, "提示");
                }
                else
                {
                    MessageBox.Show("取消成功！", "提示");
                }
            }
            dsOut.LoadData();
        }

        //回退未到达铁水
        private void btnIronBack_Click(object sender, EventArgs e)
        {
            try
            {
                dvDestIrons.EndEdit();
                bsDestIrons.EndEdit();

                DataSet dsSend = (DataSet)(cmdIronBack.Parameters[0].Value);
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;
                if (cmdIronBack.Execute() >= 0)
                {
                    int iRet = Convert.ToInt32(cmdIronBack.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("回退成功！", "提示");
                    else
                        MessageBox.Show("回退失败！", "提示");
                }
                else
                    MessageBox.Show("回退失败！", "提示");
            }
            catch { }
            dsDestIron.LoadData();
        }
        //回退到达铁水[2009-04-03]
        private void btnBackBFIron_Click(object sender, EventArgs e)
        {
            try
            {
                dvInIrons.EndEdit();
                bsInIron.EndEdit();

                DataSet dsSend = (DataSet)(cmdSendBackArrivedIrons.Parameters[0].Value);
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                if (cmdSendBackArrivedIrons.Execute() >= 0)
                {
                    int iRet = Convert.ToInt32(cmdSendBackArrivedIrons.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("回退成功！", "提示");
                    else
                        MessageBox.Show("回退失败！", "提示");
                }
                else
                    MessageBox.Show("回退失败！", "提示");
            }
            catch { }
            dsInIron.LoadData();
        }

        private void txS11S_TextChanged(object sender, EventArgs e)
        {
            //////1#混铁炉////////
            //modify by hyh 2012-4-7
            txS11C.LoadData(); txS11C_Cal.LoadData();
            txS11Si.LoadData(); txS11Si_Cal.LoadData();
            txS11Mn.LoadData(); txS11Mn_Cal.LoadData();
            txS11P.LoadData(); txS11P_Cal.LoadData();
            txS11S.LoadData(); txS11S_Cal.LoadData();
            txS11Ti.LoadData(); txS11Ti_Cal.LoadData();
            txS11Sn.LoadData(); txS11Sn_Cal.LoadData();
            txS11Sb.LoadData(); txS11Sb_Cal.LoadData();
            txS11As.LoadData(); txS11As_Cal.LoadData();
            txS11Pb.LoadData(); txS11Pb_Cal.LoadData();
            //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
            txS11Ni.LoadData();
            txS11Mo.LoadData();
            txS11Cu.LoadData();
            txS11Cr.LoadData();
            txS11B.LoadData();
            txS11V.LoadData();
            txS11Al.LoadData();
            txS11Nb.LoadData();
            txS11Zn.LoadData();
            txS11W.LoadData();
            txS11Ni_Cal.LoadData();
            txS11Mo_Cal.LoadData();
            txS11Cu_Cal.LoadData();
            txS11Cr_Cal.LoadData();
            txS11B_Cal.LoadData();
            txS11V_Cal.LoadData();
            txS11Al_Cal.LoadData();
            txS11Nb_Cal.LoadData();
            txS11Zn_Cal.LoadData();
            txS11W_Cal.LoadData();
            //end

            //////2#混铁炉////////
            txS12C.LoadData(); txS12C_Cal.LoadData();
            txS12Si.LoadData(); txS12Si_Cal.LoadData();
            txS12Mn.LoadData(); txS12Mn_Cal.LoadData();
            txS12P.LoadData(); txS12P_Cal.LoadData();
            txS12S.LoadData(); txS12S_Cal.LoadData();
            txS12Ti.LoadData(); txS12Ti_Cal.LoadData();
            txS12Sn.LoadData(); txS12Sn_Cal.LoadData();
            txS12Sb.LoadData(); txS12Sb_Cal.LoadData();
            txS12As.LoadData(); txS12As_Cal.LoadData();
            txS12Pb.LoadData(); txS12Pb_Cal.LoadData();

            //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
            txS12Ni.LoadData();
            txS12Mo.LoadData();
            txS12Cu.LoadData();
            txS12Cr.LoadData();
            txS12B.LoadData();
            txS12V.LoadData();
            txS12Al.LoadData();
            txS12Nb.LoadData();
            txS12Zn.LoadData();
            txS12W.LoadData();
            txS12Ni_Cal.LoadData();
            txS12Mo_Cal.LoadData();
            txS12Cu_Cal.LoadData();
            txS12Cr_Cal.LoadData();
            txS12B_Cal.LoadData();
            txS12V_Cal.LoadData();
            txS12Al_Cal.LoadData();
            txS12Nb_Cal.LoadData();
            txS12Zn_Cal.LoadData();
            txS12W_Cal.LoadData();
            //end

            //////3#混铁炉////////
            txS13C.LoadData(); txS13C_Cal.LoadData();
            txS13Si.LoadData(); txS13Si_Cal.LoadData();
            txS13Mn.LoadData(); txS13Mn_Cal.LoadData();
            txS13P.LoadData(); txS13P_Cal.LoadData();
            txS13S.LoadData(); txS13S_Cal.LoadData();
            txS13Ti.LoadData(); txS13Ti_Cal.LoadData();
            txS13Sn.LoadData(); txS13Sn_Cal.LoadData();
            txS13Sb.LoadData(); txS13Sb_Cal.LoadData();
            txS13As.LoadData(); txS13As_Cal.LoadData();
            txS13Pb.LoadData(); txS13Pb_Cal.LoadData();
            //add by hyh 2012-08-09 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
            txS13Ni.LoadData();
            txS13Mo.LoadData();
            txS13Cu.LoadData();
            txS13Cr.LoadData();
            txS13B.LoadData();
            txS13V.LoadData();
            txS13Al.LoadData();
            txS13Nb.LoadData();
            txS13Zn.LoadData();
            txS13W.LoadData();

            txS13Ni_Cal.LoadData();
            txS13Mo_Cal.LoadData();
            txS13Cu_Cal.LoadData();
            txS13Cr_Cal.LoadData();
            txS13B_Cal.LoadData();
            txS13V_Cal.LoadData();
            txS13Al_Cal.LoadData();
            txS13Nb_Cal.LoadData();
            txS13Zn_Cal.LoadData();
            txS13W_Cal.LoadData();
            //end

            //1#MIF
            if (txS11S.Text.Trim() != "" && Convert.ToDouble(txS11S.Text.Trim()) > 0.03)
            {
                txS11S.BackColor = Color.Yellow;
            }
            if (txS11S_Cal.Text.Trim() != "" && Convert.ToDouble(txS11S_Cal.Text.Trim()) > 0.03)
            {
                txS11S_Cal.BackColor = Color.Yellow;
            }
            if (txS11P.Text.Trim() != "" && Convert.ToDouble(txS11P.Text.Trim()) > 0.08)
            {
                txS11P.BackColor = Color.Yellow;
            }
            if (txS11P_Cal.Text.Trim() != "" && Convert.ToDouble(txS11P_Cal.Text.Trim()) > 0.08)
            {
                txS11P_Cal.BackColor = Color.Yellow;
            }
            if (txS11Si.Text.Trim() != "" && Convert.ToDouble(txS11Si.Text.Trim()) > 0.6)
            {
                txS11Si.BackColor = Color.Yellow;
            }
            if (txS11Si_Cal.Text.Trim() != "" && Convert.ToDouble(txS11Si_Cal.Text.Trim()) > 0.6)
            {
                txS11Si_Cal.BackColor = Color.Yellow;
            }
            //2#MIF
            if (txS12S.Text.Trim() != "" && Convert.ToDouble(txS12S.Text.Trim()) > 0.03)
            {
                txS12S.BackColor = Color.Yellow;
            }
            if (txS12S_Cal.Text.Trim() != "" && Convert.ToDouble(txS12S_Cal.Text.Trim()) > 0.03)
            {
                txS12S_Cal.BackColor = Color.Yellow;
            }
            if (txS12P.Text.Trim() != "" && Convert.ToDouble(txS12P.Text.Trim()) > 0.08)
            {
                txS12P.BackColor = Color.Yellow;
            }
            if (txS12P_Cal.Text.Trim() != "" && Convert.ToDouble(txS12P_Cal.Text.Trim()) > 0.08)
            {
                txS12P_Cal.BackColor = Color.Yellow;
            }
            if (txS12Si.Text.Trim() != "" && Convert.ToDouble(txS12Si.Text.Trim()) > 0.6)
            {
                txS12Si.BackColor = Color.Yellow;
            }
            if (txS12Si_Cal.Text.Trim() != "" && Convert.ToDouble(txS12Si_Cal.Text.Trim()) > 0.6)
            {
                txS12Si_Cal.BackColor = Color.Yellow;
            }
            //add by hyh 2012-03-29
            //3#MIF
            //C
            if (txS13S.Text.Trim() != "" && Convert.ToDouble(txS13S.Text.Trim()) > 0.03)
            {
                txS13S.BackColor = Color.Yellow;
            }
            if (txS13S_Cal.Text.Trim() != "" && Convert.ToDouble(txS13S_Cal.Text.Trim()) > 0.03)
            {
                txS13S_Cal.BackColor = Color.Yellow;
            }
            //P
            if (txS13P.Text.Trim() != "" && Convert.ToDouble(txS13P.Text.Trim()) > 0.08)
            {
                txS13P.BackColor = Color.Yellow;
            }
            if (txS13P_Cal.Text.Trim() != "" && Convert.ToDouble(txS13P_Cal.Text.Trim()) > 0.08)
            {
                txS13P_Cal.BackColor = Color.Yellow;
            }
            //Si
            if (txS13Si.Text.Trim() != "" && Convert.ToDouble(txS13Si.Text.Trim()) > 0.6)
            {
                txS13Si.BackColor = Color.Yellow;
            }
            if (txS13Si_Cal.Text.Trim() != "" && Convert.ToDouble(txS13Si_Cal.Text.Trim()) > 0.6)
            {
                txS13Si_Cal.BackColor = Color.Yellow;
            }
            //end
        }

        private void dvDestIrons_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dvDestIrons.RowCount; i++)
            {
                if (dvDestIrons.Rows[i].Cells["SIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["SIn"].Value.ToString()) > 0.03)
                    dvDestIrons.Rows[i].Cells["SIn"].Style.BackColor = Color.Yellow;
                if (dvDestIrons.Rows[i].Cells["PIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["PIn"].Value.ToString()) > 0.08)
                    dvDestIrons.Rows[i].Cells["PIn"].Style.BackColor = Color.Yellow;
                if (dvDestIrons.Rows[i].Cells["SiIn"].Value.ToString() != "" && Convert.ToDouble(dvDestIrons.Rows[i].Cells["SiIn"].Value.ToString()) > 0.6)
                    dvDestIrons.Rows[i].Cells["SiIn"].Style.BackColor = Color.Yellow;
            }
        }

        private void dvInIrons_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dvInIrons.RowCount; i++)
            {
                if (dvInIrons.Rows[i].Cells["SArv"].Value.ToString() != "" && Convert.ToDouble(dvInIrons.Rows[i].Cells["SArv"].Value.ToString()) > 0.03)
                    dvInIrons.Rows[i].Cells["SArv"].Style.BackColor = Color.Yellow;
                if (dvInIrons.Rows[i].Cells["PArv"].Value.ToString() != "" && Convert.ToDouble(dvInIrons.Rows[i].Cells["PArv"].Value.ToString()) > 0.08)
                    dvInIrons.Rows[i].Cells["PArv"].Style.BackColor = Color.Yellow;
                if (dvInIrons.Rows[i].Cells["SiArv"].Value.ToString() != "" && Convert.ToDouble(dvInIrons.Rows[i].Cells["SiArv"].Value.ToString()) > 0.6)
                    dvInIrons.Rows[i].Cells["SiArv"].Style.BackColor = Color.Yellow;
            }
        }

        private void dgvTapData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvTapData.RowCount; i++)
            {
                if (dgvTapData.Rows[i].Cells["SOut"].Value.ToString() != "" && Convert.ToDouble(dgvTapData.Rows[i].Cells["SOut"].Value.ToString()) > 0.03)
                    dgvTapData.Rows[i].Cells["SOut"].Style.BackColor = Color.Yellow;
                if (dgvTapData.Rows[i].Cells["POut"].Value.ToString() != "" && Convert.ToDouble(dgvTapData.Rows[i].Cells["POut"].Value.ToString()) > 0.08)
                    dgvTapData.Rows[i].Cells["POut"].Style.BackColor = Color.Yellow;
                if (dgvTapData.Rows[i].Cells["SiOut"].Value.ToString() != "" && Convert.ToDouble(dgvTapData.Rows[i].Cells["SiOut"].Value.ToString()) > 0.6)
                    dgvTapData.Rows[i].Cells["SiOut"].Style.BackColor = Color.Yellow;
            }
        }

        //是否脱硫确认 
        private void tsBtnIsDesIron_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTapData.EndEdit();
                bsOut.EndEdit();
                DataSet dsSend = (DataSet)(cmdDes.Parameters[0].Value);
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                if (cmdDes.Execute() >= 0)
                {
                    int iRet = Convert.ToInt32(cmdDes.Command.Return);
                    if (iRet== 0)
                        MessageBox.Show("操作成功！", "提示");
                    else
                        MessageBox.Show("操作失败！", "提示");
                }
                else
                    MessageBox.Show("操作失败！", "提示");
            }
            catch { }
            dsOut.LoadData();
        }

        private void MIFMagMainFrm_Load(object sender, EventArgs e)
        {
            dsOut.L3DataAdapter = Adapter;
            dsIronMode.L3DataAdapter = Adapter;
            dsOut2.L3DataAdapter = Adapter;
            
 
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            dataGridView3.EndEdit();
            bsOut2.EndEdit();
            //if(cmdCancelIron.Parameters.Count>0)
            DataSet dsSend = (DataSet)(cmdCancelIronToDEP.Parameters[0].Value);
            if (dsSend == null)
            {
                MessageBox.Show("请先选择需取消的铁水！", "提示");
                return;
            }
            if (dsSend.Tables[0].Rows.Count != 1)
            {
                MessageBox.Show("请只选择一条记录！", "提示");
                return;
            }

            string strMIFID = dsSend.Tables[0].Rows[0]["Source"].ToString();
            if (strMIFID == "0")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Mag\MIFMag";
            else if (strMIFID == "1")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S11";
            else if (strMIFID == "2")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S12";
            //Add by hyh 2012-03-29
            else if (strMIFID == "3")
                cmdCancelIron.Object = @"XGMESLogic\MIXFMag\CMIF_Unit_Mag\S13";
            //end
            else
                return;
            if (cmdCancelIronToDEP.Execute() >= 0)
            {
                int iRet = Convert.ToInt32(cmdCancelIronToDEP.Command.Return);
                if (iRet < 0)
                {
                    string strShow = "";
                    switch (iRet)
                    {
                        case -3:
                            strShow = "已经指定主原料不允许取消！";
                            break;
                        case -4:
                            strShow = "直兑铁水不允许取消！";
                            break;
                        case -5:
                            strShow = "删除铁水对象不成功！";
                            break;
                        case -6:
                            strShow = "将新铁水移出出口区域不成功！";
                            break;
                        case -7:
                            strShow = "更改铁包的状态为热备不成功！";
                            break;
                        case -8:
                            strShow = "设置铁水属性对象不成功！";
                            break;
                    }
                    MessageBox.Show(strShow, "提示");
                }
                else
                {
                    MessageBox.Show("取消成功！", "提示");
                }
            }
            dsOut2.LoadData();
        }


   

    }
}