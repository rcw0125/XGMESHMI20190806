using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.IronLadleMag
{
    public partial class IronLadleTieMagFrm : DockContent, IMESForm
    {
        public IronLadleTieMagFrm()
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
      
        private string strCurSql = "";
        private object objShiftID = "";
        private object objTeamID = "";
        private string strSort = "";

        //�ؼ�����
        private void IronLadleTieMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-3);
            dtEnd.Value = DateTime.Now;

            cmbIronladleID.Items.Add("");
            for (int i = 0; i < dsIronLadleID.Tables[0].Rows.Count; i++)
            {
                cmbIronladleID.Items.Add(dsIronLadleID.Tables[0].Rows[i]["IronLadleID"]);
            }
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //������Ϣ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsTieInfo.Tables[0].NewRow();
                newrow["InPut_Time"] = DateTime.Now;
                newrow["IronLadleID"] = "";
                newrow["Refra_Produce"] = "";
                newrow["Refra_ID"] = "";
                newrow["Consumption"] = 0;
                newrow["Tie_Start_Time"] = DateTime.Now;
                newrow["Tie_End_Time"] = DateTime.Now;
                newrow["Doff_Mod_Time"] = DateTime.Now;
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsTieInfo.Tables[0].Rows.Add(newrow);

                bsTieInfo.MoveFirst();//
                while (((System.Data.DataRowView)(bsTieInfo.Current)).Row != newrow && bsTieInfo.Position != dsTieInfo.Tables[0].Rows.Count - 1)
                {
                    bsTieInfo.MoveNext();
                }
                IronLadleTieShowFrm frm = new IronLadleTieShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsTieInfo.Position, strSort, ref dsTieInfo);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸���Ϣ
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsTieInfo.Tables[0].Rows.Count > 0)
            {
                bsTieInfo.Position = e.RowIndex;
                IronLadleTieShowFrm frm = new IronLadleTieShowFrm();
                frm.ShowDialogEx(Adapter.Session, bsTieInfo.Position, strSort, ref dsTieInfo);
                GC.Collect();
            }
        }

        //ɾ����Ϣ
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsTieInfo.Position >= 0)
            {
                bsTieInfo.RemoveCurrent();
            }
            
        }

        //��Ϣ����
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvTieInfo.EndEdit();
            bsTieInfo.EndEdit();
            if (dsTieInfo.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                FormQueryString();
            }
            else
                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

        //��Ϣȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        //��ѯ
        private void FormQueryString()
        {
            DateTime dtS = Convert.ToDateTime(dtStart.Text.Trim());
            DateTime dtE = Convert.ToDateTime(dtEnd.Text.Trim() + " 23:59:59");
            strCurSql = " Input_Time between '" + dtS + "' and '" + dtE + "'";
            if (cmbIronladleID.Text != null && cmbIronladleID.Text != "")
            {
                strCurSql += " and IronLadleID = '" + cmbIronladleID.SelectedItem.ToString() + "'";
            }
            cmdTieInfo.Parameters[0].ConstantValue = strCurSql;
            dsTieInfo.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvTieInfo_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsTieInfo.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("�������ʵ��", dvTieInfo);
        }

        private void IronLadleTieMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvTieInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

    }
}