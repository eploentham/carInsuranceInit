using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    public class SedanInjuryTime:Persistent
    {
        public String sedanInjuryTime = "";
        public String sedanInjuryTimeId = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public String sedanInjuryTimeActive = "";

        public override string ToString()
        {
            return sedanInjuryTime;
        }
    }
}
