﻿using carInsuranceInit.control;
using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInsuranceInit.gui
{
    public partial class FrmSedanInjuryTime : Form
    {
        private CarIControl cic;
        SedanInjuryTime sit;
        int colRow = 0, colCapital = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanCapitalId = 5, colDel=6;
        int colCnt = 7;
        private void initConfig()
        {
            cic = new CarIControl();
            sit = new SedanInjuryTime();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanInjuryTime()
        {
            InitializeComponent();
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectSedanInjuryTime();

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colCapital].Width = 130;
            //dgvAdd.Columns[colCapitalMax].Width = 130;
            dgvAdd.Columns[colRateTInsur1].Width = 125;
            dgvAdd.Columns[colRateTInsur2].Width = 125;
            dgvAdd.Columns[colRateTInsur3].Width = 125;
            dgvAdd.Columns[colSedanCapitalId].Width = 120;
            dgvAdd.Columns[colDel].Width = 50;
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colCapital].HeaderText = "บาดเจ็บ ครั้ง";
            //dgvAdd.Columns[colCapitalMax].HeaderText = "ทุนประกันขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";
            dgvAdd.Columns[colDel].HeaderText = " ";

            dgvAdd.Columns[colSedanCapitalId].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanCapitalId].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colSedanCapitalId, i].Value = dt.Rows[i][cic.sitdb.sit.sedanInjuryTimeId].ToString();

                    dgvAdd[colCapital, i].Value = dt.Rows[i][cic.sitdb.sit.sedanInjuryTime].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.sitdb.sit.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.sitdb.sit.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.sitdb.sit.RateTInsur3].ToString();
                    dgvAdd[colDel, i].Value = "ยกเลิก";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        private SedanInjuryTime getSedanInjuryTime(int row)
        {
            sit = new SedanInjuryTime();
            if (dgvAdd[colCapital, row].Value == null)
            {
                return null;
            }
            sit.RateTInsur1 = cic.cf.ObjectNull(dgvAdd[colRateTInsur1, row].Value);
            sit.RateTInsur2 = cic.cf.ObjectNull(dgvAdd[colRateTInsur2, row].Value);
            sit.RateTInsur3 = cic.cf.ObjectNull(dgvAdd[colRateTInsur3, row].Value);

            sit.sedanInjuryTime = dgvAdd[colCapital, row].Value.ToString();
            sit.sedanInjuryTimeId = cic.cf.ObjectNull(dgvAdd[colSedanCapitalId, row].Value);

            return sit;
        }
        private void FrmSedanInjuryTime_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanInjuryTime_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sit = getSedanInjuryTime(i);
                if (sit != null)
                {
                    if (cic.saveSedanInjuryTime(sit).Length >= 1)
                    {
                        chk = true;
                    }
                    else
                    {
                        chk = false;
                        MessageBox.Show("ไม่สามารถ บันทึกข้อมูลได้", "Error");
                    }
                }
            }
            if (chk)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
                setData();
            }
        }

        private void dgvAdd_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = e.Control as TextBox;
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvAdd.CurrentCell.ColumnIndex == colRateTInsur1) //Desired Column
            {

                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            else if (dgvAdd.CurrentCell.ColumnIndex == colRateTInsur2) //Desired Column
            {
                //TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            else if (dgvAdd.CurrentCell.ColumnIndex == colRateTInsur3) //Desired Column
            {
                //TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if(e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDel)
            {
                //MessageBox.Show("ต้องการยกเลิกข้อมูลรายการ","ยกเลิก");
                if (dgvAdd[colCapital, e.RowIndex].Value == null)
                {
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการ \nบาดเจ็บ ครั้ง : " + dgvAdd[colCapital, e.RowIndex].Value.ToString(), "ยกเลิกรายการ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String sacId = "";
                    if (dgvAdd[colSedanCapitalId, e.RowIndex].Value != null)
                    {
                        cic.sitdb.updateUnActive(dgvAdd[colSedanCapitalId, e.RowIndex].Value.ToString());
                        this.Dispose();
                    }
                }
            }
        }
    }
}
