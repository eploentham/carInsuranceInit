using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.object1
{
    public class SedanAgeDriver:Persistent
    {
        public String sedanAgeDriverId = "";
        public String sedanAgeDriver = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public String sedanAgeDriverActive = "";

        public override string ToString()
        {
            return sedanAgeDriver;
        }
    }
}
