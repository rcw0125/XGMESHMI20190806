using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BOFMag
{
    public partial class BOFMagMainFrm : DockContent, IMESForm
    {
        public BOFMagMainFrm()
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

        protected virtual string GetCurUnitName()
        {
            //throw new Exception("No BOF");
            return "";
        }

        private void BOFMagMainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                panelUnit.Controls.Clear();

                string UnitID = GetCurUnitName();
               
                switch (UnitID)
                {
                    case "Bof01":
                        this.TabText = "1#转炉工序";
                        ucBOFData ucBof01 = new ucBOFData();
                        panelUnit.Controls.Add(ucBof01);
                        ucBof01.Dock = DockStyle.Fill;
                        break;
                    case "Bof02":
                        this.TabText = "2#转炉工序";
                        ucBOFData ucBof02 = new ucBOFData();
                        panelUnit.Controls.Add(ucBof02);
                        ucBof02.Dock = DockStyle.Fill;
                        break;
                    case "Lf01":
                        this.TabText = "1#LF炉工序";
                        UnitMag.LFMag.ucLFData ucLf01 = new UnitMag.LFMag.ucLFData();
                        panelUnit.Controls.Add(ucLf01);
                        ucLf01.Dock = DockStyle.Fill;
                        break;
                    case "Tap01":
                        this.TabText = " 1#转炉炉后工序";
                        break;
                    default:
                        break;
                }

            }
            catch { }
          
        }

        //属性调整
        private void btnAttribute_Click(object sender, EventArgs e)
        {

        }

        //改钢申请
        private void btnReqChaGrade_Click(object sender, EventArgs e)
        {

        }

        //指定主原料
        private void btnDesignateMat_Click(object sender, EventArgs e)
        {

        }

        //加料数据收集
        private void btnDischarge_Click(object sender, EventArgs e)
        {

        }

        //设备状态维护
        private void btnEquStatus_Click(object sender, EventArgs e)
        {

        }

        //炉次记事
        private void btnHeatRemark_Click(object sender, EventArgs e)
        {

        }

        //定氧数据收集
        private void btnMeasureOxygen_Click(object sender, EventArgs e)
        {

        }

        //作业状态维护
        private void btnProcStatus_Click(object sender, EventArgs e)
        {

        }

        //炉衬维护
        private void btnStackMag_Click(object sender, EventArgs e)
        {

        }

        //工艺异常
        private void btnTechicsException_Click(object sender, EventArgs e)
        {

        }

        //处理开始
        private void btnTAPStart_Click(object sender, EventArgs e)
        {

        }

        //处理结束
        private void btnTAPEnd_Click(object sender, EventArgs e)
        {

        }

        //手动收集数据
        private void btnManualData_Click(object sender, EventArgs e)
        {
            UnitMag.TAPMag.ManualDataFrm frm = new UnitMag.TAPMag.ManualDataFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //指定称重炉号
        private void btnTapDesignateLadle_Click(object sender, EventArgs e)
        {
             
        }

        //数据修正
        private void btnTAPHeatFinalData_Click(object sender, EventArgs e)
        {

        }

        //LF属性调整
        private void btnLFAttribute_Click(object sender, EventArgs e)
        {

        }

        //LF指定钢包
        private void btnLFDesignateLadle_Click(object sender, EventArgs e)
        {

        }

        //LF加料
        private void btnLFDischarge_Click(object sender, EventArgs e)
        {

        }

    }
}