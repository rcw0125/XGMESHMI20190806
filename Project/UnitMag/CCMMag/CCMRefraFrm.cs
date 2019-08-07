using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnitMag.CCMMag
{

    public enum EquipType : int
    {
        SmoothBlock = 1,	//����
        HurryWaterGap = 2,		//ˮ��
        BigWaterGap = 3,	//���ˮ��
    }

    public partial class CCMRefraFrm : Form
    {
        public CCMRefraFrm()
        {
            InitializeComponent();
        }

        public EquipType MainEquipType = EquipType.SmoothBlock;

        private string strStrandNo = "1";//����

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string UnitID)
        {
            /****Modify By Huyunhai 2011-3-15****/
            if (UnitID.Equals("S67"))
            {
                rbtnStrandNo4.Enabled = false;
                rbtnStrandNo4.Visible = false;
            }
            /****Modify End****/
            if (UnitID == null || UnitID.Length != 3 || UnitID.Substring(1, 1).ToString() != "6")
            {
                MessageBox.Show("��ǰ����������Ͳģ�ԭ����û���ҵ���Ӧ��������", "��ʾ");
                return DialogResult.No;
            }

            Adapter.set_URIParameters("CCMID", UnitID);
            txtCCMID.Text = UnitID;

            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            if (dbxTreatNO.Text.Trim() == "")
            {
                MessageBox.Show("��ǰ����������Ͳģ�ԭ����û���ҵ���Ӧ�Ĵ���ţ�", "��ʾ");
                return DialogResult.No;
            }
            object objHeatID = null;
            Adapter.Session.Get(@"XGMESLogic\CCMMag\CCCM_Base_Data\" + dbxTreatNO.Text.Trim(), "HeatID", ref objHeatID);
            if (objHeatID != null)
                txtHeatID.Text = objHeatID.ToString();
            else
            {
                MessageBox.Show("��ǰ����������Ͳģ�ԭ����û���ҵ���Ӧ��¯�ţ�", "��ʾ");
                return DialogResult.No;
            }

            return ShowDialog();
        }

        //�������
        private void CCMRefraFrm_Load(object sender, EventArgs e)
        {
            rbtnStrandNo1.Checked = true;

            switch (MainEquipType)
            {
                case EquipType.SmoothBlock:
                    this.Text += "--�컻����";
                    //�Ͳĳ���
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsSmoothBlockFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //����ԭ��
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsSmoothBlockReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
                case EquipType.HurryWaterGap:
                    this.Text += "--�а�ˮ��";
                    //�Ͳĳ���
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsHurryGapFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //����ԭ��
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsHurryGapReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
                case EquipType.BigWaterGap:
                    this.Text += "--���ˮ��";
                    //�Ͳĳ���
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsBigGapFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //����ԭ��
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsBigGapReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
            }
        }

        //ѡ������
        private void rbtnStrandNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStrandNo1.Checked)
            {
                strStrandNo = "1";
            }
            else if (rbtnStrandNo2.Checked)
            {
                strStrandNo = "2";
            }
            else if (rbtnStrandNo3.Checked)
            {
                strStrandNo = "3";
            }
            else if (rbtnStrandNo4.Checked)
            {
                strStrandNo = "4";
            }
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool bSuccess = false;
            try
            {
                switch (MainEquipType)
                {
                    case EquipType.SmoothBlock:

                        dsSmoothBlock.Tables[0].Rows.Clear();
                        DataRow newrow1 = dsSmoothBlock.Tables[0].NewRow();
                        //¯��
                        newrow1["HeatID"] = txtHeatID.Text;
                        //������
                        newrow1["CCMID"] = txtCCMID.Text;
                        //����
                        newrow1["StrandNo"] = strStrandNo;
                        //�Ͳĳ���
                        newrow1["Factory"] = cmbFactory.SelectedValue.ToString();
                        //���
                        newrow1["Block_Size"] = txtSize.Text;
                        //����ԭ��
                        newrow1["Reason"] = cmbReason.SelectedValue.ToString();
                        //�Ͳ�����
                        newrow1["EquipmentType"] = 1;

                        dsSmoothBlock.Tables[0].Rows.Add(newrow1);
                        dsSmoothBlock.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsSmoothBlock;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("�����컻����ɹ���", "��ʾ");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("�����컻����ʧ�ܣ�", "��ʾ");
                            bSuccess = false;
                        }
                        break;

                    case EquipType.HurryWaterGap:

                        dsHurryGap.Tables[0].Rows.Clear();
                        DataRow newrow2 = dsHurryGap.Tables[0].NewRow();
                        //¯��
                        newrow2["HeatID"] = txtHeatID.Text;
                        //������
                        newrow2["CCMID"] = txtCCMID.Text;
                        //����
                        newrow2["StrandNo"] = strStrandNo;
                        //�Ͳĳ���
                        newrow2["Factory"] = cmbFactory.SelectedValue.ToString();
                        //����
                        newrow2["MatType"] = txtSize.Text;
                        //����ԭ��
                        newrow2["Reason"] = cmbReason.SelectedValue.ToString();
                        //�Ͳ�����
                        newrow2["EquipmentType"] = 2;

                        dsHurryGap.Tables[0].Rows.Add(newrow2);
                        dsHurryGap.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsHurryGap;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("�����а�ˮ�ڳɹ���", "��ʾ");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("�����а�ˮ��ʧ�ܣ�", "��ʾ");
                            bSuccess = false;
                        }
                        break;

                    case EquipType.BigWaterGap:

                        dsBigGap.Tables[0].Rows.Clear();
                        DataRow newrow3 = dsBigGap.Tables[0].NewRow();
                        //¯��
                        newrow3["HeatID"] = txtHeatID.Text;
                        //������
                        newrow3["CCMID"] = txtCCMID.Text;
                        //����
                        newrow3["StrandNo"] = strStrandNo;
                        //�Ͳĳ���
                        newrow3["Factory"] = cmbFactory.SelectedValue.ToString();
                        //����
                        newrow3["MatType"] = txtSize.Text;
                        //����ԭ��
                        newrow3["Reason"] = cmbReason.SelectedValue.ToString();
                        //�Ͳ�����
                        newrow3["EquipmentType"] = 3;

                        dsBigGap.Tables[0].Rows.Add(newrow3);
                        dsBigGap.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsBigGap;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("�������ˮ�ڳɹ���", "��ʾ");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("�������ˮ��ʧ�ܣ�", "��ʾ");
                            bSuccess = false;
                        }
                        break;
                }
                if (bSuccess)
                    this.Close();
            }
            catch
            { }
        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  