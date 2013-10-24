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
    public partial class FrmSedanAgeCar : Form
    {
        private CarIControl cic;
        int colRow = 0, colAgeCar = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanAgeCarid = 5, colDel=6;
        int colCnt = 7;
        SedanAgeCar sac;
        private void initConfig()
        {
            sac = new SedanAgeCar();
            cic = new CarIControl();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanAgeCar()
        {
            InitializeComponent();
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;

            dt = cic.selectSedanAgeCar();
            dgvAdd.RowCount = dt.Rows.Count+1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colAgeCar].Width = 120;
            //dgvAdd.Columns[colAgeCarMax].Width = 120;
            dgvAdd.Columns[colRateTInsur1].Width = 150;
            dgvAdd.Columns[colRateTInsur2].Width = 150;
            dgvAdd.Columns[colRateTInsur3].Width = 150;
            dgvAdd.Columns[colSedanAgeCarid].Width = 120;
            dgvAdd.Columns[colDel].Width = 50;
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAgeCar].HeaderText = "อายุรถ";
            //dgvAdd.Columns[colAgeCarMax].HeaderText = "อายุรถขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";
            dgvAdd.Columns[colDel].HeaderText = " ";
            
            dgvAdd.Columns[colSedanAgeCarid].HeaderText = "sedanagecarid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanAgeCarid].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;
            dgvAdd.Columns[colDel].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow,i].Value = (i+1);
                    dgvAdd[colSedanAgeCarid, i].Value = dt.Rows[i][cic.sacdb.sac.sedanAgeCarId].ToString();

                    dgvAdd[colAgeCar, i].Value = dt.Rows[i][cic.sacdb.sac.sedanAgeCar].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur3].ToString();
                    dgvAdd[colDel, i].Value = "ยกเลิก";
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        private SedanAgeCar getSedanAgeCar(int row)
        {
            sac = new SedanAgeCar();
            if (dgvAdd[colRateTInsur1, row].Value == null)
            {
                return null;
            }
            sac.RateTInsur1 = dgvAdd[colRateTInsur1, row].Value.ToString();
            sac.RateTInsur2 = dgvAdd[colRateTInsur2, row].Value.ToString();
            sac.RateTInsur3 = dgvAdd[colRateTInsur3, row].Value.ToString();

            sac.sedanAgeCar = dgvAdd[colAgeCar, row].Value.ToString();
            if (dgvAdd[colSedanAgeCarid, row].Value != null)
            {
                sac.sedanAgeCarId = dgvAdd[colSedanAgeCarid, row].Value.ToString();
            }
            else
            {
                sac.sedanAgeCarId = "";
            }

            return sac;
        }

        private void FrmSedanAgeCar_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanAgeCar_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sac = getSedanAgeCar(i);
                if (sac != null)
                {
                    if (cic.saveSedanAgeCar(sac).Length >= 1)
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
                if (dgvAdd[colAgeCar, e.RowIndex].Value == null)
                {
                    return;
                }
                //MessageBox.Show("ต้องการยกเลิกข้อมูลรายการ","ยกเลิก");
                DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการ \nอายุรถ : " + dgvAdd[colAgeCar, e.RowIndex].Value.ToString(), "ยกเลิกรายการ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String sacId = "";
                    if (dgvAdd[colSedanAgeCarid,e.RowIndex].Value != null)
                    {
                        cic.sacdb.updateUnActive(dgvAdd[colSedanAgeCarid, e.RowIndex].Value.ToString());
                        this.Dispose();
                    }
                }
            }
            //FrmSedanAgeCar frm = new FrmSedanAgeCar();
            //frm.setData();
            //frm.ShowDialog(this);
        }
    }
}
