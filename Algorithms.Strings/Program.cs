using System;

namespace Algorithms.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringComparisions sc = new StringComparisions();
            //sc. TryStringComparisions();
            

            StringAlgos strAlgos = new StringAlgos();

            //Console.WriteLine(strAlgos.ReverseString("Gopala"));
            //Console.WriteLine(strAlgos.ParallelReverseString("ParallelGopala"));
            //Console.WriteLine(strAlgos.ReverseWords("Gopala Krishna"));
            //Console.WriteLine(strAlgos.Palindrome("abcba"));
            //Console.WriteLine(strAlgos.SearchSubString("ABCDEFGHIJKLMNOP","DEF"));

            //strAlgos.SearchSubString();
            //Console.WriteLine("Please input any number");
            //var input = Console.ReadLine();
            //strAlgos.NumberInWords(Convert.ToInt64(input));
            ////strAlgos.ReverseWords("Gopala krishna is great");

            strAlgos.MetaStrings();

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