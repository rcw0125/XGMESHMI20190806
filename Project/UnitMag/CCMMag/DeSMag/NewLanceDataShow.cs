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
           //������ǹ��Ϣ
            dsLanceNo.SourceMethod = "select distinct LANCENO from CDES_LANCE_DATA where STATUS<>5";
            dsLanceNo.LoadData();

            DataTable dt = new DataTable();
            dt.Columns.Add("LanceNoText", System.Type.GetType("System.String"));
            dt.Columns.Add("LanceNoValue", System.Type.GetType("System.Int32"));

            dt.Rows.Add("����", 1);
            dt.Rows.Add("����", 2);
            dt.Rows.Add("ά��", 3);
            dt.Rows.Add("����", 4);
            dt.Rows.Add("����", 5);

            cmbStatus.DataSource = dt;
            cmbStatus.DisplayMember = "LanceNoText";
            cmbStatus.ValueMember = "LanceNoValue";


           //������ǹ״̬
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //����һ��
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
                        MessageBox.Show("�����ɹ���", "��ʾ");
                        this.Close();
                    }
                    else
                    {
                        string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, sRet);
                        MessageBox.Show("����ʧ�ܣ�" + sRet + strReasultShow, "��ʾ");
                    }
                }
                else
                    MessageBox.Show("����ʧ�ܣ�", "��ʾ");
            }
            catch { }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}