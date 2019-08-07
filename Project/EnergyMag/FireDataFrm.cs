using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EnergyMag
{
    public partial class FireDataFrm : DockContent, IMESForm
    {
        public FireDataFrm()
        {
            InitializeComponent();
        }

        #region IMESForm 成员

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

        private CurveShowFrm Frm = new CurveShowFrm();
        private void energyMeter_UserBtn_DoubleClick(object sender, EventArgs e)
        {
            if (sender.GetType().Name.ToString() != "EnergyMeter1")
                return;
            EnergyMeter1 energymeter = (EnergyMeter1)sender;
            if (!Frm.IsDisposed)
                Frm.Dispose();
            Frm = new CurveShowFrm();

            Frm.strTagName = energymeter.Tag.ToString();
            Frm.strFormText = energymeter.gbxNameText;
            if (energymeter.Parent != gbxCCMHotFire)
            {
                Frm.strFlowTitle = "煤气流量";
                Frm.strPressTitle = "空气流量";
            }
            else
            {
                Frm.strPressTitle = "西车煤气流量";
                Frm.strFlowTitle = "东车煤气流量";
            }
            Frm.ShowDialogEx(Adapter.Session);
        }

        private void FireDataFrm_Load(object sender, EventArgs e)
        {
            Adapter.RefreshDataBindings();
        }

    }
}