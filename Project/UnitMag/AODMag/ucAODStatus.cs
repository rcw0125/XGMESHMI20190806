using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UnitMag.AODMag
{
    public class ucAODStatus : ucUnitStatus
    {
        public ucAODStatus()
        {
            UnitURI = @"XGMESLogic\AODMag\CAOD_Unit_Mag\S25";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;
    
        protected override string GetStatusText(int iStatus)
        {
            switch(iStatus)
            {
                    /*************正常***************/
                case CommDataMag.CommonData.AODWaiting:
                    return CommDataMag.CommonData.strAODWaiting;
               
                case CommDataMag.CommonData.AODFeeding:
                    return CommDataMag.CommonData.strAODFeeding;

                case CommDataMag.CommonData.AODDec:
                    return CommDataMag.CommonData.strAODDec;

                case CommDataMag.CommonData.AODStartBlowing:
                    return CommDataMag.CommonData.strAODStartBlowing;

                case CommDataMag.CommonData.AODStopBlowing:
                    return CommDataMag.CommonData.strAODStopBlowing;

                case CommDataMag.CommonData.AODReturn:
                    return CommDataMag.CommonData.strAODReturn;

                case CommDataMag.CommonData.AODTapping:
                    return CommDataMag.CommonData.strAODTapping;

                case CommDataMag.CommonData.AODTapped:
                    return CommDataMag.CommonData.strAODTapped;

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
                case CommDataMag.CommonData.AODFeeding:
                case CommDataMag.CommonData.AODReturn:
                case CommDataMag.CommonData.AODStartBlowing:
                case CommDataMag.CommonData.AODStopBlowing:
                case CommDataMag.CommonData.AODTapping:
                case CommDataMag.CommonData.AODTapped:
                case CommDataMag.CommonData.AODDec:
                    return global::UnitMag.Properties.Resources.BOFBusy;

                /*****************等待或异常******************/
                case CommDataMag.CommonData.AODWaiting:
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
