using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.BulkStore
{
    public partial class BulkStoreMag : DockContent, IMESForm
    {
        public BulkStoreMag()
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

        private BulkBalanceFrm BulkBalance = new BulkBalanceFrm();
        private BulkChangeFrm BulkChange = new BulkChangeFrm();
        private InStoreQueryFrm InStoreQuery = new InStoreQueryFrm();
        private OutStoreQueryFrm OutStoreQuery = new OutStoreQueryFrm();
        private BulkRollBackFrm RollBack = new BulkRollBackFrm();

        private void BulkAadAreaMapFrm_Load(object sender, EventArgs e)
        {
            //锁定排序
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvBOF);
        }
        //散状原料维护
        private void btnDefend_Click(object sender, EventArgs e)
        {
            BulkAndAreaMapFrm frm = new BulkAndAreaMapFrm();
            frm.ShowDialogEx(Adapter.Session);
        }
        //散状原料申请
        private void btnApp_Click(object sender, EventArgs e)
        {
            BulkAppFrm frm = new BulkAppFrm();
            frm.ShowDialogEx(Adapter.Session);
        }


        //散状原料上料
        private void btnInStore_Click(object sender, EventArgs e)
        {
            BulkInStoreFrm frm = new BulkInStoreFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ToolTipText
        private void TipText_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            try
            {
                DataGridView dvTip = (DataGridView)sender;
                int iRow = e.RowIndex;
                string strTip = "  C 含量  : " + dvTip.Rows[iRow].Cells[4].Value.ToString();
                strTip += " \r\n  Si含量  : " + dvTip.Rows[iRow].Cells[5].Value.ToString();
                strTip += " \r\n  Mn含量  : " + dvTip.Rows[iRow].Cells[6].Value.ToString();
                strTip += " \r\n  P 含量  : " + dvTip.Rows[iRow].Cells[7].Value.ToString();
                strTip += " \r\n  S 含量  : " + dvTip.Rows[iRow].Cells[8].Value.ToString() + " ";
                e.ToolTipText = strTip;
            }
            catch
            {
                e.ToolTipText = "";
            }
        }

        //界面可见性改变
        private void BulkStoreMag_VisibleChanged(object sender, EventArgs e)
        {
        }

        //关闭窗体
        private void BulkStoreMag_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //散状原料信息导入
        private void btnBulkInput_Click(object sender, EventArgs e)
        {
            BulkInformationInputFrm frm = new BulkInformationInputFrm();
            frm.ShowDialogEx(Adapter.Session);

        }

        //盘库
        private void tsbtnBOFBanlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            BulkBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //转库
        private void tsbtnBOFChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            BulkChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //入库查询
        private void btnInStoreQuery_Click(object sender, EventArgs e)
        {
            InStoreQuery.ShowDialogEx(Adapter.Session);
        }
        //出库查询
        private void btnOutStoreQuery_Click(object sender, EventArgs e)
        {
            OutStoreQuery.ShowDialogEx(Adapter.Session);
        }

        private void tsbtnGroundBanlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGround.Current as System.Data.DataRowView).Row)]);
            BulkBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnGroundChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGround.Current as System.Data.DataRowView).Row)]);
            BulkChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        // BOF2 [12/29/2008 sun]
        private void btnBalance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs2BOF.Current as System.Data.DataRowView).Row)]);
            BulkBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bs2BOF.EndEdit();
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Select("POSITION = '" + dvGround.Rows[bs2BOF.Position]
                .Cells[dataGridViewTextBoxColumn1.Index].Value.ToString() + "'")[0]);//dvGround.Rows[dsStore.Tables[0].Rows.IndexOf((bs2BOF.Current as System.Data.DataRowView).Row)]);
            BulkChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        // BOF3 [12/29/2008 sun]
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs3BOF.Current as System.Data.DataRowView).Row)]);
            BulkBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs3BOF.Current as System.Data.DataRowView).Row)]);
            BulkChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        // BOF4 [12/29/2008 sun]
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs4BOF.Current as System.Data.DataRowView).Row)]);
            BulkBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs4BOF.Current as System.Data.DataRowView).Row)]);
            BulkChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //预约出入库事件,刷新界面数据集dsStore[20090105Liao]
        private void l3dbxGetStore_TextChanged(object sender, EventArgs e)
        {
            dsStore.L3DataAdapter = Adapter;
            dsStore.LoadData();
        }

        private void BulkStoreMag_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void tsbtnBOFClear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void btnBOF2Clear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs2BOF.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void btnBOF3Clear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs3BOF.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void btnBOF4Clear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs4BOF.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void btnGroundClear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGround.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void btnGroundRollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGround.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);

        }

        private void btnBOFRollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnBOF2RollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs2BOF.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnBOF3RollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs3BOF.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnBOF4RollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bs4BOF.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

    }
}