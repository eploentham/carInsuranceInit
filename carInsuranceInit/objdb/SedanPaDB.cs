using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class SedanPaDB
    {
        private ConnectDB conn;
        public SedanPa spa;
        public SedanPaDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            spa = new SedanPa();
            spa.RateTInsur1 = "rate_t_insur1";
            spa.RateTInsur2 = "rate_t_insur2";
            spa.RateTInsur3 = "rate_t_insur3";
            spa.sedanPa = "sedan_pa";
            spa.sedanPaId = "sedan_pa_id";

            spa.table = "sedan_pa";
            spa.sited = "";
            spa.pkField = "sedan_pa_id";
        }
        private SedanPa setData(SedanPa item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][spa.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][spa.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][spa.RateTInsur3].ToString();

            item.sedanPa = dt.Rows[0][spa.sedanPa].ToString();
            item.sedanPaId = dt.Rows[0][spa.sedanPaId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + spa.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanPa selectByPk(String sadId)
        {
            SedanPa item = new SedanPa();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + spa.table + " Where " + spa.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanPa p)
        {
            String sql = "", chk = "";
            if (p.sedanPaId.Equals(""))
            {
                p.sedanPaId = p.getGenID();
            }
            p.sedanPa = p.sedanPa.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + spa.table + " (" + spa.pkField + "," + spa.sedanPa + "," +
                spa.RateTInsur1 + "," + spa.RateTInsur2 + "," + spa.RateTInsur3 + ") " +
                "Values('" + p.sedanPaId + "','" + p.sedanPa + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3 + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanPaId;
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
        private String update(SedanPa p)
        {
            String sql = "", chk = "";

            p.sedanPa = p.sedanPa.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + spa.table + " Set " + spa.sedanPa + "='" + p.sedanPa + "'," +
                spa.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                spa.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                spa.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + spa.pkField + "='" + p.sedanPaId + "'";
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
        public String insertSedanPa(SedanPa p)
        {
            SedanPa item = new SedanPa();
            String chk = "";
            item = selectByPk(p.sedanPaId);
            if (item.sedanPaId == "")
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
            sql = "Delete From " + spa.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
