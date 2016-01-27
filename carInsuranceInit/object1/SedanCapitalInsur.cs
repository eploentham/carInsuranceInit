using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    public class SedanCapitalInsur:Persistent
    {
        public String sedanCapitalInsur = "";
        public String sedanCapitalInsurId = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public String sedanCapitalInsurActive = "";

        public override string ToString()
        {
            return sedanCapitalInsur;
        }
    }
}
