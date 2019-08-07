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
    public partial class TundishOTHotFireMagFrm : DockContent, IMESForm
    {
        public TundishOTHotFireMagFrm()
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
        private void TundishOTHotFireMagFrm_Load(object sender, EventArgs e)
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

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsFireInfo.SourceCondition = "1=2";
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            if (cmbTundishID.Text.Trim() == "")
                dsFireInfo.SourceCondition = "FIRE_START_TIME between '" + dtS + "' and '" + dtE + "' order by FIRE_START_TIME asc";
            else
                dsFireInfo.SourceCondition = "TundishID = '" + cmbTundishID.Text.Trim() + "' and FIRE_START_TIME between '" + dtS + "' and '" + dtE + "' order by FIRE_START_TIME asc";
        }

        //������EXL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�а�������濾ʵ����Ϣ", dvM);
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}