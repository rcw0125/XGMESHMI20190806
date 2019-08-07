using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyToBulkFrm : Form
    {
        public AlloyToBulkFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            dsAlloyToBulk.Tables[0].Clear();
            dsAlloyToBulk.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            txtOldAmount.Text = dsData.Tables[0].Rows[0]["AMOUNT"].ToString();
            Adapter.Session = session;
            this.ShowDialog();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsAlloyToBulk.EndEdit();
            dsAlloyToBulk.AcceptChanges();
            string check = MessageBox.Show("确认要转换么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (txtAmount.Text.Trim() == "0" && txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("转换重量不能为零！", "提示");
                    return;
                }

                if (Convert.ToDouble(txtOldAmount.Text.Trim()) < Convert.ToDouble(dsAlloyToBulk.Tables[0].Rows[0]["Amount"].ToString()))
                {
                    MessageBox.Show("转换失败，转换重量大于现有重量！", "提示");
                }
                else
                {
                    cmdAlloyToBulk.Execute();
                    String returnFlag = cmdAlloyToBulk.Command.Return.ToString();
                    //string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        MessageBox.Show("转换成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        if (returnFlag == "-3")
                        {
                            MessageBox.Show("转换不成功！该合金不允许转换为散状料", "提示");
                        }
                        else
                        {
                            MessageBox.Show("转换不成功！" + returnFlag, "提示");
                        }
                    }
                }
            }
        }

        //取消
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AlloyToBulkFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}