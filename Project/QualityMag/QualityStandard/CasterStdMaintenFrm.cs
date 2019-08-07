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
    public partial class CasterStdMaintenFrm : DockContent, IMESForm
    {
        public CasterStdMaintenFrm()
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

            bsSpeed.RemoveCurrent();
            bsSpeed.EndEdit();
            dsSpeed.UpdateData();

            bsTundish.RemoveCurrent();
            bsTundish.EndEdit();
            dsTundish.UpdateData();

            bsFlux.MoveFirst();
            for (int i = 0; i < dsFlux.Tables[0].Rows.Count; i++)
            {
                bsFlux.RemoveCurrent();
                bsFlux.MoveNext();
            }
            bsFlux.EndEdit();
            dsFlux.UpdateData();

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体时
        private void CasterStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void CasterStdMaintenFrm_Load(object sender, EventArgs e)
        {
            tscmbSteelGradeIndex.Items.Clear();
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i][0]);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (tscmbSteelGradeIndex.Text.Trim() != "")
            {
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + tscmbSteelGradeIndex.Text.Trim() + "'";
                if (dsSteelGrade.Tables[0].Rows.Count > 0 && dsSteelGrade != null)
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

            dsSpeed.SourceCondition = strSourceCondition;
            if (dsSpeed.Tables[0].Rows.Count < 1)
            {
                DataRow drSpeed = dsSpeed.Tables[0].NewRow();
                drSpeed["SteelGradeIndex"] = strSteelGradeIndex;
                dsSpeed.Tables[0].Rows.Add(drSpeed);
            }

            dsFlux.SourceCondition = strSourceCondition;
            //if (dsFlux.Tables[0].Rows.Count < 1)
            //{
            //    DataRow drFlux = dsFlux.Tables[0].NewRow();
            //    drFlux["SteelGradeIndex"] = strSteelGradeIndex;
            //    dsFlux.Tables[0].Rows.Add(drFlux);
            //}

            dsTundish.SourceCondition = strSourceCondition;
            if (dsTundish.Tables[0].Rows.Count < 1)
            {
                DataRow drTundish = dsTundish.Tables[0].NewRow();
                drTundish["SteelGradeIndex"] = strSteelGradeIndex;
                dsTundish.Tables[0].Rows.Add(drTundish);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            dsBase.UpdateData();

            bsProc.EndEdit();
            dsProc.UpdateData();

            dvFlux.EndEdit();
            bsFlux.EndEdit();
            dsFlux.UpdateData();

            bsSpeed.EndEdit();
            dsSpeed.UpdateData();

            bsTundish.EndEdit();
            dsTundish.UpdateData();

        }

        private void btnAddFlux_Click(object sender, EventArgs e)
        {
            DataRow drFlux = dsFlux.Tables[0].NewRow();
            drFlux["SteelGradeIndex"] = tscmbSteelGradeIndex.Text.Trim();
            dsFlux.Tables[0].Rows.Add(drFlux);
        }

        private void CasterStdMaintenFrm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Adapter.RefreshDataBindings();
        }

        private void btnDelFlux_Click(object sender, EventArgs e)
        {
            if (bsFlux.Position >= 0)
                bsFlux.RemoveCurrent();
        }
    }
}