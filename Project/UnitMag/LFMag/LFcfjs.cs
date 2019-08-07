using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class LFcfjs : Form
    {
        public LFcfjs()
        {
            InitializeComponent();
        }

        public string strHeatid = "";
        public string strSteelgradeindex = "";
        string strGradeTypeSql = "";

        public double weight;
       

        public double C;
        public double Si;
        public double Mn;
        public double Cr;

        public double zd_c;
        public double zd_si;
        public double zd_mn;
        public double zd_cr;

        public double bc_zd_c;
        public double bc_zd_si;
        public double bc_zd_mn;
        public double bc_zd_cr;


        public double bc_time;



        private void LFcfjs_Load(object sender, EventArgs e)
        {
            if (strHeatid != "")
            {
                tbheatid.Text = strHeatid;
                tbheatid.Enabled = false;
                getGradeType();
                getAlloyData();
                getweight();
            }        
        }
        /// <summary>
        /// 获取钢种分类（硅镇静钢 还是硅铝镇静钢）
        /// </summary>
        public void getGradeType()
        {
            if (strSteelgradeindex != "")
            {
                //strGradeTypeSql = "select steelgrade_type from  CQA_STEELGRADEINDEX_R where steelgradeindex='" + strSteelgradeindex + "'";
                strGradeTypeSql = "  select a.steelgrade_type,b.steelgrade_des,b.c,b.si,b.mn,b.cr from  ";
                strGradeTypeSql += " CQA_STEELGRADEINDEX_R a,L_ALLOY_RATE b where a.steelgrade_type=b.steelgrade  ";
                strGradeTypeSql += " and  steelgradeindex='" + strSteelgradeindex + "'";
            }
            else
            {
                if (tbheatid.Text.Trim() != "")
                {
                    //select a.steelgrade_type,b.steelgrade_des,b.c,b.si,b.mn,b.cr from  CQA_STEELGRADEINDEX_R a, cplan_tapping c,L_ALLOY_RATE b

                    //where a.steelgradeindex = c.steelgradeindex and a.steelgrade_type = b.steelgrade and c.heatid = '241902094'
                    strGradeTypeSql = "select a.steelgrade_type,b.steelgrade_des,b.c,b.si,b.mn,b.cr from  CQA_STEELGRADEINDEX_R a, cplan_tapping c,L_ALLOY_RATE b";
                    strGradeTypeSql += " where a.steelgradeindex=c.steelgradeindex and a.steelgrade_type=b.steelgrade and c.heatid ='" + tbheatid.Text + "'";
                }
                else
                {
                    strGradeTypeSql = "";
                }
            }
            if (strGradeTypeSql != "")
            {
                var dt = UnitMag.MESTool.GetData(Adapter, strGradeTypeSql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    labelgrade.Text = dt.Rows[0]["steelgrade_des"].ToString();
                    tbC.Text= dt.Rows[0]["c"].ToString();
                    tbSi.Text = dt.Rows[0]["si"].ToString();
                    tbMn.Text = dt.Rows[0]["mn"].ToString();
                    tbCr.Text = dt.Rows[0]["cr"].ToString();
                    //string gradeType = dt.Rows[0][0].ToString();
                    //（硅）铝镇静钢
                    //if (gradeType == "2" || gradeType == "3" || gradeType == "4")
                    //{

                    //}
                    ////硅镇静钢
                    //else if (gradeType == "5")
                    //{

                    //}
                }
            }
        }

        /// <summary>
        /// 获取出钢量、终点c
        /// </summary>
        public void getweight()
        {
            string strSql = "select reblow_count,tapping_weight,reblow_time from cbof_process_data where heatid='" + tbheatid.Text.Trim() + "'";
            var dt = UnitMag.MESTool.GetData(Adapter, strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                if (Convert.ToDouble(dt.Rows[0]["tapping_weight"].ToString()) < 10)
                {
                    if (tbheatid.Text.Trim().StartsWith("24"))
                    {
                        tbweight.Text = "78";
                    }
                    else
                    {
                        tbweight.Text = "48";
                    }
                }
                else
                {
                    tbweight.Text =Math.Round(Convert.ToDouble(dt.Rows[0]["tapping_weight"].ToString()),3).ToString();
                    tbweight.Enabled = false;
                }

                bc_time = Convert.ToDouble(dt.Rows[0]["reblow_time"].ToString());
                lbre_time.Text = dt.Rows[0]["reblow_time"].ToString();

                strSql = "select c,si,mn,cr from cqa_lab_element where unittypeid='2' and  heatid='" + tbheatid.Text.Trim() + "' order by sample_count desc";
                var zddb = MESTool.GetData(Adapter, strSql);
                if (zddb != null && zddb.Rows.Count > 0)
                {
                    zd_c = Convert.ToDouble(zddb.Rows[0][0].ToString());
                    tbzdc.Text = zddb.Rows[0][0].ToString();
                    tbzdc.Enabled = false;

                    zd_si = Convert.ToDouble(zddb.Rows[0][1].ToString());
                    tbzdsi.Text = zddb.Rows[0][1].ToString();
                    tbzdsi.Enabled = false;

                    zd_mn = Convert.ToDouble(zddb.Rows[0][2].ToString());
                    tbzdmn.Text = zddb.Rows[0][2].ToString();
                    tbzdmn.Enabled = false;

                    zd_cr = Convert.ToDouble(zddb.Rows[0][3].ToString());
                    tbzdcr.Text = zddb.Rows[0][3].ToString();
                    tbzdcr.Enabled = false;
                }

                //补吹时间 大于 0
                if (bc_time > 0)
                {
                    ckbReblow.Checked = true;
                    ckbReblow.Enabled = false;
                    if (Convert.ToDouble(dt.Rows[0]["tapping_weight"].ToString()) > 60)
                    {
                        bc_zd_c = zd_c - bc_time * 0.01 / 4;
                        bc_zd_mn = zd_mn - bc_time * 0.01 / 8;
                    }
                    else
                    {
                        bc_zd_c = zd_c - bc_time * 0.01 / 3;
                        bc_zd_mn = zd_mn - bc_time * 0.01 / 8;
                    }
                    if (bc_zd_c < 0.03)
                    {
                        bc_zd_c = 0.03;
                    }

                    if (bc_zd_mn < 0.07)
                    {
                        bc_zd_mn = 0.07;
                    }

                    labelc.Text = Math.Round(bc_zd_c, 4).ToString();
                    labelmn.Text = Math.Round(bc_zd_mn, 4).ToString();
                }
                else
                {
                    bc_zd_c = zd_c;
                    bc_zd_mn = zd_mn;

                    labelc.Text = "";
                    labelmn.Text = "";
                }
            }
        }

        public List<Jzcf_alloydata> alloydataList = new List<Jzcf_alloydata>();
        public void getAlloyData()
        {
            string strSql = "select * from jzcfnew where heatid='"+tbheatid.Text.Trim()+"' order by element ";
            var dt = UnitMag.MESTool.GetData(Adapter, strSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                alloydataList.Clear();             
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Jzcf_alloydata alloydata = new Jzcf_alloydata();
                    alloydata.heatid = dt.Rows[i]["HEATID"].ToString();
                    alloydata.elment = dt.Rows[i]["ELEMENT"].ToString();
                    alloydata.type = dt.Rows[i]["TYPE"].ToString();
                    alloydata.weight = Convert.ToDouble(dt.Rows[i]["WEIGHT"].ToString());
                    alloydata.c = Convert.ToDouble(dt.Rows[i]["C"].ToString());
                    alloydata.si = Convert.ToDouble(dt.Rows[i]["SI"].ToString());
                    alloydata.mn = Convert.ToDouble(dt.Rows[i]["MN"].ToString());
                    alloydata.cr = Convert.ToDouble(dt.Rows[i]["CR"].ToString());
                    alloydataList.Add(alloydata);

                }                    
                dataGridView1.DataSource = alloydataList;
            }

        }
        //private void ckbSi_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckbSi.Checked)
        //    {
        //        ckbAl.Checked = false;
        //        tbC.Text = "0.90";
        //        tbSi.Text = "0.80";
        //        tbMn.Text = "0.95";
        //        tbCr.Text = "1";
        //    }
        //}

        //private void ckbAl_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ckbAl.Checked)
        //    {
        //        ckbSi.Checked = false;
        //        tbC.Text = "0.90";
        //        tbSi.Text = "0.90";
        //        tbMn.Text = "1";
        //        tbCr.Text = "1";
        //    }
        //}

        /// <summary>
        /// 计算成分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            JzcfModel jzcfmodel = new JzcfModel();
            jzcfmodel.alloydatalist = alloydataList;
            jzcfmodel.weight = Convert.ToDouble(tbweight.Text.Trim());
            try
            {
                jzcfmodel.zd_c = bc_zd_c;
                jzcfmodel.zd_mn = bc_zd_mn;
                jzcfmodel.zd_si = zd_si;
                jzcfmodel.zd_cr = zd_cr;
            }
            catch
            {
                MessageBox.Show("不是有效的数字");
                return;
            }
            try
            {
                jzcfmodel.c_rate = Convert.ToDouble(tbC.Text.Trim());
                jzcfmodel.si_rate = Convert.ToDouble(tbSi.Text.Trim());
                jzcfmodel.mn_rate = Convert.ToDouble(tbMn.Text.Trim());
                jzcfmodel.cr_rate = Convert.ToDouble(tbCr.Text.Trim());
                jzcfmodel.calC();
                jzcfmodel.calSi();
                jzcfmodel.calMn();
                jzcfmodel.calCr();
            }
            catch(Exception ex)
            {
                MessageBox.Show("出现异常："+ex.ToString());
                return;
            }
            C = Math.Round(jzcfmodel.c, 3);
            Si = Math.Round(jzcfmodel.si, 3);
            Mn = Math.Round(jzcfmodel.mn, 3);
            Cr = Math.Round(jzcfmodel.cr, 3);
            tbjsc.Text = C.ToString();
            tbjsSi.Text = Si.ToString();
            tbjsMn.Text = Mn.ToString();
            tbjsCr.Text = Cr.ToString();
            btnOk.Enabled = true;
        }
    }
}
