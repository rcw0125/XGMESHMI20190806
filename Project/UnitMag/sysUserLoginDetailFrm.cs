using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;


namespace UnitMag
{
    public partial class sysUserLoginDetailFrm : DockContent, IMESForm
    {
        public string Userid = "";
        public string Ip = "";
        public sysUserLoginDetailFrm()
        {
            InitializeComponent();
        }

        #region IMESForm ��Ա

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
        public static string strSQL = "";
        private void btnQuery_Click(object sender, EventArgs e)
        {


            string strsql = " select rownum as ���,d.* from (   select a.userid as �˺�,b.operator_name as ����,a.ip as ip��ַ,pcname as �������,flag as ��־,c_ts as ��¼ʱ��,version as �汾��,c.des as ��������,c.fzr as ���Ը�����,rn as ���� from(select userid, ip, pcname, flag, c_ts, version, ";

            strsql += "   row_number() over(partition by ip order by c_ts ) rn";
            strsql += "   from ts_user_login where c_ts >= to_char(sysdate-1,'yyyy-MM-dd') ) a,CBase_Operator_ID b, ts_ip c";
            strsql += "   where  a.userid = b.operator(+) and a.ip = c.ip(+)  ";
            if (toolStripTextBox1.Text.Trim() != "")
            {
                strsql += "   and (a.userid='"+ toolStripTextBox1.Text.Trim() + "' or a.ip like '%"+ toolStripTextBox1.Text.Trim() + "%') ";
            }
            strsql += "    order by a.c_ts desc ) d";
            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
          
            

        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            //tdtstart.Value = DateTime.Now;
            //tdtend.Value = DateTime.Now;
        }



        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("��־ͳ��", dvTel);
        }
    }

}