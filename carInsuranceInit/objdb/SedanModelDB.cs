using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class SedanModelDB
    {
        private ConnectDB conn;
        public SedanModel sm;
        public SedanModelDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sm = new SedanModel();
            sm.brandId = "brand_id";
            sm.brandName = "brand_name";
            sm.price = "price";
            sm.priceMax = "price_min";
            sm.priceMin = "price_max";
            sm.sedanCatCar = "sedan_cat_car";
            sm.sedanEngineCC = "sedan_engine_cc";
            sm.sedanModel = "sedan_model_name";
            sm.sedanModelId = "sedan_model_id";
            sm.statusEngineCC = "status_engine_cc";
            sm.sedanModelActive = "sedan_model_active";

            sm.sited = "";
            sm.table = "sedan_model";
            sm.pkField = "sedan_model_id";
        }
        private SedanModel setData(SedanModel item, DataTable dt)
        {
            item.brandId = dt.Rows[0][sm.brandId].ToString();
            item.brandName = dt.Rows[0][sm.brandName].ToString();
            item.price = dt.Rows[0][sm.price].ToString();
            item.priceMax = dt.Rows[0][sm.priceMax].ToString();
            item.priceMin = dt.Rows[0][sm.priceMin].ToString();
            item.sedanCatCar = dt.Rows[0][sm.sedanCatCar].ToString();

            item.sedanEngineCC = dt.Rows[0][sm.sedanEngineCC].ToString();
            item.sedanModel = dt.Rows[0][sm.sedanModel].ToString();
            item.sedanModelId = dt.Rows[0][sm.sedanModelId].ToString();
            item.statusEngineCC = dt.Rows[0][sm.statusEngineCC].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sm.table + " Where " + sm.sedanModelActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanModel selectByPk(String sadId)
        {
            SedanModel item = new SedanModel();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sm.table + " Where " + sm.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanModel p)
        {
            String sql = "", chk = "";
            if (p.sedanModelId.Equals(""))
            {
                p.sedanModelId = p.getGenID();
            }
            if (p.sedanModelActive.Equals(""))
            {
                p.sedanModelActive = "1";
            }
            p.sedanModel = p.sedanModel.Replace("''", "'");
            p.price = p.price.Replace(",", "");
            p.priceMax = p.priceMax.Replace(",", "");
            p.priceMin = p.priceMin.Replace(",", "");

            sql = "Insert Into " + sm.table + " (" + sm.pkField + "," + sm.brandId + "," +
                sm.price + "," + sm.priceMax + "," + sm.priceMin + "," +
                sm.sedanCatCar + "," + sm.sedanEngineCC + "," + sm.sedanModel + "," +
                sm.statusEngineCC+","+sm.brandName + ") " +
                "Values('" + p.sedanModelId + "','" + p.brandId + "','" +
                p.price + "','" + p.priceMax + "','" + p.priceMin + "','" +
                p.sedanCatCar + "','" + p.sedanEngineCC + "','" + p.sedanModel + "','" +
                p.statusEngineCC+"','"+p.brandName + "') ";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanModelId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert SedanModel");
            }
            finally
            {
            }
            return chk;
        }
        private String update(SedanModel p)
        {
            String sql = "", chk = "";

            p.sedanModel = p.sedanModel.Replace("''", "'");
            p.price = p.price.Replace(",", "");
            p.priceMax = p.priceMax.Replace(",", "");
            p.priceMin = p.priceMin.Replace(",", "");

            sql = "Update " + sm.table + " Set " + sm.sedanModel + "='" + p.sedanModel + "'," +
                sm.brandId + "='" + p.brandId + "'," +
                sm.price + "='" + p.price + "'," +
                sm.priceMin + "='" + p.priceMin + "', " +
                sm.sedanCatCar + "='" + p.sedanCatCar + "', " +
                sm.sedanEngineCC + "='" + p.sedanEngineCC + "', " +
                //sm.sedanModel + "='" + p.sedanModel + "', " +
                sm.statusEngineCC + "='" + p.statusEngineCC + "', " +
                sm.brandName + "='" + p.brandName + "' " +
                "Where " + sm.pkField + "='" + p.sedanModelId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update SedanModel");
            }
            finally
            {
            }
            return chk;
        }
        public String insertSedanModel(SedanModel p)
        {
            SedanModel item = new SedanModel();
            String chk = "";
            item = selectByPk(p.sedanModelId);
            if (item.sedanModelId == "")
            {
                //p.statusDeposit = "0";
                //p.statusRecp = "1";
                chk = insert(p);
            }
            else
            {
                chk = update(p);
            }
            return chk;
        }
        public String deleteAll()
        {
            String sql = "", chk = "";
            sql = "Delete From " + sm.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sm.table + " Set " + sm.sedanModelActive + "='3' "+
                "Where "+sm.sedanModelId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
