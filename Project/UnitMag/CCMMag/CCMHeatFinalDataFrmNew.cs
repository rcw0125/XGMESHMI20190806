using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.CCMMag
{
    public partial class CCMHeatFinalDataFrmNew : DockContent, IMESForm
    {
        public CCMHeatFinalDataFrmNew()
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


        public void ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            this.Adapter.Session = session;
            this.ShowDialog();
        }

        private int iLockColIndex = -1;
        private void CCMHeatFinalDataFrm_Load(object sender, EventArgs e)
        {
            iLockColIndex = dvCCMData.Columns["Locked"].Index;
            dtData.Value = DateTime.Now;
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
            {
                cmbCCMID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                {
                    if (cmbCCMID.Text.Length > 0)
                        dsBase.SourceCondition = "substr(TreatNo,1,1) = '" + cmbCCMID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by ProductionDate";
                    else
                        dsBase.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by ProductionDate";
                }
                else
                {
                    if (cmbCCMID.Text.Length > 0)
                        dsBase.SourceCondition = "HeatID like '%" + txtHeatID.Text.Trim() + "%' and substr(TreatNo,1,1) = '" + cmbCCMID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by ProductionDate";
                    else
                        dsBase.SourceCondition = "HeatID like '%" + txtHeatID.Text.Trim() + "%' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by ProductionDate";
                }
            }
            else
                dsBase.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
        }

        private void dvCCMData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bsBase.Position = e.RowIndex;
                if (bsBase.Position < 0)
                    return;

                DataSet dsSend = dsBase.Clone();
                dsSend.Tables[0].ImportRow(dsBase.Tables[0].Rows[dsBase.Tables[0].Rows.IndexOf
                    (((System.Data.DataRowView)(bsBase.Current)).Row)]);

                string strHeatID = dvCCMData.Rows[e.RowIndex].Cells[1].Value.ToString();
                string strTreatNo = dvCCMData.Rows[e.RowIndex].Cells[0].Value.ToString();

                bool check = false;
                bool bLocked = false;

                if (cxCheckFlag.Checked)
                    check = true;
                if (Convert.ToBoolean(dvCCMData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                    bLocked = true;
                //连铸数据维护
                CCMHeatInfoFrm frmCCMHeatInfo = new CCMHeatInfoFrm();
                frmCCMHeatInfo.ShowDialogEx(Adapter.Session,bLocked, check, dsSend, strHeatID, strTreatNo);
                GC.Collect();
            }
            catch(Exception j)
            { MessageBox.Show(j.ToString()); }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //  [12/25/2008 sun]
                string strHeat = dvCCMData.CurrentRow.Cells["HeatID"].Value.ToString();
                string strTreatNo = dvCCMData.CurrentRow.Cells["TreatNo"].Value.ToString();
                string strYesNo = MessageBox.Show("确认炉号为:\"" + strHeat + "\"的实绩？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo == "Yes")
                {
                    cmdConfirm.Parameters[0].ConstantValue = "S6" + strTreatNo.Substring(0,1);
                    cmdConfirm.Parameters[1].ConstantValue = strHeat;
                    cmdConfirm.Parameters[2].ConstantValue = strTreatNo;
                    cmdConfirm.Execute();
                }
            }
            catch { }
        }

        private void dvCCMData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvCCMData, "TreatNo", "Locked", "1");
        }

        private void dvCCMData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void CCMHeatFinalDataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        /*********20090116**********/
        private void btnCureData_Click(object sender, EventArgs e)
        {
            try
            {
                string strHeatID = dvCCMData.Rows[bsBase.Position].Cells[1].Value.ToString();
                string strCCMID = dvCCMData.Rows[bsBase.Position].Cells[CCMID.Index].Value.ToString();

                bool check = false;
                if (cxCheckFlag.Checked)
                {
                    if (Convert.ToBoolean(dvCCMData.Rows[bsBase.Position].Cells[Locked.Index].Value))
                    {
                        check = false;
                    }
                    else
                    {
                        check = true;
                    }
                }

                CCMCureDataFrm CureDataFrm = new CCMCureDataFrm();
                CureDataFrm.ShowDialogEx(Adapter.Session, check, strCCMID, strHeatID);

                GC.Collect();
            }
            catch { }
        }

        private void dvCCMData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex == iLockColIndex)
            //{
            //    if (e.Value.ToString() == "1")
            //    {
 
            //    }
            //}
            ////
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string strHeat = dvCCMData.CurrentRow.Cells["HeatID"].Value.ToString();
            //UnitMag.MESTool.GetData(Adapter, strGradeTypeSql);
            string sql = "update cccm_base_data set locked=0 where heatid='" + strHeat + "'";
            UnitMag.MESTool.exeSql(Adapter, sql);
            MessageBox.Show("操作完成！");
        }
    }
}