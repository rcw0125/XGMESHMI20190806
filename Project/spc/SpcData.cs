using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
//using XGMESMain;
using System.Configuration;
namespace spc
{
    public class SpcChartData : INotifyPropertyChanged
    {
        private double d2 = 1.128;
        private double E2
        {
            get
            {
                return 3 / d2;
            }
        }
        private double D4 = 3.267;
        private double D3 = 0;
        //2016-07-21
        //public SpcDataItem Add(double x)
        //{
        //    SpcDataItem spi = new SpcDataItem(this.Data.Count+1, x);
        //    if (this.Data.Count > 0)
        //    {
        //        double y1 = Math.Abs(x - this.Data[this.Data.Count - 1].X);
        //        spi.R = y1;
        //    }
        //    this.Data.Add(spi);
        //    return spi;
        //}

        private SpcData data = new SpcData();

        public SpcData Data
        {
            get { return data; }
            set { data = value; }
        }

        public void Clear()
        {
            Data.Clear();
            _avgX = null;
            _MR = null;
        }

        public void Refresh()
        {
            //计算均值
            calAvgX();
            //计算平均移动极差
            calMR();
            //均方差
            calMse();

            // 将计算的结果赋值给每一项
            foreach (SpcDataItem item in Data)
            {
                //y1 = double.Parse(this.AvgX).ToString("########0.0000"));
                item.ResetRowState();
                if (item.AvgX < 0.000000001 || item.Idx > Data.Count - 2)
                {
                    if (this.AvgX == null)
                    {
                        item.AvgX = 0;
                    }
                    else
                    {
                        item.AvgX = (double)this.AvgX;
                    }
                }

                if (item.MR == 0 || item.Idx > Data.Count - 2)
                {
                    if (this.MR == null)
                    {
                        item.MR = 0;
                    }
                    else
                    {
                        item.MR = (double)this.MR;
                    }
                }

                if (item.Mse == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.Mse == null)
                    {
                        item.Mse = 0;
                    }
                    else
                    {
                        item.Mse = (double)this.Mse;
                    }
                }

                if (item.USL == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.USL == null)
                    {
                        item.USL = 0;
                    }
                    else
                    {
                        item.USL = (double)this.USL;
                    }
                }

                if (item.LSL == 0 || item.Idx > Data.Count - 2)
                {
                    if (this.LSL == null)
                    {
                        item.LSL = 0;
                    }
                    else
                    {
                        item.LSL = (double)this.LSL;
                    }
                }


                if (item.USLX == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.UCLx == null)
                    {
                        item.USLX = 0;
                    }
                    else
                    {
                        item.USLX = (double)this.UCLx;
                    }
                }

