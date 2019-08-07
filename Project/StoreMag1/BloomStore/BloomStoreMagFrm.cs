using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace StoreMag.BloomStore
{
    public partial class BloomStoreMagFrm : DockContent, IMESForm
    {
        public BloomStoreMagFrm()
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

        BloomInStoreFrm frmInStore = new BloomInStoreFrm();
        BloomOnStoreMagFrm frmQualityCheck = new BloomOnStoreMagFrm();
        BloomSpileChangeFrm frmSpileChange = new BloomSpileChangeFrm();
        BloomOnStoreMagFrm frmOnStoreMag = new BloomOnStoreMagFrm();
        BloomStoreQueryFrm frmStoreQuery = new BloomStoreQueryFrm();
        BloomOutStoreFrm frmOutStore = new BloomOutStoreFrm();
        InStoreQueryFrm frmInStoreQuery = new InStoreQueryFrm();
        OutStoreQueryFrm frmOutStoreQuery = new OutStoreQueryFrm();
        
        //入库
        private void btnInStore_Click(object sender, EventArgs e)
        {
            //dvCaster01.EndEdit();
            //dvCaster02.EndEdit();
            dvCaster03.EndEdit();
            dvCaster04.EndEdit();
            dvCaster05.EndEdit();
            //bsCaster01.EndEdit();
            //bsCaster02.EndEdit();
            bsCaster03.EndEdit();
            bsCaster04.EndEdit();
            bsCaster05.EndEdit();

            /**************Modify Begin At 2011-02-21 By Huyunhai**************/
            dvCaster07.EndEdit();
            bsCaster07.EndEdit();
            /********END********/

            /**************Modify Begin At 2012-06-12 By hyh**************/
            dvCaster06.EndEdit();
            bsCaster06.EndEdit();
            /********END********/
            
            dsBloomSend.Tables[0].Clear();
            for (int i = 0; i < dsBloom.Tables[0].Rows.Count; i++) 
            {
                if (dsBloom.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsBloomSend.Tables[0].ImportRow(dsBloom.Tables[0].Rows[i]);
                }
            }
            dsBloomSend.AcceptChanges();
            frmInStore.ShowDialogEx(Adapter.Session, dsBloomSend);
            dsBloom.LoadData();
        }

        //钢坯库管理
        private void btnQualityCheck_Click(object sender, EventArgs e)
        {
            frmQualityCheck.ShowDialogEx(Adapter.Session);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOnStoreMag.ShowDialogEx(Adapter.Session);
        }

        //库存查询
        private void btnStoreQuery_Click(object sender, EventArgs e)
        {
            frmStoreQuery.ShowDialogEx(Adapter.Session);
        }

        private void dbxBloomOffLineEvent_TextChanged ( object sender , EventArgs e )
        {
            dsBloom.LoadData();
        }

        //出库
        private void btnOutStore_Click(object sender, EventArgs e)
        {
            dvCaster06.EndEdit();
            dvCaster02.EndEdit();
            dvCaster03.EndEdit();
            dvCaster04.EndEdit();
            dvCaster05.EndEdit();
            bsCaster01.EndEdit();
            bsCaster02.EndEdit();
            bsCaster03.EndEdit();
            bsCaster04.EndEdit();
            bsCaster05.EndEdit();

            /**************Modify Begin At 2011-02-21 By Huyunhai**************/
            dvCaster07.EndEdit();
            bsCaster07.EndEdit();
            /********END********/

            dsBloomSend.Tables[0].Clear();
            for (int i = 0; i < dsBloom.Tables[0].Rows.Count; i++)
            {
                if (dsBloom.Tables[0].Rows[i]["CheckFlag"].ToString() == "1")
                {
                    dsBloomSend.Tables[0].ImportRow(dsBloom.Tables[0].Rows[i]);
                }
            }
            dsBloomSend.AcceptChanges();
            frmOutStore.ShowDialogEx(Adapter.Session, dsBloomSend);
            dsBloom.LoadData();
        }

        //入库查询
        private void btnInStoreQuery_Click(object sender, EventArgs e)
        {
            frmInStoreQuery.ShowDialogEx(Adapter.Session);
        }

        //出库查询
        private void btnOutStoreQuery_Click(object sender, EventArgs e)
        {
            frmOutStoreQuery.ShowDialogEx(Adapter.Session);
        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
                                                          
        private void dvCaster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strHeatID = "";
            //DataGridView dvSelect = (DataGridView)sender;
            //if (e.RowIndex < 0)
            //    strHeatID = "";
            //else
            //    strHeatID = dvSelect.Rows[e.RowIndex].Cells[1].Value.ToString();
       
            string strsenderName = ((DataGridView)sender).Name;

            switch (strsenderName)
            {
                case "dvCaster01":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster06.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "dvCaster02":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster02.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "dvCaster03":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster03.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "dvCaster04":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster04.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "dvCaster05":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster05.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;

                 /**************Modify Begin At 2011-02-21 By Huyunhai**************/
                case "dvCaster07":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster05.Rows[e.RowIndex].Cells[1].Value.ToString();//取炉号
                    break;
                /********END********/

                /**************Modify Begin At 2011-06-12 By hyh**************/
                case "dvCaster06":
                    if (e.RowIndex < 0)
                        strHeatID = "";
                    else
                        strHeatID = dvCaster06.Rows[e.RowIndex].Cells[1].Value.ToString();//取炉号
                    break;
                /********END********/


                default:
                    break;
            }
            bsInfo.Filter = "MATERIALID = '" + strHeatID + "'";       //bsinfo 的过滤条件
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strsenderName = ((ComboBox)sender).Name;
            switch (strsenderName)
            {
                case "cmbWasterReason1":
                    lbWasterReason1.Text = cmbWasterReason1.Text;
                    break;
                case "cmbWasterReason2":
                    lbWasterReason2.Text = cmbWasterReason2.Text;
                    break;
                case "cmbWasterReason3":
                    lbWasterReason3.Text = cmbWasterReason3.Text;
                    break;
                case "cmbWrongReason1":
                    lbWrongReason1.Text = cmbWrongReason1.Text;
                    break;
                case "cmbWrongReason2":
                    lbWrongReason2.Text = cmbWrongReason2.Text;
                    break;
                case "cmbWrongReason3":
                    lbWrongReason3.Text = cmbWrongReason3.Text;
                    break;
                case "cmbOffLineReason":
                    lbOffLineReason.Text = cmbOffLineReason.Text;
                    break;
                default:
                    break;
            }
        }

        private void BloomStoreMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        
    }
}