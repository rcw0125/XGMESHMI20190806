using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class NewLanceDataShow : Form
    {
        public NewLanceDataShow()
        {
            InitializeComponent();
        }
        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            this.ShowDialog();

        }
        private void NewLanceDataShow_Load(object sender, EventArgs e)
        {
           //加载喷枪信息
            dsLanceNo.SourceMethod = "select distinct LANCENO from CDES_LANCE_DATA where STATUS<>5";
            dsLanceNo.LoadData();

            DataTable dt = new DataTable();
            dt.Columns.Add("LanceNoText", System.Type.GetType("System.String"));
            dt.Columns.Add("LanceNoValue", System.Type.GetType("System.Int32"));

            dt.Rows.Add("备用", 1);
            dt.Rows.Add("在线", 2);
            dt.Rows.Add("维修", 3);
            dt.Rows.Add("在线", 4);
            dt.Rows.Add("废弃", 5);

            cmbStatus.DataSource = dt;
            cmbStatus.DisplayMember = "LanceNoText";
            cmbStatus.ValueMember = "LanceNoValue";


           //加载配枪状态
        }

        //确定
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //新增一行
            DataRow newrow = dsLance.Tables[0].NewRow();
            newrow["LanceNo"] = cbLanceNo.Text;
            newrow["Status"] = Int32.Parse(cmbStatus.SelectedValue.ToString());
            newrow["Note"] = richTextBox1.Text;
            dsLance.Tables[0].Rows.Add(newrow);
            //dsError.SourceCondition = "OWNER = 'DesignateIronLadle'";
            string sRet = "";
            if (dsLance == null || dsLance.Tables[0].Rows.Count < 1)
                return;
            try
            {
                if (cmdNewLance.Execute() >= 0)
                {
                    sRet = Convert.ToString(cmdNewLance.Command.Return);
                    if (sRet == "1")
                    {
                        MessageBox.Show("新增成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("新增失败！" + sRet + strReasultShow, "提示");
                    }
                }
                else
                    MessageBox.Show("新增失败！", "提示");
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}