using carInsuranceInit.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInsuranceInit.gui
{
    public partial class FrmMain : Form
    {
        private CarIControl cic;
        public FrmMain()
        {
            InitializeComponent();
            cic = new CarIControl();
        }
        private void showFrame(Form f)
        {
            this.Hide();
            f.ShowDialog(this);
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Last Update " + System.IO.File.GetLastWriteTime(System.Environment.CurrentDirectory + "\\" + Process.GetCurrentProcess().ProcessName + ".exe");
        }

        private void tv1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node.Name.ToString() == "nSedanUseCar")
            {
                FrmSedanUseCar frm = new FrmSedanUseCar(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanEngineCC")
            {
                FrmSedanEngineCC frm = new FrmSedanEngineCC(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanAgeDriver")
            {
                FrmSedanAgeDriver frm = new FrmSedanAgeDriver(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanAgeCar")
            {
                FrmSedanAgeCar frm = new FrmSedanAgeCar(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanCapitalInsur")
            {
                FrmSedanCapitalInsur frm = new FrmSedanCapitalInsur(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanCatCar")
            {
                FrmSedanCatCar frm = new FrmSedanCatCar(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryPerson")
            {
                FrmSedanInjuryPerson frm = new FrmSedanInjuryPerson(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryTime")
            {
                FrmSedanInjuryTime frm = new FrmSedanInjuryTime(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryAsset")
            {
                FrmSedanInjuryAsset frm = new FrmSedanInjuryAsset(cic);
                showFrame(frm);
            }
            
            else if (e.Node.Name.ToString() == "nWriteText")
            {
                FrmWriteText frm = new FrmWriteText(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nBrand")
            {
                FrmBrand frm = new FrmBrand(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanModel")
            {
                FrmSedanModelView frm = new FrmSedanModelView(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanPa")
            {
                FrmSedanPa frm = new FrmSedanPa(cic);
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanMe")
            {
                FrmSedanMe frm = new FrmSedanMe(cic);
                showFrame(frm);
            }
        }
        private void setResize()
        {
            tv1.Width = this.Width - 50;
            tv1.Height = this.Height - 80;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            setResize();
        }
    }
}
