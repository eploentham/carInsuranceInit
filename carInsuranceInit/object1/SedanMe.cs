using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    public class SedanMe : Persistent
    {
        public String sedanMe = "";
        public String sedanMeId = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public String sedanMeActive = "";

        public override string ToString()
        {
            return sedanMe;
        }
    }
}
