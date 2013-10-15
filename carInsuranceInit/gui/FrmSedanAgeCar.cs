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
        int colRow = 0, colAgeCar = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanAgeCarid = 5;
        int colCnt = 6;
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
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAgeCar].HeaderText = "อายุรถ";
            //dgvAdd.Columns[colAgeCarMax].HeaderText = "อายุรถขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";
            
            dgvAdd.Columns[colSedanAgeCarid].HeaderText = "sedanagecarid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanAgeCarid].Visible = false;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow,i].Value = (i+1);
                    dgvAdd[colSedanAgeCarid, i].Value = dt.Rows[i][cic.sacdb.sac.sedanAgeCar].ToString();

                    dgvAdd[colAgeCar, i].Value = dt.Rows[i][cic.sacdb.sac.sedanAgeCar].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.sacdb.sac.RateTInsur3].ToString();
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
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sac = getSedanAgeCar(i);
                if (sac != null)
                {
                    cic.saveSedanAgeCar(sac);
                }
                
            }
        }
    }
}
