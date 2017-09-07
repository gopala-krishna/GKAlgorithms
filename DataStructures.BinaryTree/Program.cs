using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            /*create root*/
            tree.root = new Node(1);

            /* following is the tree after above statement

                  1
                /   \
              null  null     */

            tree.root.left = new Node(2);
            tree.root.right = new Node(3);

            /* 2 and 3 become left and right children of 1
                   1
                 /   \
                2      3
              /    \    /  \
            null null null null  */


            tree.root.left.left = new Node(4);
            /* 4 becomes left child of 2
                        1
                    /       \
                   2          3
                 /   \       /  \
                4    null  null  null
               /   \
              null null
             */

            Console.WriteLine(tree.root.key);
            while(tree.root.left != null || tree.root.right != null)
            {
                if (tree.root.left != null)
                {
                    Console.WriteLine(tree.root.left.key);
                    tree.root.left = tree.root.left.left;
                }

                if (tree.root.right != null)
                {
                    Console.WriteLine(tree.root.right.key);
                    tree.root.right = tree.root.right.right;
                }
            }


            Console.Read();
        }
    }
}
