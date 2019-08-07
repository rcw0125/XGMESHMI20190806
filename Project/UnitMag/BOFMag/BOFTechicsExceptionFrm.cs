using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFTechicsExceptionFrm : Form
    {
        public BOFTechicsExceptionFrm()
        {
            InitializeComponent();
        }

        private string cstrUnitID;
        public DialogResult ShowDialogEx(AppSvrIF.Session session,string UnitID)
        {
            cstrUnitID = UnitID;
            Adapter.set_URIParameters("UnitID", UnitID.Substring(1,1));
            cmdHeatID.Parameters[0].ConstantValue = UnitID;
            Adapter.Session = session;
            return ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string check = MessageBox.Show("确认记录工艺异常？", "提示", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "Cancel") return;

            if (cmbTechnicsException.SelectedValue == null)
            {
                MessageBox.Show("请选择异常原因！");
                return;
            }
            if (cmbHeatID.Text.Length != 9)
            {
                MessageBox.Show("炉号数据不正确！");
                return;
            }

            DataRow row = dsHeatExcept.Tables[0].NewRow();
            row[0] = cmbTechnicsException.SelectedValue;
            row[1] = DateTime.Now;
            dsHeatExcept.Tables[0].Rows.Add(row);

            cmdHeatExcept.Parameters[0].ConstantValue = cmbHeatID.SelectedValue.ToString();
            cmdHeatExcept.Parameters[1].ConstantValue = cstrUnitID.Substring(1,1).ToString();
            cmdHeatExcept.Parameters[2].ConstantValue = cstrUnitID.Substring(2, 1).ToString();
            cmdHeatExcept.Parameters[3].SourceObject = dsHeatExcept;

            int iRet = cmdHeatExcept.Execute();
            if (iRet != 0 || ( Convert.ToInt16(cmdHeatExcept.Command.Return)) != 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", cmdHeatExcept.Command.ErrorCode));
                //MessageBox.Show(string.Format("失败！错误:{0:X},{1:X}", cmdHeatExcept.Command.ErrorCode, iRet));
                MessageBox.Show("失败！" + strReasultShow);
            }
            else
            {
                MessageBox.Show("记录工艺异常成功！");
                Close();
            }
            return;
        }
    }
}