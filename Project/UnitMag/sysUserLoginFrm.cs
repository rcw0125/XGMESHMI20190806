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
    public partial class sysUserLoginFrm : DockContent, IMESForm
    {
        public sysUserLoginFrm()
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

 //           select a.userid as 账号,b.operator_name as 姓名,a.ip as ip地址,pcname as 计算机名,flag as 标志,c_ts as 登录时间,version as 版本号,c.des as 电脑描述,c.fzr as 电脑负责人 from(select userid, ip, pcname, flag, c_ts, version,
 //     row_number() over(partition by ip order by c_ts desc) rn

 //from ts_user_login) a,CBase_Operator_ID b, ts_ip c
 // where a.rn = 1 and a.userid = b.operator(+) and a.ip = c.ip(+) order by a.c_ts desc;
            string strsql = "  select a.userid as 账号,b.operator_name as 姓名,a.ip as ip地址,pcname as 计算机名,flag as 标志,c_ts as 登录时间,version as 版本号,c.des as 电脑描述,c.fzr as 电脑负责人 from(select userid, ip, pcname, flag, c_ts, version, ";

            strsql += "   row_number() over(partition by ip order by c_ts desc) rn";
            strsql += "   from ts_user_login) a,CBase_Operator_ID b, ts_ip c";
            strsql += "   where a.rn = 1 and a.userid = b.operator(+) and a.ip = c.ip(+) order by a.c_ts desc";

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='投料' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

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