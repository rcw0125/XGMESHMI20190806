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
    public partial class GenTappingPlanFrm : DockContent, IMESForm
    {
        public GenTappingPlanFrm()
        {
            InitializeComponent();
        }

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

        private string[] strArrValue = new string[4];
        private Color[] ColorArr = new Color[4];

        private int iFlag = 1;
        private string strOldValue = "";
        private string strNewValue = "";
        private string strRefineType = "";
        private string strNewBofFlag = "";
        private string strBOFID = "";
        private string strSteelGradeIndex = "";
        private string strMaterialCode = "";
        private void GenTappingPlanFrm_Load(object sender, EventArgs e)
        {
            strArrValue[0] = "10";//δ�Ų�
            strArrValue[1] = "11";//���Ų�
            strArrValue[2] = "12";//ִ��
            strArrValue[3] = "13";//ִ�����

            ColorArr[0] = System.Drawing.SystemColors.Control;//δ�Ų�
            ColorArr[1] = System.Drawing.Color.FromArgb(210, 140, 170);
            ColorArr[2] = System.Drawing.Color.Red;
            ColorArr[3] = System.Drawing.Color.FromArgb(150, 220, 200);

            tstdtpCreateDate.Value = DateTime.Now;
            for (int i = 0; i < dsCasterID.Tables[0].Rows.Count; i++)
            {
                tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[i]["Code_Des"].ToString());
            }
        }

        private void tscmbCasterID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tstxtCasterID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.SelectedItem.ToString());
        }

        private void contextCasting_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dvTapping.Rows.Count; i++)
            {
                dvTapping.Rows[i].Cells[0].Value = 1;
            }
        }

        //���Ƴ��ּƻ�
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvTapping.EndEdit();
            bsTapping.EndEdit();

            //AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsGenCasting.Clone();
            //DataRow[] dr = dsGenCasting.Tables[0].Select("CheckFlag = 1 and CASTERID is not null ");
            //if (dr.Length < 1)
            //{
            //    MessageBox.Show("��ѡ����ּƻ�����������û��ѡ��ƻ�����û��ѡ����������ǰû�мƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}// MODIFY BY Huyunhai 2011-03-13
            //else if (dr.Length > 1)
            //{
            //    MessageBox.Show("�Բ���ֻ��һ����ѡ��һ���ƻ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}//MODIFY END



            ////У��ʵ��Ͷ����
            //for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            //{
            //    if (Convert.ToInt16(dr[iIndex]["SpareWeight"].ToString()) > 1600)
            //    {
            //        if (MessageBox.Show("�ƻ�������Ϊ\"" + dr[iIndex]["PLANID"].ToString() + "\"��Ͷ��������1600�֣�ȷ��Ҫ���ƴ˽��ּƻ�ô��",
            //            "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            //        {
            //            dsCasting.Tables[0].ImportRow(dr[iIndex]);
            //        }
            //    }
            //    else
            //    {
            //        dsCasting.Tables[0].ImportRow(dr[iIndex]);
            //    }
            //}

            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsTapping.Clone();
            DataRow[] dr = dsTapping.Tables[0].Select("CheckFlag = 1");
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                //if (dr[iIndex]["BOFID"].ToString() == "S25")
                if (dr[iIndex]["Pre_SteelGradeIndex"].ToString().Substring(0, 1) == "B")
                {
                    MessageBox.Show("��ѡ����ּƻ��Ų���");
                    return;
                }
                if (dr[iIndex]["BOFID"].ToString() != "S51" && dr[iIndex]["MaterialCode"].ToString().Substring(0, 3) == "617")
                {
                    MessageBox.Show("��ѡ���ۻ�¯��");
                    return;
                }

            }



            string check = MessageBox.Show("ȷ��Ҫ���Ƴ��ּƻ�ô��", "��ʾ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTapping1.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdTapping1.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                }
                else
                {
                    MessageBox.Show("���Ƴ��ּƻ����ɹ���" + returnFlag, "��ʾ");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //ȡ�����ּƻ�
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            string check = MessageBox.Show("ȷ��Ҫȡ�����ּƻ�ô��", "��ʾ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdCastingCancel.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdCastingCancel.Command.Return.ToString();
                if (returnFlag == "1")
                {
                    MessageBox.Show("ȡ�����ּƻ��ɹ���", "��ʾ");
                }
                else
                {
                    MessageBox.Show("ȡ�����ּƻ����ɹ���", "��ʾ");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvTapping_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvTapping, "STATUS", strArrValue, ColorArr);//������ɫ
        }

        //�ж�ѡ����·���Ƿ���ȷ
        private void dvTapping_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if ((bsTapping.Position < 0) || (dvTapping.CurrentCell.ColumnIndex == 0))
                return;

            iFlag += 1;
            if (iFlag == 1)
            {
                strOldValue = dvTapping.CurrentCell.Value.ToString();
                strRefineType = dvTapping.Rows[bsTapping.Position].Cells["REFINE_TYPE"].Value.ToString();
                strNewBofFlag = dvTapping.Rows[bsTapping.Position].Cells["NEW_BOF_FLAG"].Value.ToString();
                strSteelGradeIndex = dvTapping.Rows[bsTapping.Position].Cells["pRESTEELGRADEINDEXDataGridViewTextBoxColumn"].Value.ToString();
                strMaterialCode = dvTapping.Rows[bsTapping.Position].Cells["MaterialCode"].Value.ToString();
                strBOFID = dvTapping.Rows[bsTapping.Position].Cells["BOFID"].Value.ToString();
            }
            dvTapping.EndEdit();

            strNewValue = dvTapping.CurrentCell.Value.ToString();
            //if (strNewBofFlag == "1" && iFlag == 2)              //ȡ����4#ת¯��������3��4#���������ơ�2017-11-07
            //{
            //    MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    dvTapping.CurrentCell.Value = strOldValue;
            //}
            //else if (strNewBofFlag == "0" && iFlag == 2)
             if (strNewBofFlag == "0" && iFlag == 2)
            {
                //ѡ��RH¯
                if (dvTapping.CurrentCell.ColumnIndex == 6 && strNewValue=="S51")//ע��RHҲΪS51
                {
                    MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dvTapping.CurrentCell.Value = strOldValue;
                }
                //ѡ��ת¯
                else if (dvTapping.CurrentCell.ColumnIndex == 3)
                {
                    if (strNewValue == "S24")
                    {
                        MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dvTapping.CurrentCell.Value = strOldValue;
                    }
                    else if (strRefineType == "A" && dvTapping.CurrentCell.ColumnIndex == 3)
                    {
                        if (strNewValue != "S51")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "0" && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    {
                        if (strNewValue == "S51" && strMaterialCode.Substring (0,3) != "617")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                        else if (strNewValue == "S25")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L" && dvTapping.CurrentCell.ColumnIndex == 3 &&  strSteelGradeIndex.Substring (0,1)=="B")
                    {
                        if (strNewValue != "S25")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L" && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    {
                        if (strNewValue == "S51" || strNewValue == "S25")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    //else if ((strRefineType == "L" || strRefineType == "0" ) && dvTapping.CurrentCell.ColumnIndex == 3 && strSteelGradeIndex.Substring(0, 1) != "B")
                    //{
                    //    if (strNewValue == "S25")
                    //    {
                    //        MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //        dvTapping.CurrentCell.Value = strOldValue;
                    //    }
                    //}

                }

                //ѡ��LF¯
                else if (dvTapping.CurrentCell.ColumnIndex == 5)
                {
                    if (strRefineType == "0" && strBOFID == "S51")//�˴�S51Ϊ�ۻ�¯
                    {
                        if (strOldValue != strNewValue)
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                    else if (strRefineType == "L")
                    {
                        if (strNewValue == "S43" || strNewValue == "0")
                        {
                            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dvTapping.CurrentCell.Value = strOldValue;
                        }
                    }
                }
            }
            iFlag = 0;
        }

        //�ж�ѡ����·���Ƿ���ȷ
        //private void routeJudge()
        //{
        //    //if ((bsTapping.Position < 0) || (dvTapping.CurrentCell.ColumnIndex == 0))
        //    //    return;

        //    iFlag += 1;
        //    if (iFlag == 1)
        //    {
        //        strOldValue = dvTapping.CurrentCell.Value.ToString();
        //        strRefineType = dvTapping.Rows[bsTapping.Position].Cells["REFINE_TYPE"].Value.ToString();
        //        strNewBofFlag = dvTapping.Rows[bsTapping.Position].Cells["NEW_BOF_FLAG"].Value.ToString();
        //    }
        //    dvTapping.EndEdit();

        //    strNewValue = dvTapping.CurrentCell.Value.ToString();
        //    if (strNewBofFlag == "1" && iFlag == 2)
        //    {
        //        MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        dvTapping.CurrentCell.Value = strOldValue;
        //    }
        //    else if (strNewBofFlag == "0" && iFlag == 1)
        //    {
        //        //ѡ��RH¯
        //        if (dvTapping.CurrentCell.ColumnIndex == 5)
        //        {
        //            MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            dvTapping.CurrentCell.Value = strOldValue;
        //        }
        //        //ѡ��ת¯
        //        else if (dvTapping.CurrentCell.ColumnIndex == 3)
        //        {
        //            if (strNewValue == "S24")
        //            {
        //                MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                dvTapping.CurrentCell.Value = strOldValue;
        //            }
        //            else if (strRefineType == "A" && dvTapping.CurrentCell.ColumnIndex == 3)
        //            {
        //                if (strNewValue != "S51")
        //                {
        //                    MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //        }

        //        //ѡ��LF¯
        //        else if (dvTapping.CurrentCell.ColumnIndex == 4)
        //        {
        //            if (strRefineType == "0")
        //            {
        //                if (strOldValue != strNewValue)
        //                {
        //                    MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //            else if (strRefineType == "L")
        //            {
        //                if (strNewValue == "S43" || strNewValue == "0")
        //                {
        //                    MessageBox.Show("����·���������޸ģ�", "ע�⣡", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    dvTapping.CurrentCell.Value = strOldValue;
        //                }
        //            }
        //        }
        //    }
        //    iFlag = 0;
        //}

        private void btnTappingAct_Click(object sender, EventArgs e)
        {
            TappingActFrm frm = new TappingActFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void GenTappingPlanFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void BuSteelBtn_Click(object sender, EventArgs e)
        {
            //routeJudge();
            dvTapping.EndEdit();
            bsTapping.EndEdit();
            AppSvrHMI.L3DataSet dsCasting = (AppSvrHMI.L3DataSet)dsTapping.Clone();
            DataRow[] dr = dsTapping.Tables[0].Select("CheckFlag = 1");
            for (int iIndex = 0; iIndex < dr.Length; iIndex++)
            {
                //if (dr[iIndex]["BOFID"].ToString() == "S25")
                if (dr[iIndex]["Pre_SteelGradeIndex"].ToString().Substring(0, 1) != "B")
                {
                    MessageBox.Show("��ѡ�ƻ��ǲ���֣���ѡ����ּƻ��Ų���");
                    return;
                }

            }

            string check = MessageBox.Show("ȷ��Ҫ���Ƴ��ּƻ�ô��", "��ʾ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdTapping.Execute();
                dsTapping.LoadData();
                String returnFlag = cmdTapping.Command.Return.ToString();
                string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                if (returnFlag == "0")
                {
                   // updateHeatid.Execute();
                    MessageBox.Show(strReasultShow + "��", "��ʾ");
                }
                else
                {
                    MessageBox.Show("���Ƴ��ּƻ����ɹ���" + returnFlag, "��ʾ");
                }
            }
            else
            {
                dsTapping.LoadData();
            }
        }
    }
}