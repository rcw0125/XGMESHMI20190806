using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EquipMag.LadleMag
{
    public partial class BOFTapStartFrm : Form
    {
        public BOFTapStartFrm()
        {
            InitializeComponent();
        }

        //[20081229Liao]
        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strLadleID)
        {
            Adapter.Session = session;

            txtLadleID.Text = strLadleID;

            return ShowDialog();
        }

        private void BOFTapStartFrm_Load(object sender, EventArgs e)
        {
            dtTapTime.Value = DateTime.Now;

            cmbBOFID.TextChanged += new EventHandler(pxControls_TextChanged);
            txtHeatID.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbBOFID.Text.Trim() == "" || txtHeatID.Text.Trim().Length != 9)
            {
                MessageBox.Show("������������", "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("ȷ��\"��¼ת¯���ֿ�ʼ�ź�\"��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                l3cmdpUnitID.ConstantValue = cmbBOFID.Text.Trim();
                l3cmdpTapTime.SourceObject = dtTapTime;
                l3cmdpTapTime.SourceProperty = "Value";
                l3cmdpHeatID.ConstantValue = txtHeatID.Text.Trim();

                if (cmdBOFTapStart.Execute() >= 0)
                {
                    if (Convert.ToBoolean(cmdBOFTapStart.Command.Return))
                    {
                        MessageBox.Show("��¼�ɹ���", "��ʾ", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("��¼ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("��¼ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }
    }
}