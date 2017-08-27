using System;

namespace Algorithms.Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringRotation sr = new StringRotation();
            //sr.AreRotaredStrings("water", "terwa");
            //Console.Read();

            //StringsFromChars sc = new StringsFromChars();
            // char[] charset = new char[] { 'a', 'b','c' };
            //int arraySize = 3;
            //sc.StringsFromChars4(charset, "",arraySize);
            //Console.Read();

            //Permutations P = new Permutations();
            // P.GetPermutationsWithoutDuplicates("abcc");
            //Console.Read();

            //P.GetPermutationsWithRepititionOfChars("abc");

            //StringToASCII sc = new StringToASCII();
            //sc.StringToASCII2("abcdefg");

            //IsPermutation ip = new IsPermutation();
            //ip.IsPermutation1("gopala", "gbplaa");

            string[] strArr = new string[] { "Gopala", "Krishna", "Rao" };
            ReverseWords rw = new ReverseWords();
            rw.ReverseWords2(strArr);


            //StringRotation sr = new StringRotation();
            //sr.StringRotation123("Gopala", "palaGa");

            //SearchSubString ss = new SearchSubString();
            //ss.SearchSubstring3("abcabcdgb", "abc");

            Console.Read();
        }
    }
}