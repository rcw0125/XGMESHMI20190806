using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class ComLadleTieQueryFrm : DockContent, IMESForm
    {
        private string path = Application.StartupPath;

        public ComLadleTieQueryFrm()
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

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        //界面加载
        private void ComLadleTieQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbLadleID.Items.Clear();
            cmbLadleID.Items.Add("");
            if (dsLadleID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsLadleID.Tables[0].Rows.Count; i++)
                {
                    cmbLadleID.Items.Add(dsLadleID.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            if (cmbLadleID.Text.Trim() == "")
            {
                dsDetail.SourceCondition = "Input_Time between '" + dtS + "' and '" + dtE + "' order by Input_Time asc";
            }
            else
            {
                dsDetail.SourceCondition = "LadleID = '" + cmbLadleID.Text.Trim() + "' and Input_Time between '" + dtS + "' and '" + dtE + "' order by Input_Time asc";
            }
        }


        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("普通钢包修补实绩信息", dvDetail);
        }

        private void ComLadleTieQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

    }
}