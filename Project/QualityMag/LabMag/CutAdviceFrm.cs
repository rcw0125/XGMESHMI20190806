using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.LabMag
{
    public partial class CutAdviceFrm : DockContent, IMESForm
    {
        public CutAdviceFrm()
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

        private string strSort = "";
        AdviceInfoFrm Frm = new AdviceInfoFrm();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加一行数据，对相应数据进行填充
            DataRow newrow = dsCutAdvice.Tables[0].NewRow();
            dsCutAdvice.Tables[0].Rows.Add(newrow);
            bsCutAdvice.MoveFirst();
            while (((System.Data.DataRowView)(bsCutAdvice.Current)).Row != newrow && bsCutAdvice.Position != dsCutAdvice.Tables[0].Rows.Count - 1)
            {
                bsCutAdvice.MoveNext();
            }
            Frm.ShowDialogEx(Adapter.Session, bsCutAdvice.Position, strSort, ref dsCutAdvice);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCutAdvice.EndEdit();
            bsCutAdvice.EndEdit();
            DataSet ds = dsCutAdvice.GetChanges(DataRowState.Added);
            //2009-03-11
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                object objAdd = null;
                if (dsCutAdvice.CommitAdded(ref objAdd))
                {
                    if (Convert.ToInt32(objAdd) > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            string strCCMID = ds.Tables[0].Rows[i]["CASTERID"].ToString();
                            string strUri = CommDataMag.CommonData.CCM_CLASS_URI + strCCMID;

                            object objCut = null;
                            int iCut = 0;
                            if (Adapter.Session.Get(strUri, "Cut_Information", ref objCut) >= 0)
                            {
                                try
                                {
                                    iCut = Convert.ToInt32(objCut);
                                    iCut = iCut % 9999 + 1;
                                }
                                catch { iCut = iCut + 1; }
                            }
                            Adapter.Session.Set(strUri, "Cut_Information", iCut);
                        }
                    }
                }
            }
            object objDel = null;
            dsCutAdvice.CommitDeleted(ref objDel);
            dsCutAdvice.LoadData();
        }

        private void CutAdviceFrm_Load(object sender, EventArgs e)
        {
            dsCutAdvice.LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCutAdvice.Position >= 0)
                bsCutAdvice.RemoveCurrent();
        }

        private void dvCutAdvice_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsCutAdvice.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsCutAdvice.LoadData();
        }

        private void CutAdviceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}