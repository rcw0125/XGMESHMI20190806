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

namespace StoreMag.BulkStore
{
    public partial class BulkInformationInputFrm : Form
    {
        public BulkInformationInputFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //采购入库信息从EXL导入
        private void btnBulkInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = d:\\Exl\\散状料外购.xls;Extended Properties=\"Excel 8.0\"";
                OleDbConnection myConn = new OleDbConnection(strCon);
                myConn.Open();
                string strCom = " Select * FROM [Sheet 1$]";
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);

                dsBulkInfor.Clear();
                DataSet ds = new DataSet();
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsBulkInfor.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("导入模板不存在，请找相关人员维护！", "提示");
            }



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBulkInfor.Tables[0].NewRow();
            dsBulkInfor.Tables[0].Rows.Add(newrow);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsBulkInfor.Position > -1)
                bsBulkInfor.RemoveCurrent();
        }
        //采购入库信息确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvBulkInfor.EndEdit();
            bsBulkInfor.EndEdit();
            string check = MessageBox.Show("确认要导入么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBulkInfor.Execute();
                String returnFlag = cmdBulkInfor.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if (returnFlag == "0")
                {
                    MessageBox.Show("导入成功！", "提示");
                    dsBulkInfor.Clear();
                }
                else
                {
                    MessageBox.Show("导入不成功！" + strShow, "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsBulkInfor.RejectChanges();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //转库信息从EXL导入
        private void btnTrans_Click(object sender, EventArgs e)
        {
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = d:\\Exl\\散状料转库.xls;Extended Properties=\"Excel 8.0\"";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " Select * FROM [Sheet 1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsBulkTrans.Clear();
            DataSet ds = new DataSet();
            try
            {
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsBulkTrans.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
                }
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("导入模板不存在，请找相关人员维护！", "提示");
            }
        }

        private void btnTransAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsBulkTrans.Tables[0].NewRow();
            dsBulkTrans.Tables[0].Rows.Add(newrow);
        }

        private void btnTransDel_Click(object sender, EventArgs e)
        {
            if (bsBulkTrans.Position > -1)
                bsBulkTrans.RemoveCurrent();
        }

        //转库信息确认
        private void btnTransConfirm_Click(object sender, EventArgs e)
        {
            dvBulkTrans.EndEdit();
            bsBulkTrans.EndEdit();
            string check = MessageBox.Show("确认要导入么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdBulkTrans.Execute();
                String returnFlag = cmdBulkTrans.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if (returnFlag == "0")
                {
                    MessageBox.Show("导入成功！", "提示");
                    dsBulkTrans.Clear();
                }
                else
                {
                    MessageBox.Show("导入不成功！" + strShow, "提示");
                }
            }
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            dsBulkTrans.RejectChanges();
        }

        private void dvBulkInfor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BulkInformationInputFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}