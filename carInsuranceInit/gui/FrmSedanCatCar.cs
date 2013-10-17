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
    public partial class FrmSedanCatCar : Form
    {
        private CarIControl cic;
        SedanCatCar scc;
        int colRow = 0, colCatCar = 1, colCatRate = 2, colCatCarId=3;
        int colCnt = 4;
        private void initConfig()
        {
            cic = new CarIControl();
            scc = new SedanCatCar();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanCatCar()
        {
            InitializeComponent();
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectSedanCatCar();

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colCatCar].Width = 130;
            dgvAdd.Columns[colCatRate].Width = 80;
            

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colCatCar].HeaderText = "กลุ่มรถ";

            dgvAdd.Columns[colCatRate].HeaderText = "อัตรา ";

            dgvAdd.Columns[colCatCarId].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colCatCarId].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colCatCarId, i].Value = dt.Rows[i][cic.sccdb.scc.sedanCatCarId].ToString();

                    dgvAdd[colCatCar, i].Value = dt.Rows[i][cic.sccdb.scc.sedanCatCar].ToString();
                    dgvAdd[colCatRate, i].Value = dt.Rows[i][cic.sccdb.scc.Rate].ToString();
                    //dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur2].ToString();
                    //dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur3].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        private SedanCatCar getSedanCatCar(int row)
        {
            scc = new SedanCatCar();
            if (dgvAdd[colCatCar, row].Value == null)
            {
                return null;
            }
            scc.Rate = dgvAdd[colCatRate, row].Value.ToString();
            //scc. = dgvAdd[colRateTInsur2, row].Value.ToString();
            //sad.RateTInsur3 = dgvAdd[colRateTInsur3, row].Value.ToString();

            scc.sedanCatCar = dgvAdd[colCatCar, row].Value.ToString();
            if (dgvAdd[colCatCarId, row].Value != null)
            {
                scc.sedanCatCarId = dgvAdd[colCatCarId, row].Value.ToString();
            }
            else
            {
                scc.sedanCatCarId = "";
            }

            return scc;
        }

        private void FrmSedanCatCar_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanCatCar_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                scc = getSedanCatCar(i);
                if (scc != null)
                {
                    if (cic.saveSedanCatCat(scc).Length >= 1)
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
            if (dgvAdd.CurrentCell.ColumnIndex == colCatRate) //Desired Column
            {

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
    }
}
