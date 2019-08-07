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
    public partial class CostMediumMagFrm : DockContent, IMESForm
    {
        public CostMediumMagFrm()
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

        /*
         * 2009-08-07 �����������Ĵ��� sun
         */ 
        private void CostMediumMagFrm_Load(object sender, EventArgs e)
        {
            //dsCostMedium.SourceMethod = "";
            //string strCodeSQL = "";
            //strCodeSQL += "     SELECT *                                    ";
            //strCodeSQL += "       FROM CCost_Medium_Consume_Std             ";
            //strCodeSQL += "   order by Medium,Cost_Center                   ";

            //dsCostMedium.SourceMethod = strCodeSQL;
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsCostMedium.Tables[0].NewRow();
            dsCostMedium.Tables[0].Rows.Add(newrow);
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCostMedium.Position >= 0)
                bsCostMedium.RemoveCurrent();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCostMedium.EndEdit();
            bsCostMedium.EndEdit();
            if (dsCostMedium.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsCostMedium.LoadData();
                return;
            }
            MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsCostMedium.LoadData();
        }

        //��ӡ
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�������Ķ�����Ϣ", dvCostMedium);
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //�ݴ�
        private void dvMatPrice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //�رմ���ʱ�ͷ�
        private void CostMediumMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}