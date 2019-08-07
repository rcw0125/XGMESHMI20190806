﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using Microsoft.Office.Interop.Excel;

namespace QualityMag.QualityJudge
{
    public partial class SteelWaterToBXGJudgeQueryFrm : DockContent, IMESForm
    {
        public SteelWaterToBXGJudgeQueryFrm()
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


        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strCondition = "select * from VIEW_BLOOM_FIANLJUDGE_DATA where ";
            if (cmbSteelGradeIndex.Text == "" && txtHeatID.Text == "")
                dsFinalJudge.SourceMethod = strCondition + " CASTERID='S66' order by FinalJudge_Time asc";
            if (cmbSteelGradeIndex.Text != "" && txtHeatID.Text == "")
                dsFinalJudge.SourceMethod = strCondition + " STEELGRADEINDEX='"+cmbSteelGradeIndex.Text+"' and  CASTERID='S66' order by FinalJudge_Time asc";
            if (cmbSteelGradeIndex.Text == "" && txtHeatID.Text != "")
                dsFinalJudge.SourceMethod = strCondition + " HEATID='"+txtHeatID.Text+"'and  CASTERID='S66' order by FinalJudge_Time asc";
            if (cmbSteelGradeIndex.Text != "" && txtHeatID.Text != "")
                dsFinalJudge.SourceMethod = strCondition + " STEELGRADEINDEX='" + cmbSteelGradeIndex.Text + "' and  HEATID='" + txtHeatID.Text + "' and  CASTERID='S66' order by FinalJudge_Time asc";
        }

