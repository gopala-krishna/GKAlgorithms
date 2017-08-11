using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            SubArrayWithGivenSum sawgs = new SubArrayWithGivenSum();

            var input = TakeSearchInput();
            sawgs.SubArrayWithGivenSum1(input, 6);
            Console.Read();
        }

        #region Input and Output Funtions for Search
        private static long[] TakeSearchInput()
        {
            Console.WriteLine("Please input numbers seperated by comma");
            string numbers = Console.ReadLine();
            var arrRawInput = numbers.Split(new char[] { ',' });
            long[] arrInput = new long[arrRawInput.Length];

            if (numbers.Length > 0)
            {
                for (int i = 0; i < arrRawInput.Length; i++)
                {
                    arrInput[i] = Convert.ToInt32(arrRawInput[i]);
                }
            }
            else
            {
                Console.WriteLine("Please input numbers seperated by ", " ");
            }
            return arrInput;
        }
        //private static void ShowSearchResult(MinMaxPair arrResult)
        //{
        //    Console.Write(arrResult.MinValue.ToString() + ",");
        //    Console.Write(arrResult.MaxValue.ToString());
        //}
        #endregion Input and Output Funtions for Search
    }
}
