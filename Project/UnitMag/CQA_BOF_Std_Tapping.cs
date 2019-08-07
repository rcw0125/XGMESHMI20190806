using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    [DisplayName("出钢标准")]
    public class CQA_BOF_Std_Tapping
    {
        public string steelgradeindex { get; set; }
        [DisplayName("出钢温度最小")]
        public string tapping_temp_min { get; set; }

        [DisplayName("出钢时间最小")]
        public string tapping_time_min { get; set; }
        [DisplayName("终点氧含量上限")]
        public string end_o2_uplimit { get; set; }
        [DisplayName("终点成份C上限")]
        public string end_c_uplimit { get; set; }
        [DisplayName("终点成份C下限")]
        public string end_c_lowlimit { get; set; }
        [DisplayName("终点成份S上限")]
        public string end_s_uplimit { get; set; }
        [DisplayName("终点成份P上限")]
        public string end_p_uplimit { get; set; }
        [DisplayName("终点成份Mn上限")]
        public string end_mn_uplimit { get; set; }
        [DisplayName("出钢过程吹氩压力最大")]
        public string ar_press_max { get; set; }
        [DisplayName("出钢过程吹氩压力最小")]
        public string ar_press_min { get; set; }
        [DisplayName("出钢过程吹氩气量最大")]
        public string ar_blow_max { get; set; }
        [DisplayName("出钢过程吹氩气量最小")]
        public string ar_blow_min { get; set; }
    }
}
