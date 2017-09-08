using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            /* Let us create following BST
                  50
               /     \
              30      70
             /  \    /  \
           20   40  60   80 */

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // print inorder traversal of the BST
            Console.WriteLine("Inorder traversal of the given tree");

            tree.Inorder();

            Console.WriteLine("\nDelete 20");
            tree.DeleteKey(20);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.Inorder();

            Console.WriteLine("\nDelete 30");
            tree.DeleteKey(30);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.Inorder();

            Console.WriteLine("\nDelete 50");
            tree.DeleteKey(50);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.Inorder();

            //tree.Search(null, 50);

            Console.Read();
        }
    }
}
