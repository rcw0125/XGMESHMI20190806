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
    public partial class AlloyAndAreaRHMapFrm : DockContent, IMESForm
    {

        private AppSvrHMI.L3DataSet tdsPublic;
        private AppSvrHMI.L3DataSet tdsGroundLF3;
        private AppSvrHMI.L3DataSet tdsGroundPublic;
        private AppSvrHMI.L3DataSet tdsWireLF3;
        private AppSvrHMI.L3DataSet tdsWireRH;

        private AppSvrHMI.L3DataSet dsA = null;
        private AppSvrHMI.L3DataSet dsB = null;
        private AppSvrHMI.L3DataSet dsC = null;
        private AppSvrHMI.L3DataSet dsD = null;
        private AppSvrHMI.L3DataSet dsE = null;
       
        public AlloyAndAreaRHMapFrm()
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
           
            DataTable dtCapture1 = dsPublic.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture1, dsA, Adapter.Session, dsForStoreMagQuery))
            {
                dvPublic.EndEdit();
                bsPublic.EndEdit();
                dsPublic.UpdateData();
              
            }
           
            DataTable dtCapture2 = dsGroundLF3.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture2, dsB, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundLF3.EndEdit();
                bsGroundLF3.EndEdit();
                dsGroundLF3.UpdateData();
              
            }
           
            DataTable dtCapture3 = dsGroundPublic.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture3, dsC, Adapter.Session, dsForStoreMagQuery))
            {
                dvGroundPublic.EndEdit();
                bsGroundPublic.EndEdit();
                dsGroundPublic.UpdateData();
               
            }
            
          
            DataTable dtCapture4 = dsWireLF3.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture4, dsD, Adapter.Session, dsForStoreMagQuery))
            {
                dvWireLF3.EndEdit();
                bsWireLF3.EndEdit();
                dsWireLF3.UpdateData();
               
            }

            DataTable dtCapture5 = dsWireRH.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture5, dsE, Adapter.Session, dsForStoreMagQuery))
            {
                dvWireRH.EndEdit();
                bsWireRH.EndEdit();
                dsWireRH.UpdateData();
              
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsPublic.LoadData();
            dsGroundLF3.LoadData();
            dsGroundPublic.LoadData();
            dsWireLF3.LoadData();
            dsWireRH.LoadData();

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

        private void AlloyAndAreaRHMapFrm_Load(object sender, EventArgs e)
        {
            tdsPublic = (AppSvrHMI.L3DataSet)(dsPublic.Clone());
            tdsGroundLF3 = (AppSvrHMI.L3DataSet)(dsGroundLF3.Clone());
            tdsGroundPublic = (AppSvrHMI.L3DataSet)(dsGroundPublic.Clone());
            tdsWireLF3 = (AppSvrHMI.L3DataSet)(dsWireLF3.Clone());
            tdsWireRH = (AppSvrHMI.L3DataSet)(dsWireRH.Clone());
           
            tdsPublic = dsPublic;
            tdsGroundLF3 = dsGroundLF3;
            tdsGroundPublic = dsGroundPublic;
            tdsWireLF3 = dsWireLF3;
            tdsWireRH = dsWireRH;

            //AppSvrHMI.L3DataSet d = null;
            dsA = (AppSvrHMI.L3DataSet)tdsPublic.Copy();
            dsB = (AppSvrHMI.L3DataSet)tdsGroundLF3.Copy();
            dsC = (AppSvrHMI.L3DataSet)tdsGroundPublic.Copy();
            dsD = (AppSvrHMI.L3DataSet)tdsWireLF3.Copy();
            //e = (AppSvrHMI.L3DataSet)tdsWireRH.Copy();
            dsE = (AppSvrHMI.L3DataSet)tdsWireRH.Copy();

        }
    }
}