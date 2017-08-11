using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class QuickSort
    {
        public void QuickSort1(int[] InputArr, int arrLength)
        {
            int start = 0; int end = arrLength - 1;

            SortQuick(InputArr, start, end);

            for (int i = 0; i < InputArr.Length; i++)
            {
                Console.Write(InputArr[i] + ",");
            }
        }




        static public void SortQuick(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    SortQuick(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    SortQuick(arr, pivot + 1, right);
            }

        }


        static public int Partition(int[] numbers, int left, int right)

        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }




        /// <summary>
        ///  13 3 4 9  3 13 4 9  3 4 13 9    3 4 9 13
        ///  
        ///  
        /// 
        /// </summary>
        /// <param name="InputArr"></param>
        /// <param name="arrLength"></param>
        /// <returns></returns>
        //public void QuickSort1(int[] InputArr, int arrLength)
        //{
        //    int start = 0; int end = arrLength - 1;

        //    QuickSortRecursive(InputArr, start, end);

        //    for (int i = 0; i < InputArr.Length; i++)
        //    {
        //        Console.Write(InputArr[i] + ",");
        //    }
        //}

        //public static void QuickSortRecursive(int[] InputArr, int start, int end)
        //{
        //    if (start < end)
        //    {
        //        int partitionedIndex = Partition(InputArr, start, end);
        //        if (partitionedIndex > 1)
        //        {
        //            QuickSortRecursive(InputArr, start, partitionedIndex - 1);
        //        }
        //        if (partitionedIndex + 1 < end)
        //        {
        //            QuickSortRecursive(InputArr, partitionedIndex + 1, end);
        //        }
        //    }

        //    return InputArr;
        //}

        //public static int Partition(int[] inputArr, int start, int end)
        //{


        //    int pivot = inputArr[end]; int i = start - 1; int temp;

        //    for (int j = start; j < end; j++)
        //    {
        //        if (inputArr[j] <= pivot)
        //        {
        //            i = i + 1;
        //            temp = inputArr[i];
        //            inputArr[i] = inputArr[j];
        //            inputArr[j] = temp;
        //        }
        //    }
        //    temp = inputArr[i + 1];
        //    inputArr[i + 1] = pivot;
        //    pivot = temp;

        //    return i + 1;
        //}


    }
}
