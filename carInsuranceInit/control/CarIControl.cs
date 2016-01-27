using carInsuranceInit.objdb;
using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInsuranceInit.control
{
    public class CarIControl
    {
        public Config1 cf;
        String pathFileSedan =System.Environment.CurrentDirectory + "\\asset\\110\\";
        String pathFilePickUp210 = System.Environment.CurrentDirectory + "\\asset\\210\\";
        String pathFilePickUp320 = System.Environment.CurrentDirectory + "\\asset\\320\\";
        ConnectDB conn;//
        public SedanUseCarDB sucdb;
        public SedanEngineCCDB secdb;
        public SedanAgeCarDB sacdb;
        public SedanAgeDriverDB saddb;
        public SedanCapitalInsurDB scidb;
        public SedanCatCarDB sccdb;
        public SedanInjuryPersonDB sipdb;
        public SedanInjuryTimeDB sitdb;
        public SedanInjuryAssetDB siadb;
        public BrandDB branddb;
        public SedanPaDB spadb;
        public SedanMeDB smedb;
        public SedanModelDB smdb;

        SedanUseCar suc;
        SedanEngineCC sec;
        SedanAgeCar sac;
        SedanAgeDriver sad;
        SedanCapitalInsur sci;
        SedanCatCar scc;
        SedanInjuryPerson sip;
        SedanInjuryTime sit;
        SedanInjuryAsset sia;
        Brand brand;
        SedanPa spa;
        SedanMe sme;
        SedanModel sm;

        WriteText wt;
        public InitConfig initC;
        private IniFile iniFile;
        public CarIControl()
        {
            initConfig();
        }
        private void initConfig()
        {
            iniFile = new IniFile(Environment.CurrentDirectory + "\\" + Application.ProductName + ".ini");
            initC = new InitConfig();
            GetConfig();
            cf = new Config1();
            conn = new ConnectDB(initC);
            wt = new WriteText();

            suc = new SedanUseCar();
            sec = new SedanEngineCC();
            sac = new SedanAgeCar();
            sad = new SedanAgeDriver();

            sci = new SedanCapitalInsur();
            scc = new SedanCatCar();
            sip = new SedanInjuryPerson();
            sit = new SedanInjuryTime();
            sia = new SedanInjuryAsset();

            brand = new Brand();

            spa = new SedanPa();
            sme = new SedanMe();
            sm = new SedanModel();

            sucdb = new SedanUseCarDB(conn);
            secdb = new SedanEngineCCDB(conn);
            sacdb = new SedanAgeCarDB(conn);
            saddb = new SedanAgeDriverDB(conn);

            scidb = new SedanCapitalInsurDB(conn);
            sccdb = new SedanCatCarDB(conn);
            sipdb = new SedanInjuryPersonDB(conn);
            sitdb = new SedanInjuryTimeDB(conn);
            siadb = new SedanInjuryAssetDB(conn);

            branddb = new BrandDB(conn);

            spadb = new SedanPaDB(conn);
            smedb = new SedanMeDB(conn);
            smdb = new SedanModelDB(conn);

            
        }
        public void GetConfig()
        {
            initC.clearInput = iniFile.Read("clearinput");
            initC.connectDatabaseServer = iniFile.Read("connectdatabaseserver");
            initC.ServerIP = iniFile.Read("host");
            initC.User = iniFile.Read("username");
            initC.Password = iniFile.Read("password");

            initC.pathImageLogo = iniFile.Read("pathimagelogo");
            
            initC.PathReport = iniFile.Read("pathreport");

            initC.Database = iniFile.Read("database");
            //initC.connectServer = regE.getConnectServer();
            //initC.ServerIP = regE.getServerIP();
            //initC.User = regE.getUsername();
            //initC.Password = regE.getPassword();
        }
        public SedanUseCar selectSedanUsecar()
        {
            suc = sucdb.selectAll();
            return suc;
        }
        public SedanEngineCC selectSedanEngineCC()
        {
            sec = secdb.selectAll();
            return sec;
        }
        public DataTable selectSedanAgeCar()
        {
            DataTable dt = sacdb.selectAll();
            return dt;
        }
        public DataTable selectSedanAgeDriver()
        {
            DataTable dt = saddb.selectAll();
            return dt;
        }
        public DataTable selectSedanCapitalInsur()
        {
            DataTable dt = scidb.selectAll();
            return dt;
        }
        public DataTable selectSedanCatCar()
        {
            DataTable dt = sccdb.selectAll();
            return dt;
        }
        public DataTable selectSedanInjuryPerson()
        {
            DataTable dt = sipdb.selectAll();
            return dt;
        }
        public DataTable selectSedanInjuryTime()
        {
            DataTable dt = sitdb.selectAll();
            return dt;
        }
        public DataTable selectSedanInjuryAsset()
        {
            DataTable dt = siadb.selectAll();
            return dt;
        }
        public DataTable selectBrand()
        {
            DataTable dt = branddb.selectAll();
            return dt;
        }
        public DataTable selectSedanMe()
        {
            DataTable dt = smedb.selectAll();
            return dt;
        }
        public DataTable selectSedanPa()
        {
            DataTable dt = spadb.selectAll();
            return dt;
        }
        public DataTable selectSedanModel()
        {
            DataTable dt = smdb.selectAll();
            return dt;
        }

        public String saveSedanUseCar(SedanUseCar p)
        {
            String chk = "";
            chk = sucdb.update(p);
            return chk;
        }
        public String saveSedanEngineCC(SedanEngineCC p)
        {
            String chk = "";
            chk = secdb.update(p);
            return chk;
        }
        public String saveSedanAgeCar(SedanAgeCar p)
        {
            String chk = "";
            chk = sacdb.insertSedanAgeCar(p);
            return chk;
        }
        public String saveSedanAgeDriver(SedanAgeDriver p)
        {
            String chk = "";
            chk = saddb.insertSedanAgeDriver(p);
            return chk;
        }
        public String saveSedanCapitalInsur(SedanCapitalInsur p)
        {
            String chk = "";
            chk = scidb.insertSedanCapitalInsur(p);
            return chk;
        }
        public String saveSedanCatCat(SedanCatCar p)
        {
            String chk = "";
            chk = sccdb.insertSedanCatCar(p);
            return chk;
        }
        public String saveSedanInjuryPerson(SedanInjuryPerson p)
        {
            String chk = "";
            chk = sipdb.insertSedanInjuryPerson(p);
            return chk;
        }
        public String saveSedanInjuryTime(SedanInjuryTime p)
        {
            String chk = "";
            chk = sitdb.insertSedanInjuryTime(p);
            return chk;
        }
        public String saveSedanInjuryAsset(SedanInjuryAsset p)
        {
            String chk = "";
            chk = siadb.insertSedanInjuryAsset(p);
            return chk;
        }
        public String saveBrand(Brand p)
        {
            String chk = "";
            chk = branddb.insertBrand(p);
            return chk;
        }
        public String saveSedanPa(SedanPa p)
        {
            String chk = "";
            chk = spadb.insertSedanPa(p);
            return chk;
        }
        public String saveSedanMe(SedanMe p)
        {
            String chk = "";
            chk = smedb.insertSedanMe(p);
            return chk;
        }
        public String saveSedanModel(SedanModel p)
        {
            String chk = "";
            chk = smdb.insertSedanModel(p);
            return chk;
        }

        public String writeSedanAgeCar()
        {
            String data="",chk="";
            DataTable dt;
            dt = sacdb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][sacdb.sac.sedanAgeCar].ToString().Trim() + "\t" + dt.Rows[i][sacdb.sac.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][sacdb.sac.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][sacdb.sac.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan,"CarAge.txt", data))
            {
                chk = "จำนวนข้อมูล อายุรถเก๋งทั้งหมด "+dt.Rows.Count+" รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanAgeDriver()
        {
            String data = "", chk="";
            DataTable dt;
            dt = saddb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][saddb.sad.sedanAgeDriver].ToString().Trim() + "\t" + dt.Rows[i][saddb.sad.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][saddb.sad.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][saddb.sad.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "DriverAge.txt", data))
            {
                chk = "จำนวนข้อมูล อายุผู้ขับขี่ทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanCapitalInsur()
        {
            String data = "", chk="";
            DataTable dt;
            dt = scidb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][scidb.sci.sedanCapitalInsur].ToString().Trim() + "\t" + dt.Rows[i][scidb.sci.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][scidb.sci.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][scidb.sci.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "CarInsur.txt", data))
            {
                chk = "จำนวนข้อมูล ทุนประกันทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanCatCar()
        {
            String data = "", chk="";
            DataTable dt;
            dt = sccdb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][sccdb.scc.sedanCatCar].ToString().Trim() + "\t" + dt.Rows[i][sccdb.scc.Rate].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "groupCar.txt", data))
            {
                chk = "จำนวนข้อมูล กลุ่มรถเก่งทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanEngineCC()
        {
            String data = "", chk="";
            SedanEngineCC sec;
            sec = secdb.selectAll();
            data = "2000" + sec.sedanEngine2000CCMinTInsur1 + "\t" + sec.sedanEngine2000CCMinTInsur2 + "\t" + sec.sedanEngine2000CCMinTInsur3;
            data += "2001" + sec.sedanEngine2000CCMaxTInsur1 + "\t" + sec.sedanEngine2000CCMaxTInsur2 + "\t" + sec.sedanEngine2000CCMaxTInsur3;
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "MotorCar.txt", data))
            {
                chk = "เขียน Text File SedanEngineCC เรียบร้อย";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanUseCar()
        {
            String data = "", chk="";
            SedanUseCar suc;
            suc = sucdb.selectAll();
            data = "110\t" + suc.sedanUseCar110TInsur1 + "\t" + suc.sedanUseCar110TInsur2 + "\t" + suc.sedanUseCar110TInsur3;
            data += "210\t" + suc.sedanUseCar110TInsur1 + "\t" + suc.sedanUseCar110TInsur2 + "\t" + suc.sedanUseCar110TInsur3;
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "\\ModeCar.txt", data))
            {
                chk = "เขียน Text File SedanUseCar เรียบร้อย";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanInjuryAsset()
        {
            String data = "", chk="";
            DataTable dt;
            dt = siadb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][siadb.sia.sedanInjuryAsset].ToString().Trim() + "\t" + dt.Rows[i][siadb.sia.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][siadb.sia.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][siadb.sia.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "damageproperty.txt", data))
            {
                chk = "จำนวนข้อมูล บาดเจ็บต่อทรัพย์สิน ทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanInjuryPerson()
        {
            String data = "", chk="";
            DataTable dt;
            dt = sipdb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][sipdb.sip.sedanInjuryPerson].ToString().Trim() + "\t" + dt.Rows[i][sipdb.sip.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][sipdb.sip.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "damageperson.txt", data))
            {
                chk = "จำนวนข้อมูล บาดเจ็บต่อบุคคล ทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanInjuryTime()
        {
            String data = "", chk="";
            DataTable dt;
            dt = sitdb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][sitdb.sit.sedanInjuryTime].ToString().Trim() + "\t" + dt.Rows[i][sitdb.sit.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][sitdb.sit.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][sitdb.sit.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan , "damageacient.txt", data))
            {
                chk = "จำนวนข้อมูล บาดเจ็บต่อครั้ง ทั้งหมด " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeBrand()
        {
            String data = "", chk = "";
            DataTable dt;
            dt = sccdb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][sccdb.scc.sedanCatCar].ToString().Trim() + "\t" + dt.Rows[i][sccdb.scc.Rate].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan, "CarBrand.txt", data))
            {
                chk = "จำนวนข้อมูล ME " + dt.Rows.Count + " รายการ ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanPa()
        {
            String data = "", chk = "";
            DataTable dt;
            dt = spadb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][spadb.spa.sedanPa].ToString().Trim() + "\t" + dt.Rows[i][spadb.spa.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][spadb.spa.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][spadb.spa.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan, "pa.txt", data))
            {
                chk = "จำนวนข้อมูล PA เรียบร้อย ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        public String writeSedanMe()
        {
            String data = "", chk = "";
            DataTable dt;
            dt = smedb.selectAll();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += dt.Rows[i][smedb.sme.sedanMe].ToString().Trim() + "\t" + dt.Rows[i][smedb.sme.RateTInsur1].ToString().Trim() + "\t" + dt.Rows[i][smedb.sme.RateTInsur2].ToString().Trim() + "\t" + dt.Rows[i][smedb.sme.RateTInsur3].ToString().Trim() + Environment.NewLine;
            }
            //pathFileSedan = setPathFile(pathFileSedan);
            if (wt.writeTxt(pathFileSedan, "me.txt", data))
            {
                chk = "จำนวนข้อมูล ME เรียบร้อย ";
                //MessageBox.Show("", "เขียน Text File  เรียบร้อย");
            }
            return chk;
        }
        //private String setPathFile(String tInsur)
        //{
        //    String path = "";
        //    if (tInsur.Equals("1"))
        //    {
        //        path = pathFileSedan + "\\110\\";
        //    }
        //    else if (tInsur.Equals("2"))
        //    {
        //        path = pathFileSedan + "\\210\\";
        //    }
        //    else if (tInsur.Equals("3"))
        //    {
        //        path = pathFileSedan + "\\320\\";
        //    }
        //    return path;
        //}
    }
}