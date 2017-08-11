using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        /// <summary>
        ///  7 3 4 9
        ///  
        ///  
        /// 
        /// </summary>
        /// <param name="InputArr"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        public void QuickSort1(int[] InputArr, int arrLength)
        {
            int start = 0; int end = arrLength-1;

           QuickSortRecursive(InputArr, start, end);

            for (int i = 0; i < InputArr.Length; i++)
            {
                Console.Write(InputArr[i] + ",");
            }
        }

        public void QuickSortRecursive(int[] InputArr, int start, int end)
        {
            if (start < end)
            {
                int partitionedIndex = Partition(InputArr, start, end);
                QuickSortRecursive(InputArr, start, partitionedIndex - 1);
                QuickSortRecursive(InputArr, partitionedIndex + 1, end);
            }

            //return InputArr;
        }

        public int Partition(int[] inputArr, int start, int end)
        {
            
           int pivot = inputArr[end];  int i = start -1; int temp; 

            for (int j = start; j < end; j++)
            {
                if( inputArr[j] <= pivot)
                {
                    i = i + 1;
                    temp = inputArr[i];
                    inputArr[i] = inputArr[j];
                    inputArr[j] = temp;
                }
             }
            temp = inputArr[i+1];
            inputArr[i+1] = pivot;
            pivot = temp;

            return i +1;
        }
    }
}
