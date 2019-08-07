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
    public partial class ProcTimeStdMaintenFrm : DockContent, IMESForm
    {
        public ProcTimeStdMaintenFrm()
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
            DataRow newrow = dsProcTime.Tables[0].NewRow();
            newrow ["SteelGradeIndex"] = cmbSteelGradeIndex.Text.ToString();
            dsProcTime.Tables[0].Rows.Add(newrow);
        }

        //删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            dvProcTime.EndEdit();
            bsProcTime.EndEdit();
            for ( int i = 0 ; i < dsProcTime.Tables[0].Rows.Count ;i++ )
            {
                if (dvProcTime.Rows[i].Cells[0].Value.ToString() == "1")
                {
                    bsProcTime.RemoveAt( i );
                    dsProcTime.UpdateData();
                }
            }
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvProcTime.EndEdit();
            bsProcTime.EndEdit();
            dsProcTime.UpdateData();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsProcTime.LoadData();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void ProcTimeStdMaintenFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void ProcTimeStdMaintenFrm_Load ( object sender , EventArgs e )
        {
            for ( int i = 0 ; i < dsSteelGradeIndex.Tables [0].Rows.Count ;i++ )
            {
                cmbSteelGradeIndex.Items.Add( dsSteelGradeIndex.Tables [0].Rows [i] ["SteelGradeIndex"].ToString() );
            }
        }

        //查询
        private void btnQuery_Click ( object sender , EventArgs e )
        {
            if (cmbSteelGradeIndex.Text.Trim() == "")
                dsProcTime.SourceCondition = "";
            else
            {
                dsProcTime.SourceCondition = "SteelGradeIndex like '%" + cmbSteelGradeIndex.Text.Trim() + "%'";
                dsSteelGrade.SourceCondition = "SteelGradeIndex = '" + cmbSteelGradeIndex.Text.Trim() + "'";
                txtSteelGrade.Text = dsSteelGrade.Tables[0].Rows[0]["SteelGrade"].ToString();
            }
        }

        private void dvProcTime_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}