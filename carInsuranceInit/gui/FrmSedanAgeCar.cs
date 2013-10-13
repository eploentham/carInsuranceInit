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
        int colRow = 0, colAgeCarMin = 1, colAgeCarMax = 2, colRateTInsur1 = 3, colRateTInsur2 = 4, colRateTInsur3 = 5, colSedanAgeCarid = 6;
        int colCnt = 7;
        private void initConfig()
        {

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

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colAgeCarMin].Width = 120;
            dgvAdd.Columns[colAgeCarMax].Width = 120;
            dgvAdd.Columns[colRateTInsur1].Width = 150;
            dgvAdd.Columns[colRateTInsur2].Width = 150;
            dgvAdd.Columns[colRateTInsur3].Width = 150;
            dgvAdd.Columns[colSedanAgeCarid].Width = 120;
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colAgeCarMin].HeaderText = "อายุรถขั้นต่ำ";
            dgvAdd.Columns[colAgeCarMax].HeaderText = "อายุรถขั้นสูง";
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

                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }

        private void FrmSedanAgeCar_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanAgeCar_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
