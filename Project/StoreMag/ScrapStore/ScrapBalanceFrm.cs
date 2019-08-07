using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.ScrapStore
{
    public partial class ScrapBalanceFrm : Form
    {
        public ScrapBalanceFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsBalance.Tables[0].Clear();
            dsBalance.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsBalance.Tables[0].Rows[0]["OldAmount"] = dsData.Tables[0].Rows[0]["AMOUNT"];
            dsBalance.Tables[0].Rows[0]["StoreAreaID"] = dsData.Tables[0].Rows[0]["POSITION"];
            this.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //盘亏
        private void btnRemove_Click(object sender, EventArgs e)
        {
            dsBalance.Tables[0].Rows[0]["BalanceFlag"] = 0;
            bsBalance.EndEdit();
            string check = MessageBox.Show("确认要盘亏么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if ( check == "OK" )
            {
                cmdBalance.Execute();
                String returnFlag = cmdBalance.Command.Return.ToString();
                if ( returnFlag == "0" )
                {
                    MessageBox.Show( "盘亏成功！" , "提示" );
                    this.Close();
                }
                else
                {
                    MessageBox.Show( "盘亏不成功！错误代码为：" + returnFlag , "提示" );
                }
            }
        }

        //盘盈
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dsBalance.Tables[0].Rows[0]["BalanceFlag"] = 1;
            bsBalance.EndEdit();
            string check = MessageBox.Show("确认要盘盈么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if ( check == "OK" )
            {
                cmdBalance.Execute();
                String returnFlag = cmdBalance.Command.Return.ToString();
                if ( returnFlag == "0" )
                {
                    MessageBox.Show( "盘盈成功！" , "提示" );
                    this.Close();
                }
                else
                {
                    MessageBox.Show( "盘盈不成功！错误代码为：" + returnFlag , "提示" );
                }
            }
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
            btnAdd.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void ScrapBalanceFrm_Load(object sender, EventArgs e)
        {
            cmbScrap.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCurWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            txtWeight.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbScrap.SelectedIndex = 0;
        }

        private void ScrapBalanceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}