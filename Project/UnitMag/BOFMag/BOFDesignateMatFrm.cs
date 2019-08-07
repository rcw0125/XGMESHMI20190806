using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class BOFDesignateMatFrm : Form
    {
        public BOFDesignateMatFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.Session = session;
            return ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvIron.EndEdit();
            bsIron.EndEdit();
            dvScrape.EndEdit();
            bsScrapes.EndEdit();
            dsTurnSteelInfo.AcceptChanges();

            string strYesNo = MessageBox.Show("确认所选主原料?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            if (strYesNo == "Yes")
            {
                //[2009-02-28 sun]
                int iRet = cmdDesignateMainMaterial.Execute();
                string strError = cmdDesignateMainMaterial.Command.Return.ToString();
                if (iRet != 0 || (int)cmdDesignateMainMaterial.Command.Return < 0)
                {
                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsErrorCode, strError);
                    MessageBox.Show(string.Format("指定主原料失败！" + strReasultShow));
                }
                else
                {
                    MessageBox.Show("指定主原料成功！", "提示");
                    this.Close();
                }
            }
        }

        private void BOFDesignateMatFrm_Load(object sender, EventArgs e)
        {
            /*************Modify Begin At 2011-03-24 By Huyunhai   (1#炉-3#炉 和 4#炉用颜色区分)**********/
            List<int> Flag = new List<int>();

            if (dsScrapes.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsScrapes.Tables[0].Rows.Count; i++)
                {
                    string strHeatID = dsScrapes.Tables[0].Rows[i]["HeatID"].ToString();
                    string scrapID = dsScrapes.Tables[0].Rows[i]["SCRAP_SLOT_ID"].ToString();
                    if (strHeatID == ""&&scrapID=="")
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
                        if (strHeatID[1].Equals('4'))  //若为4#转炉 背景色改为浅绿色
                        {
                            try
                            {
                                Flag.Add(i);
                                continue;

                            }
                            catch { }
                        }
                    }
                }
            }
            //更改背景色
            if (Flag.Count > 0)
            {
                for (int i = 0; i < Flag.Count; i++)
                {
                    //CommDataMag.CommonMethed.SetDataGridViewRowColor("dvInStore",)
                    //dvInStore.Rows[i].DefaultCellStyle.BackColor = CommDataMag.CommonData.Color_Code_Green;
                    dvScrape.Rows[Flag[i]].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
            /**********END**********/


            //dsSteelGrade.LoadData();
            dsTurnSteelInfo.Tables[0].Clear();
            DataRow newrow = dsTurnSteelInfo.Tables[0].NewRow();
            newrow["HeatID"] = txtHeatID.Text;
            newrow["Return_Steel_Weight"] = "0";
            dsTurnSteelInfo.Tables[0].Rows.Add(newrow);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*****Modify By Huyunhai 2011-3-25*****/
        private void dvScrape_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            try
            {
                DataGridView dvTip = (DataGridView)sender;
                //string SCRAP_SLOT_ID = dvTip[1, e.RowIndex].Value.ToString();
                string SCRAP_SLOT_ID = dvTip[1,e.RowIndex].Value.ToString();//取出斗号
                if (dsTempt.Tables[0].Rows.Count < 1)
                    return;
                DataRow[] dr = dsTempt.Tables[0].Select("SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "'");
                string strTip = "";
                for (int i = 0; i < dr.Length; i++)
                {
                    string type = dr[i]["MATERIAL"].ToString();//废钢类型
                    if (type.Equals("PigIronGroupName"))
                    {
                        type = "生 铁: ";
                    }
                    else
                    {
                        type = "废 钢: ";
                    }
                    string name1 = dr[i]["MATERIAL_CODE"].ToString();//名称
                    DataRow[] drr = dsFGST.Tables[0].Select("Code='" + name1 + "'");
                    string name = drr[0]["CODE_DES"].ToString();
                    //string name = ((dsFGST.Tables[0].Select("Code='" + name1 + "'")[0])["CODE_DES"]).ToString();
                    string amount = dr[i]["AMOUNT"].ToString();//重量
                    strTip += "\r\n" + type + name + "  " + amount + "  ";
                    strTip += "\r\n" + "   ".PadRight(11);
                }
                e.ToolTipText = strTip;


            }
            catch
            {
                e.ToolTipText = "";
            }
        }

        private void dvIron_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvScrape_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvScrape_Click(object sender, EventArgs e)
        {
            if (dvScrape.CurrentRow == null)
            {
                dsFG.SourceMethod = "";
                dsST.SourceMethod = "";
                return;
            }
            if (dvScrape.CurrentRow.Cells["sCRAPSLOTIDDataGridViewTextBoxColumn"].Value == null)
                return;
            string SCRAP_SLOT_ID = dvScrape.CurrentRow.Cells["sCRAPSLOTIDDataGridViewTextBoxColumn"].Value.ToString();
            string SQL1 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='ScrapGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            string SQL2 = "SELECT * FROM CSCRAPOUTSTOREDETAIL WHERE MATERIAL='PigIronGroupName' AND SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' ";
            dsFG.SourceMethod = SQL1;
            dsST.SourceMethod = SQL2;
        }
        /*****Modify END*****/
    }
}