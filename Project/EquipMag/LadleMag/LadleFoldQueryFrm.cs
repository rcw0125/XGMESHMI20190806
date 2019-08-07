using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class LadleFoldQueryFrm : DockContent, IMESForm
    {
        public LadleFoldQueryFrm()
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


        private string strLadleID = "";
        private string strSort = "";

        private object objShiftID = "";
        private object objTeamID = "";

        LadleFoldShowFrm Frm = new LadleFoldShowFrm();
        //控件加载
        private void LadleFoldQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            cmbLadleID.Items.Clear();
            cmbLadleID.Items.Add("");
            if (dsLadleID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsLadleID.Tables[0].Rows.Count; i++)
                {
                    cmbLadleID.Items.Add(dsLadleID.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);

                DataRow newrow = dsM.Tables[0].NewRow();

                newrow["Input_Time"] = DateTime.Now;
                newrow["Weight"] = "0";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }
                Frm.ShowDialogEx(Adapter.Session, strSort, bsM.Position, ref dsM);
            }
            catch
            {
            }
        }

        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsM.Tables[0].Rows.Count > 0)
            {
                bsM.Position = e.RowIndex;
                Frm.ShowDialogEx(Adapter.Session, strSort, bsM.Position, ref dsM);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position >= 0)
                bsM.RemoveCurrent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsM.EndEdit();
            if (dsM.GetChanges() == null)
            {
                return;
            }


            if (dsM.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                dsM.LoadData();
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsM.RejectChanges();
            dsM.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            string strSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (strLadleID != "")
            {
                strSql += strLadleID;
            }
            strSql += " order by Input_Time desc,Out_LadleID asc";
            cmdM.Parameters[0].ConstantValue = strSql;
            dsM.LoadData(); 
        }

        private void cmbLadleID_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbLadleID.Text.ToString() != null && cmbLadleID.Text.ToString() != "")
            {
                strLadleID = " and Out_LadleID = '" + cmbLadleID.Text + "'";
            }
            else
            {
                strLadleID = "";
            }
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("钢包折灌实绩", dvM);
        }

        private void LadleFoldQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}