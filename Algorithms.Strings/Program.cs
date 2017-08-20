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

            StringsFromChars sc = new StringsFromChars();
            char[] charset = new char[] { 'a', 'b', 'c' };
            int arraySize = 3;
            sc.StringsFromChars3(charset, arraySize);
            Console.Read();
        }
    }
}