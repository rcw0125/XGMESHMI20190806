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
using System.Data.OleDb;

namespace BaseDataMag
{
    public partial class UnitPriceMagFrm : DockContent, IMESForm
    {
        public UnitPriceMagFrm()
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

        private string strCon = "";
        private OleDbConnection myConn;
        private int iRowCount = 0;
        private int iColumnCount = 0;
        bool bAdded = false;

        private void UnitPriceMagFrm_Load(object sender, EventArgs e)
        {

            strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\\Exl\\�Ͻ�ƻ�����.xls;Extended Properties=\"Excel 8.0\"";
            myConn = new OleDbConnection(strCon);

            dsUnitCode.SourceMethod = "";
            string strCodeSQL = "";
            strCodeSQL += "     SELECT DISTINCT (code), code_des            ";
            strCodeSQL += "       FROM cbase_all_code                       ";
            strCodeSQL += "      WHERE (   code_group = 'ALLOY_CODE'        ";
            strCodeSQL += "             OR code_group = 'BULK_CODE'         ";
            strCodeSQL += "            )                                    ";
            strCodeSQL += "        AND code IS NOT NULL                     ";
            strCodeSQL += "   ORDER BY code_des                             ";

            dsUnitCode.SourceMethod = strCodeSQL;
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsUnitPrice.Tables[0].NewRow();
            newrow["Ele_Price"] = 0;
            dsUnitPrice.Tables[0].Rows.Add(newrow);
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            //2009-08-20 sun
            dvUnitPrice.EndEdit();
            bsUnitPrice.EndEdit();
            int iCheckFlagCount = 0;
            for (int i = 0; i < dsUnitPrice.Tables[0].Rows.Count; i++)
            {
                if (dsUnitPrice.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    iCheckFlagCount++;
                }
            }
            if (iCheckFlagCount == 0)
            {
                MessageBox.Show("û��ѡ�����ݻ��ߵ�ǰû�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = dsUnitPrice.Tables[0].Rows.Count-1; i >=0; i--)
            {
                if (dsUnitPrice.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsUnitPrice.Tables[0].Rows[i].Delete();
                }
            }
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUnitPrice.EndEdit();
            bsUnitPrice.EndEdit();
            if (dsUnitPrice.GetChanges(DataRowState.Added) != null)
                bAdded = true;
            else
                bAdded = false;
            if (dsUnitPrice.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsUnitPrice.LoadData();
                return;
            }
            //�ж��Ƿ�Ϊ���
            if (bAdded)
            MessageBox.Show("����ʧ�ܣ������������ݿ��������ݿ����Ѵ��ڣ�", "��ʾ");
            else
            MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsUnitPrice.LoadData();
        }

        //��ӡ
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�Ͻ�ƻ�������Ϣ", dvUnitPrice);
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
        private void UnitPriceMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //����ʱд�����ϱ���
        private void dvMatPrice_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dvUnitPrice.CurrentCell.ColumnIndex != dvUnitPrice.Columns["Ele_Des"].Index)
                return;
            dvUnitPrice.CurrentRow.Cells["Ele_Code"].Value = dvUnitPrice.CurrentRow.Cells["Ele_Des"].Value.ToString();
        }

        //������ݰ�(�޶���ʷ��¼�����޸Ĺؼ��ּ�����ɲ���)
        //private void dvMatPrice_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    try
        //    {
        //        if (dvUnitPrice.Rows.Count < 1)
        //            return;
        //        for (int i = 0; i < dvUnitPrice.Rows.Count; i++)
        //        {
        //            if (dvUnitPrice.Rows[i].Cells["OBJECT_ID"].Value.ToString() != "")
        //            {
        //                dvUnitPrice.Rows[i].Cells["WORK_YEAR"].ReadOnly = true;
        //                //dvMatPrice.Rows[i].Cells["MATERIAL_CODE"].ReadOnly = true;
        //                dvUnitPrice.Rows[i].Cells["MATERIAL_NAME"].ReadOnly = true;
        //            }
        //        }
        //    }
        //    catch { }
        //}

        //����EXCEL  2009-08-19 sun
        private void btnIncludeExcel_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }

            string strCom = " Select * FROM [Sheet1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsUnitPrice.Tables[0].Rows.Clear();
            dsUnitPrice.AcceptChanges();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                iRowCount = ds.Tables[0].Rows.Count + 1;
                iColumnCount = ds.Tables[0].Columns.Count;
                for (int i = 1; i < iRowCount - 1; i++)
                {
                    DataRow newrow = dsUnitPrice.Tables[0].NewRow();
                    dsUnitPrice.Tables[0].Rows.Add(newrow);
                    dsUnitPrice.Tables[0].Rows[i - 1]["ELE_CODE"] = ds.Tables[0].Rows[i]["ELE_CODE"];
                    dsUnitPrice.Tables[0].Rows[i - 1]["ELE_DES"] = ds.Tables[0].Rows[i]["ELE_CODE"];
                    dsUnitPrice.Tables[0].Rows[i - 1]["ELE_PRICE"] = ds.Tables[0].Rows[i]["ELE_PRICE"];
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("����ģ�岻���ڣ����������Աά����", "��ʾ");
            }
        }

        //2009-08-20 sun ȫѡ�˵�
        private void ȫѡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dsUnitPrice.Tables[0].Rows.Count; i++)
            {
                dsUnitPrice.Tables[0].Rows[i]["CheckFlag"] = 1;
            }
        }

    }
}