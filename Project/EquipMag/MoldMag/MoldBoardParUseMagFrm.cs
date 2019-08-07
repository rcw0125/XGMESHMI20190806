using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.MoldMag
{
    public partial class MoldBoardParUseMagFrm : DockContent, IMESForm
    {
        public MoldBoardParUseMagFrm()
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

        private MoldBoardParUseShowFrm frm = new MoldBoardParUseShowFrm();

        //控件加载
        private void MoldBoardParUseMagFrm_Load(object sender, EventArgs e)
        {
            try
            {
                dtStart.Value = DateTime.Now;
                dtEnd.Value = DateTime.Now;

                cmbMoldID.Items.Clear();
                cmbMoldID.Items.Add("");
                if (dsMoldID.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < dsMoldID.Tables[0].Rows.Count; i++)
                    {
                        cmbMoldID.Items.Add(dsMoldID.Tables[0].Rows[i][0].ToString());
                    }
                }
                DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
                DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
                strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
                cmdM.Parameters[0].ConstantValue = strCurSql;
            }
            catch { }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增信息
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsM.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["Cast_ID"] = "S65";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsM.Tables[0].Rows.Add(newrow);

                bsM.MoveFirst();//
                while (((System.Data.DataRowView)(bsM.Current)).Row != newrow && bsM.Position != dsM.Tables[0].Rows.Count - 1)
                {
                    bsM.MoveNext();
                }

                frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
            }
            catch
            {
                //MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //修改信息
        private void dvM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsM.Tables[0].Rows.Count > 0)
            {
                bsM.Position = e.RowIndex;
                frm.ShowDialogEx(Adapter.Session, bsM.Position, strSort, ref dsM);
            }
        }

        //删除信息
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsM.Position >= 0)
            {
                bsM.RemoveCurrent();
            }
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsM.EndEdit();
            bool bMod = false;
            bool bDel = false;
            object objAdd = null;
            object objMod = null;
            object objDel = null;
            if (dsM.CommitAdded(ref objAdd))
            {
                if (objAdd.ToString() == "-1")
                {
                    MessageBox.Show("结晶器为空或找不到对应的装配编号！", "提示");
                    return;
                }
                if (objAdd.ToString() == "-3")
                {
                    MessageBox.Show("已经存在当前结晶器铜管的使用记录，不允许新增！", "提示");
                    return;
                }
                //bAdd = true;
            }
            if (dsM.CommitModified(ref objMod))
            {
                if (objMod.ToString() == "1")
                    bMod = true;
            }
            if (dsM.CommitDeleted(ref objDel))
            {
                if (objDel.ToString() == "1")
                    bDel = true;
            }
            if ((objMod == null || bMod == true) && (objDel == null || bDel == true))
            {
                MessageBox.Show("操作成功！", "提示");
                FormQueryString();
            }
            else
            {
                MessageBox.Show("操作失败！", "提示");
            }
            //dsM.UpdateData();
            //FormQueryString();
        }

        //查询
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (cmbMoldID.Text != "")
            {
                strCurSql += " and MOLDID = '" + cmbMoldID.Text.ToString() + "'";
            }
            cmdM.Parameters[0].ConstantValue = strCurSql;
            dsM.LoadData();
        }

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvM_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsM.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("结晶器铜板使用实绩", dvM);
        }

        private void MoldBoardParUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}