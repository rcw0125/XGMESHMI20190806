using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.LFMag
{
    public partial class ucLFStatus : UnitMag.ucUnitStatus
    {
        public ucLFStatus()
        {
            UnitURI = @"XGMESLogic\LFMag\CLF_Unit_Mag\{LFID}";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;

        protected override string GetStatusText(int iStatus)
        {
            switch (iStatus)
            {
                /*************正常***************/
                case CommDataMag.CommonData.LFWaiting: 
                    return CommDataMag.CommonData.strLFWaiting;
                case CommDataMag.CommonData.LFProcBegin: 
                    return CommDataMag.CommonData.strLFProcBegin;
                case CommDataMag.CommonData.LFHeatBegin: 
                    return CommDataMag.CommonData.strLFHeatBegin;
                case CommDataMag.CommonData.LFHeatEnd: 
                    return CommDataMag.CommonData.strLFHeatEnd;
                case CommDataMag.CommonData.LFProcEnd: 
                    return CommDataMag.CommonData.strLFProcEnd;
                case CommDataMag.CommonData.LFBlowBegin:
                    return CommDataMag.CommonData.strLFBlowBegin;
                case CommDataMag.CommonData.LFBlowEnd: 
                    return CommDataMag.CommonData.strLFBlowEnd;
                /*****************异常*****************/
                case CommDataMag.CommonData.LFRepair: 
                    return CommDataMag.CommonData.strLFRepair;
                case CommDataMag.CommonData.LFBushing: 
                    return CommDataMag.CommonData.strLFBushing;
                case CommDataMag.CommonData.LFMaintain: 
                    return CommDataMag.CommonData.strLFMaintain;
                case CommDataMag.CommonData.LFFailure: 
                    return CommDataMag.CommonData.strLFFailure;

                default: return "未知";
            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                /*****************使用中*************/
                case CommDataMag.CommonData.LFProcBegin:
                case CommDataMag.CommonData.LFHeatBegin:
                case CommDataMag.CommonData.LFHeatEnd:
                case CommDataMag.CommonData.LFProcEnd:
                case CommDataMag.CommonData.LFBlowBegin:
                case CommDataMag.CommonData.LFBlowEnd: 
                    return global::UnitMag.Properties.Resources.LFBusy;
                /*****************等待或异常******************/
                case CommDataMag.CommonData.LFWaiting:
                case CommDataMag.CommonData.LFRepair:
                case CommDataMag.CommonData.LFBushing:
                case CommDataMag.CommonData.LFMaintain:
                case CommDataMag.CommonData.LFFailure: 
                    return global::UnitMag.Properties.Resources.LFFree;

                default: return global::UnitMag.Properties.Resources.LFFree;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imglstStatus = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imglstStatus
            // 
            this.imglstStatus.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstStatus.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstStatus.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ucLFStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "ucLFStatus";
            this.ResumeLayout(false);

        }
    }
}

