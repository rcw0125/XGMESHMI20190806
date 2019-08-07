using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QualityMag.LabMag
{
    public partial class ApplyInfoFrm : Form
    {
        public ApplyInfoFrm()
        {
            InitializeComponent();
        }

        private string strCurSampleAddr = "";

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSampleAddr, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            dsSampleType.Tables[0].Rows.Clear();
            strCurSampleAddr = strSampleAddr;

            Adapter.Session = session;
            Adapter.RefreshDataBindings();
            ApplyInfoFrm_Load(strCurSampleAddr);

            bsSampleApply.DataSource = null;
            bsSampleApply.DataSource = dsData;
            bsSampleApply.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsSampleApply.Current)).DataView.Sort = strSort;
            bsSampleApply.Position = nPosition;

            return ShowDialog();
        }

        private void ApplyInfoFrm_Load(string strSampleAddr)
        {

            try
            {
                bool bGetHeatID = true;//是否获取炉号
                switch (strSampleAddr.Substring(0, 1))
                {
                    case CommDataMag.CommonData.BOF_SAMPLE_TYPE:
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and Code_Function_Group = 'Z'";
                        cbxFinProd.Visible = false;
                        break;
                    case "T":
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and Code_Function_Group = 'T'";
                        cbxFinProd.Visible = false;
                        break;
                    case "A":
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and Code_Function_Group = 'A'";
                        cbxFinProd.Visible = false;
                        break;

                    case "E":
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and (Code_Function_Group = 'E' or Code_Function_Group = 'FR')";
                        cbxFinProd.Visible = false;
                        break;
                    case CommDataMag.CommonData.LF_SAMPLE_TYPE:
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and (Code_Function_Group = 'F' or Code_Function_Group = 'FR')";
                        break;

                    case CommDataMag.CommonData.RH_SAMPLE_TYPE:
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and (Code_Function_Group = 'R' or Code_Function_Group = 'FR')";
                        break;

                    case CommDataMag.CommonData.CCM_SAMPLE_TYPE:
                        dsSampleType.SourceCondition = "Code_Group =  'QA_Sample_Type' and Code_Function_Group = 'C'";
                        break;
                }

                if (bGetHeatID)
                {
                    cmdHeatID.Parameters[0].ConstantValue = strSampleAddr;
                    dsHeatID.LoadData();
                    cmbHeatID.DataSource = dsHeatID;
                    cmbHeatID.DisplayMember = "L3DataTable.HeatID";
                    cmbHeatID.ValueMember = "L3DataTable.HeatID";
                }
            }
            catch
            {
                btnOK.Enabled = false;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsSampleApply.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsSampleApply.CancelEdit();
            this.Close();
        }

        private void cmbSampleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSampleType.SelectedValue != null && cmbSampleType.SelectedValue.ToString() != "")
                {
                    switch (cmbSampleType.SelectedValue.ToString())
                    {
                        //连铸中包样
                        case CommDataMag.CommonData.QA_Sample_Type_GL:
                            cbxFinProd.Checked = true;
                            break;
                        default:
                            if (cbxFinProd.Visible)
                                cbxFinProd.Checked = false;
                            break;
                    }
                }
            }
            catch { }
        }

        private void cmbSampleAddr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}