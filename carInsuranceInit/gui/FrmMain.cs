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
        public FrmMain()
        {
            InitializeComponent();
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
                FrmSedanUseCar frm = new FrmSedanUseCar();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanEngineCC")
            {
                FrmSedanEngineCC frm = new FrmSedanEngineCC();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanAgeDriver")
            {
                FrmSedanAgeDriver frm = new FrmSedanAgeDriver();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanAgeCar")
            {
                FrmSedanAgeCar frm = new FrmSedanAgeCar();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanCapitalInsur")
            {
                FrmSedanCapitalInsur frm = new FrmSedanCapitalInsur();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanCatCar")
            {
                FrmSedanCatCar frm = new FrmSedanCatCar();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryPerson")
            {
                FrmSedanInjuryPerson frm = new FrmSedanInjuryPerson();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryTime")
            {
                FrmSedanInjuryTime frm = new FrmSedanInjuryTime();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanInjuryAsset")
            {
                FrmSedanInjuryAsset frm = new FrmSedanInjuryAsset();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanRY01")
            {
                FrmSedanRY01 frm = new FrmSedanRY01();
                showFrame(frm);
            }
            else if (e.Node.Name.ToString() == "nSedanRY02")
            {
                FrmSedanRY02 frm = new FrmSedanRY02();
                showFrame(frm);
            }
            
        }
    }
}
