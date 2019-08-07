using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    public class CQA_BOF_Std_Slag_Ele
    {
        [DisplayName("炼钢记号")]
        public string STEELGRADEINDEX { get; set; }
        public string CAO_MAX { get; set; }
        public string CAO_MIN { get; set; }

        public string SIO2_MAX { get; set; }

        public string SIO2_MIN { get; set; }
        public string MGO_MAX { get; set; }
        public string MGO_MIN { get; set; }

        public string TFE_MAX { get; set; }
        public string TFE_MIN { get; set; }
    }
}