                if (item.LSLX == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.LCLx == null)
                    {
                        item.LSLX = 0;
                    }
                    else
                    {
                        item.LSLX = (double)this.LCLx;
                    }
                }



                if (item.USLR == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.UCLr == null)
                    {
                        item.USLR = 0;
                    }
                    else
                    {
                        item.USLR = (double)this.UCLr;
                    }
                }

                if (item.LSLR == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.LCLr == null)
                    {
                        item.LSLR = 0;
                    }
                    else
                    {
                        item.LSLR = (double)this.LCLr;
                    }
                }


                if (item.Cp == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.Cp == null)
                    {
                        item.Cp = 0;
                    }
                    else
                    {
                        item.Cp = (double)this.Cp;
                    }
                }

                if (item.Cpk == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.Cpk == null)
                    {
                        item.Cpk = 0;
                    }
                    else
                    {
                        item.Cpk = (double)this.Cpk;
                    }
                }


                if (item.Pp == 0 || item.Idx > Data.Count - 2)
                {
                    if (this.Pp == null)
                    {
                        item.Pp = 0;
                    }
                    else
                    {
                        item.Pp = (double)this.Pp;
                    }
                }

                if (item.Ppk == 0 || item.Idx > Data.Count - 2)
                {

                    if (this.Ppk == null)
                    {
                        item.Ppk = 0;
                    }
                    else
                    {
                        item.Ppk = (double)this.Ppk;
                    }
                }
                    

                //每个点判断是否报警
                item.Alarm();
            }

            this.Data.Refresh();


        }

        //计算均值 总和除以个数
        private void calAvgX()
        {
            if (this.Data.Count == 0)
                AvgX = null;
            else
            {
                double total = 0;
                foreach (SpcDataItem item in this.data)
                {
                    total += item.X;
                }
                AvgX = total / this.Data.Count;
            }
        }

        //极差的均值
        private void calMR()
        {
            if (this.Data.Count <= 1)
                _MR = null;
            else
            {
                double total = 0;
                foreach (SpcDataItem item in this.Data)
                {
                    total += item.R;
                }
                _MR = total / (this.Data.Count - 1);
            }
        }

        //方差
        private void calMse()
        {
            if (this.Data.Count <= 0)
                Mse = null;
            else
            {
                if (AvgX == null)
                {
                    Mse = null;
                }
                else
                {
                    double total = 0;
                    double avg = AvgX.Value;
                    foreach (SpcDataItem item in this.Data)
                    {
                        total += (item.X - avg) * (item.X - avg);
                    }

                    Mse = Math.Sqrt(total / (this.Data.Count - 1));
                }
            }
        }

        private double? _avgX = null;
        //X
        public double? AvgX
        {
            get
            {
                return _avgX.GetValueOrDefault();
            }
            set
            {
                if (_avgX != value)
                {
                    _avgX = value;
                    RaisePropertyChanged("AvgX");
                    //RaisePropertyChanged("UCLx");
                    //RaisePropertyChanged("LCLx");
                    //RaisePropertyChanged("Cp");
                    //RaisePropertyChanged("Cpk");
                    //RaisePropertyChanged("Pp");
                    //RaisePropertyChanged("Ppk");
                }
            }
        }

        private double? _MR = null;
        //MR
        public double? MR
        {
            get
            {
                return _MR.GetValueOrDefault();
            }
            set
            {
                if (_MR != value)
                {
                    _MR = value;
                    RaisePropertyChanged("MR");
                    //RaisePropertyChanged("Sd");
                    //RaisePropertyChanged("UCLx");
                    //RaisePropertyChanged("LCLx");
                    //RaisePropertyChanged("UCLr");
                    //RaisePropertyChanged("LCLr");
                    //RaisePropertyChanged("Cp");
                    //RaisePropertyChanged("Cpk");
                }
            }
        }

        /// <summary>
        /// 标准差
        /// </summary>
        public double? Sd
        {
            get
            {
                return MR / d2;
            }
        }

        private double? _Mse = 0;
        //均方差
        public double? Mse
        {
            get
            {
                return _Mse;
            }
            set
            {
                if (_Mse != value)
                {
                    _Mse = value;
                    RaisePropertyChanged("Mse");
                    RaisePropertyChanged("Sd");
                    RaisePropertyChanged("UCLx");
                    RaisePropertyChanged("LCLx");
                    RaisePropertyChanged("UCLr");
                    RaisePropertyChanged("LCLr");
                    RaisePropertyChanged("Cp");
                    RaisePropertyChanged("Cpk");
                    RaisePropertyChanged("Pp");
                    RaisePropertyChanged("Ppk");
                }
            }
        }

        public double? UCLx
        {
            get
            {
                return AvgX + E2 * MR;
            }
        }

        public double? LCLx
        {
            get
            {
                return AvgX - E2 * MR;
            }
        }

        public double? UCLr
        {
            get
            {
                return D4 * MR;
            }
        }

        public double? LCLr
        {
            get
            {
                return D3 * MR;
            }
        }

        private double? _USL = 0;

        public double? USL
        {
            get { return _USL; }
            set
            {
                if (_USL != value)
                {
                    _USL = value;
                    RaisePropertyChanged("USL");
                    //RaisePropertyChanged("Cp");
                    //RaisePropertyChanged("Cpk");
                    //RaisePropertyChanged("Pp");
                    //RaisePropertyChanged("Ppk");
                }
            }
        }

        private double? _LSL = 0;

        public double? LSL
        {
            get { return _LSL; }
            set
            {
                if (_LSL != value)
                {
                    _LSL = value;
                    RaisePropertyChanged("LSL");
                    //RaisePropertyChanged("Cp");
                    //RaisePropertyChanged("Cpk");
                    //RaisePropertyChanged("Pp");
                    //RaisePropertyChanged("Ppk");
                }
            }
        }

        public double? Cp
        {
            get
            {
                return (USL - LSL) / (6 * Sd);
            }
        }

        public double? Cpk
        {
            get
            {
                double? CPU = (USL - AvgX) / (3 * Sd);
                double? CPL = (AvgX - LSL) / (3 * Sd);

                if (CPU != null && CPL != null)
                {
                    if (LSL < 0.00000001)
                    {
                        return CPU.Value;
                    }
                    else
                        return Math.Min(CPU.Value, CPL.Value);
                }
                return null;


            }
        }

        public double? Pp
        {
            get
            {
                return (USL - LSL) / (6 * Mse);
            }
        }

        public double? Ppk
        {
            get
            {
                double? PPU = (USL - AvgX) / (3 * Mse);
                double? PPL = (AvgX - LSL) / (3 * Mse);

                if (PPU != null && PPL != null)
                {
                    if (LSL < 0.00000001)
                    {
                        return PPU.Value;
                    }
                    else
                    {
                        return Math.Min(PPU.Value, PPL.Value);
                    }
                }
                else
                {
                    return null;
                }





            }
        }



        public SpcData getAllAlarm()
        {
            SpcData alarmItem = new SpcData();
            for (int i = Data.Count - 1; i >= 0; i--)
            {
                SpcDataItem item = Data[i];
                if (item.AlarmType != "")
                {
                    alarmItem.Add(item);
                }
            }
            return alarmItem;
        }

        public SpcData orderItem()
        {
            SpcData orderItem = new SpcData();
            for (int i = Data.Count - 1; i >= 0; i--)
            {
                SpcDataItem item = Data[i];
                orderItem.Add(item);
                //SpcDataItem item = new SpcDataItem();
                //item.Idx = Data[i].Idx;
                //item.ShiJian = Data[i].ShiJian;
                //item.HeatId = Data[i].HeatId;
                //item.steelgradeindex = Data[i].steelgradeindex;
                //item.AlarmType = Data[i].AlarmType;
                //item.YuanYin = Data[i].YuanYin;
                //item.GaiJin = Data[i].GaiJin;
                //item.Guid = Data[i].Guid;
                //item.AnaItem = Data[i].AnaItem;
                //item.AnaType = Data[i].AnaType;
                //item.X = Data[i].X;
                //item.R = Data[i].R;
                //item.USL = Data[i].USL;
                //item.LSL = Data[i].LSL;
                //item.AvgX = Data[i].AvgX;
                //// item.Sd = Data[i].Sd;
                //item.USLX = Data[i].USLX;
                //item.LSLX = Data[i].LSLX;
                //item.MR = Data[i].MR;

                //item.USLR = Data[i].USLR;
                //item.LSLR = Data[i].LSLR;
                //item.Cp = Data[i].Cp;
                //item.Cpk = Data[i].Cpk;
                //item.Pp = Data[i].Pp;
                //item.Ppk = Data[i].Ppk;
                //orderItem.Add(item);


            }
            return orderItem;
        }

        private DataCollection zhifang = null;
        public DataCollection Zhifang
        {
            get
            {
                if (zhifang == null)
                {
                    zhifang = new DataCollection();
                    //   CalZhiFang();
                }
                return zhifang;
            }
            set
            {
                zhifang = value;
            }
        }
        //均值+3*Sd
        public double? ZFMaxY
        {
            get
            {
                return AvgX + 3 * Sd;
            }
        }
        ////均值-3*Sd
        public double? ZFMinY
        {
            get
            {
                return AvgX - 3 * Sd;
            }
        }
        //
        public double? ZFIntervalWidth
        {
            get
            {

                return (ZFMaxY - ZFMinY) / 12;
                // return (ZFMaxY - ZFMinY) / 6;
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

    public class SpcData : BindingList<SpcDataItem>
    {
        //2016-07-21
        //public SpcDataItem Add(double x)
        //{
        //    SpcDataItem spi = new SpcDataItem(this.Count, x);
        //    if (this.Count > 0)
        //    {
        //        double y1 = Math.Abs(x - this.Items[this.Count - 1].X);
        //        spi.R = y1;
        //    }
        //    this.Add(spi);
        //    return spi;
        //}
        public void Refresh()
        {
            ListChangedEventArgs arg = new ListChangedEventArgs(ListChangedType.Reset, -1);
            this.OnListChanged(arg);
        }


    }
    //spc各项数据定义
    public class SpcDataItem : INotifyPropertyChanged
    {
        private static double d2 = 1.128;
        private static double E2 = 3 / d2;
        private static double D4 = 3.267;
        private static double D3 = 0;

        private int _idx;
        /// <summary>
        /// 序号
        /// </summary>
        [DisplayName("序号")]
        public int Idx
        {
            get { return _idx; }
            set
            {
                if (_idx != value)
                {
                    _idx = value;
                    RaisePropertyChanged("Idx");
                }
            }
        }

        private DateTime? shijian = null;
        /// <summary>
        /// 时间
        /// </summary>
        [DisplayName("时间")]
        public DateTime? ShiJian
        {
            get { return shijian; }
            set
            {
                if (shijian != value)
                {
                    shijian = value;
                    RaisePropertyChanged("ShiJian");
                }
            }
        }

        private string heatId = "";
        /// <summary>
        /// 炉次号
        /// </summary>
        [DisplayName("炉次号")]
        public string HeatId
        {
            get { return heatId; }
            set
            {
                if (heatId != value)
                {
                    heatId = value;
                    RaisePropertyChanged("HeatId");
                }
            }
        }

        private string _team = "";
        /// <summary>
        /// 班次
        /// </summary>
        [DisplayName("班次")]
        public string team
        {
            get { return _team; }
            set
            {

                if (_team != value)
                {
                    _team = value;
                    RaisePropertyChanged("team");
                }

            }
        }

         private string _steelgradeindex = "";
        /// <summary>
        /// 炉次号
        /// </summary>
        [DisplayName("炼钢记号")]
        public string steelgradeindex
        {
            get { return _steelgradeindex; }
            set
            {

                if (_steelgradeindex != value)
                {
                    _steelgradeindex = value;
                    RaisePropertyChanged("steelgradeindex");
                }
                
            }
        }


   

        private string alarmType = "";
        [DisplayName("异常描述")]
        public string AlarmType
        {
            get
            {
                return alarmType;
            }
            set
            {
                if (alarmType != value)
                {
                    alarmType = value;
                    RaisePropertyChanged("AlarmType");
                    // rowState = DataRowState.Modified;
                }
            }
        }

        private string yuanYin = "";
        /// <summary>
        /// 原因分析
        /// </summary>
        [DisplayName("原因分析")]
        public string YuanYin
        {
            get { return yuanYin; }
            set
            {
                if (yuanYin != value)
                {
                    yuanYin = value;
                    RaisePropertyChanged("YuanYin");
                    rowState = DataRowState.Modified;
                }
            }
        }

        private string gaiJin = "";
        /// <summary>
        /// 改进措施
        /// </summary>
        [DisplayName("改进措施")]
        public string GaiJin
        {
            get { return gaiJin; }
            set
            {
                if (gaiJin != value)
                {
                    gaiJin = value;
                    RaisePropertyChanged("GaiJin");
                    rowState = DataRowState.Modified;
                }
            }
        }



        private string guid = "";

        public string Guid
        {
            get { return guid; }
            set { guid = value; }
        }

        private string anaType = "";
        /// <summary>
        /// 检验类型
        /// </summary> 
        [DisplayName("检验类型")]
        public string AnaType
        {
            get { return anaType; }
            set
            {
                if (anaType != value)
                {
                    anaType = value;
                    RaisePropertyChanged("AnaType");
                }
            }
        }

        private string anaItem = "";
        /// <summary>
        /// 检验项
        /// </summary>
        [DisplayName("检验项")]
        public string AnaItem
        {
            get { return anaItem; }
            set
            {
                if (anaItem != value)
                {
                    anaItem = value;
                    RaisePropertyChanged("AnaItem");
                }
            }
        }


        private double _x;
        /// <summary>
        /// 数值
        /// </summary>
        [DisplayName("数值")]
        public double X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    if (this.Data.Count >= Idx && this.Idx > 1)
                    {
                        double y1 = double.Parse(Math.Abs(_x - this.Data[Idx - 2].X).ToString("########0.0000"));
                        R = y1;
                    }
                    RaisePropertyChanged("X");
                }
            }
        }

        private double _r;
        /// <summary>
        /// 极差
        /// </summary>
        [DisplayName("极差")]
        public double R
        {
            get { return _r; }
            set
            {
                if (_r != value)
                {
                    _r = value;
                  //  _r= double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("R");
                }
            }
        }

        private double _usl;
        /// <summary>
        /// 上限
        /// </summary>
        [DisplayName("要求上限")]
        public double USL
        {
            get { return _usl; }
            set
            {
                if (_usl != value)
                {
                    //_usl = value;
                    _usl = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("USL");
                }
            }
        }

        private double _lsl;
        /// <summary>
        /// 下限
        /// </summary>
        [DisplayName("要求下限")]
        public double LSL
        {
            get { return _lsl; }
            set
            {
                if (_lsl != value)
                {
                    //_lsl = value;
                    _lsl = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("LSL");
                }
            }
        }

        private double _avgX =0;
        [DisplayName("平均值")]
        public double AvgX
        {
            get { return _avgX; }
            set
            {
                if (_avgX != value)
                {
                   // _avgX = value;
                    _avgX = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("AvgX");
                   // rowState = DataRowState.Modified;
                }
            }
        }

        [DisplayName("标准差")]
        public double Sd
        {
            get
            {
                double sd = double.Parse((MR / d2).ToString("########0.0000"));
                return sd; 
            }

        }

        private double _uslx;
        /// <summary>
        /// 上限
        /// </summary>
        [DisplayName("上限")]
        public double USLX
        {
            get { return _uslx; }
            set
            {
                if (_uslx != value)
                {
                    //_uslx = value;
                    _uslx = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("USLX");
                }
            }
        }

        private double _lslx;
        /// <summary>
        /// 下限
        /// </summary>
        [DisplayName("下限")]
        public double LSLX
        {
            get { return _lslx; }
            set
            {
                if (_lslx != value)
                {
                    //_lslx = value;
                    _lslx = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("LSLX");
                }
            }
        }

        private double _MR=0 ;
        [DisplayName("均极差")]
        public double MR
        {
            get { return _MR; }
            set
            {
                if (_MR != value)
                {
                   // _MR = value;
                    _MR = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("MR");
                    RaisePropertyChanged("Sd");
                    //rowState = DataRowState.Modified;
                }
            }
        }
        private double _uslr;
        /// <summary>
        /// 上限
        /// </summary>
        [DisplayName("极差上限")]
        public double USLR
        {
            get { return _uslr; }
            set
            {
                if (_uslr != value)
                {
                    //_uslr = value;
                    _uslr = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("USLR");
                }
            }
        }

        private double _lslr;
        /// <summary>
        /// 下限
        /// </summary>
        [DisplayName("极差下限")]
        public double LSLR
        {
            get { return _lslr; }
            set
            {
                if (_lslr != value)
                {
                    //_lslr = value;
                    _lslr = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("LSLR");
                }
            }
        }

        private double mse = 0;
        [DisplayName("均移动极差")]
        public double Mse
        {
            get { return mse; }
            set
            {
                if (mse != value)
                {
                    //mse = value;
                    mse = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("Mse");
                   // rowState = DataRowState.Modified;
                }
            }
        }

        private double _cp;
        /// <summary>
        /// Cp
        /// </summary>
        [DisplayName("Cp")]
        public double Cp
        {
            get { return _cp; }
            set
            {
                if (_cp != value)
                {
                    //_cp = value;
                    _cp = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("Cp");
                }
            }
        }

        private double _cpk;
        /// <summary>
        /// Cpk
        /// </summary>
        [DisplayName("Cpk")]
        public double Cpk
        {
            get { return _cpk; }
            set
            {
                if (_cpk != value)
                {
                    //_cpk = value;
                    _cpk = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("Cpk");
                }
            }
        }

        private double _pp;
        /// <summary>
        /// pp
        /// </summary>
        [DisplayName("Pp")]
        public double Pp
        {
            get { return _pp; }
            set
            {
                if (_pp != value)
                {
                    //_pp = value;
                    _pp = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("Pp");
                }
            }
        }

        private double _ppk;
        /// <summary>
        /// Ppk
        /// </summary>
        [DisplayName("Ppk")]
        public double Ppk
        {
            get { return _ppk; }
            set
            {
                if (_ppk != value)
                {
                    //_ppk = value;
                    _ppk = double.Parse((value).ToString("########0.0000"));
                    RaisePropertyChanged("Ppk");
                }
            }
        }

        private SpcData data = null;

        public SpcData Data
        {
            get { return data; }
            set { data = value; }
        }

        private double? UCLx
        {
            get
            {
                return AvgX + E2 * MR;
            }
        }

        private double? LCLx
        {
            get
            {
                return AvgX - E2 * MR;
            }
        }

        public int Alarm()
        {
            AlarmType = "";
            int dataIdx = this.Idx - 1;
            //值超范围
            // if (this.X > UCLx || this.X < LCLx||this.X>USL||this.X<LSL)
            if (this.X > UCLx || this.X < LCLx)
            {
                // AlarmType = "值超范围或超上下限";
                AlarmType = "值超范围";
                return 0;
            }

            //连续9个点都在同一侧
            int smCnt = 9;
            if (dataIdx >= smCnt - 1)
            {
                bool douxiao = true;
                bool douda = true;
                for (int i = dataIdx - (smCnt - 1); i <= dataIdx; i++)
                {
                    if (this.Data[i].X > AvgX)
                    {
                        douxiao = false;
                    }
                    if (this.Data[i].X < AvgX)
                    {
                        douda = false;
                    }

                }
                if (douxiao || douda)
                {
                    if (AlarmType != "")
                        AlarmType += ",";
                    AlarmType += "连续9个点都在同一侧";
                }
            }

            //连续6个点递增或递减
            if (dataIdx >= 5)
            {
                bool dizeng = true;
                bool dijian = true;
                for (int i = dataIdx - 4; i <= dataIdx; i++)
                {
                    if (this.Data[i].X >= this.Data[i - 1].X)
                    {
                        dijian = false;
                    }
                    if (this.Data[i].X <= this.Data[i - 1].X)
                    {
                        dizeng = false;
                    }
                }
                if (dizeng || dijian)
                {
                    if (AlarmType != "")
                        AlarmType += ",";
                    AlarmType += "连续6个点递增或递减";
                }
            }
            //2019-06-05 技术科要求 减少报警项目 以下注释掉
            ////连续8个点不在C区
            //if (dataIdx >= 7)
            //{
            //    bool alarm = true;
            //    for (int i = dataIdx - 7; i <= dataIdx; i++)
            //    {
            //        if (this.Data[i].X < this.AvgX + this.Sd && this.Data[i].X > this.AvgX - this.Sd)
            //        {
            //            alarm = false;
            //        }

            //    }

            //    if (alarm)
            //    {
            //        if (AlarmType != "")
            //            AlarmType += ",";
            //        AlarmType += "连续8个点不在C区";
            //    }
            //}

            ////连续15个点在C区
            //if (dataIdx >= 14)
            //{
            //    bool alarm = true;
            //    for (int i = dataIdx - 14; i <= dataIdx; i++)
            //    {
            //        if (this.Data[i].X > this.AvgX + this.Sd || this.Data[i].X < this.AvgX - this.Sd)
            //        {
            //            alarm = false;
            //            break;
            //        }

            //    }
            //    if (alarm)
            //    {
            //        if (AlarmType != "")
            //            AlarmType += ",";
            //        AlarmType += "连续15个点在C区";
            //        return 0;
            //    }
            //}

            ////连续14个相邻点点上下交替
            //if (dataIdx >= 13)
            //{
            //    bool alarm = true;
            //    int dx = 0;
            //    for (int i = dataIdx - 12; i <= dataIdx; i++)
            //    {
            //        if (this.Data[i].X >= this.Data[i - 1].X)
            //        {
            //            if (dx == 0 || dx == -1)
            //            {
            //                dx = 1;
            //            }
            //            else
            //            {
            //                alarm = false;
            //                break;
            //            }
            //        }
            //        else if (this.Data[i].X <= this.Data[i - 1].X)
            //        {
            //            if (dx == 0 || dx == 1)
            //            {
            //                dx = -1;
            //            }
            //            else
            //            {
            //                alarm = false;
            //                break;
            //            }
            //        }
            //    }
            //    if (alarm)
            //    {
            //        if (AlarmType != "")
            //            AlarmType += ",";
            //        AlarmType += "连续14个相邻点点上下交替";
            //        return 0;
            //    }

            //}

            ////连续3个点中的两个点在同一侧的B区以外
            //if (dataIdx >= 2)
            //{
            //    int b_max = 0;
            //    int b_min = 0;
            //    for (int i = dataIdx - 2; i <= dataIdx; i++)
            //    {
            //        if (this.Data[i].X > this.AvgX + 2 * this.Sd)
            //        {
            //            b_max++;
            //        }
            //        if (this.Data[i].X < this.AvgX - 2 * this.Sd)
            //        {
            //            b_min++;
            //        }
            //    }
            //    if (b_max >= 2 || b_min >= 2)
            //    {
            //        if (AlarmType != "")
            //            AlarmType += ",";
            //        AlarmType += "连续3个点中的两个点在同一侧的B区以外";
            //    }
            //}



            ////连续5个点中的4个点在同一侧的C区以外
            //if (dataIdx >= 4)
            //{
            //    int b_max = 0;
            //    int b_min = 0;
            //    for (int i = dataIdx - 4; i <= dataIdx; i++)
            //    {
            //        if (this.Data[i].X > this.AvgX + this.Sd)
            //        {
            //            b_max++;
            //        }
            //        if (this.Data[i].X < this.AvgX - this.Sd)
            //        {
            //            b_min++;
            //        }
            //    }
            //    if (b_max >= 4 || b_min >= 4)
            //    {
            //        if (AlarmType != "")
            //            AlarmType += ",";
            //        AlarmType += "连续5个点中的4个点在同一侧的C区以外";
            //    }
            //}





            return 0;
        }

        public SpcDataItem()
        {

        }

        public SpcDataItem(SpcData data)
        {
            Data = data;
            this.Idx = this.Data.Count + 1;
            Data.Add(this);
        }

        public SpcDataItem(int idx, double x)
        {
            this._idx = idx;
            this._x = x;
        }

        public SpcDataItem(int idx, double x, double r)
        {
            this._idx = idx;
            this._x = x;
            this._r = r;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }

        private System.Data.DataRowState rowState = System.Data.DataRowState.Unchanged;

        public void ResetRowState()
        {
            rowState = DataRowState.Unchanged;
        }

        public string getSql()
        {
            string sql = "";
            //if (string.IsNullOrEmpty(Guid)) rowState = DataRowState.Added;

            //if (rowState == DataRowState.Added)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    // Guid = System.Guid.NewGuid().ToString().Replace("-", "");
            //    DateTime nowtime = DateTime.Now;
            //    Guid = HeatId + AnaType + AnaItem;
            //    string insert_operator = "";

            //    sb.Append("INSERT INTO SPC_AlarmData(Guid,HeatId,AnaType,AnaItem,AlarmType,YuanYin,GaiJin,insert_time,insert_operator,AvgX,MR,Sd,MSE) Values(");
            //    sb.Append("'" + Guid + "',");
            //    sb.Append("'" + HeatId + "',");
            //    sb.Append("'" + AnaType + "',");
            //    sb.Append("'" + AnaItem + "',");
            //    sb.Append("'" + AlarmType + "',");
            //    sb.Append("'" + YuanYin + "',");
            //    sb.Append("'" + GaiJin + "',");
            //    sb.Append("'" + nowtime + "',");
            //    sb.Append("'" + insert_operator + "',");
            //    sb.Append((AvgX == null ? "null" : AvgX.Value.ToString("#####0.0###")) + ",");
            //    sb.Append((MR == null ? "null" : MR.Value.ToString("#####0.0###")) + ",");
            //    sb.Append((Sd == null ? "null" : Sd.Value.ToString("#####0.0###")) + ",");
            //    sb.Append((Mse == null ? "null" : Mse.Value.ToString("#####0.0###")));
            //    sb.Append(")");
            //    sql = sb.ToString();
            //}
            //else if (rowState == DataRowState.Modified)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    DateTime nowtime = DateTime.Now;
            //    string update_operator = "";
            //    sb.Append("Update SPC_AlarmData Set ");
            //    sb.Append(" AlarmType='" + AlarmType + "',");
            //    sb.Append(" YuanYin='" + YuanYin + "',");
            //    sb.Append(" GaiJin='" + GaiJin + "',");
            //    sb.Append(" AvgX=" + AvgX + ",");
            //    sb.Append(" MR=" + MR + ",");
            //    sb.Append(" Sd=" + Sd + ",");
            //    sb.Append(" update_time='" + nowtime + "',");
            //    sb.Append(" update_operator='" + update_operator + "',");
            //    sb.Append(" Mse=" + Mse);
            //    //  sb.Append(" operator=" + update_operator + ",");
            //    // sb.Append(" update_time=" + nowtime);
            //    sb.Append(" Where Guid='" + Guid + "'");
            //    sql = sb.ToString();
            //}
            //else if (rowState == DataRowState.Deleted)
            //{
            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("Delete From SPC_AlarmData ");
            //    sb.Append(" Where Guid='" + Guid.ToString());
            //}
            return sql;
        }

        public static string getCreateSql()
        {
            return "Create Table SPC_AlarmData(Guid char(36),HeatId varchar(20),AnaType varchar2(20),AnaItem varchar2(20),AlarmType varchar2(200),YuanYin varchar2(500),GaiJin varchar2(500),AvgX Number(18,6),MR Number(18,6),Sd Number(18,6),Mse Number(18,6))";
        }

        public static string getDropSql()
        {
            return "Drop Table SPC_AlarmData";
        }

    }

    public class DataCollection : BindingList<DataItem>
    {

    }

    public class DataItem : INotifyPropertyChanged
    {
        private double _x = 0;

        public double X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    RaisePropertyChanged("X");
                }
            }
        }
        private double _y = 0;

        public double Y
        {
            get { return _y; }
            set
            {
                if (_y != value)
                {
                    _y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        public DataItem()
        {

        }
        public DataItem(double x, double y)
        {
            this._x = x;
            this._y = y;
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



}
