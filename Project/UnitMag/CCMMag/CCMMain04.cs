using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMMain04 : UnitMag.BOFMag.UnitMagMainFrm
    {
        public CCMMain04()
        {
            MainUnitType = UnitMag.BOFMag.UnitType.CCM;
            CurUnitID = 4;

            InitializeComponent();
        }
    }
}

