using System;
using System.Collections.Generic;
using System.Text;

namespace UnitMag
{
    public class CBOF_Feed_Data
    {
        public string heatid { get; set; }
        public decimal ironweight { get; set; }

        public decimal scrapweight { get; set; }

        public decimal pigironweight { get; set; }

        public decimal return_steel_weight { get; set; }

        public int irontemp { get; set; }

        public decimal c { get; set; }

        public decimal si { get; set; }

        public decimal mn { get; set; }

        public decimal p { get; set; }

        public decimal s { get; set; }

        public decimal ti { get; set; }

        public decimal totalweight { get; set; }

        public decimal iron_s_max { get; set; }
        public decimal iron_p_max { get; set; }

        public decimal iron_si_max { get; set; }


    }
}
