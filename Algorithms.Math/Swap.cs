using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    public class Swap
    {

        /// <summary>
        ///  Simple
        /// </summary>
        /// <param name="arrInput"></param>
        /// <returns></returns>
        public static void SimpleSwap(int a, int b)
        {
            int iTemp = a;
            a = b;
            b = iTemp;
        }
        /// <summary>
        ///  Simple
        /// </summary>
        /// <param name="arrInput"></param>
        /// <returns></returns>
        public static int[] SwapUsingTempVar(int[] arrInput)
        {
            
            int iTemp = arrInput[0];
            arrInput[0] = arrInput[1];
            arrInput[1] = iTemp;
            return arrInput;
        }
        /// <summary>
        ///  Generic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrInput"></param>
        /// <returns></returns>
        public static T[] SwapUsingGenerics<T>(T[] arrInput)
        {
            
            T  iTemp = arrInput[0];
            arrInput[0] = arrInput[1];
            arrInput[1] = iTemp;
            return arrInput;
        }
    }
}
