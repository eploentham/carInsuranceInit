using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class SedanInjuryPersonDB
    {
        private ConnectDB conn;
        public SedanInjuryPerson sip;
        public SedanInjuryPersonDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sip = new SedanInjuryPerson();
            sip.RateTInsur1 = "rate_t_insur1";
            sip.RateTInsur2 = "rate_t_insur2";
            sip.RateTInsur3 = "rate_t_insur3";
            sip.sedanInjuryPerson = "sedan_injury_person";
            sip.sedanInjuryPersonId = "sedan_injury_person_id";
            sip.sedanInjuryPersonActive = "sedan_injury_person_active";

            sip.table = "sedan_injury_person";
            sip.sited = "";
            sip.pkField = "sedan_injury_person_id";
        }
        private SedanInjuryPerson setData(SedanInjuryPerson item, DataTable dt)
        {
            item.RateTInsur1 = dt.Rows[0][sip.RateTInsur1].ToString();
            item.RateTInsur2 = dt.Rows[0][sip.RateTInsur2].ToString();
            item.RateTInsur3 = dt.Rows[0][sip.RateTInsur3].ToString();

            item.sedanInjuryPerson = dt.Rows[0][sip.sedanInjuryPerson].ToString();
            item.sedanInjuryPersonId = dt.Rows[0][sip.sedanInjuryPersonId].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sip.table + " Where " + sip.sedanInjuryPersonActive + "='1'";
            dt = conn.selectData(sql);

            return dt;
        }
        public SedanInjuryPerson selectByPk(String sadId)
        {
            SedanInjuryPerson item = new SedanInjuryPerson();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + sip.table + " Where " + sip.pkField + "='" + sadId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        public String insert(SedanInjuryPerson p)
        {
            String sql = "", chk = "";
            if (p.sedanInjuryPersonId.Equals(""))
            {
                p.sedanInjuryPersonId = p.getGenID();
            }
            if (p.sedanInjuryPersonActive.Equals(""))
            {
                p.sedanInjuryPersonActive = "1";
            }
            p.sedanInjuryPerson = p.sedanInjuryPerson.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Insert Into " + sip.table + " (" + sip.pkField + "," + sip.sedanInjuryPerson + "," +
                sip.RateTInsur1 + "," + sip.RateTInsur2 + "," + sip.RateTInsur3+","+
                sip.sedanInjuryPersonActive + ") " +
                "Values('" + p.sedanInjuryPersonId + "','" + p.sedanInjuryPerson + "','" +
                p.RateTInsur1 + "','" + p.RateTInsur2 + "','" + p.RateTInsur3+"','"+
                p.sedanInjuryPersonActive + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.sedanInjuryPersonId;
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
        private String update(SedanInjuryPerson p)
        {
            String sql = "", chk = "";

            p.sedanInjuryPerson = p.sedanInjuryPerson.Replace("''", "'");
            p.RateTInsur1 = p.RateTInsur1.Replace(",", "");
            p.RateTInsur2 = p.RateTInsur2.Replace(",", "");
            p.RateTInsur3 = p.RateTInsur3.Replace(",", "");

            sql = "Update " + sip.table + " Set " + sip.sedanInjuryPerson + "='" + p.sedanInjuryPerson + "'," +
                sip.RateTInsur1 + "='" + p.RateTInsur1 + "'," +
                sip.RateTInsur2 + "='" + p.RateTInsur2 + "'," +
                sip.RateTInsur3 + "='" + p.RateTInsur3 + "' " +
                "Where " + sip.pkField + "='" + p.sedanInjuryPersonId + "'";
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
        public String insertSedanInjuryPerson(SedanInjuryPerson p)
        {
            SedanInjuryPerson item = new SedanInjuryPerson();
            String chk = "";
            item = selectByPk(p.sedanInjuryPersonId);
            if (item.sedanInjuryPersonId == "")
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
            sql = "Delete From " + sip.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
        public String updateUnActive(String sacId)
        {
            String sql = "", chk = "";
            sql = "Update  " + sip.table + " Set " + sip.sedanInjuryPersonActive + "='3' "+
                "Where "+sip.sedanInjuryPersonId+"='"+sacId+"'";
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
