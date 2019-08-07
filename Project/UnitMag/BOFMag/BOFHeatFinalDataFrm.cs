using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BOFMag
{
    public partial class BOFHeatFinalDataFrm : DockContent, IMESForm
    {
        public BOFHeatFinalDataFrm()
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



        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void BOFHeatFinalDataFrm_Load(object sender, EventArgs e)
        {
            dtData.Value = DateTime.Now;
            for (int i = 0; i < dsHeatID.Tables[0].Rows.Count; i++)
            {
                cmbBOFID.Items.Add(dsHeatID.Tables[0].Rows[i]["Code"].ToString());
            }
        }

        //修改
        private void dvBOFData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string HeatID = dvBOFData.Rows[e.RowIndex].Cells[0].Value.ToString();
                bool check = false;
                bool bLocked = false;

                //数据维护
                if (cxCheckFlag.Checked)
                    check = true;

                //实绩锁定标志
                if (Convert.ToBoolean(dvBOFData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                    bLocked = true;

                BOFHeatInfoFrm frmBOFHeatInfo = new BOFHeatInfoFrm();
                frmBOFHeatInfo.ShowDialogEx(Adapter.Session, bLocked, check, HeatID,false);
                GC.Collect();
            }
            catch { }
        }
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                {
                    if (cmbBOFID.Text.Length > 0)
                    {
                        dsBOFData.SourceCondition = "substr(HeatID,2,1) = '" + cmbBOFID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                    }
                    else
                    {
                        dsBOFData.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                    }
                }
                else
                {
                    if (cmbBOFID.Text.Length > 0)
                    {
                        dsBOFData.SourceCondition = "HeatID like '%" + txtHeatID.Text.Trim() + "%' and substr(HeatID,2,1) = '" + cmbBOFID.Text.Substring(2, 1) + "' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                    }
                    else
                    {
                        dsBOFData.SourceCondition = "HeatID like '%" + txtHeatID.Text.Trim() + "%' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                    }
                }
            }
            else
            {
                dsBOFData.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
            }
            //dsBOFData.AcceptChanges();
        }
        //实绩确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //  [12/25/2008 sun][2009-04-02 Liao]
            string strHeat = dvBOFData.CurrentRow.Cells["HeatID"].Value.ToString();
            /******Modify By Huyunhai 2011-03-26*****/
            dsTempt.Clear();
            dsTempt.SourceMethod = "select a.CASTERID,a.HEATID,b.TAPPING_WEIGHT from CPLAN_TAPPING a,CBOF_Process_Data b where a.HEATID=b.HEATID and a.HEATID='" + strHeat + "'";
            dsTempt.LoadData();
            if (dsTempt.Tables[0].Rows.Count > 0)
            {
                if ((dsTempt.Tables[0].Rows[0]["CASTERID"].ToString() == "S66") && Convert.ToInt32(dsTempt.Tables[0].Rows[0]["TAPPING_WEIGHT"]) == 0)
                {
                    MessageBox.Show("不能实绩确认，请输入出钢量并保存！", "提示");
                    try
                    {
                        string HeatID = dvBOFData.CurrentRow.Cells[0].Value.ToString();
                        bool check = false;
                        bool bLocked = false;

                        //数据维护
                        if (cxCheckFlag.Checked)
                            check = true;

                        //实绩锁定标志
                        if (Convert.ToBoolean(dvBOFData.CurrentRow.Cells[Locked.Index].Value))
                            bLocked = true;

                        BOFHeatInfoFrm frmBOFHeatInfo = new BOFHeatInfoFrm();
                        frmBOFHeatInfo.ShowDialogEx(Adapter.Session, bLocked, check, HeatID, true);
                        GC.Collect();
                    }
                    catch { }
          
                }
            
            else
            {

                /******Modify End*******/
                try
                {
                    string strYesNo = MessageBox.Show("确认炉号为:\"" + strHeat + "\"的实绩？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (strYesNo == "Yes")
                    {
                        cmdConfirm.Parameters[0].ConstantValue = "S2" + strHeat.Substring(1, 1);
                        cmdConfirm.Parameters[1].ConstantValue = strHeat;
                        cmdConfirm.Parameters[2].ConstantValue = strHeat;
                        cmdConfirm.Execute();
                    }
                    //dsBOFData.LoadData();
                }
                catch { }
            }
        }
    }

        private void dvBOFData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBOFData, "HeatID", "Locked", "1");
        }

        private void dvBOFData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BOFHeatFinalDataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strHeat = dvBOFData.CurrentRow.Cells["HeatID"].Value.ToString();
            string applyType="";
            newApply frm = new newApply();
            frm.apply(strHeat,ref applyType);

            if (applyType != "")
            {
                string strSteelGradeIndex = dvBOFData.CurrentRow.Cells["steelGradeIndexDataGridViewTextBoxColumn"].Value.ToString();
                string strAddress = "Z" + strHeat.Substring(2, 1);
                int flag = 0;
                sendSheet.Parameters[0].ConstantValue = applyType;
                sendSheet.Parameters[1].ConstantValue = strAddress;
                sendSheet.Parameters[2].ConstantValue = strHeat;
                sendSheet.Parameters[3].ConstantValue = strSteelGradeIndex;
                sendSheet.Parameters[4].ConstantValue = flag.ToString();

                //sendSheet.Execute();

                int iRet = sendSheet.Execute();
                int iReturn = Convert.ToInt16(sendSheet.Command.Return.ToString());
                if (iRet != 0 || iReturn < 0)
                {
                    MessageBox.Show(string.Format("发送委托单失败！" + iReturn.ToString()));
                    return;

                }
                else
                {
                    MessageBox.Show("发送委托单成功！", "提示");
                }

            
            }
        }

    }
}