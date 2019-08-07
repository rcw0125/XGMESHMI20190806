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
    public partial class IronLadleUseMagFrm : DockContent, IMESForm
    {
        public IronLadleUseMagFrm()
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
        
        private void IronLadleUseMagFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now.AddDays(-3);
            dtEnd.Value = DateTime.Now;

            cmbIronladleID.Items.Add("");
            for (int i = 0; i < dsIronLadleID.Tables[0].Rows.Count; i++)
            {
                cmbIronladleID.Items.Add(dsIronLadleID.Tables[0].Rows[i]["IronLadleID"]);
            }
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "ShiftID", ref objShiftID);
                Adapter.Session.Get(CommDataMag.CommonData.CCURRENT_SHIFT_INFO_OBJ, "TeamID", ref objTeamID);
                //���һ�����ݣ�����Ӧ���ݽ������
                DataRow newrow = dsUseInfo.Tables[0].NewRow();
                newrow["Input_Time"] = DateTime.Now;
                newrow["IronLadleID"] = "";
                newrow["Check_Time"] = DateTime.Now;
                newrow["IronLadle_Age"] = 0;
                newrow["Wall_TEMP"] = 0;
                newrow["Bottom_TEMP"] = 0;
                newrow["Stop_Reason"] = "";
                if (objShiftID != null && objTeamID != null)
                {
                    newrow["TeamID"] = objTeamID.ToString();
                    newrow["ShiftID"] = objShiftID.ToString();
                }
                newrow["Operator"] = Adapter.Session.User;
                newrow["Note"] = "";

                dsUseInfo.Tables[0].Rows.Add(newrow);

                bsUseInfo.MoveFirst();//����ƶ������һ��
                while (((System.Data.DataRowView)(bsUseInfo.Current)).Row != newrow && bsUseInfo.Position != dsUseInfo.Tables[0].Rows.Count - 1)
                {
                    bsUseInfo.MoveNext();
                }
                IronLadleUseShowFrm Frm = new IronLadleUseShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsUseInfo.Position, strSort, ref dsUseInfo);
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "�쳣", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //�޸�
        private void dvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && dsUseInfo.Tables[0].Rows.Count > 0)
            {
                bsUseInfo.Position = e.RowIndex;
                IronLadleUseShowFrm Frm = new IronLadleUseShowFrm();
                Frm.ShowDialogEx(Adapter.Session, bsUseInfo.Position, strSort, ref dsUseInfo);
                GC.Collect();
            }
        }

        //ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bsUseInfo.Position >= 0)
            {
                bsUseInfo.RemoveCurrent();
            }
            
        }

        //�˳�
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            dvUseInfo.EndEdit();
            bsUseInfo.EndEdit();
            if (dsUseInfo.UpdateData())
            {
                MessageBox.Show("�����ɹ���", "��ʾ");
                FormQueryString();
            }
            else
                MessageBox.Show("����ʧ�ܣ�", "��ʾ");
        }

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
            
            cmdUseInfo.Parameters[0].ConstantValue = strCurSql;
            dsUseInfo.LoadData();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FormQueryString();
        }

        private void dvUseInfo_Sorted(object sender, EventArgs e)
        {
            try
            {
                strSort = ((System.Data.DataRowView)(bsUseInfo.Current)).DataView.Sort.ToString();
            }
            catch { }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("����ʹ��ʵ��", dvUseInfo);
        }

        private void IronLadleUseMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        private void dvUseInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}