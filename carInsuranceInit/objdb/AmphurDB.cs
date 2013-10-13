using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.objdb
{
    class AmphurDB
    {
        private ConnectDB conn;
        public Amphur amph;
        public AmphurDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            amph = new Amphur();
            amph.amphurCode = "amphur_code";
            amph.amphurId = "amphur_id";
            amph.amphurName = "amphur_name";
            amph.geoId = "geo_id";
            amph.provinceId = "province_id";
            amph.pkField = "amphur_id";
            amph.sited = "";
            amph.table = "f_amphur";
        }
        public DataTable selectAmphurAll()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + amph.table + "  Order By " + amph.amphurName;
            dt = conn.selectData(sql);

            return dt;
        }
    }
}
