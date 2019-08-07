using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace UnitMag.AODMag
{
    public partial class AODHeatFinalDataFrm : DockContent, IMESForm
    {
        public AODHeatFinalDataFrm()
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



        public DialogResult ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            return ShowDialog();
        }

        private void BOFHeatFinalDataFrm_Load(object sender, EventArgs e)
        {
            dtData.Value = DateTime.Now;
            
        }

        //�޸�
        private void dvBOFData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string HeatID = dvBOFData.Rows[e.RowIndex].Cells[0].Value.ToString();
                bool check = false;
                bool bLocked = false;

                //����ά��
                if (cxCheckFlag.Checked)
                    check = true;

                //ʵ��������־
                if (Convert.ToBoolean(dvBOFData.Rows[e.RowIndex].Cells[Locked.Index].Value))
                    bLocked = true;

                AODHeatInfoFrm frmBOFHeatInfo = new AODHeatInfoFrm();
                frmBOFHeatInfo.ShowDialogEx(Adapter.Session, bLocked, check, HeatID, false);
                GC.Collect();
            }
            catch { }
        }
        //��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (txtHeatID.Text.Length != 9)
            {
                if (txtHeatID.Text.Trim() == "")
                {
                  
                        dsBOFData.SourceCondition = "to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                }
                else
                {
                        dsBOFData.SourceCondition = "HeatID like '%" + txtHeatID.Text.Trim() + "%' and to_Char(ProductionDate,'yyyy-MM-dd') = '" + dtData.Text.Trim() + "' order by HeatID";
                }
            }
            else
            {
                dsBOFData.SourceCondition = "HeatID = '" + txtHeatID.Text.Trim() + "'";
            }
            //dsBOFData.AcceptChanges();
        }
        //ʵ��ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            //  [12/25/2008 sun][2009-04-02 Liao]
            string strHeat = dvBOFData.CurrentRow.Cells["HeatID"].Value.ToString();
            /******Modify By Huyunhai 2011-03-26*****/

                /******Modify End*******/
               
                    string strYesNo = MessageBox.Show("ȷ��¯��Ϊ:\"" + strHeat + "\"��ʵ����", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                    if (strYesNo == "Yes")
                    {
                        cmdConfirm.Parameters[0].ConstantValue = "S25";
                        cmdConfirm.Parameters[1].ConstantValue = strHeat;
                        cmdConfirm.Parameters[2].ConstantValue = strHeat;
                        cmdConfirm.Execute();
                    }

                    string iReturn = cmdConfirm.Command.Return.ToString();
                    if (iReturn == "0")
                    {
                        MessageBox.Show("ȷ�ϳɹ�");
                    }
                    else
                    {
                        MessageBox.Show("ȷ��ʧ��"+iReturn);
                    
                    }
                    //dsBOFData.LoadData();
              
        }

        private void dvBOFData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            CommDataMag.CommonMethed.SetCellColorByColumnName(dvBOFData, "HeatID", "Locked", "1");
        }

        private void dvBOFData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BOFHeatFinalDataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}