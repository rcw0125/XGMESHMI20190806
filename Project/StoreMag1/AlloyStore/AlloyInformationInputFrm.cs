using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace StoreMag.AlloyStore
{
    public partial class AlloyInformationInputFrm : Form
    {
        public AlloyInformationInputFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //�Ͻ��EXL����
        private void btnAlloyInforEXL_Click(object sender, EventArgs e)
        {
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\\Exl\\�Ͻ�ת��.xls;Extended Properties=\"Excel 8.0\"";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " Select * FROM [Sheet 1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsAlloyInfor.Clear();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsAlloyInfor.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("����ģ�岻���ڣ����������Աά����", "��ʾ");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsAlloyInfor.Tables[0].NewRow();
            dsAlloyInfor.Tables[0].Rows.Add(newrow);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsAlloyInfor.Position > -1)
                bsAlloyInfor.RemoveCurrent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsAlloyInfor.RejectChanges();
        }

        //�Ͻ�ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvAlloyInfor.EndEdit();
            bsAlloyInfor.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdAlloyInfor.Execute();
                String returnFlag = cmdAlloyInfor.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if (returnFlag == "0")
                {
                    MessageBox.Show("����ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���벻�ɹ���" + strShow, "��ʾ");
                }
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //�ɷִ�EXL����
        private void btnElementEXL_Click(object sender, EventArgs e)
        {
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\\Exl\\�Ͻ�ɷ�.xls;Extended Properties=\"Excel 8.0\"";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " Select * FROM [Sheet 1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsAlloyInfor.Clear();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsElement.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("����ģ�岻���ڣ����������Աά����", "��ʾ");
            }

        }
        //�ɷ�ȷ��
        private void btnElementConfirm_Click(object sender, EventArgs e)
        {
            dvElement.EndEdit();
            bsElement.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdElement.Execute();
                String returnFlag = cmdElement.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if (returnFlag == "0")
                {
                    MessageBox.Show("����ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���벻�ɹ���" + strShow, "��ʾ");
                }
            }
        }

        private void btnElementAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsElement.Tables[0].NewRow();
            dsElement.Tables[0].Rows.Add(newrow);
        }

        private void btnElementDel_Click(object sender, EventArgs e)
        {
            if (bsElement.Position > -1)
                bsElement.RemoveCurrent();
        }

        private void btnElementCancel_Click(object sender, EventArgs e)
        {
            dsElement.RejectChanges();
        }

        private void dvAlloyInfor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void AlloyInformationInputFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}