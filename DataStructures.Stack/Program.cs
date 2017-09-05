using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackUsingArray sua = new StackUsingArray();

            //sua.Push(10);
            //sua.Push(20);
            //sua.Push(30);
            //sua.Push(40);

            //sua.Pop();
            
            //Console.WriteLine(sua.Peek());

            ReverseString rs = new ReverseString();
            rs.ReverseStringUsingStack("Gopala");

            Console.Read();
        }
    }
}
