using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.BloomStore
{
    public partial class BloomSpileChangeFrm : Form
    {
        public BloomSpileChangeFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsSpileChange.Tables[0].Clear();
            for (int i = 0; i < dsData.Tables[0].Rows.Count; i++)
            {
                dsSpileChange.Tables[0].ImportRow(dsData.Tables[0].Rows[i]);
            }
            this.ShowDialog();
        }

        private void BloomSpileChangeFrm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dsSpileChange.Tables[0].Rows.Count; i++)
            {
                dsSpileChange.Tables[0].Rows[i]["Amount"] = dsSpileChange.Tables[0].Rows[i]["BLOOM_COUNT"];
                dsSpileChange.Tables[0].Rows[i]["TargetID"] = dsSpileChange.Tables[0].Rows[i]["Position"];
                dsSpileChange.Tables[0].Rows[i]["Target_Pile_ID"] = dsSpileChange.Tables[0].Rows[i]["Cur_Pile_ID"];
                dsSpileChange.Tables[0].Rows[i]["Target_Layer_ID"] = dsSpileChange.Tables[0].Rows[i]["Cur_Layer_ID"];
                dsSpileChange.Tables[0].Rows[i]["MaterialType"] = "CBloom_Data";
            }
        }

       
        //垛位变更
        private void btnSpileChange_Click(object sender, EventArgs e)
        {
            dvSpileChange.EndEdit();
            bsSpileChange.EndEdit();
            string check = MessageBox.Show("确认要垛位变更么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdSpileChange.Execute();
                String returnFlag = cmdSpileChange.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("垛位变更成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("垛位变更不成功！错误代码为：" + returnFlag, "提示");
                    dsSpileChange.LoadData();
                }
            }
        }

        private void dvSpileChange_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloomSpileChangeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}