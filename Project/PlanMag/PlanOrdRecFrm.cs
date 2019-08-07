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

        #region IMESForm ��Ա

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

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvPlanOrdRec.EndEdit();
            bsPlanOrdRec.EndEdit();
            string check = MessageBox.Show("Ҫȷ����ѡ�ƻ�����ô��", "��ʾ", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdPlanOrdRec.Execute();
                dsPlanOrdRec.LoadData();
                String returnFlag = cmdPlanOrdRec.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("ȷ�ϳɹ���", "��ʾ");
                }
                else
                {
                    MessageBox.Show("�������ɹ���û��Ҫȷ�ϵļƻ�", "��ʾ");
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