using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace EquipMag.LadleMag
{
    public partial class LadlePlanMagFrm : DockContent, IMESForm
    {
        public LadlePlanMagFrm()
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

        private LadleFoldShowFrm LadleFoldShow = new LadleFoldShowFrm();//折罐
        private LadlePourShowFrm LadlePourShow = new LadlePourShowFrm();//倒包
        private ChooseLadleShowFrm ChooseLadleShow = new ChooseLadleShowFrm();

        private string[,] strArrColor = new string[4, 2] 
              { { "01", CommDataMag.CommonData.Color_Code_Control },
                { "02", CommDataMag.CommonData.Color_Code_Yellow },
                { "03", CommDataMag.CommonData.Color_Code_Red },
                { "04", CommDataMag.CommonData.Color_Code_Green } };

        private AppSvrHMI.L3DataSet dsChooseLadle = new AppSvrHMI.L3DataSet();


        //控件加载
        private void LadlePlanMagFrm_Load(object sender, EventArgs e)
        {
            //string[,] strArrColor = 
            //  { { "01", CommDataMag.CommonData.Color_Code_Control },
            //    { "02", CommDataMag.CommonData.Color_Code_Yellow },
            //    { "03", CommDataMag.CommonData.Color_Code_Red },
            //    { "04", CommDataMag.CommonData.Color_Code_Green } };

            dsChooseLadle = (AppSvrHMI.L3DataSet)dsLadlePlan.Clone();

            tscmbBOFID.Items.Clear();
            tscmbCasterID.Items.Clear();
            for (int iBof = 0; iBof < dsBOFID.Tables[0].Rows.Count; iBof++)
            {
                tscmbBOFID.Items.Add(dsBOFID.Tables[0].Rows[iBof]["Code_Des"].ToString());
            }
            for (int iCast = 0; iCast < dsCasterID.Tables[0].Rows.Count; iCast++)
            {
                tscmbCasterID.Items.Add(dsCasterID.Tables[0].Rows[iCast]["Code_Des"].ToString());
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //信息保存
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        //信息取消
        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void tscmbBOFID_DropDownClosed(object sender, EventArgs e)
        {
            txtBOFID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsBOFID, tscmbBOFID.Text);
        }

        private void tscmbCasterID_DropDownClosed(object sender, EventArgs e)
        {
            txtCastID.Text = CommDataMag.CommonMethed.GetStrCodeByDesc(dsCasterID, tscmbCasterID.Text);
        }

        //折罐
        private void btnFold_Click(object sender, EventArgs e)
        {
            //DataSet dsFold = 
            //LadleFoldShow.ShowDialogEx(Adapter.Session);
        }

        //倒包
        private void btnPour_Click(object sender, EventArgs e)
        {
            //LadlePourShow.ShowDialogEx(Adapter.Session);
        }

        //指定钢包
        private void btnSpecify_Click(object sender, EventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            DataSet dsSpecify = (DataSet)(cmdSpecify.Parameters[0].Value);
            if (dsSpecify != null && dsSpecify.Tables[0].Rows.Count > 0)
            {
                if (!GetdsSpecifyEqualCount(dsSpecify))
                {
                    cmdSpecify.Execute();
                    int iRet = Convert.ToInt16(cmdSpecify.Command.Return);
                    if (iRet < 1)
                    {
                        MessageBox.Show("指定失败！", "提示", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("\" " + iRet + "\" 条计划指定成功！", "提示", MessageBoxButtons.OK);
                        dsLadlePlan.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("不能指定，可能存在同一钢包指定到不同钢包计划，请检查！", "提示！", MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("没有选中计划，或则被选中计划没有选择钢包！",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            dsLadlePlan.SourceMethod = "QueryUnProcessLadlePlan";
            dsLadlePlan.LoadData();
        }

        private void dvLadlePlan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //右键选择指定钢包
        private void btnChooseLadle_Click(object sender, EventArgs e)
        {
            dsChooseLadle.Tables[0].Clear();
            int idsPosition = dsLadlePlan.Tables[0].Rows.IndexOf(((System.Data.DataRowView)(bsLadlePlan.Current)).Row);
            dsChooseLadle.Tables[0].ImportRow(dsLadlePlan.Tables[0].Rows[idsPosition]);

            if (dsChooseLadle.Tables[0].Rows.Count != 1)
            {
                MessageBox.Show("无法指定！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ChooseLadleShow.ShowDialogEx(Adapter.Session, ref dsChooseLadle);

            if (dsChooseLadle.Tables[0].Rows[0]["LadleID"] == null || dsChooseLadle.Tables[0].Rows[0]["LadleID"].ToString() == "")
            {
                dsLadlePlan.Tables[0].Rows[idsPosition]["LadleID"] = null;
            }
            else
            {
                dsLadlePlan.Tables[0].Rows[idsPosition]["LadleID"] = dsChooseLadle.Tables[0].Rows[0]["LadleID"].ToString();
            }
        }

        //需要右键时
        private void dvLadlePlan_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            //未分配
            if (dvLadlePlan.Rows[bsLadlePlan.Position].Cells["Status"].Value.ToString()
                != CommDataMag.CommonData.CLADLE_PLAN_STATUS_UNDESIGN)
            {
                btnChooseLadle.Enabled = false;
            }
            else
            {
                btnChooseLadle.Enabled = true;
            }

            //执行
            if (dvLadlePlan.Rows[bsLadlePlan.Position].Cells["Status"].Value.ToString()
                != CommDataMag.CommonData.CLADLE_PLAN_STATUS_EXCUTING)
            {
                btnPour.Enabled = false;
                btnFold.Enabled = false;
            }
            else
            {
                btnPour.Enabled = true;
                btnFold.Enabled = true;
            }
        }

        //取消指定
        private void btnCancelSpecify_Click(object sender, EventArgs e)
        {
            dvLadlePlan.EndEdit();
            bsLadlePlan.EndEdit();

            DataSet dsCancel = (DataSet)(cmdCancel.Parameters[0].Value);

            if (dsCancel != null && dsCancel.Tables[0].Rows.Count > 0)
            {
                cmdCancel.Execute();

                int iRet = Convert.ToInt16(cmdCancel.Command.Return);
                if (iRet < 1)
                {
                    MessageBox.Show("取消指定失败！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("\" " + iRet + "\" 条计划取消指定成功 ",
                        "提示！", MessageBoxButtons.OK);
                    dsLadlePlan.LoadData();
                }
            }
            else
            {
                MessageBox.Show("没有选中计划，或则被选中计划不允许取消指定！",
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        //判断是否存在相同钢包的指定到不同计划计划
        private bool GetdsSpecifyEqualCount(DataSet dsSpecify)
        {
            string[] strArr = new string[dsSpecify.Tables[0].Rows.Count];
            for (int i = 0; i < dsSpecify.Tables[0].Rows.Count; i++)
            {
                strArr[i] = dsSpecify.Tables[0].Rows[i]["LadleID"].ToString();
            }
            if (CommDataMag.CommonMethed.GetEqualCount(strArr))
            {
                return true;
            }
            else { return false; }
        }

        //绘制颜色
        private void dvLadlePlan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            CommDataMag.CommonMethed.SetDataGridViewRowColor(dvLadlePlan, "STATUS", strArrColor);
        }
    }
}