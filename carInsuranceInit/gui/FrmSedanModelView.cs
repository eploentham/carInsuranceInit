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

            dgvView.ColumnCount = colCnt;

            dgvView.RowCount = dt.Rows.Count + 1;
            dgvView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvView.Columns[colRow].Width = 50;
            dgvView.Columns[colBrand].Width = 150;
            dgvView.Columns[colSedanModel].Width = 120;
            dgvView.Columns[colCatCar].Width = 300;
            dgvView.Columns[colEngineCC].Width = 120;
            dgvView.Columns[colPriceMin].Width = 100;
            dgvView.Columns[colPriceMax].Width = 120;
            dgvView.Columns[colPrice].Width = 80;
            dgvView.Columns[colSedanModelId].Width = 80;

            dgvView.Columns[colRow].HeaderText = "ลำดับ";
            dgvView.Columns[colBrand].HeaderText = "ยี่ห้อ";
            dgvView.Columns[colSedanModel].HeaderText = "รุ่น";
            dgvView.Columns[colCatCar].HeaderText = "กลุ่มรถ";
            dgvView.Columns[colEngineCC].HeaderText = "ขนาดเครื่องยนต์";
            dgvView.Columns[colPriceMin].HeaderText = "ราคาขั้นต่ำ";
            dgvView.Columns[colPriceMax].HeaderText = "วันที่ราคาขั้นสูง";
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
                    //dgvView[colInvNumber, i].Value = dt.Rows[i][invdb.inv.invNumber].ToString();
                    //dgvView[colInvDate, i].Value = dc.config1.dateDBtoShow1(dt.Rows[i][invdb.inv.invDate].ToString());
                    //dgvView[colCustName, i].Value = dt.Rows[i][invdb.inv.custName].ToString();
                    //dgvView[colInvAmount, i].Value = dc.config1.NumberNull(dt.Rows[i][invdb.inv.invAmount]);
                    //dgvView[colTermPay, i].Value = dt.Rows[i][invdb.inv.termPayment].ToString();
                    //dgvView[colDueDate, i].Value = dc.config1.dateDBtoShow1(dt.Rows[i][invdb.inv.dueDate].ToString());
                    //dgvView[colInvId, i].Value = dt.Rows[i][invdb.inv.invId].ToString();
                    //dgvView[colRecpNumber, i].Value = dt.Rows[i][invdb.inv.receiptNumber].ToString();

                    if ((i % 2) != 0)
                    {
                        dgvView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }
        }
        public FrmSedanModelView()
        {
            InitializeComponent();
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
        }
    }
}