        //控件加载
        private void InStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dsID.SourceMethod = "select * from VIEW_BLOOM_FIANLJUDGE_DATA where  CASTERID='S66' order by FinalJudge_Time asc ";
            for (int i = 0; i < dsID.Tables[0].Rows.Count; i++)
            {
                string dd=dsID.Tables[0].Rows[i]["STEELGRADEINDEX"].ToString();
                if (dd == "")
                    continue;
                cmbSteelGradeIndex.Items.Add(dd);
            }
        }



        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("转炉钢水直送不锈钢信息", dvFinalJudge);
        }

        private void dvFinalJudge_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void HeatFinalJudgeQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvFinalJudge.RowCount > 0)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    app.Visible = false;

                    string fileName = "D:\\Exl\\送钢卡片";


                    string strPlanSteelGrade = "";
                    string strFinalSteelGrade = "";
                    string strFinalProtocol = "";
                    string strUri = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\";

                    //计划牌号
                    string strPlanSteelGradeIndex = dvFinalJudge.CurrentRow.Cells["steelGradeIndexDataGridViewTextBoxColumn"].Value.ToString();//当前炼钢记号
                    string strPlanObjUri = strUri + strPlanSteelGradeIndex;
                    object ObjPlanSteelGrade = null;
                    Adapter.Session.Get(strPlanObjUri, "SteelGrade", ref ObjPlanSteelGrade);

                    if (ObjPlanSteelGrade != null)
                        strPlanSteelGrade = ObjPlanSteelGrade.ToString();

                    //终判牌号
                    string strFinalSteelGradeIndex = dvFinalJudge.CurrentRow.Cells["finalSteelGradeIndexDataGridViewTextBoxColumn"].Value.ToString();//终判炼钢记号
                    object ObjFinalSteelGrade = null;
                    string strFinalObjUri = strUri + strFinalSteelGradeIndex;
                    Adapter.Session.Get(strFinalObjUri, "SteelGrade", ref ObjFinalSteelGrade);

                    if (ObjFinalSteelGrade != null)
                        strFinalSteelGrade = ObjFinalSteelGrade.ToString();

                    //技术条件
                    object ObjFinalProtocol = null;
                    Adapter.Session.Get(strFinalObjUri, "Protocol", ref ObjFinalProtocol);

                    if (ObjFinalProtocol != null)
                        strFinalProtocol = ObjFinalProtocol.ToString();

                    app.Workbooks.Add(fileName);
                    app.Cells[3, 2] = dvFinalJudge.CurrentRow.Cells["HeatID"].Value.ToString();
                    app.Cells[3, 5] = dvFinalJudge.CurrentRow.Cells["casterIDDataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    app.Cells[3, 8] = strPlanSteelGrade;
                    app.Cells[3, 12] = Convert.ToDateTime(dvFinalJudge.CurrentRow.Cells["finalJudgeTimeDataGridViewTextBoxColumn"].Value).ToString("yyyy-MM-dd").ToString();
                    app.Cells[3, 15] = dvFinalJudge.CurrentRow.Cells["teamDataGridViewTextBoxColumn"].EditedFormattedValue.ToString();

                    dsProduct.SourceCondition = "SteelGradeIndex = '" + strFinalSteelGradeIndex + "'";

                    if (dsProduct.Tables[0].Rows[0]["C_Max"].ToString() != "")
                        app.Cells[5, 1] = dvFinalJudge.CurrentRow.Cells["C"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["S_Max"].ToString() != "")
                        app.Cells[5, 2] = dvFinalJudge.CurrentRow.Cells["S"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Si_Max"].ToString() != "")
                        app.Cells[5, 3] = dvFinalJudge.CurrentRow.Cells["Si"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Mn_Max"].ToString() != "")
                        app.Cells[5, 4] = dvFinalJudge.CurrentRow.Cells["Mn"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["P_Max"].ToString() != "")
                        app.Cells[5, 5] = dvFinalJudge.CurrentRow.Cells["P"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Al_Max"].ToString() != "")
                        app.Cells[5, 6] = dvFinalJudge.CurrentRow.Cells["Al"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Cr_Max"].ToString() != "")
                        app.Cells[5, 7] = dvFinalJudge.CurrentRow.Cells["Cr"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Ni_Max"].ToString() != "")
                        app.Cells[5, 8] = dvFinalJudge.CurrentRow.Cells["Ni"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Cu_Max"].ToString() != "")
                        app.Cells[5, 9] = dvFinalJudge.CurrentRow.Cells["Cu"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Ti_Max"].ToString() != "")
                        app.Cells[5, 10] = dvFinalJudge.CurrentRow.Cells["Ti"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Mo_Max"].ToString() != "")
                        app.Cells[5, 11] = dvFinalJudge.CurrentRow.Cells["Mo"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["V_Max"].ToString() != "")
                        app.Cells[5, 12] = dvFinalJudge.CurrentRow.Cells["V"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["B_Max"].ToString() != "")
                        app.Cells[5, 13] = dvFinalJudge.CurrentRow.Cells["B"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Ca_Max"].ToString() != "")
                        app.Cells[5, 14] = dvFinalJudge.CurrentRow.Cells["Ca"].Value.ToString();
                    if (dsProduct.Tables[0].Rows[0]["Ceq_Max"].ToString() != "")
                        app.Cells[5, 15] = dvFinalJudge.CurrentRow.Cells["Ceq"].Value.ToString();

                    app.Cells[6, 2] = strFinalSteelGrade;
                    app.Cells[6, 7] = dvFinalJudge.CurrentRow.Cells["operatorDataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    app.Cells[6, 13] = strFinalProtocol;

                    app.Cells[8, 2] = dvFinalJudge.CurrentRow.Cells["bloomCountDataGridViewTextBoxColumn"].Value.ToString();
                    app.Cells[8, 4] = dvFinalJudge.CurrentRow.Cells["rightCountDataGridViewTextBoxColumn"].Value.ToString();

                    app.Cells[8, 7] = dvFinalJudge.CurrentRow.Cells["wrongCount1DataGridViewTextBoxColumn"].Value.ToString();
                    app.Cells[8, 10] = dvFinalJudge.CurrentRow.Cells["wrongCount2DataGridViewTextBoxColumn"].Value.ToString();
                    app.Cells[8, 13] = dvFinalJudge.CurrentRow.Cells["wrongCount3DataGridViewTextBoxColumn"].Value.ToString();
                    app.Cells[9, 7] = dvFinalJudge.CurrentRow.Cells["wrongReason1DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    app.Cells[9, 10] = dvFinalJudge.CurrentRow.Cells["wrongReason2DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();
                    app.Cells[9, 13] = dvFinalJudge.CurrentRow.Cells["wrongReason3DataGridViewTextBoxColumn"].EditedFormattedValue.ToString();


                    string strLength = dvFinalJudge.CurrentRow.Cells["lengthDataGridViewTextBoxColumn"].Value.ToString();
                    string strWidth = dvFinalJudge.CurrentRow.Cells["widthDataGridViewTextBoxColumn"].Value.ToString();
                    string strThickNess = dvFinalJudge.CurrentRow.Cells["thicknessDataGridViewTextBoxColumn"].Value.ToString();
                    app.Cells[10, 3] = strLength + " mm* " + strWidth + " mm* " + strThickNess + " mm";

                    app.Visible = true;
                }
                else
                {
                    MessageBox.Show("没有数据导出!");
                }
            }
            catch { }
        }

        //描绘行
        private void dvFinalJudge_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }


    }
}