using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Delegate
{
    internal class CompareFunctions
    {
        public static bool CompareGrt(int x, int y)
        {
            return x > y;
        }
        public static bool CompareLess(int x, int y)
        {
            return x < y;
        }

        public static bool SortAscending(string x, string y) 
        { 
            return x?.Length > y?.Length;
        }

        public static bool SortDecsending(string x, string y)
        {
            return x?.Length < y?.Length;
        }
    }
}
