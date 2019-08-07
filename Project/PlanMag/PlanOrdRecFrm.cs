using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace PlanMag
{
    public partial class PlanOrdRecFrm : DockContent, IMESForm
    {
        public PlanOrdRecFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvPlanOrdRec.EndEdit();
            bsPlanOrdRec.EndEdit();
            string check = MessageBox.Show("要确认所选计划订单么？", "提示", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdPlanOrdRec.Execute();
                dsPlanOrdRec.LoadData();
                String returnFlag = cmdPlanOrdRec.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("确认成功！", "提示");
                }
                else
                {
                    MessageBox.Show("操作不成功！没有要确认的计划", "提示");
                }
            }
            else
            {
                dsPlanOrdRec.LoadData();
            }
            
            
        }

        private void PlanOrdRecFrm_Load(object sender, EventArgs e)
        {
        }

        private void PlanOrdRecFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}