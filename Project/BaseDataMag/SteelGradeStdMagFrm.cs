//Add by hyh 2012-03-29
//�������ֱ�׼ά������
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace BaseDataMag
{
    public partial class SteelGradeStdMagFrm : DockContent, IMESForm
    {
        public SteelGradeStdMagFrm()
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

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow drSteelGradeStd = dsSteelGradeStd.Tables[0].NewRow();
            dsSteelGradeStd.Tables[0].Rows.Add(drSteelGradeStd);
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsSteelGradeStd.Position >= 0)
                bsSteelGradeStd.RemoveCurrent();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvSteelGradeStd.EndEdit();
            bsSteelGradeStd.EndEdit();
            if (dsSteelGradeStd.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsSteelGradeStd.LoadData();
                return;
            }
            MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsSteelGradeStd.LoadData();
        }

        //������EXCEL
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("���ֱ�׼ά��", dvSteelGradeStd);
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dvSteelGradeStd_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvSteelGradeStd_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CommDataMag.CommonMethed.dataGridViewRowPostPaint(sender, e);
        }
    }
}