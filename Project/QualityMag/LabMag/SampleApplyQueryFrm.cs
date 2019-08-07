using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.LabMag
{
    public partial class SampleApplyQueryFrm : DockContent, IMESForm
    {
        public SampleApplyQueryFrm()
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

        //private string strCurAddress = "";
        //private string strSort = "";
        //private bool bCheck = false;//标记当前是否(Check)选中数据
        //private AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();

        //public DialogResult ShowDialogEx(AppSvrIF.Session session, string strAddr)
        //{
        //    Adapter.Session = session;
        //    switch (strAddr)
        //    {
        //        //混铁炉工序
        //        case CommDataMag.CommonData.MIF_UNIT_01ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_H1;
        //            break;
        //        case CommDataMag.CommonData.MIF_UNIT_02ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_H2;
        //            break;
        //        //转炉工序
        //        case CommDataMag.CommonData.BOF_UNIT_01ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_Z1;
        //            break;
        //        case CommDataMag.CommonData.BOF_UNIT_02ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_Z2;
        //            break;
        //        case CommDataMag.CommonData.BOF_UNIT_03ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_Z3;
        //            break;
        //        case CommDataMag.CommonData.BOF_UNIT_04ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_Z4;
        //            break;
        //        //LF炉工序
        //        case CommDataMag.CommonData.LF_UNIT_01ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_F1;
        //            break;
        //        case CommDataMag.CommonData.LF_UNIT_02ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_F2;
        //            break;
        //        case CommDataMag.CommonData.LF_UNIT_03ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_F3;
        //            break;
        //        //RH炉工序
        //        case CommDataMag.CommonData.RH_UNIT_01ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_R1;
        //            break;
        //        //连铸工序
        //        case CommDataMag.CommonData.CCM_UNIT_01ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_C1;
        //            break;
        //        case CommDataMag.CommonData.CCM_UNIT_02ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_C2;
        //            break;
        //        case CommDataMag.CommonData.CCM_UNIT_03ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_C3;
        //            break;
        //        case CommDataMag.CommonData.CCM_UNIT_04ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_C4;
        //            break;
        //        case CommDataMag.CommonData.CCM_UNIT_05ID:
        //            strCurAddress = CommDataMag.CommonData.QA_Sample_Addr_C5;
        //            break;
        //        default:
        //            break;
        //    }
        //    return ShowDialog();
        //}

        private void SampleApplyQueryFrm_Load(object sender, EventArgs e)
        {
            //dsSend = (AppSvrHMI.L3DataSet)dsSampleApply.Clone();
            //cmdSampleApply.Parameters[0].ConstantValue = strCurAddress;
            //cmdSampleApply.Execute();
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            //试样类别
            cmbSampleType.Items.Clear();
            cmbSampleType.Items.Add("");
            for (int i = 0; i < dsSampleType.Tables[0].Rows.Count; i++)
            {
                cmbSampleType.Items.Add(dsSampleType.Tables[0].Rows[i]["Code_Des"].ToString());
            }

            //取样地点
            cmbPosition.Items.Clear();
            cmbPosition.Items.Add("");
            for (int j=0;j<dsSampleAddr.Tables[0].Rows.Count;j++)
            {
                cmbPosition.Items.Add(dsSampleAddr.Tables[0].Rows[j]["Code_Des"].ToString());
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dsSampleApply.UpdateData();
            dsSampleApply.AcceptChanges();
            cmdSampleApply.Execute();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((bsSampleApply.Position >= 0) && (!(Convert.ToBoolean(dvSampleApply.CurrentRow.Cells["SENDFLAG"].Value))))
                bsSampleApply.RemoveCurrent();
        }

        private void btnToLab_Click(object sender, EventArgs e)
        {
            cmdToLab.Parameters[0].SourceFilter = "CheckFlag = 1 and APPID <> '' and SAMPLE_CODE <> ''";

            dvSampleApply.EndEdit();
            bsSampleApply.EndEdit();
            if ((DataSet)(cmdToLab.Parameters[0].Value) != null && ((DataSet)(cmdToLab.Parameters[0].Value)).Tables[0].Rows.Count > 0)
            {
                bool bValid = true;
                int i = 0;
                while ((i < ((DataSet)cmdToLab.Parameters[0].Value).Tables[0].Rows.Count) && bValid)
                {
                    string strType = ((DataSet)cmdToLab.Parameters[0].Value).Tables[0].Rows[i]["AppID"].ToString().Substring(0, 1);
                    string strHeatID = ((DataSet)cmdToLab.Parameters[0].Value).Tables[0].Rows[i]["HeatID"].ToString();
                    if (strType == "H" || (strType != "H" && strHeatID != ""))
                    {
                        bValid = true;
                    }
                    else
                    {
                        bValid = false;
                    }
                    i++;
                }
                if (bValid)
                {
                    if (MessageBox.Show("确认下传委托单到检化验？", "提示", 
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString() == "Yes")
                    {
                        if (cmdToLab.Execute() >= 0)
                        {
                            if (Convert.ToInt16(cmdToLab.Command.Return) > 0)
                            {
                                MessageBox.Show("下传成功！", "提示", MessageBoxButtons.OK);
                                //dsSampleApply.LoadData();
                            }
                            else
                            {
                                MessageBox.Show("下传失败！", "提示", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("下传失败！", "提示", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("所选委托单无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("所选委托单无效！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //校验选择
        private void dvSampleApply_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //if (Convert.ToBoolean(dvSampleApply.CurrentRow.Cells["SENDFLAG"].Value))
            //{
            //    dvSampleApply.CurrentRow.Cells[0].Value = 0;
            //    dvSampleApply.EndEdit();
            //    return;
            //}
            //dvSampleApply.EndEdit();
            //if (dvSampleApply.CurrentRow.Cells[0].Value.ToString() == "1")
            //{
            //    if (bCheck)
            //    {
            //        int iRowCount = dvSampleApply.Rows.Count;
            //        for (int i = 0; i < dvSampleApply.CurrentRow.Index; i++)
            //        {
            //            if (dvSampleApply.Rows[i].Cells[0].Value.ToString() == "1")
            //            {
            //                dvSampleApply.Rows[i].Cells[0].Value = 0;
            //            }
            //        }
            //        for (int j = dvSampleApply.CurrentRow.Index + 1; j < iRowCount; j++)
            //        {
            //            if (dvSampleApply.Rows[j].Cells[0].Value.ToString() == "1")
            //            {
            //                dvSampleApply.Rows[j].Cells[0].Value = 0;
            //            }
            //        }
            //    }
            //    bCheck = true;
            //}
        }

        private void dvSampleApply_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dvSampleApply_RowPrePaint(object sender, int iRowIndex)
        {
            if (dvSampleApply.Rows[iRowIndex].Cells["BACK_FLAG"].Value.ToString() == "1")
            {
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.BackColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionForeColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionBackColor = Color.LightGreen;
            }
            else if (dvSampleApply.Rows[iRowIndex].Cells["RESAMPLE_FLAG"].Value.ToString() == "1")
            {
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.BackColor = Color.Red;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionForeColor = Color.Yellow;
                dvSampleApply.Rows[iRowIndex].Cells["APPID"].Style.SelectionBackColor = Color.LightPink;
            }

        }

        private void dvSampleApply_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dvSampleApply.Rows.Count; i++)
            {
                dvSampleApply_RowPrePaint(sender, i);
            }
        }


        //确认已重取样
        private void btnConfirmSampleAgain_Click(object sender, EventArgs e)
        {
            string strAppID = dvSampleApply.Rows[bsSampleApply.Position].Cells["APPID"].Value.ToString();
            Adapter.Session.Set("XGMESLogic\\QualityMag\\CQA_Lab_Sheet_App\\" + strAppID, "ReSample_Flag", "2");
            Adapter.RefreshDataBindings();
            cmdSampleApply.Execute();
        }

        //确认已重制单
        private void btnConfirmMakeAgain_Click(object sender, EventArgs e)
        {
            string strAppID = dvSampleApply.Rows[bsSampleApply.Position].Cells["APPID"].Value.ToString();
            Adapter.Session.Set("XGMESLogic\\QualityMag\\CQA_Lab_Sheet_App\\" + strAppID, "Back_Flag", "2");
            Adapter.RefreshDataBindings();
            cmdSampleApply.Execute();
        }

        //[20090103Liao]
        private void dvSampleApply_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            //if (e.RowIndex < 00)
            //    return;
            //bsSampleApply.Position = e.RowIndex;

            //string strBackFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["BACK_FLAG"].Value.ToString();
            //string strReSampleFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["RESAMPLE_FLAG"].Value.ToString();
            ////string strSendFlag = dvSampleApply.Rows[bsSampleApply.Position].Cells["SENDFLAG"].Value.ToString();
            //if (strBackFlag == "1")
            //{
            //    btnConfirmMakeAgain.Enabled = true;
            //    btnConfirmSampleAgain.Enabled = false;
            //}
            //else if (strReSampleFlag == "1")
            //{
            //    btnConfirmMakeAgain.Enabled = false;
            //    btnConfirmSampleAgain.Enabled = true;
            //}
            //else
            //{
            //    btnConfirmMakeAgain.Enabled = false;
            //    btnConfirmSampleAgain.Enabled = false;
            //}
        }

        private void SampleApplyQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void cmbSampleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSampleType.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsSampleType, cmbSampleType.Text);
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtElement.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsSampleAddr, cmbPosition.Text);
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsSampleApply.SourceCondition = "1=2";
            double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            if (txtSampleType.Text == "")
            {
                if (txtElement.Text == "")
                {
                    dsSampleApply.SourceCondition = "Sample_Date between to_date( '" + dtS + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + dtE + "','yyyy-mm-dd hh24:mi:ss') order by Sample_Date asc";
                }
                else
                {
                    dsSampleApply.SourceCondition = "(Sample_Date between to_date( '" + dtS + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + dtE + "','yyyy-mm-dd hh24:mi:ss')) and ( Sample_Address = '" + txtElement.Text + "') order by Sample_Date asc";
                }
            }
            else
            {
                if (txtElement.Text == "")
                {
                    dsSampleApply.SourceCondition = "(Sample_Date between to_date( '" + dtS + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + dtE + "','yyyy-mm-dd hh24:mi:ss')) and ( Sample_Type = '" + txtSampleType.Text + "') order by Sample_Date asc";
                }
                else
                {
                    dsSampleApply.SourceCondition = "(Sample_Date between to_date( '" + dtS + "','yyyy-mm-dd hh24:mi:ss') and to_date('" + dtE + "','yyyy-mm-dd hh24:mi:ss')) and ( Sample_Address = '" + txtElement.Text + "') and ( Sample_Type = '" + txtSampleType.Text + "') order by Sample_Date asc";
                }
            }
            //dsSampleApply.LoadData();
        }
    }
}