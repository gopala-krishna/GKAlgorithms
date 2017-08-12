using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Math
{
    class PrimeNumbers
    {
        /* 
        --------------------------------------------------------------------------------
                                              Algorithm
        ---------------------------------------------------------------------------------
           
            Create a results list, filled with 2, 3, and 5.
            Create a sieve list with an entry for each positive integer; all entries of this list should initially be marked non prime.
            For each entry number n in the sieve list, with modulo-sixty remainder r:
                If r is 1, 13, 17, 29, 37, 41, 49, or 53, flip the entry for each possible solution to 4x2 + y2 = n.
                If r is 7, 19, 31, or 43, flip the entry for each possible solution to 3x2 + y2 = n.
                If r is 11, 23, 47, or 59, flip the entry for each possible solution to 3x2 – y2 = n when x > y.
                If r is something else, ignore it completely..
            Start with the lowest number in the sieve list.
            Take the next number in the sieve list still marked prime.
            Include the number in the results list.
            Square the number and mark all multiples of that square as non prime. Note that the multiples that can be factored by 2, 3, or 5 need not be marked, as these will be ignored in the final enumeration of primes.
            Repeat steps four through seven.

        ----------------------------------------------------------------------------------            
        */
        public void SieveofAtkin()
        {


        }



        /* 
         --------------------------------------------------------------------------------
                                               Algorithm
         ---------------------------------------------------------------------------------
             1) In general Sieve of Sundaram, produces primes smaller than 
               (2*x + 2) for a number given number x. Since we want primes 
               smaller than n, we reduce n-2 to half. We call it nNew.
                   nNew = (n-2)/2;
               For example, if n = 102, then nNew = 50.

            2) Create an array marked[n] that is going 
               to be used to separate numbers of the form i+j+2ij from 
               others where  1 <= i <= j

            3) Initialize all entries of marked[] as false.

            4) // Mark all numbers of the form i + j + 2ij as true
               // where 1 <= i <= j
               Loop for i=1 to nNew
                    a) j = i; 
                    b) Loop While (i + j + 2*i*j) <= nNew
                         (i)  primes[i + j + 2*i*j] = true;
                         (ii) j++

            5) If n > 2, then print 2 as first prime.

            6) Remaining primes are of the form 2i + 1 where i is
               index of NOT marked numbers. So print 2i + 1 for all i
               such that marked[i] is false.
         ----------------------------------------------------------------------------------            
         */
        public void SieveOfSundaram()
        { }

        /* 
      --------------------------------------------------------------------------------
                                            Algorithm
      ---------------------------------------------------------------------------------

Following is the algorithm to find all the prime numbers less than or equal to a given integer n by Eratosthenes’ method:

    Create a list of consecutive integers from 2 to n: (2, 3, 4, …, n).
    Initially, let p equal 2, the first prime number.
    Starting from p, count up in increments of p and mark each of these numbers greater than p itself in the list. These numbers will be 2p, 3p, 4p, etc.; note that some of them may have already been marked.
    Find the first number greater than p in the list that is not marked. If there was no such number, stop. Otherwise, let p now equal this number (which is the next prime), and repeat from step 3.

     When the algorithm terminates, all the numbers in the list that are not marked are prime. 

      ----------------------------------------------------------------------------------            
      */
        public void SieveofEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];
            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2;  p * p <=n ; p++)
            {
                // If prime[p] is not changed, then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * 2; i<=n; i += p)
                        prime[i] = false;
                }
            }
            // Print all prime numbers
            for (int i = 2; i<=n ; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + ",");
            }




        }

    }
}
