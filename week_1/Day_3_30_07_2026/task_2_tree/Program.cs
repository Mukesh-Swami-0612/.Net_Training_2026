using System;

namespace SimpleTree
{
    class Program
    {
        /// <summary>
        /// Entry point of the Binary Search Tree application.
        /// Creates a binary search tree, inserts nodes,
        /// and performs an inorder traversal to display
        /// the nodes in ascending order.
        /// </summary>
        static void Main(string[] args)
        {
            // Create an object of the TreeOperations class.
            TreeOperations tree = new TreeOperations();

            // Insert nodes into the binary search tree.
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(60);
            tree.Insert(80);

            // Display the traversal heading.
            Console.WriteLine("Inorder Traversal");

            // Perform inorder traversal of the binary search tree.
            tree.InOrder(tree.Root);
        }
    }
}