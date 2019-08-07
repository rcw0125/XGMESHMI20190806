using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;


namespace StoreMag.AlloyStore
{
    /****************Modify Begin At 2011-02-16 �� By Huyunhai       (������� �������Ͻ��ϲ�����ά��Ϣ����ѯ��)******************/

    public partial class AlloyStoreMagQuery : DockContent, IMESForm
    {
        public AlloyStoreMagQuery()
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


        private void AlloyStoreMagQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory(); //�ͷ��ڴ�
        }

        // ������EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (dvStore.Visible == true)
            {
                CommDataMag.CommonMethed.PutIntoExcel("�Ͻ��ϲ�����ά����Ϣ��ѯ", dvStore);
            }
            if (dvMatStoreEmpt.Visible == true)
            {
                CommDataMag.CommonMethed.PutIntoExcel("�ϲ�������Ϣ��ѯ", dvMatStoreEmpt);
            }

        }

        private void AlloyStoreMagQuery_Load(object sender, EventArgs e)
        {
            // string d = comboBox1.DisplayMember;
            //����ComboBox
            //if (dsMaterial != null && dsMaterial.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataRow dr in dsMaterial.Tables[0].Rows)
            //    {
            //        cmbMaterial.Items.Add(dr["StoreID"]);
            //    }
            //}
          // select a.ALLOY_CODE from CALLOY_DATA a,CALLOY_PROPCHANGE_LOG b 
            //dsTempt = CommDataMag.CommonMethed.GetdsStandard(Adapter, "");

        }



        private void toolStripToriDateTimePicker1_TextChanged(object sender, EventArgs e)
        {
            if (dvStore.Visible == true&&tsCmbType.Text=="����ά��")
            {
                dvMatStoreEmpt.Visible = false;
                dvStore.Visible = true;
                dvStore.Dock = DockStyle.Fill;
                if (toolStripToriDateTimePicker1.Text == "")
                {
                    dsAlloyMainInfoQuery.SourceCondition = "1=2";
                }
                else if (toolStripToriDateTimePicker1.Text.Equals("ȫ��"))
                {
                    dsAlloyMainInfoQuery.SourceCondition = "";
                }
                else
                    dsAlloyMainInfoQuery.SourceCondition = " OperatorTime>='" + toolStripToriDateTimePicker1.Text.ToString() + " 00:00:00'" + " and OperatorTime<='" + toolStripToriDateTimePicker1.Text.ToString() + " 23:59:59' ";
            }

            if (dvMatStoreEmpt.Visible == true&&tsCmbType.Text=="�ϲ�����")
            {
                dvMatStoreEmpt.Visible = true;
                dvStore.Visible = false;
                dvMatStoreEmpt.Dock = DockStyle.Fill;
                if (toolStripToriDateTimePicker1.Text == "")
                {
                    dsMatStoreEmpt.SourceCondition = "1=2";
                }
                else if (toolStripToriDateTimePicker1.Text.Equals("ȫ��"))
                {
                    dsMatStoreEmpt.SourceCondition = "";
                }
                else
                    dsMatStoreEmpt.SourceCondition = " LogDate>='" + toolStripToriDateTimePicker1.Text.ToString() + " 00:00'" + " and LogDate<='" + toolStripToriDateTimePicker1.Text.ToString() + " 23:59' ";

            }

        }

        /// <summary>
        /// ѡ���ѯ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsCmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tsCmbType.Text == "")
            {
                bdN1.BindingSource = null;
                dvStore.Visible = false;
                dvMatStoreEmpt.Visible = false;
            }
            else if (tsCmbType.Text == "�ϲ�����")
            {
                bdN1.BindingSource = bsMatSotreEmpt;
                dvMatStoreEmpt.Visible = true;
                dvStore.Visible = false;
                dvMatStoreEmpt.Dock = DockStyle.Fill;
            }
            else if (tsCmbType.Text == "����ά��")
            {
                bdN1.BindingSource = bsAlloyMainInfoQuery;
                dvStore.Visible = true;
                dvMatStoreEmpt.Visible = false;
                dvStore.Dock = DockStyle.Fill;
            }
        }

        private void dvMatStoreEmpt_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }






    }
    /*******END*******/
}
