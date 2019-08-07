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
    public partial class AlloyAndAreaMapFrm : DockContent, IMESForm
    {

        private AppSvrHMI.L3DataSet tdsFire;
        private AppSvrHMI.L3DataSet tdsGround;
        private AppSvrHMI.L3DataSet tdsWire;
       
        private AppSvrHMI.L3DataSet a = null;
        private AppSvrHMI.L3DataSet b = null;
        private AppSvrHMI.L3DataSet c = null;
       

        public AlloyAndAreaMapFrm()
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

            dvFire.EndEdit();
            bsFire.EndEdit();
            DataTable dtCapture1 = dsFire.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture1, a,Adapter.Session,dsForStoreMagQuery))
            dsFire.UpdateData();

            dvGround.EndEdit();
            bsGround.EndEdit();
            DataTable dtCapture2 = dsGround.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture2, b,Adapter.Session,dsForStoreMagQuery))
            dsGround.UpdateData();

            dvWire.EndEdit();
            bsWire.EndEdit();
            DataTable dtCapture3 = dsWire.Tables[0].GetChanges(DataRowState.Modified);
            if (CommDataMag.CommonMethed.isModifyForMaterial(dtCapture3, c,Adapter.Session,dsForStoreMagQuery))
            dsWire.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsFire.LoadData();
            dsGround.LoadData();
            dsWire.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AlloyAndAreaMapFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void AlloyAndAreaMapFrm_Load(object sender, EventArgs e)
        {
            tdsFire = (AppSvrHMI.L3DataSet)(dsFire.Clone());
            tdsGround = (AppSvrHMI.L3DataSet)(dsGround.Clone());
            tdsWire = (AppSvrHMI.L3DataSet)(dsWire.Clone());

            tdsFire = dsFire;
            tdsGround = dsGround;
            tdsWire = dsWire;
          
            //AppSvrHMI.L3DataSet d = null;
            a = (AppSvrHMI.L3DataSet)tdsFire.Copy();
            b = (AppSvrHMI.L3DataSet)tdsGround.Copy();
            c = (AppSvrHMI.L3DataSet)tdsWire.Copy();
     
        }
    }
}