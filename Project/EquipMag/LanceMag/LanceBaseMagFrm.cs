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
        private void LanceBaseMagFrm_Load(object sender, EventArgs e)
        {
            //制作开始
            cmdDefendStrat.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_OFFLINE + "'";
            //制作结束
            cmdDefendEnd.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_REPAIR + "'";
            //上线
            cmdChangeOn.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_FREE + "'";
            //下线检查
            cmdOffCheck.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_USE + "'";
            //判为可再次使用
            cmdFree.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_CHECK + "'";
            //离线待修
            cmdOffLine.Parameters[0].SourceFilter = "CheckFlag = 1 and Status = '" + CommDataMag.CommonData.CLANCE_STATUS_CHECK + "'";
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //氧枪维修开始
        private void btnDefendStrat_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdDefendStrat))
            {
                cmdDefendStrat.Execute();
            }
        }

        //氧枪维修结束
        private void btnDefendEnd_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdDefendEnd))
            {
                cmdDefendEnd.Execute();
            }
        }

        //人工换上氧枪
        private void btnOn_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdChangeOn))
            {
                cmdChangeOn.Execute();
            }
        }

        //人工换下氧枪
        private void btnOff_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdOffCheck))
            {
                cmdOffCheck.Execute();
            }
        }

        //准备再次上线
        private void btnUseAgain_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdFree))
            {
                cmdFree.Execute();
            }
        }

        //离线待修
        private void btnWaitRepair_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit();
            if (JudgeValueRowCount(cmdOffLine))
            {
                cmdOffLine.Execute();
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

        //[20081230]
        private void dvBase_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        { 
            //制作 
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_REPAIR, Color.DarkOrange, Color.Blue);

            //空闲
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_FREE, Color.LightSeaGreen, Color.Blue);

            //使用
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_USE, Color.Red, Color.Yellow);

            //检查
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBase, "LanceID",
                "Status", CommDataMag.CommonData.CLANCE_STATUS_CHECK, Color.Yellow, Color.Blue);

            //离线待修
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
                MessageBox.Show("请选择状态为\"离线待修\"的氧枪", "提示", MessageBoxButtons.OK);
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
            string deleteConfirm = MessageBox.Show("确认要删除" + strMessage + "号氧枪么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
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
                MessageBox.Show("删除失败！", "提示");
            else
                MessageBox.Show("成功删除" + objDel + "条记录！", "提示");
            dsBase.LoadData();
        }

    }
}