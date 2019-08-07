using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityStandard
{
    public partial class LFStdMaintenFrm : DockContent, IMESForm
    {
        public LFStdMaintenFrm()
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

        //新增
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            string strMesg = MessageBox.Show("确认删除有关炼钢记号为" + tscmbSteelGradeIndex.Text.Trim() + "的所有标准信息", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (strMesg != "OK")
                return;

            bsBase.RemoveCurrent();
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsProc.RemoveCurrent();
            bsProc.EndEdit();
            dsProc.UpdateData();

            bsAlloy.MoveFirst();
            for (int i = 0; i < dsAlloy.Tables[0].Rows.Count; i++)
            {
                bsAlloy.RemoveCurrent();
                bsAlloy.MoveNext();
            }
            bsAlloy.EndEdit();
            dsAlloy.UpdateData();

            bsLadle.MoveFirst();
            for (int i = 0; i < dsLadle.Tables[0].Rows.Count; i++)
            {
                bsLadle.RemoveCurrent();
                bsLadle.MoveNext();
            }
            bsLadle.EndEdit();
            dsLadle.UpdateData();

            bsFeed.MoveFirst();
            for (int i = 0; i < dsFeed.Tables[0].Rows.Count; i++)
            {
                bsFeed.RemoveCurrent();
                bsFeed.MoveNext();
            }
            bsFeed.EndEdit();
            dsFeed.UpdateData();

            bsLadle.MoveFirst();
            for (int i = 0; i < dsLadle.Tables[0].Rows.Count; i++)
            {
                bsLadle.RemoveCurrent();
                bsLadle.MoveNext();
            }
            bsLadle.EndEdit();
            dsLadle.UpdateData();

            bsSlagEle.RemoveCurrent();
            bsSlagEle.EndEdit();
            dsSlagEle.UpdateData();

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体时
        private void LFStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tscmbSteelGradeIndex.Text.Trim() != "")
            {
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + tscmbSteelGradeIndex.Text.Trim() + "'";
                txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
            }
            string strSourceCondition = "SteelGradeIndex = '" + tscmbSteelGradeIndex.Text.Trim() + "'";
            string strSteelGradeIndex = tscmbSteelGradeIndex.Text.Trim();
           
            dsBase.SourceCondition = strSourceCondition;

            if (dsBase.Tables[0].Rows.Count < 1)
            {
                DataRow drBase = dsBase.Tables[0].NewRow();
                drBase["SteelGradeIndex"] = strSteelGradeIndex;
                dsBase.Tables[0].Rows.Add(drBase);
            }

            dsProc.SourceCondition = strSourceCondition;
            if (dsProc.Tables[0].Rows.Count < 1)
            {
                DataRow drProc = dsProc.Tables[0].NewRow();
                drProc["SteelGradeIndex"] = strSteelGradeIndex;
                dsProc.Tables[0].Rows.Add(drProc);
            }

            dsAlloy.SourceCondition = strSourceCondition;
            //if (dsAlloy.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drAlloy = dsAlloy.Tables[0].NewRow();
            //    drAlloy["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsAlloy.Tables[0].Rows.Add(drAlloy);
            //}

            dsSlag.SourceCondition = strSourceCondition;
            //if (dsSlag.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drSlag = dsSlag.Tables[0].NewRow();
            //    drSlag["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsSlag.Tables[0].Rows.Add(drSlag);
            //}

            dsFeed.SourceCondition = strSourceCondition;
            //if (dsFeed.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drFeed = dsFeed.Tables[0].NewRow();
            //    drFeed["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsFeed.Tables[0].Rows.Add(drFeed);
            //}

            dsLadle.SourceCondition = strSourceCondition;
            //if (dsLadle.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drLadle = dsLadle.Tables[0].NewRow();
            //    drLadle["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsLadle.Tables[0].Rows.Add(drLadle);
            //}

            dsSlagEle.SourceCondition = strSourceCondition;
            if (dsSlagEle.Tables[0].Rows.Count < 1)
            {
                DataRow drSlagEle = dsSlagEle.Tables[0].NewRow();
                drSlagEle["SteelGradeIndex"] = strSteelGradeIndex;
                dsSlagEle.Tables[0].Rows.Add(drSlagEle);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsProc.EndEdit();
            dsProc.UpdateData();

            dvAlloy.EndEdit();
            bsAlloy.EndEdit();
            dsAlloy.UpdateData();

            dvFeed.EndEdit();
            bsFeed.EndEdit();
            dsFeed.UpdateData();

            dvLadle.EndEdit();
            bsLadle.EndEdit();
            dsLadle.UpdateData();

            dvSlag.EndEdit();
            bsSlag.EndEdit();
            dsSlag.UpdateData();


            bsSlagEle.EndEdit();
            dsSlagEle.UpdateData();
        }

        private void LFStdMaintenFrm_Load(object sender, EventArgs e)
        {
            tscmbSteelGradeIndex.Items.Clear();
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i][0]);
            }
        }

        private void btnAddAlloy_Click(object sender, EventArgs e)
        {
            DataRow drAlloy = dsAlloy.Tables[0].NewRow();
            drAlloy["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsAlloy.Tables[0].Rows.Add(drAlloy);
        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            DataRow drFeed = dsFeed.Tables[0].NewRow();
            drFeed["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsFeed.Tables[0].Rows.Add(drFeed);
        }

        private void btnAddSlag_Click(object sender, EventArgs e)
        {
            DataRow drSlag = dsSlag.Tables[0].NewRow();
            drSlag["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsSlag.Tables[0].Rows.Add(drSlag);
        }

        private void btnAddLadle_Click(object sender, EventArgs e)
        {
            DataRow drLadle = dsLadle.Tables[0].NewRow();
            drLadle["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsLadle.Tables[0].Rows.Add(drLadle);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Adapter.RefreshDataBindings();
        }

        private void btnDelAlloy_Click(object sender, EventArgs e)
        {
            if (bsAlloy.Position >= 0)
                bsAlloy.RemoveCurrent();
        }

        private void btnDelFeed_Click(object sender, EventArgs e)
        {
            if (bsFeed.Position >= 0)
                bsFeed.RemoveCurrent();
        }

        private void btnDelSlag_Click(object sender, EventArgs e)
        {
            if (bsSlag.Position >= 0)
                bsSlag.RemoveCurrent();
        }

        private void btnDelLadle_Click(object sender, EventArgs e)
        {
            if (bsLadle.Position >= 0)
                bsLadle.RemoveCurrent();
        }
    }
}