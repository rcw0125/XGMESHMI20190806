using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnergyMag
{
    public partial class EnergyDataAddModFrm : Form
    {
        public EnergyDataAddModFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新增数据标志
        /// </summary>
        private bool bAddFlag = true;
        public DialogResult ShowDialogEx(AppSvrIF.Session session, int nPosition, string strSort, ref AppSvrHMI.L3DataSet dsData)
        {
            try
            {
                Adapter.Session = session;

                bsMain.DataSource = null;
                bsMain.DataSource = dsData;
                bsMain.DataMember = dsData.Tables[0].TableName;

                ((System.Data.DataRowView)(bsMain.Current)).DataView.Sort = strSort;
                bsMain.Position = nPosition;

                //判断当前数据是否为新增数据    检查主键是否生成
                if (((System.Data.DataRowView)(bsMain.Current)).Row["ObjectID"].ToString() != "")
                {
                    dtTime.Enabled = false;
                    cmbTagName.Enabled = false;
                    bAddFlag = false;
                }

                return ShowDialog();
            }
            catch { return DialogResult.None; }
        }

        private void EnergyDataAddModFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cmbTagName.Text == "")
            {
                MessageBox.Show("请选择标签名!", "提示");
                return;
            }
            if (txtTagValue.Text == "")
            {
                MessageBox.Show("请输入正确的表数据!", "提示");
                return;
            }
            if (bAddFlag)
            {
                string strObjectID = dtTime.Value.ToString("yyyyMMdd") + cmbTagName.SelectedValue.ToString();
                object objTagName = null;
                if (Adapter.Session.Get("XGMESLogic\\EnergyMag\\CEnergyConsumption\\" + strObjectID, "TagName", ref objTagName) >= 0)
                {
                    MessageBox.Show(dtTime.Value.ToString("yyyy-MM-dd") + "已存在该标签名!", "提示");
                    return;
                }
            }
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }
    }
}