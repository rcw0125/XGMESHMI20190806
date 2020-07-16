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
        public static string strSQL = "";
        private void btnQuery_Click(object sender, EventArgs e)
        {


            string strsql = " select rownum as 序号,d.* from (   select a.userid as 账号,b.operator_name as 姓名,a.ip as ip地址,pcname as 计算机名,flag as 标志,c_ts as 登录时间,version as 版本号,c.des as 电脑描述,c.fzr as 电脑负责人,rn as 次数 from(select userid, ip, pcname, flag, c_ts, version, ";

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
            CommDataMag.CommonMethed.PutIntoExcel("日志统计", dvTel);
        }
    }

}