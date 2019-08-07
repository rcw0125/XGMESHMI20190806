using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{
    public partial class ucCCMStatus : UnitMag.ucUnitStatus
    {
        public ucCCMStatus()
        {
            UnitURI = @"XGMESLogic\CCMMag\CCCM_Unit_Mag\{CCMID}";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;

        protected override string GetStatusText(int iStatus)
        {
            switch (iStatus)
            {
                /*************正常***************/

                case CommDataMag.CommonData.CCMWaiting:
                    return CommDataMag.CommonData.strCCMWaiting;
                case CommDataMag.CommonData.CCMArrivle: 
                    return CommDataMag.CommonData.strCCMArrivle;
                case CommDataMag.CommonData.CCMCasting:
                    return CommDataMag.CommonData.strCCMCasting;
                case CommDataMag.CommonData.CCMCasted: 
                    return CommDataMag.CommonData.strCCMCasted;
                /*****************异常*****************/
                case CommDataMag.CommonData.CCMRepair: 
                    return CommDataMag.CommonData.strCCMRepair;
                case CommDataMag.CommonData.CCMFailure: 
                    return CommDataMag.CommonData.strCCMFailure;

                default: return "未知";

            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                /*****************使用中*************/
                case CommDataMag.CommonData.CCMCasting:
                    if (CCMFlowCount == 3)
                        return global::UnitMag.Properties.Resources.CCMBusy7;
                    else
                        return global::UnitMag.Properties.Resources.CCMBuye;
                case CommDataMag.CommonData.CCMCasted:
                /*****************等待或异常******************/
                case CommDataMag.CommonData.CCMWaiting:
                case CommDataMag.CommonData.CCMRepair:
                case CommDataMag.CommonData.CCMFailure:
                    if (CCMFlowCount == 3)
                        return global::UnitMag.Properties.Resources.CCMFree7;
                    else
                        return global::UnitMag.Properties.Resources.CCMFree;  
                default:
                    if (CCMFlowCount == 3)
                        return global::UnitMag.Properties.Resources.CCMFree7;
                    else
                        return global::UnitMag.Properties.Resources.CCMFree;
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
            this.Name = "ucCCMStatus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

