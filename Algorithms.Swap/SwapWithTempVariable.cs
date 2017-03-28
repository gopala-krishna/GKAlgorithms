using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Swap
{
    class SwapWithTempVariable
    {
        public int[] SwapUsingTempVar(int[] arrInput)
        {
            int iTemp;
            iTemp = arrInput[0];
            arrInput[0] = arrInput[1];
            arrInput[1] = iTemp;
            return arrInput;
        }

    }
}
