using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace PlanMag
{
    public partial class GenCastingPlanFrm : DockContent, IMESForm
    {
        public GenCastingPlanFrm()
        {
            InitializeComponent();
        }

        private string[] strArrValue = new string[5];
        private Color[] ColorArr = new Color[5];
        #region IMESForm ��Ա

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

        //���ּƻ��Ų�
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null");
            if (dr.Length < 1)
            {
                MessageBox.Show("û��ѡ��ƻ�����û��ѡ���������ߵ�ǰû�мƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// MODIFY BY Huyunhai 2011-03-13
            else if (dr.Length > 1)
            {
                MessageBox.Show("ֻ��һ����ѡ��һ���ƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//MODIFY END

            //У��ʵ��Ͷ����
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
                {
                    if (MessageBox.Show("�ƻ�������Ϊ\"" + dr[iIndex]["PLANID"].ToString() + "\"��Ͷ��������1600�֣�ȷ��Ҫ���ƴ˽��ּƻ�ô��",
                        "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
                    {
                        dsCasting.Tables[0].ImportRow(dr[iIndex]);
                    }
                }
                else
                {
                    dsCasting.Tables[0].ImportRow(dr[iIndex]);
                }
            }
            if (dsCasting.Tables[0].Rows.Count < 1)
                return;
            //Modify Begin At 2011-03-13 By Huyunhai

            //if (MessageBox.Show("��ǰ��\"" + dsCasting.Tables[0].Rows.Count + "\"�����ּƻ���Ҫ���ƣ�",
            //    "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")

            if (MessageBox.Show("���Ͻ��ּƻ�Ҫ��ȷ��������",
                "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//������
                string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//����
                string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//Э��
                string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//����·��
                string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//���
                string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//���ϴ���
                string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//�����׼
                string Flag = "";

                SelProductPathFrm sppf = new SelProductPathFrm();
                sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
                //L3cmdpGenCasting.SourceProperty = "L3DataTable";
                //L3cmdpGenCasting.SourceObject = dsCasting;
                Flag = sppf.returnFlag;
                string tt = sppf.isExcute;
                int iRot = -1;
                if (tt.Substring(0, 2).Equals("ȷ��"))
                {
                    cmdGenCasting.Parameters[0].SourceObject = dsCasting;
                    cmdGenCasting.Parameters[0].SourceProperty = "L3DataTable";
                    cmdGenCasting.Parameters[1].ConstantValue = Flag;
                    iRot = cmdGenCasting.Execute();
                    //dsGenCasting.LoadData();
                }
                else
                    return;

                if (iRot == 0)
                {

                    string returnFlag = cmdGenCasting.Command.Return.ToString();

                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        dsGenCasting.LoadData();
                        MessageBox.Show(strReasultShow + "��", "��ʾ");
                    }
                    else
                    {
                        MessageBox.Show("���ƽ��ּƻ����ɹ���" + strReasultShow, "��ʾ");
                    }
                }
                else
                {
                    MessageBox.Show("���ƽ��ּƻ����ɹ���", "��ʾ");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
            //Modify END
        }

        //ȡ���ճ�
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫȡ���ճ�ô��", "��ʾ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdIntegrateCancel.Execute();
                dsGenCasting.LoadData();
                String returnFlag = cmdIntegrateCancel.Command.Return.ToString();
                if (returnFlag == "1" && dsGenCasting.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("ȡ���ճسɹ���", "��ʾ");
                }
                else
                {
                    MessageBox.Show("ȡ���ճز��ɹ���", "��ʾ");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
        }



        private void GenCastingPlanFrm_Load(object sender, EventArgs e)
        {
            strArrValue[0] = "11";//δ�Ų�
            strArrValue[1] = "13";//�������ּƻ�
            strArrValue[2] = "14";//�������ּƻ�
            strArrValue[3] = "15";//ִ��
            strArrValue[4] = "16";//ִ�����

            ColorArr[0] = System.Drawing.SystemColors.Control;//δ�Ų�
            ColorArr[1] = System.Drawing.Color.FromArgb(190, 190, 115);
            ColorArr[2] = System.Drawing.Color.FromArgb(210, 140, 170);
            ColorArr[3] = System.Drawing.Color.Red;
            ColorArr[4] = System.Drawing.Color.FromArgb(150, 220, 200);

            tstdtpEndDate.Value = DateTime.Now;
            tstdtpBeginDate.Value = DateTime.Now;
            for (int i = 0; i < dsSteelGrade.Tables[0].Rows.Count; i++)
            {
                tscmbSteelGrade.Items.Add(dsSteelGrade.Tables[0].Rows[i]["SteelGrade"].ToString());
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvGenCasting_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvGenCasting, "sTATUSDataGridViewTextBoxColumn", strArrValue, ColorArr);//������ɫ
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsGenCasting.LoadData();
        }

        //ɾ���ƻ�����[20090110 Liao]
        private void btnDel_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            DataSet dsDel = (DataSet)(cmdDel.Parameters[0].Value);
            if (dsDel == null || dsDel.Tables[0].Rows.Count < 1)
                return;
            if (cmdDel.Execute() >= 0)
            {
                if (Convert.ToBoolean(cmdDel.Command.Return))
                {
                    MessageBox.Show("ɾ���ƻ������ɹ���", "��ʾ", MessageBoxButtons.OK);
                    dsGenCasting.LoadData();
                }
                else
                {
                    MessageBox.Show("ɾ���ƻ�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("ɾ���ƻ�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
            }
        }

        private void GenCastingPlanFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //�رռƻ�����[2009-04-19 sun]
        private void btnClosePlan_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            DataSet dsClose = (DataSet)(cmdDel.Parameters[0].Value);
            if (dsClose == null || dsClose.Tables[0].Rows.Count < 1)
                return;
            string strFalg = MessageBox.Show("ȷ��Ҫ�رռƻ�����ô���ƻ������رպ��������Ų���", "��ʾ", MessageBoxButtons.YesNo).ToString();
            if (strFalg == "No")
                return;
            if (cmdClose.Execute() >= 0)
            {
                if (Convert.ToBoolean(cmdClose.Command.Return))
                {
                    MessageBox.Show("�رռƻ������ɹ���", "��ʾ", MessageBoxButtons.OK);
                    dsGenCasting.LoadData();
                }
                else
                {
                    MessageBox.Show("�رռƻ�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("�رռƻ�����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK);
            }
        }

        private void btnSteelLess_Click(object sender, EventArgs e)
        {
            dvGenCasting.EndEdit();
            bsGenCasting.EndEdit();

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
            if (dr.Length < 1)
            {
                MessageBox.Show("��ѡ����ּƻ�����������û��ѡ��ƻ�����û��ѡ���������ߵ�ǰû�мƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// MODIFY BY Huyunhai 2011-03-13
            else if (dr.Length > 1)
            {
                MessageBox.Show("ֻ��һ����ѡ��һ���ƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//MODIFY END



            //У��ʵ��Ͷ����
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
                {
                    if (MessageBox.Show("�ƻ�������Ϊ\"" + dr[iIndex]["PLANID"].ToString() + "\"��Ͷ��������1600�֣�ȷ��Ҫ���ƴ˽��ּƻ�ô��",
                        "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
                    {
                        dsCasting.Tables[0].ImportRow(dr[iIndex]);
                    }
                }
                else
                {
                    dsCasting.Tables[0].ImportRow(dr[iIndex]);
                }
            }
            if (dsCasting.Tables[0].Rows.Count < 1)
                return;
            //Modify Begin At 2011-03-13 By Huyunhai

            //if (MessageBox.Show("��ǰ��\"" + dsCasting.Tables[0].Rows.Count + "\"�����ּƻ���Ҫ���ƣ�",
            //    "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")

            if (MessageBox.Show("���Ͻ��ּƻ�Ҫ��ȷ��������",
                "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")
            {
                string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//������
                string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//����
                string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//Э��

                string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//����·��
                if (Path != "AL")
                {
                    MessageBox.Show("��ѡ����ֶ���");
                    return;
                }
                string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//���
                string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//���ϴ���
                string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//�����׼
                string Flag = "";

                SelProductPathFrm sppf = new SelProductPathFrm();
                sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
                //L3cmdpGenCasting.SourceProperty = "L3DataTable";
                //L3cmdpGenCasting.SourceObject = dsCasting;
                Flag = sppf.returnFlag;
                string tt = sppf.isExcute;
                int iRot = -1;
                if (tt.Substring(0, 2).Equals("ȷ��"))
                {
                    cmdSteelLess.Parameters[0].SourceObject = dsCasting;
                    cmdSteelLess.Parameters[0].SourceProperty = "L3DataTable";
                    cmdSteelLess.Parameters[1].ConstantValue = Flag;
                    iRot = cmdSteelLess.Execute();
                    //dsGenCasting.LoadData();
                }
                else
                    return;

                if (iRot == 0)
                {

                    string returnFlag = cmdSteelLess.Command.Return.ToString();

                    string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        dsGenCasting.LoadData();
                        MessageBox.Show(strReasultShow + "��", "��ʾ");
                    }
                    else
                    {
                        MessageBox.Show("���ƽ��ּƻ����ɹ���" + strReasultShow, "��ʾ");
                    }
                }
                else
                {
                    MessageBox.Show("���ƽ��ּƻ����ɹ���", "��ʾ");
                }
            }
            else
            {
                dsGenCasting.LoadData();
            }
        }

        //private void btnMelt_Click(object sender, EventArgs e)
        //{
        //    dvGenCasting.EndEdit();
        //    bsGenCasting.EndEdit();

        //    AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
        //    DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
        //    if (dr.Length < 1)
        //    {
        //        MessageBox.Show("��ѡ����ּƻ�����������û��ѡ��ƻ�����û��ѡ���������ߵ�ǰû�мƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }// MODIFY BY Huyunhai 2011-03-13
        //    else if (dr.Length > 1)
        //    {
        //        MessageBox.Show("ֻ��һ����ѡ��һ���ƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }//MODIFY END



        //    //У��ʵ��Ͷ����
        //    for (int iIndex = 0; iIndex < dr.Length; iIndex++)
        //    {
        //        if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
        //        {
        //            if (MessageBox.Show("�ƻ�������Ϊ\"" + dr[iIndex]["PLANID"].ToString() + "\"��Ͷ��������1600�֣�ȷ��Ҫ���ƴ˽��ּƻ�ô��",
        //                "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
        //            {
        //                dsCasting.Tables[0].ImportRow(dr[iIndex]);
        //            }
        //        }
        //        else
        //        {
        //            dsCasting.Tables[0].ImportRow(dr[iIndex]);
        //        }
        //    }
        //    if (dsCasting.Tables[0].Rows.Count < 1)
        //        return;
        //    //Modify Begin At 2011-03-13 By Huyunhai

        //    //if (MessageBox.Show("��ǰ��\"" + dsCasting.Tables[0].Rows.Count + "\"�����ּƻ���Ҫ���ƣ�",
        //    //    "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")

        //    if (MessageBox.Show("���Ͻ��ּƻ�Ҫ��ȷ��������",
        //        "��ʾ", MessageBoxButtons.OKCancel).ToString() == "OK")
        //    {
        //        string PLANID = dsCasting.Tables[0].Rows[0]["PLANID"].ToString();//������
        //        string STEELGRAD = dsCasting.Tables[0].Rows[0]["STEELGRADE"].ToString();//����
        //        string Protocol = dsCasting.Tables[0].Rows[0]["Protocol"].ToString();//Э��

        //        string MaterialCode = dsCasting.Tables[0].Rows[0]["MaterialCode"].ToString();//����·��
        //        //if (MaterialCode.Substring (0,3) != "617")
        //        //{
        //        //    MessageBox.Show("��ѡ���ۻ�¯̼�ֶ���");
        //        //    return;
        //        //}
        //        string standard = dsCasting.Tables[0].Rows[0]["STD"].ToString();//���
        //        string Path = dsCasting.Tables[0].Rows[0]["Product_Route"].ToString();//���ϴ���
        //        string ProduceStd = dsCasting.Tables[0].Rows[0]["ProduceStd"].ToString();//�����׼
        //        string Flag = "";

        //        SelProductPathFrm sppf = new SelProductPathFrm();
        //        sppf.ShowDialog(Adapter.Session, STEELGRAD, Protocol, PLANID, ref  Flag, Path, standard, ProduceStd, MaterialCode);
        //        //L3cmdpGenCasting.SourceProperty = "L3DataTable";
        //        //L3cmdpGenCasting.SourceObject = dsCasting;
        //        Flag = sppf.returnFlag;
        //        string tt = sppf.isExcute;
        //        int iRot = -1;
        //        if (tt.Substring(0, 2).Equals("ȷ��"))
        //        {
        //            cmdSteelLess.Parameters[0].SourceObject = dsCasting;
        //            cmdSteelLess.Parameters[0].SourceProperty = "L3DataTable";
        //            cmdSteelLess.Parameters[1].ConstantValue = Flag;
        //            iRot = cmdSteelLess.Execute();
        //            //dsGenCasting.LoadData();
        //        }
        //        else
        //            return;

        //        if (iRot == 0)
        //        {

        //            string returnFlag = cmdSteelLess.Command.Return.ToString();

        //            string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
        //            if (returnFlag == "0")
        //            {
        //                dsGenCasting.LoadData();
        //                MessageBox.Show(strReasultShow + "��", "��ʾ");
        //            }
        //            else
        //            {
        //                MessageBox.Show("���ƽ��ּƻ����ɹ���" + strReasultShow, "��ʾ");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("���ƽ��ּƻ����ɹ���", "��ʾ");
        //        }
        //    }
        //    else
        //    {
        //        dsGenCasting.LoadData();
        //    }
        //}


    }
}