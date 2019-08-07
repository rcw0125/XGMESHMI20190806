using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace DispatchMag
{
    public partial class DisExceptionalQueryFrm : DockContent, IMESForm
    {
        public DisExceptionalQueryFrm()
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

        private void DisExceptionalQueryFrm_Load(object sender, EventArgs e)
        {
            dtStart.Value = DateTime.Now;
            dtEnd.Value = DateTime.Now;

            /********************** 工 作 中 心 *************************/
            string strUnitIDSQL = "";
            strUnitIDSQL += " SELECT pk_center, center_name, center_code        ";
            strUnitIDSQL += "   FROM cbase_prod_center_infor                    ";
            strUnitIDSQL += "   WHERE SUBSTR (center_name, 1, 4) <= '1103'      ";
            strUnitIDSQL += "     AND SUBSTR (center_name, 1, 4) >= '1101'      ";
            strUnitIDSQL += "ORDER BY center_name                               ";

            dsUnitID.SourceMethod = strUnitIDSQL;

            cmbUnitID.Items.Clear();
            cmbUnitID.Items.Add("");
            if (dsUnitID.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dsUnitID.Tables[0].Rows.Count; i++)
                    cmbUnitID.Items.Add(dsUnitID.Tables[0].Rows[i]["center_code"].ToString());
            }
            /********************** 工 作 中 心 *************************/

            /**********************    班 次    *************************/
            string strShiftSQL = "";
            strShiftSQL += "  SELECT   pk_shift, shift_code, shift_name         ";
            strShiftSQL += "    FROM cbase_shift_infor                          ";
            strShiftSQL += "   WHERE LENGTH (shift_code) = 4                    ";
            strShiftSQL += "ORDER BY shift_code                                 ";
            dsShiftNC.SourceMethod = strShiftSQL;
            /**********************    班 次    *************************/

            cmbShift.Items.Clear();
            cmbShift.Items.Add("");
            for (int j = 0; j < dsShiftNC.Tables[0].Rows.Count; j++)
                cmbShift.Items.Add(dsShiftNC.Tables[0].Rows[j]["shift_name"].ToString());

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSQL = "";
            dsExceptional.SourceMethod = strSQL;

            strSQL += "SELECT   a.createdate, c.center_code AS unitid, d.shift_name AS shift,           ";
            strSQL += "         e.team_name AS team, a.OPERATOR, f.exception_name AS items,             ";
            strSQL += "         b.createtime, b.begintime, b.endtime, b.timespan, b.note                ";
            strSQL += "    FROM cdisp_exceptional a,                                                    ";
            strSQL += "         cdisp_exceptional_items b,                                              ";
            strSQL += "         cbase_prod_center_infor c,                                              ";
            strSQL += "         cbase_shift_infor d,                                                    ";
            strSQL += "         cbase_team_infor e,                                                     ";
            strSQL += "         cbase_excep_infor f                                                     ";
            strSQL += "   WHERE a.createdate BETWEEN '" + dtStart.Text.Trim() + "' AND '" + dtEnd.Text.Trim() + "' ";
            strSQL += "     AND a.idobject = b.idobject(+)                                              ";
            strSQL += "     AND a.unitid = c.pk_center                                                  ";
            strSQL += "     AND a.shift = d.pk_shift                                                    ";
            strSQL += "     AND a.team = e.pk_team                                                      ";
            strSQL += "     AND b.items = f.pk_exception                                                ";

            if (cmbUnitID.Text.Trim() != "")
                strSQL += "     AND c.center_code = '" + cmbUnitID.Text.Trim() + "'                     ";
            if (cmbShift.Text.Trim() != "")
                strSQL += "     AND d.shift_name = '" + cmbShift.Text.Trim() + "'                       ";

            strSQL += "ORDER BY a.createdate, a.shift, a.unitid, b.createtime                           ";

            dsExceptional.SourceMethod = strSQL;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            CommDataMag.CommonMethed.PutIntoExcel("设备异常信息", dvExceptional);
        }

        private void dvExceptional_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DisExceptionalQueryFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}