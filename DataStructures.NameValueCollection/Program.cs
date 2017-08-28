using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace DataStructures.NameValueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 476;

            System.Collections.Specialized.NameValueCollection nv = new System.Collections.Specialized.NameValueCollection();
            nv.Add("a", "Gopala");
            nv.Add("a", "Krishna");

            nv.Add(i.ToString(), "Gop");
            nv.Add(i.ToString(), "Kris");

            var values = nv.GetValues("a");

            foreach (var j in values)
            {
                Console.WriteLine(j.ToString());
            }
            Console.Read();

        }
    }
}
