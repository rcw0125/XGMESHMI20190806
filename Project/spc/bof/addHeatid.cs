using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace spc
{
    public partial class addHeatid : Form
    {
        public addHeatid()
        {
            InitializeComponent();
        }
        public bool add(ref string heatid)
            
        {
            textBox1.Text = heatid;
             if (ShowDialog() != DialogResult.OK)
             {
                 return false;
               
             }
             heatid = textBox1.Text.ToString();
             return true;
        }
    }
}