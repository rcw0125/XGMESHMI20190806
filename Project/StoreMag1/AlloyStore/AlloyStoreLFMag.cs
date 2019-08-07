using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.AlloyStore
{
    public partial class AlloyStoreLFMag : DockContent, IMESForm
    {
        public AlloyStoreLFMag()
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

        private AlloyBalanceFrm AlloyBalance = new AlloyBalanceFrm();
        private AlloyChangeFrm AlloyChange = new AlloyChangeFrm();
        private InStoreQueryFrm InStoreQuery = new InStoreQueryFrm();
        private OutStoreQueryFrm OutStoreQuery = new OutStoreQueryFrm();
        private AlloyOutStoreFrm OutStore = new AlloyOutStoreFrm();
        private AlloyRollBackFrm RollBack = new AlloyRollBackFrm();

        private void AlloyAadAreaMapFrm_Load(object sender, EventArgs e)
        {
            //锁定排序
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvBOF);
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvLF01);
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvLF02);
            CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvGroundPublic);
            //CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvWireLF1);
            //CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvWireLF2);
            //CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvGroundLF1);
            //CommDataMag.CommonMethed.SetdvColumnSortNotSortable(dvGroundLF2);
        }

        //合金维护
        private void btnDefend_Click(object sender, EventArgs e)
        {
            AlloyAndAreaMapFrm frm = new AlloyAndAreaMapFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //合金申请
        private void btnApp_Click(object sender, EventArgs e)
        {
            AlloyAppFrm frm = new AlloyAppFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //合金上料
        private void btnInStore_Click(object sender, EventArgs e)
        {
            AlloyInStoreFrm frm = new AlloyInStoreFrm();
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
                string strBatchID = dvTip.Rows[e.RowIndex].Cells[2].Value.ToString();
                DataRow[] DataRowTempTotal = dsStore.Tables[0].Select("BATCH_ID = '" + strBatchID + "'");
                int iRow = dsStore.Tables[0].Rows.IndexOf(DataRowTempTotal[0]);
                //string strTip = " C 含量 : " + dsStore.Tables[0].Rows[iRow]["C"].ToString();
                //strTip += "\r\n Si含量 : " + dsStore.Tables[0].Rows[iRow]["Si"].ToString();
                //strTip += "\r\n Mn含量 : " + dsStore.Tables[0].Rows[iRow]["Mn"].ToString();
                //strTip += "\r\n P 含量 : " + dsStore.Tables[0].Rows[iRow]["P"].ToString();
                //strTip += "\r\n S 含量 : " + dsStore.Tables[0].Rows[iRow]["S"].ToString();
                //strTip += "\r\n Cu含量 : " + dsStore.Tables[0].Rows[iRow]["Cu"].ToString();
                //strTip += "\r\n Ni含量 : " + dsStore.Tables[0].Rows[iRow]["Ni"].ToString();
                //strTip += "\r\n Cr含量 : " + dsStore.Tables[0].Rows[iRow]["Cr"].ToString();
                //strTip += "\r\n Mo含量 : " + dsStore.Tables[0].Rows[iRow]["Mo"].ToString();
                //strTip += "\r\n V 含量 : " + dsStore.Tables[0].Rows[iRow]["V"].ToString();
                //strTip += "\r\n Nb含量 : " + dsStore.Tables[0].Rows[iRow]["Nb"].ToString();
                //strTip += "\r\n Al含量 : " + dsStore.Tables[0].Rows[iRow]["Al"].ToString();
                //strTip += "\r\n AlS含量: " + dsStore.Tables[0].Rows[iRow]["AlS"].ToString();
                //strTip += "\r\n Ti含量 : " + dsStore.Tables[0].Rows[iRow]["Ti"].ToString();
                //strTip += "\r\n B 含量 : " + dsStore.Tables[0].Rows[iRow]["B"].ToString();
                //strTip += "\r\n Sb含量 : " + dsStore.Tables[0].Rows[iRow]["Sb"].ToString();
                //strTip += "\r\n As含量 : " + dsStore.Tables[0].Rows[iRow]["As"].ToString();
                //strTip += "\r\n Sn含量 : " + dsStore.Tables[0].Rows[iRow]["Sn"].ToString();
                //strTip += "\r\n Zn含量 : " + dsStore.Tables[0].Rows[iRow]["Zn"].ToString();
                //strTip += "\r\n Ca含量 : " + dsStore.Tables[0].Rows[iRow]["Ca"].ToString();
                //strTip += "\r\n W 含量 : " + dsStore.Tables[0].Rows[iRow]["W"].ToString();
                //strTip += "\r\n Pb含量 : " + dsStore.Tables[0].Rows[iRow]["Pb"].ToString();
                //strTip += "\r\n Re含量 : " + dsStore.Tables[0].Rows[iRow]["Re"].ToString();
                //strTip += "\r\n Ceq含量: " + dsStore.Tables[0].Rows[iRow]["Ceq"].ToString();
                //strTip += "\r\n N含量  : " + dsStore.Tables[0].Rows[iRow]["N"].ToString();
                //strTip += "\r\n H含量  : " + dsStore.Tables[0].Rows[iRow]["H"].ToString();
                //strTip += "\r\n O含量  : " + dsStore.Tables[0].Rows[iRow]["O"].ToString();
                //strTip += "\r\n CrNi含量  : " + dsStore.Tables[0].Rows[iRow]["CrNi"].ToString();
                //strTip += "\r\n CrCu含量  : " + dsStore.Tables[0].Rows[iRow]["CrCu"].ToString();
                //strTip += "\r\n CrNiCu含量  : " + dsStore.Tables[0].Rows[iRow]["CrNiCu"].ToString();
                //strTip += "\r\n TFe含量  : " + dsStore.Tables[0].Rows[iRow]["TFe"].ToString();
                //strTip += "\r\n FeO含量  : " + dsStore.Tables[0].Rows[iRow]["FeO"].ToString();
                //strTip += "\r\n SiO2含量  : " + dsStore.Tables[0].Rows[iRow]["SiO2"].ToString();
                //strTip += "\r\n TCa含量  : " + dsStore.Tables[0].Rows[iRow]["TCa"].ToString();
                //strTip += "\r\n CaO含量  : " + dsStore.Tables[0].Rows[iRow]["CaO"].ToString();
                //strTip += "\r\n MgO含量  : " + dsStore.Tables[0].Rows[iRow]["MgO"].ToString();
                //strTip += "\r\n Al2O3含量  : " + dsStore.Tables[0].Rows[iRow]["Al2O3"].ToString();
                //strTip += "\r\n MnO含量  : " + dsStore.Tables[0].Rows[iRow]["MnO"].ToString();
                //strTip += "\r\n TiO2含量  : " + dsStore.Tables[0].Rows[iRow]["TiO2"].ToString();
                //strTip += "\r\n P2O5含量  : " + dsStore.Tables[0].Rows[iRow]["P2O5"].ToString();
                //strTip += "\r\n R含量  : " + dsStore.Tables[0].Rows[iRow]["R"].ToString();
                //strTip += "\r\n Other1含量 : " + dsStore.Tables[0].Rows[iRow]["Other1"].ToString();
                //strTip += "\r\n Other2含量 : " + dsStore.Tables[0].Rows[iRow]["Other2"].ToString();
                string strTip = " C : " + dsStore.Tables[0].Rows[iRow]["C"].ToString().PadRight(12);
                strTip += " TFe : " + dsStore.Tables[0].Rows[iRow]["TFe"].ToString().PadRight(8);

                strTip += "\r\n Si : " + dsStore.Tables[0].Rows[iRow]["Si"].ToString().PadRight(11);
                strTip += " FeO : " + dsStore.Tables[0].Rows[iRow]["FeO"].ToString().PadRight(8);

                strTip += "\r\n Mn : " + dsStore.Tables[0].Rows[iRow]["Mn"].ToString().PadRight(11);
                strTip += " SiO2 : " + dsStore.Tables[0].Rows[iRow]["SiO2"].ToString().PadRight(8);

                strTip += "\r\n P : " + dsStore.Tables[0].Rows[iRow]["P"].ToString().PadRight(12);
                strTip += " TCa : " + dsStore.Tables[0].Rows[iRow]["TCa"].ToString().PadRight(8);

                strTip += "\r\n S : " + dsStore.Tables[0].Rows[iRow]["S"].ToString().PadRight(12);
                strTip += " CaO : " + dsStore.Tables[0].Rows[iRow]["CaO"].ToString().PadRight(8);

                strTip += "\r\n Cu : " + dsStore.Tables[0].Rows[iRow]["Cu"].ToString().PadRight(11);
                strTip += " MgO : " + dsStore.Tables[0].Rows[iRow]["MgO"].ToString().PadRight(8);

                strTip += "\r\n Ni : " + dsStore.Tables[0].Rows[iRow]["Ni"].ToString().PadRight(11);
                strTip += " Al2O3 : " + dsStore.Tables[0].Rows[iRow]["Al2O3"].ToString().PadRight(8);

                strTip += "\r\n Cr : " + dsStore.Tables[0].Rows[iRow]["Cr"].ToString().PadRight(11);
                strTip += " MnO : " + dsStore.Tables[0].Rows[iRow]["MnO"].ToString().PadRight(8);

                strTip += "\r\n Mo : " + dsStore.Tables[0].Rows[iRow]["Mo"].ToString().PadRight(11);
                strTip += " TiO2 : " + dsStore.Tables[0].Rows[iRow]["TiO2"].ToString().PadRight(8);

                strTip += "\r\n V : " + dsStore.Tables[0].Rows[iRow]["V"].ToString().PadRight(12);
                strTip += " P2O5 : " + dsStore.Tables[0].Rows[iRow]["P2O5"].ToString().PadRight(8);

                strTip += "\r\n Nb : " + dsStore.Tables[0].Rows[iRow]["Nb"].ToString().PadRight(11);
                strTip += " R : " + dsStore.Tables[0].Rows[iRow]["R"].ToString().PadRight(8);

                strTip += "\r\n Al : " + dsStore.Tables[0].Rows[iRow]["Al"].ToString().PadRight(11);
                strTip += " AD : " + dsStore.Tables[0].Rows[iRow]["AD"].ToString().PadRight(8);

                strTip += "\r\n AlS : " + dsStore.Tables[0].Rows[iRow]["AlS"].ToString().PadRight(10);
                strTip += " Ni_Co : " + dsStore.Tables[0].Rows[iRow]["Ni_Co"].ToString().PadRight(8);

                strTip += "\r\n Ti : " + dsStore.Tables[0].Rows[iRow]["Ti"].ToString().PadRight(11);
                strTip += " H2O : " + dsStore.Tables[0].Rows[iRow]["H2O"].ToString().PadRight(8);

                strTip += "\r\n B : " + dsStore.Tables[0].Rows[iRow]["B"].ToString().PadRight(12);
                strTip += " SSL : " + dsStore.Tables[0].Rows[iRow]["SSL"].ToString().PadRight(8);

                strTip += "\r\n Sb : " + dsStore.Tables[0].Rows[iRow]["Sb"].ToString().PadRight(11);
                strTip += " FE2O3 : " + dsStore.Tables[0].Rows[iRow]["FE2O3"].ToString().PadRight(8);

                strTip += "\r\n As : " + dsStore.Tables[0].Rows[iRow]["As"].ToString().PadRight(11);
                strTip += " G_C : " + dsStore.Tables[0].Rows[iRow]["G_C"].ToString().PadRight(8);

                strTip += "\r\n Sn : " + dsStore.Tables[0].Rows[iRow]["Sn"].ToString().PadRight(11);
                strTip += " RD : " + dsStore.Tables[0].Rows[iRow]["RD"].ToString().PadRight(8);

                strTip += "\r\n Zn : " + dsStore.Tables[0].Rows[iRow]["Zn"].ToString().PadRight(11);
                strTip += " Ba : " + dsStore.Tables[0].Rows[iRow]["Ba"].ToString().PadRight(8);

                strTip += "\r\n Ca : " + dsStore.Tables[0].Rows[iRow]["Ca"].ToString().PadRight(11);
                strTip += " HFF : " + dsStore.Tables[0].Rows[iRow]["HFF"].ToString().PadRight(8);

                strTip += "\r\n W : " + dsStore.Tables[0].Rows[iRow]["W"].ToString().PadRight(12);
                strTip += " Sic : " + dsStore.Tables[0].Rows[iRow]["Sic"].ToString().PadRight(8);

                strTip += "\r\n Pb : " + dsStore.Tables[0].Rows[iRow]["Pb"].ToString().PadRight(11);
                strTip += " Si_SiO2 : " + dsStore.Tables[0].Rows[iRow]["Si_SiO2"].ToString().PadRight(8);

                strTip += "\r\n Re : " + dsStore.Tables[0].Rows[iRow]["Re"].ToString().PadRight(11);
                strTip += " Y_C : " + dsStore.Tables[0].Rows[iRow]["Y_C"].ToString().PadRight(8);

                strTip += "\r\n Ceq : " + dsStore.Tables[0].Rows[iRow]["Ceq"].ToString().PadRight(10);
                strTip += " Ca_MgO : " + dsStore.Tables[0].Rows[iRow]["Ca_MgO"].ToString().PadRight(8);

                strTip += "\r\n N : " + dsStore.Tables[0].Rows[iRow]["N"].ToString().PadRight(12);
                strTip += " K2O_Na2O : " + dsStore.Tables[0].Rows[iRow]["K2O_Na2O"].ToString().PadRight(8);

                strTip += "\r\n H : " + dsStore.Tables[0].Rows[iRow]["H"].ToString().PadRight(12);
                strTip += "\r\n O : " + dsStore.Tables[0].Rows[iRow]["O"].ToString().PadRight(12);
                strTip += "\r\n CrNi : " + dsStore.Tables[0].Rows[iRow]["CrNi"].ToString().PadRight(9);
                strTip += "\r\n CrCu : " + dsStore.Tables[0].Rows[iRow]["CrCu"].ToString().PadRight(9);
                strTip += "\r\n CrNiCu : " + dsStore.Tables[0].Rows[iRow]["CrNiCu"].ToString().PadRight(7);

                e.ToolTipText = strTip;
            }
            catch
            {
                e.ToolTipText = "";
            }
        }

        //界面可见性改变
        private void AlloyStoreLFMag_VisibleChanged(object sender, EventArgs e)
        {

        }

        //关闭窗体
        private void AlloyStoreLFMag_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        //合金信息导入
        private void btnAlloyInput_Click(object sender, EventArgs e)
        {
            AlloyInformationInputFrm frm = new AlloyInformationInputFrm();
            frm.ShowDialogEx(Adapter.Session);

        }

        private void tsbtnLF01Balance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF01.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLF01Change_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF01.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLF02Banlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF02.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLF02Change_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF02.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLFPublicBanlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnLFPublicChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnBOFBanlance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void tsbtnBOFChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
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

        //private void tsbtnGroundBanlance_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF1.Current as System.Data.DataRowView).Row)]);
        //    AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void tsbtnGroundChange_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF1.Current as System.Data.DataRowView).Row)]);
        //    if (dsStoreSend.Tables[0].Rows[0]["AMOUNT"].ToString() != "")
        //    {
        //        OutStore.ShowDialogEx(Adapter.Session, dsStoreSend);
        //    }

        //}

        //private void btnWireBalance_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF1.Current as System.Data.DataRowView).Row)]);
        //    AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        private void dvFire_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //预约出入库事件,刷新界面数据集dsStore[20090105Liao]
        private void l3dbxGetStore_TextChanged(object sender, EventArgs e)
        {
            dsStore.LoadData();
        }

        private void AlloyStoreLFMag_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void tsbtnLF01Clear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF01.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void tsbtnLF02Clear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF02.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        private void tsbtnLFPublicClear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
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
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }

        //private void tsbtnGroundClear_Click(object sender, EventArgs e)
        //{
        //    dsClear.Tables[0].Clear();
        //    dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF1.Current as System.Data.DataRowView).Row)]);
        //    string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示", MessageBoxButtons.OKCancel).ToString();
        //    if (check == "OK")
        //    {
        //        if (cmdClear.Execute() >= 0)
        //        {
        //            if (Convert.ToInt32(cmdClear.Command.Return) == 0)
        //            {
        //                MessageBox.Show("操作成功！", "提示");
        //                dsStore.LoadData();
        //            }
        //            else
        //            {
        //                MessageBox.Show("操作不成功!", "提示");
        //            }
        //        }
        //    }
        //}

        //private void btnWireClear_Click(object sender, EventArgs e)
        //{
        //    dsClear.Tables[0].Clear();
        //    dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF1.Current as System.Data.DataRowView).Row)]);
        //    string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示", MessageBoxButtons.OKCancel).ToString();
        //    if (check == "OK")
        //    {
        //        if (cmdClear.Execute() >= 0)
        //        {
        //            if (Convert.ToInt32(cmdClear.Command.Return) == 0)
        //            {
        //                MessageBox.Show("操作成功！", "提示");
        //                dsStore.LoadData();
        //            }
        //            else
        //            {
        //                MessageBox.Show("操作不成功!", "提示");
        //            }
        //        }
        //    }
        //}

        private void bsGroundLF1_CurrentChanged(object sender, EventArgs e)
        {

        }

        //1#2#LF袋状合金
        private void btnGroundPublicBalance_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundPublic.Current as System.Data.DataRowView).Row)]);
            AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnGroundPublicChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundPublic.Current as System.Data.DataRowView).Row)]);
            if (dsStoreSend.Tables[0].Rows[0]["AMOUNT"].ToString() != "")
            {
                OutStore.ShowDialogEx(Adapter.Session, dsStoreSend);
            }
        }

        private void btnGroundPublicClear_Click(object sender, EventArgs e)
        {
            dsClear.Tables[0].Clear();
            dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundPublic.Current as System.Data.DataRowView).Row)]);
            string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                if (cmdClear.Execute() >= 0)
                {
                    if (Convert.ToInt32(cmdClear.Command.Return) == 0)
                    {
                        MessageBox.Show("操作成功！", "提示");
                        //dsStore.LoadData();
                    }
                    else
                    {
                        MessageBox.Show("操作不成功!", "提示");
                    }
                }
            }
        }
        //2#LF袋状合金
        //private void btnGroundLF2Balance_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF2.Current as System.Data.DataRowView).Row)]);
        //    AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnGroundLF2Change_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF2.Current as System.Data.DataRowView).Row)]);
        //    if (dsStoreSend.Tables[0].Rows[0]["AMOUNT"].ToString() != "")
        //    {
        //        OutStore.ShowDialogEx(Adapter.Session, dsStoreSend);
        //    }
        //}

        //private void btnGroundLF2Clear_Click(object sender, EventArgs e)
        //{
        //    dsClear.Tables[0].Clear();
        //    dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF2.Current as System.Data.DataRowView).Row)]);
        //    string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示", MessageBoxButtons.OKCancel).ToString();
        //    if (check == "OK")
        //    {
        //        if (cmdClear.Execute() >= 0)
        //        {
        //            if (Convert.ToInt32(cmdClear.Command.Return) == 0)
        //            {
        //                MessageBox.Show("操作成功！", "提示");
        //                dsStore.LoadData();
        //            }
        //            else
        //            {
        //                MessageBox.Show("操作不成功!", "提示");
        //            }
        //        }
        //    }
        //}

        //2#LF喂丝机
        //private void btnWireLF2Balance7_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF2.Current as System.Data.DataRowView).Row)]);
        //    AlloyBalance.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnWireLF2Clear_Click(object sender, EventArgs e)
        //{
        //    dsClear.Tables[0].Clear();
        //    dsClear.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF2.Current as System.Data.DataRowView).Row)]);
        //    string check = MessageBox.Show("此操作将清空该料仓内所有数据，是否清空？", "提示", MessageBoxButtons.OKCancel).ToString();
        //    if (check == "OK")
        //    {
        //        if (cmdClear.Execute() >= 0)
        //        {
        //            if (Convert.ToInt32(cmdClear.Command.Return) == 0)
        //            {
        //                MessageBox.Show("操作成功！", "提示");
        //                dsStore.LoadData();
        //            }
        //            else
        //            {
        //                MessageBox.Show("操作不成功!", "提示");
        //            }
        //        }
        //    }
        //}

        private void btnLF1RollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF01.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnLF2RollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLF02.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnLFPublicRollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsLFPublic.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        private void btnBOFRollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsBOF.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //private void btnGroundLF1RollBack_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF1.Current as System.Data.DataRowView).Row)]);
        //    RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnWireLF1RollBack_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF1.Current as System.Data.DataRowView).Row)]);
        //    RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        private void btnGroundPublicRollBack_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundPublic.Current as System.Data.DataRowView).Row)]);
            RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //private void btnGroundLF2RollBack_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF2.Current as System.Data.DataRowView).Row)]);
        //    RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnWireLF2RollBack_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF2.Current as System.Data.DataRowView).Row)]);
        //    RollBack.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnGroundLF1Change_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF1.Current as System.Data.DataRowView).Row)]);
        //    AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnWireLF1Change_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF1.Current as System.Data.DataRowView).Row)]);
        //    AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        private void btnGroundLFPublicChange_Click(object sender, EventArgs e)
        {
            dsStoreSend.Tables[0].Clear();
            dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundPublic.Current as System.Data.DataRowView).Row)]);
            AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        }

        //private void btnGroundLF2Change_Click_1(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsGroundLF2.Current as System.Data.DataRowView).Row)]);
        //    AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}

        //private void btnWireLF2Change_Click(object sender, EventArgs e)
        //{
        //    dsStoreSend.Tables[0].Clear();
        //    dsStoreSend.Tables[0].ImportRow(dsStore.Tables[0].Rows[dsStore.Tables[0].Rows.IndexOf((bsWireLF2.Current as System.Data.DataRowView).Row)]);
        //    AlloyChange.ShowDialogEx(Adapter.Session, dsStoreSend);
        //}
    }
}