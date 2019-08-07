using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class SteelExchangeFrm : Form
    {
        public SteelExchangeFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, AppSvrHMI.L3DataSet dsData)
        {

            Adapter.Session = session;

            try
            {
                //�������ּǺŻ�ȡ���ֺ�Э��
                string strSteelGradeIndex = dsData.Tables[0].Rows[0]["SteelGradeIndex"].ToString();
                string strCheckFlag = dsData.Tables[0].Rows[0]["Ex_Flag"].ToString();
                if (strSteelGradeIndex == "")
                {
                    MessageBox.Show("��ǰ����\"û�����ּǺ�\"��","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return DialogResult.None;
                }
                if (strCheckFlag == "1")
                {
                    MessageBox.Show("��ǰ����\"�Ѿ��������\"��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return DialogResult.None;
                }
                string strObject = @"XGMESLogic\QualityMag\CQA_SteelGradeIndex_R\" + strSteelGradeIndex;
                object objSteelGrade = new object();
                object objProtocol = new object();
                Adapter.Session.Get(strObject, "SteelGrade", ref  objSteelGrade);
                Adapter.Session.Get(strObject, "Protocol", ref  objProtocol);

                lbSteelGradePre.Text = objSteelGrade.ToString();
                lbProtocolPre.Text = objProtocol.ToString();

                l3cmdpSteelGrade.ConstantValue = objSteelGrade.ToString();
                l3cmdpSteelGradeIndx.ConstantValue = strSteelGradeIndex;
                dsSteelGradeIndex.L3DataAdapter = Adapter;


                dsExchange.Tables[0].Clear();
                dsExchange.Tables[0].ImportRow(dsData.Tables[0].Rows[0]);

                return ShowDialog();
            }
            catch
            {
                return DialogResult.None;
            }
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
             bsExchange.EndEdit();
            dsExchange.AcceptChanges();
            string check = MessageBox.Show("ȷ��Ҫ�ĸ�ô��", "��ʾ", 
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdExchange.Execute();
                String returnFlag = cmdExchange.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("�ĸֲ��ɹ���" + strReasultShow, "��ʾ");
                }
            }
        }

        //ѡ�����ּǺ�
        private void cmbExSteelGradeIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbExSteelGradeIndex.SelectedValue != null)
            //{
            //    lbProtocolChange.Text = "";
            //    lbStellGradeChange.Text = "";
            //}
            //DataRow[] dr = dsSteelGradeIndex.Tables[0].Select("SteelGradeIndex = '" + cmbExSteelGradeIndex.Text.Trim() + "'");
            //lbProtocolChange.Text = dr[0][""].ToString();
            //lbStellGradeChange.Text = dr[0][""].ToString();
        }

        private void SteelExchangeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
    }
}