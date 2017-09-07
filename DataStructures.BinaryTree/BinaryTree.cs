using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        // Root of Binary Tree
            public Node root;

        // Constructors
        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(int key)
            {
                root = new Node(key);
            }
    }
}
