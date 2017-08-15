using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
  public class MergeSort
    {
        /// <summary>
        ///  Time Complexity : O(n log n)
        ///  Space Complexity : O(n) (merge process : n stack : logn  total = n+logn) so o(n)
        /// </summary>
        /// <param name="input"></param>
        public static void MergeSort1(int[] input)
        {
            MergeSortRecursive(input, 0, input.Length - 1);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + ",");
            }
        }

        public static void MergeSortRecursive(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low +high )/ 2;
                MergeSortRecursive(input, low, middle);
                MergeSortRecursive(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }


        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;                                            //4,8,5,1,3,9,2      1 4 5 8   2 3 9     1 2 3 4 5 8 9
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while ((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                }
                tmpIndex = tmpIndex + 1;
            }

            if (left <= middle)
            {
                while (left <= middle)
                {
                    tmp[tmpIndex] = input[left];
                    left = left + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            if (right <= high)
            {
                while (right <= high)
                {
                    tmp[tmpIndex] = input[right];
                    right = right + 1;
                    tmpIndex = tmpIndex + 1;
                }
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

        }

    }
        
}
