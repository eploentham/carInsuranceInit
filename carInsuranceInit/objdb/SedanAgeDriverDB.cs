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
    class SedanAgeDriverDB
    {
        private ConnectDB conn;
        public SedanAgeDriver sad;
        public SedanAgeDriverDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sad = new SedanAgeDriver();
            sad.RateTInsur1 = "rate_t_insur1";
            sad.RateTInsur2 = "rate_t_insur2";
            sad.RateTInsur3 = "rate_t_insur3";
            sad.sedanAgeDriver = "sedan_age_driver";
            sad.sedanAgeDriverId = "sedan_age_driver_id";
            sad.sedanAgeDriverActive = "sedan_age_driver_active";

            sad.sited = "";
            sad.table = "sedan_age_driver";
            sad.pkField = "sedan_age_driver_id";
        }
        private SedanAgeDriver setData(SedanAgeDriver item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sad.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sad.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sad.RateTInsur3].ToString();

            item.sedanAgeDriver = dt.Rows[0][sad.sedanAgeDriver].ToString();
            item.sedanAgeDriverId = dt.Rows[0][sad.sedanAgeDriverId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sad.table + " Where " + sad.sedanAgeDriverActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanAgeDriver selectByPk(String sadId)
        {
            SedanAgeDriver item = new SedanAgeDriver();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sad.table + " Where " + sad.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanAgeDriver p)
        {
            String sql = "", chk = "";
            if (p.sedanAgeDriverId.Equals(""))
            {
                p.sedanAgeDriverId = p.getGenID();
            }
            if (p.sedanAgeDriverActive.Equals(""))
            {
                p.sedanAgeDriverActive = "1";
            }
            p.sedanAgeDriver = p.sedanAgeDriver.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sad.table + " (" + sad.pkField + "," + sad.sedanAgeDriver + "," +
                sad.RateTInsur1 + "," + sad.RateTInsur2 + "," + sad.RateTInsur3+","+
                sad.sedanAgeDriverActive + ") " +
                "Values('" + p.sedanAgeDriverId + "','" + p.sedanAgeDriver + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3+"','"+
                p.sedanAgeDriverActive + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanAgeDriverId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert SedanAgeDriver");
            }
            finally
            {
            }
            return chk;
        }
        private String update(SedanAgeDriver p)
        {
            String sql = "", chk = "";

            p.sedanAgeDriver = p.sedanAgeDriver.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sad.table + " Set " + sad.sedanAgeDriver + "='" + p.sedanAgeDriver + "'," +
                sad.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sad.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sad.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sad.pkField + "='" + p.sedanAgeDriverId + "'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "update SedanAgeCar");
            }
            finally
            {
            }
            return chk;
        }
        public String insertSedanAgeDriver(SedanAgeDriver p)
        {
            SedanAgeDriver item = new SedanAgeDriver();
            String chk = "";
            item = selectByPk(p.sedanAgeDriverId);
            if (item.sedanAgeDriverId == "")
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
            sql = "Delete From " + sad.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sad.table + " Set " + sad.sedanAgeDriverActive + "='3' "+
                "Where "+sad.sedanAgeDriverId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
