using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    class SedanInjuryPerson:Persistent
    {
        public String sedanInjuryPerson = "";
        public String sedanInjuryPersonId = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public override string ToString()
        {
            return sedanInjuryPerson;
        }
    }
}
