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
        SmoothBlock = 1,	//滑块
        HurryWaterGap = 2,		//水口
        BigWaterGap = 3,	//大包水口
    }

    public partial class CCMRefraFrm : Form
    {
        public CCMRefraFrm()
        {
            InitializeComponent();
        }

        public EquipType MainEquipType = EquipType.SmoothBlock;

        private string strStrandNo = "1";//流号

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
                MessageBox.Show("当前不允许更换耐材，原因是没有找到相应的铸机！", "提示");
                return DialogResult.No;
            }

            Adapter.set_URIParameters("CCMID", UnitID);
            txtCCMID.Text = UnitID;

            Adapter.Session = session;
            Adapter.RefreshDataBindings();

            if (dbxTreatNO.Text.Trim() == "")
            {
                MessageBox.Show("当前不允许更换耐材，原因是没有找到相应的处理号！", "提示");
                return DialogResult.No;
            }
            object objHeatID = null;
            Adapter.Session.Get(@"XGMESLogic\CCMMag\CCCM_Base_Data\" + dbxTreatNO.Text.Trim(), "HeatID", ref objHeatID);
            if (objHeatID != null)
                txtHeatID.Text = objHeatID.ToString();
            else
            {
                MessageBox.Show("当前不允许更换耐材，原因是没有找到相应的炉号！", "提示");
                return DialogResult.No;
            }

            return ShowDialog();
        }

        //界面加载
        private void CCMRefraFrm_Load(object sender, EventArgs e)
        {
            rbtnStrandNo1.Checked = true;

            switch (MainEquipType)
            {
                case EquipType.SmoothBlock:
                    this.Text += "--快换滑块";
                    //耐材厂家
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsSmoothBlockFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //下线原因
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsSmoothBlockReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
                case EquipType.HurryWaterGap:
                    this.Text += "--中包水口";
                    //耐材厂家
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsHurryGapFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //下线原因
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsHurryGapReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
                case EquipType.BigWaterGap:
                    this.Text += "--大包水口";
                    //耐材厂家
                    cmbFactory.DataSource = null;
                    cmbFactory.DataSource = bsBigGapFac;
                    cmbFactory.DisplayMember = "MatFactory";
                    cmbFactory.ValueMember = "MatFactory";
                    //下线原因
                    cmbReason.DataSource = null;
                    cmbReason.DataSource = bsBigGapReason;
                    cmbReason.DisplayMember = "Code_Des";
                    cmbReason.ValueMember = "Code";
                    break;
            }
        }

        //选择流号
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

        //确认
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
                        //炉号
                        newrow1["HeatID"] = txtHeatID.Text;
                        //铸机号
                        newrow1["CCMID"] = txtCCMID.Text;
                        //流号
                        newrow1["StrandNo"] = strStrandNo;
                        //耐材厂家
                        newrow1["Factory"] = cmbFactory.SelectedValue.ToString();
                        //规格
                        newrow1["Block_Size"] = txtSize.Text;
                        //下线原因
                        newrow1["Reason"] = cmbReason.SelectedValue.ToString();
                        //耐材类型
                        newrow1["EquipmentType"] = 1;

                        dsSmoothBlock.Tables[0].Rows.Add(newrow1);
                        dsSmoothBlock.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsSmoothBlock;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("更换快换滑块成功！", "提示");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("更换快换滑块失败！", "提示");
                            bSuccess = false;
                        }
                        break;

                    case EquipType.HurryWaterGap:

                        dsHurryGap.Tables[0].Rows.Clear();
                        DataRow newrow2 = dsHurryGap.Tables[0].NewRow();
                        //炉号
                        newrow2["HeatID"] = txtHeatID.Text;
                        //铸机号
                        newrow2["CCMID"] = txtCCMID.Text;
                        //流号
                        newrow2["StrandNo"] = strStrandNo;
                        //耐材厂家
                        newrow2["Factory"] = cmbFactory.SelectedValue.ToString();
                        //材质
                        newrow2["MatType"] = txtSize.Text;
                        //下线原因
                        newrow2["Reason"] = cmbReason.SelectedValue.ToString();
                        //耐材类型
                        newrow2["EquipmentType"] = 2;

                        dsHurryGap.Tables[0].Rows.Add(newrow2);
                        dsHurryGap.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsHurryGap;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("更换中包水口成功！", "提示");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("更换中包水口失败！", "提示");
                            bSuccess = false;
                        }
                        break;

                    case EquipType.BigWaterGap:

                        dsBigGap.Tables[0].Rows.Clear();
                        DataRow newrow3 = dsBigGap.Tables[0].NewRow();
                        //炉号
                        newrow3["HeatID"] = txtHeatID.Text;
                        //铸机号
                        newrow3["CCMID"] = txtCCMID.Text;
                        //流号
                        newrow3["StrandNo"] = strStrandNo;
                        //耐材厂家
                        newrow3["Factory"] = cmbFactory.SelectedValue.ToString();
                        //材质
                        newrow3["MatType"] = txtSize.Text;
                        //下线原因
                        newrow3["Reason"] = cmbReason.SelectedValue.ToString();
                        //耐材类型
                        newrow3["EquipmentType"] = 3;

                        dsBigGap.Tables[0].Rows.Add(newrow3);
                        dsBigGap.AcceptChanges();

                        l3cmdpdsRefra.SourceObject = dsBigGap;
                        l3cmdpdsRefra.SourceProperty = "L3DataTable";

                        if (cmdRefra.Execute() == 0 && Convert.ToBoolean(cmdRefra.Command.Return))
                        {
                            MessageBox.Show("更换大包水口成功！", "提示");
                            bSuccess = true;
                        }
                        else
                        {
                            MessageBox.Show("更换大包水口失败！", "提示");
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

        //取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  