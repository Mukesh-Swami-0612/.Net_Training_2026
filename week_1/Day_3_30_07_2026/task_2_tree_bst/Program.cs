using System;

namespace BinarySearchTree
{
    class Program
    {
        /// <summary>
        /// Entry point of the Binary Search Tree application.
        /// Creates a Binary Search Tree, performs insertion,
        /// displays inorder traversal, and searches for a node.
        /// </summary>
        static void Main(string[] args)
        {
            // Create an object of the BSTOperations class.
            BSTOperations bst = new BSTOperations();

            // Insert nodes into the Binary Search Tree.
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);

            // Display the traversal heading.
            Console.WriteLine("Inorder Traversal");

            // Perform inorder traversal of the Binary Search Tree.
            bst.InOrder(bst.Root);

            // Print a blank line for better output formatting.
            Console.WriteLine("\n");

            // Display the value to be searched.
            Console.WriteLine("Searching 60");

            // Search for the specified node and display the result.
            if (bst.Search(bst.Root, 60))
                Console.WriteLine("Node Found");
            else
                Console.WriteLine("Node Not Found");
        }
    }
}