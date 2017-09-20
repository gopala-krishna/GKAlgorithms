using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Strings
{
    public class ConvertBase
    {
        public void ConvertBase1(int baseInt, int targetBase)
        {
            List<int> result = new List<int>();
            while (baseInt > 0)
            {
                result.Add(baseInt % targetBase);
                baseInt = baseInt / targetBase;
            }
            result.Reverse();
            foreach(var i in result)
            Console.Write(i.ToString());
        }
    }
}
