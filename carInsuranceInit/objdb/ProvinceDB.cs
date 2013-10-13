using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.objdb
{
    class ProvinceDB
    {
        private ConnectDB conn;
        public Province prov;
        public ProvinceDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        public void initConfig()
        {
            prov = new Province();
            prov.geoId = "geo_id";
            prov.provinceCode = "province_code";
            prov.provinceId = "province_id";
            prov.provinceName = "province_name";
            prov.sited = "";
            prov.table = "f_province";
            prov.pkField = "province_id";
        }
        public DataTable selectProvince()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + prov.table + "  Order By " + prov.provinceName;
            dt = conn.selectData(sql);

            return dt;
        }
    }
}
