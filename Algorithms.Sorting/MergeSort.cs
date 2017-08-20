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
        public static void MergeSort1(int[] arr)
        {
            MergeSortRecursive(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }

        public static void MergeSortRecursive(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low +high )/ 2;
                MergeSortRecursive(arr, low, mid);
                MergeSortRecursive(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }


        private static void Merge(int[] arr, int low, int mid, int high)
        {

           int i, j, k;
            int n1 = mid-low+ 1;
            int n2 = high - mid;

            /* create temp arrays */
            int[] left = new int[n1];
            int[] right = new int[n2];
            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                left[i] = arr[low + i];
            for (j = 0; j < n2; j++)
                right[j]= arr[mid+ 1 + j];

            i = 0;
            j = 0;
            k = low; // Initial index of merged subarray
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of left array, if there
               are any */
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of right array, if there
               are any */
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }








            //int left = low;                                            //4,8,5,1,3,9,2      1 4 5 8   2 3 9     1 2 3 4 5 8 9
            //int right = middle + 1;
            //int[] tmp = new int[(high - low) + 1];
            //int tmpIndex = 0;

            //while ((left <= middle) && (right <= high))
            //{
            //    if (input[left] < input[right])
            //    {
            //        tmp[tmpIndex] = input[left];
            //        left = left + 1;
            //    }
            //    else
            //    {
            //        tmp[tmpIndex] = input[right];
            //        right = right + 1;
            //    }
            //    tmpIndex = tmpIndex + 1;
            //}

            //if (left <= middle)
            //{
            //    while (left <= middle)
            //    {
            //        tmp[tmpIndex] = input[left];
            //        left = left + 1;
            //        tmpIndex = tmpIndex + 1;
            //    }
            //}

            //if (right <= high)
            //{
            //    while (right <= high)
            //    {
            //        tmp[tmpIndex] = input[right];
            //        right = right + 1;
            //        tmpIndex = tmpIndex + 1;
            //    }
            //}

            //for (int i = 0; i < tmp.Length; i++)
            //{
            //    input[low + i] = tmp[i];
            //}

        }

    }
        
}
