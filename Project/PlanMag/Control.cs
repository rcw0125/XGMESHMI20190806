using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
namespace PlanMag
{
    public partial class Control : DockContent, IMESForm
    {
        public Control()
        {
            InitializeComponent();
            cmBof.Text = "4#转炉";
          
            RefreshContent();
            //dataload();
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

        public void RefreshContent()
        {
            string sql = " select  a.heatid,a.AIM_TIME_IRONPREPARED,a.AIM_TIME_BOFSTART,a.AIM_TIME_BOFTAPPED,a.AIM_TIME_TAPPEDSIDEEND,a.AIM_TIME_LFARRIVAL,a.AIM_TIME_LFSTART,a.AIM_TIME_LFEND,a.AIM_TIME_LFLEAVE,a.AIM_TIME_RHARRIVAL,a.AIM_TIME_RHSTART,a.AIM_TIME_RHEND,a.AIM_TIME_RHLEAVE,a.AIM_TIME_CASTERARRIVAL,a.AIM_TIME_CASTINGSTART,a.AIM_TIME_CASTINGEND ,b.ACT_TIME_IRONPREPARED,b.ACT_TIME_BOFSTART,b.ACT_TIME_BOFTAPPED,b.ACT_TIME_TAPPEDSIDEEND,b.ACT_TIME_LFARRIVAL,b.ACT_TIME_LFSTART,b.ACT_TIME_LFEND,b.ACT_TIME_LFLEAVE,b.ACT_TIME_RHARRIVAL,b.ACT_TIME_RHSTART,b.ACT_TIME_RHEND, b.ACT_TIME_RHLEAVE,b.ACT_TIME_CASTERARRIVAL, b.ACT_TIME_CASTINGSTART,b.ACT_TIME_CASTINGEND from cplan_tapping a  ,cplan_tapping_act b where (a.status=11 or a.status=12) and a.heatid=b.heatid(+)";
            if (txtHeatid.Text.ToString().Trim() != "")
            {

                if (txtHeatid.Text.ToString().Trim().Length == 9)
                {
                    sql = sql + " and a.heatid='" + txtHeatid.Text + "'";
                }
                else 
                {
                    MessageBox.Show("炉号位数不对，请重新输入");
                    return;
                }
            
            }
            else 
            {
                if (cmBof.Text.ToString() != "")
                {
                    switch (cmBof.Text)
                    { 
                        case "1#转炉" :
                        sql=sql+" and a.bofid='S21'" ;
                        break;
                        case "2#转炉":
                        sql = sql + " and a.bofid='S22'";
                        break;
                        case "3#转炉":
                        sql = sql + " and a.bofid='S23'";
                        break;
                        case "4#转炉":
                        sql = sql + " and a.bofid='S24'";
                        break;
                    default: break;
                
                    }
                }
                else if (cmLf.Text.ToString() != "")
                {
                    switch (cmLf.Text)
                    {
                        case "1#LF":
                            sql = sql + " and a.lfid='S41'";
                            break;
                        case "2#LF":
                            sql = sql + " and a.lfid='S42'";
                            break;
                        case "3#LF":
                            sql = sql + " and a.lfid='S43'";
                            break;
                        case "4#LF":
                            sql = sql + " and a.lfid='S44'";
                            break;
                        case "5#LF":
                            sql = sql + " and a.lfid='S45'";
                            break;
                        default: break;

                    }
                }
                else if (cmCcm.Text.ToString() != "")
                {
                    switch (cmCcm.Text)
                    {
                        case "3#机":
                            sql = sql + " and a.CASTERID='S63'";
                            break;
                        case "4#机":
                            sql = sql + " and a.CASTERID='S64'";
                            break;
                        case "5#机":
                            sql = sql + " and a.CASTERID='S65'";
                            break;
                        case "6#机":
                            sql = sql + " and a.CASTERID='S66'";
                            break;
                        case "7#机":
                            sql = sql + " and a.CASTERID='S67'";
                            break;

                        default: break;

                    }
                }
                

            }
            

            


            sql = sql + " order by a.heatid";
            l3DataSet1.SourceMethod = sql;
            l3DataSet1.LoadData();
          
        
        }

       

        public void dataload()
        {
            int row = l3DataSet1.Tables[0].Rows.Count;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount=3*row;
       
            for (int i = 0; i < row; i++)
            { 
            dataGridView1.Rows[3*i].Cells[1].Value="计划时间";
            dataGridView1.Rows[3 * i].Cells[0].Value = l3DataSet1.Tables[0].Rows[i]["Heatid"].ToString();
            dataGridView1.Rows[3 * i].Cells[2].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[3].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[4].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFTapped"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[5].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_TappedSideEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[6].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[7].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[8].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[9].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFLeave"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[10].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[11].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[12].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[13].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHLeave"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[14].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CasterArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[15].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i].Cells[16].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingEnd"]).ToString("HH:mm:ss");


            //实际时间
            dataGridView1.Rows[3 * i+1].Cells[1].Value = "实际时间";
            //dataGridView1.Rows[3 * i+1].Cells[1].Value = l3DataSet1.Tables[0].Rows[i]["Heatid"].ToString();
            string timestr = "";
          
                //兑铁时刻
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_IronPrepared"]).ToString("MM-dd HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[2].Value = timestr;
            if (timestr == "12-30 00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[2].Value = "";

            }
            else 
            {
               
                dataGridView1.Rows[3 * i + 2].Cells[2].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_IronPrepared"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_IronPrepared"]);

                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[2].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_IronPrepared"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_IronPrepared"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[2].Style.BackColor = Color.Red;
                }
            }

                //开吹时刻
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[3].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[3].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[3].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFStart"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[3].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFStart"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFStart"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[3].Style.BackColor = Color.Red;
                }
            }
                //转炉结束
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFTapped"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[4].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[4].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[4].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFTapped"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFTapped"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[4].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFTapped"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFTapped"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[4].Style.BackColor = Color.Red;
                }
               
            }
                //炉后结束

            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[5].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[5].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[5].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_TappedSideEnd"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[5].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_TappedSideEnd"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[5].Style.BackColor = Color.Red;
                }
            }
                //精炼炉到达
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[6].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[6].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[6].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFArrival"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFArrival"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[6].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFArrival"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFArrival"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[6].Style.BackColor = Color.Red;
                }
            }

                //精炼炉处理开始
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[7].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[7].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[7].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFStart"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[7].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFStart"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFStart"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[7].Style.BackColor = Color.Red;
                }
            }
                //精炼炉处理结束
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[8].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[8].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[8].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFEnd"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[8].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFEnd"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFEnd"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[8].Style.BackColor = Color.Red;
                }
            }
                //精炼炉离站
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFLeave"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[9].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[9].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[9].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFLeave"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFLeave"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[9].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFLeave"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFLeave"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[9].Style.BackColor = Color.Red;
                }
            }
                //RH炉进站
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[10].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[10].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[10].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHArrival"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHArrival"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[10].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHArrival"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHArrival"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[10].Style.BackColor = Color.Red;
                }
            }
                //rh开始
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[11].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[11].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[11].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHStart"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[11].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHStart"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHStart"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[11].Style.BackColor = Color.Red;
                }
            }
                //rh结束
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[12].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[12].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[12].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHEnd"]);

                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[12].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHEnd"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHEnd"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[12].Style.BackColor = Color.Red;
                }
            }
                //RH离站
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHLeave"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[13].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[13].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[13].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHLeave"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHLeave"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[13].Style.BackColor = Color.Green;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHLeave"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHLeave"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[13].Style.BackColor = Color.Red;
                }
            }
                //大包到达
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CasterArrival"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[14].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[14].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[14].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CasterArrival"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CasterArrival"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[14].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CasterArrival"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CasterArrival"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[14].Style.BackColor = Color.Red;
                }
            }
                //大包开浇
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingStart"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[15].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[15].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[15].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingStart"]);
                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[15].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingStart"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingStart"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[15].Style.BackColor = Color.Red;
                }
            }
                //大包离站
            timestr = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingEnd"]).ToString("HH:mm:ss");
            dataGridView1.Rows[3 * i + 1].Cells[16].Value = timestr;
            if (timestr == "00:00:00")
            {
                dataGridView1.Rows[3 * i + 2].Cells[16].Value = "";

            }
            else
            {
                dataGridView1.Rows[3 * i + 2].Cells[16].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingEnd"]);

                //实际时间单元格颜色设置为蓝色
                dataGridView1.Rows[3 * i + 1].Cells[16].Style.BackColor = Color.GreenYellow;
                //实绩时间延迟，则警示为红色
                if (Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingEnd"]) > Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingEnd"]))
                {

                    dataGridView1.Rows[3 * i + 2].Cells[16].Style.BackColor = Color.Red;
                }
            }

             //节奏误差
            dataGridView1.Rows[3 * i + 2].Cells[1].Value = "节奏误差";
            
            //dataGridView1.Rows[3 * i + 2].Cells[3].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFStart"])-Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFStart"]);
            //dataGridView1.Rows[3 * i + 2].Cells[4].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_BOFTapped"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_BOFTapped"]);
            //dataGridView1.Rows[3 * i + 2].Cells[5].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_TappedSideEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_TappedSideEnd"]);
            //dataGridView1.Rows[3 * i + 2].Cells[6].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFArrival"])-Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFArrival"]);
            //dataGridView1.Rows[3 * i + 2].Cells[7].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFStart"]);
            //dataGridView1.Rows[3 * i + 2].Cells[8].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFEnd"]);
            //dataGridView1.Rows[3 * i + 2].Cells[9].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_LFLeave"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_LFLeave"]);
            //dataGridView1.Rows[3 * i + 2].Cells[10].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHArrival"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHArrival"]);
            //dataGridView1.Rows[3 * i + 2].Cells[11].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHStart"]);
            //dataGridView1.Rows[3 * i + 2].Cells[12].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHEnd"]);
            //dataGridView1.Rows[3 * i + 2].Cells[13].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_RHLeave"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_RHLeave"]);
            //dataGridView1.Rows[3 * i + 2].Cells[14].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CasterArrival"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CasterArrival"]);
            //dataGridView1.Rows[3 * i + 2].Cells[15].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingStart"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingStart"]);
            //dataGridView1.Rows[3 * i + 2].Cells[16].Value = Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Act_Time_CastingEnd"]) - Convert.ToDateTime(l3DataSet1.Tables[0].Rows[i]["Aim_Time_CastingEnd"]);

            
            }

           


        }


        private void button1_Click(object sender, EventArgs e)
        {
            RefreshContent();
            dataload();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridView1.Rows.Count < 0)
                return;
            if (dataGridView1.Rows[e.RowIndex].Cells[Column2.Index].Value.ToString().Trim() == "计划时间")
            {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gold;
            }
            try
            {
                //添加行号 
                SolidBrush v_SolidBrush = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
                int v_LineNo = 0;
                v_LineNo = e.RowIndex + 1;

                string v_Line = v_LineNo.ToString();


                e.Graphics.DrawString(v_Line, e.InheritedRowStyle.Font, v_SolidBrush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 5);

            }
            catch (Exception ex)
            {
                MessageBox.Show("添加行号时发生错误，错误信息：" + ex.Message, "操作失败");
            }
        }

        private void cmBof_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBof.Text.ToString() != "")
            {

                cmLf.Text = "";
                cmCcm.Text = "";
                txtHeatid.Text = "";
            }
        }

        private void cmLf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmLf.Text.ToString() != "")
            {

                cmBof.Text = "";
                cmCcm.Text = "";
                txtHeatid.Text = "";
            }
        }

        private void cmCcm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmCcm.Text.ToString() != "")
            {

                cmBof.Text = "";
                cmLf.Text = "";
                txtHeatid.Text = "";
            }
        }

        private void l3dbxTappingStatus_TextChanged(object sender, EventArgs e)
        {
            RefreshContent();
            dataload(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count<1)
            {
            return;
            }
            string heatid="";
            try 
            {
             heatid = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            }
            catch
            {
                return;
            }
        
         
            if (heatid == "")
            {
                MessageBox.Show("该行没有炉号，请选择炉号");
                return;
            }
            UpdateControl fm = new UpdateControl();
            fm.ShowDialog(Adapter.Session,heatid);
        }
    }
}