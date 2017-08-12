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

            strAlgos.SearchSubString();

            //strAlgos.ReverseWords("Gopala krishna is great");

            Console.Read();
        }
    }
}