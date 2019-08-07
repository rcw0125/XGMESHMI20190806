using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BFMag
{
    public partial class IronMagFrm : DockContent, IMESForm
    {
        public IronMagFrm()
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
        private string strSort = "";

        //控件加载
        private void IronMagFrm_Load(object sender, EventArgs e)
        {

        }
        
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取最大铁次号
            
            //添加一行数据，对相应数据进行填充
            DataRow newrow = dsBFIron.Tables[0].NewRow();
            dsBFIron.Tables[0].Rows.Add(newrow);

            bsBFIron.MoveLast();//光标移动到最后一行
            IronInfoFrm Frm = new IronInfoFrm();
            Frm.ShowDialogEx(Adapter.Session, strSort, bsBFIron.Position, ref dsBFIron);
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsBFIron.Position >= 0)
                bsBFIron.RemoveCurrent();
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsBFIron.EndEdit();
            object objDel = null;
            if (dsBFIron.CommitDeleted(ref objDel))
            {
                if (objDel != null && Convert.ToInt32(objDel) < 1)
                    MessageBox.Show("删除失败,铁水已使用！", "提示");
                else if (objDel != null && Convert.ToInt32(objDel) > 0)
                    MessageBox.Show("删除成功！", "提示");
            }
            dsBFIron.LoadData();
        }

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBFIron.RejectChanges();
            dsBFIron.LoadData();
        }

        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //bsBFIron.Position = e.RowIndex;
            //IronInfoFrm Frm = new IronInfoFrm();
            //Frm.ShowDialogEx(Adapter.Session,strSort, bsBFIron.Position, ref dsBFIron);
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void IronMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //高炉委托单管理
        private void btnBFSample_Click(object sender, EventArgs e)
        {
            IronSampleFrm Frm = new IronSampleFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }

        //脱硫委托单
        private void btnDisSSample_Click(object sender, EventArgs e)
        {
            DeSIronSheetFrm Frm = new DeSIronSheetFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsBFIron.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        //右键菜单可用性：可见&&满足条件
        private void dvM_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                menuGross.Enabled = false;
                menuTare.Enabled = false;
                menuToIron.Enabled = false;
                menuToNC.Enabled = false;
                return;
            }

            if (e.RowIndex >= 0)
                bsBFIron.Position = e.RowIndex;

            //去向标志
            string strDestination = dvM.Rows[bsBFIron.Position].Cells["Destination"].Value.ToString();
            //铁水状态
            string strIronStatus = dvM.Rows[bsBFIron.Position].Cells["IronStatus"].Value.ToString();
            //成分标志
            string strAnalysisFlag = dvM.Rows[bsBFIron.Position].Cells["AnalysisFlag"].Value.ToString();
            //皮重标志
            string strTareFlag = dvM.Rows[bsBFIron.Position].Cells["TareFlag"].Value.ToString();
            //毛重标志
            string strGrossFlag = dvM.Rows[bsBFIron.Position].Cells["GrossFlag"].Value.ToString();
            //可发送电文标志
            string strIronConfirm = dvM.Rows[bsBFIron.Position].Cells["IronConfirm"].Value.ToString();
            //铁水来源
            string strSource = dvM.Rows[bsBFIron.Position].Cells["Source"].Value.ToString();

            /************* 设定皮重 ***********************/
            //对象为皮重标志为0且已经设定毛重的铁水
            if (strTareFlag != "0" && strGrossFlag == "1")
                menuTare.Enabled = false;// && menuTare.Visible;
            else
                menuTare.Enabled = true;//&& menuTare.Visible;
            /************* 设定皮重 ***********************/

            /************* 设定毛重 ***********************/
            //对象为铁水状态为未处理、去向为未指定的铁水。
            if (strGrossFlag == "0" && strIronStatus == "0" && strDestination == "0")
                menuGross.Enabled = true;// && menuGross.Visible;
            else
                menuGross.Enabled = false;// && menuGross.Visible;
            /************* 设定毛重 ***********************/

            /************* 指定去铸铁 ***********************/
            //净重:指定去铸铁,对象为铁水状态为未处理、去向为未指定的铁水，AnalysisFlag（成分标志）=1。
            if (strAnalysisFlag == "1" && strIronStatus == "0" && strDestination == "0")
                menuToIron.Enabled = true;// && menuToIron.Visible;
            else
                menuToIron.Enabled = false;// && menuToIron.Visible;
            /************* 指定去铸铁 ***********************/

            /************* 重去炼钢 ***********************/
            if (strIronStatus == "0" && strGrossFlag == "1")
                menuToSteelAgain.Enabled = true;
            else
                menuToSteelAgain.Enabled = false;
            /************* 重去炼钢 ***********************/

            /************* 指定上传NC ***********************/
            if (strIronConfirm == "1")
                menuToNC.Enabled = true;// && menuToNC.Visible;
            else
                menuToNC.Enabled = false;// && menuToNC.Visible;
            /************* 指定上传NC ***********************/

            /************* 脱硫站铁水 ***********************/
            if ((strIronStatus == "0" || strIronStatus == "1") && strSource == "0")
                menuSoureS.Enabled = true;// && menuSoureS.Visible;
            else
                menuSoureS.Enabled = false;// && menuSoureS.Visible;
            /************* 脱硫站铁水 ***********************/

            /************* 高炉铁水 ***********************/
            if ((strIronStatus == "0" || strIronStatus == "1") && strSource == "1")
                menuSouresHF.Enabled = true;// && menuSouresHF.Visible;
            else
                menuSouresHF.Enabled = false;// && menuSouresHF.Visible;
            /************* 高炉铁水 ***********************/
        }

        //毛重
        private void menuGross_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronGrossFrm frm = new IronGrossFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
             //   dsBFIron.LoadData();
            }
            catch { }
        }

        //皮重
        private void menuTare_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronTareFrm frm = new IronTareFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //去铸铁
        private void menuToIron_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                    dsSend.Tables[0].ImportRow(dr);
                IronNetWeightFrm frm = new IronNetWeightFrm();
                frm.ShowDialogEx(Adapter.Session, dsSend);
                GC.Collect();
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //重去炼钢
        private void menuToSteelAgain_Click(object sender, EventArgs e)
        {
            try
            {
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells["MaterialID"].Value.ToString();
                DataSet dsSend = dsBFIron.Clone();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Destination"] = 1 ;//铸铁【2009-04-05】
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                cmdDesignatePath.Parameters[0].SourceObject = dsSend;
                if (cmdDesignatePath.Execute() >= 0)
                {
                    int iRet = (int)cmdDesignatePath.Command.Return;
                    if (iRet > 0)
                        MessageBox.Show("指定成功！", "提示");
                    else
                        MessageBox.Show("指定失败！", "提示");
                }
                else
                    MessageBox.Show("指定失败！", "提示");
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //上传NC
        private void menuToNC_Click(object sender, EventArgs e)
        {
            try
            {
                string strTapNo = dvM.Rows[bsBFIron.Position].Cells[TAP_No.Index].Value.ToString();
                if (strTapNo == "")
                    return;

                string strMessage = MessageBox.Show("是否确认上传NC？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strMessage != "Yes")
                    return;
                cmdSendIronDataToNC.Parameters[0].ConstantValue = strTapNo;
                

                //dsBFIron.LoadData();
            }
            catch { }
        }

        //脱硫站铁水
        private void menuSoureS_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Source"] = 1;
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                cmdModifySource.Parameters[0].SourceObject = dsSend;
                if (cmdModifySource.Execute() >= 0)
                {
                    //string strErrorCode = "0x" + string.Format("{0:X}", cmdModifySource.Command.ErrorCode);
                    //string Desc = CommDataMag.CommonMethed.GetErrorDescByErrorCode(Adapter, strErrorCode, "AppServer");
                    int iRet = Convert.ToInt32(cmdModifySource.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("指定成功！", "提示");
                    else
                        MessageBox.Show("指定失败！", "提示");

                }
                else
                    MessageBox.Show("指定失败！", "提示");
                //dsBFIron.LoadData();

            }
            catch { }
        }

        //高炉铁水
        private void menuSouresHF_Click(object sender, EventArgs e)
        {
            try
            {
                AppSvrHMI.L3DataSet dsSend = (AppSvrHMI.L3DataSet)dsBFIron.Clone();
                string strMaterialID = dvM.Rows[bsBFIron.Position].Cells[MaterialID.Index].Value.ToString();
                DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
                foreach (DataRow dr in drArray)
                {
                    dr["Source"] = 0;
                    dsSend.Tables[0].ImportRow(dr);
                }
                dsSend.AcceptChanges();
                if (dsSend == null || dsSend.Tables[0].Rows.Count < 1)
                    return;

                cmdModifySource.Parameters[0].SourceObject = dsSend;
                if (cmdModifySource.Execute() >= 0)
                {
                    //string strErrorCode = cmdModifySource.Command.ErrorCode.ToString();
                    //string.Format("{0:X}", cmdFeedIrons.Command.ErrorCode));
                    int iRet = Convert.ToInt32(cmdModifySource.Command.Return);
                    if (iRet > 0)
                        MessageBox.Show("指定成功！","提示");
                    else
                        MessageBox.Show("指定失败！", "提示");

                }
                else
                    MessageBox.Show("指定失败！", "提示");
                //dsBFIron.LoadData();
            }
            catch { }
        }

        //绘制颜色
        private void dvM_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
            string strIronStatus = dvM.Rows[e.RowIndex].Cells[IronStatus.Index].Value.ToString();
            switch (strIronStatus)
            {
                case "5":
                    //dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Control;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGreen;
                    break;
                case "1":
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Orange;
                    //dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Blue;
                    break;
                case "2":
                    dvM.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    dvM.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.Black;
                    break;
                default:
                    break;
            }
        }

        //
        private void dvM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }


        //铁渣样委托单
        private void btnIronSlagSample_Click(object sender, EventArgs e)
        {
            IronSlagApplyFrm Frm = new IronSlagApplyFrm();
            Frm.ShowDialogEx(Adapter.Session);
            GC.Collect();
            //dsBFIron.LoadData();
        }
        //重新发送委托单
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            reSendApply Frm = new reSendApply();
            Frm.ShowDialogEx(Adapter.Session);
          
        }



        ////指定去向
        //private void menu_AssignDire_Click(object sender, EventArgs e)
        //{
        //    if (bsBFIron.Position < 0)
        //        return;

        //    if (sender.GetType().Name != "ToolStripMenuItem")
        //        return;

        //    ToolStripMenuItem menuSend = (ToolStripMenuItem)sender;
        //    if (menuSend.Tag.ToString() == "")
        //        return;

        //    try
        //    {
        //        if (sender.Equals(btnIron) || sender.Equals(menuIron))
        //        {
        //            float fNetwt = float.Parse(dvM.Rows[bsBFIron.Position].Cells[Net_Weight.Index].Value.ToString());
        //            if (fNetwt <= 0)
        //            {
        //                MessageBox.Show("净重必须大于\"0\"", "提示");
        //                return;
        //            }
        //        }

        //        string strMaterialID = dvM.Rows[bsBFIron.Position].Cells["MaterialID"].Value.ToString();
        //        DataSet dsSend = dsBFIron.Clone();
        //        DataRow[] drArray = dsBFIron.Tables[0].Select("MaterialID = '" + strMaterialID + "'");
        //        foreach (DataRow dr in drArray)
        //        {
        //            dr["Destination"] = menuSend.Tag.ToString(); ;//铸铁【2009-04-05】
        //            dsSend.Tables[0].ImportRow(dr);
        //        }
        //        dsSend.AcceptChanges();
        //        cmdDesignatePath.Parameters[0].SourceObject = dsSend;
        //        if (cmdDesignatePath.Execute() >= 0)
        //        {
        //            int iRet = (int)cmdDesignatePath.Command.Return;
        //            if (iRet > 0)
        //                MessageBox.Show("指定成功！", "提示");
        //            else
        //                MessageBox.Show("指定失败！", "提示");
        //        }
        //        else
        //            MessageBox.Show("指定失败！", "提示");
        //        dsBFIron.LoadData();
        //    }
        //    catch { }
        //}

    }
}