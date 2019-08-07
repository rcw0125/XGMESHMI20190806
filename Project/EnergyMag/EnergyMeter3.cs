using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EnergyMag
{
    public partial class EnergyMeter3 : UserControl
    {
        public EnergyMeter3()
        {
            InitializeComponent();
        }

        public AppSvrHMI.L3Adapter Adapter
        {
            get { return meterPressure.L3DataAdapter; }
            set
            {
                meterPressure.L3DataAdapter = value;
                meterFlow.L3DataAdapter = value;
            }
        }

        public string MeterObject
        {
            get { return meterPressure.MeterObject; }
            set
            {
                meterPressure.MeterObject = value;
                meterFlow.MeterObject = value;
            }
        }

        public string PressureProp
        {
            get { return meterPressure.ValueProperty; }
            set { meterPressure.ValueProperty = value; }
        }

        public string MaxPressureProp
        {
            get { return meterPressure.MaxProperty; }
            set { meterPressure.MaxProperty = value; }
        }

        public string MinPressureProp
        {
            get { return meterPressure.MinProperty; }
            set { meterPressure.MinProperty = value; }
        }

        public string LowPressureProp
        {
            get { return meterPressure.LowProperty; }
            set { meterPressure.LowProperty = value; }
        }

        public string HighPressureProp
        {
            get { return meterPressure.HighProperty; }
            set { meterPressure.HighProperty = value; }
        }

        public string FlowProp
        {
            get { return meterFlow.ValueProperty; }
            set { meterFlow.ValueProperty = value; }
        }

        public string MaxFlowProp
        {
            get { return meterFlow.MaxProperty; }
            set { meterFlow.MaxProperty = value; }
        }

        public string MinFlowProp
        {
            get { return meterFlow.MinProperty; }
            set { meterFlow.MinProperty = value; }
        }

        public string LowFlowProp
        {
            get { return meterFlow.LowProperty; }
            set { meterFlow.LowProperty = value; }
        }

        public string HighFlowProp
        {
            get { return meterFlow.HighProperty; }
            set { meterFlow.HighProperty = value; }
        }

        public int PressurePrecision
        {
            get { return meterPressure.Precision; }
            set { meterPressure.Precision = value; }
        }

        public float Pressure
        {
            get { return meterPressure.Value; }
            set { meterPressure.Value = value; }
        }

        public float MaxPressure
        {
            get { return meterPressure.MaxValue; }
            set { meterPressure.MaxValue = value; }
        }

        public float MinPressure
        {
            get { return meterPressure.MinValue; }
            set { meterPressure.MinValue = value; }
        }

        public float HighPressure
        {
            get { return meterPressure.HighValve; }
            set { meterPressure.HighValve = value; }
        }

        public float LowPressure
        {
            get { return meterPressure.LowValve; }
            set { meterPressure.LowValve = value; }
        }

        public float Flow
        {
            get { return meterFlow.Value; }
            set { meterFlow.Value = value; }
        }

        public float MaxFlow
        {
            get { return meterFlow.MaxValue; }
            set { meterFlow.MaxValue = value; }
        }

        public float MinFlow
        {
            get { return meterFlow.MinValue; }
            set { meterFlow.MinValue = value; }
        }

        public float HighFlow
        {
            get { return meterFlow.HighValve; }
            set { meterFlow.HighValve = value; }
        }

        public float LowFlow
        {
            get { return meterFlow.LowValve; }
            set { meterFlow.LowValve = value; }
        }

        public int FlowPrecision
        {
            get { return meterFlow.Precision; }
            set { meterFlow.Precision = value; }
        }

        public string gbxNameText
        {
            get { return gbxName.Text; }
            set { gbxName.Text = value; }
        }

        private static object EventClick = new object();        //定义一对象EventClick
        //申明一个委托
        public delegate void BtnDoubleClickEventHandler(object sender, EventArgs e);

        //发布事件BtnClick
        [Category("自定义事件")]
        [Description("响应控件的双击事件")]
        public event EventHandler UserBtn_DoubleClick
        {
            add
            {
                Events.AddHandler(EventClick, value);
            }
            remove
            {
                Events.RemoveHandler(EventClick, value); 
            }
        }

        private void meterPressure_DoubleClick(object sender, EventArgs e)
        {
            EventHandler ButtonClick = (EventHandler)Events[EventClick];
            if (ButtonClick != null)
            {
                ButtonClick(this, e);
            }
        }

        private void meterFlow_DoubleClick(object sender, EventArgs e)
        {
            EventHandler ButtonClick = (EventHandler)Events[EventClick];
            if (ButtonClick != null)
            {
                ButtonClick(this, e);
            }
        }

        private void EnergyMeter3_DoubleClick(object sender, EventArgs e)
        {
            EventHandler ButtonClick = (EventHandler)Events[EventClick];
            if (ButtonClick != null)
            {
                ButtonClick(this, e);
            }
        }
    }
}
