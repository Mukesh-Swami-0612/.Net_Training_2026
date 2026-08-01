using System;

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
    /// Prints the postorder traversal of the binary tree.
    /// </summary>
    
    public static void PostOrder(Node root)
    {
        // Stop recursion if the current node is null.
        if (root == null)
        {
            return;
        }

        // Traverse the left subtree.
        PostOrder(root.left);

        // Traverse the right subtree.
        PostOrder(root.right);

        // Print the current node.
        Console.Write(root.data + " ");
    }

    static void Main(string[] args)
    {
        // Create the sample binary tree.
        Node root = new Node(1);

        root.right = new Node(2);

        root.right.right = new Node(5);

        root.right.right.left = new Node(3);

        root.right.right.left.right = new Node(4);

        root.right.right.right = new Node(6);

        // Display postorder traversal.
        Console.WriteLine("Postorder Traversal:");

        PostOrder(root);

        Console.WriteLine();
    }
}