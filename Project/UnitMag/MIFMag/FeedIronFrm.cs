using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.MIFMag
{
    public partial class FeedIronFrm : Form
    {
        public FeedIronFrm()
        {
            InitializeComponent();
        }

        private string m_strMIF;

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strMIFID)
        {
            Adapter.Session = session;
            m_strMIF = "XGMESLogic\\MIXFMag\\CMIF_Unit_Mag\\" + strMIFID;
            //add by hyh 2012-03-30
            this.Text = strMIFID[strMIFID.Length - 1].ToString() + "号" + this.Text;
            //end
            return ShowDialog();
        }

        private void FeedIronFrm_Load(object sender, EventArgs e)
        {
            // 绑定混铁炉成分数据    预约加载
            foreach (Control ctrl in tabPageMIF.Controls)
            {
                if (!(ctrl is AppSvrHMI.L3DataBox))
                    continue;
                AppSvrHMI.L3DataBox tx = ctrl as AppSvrHMI.L3DataBox;
                tx.DataObject = m_strMIF;           
                //tx.LoadData();
            }

            l3cmdMix.Object = m_strMIF;//兑铁 加载

            dsMixInfos.Tables[0].RowDeleted += new DataRowChangeEventHandler(FeedIronFrm_RowDeleted);
            dsMixInfos.Tables[0].RowChanged += new DataRowChangeEventHandler(FeedIronFrm_RowChanged);
        }

        void FeedIronFrm_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if(e.Action == DataRowAction.Change)
                ReCalculateMix();
        }

        void FeedIronFrm_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            ReCalculateMix();
        }


        private void dvIn_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dvMix.EndEdit();
            bsMixInfos.EndEdit();
            dsMixInfos.AcceptChanges();

            if (e.RowIndex >= 0 && e.RowIndex < dsInInfos.Tables[0].Rows.Count)
            {
                DataRow row = dsInInfos.Tables[0].Rows[e.RowIndex];
                string strMatID = row["MaterialID"].ToString();
                DataRow[] exist = dsMixInfos.Tables[0].Select(string.Format("MaterialID = '{0}'", strMatID));
                if (exist == null || exist.Length < 1)
                {
                    dsMixInfos.Tables[0].ImportRow(dsInInfos.Tables[0].Rows[e.RowIndex]);
                    dsMixInfos.Tables[0].Rows[dsMixInfos.Tables[0].Rows.Count - 1]["Net_Weight"] = dsMixInfos.Tables[0].Rows[dsMixInfos.Tables[0].Rows.Count - 1]["Spare_Weight"];
                    ReCalculateMix();
                }
            }
        }
 
        private void dvMix_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dvMix.Columns[e.ColumnIndex].DataPropertyName == "Net_Weight")
            {
                double fNewWeight = double.Parse(e.FormattedValue.ToString());
                DataRow row = ((DataRowView)dvMix.Rows[e.RowIndex].DataBoundItem).Row;
                if (fNewWeight > double.Parse(row["Spare_Weight"].ToString()))
                {
                    e.Cancel = true;
                    MessageBox.Show("输入的兑铁量过大！");
                }
            }
        }

        private void ReCalculateMix()
        {
            try
            {
                double Weight = 0, Mn = 0, P = 0, S = 0, Ti = 0, Si = 0, C = 0;
                //add by hyh 2012-4-7
                double Sn = 0, Sb = 0, As = 0, Pb = 0;
                //end

                //add by hyh 2012-08-13 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                double Ni = 0, Mo = 0, Cu = 0, Cr = 0, B = 0, V = 0, Al = 0, Nb = 0, Zn = 0, W = 0;

                // The exist data
                if (dsMixInfos.Tables.Count < 1 || dsMixInfos.Tables[0].Rows.Count < 1)
                    return;

                foreach (Control ctrl in tabPageMIF.Controls)
                {
                    if (!(ctrl is AppSvrHMI.L3DataBox))
                        continue;
                    AppSvrHMI.L3DataBox tx = ctrl as AppSvrHMI.L3DataBox;
                    tx.LoadData();
                }

                Weight = double.Parse(txWeight.Text);
                Mn = Weight * double.Parse(txMn.Text);
                if (Mn == 0) Mn = Weight * double.Parse(txMn_Cal.Text);
                P = Weight * double.Parse(txP.Text);
                if (P == 0) P = Weight * double.Parse(txP_Cal.Text);
                S = Weight * double.Parse(txS.Text);
                if (S == 0) S = Weight * double.Parse(txS_Cal.Text);
                Ti = Weight * double.Parse(txTi.Text);
                if (Ti == 0) Ti = Weight * double.Parse(txTi_Cal.Text);
                Si = Weight * double.Parse(txSi.Text);
                if (Si == 0) Si = Weight * double.Parse(txSi_Cal.Text);
                C = Weight * double.Parse(txC.Text);
                if (C == 0) C = Weight * double.Parse(txC_Cal.Text);

                //add by hyh 2012-4-7
                Sn = Weight * double.Parse(txSn.Text);
                if (Sn == 0) Sn = Weight * double.Parse(txSn_Cal.Text);
                Sb = Weight * double.Parse(txSb.Text);
                if (Sb == 0) Sb = Weight * double.Parse(txSb_Cal.Text);
                As = Weight * double.Parse(txAs.Text);
                if (As == 0) As = Weight * double.Parse(txAs_Cal.Text);
                Pb = Weight * double.Parse(txPb.Text);
                if (Pb == 0) Pb = Weight * double.Parse(txPb_Cal.Text);
                //end

                //add by hyh 2012-08-13 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                Ni = Weight * double.Parse(txNi.Text);
                if (Ni == 0) Ni = Weight * double.Parse(txNi_Cal.Text);

                Mo = Weight * double.Parse(txMo.Text);
                if (Mo == 0) Mo = Weight * double.Parse(txMo_Cal.Text);

                Cu = Weight * double.Parse(txCu.Text);
                if (Cu == 0) Cu = Weight * double.Parse(txCu_Cal.Text);

                Cr = Weight * double.Parse(txCr.Text);
                if (Cr == 0) Cr = Weight * double.Parse(txCr_Cal.Text);

                B = Weight * double.Parse(txB.Text);
                if (B == 0) B = Weight * double.Parse(txB_Cal.Text);

                V = Weight * double.Parse(txV.Text);
                if (V == 0) V = Weight * double.Parse(txV_Cal.Text);

                Al = Weight * double.Parse(txAl.Text);
                if (Al == 0) Al = Weight * double.Parse(txAl_Cal.Text);

                Nb = Weight * double.Parse(txNb.Text);
                if (Nb == 0) Nb = Weight * double.Parse(txNb_Cal.Text);

                Zn = Weight * double.Parse(txZn.Text);
                if (Zn == 0) Zn = Weight * double.Parse(txZn_Cal.Text);

                W = Weight * double.Parse(txW.Text);
                if (W == 0) W = Weight * double.Parse(txW_Cal.Text);
                //end

                // New mix data
                foreach (DataRow rowMix in dsMixInfos.Tables[0].Rows)
                {
                    if (rowMix.RowState == DataRowState.Deleted)
                        continue;
                    double fWeight = (float)rowMix["Net_Weight"];
                    double fMn = (float)rowMix["Mn"];
                    double fP = (float)rowMix["P"];
                    double fS = (float)rowMix["S"];
                    double fTi = (float)rowMix["Ti"];
                    double fSi = (float)rowMix["Si"];
                    double fC = (float)rowMix["C"];
                    //add by hyh 2012-4-7
                    double fSn = (float)rowMix["Sn"];
                    double fSb = (float)rowMix["Sb"];
                    double fAs = (float)rowMix["As"];
                    double fPb = (float)rowMix["Pb"];
                    //end

                    //add by hyh 2012-08-13 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                    double fNi = (float)rowMix["Ni"];
                    double fMo = (float)rowMix["Mo"];
                    double fCu = (float)rowMix["Cu"];
                    double fCr = (float)rowMix["Cr"];
                    double fB = (float)rowMix["B"];
                    double fV = (float)rowMix["V"];
                    double fAl = (float)rowMix["Al"];
                    double fNb = (float)rowMix["Nb"];
                    double fZn = (float)rowMix["Zn"];
                    double fW = (float)rowMix["W"];
                    //end

                    Weight += fWeight;
                    Mn += fWeight * fMn;
                    P += fWeight * fP;
                    S += fWeight * fS;
                    Ti += fWeight * fTi;
                    Si += fWeight * fSi;
                    C += fWeight * fC;
                    //add by hyh 2012-4-7
                    Sn += fWeight * fSn;
                    Sb += fWeight * fSb;
                    As += fWeight * fAs;
                    Pb += fWeight * fPb;
                    //end

                    //add by hyh 2012-08-13 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                    Ni += fWeight * fNi;
                    Mo += fWeight * fMo;
                    Cu += fWeight * fCu;
                    Cr += fWeight * fCr;
                    B += fWeight * fB;
                    V += fWeight * fV;
                    Al += fWeight * fAl;
                    Nb += fWeight * fNb;
                    Zn += fWeight * fZn;
                    W += fWeight * fW;
                    //end

                }

                Mn = Mn / Weight;
                P = P / Weight;
                S = S / Weight;
                Ti = Ti / Weight;
                Si = Si / Weight;
                C = C / Weight;
                txWeight_Cal.Text = Weight.ToString();
                txMn_Cal.Text = Mn.ToString();
                txP_Cal.Text = P.ToString();
                txS_Cal.Text = S.ToString();
                txTi_Cal.Text = Ti.ToString();
                txSi_Cal.Text = Si.ToString();
                txC_Cal.Text = C.ToString();

                //add by hyh 2012-4-7
                Sn = Sn / Weight;
                Sb = Sb / Weight;
                As = As / Weight;
                Pb = Pb / Weight;
                txSn_Cal.Text = Sn.ToString();
                txSb_Cal.Text = Sb.ToString();
                txAs_Cal.Text = As.ToString();
                txPb_Cal.Text = Pb.ToString();
                //end

                //add by hyh 2012-08-13 应业务方要求新增：Ni(镍)、Mo(钼)、Cu(铜) 、Cr(铬)、B(硼)、V(钒)、Al(铝)、Nb(铌)、Zn(锌)、W(钨)
                Ni = Ni / Weight; Mo = Mo / Weight; Cu = Cu / Weight; Cr = Cr / Weight; B = B / Weight;
                V = V / Weight; Al = Al / Weight; Nb = Nb / Weight; Zn = Zn / Weight; W = W / Weight;
                txNi_Cal.Text = Ni.ToString();
                txMo_Cal.Text = Mo.ToString();
                txCu_Cal.Text = Cr.ToString();
                txCr_Cal.Text = Sn.ToString();
                txB_Cal.Text = B.ToString();
                txV_Cal.Text = V.ToString();
                txAl_Cal.Text = Al.ToString();
                txNb_Cal.Text = Nb.ToString();
                txZn_Cal.Text = Zn.ToString();
                txW_Cal.Text = W.ToString();

                //END
            }
            catch { }
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            
            dvMix.EndEdit();
            bsMixInfos.EndEdit();
            dsMixInfos.AcceptChanges();
            int iRet = l3cmdMix.Execute();
            if (iRet != 0 || ((int)l3cmdMix.Command.Return) == 0)
            {
                //  [12/28/2008 sun]
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, string.Format("{0:X}", l3cmdMix.Command.ErrorCode));
                MessageBox.Show("组罐失败！" + strReasultShow);
                btnMix.DialogResult = DialogResult.None;
                return;
            }
            btnMix.DialogResult = DialogResult.OK;
        }

        private void dvIn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}