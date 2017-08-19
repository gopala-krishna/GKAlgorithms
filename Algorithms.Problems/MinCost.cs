using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    class MinCost
    {
        /// <summary>
        /// Given a cost matrix cost[][] and a position (m, n) in cost[][], write a function that returns cost of minimum cost path to reach (m, n) from (0, 0). 
        /// Each cell of the matrix represents a cost to traverse through that cell. Total cost of a path to reach (m, n) is sum of all the costs on that 
        /// path (including both source and destination). You can only traverse down, right and diagonally lower cells from a given cell, i.e., from a given 
        /// cell (i, j), cells (i+1, j), (i, j+1) and (i+1, j+1) can be traversed. You may assume that all costs are positive integers
        /// 
        /// Time complexity is exponential
        /// 
        /// </summary>
        public void MinCost1()
        {
            int[,] cost = new int[,]{ {1, 2, 3},{4, 8, 2},{1, 5, 3} };
            int minCost = MinCostRecursive(cost, 2, 2);
            Console.Write(minCost.ToString());
        }
        public int MinCostRecursive(int[,] cost, int m, int n)
        {
            if (n < 0 || m < 0)
                return int.MaxValue;
            else if (m == 0 && n == 0)
                return cost[m,n];
            else
            return cost[m,n] + min(MinCostRecursive(cost, m - 1, n - 1), MinCostRecursive(cost, m - 1, n), MinCostRecursive(cost, m, n - 1));
        }

        int min(int x, int y, int z)
        {
            if (x < y)
                return (x < z) ? x : z;
            else
                return (y < z) ? y : z;
        }

        /// <summary>
        /// Time Complexity :O(M*N)
        /// </summary>
        public void MinCost2()
        {
            int[,] cost = new int[,] { { 1, 2, 3 }, { 4, 8, 2 }, { 1, 5, 3 } };
            int minCost = EfficientMinCost(cost, 2, 2);
            Console.Write(minCost.ToString());
        }
        public int EfficientMinCost(int[,] cost, int m, int n)
        {
            int i, j;

            // Instead of following line, we can use int tc[m+1][n+1] or 
            // dynamically allocate memoery to save space. The following line is
            // used to keep te program simple and make it working on all compilers.
            int[,] tc = new int[m+1,n+1];  
            tc[0,0] = cost[0,0];
 
         /* Initialize first column of total cost(tc) array */
             for (i = 1; i <= m; i++)
                tc[i,0] = tc[i - 1,0] + cost[i,0];
 
         /* Initialize first row of tc array */
         for (j = 1; j <= n; j++)
            tc[0,j] = tc[0,j - 1] + cost[0,j];
 
         /* Construct rest of the tc array */
         for (i = 1; i <= m; i++)
            for (j = 1; j <= n; j++)
                tc[i,j] = min(tc[i - 1,j - 1],tc[i - 1,j],tc[i,j - 1]) + cost[i,j];
 
         return tc[m,n];
      }

}


}
