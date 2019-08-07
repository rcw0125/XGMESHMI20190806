using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag.LFMag
{
    public class JzcfModel
    {
        [DisplayName("炉号")]
        public string heatid { get; set; }

        [DisplayName("C吸收率")]
        public double c_rate { get; set; }

        [DisplayName("si吸收率")]
        public double si_rate { get; set; }

        [DisplayName("mn吸收率")]
        public double mn_rate { get; set; }

        [DisplayName("cr吸收率")]
        public double cr_rate { get; set; }

        [DisplayName("C")]
        public double c { get; set; }

        [DisplayName("si")]
        public double si { get; set; }

        [DisplayName("mn")]
        public double mn { get; set; }

        [DisplayName("cr")]
        public double cr { get; set; }

        [DisplayName("钢水重量")]
        public double weight { get; set; }

        [DisplayName("终点C")]
        public double zd_c { get; set; }

        [DisplayName("终点si")]
        public double zd_si { get; set; }

        [DisplayName("终点mn")]
        public double zd_mn { get; set; }

        [DisplayName("终点cr")]
        public double zd_cr { get; set; }

        public List<Jzcf_alloydata> alloydatalist = new List<Jzcf_alloydata>();

        public void calC()
        {
            if (alloydatalist.Count > 0)
            {
                double c_value = 0;
                foreach (var item in alloydatalist)
                {
                   
                        c_value += item.weight * item.c / 100;
                  
                }
                c = zd_c+ c_value*c_rate / weight / 10;
            }          
        }

        public void calSi()
        {
            if (alloydatalist.Count > 0)
            {
                double si_value = 0;
                foreach (var item in alloydatalist)
                {
                    si_value += item.weight * item.si / 100;
                }
                si =zd_si+ si_value*si_rate / weight / 10;
            }
        }

        public void calMn()
        {
            if (alloydatalist.Count > 0)
            {
                double mn_value = 0;
                foreach (var item in alloydatalist)
                {
                  
                    mn_value += item.weight * item.mn/100;
                }
                mn = zd_mn+mn_value*mn_rate / weight / 10;
            }
        }

        public void calCr()
        {
            if (alloydatalist.Count > 0)
            {
                double cr_value = 0;
                foreach (var item in alloydatalist)
                {                   
                    cr_value += item.weight * item.cr / 100;
                }
                cr =zd_cr+ cr_value *cr_rate / weight / 10;
            }
        }
    }

    public class Jzcf_alloydata
    {
        [DisplayName("炉号")]
        public string heatid { get; set; }

        [DisplayName("合金名")]
        public string elment { get; set; }

        [DisplayName("采集方式")]
        public string type { get; set; }

        //[DisplayName("合金批次")]
        //public string batch_id { get; set; }
        [DisplayName("重量")]
        public double weight { get; set; }

        //[DisplayName("增碳剂")]
        //public string ztj { get; set; }
        //[DisplayName("C计算")]
        //public string c_cal { get; set; }

        [DisplayName("C品位")]
        public double c { get; set; }

        //[DisplayName("Si计算")]
        //public string si_cal { get; set; }

        [DisplayName("Si品位")]
        public double si { get; set; }

        //[DisplayName("Mn计算")]
        //public string mn_cal { get; set; }

        [DisplayName("Mn品位")]
        public double mn { get; set; }

        //[DisplayName("Cr计算")]
        //public string cr_cal { get; set; }
        [DisplayName("Cr品位")]
        public double cr { get; set; }

    }


}
