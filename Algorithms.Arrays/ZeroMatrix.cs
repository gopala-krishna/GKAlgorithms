using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Arrays
{
    class ZeroMatrix
    {

        public void ZeroMatrix1()
        {
            int[,] zeroArr = new int[3, 3] { { 1, 2, 3 }, { 4, 0, 6}, { 7, 8, 9 } };


            int[] row = new int[3]  ;
            int[] col = new int[3];

            int i, j;


            /* Initialize all values of row[] as 1 */
            for (i = 0; i < 3; i++)
            {
                row[i] = 1;
            }


            /* Initialize all values of col[] as 1 */
            for (i = 0; i < 3; i++)
            {
                col[i] = 1;
            }


            /* Store the rows and columns to be marked as 1 in row[] and col[]
               arrays respectively */
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (zeroArr[i,j] == 0)
                    {
                        row[i] = 0;
                        col[j] = 0;
                    }
                }
            }

            /* Modify the input matrix mat[] using the above constructed row[] and
               col[] arrays */
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (row[i] == 0 || col[j] == 0)
                    {
                        zeroArr[i,j] = 0;
                    }
                }
            }
        }
    }
}
