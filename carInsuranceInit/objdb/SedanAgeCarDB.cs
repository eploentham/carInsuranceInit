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
    class SedanAgeCarDB
    {
        private ConnectDB conn;
        public SedanAgeCar sac;
        public SedanAgeCarDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sac = new SedanAgeCar();
            sac.RateTInsur1 = "rate_t_insur1";
            sac.RateTInsur2 = "rate_t_insur2";
            sac.RateTInsur3 = "rate_t_insur3";
            sac.sedanAgeCar = "sedan_age_car";
            sac.sedanAgeCarId = "sedan_age_car_id";

            sac.sited = "";
            sac.table = "sedan_age_car";
            sac.pkField = "sedan_age_car_id";
        }
        private SedanAgeCar setData(SedanAgeCar item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sac.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sac.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sac.RateTInsur3].ToString();

            item.sedanAgeCar = dt.Rows[0][sac.sedanAgeCar].ToString();
            item.sedanAgeCarId = dt.Rows[0][sac.sedanAgeCarId].ToString();
            
            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sac.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanAgeCar selectByPk(String sacId)
        {
            SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sac.table + " Where " + sac.pkField + "='" + sacId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(SedanAgeCar p)
        {
            String sql = "", chk = "";
            if (p.sedanAgeCarId.Equals(""))
            {
                p.sedanAgeCarId = p.getGenID();
            }
            p.sedanAgeCar = p.sedanAgeCar.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into "+sac.table+" ("+sac.pkField+","+sac.sedanAgeCar+","+
                sac.RateTInsur1+","+sac.RateTInsur2+","+sac.RateTInsur3+") "+
                "Values('"+p.sedanAgeCarId+"','"+p.sedanAgeCar+"','"+
                p.RateTInsur1+"','"+p.RateTInsur2+"','"+p.RateTInsur3+"')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanAgeCarId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "insert SedanAgeCar");
            }
            finally
            {
            }
            return chk;
        }
        private String update(SedanAgeCar p)
        {
            String sql = "", chk = "";

            p.sedanAgeCar = p.sedanAgeCar.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update "+sac.table+" Set "+ sac.sedanAgeCar+"='"+p.sedanAgeCar+"',"+
                sac.RateTInsur1+"='"+p.RateTInsur1+"',"+
                sac.RateTInsur2+"='"+p.RateTInsur2+"',"+
                sac.RateTInsur3+"='"+p.RateTInsur3+"' "+
                "Where "+sac.pkField+"='"+p.sedanAgeCarId+"'";
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
        public String insertSedanAgeCar(SedanAgeCar p)
        {
            SedanAgeCar item = new SedanAgeCar();
            String chk = "";
            item = selectByPk(p.sedanAgeCarId);
            if (item.sedanAgeCarId == "")
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
            sql = "Delete From " + sac.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
