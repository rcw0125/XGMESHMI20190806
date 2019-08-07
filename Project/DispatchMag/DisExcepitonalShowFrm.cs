using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DispatchMag
{
    public partial class DisExcepitonalShowFrm : Form
    {
        public DisExcepitonalShowFrm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialogEx(AppSvrIF.Session session, string strSort,int nPosition, ref AppSvrHMI.L3DataSet dsData)
        {
            Adapter.Session = session;
            SetDataSource();

            bsMain.DataSource = null;
            bsMain.DataSource = dsData;
            bsMain.DataMember = dsData.Tables[0].TableName;

            (bsMain.Current as System.Data.DataRowView).DataView.Sort = strSort;
            bsMain.Position = nPosition;
            
            return ShowDialog();
        }


        private void DisExcepitonalShowFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bsMain.EndEdit();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsMain.CancelEdit();
            this.Close();
        }

        private void cmbUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnitID.Text.ToString() == "")
            {
                cmbTeam.DataSource = null;
                return;
            }
            
            bsTeam.Filter = "pk_center = '" + cmbUnitID.SelectedValue.ToString() + "'";

            cmbTeam.DisplayMember = "team_name";
            cmbTeam.ValueMember = "PK_TEAM";
            cmbTeam.DataSource = bsTeam;
        }

        /// <summary>
        /// 获取NC对应编码
        /// </summary>
        private void SetDataSource()
        {
            /********************** 工 作 中 心 *************************/
            string strUnitIDSQL = "";
            strUnitIDSQL += " SELECT pk_center, center_name, center_code        ";
            strUnitIDSQL += "   FROM cbase_prod_center_infor                    ";
            strUnitIDSQL += "   WHERE SUBSTR (center_name, 1, 4) <= '1103'      ";
            strUnitIDSQL += "     AND SUBSTR (center_name, 1, 4) >= '1101'      ";
            strUnitIDSQL += "ORDER BY center_name                               ";

            dsUnitID.SourceMethod = strUnitIDSQL;
            /********************** 工 作 中 心 *************************/

            /**********************    班 次    *************************/
            string strShiftSQL = "";
            strShiftSQL += "  SELECT   pk_shift, shift_code, shift_name         ";
            strShiftSQL += "    FROM cbase_shift_infor                          ";
            strShiftSQL += "   WHERE LENGTH (shift_code) = 4                    ";
            strShiftSQL += "ORDER BY shift_code                                 ";
            dsShift.SourceMethod = strShiftSQL;
            /**********************    班 次    *************************/

            /**********************    班 别    *************************/
            string strTeamSQL = "";
            strTeamSQL += "  SELECT   pk_team, team_code, team_name, pk_center  ";
            strTeamSQL += "    FROM cbase_team_infor                            ";
            strTeamSQL += "   WHERE SUBSTR (team_code, 1, 4) <= '1103'          ";
            strTeamSQL += "     AND SUBSTR (team_code, 1, 4) >= '1101'          ";
            strTeamSQL += "ORDER BY team_code                                   ";
            dsTeam.SourceMethod = strTeamSQL;
            /**********************    班 别    *************************/
        }
    }
}