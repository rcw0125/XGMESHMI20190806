using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class WriteInTimeFrm : Form
    {
        public WriteInTimeFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;

            dsWriteTime.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsWriteTime.AcceptChanges();
            bsData.Position = 0;
            //bsData.DataSource = dsData;
            //bsData.DataMember = dsData.Tables[0].TableName;

            this.ShowDialog();
        }

        //返回
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //录入
        private void btnChange_Click(object sender, EventArgs e)
        {
            bsData.EndEdit();
            string check = MessageBox.Show("确认要录入么？", "提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdWriteTime.Execute();
                String returnFlag = cmdWriteTime.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("录入成功！", "提示");
                }
                else
                {
                    MessageBox.Show("录入不成功！", "提示");
                }
            }
            
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnChange.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void WriteInTimeFrm_Load(object sender, EventArgs e)
        {
            foreach (Control c in tpTime.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }
        }

        private void WriteInTimeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}