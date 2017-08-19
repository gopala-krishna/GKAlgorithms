using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Sorting;

namespace Algorithms.Math
{
    class KthSmallest
    {
        public void GetKthSmallestSorted(int[] intArr, int k)
        {
            Console.WriteLine(intArr[k - 1].ToString());
        }
        public void GetKthSmallestUnsorted(int[] intArr, int k)
        {
            MergeSort.MergeSort1(intArr);
            Console.WriteLine(intArr[k-1].ToString());
        }

    }
}
