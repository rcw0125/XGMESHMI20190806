using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleUseMagFrm : DockContent, IMESForm
    {
        public IronLadleUseMagFrm()
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
        private string strCurSql = "";
        private object objShiftID = "";
        private object objTeamID = "";
        private string strSort = "";
        
        private void IronLadleUseMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-3);
            dtEnd.Value = DateTime.Now;

            cmbIronladleID.Items.Add("");
            for (int i = 0; i < dsIronLadleID.Tables[0].Rows.Count; i++)
            {
                cmbIronladleID.Items.Add(dsIronLadleID.Tables[0].Rows[i]["IronLadleID"]);
            }
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsUseInfo.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["IronLadleID"] = "";
                newrow["Check_Time"] = DateTime.Now;
                newrow["IronLadle_Age"] = 0;
                newrow["Wall_TEMP"] = 0;
                newrow["Bottom_TEMP"] = 0;
                newrow["Stop_Reason"] = "";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsUseInfo.Tables[0].Rows.Add(newrow);

                bsUseInfo.MoveFirst();//光标移动到最后一行
                while (((System.Data.DataRowView)(bsUseInfo.Current)).Row != newrow && bsUseInfo.Position != dsUseInfo.Tables[0].Rows.Count - 1)
                {
                    bsUseInfo.MoveNext();
                }
                IronLadleUseShowFrm Frm = new IronLadleUseShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsUseInfo.Position, strSort, ref dsUseInfo);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsUseInfo.Tables[0].Rows.Count > 0)
            {
                bsUseInfo.Position = e.RowIndex;
                IronLadleUseShowFrm Frm = new IronLadleUseShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsUseInfo.Position, strSort, ref dsUseInfo);
                GC.Collect();
            }
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsUseInfo.Position >= 0)
            {
                bsUseInfo.RemoveCurrent();
            }
            
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUseInfo.EndEdit();
            bsUseInfo.EndEdit();
            if (dsUseInfo.UpdateData())
            {
                MessageBox.Show("操作成功！", "提示");
                FormQueryString();
            }
            else
                MessageBox.Show("操作失败！", "提示");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        //查询
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (cmbIronladleID.Text != null && cmbIronladleID.Text != "")
            {
                strCurSql += " and IronLadleID = '" + cmbIronladleID.SelectedItem.ToString() + "'";
            }
            
            cmdUseInfo.Parameters[0].ConstantValue = strCurSql;
            dsUseInfo.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvUseInfo_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsUseInfo.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("铁包使用实绩", dvUseInfo);
        }

        private void IronLadleUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvUseInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}