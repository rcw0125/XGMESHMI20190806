using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;
//using AppSvrIf;
namespace PlanMag
{
    public partial class UpdateControl : DockContent, IMESForm
    {
        public UpdateControl()
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
        public void ShowDialog(AppSvrIF.Session session,string  heatid)
        {
            this.Adapter.Session = session;
            dsTapping.SourceCondition = "HeatID = '" + heatid + "'";
            this.ShowDialog();
            
        }

 

        private void UpdateControl_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsTapping.EndEdit();
            ////记录修改时间 暂时屏蔽
            //DateTime dt = DateTime.Now;
            //dsTapping.Tables[0].Rows[0]["PlanExecuteDate"] = dt;
            dsTapping.UpdateData();
            //dsTapping.SourceCondition = " casterid= '" + textBox2.Text + "' and treat_seq>='"+textBox3.Text+"' and (status= 11 or status= 12) order by treat_seq";
            dsTapping.LoadData();
          
            string check = MessageBox.Show("确认要修改计划时间么？", "提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check == "OK")
            {
                cmdchangecurheat.Execute();
                String curreturnFlag = cmdchangecurheat.Command.Return.ToString();
                if (curreturnFlag == "1")
                {
                   
                }
                else
                {
                    MessageBox.Show("修改本炉次计划时间不成功！", "提示");
                    return;
                }
                cmdChangePlanTime.Execute();
                String returnFlag = cmdChangePlanTime.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("修改计划时间成功！", "提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改下一计划时间不成功！", "提示");
                }
            }
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string str = textBox1.Text;
        //    label1.Text=GetSteelGradeBySteelGradeIndex(str);
            
        //}
        //public string GetSteelGradeBySteelGradeIndex(string strSteelGradeIndex)
        //{
        //    try
        //    {
        //        if (strSteelGradeIndex == "")
        //            return "";

        //        object Obj = new object();
        //        string strUri = "XGMESLogic\\PlanMag\\CPlan_Tapping\\";
        //        string strObjUri = strUri + strSteelGradeIndex;
        //        Adapter.Session.Get(strObjUri, "Aim_Time_IronPrepared", ref Obj);
           
        //        return Obj.ToString();
        //    }
        //    catch
        //    {

        //        return "";
        //    }
        //}

        //public void SetSteelGradeBySteelGradeIndex(string strSteelGradeIndex)
        //{
        //    try
        //    {
        //        if (strSteelGradeIndex == "")
        //            return ;

        //        object Obj = new object();
        //        string strUri = "XGMESLogic\\PlanMag\\CPlan_Tapping\\";
        //        string strObjUri = strUri + strSteelGradeIndex;
        //        Adapter.Session.Set(strObjUri, "Aim_Time_IronPrepared", "2015-11-6 6:37:26");

                
        //    }
        //    catch
        //    {

        //        return ;
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string str = textBox1.Text;
        //    SetSteelGradeBySteelGradeIndex(str);
        //}
    }
}