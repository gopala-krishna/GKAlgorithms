using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Queue;

namespace DataStructures.BinarySearchTree
{
    class BreadthFirstTransversals
    {
       
        /* function to print level order traversal of tree*/
        public void PrintLevelOrderRecursive(Node root)
        {
            int h = Height(root);
            int i;
            for (i = 1; i <= h; i++)
                PrintGivenLevel(root, i);
        }

        /* Compute the "height" of a tree -- the number of
        nodes along the longest path from the root node
        down to the farthest leaf node.*/
        private int Height(Node root)
        {

            if (root == null)
                return 0;
            else
            {
                /* compute  height of each subtree */
                int lheight = Height(root.left);
                int rheight = Height(root.right);

                /* use the larger one */
                if (lheight > rheight)
                    return (lheight + 1);
                else return (rheight + 1);
            }
        }
   
        /* Print nodes at the given level */
        private void PrintGivenLevel(Node root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.WriteLine(root.key + " ");
            else if (level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
            }
        }


        /// <summary>
        ///  Very efficient :)
        /// </summary>
        /// <param name="root"></param>
        public void PrintLevelOrderUsingQueue(Node root)
        {
            Queue<Node> queue = new Queue<Node>(1024);

            queue.Enqueue(root);
                                                                         //   60 80 20 40 70 30 50 
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node != null)
                {
                    Console.WriteLine(node.key);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }
        }
    }
}

