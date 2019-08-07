using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    [DisplayName("散装料标准")]
    public class CQA_BOF_Std_Bulk
    {
        public string steelgradeindex { get; set; }

        [DisplayName("散状料名称")]
        public string bulk_code { get; set; }
        [DisplayName("散状料1加入量最小")]
        public string bulk_weight_min { get; set; }
        [DisplayName("散状料1加入量最大")]
        public string bulk_weight_max { get; set; }
    }
}
