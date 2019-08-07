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
    public partial class ProduceSheetMaintenShowFrm : Form
    {
        public ProduceSheetMaintenShowFrm()
        {
            InitializeComponent();
        }

        public string strSteelGradeIndex = "";

        public DialogResult ShowDialogEx(int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            bsDesStdMainten.DataSource = null;
            bsDesStdMainten.DataSource = dsData;
            bsDesStdMainten.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsDesStdMainten.Current)).DataView.Sort = strSort;
            bsDesStdMainten.Position = nPosition;

            return ShowDialog();
        }

        private  AppSvrHMI.L3DataSet dsReturn = new AppSvrHMI.L3DataSet();
        public AppSvrHMI.L3DataSet ShowDialogExL(AppSvrHMI.L3Adapter adapter, int nPosition, string strSort, AppSvrHMI.L3DataSet dsData)
        {
            Adapter = adapter;
            txtCopy.Text = "";
            dsReturn = dsData;

            bsDesStdMainten.DataSource = null;
            bsDesStdMainten.DataSource = dsReturn;
            bsDesStdMainten.DataMember = dsReturn.Tables[0].TableName;

            ((System.Data.DataRowView)(bsDesStdMainten.Current)).DataView.Sort = strSort;
            bsDesStdMainten.Position = nPosition;
            strSteelGradeIndex = dsData.Tables[0].Rows[nPosition]["SteelGradeIndex"].ToString();

            ShowDialog();

            return dsReturn;
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsDesStdMainten.EndEdit();
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsDesStdMainten.CancelEdit();
            this.Close();
        }

        private void ProduceSheetMaintenShowFrm_Load(object sender, EventArgs e)
        {
            if (strSteelGradeIndex.Length == 8)
            {
                object objSteelGrade = null;
                Adapter.Session.Get(@"XGMESLogic\QualityMag\CQA_SteelGradeIndex_R\" + strSteelGradeIndex + "", "SteelGrade", ref objSteelGrade);
                if (objSteelGrade != null)
                    txtSteelGrade.Text = objSteelGrade.ToString();
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            //btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1, 0);
        }

        //复制
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtCopy.Text.Trim() == "" || txtCopy.Text.Trim().Length != 8)
                return;

            if (MessageBox.Show("确认替换现有的数据？", "提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question).ToString() == "Yes")
            {
                dsCopy.SourceCondition = "SteelGradeIndex = '" + txtCopy.Text.Trim() + "'";
                dsCopy.L3DataAdapter = Adapter;
                dsCopy.L3DataAdapter = null;

                if (dsCopy.Tables[0].Rows.Count == 1)
                {
                    foreach (System.Data.DataColumn col in this.schemadsCopy.Columns)
                    {
                        dsReturn.Tables[0].Rows[bsDesStdMainten.Position][col.ColumnName] = dsCopy.Tables[0].Rows[0][col.ColumnName].ToString();
                    }
                }
            }



        }

    }
}