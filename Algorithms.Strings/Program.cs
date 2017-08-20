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
            //char[] charset = new char[] { 'a', 'b', 'c','d','e' };
            //int arraySize = 3;
            //sc.StringsFromChars3(charset, arraySize);
            //Console.Read();

            //Permutations P = new Permutations();
            //P.GetPermutationsWithoutDuplicates("abcc");
            //Console.Read();

            //P.Permutations1(charset);

            IsPermutation ip = new IsPermutation();
            ip.IsPermutation1("gopala", "gbplaa");
            Console.Read();
        }
    }
}