using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExcel.Compare
{
   public class CompareProcess
    {
        private List<string> _column1;
        private List<string> _column2;

        private CompareFunctionEnum _function { get;  set; }

        public CompareProcess(List<string> column1,List<string> column2,CompareFunctionEnum function)
        {
            _function = function;
            _column1 = column1;
            _column2 = column2;
        }

        public List<string> Compare()
        {
            ICompare compare = GetCompareOption(_function);
           return compare.Compare(_column1, _column2);
        }

        private static ICompare GetCompareOption(CompareFunctionEnum objectToCompare)
        {
            ICompare Strategy = null;

            switch (objectToCompare)
            {
                case CompareFunctionEnum.Dup:
                    Strategy = new DuplicateCompare();
                    break;
                case CompareFunctionEnum.Unique:
                    Strategy = new UniqueCompare();
                    break;
              //  case CompareFunctionEnum.les1f2:
                //    Strategy = new LesserthanvaluesinColumn_1_fromColumn_2();
                  //  break;
                default:
                    break;
            }
            return Strategy;
        }
    }
}
