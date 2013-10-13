using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.objdb
{
    class ReportDB
    {
        public ConnectDB conn;
        public ReportDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            //invdb = new InvoiceDB(conn);
            //invIdb = new InvoiceItemDB(conn);
        }
        public DataTable dailyInvoice(String dateStart, String dateEnd)
        {
            DataTable dt = new DataTable();
            String sql = "", chk = "";

            //sql = "Select inv.inv_number,inv.cust_name,inv.inv_date,inv.inv_amount,inv.due_date,inv.recp_number, " +
            //    "mid(inv.inv_date,9,2) +'-'+ mid(inv.inv_date,6,2) +'-'+ mid(inv.inv_date,1,4) as invdate, " +
            //    "mid(inv.due_date,9,2) +'-'+ mid(inv.due_date,6,2) +'-'+ mid(inv.due_date,1,4) as duedate, invi.description, invi.amount, invi.recp_number, invi.recp_amount " +
            //    "From " + invdb.inv.table + " inv Left Join t_invoice_item invi On inv."+invdb.inv.invId+" = invi.inv_id " +
            //    " Where inv." + invdb.inv.invDate + ">='" + dateStart + "' and inv." + invdb.inv.invDate + "<='" + dateEnd + "' and inv." 
            //    + invdb.inv.invActive + " = '1' and invi.inv_item_active " +
            //    "Order By inv." + invdb.inv.invDate + ",inv." + invdb.inv.invNumber+",invi.inv_item_row";
            //dt = conn.selectData(sql);
            
            return dt;
        }
    }
}
