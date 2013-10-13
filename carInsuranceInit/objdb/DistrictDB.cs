using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class DistrictDB
    {
        private ConnectDB conn;
        public District dist;
        public Amphur amph;
        public Province prov;
        public DistrictDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            prov = new Province();
            amph = new Amphur();
            dist = new District();
            dist.amphurId = "amphur_id";
            dist.districtCode = "district_code";
            dist.districtId = "districe_id";
            dist.districtName = "district_name";
            dist.geoId = "geo_id";
            dist.provinceId = "province_id";
            dist.zipcode = "zipcode";
            dist.amphurName = "AMPHUR_NAME";
            dist.provinceName = "PROVINCE_NAME";
            dist.pkField = "districe_id";
            dist.sited = "";
            dist.table = "f_districts";
        }
        public DataTable selectDistrictAll()
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + dist.table + "  Order By " + dist.districtName;
            dt = conn.selectData(sql);

            return dt;
        }
        public District selectDistrict(String provId, String amphId)
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            District item = new District();
            sql = "Select * From " + dist.table + 
                " Whrere "+dist.amphurId+" ="+amphId+" and "+dist.provinceId+" ="+provId+
                " Order By " + dist.districtName;
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item.amphurId = dt.Rows[0][dist.amphurId].ToString();
                item.districtCode = dt.Rows[0][dist.districtCode].ToString();
                item.districtId = dt.Rows[0][dist.districtCode].ToString();
                item.districtName = dt.Rows[0][dist.districtCode].ToString();
                item.geoId = dt.Rows[0][dist.districtCode].ToString();
                item.provinceId = dt.Rows[0][dist.districtCode].ToString();
                item.zipcode = dt.Rows[0][dist.districtCode].ToString();
                
            }
            return item;
        }
        public DataTable selectDistrict(String distName)
        {
            String sql = "", row = "";
            DataTable dt = new DataTable();
            sql = "Select dist.*, amph.AMPHUR_NAME, prov.PROVINCE_NAME From (" + dist.table + " dist " +
                "Left Join f_amphures amph on amph.AMPHUR_ID = dist." + dist.amphurId + ") " +
                "Left Join f_provinces  prov on prov.PROVINCE_ID = dist." + dist.provinceId + " " +
                "Where dist." + dist.districtName + " like '" + distName + "%' "+
                "Order By dist." + dist.districtName;
            dt = conn.selectData(sql);

            return dt;
        }
        public ComboBox getCboDistrict(ComboBox c, String distName)
        {
            //ComboBox c = new ComboBox();
            
            c.Items.Clear();
            c.Items.Add(distName);
            
            DataTable dt = selectDistrict(distName);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                c.Items.Add(dt.Rows[i][dist.districtName].ToString() + "/" + dt.Rows[i][dist.amphurName].ToString() + "/" + dt.Rows[i][dist.provinceName].ToString());
            }
            c.SelectionStart = c.Text.Length;
            c.DroppedDown = true;
            return c;
        }
    }
}
