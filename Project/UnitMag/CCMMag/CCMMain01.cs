using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMMain01 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public CCMMain01()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.CCM;
            CurUnitID = 1;

            InitializeComponent();
        }
    }
}

