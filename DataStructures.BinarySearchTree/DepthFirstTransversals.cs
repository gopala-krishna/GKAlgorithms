using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    class DepthFirstTransversals
    {

        /// <summary>
        ///  Depth First Transversals - InOrder(Left, Root, Right) 
        ///  Time Complexity :O(N)
        /// </summary>
        // This method mainly calls InorderRec()
        public void Inorder(Node root)
        {
            InorderRec(root);
        }

        // A utility function to do inorder traversal of BST
        void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.WriteLine(root.key);
                InorderRec(root.right);
            }
        }

        /// <summary>
        ///  Depth First Transversals - PreOrder(Root, Left, Right)
        ///  Time Complexity :O(N)
        /// </summary>
        public void Preorder(Node root)
        {
            PreorderRec(root);
        }

        // A utility function to do pre order traversal of BST
        void PreorderRec(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.key);
                PreorderRec(root.left);
                PreorderRec(root.right);
            }
        }

        public void Postorder(Node root)
        {
            PostorderRec(root);
        }

        /// <summary>
        ///  Depth First Transversals - PostOrder(Left, Right, Root)
        ///  Time Complexity :O(N)
        /// </summary>
        // A utility function to do  postorder traversal of BST
        void PostorderRec(Node root)
        {
            if (root != null)
            {
                PostorderRec(root.left);
                PostorderRec(root.right);
                Console.WriteLine(root.key);
            }
        }
    }
}
