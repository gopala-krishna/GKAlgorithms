using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        ///// <summary>
        ///// Time Complexity : O(n*n) but mostly O(nlogn)
        ///// Space Complexity : O(logn) 
        ///// </summary>
        ///// <param name="inputArr"></param>

        public void QuickSort1(int[] arr)
        {
            QuickSortRecursive(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }

        private void QuickSortRecursive(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);
                QuickSortRecursive(arr, low, partitionIndex - 1);
                QuickSortRecursive(arr, partitionIndex + 1, high);
            }
        }
        private int Partition(int[] arr, int low, int high)
        {
            int i = low - 1; int j = low; int pivot = arr[high];
            while (j < high)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                j++;
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
