using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.TundishMag
{
    public partial class TundishFireDataFrm : DockContent, IMESForm
    {
        public TundishFireDataFrm()
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


        private void TundishFireDataFrm_Load(object sender, EventArgs e)
        {
            cmbCCMID.Items.Clear();
            for (int i = 0; i < dsCCMID.Tables[0].Rows.Count; i++)
            {
                cmbCCMID.Items.Add(dsCCMID.Tables[0].Rows[i]["Code"].ToString());
            }

            cmbTundishID.Items.Clear();
            cmbTundishID.Items.Add("");
            for (int j = 0; j < dsTundishID.Tables[0].Rows.Count; j++)
            {
                cmbTundishID.Items.Add(dsTundishID.Tables[0].Rows[j][0].ToString());
            }

            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsM.SourceCondition = " 1 = 2";

            string strSQL = "";
            strSQL = "to_Char(MeasureTime,'yyyy-MM-dd') >= '" + dtStart.Text + "' and to_Char(MeasureTime,'yyyy-MM-dd') <= '" +dtEnd.Text + "'";
            
            if (cmbCCMID.Text != "")
                strSQL += " and Cast_ID = '" + cmbCCMID.Text + "'";
            
            if (cmbTundishID.Text != "")
                strSQL += " and TundishID = '" + cmbTundishID.Text + "'";

            strSQL += " order by Cast_ID,TundishID,MeasureTime";
            dsM.SourceCondition = strSQL;
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("连铸中包温度在线烘烤实绩", dvM);
        }
    }
}