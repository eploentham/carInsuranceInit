using carInsuranceInit.object1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.objdb
{
    class SedanModelDB
    {
        private ConnectDB conn;
        public SedanModel sm;
        public SedanModelDB(ConnectDB c)
        {
            conn = c;
            initConfig();
        }
        private void initConfig()
        {
            sm = new SedanModel();
            sm.brandId = "brand_id";
            sm.price = "price";
            sm.priceMax = "price_min";
            sm.priceMin = "price_max";
            sm.sedanCatCar = "sedan_cat_car";
            sm.sedanEngineCC = "sedan_engine_cc";
            sm.sedanModel = "sedan_model";
            sm.sedanModelId = "sedan_model_id";
            sm.statusEngineCC = "status_engine_cc";

            sm.sited = "";
            sm.table = "sedan_model";
            sm.pkField = "sedan_model_id";
        }
    }
}
