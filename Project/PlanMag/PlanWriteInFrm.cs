using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PlanMag
{
    public partial class PlanWriteInFrm : DockContent, IMESForm
    {
        public PlanWriteInFrm()
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
        //private string strAddress = "D:\\Exl\\�ƻ�����.xls";
        private int iRowCount = 0;
        private int iColumnCount = 0;
        private OleDbConnection myConn;

        private void PlanWriteInFrm_Load(object sender, EventArgs e)
        {
            strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\\Exl\\�ƻ�����.xls;Extended Properties=\"Excel 8.0\"";
            myConn = new OleDbConnection(strCon);
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsPlan.Tables[0].NewRow();
            dsPlan.Tables[0].Rows.Add(newrow);

            bsPlan.MoveLast();
            PlanWriteInShowFrm Frm = new PlanWriteInShowFrm();
            Frm.ShowDialogEx(bsPlan.Position, dsPlan);
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsPlan.RejectChanges();
            dsPlan.LoadData();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsPlan.EndEdit();
            if (cmdPlan.Execute() >= 0)
            {
                if (cmdPlan.Command.Return.ToString() == "1")
                {
                    MessageBox.Show("ȷ�ϳɹ���", "��ʾ");
                   // CommDataMag.CommonMethed.Delete(strAddress, 3, 1, iRowCount, iColumnCount, true);
                }
                else
                {
                    MessageBox.Show("�������ɹ���û��Ҫȷ�ϵļƻ�", "��ʾ");
                }
                dsPlan.Tables[0].Clear();
            }
        }

        //�ƻ�Excel����
        private void btnIncludeExcel_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Closed)
            {
                myConn.Open();
            }

            string strCom = " Select * FROM [Sheet1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsPlan.Clear();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                iRowCount = ds.Tables[0].Rows.Count + 1;
                iColumnCount = ds.Tables[0].Columns.Count;
                for (int i = 1; i < iRowCount - 1; i++)
                {
                    dsPlan.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("����ģ�岻���ڣ����������Աά����", "��ʾ");
            }
        }

        private void PlanWriteInFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myConn.Close();
        }

        private void PlanWriteInFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}