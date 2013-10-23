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
    public partial class FrmSedanModelAdd : Form
    {
        CarIControl cic;
        SedanModel sm;
        private void initConfig()
        {
            cic = new CarIControl();
            sm = new SedanModel();
            cboBrand = cic.branddb.getCboCustomer(cboBrand);
        }
        public FrmSedanModelAdd()
        {
            InitializeComponent();
            initConfig();
        }
        public void setData(String sedanModelId)
        {
            DataTable dt = new DataTable();
            sm = cic.smdb.selectByPk(sedanModelId);
            txtBrandId.Text = sm.brandId;
            cboBrand.Text = sm.brandName;
            txtSedanPrice.Text = sm.price;
            txtSedanPriceMax.Text = sm.priceMax;
            txtSedanPriceMin.Text = sm.priceMin;
            if (sm.sedanCatCar.Equals("1"))
            {
                chkCatCar1.Checked = true;
            }
            else if (sm.sedanCatCar.Equals("2"))
            {
                chkCatCar2.Checked = true;
            }
            else if (sm.sedanCatCar.Equals("3"))
            {
                chkCatCar3.Checked = true;
            }
            else if (sm.sedanCatCar.Equals("4"))
            {
                chkCatCar4.Checked = true;
            }
            else if (sm.sedanCatCar.Equals("5"))
            {
                chkCatCar5.Checked = true;
            }

            txtEngineCC.Text = sm.sedanEngineCC;
            txtSedanModel.Text = sm.sedanModel;
            txtSedanModelId.Text = sm.sedanModelId;
            
            if (sm.statusEngineCC.Equals("1"))
            {
                chkMin2000cc.Checked = true;
            }
            else if (sm.sedanCatCar.Equals("2"))
            {
                chkMax2000cc.Checked = true;
            }
            if (sm.sedanModelActive.Equals("3"))
            {
                setControlDisAbled();
            }
            else
            {
                setControlEnAbled();
            }
            //cboTypeCust.Text = cic.smdb.selectCustomerTypeNameById(sm.sedanModelId);
        }
        private void getData()
        {
            sm.brandId = txtBrandId.Text;
            sm.brandName = cboBrand.Text;
            sm.price = txtSedanPrice.Text;
            sm.priceMax = txtSedanPriceMax.Text;
            sm.priceMin = txtSedanPriceMin.Text;
            //sm.sedanCatCar = txtAddress2.Text;
            if (chkCatCar1.Checked)
            {
                sm.sedanCatCar = "1";
            }
            else if (chkCatCar2.Checked)
            {
                sm.sedanCatCar = "2";
            }
            else if (chkCatCar3.Checked)
            {
                sm.sedanCatCar = "3";
            }
            else if (chkCatCar4.Checked)
            {
                sm.sedanCatCar = "4";
            }
            else if (chkCatCar5.Checked)
            {
                sm.sedanCatCar = "5";
            }
            sm.sedanEngineCC = txtEngineCC.Text;
            sm.sedanModel = txtSedanModel.Text;
            sm.sedanModelId = txtSedanModelId.Text;
            
            if (chkMin2000cc.Checked)
            {
                sm.statusEngineCC = "1";
            }
            else if (chkMax2000cc.Checked)
            {
                sm.statusEngineCC = "2";
            }
            
        }
        private void saveSedanModel()
        {
            getData();
            cic.smdb.insertSedanModel(sm);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Boolean chk = false;
            if (txtBrandId.Text.Equals(""))
            {
                MessageBox.Show("ยี่ห้อ ไม่ถูกต้อง กรุณาเลือกใหม่", "error");
                return;
            }
            if (cboBrand.Text.Equals(""))
            {
                MessageBox.Show("กรุณาป้อนยี่ห้อ", "error");
                return;
            }
            if (txtEngineCC.Text.Equals(""))
            {
                MessageBox.Show("กรุณาป้อน ขนาดเครื่องยนต์", "error");
                return;
            }
            if (txtSedanPriceMin.Text.Equals(""))
            {
                MessageBox.Show("กรุณาป้อน ราคาขั้นต่ำ", "error");
                return;
            }
            if (txtSedanPriceMax.Text.Equals(""))
            {
                MessageBox.Show("กรุณาป้อน ราคาขั้นสูง", "error");
                return;
            }
            if (txtSedanPrice.Text.Equals(""))
            {
                MessageBox.Show("กรุณาป้อน ราคากลาง", "error");
                return;
            }
            if (chkCatCar1.Checked)
            {
                chk = true;
            }
            if (chkCatCar2.Checked)
            {
                chk = true;
            }
            if (chkCatCar3.Checked)
            {
                chk = true;
            }
            if (chkCatCar4.Checked)
            {
                chk = true;
            }
            if (chkCatCar5.Checked)
            {
                chk = true;
            }
            if (!chk)
            {
                MessageBox.Show("กรุณาเลือก กลุ่มรถ", "error");
            }
            saveSedanModel();
        }

        private void txtEngineCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSedanPriceMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSedanPriceMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSedanPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cboBrand_Enter(object sender, EventArgs e)
        {
            cboBrand.BackColor = Color.LightYellow;
        }

        private void cboBrand_Leave(object sender, EventArgs e)
        {
            cboBrand.BackColor = Color.White;
        }

        private void txtSedanModel_Enter(object sender, EventArgs e)
        {
            txtSedanModel.BackColor = Color.LightYellow;
        }

        private void txtSedanModel_Leave(object sender, EventArgs e)
        {
            txtSedanModel.BackColor = Color.White;
        }

        private void txtEngineCC_Enter(object sender, EventArgs e)
        {
            txtEngineCC.BackColor = Color.LightYellow;
        }

        private void txtEngineCC_Leave(object sender, EventArgs e)
        {
            if (Double.Parse(txtEngineCC.Text) >= 2000)
            {
                chkMax2000cc.Checked = true;
            }
            else
            {
                chkMin2000cc.Checked = true;
            }
            txtEngineCC.BackColor = Color.White;
        }

        private void txtSedanPriceMin_Enter(object sender, EventArgs e)
        {
            txtSedanPriceMin.BackColor = Color.LightYellow;
        }

        private void txtSedanPriceMin_Leave(object sender, EventArgs e)
        {
            txtSedanPriceMin.BackColor = Color.White;
        }

        private void txtSedanPriceMax_Enter(object sender, EventArgs e)
        {
            txtSedanPriceMax.BackColor = Color.LightYellow;
        }

        private void txtSedanPriceMax_Leave(object sender, EventArgs e)
        {
            txtSedanPriceMax.BackColor = Color.White;
        }

        private void txtSedanPrice_Enter(object sender, EventArgs e)
        {
            txtSedanPrice.BackColor = Color.LightYellow;
        }

        private void txtSedanPrice_Leave(object sender, EventArgs e)
        {
            txtSedanPrice.BackColor = Color.White;
        }

        private void FrmSedanModelAdd_Load(object sender, EventArgs e)
        {

        }

        private void cboBrand_Click(object sender, EventArgs e)
        {
            
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = new ComboBoxItem();
            item = (ComboBoxItem)cboBrand.SelectedItem;
            txtBrandId.Text = item.Value;
        }

        private void btnUnActive_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ต้องการยกเลิกรายการ \n" + "ยี่ห้อ :" + cboBrand.Text, "ยกเลิกรายการ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cic.smdb.updateUnActive(txtSedanModelId.Text);
                this.Dispose();
            }
        }

        private void setControlDisAbled()
        {
            cboBrand.Enabled = false;
            txtSedanModel.Enabled = false;
            txtEngineCC.Enabled = false;
            groupBox2.Enabled = false;
            txtSedanPriceMin.Enabled = false;
            txtSedanPriceMax.Enabled = false;
            txtSedanPrice.Enabled = false;
            //btnPrint.Enabled = true;
            btnSave.Enabled = false;
            btnUnActive.Enabled = true;
        }
        private void setControlEnAbled()
        {
            cboBrand.Enabled = true;
            txtSedanModel.Enabled = true;
            txtEngineCC.Enabled = true;
            groupBox2.Enabled = true;
            txtSedanPriceMin.Enabled = true;
            txtSedanPriceMax.Enabled = true;
            txtSedanPrice.Enabled = true;
            //btnPrint.Enabled = true;
            btnSave.Enabled = true;
            btnUnActive.Enabled = false;
        }

        private void chkActive_Click(object sender, EventArgs e)
        {
            setControlEnAbled();
        }

        private void chkUnActive_Click(object sender, EventArgs e)
        {
            setControlDisAbled();
        }
    }
}
