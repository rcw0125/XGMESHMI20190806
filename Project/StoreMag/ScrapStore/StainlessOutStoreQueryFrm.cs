using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace StoreMag.ScrapStore
{
    public partial class StainlessOutStoreQueryFrm : DockContent, IMESForm
    {
        public StainlessOutStoreQueryFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            dsOutStore.SourceCondition = "1=2";
            Adapter.Session = session;
            return this.ShowDialog();
        }

        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //DateTime dtS = Convert.ToDateTime(dtOutStoreData.Text.Trim());
            //DateTime dtE = Convert.ToDateTime(dtOutStoreEndData.Text.Trim() + " 23:59:59");
            dsOutStore.SourceMethod = "select * from VIEW_SCRAP_OUTPUT_LOG1 where 1=2 ";
            //dsOutStore.SourceMethod = "select * from SCRAP_OUTPUT_LOG where 1=2";
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                    dsOutStore.SourceMethod = "select * from VIEW_SCRAP_OUTPUT_LOG1 where to_char(LOGDATE,'yyyy-mm-dd')  =  '" + dtOutStoreData.Text + "' order by LOGDATE desc";
                else
                    dsOutStore.SourceMethod = "select * from VIEW_SCRAP_OUTPUT_LOG1 whereto_char(LOGDATE,'yyyy-mm-dd')  =  '" + dtOutStoreData.Text + "' and HeatID like '%" + txtHeatID.Text.Trim() + "%' order by LOGDATE desc";
            }
            else    //¯�ų���Ϊ    9
                dsOutStore.SourceMethod = "select * from VIEW_SCRAP_OUTPUT_LOG1 where HeatID = '" + txtHeatID.Text.Trim() + "'";

            /*************Modify Begin At 2011-02-16 By Huyunhai   (1#¯-3#¯ �� 4#¯����ɫ����)**********/
            List<int> Flag = new List<int>();

            if (dsOutStore.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
                {
                    string strHeatID = dsOutStore.Tables[0].Rows[i]["HeatID"].ToString();
                    string scrapID = dsOutStore.Tables[0].Rows[i]["SCRAP_SLOT_ID"].ToString();
                    if (strHeatID == "" && scrapID == "")
                        continue;
                    if (scrapID[1].ToString() == "-")
                    {
                        if (scrapID[0].ToString() == "4")
                        {
                            try
                            {
                                Flag.Add(i);
                                continue;

                            }
                            catch { }
                        }
                    }
                    if (strHeatID != "")
                    {
                        if (strHeatID[1].Equals('4'))  //��Ϊ4#ת¯ ����ɫ��Ϊǳ��ɫ
                        {
                            try
                            {
                                Flag.Add(i);

                            }
                            catch { }
                        }
                    }
                }
            }
            //���ı���ɫ
            if (Flag.Count > 0)
            {
                for (int i = 0; i < Flag.Count; i++)
                {
                    //CommDataMag.CommonMethed.SetDataGridViewRowColor("dvInStore",)
                    //dvInStore.Rows[i].DefaultCellStyle.BackColor = CommDataMag.CommonData.Color_Code_Green;
                    dvInStore.Rows[Flag[i]].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
            /**********END**********/
        }

        //�ؼ�����
        private void StainlessOutStoreQueryFrm_Load(object sender, EventArgs e)
        {
            dtOutStoreData.Value = DateTime.Now;
            dtOutStoreEndData.Value = DateTime.Now;
            /*******Modify By Huyunhai 2011-3-25********/

            /*****Modify End****/
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //List<AppSvrHMI.L3DataSet> lFG = new List<AppSvrHMI.L3DataSet>();
            //List<AppSvrHMI.L3DataSet> lST = new List<AppSvrHMI.L3DataSet>();
            //AppSvrHMI.L3DataSet[] arryFG=new AppSvrHMI.L3DataSet[dvInStore];

            //List<AppSvrHMI.L3DataSet> lFG = new List<AppSvrHMI.L3DataSet>();
            //List<AppSvrHMI.L3DataSet> lST = new List<AppSvrHMI.L3DataSet>();

            DataSet[] lFG = new DataSet[dvInStore.Rows.Count];
            DataSet[] lST = new DataSet[dvInStore.Rows.Count];

            for (int i = 0; i < dvInStore.Rows.Count; i++)
            {
               

                dsST1.Clear();
                dsFG1.Clear();
                string SCRAP_SLOT_ID = dvInStore["scrapSlotIDDataGridViewTextBoxColumn", i].Value.ToString();
                //string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
                //string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
                string SQL1 = "SELECT b.Code_Des as Name,a.AMOUNT FROM CSCRAPOUTSTOREDETAIL a,CBASE_ALL_CODE b WHERE a.MATERIAL='ScrapGroupName' AND a.SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' and a.MATERIAL_CODE=b.CODE and b.CODE_GROUP='ScrapGroupName'";
                string SQL2 = "SELECT b.Code_Des as Name,a.AMOUNT FROM CSCRAPOUTSTOREDETAIL a,CBASE_ALL_CODE b WHERE a.MATERIAL='PigIronGroupName' AND a.SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' and a.MATERIAL_CODE=b.CODE and b.CODE_GROUP='PigIronGroupName' ";
                dsFG1.SourceMethod = SQL1;
                dsST1.SourceMethod = SQL2;
                dsFG1.LoadData();
                dsST1.LoadData();
                //System.Data.DataSet ds1 = dsFG1.Copy();
                //System.Data.DataSet ds2 = dsST1.Copy();
                //ds1 = (System.Data.DataSet)dsFG1;
                //ds2 = (System.Data.DataSet)dsST1;

                //lFG.Add(ds1);
                //lST.Add(ds2);
                DataSet ds1 = new DataSet();
                ds1 = (DataSet)dsFG1.Copy();
                DataSet ds2 = new DataSet();
                ds2 = (DataSet)dsST1.Copy();

                lFG[i] = ds1;
                lST[i] = ds2;

            }

          

            CommDataMag.CommonMethed.PutIntoExcelForFGFL("�ϸֳ�����Ϣ", dvInStore,lFG,lST);
        }

        private void StainlessOutStoreQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //
        private void dvInStore_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {


        }

        private void dvInStore_Click(object sender, EventArgs e)
        {
            if (dvInStore.CurrentRow == null)
            {
                dsFG.SourceMethod = "";
                dsST.SourceMethod = "";
                return;
            }
            if (dvInStore.CurrentRow.Cells["scrapSlotIDDataGridViewTextBoxColumn"].Value == null)
                return;
            string SCRAP_SLOT_ID = dvInStore.CurrentRow.Cells["scrapSlotIDDataGridViewTextBoxColumn"].Value.ToString();
            //dsFG.SourceCondition = "MATERIAL=\"ScrapGroupName\" and SCRAP_SLOT_ID=\"" + SCRAP_SLOT_ID +"\"";
            //dsST.SourceCondition = "MATERIAL=\"PigIronGroupName\" and SCRAP_SLOT_ID=\"" + SCRAP_SLOT_ID + "\"";
            string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            dsFG.SourceMethod = SQL1;
            dsST.SourceMethod = SQL2;
            //dsST.SourceCondition = SQL2;
            //dsFG.SourceCondition = SQL1;

        }

        //�����м� gridView
        private void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView ss = (DataGridView)sender;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X - 10, e.RowBounds.Location.Y,
                ss.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                ss.RowHeadersDefaultCellStyle.Font, rectangle,
                ss.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        private void dvInStore_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dvInStore.CurrentRow == null)
            {
                dsFG.Tables[0].Clear();
                dsST.Tables[0].Clear();
            }
            else
                dvInStore_Click(sender, e);
        }

        // ��������ʱ����
        private void dvInStore_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            /*************Modify Begin At 2011-02-16 By Huyunhai   (1#¯-3#¯ �� 4#¯����ɫ����)**********/
            List<string> Flag = new List<string>();

            if (dsOutStore.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
                {
                    string strHeatID = dsOutStore.Tables[0].Rows[i]["HeatID"].ToString();
                    if (strHeatID == "")
                        continue;
                    if (strHeatID[1].Equals('4'))  //��Ϊ4#ת¯ ����ɫ��Ϊǳ��ɫ
                    {
                        try
                        {
                            Flag.Add(strHeatID);

                        }
                        catch { }
                    }
                }
            }
            //���ı���ɫ
            //if (Flag.Count > 0)
            //{
            //    for (int i = 0; i < Flag.Count; i++)
            //    {
            //        //CommDataMag.CommonMethed.SetDataGridViewRowColor("dvInStore",)
            //        //dvInStore.Rows[i].DefaultCellStyle.BackColor = CommDataMag.CommonData.Color_Code_Green;
            //        dvInStore.Rows[Flag[i]].DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //}

            for (int i = 0; i < dsOutStore.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < Flag.Count; j++)
                {
                    if (dvInStore[5, i].Value.ToString() == Flag[j])
                    {
                        dvInStore.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                        continue;
                    }
                }
            }
            /**********END**********/
        }



    }
}