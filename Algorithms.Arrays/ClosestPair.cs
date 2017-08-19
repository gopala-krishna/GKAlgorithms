using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class ClosestPair
    {
        /// <summary>
        /// We are given two arrays ar1[0…m-1] and ar2[0..n-1] and a number x, 
        /// we need to find the pair ar1[i] + ar2[j] 
        /// such that absolute value of (ar1[i] + ar2[j] – x) is minimum.
        /// </summary>
        public void ClosestPairsFromSortedArrays()
        {
            int[] arr1 = new int[] { 1, 4, 5, 7 };
            int[] arr2 = new int[] { 10, 20, 30, 40 };
            int x = 50; int minVal = int.MaxValue; int ind1 = 0; int ind2 = 0;


            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if ((System.Math.Abs(arr1[i] + arr2[j] - x) < minVal))
                    {
                        minVal = System.Math.Abs(arr1[i] + arr2[j] - x);
                        ind1 = arr1[i];
                        ind2 = arr2[j];
                    }
                }
            }
            Console.WriteLine(ind1.ToString() + "," + ind2.ToString());
        }

       
        public void ClosestPairsFromSortedArrays1()
        {
            int[] arr1 = new int[] { 1, 4, 5, 7 };
            int[] arr2 = new int[] { 10, 20, 30, 40 };
            int x = 32;
            int minVal = int.MaxValue; int ind1 = 0; int ind2 = 0;
            int l = 0; int r = arr2.Length-1;

            while( l<arr1.Length && r>0)
            {
                if ((System.Math.Abs(arr1[l] + arr2[r] - x) < minVal))
                {
                    minVal = System.Math.Abs(arr1[l] + arr2[r] - x);
                    ind1 = arr1[l];
                    ind2 = arr2[r];
                }

                if (arr1[l] + arr2[r] > x)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
            Console.WriteLine(ind1.ToString() + "," + ind2.ToString());
        }
    }
}