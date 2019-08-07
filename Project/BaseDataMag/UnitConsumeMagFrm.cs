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
    public partial class UnitConsumeMagFrm : DockContent, IMESForm
    {
        public UnitConsumeMagFrm()
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

        private void UnitConsumeMagFrm_Load(object sender, EventArgs e)
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

            dsSteelGrade.SourceMethod = "";
            dsSteelGrade.SourceMethod = "select DISTINCT (STEELGRADE) from CQA_STEELGRADEINDEX_R order by STEELGRADE";
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsUnitConsume.Tables[0].NewRow();
            newrow["UNIT_CONSUME"] = 0;
            dsUnitConsume.Tables[0].Rows.Add(newrow);
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            //2009-08-20 sun
            dvUnitConsume.EndEdit();
            bsUnitConsume.EndEdit();
            int iCheckFlagCount = 0;
            for (int i = 0; i < dsUnitConsume.Tables[0].Rows.Count; i++)
            {
                if (dsUnitConsume.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    iCheckFlagCount++;
                }
            }
            if (iCheckFlagCount == 0)
            {
                MessageBox.Show("û��ѡ�����ݻ��ߵ�ǰû�����ݣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = dsUnitConsume.Tables[0].Rows.Count-1; i >=0; i--)
            {
                if (dsUnitConsume.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsUnitConsume.Tables[0].Rows[i].Delete();
                }
            }
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUnitConsume.EndEdit();
            bsUnitConsume.EndEdit();
            if (dsUnitConsume.GetChanges(DataRowState.Added) != null)
                bAdded = true;
            else
                bAdded = false;
            if (dsUnitConsume.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                dsUnitConsume.LoadData();
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
            dsUnitConsume.LoadData();
        }

        //��ӡ
        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�Ͻ�ƻ�������Ϣ", dvUnitConsume);
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
        private void UnitConsumeMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //����ʱд�����ϱ���
        private void dvMatPrice_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dvUnitConsume.CurrentCell.ColumnIndex != dvUnitConsume.Columns["Ele_Des"].Index)
                return;
            dvUnitConsume.CurrentRow.Cells["Ele_Code"].Value = dvUnitConsume.CurrentRow.Cells["Ele_Des"].Value.ToString();
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
            dsUnitConsume.Tables[0].Rows.Clear();
            dsUnitConsume.AcceptChanges();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                iRowCount = ds.Tables[0].Rows.Count + 1;
                iColumnCount = ds.Tables[0].Columns.Count;
                for (int i = 1; i < iRowCount - 1; i++)
                {
                    DataRow newrow = dsUnitConsume.Tables[0].NewRow();
                    dsUnitConsume.Tables[0].Rows.Add(newrow);
                    dsUnitConsume.Tables[0].Rows[i - 1]["ELE_CODE"] = ds.Tables[0].Rows[i]["ELE_CODE"];
                    dsUnitConsume.Tables[0].Rows[i - 1]["ELE_DES"] = ds.Tables[0].Rows[i]["ELE_CODE"];
                    dsUnitConsume.Tables[0].Rows[i - 1]["STEELTYPE"] = ds.Tables[0].Rows[i]["STEELTYPE"];
                    dsUnitConsume.Tables[0].Rows[i - 1]["STEELGRADE"] = ds.Tables[0].Rows[i]["STEELGRADE"];
                    dsUnitConsume.Tables[0].Rows[i - 1]["UNIT_CONSUME"] = ds.Tables[0].Rows[i]["UNIT_CONSUME"];
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
            for (int i = 0; i < dsUnitConsume.Tables[0].Rows.Count; i++)
            {
                dsUnitConsume.Tables[0].Rows[i]["CheckFlag"] = 1;
            }
        }

    }
}