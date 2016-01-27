using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.objdb
{
    public class SedanEngineCCDB
    {
        private ConnectDB conn;
        public SedanEngineCC sec;
        public SedanEngineCCDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sec = new SedanEngineCC();

            sec.sedanEngine2000CCMinTInsur1 = "sedan_engine_2000cc_min_t_insur_1";
            sec.sedanEngine2000CCMinTInsur2 = "sedan_engine_2000cc_min_t_insur_2";
            sec.sedanEngine2000CCMinTInsur3 = "sedan_engine_2000cc_min_t_insur_3";
            sec.sedanEngine2000CCMaxTInsur1 = "sedan_engine_2000cc_max_t_insur_1";
            sec.sedanEngine2000CCMaxTInsur2 = "sedan_engine_2000cc_max_t_insur_2";
            sec.sedanEngine2000CCMaxTInsur3 = "sedan_engine_2000cc_max_t_insur_3";
            sec.sited = "";
            sec.table = "sedan_engine_cc";
            sec.pkField = "id";
        }
        public String update(SedanEngineCC p)
        {
            String sql = "", chk = "";
            p.sedanEngine2000CCMinTInsur1 = p.sedanEngine2000CCMinTInsur1.Replace(",", "");
            p.sedanEngine2000CCMinTInsur2 = p.sedanEngine2000CCMinTInsur2.Replace(",", "");
            p.sedanEngine2000CCMinTInsur3 = p.sedanEngine2000CCMinTInsur3.Replace(",", "");

            p.sedanEngine2000CCMaxTInsur1 = p.sedanEngine2000CCMaxTInsur1.Replace(",", "");
            p.sedanEngine2000CCMaxTInsur2 = p.sedanEngine2000CCMaxTInsur2.Replace(",", "");
            p.sedanEngine2000CCMaxTInsur3 = p.sedanEngine2000CCMaxTInsur3.Replace(",", "");

            sql = "Update " + sec.table + " Set " + sec.sedanEngine2000CCMinTInsur1 + "='" + p.sedanEngine2000CCMinTInsur1 + "'," +
                sec.sedanEngine2000CCMinTInsur2 + "='" + p.sedanEngine2000CCMinTInsur2 + "'," +
                sec.sedanEngine2000CCMinTInsur3 + "='" + p.sedanEngine2000CCMinTInsur3 + "'," +
                sec.sedanEngine2000CCMaxTInsur1 + "='" + p.sedanEngine2000CCMaxTInsur1 + "'," +
                sec.sedanEngine2000CCMaxTInsur2 + "='" + p.sedanEngine2000CCMaxTInsur2 + "'," +
                sec.sedanEngine2000CCMaxTInsur3 + "='" + p.sedanEngine2000CCMaxTInsur3 + "' " +
                "Where " + sec.pkField + "='1'";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return chk;
        }
        public SedanEngineCC selectAll()
        {
            SedanEngineCC item = new SedanEngineCC();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sec.table + " Where " + sec.pkField + "='1'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private SedanEngineCC setData(SedanEngineCC item, DataTable dt)
        {
            item.sedanEngine2000CCMinTInsur1 = dt.Rows[0][sec.sedanEngine2000CCMinTInsur1].ToString();
            item.sedanEngine2000CCMinTInsur2 = dt.Rows[0][sec.sedanEngine2000CCMinTInsur2].ToString();
            item.sedanEngine2000CCMinTInsur3 = dt.Rows[0][sec.sedanEngine2000CCMinTInsur3].ToString();

            item.sedanEngine2000CCMaxTInsur1 = dt.Rows[0][sec.sedanEngine2000CCMaxTInsur1].ToString();
            item.sedanEngine2000CCMaxTInsur2 = dt.Rows[0][sec.sedanEngine2000CCMaxTInsur2].ToString();
            item.sedanEngine2000CCMaxTInsur3 = dt.Rows[0][sec.sedanEngine2000CCMaxTInsur3].ToString();
            return item;
        }
    }
}
