using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//modify by hyh 2012-04-25
//����6#��¯������
namespace UnitMag.BFMag
{
    public partial class IronSampleFrm : Form
    {
        public IronSampleFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;
            return ShowDialog();
        }

        private void IronSampleFrm_Load(object sender, EventArgs e)
        {
            dsTapNo.LoadData();
            ckbHF1.Checked = true;
            ckbHF2.Checked = true;
            ckbHF3.Checked = true;
            ckbHF4.Checked = true;
            ckbHF5.Checked = true;
            ckbHF6.Checked = true;
        }

        //ѡ���¯
        private void ckbHF_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "CheckBox")
                    return;
                bool bckb = false;
                CheckBox ckbBF = (CheckBox)sender;
                if (ckbBF.Tag.ToString() == "")
                    return;
                //�ж��Ƿ�ѡ��
                if (ckbBF.Checked)
                    bckb = true;

                int iBFID = Convert.ToInt32(ckbBF.Tag.ToString());
                SetTapNo(iBFID, bckb);//���κ�
                //SetIronGroupNo(iBFID, bckb);//��ˮ����
            }
            catch { }
        }

        //ѡ����
        private void cmbTpcGroupNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "ComboBox")
                    return;

                ComboBox cmbGroup = (ComboBox)sender;
                if (cmbGroup.Tag.ToString() == "")
                    return;
                string strGroupName = cmbGroup.Text.Trim();
                //modify by hyh 2012-04-27
                int iBFID = Convert.ToInt32(cmbGroup.Tag.ToString());
                if (iBFID == 1)
                {
                    txtTpcNo1.Text = "";
                    ckbSeqNo11.Checked = false;
                    ckbSeqNo12.Checked = false;
                    ckbSeqNo13.Checked = false;
                }
                else if (iBFID == 2)
                {
                    txtTpcNo2.Text = "";
                    ckbSeqNo21.Checked = false;
                    ckbSeqNo22.Checked = false;
                    ckbSeqNo23.Checked = false;
                }
                else if (iBFID == 3)
                {
                    txtTpcNo3.Text = "";
                    ckbSeqNo31.Checked = false;
                    ckbSeqNo32.Checked = false;
                    ckbSeqNo33.Checked = false;
                }
                else if (iBFID == 4)
                {
                    txtTpcNo4.Text = "";
                    ckbSeqNo41.Checked = false;
                    ckbSeqNo42.Checked = false;
                    ckbSeqNo43.Checked = false;
                }
                else if (iBFID == 5)
                {
                    txtTpcNo5.Text = "";
                    ckbSeqNo51.Checked = false;
                    ckbSeqNo52.Checked = false;
                    ckbSeqNo53.Checked = false;
                }
                else if (iBFID == 6)
                {
                    txtTpcNo6.Text = "";
                    ckbSeqNo61.Checked = false;
                    ckbSeqNo62.Checked = false;
                    ckbSeqNo63.Checked = false;
                }
                //end

                bool bckb = false;
                if (strGroupName != "")
                    bckb = true;

                SetTpcNo(iBFID, strGroupName, 0, bckb);
            }
            catch { }

        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //��֯���ݼ�ʧ��
            if (!FormDataSet())
                return;

            cmdpdsIron.SourceObject = dsM;
            if (cmdM.Execute() >= 0)
            {
                int iRet = (int)cmdM.Command.Return;
                if (iRet > 0)
                {
                    MessageBox.Show("�����ɹ���", "��ʾ", MessageBoxButtons.OK);
                    this.Close();
                }
                else { MessageBox.Show("����ʧ�ܣ��������Ϊ��  "+iRet.ToString(), "��ʾ", MessageBoxButtons.OK); }
            }
            else { MessageBox.Show("����ʧ�ܣ�", "��ʾ", MessageBoxButtons.OK); }
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��ȡ��Ӧ��¯���κŲ��ҽ����1
        private void SetTapNo(int iBFID, bool bckb)
        {
            try
            {
                
                MaskedTextBox mtxtTapNo = new MaskedTextBox();
                ComboBox cmbGroup = new ComboBox();
                CheckBox ckbSeqNo = new CheckBox();

                switch (iBFID)
                {
                    case 1:
                        mtxtTapNo = mtxtTapNo1;
                        cmbGroup = cmbTpcGroupNo1;
                        ckbSeqNo = ckbSeqNo11;
                        break;
                    case 2:
                        mtxtTapNo = mtxtTapNo2;
                        cmbGroup = cmbTpcGroupNo2;
                        ckbSeqNo = ckbSeqNo22;
                        break;
                    case 3:
                        mtxtTapNo = mtxtTapNo3;
                        cmbGroup = cmbTpcGroupNo3;
                        ckbSeqNo = ckbSeqNo33;
                        break;
                    case 4:
                        mtxtTapNo = mtxtTapNo4;
                        cmbGroup = cmbTpcGroupNo4;
                        ckbSeqNo = ckbSeqNo41;
                        break;
                    case 5:
                        mtxtTapNo = mtxtTapNo5;
                        cmbGroup = cmbTpcGroupNo5;
                        ckbSeqNo = ckbSeqNo52;
                        break;
                    case 6:
                        mtxtTapNo = mtxtTapNo6;
                        cmbGroup = cmbTpcGroupNo6;
                        ckbSeqNo = ckbSeqNo62;
                        break;
                    default:
                        break;
                }
                //�ж��Ƿ�Ϊ��ǰ�����ϵ����κ�TextBox
                if (mtxtTapNo.Tag.ToString() == "")
                    return;

                mtxtTapNo.Text = "";
                //û��ѡ�У�������κ�
                if (!bckb)
                {
                    mtxtTapNo.ReadOnly = true;
                    cmbGroup.Text = "";
                    ckbSeqNo.Checked = false;
                    return;
                }
                //cmbGroup.Text = "A";
                mtxtTapNo.ReadOnly = false;
                ckbSeqNo.Checked = true;
                //���ݸ�¯�Ż�ȡ���κ�
                DataRow[] drArray = dsTapNo.Tables[0].Select("BFID = '" + iBFID + "'");
                if (drArray.Length < 1)
                    return;
                else
                {
                    Int32 iTapNo = Convert.ToInt32(drArray[0]["TAPNO"].ToString()) + 1;
                    mtxtTapNo.Text = iTapNo.ToString();
                }
            }
            catch { }
        }

        //������ˮ��������Դ
        private void SetIronGroupNo(int iBFID, bool bckb)
        {
            try
            {
                ComboBox cmbGroup = new ComboBox();
                switch (iBFID)
                {
                    case 1:
                        cmbGroup = cmbTpcGroupNo1;
                        break;
                    case 2:
                        cmbGroup = cmbTpcGroupNo2;
                        break;
                    case 3:
                        cmbGroup = cmbTpcGroupNo3;
                        break;
                    case 4:
                        cmbGroup = cmbTpcGroupNo4;
                        break;
                    case 5:
                        cmbGroup = cmbTpcGroupNo5;
                        break;
                    case 6:
                        cmbGroup = cmbTpcGroupNo6;
                        break;
                    default:
                        break;
                }
                //�ж��Ƿ�Ϊ��ǰ�����ϵ���ComboBox
                if (cmbGroup.Tag.ToString() == "")
                    return;
                CheckBox ckbseqno1 = new CheckBox();
                CheckBox ckbseqno2 = new CheckBox();
                CheckBox ckbseqno3 = new CheckBox();
                switch (iBFID)
                {
                    case 1:
                        ckbseqno1 = ckbSeqNo11;
                        ckbseqno2 = ckbSeqNo12;
                        ckbseqno3 = ckbSeqNo13;
                        break;
                    case 2:
                        ckbseqno1 = ckbSeqNo21;
                        ckbseqno2 = ckbSeqNo22;
                        ckbseqno3 = ckbSeqNo23;
                        break;
                    case 3:
                        ckbseqno1 = ckbSeqNo31;
                        ckbseqno2 = ckbSeqNo32;
                        ckbseqno3 = ckbSeqNo33;
                        break;
                    case 4:
                        ckbseqno1 = ckbSeqNo41;
                        ckbseqno2 = ckbSeqNo42;
                        ckbseqno3 = ckbSeqNo43;
                        break;
                    case 5:
                        ckbseqno1 = ckbSeqNo51;
                        ckbseqno2 = ckbSeqNo52;
                        ckbseqno3 = ckbSeqNo53;
                        break;
                    case 6:
                        ckbseqno1 = ckbSeqNo61;
                        ckbseqno2 = ckbSeqNo62;
                        ckbseqno3 = ckbSeqNo63;
                        break;
                    default:
                        break;
                }
                ckbseqno1.Checked = false;
                ckbseqno2.Checked = false;
                ckbseqno3.Checked = false;

                cmbGroup.Items.Clear();
                //���û��ѡ�У������������Դ�󷵻�
                if (!bckb)
                    return;

                //dsGroupNo.SourceMethod = "select GroupNo from CBF_IronLadle_Info where 1=2";
                //dsGroupNo.SourceMethod = "select GroupNo from CBF_IronLadle_Info where BFID = '" + iBFID + "' order by GroupNo";

                DataRow[] drArray = dsIronLadleInfo.Tables[0].Select("BFID = '" + iBFID + "'");
                //for (int i = 0; i < dsGroupNo.Tables[0].Rows.Count; i++)
                foreach (DataRow dr in drArray)
                    cmbGroup.Items.Add(dr["GroupNo"].ToString());
            }
            catch { }
        }

        //��֯�����̨���ݼ�
        private bool FormDataSet()
        {
            try
            {
                dsM.Tables[0].Rows.Clear();

                if (ckbHF1.Checked)
                {
                    if (mtxtTapNo1.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("1#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo1.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("1#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 1;
                    newrow["TAP_No"] = mtxtTapNo1.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo1.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo1.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }
                if (ckbHF2.Checked)
                {
                    if (mtxtTapNo2.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("2#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo2.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("2#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 2;
                    newrow["TAP_No"] = mtxtTapNo2.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo2.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo2.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }
                if (ckbHF3.Checked)
                {
                    if (mtxtTapNo3.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("3#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo3.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("3#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 3;
                    newrow["TAP_No"] = mtxtTapNo3.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo3.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo3.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }
                if (ckbHF4.Checked)
                {
                    if (mtxtTapNo4.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("4#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo4.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("4#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 4;
                    newrow["TAP_No"] = mtxtTapNo4.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo4.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo4.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }
                if (ckbHF5.Checked)
                {
                    if (mtxtTapNo5.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("5#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo5.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("5#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 5;
                    newrow["TAP_No"] = mtxtTapNo5.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo5.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo5.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }
                if (ckbHF6.Checked)
                {
                    if (mtxtTapNo6.Text.Trim().Length != 9)
                    {
                        MessageBox.Show("6#��¯���κ�λ�����ԣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    if (txtTpcNo6.Text.Trim().Length < 1)
                    {
                        MessageBox.Show("6#��¯û��ѡ�����ޣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    DataRow newrow = dsM.Tables[0].NewRow();
                    newrow["BFID"] = 6;
                    newrow["TAP_No"] = mtxtTapNo6.Text.Trim();
                    newrow["TPC_No"] = txtTpcNo6.Text.Trim();
                    newrow["Name"] = cmbTpcGroupNo6.Text.Trim();
                    dsM.Tables[0].Rows.Add(newrow);
                }

                dsM.AcceptChanges();
                if (dsM.Tables[0].Rows.Count < 1)
                    return false;
                else
                    return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// ѡ����ˮ��˳��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbSqlNo_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "CheckBox")
                    return;

                CheckBox ckbBF = (CheckBox)sender;
                if (ckbBF.Tag.ToString().Length != 2)
                    return;

                int iBFID = Convert.ToInt32(ckbBF.Tag.ToString().Substring(0, 1));//��¯��
                int iSeqID = Convert.ToInt32(ckbBF.Tag.ToString().Substring(1, 1));//˳���1:1-2 / 2:3-4 / 3:5-6

                bool bckb = false;
                //�ж��Ƿ�ѡ��
                if (ckbBF.Checked)
                    bckb = true;
                if (bckb)
                {
                    switch (iBFID)
                    {
                        case 1:
                            if (iSeqID.ToString() != ckbSeqNo11.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo11.Checked)
                                    ckbSeqNo11.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo12.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo12.Checked)
                                    ckbSeqNo12.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo13.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo13.Checked)
                                    ckbSeqNo13.Checked = false;
                            break;
                        case 2:
                            if (iSeqID.ToString() != ckbSeqNo21.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo21.Checked)
                                    ckbSeqNo21.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo22.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo22.Checked)
                                    ckbSeqNo22.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo23.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo23.Checked)
                                    ckbSeqNo23.Checked = false;
                            break;
                        case 3:
                            if (iSeqID.ToString() != ckbSeqNo31.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo31.Checked)
                                    ckbSeqNo31.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo32.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo32.Checked)
                                    ckbSeqNo32.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo33.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo33.Checked)
                                    ckbSeqNo33.Checked = false;
                            break;
                        case 4:
                            if (iSeqID.ToString() != ckbSeqNo41.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo41.Checked)
                                    ckbSeqNo41.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo42.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo42.Checked)
                                    ckbSeqNo42.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo43.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo43.Checked)
                                    ckbSeqNo43.Checked = false;
                            break;
                        case 5:
                            if (iSeqID.ToString() != ckbSeqNo51.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo51.Checked)
                                    ckbSeqNo51.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo52.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo52.Checked)
                                    ckbSeqNo52.Checked = false;

                            if (iSeqID.ToString() != ckbSeqNo53.Tag.ToString().Substring(1, 1))
                                if (ckbSeqNo53.Checked)
                                    ckbSeqNo53.Checked = false;
                            break;
                        case 6:
                            //{
                            //    if (iSeqID.ToString() != ckbSeqNo61.Tag.ToString().Substring(1, 1))
                            //        if (ckbSeqNo61.Checked)
                            //            ckbSeqNo61.Checked = false;

                            //    if (iSeqID.ToString() != ckbSeqNo62.Tag.ToString().Substring(1, 1))
                            //        if (ckbSeqNo62.Checked)
                            //            ckbSeqNo62.Checked = false;

                            //    if (iSeqID.ToString() != ckbSeqNo63.Tag.ToString().Substring(1, 1))
                            //        if (ckbSeqNo63.Checked)
                            //            ckbSeqNo63.Checked = false;
                            //}
                            break;
                        default:
                            break;
                    }
                }
                SetTpcNo(iBFID, "", iSeqID, bckb);
            }
            catch { }
        }

        /// <summary>
        /// �������޺�
        /// </summary>
        /// <param name="iBFID">��¯��</param>
        /// <param name="strGroupName">����</param>
        /// <param name="iSeqID">Tagֵ</param>
        /// <param name="bckb">�Ƿ�ѡ��˳���</param>
        private void SetTpcNo(int iBFID, string strGroupName, int iSeqID, bool bckb)
        {
            //�����¯��û���ڷ�Χ��
            if (iBFID < 1 || iBFID > 6)
                return;

            //��ǹ޺��Ƿ�Ϊ��
            bool bNull = false;

            //û��������˳���
            if (strGroupName == "" && iSeqID == 0)
                bNull = true;

            //���û��ѡ��˳��ţ���Ϊ��
            if (!bckb)
                bNull = true;

            TextBox txtTpcNo = new TextBox();
            switch (iBFID)
            {
                case 1:
                    txtTpcNo = txtTpcNo1;
                    break;
                case 2:
                    txtTpcNo = txtTpcNo2;
                    break;
                case 3:
                    txtTpcNo = txtTpcNo3;
                    break;
                case 4:
                    txtTpcNo = txtTpcNo4;
                    break;
                case 5:
                    txtTpcNo = txtTpcNo5;
                    break;
                case 6:
                    txtTpcNo = txtTpcNo6;
                    break;
                default:
                    break;
            }
            if (txtTpcNo.Tag.ToString() == "")
                return;
            //������޺�Ӧ��Ϊ��
            if (bNull)
            {
                txtTpcNo.Text = "";
                return;
            }
            //����������޺�
            string strSql = "";// "BFID = '" + iBFID + "'";
            if (strGroupName != "")
            {
                switch (iBFID)
                {
                    case 1:
                        if (ckbSeqNo11.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo12.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo13.Checked)
                            iSeqID = 3;
                        break;
                    case 2:
                        if (ckbSeqNo21.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo22.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo23.Checked)
                            iSeqID = 3;
                        break;
                    case 3:
                        if (ckbSeqNo31.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo32.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo33.Checked)
                            iSeqID = 3;
                        break;
                    case 4:
                        if (ckbSeqNo41.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo42.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo43.Checked)
                            iSeqID = 3;
                        break;
                    case 5:
                        if (ckbSeqNo51.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo52.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo53.Checked)
                            iSeqID = 3;
                        break;
                    case 6:
                        if (ckbSeqNo61.Checked)
                            iSeqID = 1;
                        else if (ckbSeqNo62.Checked)
                            iSeqID = 2;
                        else if (ckbSeqNo63.Checked)
                            iSeqID = 3;
                        break;
                    default:
                        iSeqID = 0;
                        break;
                }
            }
            else if (iSeqID != 0)
            {
                switch (iBFID)
                {
                    case 1:
                        strGroupName = cmbTpcGroupNo1.Text.Trim();
                        break;
                    case 2:
                        strGroupName = cmbTpcGroupNo2.Text.Trim();
                        break;
                    case 3:
                        strGroupName = cmbTpcGroupNo3.Text.Trim();
                        break;
                    case 4:
                        strGroupName = cmbTpcGroupNo4.Text.Trim();
                        break;
                    case 5:
                        strGroupName = cmbTpcGroupNo5.Text.Trim();
                        break;
                    case 6:
                        strGroupName = cmbTpcGroupNo6.Text.Trim();
                        break;
                    default:
                        strGroupName = "";
                        break;
                }
            }
            //�Ҳ��������Ĳ�ѯ����
            if (strGroupName == "" || iSeqID == 0)
            {
                txtTpcNo.Text = "";
                return;
            }
            strSql = " GroupNo = '" + strGroupName.Trim() + "'";
            switch (iSeqID)
            {
                case 1:
                    strSql += "and (Order_No = '1' or Order_No = '2') ";
                    break;

                case 2:
                    strSql += "and (Order_No = '3' or Order_No = '4') ";
                    break;

                case 3:
                    strSql += "and (Order_No = '5' or Order_No = '6') ";
                    break;
                default:
                    strSql += " and 1=2";
                    break;
            }
            //���
            if (iBFID != 6)
                txtTpcNo.Text = "";
            
            DataRow[] drArray = dsIronLadleInfo.Tables[0].Select(strSql);
            if (txtTpcNo.Text != "")
                txtTpcNo.Text += ",";
            foreach (DataRow dr in drArray)
            {
               
                if (dr["TPC_No"].ToString() != "")
                    txtTpcNo.Text += dr["TPC_No"].ToString() + ",";
            }
            //ȥ�������','
            if (txtTpcNo.Text.Trim().Length > 1)
                txtTpcNo.Text = txtTpcNo.Text.Trim().Substring(0, txtTpcNo.Text.Trim().Length - 1);
        }

        private void mtxtTapNo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//end