using carInsuranceInit.objdb;
using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.control
{
    class CarIControl
    {
        ConnectDB conn;
        public SedanUseCarDB sucdb;
        public SedanEngineCCDB secdb;
        public SedanAgeCarDB sacdb;
        public SedanAgeDriverDB saddb;
        public SedanCapitalInsurDB scidb;
        public SedanCatCarDB sccdb;
        public SedanInjuryPersonDB sipdb;
        public SedanInjuryTimeDB sitdb;
        public SedanInjuryAssetDB siadb;

        SedanUseCar suc;
        SedanEngineCC sec;
        SedanAgeCar sac;
        SedanAgeDriver sad;
        SedanCapitalInsur sci;
        SedanCatCar scc;
        SedanInjuryPerson sip;
        SedanInjuryTime sit;
        SedanInjuryAsset sia;

        public CarIControl()
        {
            initConfig();
        }
        private void initConfig()
        {
            conn = new ConnectDB();

            suc = new SedanUseCar();
            sec = new SedanEngineCC();
            sac = new SedanAgeCar();
            sad = new SedanAgeDriver();

            sci = new SedanCapitalInsur();
            scc = new SedanCatCar();
            sip = new SedanInjuryPerson();
            sit = new SedanInjuryTime();
            sia = new SedanInjuryAsset();

            sucdb = new SedanUseCarDB(conn);
            secdb = new SedanEngineCCDB(conn);
            sacdb = new SedanAgeCarDB(conn);
            saddb = new SedanAgeDriverDB(conn);

            scidb = new SedanCapitalInsurDB(conn);
            sccdb = new SedanCatCarDB(conn);
            sipdb = new SedanInjuryPersonDB(conn);
            sitdb = new SedanInjuryTimeDB(conn);
            siadb = new SedanInjuryAssetDB(conn);
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
    }
}
