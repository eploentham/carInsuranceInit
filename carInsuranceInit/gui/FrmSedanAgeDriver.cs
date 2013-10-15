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
        int colRow = 0, colAgeDriver = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanAgeDriverid = 5;
        int colCnt = 6;
        private void initConfig()
        {
            cic = new CarIControl();
            sad = new SedanAgeDriver();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanAgeDriver()
        {
            InitializeComponent();
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
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAgeDriver].HeaderText = "อายุผู้ขับขี่";
            //dgvAdd.Columns[colAgeDriverMax].HeaderText = "อายุผู้ขับขี่ขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";

            dgvAdd.Columns[colSedanAgeDriverid].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanAgeDriverid].Visible = false;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colSedanAgeDriverid, i].Value = dt.Rows[i][cic.saddb.sad.sedanAgeDriver].ToString();

                    dgvAdd[colAgeDriver, i].Value = dt.Rows[i][cic.saddb.sad.sedanAgeDriver].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.saddb.sad.RateTInsur3].ToString();
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
            if (dgvAdd[colRateTInsur1, row].Value == null)
            {
                return null;
            }
            sad.RateTInsur1 = dgvAdd[colRateTInsur1, row].Value.ToString();
            sad.RateTInsur2 = dgvAdd[colRateTInsur2, row].Value.ToString();
            sad.RateTInsur3 = dgvAdd[colRateTInsur3, row].Value.ToString();

            sad.sedanAgeDriver = dgvAdd[colAgeDriver, row].Value.ToString();
            if (dgvAdd[colSedanAgeDriverid, row].Value != null)
            {
                sad.sedanAgeDriverId = dgvAdd[colSedanAgeDriverid, row].Value.ToString();
            }
            else
            {
                sad.sedanAgeDriverId = "";
            }

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
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sad = getSedanAgeCar(i);
                if (sad != null)
                {
                    cic.saveSedanAgeDriver(sad);
                }

            }
        }
    }
}
