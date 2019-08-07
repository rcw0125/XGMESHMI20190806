using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HMIBase;
using EDoor.WinFormsUI.Docking;

namespace UnitMag.DeSMag
{
    public partial class LanceMagFrm : DockContent, IMESForm
    {
        public LanceMagFrm()
        {     
            InitializeComponent();
            
        }

        #region IMESForm 成员

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

        /***********Modify Begin At 2011-02-22 By Huyunhai*************/
        private void displayData30Rows()
        {
        if (dsLance.Tables[0].Rows.Count>30)
        {
            for (int i=0;i<dsLance.Tables[0].Rows.Count-30;i++)
            {
                dsLance.Tables[0].Rows.RemoveAt(30);
            }
            dsLance.AcceptChanges();
            
        }
        }
        /*****Modify END******/

        private void LanceMagFrm_Load(object sender, EventArgs e)
        {
           displayData30Rows();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewLanceShow frm = new NewLanceShow();
            frm.ShowDialogEx(Adapter.Session);
        }

        //修改状态
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            //try
            //{

                dvLance.EndEdit();
                bsLance.EndEdit();
                int checkCount = 0;
                int tempt = -1;
                string LanceNo1 = "";
                string Status1 = "";
                for (int i = 0; i < dsLance.Tables[0].Rows.Count; i++)
                {
                    if (dvLance.Rows[i].Cells[0].Value != null && dvLance.Rows[i].Cells[0].Value.ToString() == "1")
                    {
                        checkCount++;
                        tempt = i;
                        //LanceNo = dsLance.Tables[0].Rows[tempt]["LanceNo"].ToString();
                        //Status = dsLance.Tables[0].Rows[tempt]["Status"].ToString();
                        LanceNo1 = dvLance["lanceNoDataGridViewTextBoxColumn", tempt].EditedFormattedValue.ToString();
                        //Status1 = dvLance["statusDataGridViewTextBoxColumn", tempt].Value.ToString();
                        Status1 = dsLance.Tables[0].Select("LanceNo='" + LanceNo1 + "'")[0]["Status"].ToString();
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else if(tempt!=-1)
                {
                    //string LanceNo = dsLance.Tables[0].Select("CheckFlag = '1'")[0]["LanceNo"].ToString();
                    //string Status = dsLance.Tables[0].Select("CheckFlag = '1'")[0]["Status"].ToString();
                    string LanceNo = dsLance.Tables[0].Rows[tempt]["LanceNo"].ToString();
                    string Status = dsLance.Tables[0].Rows[tempt]["Status"].ToString();
                    LanceNo = LanceNo1.ToString();
                    Status = Status1.ToString();
                    LanceChangeStatusShow frm = new LanceChangeStatusShow();
                    frm.ShowDialogEx(Adapter.Session, LanceNo, Status);
                }
            //}
            //catch { }
            dsLance.LoadData();
        }

        //修改枪龄
        private void btnChangeAge_Click(object sender, EventArgs e)
        {
            try
            {

                dvLance.EndEdit();
                bsLance.EndEdit();
                int checkCount = 0;
                for (int i = 0; i < dsLance.Tables[0].Rows.Count; i++)
                {
                    if (dvLance.Rows[i].Cells[0].Value != null && dvLance.Rows[i].Cells[0].Value.ToString() == "true")
                    {
                        checkCount++;
                    }
                }
                if (checkCount != 1)
                {
                    MessageBox.Show("只能选一条数据", "提示");
                }
                else
                {
                    string LanceNo = dsLance.Tables[0].Select("CheckFlag = '1'")[0]["LanceNo"].ToString();
                    string Age = dsLance.Tables[0].Select("CheckFlag = '1'")[0]["LanceAge"].ToString();
                    LanceChangeAgeShow frm = new LanceChangeAgeShow();
                    frm.ShowDialogEx(Adapter.Session, LanceNo, Age);
                }
            }
            catch { }
            dsLance.LoadData();
        }

        //确定
        private void tsbtnConfirm_Click(object sender, EventArgs e)
        {
            dvLance.EndEdit();
            bsLance.EndEdit();
            if (dsLance.UpdateData())
            {
                MessageBox.Show("修改成功！", "提示");
                dsLance.LoadData();
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
                dsLance.LoadData();
            }
        }

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnCancel_Click(object sender, EventArgs e)
        {
            dsLance.LoadData();
        }

        //喷枪数据查询
        private void btnLanceQuery_Click(object sender, EventArgs e)
        {
            LanceQueryFrm frm = new LanceQueryFrm();
            frm.ShowDialogEx(Adapter.Session);
        }

        private void btnIntoEXL_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("喷枪信息", dvLance);
        }

        private void LanceMagFrm_Shown(object sender, EventArgs e)
        {
            //displayData30Rows();
        }

        private void tlDeSLanceDataAdd_Click(object sender, EventArgs e)
        {
            NewLanceDataShow frm = new NewLanceDataShow();
            frm.ShowDialogEx(Adapter.Session);
        }

    }
}