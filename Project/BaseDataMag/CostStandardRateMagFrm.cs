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
    public partial class SteelGradeStandardMagFrm : DockContent, IMESForm
    {
        public SteelGradeStandardMagFrm()
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
        private void CostStandardRateMagFrm_Load(object sender, EventArgs e)
        {
            //dsCostStandardRate.SourceMethod = "";
            //string strCodeSQL = "";
            //strCodeSQL += "     SELECT *                                    ";
            //strCodeSQL += "       FROM CCost_Standard_Rate                  ";
            //strCodeSQL += "   order by Cost_Item,Cost_Center                ";

            //dsCostStandardRate.SourceMethod = strCodeSQL;
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsCostStandardRate.Tables[0].NewRow();
            dsCostStandardRate.Tables[0].Rows.Add(newrow);
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsCostStandardRate.Position >= 0)
                bsCostStandardRate.RemoveCurrent();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvCostStandardRate.EndEdit();
            bsCostStandardRate.EndEdit();
            if (dsCostStandardRate.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsCostStandardRate.LoadData();
                return;
            }
            MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsCostStandardRate.LoadData();
        }

        //��ӡ
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("��׼������Ϣ", dvCostStandardRate);
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
        private void CostStandardRateMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}