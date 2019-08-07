using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.TAPMag
{
    public partial class TapHeatInfoFrm : Form
    {
        public TapHeatInfoFrm()
        {
            InitializeComponent();
        }

        private bool IsModify;
        private string strCurHeatID = "";
        private bool bOperation = false;

        public DialogResult ShowDialogEx(AppSvrIF.Session session, bool bFlag, string strHeatID)
        {
            txtHeatID.Text = strHeatID;
            strCurHeatID = strHeatID;
            IsModify = bFlag;

            dsBase.SourceCondition = " HeatID = '" + strHeatID + "'";
            dsMat.SourceCondition = " HeatID = '" + strHeatID + "' order by Discharge_Time desc";
            dsProcess.SourceCondition = " HeatID = '" + strHeatID + "'";
            dsTemp.SourceCondition = " HeatID = '" + strHeatID + "' order by MeasureTime desc";
            dsOxygen.SourceCondition = " HeatID = '" + strHeatID + "' order by MeasureTime desc";

            Adapter.Session = session;
            return ShowDialog();
        }

        //加载
        private void TapHeatInfoFrm_Load(object sender, EventArgs e)
        {
            pnlBase.Visible = IsModify;
            pnlMat.Visible = IsModify;
            pnlProcess.Visible = IsModify;
            pnlTemp.Visible = IsModify;
            pnlOxygen.Visible = IsModify;

            btnAddMat.Visible = IsModify;
            btnAddOxygen.Visible = IsModify;
            btnTempAdd.Visible = IsModify;
            
            if (IsModify)
            {
                if (dsProcess.Tables[0].Rows.Count < 1)
                {
                    DataRow newrow = dsProcess.Tables[0].NewRow();
                    dsProcess.Tables[0].Rows.Add(newrow);
                }
            }

            foreach (Control c in tabBase.Controls)
            {
                if (c is PxDataValid.PxTextBox||c is PxDataValid.PxComboBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChangedBase);
                }
            }
            foreach (Control c in tabProcess.Controls)
            {
                if (c is PxDataValid.PxTextBox )
                {
                    c.TextChanged += new EventHandler(pxControls_TextChangedProcess);
                }
            }
        }

        //基本数据
        private void btnBaseConfirm_Click(object sender, EventArgs e)
        {
            bsBase.EndEdit();
            bOperation = dsBase.UpdateData();
            MessageShowOperation();
        }

        private void btnBaseCancel_Click(object sender, EventArgs e)
        {
            dsBase.LoadData();
        }
        //加料数据
        private void btnAddMat_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsMat.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["Discharge_Time"] = System.DateTime.Now;
            dsMat.Tables[0].Rows.Add(newrow);
        }

        private void btnMatOK_Click(object sender, EventArgs e)
        {
            dvMat.EndEdit();
            bsMat.EndEdit();
            bOperation = dsMat.UpdateData();
            MessageShowOperation();
        }

        private void btnMatCancel_Click(object sender, EventArgs e)
        {
            dsMat.LoadData();
        }

        //冶炼数据
        private void btnProcessOK_Click(object sender, EventArgs e)
        {
            bsProcess.EndEdit();
            bOperation = dsProcess.UpdateData();
            MessageShowOperation();
        }

        private void btnProcessCancel_Click(object sender, EventArgs e)
        {
            dsProcess.LoadData();
            if (dsProcess.Tables[0].Rows.Count < 1)
            {
                DataRow newrow = dsProcess.Tables[0].NewRow();
                dsProcess.Tables[0].Rows.Add(newrow);
            }
        }

        //测温数据
        private void btnTempAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsTemp.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["MeasureTime"] = System.DateTime.Now;
            dsTemp.Tables[0].Rows.Add(newrow);
        }

        private void btnTempOK_Click(object sender, EventArgs e)
        {
            bsTemp.EndEdit();
            bOperation = dsTemp.UpdateData();
            MessageShowOperation();
        }

        private void btnTempCancel_Click(object sender, EventArgs e)
        {
            dsTemp.LoadData();
        }

        //定氧数据
        private void btnOxygenAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsOxygen.Tables[0].NewRow();
            newrow["HeatID"] = strCurHeatID;
            newrow["MeasureTime"] = System.DateTime.Now;
            dsOxygen.Tables[0].Rows.Add(newrow);
        }

        private void btnOxygenOK_Click(object sender, EventArgs e)
        {
            dvOxygen.EndEdit();
            bsOxygen.EndEdit();
            bOperation = dsOxygen.UpdateData();
            MessageShowOperation();
        }

        private void btnOxygenCancel_Click(object sender, EventArgs e)
        {
            dsOxygen.LoadData();
        }

        private void MessageShowOperation()
        {
            if (bOperation)
            {
                MessageBox.Show("保存成功！", "提示");
            }
            else
            {
                MessageBox.Show("保存失败！", "警告");
            }
        }
        private void pxControls_TextChangedBase(object sender, EventArgs e)
        {
            btnBaseConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
        private void pxControls_TextChangedProcess(object sender, EventArgs e)
        {
            btnProcessOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void dvMat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}