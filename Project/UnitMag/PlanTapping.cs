using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    public class PlanTapping
    {
        [DisplayName("炉号")]
        public string heatid { get; set; }
        [DisplayName("预定炼钢记号")]
        public string pre_steelgradeindex { get; set; }
        [DisplayName("实际炼钢记号")]
        public string steelgradeindex { get; set; }
        [DisplayName("钢种")]
        public string steelgrade { get; set; }

        [DisplayName("协议号")]
        public string protocol { get; set; }
        [DisplayName("其他要求")]
        public string other_tech_request { get; set; }
        [DisplayName("转炉炉座号")]
        public string bofid { get; set; }
        [DisplayName("LF炉座号")]
        public string lfid { get; set; }
        [DisplayName("RH炉座号")]
        public string rhid { get; set; }
        [DisplayName("铸机号")]
        public string casterid { get; set; }
        public string status { get; set; }
        [DisplayName("转炉状态")]
        public string bof_status { get; set; }
        [DisplayName("LF炉状态")]
        public string lf_status { get; set; }
        [DisplayName("RH炉状态")]
        public string rh_status { set; get; }
        [DisplayName("铸机状态")]
        public string caster_status { set; get; }
        [DisplayName("炉后状态")]
        public string side_status { get; set; }
        [DisplayName("去向")]
        public string destitation { get; set; }
        [DisplayName("计划订单号")]
        public string plan_ord_id { get; set; }
        //public DateTime createdate { get; set; }
       
       

    }
}
