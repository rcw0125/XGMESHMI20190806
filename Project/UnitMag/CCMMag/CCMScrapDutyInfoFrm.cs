using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMScrapDutyInfoFrm : Form
    {
        public CCMScrapDutyInfoFrm()
        {
            InitializeComponent();
        }



        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strHeatID)
        {
            Adapter.Session = session;
            dsWasterData.SourceCondition = "HeatID = '" + strHeatID + "'";
            dsWasterData.L3DataAdapter = Adapter;

            return ShowDialog();
        }

        //数据加载
        private void CCMScrapDutyInfoFrm_Load(object sender, EventArgs e)
        {
            try
            {
                if (dsWasterData.Tables[0].Rows[0]["Duty_Flag"].ToString() == "1")
                {
                    panel.Visible = false;
                }

                cmbSampleType_TextChanged(cmbSampleType1, e);
                cmbSampleType_TextChanged(cmbSampleType2, e);
                cmbSampleType_TextChanged(cmbSampleType3, e);
            }
            catch { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认指定？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() != "Yes")
                return;

            bsWasterData.EndEdit();
            dsWasterData.Tables[0].Rows[0]["Duty_Flag"] = 1;
            if (dsWasterData.UpdateData())
            {
                MessageBox.Show("确认成功！", "提示！", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSampleType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                int itxtLenth = cmb.Text.Trim().Length;

                bool bobj = true;
                if (itxtLenth <= 0)
                    bobj = false;

                switch (cmb.Name)
                {
                    case "cmbSampleType1":
                        cmbShop1.Enabled = bobj;
                        cmbUnit1.Enabled = bobj;
                        txtPer1.Enabled = bobj;
                        cmbTeam1.Enabled = bobj;
                        break;

                    case "cmbSampleType2":
                        cmbShop2.Enabled = bobj;
                        cmbUnit2.Enabled = bobj;
                        txtPer2.Enabled = bobj;
                        cmbTeam2.Enabled = bobj;
                        break;

                    case "cmbSampleType3":
                        cmbShop3.Enabled = bobj;
                        cmbUnit3.Enabled = bobj;
                        txtPer3.Enabled = bobj;
                        cmbTeam3.Enabled = bobj;
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }
    }
}