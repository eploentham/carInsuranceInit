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
        int colRow = 0, colCatCar = 1, colCatRate = 2, colCatCarId=3;
        int colCnt = 4;
        private void initConfig()
        {

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

        private void FrmSedanCatCar_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanCatCar_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
