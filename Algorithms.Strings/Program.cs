using System;

namespace Algorithms.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringComparisions sc = new StringComparisions();

            SearchSubString sss = new SearchSubString();
            sss.SearchSubString2();
            //StringToASCII st = new StringToASCII();
            //st.StringToASCII1();

            //IsPermutation ip = new IsPermutation();
            //ip.IsPermutation2("GOPALA", "OGPALA");

            //char[] set = new char[] { 'a', 'b', 'c' }; int arrSize = 2;
            //StringsFromChars sfc = new StringsFromChars();
            //sfc.StringsFromChars1(set, arrSize);

            //Permutations p = new Permutations();
            //p.GetPermutations("abc");

            //Permutations p = new Permutations();
            //p.GetPermutationsWithoutDuplicates("aba");

            //OneAway ow = new OneAway();
            //ow.IsOneAway("pale", "bale");

           // StringCompression sc = new StringCompression();
           // string s =sc.StringCompression1("abcd");

            //PermutationPalindrome pp = new PermutationPalindrome();
            //pp.IsPermutationPalindrome("tactcoa");
            //pp.PalindromePermutations("abc");


            //const string input = "abc d e f";
            //var characterArray = new char[input.Length + 3 * 2 + 1];
            //for (var i = 0; i < input.Length; i++)
            //{
            //    characterArray[i] = input[i];
            //}
            //URLify u = new URLify();
            //u.URLify1(characterArray, input.Length);

            //PermutationPalindrome pp = new PermutationPalindrome();
            //pp.GetCombinations();


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