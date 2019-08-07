using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EnergyMag
{
    public partial class EnergyStatFrm : DockContent, IMESForm
    {
        public EnergyStatFrm()
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
        private string strCurSql = "";
        private void EnergyStatFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsStat.SourceCondition = "1=2";
            //DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            //DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " ProductionDate between '" + dtStart.Text.Trim() + "' and '" + dtEnd.Text.Trim() + "' order by ProductionDate";

            dsStat.SourceCondition = strCurSql;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newrow = dsStat.Tables[0].NewRow();
                newrow["CreateTime"] = DateTime.Now;
                newrow["ProductionDate"] = DateTime.Now.ToString("yyyy-MM-dd");
                newrow["Operator"] = Adapter.Session.User;

                newrow["Flow_CFCO"] = "0";
                newrow["Flow_BOFCO"] = "0";
                newrow["Flow_BOFCO_CallBack"] = "0";
                newrow["Flow_N2"] = "0";
                newrow["Flow_N2_SpecialSteel"] = "0";
                newrow["Flow_O2"] = "0";
                newrow["CFCO_D"] = "0";
                newrow["BOFCO_D"] = "0";
                newrow["BOFCO_CallBack_D"] = "0";
                newrow["N2_D"] = "0";
                newrow["N2_SpecialSteel_D"] = "0";
                newrow["O2_D"] = "0";
                newrow["CFCO_D_Avg"] = "0";
                newrow["BOFCO_D_Avg"] = "0";
                newrow["BOFCO_CallBack_D_Avg"] = "0";
                newrow["N2_D_Avg"] = "0";
                newrow["N2_SpecialSteel_D_Avg"] = "0";
                newrow["O2_D_Avg"] = "0";
                newrow["CFCO_M"] = "0";
                newrow["BOFCO_M"] = "0";
                newrow["BOFCO_CallBack_M"] = "0";
                newrow["N2_M"] = "0";
                newrow["N2_SpecialSteel_M"] = "0";
                newrow["O2_M"] = "0";
                newrow["CFCO_M_Avg"] = "0";
                newrow["BOFCO_M_Avg"] = "0";
                newrow["BOFCO_CallBack_M_Avg"] = "0";
                newrow["N2_M_Avg"] = "0";
                newrow["N2_SpecialSteel_M_Avg"] = "0";
                newrow["O2_M_Avg"] = "0";
                newrow["Production_D"] = "0";
                newrow["Production_M"] = "0";
                newrow["Production_Special_D"] = "0";
                newrow["Production_Special_M"] = "0";

                dsStat.Tables[0].Rows.Add(newrow);
                bsStat.MoveFirst();
                while (((System.Data.DataRowView)(bsStat.Current)).Row != newrow && bsStat.Position != dsStat.Tables[0].Rows.Count - 1)
                {
                    bsStat.MoveNext();
                }
                EnergyStatShowFrm Frm = new EnergyStatShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsStat.Position, true, ref dsStat);
                GC.Collect();
            }
            catch { }
        }

        private void dvEnergyData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dsStat.Tables[0].Rows.Count > 0)
            {
                bool bPreDtEnabled=false;
                if (dvStat.CurrentRow.Cells["GUID"].Value.ToString() == "")
                    bPreDtEnabled = true;

                EnergyStatShowFrm Frm = new EnergyStatShowFrm();
                Frm.ShowDialogEx(Adapter.Session, strSort, bsStat.Position,bPreDtEnabled, ref dsStat);
                GC.Collect();
            }
        }

        private void dvEnergyData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvStat.EndEdit();
            bsStat.EndEdit();
            if (dsStat.UpdateData())
            {
                MessageBox.Show("操作成功!", "提示");
                dsStat.LoadData();
            }
            else
                MessageBox.Show("操作失败!", "提示");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsStat.LoadData();
        }

        private void dvStat_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsStat.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("炼钢厂能源日消耗统计表", dvStat);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsStat.Position >= 0)
                bsStat.RemoveCurrent();
        }
    }
}