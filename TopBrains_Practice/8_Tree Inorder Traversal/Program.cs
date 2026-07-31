using System;

// Represents a node in the binary tree.
public class Node
{
    // Stores the node value.
    public int data;

    // Reference to the left child.
    public Node left;

    // Reference to the right child.
    public Node right;

    /// <summary>
    /// Initializes a new node.
    /// </summary>
    /// <param name="value">Node value.</param>
    public Node(int value)
    {
        data = value;
        left = null;
        right = null;
    }
}

class Solution
{
    /// <summary>
    /// Prints the inorder traversal of the binary tree.
    /// </summary>
    /// <param name="root">Root node of the tree.</param>
    public static void InOrder(Node root)
    {
        // Stop recursion if the node is null.
        if (root == null)
        {
            return;
        }

        // Traverse the left subtree.
        InOrder(root.left);

        // Print the current node.
        Console.Write(root.data + " ");

        // Traverse the right subtree.
        InOrder(root.right);
    }

    static void Main(string[] args)
    {
        // Create the sample tree.
        Node root = new Node(1);

        root.right = new Node(2);

        root.right.right = new Node(5);

        root.right.right.left = new Node(3);

        root.right.right.left.right = new Node(4);

        root.right.right.right = new Node(6);

        // Display the inorder traversal.
        Console.WriteLine("Inorder Traversal:");

        InOrder(root);

        Console.WriteLine();
    }
}