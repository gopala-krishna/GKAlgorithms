using System;

namespace Algorithms.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = TakeFactorialInput();


            FactorialWithForLoop floop = new FactorialWithForLoop();
            var output = floop.FactorialUsingForLoop(input);

            //FactorialWithRecursion frecu = new FactorialWithRecursion();
            //var output = frecu.FactorialUsingRecursion(input);

            ShowFactorialResult(output);
            Console.Read();
        }

        #region Input and Output Funtions for Factorial
        private static long TakeFactorialInput()
        {
            Console.WriteLine("Please input a number");
            string number = Console.ReadLine();
            return Convert.ToInt64(number);
        }
        private static void ShowFactorialResult(long result)
        {
                    Console.WriteLine(result.ToString());
        }
        #endregion Input and Output Funtions for Factorial
    }
}