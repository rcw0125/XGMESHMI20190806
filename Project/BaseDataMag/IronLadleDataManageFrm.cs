using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;

namespace BaseDataMag
{
    public partial class IronLadleDataManageFrm : DockContent, IMESForm
    {
        public IronLadleDataManageFrm()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnergyDataManageFrm_Load(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dsIronLadle.Tables[0].NewRow();
            dsIronLadle.Tables[0].Rows.Add(row);
        }

        private void dvEnergyData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private ArrayList alIDObject = new ArrayList();//缓存主键
        private ArrayList alTPC_No = new ArrayList();//缓存罐号
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvIronLadle.EndEdit();
            bsIronLadle.EndEdit();
            alIDObject.Clear();
            alTPC_No.Clear();

            for (int i = 0; i < dsIronLadle.Tables[0].Rows.Count; i++)
            {
                if (!((dsIronLadle.Tables[0].Rows[i].RowState.Equals(DataRowState.Added)) || (dsIronLadle.Tables[0].Rows[i].RowState.Equals(DataRowState.Modified))))
                {
                    if (dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString() != "")
                        alIDObject.Add(dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString());
                    if (dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString() != "")
                        alTPC_No.Add(dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString());
                }
                else if (dsIronLadle.Tables[0].Rows[i].RowState.Equals(DataRowState.Added))
                {
                    dsIronLadle.Tables[0].Rows[i]["GroupNo"] = dsIronLadle.Tables[0].Rows[i]["GroupNo"].ToString().ToUpperInvariant();
                    dsIronLadle.Tables[0].Rows[i]["IDObject"] = dsIronLadle.Tables[0].Rows[i]["GroupNo"].ToString() + dsIronLadle.Tables[0].Rows[i]["Order_No"].ToString();
                    if (alIDObject.Contains(dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString()))
                    {
                        MessageBox.Show("有分组号和组内顺序号重复!请检查", "提示");
                        dsIronLadle.Tables[0].Rows[i]["IDObject"] = "";
                        return;
                    }
                    if (alTPC_No.Contains(dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString()))
                    {
                        MessageBox.Show("有罐号重复!请检查", "提示");
                        return;
                    }
                    if (dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString() != "")
                        alIDObject.Add(dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString());
                    if (dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString() != "")
                        alTPC_No.Add(dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString());
                    dsIronLadle.Tables[0].Rows[i]["ModifyTime"] = DateTime.Now;
                    dsIronLadle.Tables[0].Rows[i]["Operator"] = Adapter.Session.User;
                }
                else if (dsIronLadle.Tables[0].Rows[i].RowState.Equals(DataRowState.Modified))
                {
                    if (alTPC_No.Contains(dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString()))
                    {
                        MessageBox.Show("有罐号重复!请检查", "提示");
                        return;
                    }
                    if (dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString() != "")
                        alIDObject.Add(dsIronLadle.Tables[0].Rows[i]["IDObject"].ToString());
                    if (dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString() != "")
                        alTPC_No.Add(dsIronLadle.Tables[0].Rows[i]["TPC_No"].ToString());
                    dsIronLadle.Tables[0].Rows[i]["ModifyTime"] = DateTime.Now;
                    dsIronLadle.Tables[0].Rows[i]["Operator"] = Adapter.Session.User;
                }
            }
            dsIronLadle.UpdateData();
            dsIronLadle.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsIronLadle.LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dvIronLadle.RowCount > 0)
            {
                if (MessageBox.Show("是否删除罐号" + dvIronLadle.CurrentRow.Cells["tPCNoDataGridViewTextBoxColumn"].Value.ToString() + "信息?", "提示", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
                {
                    bsIronLadle.RemoveCurrent();
                    dsIronLadle.UpdateData();
                }
            }
        }

        private void dvIronLadle_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dvIronLadle.CurrentRow.Cells["IDObject"].Value.ToString() != "")
            {
                dvIronLadle.CurrentRow.Cells["groupNoDataGridViewTextBoxColumn"].ReadOnly = true;
                dvIronLadle.CurrentRow.Cells["orderNoDataGridViewTextBoxColumn"].ReadOnly = true;
            }
        }

        private void 统计罐龄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < dvIronLadle.RowCount; i++)
            {
                if (dvIronLadle.Rows[i].Selected)
                {
                    string strTpcNo = dvIronLadle.Rows[i].Cells["tPCNoDataGridViewTextBoxColumn"].Value.ToString();
                    if (strTpcNo.Length == 1)
                        strTpcNo = "0" + strTpcNo;
                    al.Add(strTpcNo);
                }
            }
            string strID = dvIronLadle.CurrentRow.Cells["tPCNoDataGridViewTextBoxColumn"].Value.ToString();
            IronLadleAgeQueryFrm frm = new IronLadleAgeQueryFrm();
            frm.ShowDialogEx(Adapter.Session, al);
        }
    }
}