using System;

namespace Algorithms.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringComparisions sc = new StringComparisions();
            //sc. TryStringComparisions();
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
            //strAlgos.MetaStrings();

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

            OneAway ow = new OneAway();
            ow.IsOneAway("pale", "bale");


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