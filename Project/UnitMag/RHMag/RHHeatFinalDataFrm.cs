using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.RHMag
{
    public partial class RHHeatFinalDataFrm : DockContent , IMESForm
    {
        public RHHeatFinalDataFrm()
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


        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void tsbtnEdit_Click ( object sender , EventArgs e )
        {

        }

        private void RHHeatFinalDataFrm_Load ( object sender , EventArgs e )
        {
            dtData.Value = DateTime.Now;
            for ( int i = 0 ; i < dsHeatID.Tables [0].Rows.Count ; i++ )
            {
                cmbBOFID.Items.Add( dsHeatID.Tables [0].Rows [i] ["Code"].ToString() );
            }
        }

        

        private void btnQuery_Click ( object sender , EventArgs e )
        {
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                {
                    if (cmbBOFID.Text.Length > 0)
                    {
                        dsBase.SourceCondition = "substr(TreatNo,1,1) = '" + cmbBOFID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' ORDER BY TREATNO ASC";
                    }
                    else
                    {
                        dsBase.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' ORDER BY TREATNO ASC";
                    }
                }
                else
                {
                    if (cmbBOFID.Text.Length > 0)
                    {
                        dsBase.SourceCondition = "substr(TreatNo,1,1) = '" + cmbBOFID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%' ORDER BY TREATNO ASC";
                    }
                    else
                    {
                        dsBase.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%' ORDER BY TREATNO ASC";
                    }
                }
            }
            else
            {
                dsBase.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "' ";
            }
        }

        private void dvBOFData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                string HeatID = dvRHData.Rows[e.RowIndex].Cells[1].Value.ToString();
                string TreatNo = dvRHData.Rows[e.RowIndex].Cells[0].Value.ToString();

                bool check = false;
                bool bLocked = false;
               
                if (cxCheckFlag.Checked)
                    check = true;
                if (Convert.ToBoolean(dvRHData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                    bLocked = true;
                
                RHHeatInfoFrm frmRHHeatInfo = new RHHeatInfoFrm();
                frmRHHeatInfo.ShowDialogEx(Adapter.Session,bLocked,check, HeatID, TreatNo);
                GC.Collect();
            }
            catch { }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //  [12/25/2008 sun]
                string strArea = "S5";
                string strHeat = dvRHData.CurrentRow.Cells["HeatID"].Value.ToString();
                string strTreatNo = dvRHData.CurrentRow.Cells["TreatNo"].Value.ToString();
                string strYesNo = MessageBox.Show("确认炉号为:\"" + strHeat + "\"的实绩？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo == "Yes")
                {
                    cmdConfirm.Parameters[0].ConstantValue = strArea + strTreatNo.Substring(0,1);
                    cmdConfirm.Parameters[1].ConstantValue = strHeat;
                    cmdConfirm.Parameters[2].ConstantValue = strTreatNo;
                    cmdConfirm.Execute();
                }
            }
            catch { }
        }

        private void dvRHData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvRHData, "TreatNo", "Locked", "1");
        }

        private void RHHeatFinalDataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}