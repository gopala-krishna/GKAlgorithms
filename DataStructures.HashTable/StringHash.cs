using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    class StringHash
    {
        public void StringHash1(string str)
        {
            bool[] prime = new bool[103];
            int[] primes = new int[26];
            for (int i = 0; i < 102; i++)
                prime[i] = true;

            for (int p = 2; p * p <= 103; p++)
            {
                // If prime[p] is not changed, then it is a prime
                if (prime[p] == true)
                {
                    // Update all multiples of p
                    for (int i = p * 2; i <= 103; i += p)
                        prime[i] = false;
                }
            }
            Dictionary<char, int> dict = new Dictionary<char, int>(); int j = 0;
            for (int i = 2; i <= 102; i++)
            {
                if (prime[i] == true)
                {
                    primes[j] = i; j++;
                }
            }

            int k = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                dict.Add(c, primes[k]); k++;
            }

            int hash = 1;

            for (int i = 0; i <str.Length ; i++)
            {
                hash *= dict[str[i]];
            }

            Console.WriteLine(hash.ToString());

        }
    }
}
