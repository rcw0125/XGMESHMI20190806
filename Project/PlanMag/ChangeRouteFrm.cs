using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class ChangeRouteFrm : Form
    {
        public ChangeRouteFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsPlan.Tables[0].Clear();
            dsPlan.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            
            this.ShowDialog(); 
        }

        //����
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeRouteFrm_Load(object sender, EventArgs e)
        {
        //    foreach (Control c in tpRoute.Controls)
        //    {
        //        if (c is PxDataValid.PxComboBox)
        //        {
        //            c.TextChanged += new EventHandler(pxControls_TextChanged);
        //        }
        //    }
        }

        //����
        private void btnChange_Click(object sender, EventArgs e)
        {
            bsPlan.EndEdit();
            dsPlan.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ���Ĺ���·��ô��", "��ʾ", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdChangeRoute.Execute();
                String returnFlag = cmdChangeRoute.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                    this.Close();
                }
                else
                {
                    dsPlan.LoadData();
                    MessageBox.Show("���Ĺ���·�����ɹ���" + strReasultShow, "��ʾ");
                }
            }
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnChange.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ChangeRouteFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}