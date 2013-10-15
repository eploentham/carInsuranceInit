using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.objdb
{
    class SedanUseCarDB
    {
        private ConnectDB conn;
        public SedanUseCar suc;
        public SedanUseCarDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            suc = new SedanUseCar();
            suc.sedanUseCar110TInsur1 = "sedan_use_car110_t_insur_1";
            suc.sedanUseCar110TInsur2 = "sedan_use_car110_t_insur_2";
            suc.sedanUseCar110TInsur3 = "sedan_use_car110_t_insur_3";
            suc.sedanUseCar120TInsur1 = "sedan_use_car120_t_insur_1";
            suc.sedanUseCar120TInsur2 = "sedan_use_car120_t_insur_2";
            suc.sedanUseCar120TInsur3 = "sedan_use_car130_t_insur_3";
            suc.sited = "";
            suc.table = "sedan_use_car";
            suc.pkField = "id";
        }
        public String update(SedanUseCar p)
        {
            String sql = "", chk="";
            p.sedanUseCar110TInsur1 = p.sedanUseCar110TInsur1.Replace(",", "");
            p.sedanUseCar110TInsur2 = p.sedanUseCar110TInsur2.Replace(",", "");
            p.sedanUseCar110TInsur3 = p.sedanUseCar110TInsur3.Replace(",", "");

            p.sedanUseCar120TInsur1 = p.sedanUseCar120TInsur1.Replace(",", "");
            p.sedanUseCar120TInsur2 = p.sedanUseCar120TInsur2.Replace(",", "");
            p.sedanUseCar120TInsur3 = p.sedanUseCar120TInsur3.Replace(",", "");

            sql = "Update "+suc.table+" Set "+suc.sedanUseCar110TInsur1+"='"+p.sedanUseCar110TInsur1+"',"+
                suc.sedanUseCar110TInsur2+"='"+p.sedanUseCar110TInsur2+"',"+
                suc.sedanUseCar110TInsur3+"='"+p.sedanUseCar110TInsur3+"',"+
                suc.sedanUseCar120TInsur1+"='"+p.sedanUseCar120TInsur1+"',"+
                suc.sedanUseCar120TInsur2+"='"+p.sedanUseCar120TInsur2+"',"+
                suc.sedanUseCar120TInsur3+"='"+p.sedanUseCar120TInsur3+"' "+
                "Where "+suc.pkField+"='1'";
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
        public SedanUseCar selectAll()
        {
            SedanUseCar item = new SedanUseCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + suc.table + " Where " + suc.pkField + "='1'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private SedanUseCar setData(SedanUseCar item, DataTable dt)
        {
            item.sedanUseCar110TInsur1 = dt.Rows[0][suc.sedanUseCar110TInsur1].ToString();
            item.sedanUseCar110TInsur2 = dt.Rows[0][suc.sedanUseCar110TInsur2].ToString();
            item.sedanUseCar110TInsur3 = dt.Rows[0][suc.sedanUseCar110TInsur3].ToString();

            item.sedanUseCar120TInsur1 = dt.Rows[0][suc.sedanUseCar120TInsur1].ToString();
            item.sedanUseCar120TInsur2 = dt.Rows[0][suc.sedanUseCar120TInsur2].ToString();
            item.sedanUseCar120TInsur3 = dt.Rows[0][suc.sedanUseCar120TInsur3].ToString();
            return item;
        }
    }
}
