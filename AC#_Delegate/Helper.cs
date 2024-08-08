using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Delegate
{
    internal static class Helper<T>
    {
       // public delegate bool CondtionalFuncDelegate(int x);
        public delegate bool ConditionalFuncDelegate<T>(T x);//generic delegate //declare delegate

        public static List<T> GetElements(List<T> elements, ConditionalFuncDelegate<T> condition)
        {
            List<T> Result = new List<T>();
            if (elements is not null && condition is not null)

                for (int i = 0; i < elements.Count; i++)

                    if (condition(elements[i])) Result.Add(elements[i]);

            return Result;


        }





        //public static List<int> GetNumber(List<int> Numbers, ConditionalFuncDelegate condition)
        //{
        //    List<int> Result = new List<int>();
        //    if (Numbers is not null && condition is not null) 
            
        //        for (int i = 0; i < Numbers.Count; i++) 
                
        //           if(condition(Numbers[i])) Result.Add(Numbers[i]);

        //        return Result;
            

        //}



    }
}
