using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class MIFApplyInfoFrm : Form
    {
        public MIFApplyInfoFrm()
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
            MIFApplyInfoFrm_Load(strCurSampleAddr);

            bsSampleApply.DataSource = null;
            bsSampleApply.DataSource = dsData;
            bsSampleApply.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsSampleApply.Current)).DataView.Sort = strSort;
            bsSampleApply.Position = nPosition;

            return ShowDialog();
        }

        private void MIFApplyInfoFrm_Load(string strSampleAddr)
        {
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
                    string strOldSamplyAddress = cmbSampleAddr.Text.ToString();
                    switch (cmbSampleType.SelectedValue.ToString())
                    {
                        //抽查铁水样
                        case CommDataMag.CommonData.QA_Sample_Type_TC:
                            //string strOldSamplyAddress = cmbSampleAddr.Text.ToString();
                            cmbSampleAddr.Enabled = true;
                            cmbSampleAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                            cmbSampleAddr.Items.Clear();
                            cmbSampleAddr.Items.Add(CommDataMag.CommonData.QA_Sample_Addr_TB);
                            cmbSampleAddr.Items.Add(CommDataMag.CommonData.QA_Sample_Addr_TC);
                            if (strOldSamplyAddress == CommDataMag.CommonData.QA_Sample_Addr_TB ||
                                strOldSamplyAddress == CommDataMag.CommonData.QA_Sample_Addr_TC)
                            {
                                cmbSampleAddr.Text = strOldSamplyAddress;
                            }
                            break;
                        //混铁炉样
                        case CommDataMag.CommonData.QA_Sample_Type_TH: 
                            cmbSampleAddr.Enabled = false;
                            cmbSampleAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                            cmbSampleAddr.Items.Clear();
                            cmbSampleAddr.Text = strCurSampleAddr;
                            bsSampleApply.EndEdit();

                            cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                            cmbHeatID.DataSource = null;
                            cmbHeatID.Items.Clear();
                            ((System.Data.DataRowView)(bsSampleApply.Current)).Row["HeatID"] = "";
                            cmbHeatID.Enabled = false;
                            break;
                        //混铁炉全分析样
                        case CommDataMag.CommonData.QA_Sample_Type_TA:
                            cmbSampleAddr.Enabled = false;
                            cmbSampleAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                            cmbSampleAddr.Items.Clear();
                            cmbSampleAddr.Text = strCurSampleAddr;
                            bsSampleApply.EndEdit();

                            cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                            cmbHeatID.DataSource = null;
                            cmbHeatID.Items.Clear();
                            ((System.Data.DataRowView)(bsSampleApply.Current)).Row["HeatID"] = "";
                            cmbHeatID.Enabled = false;
                            break;
                        //转炉铁包铁水样
                        case CommDataMag.CommonData.QA_Sample_Type_TL:
                            //string strOldSamplyAddress = cmbSampleAddr.Text.ToString();
                            cmbSampleAddr.Enabled = false;
                            cmbSampleAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                            cmbSampleAddr.Items.Clear();
                            //cmbSampleAddr.Items.Add(CommDataMag.CommonData.QA_Sample_Addr_TB);
                            //cmbSampleAddr.Items.Add(CommDataMag.CommonData.QA_Sample_Addr_TC);
                            //if (strOldSamplyAddress == CommDataMag.CommonData.QA_Sample_Addr_TB ||
                            //    strOldSamplyAddress == CommDataMag.CommonData.QA_Sample_Addr_TC)
                            //{
                                cmbSampleAddr.Text = strOldSamplyAddress;
                                bsSampleApply.EndEdit();

                            //}
                                if (cmbSampleType.Text.ToString() == "转炉铁包样")
                            {
                                lbHeatName.Text = "铁包号:";
                                cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                                cmbHeatID.DataSource = dsIronLadleIDPre;
                                cmbHeatID.DisplayMember = "L3DataTable.MaterialID";
                                cmbHeatID.ValueMember = "L3DataTable.MaterialID";
                                cmbHeatID.Enabled = true;
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            catch { }
        }

        private void cmbSampleAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSampleAddr.Text.ToString() != "")
            {
                if (cmbSampleAddr.Text.ToString() == CommDataMag.CommonData.QA_Sample_Addr_TB)
                {
                    cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    cmbHeatID.DataSource = null;
                    cmbHeatID.DataSource = dsIronLadleID;
                    cmbHeatID.DisplayMember = "L3DataTable.IronLadleID";
                    cmbHeatID.ValueMember = "L3DataTable.IronLadleID";
                    cmbHeatID.Enabled = true;
                    lbHeatName.Text = "铁包号:";

                }
                else if (cmbSampleAddr.Text.ToString() == CommDataMag.CommonData.QA_Sample_Addr_TC)
                {
                    cmbHeatID.DataSource = null;
                    cmbHeatID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
                    cmbHeatID.Text = "";
                    cmbHeatID.Enabled = true;
                    lbHeatName.Text = "铁次号:";
                }
                else
                {
                    cmbHeatID.DataSource = null;
                    cmbHeatID.Items.Clear();
                    cmbHeatID.Text = "";
                    cmbHeatID.Enabled = false;
                }
            }
            else
            {
                cmbHeatID.DataSource = null;
                cmbHeatID.Items.Clear();
                cmbHeatID.Text = "";
                cmbHeatID.Enabled = false;
            }
        }

    }
}