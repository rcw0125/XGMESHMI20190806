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
    public partial class TundishInnerFireMagFrm : DockContent, IMESForm
    {
        public TundishInnerFireMagFrm()
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
        private void TundishInnerFireMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            cmbTundishID.Items.Clear();
            dsTundishID.SourceCondition = "TundishID is not null order by TundishID";
            for ( int i = 0; i < dsTundishID.Tables[0].Rows.Count; i++)
            {
                cmbTundishID.Items.Add(dsTundishID.Tables[0].Rows[i][0].ToString());
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            if (cmbTundishID.Text.Trim() == "")
            {
                dsTundishInnerFire.SourceCondition = "Small_Fire_Time between '" + dtS + "' and '" + dtE + "' order by Small_Fire_Time asc";
            }
            else
            {
                dsTundishInnerFire.SourceCondition = "TundishID = '"+cmbTundishID.Text.Trim()+"' and Small_Fire_Time between '" + dtS + "' and '" + dtE + "' order by Small_Fire_Time asc";
            }

        }

        //导出到EXL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("中包永久层烘烤实绩信息", dvInnerFire);
        }

        private void dvInnerFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}