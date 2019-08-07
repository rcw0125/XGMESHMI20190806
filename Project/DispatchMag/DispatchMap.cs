using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class DispatchMap : DockContent, IMESForm
    {
        public DispatchMap()
        {
            InitializeComponent();
        }

        #region IMESForm ≥…‘±

        DockContent IMESForm.Document
        {
            get { return this as DockContent; }
        }

        AppSvrIF.Session IMESForm.L3Session
        {
            get
            {
                return Adapter.Session;
            }
            set
            {
                Adapter.Session = value;
            }
        }

        #endregion

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ShowMap();
        }

        private void ShowMap()
        {
            Bitmap bitm = new Bitmap(this.pbxMap.Width, this.pbxMap.Height);
            Graphics grap = Graphics.FromImage(bitm);
            grap.Clear(Color.White);

            grap.DrawLine(new Pen(new SolidBrush(Color.Black), 2.0f), 80, 40, 80 + 24 * 36, 40);
            for (int i = 0; i <= 24; i++)
            {
                grap.DrawString(i.ToString(), new Font("ÀŒÃÂ", 9), new SolidBrush(Color.Black), 82 + i * 36, 15);

                grap.DrawLine(new Pen(new SolidBrush(Color.Black), 2.0f), 80 + i * 36, 20, 80 + i * 36, 380);

                if (i < 24)
                {
                    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 80 + i * 36 + 6 * 1, 32, 80 + i * 36 + 6 * 1, 40);
                    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 80 + i * 36 + 6 * 2, 32, 80 + i * 36 + 6 * 2, 40);
                    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 1.0f), 80 + i * 36 + 6 * 3, 28, 80 + i * 36 + 6 * 3, 40);
                    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 80 + i * 36 + 6 * 4, 32, 80 + i * 36 + 6 * 4, 40);
                    grap.DrawLine(new Pen(new SolidBrush(Color.Black), 0.5f), 80 + i * 36 + 6 * 5, 32, 80 + i * 36 + 6 * 5, 40);
                }
            }

            for (int j = 0; j < 9; j++)
            {
                grap.DrawLine(new Pen(new SolidBrush(Color.Green), 20.0f), 80, 50 + 40 * j, 80 + 24 * 36, 50 + 40 * j);
            }

            this.pbxMap.BackgroundImage = bitm;
        }
    }
}