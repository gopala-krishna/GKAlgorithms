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
            //var input = TakeSearchInput();

            //SubArrayWithGivenSum sawgs = new SubArrayWithGivenSum();
            //var input = TakeSearchInput();
            //sawgs.SubArrayWithGivenSum1(input, 6);

            ClosestPair cp = new ClosestPair();
            cp.ClosestPairsFromSortedArrays1();

            ////var input = TakeSearchInput();

            ////PeaksAndValleys pv = new PeaksAndValleys();
            ////pv.PeaksAndValleys2(input);

           // var input = TakeSearchInput();

            //ZigZag zz = new ZigZag();
            //zz.IsZigzag(input);

            //ZeroMatrix zm = new ZeroMatrix();
            //zm.ZeroMatrix1();


            Console.Read();
        }

        #region Input and Output Funtions for Search
        private static int[] TakeSearchInput()
        {
            Console.WriteLine("Please input numbers seperated by comma");
            string numbers = Console.ReadLine();
            var arrRawInput = numbers.Split(new char[] { ',' });
            int[] arrInput = new int[arrRawInput.Length];

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
