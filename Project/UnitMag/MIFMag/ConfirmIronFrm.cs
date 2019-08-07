using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class ConfirmIronFrm : Form
    {
        public ConfirmIronFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session,string strMIFID)
        {
            Adapter.Session = session;
            
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvM.EndEdit();
            bsIron.EndEdit();
            DataSet dsSel = dsgIron.Clone();
            DataRow[] rowSel = dsgIron.Tables[0].Select("SELECTED = true");
            if (rowSel == null || rowSel.Length < 1)
            {
                MessageBox.Show("ÇëÑ¡ÔñÌúË®£¡");
                return;
            }
            foreach (DataRow row in rowSel)
            {
                dsSel.Tables[0].ImportRow(row);
            }
            l3cmdConfirm.Parameters[0].SourceObject = dsSel;
            int iRet = l3cmdConfirm.Execute();
            if (iRet != 0 || ((short)l3cmdConfirm.Command.Return) == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", l3cmdConfirm.Command.ErrorCode));
                //MessageBox.Show(string.Format("Ê§°Ü£¡´íÎó:{0:X},{1:X}", l3cmdConfirm.Command.ErrorCode, iRet));
                MessageBox.Show("Ê§°Ü£¡" + strReasultShow);
            }
            dsgIron.LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}