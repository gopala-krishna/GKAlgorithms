using System;

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
            var input = TakeInput();
            MaxDiffWithMinbeforeMax maxdiff = new MaxDiffWithMinbeforeMax();
            var output = maxdiff.EfficientWithMinValueTracking(input, input.Length);
            ShowResult(output);
            Console.Read();

        }

        #region Input and Output Funtions for Finding Max Difference
        private static long[] TakeInput()
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
        private static void ShowResult(long arrResult)
        {
            Console.Write(arrResult.ToString());
             
        }
        #endregion Input and Output Funtions for Finding Max Difference
    }
}