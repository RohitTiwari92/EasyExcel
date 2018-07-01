﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyExcel.Compare
{
    class DuplicateCompare : ICompare
    {
        public DuplicateCompare()
        {

        }
        public List<string> Compare(List<string> column1, List<string> column2)
        {
            List<string> duplicate = new List<string>();
            foreach (var item in column1)
            {
                if(column2.Contains(item))
                {
                    duplicate.Add(item);
                }
            }
            return duplicate;
        }
    }
}
