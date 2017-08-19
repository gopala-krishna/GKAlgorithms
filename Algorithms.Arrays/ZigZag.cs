using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class ZigZag
    {
        /// <summary>
        ///  Check whether the sequence is zig zag
        ///  Time Complexity : O(N)
        /// </summary>
        /// <param name="intArr"></param>
        public void IsZigzag(int[] intArr)
        {
             bool increasing = false; bool IsZigzag = true;
            if (intArr[0] < intArr[1])
            {
                increasing = true;
            }
            if (increasing)
            {
                for (int i = 1; i< intArr.Length-1; i+=2)
                {
                    if (intArr[i-1] > intArr[i] || intArr[i+1] > intArr[i])
                    {
                        IsZigzag = false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < intArr.Length - 1; i+=2)
                {
                    if (intArr[i - 1] < intArr[i] || intArr[i + 1] < intArr[i])
                    {
                        IsZigzag = false;
                    }
                }
            }

            if (IsZigzag)
            {
                Console.WriteLine("This is a zigzag sequence");
            }
            else
            {
                Console.WriteLine("This is a not zigzag sequence");
            }



        }

        public void LongestZigzagSubString(int[] intArr)
        {
            int i = 1;
            while (i < intArr.Length)
            {
               
                


            }

        }
    }
}
