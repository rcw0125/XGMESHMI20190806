using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;


namespace UnitMag
{
    public partial class shoupiFrm : DockContent, IMESForm
    {
        public shoupiFrm()
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
        public static string strSQL = "";

        List<scsj> listscsj = new List<scsj>();
        private void btnQuery_Click(object sender, EventArgs e)
        {

            //            select ccmid as 铸机,heatid as 炉号,steelgrade as 钢种,decode(bloomweight,null,0,bloomweight) as 收坯,baocihao as 包次,ironweight as 铁水,scrapweight as 废钢,pigironweight as 铁块,ykweight as 压块,steelweight as 钢水
            // from
            //(
            //  select substr(a.ccmid, 3, 1) || '#连铸机' as ccmid, a.heatid, a.steelgrade,
            //       (select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight,
            //       (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,
            //       round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight
            // from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid and to_char(productiondate,'yyyy-MM-dd')= '2019-11-27' order by a.ccmid,a.productiondate
            // )
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strsql = "";
            if (toolStripComboBox1.Text == "" || toolStripComboBox1.Text == "全部")
            {
                strsql = "      select ccmid as 铸机,heatid as 炉号,steelgrade as 钢种,baocihao as 包次,productiondate as 开浇时间,ironweight as 铁水,scrapweight as 废钢,pigironweight as 铁块,ykweight as 压块,steelweight as 钢水,decode(bloomweight,null,0,bloomweight) as 收坯";
                strsql += "        from (";
                strsql += "        select substr(a.ccmid, 3, 1) || '#连铸机' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate ";
                strsql += "        from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '"+strStart+"' order by a.ccmid,a.productiondate ";
                strsql += "       )";
            }
            else
            {
                strsql = "      select ccmid as 铸机,heatid as 炉号,steelgrade as 钢种,baocihao as 包次,productiondate as 开浇时间,ironweight as 铁水,scrapweight as 废钢,pigironweight as 铁块,ykweight as 压块,steelweight as 钢水,decode(bloomweight,null,0,bloomweight) as 收坯";
                strsql += "        from (";
                strsql += "        select substr(a.ccmid, 3, 1) || '#连铸机' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate";
                strsql += "        from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '"+strStart+"' and a.ccmid='S6"+toolStripComboBox1.Text.Substring(0,1)+"' order by a.ccmid,a.productiondate ";
                strsql += "       )";

                if (toolStripComboBox1.Text.StartsWith("6"))
                {
                    strsql += "       union  select ccmid as 铸机,heatid as 炉号,steelgrade as 钢种,baocihao as 包次,productiondate as 开浇时间,ironweight as 铁水,scrapweight as 废钢,pigironweight as 铁块,ykweight as 压块,steelweight as 钢水,decode(bloomweight,null,0,bloomweight) as 收坯";
                    strsql += "        from (";
                    strsql += "        select substr(a.ccmid, 3, 1) || '#连铸机' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                    strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                    strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,0 as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate";
                    strsql += "        from cccm_base_data a ,caod_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                    strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '" + strStart + "' and a.ccmid='S6" + toolStripComboBox1.Text.Substring(0, 1) + "' order by a.ccmid,a.productiondate ";
                    strsql += "       )";

                }
            }
            

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            listscsj.Clear();
            double ironweight = 0, scrapweight = 0, pigironweight = 0, ykweight = 0, steelweight = 0, shoupi = 0;
            if (data == null)
            {
                MessageBox.Show("没有查询到数据！");
                return;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                scsj curscsj = new scsj();
                curscsj.铸机 = data.Rows[i]["铸机"].ToString();
                curscsj.炉号 = data.Rows[i]["炉号"].ToString();
                curscsj.钢种 = data.Rows[i]["钢种"].ToString();
                curscsj.包次 = data.Rows[i]["包次"].ToString();
                curscsj.开浇时间 = data.Rows[i]["开浇时间"].ToString();
                curscsj.铁水 = (double)data.Rows[i]["铁水"];
                ironweight += curscsj.铁水;
                curscsj.废钢 = (double)data.Rows[i]["废钢"];
                scrapweight += curscsj.废钢;
                curscsj.铁块 = (double)data.Rows[i]["铁块"];
                pigironweight += curscsj.铁块;
                curscsj.压块 = (double)data.Rows[i]["压块"];
                ykweight += curscsj.压块;
                curscsj.钢水 = (double)data.Rows[i]["钢水"];
                steelweight += curscsj.钢水;
                curscsj.收坯 = (double)data.Rows[i]["收坯"];
                if (curscsj.收坯 > 1)
                {
                    curscsj.铁耗 = Math.Round(curscsj.铁水 * 1000 / curscsj.收坯, 1);
                }
                else
                {
                    curscsj.铁耗 = 0;
                }
                
                shoupi += curscsj.收坯;
                listscsj.Add(curscsj);
            }
            //if ((toolStripComboBox1.Text != "" && toolStripComboBox1.Text != "全部"))
            //{
               
            //}
            //累计
            scsj ljscsj = new scsj();
            ljscsj.铸机 = "累计";
            ljscsj.铁水 = Math.Round(ironweight, 1);
            ljscsj.废钢 = Math.Round(scrapweight, 1);
            ljscsj.铁块 = Math.Round(pigironweight, 1);
            ljscsj.压块 = Math.Round(ykweight, 1);
            ljscsj.钢水 = Math.Round(steelweight, 1);
            ljscsj.收坯 = Math.Round(shoupi, 1);
            //平均
            scsj pjscsj = new scsj();
            pjscsj.铸机 = "平均";
            if (data.Rows.Count > 0)
            {
                pjscsj.铁水 = Math.Round(ironweight / data.Rows.Count, 2);
                pjscsj.废钢 = Math.Round(scrapweight / data.Rows.Count, 2);
                pjscsj.铁块 = Math.Round(pigironweight / data.Rows.Count, 2);
                pjscsj.压块 = Math.Round(ykweight / data.Rows.Count, 2);
                pjscsj.钢水 = Math.Round(steelweight / data.Rows.Count, 2);
                pjscsj.收坯 = Math.Round(shoupi / data.Rows.Count, 2);
                pjscsj.铁耗 = Math.Round(ljscsj.铁水*1000 / ljscsj.收坯, 2);
            }
            else
            {
                pjscsj.铁水 = 0;
                pjscsj.废钢 = 0;
                pjscsj.铁块 = 0;
                pjscsj.压块 = 0;
                pjscsj.钢水 = 0;
                pjscsj.收坯 = 0;
                pjscsj.铁耗 = 0;
            }
            listscsj.Add(ljscsj);
            listscsj.Add(pjscsj);


            dvTel.DataSource = null;
            dvTel.DataSource = listscsj;
            bsMqhs.DataSource = listscsj;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='投料' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            tdtstart.Value = DateTime.Now;
            toolStripComboBox1.SelectedIndex = 0;
            
        }



        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("收坯统计", dvTel);
        }
    }

    public class scsj
    {
        //select ccmid as 铸机,heatid as 炉号,steelgrade as 钢种,baocihao as 包次,productiondate as 开浇时间,ironweight as 铁水,scrapweight as 废钢,
        //    pigironweight as 铁块,ykweight as 压块,steelweight as 钢水,decode(bloomweight,null,0, bloomweight) as 收坯
        public string 铸机 { get; set; }
        public string 炉号 { get; set; }
        public string 钢种 { get; set; }
        public string 包次 { get; set; }
        public string 开浇时间 { get; set; }

        public double 铁水 { get; set; }
        public double 废钢 { get; set; }
        public double 铁块 { get; set; }
        public double 压块 { get; set; }
        public double 钢水 { get; set; }
        public double 收坯 { get; set; }

        public double 铁耗 { get; set; }



    }
}