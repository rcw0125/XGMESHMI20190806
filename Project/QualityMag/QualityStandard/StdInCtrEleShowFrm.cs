using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace QualityMag.QualityStandard
{
    public partial class StdInCtrEleShowFrm : DockContent, IMESForm
    {
        public StdInCtrEleShowFrm()
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
        public DialogResult ShowDialogEx(AppSvrIF.Session session,int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData )
        
        {
            pxTextBox1.Text = "";
            pxTextBox2.Text = "";
            Adapter.Session = session;
            bsStdInCtrEle.DataSource = null;
            bsStdInCtrEle.DataSource = dsData;
            bsStdInCtrEle.DataMember = dsData.Tables[0].TableName;

            ((System.Data.DataRowView)(bsStdInCtrEle.Current)).DataView.Sort = strSort;
            bsStdInCtrEle.Position = nPosition;

            return ShowDialog();
        }

        //确认
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsStdInCtrEle.EndEdit();
            this.Close();
        }

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsStdInCtrEle.CancelEdit();
            this.Close();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        private void StdInCtrEleShowFrm_Load(object sender, EventArgs e)
        {
            
            foreach (Control c in tpElement.Controls)
            {
                if (c is PxDataValid.PxTextBox)
                {
                    c.TextChanged += new EventHandler(pxControls_TextChanged);
                }
            }
        }

        private void SteelGradeIndexChanged()
        {
            string strsteelIndex = txtSteelGradeIndex.Text.Trim();

            string sql = " select steelgradeindex,steelgrade,protocol from CQA_SteelGradeIndex_R where  STEELGRADEINDEX='" + strsteelIndex + "'";//在这儿写sql语句 
            //object objSteelGrade = null ;
            
            //Adapter.Session.Get(@"XGMESLogic\QualityMag\CQA_SteelGradeIndex_R\" + strsteelIndex + "", "SteelGrade", ref objSteelGrade);
            //if (objSteelGrade != null)
            //    pxTextBox2.Text = objSteelGrade.ToString();

            dsGrid.SourceMethod = sql;
        

            //Adapter.RefreshDataBindings();
            //string strObjID = "";
            //object objTemp = null;
            //object objSteelGrade = null;
            //string strSteelGradeIndex = steelIndex;
            //int i;
            //i=dsSteelIndex.Tables[0].Rows.Count;
            if (dsGrid.Tables[0].Rows.Count != 0 )
            {

                pxTextBox1.Text = dsGrid.Tables[0].Rows[0]["SteelGrade"].ToString();
                pxTextBox2.Text = dsGrid.Tables[0].Rows[0]["Protocol"].ToString();
            }
            else if (txtSteelGradeIndex .TextLength >=8)
            {
                MessageBox.Show("钢种对照关系表中无该炼钢记号，获取炼钢记号失败！", "提示");
                return;
            }
            
            //if ((strSteelGradeIndex.Substring(0, 1) == "J") || (strSteelGradeIndex.Substring(0, 1) == "B"))
            //{
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R\\" + strSteelGradeIndex, "SteelGrade", ref objSteelGrade);
            //    strObjID = iLength.ToString() + objSteelGrade.ToString();
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + strObjID.ToString(), "Weight", ref objTemp);
            //}
            //else
            //    Adapter.Session.Get("XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std\\" + iLength.ToString(), "Weight", ref objTemp);

            //string strWeight = objTemp != null ? objTemp.ToString() : "";
            //if (strWeight.Length > 0)
            //{
            //    fweight = double.Parse(strWeight);
            //    fWTPerMM = (fweight / iLength) * 1000;//20081228Liao
            //}
            //else
            //{
            //    fWTPerMM = 0;
            //    MessageBox.Show("铸坯重量长度关系维护表中，没有" + strObjID + "主键，获取定尺对应重量标准值失败，请与生产科联系！, 提示");

            //}
            
        }

        private void txtSteelGradeIndex_TextChanged(object sender, EventArgs e)
        {
            SteelGradeIndexChanged();
        }

       
    }
}