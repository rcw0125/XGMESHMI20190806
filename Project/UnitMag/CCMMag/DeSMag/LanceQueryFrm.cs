using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.DeSMag
{
    public partial class LanceQueryFrm : DockContent, IMESForm
    {
        public LanceQueryFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();
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

        private void LanceQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            for (int i = 0; i < dsStatus.Tables[0].Rows.Count; i++)
            {
                cmbStatus.Items.Add(dsStatus.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text =="废弃")
            {
                dsLance.SourceCondition = "1=2";
                DateTime dtS = Convert.ToDateTime(dtStart.Text);
                DateTime dtE = Convert.ToDateTime(dtEnd.Text + " 23:59:59");
                //dsFQ.SourceCondition = "Status=5  and Time_Change between '" + dtS + "' and '" + dtE + "'  order by LANCENO DESC ";
                dsFQ.SourceCondition = " Status=5  and OPTIME between to_date('" + dtS + "','yyyy-MM-dd Hh24:mi:ss') and to_date('" + dtE + "','yyyy-MM-dd Hh24:mi:ss')   order by LANCENO DESC ";
                dsFQ.LoadData();
            }
            else
            {
                dsFQ.SourceCondition = "1=2";
                DateTime dtS = Convert.ToDateTime(dtStart.Text);
                DateTime dtE = Convert.ToDateTime(dtEnd.Text + " 23:59:59");
                if (txtLanceNo.Text == "")
                {
                    if (cmbStatus.Text == "")
                        dsLance.SourceCondition = "Time_Change between '" + dtS + "' and '" + dtE + "' order by Time_Change desc";
                    else
                        dsLance.SourceCondition = "Status = " + CommDataMag.CommonMethed.GetIntCodeByDesc(dsStatus, cmbStatus.Text).ToString() + " and Time_Change between '" + dtS + "' and '" + dtE + "' order by Time_Change desc"; ;
                }
                else
                {
                    dsLance.SourceCondition = "LanceNo = '" + txtLanceNo.Text.Trim() + "'";
                }
                dsLance.LoadData();
                //dsDeSStatus.SourceCondition = "Log_Time between '" + dtS + "' and '" + dtE + "' and DeSID = 1 order by Log_Time desc";
            }
        }

        private void btnInExl_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("喷枪信息", dvLance);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("废弃喷枪信息", dataGridView1);
        }

    }
}