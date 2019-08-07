using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.AODMag
{
    public partial class AODMag01 : UnitMag.Steel.BSteel
    {
        public AODMag01()
        {
            MainUnitType = UnitMag.Steel.UnitType.BOF;
            CurUnitID = 5;
            InitializeComponent();
            
        }
    }
}

