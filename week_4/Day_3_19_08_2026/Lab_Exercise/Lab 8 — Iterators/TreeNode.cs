using System.Collections;
using System.Collections.Generic;

public class TreeNode<T> : IEnumerable<T>
{
    // Stores the value of this tree node.
    public T Value { get; }

    // Stores the child nodes.
    private List<TreeNode<T>> Children { get; } = new List<TreeNode<T>>();

    // Constructor initializes the node value.
    public TreeNode(T value)
    {
        Value = value;
    }

    // Adds a child node to this node.
    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }

    // Performs depth-first traversal using yield return.
    public IEnumerator<T> GetEnumerator()
    {
        // Return the current node first.
        yield return Value;

        // Visit every child recursively.
        foreach (TreeNode<T> child in Children)
        {
            // Recursively enumerate the child's nodes.
            foreach (T value in child)
            {
                yield return value;
            }
        }
    }

    // Required non-generic IEnumerable implementation.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}