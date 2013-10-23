using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    class SedanModel:Persistent
    {
        public String sedanModelId = "";
        public String sedanModel = "";
        public String sedanEngineCC = "";
        public String sedanCatCar = "";
        public String brandId = "";
        public String brandName = "";
        public String priceMin = "";
        public String priceMax = "";
        public String price = "";
        public String statusEngineCC = "";
        public String sedanModelActive = "";

        public override string ToString()
        {
            return sedanModel;
        }
    }
}
