using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class SubArrayWithGivenSum
    {
        public void SubArrayWithGivenSum1(long[] inputArr, long sum)
        {
             long start=0 ; long end =0;
            
            for (long i = 0; i < inputArr.Length; i++)
            {
                long addsum = inputArr[i];  start = i; 

                for (long j = i+1; j < inputArr.Length; j++)
                {
                    addsum += inputArr[j];

                    if (addsum > sum) break;

                    else if (addsum == sum)
                    {
                        end = j;
                        Console.WriteLine(start); Console.WriteLine(end);
                        Console.WriteLine("-------");
                        break;
                    }
                }
            }
            

        }
    }
}
