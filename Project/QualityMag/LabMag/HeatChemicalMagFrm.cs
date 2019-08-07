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
    public partial class HeatChemicalMagFrm : DockContent, IMESForm
    {
        public HeatChemicalMagFrm()
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
        ChemicalInfoFrm Frm = new ChemicalInfoFrm();
        private void bnIronLadle_RefreshItems(object sender, EventArgs e)
        {

        }

        private void tSp1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //添加一行数据，对相应数据进行填充
            DataRow newrow = dsChemical.Tables[0].NewRow();
            newrow["DataLogMode"] = 1;
            newrow["Report_Date"] = DateTime.Now;
            dsChemical.Tables[0].Rows.Add(newrow);
            bsChemical.MoveFirst();
            while (((System.Data.DataRowView)(bsChemical.Current)).Row != newrow && bsChemical.Position != dsChemical.Tables[0].Rows.Count - 1)
            {
                bsChemical.MoveNext();
            }

            Frm.ShowDialogEx(Adapter.Session, bsChemical.Position, strSort, ref dsChemical);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvChemical.EndEdit();
            bsChemical.EndEdit();
            dsChemical.UpdateData();
            dsChemical.LoadData();
        }

        private void dvChemical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dvChemical_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsChemical.Current)).DataView.Sort.ToString();
            }
            catch { }
        }
        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsChemical.Position >= 0)
                bsChemical.RemoveCurrent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeatChemicalMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}