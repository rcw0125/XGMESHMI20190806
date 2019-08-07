using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.CCMMag
{
    public partial class DutyMagFrm : DockContent, IMESForm
    {
        public DutyMagFrm()
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

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            Adapter.Session = session;

            return ShowDialog();
        }
        //  [12/27/2008 sun]
        

        //ȷ��
        private void tsbtnConfirm_Click(object sender, EventArgs e)
        {
            dvDuty.EndEdit();
            bsDuty.EndEdit();
            dsDuty.UpdateData();
        }

        //ȡ��
        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            dsDuty.LoadData();
        }

        //�˳�
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvDuty_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            dvDuty.Columns[0].DefaultCellStyle.BackColor = Color.Silver;
            dvDuty.Columns[1].DefaultCellStyle.BackColor = Color.Silver;
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsDuty.Tables[0].NewRow();
            dsDuty.Tables[0].Rows.Add(newrow);
        }
        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsDuty.Position >= 0)
            {
                bsDuty.RemoveCurrent();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsDuty.SourceCondition = "CCMID = '" + cmbCCMID.Text.Trim() + "'";
        }

    }
}