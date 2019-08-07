using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    public class ccm_plan
    {
        [DisplayName("炉号")]
        public string heatid { get; set; }

        [DisplayName("预定炉号")]
        public string planid { get; set; }

        [DisplayName("炼钢记号")]
        public string steelgradeindex { get; set; }
        [DisplayName("LF炉座号")]
        public string lfid { get; set; }
        [DisplayName("RH炉座号")]
        public string rhid { get; set; }
        [DisplayName("铸机号")]
        public string casterid { get; set; }
        [DisplayName("状态")]
        public string status { get; set; }

        [DisplayName("预定炼钢记号")]
        public string pre_steelgradeindex { get; set; }
        [DisplayName("预定钢种")]
        public string pre_steelgrade { get; set; }

        [DisplayName("转炉炉座号")]
        public string bofid { get; set; }
        [DisplayName("转炉状态")]
        public string bof_status { get; set; }
        [DisplayName("LF炉状态")]
        public string lf_status { get; set; }

        [DisplayName("RH炉状态")]
        public string rh_status { get; set; }

        [DisplayName("铸机状态")]
        public string caster_status { get; set; }
        [DisplayName("炉后状态")]
        public string side_status { get; set; }
        //[DisplayName("预定炉号")]
        //public string casting_no { get; set; }

        //[DisplayName("预定炉号")]
        //public string casting_heat_cnt { get; set; }
        [DisplayName("计划订单号")]
        public string plan_ord_id { get; set; }

        [DisplayName("去向")]
        public string destitation { get; set; }

        [DisplayName("精炼区分")]
        public string refine_type { get; set; }

        [DisplayName("热送标志")]
        public string hot_send_flag { get; set; }

        [DisplayName("回炉标志")]
        public string steel_return_flag { get; set; }

        [DisplayName("回退标志")]
        public string steel_back_flag { get; set; }

        [DisplayName("长")]
        public string length { get; set; }

        [DisplayName("宽")]
        public string width { get; set; }

        [DisplayName("厚")]
        public string thickness { get; set; }

        [DisplayName("钢种")]
        public string steelgrade { get; set; }

        [DisplayName("协议")]
        public string protocol { get; set; }
        [DisplayName("其他要求")]
        public string other_tech_request { get; set; }

    }
}
