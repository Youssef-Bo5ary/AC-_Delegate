using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Delegate
{

    public delegate bool CompareFuncDelegate<T>(T A, T B);//generic delegate //0 step (delegate Declaration)
    internal class SortingAlgorithm<T>
    {

        public static void BuubleSort(T[] array,CompareFuncDelegate<T> compareFunc)    
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length-i-1; j++)
                    {
                        if (compareFunc(array[j] , array[j + 1]))
                            SWAP(ref array[j], ref array[j + 1]);
                    }
                }


            }
        }
        private static void SWAP(ref T v1, ref T v2)
        {
          T  Temp = v1;
            v1 = v2;
            v2 = Temp;

        }

        //public static void BubbleSortDesc(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j] < array[j + 1])
        //                    SWAP(ref array[j], ref array[j + 1]);
        //            }
        //        }


        //    }
        //}






    }
}
