using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace BaseDataMag
{
    public partial class EQMaterialMagFrm : DockContent, IMESForm
    {
        public EQMaterialMagFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ³ÉÔ±

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
        private EQMaterialMagShowFrm frm = new EQMaterialMagShowFrm();

        private void EQMaterialMagFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsEQM.Tables[0].NewRow();

            dsEQM.Tables[0].Rows.Add(newrow);
            bsEQM.MoveFirst();//
            while (((System.Data.DataRowView)(bsEQM.Current)).Row != newrow && bsEQM.Position != dsEQM.Tables[0].Rows.Count - 1)
            {
                bsEQM.MoveNext();
            }

            frm.ShowDialogEx(Adapter.Session, bsEQM.Position, strSort, ref dsEQM);
        }

        private void dvEQM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (bsEQM.Position >= 0)
            {
                frm.ShowDialogEx(Adapter.Session, bsEQM.Position, strSort, ref dsEQM);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsEQM.Position >= 0)
            {
                bsEQM.RemoveCurrent();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvEQM.EndEdit();
            bsEQM.EndEdit();

            dsEQM.UpdateData();
            dsEQM.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsEQM.LoadData();
        }

        private void dvEQM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsEQM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EQMaterialMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}