using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UnitMag
{
    [DisplayName("钢包物料添加标准")]
    public class CQA_BOF_Std_Ladle
    {
        public string steelgradeindex { get; set; }

        [DisplayName("钢包物料名称")]
        public string ladle_mat_name { get; set; }
        [DisplayName("钢包物料数量最小")]
        public string ladle_mat_min { get; set; }
        [DisplayName("钢包物料数量最大")]
        public string ladle_mat_max { get; set; }
        [DisplayName("钢包物料数量目标")]
        public string ladle_mat_aim { get; set; }

    }
}
