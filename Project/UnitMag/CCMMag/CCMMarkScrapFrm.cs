using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.CCMMag
{
    public partial class CCMMarkScrapFrm : DockContent, IMESForm
    {
        public CCMMarkScrapFrm()
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


        private AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();
        private string strUnitID = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("CCMID", UnitID);
            strUnitID = UnitID;
            Adapter.Session = session;
            //dsHeatData.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\" + UnitID;
            return ShowDialog();
        }

        //数据加载
        private void CCMMarkScrapFrm_Load(object sender, EventArgs e)
        {
            cmbCasterID.Items.Clear();
            dsSend = (AppSvrHMI.L3DataSet)dsHeatData.Clone();
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
            {
                cmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code"]);
            }
        }

        //甩废
        private void btnThrow_Click(object sender, EventArgs e)
        {
            CCMScrapInfoFrm Frm = new CCMScrapInfoFrm();
            dsSend.Tables[0].Clear();
            int iRowIndex = dsHeatData.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsHeatData.Current)).Row);
            if (dsHeatData.Tables[0].Rows[iRowIndex]["MATERIALID"].ToString() == "")
            {
                MessageBox.Show("当前选中炉次信息没有炉号，不允许操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dsSend.Tables[0].ImportRow(dsHeatData.Tables[0].Rows[iRowIndex]);
            Frm.ShowDialogEx(Adapter.Session, dsSend, strUnitID);
            dsHeatData.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //数据邦定完成
        private void dvHeatData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dvHeatData.Rows.Count < 1)
                btnThrow.Enabled = false;
            else
                btnThrow.Enabled = true;
        }

        //预约浇次结束事件,刷新炉次数据
        private void l3dbxCastingEndEvent_TextChanged(object sender, EventArgs e)
        {
            dsHeatData.LoadData();
        }

        private void dvHeatData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CCMScrapInfoFrm Frm = new CCMScrapInfoFrm();
            dsSend.Tables[0].Clear();
            int iRowIndex = dsHeatData.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsHeatData.Current)).Row);
            if (dsHeatData.Tables[0].Rows[iRowIndex]["MATERIALID"].ToString() == "")
            {
                MessageBox.Show("当前选中炉次信息没有炉号，不允许操作！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dsSend.Tables[0].ImportRow(dsHeatData.Tables[0].Rows[iRowIndex]);
            Frm.ShowDialogEx(Adapter.Session, dsSend, strUnitID);
            dsHeatData.LoadData();
        }

        private void dvHeatData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adapter.set_URIParameters("CCMID", cmbCasterID.Text);
            dsHeatData.LoadData();
            strUnitID = cmbCasterID.Text;
        }

        //甩废实绩查询
        private void btnScrapQuery_Click(object sender, EventArgs e)
        {
            CCMMarkScrapQueryFrm Frm = new CCMMarkScrapQueryFrm();
            Frm.ShowDialogEx(Adapter.Session);
        }
        /// <summary>
        /// 重新做甩废
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ccmReScrapFrm Frm = new ccmReScrapFrm();
            Frm.ShowDialogEx(Adapter.Session);
        }
    }
}