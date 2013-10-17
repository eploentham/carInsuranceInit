using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace carInsuranceInit.objdb
{
    class BrandDB
    {
        ConnectDB conn;
        public Brand brand;
        public BrandDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            brand = new Brand();
            brand.brandId = "brand_id";
            brand.brandName = "brand_name";
            brand.sited = "";
            brand.pkField = "brand_id";
            brand.table = "brand";
        }
        private Brand setData(Brand item, DataTable dt)
        {
            item.brandId = dt.Rows[0][brand.brandId].ToString();
            item.brandName = dt.Rows[0][brand.brandName].ToString();

            return item;
        }
        public DataTable selectAll()
        {
            //SedanAgeCar item = new SedanAgeCar();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + brand.table + " ";
            dt = conn.selectData(sql);

            return dt;
        }
        public Brand selectByPk(String sacId)
        {
            Brand item = new Brand();
            String sql = "";
            DataTable dt = new DataTable();
            sql = "Select * From " + brand.table + " Where " + brand.pkField + "='" + sacId + "'";
            dt = conn.selectData(sql);
            if (dt.Rows.Count > 0)
            {
                item = setData(item, dt);
            }
            return item;
        }
        private String insert(Brand p)
        {
            String sql = "", chk = "";
            if (p.brandId.Equals(""))
            {
                p.brandId = p.getGenID();
            }
            p.brandName = p.brandName.Replace("''", "'");

            sql = "Insert Into " + brand.table + " (" + brand.pkField + "," + brand.brandName + ") " +
                "Values('" + p.brandId + "','" + p.brandName + "')";
            try
            {
                chk = conn.ExecuteNonQuery(sql);
                chk = p.brandId;
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
        private String update(Brand p)
        {
            String sql = "", chk = "";

            p.brandName = p.brandName.Replace("''", "'");

            sql = "Update " + brand.table + " Set " + brand.brandName + "='" + p.brandName + "' " +
                "Where " + brand.pkField + "='" + p.brandId + "'";
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
        public String insertBrand(Brand p)
        {
            Brand item = new Brand();
            String chk = "";
            item = selectByPk(p.brandId);
            if (item.brandId == "")
            {
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
            sql = "Delete From " + brand.table;
            chk = conn.ExecuteNonQuery(sql);
            return chk;
        }
    }
}
