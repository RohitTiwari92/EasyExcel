using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExcel.Compare
{
   public interface ICompare
    {
        List<string> Compare(List<string> column1, List<string> column2);
        
    }
}
