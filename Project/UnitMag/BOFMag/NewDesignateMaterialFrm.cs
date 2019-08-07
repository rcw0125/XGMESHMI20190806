using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.BOFMag
{
    public partial class NewDesignateMaterialFrm : Form
    {
        public NewDesignateMaterialFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            
            Adapter.set_URIParameters("BOFID", UnitID);
            Adapter.Session = session;

            return ShowDialog();
        }

        //private void dvIronInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    //
        //}

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //指定
        private void btnAssign_Click(object sender, EventArgs e)
        {
            
            dvIronInfo.EndEdit();
            bsIronInfo.EndEdit();
            dvScrapSteel.EndEdit();
            bsScrapSteel.EndEdit();
            dsReturnSteel.AcceptChanges();
            DataSet ds1 = (DataSet)cmdDesignateMainMat.Parameters[0].Value;
            DataSet ds2 = (DataSet)cmdDesignateMainMat.Parameters[1].Value;
            DataSet ds3 = (DataSet)cmdDesignateMainMat.Parameters[2].Value;

            string strYesNo = MessageBox.Show("确认所选主原料?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            
            if (strYesNo == "Yes")
            {
                //[2009-02-28 sun]
                int iRet = cmdDesignateMainMat.Execute();
                string strError = cmdDesignateMainMat.Command.Return.ToString();
                if (iRet != 0 || (int)cmdDesignateMainMat.Command.Return < 0)
                {
                   // string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsErrorCode, strError);
                    //MessageBox.Show(string.Format("指定主原料失败！" + strReasultShow));
                    MessageBox.Show(string.Format("指定主原料失败！"));
                }
                else
                {
                    MessageBox.Show("指定主原料成功！", "提示");
                    this.Close();
                }
            }
        }

        private void NewDesignateMaterialFrm_Load(object sender, EventArgs e)
        {
            /*************Modify Begin At 2011-03-24 By Huyunhai   (1#炉-3#炉 和 4#炉用颜色区分)**********/
            List<int> Flag = new List<int>();

            if (dsScrapSteel.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsScrapSteel.Tables[0].Rows.Count; i++)
                {
                    string strHeatID = dsScrapSteel.Tables[0].Rows[i]["HeatID"].ToString();
                    string scrapID = dsScrapSteel.Tables[0].Rows[i]["SCRAP_SLOT_ID"].ToString();
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
                    dvScrapSteel.Rows[Flag[i]].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
            /**********END**********/


            //dsSteelGrade.LoadData();
            dsReturnSteel.Tables[0].Clear();
            DataRow newrow = dsReturnSteel.Tables[0].NewRow();
            newrow["HeatID"] = txtHeatID.Text;
            newrow["Return_Steel_Weight"] = "0";
            dsReturnSteel.Tables[0].Rows.Add(newrow);
        }

        private void dvScrapSteel_Click(object sender, EventArgs e)
        {
            if (dvScrapSteel.CurrentRow == null)
            {
                dsFG.SourceMethod = "";
                dsST.SourceMethod = "";
                return;
            }
            if (dvScrapSteel.CurrentRow.Cells["scrapSlotIDDataGridViewTextBoxColumn"].Value == null)
                return;
            string sql0 = "select code,code_des from cbase_all_code where CODE_GROUP='ScrapGroupName' or CODE_GROUP='PigIronGroupName'";
            string SCRAP_SLOT_ID = dvScrapSteel.CurrentRow.Cells["scrapSlotIDDataGridViewTextBoxColumn"].Value.ToString();
            string SQL1 = "SELECT a.*,b.code_des FROM CSCRAPOUTSTOREDETAIL a,cbase_all_code b WHERE a.MATERIAL='ScrapGroupName' AND a.SCRAP_SLOT_ID='" + SCRAP_SLOT_ID +"' and a.MATERIAL_CODE = b.code";
            string SQL2 = "SELECT a.*,b.code_des FROM CSCRAPOUTSTOREDETAIL a,cbase_all_code b WHERE a.MATERIAL='PigIronGroupName' AND a.SCRAP_SLOT_ID='" + SCRAP_SLOT_ID + "' and a.MATERIAL_CODE = b.code";
            dsFGST.SourceMethod = sql0;
            dsFG.SourceMethod = SQL1;
            dsST.SourceMethod = SQL2;
        }

        private void dvScrapSteel_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dvScrapSteel.CurrentRow == null)
            {
                dsFG.Tables[0].Clear();
                dsST.Tables[0].Clear();
                dsFGST.Tables[0].Clear();
            }
            else
                dvScrapSteel_Click(sender, e);
        }

       
       

    }
}