using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace UnitMag.DEPMag
{
    public partial class DEPMag : UnitMag.Steel.BSteel
    {
        public DEPMag()
        {
            MainUnitType = UnitMag.Steel.UnitType.DEP;
            CurUnitID =5;
            InitializeComponent();
        }
    }
}

