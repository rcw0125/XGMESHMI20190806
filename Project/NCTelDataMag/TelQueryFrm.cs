using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NCTelDataMag
{
    public partial class TelQueryFrm : Form
    {
        public TelQueryFrm()
        {
            InitializeComponent();
        }

        private void TelQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }

            NCTelDataFrm.strSQL = "";
            string strType = "";
            string strFlag = "";
            if (rbtSteel.Checked == true)
                strType = "1";
            else if (rbtIron.Checked == true)
                strType = "2";
            if (rbtSuccess.Checked == true)
                strFlag = "0";
            else if (rbtFail.Checked == true)
                strFlag = "1";
            if (strType != "" && strFlag != "")
                NCTelDataFrm.strSQL = "select * from CRetrunData_NC where Flag = " + strFlag + "and other1 = " + strType + " and To_Char(CreateTime,'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + dtEnd.Text.Trim() + "' order by CreateTime desc";
            else if(strType == "" && strFlag !="")
                NCTelDataFrm.strSQL = "select * from CRetrunData_NC where Flag = " + strFlag + " and To_Char(CreateTime,'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + dtEnd.Text.Trim() + "' order by CreateTime desc";
            else if(strType != "" && strFlag == "")
                NCTelDataFrm.strSQL = "select * from CRetrunData_NC where other1 = " + strType + " and To_Char(CreateTime,'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + dtEnd.Text.Trim() + "' order by CreateTime desc";
            else if (strType == "" && strFlag == "")
                NCTelDataFrm.strSQL = "select * from CRetrunData_NC where To_Char(CreateTime,'yyyy-mm-dd') >= '" + dtStart.Text.Trim() + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + dtEnd.Text.Trim() + "' order by CreateTime desc";
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NCTelDataFrm.strSQL = "";
            this.Close();
        }

    }
}