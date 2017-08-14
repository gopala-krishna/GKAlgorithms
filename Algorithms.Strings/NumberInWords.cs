using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    class NumberInWords
    {
        public void NumberInWords1(long num)
        {
            if (num >= 100000000)
            {
                Console.WriteLine("please input number less than 100000000");
                return;
            }
            string sentence = string.Empty;         //53465781
            sentence += ConvertToWord((num / 10000000), "crore ");
            sentence += ConvertToWord((num / 100000) % 100, "lakh ");
            sentence += ConvertToWord((num / 1000) % 100, "thousand ");
            sentence += ConvertToWord((num / 100) % 10, "hundred ");
            sentence += ConvertToWord(num % 100, " ");

            //if (num > 100 && num % 100)
            //{ 
            //   sentence += "and ";
            //}

            Console.WriteLine(sentence);

        }

        public string ConvertToWord(long n, string word)
        {
            // strings at index 0 is not used, it is to make array
            // indexing simple
            string[] one = { "", "one ", "two ", "three ", "four ",
                "five ", "six ", "seven ", "eight ",
                "nine ", "ten ", "eleven ", "twelve ",
                "thirteen ", "fourteen ", "fifteen ",
                "sixteen ", "seventeen ", "eighteen ",
                "nineteen "
            };

            // strings at index 0 and 1 are not used, they is to
            // make array indexing simple
            string[] ten = { "", "", "twenty ", "thirty ", "forty ",
                "fifty ", "sixty ", "seventy ", "eighty ",
                "ninety "
            };

            string partSentence = string.Empty;

            if (n > 19)
            {
                partSentence += ten[n / 10] + one[n % 10];
            }
            else
                partSentence += one[n % 10];

            if (n > 0)
                partSentence += word;

            return partSentence;
        }

    }
}
