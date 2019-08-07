using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.AlloyStore
{
    public partial class LF4AlloyYLStoreMaintain : DockContent, IMESForm
    {
        public LF4AlloyYLStoreMaintain()
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

        private AppSvrHMI.L3DataSet tdsPublic1;
        private AppSvrHMI.L3DataSet tdsGroundLF5;
        private AppSvrHMI.L3DataSet tdsGroundPublic;
        private AppSvrHMI.L3DataSet tdsWireLF5;

        private AppSvrHMI.L3DataSet a = null;
        private AppSvrHMI.L3DataSet b = null;
        private AppSvrHMI.L3DataSet c = null;
        private AppSvrHMI.L3DataSet d = null;


        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DataTable dtCapture1 = dsPublic.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture1, a, Adapter.Session, dsForStoreMagQuery))
            {   //刷新数据
                dvPublic.EndEdit();
                bsPublic.EndEdit();
                dsPublic.UpdateData();
            }

            DataTable dtCapture2 = dsGroundLF5.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture2, b, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundLF5.EndEdit();
                bsGroundLF5.EndEdit();
                dsGroundLF5.UpdateData();
            }


            DataTable dtCapture3 = dsGroundPublic.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture3, c, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundPublic.EndEdit();
                bsGroundPublic.EndEdit();
                dsGroundPublic.UpdateData();
            }

            DataTable dtCapture4 = dsWireLF5.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture4, d, Adapter.Session, dsForStoreMagQuery))
            {
                dvWireLF5.EndEdit();
                bsWireLF5.EndEdit();
                dsWireLF5.UpdateData();
            }

        }


        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsPublic.LoadData();
            dsGroundLF5.LoadData();
            dsGroundPublic.LoadData();
            dsWireLF5.LoadData();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AlloyAndAreaRHMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void AlloyYLStoreMaintain_Load(object sender, EventArgs e)
        {
            tdsPublic1 = (AppSvrHMI.L3DataSet)(dsPublic.Clone());
            tdsGroundLF5 = (AppSvrHMI.L3DataSet)(dsGroundLF5.Clone());
            tdsGroundPublic = (AppSvrHMI.L3DataSet)(dsGroundPublic.Clone());
            tdsWireLF5 = (AppSvrHMI.L3DataSet)(dsWireLF5.Clone());
            tdsPublic1 = dsPublic;
            tdsWireLF5 = dsWireLF5;
            tdsGroundPublic = dsGroundPublic;
            tdsGroundLF5 = dsGroundLF5;
            //AppSvrHMI.L3DataSet d = null;
            a = (AppSvrHMI.L3DataSet)tdsPublic1.Copy();
            b = (AppSvrHMI.L3DataSet)tdsGroundLF5.Copy();
            c = (AppSvrHMI.L3DataSet)tdsGroundPublic.Copy();
            d = (AppSvrHMI.L3DataSet)tdsWireLF5.Copy();
        }

    }
}