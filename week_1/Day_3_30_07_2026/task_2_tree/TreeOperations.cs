using System;

namespace SimpleTree
{
    // Represents a node in the Binary Search Tree.
    class Node
    {
        // Stores the data value of the node.
        public int Data;

        // Stores the reference to the left child node.
        public Node Left;

        // Stores the reference to the right child node.
        public Node Right;

        /// <summary>
        /// Initializes a new tree node with the specified data value.
        /// </summary>
        public Node(int data)
        {
            // Assign the given value to the Data field.
            Data = data;

            // Initialize the left child reference as null.
            Left = null;

            // Initialize the right child reference as null.
            Right = null;
        }
    }

    // Performs Binary Search Tree operations.
    class TreeOperations
    {
        // Stores the reference to the root node of the tree.
        public Node Root;

        /// <summary>
        /// Initializes an empty Binary Search Tree.
        /// </summary>
        public TreeOperations()
        {
            // Initially, the tree is empty.
            Root = null;
        }

        /// <summary>
        /// Inserts a new node into the Binary Search Tree.
        /// </summary>
        public void Insert(int data)
        {
            // Call the recursive insertion method.
            Root = InsertNode(Root, data);
        }

        /// <summary>
        /// Recursively inserts a node into the correct
        /// position in the Binary Search Tree.
        /// </summary>
        private Node InsertNode(Node root, int data)
        {
            // Create a new node if the current position is empty.
            if (root == null)
                return new Node(data);

            // Insert into the left subtree if the value is smaller.
            if (data < root.Data)
                root.Left = InsertNode(root.Left, data);
            else
                // Otherwise, insert into the right subtree.
                root.Right = InsertNode(root.Right, data);

            // Return the updated root node.
            return root;
        }

        /// <summary>
        /// Performs an inorder traversal of the Binary Search Tree
        /// and displays the nodes in ascending order.
        /// </summary>
        public void InOrder(Node root)
        {
            // Continue traversal if the current node is not null.
            if (root != null)
            {
                // Visit the left subtree.
                InOrder(root.Left);

                // Display the current node.
                Console.Write(root.Data + " ");

                // Visit the right subtree.
                InOrder(root.Right);
            }
        }
    }
}