using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.EquipAdjust
{
    public partial class EquipAdjustMainFrm : Form
    {
        public EquipAdjustMainFrm()
        {
            InitializeComponent();
        }

        private DataSet dsData = new DataSet();
        public DialogResult ShowDialogEx(AppSvrIF.Session session, ref DataSet ds)
        {
            Adapter.Session = session;
            dsData = ds;
            if (dsData.Tables[0].Rows.Count == 0)
            {
                dsData.Tables[0].Rows.Add();
                dtCheck_Date.Value = DateTime.Now;

                dsData.Tables[0].Rows[0]["Operator"] = Adapter.Session.User;
            }

            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbLocation.Text == "")
            {
                MessageBox.Show("请选择处所!", "提示");
                return;
            }
            else if (cmbLocation_Des.Text == "")
            {
                MessageBox.Show("请选择处所描述!", "提示");
                return;
            }
            else
            {
                string strCondition = "";
                string strLocation = "";
                strLocation = cmbLocation.Text.ToString();
                strCondition = "Code_Des = '" + strLocation + "'";
                DataRow[] RowTotal = dsLocation.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    dsData.Tables[0].Rows[0]["Location"] = Row["Code"].ToString();
                }

                strLocation = cmbLocation_Des.Text.ToString();
                strCondition = "Code_Des = '" + strLocation + "'";
                RowTotal = dsLocation_Des.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    dsData.Tables[0].Rows[0]["Location_Des"] = Row["Code"].ToString();
                }

                dsData.Tables[0].Rows[0]["Meter"] = txtMeter.Text.ToString();
                dsData.Tables[0].Rows[0]["Meter_Size"] = txtMeter_Size.Text.ToString();
                dsData.Tables[0].Rows[0]["Range"] = txtRange.Text.ToString();
                dsData.Tables[0].Rows[0]["Precision"] = txtPrecision.Text.ToString();
                dsData.Tables[0].Rows[0]["Factory"] = txtFactory.Text.ToString();
                dsData.Tables[0].Rows[0]["Measure_ID"] = txtMeasure_ID.Text.ToString();
                dsData.Tables[0].Rows[0]["Standard_Equ"] = txtStandard_Equ.Text.ToString();
                dsData.Tables[0].Rows[0]["Scale_Min"] = txtScale_Min.Text.ToString();
                dsData.Tables[0].Rows[0]["Check_Date"] = dtCheck_Date.Value;
                dsData.Tables[0].Rows[0]["Result"] = rtxtResult.Text.ToString();
                dsData.Tables[0].Rows[0]["Status"] = "0";

                Close();
            }
        }

        private void FinLadleBuildShowFrm_Load(object sender, EventArgs e)
        {
            string strCondition = "";
            string strLocation = "";

            for (int i = 0; i < dsEquipAdjustSet.Tables[0].Rows.Count; i++)
            {
                strLocation = dsEquipAdjustSet.Tables[0].Rows[i]["Location"].ToString();
                strCondition = "Code = '" + strLocation + "'";
                DataRow[] RowTotal = dsLocation.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    if (!(cmbLocation.Items.Contains(Row["Code_Des"].ToString())))
                        cmbLocation.Items.Add(Row["Code_Des"].ToString());
                }
            }

            for (int i = 0; i < dsEquipAdjustSet.Tables[0].Rows.Count; i++)
            {
                strLocation = dsEquipAdjustSet.Tables[0].Rows[i]["Location_Des"].ToString();
                strCondition = "Code = '" + strLocation + "'";
                DataRow[] RowTotal = dsLocation_Des.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    if (!(cmbLocation_Des.Items.Contains(Row["Code_Des"].ToString())))
                        cmbLocation_Des.Items.Add(Row["Code_Des"].ToString());
                }
            }

            if (dsData.Tables[0].Rows[0]["Location"].ToString() != "")
            {
                strLocation = dsData.Tables[0].Rows[0]["Location"].ToString();
                strCondition = "Code = '" + strLocation + "'";
                DataRow[] dataRowTotal = dsLocation.Tables[0].Select(strCondition);
                foreach (DataRow Row in dataRowTotal)
                {
                    cmbLocation.Text = Row["Code_Des"].ToString();
                }

                strLocation = dsData.Tables[0].Rows[0]["Location_Des"].ToString();
                strCondition = "Code = '" + strLocation + "'";
                dataRowTotal = dsLocation_Des.Tables[0].Select(strCondition);
                foreach (DataRow Row in dataRowTotal)
                {
                    cmbLocation_Des.Text = Row["Code_Des"].ToString();
                }
            }
            else
                bsMain.Filter = "Location = ''";


            if (dsData.Tables[0].Rows[0]["Check_Date"].ToString() != "")
                dtCheck_Date.Text = dsData.Tables[0].Rows[0]["Check_Date"].ToString();
            else
                dtCheck_Date.Value = DateTime.Today;
            txtOperator.Text = dsData.Tables[0].Rows[0]["Operator"].ToString();
            rtxtResult.Text = dsData.Tables[0].Rows[0]["Result"].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsData.Clear();
            Close();
        }

        private void cmbLocation_Des_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCondition = "";
            string strLocation = "";
            string strLocation_Des = "";
            strCondition = "Code_Des = '" + cmbLocation_Des.Text.ToString() + "'";
            DataRow[] RowTotal = dsLocation_Des.Tables[0].Select(strCondition);
            foreach (DataRow Row in RowTotal)
            {
                strLocation_Des = Row["Code"].ToString();
            }

            if (cmbLocation.Text != "")
            {
                strCondition = "Code_Des = '" + cmbLocation.Text.ToString() + "'";
                RowTotal = dsLocation.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    strLocation = Row["Code"].ToString();
                }

                bsMain.Filter = "Location = '" + strLocation + "' and Location_Des = '" + strLocation_Des + "'";
            }
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCondition = "";
            string strLocation = "";
            string strLocation_Des = "";
            strCondition = "Code_Des = '" + cmbLocation.Text.ToString() + "'";
            DataRow[] RowTotal = dsLocation.Tables[0].Select(strCondition);
            foreach (DataRow Row in RowTotal)
            {
                strLocation = Row["Code"].ToString();
            }

            if (cmbLocation_Des.Text != "")
            {
                strCondition = "Code_Des = '" + cmbLocation_Des.Text.ToString() + "'";
                RowTotal = dsLocation_Des.Tables[0].Select(strCondition);
                foreach (DataRow Row in RowTotal)
                {
                    strLocation_Des = Row["Code"].ToString();
                }

                bsMain.Filter = "Location = '" + strLocation + "' and Location_Des = '" + strLocation_Des + "'";
            }
        }
    }
}