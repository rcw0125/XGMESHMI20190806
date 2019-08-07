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

namespace StoreMag.ScrapStore
{
    public partial class ScrapInformationInputFrm : Form
    {
        public ScrapInformationInputFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        //采购入库信息从EXL导入
        private void btnPurchaseEXL_Click(object sender, EventArgs e)
        {

            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = d:\\Exl\\废钢外购.xls;Extended Properties=\"Excel 8.0\"";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " Select * FROM [Sheet 1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsScrapInfor.Clear();
            DataSet ds = new DataSet();

            try
            {
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsScrapInfor.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
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
            DataRow newrow = dsScrapInfor.Tables[0].NewRow();
            dsScrapInfor.Tables[0].Rows.Add(newrow);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsScrapInfor.Position > -1)
                bsScrapInfor.RemoveCurrent();
        }

        //采购入库信息确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvScrapInfor.EndEdit();
            bsScrapInfor.EndEdit();
            string check = MessageBox.Show("确认要导入么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdScrapInfor.Execute();
                String returnFlag = cmdScrapInfor.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("导入成功！", "提示");
                    dsScrapInfor.Clear();
                }
                else
                {
                    MessageBox.Show("导入不成功！错误代码为：" + returnFlag, "提示");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsScrapInfor.RejectChanges();
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //转库信息从EXL导入
        private void btnTransEXL_Click(object sender, EventArgs e)
        {
            string strCon = " Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = d:\\Exl\\废钢生铁转库.xls;Extended Properties=\"Excel 8.0\"";
            OleDbConnection myConn = new OleDbConnection(strCon);
            myConn.Open();
            string strCom = " Select * FROM [Sheet 1$]";
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            dsTrans.Clear();
            DataSet ds = new DataSet();

            try
            {
                myCommand.Fill(ds);
                for (int i = 1; i < ds.Tables[0].Rows.Count; i++)
                {
                    dsTrans.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
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
            DataRow newrow = dsTrans.Tables[0].NewRow();
            dsTrans.Tables[0].Rows.Add(newrow);
        }

        private void btnTransDel_Click(object sender, EventArgs e)
        {
            if (bsTrans.Position > -1)
                bsTrans.RemoveCurrent();
        }

        //转库信息确认
        private void btnTransConfirm_Click(object sender, EventArgs e)
        {
            dvTrans.EndEdit();
            bsTrans.EndEdit();
            string check = MessageBox.Show("确认要导入么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTrans.Execute();
                String returnFlag = cmdTrans.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("导入成功！", "提示");
                    dsTrans.Clear();
                }
                else
                {
                    MessageBox.Show("导入不成功！错误代码为：" + returnFlag, "提示");
                }
            }
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            dsTrans.RejectChanges();
        }

        private void dvScrapInfor_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void ScrapInformationInputFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}