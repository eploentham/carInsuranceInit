using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    public class SedanMeDB
    {
        private ConnectDB conn;
        public SedanMe sme;
        public SedanMeDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sme = new SedanMe();
            sme.RateTInsur1 = "rate_t_insur1";
            sme.RateTInsur2 = "rate_t_insur2";
            sme.RateTInsur3 = "rate_t_insur3";
            sme.sedanMe = "sedan_me";
            sme.sedanMeId = "sedan_me_id";
            sme.sedanMeActive = "sedan_me_active";

            sme.table = "sedan_me";
            sme.sited = "";
            sme.pkField = "sedan_me_id";
        }
        private SedanMe setData(SedanMe item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sme.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sme.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sme.RateTInsur3].ToString();

            item.sedanMe = dt.Rows[0][sme.sedanMe].ToString();
            item.sedanMeId = dt.Rows[0][sme.sedanMeId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sme.table + " Where " + sme.sedanMeActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanMe selectByPk(String sadId)
        {
            SedanMe item = new SedanMe();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sme.table + " Where " + sme.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanMe p)
        {
            String sql = "", chk = "";
            if (p.sedanMeId.Equals(""))
            {
                p.sedanMeId = p.getGenID();
            }
            if (p.sedanMeActive.Equals(""))
            {
                p.sedanMeActive = "1";
            }
            p.sedanMe = p.sedanMe.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sme.table + " (" + sme.pkField + "," + sme.sedanMe + "," +
                sme.RateTInsur1 + "," + sme.RateTInsur2 + "," + sme.RateTInsur3+","+
                sme.sedanMeActive + ") " +
                "Values('" + p.sedanMeId + "','" + p.sedanMe + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3 +"','"+
                p.sedanMeActive+ "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanMeId;
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
        private String update(SedanMe p)
        {
            String sql = "", chk = "";

            p.sedanMe = p.sedanMe.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sme.table + " Set " + sme.sedanMe + "='" + p.sedanMe + "'," +
                sme.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sme.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sme.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sme.pkField + "='" + p.sedanMeId + "'";
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
        public String insertSedanMe(SedanMe p)
        {
            SedanMe item = new SedanMe();
            String chk = "";
            item = selectByPk(p.sedanMeId);
            if (item.sedanMeId == "")
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
            sql = "Delete From " + sme.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sme.table + " Set " + sme.sedanMeActive + "='3' "+
                "Where "+sme.sedanMeId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
