using carInsuranceInit.control;
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
    public partial class FrmWriteText : Form
    {
        CarIControl cic;
        private void initConfig()
        {
            //cic = new CarIControl();
        }
        public FrmWriteText(CarIControl c)
        {
            InitializeComponent();
            cic = c;
            initConfig();
            setTab();
        }
        private void setResize()
        {
            tab1.Width = this.Width - 40;
            tab1.Height = this.Height - 70;
        }
        private void setTab()
        {
            tab1.TabPages[0].Text = "ข้อมูลรถยนต์";
            tab1.TabPages[1].Text = "ข้อมูลกระบะ 210";
            tab1.TabPages[2].Text = "ข้อมูลกระบะ320";
            tab1.TabPages[3].Text = "ข้อมูลรถตู้";
            tab1.TabPages[4].Text = "เตรียมข้อมูล";
        }
        private void FrmWriteText_Load(object sender, EventArgs e)
        {
            setResize();
        }

        private void btnWriteText_Click(object sender, EventArgs e)
        {
            String tInsur = "";
            //if (chkTInsur1.Checked)
            //{
            //    tInsur = "1";
            //}
            //else if (chkTInsur2.Checked)
            //{
            //    tInsur = "2";
            //}
            //else if (chkTInsur2.Checked)
            //{
            //    tInsur = "3";
            //}
            //if (tInsur.Equals(""))
            //{
            //    MessageBox.Show("กรุณาเลือกประกันประเภท ", "error");
            //    return;
            //}
            labelSedanAgeCar.Text = cic.writeSedanAgeCar();
            labelSedanAgeDriver.Text = cic.writeSedanAgeDriver();
            labelSedanCapitalInsur.Text = cic.writeSedanCapitalInsur();
            labelSedanCatCar.Text = cic.writeSedanCatCar();
            labelSedanEngineCC.Text = cic.writeSedanEngineCC();
            labelSedanInjuryAsset.Text = cic.writeSedanInjuryAsset();
            labelSedanInjuryPerson.Text = cic.writeSedanInjuryPerson();
            labelSedanInjuryTime.Text = cic.writeSedanInjuryTime();
            labelSedanUseCar.Text = cic.writeSedanUseCar();
            labelSedanPa.Text = cic.writeSedanPa();
            labelSedanMe.Text = cic.writeSedanMe();
            //cic.writeSedanEngineCC();
            //cic.writeSedanUseCar();
            labelBrand.Text= cic.writeBrand();
        }
    }
}
