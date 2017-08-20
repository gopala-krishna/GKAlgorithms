using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class BubbleSort
    {
        /// <summary>
        ///  Time Complexity: O(N*N) 
        ///  
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int[] BubbleSort1(int[] arr)
        {
            int iTemp;                                                                                         // 5 4 3 2 1--- 4 5 3 2 1- 4 3 5 2 1- 4 3 2 5 1 - 4 3 2 1 5
                                                                                                               // 4 3 2 1 5 --- 3 4 2 1 5 - 3 2 4 1 5 - 3 2 1 4 5
            for (int i = 0; i <arr.Length-1; i++)                                                // 3 2 1 4 5 --- 2 3 1 4 5 - 2 1 3 4 5 
            {                                                                                                      // 2 1 3 4 5 --- 1 2 3 4 5  
                for (int j = 0; j <arr.Length-i-1; j++)
                {
                   if (arr[j] > arr[j+1])
                    {
                        iTemp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = iTemp;
                    }
                }
            }
            return arr;
        }
    }
}
