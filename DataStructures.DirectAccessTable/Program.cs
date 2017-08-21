using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DirectAccessTable
{
    class Program
    {
        /// <summary>
        /// Make a big array and use elements as index in the array. An entry in array is NIL if elements is not present, else the array entry stores pointer to records 
        /// corresponding to element. Time complexity wise this solution is the best among all, we can do all operations in O(1) time. 
        /// For example to insert an element, we create a record with details of given element, use element as index and store the pointer to the created record in table.
        //This solution has many practical limitations.
        //First problem with this solution is extra space required is huge.For example if element is n digits, we need O(m* 10n) space for table where m is size of a pointer
        //to record.Another problem is an integer in a programming language may not store n digits
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }
    }
}
