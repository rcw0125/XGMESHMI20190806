using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;



namespace QualityMag.QualityStandard
{
    public partial class SteelGradeGlobalMainten : DockContent, IMESForm
    {
        public SteelGradeGlobalMainten()
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

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //dsSteelGradeIndexRelation.LoadData();
            // bsSteelGradeIndexRelation.Current = null;
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //关闭窗体
        private void SteelGradeIndexRelationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {

            string strSteelGradeIndex = cmbSteelGradeIndex.Text.Trim();
            string strSteelGrade = txtSteelGrade.Text.Trim();
            if (strSteelGradeIndex == "")
            {
                if (strSteelGrade == "")
                    dsSteelGradeIndexRelation.SourceCondition = "";
                else
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGrade like '%" + strSteelGrade + "%'";
            }
            else
            {
                if (strSteelGrade == "")
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGradeIndex like '%" + strSteelGradeIndex + "%'";
                else
                    dsSteelGradeIndexRelation.SourceCondition = "SteelGradeIndex like '%" + strSteelGradeIndex + "%' and SteelGrade like '%" + strSteelGrade + "%'";
            }
        }


        private void dvSteelGradeIndexRelation_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //导出EXCEL
        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("炼钢记号钢种对照关系维护", dvSteelGradeIndexRelation);
        }

        //复制炼钢记号
        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (bsSteelGradeIndexRelation.Current != null && dvSteelGradeIndexRelation.SelectedRows.Count == 1)
            {
                AppSvrHMI.L3DataSet dsSend = new AppSvrHMI.L3DataSet();
                dsSend = (AppSvrHMI.L3DataSet)dsSteelGradeIndexRelation.Clone();
                int index = dsSteelGradeIndexRelation.Tables[0].Rows.IndexOf((bsSteelGradeIndexRelation.Current as System.Data.DataRowView).Row);
                dsSend.Tables[0].ImportRow(dsSteelGradeIndexRelation.Tables[0].Rows[index]);

                NewAndOldSteelGrade naosg = new NewAndOldSteelGrade();
                naosg.showDialogForSteel(Adapter.Session, dsSend);

                if (naosg.isCopy = false && naosg.newSteelGrade == "")
                    return;
                int iRot = -1;
                if (naosg.isCopy = true && naosg.newSteelGrade != "")
                {
                    cmdCopy.Parameters[0].ConstantValue = naosg.newSteelGrade;
                    cmdCopy.Parameters[1].ConstantValue = dsSend.Tables[0].Rows[0]["STEELGRADEINDEX"].ToString();
                    iRot = cmdCopy.Execute();
                }
                string returnFlag = "";
                if (naosg.isCopy = false)
                    return;
                if (cmdCopy.Command != null)
                {
                    returnFlag = cmdCopy.Command.Return.ToString();
                }
                else
                    return;

                if (iRot >= 0)    //调用成功
                {
                    //string strReasultShow = CommDataMag.CommonMethed.GetErrorDescByErrorCode(dsError, returnFlag);
                    if (returnFlag == "0")
                    {
                        MessageBox.Show("操作成功！", "提示");
                    }
                    else if (returnFlag == "-1")
                    {
                        MessageBox.Show("炼钢记号为空！", "提示");
                    }
                    else if (returnFlag == "-2")
                    {
                        MessageBox.Show("新的炼钢记号已经存在！", "提示");
                    }
                    else if (returnFlag == "-3")
                    {
                        MessageBox.Show("旧的炼钢记号不存在！", "提示");
                    }
                    else if (returnFlag == "-5")
                    {
                        MessageBox.Show("复制炼钢记号失败！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("操作失败！", "提示");
                    }
                }
            }
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            btnQuery_Click(sender, e);
        }

        private void SteelGradeGlobalMainten_Load(object sender, EventArgs e)
        {
            //加载炼钢记号
            for (int i = 0; i < dsSteelGradeIndex.Tables[0].Rows.Count; i++)
            {
                cmbSteelGradeIndex.Items.Add(dsSteelGradeIndex.Tables[0].Rows[i]["SteelGradeIndex"].ToString());
            }

            //
            //DataRow dr1 = dsFlag.Tables[0].NewRow();
            //DataRow dr2 = dsFlag.Tables[0].NewRow();
            DataTable dt = new DataTable();
            dsFlag.Tables.Add(dt);
            dsFlag.Tables[0].Columns.Add("USEFLAG");
            dsFlag.Tables[0].Columns.Add("USEFLAG_DES");
            dsFlag.Tables[0].Rows.Add(new string[] { "0", "在用" });
            dsFlag.Tables[0].Rows.Add(new string[] { "1", "禁用" });
            dsFlag.Tables[0].Rows.Add(new string[] { "", "未定义" });

            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataSource = dsFlag;
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DisplayMember = "Table1.USEFLAG_DES";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).ValueMember = "Table1.USEFLAG";
            ((DataGridViewComboBoxColumn)cmbUse_Flag).DataPropertyName = "Use_Flag";
        }

      



    }
}