using System;

class CircularNode
{
    // Stores the data value of the node.
    public int Data;

    // Stores the reference to the next node in the circular linked list.
    public CircularNode? Next;

    /// <summary>
    /// Initializes a new circular linked list node
    /// with the specified data value.
    /// </summary>
    public CircularNode(int data)
    {
        // Assign the given value to the Data field.
        Data = data;

        // Initialize the next node reference as null.
        Next = null;
    }
}