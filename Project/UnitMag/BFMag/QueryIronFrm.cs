using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BFMag
{
    public partial class QueryIronFrm : DockContent, IMESForm
    {
        public QueryIronFrm()
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
        
        //控件加载
        private void frmMultiRecord_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPath.SelectedIndex = 0;
                dtStart.Value = DateTime.Now;
                dtEnd.Value = DateTime.Now;
                //string s = dsPath.Tables[0].TableName;
                //string ss = dsSource.Tables[0].TableName;
            }
            catch { }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetoNC_Click(object sender, EventArgs e)
        {
            // 将选中的铸铁铁水信息重发NC
            //DataSet dsCastIrons = dsM.Clone();
            //foreach (DataGridViewRow row in dvM.Rows)
            //{
            //    if (row.Selected)
            //    {
            //        if ((int)dsM.Tables[0].Rows[row.Index]["Destination"] == 2)
            //            dsCastIrons.Tables[0].ImportRow(dsM.Tables[0].Rows[row.Index]);
            //    }
            //}
            //if (dsCastIrons.Tables[0].Rows.Count < 1)
            //{
            //    MessageBox.Show("请选择至少一条去向为铸铁的铁水.");
            //    return;
            //}
            //l3cmdReSendNC.Parameters[0].SourceObject = dsCastIrons;
            //int iRet = l3cmdReSendNC.Execute();
            //if (iRet != 0 || 0 > (int)l3cmdReSendNC.Command.Return)
            //{
            //    MessageBox.Show(string.Format("发送失败！错误代码：{0:X},{1}", l3cmdReSendNC.Command.ErrorCode, (int)l3cmdReSendNC.Command.Return));
            //}
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsM.SourceCondition = "1=2";
            dsWeight.SourceMethod = "SELECT   tap_no, ROUND (SUM (net_weight), 2) AS weight  FROM cbfiron where 1=2  GROUP BY tap_no order by tap_no";
            dsM.Tables[0].Clear();
            dsWeight.Tables[0].Clear();
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            double dDateLength = Math.Round((dtEnd.Value.ToOADate() - dtStart.Value.ToOADate() + 1), 0);
            //  [2010/4/13 孙笑天]
            if (dDateLength > 7)
            {
                MessageBox.Show("请查询时间间隔在一周以内的数据！", "提示");
                return;
            }
            string strSQL = "";
            string strWeightSQL = "";


            strSQL = "Production_Date between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";
            strWeightSQL = " SELECT   tap_no, ROUND (SUM (net_weight), 2) AS weight  FROM cbfiron where Curr_Tare > 0";
            strWeightSQL += " and Production_Date between to_date('" + dtS + "','YYYY-MM-DD HH24:MI:SS') and to_date('" + dtE + "','YYYY-MM-DD HH24:MI:SS')";

            if (cmbSoure.Text.Trim() != "")
            {
                if (cmbSoure.Text.Trim().Substring(0, 1) != "2")
                {
                    strSQL += " and Source = '" + cmbSoure.Text.Trim().Substring(0, 1) + "'";
                    strWeightSQL += " and Source = '" + cmbSoure.Text.Trim().Substring(0, 1) + "'";
                }
            }

            if (cmbPath.Text.Trim() != "")
            {
                if (cmbPath.Text.Substring(0, 1) != "3")
                {
                    strSQL += " and Destination = '" + cmbPath.Text.Substring(0, 1) + "' ";

                    strWeightSQL += " and Destination = '" + cmbPath.Text.Substring(0, 1) + "' ";
                }
            }

            strSQL += " order by Production_Date asc";
            dsM.SourceCondition = strSQL;
            //timer1.Enabled = true;
            //timer1.Start();
            //DateTime t1 = DateTime.Now;

           // dsM.SourceCondition = "rownum <10000";
           // DateTime t2 = DateTime.Now;
            //timer1.Stop();
           // TimeSpan sp = t2.Subtract(t1);
            //double d = sp.TotalMilliseconds;
           // MessageBox.Show(d.ToString(),"" );

            strWeightSQL += " GROUP BY tap_no order by tap_no";
            dsWeight.SourceMethod = strWeightSQL;
        }
        public int tt = 0;
        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("铁水信息", dvM);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tt++;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string strSql = "call xgmes.Change_irontie()";
            MESTool.exeSql(Adapter, strSql);
            MessageBox.Show("操作完成！");
        }
    }
}