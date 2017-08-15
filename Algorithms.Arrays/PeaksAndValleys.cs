using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting;

namespace Algorithms.Arrays
{
    /// <summary>
    /// Time Complexity : O(n*n)
    /// </summary>
    class PeaksAndValleys
    {

        public void PeaksAndValleys1(int[] intArr)
        {
            MergeSort.MergeSort1(intArr);
            Console.WriteLine();

            for (int i = 1; i < intArr.Length; i += 2)
            {
                int temp = intArr[i - 1];
                intArr[i - 1] = intArr[i];
                intArr[i] = temp;
            }

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i].ToString() + ",");
            }
        }


        public void PeaksAndValleys2(int[] intArr)
        {
            //for (int i = 0; i < intArr.Length; i+=2)
            //{
            //    int maxValIndex = Math.Max(i - 1, Math.Max(i, i + 1));
            //    if (i != maxValIndex)
            //    {
            //        int temp = intArr[i ];
            //        intArr[i] = intArr[maxValIndex];
            //        intArr[maxValIndex] = temp;
            //    }
            //}

            //for (int i = 0; i < intArr.Length; i++)
            //{
            //    Console.Write(intArr[i].ToString() + ",");
            //}
        }
    }
}