﻿using System;
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
            Console.WriteLine("Please input an interger");
            var input = Console.ReadLine();
            PrimeNumbers primes = new PrimeNumbers();
            primes.SieveofEratosthenes(Convert.ToInt32(input));

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
