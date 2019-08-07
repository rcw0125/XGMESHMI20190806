using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.DeSMag
{
    public partial class DeSMatSetShow : Form
    {
        public DeSMatSetShow()
        {
            InitializeComponent();
        }

        private string IorII = "";
        public void ShowDialogEx(AppSvrIF.Session session, string Unit)
        {
            Adapter.Session = session;
            IorII = Unit;
            this.ShowDialog();
        }

        private void DeSMatSetShow_Load(object sender, EventArgs e)
        {
            //��ʾ��ͬtabpage
            if (IorII == "S02")
                tcMain.TabPages.Remove(tpDeSII);
            else
                tcMain.TabPages.Remove(tpDeSI);

            dsMatCode.LoadData();
            dsMatVendor.LoadData();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (IorII == "S02")
            {
                bsMatSet1.EndEdit();
                if (dsMatSet1.UpdateData())
                    MessageBox.Show("�趨�ɹ���", "��ʾ");
                else
                    MessageBox.Show("�趨ʧ�ܣ�", "��ʾ");
            }
            else
            {
                bsMatSet2.EndEdit();
                if (dsMatSet2.UpdateData())
                    MessageBox.Show("�趨�ɹ���", "��ʾ");
                else
                    MessageBox.Show("�趨ʧ�ܣ�", "��ʾ");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}