using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag
{
    public partial class newApply : Form
    {
        public newApply()
        {
            InitializeComponent();
            comboBox1.Text = "高拉碳";
        }

        public bool apply(string heatid, ref string type)
        {
            textBox1.Text = heatid;
            if (ShowDialog() != DialogResult.OK)
                return false;
            if (comboBox1.Text.Trim() == "高拉碳")
            {
                type = "GT";
            }
            else if (comboBox1.Text.Trim() == "低拉碳")
            { 
            
            }
            else if (comboBox1.Text.Trim() == "")
            {
                return false;
            }
            
            return true;
        }
    }
}