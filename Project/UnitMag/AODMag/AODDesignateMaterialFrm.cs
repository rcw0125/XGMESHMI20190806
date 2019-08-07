using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.AODMag
{
    public partial class AODDesignateMaterialFrm : Form
    {
        public AODDesignateMaterialFrm()
        {
            InitializeComponent();
        }


        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            Adapter.set_URIParameters("AODID", "S25");
            Adapter.Session = session;

            return ShowDialog();
        }

        private void dvIronInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void dvScrapSteel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //ָ��
        private void btnAssign_Click(object sender, EventArgs e)
        {
            
            dvIronInfo.EndEdit();
            bsIronInfo.EndEdit();
            bsScrapSteel.EndEdit();
            dsReturnSteel.AcceptChanges();
            DataSet ds1 = (DataSet)cmdDesignateMainMat.Parameters[0].Value;
            DataSet ds2 = (DataSet)cmdDesignateMainMat.Parameters[1].Value;
            DataSet ds3 = (DataSet)cmdDesignateMainMat.Parameters[2].Value;

            string strYesNo = MessageBox.Show("ȷ����ѡ��ԭ��?", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
            
            if (strYesNo == "Yes")
            {
                //[2009-02-28 sun]
                int iRet = cmdDesignateMainMat.Execute();
                string strError = cmdDesignateMainMat.Command.Return.ToString();
                if (iRet != 0 || (int)cmdDesignateMainMat.Command.Return < 0)
                {
                    //string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsErrorCode, strError);
                    MessageBox.Show("ָ����ԭ��ʧ�ܣ�" + strError);
                    //MessageBox.Show(string.Format("ָ����ԭ��ʧ�ܣ�"));
                }
                else
                {
                    MessageBox.Show("ָ����ԭ�ϳɹ���", "��ʾ");
                    this.Close();
                }
            }
        }

        private void NewDesignateMaterialFrm_Load(object sender, EventArgs e)
        {
            /*************Modify Begin At 2011-03-24 By Huyunhai   (1#¯-3#¯ �� 4#¯����ɫ����)**********/
            //List<int> Flag = new List<int>();

            //if (dsScrapSteel.Tables[0].Rows.Count > 0)
            //{
            //    for (int i = 0; i < dsScrapSteel.Tables[0].Rows.Count; i++)
            //    {
            //        string strHeatID = dsScrapSteel.Tables[0].Rows[i]["HeatID"].ToString();
            //        string scrapID = dsScrapSteel.Tables[0].Rows[i]["SCRAP_SLOT_ID"].ToString();
            //        if (strHeatID == "" && scrapID == "")
            //            continue;
            //        if (scrapID[1].ToString() == "-")
            //        {
            //            if (scrapID[0].ToString() == "4")
            //            {
            //                try
            //                {
            //                    Flag.Add(i);
            //                    continue;

            //                }
            //                catch { }
            //            }
            //        }
            //        if (strHeatID != "")
            //        {
            //            if (strHeatID[1].Equals('4'))  //��Ϊ4#ת¯ ����ɫ��Ϊǳ��ɫ
            //            {
            //                try
            //                {
            //                    Flag.Add(i);
            //                    continue;

            //                }
            //                catch { }
            //            }
            //        }
            //    }
            //}
            ////���ı���ɫ
            //if (Flag.Count > 0)
            //{
            //    for (int i = 0; i < Flag.Count; i++)
            //    {
            //        //CommDataMag.CommonMethed.SetDataGridViewRowColor("dvInStore",)
            //        //dvInStore.Rows[i].DefaultCellStyle.BackColor = CommDataMag.CommonData.Color_Code_Green;
            //        dvScrapSteel.Rows[Flag[i]].DefaultCellStyle.BackColor = Color.GreenYellow;
            //    }
            //}
            ///**********END**********/


            //dsSteelGrade.LoadData();
            dsReturnSteel.Tables[0].Clear();
            DataRow newrow = dsReturnSteel.Tables[0].NewRow();
            newrow["HeatID"] = txtHeatID.Text;
            newrow["Return_Steel_Weight"] = "0";
            dsReturnSteel.Tables[0].Rows.Add(newrow);
        }

       
       

    }
}