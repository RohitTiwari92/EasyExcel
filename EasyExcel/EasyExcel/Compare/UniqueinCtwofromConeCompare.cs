using System.Collections.Generic;

namespace EasyExcel.Compare
{
    internal class UniqueinCtwofromConeCompare : ICompare
    {
        public List<string> Compare(List<string> column1, List<string> column2)
        {
            List<string> duplicate = new List<string>();

           

            foreach (var item in column2)
            {
                if (!column1.Contains(item))
                {
                    duplicate.Add(item);
                }
            }
            return duplicate;
        }
    }
}