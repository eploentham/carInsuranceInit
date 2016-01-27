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
    public partial class FrmSedanModelView : Form
    {
        private CarIControl cic;
        SedanInjuryTime sit;
        int colRow = 0, colSedanModel = 2, colBrand = 1, colCatCar = 3, colEngineCC = 4, colPriceMin = 5, colPriceMax = 6, colPrice = 7, colSedanModelId = 8;
        int colCnt = 9;
        private void initConfig()
        {
            cic = new CarIControl();
            sit = new SedanInjuryTime();
            cboBrand = cic.branddb.getCboCustomer(cboBrand);
        }
        public FrmSedanModelView(CarIControl c)
        {
            InitializeComponent();
            cic = c;
            initConfig();
        }
        private void setResize()
        {
            dgvView.Width = this.Width - 50;
            dgvView.Height = this.Height - 150;

            groupBox1.Width = this.Width - 50;
            //groupBox1.Height = this.Height = 150;
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dt = cic.smdb.selectAll();
            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colBrand].Width = 150;
            dgvView.Columns[colSedanModel].Width = 120;
            dgvView.Columns[colCatCar].Width = 80;
            dgvView.Columns[colEngineCC].Width = 140;
            dgvView.Columns[colPriceMin].Width = 120;
            dgvView.Columns[colPriceMax].Width = 120;
            dgvView.Columns[colPrice].Width = 120;
            dgvView.Columns[colSedanModelId].Width = 80;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colBrand].HeaderText = "ยี่ห้อ";
            dgvView.Columns[colSedanModel].HeaderText = "รุ่น";
            dgvView.Columns[colCatCar].HeaderText = "กลุ่มรถ";
            dgvView.Columns[colEngineCC].HeaderText = "ขนาดเครื่องยนต์";
            dgvView.Columns[colPriceMin].HeaderText = "ราคาขั้นต่ำ";
            dgvView.Columns[colPriceMax].HeaderText = "ราคาขั้นสูง";
            dgvView.Columns[colPrice].HeaderText = "ราคากลาง";
            dgvView.Columns[colSedanModelId].HeaderText = "id";
            Font font = new Font("Microsoft Sans Serif", 12);

            dgvView.Font = font;
            dgvView.Columns[colSedanModelId].Visible = false;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvView[colRow, i].Value = (i + 1);
                    dgvView[colBrand, i].Value = dt.Rows[i][cic.smdb.sm.brandName].ToString();
                    dgvView[colSedanModel, i].Value = dt.Rows[i][cic.smdb.sm.sedanModel].ToString();
                    dgvView[colCatCar, i].Value = dt.Rows[i][cic.smdb.sm.sedanCatCar].ToString();
                    dgvView[colEngineCC, i].Value = dt.Rows[i][cic.smdb.sm.sedanEngineCC].ToString();
                    dgvView[colPriceMin, i].Value = dt.Rows[i][cic.smdb.sm.priceMin].ToString();
                    dgvView[colPriceMax, i].Value = dt.Rows[i][cic.smdb.sm.priceMax].ToString();
                    dgvView[colPrice, i].Value = dt.Rows[i][cic.smdb.sm.price].ToString();
                    dgvView[colSedanModelId, i].Value = dt.Rows[i][cic.smdb.sm.sedanModelId].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmSedanModelAdd frm = new FrmSedanModelAdd();
            frm.ShowDialog(this);
            setData();
        }

        private void FrmSedanModel_Load(object sender, EventArgs e)
        {
            setResize();
            setData();
        }

        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgvView[colSedanModelId, e.RowIndex].Value == null)
            {
                return;
            }
            FrmSedanModelAdd frmDepositAdd = new FrmSedanModelAdd();
            frmDepositAdd.setData(dgvView[colSedanModelId, e.RowIndex].Value.ToString());
            frmDepositAdd.ShowDialog(this);
            setData();
        }
    }
}
