using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSetBasics();
            Console.Read();
        }

        /// <summary>
        /// Hashset removes all duplicate values added to it
        ///This class represent a set of values.
        ///This class provides high-performance set of operations.
        ///This is a set of collection that contains no duplicate elements and there is no specific order for the elements stored in it.
        ///In the .NET Framework 4.6 release, the HashSet implements IReadOnlyCollection interface along with the ISet interface.
        ///The HashSet class does not have any maximum capacity for the number of elements stored in it.This capacity keeps increasing as the number of elements are added in it.
       /// </summary>
        public static void HashSetBasics()
        {
            HashSet<string> hs = new HashSet<string>();

            hs.Add("Gopala");
            hs.Add("Gopala");
            hs.Add("Krishna");
            hs.Add("Krishna");
            hs.Add("Krishna");
            hs.Add("Rao");
            foreach (var i in hs)
            {
                Console.WriteLine(i);
            }

        }
    }
}
