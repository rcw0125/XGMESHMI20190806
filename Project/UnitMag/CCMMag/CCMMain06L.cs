using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class CCMMain06L : UnitMag.Steel.BSteel
    {
        public CCMMain06L()
        {
            MainUnitType = UnitMag.Steel.UnitType.CCM;
            CurUnitID = 6;
            InitializeComponent();
        }
    }
}

