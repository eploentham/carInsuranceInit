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
    public partial class FrmSedanUseCar : Form
    {
        private CarIControl cic;
        private SedanUseCar suc;
        private void initConfig()
        {
            cic = new CarIControl();
            suc = new SedanUseCar();
            
            setControl();
        }
        private void setControl()
        {
            suc = cic.selectSedanUsecar();
            txt110TInsur1.Text = suc.sedanUseCar110TInsur1;
            txt110TInsur2.Text = suc.sedanUseCar110TInsur2;
            txt110TInsur3.Text = suc.sedanUseCar110TInsur3;

            txt120TInsur1.Text = suc.sedanUseCar120TInsur1;
            txt120TInsur2.Text = suc.sedanUseCar120TInsur2;
            txt120TInsur3.Text = suc.sedanUseCar120TInsur3;
        }
        private SedanUseCar getSedanUseCar()
        {
             suc.sedanUseCar110TInsur1 = txt110TInsur1.Text;
             suc.sedanUseCar110TInsur2 = txt110TInsur2.Text;
             suc.sedanUseCar110TInsur3 = txt110TInsur3.Text;

             suc.sedanUseCar120TInsur1 = txt120TInsur1.Text;
             suc.sedanUseCar120TInsur2 = txt120TInsur2.Text;
             suc.sedanUseCar120TInsur3 = txt120TInsur3.Text;
             return suc;
        }
        public FrmSedanUseCar()
        {
            InitializeComponent();
            initConfig();
        }

        private void txt110TInsur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt120TInsur1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt110TInsur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt120TInsur2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt110TInsur3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt120TInsur3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt110TInsur1_Enter(object sender, EventArgs e)
        {
            txt110TInsur1.BackColor = Color.LightYellow;
        }

        private void txt110TInsur1_Leave(object sender, EventArgs e)
        {
            txt110TInsur1.BackColor = Color.White;
        }

        private void txt120TInsur1_Enter(object sender, EventArgs e)
        {
            txt120TInsur1.BackColor = Color.LightYellow;
        }

        private void txt120TInsur1_Leave(object sender, EventArgs e)
        {
            txt120TInsur1.BackColor = Color.White;
        }

        private void txt110TInsur2_Enter(object sender, EventArgs e)
        {
            txt110TInsur2.BackColor = Color.LightYellow;
        }

        private void txt110TInsur2_Leave(object sender, EventArgs e)
        {
            txt110TInsur2.BackColor = Color.White;
        }

        private void txt120TInsur2_Enter(object sender, EventArgs e)
        {
            txt120TInsur2.BackColor = Color.LightYellow;
        }

        private void txt120TInsur2_Leave(object sender, EventArgs e)
        {
            txt120TInsur2.BackColor = Color.White;
        }

        private void txt110TInsur3_Enter(object sender, EventArgs e)
        {
            txt110TInsur3.BackColor = Color.LightYellow;
        }

        private void txt110TInsur3_Leave(object sender, EventArgs e)
        {
            txt110TInsur3.BackColor = Color.White;
        }

        private void txt120TInsur3_Enter(object sender, EventArgs e)
        {
            txt120TInsur3.BackColor = Color.LightYellow;
        }

        private void txt120TInsur3_Leave(object sender, EventArgs e)
        {
            txt120TInsur3.BackColor = Color.White;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            suc = getSedanUseCar();
            if (cic.saveSedanUseCar(suc).Length >= 1)
            {
                MessageBox.Show("บันทึกข้อมูล เรียบร้อย", "บันทึกข้อมูล");
            }
            setControl();
        }

        private void FrmSedanUseCar_Load(object sender, EventArgs e)
        {

        }
    }
}
