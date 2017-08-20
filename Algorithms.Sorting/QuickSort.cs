using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        /// <summary>
        /// Time Complexity : O(n*n) but mostly O(nlogn)
        /// Space Complexity : O(logn) 
        /// </summary>
        /// <param name="inputArr"></param>

        public void QuickSort1(int[] inputArr)
        {
            QuickSortRecursive(inputArr, 0, inputArr.Length-1);

            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write(inputArr[i] + ",");
            }
        }

        public void QuickSortRecursive(int[]inputArr, int start, int end)
        {
            if (start < end)
            {
                int partitionedIndex = Partition(inputArr, start, end);
             
                QuickSortRecursive(inputArr, start, partitionedIndex - 1);
                QuickSortRecursive(inputArr, partitionedIndex + 1, end);
            }
        }

        public int Partition(int[] inputArr, int start, int end)
        {

            int pivot = inputArr[end];

            int i = start - 1;


            for (int j = start; j < end; j++)
            {
                if (inputArr[j] <= pivot)
                {
                    i++;
                    int temp = inputArr[i];
                    inputArr[i] = inputArr[j];
                    inputArr[j] = temp;
                }
            }
           int  temp1 = inputArr[i + 1];
            inputArr[i + 1] = inputArr[end];
            inputArr[end]= temp1;

            return i + 1;
        }
    }
}
