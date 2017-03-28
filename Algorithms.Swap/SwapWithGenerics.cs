using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Swap
{
    class SwapWithGenerics
    {
        public T[] SwapUsingGenerics<T>(T[] arrInput)
        {
            T iTemp;
            iTemp = arrInput[0];
            arrInput[0] = arrInput[1];
            arrInput[1] = iTemp;
            return arrInput;
        }
    }
}
