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
    public partial class FrmSedanInjuryPerson : Form
    {
        private CarIControl cic;
        SedanInjuryPerson sip;
        int colRow = 0, colCapital = 1, colRateTInsur1 = 2, colRateTInsur2 = 3, colRateTInsur3 = 4, colSedanCapitalId = 5;
        int colCnt = 6;
        private void initConfig()
        {
            cic = new CarIControl();
            sip = new SedanInjuryPerson();
        }
        private void setResize()
        {
            dgvAdd.Width = this.Width - 50;
            dgvAdd.Height = this.Height - 150;
        }
        public FrmSedanInjuryPerson()
        {
            InitializeComponent();
            initConfig();
            setData();
        }
        public void setData()
        {
            DataTable dt = new DataTable();
            dgvAdd.ColumnCount = colCnt;
            dt = cic.selectSedanInjuryPerson();

            dgvAdd.RowCount = dt.Rows.Count + 1;
            dgvAdd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdd.Columns[colRow].Width = 50;
            dgvAdd.Columns[colCapital].Width = 130;
            //dgvAdd.Columns[colCapitalMax].Width = 130;
            dgvAdd.Columns[colRateTInsur1].Width = 125;
            dgvAdd.Columns[colRateTInsur2].Width = 125;
            dgvAdd.Columns[colRateTInsur3].Width = 125;
            dgvAdd.Columns[colSedanCapitalId].Width = 120;
            //dgvAdd.Columns[colAmount].Width = 120;

            dgvAdd.Columns[colRow].HeaderText = "ลำดับ";
            dgvAdd.Columns[colCapital].HeaderText = "บาดเจ็บ บุคคล";
            //dgvAdd.Columns[colCapitalMax].HeaderText = "ทุนประกันขั้นสูง";
            dgvAdd.Columns[colRateTInsur1].HeaderText = "อัตรา ประเภท1";
            dgvAdd.Columns[colRateTInsur2].HeaderText = "อัตรา ประเภท2";
            dgvAdd.Columns[colRateTInsur3].HeaderText = "อัตรา ประเภท3";

            dgvAdd.Columns[colSedanCapitalId].HeaderText = "sedanagedriverid";
            //dgvAdd.Columns[colAmount].HeaderText = "จำนวนเงิน";
            Font font = new Font("Microsoft Sans Serif", 12);
            dgvAdd.Columns[colSedanCapitalId].Visible = false;
            dgvAdd.Columns[colRow].ReadOnly = true;

            dgvAdd.Font = font;
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvAdd[colRow, i].Value = (i + 1);
                    dgvAdd[colSedanCapitalId, i].Value = dt.Rows[i][cic.sipdb.sip.sedanInjuryPersonId].ToString();

                    dgvAdd[colCapital, i].Value = dt.Rows[i][cic.sipdb.sip.sedanInjuryPerson].ToString();
                    dgvAdd[colRateTInsur1, i].Value = dt.Rows[i][cic.sipdb.sip.RateTInsur1].ToString();
                    dgvAdd[colRateTInsur2, i].Value = dt.Rows[i][cic.sipdb.sip.RateTInsur2].ToString();
                    dgvAdd[colRateTInsur3, i].Value = dt.Rows[i][cic.sipdb.sip.RateTInsur3].ToString();
                    if ((i % 2) != 0)
                    {
                        dgvAdd.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                }
            }

        }
        private SedanInjuryPerson getSedanInjuryPerson(int row)
        {
            sip = new SedanInjuryPerson();
            if (dgvAdd[colRateTInsur1, row].Value == null)
            {
                return null;
            }
            sip.RateTInsur1 = dgvAdd[colRateTInsur1, row].Value.ToString();
            sip.RateTInsur2 = dgvAdd[colRateTInsur2, row].Value.ToString();
            sip.RateTInsur3 = dgvAdd[colRateTInsur3, row].Value.ToString();

            sip.sedanInjuryPerson = dgvAdd[colCapital, row].Value.ToString();
            if (dgvAdd[colSedanCapitalId, row].Value != null)
            {
                sip.sedanInjuryPersonId = dgvAdd[colSedanCapitalId, row].Value.ToString();
            }
            else
            {
                sip.sedanInjuryPersonId = "";
            }

            return sip;
        }
        private void FrmSedanInjuryPerson_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void FrmSedanInjuryPerson_Resize(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            for (int i = 0; i < dgvAdd.RowCount; i++)
            {
                sip = getSedanInjuryPerson(i);
                if (sip != null)
                {
                    if (cic.saveSedanInjuryPerson(sip).Length >= 1)
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
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }
    }
}
