using carInsuranceInit.control;
using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.gui
{
    public partial class FrmBrand : Form
    {
        private CarIControl cic;
        Brand brand;
        int colRow = 0, colBrandName = 1, colCatRate = 2, colBrandId = 3;
        int colCnt = 4;
        public FrmBrand(CarIControl c)
        {
            InitializeComponent();
            cic = c;
            initConfig();
        }
        private void initConfig()
        {
            brand = new Brand();
            //cic = new CarIControl();
            setData();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectBrand();

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colBrandName].Width = 130;
            dgvAdd.Columns[colCatRate].Width = 80;


            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colBrandName].HeaderText = "ยี่ห้อรถ";

            //dgvAdd.Columns[colCatRate].HeaderText = "อัตรา ";

            dgvAdd.Columns[colBrandId].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colBrandId].Visible = false;
            dgvAdd.Columns[colCatRate].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colBrandId, i].Value = dt.Rows[i][cic.branddb.brand.brandId].ToString();

                    dgvAdd[colBrandName, i].Value = dt.Rows[i][cic.branddb.brand.brandName].ToString();
                    
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        private Brand getBrand(int row)
        {
            brand = new Brand();
            if (dgvAdd[colBrandName, row].Value == null)
            {
                return null;
            }

            brand.brandName = dgvAdd[colBrandName, row].Value.ToString();
            if (dgvAdd[colBrandId, row].Value != null)
            {
                brand.brandId = dgvAdd[colBrandId, row].Value.ToString();
            }
            else
            {
                brand.brandId = "";
            }

            return brand;
        }

        private void FrmBrand_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                brand = getBrand(i);
                if (brand != null)
                {
                    if (cic.saveBrand(brand).Length >= 1)
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
    }
}
