﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace carInsuranceInit.object1
{
    class SedanPa : Persistent
    {
        public String sedanPa = "";
        public String sedanPaId = "";
        public String RateTInsur1 = "";
        public String RateTInsur2 = "";
        public String RateTInsur3 = "";
        public override string ToString()
        {
            return sedanPa;
        }
    }
}
