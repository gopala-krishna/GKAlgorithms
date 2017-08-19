using System;
using Algorithms.Entities;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = TakeInput();
            //MaxDiffWithMinbeforeMax maxdiff = new MaxDiffWithMinbeforeMax();
            //var output = maxdiff.SimpleWithTwoLoops(input, input.Length);
            //ShowResult(output);

            //var input = TakeInput();
            //MaxDiffWithMinbeforeMax maxdiff = new MaxDiffWithMinbeforeMax();
            //var output = maxdiff.EfficientWithMinValueTracking(input);
            //ShowResult(output);


            //var input = TakeInput();
            //BuySellWithMaxProfit bswmp = new BuySellWithMaxProfit();
            //bswmp.EfficientBuySellPairsWithMaxProfit(input);
            ////ShowMaxProfitPairs(output);
            //ShowResult(output);

            //ClockAngle ca = new ClockAngle();
            //ca.HMClockAngle(39, 75);

            MinimumSquares ms = new MinimumSquares();
            ms.MinimumSquares1(15, 4);


            Console.Read();
        }

        #region Input and Output Funtions 
        private static int[] TakeInput()
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
        private static void ShowResult(long arrResult)
        {
            Console.Write(arrResult.ToString());
             
        }

        private static void ShowMaxProfitPairs(List<BuySellInterval> Intervals)
        {
            if (Intervals.Count > 0)
            {
                foreach (BuySellInterval bsi in Intervals)
                {
                    Console.WriteLine(bsi.Buy.ToString() + "," + bsi.Sell.ToString());
                }
            }
            else
            {
                Console.WriteLine("No Luck");
            }
        }
        #endregion Input and Output Funtions 
    }
}