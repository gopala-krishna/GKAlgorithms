using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //PrimeNumbers primes = new PrimeNumbers();
            //primes.SieveofEratosthenes(Convert.ToInt32(input));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //Fibonacci fb = new Fibonacci();
            //Console.WriteLine(fb.NthFibonacciIterative(Convert.ToInt32(input)));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //Fibonacci fb = new Fibonacci();
            //// fb.FibonacciSeriesIterative(Convert.ToInt32(input));
            //fb.FibonacciSeriesRecursive(Convert.ToInt32(input));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //Factors fb = new Factors();
            //// fb.FibonacciSeriesIterative(Convert.ToInt32(input));
            //fb.PrintFactors(Convert.ToInt32(input));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //Magicumbers mn = new Magicumbers();
            //mn.MagicNumbers(Convert.ToInt32(input));
            ////mn.GetFactorsSum(Convert.ToInt32(input));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //PrimeFactors pf = new PrimeFactors();
            //pf.PrimeFactors1(Convert.ToInt32(input));
            ////bool res = pf.IsPrime(Convert.ToInt32(input));
            //mn.GetFactorsSum(Convert.ToInt32(input));

            //Console.WriteLine("Please input an interger");
            //var input = Console.ReadLine();
            //Factorial f = new Factorial();
            //f.DigitsCountFactorial(Convert.ToInt32(input));

            BiggestNumberFromNumbers bg = new BiggestNumberFromNumbers();
            bg.BiggestNumberFromNumbers1();

            Console.Read();
        }

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
    }
}
