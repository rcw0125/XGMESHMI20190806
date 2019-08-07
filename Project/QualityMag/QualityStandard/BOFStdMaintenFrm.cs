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
    public partial class BOFStdMaintenFrm : DockContent, IMESForm
    {
        public BOFStdMaintenFrm()
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

            bsAr.RemoveCurrent();
            bsAr.EndEdit();
            dsAr.UpdateData();

            bsBlow.RemoveCurrent();
            bsBlow.EndEdit();
            dsBlow.UpdateData();

            bsBlowO2.RemoveCurrent();
            bsBlowO2.EndEdit();
            dsBlowO2.UpdateData();

            bsBulk.MoveFirst();
            for (int i = 0; i < dsBulk.Tables[0].Rows.Count; i++)
            {
                bsBulk.RemoveCurrent();
                bsBulk.MoveNext();
            }
            bsBulk.EndEdit();
            dsBulk.UpdateData();

            bsFeed.MoveFirst();
            for (int i = 0; i < dsFeed.Tables[0].Rows.Count; i++)
            {
                bsFeed.RemoveCurrent();
                bsFeed.MoveNext();
            }
            bsFeed.EndEdit();
            dsFeed.UpdateData();

            bsInToConver.RemoveCurrent();
            bsInToConver.EndEdit();
            dsInToConver.UpdateData();

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

            bsTap.RemoveCurrent();
            bsTap.EndEdit();
            dsTap.UpdateData();

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体时
        private void BOFStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tscmbSteelGradeIndex.Text.Trim() != "")
            {
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + tscmbSteelGradeIndex.Text.Trim() + "'";
                if (dsSteelGrade.Tables[0].Rows.Count > 0)
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

            dsAr.SourceCondition = strSourceCondition;
            if (dsAr.Tables[0].Rows.Count < 1)
            {
                DataRow drAr = dsAr.Tables[0].NewRow();
                drAr["SteelGradeIndex"] = strSteelGradeIndex;
                dsAr.Tables[0].Rows.Add(drAr);
            }

            dsBlow.SourceCondition = strSourceCondition;
            if (dsBlow.Tables[0].Rows.Count < 1)
            {
                DataRow drBlow = dsBlow.Tables[0].NewRow();
                drBlow["SteelGradeIndex"] = strSteelGradeIndex;
                dsBlow.Tables[0].Rows.Add(drBlow);
            }

            dsBlowO2.SourceCondition = strSourceCondition;
            if (dsBlowO2.Tables[0].Rows.Count < 1)
            {
                DataRow drBlowO2 = dsBlowO2.Tables[0].NewRow();
                drBlowO2["SteelGradeIndex"] = strSteelGradeIndex;
                dsBlowO2.Tables[0].Rows.Add(drBlowO2);
            }

            dsBulk.SourceCondition = strSourceCondition;
            //if (dsBulk.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drBulk = dsBulk.Tables[0].NewRow();
            //    drBulk["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsBulk.Tables[0].Rows.Add(drBulk);
            //}

            dsFeed.SourceCondition = strSourceCondition;
            //if (dsFeed.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drFeed = dsFeed.Tables[0].NewRow();
            //    drFeed["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsFeed.Tables[0].Rows.Add(drFeed);
            //}

            dsInToConver.SourceCondition = strSourceCondition;
            if (dsInToConver.Tables[0].Rows.Count < 1)
            {
                DataRow drInToConver = dsInToConver.Tables[0].NewRow();
                drInToConver["SteelGradeIndex"] = strSteelGradeIndex;
                dsInToConver.Tables[0].Rows.Add(drInToConver);
            }

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

            dsTap.SourceCondition = strSourceCondition;
            if (dsTap.Tables[0].Rows.Count < 1)
            {
                DataRow drTap = dsTap.Tables[0].NewRow();
                drTap["SteelGradeIndex"] = strSteelGradeIndex;
                dsTap.Tables[0].Rows.Add(drTap);
            }


        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsAr.EndEdit();
            dsAr.UpdateData();

            bsBlow.EndEdit();
            dsBlow.UpdateData();

            bsBlowO2.EndEdit();
            dsBlowO2.UpdateData();

            dvBulk.EndEdit();
            bsBulk.EndEdit();
            dsBulk.UpdateData();

            dvFeed.EndEdit();
            bsFeed.EndEdit();
            dsFeed.UpdateData();

            bsInToConver.EndEdit();
            dsInToConver.UpdateData();

            dvLadle.EndEdit();
            bsLadle.EndEdit();
            dsLadle.UpdateData();

            bsSlagEle.EndEdit();
            dsSlagEle.UpdateData();

            bsTap.EndEdit();
            dsTap.UpdateData();

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BOFStdMaintenFrm_Load(object sender, EventArgs e)
        {
            tscmbSteelGradeIndex.Items.Clear();
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i][0]);
            }
            foreach (Control c in gbxTemp.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.Text = "";
                }
            }

        }

        private void cmbOxyFlag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOxyFlag.Text == "是")
                cmbOxyFlag.Tag = 1;
            else
                cmbOxyFlag.Tag = 0;
        }

        private void btnAddLadle_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsLadle.Tables[0].NewRow();
            newrow["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsLadle.Tables[0].Rows.Add(newrow);
        }

        private void btnAddBulk_Click(object sender, EventArgs e)
        {
            DataRow drBulk = dsBulk.Tables[0].NewRow();
            drBulk["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsBulk.Tables[0].Rows.Add(drBulk);
        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            DataRow drFeed = dsFeed.Tables[0].NewRow();
            drFeed["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsFeed.Tables[0].Rows.Add(drFeed);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Adapter.RefreshDataBindings();
        }

        private void dvBulk_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //if (dvBulk.Rows.Count < 0)
            //    btnDelBulk.Enabled = false;
            //else
            //    btnDelBulk.Enabled = true;

            //if (dvFeed.Rows.Count < 0) 
            //      btnDelFeed.Enabled = false;
            //else
            //    btnDelFeed.Enabled = true;

            //if (dvLadle.Rows.Count < 0)
            //    btnDelLadle.Enabled = false;
            //else
            //    btnDelLadle.Enabled = true;
        }

        private void btnDelBulk_Click(object sender, EventArgs e)
        {
            if (bsBulk.Position >= 0)
                bsBulk.RemoveCurrent();
        }

        private void btnDelFeed_Click(object sender, EventArgs e)
        {
            if (bsFeed.Position >= 0)
                bsFeed.RemoveCurrent();
        }

        private void btnDelLadle_Click(object sender, EventArgs e)
        {
            if (bsLadle.Position >= 0)
                bsLadle.RemoveCurrent();
        }

        private void txtBeArAim_TextChanged(object sender, EventArgs e)
        {

        }

    }
}