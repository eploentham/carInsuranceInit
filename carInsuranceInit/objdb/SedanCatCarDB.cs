using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    public class SedanCatCarDB
    {
        private ConnectDB conn;
        public SedanCatCar scc;
        public SedanCatCarDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            scc = new SedanCatCar();
            scc.Rate = "rate";
            scc.sedanCatCar = "sedan_cat_car";
            scc.sedanCatCarId = "sedan_cat_car_id";

            scc.table = "sedan_cat_car";
            scc.sited = "";
            scc.pkField = "sedan_cat_car_id";
        }
        private SedanCatCar setData(SedanCatCar item, DataTable dt)
        {
            item.Rate = dt.Rows[0][scc.Rate].ToString();


            item.sedanCatCar = dt.Rows[0][scc.sedanCatCar].ToString();
            item.sedanCatCarId = dt.Rows[0][scc.sedanCatCarId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + scc.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanCatCar selectByPk(String sadId)
        {
            SedanCatCar item = new SedanCatCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + scc.table + " Where " + scc.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanCatCar p)
        {
            String sql = "", chk = "";
            if (p.sedanCatCarId.Equals(""))
            {
                p.sedanCatCarId = p.getGenID();
            }
            p.sedanCatCar = p.sedanCatCar.Replace("''", "'");
            p.Rate = p.Rate.Replace(",", "");


            sql = "Insert Into " + scc.table + " (" + scc.pkField + "," + scc.sedanCatCar + "," +
                scc.Rate + ") " +
                "Values('" + p.sedanCatCarId + "','" + p.sedanCatCar + "','" +
                p.Rate + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanCatCarId;
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
        private String update(SedanCatCar p)
        {
            String sql = "", chk = "";

            p.sedanCatCar = p.sedanCatCar.Replace("''", "'");
            p.Rate = p.Rate.Replace(",", "");


            sql = "Update " + scc.table + " Set " + scc.sedanCatCar + "='" + p.sedanCatCar + "'," +
                scc.Rate + "='" + p.Rate + "' " +

                "Where " + scc.pkField + "='" + p.sedanCatCarId + "'";
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
        public String insertSedanCatCar(SedanCatCar p)
        {
            SedanCatCar item = new SedanCatCar();
            String chk = "";
            item = selectByPk(p.sedanCatCarId);
            if (item.sedanCatCarId == "")
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
            sql = "Delete From " + scc.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
