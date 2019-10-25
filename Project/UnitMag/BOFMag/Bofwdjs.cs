using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UnitMag.LFMag;

namespace UnitMag.BOFMag
{
    public partial class Bofwdjs : Form
    {
        public Bofwdjs()
        {
            InitializeComponent();
        }

        
        public string strSteelgradeindex = "";
        string strGradeTypeSql = "";

        public double weight;
        


        public double C;
        public double Si;
        public double Mn;
        public double Cr;

        public double zd_c;
        public double zd_si;
        public double zd_mn;
        public double zd_cr;

        public double bc_zd_c;
        public double bc_zd_si;
        public double bc_zd_mn;
        public double bc_zd_cr;


        public double bc_time;

        public int bofid;
        public string strHeatid = "";



        private void LFcfjs_Load(object sender, EventArgs e)
        {
            if (strHeatid != "")
            {
                tbheatid.Text = strHeatid;
             
            }        
        }
     
       

   
       

        /// <summary>
        /// 计算成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double piancha = 0;
            if (tempdataList.Count == 2)
            {
                #region 兑入铁水废钢部分
                if (tempdataList[0].c > 0 && tempdataList[1].c > 0)
                {
                    piancha += Math.Round(((tempdataList[1].c - tempdataList[0].c) / 0.1) * 10.4, 1);
                }

                if (tempdataList[0].si > 0 && tempdataList[1].si > 0)
                {
                    piancha += Math.Round(((tempdataList[1].si - tempdataList[0].si) / 0.1) * 29.1, 1);
                }

                if (tempdataList[0].mn > 0 && tempdataList[1].mn > 0)
                {
                    piancha += Math.Round(((tempdataList[1].mn - tempdataList[0].mn) / 0.1) * 6.3, 1);
                }

                if (tempdataList[0].p > 0 && tempdataList[1].p > 0)
                {
                    piancha += Math.Round(((tempdataList[1].p - tempdataList[0].p) / 0.01) * 2.7, 1);
                }

                if (tempdataList[0].irontemp > 0 && tempdataList[1].irontemp > 0)
                {
                    piancha += Math.Round(((tempdataList[1].irontemp - tempdataList[0].irontemp) / 10) * 7.6, 1);
                }

                if (tempdataList[0].ironweight > 0 && tempdataList[1].ironweight > 0)
                {
                    piancha += Math.Round(((tempdataList[1].ironweight - tempdataList[0].ironweight) / 1) * 8.2, 1);
                }

                if (tempdataList[0].scrapweight > 0 && tempdataList[1].scrapweight > 0)
                {
                    piancha += Math.Round(((tempdataList[1].scrapweight - tempdataList[0].scrapweight) / 1) * (-29), 1);
                }

                if (tempdataList[0].ykweight >= 0 && tempdataList[1].ykweight >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].ykweight - tempdataList[0].ykweight) / 1) * (-29), 1);
                }

                #endregion

                #region 加入散装料部分

                if (tempdataList[0].shihui >=0 && tempdataList[1].shihui >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].shihui - tempdataList[0].shihui) / 100) * (-5.1), 1);
                }

                if (tempdataList[0].baiyunhui >= 0 && tempdataList[1].baiyunhui >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].baiyunhui - tempdataList[0].baiyunhui) / 100) * (-6.6), 1);
                }

                if (tempdataList[0].baiyunshi >= 0 && tempdataList[1].baiyunshi >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].baiyunshi - tempdataList[0].baiyunshi) / 100) * (-7), 1);
                }

                if (tempdataList[0].shihuishi >= 0 && tempdataList[1].shihuishi >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].shihuishi - tempdataList[0].shihuishi) / 100) * (-7), 1);
                }

                if (tempdataList[0].shaojiekuang >= 0 && tempdataList[1].shaojiekuang >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].shaojiekuang - tempdataList[0].shaojiekuang) / 100) * (-10.32), 1);
                }
                if (tempdataList[0].cgfrj >= 0 && tempdataList[1].cgfrj >= 0)
                {
                    piancha += Math.Round(((tempdataList[1].cgfrj - tempdataList[0].cgfrj) / 100) * (15), 1);
                }
                #endregion



                if (tempdataList[0].zdc > 0 && tempdataList[1].zdc > 0)
                {
                    piancha += Math.Round(((tempdataList[1].zdc - tempdataList[0].zdc) / 0.01) * (-2), 1);
                }

                if (tempdataList[0].o2time > 0 && tempdataList[1].o2time > 0)
                {
                    piancha += Math.Round(((tempdataList[1].o2time - tempdataList[0].o2time) / 15) * (10), 1);
                }

                if (tempdataList[0].liuzha != tempdataList[1].liuzha)
                {
                    if (tempdataList[0].liuzha == 0 && tempdataList[1].liuzha == 1)
                    {
                        piancha += -20;
                    }
                    else if (tempdataList[0].liuzha == 1 && tempdataList[1].liuzha == 0)
                    {
                        piancha += 20;
                    }
                }

                if (tempdataList[0].sxzweight != tempdataList[1].sxzweight)
                {
                    piancha += Math.Round(((tempdataList[1].sxzweight - tempdataList[0].sxzweight) / 1) * (-50), 1);
                }
                if (tempdataList[0].tlzweight != tempdataList[1].tlzweight)
                {
                    piancha += Math.Round(((tempdataList[1].tlzweight - tempdataList[0].tlzweight) / 1) * (-60), 1);
                }

                if (tempdataList[0].qgzweight != tempdataList[1].qgzweight)
                {
                    piancha += Math.Round(((tempdataList[1].qgzweight - tempdataList[0].qgzweight) / 1) * (-70), 1);
                }

                tbtemp.Text = (tempdataList[0].lactemp + piancha).ToString();
            }
            else
            {
                MessageBox.Show("炉次信息有误,不是两个炉次");
            }
        }
        public List<wdmodel> tempdataList = new List<wdmodel>();
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbheatid.Text.Trim() != "")
            {
                tempdataList.Clear();
                string preheatid = (Convert.ToInt64(tbheatid.Text.Trim()) - 1).ToString();
                string strSql = " select heatid,ironweight ,(scrapweight + ykweight) as scrapweight,c,si,mn,p,irontemp ,ykweight,";
                strSql += " (select  decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '13301') as shihui,";
                strSql += " (select decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '13305') as baiyunhui, ";
                strSql += " (select decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '13323') as baiyunshi, ";
                strSql += " (select decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '13307') as shihuishi, ";
                strSql += " (select decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '60103') as shaojiekuang,";
                strSql += "  (select decode(sum(weight),null,0,sum(weight)) from cbof_addition_data  where heatid = cbof_feed_data.heatid and type = 1 and element = '12176') as cgfrj, ";
                strSql += "  (select blowo2_time-reblow_time from cbof_process_data where heatid = cbof_feed_data.heatid) as o2time, ";
                strSql += "  (select remainslag from cbof_process_data where heatid = cbof_feed_data.heatid) as liuzha, ";
                strSql += "  (select c from CQA_LAB_ELEMENT where unittypeid='2' and heatid = cbof_feed_data.heatid and rownum=1)  as zdc, ";
                strSql += " (select lac_temp from cbof_process_data where heatid = cbof_feed_data.heatid) as lactemp ";
                strSql += " from cbof_feed_data";
                strSql += " where heatid = '"+tbheatid.Text.Trim()+"' or heatid='"+preheatid+"' order by heatid";
                var dt = UnitMag.MESTool.GetData(Adapter, strSql);
                dataGridView1.DataSource = dt;
                if (dt != null && dt.Rows.Count > 0)
                {               
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        wdmodel tempdata = new wdmodel();
                        tempdata.heatid = dt.Rows[i]["heatid"].ToString();
                        tempdata.ironweight = Math.Round(Convert.ToDouble(dt.Rows[i]["ironweight"]), 1) ;
                        tempdata.scrapweight = Math.Round(Convert.ToDouble(dt.Rows[i]["scrapweight"]),1);
                        tempdata.ykweight = Math.Round(Convert.ToDouble(dt.Rows[i]["ykweight"]), 1);
                        tempdata.c =Math.Round(Convert.ToDouble(dt.Rows[i]["c"]),3) ;
                        tempdata.si = Math.Round(Convert.ToDouble(dt.Rows[i]["si"]), 3);
                        tempdata.mn = Math.Round(Convert.ToDouble(dt.Rows[i]["mn"]), 3);
                        tempdata.p = Math.Round(Convert.ToDouble(dt.Rows[i]["p"]), 3);
                        tempdata.shihui= Math.Round(Convert.ToDouble(dt.Rows[i]["shihui"]), 1);
                        tempdata.baiyunhui = Math.Round(Convert.ToDouble(dt.Rows[i]["baiyunhui"]), 1);
                        tempdata.baiyunshi = Math.Round(Convert.ToDouble(dt.Rows[i]["baiyunshi"]), 1);
                        tempdata.shihuishi = Math.Round(Convert.ToDouble(dt.Rows[i]["shihuishi"]), 1);
                        tempdata.shaojiekuang = Math.Round(Convert.ToDouble(dt.Rows[i]["shaojiekuang"]), 1);
                        tempdata.cgfrj = Math.Round(Convert.ToDouble(dt.Rows[i]["cgfrj"]), 1);
                        tempdata.lactemp = Convert.ToInt16(dt.Rows[i]["lactemp"]);
                        tempdata.irontemp = Convert.ToDouble(dt.Rows[i]["irontemp"]);
                        tempdata.o2time = Convert.ToDouble(dt.Rows[i]["o2time"]);
                        if (dt.Rows[i]["zdc"] != DBNull.Value && dt.Rows[i]["zdc"].ToString() != null)
                        {
                            tempdata.zdc = Convert.ToDouble(dt.Rows[i]["zdc"]);
                        }
                        else
                        {
                            tempdata.zdc = 0;
                        }
                        if (dt.Rows[i]["liuzha"] != DBNull.Value && dt.Rows[i]["liuzha"].ToString() != null)
                        {
                            if (dt.Rows[i]["liuzha"].ToString() == "是")
                            {
                                tempdata.liuzha = 1;
                            }
                            else
                            {
                                tempdata.liuzha = 0;
                            }
                        }
                        else
                        {
                            tempdata.liuzha = 0;
                        }
                        tempdata.irontemp = Convert.ToDouble(dt.Rows[i]["irontemp"]);
                        tempdataList.Add(tempdata);
                    }             
                }

                if (tempdataList.Count == 1)
                {
                    wdmodel tempdata = new wdmodel();
                    tempdata.heatid = tbheatid.Text.Trim();
                    tempdataList.Add(tempdata);
                }
                #region 对最后一炉的数据检查赋值
                if (tempdataList[1].shihui < 1)
                {
                    tempdataList[1].shihui = tempdataList[0].shihui;
                }
                if (tempdataList[1].baiyunhui < 1)
                {
                    tempdataList[1].baiyunhui = tempdataList[0].baiyunhui;
                }
                if (tempdataList[1].baiyunshi < 1)
                {
                    tempdataList[1].baiyunshi = tempdataList[0].baiyunshi;
                }
                if (tempdataList[1].shihuishi < 1)
                {
                    tempdataList[1].shihuishi = tempdataList[0].shihuishi;
                }
                if (tempdataList[1].shaojiekuang < 1)
                {
                    tempdataList[1].shaojiekuang = tempdataList[0].shaojiekuang;
                }
                if (tempdataList[1].cgfrj < 1)
                {
                    tempdataList[1].cgfrj = tempdataList[0].cgfrj;
                }

                if (tempdataList[1].zdc < 0.0001)
                {
                    tempdataList[1].zdc = tempdataList[0].zdc;
                }
                if (tempdataList[1].o2time < 1)
                {
                    tempdataList[1].o2time = tempdataList[0].o2time;
                }        
                if (tempdataList[1].ironweight < 0.0001)
                {
                    tempdataList[1].ironweight = tempdataList[0].ironweight;
                }

                if (tempdataList[1].ironweight < 0.0001)
                {
                    tempdataList[1].ironweight = tempdataList[0].ironweight;
                }
                if (tempdataList[1].scrapweight < 0.0001)
                {
                    tempdataList[1].scrapweight = tempdataList[0].scrapweight;
                }
                if (tempdataList[1].ykweight < 0.0001)
                {
                    tempdataList[1].ykweight = tempdataList[0].ykweight;
                }
                if (tempdataList[1].c < 0.0001)
                {
                    tempdataList[1].c = tempdataList[0].c;
                }
                if (tempdataList[1].si < 0.0001)
                {
                    tempdataList[1].si = tempdataList[0].si;
                }
                if (tempdataList[1].mn < 0.0001)
                {
                    tempdataList[1].mn = tempdataList[0].mn;
                }
                if (tempdataList[1].p < 0.0001)
                {
                    tempdataList[1].p = tempdataList[0].p;
                }
                if (tempdataList[1].irontemp < 0.0001)
                {
                    tempdataList[1].irontemp = tempdataList[0].irontemp;
                }
                #endregion     
                lbtemp.Text = tempdataList[0].lactemp.ToString();
                lbcurtemp.Text = tempdataList[1].lactemp.ToString();
                dataGridView1.DataSource = tempdataList;
            }
            else
            {
                MessageBox.Show("请输入最后一炉炉号");
            }
           
        }
    }

    public class wdmodel
    {
        [DisplayName("炉号")]
        public string heatid { get; set; }
        [DisplayName("铁水重量")]
        public double ironweight { get; set; }
        [DisplayName("废钢重量")]
        public double scrapweight { get; set; }
        [DisplayName("压块")]
        public double ykweight { get; set; }

        [DisplayName("三选钢渣")]
        public double sxzweight { get; set; }

        [DisplayName("脱硫渣")]
        public double tlzweight { get; set; }
        [DisplayName("切割渣")]
        public double qgzweight { get; set; }


        [DisplayName("C")]
        public double  c { get; set; }

        [DisplayName("终点C")]
        public double zdc { get; set; }
        [DisplayName("Si")]

        public double si { get; set; }
        [DisplayName("Mn")]
        public double mn{ get; set; }
        [DisplayName("P")]
        public double p { get; set; }
        [DisplayName("铁水温度")]
        public double irontemp { get; set; }
        [DisplayName("石灰")]

        public double shihui { get; set; }
        [DisplayName("白云灰")]

        public double baiyunhui { get; set; }
        [DisplayName("白云石")]

        public double baiyunshi { get; set; }
        [DisplayName("石灰石")]

        public double shihuishi { get; set; }

        [DisplayName("烧结矿")]

        public double shaojiekuang { get; set; }

        [DisplayName("碳硅发热剂")]

        public double cgfrj { get; set; }

        [DisplayName("供氧时间")]

        public double o2time { get; set; }

        [DisplayName("拉碳温度")]
        public Int16 lactemp { get; set; }

        [DisplayName("留渣")]
        public Int16 liuzha { get; set; }

    }
}
