using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        //public void MergeSort1(int[] inputArr)
        //{
        //    MergeSortRecursive(inputArr, 0, inputArr.Length - 1);

        //    for (int i = 0; i < inputArr.Length; i++)
        //    {
        //        Console.Write(inputArr[i] + ",");
        //    }
        //}

        //public void MergeSortRecursive(int[] inputArr, int start, int end)
        //{
        //    if (start < end)
        //    {
        //        int mid = (start + end) / 2;
        //        MergeSortRecursive(inputArr, start, mid);
        //        MergeSortRecursive(inputArr, mid + 1, end);
        //        Merge(inputArr, start, mid, end);
        //    }
        //}

        //public void Merge(int[] inputArr, int start, int mid, int end)
        //{
        //    int n1 = mid - start + 1; int n2 = end - mid; 
        //    int[] leftArr = new int[n1];  int[] rightArr = new int[n2];

        //    for (int i = 0; i < n1; ++i)
        //    {
        //        leftArr[i] = inputArr[i+start];
        //    }

        //    for (int j =0 ; j < n2; ++j)
        //    {
        //       rightArr[j] = inputArr[mid+1+j];
        //    }

        //leftArr[n1 +1] = 100000;
        //rightArr[n2 + 1] = 100000;

        //int m = 1; int n = 1;

        //for (int p = start; p < end; p++)
        //{
        //    if (leftArr[m] <= rightArr[n])
        //    {
        //        inputArr[p] = leftArr[m];
        //        m++;
        //    }
        //    else
        //    {
        //        leftArr[p] = rightArr[n];
        //        n++;
        //    }

        //}


        //while (m<n1 && n< n2)
        //{
        //    if (leftArr[m] <= rightArr[n])
        //    {
        //        inputArr[p] = leftArr[m];
        //        m++;
        //    }
        //    else
        //    {
        //        inputArr[p] = rightArr[n];
        //        n++;
        //    }
        //    p++;
        //}

        //while (m < n1)
        //{
        //    inputArr[p] = leftArr[m];
        //    m++; p++;
        //}

        //while (n< n2)
        //{
        //    inputArr[p] = rightArr[n];
        //    n++; p++;
        //}

        public static void MergeSortIterative(int[] input, int low, int high)
        {
            if (low < high)
            {
                int middle = (low / 2) + (high / 2);
                MergeSortIterative(input, low, middle);
                MergeSortIterative(input, middle + 1, high);
                Merge(input, low, middle, high);
            }
        }

        public static void MergeSort1(int[] input)
        {
            MergeSortIterative(input, 0, input.Length - 1);


            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + ",");
            }
        }

    

        private static void Merge(int[] input, int low, int middle, int high)
        {

            int left = low;
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
