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
    public partial class FrmSedanAgeDriver : Form
    {
        private CarIControl cic;
        SedanAgeDriver sad;
        int colRow = 0, colAgeDriver = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanAgeDriverid = 5, colDel=6;
        int colCnt = 7;
        private void initConfig()
        {
            //cic = new CarIControl();
            sad = new SedanAgeDriver();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanAgeDriver(CarIControl c)
        {
            InitializeComponent();
            cic = c;
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectSedanAgeDriver();

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colAgeDriver].Width = 125;
            //dgvAdd.Columns[colAgeDriverMax].Width = 125;
            dgvAdd.Columns[colRateTInsur1].Width = 150;
            dgvAdd.Columns[colRateTInsur2].Width = 150;
            dgvAdd.Columns[colRateTInsur3].Width = 150;
            dgvAdd.Columns[colSedanAgeDriverid].Width = 120;
            dgvAdd.Columns[colDel].Width = 50;
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAgeDriver].HeaderText = "อายุผู้ขับขี่";
            //dgvAdd.Columns[colAgeDriverMax].HeaderText = "อายุผู้ขับขี่ขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";
            dgvAdd.Columns[colDel].HeaderText = " ";

            dgvAdd.Columns[colSedanAgeDriverid].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanAgeDriverid].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colSedanAgeDriverid, i].Value = dt.Rows[i][cic.saddb.sad.sedanAgeDriverId].ToString();

                    dgvAdd[colAgeDriver, i].Value = dt.Rows[i][cic.saddb.sad.sedanAgeDriver].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur3].ToString();
                    dgvAdd[colDel, i].Value = "ยกเลิก";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        
        private SedanAgeDriver getSedanAgeCar(int row)
        {
            sad = new SedanAgeDriver();
            if (dgvAdd[colAgeDriver, row].Value == null)
            {
                return null;
            }
            sad.RateTInsur1 = cic.cf.ObjectNull(dgvAdd[colRateTInsur1, row].Value);
            sad.RateTInsur2 = cic.cf.ObjectNull(dgvAdd[colRateTInsur2, row].Value);
            sad.RateTInsur3 = cic.cf.ObjectNull(dgvAdd[colRateTInsur3, row].Value);

            sad.sedanAgeDriver = cic.cf.ObjectNull(dgvAdd[colAgeDriver, row].Value);
            sad.sedanAgeDriverId = cic.cf.ObjectNull(dgvAdd[colSedanAgeDriverid, row].Value);

            return sad;
        }

        private void FrmSedanAgeDriver_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanAgeDriver_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sad = getSedanAgeCar(i);
                if (sad != null)
                {
                    if (cic.saveSedanAgeDriver(sad).Length >= 1)
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
                DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการ \nอายุผู้ขับขี่ : " + dgvAdd[colAgeDriver, e.RowIndex].Value.ToString(), "ยกเลิกรายการ ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String sacId = "";
                    if (dgvAdd[colSedanAgeDriverid, e.RowIndex].Value != null)
                    {
                        cic.saddb.updateUnActive(dgvAdd[colSedanAgeDriverid, e.RowIndex].Value.ToString());
                        this.Dispose();
                    }
                }
            }
        }
    }
}
