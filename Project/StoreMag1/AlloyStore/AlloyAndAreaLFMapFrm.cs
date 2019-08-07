using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.AlloyStore
{
    public partial class AlloyAndAreaLFMapFrm : DockContent, IMESForm
    {

        private AppSvrHMI.L3DataSet tdsBOF;
        private AppSvrHMI.L3DataSet tdsLFOne;
        private AppSvrHMI.L3DataSet tdsLFTwo;
        private AppSvrHMI.L3DataSet tdsGroundPublic;
        private AppSvrHMI.L3DataSet tdsGroundLF1;
        private AppSvrHMI.L3DataSet tdsGroundLF2;
        private AppSvrHMI.L3DataSet tdsWireLF1;
        private AppSvrHMI.L3DataSet tdsWireLF2;

        private AppSvrHMI.L3DataSet dsA = null;
        private AppSvrHMI.L3DataSet dsB = null;
        private AppSvrHMI.L3DataSet dsC = null;
        private AppSvrHMI.L3DataSet dsD = null;
        private AppSvrHMI.L3DataSet dsE = null;
        private AppSvrHMI.L3DataSet dsF= null;
        private AppSvrHMI.L3DataSet dsG = null;
        private AppSvrHMI.L3DataSet dsH = null;


        public AlloyAndAreaLFMapFrm()
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

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //刷新数据

            DataTable dtCapture1 = dsBOF.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture1, dsA, Adapter.Session, dsForStoreMagQuery))
            {
                dvBOF.EndEdit();
                bsBOF.EndEdit();
                dsBOF.UpdateData();

            }

            DataTable dtCapture2 = dsLFOne.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture2, dsB, Adapter.Session, dsForStoreMagQuery))
            {

                dvLFOne.EndEdit();
                bsLFOne.EndEdit();
                dsLFOne.UpdateData();


            }


            DataTable dtCapture3 = dsLFTwo.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture3, dsC, Adapter.Session, dsForStoreMagQuery))
            {
                dvLFTwo.EndEdit();
                bsLFTwo.EndEdit();
                dsLFTwo.UpdateData();

            }


            DataTable dtCapture4 = dsGroundPublic.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture4, dsD, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundPublic.EndEdit();
                bsGroundPublic.EndEdit();
                dsGroundPublic.UpdateData();
            }

            DataTable dtCapture5 = dsGroundLF1.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture5, dsE, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundLF1.EndEdit();
                bsGroundLF1.EndEdit();
                dsGroundLF1.UpdateData();
            }


            DataTable dtCapture6 = dsGroundLF2.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture6, dsF, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundLF2.EndEdit();
                bsGroundLF2.EndEdit();
                dsGroundLF2.UpdateData();
            }


            DataTable dtCapture7 = dsWireLF1.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture7, dsG, Adapter.Session, dsForStoreMagQuery))
            {
                dvWireLF1.EndEdit();
                bsWireLF1.EndEdit();
                dsWireLF1.UpdateData();
            }


            DataTable dtCapture8 = dsWireLF2.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture8, dsH, Adapter.Session, dsForStoreMagQuery))
            {
                dvWireLF2.EndEdit();
                bsWireLF2.EndEdit();
                dsWireLF2.UpdateData();
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBOF.LoadData();
            dsLFOne.LoadData();
            dsLFTwo.LoadData();
            dsGroundPublic.LoadData();
            dsGroundLF1.LoadData();
            dsGroundLF2.LoadData();
            dsWireLF1.LoadData();
            dsWireLF2.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AlloyAndAreaLFMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void AlloyAndAreaLFMapFrm_Load(object sender, EventArgs e)
        {

            tdsBOF = (AppSvrHMI.L3DataSet)(dsBOF.Clone());
            tdsLFOne = (AppSvrHMI.L3DataSet)(dsLFOne.Clone());
            tdsLFTwo = (AppSvrHMI.L3DataSet)(dsLFTwo.Clone());
            tdsGroundPublic = (AppSvrHMI.L3DataSet)(dsGroundPublic.Clone());
            tdsGroundLF1 = (AppSvrHMI.L3DataSet)(dsGroundLF1.Clone());
            tdsGroundLF2 = (AppSvrHMI.L3DataSet)(dsGroundLF2.Clone());
            tdsWireLF1 = (AppSvrHMI.L3DataSet)(dsWireLF1.Clone());
            tdsWireLF2 = (AppSvrHMI.L3DataSet)(dsWireLF2.Clone());

            tdsBOF = dsBOF;
            tdsLFOne = dsLFOne;
            tdsLFTwo = dsLFTwo;
            tdsGroundPublic = dsGroundPublic;
            tdsGroundLF1 = dsGroundLF1;
            tdsGroundLF2 = dsGroundLF2;
            tdsWireLF1 = dsWireLF1;
            tdsWireLF2 = dsWireLF2;

            //AppSvrHMI.L3DataSet d = null;
            dsA = (AppSvrHMI.L3DataSet)tdsBOF.Copy();
            dsB = (AppSvrHMI.L3DataSet)tdsLFOne.Copy();
            dsC = (AppSvrHMI.L3DataSet)tdsLFTwo.Copy();
            dsD = (AppSvrHMI.L3DataSet)tdsGroundPublic.Copy();
            //e = (AppSvrHMI.L3DataSet)tdsGroundLF1.Copy();
            dsE = (AppSvrHMI.L3DataSet)tdsGroundLF1.Copy();
            dsF= (AppSvrHMI.L3DataSet)tdsGroundLF2.Copy();
            dsG = (AppSvrHMI.L3DataSet)tdsWireLF1.Copy();
            dsH = (AppSvrHMI.L3DataSet)tdsWireLF2.Copy();



        }

    }
}