using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyInStoreComfirmFrm : Form
    {
        public AlloyInStoreComfirmFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            dsAlloyInStoreConfirm.Tables[0].Clear();
            dsAlloyInStoreConfirm.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            txtOldAmount.Text = dsData.Tables[0].Rows[0]["AMOUNT"].ToString();
            //cmdCodeArea.Parameters[0].ConstantValue = dsData.Tables[0].Rows[0]["ALLOY_CODE"].ToString(); 
            cmdPossition.Parameters[0].ConstantValue= dsData.Tables[0].Rows[0]["ALLOY_CODE"].ToString();
            Adapter.Session = session;
            //dsCodeArea.L3DataAdapter = Adapter;
            dsPossition.L3DataAdapter = Adapter;
            this.ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsAlloyInStoreComfirmFrm.EndEdit();
            dsAlloyInStoreConfirm.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ����ô��", "��ʾ", MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (txtAmount.Text.Trim() == "0")
                {
                    MessageBox.Show("������������Ϊ�㣡", "��ʾ");
                    return;
                }
                    
                if (Convert.ToDouble(txtOldAmount.Text.Trim()) < Convert.ToDouble(dsAlloyInStoreConfirm.Tables[0].Rows[0]["Amount"].ToString()))
                {
                    MessageBox.Show("����ʧ�ܣ�����������������������", "��ʾ");
                }
                else
                {
                    cmdAlloyInStoreConfirm.Execute();
                    String returnFlag = cmdAlloyInStoreConfirm.Command.Return.ToString();
                    string strShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        MessageBox.Show("���ϳɹ���", "��ʾ");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("���ϲ��ɹ���" + strShow, "��ʾ");
                    }
                }
            }
        }

        //ȡ��
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlloyArea.Checked)
            {
                cmbArea.DataSource = null;
                cmbArea.DataSource = dsPossition;
                cmbArea.DisplayMember = "L3DataTable.CODE_DES";
                cmbArea.ValueMember = "L3DataTable.ALLOY_AREA";
               
            }
            else
            {
                cmbArea.DataSource = null;
                cmbArea.DataSource = dsGround;
                cmbArea.DisplayMember = "L3DataTable.Code_Des";
                cmbArea.ValueMember = "L3DataTable.Code";
                
                
            }
        }

        private void AlloyInStoreComfirmFrm_Load(object sender, EventArgs e)
        {
            rbtn_CheckedChanged(sender, e);

            cmbArea.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
           
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AlloyInStoreComfirmFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}