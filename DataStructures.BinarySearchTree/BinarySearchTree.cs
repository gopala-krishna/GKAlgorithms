using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    /* Class containing left and right child of current node and key value*/
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
    public class BinarySearchTree
    {
        // Root of BST
        public Node root;

        // Constructor
        public BinarySearchTree()
        {
            root = null;
        }

        /// <summary>
        /// Time Complexity: O(logN)
        /// </summary>
        /// <param name="key"></param>
        // This method mainly calls insertRec()
        public void Insert(int key)
        {
            root = InsertRec(root, key);
        }

        /* A recursive function to insert a new key in BST */
        Node InsertRec(Node root, int key)
        {

            /* If the tree is empty, return a new node */
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            /* return the (unchanged) node pointer */
            return root;
        }

        

        /// <summary>
        /// Time Complexity: O(logN)
        /// </summary>
        /// <param name="key"></param>
        // This method mainly calls deleteRec()
        public void DeleteKey(int key)
        {
            root = DeleteRec(root, key);
        }

        /* A recursive function to delete a key in BST */
        Node DeleteRec(Node root, int key)
        {
            /* Base Case: If the tree is empty */
            if (root == null) return root;

            /* Otherwise, recur down the tree */
            if (key < root.key)
                root.left = DeleteRec(root.left, key);
            else if (key > root.key)
                root.right = DeleteRec(root.right, key);

            // if key is same as root's key, then This is the node
            // to be deleted
            else
            {
                // node with only one child or no child
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                // node with two children: Get the inorder successor (smallest
                // in the right subtree)
                root.key = MinValue(root.right);

                // Delete the inorder successor
                root.right = DeleteRec(root.right, root.key);
            }
            return root;
        }

        int MinValue(Node root)
        {
            int minv = root.key;
            while (root.left != null)
            {
                minv = root.left.key;
                root = root.left;
            }
            return minv;
        }

        /// <summary>
        /// Time Complexity: O(logN)
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node Search(Node root, int key)
        {
            // Base Cases: root is null or key is present at root
            if (root == null || root.key == key)
            {
                return root;
            }
            // val is greater than root's key
            if (root.key > key)
                return Search(root.left, key);

            // val is less than root's key
            return Search(root.right, key);
        }
    }
}

