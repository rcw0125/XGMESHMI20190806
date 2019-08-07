using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QualityMag.LabMag
{
    public partial class ChemicalInfoFrm : Form
    {
        public ChemicalInfoFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            bsChemical.DataSource = null;
            bsChemical.DataSource = dsData;
            bsChemical.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsChemical.Current)).DataView.Sort = strSort;
            bsChemical.Position = nPosition;

            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bsChemical.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsChemical.CancelEdit();
            this.Close();
        }

        private void ChemicalInfoFrm_Load(object sender, EventArgs e)
        {
            foreach (Control c in tpElement.Controls)
            {
                if (c is PxDataValid.PxTextBox || c is PxDataValid.PxComboBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }

            try
            {
                cmbAddr.SelectedIndex = 0;
              
            }
            catch { }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        //生成委托单
        private void btnFormAppID_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAddr.SelectedValue == null || cmbAddr.SelectedValue.ToString() == "" ||
                    txtHeatID.Text.Length != 9 || cmbSampleType.SelectedValue == null || cmbSampleType.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("请确认取样地点、炉号、取样类型输入是否正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmdNewLabSheet.Parameters[0].ConstantValue = cmbSampleType.SelectedValue.ToString();
                cmdNewLabSheet.Parameters[1].ConstantValue = cmbAddr.SelectedValue.ToString();
                cmdNewLabSheet.Parameters[2].ConstantValue = txtHeatID.Text.Trim();
                cmdNewLabSheet.Parameters[3].ConstantValue = "0";

                if (cmdNewLabSheet.Execute() >= 0)
                {
                    DataSet ds = (DataSet)cmdNewLabSheet.Command.Return;
                    if (ds == null && ds.Tables[0].Rows.Count < 1)
                    {
                        MessageBox.Show("生成委托单失败！", "提示");
                        return;
                    }
                    txtSampleCount.Text = ds.Tables[0].Rows[0]["Sample_Count"].ToString();
                    txtApplyID.Text = ds.Tables[0].Rows[0]["AppID"].ToString();
                    txtSampleCode.Text = ds.Tables[0].Rows[0]["Sample_Code"].ToString();
                }
            }
            catch { }
        }

        private void OnPreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Control ctrl = sender as Control;
            if (e.KeyCode == Keys.Return)
            {
                Control next = ctrl.Parent.GetNextControl(ctrl, true);
                if (next != null)
                {
                    while (!next.TabStop)
                    {
                        next = ctrl.Parent.GetNextControl(next, true);
                        if (next == null)
                            break;
                    }
                }
                if (next == null)
                {
                    next = ctrl.Parent;
                }
                next.Focus();
            }
        }
    }
}