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
    public partial class PathMagFrm : DockContent, IMESForm
    {
        public PathMagFrm()
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

        //IronDestinationMag

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //指定去向
        private void btnDegiate_Click(object sender, EventArgs e)
        {
            PathInfoFrm Frm = new PathInfoFrm();
            Frm.ShowDialogEx(Adapter.Session, bsMain.Position, ref dsMain);
        }

        //撤销指定
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dsMain.Tables[0].Rows[bsMain.Position]["Destination"] = (long)0;
        }

        //刷新
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dsMain.LoadData();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dsMain.UpdateData();
            dsMain.LoadData();
        }

        private void btnReSendNC_Click(object sender, EventArgs e)
        {
            // 将选中的铸铁铁水信息重发NC
            DataSet dsCastIrons = dsMain.Clone();
            foreach (DataGridViewRow row in dvM.Rows)
            {
                if (row.Selected)
                {
                    if((int)dsMain.Tables[0].Rows[row.Index]["Destination"] == 2)
                        dsCastIrons.Tables[0].ImportRow(dsMain.Tables[0].Rows[row.Index]);
                }
            }
            if (dsCastIrons.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show("请选择至少一条去向为铸铁的铁水.");
                return;
            }
            l3cmdReSendNC.Parameters[0].SourceObject = dsCastIrons;
            int iRet = l3cmdReSendNC.Execute();
            if (iRet != 0 || 0 > (int)l3cmdReSendNC.Command.Return)
            {
                MessageBox.Show(string.Format("发送失败！错误代码：{0:X},{1}", l3cmdReSendNC.Command.ErrorCode,(int)l3cmdReSendNC.Command.Return));
            }
        }

        private void dvM_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}