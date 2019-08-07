using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class Remark : Form
    {
        public Remark()
        {
            InitializeComponent();
           // loadData();
           
        }
        public string maintype;
        AppSvrHMI.L3DataSet ds;

        public void loadData()
        {
            //LFProdArea
            //string sql = "select * from cbase_all_code where CODE_GROUP='"+maintype+"'";
            
            try
            {
               // string sql = "select * from cbase_all_code where CODE_GROUP='LFProdArea'";
                string sql = "select * from cbase_all_code where CODE_GROUP='"+maintype+"'";
                ds = new AppSvrHMI.L3DataSet();
                ds.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
                ds.SourceMethod = sql;
                ds.L3DataAdapter = this.Adapter;
                ds.LoadData();
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cbYuanyin.DataSource = ds;
                    // cbYuanyin.DataMember = "L3DataTable";
                    cbYuanyin.DisplayMember = "L3DataTable.Code_Des";
                }
               // cbYuanyin.DataSource = ds;
               //// cbYuanyin.DataMember = "L3DataTable";
               // cbYuanyin.DisplayMember = "L3DataTable.Code_Des";
               // MessageBox.Show(ds.Tables[0].Rows.Count.ToString());
            }
            catch
            {
                return;
            }
           

        }

         private void cbYuanyin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYuanyin.Text == "")
            {
                return;
            }
            else
            {
                tbGaijin.Text=  GetStrCodeByDesc(ds, "Code_Group_Des", "Code_des", cbYuanyin.Text.Trim());
              
            }
        }
        /// 根据代码描述获取对应代码
        public static string GetStrCodeByDesc(DataSet ds, string Code, string CodeDes, String strDes)
        {
            try
            {
                string strID = "";
                string strCondition = CodeDes + "= '" + strDes + "'";
                DataRow[] DataRowTempTotal = ds.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strID = DataRowTemp[Code].ToString();
                }
                return strID;
            }
            catch { return ""; }
        }

        

        public bool remark(string heatid, string alarmtype, ref string yuanyin, ref string gaijin,string  type,AppSvrIF.Session session)
        {
            tbHeatid.Text = heatid;
            tbAlarmtype.Text = alarmtype;
            cbYuanyin.Text = yuanyin;
            this.Adapter.Session = session;
            maintype = type;
            tbGaijin.Text = gaijin;
            loadData();
            if (ShowDialog() != DialogResult.OK)
                return false;
            yuanyin = cbYuanyin.Text.Trim();
            gaijin = tbGaijin.Text.Trim();
            return true;
        }
        //public bool remark(string heatid, string alarmtype, ref string yuanyin, ref string gaijin)
        //{
        //    tbHeatid.Text = heatid;
        //    tbAlarmtype.Text = alarmtype;
        //    tbYuanyin.Text = yuanyin;
        //    tbGaijin.Text = gaijin;
        
        //    if (ShowDialog() != DialogResult.OK)
        //        return false;
        //    yuanyin = tbYuanyin.Text.Trim();
        //    gaijin = tbGaijin.Text.Trim();
        //    return true;
        //}

       
    }
}