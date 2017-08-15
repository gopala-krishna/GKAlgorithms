using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Algorithms.Sorting;
using Algorithms.Math;



namespace Algorithms.Arrays
{
    class PeaksAndValleys
    {
        public void PeaksAndValleys1(int[] intArr)
        {
            //MergeSort.MergeSort1(intArr);

            for (int i = 0; i < intArr.Length; i += 2)
            {
                Swap.SimpleSwap(intArr[i], intArr[i + 1]);
            }

            for (int i = 0; i < intArr.Length; i += 2)
            {
                Console.Write(intArr[i].ToString(), ",");
            }
        }
    }
}