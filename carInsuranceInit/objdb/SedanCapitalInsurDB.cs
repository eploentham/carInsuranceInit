using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    public class SedanCapitalInsurDB
    {
        private ConnectDB conn;
        public SedanCapitalInsur sci;
        public SedanCapitalInsurDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sci = new SedanCapitalInsur();
            sci.RateTInsur1 = "rate_t_insur1";
            sci.RateTInsur2 = "rate_t_insur2";
            sci.RateTInsur3 = "rate_t_insur3";
            sci.sedanCapitalInsur = "sedan_cap_insur";
            sci.sedanCapitalInsurId = "sedan_cap_insur_id";
            sci.sedanCapitalInsurActive = "sedan_cap_insur_active";

            sci.table = "sedan_capital_insur";
            sci.sited = "";
            sci.pkField = "sedan_cap_insur_id";

        }
        private SedanCapitalInsur setData(SedanCapitalInsur item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sci.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sci.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sci.RateTInsur3].ToString();

            item.sedanCapitalInsur = dt.Rows[0][sci.sedanCapitalInsur].ToString();
            item.sedanCapitalInsurId = dt.Rows[0][sci.sedanCapitalInsurId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sci.table + " Where " + sci.sedanCapitalInsurActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanCapitalInsur selectByPk(String sadId)
        {
            SedanCapitalInsur item = new SedanCapitalInsur();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sci.table + " Where " + sci.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanCapitalInsur p)
        {
            String sql = "", chk = "";
            if (p.sedanCapitalInsurId.Equals(""))
            {
                p.sedanCapitalInsurId = p.getGenID();
            }
            if (p.sedanCapitalInsurActive.Equals(""))
            {
                p.sedanCapitalInsurActive = "1";
            }
            p.sedanCapitalInsur = p.sedanCapitalInsur.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sci.table + " (" + sci.pkField + "," + sci.sedanCapitalInsur + "," +
                sci.RateTInsur1 + "," + sci.RateTInsur2 + "," + 
                sci.RateTInsur3+","+sci.sedanCapitalInsurActive + ") " +
                "Values('" + p.sedanCapitalInsurId + "','" + p.sedanCapitalInsur + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + 
                p.RateTInsur3+"','"+p.sedanCapitalInsurActive + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanCapitalInsurId;
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
        private String update(SedanCapitalInsur p)
        {
            String sql = "", chk = "";

            p.sedanCapitalInsur = p.sedanCapitalInsur.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sci.table + " Set " + sci.sedanCapitalInsur + "='" + p.sedanCapitalInsur + "'," +
                sci.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sci.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sci.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sci.pkField + "='" + p.sedanCapitalInsurId + "'";
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
        public String insertSedanCapitalInsur(SedanCapitalInsur p)
        {
            SedanCapitalInsur item = new SedanCapitalInsur();
            String chk = "";
            item = selectByPk(p.sedanCapitalInsurId);
            if (item.sedanCapitalInsurId == "")
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
            sql = "Delete From " + sci.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sci.table + " Set " + sci.sedanCapitalInsurActive + "='3' "+
                "Where "+sci.sedanCapitalInsurId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
