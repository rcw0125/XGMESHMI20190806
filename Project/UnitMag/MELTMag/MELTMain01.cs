using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MELTMag
{
    public partial class MELTMain01 : UnitMag.Steel.CSteel
    {
        public MELTMain01()
        {
            MainUnitType = UnitMag.Steel.UnitType .MELT;
            CurUnitID = 6;

            InitializeComponent();
        }
    }
}