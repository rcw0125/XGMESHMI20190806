using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.DeSMag
{
    public partial class AdditionMagFrm : DockContent, IMESForm
    {
        public AdditionMagFrm()
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

        private object objShiftID = "";
        private object objTeamID = "";

        //确定
        private void tsbtnConfirm_Click(object sender, EventArgs e)
        {
            dvAddition.EndEdit();
            bsAddition.EndEdit();
            if(dsAddition.UpdateData())
                MessageBox.Show("修改成功！", "提示");
            else
                MessageBox.Show("修改失败！", "提示");
            dsAddition.LoadData();
        }

        //取消
        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            dsAddition.RejectChanges();
        }

        //退出
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string UnitID = "";
            string Weight = "";
            AdditionShowFrm frm = new AdditionShowFrm();
            dsAdditionSend.Clear();
            dsAdditionSend.Tables[0].Rows.Add(dsAdditionSend.Tables[0].NewRow());
            frm.ShowDialogEx(Adapter.Session);
            dsAddition.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            dsAddition.SourceCondition = "Time_Discharge between '" + dtS + "' and '" + dtE + "' order by Time_Discharge";
        }

        private void AdditionMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnIntoEXL_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("加料信息", dvAddition);
        }
    }
}