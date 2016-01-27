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
    public partial class FrmSedanEngineCC : Form
    {
        private CarIControl cic;
        private SedanEngineCC sec;
        private void initConfig()
        {
            //cic = new CarIControl();
            sec = new SedanEngineCC();

            setControl();
        }
        private void setControl()
        {
            sec = cic.selectSedanEngineCC();
            txtCCMinTInsur1.Text = sec.sedanEngine2000CCMinTInsur1;
            txtCCMinTInsur2.Text = sec.sedanEngine2000CCMinTInsur2;
            txtCCMinTInsur3.Text = sec.sedanEngine2000CCMinTInsur3;

            txtCCMaxTInsur1.Text = sec.sedanEngine2000CCMaxTInsur1;
            txtCCMaxTInsur2.Text = sec.sedanEngine2000CCMaxTInsur2;
            txtCCMaxTInsur3.Text = sec.sedanEngine2000CCMaxTInsur3;
        }
        private SedanEngineCC getSedanUseCar()
        {
            sec.sedanEngine2000CCMinTInsur1 = txtCCMinTInsur1.Text;
            sec.sedanEngine2000CCMinTInsur2 = txtCCMinTInsur2.Text;
            sec.sedanEngine2000CCMinTInsur3 = txtCCMinTInsur3.Text;

            sec.sedanEngine2000CCMaxTInsur1 = txtCCMaxTInsur1.Text;
            sec.sedanEngine2000CCMaxTInsur2 = txtCCMaxTInsur2.Text;
            sec.sedanEngine2000CCMaxTInsur3 = txtCCMaxTInsur3.Text;
            return sec;
        }
        public FrmSedanEngineCC(CarIControl c)
        {
            InitializeComponent();
            cic = c;
            initConfig();
        }

        private void txtCCMinTInsur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMaxTInsur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMinTInsur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMaxTInsur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMinTInsur3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMaxTInsur3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCCMinTInsur1_Enter(object sender, EventArgs e)
        {
            txtCCMinTInsur1.BackColor = Color.LightYellow;
        }

        private void txtCCMinTInsur1_Leave(object sender, EventArgs e)
        {
            txtCCMinTInsur1.BackColor = Color.White;
        }

        private void txtCCMaxTInsur1_Enter(object sender, EventArgs e)
        {
            txtCCMaxTInsur1.BackColor = Color.LightYellow;
        }

        private void txtCCMaxTInsur1_Leave(object sender, EventArgs e)
        {
            txtCCMaxTInsur1.BackColor = Color.White;
        }

        private void txtCCMinTInsur2_Enter(object sender, EventArgs e)
        {
            txtCCMinTInsur2.BackColor = Color.LightYellow;
        }

        private void txtCCMinTInsur2_Leave(object sender, EventArgs e)
        {
            txtCCMinTInsur2.BackColor = Color.White;
        }

        private void txtCCMaxTInsur2_Enter(object sender, EventArgs e)
        {
            txtCCMaxTInsur2.BackColor = Color.LightYellow;
        }

        private void txtCCMaxTInsur2_Leave(object sender, EventArgs e)
        {
            txtCCMaxTInsur2.BackColor = Color.White;
        }

        private void txtCCMinTInsur3_Enter(object sender, EventArgs e)
        {
            txtCCMinTInsur3.BackColor = Color.LightYellow;
        }

        private void txtCCMinTInsur3_Leave(object sender, EventArgs e)
        {
            txtCCMinTInsur3.BackColor = Color.White;
        }

        private void txtCCMaxTInsur3_Enter(object sender, EventArgs e)
        {
            txtCCMaxTInsur3.BackColor = Color.LightYellow;
        }

        private void txtCCMaxTInsur3_Leave(object sender, EventArgs e)
        {
            txtCCMaxTInsur3.BackColor = Color.White;
        }

        private void FrmSedanEngineCC_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sec = getSedanUseCar();
            if (cic.saveSedanEngineCC(sec).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            }
            setControl();
        }
    }
}
