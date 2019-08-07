using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BulkStore
{
    public partial class BulkInStoreComfirmFrm : Form
    {
        public BulkInStoreComfirmFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            dsBulkInStoreConfirm.Tables[0].Clear();
            dsBulkInStoreConfirm.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            cmdCodeArea.Parameters[0].ConstantValue = dsData.Tables[0].Rows[0]["Bulk_CODE"].ToString();
            Adapter.Session = session;
            this.ShowDialog();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsBulkInStoreComfirmFrm.EndEdit();
            dsBulkInStoreConfirm.AcceptChanges();
            string check = MessageBox.Show("确认要上料么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBulkInStoreConfirm.Execute();
                String returnFlag = cmdBulkInStoreConfirm.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if (returnFlag == "0")
                {
                    MessageBox.Show("上料成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("上料不成功！" + strShow, "提示");
                }
            }
        }

        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bsBulkInStoreComfirmFrm_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlloyArea.Checked)
            {
                cmbArea.DataSource = null;
                cmbArea.DataSource = dsCodeArea;
                cmbArea.DisplayMember = "L3DataTable.CODE_DES";
                cmbArea.ValueMember = "L3DataTable.BULK_AREA";

            }
            else
            {
                cmbArea.DataSource = null;
                cmbArea.DataSource = dsGround;
                cmbArea.DisplayMember = "L3DataTable.Code_Des";
                cmbArea.ValueMember = "L3DataTable.Code";


            }
        }

        private void BulkInStoreComfirmFrm_Load(object sender, EventArgs e)
        {
            rbtn_CheckedChanged(sender, e);
            cmbArea.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            //cmbArea.SelectedIndex = 0;
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void BulkInStoreComfirmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}