using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EDoor.WinFormsUI.Docking;
using HMIBase;

namespace BaseDataMag
{
    public partial class ShiftTeamMagFrm : DockContent, IMESForm
    {
        public ShiftTeamMagFrm()
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

    
        private void btnSet_Click(object sender, EventArgs e)
        {
            int iRowIndex = bsShiftTeamOrder.Position;

            string strShiftID =dvShiftTeamOrder.Rows[iRowIndex].Cells[shiftIDDataGridViewTextBoxColumn.Index].Value.ToString();
            string strTeamID = dvShiftTeamOrder.Rows[iRowIndex].Cells[teamIDDataGridViewTextBoxColumn.Index].Value.ToString();
            string strOrderIndex = dvShiftTeamOrder.Rows[iRowIndex].Cells[orderIndexDataGridViewTextBoxColumn.Index].Value.ToString();

            Adapter.Session.Set("XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101", "ShiftID", strShiftID);
            Adapter.Session.Set("XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101", "TeamID", strTeamID);
            Adapter.Session.Set("XGMESLogic\\ShiftTeamMag\\CCurrentShiftInfo\\0101", "CurrentID", strOrderIndex);
        }

        private void ShiftTeamMagFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }

    }
}