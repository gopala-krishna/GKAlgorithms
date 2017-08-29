using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class SubArrayWithGivenSum
    {
        /// <summary>
        /// Time Complexity : O(N*N)
        /// </summary>
        /// <param name="inputArr"></param>
        /// <param name="sum"></param>
        public void SubArrayWithGivenSum1(int[] inputArr, int sum)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                int addsum = inputArr[i];
                if (addsum == sum)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("-------");
                }

                for (int j = i+1 ; j < inputArr.Length; j++)
                {
                   
                   addsum += inputArr[j];
                   if (addsum == sum)
                    { 
                        Console.WriteLine(i); Console.WriteLine(j);
                        Console.WriteLine("-------");
                    }
                }
            }
        }
    }
}
