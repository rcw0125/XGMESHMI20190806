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
    public partial class shoupiFrm : DockContent, IMESForm
    {
        public shoupiFrm()
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

            //            select ccmid as ����,heatid as ¯��,steelgrade as ����,decode(bloomweight,null,0,bloomweight) as ����,baocihao as ����,ironweight as ��ˮ,scrapweight as �ϸ�,pigironweight as ����,ykweight as ѹ��,steelweight as ��ˮ
            // from
            //(
            //  select substr(a.ccmid, 3, 1) || '#������' as ccmid, a.heatid, a.steelgrade,
            //       (select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight,
            //       (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,
            //       round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight
            // from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid and to_char(productiondate,'yyyy-MM-dd')= '2019-11-27' order by a.ccmid,a.productiondate
            // )
            string strStart = tdtstart.Value.ToString("yyyy-MM-dd");
            string strsql = "";
            if (toolStripComboBox1.Text == "" || toolStripComboBox1.Text == "ȫ��")
            {
                strsql = "      select ccmid as ����,heatid as ¯��,steelgrade as ����,baocihao as ����,productiondate as ����ʱ��,ironweight as ��ˮ,scrapweight as �ϸ�,pigironweight as ����,ykweight as ѹ��,steelweight as ��ˮ,decode(bloomweight,null,0,bloomweight) as ����";
                strsql += "        from (";
                strsql += "        select substr(a.ccmid, 3, 1) || '#������' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate ";
                strsql += "        from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '"+strStart+"' order by a.ccmid,a.productiondate ";
                strsql += "       )";
            }
            else
            {
                strsql = "      select ccmid as ����,heatid as ¯��,steelgrade as ����,baocihao as ����,productiondate as ����ʱ��,ironweight as ��ˮ,scrapweight as �ϸ�,pigironweight as ����,ykweight as ѹ��,steelweight as ��ˮ,decode(bloomweight,null,0,bloomweight) as ����";
                strsql += "        from (";
                strsql += "        select substr(a.ccmid, 3, 1) || '#������' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,round(ykweight, 2) as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate";
                strsql += "        from cccm_base_data a ,cbof_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '"+strStart+"' and a.ccmid='S6"+toolStripComboBox1.Text.Substring(0,1)+"' order by a.ccmid,a.productiondate ";
                strsql += "       )";
            }
            

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            dvTel.DataSource = data;
            bsMqhs.DataSource = data;
            
            //dsLog.SourceMethod = "select * from CRetrunData_NC where billtype='Ͷ��' and flag='1'  and To_Char(CreateTime,'yyyy-mm-dd') >= '" + strStart + "' and  To_Char(CreateTime,'yyyy-mm-dd') <= '" + strEnd + "' order by CreateTime desc";
            

        }

        private void NCTelDataFrm_Load(object sender, EventArgs e)
        {
            tdtstart.Value = DateTime.Now;
            toolStripComboBox1.SelectedIndex = 0;
            
        }



        private void dvTel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("����ͳ��", dvTel);
        }
    }
}