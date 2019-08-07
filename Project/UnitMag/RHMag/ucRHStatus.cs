using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.RHMag
{
    public partial class ucRHStatus : UnitMag.ucUnitStatus
    {
        public ucRHStatus()
        {
            UnitURI = @"XGMESLogic\RHMag\CRH_Unit_Mag\{RHID}";
            StatusProperty = "Status";
        }
        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;

        protected override string GetStatusText(int iStatus)
        {
            switch (iStatus)
            {
                /*************正常***************/
                case CommDataMag.CommonData.RHWaiting: 
                    return CommDataMag.CommonData.strRHWaiting;
                case CommDataMag.CommonData.RHProcBegin: 
                    return CommDataMag.CommonData.strRHProcBegin;
                case CommDataMag.CommonData.RHVacBegin: 
                    return CommDataMag.CommonData.strRHVacBegin;
                case CommDataMag.CommonData.RHOB: 
                    return CommDataMag.CommonData.strRHOB;
                case CommDataMag.CommonData.RHAlloy: 
                    return CommDataMag.CommonData.strRHAlloy;
                case CommDataMag.CommonData.RHProcEnd: 
                    return CommDataMag.CommonData.strRHProcEnd;
                case CommDataMag.CommonData.RHBlowBegin: 
                    return CommDataMag.CommonData.strRHBlowBegin;
                case CommDataMag.CommonData.RHBlowEnd: 
                    return CommDataMag.CommonData.strRHBlowEnd;
                /*****************异常*****************/
                case CommDataMag.CommonData.RHRepair: 
                    return CommDataMag.CommonData.strRHRepair;
                case CommDataMag.CommonData.RHFailure: 
                    return CommDataMag.CommonData.strRHFailure;
                default: return "未知";
            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                /*****************使用中*************/
                case CommDataMag.CommonData.RHProcBegin:
                case CommDataMag.CommonData.RHVacBegin:
                case CommDataMag.CommonData.RHOB:
                case CommDataMag.CommonData.RHAlloy:
                case CommDataMag.CommonData.RHProcEnd:
                case CommDataMag.CommonData.RHBlowBegin:
                case CommDataMag.CommonData.RHBlowEnd: 
                    return global::UnitMag.Properties.Resources.VacTubeBusy;
                /*****************等待或异常******************/
                case CommDataMag.CommonData.RHWaiting:
                case CommDataMag.CommonData.RHRepair:
                case CommDataMag.CommonData.RHFailure: 
                    return global::UnitMag.Properties.Resources.VacTubeFree;

                default: return global::UnitMag.Properties.Resources.VacTubeFree;
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
            // ucBOFStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "ucRHStatus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

