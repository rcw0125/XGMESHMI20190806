using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.BOFMag
{
    public partial class BOFMagMainFrm : DockContent, IMESForm
    {
        public BOFMagMainFrm()
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

        protected virtual string GetCurUnitName()
        {
            //throw new Exception("No BOF");
            return "";
        }

        private void BOFMagMainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                panelUnit.Controls.Clear();

                string UnitID = GetCurUnitName();
               
                switch (UnitID)
                {
                    case "Bof01":
                        this.TabText = "1#ת¯����";
                        ucBOFData ucBof01 = new ucBOFData();
                        panelUnit.Controls.Add(ucBof01);
                        ucBof01.Dock = DockStyle.Fill;
                        break;
                    case "Bof02":
                        this.TabText = "2#ת¯����";
                        ucBOFData ucBof02 = new ucBOFData();
                        panelUnit.Controls.Add(ucBof02);
                        ucBof02.Dock = DockStyle.Fill;
                        break;
                    case "Lf01":
                        this.TabText = "1#LF¯����";
                        UnitMag.LFMag.ucLFData ucLf01 = new UnitMag.LFMag.ucLFData();
                        panelUnit.Controls.Add(ucLf01);
                        ucLf01.Dock = DockStyle.Fill;
                        break;
                    case "Tap01":
                        this.TabText = " 1#ת¯¯����";
                        break;
                    default:
                        break;
                }

            }
            catch { }
          
        }

        //���Ե���
        private void btnAttribute_Click(object sender, EventArgs e)
        {

        }

        //�ĸ�����
        private void btnReqChaGrade_Click(object sender, EventArgs e)
        {

        }

        //ָ����ԭ��
        private void btnDesignateMat_Click(object sender, EventArgs e)
        {

        }

        //���������ռ�
        private void btnDischarge_Click(object sender, EventArgs e)
        {

        }

        //�豸״̬ά��
        private void btnEquStatus_Click(object sender, EventArgs e)
        {

        }

        //¯�μ���
        private void btnHeatRemark_Click(object sender, EventArgs e)
        {

        }

        //���������ռ�
        private void btnMeasureOxygen_Click(object sender, EventArgs e)
        {

        }

        //��ҵ״̬ά��
        private void btnProcStatus_Click(object sender, EventArgs e)
        {

        }

        //¯��ά��
        private void btnStackMag_Click(object sender, EventArgs e)
        {

        }

        //�����쳣
        private void btnTechicsException_Click(object sender, EventArgs e)
        {

        }

        //����ʼ
        private void btnTAPStart_Click(object sender, EventArgs e)
        {

        }

        //�������
        private void btnTAPEnd_Click(object sender, EventArgs e)
        {

        }

        //�ֶ��ռ�����
        private void btnManualData_Click(object sender, EventArgs e)
        {
            UnitMag.TAPMag.ManualDataFrm frm = new UnitMag.TAPMag.ManualDataFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        //ָ������¯��
        private void btnTapDesignateLadle_Click(object sender, EventArgs e)
        {
             
        }

        //��������
        private void btnTAPHeatFinalData_Click(object sender, EventArgs e)
        {

        }

        //LF���Ե���
        private void btnLFAttribute_Click(object sender, EventArgs e)
        {

        }

        //LFָ���ְ�
        private void btnLFDesignateLadle_Click(object sender, EventArgs e)
        {

        }

        //LF����
        private void btnLFDischarge_Click(object sender, EventArgs e)
        {

        }

    }
}