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

            /* Let us create following BST
                  50
               /     \
              30      70
             /  \        /  \
           20   40  60   80 */

            BinarySearchTree tree = new BinarySearchTree();

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // print inorder traversal of the BST
            Console.WriteLine("Inorder traversal of the given tree");

            DepthFirstTransversals tv = new DepthFirstTransversals();
            tv.Inorder(tree.root);

            // print pre order traversal of the BST
            Console.WriteLine("pre order traversal of the given tree");

            tv.Preorder(tree.root);

            // print post order traversal of the BST
            Console.WriteLine("post  order traversal of the given tree");

            tv.Postorder(tree.root);


            //Console.WriteLine("\nDelete 20");
            //tree.DeleteKey(20);
            //Console.WriteLine("Inorder traversal of the modified tree");
            //tree.Inorder();

            //Console.WriteLine("\nDelete 30");
            //tree.DeleteKey(30);
            //Console.WriteLine("Inorder traversal of the modified tree");
            //tree.Inorder();

            Console.WriteLine("\nDelete 70");
            tree.DeleteKey(70);
            Console.WriteLine("Inorder traversal of the modified tree");
            tv.Inorder(tree.root);

            //Console.WriteLine("Searching...");

            //Console.WriteLine(tree.Search(tree.root, 40).key);


            Console.Read();
        }
    }
}
