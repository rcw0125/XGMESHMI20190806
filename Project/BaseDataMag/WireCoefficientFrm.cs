using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Collections;

namespace BaseDataMag
{
    public partial class WireCoefficientFrm : DockContent, IMESForm
    {
        public WireCoefficientFrm()
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

        private void WireCoefficientFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsWireData.Tables[0].NewRow();
            newrow["WireCode"] = "";
            newrow["Coefficient"] = 0;
            dsWireData.Tables[0].Rows.Add(newrow);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsWireData.Position >= 0)
                bsWireData.RemoveCurrent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvWireData.EndEdit();
            bsWireData.EndEdit();
            if (dsWireData.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsWireData.LoadData();
                return;
            }
            MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsWireData.LoadData();
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("ι��������Ϣ", dvWireData);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvWireData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void WireCoefficientFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}