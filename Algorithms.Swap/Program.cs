using System;

namespace Algorithms.Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = TakeSwapInput();

           

            //SwapWithTempVariable swapTemp = new SwapWithTempVariable();
            //var output = swapTemp.SwapUsingTempVar(input);

            SwapWithTempVariable swapGenerics = new SwapWithTempVariable();
            var output = swapGenerics.SwapUsingTempVar(input);


            ShowSwapResult(output);
            Console.Read();

        }


        #region Input and Output Funtions for Swap
        private static int[] TakeSwapInput()
        {
            Console.WriteLine("Please input two numbers seperated by comma");
            string numbers = Console.ReadLine();
            var arrRawInput = numbers.Split(new char[] { ',' });
            int[] arrInput = new int[arrRawInput.Length];

            if (numbers.Length > 0)
            {
                for (int i = 0; i < arrRawInput.Length; i++)
                {
                    arrInput[i] = Convert.ToInt32(arrRawInput[i]);
                }
            }
            else
            {
                Console.WriteLine("Please input numbers seperated by ", " ");
            }
            return arrInput;
        }
        private static void ShowSwapResult(int[] arrResult)
        {
            for (int i = 0; i < arrResult.Length; i++)
            {
                if (i < arrResult.Length - 1)
                    Console.Write(arrResult[i].ToString() + ",");
                else
                    Console.Write(arrResult[i].ToString());
            }
        }
        #endregion Input and Output Funtions for Swap

    }
}