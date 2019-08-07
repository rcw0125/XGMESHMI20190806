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
    public partial class BaseAllCodeMagFrm : DockContent, IMESForm
    {
        public BaseAllCodeMagFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ≥…‘±

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
        private string strCodeGroup = "";

        private void BaseAllCodeMagFrm_Load(object sender, EventArgs e)
        {
            dsCodeGroup.SourceMethod = "select Code_Group ,Code_Group_Des from CBase_All_Code where Code_Group is not null Group by Code_Group ,Code_Group_Des order by Code_Group_Des ";
            cmbCodeGroup.Items.Clear();
            for (int i = 0; i < dsCodeGroup.Tables[0].Rows.Count; i++)
            {
                cmbCodeGroup.Items.Add(dsCodeGroup.Tables[0].Rows[i]["Code_Group_Des"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBase.Tables[0].NewRow();
            newrow["Code_Group"] = dsBase.Tables[0].Rows[0]["Code_Group"];
            newrow["Code_Group_Des"] = dsBase.Tables[0].Rows[0]["Code_Group_Des"];
            newrow["Code_Function_Group"] = dsBase.Tables[0].Rows[0]["Code_Function_Group"];
            dsBase.Tables[0].Rows.Add(newrow);
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsBase.Position >= 0)
            {
                bsBase.RemoveCurrent();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBase.EndEdit();
            bsBase.EndEdit(); 

            dsBase.UpdateData();
            dsBase.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCodeGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            strCodeGroup = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCodeGroup, "Code_Group", "Code_Group_Des", cmbCodeGroup.Text.ToString());
            if (strCodeGroup != "")
            {
                dsBase.SourceCondition = "Code_Group = '" + strCodeGroup + "' order by Code";
            }
            else
            {
                dsBase.Tables[0].Rows.Clear();
            }
        }

        private void dvBase_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvBase.Rows.Count < 1)
            {
                btnAdd.Enabled = false;
                //btnDel.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                //btnDel.Enabled = true;
                for (int i = 0; i < dvBase.Rows.Count; i++)
                {
                    if (dvBase.Rows[i].Cells[GUID_All_Code.Index].Value.ToString() != "")
                        dvBase.Rows[i].Cells[Code.Index].ReadOnly = true;
                    else
                        dvBase.Rows[i].Cells[Code.Index].ReadOnly = false;
                }

            }
        }

        private void BaseAllCodeMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}