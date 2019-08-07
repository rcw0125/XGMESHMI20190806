using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UnitMag.MELTMag
{
    public class ucMELTStatus : ucUnitStatus
    {
        public ucMELTStatus()
        {
            UnitURI = @"XGMESLogic\MELTMag\CMELT_Unit_Mag\S51";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;
    
        protected override string GetStatusText(int iStatus)
        {
            switch(iStatus)
            {
                    /*************正常***************/
                case CommDataMag.CommonData.MELTWaiting: 
                    return CommDataMag.CommonData.strMELTWaiting;
               
                case CommDataMag.CommonData.MELTFeeding:
                    return CommDataMag.CommonData.strMELTFeeding;

                case CommDataMag.CommonData.MELTBlowing:
                    return CommDataMag.CommonData.strMELTBlowing;

                case CommDataMag.CommonData.MELTReBlowing:
                    return CommDataMag.CommonData.strMELTReBlowing;

                case CommDataMag.CommonData.MELTTapping:
                    return CommDataMag.CommonData.strMELTTapping;

                case CommDataMag.CommonData.MELTTapped:
                    return CommDataMag.CommonData.strMELTTapped;

                case CommDataMag.CommonData.MELTSplash:
                    return CommDataMag.CommonData.strMELTSplash;

                case CommDataMag.CommonData.MELTDumping:
                    return CommDataMag.CommonData.strMELTDumping;

                /*****************异常*****************/
                case CommDataMag.CommonData.MELTRepair:
                    return CommDataMag.CommonData.strMELTRepair;
                case CommDataMag.CommonData.MELTBushing:
                    return CommDataMag.CommonData.strMELTBushing;
                case CommDataMag.CommonData.MELTMaintain:
                    return CommDataMag.CommonData.strMELTMaintain;
                case CommDataMag.CommonData.MELTFailure:
                    return CommDataMag.CommonData.strMELTFailure;

                default: return "未知";
            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                /*****************使用中*************/
                case CommDataMag.CommonData.MELTFeeding:
                case CommDataMag.CommonData.MELTBlowing:
                case CommDataMag.CommonData.MELTReBlowing:
                case CommDataMag.CommonData.MELTTapping:
                case CommDataMag.CommonData.MELTTapped:
                case CommDataMag.CommonData.MELTSplash:
                case CommDataMag.CommonData.MELTDumping:
                    return global::UnitMag.Properties.Resources.BOFBusy;

                /*****************等待或异常******************/
                case CommDataMag.CommonData.MELTWaiting:
                case CommDataMag.CommonData.MELTRepair:
                case CommDataMag.CommonData.MELTBushing:
                case CommDataMag.CommonData.MELTMaintain:
                case CommDataMag.CommonData.MELTFailure:
                    return global::UnitMag.Properties.Resources.BOFFree;
                default: return global::UnitMag.Properties.Resources.BOFFree;
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
            // ucMELTStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "ucMELTStatus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
