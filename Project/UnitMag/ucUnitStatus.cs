using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using AppSvrHMI;
using AppSvrIF;

//封装用户控件  工序状态
namespace UnitMag
{
    public partial class ucUnitStatus : UserControl
    {
        public ucUnitStatus()
        {
            InitializeComponent();
        }

        //
        protected AppSvrHMI.L3Adapter m_Adapter = null;
        protected string m_UnitURI = "";
        protected string m_StatusProp = "";
        protected int m_iStatus = 0;
        //add by hyh 2012-04-01
        protected int m_flowCount = 4;//默认连铸流数位4流
        //end

        // 委托函数
        public delegate void Delegate_OnUnitStatusChanged(string UnitURI, int OldStatus, int NewStatus);

        //定义一个事件 OnUnitStatusChanged
        public event Delegate_OnUnitStatusChanged OnUnitStatusChanged;

        protected string TranslateURI(string uri)
        {
            if (m_Adapter == null)
                return uri;
            else
                return m_Adapter.ReplaceURIParameters(uri);
        }

        protected void Bind()
        {
            if(m_Adapter == null || m_Adapter.Session == null ||! m_Adapter.Session.Opened)
                return;

            string strUnit = TranslateURI(m_UnitURI);
            string strProp = TranslateURI(m_StatusProp);
            if (strUnit.Length < 1 || strProp.Length < 1)
                return;
            
            m_Adapter.Session.Subscribe(strUnit,strProp,SubscribeType.Change);
            ReLoad();
        }

        protected void Unbind()
        {
            if (m_Adapter == null || m_Adapter.Session == null || !m_Adapter.Session.Opened)
                return;

            string strUnit = TranslateURI(m_UnitURI);
            string strProp = TranslateURI(m_StatusProp);
            if (strUnit.Length < 1 || strProp.Length < 1)
                return;

            m_Adapter.Session.Subscribe(strUnit, strProp, SubscribeType.Change);
        }

        public void ReLoad()
        {
            if(m_Adapter == null || m_Adapter.Session == null || !m_Adapter.Session.Opened)
                return;

            object val = null;
            int iRet = m_Adapter.Session.Get(TranslateURI(m_UnitURI),TranslateURI(m_StatusProp),ref val);
            if(iRet != 0)
                return;
            Int32 iStatus = Convert.ToInt32(val);

            Status = iStatus;
        }


        //定义控件的 属性
        public int Status
        {
            get { return m_iStatus; }
            set
            {
                int iOld = m_iStatus;
                //if (iOld == value)
                //    return;
                m_iStatus = value;
                OnStatusChanged(iOld,m_iStatus);
            }
        }

        protected virtual void OnStatusChanged(Int32 iOldStatus,Int32 iStatus)
        {
 	        // Set status text
            lbStatus.Text = GetStatusText(iStatus);
            // Set status image
            picStatus.Image = GetStatusImage(iStatus);

            if (OnUnitStatusChanged != null)
                OnUnitStatusChanged(TranslateURI(m_UnitURI), iOldStatus, iStatus);
        }

        //在各个工序中重写
        protected virtual string GetStatusText(int iStatus)
        {
            return "未知";
        }

        //在各个工序中重写
        protected virtual Image GetStatusImage(int iStatus)
        {
            return null;
        }

        public string UnitURI
        {
            get { return m_UnitURI; }
            set
            {
                if(m_UnitURI == value)
                    return;
                m_UnitURI = value;
                Bind();
            }
        }

        //add by hyh 2012-04-01
        //用于满足邢钢新增了3流连铸机，而程序将连铸机流数写定为 4
        public int CCMFlowCount
        {
            get { return m_flowCount; }
            set
            {
                if (m_flowCount == value)
                    return;
                m_flowCount = value;
                Bind();
            }
        }
        //end

        public string StatusProperty
        {
            get { return m_StatusProp; }
            set
            {
                if (m_StatusProp == value)
                    return;
                m_StatusProp = value;
                Bind();
            }
        }

        public AppSvrHMI.L3Adapter L3Adapter
        {
            get { return m_Adapter; }
            set
            {
                if (m_Adapter == value)
                    return;

                if (m_Adapter != null)
                {
                    m_Adapter.OnSessionReady -= new Delegate_OnSessionReady(OnSessionReady);
                    m_Adapter.OnObjectPropChanged -= new Delegate_OnObjectPropChanged(OnObjectPropChanged);
                }

                m_Adapter = value;

                if (m_Adapter != null)
                {
                    m_Adapter.OnSessionReady += new Delegate_OnSessionReady(OnSessionReady);
                    m_Adapter.OnObjectPropChanged += new Delegate_OnObjectPropChanged(OnObjectPropChanged);
                }

                Bind();
            }
        }

        void OnSessionReady()
        {
            Bind();
        }

        void  OnObjectPropChanged(string strObj, string strProp, object newVal, object oldVal)
        {
            if (m_Adapter == null)
                return;

            if (strObj != TranslateURI(m_UnitURI) ||
                strProp != TranslateURI(m_StatusProp))
                return;

            Status = Convert.ToInt32(newVal);
        }

    }

   
}
