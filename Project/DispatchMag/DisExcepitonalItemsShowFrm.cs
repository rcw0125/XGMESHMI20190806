using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class DisExcepitonalItemsShowFrm : Form
    {
        public DisExcepitonalItemsShowFrm()
        {
            InitializeComponent();
        }

        private string strIDObject = "";//����Ϣ����
        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort, int nPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            if (dsData == null || dsData.Tables[0].Rows.Count < 1)
                return DialogResult.None;

            Adapter.Session = session;
            strIDObject = dsData.Tables[0].Rows[0]["IDObject"].ToString();
            if (strIDObject == "")
                return DialogResult.None;

            SetDataSource();

            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            (bsMain.Current as System.Data.DataRowView).DataView.Sort = strSort;
            bsMain.Position = nPosition;


            return ShowDialog();
        }

        private void DisExcepitonalItemsShowFrm_Load(object sender, EventArgs e)
        {
           

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            if (Convert.ToDateTime(dtStartTime.Text) > Convert.ToDateTime(dtEndTime.Text))
            {
                MessageBox.Show("��ʼʱ�̱Ƚ���ʱ����", "��ʾ", MessageBoxButtons.OK);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbUnitID.Text.ToString() == "")
            //{
            //    cmbTeam.DataSource = null;
            //    return;
            //}

            //bsTeam.Filter = "pk_center = '" + cmbUnitID.SelectedValue.ToString() + "'";

            //cmbTeam.DisplayMember = "team_name";
            //cmbTeam.ValueMember = "PK_TEAM";
            //cmbTeam.DataSource = bsTeam;
        }

        /// <summary>
        /// ��ȡNC��Ӧ����
        /// </summary>
        private void SetDataSource()
        {
            /********************** �� �� �� �� *************************/
            string strUnitIDSQL = "";
            strUnitIDSQL += " SELECT pk_center, center_name, center_code        ";
            strUnitIDSQL += "   FROM cbase_prod_center_infor                    ";
            strUnitIDSQL += "   WHERE SUBSTR (center_name, 1, 4) <= '1103'      ";
            strUnitIDSQL += "     AND SUBSTR (center_name, 1, 4) >= '1101'      ";
            strUnitIDSQL += "ORDER BY center_name                               ";

            dsUnitID.SourceMethod = strUnitIDSQL;
            /********************** �� �� �� �� *************************/
            string strUnitID = strIDObject.Substring(10, 20);
            string strExceptionCode = GetStrCodeByDesc(strUnitID);

            /********************** �� �� �� �� *************************/
            string strItemsSql = "";
            strItemsSql += "SELECT pk_exception, exception_code, exception_name ";
            strItemsSql += "  FROM cbase_excep_infor                            ";
            strItemsSql += " WHERE LENGTH (exception_code) = 6                  ";
            strItemsSql += "   AND SUBSTR (exception_code, 1, 4) = '" + strExceptionCode + "' order by exception_code";
            // strItemsSql += "   AND SUBSTR (exception_code, 1, 4) >= '1101'      ";

            dsItems.SourceMethod = strItemsSql;
            /********************** �� �� �� �� *************************/
            // bsItems.Filter = "EXCEPTION_CODE like '" + strExceptionCode + "'";
            //�����쳣����Դ�����ݹ������ģ�

        }

        private string GetStrCodeByDesc(string strUnitID)
        {
            try
            {
                string strID = "";
                string strCondition = " PK_CENTER = '" + strUnitID + "'";
                DataRow[] DataRowTempTotal = dsUnitID.Tables[0].Select(strCondition);
                foreach (DataRow DataRowTemp in DataRowTempTotal)
                {
                    strID = DataRowTemp["CENTER_NAME"].ToString();
                }
                if (strID.Length != 6)
                    return "";
                return strID.Substring(0,4);
            }
            catch { return ""; }
        }

    }
}