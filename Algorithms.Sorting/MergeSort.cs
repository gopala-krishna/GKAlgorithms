using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    class MergeSort
    {
        public void MergeSort1(int[] inputArr)
        {
            MergeSortRecursive(inputArr, 0, inputArr.Length - 1);

            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write(inputArr[i] + ",");
            }
        }

        public void MergeSortRecursive(int[] inputArr, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                MergeSortRecursive(inputArr, start, mid);
                MergeSortRecursive(inputArr, mid + 1, end);
                Merge(inputArr, start, mid, end);
            }
        }
        
        public void Merge(int[] inputArr, int start, int mid, int end)
        {
            int n1 = mid - start + 1; int n2 = end - mid; 
            int[] leftArr = new int[n1];  int[] rightArr = new int[n2];

            for (int i = 0; i < n1; ++i)
            {
                leftArr[i] = inputArr[i+start];
            }

            for (int j =0 ; j < n2; ++j)
            {
               rightArr[j] = inputArr[mid+1+j];
            }
             
           int m = 0; int n = 0; int p = 1;



            while (m<n1 && n< n2)
            {
                if (leftArr[m] <= rightArr[n])
                {
                    inputArr[p] = leftArr[m];
                    m++;
                }
                else
                {
                    inputArr[p] = rightArr[n];
                    n++;
                }
                p++;
            }

            while (m < n1)
            {
                inputArr[p] = leftArr[m];
                m++; p++;
            }

            while (n< n2)
            {
                inputArr[p] = rightArr[n];
                n++; p++;
            }


        }
    }
}
