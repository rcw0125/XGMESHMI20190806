using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;


namespace NCTelDataMag
{
    public partial class NCTelDataFrm : DockContent, IMESForm
    {
        public NCTelDataFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion
        public static string strSQL = "";
        private void btnQuery_Click(object sender, EventArgs e)
        {
            double dDateLength = Math.Round((tdtend.Value.ToOADate() - tdtstart.Value.ToOADate() + 1), 0);
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            dsLog.SourceMethod = "select * from CRetrunData_NC where HeatID = ''";

            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strEnd = tdtend.Value.ToString("yyyy-MM-dd");
            if (txbHeatID.Text == "")
                dsLog.SourceMethod = "select * from CRetrunData_NC where To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            else
                dsLog.SourceMethod = "select * from CRetrunData_NC where HeatID = '" + txbHeatID.Text + "'";
        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            tdtstart.Value = DateTime.Now;
            tdtend.Value = DateTime.Now;
        }

        private void dvTel_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvTel.RowCount > 0)
                {
                    txtRemark.Text = dvTel.CurrentRow.Cells["remarkDataGridViewTextBoxColumn"].Value.ToString();
                }
            }
            catch { }
        }

        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {            
            TelQueryFrm frm = new TelQueryFrm();
            frm.ShowDialog();
            if (strSQL != "")
            {
                dsLog.SourceMethod = "select * from CRetrunData_NC where HeatID = ''";
                dsLog.SourceMethod = strSQL;
            }
        }
    }
}