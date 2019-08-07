using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class DirectFeedIronFrm : Form
    {
        public DirectFeedIronFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strMIFID)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            dvMixs.EndEdit();
            bsMixs.EndEdit();
            
            int iRet = l3cmdMix.Execute();
            if (iRet != 0 || l3cmdMix.Command.Return.ToString() == "")
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", l3cmdMix.Command.ErrorCode));
                //MessageBox.Show(string.Format("直兑失败！错误:{0:X},{0:X}", l3cmdMix.Command.ErrorCode, iRet));
                MessageBox.Show("直兑失败！" + strReasultShow);
                btnMix.DialogResult = DialogResult.None;
                return;
            }
            btnMix.DialogResult = DialogResult.OK;
        }

        private void dvIron_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dsMixs.AcceptChanges();

            if (e.RowIndex >= 0 && e.RowIndex < dsIrons.Tables[0].Rows.Count)
            {
                DataRow row = dsIrons.Tables[0].Rows[e.RowIndex];
                string strMatID = row["MaterialID"].ToString();
                DataRow[] exist = dsMixs.Tables[0].Select(string.Format("MaterialID = '{0}'", strMatID));
                if (exist == null || exist.Length < 1)
                {
                    dsMixs.Tables[0].ImportRow(dsIrons.Tables[0].Rows[e.RowIndex]);
                    dsMixs.Tables[0].Rows[dsMixs.Tables[0].Rows.Count - 1]["Net_Weight"] = dsMixs.Tables[0].Rows[dsMixs.Tables[0].Rows.Count - 1]["Spare_Weight"];
                }
            }
        }

        private void dvMix_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(dvMixs.Columns[e.ColumnIndex].DataPropertyName == "Net_Weight")
            {
                double fNewWeight = Math.Round(double.Parse(e.FormattedValue.ToString()), 2);
                DataRow row = ((DataRowView)dvMixs.Rows[e.RowIndex].DataBoundItem).Row;
                if (fNewWeight > Math.Round(double.Parse(row["Spare_Weight"].ToString()),2))
                {
                    e.Cancel = true;
                    MessageBox.Show("输入的兑铁量过大！");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvIron_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}