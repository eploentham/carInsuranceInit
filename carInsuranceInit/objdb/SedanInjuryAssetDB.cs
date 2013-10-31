using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class SedanInjuryAssetDB
    {
        private ConnectDB conn;
        public SedanInjuryAsset sia;
        public SedanInjuryAssetDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sia = new SedanInjuryAsset();
            sia.RateTInsur1 = "rate_t_insur1";
            sia.RateTInsur2 = "rate_t_insur2";
            sia.RateTInsur3 = "rate_t_insur3";
            sia.sedanInjuryAsset = "sedan_injury_asset";
            sia.sedanInjuryAssetId = "sedan_injury_asset_id";
            sia.sedanInjuryAssetActive = "sedan_injury_asset_active";

            sia.table = "sedan_injury_asset";
            sia.sited = "";
            sia.pkField = "sedan_injury_asset_id";
        }
        private SedanInjuryAsset setData(SedanInjuryAsset item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sia.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sia.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sia.RateTInsur3].ToString();

            item.sedanInjuryAsset = dt.Rows[0][sia.sedanInjuryAsset].ToString();
            item.sedanInjuryAssetId = dt.Rows[0][sia.sedanInjuryAssetId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sia.table + " Where " + sia.sedanInjuryAssetActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanInjuryAsset selectByPk(String sadId)
        {
            SedanInjuryAsset item = new SedanInjuryAsset();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sia.table + " Where " + sia.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanInjuryAsset p)
        {
            String sql = "", chk = "";
            if (p.sedanInjuryAssetId.Equals(""))
            {
                p.sedanInjuryAssetId = p.getGenID();
            }
            if (p.sedanInjuryAssetActive.Equals(""))
            {
                p.sedanInjuryAssetActive = "1";
            }
            p.sedanInjuryAsset = p.sedanInjuryAsset.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sia.table + " (" + sia.pkField + "," + sia.sedanInjuryAsset + "," +
                sia.RateTInsur1 + "," + sia.RateTInsur2 + "," + sia.RateTInsur3+","+
                sia.sedanInjuryAssetActive + ") " +
                "Values('" + p.sedanInjuryAssetId + "','" + p.sedanInjuryAsset + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3+"','"+
                p.sedanInjuryAssetActive + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanInjuryAssetId;
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
        private String update(SedanInjuryAsset p)
        {
            String sql = "", chk = "";

            p.sedanInjuryAsset = p.sedanInjuryAsset.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sia.table + " Set " + sia.sedanInjuryAsset + "='" + p.sedanInjuryAsset + "'," +
                sia.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sia.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sia.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sia.pkField + "='" + p.sedanInjuryAssetId + "'";
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
        public String insertSedanInjuryAsset(SedanInjuryAsset p)
        {
            SedanInjuryAsset item = new SedanInjuryAsset();
            String chk = "";
            item = selectByPk(p.sedanInjuryAssetId);
            if (item.sedanInjuryAssetId == "")
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
            sql = "Delete From " + sia.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sia.table + " Set " + sia.sedanInjuryAssetActive + "='3' "+
                "Where "+sia.sedanInjuryAssetId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
