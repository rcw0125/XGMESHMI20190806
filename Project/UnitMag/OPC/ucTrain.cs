using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public partial class ucTrain : UserControl
    {
      
        public ucTrain()
        {    
            InitializeComponent();           
        }
        public void setno(string trainno)
        {
            label1.Text = trainno;
        }
    }
}
