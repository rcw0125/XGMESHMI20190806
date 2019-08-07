using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class ChangePlanTimeFrm : Form
    {
        public ChangePlanTimeFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session,AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsTapping.Tables[0].ImportRow(dsData.Tables[0].Rows[0]); 
            dsTapping.AcceptChanges();
            bsTapping.Position = 0;

            lbSteelGradeIndex.Text = dsData.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
            this.ShowDialog();
        }

        //返回
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePlanTimeFrm_Load(object sender, EventArgs e)
        {
            //设置日期显示格式
            dtActTimeIronPrepared.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtActTimeTappedSideEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dvActTimeCasterArrival.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtActTimeBOFStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtActTimeLFStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dvActTimeCastingStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtActTimeBOFTapped.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtActTimeRHStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dvActTimeCastingEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            object obBOF_PROC_TIME = new object();
            String csUri = "XGMESLogic\\QualityMag\\CQA_Unit_Proc_Time\\" + lbSteelGradeIndex.Text;

            Adapter.Session.Get(csUri, "BOF_Proc_Time", ref obBOF_PROC_TIME);
            txtStartToEndTime.Text = obBOF_PROC_TIME.ToString();
            Adapter.Session.Get(csUri, "LF_Proc_Time", ref obBOF_PROC_TIME);
            txtLFTime.Text = obBOF_PROC_TIME.ToString();
            Adapter.Session.Get(csUri, "RH_Proc_Time", ref obBOF_PROC_TIME);
            txtRHTime.Text = obBOF_PROC_TIME.ToString();
            Adapter.Session.Get(csUri, "Caster_Proc_Time", ref obBOF_PROC_TIME);
            txtCastingTime.Text = obBOF_PROC_TIME.ToString();
            Adapter.Session.Get(csUri, "Tapped_Proc_Time", ref obBOF_PROC_TIME);
            txtTippedSideTime.Text = obBOF_PROC_TIME.ToString();
            Adapter.Session.Get(csUri, "Tapped_Proc_Time", ref obBOF_PROC_TIME);
            txtTippedSideTime.Text = obBOF_PROC_TIME.ToString();
            txtCasterWaitTime.Text = "5";

            foreach (Control c in tptime.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }
        }

        //更改
        private void btnChange_Click(object sender, EventArgs e)
        {
            bsTapping.EndEdit();

            string check = MessageBox.Show("确认要修改计划时间么？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdChangePlanTime.Execute();
                String returnFlag = cmdChangePlanTime.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("修改计划时间成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改计划时间不成功！", "提示");
                }
            }
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnChange.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ChangePlanTimeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}