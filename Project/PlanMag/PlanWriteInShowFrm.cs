using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlanMag
{
    public partial class PlanWriteInShowFrm : Form
    {
        public PlanWriteInShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(int nPosition,AppSvrHMI.L3DataSet dsData)
        {
            bsPlan.DataSource = dsData;
            bsPlan.DataMember = dsData.Tables[0].TableName;
            bsPlan.Position = nPosition;

            return ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            bsPlan.EndEdit(); 
            Close();
            
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanWriteInShowFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        
    }
}