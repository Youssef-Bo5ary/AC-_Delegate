using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Delegate
{
    internal class ConditionalFunctions
    {
        public static bool CheckOdd(int Number) => Number % 2 == 1;
        
        public static bool Checkeven(int Number)=> Number % 2 == 0;


        public static bool CheckDivisibleBy7(int Number) => Number % 7 == 0;

        public static bool CheckDivisibleBy10(int Number) => Number % 10 == 0;

        public static bool CheckStringLength(String word)=> word?.Length > 4;
    }
}
