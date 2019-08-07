using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UnitMag.BOFMag
{
    public class ucBOFStatus : ucUnitStatus
    {
        public ucBOFStatus()
        {
            UnitURI = @"XGMESLogic\BOFMag\CBOF_Unit_Mag\{BOFID}";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;
    
        protected override string GetStatusText(int iStatus)
        {
            switch(iStatus)
            {
                    /*************正常***************/
                case CommDataMag.CommonData.BOFWaiting: 
                    return CommDataMag.CommonData.strBOFWaiting;
               
                case CommDataMag.CommonData.BOFFeeding:
                    return CommDataMag.CommonData.strBOFFeeding;

                case CommDataMag.CommonData.BOFBlowing:
                    return CommDataMag.CommonData.strBOFBlowing;

                case CommDataMag.CommonData.BOFReBlowing:
                    return CommDataMag.CommonData.strBOFReBlowing;

                case CommDataMag.CommonData.BOFTapping:
                    return CommDataMag.CommonData.strBOFTapping;

                case CommDataMag.CommonData.BOFTapped:
                    return CommDataMag.CommonData.strBOFTapped;

                case CommDataMag.CommonData.BOFSplash:
                    return CommDataMag.CommonData.strBOFSplash;

                case CommDataMag.CommonData.BOFDumping:
                    return CommDataMag.CommonData.strBOFDumping;

                /*****************异常*****************/
                case CommDataMag.CommonData.BOFRepair:
                    return CommDataMag.CommonData.strBOFRepair;
                case CommDataMag.CommonData.BOFBushing:
                    return CommDataMag.CommonData.strBOFBushing;
                case CommDataMag.CommonData.BOFMaintain:
                    return CommDataMag.CommonData.strBOFMaintain;
                case CommDataMag.CommonData.BOFFailure:
                    return CommDataMag.CommonData.strBOFFailure;

                default: return "未知";
            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                /*****************使用中*************/
                case CommDataMag.CommonData.BOFFeeding:
                case CommDataMag.CommonData.BOFBlowing:
                case CommDataMag.CommonData.BOFReBlowing:
                case CommDataMag.CommonData.BOFTapping:
                case CommDataMag.CommonData.BOFTapped:
                case CommDataMag.CommonData.BOFSplash:
                case CommDataMag.CommonData.BOFDumping:
                    return global::UnitMag.Properties.Resources.BOFBusy;

                /*****************等待或异常******************/
                case CommDataMag.CommonData.BOFWaiting:
                case CommDataMag.CommonData.BOFRepair:
                case CommDataMag.CommonData.BOFBushing:
                case CommDataMag.CommonData.BOFMaintain:
                case CommDataMag.CommonData.BOFFailure:
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
            // ucBOFStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Name = "ucBOFStatus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
