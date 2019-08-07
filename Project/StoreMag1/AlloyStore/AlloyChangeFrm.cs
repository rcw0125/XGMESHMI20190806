using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyChangeFrm : Form
    {
        public AlloyChangeFrm()
        {
            InitializeComponent();
        }
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;

            l3cmdpTraget.ConstantValue = dsData.Tables[0].Rows[0]["ALLOY_CODE"].ToString();
            dsTraget.L3DataAdapter = Adapter;
            Adapter.RefreshDataBindings();
            dsTraget.LoadData();

            dsChange.Tables[0].Clear();
            dsChange.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsChange.Tables[0].Rows[0]["OldAmount"] = dsData.Tables[0].Rows[0]["AMOUNT"];
            this.ShowDialog();
        }
        
        //确定
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsChange.EndEdit();

            string check = MessageBox.Show( "确认要转库么？" , "提示" , MessageBoxButtons.OKCancel,MessageBoxIcon.Question ).ToString();
            if ( check == "OK" )
            {
                cmdChange.Execute();
                String returnFlag = cmdChange.Command.Return.ToString();
                string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);//  [12/30/2008 sun]
                if ( returnFlag == "0" )
                {
                    MessageBox.Show( "转库成功！" , "提示" );
                    this.Close();
                }
                else
                {
                    MessageBox.Show("转库不成功！" + strShow, "提示");
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

        private void AlloyChangeFrm_Load(object sender, EventArgs e)
        {
            cmbCurPosition.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbPosition.TextChanged += new EventHandler(pxControls_TextChanged);
            txtCurAmount.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void AlloyChangeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}