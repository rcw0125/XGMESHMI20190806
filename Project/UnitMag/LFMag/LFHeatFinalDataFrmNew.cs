using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.LFMag
{
    public partial class LFHeatFinalDataFrmNew : DockContent, IMESForm
    {
        public LFHeatFinalDataFrmNew()
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSourceCondition = "to_char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "'";
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                {
                    if (cmbLFID.Text.Length > 0)
                        strSourceCondition += " and substr(TreatNo,0,1) = '" + cmbLFID.Text.Substring(2, 1) + "'";
                }
                else
                {
                    if (cmbLFID.Text.Length > 0)
                        strSourceCondition += " and substr(TreatNo,0,1) = '" + cmbLFID.Text.Substring(2, 1) + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%'";
                    else
                        strSourceCondition += " and HeatID like '%" + txtHeatID.Text.Trim() + "%'";
                }
            }
            else
                strSourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
            strSourceCondition += " order by TreatNo";
            dsData.SourceCondition = strSourceCondition;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                bsData.Position = e.RowIndex;
                string strtreatno = dvLFData.Rows[bsData.Position].Cells["TreatNo"].Value.ToString();
                string strHeatID = dvLFData.Rows[bsData.Position].Cells["HeatID"].Value.ToString();

                bool check = false;
                bool bLocked = false;

                if (cbxUpdate.Checked)
                    check = true;

                if (Convert.ToBoolean(dvLFData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                    bLocked = true;

                LFHeatInfoFrm Frm = new LFHeatInfoFrm();
                Frm.ShowDialogEx(Adapter.Session,bLocked, check, strtreatno, strHeatID);
                GC.Collect();
            }
            catch { }
        }

        private void LFHeatFinalDataFrm_Load(object sender, EventArgs e)
        {
            dtData.Value = DateTime.Now;
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
            {
                cmbLFID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //  [12/25/2008 sun]
                string strHeat = dvLFData.CurrentRow.Cells["HeatID"].Value.ToString();
                string strTreatNo = dvLFData.CurrentRow.Cells["TreatNo"].Value.ToString();
                string strYesNo = MessageBox.Show("确认炉号为:\"" + strHeat + "\"的实绩？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (strYesNo == "Yes")
                {
                    cmdConfirm.Parameters[0].ConstantValue = "S4" + strTreatNo.Substring(0,1);
                    cmdConfirm.Parameters[1].ConstantValue = strHeat;
                    cmdConfirm.Parameters[2].ConstantValue = strTreatNo;
                    cmdConfirm.Execute();
                    string ss = cmdConfirm.Command.Return.ToString();
                }
                //dsData.LoadData();
            }
            catch { }
        }

        private void dvLFData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvLFData, "TreatNo", "Locked", "1");
        }

        private void dvLFData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void LFHeatFinalDataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvLFData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string strHeat = dvLFData.CurrentRow.Cells["HeatID"].Value.ToString();
            //UnitMag.MESTool.GetData(Adapter, strGradeTypeSql);
            string sql = "update clf_base_data set locked=0 where heatid='"+strHeat+"'";
            UnitMag.MESTool.exeSql(Adapter, sql);
            MessageBox.Show("操作完成！");
        }
    }
}
