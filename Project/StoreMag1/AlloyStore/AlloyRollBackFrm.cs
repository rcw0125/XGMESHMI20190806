using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyRollBackFrm : Form
    {
        public AlloyRollBackFrm()
        {
            InitializeComponent();
        }
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            dsRollBack.Tables[0].Clear();
            dsRollBack.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsRollBack.Tables[0].Rows[0]["OldAmount"] = dsData.Tables[0].Rows[0]["AMOUNT"];
            dsRollBack.Tables[0].Rows[0]["AMOUNT"] = 0;
            this.ShowDialog();
        }
        
        //确定
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsRollBack.EndEdit();

            string check = MessageBox.Show( "确认要取消上料么？" , "提示" , MessageBoxButtons.OKCancel,MessageBoxIcon.Question ).ToString();
            if ( check == "OK" )
            {
                if (Convert.ToDouble(dsRollBack.Tables[0].Rows[0]["AMOUNT"]) <= Convert.ToDouble(dsRollBack.Tables[0].Rows[0]["OldAmount"]))
                {
                    if (Convert.ToDouble(dsRollBack.Tables[0].Rows[0]["AMOUNT"]) == 0)
                    {
                        MessageBox.Show("取消重量不能为0！", "提示");
                    }
                    else
                    {
                        cmdRollBack.Execute();
                        String returnFlag = cmdRollBack.Command.Return.ToString();
                        string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                        if (returnFlag == "0")
                        {
                            MessageBox.Show("取消上料成功！", "提示");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("取消上料不成功！" + strShow, "提示");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("取消重量大于现有重量！", "提示");
                }
            }
        }

        //取消
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AlloyRollBackFrm_Load(object sender, EventArgs e)
        {
            //cmbCurPosition.TextChanged += new EventHandler(pxControls_TextChanged);
            //cmbPosition.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtCurAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            //txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void AlloyRollBackFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}