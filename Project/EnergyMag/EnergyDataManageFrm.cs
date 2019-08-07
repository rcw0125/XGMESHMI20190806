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
    public partial class EnergyDataManageFrm : DockContent, IMESForm
    {
        public EnergyDataManageFrm()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnergyDataManageFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                dsEnergyData.SourceCondition = "1=2";
                string strStart = dtStart.Value.ToString("yyyyMMdd");
                string strEnd = dtEnd.Value.ToString("yyyyMMdd");
                dsEnergyData.SourceCondition = "ProductionDate between '" + strStart + "' and '" + strEnd + "' order by ProductionDate,TagName";
                
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //添加一行数据，对相应数据进行填充
                DataRow newrow = dsEnergyData.Tables[0].NewRow();
                newrow["ProductionDate"] = DateTime.Now.ToString("yyyyMMdd");
                newrow["CreateTime"] = DateTime.Now;

                newrow["TagValue"] = 0;
                newrow["DayValue"] = 0;
                newrow["MonthValue"] = 0;
                newrow["Operator"] = Adapter.Session.User;

                dsEnergyData.Tables[0].Rows.Add(newrow);
                
                bsEnergyData.MoveFirst();
                while ((bsEnergyData.Current as System.Data.DataRowView).Row != newrow || bsEnergyData.Position < dsEnergyData.Tables[0].Rows.Count - 1)
                {
                    bsEnergyData.MoveNext();
                }
                EnergyDataAddModFrm frm = new EnergyDataAddModFrm();
                frm.ShowDialogEx(Adapter.Session, bsEnergyData.Position, strSort, ref dsEnergyData);
             
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dvEnergyData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dsEnergyData.Tables[0].Rows.Count > 0)
                {
                    bsEnergyData.Position = e.RowIndex;
                   
                    EnergyDataAddModFrm frm = new EnergyDataAddModFrm();
                    frm.ShowDialogEx(Adapter.Session, bsEnergyData.Position, strSort, ref dsEnergyData);

                    GC.Collect();
                }
            }
            catch { }
        }

        private void dvEnergyData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvEnergyData.EndEdit();
            bsEnergyData.EndEdit();

            bool bSucc = false;
            if (dsEnergyData.GetChanges(DataRowState.Modified) != null &&
                dsEnergyData.GetChanges(DataRowState.Modified).Tables[0].Rows.Count > 0)
            {
              
                    cmdMod.Parameters[0].SourceObject = dsEnergyData.GetChanges(DataRowState.Modified);
                    cmdMod.Execute();
                    bool flagMod = Convert.ToBoolean(cmdMod.Command.Return);
                    if (flagMod)
                    {
                        MessageBox.Show("修改成功!", "提示");
                        bSucc = true;
                    }
                    else
                    {
                        MessageBox.Show("修改失败!", "提示");
                        return;
                    }
            }
            //新增
            if (dsEnergyData.GetChanges(DataRowState.Added) != null &&
                dsEnergyData.GetChanges(DataRowState.Added).Tables[0].Rows.Count > 0)
            {
                cmdAdd.Parameters[0].SourceObject = dsEnergyData.GetChanges(DataRowState.Added);
                cmdAdd.Execute();
                bool flagAdd = Convert.ToBoolean(cmdAdd.Command.Return);
                if (flagAdd)
                {
                    MessageBox.Show("新增成功!", "提示");
                    bSucc = true;
                }
                else
                {
                    MessageBox.Show("新增失败!", "提示");
                    return;
                }
            }
            if (bSucc)
                dsEnergyData.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsEnergyData.LoadData();
        }

        private void dvEnergyData_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsEnergyData.Current)).DataView.Sort.ToString();
            }
            catch { }
        }
    }
}