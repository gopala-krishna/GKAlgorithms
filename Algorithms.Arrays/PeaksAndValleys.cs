using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting;

namespace Algorithms.Arrays
{
    class PeaksAndValleys
    {
        /// <summary>
        /// Time Complexity : O(NlogN)
        /// </summary>
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

        /// <summary>
        ///  Time Complexity : O(N)
        /// </summary>
        /// <param name="intArr"></param>
        public void PeaksAndValleys2(int[] intArr)
        {
            for (int i = 1; i < intArr.Length-1; i += 2)
            {
                if (intArr[i - 1] > intArr[i])
               {
                    int temp = intArr[i - 1];
                    intArr[i - 1] = intArr[i];
                    intArr[i] = temp;
                }

                if (intArr[i +1] > intArr[i])
                {
                    int temp = intArr[i +1];
                    intArr[i +1] = intArr[i];
                    intArr[i] = temp;
                }
            }

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i].ToString() + ",");
            }

        }
    }
}