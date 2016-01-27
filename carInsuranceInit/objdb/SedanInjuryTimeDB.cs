using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    public class SedanInjuryTimeDB
    {
        private ConnectDB conn;
        public SedanInjuryTime sit;
        public SedanInjuryTimeDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sit = new SedanInjuryTime();
            sit.RateTInsur1 = "rate_t_insur1";
            sit.RateTInsur2 = "rate_t_insur2";
            sit.RateTInsur3 = "rate_t_insur3";
            sit.sedanInjuryTime = "sedan_injury_time";
            sit.sedanInjuryTimeId = "sedan_injury_time_id";
            sit.sedanInjuryTimeActive = "sedan_injury_time_active";

            sit.table = "sedan_injury_time";
            sit.sited = "";
            sit.pkField = "sedan_injury_time_id";
        }
        private SedanInjuryTime setData(SedanInjuryTime item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sit.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sit.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sit.RateTInsur3].ToString();

            item.sedanInjuryTime = dt.Rows[0][sit.sedanInjuryTime].ToString();
            item.sedanInjuryTimeId = dt.Rows[0][sit.sedanInjuryTimeId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sit.table + " Where " + sit.sedanInjuryTimeActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanInjuryTime selectByPk(String sadId)
        {
            SedanInjuryTime item = new SedanInjuryTime();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sit.table + " Where " + sit.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanInjuryTime p)
        {
            String sql = "", chk = "";
            if (p.sedanInjuryTimeId.Equals(""))
            {
                p.sedanInjuryTimeId = p.getGenID();
            }
            if (p.sedanInjuryTimeActive.Equals(""))
            {
                p.sedanInjuryTimeActive = "1";
            }
            p.sedanInjuryTime = p.sedanInjuryTime.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sit.table + " (" + sit.pkField + "," + sit.sedanInjuryTime + "," +
                sit.RateTInsur1 + "," + sit.RateTInsur2 + "," + sit.RateTInsur3+","+ 
                sit.sedanInjuryTimeActive+ ") " +
                "Values('" + p.sedanInjuryTimeId + "','" + p.sedanInjuryTime + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3+"','"+
                p.sedanInjuryTimeActive + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanInjuryTimeId;
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
        private String update(SedanInjuryTime p)
        {
            String sql = "", chk = "";

            p.sedanInjuryTime = p.sedanInjuryTime.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sit.table + " Set " + sit.sedanInjuryTime + "='" + p.sedanInjuryTime + "'," +
                sit.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sit.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sit.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sit.pkField + "='" + p.sedanInjuryTimeId + "'";
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
        public String insertSedanInjuryTime(SedanInjuryTime p)
        {
            SedanInjuryTime item = new SedanInjuryTime();
            String chk = "";
            item = selectByPk(p.sedanInjuryTimeId);
            if (item.sedanInjuryTimeId == "")
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
            sql = "Delete From " + sit.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sit.table + " Set " + sit.sedanInjuryTimeActive + "='3' "+
                "Where "+sit.sedanInjuryTimeId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
