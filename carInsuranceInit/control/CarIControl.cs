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

        SedanUseCar suc;
        SedanEngineCC sec;
        SedanAgeCar sac;
        SedanAgeDriver sad;

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

            sucdb = new SedanUseCarDB(conn);
            secdb = new SedanEngineCCDB(conn);
            sacdb = new SedanAgeCarDB(conn);
            saddb = new SedanAgeDriverDB(conn);
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
    }
}
