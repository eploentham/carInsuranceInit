using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInsuranceInit.object1
{
    class SedanAgeCar : Persistent
    {
        public String sedanAgeCarId = "";
        public String sedanAgeCar = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public String sedanAgeCarActive = "";
        public override string ToString()
        {
            return sedanAgeCar;
        }
    }
}
