using System;
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
        [Description("Unique items in Column 1 from column 2")]
        Unique1f2 = 3,
        [Description("Unique items in Column 2 from column 1")]
        Unique2f1 = 4,

    }
}
