using carInsuranceInit.control;
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
    public partial class FrmSedanCapitalInsur : Form
    {
        private CarIControl cic;
        SedanCapitalInsur sci;
        int colRow = 0, colCapital = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanCapitalId = 5, colDel=6;
        int colCnt = 7;
        private void initConfig()
        {
            cic = new CarIControl();
            sci = new SedanCapitalInsur();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanCapitalInsur()
        {
            InitializeComponent();
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectSedanCapitalInsur();

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
            dgvAdd.Columns[colCapital].HeaderText = "ทุนประกัน";
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
                    dgvAdd[colSedanCapitalId, i].Value = dt.Rows[i][cic.scidb.sci.sedanCapitalInsurId].ToString();

                    dgvAdd[colCapital, i].Value = dt.Rows[i][cic.scidb.sci.sedanCapitalInsur].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.scidb.sci.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.scidb.sci.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.scidb.sci.RateTInsur3].ToString();
                    dgvAdd[colDel, i].Value = "ยกเลิก";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        private SedanCapitalInsur getSedanCapitalInsur(int row)
        {
            sci = new SedanCapitalInsur();
            if (dgvAdd[colRateTInsur1, row].Value == null)
            {
                return null;
            }
            sci.RateTInsur1 = dgvAdd[colRateTInsur1, row].Value.ToString();
            sci.RateTInsur2 = dgvAdd[colRateTInsur2, row].Value.ToString();
            sci.RateTInsur3 = dgvAdd[colRateTInsur3, row].Value.ToString();

            sci.sedanCapitalInsur = dgvAdd[colCapital, row].Value.ToString();
            if (dgvAdd[colSedanCapitalId, row].Value != null)
            {
                sci.sedanCapitalInsurId = dgvAdd[colSedanCapitalId, row].Value.ToString();
            }
            else
            {
                sci.sedanCapitalInsurId = "";
            }

            return sci;
        }

        private void FrmSedanCapitalInsur_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanCapitalInsur_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sci = getSedanCapitalInsur(i);
                if (sci != null)
                {
                    if (cic.saveSedanCapitalInsur(sci).Length >= 1)
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
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar))
            {
                //if (e.KeyChar != '.')
                //{
                    e.Handled = true;
                //}
            }
        }

        private void dgvAdd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colDel)
            {
                //MessageBox.Show("ต้องการยกเลิกข้อมูลรายการ","ยกเลิก");
                DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการ \n", "ยกเลิกรายการ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String sacId = "";
                    if (dgvAdd[colSedanCapitalId, e.RowIndex].Value != null)
                    {
                        cic.scidb.updateUnActive(dgvAdd[colSedanCapitalId, e.RowIndex].Value.ToString());
                        this.Dispose();
                    }
                }
            }
        }

    }
}
