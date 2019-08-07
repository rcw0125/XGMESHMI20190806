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
    public partial class TundishInnerBuildMagFrm : DockContent, IMESForm
    {
        public TundishInnerBuildMagFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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

        //�ؼ�����
        private void TundishInnerBuildMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
            cmbTundishID.Items.Clear();
            dsTundishID.SourceCondition = "TundishID is not null order by TundishID";
            for (int i = 0; i < dsTundishID.Tables[0].Rows.Count; i++)
            {
                cmbTundishID.Items.Add(dsTundishID.Tables[0].Rows[i][0].ToString());
            }
        }

        //�˳�
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
                dsInnerBuild.SourceCondition = "TIE_START_TIME between '" + dtS + "' and '" + dtE + "' order by TIE_START_TIME asc";
            }
            else
            {
                dsInnerBuild.SourceCondition = "TundishID = '" + cmbTundishID.Text.Trim() + "' and TIE_START_TIME between '" + dtS + "' and '" + dtE + "' order by TIE_START_TIME asc";
            }
        }

        //�Ƚ�����ʱ����
        private void dvInnerBuild_Sorted(object sender, EventArgs e)
        {
            //string ss = 
        }

        //������EXL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�а����ò�����ʵ����Ϣ", dvInnerBuild);
        }

        private void dvInnerBuild_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}