using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StoreMag.ScrapStore
{
    public partial class StainlessScrapOutStoreShowFrm : Form
    {
        public StainlessScrapOutStoreShowFrm()
        {
            InitializeComponent();
        }

        public void ShowDialogEx(AppSvrIF.Session session)
        {
            Adapter.Session = session;

            this.ShowDialog();
        }

        //ȷ��
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /******Modify By Huyunhai 2011-03-24*******/
            //DataRow dr = dsSend.Tables[0].NewRow();

            DataTable dt = new DataTable();
            dsSend.Tables.Add(dt);
            dsSend.Tables[0].Columns.Add("MATERIAL_CODE");//MATERIAL_CODE
            dsSend.Tables[0].Columns.Add("AMOUNT");
            dsSend.Tables[0].Columns.Add("MATERIAL");
            dsSend.Tables[0].Columns.Add("SCRAP_SLOT_ID");
            if (dvSteel.Rows.Count > 0)
            {
                for (int i = 0; i < dvSteel.Rows.Count; i++)
                {
                    if (dvSteel.Rows[i].Cells["ColName"].Value == null)
                        break;
                    dsSend.Tables[0].Rows.Add(new string[] { dvSteel.Rows[i].Cells["ColName"].Value.ToString(), dvSteel.Rows[i].Cells["colWeight"].Value.ToString(), "ScrapGroupName", "" });//�ϸ���

                }
            }

            if (dvIron.Rows.Count > 0)
            {
                for (int i = 0; i < dvIron.Rows.Count; i++)
                {
                    if (dvIron.Rows[i].Cells["Column3"].Value == null)
                        break;
                    dsSend.Tables[0].Rows.Add(new string[] { dvIron.Rows[i].Cells["Column3"].Value.ToString(), dvIron.Rows[i].Cells["Column4"].Value.ToString(), "PigIronGroupName", "" });//������

                }
            }
            dsSend.AcceptChanges();



            /*******Modify End********/

            dsScrapOutStoreConfirm.Tables[0].Clear();
            string check = MessageBox.Show("ȷ�ϳ��⣿", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
            if (check != "OK")
                this.Dispose();

            try
            {
                if (float.Parse(txtSTAmount.Text.Trim()) > 20)
                {
                    check = MessageBox.Show("��������������20�֣�ȷ�ϳ��⣿", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                    if (check != "OK")
                        this.Dispose();
                }
                if (float.Parse(txtFGAmount.Text.Trim()) >= 20)
                {
                    check = MessageBox.Show("�ϸֳ���������20�֣�ȷ�ϳ��⣿", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString();
                    if (check != "OK")
                        this.Dispose();
                }
                //����
                DataRow newrowST = dsScrapOutStoreConfirm.Tables[0].NewRow();
                newrowST["MaterialType"] = "CScrap_Data";
                newrowST["MaterialID"] = "PigIron";
                newrowST["Amount"] = Math.Round(float.Parse(txtSTAmount.Text.Trim()), 3); ��//����������

                newrowST["StoreAreaID"] = "S84A02";
                newrowST["Scrap_Slot_ID"] = txtScrapSlotID.Text.Trim().ToString();
                newrowST["Net_Weight"] = Math.Round(float.Parse(txtNetWeight.Text.Trim()), 3);
                newrowST["Gross_Weight"] = Math.Round(float.Parse(txtGrossWeight.Text.Trim()), 3);
                newrowST["Tare_Weight"] = Math.Round(float.Parse(txtTareWeight.Text.Trim()), 3);
                dsScrapOutStoreConfirm.Tables[0].Rows.Add(newrowST);
                //�ϸ�
                DataRow newrowFG = dsScrapOutStoreConfirm.Tables[0].NewRow();
                newrowFG["MaterialType"] = "CScrap_Data";
                newrowFG["MaterialID"] = "Scrap";
                newrowFG["Amount"] = Math.Round(float.Parse(txtFGAmount.Text.Trim()), 3);   //�ϸֳ�����

                newrowFG["StoreAreaID"] = "S84A01";
                newrowFG["Scrap_Slot_ID"] = txtScrapSlotID.Text.Trim().ToString();                               //�ϸֶ���
                newrowFG["Net_Weight"] = Math.Round(float.Parse(txtNetWeight.Text.Trim()), 3);          //����
                newrowFG["Gross_Weight"] = Math.Round(float.Parse(txtGrossWeight.Text.Trim()), 3); //ë��
                newrowFG["Tare_Weight"] = Math.Round(float.Parse(txtTareWeight.Text.Trim()), 3);      //Ƥ��
                dsScrapOutStoreConfirm.Tables[0].Rows.Add(newrowFG);
                cmdScrapOutStore.Execute();

                string returnFlag = cmdScrapOutStore.Command.Return.ToString();
                if (returnFlag == "0")
                {
                    MessageBox.Show("���ⲻ�ɹ���", "��ʾ");
                    this.Close();
                }
                else
                {
                    cmdSteelIron.Execute();
                    string flag = cmdSteelIron.Command.Return.ToString();
                    if (flag == "0")
                        MessageBox.Show("���⡢�ϸ���������ɹ���", "��ʾ");
                    else
                        MessageBox.Show("�ϸ���������ʧ�ܣ�", "��ʾ");
                    this.Close();
                }
            }
            catch { }

        }

        //ȡ��
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //����
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newrow = dsScrapOutStoreConfirm.Tables[0].NewRow();
            newrow["MaterialType"] = "CScrap_Data";
            dsScrapOutStoreConfirm.Tables[0].Rows.Add(newrow);
            bsScrapOutStore.MoveLast();
        }

        private void StainlessScrapOutStoreShowFrm_Load(object sender, EventArgs e)
        {
            txtSTAmount.Text = "0";
            txtFGAmount.Text = "0";
            txtNetWeight.Text = "0";
            txtGrossWeight.Text = "0";
            txtTareWeight.Text = "0";
            btnConfirm.Enabled = false;
            txtScrapSlotID.TextChanged += new EventHandler(pxControls_TextChanged);
        }

        private void StainlessScrapOutStoreShowFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CommDataMag.CommonMethed.FlushMemory();
        }
        private void pxControls_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = CommDataMag.CommonMethed.GetDataValidError(sender, errorProvider1);
        }

        /*****Modfiy By Huyunhai 2011-3-24******/

        //�����ϸ�
        private void btnAddSteel_Click(object sender, EventArgs e)
        {
            dvSteel.Rows.Add();
        }
        //ɾ���ϸ�
        private void btnDeleteSteel_Click(object sender, EventArgs e)
        {
            if (dvSteel.CurrentRow == null)
                return;
            dvSteel.Rows.Remove((DataGridViewRow)dvSteel.CurrentRow);
        }
        //��������
        private void btnAddIron_Click(object sender, EventArgs e)
        {
            dvIron.Rows.Add();
        }
        //ɾ������
        private void btnDeleteIron_Click(object sender, EventArgs e)
        {
            if (dvIron.CurrentRow == null)
                return;
            dvIron.Rows.Remove((DataGridViewRow)dvIron.CurrentRow);
        }

        //��������
        private void dvSteel_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvSteel.Rows.Count == 0)
                return;
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                try
                {
                    float tempt = 0;
                    for (int i = 0; i < dvSteel.Rows.Count; i++)
                    {
                        if (dvSteel.Rows[i].Cells["colWeight"].Value == null)
                            continue;

                        tempt += float.Parse(dvSteel.Rows[i].Cells["colWeight"].Value.ToString());
                    }
                    txtFGAmount.Text = tempt.ToString();
                }
                catch { }
            }
        }

        //�����м� gridView
        private void dataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView ss = (DataGridView)sender;
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X - 10, e.RowBounds.Location.Y,
                ss.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                ss.RowHeadersDefaultCellStyle.Font, rectangle,
                ss.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dvSteel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        private void dvIron_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewRowPostPaint(sender, e);
        }

        //��������
        private void dvIron_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvIron.Rows.Count == 0)
                return;
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                try
                {
                    float tempt = 0;
                    for (int i = 0; i < dvIron.Rows.Count; i++)
                    {
                        if (dvIron.Rows[i].Cells["Column4"].Value == null)
                            continue;
                        tempt += float.Parse(dvIron.Rows[i].Cells["Column4"].Value.ToString());
                    }
                    txtSTAmount.Text = tempt.ToString();
                }
                catch { }
            }
        }


        /****Modify END***/
    }
}