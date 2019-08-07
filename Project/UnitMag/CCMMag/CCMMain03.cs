using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMMain03 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public CCMMain03()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.CCM;
            CurUnitID = 3;

            InitializeComponent();
        }
    }
}

