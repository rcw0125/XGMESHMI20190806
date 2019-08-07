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
    public partial class TundishWorkBuildMagFrm : DockContent, IMESForm
    {
        public TundishWorkBuildMagFrm()
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
        private void TundishWorkBuildMagFrm_Load(object sender, EventArgs e)
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
                dsDaub.SourceCondition = "DAUB_START_TIME between '" + dtS + "' and '" + dtE + "' order by DAUB_START_TIME asc";
            }
            else
            {
                dsDaub.SourceCondition = "TundishID = '" + cmbTundishID.Text.Trim() + "' and DAUB_START_TIME between '" + dtS + "' and '" + dtE + "' order by DAUB_START_TIME asc";
            }
        }

        //������EXL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�а�����������ʵ����Ϣ", dvDaub);
        }

        private void dvDaub_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}