using EDoor.WinFormsUI.Docking;
using HMIBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace UnitMag.cut
{
    public partial class Caster3Cut : DockContent, IMESForm
    {
        public Caster3Cut()
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


        private void Caster3Cut_Load(object sender, EventArgs e)
        {
            strand s1 = new strand();
            s1.strandid = 1;
            strand s2 = new strand();
            s2.strandid = 2;
            strand s3 = new strand();
            s3.strandid = 3;
            strand s4 = new strand();
            s4.strandid = 4;
            strandData.Add(s1);
            strandData.Add(s2);
            strandData.Add(s3);
            strandData.Add(s4);



            setupConfig();
            dataGridView1.DataSource = strandData;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            GetData();
        }

        public StrindData strandData = new StrindData();

        public string ccmid = "S63";
        public cutStrandInfo strand1 = new cutStrandInfo();
        public cutStrandInfo strand2 = new cutStrandInfo();
        public cutStrandInfo strand3 = new cutStrandInfo();
        public cutStrandInfo strand4 = new cutStrandInfo();

        public void setupConfig()
        {

            int pointX = 500;
            strand1.strandid = 1;
            strand1.circlePointX = pointX;
            strand1.circlePointY = 50;
            strand1.radius = 200;
            strand1.gunaochangdu = 450;
            strand1.shijigunaochangdu = 30;
            strand1.huoqiejiweizhi = 24.8;
            strand1.shanxingweizhi = 14.13;
            strand1.zhupiStart = 30;
            strand1.zhupiEnd = 5;
            int pointCha = 70;

            strand2.strandid = 2;
            strand2.circlePointX = pointX;
            strand2.circlePointY = 50 + pointCha;
            strand2.radius = 200;
            strand2.gunaochangdu = 450;
            strand2.shijigunaochangdu = 30;
            strand2.huoqiejiweizhi = 24.8;
            strand2.shanxingweizhi = 14.13;
            strand2.zhupiStart = 30;
            strand2.zhupiEnd = 5;

            strand3.strandid = 3;
            strand3.circlePointX = pointX;
            strand3.circlePointY = 50 + 2 * pointCha;
            strand3.radius = 200;
            strand3.gunaochangdu = 450;
            strand3.shijigunaochangdu = 30;
            strand3.huoqiejiweizhi = 24.8;
            strand3.shanxingweizhi = 14.13;
            strand3.zhupiStart = 30;
            strand3.zhupiEnd = 5;

            strand4.strandid = 4;
            strand4.circlePointX = pointX;
            strand4.circlePointY = 50 + 3 * pointCha;
            strand4.radius = 200;
            strand4.gunaochangdu = 450;
            strand4.shijigunaochangdu = 30;
            strand4.huoqiejiweizhi = 24.8;
            strand4.shanxingweizhi = 14.13;
            strand4.zhupiStart = 30;
            strand4.zhupiEnd = 5;
        }



        public void Redraw()
        {
            lbladlefeng.Visible = false;
            lbladlefeng2.Visible = false;
            lbladlefeng3.Visible = false;
            lbladlefeng4.Visible = false;
            drawCircle(strand1);
            drawCircle(strand2);
            drawCircle(strand3);
            drawCircle(strand4);
        }

        public void drawCircle(cutStrandInfo strand)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Gray, 10);
            Pen redpen = new Pen(Color.Red, 4);
            Pen cutpen = new Pen(Color.Red, 20);
            Pen fengpen = new Pen(Color.Green, 10);
            int gundaofeng = 3;

           

            #region 1、弧形+辊道 2、火切机位置  静态的
            //弧形+辊道
            graphics.DrawArc(pen, strand.circlePointX - strand.radius, strand.circlePointY - strand.radius, 2 * strand.radius, 2 * strand.radius, 90, 90);
            graphics.DrawLine(pen, strand.circlePointX + gundaofeng, strand.circlePointY + strand.radius, strand.circlePointX + strand.gunaochangdu + gundaofeng, strand.circlePointY + strand.radius);
            //火切机位置
            int hqj = Convert.ToInt32((strand.huoqiejiweizhi - strand.shanxingweizhi) * strand.gunaochangdu / strand.shijigunaochangdu);
            graphics.DrawLine(cutpen, strand.circlePointX + hqj + gundaofeng, strand.circlePointY + strand.radius, strand.circlePointX + hqj + 3 + gundaofeng, strand.circlePointY + strand.radius);
            #endregion

            #region 红坯位置
            //坯头位置不超过辊道+扇形长度
            if (strand.zhupiStart > strand.shijigunaochangdu+ strand.shanxingweizhi)
            {
                strand.zhupiStart = strand.shijigunaochangdu+ strand.shanxingweizhi;
            }
            //铸坯头超过扇形段
            if (strand.zhupiStart > strand.shanxingweizhi)
            {
                //铸坯尾没有超过扇形段，绘制弧度和直线
                if (strand.zhupiEnd < strand.shanxingweizhi)
                {
                    int hudu = Convert.ToInt32((strand.shanxingweizhi - strand.zhupiEnd) * 90.0 / strand.shanxingweizhi);
                    graphics.DrawArc(redpen, strand.circlePointX - strand.radius, strand.circlePointY - strand.radius, 2 * strand.radius, 2 * strand.radius, 90, hudu);
                    int changdu = Convert.ToInt32((strand.zhupiStart - strand.shanxingweizhi) * strand.gunaochangdu / strand.shijigunaochangdu);
                    graphics.DrawLine(redpen, strand.circlePointX + gundaofeng, strand.circlePointY + strand.radius, strand.circlePointX + changdu + gundaofeng, strand.circlePointY + strand.radius);
                }
                //铸坯尾超过扇形段 绘制直线
                else
                {
                    int qidian = Convert.ToInt32((strand.zhupiEnd - strand.shanxingweizhi) * strand.gunaochangdu / strand.shijigunaochangdu);

                    int changdu = Convert.ToInt32((strand.zhupiStart - strand.zhupiEnd) * strand.gunaochangdu / strand.shijigunaochangdu);
                    graphics.DrawLine(redpen, strand.circlePointX + gundaofeng + qidian, strand.circlePointY + strand.radius, strand.circlePointX + changdu + gundaofeng + qidian, strand.circlePointY + strand.radius);
                }

            }
            else
            {
                if (strand.zhupiStart > strand.zhupiEnd)
                {
                    int hudu = Convert.ToInt32((strand.zhupiStart - strand.zhupiEnd) * 90.0 / strand.shanxingweizhi);

                    int qidian = Convert.ToInt32((strand.shanxingweizhi - strand.zhupiStart) * 90.0 / strand.shanxingweizhi);
                    graphics.DrawArc(redpen, strand.circlePointX - strand.radius, strand.circlePointY - strand.radius, 2 * strand.radius, 2 * strand.radius, 90+qidian, hudu);

                }
              
            }
            #endregion


            foreach (var item in strand.listfeng)
            {
                //end点的跟踪值-缝跟踪值-  +end点的位置
                double fengweizhi = strand.endtrack - item.endTrack + strand.zhupiEnd;
                if (fengweizhi < strand.shanxingweizhi)
                {
                    int starthudu = Convert.ToInt32(180 - fengweizhi * 90.0 / strand.shanxingweizhi);
                    if (starthudu > 177)
                    {
                        starthudu = 177;
                    }
                    
                    graphics.DrawArc(fengpen, strand.circlePointX - strand.radius, strand.circlePointY - strand.radius, 2 * strand.radius, 2 * strand.radius, starthudu, 3);
                    if (strand.strandid==1)
                    {
                        lbladlefeng.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX - strand.radius * Math.Sin((starthudu - 90) * Math.PI / 180));                
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius * Math.Cos((starthudu - 90) * Math.PI / 180)) - 20;
                        lbladlefeng.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 2&&lbladlefeng.Visible==false)
                    {
                        lbladlefeng2.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX - strand.radius * Math.Sin((starthudu - 90) * Math.PI / 180));
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius * Math.Cos((starthudu - 90) * Math.PI / 180)) - 20;
                        lbladlefeng2.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng2.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 3 && lbladlefeng.Visible == false && lbladlefeng2.Visible == false)
                    {
                        lbladlefeng3.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX - strand.radius * Math.Sin((starthudu - 90) * Math.PI / 180));
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius * Math.Cos((starthudu - 90) * Math.PI / 180)) - 20;
                        lbladlefeng3.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng3.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 3 && lbladlefeng.Visible == false && lbladlefeng2.Visible == false && lbladlefeng3.Visible == false)
                    {
                        lbladlefeng4.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX - strand.radius * Math.Sin((starthudu - 90) * Math.PI / 180));
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius * Math.Cos((starthudu - 90) * Math.PI / 180)) - 20;
                        lbladlefeng4.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng4.Text = "大包缝炉号:" + item.heatid;
                    }
                }
                else
                {
                    int changdu = Convert.ToInt32((fengweizhi - strand.shanxingweizhi) * strand.gunaochangdu / strand.shijigunaochangdu);
                    graphics.DrawLine(fengpen, strand.circlePointX + changdu + gundaofeng, strand.circlePointY + strand.radius, strand.circlePointX + changdu + 3 + gundaofeng, strand.circlePointY + strand.radius);

                    if (strand.strandid == 1)
                    {
                        lbladlefeng.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX + changdu + gundaofeng);
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius-20);
                        lbladlefeng.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 2 && lbladlefeng.Visible == false)
                    {
                        lbladlefeng2.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX + changdu + gundaofeng);
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius - 20);
                        lbladlefeng2.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng2.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 3 && lbladlefeng.Visible == false && lbladlefeng2.Visible == false)
                    {
                        lbladlefeng3.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX + changdu + gundaofeng);
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius - 20);
                        lbladlefeng3.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng3.Text = "大包缝炉号:" + item.heatid;
                    }
                    else if (strand.strandid == 3 && lbladlefeng.Visible == false && lbladlefeng2.Visible == false && lbladlefeng3.Visible == false)
                    {
                        lbladlefeng4.Visible = true;
                        int lableX = Convert.ToInt32(strand.circlePointX + changdu + gundaofeng);
                        int lableY = Convert.ToInt32(strand.circlePointY + strand.radius - 20);
                        lbladlefeng4.Location = new System.Drawing.Point(lableX, lableY);
                        lbladlefeng4.Text = "大包缝炉号:" + item.heatid;
                    }
                }
            }

        }

        public void GetData()
        {
            var db = new DbHelp("192.168.36.162", "cmsdb", "sa", "xgmes");

            #region 获取大包缝数据
            //SELECT   ccmid, strandid, heatid, endtrack  FROM cut_ladlefenginfo  WHERE status = 0 AND ccmid = 'S63'
            string fengsql = "SELECT   ccmid, strandid, heatid, endtrack  FROM cut_ladlefenginfo  WHERE status = 0 AND ccmid = '" + ccmid + "'";
            var fengdt = db.Query(fengsql);
            foreach (var item in strandData)
            {
                item.heatid = "";
                item.endtrack = 0;
            }
            strand1.listfeng.Clear();
            strand2.listfeng.Clear();
            strand3.listfeng.Clear();
            strand4.listfeng.Clear();
            foreach (DataRow item in fengdt.Rows)
            {
                int i = Convert.ToInt32(item["strandid"]);
                strandData[i - 1].heatid = item["heatid"].ToString();
                strandData[i - 1].endtrack = Convert.ToDouble(item["endtrack"]);

                ladleFeng lf = new ladleFeng();
                lf.heatid = item["heatid"].ToString();
                lf.endTrack = Convert.ToDouble(item["endtrack"]);

                if (i == 1)
                {
                    strand1.listfeng.Add(lf);
                }
                else if (i == 2)
                {
                    strand2.listfeng.Add(lf);
                }
                else if (i == 3)
                {
                    strand3.listfeng.Add(lf);
                }
                else if (i == 4)
                {
                    strand4.listfeng.Add(lf);
                }
            }
            #endregion


            #region 获取实时位置数据
            string sql = "SELECT TOP (4) * FROM cut_strand_info_his order by c_ts desc ";
            var dt = db.Query(sql);
            var infoList = dt_to_list(dt);
            foreach (var item in infoList)
            {
                if (item.strandid == 1)
                {
                    strand1.zhupiStart = item.zhupiStart;
                    strandData[0].zhupistart = item.zhupiStart;
                    strand1.zhupiEnd = item.zhupiEnd;
                    strand1.starttrack = item.starttrack;
                    strand1.endtrack = item.endtrack;
                }
                else if (item.strandid == 2)
                {
                    strand2.zhupiStart = item.zhupiStart;
                    strand2.zhupiEnd = item.zhupiEnd;
                    strandData[1].zhupistart = item.zhupiStart;
                    strand2.starttrack = item.starttrack;
                    strand2.endtrack = item.endtrack;
                }
                else if (item.strandid == 3)
                {
                    strand3.zhupiStart = item.zhupiStart;
                    strand3.zhupiEnd = item.zhupiEnd;
                    strandData[2].zhupistart = item.zhupiStart;
                    strand3.starttrack = item.starttrack;
                    strand3.endtrack = item.endtrack;
                }
                else if (item.strandid == 4)
                {
                    strand4.zhupiStart = item.zhupiStart;
                    strand4.zhupiEnd = item.zhupiEnd;
                    strandData[3].zhupistart = item.zhupiStart;
                    strand4.starttrack = item.starttrack;
                    strand4.endtrack = item.endtrack;
                }
            }
            #endregion

            #region 获取最近100条切割数据
            //SELECT top(30)    strandid ,heatid ,toutrack,weitrack ,fengtrack ,c_ts FROM cut_info order by c_ts desc;
            string cutsql = "SELECT top(100)    strandid ,heatid ,toutrack,weitrack ,fengtrack ,c_ts, Round(weitrack-toutrack,1)  as changdu FROM cut_info where ccmid='" + ccmid + "' order by c_ts desc";
            var cutdt = db.Query(cutsql);
            //dataGridView2.DataSource = null;
            dataGridView2.DataSource = cutdt;
            #endregion


            #region 重新绘制图形
            Redraw();
            #endregion


        }

        public List<StrandInfo> dt_to_list(DataTable dt)
        {
            List<StrandInfo> trainlist = new List<StrandInfo>();
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    StrandInfo tinfo = new StrandInfo();
                    tinfo.strandid = Convert.ToInt32(item["strandid"]);
                    tinfo.heatid = item["heatid"].ToString();
                    tinfo.zhupiStart = Convert.ToDouble(item["zhupiStart"]);
                    tinfo.zhupiEnd = Convert.ToDouble(item["zhupiEnd"]);
                    tinfo.starttrack = Convert.ToDouble(item["starttrack"]);
                    tinfo.endtrack = Convert.ToDouble(item["endtrack"]);
                    tinfo.speed = Convert.ToDouble(item["speed"]);
                    tinfo.c_ts = item["c_ts"].ToString();
                    trainlist.Add(tinfo);
                }
            }
            return trainlist;
        }
        public class StrindData : BindingList<strand>
        {
            public void Refresh()
            {
                ListChangedEventArgs arg = new ListChangedEventArgs(ListChangedType.Reset, -1);
                this.OnListChanged(arg);
            }
        }
        public class strand : INotifyPropertyChanged
        {
            public int strandid { get; set; }

            public string _heatid;
            public string heatid 
            {
                get
                {
                    return _heatid;
                }
                set
                {
                    _heatid = value;
                    RaisePropertyChanged("heatid");

                }
            }

            public double _endtrack;
            public double endtrack 
            {
                get
                {
                    return _endtrack;
                }
                set
                {
                    _endtrack = value;
                    RaisePropertyChanged("endtrack");

                }
            }

            public double _zhupistart;
            public double zhupistart
            {
                get
                {
                    return _zhupistart;
                }
                set
                {
                    _zhupistart = value;
                    RaisePropertyChanged("zhupistart");

                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void RaisePropertyChanged(string prop)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
