using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UnitMag.DEPMag
{
    public class ucDePStatus : ucUnitStatus
    {
        public ucDePStatus()
        {
            UnitURI = @"XGMESLogic\DePMag\CDEP_Unit_Mag\S91";
            StatusProperty = "Status";
        }

        private System.Windows.Forms.ImageList imglstStatus;
        private System.ComponentModel.IContainer components;
    
        protected override string GetStatusText(int iStatus)
        {
            switch(iStatus)
            {
                //    /*************正常***************/
                case 1:
                    return "铁包进站";
                case 2:
                    return "捞渣开始";
                case 3:
                    return "捞渣结束";
                case 4:
                    return "喷吹开始";
                case 5:
                    return "喷吹结束";
                case 6:
                    return "脱硅开始";
                case 7:
                    return "脱硅结束";
                case 8:
                    return "脱磷开始";
                case 9:
                    return "脱磷结束";
                case 10:
                    return "等待";
                //case CommDataMag.CommonData.DePArrived:
                //    return CommDataMag.CommonData.strDePArrived;

                //case CommDataMag.CommonData.DePBeginSpray:
                //    return CommDataMag.CommonData.strDePBeginSpray;

                //case CommDataMag.CommonData.DePEndSpray:
                //    return CommDataMag.CommonData.strDePEndSpray;

                //case CommDataMag.CommonData.DePEndRemoveSlag:
                //    return CommDataMag.CommonData.strDePEndRemoveSlag;

                //case CommDataMag.CommonData.DePBeginRemoveSlag:
                //    return CommDataMag.CommonData.strDePBeginRemoveSlag;

                //case CommDataMag.CommonData.DePBegin:
                //    return CommDataMag.CommonData.strDePBegin;

                //case CommDataMag.CommonData.DePEnd:
                //    return CommDataMag.CommonData.strDePEnd;
                //case CommDataMag.CommonData.DePDepart:
                //    return CommDataMag.CommonData.strDePDepart;

                /*****************异常*****************/
                //case CommDataMag.CommonData.BOFRepair:
                //    return CommDataMag.CommonData.strBOFRepair;
                //case CommDataMag.CommonData.BOFBushing:
                //    return CommDataMag.CommonData.strBOFBushing;
                //case CommDataMag.CommonData.BOFMaintain:
                //    return CommDataMag.CommonData.strBOFMaintain;
                //case CommDataMag.CommonData.BOFFailure:
                //    return CommDataMag.CommonData.strBOFFailure;

                default: return "未知";
            }
        }

        protected override Image GetStatusImage(Int32 iStatus)
        {
            switch (iStatus)
            {
                ///*****************使用中*************/
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
              
         
                    //case CommDataMag.CommonData.BOFDumping:
                    return global::UnitMag.Properties.Resources.DesBusy;

                /*****************等待或异常******************/
                //case CommDataMag.CommonData.DePPrepare:
                //case CommDataMag.CommonData.DePArrived:
                //case CommDataMag.CommonData.DePDepart:
                //    //case CommDataMag.CommonData.BOFMaintain:
                //    //case CommDataMag.CommonData.BOFFailure:
                //    return global::UnitMag.Properties.Resources.DesFree;
                default: return global::UnitMag.Properties.Resources.DesFree;
            }

            return global::UnitMag.Properties.Resources.DesFree;
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
            this.Name = "ucDePStatus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
