﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExcel.Compare
{
    public enum CompareFunctionEnum
    {
        [Description("Duplicate Items in Column 2")]
        Dup = 1,
       [Description("Unique items in both column")]
        Unique = 2,
        //[Description("Lesser than values in Column 1 from Column 2")]
        //les1f2 = 3,
      

    }
}
