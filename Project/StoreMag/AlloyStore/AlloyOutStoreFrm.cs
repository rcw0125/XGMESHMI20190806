using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.AlloyStore
{
    public partial class AlloyOutStoreFrm : Form
    {
        public AlloyOutStoreFrm()
        {
            InitializeComponent();
        }
        private string strPossition = "";
        public void ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            dsOutStroe.Tables[0].Clear();
            dsOutStroe.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);
            dsOutStroe.Tables[0].Rows[0]["OldAmount"] = dsData.Tables[0].Rows[0]["AMOUNT"];
            dsOutStroe.Tables[0].Rows[0]["Amount"] = 0;
            dsOutStroe.Tables[0].Rows[0]["StoreAreaID"] = dsData.Tables[0].Rows[0]["POSITION"];
            strPossition = dsData.Tables[0].Rows[0]["POSITION"].ToString();
            this.ShowDialog();
        }
        
        //确定
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bsOutStore.EndEdit();

            string check = MessageBox.Show( "确认要出库么？" , "提示" , MessageBoxButtons.OKCancel,MessageBoxIcon.Question ).ToString();
            if ( check == "OK" )
            {
                if (cmdOutStore.Execute() >= 0)
                {
                    if(Convert.ToBoolean( cmdOutStore.Command.Return))
                    {
                        MessageBox.Show("出库成功！", "提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("出库不成功!", "提示");
                    }
                }
            }
        }

        //取消
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void AlloyOutStoreFrm_Load(object sender, EventArgs e)
        {
            cmbUnit.TextChanged += new EventHandler(pxControls_TextChanged);
            cmbTarget.TextChanged += new EventHandler(pxControls_TextChanged);
            txtAmount.TextChanged += new EventHandler(pxControls_TextChanged);
           // cmbTarget.SelectedIndex = 0;
            //cmbUnit.SelectedIndex = 0;

            // 设置机组信息 [12/29/2008 sun]
            //switch (strPossition)
            //{
            //    case CommDataMag.CommonData.CLF01_GROUND_ALLOY_POSSITION://1#LF袋装合金堆放处
            //        dsUnit.SourceCondition = "CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_01ID + "'";
            //        break;
            //    case CommDataMag.CommonData.CLF03RH_GROUND_ALLOY_POSSITION://3#LFRH袋装合金堆放处
            //        dsUnit.SourceCondition = "(CODE_GROUP = 'LF' and CODE = '" +CommDataMag.CommonData.LF_UNIT_03ID + "') or (CODE_GROUP = 'RH' and CODE = '" + CommDataMag.CommonData.RH_UNIT_01ID + "')";
            //        break;
            //    case CommDataMag.CommonData.CLF02_GROUND_ALLOY_POSSITION://2#LF袋装合金堆放处
            //        dsUnit.SourceCondition = "CODE_GROUP = 'LF' and CODE = '" +CommDataMag.CommonData.LF_UNIT_02ID + "'";
            //        break;
            //    case CommDataMag.CommonData.CBOF_GROUND_ALLOY_POSSITION://转炉袋装合金堆放处
            //        dsUnit.SourceCondition = "CODE_GROUP  = 'BOF' and CODE is not null" ;
            //        break;
            //}
            
            if (strPossition == "S81Z01" || strPossition == "S81Z02" || strPossition == "S81Z03" || strPossition == "S81Z04")
            {
                dsUnit.SourceCondition = "CODE_GROUP  = 'BOF' and CODE is not null";
            }
            else
            {
                if (strPossition == "S81Z05" || strPossition == "S81Z06" || strPossition == "S81Z07" || strPossition == "S81Z08" )
                {
                    dsUnit.SourceCondition = "CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_01ID + "'";
                }
                else
                {
                    if (strPossition == "S81Z09" || strPossition == "S81Z10" || strPossition == "S81Z11" || strPossition == "S81Z12")
                    {
                        dsUnit.SourceCondition = "CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_02ID + "'";
                    }
                    else
                    {
                        if (strPossition == "S81Z17" || strPossition == "S81Z18" || strPossition == "S81Z19" || strPossition == "S81Z20" || strPossition == "S81Z21" || strPossition == "S81Z22" || strPossition == "S81Z23" || strPossition == "S81Z24" || strPossition == "S81Z25" || strPossition == "S81Z26" || strPossition == "S81Z27" || strPossition == "S81Z28" || strPossition == "S81Z29" || strPossition == "S81Z30" || strPossition == "S81Z31" || strPossition == "S81Z32" || strPossition == "S81Z33" || strPossition == "S81Z44" || strPossition == "S81Z45" || strPossition == "S81Z46")
                        {
                            dsUnit.SourceCondition = "(CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_01ID + "') or (CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_02ID + "')";
                        }
                        else
                        {
                            if (strPossition == "S81Z80" || strPossition == "S81Z81" || strPossition == "S81Z82" || strPossition == "S81Z83" || strPossition == "S81Z84" || strPossition == "S81Z85" || strPossition == "S81Z86" || strPossition == "S81Z87" || strPossition == "S81Z88" || strPossition == "S81Z89" || strPossition == "S81Z90" || strPossition == "S81Z91" || strPossition == "S81Z92" || strPossition == "S81Z93" || strPossition == "S81Z94" || strPossition == "S81Z95" || strPossition == "S81Z96" || strPossition == "S81Z97" || strPossition == "S81Z98" || strPossition == "S81Z99" || strPossition == "S81Z104" || strPossition == "S81Z105" || strPossition == "S81Z106" || strPossition == "S81Z107" || strPossition == "S81Z108" || strPossition == "S81Z109" || strPossition == "S81Z110" || strPossition == "S81Z111" || strPossition == "S81Z112" || strPossition == "S81Z113")
                            {
                                dsUnit.SourceCondition = "(CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_05ID + "')";
                            }
                            else
                            {
                                dsUnit.SourceCondition = "(CODE_GROUP = 'LF' and CODE = '" + CommDataMag.CommonData.LF_UNIT_03ID + "') or (CODE_GROUP = 'RH' and CODE = '" + CommDataMag.CommonData.RH_UNIT_01ID + "')";
                            }
                        }
                    }
                }
            }
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnit.SelectedValue == null)
            {
                dsHeatID.Tables[0].Clear();
                return;
            }
            cmdHeatID.Parameters[0].ConstantValue = cmbUnit.SelectedValue.ToString();
            dsHeatID.LoadData();
        }

        private void AlloyOutStoreFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
       
    }
}