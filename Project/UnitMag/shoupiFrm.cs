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

        List<scsj> listscsj = new List<scsj>();
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

                if (toolStripComboBox1.Text.StartsWith("6"))
                {
                    strsql += "       union  select ccmid as ����,heatid as ¯��,steelgrade as ����,baocihao as ����,productiondate as ����ʱ��,ironweight as ��ˮ,scrapweight as �ϸ�,pigironweight as ����,ykweight as ѹ��,steelweight as ��ˮ,decode(bloomweight,null,0,bloomweight) as ����";
                    strsql += "        from (";
                    strsql += "        select substr(a.ccmid, 3, 1) || '#������' as ccmid, a.heatid, a.steelgrade,(select cal_weight  from cbloom_data where cbloom_data.heatid = a.heatid) as bloomweight, ";
                    strsql += "        (select substr(ccmid, 3, 1) || '-' || tundish_heatnum from cccm_process_data where cccm_process_data.heatid = a.heatid) as baocihao,";
                    strsql += "        round(b.ironweight, 2) as ironweight,round(b.scrapweight, 2) as scrapweight,round(b.pigironweight, 2) as pigironweight,0 as ykweight,c.weight as steelweight,to_char(a.productiondate,'HH24:MI:SS') as productiondate";
                    strsql += "        from cccm_base_data a ,caod_feed_data b, csteel_data c where a.heatid = b.heatid and a.heatid = c.heatid ";
                    strsql += "       and to_char(productiondate,'yyyy-MM-dd')= '" + strStart + "' and a.ccmid='S6" + toolStripComboBox1.Text.Substring(0, 1) + "' order by a.ccmid,a.productiondate ";
                    strsql += "       )";

                }
            }
            

            var data = UnitMag.MESTool.GetData(Adapter, strsql);
            listscsj.Clear();
            double ironweight = 0, scrapweight = 0, pigironweight = 0, ykweight = 0, steelweight = 0, shoupi = 0;
            if (data == null)
            {
                MessageBox.Show("û�в�ѯ�����ݣ�");
                return;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                scsj curscsj = new scsj();
                curscsj.���� = data.Rows[i]["����"].ToString();
                curscsj.¯�� = data.Rows[i]["¯��"].ToString();
                curscsj.���� = data.Rows[i]["����"].ToString();
                curscsj.���� = data.Rows[i]["����"].ToString();
                curscsj.����ʱ�� = data.Rows[i]["����ʱ��"].ToString();
                curscsj.��ˮ = (double)data.Rows[i]["��ˮ"];
                ironweight += curscsj.��ˮ;
                curscsj.�ϸ� = (double)data.Rows[i]["�ϸ�"];
                scrapweight += curscsj.�ϸ�;
                curscsj.���� = (double)data.Rows[i]["����"];
                pigironweight += curscsj.����;
                curscsj.ѹ�� = (double)data.Rows[i]["ѹ��"];
                ykweight += curscsj.ѹ��;
                curscsj.��ˮ = (double)data.Rows[i]["��ˮ"];
                steelweight += curscsj.��ˮ;
                curscsj.���� = (double)data.Rows[i]["����"];
                if (curscsj.���� > 1)
                {
                    curscsj.���� = Math.Round(curscsj.��ˮ * 1000 / curscsj.����, 1);
                }
                else
                {
                    curscsj.���� = 0;
                }
                
                shoupi += curscsj.����;
                listscsj.Add(curscsj);
            }
            //if ((toolStripComboBox1.Text != "" && toolStripComboBox1.Text != "ȫ��"))
            //{
               
            //}
            //�ۼ�
            scsj ljscsj = new scsj();
            ljscsj.���� = "�ۼ�";
            ljscsj.��ˮ = Math.Round(ironweight, 1);
            ljscsj.�ϸ� = Math.Round(scrapweight, 1);
            ljscsj.���� = Math.Round(pigironweight, 1);
            ljscsj.ѹ�� = Math.Round(ykweight, 1);
            ljscsj.��ˮ = Math.Round(steelweight, 1);
            ljscsj.���� = Math.Round(shoupi, 1);
            //ƽ��
            scsj pjscsj = new scsj();
            pjscsj.���� = "ƽ��";
            if (data.Rows.Count > 0)
            {
                pjscsj.��ˮ = Math.Round(ironweight / data.Rows.Count, 2);
                pjscsj.�ϸ� = Math.Round(scrapweight / data.Rows.Count, 2);
                pjscsj.���� = Math.Round(pigironweight / data.Rows.Count, 2);
                pjscsj.ѹ�� = Math.Round(ykweight / data.Rows.Count, 2);
                pjscsj.��ˮ = Math.Round(steelweight / data.Rows.Count, 2);
                pjscsj.���� = Math.Round(shoupi / data.Rows.Count, 2);
                pjscsj.���� = Math.Round(ljscsj.��ˮ*1000 / ljscsj.����, 2);
            }
            else
            {
                pjscsj.��ˮ = 0;
                pjscsj.�ϸ� = 0;
                pjscsj.���� = 0;
                pjscsj.ѹ�� = 0;
                pjscsj.��ˮ = 0;
                pjscsj.���� = 0;
                pjscsj.���� = 0;
            }
            listscsj.Add(ljscsj);
            listscsj.Add(pjscsj);


            dvTel.DataSource = null;
            dvTel.DataSource = listscsj;
            bsMqhs.DataSource = listscsj;
            
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

    public class scsj
    {
        //select ccmid as ����,heatid as ¯��,steelgrade as ����,baocihao as ����,productiondate as ����ʱ��,ironweight as ��ˮ,scrapweight as �ϸ�,
        //    pigironweight as ����,ykweight as ѹ��,steelweight as ��ˮ,decode(bloomweight,null,0, bloomweight) as ����
        public string ���� { get; set; }
        public string ¯�� { get; set; }
        public string ���� { get; set; }
        public string ���� { get; set; }
        public string ����ʱ�� { get; set; }

        public double ��ˮ { get; set; }
        public double �ϸ� { get; set; }
        public double ���� { get; set; }
        public double ѹ�� { get; set; }
        public double ��ˮ { get; set; }
        public double ���� { get; set; }

        public double ���� { get; set; }



    }
}