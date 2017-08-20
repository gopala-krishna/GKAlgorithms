using System;

namespace Algorithms.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var input = TakeSortingInput();

            //BubbleSort bs = new BubbleSort();
            //var output = bs.BubbleSort1(input);

            //InsertionSort ins = new InsertionSort();
            //ins.InsertionSort2(input);

            //ShellSort shs = new ShellSort();
            //var output = shs.ShellSort1(input, input.Length);


            //QuickSort shs = new QuickSort();
            //shs.QuickSort1(input);

            //MergeSort.MergeSort1(input);

           // ShowSortingResult(output);
            Console.Read();

        }

        #region Input and Output Funtions for Sorting
        private static int[] TakeSortingInput()
        {
            Console.WriteLine("Please input numbers seperated by comma");
            string numbers = Console.ReadLine();
             var arrRawInput = numbers.Split(new char[] { ',' });
            int[] arrInput = new int[arrRawInput.Length];

            if (numbers.Length >0)
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
        private static void ShowSortingResult(int[] arrResult)
        {
            for (int i = 0; i < arrResult.Length; i++)
            {
                if(i < arrResult.Length-1)
                    Console.Write(arrResult[i].ToString() + ",");
                else
                   Console.Write(arrResult[i].ToString());
            }
        }
        #endregion Input and Output Funtions for Sorting
    }
}