using System;

// Represents a node of the binary tree.
public class Node
{
    // Stores the node value.
    public int data;

    // Reference to the left child.
    public Node left;

    // Reference to the right child.
    public Node right;

    /// <summary>
    /// Initializes a node with the given value.
    /// </summary>
    public Node(int value)
    {
        data = value;
        left = null;
        right = null;
    }
}

class BinarySearchTree
{
    // Root of the tree.
    public Node root;

    /// <summary>
    /// Inserts a value into the BST.
    /// </summary>
    public Node Insert(Node root, int data)
    {
        // Create a new node if the tree is empty.
        if (root == null)
        {
            return new Node(data);
        }

        // Insert into the left subtree.
        if (data <= root.data)
        {
            root.left = Insert(root.left, data);
        }
        // Insert into the right subtree.
        else
        {
            root.right = Insert(root.right, data);
        }

        return root;
    }

    /// <summary>
    /// Returns the height of the binary tree.
    /// </summary>
    public int GetHeight(Node root)
    {
        // If the node is null, return -1.
        if (root == null)
        {
            return -1;
        }

        // Find the height of the left subtree.
        int leftHeight = GetHeight(root.left);

        // Find the height of the right subtree.
        int rightHeight = GetHeight(root.right);

        // Return the maximum height plus one.
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create the BST.
        BinarySearchTree tree = new BinarySearchTree();

        // Read the number of nodes.
        Console.Write("Enter the number of nodes: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Read the node values.
        Console.WriteLine("Enter the node values:");

        string[] values = Console.ReadLine().Split(' ');

        // Insert each value into the BST.
        for (int i = 0; i < n; i++)
        {
            tree.root = tree.Insert(tree.root, Convert.ToInt32(values[i]));
        }

        // Calculate the height.
        int height = tree.GetHeight(tree.root);

        // Display the result.
        Console.WriteLine("Height of Binary Tree: " + height);
    }
}