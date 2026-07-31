using System;
using System.Collections.Generic;

// Represents a node in the B-Tree.
public class BTreeNode
{
    // Stores the keys of the node.
    public List<int> Keys;

    // Stores the child nodes.
    public List<BTreeNode> Children;

    // Indicates whether the node is a leaf node.
    public bool IsLeaf;

    /// <summary>
    /// Initializes a new B-Tree node.
    /// </summary>
    public BTreeNode(bool isLeaf)
    {
        // Initialize the list of keys.
        Keys = new List<int>();

        // Initialize the list of child nodes.
        Children = new List<BTreeNode>();

        // Set whether the node is a leaf.
        IsLeaf = isLeaf;
    }
}

// Performs B-Tree operations.
public class BTree
{
    // Stores the root node of the B-Tree.
    private BTreeNode root;

    // Stores the minimum degree of the B-Tree.
    private int degree;

    // Maximum number of keys allowed in a node.
    private int maxKeys => 2 * degree - 1;

    // Minimum number of keys required in a node.
    private int minKeys => degree - 1;

    /// <summary>
    /// Initializes a new B-Tree with the specified degree.
    /// </summary>
    public BTree(int degree)
    {
        // Set the degree of the tree.
        this.degree = degree;

        // Create an empty root node.
        root = new BTreeNode(true);
    }

    /// <summary>
    /// Inserts a key into the B-Tree.
    /// </summary>
    public void Insert(int key)
    {
        // Check if the root node is full.
        if (root.Keys.Count == maxKeys)
        {
            // Create a new root node.
            BTreeNode newRoot = new BTreeNode(false);

            // Make the old root the first child.
            newRoot.Children.Add(root);

            // Split the full child.
            SplitChild(newRoot, 0);

            // Update the root reference.
            root = newRoot;
        }

        // Insert the key into a non-full node.
        InsertNonFull(root, key);
    }

    /// <summary>
    /// Inserts a key into a node that is not full.
    /// </summary>
    private void InsertNonFull(BTreeNode node, int key)
    {
        // Start from the last key.
        int i = node.Keys.Count - 1;

        // Check if the node is a leaf.
        if (node.IsLeaf)
        {
            // Add a placeholder for the new key.
            node.Keys.Add(0);

            // Shift larger keys one position to the right.
            while (i >= 0 && key < node.Keys[i])
            {
                node.Keys[i + 1] = node.Keys[i];
                i--;
            }

            // Insert the key at the correct position.
            node.Keys[i + 1] = key;
        }
        else
        {
            // Find the correct child for insertion.
            while (i >= 0 && key < node.Keys[i])
                i--;

            i++;

            // Split the child if it is full.
            if (node.Children[i].Keys.Count == maxKeys)
            {
                SplitChild(node, i);

                // Determine which child should receive the key.
                if (key > node.Keys[i])
                    i++;
            }

            // Recursively insert into the appropriate child.
            InsertNonFull(node.Children[i], key);
        }
    }

    /// <summary>
    /// Splits a full child node into two nodes.
    /// </summary>
    private void SplitChild(BTreeNode parent, int index)
    {
        // Get the child node to split.
        BTreeNode child = parent.Children[index];

        // Create a new sibling node.
        BTreeNode newChild = new BTreeNode(child.IsLeaf);

        // Store the middle key.
        int middleKey = child.Keys[degree - 1];

        // Move the last (degree - 1) keys to the new child.
        for (int j = 0; j < degree - 1; j++)
        {
            newChild.Keys.Add(child.Keys[degree + j]);
        }

        // Move child references if the node is not a leaf.
        if (!child.IsLeaf)
        {
            for (int j = 0; j < degree; j++)
            {
                newChild.Children.Add(child.Children[degree + j]);
            }

            // Remove the transferred child references.
            child.Children.RemoveRange(degree, degree);
        }

        // Remove the transferred keys and the middle key.
        child.Keys.RemoveRange(degree - 1, degree);

        // Insert the new child into the parent.
        parent.Children.Insert(index + 1, newChild);

        // Promote the middle key to the parent.
        parent.Keys.Insert(index, middleKey);
    }

    /// <summary>
    /// Displays the keys of the B-Tree using inorder traversal.
    /// </summary>
    public void Traverse()
    {
        // Start traversal from the root.
        Traverse(root);

        // Move to the next line after traversal.
        Console.WriteLine();
    }

    /// <summary>
    /// Recursively traverses the B-Tree.
    /// </summary>
    private void Traverse(BTreeNode node)
    {
        int i;

        // Traverse each key and its left child.
        for (i = 0; i < node.Keys.Count; i++)
        {
            if (!node.IsLeaf)
                Traverse(node.Children[i]);

            // Display the current key.
            Console.Write(node.Keys[i] + " ");
        }

        // Traverse the last child.
        if (!node.IsLeaf)
            Traverse(node.Children[i]);
    }
}

class Program
{
    /// <summary>
    /// Entry point of the B-Tree application.
    /// Creates a B-Tree, inserts keys, and displays
    /// the traversal of the tree.
    /// </summary>
    static void Main()
    {
        // Create a B-Tree with minimum degree 3.
        BTree tree = new BTree(3);

        // Insert keys into the B-Tree.
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(5);
        tree.Insert(6);
        tree.Insert(12);
        tree.Insert(30);
        tree.Insert(7);
        tree.Insert(17);

        // Display the traversal heading.
        Console.WriteLine("B-Tree Traversal:");

        // Display the B-Tree traversal.
        tree.Traverse();
    }
}